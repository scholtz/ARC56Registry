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

namespace Arc56.Generated.swanandi_bhende.mercator.SubscriptionManager_69960422
{


    public class SubscriptionManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SubscriptionManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class SubscriptionRecord : AVMObjectType
            {
                public ulong SubscribedAtRound { get; set; }

                public ulong ExpiryRound { get; set; }

                public ulong TotalMonthsPaid { get; set; }

                public ulong TotalUsdcPaid { get; set; }

                public ulong LastPaymentRound { get; set; }

                public string SourceType { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSubscribedAtRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSubscribedAtRound.From(SubscribedAtRound);
                    ret.AddRange(vSubscribedAtRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiryRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiryRound.From(ExpiryRound);
                    ret.AddRange(vExpiryRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalMonthsPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalMonthsPaid.From(TotalMonthsPaid);
                    ret.AddRange(vTotalMonthsPaid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalUsdcPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalUsdcPaid.From(TotalUsdcPaid);
                    ret.AddRange(vTotalUsdcPaid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastPaymentRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastPaymentRound.From(LastPaymentRound);
                    ret.AddRange(vLastPaymentRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSourceType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSourceType.From(SourceType);
                    stringRef[ret.Count] = vSourceType.Encode();
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

                public static SubscriptionRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new SubscriptionRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSubscribedAtRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSubscribedAtRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSubscribedAtRound = vSubscribedAtRound.ToValue();
                    if (valueSubscribedAtRound is ulong vSubscribedAtRoundValue) { ret.SubscribedAtRound = vSubscribedAtRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiryRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiryRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiryRound = vExpiryRound.ToValue();
                    if (valueExpiryRound is ulong vExpiryRoundValue) { ret.ExpiryRound = vExpiryRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalMonthsPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalMonthsPaid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalMonthsPaid = vTotalMonthsPaid.ToValue();
                    if (valueTotalMonthsPaid is ulong vTotalMonthsPaidValue) { ret.TotalMonthsPaid = vTotalMonthsPaidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalUsdcPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalUsdcPaid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalUsdcPaid = vTotalUsdcPaid.ToValue();
                    if (valueTotalUsdcPaid is ulong vTotalUsdcPaidValue) { ret.TotalUsdcPaid = vTotalUsdcPaidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastPaymentRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastPaymentRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastPaymentRound = vLastPaymentRound.ToValue();
                    if (valueLastPaymentRound is ulong vLastPaymentRoundValue) { ret.LastPaymentRound = vLastPaymentRoundValue; }
                    var indexSourceType = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSourceType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSourceType.Decode(bytes.Skip(indexSourceType + prefixOffset).ToArray());
                    var valueSourceType = vSourceType.ToValue();
                    if (valueSourceType is string vSourceTypeValue) { ret.SourceType = vSourceTypeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SubscriptionRecord);
                }
                public bool Equals(SubscriptionRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SubscriptionRecord left, SubscriptionRecord right)
                {
                    return EqualityComparer<SubscriptionRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(SubscriptionRecord left, SubscriptionRecord right)
                {
                    return !(left == right);
                }

            }

            public class GetConfigReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetConfigReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetConfigReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetConfigReturn);
                }
                public bool Equals(GetConfigReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetConfigReturn left, GetConfigReturn right)
                {
                    return EqualityComparer<GetConfigReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetConfigReturn left, GetConfigReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class SubscriptionManagerCreatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 145, 185, 14, 180 };
                public const string Signature = "SubscriptionManagerCreated(address,uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public ulong Field2 { get; set; }
                public ulong Field3 { get; set; }
                public ulong Field4 { get; set; }

                public static SubscriptionManagerCreatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SubscriptionManagerCreatedEvent();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

            }

            public class SubscriptionEscrowAppSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 183, 192, 37, 228 };
                public const string Signature = "SubscriptionEscrowAppSet(uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }

                public static SubscriptionEscrowAppSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SubscriptionEscrowAppSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

            }

            public class SubscriptionMonthlyRateUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 43, 143, 231, 213 };
                public const string Signature = "SubscriptionMonthlyRateUpdated(uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }

                public static SubscriptionMonthlyRateUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SubscriptionMonthlyRateUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

            }

            public class SubscriptionRoundsPerMonthUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 51, 225, 210, 239 };
                public const string Signature = "SubscriptionRoundsPerMonthUpdated(uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }

                public static SubscriptionRoundsPerMonthUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SubscriptionRoundsPerMonthUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

            }

            public class SubscriptionRecordedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 192, 0, 43, 23 };
                public const string Signature = "SubscriptionRecorded(address,uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public ulong Field2 { get; set; }
                public ulong Field3 { get; set; }
                public ulong Field4 { get; set; }

                public static SubscriptionRecordedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SubscriptionRecordedEvent();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="monthly_rate"> </param>
        /// <param name="rounds_per_month"> </param>
        /// <param name="usdc_id"> </param>
        public async Task Create(ulong monthly_rate, ulong rounds_per_month, ulong usdc_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 253, 164, 210 };
            var monthly_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); monthly_rateAbi.From(monthly_rate);
            var rounds_per_monthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rounds_per_monthAbi.From(rounds_per_month);
            var usdc_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_idAbi.From(usdc_id);

            var result = await base.CallApp(new List<object> { abiHandle, monthly_rateAbi, rounds_per_monthAbi, usdc_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong monthly_rate, ulong rounds_per_month, ulong usdc_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 253, 164, 210 };
            var monthly_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); monthly_rateAbi.From(monthly_rate);
            var rounds_per_monthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rounds_per_monthAbi.From(rounds_per_month);
            var usdc_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_idAbi.From(usdc_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, monthly_rateAbi, rounds_per_monthAbi, usdc_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="escrow_app_id"> </param>
        public async Task SetEscrowApp(ulong escrow_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 8, 30, 186 };
            var escrow_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrow_app_idAbi.From(escrow_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, escrow_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetEscrowApp_Transactions(ulong escrow_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 8, 30, 186 };
            var escrow_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrow_app_idAbi.From(escrow_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrow_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="monthly_rate"> </param>
        public async Task SetMonthlyRate(ulong monthly_rate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 239, 55, 205 };
            var monthly_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); monthly_rateAbi.From(monthly_rate);

            var result = await base.CallApp(new List<object> { abiHandle, monthly_rateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetMonthlyRate_Transactions(ulong monthly_rate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 239, 55, 205 };
            var monthly_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); monthly_rateAbi.From(monthly_rate);

            return await base.MakeTransactionList(new List<object> { abiHandle, monthly_rateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="rounds_per_month"> </param>
        public async Task SetRoundsPerMonth(ulong rounds_per_month, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 127, 115, 111 };
            var rounds_per_monthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rounds_per_monthAbi.From(rounds_per_month);

            var result = await base.CallApp(new List<object> { abiHandle, rounds_per_monthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetRoundsPerMonth_Transactions(ulong rounds_per_month, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 127, 115, 111 };
            var rounds_per_monthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rounds_per_monthAbi.From(rounds_per_month);

            return await base.MakeTransactionList(new List<object> { abiHandle, rounds_per_monthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OptInUsdc(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 52, 213, 214 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInUsdc_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 52, 213, 214 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="months"> </param>
        public async Task Subscribe(ulong months, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 59, 196, 23 };
            var monthsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); monthsAbi.From(months);

            var result = await base.CallApp(new List<object> { abiHandle, monthsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Subscribe_Transactions(ulong months, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 59, 196, 23 };
            var monthsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); monthsAbi.From(months);

            return await base.MakeTransactionList(new List<object> { abiHandle, monthsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<bool> IsActive(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 4, 37, 58 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsActive_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 4, 37, 58 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<Structs.SubscriptionRecord> GetSubscription(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 91, 115, 183 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SubscriptionRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetSubscription_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 91, 115, 183 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<ulong> GetExpiryRound(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 48, 219, 115 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetExpiryRound_Transactions(Algorand.Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 48, 219, 115 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetConfigReturn> GetConfig(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 78, 110, 130 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetConfigReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetConfig_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 78, 110, 130 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="buyer"> </param>
        /// <param name="listing_id"> </param>
        public async Task<bool> ReleaseForSubscriber(Algorand.Address buyer, ulong listing_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 60, 94, 7 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);
            var listing_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_idAbi.From(listing_id);

            var result = await base.CallApp(new List<object> { abiHandle, buyerAbi, listing_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ReleaseForSubscriber_Transactions(Algorand.Address buyer, ulong listing_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 60, 94, 7 };
            var buyerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); buyerAbi.From(buyer);
            var listing_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); listing_idAbi.From(listing_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, buyerAbi, listing_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task WithdrawSubscriptionRevenue(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 197, 138, 172 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawSubscriptionRevenue_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 197, 138, 172 };

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

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3Vic2NyaXB0aW9uTWFuYWdlciIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTdWJzY3JpcHRpb25SZWNvcmQiOlt7Im5hbWUiOiJzdWJzY3JpYmVkX2F0X3JvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImV4cGlyeV9yb3VuZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbF9tb250aHNfcGFpZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbF91c2RjX3BhaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdF9wYXltZW50X3JvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNvdXJjZV90eXBlIiwidHlwZSI6InN0cmluZyJ9XSwiR2V0Q29uZmlnUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1vbnRobHlfcmF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm91bmRzX3Blcl9tb250aCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNkY19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiU3Vic2NyaXB0aW9uTWFuYWdlckNyZWF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9lc2Nyb3dfYXBwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImVzY3Jvd19hcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlN1YnNjcmlwdGlvbkVzY3Jvd0FwcFNldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfbW9udGhseV9yYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1vbnRobHlfcmF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiU3Vic2NyaXB0aW9uTW9udGhseVJhdGVVcGRhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9yb3VuZHNfcGVyX21vbnRoIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvdW5kc19wZXJfbW9udGgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlN1YnNjcmlwdGlvblJvdW5kc1Blck1vbnRoVXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRfaW5fdXNkYyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdWJzY3JpYmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibW9udGhzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJTdWJzY3JpcHRpb25SZWNvcmRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ0IiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfYWN0aXZlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfc3Vic2NyaXB0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsc3RyaW5nKSIsInN0cnVjdCI6IlN1YnNjcmlwdGlvblJlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2V4cGlyeV9yb3VuZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfY29uZmlnIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldENvbmZpZ1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVsZWFzZV9mb3Jfc3Vic2NyaWJlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnV5ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxpc3RpbmdfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXdfc3Vic2NyaXB0aW9uX3JldmVudWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjo3fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls3NDBdLCJlcnJvck1lc3NhZ2UiOiJFeHBpcnkgcm91bmQgb3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDg2XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBzdWJzY3JpcHRpb24gc291cmNlIHR5cGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NDddLCJlcnJvck1lc3NhZ2UiOiJNb250aCBjb3VudGVyIG92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTM1LDk2MSwxMDU0XSwiZXJyb3JNZXNzYWdlIjoiTm8gc3Vic2NyaXB0aW9uIHJlY29yZCBmb3VuZCBmb3IgdGhpcyB3YWxsZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDhdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRoZSBjb250cmFjdCBvd25lciBjYW4gb3B0IHRoZSBhcHAgaW50byBVU0RDIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMxXSwiZXJyb3JNZXNzYWdlIjoiT25seSB0aGUgY29udHJhY3Qgb3duZXIgY2FuIHNldCB0aGUgRXNjcm93IGFwcCBJRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIGNvbnRyYWN0IG93bmVyIGNhbiB1cGRhdGUgcm91bmRzX3Blcl9tb250aCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2NV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIGNvbnRyYWN0IG93bmVyIGNhbiB1cGRhdGUgdGhlIG1vbnRobHkgcmF0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMDRdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRoZSBjb250cmFjdCBvd25lciBjYW4gd2l0aGRyYXcgc3Vic2NyaXB0aW9uIHJldmVudWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDRdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IGFtb3VudCBpcyBiZWxvdyB0aGUgcmVxdWlyZWQgc3Vic2NyaXB0aW9uIHByaWNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjUxXSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBtdXN0IGJlIHNlbnQgdG8gdGhpcyBjb250cmFjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzNl0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCB1c2UgdGhlIGNvbmZpZ3VyZWQgVVNEQyBhc3NldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1OF0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgc2VuZGVyIG11c3QgbWF0Y2ggdGhlIHN1YnNjcmliaW5nIHdhbGxldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc4OF0sImVycm9yTWVzc2FnZSI6IlJldmVudWUgY291bnRlciBvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2OV0sImVycm9yTWVzc2FnZSI6IlN1YnNjcmliZXIgY291bnRlciBvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1NV0sImVycm9yTWVzc2FnZSI6IlN1YnNjcmliZXIgcGF5bWVudCBjb3VudGVyIG92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0NV0sImVycm9yTWVzc2FnZSI6IlN1YnNjcmlwdGlvbiBpcyBub3QgYWN0aXZlIG9yIGhhcyBleHBpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzMzXSwiZXJyb3JNZXNzYWdlIjoiU3Vic2NyaXB0aW9uIGxlbmd0aCBvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMzZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmVzY3Jvd19hcHBfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjIyLDk3Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubW9udGhseV9yYXRlX21pY3JvX3VzZGMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI5LDQ2Myw1MTksNTQ2LDExMDJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm93bmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyMyw5ODFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJvdW5kc19wZXJfbW9udGggZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzc4LDk5MCwxMTA4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9yZXZlbnVlX21pY3JvX3VzZGMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzYzLDk4Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfc3Vic2NyaWJlcnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEyNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudHJlYXN1cnlfYWRkcmVzcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTMsNjMwLDk5NCwxMTE4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi51c2RjX2Fzc2V0X2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4MCw2OTUsNzA5LDcxNiw5NjQsMTE3Ml0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MDgsOTI2LDk1MiwxMDIyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMywzMzMsMzQzLDQyMyw0NTcsNTEzLDU5MSwxMDI5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYwLDQ4Ml0sImVycm9yTWVzc2FnZSI6Im1vbnRobHlfcmF0ZSBtdXN0IGJlIGJldHdlZW4gMSwwMDAsMDAwIGFuZCAxLDAwMCwwMDAsMDAwIG1pY3JvVVNEQyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwNV0sImVycm9yTWVzc2FnZSI6Im1vbnRocyBtdXN0IGJlIGJldHdlZW4gMSBhbmQgMTIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDM4XSwiZXJyb3JNZXNzYWdlIjoicmVsZWFzZV9mb3Jfc3Vic2NyaWJlciBjYW4gb25seSBiZSBjYWxsZWQgYnkgdGhlIEVzY3JvdyBjb250cmFjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyNF0sImVycm9yTWVzc2FnZSI6InJvdW5kc19wZXJfbW9udGggbXVzdCBiZSBncmVhdGVyIHRoYW4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxN10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXhmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQXpNaUF4TURBd01EQXdJREV3TURBd01EQXdNREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbTkzYm1WeUlpQXdlREF3TURBd01EQXdNREF3TURBd01EQWdJblZ6WkdOZllYTnpaWFJmYVdRaUlDSjBiM1JoYkY5eVpYWmxiblZsWDIxcFkzSnZYM1Z6WkdNaUlDSnRiMjUwYUd4NVgzSmhkR1ZmYldsamNtOWZkWE5rWXlJZ0luSnZkVzVrYzE5d1pYSmZiVzl1ZEdnaUlEQjROek0zTlRZeU5XWWdJblJ2ZEdGc1gzTjFZbk5qY21saVpYSnpJaUF3ZURFMU1XWTNZemMxSUNKMGNtVmhjM1Z5ZVY5aFpHUnlaWE56SWlBaVpYTmpjbTkzWDJGd2NGOXBaQ0lLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pNMUNpQWdJQ0F2THlCelpXeG1MbTkzYm1WeUxuWmhiSFZsSUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG96TmdvZ0lDQWdMeThnYzJWc1ppNTBjbVZoYzNWeWVWOWhaR1J5WlhOekxuWmhiSFZsSUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0owY21WaGMzVnllVjloWkdSeVpYTnpJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pNM0NpQWdJQ0F2THlCelpXeG1MbVZ6WTNKdmQxOWhjSEJmYVdRdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKbGMyTnliM2RmWVhCd1gybGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRvek9Bb2dJQ0FnTHk4Z2MyVnNaaTV0YjI1MGFHeDVYM0poZEdWZmJXbGpjbTlmZFhOa1l5NTJZV3gxWlNBOUlHRnlZelF1VlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p0YjI1MGFHeDVYM0poZEdWZmJXbGpjbTlmZFhOa1l5SUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmMzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVjSGs2TXprS0lDQWdJQzh2SUhObGJHWXVjbTkxYm1SelgzQmxjbDl0YjI1MGFDNTJZV3gxWlNBOUlHRnlZelF1VlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p5YjNWdVpITmZjR1Z5WDIxdmJuUm9JZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRvME1Bb2dJQ0FnTHk4Z2MyVnNaaTUxYzJSalgyRnpjMlYwWDJsa0xuWmhiSFZsSUQwZ1lYSmpOQzVWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblZ6WkdOZllYTnpaWFJmYVdRaUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDNOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxuQjVPalF4Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNOMVluTmpjbWxpWlhKekxuWmhiSFZsSUQwZ1lYSmpOQzVWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblJ2ZEdGc1gzTjFZbk5qY21saVpYSnpJZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRvME1nb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXlaWFpsYm5WbFgyMXBZM0p2WDNWelpHTXVkbUZzZFdVZ1BTQmhjbU0wTGxWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZjbVYyWlc1MVpWOXRhV055YjE5MWMyUmpJZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDNOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxuQjVPakV6Q2lBZ0lDQXZMeUJqYkdGemN5QlRkV0p6WTNKcGNIUnBiMjVOWVc1aFoyVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREUzQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TkdVd09ERmxZbUVnTUhnd1pHVm1NemRqWkNBd2VHTTJOMlkzTXpabUlEQjRZamN6TkdRMVpEWWdNSGd4WXpOaVl6UXhOeUF3ZURnM01EUXlOVE5oSURCNFkySTFZamN6WWpjZ01IZ3lOak13WkdJM015QXdlRGs0TkdVMlpUZ3lJREI0TUdNell6VmxNRGNnTUhnNVkyTTFPR0ZoWXlBdkx5QnRaWFJvYjJRZ0luTmxkRjlsYzJOeWIzZGZZWEJ3S0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJmYlc5dWRHaHNlVjl5WVhSbEtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSZmNtOTFibVJ6WDNCbGNsOXRiMjUwYUNoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWliM0IwWDJsdVgzVnpaR01vS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk4xWW5OamNtbGlaU2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWFYTmZZV04wYVhabEtHRmtaSEpsYzNNcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzTjFZbk5qY21sd2RHbHZiaWhoWkdSeVpYTnpLU2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSE4wY21sdVp5a2lMQ0J0WlhSb2IyUWdJbWRsZEY5bGVIQnBjbmxmY205MWJtUW9ZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjlqYjI1bWFXY29LU2gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpY21Wc1pXRnpaVjltYjNKZmMzVmljMk55YVdKbGNpaGhaR1J5WlhOekxIVnBiblEyTkNsaWIyOXNJaXdnYldWMGFHOWtJQ0ozYVhSb1pISmhkMTl6ZFdKelkzSnBjSFJwYjI1ZmNtVjJaVzUxWlNncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhObGRGOWxjMk55YjNkZllYQndJSE5sZEY5dGIyNTBhR3g1WDNKaGRHVWdjMlYwWDNKdmRXNWtjMTl3WlhKZmJXOXVkR2dnYjNCMFgybHVYM1Z6WkdNZ2MzVmljMk55YVdKbElHbHpYMkZqZEdsMlpTQm5aWFJmYzNWaWMyTnlhWEIwYVc5dUlHZGxkRjlsZUhCcGNubGZjbTkxYm1RZ1oyVjBYMk52Ym1acFp5QnlaV3hsWVhObFgyWnZjbDl6ZFdKelkzSnBZbVZ5SUhkcGRHaGtjbUYzWDNOMVluTmpjbWx3ZEdsdmJsOXlaWFpsYm5WbENpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UYzZDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRveE13b2dJQ0FnTHk4Z1kyeGhjM01nVTNWaWMyTnlhWEIwYVc5dVRXRnVZV2RsY2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjROMlZtWkdFMFpESWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVW9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR055WldGMFpRb2dJQ0FnWlhKeUNnb0tMeThnYzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdVUzVmljMk55YVhCMGFXOXVUV0Z1WVdkbGNpNWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG8wTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXNJR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG8wTmdvZ0lDQWdMeThnYlc5dWRHaHNlVjl5WVhSbFgyNWhkR2wyWlNBOUlHMXZiblJvYkhsZmNtRjBaUzV1WVhScGRtVUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmMzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVjSGs2TkRjS0lDQWdJQzh2SUdGemMyVnlkQ0F4TURBd01EQXdJRHc5SUcxdmJuUm9iSGxmY21GMFpWOXVZWFJwZG1VZ1BEMGdNVEF3TURBd01EQXdNQ3dnS0FvZ0lDQWdhVzUwWXlBMElDOHZJREV3TURBd01EQUtJQ0FnSUQ0OUNpQWdJQ0JpZWlCamNtVmhkR1ZmWW05dmJGOW1ZV3h6WlVBMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05TQXZMeUF4TURBd01EQXdNREF3Q2lBZ0lDQThQUW9nSUNBZ1lub2dZM0psWVhSbFgySnZiMnhmWm1Gc2MyVkFOQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtDbU55WldGMFpWOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUbzBOeTAwT1FvZ0lDQWdMeThnWVhOelpYSjBJREV3TURBd01EQWdQRDBnYlc5dWRHaHNlVjl5WVhSbFgyNWhkR2wyWlNBOFBTQXhNREF3TURBd01EQXdMQ0FvQ2lBZ0lDQXZMeUFnSUNBZ0ltMXZiblJvYkhsZmNtRjBaU0J0ZFhOMElHSmxJR0psZEhkbFpXNGdNU3d3TURBc01EQXdJR0Z1WkNBeExEQXdNQ3d3TURBc01EQXdJRzFwWTNKdlZWTkVReUlLSUNBZ0lDOHZJQ2tLSUNBZ0lHRnpjMlZ5ZENBdkx5QnRiMjUwYUd4NVgzSmhkR1VnYlhWemRDQmlaU0JpWlhSM1pXVnVJREVzTURBd0xEQXdNQ0JoYm1RZ01Td3dNREFzTURBd0xEQXdNQ0J0YVdOeWIxVlRSRU1LSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qVXdDaUFnSUNBdkx5QnpaV3htTG05M2JtVnlMblpoYkhWbElEMGdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdmQyNWxjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRvMU1Rb2dJQ0FnTHk4Z2MyVnNaaTUwY21WaGMzVnllVjloWkdSeVpYTnpMblpoYkhWbElEMGdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKMGNtVmhjM1Z5ZVY5aFpHUnlaWE56SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qVXlDaUFnSUNBdkx5QnpaV3htTG0xdmJuUm9iSGxmY21GMFpWOXRhV055YjE5MWMyUmpMblpoYkhWbElEMGdiVzl1ZEdoc2VWOXlZWFJsQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p0YjI1MGFHeDVYM0poZEdWZmJXbGpjbTlmZFhOa1l5SUtJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUbzFNd29nSUNBZ0x5OGdjMlZzWmk1eWIzVnVaSE5mY0dWeVgyMXZiblJvTG5aaGJIVmxJRDBnY205MWJtUnpYM0JsY2w5dGIyNTBhQW9nSUNBZ1lubDBaV01nTlNBdkx5QWljbTkxYm1SelgzQmxjbDl0YjI1MGFDSUtJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUbzFOQW9nSUNBZ0x5OGdjMlZzWmk1MWMyUmpYMkZ6YzJWMFgybGtMblpoYkhWbElEMGdkWE5rWTE5cFpBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRYTmtZMTloYzNObGRGOXBaQ0lLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG8xT0FvZ0lDQWdMeThnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmMzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVjSGs2TlRZdE5qSUtJQ0FnSUM4dklHRnlZelF1WlcxcGRDZ0tJQ0FnSUM4dklDQWdJQ0FpVTNWaWMyTnlhWEIwYVc5dVRXRnVZV2RsY2tOeVpXRjBaV1FpTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQnRiMjUwYUd4NVgzSmhkR1VzQ2lBZ0lDQXZMeUFnSUNBZ2NtOTFibVJ6WDNCbGNsOXRiMjUwYUN3S0lDQWdJQzh2SUNBZ0lDQjFjMlJqWDJsa0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T1RGaU9UQmxZalFnTHk4Z2JXVjBhRzlrSUNKVGRXSnpZM0pwY0hScGIyNU5ZVzVoWjJWeVEzSmxZWFJsWkNoaFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRvME5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lzSUdGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BqY21WaGRHVmZZbTl2YkY5bVlXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdZM0psWVhSbFgySnZiMnhmYldWeVoyVkFOUW9LQ2k4dklITjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbE4xWW5OamNtbHdkR2x2YmsxaGJtRm5aWEl1YzJWMFgyVnpZM0p2ZDE5aGNIQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZlpYTmpjbTkzWDJGd2NEb0tJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pZMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJazV2VDNBaVhTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qWTJDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtOTNibVZ5TG5aaGJIVmxMbTVoZEdsMlpTd2dJazl1YkhrZ2RHaGxJR052Ym5SeVlXTjBJRzkzYm1WeUlHTmhiaUJ6WlhRZ2RHaGxJRVZ6WTNKdmR5QmhjSEFnU1VRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWliM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnZEdobElHTnZiblJ5WVdOMElHOTNibVZ5SUdOaGJpQnpaWFFnZEdobElFVnpZM0p2ZHlCaGNIQWdTVVFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qWTNDaUFnSUNBdkx5QnpaV3htTG1WelkzSnZkMTloY0hCZmFXUXVkbUZzZFdVZ1BTQmxjMk55YjNkZllYQndYMmxrTG1GelgzVnBiblEyTkNncENpQWdJQ0JrZFhBS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKbGMyTnliM2RmWVhCd1gybGtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qWTRDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9JbE4xWW5OamNtbHdkR2x2YmtWelkzSnZkMEZ3Y0ZObGRDSXNJR1Z6WTNKdmQxOWhjSEJmYVdRcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaU4yTXdNalZsTkNBdkx5QnRaWFJvYjJRZ0lsTjFZbk5qY21sd2RHbHZia1Z6WTNKdmQwRndjRk5sZENoMWFXNTBOalFwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDNOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxuQjVPalkwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrNXZUM0FpWFNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1VGRXSnpZM0pwY0hScGIyNU5ZVzVoWjJWeUxuTmxkRjl0YjI1MGFHeDVYM0poZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJmYlc5dWRHaHNlVjl5WVhSbE9nb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmMzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVjSGs2TnpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUbTlQY0NKZEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdWNIazZOeklLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXViM2R1WlhJdWRtRnNkV1V1Ym1GMGFYWmxMQ0FpVDI1c2VTQjBhR1VnWTI5dWRISmhZM1FnYjNkdVpYSWdZMkZ1SUhWd1pHRjBaU0IwYUdVZ2JXOXVkR2hzZVNCeVlYUmxJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW05M2JtVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG05M2JtVnlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlIUm9aU0JqYjI1MGNtRmpkQ0J2ZDI1bGNpQmpZVzRnZFhCa1lYUmxJSFJvWlNCdGIyNTBhR3g1SUhKaGRHVUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pjekNpQWdJQ0F2THlCdGIyNTBhR3g1WDNKaGRHVmZibUYwYVhabElEMGdiVzl1ZEdoc2VWOXlZWFJsTG01aGRHbDJaUW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRvM05Bb2dJQ0FnTHk4Z1lYTnpaWEowSURFd01EQXdNREFnUEQwZ2JXOXVkR2hzZVY5eVlYUmxYMjVoZEdsMlpTQThQU0F4TURBd01EQXdNREF3TENBb0NpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01EQXdNQW9nSUNBZ1BqMEtJQ0FnSUdKNklITmxkRjl0YjI1MGFHeDVYM0poZEdWZlltOXZiRjltWVd4elpVQTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTWdOU0F2THlBeE1EQXdNREF3TURBd0NpQWdJQ0E4UFFvZ0lDQWdZbm9nYzJWMFgyMXZiblJvYkhsZmNtRjBaVjlpYjI5c1gyWmhiSE5sUURRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwelpYUmZiVzl1ZEdoc2VWOXlZWFJsWDJKdmIyeGZiV1Z5WjJWQU5Ub0tJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pjMExUYzJDaUFnSUNBdkx5QmhjM05sY25RZ01UQXdNREF3TUNBOFBTQnRiMjUwYUd4NVgzSmhkR1ZmYm1GMGFYWmxJRHc5SURFd01EQXdNREF3TURBc0lDZ0tJQ0FnSUM4dklDQWdJQ0FpYlc5dWRHaHNlVjl5WVhSbElHMTFjM1FnWW1VZ1ltVjBkMlZsYmlBeExEQXdNQ3d3TURBZ1lXNWtJREVzTURBd0xEQXdNQ3d3TURBZ2JXbGpjbTlWVTBSRElnb2dJQ0FnTHk4Z0tRb2dJQ0FnWVhOelpYSjBJQzh2SUcxdmJuUm9iSGxmY21GMFpTQnRkWE4wSUdKbElHSmxkSGRsWlc0Z01Td3dNREFzTURBd0lHRnVaQ0F4TERBd01Dd3dNREFzTURBd0lHMXBZM0p2VlZORVF3b2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmMzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVjSGs2TnpjS0lDQWdJQzh2SUhObGJHWXViVzl1ZEdoc2VWOXlZWFJsWDIxcFkzSnZYM1Z6WkdNdWRtRnNkV1VnUFNCdGIyNTBhR3g1WDNKaGRHVUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltMXZiblJvYkhsZmNtRjBaVjl0YVdOeWIxOTFjMlJqSWdvZ0lDQWdaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pjNENpQWdJQ0F2THlCaGNtTTBMbVZ0YVhRb0lsTjFZbk5qY21sd2RHbHZiazF2Ym5Sb2JIbFNZWFJsVlhCa1lYUmxaQ0lzSUcxdmJuUm9iSGxmY21GMFpTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VESmlPR1psTjJRMUlDOHZJRzFsZEdodlpDQWlVM1ZpYzJOeWFYQjBhVzl1VFc5dWRHaHNlVkpoZEdWVmNHUmhkR1ZrS0hWcGJuUTJOQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdWNIazZOekFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2MyVjBYMjF2Ym5Sb2JIbGZjbUYwWlY5aWIyOXNYMlpoYkhObFFEUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCelpYUmZiVzl1ZEdoc2VWOXlZWFJsWDJKdmIyeGZiV1Z5WjJWQU5Rb0tDaTh2SUhOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxsTjFZbk5qY21sd2RHbHZiazFoYm1GblpYSXVjMlYwWDNKdmRXNWtjMTl3WlhKZmJXOXVkR2hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUmZjbTkxYm1SelgzQmxjbDl0YjI1MGFEb0tJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pnd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJazV2VDNBaVhTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qZ3lDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtOTNibVZ5TG5aaGJIVmxMbTVoZEdsMlpTd2dJazl1YkhrZ2RHaGxJR052Ym5SeVlXTjBJRzkzYm1WeUlHTmhiaUIxY0dSaGRHVWdjbTkxYm1SelgzQmxjbDl0YjI1MGFDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCMGFHVWdZMjl1ZEhKaFkzUWdiM2R1WlhJZ1kyRnVJSFZ3WkdGMFpTQnliM1Z1WkhOZmNHVnlYMjF2Ym5Sb0NpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG80TXdvZ0lDQWdMeThnWVhOelpYSjBJSEp2ZFc1a2MxOXdaWEpmYlc5dWRHZ3VibUYwYVhabElENGdNQ3dnSW5KdmRXNWtjMTl3WlhKZmJXOXVkR2dnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01DSUtJQ0FnSUdSMWNBb2dJQ0FnWW5SdmFRb2dJQ0FnWVhOelpYSjBJQzh2SUhKdmRXNWtjMTl3WlhKZmJXOXVkR2dnYlhWemRDQmlaU0JuY21WaGRHVnlJSFJvWVc0Z01Bb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmMzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVjSGs2T0RRS0lDQWdJQzh2SUhObGJHWXVjbTkxYm1SelgzQmxjbDl0YjI1MGFDNTJZV3gxWlNBOUlISnZkVzVrYzE5d1pYSmZiVzl1ZEdnS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5KdmRXNWtjMTl3WlhKZmJXOXVkR2dpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDNOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxuQjVPamcxQ2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvSWxOMVluTmpjbWx3ZEdsdmJsSnZkVzVrYzFCbGNrMXZiblJvVlhCa1lYUmxaQ0lzSUhKdmRXNWtjMTl3WlhKZmJXOXVkR2dwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd6TTJVeFpESmxaaUF2THlCdFpYUm9iMlFnSWxOMVluTmpjbWx3ZEdsdmJsSnZkVzVrYzFCbGNrMXZiblJvVlhCa1lYUmxaQ2gxYVc1ME5qUXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qZ3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTVUZFdKelkzSnBjSFJwYjI1TllXNWhaMlZ5TG05d2RGOXBibDkxYzJSalczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiM0IwWDJsdVgzVnpaR002Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUbzRPUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNXZkMjVsY2k1MllXeDFaUzV1WVhScGRtVXNJQ0pQYm14NUlIUm9aU0JqYjI1MGNtRmpkQ0J2ZDI1bGNpQmpZVzRnYjNCMElIUm9aU0JoY0hBZ2FXNTBieUJWVTBSRElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhSb1pTQmpiMjUwY21GamRDQnZkMjVsY2lCallXNGdiM0IwSUhSb1pTQmhjSEFnYVc1MGJ5QlZVMFJEQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUbzVNUzA1TmdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTljMlZzWmk1MWMyUmpYMkZ6YzJWMFgybGtMblpoYkhWbExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDB3TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NVEF3TUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUbzVNZ29nSUNBZ0x5OGdlR1psY2w5aGMzTmxkRDF6Wld4bUxuVnpaR05mWVhOelpYUmZhV1F1ZG1Gc2RXVXVibUYwYVhabExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5WelpHTmZZWE56WlhSZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZFhOa1kxOWhjM05sZEY5cFpDQmxlR2x6ZEhNS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDNOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxuQjVPamt6Q2lBZ0lDQXZMeUJoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2prMENpQWdJQ0F2THlCaGMzTmxkRjloYlc5MWJuUTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRvNU1Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRvNU5Rb2dJQ0FnTHk4Z1ptVmxQVlZKYm5RMk5DZ3hNREF3S1N3S0lDQWdJSEIxYzJocGJuUWdNVEF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDNOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxuQjVPamt4TFRrMkNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDF6Wld4bUxuVnpaR05mWVhOelpYUmZhV1F1ZG1Gc2RXVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFRBc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d4TURBd0tTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG80TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdVUzVmljMk55YVhCMGFXOXVUV0Z1WVdkbGNpNXpkV0p6WTNKcFltVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZFdKelkzSnBZbVU2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lHUjFjRzRnTndvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdWNIazZPVGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZjM1ZpYzJOeWFYQjBhVzl1WDIxaGJtRm5aWEl1Y0hrNk1UQXdDaUFnSUNBdkx5QnRiMjUwYUhOZmJtRjBhWFpsSUQwZ2JXOXVkR2h6TG01aGRHbDJaUW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRveE1ERUtJQ0FnSUM4dklHRnpjMlZ5ZENBeElEdzlJRzF2Ym5Sb2MxOXVZWFJwZG1VZ1BEMGdNVElzSUNKdGIyNTBhSE1nYlhWemRDQmlaU0JpWlhSM1pXVnVJREVnWVc1a0lERXlJZ29nSUNBZ1lub2djM1ZpYzJOeWFXSmxYMkp2YjJ4ZlptRnNjMlZBTkFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXlDaUFnSUNBOFBRb2dJQ0FnWW5vZ2MzVmljMk55YVdKbFgySnZiMnhmWm1Gc2MyVkFOQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtDbk4xWW5OamNtbGlaVjlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG94TURFS0lDQWdJQzh2SUdGemMyVnlkQ0F4SUR3OUlHMXZiblJvYzE5dVlYUnBkbVVnUEQwZ01USXNJQ0p0YjI1MGFITWdiWFZ6ZENCaVpTQmlaWFIzWldWdUlERWdZVzVrSURFeUlnb2dJQ0FnWVhOelpYSjBJQzh2SUcxdmJuUm9jeUJ0ZFhOMElHSmxJR0psZEhkbFpXNGdNU0JoYm1RZ01USUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pFd01nb2dJQ0FnTHk4Z1kyRnNiR1Z5SUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVFFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qRXdOQW9nSUNBZ0x5OGdjR0Y1YldWdWRGOTBlQ0E5SUdkMGVHNHVRWE56WlhSVWNtRnVjMlpsY2xSeVlXNXpZV04wYVc5dUtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QmhlR1psY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJR0Y0Wm1WeUNpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG94TURVS0lDQWdJQzh2SUhKbGNYVnBjbVZrWDNCaGVXMWxiblFnUFNCdGIyNTBhSE5mYm1GMGFYWmxJQ29nYzJWc1ppNXRiMjUwYUd4NVgzSmhkR1ZmYldsamNtOWZkWE5rWXk1MllXeDFaUzV1WVhScGRtVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKdGIyNTBhR3g1WDNKaGRHVmZiV2xqY205ZmRYTmtZeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dGIyNTBhR3g1WDNKaGRHVmZiV2xqY205ZmRYTmtZeUJsZUdsemRITUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QXlDaUFnSUNBcUNpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG94TURjS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBYM1I0TG5obVpYSmZZWE56WlhRdWFXUWdQVDBnYzJWc1ppNTFjMlJqWDJGemMyVjBYMmxrTG5aaGJIVmxMQ0FpVUdGNWJXVnVkQ0J0ZFhOMElIVnpaU0IwYUdVZ1kyOXVabWxuZFhKbFpDQlZVMFJESUdGemMyVjBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luVnpaR05mWVhOelpYUmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRYTmtZMTloYzNObGRGOXBaQ0JsZUdsemRITUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pFd05Bb2dJQ0FnTHk4Z2NHRjViV1Z1ZEY5MGVDQTlJR2QwZUc0dVFYTnpaWFJVY21GdWMyWmxjbFJ5WVc1ellXTjBhVzl1S0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdWNIazZNVEEzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRGOTBlQzU0Wm1WeVgyRnpjMlYwTG1sa0lEMDlJSE5sYkdZdWRYTmtZMTloYzNObGRGOXBaQzUyWVd4MVpTd2dJbEJoZVcxbGJuUWdiWFZ6ZENCMWMyVWdkR2hsSUdOdmJtWnBaM1Z5WldRZ1ZWTkVReUJoYzNObGRDSUtJQ0FnSUdkMGVHNXpJRmhtWlhKQmMzTmxkQW9nSUNBZ2FYUnZZZ29nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCdGRYTjBJSFZ6WlNCMGFHVWdZMjl1Wm1sbmRYSmxaQ0JWVTBSRElHRnpjMlYwQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUb3hNRFFLSUNBZ0lDOHZJSEJoZVcxbGJuUmZkSGdnUFNCbmRIaHVMa0Z6YzJWMFZISmhibk5tWlhKVWNtRnVjMkZqZEdsdmJpZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pFd09Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblJmZEhndVlYTnpaWFJmWVcxdmRXNTBJRDQ5SUhKbGNYVnBjbVZrWDNCaGVXMWxiblFzSUNKUVlYbHRaVzUwSUdGdGIzVnVkQ0JwY3lCaVpXeHZkeUIwYUdVZ2NtVnhkV2x5WldRZ2MzVmljMk55YVhCMGFXOXVJSEJ5YVdObElnb2dJQ0FnWjNSNGJuTWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EzQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklGQmhlVzFsYm5RZ1lXMXZkVzUwSUdseklHSmxiRzkzSUhSb1pTQnlaWEYxYVhKbFpDQnpkV0p6WTNKcGNIUnBiMjRnY0hKcFkyVUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pFd05Bb2dJQ0FnTHk4Z2NHRjViV1Z1ZEY5MGVDQTlJR2QwZUc0dVFYTnpaWFJVY21GdWMyWmxjbFJ5WVc1ellXTjBhVzl1S0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdWNIazZNVEE1Q2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRGOTBlQzVoYzNObGRGOXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0FvQ2lBZ0lDQm5kSGh1Y3lCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pFd09TMHhNVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MFgzUjRMbUZ6YzJWMFgzSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNJQ2dLSUNBZ0lDOHZJQ0FnSUNBaVVHRjViV1Z1ZENCdGRYTjBJR0psSUhObGJuUWdkRzhnZEdocGN5QmpiMjUwY21GamRDSUtJQ0FnSUM4dklDa0tJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUcxMWMzUWdZbVVnYzJWdWRDQjBieUIwYUdseklHTnZiblJ5WVdOMENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG94TURRS0lDQWdJQzh2SUhCaGVXMWxiblJmZEhnZ1BTQm5kSGh1TGtGemMyVjBWSEpoYm5ObVpYSlVjbUZ1YzJGamRHbHZiaWd3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qRXhNZ29nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzFsYm5SZmRIZ3VjMlZ1WkdWeUlEMDlJRlI0Ymk1elpXNWtaWElzSUNKUVlYbHRaVzUwSUhObGJtUmxjaUJ0ZFhOMElHMWhkR05vSUhSb1pTQnpkV0p6WTNKcFltbHVaeUIzWVd4c1pYUWlDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVR0Y1YldWdWRDQnpaVzVrWlhJZ2JYVnpkQ0J0WVhSamFDQjBhR1VnYzNWaWMyTnlhV0pwYm1jZ2QyRnNiR1YwQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUb3hNVFFLSUNBZ0lDOHZJR04xY25KbGJuUmZjbTkxYm1RZ1BTQkhiRzlpWVd3dWNtOTFibVFLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ1luVnllU0F4TUFvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdWNIazZNVEUyQ2lBZ0lDQXZMeUJsZUdsemRITWdQU0J6Wld4bUxuTjFZbk5qY21sd2RHbHZibk11YldGNVltVW9ZMkZzYkdWeUtWc3hYUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlRGN6TnpVMk1qVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRveE1UZ0tJQ0FnSUM4dklHbG1JR1Y0YVhOMGN6b0tJQ0FnSUdKNklITjFZbk5qY21saVpWOWxiSE5sWDJKdlpIbEFNVEFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qRXhPUW9nSUNBZ0x5OGdZM1Z5Y21WdWRGOWxlSEJwY25sZmNtOTFibVFnUFNCelpXeG1Mbk4xWW5OamNtbHdkR2x2Ym5OYlkyRnNiR1Z5WFM1bGVIQnBjbmxmY205MWJtUXVibUYwYVhabENpQWdJQ0JrYVdjZ01URUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVEVLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qRXlNQW9nSUNBZ0x5OGdhV1lnWTNWeWNtVnVkRjlsZUhCcGNubGZjbTkxYm1RZ1BpQmpkWEp5Wlc1MFgzSnZkVzVrT2dvZ0lDQWdaR2xuSURrS0lDQWdJRDRLSUNBZ0lHSjZJSE4xWW5OamNtbGlaVjlsYkhObFgySnZaSGxBT0FvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdWNIazZNVEl5Q2lBZ0lDQXZMeUJ6ZFdKelkzSnBZbVZrWDJGMFgzSnZkVzVrSUQwZ2MyVnNaaTV6ZFdKelkzSnBjSFJwYjI1elcyTmhiR3hsY2wwdWMzVmljMk55YVdKbFpGOWhkRjl5YjNWdVpBb2dJQ0FnWkdsbklERXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQmthV2NnT1FvZ0lDQWdZblZ5ZVNBNENncHpkV0p6WTNKcFltVmZZV1owWlhKZmFXWmZaV3h6WlVBNU9nb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmMzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVjSGs2TVRJMkNpQWdJQ0F2THlCcGMxOXVaWGRmYzNWaWMyTnlhV0psY2lBOUlFWmhiSE5sQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZjM1ZpYzJOeWFYQjBhVzl1WDIxaGJtRm5aWEl1Y0hrNk1USTNDaUFnSUNBdkx5QjBiM1JoYkY5dGIyNTBhSE5mY0dGcFpDQTlJSE5sYkdZdWMzVmljMk55YVhCMGFXOXVjMXRqWVd4c1pYSmRMblJ2ZEdGc1gyMXZiblJvYzE5d1lXbGtMbTVoZEdsMlpRb2dJQ0FnWkdsbklERXlDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnWW5WeWVTQTFDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRveE1qZ0tJQ0FnSUM4dklIUnZkR0ZzWDNWelpHTmZjR0ZwWkNBOUlITmxiR1l1YzNWaWMyTnlhWEIwYVc5dWMxdGpZV3hzWlhKZExuUnZkR0ZzWDNWelpHTmZjR0ZwWkM1dVlYUnBkbVVLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1luUnZhUW9nSUNBZ2MzZGhjQW9LYzNWaWMyTnlhV0psWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEU2Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUb3hNellLSUNBZ0lDOHZJR1Y0ZEdWdWMybHZibDl5YjNWdVpITmZhR2xuYUN3Z1pYaDBaVzV6YVc5dVgzSnZkVzVrYzE5c2IzY2dQU0J2Y0M1dGRXeDNLRzF2Ym5Sb2MxOXVZWFJwZG1Vc0lITmxiR1l1Y205MWJtUnpYM0JsY2w5dGIyNTBhQzUyWVd4MVpTNXVZWFJwZG1VcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpY205MWJtUnpYM0JsY2w5dGIyNTBhQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eWIzVnVaSE5mY0dWeVgyMXZiblJvSUdWNGFYTjBjd29nSUNBZ1luUnZhUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J0ZFd4M0NpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG94TXpjS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUhSbGJuTnBiMjVmY205MWJtUnpYMmhwWjJnZ1BUMGdWVWx1ZERZMEtEQXBMQ0FpVTNWaWMyTnlhWEIwYVc5dUlHeGxibWQwYUNCdmRtVnlabXh2ZHlJS0lDQWdJSE4zWVhBS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRkV0p6WTNKcGNIUnBiMjRnYkdWdVozUm9JRzkyWlhKbWJHOTNDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRveE16a0tJQ0FnSUM4dklHVjRjR2x5ZVY5b2FXZG9MQ0J1WlhkZlpYaHdhWEo1WDNKdmRXNWtJRDBnYjNBdVlXUmtkeWhsZUhCcGNubGZZbUZ6WlN3Z1pYaDBaVzV6YVc5dVgzSnZkVzVrYzE5c2IzY3BDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHRmtaSGNLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDNOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxuQjVPakUwTUFvZ0lDQWdMeThnWVhOelpYSjBJR1Y0Y0dseWVWOW9hV2RvSUQwOUlGVkpiblEyTkNnd0tTd2dJa1Y0Y0dseWVTQnliM1Z1WkNCdmRtVnlabXh2ZHlJS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZlSEJwY25rZ2NtOTFibVFnYjNabGNtWnNiM2NLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qRTBNZ29nSUNBZ0x5OGdiVzl1ZEdoelgyaHBaMmdzSUc1bGQxOTBiM1JoYkY5dGIyNTBhSE5mY0dGcFpDQTlJRzl3TG1Ga1pIY29kRzkwWVd4ZmJXOXVkR2h6WDNCaGFXUXNJRzF2Ym5Sb2MxOXVZWFJwZG1VcENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWVdSa2R3b2dJQ0FnWW5WeWVTQTVDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRveE5ETUtJQ0FnSUM4dklHRnpjMlZ5ZENCdGIyNTBhSE5mYUdsbmFDQTlQU0JWU1c1ME5qUW9NQ2tzSUNKTmIyNTBhQ0JqYjNWdWRHVnlJRzkyWlhKbWJHOTNJZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUUxdmJuUm9JR052ZFc1MFpYSWdiM1psY21ac2IzY0tJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pFME5Rb2dJQ0FnTHk4Z2NtVjJaVzUxWlY5b2FXZG9MQ0J1WlhkZmRHOTBZV3hmZFhOa1kxOXdZV2xrSUQwZ2IzQXVZV1JrZHloMGIzUmhiRjkxYzJSalgzQmhhV1FzSUhCaGVXMWxiblJmWVcxdmRXNTBLUW9nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHRmtaSGNLSUNBZ0lHSjFjbmtnTndvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdWNIazZNVFEyQ2lBZ0lDQXZMeUJoYzNObGNuUWdjbVYyWlc1MVpWOW9hV2RvSUQwOUlGVkpiblEyTkNnd0tTd2dJbE4xWW5OamNtbGlaWElnY0dGNWJXVnVkQ0JqYjNWdWRHVnlJRzkyWlhKbWJHOTNJZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUZOMVluTmpjbWxpWlhJZ2NHRjViV1Z1ZENCamIzVnVkR1Z5SUc5MlpYSm1iRzkzQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUb3hORGdLSUNBZ0lDOHZJR2xtSUdselgyNWxkMTl6ZFdKelkzSnBZbVZ5T2dvZ0lDQWdZbm9nYzNWaWMyTnlhV0psWDJGbWRHVnlYMmxtWDJWc2MyVkFNVE1LSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qRTBPUW9nSUNBZ0x5OGdjM1ZpYzJOeWFXSmxjbk5mYUdsbmFDd2dibVYzWDNSdmRHRnNYM04xWW5OamNtbGlaWEp6SUQwZ2IzQXVZV1JrZHloelpXeG1MblJ2ZEdGc1gzTjFZbk5qY21saVpYSnpMblpoYkhWbExtNWhkR2wyWlN3Z01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKMGIzUmhiRjl6ZFdKelkzSnBZbVZ5Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5emRXSnpZM0pwWW1WeWN5QmxlR2x6ZEhNS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhaR1IzQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUb3hOVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpkV0p6WTNKcFltVnljMTlvYVdkb0lEMDlJRlZKYm5RMk5DZ3dLU3dnSWxOMVluTmpjbWxpWlhJZ1kyOTFiblJsY2lCdmRtVnlabXh2ZHlJS0lDQWdJSE4zWVhBS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRkV0p6WTNKcFltVnlJR052ZFc1MFpYSWdiM1psY21ac2IzY0tJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pFMU1Rb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXpkV0p6WTNKcFltVnljeTUyWVd4MVpTQTlJR0Z5WXpRdVZVbHVkRFkwS0c1bGQxOTBiM1JoYkY5emRXSnpZM0pwWW1WeWN5a0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luUnZkR0ZzWDNOMVluTmpjbWxpWlhKeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbk4xWW5OamNtbGlaVjloWm5SbGNsOXBabDlsYkhObFFERXpPZ29nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZjM1ZpYzJOeWFYQjBhVzl1WDIxaGJtRm5aWEl1Y0hrNk1UVXpDaUFnSUNBdkx5QnlaWFpsYm5WbFgzUnZkR0ZzWDJocFoyZ3NJRzVsZDE5MGIzUmhiRjl5WlhabGJuVmxJRDBnYjNBdVlXUmtkeWh6Wld4bUxuUnZkR0ZzWDNKbGRtVnVkV1ZmYldsamNtOWZkWE5rWXk1MllXeDFaUzV1WVhScGRtVXNJSEJoZVcxbGJuUmZZVzF2ZFc1MEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYM0psZG1WdWRXVmZiV2xqY205ZmRYTmtZeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl5WlhabGJuVmxYMjFwWTNKdlgzVnpaR01nWlhocGMzUnpDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmhaR1IzQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUb3hOVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnlaWFpsYm5WbFgzUnZkR0ZzWDJocFoyZ2dQVDBnVlVsdWREWTBLREFwTENBaVVtVjJaVzUxWlNCamIzVnVkR1Z5SUc5MlpYSm1iRzkzSWdvZ0lDQWdjM2RoY0FvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGSmxkbVZ1ZFdVZ1kyOTFiblJsY2lCdmRtVnlabXh2ZHdvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdWNIazZNVFUxQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNKbGRtVnVkV1ZmYldsamNtOWZkWE5rWXk1MllXeDFaU0E5SUdGeVl6UXVWVWx1ZERZMEtHNWxkMTkwYjNSaGJGOXlaWFpsYm5WbEtRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRHOTBZV3hmY21WMlpXNTFaVjl0YVdOeWIxOTFjMlJqSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDNOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxuQjVPakUxT1FvZ0lDQWdMeThnWlhod2FYSjVYM0p2ZFc1a1BXRnlZelF1VlVsdWREWTBLRzVsZDE5bGVIQnBjbmxmY205MWJtUXBMQW9nSUNBZ1pHbG5JRGNLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qRTJNQW9nSUNBZ0x5OGdkRzkwWVd4ZmJXOXVkR2h6WDNCaGFXUTlZWEpqTkM1VlNXNTBOalFvYm1WM1gzUnZkR0ZzWDIxdmJuUm9jMTl3WVdsa0tTd0tJQ0FnSUdScFp5QTNDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRveE5qRUtJQ0FnSUM4dklIUnZkR0ZzWDNWelpHTmZjR0ZwWkQxaGNtTTBMbFZKYm5RMk5DaHVaWGRmZEc5MFlXeGZkWE5rWTE5d1lXbGtLU3dLSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUb3hOaklLSUNBZ0lDOHZJR3hoYzNSZmNHRjViV1Z1ZEY5eWIzVnVaRDFoY21NMExsVkpiblEyTkNoamRYSnlaVzUwWDNKdmRXNWtLU3dLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdWNIazZNVFUzTFRFMk5Bb2dJQ0FnTHk4Z2MyVnNaaTV6ZFdKelkzSnBjSFJwYjI1elcyTmhiR3hsY2wwZ1BTQlRkV0p6WTNKcGNIUnBiMjVTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnYzNWaWMyTnlhV0psWkY5aGRGOXliM1Z1WkQxemRXSnpZM0pwWW1Wa1gyRjBYM0p2ZFc1a0xBb2dJQ0FnTHk4Z0lDQWdJR1Y0Y0dseWVWOXliM1Z1WkQxaGNtTTBMbFZKYm5RMk5DaHVaWGRmWlhod2FYSjVYM0p2ZFc1a0tTd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOXRiMjUwYUhOZmNHRnBaRDFoY21NMExsVkpiblEyTkNodVpYZGZkRzkwWVd4ZmJXOXVkR2h6WDNCaGFXUXBMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNYM1Z6WkdOZmNHRnBaRDFoY21NMExsVkpiblEyTkNodVpYZGZkRzkwWVd4ZmRYTmtZMTl3WVdsa0tTd0tJQ0FnSUM4dklDQWdJQ0JzWVhOMFgzQmhlVzFsYm5SZmNtOTFibVE5WVhKak5DNVZTVzUwTmpRb1kzVnljbVZ1ZEY5eWIzVnVaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2MyOTFjbU5sWDNSNWNHVTlZWEpqTkM1VGRISnBibWNvSW5OMVluTmpjbWx3ZEdsdmJpSXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1pHbG5JREUxQ2lBZ0lDQmthV2NnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeVlUQXdNR00zTXpjMU5qSTNNell6TnpJMk9UY3dOelEyT1RabU5tVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREUwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmMzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVjSGs2TVRjeENpQWdJQ0F2THlCaGNtTTBMbFZKYm5RMk5DaHdZWGx0Wlc1MFgyRnRiM1Z1ZENrc0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG94TmpZdE1UY3lDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9DaUFnSUNBdkx5QWdJQ0FnSWxOMVluTmpjbWx3ZEdsdmJsSmxZMjl5WkdWa0lpd0tJQ0FnSUM4dklDQWdJQ0JqWVd4c1pYSXNDaUFnSUNBdkx5QWdJQ0FnYlc5dWRHaHpMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtHNWxkMTlsZUhCcGNubGZjbTkxYm1RcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hCaGVXMWxiblJmWVcxdmRXNTBLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHUnBaeUF4TkFvZ0lDQWdaR2xuSURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFl6QXdNREppTVRjZ0x5OGdiV1YwYUc5a0lDSlRkV0p6WTNKcGNIUnBiMjVTWldOdmNtUmxaQ2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG81T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHpkV0p6WTNKcFltVmZaV3h6WlY5aWIyUjVRRGc2Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUb3hNalVLSUNBZ0lDOHZJSE4xWW5OamNtbGlaV1JmWVhSZmNtOTFibVFnUFNCaGNtTTBMbFZKYm5RMk5DaGpkWEp5Wlc1MFgzSnZkVzVrS1FvZ0lDQWdaR2xuSURnS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZblZ5ZVNBeE1nb2dJQ0FnWW5WeWVTQTRDaUFnSUNCaUlITjFZbk5qY21saVpWOWhablJsY2w5cFpsOWxiSE5sUURrS0NuTjFZbk5qY21saVpWOWxiSE5sWDJKdlpIbEFNVEE2Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUb3hNekVLSUNBZ0lDOHZJSE4xWW5OamNtbGlaV1JmWVhSZmNtOTFibVFnUFNCaGNtTTBMbFZKYm5RMk5DaGpkWEp5Wlc1MFgzSnZkVzVrS1FvZ0lDQWdaR2xuSURnS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZblZ5ZVNBeE1nb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmMzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVjSGs2TVRNeUNpQWdJQ0F2THlCcGMxOXVaWGRmYzNWaWMyTnlhV0psY2lBOUlGUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCemQyRndDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRveE16TUtJQ0FnSUM4dklIUnZkR0ZzWDIxdmJuUm9jMTl3WVdsa0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5WeWVTQTFDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRveE16UUtJQ0FnSUM4dklIUnZkR0ZzWDNWelpHTmZjR0ZwWkNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKMWNua2dNVEFLSUNBZ0lHSWdjM1ZpYzJOeWFXSmxYMkZtZEdWeVgybG1YMlZzYzJWQU1URUtDbk4xWW5OamNtbGlaVjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ6ZFdKelkzSnBZbVZmWW05dmJGOXRaWEpuWlVBMUNnb0tMeThnYzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdVUzVmljMk55YVhCMGFXOXVUV0Z1WVdkbGNpNXBjMTloWTNScGRtVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYzE5aFkzUnBkbVU2Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUb3hOelFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsTENCaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCallXeHNjM1ZpSUhOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxsTjFZbk5qY21sd2RHbHZiazFoYm1GblpYSXVhWE5mWVdOMGFYWmxDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVVM1ZpYzJOeWFYQjBhVzl1VFdGdVlXZGxjaTVuWlhSZmMzVmljMk55YVhCMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzTjFZbk5qY21sd2RHbHZiam9LSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qRTRNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VzSUdGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pFNE13b2dJQ0FnTHk4Z1pYaHBjM1J6SUQwZ2MyVnNaaTV6ZFdKelkzSnBjSFJwYjI1ekxtMWhlV0psS0hkaGJHeGxkQ2xiTVYwS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnM016YzFOakkxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZjM1ZpYzJOeWFYQjBhVzl1WDIxaGJtRm5aWEl1Y0hrNk1UZzBDaUFnSUNBdkx5QmhjM05sY25RZ1pYaHBjM1J6TENBaVRtOGdjM1ZpYzJOeWFYQjBhVzl1SUhKbFkyOXlaQ0JtYjNWdVpDQm1iM0lnZEdocGN5QjNZV3hzWlhRaUNpQWdJQ0JoYzNObGNuUWdMeThnVG04Z2MzVmljMk55YVhCMGFXOXVJSEpsWTI5eVpDQm1iM1Z1WkNCbWIzSWdkR2hwY3lCM1lXeHNaWFFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qRTROUW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1YzNWaWMyTnlhWEIwYVc5dWMxdDNZV3hzWlhSZENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pFNE1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXNJR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdVUzVmljMk55YVhCMGFXOXVUV0Z1WVdkbGNpNW5aWFJmWlhod2FYSjVYM0p2ZFc1a1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDJWNGNHbHllVjl5YjNWdVpEb0tJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pFNE53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXNJR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDNOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxuQjVPakU0T1FvZ0lDQWdMeThnWlhocGMzUnpJRDBnYzJWc1ppNXpkV0p6WTNKcGNIUnBiMjV6TG0xaGVXSmxLSGRoYkd4bGRDbGJNVjBLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGczTXpjMU5qSTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmMzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVjSGs2TVRrd0NpQWdJQ0F2THlCaGMzTmxjblFnWlhocGMzUnpMQ0FpVG04Z2MzVmljMk55YVhCMGFXOXVJSEpsWTI5eVpDQm1iM1Z1WkNCbWIzSWdkR2hwY3lCM1lXeHNaWFFpQ2lBZ0lDQmhjM05sY25RZ0x5OGdUbThnYzNWaWMyTnlhWEIwYVc5dUlISmxZMjl5WkNCbWIzVnVaQ0JtYjNJZ2RHaHBjeUIzWVd4c1pYUUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pFNU1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVjM1ZpYzJOeWFYQjBhVzl1YzF0M1lXeHNaWFJkTG1WNGNHbHllVjl5YjNWdVpBb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHSmhZMnRsYm1RdlkyOXVkSEpoWTNSekwzTjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbkI1T2pFNE53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXNJR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdVUzVmljMk55YVhCMGFXOXVUV0Z1WVdkbGNpNW5aWFJmWTI5dVptbG5XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyTnZibVpwWnpvS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDNOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxuQjVPakU1TndvZ0lDQWdMeThnYzJWc1ppNXRiMjUwYUd4NVgzSmhkR1ZmYldsamNtOWZkWE5rWXk1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnRiMjUwYUd4NVgzSmhkR1ZmYldsamNtOWZkWE5rWXlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRiMjUwYUd4NVgzSmhkR1ZmYldsamNtOWZkWE5rWXlCbGVHbHpkSE1LSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qRTVPQW9nSUNBZ0x5OGdjMlZzWmk1eWIzVnVaSE5mY0dWeVgyMXZiblJvTG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luSnZkVzVrYzE5d1pYSmZiVzl1ZEdnaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjbTkxYm1SelgzQmxjbDl0YjI1MGFDQmxlR2x6ZEhNS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDNOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxuQjVPakU1T1FvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5emRXSnpZM0pwWW1WeWN5NTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0owYjNSaGJGOXpkV0p6WTNKcFltVnljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl6ZFdKelkzSnBZbVZ5Y3lCbGVHbHpkSE1LSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qSXdNQW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl5WlhabGJuVmxYMjFwWTNKdlgzVnpaR011ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRHOTBZV3hmY21WMlpXNTFaVjl0YVdOeWIxOTFjMlJqSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDNKbGRtVnVkV1ZmYldsamNtOWZkWE5rWXlCbGVHbHpkSE1LSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qSXdNUW9nSUNBZ0x5OGdjMlZzWmk1MWMyUmpYMkZ6YzJWMFgybGtMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5WelpHTmZZWE56WlhSZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZFhOa1kxOWhjM05sZEY5cFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDNOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxuQjVPakU1TlMweU1ETUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFIxY0d4bEtBb2dJQ0FnTHk4Z0lDQWdJQ2dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdjMlZzWmk1dGIyNTBhR3g1WDNKaGRHVmZiV2xqY205ZmRYTmtZeTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ2MyVnNaaTV5YjNWdVpITmZjR1Z5WDIxdmJuUm9MblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCelpXeG1MblJ2ZEdGc1gzTjFZbk5qY21saVpYSnpMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCelpXeG1MblJ2ZEdGc1gzSmxkbVZ1ZFdWZmJXbGpjbTlmZFhOa1l5NTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnYzJWc1ppNTFjMlJqWDJGemMyVjBYMmxrTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUNrS0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG94T1RNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbExDQmhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkS1FvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE4xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TGxOMVluTmpjbWx3ZEdsdmJrMWhibUZuWlhJdWNtVnNaV0Z6WlY5bWIzSmZjM1ZpYzJOeWFXSmxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGJHVmhjMlZmWm05eVgzTjFZbk5qY21saVpYSTZDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRveU1EVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdWNIazZNakEzQ2lBZ0lDQXZMeUJoYzNObGNuUWdSMnh2WW1Gc0xtTmhiR3hsY2w5aGNIQnNhV05oZEdsdmJsOXBaQ0E5UFNCelpXeG1MbVZ6WTNKdmQxOWhjSEJmYVdRdWRtRnNkV1VzSUNnS0lDQWdJR2RzYjJKaGJDQkRZV3hzWlhKQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0ltVnpZM0p2ZDE5aGNIQmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpYTmpjbTkzWDJGd2NGOXBaQ0JsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG95TURjdE1qQTVDaUFnSUNBdkx5QmhjM05sY25RZ1IyeHZZbUZzTG1OaGJHeGxjbDloY0hCc2FXTmhkR2x2Ymw5cFpDQTlQU0J6Wld4bUxtVnpZM0p2ZDE5aGNIQmZhV1F1ZG1Gc2RXVXNJQ2dLSUNBZ0lDOHZJQ0FnSUNBaWNtVnNaV0Z6WlY5bWIzSmZjM1ZpYzJOeWFXSmxjaUJqWVc0Z2IyNXNlU0JpWlNCallXeHNaV1FnWW5rZ2RHaGxJRVZ6WTNKdmR5QmpiMjUwY21GamRDSUtJQ0FnSUM4dklDa0tJQ0FnSUdGemMyVnlkQ0F2THlCeVpXeGxZWE5sWDJadmNsOXpkV0p6WTNKcFltVnlJR05oYmlCdmJteDVJR0psSUdOaGJHeGxaQ0JpZVNCMGFHVWdSWE5qY205M0lHTnZiblJ5WVdOMENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG95TVRFS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtbHpYMkZqZEdsMlpTaGlkWGxsY2lrdWJtRjBhWFpsTENBaVUzVmljMk55YVhCMGFXOXVJR2x6SUc1dmRDQmhZM1JwZG1VZ2IzSWdhR0Z6SUdWNGNHbHlaV1FpQ2lBZ0lDQmtkWEFLSUNBZ0lHTmhiR3h6ZFdJZ2MzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVVM1ZpYzJOeWFYQjBhVzl1VFdGdVlXZGxjaTVwYzE5aFkzUnBkbVVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRkV0p6WTNKcGNIUnBiMjRnYVhNZ2JtOTBJR0ZqZEdsMlpTQnZjaUJvWVhNZ1pYaHdhWEpsWkFvZ0lDQWdMeThnWW1GamEyVnVaQzlqYjI1MGNtRmpkSE12YzNWaWMyTnlhWEIwYVc5dVgyMWhibUZuWlhJdWNIazZNakV5Q2lBZ0lDQXZMeUJsZUdsemRITWdQU0J6Wld4bUxuTjFZbk5qY21sd2RHbHZibk11YldGNVltVW9ZblY1WlhJcFd6RmRDaUFnSUNCaWVYUmxZeUEySUM4dklEQjROek0zTlRZeU5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUdKaFkydGxibVF2WTI5dWRISmhZM1J6TDNOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxuQjVPakl4TXdvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN5d2dJazV2SUhOMVluTmpjbWx3ZEdsdmJpQnlaV052Y21RZ1ptOTFibVFnWm05eUlIUm9hWE1nZDJGc2JHVjBJZ29nSUNBZ1lYTnpaWEowSUM4dklFNXZJSE4xWW5OamNtbHdkR2x2YmlCeVpXTnZjbVFnWm05MWJtUWdabTl5SUhSb2FYTWdkMkZzYkdWMENpQWdJQ0F2THlCaVlXTnJaVzVrTDJOdmJuUnlZV04wY3k5emRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNXdlVG95TVRRS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTjFZbk5qY21sd2RHbHZibk5iWW5WNVpYSmRMbk52ZFhKalpWOTBlWEJsSUQwOUlHRnlZelF1VTNSeWFXNW5LQ0p6ZFdKelkzSnBjSFJwYjI0aUtTd2dJa2x1ZG1Gc2FXUWdjM1ZpYzJOeWFYQjBhVzl1SUhOdmRYSmpaU0IwZVhCbElnb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBjeUEwTWlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J3ZFhOb2FXNTBJRFF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3WXpjek56VTJNamN6TmpNM01qWTVOekEzTkRZNU5tWTJaUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuWmhiR2xrSUhOMVluTmpjbWx3ZEdsdmJpQnpiM1Z5WTJVZ2RIbHdaUW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZjM1ZpYzJOeWFYQjBhVzl1WDIxaGJtRm5aWEl1Y0hrNk1qQTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFPREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITjFZbk5qY21sd2RHbHZibDl0WVc1aFoyVnlMbE4xWW5OamNtbHdkR2x2YmsxaGJtRm5aWEl1ZDJsMGFHUnlZWGRmYzNWaWMyTnlhWEIwYVc5dVgzSmxkbVZ1ZFdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDNhWFJvWkhKaGQxOXpkV0p6WTNKcGNIUnBiMjVmY21WMlpXNTFaVG9LSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qSXlNQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNXZkMjVsY2k1MllXeDFaUzV1WVhScGRtVXNJQ0pQYm14NUlIUm9aU0JqYjI1MGNtRmpkQ0J2ZDI1bGNpQmpZVzRnZDJsMGFHUnlZWGNnYzNWaWMyTnlhWEIwYVc5dUlISmxkbVZ1ZFdVaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWliM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnZEdobElHTnZiblJ5WVdOMElHOTNibVZ5SUdOaGJpQjNhWFJvWkhKaGR5QnpkV0p6WTNKcGNIUnBiMjRnY21WMlpXNTFaUW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZjM1ZpYzJOeWFYQjBhVzl1WDIxaGJtRm5aWEl1Y0hrNk1qSXlDaUFnSUNBdkx5QnlaWFpsYm5WbElEMGdjMlZzWmk1MGIzUmhiRjl5WlhabGJuVmxYMjFwWTNKdlgzVnpaR011ZG1Gc2RXVXVibUYwYVhabENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZjbVYyWlc1MVpWOXRhV055YjE5MWMyUmpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYM0psZG1WdWRXVmZiV2xqY205ZmRYTmtZeUJsZUdsemRITUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmMzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVjSGs2TWpJekNpQWdJQ0F2THlCcFppQnlaWFpsYm5WbElEMDlJREE2Q2lBZ0lDQmllaUIzYVhSb1pISmhkMTl6ZFdKelkzSnBjSFJwYjI1ZmNtVjJaVzUxWlY5aFpuUmxjbDlwYm14cGJtVmtYM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TGxOMVluTmpjbWx3ZEdsdmJrMWhibUZuWlhJdWQybDBhR1J5WVhkZmMzVmljMk55YVhCMGFXOXVYM0psZG1WdWRXVkFOUW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZjM1ZpYzJOeWFYQjBhVzl1WDIxaGJtRm5aWEl1Y0hrNk1qSTJMVEl6TVFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTljMlZzWmk1MWMyUmpYMkZ6YzJWMFgybGtMblpoYkhWbExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxelpXeG1MblJ5WldGemRYSjVYMkZrWkhKbGMzTXVkbUZzZFdVdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDF5WlhabGJuVmxMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMVZTVzUwTmpRb01UQXdNQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRveU1qY0tJQ0FnSUM4dklIaG1aWEpmWVhOelpYUTljMlZzWmk1MWMyUmpYMkZ6YzJWMFgybGtMblpoYkhWbExtNWhkR2wyWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0oxYzJSalgyRnpjMlYwWDJsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblZ6WkdOZllYTnpaWFJmYVdRZ1pYaHBjM1J6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUb3lNamdLSUNBZ0lDOHZJR0Z6YzJWMFgzSmxZMlZwZG1WeVBYTmxiR1l1ZEhKbFlYTjFjbmxmWVdSa2NtVnpjeTUyWVd4MVpTNXVZWFJwZG1Vc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpZEhKbFlYTjFjbmxmWVdSa2NtVnpjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGNtVmhjM1Z5ZVY5aFpHUnlaWE56SUdWNGFYTjBjd29nSUNBZ1pHbG5JRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qSXlOZ29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUb3lNekFLSUNBZ0lDOHZJR1psWlQxVlNXNTBOalFvTVRBd01Da3NDaUFnSUNCd2RYTm9hVzUwSURFd01EQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRveU1qWXRNak14Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMXpaV3htTG5WelpHTmZZWE56WlhSZmFXUXVkbUZzZFdVdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFhObGJHWXVkSEpsWVhOMWNubGZZV1JrY21WemN5NTJZV3gxWlM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQWEpsZG1WdWRXVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNneE1EQXdLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRveU16TUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZjbVYyWlc1MVpWOXRhV055YjE5MWMyUmpMblpoYkhWbElEMGdZWEpqTkM1VlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYM0psZG1WdWRXVmZiV2xqY205ZmRYTmtZeUlLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LZDJsMGFHUnlZWGRmYzNWaWMyTnlhWEIwYVc5dVgzSmxkbVZ1ZFdWZllXWjBaWEpmYVc1c2FXNWxaRjl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1VGRXSnpZM0pwY0hScGIyNU5ZVzVoWjJWeUxuZHBkR2hrY21GM1gzTjFZbk5qY21sd2RHbHZibDl5WlhabGJuVmxRRFU2Q2lBZ0lDQXZMeUJpWVdOclpXNWtMMk52Ym5SeVlXTjBjeTl6ZFdKelkzSnBjSFJwYjI1ZmJXRnVZV2RsY2k1d2VUb3lNVGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE4xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TGxOMVluTmpjbWx3ZEdsdmJrMWhibUZuWlhJdWFYTmZZV04wYVhabEtIZGhiR3hsZERvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwemRXSnpZM0pwY0hScGIyNWZiV0Z1WVdkbGNpNVRkV0p6WTNKcGNIUnBiMjVOWVc1aFoyVnlMbWx6WDJGamRHbDJaVG9LSUNBZ0lDOHZJR0poWTJ0bGJtUXZZMjl1ZEhKaFkzUnpMM04xWW5OamNtbHdkR2x2Ymw5dFlXNWhaMlZ5TG5CNU9qRTNOQzB4TnpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbExDQmhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkS1FvZ0lDQWdMeThnWkdWbUlHbHpYMkZqZEdsMlpTaHpaV3htTENCM1lXeHNaWFE2SUdGeVl6UXVRV1JrY21WemN5a2dMVDRnWVhKak5DNUNiMjlzT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QmlZV05yWlc1a0wyTnZiblJ5WVdOMGN5OXpkV0p6WTNKcGNIUnBiMjVmYldGdVlXZGxjaTV3ZVRveE56WUtJQ0FnSUM4dklHVjRhWE4wY3lBOUlITmxiR1l1YzNWaWMyTnlhWEIwYVc5dWN5NXRZWGxpWlNoM1lXeHNaWFFwV3pGZENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE56TTNOVFl5TldZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZjM1ZpYzJOeWFYQjBhVzl1WDIxaGJtRm5aWEl1Y0hrNk1UYzNDaUFnSUNBdkx5QnBaaUJ1YjNRZ1pYaHBjM1J6T2dvZ0lDQWdZbTU2SUhOMVluTmpjbWx3ZEdsdmJsOXRZVzVoWjJWeUxsTjFZbk5qY21sd2RHbHZiazFoYm1GblpYSXVhWE5mWVdOMGFYWmxYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z1ltRmphMlZ1WkM5amIyNTBjbUZqZEhNdmMzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVjSGs2TVRjNENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0VaaGJITmxLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lITjNZWEFLSUNBZ0lISmxkSE4xWWdvS2MzVmljMk55YVhCMGFXOXVYMjFoYm1GblpYSXVVM1ZpYzJOeWFYQjBhVzl1VFdGdVlXZGxjaTVwYzE5aFkzUnBkbVZmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdZbUZqYTJWdVpDOWpiMjUwY21GamRITXZjM1ZpYzJOeWFYQjBhVzl1WDIxaGJtRm5aWEl1Y0hrNk1UYzVDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVDYjI5c0tITmxiR1l1YzNWaWMyTnlhWEIwYVc5dWMxdDNZV3hzWlhSZExtVjRjR2x5ZVY5eWIzVnVaQzV1WVhScGRtVWdQaUJIYkc5aVlXd3VjbTkxYm1RcENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdQZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBR0FBRUlJTUNFUFlDVTY5d0RKZ3NGYjNkdVpYSUlBQUFBQUFBQUFBQU5kWE5rWTE5aGMzTmxkRjlwWkJoMGIzUmhiRjl5WlhabGJuVmxYMjFwWTNKdlgzVnpaR01YYlc5dWRHaHNlVjl5WVhSbFgyMXBZM0p2WDNWelpHTVFjbTkxYm1SelgzQmxjbDl0YjI1MGFBUnpkV0pmRVhSdmRHRnNYM04xWW5OamNtbGlaWEp6QkJVZmZIVVFkSEpsWVhOMWNubGZZV1JrY21WemN3MWxjMk55YjNkZllYQndYMmxrTVJoQUFCOG9NUUJuSndreEFHY25DaUpuSndRcFp5Y0ZLV2NxS1djbkJ5bG5LeWxuTVJrVVJERVlRUUJWZ2dzRVRnZ2V1Z1FON3pmTkJNWi9jMjhFdHpUVjFnUWNPOFFYQkljRUpUb0V5MXR6dHdRbU1OdHpCSmhPYm9JRUREeGVCd1NjeFlxc05ob0FqZ3NBZEFDVkFNNEE4UUVVQWxrQ2F3S0ZBcUFDeXdNZEFJQUVmdjJrMGpZYUFJNEJBQUVBTmhvQlJ3SVZKQkpFTmhvQ1NVNENGU1FTUkRZYUEwbE9BaFVrRWtRWFNTRUVEMEVBUEVraEJRNUJBRFVqUkNneEFHY25DVEVBWnljRVN3UkpUZ0puSndWTEJFbE9BMmNxU3dSSlRnUm5NUUJNVUV4UVRGQ0FCSkc1RHJSTVVMQWpReUpDLzhnMkdnRkpGU1FTUkRFQUlpaGxSQkpFU1JjbkNreG5nQVMzd0NYa1RGQ3dJME0yR2dGSEFoVWtFa1F4QUNJb1pVUVNSQmRKSVFRUFFRQWNTU0VGRGtFQUZTTkVKd1JMQWtsT0FtZUFCQ3VQNTlWTVVMQWpReUpDLytnMkdnRkpGU1FTUkRFQUlpaGxSQkpFU1JkRUp3VkxBV2VBQkRQaDB1OU1VTEFqUXpFQUlpaGxSQkpFc1NJcVpVUVhNZ29pc2hLeUZMSVJnUVN5RUlIb0I3SUJzeU5ESWtjQ2dBQkhCellhQVVjQ0ZTUVNSQmRKUVFFc1NZRU1Ea0VCSlNORU1RQkpSUTRpT0JDQkJCSkVJaWNFWlVRWFN3SUxJaXBsUkNJNEVSYW9SQ0k0RWtsRkJ3NUVJamdVTWdvU1JDSTRBREVBRWtReUJrVUtKd1pNVUVsRkRiMUZBVUVBeWtzTEpFbTZGMGxGQzBzSkRVRUFzRXNMSWlTNlJRdExDVVVJSWtzTVNZRVFKTG9YUlFXQkdDUzZGMHdpSndWbFJCZExBMGxQQWgxTUZFUkxDeDVGQ3hSRVN3VWVSUWtVUkV4TEJSNUZCeFJFUVFBUUlpY0haVVFYSXg1TUZFUVdKd2RNWnlJclpVUVhTd1JKVGdJZVRCUkVGaXRNWjBzSEZrc0hGa3NIRmtzTUZrc1BTd1JRVHdOUVR3SlFURkNBRUFBcUFBeHpkV0p6WTNKcGNIUnBiMjVRU3c1SnZFaE12MHdXU3c1TEJGQlBBbEJNVUlBRXdBQXJGMHhRc0NORFN3aEpGa1VNUlFoQy8xQkxDRWtXUlF3alRDSkZCU0pPQWtVS1F2OU9Ja0wrMkRZYUFVa1ZKUkpFaUFEc0p3aE1VTEFqUXpZYUFVa1ZKUkpFSndaTVVFbTlSUUZFdmtnbkNFeFFzQ05ETmhvQlNSVWxFa1FuQmt4UVNiMUZBVVFrU2JvbkNFeFFzQ05ESWljRVpVUWlKd1ZsUkNJbkIyVkVJaXRsUkNJcVpVUlBCRThFVUU4RFVFOENVRXhRSndoTVVMQWpRellhQVVrVkpSSkVOaG9DRlNRU1JESU5JaWNLWlVRU1JFbUlBR2tpVTBRbkJreFFTYjFGQVVSSmd3SXFBcm9YZ1FJSWdTcE11b0FPQUF4emRXSnpZM0pwY0hScGIyNFNSSUFGRlI5OGRZQ3dJME14QUNJb1pVUVNSQ0lyWlVRWFNVRUFJTEVpS21WRUZ5SW5DV1ZFU3dLeUVySVVzaEdCQkxJUWdlZ0hzZ0d6S3lsbkkwT0tBUUVuQm92L1VFbTlSUUZBQUFXQUFRQk1pWXNBSkVtNkZ6SUdEWUFCQUNKUEFsUk1pUT09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiU3Vic2NyaXB0aW9uTWFuYWdlckNyZWF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU3Vic2NyaXB0aW9uRXNjcm93QXBwU2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU3Vic2NyaXB0aW9uTW9udGhseVJhdGVVcGRhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU3Vic2NyaXB0aW9uUm91bmRzUGVyTW9udGhVcGRhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU3Vic2NyaXB0aW9uUmVjb3JkZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
