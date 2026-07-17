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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.PairTestHelper_b4c72f33
{


    //
    // @title Test wrapper that extends initialize to also set factory.
    // The real Pair sets factory = msg.sender in constructor, which doesn't work
    // on AVM where contracts can't deploy other contracts. This wrapper adds
    // a setFactory method for test setup.
    //
    public class PairTestHelperProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PairTestHelperProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        /// <param name="_factory"> </param>
        public async Task SetFactory(Algorand.Address _factory, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 112, 252, 32 };
            var _factoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _factoryAbi.From(_factory);

            var result = await base.CallApp(new List<object> { abiHandle, _factoryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetFactory_Transactions(Algorand.Address _factory, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 112, 252, 32 };
            var _factoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _factoryAbi.From(_factory);

            return await base.MakeTransactionList(new List<object> { abiHandle, _factoryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGFpclRlc3RIZWxwZXIiLCJkZXNjIjoiQHRpdGxlIFRlc3Qgd3JhcHBlciB0aGF0IGV4dGVuZHMgaW5pdGlhbGl6ZSB0byBhbHNvIHNldCBmYWN0b3J5LlxuIFRoZSByZWFsIFBhaXIgc2V0cyBmYWN0b3J5ID0gbXNnLnNlbmRlciBpbiBjb25zdHJ1Y3Rvciwgd2hpY2ggZG9lc24ndCB3b3JrXG4gb24gQVZNIHdoZXJlIGNvbnRyYWN0cyBjYW4ndCBkZXBsb3kgb3RoZXIgY29udHJhY3RzLiBUaGlzIHdyYXBwZXIgYWRkc1xuIGEgc2V0RmFjdG9yeSBtZXRob2QgZm9yIHRlc3Qgc2V0dXAuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7ImJ1cm5SZXR1cm4iOlt7Im5hbWUiOiJhbW91bnQwIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJhbW91bnQxIiwidHlwZSI6InVpbnQyNTYifV0sImdldFJlc2VydmVzUmV0dXJuIjpbeyJuYW1lIjoiX3Jlc2VydmUwIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJfcmVzZXJ2ZTEiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6Il9ibG9ja1RpbWVzdGFtcExhc3QiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InNldEZhY3RvcnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9mYWN0b3J5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJlc2VydmVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYsdWludDY0KSIsInN0cnVjdCI6ImdldFJlc2VydmVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbml0aWFsaXplIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfdG9rZW4wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX3Rva2VuMSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtaW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJTeW5jIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXNlcnZlMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXNlcnZlMSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTWludCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50MCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQxIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnVybiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJidXJuUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU3luYyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzZXJ2ZTAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzZXJ2ZTEiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkJ1cm4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50MSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3dhcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50ME91dCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDFPdXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiU3luYyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzZXJ2ZTAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzZXJ2ZTEiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlN3YXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDBJbiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQxSW4iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50ME91dCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQxT3V0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJza2ltIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzeW5jIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJTeW5jIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXNlcnZlMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXNlcnZlMSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcHJvdmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zZmVyRnJvbSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBlcm1pdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWFkbGluZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZhY3RvcnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b2tlbjAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b2tlbjEiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcmljZTBDdW11bGF0aXZlTGFzdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByaWNlMUN1bXVsYXRpdmVMYXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoia0xhc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b3RhbFN1cHBseSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IkRPTUFJTl9TRVBBUkFUT1IiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxMX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTE3N10sImVycm9yTWVzc2FnZSI6IkJhZCBkZXNpcmVkIGxpcXVpZGl0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOTBdLCJlcnJvck1lc3NhZ2UiOiJNdXN0IG5vdCBoYXZlIG1pZ3JhdG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjczOV0sImVycm9yTWVzc2FnZSI6IlVuaXN3YXBWMjogRVhQSVJFRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyNl0sImVycm9yTWVzc2FnZSI6IlVuaXN3YXBWMjogRk9SQklEREVOIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjExNl0sImVycm9yTWVzc2FnZSI6IlVuaXN3YXBWMjogSU5TVUZGSUNJRU5UX0lOUFVUX0FNT1VOVCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NTVdLCJlcnJvck1lc3NhZ2UiOiJVbmlzd2FwVjI6IElOU1VGRklDSUVOVF9MSVFVSURJVFkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTMyXSwiZXJyb3JNZXNzYWdlIjoiVW5pc3dhcFYyOiBJTlNVRkZJQ0lFTlRfTElRVUlESVRZX0JVUk5FRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExODNdLCJlcnJvck1lc3NhZ2UiOiJVbmlzd2FwVjI6IElOU1VGRklDSUVOVF9MSVFVSURJVFlfTUlOVEVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgyNF0sImVycm9yTWVzc2FnZSI6IlVuaXN3YXBWMjogSU5TVUZGSUNJRU5UX09VVFBVVF9BTU9VTlQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODkyXSwiZXJyb3JNZXNzYWdlIjoiVW5pc3dhcFYyOiBJTlZBTElEX1NJR05BVFVSRSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4OTBdLCJlcnJvck1lc3NhZ2UiOiJVbmlzd2FwVjI6IElOVkFMSURfVE8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTk4XSwiZXJyb3JNZXNzYWdlIjoiVW5pc3dhcFYyOiBLIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTU2LDEzNjksMTgwMiwyMzI2LDI0MTldLCJlcnJvck1lc3NhZ2UiOiJVbmlzd2FwVjI6IExPQ0tFRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNjZdLCJlcnJvck1lc3NhZ2UiOiJVbmlzd2FwVjI6IE9WRVJGTE9XIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc3NiwzMDIxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgRE9NQUlOX1NFUEFSQVRPUiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDQyLDMxMDJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBibG9ja1RpbWVzdGFtcExhc3QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTI0LDEwODgsMjkxMiwzMjU0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgZmFjdG9yeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTgzLDMyOTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBrTGFzdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTQ1LDMxMjhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBwcmljZTBDdW11bGF0aXZlTGFzdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTY0LDMxNTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBwcmljZTFDdW11bGF0aXZlTGFzdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjEwLDE2NjYsMjM3MywyNDk1LDMwMzIsMzIwM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHJlc2VydmUwIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMTUsMTY3MSwyNDA0LDI1MDAsMzAzNywzMjE5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgcmVzZXJ2ZTEgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTg1LDEzOTUsMTg2NiwyMzM2LDI0MzIsMjkyM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHRva2VuMCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDIxLDE0MDAsMTg3NCwyMzQxLDI0NjAsMjkzNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHRva2VuMSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDc3LDE0OTUsMTU2NCwzMDAyLDMzMzUsMzQxMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHRvdGFsU3VwcGx5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk1MiwxMzY1LDE3OTgsMjMyMiwyNDE1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgdW5sb2NrZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzU4XSwiZXJyb3JNZXNzYWdlIjoiZHMtbWF0aC1hZGQtb3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MDldLCJlcnJvck1lc3NhZ2UiOiJkcy1tYXRoLW11bC1vdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc3OF0sImVycm9yTWVzc2FnZSI6ImRzLW1hdGgtc3ViLXVuZGVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3ODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzkwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1OCw5MDksOTE3LDk0OCwxMzYxLDE3NzYsMjMxOCwyNTE4LDI1NDYsMjU3NSwyNTg1LDI2NzYsMjY4NywyNzI0LDI3MzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc1MywxNzY2LDI1MjYsMjU1NCwyNTk1LDI2OTgsMjcwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzE1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODczLDg4NiwxMjI5LDEyNDIsMTI3MywxNTc4LDE2ODUsMTY5OCwyMjE0LDIyMjUsMjIzNiwyMjQ2LDI5NTAsMjk2OSwyOTg4LDMwMDcsMzIwOCwzMjI0LDM0NDgsMzQ5MiwzNTYzXSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMzVnphR2x6ZDJGd0xYWXlMMk52Ym5SeVlXTjBjeTl0YjJOcmN5OVFZV2x5VkdWemRFaGxiSEJsY2k1emIyd3VVR0ZwY2xSbGMzUklaV3h3WlhJdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURNeUlERWdOZ29nSUNBZ1lubDBaV05pYkc5amF5QXdlQ0FpZFc1c2IyTnJaV1FpSURCNE9ETmlZV1EzWTJNZ01IZ3hOVEZtTjJNM05TQXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUNBaWRHOTBZV3hUZFhCd2JIa2lJR0poYzJVek1paEJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQktTQWlkRzlyWlc0d0lpQWlkRzlyWlc0eElpQWljbVZ6WlhKMlpUQWlJQ0p5WlhObGNuWmxNU0lnSW1aaFkzUnZjbmtpSURCNE1ERWdJbXRNWVhOMElpQWlZbUZzWVc1alpVOW1JaUFpUkU5TlFVbE9YMU5GVUVGU1FWUlBVaUlnSW1Kc2IyTnJWR2x0WlhOMFlXMXdUR0Z6ZENJZ0luQnlhV05sTUVOMWJYVnNZWFJwZG1WTVlYTjBJaUFpY0hKcFkyVXhRM1Z0ZFd4aGRHbDJaVXhoYzNRaUlDSmhiR3h2ZDJGdVkyVWlJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmlBd2VESTRPVEU0T0RZeElEQjRNVFV4Wmpkak56VTRNQ0F3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1ZZ01IZ3dNVEF3TURBd01EQXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIzUmhiRk4xY0hCc2VTSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4TlNBdkx5QWlSRTlOUVVsT1gxTkZVRUZTUVZSUFVpSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWlabUZqZEc5eWVTSUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z1lXUmtjaUJCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJXVFZJUmt0UkNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWRHOXJaVzR3SWdvZ0lDQWdZbmwwWldNZ05pQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0owYjJ0bGJqRWlDaUFnSUNCaWVYUmxZeUEySUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luSmxjMlZ5ZG1Vd0lnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSnlaWE5sY25abE1TSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWlZbXh2WTJ0VWFXMWxjM1JoYlhCTVlYTjBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4TnlBdkx5QWljSEpwWTJVd1EzVnRkV3hoZEdsMlpVeGhjM1FpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01UZ2dMeThnSW5CeWFXTmxNVU4xYlhWc1lYUnBkbVZNWVhOMElnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpJREV6SUM4dklDSnJUR0Z6ZENJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZFc1c2IyTnJaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0dJM00yTXpZelk1WW1JNFptVXpaRFV4TW1Wall6UmpaamMxT1dOak56a3lNemxtTjJJeE56bGlNR1ptWVdOaFlUbGhOelZrTlRJeVlqTTVOREF3Wm1WbVltWm1aVFkxTmpVeVlURTBOVGcwTldNNVltTTRaREExTXpJNU5EVmlaVFppT1Rnek1HWmxNV1U1T1RZMll6ZzROMkprTWprNFpUVTFNV0ZqT0ROak9EbGxabVJoWVRVMFl6Qm1NakJqTjJGa1pqWXhNamc0TW1SbU1EazFNR1kxWVRrMU1UWXpOMlV3TXpBM1kyUmpZalJqTmpjeVpqSTVPR0k0WW1NMk1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYTJWalkyRnJNalUyQ2lBZ0lDQmllWFJsWXlBeE5TQXZMeUFpUkU5TlFVbE9YMU5GVUVGU1FWUlBVaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpWm1GamRHOXllU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURJNE56Qm1Zekl3SURCNE1UUTBNekkyT1RNZ01IZzRNRGRpTURReU5DQXdlR1k1TXpneU56RTJJREI0TUdOaE5UTTFaVGdnTUhobVpUZ3dNR0V4TnlBd2VERmxZak5oTXpsaUlEQjRPVGhtTXprMk9ESWdNSGhtWVdaaU5tRXdPQ0F3ZURFNU9HTTVPREl3SURCNE5tUm1OREZtTm1RZ01IZzBZVGhrWkRBNFppQXdlRE01TkdNME1ERmlJREI0TmpNeE9EUTFaVE1nTUhoaE5UQmpPVFE1T1NBd2VEUmlaVGhqTW1FeUlEQjRPVEEzWVRVMk9ERWdNSGhoTW1VMFpEUXhaaUF3ZURjNVptRmlORFkxSURCNFltUXdZamhsTkRZZ0x5OGdiV1YwYUc5a0lDSnpaWFJHWVdOMGIzSjVLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBVbVZ6WlhKMlpYTW9LU2gxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlhVzVwZEdsaGJHbDZaU2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWJXbHVkQ2hoWkdSeVpYTnpLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbUoxY200b1lXUmtjbVZ6Y3lrb2RXbHVkREkxTml4MWFXNTBNalUyS1NJc0lHMWxkR2h2WkNBaWMzZGhjQ2gxYVc1ME1qVTJMSFZwYm5ReU5UWXNZV1JrY21WemN5eGllWFJsVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJ0cGJTaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5ONWJtTW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRndjSEp2ZG1Vb1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1dKdmIyd2lMQ0J0WlhSb2IyUWdJblJ5WVc1elptVnlLR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbGliMjlzSWl3Z2JXVjBhRzlrSUNKMGNtRnVjMlpsY2taeWIyMG9ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcFltOXZiQ0lzSUcxbGRHaHZaQ0FpY0dWeWJXbDBLR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkRFkwTEdKNWRHVmJNekpkTEdKNWRHVmJNekpkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVpoWTNSdmNua29LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJblJ2YTJWdU1DZ3BZV1JrY21WemN5SXNJRzFsZEdodlpDQWlkRzlyWlc0eEtDbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSndjbWxqWlRCRGRXMTFiR0YwYVhabFRHRnpkQ2dwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpY0hKcFkyVXhRM1Z0ZFd4aGRHbDJaVXhoYzNRb0tYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltdE1ZWE4wS0NsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKMGIzUmhiRk4xY0hCc2VTZ3BkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWlSRTlOUVVsT1gxTkZVRUZTUVZSUFVpZ3BZbmwwWlZzek1sMGlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J6WlhSR1lXTjBiM0o1SUdkbGRGSmxjMlZ5ZG1WeklHbHVhWFJwWVd4cGVtVWdiV2x1ZENCaWRYSnVJSE4zWVhBZ2MydHBiU0J6ZVc1aklHRndjSEp2ZG1VZ2RISmhibk5tWlhJZ2RISmhibk5tWlhKR2NtOXRJSEJsY20xcGRDQm1ZV04wYjNKNUlIUnZhMlZ1TUNCMGIydGxiakVnY0hKcFkyVXdRM1Z0ZFd4aGRHbDJaVXhoYzNRZ2NISnBZMlV4UTNWdGRXeGhkR2wyWlV4aGMzUWdhMHhoYzNRZ2RHOTBZV3hUZFhCd2JIa2dSRTlOUVVsT1gxTkZVRUZTUVZSUFVnb2dJQ0FnWlhKeUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdmJXOWphM012VUdGcGNsUmxjM1JJWld4d1pYSXVjMjlzTGsxaGRHZ3ViV2x1S0hnNklHSjVkR1Z6TENCNU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNrMWhkR2d1YldsdU9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lqd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdmJXOWphM012VUdGcGNsUmxjM1JJWld4d1pYSXVjMjlzTGsxaGRHZ3VjM0Z5ZENoNU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNrMWhkR2d1YzNGeWREb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNRE1LSUNBZ0lHSStDaUFnSUNCaWVpQk5ZWFJvTG5OeGNuUmZaV3h6WlY5aWIyUjVRRFVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNRElLSUNBZ0lHSXZDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QXdlREF4Q2lBZ0lDQmlLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb0tUV0YwYUM1emNYSjBYM2RvYVd4bFgzUnZjRUF5T2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaVBBb2dJQ0FnWW5vZ1RXRjBhQzV6Y1hKMFgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmlMd29nSUNBZ1pHbG5JREVLSUNBZ0lHSXJDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNZ29nSUNBZ1lpOEtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JpSUUxaGRHZ3VjM0Z5ZEY5M2FHbHNaVjkwYjNCQU1nb0tUV0YwYUM1emNYSjBYMkZtZEdWeVgybG1YMlZzYzJWQU9Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tUV0YwYUM1emNYSjBYMlZzYzJWZlltOWtlVUExT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lHSjZJRTFoZEdndWMzRnlkRjloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR0lnVFdGMGFDNXpjWEowWDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emRYTm9hWE4zWVhBdGRqSXZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwxQmhhWEpVWlhOMFNHVnNjR1Z5TG5OdmJDNVRZV1psVFdGMGFGVnVhWE4zWVhBdVlXUmtLSGc2SUdKNWRHVnpMQ0I1T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2xOaFptVk5ZWFJvVlc1cGMzZGhjQzVoWkdRNkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUt3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0krUFFvZ0lDQWdZWE56WlhKMElDOHZJR1J6TFcxaGRHZ3RZV1JrTFc5MlpYSm1iRzkzQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjM1Z6YUdsemQyRndMWFl5TDJOdmJuUnlZV04wY3k5dGIyTnJjeTlRWVdseVZHVnpkRWhsYkhCbGNpNXpiMnd1VTJGbVpVMWhkR2hWYm1semQyRndMbk4xWWloNE9pQmllWFJsY3l3Z2VUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncFRZV1psVFdGMGFGVnVhWE4zWVhBdWMzVmlPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJckNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSThQUW9nSUNBZ1lYTnpaWEowSUM4dklHUnpMVzFoZEdndGMzVmlMWFZ1WkdWeVpteHZkd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTjFjMmhwYzNkaGNDMTJNaTlqYjI1MGNtRmpkSE12Ylc5amEzTXZVR0ZwY2xSbGMzUklaV3h3WlhJdWMyOXNMbE5oWm1WTllYUm9WVzVwYzNkaGNDNXRkV3dvZURvZ1lubDBaWE1zSUhrNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1UyRm1aVTFoZEdoVmJtbHpkMkZ3TG0xMWJEb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQVDBLSUNBZ0lHSnVlaUJUWVdabFRXRjBhRlZ1YVhOM1lYQXViWFZzWDJKdmIyeGZkSEoxWlVBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZaW9LSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJdkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0k5UFFvZ0lDQWdZbm9nVTJGbVpVMWhkR2hWYm1semQyRndMbTExYkY5aWIyOXNYMlpoYkhObFFETUtDbE5oWm1WTllYUm9WVzVwYzNkaGNDNXRkV3hmWW05dmJGOTBjblZsUURJNkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvS1UyRm1aVTFoZEdoVmJtbHpkMkZ3TG0xMWJGOWliMjlzWDIxbGNtZGxRRFE2Q2lBZ0lDQmhjM05sY25RZ0x5OGdaSE10YldGMGFDMXRkV3d0YjNabGNtWnNiM2NLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2xOaFptVk5ZWFJvVlc1cGMzZGhjQzV0ZFd4ZlltOXZiRjltWVd4elpVQXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ1UyRm1aVTFoZEdoVmJtbHpkMkZ3TG0xMWJGOWliMjlzWDIxbGNtZGxRRFFLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMzVnphR2x6ZDJGd0xYWXlMMk52Ym5SeVlXTjBjeTl0YjJOcmN5OVFZV2x5VkdWemRFaGxiSEJsY2k1emIyd3VWVkV4TVRKNE1URXlMbVZ1WTI5a1pTaDVPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbFZSTVRFeWVERXhNaTVsYm1OdlpHVTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS2dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdmJXOWphM012VUdGcGNsUmxjM1JJWld4d1pYSXVjMjlzTGxWUk1URXllREV4TWk1MWNXUnBkaWg0T2lCaWVYUmxjeXdnZVRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwVlVURXhNbmd4TVRJdWRYRmthWFk2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpTHdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdmJXOWphM012VUdGcGNsUmxjM1JJWld4d1pYSXVjMjlzTGxCaGFYSlVaWE4wU0dWc2NHVnlMbk5sZEVaaFkzUnZjbmxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUkdZV04wYjNKNU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaVptRmpkRzl5ZVNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdmJXOWphM012VUdGcGNsUmxjM1JJWld4d1pYSXVjMjlzTGxCaGFYSlVaWE4wU0dWc2NHVnlMbWRsZEZKbGMyVnlkbVZ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBVbVZ6WlhKMlpYTTZDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6ZFhOb2FYTjNZWEF0ZGpJdlkyOXVkSEpoWTNSekwyMXZZMnR6TDFCaGFYSlVaWE4wU0dWc2NHVnlMbk52YkM1UVlXbHlWR1Z6ZEVobGJIQmxjaTVuWlhSU1pYTmxjblpsY3dvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlmQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbndLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdmJXOWphM012VUdGcGNsUmxjM1JJWld4d1pYSXVjMjlzTGxCaGFYSlVaWE4wU0dWc2NHVnlMbWx1YVhScFlXeHBlbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGJtbDBhV0ZzYVhwbE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWlabUZqZEc5eWVTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1ptRmpkRzl5ZVNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZXNXBjM2RoY0ZZeU9pQkdUMUpDU1VSRVJVNEtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luUnZhMlZ1TUNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblJ2YTJWdU1TSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOMWMyaHBjM2RoY0MxMk1pOWpiMjUwY21GamRITXZiVzlqYTNNdlVHRnBjbFJsYzNSSVpXeHdaWEl1YzI5c0xsQmhhWEpVWlhOMFNHVnNjR1Z5TG0xcGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B0YVc1ME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0c0Z01nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZFc1c2IyTnJaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFZ1Ykc5amEyVmtJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTWdNVElnTHk4Z01IZ3dNUW9nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZXNXBjM2RoY0ZZeU9pQk1UME5MUlVRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0oxYm14dlkydGxaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emRYTm9hWE4zWVhBdGRqSXZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwxQmhhWEpVWlhOMFNHVnNjR1Z5TG5OdmJDNVFZV2x5VkdWemRFaGxiSEJsY2k1blpYUlNaWE5sY25abGN3b2dJQ0FnY0c5d2JpQXlDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdmJXOWphM012VUdGcGNsUmxjM1JJWld4d1pYSXVjMjlzTGxCaGFYSlVaWE4wU0dWc2NHVnlMbWRsZEZKbGMyVnlkbVZ6Q2lBZ0lDQndiM0FLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnY0c5d0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblJ2YTJWdU1DSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOXJaVzR3SUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eUlDOHZJRzFsZEdodlpDQWlZbUZzWVc1alpVOW1LR0ZrWkhKbGMzTXBkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE0SUM4dklDSjBiMnRsYmpFaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhSdmEyVnVNU0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTWlBdkx5QnRaWFJvYjJRZ0ltSmhiR0Z1WTJWUFppaGhaR1J5WlhOektYVnBiblF5TlRZaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb1ZXNXBjM2RoY0M1emRXSUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb1ZXNXBjM2RoY0M1emRXSUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1gyMXBiblJHWldVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0owYjNSaGJGTjFjSEJzZVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIUnZkR0ZzVTNWd2NHeDVJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWowOUNpQWdJQ0JpZWlCdGFXNTBYMlZzYzJWZlltOWtlVUF4TkFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV4SUM4dklDSm1ZV04wYjNKNUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCbVlXTjBiM0o1SUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0TXpCbFptWTROQ0F2THlCdFpYUm9iMlFnSW0xcFozSmhkRzl5S0NsaFpHUnlaWE56SWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE1Rb2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE1nb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHSjZJRzFwYm5SZlpXeHpaVjlpYjJSNVFERXlDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JrYVdjZ09Rb2dJQ0FnY0hWemFHbHVkQ0F5T0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dOVFEzTXpCbVl5QXZMeUJ0WlhSb2IyUWdJbVJsYzJseVpXUk1hWEYxYVdScGRIa29LWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqNEtJQ0FnSUdKNklHMXBiblJmWW05dmJGOW1ZV3h6WlVBeE1Bb2dJQ0FnWkdsbklERXhDaUFnSUNCaWVYUmxZeUF5TXlBdkx5QXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlLSUNBZ0lHSWhQUW9nSUNBZ1lub2diV2x1ZEY5aWIyOXNYMlpoYkhObFFERXdDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb0tiV2x1ZEY5aWIyOXNYMjFsY21kbFFERXhPZ29nSUNBZ1lYTnpaWEowSUM4dklFSmhaQ0JrWlhOcGNtVmtJR3hwY1hWcFpHbDBlUW9LYldsdWRGOWhablJsY2w5cFpsOWxiSE5sUURFMU9nb2dJQ0FnWkdsbklERXhDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJK0NpQWdJQ0JoYzNObGNuUWdMeThnVlc1cGMzZGhjRll5T2lCSlRsTlZSa1pKUTBsRlRsUmZURWxSVlVsRVNWUlpYMDFKVGxSRlJBb2dJQ0FnWkdsbklEa0tJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnWDIxcGJuUUtJQ0FnSUdScFp5QTFDaUFnSUNCa2FXY2dOUW9nSUNBZ1pHbG5JRGtLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmpZV3hzYzNWaUlGOTFjR1JoZEdVS0lDQWdJR1JwWnlBeENpQWdJQ0JpZWlCdGFXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU1UY0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKeVpYTmxjblpsTUNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnY21WelpYSjJaVEFnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0luSmxjMlZ5ZG1VeElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCeVpYTmxjblpsTVNCbGVHbHpkSE1LSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdoVmJtbHpkMkZ3TG0xMWJBb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0ltdE1ZWE4wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMXBiblJmWVdaMFpYSmZhV1pmWld4elpVQXhOem9LSUNBZ0lHUnBaeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbndLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUTNabVEwTVRaaElDOHZJRzFsZEdodlpDQWlUV2x1ZENoaFpHUnlaWE56TEhWcGJuUXlOVFlzZFdsdWRESTFOaWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblZ1Ykc5amEyVmtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xcGJuUmZZbTl2YkY5bVlXeHpaVUF4TURvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRzFwYm5SZlltOXZiRjl0WlhKblpVQXhNUW9LYldsdWRGOWxiSE5sWDJKdlpIbEFNVEk2Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR0o1ZEdWaklEWWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFMTFjM1FnYm05MElHaGhkbVVnYldsbmNtRjBiM0lLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFGVnVhWE4zWVhBdWJYVnNDaUFnSUNCallXeHNjM1ZpSUUxaGRHZ3VjM0Z5ZEFvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFGVnVhWE4zWVhBdWMzVmlDaUFnSUNCaWRYSjVJREV6Q2lBZ0lDQmllWFJsWXlBMklDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCZmJXbHVkQW9nSUNBZ1lpQnRhVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFVLQ20xcGJuUmZaV3h6WlY5aWIyUjVRREUwT2dvZ0lDQWdaR2xuSURNS0lDQWdJR1JwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2hWYm1semQyRndMbTExYkFvZ0lDQWdaR2xuSURrS0lDQWdJR0l2Q2lBZ0lDQmthV2NnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvVlc1cGMzZGhjQzV0ZFd3S0lDQWdJR1JwWnlBNENpQWdJQ0JpTHdvZ0lDQWdZMkZzYkhOMVlpQk5ZWFJvTG0xcGJnb2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ1lpQnRhVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFVLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMzVnphR2x6ZDJGd0xYWXlMMk52Ym5SeVlXTjBjeTl0YjJOcmN5OVFZV2x5VkdWemRFaGxiSEJsY2k1emIyd3VVR0ZwY2xSbGMzUklaV3h3WlhJdVluVnlibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21KMWNtNDZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZFc1c2IyTnJaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFZ1Ykc5amEyVmtJR1Y0YVhOMGN3b2dJQ0FnWW5sMFpXTWdNVElnTHk4Z01IZ3dNUW9nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZXNXBjM2RoY0ZZeU9pQk1UME5MUlVRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0oxYm14dlkydGxaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emRYTm9hWE4zWVhBdGRqSXZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwxQmhhWEpVWlhOMFNHVnNjR1Z5TG5OdmJDNVFZV2x5VkdWemRFaGxiSEJsY2k1blpYUlNaWE5sY25abGN3b2dJQ0FnY0c5d2JpQXlDaUFnSUNCa2RYQUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdmJXOWphM012VUdGcGNsUmxjM1JJWld4d1pYSXVjMjlzTGxCaGFYSlVaWE4wU0dWc2NHVnlMbWRsZEZKbGMyVnlkbVZ6Q2lBZ0lDQndiM0FLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnY0c5d0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ055QXZMeUFpZEc5clpXNHdJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjBiMnRsYmpBZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkRzlyWlc0eElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMGIydGxiakVnWlhocGMzUnpDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUExQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNaUF2THlCdFpYUm9iMlFnSW1KaGJHRnVZMlZQWmloaFpHUnlaWE56S1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTFDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1pQXZMeUJ0WlhSb2IyUWdJbUpoYkdGdVkyVlBaaWhoWkdSeVpYTnpLWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBaVltRnNZVzVqWlU5bUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOUW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTmhiR3h6ZFdJZ1gyMXBiblJHWldVS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIzUmhiRk4xY0hCc2VTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOTBZV3hUZFhCd2JIa2daWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb1ZXNXBjM2RoY0M1dGRXd0tJQ0FnSUdScFp5QXhDaUFnSUNCaUx3b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2hWYm1semQyRndMbTExYkFvZ0lDQWdjM2RoY0FvZ0lDQWdZaThLSUNBZ0lITjNZWEFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSStDaUFnSUNCaWVpQmlkWEp1WDJKdmIyeGZabUZzYzJWQU5nb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpUGdvZ0lDQWdZbm9nWW5WeWJsOWliMjlzWDJaaGJITmxRRFlLSUNBZ0lHbHVkR05mTWlBdkx5QXhDZ3BpZFhKdVgySnZiMnhmYldWeVoyVkFOem9LSUNBZ0lHRnpjMlZ5ZENBdkx5QlZibWx6ZDJGd1ZqSTZJRWxPVTFWR1JrbERTVVZPVkY5TVNWRlZTVVJKVkZsZlFsVlNUa1ZFQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdaSFZ3Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKaVlXeGhibU5sVDJZaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrYVdjZ05nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUZOaFptVk5ZWFJvVlc1cGMzZGhjQzV6ZFdJS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSjBiM1JoYkZOMWNIQnNlU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkRzkwWVd4VGRYQndiSGtnWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUZWdWFYTjNZWEF1YzNWaUNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIzUmhiRk4xY0hCc2VTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVE1LSUNBZ0lHSjhDaUFnSUNCemQyRndDaUFnSUNCaWVYUmxZeUEySUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURJeElDOHZJRzFsZEdodlpDQWlWSEpoYm5ObVpYSW9ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdScFp5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdiV1YwYUc5a0lDSmlZV3hoYm1ObFQyWW9ZV1JrY21WemN5bDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ1pHbG5JRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1pQXZMeUJ0WlhSb2IyUWdJbUpoYkdGdVkyVlBaaWhoWkdSeVpYTnpLWFZwYm5ReU5UWWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmthV2NnT1FvZ0lDQWdaR2xuSURrS0lDQWdJR05oYkd4emRXSWdYM1Z3WkdGMFpRb2dJQ0FnWkdsbklESUtJQ0FnSUdKNklHSjFjbTVmWVdaMFpYSmZhV1pmWld4elpVQXhNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luSmxjMlZ5ZG1Vd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCeVpYTmxjblpsTUNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWljbVZ6WlhKMlpURWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklISmxjMlZ5ZG1VeElHVjRhWE4wY3dvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFGVnVhWE4zWVhBdWJYVnNDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlhMHhoYzNRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tZblZ5Ymw5aFpuUmxjbDlwWmw5bGJITmxRREV4T2dvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWZBb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbndLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3daRGd5WXpZMVlpQXZMeUJ0WlhSb2IyUWdJa0oxY200b1lXUmtjbVZ6Y3l4MWFXNTBNalUyTEhWcGJuUXlOVFlzWVdSa2NtVnpjeWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblZ1Ykc5amEyVmtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1luVnlibDlpYjI5c1gyWmhiSE5sUURZNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJpZFhKdVgySnZiMnhmYldWeVoyVkFOd29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emRYTm9hWE4zWVhBdGRqSXZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwxQmhhWEpVWlhOMFNHVnNjR1Z5TG5OdmJDNVFZV2x5VkdWemRFaGxiSEJsY2k1emQyRndXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzNkaGNEb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhCdUlEa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0lpSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0oxYm14dlkydGxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkVzVzYjJOclpXUWdaWGhwYzNSekNpQWdJQ0JpZVhSbFl5QXhNaUF2THlBd2VEQXhDaUFnSUNCaVBUMEtJQ0FnSUdGemMyVnlkQ0F2THlCVmJtbHpkMkZ3VmpJNklFeFBRMHRGUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZFc1c2IyTnJaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajRLSUNBZ0lHSnVlaUJ6ZDJGd1gySnZiMnhmZEhKMVpVQXpDaUFnSUNCa2FXY2dOQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqNEtJQ0FnSUdKNklITjNZWEJmWW05dmJGOW1ZV3h6WlVBMENncHpkMkZ3WDJKdmIyeGZkSEoxWlVBek9nb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0NuTjNZWEJmWW05dmJGOXRaWEpuWlVBMU9nb2dJQ0FnWVhOelpYSjBJQzh2SUZWdWFYTjNZWEJXTWpvZ1NVNVRWVVpHU1VOSlJVNVVYMDlWVkZCVlZGOUJUVTlWVGxRS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTjFjMmhwYzNkaGNDMTJNaTlqYjI1MGNtRmpkSE12Ylc5amEzTXZVR0ZwY2xSbGMzUklaV3h3WlhJdWMyOXNMbEJoYVhKVVpYTjBTR1ZzY0dWeUxtZGxkRkpsYzJWeWRtVnpDaUFnSUNCd2IzQnVJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4T1FvZ0lDQWdZMkZzYkhOMVlpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMzVnphR2x6ZDJGd0xYWXlMMk52Ym5SeVlXTjBjeTl0YjJOcmN5OVFZV2x5VkdWemRFaGxiSEJsY2k1emIyd3VVR0ZwY2xSbGMzUklaV3h3WlhJdVoyVjBVbVZ6WlhKMlpYTUtJQ0FnSUhCdmNBb2dJQ0FnWW5WeWVTQXhPUW9nSUNBZ2NHOXdDaUFnSUNCa2FXY2dOd29nSUNBZ1lqNEtJQ0FnSUdKNklITjNZWEJmWW05dmJGOW1ZV3h6WlVBNENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkdsbklERTNDaUFnSUNCaVBBb2dJQ0FnWW5vZ2MzZGhjRjlpYjI5c1gyWmhiSE5sUURnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2dwemQyRndYMkp2YjJ4ZmJXVnlaMlZBT1RvS0lDQWdJR0Z6YzJWeWRDQXZMeUJWYm1semQyRndWakk2SUVsT1UxVkdSa2xEU1VWT1ZGOU1TVkZWU1VSSlZGa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKMGIydGxiakFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWRYSjVJREU0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOXJaVzR3SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luUnZhMlZ1TVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCemQyRndDaUFnSUNCaWRYSjVJREUzQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOXJaVzR4SUdWNGFYTjBjd29nSUNBZ1pHbG5JRE1LSUNBZ0lDRTlDaUFnSUNCaWVpQnpkMkZ3WDJKdmIyeGZabUZzYzJWQU1USUtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNVFVLSUNBZ0lDRTlDaUFnSUNCaWVpQnpkMkZ3WDJKdmIyeGZabUZzYzJWQU1USUtJQ0FnSUdsdWRHTmZNaUF2THlBeENncHpkMkZ3WDJKdmIyeGZiV1Z5WjJWQU1UTTZDaUFnSUNCaGMzTmxjblFnTHk4Z1ZXNXBjM2RoY0ZZeU9pQkpUbFpCVEVsRVgxUlBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dPUW9nSUNBZ1lub2djM2RoY0Y5aFpuUmxjbDlwWmw5bGJITmxRREl3Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBNUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1JwWnlBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTJDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR00yWlRFMFlXWTJJQzh2SUcxbGRHaHZaQ0FpZFc1cGMzZGhjRll5UTJGc2JDaGhaR1J5WlhOekxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBPRnRkS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9LYzNkaGNGOWhablJsY2w5cFpsOWxiSE5sUURJd09nb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR1JwWnlBeE5nb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh5SUM4dklHMWxkR2h2WkNBaVltRnNZVzVqWlU5bUtHRmtaSEpsYzNNcGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNd29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdScFp5QXhOZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eUlDOHZJRzFsZEdodlpDQWlZbUZzWVc1alpVOW1LR0ZrWkhKbGMzTXBkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHSjFjbmtnTVRJS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdScFp5QTRDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ1lqNEtJQ0FnSUdKNklITjNZWEJmZEdWeWJtRnllVjltWVd4elpVQXlOQW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdaR2xuSURFd0NpQWdJQ0JpTFFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR0oxY25rZ01UUUtDbk4zWVhCZmRHVnlibUZ5ZVY5dFpYSm5aVUF5TlRvS0lDQWdJR1JwWnlBeE5nb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdScFp5QTFDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNQW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQmlQQW9nSUNBZ1lub2djM2RoY0Y5MFpYSnVZWEo1WDJaaGJITmxRREkzQ2lBZ0lDQmthV2NnTVRBS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJckNpQWdJQ0JrYVdjZ09Rb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JpZFhKNUlERXpDZ3B6ZDJGd1gzUmxjbTVoY25sZmJXVnlaMlZBTWpnNkNpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdJK0NpQWdJQ0JpYm5vZ2MzZGhjRjlpYjI5c1gzUnlkV1ZBTXpBS0lDQWdJR1JwWnlBeE1nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWo0S0lDQWdJR0o2SUhOM1lYQmZZbTl2YkY5bVlXeHpaVUF6TVFvS2MzZGhjRjlpYjI5c1gzUnlkV1ZBTXpBNkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvS2MzZGhjRjlpYjI5c1gyMWxjbWRsUURNeU9nb2dJQ0FnWVhOelpYSjBJQzh2SUZWdWFYTjNZWEJXTWpvZ1NVNVRWVVpHU1VOSlJVNVVYMGxPVUZWVVgwRk5UMVZPVkFvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTVRJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2hWYm1semQyRndMbTExYkFvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNVGNLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdVMkZtWlUxaGRHaFZibWx6ZDJGd0xtMTFiQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9WVzVwYzNkaGNDNXpkV0lLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdoVmJtbHpkMkZ3TG0xMWJBb2dJQ0FnWkdsbklERTRDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRGNLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTJGc2JITjFZaUJUWVdabFRXRjBhRlZ1YVhOM1lYQXViWFZzQ2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb1ZXNXBjM2RoY0M1emRXSUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2hWYm1semQyRndMbTExYkFvZ0lDQWdaR2xuSURJeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdScFp5QXlNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb1ZXNXBjM2RoY0M1dGRXd0tJQ0FnSUhCMWMyaHBiblFnTVRBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUZWdWFYTjNZWEF1YlhWc0NpQWdJQ0JpUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJWYm1semQyRndWakk2SUVzS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTJGc2JITjFZaUJmZFhCa1lYUmxDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUdScFp5QTRDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZbndLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dNd29nSUNBZ1lud0tJQ0FnSUdScFp5QTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUE0Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdKOENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREprTW1GbVlXWTRJQzh2SUcxbGRHaHZaQ0FpVTNkaGNDaGhaR1J5WlhOekxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzWVdSa2NtVnpjeWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblZ1Ykc5amEyVmtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25OM1lYQmZZbTl2YkY5bVlXeHpaVUF6TVRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJSE4zWVhCZlltOXZiRjl0WlhKblpVQXpNZ29LYzNkaGNGOTBaWEp1WVhKNVgyWmhiSE5sUURJM09nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXpDaUFnSUNCaUlITjNZWEJmZEdWeWJtRnllVjl0WlhKblpVQXlPQW9LYzNkaGNGOTBaWEp1WVhKNVgyWmhiSE5sUURJME9nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTBDaUFnSUNCaUlITjNZWEJmZEdWeWJtRnllVjl0WlhKblpVQXlOUW9LYzNkaGNGOWliMjlzWDJaaGJITmxRREV5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdjM2RoY0Y5aWIyOXNYMjFsY21kbFFERXpDZ3B6ZDJGd1gySnZiMnhmWm1Gc2MyVkFPRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlITjNZWEJmWW05dmJGOXRaWEpuWlVBNUNncHpkMkZ3WDJKdmIyeGZabUZzYzJWQU5Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUhOM1lYQmZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTjFjMmhwYzNkaGNDMTJNaTlqYjI1MGNtRmpkSE12Ylc5amEzTXZVR0ZwY2xSbGMzUklaV3h3WlhJdWMyOXNMbEJoYVhKVVpYTjBTR1ZzY0dWeUxuTnJhVzFiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwemEybHRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luVnViRzlqYTJWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMWJteHZZMnRsWkNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0TURFS0lDQWdJR0k5UFFvZ0lDQWdZWE56WlhKMElDOHZJRlZ1YVhOM1lYQldNam9nVEU5RFMwVkVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRXNXNiMk5yWldRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5SdmEyVnVNQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkRzlyWlc0d0lHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblJ2YTJWdU1TSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOXJaVzR4SUdWNGFYTjBjd29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHlJQzh2SUcxbGRHaHZaQ0FpWW1Gc1lXNWpaVTltS0dGa1pISmxjM01wZFdsdWRESTFOaUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKeVpYTmxjblpsTUNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCeVpYTmxjblpsTUNCbGVHbHpkSE1LSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdiV1YwYUc5a0lDSmlZV3hoYm1ObFQyWW9ZV1JrY21WemN5bDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0p5WlhObGNuWmxNU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ5WlhObGNuWmxNU0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMWJteHZZMnRsWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdmJXOWphM012VUdGcGNsUmxjM1JJWld4d1pYSXVjMjlzTGxCaGFYSlVaWE4wU0dWc2NHVnlMbk41Ym1OYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHplVzVqT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblZ1Ykc5amEyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjFibXh2WTJ0bFpDQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWaklERXlJQzh2SURCNE1ERUtJQ0FnSUdJOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZWdWFYTjNZWEJXTWpvZ1RFOURTMFZFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QWlkVzVzYjJOclpXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKMGIydGxiakFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSFJ2YTJWdU1DQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNaUF2THlCdFpYUm9iMlFnSW1KaGJHRnVZMlZQWmloaFpHUnlaWE56S1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5SdmEyVnVNU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dkRzlyWlc0eElHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHlJQzh2SUcxbGRHaHZaQ0FpWW1Gc1lXNWpaVTltS0dGa1pISmxjM01wZFdsdWRESTFOaUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnlaWE5sY25abE1DSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2NtVnpaWEoyWlRBZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbkpsYzJWeWRtVXhJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnlaWE5sY25abE1TQmxlR2x6ZEhNS0lDQWdJR05oYkd4emRXSWdYM1Z3WkdGMFpRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5WdWJHOWphMlZrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjM1Z6YUdsemQyRndMWFl5TDJOdmJuUnlZV04wY3k5dGIyTnJjeTlRWVdseVZHVnpkRWhsYkhCbGNpNXpiMnd1VUdGcGNsUmxjM1JJWld4d1pYSXVZWEJ3Y205MlpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ3Y0hKdmRtVTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQmZZWEJ3Y205MlpRb2dJQ0FnWW5sMFpXTWdNaklnTHk4Z01IZ3hOVEZtTjJNM05UZ3dDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YzNWemFHbHpkMkZ3TFhZeUwyTnZiblJ5WVdOMGN5OXRiMk5yY3k5UVlXbHlWR1Z6ZEVobGJIQmxjaTV6YjJ3dVVHRnBjbFJsYzNSSVpXeHdaWEl1ZEhKaGJuTm1aWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMGNtRnVjMlpsY2pvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCallXeHNjM1ZpSUY5MGNtRnVjMlpsY2dvZ0lDQWdZbmwwWldNZ01qSWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjM1Z6YUdsemQyRndMWFl5TDJOdmJuUnlZV04wY3k5dGIyTnJjeTlRWVdseVZHVnpkRWhsYkhCbGNpNXpiMnd1VUdGcGNsUmxjM1JJWld4d1pYSXVkSEpoYm5ObVpYSkdjbTl0VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RISmhibk5tWlhKR2NtOXRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERTVJQzh2SUNKaGJHeHZkMkZ1WTJVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWW5sMFpXTWdNak1nTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCaUlUMEtJQ0FnSUdKNklIUnlZVzV6Wm1WeVJuSnZiVjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBekNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWaklERTVJQzh2SUNKaGJHeHZkMkZ1WTJVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkdsbklESUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2hWYm1semQyRndMbk4xWWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRrZ0x5OGdJbUZzYkc5M1lXNWpaU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtDblJ5WVc1elptVnlSbkp2YlY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJRjkwY21GdWMyWmxjZ29nSUNBZ1lubDBaV01nTWpJZ0x5OGdNSGd4TlRGbU4yTTNOVGd3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMzVnphR2x6ZDJGd0xYWXlMMk52Ym5SeVlXTjBjeTl0YjJOcmN5OVFZV2x5VkdWemRFaGxiSEJsY2k1emIyd3VVR0ZwY2xSbGMzUklaV3h3WlhJdWNHVnliV2wwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NHVnliV2wwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dOQW9nSUNBZ1lqdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZXNXBjM2RoY0ZZeU9pQkZXRkJKVWtWRUNpQWdJQ0JrYVdjZ05nb2dJQ0FnYzJoaE1qVTJDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltNXZibU5sY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0o1ZEdWaklERXlJQzh2SURCNE1ERUtJQ0FnSUdJckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJQ0pFVDAxQlNVNWZVMFZRUVZKQlZFOVNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkVUMDFCU1U1ZlUwVlFRVkpCVkU5U0lHVjRhWE4wY3dvZ0lDQWdaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pjZURFNVhIZ3dNU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Tm1VM01XVmtZV1V4TW1JeFlqazNaalJrTVdZMk1ETTNNR1psWmpFd01UQTFabUV5Wm1GaFpUQXhNall4TVRSaE1UWTVZelkwT0RRMVpEWXhNalpqT1FvZ0lDQWdkVzVqYjNabGNpQXhNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhMlZqWTJGck1qVTJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JyWldOallXc3lOVFlLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnY0hWemFHbHVkQ0F5TndvZ0lDQWdMUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHVmpaSE5oWDNCclgzSmxZMjkyWlhJZ1UyVmpjREkxTm1zeENpQWdJQ0J3ZFhOb2FXNTBJREV5Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCclpXTmpZV3N5TlRZS0lDQWdJR1Y0ZEhKaFkzUWdNVElnTWpBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUdGa1pISWdRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFWazFTRVpMVVFvZ0lDQWdJVDBLSUNBZ0lHSjZJSEJsY20xcGRGOWliMjlzWDJaaGJITmxRRFFLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFFLSUNBZ0lEMDlDaUFnSUNCaWVpQndaWEp0YVhSZlltOXZiRjltWVd4elpVQTBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb0tjR1Z5YldsMFgySnZiMnhmYldWeVoyVkFOVG9LSUNBZ0lHRnpjMlZ5ZENBdkx5QlZibWx6ZDJGd1ZqSTZJRWxPVmtGTVNVUmZVMGxIVGtGVVZWSkZDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpZV3hzYzNWaUlGOWhjSEJ5YjNabENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHdaWEp0YVhSZlltOXZiRjltWVd4elpVQTBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2NHVnliV2wwWDJKdmIyeGZiV1Z5WjJWQU5Rb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6ZFhOb2FYTjNZWEF0ZGpJdlkyOXVkSEpoWTNSekwyMXZZMnR6TDFCaGFYSlVaWE4wU0dWc2NHVnlMbk52YkM1UVlXbHlWR1Z6ZEVobGJIQmxjaTVtWVdOMGIzSjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWm1GamRHOXllVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWlabUZqZEc5eWVTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1ptRmpkRzl5ZVNCbGVHbHpkSE1LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMzVnphR2x6ZDJGd0xYWXlMMk52Ym5SeVlXTjBjeTl0YjJOcmN5OVFZV2x5VkdWemRFaGxiSEJsY2k1emIyd3VVR0ZwY2xSbGMzUklaV3h3WlhJdWRHOXJaVzR3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHOXJaVzR3T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblJ2YTJWdU1DSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2RHOXJaVzR3SUdWNGFYTjBjd29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5emRYTm9hWE4zWVhBdGRqSXZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwxQmhhWEpVWlhOMFNHVnNjR1Z5TG5OdmJDNVFZV2x5VkdWemRFaGxiSEJsY2k1MGIydGxiakZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMGIydGxiakU2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlkRzlyWlc0eElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCMGIydGxiakVnWlhocGMzUnpDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOMWMyaHBjM2RoY0MxMk1pOWpiMjUwY21GamRITXZiVzlqYTNNdlVHRnBjbFJsYzNSSVpXeHdaWEl1YzI5c0xsQmhhWEpVWlhOMFNHVnNjR1Z5TG5CeWFXTmxNRU4xYlhWc1lYUnBkbVZNWVhOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjSEpwWTJVd1EzVnRkV3hoZEdsMlpVeGhjM1E2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRjZ0x5OGdJbkJ5YVdObE1FTjFiWFZzWVhScGRtVk1ZWE4wSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ3Y21salpUQkRkVzExYkdGMGFYWmxUR0Z6ZENCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOMWMyaHBjM2RoY0MxMk1pOWpiMjUwY21GamRITXZiVzlqYTNNdlVHRnBjbFJsYzNSSVpXeHdaWEl1YzI5c0xsQmhhWEpVWlhOMFNHVnNjR1Z5TG5CeWFXTmxNVU4xYlhWc1lYUnBkbVZNWVhOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjSEpwWTJVeFEzVnRkV3hoZEdsMlpVeGhjM1E2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRnZ0x5OGdJbkJ5YVdObE1VTjFiWFZzWVhScGRtVk1ZWE4wSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ3Y21salpURkRkVzExYkdGMGFYWmxUR0Z6ZENCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOMWMyaHBjM2RoY0MxMk1pOWpiMjUwY21GamRITXZiVzlqYTNNdlVHRnBjbFJsYzNSSVpXeHdaWEl1YzI5c0xsQmhhWEpVWlhOMFNHVnNjR1Z5TG10TVlYTjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYTB4aGMzUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0ltdE1ZWE4wSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJyVEdGemRDQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTjFjMmhwYzNkaGNDMTJNaTlqYjI1MGNtRmpkSE12Ylc5amEzTXZVR0ZwY2xSbGMzUklaV3h3WlhJdWMyOXNMbEJoYVhKVVpYTjBTR1ZzY0dWeUxuUnZkR0ZzVTNWd2NHeDVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEc5MFlXeFRkWEJ3YkhrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEc5MFlXeFRkWEJ3YkhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhSdmRHRnNVM1Z3Y0d4NUlHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMzVnphR2x6ZDJGd0xYWXlMMk52Ym5SeVlXTjBjeTl0YjJOcmN5OVFZV2x5VkdWemRFaGxiSEJsY2k1emIyd3VVR0ZwY2xSbGMzUklaV3h3WlhJdVJFOU5RVWxPWDFORlVFRlNRVlJQVWx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNrUlBUVUZKVGw5VFJWQkJVa0ZVVDFJNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UVWdMeThnSWtSUFRVRkpUbDlUUlZCQlVrRlVUMUlpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRVJQVFVGSlRsOVRSVkJCVWtGVVQxSWdaWGhwYzNSekNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdmJXOWphM012VUdGcGNsUmxjM1JJWld4d1pYSXVjMjlzTGxCaGFYSlVaWE4wU0dWc2NHVnlMbWRsZEZKbGMyVnlkbVZ6S0NrZ0xUNGdZbmwwWlhNc0lHSjVkR1Z6TENCMWFXNTBOalE2Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6ZFhOb2FYTjNZWEF0ZGpJdlkyOXVkSEpoWTNSekwyMXZZMnR6TDFCaGFYSlVaWE4wU0dWc2NHVnlMbk52YkM1UVlXbHlWR1Z6ZEVobGJIQmxjaTVuWlhSU1pYTmxjblpsY3pvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0p5WlhObGNuWmxNQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djbVZ6WlhKMlpUQWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW5KbGMyVnlkbVV4SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ5WlhObGNuWmxNU0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhOaUF2THlBaVlteHZZMnRVYVcxbGMzUmhiWEJNWVhOMElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCaWJHOWphMVJwYldWemRHRnRjRXhoYzNRZ1pYaHBjM1J6Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZjM1Z6YUdsemQyRndMWFl5TDJOdmJuUnlZV04wY3k5dGIyTnJjeTlRWVdseVZHVnpkRWhsYkhCbGNpNXpiMnd1VUdGcGNsUmxjM1JJWld4d1pYSXVYM1Z3WkdGMFpTaGlZV3hoYm1ObE1Eb2dZbmwwWlhNc0lHSmhiR0Z1WTJVeE9pQmllWFJsY3l3Z1gzSmxjMlZ5ZG1Vd09pQmllWFJsY3l3Z1gzSmxjMlZ5ZG1VeE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1gzVndaR0YwWlRvS0lDQWdJSEJ5YjNSdklEUWdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlJZ29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdKNWRHVmpJREl3SUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1lqdzlDaUFnSUNCaWVpQmZkWEJrWVhSbFgySnZiMnhmWm1Gc2MyVkFNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaWVYUmxZeUF5TUNBdkx5QXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlLSUNBZ0lHSThQUW9nSUNBZ1lub2dYM1Z3WkdGMFpWOWliMjlzWDJaaGJITmxRRE1LSUNBZ0lHbHVkR05mTWlBdkx5QXhDZ3BmZFhCa1lYUmxYMkp2YjJ4ZmJXVnlaMlZBTkRvS0lDQWdJR0Z6YzJWeWRDQXZMeUJWYm1semQyRndWakk2SUU5V1JWSkdURTlYQ2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUdKNlpYSnZDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUF5TkNBdkx5QXdlREF4TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBeU5DQXZMeUF3ZURBeE1EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUySUM4dklDSmliRzlqYTFScGJXVnpkR0Z0Y0V4aGMzUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklHSnNiMk5yVkdsdFpYTjBZVzF3VEdGemRDQmxlR2x6ZEhNS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCaWVpQmZkWEJrWVhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lHSjZJRjkxY0dSaGRHVmZZV1owWlhKZmFXWmZaV3h6WlVBNENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdZbm9nWDNWd1pHRjBaVjloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhOeUF2THlBaWNISnBZMlV3UTNWdGRXeGhkR2wyWlV4aGMzUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklIQnlhV05sTUVOMWJYVnNZWFJwZG1WTVlYTjBJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRlZSTVRFeWVERXhNaTVsYm1OdlpHVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTJGc2JITjFZaUJWVVRFeE1uZ3hNVEl1ZFhGa2FYWUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWWlvS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpJREUzSUM4dklDSndjbWxqWlRCRGRXMTFiR0YwYVhabFRHRnpkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRnZ0x5OGdJbkJ5YVdObE1VTjFiWFZzWVhScGRtVk1ZWE4wSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ3Y21salpURkRkVzExYkdGMGFYWmxUR0Z6ZENCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyRnNiSE4xWWlCVlVURXhNbmd4TVRJdVpXNWpiMlJsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1ZWRXhNVEo0TVRFeUxuVnhaR2wyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdJcUNpQWdJQ0JpS3dvZ0lDQWdZbmwwWldNZ01UZ2dMeThnSW5CeWFXTmxNVU4xYlhWc1lYUnBkbVZNWVhOMElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbDkxY0dSaGRHVmZZV1owWlhKZmFXWmZaV3h6WlVBNE9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JpZVhSbFl5QXlNQ0F2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKeVpYTmxjblpsTUNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0o1ZEdWaklESXdJQzh2SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVpnb2dJQ0FnWWlZS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKeVpYTmxjblpsTVNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXhOaUF2THlBaVlteHZZMnRVYVcxbGMzUmhiWEJNWVhOMElnb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpY21WelpYSjJaVEFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSEpsYzJWeWRtVXdJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdKOENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW5KbGMyVnlkbVV4SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ5WlhObGNuWmxNU0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbndLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRVeVlXUTBZVEFnTHk4Z2JXVjBhRzlrSUNKVGVXNWpLSFZwYm5ReU5UWXNkV2x1ZERJMU5pa2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2NtVjBjM1ZpQ2dwZmRYQmtZWFJsWDJKdmIyeGZabUZzYzJWQU16b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUY5MWNHUmhkR1ZmWW05dmJGOXRaWEpuWlVBMENnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM04xYzJocGMzZGhjQzEyTWk5amIyNTBjbUZqZEhNdmJXOWphM012VUdGcGNsUmxjM1JJWld4d1pYSXVjMjlzTGxCaGFYSlVaWE4wU0dWc2NHVnlMbDl0YVc1MFJtVmxLRjl5WlhObGNuWmxNRG9nWW5sMFpYTXNJRjl5WlhObGNuWmxNVG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LWDIxcGJuUkdaV1U2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpWm1GamRHOXllU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dabUZqZEc5eWVTQmxlR2x6ZEhNS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9UTXpNakZqWmpNZ0x5OGdiV1YwYUc5a0lDSm1aV1ZVYnlncFlXUmtjbVZ6Y3lJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWXlBMklDOHZJR0ZrWkhJZ1FVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVZrMVNFWkxVUW9nSUNBZ0lUMEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKclRHRnpkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYTB4aGMzUWdaWGhwYzNSekNpQWdJQ0JpZWlCZmJXbHVkRVpsWlY5bGJITmxYMkp2WkhsQU9Rb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdZbm9nWDIxcGJuUkdaV1ZmWVdaMFpYSmZhV1pmWld4elpVQXhNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2hWYm1semQyRndMbTExYkFvZ0lDQWdZMkZzYkhOMVlpQk5ZWFJvTG5OeGNuUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdZMkZzYkhOMVlpQk5ZWFJvTG5OeGNuUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0JpUGdvZ0lDQWdZbm9nWDIxcGJuUkdaV1ZmWVdaMFpYSmZhV1pmWld4elpVQXhNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUnZkR0ZzVTNWd2NHeDVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QjBiM1JoYkZOMWNIQnNlU0JsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVMWhkR2hWYm1semQyRndMbk4xWWdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psVFdGMGFGVnVhWE4zWVhBdWJYVnNDaUFnSUNCd2RYTm9hVzUwSURVS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUZWdWFYTjNZWEF1YlhWc0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVTFoZEdoVmJtbHpkMkZ3TG1Ga1pBb2dJQ0FnWWk4S0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQZ29nSUNBZ1lub2dYMjFwYm5SR1pXVmZZV1owWlhKZmFXWmZaV3h6WlVBeE1nb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmpZV3hzYzNWaUlGOXRhVzUwQ2dwZmJXbHVkRVpsWlY5aFpuUmxjbDlwWmw5bGJITmxRREV5T2dvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwZmJXbHVkRVpsWlY5bGJITmxYMkp2WkhsQU9Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJR0o2SUY5dGFXNTBSbVZsWDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlhMHhoYzNRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWWlCZmJXbHVkRVpsWlY5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzTjFjMmhwYzNkaGNDMTJNaTlqYjI1MGNtRmpkSE12Ylc5amEzTXZVR0ZwY2xSbGMzUklaV3h3WlhJdWMyOXNMbEJoYVhKVVpYTjBTR1ZzY0dWeUxsOXRhVzUwS0hSdk9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BmYldsdWREb0tJQ0FnSUhCeWIzUnZJRElnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2ZEdGc1UzVndjR3g1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUIwYjNSaGJGTjFjSEJzZVNCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUZWdWFYTjNZWEF1WVdSa0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIzUmhiRk4xY0hCc2VTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ1lubDBaV01nTVRRZ0x5OGdJbUpoYkdGdVkyVlBaaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxUV0YwYUZWdWFYTjNZWEF1WVdSa0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZeUEySUM4dklHRmtaSElnUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVmsxU0VaTFVRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTWpFZ0x5OGdiV1YwYUc5a0lDSlVjbUZ1YzJabGNpaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkREkxTmlraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNOMWMyaHBjM2RoY0MxMk1pOWpiMjUwY21GamRITXZiVzlqYTNNdlVHRnBjbFJsYzNSSVpXeHdaWEl1YzI5c0xsQmhhWEpVWlhOMFNHVnNjR1Z5TGw5aGNIQnliM1psS0c5M2JtVnlPaUJpZVhSbGN5d2djM0JsYm1SbGNqb2dZbmwwWlhNc0lIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWDJGd2NISnZkbVU2Q2lBZ0lDQndjbTkwYnlBeklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF4T1NBdkx5QWlZV3hzYjNkaGJtTmxJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFNFpUQTVORFl4SUM4dklHMWxkR2h2WkNBaVFYQndjbTkyWVd3b1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUXlOVFlwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl6ZFhOb2FYTjNZWEF0ZGpJdlkyOXVkSEpoWTNSekwyMXZZMnR6TDFCaGFYSlVaWE4wU0dWc2NHVnlMbk52YkM1UVlXbHlWR1Z6ZEVobGJIQmxjaTVmZEhKaGJuTm1aWElvWm5KdmJUb2dZbmwwWlhNc0lIUnZPaUJpZVhSbGN5d2dkbUZzZFdVNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwZmRISmhibk5tWlhJNkNpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2MyaGhNalUyQ2lBZ0lDQmllWFJsWXlBeE5DQXZMeUFpWW1Gc1lXNWpaVTltSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZOWVhSb1ZXNXBjM2RoY0M1emRXSUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBaVltRnNZVzVqWlU5bUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WTllYUm9WVzVwYzNkaGNDNWhaR1FLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW53S0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdNakVnTHk4Z2JXVjBhRzlrSUNKVWNtRnVjMlpsY2loaFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWRESTFOaWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmMzVnphR2x6ZDJGd0xYWXlMMk52Ym5SeVlXTjBjeTl0YjJOcmN5OVFZV2x5VkdWemRFaGxiSEJsY2k1emIyd3VVR0ZwY2xSbGMzUklaV3h3WlhJdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQUNBQkJpWVpBQWgxYm14dlkydGxaQVNEdXRmTUJCVWZmSFVoQVFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDM1J2ZEdGc1UzVndjR3g1SUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCblJ2YTJWdU1BWjBiMnRsYmpFSWNtVnpaWEoyWlRBSWNtVnpaWEoyWlRFSFptRmpkRzl5ZVFFQkJXdE1ZWE4wQ1dKaGJHRnVZMlZQWmhCRVQwMUJTVTVmVTBWUVFWSkJWRTlTRW1Kc2IyTnJWR2x0WlhOMFlXMXdUR0Z6ZEJSd2NtbGpaVEJEZFcxMWJHRjBhWFpsVEdGemRCUndjbWxqWlRGRGRXMTFiR0YwYVhabFRHRnpkQWxoYkd4dmQyRnVZMlVPLy8vLy8vLy8vLy8vLy8vLy8vOEVLSkdJWVFVVkgzeDFnQ0QvLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy93VUJBQUFBQURFWVFBQ3RKd1VvWnljUEtHY25DeWNHWnljSEp3Wm5Kd2duQm1jbkNTaG5Kd29vWnljUUltY25FU2huSnhJb1p5Y05LR2NrRmlsTVo0Qm9pM1BEeHB1NC9qMVJMc3hNOTFuTWVTT2ZleGViRC9yS3FhZGRVaXM1UUEvdnYvNWxaU29VV0VYSnZJMEZNcFJiNXJtREQrSHBsbXlJZTlLWTVWR3NnOGllL2FwVXdQSU1ldDloS0lMZkNWRDFxVkZqZmdNSHpjdE1aeThwaTR2R0FBQUFBQUFBQUFBeUNsQUNKdzlNWnljTE1RQm5KRU14R1JSRU1SaEVnaFFFS0hEOElBUVVReWFUQklCN0JDUUUrVGduRmdRTXBUWG9CUDZBQ2hjRUhyT2ptd1NZODVhQ0JQcjdhZ2dFR1l5WUlBUnQ5Qjl0QkVxTjBJOEVPVXhBR3dSakdFWGpCS1VNbEprRVMrakNvZ1NRZWxhQkJLTGsxQjhFZWZxMFpRUzlDNDVHTmhvQWpoUUF5QURXQVBzQkh3SytCRDhHZlFiaEIwUUhZQWQ4QitFSTBRamNDT2NJOGdrRkNSZ0pLd2srQUlvQ0FZditpLytraS8rTC9rOENUWW1LQVFFaUtJdi9nQUVEcFVFQU1vdi9nQUVDb2ljTW9Jd0FpLytNQVlzQWl3R2tRUUFXaS8rTEFFbE9BcUpMQWFDQUFRS2lqQUNNQVVMLzRvc0JqQUNKaS84b3FVSC85Q1FXakFGQy8rMktBZ0dML292L29FbUwvcWRFaVlvQ0FZditKd1NnaS8raEp3U3FTWXYrcGtTSmlnSUJLSXYvS0toQUFCR0wvb3YvbzBtTUFJdi9vb3YrcUVFQUJpUkVpd0JNaVNKQy8vZUtBUUdMLzRBUEFRQUFBQUFBQUFBQUFBQUFBQUFBbzRtS0FnR0wvb3Yvb29rMkdnRkpGU01TUkNjTFRHY2tRNGdJY0VzQ0ZTTU9SQ092VHdOTEFhdExBeFVqRGtSUEEwOENxMUJNRmxBclRGQ3dKRU0yR2dGSkZTTVNSRFlhQWtrVkl4SkVNUUFpSnd0bFJCSkVKd2RQQW1jbkNFeG5KRU1pUndJMkdnRkpGU01TUkNJcFpVUW5ES2hFSWhZcFRHZUlDQTlHQWttSUNBbElTVTREVGdOSXNUSUtJaWNIWlVTQkdGc2xzaEFpc2hraXNnR3lHQ3F5R3JJYXM3UStWd1FBU1U0RHNUSUtJaWNJWlVTQkdGc2xzaEFpc2hraXNnR3lHQ3F5R3JJYXM3UStWd1FBU1U0RVRFc0NpUDdZVGdOTEFvaiswVTRDVElnSWZpSW5CV1ZNU1U4Q1JDaW9RUUR2c1NJbkMyVkVnUmhiSmJJUUlySVpJcklCc2hpQUJJTU8vNFN5R3JPMFBrbEZDMWNFQUVsRkRERUFFa0VBbkxGTENZRWNXeVd5RUNLeUdTS3lBYklZZ0FRRlJ6RDhzaHF6dEQ1WEJBQkpSUTBvcFVFQWNVc0xKeGVwUVFCcEpFUkxDMGtvcFVSTENVeUlDS1ZMQlVzRlN3bExDWWdITTBzQlFRQVJJaWNKWlVRaUp3cGxSSWorU1NjTlRHZExBMGtWSXc1RUk2OU1Td0dyU3dSSkZTTU9SRXNDcXpFQVR3SlFURkNBQkVmOVFXcE1VTEFrRmlsTVowc01TUlVqRGtTcksweFFzQ1JESWtML2xFc0tKd1lTUkVzRFN3T0kvZnFJL1llQjZBY1dURXNCaVAzWlJRMG5Ca3lJQ0NSQy8zQkxBMHNCU1U0Q2lQM1lTd21pU3dSUEFvajl6a3NJb29qOVNFVU1RdjlSSWpZYUFVa1ZJeEpFSWlsbFJDY01xRVFpRmlsTVo0Z0dja1lDU1lnR2JFaEpUZ0pPQTBnaUp3ZGxSQ0luQ0dWRXNUSUtUd0tCR0Z0SlRnVWxzaEFpc2hraXNnR3lHQ3F5R3JJYXM3UStWd1FBc1RJS1R3S0JHRnRKVGdVbHNoQWlzaGtpc2dHeUdDcXlHcklhczdRK1Z3UUFNZ29CSnc1TVVMNG9UZ0pOU1U0RlR3UlBCSWdHMms0RElpY0ZaVVJMQVU4RWlQMHRTd0dpU1U0RFRnUk1Ud09JL1I5TW9rd29wVUVBMFVrb3BVRUF5eVJFTWdwSkFTY09URkJKdmloT0FrMUxCa2xPQTRqODVVc0J2RWkvSWljRlpVUkxBWWo4MWljRlRHZEpGU01PUkNPdlNVVU5xMHduQmxCTVVDY1ZURkN3c1RJS0piSVFJcklaSXJJQlN3YXlHQ3F5R3JJYXM3UStWd1FBc1RJS0piSVFJcklaSXJJQlN3YXlHQ3F5R3JJYXM3UStWd1FBU3dsTENZZ0ZhMHNDUVFBUklpY0paVVFpSndwbFJJajhnU2NOVEdkTEFVa1ZJdzVFU3dwSlRnS3JTd0pKRlNNT1JFOENxekVBU3dKUVN3RlFTd3RRZ0FRTmdzWmJURkN3SkJZcFRHZFFLMHhRc0NSRElrTC9NaUpIQ1NnMkdnRkhBaFZKVGdJakVrUTJHZ0pKVGdJVlNVNENJeEpFTmhvRFNVNENGU01TUkRZYUJFa2lXWUVDQ0VzQkZSSkVWd0lBVENJcFpVUW5ES2hFSWhaSlRnSXBUR2NvcFVBQUIwc0VLS1ZCQWVVa1JJZ0VzRVlDU1VVVGlBU29TRVVUU0VzSHBVRUJ5a3NFU3hHa1FRSENKRVFpSndkbFRFbE9Ba1VTUkNJbkNHVk1SUkZFU3dNVFFRR2pTd0pMRHhOQkFac2tSRXNCRlVsRkNVRUFTTEV4QUNPdlNVc0pVRWtWSXdraldFeExCMUJKRlNNSkkxaExDaFpYQmdKTEJWQkxCb0VZV3lXeUVDS3lHU0t5QWJJWWdBVEc0VXIyc2hwUEE3SWFUd0t5R2t5eUdySWFzN0V5Q2tzUWdSaGJKYklRSXJJWklySUJzaGdxc2hxeUdyTzBQbGNFQUVsRkRiRXlDa3NRZ1JoYkpiSVFJcklaSXJJQnNoZ3FzaHF5R3JPMFBsY0VBRVVNU3hJbkJLQkxDS0VuQktwSlJReWxRUUR2U3dzbkJLQkxDcUVuQktwRkRrc1FKd1NnU3dXaEp3U3FTVVVLU3d1a1FRRElTd29uQktCTENhRW5CS3BGRFVzTktLVkFBQWRMRENpbFFRQ3BKRVNCNkFjV1N3eEpUZ0pMQVlqNnVZRURGa3NSU1U0RVN3R0krcXhQQWt5SStwSkxEMGxPQkU4RGlQcWNTeEpKVGdkUEE0ajZrb2o2ZTRqNmpFc1dTVTRDU3hkSlRnU0krbitCd0lROUZvajZkNmRFVHdSUEEwOENUd09JQTBKSkZTTU9SQ092VEVzQnEwc0lJdzVFU3dsTEFxdExBeFVqRGtSUEEwc0RxMHNISXc1RVN3aFBCS3N4QUU4RVVFOENVRThDVUV4UVN3TlFnQVF0S3ZyNFRGQ3dKQllwVEdja1F5SkMvMVJKUlExQy96OUpSUTVDL3hnaVF2NWlJa0wrT3lKQy9oZzJHZ0VWSXhKRUlpbGxSQ2NNcUVRaUZpbE1aeUluQjJWRUlpY0laVVN4TWdwUEFvRVlXeVd5RUNLeUdTS3lBYklZS3JJYXNocXpJaWNKWlVVQlJMRXlDa3lCR0ZzbHNoQWlzaGtpc2dHeUdDcXlHcklhc3lJbkNtVkZBVVFrRmlsTVp5UkRJaWxsUkNjTXFFUWlGaWxNWjdFeUNpSW5CMlZFZ1JoYkpiSVFJcklaSXJJQnNoZ3FzaHF5R3JPeE1nb2lKd2hsUklFWVd5V3lFQ0t5R1NLeUFiSVlLcklhc2hxenRENVhCQUMwUGxjRUFDSW5DV1ZFSWljS1pVU0lBaHdrRmlsTVp5UkROaG9CU1JVakVrUTJHZ0pKRlNNU1JERUFUZ0tJQTZVbkZyQWtRellhQVVrVkl4SkVOaG9DU1JVakVrUXhBRTRDaUFPekp4YXdKRU0yR2dGSEFoVWpFa1EyR2dKSlRnSVZJeEpFTmhvRFNVNENGU01TUkRFQVVBRW5FMHhRdmloT0FrMG5GNmxCQUNjeEFFc0RTVThDVUFFbkUweFF2aWhPQWsxTEFvajRxakVBVHdKTVVBRW5FMHhRU2J4SVRMOUxBa3NDU3dLSUEwNG5GckFrUXpZYUFVY0NGU01TUkRZYUFrbE9Ba2tWSXhKRU5ob0RTVTREU1JVakVrUTJHZ1JKRlNNU1JEWWFCVWtWZ1FnU1JCYzJHZ1pKRlNNU1JEWWFCMGtWSXhKRU1nY1dTd1NtUkVzR0FZQUdibTl1WTJWelRGQkp2aWhPQWswbkRLQkxBYnhJVEVzQnZ5T3ZJaWNQWlVSTEFVeFFTUlVqQ1NOWWdBSVpBVXhRZ0NCdWNlMnVFckc1ZjAwZllEY1A3eEFRWDZMNnJnRW1FVW9XbkdTRVhXRW15VThLVUU4SlVFOElVRThEVUU4R1VBSlBBa3hRU1JVakNTTllVQUpQQTRFYkNVOERUd01IQUlFTXIwNENVQUpYREJSUVNTY0dFMEVBRkVsTEJCSkJBQTBrUkVzRFN3TkxBNGdDTlNSRElrTC84Q0luQzJWRUsweFFzQ1JESWljSFpVUXJURkN3SkVNaUp3aGxSQ3RNVUxBa1F5SW5FV1ZFU1JVakRrUWpyNnNyVEZDd0pFTWlKeEpsUkVrVkl3NUVJNitySzB4UXNDUkRJaWNOWlVSSkZTTU9SQ092cXl0TVVMQWtReUluQldWRVNSVWpEa1FqcjZzclRGQ3dKRU1pSnc5bFJDdE1VTEFrUXlJbkNXVkVJaWNLWlVRaUp4QmxSSW1LQkFBb1NZdjhKeFNtUVFDMmkvMG5GS1pCQUs0a1JJRUlyeklIRmljWXFrc0JURkF5QnhZbkdLcFBBa3hRRllFSUNWdEpqQUFpSnhCbFJBbEpqQUZCQUVLTC9paXBRUUE3aS84b3FVRUFOQ0luRVdWRWkvK0k5dlNML29qM0I0c0JGa3hMQWFOUEFxQW5FVXhuSWljU1pVU0wvb2oyMTR2L2lQYnFUd0tqb0NjU1RHZUwvQ2NVckNjSlRHZUwvU2NVckNjS1RHY25FSXNBWnlJbkNXVkVTUlVqRGtRanIweExBYXNpSndwbFJFa1ZJdzVFVHdLclVJQUVWU3JVb0V4UXNJa2lRdjlQaWdJQklrY0NzU0luQzJWRWdSaGJKYklRSXJJWklySUJzaGlBQkpNeUhQT3lHck8wUGxjRUFFa25CaE5KSWljTlpVeE9Ba1JCQUZpTEJTaXBRUUJNaS82TC80ajJHNGoxcUVtTUFZc0ZpUFdnU1l3Q3BVRUFNeUluQldWRWl3RkpUZ0tMQWtsT0JJajE0NGoxOUlFRkZrOENUSWoxNjA4Q2lQWEVva21NQUNpbFFRQUhpd09MQUlnQUZZc0VqQUNKaXdVb3FVSC85Q0lXSncxTVowTC82NG9DQUNJbkJXVkVpLytJOVpJbkJVeG5pLzRCSnc1TVVFbStLRTRDVFl2L2lQVjhTd0c4U0wrTC94VWpEa1FqcjR2L3F5Y0dpLzVRVEZBbkZVeFFzSW1LQXdDTC9ZditVRWtCSnhOTVVFbThTSXYvdjR2L0ZTTU9SQ092aS8rclVJQUVHT0NVWVV4UXNJbUtBd0NML1FFbkRreFFTYjRvVGdKTmkvK0k5UzVMQWJ4SXY0ditBU2NPVEZCSnZpaE9BazJMLzRqMUNVc0J2RWkvaS84Vkl3NUVJNitMLzZ1TC9ZditVRXhRSnhWTVVMQ0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlN5bmMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc2VydmUwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlc2VydmUxIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJNaW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDEiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkJ1cm4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50MSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJTd2FwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQwSW4iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50MUluIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDBPdXQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50MU91dCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJBcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
