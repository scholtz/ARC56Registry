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

namespace Arc56.Generated.LoafPickleWW.wen_tools.WenPadSaleFactory_74942e87
{


    public class WenPadSaleFactoryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public WenPadSaleFactoryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class SaleRecord : AVMObjectType
            {
                public ulong App { get; set; }

                public Algorand.Address Admin { get; set; }

                public Algorand.Address Distribution { get; set; }

                public Algorand.Address Payout { get; set; }

                public ulong Price { get; set; }

                public ulong StartRound { get; set; }

                public ulong EndRound { get; set; }

                public ulong TotalItems { get; set; }

                public ulong Sold { get; set; }

                public ulong Status { get; set; }

                public ulong CreatedRound { get; set; }

                public ulong Volume { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vApp.From(App);
                    ret.AddRange(vApp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAdmin.From(Admin);
                    ret.AddRange(vAdmin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDistribution = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vDistribution.From(Distribution);
                    ret.AddRange(vDistribution.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayout = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPayout.From(Payout);
                    ret.AddRange(vPayout.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrice.From(Price);
                    ret.AddRange(vPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStartRound.From(StartRound);
                    ret.AddRange(vStartRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEndRound.From(EndRound);
                    ret.AddRange(vEndRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalItems = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalItems.From(TotalItems);
                    ret.AddRange(vTotalItems.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSold = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSold.From(Sold);
                    ret.AddRange(vSold.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedRound.From(CreatedRound);
                    ret.AddRange(vCreatedRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVolume = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVolume.From(Volume);
                    ret.AddRange(vVolume.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SaleRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SaleRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vApp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApp = vApp.ToValue();
                    if (valueApp is ulong vAppValue) { ret.App = vAppValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdmin = vAdmin.ToValue();
                    if (valueAdmin is Algorand.Address vAdminValue) { ret.Admin = vAdminValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDistribution = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDistribution.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDistribution = vDistribution.ToValue();
                    if (valueDistribution is Algorand.Address vDistributionValue) { ret.Distribution = vDistributionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayout = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPayout.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayout = vPayout.ToValue();
                    if (valuePayout is Algorand.Address vPayoutValue) { ret.Payout = vPayoutValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrice = vPrice.ToValue();
                    if (valuePrice is ulong vPriceValue) { ret.Price = vPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStartRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStartRound = vStartRound.ToValue();
                    if (valueStartRound is ulong vStartRoundValue) { ret.StartRound = vStartRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEndRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEndRound = vEndRound.ToValue();
                    if (valueEndRound is ulong vEndRoundValue) { ret.EndRound = vEndRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalItems = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalItems.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalItems = vTotalItems.ToValue();
                    if (valueTotalItems is ulong vTotalItemsValue) { ret.TotalItems = vTotalItemsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSold = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSold.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSold = vSold.ToValue();
                    if (valueSold is ulong vSoldValue) { ret.Sold = vSoldValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedRound = vCreatedRound.ToValue();
                    if (valueCreatedRound is ulong vCreatedRoundValue) { ret.CreatedRound = vCreatedRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVolume = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVolume.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVolume = vVolume.ToValue();
                    if (valueVolume is ulong vVolumeValue) { ret.Volume = vVolumeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SaleRecord);
                }
                public bool Equals(SaleRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SaleRecord left, SaleRecord right)
                {
                    return EqualityComparer<SaleRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(SaleRecord left, SaleRecord right)
                {
                    return !(left == right);
                }

            }

            public class SaleMetadata : AVMObjectType
            {
                public string Name { get; set; }

                public string UnitName { get; set; }

                public string Standard { get; set; }

                public string MetadataUrl { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.From(UnitName);
                    stringRef[ret.Count] = vUnitName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStandard = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vStandard.From(Standard);
                    stringRef[ret.Count] = vStandard.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadataUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMetadataUrl.From(MetadataUrl);
                    stringRef[ret.Count] = vMetadataUrl.Encode();
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

                public static SaleMetadata Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new SaleMetadata();
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexUnitName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnitName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vUnitName.Decode(bytes.Skip(indexUnitName + prefixOffset).ToArray());
                    var valueUnitName = vUnitName.ToValue();
                    if (valueUnitName is string vUnitNameValue) { ret.UnitName = vUnitNameValue; }
                    var indexStandard = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStandard = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vStandard.Decode(bytes.Skip(indexStandard + prefixOffset).ToArray());
                    var valueStandard = vStandard.ToValue();
                    if (valueStandard is string vStandardValue) { ret.Standard = vStandardValue; }
                    var indexMetadataUrl = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadataUrl = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMetadataUrl.Decode(bytes.Skip(indexMetadataUrl + prefixOffset).ToArray());
                    var valueMetadataUrl = vMetadataUrl.ToValue();
                    if (valueMetadataUrl is string vMetadataUrlValue) { ret.MetadataUrl = vMetadataUrlValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SaleMetadata);
                }
                public bool Equals(SaleMetadata? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SaleMetadata left, SaleMetadata right)
                {
                    return EqualityComparer<SaleMetadata>.Default.Equals(left, right);
                }
                public static bool operator !=(SaleMetadata left, SaleMetadata right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class SaleCreatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 149, 248, 165, 201 };
                public const string Signature = "SaleCreated(uint64,uint64,address,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong SaleId { get; set; }
                public ulong App { get; set; }
                public Algorand.Address Admin { get; set; }
                public Algorand.Address Distribution { get; set; }

                public static SaleCreatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SaleCreatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSaleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSaleId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSaleId = vSaleId.ToValue();
                    if (valueSaleId is ulong vSaleIdValue) { ret.SaleId = vSaleIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vApp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApp = vApp.ToValue();
                    if (valueApp is ulong vAppValue) { ret.App = vAppValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdmin = vAdmin.ToValue();
                    if (valueAdmin is Algorand.Address vAdminValue) { ret.Admin = vAdminValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDistribution = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDistribution.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDistribution = vDistribution.ToValue();
                    if (valueDistribution is Algorand.Address vDistributionValue) { ret.Distribution = vDistributionValue; }
                    return ret;

                }

            }

            public class SaleSyncedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 154, 143, 70, 172 };
                public const string Signature = "SaleSynced(uint64,uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong SaleId { get; set; }
                public ulong Status { get; set; }
                public ulong TotalItems { get; set; }
                public ulong Sold { get; set; }

                public static SaleSyncedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SaleSyncedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSaleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSaleId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSaleId = vSaleId.ToValue();
                    if (valueSaleId is ulong vSaleIdValue) { ret.SaleId = vSaleIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalItems = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalItems.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalItems = vTotalItems.ToValue();
                    if (valueTotalItems is ulong vTotalItemsValue) { ret.TotalItems = vTotalItemsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSold = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSold.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSold = vSold.ToValue();
                    if (valueSold is ulong vSoldValue) { ret.Sold = vSoldValue; }
                    return ret;

                }

            }

            public class PurchaseEvent
            {
                public static readonly byte[] Selector = new byte[4] { 208, 184, 50, 245 };
                public const string Signature = "Purchase(uint64,uint64,uint64,address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong SaleId { get; set; }
                public ulong App { get; set; }
                public ulong Asset { get; set; }
                public Algorand.Address Buyer { get; set; }
                public ulong Price { get; set; }

                public static PurchaseEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PurchaseEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSaleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSaleId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSaleId = vSaleId.ToValue();
                    if (valueSaleId is ulong vSaleIdValue) { ret.SaleId = vSaleIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vApp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApp = vApp.ToValue();
                    if (valueApp is ulong vAppValue) { ret.App = vAppValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBuyer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBuyer = vBuyer.ToValue();
                    if (valueBuyer is Algorand.Address vBuyerValue) { ret.Buyer = vBuyerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrice = vPrice.ToValue();
                    if (valuePrice is ulong vPriceValue) { ret.Price = vPriceValue; }
                    return ret;

                }

            }

            public class MetadataUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 222, 169, 27, 176 };
                public const string Signature = "MetadataUpdated(uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong SaleId { get; set; }

                public static MetadataUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new MetadataUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSaleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSaleId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSaleId = vSaleId.ToValue();
                    if (valueSaleId is ulong vSaleIdValue) { ret.SaleId = vSaleIdValue; }
                    return ret;

                }

            }

            public class SaleDeletedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 205, 134, 175, 197 };
                public const string Signature = "SaleDeleted(uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong SaleId { get; set; }

                public static SaleDeletedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SaleDeletedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSaleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSaleId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSaleId = vSaleId.ToValue();
                    if (valueSaleId is ulong vSaleIdValue) { ret.SaleId = vSaleIdValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="router"> </param>
        public async Task CreateApplication(ulong router, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 59, 97, 111 };
            var routerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); routerAbi.From(router);

            var result = await base.CallApp(new List<object> { abiHandle, routerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(ulong router, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 59, 97, 111 };
            var routerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); routerAbi.From(router);

            return await base.MakeTransactionList(new List<object> { abiHandle, routerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deploy a new sale app. The sender is the distribution wallet: the creator's connected
        ///wallet that holds the collection and signs the whole setup.  (the manager) controls
        ///the sale once live.  is the packed proceeds split (see PAYOUT_ENTRY_BYTES).
        ///The payment must cover the factory's MBR increase (child app + index boxes) plus
        ///CHILD_SEED; any overpayment is refunded.
        ///</summary>
        /// <param name="mbrPay"> </param>
        /// <param name="admin"> </param>
        /// <param name="payouts"> </param>
        /// <param name="price"> </param>
        /// <param name="startRound"> </param>
        /// <param name="endRound"> </param>
        /// <param name="revealFee"> </param>
        /// <param name="deliveryBudget"> </param>
        /// <param name="name"> </param>
        /// <param name="unitName"> </param>
        /// <param name="standard"> </param>
        /// <param name="metadataUrl"> </param>
        public async Task<ulong> CreateSale(PaymentTransaction mbrPay, Algorand.Address admin, byte[] payouts, ulong price, ulong startRound, ulong endRound, ulong revealFee, ulong deliveryBudget, string name, string unitName, string standard, string metadataUrl, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 16, 160, 239, 52 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var payoutsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payoutsAbi.From(payouts);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var startRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startRoundAbi.From(startRound);
            var endRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); endRoundAbi.From(endRound);
            var revealFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); revealFeeAbi.From(revealFee);
            var deliveryBudgetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deliveryBudgetAbi.From(deliveryBudget);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var unitNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); unitNameAbi.From(unitName);
            var standardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); standardAbi.From(standard);
            var metadataUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadataUrlAbi.From(metadataUrl);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPay, adminAbi, payoutsAbi, priceAbi, startRoundAbi, endRoundAbi, revealFeeAbi, deliveryBudgetAbi, nameAbi, unitNameAbi, standardAbi, metadataUrlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateSale_Transactions(PaymentTransaction mbrPay, Algorand.Address admin, byte[] payouts, ulong price, ulong startRound, ulong endRound, ulong revealFee, ulong deliveryBudget, string name, string unitName, string standard, string metadataUrl, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 16, 160, 239, 52 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var payoutsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); payoutsAbi.From(payouts);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var startRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startRoundAbi.From(startRound);
            var endRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); endRoundAbi.From(endRound);
            var revealFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); revealFeeAbi.From(revealFee);
            var deliveryBudgetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deliveryBudgetAbi.From(deliveryBudget);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var unitNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); unitNameAbi.From(unitName);
            var standardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); standardAbi.From(standard);
            var metadataUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadataUrlAbi.From(metadataUrl);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPay, adminAbi, payoutsAbi, priceAbi, startRoundAbi, endRoundAbi, revealFeeAbi, deliveryBudgetAbi, nameAbi, unitNameAbi, standardAbi, metadataUrlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Called by a sale app whenever its state changes.
        ///</summary>
        /// <param name="saleId"> </param>
        /// <param name="price"> </param>
        /// <param name="endRound"> </param>
        /// <param name="totalItems"> </param>
        /// <param name="sold"> </param>
        /// <param name="status"> </param>
        public async Task SyncSale(ulong saleId, ulong price, ulong endRound, ulong totalItems, ulong sold, ulong status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 102, 200, 226 };
            var saleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); saleIdAbi.From(saleId);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var endRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); endRoundAbi.From(endRound);
            var totalItemsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalItemsAbi.From(totalItems);
            var soldAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); soldAbi.From(sold);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); statusAbi.From(status);

            var result = await base.CallApp(new List<object> { abiHandle, saleIdAbi, priceAbi, endRoundAbi, totalItemsAbi, soldAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SyncSale_Transactions(ulong saleId, ulong price, ulong endRound, ulong totalItems, ulong sold, ulong status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 102, 200, 226 };
            var saleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); saleIdAbi.From(saleId);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var endRoundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); endRoundAbi.From(endRound);
            var totalItemsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); totalItemsAbi.From(totalItems);
            var soldAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); soldAbi.From(sold);
            var statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); statusAbi.From(status);

            return await base.MakeTransactionList(new List<object> { abiHandle, saleIdAbi, priceAbi, endRoundAbi, totalItemsAbi, soldAbi, statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Called by a sale app on every delivered item.
        ///</summary>
        /// <param name="saleId"> </param>
        /// <param name="asset"> </param>
        /// <param name="buyer"> </param>
        /// <param name="price"> </param>
        /// <param name="sold"> </param>
        /// <param name="remaining"> </param>
        public async Task LogPurchase(ulong saleId, ulong asset, Algorand.Address buyer, ulong price, ulong sold, ulong remaining, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 0, 88, 108 };
            var saleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); saleIdAbi.From(saleId);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var soldAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); soldAbi.From(sold);
            var remainingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); remainingAbi.From(remaining);

            var result = await base.CallApp(new List<object> { abiHandle, saleIdAbi, assetAbi, buyerAbi, priceAbi, soldAbi, remainingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogPurchase_Transactions(ulong saleId, ulong asset, Algorand.Address buyer, ulong price, ulong sold, ulong remaining, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 0, 88, 108 };
            var saleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); saleIdAbi.From(saleId);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);
            var priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); priceAbi.From(price);
            var soldAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); soldAbi.From(sold);
            var remainingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); remainingAbi.From(remaining);

            return await base.MakeTransactionList(new List<object> { abiHandle, saleIdAbi, assetAbi, buyerAbi, priceAbi, soldAbi, remainingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin-only. Payment covers any MBR increase; any decrease is refunded.
        ///</summary>
        /// <param name="mbrPay"> </param>
        /// <param name="saleId"> </param>
        /// <param name="name"> </param>
        /// <param name="unitName"> </param>
        /// <param name="standard"> </param>
        /// <param name="metadataUrl"> </param>
        public async Task UpdateMetadata(PaymentTransaction mbrPay, ulong saleId, string name, string unitName, string standard, string metadataUrl, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 46, 197, 47, 237 };
            var saleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); saleIdAbi.From(saleId);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var unitNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); unitNameAbi.From(unitName);
            var standardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); standardAbi.From(standard);
            var metadataUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadataUrlAbi.From(metadataUrl);

            var result = await base.CallApp(new List<object> { abiHandle, mbrPay, saleIdAbi, nameAbi, unitNameAbi, standardAbi, metadataUrlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateMetadata_Transactions(PaymentTransaction mbrPay, ulong saleId, string name, string unitName, string standard, string metadataUrl, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 46, 197, 47, 237 };
            var saleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); saleIdAbi.From(saleId);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var unitNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); unitNameAbi.From(unitName);
            var standardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); standardAbi.From(standard);
            var metadataUrlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadataUrlAbi.From(metadataUrl);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbrPay, saleIdAbi, nameAbi, unitNameAbi, standardAbi, metadataUrlAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Callable by anyone (the keeper closes a Shuffle right after its last delivery). Deletes a
        ///released sale app (after its item pages are freed) and its index entries. Nothing can be
        ///redirected: proceeds go to the payout split, all MBR to the distribution wallet, and the
        ///sale app itself refuses deletion unless it is released with nothing pending. Purchase
        ///history stays in the event logs.
        ///</summary>
        /// <param name="saleId"> </param>
        public async Task DeleteSale(ulong saleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 45, 76, 10 };
            var saleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); saleIdAbi.From(saleId);

            var result = await base.CallApp(new List<object> { abiHandle, saleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteSale_Transactions(ulong saleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 45, 76, 10 };
            var saleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); saleIdAbi.From(saleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, saleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="saleId"> </param>
        public async Task<Structs.SaleRecord> GetSale(ulong saleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 135, 235, 143 };
            var saleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); saleIdAbi.From(saleId);

            var result = await base.SimApp(new List<object> { abiHandle, saleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SaleRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetSale_Transactions(ulong saleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 135, 235, 143 };
            var saleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); saleIdAbi.From(saleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, saleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="saleId"> </param>
        public async Task<Structs.SaleMetadata> GetSaleMetadata(ulong saleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 84, 31, 60 };
            var saleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); saleIdAbi.From(saleId);

            var result = await base.SimApp(new List<object> { abiHandle, saleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SaleMetadata.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetSaleMetadata_Transactions(ulong saleId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 84, 31, 60 };
            var saleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); saleIdAbi.From(saleId);

            return await base.MakeTransactionList(new List<object> { abiHandle, saleIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJXZW5QYWRTYWxlRmFjdG9yeSIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiU2FsZVJlY29yZCI6W3sibmFtZSI6ImFwcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhZG1pbiIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZGlzdHJpYnV0aW9uIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwYXlvdXQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InByaWNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXJ0Um91bmQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZW5kUm91bmQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxJdGVtcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzb2xkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXR1cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjcmVhdGVkUm91bmQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidm9sdW1lIiwidHlwZSI6InVpbnQ2NCJ9XSwiU2FsZU1ldGFkYXRhIjpbeyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ1bml0TmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJzdGFuZGFyZCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJtZXRhZGF0YVVybCIsInR5cGUiOiJzdHJpbmcifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm91dGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVTYWxlIiwiZGVzYyI6IkRlcGxveSBhIG5ldyBzYWxlIGFwcC4gVGhlIHNlbmRlciBpcyB0aGUgZGlzdHJpYnV0aW9uIHdhbGxldDogdGhlIGNyZWF0b3IncyBjb25uZWN0ZWRcbndhbGxldCB0aGF0IGhvbGRzIHRoZSBjb2xsZWN0aW9uIGFuZCBzaWducyB0aGUgd2hvbGUgc2V0dXAuICAodGhlIG1hbmFnZXIpIGNvbnRyb2xzXG50aGUgc2FsZSBvbmNlIGxpdmUuICBpcyB0aGUgcGFja2VkIHByb2NlZWRzIHNwbGl0IChzZWUgUEFZT1VUX0VOVFJZX0JZVEVTKS5cblRoZSBwYXltZW50IG11c3QgY292ZXIgdGhlIGZhY3RvcnkncyBNQlIgaW5jcmVhc2UgKGNoaWxkIGFwcCArIGluZGV4IGJveGVzKSBwbHVzXG5DSElMRF9TRUVEOyBhbnkgb3ZlcnBheW1lbnQgaXMgcmVmdW5kZWQuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXlvdXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhcnRSb3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kUm91bmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJldmVhbEZlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsaXZlcnlCdWRnZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVuaXROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFuZGFyZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWV0YWRhdGFVcmwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOlt7Im5hbWUiOiJTYWxlQ3JlYXRlZCIsImRlc2MiOiIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FsZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRpc3RyaWJ1dGlvbiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InN5bmNTYWxlIiwiZGVzYyI6IkNhbGxlZCBieSBhIHNhbGUgYXBwIHdoZW5ldmVyIGl0cyBzdGF0ZSBjaGFuZ2VzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzYWxlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmRSb3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxJdGVtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic29sZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhdHVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6W3sibmFtZSI6IlNhbGVTeW5jZWQiLCJkZXNjIjoiIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNhbGVJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXR1cyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsSXRlbXMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzb2xkIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoibG9nUHVyY2hhc2UiLCJkZXNjIjoiQ2FsbGVkIGJ5IGEgc2FsZSBhcHAgb24gZXZlcnkgZGVsaXZlcmVkIGl0ZW0uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNhbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJidXllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNvbGQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlbWFpbmluZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOlt7Im5hbWUiOiJQdXJjaGFzZSIsImRlc2MiOiIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FsZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnV5ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InVwZGF0ZU1ldGFkYXRhIiwiZGVzYyI6IkFkbWluLW9ubHkuIFBheW1lbnQgY292ZXJzIGFueSBNQlIgaW5jcmVhc2U7IGFueSBkZWNyZWFzZSBpcyByZWZ1bmRlZC4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyUGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzYWxlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVuaXROYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFuZGFyZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWV0YWRhdGFVcmwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpbeyJuYW1lIjoiTWV0YWRhdGFVcGRhdGVkIiwiZGVzYyI6IiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzYWxlSWQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJkZWxldGVTYWxlIiwiZGVzYyI6IkNhbGxhYmxlIGJ5IGFueW9uZSAodGhlIGtlZXBlciBjbG9zZXMgYSBTaHVmZmxlIHJpZ2h0IGFmdGVyIGl0cyBsYXN0IGRlbGl2ZXJ5KS4gRGVsZXRlcyBhXG5yZWxlYXNlZCBzYWxlIGFwcCAoYWZ0ZXIgaXRzIGl0ZW0gcGFnZXMgYXJlIGZyZWVkKSBhbmQgaXRzIGluZGV4IGVudHJpZXMuIE5vdGhpbmcgY2FuIGJlXG5yZWRpcmVjdGVkOiBwcm9jZWVkcyBnbyB0byB0aGUgcGF5b3V0IHNwbGl0LCBhbGwgTUJSIHRvIHRoZSBkaXN0cmlidXRpb24gd2FsbGV0LCBhbmQgdGhlXG5zYWxlIGFwcCBpdHNlbGYgcmVmdXNlcyBkZWxldGlvbiB1bmxlc3MgaXQgaXMgcmVsZWFzZWQgd2l0aCBub3RoaW5nIHBlbmRpbmcuIFB1cmNoYXNlXG5oaXN0b3J5IHN0YXlzIGluIHRoZSBldmVudCBsb2dzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzYWxlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpbeyJuYW1lIjoiU2FsZURlbGV0ZWQiLCJkZXNjIjoiIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNhbGVJZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImdldFNhbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FsZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJTYWxlUmVjb3JkIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImdldFNhbGVNZXRhZGF0YSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzYWxlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcsc3RyaW5nLHN0cmluZykiLCJzdHJ1Y3QiOiJTYWxlTWV0YWRhdGEiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDbWx1ZEdOaWJHOWpheUF4SURBZ09DQXpNaUEySURRd0lESXdNREF3TUNBeU5UWWdOalFnTVRNMklERTJNQXBpZVhSbFkySnNiMk5ySURCNElEQjROek1nTUhnM05EWm1OelEyTVRaak5XWTNNell4Tm1NMk5UY3pJREI0Tm1RZ01IZ3dNREF3TURBd01EQXdNREF3TURBd0lEQjROelEyWmpjME5qRTJZelZtTnpZMlpqWmpOelUyWkRZMUlEQjRObVUyTlRjNE56UTFaamN6TmpFMll6WTFOV1kyT1RZMElEQjRNVFV4Wmpkak56VWdNSGcyTVRjeU5qTXpOVE01SURCNE1EQXdPQ0F3ZURZekNnb3ZMeUJVYUdseklGUkZRVXdnZDJGeklHZGxibVZ5WVhSbFpDQmllU0JVUlVGTVUyTnlhWEIwSUhZd0xqRXdOeTR5Q2k4dklHaDBkSEJ6T2k4dloybDBhSFZpTG1OdmJTOWhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZWRVZCVEZOamNtbHdkQW9LTHk4Z1ZHaHBjeUJqYjI1MGNtRmpkQ0JwY3lCamIyMXdiR2xoYm5RZ2QybDBhQ0JoYm1RdmIzSWdhVzF3YkdWdFpXNTBjeUIwYUdVZ1ptOXNiRzkzYVc1bklFRlNRM002SUZzZ1FWSkROQ0JkQ2dvdkx5QlVhR1VnWm05c2JHOTNhVzVuSUhSbGJpQnNhVzVsY3lCdlppQlVSVUZNSUdoaGJtUnNaU0JwYm1sMGFXRnNJSEJ5YjJkeVlXMGdabXh2ZHdvdkx5QlVhR2x6SUhCaGRIUmxjbTRnYVhNZ2RYTmxaQ0IwYnlCdFlXdGxJR2wwSUdWaGMza2dabTl5SUdGdWVXOXVaU0IwYnlCd1lYSnpaU0IwYUdVZ2MzUmhjblFnYjJZZ2RHaGxJSEJ5YjJkeVlXMGdZVzVrSUdSbGRHVnliV2x1WlNCcFppQmhJSE53WldOcFptbGpJR0ZqZEdsdmJpQnBjeUJoYkd4dmQyVmtDaTh2SUVobGNtVXNJR0ZqZEdsdmJpQnlaV1psY25NZ2RHOGdkR2hsSUU5dVEyOXRjR3hsZEdVZ2FXNGdZMjl0WW1sdVlYUnBiMjRnZDJsMGFDQjNhR1YwYUdWeUlIUm9aU0JoY0hBZ2FYTWdZbVZwYm1jZ1kzSmxZWFJsWkNCdmNpQmpZV3hzWldRS0x5OGdSWFpsY25rZ2NHOXpjMmxpYkdVZ1lXTjBhVzl1SUdadmNpQjBhR2x6SUdOdmJuUnlZV04wSUdseklISmxjSEpsYzJWdWRHVmtJR2x1SUhSb1pTQnpkMmwwWTJnZ2MzUmhkR1Z0Wlc1MENpOHZJRWxtSUhSb1pTQmhZM1JwYjI0Z2FYTWdibTkwSUdsdGNHeGxiV1Z1ZEdWa0lHbHVJSFJvWlNCamIyNTBjbUZqZEN3Z2FYUnpJSEpsYzNCbFkzUnBkbVVnWW5KaGJtTm9JSGRwYkd3Z1ltVWdJaXBPVDFSZlNVMVFURVZOUlU1VVJVUWlJSGRvYVdOb0lHcDFjM1FnWTI5dWRHRnBibk1nSW1WeWNpSUtkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJUXBwYm5SaklEUWdMeThnTmdvcUNuUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0t3cHpkMmwwWTJnZ0ttTmhiR3hmVG05UGNDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS21OeVpXRjBaVjlPYjA5d0lDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQW9LS2s1UFZGOUpUVkJNUlUxRlRsUkZSRG9LQ1M4dklGUm9aU0J5WlhGMVpYTjBaV1FnWVdOMGFXOXVJR2x6SUc1dmRDQnBiWEJzWlcxbGJuUmxaQ0JwYmlCMGFHbHpJR052Ym5SeVlXTjBMaUJCY21VZ2VXOTFJSFZ6YVc1bklIUm9aU0JqYjNKeVpXTjBJRTl1UTI5dGNHeGxkR1UvSUVScFpDQjViM1VnYzJWMElIbHZkWElnWVhCd0lFbEVQd29KWlhKeUNnb3ZMeUJqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWgxYVc1ME5qUXBkbTlwWkFvcVlXSnBYM0p2ZFhSbFgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dU9nb0pMeThnY205MWRHVnlPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXSjBiMmtLQ2drdkx5QmxlR1ZqZFhSbElHTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtIVnBiblEyTkNsMmIybGtDZ2xqWVd4c2MzVmlJR055WldGMFpVRndjR3hwWTJGMGFXOXVDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpaHliM1YwWlhJNklFRndjRWxFS1RvZ2RtOXBaQXBqY21WaGRHVkJjSEJzYVdOaGRHbHZiam9LQ1hCeWIzUnZJREVnTUFvS0NTOHZJR052Ym5SeVlXTjBjMXhYWlc1UVlXUlRZV3hsTG1Gc1oyOHVkSE02TnpNMENna3ZMeUIwYUdsekxuUnZkR0ZzVTJGc1pYTXVkbUZzZFdVZ1BTQXdDZ2xpZVhSbFl5QXlJQzh2SUNBaWRHOTBZV3hmYzJGc1pYTWlDZ2xwYm5SaklERWdMeThnTUFvSllYQndYMmRzYjJKaGJGOXdkWFFLQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamN6TlFvSkx5OGdkR2hwY3k1MGIzUmhiRlp2YkhWdFpTNTJZV3gxWlNBOUlEQUtDV0o1ZEdWaklEVWdMeThnSUNKMGIzUmhiRjkyYjJ4MWJXVWlDZ2xwYm5SaklERWdMeThnTUFvSllYQndYMmRzYjJKaGJGOXdkWFFLQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamN6TmdvSkx5OGdkR2hwY3k1dVpYaDBVMkZzWlVsa0xuWmhiSFZsSUQwZ01Rb0pZbmwwWldNZ05pQXZMeUFnSW01bGVIUmZjMkZzWlY5cFpDSUtDV2x1ZEdNZ01DQXZMeUF4Q2dsaGNIQmZaMnh2WW1Gc1gzQjFkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZOek0zQ2drdkx5QjBhR2x6TG5KdmRYUmxjaTUyWVd4MVpTQTlJSEp2ZFhSbGNnb0pZbmwwWldNZ09DQXZMeUFnSW1GeVl6VTVJZ29KWm5KaGJXVmZaR2xuSUMweElDOHZJSEp2ZFhSbGNqb2dRWEJ3U1VRS0NXRndjRjluYkc5aVlXeGZjSFYwQ2dseVpYUnpkV0lLQ2k4dklHTnlaV0YwWlZOaGJHVW9jR0Y1TEdGa1pISmxjM01zWW5sMFpWdGRMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNjM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5LWFZwYm5RMk5Bb3FZV0pwWDNKdmRYUmxYMk55WldGMFpWTmhiR1U2Q2drdkx5QlVhR1VnUVVKSklISmxkSFZ5YmlCd2NtVm1hWGdLQ1dKNWRHVmpJRGNnTHk4Z01IZ3hOVEZtTjJNM05Rb0tDUzh2SUcxbGRHRmtZWFJoVlhKc09pQnpkSEpwYm1jS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREV4Q2dsbGVIUnlZV04wSURJZ01Bb0tDUzh2SUhOMFlXNWtZWEprT2lCemRISnBibWNLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERXdDZ2xsZUhSeVlXTjBJRElnTUFvS0NTOHZJSFZ1YVhST1lXMWxPaUJ6ZEhKcGJtY0tDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURrS0NXVjRkSEpoWTNRZ01pQXdDZ29KTHk4Z2JtRnRaVG9nYzNSeWFXNW5DZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBNENnbGxlSFJ5WVdOMElESWdNQW9LQ1M4dklHUmxiR2wyWlhKNVFuVmtaMlYwT2lCMWFXNTBOalFLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEY0tDV0owYjJrS0Nna3ZMeUJ5WlhabFlXeEdaV1U2SUhWcGJuUTJOQW9KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05nb0pZblJ2YVFvS0NTOHZJR1Z1WkZKdmRXNWtPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0NXSjBiMmtLQ2drdkx5QnpkR0Z5ZEZKdmRXNWtPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0NXSjBiMmtLQ2drdkx5QndjbWxqWlRvZ2RXbHVkRFkwQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDZ2xpZEc5cENnb0pMeThnY0dGNWIzVjBjem9nWW5sMFpWdGRDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNnbGxlSFJ5WVdOMElESWdNQW9LQ1M4dklHRmtiV2x1T2lCaFpHUnlaWE56Q2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDZ2xrZFhBS0NXeGxiZ29KYVc1MFl5QXpJQzh2SURNeUNnazlQUW9LQ1M4dklHRnlaM1Z0Wlc1MElERXdJQ2hoWkcxcGJpa2dabTl5SUdOeVpXRjBaVk5oYkdVZ2JYVnpkQ0JpWlNCaElHRmtaSEpsYzNNS0NXRnpjMlZ5ZEFvS0NTOHZJRzFpY2xCaGVUb2djR0Y1Q2dsMGVHNGdSM0p2ZFhCSmJtUmxlQW9KYVc1MFl5QXdJQzh2SURFS0NTMEtDV1IxY0FvSlozUjRibk1nVkhsd1pVVnVkVzBLQ1dsdWRHTWdNQ0F2THlBZ2NHRjVDZ2s5UFFvS0NTOHZJR0Z5WjNWdFpXNTBJREV4SUNodFluSlFZWGtwSUdadmNpQmpjbVZoZEdWVFlXeGxJRzExYzNRZ1ltVWdZU0J3WVhrZ2RISmhibk5oWTNScGIyNEtDV0Z6YzJWeWRBb0tDUzh2SUdWNFpXTjFkR1VnWTNKbFlYUmxVMkZzWlNod1lYa3NZV1JrY21WemN5eGllWFJsVzEwc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4emRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcGRXbHVkRFkwQ2dsallXeHNjM1ZpSUdOeVpXRjBaVk5oYkdVS0NXbDBiMklLQ1dOdmJtTmhkQW9KYkc5bkNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCamNtVmhkR1ZUWVd4bEtHMWljbEJoZVRvZ1VHRjVWSGh1TENCaFpHMXBiam9nUVdSa2NtVnpjeXdnY0dGNWIzVjBjem9nWW5sMFpYTXNJSEJ5YVdObE9pQjFhVzUwTmpRc0lITjBZWEowVW05MWJtUTZJSFZwYm5RMk5Dd2daVzVrVW05MWJtUTZJSFZwYm5RMk5Dd2djbVYyWldGc1JtVmxPaUIxYVc1ME5qUXNJR1JsYkdsMlpYSjVRblZrWjJWME9pQjFhVzUwTmpRc0lHNWhiV1U2SUhOMGNtbHVaeXdnZFc1cGRFNWhiV1U2SUhOMGNtbHVaeXdnYzNSaGJtUmhjbVE2SUhOMGNtbHVaeXdnYldWMFlXUmhkR0ZWY213NklITjBjbWx1WnlrNklIVnBiblEyTkFvdkx3b3ZMeUJFWlhCc2Iza2dZU0J1WlhjZ2MyRnNaU0JoY0hBdUlGUm9aU0J6Wlc1a1pYSWdhWE1nZEdobElHUnBjM1J5YVdKMWRHbHZiaUIzWVd4c1pYUTZJSFJvWlNCamNtVmhkRzl5SjNNZ1kyOXVibVZqZEdWa0NpOHZJSGRoYkd4bGRDQjBhR0YwSUdodmJHUnpJSFJvWlNCamIyeHNaV04wYVc5dUlHRnVaQ0J6YVdkdWN5QjBhR1VnZDJodmJHVWdjMlYwZFhBdUlHQmhaRzFwYm1BZ0tIUm9aU0J0WVc1aFoyVnlLU0JqYjI1MGNtOXNjd292THlCMGFHVWdjMkZzWlNCdmJtTmxJR3hwZG1VdUlHQndZWGx2ZFhSellDQnBjeUIwYUdVZ2NHRmphMlZrSUhCeWIyTmxaV1J6SUhOd2JHbDBJQ2h6WldVZ1VFRlpUMVZVWDBWT1ZGSlpYMEpaVkVWVEtTNEtMeThnVkdobElIQmhlVzFsYm5RZ2JYVnpkQ0JqYjNabGNpQjBhR1VnWm1GamRHOXllU2R6SUUxQ1VpQnBibU55WldGelpTQW9ZMmhwYkdRZ1lYQndJQ3NnYVc1a1pYZ2dZbTk0WlhNcElIQnNkWE1LTHk4Z1EwaEpURVJmVTBWRlJEc2dZVzU1SUc5MlpYSndZWGx0Wlc1MElHbHpJSEpsWm5WdVpHVmtMZ3BqY21WaGRHVlRZV3hsT2dvSmNISnZkRzhnTVRJZ01Rb0tDUzh2SUZCMWMyZ2daVzF3ZEhrZ1lubDBaWE1nWVdaMFpYSWdkR2hsSUdaeVlXMWxJSEJ2YVc1MFpYSWdkRzhnY21WelpYSjJaU0J6Y0dGalpTQm1iM0lnYkc5allXd2dkbUZ5YVdGaWJHVnpDZ2xpZVhSbFl5QXdJQzh2SURCNENnbGtkWEJ1SURnS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVjJWdVVHRmtVMkZzWlM1aGJHZHZMblJ6T2pjMk1Rb0pMeThnWkdsemRISnBZblYwYVc5dUlEMGdkR2hwY3k1MGVHNHVjMlZ1WkdWeUNnbDBlRzRnVTJWdVpHVnlDZ2xtY21GdFpWOWlkWEo1SURBZ0x5OGdaR2x6ZEhKcFluVjBhVzl1T2lCaFpHUnlaWE56Q2dvSkx5OGdZMjl1ZEhKaFkzUnpYRmRsYmxCaFpGTmhiR1V1WVd4bmJ5NTBjem8zTmpVS0NTOHZJR0Z6YzJWeWRDaGhaRzFwYmlBaFBUMGdaR2x6ZEhKcFluVjBhVzl1S1FvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUdGa2JXbHVPaUJCWkdSeVpYTnpDZ2xtY21GdFpWOWthV2NnTUNBdkx5QmthWE4wY21saWRYUnBiMjQ2SUdGa1pISmxjM01LQ1NFOUNnbGhjM05sY25RS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVjJWdVVHRmtVMkZzWlM1aGJHZHZMblJ6T2pjMk5nb0pMeThnWVhOelpYSjBLR0ZrYldsdUlDRTlQU0JuYkc5aVlXeHpMbnBsY205QlpHUnlaWE56S1FvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUdGa2JXbHVPaUJCWkdSeVpYTnpDZ2xuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LQ1NFOUNnbGhjM05sY25RS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVjJWdVVHRmtVMkZzWlM1aGJHZHZMblJ6T2pjMk9Rb0pMeThnWVhOelpYSjBLSEJoZVc5MWRITXViR1Z1WjNSb0lENGdNQ2tLQ1daeVlXMWxYMlJwWnlBdE15QXZMeUJ3WVhsdmRYUnpPaUJpZVhSbGN3b0piR1Z1Q2dscGJuUmpJREVnTHk4Z01Bb0pQZ29KWVhOelpYSjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhGZGxibEJoWkZOaGJHVXVZV3huYnk1MGN6bzNOekFLQ1M4dklHRnpjMlZ5ZENod1lYbHZkWFJ6TG14bGJtZDBhQ0E4UFNCUVFWbFBWVlJmUlU1VVVsbGZRbGxVUlZNZ0tpQk5RVmhmVUVGWlQxVlVVeWtLQ1daeVlXMWxYMlJwWnlBdE15QXZMeUJ3WVhsdmRYUnpPaUJpZVhSbGN3b0piR1Z1Q2dsd2RYTm9hVzUwSURJd01Bb0pQRDBLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZOemN4Q2drdkx5QmhjM05sY25Rb2NHRjViM1YwY3k1c1pXNW5kR2dnSlNCUVFWbFBWVlJmUlU1VVVsbGZRbGxVUlZNZ1BUMDlJREFwQ2dsbWNtRnRaVjlrYVdjZ0xUTWdMeThnY0dGNWIzVjBjem9nWW5sMFpYTUtDV3hsYmdvSmFXNTBZeUExSUM4dklEUXdDZ2tsQ2dscGJuUmpJREVnTHk4Z01Bb0pQVDBLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZOemN5Q2drdkx5QjBiM1JoYkVKd2N5QTlJREFLQ1dsdWRHTWdNU0F2THlBd0NnbG1jbUZ0WlY5aWRYSjVJREVnTHk4Z2RHOTBZV3hDY0hNNklIVnBiblEyTkFvS0NTOHZJR052Ym5SeVlXTjBjMXhYWlc1UVlXUlRZV3hsTG1Gc1oyOHVkSE02TnpjekNna3ZMeUJtYjNJZ0tHeGxkQ0JwSUQwZ01Ec2dhU0E4SUhCaGVXOTFkSE11YkdWdVozUm9PeUJwSUQwZ2FTQXJJRkJCV1U5VlZGOUZUbFJTV1Y5Q1dWUkZVeWtLQ1dsdWRHTWdNU0F2THlBd0NnbG1jbUZ0WlY5aWRYSjVJRElnTHk4Z2FUb2dkV2x1ZERZMENnb3FabTl5WHpBNkNna3ZMeUJqYjI1MGNtRmpkSE5jVjJWdVVHRmtVMkZzWlM1aGJHZHZMblJ6T2pjM013b0pMeThnYVNBOElIQmhlVzkxZEhNdWJHVnVaM1JvQ2dsbWNtRnRaVjlrYVdjZ01pQXZMeUJwT2lCMWFXNTBOalFLQ1daeVlXMWxYMlJwWnlBdE15QXZMeUJ3WVhsdmRYUnpPaUJpZVhSbGN3b0piR1Z1Q2drOENnbGllaUFxWm05eVh6QmZaVzVrQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRmRsYmxCaFpGTmhiR1V1WVd4bmJ5NTBjem8zTnpVS0NTOHZJR0Z6YzJWeWRDaGpZWE4wUW5sMFpYTThRV1JrY21WemN6NG9aWGgwY21GamRETW9jR0Y1YjNWMGN5d2dhU3dnTXpJcEtTQWhQVDBnWjJ4dlltRnNjeTU2WlhKdlFXUmtjbVZ6Y3lrS0NXWnlZVzFsWDJScFp5QXRNeUF2THlCd1lYbHZkWFJ6T2lCaWVYUmxjd29KWm5KaGJXVmZaR2xuSURJZ0x5OGdhVG9nZFdsdWREWTBDZ2xwYm5SaklETWdMeThnTXpJS0NXVjRkSEpoWTNRekNnbG5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtDU0U5Q2dsaGMzTmxjblFLQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamMzTmdvSkx5OGdZbkJ6SUQwZ1pYaDBjbUZqZEZWcGJuUTJOQ2h3WVhsdmRYUnpMQ0JwSUNzZ016SXBDZ2xtY21GdFpWOWthV2NnTFRNZ0x5OGdjR0Y1YjNWMGN6b2dZbmwwWlhNS0NXWnlZVzFsWDJScFp5QXlJQzh2SUdrNklIVnBiblEyTkFvSmFXNTBZeUF6SUM4dklETXlDZ2tyQ2dsbGVIUnlZV04wWDNWcGJuUTJOQW9KWm5KaGJXVmZZblZ5ZVNBeklDOHZJR0p3Y3pvZ2RXbHVkRFkwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRmRsYmxCaFpGTmhiR1V1WVd4bmJ5NTBjem8zTnpjS0NTOHZJR0Z6YzJWeWRDaGljSE1nUGlBd0tRb0pabkpoYldWZlpHbG5JRE1nTHk4Z1luQnpPaUIxYVc1ME5qUUtDV2x1ZEdNZ01TQXZMeUF3Q2drK0NnbGhjM05sY25RS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVjJWdVVHRmtVMkZzWlM1aGJHZHZMblJ6T2pjM09Bb0pMeThnZEc5MFlXeENjSE1nUFNCMGIzUmhiRUp3Y3lBcklHSndjd29KWm5KaGJXVmZaR2xuSURFZ0x5OGdkRzkwWVd4Q2NITTZJSFZwYm5RMk5Bb0pabkpoYldWZlpHbG5JRE1nTHk4Z1luQnpPaUIxYVc1ME5qUUtDU3NLQ1daeVlXMWxYMkoxY25rZ01TQXZMeUIwYjNSaGJFSndjem9nZFdsdWREWTBDZ29xWm05eVh6QmZZMjl1ZEdsdWRXVTZDZ2t2THlCamIyNTBjbUZqZEhOY1YyVnVVR0ZrVTJGc1pTNWhiR2R2TG5Sek9qYzNNd29KTHk4Z2FTQTlJR2tnS3lCUVFWbFBWVlJmUlU1VVVsbGZRbGxVUlZNS0NXWnlZVzFsWDJScFp5QXlJQzh2SUdrNklIVnBiblEyTkFvSmFXNTBZeUExSUM4dklEUXdDZ2tyQ2dsbWNtRnRaVjlpZFhKNUlESWdMeThnYVRvZ2RXbHVkRFkwQ2dsaUlDcG1iM0pmTUFvS0ttWnZjbDh3WDJWdVpEb0tDUzh2SUdOdmJuUnlZV04wYzF4WFpXNVFZV1JUWVd4bExtRnNaMjh1ZEhNNk56Z3dDZ2t2THlCaGMzTmxjblFvZEc5MFlXeENjSE1nUFQwOUlFSlFVMTlVVDFSQlRDa0tDV1p5WVcxbFgyUnBaeUF4SUM4dklIUnZkR0ZzUW5Cek9pQjFhVzUwTmpRS0NYQjFjMmhwYm5RZ01UQXdNREFLQ1QwOUNnbGhjM05sY25RS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVjJWdVVHRmtVMkZzWlM1aGJHZHZMblJ6T2pjNE1Rb0pMeThnY0dGNWIzVjBJRDBnWTJGemRFSjVkR1Z6UEVGa1pISmxjM00rS0dWNGRISmhZM1F6S0hCaGVXOTFkSE1zSURBc0lETXlLU2tLQ1daeVlXMWxYMlJwWnlBdE15QXZMeUJ3WVhsdmRYUnpPaUJpZVhSbGN3b0paWGgwY21GamRDQXdJRE15Q2dsbWNtRnRaVjlpZFhKNUlEUWdMeThnY0dGNWIzVjBPaUJoWkdSeVpYTnpDZ29KTHk4Z1kyOXVkSEpoWTNSelhGZGxibEJoWkZOaGJHVXVZV3huYnk1MGN6bzNPRE1LQ1M4dklHRnpjMlZ5ZENobGJtUlNiM1Z1WkNBK0lITjBZWEowVW05MWJtUXBDZ2xtY21GdFpWOWthV2NnTFRZZ0x5OGdaVzVrVW05MWJtUTZJSFZwYm5RMk5Bb0pabkpoYldWZlpHbG5JQzAxSUM4dklITjBZWEowVW05MWJtUTZJSFZwYm5RMk5Bb0pQZ29KWVhOelpYSjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhGZGxibEJoWkZOaGJHVXVZV3huYnk1MGN6bzNPRFFLQ1M4dklHRnpjMlZ5ZENobGJtUlNiM1Z1WkNBK0lHZHNiMkpoYkhNdWNtOTFibVFwQ2dsbWNtRnRaVjlrYVdjZ0xUWWdMeThnWlc1a1VtOTFibVE2SUhWcGJuUTJOQW9KWjJ4dlltRnNJRkp2ZFc1a0NnaytDZ2xoYzNObGNuUUtDZ2t2THlCamIyNTBjbUZqZEhOY1YyVnVVR0ZrVTJGc1pTNWhiR2R2TG5Sek9qYzROUW9KTHk4Z1lYTnpaWEowS0hKbGRtVmhiRVpsWlNBK1BTQk5TVTVmVWtWV1JVRk1YMFpGUlNrS0NXWnlZVzFsWDJScFp5QXROeUF2THlCeVpYWmxZV3hHWldVNklIVnBiblEyTkFvSmNIVnphR2x1ZENBeU1EQXdNQW9KUGowS0NXRnpjMlZ5ZEFvS0NTOHZJR052Ym5SeVlXTjBjMXhYWlc1UVlXUlRZV3hsTG1Gc1oyOHVkSE02TnpnMkNna3ZMeUJoYzNObGNuUW9aR1ZzYVhabGNubENkV1JuWlhRZ1BqMGdUVWxPWDBSRlRFbFdSVkpaWDBKVlJFZEZWQ2tLQ1daeVlXMWxYMlJwWnlBdE9DQXZMeUJrWld4cGRtVnllVUoxWkdkbGREb2dkV2x1ZERZMENnbHdkWE5vYVc1MElEUXdNREF3TUFvSlBqMEtDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4WFpXNVFZV1JUWVd4bExtRnNaMjh1ZEhNNk56ZzNDZ2t2THlCaGMzTmxjblFvYm1GdFpTNXNaVzVuZEdnZ1BEMGdOalFwQ2dsbWNtRnRaVjlrYVdjZ0xUa2dMeThnYm1GdFpUb2djM1J5YVc1bkNnbHNaVzRLQ1dsdWRHTWdPQ0F2THlBMk5Bb0pQRDBLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZOemc0Q2drdkx5QmhjM05sY25Rb2RXNXBkRTVoYldVdWJHVnVaM1JvSUR3OUlEZ3BDZ2xtY21GdFpWOWthV2NnTFRFd0lDOHZJSFZ1YVhST1lXMWxPaUJ6ZEhKcGJtY0tDV3hsYmdvSmFXNTBZeUF5SUM4dklEZ0tDVHc5Q2dsaGMzTmxjblFLQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamM0T1FvSkx5OGdZWE56WlhKMEtITjBZVzVrWVhKa0xteGxibWQwYUNBOFBTQTRLUW9KWm5KaGJXVmZaR2xuSUMweE1TQXZMeUJ6ZEdGdVpHRnlaRG9nYzNSeWFXNW5DZ2xzWlc0S0NXbHVkR01nTWlBdkx5QTRDZ2s4UFFvSllYTnpaWEowQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRmRsYmxCaFpGTmhiR1V1WVd4bmJ5NTBjem8zT1RBS0NTOHZJR0Z6YzJWeWRDaHRaWFJoWkdGMFlWVnliQzVzWlc1bmRHZ2dQRDBnTWpVMktRb0pabkpoYldWZlpHbG5JQzB4TWlBdkx5QnRaWFJoWkdGMFlWVnliRG9nYzNSeWFXNW5DZ2xzWlc0S0NXbHVkR01nTnlBdkx5QXlOVFlLQ1R3OUNnbGhjM05sY25RS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVjJWdVVHRmtVMkZzWlM1aGJHZHZMblJ6T2pjNU1Rb0pMeThnZG1WeWFXWjVVR0Y1VkhodUtHMWljbEJoZVN3Z2V3b0pMeThnSUNBZ0lDQWdjMlZ1WkdWeU9pQmthWE4wY21saWRYUnBiMjRzQ2drdkx5QWdJQ0FnSUNCeVpXTmxhWFpsY2pvZ2RHaHBjeTVoY0hBdVlXUmtjbVZ6Y3l3S0NTOHZJQ0FnSUNBZ0lHTnNiM05sVW1WdFlXbHVaR1Z5Vkc4NklHZHNiMkpoYkhNdWVtVnliMEZrWkhKbGMzTXNDZ2t2THlBZ0lDQWdJQ0J5Wld0bGVWUnZPaUJuYkc5aVlXeHpMbnBsY205QlpHUnlaWE56TEFvSkx5OGdJQ0FnSUgwcENna3ZMeUIyWlhKcFpua2djMlZ1WkdWeUNnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z2JXSnlVR0Y1T2lCUVlYbFVlRzRLQ1dkMGVHNXpJRk5sYm1SbGNnb0pabkpoYldWZlpHbG5JREFnTHk4Z1pHbHpkSEpwWW5WMGFXOXVPaUJoWkdSeVpYTnpDZ2s5UFFvS0NTOHZJSFJ5WVc1ellXTjBhVzl1SUhabGNtbG1hV05oZEdsdmJpQm1ZV2xzWldRNklIc2lkSGh1SWpvaWJXSnlVR0Y1SWl3aVptbGxiR1FpT2lKelpXNWtaWElpTENKbGVIQmxZM1JsWkNJNkltUnBjM1J5YVdKMWRHbHZiaUo5Q2dsaGMzTmxjblFLQ2drdkx5QjJaWEpwWm5rZ2NtVmpaV2wyWlhJS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCdFluSlFZWGs2SUZCaGVWUjRiZ29KWjNSNGJuTWdVbVZqWldsMlpYSUtDV2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNnazlQUW9LQ1M4dklIUnlZVzV6WVdOMGFXOXVJSFpsY21sbWFXTmhkR2x2YmlCbVlXbHNaV1E2SUhzaWRIaHVJam9pYldKeVVHRjVJaXdpWm1sbGJHUWlPaUp5WldObGFYWmxjaUlzSW1WNGNHVmpkR1ZrSWpvaWRHaHBjeTVoY0hBdVlXUmtjbVZ6Y3lKOUNnbGhjM05sY25RS0Nna3ZMeUIyWlhKcFpua2dZMnh2YzJWU1pXMWhhVzVrWlhKVWJ3b0pabkpoYldWZlpHbG5JQzB4SUM4dklHMWljbEJoZVRvZ1VHRjVWSGh1Q2dsbmRIaHVjeUJEYkc5elpWSmxiV0ZwYm1SbGNsUnZDZ2xuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LQ1QwOUNnb0pMeThnZEhKaGJuTmhZM1JwYjI0Z2RtVnlhV1pwWTJGMGFXOXVJR1poYVd4bFpEb2dleUowZUc0aU9pSnRZbkpRWVhraUxDSm1hV1ZzWkNJNkltTnNiM05sVW1WdFlXbHVaR1Z5Vkc4aUxDSmxlSEJsWTNSbFpDSTZJbWRzYjJKaGJITXVlbVZ5YjBGa1pISmxjM01pZlFvSllYTnpaWEowQ2dvSkx5OGdkbVZ5YVdaNUlISmxhMlY1Vkc4S0NXWnlZVzFsWDJScFp5QXRNU0F2THlCdFluSlFZWGs2SUZCaGVWUjRiZ29KWjNSNGJuTWdVbVZyWlhsVWJ3b0paMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDZ2s5UFFvS0NTOHZJSFJ5WVc1ellXTjBhVzl1SUhabGNtbG1hV05oZEdsdmJpQm1ZV2xzWldRNklIc2lkSGh1SWpvaWJXSnlVR0Y1SWl3aVptbGxiR1FpT2lKeVpXdGxlVlJ2SWl3aVpYaHdaV04wWldRaU9pSm5iRzlpWVd4ekxucGxjbTlCWkdSeVpYTnpJbjBLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZOems0Q2drdkx5QndjbVZOWW5JZ1BTQjBhR2x6TG1Gd2NDNWhaR1J5WlhOekxtMXBia0poYkdGdVkyVUtDV2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNnbGhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRTFwYmtKaGJHRnVZMlVLQ1hCdmNBb0pabkpoYldWZlluVnllU0ExSUM4dklIQnlaVTFpY2pvZ2RXbHVkRFkwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRmRsYmxCaFpGTmhiR1V1WVd4bmJ5NTBjem8zT1RrS0NTOHZJSE5oYkdWSlpDQTlJSFJvYVhNdWJtVjRkRk5oYkdWSlpDNTJZV3gxWlFvSllubDBaV01nTmlBdkx5QWdJbTVsZUhSZmMyRnNaVjlwWkNJS0NXRndjRjluYkc5aVlXeGZaMlYwQ2dsbWNtRnRaVjlpZFhKNUlEWWdMeThnYzJGc1pVbGtPaUIxYVc1ME5qUUtDZ2t2THlCamIyNTBjbUZqZEhOY1YyVnVVR0ZrVTJGc1pTNWhiR2R2TG5Sek9qZ3dNUW9KTHk4Z2MyVnVaRTFsZEdodlpFTmhiR3c4ZEhsd1pXOW1JRmRsYmxCaFpGTmhiR1V1Y0hKdmRHOTBlWEJsTG1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1UGloN0Nna3ZMeUFnSUNBZ0lDQmhjSEJ5YjNaaGJGQnliMmR5WVcwNklGZGxibEJoWkZOaGJHVXVZWEJ3Y205MllXeFFjbTluY21GdEtDa3NDZ2t2THlBZ0lDQWdJQ0JqYkdWaGNsTjBZWFJsVUhKdlozSmhiVG9nVjJWdVVHRmtVMkZzWlM1amJHVmhjbEJ5YjJkeVlXMG9LU3dLQ1M4dklDQWdJQ0FnSUdkc2IySmhiRTUxYlZWcGJuUTZJRU5JU1V4RVgwZE1UMEpCVEY5VlNVNVVVeXdLQ1M4dklDQWdJQ0FnSUdkc2IySmhiRTUxYlVKNWRHVlRiR2xqWlRvZ1EwaEpURVJmUjB4UFFrRk1YMEpaVkVWVExBb0pMeThnSUNBZ0lDQWdaWGgwY21GUWNtOW5jbUZ0VUdGblpYTTZJRU5JU1V4RVgwVllWRkpCWDFCQlIwVlRMQW9KTHk4Z0lDQWdJQ0FnYldWMGFHOWtRWEpuY3pvZ1d3b0pMeThnSUNBZ0lDQWdJQ0J6WVd4bFNXUXNDZ2t2THlBZ0lDQWdJQ0FnSUdGa2JXbHVMQW9KTHk4Z0lDQWdJQ0FnSUNCa2FYTjBjbWxpZFhScGIyNHNDZ2t2THlBZ0lDQWdJQ0FnSUhCeWFXTmxMQW9KTHk4Z0lDQWdJQ0FnSUNCemRHRnlkRkp2ZFc1a0xBb0pMeThnSUNBZ0lDQWdJQ0JsYm1SU2IzVnVaQ3dLQ1M4dklDQWdJQ0FnSUNBZ2NtVjJaV0ZzUm1WbExBb0pMeThnSUNBZ0lDQWdJQ0JrWld4cGRtVnllVUoxWkdkbGRDd0tDUzh2SUNBZ0lDQWdJQ0FnZEdocGN5NXliM1YwWlhJdWRtRnNkV1VzQ2drdkx5QWdJQ0FnSUNCZExBb0pMeThnSUNBZ0lDQWdabVZsT2lBd0xBb0pMeThnSUNBZ0lIMHBDZ2xwZEhodVgySmxaMmx1Q2dscGJuUmpJRFFnTHk4Z0lHRndjR3dLQ1dsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0NYQjFjMmhpZVhSbGN5QXdlR1JsTTJNNFlqUTFJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvZFdsdWREWTBMR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNsMmIybGtJZ29KYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamd3TWdvSkx5OGdZWEJ3Y205MllXeFFjbTluY21GdE9pQlhaVzVRWVdSVFlXeGxMbUZ3Y0hKdmRtRnNVSEp2WjNKaGJTZ3BDZ2xRUlU1RVNVNUhYME5QVFZCSlRFVmZRVkJRVWs5V1FVdzZJRmRsYmxCaFpGTmhiR1VLQ1dsMGVHNWZabWxsYkdRZ1FYQndjbTkyWVd4UWNtOW5jbUZ0Q2dvSkx5OGdZMjl1ZEhKaFkzUnpYRmRsYmxCaFpGTmhiR1V1WVd4bmJ5NTBjem80TURNS0NTOHZJR05zWldGeVUzUmhkR1ZRY205bmNtRnRPaUJYWlc1UVlXUlRZV3hsTG1Oc1pXRnlVSEp2WjNKaGJTZ3BDZ2xRUlU1RVNVNUhYME5QVFZCSlRFVmZRMHhGUVZJNklGZGxibEJoWkZOaGJHVUtDV2wwZUc1ZlptbGxiR1FnUTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBLQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamd3TkFvSkx5OGdaMnh2WW1Gc1RuVnRWV2x1ZERvZ1EwaEpURVJmUjB4UFFrRk1YMVZKVGxSVENnbHdkWE5vYVc1MElERTJDZ2xwZEhodVgyWnBaV3hrSUVkc2IySmhiRTUxYlZWcGJuUUtDZ2t2THlCamIyNTBjbUZqZEhOY1YyVnVVR0ZrVTJGc1pTNWhiR2R2TG5Sek9qZ3dOUW9KTHk4Z1oyeHZZbUZzVG5WdFFubDBaVk5zYVdObE9pQkRTRWxNUkY5SFRFOUNRVXhmUWxsVVJWTUtDWEIxYzJocGJuUWdNZ29KYVhSNGJsOW1hV1ZzWkNCSGJHOWlZV3hPZFcxQ2VYUmxVMnhwWTJVS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVjJWdVVHRmtVMkZzWlM1aGJHZHZMblJ6T2pnd05nb0pMeThnWlhoMGNtRlFjbTluY21GdFVHRm5aWE02SUVOSVNVeEVYMFZZVkZKQlgxQkJSMFZUQ2dscGJuUmpJREFnTHk4Z01Rb0phWFI0Ymw5bWFXVnNaQ0JGZUhSeVlWQnliMmR5WVcxUVlXZGxjd29LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZPREEzQ2drdkx5QnRaWFJvYjJSQmNtZHpPaUJiQ2drdkx5QWdJQ0FnSUNBZ0lITmhiR1ZKWkN3S0NTOHZJQ0FnSUNBZ0lDQWdZV1J0YVc0c0Nna3ZMeUFnSUNBZ0lDQWdJR1JwYzNSeWFXSjFkR2x2Yml3S0NTOHZJQ0FnSUNBZ0lDQWdjSEpwWTJVc0Nna3ZMeUFnSUNBZ0lDQWdJSE4wWVhKMFVtOTFibVFzQ2drdkx5QWdJQ0FnSUNBZ0lHVnVaRkp2ZFc1a0xBb0pMeThnSUNBZ0lDQWdJQ0J5WlhabFlXeEdaV1VzQ2drdkx5QWdJQ0FnSUNBZ0lHUmxiR2wyWlhKNVFuVmtaMlYwTEFvSkx5OGdJQ0FnSUNBZ0lDQjBhR2x6TG5KdmRYUmxjaTUyWVd4MVpTd0tDUzh2SUNBZ0lDQWdJRjBLQ1daeVlXMWxYMlJwWnlBMklDOHZJSE5oYkdWSlpEb2dkV2x1ZERZMENnbHBkRzlpQ2dscGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUdGa2JXbHVPaUJCWkdSeVpYTnpDZ2xwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29KWm5KaGJXVmZaR2xuSURBZ0x5OGdaR2x6ZEhKcFluVjBhVzl1T2lCaFpHUnlaWE56Q2dscGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvSlpuSmhiV1ZmWkdsbklDMDBJQzh2SUhCeWFXTmxPaUIxYVc1ME5qUUtDV2wwYjJJS0NXbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNnbG1jbUZ0WlY5a2FXY2dMVFVnTHk4Z2MzUmhjblJTYjNWdVpEb2dkV2x1ZERZMENnbHBkRzlpQ2dscGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvSlpuSmhiV1ZmWkdsbklDMDJJQzh2SUdWdVpGSnZkVzVrT2lCMWFXNTBOalFLQ1dsMGIySUtDV2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDZ2xtY21GdFpWOWthV2NnTFRjZ0x5OGdjbVYyWldGc1JtVmxPaUIxYVc1ME5qUUtDV2wwYjJJS0NXbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNnbG1jbUZ0WlY5a2FXY2dMVGdnTHk4Z1pHVnNhWFpsY25sQ2RXUm5aWFE2SUhWcGJuUTJOQW9KYVhSdllnb0phWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtDV0o1ZEdWaklEZ2dMeThnSUNKaGNtTTFPU0lLQ1dGd2NGOW5iRzlpWVd4ZloyVjBDZ2xwZEc5aUNnbHBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b0tDUzh2SUdOdmJuUnlZV04wYzF4WFpXNVFZV1JUWVd4bExtRnNaMjh1ZEhNNk9ERTRDZ2t2THlCbVpXVTZJREFLQ1dsdWRHTWdNU0F2THlBd0NnbHBkSGh1WDJacFpXeGtJRVpsWlFvS0NTOHZJRk4xWW0xcGRDQnBibTVsY2lCMGNtRnVjMkZqZEdsdmJnb0phWFI0Ymw5emRXSnRhWFFLQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamd5TUFvSkx5OGdZWEJ3SUQwZ2RHaHBjeTVwZEhodUxtTnlaV0YwWldSQmNIQnNhV05oZEdsdmJrbEVDZ2xwZEhodUlFTnlaV0YwWldSQmNIQnNhV05oZEdsdmJrbEVDZ2xtY21GdFpWOWlkWEo1SURjZ0x5OGdZWEJ3T2lCMWFXNTBOalFLQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamd5TWdvSkx5OGdjMlZ1WkZCaGVXMWxiblFvZXlCeVpXTmxhWFpsY2pvZ1lYQndMbUZrWkhKbGMzTXNJR0Z0YjNWdWREb2dRMGhKVEVSZlUwVkZSQ3dnWm1WbE9pQXdJSDBwQ2dscGRIaHVYMkpsWjJsdUNnbHBiblJqSURBZ0x5OGdJSEJoZVFvSmFYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb0tDUzh2SUdOdmJuUnlZV04wYzF4WFpXNVFZV1JUWVd4bExtRnNaMjh1ZEhNNk9ESXlDZ2t2THlCeVpXTmxhWFpsY2pvZ1lYQndMbUZrWkhKbGMzTUtDV1p5WVcxbFgyUnBaeUEzSUM4dklHRndjRG9nZFdsdWREWTBDZ2xoY0hCZmNHRnlZVzF6WDJkbGRDQkJjSEJCWkdSeVpYTnpDZ2x3YjNBS0NXbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtDZ2t2THlCamIyNTBjbUZqZEhOY1YyVnVVR0ZrVTJGc1pTNWhiR2R2TG5Sek9qZ3lNZ29KTHk4Z1lXMXZkVzUwT2lCRFNFbE1SRjlUUlVWRUNnbHBiblJqSURZZ0x5OGdNakF3TURBd0NnbHBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4WFpXNVFZV1JUWVd4bExtRnNaMjh1ZEhNNk9ESXlDZ2t2THlCbVpXVTZJREFLQ1dsdWRHTWdNU0F2THlBd0NnbHBkSGh1WDJacFpXeGtJRVpsWlFvS0NTOHZJRk4xWW0xcGRDQnBibTVsY2lCMGNtRnVjMkZqZEdsdmJnb0phWFI0Ymw5emRXSnRhWFFLQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamd5TXdvSkx5OGdjMlZ1WkUxbGRHaHZaRU5oYkd3OGRIbHdaVzltSUZkbGJsQmhaRk5oYkdVdWNISnZkRzkwZVhCbExuTmxkRkJoZVc5MWRITStLSHNLQ1M4dklDQWdJQ0FnSUdGd2NHeHBZMkYwYVc5dVNVUTZJR0Z3Y0N3S0NTOHZJQ0FnSUNBZ0lHMWxkR2h2WkVGeVozTTZJRnR3WVhsdmRYUnpYU3dLQ1M4dklDQWdJQ0FnSUdabFpUb2dNQ3dLQ1M4dklDQWdJQ0I5S1FvSmFYUjRibDlpWldkcGJnb0phVzUwWXlBMElDOHZJQ0JoY0hCc0NnbHBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDZ2x3ZFhOb1lubDBaWE1nTUhoallXRTBNV1ptTkNBdkx5QnRaWFJvYjJRZ0luTmxkRkJoZVc5MWRITW9ZbmwwWlZ0ZEtYWnZhV1FpQ2dscGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvS0NTOHZJR052Ym5SeVlXTjBjMXhYWlc1UVlXUlRZV3hsTG1Gc1oyOHVkSE02T0RJMENna3ZMeUJoY0hCc2FXTmhkR2x2YmtsRU9pQmhjSEFLQ1daeVlXMWxYMlJwWnlBM0lDOHZJR0Z3Y0RvZ2RXbHVkRFkwQ2dscGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamd5TlFvSkx5OGdiV1YwYUc5a1FYSm5jem9nVzNCaGVXOTFkSE5kQ2dsbWNtRnRaVjlrYVdjZ0xUTWdMeThnY0dGNWIzVjBjem9nWW5sMFpYTUtDV1IxY0FvSmJHVnVDZ2xwZEc5aUNnbGxlSFJ5WVdOMElEWWdNZ29KYzNkaGNBb0pZMjl1WTJGMENnbHBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b0tDUzh2SUdOdmJuUnlZV04wYzF4WFpXNVFZV1JUWVd4bExtRnNaMjh1ZEhNNk9ESTJDZ2t2THlCbVpXVTZJREFLQ1dsdWRHTWdNU0F2THlBd0NnbHBkSGh1WDJacFpXeGtJRVpsWlFvS0NTOHZJRk4xWW0xcGRDQnBibTVsY2lCMGNtRnVjMkZqZEdsdmJnb0phWFI0Ymw5emRXSnRhWFFLQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamd5T1FvSkx5OGdkR2hwY3k1ellXeGxjeWh6WVd4bFNXUXBMblpoYkhWbElEMGdld29KTHk4Z0lDQWdJQ0FnWVhCd09pQmhjSEFzQ2drdkx5QWdJQ0FnSUNCaFpHMXBiam9nWVdSdGFXNHNDZ2t2THlBZ0lDQWdJQ0JrYVhOMGNtbGlkWFJwYjI0NklHUnBjM1J5YVdKMWRHbHZiaXdLQ1M4dklDQWdJQ0FnSUhCaGVXOTFkRG9nY0dGNWIzVjBMQW9KTHk4Z0lDQWdJQ0FnY0hKcFkyVTZJSEJ5YVdObExBb0pMeThnSUNBZ0lDQWdjM1JoY25SU2IzVnVaRG9nYzNSaGNuUlNiM1Z1WkN3S0NTOHZJQ0FnSUNBZ0lHVnVaRkp2ZFc1a09pQmxibVJTYjNWdVpDd0tDUzh2SUNBZ0lDQWdJSFJ2ZEdGc1NYUmxiWE02SURBc0Nna3ZMeUFnSUNBZ0lDQnpiMnhrT2lBd0xBb0pMeThnSUNBZ0lDQWdjM1JoZEhWek9pQlRWRUZVVlZOZlUwVlVWVkFzQ2drdkx5QWdJQ0FnSUNCamNtVmhkR1ZrVW05MWJtUTZJR2RzYjJKaGJITXVjbTkxYm1Rc0Nna3ZMeUFnSUNBZ0lDQjJiMngxYldVNklEQXNDZ2t2THlBZ0lDQWdmUW9KWW5sMFpXTWdNU0F2THlBZ0luTWlDZ2xtY21GdFpWOWthV2NnTmlBdkx5QnpZV3hsU1dRNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5dVkyRjBDZ2xtY21GdFpWOWthV2NnTnlBdkx5QmhjSEE2SUhWcGJuUTJOQW9KYVhSdllnb0pabkpoYldWZlpHbG5JQzB5SUM4dklHRmtiV2x1T2lCQlpHUnlaWE56Q2dsamIyNWpZWFFLQ1daeVlXMWxYMlJwWnlBd0lDOHZJR1JwYzNSeWFXSjFkR2x2YmpvZ1lXUmtjbVZ6Y3dvSlkyOXVZMkYwQ2dsbWNtRnRaVjlrYVdjZ05DQXZMeUJ3WVhsdmRYUTZJR0ZrWkhKbGMzTUtDV052Ym1OaGRBb0pabkpoYldWZlpHbG5JQzAwSUM4dklIQnlhV05sT2lCMWFXNTBOalFLQ1dsMGIySUtDV052Ym1OaGRBb0pabkpoYldWZlpHbG5JQzAxSUM4dklITjBZWEowVW05MWJtUTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlkyOXVZMkYwQ2dsbWNtRnRaVjlrYVdjZ0xUWWdMeThnWlc1a1VtOTFibVE2SUhWcGJuUTJOQW9KYVhSdllnb0pZMjl1WTJGMENnbGllWFJsWXlBMElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9KWTI5dVkyRjBDZ2xpZVhSbFl5QTBJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvSlkyOXVZMkYwQ2dsaWVYUmxZeUEwSUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb0pZMjl1WTJGMENnbG5iRzlpWVd3Z1VtOTFibVFLQ1dsMGIySUtDV052Ym1OaGRBb0pZbmwwWldNZ05DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLQ1dOdmJtTmhkQW9KWW05NFgzQjFkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZPRFF6Q2drdkx5QjBhR2x6TG0xbGRHRmtZWFJoS0hOaGJHVkpaQ2t1ZG1Gc2RXVWdQU0I3Q2drdkx5QWdJQ0FnSUNCdVlXMWxPaUJ1WVcxbExBb0pMeThnSUNBZ0lDQWdkVzVwZEU1aGJXVTZJSFZ1YVhST1lXMWxMQW9KTHk4Z0lDQWdJQ0FnYzNSaGJtUmhjbVE2SUhOMFlXNWtZWEprTEFvSkx5OGdJQ0FnSUNBZ2JXVjBZV1JoZEdGVmNtdzZJRzFsZEdGa1lYUmhWWEpzTEFvSkx5OGdJQ0FnSUgwS0NXSjVkR1ZqSURNZ0x5OGdJQ0p0SWdvSlpuSmhiV1ZmWkdsbklEWWdMeThnYzJGc1pVbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXTnZibU5oZEFvSlpIVndDZ2xpYjNoZlpHVnNDZ2x3YjNBS0NXSjVkR1ZqSURBZ0x5OGdJR2x1YVhScFlXd2dhR1ZoWkFvSllubDBaV01nTUNBdkx5QWdhVzVwZEdsaGJDQjBZV2xzQ2dsaWVYUmxZeUE1SUM4dklDQnBibWwwYVdGc0lHaGxZV1FnYjJabWMyVjBDZ2xtY21GdFpWOWthV2NnTFRrZ0x5OGdibUZ0WlRvZ2MzUnlhVzVuQ2dsa2RYQUtDV3hsYmdvSmFYUnZZZ29KWlhoMGNtRmpkQ0EySURJS0NYTjNZWEFLQ1dOdmJtTmhkQW9KWTJGc2JITjFZaUFxY0hKdlkyVnpjMTlrZVc1aGJXbGpYM1IxY0d4bFgyVnNaVzFsYm5RS0NXWnlZVzFsWDJScFp5QXRNVEFnTHk4Z2RXNXBkRTVoYldVNklITjBjbWx1WndvSlpIVndDZ2xzWlc0S0NXbDBiMklLQ1dWNGRISmhZM1FnTmlBeUNnbHpkMkZ3Q2dsamIyNWpZWFFLQ1dOaGJHeHpkV0lnS25CeWIyTmxjM05mWkhsdVlXMXBZMTkwZFhCc1pWOWxiR1Z0Wlc1MENnbG1jbUZ0WlY5a2FXY2dMVEV4SUM4dklITjBZVzVrWVhKa09pQnpkSEpwYm1jS0NXUjFjQW9KYkdWdUNnbHBkRzlpQ2dsbGVIUnlZV04wSURZZ01nb0pjM2RoY0FvSlkyOXVZMkYwQ2dsallXeHNjM1ZpSUNwd2NtOWpaWE56WDJSNWJtRnRhV05mZEhWd2JHVmZaV3hsYldWdWRBb0pabkpoYldWZlpHbG5JQzB4TWlBdkx5QnRaWFJoWkdGMFlWVnliRG9nYzNSeWFXNW5DZ2xrZFhBS0NXeGxiZ29KYVhSdllnb0paWGgwY21GamRDQTJJRElLQ1hOM1lYQUtDV052Ym1OaGRBb0pZMkZzYkhOMVlpQXFjSEp2WTJWemMxOWtlVzVoYldsalgzUjFjR3hsWDJWc1pXMWxiblFLQ1hCdmNDQXZMeUJ3YjNBZ2FHVmhaQ0J2Wm1aelpYUUtDV052Ym1OaGRDQXZMeUJqYjI1allYUWdhR1ZoWkNCaGJtUWdkR0ZwYkFvSlltOTRYM0IxZEFvS0NTOHZJR052Ym5SeVlXTjBjMXhYWlc1UVlXUlRZV3hsTG1Gc1oyOHVkSE02T0RRNUNna3ZMeUIwYUdsekxtTnlaV0YwYjNKVFlXeGxjeWhqYjI1allYUW9ZV1J0YVc0c0lHbDBiMklvYzJGc1pVbGtLU2twTG5aaGJIVmxJRDBnWVhCd0NnbGllWFJsWXlBeE1DQXZMeUFnSW1NaUNnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z1lXUnRhVzQ2SUVGa1pISmxjM01LQ1daeVlXMWxYMlJwWnlBMklDOHZJSE5oYkdWSlpEb2dkV2x1ZERZMENnbHBkRzlpQ2dsamIyNWpZWFFLQ1dOdmJtTmhkQW9KWm5KaGJXVmZaR2xuSURjZ0x5OGdZWEJ3T2lCMWFXNTBOalFLQ1dsMGIySUtDV0p2ZUY5d2RYUUtDZ2t2THlCamIyNTBjbUZqZEhOY1YyVnVVR0ZrVTJGc1pTNWhiR2R2TG5Sek9qZzFNUW9KTHk4Z2RHaHBjeTV1WlhoMFUyRnNaVWxrTG5aaGJIVmxJRDBnYzJGc1pVbGtJQ3NnTVFvSllubDBaV01nTmlBdkx5QWdJbTVsZUhSZmMyRnNaVjlwWkNJS0NXWnlZVzFsWDJScFp5QTJJQzh2SUhOaGJHVkpaRG9nZFdsdWREWTBDZ2xwYm5SaklEQWdMeThnTVFvSkt3b0pZWEJ3WDJkc2IySmhiRjl3ZFhRS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVjJWdVVHRmtVMkZzWlM1aGJHZHZMblJ6T2pnMU1nb0pMeThnZEdocGN5NTBiM1JoYkZOaGJHVnpMblpoYkhWbElEMGdkR2hwY3k1MGIzUmhiRk5oYkdWekxuWmhiSFZsSUNzZ01Rb0pZbmwwWldNZ01pQXZMeUFnSW5SdmRHRnNYM05oYkdWeklnb0paSFZ3Q2dsaGNIQmZaMnh2WW1Gc1gyZGxkQW9KYVc1MFl5QXdJQzh2SURFS0NTc0tDV0Z3Y0Y5bmJHOWlZV3hmY0hWMENnb0pMeThnWTI5dWRISmhZM1J6WEZkbGJsQmhaRk5oYkdVdVlXeG5ieTUwY3pvNE5UVUtDUzh2SUhKbGNYVnBjbVZrSUQwZ2RHaHBjeTVoY0hBdVlXUmtjbVZ6Y3k1dGFXNUNZV3hoYm1ObElDMGdjSEpsVFdKeUlDc2dRMGhKVEVSZlUwVkZSQW9KWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtDV0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wVFdsdVFtRnNZVzVqWlFvSmNHOXdDZ2xtY21GdFpWOWthV2NnTlNBdkx5QndjbVZOWW5JNklIVnBiblEyTkFvSkxRb0phVzUwWXlBMklDOHZJREl3TURBd01Bb0pLd29KWm5KaGJXVmZZblZ5ZVNBNElDOHZJSEpsY1hWcGNtVmtPaUIxYVc1ME5qUUtDZ2t2THlCamIyNTBjbUZqZEhOY1YyVnVVR0ZrVTJGc1pTNWhiR2R2TG5Sek9qZzFOZ29KTHk4Z1lYTnpaWEowS0cxaWNsQmhlUzVoYlc5MWJuUWdQajBnY21WeGRXbHlaV1FwQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnYldKeVVHRjVPaUJRWVhsVWVHNEtDV2QwZUc1eklFRnRiM1Z1ZEFvSlpuSmhiV1ZmWkdsbklEZ2dMeThnY21WeGRXbHlaV1E2SUhWcGJuUTJOQW9KUGowS0NXRnpjMlZ5ZEFvS0NTOHZJQ3BwWmpCZlkyOXVaR2wwYVc5dUNna3ZMeUJqYjI1MGNtRmpkSE5jVjJWdVVHRmtVMkZzWlM1aGJHZHZMblJ6T2pnMU53b0pMeThnYldKeVVHRjVMbUZ0YjNWdWRDQStJSEpsY1hWcGNtVmtDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdiV0p5VUdGNU9pQlFZWGxVZUc0S0NXZDBlRzV6SUVGdGIzVnVkQW9KWm5KaGJXVmZaR2xuSURnZ0x5OGdjbVZ4ZFdseVpXUTZJSFZwYm5RMk5Bb0pQZ29KWW5vZ0ttbG1NRjlsYm1RS0Nna3ZMeUFxYVdZd1gyTnZibk5sY1hWbGJuUUtDUzh2SUdOdmJuUnlZV04wYzF4WFpXNVFZV1JUWVd4bExtRnNaMjh1ZEhNNk9EVTRDZ2t2THlCelpXNWtVR0Y1YldWdWRDaDdJSEpsWTJWcGRtVnlPaUJrYVhOMGNtbGlkWFJwYjI0c0lHRnRiM1Z1ZERvZ2JXSnlVR0Y1TG1GdGIzVnVkQ0F0SUhKbGNYVnBjbVZrTENCbVpXVTZJREFnZlNrS0NXbDBlRzVmWW1WbmFXNEtDV2x1ZEdNZ01DQXZMeUFnY0dGNUNnbHBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDZ29KTHk4Z1kyOXVkSEpoWTNSelhGZGxibEJoWkZOaGJHVXVZV3huYnk1MGN6bzROVGdLQ1M4dklISmxZMlZwZG1WeU9pQmthWE4wY21saWRYUnBiMjRLQ1daeVlXMWxYMlJwWnlBd0lDOHZJR1JwYzNSeWFXSjFkR2x2YmpvZ1lXUmtjbVZ6Y3dvSmFYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb0tDUzh2SUdOdmJuUnlZV04wYzF4WFpXNVFZV1JUWVd4bExtRnNaMjh1ZEhNNk9EVTRDZ2t2THlCaGJXOTFiblE2SUcxaWNsQmhlUzVoYlc5MWJuUWdMU0J5WlhGMWFYSmxaQW9KWm5KaGJXVmZaR2xuSUMweElDOHZJRzFpY2xCaGVUb2dVR0Y1VkhodUNnbG5kSGh1Y3lCQmJXOTFiblFLQ1daeVlXMWxYMlJwWnlBNElDOHZJSEpsY1hWcGNtVmtPaUIxYVc1ME5qUUtDUzBLQ1dsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRmRsYmxCaFpGTmhiR1V1WVd4bmJ5NTBjem80TlRnS0NTOHZJR1psWlRvZ01Bb0phVzUwWXlBeElDOHZJREFLQ1dsMGVHNWZabWxsYkdRZ1JtVmxDZ29KTHk4Z1UzVmliV2wwSUdsdWJtVnlJSFJ5WVc1ellXTjBhVzl1Q2dscGRIaHVYM04xWW0xcGRBb0tLbWxtTUY5bGJtUTZDZ2t2THlCamIyNTBjbUZqZEhOY1YyVnVVR0ZrVTJGc1pTNWhiR2R2TG5Sek9qZzJNUW9KTHk4Z2RHaHBjeTVUWVd4bFEzSmxZWFJsWkM1c2IyY29leUJ6WVd4bFNXUTZJSE5oYkdWSlpDd2dZWEJ3T2lCaGNIQXNJR0ZrYldsdU9pQmhaRzFwYml3Z1pHbHpkSEpwWW5WMGFXOXVPaUJrYVhOMGNtbGlkWFJwYjI0Z2ZTa0tDWEIxYzJoaWVYUmxjeUF3ZURrMVpqaGhOV001SUM4dklGTmhiR1ZEY21WaGRHVmtLSFZwYm5RMk5DeDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1FvSlpuSmhiV1ZmWkdsbklEWWdMeThnYzJGc1pVbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXWnlZVzFsWDJScFp5QTNJQzh2SUdGd2NEb2dkV2x1ZERZMENnbHBkRzlpQ2dsamIyNWpZWFFLQ1daeVlXMWxYMlJwWnlBdE1pQXZMeUJoWkcxcGJqb2dRV1JrY21WemN3b0pZMjl1WTJGMENnbG1jbUZ0WlY5a2FXY2dNQ0F2THlCa2FYTjBjbWxpZFhScGIyNDZJR0ZrWkhKbGMzTUtDV052Ym1OaGRBb0pZMjl1WTJGMENnbHNiMmNLQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamcyTWdvSkx5OGdjbVYwZFhKdUlITmhiR1ZKWkRzS0NXWnlZVzFsWDJScFp5QTJJQzh2SUhOaGJHVkpaRG9nZFdsdWREWTBDZ29KTHk4Z2MyVjBJSFJvWlNCemRXSnliM1YwYVc1bElISmxkSFZ5YmlCMllXeDFaUW9KWm5KaGJXVmZZblZ5ZVNBd0Nnb0pMeThnY0c5d0lHRnNiQ0JzYjJOaGJDQjJZWEpwWVdKc1pYTWdabkp2YlNCMGFHVWdjM1JoWTJzS0NYQnZjRzRnT0FvSmNtVjBjM1ZpQ2dvdkx5QnplVzVqVTJGc1pTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNsMmIybGtDaXBoWW1sZmNtOTFkR1ZmYzNsdVkxTmhiR1U2Q2drdkx5QnpkR0YwZFhNNklIVnBiblEyTkFvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29KWW5SdmFRb0tDUzh2SUhOdmJHUTZJSFZwYm5RMk5Bb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvSlluUnZhUW9LQ1M4dklIUnZkR0ZzU1hSbGJYTTZJSFZwYm5RMk5Bb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvSlluUnZhUW9LQ1M4dklHVnVaRkp2ZFc1a09pQjFhVzUwTmpRS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LQ1dKMGIya0tDZ2t2THlCd2NtbGpaVG9nZFdsdWREWTBDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNnbGlkRzlwQ2dvSkx5OGdjMkZzWlVsa09pQjFhVzUwTmpRS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLQ1dKMGIya0tDZ2t2THlCbGVHVmpkWFJsSUhONWJtTlRZV3hsS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLWFp2YVdRS0NXTmhiR3h6ZFdJZ2MzbHVZMU5oYkdVS0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaTh2SUhONWJtTlRZV3hsS0hOaGJHVkpaRG9nZFdsdWREWTBMQ0J3Y21salpUb2dkV2x1ZERZMExDQmxibVJTYjNWdVpEb2dkV2x1ZERZMExDQjBiM1JoYkVsMFpXMXpPaUIxYVc1ME5qUXNJSE52YkdRNklIVnBiblEyTkN3Z2MzUmhkSFZ6T2lCMWFXNTBOalFwT2lCMmIybGtDaTh2Q2k4dklFTmhiR3hsWkNCaWVTQmhJSE5oYkdVZ1lYQndJSGRvWlc1bGRtVnlJR2wwY3lCemRHRjBaU0JqYUdGdVoyVnpMZ3B6ZVc1alUyRnNaVG9LQ1hCeWIzUnZJRFlnTUFvS0NTOHZJR052Ym5SeVlXTjBjMXhYWlc1UVlXUlRZV3hsTG1Gc1oyOHVkSE02T0RZM0Nna3ZMeUIwYUdsekxtRnpjMlZ5ZEVOaGJHeGxja2x6VTJGc1pTaHpZV3hsU1dRcENnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z2MyRnNaVWxrT2lCMWFXNTBOalFLQ1dOaGJHeHpkV0lnWVhOelpYSjBRMkZzYkdWeVNYTlRZV3hsQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRmRsYmxCaFpGTmhiR1V1WVd4bmJ5NTBjem80TmpnS0NTOHZJSFJvYVhNdWMyRnNaWE1vYzJGc1pVbGtLUzUyWVd4MVpTNXdjbWxqWlNBOUlIQnlhV05sQ2dsd2RYTm9hVzUwSURFd05DQXZMeUJvWldGa1QyWm1jMlYwQ2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnY0hKcFkyVTZJSFZwYm5RMk5Bb0phWFJ2WWdvSllubDBaV01nTVNBdkx5QWdJbk1pQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnYzJGc1pVbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXTnZibU5oZEFvSlkyOTJaWElnTWdvSlltOTRYM0psY0d4aFkyVUtDZ2t2THlCamIyNTBjbUZqZEhOY1YyVnVVR0ZrVTJGc1pTNWhiR2R2TG5Sek9qZzJPUW9KTHk4Z2RHaHBjeTV6WVd4bGN5aHpZV3hsU1dRcExuWmhiSFZsTG1WdVpGSnZkVzVrSUQwZ1pXNWtVbTkxYm1RS0NYQjFjMmhwYm5RZ01USXdJQzh2SUdobFlXUlBabVp6WlhRS0NXWnlZVzFsWDJScFp5QXRNeUF2THlCbGJtUlNiM1Z1WkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xpZVhSbFl5QXhJQzh2SUNBaWN5SUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QnpZV3hsU1dRNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5dVkyRjBDZ2xqYjNabGNpQXlDZ2xpYjNoZmNtVndiR0ZqWlFvS0NTOHZJR052Ym5SeVlXTjBjMXhYWlc1UVlXUlRZV3hsTG1Gc1oyOHVkSE02T0Rjd0Nna3ZMeUIwYUdsekxuTmhiR1Z6S0hOaGJHVkpaQ2t1ZG1Gc2RXVXVkRzkwWVd4SmRHVnRjeUE5SUhSdmRHRnNTWFJsYlhNS0NYQjFjMmhwYm5RZ01USTRJQzh2SUdobFlXUlBabVp6WlhRS0NXWnlZVzFsWDJScFp5QXROQ0F2THlCMGIzUmhiRWwwWlcxek9pQjFhVzUwTmpRS0NXbDBiMklLQ1dKNWRHVmpJREVnTHk4Z0lDSnpJZ29KWm5KaGJXVmZaR2xuSUMweElDOHZJSE5oYkdWSlpEb2dkV2x1ZERZMENnbHBkRzlpQ2dsamIyNWpZWFFLQ1dOdmRtVnlJRElLQ1dKdmVGOXlaWEJzWVdObENnb0pMeThnWTI5dWRISmhZM1J6WEZkbGJsQmhaRk5oYkdVdVlXeG5ieTUwY3pvNE56RUtDUzh2SUhSb2FYTXVjMkZzWlhNb2MyRnNaVWxrS1M1MllXeDFaUzV6YjJ4a0lEMGdjMjlzWkFvSmFXNTBZeUE1SUM4dklDQm9aV0ZrVDJabWMyVjBDZ2xtY21GdFpWOWthV2NnTFRVZ0x5OGdjMjlzWkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xpZVhSbFl5QXhJQzh2SUNBaWN5SUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QnpZV3hsU1dRNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5dVkyRjBDZ2xqYjNabGNpQXlDZ2xpYjNoZmNtVndiR0ZqWlFvS0NTOHZJR052Ym5SeVlXTjBjMXhYWlc1UVlXUlRZV3hsTG1Gc1oyOHVkSE02T0RjeUNna3ZMeUIwYUdsekxuTmhiR1Z6S0hOaGJHVkpaQ2t1ZG1Gc2RXVXVjM1JoZEhWeklEMGdjM1JoZEhWekNnbHdkWE5vYVc1MElERTBOQ0F2THlCb1pXRmtUMlptYzJWMENnbG1jbUZ0WlY5a2FXY2dMVFlnTHk4Z2MzUmhkSFZ6T2lCMWFXNTBOalFLQ1dsMGIySUtDV0o1ZEdWaklERWdMeThnSUNKeklnb0pabkpoYldWZlpHbG5JQzB4SUM4dklITmhiR1ZKWkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjI1allYUUtDV052ZG1WeUlESUtDV0p2ZUY5eVpYQnNZV05sQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRmRsYmxCaFpGTmhiR1V1WVd4bmJ5NTBjem80TnpRS0NTOHZJSFJvYVhNdVUyRnNaVk41Ym1ObFpDNXNiMmNvZXlCellXeGxTV1E2SUhOaGJHVkpaQ3dnYzNSaGRIVnpPaUJ6ZEdGMGRYTXNJSFJ2ZEdGc1NYUmxiWE02SUhSdmRHRnNTWFJsYlhNc0lITnZiR1E2SUhOdmJHUWdmU2tLQ1hCMWMyaGllWFJsY3lBd2VEbGhPR1kwTm1GaklDOHZJRk5oYkdWVGVXNWpaV1FvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1FvSlpuSmhiV1ZmWkdsbklDMHhJQzh2SUhOaGJHVkpaRG9nZFdsdWREWTBDZ2xwZEc5aUNnbG1jbUZ0WlY5a2FXY2dMVFlnTHk4Z2MzUmhkSFZ6T2lCMWFXNTBOalFLQ1dsMGIySUtDV052Ym1OaGRBb0pabkpoYldWZlpHbG5JQzAwSUM4dklIUnZkR0ZzU1hSbGJYTTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlkyOXVZMkYwQ2dsbWNtRnRaVjlrYVdjZ0xUVWdMeThnYzI5c1pEb2dkV2x1ZERZMENnbHBkRzlpQ2dsamIyNWpZWFFLQ1dOdmJtTmhkQW9KYkc5bkNnbHlaWFJ6ZFdJS0NpOHZJR3h2WjFCMWNtTm9ZWE5sS0hWcGJuUTJOQ3gxYVc1ME5qUXNZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0NpcGhZbWxmY205MWRHVmZiRzluVUhWeVkyaGhjMlU2Q2drdkx5QnlaVzFoYVc1cGJtYzZJSFZwYm5RMk5Bb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTmdvSlluUnZhUW9LQ1M4dklITnZiR1E2SUhWcGJuUTJOQW9KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb0pZblJ2YVFvS0NTOHZJSEJ5YVdObE9pQjFhVzUwTmpRS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLQ1dKMGIya0tDZ2t2THlCaWRYbGxjam9nWVdSa2NtVnpjd29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b0paSFZ3Q2dsc1pXNEtDV2x1ZEdNZ015QXZMeUF6TWdvSlBUMEtDZ2t2THlCaGNtZDFiV1Z1ZENBeklDaGlkWGxsY2lrZ1ptOXlJR3h2WjFCMWNtTm9ZWE5sSUcxMWMzUWdZbVVnWVNCaFpHUnlaWE56Q2dsaGMzTmxjblFLQ2drdkx5QmhjM05sZERvZ2RXbHVkRFkwQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDZ2xpZEc5cENnb0pMeThnYzJGc1pVbGtPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXSjBiMmtLQ2drdkx5QmxlR1ZqZFhSbElHeHZaMUIxY21Ob1lYTmxLSFZwYm5RMk5DeDFhVzUwTmpRc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrQ2dsallXeHNjM1ZpSUd4dloxQjFjbU5vWVhObENnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCc2IyZFFkWEpqYUdGelpTaHpZV3hsU1dRNklIVnBiblEyTkN3Z1lYTnpaWFE2SUVGemMyVjBTVVFzSUdKMWVXVnlPaUJCWkdSeVpYTnpMQ0J3Y21salpUb2dkV2x1ZERZMExDQnpiMnhrT2lCMWFXNTBOalFzSUhKbGJXRnBibWx1WnpvZ2RXbHVkRFkwS1RvZ2RtOXBaQW92THdvdkx5QkRZV3hzWldRZ1lua2dZU0J6WVd4bElHRndjQ0J2YmlCbGRtVnllU0JrWld4cGRtVnlaV1FnYVhSbGJTNEtiRzluVUhWeVkyaGhjMlU2Q2dsd2NtOTBieUEySURBS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVjJWdVVHRmtVMkZzWlM1aGJHZHZMblJ6T2pnM09Rb0pMeThnZEdocGN5NWhjM05sY25SRFlXeHNaWEpKYzFOaGJHVW9jMkZzWlVsa0tRb0pabkpoYldWZlpHbG5JQzB4SUM4dklITmhiR1ZKWkRvZ2RXbHVkRFkwQ2dsallXeHNjM1ZpSUdGemMyVnlkRU5oYkd4bGNrbHpVMkZzWlFvS0NTOHZJR052Ym5SeVlXTjBjMXhYWlc1UVlXUlRZV3hsTG1Gc1oyOHVkSE02T0Rnd0Nna3ZMeUIwYUdsekxuTmhiR1Z6S0hOaGJHVkpaQ2t1ZG1Gc2RXVXVjMjlzWkNBOUlITnZiR1FLQ1dsdWRHTWdPU0F2THlBZ2FHVmhaRTltWm5ObGRBb0pabkpoYldWZlpHbG5JQzAxSUM4dklITnZiR1E2SUhWcGJuUTJOQW9KYVhSdllnb0pZbmwwWldNZ01TQXZMeUFnSW5NaUNnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z2MyRnNaVWxrT2lCMWFXNTBOalFLQ1dsMGIySUtDV052Ym1OaGRBb0pZMjkyWlhJZ01nb0pZbTk0WDNKbGNHeGhZMlVLQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamc0TVFvSkx5OGdkR2hwY3k1ellXeGxjeWh6WVd4bFNXUXBMblpoYkhWbExuWnZiSFZ0WlNBOUlIUm9hWE11YzJGc1pYTW9jMkZzWlVsa0tTNTJZV3gxWlM1MmIyeDFiV1VnS3lCd2NtbGpaUW9KYVc1MFl5QXhNQ0F2THlBZ2FHVmhaRTltWm5ObGRBb0paSFZ3Q2dscGJuUmpJRElnTHk4Z09Bb0pZbmwwWldNZ01TQXZMeUFnSW5NaUNnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z2MyRnNaVWxrT2lCMWFXNTBOalFLQ1dsMGIySUtDV052Ym1OaGRBb0pZMjkyWlhJZ01nb0pZbTk0WDJWNGRISmhZM1FLQ1dKMGIya0tDV1p5WVcxbFgyUnBaeUF0TkNBdkx5QndjbWxqWlRvZ2RXbHVkRFkwQ2drckNnbHBkRzlpQ2dsaWVYUmxZeUF4SUM4dklDQWljeUlLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJ6WVd4bFNXUTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlkyOXVZMkYwQ2dsamIzWmxjaUF5Q2dsaWIzaGZjbVZ3YkdGalpRb0tDUzh2SUdOdmJuUnlZV04wYzF4WFpXNVFZV1JUWVd4bExtRnNaMjh1ZEhNNk9EZ3lDZ2t2THlCMGFHbHpMblJ2ZEdGc1ZtOXNkVzFsTG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkZadmJIVnRaUzUyWVd4MVpTQXJJSEJ5YVdObENnbGllWFJsWXlBMUlDOHZJQ0FpZEc5MFlXeGZkbTlzZFcxbElnb0paSFZ3Q2dsaGNIQmZaMnh2WW1Gc1gyZGxkQW9KWm5KaGJXVmZaR2xuSUMwMElDOHZJSEJ5YVdObE9pQjFhVzUwTmpRS0NTc0tDV0Z3Y0Y5bmJHOWlZV3hmY0hWMENnb0pMeThnWTI5dWRISmhZM1J6WEZkbGJsQmhaRk5oYkdVdVlXeG5ieTUwY3pvNE9EUUtDUzh2SUhSb2FYTXVVSFZ5WTJoaGMyVXViRzluS0hzZ2MyRnNaVWxrT2lCellXeGxTV1FzSUdGd2NEb2daMnh2WW1Gc2N5NWpZV3hzWlhKQmNIQnNhV05oZEdsdmJrbEVMQ0JoYzNObGREb2dZWE56WlhRc0lHSjFlV1Z5T2lCaWRYbGxjaXdnY0hKcFkyVTZJSEJ5YVdObElIMHBDZ2x3ZFhOb1lubDBaWE1nTUhoa01HSTRNekptTlNBdkx5QlFkWEpqYUdGelpTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3hoWkdSeVpYTnpMSFZwYm5RMk5Da0tDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QnpZV3hsU1dRNklIVnBiblEyTkFvSmFYUnZZZ29KWjJ4dlltRnNJRU5oYkd4bGNrRndjR3hwWTJGMGFXOXVTVVFLQ1dsMGIySUtDV052Ym1OaGRBb0pabkpoYldWZlpHbG5JQzB5SUM4dklHRnpjMlYwT2lCQmMzTmxkRWxFQ2dscGRHOWlDZ2xqYjI1allYUUtDV1p5WVcxbFgyUnBaeUF0TXlBdkx5QmlkWGxsY2pvZ1FXUmtjbVZ6Y3dvSlkyOXVZMkYwQ2dsbWNtRnRaVjlrYVdjZ0xUUWdMeThnY0hKcFkyVTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlkyOXVZMkYwQ2dsamIyNWpZWFFLQ1d4dlp3b0pjbVYwYzNWaUNnb3ZMeUIxY0dSaGRHVk5aWFJoWkdGMFlTaHdZWGtzZFdsdWREWTBMSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeWwyYjJsa0NpcGhZbWxmY205MWRHVmZkWEJrWVhSbFRXVjBZV1JoZEdFNkNna3ZMeUJ0WlhSaFpHRjBZVlZ5YkRvZ2MzUnlhVzVuQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDZ2xsZUhSeVlXTjBJRElnTUFvS0NTOHZJSE4wWVc1a1lYSmtPaUJ6ZEhKcGJtY0tDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0NXVjRkSEpoWTNRZ01pQXdDZ29KTHk4Z2RXNXBkRTVoYldVNklITjBjbWx1WndvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29KWlhoMGNtRmpkQ0F5SURBS0Nna3ZMeUJ1WVcxbE9pQnpkSEpwYm1jS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLQ1dWNGRISmhZM1FnTWlBd0Nnb0pMeThnYzJGc1pVbGtPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXSjBiMmtLQ2drdkx5QnRZbkpRWVhrNklIQmhlUW9KZEhodUlFZHliM1Z3U1c1a1pYZ0tDV2x1ZEdNZ01DQXZMeUF4Q2drdENnbGtkWEFLQ1dkMGVHNXpJRlI1Y0dWRmJuVnRDZ2xwYm5SaklEQWdMeThnSUhCaGVRb0pQVDBLQ2drdkx5QmhjbWQxYldWdWRDQTFJQ2h0WW5KUVlYa3BJR1p2Y2lCMWNHUmhkR1ZOWlhSaFpHRjBZU0J0ZFhOMElHSmxJR0VnY0dGNUlIUnlZVzV6WVdOMGFXOXVDZ2xoYzNObGNuUUtDZ2t2THlCbGVHVmpkWFJsSUhWd1pHRjBaVTFsZEdGa1lYUmhLSEJoZVN4MWFXNTBOalFzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuS1hadmFXUUtDV05oYkd4emRXSWdkWEJrWVhSbFRXVjBZV1JoZEdFS0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaTh2SUhWd1pHRjBaVTFsZEdGa1lYUmhLRzFpY2xCaGVUb2dVR0Y1VkhodUxDQnpZV3hsU1dRNklIVnBiblEyTkN3Z2JtRnRaVG9nYzNSeWFXNW5MQ0IxYm1sMFRtRnRaVG9nYzNSeWFXNW5MQ0J6ZEdGdVpHRnlaRG9nYzNSeWFXNW5MQ0J0WlhSaFpHRjBZVlZ5YkRvZ2MzUnlhVzVuS1RvZ2RtOXBaQW92THdvdkx5QkJaRzFwYmkxdmJteDVMaUJRWVhsdFpXNTBJR052ZG1WeWN5QmhibmtnVFVKU0lHbHVZM0psWVhObE95QmhibmtnWkdWamNtVmhjMlVnYVhNZ2NtVm1kVzVrWldRdUNuVndaR0YwWlUxbGRHRmtZWFJoT2dvSmNISnZkRzhnTmlBd0Nnb0pMeThnVUhWemFDQmxiWEIwZVNCaWVYUmxjeUJoWm5SbGNpQjBhR1VnWm5KaGJXVWdjRzlwYm5SbGNpQjBieUJ5WlhObGNuWmxJSE53WVdObElHWnZjaUJzYjJOaGJDQjJZWEpwWVdKc1pYTUtDV0o1ZEdWaklEQWdMeThnTUhnS0NXUjFjRzRnTXdvS0NTOHZJR052Ym5SeVlXTjBjMXhYWlc1UVlXUlRZV3hsTG1Gc1oyOHVkSE02T0RrMkNna3ZMeUJoYzNObGNuUW9kR2hwY3k1ellXeGxjeWh6WVd4bFNXUXBMbVY0YVhOMGN5a0tDV0o1ZEdWaklERWdMeThnSUNKeklnb0pabkpoYldWZlpHbG5JQzB5SUM4dklITmhiR1ZKWkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjI1allYUUtDV0p2ZUY5c1pXNEtDWE4zWVhBS0NYQnZjQW9KWVhOelpYSjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhGZGxibEJoWkZOaGJHVXVZV3huYnk1MGN6bzRPVGNLQ1M4dklHRmtiV2x1SUQwZ2RHaHBjeTV6WVd4bGN5aHpZV3hsU1dRcExuWmhiSFZsTG1Ga2JXbHVDZ2xwYm5SaklESWdMeThnSUdobFlXUlBabVp6WlhRS0NXbHVkR01nTXlBdkx5QXpNZ29KWW5sMFpXTWdNU0F2THlBZ0luTWlDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdjMkZzWlVsa09pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KWTI5MlpYSWdNZ29KWW05NFgyVjRkSEpoWTNRS0NXWnlZVzFsWDJKMWNua2dNQ0F2THlCaFpHMXBiam9nWVdSa2NtVnpjd29LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZPRGs0Q2drdkx5QmhjM05sY25Rb2RHaHBjeTUwZUc0dWMyVnVaR1Z5SUQwOVBTQmhaRzFwYmlrS0NYUjRiaUJUWlc1a1pYSUtDV1p5WVcxbFgyUnBaeUF3SUM4dklHRmtiV2x1T2lCaFpHUnlaWE56Q2drOVBRb0pZWE56WlhKMENnb0pMeThnWTI5dWRISmhZM1J6WEZkbGJsQmhaRk5oYkdVdVlXeG5ieTUwY3pvNE9Ua0tDUzh2SUdGemMyVnlkQ2h1WVcxbExteGxibWQwYUNBOFBTQTJOQ2tLQ1daeVlXMWxYMlJwWnlBdE15QXZMeUJ1WVcxbE9pQnpkSEpwYm1jS0NXeGxiZ29KYVc1MFl5QTRJQzh2SURZMENnazhQUW9KWVhOelpYSjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhGZGxibEJoWkZOaGJHVXVZV3huYnk1MGN6bzVNREFLQ1M4dklHRnpjMlZ5ZENoMWJtbDBUbUZ0WlM1c1pXNW5kR2dnUEQwZ09Da0tDV1p5WVcxbFgyUnBaeUF0TkNBdkx5QjFibWwwVG1GdFpUb2djM1J5YVc1bkNnbHNaVzRLQ1dsdWRHTWdNaUF2THlBNENnazhQUW9KWVhOelpYSjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhGZGxibEJoWkZOaGJHVXVZV3huYnk1MGN6bzVNREVLQ1M4dklHRnpjMlZ5ZENoemRHRnVaR0Z5WkM1c1pXNW5kR2dnUEQwZ09Da0tDV1p5WVcxbFgyUnBaeUF0TlNBdkx5QnpkR0Z1WkdGeVpEb2djM1J5YVc1bkNnbHNaVzRLQ1dsdWRHTWdNaUF2THlBNENnazhQUW9KWVhOelpYSjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhGZGxibEJoWkZOaGJHVXVZV3huYnk1MGN6bzVNRElLQ1M4dklHRnpjMlZ5ZENodFpYUmhaR0YwWVZWeWJDNXNaVzVuZEdnZ1BEMGdNalUyS1FvSlpuSmhiV1ZmWkdsbklDMDJJQzh2SUcxbGRHRmtZWFJoVlhKc09pQnpkSEpwYm1jS0NXeGxiZ29KYVc1MFl5QTNJQzh2SURJMU5nb0pQRDBLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZPVEF6Q2drdkx5QjJaWEpwWm5sUVlYbFVlRzRvYldKeVVHRjVMQ0I3SUhObGJtUmxjam9nWVdSdGFXNHNJSEpsWTJWcGRtVnlPaUIwYUdsekxtRndjQzVoWkdSeVpYTnpJSDBwQ2drdkx5QjJaWEpwWm5rZ2MyVnVaR1Z5Q2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnYldKeVVHRjVPaUJRWVhsVWVHNEtDV2QwZUc1eklGTmxibVJsY2dvSlpuSmhiV1ZmWkdsbklEQWdMeThnWVdSdGFXNDZJR0ZrWkhKbGMzTUtDVDA5Q2dvSkx5OGdkSEpoYm5OaFkzUnBiMjRnZG1WeWFXWnBZMkYwYVc5dUlHWmhhV3hsWkRvZ2V5SjBlRzRpT2lKdFluSlFZWGtpTENKbWFXVnNaQ0k2SW5ObGJtUmxjaUlzSW1WNGNHVmpkR1ZrSWpvaVlXUnRhVzRpZlFvSllYTnpaWEowQ2dvSkx5OGdkbVZ5YVdaNUlISmxZMlZwZG1WeUNnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z2JXSnlVR0Y1T2lCUVlYbFVlRzRLQ1dkMGVHNXpJRkpsWTJWcGRtVnlDZ2xuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b0pQVDBLQ2drdkx5QjBjbUZ1YzJGamRHbHZiaUIyWlhKcFptbGpZWFJwYjI0Z1ptRnBiR1ZrT2lCN0luUjRiaUk2SW0xaWNsQmhlU0lzSW1acFpXeGtJam9pY21WalpXbDJaWElpTENKbGVIQmxZM1JsWkNJNkluUm9hWE11WVhCd0xtRmtaSEpsYzNNaWZRb0pZWE56WlhKMENnb0pMeThnWTI5dWRISmhZM1J6WEZkbGJsQmhaRk5oYkdVdVlXeG5ieTUwY3pvNU1EVUtDUzh2SUhCeVpVMWljaUE5SUhSb2FYTXVZWEJ3TG1Ga1pISmxjM011YldsdVFtRnNZVzVqWlFvSloyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LQ1dGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFRXbHVRbUZzWVc1alpRb0pjRzl3Q2dsbWNtRnRaVjlpZFhKNUlERWdMeThnY0hKbFRXSnlPaUIxYVc1ME5qUUtDZ2t2THlCamIyNTBjbUZqZEhOY1YyVnVVR0ZrVTJGc1pTNWhiR2R2TG5Sek9qa3dOZ29KTHk4Z2RHaHBjeTV0WlhSaFpHRjBZU2h6WVd4bFNXUXBMbVJsYkdWMFpTZ3BDZ2xpZVhSbFl5QXpJQzh2SUNBaWJTSUtDV1p5WVcxbFgyUnBaeUF0TWlBdkx5QnpZV3hsU1dRNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5dVkyRjBDZ2xpYjNoZlpHVnNDZ29KTHk4Z1kyOXVkSEpoWTNSelhGZGxibEJoWkZOaGJHVXVZV3huYnk1MGN6bzVNRGNLQ1M4dklIUm9hWE11YldWMFlXUmhkR0VvYzJGc1pVbGtLUzUyWVd4MVpTQTlJSHNLQ1M4dklDQWdJQ0FnSUc1aGJXVTZJRzVoYldVc0Nna3ZMeUFnSUNBZ0lDQjFibWwwVG1GdFpUb2dkVzVwZEU1aGJXVXNDZ2t2THlBZ0lDQWdJQ0J6ZEdGdVpHRnlaRG9nYzNSaGJtUmhjbVFzQ2drdkx5QWdJQ0FnSUNCdFpYUmhaR0YwWVZWeWJEb2diV1YwWVdSaGRHRlZjbXdzQ2drdkx5QWdJQ0FnZlFvSllubDBaV01nTXlBdkx5QWdJbTBpQ2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnYzJGc1pVbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXTnZibU5oZEFvSlpIVndDZ2xpYjNoZlpHVnNDZ2x3YjNBS0NXSjVkR1ZqSURBZ0x5OGdJR2x1YVhScFlXd2dhR1ZoWkFvSllubDBaV01nTUNBdkx5QWdhVzVwZEdsaGJDQjBZV2xzQ2dsaWVYUmxZeUE1SUM4dklDQnBibWwwYVdGc0lHaGxZV1FnYjJabWMyVjBDZ2xtY21GdFpWOWthV2NnTFRNZ0x5OGdibUZ0WlRvZ2MzUnlhVzVuQ2dsa2RYQUtDV3hsYmdvSmFYUnZZZ29KWlhoMGNtRmpkQ0EySURJS0NYTjNZWEFLQ1dOdmJtTmhkQW9KWTJGc2JITjFZaUFxY0hKdlkyVnpjMTlrZVc1aGJXbGpYM1IxY0d4bFgyVnNaVzFsYm5RS0NXWnlZVzFsWDJScFp5QXROQ0F2THlCMWJtbDBUbUZ0WlRvZ2MzUnlhVzVuQ2dsa2RYQUtDV3hsYmdvSmFYUnZZZ29KWlhoMGNtRmpkQ0EySURJS0NYTjNZWEFLQ1dOdmJtTmhkQW9KWTJGc2JITjFZaUFxY0hKdlkyVnpjMTlrZVc1aGJXbGpYM1IxY0d4bFgyVnNaVzFsYm5RS0NXWnlZVzFsWDJScFp5QXROU0F2THlCemRHRnVaR0Z5WkRvZ2MzUnlhVzVuQ2dsa2RYQUtDV3hsYmdvSmFYUnZZZ29KWlhoMGNtRmpkQ0EySURJS0NYTjNZWEFLQ1dOdmJtTmhkQW9KWTJGc2JITjFZaUFxY0hKdlkyVnpjMTlrZVc1aGJXbGpYM1IxY0d4bFgyVnNaVzFsYm5RS0NXWnlZVzFsWDJScFp5QXROaUF2THlCdFpYUmhaR0YwWVZWeWJEb2djM1J5YVc1bkNnbGtkWEFLQ1d4bGJnb0phWFJ2WWdvSlpYaDBjbUZqZENBMklESUtDWE4zWVhBS0NXTnZibU5oZEFvSlkyRnNiSE4xWWlBcWNISnZZMlZ6YzE5a2VXNWhiV2xqWDNSMWNHeGxYMlZzWlcxbGJuUUtDWEJ2Y0NBdkx5QndiM0FnYUdWaFpDQnZabVp6WlhRS0NXTnZibU5oZENBdkx5QmpiMjVqWVhRZ2FHVmhaQ0JoYm1RZ2RHRnBiQW9KWW05NFgzQjFkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZPVEV6Q2drdkx5QndiM04wVFdKeUlEMGdkR2hwY3k1aGNIQXVZV1JrY21WemN5NXRhVzVDWVd4aGJtTmxDZ2xuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b0pZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JOYVc1Q1lXeGhibU5sQ2dsd2IzQUtDV1p5WVcxbFgySjFjbmtnTWlBdkx5QndiM04wVFdKeU9pQjFhVzUwTmpRS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVjJWdVVHRmtVMkZzWlM1aGJHZHZMblJ6T2preE5nb0pMeThnY21WbWRXNWtJRDBnYldKeVVHRjVMbUZ0YjNWdWRDQXJJSEJ5WlUxaWNnb0pabkpoYldWZlpHbG5JQzB4SUM4dklHMWljbEJoZVRvZ1VHRjVWSGh1Q2dsbmRIaHVjeUJCYlc5MWJuUUtDV1p5WVcxbFgyUnBaeUF4SUM4dklIQnlaVTFpY2pvZ2RXbHVkRFkwQ2drckNnbG1jbUZ0WlY5aWRYSjVJRE1nTHk4Z2NtVm1kVzVrT2lCMWFXNTBOalFLQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamt4TndvSkx5OGdZWE56WlhKMEtISmxablZ1WkNBK1BTQndiM04wVFdKeUtRb0pabkpoYldWZlpHbG5JRE1nTHk4Z2NtVm1kVzVrT2lCMWFXNTBOalFLQ1daeVlXMWxYMlJwWnlBeUlDOHZJSEJ2YzNSTlluSTZJSFZwYm5RMk5Bb0pQajBLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZPVEU0Q2drdkx5QnlaV1oxYm1RZ1BTQnlaV1oxYm1RZ0xTQndiM04wVFdKeUNnbG1jbUZ0WlY5a2FXY2dNeUF2THlCeVpXWjFibVE2SUhWcGJuUTJOQW9KWm5KaGJXVmZaR2xuSURJZ0x5OGdjRzl6ZEUxaWNqb2dkV2x1ZERZMENna3RDZ2xtY21GdFpWOWlkWEo1SURNZ0x5OGdjbVZtZFc1a09pQjFhVzUwTmpRS0Nna3ZMeUFxYVdZeFgyTnZibVJwZEdsdmJnb0pMeThnWTI5dWRISmhZM1J6WEZkbGJsQmhaRk5oYkdVdVlXeG5ieTUwY3pvNU1Ua0tDUzh2SUhKbFpuVnVaQ0ErSURBS0NXWnlZVzFsWDJScFp5QXpJQzh2SUhKbFpuVnVaRG9nZFdsdWREWTBDZ2xwYm5SaklERWdMeThnTUFvSlBnb0pZbm9nS21sbU1WOWxibVFLQ2drdkx5QXFhV1l4WDJOdmJuTmxjWFZsYm5RS0NTOHZJR052Ym5SeVlXTjBjMXhYWlc1UVlXUlRZV3hsTG1Gc1oyOHVkSE02T1RJd0Nna3ZMeUJ6Wlc1a1VHRjViV1Z1ZENoN0lISmxZMlZwZG1WeU9pQmhaRzFwYml3Z1lXMXZkVzUwT2lCeVpXWjFibVFzSUdabFpUb2dNQ0I5S1FvSmFYUjRibDlpWldkcGJnb0phVzUwWXlBd0lDOHZJQ0J3WVhrS0NXbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtDZ2t2THlCamIyNTBjbUZqZEhOY1YyVnVVR0ZrVTJGc1pTNWhiR2R2TG5Sek9qa3lNQW9KTHk4Z2NtVmpaV2wyWlhJNklHRmtiV2x1Q2dsbWNtRnRaVjlrYVdjZ01DQXZMeUJoWkcxcGJqb2dZV1JrY21WemN3b0phWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZPVEl3Q2drdkx5QmhiVzkxYm5RNklISmxablZ1WkFvSlpuSmhiV1ZmWkdsbklETWdMeThnY21WbWRXNWtPaUIxYVc1ME5qUUtDV2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDZ29KTHk4Z1kyOXVkSEpoWTNSelhGZGxibEJoWkZOaGJHVXVZV3huYnk1MGN6bzVNakFLQ1M4dklHWmxaVG9nTUFvSmFXNTBZeUF4SUM4dklEQUtDV2wwZUc1ZlptbGxiR1FnUm1WbENnb0pMeThnVTNWaWJXbDBJR2x1Ym1WeUlIUnlZVzV6WVdOMGFXOXVDZ2xwZEhodVgzTjFZbTFwZEFvS0ttbG1NVjlsYm1RNkNna3ZMeUJqYjI1MGNtRmpkSE5jVjJWdVVHRmtVMkZzWlM1aGJHZHZMblJ6T2preU13b0pMeThnZEdocGN5NU5aWFJoWkdGMFlWVndaR0YwWldRdWJHOW5LSHNnYzJGc1pVbGtPaUJ6WVd4bFNXUWdmU2tLQ1hCMWMyaGllWFJsY3lBd2VHUmxZVGt4WW1Jd0lDOHZJRTFsZEdGa1lYUmhWWEJrWVhSbFpDaDFhVzUwTmpRcENnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z2MyRnNaVWxrT2lCMWFXNTBOalFLQ1dsMGIySUtDV052Ym1OaGRBb0piRzluQ2dseVpYUnpkV0lLQ2k4dklHUmxiR1YwWlZOaGJHVW9kV2x1ZERZMEtYWnZhV1FLS21GaWFWOXliM1YwWlY5a1pXeGxkR1ZUWVd4bE9nb0pMeThnYzJGc1pVbGtPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXSjBiMmtLQ2drdkx5QmxlR1ZqZFhSbElHUmxiR1YwWlZOaGJHVW9kV2x1ZERZMEtYWnZhV1FLQ1dOaGJHeHpkV0lnWkdWc1pYUmxVMkZzWlFvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnWkdWc1pYUmxVMkZzWlNoellXeGxTV1E2SUhWcGJuUTJOQ2s2SUhadmFXUUtMeThLTHk4Z1EyRnNiR0ZpYkdVZ1lua2dZVzU1YjI1bElDaDBhR1VnYTJWbGNHVnlJR05zYjNObGN5QmhJRk5vZFdabWJHVWdjbWxuYUhRZ1lXWjBaWElnYVhSeklHeGhjM1FnWkdWc2FYWmxjbmtwTGlCRVpXeGxkR1Z6SUdFS0x5OGdjbVZzWldGelpXUWdjMkZzWlNCaGNIQWdLR0ZtZEdWeUlHbDBjeUJwZEdWdElIQmhaMlZ6SUdGeVpTQm1jbVZsWkNrZ1lXNWtJR2wwY3lCcGJtUmxlQ0JsYm5SeWFXVnpMaUJPYjNSb2FXNW5JR05oYmlCaVpRb3ZMeUJ5WldScGNtVmpkR1ZrT2lCd2NtOWpaV1ZrY3lCbmJ5QjBieUIwYUdVZ2NHRjViM1YwSUhOd2JHbDBMQ0JoYkd3Z1RVSlNJSFJ2SUhSb1pTQmthWE4wY21saWRYUnBiMjRnZDJGc2JHVjBMQ0JoYm1RZ2RHaGxDaTh2SUhOaGJHVWdZWEJ3SUdsMGMyVnNaaUJ5WldaMWMyVnpJR1JsYkdWMGFXOXVJSFZ1YkdWemN5QnBkQ0JwY3lCeVpXeGxZWE5sWkNCM2FYUm9JRzV2ZEdocGJtY2djR1Z1WkdsdVp5NGdVSFZ5WTJoaGMyVUtMeThnYUdsemRHOXllU0J6ZEdGNWN5QnBiaUIwYUdVZ1pYWmxiblFnYkc5bmN5NEtaR1ZzWlhSbFUyRnNaVG9LQ1hCeWIzUnZJREVnTUFvS0NTOHZJRkIxYzJnZ1pXMXdkSGtnWW5sMFpYTWdZV1owWlhJZ2RHaGxJR1p5WVcxbElIQnZhVzUwWlhJZ2RHOGdjbVZ6WlhKMlpTQnpjR0ZqWlNCbWIzSWdiRzlqWVd3Z2RtRnlhV0ZpYkdWekNnbGllWFJsWXlBd0lDOHZJREI0Q2dsa2RYQnVJRE1LQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamt6TkFvSkx5OGdZWE56WlhKMEtIUm9hWE11YzJGc1pYTW9jMkZzWlVsa0tTNWxlR2x6ZEhNcENnbGllWFJsWXlBeElDOHZJQ0FpY3lJS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCellXeGxTV1E2SUhWcGJuUTJOQW9KYVhSdllnb0pZMjl1WTJGMENnbGliM2hmYkdWdUNnbHpkMkZ3Q2dsd2IzQUtDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4WFpXNVFZV1JUWVd4bExtRnNaMjh1ZEhNNk9UTTJDZ2t2THlCaFpHMXBiaUE5SUhSb2FYTXVjMkZzWlhNb2MyRnNaVWxrS1M1MllXeDFaUzVoWkcxcGJnb0phVzUwWXlBeUlDOHZJQ0JvWldGa1QyWm1jMlYwQ2dscGJuUmpJRE1nTHk4Z016SUtDV0o1ZEdWaklERWdMeThnSUNKeklnb0pabkpoYldWZlpHbG5JQzB4SUM4dklITmhiR1ZKWkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjI1allYUUtDV052ZG1WeUlESUtDV0p2ZUY5bGVIUnlZV04wQ2dsbWNtRnRaVjlpZFhKNUlEQWdMeThnWVdSdGFXNDZJR0ZrWkhKbGMzTUtDZ2t2THlCamIyNTBjbUZqZEhOY1YyVnVVR0ZrVTJGc1pTNWhiR2R2TG5Sek9qa3pOd29KTHk4Z1lYQndJRDBnZEdocGN5NXpZV3hsY3loellXeGxTV1FwTG5aaGJIVmxMbUZ3Y0FvSmFXNTBZeUF4SUM4dklEQUtDV2x1ZEdNZ01pQXZMeUE0Q2dsaWVYUmxZeUF4SUM4dklDQWljeUlLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJ6WVd4bFNXUTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlkyOXVZMkYwQ2dsamIzWmxjaUF5Q2dsaWIzaGZaWGgwY21GamRBb0pZblJ2YVFvSlpuSmhiV1ZmWW5WeWVTQXhJQzh2SUdGd2NEb2dkV2x1ZERZMENnb0pMeThnWTI5dWRISmhZM1J6WEZkbGJsQmhaRk5oYkdVdVlXeG5ieTUwY3pvNU16Z0tDUzh2SUdScGMzUnlhV0oxZEdsdmJpQTlJSFJvYVhNdWMyRnNaWE1vYzJGc1pVbGtLUzUyWVd4MVpTNWthWE4wY21saWRYUnBiMjRLQ1dsdWRHTWdOU0F2THlBZ2FHVmhaRTltWm5ObGRBb0phVzUwWXlBeklDOHZJRE15Q2dsaWVYUmxZeUF4SUM4dklDQWljeUlLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJ6WVd4bFNXUTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlkyOXVZMkYwQ2dsamIzWmxjaUF5Q2dsaWIzaGZaWGgwY21GamRBb0pabkpoYldWZlluVnllU0F5SUM4dklHUnBjM1J5YVdKMWRHbHZiam9nWVdSa2NtVnpjd29LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZPVFF3Q2drdkx5QndjbVZOWW5JZ1BTQjBhR2x6TG1Gd2NDNWhaR1J5WlhOekxtMXBia0poYkdGdVkyVUtDV2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNnbGhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRTFwYmtKaGJHRnVZMlVLQ1hCdmNBb0pabkpoYldWZlluVnllU0F6SUM4dklIQnlaVTFpY2pvZ2RXbHVkRFkwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRmRsYmxCaFpGTmhiR1V1WVd4bmJ5NTBjem81TkRJS0NTOHZJSE5sYm1STlpYUm9iMlJEWVd4c1BIUjVjR1Z2WmlCWFpXNVFZV1JUWVd4bExuQnliM1J2ZEhsd1pTNWtaV3hsZEdWQmNIQnNhV05oZEdsdmJqNG9ld29KTHk4Z0lDQWdJQ0FnWVhCd2JHbGpZWFJwYjI1SlJEb2dZWEJ3TEFvSkx5OGdJQ0FnSUNBZ2IyNURiMjF3YkdWMGFXOXVPaUJQYmtOdmJYQnNaWFJwYjI0dVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0c0Nna3ZMeUFnSUNBZ0lDQm1aV1U2SURBc0Nna3ZMeUFnSUNBZ2ZTa0tDV2wwZUc1ZlltVm5hVzRLQ1dsdWRHTWdOQ0F2THlBZ1lYQndiQW9KYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvSmNIVnphR0o1ZEdWeklEQjRNalE0TjJNek1tTWdMeThnYldWMGFHOWtJQ0prWld4bGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSUtDV2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDZ29KTHk4Z1kyOXVkSEpoWTNSelhGZGxibEJoWkZOaGJHVXVZV3huYnk1MGN6bzVORE1LQ1M4dklHRndjR3hwWTJGMGFXOXVTVVE2SUdGd2NBb0pabkpoYldWZlpHbG5JREVnTHk4Z1lYQndPaUIxYVc1ME5qUUtDV2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb0tDUzh2SUdOdmJuUnlZV04wYzF4WFpXNVFZV1JUWVd4bExtRnNaMjh1ZEhNNk9UUTBDZ2t2THlCdmJrTnZiWEJzWlhScGIyNDZJRTl1UTI5dGNHeGxkR2x2Ymk1RVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmdvSmNIVnphR2x1ZENBMUlDOHZJRVJsYkdWMFpVRndjR3hwWTJGMGFXOXVDZ2xwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb0tDUzh2SUdOdmJuUnlZV04wYzF4WFpXNVFZV1JUWVd4bExtRnNaMjh1ZEhNNk9UUTFDZ2t2THlCbVpXVTZJREFLQ1dsdWRHTWdNU0F2THlBd0NnbHBkSGh1WDJacFpXeGtJRVpsWlFvS0NTOHZJRk4xWW0xcGRDQnBibTVsY2lCMGNtRnVjMkZqZEdsdmJnb0phWFI0Ymw5emRXSnRhWFFLQ2drdkx5QmpiMjUwY21GamRITmNWMlZ1VUdGa1UyRnNaUzVoYkdkdkxuUnpPamswT0FvSkx5OGdkR2hwY3k1ellXeGxjeWh6WVd4bFNXUXBMbVJsYkdWMFpTZ3BDZ2xpZVhSbFl5QXhJQzh2SUNBaWN5SUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QnpZV3hsU1dRNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5dVkyRjBDZ2xpYjNoZlpHVnNDZ29KTHk4Z1kyOXVkSEpoWTNSelhGZGxibEJoWkZOaGJHVXVZV3huYnk1MGN6bzVORGtLQ1M4dklIUm9hWE11YldWMFlXUmhkR0VvYzJGc1pVbGtLUzVrWld4bGRHVW9LUW9KWW5sMFpXTWdNeUF2THlBZ0ltMGlDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdjMkZzWlVsa09pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KWW05NFgyUmxiQW9LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZPVFV3Q2drdkx5QjBhR2x6TG1OeVpXRjBiM0pUWVd4bGN5aGpiMjVqWVhRb1lXUnRhVzRzSUdsMGIySW9jMkZzWlVsa0tTa3BMbVJsYkdWMFpTZ3BDZ2xpZVhSbFl5QXhNQ0F2THlBZ0ltTWlDZ2xtY21GdFpWOWthV2NnTUNBdkx5QmhaRzFwYmpvZ1lXUmtjbVZ6Y3dvSlpuSmhiV1ZmWkdsbklDMHhJQzh2SUhOaGJHVkpaRG9nZFdsdWREWTBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NXTnZibU5oZEFvSlltOTRYMlJsYkFvS0NTOHZJR052Ym5SeVlXTjBjMXhYWlc1UVlXUlRZV3hsTG1Gc1oyOHVkSE02T1RVeENna3ZMeUIwYUdsekxuUnZkR0ZzVTJGc1pYTXVkbUZzZFdVZ1BTQjBhR2x6TG5SdmRHRnNVMkZzWlhNdWRtRnNkV1VnTFNBeENnbGllWFJsWXlBeUlDOHZJQ0FpZEc5MFlXeGZjMkZzWlhNaUNnbGtkWEFLQ1dGd2NGOW5iRzlpWVd4ZloyVjBDZ2xwYm5SaklEQWdMeThnTVFvSkxRb0pZWEJ3WDJkc2IySmhiRjl3ZFhRS0Nna3ZMeUJqYjI1MGNtRmpkSE5jVjJWdVVHRmtVMkZzWlM1aGJHZHZMblJ6T2prMU5Bb0pMeThnYzJWdVpGQmhlVzFsYm5Rb2V5QnlaV05sYVhabGNqb2daR2x6ZEhKcFluVjBhVzl1TENCaGJXOTFiblE2SUhCeVpVMWljaUF0SUhSb2FYTXVZWEJ3TG1Ga1pISmxjM011YldsdVFtRnNZVzVqWlN3Z1ptVmxPaUF3SUgwcENnbHBkSGh1WDJKbFoybHVDZ2xwYm5SaklEQWdMeThnSUhCaGVRb0phWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZPVFUwQ2drdkx5QnlaV05sYVhabGNqb2daR2x6ZEhKcFluVjBhVzl1Q2dsbWNtRnRaVjlrYVdjZ01pQXZMeUJrYVhOMGNtbGlkWFJwYjI0NklHRmtaSEpsYzNNS0NXbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtDZ2t2THlCamIyNTBjbUZqZEhOY1YyVnVVR0ZrVTJGc1pTNWhiR2R2TG5Sek9qazFOQW9KTHk4Z1lXMXZkVzUwT2lCd2NtVk5ZbklnTFNCMGFHbHpMbUZ3Y0M1aFpHUnlaWE56TG0xcGJrSmhiR0Z1WTJVS0NXWnlZVzFsWDJScFp5QXpJQzh2SUhCeVpVMWljam9nZFdsdWREWTBDZ2xuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b0pZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JOYVc1Q1lXeGhibU5sQ2dsd2IzQUtDUzBLQ1dsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRmRsYmxCaFpGTmhiR1V1WVd4bmJ5NTBjem81TlRRS0NTOHZJR1psWlRvZ01Bb0phVzUwWXlBeElDOHZJREFLQ1dsMGVHNWZabWxsYkdRZ1JtVmxDZ29KTHk4Z1UzVmliV2wwSUdsdWJtVnlJSFJ5WVc1ellXTjBhVzl1Q2dscGRIaHVYM04xWW0xcGRBb0tDUzh2SUdOdmJuUnlZV04wYzF4WFpXNVFZV1JUWVd4bExtRnNaMjh1ZEhNNk9UVTJDZ2t2THlCMGFHbHpMbE5oYkdWRVpXeGxkR1ZrTG14dlp5aDdJSE5oYkdWSlpEb2djMkZzWlVsa0lIMHBDZ2x3ZFhOb1lubDBaWE1nTUhoalpEZzJZV1pqTlNBdkx5QlRZV3hsUkdWc1pYUmxaQ2gxYVc1ME5qUXBDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdjMkZzWlVsa09pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KYkc5bkNnbHlaWFJ6ZFdJS0NpOHZJR2RsZEZOaGJHVW9kV2x1ZERZMEtTaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNrS0ttRmlhVjl5YjNWMFpWOW5aWFJUWVd4bE9nb0pMeThnVkdobElFRkNTU0J5WlhSMWNtNGdjSEpsWm1sNENnbGllWFJsWXlBM0lDOHZJREI0TVRVeFpqZGpOelVLQ2drdkx5QnpZV3hsU1dRNklIVnBiblEyTkFvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9KWW5SdmFRb0tDUzh2SUdWNFpXTjFkR1VnWjJWMFUyRnNaU2gxYVc1ME5qUXBLSFZwYm5RMk5DeGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtRb0pZMkZzYkhOMVlpQm5aWFJUWVd4bENnbGpiMjVqWVhRS0NXeHZad29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdaMlYwVTJGc1pTaHpZV3hsU1dRNklIVnBiblEyTkNrNklGTmhiR1ZTWldOdmNtUUtaMlYwVTJGc1pUb0tDWEJ5YjNSdklERWdNUW9LQ1M4dklHTnZiblJ5WVdOMGMxeFhaVzVRWVdSVFlXeGxMbUZzWjI4dWRITTZPVFkxQ2drdkx5QnlaWFIxY200Z2RHaHBjeTV6WVd4bGN5aHpZV3hsU1dRcExuWmhiSFZsT3dvSllubDBaV01nTVNBdkx5QWdJbk1pQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnYzJGc1pVbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXTnZibU5oZEFvSlltOTRYMmRsZEFvS0NTOHZJR0p2ZUNCMllXeDFaU0JrYjJWeklHNXZkQ0JsZUdsemREb2dkR2hwY3k1ellXeGxjeWh6WVd4bFNXUXBMblpoYkhWbENnbGhjM05sY25RS0NYSmxkSE4xWWdvS0x5OGdaMlYwVTJGc1pVMWxkR0ZrWVhSaEtIVnBiblEyTkNrb2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bktRb3FZV0pwWDNKdmRYUmxYMmRsZEZOaGJHVk5aWFJoWkdGMFlUb0tDUzh2SUZSb1pTQkJRa2tnY21WMGRYSnVJSEJ5WldacGVBb0pZbmwwWldNZ055QXZMeUF3ZURFMU1XWTNZemMxQ2dvSkx5OGdjMkZzWlVsa09pQjFhVzUwTmpRS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLQ1dKMGIya0tDZ2t2THlCbGVHVmpkWFJsSUdkbGRGTmhiR1ZOWlhSaFpHRjBZU2gxYVc1ME5qUXBLSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeWtLQ1dOaGJHeHpkV0lnWjJWMFUyRnNaVTFsZEdGa1lYUmhDZ2xqYjI1allYUUtDV3h2WndvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnWjJWMFUyRnNaVTFsZEdGa1lYUmhLSE5oYkdWSlpEb2dkV2x1ZERZMEtUb2dVMkZzWlUxbGRHRmtZWFJoQ21kbGRGTmhiR1ZOWlhSaFpHRjBZVG9LQ1hCeWIzUnZJREVnTVFvS0NTOHZJR052Ym5SeVlXTjBjMXhYWlc1UVlXUlRZV3hsTG1Gc1oyOHVkSE02T1Rjd0Nna3ZMeUJ5WlhSMWNtNGdkR2hwY3k1dFpYUmhaR0YwWVNoellXeGxTV1FwTG5aaGJIVmxPd29KWW5sMFpXTWdNeUF2THlBZ0ltMGlDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdjMkZzWlVsa09pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KWW05NFgyZGxkQW9LQ1M4dklHSnZlQ0IyWVd4MVpTQmtiMlZ6SUc1dmRDQmxlR2x6ZERvZ2RHaHBjeTV0WlhSaFpHRjBZU2h6WVd4bFNXUXBMblpoYkhWbENnbGhjM05sY25RS0NYSmxkSE4xWWdvS0x5OGdZWE56WlhKMFEyRnNiR1Z5U1hOVFlXeGxLSE5oYkdWSlpEb2dkV2x1ZERZMEtUb2dkbTlwWkFvdkx3b3ZMeUJCZFhSb1pXNTBhV05oZEdVZ1lTQnpZV3hsSUdGd2NDQmpZV3hzWW1GamF6b2dkR2hsSUdOaGJHeGxjaUJ0ZFhOMElHSmxJSFJvWlNCaGNIQWdjbVZqYjNKa1pXUWdabTl5SUdCellXeGxTV1JnTGdwaGMzTmxjblJEWVd4c1pYSkpjMU5oYkdVNkNnbHdjbTkwYnlBeElEQUtDZ2t2THlCamIyNTBjbUZqZEhOY1YyVnVVR0ZrVTJGc1pTNWhiR2R2TG5Sek9qazNOUW9KTHk4Z1lYTnpaWEowS0hSb2FYTXVjMkZzWlhNb2MyRnNaVWxrS1M1bGVHbHpkSE1wQ2dsaWVYUmxZeUF4SUM4dklDQWljeUlLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJ6WVd4bFNXUTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlkyOXVZMkYwQ2dsaWIzaGZiR1Z1Q2dsemQyRndDZ2x3YjNBS0NXRnpjMlZ5ZEFvS0NTOHZJR052Ym5SeVlXTjBjMXhYWlc1UVlXUlRZV3hsTG1Gc1oyOHVkSE02T1RjMkNna3ZMeUJoYzNObGNuUW9kR2hwY3k1ellXeGxjeWh6WVd4bFNXUXBMblpoYkhWbExtRndjQ0E5UFQwZ1oyeHZZbUZzY3k1allXeHNaWEpCY0hCc2FXTmhkR2x2YmtsRUtRb0phVzUwWXlBeElDOHZJREFLQ1dsdWRHTWdNaUF2THlBNENnbGllWFJsWXlBeElDOHZJQ0FpY3lJS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCellXeGxTV1E2SUhWcGJuUTJOQW9KYVhSdllnb0pZMjl1WTJGMENnbGpiM1psY2lBeUNnbGliM2hmWlhoMGNtRmpkQW9KWW5SdmFRb0paMnh2WW1Gc0lFTmhiR3hsY2tGd2NHeHBZMkYwYVc5dVNVUUtDVDA5Q2dsaGMzTmxjblFLQ1hKbGRITjFZZ29LS21OeVpXRjBaVjlPYjA5d09nb0pjSFZ6YUdKNWRHVnpJREI0T1RjellqWXhObVlnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmloMWFXNTBOalFwZG05cFpDSUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0NXMWhkR05vSUNwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0S0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kzSmxZWFJsSUU1dlQzQUtDV1Z5Y2dvS0ttTmhiR3hmVG05UGNEb0tDWEIxYzJoaWVYUmxjeUF3ZURFd1lUQmxaak0wSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsVTJGc1pTaHdZWGtzWVdSa2NtVnpjeXhpZVhSbFcxMHNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BkV2x1ZERZMElnb0pjSFZ6YUdKNWRHVnpJREI0TWpjMk5tTTRaVElnTHk4Z2JXVjBhRzlrSUNKemVXNWpVMkZzWlNoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lnb0pjSFZ6YUdKNWRHVnpJREI0WkRVd01EVTRObU1nTHk4Z2JXVjBhRzlrSUNKc2IyZFFkWEpqYUdGelpTaDFhVzUwTmpRc2RXbHVkRFkwTEdGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lLQ1hCMWMyaGllWFJsY3lBd2VESmxZelV5Wm1Wa0lDOHZJRzFsZEdodlpDQWlkWEJrWVhSbFRXVjBZV1JoZEdFb2NHRjVMSFZwYm5RMk5DeHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BkbTlwWkNJS0NYQjFjMmhpZVhSbGN5QXdlRFF5TW1RMFl6QmhJQzh2SUcxbGRHaHZaQ0FpWkdWc1pYUmxVMkZzWlNoMWFXNTBOalFwZG05cFpDSUtDWEIxYzJoaWVYUmxjeUF3ZURCbU9EZGxZamhtSUM4dklHMWxkR2h2WkNBaVoyVjBVMkZzWlNoMWFXNTBOalFwS0hWcGJuUTJOQ3hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lLQ1hCMWMyaGllWFJsY3lBd2VESTBOVFF4WmpOaklDOHZJRzFsZEdodlpDQWlaMlYwVTJGc1pVMWxkR0ZrWVhSaEtIVnBiblEyTkNrb2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bktTSUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0NXMWhkR05vSUNwaFltbGZjbTkxZEdWZlkzSmxZWFJsVTJGc1pTQXFZV0pwWDNKdmRYUmxYM041Ym1OVFlXeGxJQ3BoWW1sZmNtOTFkR1ZmYkc5blVIVnlZMmhoYzJVZ0ttRmlhVjl5YjNWMFpWOTFjR1JoZEdWTlpYUmhaR0YwWVNBcVlXSnBYM0p2ZFhSbFgyUmxiR1YwWlZOaGJHVWdLbUZpYVY5eWIzVjBaVjluWlhSVFlXeGxJQ3BoWW1sZmNtOTFkR1ZmWjJWMFUyRnNaVTFsZEdGa1lYUmhDZ29KTHk4Z2RHaHBjeUJqYjI1MGNtRmpkQ0JrYjJWeklHNXZkQ0JwYlhCc1pXMWxiblFnZEdobElHZHBkbVZ1SUVGQ1NTQnRaWFJvYjJRZ1ptOXlJR05oYkd3Z1RtOVBjQW9KWlhKeUNnb3FjSEp2WTJWemMxOWtlVzVoYldsalgzUjFjR3hsWDJWc1pXMWxiblE2Q2dsd2NtOTBieUEwSURNS0NXWnlZVzFsWDJScFp5QXROQ0F2THlCMGRYQnNaU0JvWldGa0NnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z2FHVmhaQ0J2Wm1aelpYUUtDV052Ym1OaGRBb0pabkpoYldWZlluVnllU0F0TkNBdkx5QjBkWEJzWlNCb1pXRmtDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdaV3hsYldWdWRBb0paSFZ3Q2dsc1pXNEtDV1p5WVcxbFgyUnBaeUF0TWlBdkx5Qm9aV0ZrSUc5bVpuTmxkQW9KWW5SdmFRb0pLd29KYVhSdllnb0paWGgwY21GamRDQTJJRElLQ1daeVlXMWxYMkoxY25rZ0xUSWdMeThnYUdWaFpDQnZabVp6WlhRS0NXWnlZVzFsWDJScFp5QXRNeUF2THlCMGRYQnNaU0IwWVdsc0NnbHpkMkZ3Q2dsamIyNWpZWFFLQ1daeVlXMWxYMkoxY25rZ0xUTWdMeThnZEhWd2JHVWdkR0ZwYkFvSlpuSmhiV1ZmWkdsbklDMDBJQzh2SUhSMWNHeGxJR2hsWVdRS0NXWnlZVzFsWDJScFp5QXRNeUF2THlCMGRYQnNaU0IwWVdsc0NnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z2FHVmhaQ0J2Wm1aelpYUUtDWEpsZEhOMVlnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6bnVsbCwiY29tcGlsZXJJbmZvIjpudWxsLCJldmVudHMiOlt7Im5hbWUiOiJTYWxlQ3JlYXRlZCIsImRlc2MiOiIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FsZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRpc3RyaWJ1dGlvbiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU2FsZVN5bmNlZCIsImRlc2MiOiIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FsZUlkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhdHVzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxJdGVtcyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNvbGQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlB1cmNoYXNlIiwiZGVzYyI6IiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzYWxlSWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJidXllciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJNZXRhZGF0YVVwZGF0ZWQiLCJkZXNjIjoiIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNhbGVJZCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU2FsZURlbGV0ZWQiLCJkZXNjIjoiIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNhbGVJZCIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
