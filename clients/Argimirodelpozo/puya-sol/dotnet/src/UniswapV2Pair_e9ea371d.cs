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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.UniswapV2Pair_e9ea371d
{


    public class UniswapV2PairProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public UniswapV2PairProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class BurnReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmount0.From(Amount0);
                    ret.AddRange(vAmount0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmount1.From(Amount1);
                    ret.AddRange(vAmount1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BurnReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BurnReturn();
                    uint count = 0;
                    var vAmount0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmount0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Amount0 = vAmount0;
                    var vAmount1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmount1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Amount1 = vAmount1;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BurnReturn);
                }
                public bool Equals(BurnReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BurnReturn left, BurnReturn right)
                {
                    return EqualityComparer<BurnReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(BurnReturn left, BurnReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetReservesReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Reserve0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Reserve1 { get; set; }

                public ulong BlockTimestampLast { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReserve0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vReserve0.From(Reserve0);
                    ret.AddRange(vReserve0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReserve1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vReserve1.From(Reserve1);
                    ret.AddRange(vReserve1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBlockTimestampLast = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBlockTimestampLast.From(BlockTimestampLast);
                    ret.AddRange(vBlockTimestampLast.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetReservesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetReservesReturn();
                    uint count = 0;
                    var vReserve0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vReserve0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Reserve0 = vReserve0;
                    var vReserve1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vReserve1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Reserve1 = vReserve1;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBlockTimestampLast = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBlockTimestampLast.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBlockTimestampLast = vBlockTimestampLast.ToValue();
                    if (valueBlockTimestampLast is ulong vBlockTimestampLastValue) { ret.BlockTimestampLast = vBlockTimestampLastValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetReservesReturn);
                }
                public bool Equals(GetReservesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetReservesReturn left, GetReservesReturn right)
                {
                    return EqualityComparer<GetReservesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetReservesReturn left, GetReservesReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class TransferEvent
            {
                public static readonly byte[] Selector = new byte[4] { 154, 200, 211, 241 };
                public const string Signature = "Transfer(uint8[32],uint8[32],uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] From { get; set; }
                public byte[] To { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Value { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

            }

            public class SyncEvent
            {
                public static readonly byte[] Selector = new byte[4] { 85, 42, 212, 160 };
                public const string Signature = "Sync(uint256,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Reserve0 { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Reserve1 { get; set; }

                public static SyncEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SyncEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReserve0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vReserve0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReserve0 = vReserve0.ToValue();
                    if (valueReserve0 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vReserve0Value) { ret.Reserve0 = vReserve0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReserve1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vReserve1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReserve1 = vReserve1.ToValue();
                    if (valueReserve1 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vReserve1Value) { ret.Reserve1 = vReserve1Value; }
                    return ret;

                }

            }

            public class MintEvent
            {
                public static readonly byte[] Selector = new byte[4] { 251, 246, 72, 245 };
                public const string Signature = "Mint(uint8[32],uint256,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Sender { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount0 { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount1 { get; set; }

                public static MintEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new MintEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSender = vSender.ToValue();
                    if (valueSender is byte[] vSenderValue) { ret.Sender = vSenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAmount0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount0 = vAmount0.ToValue();
                    if (valueAmount0 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAmount0Value) { ret.Amount0 = vAmount0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAmount1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount1 = vAmount1.ToValue();
                    if (valueAmount1 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAmount1Value) { ret.Amount1 = vAmount1Value; }
                    return ret;

                }

            }

            public class BurnEvent
            {
                public static readonly byte[] Selector = new byte[4] { 28, 100, 129, 144 };
                public const string Signature = "Burn(uint8[32],uint256,uint256,uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Sender { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount0 { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount1 { get; set; }
                public byte[] To { get; set; }

                public static BurnEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new BurnEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSender = vSender.ToValue();
                    if (valueSender is byte[] vSenderValue) { ret.Sender = vSenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAmount0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount0 = vAmount0.ToValue();
                    if (valueAmount0 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAmount0Value) { ret.Amount0 = vAmount0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAmount1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount1 = vAmount1.ToValue();
                    if (valueAmount1 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAmount1Value) { ret.Amount1 = vAmount1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTo = vTo.ToValue();
                    if (valueTo is byte[] vToValue) { ret.To = vToValue; }
                    return ret;

                }

            }

            public class SwapEvent
            {
                public static readonly byte[] Selector = new byte[4] { 211, 21, 59, 134 };
                public const string Signature = "Swap(uint8[32],uint256,uint256,uint256,uint256,uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Sender { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount0In { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount1In { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount0Out { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Amount1Out { get; set; }
                public byte[] To { get; set; }

                public static SwapEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new SwapEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSender = vSender.ToValue();
                    if (valueSender is byte[] vSenderValue) { ret.Sender = vSenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount0In = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAmount0In.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount0In = vAmount0In.ToValue();
                    if (valueAmount0In is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAmount0InValue) { ret.Amount0In = vAmount0InValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount1In = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAmount1In.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount1In = vAmount1In.ToValue();
                    if (valueAmount1In is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAmount1InValue) { ret.Amount1In = vAmount1InValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount0Out = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAmount0Out.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount0Out = vAmount0Out.ToValue();
                    if (valueAmount0Out is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAmount0OutValue) { ret.Amount0Out = vAmount0OutValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount1Out = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAmount1Out.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount1Out = vAmount1Out.ToValue();
                    if (valueAmount1Out is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAmount1OutValue) { ret.Amount1Out = vAmount1OutValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTo = vTo.ToValue();
                    if (valueTo is byte[] vToValue) { ret.To = vToValue; }
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
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Value { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetReservesReturn> GetReserves(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 67, 38, 147 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetReservesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetReserves_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 67, 38, 147 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_token0"> </param>
        /// <param name="_token1"> </param>
        public async Task Initialize(Algorand.Address _token0, Algorand.Address _token1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 123, 4, 36 };
            var _token0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _token0Abi.From(_token0);
            var _token1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _token1Abi.From(_token1);

            var result = await base.CallApp(new List<object> { abiHandle, _token0Abi, _token1Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(Algorand.Address _token0, Algorand.Address _token1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 123, 4, 36 };
            var _token0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _token0Abi.From(_token0);
            var _token1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _token1Abi.From(_token1);

            return await base.MakeTransactionList(new List<object> { abiHandle, _token0Abi, _token1Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="to"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Mint(Algorand.Address to, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 56, 39, 22 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Mint_Transactions(Algorand.Address to, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 56, 39, 22 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="to"> </param>
        public async Task<Structs.BurnReturn> Burn(Algorand.Address to, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 165, 53, 232 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BurnReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Burn_Transactions(Algorand.Address to, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 165, 53, 232 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount0Out"> </param>
        /// <param name="amount1Out"> </param>
        /// <param name="to"> </param>
        /// <param name="data"> </param>
        public async Task Swap(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount0Out, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount1Out, Algorand.Address to, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 128, 10, 23 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, amount0Out, amount1Out, toAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Swap_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount0Out, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amount1Out, Algorand.Address to, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 128, 10, 23 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, amount0Out, amount1Out, toAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="to"> </param>
        public async Task Skim(Algorand.Address to, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 179, 163, 155 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Skim_Transactions(Algorand.Address to, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 179, 163, 155 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Sync(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 243, 150, 130 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Sync_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 243, 150, 130 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="spender"> </param>
        /// <param name="value"> </param>
        public async Task<bool> Approve(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 251, 106, 8 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            var result = await base.CallApp(new List<object> { abiHandle, spenderAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Approve_Transactions(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 251, 106, 8 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, spenderAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="value"> </param>
        public async Task<bool> Transfer(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 140, 152, 32 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Transfer_Transactions(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 140, 152, 32 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="from"> </param>
        /// <param name="to"> </param>
        /// <param name="value"> </param>
        public async Task<bool> TransferFrom(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 244, 31, 109 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TransferFrom_Transactions(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 244, 31, 109 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="spender"> </param>
        /// <param name="value"> </param>
        /// <param name="deadline"> </param>
        /// <param name="v"> </param>
        /// <param name="r"> </param>
        /// <param name="s"> </param>
        public async Task Permit(Algorand.Address owner, Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 deadline, ulong v, byte[] r, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 141, 208, 143 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);
            var vAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vAbi.From(v);
            var rAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); rAbi.From(r);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); sAbi.From(s);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi, spenderAbi, value, deadline, vAbi, rAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Permit_Transactions(Algorand.Address owner, Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 deadline, ulong v, byte[] r, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 141, 208, 143 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);
            var vAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vAbi.From(v);
            var rAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); rAbi.From(r);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); sAbi.From(s);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, spenderAbi, value, deadline, vAbi, rAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Factory(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 76, 64, 27 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Factory_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 76, 64, 27 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Token0(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 24, 69, 227 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Token0_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 24, 69, 227 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Token1(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 12, 148, 153 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Token1_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 12, 148, 153 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Price0CumulativeLast(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 232, 194, 162 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Price0CumulativeLast_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 232, 194, 162 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Price1CumulativeLast(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 122, 86, 129 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Price1CumulativeLast_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 122, 86, 129 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> KLast(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 228, 212, 31 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> KLast_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 228, 212, 31 };

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
        ///
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVW5pc3dhcFYyUGFpciIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJidXJuUmV0dXJuIjpbeyJuYW1lIjoiYW1vdW50MCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiYW1vdW50MSIsInR5cGUiOiJ1aW50MjU2In1dLCJnZXRSZXNlcnZlc1JldHVybiI6W3sibmFtZSI6Il9yZXNlcnZlMCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiX3Jlc2VydmUxIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJfYmxvY2tUaW1lc3RhbXBMYXN0IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRSZXNlcnZlcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDI1Nix1aW50MjU2LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJnZXRSZXNlcnZlc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX3Rva2VuMCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il90b2tlbjEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWludCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU3luYyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzZXJ2ZTAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzZXJ2ZTEiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Ik1pbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50MSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1cm4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiYnVyblJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlN5bmMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc2VydmUwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc2VydmUxIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJCdXJuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN3YXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDBPdXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQxT3V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlN5bmMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc2VydmUwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc2VydmUxIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJTd2FwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQwSW4iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50MUluIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDBPdXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50MU91dCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2tpbSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3luYyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiU3luYyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzZXJ2ZTAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzZXJ2ZTEiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHByb3ZlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2ZlckZyb20iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwZXJtaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVhZGxpbmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmYWN0b3J5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9rZW4wIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG9rZW4xIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJpY2UwQ3VtdWxhdGl2ZUxhc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcmljZTFDdW11bGF0aXZlTGFzdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImtMYXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG90YWxTdXBwbHkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJET01BSU5fU0VQQVJBVE9SIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MTF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzExNjFdLCJlcnJvck1lc3NhZ2UiOiJCYWQgZGVzaXJlZCBsaXF1aWRpdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjcwXSwiZXJyb3JNZXNzYWdlIjoiTXVzdCBub3QgaGF2ZSBtaWdyYXRvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MjZdLCJlcnJvck1lc3NhZ2UiOiJVbmlzd2FwVjI6IEVYUElSRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MDNdLCJlcnJvck1lc3NhZ2UiOiJVbmlzd2FwVjI6IEZPUkJJRERFTiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMDJdLCJlcnJvck1lc3NhZ2UiOiJVbmlzd2FwVjI6IElOU1VGRklDSUVOVF9JTlBVVF9BTU9VTlQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODM5XSwiZXJyb3JNZXNzYWdlIjoiVW5pc3dhcFYyOiBJTlNVRkZJQ0lFTlRfTElRVUlESVRZIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUxN10sImVycm9yTWVzc2FnZSI6IlVuaXN3YXBWMjogSU5TVUZGSUNJRU5UX0xJUVVJRElUWV9CVVJORUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTY4XSwiZXJyb3JNZXNzYWdlIjoiVW5pc3dhcFYyOiBJTlNVRkZJQ0lFTlRfTElRVUlESVRZX01JTlRFRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MDhdLCJlcnJvck1lc3NhZ2UiOiJVbmlzd2FwVjI6IElOU1VGRklDSUVOVF9PVVRQVVRfQU1PVU5UIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg4MF0sImVycm9yTWVzc2FnZSI6IlVuaXN3YXBWMjogSU5WQUxJRF9TSUdOQVRVUkUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODc0XSwiZXJyb3JNZXNzYWdlIjoiVW5pc3dhcFYyOiBJTlZBTElEX1RPIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE4NF0sImVycm9yTWVzc2FnZSI6IlVuaXN3YXBWMjogSyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzMywxMzQ5LDE3ODUsMjMxNCwyNDA4XSwiZXJyb3JNZXNzYWdlIjoiVW5pc3dhcFYyOiBMT0NLRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDU1XSwiZXJyb3JNZXNzYWdlIjoiVW5pc3dhcFYyOiBPVkVSRkxPVyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NjQsMzAwOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIERPTUFJTl9TRVBBUkFUT1IgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAzMCwzMDk5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgYmxvY2tUaW1lc3RhbXBMYXN0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwMSwxMDcxLDI5MDAsMzI1Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIGZhY3RvcnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk3MSwzMjk3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sga0xhc3QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkzMywzMTMwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcHJpY2UwQ3VtdWxhdGl2ZUxhc3QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk1MiwzMTU5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcHJpY2UxQ3VtdWxhdGl2ZUxhc3QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE5NSwxNjUxLDIzNjEsMjQ4NCwzMDIwLDMyMDVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayByZXNlcnZlMCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjAwLDE2NTYsMjM5MiwyNDg5LDMwMjUsMzIyMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHJlc2VydmUxIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2NiwxMzc5LDE4NTAsMjMyNCwyNDIxLDI5MTFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayB0b2tlbjAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwMiwxMzg0LDE4NTgsMjMyOSwyNDQ5LDI5MjJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayB0b2tlbjEgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2MSwxNDc5LDE1NDksMjk5MCwzMzQxLDM0MjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayB0b3RhbFN1cHBseSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MjksMTM0NSwxNzc4LDIzMDcsMjQwMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHVubG9ja2VkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0OF0sImVycm9yTWVzc2FnZSI6ImRzLW1hdGgtYWRkLW92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODAwXSwiZXJyb3JNZXNzYWdlIjoiZHMtbWF0aC1tdWwtb3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjhdLCJlcnJvck1lc3NhZ2UiOiJkcy1tYXRoLXN1Yi11bmRlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzYyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc3MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4ODYsODk0LDkyNSwxMzQxLDE3NTYsMjMwMywyNTA1LDI1MzMsMjU2MiwyNTcyLDI2NjMsMjY3NCwyNzExLDI3MTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTczMywxNzQ2LDI1MTMsMjU0MSwyNTgyLDI2ODUsMjY5M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzAyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODUwLDg2MywxMjE0LDEyMjcsMTI1MywxNTYzLDE2NzAsMTY4MywyMjAwLDIyMTEsMjIyMiwyMjMyLDI5MzgsMjk1NywyOTc2LDI5OTUsMzIxMCwzMjI2LDM0NTgsMzUwMiwzNTczXSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMzVnphR2x6ZDJGd0xYWXlMMk52Ym5SeVlXTjBjeTlWYm1semQyRndWakpRWVdseUxuTnZiQzVWYm1semQyRndWakpRWVdseUxtRndjSEp2ZG1Gc1gzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBek1pQXhJRFlLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGdnSW5WdWJHOWphMlZrSWlBd2VEZ3pZbUZrTjJOaklEQjRNVFV4Wmpkak56VWdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ0luUnZkR0ZzVTNWd2NHeDVJaUJpWVhObE16SW9RVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFTa2dJblJ2YTJWdU1DSWdJblJ2YTJWdU1TSWdJbkpsYzJWeWRtVXdJaUFpY21WelpYSjJaVEVpSUNKbVlXTjBiM0o1SWlBaWEweGhjM1FpSUNKaVlXeGhibU5sVDJZaUlDSkVUMDFCU1U1ZlUwVlFRVkpCVkU5U0lpQWlZbXh2WTJ0VWFXMWxjM1JoYlhCTVlYTjBJaUFpY0hKcFkyVXdRM1Z0ZFd4aGRHbDJaVXhoYzNRaUlDSndjbWxqWlRGRGRXMTFiR0YwYVhabFRHRnpkQ0lnSW1Gc2JHOTNZVzVqWlNJZ01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1JREI0TWpnNU1UZzROakVnTUhneE5URm1OMk0zTlRnd0lEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWRHOTBZV3hUZFhCd2JIa2lDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdJa1JQVFVGSlRsOVRSVkJCVWtGVVQxSWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbVpoWTNSdmNua2lDaUFnSUNCaWVYUmxZeUEySUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luUnZhMlZ1TUNJS0lDQWdJR0o1ZEdWaklEWWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ09DQXZMeUFpZEc5clpXNHhJZ29nSUNBZ1lubDBaV01nTmlBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnlaWE5sY25abE1DSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWljbVZ6WlhKMlpURWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTVRVZ0x5OGdJbUpzYjJOclZHbHRaWE4wWVcxd1RHRnpkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTVRZZ0x5OGdJbkJ5YVdObE1FTjFiWFZzWVhScGRtVk1ZWE4wSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKd2NtbGpaVEZEZFcxMWJHRjBhWFpsVEdGemRDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWlhMHhoYzNRaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5WdWJHOWphMlZrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURoaU56TmpNMk0yT1dKaU9HWmxNMlExTVRKbFkyTTBZMlkzTlRsall6YzVNak01WmpkaU1UYzVZakJtWm1GallXRTVZVGMxWkRVeU1tSXpPVFF3TUdabFptSm1abVUyTlRZMU1tRXhORFU0TkRWak9XSmpPR1F3TlRNeU9UUTFZbVUyWWprNE16Qm1aVEZsT1RrMk5tTTRPRGRpWkRJNU9HVTFOVEZoWXpnell6ZzVaV1prWVdFMU5HTXdaakl3WXpkaFpHWTJNVEk0T0RKa1pqQTVOVEJtTldFNU5URTJNemRsTURNd04yTmtZMkkwWXpZM01tWXlPVGhpT0dKak5qQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JqYjI1allYUUtJQ0FnSUd0bFkyTmhhekkxTmdvZ0lDQWdZbmwwWldNZ01UUWdMeThnSWtSUFRVRkpUbDlUUlZCQlVrRlVUMUlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01URWdMeThnSW1aaFkzUnZjbmtpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhneE5EUXpNalk1TXlBd2VEZ3dOMkl3TkRJMElEQjRaamt6T0RJM01UWWdNSGd3WTJFMU16VmxPQ0F3ZUdabE9EQXdZVEUzSURCNE1XVmlNMkV6T1dJZ01IZzVPR1l6T1RZNE1pQXdlR1poWm1JMllUQTRJREI0TVRrNFl6azRNakFnTUhnMlpHWTBNV1kyWkNBd2VEUmhPR1JrTURobUlEQjRNemswWXpRd01XSWdNSGcyTXpFNE5EVmxNeUF3ZUdFMU1HTTVORGs1SURCNE5HSmxPR015WVRJZ01IZzVNRGRoTlRZNE1TQXdlR0V5WlRSa05ERm1JREI0TnpsbVlXSTBOalVnTUhoaVpEQmlPR1UwTmlBdkx5QnRaWFJvYjJRZ0ltZGxkRkpsYzJWeWRtVnpLQ2tvZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWx1YVhScFlXeHBlbVVvWVdSa2NtVnpjeXhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltMXBiblFvWVdSa2NtVnpjeWwxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0ppZFhKdUtHRmtaSEpsYzNNcEtIVnBiblF5TlRZc2RXbHVkREkxTmlraUxDQnRaWFJvYjJRZ0luTjNZWEFvZFdsdWRESTFOaXgxYVc1ME1qVTJMR0ZrWkhKbGMzTXNZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5OcmFXMG9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKemVXNWpLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmhjSEJ5YjNabEtHRmtaSEpsYzNNc2RXbHVkREkxTmlsaWIyOXNJaXdnYldWMGFHOWtJQ0owY21GdWMyWmxjaWhoWkdSeVpYTnpMSFZwYm5ReU5UWXBZbTl2YkNJc0lHMWxkR2h2WkNBaWRISmhibk5tWlhKR2NtOXRLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMktXSnZiMndpTENCdFpYUm9iMlFnSW5CbGNtMXBkQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblEyTkN4aWVYUmxXek15WFN4aWVYUmxXek15WFNsMmIybGtJaXdnYldWMGFHOWtJQ0ptWVdOMGIzSjVLQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0owYjJ0bGJqQW9LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJblJ2YTJWdU1TZ3BZV1JrY21WemN5SXNJRzFsZEdodlpDQWljSEpwWTJVd1EzVnRkV3hoZEdsMlpVeGhjM1FvS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW5CeWFXTmxNVU4xYlhWc1lYUnBkbVZNWVhOMEtDbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSnJUR0Z6ZENncGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaWRHOTBZV3hUZFhCd2JIa29LWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJa1JQVFVGSlRsOVRSVkJCVWtGVVQxSW9LV0o1ZEdWYk16SmRJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWjJWMFVtVnpaWEoyWlhNZ2FXNXBkR2xoYkdsNlpTQnRhVzUwSUdKMWNtNGdjM2RoY0NCemEybHRJSE41Ym1NZ1lYQndjbTkyWlNCMGNtRnVjMlpsY2lCMGNtRnVjMlpsY2taeWIyMGdjR1Z5YldsMElHWmhZM1J2Y25rZ2RHOXJaVzR3SUhSdmEyVnVNU0J3Y21salpUQkRkVzExYkdGMGFYWmxUR0Z6ZENCd2NtbGpaVEZEZFcxMWJHRjBhWFpsVEdGemRDQnJUR0Z6ZENCMGIzUmhiRk4xY0hCc2VTQkVUMDFCU1U1ZlUwVlFRVkpCVkU5U0NpQWdJQ0JsY25JS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjM1Z6YUdsemQyRndMWFl5TDJOdmJuUnlZV04wY3k5VmJtbHpkMkZ3VmpKUVlXbHlMbk52YkM1TllYUm9MbTFwYmloNE9pQmllWFJsY3l3Z2VUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncE5ZWFJvTG0xcGJqb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSThDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6ZFhOb2FYTjNZWEF0ZGpJdlkyOXVkSEpoWTNSekwxVnVhWE4zWVhCV01sQmhhWEl1YzI5c0xrMWhkR2d1YzNGeWRDaDVPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDazFoZEdndWMzRnlkRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJOENpQWdJQ0JpZWlCTllYUm9Mbk54Y25SZlpXeHpaVjlpYjJSNVFEVUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2MzZGhjQW9nSUNBZ1lpOEtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpS3dvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNZ29LVFdGMGFDNXpjWEowWDNkb2FXeGxYM1J2Y0VBeU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmlQQW9nSUNBZ1lub2dUV0YwYUM1emNYSjBYMkZtZEdWeVgybG1YMlZzYzJWQU9Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpTHdvZ0lDQWdaR2xuSURFS0lDQWdJR0lyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1lpOEtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0JpSUUxaGRHZ3VjM0Z5ZEY5M2FHbHNaVjkwYjNCQU1nb0tUV0YwYUM1emNYSjBYMkZtZEdWeVgybG1YMlZzYzJWQU9Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tUV0YwYUM1emNYSjBYMlZzYzJWZlltOWtlVUExT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpRTlDaUFnSUNCaWVpQk5ZWFJvTG5OeGNuUmZZV1owWlhKZmFXWmZaV3h6WlVBNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQmlJRTFoZEdndWMzRnlkRjloWm5SbGNsOXBabDlsYkhObFFEZ0tDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzNWemFHbHpkMkZ3TFhZeUwyTnZiblJ5WVdOMGN5OVZibWx6ZDJGd1ZqSlFZV2x5TG5OdmJDNVRZV1psVFdGMGFGVnVhWE4zWVhBdVlXUmtLSGc2SUdKNWRHVnpMQ0I1T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2xOaFptVk5ZWFJvVlc1cGMzZGhjQzVoWkdRNkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUt3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0krUFFvZ0lDQWdZWE56WlhKMElDOHZJR1J6TFcxaGRHZ3RZV1JrTFc5MlpYSm1iRzkzQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjM1Z6YUdsemQyRndMWFl5TDJOdmJuUnlZV04wY3k5VmJtbHpkMkZ3VmpKUVlXbHlMbk52YkM1VFlXWmxUV0YwYUZWdWFYTjNZWEF1YzNWaUtIZzZJR0o1ZEdWekxDQjVPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbE5oWm1WTllYUm9WVzVwYzNkaGNDNXpkV0k2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZanc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaSE10YldGMGFDMXpkV0l0ZFc1a1pYSm1iRzkzQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjM1Z6YUdsemQyRndMWFl5TDJOdmJuUnlZV04wY3k5VmJtbHpkMkZ3VmpKUVlXbHlMbk52YkM1VFlXWmxUV0YwYUZWdWFYTjNZWEF1YlhWc0tIZzZJR0o1ZEdWekxDQjVPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbE5oWm1WTllYUm9WVzVwYzNkaGNDNXRkV3c2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0k5UFFvZ0lDQWdZbTU2SUZOaFptVk5ZWFJvVlc1cGMzZGhjQzV0ZFd4ZlltOXZiRjkwY25WbFFESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpS2dvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWowOUNpQWdJQ0JpZWlCVFlXWmxUV0YwYUZWdWFYTjNZWEF1YlhWc1gySnZiMnhmWm1Gc2MyVkFNd29LVTJGbVpVMWhkR2hWYm1semQyRndMbTExYkY5aWIyOXNYM1J5ZFdWQU1qb0tJQ0FnSUdsdWRHTmZNaUF2THlBeENncFRZV1psVFdGMGFGVnVhWE4zWVhBdWJYVnNYMkp2YjJ4ZmJXVnlaMlZBTkRvS0lDQWdJR0Z6YzJWeWRDQXZMeUJrY3kxdFlYUm9MVzExYkMxdmRtVnlabXh2ZHdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lITjNZWEFLSUNBZ0lISmxkSE4xWWdvS1UyRm1aVTFoZEdoVmJtbHpkMkZ3TG0xMWJGOWliMjlzWDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQlRZV1psVFdGMGFGVnVhWE4zWVhBdWJYVnNYMkp2YjJ4ZmJXVnlaMlZBTkFvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXpkWE5vYVhOM1lYQXRkakl2WTI5dWRISmhZM1J6TDFWdWFYTjNZWEJXTWxCaGFYSXVjMjlzTGxWUk1URXllREV4TWk1bGJtTnZaR1VvZVRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwVlVURXhNbmd4TVRJdVpXNWpiMlJsT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpb0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emRYTm9hWE4zWVhBdGRqSXZZMjl1ZEhKaFkzUnpMMVZ1YVhOM1lYQldNbEJoYVhJdWMyOXNMbFZSTVRFeWVERXhNaTUxY1dScGRpaDRPaUJpZVhSbGN5d2dlVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BWVVRFeE1uZ3hNVEl1ZFhGa2FYWTZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlMd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTjFjMmhwYzNkaGNDMTJNaTlqYjI1MGNtRmpkSE12Vlc1cGMzZGhjRll5VUdGcGNpNXpiMnd1Vlc1cGMzZGhjRll5VUdGcGNpNW5aWFJTWlhObGNuWmxjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGSmxjMlZ5ZG1Wek9nb2dJQ0FnWTJGc2JITjFZaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjM1Z6YUdsemQyRndMWFl5TDJOdmJuUnlZV04wY3k5VmJtbHpkMkZ3VmpKUVlXbHlMbk52YkM1VmJtbHpkMkZ3VmpKUVlXbHlMbWRsZEZKbGMyVnlkbVZ6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pHbG5JREVLSUNBZ0lHSjhDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlmQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjM1Z6YUdsemQyRndMWFl5TDJOdmJuUnlZV04wY3k5VmJtbHpkMkZ3VmpKUVlXbHlMbk52YkM1VmJtbHpkMkZ3VmpKUVlXbHlMbWx1YVhScFlXeHBlbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGJtbDBhV0ZzYVhwbE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWlabUZqZEc5eWVTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1ptRmpkRzl5ZVNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZXNXBjM2RoY0ZZeU9pQkdUMUpDU1VSRVJVNEtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luUnZhMlZ1TUNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblJ2YTJWdU1TSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOMWMyaHBjM2RoY0MxMk1pOWpiMjUwY21GamRITXZWVzVwYzNkaGNGWXlVR0ZwY2k1emIyd3VWVzVwYzNkaGNGWXlVR0ZwY2k1dGFXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYldsdWREb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhCdUlESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5WdWJHOWphMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUIxYm14dlkydGxaQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJWYm1semQyRndWakk2SUV4UFEwdEZSQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRXNXNiMk5yWldRaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdlZXNXBjM2RoY0ZZeVVHRnBjaTV6YjJ3dVZXNXBjM2RoY0ZZeVVHRnBjaTVuWlhSU1pYTmxjblpsY3dvZ0lDQWdjRzl3YmlBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdlZXNXBjM2RoY0ZZeVVHRnBjaTV6YjJ3dVZXNXBjM2RoY0ZZeVVHRnBjaTVuWlhSU1pYTmxjblpsY3dvZ0lDQWdjRzl3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUhCdmNBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0owYjJ0bGJqQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIUnZhMlZ1TUNCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1pQXZMeUJ0WlhSb2IyUWdJbUpoYkdGdVkyVlBaaWhoWkdSeVpYTnpLWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkRzlyWlc0eElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMGIydGxiakVnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdiV1YwYUc5a0lDSmlZV3hoYm1ObFQyWW9ZV1JrY21WemN5bDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFGVnVhWE4zWVhBdWMzVmlDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFGVnVhWE4zWVhBdWMzVmlDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGOXRhVzUwUm1WbENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEc5MFlXeFRkWEJ3YkhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkRzkwWVd4VGRYQndiSGtnWlhocGMzUnpDaUFnSUNCaVBUMEtJQ0FnSUdKNklHMXBiblJmWld4elpWOWliMlI1UURFMENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbVpoWTNSdmNua2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHWmhZM1J2Y25rZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnek1HVm1aamcwSUM4dklHMWxkR2h2WkNBaWJXbG5jbUYwYjNJb0tXRmtaSEpsYzNNaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXlDaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZbm9nYldsdWRGOWxiSE5sWDJKdlpIbEFNVElLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdScFp5QXhNQW9nSUNBZ2NIVnphR2x1ZENBeU9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TlRRM016Qm1ZeUF2THlCdFpYUm9iMlFnSW1SbGMybHlaV1JNYVhGMWFXUnBkSGtvS1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TkFvZ0lDQWdaR2xuSURrS0lDQWdJR0krQ2lBZ0lDQmllaUJ0YVc1MFgySnZiMnhmWm1Gc2MyVkFNVEFLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdZbmwwWldNZ01qSWdMeThnTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JpSVQwS0lDQWdJR0o2SUcxcGJuUmZZbTl2YkY5bVlXeHpaVUF4TUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLQ20xcGJuUmZZbTl2YkY5dFpYSm5aVUF4TVRvS0lDQWdJR0Z6YzJWeWRDQXZMeUJDWVdRZ1pHVnphWEpsWkNCc2FYRjFhV1JwZEhrS0NtMXBiblJmWVdaMFpYSmZhV1pmWld4elpVQXhOVG9LSUNBZ0lHUnBaeUF4TWdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR0krQ2lBZ0lDQmhjM05sY25RZ0x5OGdWVzVwYzNkaGNGWXlPaUJKVGxOVlJrWkpRMGxGVGxSZlRFbFJWVWxFU1ZSWlgwMUpUbFJGUkFvZ0lDQWdaR2xuSURFd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRjl0YVc1MENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkdsbklEVUtJQ0FnSUdScFp5QTVDaUFnSUNCa2FXY2dPUW9nSUNBZ1kyRnNiSE4xWWlCZmRYQmtZWFJsQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbm9nYldsdWRGOWhablJsY2w5cFpsOWxiSE5sUURFM0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpY21WelpYSjJaVEFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEpsYzJWeWRtVXdJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKeVpYTmxjblpsTVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY21WelpYSjJaVEVnWlhocGMzUnpDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvVlc1cGMzZGhjQzV0ZFd3S0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKclRHRnpkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdGFXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU1UYzZDaUFnSUNCa2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSjhDaUFnSUNCa2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1pHbG5JRElLSUNBZ0lHSjhDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnME4yWmtOREUyWVNBdkx5QnRaWFJvYjJRZ0lrMXBiblFvWVdSa2NtVnpjeXgxYVc1ME1qVTJMSFZwYm5ReU5UWXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHUnBaeUF4TXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xcGJuUmZZbTl2YkY5bVlXeHpaVUF4TURvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRzFwYm5SZlltOXZiRjl0WlhKblpVQXhNUW9LYldsdWRGOWxiSE5sWDJKdlpIbEFNVEk2Q2lBZ0lDQmthV2NnTVRFS0lDQWdJR0o1ZEdWaklEWWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFMTFjM1FnYm05MElHaGhkbVVnYldsbmNtRjBiM0lLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFGVnVhWE4zWVhBdWJYVnNDaUFnSUNCallXeHNjM1ZpSUUxaGRHZ3VjM0Z5ZEFvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFGVnVhWE4zWVhBdWMzVmlDaUFnSUNCaWRYSjVJREUwQ2lBZ0lDQmllWFJsWXlBMklDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCZmJXbHVkQW9nSUNBZ1lpQnRhVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFVLQ20xcGJuUmZaV3h6WlY5aWIyUjVRREUwT2dvZ0lDQWdaR2xuSURNS0lDQWdJR1JwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2hWYm1semQyRndMbTExYkFvZ0lDQWdaR2xuSURrS0lDQWdJR0l2Q2lBZ0lDQmthV2NnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvVlc1cGMzZGhjQzV0ZFd3S0lDQWdJR1JwWnlBNENpQWdJQ0JpTHdvZ0lDQWdZMkZzYkhOMVlpQk5ZWFJvTG0xcGJnb2dJQ0FnWW5WeWVTQXhNd29nSUNBZ1lpQnRhVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFVLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMzVnphR2x6ZDJGd0xYWXlMMk52Ym5SeVlXTjBjeTlWYm1semQyRndWakpRWVdseUxuTnZiQzVWYm1semQyRndWakpRWVdseUxtSjFjbTViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaWRYSnVPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5WdWJHOWphMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUIxYm14dlkydGxaQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJWYm1semQyRndWakk2SUV4UFEwdEZSQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRXNXNiMk5yWldRaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdlZXNXBjM2RoY0ZZeVVHRnBjaTV6YjJ3dVZXNXBjM2RoY0ZZeVVHRnBjaTVuWlhSU1pYTmxjblpsY3dvZ0lDQWdjRzl3YmlBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdlZXNXBjM2RoY0ZZeVVHRnBjaTV6YjJ3dVZXNXBjM2RoY0ZZeVVHRnBjaTVuWlhSU1pYTmxjblpsY3dvZ0lDQWdjRzl3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUhCdmNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5SdmEyVnVNQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkRzlyWlc0d0lHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblJ2YTJWdU1TSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOXJaVzR4SUdWNGFYTjBjd29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTmdvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z2JXVjBhRzlrSUNKaVlXeGhibU5sVDJZb1lXUmtjbVZ6Y3lsMWFXNTBNalUySWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOZ29nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6SWdMeThnYldWMGFHOWtJQ0ppWVd4aGJtTmxUMllvWVdSa2NtVnpjeWwxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0ltSmhiR0Z1WTJWUFppSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFlLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpZV3hzYzNWaUlGOXRhVzUwUm1WbENpQWdJQ0JqYjNabGNpQTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWRHOTBZV3hUZFhCd2JIa2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIUnZkR0ZzVTNWd2NHeDVJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFGVnVhWE4zWVhBdWJYVnNDaUFnSUNCa2FXY2dNUW9nSUNBZ1lpOEtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1kyOTJaWElnTlFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvVlc1cGMzZGhjQzV0ZFd3S0lDQWdJSE4zWVhBS0lDQWdJR0l2Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpUEFvZ0lDQWdZbm9nWW5WeWJsOWliMjlzWDJaaGJITmxRRFlLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRGtLSUNBZ0lHSStDaUFnSUNCaWVpQmlkWEp1WDJKdmIyeGZabUZzYzJWQU5nb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0NtSjFjbTVmWW05dmJGOXRaWEpuWlVBM09nb2dJQ0FnWVhOelpYSjBJQzh2SUZWdWFYTjNZWEJXTWpvZ1NVNVRWVVpHU1VOSlJVNVVYMHhKVVZWSlJFbFVXVjlDVlZKT1JVUUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCa2RYQUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbUpoYkdGdVkyVlBaaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHaFZibWx6ZDJGd0xuTjFZZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5SdmRHRnNVM1Z3Y0d4NUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMGIzUmhiRk4xY0hCc2VTQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9WVzVwYzNkaGNDNXpkV0lLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2ZEdGc1UzVndjR3g1SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE5Bb2dJQ0FnWW53S0lDQWdJSE4zWVhBS0lDQWdJR0o1ZEdWaklEWWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNakFnTHk4Z2JXVjBhRzlrSUNKVWNtRnVjMlpsY2loaFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWRESTFOaWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdaR2xuSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNaUF2THlCdFpYUm9iMlFnSW1KaGJHRnVZMlZQWmloaFpHUnlaWE56S1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JrYVdjZ05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh5SUM4dklHMWxkR2h2WkNBaVltRnNZVzVqWlU5bUtHRmtaSEpsYzNNcGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdScFp5QTVDaUFnSUNCa2FXY2dPUW9nSUNBZ1kyRnNiSE4xWWlCZmRYQmtZWFJsQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbm9nWW5WeWJsOWhablJsY2w5cFpsOWxiSE5sUURFeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpY21WelpYSjJaVEFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEpsYzJWeWRtVXdJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKeVpYTmxjblpsTVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY21WelpYSjJaVEVnWlhocGMzUnpDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvVlc1cGMzZGhjQzV0ZFd3S0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKclRHRnpkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwaWRYSnVYMkZtZEdWeVgybG1YMlZzYzJWQU1URTZDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1pHbG5JREV4Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWZBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREV5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURCa09ESmpOalZpSUM4dklHMWxkR2h2WkNBaVFuVnliaWhoWkdSeVpYTnpMSFZwYm5ReU5UWXNkV2x1ZERJMU5peGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21KMWNtNWZZbTl2YkY5bVlXeHpaVUEyT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdZblZ5Ymw5aWIyOXNYMjFsY21kbFFEY0tDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzNWemFHbHpkMkZ3TFhZeUwyTnZiblJ5WVdOMGN5OVZibWx6ZDJGd1ZqSlFZV2x5TG5OdmJDNVZibWx6ZDJGd1ZqSlFZV2x5TG5OM1lYQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZDJGd09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0c0Z09Rb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaUlnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblZ1Ykc5amEyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjFibXh2WTJ0bFpDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR0k5UFFvZ0lDQWdZWE56WlhKMElDOHZJRlZ1YVhOM1lYQldNam9nVEU5RFMwVkVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjFibXh2WTJ0bFpDSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lqNEtJQ0FnSUdKdWVpQnpkMkZ3WDJKdmIyeGZkSEoxWlVBekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkdsbklERUtJQ0FnSUdJK0NpQWdJQ0JpZWlCemQyRndYMkp2YjJ4ZlptRnNjMlZBTkFvS2MzZGhjRjlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2dwemQyRndYMkp2YjJ4ZmJXVnlaMlZBTlRvS0lDQWdJR0Z6YzJWeWRDQXZMeUJWYm1semQyRndWakk2SUVsT1UxVkdSa2xEU1VWT1ZGOVBWVlJRVlZSZlFVMVBWVTVVQ2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emRYTm9hWE4zWVhBdGRqSXZZMjl1ZEhKaFkzUnpMMVZ1YVhOM1lYQldNbEJoYVhJdWMyOXNMbFZ1YVhOM1lYQldNbEJoYVhJdVoyVjBVbVZ6WlhKMlpYTUtJQ0FnSUhCdmNHNGdNZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREl3Q2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emRYTm9hWE4zWVhBdGRqSXZZMjl1ZEhKaFkzUnpMMVZ1YVhOM1lYQldNbEJoYVhJdWMyOXNMbFZ1YVhOM1lYQldNbEJoYVhJdVoyVjBVbVZ6WlhKMlpYTUtJQ0FnSUhCdmNBb2dJQ0FnWW5WeWVTQXlNQW9nSUNBZ2NHOXdDaUFnSUNCa2FXY2dPQW9nSUNBZ1lqNEtJQ0FnSUdKNklITjNZWEJmWW05dmJGOW1ZV3h6WlVBNENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkdsbklERTRDaUFnSUNCaVBBb2dJQ0FnWW5vZ2MzZGhjRjlpYjI5c1gyWmhiSE5sUURnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2dwemQyRndYMkp2YjJ4ZmJXVnlaMlZBT1RvS0lDQWdJR0Z6YzJWeWRDQXZMeUJWYm1semQyRndWakk2SUVsT1UxVkdSa2xEU1VWT1ZGOU1TVkZWU1VSSlZGa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKMGIydGxiakFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWRYSjVJREU1Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOXJaVzR3SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luUnZhMlZ1TVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCemQyRndDaUFnSUNCaWRYSjVJREU0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOXJaVzR4SUdWNGFYTjBjd29nSUNBZ1pHbG5JRFFLSUNBZ0lDRTlDaUFnSUNCaWVpQnpkMkZ3WDJKdmIyeGZabUZzYzJWQU1USUtJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNVFlLSUNBZ0lDRTlDaUFnSUNCaWVpQnpkMkZ3WDJKdmIyeGZabUZzYzJWQU1USUtJQ0FnSUdsdWRHTmZNaUF2THlBeENncHpkMkZ3WDJKdmIyeGZiV1Z5WjJWQU1UTTZDaUFnSUNCaGMzTmxjblFnTHk4Z1ZXNXBjM2RoY0ZZeU9pQkpUbFpCVEVsRVgxUlBDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVEFLSUNBZ0lHSjZJSE4zWVhCZllXWjBaWEpmYVdaZlpXeHpaVUF5TUFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXhDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWkdsbklEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRGNLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WXpabE1UUmhaallnTHk4Z2JXVjBhRzlrSUNKMWJtbHpkMkZ3VmpKRFlXeHNLR0ZrWkhKbGMzTXNkV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblE0VzEwcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2dwemQyRndYMkZtZEdWeVgybG1YMlZzYzJWQU1qQTZDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWkdsbklERTNDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdiV1YwYUc5a0lDSmlZV3hoYm1ObFQyWW9ZV1JrY21WemN5bDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1pHbG5JREUzQ2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6SWdMeThnYldWMGFHOWtJQ0ppWVd4aGJtTmxUMllvWVdSa2NtVnpjeWwxYVc1ME1qVTJJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdZblZ5ZVNBeE13b2dJQ0FnWkdsbklERTVDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlLd29nSUNBZ1pHbG5JRGtLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV6Q2lBZ0lDQmlQZ29nSUNBZ1lub2djM2RoY0Y5MFpYSnVZWEo1WDJaaGJITmxRREkwQ2lBZ0lDQmthV2NnTVRJS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJckNpQWdJQ0JrYVdjZ01URUtJQ0FnSUdJdENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWW5WeWVTQXhOUW9LYzNkaGNGOTBaWEp1WVhKNVgyMWxjbWRsUURJMU9nb2dJQ0FnWkdsbklERTNDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlLd29nSUNBZ1pHbG5JRFlLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQmthV2NnTVRJS0lDQWdJR0k4Q2lBZ0lDQmllaUJ6ZDJGd1gzUmxjbTVoY25sZlptRnNjMlZBTWpjS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdScFp5QXhNQW9nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCaWRYSjVJREUwQ2dwemQyRndYM1JsY201aGNubGZiV1Z5WjJWQU1qZzZDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlQZ29nSUNBZ1ltNTZJSE4zWVhCZlltOXZiRjkwY25WbFFETXdDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlQZ29nSUNBZ1lub2djM2RoY0Y5aWIyOXNYMlpoYkhObFFETXhDZ3B6ZDJGd1gySnZiMnhmZEhKMVpVQXpNRG9LSUNBZ0lHbHVkR05mTWlBdkx5QXhDZ3B6ZDJGd1gySnZiMnhmYldWeVoyVkFNekk2Q2lBZ0lDQmhjM05sY25RZ0x5OGdWVzVwYzNkaGNGWXlPaUJKVGxOVlJrWkpRMGxGVGxSZlNVNVFWVlJmUVUxUFZVNVVDaUFnSUNCd2RYTm9hVzUwSURFd01EQUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXhNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFGVnVhWE4zWVhBdWJYVnNDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUZWdWFYTjNZWEF1YlhWc0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdoVmJtbHpkMkZ3TG5OMVlnb2dJQ0FnWkdsbklERTJDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhRlZ1YVhOM1lYQXViWFZzQ2lBZ0lDQmthV2NnTVRrS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ053b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb1ZXNXBjM2RoY0M1dGRXd0tJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2hWYm1semQyRndMbk4xWWdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFGVnVhWE4zWVhBdWJYVnNDaUFnSUNCa2FXY2dNak1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaR2xuSURJMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2hWYm1semQyRndMbTExYkFvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3TURBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9WVzVwYzNkaGNDNXRkV3dLSUNBZ0lHSStQUW9nSUNBZ1lYTnpaWEowSUM4dklGVnVhWE4zWVhCV01qb2dTd29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpZV3hzYzNWaUlGOTFjR1JoZEdVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JpZkFvZ0lDQWdaR2xuSURrS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWkdsbklERXdDaUFnSUNCa2FXY2dNZ29nSUNBZ1lud0tJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JrYVdjZ013b2dJQ0FnWW53S0lDQWdJR1JwWnlBNENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdScFp5QTVDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR0o4Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VESmtNbUZtWVdZNElDOHZJRzFsZEdodlpDQWlVM2RoY0NoaFpHUnlaWE56TEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNZV1JrY21WemN5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ1lubDBaV05mTVNBdkx5QWlkVzVzYjJOclpXUWlDaUFnSUNCa2FXY2dNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25OM1lYQmZZbTl2YkY5bVlXeHpaVUF6TVRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJSE4zWVhCZlltOXZiRjl0WlhKblpVQXpNZ29LYzNkaGNGOTBaWEp1WVhKNVgyWmhiSE5sUURJM09nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTBDaUFnSUNCaUlITjNZWEJmZEdWeWJtRnllVjl0WlhKblpVQXlPQW9LYzNkaGNGOTBaWEp1WVhKNVgyWmhiSE5sUURJME9nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTFDaUFnSUNCaUlITjNZWEJmZEdWeWJtRnllVjl0WlhKblpVQXlOUW9LYzNkaGNGOWliMjlzWDJaaGJITmxRREV5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdjM2RoY0Y5aWIyOXNYMjFsY21kbFFERXpDZ3B6ZDJGd1gySnZiMnhmWm1Gc2MyVkFPRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlITjNZWEJmWW05dmJGOXRaWEpuWlVBNUNncHpkMkZ3WDJKdmIyeGZabUZzYzJWQU5Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUhOM1lYQmZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTjFjMmhwYzNkaGNDMTJNaTlqYjI1MGNtRmpkSE12Vlc1cGMzZGhjRll5VUdGcGNpNXpiMnd1Vlc1cGMzZGhjRll5VUdGcGNpNXphMmx0VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MydHBiVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjFibXh2WTJ0bFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RXNXNiMk5yWldRZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2FYUnZZZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGVnVhWE4zWVhCV01qb2dURTlEUzBWRUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZFc1c2IyTnJaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblJ2YTJWdU1DSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOXJaVzR3SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luUnZhMlZ1TVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnZEc5clpXNHhJR1Y0YVhOMGN3b2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eUlDOHZJRzFsZEdodlpDQWlZbUZzWVc1alpVOW1LR0ZrWkhKbGMzTXBkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0p5WlhObGNuWmxNQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ5WlhObGNuWmxNQ0JsZUdsemRITUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z2JXVjBhRzlrSUNKaVlXeGhibU5sVDJZb1lXUmtjbVZ6Y3lsMWFXNTBNalUySWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSnlaWE5sY25abE1TSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnlaWE5sY25abE1TQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5WdWJHOWphMlZrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjM1Z6YUdsemQyRndMWFl5TDJOdmJuUnlZV04wY3k5VmJtbHpkMkZ3VmpKUVlXbHlMbk52YkM1VmJtbHpkMkZ3VmpKUVlXbHlMbk41Ym1OYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHplVzVqT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblZ1Ykc5amEyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjFibXh2WTJ0bFpDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZajA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWVzVwYzNkaGNGWXlPaUJNVDBOTFJVUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMWJteHZZMnRsWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblJ2YTJWdU1DSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOXJaVzR3SUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eUlDOHZJRzFsZEdodlpDQWlZbUZzWVc1alpVOW1LR0ZrWkhKbGMzTXBkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkRzlyWlc0eElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMGIydGxiakVnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdiV1YwYUc5a0lDSmlZV3hoYm1ObFQyWW9ZV1JrY21WemN5bDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5KbGMyVnlkbVV3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ5WlhObGNuWmxNQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaWNtVnpaWEoyWlRFaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhKbGMyVnlkbVV4SUdWNGFYTjBjd29nSUNBZ1kyRnNiSE4xWWlCZmRYQmtZWFJsQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0oxYm14dlkydGxaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTjFjMmhwYzNkaGNDMTJNaTlqYjI1MGNtRmpkSE12Vlc1cGMzZGhjRll5VUdGcGNpNXpiMnd1Vlc1cGMzZGhjRll5VUdGcGNpNWhjSEJ5YjNabFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZWEJ3Y205MlpUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlGOWhjSEJ5YjNabENpQWdJQ0JpZVhSbFl5QXlNU0F2THlBd2VERTFNV1kzWXpjMU9EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6ZFhOb2FYTjNZWEF0ZGpJdlkyOXVkSEpoWTNSekwxVnVhWE4zWVhCV01sQmhhWEl1YzI5c0xsVnVhWE4zWVhCV01sQmhhWEl1ZEhKaGJuTm1aWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMGNtRnVjMlpsY2pvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUY5MGNtRnVjMlpsY2dvZ0lDQWdZbmwwWldNZ01qRWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjM1Z6YUdsemQyRndMWFl5TDJOdmJuUnlZV04wY3k5VmJtbHpkMkZ3VmpKUVlXbHlMbk52YkM1VmJtbHpkMkZ3VmpKUVlXbHlMblJ5WVc1elptVnlSbkp2YlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUnlZVzV6Wm1WeVJuSnZiVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhPQ0F2THlBaVlXeHNiM2RoYm1ObElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdKNWRHVmpJREl5SUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1lpRTlDaUFnSUNCaWVpQjBjbUZ1YzJabGNrWnliMjFmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhPQ0F2THlBaVlXeHNiM2RoYm1ObElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdScFp5QXlDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvVlc1cGMzZGhjQzV6ZFdJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURFNElDOHZJQ0poYkd4dmQyRnVZMlVpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDZ3AwY21GdWMyWmxja1p5YjIxZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTJGc2JITjFZaUJmZEhKaGJuTm1aWElLSUNBZ0lHSjVkR1ZqSURJeElDOHZJREI0TVRVeFpqZGpOelU0TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTjFjMmhwYzNkaGNDMTJNaTlqYjI1MGNtRmpkSE12Vlc1cGMzZGhjRll5VUdGcGNpNXpiMnd1Vlc1cGMzZGhjRll5VUdGcGNpNXdaWEp0YVhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdaWEp0YVhRNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEzQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmlQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlZibWx6ZDJGd1ZqSTZJRVZZVUVsU1JVUUtJQ0FnSUdScFp5QTJDaUFnSUNCemFHRXlOVFlLSUNBZ0lIQjFjMmhpZVhSbGN5QWlibTl1WTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ERUtJQ0FnSUdJckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0pFVDAxQlNVNWZVMFZRUVZKQlZFOVNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkVUMDFCU1U1ZlUwVlFRVkpCVkU5U0lHVjRhWE4wY3dvZ0lDQWdaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pjZURFNVhIZ3dNU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Tm1VM01XVmtZV1V4TW1JeFlqazNaalJrTVdZMk1ETTNNR1psWmpFd01UQTFabUV5Wm1GaFpUQXhNall4TVRSaE1UWTVZelkwT0RRMVpEWXhNalpqT1FvZ0lDQWdkVzVqYjNabGNpQXhNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhMlZqWTJGck1qVTJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JyWldOallXc3lOVFlLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnY0hWemFHbHVkQ0F5TndvZ0lDQWdMUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHVmpaSE5oWDNCclgzSmxZMjkyWlhJZ1UyVmpjREkxTm1zeENpQWdJQ0J3ZFhOb2FXNTBJREV5Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCclpXTmpZV3N5TlRZS0lDQWdJR1Y0ZEhKaFkzUWdNVElnTWpBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdJVDBLSUNBZ0lHSjZJSEJsY20xcGRGOWliMjlzWDJaaGJITmxRRFFLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFFLSUNBZ0lEMDlDaUFnSUNCaWVpQndaWEp0YVhSZlltOXZiRjltWVd4elpVQTBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb0tjR1Z5YldsMFgySnZiMnhmYldWeVoyVkFOVG9LSUNBZ0lHRnpjMlZ5ZENBdkx5QlZibWx6ZDJGd1ZqSTZJRWxPVmtGTVNVUmZVMGxIVGtGVVZWSkZDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpZV3hzYzNWaUlGOWhjSEJ5YjNabENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHdaWEp0YVhSZlltOXZiRjltWVd4elpVQTBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2NHVnliV2wwWDJKdmIyeGZiV1Z5WjJWQU5Rb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6ZFhOb2FYTjNZWEF0ZGpJdlkyOXVkSEpoWTNSekwxVnVhWE4zWVhCV01sQmhhWEl1YzI5c0xsVnVhWE4zWVhCV01sQmhhWEl1Wm1GamRHOXllVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21aaFkzUnZjbms2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbVpoWTNSdmNua2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHWmhZM1J2Y25rZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTjFjMmhwYzNkaGNDMTJNaTlqYjI1MGNtRmpkSE12Vlc1cGMzZGhjRll5VUdGcGNpNXpiMnd1Vlc1cGMzZGhjRll5VUdGcGNpNTBiMnRsYmpCYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBiMnRsYmpBNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ055QXZMeUFpZEc5clpXNHdJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjBiMnRsYmpBZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTjFjMmhwYzNkaGNDMTJNaTlqYjI1MGNtRmpkSE12Vlc1cGMzZGhjRll5VUdGcGNpNXpiMnd1Vlc1cGMzZGhjRll5VUdGcGNpNTBiMnRsYmpGYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBiMnRsYmpFNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09DQXZMeUFpZEc5clpXNHhJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjBiMnRsYmpFZ1pYaHBjM1J6Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTjFjMmhwYzNkaGNDMTJNaTlqYjI1MGNtRmpkSE12Vlc1cGMzZGhjRll5VUdGcGNpNXpiMnd1Vlc1cGMzZGhjRll5VUdGcGNpNXdjbWxqWlRCRGRXMTFiR0YwYVhabFRHRnpkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25CeWFXTmxNRU4xYlhWc1lYUnBkbVZNWVhOME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERTJJQzh2SUNKd2NtbGpaVEJEZFcxMWJHRjBhWFpsVEdGemRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2NISnBZMlV3UTNWdGRXeGhkR2wyWlV4aGMzUWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXpkWE5vYVhOM1lYQXRkakl2WTI5dWRISmhZM1J6TDFWdWFYTjNZWEJXTWxCaGFYSXVjMjlzTGxWdWFYTjNZWEJXTWxCaGFYSXVjSEpwWTJVeFEzVnRkV3hoZEdsMlpVeGhjM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwd2NtbGpaVEZEZFcxMWJHRjBhWFpsVEdGemREb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhOeUF2THlBaWNISnBZMlV4UTNWdGRXeGhkR2wyWlV4aGMzUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIQnlhV05sTVVOMWJYVnNZWFJwZG1WTVlYTjBJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjM1Z6YUdsemQyRndMWFl5TDJOdmJuUnlZV04wY3k5VmJtbHpkMkZ3VmpKUVlXbHlMbk52YkM1VmJtbHpkMkZ3VmpKUVlXbHlMbXRNWVhOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thMHhoYzNRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01USWdMeThnSW10TVlYTjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnJUR0Z6ZENCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOMWMyaHBjM2RoY0MxMk1pOWpiMjUwY21GamRITXZWVzVwYzNkaGNGWXlVR0ZwY2k1emIyd3VWVzVwYzNkaGNGWXlVR0ZwY2k1MGIzUmhiRk4xY0hCc2VWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJ2ZEdGc1UzVndjR3g1T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2ZEdGc1UzVndjR3g1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUIwYjNSaGJGTjFjSEJzZVNCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOMWMyaHBjM2RoY0MxMk1pOWpiMjUwY21GamRITXZWVzVwYzNkaGNGWXlVR0ZwY2k1emIyd3VWVzVwYzNkaGNGWXlVR0ZwY2k1RVQwMUJTVTVmVTBWUVFWSkJWRTlTVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1JFOU5RVWxPWDFORlVFRlNRVlJQVWpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE5DQXZMeUFpUkU5TlFVbE9YMU5GVUVGU1FWUlBVaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSRTlOUVVsT1gxTkZVRUZTUVZSUFVpQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjM1Z6YUdsemQyRndMWFl5TDJOdmJuUnlZV04wY3k5VmJtbHpkMkZ3VmpKUVlXbHlMbk52YkM1VmJtbHpkMkZ3VmpKUVlXbHlMbWRsZEZKbGMyVnlkbVZ6S0NrZ0xUNGdZbmwwWlhNc0lHSjVkR1Z6TENCMWFXNTBOalE2Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6ZFhOb2FYTjNZWEF0ZGpJdlkyOXVkSEpoWTNSekwxVnVhWE4zWVhCV01sQmhhWEl1YzI5c0xsVnVhWE4zWVhCV01sQmhhWEl1WjJWMFVtVnpaWEoyWlhNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpY21WelpYSjJaVEFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEpsYzJWeWRtVXdJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKeVpYTmxjblpsTVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY21WelpYSjJaVEVnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0ltSnNiMk5yVkdsdFpYTjBZVzF3VEdGemRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1lteHZZMnRVYVcxbGMzUmhiWEJNWVhOMElHVjRhWE4wY3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdlZXNXBjM2RoY0ZZeVVHRnBjaTV6YjJ3dVZXNXBjM2RoY0ZZeVVHRnBjaTVmZFhCa1lYUmxLR0poYkdGdVkyVXdPaUJpZVhSbGN5d2dZbUZzWVc1alpURTZJR0o1ZEdWekxDQmZjbVZ6WlhKMlpUQTZJR0o1ZEdWekxDQmZjbVZ6WlhKMlpURTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGZkWEJrWVhSbE9nb2dJQ0FnY0hKdmRHOGdOQ0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlJZ29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdKNWRHVmpJREU1SUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1lqdzlDaUFnSUNCaWVpQmZkWEJrWVhSbFgySnZiMnhmWm1Gc2MyVkFNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlLSUNBZ0lHSThQUW9nSUNBZ1lub2dYM1Z3WkdGMFpWOWliMjlzWDJaaGJITmxRRE1LSUNBZ0lHbHVkR05mTWlBdkx5QXhDZ3BmZFhCa1lYUmxYMkp2YjJ4ZmJXVnlaMlZBTkRvS0lDQWdJR0Z6YzJWeWRDQXZMeUJWYm1semQyRndWakk2SUU5V1JWSkdURTlYQ2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUdKNlpYSnZDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9hVzUwSURReU9UUTVOamN5T1RZS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JpSlFvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlKUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhOU0F2THlBaVlteHZZMnRVYVcxbGMzUmhiWEJNWVhOMElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCaWJHOWphMVJwYldWemRHRnRjRXhoYzNRZ1pYaHBjM1J6Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnWW5vZ1gzVndaR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRRGdLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpSVQwS0lDQWdJR0o2SUY5MWNHUmhkR1ZmWVdaMFpYSmZhV1pmWld4elpVQTRDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpSVQwS0lDQWdJR0o2SUY5MWNHUmhkR1ZmWVdaMFpYSmZhV1pmWld4elpVQTRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z0luQnlhV05sTUVOMWJYVnNZWFJwZG1WTVlYTjBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QndjbWxqWlRCRGRXMTFiR0YwYVhabFRHRnpkQ0JsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJWVVRFeE1uZ3hNVEl1Wlc1amIyUmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOaGJHeHpkV0lnVlZFeE1USjRNVEV5TG5WeFpHbDJDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdJcUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWljSEpwWTJVd1EzVnRkV3hoZEdsMlpVeGhjM1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJQ0p3Y21salpURkRkVzExYkdGMGFYWmxUR0Z6ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY0hKcFkyVXhRM1Z0ZFd4aGRHbDJaVXhoYzNRZ1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTmhiR3h6ZFdJZ1ZWRXhNVEo0TVRFeUxtVnVZMjlrWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGVlJNVEV5ZURFeE1pNTFjV1JwZGdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaUtnb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKd2NtbGpaVEZEZFcxMWJHRjBhWFpsVEdGemRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3BmZFhCa1lYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU9Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWW5sMFpXTWdNVGtnTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCaUpnb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWNtVnpaWEoyWlRBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JpZVhSbFl5QXhPU0F2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaWNtVnpaWEoyWlRFaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z0ltSnNiMk5yVkdsdFpYTjBZVzF3VEdGemRDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW5KbGMyVnlkbVV3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ5WlhObGNuWmxNQ0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCaWZBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKeVpYTmxjblpsTVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY21WelpYSjJaVEVnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVMU1tRmtOR0V3SUM4dklHMWxkR2h2WkNBaVUzbHVZeWgxYVc1ME1qVTJMSFZwYm5ReU5UWXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lISmxkSE4xWWdvS1gzVndaR0YwWlY5aWIyOXNYMlpoYkhObFFETTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCZmRYQmtZWFJsWDJKdmIyeGZiV1Z5WjJWQU5Bb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6ZFhOb2FYTjNZWEF0ZGpJdlkyOXVkSEpoWTNSekwxVnVhWE4zWVhCV01sQmhhWEl1YzI5c0xsVnVhWE4zWVhCV01sQmhhWEl1WDIxcGJuUkdaV1VvWDNKbGMyVnlkbVV3T2lCaWVYUmxjeXdnWDNKbGMyVnlkbVV4T2lCaWVYUmxjeWtnTFQ0Z2RXbHVkRFkwT2dwZmJXbHVkRVpsWlRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNHNGdOQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKbVlXTjBiM0o1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJtWVdOMGIzSjVJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzVNek15TVdObU15QXZMeUJ0WlhSb2IyUWdJbVpsWlZSdktDbGhaR1J5WlhOeklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWaklEWWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQWhQUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0ltdE1ZWE4wSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCclRHRnpkQ0JsZUdsemRITUtJQ0FnSUdKNklGOXRhVzUwUm1WbFgyVnNjMlZmWW05a2VVQTVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR1p5WVcxbFgyUnBaeUEzQ2lBZ0lDQmlJVDBLSUNBZ0lHSjZJRjl0YVc1MFJtVmxYMkZtZEdWeVgybG1YMlZzYzJWQU1USUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9WVzVwYzNkaGNDNXRkV3dLSUNBZ0lHTmhiR3h6ZFdJZ1RXRjBhQzV6Y1hKMENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTXdvZ0lDQWdabkpoYldWZlpHbG5JRGNLSUNBZ0lHTmhiR3h6ZFdJZ1RXRjBhQzV6Y1hKMENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTkFvZ0lDQWdZajRLSUNBZ0lHSjZJRjl0YVc1MFJtVmxYMkZtZEdWeVgybG1YMlZzYzJWQU1USUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIzUmhiRk4xY0hCc2VTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOTBZV3hUZFhCd2JIa2daWGhwYzNSekNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9WVzVwYzNkaGNDNXpkV0lLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdoVmJtbHpkMkZ3TG0xMWJBb2dJQ0FnY0hWemFHbHVkQ0ExQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2hWYm1semQyRndMbTExYkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvVlc1cGMzZGhjQzVoWkdRS0lDQWdJR0l2Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdJK0NpQWdJQ0JpZWlCZmJXbHVkRVpsWlY5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdOaGJHeHpkV0lnWDIxcGJuUUtDbDl0YVc1MFJtVmxYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNCbWNtRnRaVjlrYVdjZ05nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDbDl0YVc1MFJtVmxYMlZzYzJWZlltOWtlVUE1T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ053b2dJQ0FnWWlFOUNpQWdJQ0JpZWlCZmJXbHVkRVpsWlY5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpYTB4aGMzUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdJZ1gyMXBiblJHWldWZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXpkWE5vYVhOM1lYQXRkakl2WTI5dWRISmhZM1J6TDFWdWFYTjNZWEJXTWxCaGFYSXVjMjlzTGxWdWFYTjNZWEJXTWxCaGFYSXVYMjFwYm5Rb2RHODZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q2w5dGFXNTBPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEc5MFlXeFRkWEJ3YkhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhSdmRHRnNVM1Z3Y0d4NUlHVjRhWE4wY3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb1ZXNXBjM2RoY0M1aFpHUUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUnZkR0ZzVTNWd2NHeDVJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE15QXZMeUFpWW1Gc1lXNWpaVTltSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb1ZXNXBjM2RoY0M1aFpHUUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdZV1JrY2lCQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCV1RWSVJrdFJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeU1DQXZMeUJ0WlhSb2IyUWdJbFJ5WVc1elptVnlLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMktTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMzVnphR2x6ZDJGd0xYWXlMMk52Ym5SeVlXTjBjeTlWYm1semQyRndWakpRWVdseUxuTnZiQzVWYm1semQyRndWakpRWVdseUxsOWhjSEJ5YjNabEtHOTNibVZ5T2lCaWVYUmxjeXdnYzNCbGJtUmxjam9nWW5sMFpYTXNJSFpoYkhWbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1gyRndjSEp2ZG1VNkNpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE9DQXZMeUFpWVd4c2IzZGhibU5sSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKOENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTRaVEE1TkRZeElDOHZJRzFsZEdodlpDQWlRWEJ3Y205MllXd29ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emRYTm9hWE4zWVhBdGRqSXZZMjl1ZEhKaFkzUnpMMVZ1YVhOM1lYQldNbEJoYVhJdWMyOXNMbFZ1YVhOM1lYQldNbEJoYVhJdVgzUnlZVzV6Wm1WeUtHWnliMjA2SUdKNWRHVnpMQ0IwYnpvZ1lubDBaWE1zSUhaaGJIVmxPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tYM1J5WVc1elptVnlPZ29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0ltSmhiR0Z1WTJWUFppSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhRlZ1YVhOM1lYQXVjM1ZpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbUpoYkdGdVkyVlBaaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUZWdWFYTjNZWEF1WVdSa0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURJd0lDOHZJRzFsZEdodlpDQWlWSEpoYm5ObVpYSW9ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjM1Z6YUdsemQyRndMWFl5TDJOdmJuUnlZV04wY3k5VmJtbHpkMkZ3VmpKUVlXbHlMbk52YkM1VmJtbHpkMkZ3VmpKUVlXbHlMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFDQUJCaVlYQUFoMWJteHZZMnRsWkFTRHV0Zk1CQlVmZkhVaEFRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQzNSdmRHRnNVM1Z3Y0d4NUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQm5SdmEyVnVNQVowYjJ0bGJqRUljbVZ6WlhKMlpUQUljbVZ6WlhKMlpURUhabUZqZEc5eWVRVnJUR0Z6ZEFsaVlXeGhibU5sVDJZUVJFOU5RVWxPWDFORlVFRlNRVlJQVWhKaWJHOWphMVJwYldWemRHRnRjRXhoYzNRVWNISnBZMlV3UTNWdGRXeGhkR2wyWlV4aGMzUVVjSEpwWTJVeFEzVnRkV3hoZEdsMlpVeGhjM1FKWVd4c2IzZGhibU5sRHYvLy8vLy8vLy8vLy8vLy8vLy9CQ2lSaUdFRkZSOThkWUFnLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vOHhHRUFBclNjRktHY25EaWhuSndzbkJtY25CeWNHWnljSUp3Wm5Kd2tvWnljS0tHY25EeUpuSnhBb1p5Y1JLR2NuRENobkpCWXBUR2VBYUl0enc4YWJ1UDQ5VVM3TVRQZFp6SGtqbjNzWG13LzZ5cW1uWFZJck9VQVA3Ny8rWldVcUZGaEZ5YnlOQlRLVVcrYTVndy9oNlpac2lIdlNtT1ZScklQSW52MnFWTUR5REhyZllTaUMzd2xROWFsUlkzNERCODNMVEdjdktZdUx4Z0FBQUFBQUFBQUFNZ3BRQWljT1RHY25DekVBWnlSRE1Sa1VSREVZUklJVEJCUkRKcE1FZ0hzRUpBVDVPQ2NXQkF5bE5lZ0Uvb0FLRndRZXM2T2JCSmp6bG9JRSt2dHFDQVFaakpnZ0JHMzBIMjBFU28zUWp3UTVURUFiQkdNWVJlTUVwUXlVbVFSTDZNS2lCSkI2Vm9FRW91VFVId1I1K3JSbEJMMExqa1kyR2dDT0V3RE9BUE1CRndLNUJEb0dmUWJpQjBZSFlnZCtCK01JMUFqZkNPb0k5UWtJQ1JzSkxnbEJBSW9DQVl2K2kvK2tpLytML2s4Q1RZbUtBUUVpU1NpQkF4YUwvNlJCQURXQkFoWkpqQUNMLzB5aUpCYWdqQUdMLzR3Q2l3R0xBcVJCQUJXTC80c0JTVTRDb2tzQm9Jc0Fvb3dCakFKQy8rT0xBb3dBaVNJV2kvK3BRZi96SkJhTUFrTC83SW9DQVl2K2kvK2dTWXYrcDBTSmlnSUJpLzRuQktDTC82RW5CS3BKaS82bVJJbUtBZ0VvSWhhTC82aEFBQkdML292L28wbU1BSXYvb292K3FFRUFCaVJFaXdCTWlTSkMvL2VLQVFHTC80QVBBUUFBQUFBQUFBQUFBQUFBQUFBQW80bUtBZ0dML292L29vbUlDSHRMQWhVakRrUWpyMDhEU3dHclN3TVZJdzVFVHdOUEFxdFFUQlpRSzB4UXNDUkROaG9CU1JVakVrUTJHZ0pKRlNNU1JERUFJaWNMWlVRU1JDY0hUd0puSndoTVp5UkRJa2NDTmhvQlNSVWpFa1FpS1dWRUpCYW9SQ0lXU1NsTEFXZUlDQmhHQWtsT0FvZ0lFRWhKVGdOT0JFaXhNZ29pSndkbFJJRVlXeVd5RUNLeUdTS3lBYklZS3JJYXNocXp0RDVYQkFCSlRnU3hNZ29pSndobFJJRVlXeVd5RUNLeUdTS3lBYklZS3JJYXNocXp0RDVYQkFCSlRnVk1Td0tJL3VGT0JFc0NpUDdhVGdOTWlBaVRUQ0luQldWTVNVNENUZ05FcUVFQTdMRWlKd3RsUklFWVd5V3lFQ0t5R1NLeUFiSVlnQVNERHYrRXNocXp0RDVKUlF4WEJBQkpSUTB4QUJKQkFKbXhTd3FCSEZzbHNoQWlzaGtpc2dHeUdJQUVCVWN3L0xJYXM3UStWd1FBU1VVT1N3bWxRUUJ0U3d3bkZxbEJBR1VrUkVzTVNVc0twVVJMQ2t5SUNMNUxCVXNGU3dsTENZZ0hOa3NCUVFBUklpY0paVVFpSndwbFJJaitUaWNNVEdkTEEwa1ZJdzVFSTY5TVN3R3JTd1JKRlNNT1JFc0NxekVBVHdKUVRGQ0FCRWY5UVdwTVVMQkxEVWtWSXc1RXF5dE1VTEFrUXlKQy81aExDeWNHRWtSTEEwc0RpUDRFaVAyTWdlZ0hGa3hMQVlqOTQwVU9Kd1pNaUFoQ1F2OTBTd05MQVVsT0Fvajk0a3NKb2tzRVR3S0kvZGhMQ0tLSS9VMUZEVUwvVlNJMkdnRkpGU01TUkNJcFpVUWtGcWhFSWhaSktVc0JaNGdHZUVZQ1NVNENpQVp3U0VsT0FrNEVTQ0luQjJWRUlpY0laVVN4TWdwUEFvRVlXMGxPQmlXeUVDS3lHU0t5QWJJWUtySWFzaHF6dEQ1WEJBQ3hNZ3BQQW9FWVcwbE9CaVd5RUNLeUdTS3lBYklZS3JJYXNocXp0RDVYQkFBeUNnRW5EVXhRdmloT0FrMUpUZ1pQQkU4RWlBYnNUZ1FpSndWbFJFc0JUd1NJL1ROTEFhSkpUZ05PQlV4UEE0ajlKVXlpVGdLa1FRRE5TVXNKcFVFQXhpUkVNZ3BKQVNjTlRGQkp2aWhPQWsxTEJrbE9BNGo4NmtzQnZFaS9JaWNGWlVSTEFZajgyeWNGVEdkSkZTTU9SQ092U1VVT3Ewd25CbEJNVUNjVVRGQ3dzVElLSmJJUUlySVpJcklCU3dheUdDcXlHcklhczdRK1Z3UUFzVElLSmJJUUlySVpJcklCU3dheUdDcXlHcklhczdRK1Z3UUFTd2xMQ1lnRmJrc0NRUUFSSWljSlpVUWlKd3BsUklqOGhpY01UR2RMQVVrVkl3NUVTd3RKVGdLclN3SkpGU01PUkU4Q3F6RUFTd0pRU3dGUVN3eFFnQVFOZ3NaYlRGQ3dVQ3RNVUxBa1F5SkMvemNpUndrb05ob0JSd0lWU1U0Q0l4SkVOaG9DU1U0Q0ZVbE9BaU1TUkRZYUEwbE9BaFVqRWtRMkdnUkpJbG1CQWdoTEFSVVNSRmNDQUV3aUtXVkVKQlpKVGdPb1JDSVdTVTRDS1VzQlo2VkFBQWhMQlVzQnBVRUI1aVJFaUFTMFJnSkpSUlNJQkt4SVJSUklTd2lsUVFITFN3VkxFcVJCQWNNa1JDSW5CMlZNU1U0Q1JSTkVJaWNJWlV4RkVrUkxCQk5CQWFSTEEwc1FFMEVCbkNSRVN3SVZTVVVLUVFCSXNURUFJNjlKU3dwUVNSVWpDU05ZVEVzSVVFa1ZJd2tqV0VzTEZsY0dBa3NHVUVzSGdSaGJKYklRSXJJWklySUJzaGlBQk1iaFN2YXlHazhEc2hwUEFySWFUTElhc2hxenNUSUtTeEdCR0ZzbHNoQWlzaGtpc2dHeUdDcXlHcklhczdRK1Z3UUFTVVVPc1RJS1N4R0JHRnNsc2hBaXNoa2lzZ0d5R0NxeUdySWFzN1ErVndRQVJRMUxFeWNFb0VzSm9TY0Vxa2xGRGFWQkFQQkxEQ2NFb0VzTG9TY0Vxa1VQU3hFbkJLQkxCcUVuQktwSlJRdExES1JCQU1sTEN5Y0VvRXNLb1NjRXFrVU9TdzVMQWFWQUFBaExEVXNCcFVFQXFDUkVnZWdIRmtzTlNVNENTd0dJK3IyQkF4WkxFa2xPQkVzQmlQcXdUd0pNaVBxV1N4QkpUZ1JQQTRqNm9Fc1RTVTRIVHdPSStwYUkrbitJK3BCTEYwbE9Ba3NZU1U0RWlQcURnY0NFUFJhSStudW5SRThFVHdOUEFrOERpQU5FU1JVakRrUWpyMHhMQWF0TENTTU9SRXNLU3dLclN3TVZJdzVFVHdOTEE2dExDQ01PUkVzSlR3U3JNUUJQQkZCUEFsQlBBbEJNVUVzRVVJQUVMU3I2K0V4UXNDbExBbWNrUXlKQy8xVkpSUTVDL3o1SlJROUMveGNpUXY1aElrTCtPaUpDL2hjMkdnRVZJeEpFSWlsbFJDUVdURXNCcUVRaUZpbE1aeUluQjJWRUlpY0laVVN4TWdwUEFvRVlXeVd5RUNLeUdTS3lBYklZS3JJYXNocXpJaWNKWlVVQlJMRXlDa3lCR0ZzbHNoQWlzaGtpc2dHeUdDcXlHcklhc3lJbkNtVkZBVVFwVEdja1F5SXBaVVFrRmt4TEFhaEVJaFlwVEdleE1nb2lKd2RsUklFWVd5V3lFQ0t5R1NLeUFiSVlLcklhc2hxenNUSUtJaWNJWlVTQkdGc2xzaEFpc2hraXNnR3lHQ3F5R3JJYXM3UStWd1FBdEQ1WEJBQWlKd2xsUkNJbkNtVkVpQUliS1V4bkpFTTJHZ0ZKRlNNU1JEWWFBa2tWSXhKRU1RQk9Bb2dEdkNjVnNDUkROaG9CU1JVakVrUTJHZ0pKRlNNU1JERUFUZ0tJQThvbkZiQWtRellhQVVjQ0ZTTVNSRFlhQWtsT0FoVWpFa1EyR2dOSlRnSVZJeEpFTVFCUUFTY1NURkMrS0U0Q1RTY1dxVUVBSnpFQVN3TkpUd0pRQVNjU1RGQytLRTRDVFVzQ2lQaXRNUUJQQWt4UUFTY1NURkJKdkVoTXYwc0NTd0pMQW9nRFpTY1ZzQ1JETmhvQlJ3SVZJeEpFTmhvQ1NVNENTUlVqRWtRMkdnTkpUZ05KRlNNU1JEWWFCRWtWSXhKRU5ob0ZTUldCQ0JKRUZ6WWFCa2tWSXhKRU5ob0hTUlVqRWtReUJ4WkxCS1pFU3dZQmdBWnViMjVqWlhOTVVFbStLRTRDVFlBQkFhQkxBYnhJVEVzQnZ5T3ZJaWNPWlVSTEFVeFFTUlVqQ1NOWWdBSVpBVXhRZ0NCdWNlMnVFckc1ZjAwZllEY1A3eEFRWDZMNnJnRW1FVW9XbkdTRVhXRW15VThLVUU4SlVFOElVRThEVUU4R1VBSlBBa3hRU1JVakNTTllVQUpQQTRFYkNVOERUd01IQUlFTXIwNENVQUpYREJSUVNTY0dFMEVBRkVsTEJCSkJBQTBrUkVzRFN3TkxBNGdDU3lSRElrTC84Q0luQzJWRUsweFFzQ1JESWljSFpVUXJURkN3SkVNaUp3aGxSQ3RNVUxBa1F5SW5FR1ZFU1JVakRrUWpyNnNyVEZDd0pFTWlKeEZsUkVrVkl3NUVJNitySzB4UXNDUkRJaWNNWlVSSkZTTU9SQ092cXl0TVVMQWtReUluQldWRVNSVWpEa1FqcjZzclRGQ3dKRU1pSnc1bFJDdE1VTEFrUXlJbkNXVkVJaWNLWlVRaUp3OWxSSW1LQkFBaUtFbUwvQ2NUcGtFQXc0djlKeE9tUVFDN0pFU0JDSzh5QnhhQmdJQ0FnQkFXVEVzQnFrc0NURkF5QnhaUEFxcFBBa3hRRllFSUNWdEpqQUVpSnc5bFJBbEpqQUpCQUVjaUZrbU1BSXYrcVVFQVBJdi9pd0NwUVFBMElpY1FaVVNMLzRqMjZZditpUGI4aXdJV1RFc0JvMDhDb0NjUVRHY2lKeEZsUkl2K2lQYk1pLytJOXQ5UEFxT2dKeEZNWjR2OEp4T3NKd2xNWjR2OUp4T3NKd3BNWnljUGl3Rm5JaWNKWlVSSkZTTU9SQ092VEVzQnF5SW5DbVZFU1JVakRrUlBBcXRRZ0FSVkt0U2dURkN3aVNKQy8wS0tBZ0VpUndTeElpY0xaVVNCR0ZzbHNoQWlzaGtpc2dHeUdJQUVrekljODdJYXM3UStWd1FBU1NjR0Uwa2lKd3hsVEU0Q1JFRUFYU0lXU1l3Qml3ZXBRUUJOaS82TC80ajJDNGoxazBtTUE0c0hpUFdMU1l3RXBVRUFOQ0luQldWRWl3TkpUZ0tMQkVsT0JJajEwNGoxNUlFRkZrOENUSWoxMjA4Q2lQVzBva21NQUlzQnBVRUFCNHNGaXdDSUFCaUxCb3dBaVNJV1NZd0Npd2VwUWYvd0p3eUxBbWRDLytpS0FnQWlKd1ZsUkl2L2lQVitKd1ZNWjR2K0FTY05URkJKdmloT0FrMkwvNGoxYUVzQnZFaS9pLzhWSXc1RUk2K0wvNnNuQm92K1VFeFFKeFJNVUxDSmlnTUFpLzJML2xCSkFTY1NURkJKdkVpTC83K0wveFVqRGtRanI0di9xMUNBQkJqZ2xHRk1VTENKaWdNQWkvMEJKdzFNVUVtK0tFNENUWXYvaVBVYVN3RzhTTCtML2dFbkRVeFFTYjRvVGdKTmkvK0k5UFZMQWJ4SXY0di9GU01PUkNPdmkvK3JpLzJML2xCTVVDY1VURkN3aVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU3luYyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzZXJ2ZTAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzZXJ2ZTEiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6Ik1pbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50MSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQnVybiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50MCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlN3YXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDBJbiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQxSW4iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50ME91dCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQxT3V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkFwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
