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

namespace Arc56.Generated.Parthkk90.Algorand_cresca.CrescaCalendarPayments_0ce9dad7
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3Jlc2NhQ2FsZW5kYXJQYXltZW50cyIsImRlc2MiOiJcbiAgICBTY2hlZHVsZWQgYW5kIHJlY3VycmluZyBwYXltZW50IGNvbnRyYWN0IG9uIEFsZ29yYW5kLlxuXG4gICAgU3RhdGUgbGF5b3V0OlxuICAgIC0gR2xvYmFsOiB0b3RhbF9zY2hlZHVsZXMsIHRvdGFsX2V4ZWN1dGVkLCBzY2hlZHVsZV9jb3VudF9wZXJfdXNlciAoQm94TWFwKVxuICAgIC0gQm94ZXM6ICBvbmUgQm94PFNjaGVkdWxlPiBwZXIgKHBheWVyLCBzY2hlZHVsZV9pZCkgcGFpclxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTY2hlZHVsZSI6W3sibmFtZSI6InBheWVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJyZWNpcGllbnQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJleGVjdXRlX2F0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImludGVydmFsX3NlY29uZHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoib2NjdXJyZW5jZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZXhlY3V0ZWRfY291bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWN0aXZlIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJlc2Nyb3dfYmFsYW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjcmVhdGVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfc2NoZWR1bGUiLCJkZXNjIjoiQ3JlYXRlIGEgb25lLXRpbWUgb3IgcmVjdXJyaW5nIHBheW1lbnQgc2NoZWR1bGUuXG5UaGUgY2FsbGVyIG11c3QgYXR0YWNoIGEgUGF5bWVudFRyYW5zYWN0aW9uIGNvdmVyaW5nIGFtb3VudCAqIG9jY3VycmVuY2VzIM68QUxHTyAocGx1cyB0aGUgY29udHJhY3QncyBtaW4tYmFsYW5jZSBidW1wIGZvciB0aGUgbmV3IEJveCBzdG9yYWdlIOKAlCBoYW5kbGVkIHNlcGFyYXRlbHkgdmlhIGZ1bmRfY29udHJhY3QoKSkuXG5SZXR1cm5zIHRoZSBuZXcgc2NoZWR1bGVfaWQuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4ZWN1dGVfYXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVydmFsX3NlY29uZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9jY3VycmVuY2VzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlNjaGVkdWxlQ3JlYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDYiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfb25lX3RpbWVfcGF5bWVudCIsImRlc2MiOiJDb252ZW5pZW5jZTogc2NoZWR1bGUgYSBzaW5nbGUgZnV0dXJlIHBheW1lbnQuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4ZWN1dGVfYXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiU2NoZWR1bGVDcmVhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ1IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZV9yZWN1cnJpbmdfcGF5bWVudCIsImRlc2MiOiJDb252ZW5pZW5jZTogc2NoZWR1bGUgYSByZWN1cnJpbmcgcGF5bWVudCBldmVyeSBOIGRheXMuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnRfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpcnN0X2V4ZWN1dGlvbl9hdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW50ZXJ2YWxfZGF5cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib2NjdXJyZW5jZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiU2NoZWR1bGVDcmVhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ1IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4ZWN1dGVfc2NoZWR1bGUiLCJkZXNjIjoiRXhlY3V0ZSBhIGR1ZSBzY2hlZHVsZWQgcGF5bWVudC4gQW55b25lIGNhbiBjYWxsIHRoaXMgKGtlZXBlci9ib3QgcGF0dGVybikuXG5SZXZlcnRzIGlmOiAtIFNjaGVkdWxlIGRvZXNuJ3QgZXhpc3Qgb3IgaXMgaW5hY3RpdmUuIC0gUGF5bWVudCBpcyBub3QgeWV0IGR1ZS4gLSBFc2Nyb3cgaXMgaW5zdWZmaWNpZW50LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjaGVkdWxlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJQYXltZW50RXhlY3V0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlNjaGVkdWxlQ29tcGxldGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW5jZWxfc2NoZWR1bGUiLCJkZXNjIjoiQ2FuY2VsIGEgc2NoZWR1bGUgYW5kIHJlZnVuZCByZW1haW5pbmcgZXNjcm93IHRvIHRoZSBwYXllci5cbk9ubHkgdGhlIHBheWVyIGNhbiBjYW5jZWwuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjaGVkdWxlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJTY2hlZHVsZUNhbmNlbGxlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfZXhlY3V0YWJsZSIsImRlc2MiOiJDaGVjayB3aGV0aGVyIGEgc2NoZWR1bGUgaXMgY3VycmVudGx5IGV4ZWN1dGFibGUuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXllciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NoZWR1bGVfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbmV4dF9leGVjdXRpb25fdGltZSIsImRlc2MiOiJSZXR1cm5zIHRoZSBVbml4IHRpbWVzdGFtcCBvZiB0aGUgbmV4dCBkdWUgZXhlY3V0aW9uICgwIGlmIGluYWN0aXZlKS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY2hlZHVsZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RvdGFsX3NjaGVkdWxlcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RvdGFsX2V4ZWN1dGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdXNlcl9zY2hlZHVsZV9jb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnVuZF9jb250cmFjdCIsImRlc2MiOiJJbmNyZWFzZSB0aGUgY29udHJhY3QncyBtaW5pbXVtIGJhbGFuY2UgdG8gY292ZXIgQm94IHN0b3JhZ2UgY29zdHMuXG5FYWNoIFNjaGVkdWxlIEJveCBjb3N0cyB+MC4wMDI1IEFMR08gKyBieXRlLWJhc2VkIGZlZXMuIENhbGwgdGhpcyBiZWZvcmUgY3JlYXRpbmcgc2NoZWR1bGVzIGlmIHRoZSBjb250cmFjdCBpcyB1bmRlcmZ1bmRlZC4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudF90eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0NDVdLCJlcnJvck1lc3NhZ2UiOiJBbGwgcGF5bWVudHMgZG9uZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMTUsMTEzMl0sImVycm9yTWVzc2FnZSI6IkFtb3VudCBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5Nl0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBlc2Nyb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTYzXSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IGVzY3JvdyBmdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMTJdLCJlcnJvck1lc3NhZ2UiOiJNdXN0IHNlbmQgdG8gY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzVdLCJlcnJvck1lc3NhZ2UiOiJOb3QgeWV0IGV4ZWN1dGFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTUyXSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBtdXN0IHRhcmdldCBjb250cmFjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyNSw2OTNdLCJlcnJvck1lc3NhZ2UiOiJTY2hlZHVsZSBhbHJlYWR5IGNvbXBsZXRlZC9jYW5jZWxsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTAsNjY4XSwiZXJyb3JNZXNzYWdlIjoiU2NoZWR1bGUgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjgwXSwiZXJyb3JNZXNzYWdlIjoiVW5hdXRob3JpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA4NCwxMTgxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zY2hlZHVsZV9jb3VudHMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODcyLDk4NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc2NoZWR1bGVzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxOSwxMDU1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9leGVjdXRlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDQzLDEyNTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3NjaGVkdWxlcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTM5XSwiZXJyb3JNZXNzYWdlIjoiZXhlY3V0ZV9hdCBtdXN0IGJlIGluIGZ1dHVyZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwOCwyNjcsMzIyLDM4Nyw4MzUsOTQ3LDEwNzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE2LDIyNCwyMzIsMjQwLDI3NSwyODMsMzMwLDMzOCwzNDYsMzU0LDM5NSw2NDksODQzLDk1NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNDRdLCJlcnJvck1lc3NhZ2UiOiJvY2N1cnJlbmNlcyBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMCwyNTksMzE0LDExMDVdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnT0NBek1pQTRNeklLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd3TUNBd2VERTFNV1kzWXpjMUlEQjROek0yTXpZNE5XWWdJblJ2ZEdGc1gzTmphR1ZrZFd4bGN5SWdJblJ2ZEdGc1gyVjRaV04xZEdWa0lpQXdlREF3TURBd01EQXdNREF3TURBd01EQWdNSGd4TlRGbU4yTTNOVGd3SURCNE5qTTJaVGMwTldZS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG80T0FvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5elkyaGxaSFZzWlhNZ1BTQkhiRzlpWVd4VGRHRjBaU2hWU1c1ME5qUW9NQ2twQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYjNSaGJGOXpZMmhsWkhWc1pYTWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUbzRPUW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjlsZUdWamRYUmxaQ0E5SUVkc2IySmhiRk4wWVhSbEtGVkpiblEyTkNnd0tTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnZkR0ZzWDJWNFpXTjFkR1ZrSWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUbzJPUW9nSUNBZ0x5OGdZMnhoYzNNZ1EzSmxjMk5oUTJGc1pXNWtZWEpRWVhsdFpXNTBjeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNakFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFl5TnpnNU1EaGpJREI0WVRobE9HTm1OekFnTUhnMFlUazFOamczWlNBd2VEazNObUk1WW1ReUlEQjRaRE14TW1JMU5qVWdNSGc1TkRjeE5URTBNQ0F3ZURreE1qTmpaR0l5SURCNE9EWTJOVFJqWlRnZ01IaGtNMlkzWmpreE55QXdlRGszTkdFeU1qTTBJREI0TVRVMk5EYzFZVGdnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZmYzJOb1pXUjFiR1VvY0dGNUxHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVkzSmxZWFJsWDI5dVpWOTBhVzFsWDNCaGVXMWxiblFvY0dGNUxHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbU55WldGMFpWOXlaV04xY25KcGJtZGZjR0Y1YldWdWRDaHdZWGtzWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0psZUdWamRYUmxYM05qYUdWa2RXeGxLR0ZrWkhKbGMzTXNkV2x1ZERZMEtXSnZiMndpTENCdFpYUm9iMlFnSW1OaGJtTmxiRjl6WTJobFpIVnNaU2gxYVc1ME5qUXBZbTl2YkNJc0lHMWxkR2h2WkNBaWFYTmZaWGhsWTNWMFlXSnNaU2hoWkdSeVpYTnpMSFZwYm5RMk5DbGliMjlzSWl3Z2JXVjBhRzlrSUNKblpYUmZibVY0ZEY5bGVHVmpkWFJwYjI1ZmRHbHRaU2hoWkdSeVpYTnpMSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjkwYjNSaGJGOXpZMmhsWkhWc1pYTW9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDNSdmRHRnNYMlY0WldOMWRHVmtLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5MWMyVnlYM05qYUdWa2RXeGxYMk52ZFc1MEtHRmtaSEpsYzNNcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKbWRXNWtYMk52Ym5SeVlXTjBLSEJoZVNsaWIyOXNJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxYM05qYUdWa2RXeGxJR055WldGMFpWOXZibVZmZEdsdFpWOXdZWGx0Wlc1MElHTnlaV0YwWlY5eVpXTjFjbkpwYm1kZmNHRjViV1Z1ZENCbGVHVmpkWFJsWDNOamFHVmtkV3hsSUdOaGJtTmxiRjl6WTJobFpIVnNaU0JwYzE5bGVHVmpkWFJoWW14bElHZGxkRjl1WlhoMFgyVjRaV04xZEdsdmJsOTBhVzFsSUdkbGRGOTBiM1JoYkY5elkyaGxaSFZzWlhNZ1oyVjBYM1J2ZEdGc1gyVjRaV04xZEdWa0lHZGxkRjkxYzJWeVgzTmphR1ZrZFd4bFgyTnZkVzUwSUdaMWJtUmZZMjl1ZEhKaFkzUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF5TURvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMa055WlhOallVTmhiR1Z1WkdGeVVHRjViV1Z1ZEhNdVkzSmxZWFJsWDNOamFHVmtkV3hsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDNOamFHVmtkV3hsT2dvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2prekxUazJDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnSXlCamNtVmhkR1ZmYzJOb1pXUjFiR1VLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZMkZzYkhOMVlpQmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdVEzSmxjMk5oUTJGc1pXNWtZWEpRWVhsdFpXNTBjeTVqY21WaGRHVmZjMk5vWldSMWJHVUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11UTNKbGMyTmhRMkZzWlc1a1lYSlFZWGx0Wlc1MGN5NWpjbVZoZEdWZmIyNWxYM1JwYldWZmNHRjViV1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlY5dmJtVmZkR2x0WlY5d1lYbHRaVzUwT2dvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pFM05TMHhOemdLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlBaklHTnlaV0YwWlY5dmJtVmZkR2x0WlY5d1lYbHRaVzUwSUNBb1kyOXVkbVZ1YVdWdVkyVWdkM0poY0hCbGNpa0tJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pFNU1nb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9NQ2tzSUNBZ0l5QnBiblJsY25aaGJDQTlJREFnNG9hU0lHOXVaUzEwYVcxbENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pFNU13b2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9NU2tzSUNBZ0l5QnZZMk4xY25KbGJtTmxjeUE5SURFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREVLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG94T0RjdE1UazBDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVqY21WaGRHVmZjMk5vWldSMWJHVW9DaUFnSUNBdkx5QWdJQ0FnY0dGNWJXVnVkRjkwZUc0c0NpQWdJQ0F2THlBZ0lDQWdjbVZqYVhCcFpXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbGVHVmpkWFJsWDJGMExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0RBcExDQWdJQ01nYVc1MFpYSjJZV3dnUFNBd0lPS0draUJ2Ym1VdGRHbHRaUW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtERXBMQ0FnSUNNZ2IyTmpkWEp5Wlc1alpYTWdQU0F4Q2lBZ0lDQXZMeUFwQ2lBZ0lDQmpZV3hzYzNWaUlHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1RGNtVnpZMkZEWVd4bGJtUmhjbEJoZVcxbGJuUnpMbU55WldGMFpWOXpZMmhsWkhWc1pRb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qRTNOUzB4TnpnS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QWpJR055WldGMFpWOXZibVZmZEdsdFpWOXdZWGx0Wlc1MElDQW9ZMjl1ZG1WdWFXVnVZMlVnZDNKaGNIQmxjaWtLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMa055WlhOallVTmhiR1Z1WkdGeVVHRjViV1Z1ZEhNdVkzSmxZWFJsWDNKbFkzVnljbWx1WjE5d1lYbHRaVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDNKbFkzVnljbWx1WjE5d1lYbHRaVzUwT2dvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pFNU5pMHhPVGtLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlBaklHTnlaV0YwWlY5eVpXTjFjbkpwYm1kZmNHRjViV1Z1ZENBZ0tHTnZiblpsYm1sbGJtTmxJSGR5WVhCd1pYSXBDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG95TVRBS0lDQWdJQzh2SUdsdWRHVnlkbUZzWDNObFkyOXVaSE1nUFNCaGNtTTBMbFZKYm5RMk5DaHBiblJsY25aaGJGOWtZWGx6TG01aGRHbDJaU0FxSUZWSmJuUTJOQ2c0TmpRd01Da3BDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCd2RYTm9hVzUwSURnMk5EQXdDaUFnSUNBcUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1qRXhMVEl4T0FvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVkzSmxZWFJsWDNOamFHVmtkV3hsS0FvZ0lDQWdMeThnSUNBZ0lIQmhlVzFsYm5SZmRIaHVMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdabWx5YzNSZlpYaGxZM1YwYVc5dVgyRjBMQW9nSUNBZ0x5OGdJQ0FnSUdsdWRHVnlkbUZzWDNObFkyOXVaSE1zQ2lBZ0lDQXZMeUFnSUNBZ2IyTmpkWEp5Wlc1alpYTXNDaUFnSUNBdkx5QXBDaUFnSUNCamIzWmxjaUExQ2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTJGc2JITjFZaUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVRM0psYzJOaFEyRnNaVzVrWVhKUVlYbHRaVzUwY3k1amNtVmhkR1ZmYzJOb1pXUjFiR1VLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG94T1RZdE1UazVDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnSXlCamNtVmhkR1ZmY21WamRYSnlhVzVuWDNCaGVXMWxiblFnSUNoamIyNTJaVzVwWlc1alpTQjNjbUZ3Y0dWeUtRb2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdVEzSmxjMk5oUTJGc1pXNWtZWEpRWVhsdFpXNTBjeTVsZUdWamRYUmxYM05qYUdWa2RXeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWlhobFkzVjBaVjl6WTJobFpIVnNaVG9LSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG95TWpBdE1qSXpDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnSXlCbGVHVmpkWFJsWDNOamFHVmtkV3hsQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNak0zQ2lBZ0lDQXZMeUJ6WTJobFpIVnNaVjlyWlhrZ1BTQmZjMk5vWldSMWJHVmZhMlY1S0hCaGVXVnlMbTVoZEdsMlpTNWllWFJsY3l3Z2MyTm9aV1IxYkdWZmFXUXVibUYwYVhabEtRb2dJQ0FnWkhWd0NpQWdJQ0JpZEc5cENpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk5qSUtJQ0FnSUM4dklISmxkSFZ5YmlCd1lYbGxjaUFySUc5d0xtbDBiMklvYzJOb1pXUjFiR1ZmYVdRcENpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pJek9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhOamFHVmtkV3hsWDJ0bGVTQnBiaUJ6Wld4bUxuTmphR1ZrZFd4bGN5d2dJbE5qYUdWa2RXeGxJRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGczTXpZek5qZzFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUZOamFHVmtkV3hsSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pJME1Bb2dJQ0FnTHk4Z2MyTm9aV1IxYkdVZ1BTQnpaV3htTG5OamFHVmtkV3hsYzF0elkyaGxaSFZzWlY5clpYbGRMbU52Y0hrb0tRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3lORElLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpZMmhsWkhWc1pTNWhZM1JwZG1VdWJtRjBhWFpsTENBaVUyTm9aV1IxYkdVZ1lXeHlaV0ZrZVNCamIyMXdiR1YwWldRdlkyRnVZMlZzYkdWa0lnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEUWdMeThnT0RNeUNpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JoYzNObGNuUWdMeThnVTJOb1pXUjFiR1VnWVd4eVpXRmtlU0JqYjIxd2JHVjBaV1F2WTJGdVkyVnNiR1ZrQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TWpRekNpQWdJQ0F2THlCaGMzTmxjblFnYzJOb1pXUjFiR1V1WlhobFkzVjBaV1JmWTI5MWJuUXVibUYwYVhabElEd2djMk5vWldSMWJHVXViMk5qZFhKeVpXNWpaWE11Ym1GMGFYWmxMQ0FpUVd4c0lIQmhlVzFsYm5SeklHUnZibVVpQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ09UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBNE9DQTRDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBNE9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUVGc2JDQndZWGx0Wlc1MGN5QmtiMjVsQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TWpRMUxUSTBOZ29nSUNBZ0x5OGdJeUJEWVd4amRXeGhkR1VnYm1WNGRDQmxlR1ZqZFhScGIyNGdkR2x0WlFvZ0lDQWdMeThnYm1WNGRGOWxlR1ZqSUQwZ2MyTm9aV1IxYkdVdVpYaGxZM1YwWlY5aGRDNXVZWFJwZG1VZ0t5QW9DaUFnSUNCa2FXY2dNd29nSUNBZ1pYaDBjbUZqZENBM01pQTRDaUFnSUNCa2FXY2dOQW9nSUNBZ2NIVnphR2x1ZENBM01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3lORGNLSUNBZ0lDOHZJSE5qYUdWa2RXeGxMbVY0WldOMWRHVmtYMk52ZFc1MExtNWhkR2wyWlNBcUlITmphR1ZrZFd4bExtbHVkR1Z5ZG1Gc1gzTmxZMjl1WkhNdWJtRjBhWFpsQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaWGgwY21GamRDQTRNQ0E0Q2lBZ0lDQmthV2NnTmdvZ0lDQWdjSFZ6YUdsdWRDQTRNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQXFDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNalExTFRJME9Bb2dJQ0FnTHk4Z0l5QkRZV3hqZFd4aGRHVWdibVY0ZENCbGVHVmpkWFJwYjI0Z2RHbHRaUW9nSUNBZ0x5OGdibVY0ZEY5bGVHVmpJRDBnYzJOb1pXUjFiR1V1WlhobFkzVjBaVjloZEM1dVlYUnBkbVVnS3lBb0NpQWdJQ0F2THlBZ0lDQWdjMk5vWldSMWJHVXVaWGhsWTNWMFpXUmZZMjkxYm5RdWJtRjBhWFpsSUNvZ2MyTm9aV1IxYkdVdWFXNTBaWEoyWVd4ZmMyVmpiMjVrY3k1dVlYUnBkbVVLSUNBZ0lDOHZJQ2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pJME9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJRDQ5SUc1bGVIUmZaWGhsWXl3Z0lrNXZkQ0I1WlhRZ1pYaGxZM1YwWVdKc1pTSUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVG05MElIbGxkQ0JsZUdWamRYUmhZbXhsQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TWpVd0NpQWdJQ0F2THlCaGMzTmxjblFnYzJOb1pXUjFiR1V1WlhOamNtOTNYMkpoYkdGdVkyVXVibUYwYVhabElENDlJSE5qYUdWa2RXeGxMbUZ0YjNWdWRDNXVZWFJwZG1Vc0lDSkpibk4xWm1acFkybGxiblFnWlhOamNtOTNJZ29nSUNBZ1pHbG5JRFVLSUNBZ0lIQjFjMmhwYm5RZ01UQTFDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHVjRkSEpoWTNRZ05qUWdPQW9nSUNBZ1pHbG5JRGNLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JREVLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNXpkV1ptYVdOcFpXNTBJR1Z6WTNKdmR3b2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qSTFNaTB5TlRNS0lDQWdJQzh2SUNNZ1JHVmtkV04wSUdaeWIyMGdaWE5qY205M0lHRnVaQ0JwYm1OeVpXMWxiblFnWTI5MWJuUUtJQ0FnSUM4dklHNWxkMTlpWVd4aGJtTmxJRDBnYzJOb1pXUjFiR1V1WlhOamNtOTNYMkpoYkdGdVkyVXVibUYwYVhabElDMGdjMk5vWldSMWJHVXVZVzF2ZFc1MExtNWhkR2wyWlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNUW9nSUNBZ0xRb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qSTFOQW9nSUNBZ0x5OGdibVYzWDJOdmRXNTBJRDBnYzJOb1pXUjFiR1V1WlhobFkzVjBaV1JmWTI5MWJuUXVibUYwYVhabElDc2dWVWx1ZERZMEtERXBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNalUxQ2lBZ0lDQXZMeUJwYzE5a2IyNWxJRDBnYm1WM1gyTnZkVzUwSUQ0OUlITmphR1ZrZFd4bExtOWpZM1Z5Y21WdVkyVnpMbTVoZEdsMlpRb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lENDlDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNalU0Q2lBZ0lDQXZMeUJ3WVhsbGNqMXpZMmhsWkhWc1pTNXdZWGxsY2l3S0lDQWdJR1JwWnlBNENpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveU5Ua0tJQ0FnSUM4dklISmxZMmx3YVdWdWREMXpZMmhsWkhWc1pTNXlaV05wY0dsbGJuUXNDaUFnSUNCa2FXY2dPUW9nSUNBZ1pYaDBjbUZqZENBek1pQXpNZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakkyTkFvZ0lDQWdMeThnWlhobFkzVjBaV1JmWTI5MWJuUTlZWEpqTkM1VlNXNTBOalFvYm1WM1gyTnZkVzUwS1N3S0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakkyTlFvZ0lDQWdMeThnWVdOMGFYWmxQV0Z5WXpRdVFtOXZiQ2h1YjNRZ2FYTmZaRzl1WlNrc0NpQWdJQ0JrYVdjZ013b2dJQ0FnSVFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG95TmpZS0lDQWdJQzh2SUdWelkzSnZkMTlpWVd4aGJtTmxQV0Z5WXpRdVZVbHVkRFkwS0c1bGQxOWlZV3hoYm1ObEtTd0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pJMk53b2dJQ0FnTHk4Z1kzSmxZWFJsWkY5aGREMXpZMmhsWkhWc1pTNWpjbVZoZEdWa1gyRjBMQW9nSUNBZ2RXNWpiM1psY2lBeE1Rb2dJQ0FnWlhoMGNtRmpkQ0F4TVRNZ09Bb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qSTFOeTB5TmpnS0lDQWdJQzh2SUhObGJHWXVjMk5vWldSMWJHVnpXM05qYUdWa2RXeGxYMnRsZVYwZ1BTQlRZMmhsWkhWc1pTZ0tJQ0FnSUM4dklDQWdJQ0J3WVhsbGNqMXpZMmhsWkhWc1pTNXdZWGxsY2l3S0lDQWdJQzh2SUNBZ0lDQnlaV05wY0dsbGJuUTljMk5vWldSMWJHVXVjbVZqYVhCcFpXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF6WTJobFpIVnNaUzVoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWlhobFkzVjBaVjloZEQxelkyaGxaSFZzWlM1bGVHVmpkWFJsWDJGMExBb2dJQ0FnTHk4Z0lDQWdJR2x1ZEdWeWRtRnNYM05sWTI5dVpITTljMk5vWldSMWJHVXVhVzUwWlhKMllXeGZjMlZqYjI1a2N5d0tJQ0FnSUM4dklDQWdJQ0J2WTJOMWNuSmxibU5sY3oxelkyaGxaSFZzWlM1dlkyTjFjbkpsYm1ObGN5d0tJQ0FnSUM4dklDQWdJQ0JsZUdWamRYUmxaRjlqYjNWdWREMWhjbU0wTGxWSmJuUTJOQ2h1WlhkZlkyOTFiblFwTEFvZ0lDQWdMeThnSUNBZ0lHRmpkR2wyWlQxaGNtTTBMa0p2YjJ3b2JtOTBJR2x6WDJSdmJtVXBMQW9nSUNBZ0x5OGdJQ0FnSUdWelkzSnZkMTlpWVd4aGJtTmxQV0Z5WXpRdVZVbHVkRFkwS0c1bGQxOWlZV3hoYm1ObEtTd0tJQ0FnSUM4dklDQWdJQ0JqY21WaGRHVmtYMkYwUFhOamFHVmtkV3hsTG1OeVpXRjBaV1JmWVhRc0NpQWdJQ0F2THlBcENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkdsbklEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRGtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01UQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakkzTUMweU56VUtJQ0FnSUM4dklDTWdVMlZ1WkNCd1lYbHRaVzUwSUhSdklISmxZMmx3YVdWdWRBb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhOamFHVmtkV3hsTG5KbFkybHdhV1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhOamFHVmtkV3hsTG1GdGIzVnVkQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pJM01DMHlOekVLSUNBZ0lDOHZJQ01nVTJWdVpDQndZWGx0Wlc1MElIUnZJSEpsWTJsd2FXVnVkQW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakkzTkFvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3lOekF0TWpjMUNpQWdJQ0F2THlBaklGTmxibVFnY0dGNWJXVnVkQ0IwYnlCeVpXTnBjR2xsYm5RS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF6WTJobFpIVnNaUzV5WldOcGNHbGxiblF1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF6WTJobFpIVnNaUzVoYlc5MWJuUXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveU56Y3RNamcwQ2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvQ2lBZ0lDQXZMeUFnSUNBZ0lsQmhlVzFsYm5SRmVHVmpkWFJsWkNoaFpHUnlaWE56TEhWcGJuUTJOQ3hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRcElpd0tJQ0FnSUM4dklDQWdJQ0J6WTJobFpIVnNaUzV3WVhsbGNpd0tJQ0FnSUM4dklDQWdJQ0J6WTJobFpIVnNaVjlwWkN3S0lDQWdJQzh2SUNBZ0lDQnpZMmhsWkhWc1pTNXlaV05wY0dsbGJuUXNDaUFnSUNBdkx5QWdJQ0FnYzJOb1pXUjFiR1V1WVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtHNWxkMTlqYjNWdWRDa3NDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhpWTJKbU5qQmlaaUF2THlCdFpYUm9iMlFnSWxCaGVXMWxiblJGZUdWamRYUmxaQ2hoWkdSeVpYTnpMSFZwYm5RMk5DeGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveU9EWUtJQ0FnSUM4dklHbG1JR2x6WDJSdmJtVTZDaUFnSUNCaWVpQmxlR1ZqZFhSbFgzTmphR1ZrZFd4bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pJNE53b2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOWxlR1ZqZFhSbFpDNTJZV3gxWlNBOUlITmxiR1l1ZEc5MFlXeGZaWGhsWTNWMFpXUXVkbUZzZFdVZ0t5QlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGIzUmhiRjlsZUdWamRYUmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjlsZUdWamRYUmxaQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0owYjNSaGJGOWxlR1ZqZFhSbFpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNamc0TFRJNU1nb2dJQ0FnTHk4Z1lYSmpOQzVsYldsMEtBb2dJQ0FnTHk4Z0lDQWdJQ0pUWTJobFpIVnNaVU52YlhCc1pYUmxaQ2hoWkdSeVpYTnpMSFZwYm5RMk5Da2lMQW9nSUNBZ0x5OGdJQ0FnSUhOamFHVmtkV3hsTG5CaGVXVnlMQW9nSUNBZ0x5OGdJQ0FnSUhOamFHVmtkV3hsWDJsa0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5qWTNNVEpoTURjZ0x5OGdiV1YwYUc5a0lDSlRZMmhsWkhWc1pVTnZiWEJzWlhSbFpDaGhaR1J5WlhOekxIVnBiblEyTkNraUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tDbVY0WldOMWRHVmZjMk5vWldSMWJHVmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qSXlNQzB5TWpNS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QWpJR1Y0WldOMWRHVmZjMk5vWldSMWJHVUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TVRVeFpqZGpOelU0TUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxrTnlaWE5qWVVOaGJHVnVaR0Z5VUdGNWJXVnVkSE11WTJGdVkyVnNYM05qYUdWa2RXeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJGdVkyVnNYM05qYUdWa2RXeGxPZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakk1TmkweU9Ua0tJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUFqSUdOaGJtTmxiRjl6WTJobFpIVnNaUW9nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TURVS0lDQWdJQzh2SUhCaGVXVnlYMkZrWkhJZ1BTQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk16QTJDaUFnSUNBdkx5QnpZMmhsWkhWc1pWOXJaWGtnUFNCZmMyTm9aV1IxYkdWZmEyVjVLRlI0Ymk1elpXNWtaWEl1WW5sMFpYTXNJSE5qYUdWa2RXeGxYMmxrTG01aGRHbDJaU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUbzJNZ29nSUNBZ0x5OGdjbVYwZFhKdUlIQmhlV1Z5SUNzZ2IzQXVhWFJ2WWloelkyaGxaSFZzWlY5cFpDa0tJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak13TndvZ0lDQWdMeThnWVhOelpYSjBJSE5qYUdWa2RXeGxYMnRsZVNCcGJpQnpaV3htTG5OamFHVmtkV3hsY3l3Z0lsTmphR1ZrZFd4bElHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzNNell6TmpnMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRk5qYUdWa2RXeGxJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak13T1FvZ0lDQWdMeThnYzJOb1pXUjFiR1VnUFNCelpXeG1Mbk5qYUdWa2RXeGxjMXR6WTJobFpIVnNaVjlyWlhsZExtTnZjSGtvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek1URUtJQ0FnSUM4dklHRnpjMlZ5ZENCelkyaGxaSFZzWlM1d1lYbGxjaUE5UFNCd1lYbGxjbDloWkdSeUxDQWlWVzVoZFhSb2IzSnBlbVZrSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRlZ1WVhWMGFHOXlhWHBsWkFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNeE1nb2dJQ0FnTHk4Z1lYTnpaWEowSUhOamFHVmtkV3hsTG1GamRHbDJaUzV1WVhScGRtVXNJQ0pUWTJobFpIVnNaU0JoYkhKbFlXUjVJR052YlhCc1pYUmxaQzlqWVc1alpXeHNaV1FpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWXlBMElDOHZJRGd6TWdvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZWE56WlhKMElDOHZJRk5qYUdWa2RXeGxJR0ZzY21WaFpIa2dZMjl0Y0d4bGRHVmtMMk5oYm1ObGJHeGxaQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak14TkFvZ0lDQWdMeThnY21WbWRXNWtYMkZ0YjNWdWRDQTlJSE5qYUdWa2RXeGxMbVZ6WTNKdmQxOWlZV3hoYm1ObExtNWhkR2wyWlFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNVEExSURnS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURFd05Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1kyOTJaWElnTkFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNeE9Rb2dJQ0FnTHk4Z2NtVmphWEJwWlc1MFBYTmphR1ZrZFd4bExuSmxZMmx3YVdWdWRDd0tJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNekl3Q2lBZ0lDQXZMeUJoYlc5MWJuUTljMk5vWldSMWJHVXVZVzF2ZFc1MExBb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTmpRZ09Bb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTXlNUW9nSUNBZ0x5OGdaWGhsWTNWMFpWOWhkRDF6WTJobFpIVnNaUzVsZUdWamRYUmxYMkYwTEFvZ0lDQWdaR2xuSURNS0lDQWdJR1Y0ZEhKaFkzUWdOeklnT0FvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNeU1nb2dJQ0FnTHk4Z2FXNTBaWEoyWVd4ZmMyVmpiMjVrY3oxelkyaGxaSFZzWlM1cGJuUmxjblpoYkY5elpXTnZibVJ6TEFvZ0lDQWdaR2xuSURRS0lDQWdJR1Y0ZEhKaFkzUWdPREFnT0FvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNeU13b2dJQ0FnTHk4Z2IyTmpkWEp5Wlc1alpYTTljMk5vWldSMWJHVXViMk5qZFhKeVpXNWpaWE1zQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaWGgwY21GamRDQTRPQ0E0Q2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TXpJMENpQWdJQ0F2THlCbGVHVmpkWFJsWkY5amIzVnVkRDF6WTJobFpIVnNaUzVsZUdWamRYUmxaRjlqYjNWdWRDd0tJQ0FnSUdScFp5QTJDaUFnSUNCbGVIUnlZV04wSURrMklEZ0tJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3pNamNLSUNBZ0lDOHZJR055WldGMFpXUmZZWFE5YzJOb1pXUjFiR1V1WTNKbFlYUmxaRjloZEN3S0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1pYaDBjbUZqZENBeE1UTWdPQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak14Tmkwek1qZ0tJQ0FnSUM4dklDTWdUV0Z5YXlCcGJtRmpkR2wyWlNCM2FYUm9JSHBsY204Z1pYTmpjbTkzQ2lBZ0lDQXZMeUJ6Wld4bUxuTmphR1ZrZFd4bGMxdHpZMmhsWkhWc1pWOXJaWGxkSUQwZ1UyTm9aV1IxYkdVb0NpQWdJQ0F2THlBZ0lDQWdjR0Y1WlhJOWMyTm9aV1IxYkdVdWNHRjVaWElzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmphWEJwWlc1MFBYTmphR1ZrZFd4bExuSmxZMmx3YVdWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljMk5vWldSMWJHVXVZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1Y0WldOMWRHVmZZWFE5YzJOb1pXUjFiR1V1WlhobFkzVjBaVjloZEN3S0lDQWdJQzh2SUNBZ0lDQnBiblJsY25aaGJGOXpaV052Ym1SelBYTmphR1ZrZFd4bExtbHVkR1Z5ZG1Gc1gzTmxZMjl1WkhNc0NpQWdJQ0F2THlBZ0lDQWdiMk5qZFhKeVpXNWpaWE05YzJOb1pXUjFiR1V1YjJOamRYSnlaVzVqWlhNc0NpQWdJQ0F2THlBZ0lDQWdaWGhsWTNWMFpXUmZZMjkxYm5ROWMyTm9aV1IxYkdVdVpYaGxZM1YwWldSZlkyOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lXTjBhWFpsUFdGeVl6UXVRbTl2YkNoR1lXeHpaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1pYTmpjbTkzWDJKaGJHRnVZMlU5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUmxaRjloZEQxelkyaGxaSFZzWlM1amNtVmhkR1ZrWDJGMExBb2dJQ0FnTHk4Z0tRb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TXpBdE16TXhDaUFnSUNBdkx5QWpJRkpsWm5WdVpDQnlaVzFoYVc1cGJtY2daWE5qY205M0NpQWdJQ0F2THlCcFppQnlaV1oxYm1SZllXMXZkVzUwSUQ0Z1ZVbHVkRFkwS0RBcE9nb2dJQ0FnWW5vZ1kyRnVZMlZzWDNOamFHVmtkV3hsWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak16TWkwek16WUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXlaV1oxYm1SZllXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak16TXdvZ0lDQWdMeThnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNek1nb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTXpOUW9nSUNBZ0x5OGdabVZsUFRBc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek16SXRNek0yQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5Y21WbWRXNWtYMkZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENncGpZVzVqWld4ZmMyTm9aV1IxYkdWZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNek9DMHpORE1LSUNBZ0lDOHZJR0Z5WXpRdVpXMXBkQ2dLSUNBZ0lDOHZJQ0FnSUNBaVUyTm9aV1IxYkdWRFlXNWpaV3hzWldRb1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBLU0lzQ2lBZ0lDQXZMeUFnSUNBZ2NHRjVaWEpmWVdSa2Npd0tJQ0FnSUM4dklDQWdJQ0J6WTJobFpIVnNaVjlwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h5WldaMWJtUmZZVzF2ZFc1MEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaE9UYzNZMk0zWlNBdkx5QnRaWFJvYjJRZ0lsTmphR1ZrZFd4bFEyRnVZMlZzYkdWa0tHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pJNU5pMHlPVGtLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlBaklHTmhibU5sYkY5elkyaGxaSFZzWlFvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3hOVEZtTjJNM05UZ3dDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11UTNKbGMyTmhRMkZzWlc1a1lYSlFZWGx0Wlc1MGN5NXBjMTlsZUdWamRYUmhZbXhsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FYTmZaWGhsWTNWMFlXSnNaVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3pORGN0TXpVd0NpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdJeUJTWldGa0xXOXViSGtnZG1sbGQzTUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TlRNS0lDQWdJQzh2SUhOamFHVmtkV3hsWDJ0bGVTQTlJRjl6WTJobFpIVnNaVjlyWlhrb2NHRjVaWEl1Ym1GMGFYWmxMbUo1ZEdWekxDQnpZMmhsWkhWc1pWOXBaQzV1WVhScGRtVXBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZOaklLSUNBZ0lDOHZJSEpsZEhWeWJpQndZWGxsY2lBcklHOXdMbWwwYjJJb2MyTm9aV1IxYkdWZmFXUXBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TlRRS0lDQWdJQzh2SUdsbUlITmphR1ZrZFd4bFgydGxlU0J1YjNRZ2FXNGdjMlZzWmk1elkyaGxaSFZzWlhNNkNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE56TTJNelk0TldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJwYzE5bGVHVmpkWFJoWW14bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNMU5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVRbTl2YkNoR1lXeHpaU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TUFvS2FYTmZaWGhsWTNWMFlXSnNaVjloWm5SbGNsOXBibXhwYm1Wa1gyTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1RGNtVnpZMkZEWVd4bGJtUmhjbEJoZVcxbGJuUnpMbWx6WDJWNFpXTjFkR0ZpYkdWQU9Eb0tJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3pORGN0TXpVd0NpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdJeUJTWldGa0xXOXViSGtnZG1sbGQzTUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BwYzE5bGVHVmpkWFJoWW14bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek5UWUtJQ0FnSUM4dklITmphR1ZrZFd4bElEMGdjMlZzWmk1elkyaGxaSFZzWlhOYmMyTm9aV1IxYkdWZmEyVjVYUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmlkWEo1SURVS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OamFHVmtkV3hsY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3pOVGNLSUNBZ0lDOHZJR2xtSUc1dmRDQnpZMmhsWkhWc1pTNWhZM1JwZG1VdWJtRjBhWFpsT2dvZ0lDQWdhVzUwWXlBMElDOHZJRGd6TWdvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbTU2SUdselgyVjRaV04xZEdGaWJHVmZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk16VTRDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVDYjI5c0tFWmhiSE5sS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd0NpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk16UTNMVE0xTUFvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklDTWdVbVZoWkMxdmJteDVJSFpwWlhkekNpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWWlCcGMxOWxlR1ZqZFhSaFlteGxYMkZtZEdWeVgybHViR2x1WldSZlkzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TGtOeVpYTmpZVU5oYkdWdVpHRnlVR0Y1YldWdWRITXVhWE5mWlhobFkzVjBZV0pzWlVBNENncHBjMTlsZUdWamRYUmhZbXhsWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TlRrS0lDQWdJQzh2SUdsbUlITmphR1ZrZFd4bExtVjRaV04xZEdWa1gyTnZkVzUwTG01aGRHbDJaU0ErUFNCelkyaGxaSFZzWlM1dlkyTjFjbkpsYm1ObGN5NXVZWFJwZG1VNkNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRGsyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpZFhKNUlEUUtJQ0FnSUhCMWMyaHBiblFnT0RnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0ErUFFvZ0lDQWdZbm9nYVhOZlpYaGxZM1YwWVdKc1pWOWhablJsY2w5cFpsOWxiSE5sUURjS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek5qQUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek5EY3RNelV3Q2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z0l5QlNaV0ZrTFc5dWJIa2dkbWxsZDNNS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpSUdselgyVjRaV04xZEdGaWJHVmZZV1owWlhKZmFXNXNhVzVsWkY5amNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11UTNKbGMyTmhRMkZzWlc1a1lYSlFZWGx0Wlc1MGN5NXBjMTlsZUdWamRYUmhZbXhsUURnS0NtbHpYMlY0WldOMWRHRmliR1ZmWVdaMFpYSmZhV1pmWld4elpVQTNPZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak0yTVFvZ0lDQWdMeThnYm1WNGRGOWxlR1ZqSUQwZ2MyTm9aV1IxYkdVdVpYaGxZM1YwWlY5aGRDNXVZWFJwZG1VZ0t5QW9DaUFnSUNCa2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURjeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTTJNZ29nSUNBZ0x5OGdjMk5vWldSMWJHVXVaWGhsWTNWMFpXUmZZMjkxYm5RdWJtRjBhWFpsSUNvZ2MyTm9aV1IxYkdVdWFXNTBaWEoyWVd4ZmMyVmpiMjVrY3k1dVlYUnBkbVVLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ09EQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNd29nSUNBZ0tnb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTTJNUzB6TmpNS0lDQWdJQzh2SUc1bGVIUmZaWGhsWXlBOUlITmphR1ZrZFd4bExtVjRaV04xZEdWZllYUXVibUYwYVhabElDc2dLQW9nSUNBZ0x5OGdJQ0FnSUhOamFHVmtkV3hsTG1WNFpXTjFkR1ZrWDJOdmRXNTBMbTVoZEdsMlpTQXFJSE5qYUdWa2RXeGxMbWx1ZEdWeWRtRnNYM05sWTI5dVpITXVibUYwYVhabENpQWdJQ0F2THlBcENpQWdJQ0FyQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TXpZMENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJRDQ5SUc1bGVIUmZaWGhsWXlrS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJRHc5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak0wTnkwek5UQUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUFqSUZKbFlXUXRiMjVzZVNCMmFXVjNjd29nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdhWE5mWlhobFkzVjBZV0pzWlY5aFpuUmxjbDlwYm14cGJtVmtYMk55WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NURjbVZ6WTJGRFlXeGxibVJoY2xCaGVXMWxiblJ6TG1selgyVjRaV04xZEdGaWJHVkFPQW9LQ2k4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1RGNtVnpZMkZEWVd4bGJtUmhjbEJoZVcxbGJuUnpMbWRsZEY5dVpYaDBYMlY0WldOMWRHbHZibDkwYVcxbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDI1bGVIUmZaWGhsWTNWMGFXOXVYM1JwYldVNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TXpZMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek56RUtJQ0FnSUM4dklITmphR1ZrZFd4bFgydGxlU0E5SUY5elkyaGxaSFZzWlY5clpYa29jR0Y1WlhJdWJtRjBhWFpsTG1KNWRHVnpMQ0J6WTJobFpIVnNaVjlwWkM1dVlYUnBkbVVwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TmpJS0lDQWdJQzh2SUhKbGRIVnliaUJ3WVhsbGNpQXJJRzl3TG1sMGIySW9jMk5vWldSMWJHVmZhV1FwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek56SUtJQ0FnSUM4dklHbG1JSE5qYUdWa2RXeGxYMnRsZVNCdWIzUWdhVzRnYzJWc1ppNXpZMmhsWkhWc1pYTTZDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROek0yTXpZNE5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCblpYUmZibVY0ZEY5bGVHVmpkWFJwYjI1ZmRHbHRaVjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3pOek1LSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLQ21kbGRGOXVaWGgwWDJWNFpXTjFkR2x2Ymw5MGFXMWxYMkZtZEdWeVgybHViR2x1WldSZlkzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TGtOeVpYTmpZVU5oYkdWdVpHRnlVR0Y1YldWdWRITXVaMlYwWDI1bGVIUmZaWGhsWTNWMGFXOXVYM1JwYldWQU56b0tJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3pOallLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWRsZEY5dVpYaDBYMlY0WldOMWRHbHZibDkwYVcxbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek56UUtJQ0FnSUM4dklITmphR1ZrZFd4bElEMGdjMlZzWmk1elkyaGxaSFZzWlhOYmMyTm9aV1IxYkdWZmEyVjVYUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmlkWEo1SURVS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OamFHVmtkV3hsY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3pOelVLSUNBZ0lDOHZJR2xtSUc1dmRDQnpZMmhsWkhWc1pTNWhZM1JwZG1VdWJtRjBhWFpsSUc5eUlITmphR1ZrZFd4bExtVjRaV04xZEdWa1gyTnZkVzUwTG01aGRHbDJaU0ErUFNCelkyaGxaSFZzWlM1dlkyTjFjbkpsYm1ObGN5NXVZWFJwZG1VNkNpQWdJQ0JwYm5SaklEUWdMeThnT0RNeUNpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZWlCblpYUmZibVY0ZEY5bGVHVmpkWFJwYjI1ZmRHbHRaVjlwWmw5aWIyUjVRRFVLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ09UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdjSFZ6YUdsdWRDQTRPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lENDlDaUFnSUNCaWVpQm5aWFJmYm1WNGRGOWxlR1ZqZFhScGIyNWZkR2x0WlY5aFpuUmxjbDlwWmw5bGJITmxRRFlLQ21kbGRGOXVaWGgwWDJWNFpXTjFkR2x2Ymw5MGFXMWxYMmxtWDJKdlpIbEFOVG9LSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TnpZS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek5qWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0lnWjJWMFgyNWxlSFJmWlhobFkzVjBhVzl1WDNScGJXVmZZV1owWlhKZmFXNXNhVzVsWkY5amNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11UTNKbGMyTmhRMkZzWlc1a1lYSlFZWGx0Wlc1MGN5NW5aWFJmYm1WNGRGOWxlR1ZqZFhScGIyNWZkR2x0WlVBM0NncG5aWFJmYm1WNGRGOWxlR1ZqZFhScGIyNWZkR2x0WlY5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TXpjNENpQWdJQ0F2THlCelkyaGxaSFZzWlM1bGVHVmpkWFJsWDJGMExtNWhkR2wyWlFvZ0lDQWdaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTNNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96TnprS0lDQWdJQzh2SUNzZ2MyTm9aV1IxYkdVdVpYaGxZM1YwWldSZlkyOTFiblF1Ym1GMGFYWmxJQ29nYzJOb1pXUjFiR1V1YVc1MFpYSjJZV3hmYzJWamIyNWtjeTV1WVhScGRtVUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnT0RBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ013b2dJQ0FnS2dvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pNM09DMHpOemtLSUNBZ0lDOHZJSE5qYUdWa2RXeGxMbVY0WldOMWRHVmZZWFF1Ym1GMGFYWmxDaUFnSUNBdkx5QXJJSE5qYUdWa2RXeGxMbVY0WldOMWRHVmtYMk52ZFc1MExtNWhkR2wyWlNBcUlITmphR1ZrZFd4bExtbHVkR1Z5ZG1Gc1gzTmxZMjl1WkhNdWJtRjBhWFpsQ2lBZ0lDQXJDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNemMzTFRNNE1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWVWx1ZERZMEtBb2dJQ0FnTHk4Z0lDQWdJSE5qYUdWa2RXeGxMbVY0WldOMWRHVmZZWFF1Ym1GMGFYWmxDaUFnSUNBdkx5QWdJQ0FnS3lCelkyaGxaSFZzWlM1bGVHVmpkWFJsWkY5amIzVnVkQzV1WVhScGRtVWdLaUJ6WTJobFpIVnNaUzVwYm5SbGNuWmhiRjl6WldOdmJtUnpMbTVoZEdsMlpRb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTTJOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWWlCblpYUmZibVY0ZEY5bGVHVmpkWFJwYjI1ZmRHbHRaVjloWm5SbGNsOXBibXhwYm1Wa1gyTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1RGNtVnpZMkZEWVd4bGJtUmhjbEJoZVcxbGJuUnpMbWRsZEY5dVpYaDBYMlY0WldOMWRHbHZibDkwYVcxbFFEY0tDZ292THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11UTNKbGMyTmhRMkZzWlc1a1lYSlFZWGx0Wlc1MGN5NW5aWFJmZEc5MFlXeGZjMk5vWldSMWJHVnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzUnZkR0ZzWDNOamFHVmtkV3hsY3pvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek9EUUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmRHRnNYM05qYUdWa2RXeGxjeTUyWVd4MVpTa0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGIzUmhiRjl6WTJobFpIVnNaWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYzJOb1pXUjFiR1Z6SUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPak00TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1RGNtVnpZMkZEWVd4bGJtUmhjbEJoZVcxbGJuUnpMbWRsZEY5MGIzUmhiRjlsZUdWamRYUmxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOTBiM1JoYkY5bGVHVmpkWFJsWkRvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek9EZ0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmRHRnNYMlY0WldOMWRHVmtMblpoYkhWbEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5SdmRHRnNYMlY0WldOMWRHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMlY0WldOMWRHVmtJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTTROZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTVEY21WelkyRkRZV3hsYm1SaGNsQmhlVzFsYm5SekxtZGxkRjkxYzJWeVgzTmphR1ZrZFd4bFgyTnZkVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYM1Z6WlhKZmMyTm9aV1IxYkdWZlkyOTFiblE2Q2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TXprd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96T1RJS0lDQWdJQzh2SUdsbUlIVnpaWElnYVc0Z2MyVnNaaTV6WTJobFpIVnNaVjlqYjNWdWRITTZDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjROak0yWlRjME5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdkbGRGOTFjMlZ5WDNOamFHVmtkV3hsWDJOdmRXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qTTVNd29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1YzJOb1pXUjFiR1ZmWTI5MWJuUnpXM1Z6WlhKZENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTmphR1ZrZFd4bFgyTnZkVzUwY3lCbGJuUnllU0JsZUdsemRITUtDbWRsZEY5MWMyVnlYM05qYUdWa2RXeGxYMk52ZFc1MFgyRm1kR1Z5WDJsdWJHbHVaV1JmWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMa055WlhOallVTmhiR1Z1WkdGeVVHRjViV1Z1ZEhNdVoyVjBYM1Z6WlhKZmMyTm9aV1IxYkdWZlkyOTFiblJBTkRvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek9UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGxkRjkxYzJWeVgzTmphR1ZrZFd4bFgyTnZkVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96T1RRS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvek9UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0lnWjJWMFgzVnpaWEpmYzJOb1pXUjFiR1ZmWTI5MWJuUmZZV1owWlhKZmFXNXNhVzVsWkY5amNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11UTNKbGMyTmhRMkZzWlc1a1lYSlFZWGx0Wlc1MGN5NW5aWFJmZFhObGNsOXpZMmhsWkhWc1pWOWpiM1Z1ZEVBMENnb0tMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMa055WlhOallVTmhiR1Z1WkdGeVVHRjViV1Z1ZEhNdVpuVnVaRjlqYjI1MGNtRmpkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21aMWJtUmZZMjl1ZEhKaFkzUTZDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNemsyTFRNNU9Rb2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJQ01nWm5WdVpGOWpiMjUwY21GamRBb2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qUXdOZ29nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzFsYm5SZmRIaHVMbkpsWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zSUNKTmRYTjBJSE5sYm1RZ2RHOGdZMjl1ZEhKaFkzUWlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCTmRYTjBJSE5sYm1RZ2RHOGdZMjl1ZEhKaFkzUUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUbzBNRGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MFgzUjRiaTVoYlc5MWJuUWdQaUJWU1c1ME5qUW9NQ2tzSUNKQmJXOTFiblFnYlhWemRDQmlaU0ErSURBaUNpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYlc5MWJuUWdiWFZ6ZENCaVpTQStJREFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG96T1RZdE16azVDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnSXlCbWRXNWtYMk52Ym5SeVlXTjBDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURFMU1XWTNZemMxT0RBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NURjbVZ6WTJGRFlXeGxibVJoY2xCaGVXMWxiblJ6TG1OeVpXRjBaVjl6WTJobFpIVnNaU2h3WVhsdFpXNTBYM1I0YmpvZ2RXbHVkRFkwTENCeVpXTnBjR2xsYm5RNklHSjVkR1Z6TENCaGJXOTFiblE2SUdKNWRHVnpMQ0JsZUdWamRYUmxYMkYwT2lCaWVYUmxjeXdnYVc1MFpYSjJZV3hmYzJWamIyNWtjem9nWW5sMFpYTXNJRzlqWTNWeWNtVnVZMlZ6T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21OeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTVEY21WelkyRkRZV3hsYm1SaGNsQmhlVzFsYm5SekxtTnlaV0YwWlY5elkyaGxaSFZzWlRvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRvNU15MHhNRFVLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlBaklHTnlaV0YwWlY5elkyaGxaSFZzWlFvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJqY21WaGRHVmZjMk5vWldSMWJHVW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd0tJQ0FnSUM4dklDQWdJQ0J3WVhsdFpXNTBYM1I0YmpvZ1ozUjRiaTVRWVhsdFpXNTBWSEpoYm5OaFkzUnBiMjRzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmphWEJwWlc1ME9pQmhjbU0wTGtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCaGNtTTBMbFZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JsZUdWamRYUmxYMkYwT2lCaGNtTTBMbFZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JwYm5SbGNuWmhiRjl6WldOdmJtUnpPaUJoY21NMExsVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQnZZMk4xY25KbGJtTmxjem9nWVhKak5DNVZTVzUwTmpRc0NpQWdJQ0F2THlBcElDMCtJR0Z5WXpRdVZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z05pQXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveE1UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGJXOTFiblF1Ym1GMGFYWmxJRDRnVlVsdWREWTBLREFwTENBaVFXMXZkVzUwSUcxMWMzUWdZbVVnUGlBd0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYlc5MWJuUWdiWFZ6ZENCaVpTQStJREFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG94TVRZS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdWamRYUmxYMkYwTG01aGRHbDJaU0ErSUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdMQ0FpWlhobFkzVjBaVjloZENCdGRYTjBJR0psSUdsdUlHWjFkSFZ5WlNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZblJ2YVFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklHVjRaV04xZEdWZllYUWdiWFZ6ZENCaVpTQnBiaUJtZFhSMWNtVUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3hNVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnZZMk4xY25KbGJtTmxjeTV1WVhScGRtVWdQaUJWU1c1ME5qUW9NQ2tzSUNKdlkyTjFjbkpsYm1ObGN5QnRkWE4wSUdKbElENGdNQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFnTHk4Z2IyTmpkWEp5Wlc1alpYTWdiWFZ6ZENCaVpTQStJREFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG94TVRnS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBYM1I0Ymk1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWlVR0Y1YldWdWRDQnRkWE4wSUhSaGNtZGxkQ0JqYjI1MGNtRmpkQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXROZ29nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGQmhlVzFsYm5RZ2JYVnpkQ0IwWVhKblpYUWdZMjl1ZEhKaFkzUUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3hNakFLSUNBZ0lDOHZJSFJ2ZEdGc1gzSmxjWFZwY21Wa09pQlZTVzUwTmpRZ1BTQmhiVzkxYm5RdWJtRjBhWFpsSUNvZ2IyTmpkWEp5Wlc1alpYTXVibUYwYVhabENpQWdJQ0FxQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG94TWpFS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBYM1I0Ymk1aGJXOTFiblFnUGowZ2RHOTBZV3hmY21WeGRXbHlaV1FzSUNKSmJuTjFabVpwWTJsbGJuUWdaWE5qY205M0lHWjFibVJ6SWdvZ0lDQWdabkpoYldWZlpHbG5JQzAyQ2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCbGMyTnliM2NnWm5WdVpITUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3hNak10TVRJMENpQWdJQ0F2THlBaklFUmxkR1Z5YldsdVpTQnpZMmhsWkhWc1pWOXBaQW9nSUNBZ0x5OGdjR0Y1WlhKZllXUmtjaUE5SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qRXlOUW9nSUNBZ0x5OGdhV1lnY0dGNVpYSmZZV1JrY2lCcGJpQnpaV3htTG5OamFHVmtkV3hsWDJOdmRXNTBjem9LSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGcyTXpabE56UTFaZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakV5TXkweE1qUUtJQ0FnSUM4dklDTWdSR1YwWlhKdGFXNWxJSE5qYUdWa2RXeGxYMmxrQ2lBZ0lDQXZMeUJ3WVhsbGNsOWhaR1J5SUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdWNIazZNVEkxQ2lBZ0lDQXZMeUJwWmlCd1lYbGxjbDloWkdSeUlHbHVJSE5sYkdZdWMyTm9aV1IxYkdWZlkyOTFiblJ6T2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxrTnlaWE5qWVVOaGJHVnVaR0Z5VUdGNWJXVnVkSE11WTNKbFlYUmxYM05qYUdWa2RXeGxYMlZzYzJWZlltOWtlVUF5Q2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TVRJMkNpQWdJQ0F2THlCelkyaGxaSFZzWlY5cFpDQTlJSE5sYkdZdWMyTm9aV1IxYkdWZlkyOTFiblJ6VzNCaGVXVnlYMkZrWkhKZExtNWhkR2wyWlFvZ0lDQWdabkpoYldWZlpHbG5JRFlLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OamFHVmtkV3hsWDJOdmRXNTBjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJR0owYjJrS0NtTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1RGNtVnpZMkZEWVd4bGJtUmhjbEJoZVcxbGJuUnpMbU55WldGMFpWOXpZMmhsWkhWc1pWOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1UTXdMVEV6TVFvZ0lDQWdMeThnSXlCVGRHOXlaU0J6WTJobFpIVnNaU0JwYmlCaElFSnZlQW9nSUNBZ0x5OGdjMk5vWldSMWJHVmZhMlY1SUQwZ1gzTmphR1ZrZFd4bFgydGxlU2hVZUc0dWMyVnVaR1Z5TG1KNWRHVnpMQ0J6WTJobFpIVnNaVjlwWkNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG8yTWdvZ0lDQWdMeThnY21WMGRYSnVJSEJoZVdWeUlDc2diM0F1YVhSdllpaHpZMmhsWkhWc1pWOXBaQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVjSGs2TVRRd0NpQWdJQ0F2THlCaFkzUnBkbVU5WVhKak5DNUNiMjlzS0ZSeWRXVXBMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakUwTVFvZ0lDQWdMeThnWlhOamNtOTNYMkpoYkdGdVkyVTlZWEpqTkM1VlNXNTBOalFvZEc5MFlXeGZjbVZ4ZFdseVpXUXBMQW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakUwTWdvZ0lDQWdMeThnWTNKbFlYUmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1UTXlMVEUwTXdvZ0lDQWdMeThnYzJWc1ppNXpZMmhsWkhWc1pYTmJjMk5vWldSMWJHVmZhMlY1WFNBOUlGTmphR1ZrZFd4bEtBb2dJQ0FnTHk4Z0lDQWdJSEJoZVdWeVBYQmhlV1Z5WDJGa1pISXNDaUFnSUNBdkx5QWdJQ0FnY21WamFYQnBaVzUwUFhKbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHVjRaV04xZEdWZllYUTlaWGhsWTNWMFpWOWhkQ3dLSUNBZ0lDOHZJQ0FnSUNCcGJuUmxjblpoYkY5elpXTnZibVJ6UFdsdWRHVnlkbUZzWDNObFkyOXVaSE1zQ2lBZ0lDQXZMeUFnSUNBZ2IyTmpkWEp5Wlc1alpYTTliMk5qZFhKeVpXNWpaWE1zQ2lBZ0lDQXZMeUFnSUNBZ1pYaGxZM1YwWldSZlkyOTFiblE5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWVdOMGFYWmxQV0Z5WXpRdVFtOXZiQ2hVY25WbEtTd0tJQ0FnSUM4dklDQWdJQ0JsYzJOeWIzZGZZbUZzWVc1alpUMWhjbU0wTGxWSmJuUTJOQ2gwYjNSaGJGOXlaWEYxYVhKbFpDa3NDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0F2THlBcENpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd09EQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakV6TWdvZ0lDQWdMeThnYzJWc1ppNXpZMmhsWkhWc1pYTmJjMk5vWldSMWJHVmZhMlY1WFNBOUlGTmphR1ZrZFd4bEtBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEY3pOak0yT0RWbUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pFek1pMHhORE1LSUNBZ0lDOHZJSE5sYkdZdWMyTm9aV1IxYkdWelczTmphR1ZrZFd4bFgydGxlVjBnUFNCVFkyaGxaSFZzWlNnS0lDQWdJQzh2SUNBZ0lDQndZWGxsY2oxd1lYbGxjbDloWkdSeUxBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJsd2FXVnVkRDF5WldOcGNHbGxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbGVHVmpkWFJsWDJGMFBXVjRaV04xZEdWZllYUXNDaUFnSUNBdkx5QWdJQ0FnYVc1MFpYSjJZV3hmYzJWamIyNWtjejFwYm5SbGNuWmhiRjl6WldOdmJtUnpMQW9nSUNBZ0x5OGdJQ0FnSUc5alkzVnljbVZ1WTJWelBXOWpZM1Z5Y21WdVkyVnpMQW9nSUNBZ0x5OGdJQ0FnSUdWNFpXTjFkR1ZrWDJOdmRXNTBQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR0ZqZEdsMlpUMWhjbU0wTGtKdmIyd29WSEoxWlNrc0NpQWdJQ0F2THlBZ0lDQWdaWE5qY205M1gySmhiR0Z1WTJVOVlYSmpOQzVWU1c1ME5qUW9kRzkwWVd4ZmNtVnhkV2x5WldRcExBb2dJQ0FnTHk4Z0lDQWdJR055WldGMFpXUmZZWFE5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdMeThnS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qRTBOUzB4TkRZS0lDQWdJQzh2SUNNZ1NXNWpjbVZ0Wlc1MElIVnpaWEluY3lCelkyaGxaSFZzWlNCamIzVnVkR1Z5Q2lBZ0lDQXZMeUJ6Wld4bUxuTmphR1ZrZFd4bFgyTnZkVzUwYzF0d1lYbGxjbDloWkdSeVhTQTlJR0Z5WXpRdVZVbHVkRFkwS0hOamFHVmtkV3hsWDJsa0lDc2dWVWx1ZERZMEtERXBLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUEyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1UUTRDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM05qYUdWa2RXeGxjeTUyWVd4MVpTQTlJSE5sYkdZdWRHOTBZV3hmYzJOb1pXUjFiR1Z6TG5aaGJIVmxJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzkwWVd4ZmMyTm9aV1IxYkdWeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzTmphR1ZrZFd4bGN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiM1JoYkY5elkyaGxaSFZzWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qRTFNQzB4TlRFS0lDQWdJQzh2SUNNZ1VtVm1kVzVrSUdGdWVTQmxlR05sYzNNS0lDQWdJQzh2SUdWNFkyVnpjeUE5SUhCaGVXMWxiblJmZEhodUxtRnRiM1Z1ZENBdElIUnZkR0ZzWDNKbGNYVnBjbVZrQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ2MzZGhjQW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveE5USUtJQ0FnSUM4dklHbG1JR1Y0WTJWemN5QStJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHSjZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NURjbVZ6WTJGRFlXeGxibVJoY2xCaGVXMWxiblJ6TG1OeVpXRjBaVjl6WTJobFpIVnNaVjloWm5SbGNsOXBabDlsYkhObFFEWUtJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3hOVE10TVRVM0NpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVpYaGpaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakUxTkFvZ0lDQWdMeThnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxuQjVPakUxTXdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnWTNKbGMyTmhYMk5oYkdWdVpHRnlYM0JoZVcxbGJuUnpMbkI1T2pFMU5nb2dJQ0FnTHk4Z1ptVmxQVEFzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJR055WlhOallWOWpZV3hsYm1SaGNsOXdZWGx0Wlc1MGN5NXdlVG94TlRNdE1UVTNDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlaWGhqWlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0NtTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1RGNtVnpZMkZEWVd4bGJtUmhjbEJoZVcxbGJuUnpMbU55WldGMFpWOXpZMmhsWkhWc1pWOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1UVTVMVEUyTWdvZ0lDQWdMeThnSXlCT1QxUkZPaUJ0ZFhOMElHMWhkR1Z5YVdGc2FYTmxJSFJvWlNCaWIyOXNJR2x1ZEc4Z1lTQnNiMk5oYkNCbWFYSnpkRHNnY0dGemMybHVaeUIwYUdVS0lDQWdJQzh2SUNNZ1kyOXRjR0Z5YVhOdmJpQnBibXhwYm1VZ1lYTWdZR0Z5WXpRdVFtOXZiQ2hsZUhCeUtXQWdkSEpwWjJkbGNuTWdZU0JRZFhsaFVIa2dZMjlrWldkbGJnb2dJQ0FnTHk4Z0l5QmlkV2NnZDJobGNtVWdkR2hsSUhKaGR5QnBiblJsWjJWeUlHbHpJR1psWkNCcGJuUnZJR0J6WlhSaWFYUmdJQ2gyWVd4MVpTQStJREVnWlhKeWIzSXBMZ29nSUNBZ0x5OGdhWE5mY21WamRYSnlhVzVuSUQwZ1lYSmpOQzVDYjI5c0tGUnlkV1VwSUdsbUlHbHVkR1Z5ZG1Gc1gzTmxZMjl1WkhNdWJtRjBhWFpsSUQ0Z1ZVbHVkRFkwS0RBcElHVnNjMlVnWVhKak5DNUNiMjlzS0VaaGJITmxLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaWRHOXBDaUFnSUNCaWVpQmpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdVEzSmxjMk5oUTJGc1pXNWtZWEpRWVhsdFpXNTBjeTVqY21WaGRHVmZjMk5vWldSMWJHVmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNENpQWdJQ0JtY21GdFpWOWthV2NnTUFvS1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TGtOeVpYTmpZVU5oYkdWdVpHRnlVR0Y1YldWdWRITXVZM0psWVhSbFgzTmphR1ZrZFd4bFgzUmxjbTVoY25sZmJXVnlaMlZBT1RvS0lDQWdJQzh2SUdOeVpYTmpZVjlqWVd4bGJtUmhjbDl3WVhsdFpXNTBjeTV3ZVRveE5qTXRNVGN4Q2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvQ2lBZ0lDQXZMeUFnSUNBZ0lsTmphR1ZrZFd4bFEzSmxZWFJsWkNoaFpHUnlaWE56TEhWcGJuUTJOQ3hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiQ2tpTEFvZ0lDQWdMeThnSUNBZ0lIQmhlV1Z5WDJGa1pISXNDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyTm9aV1IxYkdWZmFXUXBMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdaWGhsWTNWMFpWOWhkQ3dLSUNBZ0lDOHZJQ0FnSUNCcGMxOXlaV04xY25KcGJtY3NDaUFnSUNBdkx5QXBDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRZVEJoTWpVNE9USWdMeThnYldWMGFHOWtJQ0pUWTJobFpIVnNaVU55WldGMFpXUW9ZV1JrY21WemN5eDFhVzUwTmpRc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3cElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklHTnlaWE5qWVY5allXeGxibVJoY2w5d1lYbHRaVzUwY3k1d2VUb3hOek1LSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2h6WTJobFpIVnNaVjlwWkNrS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncGpjbVZ6WTJGZlkyRnNaVzVrWVhKZmNHRjViV1Z1ZEhNdVEzSmxjMk5oUTJGc1pXNWtZWEpRWVhsdFpXNTBjeTVqY21WaGRHVmZjMk5vWldSMWJHVmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNE9nb2dJQ0FnTHk4Z1kzSmxjMk5oWDJOaGJHVnVaR0Z5WDNCaGVXMWxiblJ6TG5CNU9qRTFPUzB4TmpJS0lDQWdJQzh2SUNNZ1RrOVVSVG9nYlhWemRDQnRZWFJsY21saGJHbHpaU0IwYUdVZ1ltOXZiQ0JwYm5SdklHRWdiRzlqWVd3Z1ptbHljM1E3SUhCaGMzTnBibWNnZEdobENpQWdJQ0F2THlBaklHTnZiWEJoY21semIyNGdhVzVzYVc1bElHRnpJR0JoY21NMExrSnZiMndvWlhod2NpbGdJSFJ5YVdkblpYSnpJR0VnVUhWNVlWQjVJR052WkdWblpXNEtJQ0FnSUM4dklDTWdZblZuSUhkb1pYSmxJSFJvWlNCeVlYY2dhVzUwWldkbGNpQnBjeUJtWldRZ2FXNTBieUJnYzJWMFltbDBZQ0FvZG1Gc2RXVWdQaUF4SUdWeWNtOXlLUzRLSUNBZ0lDOHZJR2x6WDNKbFkzVnljbWx1WnlBOUlHRnlZelF1UW05dmJDaFVjblZsS1NCcFppQnBiblJsY25aaGJGOXpaV052Ym1SekxtNWhkR2wyWlNBK0lGVkpiblEyTkNnd0tTQmxiSE5sSUdGeVl6UXVRbTl2YkNoR1lXeHpaU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TUFvZ0lDQWdZaUJqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVRM0psYzJOaFEyRnNaVzVrWVhKUVlYbHRaVzUwY3k1amNtVmhkR1ZmYzJOb1pXUjFiR1ZmZEdWeWJtRnllVjl0WlhKblpVQTVDZ3BqY21WelkyRmZZMkZzWlc1a1lYSmZjR0Y1YldWdWRITXVRM0psYzJOaFEyRnNaVzVrWVhKUVlYbHRaVzUwY3k1amNtVmhkR1ZmYzJOb1pXUjFiR1ZmWld4elpWOWliMlI1UURJNkNpQWdJQ0F2THlCamNtVnpZMkZmWTJGc1pXNWtZWEpmY0dGNWJXVnVkSE11Y0hrNk1USTRDaUFnSUNBdkx5QnpZMmhsWkhWc1pWOXBaQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdZM0psYzJOaFgyTmhiR1Z1WkdGeVgzQmhlVzFsYm5SekxrTnlaWE5qWVVOaGJHVnVaR0Z5VUdGNWJXVnVkSE11WTNKbFlYUmxYM05qYUdWa2RXeGxYMkZtZEdWeVgybG1YMlZzYzJWQU13bz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQVFBSUlNQUdKZ2dCQUFRVkgzeDFCSE5qYUY4UGRHOTBZV3hmYzJOb1pXUjFiR1Z6RG5SdmRHRnNYMlY0WldOMWRHVmtDQUFBQUFBQUFBQUFCUlVmZkhXQUJHTnVkRjh4R0VBQUJ5c2paeWNFSTJjeEcwRUFYREVaRkVReEdFU0NDd1JpZUpDTUJLam96M0FFU3BWb2ZnU1hhNXZTQk5NU3RXVUVsSEZSUUFTUkk4MnlCSVpsVE9nRTAvZjVGd1NYU2lJMEJCVmtkYWcyR2dDT0N3QUpBRVFBZXdER0Fjc0Nnd0x6QTFvRFpRTnhBNUlBTVJrVU1SZ1VFRU14RmlJSlNUZ1FJaEpFTmhvQlNSVWxFa1EyR2dKSkZTUVNSRFlhQTBrVkpCSkVOaG9FU1JVa0VrUTJHZ1ZKRlNRU1JJZ0RiU2xNVUxBaVF6RVdJZ2xKT0JBaUVrUTJHZ0ZKRlNVU1JEWWFBa2tWSkJKRU5ob0RTUlVrRWtRbkJZQUlBQUFBQUFBQUFBR0lBellwVEZDd0lrTXhGaUlKU1RnUUloSkVOaG9CU1JVbEVrUTJHZ0pKRlNRU1JEWWFBMGtWSkJKRU5ob0VTUlVrRWtRMkdnVkpGU1FTUkV3WGdZQ2pCUXNXVGdWT0JVOEVUd1dJQXVzcFRGQ3dJa00yR2dGSkZTVVNSRFlhQWtrVkpCSkVTUmNXVHdKTVVDcE1VRW05UlFGRVNiNUlTU0VFVXlnalR3SlVJMU5FU1lGZ1cwc0JWMWdJU3dLQldGdExBa3NCREVSTEExZElDRXNFZ1VoYlN3VlhVQWhMQm9GUVcwc0dDMDhDQ0RJSERrUkxCWUZwVzBzR1YwQUlTd2VCUUZ0TEFrc0JEMFJQQWtzQkNVOEhJZ2hKVHdjUFN3aFhBQ0JMQ1ZjZ0lFOERGa3NERkNnalR3SlVUd1VXVHd0WGNRaExCVXNGVUVzSlVFOExVRThLVUU4S1VFc0VVRThEVUU4Q1VFeFFUd2RNdjdGUEJMSUlTd0d5QnlLeUVDT3lBYk5QQWs4RlVFbE9CVThDVUU4RFVFeFFnQVM4djJDL1RGQ3dRUUFWSXljRVpVUWlDQ2NFVEdlQUJHWnhLZ2RMQVZDd0p3YXdJa00yR2dGSEFoVWtFa1F4QUVsUEFqRUFUQmNXVUNwTVVFbTlSUUZFU2I1SVNWY0FJRWxQQkJKRVN3RWhCRk1vSTA4Q1ZDTlRSRXNCVjJrSVRnTkxBWUZwVzBsT0EwNEVTd0ZYSUNCTEFsZEFDRXNEVjBnSVN3UlhVQWhMQlZkWUNFc0dWMkFJVHdkWGNRaFBCMDhIVUU4R1VFOEZVRThFVUU4RFVFOENVSUFKQUFBQUFBQUFBQUFBVUV4UVR3Sk12MEVBRUxFeEFFc0JzZ2l5QnlLeUVDT3lBYk5MQWtzRVVFc0NVSUFFcVhmTWZreFFzQ2NHc0NKREk0QUFOaG9CU1JVbEVrUTJHZ0pKRlNRU1JCY1dVQ3BNVUVtOVJRRkFBQWNvS1V4UXNDSkRTYjVNU1U0Q1JRVkVJUVJUS0NOUEFsUWpVMEFBQkNoQy8rQkxBa21CWUZ0SlRnSkZCSUZZV3c5QkFBUW9Rdi9LU3dKSmdVaGJUSUZRVzBzREN3Z3lCdzRvSTA4Q1ZFTC9zU09BQURZYUFVa1ZKUkpFTmhvQ1NSVWtFa1FYRmxBcVRGQkp2VVVCUUFBSUp3VXBURkN3SWtOSnZreEpUZ0pGQlVRaEJGTW9JMDhDVkNOVFFRQVNTd0pKZ1dCYlNVNENSUVNCV0ZzUFFRQUZKd1ZDLzgxTEFrbUJTRnRNZ1ZCYlN3TUxDQlpDLzdzaksyVkVGaWxNVUxBaVF5TW5CR1ZFRmlsTVVMQWlRellhQVVrVkpSSkVKd2RNVUVtOVJRRkJBQWxKdmtRcFRGQ3dJa01uQlVMLzlURVdJZ2xKT0JBaUVrUkpPQWN5Q2hKRU9BaEVKd2F3SWtPS0JnRWpTWUFBaS93WFNVU0wvUmN5QncxRWkvOFhTVVNMK2pnSE1nb1NSQXRKaS9vNENFbFBBZzlFTVFBbkJ6RUFVRW05UlFGQkFKcUxCcjVFRnpFQVN3RVdTWXdCVUlBQmdJd0Fpd05KVGdNV01nY1dpd1dMKzFDTC9GQ0wvVkNML2xDTC8xQ0FDUUFBQUFBQUFBQUFnRkJQQWxCTVVDcFBBbEJNdnlJSUZvc0dUTDhqSzJWRUlnZ3JUR2VMQkV3SlNZd0NRUUFRc1RFQWl3S3lDTElISXJJUUk3SUJzNHYrRjBFQUlvc0Fpd1dMQVVsT0FsQ0wrMUNML0ZDTC9WQlBBbENBQktDaVdKSk1VTENNQUlrb1F2L2NJMEwvWnc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IlNjaGVkdWxlQ3JlYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDYiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlBheW1lbnRFeGVjdXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU2NoZWR1bGVDb21wbGV0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiU2NoZWR1bGVDYW5jZWxsZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
