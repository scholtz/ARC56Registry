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

namespace Arc56.Generated.ShahiTechnovation.Bloopa.Bloopa_bb98907d
{


    //
    // 
    //    On-chain reputation credit protocol for AI agents.
    //
    //    Local state schema:  9 × uint64, 0 × bytes
    //      stake_amount, payment_count, total_repaid, outstanding,
    //      is_defaulted, last_payment_round, daily_drawn,
    //      day_start_round, repay_by_round
    //
    //    Global state schema: 3 × uint64, 1 × bytes
    //      treasury_balance, total_agents, skip_attestation,
    //      protocol_signer (bytes)
    //    
    //
    public class BloopaProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BloopaProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetPositionReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public ulong Field5 { get; set; }

                public ulong Field6 { get; set; }

                public ulong Field7 { get; set; }

                public ulong Field8 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField8.From(Field8);
                    ret.AddRange(vField8.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetPositionReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetPositionReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField7 = vField7.ToValue();
                    if (valueField7 is ulong vField7Value) { ret.Field7 = vField7Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField8.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField8 = vField8.ToValue();
                    if (valueField8 is ulong vField8Value) { ret.Field8 = vField8Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetPositionReturn);
                }
                public bool Equals(GetPositionReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetPositionReturn left, GetPositionReturn right)
                {
                    return EqualityComparer<GetPositionReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetPositionReturn left, GetPositionReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class AgentRegisteredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 137, 53, 175, 157 };
                public const string Signature = "AgentRegistered(address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Agent { get; set; }
                public ulong Stake { get; set; }

                public static AgentRegisteredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AgentRegisteredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAgent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgent = vAgent.ToValue();
                    if (valueAgent is Algorand.Address vAgentValue) { ret.Agent = vAgentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStake = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStake.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStake = vStake.ToValue();
                    if (valueStake is ulong vStakeValue) { ret.Stake = vStakeValue; }
                    return ret;

                }

            }

            public class PaymentRecordedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 194, 83, 95, 165 };
                public const string Signature = "PaymentRecorded(address,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Agent { get; set; }
                public ulong Amount { get; set; }
                public ulong Tier { get; set; }

                public static PaymentRecordedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PaymentRecordedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAgent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgent = vAgent.ToValue();
                    if (valueAgent is Algorand.Address vAgentValue) { ret.Agent = vAgentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTier = vTier.ToValue();
                    if (valueTier is ulong vTierValue) { ret.Tier = vTierValue; }
                    return ret;

                }

            }

            public class CreditDrawnEvent
            {
                public static readonly byte[] Selector = new byte[4] { 42, 100, 13, 145 };
                public const string Signature = "CreditDrawn(address,uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Agent { get; set; }
                public ulong Amount { get; set; }
                public ulong Interest { get; set; }
                public ulong Outstanding { get; set; }

                public static CreditDrawnEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CreditDrawnEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAgent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgent = vAgent.ToValue();
                    if (valueAgent is Algorand.Address vAgentValue) { ret.Agent = vAgentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInterest = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInterest.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInterest = vInterest.ToValue();
                    if (valueInterest is ulong vInterestValue) { ret.Interest = vInterestValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOutstanding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOutstanding.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOutstanding = vOutstanding.ToValue();
                    if (valueOutstanding is ulong vOutstandingValue) { ret.Outstanding = vOutstandingValue; }
                    return ret;

                }

            }

            public class RepaidEvent
            {
                public static readonly byte[] Selector = new byte[4] { 84, 150, 90, 147 };
                public const string Signature = "Repaid(address,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Agent { get; set; }
                public ulong Amount { get; set; }
                public ulong Outstanding { get; set; }

                public static RepaidEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RepaidEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAgent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgent = vAgent.ToValue();
                    if (valueAgent is Algorand.Address vAgentValue) { ret.Agent = vAgentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOutstanding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOutstanding.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOutstanding = vOutstanding.ToValue();
                    if (valueOutstanding is ulong vOutstandingValue) { ret.Outstanding = vOutstandingValue; }
                    return ret;

                }

            }

            public class AgentSlashedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 80, 253, 198, 74 };
                public const string Signature = "AgentSlashed(address,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Agent { get; set; }
                public ulong StakeBurned { get; set; }
                public ulong CallerReward { get; set; }

                public static AgentSlashedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AgentSlashedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAgent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgent = vAgent.ToValue();
                    if (valueAgent is Algorand.Address vAgentValue) { ret.Agent = vAgentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakeBurned = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStakeBurned.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStakeBurned = vStakeBurned.ToValue();
                    if (valueStakeBurned is ulong vStakeBurnedValue) { ret.StakeBurned = vStakeBurnedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCallerReward = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCallerReward.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCallerReward = vCallerReward.ToValue();
                    if (valueCallerReward is ulong vCallerRewardValue) { ret.CallerReward = vCallerRewardValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Register a new agent by staking ALGO.
        ///Preconditions:   - pay.receiver == application address   - pay.amount >= 1_000_000 microALGO (1 ALGO)   - Agent must not already be registered (stake_amount == 0)
        ///Mutates:   - All 9 local state slots initialised for Txn.sender.   - treasury_balance += pay.amount   - total_agents += 1
        ///Emits: AgentRegistered
        ///</summary>
        /// <param name="pay"> </param>
        public async Task Register(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 240, 64, 221, 13 };

            var result = await base.CallApp(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Register_Transactions(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 240, 64, 221, 13 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record an off-chain machine-to-machine payment. No ALGO transfer occurs.
        ///Increments payment_count, which gates tier advancement.
        ///Preconditions:   - Agent is not defaulted (is_defaulted == 0)   - Agent is registered (stake_amount > 0)
        ///Mutates:   - payment_count[sender] += 1   - last_payment_round[sender] = current round
        ///Emits: PaymentRecorded Returns: current tier number (0-3) as arc4.UInt64
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<ulong> RecordPayment(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 137, 6, 194 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RecordPayment_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 137, 6, 194 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Draw undercollateralised credit from the protocol treasury.
        ///Sends ALGO from the contract to Txn.sender via inner transaction.
        ///Preconditions:   - Agent not defaulted (is_defaulted == 0)   - Agent registered (stake_amount > 0)   - draw amount <= tier per-draw hard cap   - daily_drawn + amount <= tier daily cap   - contract has sufficient balance   - attestation_hash valid (if skip_attestation == 0)
        ///Mutates:   - daily_drawn[sender] += amount  (resets if new day window)   - day_start_round[sender] updated if new window   - outstanding[sender] += amount + interest   - repay_by_round[sender] = current_round + DAY_IN_ROUNDS   - treasury_balance.value -= amount  (funds leave contract)
        ///Emits: CreditDrawn
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="attestation_hash"> </param>
        public async Task Draw(ulong amount, byte[] attestation_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 25, 53, 200 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var attestation_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); attestation_hashAbi.From(attestation_hash);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, attestation_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Draw_Transactions(ulong amount, byte[] attestation_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 25, 53, 200 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var attestation_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); attestation_hashAbi.From(attestation_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, attestation_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Repay outstanding credit (principal + interest) by sending ALGO
        ///back to the contract address.
        ///Preconditions:   - pay.receiver == application address   - pay.amount > 0
        ///Mutates:   - outstanding[sender] reduced by repay_amt (floored at 0)   - total_repaid[sender] += repay_amt   - treasury_balance += repay_amt   - last_payment_round[sender] = current round
        ///Emits: Repaid
        ///</summary>
        /// <param name="pay"> </param>
        public async Task Repay(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 249, 126, 159, 39 };

            var result = await base.CallApp(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Repay_Transactions(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 249, 126, 159, 39 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Slash a delinquent agent. Anyone may call this; caller earns 10% reward.
        ///Preconditions:   - Agent has outstanding > 0   - Agent has never repaid (payment_count == 0)     OR last payment was > 30 rounds ago
        ///Mutates:   - is_defaulted[agent] = 1   - stake_amount[agent] = 0   - treasury_balance += 90% of stake   - Sends 10% of stake to Txn.sender via inner transaction
        ///Emits: AgentSlashed
        ///</summary>
        /// <param name="agent"> </param>
        public async Task Slash(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 36, 157, 112 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Slash_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 36, 157, 112 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read an agent's full position. Does not modify state.
        ///Returns (all arc4.UInt64):   0: stake_amount   1: payment_count   2: tier_max_draw      (derived from tier, replaces credit_limit formula)   3: outstanding   4: is_defaulted   5: tier               (0-3)   6: apr_bps            (tier APR in basis points)   7: daily_drawn   8: repay_by_round
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<Structs.GetPositionReturn> GetPosition(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 48, 174, 247 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.SimApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetPositionReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPosition_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 48, 174, 247 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Seed the protocol treasury with ALGO. Creator-only.
        ///Preconditions:   - Txn.sender == Global.creator_address   - pay.receiver == application address   - pay.amount > 0
        ///Mutates:   - treasury_balance += pay.amount
        ///Emits: nothing.
        ///</summary>
        /// <param name="pay"> </param>
        public async Task SeedTreasury(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 179, 135, 110, 42 };

            var result = await base.CallApp(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SeedTreasury_Transactions(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 179, 135, 110, 42 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set the protocol attestation signer address. Creator-only.
        ///Preconditions:   - Txn.sender == Global.creator_address
        ///Mutates:   - protocol_signer = signer.native
        ///Emits: nothing.
        ///</summary>
        /// <param name="signer"> </param>
        public async Task SetSigner(Algorand.Address signer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 93, 156, 145 };
            var signerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); signerAbi.From(signer);

            var result = await base.CallApp(new List<object> { abiHandle, signerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetSigner_Transactions(Algorand.Address signer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 93, 156, 145 };
            var signerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); signerAbi.From(signer);

            return await base.MakeTransactionList(new List<object> { abiHandle, signerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Switch draw() from demo-bypass mode into full attestation-hash
        ///verification mode. Creator-only.
        ///Preconditions:   - Txn.sender == Global.creator_address
        ///Mutates:   - skip_attestation = 0
        ///Emits: nothing. Note: Call set_signer() before enabling attestation in production.
        ///</summary>
        public async Task EnableAttestation(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 175, 174, 243 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> EnableAttestation_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 175, 174, 243 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmxvb3BhIiwiZGVzYyI6IlxuICAgIE9uLWNoYWluIHJlcHV0YXRpb24gY3JlZGl0IHByb3RvY29sIGZvciBBSSBhZ2VudHMuXG5cbiAgICBMb2NhbCBzdGF0ZSBzY2hlbWE6ICA5IMOXIHVpbnQ2NCwgMCDDlyBieXRlc1xuICAgICAgc3Rha2VfYW1vdW50LCBwYXltZW50X2NvdW50LCB0b3RhbF9yZXBhaWQsIG91dHN0YW5kaW5nLFxuICAgICAgaXNfZGVmYXVsdGVkLCBsYXN0X3BheW1lbnRfcm91bmQsIGRhaWx5X2RyYXduLFxuICAgICAgZGF5X3N0YXJ0X3JvdW5kLCByZXBheV9ieV9yb3VuZFxuXG4gICAgR2xvYmFsIHN0YXRlIHNjaGVtYTogMyDDlyB1aW50NjQsIDEgw5cgYnl0ZXNcbiAgICAgIHRyZWFzdXJ5X2JhbGFuY2UsIHRvdGFsX2FnZW50cywgc2tpcF9hdHRlc3RhdGlvbixcbiAgICAgIHByb3RvY29sX3NpZ25lciAoYnl0ZXMpXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldFBvc2l0aW9uUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ2IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDgiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InJlZ2lzdGVyIiwiZGVzYyI6IlJlZ2lzdGVyIGEgbmV3IGFnZW50IGJ5IHN0YWtpbmcgQUxHTy5cblByZWNvbmRpdGlvbnM6ICAgLSBwYXkucmVjZWl2ZXIgPT0gYXBwbGljYXRpb24gYWRkcmVzcyAgIC0gcGF5LmFtb3VudCA+PSAxXzAwMF8wMDAgbWljcm9BTEdPICgxIEFMR08pICAgLSBBZ2VudCBtdXN0IG5vdCBhbHJlYWR5IGJlIHJlZ2lzdGVyZWQgKHN0YWtlX2Ftb3VudCA9PSAwKVxuTXV0YXRlczogICAtIEFsbCA5IGxvY2FsIHN0YXRlIHNsb3RzIGluaXRpYWxpc2VkIGZvciBUeG4uc2VuZGVyLiAgIC0gdHJlYXN1cnlfYmFsYW5jZSArPSBwYXkuYW1vdW50ICAgLSB0b3RhbF9hZ2VudHMgKz0gMVxuRW1pdHM6IEFnZW50UmVnaXN0ZXJlZCIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFnZW50UmVnaXN0ZXJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFrZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZF9wYXltZW50IiwiZGVzYyI6IlJlY29yZCBhbiBvZmYtY2hhaW4gbWFjaGluZS10by1tYWNoaW5lIHBheW1lbnQuIE5vIEFMR08gdHJhbnNmZXIgb2NjdXJzLlxuSW5jcmVtZW50cyBwYXltZW50X2NvdW50LCB3aGljaCBnYXRlcyB0aWVyIGFkdmFuY2VtZW50LlxuUHJlY29uZGl0aW9uczogICAtIEFnZW50IGlzIG5vdCBkZWZhdWx0ZWQgKGlzX2RlZmF1bHRlZCA9PSAwKSAgIC0gQWdlbnQgaXMgcmVnaXN0ZXJlZCAoc3Rha2VfYW1vdW50ID4gMClcbk11dGF0ZXM6ICAgLSBwYXltZW50X2NvdW50W3NlbmRlcl0gKz0gMSAgIC0gbGFzdF9wYXltZW50X3JvdW5kW3NlbmRlcl0gPSBjdXJyZW50IHJvdW5kXG5FbWl0czogUGF5bWVudFJlY29yZGVkIFJldHVybnM6IGN1cnJlbnQgdGllciBudW1iZXIgKDAtMykgYXMgYXJjNC5VSW50NjQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlBheW1lbnRSZWNvcmRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aWVyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZHJhdyIsImRlc2MiOiJEcmF3IHVuZGVyY29sbGF0ZXJhbGlzZWQgY3JlZGl0IGZyb20gdGhlIHByb3RvY29sIHRyZWFzdXJ5LlxuU2VuZHMgQUxHTyBmcm9tIHRoZSBjb250cmFjdCB0byBUeG4uc2VuZGVyIHZpYSBpbm5lciB0cmFuc2FjdGlvbi5cblByZWNvbmRpdGlvbnM6ICAgLSBBZ2VudCBub3QgZGVmYXVsdGVkIChpc19kZWZhdWx0ZWQgPT0gMCkgICAtIEFnZW50IHJlZ2lzdGVyZWQgKHN0YWtlX2Ftb3VudCA+IDApICAgLSBkcmF3IGFtb3VudCA8PSB0aWVyIHBlci1kcmF3IGhhcmQgY2FwICAgLSBkYWlseV9kcmF3biArIGFtb3VudCA8PSB0aWVyIGRhaWx5IGNhcCAgIC0gY29udHJhY3QgaGFzIHN1ZmZpY2llbnQgYmFsYW5jZSAgIC0gYXR0ZXN0YXRpb25faGFzaCB2YWxpZCAoaWYgc2tpcF9hdHRlc3RhdGlvbiA9PSAwKVxuTXV0YXRlczogICAtIGRhaWx5X2RyYXduW3NlbmRlcl0gKz0gYW1vdW50ICAocmVzZXRzIGlmIG5ldyBkYXkgd2luZG93KSAgIC0gZGF5X3N0YXJ0X3JvdW5kW3NlbmRlcl0gdXBkYXRlZCBpZiBuZXcgd2luZG93ICAgLSBvdXRzdGFuZGluZ1tzZW5kZXJdICs9IGFtb3VudCArIGludGVyZXN0ICAgLSByZXBheV9ieV9yb3VuZFtzZW5kZXJdID0gY3VycmVudF9yb3VuZCArIERBWV9JTl9ST1VORFMgICAtIHRyZWFzdXJ5X2JhbGFuY2UudmFsdWUgLT0gYW1vdW50ICAoZnVuZHMgbGVhdmUgY29udHJhY3QpXG5FbWl0czogQ3JlZGl0RHJhd24iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF0dGVzdGF0aW9uX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNyZWRpdERyYXduIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3V0c3RhbmRpbmciLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXBheSIsImRlc2MiOiJSZXBheSBvdXRzdGFuZGluZyBjcmVkaXQgKHByaW5jaXBhbCArIGludGVyZXN0KSBieSBzZW5kaW5nIEFMR09cbmJhY2sgdG8gdGhlIGNvbnRyYWN0IGFkZHJlc3MuXG5QcmVjb25kaXRpb25zOiAgIC0gcGF5LnJlY2VpdmVyID09IGFwcGxpY2F0aW9uIGFkZHJlc3MgICAtIHBheS5hbW91bnQgPiAwXG5NdXRhdGVzOiAgIC0gb3V0c3RhbmRpbmdbc2VuZGVyXSByZWR1Y2VkIGJ5IHJlcGF5X2FtdCAoZmxvb3JlZCBhdCAwKSAgIC0gdG90YWxfcmVwYWlkW3NlbmRlcl0gKz0gcmVwYXlfYW10ICAgLSB0cmVhc3VyeV9iYWxhbmNlICs9IHJlcGF5X2FtdCAgIC0gbGFzdF9wYXltZW50X3JvdW5kW3NlbmRlcl0gPSBjdXJyZW50IHJvdW5kXG5FbWl0czogUmVwYWlkIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUmVwYWlkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im91dHN0YW5kaW5nIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2xhc2giLCJkZXNjIjoiU2xhc2ggYSBkZWxpbnF1ZW50IGFnZW50LiBBbnlvbmUgbWF5IGNhbGwgdGhpczsgY2FsbGVyIGVhcm5zIDEwJSByZXdhcmQuXG5QcmVjb25kaXRpb25zOiAgIC0gQWdlbnQgaGFzIG91dHN0YW5kaW5nID4gMCAgIC0gQWdlbnQgaGFzIG5ldmVyIHJlcGFpZCAocGF5bWVudF9jb3VudCA9PSAwKSAgICAgT1IgbGFzdCBwYXltZW50IHdhcyA+IDMwIHJvdW5kcyBhZ29cbk11dGF0ZXM6ICAgLSBpc19kZWZhdWx0ZWRbYWdlbnRdID0gMSAgIC0gc3Rha2VfYW1vdW50W2FnZW50XSA9IDAgICAtIHRyZWFzdXJ5X2JhbGFuY2UgKz0gOTAlIG9mIHN0YWtlICAgLSBTZW5kcyAxMCUgb2Ygc3Rha2UgdG8gVHhuLnNlbmRlciB2aWEgaW5uZXIgdHJhbnNhY3Rpb25cbkVtaXRzOiBBZ2VudFNsYXNoZWQiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBZ2VudFNsYXNoZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Rha2VfYnVybmVkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyX3Jld2FyZCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wb3NpdGlvbiIsImRlc2MiOiJSZWFkIGFuIGFnZW50J3MgZnVsbCBwb3NpdGlvbi4gRG9lcyBub3QgbW9kaWZ5IHN0YXRlLlxuUmV0dXJucyAoYWxsIGFyYzQuVUludDY0KTogICAwOiBzdGFrZV9hbW91bnQgICAxOiBwYXltZW50X2NvdW50ICAgMjogdGllcl9tYXhfZHJhdyAgICAgIChkZXJpdmVkIGZyb20gdGllciwgcmVwbGFjZXMgY3JlZGl0X2xpbWl0IGZvcm11bGEpICAgMzogb3V0c3RhbmRpbmcgICA0OiBpc19kZWZhdWx0ZWQgICA1OiB0aWVyICAgICAgICAgICAgICAgKDAtMykgICA2OiBhcHJfYnBzICAgICAgICAgICAgKHRpZXIgQVBSIGluIGJhc2lzIHBvaW50cykgICA3OiBkYWlseV9kcmF3biAgIDg6IHJlcGF5X2J5X3JvdW5kIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0UG9zaXRpb25SZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNlZWRfdHJlYXN1cnkiLCJkZXNjIjoiU2VlZCB0aGUgcHJvdG9jb2wgdHJlYXN1cnkgd2l0aCBBTEdPLiBDcmVhdG9yLW9ubHkuXG5QcmVjb25kaXRpb25zOiAgIC0gVHhuLnNlbmRlciA9PSBHbG9iYWwuY3JlYXRvcl9hZGRyZXNzICAgLSBwYXkucmVjZWl2ZXIgPT0gYXBwbGljYXRpb24gYWRkcmVzcyAgIC0gcGF5LmFtb3VudCA+IDBcbk11dGF0ZXM6ICAgLSB0cmVhc3VyeV9iYWxhbmNlICs9IHBheS5hbW91bnRcbkVtaXRzOiBub3RoaW5nLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X3NpZ25lciIsImRlc2MiOiJTZXQgdGhlIHByb3RvY29sIGF0dGVzdGF0aW9uIHNpZ25lciBhZGRyZXNzLiBDcmVhdG9yLW9ubHkuXG5QcmVjb25kaXRpb25zOiAgIC0gVHhuLnNlbmRlciA9PSBHbG9iYWwuY3JlYXRvcl9hZGRyZXNzXG5NdXRhdGVzOiAgIC0gcHJvdG9jb2xfc2lnbmVyID0gc2lnbmVyLm5hdGl2ZVxuRW1pdHM6IG5vdGhpbmcuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW5hYmxlX2F0dGVzdGF0aW9uIiwiZGVzYyI6IlN3aXRjaCBkcmF3KCkgZnJvbSBkZW1vLWJ5cGFzcyBtb2RlIGludG8gZnVsbCBhdHRlc3RhdGlvbi1oYXNoXG52ZXJpZmljYXRpb24gbW9kZS4gQ3JlYXRvci1vbmx5LlxuUHJlY29uZGl0aW9uczogICAtIFR4bi5zZW5kZXIgPT0gR2xvYmFsLmNyZWF0b3JfYWRkcmVzc1xuTXV0YXRlczogICAtIHNraXBfYXR0ZXN0YXRpb24gPSAwXG5FbWl0czogbm90aGluZy4gTm90ZTogQ2FsbCBzZXRfc2lnbmVyKCkgYmVmb3JlIGVuYWJsaW5nIGF0dGVzdGF0aW9uIGluIHByb2R1Y3Rpb24uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjksImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJPcHRJbiJdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQwNV0sImVycm9yTWVzc2FnZSI6IkFnZW50IGFscmVhZHkgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMDJdLCJlcnJvck1lc3NhZ2UiOiJBZ2VudCBoYXMgbm8gb3V0c3RhbmRpbmcgZGVidCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxNCw2MDldLCJlcnJvck1lc3NhZ2UiOiJBZ2VudCBpcyBkZWZhdWx0ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTMwXSwiZXJyb3JNZXNzYWdlIjoiQWdlbnQgaXMgbm90IGRlbGlucXVlbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjEsNjE2XSwiZXJyb3JNZXNzYWdlIjoiQWdlbnQgbm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzkxXSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzI0LDkwMCw5MTYsOTI1XSwiZXJyb3JNZXNzYWdlIjoiRXhjZWVkcyBkYWlseSBjYXAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTgsOTQxLDk1Nyw5NjZdLCJlcnJvck1lc3NhZ2UiOiJFeGNlZWRzIHRpZXIgbWF4IGRyYXciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzNdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgY29udHJhY3QgYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0MV0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgYXR0ZXN0YXRpb24gaGFzaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5N10sImVycm9yTWVzc2FnZSI6Ik1pbmltdW0gc3Rha2UgaXMgMSBBTEdPIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ0Ml0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gZW5hYmxlIGF0dGVzdGF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM4MF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gc2VlZCB0cmVhc3VyeSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MTVdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIHNldCBzaWduZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODgsOTg2LDEzODddLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgYmUgdG8gYXBwbGljYXRpb24gYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk5MV0sImVycm9yTWVzc2FnZSI6IlJlcGF5bWVudCBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyOV0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzA1LDEyODFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmRhaWx5X2RyYXduIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGF5X3N0YXJ0X3JvdW5kIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxMiw2MDcsMTI2N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaXNfZGVmYXVsdGVkIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxhc3RfcGF5bWVudF9yb3VuZCBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3ODksODMwLDEwMDMsMTA1NywxMTAxLDEyNTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm91dHN0YW5kaW5nIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyOCw1NDYsNjc3LDExMDcsMTIxOCwxMjQ5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wYXltZW50X2NvdW50IGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyODldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlcGF5X2J5X3JvdW5kIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc2tpcF9hdHRlc3RhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDMsNTIwLDYxNSwxMTM3LDEyNDJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnN0YWtlX2Ftb3VudCBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2FnZW50cyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDIwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9yZXBhaWQgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDYzLDgxNCwxMDM0LDExNTgsMTM5NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudHJlYXN1cnlfYmFsYW5jZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDAsMTA5NiwxMjE0LDE0MDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA1LDU5MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4MSw5NzksMTM3NF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNaUF6TWlBNE5qUXdNQ0F5TURBd01EQXdJRFV3TURBd01DQTFNREF3TURBd0lERXdNREF3TUFvZ0lDQWdZbmwwWldOaWJHOWpheUFpZEhKbFlYTjFjbmxmWW1Gc1lXNWpaU0lnSW05MWRITjBZVzVrYVc1bklpQWljR0Y1YldWdWRGOWpiM1Z1ZENJZ0luTjBZV3RsWDJGdGIzVnVkQ0lnSW1selgyUmxabUYxYkhSbFpDSWdJbVJoYVd4NVgyUnlZWGR1SWlBaWJHRnpkRjl3WVhsdFpXNTBYM0p2ZFc1a0lpQWlkRzkwWVd4ZmNtVndZV2xrSWlBaVpHRjVYM04wWVhKMFgzSnZkVzVrSWlBaWNtVndZWGxmWW5sZmNtOTFibVFpSUNKMGIzUmhiRjloWjJWdWRITWlJQ0p6YTJsd1gyRjBkR1Z6ZEdGMGFXOXVJaUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TVRRM0NpQWdJQ0F2THlCelpXeG1MblJ5WldGemRYSjVYMkpoYkdGdVkyVWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGNtVmhjM1Z5ZVY5aVlXeGhibU5sSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk1UUTRDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMkZuWlc1MGN5QWdJQ0FnUFNCSGJHOWlZV3hUZEdGMFpTaFZTVzUwTmpRb01Da3BDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlkRzkwWVd4ZllXZGxiblJ6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk1UUTVDaUFnSUNBdkx5QnpaV3htTG5OcmFYQmZZWFIwWlhOMFlYUnBiMjRnUFNCSGJHOWlZV3hUZEdGMFpTaFZTVzUwTmpRb01Ta3BJQ0FqSUdSbFptRjFiSFE2SUdKNWNHRnpjeUJtYjNJZ1pHVnRid29nSUNBZ1lubDBaV01nTVRFZ0x5OGdJbk5yYVhCZllYUjBaWE4wWVhScGIyNGlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qRXhOUW9nSUNBZ0x5OGdZMnhoYzNNZ1FteHZiM0JoS0dGeVl6UXVRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE9Bb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFpqQTBNR1JrTUdRZ01IZ3lZamc1TURaak1pQXdlREV4TVRrek5XTTRJREI0WmprM1pUbG1NamNnTUhnNE9ESTBPV1EzTUNBd2VERXpNekJoWldZM0lEQjRZak00TnpabE1tRWdNSGhpTlRWa09XTTVNU0F3ZURkallXWmhaV1l6SUM4dklHMWxkR2h2WkNBaWNtVm5hWE4wWlhJb2NHRjVLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxZMjl5WkY5d1lYbHRaVzUwS0hWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbVJ5WVhjb2RXbHVkRFkwTEdKNWRHVmJNekpkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsY0dGNUtIQmhlU2wyYjJsa0lpd2diV1YwYUc5a0lDSnpiR0Z6YUNoaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEY5d2IzTnBkR2x2YmloaFpHUnlaWE56S1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0luTmxaV1JmZEhKbFlYTjFjbmtvY0dGNUtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGOXphV2R1WlhJb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0psYm1GaWJHVmZZWFIwWlhOMFlYUnBiMjRvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J5WldkcGMzUmxjaUJ5WldOdmNtUmZjR0Y1YldWdWRDQmtjbUYzSUhKbGNHRjVJSE5zWVhOb0lHZGxkRjl3YjNOcGRHbHZiaUJ6WldWa1gzUnlaV0Z6ZFhKNUlITmxkRjl6YVdkdVpYSWdaVzVoWW14bFgyRjBkR1Z6ZEdGMGFXOXVDaUFnSUNCbGNuSUtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREU0T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qRXhOUW9nSUNBZ0x5OGdZMnhoYzNNZ1FteHZiM0JoS0dGeVl6UXVRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUhOM2FYUmphQ0J0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFNUlHMWhhVzVmYjNCMFgybHVRREl3Q2lBZ0lDQmxjbklLQ20xaGFXNWZiM0IwWDJsdVFESXdPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pFMk5nb2dJQ0FnTHk4Z1FHRnlZelF1WW1GeVpXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVDNCMFNXNGlYU2tLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG94TnpnS0lDQWdJQzh2SUhObGJHWXVjM1JoYTJWZllXMXZkVzUwVzFSNGJpNXpaVzVrWlhKZElDQWdJQ0FnSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p6ZEdGclpWOWhiVzkxYm5RaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qRTNPUW9nSUNBZ0x5OGdjMlZzWmk1d1lYbHRaVzUwWDJOdmRXNTBXMVI0Ymk1elpXNWtaWEpkSUNBZ0lDQWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luQmhlVzFsYm5SZlkyOTFiblFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pFNE1Bb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXlaWEJoYVdSYlZIaHVMbk5sYm1SbGNsMGdJQ0FnSUNBZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5SdmRHRnNYM0psY0dGcFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZNVGd4Q2lBZ0lDQXZMeUJ6Wld4bUxtOTFkSE4wWVc1a2FXNW5XMVI0Ymk1elpXNWtaWEpkSUNBZ0lDQWdJQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV05mTVNBdkx5QWliM1YwYzNSaGJtUnBibWNpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pFNE1nb2dJQ0FnTHk4Z2MyVnNaaTVwYzE5a1pXWmhkV3gwWldSYlZIaHVMbk5sYm1SbGNsMGdJQ0FnSUNBZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1selgyUmxabUYxYkhSbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZNVGd6Q2lBZ0lDQXZMeUJ6Wld4bUxteGhjM1JmY0dGNWJXVnVkRjl5YjNWdVpGdFVlRzR1YzJWdVpHVnlYU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTmlBdkx5QWliR0Z6ZEY5d1lYbHRaVzUwWDNKdmRXNWtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG94T0RRS0lDQWdJQzh2SUhObGJHWXVaR0ZwYkhsZlpISmhkMjViVkhodUxuTmxibVJsY2wwZ0lDQWdJQ0FnSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0prWVdsc2VWOWtjbUYzYmlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk1UZzFDaUFnSUNBdkx5QnpaV3htTG1SaGVWOXpkR0Z5ZEY5eWIzVnVaRnRVZUc0dWMyVnVaR1Z5WFNBZ0lDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVpHRjVYM04wWVhKMFgzSnZkVzVrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzV3ZVRveE9EWUtJQ0FnSUM4dklITmxiR1l1Y21Wd1lYbGZZbmxmY205MWJtUmJWSGh1TG5ObGJtUmxjbDBnSUNBZ0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKeVpYQmhlVjlpZVY5eWIzVnVaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TVRZMkNpQWdJQ0F2THlCQVlYSmpOQzVpWVhKbGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpQY0hSSmJpSmRLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE9Ub0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRDNUNiRzl2Y0dFdWNtVm5hWE4wWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV2RwYzNSbGNqb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG94T1RJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZNakV3Q2lBZ0lDQXZMeUJ3WVhrdWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN3b2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZNakE1TFRJeE1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQndZWGt1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdMeThnS1N3Z0lsQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCMGJ5QmhjSEJzYVdOaGRHbHZiaUJoWkdSeVpYTnpJZ29nSUNBZ1lYTnpaWEowSUM4dklGQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCMGJ5QmhjSEJzYVdOaGRHbHZiaUJoWkdSeVpYTnpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TWpFeUNpQWdJQ0F2THlCaGMzTmxjblFnY0dGNUxtRnRiM1Z1ZENBK1BTQlZTVzUwTmpRb01WOHdNREJmTURBd0tTd2dJazFwYm1sdGRXMGdjM1JoYTJVZ2FYTWdNU0JCVEVkUElnb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVEF3TURBd01Bb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJOYVc1cGJYVnRJSE4wWVd0bElHbHpJREVnUVV4SFR3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPakl4TkFvZ0lDQWdMeThnYzJWc1ppNXpkR0ZyWlY5aGJXOTFiblJiVkhodUxuTmxibVJsY2wwZ1BUMGdWVWx1ZERZMEtEQXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpYzNSaGEyVmZZVzF2ZFc1MElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1JoYTJWZllXMXZkVzUwSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdJUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pJeE15MHlNVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppNXpkR0ZyWlY5aGJXOTFiblJiVkhodUxuTmxibVJsY2wwZ1BUMGdWVWx1ZERZMEtEQXBDaUFnSUNBdkx5QXBMQ0FpUVdkbGJuUWdZV3h5WldGa2VTQnlaV2RwYzNSbGNtVmtJZ29nSUNBZ1lYTnpaWEowSUM4dklFRm5aVzUwSUdGc2NtVmhaSGtnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qSXhOd29nSUNBZ0x5OGdjMlZzWmk1emRHRnJaVjloYlc5MWJuUmJWSGh1TG5ObGJtUmxjbDBnSUNBZ0lDQWdQU0J3WVhrdVlXMXZkVzUwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnpkR0ZyWlY5aGJXOTFiblFpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qSXhPQW9nSUNBZ0x5OGdjMlZzWmk1d1lYbHRaVzUwWDJOdmRXNTBXMVI0Ymk1elpXNWtaWEpkSUNBZ0lDQWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luQmhlVzFsYm5SZlkyOTFiblFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pJeE9Rb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXlaWEJoYVdSYlZIaHVMbk5sYm1SbGNsMGdJQ0FnSUNBZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5SdmRHRnNYM0psY0dGcFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZNakl3Q2lBZ0lDQXZMeUJ6Wld4bUxtOTFkSE4wWVc1a2FXNW5XMVI0Ymk1elpXNWtaWEpkSUNBZ0lDQWdJQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV05mTVNBdkx5QWliM1YwYzNSaGJtUnBibWNpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pJeU1Rb2dJQ0FnTHk4Z2MyVnNaaTVwYzE5a1pXWmhkV3gwWldSYlZIaHVMbk5sYm1SbGNsMGdJQ0FnSUNBZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1selgyUmxabUYxYkhSbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZNakl5Q2lBZ0lDQXZMeUJ6Wld4bUxteGhjM1JmY0dGNWJXVnVkRjl5YjNWdVpGdFVlRzR1YzJWdVpHVnlYU0E5SUc5d0xrZHNiMkpoYkM1eWIzVnVaQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWJHRnpkRjl3WVhsdFpXNTBYM0p2ZFc1a0lnb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZNakl6Q2lBZ0lDQXZMeUJ6Wld4bUxtUmhhV3g1WDJSeVlYZHVXMVI0Ymk1elpXNWtaWEpkSUNBZ0lDQWdJQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTlNBdkx5QWlaR0ZwYkhsZlpISmhkMjRpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pJeU5Bb2dJQ0FnTHk4Z2MyVnNaaTVrWVhsZmMzUmhjblJmY205MWJtUmJWSGh1TG5ObGJtUmxjbDBnSUNBZ1BTQnZjQzVIYkc5aVlXd3VjbTkxYm1RS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbVJoZVY5emRHRnlkRjl5YjNWdVpDSUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPakl5TlFvZ0lDQWdMeThnYzJWc1ppNXlaWEJoZVY5aWVWOXliM1Z1WkZ0VWVHNHVjMlZ1WkdWeVhTQWdJQ0FnUFNCVlNXNTBOalFvTUNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbkpsY0dGNVgySjVYM0p2ZFc1a0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUb3lNamNLSUNBZ0lDOHZJSE5sYkdZdWRISmxZWE4xY25sZlltRnNZVzVqWlM1MllXeDFaU0FyUFNCd1lYa3VZVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEhKbFlYTjFjbmxmWW1Gc1lXNWpaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGNtVmhjM1Z5ZVY5aVlXeGhibU5sSUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnlaV0Z6ZFhKNVgySmhiR0Z1WTJVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPakl5T0FvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5aFoyVnVkSE11ZG1Gc2RXVWdJQ0FnSUNzOUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKMGIzUmhiRjloWjJWdWRITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZZV2RsYm5SeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSjBiM1JoYkY5aFoyVnVkSE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qSXpNZ29nSUNBZ0x5OGdZV2RsYm5ROVlYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pJek13b2dJQ0FnTHk4Z2MzUmhhMlU5WVhKak5DNVZTVzUwTmpRb2NHRjVMbUZ0YjNWdWRDa3NDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TWpNeExUSXpOQW9nSUNBZ0x5OGdRV2RsYm5SU1pXZHBjM1JsY21Wa0tBb2dJQ0FnTHk4Z0lDQWdJR0ZuWlc1MFBXRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQnpkR0ZyWlQxaGNtTTBMbFZKYm5RMk5DaHdZWGt1WVcxdmRXNTBLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qSXpNQzB5TXpVS0lDQWdJQzh2SUdGeVl6UXVaVzFwZENnS0lDQWdJQzh2SUNBZ0lDQkJaMlZ1ZEZKbFoybHpkR1Z5WldRb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGblpXNTBQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ2MzUmhhMlU5WVhKak5DNVZTVzUwTmpRb2NHRjVMbUZ0YjNWdWRDa3NDaUFnSUNBdkx5QWdJQ0FnS1FvZ0lDQWdMeThnS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0Rrek5XRm1PV1FnTHk4Z2JXVjBhRzlrSUNKQloyVnVkRkpsWjJsemRHVnlaV1FvWVdSa2NtVnpjeXgxYVc1ME5qUXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzV3ZVRveE9USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBMa0pzYjI5d1lTNXlaV052Y21SZmNHRjViV1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxZMjl5WkY5d1lYbHRaVzUwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qSTBNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPakkxT1FvZ0lDQWdMeThnYzJWc1ppNXBjMTlrWldaaGRXeDBaV1JiVkhodUxuTmxibVJsY2wwZ1BUMGdWVWx1ZERZMEtEQXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYVhOZlpHVm1ZWFZzZEdWa0lnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhWE5mWkdWbVlYVnNkR1ZrSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdJUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pJMU9DMHlOakFLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppNXBjMTlrWldaaGRXeDBaV1JiVkhodUxuTmxibVJsY2wwZ1BUMGdWVWx1ZERZMEtEQXBDaUFnSUNBdkx5QXBMQ0FpUVdkbGJuUWdhWE1nWkdWbVlYVnNkR1ZrSWdvZ0lDQWdZWE56WlhKMElDOHZJRUZuWlc1MElHbHpJR1JsWm1GMWJIUmxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pJMk1nb2dJQ0FnTHk4Z2MyVnNaaTV6ZEdGclpWOWhiVzkxYm5SYlZIaHVMbk5sYm1SbGNsMGdQaUJWU1c1ME5qUW9NQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKemRHRnJaVjloYlc5MWJuUWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZEdGclpWOWhiVzkxYm5RZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZNall4TFRJMk13b2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQnpaV3htTG5OMFlXdGxYMkZ0YjNWdWRGdFVlRzR1YzJWdVpHVnlYU0ErSUZWSmJuUTJOQ2d3S1FvZ0lDQWdMeThnS1N3Z0lrRm5aVzUwSUc1dmRDQnlaV2RwYzNSbGNtVmtJZ29nSUNBZ1lYTnpaWEowSUM4dklFRm5aVzUwSUc1dmRDQnlaV2RwYzNSbGNtVmtDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TWpZMUNpQWdJQ0F2THlCelpXeG1MbkJoZVcxbGJuUmZZMjkxYm5SYlZIaHVMbk5sYm1SbGNsMGdJQ0FnSUNBclBTQlZTVzUwTmpRb01Ta0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkJoZVcxbGJuUmZZMjkxYm5RaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdZWGx0Wlc1MFgyTnZkVzUwSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luQmhlVzFsYm5SZlkyOTFiblFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk1qWTJDaUFnSUNBdkx5QnpaV3htTG14aGMzUmZjR0Y1YldWdWRGOXliM1Z1WkZ0VWVHNHVjMlZ1WkdWeVhTQWdQU0J2Y0M1SGJHOWlZV3d1Y205MWJtUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklEWWdMeThnSW14aGMzUmZjR0Y1YldWdWRGOXliM1Z1WkNJS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qSTJPQW9nSUNBZ0x5OGdkR2xsY2lBOUlITmxiR1l1WDJkbGRGOTBhV1Z5S0hObGJHWXVjR0Y1YldWdWRGOWpiM1Z1ZEZ0VWVHNHVjMlZ1WkdWeVhTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p3WVhsdFpXNTBYMk52ZFc1MElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjR0Y1YldWdWRGOWpiM1Z1ZENCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJR05oYkd4emRXSWdYMmRsZEY5MGFXVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TWpjeUNpQWdJQ0F2THlCaFoyVnVkRDFoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZNamMwQ2lBZ0lDQXZMeUIwYVdWeVBXRnlZelF1VlVsdWREWTBLSFJwWlhJcExBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPakkzTVMweU56VUtJQ0FnSUM4dklGQmhlVzFsYm5SU1pXTnZjbVJsWkNnS0lDQWdJQzh2SUNBZ0lDQmhaMlZ1ZEQxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCMGFXVnlQV0Z5WXpRdVZVbHVkRFkwS0hScFpYSXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzV3ZVRveU56QXRNamMyQ2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvQ2lBZ0lDQXZMeUFnSUNBZ1VHRjViV1Z1ZEZKbFkyOXlaR1ZrS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JoWjJWdWREMWhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGdGIzVnVkRDFoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lIUnBaWEk5WVhKak5DNVZTVzUwTmpRb2RHbGxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ0tRb2dJQ0FnTHk4Z0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFl6STFNelZtWVRVZ0x5OGdiV1YwYUc5a0lDSlFZWGx0Wlc1MFVtVmpiM0prWldRb1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk1qUXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR0o1ZEdWaklERXlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1F1UW14dmIzQmhMbVJ5WVhkYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtjbUYzT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUb3lPRFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qTXhNZ29nSUNBZ0x5OGdjMlZzWmk1cGMxOWtaV1poZFd4MFpXUmJWSGh1TG5ObGJtUmxjbDBnUFQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlhWE5mWkdWbVlYVnNkR1ZrSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFYTmZaR1ZtWVhWc2RHVmtJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ0lRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPak14TVMwek1UTUtJQ0FnSUM4dklHRnpjMlZ5ZENBb0NpQWdJQ0F2THlBZ0lDQWdjMlZzWmk1cGMxOWtaV1poZFd4MFpXUmJWSGh1TG5ObGJtUmxjbDBnUFQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0F2THlBcExDQWlRV2RsYm5RZ2FYTWdaR1ZtWVhWc2RHVmtJZ29nSUNBZ1lYTnpaWEowSUM4dklFRm5aVzUwSUdseklHUmxabUYxYkhSbFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPak14TlFvZ0lDQWdMeThnYzJWc1ppNXpkR0ZyWlY5aGJXOTFiblJiVkhodUxuTmxibVJsY2wwZ1BpQlZTVzUwTmpRb01Da0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p6ZEdGclpWOWhiVzkxYm5RaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpkR0ZyWlY5aGJXOTFiblFnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk16RTBMVE14TmdvZ0lDQWdMeThnWVhOelpYSjBJQ2dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1Mbk4wWVd0bFgyRnRiM1Z1ZEZ0VWVHNHVjMlZ1WkdWeVhTQStJRlZKYm5RMk5DZ3dLUW9nSUNBZ0x5OGdLU3dnSWtGblpXNTBJRzV2ZENCeVpXZHBjM1JsY21Wa0lnb2dJQ0FnWVhOelpYSjBJQzh2SUVGblpXNTBJRzV2ZENCeVpXZHBjM1JsY21Wa0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZNekU0Q2lBZ0lDQXZMeUJrY21GM1gyRnRkQ0E5SUdGdGIzVnVkQzV1WVhScGRtVUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG96TVRrS0lDQWdJQzh2SUdOMWNuSmxiblJmY205MWJtUWdQU0J2Y0M1SGJHOWlZV3d1Y205MWJtUUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPak15TVMwek1qSUtJQ0FnSUM4dklDTWc0cFNBNHBTQUlFRjBkR1Z6ZEdGMGFXOXVJSFpsY21sbWFXTmhkR2x2YmlBb2NISnZaSFZqZEdsdmJpQndZWFJvS1NEaWxJRGlsSUFLSUNBZ0lDOHZJR2xtSUhObGJHWXVjMnRwY0Y5aGRIUmxjM1JoZEdsdmJpNTJZV3gxWlNBOVBTQlZTVzUwTmpRb01DazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0luTnJhWEJmWVhSMFpYTjBZWFJwYjI0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjMnRwY0Y5aGRIUmxjM1JoZEdsdmJpQmxlR2x6ZEhNS0lDQWdJR0p1ZWlCa2NtRjNYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPak15TkFvZ0lDQWdMeThnVkhodUxuTmxibVJsY2k1aWVYUmxjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPak15TkMwek1qVUtJQ0FnSUM4dklGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNS0lDQWdJQzh2SUNzZ1lXMXZkVzUwTG1KNWRHVnpDaUFnSUNCa2FXY2dOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk16STJDaUFnSUNBdkx5QXJJRzl3TG1sMGIySW9ZM1Z5Y21WdWRGOXliM1Z1WkNrS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZNekkwTFRNeU5nb2dJQ0FnTHk4Z1ZIaHVMbk5sYm1SbGNpNWllWFJsY3dvZ0lDQWdMeThnS3lCaGJXOTFiblF1WW5sMFpYTUtJQ0FnSUM4dklDc2diM0F1YVhSdllpaGpkWEp5Wlc1MFgzSnZkVzVrS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZNekl6TFRNeU53b2dJQ0FnTHk4Z1pYaHdaV04wWldRZ1BTQnZjQzV6YUdFeU5UWW9DaUFnSUNBdkx5QWdJQ0FnVkhodUxuTmxibVJsY2k1aWVYUmxjd29nSUNBZ0x5OGdJQ0FnSUNzZ1lXMXZkVzUwTG1KNWRHVnpDaUFnSUNBdkx5QWdJQ0FnS3lCdmNDNXBkRzlpS0dOMWNuSmxiblJmY205MWJtUXBDaUFnSUNBdkx5QXBDaUFnSUNCemFHRXlOVFlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvek1qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCaGRIUmxjM1JoZEdsdmJsOW9ZWE5vTG1KNWRHVnpJRDA5SUdWNGNHVmpkR1ZrTENBaVNXNTJZV3hwWkNCaGRIUmxjM1JoZEdsdmJpQm9ZWE5vSWdvZ0lDQWdaR2xuSURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQmhkSFJsYzNSaGRHbHZiaUJvWVhOb0NncGtjbUYzWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvek16QXRNek14Q2lBZ0lDQXZMeUFqSU9LVWdPS1VnQ0JFWVdsc2VTQjNhVzVrYjNjZ2NtVnpaWFFnNHBTQTRwU0FDaUFnSUNBdkx5QnliM1Z1WkhOZmFXNWZkMmx1Wkc5M0lEMGdZM1Z5Y21WdWRGOXliM1Z1WkNBdElITmxiR1l1WkdGNVgzTjBZWEowWDNKdmRXNWtXMVI0Ymk1elpXNWtaWEpkQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVpHRjVYM04wWVhKMFgzSnZkVzVrSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpHRjVYM04wWVhKMFgzSnZkVzVrSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJQzBLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvek16SUtJQ0FnSUM4dklHbG1JSEp2ZFc1a2MxOXBibDkzYVc1a2IzY2dQajBnVlVsdWREWTBLRVJCV1Y5SlRsOVNUMVZPUkZNcE9nb2dJQ0FnYVc1MFl5QTBJQzh2SURnMk5EQXdDaUFnSUNBK1BRb2dJQ0FnWW5vZ1pISmhkMTloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG96TXpNS0lDQWdJQzh2SUhObGJHWXVaR0ZwYkhsZlpISmhkMjViVkhodUxuTmxibVJsY2wwZ0lDQWdJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZeUExSUM4dklDSmtZV2xzZVY5a2NtRjNiaUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TXpNMENpQWdJQ0F2THlCelpXeG1MbVJoZVY5emRHRnlkRjl5YjNWdVpGdFVlRzR1YzJWdVpHVnlYU0E5SUdOMWNuSmxiblJmY205MWJtUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW1SaGVWOXpkR0Z5ZEY5eWIzVnVaQ0lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2dwa2NtRjNYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG96TXpZdE16TTNDaUFnSUNBdkx5QWpJT0tVZ09LVWdDQlVhV1Z5SUd4dmIydDFjQ0RpbElEaWxJQUtJQ0FnSUM4dklIUnBaWElnUFNCelpXeG1MbDluWlhSZmRHbGxjaWh6Wld4bUxuQmhlVzFsYm5SZlkyOTFiblJiVkhodUxuTmxibVJsY2wwcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljR0Y1YldWdWRGOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQmhlVzFsYm5SZlkyOTFiblFnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQmpZV3hzYzNWaUlGOW5aWFJmZEdsbGNnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEY0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG96TXprdE16UXdDaUFnSUNBdkx5QWpJT0tVZ09LVWdDQlFaWEl0WkhKaGR5Qm9ZWEprSUdOaGNDQmphR1ZqYXlEaWxJRGlsSUFLSUNBZ0lDOHZJR2xtSUhScFpYSWdQVDBnVlVsdWREWTBLRE1wT2dvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBOVBRb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEWUtJQ0FnSUdKNklHUnlZWGRmWld4elpWOWliMlI1UURjS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUb3pOREVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmtjbUYzWDJGdGRDQThQU0JWU1c1ME5qUW9WRWxGVWw4elgwMUJXRjlFVWtGWEtTd2dJa1Y0WTJWbFpITWdkR2xsY2lCdFlYZ2daSEpoZHlJS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5SaklEY2dMeThnTlRBd01EQXdNQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCRmVHTmxaV1J6SUhScFpYSWdiV0Y0SUdSeVlYY0tDbVJ5WVhkZllXWjBaWEpmYVdaZlpXeHpaVUF4TkRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUb3pORGt0TXpVd0NpQWdJQ0F2THlBaklPS1VnT0tVZ0NCRVlXbHNlU0JqWVhBZ1kyaGxZMnNnNHBTQTRwU0FDaUFnSUNBdkx5QnVaWGRmWkdGcGJIa2dQU0J6Wld4bUxtUmhhV3g1WDJSeVlYZHVXMVI0Ymk1elpXNWtaWEpkSUNzZ1pISmhkMTloYlhRS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSmtZV2xzZVY5a2NtRjNiaUlLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1SaGFXeDVYMlJ5WVhkdUlHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnWkdsbklESUtJQ0FnSUNzS0lDQWdJR0oxY25rZ053b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPak0xTVFvZ0lDQWdMeThnYVdZZ2RHbGxjaUE5UFNCVlNXNTBOalFvTXlrNkNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWW5vZ1pISmhkMTlsYkhObFgySnZaSGxBTVRZS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUb3pOVElLSUNBZ0lDOHZJR0Z6YzJWeWRDQnVaWGRmWkdGcGJIa2dQRDBnVlVsdWREWTBLRlJKUlZKZk0xOUVRVWxNV1Y5RFFWQXBMQ0FpUlhoalpXVmtjeUJrWVdsc2VTQmpZWEFpQ2lBZ0lDQmthV2NnTmdvZ0lDQWdjSFZ6YUdsdWRDQXlOVEF3TURBd01Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJGZUdObFpXUnpJR1JoYVd4NUlHTmhjQW9LWkhKaGQxOWhablJsY2w5cFpsOWxiSE5sUURJek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPak0yTVFvZ0lDQWdMeThnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeTVpWVd4aGJtTmxJRDQ5SUdSeVlYZGZZVzEwQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JDWVd4aGJtTmxDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lHUnBaeUF5Q2lBZ0lDQStQUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pNMk1DMHpOaklLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeTVpWVd4aGJtTmxJRDQ5SUdSeVlYZGZZVzEwQ2lBZ0lDQXZMeUFwTENBaVNXNXpkV1ptYVdOcFpXNTBJR052Ym5SeVlXTjBJR0poYkdGdVkyVWlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNXpkV1ptYVdOcFpXNTBJR052Ym5SeVlXTjBJR0poYkdGdVkyVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG96TmpRdE16WTJDaUFnSUNBdkx5QWpJT0tVZ09LVWdDQkpiblJsY21WemRDQmpZV3hqZFd4aGRHbHZiaURpbElEaWxJQUtJQ0FnSUM4dklDTWdhVzUwWlhKbGMzUWdQU0FvWkhKaGQxOWhiWFFnS2lCQlVGSmZRbEJUSUNvZ1JFRlpYMGxPWDFKUFZVNUVVeWtnTHlBb01UQXdNREFnS2lCU1QxVk9SRk5mVUVWU1gxbEZRVklwQ2lBZ0lDQXZMeUJwWmlCMGFXVnlJRDA5SUZWSmJuUTJOQ2d6S1RvS0lDQWdJR1JwWnlBMENpQWdJQ0JpZWlCa2NtRjNYMlZzYzJWZlltOWtlVUF5TlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qTTJOd29nSUNBZ0x5OGdZWEJ5WDJKd2N5QTlJRlZKYm5RMk5DaFVTVVZTWHpOZlFWQlNYMEpRVXlrS0lDQWdJSEIxYzJocGJuUWdOREF3Q2dwa2NtRjNYMkZtZEdWeVgybG1YMlZzYzJWQU16STZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TXpjMUNpQWdJQ0F2THlCcGJuUmxjbVZ6ZENBOUlDaGtjbUYzWDJGdGRDQXFJR0Z3Y2w5aWNITWdLaUJWU1c1ME5qUW9SRUZaWDBsT1gxSlBWVTVFVXlrcElDOHZJQ2hWU1c1ME5qUW9NVEJmTURBd0tTQXFJRlZKYm5RMk5DaFNUMVZPUkZOZlVFVlNYMWxGUVZJcEtRb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXFDaUFnSUNCcGJuUmpJRFFnTHk4Z09EWTBNREFLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTXpFMU16WXdNREF3TURBd0NpQWdJQ0F2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk16YzNMVE00TWdvZ0lDQWdMeThnSXlEaWxJRGlsSUFnVTJWdVpDQkJURWRQSUhacFlTQnBibTVsY2lCMGNtRnVjMkZqZEdsdmJpRGlsSURpbElBS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxa2NtRjNYMkZ0ZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5UjJ4dlltRnNMbTFwYmw5MGVHNWZabVZsTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pNNE1Rb2dJQ0FnTHk4Z1ptVmxQVWRzYjJKaGJDNXRhVzVmZEhodVgyWmxaU3dLSUNBZ0lHZHNiMkpoYkNCTmFXNVVlRzVHWldVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUb3pOemtLSUNBZ0lDOHZJSEpsWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNd29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvek56Y3RNemM0Q2lBZ0lDQXZMeUFqSU9LVWdPS1VnQ0JUWlc1a0lFRk1SMDhnZG1saElHbHVibVZ5SUhSeVlXNXpZV04wYVc5dUlPS1VnT0tVZ0FvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUb3pOemN0TXpneUNpQWdJQ0F2THlBaklPS1VnT0tVZ0NCVFpXNWtJRUZNUjA4Z2RtbGhJR2x1Ym1WeUlIUnlZVzV6WVdOMGFXOXVJT0tVZ09LVWdBb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXUnlZWGRmWVcxMExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxSGJHOWlZV3d1YldsdVgzUjRibDltWldVc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qTTROQzB6T0RVS0lDQWdJQzh2SUNNZzRwU0E0cFNBSUZWd1pHRjBaU0J6ZEdGMFpTRGlsSURpbElBS0lDQWdJQzh2SUhObGJHWXVaR0ZwYkhsZlpISmhkMjViVkhodUxuTmxibVJsY2wwZ0lDQWdQU0J1WlhkZlpHRnBiSGtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltUmhhV3g1WDJSeVlYZHVJZ29nSUNBZ1pHbG5JREV3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk16ZzJDaUFnSUNBdkx5QnpaV3htTG05MWRITjBZVzVrYVc1blcxUjRiaTV6Wlc1a1pYSmRJQ0FnS3owZ1pISmhkMTloYlhRZ0t5QnBiblJsY21WemRBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWliM1YwYzNSaGJtUnBibWNpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmRYUnpkR0Z1WkdsdVp5QmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNd29nSUNBZ0t3b2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYjNWMGMzUmhibVJwYm1jaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZNemczQ2lBZ0lDQXZMeUJ6Wld4bUxuSmxjR0Y1WDJKNVgzSnZkVzVrVzFSNGJpNXpaVzVrWlhKZElEMGdZM1Z5Y21WdWRGOXliM1Z1WkNBcklGVkpiblEyTkNoRVFWbGZTVTVmVWs5VlRrUlRLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR01nTkNBdkx5QTROalF3TUFvZ0lDQWdLd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWNtVndZWGxmWW5sZmNtOTFibVFpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG96T0RnS0lDQWdJQzh2SUhObGJHWXVkSEpsWVhOMWNubGZZbUZzWVc1alpTNTJZV3gxWlNBZ0lDQXRQU0JrY21GM1gyRnRkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnlaV0Z6ZFhKNVgySmhiR0Z1WTJVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkSEpsWVhOMWNubGZZbUZzWVc1alpTQmxlR2x6ZEhNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0xRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRISmxZWE4xY25sZlltRnNZVzVqWlNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZNemt5Q2lBZ0lDQXZMeUJoWjJWdWREMWhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk16azBDaUFnSUNBdkx5QnBiblJsY21WemREMWhjbU0wTGxWSmJuUTJOQ2hwYm5SbGNtVnpkQ2tzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk16azFDaUFnSUNBdkx5QnZkWFJ6ZEdGdVpHbHVaejFoY21NMExsVkpiblEyTkNoelpXeG1MbTkxZEhOMFlXNWthVzVuVzFSNGJpNXpaVzVrWlhKZEtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p2ZFhSemRHRnVaR2x1WnlJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOTFkSE4wWVc1a2FXNW5JR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pNNU1TMHpPVFlLSUNBZ0lDOHZJRU55WldScGRFUnlZWGR1S0FvZ0lDQWdMeThnSUNBZ0lHRm5aVzUwUFdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5WVhKak5DNVZTVzUwTmpRb1pISmhkMTloYlhRcExBb2dJQ0FnTHk4Z0lDQWdJR2x1ZEdWeVpYTjBQV0Z5WXpRdVZVbHVkRFkwS0dsdWRHVnlaWE4wS1N3S0lDQWdJQzh2SUNBZ0lDQnZkWFJ6ZEdGdVpHbHVaejFoY21NMExsVkpiblEyTkNoelpXeG1MbTkxZEhOMFlXNWthVzVuVzFSNGJpNXpaVzVrWlhKZEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPak01TUMwek9UY0tJQ0FnSUM4dklHRnlZelF1WlcxcGRDZ0tJQ0FnSUM4dklDQWdJQ0JEY21Wa2FYUkVjbUYzYmlnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVdkbGJuUTlZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaGJXOTFiblE5WVhKak5DNVZTVzUwTmpRb1pISmhkMTloYlhRcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCcGJuUmxjbVZ6ZEQxaGNtTTBMbFZKYm5RMk5DaHBiblJsY21WemRDa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHOTFkSE4wWVc1a2FXNW5QV0Z5WXpRdVZVbHVkRFkwS0hObGJHWXViM1YwYzNSaGJtUnBibWRiVkhodUxuTmxibVJsY2wwcExBb2dJQ0FnTHk4Z0lDQWdJQ2tLSUNBZ0lDOHZJQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREpoTmpRd1pEa3hJQzh2SUcxbGRHaHZaQ0FpUTNKbFpHbDBSSEpoZDI0b1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pJNE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwa2NtRjNYMlZzYzJWZlltOWtlVUF5TlRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUb3pOamdLSUNBZ0lDOHZJR1ZzYVdZZ2RHbGxjaUE5UFNCVlNXNTBOalFvTWlrNkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJRDA5Q2lBZ0lDQmllaUJrY21GM1gyVnNjMlZmWW05a2VVQXlOd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pNMk9Rb2dJQ0FnTHk4Z1lYQnlYMkp3Y3lBOUlGVkpiblEyTkNoVVNVVlNYekpmUVZCU1gwSlFVeWtLSUNBZ0lIQjFjMmhwYm5RZ09UQXdDaUFnSUNCaUlHUnlZWGRmWVdaMFpYSmZhV1pmWld4elpVQXpNZ29LWkhKaGQxOWxiSE5sWDJKdlpIbEFNamM2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk16Y3dDaUFnSUNBdkx5QmxiR2xtSUhScFpYSWdQVDBnVlVsdWREWTBLREVwT2dvZ0lDQWdaR2xuSURVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2daSEpoZDE5bGJITmxYMkp2WkhsQU1qa0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG96TnpFS0lDQWdJQzh2SUdGd2NsOWljSE1nUFNCVlNXNTBOalFvVkVsRlVsOHhYMEZRVWw5Q1VGTXBDaUFnSUNCd2RYTm9hVzUwSURFMk1EQUtJQ0FnSUdJZ1pISmhkMTloWm5SbGNsOXBabDlsYkhObFFETXlDZ3BrY21GM1gyVnNjMlZmWW05a2VVQXlPVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvek56TUtJQ0FnSUM4dklHRndjbDlpY0hNZ1BTQlZTVzUwTmpRb1ZFbEZVbDh3WDBGUVVsOUNVRk1wQ2lBZ0lDQndkWE5vYVc1MElESTBNREFLSUNBZ0lHSWdaSEpoZDE5aFpuUmxjbDlwWmw5bGJITmxRRE15Q2dwa2NtRjNYMlZzYzJWZlltOWtlVUF4TmpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUb3pOVE1LSUNBZ0lDOHZJR1ZzYVdZZ2RHbGxjaUE5UFNCVlNXNTBOalFvTWlrNkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJRDA5Q2lBZ0lDQmllaUJrY21GM1gyVnNjMlZmWW05a2VVQXhPQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pNMU5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUc1bGQxOWtZV2xzZVNBOFBTQlZTVzUwTmpRb1ZFbEZVbDh5WDBSQlNVeFpYME5CVUNrc0lDSkZlR05sWldSeklHUmhhV3g1SUdOaGNDSUtJQ0FnSUdScFp5QTJDaUFnSUNCd2RYTm9hVzUwSURFd01EQXdNREF3Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFVjRZMlZsWkhNZ1pHRnBiSGtnWTJGd0NpQWdJQ0JpSUdSeVlYZGZZV1owWlhKZmFXWmZaV3h6WlVBeU13b0taSEpoZDE5bGJITmxYMkp2WkhsQU1UZzZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TXpVMUNpQWdJQ0F2THlCbGJHbG1JSFJwWlhJZ1BUMGdWVWx1ZERZMEtERXBPZ29nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWW5vZ1pISmhkMTlsYkhObFgySnZaSGxBTWpBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUb3pOVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnVaWGRmWkdGcGJIa2dQRDBnVlVsdWREWTBLRlJKUlZKZk1WOUVRVWxNV1Y5RFFWQXBMQ0FpUlhoalpXVmtjeUJrWVdsc2VTQmpZWEFpQ2lBZ0lDQmthV2NnTmdvZ0lDQWdhVzUwWXlBMUlDOHZJREl3TURBd01EQUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnUlhoalpXVmtjeUJrWVdsc2VTQmpZWEFLSUNBZ0lHSWdaSEpoZDE5aFpuUmxjbDlwWmw5bGJITmxRREl6Q2dwa2NtRjNYMlZzYzJWZlltOWtlVUF5TURvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUb3pOVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnVaWGRmWkdGcGJIa2dQRDBnVlVsdWREWTBLRlJKUlZKZk1GOUVRVWxNV1Y5RFFWQXBMQ0FpUlhoalpXVmtjeUJrWVdsc2VTQmpZWEFpQ2lBZ0lDQmthV2NnTmdvZ0lDQWdhVzUwWXlBMklDOHZJRFV3TURBd01Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJGZUdObFpXUnpJR1JoYVd4NUlHTmhjQW9nSUNBZ1lpQmtjbUYzWDJGbWRHVnlYMmxtWDJWc2MyVkFNak1LQ21SeVlYZGZaV3h6WlY5aWIyUjVRRGM2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk16UXlDaUFnSUNBdkx5QmxiR2xtSUhScFpYSWdQVDBnVlVsdWREWTBLRElwT2dvZ0lDQWdaR2xuSURVS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lub2daSEpoZDE5bGJITmxYMkp2WkhsQU9Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPak0wTXdvZ0lDQWdMeThnWVhOelpYSjBJR1J5WVhkZllXMTBJRHc5SUZWSmJuUTJOQ2hVU1VWU1h6SmZUVUZZWDBSU1FWY3BMQ0FpUlhoalpXVmtjeUIwYVdWeUlHMWhlQ0JrY21GM0lnb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTWdOU0F2THlBeU1EQXdNREF3Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFVjRZMlZsWkhNZ2RHbGxjaUJ0WVhnZ1pISmhkd29nSUNBZ1lpQmtjbUYzWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLQ21SeVlYZGZaV3h6WlY5aWIyUjVRRGs2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk16UTBDaUFnSUNBdkx5QmxiR2xtSUhScFpYSWdQVDBnVlVsdWREWTBLREVwT2dvZ0lDQWdaR2xuSURVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lub2daSEpoZDE5bGJITmxYMkp2WkhsQU1URUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG96TkRVS0lDQWdJQzh2SUdGemMyVnlkQ0JrY21GM1gyRnRkQ0E4UFNCVlNXNTBOalFvVkVsRlVsOHhYMDFCV0Y5RVVrRlhLU3dnSWtWNFkyVmxaSE1nZEdsbGNpQnRZWGdnWkhKaGR5SUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpJRFlnTHk4Z05UQXdNREF3Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFVjRZMlZsWkhNZ2RHbGxjaUJ0WVhnZ1pISmhkd29nSUNBZ1lpQmtjbUYzWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLQ21SeVlYZGZaV3h6WlY5aWIyUjVRREV4T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qTTBOd29nSUNBZ0x5OGdZWE56WlhKMElHUnlZWGRmWVcxMElEdzlJRlZKYm5RMk5DaFVTVVZTWHpCZlRVRllYMFJTUVZjcExDQWlSWGhqWldWa2N5QjBhV1Z5SUcxaGVDQmtjbUYzSWdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdNZ09DQXZMeUF4TURBd01EQUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnUlhoalpXVmtjeUIwYVdWeUlHMWhlQ0JrY21GM0NpQWdJQ0JpSUdSeVlYZGZZV1owWlhKZmFXWmZaV3h6WlVBeE5Bb0tDaTh2SUdOdmJuUnlZV04wTGtKc2IyOXdZUzV5WlhCaGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsY0dGNU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPalF3TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUbzBNaklLSUNBZ0lDOHZJSEJoZVM1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUbzBNakV0TkRJekNpQWdJQ0F2THlCaGMzTmxjblFnS0FvZ0lDQWdMeThnSUNBZ0lIQmhlUzV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56Q2lBZ0lDQXZMeUFwTENBaVVHRjViV1Z1ZENCdGRYTjBJR0psSUhSdklHRndjR3hwWTJGMGFXOXVJR0ZrWkhKbGMzTWlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCdGRYTjBJR0psSUhSdklHRndjR3hwWTJGMGFXOXVJR0ZrWkhKbGMzTUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG8wTWpRS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhrdVlXMXZkVzUwSUQ0Z1ZVbHVkRFkwS0RBcExDQWlVbVZ3WVhsdFpXNTBJRzExYzNRZ1ltVWdQaUF3SWdvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJTWlhCaGVXMWxiblFnYlhWemRDQmlaU0ErSURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUbzBNamNLSUNBZ0lDOHZJR04xY25KbGJuUmZiM1YwYzNSaGJtUnBibWNnUFNCelpXeG1MbTkxZEhOMFlXNWthVzVuVzFSNGJpNXpaVzVrWlhKZENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWliM1YwYzNSaGJtUnBibWNpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTkxZEhOMFlXNWthVzVuSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qUXlPUW9nSUNBZ0x5OGdhV1lnY21Wd1lYbGZZVzEwSUQ0OUlHTjFjbkpsYm5SZmIzVjBjM1JoYm1ScGJtYzZDaUFnSUNBK1BRb2dJQ0FnWW5vZ2NtVndZWGxmWld4elpWOWliMlI1UURNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUbzBNekFLSUNBZ0lDOHZJSE5sYkdZdWIzVjBjM1JoYm1ScGJtZGJWSGh1TG5ObGJtUmxjbDBnUFNCVlNXNTBOalFvTUNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkxZEhOMFlXNWthVzVuSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLQ25KbGNHRjVYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG8wTXpRS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmNtVndZV2xrVzFSNGJpNXpaVzVrWlhKZElDQWdJQ0FnSUNzOUlISmxjR0Y1WDJGdGRBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlkRzkwWVd4ZmNtVndZV2xrSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmY21Wd1lXbGtJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdLd29nSUNBZ1lubDBaV01nTnlBdkx5QWlkRzkwWVd4ZmNtVndZV2xrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qUXpOUW9nSUNBZ0x5OGdjMlZzWmk1MGNtVmhjM1Z5ZVY5aVlXeGhibU5sTG5aaGJIVmxJQ0FnSUNBZ0lDQWdLejBnY21Wd1lYbGZZVzEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkSEpsWVhOMWNubGZZbUZzWVc1alpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwY21WaGMzVnllVjlpWVd4aGJtTmxJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SeVpXRnpkWEo1WDJKaGJHRnVZMlVpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qUXpOZ29nSUNBZ0x5OGdjMlZzWmk1c1lYTjBYM0JoZVcxbGJuUmZjbTkxYm1SYlZIaHVMbk5sYm1SbGNsMGdJRDBnYjNBdVIyeHZZbUZzTG5KdmRXNWtDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKc1lYTjBYM0JoZVcxbGJuUmZjbTkxYm1RaUNpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUbzBOREFLSUNBZ0lDOHZJR0ZuWlc1MFBXRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvME5ERUtJQ0FnSUM4dklHRnRiM1Z1ZEQxaGNtTTBMbFZKYm5RMk5DaHlaWEJoZVY5aGJYUXBMQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pRME1nb2dJQ0FnTHk4Z2IzVjBjM1JoYm1ScGJtYzlZWEpqTkM1VlNXNTBOalFvYzJWc1ppNXZkWFJ6ZEdGdVpHbHVaMXRVZUc0dWMyVnVaR1Z5WFNrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWliM1YwYzNSaGJtUnBibWNpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmRYUnpkR0Z1WkdsdVp5QmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG8wTXprdE5EUXpDaUFnSUNBdkx5QlNaWEJoYVdRb0NpQWdJQ0F2THlBZ0lDQWdZV2RsYm5ROVlYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxaGNtTTBMbFZKYm5RMk5DaHlaWEJoZVY5aGJYUXBMQW9nSUNBZ0x5OGdJQ0FnSUc5MWRITjBZVzVrYVc1blBXRnlZelF1VlVsdWREWTBLSE5sYkdZdWIzVjBjM1JoYm1ScGJtZGJWSGh1TG5ObGJtUmxjbDBwTEFvZ0lDQWdMeThnS1FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvME16Z3RORFEwQ2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvQ2lBZ0lDQXZMeUFnSUNBZ1VtVndZV2xrS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JoWjJWdWREMWhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGdGIzVnVkRDFoY21NMExsVkpiblEyTkNoeVpYQmhlVjloYlhRcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCdmRYUnpkR0Z1WkdsdVp6MWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtOTFkSE4wWVc1a2FXNW5XMVI0Ymk1elpXNWtaWEpkS1N3S0lDQWdJQzh2SUNBZ0lDQXBDaUFnSUNBdkx5QXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzFORGsyTldFNU15QXZMeUJ0WlhSb2IyUWdJbEpsY0dGcFpDaGhaR1J5WlhOekxIVnBiblEyTkN4MWFXNTBOalFwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUbzBNRE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjbVZ3WVhsZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TkRNeUNpQWdJQ0F2THlCelpXeG1MbTkxZEhOMFlXNWthVzVuVzFSNGJpNXpaVzVrWlhKZElEMGdZM1Z5Y21WdWRGOXZkWFJ6ZEdGdVpHbHVaeUF0SUhKbGNHRjVYMkZ0ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdMUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWIzVjBjM1JoYm1ScGJtY2lDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJR0lnY21Wd1lYbGZZV1owWlhKZmFXWmZaV3h6WlVBMENnb0tMeThnWTI5dWRISmhZM1F1UW14dmIzQmhMbk5zWVhOb1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMnhoYzJnNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZORFV3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pRM01Rb2dJQ0FnTHk4Z2MyVnNaaTV2ZFhSemRHRnVaR2x1WjF0aFoyVnVkRjloWkdSeVhTQStJRlZKYm5RMk5DZ3dLUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWIzVjBjM1JoYm1ScGJtY2lDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2ZFhSemRHRnVaR2x1WnlCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUbzBOekF0TkRjeUNpQWdJQ0F2THlCaGMzTmxjblFnS0FvZ0lDQWdMeThnSUNBZ0lITmxiR1l1YjNWMGMzUmhibVJwYm1kYllXZGxiblJmWVdSa2NsMGdQaUJWU1c1ME5qUW9NQ2tLSUNBZ0lDOHZJQ2tzSUNKQloyVnVkQ0JvWVhNZ2JtOGdiM1YwYzNSaGJtUnBibWNnWkdWaWRDSUtJQ0FnSUdGemMyVnlkQ0F2THlCQloyVnVkQ0JvWVhNZ2JtOGdiM1YwYzNSaGJtUnBibWNnWkdWaWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPalEzTkFvZ0lDQWdMeThnY0dGNWJXVnVkRjlqYjNWdWRDQTlJSE5sYkdZdWNHRjViV1Z1ZEY5amIzVnVkRnRoWjJWdWRGOWhaR1J5WFFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljR0Y1YldWdWRGOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQmhlVzFsYm5SZlkyOTFiblFnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk5EYzFDaUFnSUNBdkx5QnliM1Z1WkhOZmMybHVZMlVnSUQwZ2IzQXVSMnh2WW1Gc0xuSnZkVzVrSUMwZ2MyVnNaaTVzWVhOMFgzQmhlVzFsYm5SZmNtOTFibVJiWVdkbGJuUmZZV1JrY2wwS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWJHRnpkRjl3WVhsdFpXNTBYM0p2ZFc1a0lnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViR0Z6ZEY5d1lYbHRaVzUwWDNKdmRXNWtJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ0xRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPalEzT0FvZ0lDQWdMeThnY0dGNWJXVnVkRjlqYjNWdWRDQTlQU0JWU1c1ME5qUW9NQ2tnYjNJZ2NtOTFibVJ6WDNOcGJtTmxJRDRnVlVsdWREWTBLRE13S1FvZ0lDQWdZbm9nYzJ4aGMyaGZZbTl2YkY5MGNuVmxRRE1LSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBek1Bb2dJQ0FnUGdvZ0lDQWdZbm9nYzJ4aGMyaGZZbTl2YkY5bVlXeHpaVUEwQ2dwemJHRnphRjlpYjI5c1gzUnlkV1ZBTXpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwemJHRnphRjlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZORGMzTFRRM09Rb2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQndZWGx0Wlc1MFgyTnZkVzUwSUQwOUlGVkpiblEyTkNnd0tTQnZjaUJ5YjNWdVpITmZjMmx1WTJVZ1BpQlZTVzUwTmpRb016QXBDaUFnSUNBdkx5QXBMQ0FpUVdkbGJuUWdhWE1nYm05MElHUmxiR2x1Y1hWbGJuUWlDaUFnSUNCaGMzTmxjblFnTHk4Z1FXZGxiblFnYVhNZ2JtOTBJR1JsYkdsdWNYVmxiblFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvME9ERUtJQ0FnSUM4dklITjBZV3RsSUQwZ2MyVnNaaTV6ZEdGclpWOWhiVzkxYm5SYllXZGxiblJmWVdSa2NsMEtJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKemRHRnJaVjloYlc5MWJuUWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZEdGclpWOWhiVzkxYm5RZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZORGd6Q2lBZ0lDQXZMeUJqWVd4c1pYSmZjbVYzWVhKa0lDQWdJRDBnYzNSaGEyVWdMeThnVlVsdWREWTBLREV3S1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNBdkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZORGcwQ2lBZ0lDQXZMeUIwY21WaGMzVnllVjl3YjNKMGFXOXVJRDBnYzNSaGEyVWdMU0JqWVd4c1pYSmZjbVYzWVhKa0NpQWdJQ0JrZFhBeUNpQWdJQ0F0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk5EZzJMVFE0TndvZ0lDQWdMeThnSXlCVGJHRnphQ0IwYUdVZ1lXZGxiblFLSUNBZ0lDOHZJSE5sYkdZdWFYTmZaR1ZtWVhWc2RHVmtXMkZuWlc1MFgyRmtaSEpkSUNBOUlGVkpiblEyTkNneEtRb2dJQ0FnWkdsbklETUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltbHpYMlJsWm1GMWJIUmxaQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TkRnNENpQWdJQ0F2THlCelpXeG1Mbk4wWVd0bFgyRnRiM1Z1ZEZ0aFoyVnVkRjloWkdSeVhTQWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p6ZEdGclpWOWhiVzkxYm5RaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qUTRPUW9nSUNBZ0x5OGdjMlZzWmk1MGNtVmhjM1Z5ZVY5aVlXeGhibU5sTG5aaGJIVmxJQ0FnS3owZ2RISmxZWE4xY25sZmNHOXlkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ5WldGemRYSjVYMkpoYkdGdVkyVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEhKbFlYTjFjbmxmWW1Gc1lXNWpaU0JsZUdsemRITUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SeVpXRnpkWEo1WDJKaGJHRnVZMlVpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qUTVNUzAwT1RZS0lDQWdJQzh2SUNNZ1VtVjNZWEprSUhSb1pTQmpZV3hzWlhJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxallXeHNaWEpmY21WM1lYSmtMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMUhiRzlpWVd3dWJXbHVYM1I0Ymw5bVpXVXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZORGsxQ2lBZ0lDQXZMeUJtWldVOVIyeHZZbUZzTG0xcGJsOTBlRzVmWm1WbExBb2dJQ0FnWjJ4dlltRnNJRTFwYmxSNGJrWmxaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pRNU13b2dJQ0FnTHk4Z2NtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPalE1TVMwME9USUtJQ0FnSUM4dklDTWdVbVYzWVhKa0lIUm9aU0JqWVd4c1pYSUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TkRreExUUTVOZ29nSUNBZ0x5OGdJeUJTWlhkaGNtUWdkR2hsSUdOaGJHeGxjZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQV05oYkd4bGNsOXlaWGRoY21Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFVkc2IySmhiQzV0YVc1ZmRIaHVYMlpsWlN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk5UQXhDaUFnSUNBdkx5QnpkR0ZyWlY5aWRYSnVaV1E5WVhKak5DNVZTVzUwTmpRb2MzUmhhMlVwTEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qVXdNZ29nSUNBZ0x5OGdZMkZzYkdWeVgzSmxkMkZ5WkQxaGNtTTBMbFZKYm5RMk5DaGpZV3hzWlhKZmNtVjNZWEprS1N3S0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUbzBPVGt0TlRBekNpQWdJQ0F2THlCQloyVnVkRk5zWVhOb1pXUW9DaUFnSUNBdkx5QWdJQ0FnWVdkbGJuUTlZWEpqTkM1QlpHUnlaWE56S0dGblpXNTBYMkZrWkhJcExBb2dJQ0FnTHk4Z0lDQWdJSE4wWVd0bFgySjFjbTVsWkQxaGNtTTBMbFZKYm5RMk5DaHpkR0ZyWlNrc0NpQWdJQ0F2THlBZ0lDQWdZMkZzYkdWeVgzSmxkMkZ5WkQxaGNtTTBMbFZKYm5RMk5DaGpZV3hzWlhKZmNtVjNZWEprS1N3S0lDQWdJQzh2SUNrS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk5EazRMVFV3TkFvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0FvZ0lDQWdMeThnSUNBZ0lFRm5aVzUwVTJ4aGMyaGxaQ2dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZV2RsYm5ROVlYSmpOQzVCWkdSeVpYTnpLR0ZuWlc1MFgyRmtaSElwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J6ZEdGclpWOWlkWEp1WldROVlYSmpOQzVWU1c1ME5qUW9jM1JoYTJVcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCallXeHNaWEpmY21WM1lYSmtQV0Z5WXpRdVZVbHVkRFkwS0dOaGJHeGxjbDl5WlhkaGNtUXBMQW9nSUNBZ0x5OGdJQ0FnSUNrS0lDQWdJQzh2SUNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVd1ptUmpOalJoSUM4dklHMWxkR2h2WkNBaVFXZGxiblJUYkdGemFHVmtLR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPalExTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B6YkdGemFGOWliMjlzWDJaaGJITmxRRFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnpiR0Z6YUY5aWIyOXNYMjFsY21kbFFEVUtDZ292THlCamIyNTBjbUZqZEM1Q2JHOXZjR0V1WjJWMFgzQnZjMmwwYVc5dVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNCdmMybDBhVzl1T2dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk5URXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qVXpNZ29nSUNBZ0x5OGdkR2xsY2lBOUlITmxiR1l1WDJkbGRGOTBhV1Z5S0hObGJHWXVjR0Y1YldWdWRGOWpiM1Z1ZEZ0aFpHUnlYU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSndZWGx0Wlc1MFgyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHRjViV1Z1ZEY5amIzVnVkQ0JsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lHTmhiR3h6ZFdJZ1gyZGxkRjkwYVdWeUNpQWdJQ0JrZFhBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUbzFNelF0TlRNMUNpQWdJQ0F2THlBaklFUmxjbWwyWlNCMGFXVnlYMjFoZUY5a2NtRjNJRzl1SUhSb1pTQm1iSGtLSUNBZ0lDOHZJR2xtSUhScFpYSWdQVDBnVlVsdWREWTBLRE1wT2dvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBOVBRb2dJQ0FnWW5vZ1oyVjBYM0J2YzJsMGFXOXVYMlZzYzJWZlltOWtlVUF6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk5UTTJDaUFnSUNBdkx5QjBhV1Z5WDIxaGVGOWtjbUYzSUQwZ1ZVbHVkRFkwS0ZSSlJWSmZNMTlOUVZoZlJGSkJWeWtLSUNBZ0lHbHVkR01nTnlBdkx5QTFNREF3TURBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZOVE0zQ2lBZ0lDQXZMeUJoY0hKZlluQnpJQ0FnSUNBZ0lEMGdWVWx1ZERZMEtGUkpSVkpmTTE5QlVGSmZRbEJUS1FvZ0lDQWdjSFZ6YUdsdWRDQTBNREFLSUNBZ0lHSjFjbmtnTkFvS1oyVjBYM0J2YzJsMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU1UQTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TlRRNUNpQWdJQ0F2THlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5OMFlXdGxYMkZ0YjNWdWRGdGhaR1J5WFNrc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpYzNSaGEyVmZZVzF2ZFc1MElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1JoYTJWZllXMXZkVzUwSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qVTFNQW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNXdZWGx0Wlc1MFgyTnZkVzUwVzJGa1pISmRLU3dLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljR0Y1YldWdWRGOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQmhlVzFsYm5SZlkyOTFiblFnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk5UVXhDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2gwYVdWeVgyMWhlRjlrY21GM0tTd0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qVTFNZ29nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNXZkWFJ6ZEdGdVpHbHVaMXRoWkdSeVhTa3NDaUFnSUNCa2FXY2dNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltOTFkSE4wWVc1a2FXNW5JZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNWMGMzUmhibVJwYm1jZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZOVFV6Q2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MbWx6WDJSbFptRjFiSFJsWkZ0aFpHUnlYU2tzQ2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbWx6WDJSbFptRjFiSFJsWkNJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtbHpYMlJsWm1GMWJIUmxaQ0JsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvMU5UUUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSFJwWlhJcExBb2dJQ0FnWkdsbklEWUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG8xTlRVS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtHRndjbDlpY0hNcExBb2dJQ0FnWkdsbklEa0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDNXdlVG8xTlRZS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1WkdGcGJIbGZaSEpoZDI1YllXUmtjbDBwTEFvZ0lDQWdaR2xuSURjS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0prWVdsc2VWOWtjbUYzYmlJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmhhV3g1WDJSeVlYZHVJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pVMU53b2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1eVpYQmhlVjlpZVY5eWIzVnVaRnRoWkdSeVhTa3NDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0p5WlhCaGVWOWllVjl5YjNWdVpDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsY0dGNVgySjVYM0p2ZFc1a0lHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPalV4TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJREV5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BuWlhSZmNHOXphWFJwYjI1ZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TlRNNENpQWdJQ0F2THlCbGJHbG1JSFJwWlhJZ1BUMGdWVWx1ZERZMEtESXBPZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR0o2SUdkbGRGOXdiM05wZEdsdmJsOWxiSE5sWDJKdlpIbEFOUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pVek9Rb2dJQ0FnTHk4Z2RHbGxjbDl0WVhoZlpISmhkeUE5SUZWSmJuUTJOQ2hVU1VWU1h6SmZUVUZZWDBSU1FWY3BDaUFnSUNCcGJuUmpJRFVnTHk4Z01qQXdNREF3TUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qVTBNQW9nSUNBZ0x5OGdZWEJ5WDJKd2N5QWdJQ0FnSUNBOUlGVkpiblEyTkNoVVNVVlNYekpmUVZCU1gwSlFVeWtLSUNBZ0lIQjFjMmhwYm5RZ09UQXdDaUFnSUNCaWRYSjVJRFFLSUNBZ0lHSWdaMlYwWDNCdmMybDBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEFLQ21kbGRGOXdiM05wZEdsdmJsOWxiSE5sWDJKdlpIbEFOVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzV3ZVRvMU5ERUtJQ0FnSUM4dklHVnNhV1lnZEdsbGNpQTlQU0JWU1c1ME5qUW9NU2s2Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWW5vZ1oyVjBYM0J2YzJsMGFXOXVYMlZzYzJWZlltOWtlVUEzQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk5UUXlDaUFnSUNBdkx5QjBhV1Z5WDIxaGVGOWtjbUYzSUQwZ1ZVbHVkRFkwS0ZSSlJWSmZNVjlOUVZoZlJGSkJWeWtLSUNBZ0lHbHVkR01nTmlBdkx5QTFNREF3TURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUbzFORE1LSUNBZ0lDOHZJR0Z3Y2w5aWNITWdJQ0FnSUNBZ1BTQlZTVzUwTmpRb1ZFbEZVbDh4WDBGUVVsOUNVRk1wQ2lBZ0lDQndkWE5vYVc1MElERTJNREFLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdZaUJuWlhSZmNHOXphWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvS1oyVjBYM0J2YzJsMGFXOXVYMlZzYzJWZlltOWtlVUEzT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qVTBOUW9nSUNBZ0x5OGdkR2xsY2w5dFlYaGZaSEpoZHlBOUlGVkpiblEyTkNoVVNVVlNYekJmVFVGWVgwUlNRVmNwQ2lBZ0lDQnBiblJqSURnZ0x5OGdNVEF3TURBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZOVFEyQ2lBZ0lDQXZMeUJoY0hKZlluQnpJQ0FnSUNBZ0lEMGdWVWx1ZERZMEtGUkpSVkpmTUY5QlVGSmZRbEJUS1FvZ0lDQWdjSFZ6YUdsdWRDQXlOREF3Q2lBZ0lDQmlkWEo1SURRS0lDQWdJR0lnWjJWMFgzQnZjMmwwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0Nnb3ZMeUJqYjI1MGNtRmpkQzVDYkc5dmNHRXVjMlZsWkY5MGNtVmhjM1Z5ZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxaV1JmZEhKbFlYTjFjbms2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk5UWTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pVNE1Bb2dJQ0FnTHk4Z1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TlRjNUxUVTRNUW9nSUNBZ0x5OGdZWE56WlhKMElDZ0tJQ0FnSUM4dklDQWdJQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01LSUNBZ0lDOHZJQ2tzSUNKUGJteDVJR055WldGMGIzSWdZMkZ1SUhObFpXUWdkSEpsWVhOMWNua2lDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JqY21WaGRHOXlJR05oYmlCelpXVmtJSFJ5WldGemRYSjVDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TlRnekNpQWdJQ0F2THlCd1lYa3VjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TlRneUxUVTROQW9nSUNBZ0x5OGdZWE56WlhKMElDZ0tJQ0FnSUM4dklDQWdJQ0J3WVhrdWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN3b2dJQ0FnTHk4Z0tTd2dJbEJoZVcxbGJuUWdiWFZ6ZENCaVpTQjBieUJoY0hCc2FXTmhkR2x2YmlCaFpHUnlaWE56SWdvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdiWFZ6ZENCaVpTQjBieUJoY0hCc2FXTmhkR2x2YmlCaFpHUnlaWE56Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F1Y0hrNk5UZzFDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjVMbUZ0YjNWdWRDQStJRlZKYm5RMk5DZ3dLU3dnSWtGdGIzVnVkQ0J0ZFhOMElHSmxJRDRnTUNJS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVzF2ZFc1MElHMTFjM1FnWW1VZ1BpQXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXVjSGs2TlRnM0NpQWdJQ0F2THlCelpXeG1MblJ5WldGemRYSjVYMkpoYkdGdVkyVXVkbUZzZFdVZ0t6MGdjR0Y1TG1GdGIzVnVkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnlaV0Z6ZFhKNVgySmhiR0Z1WTJVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkSEpsWVhOMWNubGZZbUZzWVc1alpTQmxlR2x6ZEhNS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ5WldGemRYSjVYMkpoYkdGdVkyVWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pVMk5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUXVRbXh2YjNCaExuTmxkRjl6YVdkdVpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZmMybG5ibVZ5T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qVTVNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM1d2VUbzJNRGNLSUNBZ0lDOHZJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qWXdOaTAyTURnS0lDQWdJQzh2SUdGemMyVnlkQ0FvQ2lBZ0lDQXZMeUFnSUNBZ1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekNpQWdJQ0F2THlBcExDQWlUMjVzZVNCamNtVmhkRzl5SUdOaGJpQnpaWFFnYzJsbmJtVnlJZ29nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2MyVjBJSE5wWjI1bGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPall3T1FvZ0lDQWdMeThnYzJWc1ppNXdjbTkwYjJOdmJGOXphV2R1WlhJdWRtRnNkV1VnUFNCemFXZHVaWEl1Ym1GMGFYWmxDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luQnliM1J2WTI5c1gzTnBaMjVsY2lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZOVGt6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEM1Q2JHOXZjR0V1Wlc1aFlteGxYMkYwZEdWemRHRjBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pXNWhZbXhsWDJGMGRHVnpkR0YwYVc5dU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPall6TVFvZ0lDQWdMeThnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZOak13TFRZek1nb2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTUtJQ0FnSUM4dklDa3NJQ0pQYm14NUlHTnlaV0YwYjNJZ1kyRnVJR1Z1WVdKc1pTQmhkSFJsYzNSaGRHbHZiaUlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOeVpXRjBiM0lnWTJGdUlHVnVZV0pzWlNCaGRIUmxjM1JoZEdsdmJnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPall6TXdvZ0lDQWdMeThnYzJWc1ppNXphMmx3WDJGMGRHVnpkR0YwYVc5dUxuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaWMydHBjRjloZEhSbGMzUmhkR2x2YmlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qWXhOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1F1UW14dmIzQmhMbDluWlhSZmRHbGxjaWh3WVhsdFpXNTBYMk52ZFc1ME9pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Eb0tYMmRsZEY5MGFXVnlPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pZek9TMDJOREFLSUNBZ0lDOHZJRUJoYkdkdmNIa3VjM1ZpY205MWRHbHVaUW9nSUNBZ0x5OGdaR1ZtSUY5blpYUmZkR2xsY2loelpXeG1MQ0J3WVhsdFpXNTBYMk52ZFc1ME9pQlZTVzUwTmpRcElDMCtJRlZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qWTFNd29nSUNBZ0x5OGdhV1lnY0dGNWJXVnVkRjlqYjNWdWRDQStQU0JWU1c1ME5qUW9WRWxGVWw4elgxUklVa1ZUU0U5TVJDazZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnTVRBd0NpQWdJQ0ErUFFvZ0lDQWdZbm9nWDJkbGRGOTBhV1Z5WDJWc2MyVmZZbTlrZVVBeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdWNIazZOalUwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtETXBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJSEpsZEhOMVlnb0tYMmRsZEY5MGFXVnlYMlZzYzJWZlltOWtlVUF5T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTG5CNU9qWTFOUW9nSUNBZ0x5OGdaV3hwWmlCd1lYbHRaVzUwWDJOdmRXNTBJRDQ5SUZWSmJuUTJOQ2hVU1VWU1h6SmZWRWhTUlZOSVQweEVLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBMU1Bb2dJQ0FnUGowS0lDQWdJR0o2SUY5blpYUmZkR2xsY2w5bGJITmxYMkp2WkhsQU5Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPalkxTmdvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3lLUW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUhKbGRITjFZZ29LWDJkbGRGOTBhV1Z5WDJWc2MyVmZZbTlrZVVBME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTnZiblJ5WVdOMExuQjVPalkxTndvZ0lDQWdMeThnWld4cFppQndZWGx0Wlc1MFgyTnZkVzUwSUQ0OUlGVkpiblEyTkNoVVNVVlNYekZmVkVoU1JWTklUMHhFS1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ1BqMEtJQ0FnSUdKNklGOW5aWFJmZEdsbGNsOWxiSE5sWDJKdlpIbEFOZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pZMU9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSE4xWWdvS1gyZGxkRjkwYVdWeVgyVnNjMlZmWW05a2VVQTJPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk52Ym5SeVlXTjBMbkI1T2pZMk1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUpBQUVDSUlDakJZQ0plcURDSHNDV3NRS2dqUVltRFJCMGNtVmhjM1Z5ZVY5aVlXeGhibU5sQzI5MWRITjBZVzVrYVc1bkRYQmhlVzFsYm5SZlkyOTFiblFNYzNSaGEyVmZZVzF2ZFc1MERHbHpYMlJsWm1GMWJIUmxaQXRrWVdsc2VWOWtjbUYzYmhKc1lYTjBYM0JoZVcxbGJuUmZjbTkxYm1RTWRHOTBZV3hmY21Wd1lXbGtEMlJoZVY5emRHRnlkRjl5YjNWdVpBNXlaWEJoZVY5aWVWOXliM1Z1WkF4MGIzUmhiRjloWjJWdWRITVFjMnRwY0Y5aGRIUmxjM1JoZEdsdmJnUVZIM3gxTVJoQUFBc29JbWNuQ2lKbkp3c2paekViUVFCT01Sa1VSREVZUklJSkJQQkEzUTBFSzRrR3dnUVJHVFhJQlBsK255Y0VpQ1NkY0FRVE1LNzNCTE9IYmlvRXRWMmNrUVI4cjY3ek5ob0FqZ2tBUmdEREFSTUNuQU1TQTRZRUp3Uk1CRzhBTVJtTkFnQTVBQUVBTVJoRU1RQXJJbVl4QUNvaVpqRUFKd2NpWmpFQUtTSm1NUUFuQkNKbU1RQW5CaUptTVFBbkJTSm1NUUFuQ0NKbU1RQW5DU0ptSTBNeEdCUkRNUllqQ1VrNEVDTVNSRWs0QnpJS0VrUTRDRW1Cd0lROUQwUXhBQ0lyWTBRVVJERUFLMHNDWmpFQUtpSm1NUUFuQnlKbU1RQXBJbVl4QUNjRUltWXhBQ2NHTWdabU1RQW5CU0ptTVFBbkNESUdaakVBSndraVppSW9aVVJMQVFnb1RHY2lKd3BsUkNNSUp3cE1aekVBVEJaUWdBU0pOYStkVEZDd0kwTTJHZ0ZKRllFSUVrUXhBQ0luQkdORUZFUXhBQ0lyWTBSRU1RQkpJaXBqUkNNSUtreG1NUUFuQmpJR1pqRUFJaXBqUklnRGd6RUFUQlpNVHdKUVN3RlFnQVRDVTErbFRGQ3dKd3hNVUxBalE0QUFSd0kyR2dGSEFoV0JDQkpFTmhvQ1NVNENGU1VTUkRFQUlpY0VZMFFVUkRFQUlpdGpSRVFYTWdZaUp3dGxSRUFBRGpFQVN3UlFTd0VXVUFGTEF4SkVNUUFpSndoalJFc0JUQWtoQkE5QkFBMHhBQ2NGSW1ZeEFDY0lTd0ptTVFBaUttTkVpQU1BU1VVSGdRTVNTVVVHUVFEc1N3RWhCdzVFTVFBaUp3VmpSRXNDQ0VVSFN3UkJBS2xMQm9IQThQVUxEa1F5Q25NQVJFc0NEMFJMQkVFQWNvR1FBMHNDU1U4Q0N5RUVDNEdBOEs3bmxna0tzVElBTVFCTEE3SUlzZ2Nqc2hDeUFiTXhBQ2NGU3dwbU1RQkpJaWxqUkVzRFN3TUlDQ2xNWmtzQ0lRUUlNUUFuQ1U4Q1ppSW9aVVJQQWdrb1RHY3hBRXdXTVFBaUtXTkVGazhDU3daUVR3SlFURkNBQkNwa0RaRk1VTEFqUTBzRkpCSkJBQWFCaEFkQy80UkxCU01TUVFBR2djQU1RdjkzZ2VBU1F2OXhTd1VrRWtFQURFc0dnWUN0NGdRT1JFTC9UVXNGSXhKQkFBbExCaUVGRGtSQy96MUxCaUVHRGtSQy96UkxCU1FTUVFBSlN3RWhCUTVFUXY4S1N3VWpFa0VBQ1VzQklRWU9SRUwrK2tzQklRZ09SRUwrOFRFV0l3bEpPQkFqRWtSSk9BY3lDaEpFT0FoSEFrUXhBQ0lwWTB4SlRnSk9BMFFQUVFCRE1RQXBJbVl4QUVraUp3ZGpSRXNEU1U0RENDY0hUR1lpS0dWRVN3RUlLRXhuTVFBbkJqSUdaakVBVEJZeEFDSXBZMFFXVGdKUVRGQ0FCRlNXV3BOTVVMQWpRMGxMQWdreEFDbFBBbVpDLzdVMkdnRkhBaFVsRWtSSklpbGpSRVJKSWlwalJESUdUd0lpSndaalJBbE1RUUFIU1lFZURVRUFSeU5FU3dGSklpdGpSRW1CQ2dwS0NVc0RKd1FqWmtzREt5Sm1JaWhsUkFnb1RHZXhNZ0F4QUVzQ3NnaXlCeU95RUxJQnMwd1dUQlpPQWxCTVVJQUVVUDNHU2t4UXNDTkRJa0wvdG9BQU5ob0JSd0lWSlJKRUlpcGpSSWdBNDBtQkF4SkJBRjRoQjRHUUEwVUVTd0pKSWl0alJCWkxBU0lxWTBRV1R3TVdTd01pS1dORUZrc0VJaWNFWTBRV1N3WVdTd2tXU3djaUp3VmpSQlpQQ0NJbkNXTkVGazhJVHdoUVR3ZFFUd1pRVHdWUVR3UlFUd05RVHdKUVRGQW5ERXhRc0NORFNTUVNRUUFLSVFXQmhBZEZCRUwvbVVrakVrRUFDaUVHZ2NBTVJRUkMvNGtoQ0lIZ0VrVUVRdjkvTVJZakNVazRFQ01TUkRFQU1na1NSRWs0QnpJS0VrUTRDRWxFSWlobFJBZ29UR2NqUXpZYUFVa1ZKUkpFTVFBeUNSSkVnQTl3Y205MGIyTnZiRjl6YVdkdVpYSk1aeU5ETVFBeUNSSkVKd3NpWnlORGlnRUJpLytCWkE5QkFBT0JBNG1MLzRFeUQwRUFBaVNKaS8rQkNnOUJBQUlqaVNLSiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IkFnZW50UmVnaXN0ZXJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFrZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUGF5bWVudFJlY29yZGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpZXIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkNyZWRpdERyYXduIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVyZXN0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3V0c3RhbmRpbmciLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJlcGFpZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvdXRzdGFuZGluZyIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQWdlbnRTbGFzaGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YWtlX2J1cm5lZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbGxlcl9yZXdhcmQiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
