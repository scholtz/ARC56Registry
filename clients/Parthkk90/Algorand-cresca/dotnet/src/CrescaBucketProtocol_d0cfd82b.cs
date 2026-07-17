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

namespace Arc56.Generated.Parthkk90.Algorand_cresca.CrescaBucketProtocol_d0cfd82b
{


    //
    // 
    //    Leveraged basket trading protocol on Algorand.
    //
    //    State:
    //    - Global: total_positions, total_buckets, oracle_updated_at
    //    - Boxes:  Bucket, Position, PriceData per entry
    //    
    //
    public class CrescaBucketProtocolProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CrescaBucketProtocolProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Bucket : AVMObjectType
            {
                public ulong Asset0 { get; set; }

                public ulong Asset1 { get; set; }

                public ulong Asset2 { get; set; }

                public ulong Asset3 { get; set; }

                public ulong Asset4 { get; set; }

                public ulong Asset5 { get; set; }

                public ulong Asset6 { get; set; }

                public ulong Asset7 { get; set; }

                public ulong Weight0 { get; set; }

                public ulong Weight1 { get; set; }

                public ulong Weight2 { get; set; }

                public ulong Weight3 { get; set; }

                public ulong Weight4 { get; set; }

                public ulong Weight5 { get; set; }

                public ulong Weight6 { get; set; }

                public ulong Weight7 { get; set; }

                public ulong AssetCount { get; set; }

                public ulong Leverage { get; set; }

                public Algorand.Address Owner { get; set; }

                public bool Exists { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset0.From(Asset0);
                    ret.AddRange(vAsset0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset1.From(Asset1);
                    ret.AddRange(vAsset1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset2.From(Asset2);
                    ret.AddRange(vAsset2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset3.From(Asset3);
                    ret.AddRange(vAsset3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset4.From(Asset4);
                    ret.AddRange(vAsset4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset5.From(Asset5);
                    ret.AddRange(vAsset5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset6.From(Asset6);
                    ret.AddRange(vAsset6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset7.From(Asset7);
                    ret.AddRange(vAsset7.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWeight0.From(Weight0);
                    ret.AddRange(vWeight0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWeight1.From(Weight1);
                    ret.AddRange(vWeight1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWeight2.From(Weight2);
                    ret.AddRange(vWeight2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWeight3.From(Weight3);
                    ret.AddRange(vWeight3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWeight4.From(Weight4);
                    ret.AddRange(vWeight4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWeight5.From(Weight5);
                    ret.AddRange(vWeight5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWeight6.From(Weight6);
                    ret.AddRange(vWeight6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWeight7.From(Weight7);
                    ret.AddRange(vWeight7.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetCount.From(AssetCount);
                    ret.AddRange(vAssetCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLeverage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLeverage.From(Leverage);
                    ret.AddRange(vLeverage.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vExists.From(Exists);
                    ret.AddRange(vExists.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Bucket Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Bucket();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset0 = vAsset0.ToValue();
                    if (valueAsset0 is ulong vAsset0Value) { ret.Asset0 = vAsset0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset1 = vAsset1.ToValue();
                    if (valueAsset1 is ulong vAsset1Value) { ret.Asset1 = vAsset1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset2 = vAsset2.ToValue();
                    if (valueAsset2 is ulong vAsset2Value) { ret.Asset2 = vAsset2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset3 = vAsset3.ToValue();
                    if (valueAsset3 is ulong vAsset3Value) { ret.Asset3 = vAsset3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset4 = vAsset4.ToValue();
                    if (valueAsset4 is ulong vAsset4Value) { ret.Asset4 = vAsset4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset5 = vAsset5.ToValue();
                    if (valueAsset5 is ulong vAsset5Value) { ret.Asset5 = vAsset5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset6 = vAsset6.ToValue();
                    if (valueAsset6 is ulong vAsset6Value) { ret.Asset6 = vAsset6Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset7 = vAsset7.ToValue();
                    if (valueAsset7 is ulong vAsset7Value) { ret.Asset7 = vAsset7Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWeight0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeight0 = vWeight0.ToValue();
                    if (valueWeight0 is ulong vWeight0Value) { ret.Weight0 = vWeight0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWeight1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeight1 = vWeight1.ToValue();
                    if (valueWeight1 is ulong vWeight1Value) { ret.Weight1 = vWeight1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWeight2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeight2 = vWeight2.ToValue();
                    if (valueWeight2 is ulong vWeight2Value) { ret.Weight2 = vWeight2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWeight3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeight3 = vWeight3.ToValue();
                    if (valueWeight3 is ulong vWeight3Value) { ret.Weight3 = vWeight3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWeight4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeight4 = vWeight4.ToValue();
                    if (valueWeight4 is ulong vWeight4Value) { ret.Weight4 = vWeight4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWeight5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeight5 = vWeight5.ToValue();
                    if (valueWeight5 is ulong vWeight5Value) { ret.Weight5 = vWeight5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWeight6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeight6 = vWeight6.ToValue();
                    if (valueWeight6 is ulong vWeight6Value) { ret.Weight6 = vWeight6Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWeight7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeight7 = vWeight7.ToValue();
                    if (valueWeight7 is ulong vWeight7Value) { ret.Weight7 = vWeight7Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetCount = vAssetCount.ToValue();
                    if (valueAssetCount is ulong vAssetCountValue) { ret.AssetCount = vAssetCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLeverage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLeverage.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLeverage = vLeverage.ToValue();
                    if (valueLeverage is ulong vLeverageValue) { ret.Leverage = vLeverageValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vExists.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExists = vExists.ToValue();
                    if (valueExists is bool vExistsValue) { ret.Exists = vExistsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Bucket);
                }
                public bool Equals(Bucket? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Bucket left, Bucket right)
                {
                    return EqualityComparer<Bucket>.Default.Equals(left, right);
                }
                public static bool operator !=(Bucket left, Bucket right)
                {
                    return !(left == right);
                }

            }

            public class Position : AVMObjectType
            {
                public ulong BucketId { get; set; }

                public bool IsLong { get; set; }

                public ulong Margin { get; set; }

                public ulong EntryPrice { get; set; }

                public Algorand.Address Owner { get; set; }

                public bool Active { get; set; }

                public ulong OpenTimestamp { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBucketId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBucketId.From(BucketId);
                    ret.AddRange(vBucketId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsLong = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsLong.From(IsLong);
                    ret.AddRange(vIsLong.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMargin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMargin.From(Margin);
                    ret.AddRange(vMargin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEntryPrice.From(EntryPrice);
                    ret.AddRange(vEntryPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vActive.From(Active);
                    ret.AddRange(vActive.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOpenTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOpenTimestamp.From(OpenTimestamp);
                    ret.AddRange(vOpenTimestamp.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBucketId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBucketId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBucketId = vBucketId.ToValue();
                    if (valueBucketId is ulong vBucketIdValue) { ret.BucketId = vBucketIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsLong = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsLong.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsLong = vIsLong.ToValue();
                    if (valueIsLong is bool vIsLongValue) { ret.IsLong = vIsLongValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMargin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMargin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMargin = vMargin.ToValue();
                    if (valueMargin is ulong vMarginValue) { ret.Margin = vMarginValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEntryPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEntryPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEntryPrice = vEntryPrice.ToValue();
                    if (valueEntryPrice is ulong vEntryPriceValue) { ret.EntryPrice = vEntryPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActive = vActive.ToValue();
                    if (valueActive is bool vActiveValue) { ret.Active = vActiveValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOpenTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOpenTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOpenTimestamp = vOpenTimestamp.ToValue();
                    if (valueOpenTimestamp is ulong vOpenTimestampValue) { ret.OpenTimestamp = vOpenTimestampValue; }
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

            public class PriceData : AVMObjectType
            {
                public ulong Price { get; set; }

                public ulong Timestamp { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrice.From(Price);
                    ret.AddRange(vPrice.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PriceData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PriceData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrice = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrice.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrice = vPrice.ToValue();
                    if (valuePrice is ulong vPriceValue) { ret.Price = vPriceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PriceData);
                }
                public bool Equals(PriceData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PriceData left, PriceData right)
                {
                    return EqualityComparer<PriceData>.Default.Equals(left, right);
                }
                public static bool operator !=(PriceData left, PriceData right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class BucketCreatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 111, 74, 141, 131 };
                public const string Signature = "BucketCreated(uint64,address,uint64[],uint64[],uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }
                public ulong[] Field3 { get; set; }
                public ulong[] Field4 { get; set; }
                public ulong Field5 { get; set; }

                public static BucketCreatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new BucketCreatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong[] vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong[] vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
                    return ret;

                }

            }

            public class CollateralDepositedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 10, 191, 46, 48 };
                public const string Signature = "CollateralDeposited(address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public ulong Field2 { get; set; }

                public static CollateralDepositedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CollateralDepositedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

            }

            public class CollateralWithdrawnEvent
            {
                public static readonly byte[] Selector = new byte[4] { 165, 52, 232, 198 };
                public const string Signature = "CollateralWithdrawn(address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public ulong Field2 { get; set; }

                public static CollateralWithdrawnEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CollateralWithdrawnEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

            }

            public class PositionOpenedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 133, 254, 104, 128 };
                public const string Signature = "PositionOpened(uint64,uint64,address,bool,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public ulong Field2 { get; set; }
                public Algorand.Address Field3 { get; set; }
                public bool Field4 { get; set; }
                public ulong Field5 { get; set; }
                public ulong Field6 { get; set; }

                public static PositionOpenedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PositionOpenedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is Algorand.Address vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is bool vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is ulong vField6Value) { ret.Field6 = vField6Value; }
                    return ret;

                }

            }

            public class PositionClosedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 148, 54, 102, 163 };
                public const string Signature = "PositionClosed(uint64,address,uint64,bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }
                public ulong Field3 { get; set; }
                public bool Field4 { get; set; }

                public static PositionClosedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PositionClosedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is bool vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

            }

            public class BucketRebalancedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 187, 236, 182, 215 };
                public const string Signature = "BucketRebalanced(uint64,uint64[])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public ulong[] Field2 { get; set; }

                public static BucketRebalancedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new BucketRebalancedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong[] vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

            }

            public class OracleUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 6, 26, 235, 37 };
                public const string Signature = "OracleUpdated(uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public ulong Field2 { get; set; }

                public static OracleUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new OracleUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
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

            }

            public class LiquidationEvent
            {
                public static readonly byte[] Selector = new byte[4] { 181, 201, 209, 60 };
                public const string Signature = "Liquidation(uint64,address,byte[])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }
                public byte[] Field3 { get; set; }

                public static LiquidationEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new LiquidationEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is byte[] vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Create a custom asset basket.
        ///assets  — up to 8 Algorand ASA IDs (use 0 for ALGO itself) weights — percentage allocation per asset (must sum to 100) leverage — 1 to 150
        ///</summary>
        /// <param name="assets"> </param>
        /// <param name="weights"> </param>
        /// <param name="leverage"> </param>
        public async Task<ulong> CreateBucket(ulong[] assets, ulong[] weights, ulong leverage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 145, 156, 10 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);
            var weightsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); weightsAbi.From(weights);
            var leverageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); leverageAbi.From(leverage);

            var result = await base.CallApp(new List<object> { abiHandle, assetsAbi, weightsAbi, leverageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateBucket_Transactions(ulong[] assets, ulong[] weights, ulong leverage, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 145, 156, 10 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);
            var weightsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); weightsAbi.From(weights);
            var leverageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); leverageAbi.From(leverage);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi, weightsAbi, leverageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deposit ALGO as collateral for trading.
        ///Attach a PaymentTransaction to this contract in the same group.
        ///</summary>
        /// <param name="payment_txn"> </param>
        public async Task<bool> DepositCollateral(PaymentTransaction payment_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 23, 18, 174, 116 };

            var result = await base.CallApp(new List<object> { abiHandle, payment_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DepositCollateral_Transactions(PaymentTransaction payment_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 23, 18, 174, 116 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw ALGO collateral back to sender.
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<bool> WithdrawCollateral(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 222, 66, 220 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> WithdrawCollateral_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 222, 66, 220 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Open a leveraged long or short position on a bucket.
        ///bucket_id — ID of the bucket owned by Txn.sender is_long   — True = long, False = short margin    — μALGO to lock from collateral balance
        ///</summary>
        /// <param name="bucket_id"> </param>
        /// <param name="is_long"> </param>
        /// <param name="margin"> </param>
        public async Task<ulong> OpenPosition(ulong bucket_id, bool is_long, ulong margin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 37, 73, 220 };
            var bucket_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bucket_idAbi.From(bucket_id);
            var is_longAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_longAbi.From(is_long);
            var marginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); marginAbi.From(margin);

            var result = await base.CallApp(new List<object> { abiHandle, bucket_idAbi, is_longAbi, marginAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> OpenPosition_Transactions(ulong bucket_id, bool is_long, ulong margin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 37, 73, 220 };
            var bucket_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bucket_idAbi.From(bucket_id);
            var is_longAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_longAbi.From(is_long);
            var marginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); marginAbi.From(margin);

            return await base.MakeTransactionList(new List<object> { abiHandle, bucket_idAbi, is_longAbi, marginAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Close a position and realise P&L back into the collateral balance.
        ///Returns absolute P&L in μALGO.
        ///</summary>
        /// <param name="position_id"> </param>
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
        ///Update the weight allocation of an existing bucket (owner only).
        ///</summary>
        /// <param name="bucket_id"> </param>
        /// <param name="new_weights"> </param>
        public async Task<bool> RebalanceBucket(ulong bucket_id, ulong[] new_weights, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 34, 205, 223 };
            var bucket_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bucket_idAbi.From(bucket_id);
            var new_weightsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); new_weightsAbi.From(new_weights);

            var result = await base.CallApp(new List<object> { abiHandle, bucket_idAbi, new_weightsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RebalanceBucket_Transactions(ulong bucket_id, ulong[] new_weights, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 34, 205, 223 };
            var bucket_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bucket_idAbi.From(bucket_id);
            var new_weightsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); new_weightsAbi.From(new_weights);

            return await base.MakeTransactionList(new List<object> { abiHandle, bucket_idAbi, new_weightsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update mock oracle prices. In production, consume a Pyth price feed
        ///via a Pyth Algorand oracle contract instead.
        ///Prices must use 8-decimal precision (e.g. 1 ALGO = 100_000_000).
        ///</summary>
        /// <param name="asset_ids"> </param>
        /// <param name="asset_prices"> </param>
        public async Task<bool> UpdateOracle(ulong[] asset_ids, ulong[] asset_prices, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 31, 158, 196, 186 };
            var asset_idsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); asset_idsAbi.From(asset_ids);
            var asset_pricesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); asset_pricesAbi.From(asset_prices);

            var result = await base.CallApp(new List<object> { abiHandle, asset_idsAbi, asset_pricesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> UpdateOracle_Transactions(ulong[] asset_ids, ulong[] asset_prices, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 31, 158, 196, 186 };
            var asset_idsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); asset_idsAbi.From(asset_ids);
            var asset_pricesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); asset_pricesAbi.From(asset_prices);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idsAbi, asset_pricesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Liquidate an undercollateralised position.
        ///Anyone may call this (keeper/bot pattern — same as Solidity version).
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="position_id"> </param>
        public async Task<bool> LiquidatePosition(Algorand.Address owner, ulong position_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 12, 115, 157 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi, position_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> LiquidatePosition_Transactions(Algorand.Address owner, ulong position_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 12, 115, 157 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, position_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        public async Task<ulong> GetCollateralBalance(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 61, 243, 88 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCollateralBalance_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 61, 243, 88 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="position_id"> </param>
        public async Task<ulong> GetUnrealizedPnl(Algorand.Address owner, ulong position_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 122, 193, 182 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi, position_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetUnrealizedPnl_Transactions(Algorand.Address owner, ulong position_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 122, 193, 182 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var position_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); position_idAbi.From(position_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, position_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns Unix timestamp of the last oracle update (0 if never updated).
        ///</summary>
        public async Task<ulong> GetOracleUpdatedAt(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 252, 63, 71 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetOracleUpdatedAt_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 252, 63, 71 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetTotalPositions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 79, 94, 116 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalPositions_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 79, 94, 116 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetTotalBuckets(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 114, 202, 132 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalBuckets_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 114, 202, 132 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Increase contract's minimum balance to cover Box storage costs.
        ///</summary>
        /// <param name="payment_txn"> </param>
        public async Task<bool> FundContract(PaymentTransaction payment_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 21, 100, 117, 168 };

            var result = await base.CallApp(new List<object> { abiHandle, payment_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FundContract_Transactions(PaymentTransaction payment_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 21, 100, 117, 168 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3Jlc2NhQnVja2V0UHJvdG9jb2wiLCJkZXNjIjoiXG4gICAgTGV2ZXJhZ2VkIGJhc2tldCB0cmFkaW5nIHByb3RvY29sIG9uIEFsZ29yYW5kLlxuXG4gICAgU3RhdGU6XG4gICAgLSBHbG9iYWw6IHRvdGFsX3Bvc2l0aW9ucywgdG90YWxfYnVja2V0cywgb3JhY2xlX3VwZGF0ZWRfYXRcbiAgICAtIEJveGVzOiAgQnVja2V0LCBQb3NpdGlvbiwgUHJpY2VEYXRhIHBlciBlbnRyeVxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJCdWNrZXQiOlt7Im5hbWUiOiJhc3NldDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXNzZXQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFzc2V0MiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhc3NldDMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXNzZXQ0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFzc2V0NSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhc3NldDYiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXNzZXQ3IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6IndlaWdodDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoid2VpZ2h0MSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ3ZWlnaHQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6IndlaWdodDMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoid2VpZ2h0NCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ3ZWlnaHQ1IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6IndlaWdodDYiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoid2VpZ2h0NyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhc3NldF9jb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsZXZlcmFnZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZXhpc3RzIiwidHlwZSI6ImJvb2wifV0sIlBvc2l0aW9uIjpbeyJuYW1lIjoiYnVja2V0X2lkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImlzX2xvbmciLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6Im1hcmdpbiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlbnRyeV9wcmljZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYWN0aXZlIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJvcGVuX3RpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifV0sIlByaWNlRGF0YSI6W3sibmFtZSI6InByaWNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX2J1Y2tldCIsImRlc2MiOiJDcmVhdGUgYSBjdXN0b20gYXNzZXQgYmFza2V0LlxuYXNzZXRzICDigJQgdXAgdG8gOCBBbGdvcmFuZCBBU0EgSURzICh1c2UgMCBmb3IgQUxHTyBpdHNlbGYpIHdlaWdodHMg4oCUIHBlcmNlbnRhZ2UgYWxsb2NhdGlvbiBwZXIgYXNzZXQgKG11c3Qgc3VtIHRvIDEwMCkgbGV2ZXJhZ2Ug4oCUIDEgdG8gMTUwIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndlaWdodHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxldmVyYWdlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkJ1Y2tldENyZWF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXBvc2l0X2NvbGxhdGVyYWwiLCJkZXNjIjoiRGVwb3NpdCBBTEdPIGFzIGNvbGxhdGVyYWwgZm9yIHRyYWRpbmcuXG5BdHRhY2ggYSBQYXltZW50VHJhbnNhY3Rpb24gdG8gdGhpcyBjb250cmFjdCBpbiB0aGUgc2FtZSBncm91cC4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudF90eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNvbGxhdGVyYWxEZXBvc2l0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3X2NvbGxhdGVyYWwiLCJkZXNjIjoiV2l0aGRyYXcgQUxHTyBjb2xsYXRlcmFsIGJhY2sgdG8gc2VuZGVyLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNvbGxhdGVyYWxXaXRoZHJhd24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wZW5fcG9zaXRpb24iLCJkZXNjIjoiT3BlbiBhIGxldmVyYWdlZCBsb25nIG9yIHNob3J0IHBvc2l0aW9uIG9uIGEgYnVja2V0LlxuYnVja2V0X2lkIOKAlCBJRCBvZiB0aGUgYnVja2V0IG93bmVkIGJ5IFR4bi5zZW5kZXIgaXNfbG9uZyAgIOKAlCBUcnVlID0gbG9uZywgRmFsc2UgPSBzaG9ydCBtYXJnaW4gICAg4oCUIM68QUxHTyB0byBsb2NrIGZyb20gY29sbGF0ZXJhbCBiYWxhbmNlIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1Y2tldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlzX2xvbmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmdpbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJQb3NpdGlvbk9wZW5lZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsb3NlX3Bvc2l0aW9uIiwiZGVzYyI6IkNsb3NlIGEgcG9zaXRpb24gYW5kIHJlYWxpc2UgUCZMIGJhY2sgaW50byB0aGUgY29sbGF0ZXJhbCBiYWxhbmNlLlxuUmV0dXJucyBhYnNvbHV0ZSBQJkwgaW4gzrxBTEdPLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb3NpdGlvbl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJQb3NpdGlvbkNsb3NlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlYmFsYW5jZV9idWNrZXQiLCJkZXNjIjoiVXBkYXRlIHRoZSB3ZWlnaHQgYWxsb2NhdGlvbiBvZiBhbiBleGlzdGluZyBidWNrZXQgKG93bmVyIG9ubHkpLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJidWNrZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3dlaWdodHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkJ1Y2tldFJlYmFsYW5jZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfb3JhY2xlIiwiZGVzYyI6IlVwZGF0ZSBtb2NrIG9yYWNsZSBwcmljZXMuIEluIHByb2R1Y3Rpb24sIGNvbnN1bWUgYSBQeXRoIHByaWNlIGZlZWRcbnZpYSBhIFB5dGggQWxnb3JhbmQgb3JhY2xlIGNvbnRyYWN0IGluc3RlYWQuXG5QcmljZXMgbXVzdCB1c2UgOC1kZWNpbWFsIHByZWNpc2lvbiAoZS5nLiAxIEFMR08gPSAxMDBfMDAwXzAwMCkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfaWRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X3ByaWNlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiT3JhY2xlVXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsaXF1aWRhdGVfcG9zaXRpb24iLCJkZXNjIjoiTGlxdWlkYXRlIGFuIHVuZGVyY29sbGF0ZXJhbGlzZWQgcG9zaXRpb24uXG5BbnlvbmUgbWF5IGNhbGwgdGhpcyAoa2VlcGVyL2JvdCBwYXR0ZXJuIOKAlCBzYW1lIGFzIFNvbGlkaXR5IHZlcnNpb24pLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvc2l0aW9uX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJMaXF1aWRhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2NvbGxhdGVyYWxfYmFsYW5jZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3VucmVhbGl6ZWRfcG5sIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9zaXRpb25faWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9vcmFjbGVfdXBkYXRlZF9hdCIsImRlc2MiOiJSZXR1cm5zIFVuaXggdGltZXN0YW1wIG9mIHRoZSBsYXN0IG9yYWNsZSB1cGRhdGUgKDAgaWYgbmV2ZXIgdXBkYXRlZCkuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdG90YWxfcG9zaXRpb25zIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdG90YWxfYnVja2V0cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnVuZF9jb250cmFjdCIsImRlc2MiOiJJbmNyZWFzZSBjb250cmFjdCdzIG1pbmltdW0gYmFsYW5jZSB0byBjb3ZlciBCb3ggc3RvcmFnZSBjb3N0cy4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudF90eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4OTYsMjQ1NF0sImVycm9yTWVzc2FnZSI6IkFtb3VudCBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNzIsMTA4NywxNTMyXSwiZXJyb3JNZXNzYWdlIjoiQnVja2V0IG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk3OSwxMTE1XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IGNvbGxhdGVyYWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTUsMTk1MV0sImVycm9yTWVzc2FnZSI6Ikxlbmd0aCBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMF0sImVycm9yTWVzc2FnZSI6IkxldmVyYWdlIHRvbyBoaWdoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI1XSwiZXJyb3JNZXNzYWdlIjoiTGV2ZXJhZ2UgdG9vIGxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMl0sImVycm9yTWVzc2FnZSI6Ik1heCA4IGFzc2V0cyBwZXIgYnVja2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE4XSwiZXJyb3JNZXNzYWdlIjoiTXVzdCBoYXZlIGF0IGxlYXN0IDEgYXNzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4OTIsMjQ1MV0sImVycm9yTWVzc2FnZSI6Ik11c3QgcGF5IGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTY5LDExMDVdLCJlcnJvck1lc3NhZ2UiOiJObyBjb2xsYXRlcmFsIGJhbGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDk1LDE1NDhdLCJlcnJvck1lc3NhZ2UiOiJOb3QgeW91ciBidWNrZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjc1XSwiZXJyb3JNZXNzYWdlIjoiTm90IHlvdXIgcG9zaXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDUzLDEyMzAsMjA1Nl0sImVycm9yTWVzc2FnZSI6Ik9yYWNsZSBwcmljZSBzdGFsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNjcsMjA4N10sImVycm9yTWVzc2FnZSI6IlBvc2l0aW9uIGFscmVhZHkgY2xvc2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI1MiwyMDczXSwiZXJyb3JNZXNzYWdlIjoiUG9zaXRpb24gbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE1M10sImVycm9yTWVzc2FnZSI6IlBvc2l0aW9uIG5vdCBsaXF1aWRhdGFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTYwXSwiZXJyb3JNZXNzYWdlIjoiV2VpZ2h0IGNvdW50IG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcwLDE2MDBdLCJlcnJvck1lc3NhZ2UiOiJXZWlnaHRzIG11c3Qgc3VtIHRvIDEwMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYnVja2V0X2NvdW50cyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjkxLDIxMDAsMjM4NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYnVja2V0cyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MTQsMTQwOSwyMjkyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb2xsYXRlcmFsIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNDgsMTIyNSwyMDUxLDI0MDNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm9yYWNsZV91cGRhdGVkX2F0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzNTNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBvc2l0aW9ucyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTE1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wcmljZXMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzI2LDI0MjddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2J1Y2tldHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEyNywyNDE1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9wb3NpdGlvbnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk3NiwxOTg1XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjAsMjg1LDE0OTgsMTkxNywxOTM5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAzNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzYsMjk4LDE1MTEsMTkzMCwxOTQ5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDM0LDIyNzgsMjMxM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDksOTU3LDEwMjYsMTA0MiwxMjE5LDE0ODksMjA0NSwyMzIxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODg1LDI0NDRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnT0NBeUlEUTFOaUF4TXpZZ01UQXdNREF3TURBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1EQXdNREF3TURBd01EQXdNREF3TUNBd2VEQXdJREI0TVRVeFpqZGpOelVnSW05eVlXTnNaVjkxY0dSaGRHVmtYMkYwSWlBd2VEWXlObUkzTkRWbUlEQjRNVFV4Wmpkak56VTRNQ0F3ZURZek5tWTJZelZtSUNKMGIzUmhiRjl3YjNOcGRHbHZibk1pSUNKMGIzUmhiRjlpZFdOclpYUnpJaUF3ZURjd05tWTNNelZtSURCNE56QTNNall6TldZS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNVFV3Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNCdmMybDBhVzl1Y3lBOUlFZHNiMkpoYkZOMFlYUmxLRlZKYm5RMk5DZ3dLU2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblJ2ZEdGc1gzQnZjMmwwYVc5dWN5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRveE5URUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZZblZqYTJWMGN5QTlJRWRzYjJKaGJGTjBZWFJsS0ZWSmJuUTJOQ2d3S1NrS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5SdmRHRnNYMkoxWTJ0bGRITWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1UVXlDaUFnSUNBdkx5QnpaV3htTG05eVlXTnNaVjkxY0dSaGRHVmtYMkYwSUQwZ1IyeHZZbUZzVTNSaGRHVW9WVWx1ZERZMEtEQXBLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWliM0poWTJ4bFgzVndaR0YwWldSZllYUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG94TWpFS0lDQWdJQzh2SUdOc1lYTnpJRU55WlhOallVSjFZMnRsZEZCeWIzUnZZMjlzS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF5TXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WldZNU1UbGpNR0VnTUhneE56RXlZV1UzTkNBd2VETmpaR1UwTW1SaklEQjRObVV5TlRRNVpHTWdNSGc1TlRabE4yVTRaaUF3ZUdGa01qSmpaR1JtSURCNE1XWTVaV00wWW1FZ01IZzVOVEJqTnpNNVpDQXdlRFZqTTJSbU16VTRJREI0WlRRM1lXTXhZallnTUhoak4yWmpNMlkwTnlBd2VHVTNOR1kxWlRjMElEQjRaRFUzTW1OaE9EUWdNSGd4TlRZME56VmhPQ0F2THlCdFpYUm9iMlFnSW1OeVpXRjBaVjlpZFdOclpYUW9kV2x1ZERZMFcxMHNkV2x1ZERZMFcxMHNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVpHVndiM05wZEY5amIyeHNZWFJsY21Gc0tIQmhlU2xpYjI5c0lpd2diV1YwYUc5a0lDSjNhWFJvWkhKaGQxOWpiMnhzWVhSbGNtRnNLSFZwYm5RMk5DbGliMjlzSWl3Z2JXVjBhRzlrSUNKdmNHVnVYM0J2YzJsMGFXOXVLSFZwYm5RMk5DeGliMjlzTEhWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbU5zYjNObFgzQnZjMmwwYVc5dUtIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5KbFltRnNZVzVqWlY5aWRXTnJaWFFvZFdsdWREWTBMSFZwYm5RMk5GdGRLV0p2YjJ3aUxDQnRaWFJvYjJRZ0luVndaR0YwWlY5dmNtRmpiR1VvZFdsdWREWTBXMTBzZFdsdWREWTBXMTBwWW05dmJDSXNJRzFsZEdodlpDQWliR2x4ZFdsa1lYUmxYM0J2YzJsMGFXOXVLR0ZrWkhKbGMzTXNkV2x1ZERZMEtXSnZiMndpTENCdFpYUm9iMlFnSW1kbGRGOWpiMnhzWVhSbGNtRnNYMkpoYkdGdVkyVW9ZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjkxYm5KbFlXeHBlbVZrWDNCdWJDaGhaR1J5WlhOekxIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOXZjbUZqYkdWZmRYQmtZWFJsWkY5aGRDZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmZEc5MFlXeGZjRzl6YVhScGIyNXpLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5MGIzUmhiRjlpZFdOclpYUnpLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbVoxYm1SZlkyOXVkSEpoWTNRb2NHRjVLV0p2YjJ3aUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdWZlluVmphMlYwSUdSbGNHOXphWFJmWTI5c2JHRjBaWEpoYkNCM2FYUm9aSEpoZDE5amIyeHNZWFJsY21Gc0lHOXdaVzVmY0c5emFYUnBiMjRnWTJ4dmMyVmZjRzl6YVhScGIyNGdjbVZpWVd4aGJtTmxYMkoxWTJ0bGRDQjFjR1JoZEdWZmIzSmhZMnhsSUd4cGNYVnBaR0YwWlY5d2IzTnBkR2x2YmlCblpYUmZZMjlzYkdGMFpYSmhiRjlpWVd4aGJtTmxJR2RsZEY5MWJuSmxZV3hwZW1Wa1gzQnViQ0JuWlhSZmIzSmhZMnhsWDNWd1pHRjBaV1JmWVhRZ1oyVjBYM1J2ZEdGc1gzQnZjMmwwYVc5dWN5Qm5aWFJmZEc5MFlXeGZZblZqYTJWMGN5Qm1kVzVrWDJOdmJuUnlZV04wQ2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1qTTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1UTNKbGMyTmhRblZqYTJWMFVISnZkRzlqYjJ3dVkzSmxZWFJsWDJKMVkydGxkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVjlpZFdOclpYUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkhWd2JpQXhOZ29nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qRTFPUzB4TmpJS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QWpJR055WldGMFpWOWlkV05yWlhRS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBOalErQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBOalErQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1UYzJDaUFnSUNBdkx5QmhjM05sY25RZ1lYTnpaWFJ6TG14bGJtZDBhQ0E5UFNCM1pXbG5hSFJ6TG14bGJtZDBhQ3dnSWt4bGJtZDBhQ0J0YVhOdFlYUmphQ0lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVEdWdVozUm9JRzFwYzIxaGRHTm9DaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qRTNOd29nSUNBZ0x5OGdZWE56WlhKMElHRnpjMlYwY3k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTUNrc0lDSk5kWE4wSUdoaGRtVWdZWFFnYkdWaGMzUWdNU0JoYzNObGRDSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGMzTmxjblFnTHk4Z1RYVnpkQ0JvWVhabElHRjBJR3hsWVhOMElERWdZWE56WlhRS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TVRjNENpQWdJQ0F2THlCaGMzTmxjblFnWVhOelpYUnpMbXhsYm1kMGFDQThQU0JWU1c1ME5qUW9PQ2tzSUNKTllYZ2dPQ0JoYzNObGRITWdjR1Z5SUdKMVkydGxkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUUxaGVDQTRJR0Z6YzJWMGN5QndaWElnWW5WamEyVjBDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qRTNPUW9nSUNBZ0x5OGdZWE56WlhKMElHeGxkbVZ5WVdkbExtNWhkR2wyWlNBK1BTQlZTVzUwTmpRb1RVbE9YMHhGVmtWU1FVZEZLU3dnSWt4bGRtVnlZV2RsSUhSdmJ5QnNiM2NpQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk1aWFpsY21GblpTQjBiMjhnYkc5M0NpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pFNE1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUd4bGRtVnlZV2RsTG01aGRHbDJaU0E4UFNCVlNXNTBOalFvVFVGWVgweEZWa1ZTUVVkRktTd2dJa3hsZG1WeVlXZGxJSFJ2YnlCb2FXZG9JZ29nSUNBZ2NIVnphR2x1ZENBeE5UQUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVEdWMlpYSmhaMlVnZEc5dklHaHBaMmdLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNVGd5TFRFNE13b2dJQ0FnTHk4Z0l5QldZV3hwWkdGMFpTQjNaV2xuYUhSeklITjFiU0IwYnlBeE1EQUtJQ0FnSUM4dklIUnZkR0ZzWDNkbGFXZG9kQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNVGcwQ2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9kMlZwWjJoMGN5NXNaVzVuZEdncE9nb2dJQ0FnWkhWd0NncGpjbVZoZEdWZlluVmphMlYwWDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1UZzBDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2QyVnBaMmgwY3k1c1pXNW5kR2dwT2dvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdQQW9nSUNBZ1lub2dZM0psWVhSbFgySjFZMnRsZEY5aFpuUmxjbDltYjNKQU5Rb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRveE9EVUtJQ0FnSUM4dklIUnZkR0ZzWDNkbGFXZG9kQ0E5SUhSdmRHRnNYM2RsYVdkb2RDQXJJSGRsYVdkb2RITmJhVjB1Ym1GMGFYWmxDaUFnSUNCa2FXY2dOQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBcUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklETUtJQ0FnSUNzS0lDQWdJR0oxY25rZ013b2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRveE9EUUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoM1pXbG5hSFJ6TG14bGJtZDBhQ2s2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlHTnlaV0YwWlY5aWRXTnJaWFJmWm05eVgyaGxZV1JsY2tBeUNncGpjbVZoZEdWZlluVmphMlYwWDJGbWRHVnlYMlp2Y2tBMU9nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRveE9EWUtJQ0FnSUM4dklHRnpjMlZ5ZENCMGIzUmhiRjkzWldsbmFIUWdQVDBnVlVsdWREWTBLREV3TUNrc0lDSlhaV2xuYUhSeklHMTFjM1FnYzNWdElIUnZJREV3TUNJS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJREV3TUFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlhaV2xuYUhSeklHMTFjM1FnYzNWdElIUnZJREV3TUFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG94T0RnS0lDQWdJQzh2SUc5M2JtVnlYMkZrWkhJZ1BTQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TmdvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG94T1RBdE1Ua3hDaUFnSUNBdkx5QWpJRUZ6YzJsbmJpQmlkV05yWlhRZ1NVUUtJQ0FnSUM4dklHbG1JRzkzYm1WeVgyRmtaSElnYVc0Z2MyVnNaaTVpZFdOclpYUmZZMjkxYm5Sek9nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5qSTJZall6TldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESTNDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdOeVpXRjBaVjlpZFdOclpYUmZaV3h6WlY5aWIyUjVRRGNLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNVGt5Q2lBZ0lDQXZMeUJpZFdOclpYUmZhV1FnUFNCelpXeG1MbUoxWTJ0bGRGOWpiM1Z1ZEhOYmIzZHVaWEpmWVdSa2NsMHVibUYwYVhabENpQWdJQ0JrYVdjZ01qVUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUoxWTJ0bGRGOWpiM1Z1ZEhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCaWRHOXBDaUFnSUNCaWRYSjVJRGtLQ21OeVpXRjBaVjlpZFdOclpYUmZZV1owWlhKZmFXWmZaV3h6WlVBNE9nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRveE9UY0tJQ0FnSUM4dklHRnpjMlYwTUQxaGMzTmxkSE5iTUYwZ2FXWWdZWE56WlhSekxteGxibWQwYUNBK0lGVkpiblEyTkNnd0tTQmxiSE5sSUdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHSjZJR055WldGMFpWOWlkV05yWlhSZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TUFvZ0lDQWdaR2xuSURjS0lDQWdJR1Y0ZEhKaFkzUWdNaUE0Q2lBZ0lDQmlkWEo1SURJMENncGpjbVZoZEdWZlluVmphMlYwWDNSbGNtNWhjbmxmYldWeVoyVkFNVEU2Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPakU1T0FvZ0lDQWdMeThnWVhOelpYUXhQV0Z6YzJWMGMxc3hYU0JwWmlCaGMzTmxkSE11YkdWdVozUm9JRDRnVlVsdWREWTBLREVwSUdWc2MyVWdZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0JrYVdjZ05nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDRLSUNBZ0lHSjZJR055WldGMFpWOWlkV05yWlhSZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TXdvZ0lDQWdaR2xuSURjS0lDQWdJR1Y0ZEhKaFkzUWdNVEFnT0FvZ0lDQWdZblZ5ZVNBeU13b0tZM0psWVhSbFgySjFZMnRsZEY5MFpYSnVZWEo1WDIxbGNtZGxRREUwT2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG94T1RrS0lDQWdJQzh2SUdGemMyVjBNajFoYzNObGRITmJNbDBnYVdZZ1lYTnpaWFJ6TG14bGJtZDBhQ0ErSUZWSmJuUTJOQ2d5S1NCbGJITmxJR0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnWkdsbklEWUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0ErQ2lBZ0lDQmllaUJqY21WaGRHVmZZblZqYTJWMFgzUmxjbTVoY25sZlptRnNjMlZBTVRZS0lDQWdJR1JwWnlBM0NpQWdJQ0JsZUhSeVlXTjBJREU0SURnS0lDQWdJR0oxY25rZ01UY0tDbU55WldGMFpWOWlkV05yWlhSZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TnpvS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TWpBd0NpQWdJQ0F2THlCaGMzTmxkRE05WVhOelpYUnpXek5kSUdsbUlHRnpjMlYwY3k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTXlrZ1pXeHpaU0JoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUdScFp5QTJDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDRLSUNBZ0lHSjZJR055WldGMFpWOWlkV05yWlhSZmRHVnlibUZ5ZVY5bVlXeHpaVUF4T1FvZ0lDQWdaR2xuSURjS0lDQWdJR1Y0ZEhKaFkzUWdNallnT0FvZ0lDQWdZblZ5ZVNBeE5nb0tZM0psWVhSbFgySjFZMnRsZEY5MFpYSnVZWEo1WDIxbGNtZGxRREl3T2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG95TURFS0lDQWdJQzh2SUdGemMyVjBORDFoYzNObGRITmJORjBnYVdZZ1lYTnpaWFJ6TG14bGJtZDBhQ0ErSUZWSmJuUTJOQ2cwS1NCbGJITmxJR0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnWkdsbklEWUtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdQZ29nSUNBZ1lub2dZM0psWVhSbFgySjFZMnRsZEY5MFpYSnVZWEo1WDJaaGJITmxRREl5Q2lBZ0lDQmthV2NnTndvZ0lDQWdaWGgwY21GamRDQXpOQ0E0Q2lBZ0lDQmlkWEo1SURFMUNncGpjbVZoZEdWZlluVmphMlYwWDNSbGNtNWhjbmxmYldWeVoyVkFNak02Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPakl3TWdvZ0lDQWdMeThnWVhOelpYUTFQV0Z6YzJWMGMxczFYU0JwWmlCaGMzTmxkSE11YkdWdVozUm9JRDRnVlVsdWREWTBLRFVwSUdWc2MyVWdZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0JrYVdjZ05nb2dJQ0FnY0hWemFHbHVkQ0ExQ2lBZ0lDQStDaUFnSUNCaWVpQmpjbVZoZEdWZlluVmphMlYwWDNSbGNtNWhjbmxmWm1Gc2MyVkFNalVLSUNBZ0lHUnBaeUEzQ2lBZ0lDQmxlSFJ5WVdOMElEUXlJRGdLSUNBZ0lHSjFjbmtnTVRRS0NtTnlaV0YwWlY5aWRXTnJaWFJmZEdWeWJtRnllVjl0WlhKblpVQXlOam9LSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNakF6Q2lBZ0lDQXZMeUJoYzNObGREWTlZWE56WlhSeld6WmRJR2xtSUdGemMyVjBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OaWtnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJR1JwWnlBMkNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lENEtJQ0FnSUdKNklHTnlaV0YwWlY5aWRXTnJaWFJmZEdWeWJtRnllVjltWVd4elpVQXlPQW9nSUNBZ1pHbG5JRGNLSUNBZ0lHVjRkSEpoWTNRZ05UQWdPQW9nSUNBZ1luVnllU0F4TXdvS1kzSmxZWFJsWDJKMVkydGxkRjkwWlhKdVlYSjVYMjFsY21kbFFESTVPZ29nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUb3lNRFFLSUNBZ0lDOHZJR0Z6YzJWME56MWhjM05sZEhOYk4xMGdhV1lnWVhOelpYUnpMbXhsYm1kMGFDQStJRlZKYm5RMk5DZzNLU0JsYkhObElHRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdaR2xuSURZS0lDQWdJSEIxYzJocGJuUWdOd29nSUNBZ1Bnb2dJQ0FnWW5vZ1kzSmxZWFJsWDJKMVkydGxkRjkwWlhKdVlYSjVYMlpoYkhObFFETXhDaUFnSUNCa2FXY2dOd29nSUNBZ1pYaDBjbUZqZENBMU9DQTRDaUFnSUNCaWRYSjVJREV5Q2dwamNtVmhkR1ZmWW5WamEyVjBYM1JsY201aGNubGZiV1Z5WjJWQU16STZDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qSXdOUW9nSUNBZ0x5OGdkMlZwWjJoME1EMTNaV2xuYUhSeld6QmRJR2xtSUhkbGFXZG9kSE11YkdWdVozUm9JRDRnVlVsdWREWTBLREFwSUdWc2MyVWdZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0JrYVdjZ013b2dJQ0FnWW5vZ1kzSmxZWFJsWDJKMVkydGxkRjkwWlhKdVlYSjVYMlpoYkhObFFETTBDaUFnSUNCa2FXY2dOQW9nSUNBZ1pYaDBjbUZqZENBeUlEZ0tJQ0FnSUdKMWNua2dNVEVLQ21OeVpXRjBaVjlpZFdOclpYUmZkR1Z5Ym1GeWVWOXRaWEpuWlVBek5Ub0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1qQTJDaUFnSUNBdkx5QjNaV2xuYUhReFBYZGxhV2RvZEhOYk1WMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9NU2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQZ29nSUNBZ1lub2dZM0psWVhSbFgySjFZMnRsZEY5MFpYSnVZWEo1WDJaaGJITmxRRE0zQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaWGgwY21GamRDQXhNQ0E0Q2lBZ0lDQmlkWEo1SURFd0NncGpjbVZoZEdWZlluVmphMlYwWDNSbGNtNWhjbmxmYldWeVoyVkFNemc2Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPakl3TndvZ0lDQWdMeThnZDJWcFoyaDBNajEzWldsbmFIUnpXekpkSUdsbUlIZGxhV2RvZEhNdWJHVnVaM1JvSUQ0Z1ZVbHVkRFkwS0RJcElHVnNjMlVnWVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUQ0S0lDQWdJR0o2SUdOeVpXRjBaVjlpZFdOclpYUmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME1Bb2dJQ0FnWkdsbklEUUtJQ0FnSUdWNGRISmhZM1FnTVRnZ09Bb2dJQ0FnWW5WeWVTQXlNZ29LWTNKbFlYUmxYMkoxWTJ0bGRGOTBaWEp1WVhKNVgyMWxjbWRsUURReE9nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRveU1EZ0tJQ0FnSUM4dklIZGxhV2RvZERNOWQyVnBaMmgwYzFzelhTQnBaaUIzWldsbmFIUnpMbXhsYm1kMGFDQStJRlZKYm5RMk5DZ3pLU0JsYkhObElHRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1Bnb2dJQ0FnWW5vZ1kzSmxZWFJsWDJKMVkydGxkRjkwWlhKdVlYSjVYMlpoYkhObFFEUXpDaUFnSUNCa2FXY2dOQW9nSUNBZ1pYaDBjbUZqZENBeU5pQTRDaUFnSUNCaWRYSjVJREl4Q2dwamNtVmhkR1ZmWW5WamEyVjBYM1JsY201aGNubGZiV1Z5WjJWQU5EUTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qSXdPUW9nSUNBZ0x5OGdkMlZwWjJoME5EMTNaV2xuYUhSeld6UmRJR2xtSUhkbGFXZG9kSE11YkdWdVozUm9JRDRnVlVsdWREWTBLRFFwSUdWc2MyVWdZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQStDaUFnSUNCaWVpQmpjbVZoZEdWZlluVmphMlYwWDNSbGNtNWhjbmxmWm1Gc2MyVkFORFlLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmxlSFJ5WVdOMElETTBJRGdLSUNBZ0lHSjFjbmtnTWpBS0NtTnlaV0YwWlY5aWRXTnJaWFJmZEdWeWJtRnllVjl0WlhKblpVQTBOem9LSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNakV3Q2lBZ0lDQXZMeUIzWldsbmFIUTFQWGRsYVdkb2RITmJOVjBnYVdZZ2QyVnBaMmgwY3k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTlNrZ1pXeHpaU0JoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9hVzUwSURVS0lDQWdJRDRLSUNBZ0lHSjZJR055WldGMFpWOWlkV05yWlhSZmRHVnlibUZ5ZVY5bVlXeHpaVUEwT1FvZ0lDQWdaR2xuSURRS0lDQWdJR1Y0ZEhKaFkzUWdORElnT0FvZ0lDQWdZblZ5ZVNBeE9Rb0tZM0psWVhSbFgySjFZMnRsZEY5MFpYSnVZWEo1WDIxbGNtZGxRRFV3T2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG95TVRFS0lDQWdJQzh2SUhkbGFXZG9kRFk5ZDJWcFoyaDBjMXMyWFNCcFppQjNaV2xuYUhSekxteGxibWQwYUNBK0lGVkpiblEyTkNnMktTQmxiSE5sSUdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnUGdvZ0lDQWdZbm9nWTNKbFlYUmxYMkoxWTJ0bGRGOTBaWEp1WVhKNVgyWmhiSE5sUURVeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWlhoMGNtRmpkQ0ExTUNBNENpQWdJQ0JpZFhKNUlERTRDZ3BqY21WaGRHVmZZblZqYTJWMFgzUmxjbTVoY25sZmJXVnlaMlZBTlRNNkNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pJeE1nb2dJQ0FnTHk4Z2QyVnBaMmgwTnoxM1pXbG5hSFJ6V3pkZElHbG1JSGRsYVdkb2RITXViR1Z1WjNSb0lENGdWVWx1ZERZMEtEY3BJR1ZzYzJVZ1lYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdsdWRDQTNDaUFnSUNBK0NpQWdJQ0JpZWlCamNtVmhkR1ZmWW5WamEyVjBYM1JsY201aGNubGZabUZzYzJWQU5UVUtJQ0FnSUdScFp5QTBDaUFnSUNCbGVIUnlZV04wSURVNElEZ0tDbU55WldGMFpWOWlkV05yWlhSZmRHVnlibUZ5ZVY5dFpYSm5aVUExTmpvS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TWpFekNpQWdJQ0F2THlCaGMzTmxkRjlqYjNWdWREMWhjbU0wTGxWSmJuUTJOQ2hoYzNObGRITXViR1Z1WjNSb0tTd0tJQ0FnSUdScFp5QTNDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qRTVOaTB5TVRjS0lDQWdJQzh2SUdKMVkydGxkQ0E5SUVKMVkydGxkQ2dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkREE5WVhOelpYUnpXekJkSUdsbUlHRnpjMlYwY3k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTUNrZ1pXeHpaU0JoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRERTlZWE56WlhSeld6RmRJR2xtSUdGemMyVjBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9NU2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZERJOVlYTnpaWFJ6V3pKZElHbG1JR0Z6YzJWMGN5NXNaVzVuZEdnZ1BpQlZTVzUwTmpRb01pa2daV3h6WlNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRE05WVhOelpYUnpXek5kSUdsbUlHRnpjMlYwY3k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTXlrZ1pXeHpaU0JoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGREUTlZWE56WlhSeld6UmRJR2xtSUdGemMyVjBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OQ2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZERVOVlYTnpaWFJ6V3pWZElHbG1JR0Z6YzJWMGN5NXNaVzVuZEdnZ1BpQlZTVzUwTmpRb05Ta2daV3h6WlNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRFk5WVhOelpYUnpXelpkSUdsbUlHRnpjMlYwY3k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTmlrZ1pXeHpaU0JoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGREYzlZWE56WlhSeld6ZGRJR2xtSUdGemMyVjBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OeWtnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhRd1BYZGxhV2RvZEhOYk1GMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9NQ2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhReFBYZGxhV2RvZEhOYk1WMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9NU2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhReVBYZGxhV2RvZEhOYk1sMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9NaWtnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhRelBYZGxhV2RvZEhOYk0xMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9NeWtnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhRMFBYZGxhV2RvZEhOYk5GMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OQ2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhRMVBYZGxhV2RvZEhOYk5WMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OU2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhRMlBYZGxhV2RvZEhOYk5sMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OaWtnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhRM1BYZGxhV2RvZEhOYk4xMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OeWtnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5amIzVnVkRDFoY21NMExsVkpiblEyTkNoaGMzTmxkSE11YkdWdVozUm9LU3dLSUNBZ0lDOHZJQ0FnSUNCc1pYWmxjbUZuWlQxc1pYWmxjbUZuWlN3S0lDQWdJQzh2SUNBZ0lDQnZkMjVsY2oxdmQyNWxjbDloWkdSeUxBb2dJQ0FnTHk4Z0lDQWdJR1Y0YVhOMGN6MWhjbU0wTGtKdmIyd29WSEoxWlNrc0NpQWdJQ0F2THlBcENpQWdJQ0JrYVdjZ01qVUtJQ0FnSUdScFp5QXlOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVRrS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4TndvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01UWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREUxQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01qQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01qWUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPakl4TmdvZ0lDQWdMeThnWlhocGMzUnpQV0Z5WXpRdVFtOXZiQ2hVY25WbEtTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3dDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qRTVOaTB5TVRjS0lDQWdJQzh2SUdKMVkydGxkQ0E5SUVKMVkydGxkQ2dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkREE5WVhOelpYUnpXekJkSUdsbUlHRnpjMlYwY3k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTUNrZ1pXeHpaU0JoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRERTlZWE56WlhSeld6RmRJR2xtSUdGemMyVjBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9NU2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZERJOVlYTnpaWFJ6V3pKZElHbG1JR0Z6YzJWMGN5NXNaVzVuZEdnZ1BpQlZTVzUwTmpRb01pa2daV3h6WlNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRE05WVhOelpYUnpXek5kSUdsbUlHRnpjMlYwY3k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTXlrZ1pXeHpaU0JoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGREUTlZWE56WlhSeld6UmRJR2xtSUdGemMyVjBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OQ2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZERVOVlYTnpaWFJ6V3pWZElHbG1JR0Z6YzJWMGN5NXNaVzVuZEdnZ1BpQlZTVzUwTmpRb05Ta2daV3h6WlNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRFk5WVhOelpYUnpXelpkSUdsbUlHRnpjMlYwY3k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTmlrZ1pXeHpaU0JoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGREYzlZWE56WlhSeld6ZGRJR2xtSUdGemMyVjBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OeWtnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhRd1BYZGxhV2RvZEhOYk1GMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9NQ2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhReFBYZGxhV2RvZEhOYk1WMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9NU2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhReVBYZGxhV2RvZEhOYk1sMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9NaWtnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhRelBYZGxhV2RvZEhOYk0xMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9NeWtnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhRMFBYZGxhV2RvZEhOYk5GMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OQ2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhRMVBYZGxhV2RvZEhOYk5WMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OU2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhRMlBYZGxhV2RvZEhOYk5sMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OaWtnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhRM1BYZGxhV2RvZEhOYk4xMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OeWtnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5amIzVnVkRDFoY21NMExsVkpiblEyTkNoaGMzTmxkSE11YkdWdVozUm9LU3dLSUNBZ0lDOHZJQ0FnSUNCc1pYWmxjbUZuWlQxc1pYWmxjbUZuWlN3S0lDQWdJQzh2SUNBZ0lDQnZkMjVsY2oxdmQyNWxjbDloWkdSeUxBb2dJQ0FnTHk4Z0lDQWdJR1Y0YVhOMGN6MWhjbU0wTGtKdmIyd29WSEoxWlNrc0NpQWdJQ0F2THlBcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1UQXpDaUFnSUNBdkx5QnlaWFIxY200Z1lpSmlhM1JmSWlBcklHOTNibVZ5SUNzZ2IzQXVhWFJ2WWloaWRXTnJaWFJmYVdRcENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE5qSTJZamMwTldZS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TWpFNUNpQWdJQ0F2THlCelpXeG1MbUoxWTJ0bGRITmJYMkoxWTJ0bGRGOXJaWGtvVkhodUxuTmxibVJsY2k1aWVYUmxjeXdnWW5WamEyVjBYMmxrS1YwZ1BTQmlkV05yWlhRdVkyOXdlU2dwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qRXdNd29nSUNBZ0x5OGdjbVYwZFhKdUlHSWlZbXQwWHlJZ0t5QnZkMjVsY2lBcklHOXdMbWwwYjJJb1luVmphMlYwWDJsa0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNVElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRveU1Ua0tJQ0FnSUM4dklITmxiR1l1WW5WamEyVjBjMXRmWW5WamEyVjBYMnRsZVNoVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6TENCaWRXTnJaWFJmYVdRcFhTQTlJR0oxWTJ0bGRDNWpiM0I1S0NrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG95TWpBS0lDQWdJQzh2SUhObGJHWXVZblZqYTJWMFgyTnZkVzUwYzF0dmQyNWxjbDloWkdSeVhTQTlJR0Z5WXpRdVZVbHVkRFkwS0dKMVkydGxkRjlwWkNBcklGVkpiblEyTkNneEtTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTWprS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1qSXhDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMkoxWTJ0bGRITXVkbUZzZFdVZ1BTQnpaV3htTG5SdmRHRnNYMkoxWTJ0bGRITXVkbUZzZFdVZ0t5QlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKMGIzUmhiRjlpZFdOclpYUnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMkoxWTJ0bGRITWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV01nT0NBdkx5QWlkRzkwWVd4ZlluVmphMlYwY3lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pJeU15MHlNekFLSUNBZ0lDOHZJR0Z5WXpRdVpXMXBkQ2dLSUNBZ0lDOHZJQ0FnSUNBaVFuVmphMlYwUTNKbFlYUmxaQ2gxYVc1ME5qUXNZV1JrY21WemN5eDFhVzUwTmpSYlhTeDFhVzUwTmpSYlhTeDFhVzUwTmpRcElpd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoaWRXTnJaWFJmYVdRcExBb2dJQ0FnTHk4Z0lDQWdJRzkzYm1WeVgyRmtaSElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJ6TEFvZ0lDQWdMeThnSUNBZ0lIZGxhV2RvZEhNc0NpQWdJQ0F2THlBZ0lDQWdiR1YyWlhKaFoyVXNDaUFnSUNBdkx5QXBDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01ETTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhwYm5RZ05USUtJQ0FnSUdScFp5QTVDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURrS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRObVkwWVRoa09ETWdMeThnYldWMGFHOWtJQ0pDZFdOclpYUkRjbVZoZEdWa0tIVnBiblEyTkN4aFpHUnlaWE56TEhWcGJuUTJORnRkTEhWcGJuUTJORnRkTEhWcGJuUTJOQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG94TlRrdE1UWXlDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnSXlCamNtVmhkR1ZmWW5WamEyVjBDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1kzSmxZWFJsWDJKMVkydGxkRjkwWlhKdVlYSjVYMlpoYkhObFFEVTFPZ29nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUb3lNVElLSUNBZ0lDOHZJSGRsYVdkb2REYzlkMlZwWjJoMGMxczNYU0JwWmlCM1pXbG5hSFJ6TG14bGJtZDBhQ0ErSUZWSmJuUTJOQ2czS1NCbGJITmxJR0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lnWTNKbFlYUmxYMkoxWTJ0bGRGOTBaWEp1WVhKNVgyMWxjbWRsUURVMkNncGpjbVZoZEdWZlluVmphMlYwWDNSbGNtNWhjbmxmWm1Gc2MyVkFOVEk2Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPakl4TVFvZ0lDQWdMeThnZDJWcFoyaDBOajEzWldsbmFIUnpXelpkSUdsbUlIZGxhV2RvZEhNdWJHVnVaM1JvSUQ0Z1ZVbHVkRFkwS0RZcElHVnNjMlVnWVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWW5WeWVTQXhPQW9nSUNBZ1lpQmpjbVZoZEdWZlluVmphMlYwWDNSbGNtNWhjbmxmYldWeVoyVkFOVE1LQ21OeVpXRjBaVjlpZFdOclpYUmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME9Ub0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1qRXdDaUFnSUNBdkx5QjNaV2xuYUhRMVBYZGxhV2RvZEhOYk5WMGdhV1lnZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OU2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlkWEo1SURFNUNpQWdJQ0JpSUdOeVpXRjBaVjlpZFdOclpYUmZkR1Z5Ym1GeWVWOXRaWEpuWlVBMU1Bb0tZM0psWVhSbFgySjFZMnRsZEY5MFpYSnVZWEo1WDJaaGJITmxRRFEyT2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG95TURrS0lDQWdJQzh2SUhkbGFXZG9kRFE5ZDJWcFoyaDBjMXMwWFNCcFppQjNaV2xuYUhSekxteGxibWQwYUNBK0lGVkpiblEyTkNnMEtTQmxiSE5sSUdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdKMWNua2dNakFLSUNBZ0lHSWdZM0psWVhSbFgySjFZMnRsZEY5MFpYSnVZWEo1WDIxbGNtZGxRRFEzQ2dwamNtVmhkR1ZmWW5WamEyVjBYM1JsY201aGNubGZabUZzYzJWQU5ETTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qSXdPQW9nSUNBZ0x5OGdkMlZwWjJoME16MTNaV2xuYUhSeld6TmRJR2xtSUhkbGFXZG9kSE11YkdWdVozUm9JRDRnVlVsdWREWTBLRE1wSUdWc2MyVWdZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZblZ5ZVNBeU1Rb2dJQ0FnWWlCamNtVmhkR1ZmWW5WamEyVjBYM1JsY201aGNubGZiV1Z5WjJWQU5EUUtDbU55WldGMFpWOWlkV05yWlhSZmRHVnlibUZ5ZVY5bVlXeHpaVUEwTURvS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TWpBM0NpQWdJQ0F2THlCM1pXbG5hSFF5UFhkbGFXZG9kSE5iTWwwZ2FXWWdkMlZwWjJoMGN5NXNaVzVuZEdnZ1BpQlZTVzUwTmpRb01pa2daV3h6WlNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaWRYSjVJREl5Q2lBZ0lDQmlJR055WldGMFpWOWlkV05yWlhSZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTVFvS1kzSmxZWFJsWDJKMVkydGxkRjkwWlhKdVlYSjVYMlpoYkhObFFETTNPZ29nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUb3lNRFlLSUNBZ0lDOHZJSGRsYVdkb2RERTlkMlZwWjJoMGMxc3hYU0JwWmlCM1pXbG5hSFJ6TG14bGJtZDBhQ0ErSUZWSmJuUTJOQ2d4S1NCbGJITmxJR0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0oxY25rZ01UQUtJQ0FnSUdJZ1kzSmxZWFJsWDJKMVkydGxkRjkwWlhKdVlYSjVYMjFsY21kbFFETTRDZ3BqY21WaGRHVmZZblZqYTJWMFgzUmxjbTVoY25sZlptRnNjMlZBTXpRNkNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pJd05Rb2dJQ0FnTHk4Z2QyVnBaMmgwTUQxM1pXbG5hSFJ6V3pCZElHbG1JSGRsYVdkb2RITXViR1Z1WjNSb0lENGdWVWx1ZERZMEtEQXBJR1ZzYzJVZ1lYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdZaUJqY21WaGRHVmZZblZqYTJWMFgzUmxjbTVoY25sZmJXVnlaMlZBTXpVS0NtTnlaV0YwWlY5aWRXTnJaWFJmZEdWeWJtRnllVjltWVd4elpVQXpNVG9LSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNakEwQ2lBZ0lDQXZMeUJoYzNObGREYzlZWE56WlhSeld6ZGRJR2xtSUdGemMyVjBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OeWtnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlkWEo1SURFeUNpQWdJQ0JpSUdOeVpXRjBaVjlpZFdOclpYUmZkR1Z5Ym1GeWVWOXRaWEpuWlVBek1nb0tZM0psWVhSbFgySjFZMnRsZEY5MFpYSnVZWEo1WDJaaGJITmxRREk0T2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG95TURNS0lDQWdJQzh2SUdGemMyVjBOajFoYzNObGRITmJObDBnYVdZZ1lYTnpaWFJ6TG14bGJtZDBhQ0ErSUZWSmJuUTJOQ2cyS1NCbGJITmxJR0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0oxY25rZ01UTUtJQ0FnSUdJZ1kzSmxZWFJsWDJKMVkydGxkRjkwWlhKdVlYSjVYMjFsY21kbFFESTVDZ3BqY21WaGRHVmZZblZqYTJWMFgzUmxjbTVoY25sZlptRnNjMlZBTWpVNkNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pJd01nb2dJQ0FnTHk4Z1lYTnpaWFExUFdGemMyVjBjMXMxWFNCcFppQmhjM05sZEhNdWJHVnVaM1JvSUQ0Z1ZVbHVkRFkwS0RVcElHVnNjMlVnWVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWW5WeWVTQXhOQW9nSUNBZ1lpQmpjbVZoZEdWZlluVmphMlYwWDNSbGNtNWhjbmxmYldWeVoyVkFNallLQ21OeVpXRjBaVjlpZFdOclpYUmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU1qb0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1qQXhDaUFnSUNBdkx5QmhjM05sZERROVlYTnpaWFJ6V3pSZElHbG1JR0Z6YzJWMGN5NXNaVzVuZEdnZ1BpQlZTVzUwTmpRb05Da2daV3h6WlNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaWRYSjVJREUxQ2lBZ0lDQmlJR055WldGMFpWOWlkV05yWlhSZmRHVnlibUZ5ZVY5dFpYSm5aVUF5TXdvS1kzSmxZWFJsWDJKMVkydGxkRjkwWlhKdVlYSjVYMlpoYkhObFFERTVPZ29nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUb3lNREFLSUNBZ0lDOHZJR0Z6YzJWME16MWhjM05sZEhOYk0xMGdhV1lnWVhOelpYUnpMbXhsYm1kMGFDQStJRlZKYm5RMk5DZ3pLU0JsYkhObElHRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSjFjbmtnTVRZS0lDQWdJR0lnWTNKbFlYUmxYMkoxWTJ0bGRGOTBaWEp1WVhKNVgyMWxjbWRsUURJd0NncGpjbVZoZEdWZlluVmphMlYwWDNSbGNtNWhjbmxmWm1Gc2MyVkFNVFk2Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPakU1T1FvZ0lDQWdMeThnWVhOelpYUXlQV0Z6YzJWMGMxc3lYU0JwWmlCaGMzTmxkSE11YkdWdVozUm9JRDRnVlVsdWREWTBLRElwSUdWc2MyVWdZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZblZ5ZVNBeE53b2dJQ0FnWWlCamNtVmhkR1ZmWW5WamEyVjBYM1JsY201aGNubGZiV1Z5WjJWQU1UY0tDbU55WldGMFpWOWlkV05yWlhSZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TXpvS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TVRrNENpQWdJQ0F2THlCaGMzTmxkREU5WVhOelpYUnpXekZkSUdsbUlHRnpjMlYwY3k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTVNrZ1pXeHpaU0JoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpZFhKNUlESXpDaUFnSUNCaUlHTnlaV0YwWlY5aWRXTnJaWFJmZEdWeWJtRnllVjl0WlhKblpVQXhOQW9LWTNKbFlYUmxYMkoxWTJ0bGRGOTBaWEp1WVhKNVgyWmhiSE5sUURFd09nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRveE9UY0tJQ0FnSUM4dklHRnpjMlYwTUQxaGMzTmxkSE5iTUYwZ2FXWWdZWE56WlhSekxteGxibWQwYUNBK0lGVkpiblEyTkNnd0tTQmxiSE5sSUdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdKMWNua2dNalFLSUNBZ0lHSWdZM0psWVhSbFgySjFZMnRsZEY5MFpYSnVZWEo1WDIxbGNtZGxRREV4Q2dwamNtVmhkR1ZmWW5WamEyVjBYMlZzYzJWZlltOWtlVUEzT2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG94T1RRS0lDQWdJQzh2SUdKMVkydGxkRjlwWkNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0oxY25rZ09Rb2dJQ0FnWWlCamNtVmhkR1ZmWW5WamEyVjBYMkZtZEdWeVgybG1YMlZzYzJWQU9Bb0tDaTh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VRM0psYzJOaFFuVmphMlYwVUhKdmRHOWpiMnd1WkdWd2IzTnBkRjlqYjJ4c1lYUmxjbUZzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVndiM05wZEY5amIyeHNZWFJsY21Gc09nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRveU16UXRNak0zQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z0l5QmtaWEJ2YzJsMFgyTnZiR3hoZEdWeVlXd0tJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1qUXpDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEY5MGVHNHVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSWsxMWMzUWdjR0Y1SUdOdmJuUnlZV04wSWdvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUWFZ6ZENCd1lYa2dZMjl1ZEhKaFkzUUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1qUTBDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEY5MGVHNHVZVzF2ZFc1MElENGdWVWx1ZERZMEtEQXBMQ0FpUVcxdmRXNTBJRzExYzNRZ1ltVWdQaUF3SWdvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiVzkxYm5RZ2JYVnpkQ0JpWlNBK0lEQUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1qUTJDaUFnSUNBdkx5QjFjMlZ5SUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qSTBOd29nSUNBZ0x5OGdZM1Z5Y21WdWRDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1qUTRDaUFnSUNBdkx5QnBaaUIxYzJWeUlHbHVJSE5sYkdZdVkyOXNiR0YwWlhKaGJEb0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZzJNelptTm1NMVpnb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRveU5EWUtJQ0FnSUM4dklIVnpaWElnUFNCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1qUTRDaUFnSUNBdkx5QnBaaUIxYzJWeUlHbHVJSE5sYkdZdVkyOXNiR0YwWlhKaGJEb0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdSbGNHOXphWFJmWTI5c2JHRjBaWEpoYkY5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNalE1Q2lBZ0lDQXZMeUJqZFhKeVpXNTBJRDBnYzJWc1ppNWpiMnhzWVhSbGNtRnNXM1Z6WlhKZExtNWhkR2wyWlFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amIyeHNZWFJsY21Gc0lHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ1luUnZhUW9nSUNBZ1luVnllU0F5Q2dwa1pYQnZjMmwwWDJOdmJHeGhkR1Z5WVd4ZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG95TlRBS0lDQWdJQzh2SUhObGJHWXVZMjlzYkdGMFpYSmhiRnQxYzJWeVhTQTlJR0Z5WXpRdVZVbHVkRFkwS0dOMWNuSmxiblFnS3lCd1lYbHRaVzUwWDNSNGJpNWhiVzkxYm5RcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNalUxQ2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNod1lYbHRaVzUwWDNSNGJpNWhiVzkxYm5RcExBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRveU5USXRNalUyQ2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvQ2lBZ0lDQXZMeUFnSUNBZ0lrTnZiR3hoZEdWeVlXeEVaWEJ2YzJsMFpXUW9ZV1JrY21WemN5eDFhVzUwTmpRcElpd0tJQ0FnSUM4dklDQWdJQ0IxYzJWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hCaGVXMWxiblJmZEhodUxtRnRiM1Z1ZENrc0NpQWdJQ0F2THlBcENpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dZV0ptTW1Vek1DQXZMeUJ0WlhSb2IyUWdJa052Ykd4aGRHVnlZV3hFWlhCdmMybDBaV1FvWVdSa2NtVnpjeXgxYVc1ME5qUXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNak0wTFRJek53b2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJQ01nWkdWd2IzTnBkRjlqYjJ4c1lYUmxjbUZzQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VERTFNV1kzWXpjMU9EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VRM0psYzJOaFFuVmphMlYwVUhKdmRHOWpiMnd1ZDJsMGFHUnlZWGRmWTI5c2JHRjBaWEpoYkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuZHBkR2hrY21GM1gyTnZiR3hoZEdWeVlXdzZDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qSTFPUzB5TmpJS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QWpJSGRwZEdoa2NtRjNYMk52Ykd4aGRHVnlZV3dLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qSTJOUW9nSUNBZ0x5OGdkWE5sY2lBOUlHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUb3lOallLSUNBZ0lDOHZJR0Z6YzJWeWRDQjFjMlZ5SUdsdUlITmxiR1l1WTI5c2JHRjBaWEpoYkN3Z0lrNXZJR052Ykd4aGRHVnlZV3dnWW1Gc1lXNWpaU0lLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGcyTXpabU5tTTFaZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCT2J5QmpiMnhzWVhSbGNtRnNJR0poYkdGdVkyVUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1qWTNDaUFnSUNBdkx5QmpkWEp5Wlc1MElEMGdjMlZzWmk1amIyeHNZWFJsY21Gc1czVnpaWEpkTG01aGRHbDJaUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNalk0Q2lBZ0lDQXZMeUJoYzNObGNuUWdZM1Z5Y21WdWRDQStQU0JoYlc5MWJuUXVibUYwYVhabExDQWlTVzV6ZFdabWFXTnBaVzUwSUdOdmJHeGhkR1Z5WVd3aUNpQWdJQ0JrYVdjZ013b2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd01nb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ1kyOXNiR0YwWlhKaGJBb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRveU56QUtJQ0FnSUM4dklITmxiR1l1WTI5c2JHRjBaWEpoYkZ0MWMyVnlYU0E5SUdGeVl6UXVWVWx1ZERZMEtHTjFjbkpsYm5RZ0xTQmhiVzkxYm5RdWJtRjBhWFpsS1FvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUb3lOekl0TWpjMkNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVlXMXZkVzUwTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1qY3pDaUFnSUNBdkx5QnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1qY3lDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qSTNOUW9nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TWpjeUxUSTNOZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQV0Z0YjNWdWRDNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG95TnpndE1qZ3lDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9DaUFnSUNBdkx5QWdJQ0FnSWtOdmJHeGhkR1Z5WVd4WGFYUm9aSEpoZDI0b1lXUmtjbVZ6Y3l4MWFXNTBOalFwSWl3S0lDQWdJQzh2SUNBZ0lDQjFjMlZ5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNrS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlUVXpOR1U0WXpZZ0x5OGdiV1YwYUc5a0lDSkRiMnhzWVhSbGNtRnNWMmwwYUdSeVlYZHVLR0ZrWkhKbGMzTXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qSTFPUzB5TmpJS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QWpJSGRwZEdoa2NtRjNYMk52Ykd4aGRHVnlZV3dLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1UVXhaamRqTnpVNE1Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNURjbVZ6WTJGQ2RXTnJaWFJRY205MGIyTnZiQzV2Y0dWdVgzQnZjMmwwYVc5dVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiM0JsYmw5d2IzTnBkR2x2YmpvS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TWpnMUxUSTRPQW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ2IzQmxibDl3YjNOcGRHbHZiZ29nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPak13TWkwek1ETUtJQ0FnSUM4dklDTWdSVzVtYjNKalpTQnZjbUZqYkdVZ1puSmxjMmh1WlhOeklPS0FsQ0J5WldwbFkzUWdhV1lnYTJWbGNHVnlJR2hoYzI0bmRDQnlkVzRnZDJsMGFHbHVJRTlTUVVOTVJWOU5RVmhmUVVkRklITmxZMjl1WkhNS0lDQWdJQzh2SUdGemMyVnlkQ0JIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDQXRJSE5sYkdZdWIzSmhZMnhsWDNWd1pHRjBaV1JmWVhRdWRtRnNkV1VnUEQwZ1ZVbHVkRFkwS0U5U1FVTk1SVjlOUVZoZlFVZEZLU3dnSWs5eVlXTnNaU0J3Y21salpTQnpkR0ZzWlNJS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p2Y21GamJHVmZkWEJrWVhSbFpGOWhkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmNtRmpiR1ZmZFhCa1lYUmxaRjloZENCbGVHbHpkSE1LSUNBZ0lDMEtJQ0FnSUhCMWMyaHBiblFnTXpBS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUM0poWTJ4bElIQnlhV05sSUhOMFlXeGxDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qTXdOUW9nSUNBZ0x5OGdiM2R1WlhKZllXUmtjaUE5SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvek1EWUtJQ0FnSUM4dklHSnJkRjlyWlhrZ1BTQmZZblZqYTJWMFgydGxlU2hVZUc0dWMyVnVaR1Z5TG1KNWRHVnpMQ0JpZFdOclpYUmZhV1F1Ym1GMGFYWmxLUW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUb3hNRE1LSUNBZ0lDOHZJSEpsZEhWeWJpQmlJbUpyZEY4aUlDc2diM2R1WlhJZ0t5QnZjQzVwZEc5aUtHSjFZMnRsZEY5cFpDa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZzJNalppTnpRMVpnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvek1EY0tJQ0FnSUM4dklHRnpjMlZ5ZENCaWEzUmZhMlY1SUdsdUlITmxiR1l1WW5WamEyVjBjeXdnSWtKMVkydGxkQ0J1YjNRZ1ptOTFibVFpQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVKMVkydGxkQ0J1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNekE1Q2lBZ0lDQXZMeUJpZFdOclpYUWdQU0J6Wld4bUxtSjFZMnRsZEhOYlltdDBYMnRsZVYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TXpFd0NpQWdJQ0F2THlCaGMzTmxjblFnWW5WamEyVjBMbVY0YVhOMGN5NXVZWFJwZG1Vc0lDSkNkV05yWlhRZ2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREUwTURnS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDZFdOclpYUWdibTkwSUdadmRXNWtDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qTXhNUW9nSUNBZ0x5OGdZWE56WlhKMElHSjFZMnRsZEM1dmQyNWxjaUE5UFNCdmQyNWxjbDloWkdSeUxDQWlUbTkwSUhsdmRYSWdZblZqYTJWMElnb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREUwTkNBek1nb2dJQ0FnWkdsbklESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVG05MElIbHZkWElnWW5WamEyVjBDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qTXhNeTB6TVRRS0lDQWdJQzh2SUNNZ1EyaGxZMnNnWTI5c2JHRjBaWEpoYkFvZ0lDQWdMeThnWVhOelpYSjBJRzkzYm1WeVgyRmtaSElnYVc0Z2MyVnNaaTVqYjJ4c1lYUmxjbUZzTENBaVRtOGdZMjlzYkdGMFpYSmhiQ0JpWVd4aGJtTmxJZ29nSUNBZ1lubDBaV01nTmlBdkx5QXdlRFl6Tm1ZMll6Vm1DaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUU1dklHTnZiR3hoZEdWeVlXd2dZbUZzWVc1alpRb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvek1UVUtJQ0FnSUM4dklHTjFjbkpsYm5SZlkyOXNiR0YwWlhKaGJDQTlJSE5sYkdZdVkyOXNiR0YwWlhKaGJGdHZkMjVsY2w5aFpHUnlYUzV1WVhScGRtVUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qTXhOZ29nSUNBZ0x5OGdZWE56WlhKMElHTjFjbkpsYm5SZlkyOXNiR0YwWlhKaGJDQStQU0J0WVhKbmFXNHVibUYwYVhabExDQWlTVzV6ZFdabWFXTnBaVzUwSUdOdmJHeGhkR1Z5WVd3aUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd01nb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ1kyOXNiR0YwWlhKaGJBb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvek1UZ3RNekU1Q2lBZ0lDQXZMeUFqSUVSbFpIVmpkQ0J0WVhKbmFXNGdabkp2YlNCamIyeHNZWFJsY21Gc0NpQWdJQ0F2THlCelpXeG1MbU52Ykd4aGRHVnlZV3hiYjNkdVpYSmZZV1JrY2wwZ1BTQmhjbU0wTGxWSmJuUTJOQ2hqZFhKeVpXNTBYMk52Ykd4aGRHVnlZV3dnTFNCdFlYSm5hVzR1Ym1GMGFYWmxLUW9nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUb3pNakV0TXpJeUNpQWdJQ0F2THlBaklFTmhiR04xYkdGMFpTQjNaV2xuYUhSbFpDQmlZWE5yWlhRZ1pXNTBjbmtnY0hKcFkyVUtJQ0FnSUM4dklHVnVkSEo1WDNCeWFXTmxJRDBnYzJWc1ppNWZZMkZzWTNWc1lYUmxYMkpoYzJ0bGRGOXdjbWxqWlNoaWRXTnJaWFFwQ2lBZ0lDQmpZV3hzYzNWaUlGOWpZV3hqZFd4aGRHVmZZbUZ6YTJWMFgzQnlhV05sQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNekkwTFRNeU5Rb2dJQ0FnTHk4Z0l5QkJjM05wWjI0Z2NHOXphWFJwYjI0Z1NVUWdabkp2YlNCbmJHOWlZV3dnWTI5MWJuUmxjaUIwYnlCclpXVndJR0p2ZUNCMWMyRm5aU0JzYjNjdUNpQWdJQ0F2THlCd2IzTmZhV1FnUFNCelpXeG1MblJ2ZEdGc1gzQnZjMmwwYVc5dWN5NTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblJ2ZEdGc1gzQnZjMmwwYVc5dWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXdiM05wZEdsdmJuTWdaWGhwYzNSekNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pNek1Rb2dJQ0FnTHk4Z1pXNTBjbmxmY0hKcFkyVTlZWEpqTkM1VlNXNTBOalFvWlc1MGNubGZjSEpwWTJVcExBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvek16UUtJQ0FnSUM4dklHOXdaVzVmZEdsdFpYTjBZVzF3UFdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3S1N3S0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TXpJM0xUTXpOUW9nSUNBZ0x5OGdjRzl6SUQwZ1VHOXphWFJwYjI0b0NpQWdJQ0F2THlBZ0lDQWdZblZqYTJWMFgybGtQV0oxWTJ0bGRGOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCcGMxOXNiMjVuUFdselgyeHZibWNzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnlaMmx1UFcxaGNtZHBiaXdLSUNBZ0lDOHZJQ0FnSUNCbGJuUnllVjl3Y21salpUMWhjbU0wTGxWSmJuUTJOQ2hsYm5SeWVWOXdjbWxqWlNrc0NpQWdJQ0F2THlBZ0lDQWdiM2R1WlhJOWIzZHVaWEpmWVdSa2Npd0tJQ0FnSUM4dklDQWdJQ0JoWTNScGRtVTlZWEpqTkM1Q2IyOXNLRlJ5ZFdVcExBb2dJQ0FnTHk4Z0lDQWdJRzl3Wlc1ZmRHbHRaWE4wWVcxd1BXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUdScFp5QTJDaUFnSUNCa2FXY2dOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPak16TXdvZ0lDQWdMeThnWVdOMGFYWmxQV0Z5WXpRdVFtOXZiQ2hVY25WbEtTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3dDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qTXlOeTB6TXpVS0lDQWdJQzh2SUhCdmN5QTlJRkJ2YzJsMGFXOXVLQW9nSUNBZ0x5OGdJQ0FnSUdKMVkydGxkRjlwWkQxaWRXTnJaWFJmYVdRc0NpQWdJQ0F2THlBZ0lDQWdhWE5mYkc5dVp6MXBjMTlzYjI1bkxBb2dJQ0FnTHk4Z0lDQWdJRzFoY21kcGJqMXRZWEpuYVc0c0NpQWdJQ0F2THlBZ0lDQWdaVzUwY25sZmNISnBZMlU5WVhKak5DNVZTVzUwTmpRb1pXNTBjbmxmY0hKcFkyVXBMQW9nSUNBZ0x5OGdJQ0FnSUc5M2JtVnlQVzkzYm1WeVgyRmtaSElzQ2lBZ0lDQXZMeUFnSUNBZ1lXTjBhWFpsUFdGeVl6UXVRbTl2YkNoVWNuVmxLU3dLSUNBZ0lDOHZJQ0FnSUNCdmNHVnVYM1JwYldWemRHRnRjRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRveE1EY0tJQ0FnSUM4dklISmxkSFZ5YmlCaUluQnZjMThpSUNzZ2IzZHVaWElnS3lCdmNDNXBkRzlpS0hCdmMybDBhVzl1WDJsa0tRb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VEY3dObVkzTXpWbUNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pNek5nb2dJQ0FnTHk4Z2MyVnNaaTV3YjNOcGRHbHZibk5iWDNCdmMybDBhVzl1WDJ0bGVTaFVlRzR1YzJWdVpHVnlMbUo1ZEdWekxDQndiM05mYVdRcFhTQTlJSEJ2Y3k1amIzQjVLQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1UQTNDaUFnSUNBdkx5QnlaWFIxY200Z1lpSndiM05mSWlBcklHOTNibVZ5SUNzZ2IzQXVhWFJ2WWlod2IzTnBkR2x2Ymw5cFpDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHbDBiMklLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TXpNMkNpQWdJQ0F2THlCelpXeG1MbkJ2YzJsMGFXOXVjMXRmY0c5emFYUnBiMjVmYTJWNUtGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNc0lIQnZjMTlwWkNsZElEMGdjRzl6TG1OdmNIa29LUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qTXpOd29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl3YjNOcGRHbHZibk11ZG1Gc2RXVWdQU0J6Wld4bUxuUnZkR0ZzWDNCdmMybDBhVzl1Y3k1MllXeDFaU0FySUZWSmJuUTJOQ2d4S1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldNZ055QXZMeUFpZEc5MFlXeGZjRzl6YVhScGIyNXpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNek01TFRNME53b2dJQ0FnTHk4Z1lYSmpOQzVsYldsMEtBb2dJQ0FnTHk4Z0lDQWdJQ0pRYjNOcGRHbHZiazl3Wlc1bFpDaDFhVzUwTmpRc2RXbHVkRFkwTEdGa1pISmxjM01zWW05dmJDeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvY0c5elgybGtLU3dLSUNBZ0lDOHZJQ0FnSUNCaWRXTnJaWFJmYVdRc0NpQWdJQ0F2THlBZ0lDQWdiM2R1WlhKZllXUmtjaXdLSUNBZ0lDOHZJQ0FnSUNCcGMxOXNiMjVuTEFvZ0lDQWdMeThnSUNBZ0lHMWhjbWRwYml3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2hsYm5SeWVWOXdjbWxqWlNrc0NpQWdJQ0F2THlBcENpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RWbVpUWTRPREFnTHk4Z2JXVjBhRzlrSUNKUWIzTnBkR2x2Yms5d1pXNWxaQ2gxYVc1ME5qUXNkV2x1ZERZMExHRmtaSEpsYzNNc1ltOXZiQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qSTROUzB5T0RnS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QWpJRzl3Wlc1ZmNHOXphWFJwYjI0S0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzVEY21WelkyRkNkV05yWlhSUWNtOTBiMk52YkM1amJHOXpaVjl3YjNOcGRHbHZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Oc2IzTmxYM0J2YzJsMGFXOXVPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnWkhWd0NpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pNMU1TMHpOVFFLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlBaklHTnNiM05sWDNCdmMybDBhVzl1Q2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG96TmpBdE16WXhDaUFnSUNBdkx5QWpJRVZ1Wm05eVkyVWdiM0poWTJ4bElHWnlaWE5vYm1WemN3b2dJQ0FnTHk4Z1lYTnpaWEowSUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJQzBnYzJWc1ppNXZjbUZqYkdWZmRYQmtZWFJsWkY5aGRDNTJZV3gxWlNBOFBTQlZTVzUwTmpRb1QxSkJRMHhGWDAxQldGOUJSMFVwTENBaVQzSmhZMnhsSUhCeWFXTmxJSE4wWVd4bElnb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW05eVlXTnNaVjkxY0dSaGRHVmtYMkYwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOXlZV05zWlY5MWNHUmhkR1ZrWDJGMElHVjRhWE4wY3dvZ0lDQWdMUW9nSUNBZ2NIVnphR2x1ZENBek1Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQY21GamJHVWdjSEpwWTJVZ2MzUmhiR1VLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNell6Q2lBZ0lDQXZMeUJ2ZDI1bGNsOWhaR1J5SUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG96TmpRS0lDQWdJQzh2SUhCdmMxOXJaWGtnUFNCZmNHOXphWFJwYjI1ZmEyVjVLRlI0Ymk1elpXNWtaWEl1WW5sMFpYTXNJSEJ2YzJsMGFXOXVYMmxrTG01aGRHbDJaU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1UQTNDaUFnSUNBdkx5QnlaWFIxY200Z1lpSndiM05mSWlBcklHOTNibVZ5SUNzZ2IzQXVhWFJ2WWlod2IzTnBkR2x2Ymw5cFpDa0tJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IZzNNRFptTnpNMVpnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvek5qVUtJQ0FnSUM4dklHRnpjMlZ5ZENCd2IzTmZhMlY1SUdsdUlITmxiR1l1Y0c5emFYUnBiMjV6TENBaVVHOXphWFJwYjI0Z2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFiM05wZEdsdmJpQnViM1FnWm05MWJtUUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk16WTNDaUFnSUNBdkx5QndiM01nUFNCelpXeG1MbkJ2YzJsMGFXOXVjMXR3YjNOZmEyVjVYUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qTTJPQW9nSUNBZ0x5OGdZWE56WlhKMElIQnZjeTVoWTNScGRtVXVibUYwYVhabExDQWlVRzl6YVhScGIyNGdZV3h5WldGa2VTQmpiRzl6WldRaUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTlRZS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJRYjNOcGRHbHZiaUJoYkhKbFlXUjVJR05zYjNObFpBb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvek5qa0tJQ0FnSUM4dklHRnpjMlZ5ZENCd2IzTXViM2R1WlhJZ1BUMGdiM2R1WlhKZllXUmtjaXdnSWs1dmRDQjViM1Z5SUhCdmMybDBhVzl1SWdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElESTFJRE15Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVG05MElIbHZkWElnY0c5emFYUnBiMjRLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNemN4Q2lBZ0lDQXZMeUJpYTNSZmEyVjVJRDBnWDJKMVkydGxkRjlyWlhrb1ZIaHVMbk5sYm1SbGNpNWllWFJsY3l3Z2NHOXpMbUoxWTJ0bGRGOXBaQzV1WVhScGRtVXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURnS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TVRBekNpQWdJQ0F2THlCeVpYUjFjbTRnWWlKaWEzUmZJaUFySUc5M2JtVnlJQ3NnYjNBdWFYUnZZaWhpZFdOclpYUmZhV1FwQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TmpJMllqYzBOV1lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNemN5Q2lBZ0lDQXZMeUJpZFdOclpYUWdQU0J6Wld4bUxtSjFZMnRsZEhOYlltdDBYMnRsZVYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aWRXTnJaWFJ6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvek56TUtJQ0FnSUM4dklHVjRhWFJmY0hKcFkyVWdQU0J6Wld4bUxsOWpZV3hqZFd4aGRHVmZZbUZ6YTJWMFgzQnlhV05sS0dKMVkydGxkQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gyTmhiR04xYkdGMFpWOWlZWE5yWlhSZmNISnBZMlVLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNemMxQ2lBZ0lDQXZMeUJ3Ym14ZllXSnpJRDBnYzJWc1ppNWZZMkZzWTNWc1lYUmxYM0J1YkY5aFluTW9jRzl6TENCbGVHbDBYM0J5YVdObExDQmlkV05yWlhRdWJHVjJaWEpoWjJVdWJtRjBhWFpsS1FvZ0lDQWdhVzUwWXlBMUlDOHZJREV6TmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJmWTJGc1kzVnNZWFJsWDNCdWJGOWhZbk1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TXpjMkNpQWdJQ0F2THlCcGMxOXdjbTltYVhRZ1BTQnpaV3htTGw5cGMxOXdjbTltYVhRb2NHOXpMQ0JsZUdsMFgzQnlhV05sS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQmZhWE5mY0hKdlptbDBDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TXpnd0NpQWdJQ0F2THlCaWRXTnJaWFJmYVdROWNHOXpMbUoxWTJ0bGRGOXBaQ3dLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lEZ0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk16Z3hDaUFnSUNBdkx5QnBjMTlzYjI1blBYQnZjeTVwYzE5c2IyNW5MQW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk16Z3lDaUFnSUNBdkx5QnRZWEpuYVc0OWNHOXpMbTFoY21kcGJpd0tJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURrZ09Bb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvek9ETUtJQ0FnSUM4dklHVnVkSEo1WDNCeWFXTmxQWEJ2Y3k1bGJuUnllVjl3Y21salpTd0tJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURFM0lEZ0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk16ZzBDaUFnSUNBdkx5QnZkMjVsY2oxd2IzTXViM2R1WlhJc0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWlhoMGNtRmpkQ0F5TlNBek1nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvek9EWUtJQ0FnSUM4dklHOXdaVzVmZEdsdFpYTjBZVzF3UFhCdmN5NXZjR1Z1WDNScGJXVnpkR0Z0Y0N3S0lDQWdJR1JwWnlBMUNpQWdJQ0JsZUhSeVlXTjBJRFU0SURnS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TXpjNExUTTROd29nSUNBZ0x5OGdJeUJOWVhKcklHTnNiM05sWkFvZ0lDQWdMeThnYzJWc1ppNXdiM05wZEdsdmJuTmJjRzl6WDJ0bGVWMGdQU0JRYjNOcGRHbHZiaWdLSUNBZ0lDOHZJQ0FnSUNCaWRXTnJaWFJmYVdROWNHOXpMbUoxWTJ0bGRGOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCcGMxOXNiMjVuUFhCdmN5NXBjMTlzYjI1bkxBb2dJQ0FnTHk4Z0lDQWdJRzFoY21kcGJqMXdiM011YldGeVoybHVMQW9nSUNBZ0x5OGdJQ0FnSUdWdWRISjVYM0J5YVdObFBYQnZjeTVsYm5SeWVWOXdjbWxqWlN3S0lDQWdJQzh2SUNBZ0lDQnZkMjVsY2oxd2IzTXViM2R1WlhJc0NpQWdJQ0F2THlBZ0lDQWdZV04wYVhabFBXRnlZelF1UW05dmJDaEdZV3h6WlNrc0NpQWdJQ0F2THlBZ0lDQWdiM0JsYmw5MGFXMWxjM1JoYlhBOWNHOXpMbTl3Wlc1ZmRHbHRaWE4wWVcxd0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG96T0RVS0lDQWdJQzh2SUdGamRHbDJaVDFoY21NMExrSnZiMndvUm1Gc2MyVXBMQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPak0zT0Mwek9EY0tJQ0FnSUM4dklDTWdUV0Z5YXlCamJHOXpaV1FLSUNBZ0lDOHZJSE5sYkdZdWNHOXphWFJwYjI1elczQnZjMTlyWlhsZElEMGdVRzl6YVhScGIyNG9DaUFnSUNBdkx5QWdJQ0FnWW5WamEyVjBYMmxrUFhCdmN5NWlkV05yWlhSZmFXUXNDaUFnSUNBdkx5QWdJQ0FnYVhOZmJHOXVaejF3YjNNdWFYTmZiRzl1Wnl3S0lDQWdJQzh2SUNBZ0lDQnRZWEpuYVc0OWNHOXpMbTFoY21kcGJpd0tJQ0FnSUM4dklDQWdJQ0JsYm5SeWVWOXdjbWxqWlQxd2IzTXVaVzUwY25sZmNISnBZMlVzQ2lBZ0lDQXZMeUFnSUNBZ2IzZHVaWEk5Y0c5ekxtOTNibVZ5TEFvZ0lDQWdMeThnSUNBZ0lHRmpkR2wyWlQxaGNtTTBMa0p2YjJ3b1JtRnNjMlVwTEFvZ0lDQWdMeThnSUNBZ0lHOXdaVzVmZEdsdFpYTjBZVzF3UFhCdmN5NXZjR1Z1WDNScGJXVnpkR0Z0Y0N3S0lDQWdJQzh2SUNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk16Z3lDaUFnSUNBdkx5QnRZWEpuYVc0OWNHOXpMbTFoY21kcGJpd0tJQ0FnSUhCMWMyaHBiblFnT1FvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG96T0RrdE16a3dDaUFnSUNBdkx5QWpJRkpsZEhWeWJpQnRZWEpuYVc0Z3dyRWdVQ1pNSUhSdklHTnZiR3hoZEdWeVlXd0tJQ0FnSUM4dklHMWhjbWRwYmw5MllXd2dQU0J3YjNNdWJXRnlaMmx1TG01aGRHbDJaUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZNemt4Q2lBZ0lDQXZMeUJwWmlCcGMxOXdjbTltYVhRNkNpQWdJQ0JpZWlCamJHOXpaVjl3YjNOcGRHbHZibDlsYkhObFgySnZaSGxBTXdvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG96T1RJS0lDQWdJQzh2SUhKbGRIVnlibDloYlc5MWJuUWdQU0J0WVhKbmFXNWZkbUZzSUNzZ2NHNXNYMkZpY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdLd29nSUNBZ1luVnllU0EyQ2dwamJHOXpaVjl3YjNOcGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFEYzZDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qTTVOZ29nSUNBZ0x5OGdZM1Z5Y21WdWRGOWpiMndnUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlkWEo1SURjS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TXprM0NpQWdJQ0F2THlCcFppQnZkMjVsY2w5aFpHUnlJR2x1SUhObGJHWXVZMjlzYkdGMFpYSmhiRG9LSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGcyTXpabU5tTTFaZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dZMnh2YzJWZmNHOXphWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUE1Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPak01T0FvZ0lDQWdMeThnWTNWeWNtVnVkRjlqYjJ3Z1BTQnpaV3htTG1OdmJHeGhkR1Z5WVd4YmIzZHVaWEpmWVdSa2NsMHVibUYwYVhabENpQWdJQ0JrYVdjZ053b2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMjlzYkdGMFpYSmhiQ0JsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJR0owYjJrS0lDQWdJR0oxY25rZ053b0tZMnh2YzJWZmNHOXphWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUE1T2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG96T1RrS0lDQWdJQzh2SUhObGJHWXVZMjlzYkdGMFpYSmhiRnR2ZDI1bGNsOWhaR1J5WFNBOUlHRnlZelF1VlVsdWREWTBLR04xY25KbGJuUmZZMjlzSUNzZ2NtVjBkWEp1WDJGdGIzVnVkQ2tLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmthV2NnTmdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRGdLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TkRBMUNpQWdJQ0F2THlCaGNtTTBMbFZKYm5RMk5DaHdibXhmWVdKektTd0tJQ0FnSUdScFp5QXlDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qUXdOZ29nSUNBZ0x5OGdZWEpqTkM1Q2IyOXNLR2x6WDNCeWIyWnBkQ2tzQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdjMlYwWW1sMENpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pRd01TMDBNRGNLSUNBZ0lDOHZJR0Z5WXpRdVpXMXBkQ2dLSUNBZ0lDOHZJQ0FnSUNBaVVHOXphWFJwYjI1RGJHOXpaV1FvZFdsdWREWTBMR0ZrWkhKbGMzTXNkV2x1ZERZMExHSnZiMndwSWl3S0lDQWdJQzh2SUNBZ0lDQndiM05wZEdsdmJsOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCdmQyNWxjbDloWkdSeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hCdWJGOWhZbk1wTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1UW05dmJDaHBjMTl3Y205bWFYUXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1pHbG5JRFlLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPVFF6TmpZMllUTWdMeThnYldWMGFHOWtJQ0pRYjNOcGRHbHZia05zYjNObFpDaDFhVzUwTmpRc1lXUmtjbVZ6Y3l4MWFXNTBOalFzWW05dmJDa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUb3pOVEV0TXpVMENpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdJeUJqYkc5elpWOXdiM05wZEdsdmJnb2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21Oc2IzTmxYM0J2YzJsMGFXOXVYMlZzYzJWZlltOWtlVUF6T2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG96T1RRS0lDQWdJQzh2SUhKbGRIVnlibDloYlc5MWJuUWdQU0J0WVhKbmFXNWZkbUZzSUMwZ2NHNXNYMkZpY3lCcFppQnRZWEpuYVc1ZmRtRnNJRDRnY0c1c1gyRmljeUJsYkhObElGVkpiblEyTkNnd0tRb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ013b2dJQ0FnUGdvZ0lDQWdZbm9nWTJ4dmMyVmZjRzl6YVhScGIyNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMUNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBekNpQWdJQ0F0Q2lBZ0lDQmlkWEo1SURZS0lDQWdJR0lnWTJ4dmMyVmZjRzl6YVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBM0NncGpiRzl6WlY5d2IzTnBkR2x2Ymw5MFpYSnVZWEo1WDJaaGJITmxRRFU2Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPak01TkFvZ0lDQWdMeThnY21WMGRYSnVYMkZ0YjNWdWRDQTlJRzFoY21kcGJsOTJZV3dnTFNCd2JteGZZV0p6SUdsbUlHMWhjbWRwYmw5MllXd2dQaUJ3Ym14ZllXSnpJR1ZzYzJVZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0JpSUdOc2IzTmxYM0J2YzJsMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU53b0tDaTh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VRM0psYzJOaFFuVmphMlYwVUhKdmRHOWpiMnd1Y21WaVlXeGhibU5sWDJKMVkydGxkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFltRnNZVzVqWlY5aWRXTnJaWFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pIVndiaUF4TkFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8wTVRFdE5ERTBDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnSXlCeVpXSmhiR0Z1WTJWZlluVmphMlYwQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRFkwUGdvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8wTWpFS0lDQWdJQzh2SUdKcmRGOXJaWGtnUFNCZlluVmphMlYwWDJ0bGVTaFVlRzR1YzJWdVpHVnlMbUo1ZEdWekxDQmlkV05yWlhSZmFXUXVibUYwYVhabEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qRXdNd29nSUNBZ0x5OGdjbVYwZFhKdUlHSWlZbXQwWHlJZ0t5QnZkMjVsY2lBcklHOXdMbWwwYjJJb1luVmphMlYwWDJsa0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEWXlObUkzTkRWbUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5ESXlDaUFnSUNBdkx5QmhjM05sY25RZ1ltdDBYMnRsZVNCcGJpQnpaV3htTG1KMVkydGxkSE1zSUNKQ2RXTnJaWFFnYm05MElHWnZkVzVrSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2RXTnJaWFFnYm05MElHWnZkVzVrQ2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPalF5TkFvZ0lDQWdMeThnWW5WamEyVjBJRDBnYzJWc1ppNWlkV05yWlhSelcySnJkRjlyWlhsZExtTnZjSGtvS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5ESTFDaUFnSUNBdkx5QmhjM05sY25RZ1luVmphMlYwTG05M2JtVnlJRDA5SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dnSWs1dmRDQjViM1Z5SUdKMVkydGxkQ0lLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeE5EUWdNeklLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCT2IzUWdlVzkxY2lCaWRXTnJaWFFLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZOREkyQ2lBZ0lDQXZMeUJoYzNObGNuUWdibVYzWDNkbGFXZG9kSE11YkdWdVozUm9JRDA5SUdKMVkydGxkQzVoYzNObGRGOWpiM1Z1ZEM1dVlYUnBkbVVzSUNKWFpXbG5hSFFnWTI5MWJuUWdiV2x6YldGMFkyZ2lDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTVRJNElEZ0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ01USTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCWFpXbG5hSFFnWTI5MWJuUWdiV2x6YldGMFkyZ0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5ESTRDaUFnSUNBdkx5QjBiM1JoYkY5M1pXbG5hSFFnUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPalF5T1FvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLRzVsZDE5M1pXbG5hSFJ6TG14bGJtZDBhQ2s2Q2lBZ0lDQmtkWEFLQ25KbFltRnNZVzVqWlY5aWRXTnJaWFJmWm05eVgyaGxZV1JsY2tBeU9nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvME1qa0tJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNodVpYZGZkMlZwWjJoMGN5NXNaVzVuZEdncE9nb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ053b2dJQ0FnUEFvZ0lDQWdZbm9nY21WaVlXeGhibU5sWDJKMVkydGxkRjloWm5SbGNsOW1iM0pBTlFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8wTXpBS0lDQWdJQzh2SUhSdmRHRnNYM2RsYVdkb2RDQTlJSFJ2ZEdGc1gzZGxhV2RvZENBcklHNWxkMTkzWldsbmFIUnpXMmxkTG01aGRHbDJaUW9nSUNBZ1pHbG5JRGNLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXpDaUFnSUNBckNpQWdJQ0JpZFhKNUlETUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5ESTVDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2JtVjNYM2RsYVdkb2RITXViR1Z1WjNSb0tUb0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0lnY21WaVlXeGhibU5sWDJKMVkydGxkRjltYjNKZmFHVmhaR1Z5UURJS0NuSmxZbUZzWVc1alpWOWlkV05yWlhSZllXWjBaWEpmWm05eVFEVTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qUXpNUW9nSUNBZ0x5OGdZWE56WlhKMElIUnZkR0ZzWDNkbGFXZG9kQ0E5UFNCVlNXNTBOalFvTVRBd0tTd2dJbGRsYVdkb2RITWdiWFZ6ZENCemRXMGdkRzhnTVRBd0lnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTVRBd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRmRsYVdkb2RITWdiWFZ6ZENCemRXMGdkRzhnTVRBd0NpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pRek5Bb2dJQ0FnTHk4Z1lYTnpaWFF3UFdKMVkydGxkQzVoYzNObGREQXNJR0Z6YzJWME1UMWlkV05yWlhRdVlYTnpaWFF4TEFvZ0lDQWdaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRGdLSUNBZ0lHSjFjbmtnTWpVS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTRJRGdLSUNBZ0lHSjFjbmtnTWpRS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TkRNMUNpQWdJQ0F2THlCaGMzTmxkREk5WW5WamEyVjBMbUZ6YzJWME1pd2dZWE56WlhRelBXSjFZMnRsZEM1aGMzTmxkRE1zQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01UWWdPQW9nSUNBZ1luVnllU0F5TXdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElESTBJRGdLSUNBZ0lHSjFjbmtnTWpJS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TkRNMkNpQWdJQ0F2THlCaGMzTmxkRFE5WW5WamEyVjBMbUZ6YzJWME5Dd2dZWE56WlhRMVBXSjFZMnRsZEM1aGMzTmxkRFVzQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ016SWdPQW9nSUNBZ1luVnllU0F5TVFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUXdJRGdLSUNBZ0lHSjFjbmtnTWpBS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TkRNM0NpQWdJQ0F2THlCaGMzTmxkRFk5WW5WamEyVjBMbUZ6YzJWME5pd2dZWE56WlhRM1BXSjFZMnRsZEM1aGMzTmxkRGNzQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05EZ2dPQW9nSUNBZ1luVnllU0F4T1FvZ0lDQWdaWGgwY21GamRDQTFOaUE0Q2lBZ0lDQmlkWEo1SURFM0NpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pRek9Bb2dJQ0FnTHk4Z2QyVnBaMmgwTUQxdVpYZGZkMlZwWjJoMGMxc3dYU0JwWmlCdVpYZGZkMlZwWjJoMGN5NXNaVzVuZEdnZ1BpQlZTVzUwTmpRb01Da2daV3h6WlNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmllaUJ5WldKaGJHRnVZMlZmWW5WamEyVjBYM1JsY201aGNubGZabUZzYzJWQU53b2dJQ0FnWkdsbklEY0tJQ0FnSUdWNGRISmhZM1FnTWlBNENpQWdJQ0JpZFhKNUlERTJDZ3B5WldKaGJHRnVZMlZmWW5WamEyVjBYM1JsY201aGNubGZiV1Z5WjJWQU9Eb0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5ETTVDaUFnSUNBdkx5QjNaV2xuYUhReFBXNWxkMTkzWldsbmFIUnpXekZkSUdsbUlHNWxkMTkzWldsbmFIUnpMbXhsYm1kMGFDQStJRlZKYm5RMk5DZ3hLU0JsYkhObElHRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdaR2xuSURZS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQStDaUFnSUNCaWVpQnlaV0poYkdGdVkyVmZZblZqYTJWMFgzUmxjbTVoY25sZlptRnNjMlZBTVRBS0lDQWdJR1JwWnlBM0NpQWdJQ0JsZUhSeVlXTjBJREV3SURnS0lDQWdJR0oxY25rZ01UVUtDbkpsWW1Gc1lXNWpaVjlpZFdOclpYUmZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1Ub0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5EUXdDaUFnSUNBdkx5QjNaV2xuYUhReVBXNWxkMTkzWldsbmFIUnpXekpkSUdsbUlHNWxkMTkzWldsbmFIUnpMbXhsYm1kMGFDQStJRlZKYm5RMk5DZ3lLU0JsYkhObElHRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdaR2xuSURZS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQStDaUFnSUNCaWVpQnlaV0poYkdGdVkyVmZZblZqYTJWMFgzUmxjbTVoY25sZlptRnNjMlZBTVRNS0lDQWdJR1JwWnlBM0NpQWdJQ0JsZUhSeVlXTjBJREU0SURnS0lDQWdJR0oxY25rZ01UUUtDbkpsWW1Gc1lXNWpaVjlpZFdOclpYUmZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5Eb0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5EUXhDaUFnSUNBdkx5QjNaV2xuYUhRelBXNWxkMTkzWldsbmFIUnpXek5kSUdsbUlHNWxkMTkzWldsbmFIUnpMbXhsYm1kMGFDQStJRlZKYm5RMk5DZ3pLU0JsYkhObElHRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdaR2xuSURZS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1Bnb2dJQ0FnWW5vZ2NtVmlZV3hoYm1ObFgySjFZMnRsZEY5MFpYSnVZWEo1WDJaaGJITmxRREUyQ2lBZ0lDQmthV2NnTndvZ0lDQWdaWGgwY21GamRDQXlOaUE0Q2lBZ0lDQmlkWEo1SURFekNncHlaV0poYkdGdVkyVmZZblZqYTJWMFgzUmxjbTVoY25sZmJXVnlaMlZBTVRjNkNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pRME1nb2dJQ0FnTHk4Z2QyVnBaMmgwTkQxdVpYZGZkMlZwWjJoMGMxczBYU0JwWmlCdVpYZGZkMlZwWjJoMGN5NXNaVzVuZEdnZ1BpQlZTVzUwTmpRb05Da2daV3h6WlNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lHUnBaeUEyQ2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUQ0S0lDQWdJR0o2SUhKbFltRnNZVzVqWlY5aWRXTnJaWFJmZEdWeWJtRnllVjltWVd4elpVQXhPUW9nSUNBZ1pHbG5JRGNLSUNBZ0lHVjRkSEpoWTNRZ016UWdPQW9nSUNBZ1luVnllU0F4TWdvS2NtVmlZV3hoYm1ObFgySjFZMnRsZEY5MFpYSnVZWEo1WDIxbGNtZGxRREl3T2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8wTkRNS0lDQWdJQzh2SUhkbGFXZG9kRFU5Ym1WM1gzZGxhV2RvZEhOYk5WMGdhV1lnYm1WM1gzZGxhV2RvZEhNdWJHVnVaM1JvSUQ0Z1ZVbHVkRFkwS0RVcElHVnNjMlVnWVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNCa2FXY2dOZ29nSUNBZ2NIVnphR2x1ZENBMUNpQWdJQ0ErQ2lBZ0lDQmllaUJ5WldKaGJHRnVZMlZmWW5WamEyVjBYM1JsY201aGNubGZabUZzYzJWQU1qSUtJQ0FnSUdScFp5QTNDaUFnSUNCbGVIUnlZV04wSURReUlEZ0tJQ0FnSUdKMWNua2dNVEVLQ25KbFltRnNZVzVqWlY5aWRXTnJaWFJmZEdWeWJtRnllVjl0WlhKblpVQXlNem9LSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZORFEwQ2lBZ0lDQXZMeUIzWldsbmFIUTJQVzVsZDE5M1pXbG5hSFJ6V3paZElHbG1JRzVsZDE5M1pXbG5hSFJ6TG14bGJtZDBhQ0ErSUZWSmJuUTJOQ2cyS1NCbGJITmxJR0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnWkdsbklEWUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdQZ29nSUNBZ1lub2djbVZpWVd4aGJtTmxYMkoxWTJ0bGRGOTBaWEp1WVhKNVgyWmhiSE5sUURJMUNpQWdJQ0JrYVdjZ053b2dJQ0FnWlhoMGNtRmpkQ0ExTUNBNENpQWdJQ0JpZFhKNUlERXdDZ3B5WldKaGJHRnVZMlZmWW5WamEyVjBYM1JsY201aGNubGZiV1Z5WjJWQU1qWTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qUTBOUW9nSUNBZ0x5OGdkMlZwWjJoME56MXVaWGRmZDJWcFoyaDBjMXMzWFNCcFppQnVaWGRmZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9OeWtnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJR1JwWnlBMkNpQWdJQ0J3ZFhOb2FXNTBJRGNLSUNBZ0lENEtJQ0FnSUdKNklISmxZbUZzWVc1alpWOWlkV05yWlhSZmRHVnlibUZ5ZVY5bVlXeHpaVUF5T0FvZ0lDQWdaR2xuSURjS0lDQWdJR1Y0ZEhKaFkzUWdOVGdnT0FvS2NtVmlZV3hoYm1ObFgySjFZMnRsZEY5MFpYSnVZWEo1WDIxbGNtZGxRREk1T2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8wTkRjS0lDQWdJQzh2SUd4bGRtVnlZV2RsUFdKMVkydGxkQzVzWlhabGNtRm5aU3dLSUNBZ0lHUnBaeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01UTTJJRGdLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZORFE1Q2lBZ0lDQXZMeUJsZUdsemRITTlZblZqYTJWMExtVjRhWE4wY3l3S0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdNVFF3T0FvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8wTXpNdE5EVXdDaUFnSUNBdkx5QnpaV3htTG1KMVkydGxkSE5iWW10MFgydGxlVjBnUFNCQ2RXTnJaWFFvQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFF3UFdKMVkydGxkQzVoYzNObGREQXNJR0Z6YzJWME1UMWlkV05yWlhRdVlYTnpaWFF4TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwTWoxaWRXTnJaWFF1WVhOelpYUXlMQ0JoYzNObGRETTlZblZqYTJWMExtRnpjMlYwTXl3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZERROVluVmphMlYwTG1GemMyVjBOQ3dnWVhOelpYUTFQV0oxWTJ0bGRDNWhjM05sZERVc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhRMlBXSjFZMnRsZEM1aGMzTmxkRFlzSUdGemMyVjBOejFpZFdOclpYUXVZWE56WlhRM0xBb2dJQ0FnTHk4Z0lDQWdJSGRsYVdkb2REQTlibVYzWDNkbGFXZG9kSE5iTUYwZ2FXWWdibVYzWDNkbGFXZG9kSE11YkdWdVozUm9JRDRnVlVsdWREWTBLREFwSUdWc2MyVWdZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdkMlZwWjJoME1UMXVaWGRmZDJWcFoyaDBjMXN4WFNCcFppQnVaWGRmZDJWcFoyaDBjeTVzWlc1bmRHZ2dQaUJWU1c1ME5qUW9NU2tnWld4elpTQmhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjNaV2xuYUhReVBXNWxkMTkzWldsbmFIUnpXekpkSUdsbUlHNWxkMTkzWldsbmFIUnpMbXhsYm1kMGFDQStJRlZKYm5RMk5DZ3lLU0JsYkhObElHRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIZGxhV2RvZERNOWJtVjNYM2RsYVdkb2RITmJNMTBnYVdZZ2JtVjNYM2RsYVdkb2RITXViR1Z1WjNSb0lENGdWVWx1ZERZMEtETXBJR1ZzYzJVZ1lYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2QyVnBaMmgwTkQxdVpYZGZkMlZwWjJoMGMxczBYU0JwWmlCdVpYZGZkMlZwWjJoMGN5NXNaVzVuZEdnZ1BpQlZTVzUwTmpRb05Da2daV3h6WlNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCM1pXbG5hSFExUFc1bGQxOTNaV2xuYUhSeld6VmRJR2xtSUc1bGQxOTNaV2xuYUhSekxteGxibWQwYUNBK0lGVkpiblEyTkNnMUtTQmxiSE5sSUdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUhkbGFXZG9kRFk5Ym1WM1gzZGxhV2RvZEhOYk5sMGdhV1lnYm1WM1gzZGxhV2RvZEhNdWJHVnVaM1JvSUQ0Z1ZVbHVkRFkwS0RZcElHVnNjMlVnWVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZDJWcFoyaDBOejF1WlhkZmQyVnBaMmgwYzFzM1hTQnBaaUJ1WlhkZmQyVnBaMmgwY3k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTnlrZ1pXeHpaU0JoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWpiM1Z1ZEQxaWRXTnJaWFF1WVhOelpYUmZZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdiR1YyWlhKaFoyVTlZblZqYTJWMExteGxkbVZ5WVdkbExBb2dJQ0FnTHk4Z0lDQWdJRzkzYm1WeVBXSjFZMnRsZEM1dmQyNWxjaXdLSUNBZ0lDOHZJQ0FnSUNCbGVHbHpkSE05WW5WamEyVjBMbVY0YVhOMGN5d0tJQ0FnSUM4dklDa0tJQ0FnSUdScFp5QXlOZ29nSUNBZ1pHbG5JREkyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeU5Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNalFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWpFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4T1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREUzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeE5nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEWUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZORFV5Q2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvSWtKMVkydGxkRkpsWW1Gc1lXNWpaV1FvZFdsdWREWTBMSFZwYm5RMk5GdGRLU0lzSUdKMVkydGxkRjlwWkN3Z2JtVjNYM2RsYVdkb2RITXBDaUFnSUNCa2FXY2dPQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3WVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGlZbVZqWWpaa055QXZMeUJ0WlhSb2IyUWdJa0oxWTJ0bGRGSmxZbUZzWVc1alpXUW9kV2x1ZERZMExIVnBiblEyTkZ0ZEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qUXhNUzAwTVRRS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QWpJSEpsWW1Gc1lXNWpaVjlpZFdOclpYUUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TVRVeFpqZGpOelU0TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dweVpXSmhiR0Z1WTJWZlluVmphMlYwWDNSbGNtNWhjbmxmWm1Gc2MyVkFNamc2Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPalEwTlFvZ0lDQWdMeThnZDJWcFoyaDBOejF1WlhkZmQyVnBaMmgwYzFzM1hTQnBaaUJ1WlhkZmQyVnBaMmgwY3k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTnlrZ1pXeHpaU0JoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSUhKbFltRnNZVzVqWlY5aWRXTnJaWFJmZEdWeWJtRnllVjl0WlhKblpVQXlPUW9LY21WaVlXeGhibU5sWDJKMVkydGxkRjkwWlhKdVlYSjVYMlpoYkhObFFESTFPZ29nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzBORFFLSUNBZ0lDOHZJSGRsYVdkb2REWTlibVYzWDNkbGFXZG9kSE5iTmwwZ2FXWWdibVYzWDNkbGFXZG9kSE11YkdWdVozUm9JRDRnVlVsdWREWTBLRFlwSUdWc2MyVWdZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZblZ5ZVNBeE1Bb2dJQ0FnWWlCeVpXSmhiR0Z1WTJWZlluVmphMlYwWDNSbGNtNWhjbmxmYldWeVoyVkFNallLQ25KbFltRnNZVzVqWlY5aWRXTnJaWFJmZEdWeWJtRnllVjltWVd4elpVQXlNam9LSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZORFF6Q2lBZ0lDQXZMeUIzWldsbmFIUTFQVzVsZDE5M1pXbG5hSFJ6V3pWZElHbG1JRzVsZDE5M1pXbG5hSFJ6TG14bGJtZDBhQ0ErSUZWSmJuUTJOQ2cxS1NCbGJITmxJR0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0oxY25rZ01URUtJQ0FnSUdJZ2NtVmlZV3hoYm1ObFgySjFZMnRsZEY5MFpYSnVZWEo1WDIxbGNtZGxRREl6Q2dweVpXSmhiR0Z1WTJWZlluVmphMlYwWDNSbGNtNWhjbmxmWm1Gc2MyVkFNVGs2Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPalEwTWdvZ0lDQWdMeThnZDJWcFoyaDBORDF1WlhkZmQyVnBaMmgwYzFzMFhTQnBaaUJ1WlhkZmQyVnBaMmgwY3k1c1pXNW5kR2dnUGlCVlNXNTBOalFvTkNrZ1pXeHpaU0JoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpZFhKNUlERXlDaUFnSUNCaUlISmxZbUZzWVc1alpWOWlkV05yWlhSZmRHVnlibUZ5ZVY5dFpYSm5aVUF5TUFvS2NtVmlZV3hoYm1ObFgySjFZMnRsZEY5MFpYSnVZWEo1WDJaaGJITmxRREUyT2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8wTkRFS0lDQWdJQzh2SUhkbGFXZG9kRE05Ym1WM1gzZGxhV2RvZEhOYk0xMGdhV1lnYm1WM1gzZGxhV2RvZEhNdWJHVnVaM1JvSUQ0Z1ZVbHVkRFkwS0RNcElHVnNjMlVnWVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWW5WeWVTQXhNd29nSUNBZ1lpQnlaV0poYkdGdVkyVmZZblZqYTJWMFgzUmxjbTVoY25sZmJXVnlaMlZBTVRjS0NuSmxZbUZzWVc1alpWOWlkV05yWlhSZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TXpvS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TkRRd0NpQWdJQ0F2THlCM1pXbG5hSFF5UFc1bGQxOTNaV2xuYUhSeld6SmRJR2xtSUc1bGQxOTNaV2xuYUhSekxteGxibWQwYUNBK0lGVkpiblEyTkNneUtTQmxiSE5sSUdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdKMWNua2dNVFFLSUNBZ0lHSWdjbVZpWVd4aGJtTmxYMkoxWTJ0bGRGOTBaWEp1WVhKNVgyMWxjbWRsUURFMENncHlaV0poYkdGdVkyVmZZblZqYTJWMFgzUmxjbTVoY25sZlptRnNjMlZBTVRBNkNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pRek9Rb2dJQ0FnTHk4Z2QyVnBaMmgwTVQxdVpYZGZkMlZwWjJoMGMxc3hYU0JwWmlCdVpYZGZkMlZwWjJoMGN5NXNaVzVuZEdnZ1BpQlZTVzUwTmpRb01Ta2daV3h6WlNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaWRYSjVJREUxQ2lBZ0lDQmlJSEpsWW1Gc1lXNWpaVjlpZFdOclpYUmZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1Rb0tjbVZpWVd4aGJtTmxYMkoxWTJ0bGRGOTBaWEp1WVhKNVgyWmhiSE5sUURjNkNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pRek9Bb2dJQ0FnTHk4Z2QyVnBaMmgwTUQxdVpYZGZkMlZwWjJoMGMxc3dYU0JwWmlCdVpYZGZkMlZwWjJoMGN5NXNaVzVuZEdnZ1BpQlZTVzUwTmpRb01Da2daV3h6WlNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaWRYSjVJREUyQ2lBZ0lDQmlJSEpsWW1Gc1lXNWpaVjlpZFdOclpYUmZkR1Z5Ym1GeWVWOXRaWEpuWlVBNENnb0tMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNURjbVZ6WTJGQ2RXTnJaWFJRY205MGIyTnZiQzUxY0dSaGRHVmZiM0poWTJ4bFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkWEJrWVhSbFgyOXlZV05zWlRvS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TkRVMUxUUTFPQW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ2RYQmtZWFJsWDI5eVlXTnNaU0FnS0cxdlkyc2c0b0NVSUhKbGNHeGhZMlVnZDJsMGFDQlFlWFJvSUdsdUlIQnliMlIxWTNScGIyNHBDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBcUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblEyTkQ0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBOalErQ2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPalEzTUFvZ0lDQWdMeThnWVhOelpYSjBJR0Z6YzJWMFgybGtjeTVzWlc1bmRHZ2dQVDBnWVhOelpYUmZjSEpwWTJWekxteGxibWQwYUN3Z0lreGxibWQwYUNCdGFYTnRZWFJqYUNJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUR1Z1WjNSb0lHMXBjMjFoZEdOb0NpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pRM01nb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0dGemMyVjBYMmxrY3k1c1pXNW5kR2dwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ25Wd1pHRjBaVjl2Y21GamJHVmZabTl5WDJobFlXUmxja0F5T2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8wTnpJS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2hoYzNObGRGOXBaSE11YkdWdVozUm9LVG9LSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lEd0tJQ0FnSUdKNklIVndaR0YwWlY5dmNtRmpiR1ZmWVdaMFpYSmZabTl5UURVS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TkRjekNpQWdJQ0F2THlCaGMzTmxkRjlwWkNBOUlHRnpjMlYwWDJsa2MxdHBYUzV1WVhScGRtVUtJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNvS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pRM05Bb2dJQ0FnTHk4Z2NISnBZMlVnUFNCaGMzTmxkRjl3Y21salpYTmJhVjB1Ym1GMGFYWmxDaUFnSUNCa2FXY2dOQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG94TVRFS0lDQWdJQzh2SUhKbGRIVnliaUJpSW5CeVkxOGlJQ3NnYjNBdWFYUnZZaWhoYzNObGRGOXBaQ2tLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJREI0TnpBM01qWXpOV1lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TkRjNENpQWdJQ0F2THlCMGFXMWxjM1JoYlhBOVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvME56WXRORGM1Q2lBZ0lDQXZMeUJ6Wld4bUxuQnlhV05sYzF0d2EyVjVYU0E5SUZCeWFXTmxSR0YwWVNnS0lDQWdJQzh2SUNBZ0lDQndjbWxqWlQxaGNtTTBMbFZKYm5RMk5DaHdjbWxqWlNrc0NpQWdJQ0F2THlBZ0lDQWdkR2x0WlhOMFlXMXdQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5EZ3dMVFE0TkFvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0FvZ0lDQWdMeThnSUNBZ0lDSlBjbUZqYkdWVmNHUmhkR1ZrS0hWcGJuUTJOQ3gxYVc1ME5qUXBJaXdLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaGhjM05sZEY5cFpDa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2NISnBZMlVwTEFvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd05qRmhaV0l5TlNBdkx5QnRaWFJvYjJRZ0lrOXlZV05zWlZWd1pHRjBaV1FvZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzBOeklLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaGhjM05sZEY5cFpITXViR1Z1WjNSb0tUb0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0lnZFhCa1lYUmxYMjl5WVdOc1pWOW1iM0pmYUdWaFpHVnlRRElLQ25Wd1pHRjBaVjl2Y21GamJHVmZZV1owWlhKZlptOXlRRFU2Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPalE0TmkwME9EY0tJQ0FnSUM4dklDTWdVbVZqYjNKa0lIUm9aU0IwYVcxbGMzUmhiWEFnYzI4Z2IzQmxiaTlqYkc5elpTQmpZVzRnWlc1bWIzSmpaU0JtY21WemFHNWxjM01LSUNBZ0lDOHZJSE5sYkdZdWIzSmhZMnhsWDNWd1pHRjBaV1JmWVhRdWRtRnNkV1VnUFNCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQW9nSUNBZ1lubDBaV05mTXlBdkx5QWliM0poWTJ4bFgzVndaR0YwWldSZllYUWlDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzBOVFV0TkRVNENpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdJeUIxY0dSaGRHVmZiM0poWTJ4bElDQW9iVzlqYXlEaWdKUWdjbVZ3YkdGalpTQjNhWFJvSUZCNWRHZ2dhVzRnY0hKdlpIVmpkR2x2YmlrS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNVFV4Wmpkak56VTRNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzVEY21WelkyRkNkV05yWlhSUWNtOTBiMk52YkM1c2FYRjFhV1JoZEdWZmNHOXphWFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHNhWEYxYVdSaGRHVmZjRzl6YVhScGIyNDZDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qUTVNUzAwT1RRS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QWpJR3hwY1hWcFpHRjBaVjl3YjNOcGRHbHZiaUFnS0dGdWVXOXVaU0JqWVc0Z1kyRnNiQ2tLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZOVEEwTFRVd05Rb2dJQ0FnTHk4Z0l5QkZibVp2Y21ObElHOXlZV05zWlNCbWNtVnphRzVsYzNNZzRvQ1VJSE4wWVd4bElIQnlhV05sY3lCdFlXdGxJR3hwY1hWcFpHRjBhVzl1SUdsdWRtRnNhV1FLSUNBZ0lDOHZJR0Z6YzJWeWRDQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBdElITmxiR1l1YjNKaFkyeGxYM1Z3WkdGMFpXUmZZWFF1ZG1Gc2RXVWdQRDBnVlVsdWREWTBLRTlTUVVOTVJWOU5RVmhmUVVkRktTd2dJazl5WVdOc1pTQndjbWxqWlNCemRHRnNaU0lLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnZjbUZqYkdWZmRYQmtZWFJsWkY5aGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2Y21GamJHVmZkWEJrWVhSbFpGOWhkQ0JsZUdsemRITUtJQ0FnSUMwS0lDQWdJSEIxYzJocGJuUWdNekFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1QzSmhZMnhsSUhCeWFXTmxJSE4wWVd4bENpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pVd053b2dJQ0FnTHk4Z2NHOXpYMnRsZVNBOUlGOXdiM05wZEdsdmJsOXJaWGtvYjNkdVpYSXVibUYwYVhabExtSjVkR1Z6TENCd2IzTnBkR2x2Ymw5cFpDNXVZWFJwZG1VcENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pFd053b2dJQ0FnTHk4Z2NtVjBkWEp1SUdJaWNHOXpYeUlnS3lCdmQyNWxjaUFySUc5d0xtbDBiMklvY0c5emFYUnBiMjVmYVdRcENpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE56QTJaamN6TldZS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPalV3T0FvZ0lDQWdMeThnWVhOelpYSjBJSEJ2YzE5clpYa2dhVzRnYzJWc1ppNXdiM05wZEdsdmJuTXNJQ0pRYjNOcGRHbHZiaUJ1YjNRZ1ptOTFibVFpQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUZCdmMybDBhVzl1SUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8xTVRBS0lDQWdJQzh2SUhCdmN5QTlJSE5sYkdZdWNHOXphWFJwYjI1elczQnZjMTlyWlhsZExtTnZjSGtvS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pVeE1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhCdmN5NWhZM1JwZG1VdWJtRjBhWFpsTENBaVVHOXphWFJwYjI0Z1lXeHlaV0ZrZVNCamJHOXpaV1FpQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTkNBdkx5QTBOVFlLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFiM05wZEdsdmJpQmhiSEpsWVdSNUlHTnNiM05sWkFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8xTVRNS0lDQWdJQzh2SUdKcmRGOXJaWGtnUFNCZlluVmphMlYwWDJ0bGVTaHZkMjVsY2k1dVlYUnBkbVV1WW5sMFpYTXNJSEJ2Y3k1aWRXTnJaWFJmYVdRdWJtRjBhWFpsS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdPQW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUb3hNRE1LSUNBZ0lDOHZJSEpsZEhWeWJpQmlJbUpyZEY4aUlDc2diM2R1WlhJZ0t5QnZjQzVwZEc5aUtHSjFZMnRsZEY5cFpDa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZzJNalppTnpRMVpnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvMU1UUUtJQ0FnSUM4dklHSjFZMnRsZENBOUlITmxiR1l1WW5WamEyVjBjMXRpYTNSZmEyVjVYUzVqYjNCNUtDa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUoxWTJ0bGRITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPalV4TlFvZ0lDQWdMeThnWTNWeWNtVnVkRjl3Y21salpTQTlJSE5sYkdZdVgyTmhiR04xYkdGMFpWOWlZWE5yWlhSZmNISnBZMlVvWW5WamEyVjBLUW9nSUNBZ1kyRnNiSE4xWWlCZlkyRnNZM1ZzWVhSbFgySmhjMnRsZEY5d2NtbGpaUW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzFNVGNLSUNBZ0lDOHZJSEJ1YkY5aFluTWdQU0J6Wld4bUxsOWpZV3hqZFd4aGRHVmZjRzVzWDJGaWN5aHdiM01zSUdOMWNuSmxiblJmY0hKcFkyVXNJR0oxWTJ0bGRDNXNaWFpsY21GblpTNXVZWFJwZG1VcENpQWdJQ0JwYm5SaklEVWdMeThnTVRNMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUY5allXeGpkV3hoZEdWZmNHNXNYMkZpY3dvZ0lDQWdjM2RoY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvMU1UZ0tJQ0FnSUM4dklHbHpYM0J5YjJacGRDQTlJSE5sYkdZdVgybHpYM0J5YjJacGRDaHdiM01zSUdOMWNuSmxiblJmY0hKcFkyVXBDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUY5cGMxOXdjbTltYVhRS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qVXlNQW9nSUNBZ0x5OGdiV0Z5WjJsdVgzWmhiQ0E5SUhCdmN5NXRZWEpuYVc0dWJtRjBhWFpsQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ09TQTRDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQndkWE5vYVc1MElEa0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCemQyRndDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qVXlNZ29nSUNBZ0x5OGdhV1lnYVhOZmNISnZabWwwT2dvZ0lDQWdZbm9nYkdseGRXbGtZWFJsWDNCdmMybDBhVzl1WDJWc2MyVmZZbTlrZVVBekNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pVeU13b2dJQ0FnTHk4Z2NtVnRZV2x1YVc1blgyMWhjbWRwYmlBOUlHMWhjbWRwYmw5MllXd2dLeUJ3Ym14ZllXSnpDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTBDaUFnSUNBckNncHNhWEYxYVdSaGRHVmZjRzl6YVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBM09nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvMU1qY0tJQ0FnSUM4dklHeHBjWFZwWkdGMGFXOXVYM1JvY21WemFHOXNaQ0E5SUNodFlYSm5hVzVmZG1Gc0lDb2dWVWx1ZERZMEtFeEpVVlZKUkVGVVNVOU9YMVJJVWtWVFNFOU1SRjlRUTFRcEtTQXZMeUJWU1c1ME5qUW9NVEF3S1FvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F4TURBS0lDQWdJQzhLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZOVEk0Q2lBZ0lDQXZMeUJoYzNObGNuUWdjbVZ0WVdsdWFXNW5YMjFoY21kcGJpQThQU0JzYVhGMWFXUmhkR2x2Ymw5MGFISmxjMmh2YkdRc0lDSlFiM05wZEdsdmJpQnViM1FnYkdseGRXbGtZWFJoWW14bElnb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRYjNOcGRHbHZiaUJ1YjNRZ2JHbHhkV2xrWVhSaFlteGxDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qVXpNZ29nSUNBZ0x5OGdZblZqYTJWMFgybGtQWEJ2Y3k1aWRXTnJaWFJmYVdRc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnT0FvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8xTXpNS0lDQWdJQzh2SUdselgyeHZibWM5Y0c5ekxtbHpYMnh2Ym1jc0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0EyTkFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8xTXpVS0lDQWdJQzh2SUdWdWRISjVYM0J5YVdObFBYQnZjeTVsYm5SeWVWOXdjbWxqWlN3S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJREUzSURnS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TlRNMkNpQWdJQ0F2THlCdmQyNWxjajF3YjNNdWIzZHVaWElzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaWGgwY21GamRDQXlOU0F6TWdvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8xTXpnS0lDQWdJQzh2SUc5d1pXNWZkR2x0WlhOMFlXMXdQWEJ2Y3k1dmNHVnVYM1JwYldWemRHRnRjQ3dLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWlhoMGNtRmpkQ0ExT0NBNENpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pVek1DMDFNemtLSUNBZ0lDOHZJQ01nUTJ4dmMyVWdjRzl6YVhScGIyNGdLRzFoY21kcGJpQm5iMlZ6SUhSdklIcGxjbThnTHlCd2NtOTBiMk52YkNCbVpXVWc0b0NVSUhOcGJYQnNhV1pwWldRcENpQWdJQ0F2THlCelpXeG1MbkJ2YzJsMGFXOXVjMXR3YjNOZmEyVjVYU0E5SUZCdmMybDBhVzl1S0FvZ0lDQWdMeThnSUNBZ0lHSjFZMnRsZEY5cFpEMXdiM011WW5WamEyVjBYMmxrTEFvZ0lDQWdMeThnSUNBZ0lHbHpYMnh2Ym1jOWNHOXpMbWx6WDJ4dmJtY3NDaUFnSUNBdkx5QWdJQ0FnYldGeVoybHVQWEJ2Y3k1dFlYSm5hVzRzQ2lBZ0lDQXZMeUFnSUNBZ1pXNTBjbmxmY0hKcFkyVTljRzl6TG1WdWRISjVYM0J5YVdObExBb2dJQ0FnTHk4Z0lDQWdJRzkzYm1WeVBYQnZjeTV2ZDI1bGNpd0tJQ0FnSUM4dklDQWdJQ0JoWTNScGRtVTlZWEpqTkM1Q2IyOXNLRVpoYkhObEtTd0tJQ0FnSUM4dklDQWdJQ0J2Y0dWdVgzUnBiV1Z6ZEdGdGNEMXdiM011YjNCbGJsOTBhVzFsYzNSaGJYQXNDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZOVE0zQ2lBZ0lDQXZMeUJoWTNScGRtVTlZWEpqTkM1Q2IyOXNLRVpoYkhObEtTd0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNQW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzFNekF0TlRNNUNpQWdJQ0F2THlBaklFTnNiM05sSUhCdmMybDBhVzl1SUNodFlYSm5hVzRnWjI5bGN5QjBieUI2WlhKdklDOGdjSEp2ZEc5amIyd2dabVZsSU9LQWxDQnphVzF3YkdsbWFXVmtLUW9nSUNBZ0x5OGdjMlZzWmk1d2IzTnBkR2x2Ym5OYmNHOXpYMnRsZVYwZ1BTQlFiM05wZEdsdmJpZ0tJQ0FnSUM4dklDQWdJQ0JpZFdOclpYUmZhV1E5Y0c5ekxtSjFZMnRsZEY5cFpDd0tJQ0FnSUM4dklDQWdJQ0JwYzE5c2IyNW5QWEJ2Y3k1cGMxOXNiMjVuTEFvZ0lDQWdMeThnSUNBZ0lHMWhjbWRwYmoxd2IzTXViV0Z5WjJsdUxBb2dJQ0FnTHk4Z0lDQWdJR1Z1ZEhKNVgzQnlhV05sUFhCdmN5NWxiblJ5ZVY5d2NtbGpaU3dLSUNBZ0lDOHZJQ0FnSUNCdmQyNWxjajF3YjNNdWIzZHVaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXTjBhWFpsUFdGeVl6UXVRbTl2YkNoR1lXeHpaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2IzQmxibDkwYVcxbGMzUmhiWEE5Y0c5ekxtOXdaVzVmZEdsdFpYTjBZVzF3TEFvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTFDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPalUwTVMwMU5EWUtJQ0FnSUM4dklHRnlZelF1WlcxcGRDZ0tJQ0FnSUM4dklDQWdJQ0FpVEdseGRXbGtZWFJwYjI0b2RXbHVkRFkwTEdGa1pISmxjM01zWW5sMFpWdGRLU0lzQ2lBZ0lDQXZMeUFnSUNBZ2NHOXphWFJwYjI1ZmFXUXNDaUFnSUNBdkx5QWdJQ0FnYjNkdVpYSXNDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNUVlVzVoYldsalFubDBaWE1vWWlKSmJuTjFabVpwWTJsbGJuUWdiV0Z5WjJsdUlpa3NDaUFnSUNBdkx5QXBDaUFnSUNCa2FXY2dOUW9nSUNBZ1pHbG5JRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeVlUQXdNVE0wT1RabE56TTNOVFkyTmpZMk9UWXpOamsyTlRabE56UXlNRFprTmpFM01qWTNOamsyWlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaU5XTTVaREV6WXlBdkx5QnRaWFJvYjJRZ0lreHBjWFZwWkdGMGFXOXVLSFZwYm5RMk5DeGhaR1J5WlhOekxHSjVkR1ZiWFNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvME9URXRORGswQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z0l5QnNhWEYxYVdSaGRHVmZjRzl6YVhScGIyNGdJQ2hoYm5sdmJtVWdZMkZ1SUdOaGJHd3BDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURFMU1XWTNZemMxT0RBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JHbHhkV2xrWVhSbFgzQnZjMmwwYVc5dVgyVnNjMlZmWW05a2VVQXpPZ29nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzFNalVLSUNBZ0lDOHZJSEpsYldGcGJtbHVaMTl0WVhKbmFXNGdQU0J0WVhKbmFXNWZkbUZzSUMwZ2NHNXNYMkZpY3lCcFppQnRZWEpuYVc1ZmRtRnNJRDRnY0c1c1gyRmljeUJsYkhObElGVkpiblEyTkNnd0tRb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnUGdvZ0lDQWdZbm9nYkdseGRXbGtZWFJsWDNCdmMybDBhVzl1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOUW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dOQW9nSUNBZ0xRb2dJQ0FnWWlCc2FYRjFhV1JoZEdWZmNHOXphWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2dwc2FYRjFhV1JoZEdWZmNHOXphWFJwYjI1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExT2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8xTWpVS0lDQWdJQzh2SUhKbGJXRnBibWx1WjE5dFlYSm5hVzRnUFNCdFlYSm5hVzVmZG1Gc0lDMGdjRzVzWDJGaWN5QnBaaUJ0WVhKbmFXNWZkbUZzSUQ0Z2NHNXNYMkZpY3lCbGJITmxJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JHbHhkV2xrWVhSbFgzQnZjMmwwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTndvS0NpOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dVEzSmxjMk5oUW5WamEyVjBVSEp2ZEc5amIyd3VaMlYwWDJOdmJHeGhkR1Z5WVd4ZlltRnNZVzVqWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjlqYjJ4c1lYUmxjbUZzWDJKaGJHRnVZMlU2Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPalUxTUMwMU5UTUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUFqSUZKbFlXUXRiMjVzZVNCMmFXVjNjd29nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5UVTFDaUFnSUNBdkx5QnBaaUIxYzJWeUlHbHVJSE5sYkdZdVkyOXNiR0YwWlhKaGJEb0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZzJNelptTm1NMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWjJWMFgyTnZiR3hoZEdWeVlXeGZZbUZzWVc1alpWOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TlRVMkNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWpiMnhzWVhSbGNtRnNXM1Z6WlhKZENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnZiR3hoZEdWeVlXd2daVzUwY25rZ1pYaHBjM1J6Q2dwblpYUmZZMjlzYkdGMFpYSmhiRjlpWVd4aGJtTmxYMkZtZEdWeVgybHViR2x1WldSZlkzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzVEY21WelkyRkNkV05yWlhSUWNtOTBiMk52YkM1blpYUmZZMjlzYkdGMFpYSmhiRjlpWVd4aGJtTmxRRFE2Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPalUxTUMwMU5UTUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUFqSUZKbFlXUXRiMjVzZVNCMmFXVjNjd29nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21kbGRGOWpiMnhzWVhSbGNtRnNYMkpoYkdGdVkyVmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvMU5UY0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5UVXdMVFUxTXdvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklDTWdVbVZoWkMxdmJteDVJSFpwWlhkekNpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWWlCblpYUmZZMjlzYkdGMFpYSmhiRjlpWVd4aGJtTmxYMkZtZEdWeVgybHViR2x1WldSZlkzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzVEY21WelkyRkNkV05yWlhSUWNtOTBiMk52YkM1blpYUmZZMjlzYkdGMFpYSmhiRjlpWVd4aGJtTmxRRFFLQ2dvdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTGtOeVpYTmpZVUoxWTJ0bGRGQnliM1J2WTI5c0xtZGxkRjkxYm5KbFlXeHBlbVZrWDNCdWJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5MWJuSmxZV3hwZW1Wa1gzQnViRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qVTFPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzFOak1LSUNBZ0lDOHZJSEJ2YzE5clpYa2dQU0JmY0c5emFYUnBiMjVmYTJWNUtHOTNibVZ5TG01aGRHbDJaUzVpZVhSbGN5d2djRzl6YVhScGIyNWZhV1F1Ym1GMGFYWmxLUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUb3hNRGNLSUNBZ0lDOHZJSEpsZEhWeWJpQmlJbkJ2YzE4aUlDc2diM2R1WlhJZ0t5QnZjQzVwZEc5aUtIQnZjMmwwYVc5dVgybGtLUW9nSUNBZ1lubDBaV01nT1NBdkx5QXdlRGN3Tm1ZM016Vm1DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5UWTBDaUFnSUNBdkx5QnBaaUJ3YjNOZmEyVjVJRzV2ZENCcGJpQnpaV3htTG5CdmMybDBhVzl1Y3pvS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJR2RsZEY5MWJuSmxZV3hwZW1Wa1gzQnViRjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5UWTFDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDZ3BuWlhSZmRXNXlaV0ZzYVhwbFpGOXdibXhmWVdaMFpYSmZhVzVzYVc1bFpGOWpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTGtOeVpYTmpZVUoxWTJ0bGRGQnliM1J2WTI5c0xtZGxkRjkxYm5KbFlXeHBlbVZrWDNCdWJFQTJPZ29nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzFOVGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWRsZEY5MWJuSmxZV3hwZW1Wa1gzQnViRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qVTJOZ29nSUNBZ0x5OGdjRzl6SUQwZ2MyVnNaaTV3YjNOcGRHbHZibk5iY0c5elgydGxlVjB1WTI5d2VTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZblZ5ZVNBMUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2IzTnBkR2x2Ym5NZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qVTJOd29nSUNBZ0x5OGdhV1lnYm05MElIQnZjeTVoWTNScGRtVXVibUYwYVhabE9nb2dJQ0FnYVc1MFl5QTBJQzh2SURRMU5nb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW01NklHZGxkRjkxYm5KbFlXeHBlbVZrWDNCdWJGOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TlRZNENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pVMU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJuWlhSZmRXNXlaV0ZzYVhwbFpGOXdibXhmWVdaMFpYSmZhVzVzYVc1bFpGOWpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTGtOeVpYTmpZVUoxWTJ0bGRGQnliM1J2WTI5c0xtZGxkRjkxYm5KbFlXeHBlbVZrWDNCdWJFQTJDZ3BuWlhSZmRXNXlaV0ZzYVhwbFpGOXdibXhmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzFOamtLSUNBZ0lDOHZJR0pyZEY5clpYa2dQU0JmWW5WamEyVjBYMnRsZVNodmQyNWxjaTV1WVhScGRtVXVZbmwwWlhNc0lIQnZjeTVpZFdOclpYUmZhV1F1Ym1GMGFYWmxLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lEZ0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk1UQXpDaUFnSUNBdkx5QnlaWFIxY200Z1lpSmlhM1JmSWlBcklHOTNibVZ5SUNzZ2IzQXVhWFJ2WWloaWRXTnJaWFJmYVdRcENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE5qSTJZamMwTldZS0lDQWdJR1JwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzFOekFLSUNBZ0lDOHZJR0oxWTJ0bGRDQTlJSE5sYkdZdVluVmphMlYwYzF0aWEzUmZhMlY1WFM1amIzQjVLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KMVkydGxkSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pVM01Rb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5d2NtbGpaU0E5SUhObGJHWXVYMk5oYkdOMWJHRjBaVjlpWVhOclpYUmZjSEpwWTJVb1luVmphMlYwS1FvZ0lDQWdZMkZzYkhOMVlpQmZZMkZzWTNWc1lYUmxYMkpoYzJ0bGRGOXdjbWxqWlFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8xTnpJS0lDQWdJQzh2SUhCdWJGOWhZbk1nUFNCelpXeG1MbDlqWVd4amRXeGhkR1ZmY0c1c1gyRmljeWh3YjNNc0lHTjFjbkpsYm5SZmNISnBZMlVzSUdKMVkydGxkQzVzWlhabGNtRm5aUzV1WVhScGRtVXBDaUFnSUNCcGJuUmpJRFVnTHk4Z01UTTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1kyRnNiSE4xWWlCZlkyRnNZM1ZzWVhSbFgzQnViRjloWW5NS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8xTnpNS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNod2JteGZZV0p6S1FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8xTlRrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdaMlYwWDNWdWNtVmhiR2w2WldSZmNHNXNYMkZtZEdWeVgybHViR2x1WldSZlkzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzVEY21WelkyRkNkV05yWlhSUWNtOTBiMk52YkM1blpYUmZkVzV5WldGc2FYcGxaRjl3Ym14QU5nb0tDaTh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VRM0psYzJOaFFuVmphMlYwVUhKdmRHOWpiMnd1WjJWMFgyOXlZV05zWlY5MWNHUmhkR1ZrWDJGMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDI5eVlXTnNaVjkxY0dSaGRHVmtYMkYwT2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8xTnpnS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNoelpXeG1MbTl5WVdOc1pWOTFjR1JoZEdWa1gyRjBMblpoYkhWbEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW05eVlXTnNaVjkxY0dSaGRHVmtYMkYwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOXlZV05zWlY5MWNHUmhkR1ZrWDJGMElHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8xTnpVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTGtOeVpYTmpZVUoxWTJ0bGRGQnliM1J2WTI5c0xtZGxkRjkwYjNSaGJGOXdiM05wZEdsdmJuTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmRHOTBZV3hmY0c5emFYUnBiMjV6T2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8xT0RJS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gzQnZjMmwwYVc5dWN5NTJZV3gxWlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0owYjNSaGJGOXdiM05wZEdsdmJuTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZjRzl6YVhScGIyNXpJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvMU9EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xrTnlaWE5qWVVKMVkydGxkRkJ5YjNSdlkyOXNMbWRsZEY5MGIzUmhiRjlpZFdOclpYUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzUnZkR0ZzWDJKMVkydGxkSE02Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPalU0TmdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkRzkwWVd4ZlluVmphMlYwY3k1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE0SUM4dklDSjBiM1JoYkY5aWRXTnJaWFJ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJKMVkydGxkSE1nWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qVTROQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VRM0psYzJOaFFuVmphMlYwVUhKdmRHOWpiMnd1Wm5WdVpGOWpiMjUwY21GamRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVoxYm1SZlkyOXVkSEpoWTNRNkNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pVNE9DMDFPVEVLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlBaklHWjFibVJmWTI5dWRISmhZM1FnSUNoamIzWmxjbk1nUW05NElHMXBiaTFpWVd4aGJtTmxLUW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzFPVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MFgzUjRiaTV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TENBaVRYVnpkQ0J3WVhrZ1kyOXVkSEpoWTNRaUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJOZFhOMElIQmhlU0JqYjI1MGNtRmpkQW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzFPVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MFgzUjRiaTVoYlc5MWJuUWdQaUJWU1c1ME5qUW9NQ2tzSUNKQmJXOTFiblFnYlhWemRDQmlaU0ErSURBaUNpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYlc5MWJuUWdiWFZ6ZENCaVpTQStJREFLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZOVGc0TFRVNU1Rb2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJQ01nWm5WdVpGOWpiMjUwY21GamRDQWdLR052ZG1WeWN5QkNiM2dnYldsdUxXSmhiR0Z1WTJVcENpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREUxTVdZM1l6YzFPREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1UTNKbGMyTmhRblZqYTJWMFVISnZkRzlqYjJ3dVgyTmhiR04xYkdGMFpWOWlZWE5yWlhSZmNISnBZMlVvWW5WamEyVjBPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBMQ0JpZVhSbGN6b0tYMk5oYkdOMWJHRjBaVjlpWVhOclpYUmZjSEpwWTJVNkNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pZeE1DMDJNVEVLSUNBZ0lDOHZJRUJ6ZFdKeWIzVjBhVzVsQ2lBZ0lDQXZMeUJrWldZZ1gyTmhiR04xYkdGMFpWOWlZWE5yWlhSZmNISnBZMlVvYzJWc1ppd2dZblZqYTJWME9pQkNkV05yWlhRcElDMCtJRlZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJREVnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzJNVGNLSUNBZ0lDOHZJRzRnUFNCaWRXTnJaWFF1WVhOelpYUmZZMjkxYm5RdWJtRjBhWFpsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ01USTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzJNVGdLSUNBZ0lDOHZJSGRsYVdkb2RHVmtYM04xYlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TmpFNUNpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvYmlrNkNpQWdJQ0JrZFhBS0NsOWpZV3hqZFd4aGRHVmZZbUZ6YTJWMFgzQnlhV05sWDJadmNsOW9aV0ZrWlhKQU1Ub0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5qRTVDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2JpazZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJRHdLSUNBZ0lHSjZJRjlqWVd4amRXeGhkR1ZmWW1GemEyVjBYM0J5YVdObFgyRm1kR1Z5WDJadmNrQXlOUW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzJNak1LSUNBZ0lDOHZJR2xtSUdrZ1BUMGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdKdWVpQmZZMkZzWTNWc1lYUmxYMkpoYzJ0bGRGOXdjbWxqWlY5bGJITmxYMkp2WkhsQU5Bb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvMk1qUUtJQ0FnSUM4dklHRnpjMlYwWDJsa0lEMGdZblZqYTJWMExtRnpjMlYwTUM1dVlYUnBkbVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qWXlOUW9nSUNBZ0x5OGdkMlZwWjJoMElEMGdZblZqYTJWMExuZGxhV2RvZERBdWJtRjBhWFpsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtDbDlqWVd4amRXeGhkR1ZmWW1GemEyVjBYM0J5YVdObFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpNNkNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pFeE1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdJaWNISmpYeUlnS3lCdmNDNXBkRzlpS0dGemMyVjBYMmxrS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ01UQWdMeThnTUhnM01EY3lOak0xWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8yTURVS0lDQWdJQzh2SUdsbUlIQnJaWGtnYVc0Z2MyVnNaaTV3Y21salpYTTZDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUY5allXeGpkV3hoZEdWZlltRnphMlYwWDNCeWFXTmxYMkZtZEdWeVgybG1YMlZzYzJWQU1qZ0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5qQTJDaUFnSUNBdkx5QndjbWxqWlRvZ1ZVbHVkRFkwSUQwZ2MyVnNaaTV3Y21salpYTmJjR3RsZVYwdWNISnBZMlV1Ym1GMGFYWmxDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjSEpwWTJWeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDZ3BmWTJGc1kzVnNZWFJsWDJKaGMydGxkRjl3Y21salpWOWhablJsY2w5cGJteHBibVZrWDJOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VRM0psYzJOaFFuVmphMlYwVUhKdmRHOWpiMnd1WDJkbGRGOWhjM05sZEY5d2NtbGpaVUF5T1RvS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TmpRNUNpQWdJQ0F2THlCM1pXbG5hSFJsWkY5emRXMGdQU0IzWldsbmFIUmxaRjl6ZFcwZ0t5QW9jSEpwWTJVZ0tpQjNaV2xuYUhRcElDOHZJRlZKYm5RMk5DZ3hNREFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F4TURBS0lDQWdJQzhLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TmpFNUNpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvYmlrNkNpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb2dJQ0FnWWlCZlkyRnNZM1ZzWVhSbFgySmhjMnRsZEY5d2NtbGpaVjltYjNKZmFHVmhaR1Z5UURFS0NsOWpZV3hqZFd4aGRHVmZZbUZ6YTJWMFgzQnlhV05sWDJGbWRHVnlYMmxtWDJWc2MyVkFNamc2Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPall3T0FvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DaFFVa2xEUlY5UVVrVkRTVk5KVDA0cElDQWpJR1JsWm1GMWJIUTZJSEJ5YVdObElEMGdNUzR3SUNocGJpQTRMV1JsWTJsdFlXd2djSEpsWTJsemFXOXVLUW9nSUNBZ2FXNTBZeUEySUM4dklERXdNREF3TURBd01Bb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvMk5EZ0tJQ0FnSUM4dklIQnlhV05sSUQwZ2MyVnNaaTVmWjJWMFgyRnpjMlYwWDNCeWFXTmxLR0Z6YzJWMFgybGtLUW9nSUNBZ1lpQmZZMkZzWTNWc1lYUmxYMkpoYzJ0bGRGOXdjbWxqWlY5aFpuUmxjbDlwYm14cGJtVmtYMk55WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dVEzSmxjMk5oUW5WamEyVjBVSEp2ZEc5amIyd3VYMmRsZEY5aGMzTmxkRjl3Y21salpVQXlPUW9LWDJOaGJHTjFiR0YwWlY5aVlYTnJaWFJmY0hKcFkyVmZaV3h6WlY5aWIyUjVRRFE2Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPall5TmdvZ0lDQWdMeThnWld4cFppQnBJRDA5SUZWSmJuUTJOQ2d4S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdKNklGOWpZV3hqZFd4aGRHVmZZbUZ6YTJWMFgzQnlhV05sWDJWc2MyVmZZbTlrZVVBMkNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pZeU53b2dJQ0FnTHk4Z1lYTnpaWFJmYVdRZ1BTQmlkV05yWlhRdVlYTnpaWFF4TG01aGRHbDJaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5qSTRDaUFnSUNBdkx5QjNaV2xuYUhRZ1BTQmlkV05yWlhRdWQyVnBaMmgwTVM1dVlYUnBkbVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBM01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWWlCZlkyRnNZM1ZzWVhSbFgySmhjMnRsZEY5d2NtbGpaVjloWm5SbGNsOXBabDlsYkhObFFESXpDZ3BmWTJGc1kzVnNZWFJsWDJKaGMydGxkRjl3Y21salpWOWxiSE5sWDJKdlpIbEFOam9LSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZOakk1Q2lBZ0lDQXZMeUJsYkdsbUlHa2dQVDBnVlVsdWREWTBLRElwT2dvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBOVBRb2dJQ0FnWW5vZ1gyTmhiR04xYkdGMFpWOWlZWE5yWlhSZmNISnBZMlZmWld4elpWOWliMlI1UURnS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TmpNd0NpQWdJQ0F2THlCaGMzTmxkRjlwWkNBOUlHSjFZMnRsZEM1aGMzTmxkREl1Ym1GMGFYWmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pZek1Rb2dJQ0FnTHk4Z2QyVnBaMmgwSUQwZ1luVmphMlYwTG5kbGFXZG9kREl1Ym1GMGFYWmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnT0RBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR0lnWDJOaGJHTjFiR0YwWlY5aVlYTnJaWFJmY0hKcFkyVmZZV1owWlhKZmFXWmZaV3h6WlVBeU13b0tYMk5oYkdOMWJHRjBaVjlpWVhOclpYUmZjSEpwWTJWZlpXeHpaVjlpYjJSNVFEZzZDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qWXpNZ29nSUNBZ0x5OGdaV3hwWmlCcElEMDlJRlZKYm5RMk5DZ3pLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDA5Q2lBZ0lDQmllaUJmWTJGc1kzVnNZWFJsWDJKaGMydGxkRjl3Y21salpWOWxiSE5sWDJKdlpIbEFNVEFLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZOak16Q2lBZ0lDQXZMeUJoYzNObGRGOXBaQ0E5SUdKMVkydGxkQzVoYzNObGRETXVibUYwYVhabENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPall6TkFvZ0lDQWdMeThnZDJWcFoyaDBJRDBnWW5WamEyVjBMbmRsYVdkb2RETXVibUYwYVhabENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdPRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHSWdYMk5oYkdOMWJHRjBaVjlpWVhOclpYUmZjSEpwWTJWZllXWjBaWEpmYVdaZlpXeHpaVUF5TXdvS1gyTmhiR04xYkdGMFpWOWlZWE5yWlhSZmNISnBZMlZmWld4elpWOWliMlI1UURFd09nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvMk16VUtJQ0FnSUM4dklHVnNhV1lnYVNBOVBTQlZTVzUwTmpRb05DazZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQTlQUW9nSUNBZ1lub2dYMk5oYkdOMWJHRjBaVjlpWVhOclpYUmZjSEpwWTJWZlpXeHpaVjlpYjJSNVFERXlDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qWXpOZ29nSUNBZ0x5OGdZWE56WlhSZmFXUWdQU0JpZFdOclpYUXVZWE56WlhRMExtNWhkR2wyWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzJNemNLSUNBZ0lDOHZJSGRsYVdkb2RDQTlJR0oxWTJ0bGRDNTNaV2xuYUhRMExtNWhkR2wyWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElEazJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCaUlGOWpZV3hqZFd4aGRHVmZZbUZ6YTJWMFgzQnlhV05sWDJGbWRHVnlYMmxtWDJWc2MyVkFNak1LQ2w5allXeGpkV3hoZEdWZlltRnphMlYwWDNCeWFXTmxYMlZzYzJWZlltOWtlVUF4TWpvS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TmpNNENpQWdJQ0F2THlCbGJHbG1JR2tnUFQwZ1ZVbHVkRFkwS0RVcE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ1BUMEtJQ0FnSUdKNklGOWpZV3hqZFd4aGRHVmZZbUZ6YTJWMFgzQnlhV05sWDJWc2MyVmZZbTlrZVVBeE5Bb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvMk16a0tJQ0FnSUM4dklHRnpjMlYwWDJsa0lEMGdZblZqYTJWMExtRnpjMlYwTlM1dVlYUnBkbVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBME1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5qUXdDaUFnSUNBdkx5QjNaV2xuYUhRZ1BTQmlkV05yWlhRdWQyVnBaMmgwTlM1dVlYUnBkbVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBeE1EUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdJZ1gyTmhiR04xYkdGMFpWOWlZWE5yWlhSZmNISnBZMlZmWVdaMFpYSmZhV1pmWld4elpVQXlNd29LWDJOaGJHTjFiR0YwWlY5aVlYTnJaWFJmY0hKcFkyVmZaV3h6WlY5aWIyUjVRREUwT2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8yTkRFS0lDQWdJQzh2SUdWc2FXWWdhU0E5UFNCVlNXNTBOalFvTmlrNkNpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNBOVBRb2dJQ0FnWW5vZ1gyTmhiR04xYkdGMFpWOWlZWE5yWlhSZmNISnBZMlZmWld4elpWOWliMlI1UURFMkNpQWdJQ0F2THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMbkI1T2pZME1nb2dJQ0FnTHk4Z1lYTnpaWFJmYVdRZ1BTQmlkV05yWlhRdVlYTnpaWFEyTG01aGRHbDJaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9hVzUwSURRNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z1kzSmxjMk5oWDJKMVkydGxkRjl3Y205MGIyTnZiQzV3ZVRvMk5ETUtJQ0FnSUM4dklIZGxhV2RvZENBOUlHSjFZMnRsZEM1M1pXbG5hSFEyTG01aGRHbDJaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9hVzUwSURFeE1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWWlCZlkyRnNZM1ZzWVhSbFgySmhjMnRsZEY5d2NtbGpaVjloWm5SbGNsOXBabDlsYkhObFFESXpDZ3BmWTJGc1kzVnNZWFJsWDJKaGMydGxkRjl3Y21salpWOWxiSE5sWDJKdlpIbEFNVFk2Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPalkwTlFvZ0lDQWdMeThnWVhOelpYUmZhV1FnUFNCaWRXTnJaWFF1WVhOelpYUTNMbTVoZEdsMlpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJRFUyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8yTkRZS0lDQWdJQzh2SUhkbGFXZG9kQ0E5SUdKMVkydGxkQzUzWldsbmFIUTNMbTVoZEdsMlpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJREV5TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdZaUJmWTJGc1kzVnNZWFJsWDJKaGMydGxkRjl3Y21salpWOWhablJsY2w5cFpsOWxiSE5sUURJekNncGZZMkZzWTNWc1lYUmxYMkpoYzJ0bGRGOXdjbWxqWlY5aFpuUmxjbDltYjNKQU1qVTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qWTFNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIZGxhV2RvZEdWa1gzTjFiU0JwWmlCM1pXbG5hSFJsWkY5emRXMGdQaUJWU1c1ME5qUW9NQ2tnWld4elpTQlZTVzUwTmpRb1VGSkpRMFZmVUZKRlEwbFRTVTlPS1FvZ0lDQWdhVzUwWXlBMklDOHZJREV3TURBd01EQXdNQW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnYzJWc1pXTjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCamNtVnpZMkZmWW5WamEyVjBYM0J5YjNSdlkyOXNMa055WlhOallVSjFZMnRsZEZCeWIzUnZZMjlzTGw5cGMxOXdjbTltYVhRb2NHOXpPaUJpZVhSbGN5d2daWGhwZEY5d2NtbGpaVG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalFzSUdKNWRHVnpPZ3BmYVhOZmNISnZabWwwT2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8yTlRNdE5qVTRDaUFnSUNBdkx5QkFjM1ZpY205MWRHbHVaUW9nSUNBZ0x5OGdaR1ZtSUY5cGMxOXdjbTltYVhRb0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3S0lDQWdJQzh2SUNBZ0lDQndiM002SUZCdmMybDBhVzl1TEFvZ0lDQWdMeThnSUNBZ0lHVjRhWFJmY0hKcFkyVTZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDa2dMVDRnWW05dmJEb0tJQ0FnSUhCeWIzUnZJRElnTWdvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8yTlRrS0lDQWdJQzh2SUdWdWRISjVJRDBnY0c5ekxtVnVkSEo1WDNCeWFXTmxMbTVoZEdsMlpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J3ZFhOb2FXNTBJREUzQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8yTmpBS0lDQWdJQzh2SUdsbUlIQnZjeTVwYzE5c2IyNW5MbTVoZEdsMlpUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHbHVkQ0EyTkFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbm9nWDJselgzQnliMlpwZEY5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZOall4Q2lBZ0lDQXZMeUJwWmlCbGVHbDBYM0J5YVdObElENDlJR1Z1ZEhKNU9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E4UFFvZ0lDQWdZbm9nWDJselgzQnliMlpwZEY5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZOall5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWSEoxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NtVjBjM1ZpQ2dwZmFYTmZjSEp2Wm1sMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2TmpZekNpQWdJQ0F2THlCeVpYUjFjbTRnUm1Gc2MyVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEpsZEhOMVlnb0tYMmx6WDNCeWIyWnBkRjloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qWTJOQW9nSUNBZ0x5OGdhV1lnWlc1MGNua2dQajBnWlhocGRGOXdjbWxqWlRvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQajBLSUNBZ0lHSjZJRjlwYzE5d2NtOW1hWFJmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qWTJOUW9nSUNBZ0x5OGdjbVYwZFhKdUlGUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhKbGRITjFZZ29LWDJselgzQnliMlpwZEY5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xuQjVPalkyTmdvZ0lDQWdMeThnY21WMGRYSnVJRVpoYkhObENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJqY21WelkyRmZZblZqYTJWMFgzQnliM1J2WTI5c0xrTnlaWE5qWVVKMVkydGxkRkJ5YjNSdlkyOXNMbDlqWVd4amRXeGhkR1ZmY0c1c1gyRmljeWh3YjNNNklHSjVkR1Z6TENCbGVHbDBYM0J5YVdObE9pQjFhVzUwTmpRc0lHeGxkbVZ5WVdkbE9pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Dd2dZbmwwWlhNNkNsOWpZV3hqZFd4aGRHVmZjRzVzWDJGaWN6b0tJQ0FnSUM4dklHTnlaWE5qWVY5aWRXTnJaWFJmY0hKdmRHOWpiMnd1Y0hrNk5qWTRMVFkzTkFvZ0lDQWdMeThnUUhOMVluSnZkWFJwYm1VS0lDQWdJQzh2SUdSbFppQmZZMkZzWTNWc1lYUmxYM0J1YkY5aFluTW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd0tJQ0FnSUM4dklDQWdJQ0J3YjNNNklGQnZjMmwwYVc5dUxBb2dJQ0FnTHk4Z0lDQWdJR1Y0YVhSZmNISnBZMlU2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCc1pYWmxjbUZuWlRvZ1ZVbHVkRFkwTEFvZ0lDQWdMeThnS1NBdFBpQlZTVzUwTmpRNkNpQWdJQ0J3Y205MGJ5QXpJRElLSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZOamM0Q2lBZ0lDQXZMeUJsYm5SeWVTQTlJSEJ2Y3k1bGJuUnllVjl3Y21salpTNXVZWFJwZG1VS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdjSFZ6YUdsdWRDQXhOd29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdZM0psYzJOaFgySjFZMnRsZEY5d2NtOTBiMk52YkM1d2VUbzJOemtLSUNBZ0lDOHZJRzFoY21kcGJpQTlJSEJ2Y3k1dFlYSm5hVzR1Ym1GMGFYWmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUhCMWMyaHBiblFnT1FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUdOeVpYTmpZVjlpZFdOclpYUmZjSEp2ZEc5amIyd3VjSGs2Tmpnd0NpQWdJQ0F2THlCd2NtbGpaVjlqYUdGdVoyVWdQU0JsZUdsMFgzQnlhV05sSUMwZ1pXNTBjbmtnYVdZZ1pYaHBkRjl3Y21salpTQStQU0JsYm5SeWVTQmxiSE5sSUdWdWRISjVJQzBnWlhocGRGOXdjbWxqWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQThQUW9nSUNBZ1lub2dYMk5oYkdOMWJHRjBaVjl3Ym14ZllXSnpYM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdMUW9LWDJOaGJHTjFiR0YwWlY5d2JteGZZV0p6WDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lDOHZJR055WlhOallWOWlkV05yWlhSZmNISnZkRzlqYjJ3dWNIazZOamd4Q2lBZ0lDQXZMeUJ3Ym13NklGVkpiblEyTkNBOUlDaHdjbWxqWlY5amFHRnVaMlVnS2lCdFlYSm5hVzRnS2lCc1pYWmxjbUZuWlNrZ0x5OGdaVzUwY25rS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQXFDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNvS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQXZDaUFnSUNBdkx5QmpjbVZ6WTJGZlluVmphMlYwWDNCeWIzUnZZMjlzTG5CNU9qWTRNZ29nSUNBZ0x5OGdjbVYwZFhKdUlIQnViQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2NtVjBjM1ZpQ2dwZlkyRnNZM1ZzWVhSbFgzQnViRjloWW5OZmRHVnlibUZ5ZVY5bVlXeHpaVUF5T2dvZ0lDQWdMeThnWTNKbGMyTmhYMkoxWTJ0bGRGOXdjbTkwYjJOdmJDNXdlVG8yT0RBS0lDQWdJQzh2SUhCeWFXTmxYMk5vWVc1blpTQTlJR1Y0YVhSZmNISnBZMlVnTFNCbGJuUnllU0JwWmlCbGVHbDBYM0J5YVdObElENDlJR1Z1ZEhKNUlHVnNjMlVnWlc1MGNua2dMU0JsZUdsMFgzQnlhV05sQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBdENpQWdJQ0JpSUY5allXeGpkV3hoZEdWZmNHNXNYMkZpYzE5MFpYSnVZWEo1WDIxbGNtZGxRRE1LIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBSEFBRUlBc2dEaUFHQXd0Y3ZKZ3NJQUFBQUFBQUFBQUFCQUFRVkgzeDFFVzl5WVdOc1pWOTFjR1JoZEdWa1gyRjBCR0pyZEY4RkZSOThkWUFFWTI5c1h3OTBiM1JoYkY5d2IzTnBkR2x2Ym5NTmRHOTBZV3hmWW5WamEyVjBjd1J3YjNOZkJIQnlZMTh4R0VBQUN5Y0hJbWNuQ0NKbkt5Sm5NUnRCQUhFeEdSUkVNUmhFZ2c0RTc1R2NDZ1FYRXE1MEJEemVRdHdFYmlWSjNBU1ZibjZQQkswaXpkOEVINTdFdWdTVkRIT2RCRnc5ODFnRTVIckJ0Z1RIL0Q5SEJPZFBYblFFMVhMS2hBUVZaSFdvTmhvQWpnNEFDUUo4QXNZREN3UEhCTllHaHdiNUIrNElEd2h3Q0hzSWh3aVRBREVaRkRFWUZCQkRJa2NRZ0FBMkdnRkhBaUpaU1U0Q1NTUUxKUWhQQWhWSlRnTVNSRFlhQWtsT0Fra2lXVWxPQTBra0N5VUlUd0lWRWtRMkdnTkpUZ05KRlNRU1JFc0NUd0lTUkVzQlJFd2tEa1FYU1VTQmxnRU9SQ0pKU1VzRURFRUFHVXNFVndJQVN3RkpUZ0lrQzF0TEF3aEZBeU1JUlFGQy8rQkxBWUZrRWtReEFFbEZHb0FFWW10algweFFTVVVidlVVQlFRSGRTeG0rUkJkRkNVc0dRUUhMU3dkWEFnaEZHRXNHSXcxQkFiZExCMWNLQ0VVWFN3WWxEVUVCbzBzSFZ4SUlSUkZMQm9FRERVRUJqa3NIVnhvSVJSQkxCb0VFRFVFQmVVc0hWeUlJUlE5TEJvRUZEVUVCWkVzSFZ5b0lSUTVMQm9FR0RVRUJUMHNIVnpJSVJRMUxCb0VIRFVFQk9rc0hWem9JUlF4TEEwRUJLRXNFVndJSVJRdExBeU1OUVFFVVN3UlhDZ2hGQ2tzREpRMUJBUUJMQkZjU0NFVVdTd09CQXcxQkFPdExCRmNhQ0VVVlN3T0JCQTFCQU5aTEJGY2lDRVVVU3dPQkJRMUJBTUZMQkZjcUNFVVRTd09CQmcxQkFLeExCRmN5Q0VVU1N3T0JCdzFCQUpsTEJGYzZDRXNIRmtzWlN4bFFTeE5RU3hKUVN4RlFTeEJRU3c5UVN3NVFTdzFRU3d4UVN4aFFTeGRRU3haUVN4VlFTeFJRVHdKUVRGQkxBMGxPQWxCTEdrbE9BbENBQVlCUUp3UXhBRkJMREVsT0FoWk1Td0ZRVHdPL1RDTUlGa3NkVEw4aUp3aGxSQ01JSndoTVowbFBBbENBQWdBMFVJRTBTd2tJRmxjR0FsQlBBbEJMQ1ZCTEJsQ0FCRzlLallOTVVMQXFURkN3STBNb1F2OW9LRVVTUXY5VktFVVRRdjlBS0VVVVF2OHJLRVVWUXY4V0tFVVdRdjhCS0VVS1F2N3RLRVVMUXY3WktFVU1RdjdIS0VVTlF2NnlLRVVPUXY2ZEtFVVBRdjZJS0VVUVF2NXpLRVVSUXY1ZUtFVVhRdjVLS0VVWVF2NDJJa1VKUXY0a01SWWpDVWs0RUNNU1JFazRCeklLRWtRNENFbEVNUUFpSndZeEFGQkp2VVVCUVFBR1NiNUVGMFVDU3dGTEJFbE9BZ2dXU3dKTXZ4WkxBMHhRZ0FRS3Z5NHdURkN3SndXd0kwTTJHZ0ZKRlNRU1JERUFKd1pMQVZCSnZVVUJSRW0rU0JkTEF4ZEtEMFJNU3dFSkZrOENUTCt4TVFDeUI3SUlJN0lRSXJJQnMweFFnQVNsTk9qR1RGQ3dKd1d3STBNMkdnRkpGU1FTUkRZYUFra1ZJeEpFTmhvRFNSVWtFa1F5QnlJclpVUUpnUjRPUkRFQVNVc0VGeWNFVHdKUVRCWlFTYjFGQVVTK1NFbUJnQXRUS1NKUEFsUWlVMFJKVjVBZ1N3SVNSQ2NHU3dKUVNiMUZBVVJKdmtnWFN3UVhTZzlFQ1JhL2lBVTZTQ0luQjJWRVRCWXlCeFpMQmtzR1VFc0ZVRXNDVUVzRVVJQUJnRkJNVUNjSk1RQlFTd01XVEVzQlVFOEN2MDhDSXdnbkIweG5TVThHVUU4RFVFOEVVRThEVUU4Q1VJQUVoZjVvZ0V4UXNDcE1VTEFqUXlLQUFFazJHZ0ZIQWhVa0VrUXlCeUlyWlVRSmdSNE9SREVBU1U4Q01RQk1GeWNKVHdKUVRCWlFTYjFGQVVSSnZraEpJUVJUS1NKUEFsUWlVMFJKVnhrZ1R3TVNSREVBU3dGWEFBZ25CRThDVUV4UXZrU0lCSTBoQlZ0UEFrc0NUd0tJQmFwTVRnTk1pQVZ3VEVsT0FrNERTVmNBQ0VzQmdVQlRLU0pQQWxSTEFsY0pDRXNEVnhFSVN3UlhHU0JMQlZjNkNFOEZUd1ZRVHdSUVR3TlFUd0pRS1ZCTVVFOERUTCtCQ1Z0TVFRQkpTVXNEQ0VVR0lrVUhKd1pMQkZCSlJRbTlSUUZCQUFkTEI3NUVGMFVIU3daTEJnZ1dTd2hNdjBzQ0Zpa2lTd1JVU3daTEJsQkxBbEJNVUlBRWxEWm1vMHhRc0NwTVVMQWpRMGxMQXcxQkFBbEpTd01KUlFaQy82MGlSUVpDLzZjaVJ3NDJHZ0ZIQWhVa0VrUTJHZ0pKVGdKSklsbEpUZ05KSkFzbENFOENGUkpFTVFCUEFoY25CRThDVUV3V1VFbE9Ba205UlFGRXZraEpUZ0pKVjVBZ1NVNERNUUFTUkVsWGdBaE9Bb0dBQVZzU1JDSkpTVXNIREVFQUdVc0hWd0lBU3dGSlRnSWtDMXRMQXdoRkF5TUlSUUZDLytCTEFZRmtFa1JMQkVsWEFBaEZHVWxYQ0FoRkdFbFhFQWhGRjBsWEdBaEZGa2xYSUFoRkZVbFhLQWhGRkVsWE1BaEZFMWM0Q0VVUlN3WkJBUHBMQjFjQ0NFVVFTd1lqRFVFQTVrc0hWd29JUlE5TEJpVU5RUURTU3dkWEVnaEZEa3NHZ1FNTlFRQzlTd2RYR2doRkRVc0dnUVFOUVFDb1N3ZFhJZ2hGREVzR2dRVU5RUUNUU3dkWEtnaEZDMHNHZ1FZTlFRQitTd2RYTWdoRkNrc0dnUWNOUVFCclN3ZFhPZ2hMQlVsWGlBaE1nWUFMVXlraVR3SlVTeHBMR2xCTEdWQkxHRkJMRjFCTEZsQkxGVkJMRkZCTEUxQkxFbEJMRVZCTEVGQkxEMUJMRGxCTERWQlBBMUJMQlZCUEFsQkxCVkJNVUVzR1RMOUxDSUFDQUFwUVN3aFFnQVM3N0xiWFRGQ3dKd1d3STBNb1F2K1dLRVVLUXYrREtFVUxRdjl1S0VVTVF2OVpLRVVOUXY5RUtFVU9Rdjh2S0VVUFF2OGJLRVVRUXY4SE5ob0JSd0lpV1VsT0Fra2tDeVVJVHdJVkVrUTJHZ0pKVGdKSklsbEpKQXNsQ0U4Q0ZSSkVFa1FpU1VzRERFRUFPRXNEVndJQVN3RkpUZ0lrQzB4TEFTUllTd1JYQWdCUEFpUllKd3BMQWxBeUJ4WkxBa3hRdjFDQUJBWWE2eVZNVUxBakNFVUJRdi9CS3pJSFp5Y0ZzQ05ETmhvQlJ3SVZnU0FTUkRZYUFrbE9Ba2tWSkJKRU1nY2lLMlZFQ1lFZURrUVhKd2xMQWxCTUZsQkpUZ0pKdlVVQlJMNUlTU0VFVXlraVR3SlVJbE5FU1ZjQUNDY0VUd05RVEZDK1JJZ0JaQ0VGVzA4Q1N3SlBBb2dDZ1V4T0FreUlBa2RKVHdKTVNWY0pDRTRDZ1FsYlRFRUFjRWxMQkFoTEFZRUZDNEZrQ2c1RVN3SkpWd0FJU3dHQlFGTXBJazhDVkVzQ1Z4RUlTd05YR1NCUEJGYzZDRThFVHdSUVN3VlFUd05RVHdKUUtWQk1VRXNGVEw5TEJVc0hVSUFYQUNvQUUwbHVjM1ZtWm1samFXVnVkQ0J0WVhKbmFXNVFnQVMxeWRFOFRGQ3dKd1d3STBOSlN3UU5RUUFIU1VzRUNVTC9oaUpDLzRJMkdnRkpGWUVnRWtRbkJreFFTYjFGQVVFQUNVbStSQ3BNVUxBalF5aEMvL1lpTmhvQlJ3SVZnU0FTUkRZYUFra1ZKQkpFRnljSlR3SlFUQlpRU2IxRkFVQUFCeWdxVEZDd0kwTkp2a3hKVGdKRkJVUWhCRk1wSWs4Q1ZDSlRRQUFFS0VMLzRFc0NTVmNBQ0NjRVN3UlFURkMrUklnQVJ5RUZXNGdCYWtnV1F2L0RJaXRsUkJZcVRGQ3dJME1pSndkbFJCWXFURkN3STBNaUp3aGxSQllxVEZDd0kwTXhGaU1KU1RnUUl4SkVTVGdITWdvU1JEZ0lSQ2NGc0NORGlnRUNJb0FBaS8rQmdBRmJJa21MQklzQ0RFRUEwNHNFUUFBNGkvOGlXNHYvZ1VCYmpBRVdKd3BNVUVtTUFMMUZBVUVBR29zQXZrUWlXNHNCQzRGa0Nvc0RDSXdEaXdRakNJd0VRdi9BSVFaQy8rZUxCQ01TUVFBT2kvOGtXNHYvZ1VoYmpBRkMvNzZMQkNVU1FRQVBpLytCRUZ1TC80RlFXNHdCUXYrb2l3U0JBeEpCQUErTC80RVlXNHYvZ1ZoYmpBRkMvNUdMQklFRUVrRUFENHYvZ1NCYmkvK0JZRnVNQVVML2Vvc0VnUVVTUVFBUGkvK0JLRnVMLzRGb1c0d0JRdjlqaXdTQkJoSkJBQStMLzRFd1c0di9nWEJiakFGQy8weUwvNEU0VzR2L2dYaGJqQUZDL3owaEJvc0RTVTJMLzR3QmpBQ0ppZ0lDaS82QkVWdUwvb0ZBVXlraVR3SlVJbE5CQUE2TC93NUJBQVFqaS82SklvditpWXYvRDBFQUJDT0wvb2tpaS82SmlnTUNpLzJCRVZ0SmkvMkJDVnRNaS80T1FRQVZpLzZMQUFtTEFRdUwvd3VMQUFxTC9VOERUd09KaXdDTC9nbEMvK2c9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiQnVja2V0Q3JlYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQ29sbGF0ZXJhbERlcG9zaXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJDb2xsYXRlcmFsV2l0aGRyYXduIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlBvc2l0aW9uT3BlbmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ1IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ2IiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJQb3NpdGlvbkNsb3NlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQnVja2V0UmViYWxhbmNlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiT3JhY2xlVXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkxpcXVpZGF0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
