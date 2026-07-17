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

namespace Arc56.Generated.gulzerr.payPerSecond.TapToStream_b2aebc82
{


    public class TapToStreamProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TapToStreamProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetStreamInfoResult : AVMObjectType
            {
                public string Title { get; set; }

                public ulong Duration { get; set; }

                public ulong PricePerSecond { get; set; }

                public ulong TenSecondCost { get; set; }

                public ulong TotalEarnings { get; set; }

                public bool Active { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTitle.From(Title);
                    stringRef[ret.Count] = vTitle.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDuration.From(Duration);
                    ret.AddRange(vDuration.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPricePerSecond = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPricePerSecond.From(PricePerSecond);
                    ret.AddRange(vPricePerSecond.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTenSecondCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTenSecondCost.From(TenSecondCost);
                    ret.AddRange(vTenSecondCost.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalEarnings = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalEarnings.From(TotalEarnings);
                    ret.AddRange(vTotalEarnings.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vActive.From(Active);
                    ret.AddRange(vActive.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetStreamInfoResult Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetStreamInfoResult();
                    uint count = 0;
                    var indexTitle = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTitle.Decode(bytes.Skip(indexTitle + prefixOffset).ToArray());
                    var valueTitle = vTitle.ToValue();
                    if (valueTitle is string vTitleValue) { ret.Title = vTitleValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDuration.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDuration = vDuration.ToValue();
                    if (valueDuration is ulong vDurationValue) { ret.Duration = vDurationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPricePerSecond = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPricePerSecond.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePricePerSecond = vPricePerSecond.ToValue();
                    if (valuePricePerSecond is ulong vPricePerSecondValue) { ret.PricePerSecond = vPricePerSecondValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTenSecondCost = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTenSecondCost.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTenSecondCost = vTenSecondCost.ToValue();
                    if (valueTenSecondCost is ulong vTenSecondCostValue) { ret.TenSecondCost = vTenSecondCostValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalEarnings = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalEarnings.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalEarnings = vTotalEarnings.ToValue();
                    if (valueTotalEarnings is ulong vTotalEarningsValue) { ret.TotalEarnings = vTotalEarningsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActive = vActive.ToValue();
                    if (valueActive is bool vActiveValue) { ret.Active = vActiveValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetStreamInfoResult);
                }
                public bool Equals(GetStreamInfoResult? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetStreamInfoResult left, GetStreamInfoResult right)
                {
                    return EqualityComparer<GetStreamInfoResult>.Default.Equals(left, right);
                }
                public static bool operator !=(GetStreamInfoResult left, GetStreamInfoResult right)
                {
                    return !(left == right);
                }

            }

            public class GetUserStreamingInfoResult : AVMObjectType
            {
                public ulong HeldAmount { get; set; }

                public ulong LastPaymentTime { get; set; }

                public ulong TotalPaid { get; set; }

                public ulong WatchStartTime { get; set; }

                public bool CanProcessInterval { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHeldAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vHeldAmount.From(HeldAmount);
                    ret.AddRange(vHeldAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastPaymentTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastPaymentTime.From(LastPaymentTime);
                    ret.AddRange(vLastPaymentTime.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalPaid.From(TotalPaid);
                    ret.AddRange(vTotalPaid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWatchStartTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWatchStartTime.From(WatchStartTime);
                    ret.AddRange(vWatchStartTime.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCanProcessInterval = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vCanProcessInterval.From(CanProcessInterval);
                    ret.AddRange(vCanProcessInterval.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetUserStreamingInfoResult Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetUserStreamingInfoResult();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHeldAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vHeldAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHeldAmount = vHeldAmount.ToValue();
                    if (valueHeldAmount is ulong vHeldAmountValue) { ret.HeldAmount = vHeldAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastPaymentTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastPaymentTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastPaymentTime = vLastPaymentTime.ToValue();
                    if (valueLastPaymentTime is ulong vLastPaymentTimeValue) { ret.LastPaymentTime = vLastPaymentTimeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalPaid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalPaid = vTotalPaid.ToValue();
                    if (valueTotalPaid is ulong vTotalPaidValue) { ret.TotalPaid = vTotalPaidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWatchStartTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWatchStartTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWatchStartTime = vWatchStartTime.ToValue();
                    if (valueWatchStartTime is ulong vWatchStartTimeValue) { ret.WatchStartTime = vWatchStartTimeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCanProcessInterval = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vCanProcessInterval.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCanProcessInterval = vCanProcessInterval.ToValue();
                    if (valueCanProcessInterval is bool vCanProcessIntervalValue) { ret.CanProcessInterval = vCanProcessIntervalValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetUserStreamingInfoResult);
                }
                public bool Equals(GetUserStreamingInfoResult? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetUserStreamingInfoResult left, GetUserStreamingInfoResult right)
                {
                    return EqualityComparer<GetUserStreamingInfoResult>.Default.Equals(left, right);
                }
                public static bool operator !=(GetUserStreamingInfoResult left, GetUserStreamingInfoResult right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize a new stream with hardcoded payment recipient
        ///</summary>
        /// <param name="title"> </param>
        /// <param name="duration"> </param>
        /// <param name="pricePerSecond"> </param>
        public async Task InitializeStream(string title, ulong duration, ulong pricePerSecond, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 27, 240, 26 };
            var titleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); titleAbi.From(title);
            var durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); durationAbi.From(duration);
            var pricePerSecondAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricePerSecondAbi.From(pricePerSecond);

            var result = await base.CallApp(new List<object> { abiHandle, titleAbi, durationAbi, pricePerSecondAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InitializeStream_Transactions(string title, ulong duration, ulong pricePerSecond, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 27, 240, 26 };
            var titleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); titleAbi.From(title);
            var durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); durationAbi.From(duration);
            var pricePerSecondAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pricePerSecondAbi.From(pricePerSecond);

            return await base.MakeTransactionList(new List<object> { abiHandle, titleAbi, durationAbi, pricePerSecondAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Start streaming session - user deposits for 10-second interval
        ///</summary>
        /// <param name="payment"> </param>
        public async Task StartStreaming(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 100, 201, 121, 165 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StartStreaming_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 100, 201, 121, 165 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Process 10-second interval payment
        ///</summary>
        public async Task ProcessInterval(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 246, 97, 161 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ProcessInterval_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 246, 97, 161 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Continue streaming - deposit for next 10-second interval
        ///</summary>
        /// <param name="payment"> </param>
        public async Task ContinueStreaming(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 129, 35, 136, 213 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ContinueStreaming_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 129, 35, 136, 213 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Stop streaming and refund any remaining held amount
        ///</summary>
        public async Task StopStreaming(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 98, 73, 30 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StopStreaming_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 98, 73, 30 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update payment recipient (only owner can call)
        ///</summary>
        /// <param name="newRecipient"> </param>
        public async Task UpdatePaymentRecipient(Address newRecipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { newRecipient });
            byte newRecipientRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 235, 218, 244, 181 };
            var newRecipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newRecipientAbi.From(newRecipient);

            var result = await base.CallApp(new List<object> { abiHandle, newRecipientRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdatePaymentRecipient_Transactions(Address newRecipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { newRecipient });
            byte newRecipientRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 235, 218, 244, 181 };
            var newRecipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newRecipientAbi.From(newRecipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, newRecipientRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Emergency stop - only stream owner can call
        ///</summary>
        public async Task EmergencyStop(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 102, 26, 130 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> EmergencyStop_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 102, 26, 130 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get stream info
        ///</summary>
        public async Task<Structs.GetStreamInfoResult> GetStreamInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 87, 43, 138 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetStreamInfoResult.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetStreamInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 87, 43, 138 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user streaming session info
        ///</summary>
        public async Task<Structs.GetUserStreamingInfoResult> GetUserStreamingInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 185, 121, 75 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserStreamingInfoResult.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUserStreamingInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 185, 121, 75 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGFwVG9TdHJlYW0iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiZ2V0U3RyZWFtSW5mb1Jlc3VsdCI6W3sibmFtZSI6InRpdGxlIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImR1cmF0aW9uIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByaWNlUGVyU2Vjb25kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRlblNlY29uZENvc3QiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxFYXJuaW5ncyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhY3RpdmUiLCJ0eXBlIjoiYm9vbCJ9XSwiZ2V0VXNlclN0cmVhbWluZ0luZm9SZXN1bHQiOlt7Im5hbWUiOiJoZWxkQW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Imxhc3RQYXltZW50VGltZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbFBhaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoid2F0Y2hTdGFydFRpbWUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY2FuUHJvY2Vzc0ludGVydmFsIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdGlhbGl6ZVN0cmVhbSIsImRlc2MiOiJJbml0aWFsaXplIGEgbmV3IHN0cmVhbSB3aXRoIGhhcmRjb2RlZCBwYXltZW50IHJlY2lwaWVudCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aXRsZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZHVyYXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByaWNlUGVyU2Vjb25kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0YXJ0U3RyZWFtaW5nIiwiZGVzYyI6IlN0YXJ0IHN0cmVhbWluZyBzZXNzaW9uIC0gdXNlciBkZXBvc2l0cyBmb3IgMTAtc2Vjb25kIGludGVydmFsIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJvY2Vzc0ludGVydmFsIiwiZGVzYyI6IlByb2Nlc3MgMTAtc2Vjb25kIGludGVydmFsIHBheW1lbnQiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29udGludWVTdHJlYW1pbmciLCJkZXNjIjoiQ29udGludWUgc3RyZWFtaW5nIC0gZGVwb3NpdCBmb3IgbmV4dCAxMC1zZWNvbmQgaW50ZXJ2YWwiLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdG9wU3RyZWFtaW5nIiwiZGVzYyI6IlN0b3Agc3RyZWFtaW5nIGFuZCByZWZ1bmQgYW55IHJlbWFpbmluZyBoZWxkIGFtb3VudCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVQYXltZW50UmVjaXBpZW50IiwiZGVzYyI6IlVwZGF0ZSBwYXltZW50IHJlY2lwaWVudCAob25seSBvd25lciBjYW4gY2FsbCkiLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld1JlY2lwaWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlbWVyZ2VuY3lTdG9wIiwiZGVzYyI6IkVtZXJnZW5jeSBzdG9wIC0gb25seSBzdHJlYW0gb3duZXIgY2FuIGNhbGwiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U3RyZWFtSW5mbyIsImRlc2MiOiJHZXQgc3RyZWFtIGluZm8iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJnZXRTdHJlYW1JbmZvUmVzdWx0IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRVc2VyU3RyZWFtaW5nSW5mbyIsImRlc2MiOiJHZXQgdXNlciBzdHJlYW1pbmcgc2Vzc2lvbiBpbmZvIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJnZXRVc2VyU3RyZWFtaW5nSW5mb1Jlc3VsdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6NCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1NjksNzE1XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IHBheW1lbnQgZm9yIDEwLXNlY29uZCBpbnRlcnZhbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxOF0sImVycm9yTWVzc2FnZSI6IkludGVydmFsIG5vdCBjb21wbGV0ZSB5ZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTNdLCJlcnJvck1lc3NhZ2UiOiJNdXN0IHN0YXJ0IHN0cmVhbWluZyBmaXJzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxMV0sImVycm9yTWVzc2FnZSI6Ik5vIGhlbGQgYW1vdW50IHRvIHByb2Nlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTksMzA4LDM3NCwzODYsNDA0LDQxNiw0MzgsNDUwLDQ3Ml0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5M10sImVycm9yTWVzc2FnZSI6Ik9ubHkgb3duZXIgY2FuIGVtZXJnZW5jeSBzdG9wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzc4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBvd25lciBjYW4gdXBkYXRlIHJlY2lwaWVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2MSw3MDddLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgYmUgdG8gYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ3LDU5NSw2ODVdLCJlcnJvck1lc3NhZ2UiOiJTdHJlYW0gbm90IGFjdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwM10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MiwzMTEsMzc3LDM4OSw0MDcsNDE5LDQ0MSw0NTMsNDc1XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0Niw1NTEsNTk0LDYyNCw2NDEsNjg0LDY5Nyw3NzYsNzkxLDgwMiw4MDcsODExLDgxNSw4MjEsODI1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjAxLDYwOCw2NTQsNjkyLDczNSw4NDAsODYwLDg2Nyw4NzRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBMb2NhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyOSw0NjNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElERXdDaUFnSUNCaWVYUmxZMkpzYjJOcklDSjFjMlZ5U0dWc1pFRnRiM1Z1ZENJZ0luTjBjbVZoYlVGamRHbDJaU0lnSW5CeWFXTmxVR1Z5VTJWamIyNWtJaUFpZEc5MFlXeEZZWEp1YVc1bmN5SWdJblZ6WlhKWFlYUmphRk4wWVhKMFZHbHRaU0lnSW5WelpYSk1ZWE4wVUdGNWJXVnVkRlJwYldVaUlDSnpkSEpsWVcxUGQyNWxjaUlnSW5CaGVXMWxiblJTWldOcGNHbGxiblFpSUNKMWMyVnlWRzkwWVd4UVlXbGtJaUF3ZURFMU1XWTNZemMxSUNKemRISmxZVzFVYVhSc1pTSWdJbk4wY21WaGJVUjFjbUYwYVc5dUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWR0Z3Vkc5VGRISmxZVzBnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRRS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnM016RmlaakF4WVNBd2VEWTBZemszT1dFMUlEQjRNV0ZtTmpZeFlURWdNSGc0TVRJek9EaGtOU0F3ZURJNE5qSTBPVEZsSURCNFpXSmtZV1kwWWpVZ01IaGlPRFkyTVdFNE1pQXdlREV3TlRjeVlqaGhJREI0TURCaU9UYzVOR0lnTHk4Z2JXVjBhRzlrSUNKcGJtbDBhV0ZzYVhwbFUzUnlaV0Z0S0hOMGNtbHVaeXgxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5OMFlYSjBVM1J5WldGdGFXNW5LSEJoZVNsMmIybGtJaXdnYldWMGFHOWtJQ0p3Y205alpYTnpTVzUwWlhKMllXd29LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTnZiblJwYm5WbFUzUnlaV0Z0YVc1bktIQmhlU2wyYjJsa0lpd2diV1YwYUc5a0lDSnpkRzl3VTNSeVpXRnRhVzVuS0NsMmIybGtJaXdnYldWMGFHOWtJQ0oxY0dSaGRHVlFZWGx0Wlc1MFVtVmphWEJwWlc1MEtHRmpZMjkxYm5RcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWlcxbGNtZGxibU41VTNSdmNDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBVM1J5WldGdFNXNW1ieWdwS0hOMGNtbHVaeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzWW05dmJDa2lMQ0J0WlhSb2IyUWdJbWRsZEZWelpYSlRkSEpsWVcxcGJtZEpibVp2S0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExHSnZiMndwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlwYm1sMGFXRnNhWHBsVTNSeVpXRnRYM0p2ZFhSbFFETWdiV0ZwYmw5emRHRnlkRk4wY21WaGJXbHVaMTl5YjNWMFpVQTBJRzFoYVc1ZmNISnZZMlZ6YzBsdWRHVnlkbUZzWDNKdmRYUmxRRFVnYldGcGJsOWpiMjUwYVc1MVpWTjBjbVZoYldsdVoxOXliM1YwWlVBMklHMWhhVzVmYzNSdmNGTjBjbVZoYldsdVoxOXliM1YwWlVBM0lHMWhhVzVmZFhCa1lYUmxVR0Y1YldWdWRGSmxZMmx3YVdWdWRGOXliM1YwWlVBNElHMWhhVzVmWlcxbGNtZGxibU41VTNSdmNGOXliM1YwWlVBNUlHMWhhVzVmWjJWMFUzUnlaV0Z0U1c1bWIxOXliM1YwWlVBeE1DQnRZV2x1WDJkbGRGVnpaWEpUZEhKbFlXMXBibWRKYm1adlgzSnZkWFJsUURFeENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVVlYQlViMU4wY21WaGJTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBWWE5sY2xOMGNtVmhiV2x1WjBsdVptOWZjbTkxZEdWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua3dDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUlZjMlZ5VTNSeVpXRnRhVzVuU1c1bWJ3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdjMlYwWW1sMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlRkSEpsWVcxSmJtWnZYM0p2ZFhSbFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBVM1J5WldGdFNXNW1id29nSUNBZ1pHbG5JRFVLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdsMGIySUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQnpaWFJpYVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01qTUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ09TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlsYldWeVoyVnVZM2xUZEc5d1gzSnZkWFJsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJsYldWeVoyVnVZM2xUZEc5d0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNWd1pHRjBaVkJoZVcxbGJuUlNaV05wY0dsbGJuUmZjbTkxZEdWQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJVWVhCVWIxTjBjbVZoYlNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRmpZMjkxYm5SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnZFhCa1lYUmxVR0Y1YldWdWRGSmxZMmx3YVdWdWRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5emRHOXdVM1J5WldGdGFXNW5YM0p2ZFhSbFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCemRHOXdVM1J5WldGdGFXNW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnZiblJwYm5WbFUzUnlaV0Z0YVc1blgzSnZkWFJsUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWR0Z3Vkc5VGRISmxZVzBnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCamIyNTBhVzUxWlZOMGNtVmhiV2x1WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl3Y205alpYTnpTVzUwWlhKMllXeGZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM053b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnY0hKdlkyVnpjMGx1ZEdWeWRtRnNDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzTjBZWEowVTNSeVpXRnRhVzVuWDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVVlYQlViMU4wY21WaGJTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdjM1JoY25SVGRISmxZVzFwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYVc1cGRHbGhiR2w2WlZOMGNtVmhiVjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVkdGd1ZHOVRkSEpsWVcwZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak01Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdhVzVwZEdsaGJHbDZaVk4wY21WaGJRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVVlYQlViMU4wY21WaGJTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRnS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFVZWEJVYjFOMGNtVmhiUzVwYm1sMGFXRnNhWHBsVTNSeVpXRnRLSFJwZEd4bE9pQmllWFJsY3l3Z1pIVnlZWFJwYjI0NklIVnBiblEyTkN3Z2NISnBZMlZRWlhKVFpXTnZibVE2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LYVc1cGRHbGhiR2w2WlZOMGNtVmhiVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx3WlhKelpXTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPUzAwTUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nYVc1cGRHbGhiR2w2WlZOMGNtVmhiU2gwYVhSc1pUb2djM1J5YVc1bkxDQmtkWEpoZEdsdmJqb2dkV2x1ZERZMExDQndjbWxqWlZCbGNsTmxZMjl1WkRvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhOMGNtVmhiVTkzYm1WeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1RzS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5OMGNtVmhiVTkzYm1WeUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCMGFHbHpMbk4wY21WaGJVOTNibVZ5TG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2pzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJSEIxWW14cFl5QnpkSEpsWVcxVWFYUnNaU0E5SUVkc2IySmhiRk4wWVhSbFBITjBjbWx1Wno0b0tUc0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSnpkSEpsWVcxVWFYUnNaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx3WlhKelpXTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNZ29nSUNBZ0x5OGdkR2hwY3k1emRISmxZVzFVYVhSc1pTNTJZV3gxWlNBOUlIUnBkR3hsT3dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjM1J5WldGdFJIVnlZWFJwYjI0Z1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3SUM4dklHbHVJSE5sWTI5dVpITUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSnpkSEpsWVcxRWRYSmhkR2x2YmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTXdvZ0lDQWdMeThnZEdocGN5NXpkSEpsWVcxRWRYSmhkR2x2Ymk1MllXeDFaU0E5SUdSMWNtRjBhVzl1T3dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjSEpwWTJWUVpYSlRaV052Ym1RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3SUM4dklHbHVJRzFwWTNKdlFXeG5iM01LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkJ5YVdObFVHVnlVMlZqYjI1a0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCMGFHbHpMbkJ5YVdObFVHVnlVMlZqYjI1a0xuWmhiSFZsSUQwZ2NISnBZMlZRWlhKVFpXTnZibVE3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJSEIxWW14cFl5QnpkSEpsWVcxQlkzUnBkbVVnUFNCSGJHOWlZV3hUZEdGMFpUeGliMjlzWldGdVBpZ3BPd29nSUNBZ1lubDBaV05mTVNBdkx5QWljM1J5WldGdFFXTjBhWFpsSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUIwYUdsekxuTjBjbVZoYlVGamRHbDJaUzUyWVd4MVpTQTlJSFJ5ZFdVN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnY0hWaWJHbGpJSFJ2ZEdGc1JXRnlibWx1WjNNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYjNSaGJFVmhjbTVwYm1keklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMkNpQWdJQ0F2THlCMGFHbHpMblJ2ZEdGc1JXRnlibWx1WjNNdWRtRnNkV1VnUFNBd093b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUhCMVlteHBZeUJ3WVhsdFpXNTBVbVZqYVhCcFpXNTBJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tUc0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luQmhlVzFsYm5SU1pXTnBjR2xsYm5RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUhSb2FYTXVjR0Y1YldWdWRGSmxZMmx3YVdWdWRDNTJZV3gxWlNBOUlGUjRiaTV6Wlc1a1pYSTdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVVlYQlViMU4wY21WaGJTNXpkR0Z5ZEZOMGNtVmhiV2x1Wnlod1lYbHRaVzUwT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25OMFlYSjBVM1J5WldGdGFXNW5PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTNMVFU0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUhCMVlteHBZeUJ6ZEdGeWRGTjBjbVZoYldsdVp5aHdZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0cE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QndkV0pzYVdNZ2MzUnlaV0Z0UVdOMGFYWmxJRDBnUjJ4dlltRnNVM1JoZEdVOFltOXZiR1ZoYmo0b0tUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKemRISmxZVzFCWTNScGRtVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVNUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXpkSEpsWVcxQlkzUnBkbVV1ZG1Gc2RXVXNJQ0pUZEhKbFlXMGdibTkwSUdGamRHbDJaU0lwT3dvZ0lDQWdZWE56WlhKMElDOHZJRk4wY21WaGJTQnViM1FnWVdOMGFYWmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklIQjFZbXhwWXlCd2NtbGpaVkJsY2xObFkyOXVaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc2dMeThnYVc0Z2JXbGpjbTlCYkdkdmN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5CeWFXTmxVR1Z5VTJWamIyNWtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk1nb2dJQ0FnTHk4Z1kyOXVjM1FnZEdWdVUyVmpiMjVrUTI5emRDQTlJQ2gwYUdsekxuQnlhV05sVUdWeVUyVmpiMjVrTG5aaGJIVmxJQ29nTVRBcElHRnpJSFZwYm5RMk5Ec0tJQ0FnSUdsdWRHTmZNaUF2THlBeE1Bb2dJQ0FnS2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1YldWdWRDNXlaV05sYVhabGNpQTlQVDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNJQ0pRWVhsdFpXNTBJRzExYzNRZ1ltVWdkRzhnWVhCd0lpazdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUcxMWMzUWdZbVVnZEc4Z1lYQndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklHRnpjMlZ5ZENod1lYbHRaVzUwTG1GdGIzVnVkQ0ErUFNCMFpXNVRaV052Ym1SRGIzTjBMQ0FpU1c1emRXWm1hV05wWlc1MElIQmhlVzFsYm5RZ1ptOXlJREV3TFhObFkyOXVaQ0JwYm5SbGNuWmhiQ0lwT3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVjM1ZtWm1samFXVnVkQ0J3WVhsdFpXNTBJR1p2Y2lBeE1DMXpaV052Ym1RZ2FXNTBaWEoyWVd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnZEdocGN5NTFjMlZ5U0dWc1pFRnRiM1Z1ZENoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlIUmxibE5sWTI5dVpFTnZjM1E3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklIQjFZbXhwWXlCMWMyVnlTR1ZzWkVGdGIzVnVkQ0E5SUV4dlkyRnNVM1JoZEdVOGRXbHVkRFkwUGlncE95QXZMeUJCYlc5MWJuUWdhR1ZzWkNCbWIzSWdZM1Z5Y21WdWRDQXhNQzF6WldOdmJtUWdhVzUwWlhKMllXd0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luVnpaWEpJWld4a1FXMXZkVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalk1Q2lBZ0lDQXZMeUIwYUdsekxuVnpaWEpJWld4a1FXMXZkVzUwS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwZ2RHVnVVMlZqYjI1a1EyOXpkRHNLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjd0NpQWdJQ0F2THlCMGFHbHpMblZ6WlhKWFlYUmphRk4wWVhKMFZHbHRaU2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUVkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQTdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhCMVlteHBZeUIxYzJWeVYyRjBZMmhUZEdGeWRGUnBiV1VnUFNCTWIyTmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc2dMeThnVjJobGJpQjFjMlZ5SUhOMFlYSjBaV1FnZDJGMFkyaHBibWNLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJblZ6WlhKWFlYUmphRk4wWVhKMFZHbHRaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx3WlhKelpXTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNQW9nSUNBZ0x5OGdkR2hwY3k1MWMyVnlWMkYwWTJoVGRHRnlkRlJwYldVb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQkhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3T3dvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN4Q2lBZ0lDQXZMeUIwYUdsekxuVnpaWEpNWVhOMFVHRjViV1Z1ZEZScGJXVW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0JIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd093b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkWE5sY2t4aGMzUlFZWGx0Wlc1MFZHbHRaU0E5SUV4dlkyRnNVM1JoZEdVOGRXbHVkRFkwUGlncE95QXZMeUJNWVhOMElIQmhlVzFsYm5RZ2RHbHRaWE4wWVcxd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMWMyVnlUR0Z6ZEZCaGVXMWxiblJVYVcxbElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjeENpQWdJQ0F2THlCMGFHbHpMblZ6WlhKTVlYTjBVR0Y1YldWdWRGUnBiV1VvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdPd29nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFVZWEJVYjFOMGNtVmhiUzV3Y205alpYTnpTVzUwWlhKMllXd29LU0F0UGlCMmIybGtPZ3B3Y205alpYTnpTVzUwWlhKMllXdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklIQjFZbXhwWXlCemRISmxZVzFCWTNScGRtVWdQU0JIYkc5aVlXeFRkR0YwWlR4aWIyOXNaV0Z1UGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5OMGNtVmhiVUZqZEdsMlpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnprS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuTjBjbVZoYlVGamRHbDJaUzUyWVd4MVpTd2dJbE4wY21WaGJTQnViM1FnWVdOMGFYWmxJaWs3Q2lBZ0lDQmhjM05sY25RZ0x5OGdVM1J5WldGdElHNXZkQ0JoWTNScGRtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z1kyOXVjM1FnYUdWc1pFRnRiM1Z1ZENBOUlIUm9hWE11ZFhObGNraGxiR1JCYlc5MWJuUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVTdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkWE5sY2tobGJHUkJiVzkxYm5RZ1BTQk1iMk5oYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNnTHk4Z1FXMXZkVzUwSUdobGJHUWdabTl5SUdOMWNuSmxiblFnTVRBdGMyVmpiMjVrSUdsdWRHVnlkbUZzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oxYzJWeVNHVnNaRUZ0YjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z1kyOXVjM1FnYUdWc1pFRnRiM1Z1ZENBOUlIUm9hWE11ZFhObGNraGxiR1JCYlc5MWJuUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVTdDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1RHOWpZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnWTI5dWMzUWdiR0Z6ZEZCaGVXMWxiblJVYVcxbElEMGdkR2hwY3k1MWMyVnlUR0Z6ZEZCaGVXMWxiblJVYVcxbEtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx3WlhKelpXTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdjSFZpYkdsaklIVnpaWEpNWVhOMFVHRjViV1Z1ZEZScGJXVWdQU0JNYjJOaGJGTjBZWFJsUEhWcGJuUTJORDRvS1RzZ0x5OGdUR0Z6ZENCd1lYbHRaVzUwSUhScGJXVnpkR0Z0Y0FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZFhObGNreGhjM1JRWVhsdFpXNTBWR2x0WlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnWTI5dWMzUWdiR0Z6ZEZCaGVXMWxiblJVYVcxbElEMGdkR2hwY3k1MWMyVnlUR0Z6ZEZCaGVXMWxiblJVYVcxbEtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbE93b2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUV4dlkyRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFFLSUNBZ0lDOHZJR0Z6YzJWeWRDaG9aV3hrUVcxdmRXNTBJRDRnTUN3Z0lrNXZJR2hsYkdRZ1lXMXZkVzUwSUhSdklIQnliMk5sYzNNaUtUc0tJQ0FnSUdScFp5QXhDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOGdhR1ZzWkNCaGJXOTFiblFnZEc4Z2NISnZZMlZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamcxQ2lBZ0lDQXZMeUJoYzNObGNuUW9SMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0NBK1BTQnNZWE4wVUdGNWJXVnVkRlJwYldVZ0t5QXhNQ3dnSWtsdWRHVnlkbUZzSUc1dmRDQmpiMjF3YkdWMFpTQjVaWFFpS1RzS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TUFvZ0lDQWdLd29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuUmxjblpoYkNCdWIzUWdZMjl0Y0d4bGRHVWdlV1YwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGd0T1RRS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCMGFHbHpMbkJoZVcxbGJuUlNaV05wY0dsbGJuUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQm9aV3hrUVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncE93b2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0Y1YldWdWRGSmxZMmx3YVdWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0NrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ055QXZMeUFpY0dGNWJXVnVkRkpsWTJsd2FXVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx3WlhKelpXTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRPQzA1TXdvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUhSb2FYTXVjR0Y1YldWdWRGSmxZMmx3YVdWdWRDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklHaGxiR1JCYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1nb2dJQ0FnTHk4Z1ptVmxPaUF3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGd0T1RRS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCMGFHbHpMbkJoZVcxbGJuUlNaV05wY0dsbGJuUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQm9aV3hrUVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncE93b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnY0hWaWJHbGpJSFJ2ZEdGc1JXRnlibWx1WjNNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzkwWVd4RllYSnVhVzVuY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGNLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hGWVhKdWFXNW5jeTUyWVd4MVpTQTlJQ2gwYUdsekxuUnZkR0ZzUldGeWJtbHVaM011ZG1Gc2RXVWdLeUJvWld4a1FXMXZkVzUwS1NCaGN5QjFhVzUwTmpRN0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkRzkwWVd4RllYSnVhVzVuY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblJ2ZEdGc1JXRnlibWx1WjNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RjS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4RllYSnVhVzVuY3k1MllXeDFaU0E5SUNoMGFHbHpMblJ2ZEdGc1JXRnlibWx1WjNNdWRtRnNkV1VnS3lCb1pXeGtRVzF2ZFc1MEtTQmhjeUIxYVc1ME5qUTdDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazRDaUFnSUNBdkx5QjBhR2x6TG5WelpYSlViM1JoYkZCaGFXUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0FvZEdocGN5NTFjMlZ5Vkc5MFlXeFFZV2xrS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUNzZ2FHVnNaRUZ0YjNWdWRDa2dZWE1nZFdsdWREWTBPd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnY0hWaWJHbGpJSFZ6WlhKVWIzUmhiRkJoYVdRZ1BTQk1iMk5oYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNnTHk4Z1ZHOTBZV3dnWVcxdmRXNTBJSEJoYVdRZ1lua2dkWE5sY2dvZ0lDQWdZbmwwWldNZ09DQXZMeUFpZFhObGNsUnZkR0ZzVUdGcFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU9Bb2dJQ0FnTHk4Z2RHaHBjeTUxYzJWeVZHOTBZV3hRWVdsa0tGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdLSFJvYVhNdWRYTmxjbFJ2ZEdGc1VHRnBaQ2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0FySUdobGJHUkJiVzkxYm5RcElHRnpJSFZwYm5RMk5Ec0tJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCTWIyTmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek1LSUNBZ0lDOHZJSEIxWW14cFl5QjFjMlZ5Vkc5MFlXeFFZV2xrSUQwZ1RHOWpZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdJQzh2SUZSdmRHRnNJR0Z0YjNWdWRDQndZV2xrSUdKNUlIVnpaWElLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblZ6WlhKVWIzUmhiRkJoYVdRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RnS0lDQWdJQzh2SUhSb2FYTXVkWE5sY2xSdmRHRnNVR0ZwWkNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlDaDBhR2x6TG5WelpYSlViM1JoYkZCaGFXUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdLeUJvWld4a1FXMXZkVzUwS1NCaGN5QjFhVzUwTmpRN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RrS0lDQWdJQzh2SUhSb2FYTXVkWE5sY2t4aGMzUlFZWGx0Wlc1MFZHbHRaU2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUVkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQTdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUhCMVlteHBZeUIxYzJWeVRHRnpkRkJoZVcxbGJuUlVhVzFsSUQwZ1RHOWpZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdJQzh2SUV4aGMzUWdjR0Y1YldWdWRDQjBhVzFsYzNSaGJYQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luVnpaWEpNWVhOMFVHRjViV1Z1ZEZScGJXVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Ua0tJQ0FnSUM4dklIUm9hWE11ZFhObGNreGhjM1JRWVhsdFpXNTBWR2x0WlNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEE3Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF5Q2lBZ0lDQXZMeUIwYUdsekxuVnpaWEpJWld4a1FXMXZkVzUwS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwZ01Ec0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnY0hWaWJHbGpJSFZ6WlhKSVpXeGtRVzF2ZFc1MElEMGdURzlqWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3SUM4dklFRnRiM1Z1ZENCb1pXeGtJR1p2Y2lCamRYSnlaVzUwSURFd0xYTmxZMjl1WkNCcGJuUmxjblpoYkFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZFhObGNraGxiR1JCYlc5MWJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXlDaUFnSUNBdkx5QjBhR2x6TG5WelpYSklaV3hrUVcxdmRXNTBLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnTURzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbFJoY0ZSdlUzUnlaV0Z0TG1OdmJuUnBiblZsVTNSeVpXRnRhVzVuS0hCaGVXMWxiblE2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LWTI5dWRHbHVkV1ZUZEhKbFlXMXBibWM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEE0TFRFd09Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QndkV0pzYVdNZ1kyOXVkR2x1ZFdWVGRISmxZVzFwYm1jb2NHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhOMGNtVmhiVUZqZEdsMlpTQTlJRWRzYjJKaGJGTjBZWFJsUEdKdmIyeGxZVzQrS0NrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYzNSeVpXRnRRV04wYVhabElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuTjBjbVZoYlVGamRHbDJaUzUyWVd4MVpTd2dJbE4wY21WaGJTQnViM1FnWVdOMGFYWmxJaWs3Q2lBZ0lDQmhjM05sY25RZ0x5OGdVM1J5WldGdElHNXZkQ0JoWTNScGRtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1URUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMblZ6WlhKWFlYUmphRk4wWVhKMFZHbHRaU2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0ErSURBc0lDSk5kWE4wSUhOMFlYSjBJSE4wY21WaGJXbHVaeUJtYVhKemRDSXBPd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnY0hWaWJHbGpJSFZ6WlhKWFlYUmphRk4wWVhKMFZHbHRaU0E5SUV4dlkyRnNVM1JoZEdVOGRXbHVkRFkwUGlncE95QXZMeUJYYUdWdUlIVnpaWElnYzNSaGNuUmxaQ0IzWVhSamFHbHVad29nSUNBZ1lubDBaV01nTkNBdkx5QWlkWE5sY2xkaGRHTm9VM1JoY25SVWFXMWxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhNUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11ZFhObGNsZGhkR05vVTNSaGNuUlVhVzFsS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQ0Z01Dd2dJazExYzNRZ2MzUmhjblFnYzNSeVpXRnRhVzVuSUdacGNuTjBJaWs3Q2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dURzlqWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdGemMyVnlkQ0F2THlCTmRYTjBJSE4wWVhKMElITjBjbVZoYldsdVp5Qm1hWEp6ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjSEpwWTJWUVpYSlRaV052Ym1RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3SUM4dklHbHVJRzFwWTNKdlFXeG5iM01LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSndjbWxqWlZCbGNsTmxZMjl1WkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEUwQ2lBZ0lDQXZMeUJqYjI1emRDQjBaVzVUWldOdmJtUkRiM04wSUQwZ0tIUm9hWE11Y0hKcFkyVlFaWEpUWldOdmJtUXVkbUZzZFdVZ0tpQXhNQ2tnWVhNZ2RXbHVkRFkwT3dvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQXFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTNDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0lDSlFZWGx0Wlc1MElHMTFjM1FnWW1VZ2RHOGdZWEJ3SWlrN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRWVhsdFpXNTBJRzExYzNRZ1ltVWdkRzhnWVhCd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFNENpQWdJQ0F2THlCaGMzTmxjblFvY0dGNWJXVnVkQzVoYlc5MWJuUWdQajBnZEdWdVUyVmpiMjVrUTI5emRDd2dJa2x1YzNWbVptbGphV1Z1ZENCd1lYbHRaVzUwSUdadmNpQXhNQzF6WldOdmJtUWdhVzUwWlhKMllXd2lLVHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCa2FXY2dNUW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuTjFabVpwWTJsbGJuUWdjR0Y1YldWdWRDQm1iM0lnTVRBdGMyVmpiMjVrSUdsdWRHVnlkbUZzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl4Q2lBZ0lDQXZMeUIwYUdsekxuVnpaWEpJWld4a1FXMXZkVzUwS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwZ2RHVnVVMlZqYjI1a1EyOXpkRHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhWelpYSklaV3hrUVcxdmRXNTBJRDBnVEc5allXeFRkR0YwWlR4MWFXNTBOalErS0NrN0lDOHZJRUZ0YjNWdWRDQm9aV3hrSUdadmNpQmpkWEp5Wlc1MElERXdMWE5sWTI5dVpDQnBiblJsY25aaGJBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRYTmxja2hsYkdSQmJXOTFiblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl4Q2lBZ0lDQXZMeUIwYUdsekxuVnpaWEpJWld4a1FXMXZkVzUwS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwZ2RHVnVVMlZqYjI1a1EyOXpkRHNLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVVlYQlViMU4wY21WaGJTNXpkRzl3VTNSeVpXRnRhVzVuS0NrZ0xUNGdkbTlwWkRvS2MzUnZjRk4wY21WaGJXbHVaem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx3WlhKelpXTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNamN0TVRJNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklIQjFZbXhwWXlCemRHOXdVM1J5WldGdGFXNW5LQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTUNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJNUNpQWdJQ0F2THlCamIyNXpkQ0JvWld4a1FXMXZkVzUwSUQwZ2RHaHBjeTUxYzJWeVNHVnNaRUZ0YjNWdWRDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJSEIxWW14cFl5QjFjMlZ5U0dWc1pFRnRiM1Z1ZENBOUlFeHZZMkZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPeUF2THlCQmJXOTFiblFnYUdWc1pDQm1iM0lnWTNWeWNtVnVkQ0F4TUMxelpXTnZibVFnYVc1MFpYSjJZV3dLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblZ6WlhKSVpXeGtRVzF2ZFc1MElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU9Rb2dJQ0FnTHk4Z1kyOXVjM1FnYUdWc1pFRnRiM1Z1ZENBOUlIUm9hWE11ZFhObGNraGxiR1JCYlc5MWJuUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVTdDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRXh2WTJGc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTXhDaUFnSUNBdkx5QnBaaUFvYUdWc1pFRnRiM1Z1ZENBK0lEQXBJSHNLSUNBZ0lHSjZJSE4wYjNCVGRISmxZVzFwYm1kZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE16TFRFek9Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJvWld4a1FXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BPd29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek5Rb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpNdE1UTTRDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUdobGJHUkJiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpjS0lDQWdJQzh2SUdabFpUb2dNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNeTB4TXprS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dhR1ZzWkVGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tUc0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENncHpkRzl3VTNSeVpXRnRhVzVuWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx3WlhKelpXTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORE1LSUNBZ0lDOHZJSFJvYVhNdWRYTmxja2hsYkdSQmJXOTFiblFvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNBd093b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkWE5sY2tobGJHUkJiVzkxYm5RZ1BTQk1iMk5oYkZOMFlYUmxQSFZwYm5RMk5ENG9LVHNnTHk4Z1FXMXZkVzUwSUdobGJHUWdabTl5SUdOMWNuSmxiblFnTVRBdGMyVmpiMjVrSUdsdWRHVnlkbUZzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0oxYzJWeVNHVnNaRUZ0YjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ETUtJQ0FnSUM4dklIUm9hWE11ZFhObGNraGxiR1JCYlc5MWJuUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0F3T3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx3WlhKelpXTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORFFLSUNBZ0lDOHZJSFJvYVhNdWRYTmxjbGRoZEdOb1UzUmhjblJVYVcxbEtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdNRHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhWelpYSlhZWFJqYUZOMFlYSjBWR2x0WlNBOUlFeHZZMkZzVTNSaGRHVThkV2x1ZERZMFBpZ3BPeUF2THlCWGFHVnVJSFZ6WlhJZ2MzUmhjblJsWkNCM1lYUmphR2x1WndvZ0lDQWdZbmwwWldNZ05DQXZMeUFpZFhObGNsZGhkR05vVTNSaGNuUlVhVzFsSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTkFvZ0lDQWdMeThnZEdocGN5NTFjMlZ5VjJGMFkyaFRkR0Z5ZEZScGJXVW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0F3T3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx3WlhKelpXTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZWR0Z3Vkc5VGRISmxZVzB1ZFhCa1lYUmxVR0Y1YldWdWRGSmxZMmx3YVdWdWRDaHVaWGRTWldOcGNHbGxiblE2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3AxY0dSaGRHVlFZWGx0Wlc1MFVtVmphWEJwWlc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU1DMHhOVEVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnY0hWaWJHbGpJSFZ3WkdGMFpWQmhlVzFsYm5SU1pXTnBjR2xsYm5Rb2JtVjNVbVZqYVhCcFpXNTBPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRJS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG5OMGNtVmhiVTkzYm1WeUxuWmhiSFZsTENBaVQyNXNlU0J2ZDI1bGNpQmpZVzRnZFhCa1lYUmxJSEpsWTJsd2FXVnVkQ0lwT3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5QndkV0pzYVdNZ2MzUnlaV0Z0VDNkdVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5OMGNtVmhiVTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRJS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG5OMGNtVmhiVTkzYm1WeUxuWmhiSFZsTENBaVQyNXNlU0J2ZDI1bGNpQmpZVzRnZFhCa1lYUmxJSEpsWTJsd2FXVnVkQ0lwT3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUc5M2JtVnlJR05oYmlCMWNHUmhkR1VnY21WamFYQnBaVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSEIxWW14cFl5QndZWGx0Wlc1MFVtVmphWEJwWlc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvS1RzS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5CaGVXMWxiblJTWldOcGNHbGxiblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFV6Q2lBZ0lDQXZMeUIwYUdsekxuQmhlVzFsYm5SU1pXTnBjR2xsYm5RdWRtRnNkV1VnUFNCdVpYZFNaV05wY0dsbGJuUTdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sUmhjRlJ2VTNSeVpXRnRMbVZ0WlhKblpXNWplVk4wYjNBb0tTQXRQaUIyYjJsa09ncGxiV1Z5WjJWdVkzbFRkRzl3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTVFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11YzNSeVpXRnRUM2R1WlhJdWRtRnNkV1VzSUNKUGJteDVJRzkzYm1WeUlHTmhiaUJsYldWeVoyVnVZM2tnYzNSdmNDSXBPd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCd2RXSnNhV01nYzNSeVpXRnRUM2R1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwT3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbk4wY21WaGJVOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx3WlhKelpXTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOakVLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbk4wY21WaGJVOTNibVZ5TG5aaGJIVmxMQ0FpVDI1c2VTQnZkMjVsY2lCallXNGdaVzFsY21kbGJtTjVJSE4wYjNBaUtUc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQnZkMjVsY2lCallXNGdaVzFsY21kbGJtTjVJSE4wYjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnY0hWaWJHbGpJSE4wY21WaGJVRmpkR2wyWlNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLQ2s3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p6ZEhKbFlXMUJZM1JwZG1VaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZeUNpQWdJQ0F2THlCMGFHbHpMbk4wY21WaGJVRmpkR2wyWlM1MllXeDFaU0E5SUdaaGJITmxPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sUmhjRlJ2VTNSeVpXRnRMbWRsZEZOMGNtVmhiVWx1Wm04b0tTQXRQaUJpZVhSbGN5d2dkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalE2Q21kbGRGTjBjbVZoYlVsdVptODZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSUtJQ0FnSUM4dklIQjFZbXhwWXlCemRISmxZVzFVYVhSc1pTQTlJRWRzYjJKaGJGTjBZWFJsUEhOMGNtbHVaejRvS1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpYzNSeVpXRnRWR2wwYkdVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjM1J5WldGdFJIVnlZWFJwYjI0Z1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2s3SUM4dklHbHVJSE5sWTI5dVpITUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaWMzUnlaV0Z0UkhWeVlYUnBiMjRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QndkV0pzYVdNZ2NISnBZMlZRWlhKVFpXTnZibVFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDazdJQzh2SUdsdUlHMXBZM0p2UVd4bmIzTUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKd2NtbGpaVkJsY2xObFkyOXVaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNISnBZMlZRWlhKVFpXTnZibVFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRNUW9nSUNBZ0x5OGdkR1Z1VTJWamIyNWtRMjl6ZERvZ0tIUm9hWE11Y0hKcFkyVlFaWEpUWldOdmJtUXVkbUZzZFdVZ0tpQXhNQ2tnWVhNZ2RXbHVkRFkwTEFvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQXFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklIQjFZbXhwWXlCMGIzUmhiRVZoY201cGJtZHpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNSV0Z5Ym1sdVozTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCd2RXSnNhV01nYzNSeVpXRnRRV04wYVhabElEMGdSMnh2WW1Gc1UzUmhkR1U4WW05dmJHVmhiajRvS1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p6ZEhKbFlXMUJZM1JwZG1VaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVhCbGNuTmxZeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTnkweE9EUUtJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lIUnBkR3hsT2lCMGFHbHpMbk4wY21WaGJWUnBkR3hsTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JrZFhKaGRHbHZiam9nZEdocGN5NXpkSEpsWVcxRWRYSmhkR2x2Ymk1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnY0hKcFkyVlFaWEpUWldOdmJtUTZJSFJvYVhNdWNISnBZMlZRWlhKVFpXTnZibVF1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJSFJsYmxObFkyOXVaRU52YzNRNklDaDBhR2x6TG5CeWFXTmxVR1Z5VTJWamIyNWtMblpoYkhWbElDb2dNVEFwSUdGeklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2RHOTBZV3hGWVhKdWFXNW5jem9nZEdocGN5NTBiM1JoYkVWaGNtNXBibWR6TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JoWTNScGRtVTZJSFJvYVhNdWMzUnlaV0Z0UVdOMGFYWmxMblpoYkhWbExBb2dJQ0FnTHk4Z2ZUc0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlZHRndWRzlUZEhKbFlXMHVaMlYwVlhObGNsTjBjbVZoYldsdVowbHVabThvS1NBdFBpQjFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalFzSUhWcGJuUTJORG9LWjJWMFZYTmxjbE4wY21WaGJXbHVaMGx1Wm04NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrd0xURTVOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaMlYwVlhObGNsTjBjbVZoYldsdVowbHVabThvS1RvZ2V3b2dJQ0FnTHk4Z0lDQm9aV3hrUVcxdmRXNTBPaUIxYVc1ME5qUTdDaUFnSUNBdkx5QWdJR3hoYzNSUVlYbHRaVzUwVkdsdFpUb2dkV2x1ZERZME93b2dJQ0FnTHk4Z0lDQjBiM1JoYkZCaGFXUTZJSFZwYm5RMk5Ec0tJQ0FnSUM4dklDQWdkMkYwWTJoVGRHRnlkRlJwYldVNklIVnBiblEyTkRzS0lDQWdJQzh2SUNBZ1kyRnVVSEp2WTJWemMwbHVkR1Z5ZG1Gc09pQmliMjlzWldGdU93b2dJQ0FnTHk4Z2ZTQjdDaUFnSUNCd2NtOTBieUF3SURVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsd1pYSnpaV012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RnS0lDQWdJQzh2SUdOdmJuTjBJR3hoYzNSUVlYbHRaVzUwVkdsdFpTQTlJSFJvYVhNdWRYTmxja3hoYzNSUVlYbHRaVzUwVkdsdFpTaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpUc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1Y0dWeWMyVmpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJSEIxWW14cFl5QjFjMlZ5VEdGemRGQmhlVzFsYm5SVWFXMWxJRDBnVEc5allXeFRkR0YwWlR4MWFXNTBOalErS0NrN0lDOHZJRXhoYzNRZ2NHRjViV1Z1ZENCMGFXMWxjM1JoYlhBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5WelpYSk1ZWE4wVUdGNWJXVnVkRlJwYldVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrNENpQWdJQ0F2THlCamIyNXpkQ0JzWVhOMFVHRjViV1Z1ZEZScGJXVWdQU0IwYUdsekxuVnpaWEpNWVhOMFVHRjViV1Z1ZEZScGJXVW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVTdDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRXh2WTJGc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjVjR1Z5YzJWakwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UazVDaUFnSUNBdkx5QmpiMjV6ZENCallXNVFjbTlqWlhOeklEMGdiR0Z6ZEZCaGVXMWxiblJVYVcxbElENGdNQ0FtSmlCSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdJRDQ5SUd4aGMzUlFZWGx0Wlc1MFZHbHRaU0FySURFd093b2dJQ0FnWW5vZ1oyVjBWWE5sY2xOMGNtVmhiV2x1WjBsdVptOWZZbTl2YkY5bVlXeHpaVUF6Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2FXNTBZMTh5SUM4dklERXdDaUFnSUNBckNpQWdJQ0ErUFFvZ0lDQWdZbm9nWjJWMFZYTmxjbE4wY21WaGJXbHVaMGx1Wm05ZlltOXZiRjltWVd4elpVQXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0taMlYwVlhObGNsTjBjbVZoYldsdVowbHVabTlmWW05dmJGOXRaWEpuWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd01nb2dJQ0FnTHk4Z2FHVnNaRUZ0YjNWdWREb2dkR2hwY3k1MWMyVnlTR1ZzWkVGdGIzVnVkQ2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUhCMVlteHBZeUIxYzJWeVNHVnNaRUZ0YjNWdWRDQTlJRXh2WTJGc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3lBdkx5QkJiVzkxYm5RZ2FHVnNaQ0JtYjNJZ1kzVnljbVZ1ZENBeE1DMXpaV052Ym1RZ2FXNTBaWEoyWVd3S0lDQWdJR0o1ZEdWalh6QWdMeThnSW5WelpYSklaV3hrUVcxdmRXNTBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdNZ29nSUNBZ0x5OGdhR1ZzWkVGdGIzVnVkRG9nZEdocGN5NTFjMlZ5U0dWc1pFRnRiM1Z1ZENoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJNYjJOaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdOQW9nSUNBZ0x5OGdkRzkwWVd4UVlXbGtPaUIwYUdsekxuVnpaWEpVYjNSaGJGQmhhV1FvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVYQmxjbk5sWXk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNekNpQWdJQ0F2THlCd2RXSnNhV01nZFhObGNsUnZkR0ZzVUdGcFpDQTlJRXh2WTJGc1UzUmhkR1U4ZFdsdWREWTBQaWdwT3lBdkx5QlViM1JoYkNCaGJXOTFiblFnY0dGcFpDQmllU0IxYzJWeUNpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKMWMyVnlWRzkwWVd4UVlXbGtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdOQW9nSUNBZ0x5OGdkRzkwWVd4UVlXbGtPaUIwYUdsekxuVnpaWEpVYjNSaGJGQmhhV1FvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dURzlqWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHdaWEp6WldNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1EVUtJQ0FnSUM4dklIZGhkR05vVTNSaGNuUlVhVzFsT2lCMGFHbHpMblZ6WlhKWFlYUmphRk4wWVhKMFZHbHRaU2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWNHVnljMlZqTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhCMVlteHBZeUIxYzJWeVYyRjBZMmhUZEdGeWRGUnBiV1VnUFNCTWIyTmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tUc2dMeThnVjJobGJpQjFjMlZ5SUhOMFlYSjBaV1FnZDJGMFkyaHBibWNLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJblZ6WlhKWFlYUmphRk4wWVhKMFZHbHRaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx3WlhKelpXTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRFVLSUNBZ0lDOHZJSGRoZEdOb1UzUmhjblJVYVcxbE9pQjBhR2x6TG5WelpYSlhZWFJqYUZOMFlYSjBWR2x0WlNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJNYjJOaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlWEJsY25ObFl5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdNUzB5TURjS0lDQWdJQzh2SUhKbGRIVnliaUI3Q2lBZ0lDQXZMeUFnSUdobGJHUkJiVzkxYm5RNklIUm9hWE11ZFhObGNraGxiR1JCYlc5MWJuUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJR3hoYzNSUVlYbHRaVzUwVkdsdFpUb2diR0Z6ZEZCaGVXMWxiblJVYVcxbExBb2dJQ0FnTHk4Z0lDQjBiM1JoYkZCaGFXUTZJSFJvYVhNdWRYTmxjbFJ2ZEdGc1VHRnBaQ2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnZDJGMFkyaFRkR0Z5ZEZScGJXVTZJSFJvYVhNdWRYTmxjbGRoZEdOb1UzUmhjblJVYVcxbEtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQmpZVzVRY205alpYTnpTVzUwWlhKMllXdzZJR05oYmxCeWIyTmxjM01zQ2lBZ0lDQXZMeUI5T3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCeVpYUnpkV0lLQ21kbGRGVnpaWEpUZEhKbFlXMXBibWRKYm1adlgySnZiMnhmWm1Gc2MyVkFNem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHZGxkRlZ6WlhKVGRISmxZVzFwYm1kSmJtWnZYMkp2YjJ4ZmJXVnlaMlZBTkFvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBREFBRUtKZ3dPZFhObGNraGxiR1JCYlc5MWJuUU1jM1J5WldGdFFXTjBhWFpsRG5CeWFXTmxVR1Z5VTJWamIyNWtEWFJ2ZEdGc1JXRnlibWx1WjNNU2RYTmxjbGRoZEdOb1UzUmhjblJVYVcxbEUzVnpaWEpNWVhOMFVHRjViV1Z1ZEZScGJXVUxjM1J5WldGdFQzZHVaWElRY0dGNWJXVnVkRkpsWTJsd2FXVnVkQTExYzJWeVZHOTBZV3hRWVdsa0JCVWZmSFVMYzNSeVpXRnRWR2wwYkdVT2MzUnlaV0Z0UkhWeVlYUnBiMjR4RzBFQk40SUpCSE1iOEJvRVpNbDVwUVFhOW1HaEJJRWppTlVFS0dKSkhnVHIydlMxQkxobUdvSUVFRmNyaWdRQXVYbExOaG9BamdrQTF3REJBTFVBbndDVEFJRUFkUUF6QUFJaVF6RVpGRVF4R0VTSUFqRlBCQlpQQkJaUEJCWlBCQmFBQVFBaVR3WlVUd1JQQkZCUEExQlBBbEJNVUNjSlRGQ3dJME14R1JSRU1SaEVpQUhqU3dVVkZsY0dBazhHVUU4RkZrOEZGazhGRms4RkZvQUJBQ0pQQjFTQUFnQWpUd1ZRVHdSUVR3TlFUd0pRVEZCTVVDY0pURkN3STBNeEdSUkVNUmhFaUFHVUkwTXhHUlJFTVJoRU5ob0JGOEFjaUFGd0kwTXhHUlJFTVJoRWlBRTRJME14R1JSRU1SaEVNUllqQ1VrNEVDTVNSSWdBOVNORE1Sa1VSREVZUklnQWtpTkRNUmtVUkRFWVJERVdJd2xKT0JBakVrU0lBRWtqUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0lYTmhvREY0Z0FEU05ETVJsQS93b3hHQlJFSTBPS0F3QW5CakVBWnljS2kvMW5Kd3VML21jcWkvOW5LU05uS3lKbkp3Y3hBR2VKaWdFQUlpbGxSRVFpS21WRUpBdUwvemdITWdvU1JJdi9PQWhMQVE5RU1RQW9Ud0ptTVFBbkJESUhaakVBSndVeUIyYUpJaWxsUkVReEFDSW9ZMFF4QUNJbkJXTkVTd0ZFTWdkTUpBZ1BSTEVpSndkbFJFc0JzZ2l5QnlPeUVDS3lBYk1pSzJWRVN3RUlLMHhuTVFBaUp3aGpSREVBVEU4Q0NDY0lUR1l4QUNjRk1nZG1NUUFvSW1hSmlnRUFJaWxsUkVReEFDSW5CR05FUkNJcVpVUWtDNHYvT0FjeUNoSkVpLzg0Q0VzQkQwUXhBQ2hQQW1hSmlnQUFNUUFpS0dOTVNVOENSRUVBRUxFeEFJc0FzZ2l5QnlPeUVDS3lBYk14QUNnaVpqRUFKd1FpWm9tS0FRQXhBQ0luQm1WRUVrUW5CNHYvWjRreEFDSW5CbVZFRWtRcEltZUpJaWNLWlVRaUp3dGxSQ0lxWlVRaUttVkVKQXNpSzJWRUlpbGxSSW1LQUFVeEFDSW5CV05NU1U4Q1JFRUFMRElIaXdBa0NBOUJBQ0lqTVFBaUtHTkVNUUFpSndoalJERUFJaWNFWTBSUEFvc0FUd05QQTA4RVR3V0pJa0wvMnc9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
