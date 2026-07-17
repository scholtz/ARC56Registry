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

namespace Arc56.Generated.ansu555.Algorand_prototype_v0_0_1.AutoPilotRuleContract_22c79096
{


    //
    // 
    //    AutoPilot Rule Engine for automated trading strategies
    //    
    //    Enables users to create automated trading rules that execute
    //    when specific market conditions are met.
    //    
    //
    public class AutoPilotRuleContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AutoPilotRuleContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class RuleData : AVMObjectType
            {
                public ulong RuleId { get; set; }

                public Algorand.Address Owner { get; set; }

                public byte RuleType { get; set; }

                public byte Status { get; set; }

                public ulong[] TargetAssets { get; set; }

                public byte RotateTopN { get; set; }

                public ulong MaxSpendMicroalgos { get; set; }

                public ushort MaxSlippageBps { get; set; }

                public ushort CooldownMinutes { get; set; }

                public Structs.TriggerData Trigger { get; set; } = new Structs.TriggerData();

                public ulong LastExecutionTimestamp { get; set; }

                public uint TotalExecutions { get; set; }

                public ulong TotalSpentMicroalgos { get; set; }

                public ulong CreatedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRuleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRuleId.From(RuleId);
                    ret.AddRange(vRuleId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRuleType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vRuleType.From(RuleType);
                    ret.AddRange(vRuleType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTargetAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vTargetAssets.From(TargetAssets);
                    ret.AddRange(vTargetAssets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRotateTopN = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vRotateTopN.From(RotateTopN);
                    ret.AddRange(vRotateTopN.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxSpendMicroalgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxSpendMicroalgos.From(MaxSpendMicroalgos);
                    ret.AddRange(vMaxSpendMicroalgos.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxSlippageBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vMaxSlippageBps.From(MaxSlippageBps);
                    ret.AddRange(vMaxSlippageBps.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCooldownMinutes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vCooldownMinutes.From(CooldownMinutes);
                    ret.AddRange(vCooldownMinutes.Encode());
                    ret.AddRange(Trigger.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastExecutionTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastExecutionTimestamp.From(LastExecutionTimestamp);
                    ret.AddRange(vLastExecutionTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalExecutions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vTotalExecutions.From(TotalExecutions);
                    ret.AddRange(vTotalExecutions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalSpentMicroalgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalSpentMicroalgos.From(TotalSpentMicroalgos);
                    ret.AddRange(vTotalSpentMicroalgos.Encode());
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

                public static RuleData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new RuleData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRuleId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRuleId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRuleId = vRuleId.ToValue();
                    if (valueRuleId is ulong vRuleIdValue) { ret.RuleId = vRuleIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRuleType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vRuleType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRuleType = vRuleType.ToValue();
                    if (valueRuleType is byte vRuleTypeValue) { ret.RuleType = vRuleTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is byte vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTargetAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vTargetAssets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTargetAssets = vTargetAssets.ToValue();
                    if (valueTargetAssets is ulong[] vTargetAssetsValue) { ret.TargetAssets = vTargetAssetsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRotateTopN = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vRotateTopN.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRotateTopN = vRotateTopN.ToValue();
                    if (valueRotateTopN is byte vRotateTopNValue) { ret.RotateTopN = vRotateTopNValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxSpendMicroalgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxSpendMicroalgos.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxSpendMicroalgos = vMaxSpendMicroalgos.ToValue();
                    if (valueMaxSpendMicroalgos is ulong vMaxSpendMicroalgosValue) { ret.MaxSpendMicroalgos = vMaxSpendMicroalgosValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxSlippageBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vMaxSlippageBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxSlippageBps = vMaxSlippageBps.ToValue();
                    if (valueMaxSlippageBps is ushort vMaxSlippageBpsValue) { ret.MaxSlippageBps = vMaxSlippageBpsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCooldownMinutes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vCooldownMinutes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCooldownMinutes = vCooldownMinutes.ToValue();
                    if (valueCooldownMinutes is ushort vCooldownMinutesValue) { ret.CooldownMinutes = vCooldownMinutesValue; }
                    ret.Trigger = Structs.TriggerData.Parse(queue.ToArray());
                    { var consumedTrigger = ret.Trigger.ToByteArray().Length; for (int i = 0; i < consumedTrigger && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastExecutionTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastExecutionTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastExecutionTimestamp = vLastExecutionTimestamp.ToValue();
                    if (valueLastExecutionTimestamp is ulong vLastExecutionTimestampValue) { ret.LastExecutionTimestamp = vLastExecutionTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalExecutions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vTotalExecutions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalExecutions = vTotalExecutions.ToValue();
                    if (valueTotalExecutions is uint vTotalExecutionsValue) { ret.TotalExecutions = vTotalExecutionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalSpentMicroalgos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalSpentMicroalgos.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalSpentMicroalgos = vTotalSpentMicroalgos.ToValue();
                    if (valueTotalSpentMicroalgos is ulong vTotalSpentMicroalgosValue) { ret.TotalSpentMicroalgos = vTotalSpentMicroalgosValue; }
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
                    return Equals(obj as RuleData);
                }
                public bool Equals(RuleData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(RuleData left, RuleData right)
                {
                    return EqualityComparer<RuleData>.Default.Equals(left, right);
                }
                public static bool operator !=(RuleData left, RuleData right)
                {
                    return !(left == right);
                }

            }

            public class TriggerData : AVMObjectType
            {
                public byte TriggerType { get; set; }

                public ushort ThresholdBps { get; set; }

                public ushort WindowHours { get; set; }

                public byte LookbackDays { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTriggerType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vTriggerType.From(TriggerType);
                    ret.AddRange(vTriggerType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vThresholdBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vThresholdBps.From(ThresholdBps);
                    ret.AddRange(vThresholdBps.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWindowHours = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vWindowHours.From(WindowHours);
                    ret.AddRange(vWindowHours.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLookbackDays = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vLookbackDays.From(LookbackDays);
                    ret.AddRange(vLookbackDays.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TriggerData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TriggerData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTriggerType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vTriggerType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTriggerType = vTriggerType.ToValue();
                    if (valueTriggerType is byte vTriggerTypeValue) { ret.TriggerType = vTriggerTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vThresholdBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vThresholdBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueThresholdBps = vThresholdBps.ToValue();
                    if (valueThresholdBps is ushort vThresholdBpsValue) { ret.ThresholdBps = vThresholdBpsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWindowHours = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vWindowHours.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWindowHours = vWindowHours.ToValue();
                    if (valueWindowHours is ushort vWindowHoursValue) { ret.WindowHours = vWindowHoursValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLookbackDays = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vLookbackDays.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLookbackDays = vLookbackDays.ToValue();
                    if (valueLookbackDays is byte vLookbackDaysValue) { ret.LookbackDays = vLookbackDaysValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TriggerData);
                }
                public bool Equals(TriggerData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TriggerData left, TriggerData right)
                {
                    return EqualityComparer<TriggerData>.Default.Equals(left, right);
                }
                public static bool operator !=(TriggerData left, TriggerData right)
                {
                    return !(left == right);
                }

            }

            public class GetRuleStatsReturn : AVMObjectType
            {
                public uint Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetRuleStatsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetRuleStatsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is uint vField0Value) { ret.Field0 = vField0Value; }
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

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetRuleStatsReturn);
                }
                public bool Equals(GetRuleStatsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetRuleStatsReturn left, GetRuleStatsReturn right)
                {
                    return EqualityComparer<GetRuleStatsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetRuleStatsReturn left, GetRuleStatsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetContractStatsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ushort Field2 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetContractStatsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetContractStatsReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ushort vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetContractStatsReturn);
                }
                public bool Equals(GetContractStatsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetContractStatsReturn left, GetContractStatsReturn right)
                {
                    return EqualityComparer<GetContractStatsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetContractStatsReturn left, GetContractStatsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the contract on creation
        ///</summary>
        public async Task<string> CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 173, 194, 92 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 173, 194, 92 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a new AutoPilot rule
        ///</summary>
        /// <param name="rule_type">1=DCA, 2=REBALANCE, 3=ROTATE </param>
        /// <param name="target_assets">Asset IDs to trade </param>
        /// <param name="rotate_top_n">For ROTATE: top N assets </param>
        /// <param name="max_spend_microalgos">Max spend per execution </param>
        /// <param name="max_slippage_bps">Max slippage in basis points </param>
        /// <param name="cooldown_minutes">Cooldown period between executions </param>
        /// <param name="trigger_type">1=price_drop, 2=trend, 3=momentum </param>
        /// <param name="threshold_bps">Trigger threshold in basis points </param>
        /// <param name="window_hours">Time window for trend/momentum triggers </param>
        /// <param name="payment">Payment to cover box storage costs </param>
        public async Task<ulong> CreateRule(PaymentTransaction payment, byte rule_type, ulong[] target_assets, byte rotate_top_n, ulong max_spend_microalgos, ushort max_slippage_bps, ushort cooldown_minutes, byte trigger_type, ushort threshold_bps, ushort window_hours, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 35, 4, 239, 158 };
            var rule_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); rule_typeAbi.From(rule_type);
            var target_assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); target_assetsAbi.From(target_assets);
            var rotate_top_nAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); rotate_top_nAbi.From(rotate_top_n);
            var max_spend_microalgosAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_spend_microalgosAbi.From(max_spend_microalgos);
            var max_slippage_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); max_slippage_bpsAbi.From(max_slippage_bps);
            var cooldown_minutesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); cooldown_minutesAbi.From(cooldown_minutes);
            var trigger_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); trigger_typeAbi.From(trigger_type);
            var threshold_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); threshold_bpsAbi.From(threshold_bps);
            var window_hoursAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); window_hoursAbi.From(window_hours);

            var result = await base.CallApp(new List<object> { abiHandle, rule_typeAbi, target_assetsAbi, rotate_top_nAbi, max_spend_microalgosAbi, max_slippage_bpsAbi, cooldown_minutesAbi, trigger_typeAbi, threshold_bpsAbi, window_hoursAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateRule_Transactions(PaymentTransaction payment, byte rule_type, ulong[] target_assets, byte rotate_top_n, ulong max_spend_microalgos, ushort max_slippage_bps, ushort cooldown_minutes, byte trigger_type, ushort threshold_bps, ushort window_hours, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 35, 4, 239, 158 };
            var rule_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); rule_typeAbi.From(rule_type);
            var target_assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); target_assetsAbi.From(target_assets);
            var rotate_top_nAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); rotate_top_nAbi.From(rotate_top_n);
            var max_spend_microalgosAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_spend_microalgosAbi.From(max_spend_microalgos);
            var max_slippage_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); max_slippage_bpsAbi.From(max_slippage_bps);
            var cooldown_minutesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); cooldown_minutesAbi.From(cooldown_minutes);
            var trigger_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); trigger_typeAbi.From(trigger_type);
            var threshold_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); threshold_bpsAbi.From(threshold_bps);
            var window_hoursAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); window_hoursAbi.From(window_hours);

            return await base.MakeTransactionList(new List<object> { abiHandle, rule_typeAbi, target_assetsAbi, rotate_top_nAbi, max_spend_microalgosAbi, max_slippage_bpsAbi, cooldown_minutesAbi, trigger_typeAbi, threshold_bpsAbi, window_hoursAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Execute an AutoPilot rule
        ///This method executes a single swap for the rule. For multiple assets, this should be called multiple times (can be grouped).
        ///Expected atomic group: [0] Payment/AssetTransfer from user to this contract (asset_in) [1] App call to this method
        ///</summary>
        /// <param name="rule_id">Rule to execute </param>
        /// <param name="owner">Rule owner address </param>
        /// <param name="asset_in">Asset to swap from (typically ALGO) </param>
        /// <param name="asset_out">Asset to swap to </param>
        /// <param name="amount_in">Amount to swap </param>
        /// <param name="min_amount_out">Minimum output (slippage protection) </param>
        /// <param name="swap_router_app">DEX adapter application ID (Tinyman/Pact adapter) </param>
        /// <param name="pool_app">DEX pool application ID </param>
        public async Task<ulong> ExecuteRule(ulong rule_id, Algorand.Address owner, ulong asset_in, ulong asset_out, ulong amount_in, ulong min_amount_out, ulong swap_router_app, ulong pool_app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 111, 128, 23 };
            var rule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rule_idAbi.From(rule_id);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var asset_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_inAbi.From(asset_in);
            var asset_outAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_outAbi.From(asset_out);
            var amount_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inAbi.From(amount_in);
            var min_amount_outAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_amount_outAbi.From(min_amount_out);
            var swap_router_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); swap_router_appAbi.From(swap_router_app);
            var pool_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pool_appAbi.From(pool_app);

            var result = await base.CallApp(new List<object> { abiHandle, rule_idAbi, ownerAbi, asset_inAbi, asset_outAbi, amount_inAbi, min_amount_outAbi, swap_router_appAbi, pool_appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ExecuteRule_Transactions(ulong rule_id, Algorand.Address owner, ulong asset_in, ulong asset_out, ulong amount_in, ulong min_amount_out, ulong swap_router_app, ulong pool_app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 111, 128, 23 };
            var rule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rule_idAbi.From(rule_id);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var asset_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_inAbi.From(asset_in);
            var asset_outAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_outAbi.From(asset_out);
            var amount_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inAbi.From(amount_in);
            var min_amount_outAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_amount_outAbi.From(min_amount_out);
            var swap_router_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); swap_router_appAbi.From(swap_router_app);
            var pool_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pool_appAbi.From(pool_app);

            return await base.MakeTransactionList(new List<object> { abiHandle, rule_idAbi, ownerAbi, asset_inAbi, asset_outAbi, amount_inAbi, min_amount_outAbi, swap_router_appAbi, pool_appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Pause, resume, or cancel a rule
        ///</summary>
        /// <param name="rule_id">Rule to update </param>
        /// <param name="new_status">1=active, 2=paused, 3=cancelled </param>
        public async Task UpdateRuleStatus(ulong rule_id, byte new_status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 35, 115, 232 };
            var rule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rule_idAbi.From(rule_id);
            var new_statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); new_statusAbi.From(new_status);

            var result = await base.CallApp(new List<object> { abiHandle, rule_idAbi, new_statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateRuleStatus_Transactions(ulong rule_id, byte new_status, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 100, 35, 115, 232 };
            var rule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rule_idAbi.From(rule_id);
            var new_statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); new_statusAbi.From(new_status);

            return await base.MakeTransactionList(new List<object> { abiHandle, rule_idAbi, new_statusAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update rule risk parameters
        ///</summary>
        /// <param name="rule_id">Rule to update </param>
        /// <param name="max_spend_microalgos">New max spend limit </param>
        /// <param name="max_slippage_bps">New max slippage </param>
        /// <param name="cooldown_minutes">New cooldown period </param>
        public async Task UpdateRuleParameters(ulong rule_id, ulong max_spend_microalgos, ushort max_slippage_bps, ushort cooldown_minutes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 225, 192, 246 };
            var rule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rule_idAbi.From(rule_id);
            var max_spend_microalgosAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_spend_microalgosAbi.From(max_spend_microalgos);
            var max_slippage_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); max_slippage_bpsAbi.From(max_slippage_bps);
            var cooldown_minutesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); cooldown_minutesAbi.From(cooldown_minutes);

            var result = await base.CallApp(new List<object> { abiHandle, rule_idAbi, max_spend_microalgosAbi, max_slippage_bpsAbi, cooldown_minutesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateRuleParameters_Transactions(ulong rule_id, ulong max_spend_microalgos, ushort max_slippage_bps, ushort cooldown_minutes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 225, 192, 246 };
            var rule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rule_idAbi.From(rule_id);
            var max_spend_microalgosAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_spend_microalgosAbi.From(max_spend_microalgos);
            var max_slippage_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); max_slippage_bpsAbi.From(max_slippage_bps);
            var cooldown_minutesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); cooldown_minutesAbi.From(cooldown_minutes);

            return await base.MakeTransactionList(new List<object> { abiHandle, rule_idAbi, max_spend_microalgosAbi, max_slippage_bpsAbi, cooldown_minutesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete a rule and reclaim box storage MBR
        ///</summary>
        /// <param name="rule_id">Rule to delete </param>
        public async Task DeleteRule(ulong rule_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 172, 49, 161 };
            var rule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rule_idAbi.From(rule_id);

            var result = await base.CallApp(new List<object> { abiHandle, rule_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteRule_Transactions(ulong rule_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 172, 49, 161 };
            var rule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rule_idAbi.From(rule_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, rule_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieve rule details
        ///</summary>
        /// <param name="rule_id">Rule ID to fetch </param>
        /// <param name="owner">Rule owner address </param>
        public async Task<Structs.RuleData> GetRule(ulong rule_id, Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 62, 69, 68 };
            var rule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rule_idAbi.From(rule_id);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, rule_idAbi, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.RuleData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRule_Transactions(ulong rule_id, Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 62, 69, 68 };
            var rule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rule_idAbi.From(rule_id);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, rule_idAbi, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get rule execution statistics
        ///</summary>
        /// <param name="rule_id">Rule ID </param>
        /// <param name="owner">Rule owner address </param>
        public async Task<Structs.GetRuleStatsReturn> GetRuleStats(ulong rule_id, Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 147, 134, 16 };
            var rule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rule_idAbi.From(rule_id);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, rule_idAbi, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetRuleStatsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRuleStats_Transactions(ulong rule_id, Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 147, 134, 16 };
            var rule_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rule_idAbi.From(rule_id);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, rule_idAbi, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update protocol fee (admin only)
        ///</summary>
        /// <param name="new_fee_bps">New fee in basis points (max 1% = 100 bps) </param>
        public async Task SetProtocolFee(ushort new_fee_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 228, 16, 22 };
            var new_fee_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); new_fee_bpsAbi.From(new_fee_bps);

            var result = await base.CallApp(new List<object> { abiHandle, new_fee_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetProtocolFee_Transactions(ushort new_fee_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 228, 16, 22 };
            var new_fee_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); new_fee_bpsAbi.From(new_fee_bps);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_fee_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opt the contract into an asset (admin only)
        ///This is required before the contract can receive and hold ASAs
        ///</summary>
        /// <param name="asset">The asset to opt into </param>
        public async Task OptInAsset(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 205, 239, 59 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInAsset_Transactions(ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 205, 239, 59 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Emergency pause/unpause (admin only)
        ///</summary>
        /// <param name="paused">True to pause, False to unpause </param>
        public async Task SetPause(bool paused, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 89, 153, 88 };
            var pausedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); pausedAbi.From(paused);

            var result = await base.CallApp(new List<object> { abiHandle, pausedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPause_Transactions(bool paused, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 238, 89, 153, 88 };
            var pausedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); pausedAbi.From(paused);

            return await base.MakeTransactionList(new List<object> { abiHandle, pausedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get global contract statistics
        ///</summary>
        public async Task<Structs.GetContractStatsReturn> GetContractStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 231, 41, 123 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetContractStatsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetContractStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 231, 41, 123 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXV0b1BpbG90UnVsZUNvbnRyYWN0IiwiZGVzYyI6IlxuICAgIEF1dG9QaWxvdCBSdWxlIEVuZ2luZSBmb3IgYXV0b21hdGVkIHRyYWRpbmcgc3RyYXRlZ2llc1xuICAgIFxuICAgIEVuYWJsZXMgdXNlcnMgdG8gY3JlYXRlIGF1dG9tYXRlZCB0cmFkaW5nIHJ1bGVzIHRoYXQgZXhlY3V0ZVxuICAgIHdoZW4gc3BlY2lmaWMgbWFya2V0IGNvbmRpdGlvbnMgYXJlIG1ldC5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUnVsZURhdGEiOlt7Im5hbWUiOiJydWxlX2lkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im93bmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJydWxlX3R5cGUiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJ0YXJnZXRfYXNzZXRzIiwidHlwZSI6InVpbnQ2NFtdIn0seyJuYW1lIjoicm90YXRlX3RvcF9uIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoibWF4X3NwZW5kX21pY3JvYWxnb3MiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWF4X3NsaXBwYWdlX2JwcyIsInR5cGUiOiJ1aW50MTYifSx7Im5hbWUiOiJjb29sZG93bl9taW51dGVzIiwidHlwZSI6InVpbnQxNiJ9LHsibmFtZSI6InRyaWdnZXIiLCJ0eXBlIjoiVHJpZ2dlckRhdGEifSx7Im5hbWUiOiJsYXN0X2V4ZWN1dGlvbl90aW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfZXhlY3V0aW9ucyIsInR5cGUiOiJ1aW50MzIifSx7Im5hbWUiOiJ0b3RhbF9zcGVudF9taWNyb2FsZ29zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNyZWF0ZWRfYXQiLCJ0eXBlIjoidWludDY0In1dLCJUcmlnZ2VyRGF0YSI6W3sibmFtZSI6InRyaWdnZXJfdHlwZSIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6InRocmVzaG9sZF9icHMiLCJ0eXBlIjoidWludDE2In0seyJuYW1lIjoid2luZG93X2hvdXJzIiwidHlwZSI6InVpbnQxNiJ9LHsibmFtZSI6Imxvb2tiYWNrX2RheXMiLCJ0eXBlIjoidWludDgifV0sIkdldFJ1bGVTdGF0c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50MzIifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0Q29udHJhY3RTdGF0c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQxNiJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfYXBwbGljYXRpb24iLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgY29udHJhY3Qgb24gY3JlYXRpb24iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfcnVsZSIsImRlc2MiOiJDcmVhdGUgYSBuZXcgQXV0b1BpbG90IHJ1bGUiLCJhcmdzIjpbeyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJydWxlX3R5cGUiLCJkZXNjIjoiMT1EQ0EsIDI9UkVCQUxBTkNFLCAzPVJPVEFURSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXRfYXNzZXRzIiwiZGVzYyI6IkFzc2V0IElEcyB0byB0cmFkZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb3RhdGVfdG9wX24iLCJkZXNjIjoiRm9yIFJPVEFURTogdG9wIE4gYXNzZXRzIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXhfc3BlbmRfbWljcm9hbGdvcyIsImRlc2MiOiJNYXggc3BlbmQgcGVyIGV4ZWN1dGlvbiIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDE2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF4X3NsaXBwYWdlX2JwcyIsImRlc2MiOiJNYXggc2xpcHBhZ2UgaW4gYmFzaXMgcG9pbnRzIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb29sZG93bl9taW51dGVzIiwiZGVzYyI6IkNvb2xkb3duIHBlcmlvZCBiZXR3ZWVuIGV4ZWN1dGlvbnMiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidHJpZ2dlcl90eXBlIiwiZGVzYyI6IjE9cHJpY2VfZHJvcCwgMj10cmVuZCwgMz1tb21lbnR1bSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDE2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGhyZXNob2xkX2JwcyIsImRlc2MiOiJUcmlnZ2VyIHRocmVzaG9sZCBpbiBiYXNpcyBwb2ludHMiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQxNiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndpbmRvd19ob3VycyIsImRlc2MiOiJUaW1lIHdpbmRvdyBmb3IgdHJlbmQvbW9tZW50dW0gdHJpZ2dlcnMiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjoiUGF5bWVudCB0byBjb3ZlciBib3ggc3RvcmFnZSBjb3N0cyIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJVbmlxdWUgaWRlbnRpZmllciBmb3IgdGhlIGNyZWF0ZWQgcnVsZSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4ZWN1dGVfcnVsZSIsImRlc2MiOiJFeGVjdXRlIGFuIEF1dG9QaWxvdCBydWxlXG5UaGlzIG1ldGhvZCBleGVjdXRlcyBhIHNpbmdsZSBzd2FwIGZvciB0aGUgcnVsZS4gRm9yIG11bHRpcGxlIGFzc2V0cywgdGhpcyBzaG91bGQgYmUgY2FsbGVkIG11bHRpcGxlIHRpbWVzIChjYW4gYmUgZ3JvdXBlZCkuXG5FeHBlY3RlZCBhdG9taWMgZ3JvdXA6IFswXSBQYXltZW50L0Fzc2V0VHJhbnNmZXIgZnJvbSB1c2VyIHRvIHRoaXMgY29udHJhY3QgKGFzc2V0X2luKSBbMV0gQXBwIGNhbGwgdG8gdGhpcyBtZXRob2QiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicnVsZV9pZCIsImRlc2MiOiJSdWxlIHRvIGV4ZWN1dGUiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOiJSdWxlIG93bmVyIGFkZHJlc3MiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2luIiwiZGVzYyI6IkFzc2V0IHRvIHN3YXAgZnJvbSAodHlwaWNhbGx5IEFMR08pIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9vdXQiLCJkZXNjIjoiQXNzZXQgdG8gc3dhcCB0byIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50X2luIiwiZGVzYyI6IkFtb3VudCB0byBzd2FwIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaW5fYW1vdW50X291dCIsImRlc2MiOiJNaW5pbXVtIG91dHB1dCAoc2xpcHBhZ2UgcHJvdGVjdGlvbikiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN3YXBfcm91dGVyX2FwcCIsImRlc2MiOiJERVggYWRhcHRlciBhcHBsaWNhdGlvbiBJRCAoVGlueW1hbi9QYWN0IGFkYXB0ZXIpIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sX2FwcCIsImRlc2MiOiJERVggcG9vbCBhcHBsaWNhdGlvbiBJRCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJBbW91bnQgb2YgYXNzZXRfaW4gc3BlbnQifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfcnVsZV9zdGF0dXMiLCJkZXNjIjoiUGF1c2UsIHJlc3VtZSwgb3IgY2FuY2VsIGEgcnVsZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJydWxlX2lkIiwiZGVzYyI6IlJ1bGUgdG8gdXBkYXRlIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19zdGF0dXMiLCJkZXNjIjoiMT1hY3RpdmUsIDI9cGF1c2VkLCAzPWNhbmNlbGxlZCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfcnVsZV9wYXJhbWV0ZXJzIiwiZGVzYyI6IlVwZGF0ZSBydWxlIHJpc2sgcGFyYW1ldGVycyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJydWxlX2lkIiwiZGVzYyI6IlJ1bGUgdG8gdXBkYXRlIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXhfc3BlbmRfbWljcm9hbGdvcyIsImRlc2MiOiJOZXcgbWF4IHNwZW5kIGxpbWl0IiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXhfc2xpcHBhZ2VfYnBzIiwiZGVzYyI6Ik5ldyBtYXggc2xpcHBhZ2UiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQxNiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvb2xkb3duX21pbnV0ZXMiLCJkZXNjIjoiTmV3IGNvb2xkb3duIHBlcmlvZCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVfcnVsZSIsImRlc2MiOiJEZWxldGUgYSBydWxlIGFuZCByZWNsYWltIGJveCBzdG9yYWdlIE1CUiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJydWxlX2lkIiwiZGVzYyI6IlJ1bGUgdG8gZGVsZXRlIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ydWxlIiwiZGVzYyI6IlJldHJpZXZlIHJ1bGUgZGV0YWlscyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJydWxlX2lkIiwiZGVzYyI6IlJ1bGUgSUQgdG8gZmV0Y2giLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOiJSdWxlIG93bmVyIGFkZHJlc3MiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLHVpbnQ4LHVpbnQ4LHVpbnQ2NFtdLHVpbnQ4LHVpbnQ2NCx1aW50MTYsdWludDE2LCh1aW50OCx1aW50MTYsdWludDE2LHVpbnQ4KSx1aW50NjQsdWludDMyLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiUnVsZURhdGEiLCJkZXNjIjoiQ29tcGxldGUgcnVsZSBjb25maWd1cmF0aW9uIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcnVsZV9zdGF0cyIsImRlc2MiOiJHZXQgcnVsZSBleGVjdXRpb24gc3RhdGlzdGljcyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJydWxlX2lkIiwiZGVzYyI6IlJ1bGUgSUQiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOiJSdWxlIG93bmVyIGFkZHJlc3MiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQzMix1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFJ1bGVTdGF0c1JldHVybiIsImRlc2MiOiJUdXBsZSBvZiAodG90YWxfZXhlY3V0aW9ucywgdG90YWxfc3BlbnQsIGxhc3RfZXhlY3V0aW9uX3RpbWVzdGFtcCkifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9wcm90b2NvbF9mZWUiLCJkZXNjIjoiVXBkYXRlIHByb3RvY29sIGZlZSAoYWRtaW4gb25seSkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDE2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2ZlZV9icHMiLCJkZXNjIjoiTmV3IGZlZSBpbiBiYXNpcyBwb2ludHMgKG1heCAxJSA9IDEwMCBicHMpIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wdF9pbl9hc3NldCIsImRlc2MiOiJPcHQgdGhlIGNvbnRyYWN0IGludG8gYW4gYXNzZXQgKGFkbWluIG9ubHkpXG5UaGlzIGlzIHJlcXVpcmVkIGJlZm9yZSB0aGUgY29udHJhY3QgY2FuIHJlY2VpdmUgYW5kIGhvbGQgQVNBcyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOiJUaGUgYXNzZXQgdG8gb3B0IGludG8iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X3BhdXNlIiwiZGVzYyI6IkVtZXJnZW5jeSBwYXVzZS91bnBhdXNlIChhZG1pbiBvbmx5KSIsImFyZ3MiOlt7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF1c2VkIiwiZGVzYyI6IlRydWUgdG8gcGF1c2UsIEZhbHNlIHRvIHVucGF1c2UiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2NvbnRyYWN0X3N0YXRzIiwiZGVzYyI6IkdldCBnbG9iYWwgY29udHJhY3Qgc3RhdGlzdGljcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50MTYpIiwic3RydWN0IjoiR2V0Q29udHJhY3RTdGF0c1JldHVybiIsImRlc2MiOiJUdXBsZSBvZiAodG90YWxfcnVsZXNfY3JlYXRlZCwgdG90YWxfZXhlY3V0aW9ucywgcHJvdG9jb2xfZmVlX2JwcykifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo0LCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNzE1XSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEwOV0sImVycm9yTWVzc2FnZSI6IkNhbm5vdCBtb2RpZnkgY2FuY2VsbGVkIHJ1bGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjIsNzQ2XSwiZXJyb3JNZXNzYWdlIjoiQ29udHJhY3QgaXMgcGF1c2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzcwXSwiZXJyb3JNZXNzYWdlIjoiQ29vbGRvd24gcGVyaW9kIG5vdCBtZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjE4XSwiZXJyb3JNZXNzYWdlIjoiQ29vbGRvd24gdG9vIHNob3J0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUxXSwiZXJyb3JNZXNzYWdlIjoiQ29vbGRvd24gdG9vIHNob3J0IChtaW4gNSBtaW51dGVzKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5NV0sImVycm9yTWVzc2FnZSI6IkV4Y2VlZHMgbWF4IHNwZW5kIGxpbWl0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI4OF0sImVycm9yTWVzc2FnZSI6IkZhaWxlZCB0byBkZWxldGUgYm94IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQyM10sImVycm9yTWVzc2FnZSI6IkZlZSB0b28gaGlnaCAobWF4IDElKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMzVdLCJlcnJvck1lc3NhZ2UiOiJGaXJzdCB0eG4gbXVzdCBiZSBhc3NldCB0cmFuc2ZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5N10sImVycm9yTWVzc2FnZSI6IkZpcnN0IHR4biBtdXN0IGJlIHBheW1lbnQgZm9yIEFMR08iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzNdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgcGF5bWVudCBmb3IgYm94IHN0b3JhZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODhdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIGdyb3VwIHNpemUgKGV4cGVjdGVkIDIpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI5XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBydWxlIHR5cGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTAwXSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBzdGF0dXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NThdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIHRyaWdnZXIgdHlwZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNiwxMjAzXSwiZXJyb3JNZXNzYWdlIjoiTWF4IHNwZW5kIG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMyXSwiZXJyb3JNZXNzYWdlIjoiTXVzdCBoYXZlIHRhcmdldCBhc3NldHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MDRdLCJlcnJvck1lc3NhZ2UiOiJNdXN0IHNlbmQgQUxHTyB0byBjb250cmFjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNDldLCJlcnJvck1lc3NhZ2UiOiJNdXN0IHNlbmQgdG8gY29udHJhY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDkyLDExOTksMTI4Nl0sImVycm9yTWVzc2FnZSI6Ik5vdCBydWxlIG93bmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMyXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4Ml0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5MCwxNDE3LDE0NzEsMTUxNF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4OTVdLCJlcnJvck1lc3NhZ2UiOiJPdXRwdXQgYmVsb3cgbWluaW11bSAoc2xpcHBhZ2UgZXhjZWVkZWQpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDY1XSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBtdXN0IGJlIHRvIGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk1XSwiZXJyb3JNZXNzYWdlIjoiUHJvdmlkZSBleGFjdGx5IG9uZSBhc3NldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1M10sImVycm9yTWVzc2FnZSI6IlJ1bGUgbm90IGFjdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczOSwxMDg0LDExOTEsMTI3OSwxMzQ3LDEzNzZdLCJlcnJvck1lc3NhZ2UiOiJSdWxlIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMTFdLCJlcnJvck1lc3NhZ2UiOiJTbGlwcGFnZSB0b28gaGlnaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0NF0sImVycm9yTWVzc2FnZSI6IlNsaXBwYWdlIHRvbyBoaWdoIChtYXggNTAlKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc4Nl0sImVycm9yTWVzc2FnZSI6IlVuYXV0aG9yaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNDJdLCJlcnJvck1lc3NhZ2UiOiJXcm9uZyBpbnB1dCBhc3NldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxMSw5MDAsMTAwM10sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyMCw3NDRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmlzX3BhdXNlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTU2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wcm90b2NvbF9mZWVfYnBzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4OCwxNDE1LDE0NjksMTUxMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucHJvdG9jb2xfdHJlYXN1cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDc3LDE1NDVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJ1bGVfY291bnRlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NjUsMTU1MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfZXhlY3V0aW9ucyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTA2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjIzLDEzNDEsMTM3MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzMsMzgxLDM5Nyw0MDUsMTE3MCwxMTc4LDE0MDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjUsNjE0LDYzMSw2NDEsNjUzLDY2Myw2NzEsNjgxLDEwNjMsMTE1NCwxMTYyLDEyNjcsMTMzMiwxMzYxLDE0NjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzMsMzU3LDM4OSwxMDcxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NDIsMTU2M10sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE1XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQXlDaUFnSUNCaWVYUmxZMkpzYjJOcklDSndjbTkwYjJOdmJGOTBjbVZoYzNWeWVTSWdNSGd4TlRGbU4yTTNOU0FpY25Wc1pWOWpiM1Z1ZEdWeUlpQWlkRzkwWVd4ZlpYaGxZM1YwYVc5dWN5SWdJbWx6WDNCaGRYTmxaQ0lnSW5CeWIzUnZZMjlzWDJabFpWOWljSE1pSURCNE5ERTNNemN6TmpVM05EUm1OekEzTkRRNU5tVUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRXdNQW9nSUNBZ0x5OGdjMlZzWmk1eWRXeGxYMk52ZFc1MFpYSWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkoxYkdWZlkyOTFiblJsY2lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UQXhDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMlY0WldOMWRHbHZibk1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYMlY0WldOMWRHbHZibk1pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFd01nb2dJQ0FnTHk4Z2MyVnNaaTV3Y205MGIyTnZiRjltWldWZlluQnpJRDBnVlVsdWREWTBLREV3S1NBZ0l5QXdMakVsSUhCeWIzUnZZMjlzSUdabFpRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWNISnZkRzlqYjJ4ZlptVmxYMkp3Y3lJS0lDQWdJSEIxYzJocGJuUWdNVEFnTHk4Z01UQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TURNS0lDQWdJQzh2SUhObGJHWXVjSEp2ZEc5amIyeGZkSEpsWVhOMWNua2dQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKd2NtOTBiMk52YkY5MGNtVmhjM1Z5ZVNJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRXdOQW9nSUNBZ0x5OGdjMlZzWmk1cGMxOXdZWFZ6WldRZ1BTQkdZV3h6WlFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYVhOZmNHRjFjMlZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPamt3Q2lBZ0lDQXZMeUJqYkdGemN5QkJkWFJ2VUdsc2IzUlNkV3hsUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDI5d2RGOXBibDloYzNObGRGOWlZWEpsUURJeUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRnS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhneU16QTBaV1k1WlNBd2VEbGtObVk0TURFM0lEQjROalF5TXpjelpUZ2dNSGhtTkdVeFl6Qm1OaUF3ZUdWallXTXpNV0V4SURCNFlXRXpaVFExTkRRZ01IZzFPVGt6T0RZeE1DQXdlRFJqWlRReE1ERTJJREI0WlROalpHVm1NMklnTUhobFpUVTVPVGsxT0NBd2VEZ3daVGN5T1RkaUlDOHZJRzFsZEdodlpDQWlZM0psWVhSbFgzSjFiR1VvZFdsdWREZ3NkV2x1ZERZMFcxMHNkV2x1ZERnc2RXbHVkRFkwTEhWcGJuUXhOaXgxYVc1ME1UWXNkV2x1ZERnc2RXbHVkREUyTEhWcGJuUXhOaXh3WVhrcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKbGVHVmpkWFJsWDNKMWJHVW9kV2x1ZERZMExHRmtaSEpsYzNNc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0oxY0dSaGRHVmZjblZzWlY5emRHRjBkWE1vZFdsdWREWTBMSFZwYm5RNEtYWnZhV1FpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVjl5ZFd4bFgzQmhjbUZ0WlhSbGNuTW9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBNVFlzZFdsdWRERTJLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltUmxiR1YwWlY5eWRXeGxLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZjblZzWlNoMWFXNTBOalFzWVdSa2NtVnpjeWtvZFdsdWREWTBMR0ZrWkhKbGMzTXNkV2x1ZERnc2RXbHVkRGdzZFdsdWREWTBXMTBzZFdsdWREZ3NkV2x1ZERZMExIVnBiblF4Tml4MWFXNTBNVFlzS0hWcGJuUTRMSFZwYm5ReE5peDFhVzUwTVRZc2RXbHVkRGdwTEhWcGJuUTJOQ3gxYVc1ME16SXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltZGxkRjl5ZFd4bFgzTjBZWFJ6S0hWcGJuUTJOQ3hoWkdSeVpYTnpLU2gxYVc1ME16SXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0luTmxkRjl3Y205MGIyTnZiRjltWldVb2RXbHVkREUyS1hadmFXUWlMQ0J0WlhSb2IyUWdJbTl3ZEY5cGJsOWhjM05sZENoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDNCaGRYTmxLR0p2YjJ3cGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFgyTnZiblJ5WVdOMFgzTjBZWFJ6S0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME1UWXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxYM0oxYkdVZ1pYaGxZM1YwWlY5eWRXeGxJSFZ3WkdGMFpWOXlkV3hsWDNOMFlYUjFjeUIxY0dSaGRHVmZjblZzWlY5d1lYSmhiV1YwWlhKeklHUmxiR1YwWlY5eWRXeGxJR2RsZEY5eWRXeGxJR2RsZEY5eWRXeGxYM04wWVhSeklITmxkRjl3Y205MGIyTnZiRjltWldVZ2IzQjBYMmx1WDJGemMyVjBJSE5sZEY5d1lYVnpaU0JuWlhSZlkyOXVkSEpoWTNSZmMzUmhkSE1LSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4T0RvS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qa3dDaUFnSUNBdkx5QmpiR0Z6Y3lCQmRYUnZVR2xzYjNSU2RXeGxRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdaallXUmpNalZqSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsWDJGd2NHeHBZMkYwYVc5dUtDbHpkSEpwYm1jaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJOeVpXRjBaVjloY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUF4T1FvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOWhjSEJzYVdOaGRHbHZibDl5YjNWMFpVQXhPVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFd05nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TVdNME1UYzFOelEyWmpVd05qazJZelptTnpReU1EVXlOelUyWXpZMU1qQTBNelptTm1VM05EY3lOakUyTXpjME1qQTNOak14TW1Vek1Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDI5d2RGOXBibDloYzNObGRGOWlZWEpsUURJeU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOVFV6Q2lBZ0lDQXZMeUJBWVhKak5DNWlZWEpsYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwc0lHTnlaV0YwWlQwaVpHbHpZV3hzYjNjaUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0NBbUppQmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvMU5qSXROVFl6Q2lBZ0lDQXZMeUFqSUU5dWJIa2djSEp2ZEc5amIyd2dkSEpsWVhOMWNua2dLR0ZrYldsdUtTQmpZVzRnY0dWeVptOXliU0JoYzNObGRDQnZjSFF0YVc1ekNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG5CeWIzUnZZMjlzWDNSeVpXRnpkWEo1TENBaVQyNXNlU0JoWkcxcGJpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p3Y205MGIyTnZiRjkwY21WaGMzVnllU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2NtOTBiMk52YkY5MGNtVmhjM1Z5ZVNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JoWkcxcGJnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOVFkwTFRVMk5Rb2dJQ0FnTHk4Z0l5Qk5kWE4wSUhOMWNIQnNlU0JsZUdGamRHeDVJRzl1WlNCbWIzSmxhV2R1SUdGemMyVjBJR2x1SUhSb1pTQmpZV3hzQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG01MWJWOWhjM05sZEhNZ1BUMGdWVWx1ZERZMEtERXBMQ0FpVUhKdmRtbGtaU0JsZUdGamRHeDVJRzl1WlNCaGMzTmxkQ0lLSUNBZ0lIUjRiaUJPZFcxQmMzTmxkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZCeWIzWnBaR1VnWlhoaFkzUnNlU0J2Ym1VZ1lYTnpaWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pVMk5nb2dJQ0FnTHk4Z1lYTnpaWFJmY21WbUlEMGdWSGh1TG1GemMyVjBjeWd3S1FvZ0lDQWdkSGh1WVNCQmMzTmxkSE1nTUFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5UWTNMVFUzTXdvZ0lDQWdMeThnSXlCSmJtNWxjaUF3TFdGdGIzVnVkQ0IwY21GdWMyWmxjaUIwYnlCelpXeG1JSEJsY21admNtMXpJRzl3ZEMxcGJnb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5WVhOelpYUmZjbVZtTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOVGN3Q2lBZ0lDQXZMeUJoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPalUzTVFvZ0lDQWdMeThnWVhOelpYUmZZVzF2ZFc1MFBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qVTJOeTAxTmpnS0lDQWdJQzh2SUNNZ1NXNXVaWElnTUMxaGJXOTFiblFnZEhKaGJuTm1aWElnZEc4Z2MyVnNaaUJ3WlhKbWIzSnRjeUJ2Y0hRdGFXNEtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TlRjeUNpQWdJQ0F2THlCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8xTmpjdE5UY3pDaUFnSUNBdkx5QWpJRWx1Ym1WeUlEQXRZVzF2ZFc1MElIUnlZVzV6Wm1WeUlIUnZJSE5sYkdZZ2NHVnlabTl5YlhNZ2IzQjBMV2x1Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMWhjM05sZEY5eVpXWXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5UYzBDaUFnSUNBdkx5QnNiMmNvWWlKQmMzTmxkRTl3ZEVsdUlpd2diM0F1YVhSdllpaGhjM05sZEY5eVpXWXVhV1FwS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURReE56TTNNelkxTnpRMFpqY3dOelEwT1RabENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOVFV6Q2lBZ0lDQXZMeUJBWVhKak5DNWlZWEpsYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwc0lHTnlaV0YwWlQwaVpHbHpZV3hzYjNjaUtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wTGtGMWRHOVFhV3h2ZEZKMWJHVkRiMjUwY21GamRDNWpjbVZoZEdWZmNuVnNaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVjl5ZFd4bE9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVEV4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBPQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTJORDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwT0FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXhOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF4TmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTndvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RNENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBNENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRERTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTVDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREUyQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakUwTkMweE5EVUtJQ0FnSUM4dklDTWdWbUZzYVdSaGRHbHZibk1LSUNBZ0lDOHZJR0Z6YzJWeWRDQnViM1FnYzJWc1ppNXBjMTl3WVhWelpXUXNJQ0pEYjI1MGNtRmpkQ0JwY3lCd1lYVnpaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlhWE5mY0dGMWMyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgzQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCRGIyNTBjbUZqZENCcGN5QndZWFZ6WldRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRTBOZ29nSUNBZ0x5OGdZWE56WlhKMElISjFiR1ZmZEhsd1pTNXVZWFJwZG1VZ1BEMGdNeXdnSWtsdWRtRnNhV1FnY25Wc1pTQjBlWEJsSWdvZ0lDQWdaR2xuSURFd0NpQWdJQ0JpZEc5cENpQWdJQ0J3ZFhOb2FXNTBJRE1nTHk4Z013b2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5aaGJHbGtJSEoxYkdVZ2RIbHdaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRRM0NpQWdJQ0F2THlCaGMzTmxjblFnZEdGeVoyVjBYMkZ6YzJWMGN5NXNaVzVuZEdnZ1BpQXdMQ0FpVFhWemRDQm9ZWFpsSUhSaGNtZGxkQ0JoYzNObGRITWlDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR0Z6YzJWeWRDQXZMeUJOZFhOMElHaGhkbVVnZEdGeVoyVjBJR0Z6YzJWMGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVFE0Q2lBZ0lDQXZMeUJoYzNObGNuUWdiV0Y0WDNOd1pXNWtYMjFwWTNKdllXeG5iM011Ym1GMGFYWmxJRDRnTUN3Z0lrMWhlQ0J6Y0dWdVpDQnRkWE4wSUdKbElENGdNQ0lLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmhjM05sY25RZ0x5OGdUV0Y0SUhOd1pXNWtJRzExYzNRZ1ltVWdQaUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCdFlYaGZjMnhwY0hCaFoyVmZZbkJ6TG01aGRHbDJaU0E4UFNCTlFWaGZVMHhKVUZCQlIwVmZRbEJUTENBaVUyeHBjSEJoWjJVZ2RHOXZJR2hwWjJnZ0tHMWhlQ0ExTUNVcElnb2dJQ0FnWkdsbklEVUtJQ0FnSUdKMGIya0tJQ0FnSUhCMWMyaHBiblFnTlRBd01DQXZMeUExTURBd0NpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRk5zYVhCd1lXZGxJSFJ2YnlCb2FXZG9JQ2h0WVhnZ05UQWxLUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRVd0NpQWdJQ0F2THlCaGMzTmxjblFnWTI5dmJHUnZkMjVmYldsdWRYUmxjeTV1WVhScGRtVWdQajBnVFVsT1gwTlBUMHhFVDFkT1gwMUpUbFZVUlZNc0lDSkRiMjlzWkc5M2JpQjBiMjhnYzJodmNuUWdLRzFwYmlBMUlHMXBiblYwWlhNcElnb2dJQ0FnWkdsbklEUUtJQ0FnSUdKMGIya0tJQ0FnSUhCMWMyaHBiblFnTlNBdkx5QTFDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUVOdmIyeGtiM2R1SUhSdmJ5QnphRzl5ZENBb2JXbHVJRFVnYldsdWRYUmxjeWtLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFMU1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhSeWFXZG5aWEpmZEhsd1pTNXVZWFJwZG1VZ1BEMGdNeXdnSWtsdWRtRnNhV1FnZEhKcFoyZGxjaUIwZVhCbElnb2dJQ0FnWkdsbklETUtJQ0FnSUdKMGIya0tJQ0FnSUhCMWMyaHBiblFnTXlBdkx5QXpDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnZEhKcFoyZGxjaUIwZVhCbENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hOVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNJQ0pRWVhsdFpXNTBJRzExYzNRZ1ltVWdkRzhnWTI5dWRISmhZM1FpQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFZWGx0Wlc1MElHMTFjM1FnWW1VZ2RHOGdZMjl1ZEhKaFkzUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakUxT1FvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUXVZVzF2ZFc1MElENDlJRzFwYmw5d1lYbHRaVzUwTENBaVNXNXpkV1ptYVdOcFpXNTBJSEJoZVcxbGJuUWdabTl5SUdKdmVDQnpkRzl5WVdkbElnb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hOVE10TVRVM0NpQWdJQ0F2THlBaklGWmxjbWxtZVNCd1lYbHRaVzUwSUdadmNpQmliM2dnYzNSdmNtRm5aUW9nSUNBZ0x5OGdJeUJDYjNnZ2MybDZaU0IyWVhKcFpYTWdZbUZ6WldRZ2IyNGdiblZ0WW1WeUlHOW1JSFJoY21kbGRDQmhjM05sZEhNS0lDQWdJQzh2SUNNZ1RXbHVhVzExYlRvZ2ZqRXdNQ0JpZVhSbGN5Qm1iM0lnTVNCaGMzTmxkQ0E5SURJc05UQXdJQ3NnS0RFd01DQXFJRFF3TUNrZ1BTQTBNaXcxTURBZ2JXbGpjbTlCVEVkUGN3b2dJQ0FnTHk4Z0l5QlhaU0J5WlhGMWFYSmxJREF1TVRZMUlFRk1SMDhnS0RFMk5Td3dNREFnYldsamNtOUJURWRQY3lrZ2RHOGdZMjkyWlhJZ2RYQWdkRzhnZmpRd01DQmllWFJsY3dvZ0lDQWdMeThnYldsdVgzQmhlVzFsYm5RZ1BTQlZTVzUwTmpRb01UWTFNREF3S1FvZ0lDQWdjSFZ6YUdsdWRDQXhOalV3TURBZ0x5OGdNVFkxTURBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hOVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExtRnRiM1Z1ZENBK1BTQnRhVzVmY0dGNWJXVnVkQ3dnSWtsdWMzVm1abWxqYVdWdWRDQndZWGx0Wlc1MElHWnZjaUJpYjNnZ2MzUnZjbUZuWlNJS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzV6ZFdabWFXTnBaVzUwSUhCaGVXMWxiblFnWm05eUlHSnZlQ0J6ZEc5eVlXZGxDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TmpFdE1UWXlDaUFnSUNBdkx5QWpJRWx1WTNKbGJXVnVkQ0J5ZFd4bElHTnZkVzUwWlhJS0lDQWdJQzh2SUhObGJHWXVjblZzWlY5amIzVnVkR1Z5SUNzOUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKeWRXeGxYMk52ZFc1MFpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y25Wc1pWOWpiM1Z1ZEdWeUlHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luSjFiR1ZmWTI5MWJuUmxjaUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UWTFMVEUzTVFvZ0lDQWdMeThnSXlCRGNtVmhkR1VnZEhKcFoyZGxjaUJrWVhSaENpQWdJQ0F2THlCMGNtbG5aMlZ5SUQwZ1ZISnBaMmRsY2tSaGRHRW9DaUFnSUNBdkx5QWdJQ0FnZEhKcFoyZGxjbDkwZVhCbFBYUnlhV2RuWlhKZmRIbHdaU3dLSUNBZ0lDOHZJQ0FnSUNCMGFISmxjMmh2YkdSZlluQnpQWFJvY21WemFHOXNaRjlpY0hNc0NpQWdJQ0F2THlBZ0lDQWdkMmx1Wkc5M1gyaHZkWEp6UFhkcGJtUnZkMTlvYjNWeWN5d0tJQ0FnSUM4dklDQWdJQ0JzYjI5clltRmphMTlrWVhselBXRnlZelF1VlVsdWREZ29NQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UY3dDaUFnSUNBdkx5QnNiMjlyWW1GamExOWtZWGx6UFdGeVl6UXVWVWx1ZERnb01Da3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRZMUxURTNNUW9nSUNBZ0x5OGdJeUJEY21WaGRHVWdkSEpwWjJkbGNpQmtZWFJoQ2lBZ0lDQXZMeUIwY21sbloyVnlJRDBnVkhKcFoyZGxja1JoZEdFb0NpQWdJQ0F2THlBZ0lDQWdkSEpwWjJkbGNsOTBlWEJsUFhSeWFXZG5aWEpmZEhsd1pTd0tJQ0FnSUM4dklDQWdJQ0IwYUhKbGMyaHZiR1JmWW5CelBYUm9jbVZ6YUc5c1pGOWljSE1zQ2lBZ0lDQXZMeUFnSUNBZ2QybHVaRzkzWDJodmRYSnpQWGRwYm1SdmQxOW9iM1Z5Y3l3S0lDQWdJQzh2SUNBZ0lDQnNiMjlyWW1GamExOWtZWGx6UFdGeVl6UXVWVWx1ZERnb01Da3NDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFM05Rb2dJQ0FnTHk4Z2NuVnNaVjlwWkQxaGNtTTBMbFZKYm5RMk5DaHlkV3hsWDJsa0tTd0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakUzTmdvZ0lDQWdMeThnYjNkdVpYSTlZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UZzRDaUFnSUNBdkx5QmpjbVZoZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFM015MHhPRGtLSUNBZ0lDOHZJQ01nUTNKbFlYUmxJSEoxYkdVZ1pHRjBZUW9nSUNBZ0x5OGdjblZzWlNBOUlGSjFiR1ZFWVhSaEtBb2dJQ0FnTHk4Z0lDQWdJSEoxYkdWZmFXUTlZWEpqTkM1VlNXNTBOalFvY25Wc1pWOXBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2IzZHVaWEk5WVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0FnSUhKMWJHVmZkSGx3WlQxeWRXeGxYM1I1Y0dVc0NpQWdJQ0F2THlBZ0lDQWdjM1JoZEhWelBXRnlZelF1VlVsdWREZ29VMVJCVkZWVFgwRkRWRWxXUlNrc0NpQWdJQ0F2THlBZ0lDQWdkR0Z5WjJWMFgyRnpjMlYwY3oxMFlYSm5aWFJmWVhOelpYUnpMbU52Y0hrb0tTd0tJQ0FnSUM4dklDQWdJQ0J5YjNSaGRHVmZkRzl3WDI0OWNtOTBZWFJsWDNSdmNGOXVMQW9nSUNBZ0x5OGdJQ0FnSUcxaGVGOXpjR1Z1WkY5dGFXTnliMkZzWjI5elBXMWhlRjl6Y0dWdVpGOXRhV055YjJGc1oyOXpMQW9nSUNBZ0x5OGdJQ0FnSUcxaGVGOXpiR2x3Y0dGblpWOWljSE05YldGNFgzTnNhWEJ3WVdkbFgySndjeXdLSUNBZ0lDOHZJQ0FnSUNCamIyOXNaRzkzYmw5dGFXNTFkR1Z6UFdOdmIyeGtiM2R1WDIxcGJuVjBaWE1zQ2lBZ0lDQXZMeUFnSUNBZ2RISnBaMmRsY2oxMGNtbG5aMlZ5TG1OdmNIa29LU3dLSUNBZ0lDOHZJQ0FnSUNCc1lYTjBYMlY0WldOMWRHbHZibDkwYVcxbGMzUmhiWEE5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXeGZaWGhsWTNWMGFXOXVjejFoY21NMExsVkpiblF6TWlnd0tTd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOXpjR1Z1ZEY5dGFXTnliMkZzWjI5elBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1pHbG5JRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURrS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ERXdNRFZpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94T1RFdE1Ua3lDaUFnSUNBdkx5QWpJRk4wYjNKbElHbHVJR0p2ZUNBb2EyVjVPaUJ2ZDI1bGNpQmhaR1J5WlhOeklDc2djblZzWlY5cFpDa0tJQ0FnSUM4dklHSnZlRjlyWlhrZ1BTQlVlRzR1YzJWdVpHVnlMbUo1ZEdWeklDc2diM0F1YVhSdllpaHlkV3hsWDJsa0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVGsxQ2lBZ0lDQXZMeUJ2Y0M1Q2IzZ3VZM0psWVhSbEtHSnZlRjlyWlhrc0lISjFiR1ZmWW5sMFpYTXViR1Z1WjNSb0tRb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOWpjbVZoZEdVS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1UazJDaUFnSUNBdkx5QnZjQzVDYjNndWNIVjBLR0p2ZUY5clpYa3NJSEoxYkdWZllubDBaWE1wQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hPVGd0TVRrNUNpQWdJQ0F2THlBaklFeHZaeUJqY21WaGRHbHZiaUJsZG1WdWRBb2dJQ0FnTHk4Z2JHOW5LR0lpVW5Wc1pVTnlaV0YwWldRaUxDQnZjQzVwZEc5aUtISjFiR1ZmYVdRcExDQlVlRzR1YzJWdVpHVnlMbUo1ZEdWektRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5USTNOVFpqTmpVME16Y3lOalUyTVRjME5qVTJOQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFeE1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUXVRWFYwYjFCcGJHOTBVblZzWlVOdmJuUnlZV04wTG1WNFpXTjFkR1ZmY25Wc1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVY0WldOMWRHVmZjblZzWlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU1ETUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTNDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUE0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lNemt0TWpRd0NpQWdJQ0F2THlBaklGWmxjbWxtZVNCaGRHOXRhV01nWjNKdmRYQWdjM1J5ZFdOMGRYSmxDaUFnSUNBdkx5QmhjM05sY25RZ1IyeHZZbUZzTG1keWIzVndYM05wZW1VZ1BUMGdWVWx1ZERZMEtESXBMQ0FpU1c1MllXeHBaQ0JuY205MWNDQnphWHBsSUNobGVIQmxZM1JsWkNBeUtTSUtJQ0FnSUdkc2IySmhiQ0JIY205MWNGTnBlbVVLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnWjNKdmRYQWdjMmw2WlNBb1pYaHdaV04wWldRZ01pa0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakkwTWkweU5ETUtJQ0FnSUM4dklDTWdWbVZ5YVdaNUlHWnBjbk4wSUhSeVlXNXpZV04wYVc5dUlHbHpJSEJoZVcxbGJuUXZkSEpoYm5ObVpYSWdiMllnYVc1d2RYUWdZWE56WlhRS0lDQWdJQzh2SUdsbUlHRnpjMlYwWDJsdUxtbGtJRDA5SUZWSmJuUTJOQ2d3S1RvS0lDQWdJR0p1ZWlCbGVHVmpkWFJsWDNKMWJHVmZaV3h6WlY5aWIyUjVRRE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJME5DMHlORFVLSUNBZ0lDOHZJQ01nUVV4SFR5QnpkMkZ3SUMwZ1pYaHdaV04wSUhCaGVXMWxiblFnZEhKaGJuTmhZM1JwYjI0S0lDQWdJQzh2SUdGemMyVnlkQ0JuZEhodUxsUnlZVzV6WVdOMGFXOXVLREFwTG5SNWNHVWdQVDBnVkhKaGJuTmhZM1JwYjI1VWVYQmxMbEJoZVcxbGJuUXNJQ0pHYVhKemRDQjBlRzRnYlhWemRDQmlaU0J3WVhsdFpXNTBJR1p2Y2lCQlRFZFBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVacGNuTjBJSFI0YmlCdGRYTjBJR0psSUhCaGVXMWxiblFnWm05eUlFRk1SMDhLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJME5nb2dJQ0FnTHk4Z1lYTnpaWEowSUdkMGVHNHVVR0Y1YldWdWRGUnlZVzV6WVdOMGFXOXVLREFwTG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lDSk5kWE4wSUhObGJtUWdRVXhIVHlCMGJ5QmpiMjUwY21GamRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVFhWemRDQnpaVzVrSUVGTVIwOGdkRzhnWTI5dWRISmhZM1FLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJME53b2dJQ0FnTHk4Z1lXTjBkV0ZzWDJGdGIzVnVkQ0E5SUdkMGVHNHVVR0Y1YldWdWRGUnlZVzV6WVdOMGFXOXVLREFwTG1GdGIzVnVkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0taWGhsWTNWMFpWOXlkV3hsWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJMU5TMHlOVFlLSUNBZ0lDOHZJQ01nVm1WeWFXWjVJR0Z0YjNWdWRDQnRZWFJqYUdWekNpQWdJQ0F2THlCaGMzTmxjblFnWVdOMGRXRnNYMkZ0YjNWdWRDQTlQU0JoYlc5MWJuUmZhVzR1Ym1GMGFYWmxMQ0FpUVcxdmRXNTBJRzFwYzIxaGRHTm9JZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiVzkxYm5RZ2JXbHpiV0YwWTJnS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qSTFPQzB5TlRrS0lDQWdJQzh2SUNNZ1RHOWhaQ0J5ZFd4bElHWnliMjBnWW05NElITjBiM0poWjJVS0lDQWdJQzh2SUdKdmVGOXJaWGtnUFNCdmQyNWxjaTVpZVhSbGN5QXJJRzl3TG1sMGIySW9jblZzWlY5cFpDNXVZWFJwZG1VcENpQWdJQ0JrYVdjZ053b2dJQ0FnWW5SdmFRb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXlDaUFnSUNCa2FXY2dOd29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTFDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG95TmpJS0lDQWdJQzh2SUhKMWJHVmZZbmwwWlhNc0lHVjRhWE4wY3lBOUlHOXdMa0p2ZUM1blpYUW9ZbTk0WDJ0bGVTa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZblZ5ZVNBeE5Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNall6Q2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSekxDQWlVblZzWlNCdWIzUWdabTkxYm1RaUNpQWdJQ0JoYzNObGNuUWdMeThnVW5Wc1pTQnViM1FnWm05MWJtUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakkyTmkweU5qY0tJQ0FnSUM4dklDTWdWbUZzYVdSaGRHbHZibk1LSUNBZ0lDOHZJR0Z6YzJWeWRDQnViM1FnYzJWc1ppNXBjMTl3WVhWelpXUXNJQ0pEYjI1MGNtRmpkQ0JwY3lCd1lYVnpaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlhWE5mY0dGMWMyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgzQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCRGIyNTBjbUZqZENCcGN5QndZWFZ6WldRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qSTJPQW9nSUNBZ0x5OGdZWE56WlhKMElISjFiR1V1YzNSaGRIVnpMbTVoZEdsMlpTQTlQU0JUVkVGVVZWTmZRVU5VU1ZaRkxDQWlVblZzWlNCdWIzUWdZV04wYVhabElnb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFF4SUM4dklEUXhDaUFnSUNCblpYUmllWFJsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCU2RXeGxJRzV2ZENCaFkzUnBkbVVLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJM01DMHlOekVLSUNBZ0lDOHZJQ01nUTJobFkyc2dZMjl2YkdSdmQyNGdjR1Z5YVc5a0NpQWdJQ0F2THlCMGFXMWxYM05wYm1ObFgyeGhjM1FnUFNCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0F0SUhKMWJHVXViR0Z6ZEY5bGVHVmpkWFJwYjI1ZmRHbHRaWE4wWVcxd0xtNWhkR2wyWlFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdOak1nTHk4Z05qTUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lOeklLSUNBZ0lDOHZJR052YjJ4a2IzZHVYM05sWTI5dVpITWdQU0J5ZFd4bExtTnZiMnhrYjNkdVgyMXBiblYwWlhNdWJtRjBhWFpsSUNvZ1ZVbHVkRFkwS0RZd0tRb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0ExTlNBdkx5QTFOUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lIQjFjMmhwYm5RZ05qQWdMeThnTmpBS0lDQWdJQ29LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJM013b2dJQ0FnTHk4Z1lYTnpaWEowSUhScGJXVmZjMmx1WTJWZmJHRnpkQ0ErUFNCamIyOXNaRzkzYmw5elpXTnZibVJ6TENBaVEyOXZiR1J2ZDI0Z2NHVnlhVzlrSUc1dmRDQnRaWFFpQ2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklFTnZiMnhrYjNkdUlIQmxjbWx2WkNCdWIzUWdiV1YwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU56VXRNamMyQ2lBZ0lDQXZMeUFqSUZabGNtbG1lU0JqWVd4c1pYSWdhWE1nWVhWMGFHOXlhWHBsWkNBb2IzZHVaWElnYjNJZ1kyOXVkSEpoWTNRcENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnZkMjVsY2k1dVlYUnBkbVVnYjNJZ1ZIaHVMbk5sYm1SbGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQ0FpVlc1aGRYUm9iM0pwZW1Wa0lnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJsZUdWamRYUmxYM0oxYkdWZlltOXZiRjkwY25WbFFEWUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZbm9nWlhobFkzVjBaVjl5ZFd4bFgySnZiMnhmWm1Gc2MyVkFOd29LWlhobFkzVjBaVjl5ZFd4bFgySnZiMnhmZEhKMVpVQTJPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtDbVY0WldOMWRHVmZjblZzWlY5aWIyOXNYMjFsY21kbFFEZzZDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG95TnpVdE1qYzJDaUFnSUNBdkx5QWpJRlpsY21sbWVTQmpZV3hzWlhJZ2FYTWdZWFYwYUc5eWFYcGxaQ0FvYjNkdVpYSWdiM0lnWTI5dWRISmhZM1FwQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCdmQyNWxjaTV1WVhScGRtVWdiM0lnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWlWVzVoZFhSb2IzSnBlbVZrSWdvZ0lDQWdZWE56WlhKMElDOHZJRlZ1WVhWMGFHOXlhWHBsWkFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1qYzRMVEkzT1FvZ0lDQWdMeThnSXlCV1pYSnBabmtnYzNCbGJtUWdiR2x0YVhRS0lDQWdJQzh2SUdGemMyVnlkQ0JoYlc5MWJuUmZhVzR1Ym1GMGFYWmxJRHc5SUhKMWJHVXViV0Y0WDNOd1pXNWtYMjFwWTNKdllXeG5iM011Ym1GMGFYWmxMQ0FpUlhoalpXVmtjeUJ0WVhnZ2MzQmxibVFnYkdsdGFYUWlDaUFnSUNCa2FXY2dNVEVLSUNBZ0lIQjFjMmhwYm5RZ05EVWdMeThnTkRVS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01UQUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnUlhoalpXVmtjeUJ0WVhnZ2MzQmxibVFnYkdsdGFYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakk1TVFvZ0lDQWdMeThnYldsdVgyRnRiM1Z1ZEY5dmRYUTliV2x1WDJGdGIzVnVkRjl2ZFhRdWJtRjBhWFpsTEFvZ0lDQWdaR2xuSURJS0lDQWdJR0owYjJrS0lDQWdJR0oxY25rZ09Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOakF6TFRZd05Bb2dJQ0FnTHk4Z0l5QkRhR1ZqYXlCcFppQjNaU2R5WlNCemQyRndjR2x1WnlCbWNtOXRJRUZNUjA4Z0tHRnpjMlYwSUVsRUlEQXBDaUFnSUNBdkx5QnBaaUJoYzNObGRGOXBiaTVwWkNBOVBTQlZTVzUwTmpRb01DazZDaUFnSUNCa2FXY2dOUW9nSUNBZ1ltNTZJR1Y0WldOMWRHVmZjblZzWlY5bGJITmxYMkp2WkhsQU1URUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPall3TlMwMk1URUtJQ0FnSUM4dklDTWdSbTl5SUVGTVIwOGdjM2RoY0hNc0lIZGxJRzVsWldRZ2RHOGdjMlZ1WkNCaElIQmhlVzFsYm5RZ2RISmhibk5oWTNScGIyNEtJQ0FnSUM4dklDTWdWSEpoYm5ObVpYSWdRVXhIVHlCMGJ5QmhaR0Z3ZEdWeUlHTnZiblJ5WVdOMENpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5WVdSaGNIUmxjbDloY0hCZmFXUXVZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlZVzF2ZFc1MFgybHVMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzJNRGdLSUNBZ0lDOHZJSEpsWTJWcGRtVnlQV0ZrWVhCMFpYSmZZWEJ3WDJsa0xtRmtaSEpsYzNNc0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TmpBMUxUWXdOd29nSUNBZ0x5OGdJeUJHYjNJZ1FVeEhUeUJ6ZDJGd2N5d2dkMlVnYm1WbFpDQjBieUJ6Wlc1a0lHRWdjR0Y1YldWdWRDQjBjbUZ1YzJGamRHbHZiZ29nSUNBZ0x5OGdJeUJVY21GdWMyWmxjaUJCVEVkUElIUnZJR0ZrWVhCMFpYSWdZMjl1ZEhKaFkzUUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPall4TUFvZ0lDQWdMeThnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOakExTFRZeE1Rb2dJQ0FnTHk4Z0l5QkdiM0lnUVV4SFR5QnpkMkZ3Y3l3Z2QyVWdibVZsWkNCMGJ5QnpaVzVrSUdFZ2NHRjViV1Z1ZENCMGNtRnVjMkZqZEdsdmJnb2dJQ0FnTHk4Z0l5QlVjbUZ1YzJabGNpQkJURWRQSUhSdklHRmtZWEIwWlhJZ1kyOXVkSEpoWTNRS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFoWkdGd2RHVnlYMkZ3Y0Y5cFpDNWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWhiVzkxYm5SZmFXNHNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENncGxlR1ZqZFhSbFgzSjFiR1ZmWVdaMFpYSmZhV1pmWld4elpVQXhNam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pZeU5pMDJNemNLSUNBZ0lDOHZJSEpsYzNWc2RDQTlJR2wwZUc0dVFYQndiR2xqWVhScGIyNURZV3hzS0FvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxaFpHRndkR1Z5WDJGd2NGOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCaGNIQmZZWEpuY3owb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUhOM1lYQmZiV1YwYUc5a0xBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCdmNDNXBkRzlpS0hCdmIyeGZZWEJ3WDJsa0xtbGtLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdiM0F1YVhSdllpaGhjM05sZEY5cGJpNXBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJRzl3TG1sMGIySW9ZWE56WlhSZmIzVjBMbWxrS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnYjNBdWFYUnZZaWhoYlc5MWJuUmZhVzRwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J2Y0M1cGRHOWlLRzFwYmw5aGJXOTFiblJmYjNWMEtTd0tJQ0FnSUM4dklDQWdJQ0FwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8yTXpBS0lDQWdJQzh2SUc5d0xtbDBiMklvY0c5dmJGOWhjSEJmYVdRdWFXUXBMQW9nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8yTXpFS0lDQWdJQzh2SUc5d0xtbDBiMklvWVhOelpYUmZhVzR1YVdRcExBb2dJQ0FnWkdsbklEWUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPall6TWdvZ0lDQWdMeThnYjNBdWFYUnZZaWhoYzNObGRGOXZkWFF1YVdRcExBb2dJQ0FnWkdsbklEWUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TmpNekNpQWdJQ0F2THlCdmNDNXBkRzlpS0dGdGIzVnVkRjlwYmlrc0NpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TmpNMENpQWdJQ0F2THlCdmNDNXBkRzlpS0cxcGJsOWhiVzkxYm5SZmIzVjBLU3dLSUNBZ0lHUnBaeUF4TkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzJNakV0TmpJMENpQWdJQ0F2THlBaklFTmhiR3dnWVdSaGNIUmxjaWR6SUhOM1lYQmZabWw0WldSZmFXNXdkWFFnYldWMGFHOWtDaUFnSUNBdkx5QWpJRTFsZEdodlpDQnphV2R1WVhSMWNtVTZJQ0p6ZDJGd1gyWnBlR1ZrWDJsdWNIVjBLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBkV2x1ZERZMElnb2dJQ0FnTHk4Z0l5QkJRa2tnYzJWc1pXTjBiM0lnWm05eUlIUm9hWE1nYldWMGFHOWtDaUFnSUNBdkx5QnpkMkZ3WDIxbGRHaHZaQ0E5SUVKNWRHVnpMbVp5YjIxZmFHVjRLQ0l3WmpKbU5tWTNaaUlwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3WmpKbU5tWTNaZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1JwWnlBMUNpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOakkyQ2lBZ0lDQXZMeUJ5WlhOMWJIUWdQU0JwZEhodUxrRndjR3hwWTJGMGFXOXVRMkZzYkNnS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzJNellLSUNBZ0lDOHZJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qWXlOaTAyTXpjS0lDQWdJQzh2SUhKbGMzVnNkQ0E5SUdsMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c0tBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5cFpEMWhaR0Z3ZEdWeVgyRndjRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjSEJmWVhKbmN6MG9DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lITjNZWEJmYldWMGFHOWtMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnZjQzVwZEc5aUtIQnZiMnhmWVhCd1gybGtMbWxrS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnYjNBdWFYUnZZaWhoYzNObGRGOXBiaTVwWkNrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUc5d0xtbDBiMklvWVhOelpYUmZiM1YwTG1sa0tTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ2IzQXVhWFJ2WWloaGJXOTFiblJmYVc0cExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCdmNDNXBkRzlpS0cxcGJsOWhiVzkxYm5SZmIzVjBLU3dLSUNBZ0lDOHZJQ0FnSUNBcExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvMk5ERUtJQ0FnSUM4dklHOTFkSEIxZEY5aGJXOTFiblFnUFNCdmNDNWlkRzlwS0c5MWRIQjFkRjlpZVhSbGN5a0tJQ0FnSUdKMGIya0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPalkwTXkwMk5EUUtJQ0FnSUM4dklDTWdWbVZ5YVdaNUlHMXBibWx0ZFcwZ2IzVjBjSFYwSUhkaGN5QnRaWFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnZkWFJ3ZFhSZllXMXZkVzUwSUQ0OUlHMXBibDloYlc5MWJuUmZiM1YwTENBaVQzVjBjSFYwSUdKbGJHOTNJRzFwYm1sdGRXMGdLSE5zYVhCd1lXZGxJR1Y0WTJWbFpHVmtLU0lLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRTkxZEhCMWRDQmlaV3h2ZHlCdGFXNXBiWFZ0SUNoemJHbHdjR0ZuWlNCbGVHTmxaV1JsWkNrS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qWTBOaTAyTlRNS0lDQWdJQzh2SUNNZ1ZISmhibk5tWlhJZ2NtVmpaV2wyWldRZ1lYTnpaWFJ6SUdaeWIyMGdZV1JoY0hSbGNpQmlZV05ySUhSdklIUm9hWE1nWTI5dWRISmhZM1FLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXRnpjMlYwWDI5MWRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXpaVzVrWlhJOVlXUmhjSFJsY2w5aGNIQmZhV1F1WVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMXZkWFJ3ZFhSZllXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8yTkRrS0lDQWdJQzh2SUdGemMyVjBYM05sYm1SbGNqMWhaR0Z3ZEdWeVgyRndjRjlwWkM1aFpHUnlaWE56TEFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndRV1JrY21WemN3b2dJQ0FnWVhOelpYSjBJQzh2SUdGd2NHeHBZMkYwYVc5dUlHVjRhWE4wY3dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5qVXdDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFUyVnVaR1Z5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TmpRMkxUWTBOd29nSUNBZ0x5OGdJeUJVY21GdWMyWmxjaUJ5WldObGFYWmxaQ0JoYzNObGRITWdabkp2YlNCaFpHRndkR1Z5SUdKaFkyc2dkRzhnZEdocGN5QmpiMjUwY21GamRBb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8yTlRJS0lDQWdJQzh2SUdabFpUMVZTVzUwTmpRb01Da3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPalkwTmkwMk5UTUtJQ0FnSUM4dklDTWdWSEpoYm5ObVpYSWdjbVZqWldsMlpXUWdZWE56WlhSeklHWnliMjBnWVdSaGNIUmxjaUJpWVdOcklIUnZJSFJvYVhNZ1kyOXVkSEpoWTNRS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQV0Z6YzJWMFgyOTFkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl6Wlc1a1pYSTlZV1JoY0hSbGNsOWhjSEJmYVdRdVlXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDF2ZFhSd2RYUmZZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1qazJMVEk1TndvZ0lDQWdMeThnSXlCVmNHUmhkR1VnY25Wc1pTQnpkR0YwYVhOMGFXTnpDaUFnSUNBdkx5QnlkV3hsTG14aGMzUmZaWGhsWTNWMGFXOXVYM1JwYldWemRHRnRjQ0E5SUdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3S1FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURFMENpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUEyTXdvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1qazRDaUFnSUNBdkx5QnlkV3hsTG5SdmRHRnNYMlY0WldOMWRHbHZibk1nUFNCaGNtTTBMbFZKYm5Rek1paHlkV3hsTG5SdmRHRnNYMlY0WldOMWRHbHZibk11Ym1GMGFYWmxJQ3NnVlVsdWREWTBLREVwS1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEY3hJQzh2SURjeENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5Rek1nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1ltbDBiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCbGVIUnlZV04wSURRZ05Bb2dJQ0FnY21Wd2JHRmpaVElnTnpFS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qTXdNQW9nSUNBZ0x5OGdjblZzWlM1MGIzUmhiRjl6Y0dWdWRGOXRhV055YjJGc1oyOXpMbTVoZEdsMlpTQXJJR0Z0YjNWdWRGOXpjR1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEYzFJQzh2SURjMUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQXJDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG95T1RrdE16QXhDaUFnSUNBdkx5QnlkV3hsTG5SdmRHRnNYM053Wlc1MFgyMXBZM0p2WVd4bmIzTWdQU0JoY21NMExsVkpiblEyTkNnS0lDQWdJQzh2SUNBZ0lDQnlkV3hsTG5SdmRHRnNYM053Wlc1MFgyMXBZM0p2WVd4bmIzTXVibUYwYVhabElDc2dZVzF2ZFc1MFgzTndaVzUwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQTNOUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TXpBekxUTXdOQW9nSUNBZ0x5OGdJeUJUWVhabElIVndaR0YwWldRZ2NuVnNaUW9nSUNBZ0x5OGdiM0F1UW05NExuQjFkQ2hpYjNoZmEyVjVMQ0J5ZFd4bExtSjVkR1Z6S1FvZ0lDQWdaR2xuSURFMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG96TURZdE16QTNDaUFnSUNBdkx5QWpJRWx1WTNKbGJXVnVkQ0JuYkc5aVlXd2daWGhsWTNWMGFXOXVJR052ZFc1MFpYSUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZaWGhsWTNWMGFXOXVjeUFyUFNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZaWGhsWTNWMGFXOXVjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjlsZUdWamRYUnBiMjV6SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYMlY0WldOMWRHbHZibk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk16QTVMVE14TUFvZ0lDQWdMeThnSXlCTWIyY2daWGhsWTNWMGFXOXVDaUFnSUNBdkx5QnNiMmNvWWlKU2RXeGxSWGhsWTNWMFpXUWlMQ0J2Y0M1cGRHOWlLSEoxYkdWZmFXUXVibUYwYVhabEtTd2diM0F1YVhSdllpaGhiVzkxYm5SZmMzQmxiblFwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRJM05UWmpOalUwTlRjNE5qVTJNemMxTnpRMk5UWTBDaUFnSUNCa2FXY2dNVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qSXdNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJR1JwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0taWGhsWTNWMFpWOXlkV3hsWDJWc2MyVmZZbTlrZVVBeE1Ub0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPall4TXkwMk1Ua0tJQ0FnSUM4dklDTWdSbTl5SUVGVFFTQnpkMkZ3Y3l3Z2RISmhibk5tWlhJZ2RHaGxJR0Z6YzJWMElIUnZJR0ZrWVhCMFpYSUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdGemMyVjBYMmx1TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFdGa1lYQjBaWEpmWVhCd1gybGtMbUZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBXRnRiM1Z1ZEY5cGJpd0tJQ0FnSUM4dklDQWdJQ0JtWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5qRTJDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxaFpHRndkR1Z5WDJGd2NGOXBaQzVoWkdSeVpYTnpMQW9nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRmtaSEpsYzNNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCc2FXTmhkR2x2YmlCbGVHbHpkSE1LSUNBZ0lHUnBaeUF4TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qWXhNeTAyTVRRS0lDQWdJQzh2SUNNZ1JtOXlJRUZUUVNCemQyRndjeXdnZEhKaGJuTm1aWElnZEdobElHRnpjMlYwSUhSdklHRmtZWEIwWlhJS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOakU0Q2lBZ0lDQXZMeUJtWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzJNVE10TmpFNUNpQWdJQ0F2THlBaklFWnZjaUJCVTBFZ2MzZGhjSE1zSUhSeVlXNXpabVZ5SUhSb1pTQmhjM05sZENCMGJ5QmhaR0Z3ZEdWeUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFoYzNObGRGOXBiaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFoWkdGd2RHVnlYMkZ3Y0Y5cFpDNWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxaGJXOTFiblJmYVc0c0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQmlJR1Y0WldOMWRHVmZjblZzWlY5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2dwbGVHVmpkWFJsWDNKMWJHVmZZbTl2YkY5bVlXeHpaVUEzT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdaWGhsWTNWMFpWOXlkV3hsWDJKdmIyeGZiV1Z5WjJWQU9Bb0taWGhsWTNWMFpWOXlkV3hsWDJWc2MyVmZZbTlrZVVBek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNalE1TFRJMU1Bb2dJQ0FnTHk4Z0l5QkJVMEVnYzNkaGNDQXRJR1Y0Y0dWamRDQmhjM05sZENCMGNtRnVjMlpsY2dvZ0lDQWdMeThnWVhOelpYSjBJR2QwZUc0dVZISmhibk5oWTNScGIyNG9NQ2t1ZEhsd1pTQTlQU0JVY21GdWMyRmpkR2x2YmxSNWNHVXVRWE56WlhSVWNtRnVjMlpsY2l3Z0lrWnBjbk4wSUhSNGJpQnRkWE4wSUdKbElHRnpjMlYwSUhSeVlXNXpabVZ5SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUm1seWMzUWdkSGh1SUcxMWMzUWdZbVVnWVhOelpYUWdkSEpoYm5ObVpYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakkxTVFvZ0lDQWdMeThnWVhOelpYSjBJR2QwZUc0dVFYTnpaWFJVY21GdWMyWmxjbFJ5WVc1ellXTjBhVzl1S0RBcExuaG1aWEpmWVhOelpYUWdQVDBnWVhOelpYUmZhVzRzSUNKWGNtOXVaeUJwYm5CMWRDQmhjM05sZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5kSGh1Y3lCWVptVnlRWE56WlhRS0lDQWdJR1JwWnlBMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRmR5YjI1bklHbHVjSFYwSUdGemMyVjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG95TlRJS0lDQWdJQzh2SUdGemMyVnlkQ0JuZEhodUxrRnpjMlYwVkhKaGJuTm1aWEpVY21GdWMyRmpkR2x2Ymlnd0tTNWhjM05sZEY5eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWlUWFZ6ZENCelpXNWtJSFJ2SUdOdmJuUnlZV04wSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZDBlRzV6SUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUUxMWMzUWdjMlZ1WkNCMGJ5QmpiMjUwY21GamRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNalV6Q2lBZ0lDQXZMeUJoWTNSMVlXeGZZVzF2ZFc1MElEMGdaM1I0Ymk1QmMzTmxkRlJ5WVc1elptVnlWSEpoYm5OaFkzUnBiMjRvTUNrdVlYTnpaWFJmWVcxdmRXNTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjNSNGJuTWdRWE56WlhSQmJXOTFiblFLSUNBZ0lHSWdaWGhsWTNWMFpWOXlkV3hsWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9LQ2k4dklHTnZiblJ5WVdOMExrRjFkRzlRYVd4dmRGSjFiR1ZEYjI1MGNtRmpkQzUxY0dSaGRHVmZjblZzWlY5emRHRjBkWE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1ZmY25Wc1pWOXpkR0YwZFhNNkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3pNVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblE0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvek16RXRNek15Q2lBZ0lDQXZMeUFqSUV4dllXUWdjblZzWlFvZ0lDQWdMeThnWW05NFgydGxlU0E5SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1nS3lCdmNDNXBkRzlpS0hKMWJHVmZhV1F1Ym1GMGFYWmxLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3pNelVLSUNBZ0lDOHZJSEoxYkdWZllubDBaWE1zSUdWNGFYTjBjeUE5SUc5d0xrSnZlQzVuWlhRb1ltOTRYMnRsZVNrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNek0yQ2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSekxDQWlVblZzWlNCdWIzUWdabTkxYm1RaUNpQWdJQ0JoYzNObGNuUWdMeThnVW5Wc1pTQnViM1FnWm05MWJtUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPak16T1Mwek5EQUtJQ0FnSUM4dklDTWdWbUZzYVdSaGRHVUtJQ0FnSUM4dklHRnpjMlZ5ZENCeWRXeGxMbTkzYm1WeUxtNWhkR2wyWlNBOVBTQlVlRzR1YzJWdVpHVnlMQ0FpVG05MElISjFiR1VnYjNkdVpYSWlDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnT0NBek1nb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9iM1FnY25Wc1pTQnZkMjVsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk16UXhDaUFnSUNBdkx5QmhjM05sY25RZ2JtVjNYM04wWVhSMWN5NXVZWFJwZG1VZ1BEMGdVMVJCVkZWVFgwTkJUa05GVEV4RlJDd2dJa2x1ZG1Gc2FXUWdjM1JoZEhWeklnb2dJQ0FnWkdsbklETUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F6SUM4dklETUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaQ0J6ZEdGMGRYTUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPak0wTWdvZ0lDQWdMeThnWVhOelpYSjBJSEoxYkdVdWMzUmhkSFZ6TG01aGRHbDJaU0FoUFNCVFZFRlVWVk5mUTBGT1EwVk1URVZFTENBaVEyRnVibTkwSUcxdlpHbG1lU0JqWVc1alpXeHNaV1FnY25Wc1pTSUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURReElDOHZJRFF4Q2lBZ0lDQm5aWFJpZVhSbENpQWdJQ0J3ZFhOb2FXNTBJRE1nTHk4Z013b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJEWVc1dWIzUWdiVzlrYVdaNUlHTmhibU5sYkd4bFpDQnlkV3hsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvek5EUXRNelExQ2lBZ0lDQXZMeUFqSUZWd1pHRjBaU0J6ZEdGMGRYTUtJQ0FnSUM4dklISjFiR1V1YzNSaGRIVnpJRDBnYm1WM1gzTjBZWFIxY3dvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCeVpYQnNZV05sTWlBME1Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNelEyQ2lBZ0lDQXZMeUJ2Y0M1Q2IzZ3VjSFYwS0dKdmVGOXJaWGtzSUhKMWJHVXVZbmwwWlhNcENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qTTBPQzB6TkRrS0lDQWdJQzh2SUNNZ1RHOW5DaUFnSUNBdkx5QnNiMmNvWWlKU2RXeGxVM1JoZEhWelZYQmtZWFJsWkNJc0lHOXdMbWwwYjJJb2NuVnNaVjlwWkM1dVlYUnBkbVVwTENCdmNDNXBkRzlpS0c1bGQxOXpkR0YwZFhNdWJtRjBhWFpsS1NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVeU56VTJZelkxTlRNM05EWXhOelEzTlRjek5UVTNNRFkwTmpFM05EWTFOalFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TXpFMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRDNUJkWFJ2VUdsc2IzUlNkV3hsUTI5dWRISmhZM1F1ZFhCa1lYUmxYM0oxYkdWZmNHRnlZVzFsZEdWeWMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ3WkdGMFpWOXlkV3hsWDNCaGNtRnRaWFJsY25NNkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3pOVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReE5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXhOZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TXpjeExUTTNNZ29nSUNBZ0x5OGdJeUJNYjJGa0lISjFiR1VLSUNBZ0lDOHZJR0p2ZUY5clpYa2dQU0JVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJQ3NnYjNBdWFYUnZZaWh5ZFd4bFgybGtMbTVoZEdsMlpTa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1luUnZhUW9nSUNBZ2FYUnZZZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk16YzFDaUFnSUNBdkx5QnlkV3hsWDJKNWRHVnpMQ0JsZUdsemRITWdQU0J2Y0M1Q2IzZ3VaMlYwS0dKdmVGOXJaWGtwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qTTNOZ29nSUNBZ0x5OGdZWE56WlhKMElHVjRhWE4wY3l3Z0lsSjFiR1VnYm05MElHWnZkVzVrSWdvZ0lDQWdZWE56WlhKMElDOHZJRkoxYkdVZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3pOemt0TXpnd0NpQWdJQ0F2THlBaklGWmhiR2xrWVhSbENpQWdJQ0F2THlCaGMzTmxjblFnY25Wc1pTNXZkMjVsY2k1dVlYUnBkbVVnUFQwZ1ZIaHVMbk5sYm1SbGNpd2dJazV2ZENCeWRXeGxJRzkzYm1WeUlnb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRGdnTXpJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOTBJSEoxYkdVZ2IzZHVaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pNNE1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUcxaGVGOXpjR1Z1WkY5dGFXTnliMkZzWjI5ekxtNWhkR2wyWlNBK0lEQXNJQ0pOWVhnZ2MzQmxibVFnYlhWemRDQmlaU0ErSURBaUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWW5SdmFRb2dJQ0FnWVhOelpYSjBJQzh2SUUxaGVDQnpjR1Z1WkNCdGRYTjBJR0psSUQ0Z01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNemd5Q2lBZ0lDQXZMeUJoYzNObGNuUWdiV0Y0WDNOc2FYQndZV2RsWDJKd2N5NXVZWFJwZG1VZ1BEMGdUVUZZWDFOTVNWQlFRVWRGWDBKUVV5d2dJbE5zYVhCd1lXZGxJSFJ2YnlCb2FXZG9JZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHSjBiMmtLSUNBZ0lIQjFjMmhwYm5RZ05UQXdNQ0F2THlBMU1EQXdDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZOc2FYQndZV2RsSUhSdmJ5Qm9hV2RvQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvek9ETUtJQ0FnSUM4dklHRnpjMlZ5ZENCamIyOXNaRzkzYmw5dGFXNTFkR1Z6TG01aGRHbDJaU0ErUFNCTlNVNWZRMDlQVEVSUFYwNWZUVWxPVlZSRlV5d2dJa052YjJ4a2IzZHVJSFJ2YnlCemFHOXlkQ0lLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQndkWE5vYVc1MElEVWdMeThnTlFvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRiMjlzWkc5M2JpQjBiMjhnYzJodmNuUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPak00TlMwek9EWUtJQ0FnSUM4dklDTWdWWEJrWVhSbElIQmhjbUZ0WlhSbGNuTUtJQ0FnSUM4dklISjFiR1V1YldGNFgzTndaVzVrWDIxcFkzSnZZV3huYjNNZ1BTQnRZWGhmYzNCbGJtUmZiV2xqY205aGJHZHZjd29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0J5WlhCc1lXTmxNaUEwTlFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk16ZzNDaUFnSUNBdkx5QnlkV3hsTG0xaGVGOXpiR2x3Y0dGblpWOWljSE1nUFNCdFlYaGZjMnhwY0hCaFoyVmZZbkJ6Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhKbGNHeGhZMlV5SURVekNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3pPRGdLSUNBZ0lDOHZJSEoxYkdVdVkyOXZiR1J2ZDI1ZmJXbHVkWFJsY3lBOUlHTnZiMnhrYjNkdVgyMXBiblYwWlhNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2NtVndiR0ZqWlRJZ05UVUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPak01TUFvZ0lDQWdMeThnYjNBdVFtOTRMbkIxZENoaWIzaGZhMlY1TENCeWRXeGxMbUo1ZEdWektRb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TXpreUxUTTVNd29nSUNBZ0x5OGdJeUJNYjJjS0lDQWdJQzh2SUd4dlp5aGlJbEoxYkdWUVlYSmhiV1YwWlhKelZYQmtZWFJsWkNJc0lHOXdMbWwwYjJJb2NuVnNaVjlwWkM1dVlYUnBkbVVwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRJM05UWmpOalUxTURZeE56STJNVFprTmpVM05EWTFOekkzTXpVMU56QTJORFl4TnpRMk5UWTBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TXpVeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRDNUJkWFJ2VUdsc2IzUlNkV3hsUTI5dWRISmhZM1F1WkdWc1pYUmxYM0oxYkdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaV3hsZEdWZmNuVnNaVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pNNU5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzBNVEF0TkRFeENpQWdJQ0F2THlBaklFeHZZV1FnY25Wc1pTQm1hWEp6ZENCMGJ5QjJaWEpwWm5rZ2IzZHVaWEp6YUdsd0NpQWdJQ0F2THlCaWIzaGZhMlY1SUQwZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3lBcklHOXdMbWwwYjJJb2NuVnNaVjlwWkM1dVlYUnBkbVVwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvME1UUUtJQ0FnSUM4dklISjFiR1ZmWW5sMFpYTXNJR1Y0YVhOMGN5QTlJRzl3TGtKdmVDNW5aWFFvWW05NFgydGxlU2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5ERTFDaUFnSUNBdkx5QmhjM05sY25RZ1pYaHBjM1J6TENBaVVuVnNaU0J1YjNRZ1ptOTFibVFpQ2lBZ0lDQmhjM05sY25RZ0x5OGdVblZzWlNCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qUXhPQW9nSUNBZ0x5OGdZWE56WlhKMElISjFiR1V1YjNkdVpYSXVibUYwYVhabElEMDlJRlI0Ymk1elpXNWtaWElzSUNKT2IzUWdjblZzWlNCdmQyNWxjaUlLSUNBZ0lHVjRkSEpoWTNRZ09DQXpNZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYjNRZ2NuVnNaU0J2ZDI1bGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOREkwTFRReU5Rb2dJQ0FnTHk4Z0l5QkVaV3hsZEdVZ1ltOTRDaUFnSUNBdkx5QmtaV3hsZEdWa0lEMGdiM0F1UW05NExtUmxiR1YwWlNoaWIzaGZhMlY1S1FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOREkyQ2lBZ0lDQXZMeUJoYzNObGNuUWdaR1ZzWlhSbFpDd2dJa1poYVd4bFpDQjBieUJrWld4bGRHVWdZbTk0SWdvZ0lDQWdZWE56WlhKMElDOHZJRVpoYVd4bFpDQjBieUJrWld4bGRHVWdZbTk0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvME1qZ3RORE16Q2lBZ0lDQXZMeUFqSUZKbGRIVnliaUJOUWxJZ2RHOGdiM2R1WlhJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxaWIzaGZiV0p5TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8wTXpBS0lDQWdJQzh2SUhKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvME1qSUtJQ0FnSUM4dklHSnZlRjl0WW5JZ1BTQmliM2hmYzJsNlpTQXFJRlZKYm5RMk5DZzBNREFwSUNzZ1ZVbHVkRFkwS0RJMU1EQXBDaUFnSUNCd2RYTm9hVzUwSURJd056TXdNQ0F2THlBeU1EY3pNREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvME1qZ3ROREk1Q2lBZ0lDQXZMeUFqSUZKbGRIVnliaUJOUWxJZ2RHOGdiM2R1WlhJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qUXpNZ29nSUNBZ0x5OGdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5ESTRMVFF6TXdvZ0lDQWdMeThnSXlCU1pYUjFjbTRnVFVKU0lIUnZJRzkzYm1WeUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVltOTRYMjFpY2l3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pRek5TMDBNellLSUNBZ0lDOHZJQ01nVEc5bkNpQWdJQ0F2THlCc2IyY29ZaUpTZFd4bFJHVnNaWFJsWkNJc0lHOXdMbWwwYjJJb2NuVnNaVjlwWkM1dVlYUnBkbVVwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRJM05UWmpOalUwTkRZMU5tTTJOVGMwTmpVMk5Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPak01TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNRdVFYVjBiMUJwYkc5MFVuVnNaVU52Ym5SeVlXTjBMbWRsZEY5eWRXeGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzSjFiR1U2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvME16Z0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZORFUxQ2lBZ0lDQXZMeUJpYjNoZmEyVjVJRDBnYjNkdVpYSXVZbmwwWlhNZ0t5QnZjQzVwZEc5aUtISjFiR1ZmYVdRdWJtRjBhWFpsS1FvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzBOVGdLSUNBZ0lDOHZJSEoxYkdWZllubDBaWE1zSUdWNGFYTjBjeUE5SUc5d0xrSnZlQzVuWlhRb1ltOTRYMnRsZVNrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPalExT1FvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN5d2dJbEoxYkdVZ2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWVhOelpYSjBJQzh2SUZKMWJHVWdibTkwSUdadmRXNWtDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8wTXpnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wTGtGMWRHOVFhV3h2ZEZKMWJHVkRiMjUwY21GamRDNW5aWFJmY25Wc1pWOXpkR0YwYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjl5ZFd4bFgzTjBZWFJ6T2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5EWXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPalEzT1FvZ0lDQWdMeThnWW05NFgydGxlU0E5SUc5M2JtVnlMbUo1ZEdWeklDc2diM0F1YVhSdllpaHlkV3hsWDJsa0xtNWhkR2wyWlNrS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZORGd5Q2lBZ0lDQXZMeUJ5ZFd4bFgySjVkR1Z6TENCbGVHbHpkSE1nUFNCdmNDNUNiM2d1WjJWMEtHSnZlRjlyWlhrcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8wT0RNS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITXNJQ0pTZFd4bElHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdGemMyVnlkQ0F2THlCU2RXeGxJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TkRnM0NpQWdJQ0F2THlCeWRXeGxMblJ2ZEdGc1gyVjRaV04xZEdsdmJuTXNDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTnpFZ05Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZORGc0Q2lBZ0lDQXZMeUJ5ZFd4bExuUnZkR0ZzWDNOd1pXNTBYMjFwWTNKdllXeG5iM01zQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQTNOU0E0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvME9Ea0tJQ0FnSUM4dklISjFiR1V1YkdGemRGOWxlR1ZqZFhScGIyNWZkR2x0WlhOMFlXMXdMQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBJRFl6SURnS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qUTROaTAwT1RBS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsUjFjR3hsS0NnS0lDQWdJQzh2SUNBZ0lDQnlkV3hsTG5SdmRHRnNYMlY0WldOMWRHbHZibk1zQ2lBZ0lDQXZMeUFnSUNBZ2NuVnNaUzUwYjNSaGJGOXpjR1Z1ZEY5dGFXTnliMkZzWjI5ekxBb2dJQ0FnTHk4Z0lDQWdJSEoxYkdVdWJHRnpkRjlsZUdWamRYUnBiMjVmZEdsdFpYTjBZVzF3TEFvZ0lDQWdMeThnS1NrS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvME5qSUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMExrRjFkRzlRYVd4dmRGSjFiR1ZEYjI1MGNtRmpkQzV6WlhSZmNISnZkRzlqYjJ4ZlptVmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFgzQnliM1J2WTI5c1gyWmxaVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pRNU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERFMkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzFNRFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXVjSEp2ZEc5amIyeGZkSEpsWVhOMWNua3NJQ0pQYm14NUlHRmtiV2x1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luQnliM1J2WTI5c1gzUnlaV0Z6ZFhKNUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJ5YjNSdlkyOXNYM1J5WldGemRYSjVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvMU1EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCdVpYZGZabVZsWDJKd2N5NXVZWFJwZG1VZ1BEMGdNVEF3TENBaVJtVmxJSFJ2YnlCb2FXZG9JQ2h0WVhnZ01TVXBJZ29nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFd01DQXZMeUF4TURBS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdSbVZsSUhSdmJ5Qm9hV2RvSUNodFlYZ2dNU1VwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvMU1EY0tJQ0FnSUM4dklITmxiR1l1Y0hKdmRHOWpiMnhmWm1WbFgySndjeUE5SUc1bGQxOW1aV1ZmWW5CekxtNWhkR2wyWlFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpY0hKdmRHOWpiMnhmWm1WbFgySndjeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5UQTRDaUFnSUNBdkx5QnNiMmNvWWlKUWNtOTBiMk52YkVabFpWVndaR0YwWldRaUxDQnZjQzVwZEc5aUtHNWxkMTltWldWZlluQnpMbTVoZEdsMlpTa3BDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzFNRGN5Tm1ZM05EWm1Oak0yWmpaak5EWTJOVFkxTlRVM01EWTBOakUzTkRZMU5qUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8wT1RJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMExrRjFkRzlRYVd4dmRGSjFiR1ZEYjI1MGNtRmpkQzV2Y0hSZmFXNWZZWE56WlhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHZjSFJmYVc1ZllYTnpaWFE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvMU1UQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOVEkwQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbkJ5YjNSdlkyOXNYM1J5WldGemRYSjVMQ0FpVDI1c2VTQmhaRzFwYmlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSndjbTkwYjJOdmJGOTBjbVZoYzNWeWVTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3Y205MGIyTnZiRjkwY21WaGMzVnllU0JsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmhaRzFwYmdvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5USTJMVFV6TWdvZ0lDQWdMeThnSXlCUGNIUXRhVzRnZG1saElHbHVibVZ5SUhSeVlXNXpZV04wYVc5dUlDaDBjbUZ1YzJabGNpQXdJSFJ2SUhObGJHWXBDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxaGMzTmxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qVXlPUW9nSUNBZ0x5OGdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzFNekFLSUNBZ0lDOHZJR0Z6YzJWMFgyRnRiM1Z1ZEQxVlNXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvMU1qWXROVEkzQ2lBZ0lDQXZMeUFqSUU5d2RDMXBiaUIyYVdFZ2FXNXVaWElnZEhKaGJuTmhZM1JwYjI0Z0tIUnlZVzV6Wm1WeUlEQWdkRzhnYzJWc1ppa0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TlRNeENpQWdJQ0F2THlCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8xTWpZdE5UTXlDaUFnSUNBdkx5QWpJRTl3ZEMxcGJpQjJhV0VnYVc1dVpYSWdkSEpoYm5OaFkzUnBiMjRnS0hSeVlXNXpabVZ5SURBZ2RHOGdjMlZzWmlrS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQV0Z6YzJWMExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pVek5Bb2dJQ0FnTHk4Z2JHOW5LR0lpUVhOelpYUlBjSFJKYmlJc0lHOXdMbWwwYjJJb1lYTnpaWFF1YVdRcEtRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEUXhOek0zTXpZMU56UTBaamN3TnpRME9UWmxDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TlRFd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRDNUJkWFJ2VUdsc2IzUlNkV3hsUTI5dWRISmhZM1F1YzJWMFgzQmhkWE5sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBYM0JoZFhObE9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOVE0yQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8xTkRnS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1Y0hKdmRHOWpiMnhmZEhKbFlYTjFjbmtzSUNKUGJteDVJR0ZrYldsdUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkJ5YjNSdlkyOXNYM1J5WldGemRYSjVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CeWIzUnZZMjlzWDNSeVpXRnpkWEo1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR0ZrYldsdUNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzFORGtLSUNBZ0lDOHZJSE5sYkdZdWFYTmZjR0YxYzJWa0lEMGdjR0YxYzJWa0xtNWhkR2wyWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYVhOZmNHRjFjMlZrSWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzFOVEVLSUNBZ0lDOHZJR3h2WnloaUlsQmhkWE5sVlhCa1lYUmxaQ0lzSUc5d0xtbDBiMklvVlVsdWREWTBLREVwSUdsbUlIQmhkWE5sWkM1dVlYUnBkbVVnWld4elpTQlZTVzUwTmpRb01Da3BLUW9nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjROVEEyTVRjMU56TTJOVFUxTnpBMk5EWXhOelEyTlRZMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOVE0yQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCamIyNTBjbUZqZEM1QmRYUnZVR2xzYjNSU2RXeGxRMjl1ZEhKaFkzUXVaMlYwWDJOdmJuUnlZV04wWDNOMFlYUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyTnZiblJ5WVdOMFgzTjBZWFJ6T2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5qWTRDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuSjFiR1ZmWTI5MWJuUmxjaWtzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljblZzWlY5amIzVnVkR1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuSjFiR1ZmWTI5MWJuUmxjaUJsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPalkyT1FvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjNSaGJGOWxlR1ZqZFhScGIyNXpLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiM1JoYkY5bGVHVmpkWFJwYjI1eklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyVjRaV04xZEdsdmJuTWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzJOekFLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkREUyS0hObGJHWXVjSEp2ZEc5amIyeGZabVZsWDJKd2N5a3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWNISnZkRzlqYjJ4ZlptVmxYMkp3Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdjbTkwYjJOdmJGOW1aV1ZmWW5CeklHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlhWFJzWlc0S0lDQWdJSEIxYzJocGJuUWdNVFlnTHk4Z01UWUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8yTmpjdE5qY3hDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVVZFhCc1pTZ29DaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTV5ZFd4bFgyTnZkVzUwWlhJcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkRzkwWVd4ZlpYaGxZM1YwYVc5dWN5a3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTVRZb2MyVnNaaTV3Y205MGIyTnZiRjltWldWZlluQnpLU3dLSUNBZ0lDOHZJQ2twQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TmpVNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlBaVlIRVhCeWIzUnZZMjlzWDNSeVpXRnpkWEo1QkJVZmZIVU1jblZzWlY5amIzVnVkR1Z5RUhSdmRHRnNYMlY0WldOMWRHbHZibk1KYVhOZmNHRjFjMlZrRUhCeWIzUnZZMjlzWDJabFpWOWljSE1LUVhOelpYUlBjSFJKYmpFWVFBQVRLaUpuS3lKbkp3V0JDbWNvTWdsbkp3UWlaekViUVFDVE1Sa1VSREVZUVFCVmdnc0VJd1R2bmdTZGI0QVhCR1FqYytnRTlPSEE5Z1RzckRHaEJLbytSVVFFV1pPR0VBUk01QkFXQk9QTjd6c0U3bG1aV0FTQTV5bDdOaG9BamdzQWFBRjdBMElEblFRT0JFOEViQVNjQk5FRS9RVW9BSUFFL0szQ1hEWWFBSTRCQUFFQWdDSVZIM3gxQUJ4QmRYUnZVR2xzYjNRZ1VuVnNaU0JEYjI1MGNtRmpkQ0IyTVM0d3NDTkRNUmtVTVJnUVJERUFJaWhsUkJKRU1URWpFa1EyTUFDeE1nb2lzaEt5RkVteUVZRUVzaEFpc2dHekZpY0dURkN3STBNMkdnRkpGU01TUkRZYUFra2lXVWtrQ3lVSVN3SVZFa1EyR2dOSkZTTVNSRFlhQkVrVkpCSkVOaG9GU1JVbEVrUTJHZ1pKRlNVU1JEWWFCMGtWSXhKRU5ob0lTUlVsRWtRMkdnbEpGU1VTUkRFV0l3bEpPQkFqRWtRaUp3UmxSQlJFU3dvWGdRTU9SRThJUkVzR0YwUkxCUmVCaUNjT1JFc0VGNEVGRDBSTEF4ZUJBdzVFU1RnSE1nb1NSRGdJZ1lpSkNnOUVJaXBsUkNNSUtrc0JaMDhEVHdOUVR3SlFnQUVBVUV3V01RQXlCeFpMQWs4Q1VFOEpVSUFEQVFCYlVFOEhVRThHVUU4RlVFOEVVRThEVUlBVUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQlFURkJQQWxBeEFFc0NVRXNCRlVzQlRMbElUTCtBQzFKMWJHVkRjbVZoZEdWa1N3RlFNUUJRc0NsTVVMQWpReUpIQW9BQVNUWWFBVWtWSkJKRU5ob0NTUldCSUJKRU5ob0RTUlVrRWtRWFNUWWFCRWtWSkJKRUYwdzJHZ1ZKVGdJVkpCSkVOaG9HU1U0Q0ZTUVNSRFlhQjBrVkpCSkVGMHcyR2doSkZTUVNSQmRNTWdRbEVrUkFBVkVpT0JBakVrUWlPQWN5Q2hKRUlqZ0lTd1FYU1VVTUVrUkxCeGNXU1VVTVN3ZEpUd0pRU1VVUHZreEpUZ0pGRDBRaUp3UmxSQlJFU1lFcFZTTVNSRElIU3dHQlAxc0pUSUUzV1lFOEN3OUVNUUFTUUFBSU1RQXlDaEpCQVBBalJFc0xnUzFiU3dvUFJFc0NGMFVKU3dWQUFNQ3hTd0Z5Q0VSTENySUlzZ2Nqc2hBaXNnR3pzVWtXU3dZV1N3WkpUZ01XU3cxSlRnVVdTdzVKVGdVV2dBUVBMMjkvc2hwUEJMSWFUd095R2s4Q3NocExBYklhc2hwTEJVbXlHSUVHc2hBaXNnR3p0RDRYU1U4RUQwU3hUSElJUkRJS1R3S3lFcklVc2hOTXNoR0JCTElRSXJJQnN6SUhGa3NPVEZ3L1NZRkhXaU1JRmttVGdTQU9SRmNFQkZ4SFNZRkxXMDhEQ0JaY1Mwc09UTDhpSzJWRUl3Z3JUR2VBREZKMWJHVkZlR1ZqZFhSbFpFc01VRXhRc0NsTEJGQ3dJME94U3dGeUNFUkxDcklTc2hSTEJiSVJnUVN5RUNLeUFiTkMvemdpUXY4TklqZ1FnUVFTUkNJNEVVc0dFa1FpT0JReUNoSkVJamdTUXY2a05ob0JTUlVrRWtRMkdnSkpGU01TUkRFQVR3SVhGa3hMQVZCSnZrUkpWd2dnTVFBU1JFc0RGMG1CQXc1RVN3R0JLVldCQXhORVRFOEVYQ2xQQWt5L2dCRlNkV3hsVTNSaGRIVnpWWEJrWVhSbFpFOENVRXdXVUxBalF6WWFBVWtWSkJKRU5ob0NTUlVrRWtRMkdnTkpGU1VTUkRZYUJFa1ZKUkpFTVFCUEJCY1dURXNCVUVtK1JFbFhDQ0F4QUJKRVN3VVhSRXNFRjRHSUp3NUVTd01YZ1FVUFJFOEZYQzFQQkZ3MVR3TmNONytBRlZKMWJHVlFZWEpoYldWMFpYSnpWWEJrWVhSbFpFeFFzQ05ETmhvQlNSVWtFa1F4QUV3WEZreExBVkJKdmtSWENDQXhBQkpFdkVTeE1RQ0J4Tk1Nc2dpeUJ5T3lFQ0t5QWJPQUMxSjFiR1ZFWld4bGRHVmtURkN3STBNMkdnRkpGU1FTUkRZYUFra1ZnU0FTUkV3WEZsQytSQ2xNVUxBalF6WWFBVWtWSkJKRU5ob0NTUldCSUJKRVRCY1dVTDVFU1ZkSEJFc0JWMHNJVHdKWFB3aE9BbEJNVUNsTVVMQWpRellhQVVrVkpSSkVNUUFpS0dWRUVrUVhTWUZrRGtRbkJVc0JaeGFBRWxCeWIzUnZZMjlzUm1WbFZYQmtZWFJsWkV4UXNDTkROaG9CU1JVa0VrUVhNUUFpS0dWRUVrU3hNZ29pc2hLeUZFbXlFWUVFc2hBaXNnR3pGaWNHVEZDd0kwTTJHZ0ZKRlNNU1JERUFJaWhsUkJKRUlsTW5CRXNCWnhhQURGQmhkWE5sVlhCa1lYUmxaRXhRc0NORElpcGxSQllpSzJWRUZpSW5CV1ZFRmttVGdSQU9SRmNHQWs0Q1VFeFFLVXhRc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjQsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
