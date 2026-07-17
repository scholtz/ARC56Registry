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

namespace Arc56.Generated.Parthkk90.Algorand_cresca.CrescaCalendarPayments_4bb43709
{


    //
    // 
    //    Scheduled and recurring payment contract on Algorand.
    //
    //    State layout:
    //    - Global: total_schedules, total_executed, schedule_count_per_user (BoxMap)
    //    - Boxes:  one Box<Schedule> per (payer, schedule_id) pair
    //    
    //
    public class CrescaCalendarPaymentsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CrescaCalendarPaymentsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Schedule : AVMObjectType
            {
                public Algorand.Address Payer { get; set; }

                public Algorand.Address Recipient { get; set; }

                public ulong Amount { get; set; }

                public ulong ExecuteAt { get; set; }

                public ulong IntervalSeconds { get; set; }

                public ulong Occurrences { get; set; }

                public ulong ExecutedCount { get; set; }

                public bool Active { get; set; }

                public ulong EscrowBalance { get; set; }

                public ulong CreatedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPayer.From(Payer);
                    ret.AddRange(vPayer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecipient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vRecipient.From(Recipient);
                    ret.AddRange(vRecipient.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecuteAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExecuteAt.From(ExecuteAt);
                    ret.AddRange(vExecuteAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIntervalSeconds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vIntervalSeconds.From(IntervalSeconds);
                    ret.AddRange(vIntervalSeconds.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOccurrences = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOccurrences.From(Occurrences);
                    ret.AddRange(vOccurrences.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutedCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExecutedCount.From(ExecutedCount);
                    ret.AddRange(vExecutedCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vActive.From(Active);
                    ret.AddRange(vActive.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEscrowBalance.From(EscrowBalance);
                    ret.AddRange(vEscrowBalance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Schedule Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Schedule();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPayer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayer = vPayer.ToValue();
                    if (valuePayer is Algorand.Address vPayerValue) { ret.Payer = vPayerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecipient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRecipient.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRecipient = vRecipient.ToValue();
                    if (valueRecipient is Algorand.Address vRecipientValue) { ret.Recipient = vRecipientValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecuteAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExecuteAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExecuteAt = vExecuteAt.ToValue();
                    if (valueExecuteAt is ulong vExecuteAtValue) { ret.ExecuteAt = vExecuteAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIntervalSeconds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIntervalSeconds.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIntervalSeconds = vIntervalSeconds.ToValue();
                    if (valueIntervalSeconds is ulong vIntervalSecondsValue) { ret.IntervalSeconds = vIntervalSecondsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOccurrences = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOccurrences.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOccurrences = vOccurrences.ToValue();
                    if (valueOccurrences is ulong vOccurrencesValue) { ret.Occurrences = vOccurrencesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutedCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExecutedCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExecutedCount = vExecutedCount.ToValue();
                    if (valueExecutedCount is ulong vExecutedCountValue) { ret.ExecutedCount = vExecutedCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActive = vActive.ToValue();
                    if (valueActive is bool vActiveValue) { ret.Active = vActiveValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEscrowBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEscrowBalance = vEscrowBalance.ToValue();
                    if (valueEscrowBalance is ulong vEscrowBalanceValue) { ret.EscrowBalance = vEscrowBalanceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Schedule);
                }
                public bool Equals(Schedule? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Schedule left, Schedule right)
                {
                    return EqualityComparer<Schedule>.Default.Equals(left, right);
                }
                public static bool operator !=(Schedule left, Schedule right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class ScheduleCreatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 160, 162, 88, 146 };
                public const string Signature = "ScheduleCreated(address,uint64,address,uint64,uint64,bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public ulong Field2 { get; set; }
                public Algorand.Address Field3 { get; set; }
                public ulong Field4 { get; set; }
                public ulong Field5 { get; set; }
                public bool Field6 { get; set; }

                public static ScheduleCreatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ScheduleCreatedEvent();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is Algorand.Address vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is bool vField6Value) { ret.Field6 = vField6Value; }
                    return ret;

                }

            }

            public class PaymentExecutedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 188, 191, 96, 191 };
                public const string Signature = "PaymentExecuted(address,uint64,address,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public ulong Field2 { get; set; }
                public Algorand.Address Field3 { get; set; }
                public ulong Field4 { get; set; }
                public ulong Field5 { get; set; }

                public static PaymentExecutedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PaymentExecutedEvent();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is Algorand.Address vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
                    return ret;

                }

            }

            public class ScheduleCompletedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 102, 113, 42, 7 };
                public const string Signature = "ScheduleCompleted(address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public ulong Field2 { get; set; }

                public static ScheduleCompletedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ScheduleCompletedEvent();
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

            public class ScheduleCancelledEvent
            {
                public static readonly byte[] Selector = new byte[4] { 169, 119, 204, 126 };
                public const string Signature = "ScheduleCancelled(address,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public ulong Field2 { get; set; }
                public ulong Field3 { get; set; }

                public static ScheduleCancelledEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ScheduleCancelledEvent();
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
                    return ret;

                }

            }

        }

        ///<summary>
        ///Create a one-time or recurring payment schedule.
        ///The caller must attach a PaymentTransaction covering amount * occurrences μALGO (plus the contract's min-balance bump for the new Box storage — handled separately via fund_contract()).
        ///Returns the new schedule_id.
        ///</summary>
        /// <param name="payment_txn"> </param>
        /// <param name="recipient"> </param>
        /// <param name="amount"> </param>
        /// <param name="execute_at"> </param>
        /// <param name="interval_seconds"> </param>
        /// <param name="occurrences"> </param>
        public async Task<ulong> CreateSchedule(PaymentTransaction payment_txn, Algorand.Address recipient, ulong amount, ulong execute_at, ulong interval_seconds, ulong occurrences, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 98, 120, 144, 140 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var execute_atAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); execute_atAbi.From(execute_at);
            var interval_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); interval_secondsAbi.From(interval_seconds);
            var occurrencesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); occurrencesAbi.From(occurrences);

            var result = await base.CallApp(new List<object> { abiHandle, payment_txn, recipientAbi, amountAbi, execute_atAbi, interval_secondsAbi, occurrencesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateSchedule_Transactions(PaymentTransaction payment_txn, Algorand.Address recipient, ulong amount, ulong execute_at, ulong interval_seconds, ulong occurrences, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 98, 120, 144, 140 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var execute_atAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); execute_atAbi.From(execute_at);
            var interval_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); interval_secondsAbi.From(interval_seconds);
            var occurrencesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); occurrencesAbi.From(occurrences);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_txn, recipientAbi, amountAbi, execute_atAbi, interval_secondsAbi, occurrencesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Convenience: schedule a single future payment.
        ///</summary>
        /// <param name="payment_txn"> </param>
        /// <param name="recipient"> </param>
        /// <param name="amount"> </param>
        /// <param name="execute_at"> </param>
        public async Task<ulong> CreateOneTimePayment(PaymentTransaction payment_txn, Algorand.Address recipient, ulong amount, ulong execute_at, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 168, 232, 207, 112 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var execute_atAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); execute_atAbi.From(execute_at);

            var result = await base.CallApp(new List<object> { abiHandle, payment_txn, recipientAbi, amountAbi, execute_atAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateOneTimePayment_Transactions(PaymentTransaction payment_txn, Algorand.Address recipient, ulong amount, ulong execute_at, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 168, 232, 207, 112 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var execute_atAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); execute_atAbi.From(execute_at);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_txn, recipientAbi, amountAbi, execute_atAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Convenience: schedule a recurring payment every N days.
        ///</summary>
        /// <param name="payment_txn"> </param>
        /// <param name="recipient"> </param>
        /// <param name="amount"> </param>
        /// <param name="first_execution_at"> </param>
        /// <param name="interval_days"> </param>
        /// <param name="occurrences"> </param>
        public async Task<ulong> CreateRecurringPayment(PaymentTransaction payment_txn, Algorand.Address recipient, ulong amount, ulong first_execution_at, ulong interval_days, ulong occurrences, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 74, 149, 104, 126 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var first_execution_atAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); first_execution_atAbi.From(first_execution_at);
            var interval_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); interval_daysAbi.From(interval_days);
            var occurrencesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); occurrencesAbi.From(occurrences);

            var result = await base.CallApp(new List<object> { abiHandle, payment_txn, recipientAbi, amountAbi, first_execution_atAbi, interval_daysAbi, occurrencesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateRecurringPayment_Transactions(PaymentTransaction payment_txn, Algorand.Address recipient, ulong amount, ulong first_execution_at, ulong interval_days, ulong occurrences, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment_txn });
            byte[] abiHandle = { 74, 149, 104, 126 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var first_execution_atAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); first_execution_atAbi.From(first_execution_at);
            var interval_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); interval_daysAbi.From(interval_days);
            var occurrencesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); occurrencesAbi.From(occurrences);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment_txn, recipientAbi, amountAbi, first_execution_atAbi, interval_daysAbi, occurrencesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Execute a due scheduled payment. Anyone can call this (keeper/bot pattern).
        ///Reverts if: - Schedule doesn't exist or is inactive. - Payment is not yet due. - Escrow is insufficient.
        ///</summary>
        /// <param name="payer"> </param>
        /// <param name="schedule_id"> </param>
        public async Task<bool> ExecuteSchedule(Algorand.Address payer, ulong schedule_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 107, 155, 210 };
            var payerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payerAbi.From(payer);
            var schedule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); schedule_idAbi.From(schedule_id);

            var result = await base.CallApp(new List<object> { abiHandle, payerAbi, schedule_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ExecuteSchedule_Transactions(Algorand.Address payer, ulong schedule_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 107, 155, 210 };
            var payerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payerAbi.From(payer);
            var schedule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); schedule_idAbi.From(schedule_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, payerAbi, schedule_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cancel a schedule and refund remaining escrow to the payer.
        ///Only the payer can cancel.
        ///</summary>
        /// <param name="schedule_id"> </param>
        public async Task<bool> CancelSchedule(ulong schedule_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 18, 181, 101 };
            var schedule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); schedule_idAbi.From(schedule_id);

            var result = await base.CallApp(new List<object> { abiHandle, schedule_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CancelSchedule_Transactions(ulong schedule_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 18, 181, 101 };
            var schedule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); schedule_idAbi.From(schedule_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, schedule_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check whether a schedule is currently executable.
        ///</summary>
        /// <param name="payer"> </param>
        /// <param name="schedule_id"> </param>
        public async Task<bool> IsExecutable(Algorand.Address payer, ulong schedule_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 113, 81, 64 };
            var payerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payerAbi.From(payer);
            var schedule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); schedule_idAbi.From(schedule_id);

            var result = await base.SimApp(new List<object> { abiHandle, payerAbi, schedule_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsExecutable_Transactions(Algorand.Address payer, ulong schedule_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 113, 81, 64 };
            var payerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payerAbi.From(payer);
            var schedule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); schedule_idAbi.From(schedule_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, payerAbi, schedule_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the Unix timestamp of the next due execution (0 if inactive).
        ///</summary>
        /// <param name="payer"> </param>
        /// <param name="schedule_id"> </param>
        public async Task<ulong> GetNextExecutionTime(Algorand.Address payer, ulong schedule_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 35, 205, 178 };
            var payerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payerAbi.From(payer);
            var schedule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); schedule_idAbi.From(schedule_id);

            var result = await base.SimApp(new List<object> { abiHandle, payerAbi, schedule_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetNextExecutionTime_Transactions(Algorand.Address payer, ulong schedule_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 35, 205, 178 };
            var payerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payerAbi.From(payer);
            var schedule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); schedule_idAbi.From(schedule_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, payerAbi, schedule_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetTotalSchedules(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 101, 76, 232 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalSchedules_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 101, 76, 232 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetTotalExecuted(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 247, 249, 23 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalExecuted_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 247, 249, 23 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        public async Task<ulong> GetUserScheduleCount(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 74, 34, 52 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetUserScheduleCount_Transactions(Algorand.Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 74, 34, 52 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Increase the contract's minimum balance to cover Box storage costs.
        ///Each Schedule Box costs ~0.0025 ALGO + byte-based fees. Call this before creating schedules if the contract is underfunded.
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

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3Jlc2NhQ2FsZW5kYXJQYXltZW50cyIsImRlc2MiOiJcbiAgICBTY2hlZHVsZWQgYW5kIHJlY3VycmluZyBwYXltZW50IGNvbnRyYWN0IG9uIEFsZ29yYW5kLlxuXG4gICAgU3RhdGUgbGF5b3V0OlxuICAgIC0gR2xvYmFsOiB0b3RhbF9zY2hlZHVsZXMsIHRvdGFsX2V4ZWN1dGVkLCBzY2hlZHVsZV9jb3VudF9wZXJfdXNlciAoQm94TWFwKVxuICAgIC0gQm94ZXM6ICBvbmUgQm94PFNjaGVkdWxlPiBwZXIgKHBheWVyLCBzY2hlZHVsZV9pZCkgcGFpclxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTY2hlZHVsZSI6W3sibmFtZSI6InBheWVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJyZWNpcGllbnQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJleGVjdXRlX2F0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImludGVydmFsX3NlY29uZHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoib2NjdXJyZW5jZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZXhlY3V0ZWRfY291bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWN0aXZlIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJlc2Nyb3dfYmFsYW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjcmVhdGVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfc2NoZWR1bGUiLCJkZXNjIjoiQ3JlYXRlIGEgb25lLXRpbWUgb3IgcmVjdXJyaW5nIHBheW1lbnQgc2NoZWR1bGUuXG5UaGUgY2FsbGVyIG11c3QgYXR0YWNoIGEgUGF5bWVudFRyYW5zYWN0aW9uIGNvdmVyaW5nIGFtb3VudCAqIG9jY3VycmVuY2VzIM68QUxHTyAocGx1cyB0aGUgY29udHJhY3QncyBtaW4tYmFsYW5jZSBidW1wIGZvciB0aGUgbmV3IEJveCBzdG9yYWdlIOKAlCBoYW5kbGVkIHNlcGFyYXRlbHkgdmlhIGZ1bmRfY29udHJhY3QoKSkuXG5SZXR1cm5zIHRoZSBuZXcgc2NoZWR1bGVfaWQuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4ZWN1dGVfYXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVydmFsX3NlY29uZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9jY3VycmVuY2VzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlNjaGVkdWxlQ3JlYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDYiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfb25lX3RpbWVfcGF5bWVudCIsImRlc2MiOiJDb252ZW5pZW5jZTogc2NoZWR1bGUgYSBzaW5nbGUgZnV0dXJlIHBheW1lbnQuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4ZWN1dGVfYXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiU2NoZWR1bGVDcmVhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ1IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZV9yZWN1cnJpbmdfcGF5bWVudCIsImRlc2MiOiJDb252ZW5pZW5jZTogc2NoZWR1bGUgYSByZWN1cnJpbmcgcGF5bWVudCBldmVyeSBOIGRheXMuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpcnN0X2V4ZWN1dGlvbl9hdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZXJ2YWxfZGF5cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib2NjdXJyZW5jZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiU2NoZWR1bGVDcmVhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ1IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4ZWN1dGVfc2NoZWR1bGUiLCJkZXNjIjoiRXhlY3V0ZSBhIGR1ZSBzY2hlZHVsZWQgcGF5bWVudC4gQW55b25lIGNhbiBjYWxsIHRoaXMgKGtlZXBlci9ib3QgcGF0dGVybikuXG5SZXZlcnRzIGlmOiAtIFNjaGVkdWxlIGRvZXNuJ3QgZXhpc3Qgb3IgaXMgaW5hY3RpdmUuIC0gUGF5bWVudCBpcyBub3QgeWV0IGR1ZS4gLSBFc2Nyb3cgaXMgaW5zdWZmaWNpZW50LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjaGVkdWxlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJQYXltZW50RXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlNjaGVkdWxlQ29tcGxldGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW5jZWxfc2NoZWR1bGUiLCJkZXNjIjoiQ2FuY2VsIGEgc2NoZWR1bGUgYW5kIHJlZnVuZCByZW1haW5pbmcgZXNjcm93IHRvIHRoZSBwYXllci5cbk9ubHkgdGhlIHBheWVyIGNhbiBjYW5jZWwuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjaGVkdWxlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJTY2hlZHVsZUNhbmNlbGxlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfZXhlY3V0YWJsZSIsImRlc2MiOiJDaGVjayB3aGV0aGVyIGEgc2NoZWR1bGUgaXMgY3VycmVudGx5IGV4ZWN1dGFibGUuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NoZWR1bGVfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbmV4dF9leGVjdXRpb25fdGltZSIsImRlc2MiOiJSZXR1cm5zIHRoZSBVbml4IHRpbWVzdGFtcCBvZiB0aGUgbmV4dCBkdWUgZXhlY3V0aW9uICgwIGlmIGluYWN0aXZlKS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY2hlZHVsZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RvdGFsX3NjaGVkdWxlcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RvdGFsX2V4ZWN1dGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXNlcl9zY2hlZHVsZV9jb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnVuZF9jb250cmFjdCIsImRlc2MiOiJJbmNyZWFzZSB0aGUgY29udHJhY3QncyBtaW5pbXVtIGJhbGFuY2UgdG8gY292ZXIgQm94IHN0b3JhZ2UgY29zdHMuXG5FYWNoIFNjaGVkdWxlIEJveCBjb3N0cyB+MC4wMDI1IEFMR08gKyBieXRlLWJhc2VkIGZlZXMuIENhbGwgdGhpcyBiZWZvcmUgY3JlYXRpbmcgc2NoZWR1bGVzIGlmIHRoZSBjb250cmFjdCBpcyB1bmRlcmZ1bmRlZC4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudF90eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4NzVdLCJlcnJvck1lc3NhZ2UiOiJBbGwgcGF5bWVudHMgZG9uZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3OSwxNDc5XSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODYyLDg3OCw4ODgsOTEzLDk0Miw5NDcsOTY2LDEwOTQsMTEyNywxMTMyLDExMzcsMTE0MiwxMTQ3LDExNTIsMTE1N10sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTI2XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IGVzY3JvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxMF0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBlc2Nyb3cgZnVuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDc0XSwiZXJyb3JNZXNzYWdlIjoiTXVzdCBzZW5kIHRvIGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTA1XSwiZXJyb3JNZXNzYWdlIjoiTm90IHlldCBleGVjdXRhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc3LDIwMywyMjcsMjQzLDI1OSwyOTEsMzIzLDM0NywzNzksNDQ1LDQ5NV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5OV0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCB0YXJnZXQgY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NTUsMTExNF0sImVycm9yTWVzc2FnZSI6IlNjaGVkdWxlIGFscmVhZHkgY29tcGxldGVkL2NhbmNlbGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0MCwxMDg5XSwiZXJyb3JNZXNzYWdlIjoiU2NoZWR1bGUgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEwMV0sImVycm9yTWVzc2FnZSI6IlVuYXV0aG9yaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2Nl0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MCwyMDYsMjMwLDI0NiwyNjIsMjk0LDMyNiwzNTAsMzgyLDQ0OCw0OThdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI4LDE0NThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnNjaGVkdWxlX2NvdW50cyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NDMsMTA5MiwxMjcwLDEzNzJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnNjaGVkdWxlcyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDQ5LDE0MzddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2V4ZWN1dGVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5MiwxNDMwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9zY2hlZHVsZXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg2XSwiZXJyb3JNZXNzYWdlIjoiZXhlY3V0ZV9hdCBtdXN0IGJlIGluIGZ1dHVyZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNCwyNzAsMzAyLDM1OCw0MDAsNDY2LDUxNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzgsMzEwLDMzNCwzNjYsNDA4LDQxNiw0MjQsNDMyLDQ3NCw0ODIsNTI0LDUzMiw1NDAsNTQ4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTkxXSwiZXJyb3JNZXNzYWdlIjoib2NjdXJyZW5jZXMgbXVzdCBiZSA+IDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTAsMzkyLDQ1OCw1MDhdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11UTNKbGMyTmhRMkZzWlc1a1lYSlFZWGx0Wlc1MGN5NWZYMkZzWjI5d2VWOWxiblJ5ZVhCdmFXNTBYM2RwZEdoZmFXNXBkQ2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnT0NBek1pQTRNeklLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0F3ZURBd0lEQjRNREF3TURBd01EQXdNREF3TURBd01DQXdlRGN6TmpNMk9EVm1JQ0owYjNSaGJGOXpZMmhsWkhWc1pYTWlJQ0owYjNSaGJGOWxlR1ZqZFhSbFpDSWdNSGc0TUNBd2VEWXpObVUzTkRWbUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2T0RnS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmMyTm9aV1IxYkdWeklEMGdSMnh2WW1Gc1UzUmhkR1VvVlVsdWREWTBLREFwS1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpZEc5MFlXeGZjMk5vWldSMWJHVnpJZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZPRGtLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmWlhobFkzVjBaV1FnUFNCSGJHOWlZV3hUZEdGMFpTaFZTVzUwTmpRb01Da3BDaUFnSUNCaWVYUmxZeUExSUM4dklDSjBiM1JoYkY5bGVHVmpkWFJsWkNJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZOamtLSUNBZ0lDOHZJR05zWVhOeklFTnlaWE5qWVVOaGJHVnVaR0Z5VUdGNWJXVnVkSE1vUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhOZ29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFl5TnpnNU1EaGpJREI0WVRobE9HTm1OekFnTUhnMFlUazFOamczWlNBd2VEazNObUk1WW1ReUlEQjRaRE14TW1JMU5qVWdNSGc1TkRjeE5URTBNQ0F3ZURreE1qTmpaR0l5SURCNE9EWTJOVFJqWlRnZ01IaGtNMlkzWmpreE55QXdlRGszTkdFeU1qTTBJREI0TVRVMk5EYzFZVGdnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZmYzJOb1pXUjFiR1VvY0dGNUxHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVkzSmxZWFJsWDI5dVpWOTBhVzFsWDNCaGVXMWxiblFvY0dGNUxHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbU55WldGMFpWOXlaV04xY25KcGJtZGZjR0Y1YldWdWRDaHdZWGtzWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0psZUdWamRYUmxYM05qYUdWa2RXeGxLR0ZrWkhKbGMzTXNkV2x1ZERZMEtXSnZiMndpTENCdFpYUm9iMlFnSW1OaGJtTmxiRjl6WTJobFpIVnNaU2gxYVc1ME5qUXBZbTl2YkNJc0lHMWxkR2h2WkNBaWFYTmZaWGhsWTNWMFlXSnNaU2hoWkdSeVpYTnpMSFZwYm5RMk5DbGliMjlzSWl3Z2JXVjBhRzlrSUNKblpYUmZibVY0ZEY5bGVHVmpkWFJwYjI1ZmRHbHRaU2hoWkdSeVpYTnpMSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjkwYjNSaGJGOXpZMmhsWkhWc1pYTW9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDNSdmRHRnNYMlY0WldOMWRHVmtLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5MWMyVnlYM05qYUdWa2RXeGxYMk52ZFc1MEtHRmtaSEpsYzNNcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKbWRXNWtYMk52Ym5SeVlXTjBLSEJoZVNsaWIyOXNJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWZmMyTm9aV1IxYkdWZmNtOTFkR1ZBTlNCdFlXbHVYMk55WldGMFpWOXZibVZmZEdsdFpWOXdZWGx0Wlc1MFgzSnZkWFJsUURZZ2JXRnBibDlqY21WaGRHVmZjbVZqZFhKeWFXNW5YM0JoZVcxbGJuUmZjbTkxZEdWQU55QnRZV2x1WDJWNFpXTjFkR1ZmYzJOb1pXUjFiR1ZmY205MWRHVkFPQ0J0WVdsdVgyTmhibU5sYkY5elkyaGxaSFZzWlY5eWIzVjBaVUE1SUcxaGFXNWZhWE5mWlhobFkzVjBZV0pzWlY5eWIzVjBaVUF4TUNCdFlXbHVYMmRsZEY5dVpYaDBYMlY0WldOMWRHbHZibDkwYVcxbFgzSnZkWFJsUURFeElHMWhhVzVmWjJWMFgzUnZkR0ZzWDNOamFHVmtkV3hsYzE5eWIzVjBaVUF4TWlCdFlXbHVYMmRsZEY5MGIzUmhiRjlsZUdWamRYUmxaRjl5YjNWMFpVQXhNeUJ0WVdsdVgyZGxkRjkxYzJWeVgzTmphR1ZrZFd4bFgyTnZkVzUwWDNKdmRYUmxRREUwSUcxaGFXNWZablZ1WkY5amIyNTBjbUZqZEY5eWIzVjBaVUF4TlFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTRPZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPalk1Q2lBZ0lDQXZMeUJqYkdGemN5QkRjbVZ6WTJGRFlXeGxibVJoY2xCaGVXMWxiblJ6S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyWjFibVJmWTI5dWRISmhZM1JmY205MWRHVkFNVFU2Q2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TXpreUxUTTVOUW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1puVnVaRjlqYjI1MGNtRmpkQW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pZNUNpQWdJQ0F2THlCamJHRnpjeUJEY21WelkyRkRZV3hsYm1SaGNsQmhlVzFsYm5SektFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3pPVEl0TXprMUNpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdJeUJtZFc1a1gyTnZiblJ5WVdOMENpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCbWRXNWtYMk52Ym5SeVlXTjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjkxYzJWeVgzTmphR1ZrZFd4bFgyTnZkVzUwWDNKdmRYUmxRREUwT2dvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNNE5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TmprS0lDQWdJQzh2SUdOc1lYTnpJRU55WlhOallVTmhiR1Z1WkdGeVVHRjViV1Z1ZEhNb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak00TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZkWE5sY2w5elkyaGxaSFZzWlY5amIzVnVkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmZEc5MFlXeGZaWGhsWTNWMFpXUmZjbTkxZEdWQU1UTTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNemd5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzUnZkR0ZzWDJWNFpXTjFkR1ZrQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5MGIzUmhiRjl6WTJobFpIVnNaWE5mY205MWRHVkFNVEk2Q2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TXpjNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYM1J2ZEdGc1gzTmphR1ZrZFd4bGN3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZibVY0ZEY5bGVHVmpkWFJwYjI1ZmRHbHRaVjl5YjNWMFpVQXhNVG9LSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TmpJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPalk1Q2lBZ0lDQXZMeUJqYkdGemN5QkRjbVZ6WTJGRFlXeGxibVJoY2xCaGVXMWxiblJ6S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TmpJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYMjVsZUhSZlpYaGxZM1YwYVc5dVgzUnBiV1VLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZhWE5mWlhobFkzVjBZV0pzWlY5eWIzVjBaVUF4TURvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek5ETXRNelEyQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z0l5QlNaV0ZrTFc5dWJIa2dkbWxsZDNNS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvMk9Rb2dJQ0FnTHk4Z1kyeGhjM01nUTNKbGMyTmhRMkZzWlc1a1lYSlFZWGx0Wlc1MGN5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk16UXpMVE0wTmdvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklDTWdVbVZoWkMxdmJteDVJSFpwWlhkekNpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWTJGc2JITjFZaUJwYzE5bGVHVmpkWFJoWW14bENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOaGJtTmxiRjl6WTJobFpIVnNaVjl5YjNWMFpVQTVPZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakk1TWkweU9UVUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUFqSUdOaGJtTmxiRjl6WTJobFpIVnNaUW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pZNUNpQWdJQ0F2THlCamJHRnpjeUJEY21WelkyRkRZV3hsYm1SaGNsQmhlVzFsYm5SektFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1qa3lMVEk1TlFvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklDTWdZMkZ1WTJWc1gzTmphR1ZrZFd4bENpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCallXNWpaV3hmYzJOb1pXUjFiR1VLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaWGhsWTNWMFpWOXpZMmhsWkhWc1pWOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qSXhOaTB5TVRrS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QWpJR1Y0WldOMWRHVmZjMk5vWldSMWJHVUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG8yT1FvZ0lDQWdMeThnWTJ4aGMzTWdRM0psYzJOaFEyRnNaVzVrWVhKUVlYbHRaVzUwY3loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TWpFMkxUSXhPUW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1pYaGxZM1YwWlY5elkyaGxaSFZzWlFvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnWlhobFkzVjBaVjl6WTJobFpIVnNaUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWZmNtVmpkWEp5YVc1blgzQmhlVzFsYm5SZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveE9USXRNVGsxQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z0l5QmpjbVZoZEdWZmNtVmpkWEp5YVc1blgzQmhlVzFsYm5RZ0lDaGpiMjUyWlc1cFpXNWpaU0IzY21Gd2NHVnlLUW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pZNUNpQWdJQ0F2THlCamJHRnpjeUJEY21WelkyRkRZV3hsYm1SaGNsQmhlVzFsYm5SektFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakU1TWkweE9UVUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUFqSUdOeVpXRjBaVjl5WldOMWNuSnBibWRmY0dGNWJXVnVkQ0FnS0dOdmJuWmxibWxsYm1ObElIZHlZWEJ3WlhJcENpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCamNtVmhkR1ZmY21WamRYSnlhVzVuWDNCaGVXMWxiblFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFgyOXVaVjkwYVcxbFgzQmhlVzFsYm5SZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveE56RXRNVGMwQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z0l5QmpjbVZoZEdWZmIyNWxYM1JwYldWZmNHRjViV1Z1ZENBZ0tHTnZiblpsYm1sbGJtTmxJSGR5WVhCd1pYSXBDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TmprS0lDQWdJQzh2SUdOc1lYTnpJRU55WlhOallVTmhiR1Z1WkdGeVVHRjViV1Z1ZEhNb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TVRjeExURTNOQW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1kzSmxZWFJsWDI5dVpWOTBhVzFsWDNCaGVXMWxiblFnSUNoamIyNTJaVzVwWlc1alpTQjNjbUZ3Y0dWeUtRb2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ1kzSmxZWFJsWDI5dVpWOTBhVzFsWDNCaGVXMWxiblFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFgzTmphR1ZrZFd4bFgzSnZkWFJsUURVNkNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk9UTXRPVFlLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlBaklHTnlaV0YwWlY5elkyaGxaSFZzWlFvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qWTVDaUFnSUNBdkx5QmpiR0Z6Y3lCRGNtVnpZMkZEWVd4bGJtUmhjbEJoZVcxbGJuUnpLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2prekxUazJDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnSXlCamNtVmhkR1ZmYzJOb1pXUjFiR1VLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR055WldGMFpWOXpZMmhsWkhWc1pRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVFk2Q2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TmprS0lDQWdJQzh2SUdOc1lYTnpJRU55WlhOallVTmhiR1Z1WkdGeVVHRjViV1Z1ZEhNb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UZ0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMa055WlhOallVTmhiR1Z1WkdGeVVHRjViV1Z1ZEhNdVkzSmxZWFJsWDNOamFHVmtkV3hsS0hCaGVXMWxiblJmZEhodU9pQjFhVzUwTmpRc0lISmxZMmx3YVdWdWREb2dZbmwwWlhNc0lHRnRiM1Z1ZERvZ1lubDBaWE1zSUdWNFpXTjFkR1ZmWVhRNklHSjVkR1Z6TENCcGJuUmxjblpoYkY5elpXTnZibVJ6T2lCaWVYUmxjeXdnYjJOamRYSnlaVzVqWlhNNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1kzSmxZWFJsWDNOamFHVmtkV3hsT2dvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2prekxURXdOUW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1kzSmxZWFJsWDNOamFHVmtkV3hsQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JR055WldGMFpWOXpZMmhsWkhWc1pTZ0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxBb2dJQ0FnTHk4Z0lDQWdJSEJoZVcxbGJuUmZkSGh1T2lCbmRIaHVMbEJoZVcxbGJuUlVjbUZ1YzJGamRHbHZiaXdLSUNBZ0lDOHZJQ0FnSUNCeVpXTnBjR2xsYm5RNklHRnlZelF1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUdGeVl6UXVWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJR1Y0WldOMWRHVmZZWFE2SUdGeVl6UXVWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJR2x1ZEdWeWRtRnNYM05sWTI5dVpITTZJR0Z5WXpRdVZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHOWpZM1Z5Y21WdVkyVnpPaUJoY21NMExsVkpiblEyTkN3S0lDQWdJQzh2SUNrZ0xUNGdZWEpqTkM1VlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBMklERUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveE1UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGJXOTFiblF1Ym1GMGFYWmxJRDRnVlVsdWREWTBLREFwTENBaVFXMXZkVzUwSUcxMWMzUWdZbVVnUGlBd0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYlc5MWJuUWdiWFZ6ZENCaVpTQStJREFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG94TVRZS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdWamRYUmxYMkYwTG01aGRHbDJaU0ErSUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdMQ0FpWlhobFkzVjBaVjloZENCdGRYTjBJR0psSUdsdUlHWjFkSFZ5WlNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZblJ2YVFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklHVjRaV04xZEdWZllYUWdiWFZ6ZENCaVpTQnBiaUJtZFhSMWNtVUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3hNVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnZZMk4xY25KbGJtTmxjeTV1WVhScGRtVWdQaUJWU1c1ME5qUW9NQ2tzSUNKdlkyTjFjbkpsYm1ObGN5QnRkWE4wSUdKbElENGdNQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFnTHk4Z2IyTmpkWEp5Wlc1alpYTWdiWFZ6ZENCaVpTQStJREFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG94TVRnS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBYM1I0Ymk1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWlVR0Y1YldWdWRDQnRkWE4wSUhSaGNtZGxkQ0JqYjI1MGNtRmpkQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXROZ29nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGQmhlVzFsYm5RZ2JYVnpkQ0IwWVhKblpYUWdZMjl1ZEhKaFkzUUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3hNakFLSUNBZ0lDOHZJSFJ2ZEdGc1gzSmxjWFZwY21Wa09pQlZTVzUwTmpRZ1BTQmhiVzkxYm5RdWJtRjBhWFpsSUNvZ2IyTmpkWEp5Wlc1alpYTXVibUYwYVhabENpQWdJQ0FxQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG94TWpFS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBYM1I0Ymk1aGJXOTFiblFnUGowZ2RHOTBZV3hmY21WeGRXbHlaV1FzSUNKSmJuTjFabVpwWTJsbGJuUWdaWE5qY205M0lHWjFibVJ6SWdvZ0lDQWdabkpoYldWZlpHbG5JQzAyQ2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCbGMyTnliM2NnWm5WdVpITUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3hNak10TVRJMENpQWdJQ0F2THlBaklFUmxkR1Z5YldsdVpTQnpZMmhsWkhWc1pWOXBaQW9nSUNBZ0x5OGdjR0Y1WlhKZllXUmtjaUE5SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qRXlOUW9nSUNBZ0x5OGdhV1lnY0dGNVpYSmZZV1JrY2lCcGJpQnpaV3htTG5OamFHVmtkV3hsWDJOdmRXNTBjem9LSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGcyTXpabE56UTFaZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakV5TXkweE1qUUtJQ0FnSUM4dklDTWdSR1YwWlhKdGFXNWxJSE5qYUdWa2RXeGxYMmxrQ2lBZ0lDQXZMeUJ3WVhsbGNsOWhaR1J5SUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNVEkxQ2lBZ0lDQXZMeUJwWmlCd1lYbGxjbDloWkdSeUlHbHVJSE5sYkdZdWMyTm9aV1IxYkdWZlkyOTFiblJ6T2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dZM0psWVhSbFgzTmphR1ZrZFd4bFgyVnNjMlZmWW05a2VVQXlDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNVEkyQ2lBZ0lDQXZMeUJ6WTJobFpIVnNaVjlwWkNBOUlITmxiR1l1YzJOb1pXUjFiR1ZmWTI5MWJuUnpXM0JoZVdWeVgyRmtaSEpkTG01aGRHbDJaUW9nSUNBZ1puSmhiV1ZmWkdsbklEVUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk5qYUdWa2RXeGxYMk52ZFc1MGN5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lHSjBiMmtLQ21OeVpXRjBaVjl6WTJobFpIVnNaVjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNVE13TFRFek1Rb2dJQ0FnTHk4Z0l5QlRkRzl5WlNCelkyaGxaSFZzWlNCcGJpQmhJRUp2ZUFvZ0lDQWdMeThnYzJOb1pXUjFiR1ZmYTJWNUlEMGdYM05qYUdWa2RXeGxYMnRsZVNoVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6TENCelkyaGxaSFZzWlY5cFpDa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvMk1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhCaGVXVnlJQ3NnYjNBdWFYUnZZaWh6WTJobFpIVnNaVjlwWkNrS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1UUXhDaUFnSUNBdkx5QmxjMk55YjNkZlltRnNZVzVqWlQxaGNtTTBMbFZKYm5RMk5DaDBiM1JoYkY5eVpYRjFhWEpsWkNrc0NpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1UUXlDaUFnSUNBdkx5QmpjbVZoZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG94TXpJdE1UUXpDaUFnSUNBdkx5QnpaV3htTG5OamFHVmtkV3hsYzF0elkyaGxaSFZzWlY5clpYbGRJRDBnVTJOb1pXUjFiR1VvQ2lBZ0lDQXZMeUFnSUNBZ2NHRjVaWEk5Y0dGNVpYSmZZV1JrY2l3S0lDQWdJQzh2SUNBZ0lDQnlaV05wY0dsbGJuUTljbVZqYVhCcFpXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWlhobFkzVjBaVjloZEQxbGVHVmpkWFJsWDJGMExBb2dJQ0FnTHk4Z0lDQWdJR2x1ZEdWeWRtRnNYM05sWTI5dVpITTlhVzUwWlhKMllXeGZjMlZqYjI1a2N5d0tJQ0FnSUM4dklDQWdJQ0J2WTJOMWNuSmxibU5sY3oxdlkyTjFjbkpsYm1ObGN5d0tJQ0FnSUM4dklDQWdJQ0JsZUdWamRYUmxaRjlqYjNWdWREMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmhZM1JwZG1VOVlYSmpOQzVDYjI5c0tGUnlkV1VwTEFvZ0lDQWdMeThnSUNBZ0lHVnpZM0p2ZDE5aVlXeGhibU5sUFdGeVl6UXVWVWx1ZERZMEtIUnZkR0ZzWDNKbGNYVnBjbVZrS1N3S0lDQWdJQzh2SUNBZ0lDQmpjbVZoZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveE16a0tJQ0FnSUM4dklHVjRaV04xZEdWa1gyTnZkVzUwUFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3hNekl0TVRRekNpQWdJQ0F2THlCelpXeG1Mbk5qYUdWa2RXeGxjMXR6WTJobFpIVnNaVjlyWlhsZElEMGdVMk5vWldSMWJHVW9DaUFnSUNBdkx5QWdJQ0FnY0dGNVpYSTljR0Y1WlhKZllXUmtjaXdLSUNBZ0lDOHZJQ0FnSUNCeVpXTnBjR2xsYm5ROWNtVmphWEJwWlc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdaWGhsWTNWMFpWOWhkRDFsZUdWamRYUmxYMkYwTEFvZ0lDQWdMeThnSUNBZ0lHbHVkR1Z5ZG1Gc1gzTmxZMjl1WkhNOWFXNTBaWEoyWVd4ZmMyVmpiMjVrY3l3S0lDQWdJQzh2SUNBZ0lDQnZZMk4xY25KbGJtTmxjejF2WTJOMWNuSmxibU5sY3l3S0lDQWdJQzh2SUNBZ0lDQmxlR1ZqZFhSbFpGOWpiM1Z1ZEQxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCaFkzUnBkbVU5WVhKak5DNUNiMjlzS0ZSeWRXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdWelkzSnZkMTlpWVd4aGJtTmxQV0Z5WXpRdVZVbHVkRFkwS0hSdmRHRnNYM0psY1hWcGNtVmtLU3dLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkR1ZrWDJGMFBXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakUwTUFvZ0lDQWdMeThnWVdOMGFYWmxQV0Z5WXpRdVFtOXZiQ2hVY25WbEtTd0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZzRNQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakV6TWkweE5ETUtJQ0FnSUM4dklITmxiR1l1YzJOb1pXUjFiR1Z6VzNOamFHVmtkV3hsWDJ0bGVWMGdQU0JUWTJobFpIVnNaU2dLSUNBZ0lDOHZJQ0FnSUNCd1lYbGxjajF3WVhsbGNsOWhaR1J5TEFvZ0lDQWdMeThnSUNBZ0lISmxZMmx3YVdWdWREMXlaV05wY0dsbGJuUXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQV0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JsZUdWamRYUmxYMkYwUFdWNFpXTjFkR1ZmWVhRc0NpQWdJQ0F2THlBZ0lDQWdhVzUwWlhKMllXeGZjMlZqYjI1a2N6MXBiblJsY25aaGJGOXpaV052Ym1SekxBb2dJQ0FnTHk4Z0lDQWdJRzlqWTNWeWNtVnVZMlZ6UFc5alkzVnljbVZ1WTJWekxBb2dJQ0FnTHk4Z0lDQWdJR1Y0WldOMWRHVmtYMk52ZFc1MFBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHRmpkR2wyWlQxaGNtTTBMa0p2YjJ3b1ZISjFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1pYTmpjbTkzWDJKaGJHRnVZMlU5WVhKak5DNVZTVzUwTmpRb2RHOTBZV3hmY21WeGRXbHlaV1FwTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TVRNeUNpQWdJQ0F2THlCelpXeG1Mbk5qYUdWa2RXeGxjMXR6WTJobFpIVnNaVjlyWlhsZElEMGdVMk5vWldSMWJHVW9DaUFnSUNCaWVYUmxZMTh6SUM4dklEQjROek0yTXpZNE5XWUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1UTXlMVEUwTXdvZ0lDQWdMeThnYzJWc1ppNXpZMmhsWkhWc1pYTmJjMk5vWldSMWJHVmZhMlY1WFNBOUlGTmphR1ZrZFd4bEtBb2dJQ0FnTHk4Z0lDQWdJSEJoZVdWeVBYQmhlV1Z5WDJGa1pISXNDaUFnSUNBdkx5QWdJQ0FnY21WamFYQnBaVzUwUFhKbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHVjRaV04xZEdWZllYUTlaWGhsWTNWMFpWOWhkQ3dLSUNBZ0lDOHZJQ0FnSUNCcGJuUmxjblpoYkY5elpXTnZibVJ6UFdsdWRHVnlkbUZzWDNObFkyOXVaSE1zQ2lBZ0lDQXZMeUFnSUNBZ2IyTmpkWEp5Wlc1alpYTTliMk5qZFhKeVpXNWpaWE1zQ2lBZ0lDQXZMeUFnSUNBZ1pYaGxZM1YwWldSZlkyOTFiblE5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWVdOMGFYWmxQV0Z5WXpRdVFtOXZiQ2hVY25WbEtTd0tJQ0FnSUM4dklDQWdJQ0JsYzJOeWIzZGZZbUZzWVc1alpUMWhjbU0wTGxWSmJuUTJOQ2gwYjNSaGJGOXlaWEYxYVhKbFpDa3NDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0F2THlBcENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNVFExTFRFME5nb2dJQ0FnTHk4Z0l5QkpibU55WlcxbGJuUWdkWE5sY2lkeklITmphR1ZrZFd4bElHTnZkVzUwWlhJS0lDQWdJQzh2SUhObGJHWXVjMk5vWldSMWJHVmZZMjkxYm5SelczQmhlV1Z5WDJGa1pISmRJRDBnWVhKak5DNVZTVzUwTmpRb2MyTm9aV1IxYkdWZmFXUWdLeUJWU1c1ME5qUW9NU2twQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3hORGdLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYzJOb1pXUjFiR1Z6TG5aaGJIVmxJRDBnYzJWc1ppNTBiM1JoYkY5elkyaGxaSFZzWlhNdWRtRnNkV1VnS3lCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0owYjNSaGJGOXpZMmhsWkhWc1pYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZjMk5vWldSMWJHVnpJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJblJ2ZEdGc1gzTmphR1ZrZFd4bGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNVFV3TFRFMU1Rb2dJQ0FnTHk4Z0l5QlNaV1oxYm1RZ1lXNTVJR1Y0WTJWemN3b2dJQ0FnTHk4Z1pYaGpaWE56SUQwZ2NHRjViV1Z1ZEY5MGVHNHVZVzF2ZFc1MElDMGdkRzkwWVd4ZmNtVnhkV2x5WldRS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qRTFNZ29nSUNBZ0x5OGdhV1lnWlhoalpYTnpJRDRnVlVsdWREWTBLREFwT2dvZ0lDQWdZbm9nWTNKbFlYUmxYM05qYUdWa2RXeGxYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qRTFNeTB4TlRjS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxbGVHTmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNVFUwQ2lBZ0lDQXZMeUJ5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNVFV6Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TVRVMkNpQWdJQ0F2THlCbVpXVTlNQ3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakUxTXkweE5UY0tJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWxlR05sYzNNc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvS1kzSmxZWFJsWDNOamFHVmtkV3hsWDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG94TmpZS0lDQWdJQzh2SUdGeVl6UXVRbTl2YkNocGJuUmxjblpoYkY5elpXTnZibVJ6TG01aGRHbDJaU0ErSUZWSmJuUTJOQ2d3S1Nrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TVRVNUxURTJOd29nSUNBZ0x5OGdZWEpqTkM1bGJXbDBLQW9nSUNBZ0x5OGdJQ0FnSUNKVFkyaGxaSFZzWlVOeVpXRjBaV1FvWVdSa2NtVnpjeXgxYVc1ME5qUXNZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEdKdmIyd3BJaXdLSUNBZ0lDOHZJQ0FnSUNCd1lYbGxjbDloWkdSeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hOamFHVmtkV3hsWDJsa0tTd0tJQ0FnSUM4dklDQWdJQ0J5WldOcGNHbGxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHVjRaV04xZEdWZllYUXNDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNUNiMjlzS0dsdWRHVnlkbUZzWDNObFkyOXVaSE11Ym1GMGFYWmxJRDRnVlVsdWREWTBLREFwS1N3S0lDQWdJQzh2SUNrS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZVEJoTWpVNE9USWdMeThnYldWMGFHOWtJQ0pUWTJobFpIVnNaVU55WldGMFpXUW9ZV1JrY21WemN5eDFhVzUwTmpRc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3cElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3hOamtLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2h6WTJobFpIVnNaVjlwWkNrS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncGpjbVZoZEdWZmMyTm9aV1IxYkdWZlpXeHpaVjlpYjJSNVFESTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNVEk0Q2lBZ0lDQXZMeUJ6WTJobFpIVnNaVjlwWkNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnWTNKbFlYUmxYM05qYUdWa2RXeGxYMkZtZEdWeVgybG1YMlZzYzJWQU13b0tDaTh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTVEY21WelkyRkRZV3hsYm1SaGNsQmhlVzFsYm5SekxtTnlaV0YwWlY5dmJtVmZkR2x0WlY5d1lYbHRaVzUwS0hCaGVXMWxiblJmZEhodU9pQjFhVzUwTmpRc0lISmxZMmx3YVdWdWREb2dZbmwwWlhNc0lHRnRiM1Z1ZERvZ1lubDBaWE1zSUdWNFpXTjFkR1ZmWVhRNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1kzSmxZWFJsWDI5dVpWOTBhVzFsWDNCaGVXMWxiblE2Q2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TVRjeExURTRNUW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1kzSmxZWFJsWDI5dVpWOTBhVzFsWDNCaGVXMWxiblFnSUNoamIyNTJaVzVwWlc1alpTQjNjbUZ3Y0dWeUtRb2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCamNtVmhkR1ZmYjI1bFgzUnBiV1ZmY0dGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUhCaGVXMWxiblJmZEhodU9pQm5kSGh1TGxCaGVXMWxiblJVY21GdWMyRmpkR2x2Yml3S0lDQWdJQzh2SUNBZ0lDQnlaV05wY0dsbGJuUTZJR0Z5WXpRdVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklHRnlZelF1VlVsdWREWTBMQW9nSUNBZ0x5OGdJQ0FnSUdWNFpXTjFkR1ZmWVhRNklHRnlZelF1VlVsdWREWTBMQW9nSUNBZ0x5OGdLU0F0UGlCaGNtTTBMbFZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJRFFnTVFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pFNE15MHhPVEFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1OeVpXRjBaVjl6WTJobFpIVnNaU2dLSUNBZ0lDOHZJQ0FnSUNCd1lYbHRaVzUwWDNSNGJpd0tJQ0FnSUM4dklDQWdJQ0J5WldOcGNHbGxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHVjRaV04xZEdWZllYUXNDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb01Da3NJQ0FnSXlCcGJuUmxjblpoYkNBOUlEQWc0b2FTSUc5dVpTMTBhVzFsQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9NU2tzSUNBZ0l5QnZZMk4xY25KbGJtTmxjeUE5SURFS0lDQWdJQzh2SUNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakU0T0FvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb01Da3NJQ0FnSXlCcGJuUmxjblpoYkNBOUlEQWc0b2FTSUc5dVpTMTBhVzFsQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakU0T1FvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb01Ta3NJQ0FnSXlCdlkyTjFjbkpsYm1ObGN5QTlJREVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01ERUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3hPRE10TVRrd0NpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWpjbVZoZEdWZmMyTm9aV1IxYkdVb0NpQWdJQ0F2THlBZ0lDQWdjR0Y1YldWdWRGOTBlRzRzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmphWEJwWlc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JsZUdWamRYUmxYMkYwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLREFwTENBZ0lDTWdhVzUwWlhKMllXd2dQU0F3SU9LR2tpQnZibVV0ZEdsdFpRb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0RFcExDQWdJQ01nYjJOamRYSnlaVzVqWlhNZ1BTQXhDaUFnSUNBdkx5QXBDaUFnSUNCallXeHNjM1ZpSUdOeVpXRjBaVjl6WTJobFpIVnNaUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxrTnlaWE5qWVVOaGJHVnVaR0Z5VUdGNWJXVnVkSE11WTNKbFlYUmxYM0psWTNWeWNtbHVaMTl3WVhsdFpXNTBLSEJoZVcxbGJuUmZkSGh1T2lCMWFXNTBOalFzSUhKbFkybHdhV1Z1ZERvZ1lubDBaWE1zSUdGdGIzVnVkRG9nWW5sMFpYTXNJR1pwY25OMFgyVjRaV04xZEdsdmJsOWhkRG9nWW5sMFpYTXNJR2x1ZEdWeWRtRnNYMlJoZVhNNklHSjVkR1Z6TENCdlkyTjFjbkpsYm1ObGN6b2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGpjbVZoZEdWZmNtVmpkWEp5YVc1blgzQmhlVzFsYm5RNkNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1Ua3lMVEl3TkFvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklDTWdZM0psWVhSbFgzSmxZM1Z5Y21sdVoxOXdZWGx0Wlc1MElDQW9ZMjl1ZG1WdWFXVnVZMlVnZDNKaGNIQmxjaWtLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdZM0psWVhSbFgzSmxZM1Z5Y21sdVoxOXdZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZc0NpQWdJQ0F2THlBZ0lDQWdjR0Y1YldWdWRGOTBlRzQ2SUdkMGVHNHVVR0Y1YldWdWRGUnlZVzV6WVdOMGFXOXVMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkybHdhV1Z1ZERvZ1lYSmpOQzVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nWVhKak5DNVZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdabWx5YzNSZlpYaGxZM1YwYVc5dVgyRjBPaUJoY21NMExsVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQnBiblJsY25aaGJGOWtZWGx6T2lCaGNtTTBMbFZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0J2WTJOMWNuSmxibU5sY3pvZ1lYSmpOQzVWU1c1ME5qUXNDaUFnSUNBdkx5QXBJQzArSUdGeVl6UXVWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdOaUF4Q2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TWpBMkNpQWdJQ0F2THlCcGJuUmxjblpoYkY5elpXTnZibVJ6SUQwZ1lYSmpOQzVWU1c1ME5qUW9hVzUwWlhKMllXeGZaR0Y1Y3k1dVlYUnBkbVVnS2lCVlNXNTBOalFvT0RZME1EQXBLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaWRHOXBDaUFnSUNCd2RYTm9hVzUwSURnMk5EQXdJQzh2SURnMk5EQXdDaUFnSUNBcUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1qQTNMVEl4TkFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVkzSmxZWFJsWDNOamFHVmtkV3hsS0FvZ0lDQWdMeThnSUNBZ0lIQmhlVzFsYm5SZmRIaHVMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdabWx5YzNSZlpYaGxZM1YwYVc5dVgyRjBMQW9nSUNBZ0x5OGdJQ0FnSUdsdWRHVnlkbUZzWDNObFkyOXVaSE1zQ2lBZ0lDQXZMeUFnSUNBZ2IyTmpkWEp5Wlc1alpYTXNDaUFnSUNBdkx5QXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUdOeVpXRjBaVjl6WTJobFpIVnNaUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxrTnlaWE5qWVVOaGJHVnVaR0Z5VUdGNWJXVnVkSE11WlhobFkzVjBaVjl6WTJobFpIVnNaU2h3WVhsbGNqb2dZbmwwWlhNc0lITmphR1ZrZFd4bFgybGtPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbVY0WldOMWRHVmZjMk5vWldSMWJHVTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNakUyTFRJeU5Bb2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJQ01nWlhobFkzVjBaVjl6WTJobFpIVnNaUW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQmxlR1ZqZFhSbFgzTmphR1ZrZFd4bEtBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZc0NpQWdJQ0F2THlBZ0lDQWdjR0Y1WlhJNklHRnlZelF1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCelkyaGxaSFZzWlY5cFpEb2dZWEpqTkM1VlNXNTBOalFzQ2lBZ0lDQXZMeUFwSUMwK0lHRnlZelF1UW05dmJEb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pJek13b2dJQ0FnTHk4Z2MyTm9aV1IxYkdWZmEyVjVJRDBnWDNOamFHVmtkV3hsWDJ0bGVTaHdZWGxsY2k1dVlYUnBkbVV1WW5sMFpYTXNJSE5qYUdWa2RXeGxYMmxrTG01aGRHbDJaU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPall5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjR0Y1WlhJZ0t5QnZjQzVwZEc5aUtITmphR1ZrZFd4bFgybGtLUW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG95TXpRS0lDQWdJQzh2SUdGemMyVnlkQ0J6WTJobFpIVnNaVjlyWlhrZ2FXNGdjMlZzWmk1elkyaGxaSFZzWlhNc0lDSlRZMmhsWkhWc1pTQnViM1FnWm05MWJtUWlDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjROek0yTXpZNE5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJUWTJobFpIVnNaU0J1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG95TXpZS0lDQWdJQzh2SUhOamFHVmtkV3hsSUQwZ2MyVnNaaTV6WTJobFpIVnNaWE5iYzJOb1pXUjFiR1ZmYTJWNVhTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMyTm9aV1IxYkdWeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakl6T0FvZ0lDQWdMeThnWVhOelpYSjBJSE5qYUdWa2RXeGxMbUZqZEdsMlpTNXVZWFJwZG1Vc0lDSlRZMmhsWkhWc1pTQmhiSEpsWVdSNUlHTnZiWEJzWlhSbFpDOWpZVzVqWld4c1pXUWlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTWdOQ0F2THlBNE16SUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdGemMyVnlkQ0F2THlCVFkyaGxaSFZzWlNCaGJISmxZV1I1SUdOdmJYQnNaWFJsWkM5allXNWpaV3hzWldRS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveU16a0tJQ0FnSUM4dklHRnpjMlZ5ZENCelkyaGxaSFZzWlM1bGVHVmpkWFJsWkY5amIzVnVkQzV1WVhScGRtVWdQQ0J6WTJobFpIVnNaUzV2WTJOMWNuSmxibU5sY3k1dVlYUnBkbVVzSUNKQmJHd2djR0Y1YldWdWRITWdaRzl1WlNJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTVOaUF2THlBNU5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURnNElEZ2dMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0E0T0NBdkx5QTRPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklFRnNiQ0J3WVhsdFpXNTBjeUJrYjI1bENpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1qUXhMVEkwTWdvZ0lDQWdMeThnSXlCRFlXeGpkV3hoZEdVZ2JtVjRkQ0JsZUdWamRYUnBiMjRnZEdsdFpRb2dJQ0FnTHk4Z2JtVjRkRjlsZUdWaklEMGdjMk5vWldSMWJHVXVaWGhsWTNWMFpWOWhkQzV1WVhScGRtVWdLeUFvQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaWGgwY21GamRDQTNNaUE0SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JRFFLSUNBZ0lIQjFjMmhwYm5RZ056SWdMeThnTnpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1qUXpDaUFnSUNBdkx5QnpZMmhsWkhWc1pTNWxlR1ZqZFhSbFpGOWpiM1Z1ZEM1dVlYUnBkbVVnS2lCelkyaGxaSFZzWlM1cGJuUmxjblpoYkY5elpXTnZibVJ6TG01aGRHbDJaUW9nSUNBZ1pHbG5JRFVLSUNBZ0lHVjRkSEpoWTNRZ09EQWdPQ0F2THlCdmJpQmxjbkp2Y2pvZ1NXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdScFp5QTJDaUFnSUNCd2RYTm9hVzUwSURnd0lDOHZJRGd3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURZS0lDQWdJQ29LSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG95TkRFdE1qUTBDaUFnSUNBdkx5QWpJRU5oYkdOMWJHRjBaU0J1WlhoMElHVjRaV04xZEdsdmJpQjBhVzFsQ2lBZ0lDQXZMeUJ1WlhoMFgyVjRaV01nUFNCelkyaGxaSFZzWlM1bGVHVmpkWFJsWDJGMExtNWhkR2wyWlNBcklDZ0tJQ0FnSUM4dklDQWdJQ0J6WTJobFpIVnNaUzVsZUdWamRYUmxaRjlqYjNWdWRDNXVZWFJwZG1VZ0tpQnpZMmhsWkhWc1pTNXBiblJsY25aaGJGOXpaV052Ym1SekxtNWhkR2wyWlFvZ0lDQWdMeThnS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBckNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1qUTFDaUFnSUNBdkx5QmhjM05sY25RZ1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFnUGowZ2JtVjRkRjlsZUdWakxDQWlUbTkwSUhsbGRDQmxlR1ZqZFhSaFlteGxJZ29nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCT2IzUWdlV1YwSUdWNFpXTjFkR0ZpYkdVS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveU5EWUtJQ0FnSUM4dklHRnpjMlZ5ZENCelkyaGxaSFZzWlM1bGMyTnliM2RmWW1Gc1lXNWpaUzV1WVhScGRtVWdQajBnYzJOb1pXUjFiR1V1WVcxdmRXNTBMbTVoZEdsMlpTd2dJa2x1YzNWbVptbGphV1Z1ZENCbGMyTnliM2NpQ2lBZ0lDQmthV2NnTlFvZ0lDQWdjSFZ6YUdsdWRDQXhNRFVnTHk4Z01UQTFDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHVjRkSEpoWTNRZ05qUWdPQ0F2THlCdmJpQmxjbkp2Y2pvZ1NXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdScFp5QTNDaUFnSUNCd2RYTm9hVzUwSURZMElDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeENpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCbGMyTnliM2NLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG95TkRndE1qUTVDaUFnSUNBdkx5QWpJRVJsWkhWamRDQm1jbTl0SUdWelkzSnZkeUJoYm1RZ2FXNWpjbVZ0Wlc1MElHTnZkVzUwQ2lBZ0lDQXZMeUJ1WlhkZlltRnNZVzVqWlNBOUlITmphR1ZrZFd4bExtVnpZM0p2ZDE5aVlXeGhibU5sTG01aGRHbDJaU0F0SUhOamFHVmtkV3hsTG1GdGIzVnVkQzV1WVhScGRtVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURFS0lDQWdJQzBLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG95TlRBS0lDQWdJQzh2SUc1bGQxOWpiM1Z1ZENBOUlITmphR1ZrZFd4bExtVjRaV04xZEdWa1gyTnZkVzUwTG01aGRHbDJaU0FySUZWSmJuUTJOQ2d4S1FvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pJMU1Rb2dJQ0FnTHk4Z2FYTmZaRzl1WlNBOUlHNWxkMTlqYjNWdWRDQStQU0J6WTJobFpIVnNaUzV2WTJOMWNuSmxibU5sY3k1dVlYUnBkbVVLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0ErUFFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pJMU5Bb2dJQ0FnTHk4Z2NHRjVaWEk5YzJOb1pXUjFiR1V1Y0dGNVpYSXNDaUFnSUNCa2FXY2dPQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qSTFOUW9nSUNBZ0x5OGdjbVZqYVhCcFpXNTBQWE5qYUdWa2RXeGxMbkpsWTJsd2FXVnVkQ3dLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakkyTUFvZ0lDQWdMeThnWlhobFkzVjBaV1JmWTI5MWJuUTlZWEpqTkM1VlNXNTBOalFvYm1WM1gyTnZkVzUwS1N3S0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakkyTVFvZ0lDQWdMeThnWVdOMGFYWmxQV0Z5WXpRdVFtOXZiQ2h1YjNRZ2FYTmZaRzl1WlNrc0NpQWdJQ0JrYVdjZ013b2dJQ0FnSVFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG95TmpJS0lDQWdJQzh2SUdWelkzSnZkMTlpWVd4aGJtTmxQV0Z5WXpRdVZVbHVkRFkwS0c1bGQxOWlZV3hoYm1ObEtTd0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pJMk13b2dJQ0FnTHk4Z1kzSmxZWFJsWkY5aGREMXpZMmhsWkhWc1pTNWpjbVZoZEdWa1gyRjBMQW9nSUNBZ2RXNWpiM1psY2lBeE1Rb2dJQ0FnWlhoMGNtRmpkQ0F4TVRNZ09DQXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveU5UTXRNalkwQ2lBZ0lDQXZMeUJ6Wld4bUxuTmphR1ZrZFd4bGMxdHpZMmhsWkhWc1pWOXJaWGxkSUQwZ1UyTm9aV1IxYkdVb0NpQWdJQ0F2THlBZ0lDQWdjR0Y1WlhJOWMyTm9aV1IxYkdVdWNHRjVaWElzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmphWEJwWlc1MFBYTmphR1ZrZFd4bExuSmxZMmx3YVdWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljMk5vWldSMWJHVXVZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1Y0WldOMWRHVmZZWFE5YzJOb1pXUjFiR1V1WlhobFkzVjBaVjloZEN3S0lDQWdJQzh2SUNBZ0lDQnBiblJsY25aaGJGOXpaV052Ym1SelBYTmphR1ZrZFd4bExtbHVkR1Z5ZG1Gc1gzTmxZMjl1WkhNc0NpQWdJQ0F2THlBZ0lDQWdiMk5qZFhKeVpXNWpaWE05YzJOb1pXUjFiR1V1YjJOamRYSnlaVzVqWlhNc0NpQWdJQ0F2THlBZ0lDQWdaWGhsWTNWMFpXUmZZMjkxYm5ROVlYSmpOQzVWU1c1ME5qUW9ibVYzWDJOdmRXNTBLU3dLSUNBZ0lDOHZJQ0FnSUNCaFkzUnBkbVU5WVhKak5DNUNiMjlzS0c1dmRDQnBjMTlrYjI1bEtTd0tJQ0FnSUM4dklDQWdJQ0JsYzJOeWIzZGZZbUZzWVc1alpUMWhjbU0wTGxWSmJuUTJOQ2h1WlhkZlltRnNZVzVqWlNrc0NpQWdJQ0F2THlBZ0lDQWdZM0psWVhSbFpGOWhkRDF6WTJobFpIVnNaUzVqY21WaGRHVmtYMkYwTEFvZ0lDQWdMeThnS1FvZ0lDQWdaR2xuSURVS0lDQWdJR1JwWnlBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTVDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01URUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeE1Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3lOall0TWpjeENpQWdJQ0F2THlBaklGTmxibVFnY0dGNWJXVnVkQ0IwYnlCeVpXTnBjR2xsYm5RS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF6WTJobFpIVnNaUzV5WldOcGNHbGxiblF1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF6WTJobFpIVnNaUzVoYlc5MWJuUXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdaR2xuSURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG95TmpZdE1qWTNDaUFnSUNBdkx5QWpJRk5sYm1RZ2NHRjViV1Z1ZENCMGJ5QnlaV05wY0dsbGJuUUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3lOekFLSUNBZ0lDOHZJR1psWlQwd0xBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1qWTJMVEkzTVFvZ0lDQWdMeThnSXlCVFpXNWtJSEJoZVcxbGJuUWdkRzhnY21WamFYQnBaVzUwQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljMk5vWldSMWJHVXVjbVZqYVhCcFpXNTBMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljMk5vWldSMWJHVXVZVzF2ZFc1MExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TWpjekxUSTRNQW9nSUNBZ0x5OGdZWEpqTkM1bGJXbDBLQW9nSUNBZ0x5OGdJQ0FnSUNKUVlYbHRaVzUwUlhobFkzVjBaV1FvWVdSa2NtVnpjeXgxYVc1ME5qUXNZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1NJc0NpQWdJQ0F2THlBZ0lDQWdjMk5vWldSMWJHVXVjR0Y1WlhJc0NpQWdJQ0F2THlBZ0lDQWdjMk5vWldSMWJHVmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ2MyTm9aV1IxYkdVdWNtVmphWEJwWlc1MExBb2dJQ0FnTHk4Z0lDQWdJSE5qYUdWa2RXeGxMbUZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNodVpYZGZZMjkxYm5RcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WW1OaVpqWXdZbVlnTHk4Z2JXVjBhRzlrSUNKUVlYbHRaVzUwUlhobFkzVjBaV1FvWVdSa2NtVnpjeXgxYVc1ME5qUXNZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1qZ3lDaUFnSUNBdkx5QnBaaUJwYzE5a2IyNWxPZ29nSUNBZ1lub2daWGhsWTNWMFpWOXpZMmhsWkhWc1pWOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveU9ETUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZaWGhsWTNWMFpXUXVkbUZzZFdVZ1BTQnpaV3htTG5SdmRHRnNYMlY0WldOMWRHVmtMblpoYkhWbElDc2dWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWRHOTBZV3hmWlhobFkzVjBaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmWlhobFkzVjBaV1FnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEc5MFlXeGZaWGhsWTNWMFpXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakk0TkMweU9EZ0tJQ0FnSUM4dklHRnlZelF1WlcxcGRDZ0tJQ0FnSUM4dklDQWdJQ0FpVTJOb1pXUjFiR1ZEYjIxd2JHVjBaV1FvWVdSa2NtVnpjeXgxYVc1ME5qUXBJaXdLSUNBZ0lDOHZJQ0FnSUNCelkyaGxaSFZzWlM1d1lYbGxjaXdLSUNBZ0lDOHZJQ0FnSUNCelkyaGxaSFZzWlY5cFpDd0tJQ0FnSUM4dklDa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEWTJOekV5WVRBM0lDOHZJRzFsZEdodlpDQWlVMk5vWldSMWJHVkRiMjF3YkdWMFpXUW9ZV1JrY21WemN5eDFhVzUwTmpRcElnb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNncGxlR1ZqZFhSbFgzTmphR1ZrZFd4bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveU9UQUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1ZISjFaU2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGc0TUFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMa055WlhOallVTmhiR1Z1WkdGeVVHRjViV1Z1ZEhNdVkyRnVZMlZzWDNOamFHVmtkV3hsS0hOamFHVmtkV3hsWDJsa09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtTmhibU5sYkY5elkyaGxaSFZzWlRvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveU9USXRNamsyQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z0l5QmpZVzVqWld4ZmMyTm9aV1IxYkdVS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnWTJGdVkyVnNYM05qYUdWa2RXeGxLSE5sYkdZc0lITmphR1ZrZFd4bFgybGtPaUJoY21NMExsVkpiblEyTkNrZ0xUNGdZWEpqTkM1Q2IyOXNPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk16QXhDaUFnSUNBdkx5QndZWGxsY2w5aFpHUnlJRDBnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk16QXhMVE13TWdvZ0lDQWdMeThnY0dGNVpYSmZZV1JrY2lBOUlHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdMeThnYzJOb1pXUjFiR1ZmYTJWNUlEMGdYM05qYUdWa2RXeGxYMnRsZVNoVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6TENCelkyaGxaSFZzWlY5cFpDNXVZWFJwZG1VcENpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3pNRElLSUNBZ0lDOHZJSE5qYUdWa2RXeGxYMnRsZVNBOUlGOXpZMmhsWkhWc1pWOXJaWGtvVkhodUxuTmxibVJsY2k1aWVYUmxjeXdnYzJOb1pXUjFiR1ZmYVdRdWJtRjBhWFpsS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TmpJS0lDQWdJQzh2SUhKbGRIVnliaUJ3WVhsbGNpQXJJRzl3TG1sMGIySW9jMk5vWldSMWJHVmZhV1FwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek1ETUtJQ0FnSUM4dklHRnpjMlZ5ZENCelkyaGxaSFZzWlY5clpYa2dhVzRnYzJWc1ppNXpZMmhsWkhWc1pYTXNJQ0pUWTJobFpIVnNaU0J1YjNRZ1ptOTFibVFpQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TnpNMk16WTROV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCVFkyaGxaSFZzWlNCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek1EVUtJQ0FnSUM4dklITmphR1ZrZFd4bElEMGdjMlZzWmk1elkyaGxaSFZzWlhOYmMyTm9aV1IxYkdWZmEyVjVYUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjMk5vWldSMWJHVnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNd053b2dJQ0FnTHk4Z1lYTnpaWEowSUhOamFHVmtkV3hsTG5CaGVXVnlJRDA5SUhCaGVXVnlYMkZrWkhJc0lDSlZibUYxZEdodmNtbDZaV1FpQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNaUF2THlCdmJpQmxjbkp2Y2pvZ1NXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGVnVZWFYwYUc5eWFYcGxaQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak13T0FvZ0lDQWdMeThnWVhOelpYSjBJSE5qYUdWa2RXeGxMbUZqZEdsMlpTNXVZWFJwZG1Vc0lDSlRZMmhsWkhWc1pTQmhiSEpsWVdSNUlHTnZiWEJzWlhSbFpDOWpZVzVqWld4c1pXUWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZeUEwSUM4dklEZ3pNZ29nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lYTnpaWEowSUM4dklGTmphR1ZrZFd4bElHRnNjbVZoWkhrZ1kyOXRjR3hsZEdWa0wyTmhibU5sYkd4bFpBb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTXhNQW9nSUNBZ0x5OGdjbVZtZFc1a1gyRnRiM1Z1ZENBOUlITmphR1ZrZFd4bExtVnpZM0p2ZDE5aVlXeGhibU5sTG01aGRHbDJaUW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01UQTFJQzh2SURFd05Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1kyOTJaWElnTkFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNeE5Rb2dJQ0FnTHk4Z2NtVmphWEJwWlc1MFBYTmphR1ZrZFd4bExuSmxZMmx3YVdWdWRDd0tJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURNeUlETXlJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTXhOZ29nSUNBZ0x5OGdZVzF2ZFc1MFBYTmphR1ZrZFd4bExtRnRiM1Z1ZEN3S0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRFkwSURnZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TXpFM0NpQWdJQ0F2THlCbGVHVmpkWFJsWDJGMFBYTmphR1ZrZFd4bExtVjRaV04xZEdWZllYUXNDaUFnSUNCa2FXY2dNd29nSUNBZ1pYaDBjbUZqZENBM01pQTRJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTXhPQW9nSUNBZ0x5OGdhVzUwWlhKMllXeGZjMlZqYjI1a2N6MXpZMmhsWkhWc1pTNXBiblJsY25aaGJGOXpaV052Ym1SekxBb2dJQ0FnWkdsbklEUUtJQ0FnSUdWNGRISmhZM1FnT0RBZ09DQXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek1Ua0tJQ0FnSUM4dklHOWpZM1Z5Y21WdVkyVnpQWE5qYUdWa2RXeGxMbTlqWTNWeWNtVnVZMlZ6TEFvZ0lDQWdaR2xuSURVS0lDQWdJR1Y0ZEhKaFkzUWdPRGdnT0NBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TWpBS0lDQWdJQzh2SUdWNFpXTjFkR1ZrWDJOdmRXNTBQWE5qYUdWa2RXeGxMbVY0WldOMWRHVmtYMk52ZFc1MExBb2dJQ0FnWkdsbklEWUtJQ0FnSUdWNGRISmhZM1FnT1RZZ09DQXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek1qTUtJQ0FnSUM4dklHTnlaV0YwWldSZllYUTljMk5vWldSMWJHVXVZM0psWVhSbFpGOWhkQ3dLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWlhoMGNtRmpkQ0F4TVRNZ09DQXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek1USXRNekkwQ2lBZ0lDQXZMeUFqSUUxaGNtc2dhVzVoWTNScGRtVWdkMmwwYUNCNlpYSnZJR1Z6WTNKdmR3b2dJQ0FnTHk4Z2MyVnNaaTV6WTJobFpIVnNaWE5iYzJOb1pXUjFiR1ZmYTJWNVhTQTlJRk5qYUdWa2RXeGxLQW9nSUNBZ0x5OGdJQ0FnSUhCaGVXVnlQWE5qYUdWa2RXeGxMbkJoZVdWeUxBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJsd2FXVnVkRDF6WTJobFpIVnNaUzV5WldOcGNHbGxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhOamFHVmtkV3hsTG1GdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbGVHVmpkWFJsWDJGMFBYTmphR1ZrZFd4bExtVjRaV04xZEdWZllYUXNDaUFnSUNBdkx5QWdJQ0FnYVc1MFpYSjJZV3hmYzJWamIyNWtjejF6WTJobFpIVnNaUzVwYm5SbGNuWmhiRjl6WldOdmJtUnpMQW9nSUNBZ0x5OGdJQ0FnSUc5alkzVnljbVZ1WTJWelBYTmphR1ZrZFd4bExtOWpZM1Z5Y21WdVkyVnpMQW9nSUNBZ0x5OGdJQ0FnSUdWNFpXTjFkR1ZrWDJOdmRXNTBQWE5qYUdWa2RXeGxMbVY0WldOMWRHVmtYMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0ZqZEdsMlpUMWhjbU0wTGtKdmIyd29SbUZzYzJVcExBb2dJQ0FnTHk4Z0lDQWdJR1Z6WTNKdmQxOWlZV3hoYm1ObFBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTljMk5vWldSMWJHVXVZM0psWVhSbFpGOWhkQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNeU1Rb2dJQ0FnTHk4Z1lXTjBhWFpsUFdGeVl6UXVRbTl2YkNoR1lXeHpaU2tzQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek1USXRNekkwQ2lBZ0lDQXZMeUFqSUUxaGNtc2dhVzVoWTNScGRtVWdkMmwwYUNCNlpYSnZJR1Z6WTNKdmR3b2dJQ0FnTHk4Z2MyVnNaaTV6WTJobFpIVnNaWE5iYzJOb1pXUjFiR1ZmYTJWNVhTQTlJRk5qYUdWa2RXeGxLQW9nSUNBZ0x5OGdJQ0FnSUhCaGVXVnlQWE5qYUdWa2RXeGxMbkJoZVdWeUxBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJsd2FXVnVkRDF6WTJobFpIVnNaUzV5WldOcGNHbGxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhOamFHVmtkV3hsTG1GdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbGVHVmpkWFJsWDJGMFBYTmphR1ZrZFd4bExtVjRaV04xZEdWZllYUXNDaUFnSUNBdkx5QWdJQ0FnYVc1MFpYSjJZV3hmYzJWamIyNWtjejF6WTJobFpIVnNaUzVwYm5SbGNuWmhiRjl6WldOdmJtUnpMQW9nSUNBZ0x5OGdJQ0FnSUc5alkzVnljbVZ1WTJWelBYTmphR1ZrZFd4bExtOWpZM1Z5Y21WdVkyVnpMQW9nSUNBZ0x5OGdJQ0FnSUdWNFpXTjFkR1ZrWDJOdmRXNTBQWE5qYUdWa2RXeGxMbVY0WldOMWRHVmtYMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0ZqZEdsMlpUMWhjbU0wTGtKdmIyd29SbUZzYzJVcExBb2dJQ0FnTHk4Z0lDQWdJR1Z6WTNKdmQxOWlZV3hoYm1ObFBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTljMk5vWldSMWJHVXVZM0psWVhSbFpGOWhkQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNeU1nb2dJQ0FnTHk4Z1pYTmpjbTkzWDJKaGJHRnVZMlU5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTXhNaTB6TWpRS0lDQWdJQzh2SUNNZ1RXRnlheUJwYm1GamRHbDJaU0IzYVhSb0lIcGxjbThnWlhOamNtOTNDaUFnSUNBdkx5QnpaV3htTG5OamFHVmtkV3hsYzF0elkyaGxaSFZzWlY5clpYbGRJRDBnVTJOb1pXUjFiR1VvQ2lBZ0lDQXZMeUFnSUNBZ2NHRjVaWEk5YzJOb1pXUjFiR1V1Y0dGNVpYSXNDaUFnSUNBdkx5QWdJQ0FnY21WamFYQnBaVzUwUFhOamFHVmtkV3hsTG5KbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWMyTm9aV1IxYkdVdVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHVjRaV04xZEdWZllYUTljMk5vWldSMWJHVXVaWGhsWTNWMFpWOWhkQ3dLSUNBZ0lDOHZJQ0FnSUNCcGJuUmxjblpoYkY5elpXTnZibVJ6UFhOamFHVmtkV3hsTG1sdWRHVnlkbUZzWDNObFkyOXVaSE1zQ2lBZ0lDQXZMeUFnSUNBZ2IyTmpkWEp5Wlc1alpYTTljMk5vWldSMWJHVXViMk5qZFhKeVpXNWpaWE1zQ2lBZ0lDQXZMeUFnSUNBZ1pYaGxZM1YwWldSZlkyOTFiblE5YzJOb1pXUjFiR1V1WlhobFkzVjBaV1JmWTI5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWVdOMGFYWmxQV0Z5WXpRdVFtOXZiQ2hHWVd4elpTa3NDaUFnSUNBdkx5QWdJQ0FnWlhOamNtOTNYMkpoYkdGdVkyVTlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdZM0psWVhSbFpGOWhkRDF6WTJobFpIVnNaUzVqY21WaGRHVmtYMkYwTEFvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTXlOaTB6TWpjS0lDQWdJQzh2SUNNZ1VtVm1kVzVrSUhKbGJXRnBibWx1WnlCbGMyTnliM2NLSUNBZ0lDOHZJR2xtSUhKbFpuVnVaRjloYlc5MWJuUWdQaUJWU1c1ME5qUW9NQ2s2Q2lBZ0lDQmllaUJqWVc1alpXeGZjMk5vWldSMWJHVmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk16STRMVE16TWdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhKbFpuVnVaRjloYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk16STVDaUFnSUNBdkx5QnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk16STRDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNek14Q2lBZ0lDQXZMeUJtWldVOU1Dd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTXlPQzB6TXpJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxeVpXWjFibVJmWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtDbU5oYm1ObGJGOXpZMmhsWkhWc1pWOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk16TTRDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h5WldaMWJtUmZZVzF2ZFc1MEtTd0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk16TTBMVE16T1FvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0FvZ0lDQWdMeThnSUNBZ0lDSlRZMmhsWkhWc1pVTmhibU5sYkd4bFpDaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFwSWl3S0lDQWdJQzh2SUNBZ0lDQndZWGxsY2w5aFpHUnlMQW9nSUNBZ0x5OGdJQ0FnSUhOamFHVmtkV3hsWDJsa0xBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hKbFpuVnVaRjloYlc5MWJuUXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0U1Tnpkall6ZGxJQzh2SUcxbGRHaHZaQ0FpVTJOb1pXUjFiR1ZEWVc1alpXeHNaV1FvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNelF4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1Q2IyOXNLRlJ5ZFdVcENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE9EQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TGtOeVpYTmpZVU5oYkdWdVpHRnlVR0Y1YldWdWRITXVhWE5mWlhobFkzVjBZV0pzWlNod1lYbGxjam9nWW5sMFpYTXNJSE5qYUdWa2RXeGxYMmxrT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21selgyVjRaV04xZEdGaWJHVTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNelF6TFRNME53b2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJQ01nVW1WaFpDMXZibXg1SUhacFpYZHpDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ0x5OGdaR1ZtSUdselgyVjRaV04xZEdGaWJHVW9jMlZzWml3Z2NHRjVaWEk2SUdGeVl6UXVRV1JrY21WemN5d2djMk5vWldSMWJHVmZhV1E2SUdGeVl6UXVWVWx1ZERZMEtTQXRQaUJoY21NMExrSnZiMnc2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek5Ea0tJQ0FnSUM4dklITmphR1ZrZFd4bFgydGxlU0E5SUY5elkyaGxaSFZzWlY5clpYa29jR0Y1WlhJdWJtRjBhWFpsTG1KNWRHVnpMQ0J6WTJobFpIVnNaVjlwWkM1dVlYUnBkbVVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG8yTWdvZ0lDQWdMeThnY21WMGRYSnVJSEJoZVdWeUlDc2diM0F1YVhSdllpaHpZMmhsWkhWc1pWOXBaQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TXpVd0NpQWdJQ0F2THlCcFppQnpZMmhsWkhWc1pWOXJaWGtnYm05MElHbHVJSE5sYkdZdWMyTm9aV1IxYkdWek9nb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEY3pOak0yT0RWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nYVhOZlpYaGxZM1YwWVdKc1pWOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek5URUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncHBjMTlsZUdWamRYUmhZbXhsWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TlRJS0lDQWdJQzh2SUhOamFHVmtkV3hsSUQwZ2MyVnNaaTV6WTJobFpIVnNaWE5iYzJOb1pXUjFiR1ZmYTJWNVhTNWpiM0I1S0NrS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMyTm9aV1IxYkdWeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak0xTXdvZ0lDQWdMeThnYVdZZ2JtOTBJSE5qYUdWa2RXeGxMbUZqZEdsMlpTNXVZWFJwZG1VNkNpQWdJQ0JwYm5SaklEUWdMeThnT0RNeUNpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpYm5vZ2FYTmZaWGhsWTNWMFlXSnNaVjloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3pOVFFLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29SbUZzYzJVcENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BwYzE5bGVHVmpkWFJoWW14bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek5UVUtJQ0FnSUM4dklHbG1JSE5qYUdWa2RXeGxMbVY0WldOMWRHVmtYMk52ZFc1MExtNWhkR2wyWlNBK1BTQnpZMmhsWkhWc1pTNXZZMk4xY25KbGJtTmxjeTV1WVhScGRtVTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRGsySUM4dklEazJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lIQjFjMmhwYm5RZ09EZ2dMeThnT0RnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0ErUFFvZ0lDQWdZbm9nYVhOZlpYaGxZM1YwWVdKc1pWOWhablJsY2w5cFpsOWxiSE5sUURZS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek5UWUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncHBjMTlsZUdWamRYUmhZbXhsWDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TlRjS0lDQWdJQzh2SUc1bGVIUmZaWGhsWXlBOUlITmphR1ZrZFd4bExtVjRaV04xZEdWZllYUXVibUYwYVhabElDc2dLQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EzTWlBdkx5QTNNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TlRnS0lDQWdJQzh2SUhOamFHVmtkV3hsTG1WNFpXTjFkR1ZrWDJOdmRXNTBMbTVoZEdsMlpTQXFJSE5qYUdWa2RXeGxMbWx1ZEdWeWRtRnNYM05sWTI5dVpITXVibUYwYVhabENpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJRGd3SUM4dklEZ3dDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUNvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek5UY3RNelU1Q2lBZ0lDQXZMeUJ1WlhoMFgyVjRaV01nUFNCelkyaGxaSFZzWlM1bGVHVmpkWFJsWDJGMExtNWhkR2wyWlNBcklDZ0tJQ0FnSUM4dklDQWdJQ0J6WTJobFpIVnNaUzVsZUdWamRYUmxaRjlqYjNWdWRDNXVZWFJwZG1VZ0tpQnpZMmhsWkhWc1pTNXBiblJsY25aaGJGOXpaV052Ym1SekxtNWhkR2wyWlFvZ0lDQWdMeThnS1FvZ0lDQWdLd29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak0yTUFvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVFtOXZiQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDQStQU0J1WlhoMFgyVjRaV01wQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQThQUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TGtOeVpYTmpZVU5oYkdWdVpHRnlVR0Y1YldWdWRITXVaMlYwWDI1bGVIUmZaWGhsWTNWMGFXOXVYM1JwYldVb2NHRjVaWEk2SUdKNWRHVnpMQ0J6WTJobFpIVnNaVjlwWkRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwblpYUmZibVY0ZEY5bGVHVmpkWFJwYjI1ZmRHbHRaVG9LSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TmpJdE16WTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdaMlYwWDI1bGVIUmZaWGhsWTNWMGFXOXVYM1JwYldVb0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3Z2NHRjVaWEk2SUdGeVl6UXVRV1JrY21WemN5d2djMk5vWldSMWJHVmZhV1E2SUdGeVl6UXVWVWx1ZERZMENpQWdJQ0F2THlBcElDMCtJR0Z5WXpRdVZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk16WTNDaUFnSUNBdkx5QnpZMmhsWkhWc1pWOXJaWGtnUFNCZmMyTm9aV1IxYkdWZmEyVjVLSEJoZVdWeUxtNWhkR2wyWlM1aWVYUmxjeXdnYzJOb1pXUjFiR1ZmYVdRdWJtRjBhWFpsS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TmpJS0lDQWdJQzh2SUhKbGRIVnliaUJ3WVhsbGNpQXJJRzl3TG1sMGIySW9jMk5vWldSMWJHVmZhV1FwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNMk9Bb2dJQ0FnTHk4Z2FXWWdjMk5vWldSMWJHVmZhMlY1SUc1dmRDQnBiaUJ6Wld4bUxuTmphR1ZrZFd4bGN6b0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzNNell6TmpnMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUdkbGRGOXVaWGgwWDJWNFpXTjFkR2x2Ymw5MGFXMWxYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTTJPUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ21kbGRGOXVaWGgwWDJWNFpXTjFkR2x2Ymw5MGFXMWxYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3pOekFLSUNBZ0lDOHZJSE5qYUdWa2RXeGxJRDBnYzJWc1ppNXpZMmhsWkhWc1pYTmJjMk5vWldSMWJHVmZhMlY1WFM1amIzQjVLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzJOb1pXUjFiR1Z6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTTNNUW9nSUNBZ0x5OGdhV1lnYm05MElITmphR1ZrZFd4bExtRmpkR2wyWlM1dVlYUnBkbVVnYjNJZ2MyTm9aV1IxYkdVdVpYaGxZM1YwWldSZlkyOTFiblF1Ym1GMGFYWmxJRDQ5SUhOamFHVmtkV3hsTG05alkzVnljbVZ1WTJWekxtNWhkR2wyWlRvS0lDQWdJR2x1ZEdNZ05DQXZMeUE0TXpJS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o2SUdkbGRGOXVaWGgwWDJWNFpXTjFkR2x2Ymw5MGFXMWxYMmxtWDJKdlpIbEFOQW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0E1TmlBdkx5QTVOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQndkWE5vYVc1MElEZzRJQzh2SURnNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnUGowS0lDQWdJR0o2SUdkbGRGOXVaWGgwWDJWNFpXTjFkR2x2Ymw5MGFXMWxYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb0taMlYwWDI1bGVIUmZaWGhsWTNWMGFXOXVYM1JwYldWZmFXWmZZbTlrZVVBME9nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTTNNZ29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ21kbGRGOXVaWGgwWDJWNFpXTjFkR2x2Ymw5MGFXMWxYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3pOelFLSUNBZ0lDOHZJSE5qYUdWa2RXeGxMbVY0WldOMWRHVmZZWFF1Ym1GMGFYWmxDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRGN5SUM4dklEY3lDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak0zTlFvZ0lDQWdMeThnS3lCelkyaGxaSFZzWlM1bGVHVmpkWFJsWkY5amIzVnVkQzV1WVhScGRtVWdLaUJ6WTJobFpIVnNaUzVwYm5SbGNuWmhiRjl6WldOdmJtUnpMbTVoZEdsMlpRb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0E0TUNBdkx5QTRNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNBcUNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk16YzBMVE0zTlFvZ0lDQWdMeThnYzJOb1pXUjFiR1V1WlhobFkzVjBaVjloZEM1dVlYUnBkbVVLSUNBZ0lDOHZJQ3NnYzJOb1pXUjFiR1V1WlhobFkzVjBaV1JmWTI5MWJuUXVibUYwYVhabElDb2djMk5vWldSMWJHVXVhVzUwWlhKMllXeGZjMlZqYjI1a2N5NXVZWFJwZG1VS0lDQWdJQ3NLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TnpNdE16YzJDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVWU1c1ME5qUW9DaUFnSUNBdkx5QWdJQ0FnYzJOb1pXUjFiR1V1WlhobFkzVjBaVjloZEM1dVlYUnBkbVVLSUNBZ0lDOHZJQ0FnSUNBcklITmphR1ZrZFd4bExtVjRaV04xZEdWa1gyTnZkVzUwTG01aGRHbDJaU0FxSUhOamFHVmtkV3hsTG1sdWRHVnlkbUZzWDNObFkyOXVaSE11Ym1GMGFYWmxDaUFnSUNBdkx5QXBDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1RGNtVnpZMkZEWVd4bGJtUmhjbEJoZVcxbGJuUnpMbWRsZEY5MGIzUmhiRjl6WTJobFpIVnNaWE1vS1NBdFBpQmllWFJsY3pvS1oyVjBYM1J2ZEdGc1gzTmphR1ZrZFd4bGN6b0tJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3pPREFLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDNOamFHVmtkV3hsY3k1MllXeDFaU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjBiM1JoYkY5elkyaGxaSFZzWlhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmMyTm9aV1IxYkdWeklHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMa055WlhOallVTmhiR1Z1WkdGeVVHRjViV1Z1ZEhNdVoyVjBYM1J2ZEdGc1gyVjRaV04xZEdWa0tDa2dMVDRnWW5sMFpYTTZDbWRsZEY5MGIzUmhiRjlsZUdWamRYUmxaRG9LSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96T0RRS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gyVjRaV04xZEdWa0xuWmhiSFZsS1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2ZEdGc1gyVjRaV04xZEdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyVjRaV04xZEdWa0lHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMa055WlhOallVTmhiR1Z1WkdGeVVHRjViV1Z1ZEhNdVoyVjBYM1Z6WlhKZmMyTm9aV1IxYkdWZlkyOTFiblFvZFhObGNqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncG5aWFJmZFhObGNsOXpZMmhsWkhWc1pWOWpiM1Z1ZERvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek9EWXRNemczQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNBdkx5QmtaV1lnWjJWMFgzVnpaWEpmYzJOb1pXUjFiR1ZmWTI5MWJuUW9jMlZzWml3Z2RYTmxjam9nWVhKak5DNUJaR1J5WlhOektTQXRQaUJoY21NMExsVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak00T0FvZ0lDQWdMeThnYVdZZ2RYTmxjaUJwYmlCelpXeG1Mbk5qYUdWa2RXeGxYMk52ZFc1MGN6b0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZzJNelpsTnpRMVpnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJuWlhSZmRYTmxjbDl6WTJobFpIVnNaVjlqYjNWdWRGOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek9Ea0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1Mbk5qYUdWa2RXeGxYMk52ZFc1MGMxdDFjMlZ5WFFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OamFHVmtkV3hsWDJOdmRXNTBjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0taMlYwWDNWelpYSmZjMk5vWldSMWJHVmZZMjkxYm5SZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNNU1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TGtOeVpYTmpZVU5oYkdWdVpHRnlVR0Y1YldWdWRITXVablZ1WkY5amIyNTBjbUZqZENod1lYbHRaVzUwWDNSNGJqb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tablZ1WkY5amIyNTBjbUZqZERvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek9USXRNemsyQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z0l5Qm1kVzVrWDJOdmJuUnlZV04wQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JR1oxYm1SZlkyOXVkSEpoWTNRb2MyVnNaaXdnY0dGNWJXVnVkRjkwZUc0NklHZDBlRzR1VUdGNWJXVnVkRlJ5WVc1ellXTjBhVzl1S1NBdFBpQmhjbU0wTGtKdmIydzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvME1ESUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwWDNSNGJpNXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0FpVFhWemRDQnpaVzVrSUhSdklHTnZiblJ5WVdOMElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVFhWemRDQnpaVzVrSUhSdklHTnZiblJ5WVdOMENpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk5EQXpDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEY5MGVHNHVZVzF2ZFc1MElENGdWVWx1ZERZMEtEQXBMQ0FpUVcxdmRXNTBJRzExYzNRZ1ltVWdQaUF3SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiVzkxYm5RZ2JYVnpkQ0JpWlNBK0lEQUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUbzBNRFFLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29WSEoxWlNrS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnNE1Bb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUZBUUFJSU1BR0pnZ0VGUjk4ZFFFQUNBQUFBQUFBQUFBQUJITmphRjhQZEc5MFlXeGZjMk5vWldSMWJHVnpEblJ2ZEdGc1gyVjRaV04xZEdWa0FZQUVZMjUwWHpFWVFBQUlKd1FqWnljRkkyY3hHMEVCMW9JTEJHSjRrSXdFcU9qUGNBUktsV2grQkpkcm05SUUweEsxWlFTVWNWRkFCSkVqemJJRWhtVk02QVRUOS9rWEJKZEtJalFFRldSMXFEWWFBSTRMQVVBQkRnRE1BS3dBbEFCMEFGUUFSQUEwQUJ3QUFpTkRNUmtVUkRFWVJERVdJZ2xKT0JBaUVrU0lCUFlvVEZDd0lrTXhHUlJFTVJoRU5ob0JTUlVsRWtTSUJNWW9URkN3SWtNeEdSUkVNUmhFaUFTdktFeFFzQ0pETVJrVVJERVlSSWdFbUNoTVVMQWlRekVaRkVReEdFUTJHZ0ZKRlNVU1JEWWFBa2tWSkJKRWlBUWRLRXhRc0NKRE1Sa1VSREVZUkRZYUFVa1ZKUkpFTmhvQ1NSVWtFa1NJQTVjb1RGQ3dJa014R1JSRU1SaEVOaG9CU1JVa0VrU0lBdHdvVEZDd0lrTXhHUlJFTVJoRU5ob0JTUlVsRWtRMkdnSkpGU1FTUklnQnhDaE1VTEFpUXpFWkZFUXhHRVF4RmlJSlNUZ1FJaEpFTmhvQlNSVWxFa1EyR2dKSkZTUVNSRFlhQTBrVkpCSkVOaG9FU1JVa0VrUTJHZ1ZKRlNRU1JJZ0JaaWhNVUxBaVF6RVpGRVF4R0VReEZpSUpTVGdRSWhKRU5ob0JTUlVsRWtRMkdnSkpGU1FTUkRZYUEwa1ZKQkpFaUFFYUtFeFFzQ0pETVJrVVJERVlSREVXSWdsSk9CQWlFa1EyR2dGSkZTVVNSRFlhQWtrVkpCSkVOaG9EU1JVa0VrUTJHZ1JKRlNRU1JEWWFCVWtWSkJKRWlBQVJLRXhRc0NKRE1SbEEvbmt4R0JSRUlrT0tCZ0VqZ0FDTC9CZEpSSXY5RnpJSERVU0wveGRKUkl2Nk9BY3lDaEpFQzBtTCtqZ0lTVThDRDBReEFDY0hNUUJRU2IxRkFVRUFpNHNGdmtRWE1RQkxBUlpKakFCUWl3SkpUZ01XTWdjV2l3U0wrMUNML0ZDTC9WQ0wvbENMLzFBcVVDY0dVRThDVUV4UUswOENVRXkvSWdnV2l3Vk12eU1uQkdWRUlnZ25CRXhuaXdOTUNVbU1BVUVBRUxFeEFJc0JzZ2l5QnlLeUVDT3lBYk9ML2hjcEkwOENWSXNFaXdCSlRnTlFpL3RRaS94UWkvMVFURkNBQktDaVdKSk1VTENNQUlralF2OTJpZ1FCaS95TC9ZditpLzhxZ0FnQUFBQUFBQUFBQVlqL0lJbUtCZ0dML2hlQmdLTUZDeGFMK292N2kveUwvVThFaS8rSS93U0ppZ0lCaS84WEZvditURkFyVEZCSnZVVUJSRW0rUkVraEJGTXBJMDhDVkNOVFJFbUJZRnRMQVZkWUNFc0NnVmhiU3dKTEFReEVTd05YU0FoTEJJRklXMHNGVjFBSVN3YUJVRnRMQmd0UEFnZ3lCdzVFU3dXQmFWdExCbGRBQ0VzSGdVQmJTd0pMQVE5RVR3SkxBUWxQQnlJSVNVOEhEMHNJVndBZ1N3bFhJQ0JQQXhaTEF4UXBJMDhDVkU4RkZrOExWM0VJU3dWTEJWQkxDVkJQQzFCUENsQlBDbEJMQkZCUEExQlBBbEJNVUU4SFRMK3hUd1N5Q0VzQnNnY2lzaEFqc2dHelR3S0wvMUJKVGdWUEFsQlBBMUJNVUlBRXZMOWd2MHhRc0VFQUZTTW5CV1ZFSWdnbkJVeG5nQVJtY1NvSGl3QlFzQ2NHVEltS0FRRXhBRWNDaS84WEZsQXJURkJKdlVVQlJFbStSRWxYQUNCSlR3UVNSRXNCSVFSVEtTTlBBbFFqVTBSTEFZRnBXMGxPQTA0RVN3RlhJQ0JMQWxkQUNFc0RWMGdJU3dSWFVBaExCVmRZQ0VzR1YyQUlUd2RYY1FoUEIwOEhVRThHVUU4RlVFOEVVRThEVUU4Q1VDbFFLbEJNVUU4Q1RMOUJBQkN4TVFDTEFiSUlzZ2Npc2hBanNnR3ppd0VXaXdDTC8xQk1VSUFFcVhmTWZreFFzQ2NHakFDSmlnSUJJNEFBaS84WEZvditURkFyVEZCSnZVVUJRQUFFS1l3QWlZc0N2a3hKVGdLTUFFUWhCRk1wSTA4Q1ZDTlRRQUFFS1l3QWlZc0FTWUZnVzBsT0Fvd0JnVmhiRDBFQUJDbU1BSW1MQUVtQlNGdE1nVkJiaXdFTENESUhEaWtqVHdKVWpBQ0ppZ0lCSTRBQWkvOFhGb3YrVEZBclRGQkp2VVVCUUFBRUtvd0FpWXNDdmt4SlRnS01BRVFoQkZNcEkwOENWQ05UUVFBU2l3QkpnV0JiU1U0Q2pBR0JXRnNQUVFBRUtvd0FpWXNBU1lGSVcweUJVRnVMQVFzSUZvd0FpU01uQkdWRUZva2pKd1ZsUkJhSmlnRUJKd2VMLzFCSnZVVUJRUUFHaXdDK1JFeUpLa3lKaWdFQmkvODRCeklLRWtTTC96Z0lSQ2NHaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjExLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJTY2hlZHVsZUNyZWF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ2IiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJQYXltZW50RXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlNjaGVkdWxlQ29tcGxldGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlNjaGVkdWxlQ2FuY2VsbGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
