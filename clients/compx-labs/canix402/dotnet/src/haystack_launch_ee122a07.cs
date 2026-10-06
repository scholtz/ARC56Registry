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

namespace Arc56.Generated.compx_labs.canix402.haystack_launch_ee122a07
{


    public class HayLaunchProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public HayLaunchProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class BondingPreview : AVMObjectType
            {
                public ulong InitialPrice { get; set; }

                public ulong FinalPrice { get; set; }

                public ulong TotalBondingRequired { get; set; }

                public ulong InitialMarketCapUsd { get; set; }

                public ulong FinalMarketCapUsd { get; set; }

                public ulong FdvAtLaunch { get; set; }

                public ulong FdvAtBonding { get; set; }

                public ulong TokensForBonding { get; set; }

                public ulong TokensForLp { get; set; }

                public ulong PriceMultiplier { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitialPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInitialPrice.From(InitialPrice);
                    ret.AddRange(vInitialPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFinalPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFinalPrice.From(FinalPrice);
                    ret.AddRange(vFinalPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBondingRequired = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalBondingRequired.From(TotalBondingRequired);
                    ret.AddRange(vTotalBondingRequired.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitialMarketCapUsd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInitialMarketCapUsd.From(InitialMarketCapUsd);
                    ret.AddRange(vInitialMarketCapUsd.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFinalMarketCapUsd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFinalMarketCapUsd.From(FinalMarketCapUsd);
                    ret.AddRange(vFinalMarketCapUsd.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFdvAtLaunch = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFdvAtLaunch.From(FdvAtLaunch);
                    ret.AddRange(vFdvAtLaunch.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFdvAtBonding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFdvAtBonding.From(FdvAtBonding);
                    ret.AddRange(vFdvAtBonding.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokensForBonding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTokensForBonding.From(TokensForBonding);
                    ret.AddRange(vTokensForBonding.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokensForLp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTokensForLp.From(TokensForLp);
                    ret.AddRange(vTokensForLp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPriceMultiplier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPriceMultiplier.From(PriceMultiplier);
                    ret.AddRange(vPriceMultiplier.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BondingPreview Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BondingPreview();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitialPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInitialPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInitialPrice = vInitialPrice.ToValue();
                    if (valueInitialPrice is ulong vInitialPriceValue) { ret.InitialPrice = vInitialPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFinalPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFinalPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFinalPrice = vFinalPrice.ToValue();
                    if (valueFinalPrice is ulong vFinalPriceValue) { ret.FinalPrice = vFinalPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBondingRequired = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalBondingRequired.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalBondingRequired = vTotalBondingRequired.ToValue();
                    if (valueTotalBondingRequired is ulong vTotalBondingRequiredValue) { ret.TotalBondingRequired = vTotalBondingRequiredValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitialMarketCapUsd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInitialMarketCapUsd.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInitialMarketCapUsd = vInitialMarketCapUsd.ToValue();
                    if (valueInitialMarketCapUsd is ulong vInitialMarketCapUsdValue) { ret.InitialMarketCapUsd = vInitialMarketCapUsdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFinalMarketCapUsd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFinalMarketCapUsd.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFinalMarketCapUsd = vFinalMarketCapUsd.ToValue();
                    if (valueFinalMarketCapUsd is ulong vFinalMarketCapUsdValue) { ret.FinalMarketCapUsd = vFinalMarketCapUsdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFdvAtLaunch = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFdvAtLaunch.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFdvAtLaunch = vFdvAtLaunch.ToValue();
                    if (valueFdvAtLaunch is ulong vFdvAtLaunchValue) { ret.FdvAtLaunch = vFdvAtLaunchValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFdvAtBonding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFdvAtBonding.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFdvAtBonding = vFdvAtBonding.ToValue();
                    if (valueFdvAtBonding is ulong vFdvAtBondingValue) { ret.FdvAtBonding = vFdvAtBondingValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokensForBonding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTokensForBonding.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTokensForBonding = vTokensForBonding.ToValue();
                    if (valueTokensForBonding is ulong vTokensForBondingValue) { ret.TokensForBonding = vTokensForBondingValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokensForLp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTokensForLp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTokensForLp = vTokensForLp.ToValue();
                    if (valueTokensForLp is ulong vTokensForLpValue) { ret.TokensForLp = vTokensForLpValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPriceMultiplier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPriceMultiplier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePriceMultiplier = vPriceMultiplier.ToValue();
                    if (valuePriceMultiplier is ulong vPriceMultiplierValue) { ret.PriceMultiplier = vPriceMultiplierValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BondingPreview);
                }
                public bool Equals(BondingPreview? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BondingPreview left, BondingPreview right)
                {
                    return EqualityComparer<BondingPreview>.Default.Equals(left, right);
                }
                public static bool operator !=(BondingPreview left, BondingPreview right)
                {
                    return !(left == right);
                }

            }

            public class PoolFees : AVMObjectType
            {
                public ulong TokenAmount { get; set; }

                public ulong BondingAmount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokenAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTokenAmount.From(TokenAmount);
                    ret.AddRange(vTokenAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBondingAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBondingAmount.From(BondingAmount);
                    ret.AddRange(vBondingAmount.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PoolFees Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PoolFees();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokenAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTokenAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTokenAmount = vTokenAmount.ToValue();
                    if (valueTokenAmount is ulong vTokenAmountValue) { ret.TokenAmount = vTokenAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBondingAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBondingAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBondingAmount = vBondingAmount.ToValue();
                    if (valueBondingAmount is ulong vBondingAmountValue) { ret.BondingAmount = vBondingAmountValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PoolFees);
                }
                public bool Equals(PoolFees? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PoolFees left, PoolFees right)
                {
                    return EqualityComparer<PoolFees>.Default.Equals(left, right);
                }
                public static bool operator !=(PoolFees left, PoolFees right)
                {
                    return !(left == right);
                }

            }

            public class TokenInfo : AVMObjectType
            {
                public byte[] Version { get; set; }

                public ulong TokenNum { get; set; }

                public Algorand.Address TokenCreator { get; set; }

                public ulong BondingTokenId { get; set; }

                public ulong VirtualTokenReserves { get; set; }

                public ulong VirtualBondingReserves { get; set; }

                public ulong RealTokenReserves { get; set; }

                public ulong RealBondingReserves { get; set; }

                public ulong InitialRealTokenReserves { get; set; }

                public ulong LaunchQ { get; set; }

                public ulong FeeBpsPlatform { get; set; }

                public ulong FeeBpsCreator { get; set; }

                public ulong BondingTargetUsd { get; set; }

                public ulong TokenPriceMultiplier { get; set; }

                public ulong BondingOn { get; set; }

                public ulong AssetId { get; set; }

                public byte[] Symbol { get; set; }

                public byte[] Name { get; set; }

                public byte[] AssetUrl { get; set; }

                public byte[] Description { get; set; }

                public byte[] SocialWebsite { get; set; }

                public byte[] SocialX { get; set; }

                public byte[] SocialTelegram { get; set; }

                public byte[] SocialDiscord { get; set; }

                public ulong PoolAppId { get; set; }

                public ulong LpTokenId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1]");
                    vVersion.From(Version);
                    ret.AddRange(vVersion.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokenNum = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTokenNum.From(TokenNum);
                    ret.AddRange(vTokenNum.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokenCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vTokenCreator.From(TokenCreator);
                    ret.AddRange(vTokenCreator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBondingTokenId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBondingTokenId.From(BondingTokenId);
                    ret.AddRange(vBondingTokenId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVirtualTokenReserves = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVirtualTokenReserves.From(VirtualTokenReserves);
                    ret.AddRange(vVirtualTokenReserves.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVirtualBondingReserves = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVirtualBondingReserves.From(VirtualBondingReserves);
                    ret.AddRange(vVirtualBondingReserves.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRealTokenReserves = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRealTokenReserves.From(RealTokenReserves);
                    ret.AddRange(vRealTokenReserves.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRealBondingReserves = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRealBondingReserves.From(RealBondingReserves);
                    ret.AddRange(vRealBondingReserves.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitialRealTokenReserves = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInitialRealTokenReserves.From(InitialRealTokenReserves);
                    ret.AddRange(vInitialRealTokenReserves.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLaunchQ = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLaunchQ.From(LaunchQ);
                    ret.AddRange(vLaunchQ.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeBpsPlatform = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFeeBpsPlatform.From(FeeBpsPlatform);
                    ret.AddRange(vFeeBpsPlatform.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeBpsCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFeeBpsCreator.From(FeeBpsCreator);
                    ret.AddRange(vFeeBpsCreator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBondingTargetUsd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBondingTargetUsd.From(BondingTargetUsd);
                    ret.AddRange(vBondingTargetUsd.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokenPriceMultiplier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTokenPriceMultiplier.From(TokenPriceMultiplier);
                    ret.AddRange(vTokenPriceMultiplier.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBondingOn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBondingOn.From(BondingOn);
                    ret.AddRange(vBondingOn.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetId.From(AssetId);
                    ret.AddRange(vAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSymbol = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[8]");
                    vSymbol.From(Symbol);
                    ret.AddRange(vSymbol.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vName.From(Name);
                    ret.AddRange(vName.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    vAssetUrl.From(AssetUrl);
                    ret.AddRange(vAssetUrl.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    vDescription.From(Description);
                    ret.AddRange(vDescription.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSocialWebsite = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[256]");
                    vSocialWebsite.From(SocialWebsite);
                    ret.AddRange(vSocialWebsite.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSocialX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    vSocialX.From(SocialX);
                    ret.AddRange(vSocialX.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSocialTelegram = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    vSocialTelegram.From(SocialTelegram);
                    ret.AddRange(vSocialTelegram.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSocialDiscord = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    vSocialDiscord.From(SocialDiscord);
                    ret.AddRange(vSocialDiscord.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPoolAppId.From(PoolAppId);
                    ret.AddRange(vPoolAppId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLpTokenId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLpTokenId.From(LpTokenId);
                    ret.AddRange(vLpTokenId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TokenInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TokenInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1]");
                    count = vVersion.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVersion = vVersion.ToValue();
                    if (valueVersion is byte[] vVersionValue) { ret.Version = vVersionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokenNum = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTokenNum.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTokenNum = vTokenNum.ToValue();
                    if (valueTokenNum is ulong vTokenNumValue) { ret.TokenNum = vTokenNumValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokenCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vTokenCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTokenCreator = vTokenCreator.ToValue();
                    if (valueTokenCreator is Algorand.Address vTokenCreatorValue) { ret.TokenCreator = vTokenCreatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBondingTokenId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBondingTokenId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBondingTokenId = vBondingTokenId.ToValue();
                    if (valueBondingTokenId is ulong vBondingTokenIdValue) { ret.BondingTokenId = vBondingTokenIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVirtualTokenReserves = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVirtualTokenReserves.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVirtualTokenReserves = vVirtualTokenReserves.ToValue();
                    if (valueVirtualTokenReserves is ulong vVirtualTokenReservesValue) { ret.VirtualTokenReserves = vVirtualTokenReservesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVirtualBondingReserves = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVirtualBondingReserves.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVirtualBondingReserves = vVirtualBondingReserves.ToValue();
                    if (valueVirtualBondingReserves is ulong vVirtualBondingReservesValue) { ret.VirtualBondingReserves = vVirtualBondingReservesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRealTokenReserves = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRealTokenReserves.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRealTokenReserves = vRealTokenReserves.ToValue();
                    if (valueRealTokenReserves is ulong vRealTokenReservesValue) { ret.RealTokenReserves = vRealTokenReservesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRealBondingReserves = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRealBondingReserves.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRealBondingReserves = vRealBondingReserves.ToValue();
                    if (valueRealBondingReserves is ulong vRealBondingReservesValue) { ret.RealBondingReserves = vRealBondingReservesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitialRealTokenReserves = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInitialRealTokenReserves.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInitialRealTokenReserves = vInitialRealTokenReserves.ToValue();
                    if (valueInitialRealTokenReserves is ulong vInitialRealTokenReservesValue) { ret.InitialRealTokenReserves = vInitialRealTokenReservesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLaunchQ = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLaunchQ.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLaunchQ = vLaunchQ.ToValue();
                    if (valueLaunchQ is ulong vLaunchQValue) { ret.LaunchQ = vLaunchQValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeBpsPlatform = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFeeBpsPlatform.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFeeBpsPlatform = vFeeBpsPlatform.ToValue();
                    if (valueFeeBpsPlatform is ulong vFeeBpsPlatformValue) { ret.FeeBpsPlatform = vFeeBpsPlatformValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeBpsCreator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFeeBpsCreator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFeeBpsCreator = vFeeBpsCreator.ToValue();
                    if (valueFeeBpsCreator is ulong vFeeBpsCreatorValue) { ret.FeeBpsCreator = vFeeBpsCreatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBondingTargetUsd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBondingTargetUsd.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBondingTargetUsd = vBondingTargetUsd.ToValue();
                    if (valueBondingTargetUsd is ulong vBondingTargetUsdValue) { ret.BondingTargetUsd = vBondingTargetUsdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokenPriceMultiplier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTokenPriceMultiplier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTokenPriceMultiplier = vTokenPriceMultiplier.ToValue();
                    if (valueTokenPriceMultiplier is ulong vTokenPriceMultiplierValue) { ret.TokenPriceMultiplier = vTokenPriceMultiplierValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBondingOn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBondingOn.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBondingOn = vBondingOn.ToValue();
                    if (valueBondingOn is ulong vBondingOnValue) { ret.BondingOn = vBondingOnValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is ulong vAssetIdValue) { ret.AssetId = vAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSymbol = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[8]");
                    count = vSymbol.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSymbol = vSymbol.ToValue();
                    if (valueSymbol is byte[] vSymbolValue) { ret.Symbol = vSymbolValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vName.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueName = vName.ToValue();
                    if (valueName is byte[] vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[96]");
                    count = vAssetUrl.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetUrl = vAssetUrl.ToValue();
                    if (valueAssetUrl is byte[] vAssetUrlValue) { ret.AssetUrl = vAssetUrlValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    count = vDescription.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDescription = vDescription.ToValue();
                    if (valueDescription is byte[] vDescriptionValue) { ret.Description = vDescriptionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSocialWebsite = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[256]");
                    count = vSocialWebsite.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSocialWebsite = vSocialWebsite.ToValue();
                    if (valueSocialWebsite is byte[] vSocialWebsiteValue) { ret.SocialWebsite = vSocialWebsiteValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSocialX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    count = vSocialX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSocialX = vSocialX.ToValue();
                    if (valueSocialX is byte[] vSocialXValue) { ret.SocialX = vSocialXValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSocialTelegram = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    count = vSocialTelegram.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSocialTelegram = vSocialTelegram.ToValue();
                    if (valueSocialTelegram is byte[] vSocialTelegramValue) { ret.SocialTelegram = vSocialTelegramValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSocialDiscord = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    count = vSocialDiscord.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSocialDiscord = vSocialDiscord.ToValue();
                    if (valueSocialDiscord is byte[] vSocialDiscordValue) { ret.SocialDiscord = vSocialDiscordValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPoolAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPoolAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePoolAppId = vPoolAppId.ToValue();
                    if (valuePoolAppId is ulong vPoolAppIdValue) { ret.PoolAppId = vPoolAppIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLpTokenId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLpTokenId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLpTokenId = vLpTokenId.ToValue();
                    if (valueLpTokenId is ulong vLpTokenIdValue) { ret.LpTokenId = vLpTokenIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TokenInfo);
                }
                public bool Equals(TokenInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TokenInfo left, TokenInfo right)
                {
                    return EqualityComparer<TokenInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(TokenInfo left, TokenInfo right)
                {
                    return !(left == right);
                }

            }

            public class UserHoldingKey : AVMObjectType
            {
                public Algorand.Address Address { get; set; }

                public ulong TokenNum { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAddress.From(Address);
                    ret.AddRange(vAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokenNum = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTokenNum.From(TokenNum);
                    ret.AddRange(vTokenNum.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static UserHoldingKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new UserHoldingKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddress = vAddress.ToValue();
                    if (valueAddress is Algorand.Address vAddressValue) { ret.Address = vAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokenNum = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTokenNum.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTokenNum = vTokenNum.ToValue();
                    if (valueTokenNum is ulong vTokenNumValue) { ret.TokenNum = vTokenNumValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as UserHoldingKey);
                }
                public bool Equals(UserHoldingKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(UserHoldingKey left, UserHoldingKey right)
                {
                    return EqualityComparer<UserHoldingKey>.Default.Equals(left, right);
                }
                public static bool operator !=(UserHoldingKey left, UserHoldingKey right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="adminToken"> </param>
        /// <param name="usdc"> </param>
        /// <param name="hay"> </param>
        /// <param name="oracleAppId"> </param>
        /// <param name="bondingUsd"> </param>
        /// <param name="priceMultiplier"> </param>
        /// <param name="createSupply"> </param>
        /// <param name="feeBpsPlatform"> </param>
        /// <param name="feeBpsCreator"> </param>
        /// <param name="platformTreasury"> </param>
        public async Task CreateApplication(ulong adminToken, ulong usdc, ulong hay, ulong oracleAppId, ulong bondingUsd, ulong priceMultiplier, ulong createSupply, ulong feeBpsPlatform, ulong feeBpsCreator, Algorand.Address platformTreasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 161, 34, 241 };
            var adminTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); adminTokenAbi.From(adminToken);
            var usdcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdcAbi.From(usdc);
            var hayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hayAbi.From(hay);
            var oracleAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oracleAppIdAbi.From(oracleAppId);
            var bondingUsdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingUsdAbi.From(bondingUsd);
            var priceMultiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMultiplierAbi.From(priceMultiplier);
            var createSupplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); createSupplyAbi.From(createSupply);
            var feeBpsPlatformAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsPlatformAbi.From(feeBpsPlatform);
            var feeBpsCreatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsCreatorAbi.From(feeBpsCreator);
            var platformTreasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); platformTreasuryAbi.From(platformTreasury);

            var result = await base.CallApp(new List<object> { abiHandle, adminTokenAbi, usdcAbi, hayAbi, oracleAppIdAbi, bondingUsdAbi, priceMultiplierAbi, createSupplyAbi, feeBpsPlatformAbi, feeBpsCreatorAbi, platformTreasuryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(ulong adminToken, ulong usdc, ulong hay, ulong oracleAppId, ulong bondingUsd, ulong priceMultiplier, ulong createSupply, ulong feeBpsPlatform, ulong feeBpsCreator, Algorand.Address platformTreasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 161, 34, 241 };
            var adminTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); adminTokenAbi.From(adminToken);
            var usdcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdcAbi.From(usdc);
            var hayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hayAbi.From(hay);
            var oracleAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oracleAppIdAbi.From(oracleAppId);
            var bondingUsdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingUsdAbi.From(bondingUsd);
            var priceMultiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMultiplierAbi.From(priceMultiplier);
            var createSupplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); createSupplyAbi.From(createSupply);
            var feeBpsPlatformAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsPlatformAbi.From(feeBpsPlatform);
            var feeBpsCreatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsCreatorAbi.From(feeBpsCreator);
            var platformTreasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); platformTreasuryAbi.From(platformTreasury);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminTokenAbi, usdcAbi, hayAbi, oracleAppIdAbi, bondingUsdAbi, priceMultiplierAbi, createSupplyAbi, feeBpsPlatformAbi, feeBpsCreatorAbi, platformTreasuryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task UpdateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 247, 101, 51 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opts the application account into USDC, which is needed for the updateTokenMetadata
        ///fee regardless of which assets are supported for bonding.
        ///
        ///Bonding assets - including USDC and HAY - are opted into separately via
        ///optInBondingAsset(), so this no longer hardcodes the supported set.
        ///</summary>
        public async Task Init(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 241, 71, 72 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Init_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 241, 71, 72 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Configure Pact factory and Bonfire app IDs for pool creation.
        ///Must be called before any token can complete bonding.
        ///
        ///The Pact V2 vault is not configured separately: it is read from the factory's
        ///`vault_app` global, the same source every pool the factory deploys trusts. A nonzero
        ///factory must therefore have one - this rejects e.g. a Pact V1 factory id, which would
        ///otherwise let launches through that could never bond.
        ///</summary>
        /// <param name="pactFactoryAppId">- The Pact V2 pool factory application ID (mainnet 3656084442), 0 = bond without a pool </param>
        /// <param name="bonfireAppId">- The ARC-54 Bonfire application ID for LP burning </param>
        public async Task ConfigureApps(ulong pactFactoryAppId, ulong bonfireAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 72, 241, 114 };
            var pactFactoryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pactFactoryAppIdAbi.From(pactFactoryAppId);
            var bonfireAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bonfireAppIdAbi.From(bonfireAppId);

            var result = await base.CallApp(new List<object> { abiHandle, pactFactoryAppIdAbi, bonfireAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ConfigureApps_Transactions(ulong pactFactoryAppId, ulong bonfireAppId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 72, 241, 114 };
            var pactFactoryAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pactFactoryAppIdAbi.From(pactFactoryAppId);
            var bonfireAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bonfireAppIdAbi.From(bonfireAppId);

            return await base.MakeTransactionList(new List<object> { abiHandle, pactFactoryAppIdAbi, bonfireAppIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newTreasury"> </param>
        public async Task UpdateTreasury(Algorand.Address newTreasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 194, 116, 175 };
            var newTreasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newTreasuryAbi.From(newTreasury);

            var result = await base.CallApp(new List<object> { abiHandle, newTreasuryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateTreasury_Transactions(Algorand.Address newTreasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 194, 116, 175 };
            var newTreasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newTreasuryAbi.From(newTreasury);

            return await base.MakeTransactionList(new List<object> { abiHandle, newTreasuryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opts the app into an ASA so it can be used as a bonding token.
        ///
        ///The opt-in doubles as the allowlist: launchToken() only accepts assets this app
        ///holds, so there is no separate registry to maintain. The one method here open to the
        ///admin NFT as well as the creator - the two halves of adding a bonding asset have to
        ///stay aligned, and the other half (registerAsset + setAssetPrices on the oracle) is
        ///admin-gated with the same token. It is still a real risk surface - see the
        ///freeze/clawback check below.
        ///
        ///The asset must also be registered and priced in the oracle before it can be launched
        ///against; this method deliberately does not check that, so the two can be set up in
        ///either order.
        ///</summary>
        /// <param name="asset">- The ASA to support as a bonding token. </param>
        /// <param name="mbrPayment">- Payment covering the 0.1 ALGO opt-in MBR. </param>
        public async Task OptInBondingAsset(PaymentTransaction mbrPayment, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 106, 24, 95, 55 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInBondingAsset_Transactions(PaymentTransaction mbrPayment, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 106, 24, 95, 55 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bondingUsd"> </param>
        /// <param name="priceMultiplier"> </param>
        /// <param name="createSupply"> </param>
        /// <param name="feeBpsPlatform"> </param>
        /// <param name="feeBpsCreator"> </param>
        public async Task UpdateLaunchParams(ulong bondingUsd, ulong priceMultiplier, ulong createSupply, ulong feeBpsPlatform, ulong feeBpsCreator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 92, 175, 13 };
            var bondingUsdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingUsdAbi.From(bondingUsd);
            var priceMultiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMultiplierAbi.From(priceMultiplier);
            var createSupplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); createSupplyAbi.From(createSupply);
            var feeBpsPlatformAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsPlatformAbi.From(feeBpsPlatform);
            var feeBpsCreatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsCreatorAbi.From(feeBpsCreator);

            var result = await base.CallApp(new List<object> { abiHandle, bondingUsdAbi, priceMultiplierAbi, createSupplyAbi, feeBpsPlatformAbi, feeBpsCreatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateLaunchParams_Transactions(ulong bondingUsd, ulong priceMultiplier, ulong createSupply, ulong feeBpsPlatform, ulong feeBpsCreator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 92, 175, 13 };
            var bondingUsdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingUsdAbi.From(bondingUsd);
            var priceMultiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMultiplierAbi.From(priceMultiplier);
            var createSupplyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); createSupplyAbi.From(createSupply);
            var feeBpsPlatformAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsPlatformAbi.From(feeBpsPlatform);
            var feeBpsCreatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsCreatorAbi.From(feeBpsCreator);

            return await base.MakeTransactionList(new List<object> { abiHandle, bondingUsdAbi, priceMultiplierAbi, createSupplyAbi, feeBpsPlatformAbi, feeBpsCreatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update token metadata (description and social fields).
        ///Can only be called by the contract creator or the token creator.
        ///Requires a 30 USDC payment (free for contract creator).
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="tokenNum"> </param>
        /// <param name="description"> </param>
        /// <param name="socialWebsite"> </param>
        /// <param name="socialX"> </param>
        /// <param name="socialTelegram"> </param>
        /// <param name="socialDiscord"> </param>
        public async Task UpdateTokenMetadata(AssetTransferTransaction payment, ulong tokenNum, string description, string socialWebsite, string socialX, string socialTelegram, string socialDiscord, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 8, 218, 87, 127 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var socialWebsiteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialWebsiteAbi.From(socialWebsite);
            var socialXAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialXAbi.From(socialX);
            var socialTelegramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialTelegramAbi.From(socialTelegram);
            var socialDiscordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialDiscordAbi.From(socialDiscord);

            var result = await base.CallApp(new List<object> { abiHandle, payment, tokenNumAbi, descriptionAbi, socialWebsiteAbi, socialXAbi, socialTelegramAbi, socialDiscordAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateTokenMetadata_Transactions(AssetTransferTransaction payment, ulong tokenNum, string description, string socialWebsite, string socialX, string socialTelegram, string socialDiscord, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 8, 218, 87, 127 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var socialWebsiteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialWebsiteAbi.From(socialWebsite);
            var socialXAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialXAbi.From(socialX);
            var socialTelegramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialTelegramAbi.From(socialTelegram);
            var socialDiscordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialDiscordAbi.From(socialDiscord);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, tokenNumAbi, descriptionAbi, socialWebsiteAbi, socialXAbi, socialTelegramAbi, socialDiscordAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///No-op method used to add extra transactions to a group for increased opcode budget.
        ///Callers can include multiple `gas()` calls in a transaction group when complex
        ///operations require more than the single-transaction opcode limit.
        ///</summary>
        public async Task Gas(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 114, 202, 157 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Gas_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 114, 202, 157 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> MbrToLaunchToken(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 88, 204, 54 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MbrToLaunchToken_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 88, 204, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tokenNum"> </param>
        public async Task<ulong> MbrToBuy(ulong tokenNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 209, 174, 54 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);

            var result = await base.SimApp(new List<object> { abiHandle, tokenNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MbrToBuy_Transactions(ulong tokenNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 209, 174, 54 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the MBR needed for launchTokenThenBuy.
        ///Includes MBR for launch (tokenMap box, assetMap box, ASA creation) plus
        ///MBR for the user balance box (first buy).
        ///</summary>
        public async Task<ulong> MbrToLaunchTokenThenBuy(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 29, 205, 170 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MbrToLaunchTokenThenBuy_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 29, 205, 170 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculates the tokens received for a given bonding token amount at launch-time prices.
        ///This is a buy preview that mirrors launchTokenThenBuy() exactly (fees are deducted first).
        ///
        ///Uses the same reserve calculation logic as launchToken() to compute what the
        ///initial virtual reserves would be, then applies constant product formula.
        ///</summary>
        /// <param name="bondingToken">- The bonding token asset (0 = ALGO). </param>
        /// <param name="bondingIn">- The amount of bonding token to spend. </param>
        /// <param name="targetBondingUsd">- Custom bonding target in micro-USD (0 = use contract default). </param>
        /// <param name="priceMultiplier">- Custom price multiplier (9 digits) (0 = use contract default). </param>
        public async Task<ulong> TokensReceivedForBuyAtLaunch(ulong bondingToken, ulong bondingIn, ulong targetBondingUsd, ulong priceMultiplier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 137, 9, 121 };
            var bondingTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingTokenAbi.From(bondingToken);
            var bondingInAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingInAbi.From(bondingIn);
            var targetBondingUsdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetBondingUsdAbi.From(targetBondingUsd);
            var priceMultiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMultiplierAbi.From(priceMultiplier);

            var result = await base.SimApp(new List<object> { abiHandle, bondingTokenAbi, bondingInAbi, targetBondingUsdAbi, priceMultiplierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TokensReceivedForBuyAtLaunch_Transactions(ulong bondingToken, ulong bondingIn, ulong targetBondingUsd, ulong priceMultiplier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 137, 9, 121 };
            var bondingTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingTokenAbi.From(bondingToken);
            var bondingInAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingInAbi.From(bondingIn);
            var targetBondingUsdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetBondingUsdAbi.From(targetBondingUsd);
            var priceMultiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMultiplierAbi.From(priceMultiplier);

            return await base.MakeTransactionList(new List<object> { abiHandle, bondingTokenAbi, bondingInAbi, targetBondingUsdAbi, priceMultiplierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the holdings of a specific user for a given token.
        ///</summary>
        /// <param name="tokenNum">- The sequential token number assigned at launch time. </param>
        /// <param name="address">- The address of the user whose holdings are being queried. </param>
        public async Task<ulong> UserHoldings(ulong tokenNum, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 248, 146, 239 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.SimApp(new List<object> { abiHandle, tokenNumAbi, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> UserHoldings_Transactions(ulong tokenNum, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 248, 146, 239 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenNumAbi, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the USD price of a bonding token from the HaystackOracle price registry.
        ///
        ///Reads the oracle's `assetPrices` box directly with `app_box_get` (AVM 13) - a plain
        ///opcode, so this costs no inner transaction and stays usable from
        ///</summary>
        /// <param name="bondingToken">- The bonding token to price. Asset id 0 means ALGO. </param>
        public async Task<ulong> BondingTokenPrice(ulong bondingToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 182, 128, 48 };
            var bondingTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingTokenAbi.From(bondingToken);

            var result = await base.SimApp(new List<object> { abiHandle, bondingTokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BondingTokenPrice_Transactions(ulong bondingToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 182, 128, 48 };
            var bondingTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingTokenAbi.From(bondingToken);

            return await base.MakeTransactionList(new List<object> { abiHandle, bondingTokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Whether a token can be launched against right now - the question a launch UI needs
        ///answered, and the one the oracle cannot answer on its own.
        ///
        ///The oracle's assetPrices boxes (readable off-chain via the generated client's
        ///`assetPrices.getMap()`) only say an asset is registered and priced. They do not know
        ///whether THIS app is opted into it, and an asset can legitimately be priced but not
        ///opted in. This combines both, plus price freshness, into one non-throwing answer, so
        ///callers can probe candidates without catching simulate failures.
        ///
        ///Shares its predicates with the launch path deliberately - isOptedInBondingToken(),
        ///isInPactVault() and readOraclePrice() are the same calls launchToken() makes. If this
        ///returned true while launchToken() rejected, the UI would offer launches that always fail.
        ///</summary>
        /// <param name="bondingToken">- The asset to test. Asset id 0 means ALGO. </param>
        public async Task<bool> IsBondingTokenSupported(ulong bondingToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 74, 61, 78 };
            var bondingTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingTokenAbi.From(bondingToken);

            var result = await base.SimApp(new List<object> { abiHandle, bondingTokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsBondingTokenSupported_Transactions(ulong bondingToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 74, 61, 78 };
            var bondingTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingTokenAbi.From(bondingToken);

            return await base.MakeTransactionList(new List<object> { abiHandle, bondingTokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Launches a new token with the specified metadata and parameters.
        ///</summary>
        /// <param name="mbrPayment">- Prior payment transaction covering MBR costs (must equal mbrToLaunchToken amount). </param>
        /// <param name="symbol">- The symbol of the token, represented as a fixed-length byte array. </param>
        /// <param name="name">- The name of the token, represented as a fixed-length byte array. </param>
        /// <param name="assetUrl">- A URL pointing to the asset's information or metadata, represented as a fixed-length byte array. </param>
        /// <param name="description">- A textual description of the token, represented as a fixed-length byte array. </param>
        /// <param name="socialWebsite">- The URL of the token's official website, represented as a fixed-length byte array. </param>
        /// <param name="socialX">- The username or handle for the token's presence on "X" (formerly Twitter), represented as a fixed-length byte array. </param>
        /// <param name="socialTelegram">- The username or URL for the token's Telegram group or channel, represented as a fixed-length byte array. </param>
        /// <param name="socialDiscord">- The URL or identifier for the token's Discord server, represented as a fixed-length byte array. </param>
        /// <param name="targetBondingUsd">- Custom bonding target in micro-USD (0 = use contract default). Must be >= contract minimum if specified. </param>
        /// <param name="priceMultiplier">- Custom price multiplier (9 digits - 20,000,000,000 = 20x) (0 = use contract default). Must be >= contract minimum if specified. </param>
        /// <param name="bondingToken">- The bonding token asset (see isBondingTokenSupported; 0 = ALGO). </param>
        public async Task<ulong> LaunchToken(PaymentTransaction mbrPayment, string symbol, string name, string assetUrl, string description, string socialWebsite, string socialX, string socialTelegram, string socialDiscord, ulong targetBondingUsd, ulong priceMultiplier, ulong bondingToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 99, 109, 141, 26 };
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbolAbi.From(symbol);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var assetUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetUrlAbi.From(assetUrl);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var socialWebsiteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialWebsiteAbi.From(socialWebsite);
            var socialXAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialXAbi.From(socialX);
            var socialTelegramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialTelegramAbi.From(socialTelegram);
            var socialDiscordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialDiscordAbi.From(socialDiscord);
            var targetBondingUsdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetBondingUsdAbi.From(targetBondingUsd);
            var priceMultiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMultiplierAbi.From(priceMultiplier);
            var bondingTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingTokenAbi.From(bondingToken);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, symbolAbi, nameAbi, assetUrlAbi, descriptionAbi, socialWebsiteAbi, socialXAbi, socialTelegramAbi, socialDiscordAbi, targetBondingUsdAbi, priceMultiplierAbi, bondingTokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> LaunchToken_Transactions(PaymentTransaction mbrPayment, string symbol, string name, string assetUrl, string description, string socialWebsite, string socialX, string socialTelegram, string socialDiscord, ulong targetBondingUsd, ulong priceMultiplier, ulong bondingToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 99, 109, 141, 26 };
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbolAbi.From(symbol);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var assetUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetUrlAbi.From(assetUrl);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var socialWebsiteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialWebsiteAbi.From(socialWebsite);
            var socialXAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialXAbi.From(socialX);
            var socialTelegramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialTelegramAbi.From(socialTelegram);
            var socialDiscordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialDiscordAbi.From(socialDiscord);
            var targetBondingUsdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetBondingUsdAbi.From(targetBondingUsd);
            var priceMultiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMultiplierAbi.From(priceMultiplier);
            var bondingTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingTokenAbi.From(bondingToken);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, symbolAbi, nameAbi, assetUrlAbi, descriptionAbi, socialWebsiteAbi, socialXAbi, socialTelegramAbi, socialDiscordAbi, targetBondingUsdAbi, priceMultiplierAbi, bondingTokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Launches a token with the given parameters and then performs an initial purchase of the token using the provided payment transaction.
        ///Use mbrToLaunchTokenThenBuy() to get the required MBR amount.
        ///</summary>
        /// <param name="mbrPayment">- The payment transaction covering both launch and first buy MBR costs. </param>
        /// <param name="buyPayment">- The asset transfer transaction object used to perform the token purchase. </param>
        /// <param name="symbol">- The symbol of the token to be created. </param>
        /// <param name="name">- The name of the token to be created. </param>
        /// <param name="assetUrl">- The URL that provides additional information or metadata about the token. </param>
        /// <param name="description">- A detailed description of the token being created. </param>
        /// <param name="socialWebsite">- The URL of the token's official website. </param>
        /// <param name="socialX">- The link to the token's profile or handle on platform X (e.g., Twitter). </param>
        /// <param name="socialTelegram">- The link to the token's official Telegram group. </param>
        /// <param name="socialDiscord">- The link to the token's official Discord server. </param>
        /// <param name="targetBondingUsd">- Custom bonding target in micro-USD (0 = use contract default). Must be >= contract minimum if specified. </param>
        /// <param name="priceMultiplier">- Custom price multiplier (9 digits - 20,000,000,000 = 20x) (0 = use contract default). Must be >= contract minimum if specified. </param>
        /// <param name="bondingToken">- The bonding token asset (see isBondingTokenSupported; 0 = ALGO). </param>
        public async Task<ulong> LaunchTokenThenBuy(PaymentTransaction mbrPayment, AssetTransferTransaction buyPayment, string symbol, string name, string assetUrl, string description, string socialWebsite, string socialX, string socialTelegram, string socialDiscord, ulong targetBondingUsd, ulong priceMultiplier, ulong bondingToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, buyPayment });
            byte[] abiHandle = { 215, 238, 231, 219 };
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbolAbi.From(symbol);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var assetUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetUrlAbi.From(assetUrl);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var socialWebsiteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialWebsiteAbi.From(socialWebsite);
            var socialXAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialXAbi.From(socialX);
            var socialTelegramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialTelegramAbi.From(socialTelegram);
            var socialDiscordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialDiscordAbi.From(socialDiscord);
            var targetBondingUsdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetBondingUsdAbi.From(targetBondingUsd);
            var priceMultiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMultiplierAbi.From(priceMultiplier);
            var bondingTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingTokenAbi.From(bondingToken);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, buyPayment, symbolAbi, nameAbi, assetUrlAbi, descriptionAbi, socialWebsiteAbi, socialXAbi, socialTelegramAbi, socialDiscordAbi, targetBondingUsdAbi, priceMultiplierAbi, bondingTokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> LaunchTokenThenBuy_Transactions(PaymentTransaction mbrPayment, AssetTransferTransaction buyPayment, string symbol, string name, string assetUrl, string description, string socialWebsite, string socialX, string socialTelegram, string socialDiscord, ulong targetBondingUsd, ulong priceMultiplier, ulong bondingToken, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, buyPayment });
            byte[] abiHandle = { 215, 238, 231, 219 };
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbolAbi.From(symbol);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var assetUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetUrlAbi.From(assetUrl);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var socialWebsiteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialWebsiteAbi.From(socialWebsite);
            var socialXAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialXAbi.From(socialX);
            var socialTelegramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialTelegramAbi.From(socialTelegram);
            var socialDiscordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialDiscordAbi.From(socialDiscord);
            var targetBondingUsdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetBondingUsdAbi.From(targetBondingUsd);
            var priceMultiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMultiplierAbi.From(priceMultiplier);
            var bondingTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingTokenAbi.From(bondingToken);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, buyPayment, symbolAbi, nameAbi, assetUrlAbi, descriptionAbi, socialWebsiteAbi, socialXAbi, socialTelegramAbi, socialDiscordAbi, targetBondingUsdAbi, priceMultiplierAbi, bondingTokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the information associated with a specific token by its Asset ID.
        ///Note: This only works after the first buy, when the assetMap is populated.
        ///Use tokenInfoByNum() for tokens that haven't been bought yet.
        ///</summary>
        /// <param name="token">- The Asset ID of the token whose information is being retrieved. </param>
        public async Task<Structs.TokenInfo> TokenInfo(ulong token, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 92, 186, 240 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenAbi.From(token);

            var result = await base.SimApp(new List<object> { abiHandle, tokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TokenInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TokenInfo_Transactions(ulong token, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 92, 186, 240 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenAbi.From(token);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieves the information associated with a specific token by its sequential token number.
        ///This works immediately after launch, before any buys.
        ///</summary>
        /// <param name="tokenNum">- The sequential token number assigned at launch time. </param>
        public async Task<Structs.TokenInfo> TokenInfoByNum(ulong tokenNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 95, 63, 232 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);

            var result = await base.SimApp(new List<object> { abiHandle, tokenNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TokenInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TokenInfoByNum_Transactions(ulong tokenNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 95, 63, 232 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Gets the token number for a given Asset ID.
        ///Only works after the first buy, when the assetMap is populated.
        ///</summary>
        /// <param name="asset">- The Asset ID to look up. </param>
        public async Task<ulong> GetTokenNumForAsset(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 69, 28, 197 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.SimApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTokenNumForAsset_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 69, 28, 197 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the current instantaneous price for a token (micro-bonding-token per micro-token).
        ///Note: Requires assetMap to be populated (after first buy). Use tokenInfoByNum for unbought tokens.
        ///
        ///Price = virtualBondingReserves / virtualTokenReserves (scaled by SCALE)
        ///</summary>
        /// <param name="token">- The Asset ID of the token to retrieve the price for. </param>
        public async Task<ulong> Price(ulong token, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 92, 100, 116 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenAbi.From(token);

            var result = await base.SimApp(new List<object> { abiHandle, tokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Price_Transactions(ulong token, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 92, 100, 116 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenAbi.From(token);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculates the bonding token cost required to buy a specific amount of tokens.
        ///Note: Requires assetMap to be populated (after first buy). Use tokenInfoByNum for unbought tokens.
        ///
        ///Uses constant product formula: newVirtualBonding = k / newVirtualToken
        ///Bonding tokens needed = newVirtualBonding - currentVirtualBonding
        ///</summary>
        /// <param name="token">- The Asset ID of the token to buy. </param>
        /// <param name="tokensOut">- The amount of tokens to purchase. </param>
        public async Task<ulong> CostToBuy(ulong token, ulong tokensOut, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 242, 138, 215 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenAbi.From(token);
            var tokensOutAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokensOutAbi.From(tokensOut);

            var result = await base.SimApp(new List<object> { abiHandle, tokenAbi, tokensOutAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CostToBuy_Transactions(ulong token, ulong tokensOut, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 242, 138, 215 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenAbi.From(token);
            var tokensOutAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokensOutAbi.From(tokensOut);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenAbi, tokensOutAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the tokens that would be received for buying with a given amount of bonding tokens.
        ///This is a buy preview that mirrors the buy() method exactly (fees are deducted first).
        ///
        ///Uses constant product formula: newVirtualBonding = virtualBonding + bondingIn (after fees)
        ///newVirtualToken = k / newVirtualBonding
        ///tokensOut = virtualToken - newVirtualToken
        ///</summary>
        /// <param name="tokenNum">- The sequential token number assigned at launch time. </param>
        /// <param name="bondingIn">- The amount of bonding tokens to spend. </param>
        public async Task<ulong> TokensReceivedForBuy(ulong tokenNum, ulong bondingIn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 195, 195, 255 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var bondingInAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingInAbi.From(bondingIn);

            var result = await base.SimApp(new List<object> { abiHandle, tokenNumAbi, bondingInAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TokensReceivedForBuy_Transactions(ulong tokenNum, ulong bondingIn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 195, 195, 255 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var bondingInAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingInAbi.From(bondingIn);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenNumAbi, bondingInAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the bonding tokens that would be received for selling a given amount of tokens.
        ///This is a sell preview that mirrors the sell() method exactly.
        ///
        ///Uses constant product formula: newVirtualToken = virtualToken + tokensIn
        ///newVirtualBonding = k / newVirtualToken
        ///bondingOut = virtualBonding - newVirtualBonding (capped by realBondingReserves)
        ///</summary>
        /// <param name="tokenNum">- The sequential token number assigned at launch time. </param>
        /// <param name="tokensToSell">- The amount of tokens to sell. </param>
        public async Task<ulong> BondingReceivedForSell(ulong tokenNum, ulong tokensToSell, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 218, 170, 66 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var tokensToSellAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokensToSellAbi.From(tokensToSell);

            var result = await base.SimApp(new List<object> { abiHandle, tokenNumAbi, tokensToSellAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BondingReceivedForSell_Transactions(ulong tokenNum, ulong tokensToSell, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 218, 170, 66 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var tokensToSellAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokensToSellAbi.From(tokensToSell);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenNumAbi, tokensToSellAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the bonding progress as a percentage (0-100, scaled by SCALE).
        ///Note: Requires assetMap to be populated (after first buy).
        ///
        ///Progress = (initialRealTokenReserves - realTokenReserves) / initialRealTokenReserves * 100 * SCALE
        ///</summary>
        /// <param name="token">- The Asset ID of the token. </param>
        public async Task<ulong> BondingProgress(ulong token, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 99, 86, 72 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenAbi.From(token);

            var result = await base.SimApp(new List<object> { abiHandle, tokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BondingProgress_Transactions(ulong token, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 99, 86, 72 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenAbi.From(token);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the current market cap in micro-bonding-token.
        ///MarketCap = currentPrice * totalSupply
        ///</summary>
        /// <param name="token">- The Asset ID of the token. </param>
        public async Task<ulong> MarketCap(ulong token, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 18, 150, 181 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenAbi.From(token);

            var result = await base.SimApp(new List<object> { abiHandle, tokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MarketCap_Transactions(ulong token, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 18, 150, 181 };
            var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenAbi.From(token);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Preview bonding metrics for given parameters.
        ///Allows callers to simulate "what if I want bonding to be $X with Y bonding token price and Z multiplier?"
        ///</summary>
        /// <param name="bondingToken">- The bonding token asset (0 = ALGO) </param>
        /// <param name="targetBondingUsd">- Target bonding USD amount (0 = use contract default) </param>
        /// <param name="priceMultiplier">- Price increase factor (0 = use contract default) </param>
        public async Task<Structs.BondingPreview> PreviewBonding(ulong bondingToken, ulong targetBondingUsd, ulong priceMultiplier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 110, 193, 237 };
            var bondingTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingTokenAbi.From(bondingToken);
            var targetBondingUsdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetBondingUsdAbi.From(targetBondingUsd);
            var priceMultiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMultiplierAbi.From(priceMultiplier);

            var result = await base.SimApp(new List<object> { abiHandle, bondingTokenAbi, targetBondingUsdAbi, priceMultiplierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BondingPreview.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> PreviewBonding_Transactions(ulong bondingToken, ulong targetBondingUsd, ulong priceMultiplier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 110, 193, 237 };
            var bondingTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bondingTokenAbi.From(bondingToken);
            var targetBondingUsdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetBondingUsdAbi.From(targetBondingUsd);
            var priceMultiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMultiplierAbi.From(priceMultiplier);

            return await base.MakeTransactionList(new List<object> { abiHandle, bondingTokenAbi, targetBondingUsdAbi, priceMultiplierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Executes a token purchase using a bonding curve mechanism with constant product formula.
        ///Validates the payment, calculates fees and tokens to be received, updates reserves,
        ///handles refunds for excess payments or completed bonding, and updates user balances.
        ///If all real token reserves are depleted during the purchase, triggers bonding completion.
        ///</summary>
        /// <param name="tokenNum">- The unique identifier of the token to purchase </param>
        /// <param name="mbrPayment">- Payment covering MBR for user balance box (use mbrToBuy() to get required amount; 0 if user already has a balance) </param>
        /// <param name="payment">- The asset transfer transaction containing the bonding token payment </param>
        public async Task<ulong> Buy(PaymentTransaction mbrPayment, AssetTransferTransaction payment, ulong tokenNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, payment });
            byte[] abiHandle = { 113, 161, 12, 29 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);

            var result = await base.CallApp(new List<object> { abiHandle, tokenNumAbi, mbrPayment, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Buy_Transactions(PaymentTransaction mbrPayment, AssetTransferTransaction payment, ulong tokenNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, payment });
            byte[] abiHandle = { 113, 161, 12, 29 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenNumAbi, mbrPayment, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buy tokens with slippage protection.
        ///Fails if the tokens received is less than the specified minimum.
        ///</summary>
        /// <param name="tokenNum">- The unique identifier of the token to purchase </param>
        /// <param name="mbrPayment">- Payment covering MBR for user balance box (use mbrToBuy() to get required amount; 0 if user already has a balance) </param>
        /// <param name="payment">- The asset transfer transaction containing the bonding token payment </param>
        /// <param name="minTokensOut">- Minimum tokens expected (transaction fails if actual < min) </param>
        public async Task<ulong> BuyWithLimit(PaymentTransaction mbrPayment, AssetTransferTransaction payment, ulong tokenNum, ulong minTokensOut, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, payment });
            byte[] abiHandle = { 144, 104, 168, 217 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var minTokensOutAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minTokensOutAbi.From(minTokensOut);

            var result = await base.CallApp(new List<object> { abiHandle, tokenNumAbi, mbrPayment, payment, minTokensOutAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BuyWithLimit_Transactions(PaymentTransaction mbrPayment, AssetTransferTransaction payment, ulong tokenNum, ulong minTokensOut, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, payment });
            byte[] abiHandle = { 144, 104, 168, 217 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var minTokensOutAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minTokensOutAbi.From(minTokensOut);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenNumAbi, mbrPayment, payment, minTokensOutAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buy tokens using ALGO as the bonding token.
        ///Similar to buy() but accepts a PaymentTxn instead of AssetTransferTxn.
        ///</summary>
        /// <param name="tokenNum">- The unique identifier of the token to purchase </param>
        /// <param name="mbrPayment">- Payment covering MBR for user balance box (use mbrToBuy() to get required amount; 0 if user already has a balance) </param>
        /// <param name="payment">- The payment transaction containing the ALGO payment </param>
        public async Task<ulong> BuyWithAlgo(PaymentTransaction mbrPayment, PaymentTransaction payment, ulong tokenNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, payment });
            byte[] abiHandle = { 210, 9, 74, 195 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);

            var result = await base.CallApp(new List<object> { abiHandle, tokenNumAbi, mbrPayment, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BuyWithAlgo_Transactions(PaymentTransaction mbrPayment, PaymentTransaction payment, ulong tokenNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, payment });
            byte[] abiHandle = { 210, 9, 74, 195 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenNumAbi, mbrPayment, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buy tokens with ALGO and slippage protection.
        ///Fails if the tokens received is less than the specified minimum.
        ///</summary>
        /// <param name="tokenNum">- The unique identifier of the token to purchase </param>
        /// <param name="mbrPayment">- Payment covering MBR for user balance box (use mbrToBuy() to get required amount; 0 if user already has a balance) </param>
        /// <param name="payment">- The payment transaction containing the ALGO payment </param>
        /// <param name="minTokensOut">- Minimum tokens expected (transaction fails if actual < min) </param>
        public async Task<ulong> BuyWithAlgoWithLimit(PaymentTransaction mbrPayment, PaymentTransaction payment, ulong tokenNum, ulong minTokensOut, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, payment });
            byte[] abiHandle = { 176, 227, 5, 23 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var minTokensOutAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minTokensOutAbi.From(minTokensOut);

            var result = await base.CallApp(new List<object> { abiHandle, tokenNumAbi, mbrPayment, payment, minTokensOutAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BuyWithAlgoWithLimit_Transactions(PaymentTransaction mbrPayment, PaymentTransaction payment, ulong tokenNum, ulong minTokensOut, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, payment });
            byte[] abiHandle = { 176, 227, 5, 23 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var minTokensOutAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minTokensOutAbi.From(minTokensOut);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenNumAbi, mbrPayment, payment, minTokensOutAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Launches a token with ALGO bonding and performs an initial purchase using ALGO.
        ///Similar to launchTokenThenBuy but for ALGO pairs.
        ///</summary>
        /// <param name="mbrPayment">- The payment transaction covering both launch and first buy MBR costs. </param>
        /// <param name="buyPayment">- The payment transaction for the initial ALGO purchase. </param>
        /// <param name="symbol">- The symbol of the token to be created. </param>
        /// <param name="name">- The name of the token to be created. </param>
        /// <param name="assetUrl">- The URL for the token metadata. </param>
        /// <param name="description">- A description of the token. </param>
        /// <param name="socialWebsite">- The token's official website URL. </param>
        /// <param name="socialX">- The token's X (Twitter) handle. </param>
        /// <param name="socialTelegram">- The token's Telegram link. </param>
        /// <param name="socialDiscord">- The token's Discord link. </param>
        /// <param name="targetBondingUsd">- Custom bonding target in micro-USD (0 = use contract default). </param>
        /// <param name="priceMultiplier">- Custom price multiplier (0 = use contract default). </param>
        public async Task<ulong> LaunchTokenThenBuyWithAlgo(PaymentTransaction mbrPayment, PaymentTransaction buyPayment, string symbol, string name, string assetUrl, string description, string socialWebsite, string socialX, string socialTelegram, string socialDiscord, ulong targetBondingUsd, ulong priceMultiplier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, buyPayment });
            byte[] abiHandle = { 44, 242, 212, 174 };
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbolAbi.From(symbol);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var assetUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetUrlAbi.From(assetUrl);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var socialWebsiteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialWebsiteAbi.From(socialWebsite);
            var socialXAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialXAbi.From(socialX);
            var socialTelegramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialTelegramAbi.From(socialTelegram);
            var socialDiscordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialDiscordAbi.From(socialDiscord);
            var targetBondingUsdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetBondingUsdAbi.From(targetBondingUsd);
            var priceMultiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMultiplierAbi.From(priceMultiplier);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPayment, buyPayment, symbolAbi, nameAbi, assetUrlAbi, descriptionAbi, socialWebsiteAbi, socialXAbi, socialTelegramAbi, socialDiscordAbi, targetBondingUsdAbi, priceMultiplierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> LaunchTokenThenBuyWithAlgo_Transactions(PaymentTransaction mbrPayment, PaymentTransaction buyPayment, string symbol, string name, string assetUrl, string description, string socialWebsite, string socialX, string socialTelegram, string socialDiscord, ulong targetBondingUsd, ulong priceMultiplier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment, buyPayment });
            byte[] abiHandle = { 44, 242, 212, 174 };
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbolAbi.From(symbol);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var assetUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetUrlAbi.From(assetUrl);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var socialWebsiteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialWebsiteAbi.From(socialWebsite);
            var socialXAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialXAbi.From(socialX);
            var socialTelegramAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialTelegramAbi.From(socialTelegram);
            var socialDiscordAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); socialDiscordAbi.From(socialDiscord);
            var targetBondingUsdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetBondingUsdAbi.From(targetBondingUsd);
            var priceMultiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceMultiplierAbi.From(priceMultiplier);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPayment, buyPayment, symbolAbi, nameAbi, assetUrlAbi, descriptionAbi, socialWebsiteAbi, socialXAbi, socialTelegramAbi, socialDiscordAbi, targetBondingUsdAbi, priceMultiplierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Processes the sale of tokens using constant product AMM.
        ///User sells tokens back, receives bonding token minus fees.
        ///</summary>
        /// <param name="tokenNum">- The sequential token number assigned at launch time. </param>
        /// <param name="tokensToSell">- The number of tokens to be sold. </param>
        public async Task<ulong> Sell(ulong tokenNum, ulong tokensToSell, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 85, 30, 143 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var tokensToSellAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokensToSellAbi.From(tokensToSell);

            var result = await base.CallApp(new List<object> { abiHandle, tokenNumAbi, tokensToSellAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Sell_Transactions(ulong tokenNum, ulong tokensToSell, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 94, 85, 30, 143 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var tokensToSellAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokensToSellAbi.From(tokensToSell);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenNumAbi, tokensToSellAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sell tokens with slippage protection.
        ///Fails if the bonding tokens received is less than the specified minimum.
        ///</summary>
        /// <param name="tokenNum">- The sequential token number assigned at launch time </param>
        /// <param name="tokensToSell">- The number of tokens to sell </param>
        /// <param name="minBondingOut">- Minimum bonding tokens expected (transaction fails if actual < min) </param>
        public async Task<ulong> SellWithLimit(ulong tokenNum, ulong tokensToSell, ulong minBondingOut, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 138, 6, 71 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var tokensToSellAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokensToSellAbi.From(tokensToSell);
            var minBondingOutAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minBondingOutAbi.From(minBondingOut);

            var result = await base.CallApp(new List<object> { abiHandle, tokenNumAbi, tokensToSellAbi, minBondingOutAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SellWithLimit_Transactions(ulong tokenNum, ulong tokensToSell, ulong minBondingOut, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 138, 6, 71 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);
            var tokensToSellAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokensToSellAbi.From(tokensToSell);
            var minBondingOutAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); minBondingOutAbi.From(minBondingOut);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenNumAbi, tokensToSellAbi, minBondingOutAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Claims virtual token holdings as actual ASA tokens after bonding completes.
        ///Users must opt-in to the ASA before calling this method.
        ///The user's balance box is deleted and the MBR is refunded.
        ///</summary>
        /// <param name="tokenNum">- The sequential token number assigned at launch time. </param>
        public async Task<ulong> Claim(ulong tokenNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 241, 186, 21 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);

            var result = await base.CallApp(new List<object> { abiHandle, tokenNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Claim_Transactions(ulong tokenNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 241, 186, 21 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sweeps a bonded token's Pact V2 manager fees to its creator.
        ///
        ///This app is every V2 pool's manager, so Pact pays the fees here (claim_fees); they are
        ///forwarded to tokenCreator in the same call. Callable by anyone - funds only ever go to
        ///the creator, and the caller pays the fees.
        ///
        ///The amounts forwarded are the balance deltas across claim_fees, never balances: this
        ///account also custodies unclaimed buyer tokens and other tokens' ALGO reserves.
        ///
        ///If the creator cannot receive a side with fees to pay (opted out of the token or the
        ///bonding asset, or a closed account below the ALGO base MBR), the whole call reverts and
        ///the fees stay in the pool until they can - nobody else is entitled to them.
        ///</summary>
        /// <param name="tokenNum">- The sequential token number assigned at launch time. </param>
        public async Task<Structs.PoolFees> ClaimPoolFees(ulong tokenNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 101, 255, 77 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);

            var result = await base.CallApp(new List<object> { abiHandle, tokenNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PoolFees.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ClaimPoolFees_Transactions(ulong tokenNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 101, 255, 77 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Manager fees a claimPoolFees() call would pay the creator right now: the pool's own
        ///holdings, which is exactly what Pact's claim_fees sweeps - an ASA's whole balance,
        ///ALGO's balance above the pool's min balance. Zero for a token without a V2 pool.
        ///</summary>
        /// <param name="tokenNum">- The sequential token number assigned at launch time. </param>
        public async Task<Structs.PoolFees> PendingPoolFees(ulong tokenNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 36, 131, 134 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);

            var result = await base.SimApp(new List<object> { abiHandle, tokenNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PoolFees.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> PendingPoolFees_Transactions(ulong tokenNum, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 36, 131, 134 };
            var tokenNumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenNumAbi.From(tokenNum);

            return await base.MakeTransactionList(new List<object> { abiHandle, tokenNumAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpudWxsLCJuYW1lIjoiSGF5TGF1bmNoIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkJvbmRpbmdQcmV2aWV3IjpbeyJuYW1lIjoiaW5pdGlhbFByaWNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpbmFsUHJpY2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxCb25kaW5nUmVxdWlyZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaW5pdGlhbE1hcmtldENhcFVzZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaW5hbE1hcmtldENhcFVzZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmZHZBdExhdW5jaCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmZHZBdEJvbmRpbmciLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG9rZW5zRm9yQm9uZGluZyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b2tlbnNGb3JMcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcmljZU11bHRpcGxpZXIiLCJ0eXBlIjoidWludDY0In1dLCJQb29sRmVlcyI6W3sibmFtZSI6InRva2VuQW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImJvbmRpbmdBbW91bnQiLCJ0eXBlIjoidWludDY0In1dLCJUb2tlbkluZm8iOlt7Im5hbWUiOiJ2ZXJzaW9uIiwidHlwZSI6ImJ5dGVbMV0ifSx7Im5hbWUiOiJ0b2tlbk51bSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b2tlbkNyZWF0b3IiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImJvbmRpbmdUb2tlbklkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InZpcnR1YWxUb2tlblJlc2VydmVzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InZpcnR1YWxCb25kaW5nUmVzZXJ2ZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmVhbFRva2VuUmVzZXJ2ZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmVhbEJvbmRpbmdSZXNlcnZlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpbml0aWFsUmVhbFRva2VuUmVzZXJ2ZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGF1bmNoUSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmZWVCcHNQbGF0Zm9ybSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmZWVCcHNDcmVhdG9yIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImJvbmRpbmdUYXJnZXRVc2QiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG9rZW5QcmljZU11bHRpcGxpZXIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYm9uZGluZ09uIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFzc2V0SWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3ltYm9sIiwidHlwZSI6ImJ5dGVbOF0ifSx7Im5hbWUiOiJuYW1lIiwidHlwZSI6ImJ5dGVbMzJdIn0seyJuYW1lIjoiYXNzZXRVcmwiLCJ0eXBlIjoiYnl0ZVs5Nl0ifSx7Im5hbWUiOiJkZXNjcmlwdGlvbiIsInR5cGUiOiJieXRlWzEwMjRdIn0seyJuYW1lIjoic29jaWFsV2Vic2l0ZSIsInR5cGUiOiJieXRlWzI1Nl0ifSx7Im5hbWUiOiJzb2NpYWxYIiwidHlwZSI6ImJ5dGVbNjRdIn0seyJuYW1lIjoic29jaWFsVGVsZWdyYW0iLCJ0eXBlIjoiYnl0ZVs2NF0ifSx7Im5hbWUiOiJzb2NpYWxEaXNjb3JkIiwidHlwZSI6ImJ5dGVbNjRdIn0seyJuYW1lIjoicG9vbEFwcElkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImxwVG9rZW5JZCIsInR5cGUiOiJ1aW50NjQifV0sIlVzZXJIb2xkaW5nS2V5IjpbeyJuYW1lIjoiYWRkcmVzcyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidG9rZW5OdW0iLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluVG9rZW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZGMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JhY2xlQXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdVc2QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlTXVsdGlwbGllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRlU3VwcGx5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVCcHNQbGF0Zm9ybSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlQnBzQ3JlYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBsYXRmb3JtVHJlYXN1cnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImluaXQiLCJkZXNjIjoiT3B0cyB0aGUgYXBwbGljYXRpb24gYWNjb3VudCBpbnRvIFVTREMsIHdoaWNoIGlzIG5lZWRlZCBmb3IgdGhlIHVwZGF0ZVRva2VuTWV0YWRhdGFcbmZlZSByZWdhcmRsZXNzIG9mIHdoaWNoIGFzc2V0cyBhcmUgc3VwcG9ydGVkIGZvciBib25kaW5nLlxuXG5Cb25kaW5nIGFzc2V0cyAtIGluY2x1ZGluZyBVU0RDIGFuZCBIQVkgLSBhcmUgb3B0ZWQgaW50byBzZXBhcmF0ZWx5IHZpYVxub3B0SW5Cb25kaW5nQXNzZXQoKSwgc28gdGhpcyBubyBsb25nZXIgaGFyZGNvZGVzIHRoZSBzdXBwb3J0ZWQgc2V0LiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb25maWd1cmVBcHBzIiwiZGVzYyI6IkNvbmZpZ3VyZSBQYWN0IGZhY3RvcnkgYW5kIEJvbmZpcmUgYXBwIElEcyBmb3IgcG9vbCBjcmVhdGlvbi5cbk11c3QgYmUgY2FsbGVkIGJlZm9yZSBhbnkgdG9rZW4gY2FuIGNvbXBsZXRlIGJvbmRpbmcuXG5cblRoZSBQYWN0IFYyIHZhdWx0IGlzIG5vdCBjb25maWd1cmVkIHNlcGFyYXRlbHk6IGl0IGlzIHJlYWQgZnJvbSB0aGUgZmFjdG9yeSdzXG5gdmF1bHRfYXBwYCBnbG9iYWwsIHRoZSBzYW1lIHNvdXJjZSBldmVyeSBwb29sIHRoZSBmYWN0b3J5IGRlcGxveXMgdHJ1c3RzLiBBIG5vbnplcm9cbmZhY3RvcnkgbXVzdCB0aGVyZWZvcmUgaGF2ZSBvbmUgLSB0aGlzIHJlamVjdHMgZS5nLiBhIFBhY3QgVjEgZmFjdG9yeSBpZCwgd2hpY2ggd291bGRcbm90aGVyd2lzZSBsZXQgbGF1bmNoZXMgdGhyb3VnaCB0aGF0IGNvdWxkIG5ldmVyIGJvbmQuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhY3RGYWN0b3J5QXBwSWQiLCJkZXNjIjoiLSBUaGUgUGFjdCBWMiBwb29sIGZhY3RvcnkgYXBwbGljYXRpb24gSUQgKG1haW5uZXQgMzY1NjA4NDQ0MiksIDAgPSBib25kIHdpdGhvdXQgYSBwb29sIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25maXJlQXBwSWQiLCJkZXNjIjoiLSBUaGUgQVJDLTU0IEJvbmZpcmUgYXBwbGljYXRpb24gSUQgZm9yIExQIGJ1cm5pbmciLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlVHJlYXN1cnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1RyZWFzdXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdEluQm9uZGluZ0Fzc2V0IiwiZGVzYyI6Ik9wdHMgdGhlIGFwcCBpbnRvIGFuIEFTQSBzbyBpdCBjYW4gYmUgdXNlZCBhcyBhIGJvbmRpbmcgdG9rZW4uXG5cblRoZSBvcHQtaW4gZG91YmxlcyBhcyB0aGUgYWxsb3dsaXN0OiBsYXVuY2hUb2tlbigpIG9ubHkgYWNjZXB0cyBhc3NldHMgdGhpcyBhcHBcbmhvbGRzLCBzbyB0aGVyZSBpcyBubyBzZXBhcmF0ZSByZWdpc3RyeSB0byBtYWludGFpbi4gVGhlIG9uZSBtZXRob2QgaGVyZSBvcGVuIHRvIHRoZVxuYWRtaW4gTkZUIGFzIHdlbGwgYXMgdGhlIGNyZWF0b3IgLSB0aGUgdHdvIGhhbHZlcyBvZiBhZGRpbmcgYSBib25kaW5nIGFzc2V0IGhhdmUgdG9cbnN0YXkgYWxpZ25lZCwgYW5kIHRoZSBvdGhlciBoYWxmIChyZWdpc3RlckFzc2V0ICsgc2V0QXNzZXRQcmljZXMgb24gdGhlIG9yYWNsZSkgaXNcbmFkbWluLWdhdGVkIHdpdGggdGhlIHNhbWUgdG9rZW4uIEl0IGlzIHN0aWxsIGEgcmVhbCByaXNrIHN1cmZhY2UgLSBzZWUgdGhlXG5mcmVlemUvY2xhd2JhY2sgY2hlY2sgYmVsb3cuXG5cblRoZSBhc3NldCBtdXN0IGFsc28gYmUgcmVnaXN0ZXJlZCBhbmQgcHJpY2VkIGluIHRoZSBvcmFjbGUgYmVmb3JlIGl0IGNhbiBiZSBsYXVuY2hlZFxuYWdhaW5zdDsgdGhpcyBtZXRob2QgZGVsaWJlcmF0ZWx5IGRvZXMgbm90IGNoZWNrIHRoYXQsIHNvIHRoZSB0d28gY2FuIGJlIHNldCB1cCBpblxuZWl0aGVyIG9yZGVyLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiItIFRoZSBBU0EgdG8gc3VwcG9ydCBhcyBhIGJvbmRpbmcgdG9rZW4uIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXltZW50IiwiZGVzYyI6Ii0gUGF5bWVudCBjb3ZlcmluZyB0aGUgMC4xIEFMR08gb3B0LWluIE1CUi4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlTGF1bmNoUGFyYW1zIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdVc2QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlTXVsdGlwbGllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRlU3VwcGx5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVCcHNQbGF0Zm9ybSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlQnBzQ3JlYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVUb2tlbk1ldGFkYXRhIiwiZGVzYyI6IlVwZGF0ZSB0b2tlbiBtZXRhZGF0YSAoZGVzY3JpcHRpb24gYW5kIHNvY2lhbCBmaWVsZHMpLlxuQ2FuIG9ubHkgYmUgY2FsbGVkIGJ5IHRoZSBjb250cmFjdCBjcmVhdG9yIG9yIHRoZSB0b2tlbiBjcmVhdG9yLlxuUmVxdWlyZXMgYSAzMCBVU0RDIHBheW1lbnQgKGZyZWUgZm9yIGNvbnRyYWN0IGNyZWF0b3IpLiIsImFyZ3MiOlt7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuTnVtIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXNjcmlwdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic29jaWFsV2Vic2l0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic29jaWFsWCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic29jaWFsVGVsZWdyYW0iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNvY2lhbERpc2NvcmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImV2ZW50VG9rZW5NZXRhZGF0YVVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbkFzc2V0SWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbk51bSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlc2NyaXB0aW9uIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic29jaWFsV2Vic2l0ZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNvY2lhbFgiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzb2NpYWxUZWxlZ3JhbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNvY2lhbERpc2NvcmQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnYXMiLCJkZXNjIjoiTm8tb3AgbWV0aG9kIHVzZWQgdG8gYWRkIGV4dHJhIHRyYW5zYWN0aW9ucyB0byBhIGdyb3VwIGZvciBpbmNyZWFzZWQgb3Bjb2RlIGJ1ZGdldC5cbkNhbGxlcnMgY2FuIGluY2x1ZGUgbXVsdGlwbGUgYGdhcygpYCBjYWxscyBpbiBhIHRyYW5zYWN0aW9uIGdyb3VwIHdoZW4gY29tcGxleFxub3BlcmF0aW9ucyByZXF1aXJlIG1vcmUgdGhhbiB0aGUgc2luZ2xlLXRyYW5zYWN0aW9uIG9wY29kZSBsaW1pdC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWJyVG9MYXVuY2hUb2tlbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWJyVG9CdXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1iclRvTGF1bmNoVG9rZW5UaGVuQnV5IiwiZGVzYyI6IlJldHVybnMgdGhlIE1CUiBuZWVkZWQgZm9yIGxhdW5jaFRva2VuVGhlbkJ1eS5cbkluY2x1ZGVzIE1CUiBmb3IgbGF1bmNoICh0b2tlbk1hcCBib3gsIGFzc2V0TWFwIGJveCwgQVNBIGNyZWF0aW9uKSBwbHVzXG5NQlIgZm9yIHRoZSB1c2VyIGJhbGFuY2UgYm94IChmaXJzdCBidXkpLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUb3RhbCBNQlIgaW4gbWljcm9BbGdvcyBuZWVkZWQgZm9yIGxhdW5jaFRva2VuVGhlbkJ1eSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9rZW5zUmVjZWl2ZWRGb3JCdXlBdExhdW5jaCIsImRlc2MiOiJDYWxjdWxhdGVzIHRoZSB0b2tlbnMgcmVjZWl2ZWQgZm9yIGEgZ2l2ZW4gYm9uZGluZyB0b2tlbiBhbW91bnQgYXQgbGF1bmNoLXRpbWUgcHJpY2VzLlxuVGhpcyBpcyBhIGJ1eSBwcmV2aWV3IHRoYXQgbWlycm9ycyBsYXVuY2hUb2tlblRoZW5CdXkoKSBleGFjdGx5IChmZWVzIGFyZSBkZWR1Y3RlZCBmaXJzdCkuXG5cblVzZXMgdGhlIHNhbWUgcmVzZXJ2ZSBjYWxjdWxhdGlvbiBsb2dpYyBhcyBsYXVuY2hUb2tlbigpIHRvIGNvbXB1dGUgd2hhdCB0aGVcbmluaXRpYWwgdmlydHVhbCByZXNlcnZlcyB3b3VsZCBiZSwgdGhlbiBhcHBsaWVzIGNvbnN0YW50IHByb2R1Y3QgZm9ybXVsYS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9uZGluZ1Rva2VuIiwiZGVzYyI6Ii0gVGhlIGJvbmRpbmcgdG9rZW4gYXNzZXQgKDAgPSBBTEdPKS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdJbiIsImRlc2MiOiItIFRoZSBhbW91bnQgb2YgYm9uZGluZyB0b2tlbiB0byBzcGVuZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldEJvbmRpbmdVc2QiLCJkZXNjIjoiLSBDdXN0b20gYm9uZGluZyB0YXJnZXQgaW4gbWljcm8tVVNEICgwID0gdXNlIGNvbnRyYWN0IGRlZmF1bHQpLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VNdWx0aXBsaWVyIiwiZGVzYyI6Ii0gQ3VzdG9tIHByaWNlIG11bHRpcGxpZXIgKDkgZGlnaXRzKSAoMCA9IHVzZSBjb250cmFjdCBkZWZhdWx0KS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIG51bWJlciBvZiB0b2tlbnMgdGhhdCB3b3VsZCBiZSByZWNlaXZlZCAoYWZ0ZXIgZmVlcykuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1c2VySG9sZGluZ3MiLCJkZXNjIjoiUmV0cmlldmVzIHRoZSBob2xkaW5ncyBvZiBhIHNwZWNpZmljIHVzZXIgZm9yIGEgZ2l2ZW4gdG9rZW4uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuTnVtIiwiZGVzYyI6Ii0gVGhlIHNlcXVlbnRpYWwgdG9rZW4gbnVtYmVyIGFzc2lnbmVkIGF0IGxhdW5jaCB0aW1lLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjoiLSBUaGUgYWRkcmVzcyBvZiB0aGUgdXNlciB3aG9zZSBob2xkaW5ncyBhcmUgYmVpbmcgcXVlcmllZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGFtb3VudCBvZiB0aGUgc3BlY2lmaWVkIHRva2VuIGhlbGQgYnkgdGhlIHVzZXIuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib25kaW5nVG9rZW5QcmljZSIsImRlc2MiOiJSZXRyaWV2ZXMgdGhlIFVTRCBwcmljZSBvZiBhIGJvbmRpbmcgdG9rZW4gZnJvbSB0aGUgSGF5c3RhY2tPcmFjbGUgcHJpY2UgcmVnaXN0cnkuXG5cblJlYWRzIHRoZSBvcmFjbGUncyBgYXNzZXRQcmljZXNgIGJveCBkaXJlY3RseSB3aXRoIGBhcHBfYm94X2dldGAgKEFWTSAxMykgLSBhIHBsYWluXG5vcGNvZGUsIHNvIHRoaXMgY29zdHMgbm8gaW5uZXIgdHJhbnNhY3Rpb24gYW5kIHN0YXlzIHVzYWJsZSBmcm9tIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdUb2tlbiIsImRlc2MiOiItIFRoZSBib25kaW5nIHRva2VuIHRvIHByaWNlLiBBc3NldCBpZCAwIG1lYW5zIEFMR08uIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6Ik1pY3JvLVVTRCBwZXIgYmFzZSB1bml0LCBzY2FsZWQgYnkgU0NBTEUuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc0JvbmRpbmdUb2tlblN1cHBvcnRlZCIsImRlc2MiOiJXaGV0aGVyIGEgdG9rZW4gY2FuIGJlIGxhdW5jaGVkIGFnYWluc3QgcmlnaHQgbm93IC0gdGhlIHF1ZXN0aW9uIGEgbGF1bmNoIFVJIG5lZWRzXG5hbnN3ZXJlZCwgYW5kIHRoZSBvbmUgdGhlIG9yYWNsZSBjYW5ub3QgYW5zd2VyIG9uIGl0cyBvd24uXG5cblRoZSBvcmFjbGUncyBhc3NldFByaWNlcyBib3hlcyAocmVhZGFibGUgb2ZmLWNoYWluIHZpYSB0aGUgZ2VuZXJhdGVkIGNsaWVudCdzXG5gYXNzZXRQcmljZXMuZ2V0TWFwKClgKSBvbmx5IHNheSBhbiBhc3NldCBpcyByZWdpc3RlcmVkIGFuZCBwcmljZWQuIFRoZXkgZG8gbm90IGtub3dcbndoZXRoZXIgVEhJUyBhcHAgaXMgb3B0ZWQgaW50byBpdCwgYW5kIGFuIGFzc2V0IGNhbiBsZWdpdGltYXRlbHkgYmUgcHJpY2VkIGJ1dCBub3Rcbm9wdGVkIGluLiBUaGlzIGNvbWJpbmVzIGJvdGgsIHBsdXMgcHJpY2UgZnJlc2huZXNzLCBpbnRvIG9uZSBub24tdGhyb3dpbmcgYW5zd2VyLCBzb1xuY2FsbGVycyBjYW4gcHJvYmUgY2FuZGlkYXRlcyB3aXRob3V0IGNhdGNoaW5nIHNpbXVsYXRlIGZhaWx1cmVzLlxuXG5TaGFyZXMgaXRzIHByZWRpY2F0ZXMgd2l0aCB0aGUgbGF1bmNoIHBhdGggZGVsaWJlcmF0ZWx5IC0gaXNPcHRlZEluQm9uZGluZ1Rva2VuKCksXG5pc0luUGFjdFZhdWx0KCkgYW5kIHJlYWRPcmFjbGVQcmljZSgpIGFyZSB0aGUgc2FtZSBjYWxscyBsYXVuY2hUb2tlbigpIG1ha2VzLiBJZiB0aGlzXG5yZXR1cm5lZCB0cnVlIHdoaWxlIGxhdW5jaFRva2VuKCkgcmVqZWN0ZWQsIHRoZSBVSSB3b3VsZCBvZmZlciBsYXVuY2hlcyB0aGF0IGFsd2F5cyBmYWlsLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25kaW5nVG9rZW4iLCJkZXNjIjoiLSBUaGUgYXNzZXQgdG8gdGVzdC4gQXNzZXQgaWQgMCBtZWFucyBBTEdPLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVHJ1ZSBpZiBsYXVuY2hUb2tlbigpIHdvdWxkIGFjY2VwdCB0aGlzIGJvbmRpbmcgdG9rZW4uIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsYXVuY2hUb2tlbiIsImRlc2MiOiJMYXVuY2hlcyBhIG5ldyB0b2tlbiB3aXRoIHRoZSBzcGVjaWZpZWQgbWV0YWRhdGEgYW5kIHBhcmFtZXRlcnMuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjoiLSBQcmlvciBwYXltZW50IHRyYW5zYWN0aW9uIGNvdmVyaW5nIE1CUiBjb3N0cyAobXVzdCBlcXVhbCBtYnJUb0xhdW5jaFRva2VuIGFtb3VudCkuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzeW1ib2wiLCJkZXNjIjoiLSBUaGUgc3ltYm9sIG9mIHRoZSB0b2tlbiwgcmVwcmVzZW50ZWQgYXMgYSBmaXhlZC1sZW5ndGggYnl0ZSBhcnJheS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjoiLSBUaGUgbmFtZSBvZiB0aGUgdG9rZW4sIHJlcHJlc2VudGVkIGFzIGEgZml4ZWQtbGVuZ3RoIGJ5dGUgYXJyYXkuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldFVybCIsImRlc2MiOiItIEEgVVJMIHBvaW50aW5nIHRvIHRoZSBhc3NldCdzIGluZm9ybWF0aW9uIG9yIG1ldGFkYXRhLCByZXByZXNlbnRlZCBhcyBhIGZpeGVkLWxlbmd0aCBieXRlIGFycmF5LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVzY3JpcHRpb24iLCJkZXNjIjoiLSBBIHRleHR1YWwgZGVzY3JpcHRpb24gb2YgdGhlIHRva2VuLCByZXByZXNlbnRlZCBhcyBhIGZpeGVkLWxlbmd0aCBieXRlIGFycmF5LiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic29jaWFsV2Vic2l0ZSIsImRlc2MiOiItIFRoZSBVUkwgb2YgdGhlIHRva2VuJ3Mgb2ZmaWNpYWwgd2Vic2l0ZSwgcmVwcmVzZW50ZWQgYXMgYSBmaXhlZC1sZW5ndGggYnl0ZSBhcnJheS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNvY2lhbFgiLCJkZXNjIjoiLSBUaGUgdXNlcm5hbWUgb3IgaGFuZGxlIGZvciB0aGUgdG9rZW4ncyBwcmVzZW5jZSBvbiBcIlhcIiAoZm9ybWVybHkgVHdpdHRlciksIHJlcHJlc2VudGVkIGFzIGEgZml4ZWQtbGVuZ3RoIGJ5dGUgYXJyYXkuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzb2NpYWxUZWxlZ3JhbSIsImRlc2MiOiItIFRoZSB1c2VybmFtZSBvciBVUkwgZm9yIHRoZSB0b2tlbidzIFRlbGVncmFtIGdyb3VwIG9yIGNoYW5uZWwsIHJlcHJlc2VudGVkIGFzIGEgZml4ZWQtbGVuZ3RoIGJ5dGUgYXJyYXkuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzb2NpYWxEaXNjb3JkIiwiZGVzYyI6Ii0gVGhlIFVSTCBvciBpZGVudGlmaWVyIGZvciB0aGUgdG9rZW4ncyBEaXNjb3JkIHNlcnZlciwgcmVwcmVzZW50ZWQgYXMgYSBmaXhlZC1sZW5ndGggYnl0ZSBhcnJheS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldEJvbmRpbmdVc2QiLCJkZXNjIjoiLSBDdXN0b20gYm9uZGluZyB0YXJnZXQgaW4gbWljcm8tVVNEICgwID0gdXNlIGNvbnRyYWN0IGRlZmF1bHQpLiBNdXN0IGJlID49IGNvbnRyYWN0IG1pbmltdW0gaWYgc3BlY2lmaWVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VNdWx0aXBsaWVyIiwiZGVzYyI6Ii0gQ3VzdG9tIHByaWNlIG11bHRpcGxpZXIgKDkgZGlnaXRzIC0gMjAsMDAwLDAwMCwwMDAgPSAyMHgpICgwID0gdXNlIGNvbnRyYWN0IGRlZmF1bHQpLiBNdXN0IGJlID49IGNvbnRyYWN0IG1pbmltdW0gaWYgc3BlY2lmaWVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9uZGluZ1Rva2VuIiwiZGVzYyI6Ii0gVGhlIGJvbmRpbmcgdG9rZW4gYXNzZXQgKHNlZSBpc0JvbmRpbmdUb2tlblN1cHBvcnRlZDsgMCA9IEFMR08pLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgc2VxdWVudGlhbCB0b2tlbiBudW1iZXIgYXNzaWduZWQgdG8gdGhlIG5ld2x5LWNyZWF0ZWQgdG9rZW4uIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImV2ZW50VG9rZW5MYXVuY2hlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuQXNzZXRJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuTnVtIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9uZGluZ1Rva2VuSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidW5pdE5hbWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWNpbWFscyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsU3VwcGx5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5pdGlhbFByaWNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0UHJpY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25kaW5nVGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmlydHVhbFRva2VuUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2aXJ0dWFsQm9uZGluZ1Jlc2VydmVzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGF1bmNoVG9rZW5UaGVuQnV5IiwiZGVzYyI6IkxhdW5jaGVzIGEgdG9rZW4gd2l0aCB0aGUgZ2l2ZW4gcGFyYW1ldGVycyBhbmQgdGhlbiBwZXJmb3JtcyBhbiBpbml0aWFsIHB1cmNoYXNlIG9mIHRoZSB0b2tlbiB1c2luZyB0aGUgcHJvdmlkZWQgcGF5bWVudCB0cmFuc2FjdGlvbi5cblVzZSBtYnJUb0xhdW5jaFRva2VuVGhlbkJ1eSgpIHRvIGdldCB0aGUgcmVxdWlyZWQgTUJSIGFtb3VudC4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOiItIFRoZSBwYXltZW50IHRyYW5zYWN0aW9uIGNvdmVyaW5nIGJvdGggbGF1bmNoIGFuZCBmaXJzdCBidXkgTUJSIGNvc3RzLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJidXlQYXltZW50IiwiZGVzYyI6Ii0gVGhlIGFzc2V0IHRyYW5zZmVyIHRyYW5zYWN0aW9uIG9iamVjdCB1c2VkIHRvIHBlcmZvcm0gdGhlIHRva2VuIHB1cmNoYXNlLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3ltYm9sIiwiZGVzYyI6Ii0gVGhlIHN5bWJvbCBvZiB0aGUgdG9rZW4gdG8gYmUgY3JlYXRlZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjoiLSBUaGUgbmFtZSBvZiB0aGUgdG9rZW4gdG8gYmUgY3JlYXRlZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0VXJsIiwiZGVzYyI6Ii0gVGhlIFVSTCB0aGF0IHByb3ZpZGVzIGFkZGl0aW9uYWwgaW5mb3JtYXRpb24gb3IgbWV0YWRhdGEgYWJvdXQgdGhlIHRva2VuLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVzY3JpcHRpb24iLCJkZXNjIjoiLSBBIGRldGFpbGVkIGRlc2NyaXB0aW9uIG9mIHRoZSB0b2tlbiBiZWluZyBjcmVhdGVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic29jaWFsV2Vic2l0ZSIsImRlc2MiOiItIFRoZSBVUkwgb2YgdGhlIHRva2VuJ3Mgb2ZmaWNpYWwgd2Vic2l0ZS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNvY2lhbFgiLCJkZXNjIjoiLSBUaGUgbGluayB0byB0aGUgdG9rZW4ncyBwcm9maWxlIG9yIGhhbmRsZSBvbiBwbGF0Zm9ybSBYIChlLmcuLCBUd2l0dGVyKS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNvY2lhbFRlbGVncmFtIiwiZGVzYyI6Ii0gVGhlIGxpbmsgdG8gdGhlIHRva2VuJ3Mgb2ZmaWNpYWwgVGVsZWdyYW0gZ3JvdXAuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzb2NpYWxEaXNjb3JkIiwiZGVzYyI6Ii0gVGhlIGxpbmsgdG8gdGhlIHRva2VuJ3Mgb2ZmaWNpYWwgRGlzY29yZCBzZXJ2ZXIuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXRCb25kaW5nVXNkIiwiZGVzYyI6Ii0gQ3VzdG9tIGJvbmRpbmcgdGFyZ2V0IGluIG1pY3JvLVVTRCAoMCA9IHVzZSBjb250cmFjdCBkZWZhdWx0KS4gTXVzdCBiZSA+PSBjb250cmFjdCBtaW5pbXVtIGlmIHNwZWNpZmllZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlTXVsdGlwbGllciIsImRlc2MiOiItIEN1c3RvbSBwcmljZSBtdWx0aXBsaWVyICg5IGRpZ2l0cyAtIDIwLDAwMCwwMDAsMDAwID0gMjB4KSAoMCA9IHVzZSBjb250cmFjdCBkZWZhdWx0KS4gTXVzdCBiZSA+PSBjb250cmFjdCBtaW5pbXVtIGlmIHNwZWNpZmllZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdUb2tlbiIsImRlc2MiOiItIFRoZSBib25kaW5nIHRva2VuIGFzc2V0IChzZWUgaXNCb25kaW5nVG9rZW5TdXBwb3J0ZWQ7IDAgPSBBTEdPKS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIHNlcXVlbnRpYWwgdG9rZW4gbnVtYmVyIGFzc2lnbmVkIHRvIHRoZSBuZXdseS1jcmVhdGVkIHRva2VuLiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJldmVudFRva2VuTGF1bmNoZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0b3IiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbkFzc2V0SWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbk51bSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdUb2tlbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVuaXROYW1lIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVjaW1hbHMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbFN1cHBseSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluaXRpYWxQcmljZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldFByaWNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9uZGluZ1RhcmdldCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZpcnR1YWxUb2tlblJlc2VydmVzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmlydHVhbEJvbmRpbmdSZXNlcnZlcyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiZXZlbnRUb2tlbnNQdXJjaGFzZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbkFzc2V0SWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbk51bSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdUb2tlbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50QXBwbGllZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZXNQYWlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5zUmVjZWl2ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZUJlZm9yZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlQWZ0ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbkJhbGFuY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWFsVG9rZW5SZXNlcnZlcyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlYWxCb25kaW5nUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImV2ZW50VG9rZW5Cb25kZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbkFzc2V0SWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbk51bSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdUb2tlbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9uZGVkT24iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwbGF0Zm9ybUFwcElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBsYXRmb3JtUG9vbEFjY291bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJscFRva2VuIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9uZGluZ0luTFAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWFsVG9rZW5SZXNlcnZlcyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlYWxCb25kaW5nUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b2tlbkluZm8iLCJkZXNjIjoiUmV0cmlldmVzIHRoZSBpbmZvcm1hdGlvbiBhc3NvY2lhdGVkIHdpdGggYSBzcGVjaWZpYyB0b2tlbiBieSBpdHMgQXNzZXQgSUQuXG5Ob3RlOiBUaGlzIG9ubHkgd29ya3MgYWZ0ZXIgdGhlIGZpcnN0IGJ1eSwgd2hlbiB0aGUgYXNzZXRNYXAgaXMgcG9wdWxhdGVkLlxuVXNlIHRva2VuSW5mb0J5TnVtKCkgZm9yIHRva2VucyB0aGF0IGhhdmVuJ3QgYmVlbiBib3VnaHQgeWV0LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbiIsImRlc2MiOiItIFRoZSBBc3NldCBJRCBvZiB0aGUgdG9rZW4gd2hvc2UgaW5mb3JtYXRpb24gaXMgYmVpbmcgcmV0cmlldmVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYnl0ZVsxXSx1aW50NjQsYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYnl0ZVs4XSxieXRlWzMyXSxieXRlWzk2XSxieXRlWzEwMjRdLGJ5dGVbMjU2XSxieXRlWzY0XSxieXRlWzY0XSxieXRlWzY0XSx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlRva2VuSW5mbyIsImRlc2MiOiJUaGUgaW5mb3JtYXRpb24gYXNzb2NpYXRlZCB3aXRoIHRoZSBwcm92aWRlZCBBc3NldC4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRva2VuSW5mb0J5TnVtIiwiZGVzYyI6IlJldHJpZXZlcyB0aGUgaW5mb3JtYXRpb24gYXNzb2NpYXRlZCB3aXRoIGEgc3BlY2lmaWMgdG9rZW4gYnkgaXRzIHNlcXVlbnRpYWwgdG9rZW4gbnVtYmVyLlxuVGhpcyB3b3JrcyBpbW1lZGlhdGVseSBhZnRlciBsYXVuY2gsIGJlZm9yZSBhbnkgYnV5cy4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjoiLSBUaGUgc2VxdWVudGlhbCB0b2tlbiBudW1iZXIgYXNzaWduZWQgYXQgbGF1bmNoIHRpbWUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlWzFdLHVpbnQ2NCxhZGRyZXNzLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCxieXRlWzhdLGJ5dGVbMzJdLGJ5dGVbOTZdLGJ5dGVbMTAyNF0sYnl0ZVsyNTZdLGJ5dGVbNjRdLGJ5dGVbNjRdLGJ5dGVbNjRdLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiVG9rZW5JbmZvIiwiZGVzYyI6IlRoZSBpbmZvcm1hdGlvbiBhc3NvY2lhdGVkIHdpdGggdGhlIHByb3ZpZGVkIHRva2VuTnVtLiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VG9rZW5OdW1Gb3JBc3NldCIsImRlc2MiOiJHZXRzIHRoZSB0b2tlbiBudW1iZXIgZm9yIGEgZ2l2ZW4gQXNzZXQgSUQuXG5Pbmx5IHdvcmtzIGFmdGVyIHRoZSBmaXJzdCBidXksIHdoZW4gdGhlIGFzc2V0TWFwIGlzIHBvcHVsYXRlZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjoiLSBUaGUgQXNzZXQgSUQgdG8gbG9vayB1cC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIHNlcXVlbnRpYWwgdG9rZW4gbnVtYmVyIGZvciB0aGUgYXNzZXQuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcmljZSIsImRlc2MiOiJSZXR1cm5zIHRoZSBjdXJyZW50IGluc3RhbnRhbmVvdXMgcHJpY2UgZm9yIGEgdG9rZW4gKG1pY3JvLWJvbmRpbmctdG9rZW4gcGVyIG1pY3JvLXRva2VuKS5cbk5vdGU6IFJlcXVpcmVzIGFzc2V0TWFwIHRvIGJlIHBvcHVsYXRlZCAoYWZ0ZXIgZmlyc3QgYnV5KS4gVXNlIHRva2VuSW5mb0J5TnVtIGZvciB1bmJvdWdodCB0b2tlbnMuXG5cblByaWNlID0gdmlydHVhbEJvbmRpbmdSZXNlcnZlcyAvIHZpcnR1YWxUb2tlblJlc2VydmVzIChzY2FsZWQgYnkgU0NBTEUpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuIiwiZGVzYyI6Ii0gVGhlIEFzc2V0IElEIG9mIHRoZSB0b2tlbiB0byByZXRyaWV2ZSB0aGUgcHJpY2UgZm9yLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgY3VycmVudCBwcmljZSBpbiBtaWNyby1ib25kaW5nLXRva2VuIHBlciBtaWNyby10b2tlbiAoc2NhbGVkKS4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvc3RUb0J1eSIsImRlc2MiOiJDYWxjdWxhdGVzIHRoZSBib25kaW5nIHRva2VuIGNvc3QgcmVxdWlyZWQgdG8gYnV5IGEgc3BlY2lmaWMgYW1vdW50IG9mIHRva2Vucy5cbk5vdGU6IFJlcXVpcmVzIGFzc2V0TWFwIHRvIGJlIHBvcHVsYXRlZCAoYWZ0ZXIgZmlyc3QgYnV5KS4gVXNlIHRva2VuSW5mb0J5TnVtIGZvciB1bmJvdWdodCB0b2tlbnMuXG5cblVzZXMgY29uc3RhbnQgcHJvZHVjdCBmb3JtdWxhOiBuZXdWaXJ0dWFsQm9uZGluZyA9IGsgLyBuZXdWaXJ0dWFsVG9rZW5cbkJvbmRpbmcgdG9rZW5zIG5lZWRlZCA9IG5ld1ZpcnR1YWxCb25kaW5nIC0gY3VycmVudFZpcnR1YWxCb25kaW5nIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuIiwiZGVzYyI6Ii0gVGhlIEFzc2V0IElEIG9mIHRoZSB0b2tlbiB0byBidXkuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbnNPdXQiLCJkZXNjIjoiLSBUaGUgYW1vdW50IG9mIHRva2VucyB0byBwdXJjaGFzZS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGNhbGN1bGF0ZWQgY29zdCBpbiBib25kaW5nIHRva2VucyB0byBidXkgdGhlIHNwZWNpZmllZCBudW1iZXIgb2YgdG9rZW5zLiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9rZW5zUmVjZWl2ZWRGb3JCdXkiLCJkZXNjIjoiUmV0dXJucyB0aGUgdG9rZW5zIHRoYXQgd291bGQgYmUgcmVjZWl2ZWQgZm9yIGJ1eWluZyB3aXRoIGEgZ2l2ZW4gYW1vdW50IG9mIGJvbmRpbmcgdG9rZW5zLlxuVGhpcyBpcyBhIGJ1eSBwcmV2aWV3IHRoYXQgbWlycm9ycyB0aGUgYnV5KCkgbWV0aG9kIGV4YWN0bHkgKGZlZXMgYXJlIGRlZHVjdGVkIGZpcnN0KS5cblxuVXNlcyBjb25zdGFudCBwcm9kdWN0IGZvcm11bGE6IG5ld1ZpcnR1YWxCb25kaW5nID0gdmlydHVhbEJvbmRpbmcgKyBib25kaW5nSW4gKGFmdGVyIGZlZXMpXG5uZXdWaXJ0dWFsVG9rZW4gPSBrIC8gbmV3VmlydHVhbEJvbmRpbmdcbnRva2Vuc091dCA9IHZpcnR1YWxUb2tlbiAtIG5ld1ZpcnR1YWxUb2tlbiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbk51bSIsImRlc2MiOiItIFRoZSBzZXF1ZW50aWFsIHRva2VuIG51bWJlciBhc3NpZ25lZCBhdCBsYXVuY2ggdGltZS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdJbiIsImRlc2MiOiItIFRoZSBhbW91bnQgb2YgYm9uZGluZyB0b2tlbnMgdG8gc3BlbmQuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBudW1iZXIgb2YgdG9rZW5zIHJlY2VpdmVkIGZvciB0aGUgc3BlY2lmaWVkIGJvbmRpbmcgdG9rZW4gYW1vdW50IChhZnRlciBmZWVzKS4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJvbmRpbmdSZWNlaXZlZEZvclNlbGwiLCJkZXNjIjoiUmV0dXJucyB0aGUgYm9uZGluZyB0b2tlbnMgdGhhdCB3b3VsZCBiZSByZWNlaXZlZCBmb3Igc2VsbGluZyBhIGdpdmVuIGFtb3VudCBvZiB0b2tlbnMuXG5UaGlzIGlzIGEgc2VsbCBwcmV2aWV3IHRoYXQgbWlycm9ycyB0aGUgc2VsbCgpIG1ldGhvZCBleGFjdGx5LlxuXG5Vc2VzIGNvbnN0YW50IHByb2R1Y3QgZm9ybXVsYTogbmV3VmlydHVhbFRva2VuID0gdmlydHVhbFRva2VuICsgdG9rZW5zSW5cbm5ld1ZpcnR1YWxCb25kaW5nID0gayAvIG5ld1ZpcnR1YWxUb2tlblxuYm9uZGluZ091dCA9IHZpcnR1YWxCb25kaW5nIC0gbmV3VmlydHVhbEJvbmRpbmcgKGNhcHBlZCBieSByZWFsQm9uZGluZ1Jlc2VydmVzKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbk51bSIsImRlc2MiOiItIFRoZSBzZXF1ZW50aWFsIHRva2VuIG51bWJlciBhc3NpZ25lZCBhdCBsYXVuY2ggdGltZS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2Vuc1RvU2VsbCIsImRlc2MiOiItIFRoZSBhbW91bnQgb2YgdG9rZW5zIHRvIHNlbGwuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBhbW91bnQgb2YgYm9uZGluZyB0b2tlbnMgcmVjZWl2ZWQgKGFmdGVyIGZlZXMpLiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm9uZGluZ1Byb2dyZXNzIiwiZGVzYyI6IlJldHVybnMgdGhlIGJvbmRpbmcgcHJvZ3Jlc3MgYXMgYSBwZXJjZW50YWdlICgwLTEwMCwgc2NhbGVkIGJ5IFNDQUxFKS5cbk5vdGU6IFJlcXVpcmVzIGFzc2V0TWFwIHRvIGJlIHBvcHVsYXRlZCAoYWZ0ZXIgZmlyc3QgYnV5KS5cblxuUHJvZ3Jlc3MgPSAoaW5pdGlhbFJlYWxUb2tlblJlc2VydmVzIC0gcmVhbFRva2VuUmVzZXJ2ZXMpIC8gaW5pdGlhbFJlYWxUb2tlblJlc2VydmVzICogMTAwICogU0NBTEUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW4iLCJkZXNjIjoiLSBUaGUgQXNzZXQgSUQgb2YgdGhlIHRva2VuLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJCb25kaW5nIHByb2dyZXNzIGFzIHBlcmNlbnRhZ2Ugc2NhbGVkIGJ5IFNDQUxFICgwIHRvIDEwMF8wMDBfMDAwXzAwMCByZXByZXNlbnRpbmcgMC0xMDAlKS4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1hcmtldENhcCIsImRlc2MiOiJSZXR1cm5zIHRoZSBjdXJyZW50IG1hcmtldCBjYXAgaW4gbWljcm8tYm9uZGluZy10b2tlbi5cbk1hcmtldENhcCA9IGN1cnJlbnRQcmljZSAqIHRvdGFsU3VwcGx5IiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuIiwiZGVzYyI6Ii0gVGhlIEFzc2V0IElEIG9mIHRoZSB0b2tlbi4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiTWFya2V0IGNhcCBpbiBtaWNyby1ib25kaW5nLXRva2VuLiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJldmlld0JvbmRpbmciLCJkZXNjIjoiUHJldmlldyBib25kaW5nIG1ldHJpY3MgZm9yIGdpdmVuIHBhcmFtZXRlcnMuXG5BbGxvd3MgY2FsbGVycyB0byBzaW11bGF0ZSBcIndoYXQgaWYgSSB3YW50IGJvbmRpbmcgdG8gYmUgJFggd2l0aCBZIGJvbmRpbmcgdG9rZW4gcHJpY2UgYW5kIFogbXVsdGlwbGllcj9cIiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25kaW5nVG9rZW4iLCJkZXNjIjoiLSBUaGUgYm9uZGluZyB0b2tlbiBhc3NldCAoMCA9IEFMR08pIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXRCb25kaW5nVXNkIiwiZGVzYyI6Ii0gVGFyZ2V0IGJvbmRpbmcgVVNEIGFtb3VudCAoMCA9IHVzZSBjb250cmFjdCBkZWZhdWx0KSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VNdWx0aXBsaWVyIiwiZGVzYyI6Ii0gUHJpY2UgaW5jcmVhc2UgZmFjdG9yICgwID0gdXNlIGNvbnRyYWN0IGRlZmF1bHQpIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQm9uZGluZ1ByZXZpZXciLCJkZXNjIjoiUHJldmlldyBvZiBhbGwgYm9uZGluZyBtZXRyaWNzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJidXkiLCJkZXNjIjoiRXhlY3V0ZXMgYSB0b2tlbiBwdXJjaGFzZSB1c2luZyBhIGJvbmRpbmcgY3VydmUgbWVjaGFuaXNtIHdpdGggY29uc3RhbnQgcHJvZHVjdCBmb3JtdWxhLlxuVmFsaWRhdGVzIHRoZSBwYXltZW50LCBjYWxjdWxhdGVzIGZlZXMgYW5kIHRva2VucyB0byBiZSByZWNlaXZlZCwgdXBkYXRlcyByZXNlcnZlcyxcbmhhbmRsZXMgcmVmdW5kcyBmb3IgZXhjZXNzIHBheW1lbnRzIG9yIGNvbXBsZXRlZCBib25kaW5nLCBhbmQgdXBkYXRlcyB1c2VyIGJhbGFuY2VzLlxuSWYgYWxsIHJlYWwgdG9rZW4gcmVzZXJ2ZXMgYXJlIGRlcGxldGVkIGR1cmluZyB0aGUgcHVyY2hhc2UsIHRyaWdnZXJzIGJvbmRpbmcgY29tcGxldGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjoiLSBUaGUgdW5pcXVlIGlkZW50aWZpZXIgb2YgdGhlIHRva2VuIHRvIHB1cmNoYXNlIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXltZW50IiwiZGVzYyI6Ii0gUGF5bWVudCBjb3ZlcmluZyBNQlIgZm9yIHVzZXIgYmFsYW5jZSBib3ggKHVzZSBtYnJUb0J1eSgpIHRvIGdldCByZXF1aXJlZCBhbW91bnQ7IDAgaWYgdXNlciBhbHJlYWR5IGhhcyBhIGJhbGFuY2UpIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjoiLSBUaGUgYXNzZXQgdHJhbnNmZXIgdHJhbnNhY3Rpb24gY29udGFpbmluZyB0aGUgYm9uZGluZyB0b2tlbiBwYXltZW50IiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBhbW91bnQgb2YgdG9rZW5zIHB1cmNoYXNlZCBhbmQgdHJhbnNmZXJyZWQgdG8gdGhlIGJ1eWVyLCBvciAwIGlmIGJvbmRpbmcgaXMgY29tcGxldGUgb3Igbm8gdG9rZW5zIGNhbiBiZSBwdXJjaGFzZWQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiZXZlbnRUb2tlbnNQdXJjaGFzZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbkFzc2V0SWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbk51bSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdUb2tlbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50QXBwbGllZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZXNQYWlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5zUmVjZWl2ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZUJlZm9yZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlQWZ0ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbkJhbGFuY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWFsVG9rZW5SZXNlcnZlcyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlYWxCb25kaW5nUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6ImV2ZW50VG9rZW5Cb25kZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbkFzc2V0SWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbk51bSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdUb2tlbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9uZGVkT24iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwbGF0Zm9ybUFwcElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBsYXRmb3JtUG9vbEFjY291bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJscFRva2VuIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9uZGluZ0luTFAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWFsVG9rZW5SZXNlcnZlcyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlYWxCb25kaW5nUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJidXlXaXRoTGltaXQiLCJkZXNjIjoiQnV5IHRva2VucyB3aXRoIHNsaXBwYWdlIHByb3RlY3Rpb24uXG5GYWlscyBpZiB0aGUgdG9rZW5zIHJlY2VpdmVkIGlzIGxlc3MgdGhhbiB0aGUgc3BlY2lmaWVkIG1pbmltdW0uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuTnVtIiwiZGVzYyI6Ii0gVGhlIHVuaXF1ZSBpZGVudGlmaWVyIG9mIHRoZSB0b2tlbiB0byBwdXJjaGFzZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOiItIFBheW1lbnQgY292ZXJpbmcgTUJSIGZvciB1c2VyIGJhbGFuY2UgYm94ICh1c2UgbWJyVG9CdXkoKSB0byBnZXQgcmVxdWlyZWQgYW1vdW50OyAwIGlmIHVzZXIgYWxyZWFkeSBoYXMgYSBiYWxhbmNlKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6Ii0gVGhlIGFzc2V0IHRyYW5zZmVyIHRyYW5zYWN0aW9uIGNvbnRhaW5pbmcgdGhlIGJvbmRpbmcgdG9rZW4gcGF5bWVudCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWluVG9rZW5zT3V0IiwiZGVzYyI6Ii0gTWluaW11bSB0b2tlbnMgZXhwZWN0ZWQgKHRyYW5zYWN0aW9uIGZhaWxzIGlmIGFjdHVhbCA8IG1pbikiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGFtb3VudCBvZiB0b2tlbnMgcHVyY2hhc2VkIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImV2ZW50VG9rZW5zUHVyY2hhc2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5Bc3NldElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25kaW5nVG9rZW5JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudEFwcGxpZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVzUGFpZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2Vuc1JlY2VpdmVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VCZWZvcmUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZUFmdGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5CYWxhbmNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhbFRva2VuUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWFsQm9uZGluZ1Jlc2VydmVzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJldmVudFRva2VuQm9uZGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5Bc3NldElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25kaW5nVG9rZW5JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRlZE9uIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGxhdGZvcm1BcHBJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwbGF0Zm9ybVBvb2xBY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibHBUb2tlbiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdJbkxQIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhbFRva2VuUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWFsQm9uZGluZ1Jlc2VydmVzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnV5V2l0aEFsZ28iLCJkZXNjIjoiQnV5IHRva2VucyB1c2luZyBBTEdPIGFzIHRoZSBib25kaW5nIHRva2VuLlxuU2ltaWxhciB0byBidXkoKSBidXQgYWNjZXB0cyBhIFBheW1lbnRUeG4gaW5zdGVhZCBvZiBBc3NldFRyYW5zZmVyVHhuLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbk51bSIsImRlc2MiOiItIFRoZSB1bmlxdWUgaWRlbnRpZmllciBvZiB0aGUgdG9rZW4gdG8gcHVyY2hhc2UiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjoiLSBQYXltZW50IGNvdmVyaW5nIE1CUiBmb3IgdXNlciBiYWxhbmNlIGJveCAodXNlIG1iclRvQnV5KCkgdG8gZ2V0IHJlcXVpcmVkIGFtb3VudDsgMCBpZiB1c2VyIGFscmVhZHkgaGFzIGEgYmFsYW5jZSkiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjoiLSBUaGUgcGF5bWVudCB0cmFuc2FjdGlvbiBjb250YWluaW5nIHRoZSBBTEdPIHBheW1lbnQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGFtb3VudCBvZiB0b2tlbnMgcHVyY2hhc2VkIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImV2ZW50VG9rZW5zUHVyY2hhc2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5Bc3NldElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25kaW5nVG9rZW5JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudEFwcGxpZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVzUGFpZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2Vuc1JlY2VpdmVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VCZWZvcmUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZUFmdGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5CYWxhbmNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhbFRva2VuUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWFsQm9uZGluZ1Jlc2VydmVzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJldmVudFRva2VuQm9uZGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5Bc3NldElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25kaW5nVG9rZW5JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRlZE9uIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGxhdGZvcm1BcHBJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwbGF0Zm9ybVBvb2xBY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibHBUb2tlbiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdJbkxQIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhbFRva2VuUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWFsQm9uZGluZ1Jlc2VydmVzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnV5V2l0aEFsZ29XaXRoTGltaXQiLCJkZXNjIjoiQnV5IHRva2VucyB3aXRoIEFMR08gYW5kIHNsaXBwYWdlIHByb3RlY3Rpb24uXG5GYWlscyBpZiB0aGUgdG9rZW5zIHJlY2VpdmVkIGlzIGxlc3MgdGhhbiB0aGUgc3BlY2lmaWVkIG1pbmltdW0uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuTnVtIiwiZGVzYyI6Ii0gVGhlIHVuaXF1ZSBpZGVudGlmaWVyIG9mIHRoZSB0b2tlbiB0byBwdXJjaGFzZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5bWVudCIsImRlc2MiOiItIFBheW1lbnQgY292ZXJpbmcgTUJSIGZvciB1c2VyIGJhbGFuY2UgYm94ICh1c2UgbWJyVG9CdXkoKSB0byBnZXQgcmVxdWlyZWQgYW1vdW50OyAwIGlmIHVzZXIgYWxyZWFkeSBoYXMgYSBiYWxhbmNlKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOiItIFRoZSBwYXltZW50IHRyYW5zYWN0aW9uIGNvbnRhaW5pbmcgdGhlIEFMR08gcGF5bWVudCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWluVG9rZW5zT3V0IiwiZGVzYyI6Ii0gTWluaW11bSB0b2tlbnMgZXhwZWN0ZWQgKHRyYW5zYWN0aW9uIGZhaWxzIGlmIGFjdHVhbCA8IG1pbikiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjoiVGhlIGFtb3VudCBvZiB0b2tlbnMgcHVyY2hhc2VkIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImV2ZW50VG9rZW5zUHVyY2hhc2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5Bc3NldElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25kaW5nVG9rZW5JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudEFwcGxpZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVzUGFpZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2Vuc1JlY2VpdmVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VCZWZvcmUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZUFmdGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5CYWxhbmNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhbFRva2VuUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWFsQm9uZGluZ1Jlc2VydmVzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJldmVudFRva2VuQm9uZGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5Bc3NldElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25kaW5nVG9rZW5JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRlZE9uIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGxhdGZvcm1BcHBJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwbGF0Zm9ybVBvb2xBY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibHBUb2tlbiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdJbkxQIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhbFRva2VuUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWFsQm9uZGluZ1Jlc2VydmVzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibGF1bmNoVG9rZW5UaGVuQnV5V2l0aEFsZ28iLCJkZXNjIjoiTGF1bmNoZXMgYSB0b2tlbiB3aXRoIEFMR08gYm9uZGluZyBhbmQgcGVyZm9ybXMgYW4gaW5pdGlhbCBwdXJjaGFzZSB1c2luZyBBTEdPLlxuU2ltaWxhciB0byBsYXVuY2hUb2tlblRoZW5CdXkgYnV0IGZvciBBTEdPIHBhaXJzLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXltZW50IiwiZGVzYyI6Ii0gVGhlIHBheW1lbnQgdHJhbnNhY3Rpb24gY292ZXJpbmcgYm90aCBsYXVuY2ggYW5kIGZpcnN0IGJ1eSBNQlIgY29zdHMuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJidXlQYXltZW50IiwiZGVzYyI6Ii0gVGhlIHBheW1lbnQgdHJhbnNhY3Rpb24gZm9yIHRoZSBpbml0aWFsIEFMR08gcHVyY2hhc2UuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzeW1ib2wiLCJkZXNjIjoiLSBUaGUgc3ltYm9sIG9mIHRoZSB0b2tlbiB0byBiZSBjcmVhdGVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOiItIFRoZSBuYW1lIG9mIHRoZSB0b2tlbiB0byBiZSBjcmVhdGVkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRVcmwiLCJkZXNjIjoiLSBUaGUgVVJMIGZvciB0aGUgdG9rZW4gbWV0YWRhdGEuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXNjcmlwdGlvbiIsImRlc2MiOiItIEEgZGVzY3JpcHRpb24gb2YgdGhlIHRva2VuLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic29jaWFsV2Vic2l0ZSIsImRlc2MiOiItIFRoZSB0b2tlbidzIG9mZmljaWFsIHdlYnNpdGUgVVJMLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic29jaWFsWCIsImRlc2MiOiItIFRoZSB0b2tlbidzIFggKFR3aXR0ZXIpIGhhbmRsZS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNvY2lhbFRlbGVncmFtIiwiZGVzYyI6Ii0gVGhlIHRva2VuJ3MgVGVsZWdyYW0gbGluay4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNvY2lhbERpc2NvcmQiLCJkZXNjIjoiLSBUaGUgdG9rZW4ncyBEaXNjb3JkIGxpbmsuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXRCb25kaW5nVXNkIiwiZGVzYyI6Ii0gQ3VzdG9tIGJvbmRpbmcgdGFyZ2V0IGluIG1pY3JvLVVTRCAoMCA9IHVzZSBjb250cmFjdCBkZWZhdWx0KS4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlTXVsdGlwbGllciIsImRlc2MiOiItIEN1c3RvbSBwcmljZSBtdWx0aXBsaWVyICgwID0gdXNlIGNvbnRyYWN0IGRlZmF1bHQpLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgc2VxdWVudGlhbCB0b2tlbiBudW1iZXIgYXNzaWduZWQgdG8gdGhlIG5ld2x5LWNyZWF0ZWQgdG9rZW4uIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImV2ZW50VG9rZW5MYXVuY2hlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRvciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuQXNzZXRJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuTnVtIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9uZGluZ1Rva2VuSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidW5pdE5hbWUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWNpbWFscyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsU3VwcGx5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5pdGlhbFByaWNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0UHJpY2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25kaW5nVGFyZ2V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmlydHVhbFRva2VuUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2aXJ0dWFsQm9uZGluZ1Jlc2VydmVzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJldmVudFRva2Vuc1B1cmNoYXNlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuQXNzZXRJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuTnVtIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9uZGluZ1Rva2VuSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRBcHBsaWVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlc1BhaWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbnNSZWNlaXZlZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlQmVmb3JlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VBZnRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuQmFsYW5jZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlYWxUb2tlblJlc2VydmVzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhbEJvbmRpbmdSZXNlcnZlcyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiZXZlbnRUb2tlbkJvbmRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuQXNzZXRJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuTnVtIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9uZGluZ1Rva2VuSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25kZWRPbiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBsYXRmb3JtQXBwSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGxhdGZvcm1Qb29sQWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxwVG9rZW4iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25kaW5nSW5MUCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlYWxUb2tlblJlc2VydmVzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhbEJvbmRpbmdSZXNlcnZlcyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNlbGwiLCJkZXNjIjoiUHJvY2Vzc2VzIHRoZSBzYWxlIG9mIHRva2VucyB1c2luZyBjb25zdGFudCBwcm9kdWN0IEFNTS5cblVzZXIgc2VsbHMgdG9rZW5zIGJhY2ssIHJlY2VpdmVzIGJvbmRpbmcgdG9rZW4gbWludXMgZmVlcy4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjoiLSBUaGUgc2VxdWVudGlhbCB0b2tlbiBudW1iZXIgYXNzaWduZWQgYXQgbGF1bmNoIHRpbWUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbnNUb1NlbGwiLCJkZXNjIjoiLSBUaGUgbnVtYmVyIG9mIHRva2VucyB0byBiZSBzb2xkLiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgYW1vdW50IG9mIGJvbmRpbmcgdG9rZW5zIHJldHVybmVkIHRvIHRoZSB1c2VyIChhZnRlciBmZWVzIGRlZHVjdGVkKS4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiZXZlbnRUb2tlbnNTb2xkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5Bc3NldElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25kaW5nVG9rZW5JZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2Vuc1NvbGQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib25kaW5nVG9rZW5SZWNlaXZlZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZXNQYWlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VCZWZvcmUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZUFmdGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5CYWxhbmNlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhbFRva2VuUmVzZXJ2ZXMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWFsQm9uZGluZ1Jlc2VydmVzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2VsbFdpdGhMaW1pdCIsImRlc2MiOiJTZWxsIHRva2VucyB3aXRoIHNsaXBwYWdlIHByb3RlY3Rpb24uXG5GYWlscyBpZiB0aGUgYm9uZGluZyB0b2tlbnMgcmVjZWl2ZWQgaXMgbGVzcyB0aGFuIHRoZSBzcGVjaWZpZWQgbWluaW11bS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjoiLSBUaGUgc2VxdWVudGlhbCB0b2tlbiBudW1iZXIgYXNzaWduZWQgYXQgbGF1bmNoIHRpbWUiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2Vuc1RvU2VsbCIsImRlc2MiOiItIFRoZSBudW1iZXIgb2YgdG9rZW5zIHRvIHNlbGwiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pbkJvbmRpbmdPdXQiLCJkZXNjIjoiLSBNaW5pbXVtIGJvbmRpbmcgdG9rZW5zIGV4cGVjdGVkICh0cmFuc2FjdGlvbiBmYWlscyBpZiBhY3R1YWwgPCBtaW4pIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBhbW91bnQgb2YgYm9uZGluZyB0b2tlbnMgcmVjZWl2ZWQgKGFmdGVyIGZlZXMpIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImV2ZW50VG9rZW5zU29sZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuQXNzZXRJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuTnVtIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9uZGluZ1Rva2VuSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbnNTb2xkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9uZGluZ1Rva2VuUmVjZWl2ZWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVzUGFpZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlQmVmb3JlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2VBZnRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuQmFsYW5jZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlYWxUb2tlblJlc2VydmVzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhbEJvbmRpbmdSZXNlcnZlcyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltIiwiZGVzYyI6IkNsYWltcyB2aXJ0dWFsIHRva2VuIGhvbGRpbmdzIGFzIGFjdHVhbCBBU0EgdG9rZW5zIGFmdGVyIGJvbmRpbmcgY29tcGxldGVzLlxuVXNlcnMgbXVzdCBvcHQtaW4gdG8gdGhlIEFTQSBiZWZvcmUgY2FsbGluZyB0aGlzIG1ldGhvZC5cblRoZSB1c2VyJ3MgYmFsYW5jZSBib3ggaXMgZGVsZXRlZCBhbmQgdGhlIE1CUiBpcyByZWZ1bmRlZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjoiLSBUaGUgc2VxdWVudGlhbCB0b2tlbiBudW1iZXIgYXNzaWduZWQgYXQgbGF1bmNoIHRpbWUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBhbW91bnQgb2YgdG9rZW5zIGNsYWltZWQuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImV2ZW50VG9rZW5zQ2xhaW1lZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuQXNzZXRJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuTnVtIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50Q2xhaW1lZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsYWltUG9vbEZlZXMiLCJkZXNjIjoiU3dlZXBzIGEgYm9uZGVkIHRva2VuJ3MgUGFjdCBWMiBtYW5hZ2VyIGZlZXMgdG8gaXRzIGNyZWF0b3IuXG5cblRoaXMgYXBwIGlzIGV2ZXJ5IFYyIHBvb2wncyBtYW5hZ2VyLCBzbyBQYWN0IHBheXMgdGhlIGZlZXMgaGVyZSAoY2xhaW1fZmVlcyk7IHRoZXkgYXJlXG5mb3J3YXJkZWQgdG8gdG9rZW5DcmVhdG9yIGluIHRoZSBzYW1lIGNhbGwuIENhbGxhYmxlIGJ5IGFueW9uZSAtIGZ1bmRzIG9ubHkgZXZlciBnbyB0b1xudGhlIGNyZWF0b3IsIGFuZCB0aGUgY2FsbGVyIHBheXMgdGhlIGZlZXMuXG5cblRoZSBhbW91bnRzIGZvcndhcmRlZCBhcmUgdGhlIGJhbGFuY2UgZGVsdGFzIGFjcm9zcyBjbGFpbV9mZWVzLCBuZXZlciBiYWxhbmNlczogdGhpc1xuYWNjb3VudCBhbHNvIGN1c3RvZGllcyB1bmNsYWltZWQgYnV5ZXIgdG9rZW5zIGFuZCBvdGhlciB0b2tlbnMnIEFMR08gcmVzZXJ2ZXMuXG5cbklmIHRoZSBjcmVhdG9yIGNhbm5vdCByZWNlaXZlIGEgc2lkZSB3aXRoIGZlZXMgdG8gcGF5IChvcHRlZCBvdXQgb2YgdGhlIHRva2VuIG9yIHRoZVxuYm9uZGluZyBhc3NldCwgb3IgYSBjbG9zZWQgYWNjb3VudCBiZWxvdyB0aGUgQUxHTyBiYXNlIE1CUiksIHRoZSB3aG9sZSBjYWxsIHJldmVydHMgYW5kXG50aGUgZmVlcyBzdGF5IGluIHRoZSBwb29sIHVudGlsIHRoZXkgY2FuIC0gbm9ib2R5IGVsc2UgaXMgZW50aXRsZWQgdG8gdGhlbS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjoiLSBUaGUgc2VxdWVudGlhbCB0b2tlbiBudW1iZXIgYXNzaWduZWQgYXQgbGF1bmNoIHRpbWUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlBvb2xGZWVzIiwiZGVzYyI6IlRoZSBhbW91bnRzIHBhaWQgdG8gdGhlIGNyZWF0b3IuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6ImV2ZW50UG9vbEZlZXNDbGFpbWVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVhdG9yIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5Bc3NldElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sQXBwSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbkFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJvbmRpbmdUb2tlbklkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm9uZGluZ0Ftb3VudCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBlbmRpbmdQb29sRmVlcyIsImRlc2MiOiJNYW5hZ2VyIGZlZXMgYSBjbGFpbVBvb2xGZWVzKCkgY2FsbCB3b3VsZCBwYXkgdGhlIGNyZWF0b3IgcmlnaHQgbm93OiB0aGUgcG9vbCdzIG93blxuaG9sZGluZ3MsIHdoaWNoIGlzIGV4YWN0bHkgd2hhdCBQYWN0J3MgY2xhaW1fZmVlcyBzd2VlcHMgLSBhbiBBU0EncyB3aG9sZSBiYWxhbmNlLFxuQUxHTydzIGJhbGFuY2UgYWJvdmUgdGhlIHBvb2wncyBtaW4gYmFsYW5jZS4gWmVybyBmb3IgYSB0b2tlbiB3aXRob3V0IGEgVjIgcG9vbC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5OdW0iLCJkZXNjIjoiLSBUaGUgc2VxdWVudGlhbCB0b2tlbiBudW1iZXIgYXNzaWduZWQgYXQgbGF1bmNoIHRpbWUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlBvb2xGZWVzIiwiZGVzYyI6IlRoZSBwZW5kaW5nIHRva2VuIGFuZCBib25kaW5nLXRva2VuIGFtb3VudHMuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjpudWxsLCJiYXJlQWN0aW9ucyI6bnVsbCwic291cmNlSW5mbyI6bnVsbCwic291cmNlIjpudWxsLCJieXRlQ29kZSI6bnVsbCwiY29tcGlsZXJJbmZvIjpudWxsLCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
