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

namespace Arc56.Generated.NautilusOSS.AlgoVoi.SpendingCapVault_0325c2ba
{


    //
    // Multi-agent spending cap vault. Same bytecode on Algorand and Voi.
    //
    public class SpendingCapVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SpendingCapVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AgentConfig : AVMObjectType
            {
                public ulong Enabled { get; set; }

                public ulong MaxPerTxn { get; set; }

                public ulong DailyCap { get; set; }

                public ulong DayBucket { get; set; }

                public ulong DaySpent { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEnabled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEnabled.From(Enabled);
                    ret.AddRange(vEnabled.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxPerTxn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxPerTxn.From(MaxPerTxn);
                    ret.AddRange(vMaxPerTxn.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDailyCap = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDailyCap.From(DailyCap);
                    ret.AddRange(vDailyCap.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDayBucket = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDayBucket.From(DayBucket);
                    ret.AddRange(vDayBucket.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDaySpent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDaySpent.From(DaySpent);
                    ret.AddRange(vDaySpent.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AgentConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AgentConfig();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEnabled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEnabled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEnabled = vEnabled.ToValue();
                    if (valueEnabled is ulong vEnabledValue) { ret.Enabled = vEnabledValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxPerTxn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxPerTxn.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxPerTxn = vMaxPerTxn.ToValue();
                    if (valueMaxPerTxn is ulong vMaxPerTxnValue) { ret.MaxPerTxn = vMaxPerTxnValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDailyCap = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDailyCap.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDailyCap = vDailyCap.ToValue();
                    if (valueDailyCap is ulong vDailyCapValue) { ret.DailyCap = vDailyCapValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDayBucket = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDayBucket.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDayBucket = vDayBucket.ToValue();
                    if (valueDayBucket is ulong vDayBucketValue) { ret.DayBucket = vDayBucketValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDaySpent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDaySpent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDaySpent = vDaySpent.ToValue();
                    if (valueDaySpent is ulong vDaySpentValue) { ret.DaySpent = vDaySpentValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AgentConfig);
                }
                public bool Equals(AgentConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AgentConfig left, AgentConfig right)
                {
                    return EqualityComparer<AgentConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(AgentConfig left, AgentConfig right)
                {
                    return !(left == right);
                }

            }

            public class RecipientConfig : AVMObjectType
            {
                public ulong MaxPerTxn { get; set; }

                public ulong DailyCap { get; set; }

                public ulong DayBucket { get; set; }

                public ulong DaySpent { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxPerTxn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxPerTxn.From(MaxPerTxn);
                    ret.AddRange(vMaxPerTxn.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDailyCap = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDailyCap.From(DailyCap);
                    ret.AddRange(vDailyCap.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDayBucket = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDayBucket.From(DayBucket);
                    ret.AddRange(vDayBucket.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDaySpent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDaySpent.From(DaySpent);
                    ret.AddRange(vDaySpent.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static RecipientConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RecipientConfig();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxPerTxn = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxPerTxn.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxPerTxn = vMaxPerTxn.ToValue();
                    if (valueMaxPerTxn is ulong vMaxPerTxnValue) { ret.MaxPerTxn = vMaxPerTxnValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDailyCap = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDailyCap.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDailyCap = vDailyCap.ToValue();
                    if (valueDailyCap is ulong vDailyCapValue) { ret.DailyCap = vDailyCapValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDayBucket = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDayBucket.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDayBucket = vDayBucket.ToValue();
                    if (valueDayBucket is ulong vDayBucketValue) { ret.DayBucket = vDayBucketValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDaySpent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDaySpent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDaySpent = vDaySpent.ToValue();
                    if (valueDaySpent is ulong vDaySpentValue) { ret.DaySpent = vDaySpentValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as RecipientConfig);
                }
                public bool Equals(RecipientConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RecipientConfig left, RecipientConfig right)
                {
                    return EqualityComparer<RecipientConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(RecipientConfig left, RecipientConfig right)
                {
                    return !(left == right);
                }

            }

            public class GetGlobalStateReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public ulong Field5 { get; set; }

                public ulong Field6 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetGlobalStateReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetGlobalStateReturn();
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

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetGlobalStateReturn);
                }
                public bool Equals(GetGlobalStateReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetGlobalStateReturn left, GetGlobalStateReturn right)
                {
                    return EqualityComparer<GetGlobalStateReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetGlobalStateReturn left, GetGlobalStateReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Deploy the vault. No agents are added yet — use add_agent() after deployment.
        ///</summary>
        /// <param name="global_max_per_txn">Default max native coin per payment (micro-units) </param>
        /// <param name="global_daily_cap">Default max native coin per UTC day (micro-units) </param>
        /// <param name="global_max_asa_per_txn">Default max ASA base units per pay_asa() </param>
        /// <param name="allowlist_enabled">1 = only registered recipients allowed, 0 = open </param>
        public async Task Create(ulong global_max_per_txn, ulong global_daily_cap, ulong global_max_asa_per_txn, ulong allowlist_enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 245, 116, 233 };
            var global_max_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); global_max_per_txnAbi.From(global_max_per_txn);
            var global_daily_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); global_daily_capAbi.From(global_daily_cap);
            var global_max_asa_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); global_max_asa_per_txnAbi.From(global_max_asa_per_txn);
            var allowlist_enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); allowlist_enabledAbi.From(allowlist_enabled);

            var result = await base.CallApp(new List<object> { abiHandle, global_max_per_txnAbi, global_daily_capAbi, global_max_asa_per_txnAbi, allowlist_enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong global_max_per_txn, ulong global_daily_cap, ulong global_max_asa_per_txn, ulong allowlist_enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 245, 116, 233 };
            var global_max_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); global_max_per_txnAbi.From(global_max_per_txn);
            var global_daily_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); global_daily_capAbi.From(global_daily_cap);
            var global_max_asa_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); global_max_asa_per_txnAbi.From(global_max_asa_per_txn);
            var allowlist_enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); allowlist_enabledAbi.From(allowlist_enabled);

            return await base.MakeTransactionList(new List<object> { abiHandle, global_max_per_txnAbi, global_daily_capAbi, global_max_asa_per_txnAbi, allowlist_enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Pay ALGO/VOI to receiver. Any registered, enabled agent may call this.
        ///Enforces (in order):   1. Agent must be registered and enabled   2. Amount ≤ agent's effective max_per_txn   3. Agent's effective daily_cap not exceeded   4. If allowlist_enabled=1: receiver must have a RecipientConfig entry   5. Amount ≤ recipient's effective max_per_txn (if config exists)   6. Recipient's effective daily_cap not exceeded (if config exists)
        ///</summary>
        /// <param name="receiver"> </param>
        /// <param name="amount"> </param>
        /// <param name="note"> </param>
        public async Task Pay(Algorand.Address receiver, ulong amount, string note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 71, 205, 113 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); noteAbi.From(note);

            var result = await base.CallApp(new List<object> { abiHandle, receiverAbi, amountAbi, noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Pay_Transactions(Algorand.Address receiver, ulong amount, string note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 71, 205, 113 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); noteAbi.From(note);

            return await base.MakeTransactionList(new List<object> { abiHandle, receiverAbi, amountAbi, noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer ASA (USDC / aUSDC) to receiver. Any registered, enabled agent may call.
        ///Uses global_max_asa_per_txn as the limit (no per-recipient ASA cap in this version).
        ///</summary>
        /// <param name="receiver"> </param>
        /// <param name="asset"> </param>
        /// <param name="amount"> </param>
        /// <param name="note"> </param>
        public async Task PayAsa(Algorand.Address receiver, ulong asset, ulong amount, string note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 14, 76, 191 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); noteAbi.From(note);

            var result = await base.CallApp(new List<object> { abiHandle, receiverAbi, assetAbi, amountAbi, noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PayAsa_Transactions(Algorand.Address receiver, ulong asset, ulong amount, string note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 14, 76, 191 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); noteAbi.From(note);

            return await base.MakeTransactionList(new List<object> { abiHandle, receiverAbi, assetAbi, amountAbi, noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register a new agent. Set max_per_txn=0 and/or daily_cap=0 to use global defaults.
        ///Overwrites existing config if agent already registered.
        ///Note: caller must fund the vault for the box MBR (~0.033 ALGO per agent).
        ///</summary>
        /// <param name="agent"> </param>
        /// <param name="max_per_txn"> </param>
        /// <param name="daily_cap"> </param>
        public async Task AddAgent(Algorand.Address agent, ulong max_per_txn, ulong daily_cap, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 116, 217, 33 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var max_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_per_txnAbi.From(max_per_txn);
            var daily_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); daily_capAbi.From(daily_cap);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi, max_per_txnAbi, daily_capAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddAgent_Transactions(Algorand.Address agent, ulong max_per_txn, ulong daily_cap, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 116, 217, 33 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var max_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_per_txnAbi.From(max_per_txn);
            var daily_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); daily_capAbi.From(daily_cap);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi, max_per_txnAbi, daily_capAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update an existing agent's limits without resetting spend counters.
        ///</summary>
        /// <param name="agent"> </param>
        /// <param name="max_per_txn"> </param>
        /// <param name="daily_cap"> </param>
        public async Task UpdateAgent(Algorand.Address agent, ulong max_per_txn, ulong daily_cap, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 13, 204, 17 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var max_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_per_txnAbi.From(max_per_txn);
            var daily_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); daily_capAbi.From(daily_cap);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi, max_per_txnAbi, daily_capAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAgent_Transactions(Algorand.Address agent, ulong max_per_txn, ulong daily_cap, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 13, 204, 17 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var max_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_per_txnAbi.From(max_per_txn);
            var daily_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); daily_capAbi.From(daily_cap);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi, max_per_txnAbi, daily_capAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Immediately block an agent from making payments (e.g. key compromise).
        ///</summary>
        /// <param name="agent"> </param>
        public async Task SuspendAgent(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 227, 87, 239 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SuspendAgent_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 227, 87, 239 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Re-enable a suspended agent.
        ///</summary>
        /// <param name="agent"> </param>
        public async Task ResumeAgent(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 112, 164, 114 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ResumeAgent_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 112, 164, 114 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Remove an agent entirely and reclaim box MBR.
        ///</summary>
        /// <param name="agent"> </param>
        public async Task RemoveAgent(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 102, 66, 36 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveAgent_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 102, 66, 36 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add or update a recipient config. Set limits to 0 to use global defaults.
        ///When allowlist_enabled=1, any recipient not in this map is blocked.
        ///Note: caller must fund the vault for the box MBR (~0.030 ALGO per recipient).
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="max_per_txn"> </param>
        /// <param name="daily_cap"> </param>
        public async Task AddRecipient(Algorand.Address recipient, ulong max_per_txn, ulong daily_cap, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 149, 220, 222 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var max_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_per_txnAbi.From(max_per_txn);
            var daily_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); daily_capAbi.From(daily_cap);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, max_per_txnAbi, daily_capAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddRecipient_Transactions(Algorand.Address recipient, ulong max_per_txn, ulong daily_cap, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 149, 220, 222 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var max_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_per_txnAbi.From(max_per_txn);
            var daily_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); daily_capAbi.From(daily_cap);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, max_per_txnAbi, daily_capAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update recipient limits without resetting spend counters.
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="max_per_txn"> </param>
        /// <param name="daily_cap"> </param>
        public async Task UpdateRecipient(Algorand.Address recipient, ulong max_per_txn, ulong daily_cap, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 178, 154, 36 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var max_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_per_txnAbi.From(max_per_txn);
            var daily_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); daily_capAbi.From(daily_cap);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, max_per_txnAbi, daily_capAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateRecipient_Transactions(Algorand.Address recipient, ulong max_per_txn, ulong daily_cap, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 178, 154, 36 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var max_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_per_txnAbi.From(max_per_txn);
            var daily_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); daily_capAbi.From(daily_cap);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, max_per_txnAbi, daily_capAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Remove a recipient config and reclaim box MBR.
        ///</summary>
        /// <param name="recipient"> </param>
        public async Task RemoveRecipient(Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 20, 15, 190 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveRecipient_Transactions(Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 20, 15, 190 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update global fallback limits (affects agents/recipients with 0 custom limits).
        ///</summary>
        /// <param name="max_per_txn"> </param>
        /// <param name="daily_cap"> </param>
        /// <param name="max_asa_per_txn"> </param>
        public async Task UpdateGlobalLimits(ulong max_per_txn, ulong daily_cap, ulong max_asa_per_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 178, 91, 56 };
            var max_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_per_txnAbi.From(max_per_txn);
            var daily_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); daily_capAbi.From(daily_cap);
            var max_asa_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_asa_per_txnAbi.From(max_asa_per_txn);

            var result = await base.CallApp(new List<object> { abiHandle, max_per_txnAbi, daily_capAbi, max_asa_per_txnAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateGlobalLimits_Transactions(ulong max_per_txn, ulong daily_cap, ulong max_asa_per_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 178, 91, 56 };
            var max_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_per_txnAbi.From(max_per_txn);
            var daily_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); daily_capAbi.From(daily_cap);
            var max_asa_per_txnAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_asa_per_txnAbi.From(max_asa_per_txn);

            return await base.MakeTransactionList(new List<object> { abiHandle, max_per_txnAbi, daily_capAbi, max_asa_per_txnAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Toggle recipient allowlist enforcement.
        ///</summary>
        /// <param name="enabled"> </param>
        public async Task SetAllowlistEnabled(ulong enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 31, 243, 44 };
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); enabledAbi.From(enabled);

            var result = await base.CallApp(new List<object> { abiHandle, enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAllowlistEnabled_Transactions(ulong enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 31, 243, 44 };
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); enabledAbi.From(enabled);

            return await base.MakeTransactionList(new List<object> { abiHandle, enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Owner withdraws native coin from vault.
        ///</summary>
        /// <param name="receiver"> </param>
        /// <param name="amount"> </param>
        public async Task OwnerWithdraw(Algorand.Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 13, 229, 82 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, receiverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OwnerWithdraw_Transactions(Algorand.Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 13, 229, 82 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, receiverAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Owner withdraws ASA from vault.
        ///</summary>
        /// <param name="receiver"> </param>
        /// <param name="asset"> </param>
        /// <param name="amount"> </param>
        public async Task OwnerWithdrawAsa(Algorand.Address receiver, ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 221, 230, 223 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, receiverAbi, assetAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OwnerWithdrawAsa_Transactions(Algorand.Address receiver, ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 221, 230, 223 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, receiverAbi, assetAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opt the vault account into an ASA before first pay_asa(). Owner only.
        ///</summary>
        /// <param name="asset"> </param>
        public async Task OptInAsa(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 192, 148, 89 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInAsa_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 192, 148, 89 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Global vault state — simulate, no fee.
        ///</summary>
        public async Task<Structs.GetGlobalStateReturn> GetGlobalState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 50, 25, 211 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetGlobalStateReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetGlobalState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 50, 25, 211 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the AgentConfig for a given agent address — simulate, no fee.
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<Structs.AgentConfig> GetAgentState(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 17, 255, 188 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.SimApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AgentConfig.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAgentState_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 17, 255, 188 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the RecipientConfig for a given recipient — simulate, no fee.
        ///</summary>
        /// <param name="recipient"> </param>
        public async Task<Structs.RecipientConfig> GetRecipientState(Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 182, 247, 156 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            var result = await base.SimApp(new List<object> { abiHandle, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RecipientConfig.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRecipientState_Transactions(Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 182, 247, 156 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3BlbmRpbmdDYXBWYXVsdCIsImRlc2MiOiJNdWx0aS1hZ2VudCBzcGVuZGluZyBjYXAgdmF1bHQuIFNhbWUgYnl0ZWNvZGUgb24gQWxnb3JhbmQgYW5kIFZvaS4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQWdlbnRDb25maWciOlt7Im5hbWUiOiJlbmFibGVkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1heF9wZXJfdHhuIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRhaWx5X2NhcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkYXlfYnVja2V0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRheV9zcGVudCIsInR5cGUiOiJ1aW50NjQifV0sIlJlY2lwaWVudENvbmZpZyI6W3sibmFtZSI6Im1heF9wZXJfdHhuIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRhaWx5X2NhcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkYXlfYnVja2V0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRheV9zcGVudCIsInR5cGUiOiJ1aW50NjQifV0sIkdldEdsb2JhbFN0YXRlUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ2IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjoiRGVwbG95IHRoZSB2YXVsdC4gTm8gYWdlbnRzIGFyZSBhZGRlZCB5ZXQg4oCUIHVzZSBhZGRfYWdlbnQoKSBhZnRlciBkZXBsb3ltZW50LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnbG9iYWxfbWF4X3Blcl90eG4iLCJkZXNjIjoiRGVmYXVsdCBtYXggbmF0aXZlIGNvaW4gcGVyIHBheW1lbnQgKG1pY3JvLXVuaXRzKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ2xvYmFsX2RhaWx5X2NhcCIsImRlc2MiOiJEZWZhdWx0IG1heCBuYXRpdmUgY29pbiBwZXIgVVRDIGRheSAobWljcm8tdW5pdHMpIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJnbG9iYWxfbWF4X2FzYV9wZXJfdHhuIiwiZGVzYyI6IkRlZmF1bHQgbWF4IEFTQSBiYXNlIHVuaXRzIHBlciBwYXlfYXNhKCkiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFsbG93bGlzdF9lbmFibGVkIiwiZGVzYyI6IjEgPSBvbmx5IHJlZ2lzdGVyZWQgcmVjaXBpZW50cyBhbGxvd2VkLCAwID0gb3BlbiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXkiLCJkZXNjIjoiUGF5IEFMR08vVk9JIHRvIHJlY2VpdmVyLiBBbnkgcmVnaXN0ZXJlZCwgZW5hYmxlZCBhZ2VudCBtYXkgY2FsbCB0aGlzLlxuRW5mb3JjZXMgKGluIG9yZGVyKTogICAxLiBBZ2VudCBtdXN0IGJlIHJlZ2lzdGVyZWQgYW5kIGVuYWJsZWQgICAyLiBBbW91bnQg4omkIGFnZW50J3MgZWZmZWN0aXZlIG1heF9wZXJfdHhuICAgMy4gQWdlbnQncyBlZmZlY3RpdmUgZGFpbHlfY2FwIG5vdCBleGNlZWRlZCAgIDQuIElmIGFsbG93bGlzdF9lbmFibGVkPTE6IHJlY2VpdmVyIG11c3QgaGF2ZSBhIFJlY2lwaWVudENvbmZpZyBlbnRyeSAgIDUuIEFtb3VudCDiiaQgcmVjaXBpZW50J3MgZWZmZWN0aXZlIG1heF9wZXJfdHhuIChpZiBjb25maWcgZXhpc3RzKSAgIDYuIFJlY2lwaWVudCdzIGVmZmVjdGl2ZSBkYWlseV9jYXAgbm90IGV4Y2VlZGVkIChpZiBjb25maWcgZXhpc3RzKSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibm90ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXlfYXNhIiwiZGVzYyI6IlRyYW5zZmVyIEFTQSAoVVNEQyAvIGFVU0RDKSB0byByZWNlaXZlci4gQW55IHJlZ2lzdGVyZWQsIGVuYWJsZWQgYWdlbnQgbWF5IGNhbGwuXG5Vc2VzIGdsb2JhbF9tYXhfYXNhX3Blcl90eG4gYXMgdGhlIGxpbWl0IChubyBwZXItcmVjaXBpZW50IEFTQSBjYXAgaW4gdGhpcyB2ZXJzaW9uKS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub3RlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZF9hZ2VudCIsImRlc2MiOiJSZWdpc3RlciBhIG5ldyBhZ2VudC4gU2V0IG1heF9wZXJfdHhuPTAgYW5kL29yIGRhaWx5X2NhcD0wIHRvIHVzZSBnbG9iYWwgZGVmYXVsdHMuXG5PdmVyd3JpdGVzIGV4aXN0aW5nIGNvbmZpZyBpZiBhZ2VudCBhbHJlYWR5IHJlZ2lzdGVyZWQuXG5Ob3RlOiBjYWxsZXIgbXVzdCBmdW5kIHRoZSB2YXVsdCBmb3IgdGhlIGJveCBNQlIgKH4wLjAzMyBBTEdPIHBlciBhZ2VudCkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF4X3Blcl90eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhaWx5X2NhcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfYWdlbnQiLCJkZXNjIjoiVXBkYXRlIGFuIGV4aXN0aW5nIGFnZW50J3MgbGltaXRzIHdpdGhvdXQgcmVzZXR0aW5nIHNwZW5kIGNvdW50ZXJzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1heF9wZXJfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYWlseV9jYXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VzcGVuZF9hZ2VudCIsImRlc2MiOiJJbW1lZGlhdGVseSBibG9jayBhbiBhZ2VudCBmcm9tIG1ha2luZyBwYXltZW50cyAoZS5nLiBrZXkgY29tcHJvbWlzZSkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXN1bWVfYWdlbnQiLCJkZXNjIjoiUmUtZW5hYmxlIGEgc3VzcGVuZGVkIGFnZW50LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVtb3ZlX2FnZW50IiwiZGVzYyI6IlJlbW92ZSBhbiBhZ2VudCBlbnRpcmVseSBhbmQgcmVjbGFpbSBib3ggTUJSLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX3JlY2lwaWVudCIsImRlc2MiOiJBZGQgb3IgdXBkYXRlIGEgcmVjaXBpZW50IGNvbmZpZy4gU2V0IGxpbWl0cyB0byAwIHRvIHVzZSBnbG9iYWwgZGVmYXVsdHMuXG5XaGVuIGFsbG93bGlzdF9lbmFibGVkPTEsIGFueSByZWNpcGllbnQgbm90IGluIHRoaXMgbWFwIGlzIGJsb2NrZWQuXG5Ob3RlOiBjYWxsZXIgbXVzdCBmdW5kIHRoZSB2YXVsdCBmb3IgdGhlIGJveCBNQlIgKH4wLjAzMCBBTEdPIHBlciByZWNpcGllbnQpLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXhfcGVyX3R4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGFpbHlfY2FwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9yZWNpcGllbnQiLCJkZXNjIjoiVXBkYXRlIHJlY2lwaWVudCBsaW1pdHMgd2l0aG91dCByZXNldHRpbmcgc3BlbmQgY291bnRlcnMuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1heF9wZXJfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYWlseV9jYXAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVtb3ZlX3JlY2lwaWVudCIsImRlc2MiOiJSZW1vdmUgYSByZWNpcGllbnQgY29uZmlnIGFuZCByZWNsYWltIGJveCBNQlIuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX2dsb2JhbF9saW1pdHMiLCJkZXNjIjoiVXBkYXRlIGdsb2JhbCBmYWxsYmFjayBsaW1pdHMgKGFmZmVjdHMgYWdlbnRzL3JlY2lwaWVudHMgd2l0aCAwIGN1c3RvbSBsaW1pdHMpLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXhfcGVyX3R4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGFpbHlfY2FwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXhfYXNhX3Blcl90eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2FsbG93bGlzdF9lbmFibGVkIiwiZGVzYyI6IlRvZ2dsZSByZWNpcGllbnQgYWxsb3dsaXN0IGVuZm9yY2VtZW50LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmFibGVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im93bmVyX3dpdGhkcmF3IiwiZGVzYyI6Ik93bmVyIHdpdGhkcmF3cyBuYXRpdmUgY29pbiBmcm9tIHZhdWx0LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvd25lcl93aXRoZHJhd19hc2EiLCJkZXNjIjoiT3duZXIgd2l0aGRyYXdzIEFTQSBmcm9tIHZhdWx0LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luX2FzYSIsImRlc2MiOiJPcHQgdGhlIHZhdWx0IGFjY291bnQgaW50byBhbiBBU0EgYmVmb3JlIGZpcnN0IHBheV9hc2EoKS4gT3duZXIgb25seS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2dsb2JhbF9zdGF0ZSIsImRlc2MiOiJHbG9iYWwgdmF1bHQgc3RhdGUg4oCUIHNpbXVsYXRlLCBubyBmZWUuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0R2xvYmFsU3RhdGVSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hZ2VudF9zdGF0ZSIsImRlc2MiOiJSZXR1cm4gdGhlIEFnZW50Q29uZmlnIGZvciBhIGdpdmVuIGFnZW50IGFkZHJlc3Mg4oCUIHNpbXVsYXRlLCBubyBmZWUuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJBZ2VudENvbmZpZyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3JlY2lwaWVudF9zdGF0ZSIsImRlc2MiOiJSZXR1cm4gdGhlIFJlY2lwaWVudENvbmZpZyBmb3IgYSBnaXZlbiByZWNpcGllbnQg4oCUIHNpbXVsYXRlLCBubyBmZWUuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJSZWNpcGllbnRDb25maWciLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo3LCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNjcwLDgyOCwxMzA1LDEzNjJdLCJlcnJvck1lc3NhZ2UiOiJBZGRyZXNzIGxlbmd0aCBpcyAzMiBieXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5Nl0sImVycm9yTWVzc2FnZSI6IkFnZW50IGRhaWx5IGNhcCBleGNlZWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxMSw3NzhdLCJlcnJvck1lc3NhZ2UiOiJBZ2VudCBpcyBzdXNwZW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDIsNzcxLDk1Miw5OTAsMTAyMCwxNTA0XSwiZXJyb3JNZXNzYWdlIjoiQWdlbnQgbm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTMsNzU0XSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMxXSwiZXJyb3JNZXNzYWdlIjoiRXhjZWVkcyBhZ2VudCBtYXhfcGVyX3R4biIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2M10sImVycm9yTWVzc2FnZSI6IkV4Y2VlZHMgbWF4X2FzYV9wZXJfdHhuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTY2XSwiZXJyb3JNZXNzYWdlIjoiRXhjZWVkcyByZWNpcGllbnQgbWF4X3Blcl90eG4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4ODQsOTQzLDk4MiwxMDEyLDEwNDIsMTA4OSwxMTQzLDExODIsMTIyOSwxMjY1LDEyOTcsMTM1NCwxMzk5XSwiZXJyb3JNZXNzYWdlIjoiT25seSBvd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzMV0sImVycm9yTWVzc2FnZSI6IlJlY2lwaWVudCBkYWlseSBjYXAgZXhjZWVkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjEsNzk2XSwiZXJyb3JNZXNzYWdlIjoiUmVjaXBpZW50IG5vdCBpbiBhbGxvd2xpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTUyLDE1MjldLCJlcnJvck1lc3NhZ2UiOiJSZWNpcGllbnQgbm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDgsNzgzLDE0NDRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFsbG93bGlzdF9lbmFibGVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3OCw2MTIsMTQzMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZ2xvYmFsX2RhaWx5X2NhcCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NTksMTQzOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZ2xvYmFsX21heF9hc2FfcGVyX3R4biBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjIsNTU3LDE0MjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmdsb2JhbF9tYXhfcGVyX3R4biBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4ODIsOTQxLDk4MCwxMDEwLDEwNDAsMTA4NywxMTQxLDExODAsMTIyNywxMjYzLDEyOTUsMTM1MiwxMzk3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlY2lwaWVudHMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQzLDE0NTBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3BhaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODAxLDE0NTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3BhaWRfYXNhIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1Nyw4MTUsMTQ2MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudHhfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzgwLDc0MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4Nyw3NDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYzLDcxNCw4NjAsOTE5LDk3NCwxMDA0LDEwMzQsMTA2NSwxMTE5LDExNzQsMTI4MSwxMzI5LDE0OTYsMTUyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODYsMjk0LDMwMiwzMTAsMzcxLDcyMiw3MzEsODY4LDg3Niw5MjcsOTM1LDEwNzMsMTA4MSwxMTI3LDExMzUsMTIwNSwxMjEzLDEyMjEsMTI1NywxMjg5LDEzMzcsMTM0NiwxMzkwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0F6TWlBNE5qUXdNQW9nSUNBZ1lubDBaV05pYkc5amF5QWliM2R1WlhJaUlEQjROakUyTnpWbUlEQjROekkyTXpWbUlDSjBlRjlqYjNWdWRDSWdJbWRmYldGNFgzUjRiaUlnSW1kZlpHRnBiSGxmWTJGd0lpQWlZV3hmWlc1aFlteGxaQ0lnTUhnd01EQXdNREF3TURBd01EQXdNREF3SUNKblgyMWhlRjloYzJFaUlDSjBiM1JoYkY5d1lXbGtJaUFpZEc5MFlXeGZZWE5oSWlBd2VERTFNV1kzWXpjMUlEQjRNREF3TURBd01EQXdNREF3TURBd01Rb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pZekNpQWdJQ0F2THlCamJHRnpjeUJUY0dWdVpHbHVaME5oY0ZaaGRXeDBLRUZTUXpSRGIyNTBjbUZqZEN3Z1lYWnRYM1psY25OcGIyNDlNVEFwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXlOQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFE0TkRkalpEY3hJREI0WldNd1pUUmpZbVlnTUhnNE9UYzBaRGt5TVNBd2VESmtNR1JqWXpFeElEQjRZV1ZsTXpVM1pXWWdNSGhoTURjd1lUUTNNaUF3ZUdZNU5qWTBNakkwSURCNFl6WTVOV1JqWkdVZ01IZzFNR0l5T1dFeU5DQXdlR0kyTVRRd1ptSmxJREI0TlRsaU1qVmlNemdnTUhneE16Rm1aak15WXlBd2VESXpNR1JsTlRVeUlEQjROalJrWkdVMlpHWWdNSGc1TVdNd09UUTFPU0F3ZUdRMU16SXhPV1F6SURCNE5EQXhNV1ptWW1NZ01IaGxNR0kyWmpjNVl5QXZMeUJ0WlhSb2IyUWdJbkJoZVNoaFpHUnlaWE56TEhWcGJuUTJOQ3h6ZEhKcGJtY3BkbTlwWkNJc0lHMWxkR2h2WkNBaWNHRjVYMkZ6WVNoaFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNjM1J5YVc1bktYWnZhV1FpTENCdFpYUm9iMlFnSW1Ga1pGOWhaMlZ1ZENoaFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWRYQmtZWFJsWDJGblpXNTBLR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p6ZFhOd1pXNWtYMkZuWlc1MEtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WemRXMWxYMkZuWlc1MEtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WdGIzWmxYMkZuWlc1MEtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVdSa1gzSmxZMmx3YVdWdWRDaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlkWEJrWVhSbFgzSmxZMmx3YVdWdWRDaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljbVZ0YjNabFgzSmxZMmx3YVdWdWRDaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVjluYkc5aVlXeGZiR2x0YVhSektIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRjloYkd4dmQyeHBjM1JmWlc1aFlteGxaQ2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWIzZHVaWEpmZDJsMGFHUnlZWGNvWVdSa2NtVnpjeXgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWIzZHVaWEpmZDJsMGFHUnlZWGRmWVhOaEtHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnZjSFJmYVc1ZllYTmhLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZaMnh2WW1Gc1gzTjBZWFJsS0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWjJWMFgyRm5aVzUwWDNOMFlYUmxLR0ZrWkhKbGMzTXBLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZmNtVmphWEJwWlc1MFgzTjBZWFJsS0dGa1pISmxjM01wS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQndZWGtnY0dGNVgyRnpZU0JoWkdSZllXZGxiblFnZFhCa1lYUmxYMkZuWlc1MElITjFjM0JsYm1SZllXZGxiblFnY21WemRXMWxYMkZuWlc1MElISmxiVzkyWlY5aFoyVnVkQ0JoWkdSZmNtVmphWEJwWlc1MElIVndaR0YwWlY5eVpXTnBjR2xsYm5RZ2NtVnRiM1psWDNKbFkybHdhV1Z1ZENCMWNHUmhkR1ZmWjJ4dlltRnNYMnhwYldsMGN5QnpaWFJmWVd4c2IzZHNhWE4wWDJWdVlXSnNaV1FnYjNkdVpYSmZkMmwwYUdSeVlYY2diM2R1WlhKZmQybDBhR1J5WVhkZllYTmhJRzl3ZEY5cGJsOWhjMkVnWjJWMFgyZHNiMkpoYkY5emRHRjBaU0JuWlhSZllXZGxiblJmYzNSaGRHVWdaMlYwWDNKbFkybHdhV1Z1ZEY5emRHRjBaUW9nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREkwT2dvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPall6Q2lBZ0lDQXZMeUJqYkdGemN5QlRjR1Z1WkdsdVowTmhjRlpoZFd4MEtFRlNRelJEYjI1MGNtRmpkQ3dnWVhadFgzWmxjbk5wYjI0OU1UQXBPZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNbVptTlRjMFpUa2dMeThnYldWMGFHOWtJQ0pqY21WaGRHVW9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdVS0lDQWdJR1Z5Y2dvS0NpOHZJSE53Wlc1a2FXNW5YMk5oY0M1VGNHVnVaR2x1WjBOaGNGWmhkV3gwTG1OeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVG9LSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUbzVNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk1UQTVDaUFnSUNBdkx5QnpaV3htTG05M2JtVnlMblpoYkhWbElDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUQwZ1ZIaHVMbk5sYm1SbGNnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWIzZHVaWElpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qRXhNQW9nSUNBZ0x5OGdjMlZzWmk1bmJHOWlZV3hmYldGNFgzQmxjbDkwZUc0dWRtRnNkV1VnSUNBOUlHZHNiMkpoYkY5dFlYaGZjR1Z5WDNSNGJpNXVZWFJwZG1VS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1luUnZhUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlaMTl0WVhoZmRIaHVJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3hNVEVLSUNBZ0lDOHZJSE5sYkdZdVoyeHZZbUZzWDJSaGFXeDVYMk5oY0M1MllXeDFaU0FnSUNBZ1BTQm5iRzlpWVd4ZlpHRnBiSGxmWTJGd0xtNWhkR2wyWlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWRHOXBDaUFnSUNCaWVYUmxZeUExSUM4dklDSm5YMlJoYVd4NVgyTmhjQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNVEV5Q2lBZ0lDQXZMeUJ6Wld4bUxtZHNiMkpoYkY5dFlYaGZZWE5oWDNCbGNsOTBlRzR1ZG1Gc2RXVWdQU0JuYkc5aVlXeGZiV0Y0WDJGellWOXdaWEpmZEhodUxtNWhkR2wyWlFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWjE5dFlYaGZZWE5oSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG94TVRNS0lDQWdJQzh2SUhObGJHWXVZV3hzYjNkc2FYTjBYMlZ1WVdKc1pXUXVkbUZzZFdVZ0lDQWdQU0JoYkd4dmQyeHBjM1JmWlc1aFlteGxaQzV1WVhScGRtVUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltRnNYMlZ1WVdKc1pXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qRXhOQW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl3WVdsa0xuWmhiSFZsSUNBZ0lDQWdJQ0FnSUNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRHOTBZV3hmY0dGcFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pFeE5Rb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXdZV2xrWDJGellTNTJZV3gxWlNBZ0lDQWdJQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW5SdmRHRnNYMkZ6WVNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPakV4TmdvZ0lDQWdMeThnYzJWc1ppNTBlRjlqYjNWdWRDNTJZV3gxWlNBZ0lDQWdJQ0FnSUNBZ0lDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkSGhmWTI5MWJuUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvNU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjM0JsYm1ScGJtZGZZMkZ3TGxOd1pXNWthVzVuUTJGd1ZtRjFiSFF1Y0dGNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjR0Y1T2dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNVGt6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG95TVRFS0lDQWdJQzh2SUc1aGRHbDJaVjloYlc5MWJuUWdJQ0E5SUdGdGIzVnVkQzV1WVhScGRtVUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pJeE1nb2dJQ0FnTHk4Z1lXZGxiblJmWVdSa2NpQWdJQ0FnSUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWEl1WW5sMFpYTXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TWpFMENpQWdJQ0F2THlCaGMzTmxjblFnYm1GMGFYWmxYMkZ0YjNWdWRDQStJRlZKYm5RMk5DZ3dLU3dnSWtGdGIzVnVkQ0J0ZFhOMElHSmxJRDRnTUNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYlc5MWJuUWdiWFZ6ZENCaVpTQStJREFLSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3hNelVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhaMlZ1ZEY5aFpHUnlJR2x1SUhObGJHWXVZV2RsYm5SekxDQWlRV2RsYm5RZ2JtOTBJSEpsWjJsemRHVnlaV1FpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TmpFMk56Vm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXZGxiblFnYm05MElISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRveE16WUtJQ0FnSUM4dklHTm1aeUE5SUhObGJHWXVZV2RsYm5SelcyRm5aVzUwWDJGa1pISmRMbU52Y0hrb0tRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCa2RYQnVJRElLSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3hNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQmpabWN1Wlc1aFlteGxaQzV1WVhScGRtVWdQVDBnVlVsdWREWTBLREVwTENBaVFXZGxiblFnYVhNZ2MzVnpjR1Z1WkdWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaMlZ1ZENCcGN5QnpkWE53Wlc1a1pXUUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRveE5ESUtJQ0FnSUM4dklHTm1aeTV0WVhoZmNHVnlYM1I0Ymk1dVlYUnBkbVVzSUhObGJHWXVaMnh2WW1Gc1gyMWhlRjl3WlhKZmRIaHVMblpoYkhWbENpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbWRmYldGNFgzUjRiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNW5iRzlpWVd4ZmJXRjRYM0JsY2w5MGVHNGdaWGhwYzNSekNpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TVRJekNpQWdJQ0F2THlCcFppQnpjR1ZqYVdacFl5QStJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHSjZJSEJoZVY5aFpuUmxjbDlwWmw5bGJITmxRREkzQ2lBZ0lDQmthV2NnTVFvS2NHRjVYMkZtZEdWeVgybHViR2x1WldSZmMzQmxibVJwYm1kZlkyRndMbE53Wlc1a2FXNW5RMkZ3Vm1GMWJIUXVYMlZtWm1WamRHbDJaVjlzYVcxcGRFQXlPRG9LSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3hORFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhiVzkxYm5RZ1BEMGdaV1ptWDIxaGVDd2dJa1Y0WTJWbFpITWdZV2RsYm5RZ2JXRjRYM0JsY2w5MGVHNGlDaUFnSUNCa2FXY2dOUW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCRmVHTmxaV1J6SUdGblpXNTBJRzFoZUY5d1pYSmZkSGh1Q2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNVFEyTFRFME53b2dJQ0FnTHk4Z0l5QlNaWE5sZENCa1lXbHNlU0JpZFdOclpYUWdhV1lnVlZSRElHUmhlU0JvWVhNZ2NtOXNiR1ZrSUc5MlpYSUtJQ0FnSUM4dklHTjFjbkpsYm5SZlluVmphMlYwSUQwZ1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFnTHk4Z1ZVbHVkRFkwS0RnMk5EQXdLUW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FXNTBZeUEwSUM4dklEZzJOREF3Q2lBZ0lDQXZDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVEFLSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3hORGdLSUNBZ0lDOHZJR2xtSUdOMWNuSmxiblJmWW5WamEyVjBJRDRnWTJabkxtUmhlVjlpZFdOclpYUXVibUYwYVhabE9nb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0ErQ2lBZ0lDQmllaUJ3WVhsZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPakUwT1FvZ0lDQWdMeThnWTJabkxtUmhlVjlpZFdOclpYUWdQU0JoY21NMExsVkpiblEyTkNoamRYSnlaVzUwWDJKMVkydGxkQ2tLSUNBZ0lHUnBaeUE0Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdNalFLSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3hOVEFLSUNBZ0lDOHZJR05tWnk1a1lYbGZjM0JsYm5RZ0lEMGdZWEpqTkM1VlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnlaWEJzWVdObE1pQXpNZ29nSUNBZ1luVnllU0F6Q2dwd1lYbGZZV1owWlhKZmFXWmZaV3h6WlVBeE1qb0tJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRveE5UUUtJQ0FnSUM4dklHTm1aeTVrWVdsc2VWOWpZWEF1Ym1GMGFYWmxMQ0J6Wld4bUxtZHNiMkpoYkY5a1lXbHNlVjlqWVhBdWRtRnNkV1VLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElERTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSm5YMlJoYVd4NVgyTmhjQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZFhKNUlETUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtZHNiMkpoYkY5a1lXbHNlVjlqWVhBZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNVEl6Q2lBZ0lDQXZMeUJwWmlCemNHVmphV1pwWXlBK0lGVkpiblEyTkNnd0tUb0tJQ0FnSUdKNklIQmhlVjloWm5SbGNsOXBabDlsYkhObFFESXpDaUFnSUNCa2FXY2dNUW9LY0dGNVgyRm1kR1Z5WDJsdWJHbHVaV1JmYzNCbGJtUnBibWRmWTJGd0xsTndaVzVrYVc1blEyRndWbUYxYkhRdVgyVm1abVZqZEdsMlpWOXNhVzFwZEVBeU5Eb0tJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRveE5UWUtJQ0FnSUM4dklHRnpjMlZ5ZENCalptY3VaR0Y1WDNOd1pXNTBMbTVoZEdsMlpTQXJJR0Z0YjNWdWRDQThQU0JsWm1aZlkyRndMQ0FpUVdkbGJuUWdaR0ZwYkhrZ1kyRndJR1Y0WTJWbFpHVmtJZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRGNLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFRm5aVzUwSUdSaGFXeDVJR05oY0NCbGVHTmxaV1JsWkFvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPakUxT0MweE5Ua0tJQ0FnSUM4dklDTWdWWEJrWVhSbElITndaVzVrSUdGdVpDQjNjbWwwWlNCaVlXTnJDaUFnSUNBdkx5QmpabWN1WkdGNVgzTndaVzUwSUQwZ1lYSmpOQzVWU1c1ME5qUW9ZMlpuTG1SaGVWOXpjR1Z1ZEM1dVlYUnBkbVVnS3lCaGJXOTFiblFwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQXpNZ29nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qRTJNQW9nSUNBZ0x5OGdjMlZzWmk1aFoyVnVkSE5iWVdkbGJuUmZZV1JrY2wwZ1BTQmpabWN1WTI5d2VTZ3BDaUFnSUNCa2FXY2dOQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPakl4T1MweU1qQUtJQ0FnSUM4dklDTWdRV3hzYjNkc2FYTjBJR05vWldOckNpQWdJQ0F2THlCcFppQnpaV3htTG1Gc2JHOTNiR2x6ZEY5bGJtRmliR1ZrTG5aaGJIVmxJRDA5SUZWSmJuUTJOQ2d4S1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0poYkY5bGJtRmliR1ZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRnNiRzkzYkdsemRGOWxibUZpYkdWa0lHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQndZWGxmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk1qSXhDaUFnSUNBdkx5QmhjM05sY25RZ2NtVmpaV2wyWlhJZ2FXNGdjMlZzWmk1eVpXTnBjR2xsYm5SekxDQWlVbVZqYVhCcFpXNTBJRzV2ZENCcGJpQmhiR3h2ZDJ4cGMzUWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROekkyTXpWbUNpQWdJQ0JrYVdjZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJTWldOcGNHbGxiblFnYm05MElHbHVJR0ZzYkc5M2JHbHpkQW9LY0dGNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG94TnpBS0lDQWdJQzh2SUdsbUlISmxZMmx3YVdWdWRGOWhaR1J5SUdsdUlITmxiR1l1Y21WamFYQnBaVzUwY3pvS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnM01qWXpOV1lLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBMUNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJSEJoZVY5aFpuUmxjbDlwWmw5bGJITmxRRGdLSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3hOekVLSUNBZ0lDOHZJR05tWnlBOUlITmxiR1l1Y21WamFYQnBaVzUwYzF0eVpXTnBjR2xsYm5SZllXUmtjbDB1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNd29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpZFhKNUlEVUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuSmxZMmx3YVdWdWRITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNVGMwQ2lBZ0lDQXZMeUJqWm1jdWJXRjRYM0JsY2w5MGVHNHVibUYwYVhabExDQnpaV3htTG1kc2IySmhiRjl0WVhoZmNHVnlYM1I0Ymk1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltZGZiV0Y0WDNSNGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkWEo1SURNS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1kc2IySmhiRjl0WVhoZmNHVnlYM1I0YmlCbGVHbHpkSE1LSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3hNak1LSUNBZ0lDOHZJR2xtSUhOd1pXTnBabWxqSUQ0Z1ZVbHVkRFkwS0RBcE9nb2dJQ0FnWW5vZ2NHRjVYMkZtZEdWeVgybG1YMlZzYzJWQU1Ua0tJQ0FnSUdScFp5QXhDZ3B3WVhsZllXWjBaWEpmYVc1c2FXNWxaRjl6Y0dWdVpHbHVaMTlqWVhBdVUzQmxibVJwYm1kRFlYQldZWFZzZEM1ZlpXWm1aV04wYVhabFgyeHBiV2wwUURJd09nb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pFM05nb2dJQ0FnTHk4Z1lYTnpaWEowSUdGdGIzVnVkQ0E4UFNCbFptWmZiV0Y0TENBaVJYaGpaV1ZrY3lCeVpXTnBjR2xsYm5RZ2JXRjRYM0JsY2w5MGVHNGlDaUFnSUNCa2FXY2dOUW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCRmVHTmxaV1J6SUhKbFkybHdhV1Z1ZENCdFlYaGZjR1Z5WDNSNGJnb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pFM09Bb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5aWRXTnJaWFFnUFNCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0F2THlCVlNXNTBOalFvT0RZME1EQXBDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGJuUmpJRFFnTHk4Z09EWTBNREFLSUNBZ0lDOEtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNQW9nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qRTNPUW9nSUNBZ0x5OGdhV1lnWTNWeWNtVnVkRjlpZFdOclpYUWdQaUJqWm1jdVpHRjVYMkoxWTJ0bGRDNXVZWFJwZG1VNkNpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJRDRLSUNBZ0lHSjZJSEJoZVY5aFpuUmxjbDlwWmw5bGJITmxRRGNLSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3hPREFLSUNBZ0lDOHZJR05tWnk1a1lYbGZZblZqYTJWMElEMGdZWEpqTkM1VlNXNTBOalFvWTNWeWNtVnVkRjlpZFdOclpYUXBDaUFnSUNCa2FXY2dPQW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlERTJDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk1UZ3hDaUFnSUNBdkx5QmpabWN1WkdGNVgzTndaVzUwSUNBOUlHRnlZelF1VlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2NtVndiR0ZqWlRJZ01qUUtJQ0FnSUdKMWNua2dNd29LY0dGNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTnpvS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG94T0RRS0lDQWdJQzh2SUdObVp5NWtZV2xzZVY5allYQXVibUYwYVhabExDQnpaV3htTG1kc2IySmhiRjlrWVdsc2VWOWpZWEF1ZG1Gc2RXVUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVoxOWtZV2xzZVY5allYQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjM2RoY0FvZ0lDQWdZblZ5ZVNBekNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bmJHOWlZV3hmWkdGcGJIbGZZMkZ3SUdWNGFYTjBjd29nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qRXlNd29nSUNBZ0x5OGdhV1lnYzNCbFkybG1hV01nUGlCVlNXNTBOalFvTUNrNkNpQWdJQ0JpZWlCd1lYbGZZV1owWlhKZmFXWmZaV3h6WlVBeE5Rb2dJQ0FnWkdsbklERUtDbkJoZVY5aFpuUmxjbDlwYm14cGJtVmtYM053Wlc1a2FXNW5YMk5oY0M1VGNHVnVaR2x1WjBOaGNGWmhkV3gwTGw5bFptWmxZM1JwZG1WZmJHbHRhWFJBTVRZNkNpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TVRnMkNpQWdJQ0F2THlCaGMzTmxjblFnWTJabkxtUmhlVjl6Y0dWdWRDNXVZWFJwZG1VZ0t5QmhiVzkxYm5RZ1BEMGdaV1ptWDJOaGNDd2dJbEpsWTJsd2FXVnVkQ0JrWVdsc2VTQmpZWEFnWlhoalpXVmtaV1FpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRGNLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklGSmxZMmx3YVdWdWRDQmtZV2xzZVNCallYQWdaWGhqWldWa1pXUUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRveE9EZ0tJQ0FnSUM4dklHTm1aeTVrWVhsZmMzQmxiblFnUFNCaGNtTTBMbFZKYm5RMk5DaGpabWN1WkdGNVgzTndaVzUwTG01aGRHbDJaU0FySUdGdGIzVnVkQ2tLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlESTBDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk1UZzVDaUFnSUNBdkx5QnpaV3htTG5KbFkybHdhV1Z1ZEhOYmNtVmphWEJwWlc1MFgyRmtaSEpkSUQwZ1kyWm5MbU52Y0hrb0tRb2dJQ0FnWkdsbklEUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLQ25CaGVWOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TWpJMkxUSXlOd29nSUNBZ0x5OGdJeUJXWVhWc2RDMTNhV1JsSUdOdmRXNTBaWEp6Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNCaGFXUXVkbUZzZFdVZ1BTQnpaV3htTG5SdmRHRnNYM0JoYVdRdWRtRnNkV1VnS3lCdVlYUnBkbVZmWVcxdmRXNTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRHOTBZV3hmY0dGcFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXdZV2xrSUdWNGFYTjBjd29nSUNBZ1pHbG5JRFVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdLd29nSUNBZ1lubDBaV01nT1NBdkx5QWlkRzkwWVd4ZmNHRnBaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNakk0Q2lBZ0lDQXZMeUJ6Wld4bUxuUjRYMk52ZFc1MExuWmhiSFZsSUNBZ1BTQnpaV3htTG5SNFgyTnZkVzUwTG5aaGJIVmxJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkSGhmWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEhoZlkyOTFiblFnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEhoZlkyOTFiblFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPakl6TUMweU16VUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxQlkyTnZkVzUwS0hKbFkyVnBkbVZ5TG1KNWRHVnpLU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5Ym1GMGFYWmxYMkZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J1YjNSbFBXNXZkR1V1WW5sMFpYTXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBVZHNiMkpoYkM1dGFXNWZkSGh1WDJabFpTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG95TXpRS0lDQWdJQzh2SUdabFpUMUhiRzlpWVd3dWJXbHVYM1I0Ymw5bVpXVXNDaUFnSUNCbmJHOWlZV3dnVFdsdVZIaHVSbVZsQ2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNak14Q2lBZ0lDQXZMeUJ5WldObGFYWmxjajFCWTJOdmRXNTBLSEpsWTJWcGRtVnlMbUo1ZEdWektTd0tJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnWkdsbklEa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUVdSa2NtVnpjeUJzWlc1bmRHZ2dhWE1nTXpJZ1lubDBaWE1LSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRTV2ZEdVS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCa2FXY2dPQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pJek1Bb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRveU16QXRNak0xQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlRV05qYjNWdWRDaHlaV05sYVhabGNpNWllWFJsY3lrc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXNWhkR2wyWlY5aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVDF1YjNSbExtSjVkR1Z6TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFIYkc5aVlXd3ViV2x1WDNSNGJsOW1aV1VzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qRTVNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHdZWGxmWVdaMFpYSmZhV1pmWld4elpVQXhOVG9LSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qRTRNeTB4T0RVS0lDQWdJQzh2SUdWbVpsOWpZWEFnUFNCelpXeG1MbDlsWm1abFkzUnBkbVZmYkdsdGFYUW9DaUFnSUNBdkx5QWdJQ0FnWTJabkxtUmhhV3g1WDJOaGNDNXVZWFJwZG1Vc0lITmxiR1l1WjJ4dlltRnNYMlJoYVd4NVgyTmhjQzUyWVd4MVpRb2dJQ0FnTHk4Z0tRb2dJQ0FnWWlCd1lYbGZZV1owWlhKZmFXNXNhVzVsWkY5emNHVnVaR2x1WjE5allYQXVVM0JsYm1ScGJtZERZWEJXWVhWc2RDNWZaV1ptWldOMGFYWmxYMnhwYldsMFFERTJDZ3B3WVhsZllXWjBaWEpmYVdaZlpXeHpaVUF4T1RvS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPakUzTXkweE56VUtJQ0FnSUM4dklHVm1abDl0WVhnZ1BTQnpaV3htTGw5bFptWmxZM1JwZG1WZmJHbHRhWFFvQ2lBZ0lDQXZMeUFnSUNBZ1kyWm5MbTFoZUY5d1pYSmZkSGh1TG01aGRHbDJaU3dnYzJWc1ppNW5iRzlpWVd4ZmJXRjRYM0JsY2w5MGVHNHVkbUZzZFdVS0lDQWdJQzh2SUNrS0lDQWdJR0lnY0dGNVgyRm1kR1Z5WDJsdWJHbHVaV1JmYzNCbGJtUnBibWRmWTJGd0xsTndaVzVrYVc1blEyRndWbUYxYkhRdVgyVm1abVZqZEdsMlpWOXNhVzFwZEVBeU1Bb0tjR0Y1WDJGbWRHVnlYMmxtWDJWc2MyVkFNak02Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3hOVEl0TVRVMUNpQWdJQ0F2THlBaklFVm1abVZqZEdsMlpTQmtZV2xzZVNCallYQWdabTl5SUhSb2FYTWdZV2RsYm5RS0lDQWdJQzh2SUdWbVpsOWpZWEFnUFNCelpXeG1MbDlsWm1abFkzUnBkbVZmYkdsdGFYUW9DaUFnSUNBdkx5QWdJQ0FnWTJabkxtUmhhV3g1WDJOaGNDNXVZWFJwZG1Vc0lITmxiR1l1WjJ4dlltRnNYMlJoYVd4NVgyTmhjQzUyWVd4MVpRb2dJQ0FnTHk4Z0tRb2dJQ0FnWWlCd1lYbGZZV1owWlhKZmFXNXNhVzVsWkY5emNHVnVaR2x1WjE5allYQXVVM0JsYm1ScGJtZERZWEJXWVhWc2RDNWZaV1ptWldOMGFYWmxYMnhwYldsMFFESTBDZ3B3WVhsZllXWjBaWEpmYVdaZlpXeHpaVUF5TnpvS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPakUwTUMweE5ETUtJQ0FnSUM4dklDTWdSV1ptWldOMGFYWmxJRzFoZUNCd1pYSWdkSGh1SUdadmNpQjBhR2x6SUdGblpXNTBDaUFnSUNBdkx5QmxabVpmYldGNElEMGdjMlZzWmk1ZlpXWm1aV04wYVhabFgyeHBiV2wwS0FvZ0lDQWdMeThnSUNBZ0lHTm1aeTV0WVhoZmNHVnlYM1I0Ymk1dVlYUnBkbVVzSUhObGJHWXVaMnh2WW1Gc1gyMWhlRjl3WlhKZmRIaHVMblpoYkhWbENpQWdJQ0F2THlBcENpQWdJQ0JpSUhCaGVWOWhablJsY2w5cGJteHBibVZrWDNOd1pXNWthVzVuWDJOaGNDNVRjR1Z1WkdsdVowTmhjRlpoZFd4MExsOWxabVpsWTNScGRtVmZiR2x0YVhSQU1qZ0tDZ292THlCemNHVnVaR2x1WjE5allYQXVVM0JsYm1ScGJtZERZWEJXWVhWc2RDNXdZWGxmWVhOaFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjR0Y1WDJGellUb0tJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRveU16a0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPakkxTVFvZ0lDQWdMeThnYm1GMGFYWmxYMkZ0YjNWdWRDQTlJR0Z0YjNWdWRDNXVZWFJwZG1VS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPakkxTWdvZ0lDQWdMeThnWVdkbGJuUmZZV1JrY2lBZ0lDQTlJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qSTFOQW9nSUNBZ0x5OGdZWE56WlhKMElHNWhkR2wyWlY5aGJXOTFiblFnUGlCVlNXNTBOalFvTUNrc0lDSkJiVzkxYm5RZ2JYVnpkQ0JpWlNBK0lEQWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFRnRiM1Z1ZENCdGRYTjBJR0psSUQ0Z01Bb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pJMU5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc1aGRHbDJaVjloYlc5MWJuUWdQRDBnYzJWc1ppNW5iRzlpWVd4ZmJXRjRYMkZ6WVY5d1pYSmZkSGh1TG5aaGJIVmxMQ0FpUlhoalpXVmtjeUJ0WVhoZllYTmhYM0JsY2w5MGVHNGlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVoxOXRZWGhmWVhOaElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWRzYjJKaGJGOXRZWGhmWVhOaFgzQmxjbDkwZUc0Z1pYaHBjM1J6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnUlhoalpXVmtjeUJ0WVhoZllYTmhYM0JsY2w5MGVHNEtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRveU5UY3RNalU0Q2lBZ0lDQXZMeUFqSUVGblpXNTBJRzExYzNRZ1ltVWdjbVZuYVhOMFpYSmxaQ0JoYm1RZ1pXNWhZbXhsWkNBb2JtOGdaR0ZwYkhrZ1kyRndJR0Z3Y0d4cFpXUWdkRzhnUVZOQklPS0FsQ0J6WlhCaGNtRjBaU0JqYjI1alpYSnVLUW9nSUNBZ0x5OGdZWE56WlhKMElHRm5aVzUwWDJGa1pISWdhVzRnYzJWc1ppNWhaMlZ1ZEhNc0lDSkJaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQ0lLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGcyTVRZM05XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPakkxT1FvZ0lDQWdMeThnWTJabklEMGdjMlZzWmk1aFoyVnVkSE5iWVdkbGJuUmZZV1JrY2wwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG95TmpBS0lDQWdJQzh2SUdGemMyVnlkQ0JqWm1jdVpXNWhZbXhsWkM1dVlYUnBkbVVnUFQwZ1ZVbHVkRFkwS0RFcExDQWlRV2RsYm5RZ2FYTWdjM1Z6Y0dWdVpHVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWjJWdWRDQnBjeUJ6ZFhOd1pXNWtaV1FLSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3lOaklLSUNBZ0lDOHZJR2xtSUhObGJHWXVZV3hzYjNkc2FYTjBYMlZ1WVdKc1pXUXVkbUZzZFdVZ1BUMGdWVWx1ZERZMEtERXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltRnNYMlZ1WVdKc1pXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVd4c2IzZHNhWE4wWDJWdVlXSnNaV1FnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUhCaGVWOWhjMkZmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk1qWXpDaUFnSUNBdkx5QmhjM05sY25RZ2NtVmpaV2wyWlhJZ2FXNGdjMlZzWmk1eVpXTnBjR2xsYm5SekxDQWlVbVZqYVhCcFpXNTBJRzV2ZENCcGJpQmhiR3h2ZDJ4cGMzUWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROekkyTXpWbUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJTWldOcGNHbGxiblFnYm05MElHbHVJR0ZzYkc5M2JHbHpkQW9LY0dGNVgyRnpZVjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk1qWTFDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM0JoYVdSZllYTmhMblpoYkhWbElEMGdjMlZzWmk1MGIzUmhiRjl3WVdsa1gyRnpZUzUyWVd4MVpTQXJJRzVoZEdsMlpWOWhiVzkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpZEc5MFlXeGZZWE5oSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDNCaGFXUmZZWE5oSUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdLd29nSUNBZ1lubDBaV01nTVRBZ0x5OGdJblJ2ZEdGc1gyRnpZU0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNalkyQ2lBZ0lDQXZMeUJ6Wld4bUxuUjRYMk52ZFc1MExuWmhiSFZsSUNBZ0lDQWdJRDBnYzJWc1ppNTBlRjlqYjNWdWRDNTJZV3gxWlNBcklGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SNFgyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUjRYMk52ZFc1MElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUjRYMk52ZFc1MElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRveU5qZ3RNamMwQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxQlkyTnZkVzUwS0hKbFkyVnBkbVZ5TG1KNWRHVnpLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlibUYwYVhabFgyRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQnViM1JsUFc1dmRHVXVZbmwwWlhNc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFVkc2IySmhiQzV0YVc1ZmRIaHVYMlpsWlN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3lOek1LSUNBZ0lDOHZJR1psWlQxSGJHOWlZV3d1YldsdVgzUjRibDltWldVc0NpQWdJQ0JuYkc5aVlXd2dUV2x1VkhodVJtVmxDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk1qY3dDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxQlkyTnZkVzUwS0hKbFkyVnBkbVZ5TG1KNWRHVnpLU3dLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1pHbG5JRFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FXUmtjbVZ6Y3lCc1pXNW5kR2dnYVhNZ016SWdZbmwwWlhNS0lDQWdJR1JwWnlBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUU1dmRHVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdScFp5QTFDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qSTJPQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPakkyT0MweU56UUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdGemMyVjBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVUZqWTI5MWJuUW9jbVZqWldsMlpYSXVZbmwwWlhNcExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxdVlYUnBkbVZmWVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUc1dmRHVTlibTkwWlM1aWVYUmxjeXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlSMnh2WW1Gc0xtMXBibDkwZUc1ZlptVmxMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRveU16a0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE53Wlc1a2FXNW5YMk5oY0M1VGNHVnVaR2x1WjBOaGNGWmhkV3gwTG1Ga1pGOWhaMlZ1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRmtaRjloWjJWdWREb0tJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRveU56Z0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk1qa3hDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtOTNibVZ5TG5aaGJIVmxMQ0FpVDI1c2VTQnZkMjVsY2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J2ZDI1bGNnb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pJNU5nb2dJQ0FnTHk4Z1pHRjVYMkoxWTJ0bGRDQWdQU0JoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0F2THlCVlNXNTBOalFvT0RZME1EQXBLU3dLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbHVkR01nTkNBdkx5QTROalF3TUFvZ0lDQWdMd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qSTVNd29nSUNBZ0x5OGdaVzVoWW14bFpDQWdJQ0FnUFNCaGNtTTBMbFZKYm5RMk5DZ3hLU3dLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNUW9nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qSTVNaTB5T1RnS0lDQWdJQzh2SUhObGJHWXVZV2RsYm5SelcyRm5aVzUwWFNBOUlFRm5aVzUwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUdWdVlXSnNaV1FnSUNBZ0lEMGdZWEpqTkM1VlNXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lDQWdiV0Y0WDNCbGNsOTBlRzRnUFNCdFlYaGZjR1Z5WDNSNGJpd0tJQ0FnSUM4dklDQWdJQ0JrWVdsc2VWOWpZWEFnSUNBOUlHUmhhV3g1WDJOaGNDd0tJQ0FnSUM4dklDQWdJQ0JrWVhsZlluVmphMlYwSUNBOUlHRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lDOHZJRlZKYm5RMk5DZzROalF3TUNrcExBb2dJQ0FnTHk4Z0lDQWdJR1JoZVY5emNHVnVkQ0FnSUQwZ1lYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qSTVOd29nSUNBZ0x5OGdaR0Y1WDNOd1pXNTBJQ0FnUFNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk1qa3lMVEk1T0FvZ0lDQWdMeThnYzJWc1ppNWhaMlZ1ZEhOYllXZGxiblJkSUQwZ1FXZGxiblJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnWlc1aFlteGxaQ0FnSUNBZ1BTQmhjbU0wTGxWSmJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ0lDQnRZWGhmY0dWeVgzUjRiaUE5SUcxaGVGOXdaWEpmZEhodUxBb2dJQ0FnTHk4Z0lDQWdJR1JoYVd4NVgyTmhjQ0FnSUQwZ1pHRnBiSGxmWTJGd0xBb2dJQ0FnTHk4Z0lDQWdJR1JoZVY5aWRXTnJaWFFnSUQwZ1lYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBZ0x5OGdWVWx1ZERZMEtEZzJOREF3S1Nrc0NpQWdJQ0F2THlBZ0lDQWdaR0Y1WDNOd1pXNTBJQ0FnUFNCaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPakk1TWdvZ0lDQWdMeThnYzJWc1ppNWhaMlZ1ZEhOYllXZGxiblJkSUQwZ1FXZGxiblJEYjI1bWFXY29DaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROakUyTnpWbUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPakk1TWkweU9UZ0tJQ0FnSUM4dklITmxiR1l1WVdkbGJuUnpXMkZuWlc1MFhTQTlJRUZuWlc1MFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lHVnVZV0pzWldRZ0lDQWdJRDBnWVhKak5DNVZTVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnYldGNFgzQmxjbDkwZUc0Z1BTQnRZWGhmY0dWeVgzUjRiaXdLSUNBZ0lDOHZJQ0FnSUNCa1lXbHNlVjlqWVhBZ0lDQTlJR1JoYVd4NVgyTmhjQ3dLSUNBZ0lDOHZJQ0FnSUNCa1lYbGZZblZqYTJWMElDQTlJR0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJQzh2SUZWSmJuUTJOQ2c0TmpRd01Da3BMQW9nSUNBZ0x5OGdJQ0FnSUdSaGVWOXpjR1Z1ZENBZ0lEMGdZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk1qYzRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6Y0dWdVpHbHVaMTlqWVhBdVUzQmxibVJwYm1kRFlYQldZWFZzZEM1MWNHUmhkR1ZmWVdkbGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVmZZV2RsYm5RNkNpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TXpBd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pNd09Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1dmQyNWxjaTUyWVd4MVpTd2dJazl1YkhrZ2IzZHVaWElpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWIzZHVaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWIzZHVaWElnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2diM2R1WlhJS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG96TURrS0lDQWdJQzh2SUdGemMyVnlkQ0JoWjJWdWRDQnBiaUJ6Wld4bUxtRm5aVzUwY3l3Z0lrRm5aVzUwSUc1dmRDQnlaV2RwYzNSbGNtVmtJZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFl4TmpjMVpnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXZGxiblFnYm05MElISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvek1UQUtJQ0FnSUM4dklHTm1aeUE5SUhObGJHWXVZV2RsYm5SelcyRm5aVzUwWFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNekV4Q2lBZ0lDQXZMeUJqWm1jdWJXRjRYM0JsY2w5MGVHNGdQU0J0WVhoZmNHVnlYM1I0YmdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCeVpYQnNZV05sTWlBNENpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TXpFeUNpQWdJQ0F2THlCalptY3VaR0ZwYkhsZlkyRndJQ0FnUFNCa1lXbHNlVjlqWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NtVndiR0ZqWlRJZ01UWUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvek1UTUtJQ0FnSUM4dklITmxiR1l1WVdkbGJuUnpXMkZuWlc1MFhTQTlJR05tWnk1amIzQjVLQ2tLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG96TURBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITndaVzVrYVc1blgyTmhjQzVUY0dWdVpHbHVaME5oY0ZaaGRXeDBMbk4xYzNCbGJtUmZZV2RsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpkWE53Wlc1a1gyRm5aVzUwT2dvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPak14TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvek1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdWIzZHVaWEl1ZG1Gc2RXVXNJQ0pQYm14NUlHOTNibVZ5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOTNibVZ5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJRzkzYm1WeUNpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TXpFNUNpQWdJQ0F2THlCaGMzTmxjblFnWVdkbGJuUWdhVzRnYzJWc1ppNWhaMlZ1ZEhNc0lDSkJaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQ0lLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGcyTVRZM05XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPak15TUMwek1qSUtJQ0FnSUM4dklHTm1aeUE5SUhObGJHWXVZV2RsYm5SelcyRm5aVzUwWFM1amIzQjVLQ2tLSUNBZ0lDOHZJR05tWnk1bGJtRmliR1ZrSUQwZ1lYSmpOQzVWU1c1ME5qUW9NQ2tLSUNBZ0lDOHZJSE5sYkdZdVlXZGxiblJ6VzJGblpXNTBYU0E5SUdObVp5NWpiM0I1S0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNekl4Q2lBZ0lDQXZMeUJqWm1jdVpXNWhZbXhsWkNBOUlHRnlZelF1VlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qTXlNQzB6TWpJS0lDQWdJQzh2SUdObVp5QTlJSE5sYkdZdVlXZGxiblJ6VzJGblpXNTBYUzVqYjNCNUtDa0tJQ0FnSUM4dklHTm1aeTVsYm1GaWJHVmtJRDBnWVhKak5DNVZTVzUwTmpRb01Da0tJQ0FnSUM4dklITmxiR1l1WVdkbGJuUnpXMkZuWlc1MFhTQTlJR05tWnk1amIzQjVLQ2tLSUNBZ0lHSnZlRjl5WlhCc1lXTmxDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk16RTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6Y0dWdVpHbHVaMTlqWVhBdVUzQmxibVJwYm1kRFlYQldZWFZzZEM1eVpYTjFiV1ZmWVdkbGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlhOMWJXVmZZV2RsYm5RNkNpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TXpJMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qTXlOd29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNXZkMjVsY2k1MllXeDFaU3dnSWs5dWJIa2diM2R1WlhJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWliM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnYjNkdVpYSUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvek1qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCaFoyVnVkQ0JwYmlCelpXeG1MbUZuWlc1MGN5d2dJa0ZuWlc1MElHNXZkQ0J5WldkcGMzUmxjbVZrSWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURZeE5qYzFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVGblpXNTBJRzV2ZENCeVpXZHBjM1JsY21Wa0NpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TXpJNUxUTXpNUW9nSUNBZ0x5OGdZMlpuSUQwZ2MyVnNaaTVoWjJWdWRITmJZV2RsYm5SZExtTnZjSGtvS1FvZ0lDQWdMeThnWTJabkxtVnVZV0pzWldRZ1BTQmhjbU0wTGxWSmJuUTJOQ2d4S1FvZ0lDQWdMeThnYzJWc1ppNWhaMlZ1ZEhOYllXZGxiblJkSUQwZ1kyWm5MbU52Y0hrb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG96TXpBS0lDQWdJQzh2SUdObVp5NWxibUZpYkdWa0lEMGdZWEpqTkM1VlNXNTBOalFvTVNrS0lDQWdJR0o1ZEdWaklERXlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TVFvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPak15T1Mwek16RUtJQ0FnSUM4dklHTm1aeUE5SUhObGJHWXVZV2RsYm5SelcyRm5aVzUwWFM1amIzQjVLQ2tLSUNBZ0lDOHZJR05tWnk1bGJtRmliR1ZrSUQwZ1lYSmpOQzVWU1c1ME5qUW9NU2tLSUNBZ0lDOHZJSE5sYkdZdVlXZGxiblJ6VzJGblpXNTBYU0E5SUdObVp5NWpiM0I1S0NrS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNekkwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemNHVnVaR2x1WjE5allYQXVVM0JsYm1ScGJtZERZWEJXWVhWc2RDNXlaVzF2ZG1WZllXZGxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXMXZkbVZmWVdkbGJuUTZDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk16TXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPak16TmdvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTV2ZDI1bGNpNTJZV3gxWlN3Z0lrOXViSGtnYjNkdVpYSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNkdVpYSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2IzZHVaWElLSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3pNemNLSUNBZ0lDOHZJR2xtSUdGblpXNTBJR2x1SUhObGJHWXVZV2RsYm5Sek9nb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEWXhOamMxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2djbVZ0YjNabFgyRm5aVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qTXpPQW9nSUNBZ0x5OGdaR1ZzSUhObGJHWXVZV2RsYm5SelcyRm5aVzUwWFFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0NuSmxiVzkyWlY5aFoyVnVkRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk16TXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6Y0dWdVpHbHVaMTlqWVhBdVUzQmxibVJwYm1kRFlYQldZWFZzZEM1aFpHUmZjbVZqYVhCcFpXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVdSa1gzSmxZMmx3YVdWdWREb0tJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvek5ESUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk16VTFDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtOTNibVZ5TG5aaGJIVmxMQ0FpVDI1c2VTQnZkMjVsY2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J2ZDI1bGNnb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pNMU9Rb2dJQ0FnTHk4Z1pHRjVYMkoxWTJ0bGRDQWdQU0JoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0F2THlCVlNXNTBOalFvT0RZME1EQXBLU3dLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbHVkR01nTkNBdkx5QTROalF3TUFvZ0lDQWdMd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qTTFOaTB6TmpFS0lDQWdJQzh2SUhObGJHWXVjbVZqYVhCcFpXNTBjMXR5WldOcGNHbGxiblJkSUQwZ1VtVmphWEJwWlc1MFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lHMWhlRjl3WlhKZmRIaHVJRDBnYldGNFgzQmxjbDkwZUc0c0NpQWdJQ0F2THlBZ0lDQWdaR0ZwYkhsZlkyRndJQ0FnUFNCa1lXbHNlVjlqWVhBc0NpQWdJQ0F2THlBZ0lDQWdaR0Y1WDJKMVkydGxkQ0FnUFNCaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBdkx5QlZTVzUwTmpRb09EWTBNREFwS1N3S0lDQWdJQzh2SUNBZ0lDQmtZWGxmYzNCbGJuUWdJQ0E5SUdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvek5qQUtJQ0FnSUM4dklHUmhlVjl6Y0dWdWRDQWdJRDBnWVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pNMU5pMHpOakVLSUNBZ0lDOHZJSE5sYkdZdWNtVmphWEJwWlc1MGMxdHlaV05wY0dsbGJuUmRJRDBnVW1WamFYQnBaVzUwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUcxaGVGOXdaWEpmZEhodUlEMGdiV0Y0WDNCbGNsOTBlRzRzQ2lBZ0lDQXZMeUFnSUNBZ1pHRnBiSGxmWTJGd0lDQWdQU0JrWVdsc2VWOWpZWEFzQ2lBZ0lDQXZMeUFnSUNBZ1pHRjVYMkoxWTJ0bGRDQWdQU0JoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0F2THlCVlNXNTBOalFvT0RZME1EQXBLU3dLSUNBZ0lDOHZJQ0FnSUNCa1lYbGZjM0JsYm5RZ0lDQTlJR0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk16VTJDaUFnSUNBdkx5QnpaV3htTG5KbFkybHdhV1Z1ZEhOYmNtVmphWEJwWlc1MFhTQTlJRkpsWTJsd2FXVnVkRU52Ym1acFp5Z0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzNNall6TldZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNelUyTFRNMk1Rb2dJQ0FnTHk4Z2MyVnNaaTV5WldOcGNHbGxiblJ6VzNKbFkybHdhV1Z1ZEYwZ1BTQlNaV05wY0dsbGJuUkRiMjVtYVdjb0NpQWdJQ0F2THlBZ0lDQWdiV0Y0WDNCbGNsOTBlRzRnUFNCdFlYaGZjR1Z5WDNSNGJpd0tJQ0FnSUM4dklDQWdJQ0JrWVdsc2VWOWpZWEFnSUNBOUlHUmhhV3g1WDJOaGNDd0tJQ0FnSUM4dklDQWdJQ0JrWVhsZlluVmphMlYwSUNBOUlHRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lDOHZJRlZKYm5RMk5DZzROalF3TUNrcExBb2dJQ0FnTHk4Z0lDQWdJR1JoZVY5emNHVnVkQ0FnSUQwZ1lYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TXpReUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpjR1Z1WkdsdVoxOWpZWEF1VTNCbGJtUnBibWREWVhCV1lYVnNkQzUxY0dSaGRHVmZjbVZqYVhCcFpXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxYM0psWTJsd2FXVnVkRG9LSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3pOak1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNemN4Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbTkzYm1WeUxuWmhiSFZsTENBaVQyNXNlU0J2ZDI1bGNpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCdmQyNWxjZ29nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qTTNNZ29nSUNBZ0x5OGdZWE56WlhKMElISmxZMmx3YVdWdWRDQnBiaUJ6Wld4bUxuSmxZMmx3YVdWdWRITXNJQ0pTWldOcGNHbGxiblFnYm05MElISmxaMmx6ZEdWeVpXUWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROekkyTXpWbUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCU1pXTnBjR2xsYm5RZ2JtOTBJSEpsWjJsemRHVnlaV1FLSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3pOek1LSUNBZ0lDOHZJR05tWnlBOUlITmxiR1l1Y21WamFYQnBaVzUwYzF0eVpXTnBjR2xsYm5SZExtTnZjSGtvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG96TnpRS0lDQWdJQzh2SUdObVp5NXRZWGhmY0dWeVgzUjRiaUE5SUcxaGVGOXdaWEpmZEhodUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvek56VUtJQ0FnSUM4dklHTm1aeTVrWVdsc2VWOWpZWEFnSUNBOUlHUmhhV3g1WDJOaGNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnlaWEJzWVdObE1pQTRDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk16YzJDaUFnSUNBdkx5QnpaV3htTG5KbFkybHdhV1Z1ZEhOYmNtVmphWEJwWlc1MFhTQTlJR05tWnk1amIzQjVLQ2tLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG96TmpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITndaVzVrYVc1blgyTmhjQzVUY0dWdVpHbHVaME5oY0ZaaGRXeDBMbkpsYlc5MlpWOXlaV05wY0dsbGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlcxdmRtVmZjbVZqYVhCcFpXNTBPZ29nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qTTNPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG96T0RFS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1YjNkdVpYSXVkbUZzZFdVc0lDSlBibXg1SUc5M2JtVnlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW05M2JtVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG05M2JtVnlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHOTNibVZ5Q2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNemd5Q2lBZ0lDQXZMeUJwWmlCeVpXTnBjR2xsYm5RZ2FXNGdjMlZzWmk1eVpXTnBjR2xsYm5Sek9nb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEY3lOak0xWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2djbVZ0YjNabFgzSmxZMmx3YVdWdWRGOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG96T0RNS0lDQWdJQzh2SUdSbGJDQnpaV3htTG5KbFkybHdhV1Z1ZEhOYmNtVmphWEJwWlc1MFhRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtDbkpsYlc5MlpWOXlaV05wY0dsbGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pNM09Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjM0JsYm1ScGJtZGZZMkZ3TGxOd1pXNWthVzVuUTJGd1ZtRjFiSFF1ZFhCa1lYUmxYMmRzYjJKaGJGOXNhVzFwZEhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFjR1JoZEdWZloyeHZZbUZzWDJ4cGJXbDBjem9LSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUb3pPRGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pNNU5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1dmQyNWxjaTUyWVd4MVpTd2dJazl1YkhrZ2IzZHVaWElpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWIzZHVaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWIzZHVaWElnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2diM2R1WlhJS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG96T1RZS0lDQWdJQzh2SUhObGJHWXVaMnh2WW1Gc1gyMWhlRjl3WlhKZmRIaHVMblpoYkhWbElDQWdJRDBnYldGNFgzQmxjbDkwZUc0dWJtRjBhWFpsQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltZGZiV0Y0WDNSNGJpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk16azNDaUFnSUNBdkx5QnpaV3htTG1kc2IySmhiRjlrWVdsc2VWOWpZWEF1ZG1Gc2RXVWdJQ0FnSUNBOUlHUmhhV3g1WDJOaGNDNXVZWFJwZG1VS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1kZlpHRnBiSGxmWTJGd0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvek9UZ0tJQ0FnSUM4dklITmxiR1l1WjJ4dlltRnNYMjFoZUY5aGMyRmZjR1Z5WDNSNGJpNTJZV3gxWlNBOUlHMWhlRjloYzJGZmNHVnlYM1I0Ymk1dVlYUnBkbVVLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbWRmYldGNFgyRnpZU0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZNemczQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemNHVnVaR2x1WjE5allYQXVVM0JsYm1ScGJtZERZWEJXWVhWc2RDNXpaWFJmWVd4c2IzZHNhWE4wWDJWdVlXSnNaV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUmZZV3hzYjNkc2FYTjBYMlZ1WVdKc1pXUTZDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk5EQXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvME1ETUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdWIzZHVaWEl1ZG1Gc2RXVXNJQ0pQYm14NUlHOTNibVZ5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOTNibVZ5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJRzkzYm1WeUNpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TkRBMENpQWdJQ0F2THlCelpXeG1MbUZzYkc5M2JHbHpkRjlsYm1GaWJHVmtMblpoYkhWbElEMGdaVzVoWW14bFpDNXVZWFJwZG1VS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW1Gc1gyVnVZV0pzWldRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pRd01Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjM0JsYm1ScGJtZGZZMkZ3TGxOd1pXNWthVzVuUTJGd1ZtRjFiSFF1YjNkdVpYSmZkMmwwYUdSeVlYZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B2ZDI1bGNsOTNhWFJvWkhKaGR6b0tJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvME1EZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG8wTVRFS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1YjNkdVpYSXVkbUZzZFdVc0lDSlBibXg1SUc5M2JtVnlJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW05M2JtVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG05M2JtVnlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHOTNibVZ5Q2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZOREV5TFRReE5nb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFVGalkyOTFiblFvY21WalpXbDJaWEl1WW5sMFpYTXBMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFoYlc5MWJuUXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxSGJHOWlZV3d1YldsdVgzUjRibDltWldVc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZOREUxQ2lBZ0lDQXZMeUJtWldVOVIyeHZZbUZzTG0xcGJsOTBlRzVmWm1WbExBb2dJQ0FnWjJ4dlltRnNJRTFwYmxSNGJrWmxaUW9nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qUXhNd29nSUNBZ0x5OGdjbVZqWldsMlpYSTlRV05qYjNWdWRDaHlaV05sYVhabGNpNWllWFJsY3lrc0NpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlpHUnlaWE56SUd4bGJtZDBhQ0JwY3lBek1pQmllWFJsY3dvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPalF4TkFvZ0lDQWdMeThnWVcxdmRXNTBQV0Z0YjNWdWRDNXVZWFJwZG1Vc0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pReE1nb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvME1USXROREUyQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlRV05qYjNWdWRDaHlaV05sYVhabGNpNWllWFJsY3lrc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXRnRiM1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVWRzYjJKaGJDNXRhVzVmZEhodVgyWmxaU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk5EQTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6Y0dWdVpHbHVaMTlqWVhBdVUzQmxibVJwYm1kRFlYQldZWFZzZEM1dmQyNWxjbDkzYVhSb1pISmhkMTloYzJGYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHZkMjVsY2w5M2FYUm9aSEpoZDE5aGMyRTZDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk5ERTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk5ESXpDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtOTNibVZ5TG5aaGJIVmxMQ0FpVDI1c2VTQnZkMjVsY2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J2ZDI1bGNnb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pReU5DMDBNamtLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVGalkyOTFiblFvY21WalpXbDJaWEl1WW5sMFpYTXBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMWhiVzkxYm5RdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFIYkc5aVlXd3ViV2x1WDNSNGJsOW1aV1VzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk5ESTRDaUFnSUNBdkx5Qm1aV1U5UjJ4dlltRnNMbTFwYmw5MGVHNWZabVZsTEFvZ0lDQWdaMnh2WW1Gc0lFMXBibFI0YmtabFpRb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pReU5nb2dJQ0FnTHk4Z1lYTnpaWFJmY21WalpXbDJaWEk5UVdOamIzVnVkQ2h5WldObGFYWmxjaTVpZVhSbGN5a3NDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaR1J5WlhOeklHeGxibWQwYUNCcGN5QXpNaUJpZVhSbGN3b2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pReU53b2dJQ0FnTHk4Z1lYTnpaWFJmWVcxdmRXNTBQV0Z0YjNWdWRDNXVZWFJwZG1Vc0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JZWm1WeVFYTnpaWFFLSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUbzBNalFLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUJoZUdabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG8wTWpRdE5ESTVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFCWTJOdmRXNTBLSEpsWTJWcGRtVnlMbUo1ZEdWektTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROVlXMXZkVzUwTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlSMnh2WW1Gc0xtMXBibDkwZUc1ZlptVmxMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvME1UZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE53Wlc1a2FXNW5YMk5oY0M1VGNHVnVaR2x1WjBOaGNGWmhkV3gwTG05d2RGOXBibDloYzJGYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHZjSFJmYVc1ZllYTmhPZ29nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qUXpNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk5ETTBDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtOTNibVZ5TG5aaGJIVmxMQ0FpVDI1c2VTQnZkMjVsY2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J2ZDI1bGNnb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pRek5TMDBOREFLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlSMnh2WW1Gc0xtMXBibDkwZUc1ZlptVmxMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pRek9Rb2dJQ0FnTHk4Z1ptVmxQVWRzYjJKaGJDNXRhVzVmZEhodVgyWmxaU3dLSUNBZ0lHZHNiMkpoYkNCTmFXNVVlRzVHWldVS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG8wTXpjS0lDQWdJQzh2SUdGemMyVjBYM0psWTJWcGRtVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qUXpPQW9nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZORE0xQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TkRNMUxUUTBNQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVlYTnpaWFFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMUhiRzlpWVd3dWJXbHVYM1I0Ymw5bVpXVXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pRek1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjM0JsYm1ScGJtZGZZMkZ3TGxOd1pXNWthVzVuUTJGd1ZtRjFiSFF1WjJWMFgyZHNiMkpoYkY5emRHRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOW5iRzlpWVd4ZmMzUmhkR1U2Q2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZORFUyQ2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MbWRzYjJKaGJGOXRZWGhmY0dWeVgzUjRiaTUyWVd4MVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVoxOXRZWGhmZEhodUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbWRzYjJKaGJGOXRZWGhmY0dWeVgzUjRiaUJsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvME5UY0tJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE5sYkdZdVoyeHZZbUZzWDJSaGFXeDVYMk5oY0M1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlaMTlrWVdsc2VWOWpZWEFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVoyeHZZbUZzWDJSaGFXeDVYMk5oY0NCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE53Wlc1a2FXNW5YMk5oY0M1d2VUbzBOVGdLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVaMnh2WW1Gc1gyMWhlRjloYzJGZmNHVnlYM1I0Ymk1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlaMTl0WVhoZllYTmhJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1kc2IySmhiRjl0WVhoZllYTmhYM0JsY2w5MGVHNGdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TkRVNUNpQWdJQ0F2THlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG1Gc2JHOTNiR2x6ZEY5bGJtRmliR1ZrTG5aaGJIVmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSmhiRjlsYm1GaWJHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Gc2JHOTNiR2x6ZEY5bGJtRmliR1ZrSUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjM0JsYm1ScGJtZGZZMkZ3TG5CNU9qUTJNQW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBiM1JoYkY5d1lXbGtMblpoYkhWbEtTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKMGIzUmhiRjl3WVdsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzQmhhV1FnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk5EWXhDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDNCaGFXUmZZWE5oTG5aaGJIVmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlkRzkwWVd4ZllYTmhJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYM0JoYVdSZllYTmhJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pRMk1nb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGVGOWpiM1Z1ZEM1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkSGhmWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEhoZlkyOTFiblFnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk5EVTFMVFEyTXdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZIVndiR1VvS0FvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLSE5sYkdZdVoyeHZZbUZzWDIxaGVGOXdaWEpmZEhodUxuWmhiSFZsS1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtZHNiMkpoYkY5a1lXbHNlVjlqWVhBdWRtRnNkV1VwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLSE5sYkdZdVoyeHZZbUZzWDIxaGVGOWhjMkZmY0dWeVgzUjRiaTUyWVd4MVpTa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTVoYkd4dmQyeHBjM1JmWlc1aFlteGxaQzUyWVd4MVpTa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjNSaGJGOXdZV2xrTG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmRHRnNYM0JoYVdSZllYTmhMblpoYkhWbEtTd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MblI0WDJOdmRXNTBMblpoYkhWbEtTd0tJQ0FnSUM4dklDa3BDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TkRRMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MzQmxibVJwYm1kZlkyRndMbE53Wlc1a2FXNW5RMkZ3Vm1GMWJIUXVaMlYwWDJGblpXNTBYM04wWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDJGblpXNTBYM04wWVhSbE9nb2dJQ0FnTHk4Z2MzQmxibVJwYm1kZlkyRndMbkI1T2pRMk5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITndaVzVrYVc1blgyTmhjQzV3ZVRvME5qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCaFoyVnVkQ0JwYmlCelpXeG1MbUZuWlc1MGN5d2dJa0ZuWlc1MElHNXZkQ0J5WldkcGMzUmxjbVZrSWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURZeE5qYzFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVGblpXNTBJRzV2ZENCeVpXZHBjM1JsY21Wa0NpQWdJQ0F2THlCemNHVnVaR2x1WjE5allYQXVjSGs2TkRZNUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWhaMlZ1ZEhOYllXZGxiblJkTG1OdmNIa29LUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZORFkxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWaklERXhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzNCbGJtUnBibWRmWTJGd0xsTndaVzVrYVc1blEyRndWbUYxYkhRdVoyVjBYM0psWTJsd2FXVnVkRjl6ZEdGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5eVpXTnBjR2xsYm5SZmMzUmhkR1U2Q2lBZ0lDQXZMeUJ6Y0dWdVpHbHVaMTlqWVhBdWNIazZORGN4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzNCbGJtUnBibWRmWTJGd0xuQjVPalEzTkFvZ0lDQWdMeThnWVhOelpYSjBJSEpsWTJsd2FXVnVkQ0JwYmlCelpXeG1MbkpsWTJsd2FXVnVkSE1zSUNKU1pXTnBjR2xsYm5RZ2JtOTBJSEpsWjJsemRHVnlaV1FpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TnpJMk16Vm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVW1WamFYQnBaVzUwSUc1dmRDQnlaV2RwYzNSbGNtVmtDaUFnSUNBdkx5QnpjR1Z1WkdsdVoxOWpZWEF1Y0hrNk5EYzFDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTV5WldOcGNHbGxiblJ6VzNKbFkybHdhV1Z1ZEYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOd1pXNWthVzVuWDJOaGNDNXdlVG8wTnpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFGQUFFSUlJQ2pCU1lOQlc5M2JtVnlBMkZuWHdOeVkxOElkSGhmWTI5MWJuUUpaMTl0WVhoZmRIaHVDMmRmWkdGcGJIbGZZMkZ3Q21Gc1gyVnVZV0pzWldRSUFBQUFBQUFBQUFBSloxOXRZWGhmWVhOaENuUnZkR0ZzWDNCaGFXUUpkRzkwWVd4ZllYTmhCQlVmZkhVSUFBQUFBQUFBQUFFeEdSUkVNUmhCQUlhQ0VnUklSODF4Qk93T1RMOEVpWFRaSVFRdERjd1JCSzdqVis4RW9IQ2tjZ1Q1WmtJa0JNYVYzTjRFVUxLYUpBUzJGQSsrQkZteVd6Z0VFeC96TEFRakRlVlNCR1RkNXQ4RWtjQ1VXUVRWTWhuVEJFQVIvN3dFNExiM25EWWFBSTRTQUZrQnVnSk5Bb2dDdndMZEF2c0RHZ05RQTRjRHBnUGFBL0VFSVFSZkJJWUV5UVRpQUlBRUwvVjA2VFlhQUk0QkFBRUFOaG9CU1JVa0VrUTJHZ0pKRlNRU1JEWWFBMGtWSkJKRU5ob0VTUlVrRWtRb01RQm5Ud01YSndSTVowOENGeWNGVEdkTUZ5Y0lUR2NYSndaTVp5Y0pJbWNuQ2lKbkt5Sm5JME9BQURZYUFVa1ZTU1VTUkRZYUFra1ZKQkpFTmhvRFNVNENTU0paZ1FJSVRCVVNSQmRKTVFCTVJDbE1VRWNDdlVVQlJMNUlSd0lpV3lNU1JDUmJTU0luQkdWTVRnSkVRUUVVU3dGTEJROUVNZ2NoQkFwSlJRcExBNEVZV3cxQkFBNUxDQlpMQTB4Y0dDY0hYQ0JGQTBzQ2dSQmJTVVVESWljRlpVeEZBMFJCQU5oTEFVc0RTU1ZiU3djSVNVOEREa1FXWENCTEJFeS9JaWNHWlVRakVrRUFDQ3BMQ0ZDOVJRRkVLa3NJVUVsRkJiMUZBVUVBYUVzRHZreEpUZ0pGQlVRaVcwbEZBeUluQkdWTVJRTkVRUUNGU3dGTEJROUVNZ2NoQkFwSlJRcExBNEVRV3cxQkFBNUxDQlpMQTB4Y0VDY0hYQmhGQTBzQ0pGdEpSUU1pSndWbFRFVURSRUVBU2tzQlN3TkpnUmhiU3djSVNVOEREa1FXWEJoTEJFeS9JaWNKWlVSTEJVbE9BZ2duQ1V4bklpdGxSQ01JSzB4bnNUSUFKVXNKRWtSTEI3SUZUTElJU3dpeUJ5T3lFTElCc3lORFNVTC90RWxDLzNsSlF2OG1TVUwrNmpZYUFVa1ZTU1VTUkRZYUFra1ZKQkpFRnpZYUEwa1ZKQkpFTmhvRVNVNENTU0paZ1FJSVRCVVNSQmRKTVFCTEFVUWlKd2hsUkU4Q0QwUXBURkJKdlVVQlJMNUlJbHNqRWtRaUp3WmxSQ01TUVFBSUtrc0ZVTDFGQVVRaUp3cGxSRXNCU1U0Q0NDY0tUR2NpSzJWRUl3Z3JUR2V4TWdBbFN3WVNSRXNEc2dWTXNoSkxCYklVU3dPeUVZRUVzaEN5QWJNalF6WWFBVWtWSlJKRU5ob0NTUlVrRWtRMkdnTkpGU1FTUkRFQUlpaGxSQkpFTWdjaEJBb1dKd3hQQTFCUEFsQk1VQ2NIVUNsUEFsQk12eU5ETmhvQlNSVWxFa1EyR2dKSkZTUVNSRFlhQTBrVkpCSkVNUUFpS0dWRUVrUXBUd05RU2IxRkFVUkp2a2hQQTF3SVR3SmNFTDhqUXpZYUFVa1ZKUkpFTVFBaUtHVkVFa1FwVEZCSnZVVUJSQ0luQjdzalF6WWFBVWtWSlJKRU1RQWlLR1ZFRWtRcFRGQkp2VVVCUkNJbkRMc2pRellhQVVrVkpSSkVNUUFpS0dWRUVrUXBURkJKdlVVQlFRQURTYnhJSTBNMkdnRkpGU1VTUkRZYUFra1ZKQkpFTmhvRFNSVWtFa1F4QUNJb1pVUVNSRElISVFRS0ZrNENVRXhRSndkUUtrOENVRXkvSTBNMkdnRkpGU1VTUkRZYUFra1ZKQkpFTmhvRFNSVWtFa1F4QUNJb1pVUVNSQ3BQQTFCSnZVVUJSRW0rU0U4RFhBQlBBbHdJdnlORE5ob0JTUlVsRWtReEFDSW9aVVFTUkNwTVVFbTlSUUZCQUFOSnZFZ2pRellhQVVrVkpCSkVOaG9DU1JVa0VrUTJHZ05KRlNRU1JERUFJaWhsUkJKRVR3SVhKd1JNWjB3WEp3Vk1aeGNuQ0V4bkkwTTJHZ0ZKRlNRU1JERUFJaWhsUkJKRUZ5Y0dUR2NqUXpZYUFVa1ZTU1VTUkRZYUFra1ZKQkpFTVFBaUtHVkVFa1N4TWdBbFR3TVNSRXdYc2doTXNnY2pzaEN5QWJNalF6WWFBVWtWU1NVU1JEWWFBa2tWSkJKRUZ6WWFBMGtWSkJKRU1RQWlLR1ZFRWtTeE1nQWxUd1FTUkV3WHNoSlBBcklVVExJUmdRU3lFTElCc3lORE5ob0JTUlVrRWtRWE1RQWlLR1ZFRWtTeE1nQXlDaUt5RXJJVVRMSVJnUVN5RUxJQnN5TkRJaWNFWlVRV0lpY0ZaVVFXSWljSVpVUVdJaWNHWlVRV0lpY0paVVFXSWljS1pVUVdJaXRsUkJaUEJrOEdVRThGVUU4RVVFOERVRThDVUV4UUp3dE1VTEFqUXpZYUFVa1ZKUkpFS1V4UVNiMUZBVVMrU0NjTFRGQ3dJME0yR2dGSkZTVVNSQ3BNVUVtOVJRRkV2a2duQzB4UXNDTkQiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
