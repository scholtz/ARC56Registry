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

namespace Arc56.Generated.gurubazawada.AgriGuard.AgriGuardInsurance_479d0631
{


    //
    // 
    //    Enhanced AgriGuard Insurance Contract with Algorand Features
    //
    //    Features:
    //    - Buy policy with group transaction (payment + function call)
    //    - Oracle settlement with asset transfers
    //    - Policy storage by owner address with enhanced box management
    //    - Event logging for transparency
    //    - Cross-contract dispute resolution
    //    - Asset-based fee management
    //    - Time-based policy validation
    //    
    //
    public class AgriGuardInsuranceProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgriGuardInsuranceProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class PolicyData : AVMObjectType
            {
                public Algorand.Address Owner { get; set; }

                public string ZipCode { get; set; }

                public ulong T0 { get; set; }

                public ulong T1 { get; set; }

                public ulong Cap { get; set; }

                public ulong Direction { get; set; }

                public ulong Threshold { get; set; }

                public ulong Slope { get; set; }

                public ulong FeePaid { get; set; }

                public ulong Settled { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vZipCode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vZipCode.From(ZipCode);
                    stringRef[ret.Count] = vZipCode.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vT0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vT0.From(T0);
                    ret.AddRange(vT0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vT1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vT1.From(T1);
                    ret.AddRange(vT1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCap = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCap.From(Cap);
                    ret.AddRange(vCap.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDirection = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDirection.From(Direction);
                    ret.AddRange(vDirection.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vThreshold = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vThreshold.From(Threshold);
                    ret.AddRange(vThreshold.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSlope = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSlope.From(Slope);
                    ret.AddRange(vSlope.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeePaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFeePaid.From(FeePaid);
                    ret.AddRange(vFeePaid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSettled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSettled.From(Settled);
                    ret.AddRange(vSettled.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PolicyData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new PolicyData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    var indexZipCode = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vZipCode = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vZipCode.Decode(bytes.Skip(indexZipCode + prefixOffset).ToArray());
                    var valueZipCode = vZipCode.ToValue();
                    if (valueZipCode is string vZipCodeValue) { ret.ZipCode = vZipCodeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vT0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vT0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueT0 = vT0.ToValue();
                    if (valueT0 is ulong vT0Value) { ret.T0 = vT0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vT1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vT1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueT1 = vT1.ToValue();
                    if (valueT1 is ulong vT1Value) { ret.T1 = vT1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCap = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCap.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCap = vCap.ToValue();
                    if (valueCap is ulong vCapValue) { ret.Cap = vCapValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDirection = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDirection.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDirection = vDirection.ToValue();
                    if (valueDirection is ulong vDirectionValue) { ret.Direction = vDirectionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vThreshold = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vThreshold.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueThreshold = vThreshold.ToValue();
                    if (valueThreshold is ulong vThresholdValue) { ret.Threshold = vThresholdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSlope = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSlope.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSlope = vSlope.ToValue();
                    if (valueSlope is ulong vSlopeValue) { ret.Slope = vSlopeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeePaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFeePaid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFeePaid = vFeePaid.ToValue();
                    if (valueFeePaid is ulong vFeePaidValue) { ret.FeePaid = vFeePaidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSettled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSettled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSettled = vSettled.ToValue();
                    if (valueSettled is ulong vSettledValue) { ret.Settled = vSettledValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PolicyData);
                }
                public bool Equals(PolicyData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PolicyData left, PolicyData right)
                {
                    return EqualityComparer<PolicyData>.Default.Equals(left, right);
                }
                public static bool operator !=(PolicyData left, PolicyData right)
                {
                    return !(left == right);
                }

            }

            public class InsuranceStats : AVMObjectType
            {
                public ulong TotalPolicies { get; set; }

                public ulong TotalCoverage { get; set; }

                public ulong TotalPayouts { get; set; }

                public ulong ActivePolicies { get; set; }

                public ulong TotalFeesCollected { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalPolicies = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalPolicies.From(TotalPolicies);
                    ret.AddRange(vTotalPolicies.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalCoverage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalCoverage.From(TotalCoverage);
                    ret.AddRange(vTotalCoverage.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalPayouts = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalPayouts.From(TotalPayouts);
                    ret.AddRange(vTotalPayouts.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActivePolicies = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vActivePolicies.From(ActivePolicies);
                    ret.AddRange(vActivePolicies.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalFeesCollected = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalFeesCollected.From(TotalFeesCollected);
                    ret.AddRange(vTotalFeesCollected.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static InsuranceStats Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new InsuranceStats();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalPolicies = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalPolicies.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalPolicies = vTotalPolicies.ToValue();
                    if (valueTotalPolicies is ulong vTotalPoliciesValue) { ret.TotalPolicies = vTotalPoliciesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalCoverage = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalCoverage.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalCoverage = vTotalCoverage.ToValue();
                    if (valueTotalCoverage is ulong vTotalCoverageValue) { ret.TotalCoverage = vTotalCoverageValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalPayouts = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalPayouts.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalPayouts = vTotalPayouts.ToValue();
                    if (valueTotalPayouts is ulong vTotalPayoutsValue) { ret.TotalPayouts = vTotalPayoutsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActivePolicies = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vActivePolicies.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActivePolicies = vActivePolicies.ToValue();
                    if (valueActivePolicies is ulong vActivePoliciesValue) { ret.ActivePolicies = vActivePoliciesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalFeesCollected = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalFeesCollected.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalFeesCollected = vTotalFeesCollected.ToValue();
                    if (valueTotalFeesCollected is ulong vTotalFeesCollectedValue) { ret.TotalFeesCollected = vTotalFeesCollectedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as InsuranceStats);
                }
                public bool Equals(InsuranceStats? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(InsuranceStats left, InsuranceStats right)
                {
                    return EqualityComparer<InsuranceStats>.Default.Equals(left, right);
                }
                public static bool operator !=(InsuranceStats left, InsuranceStats right)
                {
                    return !(left == right);
                }

            }

            public class PolicyEvent : AVMObjectType
            {
                public ulong PolicyId { get; set; }

                public Algorand.Address Owner { get; set; }

                public string Action { get; set; }

                public ulong Timestamp { get; set; }

                public ulong Amount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPolicyId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPolicyId.From(PolicyId);
                    ret.AddRange(vPolicyId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAction = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAction.From(Action);
                    stringRef[ret.Count] = vAction.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PolicyEvent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new PolicyEvent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPolicyId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPolicyId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePolicyId = vPolicyId.ToValue();
                    if (valuePolicyId is ulong vPolicyIdValue) { ret.PolicyId = vPolicyIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    var indexAction = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAction = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAction.Decode(bytes.Skip(indexAction + prefixOffset).ToArray());
                    var valueAction = vAction.ToValue();
                    if (valueAction is string vActionValue) { ret.Action = vActionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PolicyEvent);
                }
                public bool Equals(PolicyEvent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PolicyEvent left, PolicyEvent right)
                {
                    return EqualityComparer<PolicyEvent>.Default.Equals(left, right);
                }
                public static bool operator !=(PolicyEvent left, PolicyEvent right)
                {
                    return !(left == right);
                }

            }

            public class GetPoliciesByOwnerReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetPoliciesByOwnerReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetPoliciesByOwnerReturn();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetPoliciesByOwnerReturn);
                }
                public bool Equals(GetPoliciesByOwnerReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetPoliciesByOwnerReturn left, GetPoliciesByOwnerReturn right)
                {
                    return EqualityComparer<GetPoliciesByOwnerReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetPoliciesByOwnerReturn left, GetPoliciesByOwnerReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetGlobalsReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
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

                public static GetGlobalsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetGlobalsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
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

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetGlobalsReturn);
                }
                public bool Equals(GetGlobalsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetGlobalsReturn left, GetGlobalsReturn right)
                {
                    return EqualityComparer<GetGlobalsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetGlobalsReturn left, GetGlobalsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the application with admin and setup enhanced features
        ///</summary>
        /// <param name="admin"> </param>
        public async Task CreateApplication(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 74, 113, 110 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 74, 113, 110 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set the dispute resolution contract address (admin only)
        ///</summary>
        /// <param name="dispute_contract"> </param>
        public async Task<ulong> SetDisputeContract(Algorand.Address dispute_contract, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 215, 239, 53 };
            var dispute_contractAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); dispute_contractAbi.From(dispute_contract);

            var result = await base.CallApp(new List<object> { abiHandle, dispute_contractAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetDisputeContract_Transactions(Algorand.Address dispute_contract, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 215, 239, 53 };
            var dispute_contractAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); dispute_contractAbi.From(dispute_contract);

            return await base.MakeTransactionList(new List<object> { abiHandle, dispute_contractAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set oracle account (admin only)
        ///</summary>
        /// <param name="oracle"> </param>
        public async Task SetOracle(Algorand.Address oracle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 104, 245, 86 };
            var oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); oracleAbi.From(oracle);

            var result = await base.CallApp(new List<object> { abiHandle, oracleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetOracle_Transactions(Algorand.Address oracle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 104, 245, 86 };
            var oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); oracleAbi.From(oracle);

            return await base.MakeTransactionList(new List<object> { abiHandle, oracleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current oracle account address
        ///</summary>
        public async Task<Algorand.Address> GetOracle(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 46, 105, 28 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetOracle_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 46, 105, 28 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buy insurance policy with integrated payment using group transaction
        ///Enhanced with validation, event logging, and statistics tracking Expects to be called as part of a group transaction where: - Transaction 1: Payment from user to contract - Transaction 2: This function call
        ///</summary>
        /// <param name="zip_code"> </param>
        /// <param name="t0"> </param>
        /// <param name="t1"> </param>
        /// <param name="cap"> </param>
        /// <param name="direction"> </param>
        /// <param name="threshold"> </param>
        /// <param name="slope"> </param>
        /// <param name="fee"> </param>
        public async Task<ulong> BuyPolicyWithPayment(byte[] zip_code, ulong t0, ulong t1, ulong cap, ulong direction, ulong threshold, ulong slope, ulong fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 23, 33, 214 };
            var zip_codeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); zip_codeAbi.From(zip_code);
            var t0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); t0Abi.From(t0);
            var t1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); t1Abi.From(t1);
            var capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); capAbi.From(cap);
            var directionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); directionAbi.From(direction);
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);
            var slopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); slopeAbi.From(slope);
            var feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeAbi.From(fee);

            var result = await base.CallApp(new List<object> { abiHandle, zip_codeAbi, t0Abi, t1Abi, capAbi, directionAbi, thresholdAbi, slopeAbi, feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BuyPolicyWithPayment_Transactions(byte[] zip_code, ulong t0, ulong t1, ulong cap, ulong direction, ulong threshold, ulong slope, ulong fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 23, 33, 214 };
            var zip_codeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); zip_codeAbi.From(zip_code);
            var t0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); t0Abi.From(t0);
            var t1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); t1Abi.From(t1);
            var capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); capAbi.From(cap);
            var directionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); directionAbi.From(direction);
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);
            var slopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); slopeAbi.From(slope);
            var feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeAbi.From(fee);

            return await base.MakeTransactionList(new List<object> { abiHandle, zip_codeAbi, t0Abi, t1Abi, capAbi, directionAbi, thresholdAbi, slopeAbi, feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buy insurance policy (simple version for testing)
        ///Payment should be sent to contract address before calling this method
        ///</summary>
        /// <param name="zip_code"> </param>
        /// <param name="t0"> </param>
        /// <param name="t1"> </param>
        /// <param name="cap"> </param>
        /// <param name="direction"> </param>
        /// <param name="threshold"> </param>
        /// <param name="slope"> </param>
        /// <param name="fee"> </param>
        public async Task<ulong> BuyPolicy(byte[] zip_code, ulong t0, ulong t1, ulong cap, ulong direction, ulong threshold, ulong slope, ulong fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 249, 146, 172 };
            var zip_codeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); zip_codeAbi.From(zip_code);
            var t0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); t0Abi.From(t0);
            var t1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); t1Abi.From(t1);
            var capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); capAbi.From(cap);
            var directionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); directionAbi.From(direction);
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);
            var slopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); slopeAbi.From(slope);
            var feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeAbi.From(fee);

            var result = await base.CallApp(new List<object> { abiHandle, zip_codeAbi, t0Abi, t1Abi, capAbi, directionAbi, thresholdAbi, slopeAbi, feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BuyPolicy_Transactions(byte[] zip_code, ulong t0, ulong t1, ulong cap, ulong direction, ulong threshold, ulong slope, ulong fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 249, 146, 172 };
            var zip_codeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); zip_codeAbi.From(zip_code);
            var t0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); t0Abi.From(t0);
            var t1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); t1Abi.From(t1);
            var capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); capAbi.From(cap);
            var directionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); directionAbi.From(direction);
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);
            var slopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); slopeAbi.From(slope);
            var feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeAbi.From(fee);

            return await base.MakeTransactionList(new List<object> { abiHandle, zip_codeAbi, t0Abi, t1Abi, capAbi, directionAbi, thresholdAbi, slopeAbi, feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Enhanced oracle settlement with cross-contract communication and event logging
        ///If approved == 1 → payout = cap; else 0
        ///</summary>
        /// <param name="policy_id"> </param>
        /// <param name="approved"> </param>
        public async Task<ulong> OracleSettle(ulong policy_id, ulong approved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 144, 159, 56 };
            var policy_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_idAbi.From(policy_id);
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvedAbi.From(approved);

            var result = await base.CallApp(new List<object> { abiHandle, policy_idAbi, approvedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> OracleSettle_Transactions(ulong policy_id, ulong approved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 144, 159, 56 };
            var policy_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_idAbi.From(policy_id);
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvedAbi.From(approved);

            return await base.MakeTransactionList(new List<object> { abiHandle, policy_idAbi, approvedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Enhanced dispute creation with cross-contract communication
        ///Only the policy owner can dispute their own policy
        ///</summary>
        /// <param name="policy_id"> </param>
        /// <param name="reason"> </param>
        public async Task<ulong> DisputeSettlement(ulong policy_id, string reason, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 22, 137, 162 };
            var policy_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_idAbi.From(policy_id);
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasonAbi.From(reason);

            var result = await base.CallApp(new List<object> { abiHandle, policy_idAbi, reasonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DisputeSettlement_Transactions(ulong policy_id, string reason, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 22, 137, 162 };
            var policy_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_idAbi.From(policy_id);
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasonAbi.From(reason);

            return await base.MakeTransactionList(new List<object> { abiHandle, policy_idAbi, reasonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get policy data by ID
        ///</summary>
        /// <param name="policy_id"> </param>
        public async Task<Structs.PolicyData> GetPolicy(ulong policy_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 13, 224, 43 };
            var policy_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_idAbi.From(policy_id);

            var result = await base.SimApp(new List<object> { abiHandle, policy_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PolicyData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPolicy_Transactions(ulong policy_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 13, 224, 43 };
            var policy_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_idAbi.From(policy_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, policy_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get all policy IDs for a specific owner
        ///Returns: (count, first_policy_id) Note: This is a simplified implementation for MVP
        ///</summary>
        /// <param name="owner"> </param>
        public async Task<Structs.GetPoliciesByOwnerReturn> GetPoliciesByOwner(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 120, 246, 227 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetPoliciesByOwnerReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPoliciesByOwner_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 120, 246, 227 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total number of policies created
        ///</summary>
        public async Task<ulong> GetPolicyCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 246, 213, 26 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPolicyCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 246, 213, 26 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate policy fee based on risk parameters
        ///Formula: base_fee * risk_multiplier * uncertainty_multiplier * duration_multiplier
        ///</summary>
        /// <param name="cap"> </param>
        /// <param name="risk_score"> </param>
        /// <param name="uncertainty"> </param>
        /// <param name="duration_days"> </param>
        public async Task<ulong> CalculateFee(ulong cap, ulong risk_score, ulong uncertainty, ulong duration_days, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 32, 2, 12 };
            var capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); capAbi.From(cap);
            var risk_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); risk_scoreAbi.From(risk_score);
            var uncertaintyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); uncertaintyAbi.From(uncertainty);
            var duration_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_daysAbi.From(duration_days);

            var result = await base.SimApp(new List<object> { abiHandle, capAbi, risk_scoreAbi, uncertaintyAbi, duration_daysAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateFee_Transactions(ulong cap, ulong risk_score, ulong uncertainty, ulong duration_days, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 32, 2, 12 };
            var capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); capAbi.From(cap);
            var risk_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); risk_scoreAbi.From(risk_score);
            var uncertaintyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); uncertaintyAbi.From(uncertainty);
            var duration_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_daysAbi.From(duration_days);

            return await base.MakeTransactionList(new List<object> { abiHandle, capAbi, risk_scoreAbi, uncertaintyAbi, duration_daysAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete a policy by ID - only the owner can delete their own unsettled policy
        ///Returns: 1 if successful, 0 if failed
        ///</summary>
        /// <param name="policy_id"> </param>
        public async Task<ulong> DeletePolicy(ulong policy_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 227, 27, 190 };
            var policy_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_idAbi.From(policy_id);

            var result = await base.CallApp(new List<object> { abiHandle, policy_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DeletePolicy_Transactions(ulong policy_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 227, 27, 190 };
            var policy_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_idAbi.From(policy_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, policy_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get global state
        ///</summary>
        public async Task<Structs.GetGlobalsReturn> GetGlobals(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 14, 32, 72 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetGlobalsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetGlobals_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 14, 32, 72 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get comprehensive insurance statistics
        ///</summary>
        public async Task<Structs.InsuranceStats> GetStatistics(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 13, 31, 71 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.InsuranceStats.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetStatistics_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 13, 31, 71 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get a specific event by ID
        ///</summary>
        /// <param name="event_id"> </param>
        public async Task<Structs.PolicyEvent> GetEvent(ulong event_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 127, 114, 82 };
            var event_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); event_idAbi.From(event_id);

            var result = await base.SimApp(new List<object> { abiHandle, event_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.PolicyEvent.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetEvent_Transactions(ulong event_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 127, 114, 82 };
            var event_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); event_idAbi.From(event_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, event_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get recent events (returns count and starting event ID)
        ///</summary>
        /// <param name="limit"> </param>
        public async Task<Structs.GetPoliciesByOwnerReturn> GetRecentEvents(ulong limit, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 91, 179, 15 };
            var limitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); limitAbi.From(limit);

            var result = await base.SimApp(new List<object> { abiHandle, limitAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetPoliciesByOwnerReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRecentEvents_Transactions(ulong limit, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 91, 179, 15 };
            var limitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); limitAbi.From(limit);

            return await base.MakeTransactionList(new List<object> { abiHandle, limitAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Validate if a policy is currently active based on timing
        ///</summary>
        /// <param name="policy_id"> </param>
        public async Task<ulong> ValidatePolicyTiming(ulong policy_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 116, 70, 224 };
            var policy_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_idAbi.From(policy_id);

            var result = await base.SimApp(new List<object> { abiHandle, policy_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ValidatePolicyTiming_Transactions(ulong policy_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 116, 70, 224 };
            var policy_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_idAbi.From(policy_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, policy_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdyaUd1YXJkSW5zdXJhbmNlIiwiZGVzYyI6IlxuICAgIEVuaGFuY2VkIEFncmlHdWFyZCBJbnN1cmFuY2UgQ29udHJhY3Qgd2l0aCBBbGdvcmFuZCBGZWF0dXJlc1xuXG4gICAgRmVhdHVyZXM6XG4gICAgLSBCdXkgcG9saWN5IHdpdGggZ3JvdXAgdHJhbnNhY3Rpb24gKHBheW1lbnQgKyBmdW5jdGlvbiBjYWxsKVxuICAgIC0gT3JhY2xlIHNldHRsZW1lbnQgd2l0aCBhc3NldCB0cmFuc2ZlcnNcbiAgICAtIFBvbGljeSBzdG9yYWdlIGJ5IG93bmVyIGFkZHJlc3Mgd2l0aCBlbmhhbmNlZCBib3ggbWFuYWdlbWVudFxuICAgIC0gRXZlbnQgbG9nZ2luZyBmb3IgdHJhbnNwYXJlbmN5XG4gICAgLSBDcm9zcy1jb250cmFjdCBkaXNwdXRlIHJlc29sdXRpb25cbiAgICAtIEFzc2V0LWJhc2VkIGZlZSBtYW5hZ2VtZW50XG4gICAgLSBUaW1lLWJhc2VkIHBvbGljeSB2YWxpZGF0aW9uXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlBvbGljeURhdGEiOlt7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiemlwX2NvZGUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoidDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY2FwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRpcmVjdGlvbiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0aHJlc2hvbGQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic2xvcGUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmVlX3BhaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic2V0dGxlZCIsInR5cGUiOiJ1aW50NjQifV0sIkluc3VyYW5jZVN0YXRzIjpbeyJuYW1lIjoidG90YWxfcG9saWNpZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfY292ZXJhZ2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfcGF5b3V0cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhY3RpdmVfcG9saWNpZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfZmVlc19jb2xsZWN0ZWQiLCJ0eXBlIjoidWludDY0In1dLCJQb2xpY3lFdmVudCI6W3sibmFtZSI6InBvbGljeV9pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYWN0aW9uIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDY0In1dLCJHZXRQb2xpY2llc0J5T3duZXJSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0R2xvYmFsc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9hcHBsaWNhdGlvbiIsImRlc2MiOiJJbml0aWFsaXplIHRoZSBhcHBsaWNhdGlvbiB3aXRoIGFkbWluIGFuZCBzZXR1cCBlbmhhbmNlZCBmZWF0dXJlcyIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2Rpc3B1dGVfY29udHJhY3QiLCJkZXNjIjoiU2V0IHRoZSBkaXNwdXRlIHJlc29sdXRpb24gY29udHJhY3QgYWRkcmVzcyAoYWRtaW4gb25seSkiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRpc3B1dGVfY29udHJhY3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfb3JhY2xlIiwiZGVzYyI6IlNldCBvcmFjbGUgYWNjb3VudCAoYWRtaW4gb25seSkiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yYWNsZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfb3JhY2xlIiwiZGVzYyI6IkdldCBjdXJyZW50IG9yYWNsZSBhY2NvdW50IGFkZHJlc3MiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJidXlfcG9saWN5X3dpdGhfcGF5bWVudCIsImRlc2MiOiJCdXkgaW5zdXJhbmNlIHBvbGljeSB3aXRoIGludGVncmF0ZWQgcGF5bWVudCB1c2luZyBncm91cCB0cmFuc2FjdGlvblxuRW5oYW5jZWQgd2l0aCB2YWxpZGF0aW9uLCBldmVudCBsb2dnaW5nLCBhbmQgc3RhdGlzdGljcyB0cmFja2luZyBFeHBlY3RzIHRvIGJlIGNhbGxlZCBhcyBwYXJ0IG9mIGEgZ3JvdXAgdHJhbnNhY3Rpb24gd2hlcmU6IC0gVHJhbnNhY3Rpb24gMTogUGF5bWVudCBmcm9tIHVzZXIgdG8gY29udHJhY3QgLSBUcmFuc2FjdGlvbiAyOiBUaGlzIGZ1bmN0aW9uIGNhbGwiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiemlwX2NvZGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InQwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkaXJlY3Rpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRocmVzaG9sZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2xvcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eV9wb2xpY3kiLCJkZXNjIjoiQnV5IGluc3VyYW5jZSBwb2xpY3kgKHNpbXBsZSB2ZXJzaW9uIGZvciB0ZXN0aW5nKVxuUGF5bWVudCBzaG91bGQgYmUgc2VudCB0byBjb250cmFjdCBhZGRyZXNzIGJlZm9yZSBjYWxsaW5nIHRoaXMgbWV0aG9kIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InppcF9jb2RlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0MCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidDEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGlyZWN0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aHJlc2hvbGQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNsb3BlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcmFjbGVfc2V0dGxlIiwiZGVzYyI6IkVuaGFuY2VkIG9yYWNsZSBzZXR0bGVtZW50IHdpdGggY3Jvc3MtY29udHJhY3QgY29tbXVuaWNhdGlvbiBhbmQgZXZlbnQgbG9nZ2luZ1xuSWYgYXBwcm92ZWQgPT0gMSDihpIgcGF5b3V0ID0gY2FwOyBlbHNlIDAiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9saWN5X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHByb3ZlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRpc3B1dGVfc2V0dGxlbWVudCIsImRlc2MiOiJFbmhhbmNlZCBkaXNwdXRlIGNyZWF0aW9uIHdpdGggY3Jvc3MtY29udHJhY3QgY29tbXVuaWNhdGlvblxuT25seSB0aGUgcG9saWN5IG93bmVyIGNhbiBkaXNwdXRlIHRoZWlyIG93biBwb2xpY3kiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9saWN5X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWFzb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcG9saWN5IiwiZGVzYyI6IkdldCBwb2xpY3kgZGF0YSBieSBJRCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb2xpY3lfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3Msc3RyaW5nLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiUG9saWN5RGF0YSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BvbGljaWVzX2J5X293bmVyIiwiZGVzYyI6IkdldCBhbGwgcG9saWN5IElEcyBmb3IgYSBzcGVjaWZpYyBvd25lclxuUmV0dXJuczogKGNvdW50LCBmaXJzdF9wb2xpY3lfaWQpIE5vdGU6IFRoaXMgaXMgYSBzaW1wbGlmaWVkIGltcGxlbWVudGF0aW9uIGZvciBNVlAiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFBvbGljaWVzQnlPd25lclJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BvbGljeV9jb3VudCIsImRlc2MiOiJHZXQgdG90YWwgbnVtYmVyIG9mIHBvbGljaWVzIGNyZWF0ZWQiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGN1bGF0ZV9mZWUiLCJkZXNjIjoiQ2FsY3VsYXRlIHBvbGljeSBmZWUgYmFzZWQgb24gcmlzayBwYXJhbWV0ZXJzXG5Gb3JtdWxhOiBiYXNlX2ZlZSAqIHJpc2tfbXVsdGlwbGllciAqIHVuY2VydGFpbnR5X211bHRpcGxpZXIgKiBkdXJhdGlvbl9tdWx0aXBsaWVyIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmlza19zY29yZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidW5jZXJ0YWludHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImR1cmF0aW9uX2RheXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZV9wb2xpY3kiLCJkZXNjIjoiRGVsZXRlIGEgcG9saWN5IGJ5IElEIC0gb25seSB0aGUgb3duZXIgY2FuIGRlbGV0ZSB0aGVpciBvd24gdW5zZXR0bGVkIHBvbGljeVxuUmV0dXJuczogMSBpZiBzdWNjZXNzZnVsLCAwIGlmIGZhaWxlZCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb2xpY3lfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZ2xvYmFscyIsImRlc2MiOiJHZXQgZ2xvYmFsIHN0YXRlIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLGFkZHJlc3MsdWludDY0KSIsInN0cnVjdCI6IkdldEdsb2JhbHNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9zdGF0aXN0aWNzIiwiZGVzYyI6IkdldCBjb21wcmVoZW5zaXZlIGluc3VyYW5jZSBzdGF0aXN0aWNzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6Ikluc3VyYW5jZVN0YXRzIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZXZlbnQiLCJkZXNjIjoiR2V0IGEgc3BlY2lmaWMgZXZlbnQgYnkgSUQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXZlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLHN0cmluZyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlBvbGljeUV2ZW50IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcmVjZW50X2V2ZW50cyIsImRlc2MiOiJHZXQgcmVjZW50IGV2ZW50cyAocmV0dXJucyBjb3VudCBhbmQgc3RhcnRpbmcgZXZlbnQgSUQpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxpbWl0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFBvbGljaWVzQnlPd25lclJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfcG9saWN5X3RpbWluZyIsImRlc2MiOiJWYWxpZGF0ZSBpZiBhIHBvbGljeSBpcyBjdXJyZW50bHkgYWN0aXZlIGJhc2VkIG9uIHRpbWluZyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb2xpY3lfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6M30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTAzN10sImVycm9yTWVzc2FnZSI6IkNvdmVyYWdlIGFtb3VudCBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUwMl0sImVycm9yTWVzc2FnZSI6IkRpc3B1dGUgZmlsaW5nIHBlcmlvZCBleHBpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0MV0sImVycm9yTWVzc2FnZSI6IkZlZSBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMzMiwxNDA1LDE0NjcsMTY2NCwxODIzXSwiZXJyb3JNZXNzYWdlIjoiSW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDI0XSwiZXJyb3JNZXNzYWdlIjoiTXVzdCBiZSBjYWxsZWQgaW4gZ3JvdXAgdHJhbnNhY3Rpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTMsMzcyLDM5MSw0MTAsNDI2LDQ0Miw0NjEsNDg5LDUwNSw1MjQsNTQzLDU2NSw1ODcsNjI3LDY2Nyw2ODMsNjk4LDcxN10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyN10sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHNldCBkaXNwdXRlIGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwM10sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHNldCBvcmFjbGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjMyXSwiZXJyb3JNZXNzYWdlIjoiT25seSBvcmFjbGUgY2FuIHNldHRsZSBwb2xpY2llcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNDldLCJlcnJvck1lc3NhZ2UiOiJQb2xpY3kgYWxyZWFkeSBzZXR0bGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0N10sImVycm9yTWVzc2FnZSI6IlBvbGljeSBjYW5ub3Qgc3RhcnQgaW4gdGhlIHBhc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDUyXSwiZXJyb3JNZXNzYWdlIjoiUG9saWN5IGR1cmF0aW9uIHRvbyBzaG9ydCAobWluaW11bSAxMDAgcm91bmRzKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNjZdLCJlcnJvck1lc3NhZ2UiOiJQb2xpY3kgaGFzIGV4cGlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjYwXSwiZXJyb3JNZXNzYWdlIjoiUG9saWN5IGhhcyBub3Qgc3RhcnRlZCB5ZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDMzXSwiZXJyb3JNZXNzYWdlIjoiU3RhcnQgdGltZSBtdXN0IGJlIGJlZm9yZSBlbmQgdGltZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyMV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1NiwzNzUsMzk0LDQxMyw0MjksNDQ1LDQ2NCw0OTIsNTA4LDUyNyw1NDYsNTY4LDU5MCw2MzAsNjcwLDY4Niw3MDFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODI1LDEwMDEsMTg2MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUwN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGlzcHV0ZV9jb250cmFjdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NjQsMjA1Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubmV4dF9ldmVudF9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDU2LDExNzAsMTYyNywxNzM2LDE4NjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm5leHRfcG9saWN5X2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMTQsMTIzMCwxODY1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vcmFjbGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODkxLDE4ODBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnN0YXRzX2JveCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFXNXpkWEpoYm1ObExtTnZiblJ5WVdOMExrRm5jbWxIZFdGeVpFbHVjM1Z5WVc1alpTNWZYMkZzWjI5d2VWOWxiblJ5ZVhCdmFXNTBYM2RwZEdoZmFXNXBkQ2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTVRBd0lEa3dJREV3TURBS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlNBd2VEQXdNREF3TURBd01EQXdNREF3TURBZ0ltNWxlSFJmY0c5c2FXTjVYMmxrSWlBaWNHOXNhV05wWlhNaUlDSmhaRzFwYmlJZ0ltOXlZV05zWlNJZ01IZ3dNREF3TURBd01EQXdNREF3TURBeElDSnVaWGgwWDJWMlpXNTBYMmxrSWlBaWMzUmhkSE5mWW05NElpQWlaR2x6Y0hWMFpWOWpiMjUwY21GamRDSWdJbU52Ym5SeVlXTjBYMk55WldGMGFXOXVYM0p2ZFc1a0lpQWlaWFpsYm5SZmJHOW5JaUFpY0c5c2FXTjVYMk55WldGMFpXUWlJQ0p3YjJ4cFkzbGZjMlYwZEd4bFpDSWdNSGd3TURZeUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pZeExUWXlDaUFnSUNBdkx5QWpJRWRzYjJKaGJDQnpkR0YwWlFvZ0lDQWdMeThnYzJWc1ppNWhaRzFwYmlBOUlFRmpZMjkxYm5Rb0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJ6Wld4bUxtOXlZV05zWlNBOUlFRmpZMjkxYm5Rb0tRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWIzSmhZMnhsSWdvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG8yTkFvZ0lDQWdMeThnYzJWc1ppNWthWE53ZFhSbFgyTnZiblJ5WVdOMElEMGdRV1JrY21WemN5Z3BJQ0FqSUV4cGJtdGxaQ0JrYVhOd2RYUmxJSEpsYzI5c2RYUnBiMjRnWTI5dWRISmhZM1FLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbVJwYzNCMWRHVmZZMjl1ZEhKaFkzUWlDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5QnpaV3htTG01bGVIUmZjRzlzYVdONVgybGtJRDBnVlVsdWREWTBLREVwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p1WlhoMFgzQnZiR2xqZVY5cFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUbzJOZ29nSUNBZ0x5OGdjMlZzWmk1amIyNTBjbUZqZEY5amNtVmhkR2x2Ymw5eWIzVnVaQ0E5SUZWSmJuUTJOQ2d3S1NBZ0l5QlVjbUZqYXlCM2FHVnVJR052Ym5SeVlXTjBJSGRoY3lCamNtVmhkR1ZrQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpWTI5dWRISmhZM1JmWTNKbFlYUnBiMjVmY205MWJtUWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZOellLSUNBZ0lDOHZJSE5sYkdZdWJtVjRkRjlsZG1WdWRGOXBaQ0E5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdZbmwwWldNZ055QXZMeUFpYm1WNGRGOWxkbVZ1ZEY5cFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pRMkNpQWdJQ0F2THlCamJHRnpjeUJCWjNKcFIzVmhjbVJKYm5OMWNtRnVZMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNak1LSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGc0T1RSaE56RTJaU0F3ZURRM1pEZGxaak0xSURCNE16TTJPR1kxTlRZZ01IaGhPVEpsTmpreFl5QXdlRFkzTVRjeU1XUTJJREI0TlRCbU9Ua3lZV01nTUhobFpqa3dPV1l6T0NBd2VEVmpNVFk0T1dFeUlEQjRaV0l3WkdVd01tSWdNSGd6WmpjNFpqWmxNeUF3ZUdGaVpqWmtOVEZoSURCNFptRXlNREF5TUdNZ01IaGtZMlV6TVdKaVpTQXdlREZoTUdVeU1EUTRJREI0TVRRd1pERm1ORGNnTUhnME5UZG1OekkxTWlBd2VEWXhOV0ppTXpCbUlEQjRPVEkzTkRRMlpUQWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVmZZWEJ3YkdsallYUnBiMjRvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJmWkdsemNIVjBaVjlqYjI1MGNtRmpkQ2hoWkdSeVpYTnpLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljMlYwWDI5eVlXTnNaU2hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRjl2Y21GamJHVW9LV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbUoxZVY5d2IyeHBZM2xmZDJsMGFGOXdZWGx0Wlc1MEtHSjVkR1ZiWFN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSmlkWGxmY0c5c2FXTjVLR0o1ZEdWYlhTeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p2Y21GamJHVmZjMlYwZEd4bEtIVnBiblEyTkN4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0prYVhOd2RYUmxYM05sZEhSc1pXMWxiblFvZFdsdWREWTBMSE4wY21sdVp5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjl3YjJ4cFkza29kV2x1ZERZMEtTaGhaR1J5WlhOekxITjBjbWx1Wnl4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwWDNCdmJHbGphV1Z6WDJKNVgyOTNibVZ5S0dGa1pISmxjM01wS0hWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZmNHOXNhV041WDJOdmRXNTBLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbU5oYkdOMWJHRjBaVjltWldVb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVpHVnNaWFJsWDNCdmJHbGplU2gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmWjJ4dlltRnNjeWdwS0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZmMzUmhkR2x6ZEdsamN5Z3BLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZlpYWmxiblFvZFdsdWREWTBLU2gxYVc1ME5qUXNZV1JrY21WemN5eHpkSEpwYm1jc2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1kbGRGOXlaV05sYm5SZlpYWmxiblJ6S0hWcGJuUTJOQ2tvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJblpoYkdsa1lYUmxYM0J2YkdsamVWOTBhVzFwYm1jb2RXbHVkRFkwS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFgyRndjR3hwWTJGMGFXOXVYM0p2ZFhSbFFEVWdiV0ZwYmw5elpYUmZaR2x6Y0hWMFpWOWpiMjUwY21GamRGOXliM1YwWlVBMklHMWhhVzVmYzJWMFgyOXlZV05zWlY5eWIzVjBaVUEzSUcxaGFXNWZaMlYwWDI5eVlXTnNaVjl5YjNWMFpVQTRJRzFoYVc1ZlluVjVYM0J2YkdsamVWOTNhWFJvWDNCaGVXMWxiblJmY205MWRHVkFPU0J0WVdsdVgySjFlVjl3YjJ4cFkzbGZjbTkxZEdWQU1UQWdiV0ZwYmw5dmNtRmpiR1ZmYzJWMGRHeGxYM0p2ZFhSbFFERXhJRzFoYVc1ZlpHbHpjSFYwWlY5elpYUjBiR1Z0Wlc1MFgzSnZkWFJsUURFeUlHMWhhVzVmWjJWMFgzQnZiR2xqZVY5eWIzVjBaVUF4TXlCdFlXbHVYMmRsZEY5d2IyeHBZMmxsYzE5aWVWOXZkMjVsY2w5eWIzVjBaVUF4TkNCdFlXbHVYMmRsZEY5d2IyeHBZM2xmWTI5MWJuUmZjbTkxZEdWQU1UVWdiV0ZwYmw5allXeGpkV3hoZEdWZlptVmxYM0p2ZFhSbFFERTJJRzFoYVc1ZlpHVnNaWFJsWDNCdmJHbGplVjl5YjNWMFpVQXhOeUJ0WVdsdVgyZGxkRjluYkc5aVlXeHpYM0p2ZFhSbFFERTRJRzFoYVc1ZloyVjBYM04wWVhScGMzUnBZM05mY205MWRHVkFNVGtnYldGcGJsOW5aWFJmWlhabGJuUmZjbTkxZEdWQU1qQWdiV0ZwYmw5blpYUmZjbVZqWlc1MFgyVjJaVzUwYzE5eWIzVjBaVUF5TVNCdFlXbHVYM1poYkdsa1lYUmxYM0J2YkdsamVWOTBhVzFwYm1kZmNtOTFkR1ZBTWpJS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TkRZS0lDQWdJQzh2SUdOc1lYTnpJRUZuY21sSGRXRnlaRWx1YzNWeVlXNWpaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MllXeHBaR0YwWlY5d2IyeHBZM2xmZEdsdGFXNW5YM0p2ZFhSbFFESXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG8wT0RJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG8wTmdvZ0lDQWdMeThnWTJ4aGMzTWdRV2R5YVVkMVlYSmtTVzV6ZFhKaGJtTmxLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qUTRNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWTJGc2JITjFZaUIyWVd4cFpHRjBaVjl3YjJ4cFkzbGZkR2x0YVc1bkNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOXlaV05sYm5SZlpYWmxiblJ6WDNKdmRYUmxRREl4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvME56SUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvME5nb2dJQ0FnTHk4Z1kyeGhjM01nUVdkeWFVZDFZWEprU1c1emRYSmhibU5sS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPalEzTWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZjbVZqWlc1MFgyVjJaVzUwY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZlpYWmxiblJmY205MWRHVkFNakE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pRMU1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pRMkNpQWdJQ0F2THlCamJHRnpjeUJCWjNKcFIzVmhjbVJKYm5OMWNtRnVZMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZORFV5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCallXeHNjM1ZpSUdkbGRGOWxkbVZ1ZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZmMzUmhkR2x6ZEdsamMxOXliM1YwWlVBeE9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZORFEzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzTjBZWFJwYzNScFkzTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBYMmRzYjJKaGJITmZjbTkxZEdWQU1UZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPalF6T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGOW5iRzlpWVd4ekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJSbGJHVjBaVjl3YjJ4cFkzbGZjbTkxZEdWQU1UYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPalF3TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pRMkNpQWdJQ0F2THlCamJHRnpjeUJCWjNKcFIzVmhjbVJKYm5OMWNtRnVZMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZOREExQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHUmxiR1YwWlY5d2IyeHBZM2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMkZzWTNWc1lYUmxYMlpsWlY5eWIzVjBaVUF4TmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk16Y3hDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk5EWUtJQ0FnSUM4dklHTnNZWE56SUVGbmNtbEhkV0Z5WkVsdWMzVnlZVzVqWlNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG96TnpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHTmhiR3h6ZFdJZ1kyRnNZM1ZzWVhSbFgyWmxaUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmY0c5c2FXTjVYMk52ZFc1MFgzSnZkWFJsUURFMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3pOallLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSZmNHOXNhV041WDJOdmRXNTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjl3YjJ4cFkybGxjMTlpZVY5dmQyNWxjbDl5YjNWMFpVQXhORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TXpRMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TkRZS0lDQWdJQzh2SUdOc1lYTnpJRUZuY21sSGRXRnlaRWx1YzNWeVlXNWpaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3pORFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzQnZiR2xqYVdWelgySjVYMjkzYm1WeUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOXdiMnhwWTNsZmNtOTFkR1ZBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qTXpPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qUTJDaUFnSUNBdkx5QmpiR0Z6Y3lCQlozSnBSM1ZoY21SSmJuTjFjbUZ1WTJVb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TXpNNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRjl3YjJ4cFkza0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpHbHpjSFYwWlY5elpYUjBiR1Z0Wlc1MFgzSnZkWFJsUURFeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3lPVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG8wTmdvZ0lDQWdMeThnWTJ4aGMzTWdRV2R5YVVkMVlYSmtTVzV6ZFhKaGJtTmxLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qSTVOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCa2FYTndkWFJsWDNObGRIUnNaVzFsYm5RS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYjNKaFkyeGxYM05sZEhSc1pWOXliM1YwWlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNalExQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TkRZS0lDQWdJQzh2SUdOc1lYTnpJRUZuY21sSGRXRnlaRWx1YzNWeVlXNWpaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3lORFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ2IzSmhZMnhsWDNObGRIUnNaUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlkWGxmY0c5c2FXTjVYM0p2ZFhSbFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG95TURjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvME5nb2dJQ0FnTHk4Z1kyeGhjM01nUVdkeWFVZDFZWEprU1c1emRYSmhibU5sS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTNDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPakl3TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQmlkWGxmY0c5c2FXTjVDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySjFlVjl3YjJ4cFkzbGZkMmwwYUY5d1lYbHRaVzUwWDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pFME5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qUTJDaUFnSUNBdkx5QmpiR0Z6Y3lCQlozSnBSM1ZoY21SSmJuTjFjbUZ1WTJVb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRRMENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR0oxZVY5d2IyeHBZM2xmZDJsMGFGOXdZWGx0Wlc1MENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOXZjbUZqYkdWZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk1UTTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwWDI5eVlXTnNaUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpaWFJmYjNKaFkyeGxYM0p2ZFhSbFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPakV6TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pRMkNpQWdJQ0F2THlCamJHRnpjeUJCWjNKcFIzVmhjbVJKYm5OMWNtRnVZMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNVE16Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlITmxkRjl2Y21GamJHVUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmMyVjBYMlJwYzNCMWRHVmZZMjl1ZEhKaFkzUmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZPVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG8wTmdvZ0lDQWdMeThnWTJ4aGMzTWdRV2R5YVVkMVlYSmtTVzV6ZFhKaGJtTmxLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qazNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhObGRGOWthWE53ZFhSbFgyTnZiblJ5WVdOMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOeVpXRjBaVjloY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvM09Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZORFlLSUNBZ0lDOHZJR05zWVhOeklFRm5jbWxIZFdGeVpFbHVjM1Z5WVc1alpTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvM09Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaGpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnWTJGc2JITjFZaUJqY21WaGRHVmZZWEJ3YkdsallYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFXNXpkWEpoYm1ObExtTnZiblJ5WVdOMExrRm5jbWxIZFdGeVpFbHVjM1Z5WVc1alpTNWpjbVZoZEdWZllYQndiR2xqWVhScGIyNG9ZV1J0YVc0NklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZmWVhCd2JHbGpZWFJwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qYzRMVGM1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQXZMeUJrWldZZ1kzSmxZWFJsWDJGd2NHeHBZMkYwYVc5dUtITmxiR1lzSUdGa2JXbHVPaUJCWkdSeVpYTnpLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qZ3hDaUFnSUNBdkx5QnpaV3htTG1Ga2JXbHVJRDBnWVdSdGFXNHVibUYwYVhabENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2T0RJS0lDQWdJQzh2SUhObGJHWXVZMjl1ZEhKaFkzUmZZM0psWVhScGIyNWZjbTkxYm1RZ1BTQkhiRzlpWVd3dWNtOTFibVFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0pqYjI1MGNtRmpkRjlqY21WaGRHbHZibDl5YjNWdVpDSUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZPVElLSUNBZ0lDOHZJSE5sYkdZdWMzUmhkSE5mWW05NExuWmhiSFZsSUQwZ2FXNXBkR2xoYkY5emRHRjBjeTVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luTjBZWFJ6WDJKdmVDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZPRFF0T1RFS0lDQWdJQzh2SUNNZ1NXNXBkR2xoYkdsNlpTQnpkR0YwYVhOMGFXTnpDaUFnSUNBdkx5QnBibWwwYVdGc1gzTjBZWFJ6SUQwZ1NXNXpkWEpoYm1ObFUzUmhkSE1vQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3hmY0c5c2FXTnBaWE05UVZKRE5GVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOWpiM1psY21GblpUMUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDNCaGVXOTFkSE05UVZKRE5GVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JoWTNScGRtVmZjRzlzYVdOcFpYTTlRVkpETkZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5bVpXVnpYMk52Ykd4bFkzUmxaRDFCVWtNMFZVbHVkRFkwS0RBcENpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z2MyVnNaaTV6ZEdGMGMxOWliM2d1ZG1Gc2RXVWdQU0JwYm1sMGFXRnNYM04wWVhSekxtTnZjSGtvS1FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUbzVOQzA1TlFvZ0lDQWdMeThnSXlCTWIyY2dZMjl1ZEhKaFkzUWdZM0psWVhScGIyNGdaWFpsYm5RS0lDQWdJQzh2SUhObGJHWXVYMnh2WjE5bGRtVnVkQ2hCVWtNMFZVbHVkRFkwS0RBcExDQmhaRzFwYml3Z1FWSkRORk4wY21sdVp5Z2lZMjl1ZEhKaFkzUmZZM0psWVhSbFpDSXBMQ0JCVWtNMFZVbHVkRFkwS0RBcEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeE1EWXpObVkyWlRjME56STJNVFl6TnpRMVpqWXpOekkyTlRZeE56UTJOVFkwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyRnNiSE4xWWlCZmJHOW5YMlYyWlc1MENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YVc1emRYSmhibU5sTG1OdmJuUnlZV04wTGtGbmNtbEhkV0Z5WkVsdWMzVnlZVzVqWlM1elpYUmZaR2x6Y0hWMFpWOWpiMjUwY21GamRDaGthWE53ZFhSbFgyTnZiblJ5WVdOME9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNuTmxkRjlrYVhOd2RYUmxYMk52Ym5SeVlXTjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG81TnkwNU9Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JSE5sZEY5a2FYTndkWFJsWDJOdmJuUnlZV04wS0hObGJHWXNJR1JwYzNCMWRHVmZZMjl1ZEhKaFkzUTZJRUZrWkhKbGMzTXBJQzArSUVGU1F6UlZTVzUwTmpRNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRBd0NpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1Ga2JXbHVMQ0FpVDI1c2VTQmhaRzFwYmlCallXNGdjMlYwSUdScGMzQjFkR1VnWTI5dWRISmhZM1FpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZV1J0YVc0Z1kyRnVJSE5sZENCa2FYTndkWFJsSUdOdmJuUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pFd01Rb2dJQ0FnTHk4Z2MyVnNaaTVrYVhOd2RYUmxYMk52Ym5SeVlXTjBJRDBnWkdsemNIVjBaVjlqYjI1MGNtRmpkQW9nSUNBZ1lubDBaV01nT1NBdkx5QWlaR2x6Y0hWMFpWOWpiMjUwY21GamRDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNVEF5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRVkpETkZWSmJuUTJOQ2d4S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXBibk4xY21GdVkyVXVZMjl1ZEhKaFkzUXVRV2R5YVVkMVlYSmtTVzV6ZFhKaGJtTmxMbDlzYjJkZlpYWmxiblFvY0c5c2FXTjVYMmxrT2lCaWVYUmxjeXdnYjNkdVpYSTZJR0o1ZEdWekxDQmhZM1JwYjI0NklHSjVkR1Z6TENCaGJXOTFiblE2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BmYkc5blgyVjJaVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRveE1EUXRNVEExQ2lBZ0lDQXZMeUJBYzNWaWNtOTFkR2x1WlFvZ0lDQWdMeThnWkdWbUlGOXNiMmRmWlhabGJuUW9jMlZzWml3Z2NHOXNhV041WDJsa09pQkJVa00wVlVsdWREWTBMQ0J2ZDI1bGNqb2dRV1JrY21WemN5d2dZV04wYVc5dU9pQkJVa00wVTNSeWFXNW5MQ0JoYlc5MWJuUTZJRUZTUXpSVlNXNTBOalFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBMElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNVEV4Q2lBZ0lDQXZMeUIwYVcxbGMzUmhiWEE5UVZKRE5GVkpiblEyTkNoSGJHOWlZV3d1Y205MWJtUXBMQW9nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPakV3TnkweE1UTUtJQ0FnSUM4dklHVjJaVzUwSUQwZ1VHOXNhV041UlhabGJuUW9DaUFnSUNBdkx5QWdJQ0FnY0c5c2FXTjVYMmxrUFhCdmJHbGplVjlwWkN3S0lDQWdJQzh2SUNBZ0lDQnZkMjVsY2oxdmQyNWxjaXdLSUNBZ0lDOHZJQ0FnSUNCaFkzUnBiMjQ5WVdOMGFXOXVMQW9nSUNBZ0x5OGdJQ0FnSUhScGJXVnpkR0Z0Y0QxQlVrTTBWVWx1ZERZMEtFZHNiMkpoYkM1eWIzVnVaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGdGIzVnVkQW9nSUNBZ0x5OGdLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF6WVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG94TVRRS0lDQWdJQzh2SUhObGJHWXVaWFpsYm5SZmJHOW5XM05sYkdZdWJtVjRkRjlsZG1WdWRGOXBaRjBnUFNCbGRtVnVkQzVqYjNCNUtDa0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKdVpYaDBYMlYyWlc1MFgybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG01bGVIUmZaWFpsYm5SZmFXUWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKbGRtVnVkRjlzYjJjaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNVEUxQ2lBZ0lDQXZMeUJ6Wld4bUxtNWxlSFJmWlhabGJuUmZhV1FnS3owZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV01nTnlBdkx5QWlibVY0ZEY5bGRtVnVkRjlwWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YVc1emRYSmhibU5sTG1OdmJuUnlZV04wTGtGbmNtbEhkV0Z5WkVsdWMzVnlZVzVqWlM1ZmRYQmtZWFJsWDNOMFlYUnpLR0ZqZEdsdmJqb2dZbmwwWlhNc0lHTnZkbVZ5WVdkbFgyRnRiM1Z1ZERvZ1lubDBaWE1zSUdabFpWOWhiVzkxYm5RNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwZmRYQmtZWFJsWDNOMFlYUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG94TVRjdE1URTRDaUFnSUNBdkx5QkFjM1ZpY205MWRHbHVaUW9nSUNBZ0x5OGdaR1ZtSUY5MWNHUmhkR1ZmYzNSaGRITW9jMlZzWml3Z1lXTjBhVzl1T2lCVGRISnBibWNzSUdOdmRtVnlZV2RsWDJGdGIzVnVkRG9nUVZKRE5GVkpiblEyTkN3Z1ptVmxYMkZ0YjNWdWREb2dRVkpETkZWSmJuUTJOQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURNZ01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk1USXdDaUFnSUNBdkx5QmpkWEp5Wlc1MFgzTjBZWFJ6SUQwZ2MyVnNaaTV6ZEdGMGMxOWliM2d1ZG1Gc2RXVXVZMjl3ZVNncENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKemRHRjBjMTlpYjNnaUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpkR0YwYzE5aWIzZ2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qRXlNZ29nSUNBZ0x5OGdhV1lnWVdOMGFXOXVJRDA5SUZOMGNtbHVaeWdpY0c5c2FXTjVYMk55WldGMFpXUWlLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lubDBaV01nTVRJZ0x5OGdJbkJ2YkdsamVWOWpjbVZoZEdWa0lnb2dJQ0FnUFQwS0lDQWdJR0o2SUY5MWNHUmhkR1ZmYzNSaGRITmZaV3h6WlY5aWIyUjVRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRJekNpQWdJQ0F2THlCamRYSnlaVzUwWDNOMFlYUnpMblJ2ZEdGc1gzQnZiR2xqYVdWeklEMGdRVkpETkZWSmJuUTJOQ2hqZFhKeVpXNTBYM04wWVhSekxuUnZkR0ZzWDNCdmJHbGphV1Z6TG01aGRHbDJaU0FySURFcENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pFeU5Bb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5emRHRjBjeTUwYjNSaGJGOWpiM1psY21GblpTQTlJRUZTUXpSVlNXNTBOalFvWTNWeWNtVnVkRjl6ZEdGMGN5NTBiM1JoYkY5amIzWmxjbUZuWlM1dVlYUnBkbVVnS3lCamIzWmxjbUZuWlY5aGJXOTFiblF1Ym1GMGFYWmxLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURnZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1luUnZhUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRveE1qVUtJQ0FnSUM4dklHTjFjbkpsYm5SZmMzUmhkSE11WVdOMGFYWmxYM0J2YkdsamFXVnpJRDBnUVZKRE5GVkpiblEyTkNoamRYSnlaVzUwWDNOMFlYUnpMbUZqZEdsMlpWOXdiMnhwWTJsbGN5NXVZWFJwZG1VZ0t5QXhLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJMElDOHZJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURJMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qRXlOZ29nSUNBZ0x5OGdZM1Z5Y21WdWRGOXpkR0YwY3k1MGIzUmhiRjltWldWelgyTnZiR3hsWTNSbFpDQTlJRUZTUXpSVlNXNTBOalFvWTNWeWNtVnVkRjl6ZEdGMGN5NTBiM1JoYkY5bVpXVnpYMk52Ykd4bFkzUmxaQzV1WVhScGRtVWdLeUJtWldWZllXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZblJ2YVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ016SUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb0tYM1Z3WkdGMFpWOXpkR0YwYzE5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pFek1Rb2dJQ0FnTHk4Z2MyVnNaaTV6ZEdGMGMxOWliM2d1ZG1Gc2RXVWdQU0JqZFhKeVpXNTBYM04wWVhSekxtTnZjSGtvS1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpYzNSaGRITmZZbTk0SWdvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tYM1Z3WkdGMFpWOXpkR0YwYzE5bGJITmxYMkp2WkhsQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNVEkzQ2lBZ0lDQXZMeUJsYkdsbUlHRmpkR2x2YmlBOVBTQlRkSEpwYm1jb0luQnZiR2xqZVY5elpYUjBiR1ZrSWlrNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0o1ZEdWaklERXpJQzh2SUNKd2IyeHBZM2xmYzJWMGRHeGxaQ0lLSUNBZ0lEMDlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JpZWlCZmRYQmtZWFJsWDNOMFlYUnpYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3hNamdLSUNBZ0lDOHZJR04xY25KbGJuUmZjM1JoZEhNdWRHOTBZV3hmY0dGNWIzVjBjeUE5SUVGU1F6UlZTVzUwTmpRb1kzVnljbVZ1ZEY5emRHRjBjeTUwYjNSaGJGOXdZWGx2ZFhSekxtNWhkR2wyWlNBcklHTnZkbVZ5WVdkbFgyRnRiM1Z1ZEM1dVlYUnBkbVVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFMklDOHZJREUyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBeE5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3hNamtLSUNBZ0lDOHZJR04xY25KbGJuUmZjM1JoZEhNdVlXTjBhWFpsWDNCdmJHbGphV1Z6SUQwZ1FWSkRORlZKYm5RMk5DaGpkWEp5Wlc1MFgzTjBZWFJ6TG1GamRHbDJaVjl3YjJ4cFkybGxjeTV1WVhScGRtVWdMU0F4S1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElESTBJQzh2SURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlESTBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtDbDkxY0dSaGRHVmZjM1JoZEhOZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1lpQmZkWEJrWVhSbFgzTjBZWFJ6WDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1cGJuTjFjbUZ1WTJVdVkyOXVkSEpoWTNRdVFXZHlhVWQxWVhKa1NXNXpkWEpoYm1ObExuTmxkRjl2Y21GamJHVW9iM0poWTJ4bE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2MyVjBYMjl5WVdOc1pUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNVE16TFRFek5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JSE5sZEY5dmNtRmpiR1VvYzJWc1ppd2diM0poWTJ4bE9pQkJaR1J5WlhOektTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pFek5nb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaXdnSWs5dWJIa2dZV1J0YVc0Z1kyRnVJSE5sZENCdmNtRmpiR1VpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZV1J0YVc0Z1kyRnVJSE5sZENCdmNtRmpiR1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRNM0NpQWdJQ0F2THlCelpXeG1MbTl5WVdOc1pTQTlJRzl5WVdOc1pTNXVZWFJwZG1VS0lDQWdJR0o1ZEdWaklEVWdMeThnSW05eVlXTnNaU0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXBibk4xY21GdVkyVXVZMjl1ZEhKaFkzUXVRV2R5YVVkMVlYSmtTVzV6ZFhKaGJtTmxMbWRsZEY5dmNtRmpiR1VvS1NBdFBpQmllWFJsY3pvS1oyVjBYMjl5WVdOc1pUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNVFF5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRV1JrY21WemN5aHpaV3htTG05eVlXTnNaU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSnZjbUZqYkdVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViM0poWTJ4bElHVjRhWE4wY3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWx1YzNWeVlXNWpaUzVqYjI1MGNtRmpkQzVCWjNKcFIzVmhjbVJKYm5OMWNtRnVZMlV1WW5WNVgzQnZiR2xqZVY5M2FYUm9YM0JoZVcxbGJuUW9lbWx3WDJOdlpHVTZJR0o1ZEdWekxDQjBNRG9nWW5sMFpYTXNJSFF4T2lCaWVYUmxjeXdnWTJGd09pQmllWFJsY3l3Z1pHbHlaV04wYVc5dU9pQmllWFJsY3l3Z2RHaHlaWE5vYjJ4a09pQmllWFJsY3l3Z2MyeHZjR1U2SUdKNWRHVnpMQ0JtWldVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1luVjVYM0J2YkdsamVWOTNhWFJvWDNCaGVXMWxiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pFME5DMHhOVFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCaWRYbGZjRzlzYVdONVgzZHBkR2hmY0dGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUhwcGNGOWpiMlJsT2lCRWVXNWhiV2xqUW5sMFpYTXNDaUFnSUNBdkx5QWdJQ0FnZERBNklFRlNRelJWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnZERFNklFRlNRelJWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnWTJGd09pQkJVa00wVlVsdWREWTBMQW9nSUNBZ0x5OGdJQ0FnSUdScGNtVmpkR2x2YmpvZ1FWSkRORlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0IwYUhKbGMyaHZiR1E2SUVGU1F6UlZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdjMnh2Y0dVNklFRlNRelJWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQkJVa00wVlVsdWREWTBDaUFnSUNBdkx5QXBJQzArSUVGU1F6UlZTVzUwTmpRNkNpQWdJQ0J3Y205MGJ5QTRJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRZekxURTJOQW9nSUNBZ0x5OGdJeUJGYm1oaGJtTmxaQ0IyWVd4cFpHRjBhVzl1Q2lBZ0lDQXZMeUJoYzNObGNuUWdSMnh2WW1Gc0xtZHliM1Z3WDNOcGVtVWdQVDBnVlVsdWREWTBLRElwTENBaVRYVnpkQ0JpWlNCallXeHNaV1FnYVc0Z1ozSnZkWEFnZEhKaGJuTmhZM1JwYjI0aUNpQWdJQ0JuYkc5aVlXd2dSM0p2ZFhCVGFYcGxDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCTmRYTjBJR0psSUdOaGJHeGxaQ0JwYmlCbmNtOTFjQ0IwY21GdWMyRmpkR2x2YmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRveE5qVUtJQ0FnSUM4dklHRnpjMlZ5ZENCME1DNXVZWFJwZG1VZ1BDQjBNUzV1WVhScGRtVXNJQ0pUZEdGeWRDQjBhVzFsSUcxMWMzUWdZbVVnWW1WbWIzSmxJR1Z1WkNCMGFXMWxJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDNDaUFnSUNCaWRHOXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUWUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNESUtJQ0FnSUR3S0lDQWdJR0Z6YzJWeWRDQXZMeUJUZEdGeWRDQjBhVzFsSUcxMWMzUWdZbVVnWW1WbWIzSmxJR1Z1WkNCMGFXMWxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPakUyTmdvZ0lDQWdMeThnWVhOelpYSjBJR05oY0M1dVlYUnBkbVVnUGlCVlNXNTBOalFvTUNrc0lDSkRiM1psY21GblpTQmhiVzkxYm5RZ2JYVnpkQ0JpWlNCd2IzTnBkR2wyWlNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdZblJ2YVFvZ0lDQWdZWE56WlhKMElDOHZJRU52ZG1WeVlXZGxJR0Z0YjNWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qRTJOd29nSUNBZ0x5OGdZWE56WlhKMElHWmxaUzV1WVhScGRtVWdQaUJWU1c1ME5qUW9NQ2tzSUNKR1pXVWdiWFZ6ZENCaVpTQndiM05wZEdsMlpTSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5SdmFRb2dJQ0FnWVhOelpYSjBJQzh2SUVabFpTQnRkWE4wSUdKbElIQnZjMmwwYVhabENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qRTNNUW9nSUNBZ0x5OGdZWE56WlhKMElIUXdMbTVoZEdsMlpTQStJR04xY25KbGJuUmZjbTkxYm1Rc0lDSlFiMnhwWTNrZ1kyRnVibTkwSUhOMFlYSjBJR2x1SUhSb1pTQndZWE4wSWdvZ0lDQWdaR2xuSURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk1UWTVMVEUzTUFvZ0lDQWdMeThnSXlCVWFXMWxMV0poYzJWa0lIWmhiR2xrWVhScGIyNEtJQ0FnSUM4dklHTjFjbkpsYm5SZmNtOTFibVFnUFNCSGJHOWlZV3d1Y205MWJtUUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3hOekVLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBNQzV1WVhScGRtVWdQaUJqZFhKeVpXNTBYM0p2ZFc1a0xDQWlVRzlzYVdONUlHTmhibTV2ZENCemRHRnlkQ0JwYmlCMGFHVWdjR0Z6ZENJS0lDQWdJRDRLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFiMnhwWTNrZ1kyRnVibTkwSUhOMFlYSjBJR2x1SUhSb1pTQndZWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pFM01nb2dJQ0FnTHk4Z1lYTnpaWEowSUhReExtNWhkR2wyWlNBK0lIUXdMbTVoZEdsMlpTQXJJRlZKYm5RMk5DZ3hNREFwTENBaVVHOXNhV041SUdSMWNtRjBhVzl1SUhSdmJ5QnphRzl5ZENBb2JXbHVhVzExYlNBeE1EQWdjbTkxYm1SektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeE1EQUtJQ0FnSUNzS0lDQWdJRDRLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFiMnhwWTNrZ1pIVnlZWFJwYjI0Z2RHOXZJSE5vYjNKMElDaHRhVzVwYlhWdElERXdNQ0J5YjNWdVpITXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPakUzTkMweE56VUtJQ0FnSUM4dklDTWdRM0psWVhSbElIQnZiR2xqZVFvZ0lDQWdMeThnY0c5c2FXTjVYMmxrSUQwZ2MyVnNaaTV1WlhoMFgzQnZiR2xqZVY5cFpBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW01bGVIUmZjRzlzYVdONVgybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG01bGVIUmZjRzlzYVdONVgybGtJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3hOellLSUNBZ0lDOHZJSE5sYkdZdWJtVjRkRjl3YjJ4cFkzbGZhV1FnS3owZ1ZVbHVkRFkwS0RFcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnVaWGgwWDNCdmJHbGplVjlwWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qRTNPQW9nSUNBZ0x5OGdZMkZzYkdWeUlEMGdRV1JrY21WemN5NW1jbTl0WDJKNWRHVnpLRlI0Ymk1elpXNWtaWEl1WW5sMFpYTXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qRTRNQzB4T1RFS0lDQWdJQzh2SUhCdmJHbGplVjlrWVhSaElEMGdVRzlzYVdONVJHRjBZU2dLSUNBZ0lDOHZJQ0FnSUNCdmQyNWxjajFqWVd4c1pYSXNDaUFnSUNBdkx5QWdJQ0FnZW1sd1gyTnZaR1U5UVZKRE5GTjBjbWx1Wnk1bWNtOXRYMko1ZEdWektIcHBjRjlqYjJSbExtSjVkR1Z6S1N3S0lDQWdJQzh2SUNBZ0lDQjBNRDEwTUN3S0lDQWdJQzh2SUNBZ0lDQjBNVDEwTVN3S0lDQWdJQzh2SUNBZ0lDQmpZWEE5WTJGd0xBb2dJQ0FnTHk4Z0lDQWdJR1JwY21WamRHbHZiajFrYVhKbFkzUnBiMjRzQ2lBZ0lDQXZMeUFnSUNBZ2RHaHlaWE5vYjJ4a1BYUm9jbVZ6YUc5c1pDd0tJQ0FnSUM4dklDQWdJQ0J6Ykc5d1pUMXpiRzl3WlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1ZmY0dGcFpEMW1aV1VzQ2lBZ0lDQXZMeUFnSUNBZ2MyVjBkR3hsWkQxQlVrTTBWVWx1ZERZMEtEQXBDaUFnSUNBdkx5QXBDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpJREUwSUM4dklEQjRNREEyTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRjS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRveE9UQUtJQ0FnSUM4dklITmxkSFJzWldROVFWSkRORlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNVGd3TFRFNU1Rb2dJQ0FnTHk4Z2NHOXNhV041WDJSaGRHRWdQU0JRYjJ4cFkzbEVZWFJoS0FvZ0lDQWdMeThnSUNBZ0lHOTNibVZ5UFdOaGJHeGxjaXdLSUNBZ0lDOHZJQ0FnSUNCNmFYQmZZMjlrWlQxQlVrTTBVM1J5YVc1bkxtWnliMjFmWW5sMFpYTW9lbWx3WDJOdlpHVXVZbmwwWlhNcExBb2dJQ0FnTHk4Z0lDQWdJSFF3UFhRd0xBb2dJQ0FnTHk4Z0lDQWdJSFF4UFhReExBb2dJQ0FnTHk4Z0lDQWdJR05oY0QxallYQXNDaUFnSUNBdkx5QWdJQ0FnWkdseVpXTjBhVzl1UFdScGNtVmpkR2x2Yml3S0lDQWdJQzh2SUNBZ0lDQjBhSEpsYzJodmJHUTlkR2h5WlhOb2IyeGtMQW9nSUNBZ0x5OGdJQ0FnSUhOc2IzQmxQWE5zYjNCbExBb2dJQ0FnTHk4Z0lDQWdJR1psWlY5d1lXbGtQV1psWlN3S0lDQWdJQzh2SUNBZ0lDQnpaWFIwYkdWa1BVRlNRelJWU1c1ME5qUW9NQ2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzA0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk1Ua3pMVEU1TkFvZ0lDQWdMeThnSXlCVGRHOXlaU0J3YjJ4cFkza2dhVzRnWW05NElIZHBkR2dnWlc1b1lXNWpaV1FnWlhKeWIzSWdhR0Z1Wkd4cGJtY0tJQ0FnSUM4dklITmxiR1l1Y0c5c2FXTnBaWE5iY0c5c2FXTjVYMmxrWFNBOUlIQnZiR2xqZVY5a1lYUmhMbU52Y0hrb0tRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3YjJ4cFkybGxjeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk1UazJMVEU1TndvZ0lDQWdMeThnSXlCVmNHUmhkR1VnYzNSaGRHbHpkR2xqY3dvZ0lDQWdMeThnYzJWc1ppNWZkWEJrWVhSbFgzTjBZWFJ6S0ZOMGNtbHVaeWdpY0c5c2FXTjVYMk55WldGMFpXUWlLU3dnWTJGd0xDQm1aV1VwQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpY0c5c2FXTjVYMk55WldGMFpXUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJmZFhCa1lYUmxYM04wWVhSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qRTVPUzB5TURBS0lDQWdJQzh2SUNNZ1RHOW5JSEJ2YkdsamVTQmpjbVZoZEdsdmJpQmxkbVZ1ZEFvZ0lDQWdMeThnYzJWc1ppNWZiRzluWDJWMlpXNTBLRUZTUXpSVlNXNTBOalFvY0c5c2FXTjVYMmxrS1N3Z1kyRnNiR1Z5TENCQlVrTTBVM1J5YVc1bktDSndiMnhwWTNsZlkzSmxZWFJsWkNJcExDQmpZWEFwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURCbE56QTJaalpqTmprMk16YzVOV1kyTXpjeU5qVTJNVGMwTmpVMk5Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0JqWVd4c2MzVmlJRjlzYjJkZlpYWmxiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TWpBeUxUSXdNd29nSUNBZ0x5OGdJeUJGYldsMElHeHZaeUJtYjNJZ1pYaDBaWEp1WVd3Z2JXOXVhWFJ2Y21sdVp3b2dJQ0FnTHk4Z2JHOW5LRUo1ZEdWektHSWlVRTlNU1VOWlgwTlNSVUZVUlVRaUtTQXJJR05oYkd4bGNpNWllWFJsY3lrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVd05HWTBZelE1TkRNMU9UVm1ORE0xTWpRMU5ERTFORFExTkRRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TWpBMUNpQWdJQ0F2THlCeVpYUjFjbTRnUVZKRE5GVkpiblEyTkNod2IyeHBZM2xmYVdRcENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YVc1emRYSmhibU5sTG1OdmJuUnlZV04wTGtGbmNtbEhkV0Z5WkVsdWMzVnlZVzVqWlM1aWRYbGZjRzlzYVdONUtIcHBjRjlqYjJSbE9pQmllWFJsY3l3Z2REQTZJR0o1ZEdWekxDQjBNVG9nWW5sMFpYTXNJR05oY0RvZ1lubDBaWE1zSUdScGNtVmpkR2x2YmpvZ1lubDBaWE1zSUhSb2NtVnphRzlzWkRvZ1lubDBaWE1zSUhOc2IzQmxPaUJpZVhSbGN5d2dabVZsT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21KMWVWOXdiMnhwWTNrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qSXdOeTB5TVRnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQmlkWGxmY0c5c2FXTjVLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnZW1sd1gyTnZaR1U2SUVSNWJtRnRhV05DZVhSbGN5d0tJQ0FnSUM4dklDQWdJQ0IwTURvZ1FWSkRORlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0IwTVRvZ1FWSkRORlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JqWVhBNklFRlNRelJWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnWkdseVpXTjBhVzl1T2lCQlVrTTBWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJSFJvY21WemFHOXNaRG9nUVZKRE5GVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQnpiRzl3WlRvZ1FWSkRORlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklFRlNRelJWU1c1ME5qUUtJQ0FnSUM4dklDa2dMVDRnUVZKRE5GVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklEZ2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG95TWpNdE1qSTBDaUFnSUNBdkx5QWpJRU55WldGMFpTQndiMnhwWTNrS0lDQWdJQzh2SUhCdmJHbGplVjlwWkNBOUlITmxiR1l1Ym1WNGRGOXdiMnhwWTNsZmFXUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKdVpYaDBYM0J2YkdsamVWOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dVpYaDBYM0J2YkdsamVWOXBaQ0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNakkxQ2lBZ0lDQXZMeUJ6Wld4bUxtNWxlSFJmY0c5c2FXTjVYMmxrSUNzOUlGVkpiblEyTkNneEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTWlBdkx5QWlibVY0ZEY5d2IyeHBZM2xmYVdRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3lNamdLSUNBZ0lDOHZJRzkzYm1WeVBVRmtaSEpsYzNNdVpuSnZiVjlpZVhSbGN5aFVlRzR1YzJWdVpHVnlMbUo1ZEdWektTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk1qSTNMVEl6T0FvZ0lDQWdMeThnY0c5c2FXTjVYMlJoZEdFZ1BTQlFiMnhwWTNsRVlYUmhLQW9nSUNBZ0x5OGdJQ0FnSUc5M2JtVnlQVUZrWkhKbGMzTXVabkp2YlY5aWVYUmxjeWhVZUc0dWMyVnVaR1Z5TG1KNWRHVnpLU3dLSUNBZ0lDOHZJQ0FnSUNCNmFYQmZZMjlrWlQxQlVrTTBVM1J5YVc1bkxtWnliMjFmWW5sMFpYTW9lbWx3WDJOdlpHVXVZbmwwWlhNcExBb2dJQ0FnTHk4Z0lDQWdJSFF3UFhRd0xBb2dJQ0FnTHk4Z0lDQWdJSFF4UFhReExBb2dJQ0FnTHk4Z0lDQWdJR05oY0QxallYQXNDaUFnSUNBdkx5QWdJQ0FnWkdseVpXTjBhVzl1UFdScGNtVmpkR2x2Yml3S0lDQWdJQzh2SUNBZ0lDQjBhSEpsYzJodmJHUTlkR2h5WlhOb2IyeGtMQW9nSUNBZ0x5OGdJQ0FnSUhOc2IzQmxQWE5zYjNCbExBb2dJQ0FnTHk4Z0lDQWdJR1psWlY5d1lXbGtQV1psWlN3S0lDQWdJQzh2SUNBZ0lDQnpaWFIwYkdWa1BVRlNRelJWU1c1ME5qUW9NQ2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHSjVkR1ZqSURFMElDOHZJREI0TURBMk1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDJDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3lNemNLSUNBZ0lDOHZJSE5sZEhSc1pXUTlRVkpETkZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TWpJM0xUSXpPQW9nSUNBZ0x5OGdjRzlzYVdONVgyUmhkR0VnUFNCUWIyeHBZM2xFWVhSaEtBb2dJQ0FnTHk4Z0lDQWdJRzkzYm1WeVBVRmtaSEpsYzNNdVpuSnZiVjlpZVhSbGN5aFVlRzR1YzJWdVpHVnlMbUo1ZEdWektTd0tJQ0FnSUM4dklDQWdJQ0I2YVhCZlkyOWtaVDFCVWtNMFUzUnlhVzVuTG1aeWIyMWZZbmwwWlhNb2VtbHdYMk52WkdVdVlubDBaWE1wTEFvZ0lDQWdMeThnSUNBZ0lIUXdQWFF3TEFvZ0lDQWdMeThnSUNBZ0lIUXhQWFF4TEFvZ0lDQWdMeThnSUNBZ0lHTmhjRDFqWVhBc0NpQWdJQ0F2THlBZ0lDQWdaR2x5WldOMGFXOXVQV1JwY21WamRHbHZiaXdLSUNBZ0lDOHZJQ0FnSUNCMGFISmxjMmh2YkdROWRHaHlaWE5vYjJ4a0xBb2dJQ0FnTHk4Z0lDQWdJSE5zYjNCbFBYTnNiM0JsTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVjl3WVdsa1BXWmxaU3dLSUNBZ0lDOHZJQ0FnSUNCelpYUjBiR1ZrUFVGU1F6UlZTVzUwTmpRb01Da0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDRDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TWpRd0xUSTBNUW9nSUNBZ0x5OGdJeUJUZEc5eVpTQndiMnhwWTNrZ2FXNGdZbTk0Q2lBZ0lDQXZMeUJ6Wld4bUxuQnZiR2xqYVdWelczQnZiR2xqZVY5cFpGMGdQU0J3YjJ4cFkzbGZaR0YwWVM1amIzQjVLQ2tLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkJ2YkdsamFXVnpJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRveU5ETUtJQ0FnSUM4dklISmxkSFZ5YmlCQlVrTTBWVWx1ZERZMEtIQnZiR2xqZVY5cFpDa0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1cGJuTjFjbUZ1WTJVdVkyOXVkSEpoWTNRdVFXZHlhVWQxWVhKa1NXNXpkWEpoYm1ObExtOXlZV05zWlY5elpYUjBiR1VvY0c5c2FXTjVYMmxrT2lCaWVYUmxjeXdnWVhCd2NtOTJaV1E2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LYjNKaFkyeGxYM05sZEhSc1pUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNalExTFRJME5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JRzl5WVdOc1pWOXpaWFIwYkdVb2MyVnNaaXdnY0c5c2FXTjVYMmxrT2lCQlVrTTBWVWx1ZERZMExDQmhjSEJ5YjNabFpEb2dRVkpETkZWSmJuUTJOQ2tnTFQ0Z1FWSkRORlZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRveU5URXRNalV5Q2lBZ0lDQXZMeUFqSUVWdWFHRnVZMlZrSUdGalkyVnpjeUJqYjI1MGNtOXNDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtOXlZV05zWlN3Z0lrOXViSGtnYjNKaFkyeGxJR05oYmlCelpYUjBiR1VnY0c5c2FXTnBaWE1pQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWIzSmhZMnhsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOXlZV05zWlNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J2Y21GamJHVWdZMkZ1SUhObGRIUnNaU0J3YjJ4cFkybGxjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG95TlRRS0lDQWdJQzh2SUhCcFpDQTlJSEJ2YkdsamVWOXBaQzV1WVhScGRtVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3lOVFVLSUNBZ0lDOHZJSEJ2YkdsamVWOWtZWFJoSUQwZ2MyVnNaaTV3YjJ4cFkybGxjeTV0WVhsaVpTaHdhV1FwV3pCZExtTnZjSGtvS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3YjJ4cFkybGxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJR1IxY0c0Z01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3lOVGN0TWpVNENpQWdJQ0F2THlBaklFVnVhR0Z1WTJWa0lIWmhiR2xrWVhScGIyNEtJQ0FnSUM4dklHRnpjMlZ5ZENCd2IyeHBZM2xmWkdGMFlTNXpaWFIwYkdWa0xtNWhkR2wyWlNBOVBTQlZTVzUwTmpRb01Da3NJQ0pRYjJ4cFkza2dZV3h5WldGa2VTQnpaWFIwYkdWa0lnb2dJQ0FnYVc1MFkxOHpJQzh2SURrd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRkJ2YkdsamVTQmhiSEpsWVdSNUlITmxkSFJzWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk1qWXdMVEkyTVFvZ0lDQWdMeThnSXlCVWFXMWxMV0poYzJWa0lIWmhiR2xrWVhScGIyNGdMU0JsYm5OMWNtVWdjRzlzYVdONUlHbHpJSGRwZEdocGJpQmpiM1psY21GblpTQndaWEpwYjJRS0lDQWdJQzh2SUdOMWNuSmxiblJmY205MWJtUWdQU0JIYkc5aVlXd3VjbTkxYm1RS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRveU5qSUtJQ0FnSUM4dklHRnpjMlZ5ZENCamRYSnlaVzUwWDNKdmRXNWtJRDQ5SUhCdmJHbGplVjlrWVhSaExuUXdMbTVoZEdsMlpTd2dJbEJ2YkdsamVTQm9ZWE1nYm05MElITjBZWEowWldRZ2VXVjBJZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ016UWdMeThnTXpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJRYjJ4cFkza2dhR0Z6SUc1dmRDQnpkR0Z5ZEdWa0lIbGxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG95TmpNS0lDQWdJQzh2SUdGemMyVnlkQ0JqZFhKeVpXNTBYM0p2ZFc1a0lEdzlJSEJ2YkdsamVWOWtZWFJoTG5ReExtNWhkR2wyWlN3Z0lsQnZiR2xqZVNCb1lYTWdaWGh3YVhKbFpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTkRJZ0x5OGdORElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklGQnZiR2xqZVNCb1lYTWdaWGh3YVhKbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3lOalVLSUNBZ0lDOHZJSEJoZVc5MWRDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNalkyQ2lBZ0lDQXZMeUJ6WlhSMGJHVnRaVzUwWDJGamRHbHZiaUE5SUVGU1F6UlRkSEpwYm1jb0luTmxkSFJzWldSZmNtVnFaV04wWldRaUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXhNRGN6TmpVM05EYzBObU0yTlRZME5XWTNNalkxTm1FMk5UWXpOelEyTlRZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qSTJPQW9nSUNBZ0x5OGdhV1lnWVhCd2NtOTJaV1F1Ym1GMGFYWmxJRDA5SUZWSmJuUTJOQ2d4S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQnZjbUZqYkdWZmMyVjBkR3hsWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG95TmprS0lDQWdJQzh2SUhCaGVXOTFkQ0E5SUhCdmJHbGplVjlrWVhSaExtTmhjQzV1WVhScGRtVUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRFV3SUM4dklEVXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNamN3Q2lBZ0lDQXZMeUJ6WlhSMGJHVnRaVzUwWDJGamRHbHZiaUE5SUVGU1F6UlRkSEpwYm1jb0luTmxkSFJzWldSZllYQndjbTkyWldRaUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXhNRGN6TmpVM05EYzBObU0yTlRZME5XWTJNVGN3TnpBM01qWm1OelkyTlRZMENpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk1qY3lMVEkzTXdvZ0lDQWdMeThnSXlCRmJtaGhibU5sWkNCd1lYbHRaVzUwSUhkcGRHZ2dZWE56WlhRZ2RtRnNhV1JoZEdsdmJnb2dJQ0FnTHk4Z2FXWWdjR0Y1YjNWMElENGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1lub2diM0poWTJ4bFgzTmxkSFJzWlY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TWpjMExUSTRNQW9nSUNBZ0x5OGdJeUJWYzJVZ2FXNXVaWElnZEhKaGJuTmhZM1JwYjI0Z1ptOXlJSE5sWTNWeVpTQndZWGx0Wlc1MENpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5Y0c5c2FXTjVYMlJoZEdFdWIzZHVaWEl1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF3WVhsdmRYUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNneE1EQXdLU3dLSUNBZ0lDOHZJQ0FnSUNCdWIzUmxQVUo1ZEdWektHSWlRV2R5YVVkMVlYSmtJRWx1YzNWeVlXNWpaU0JRWVhsdmRYUWlLUW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3lOellLSUNBZ0lDOHZJSEpsWTJWcGRtVnlQWEJ2YkdsamVWOWtZWFJoTG05M2JtVnlMbTVoZEdsMlpTd0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJREFnTXpJZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pJM09Rb2dJQ0FnTHk4Z2JtOTBaVDFDZVhSbGN5aGlJa0ZuY21sSGRXRnlaQ0JKYm5OMWNtRnVZMlVnVUdGNWIzVjBJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFF4TmpjM01qWTVORGMzTlRZeE56STJOREl3TkRrMlpUY3pOelUzTWpZeE5tVTJNelkxTWpBMU1EWXhOemsyWmpjMU56UUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1RtOTBaUW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPakkzTkMweU56VUtJQ0FnSUM4dklDTWdWWE5sSUdsdWJtVnlJSFJ5WVc1ellXTjBhVzl1SUdadmNpQnpaV04xY21VZ2NHRjViV1Z1ZEFvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRveU56Z0tJQ0FnSUM4dklHWmxaVDFWU1c1ME5qUW9NVEF3TUNrc0NpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNamMwTFRJNE1Bb2dJQ0FnTHk4Z0l5QlZjMlVnYVc1dVpYSWdkSEpoYm5OaFkzUnBiMjRnWm05eUlITmxZM1Z5WlNCd1lYbHRaVzUwQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljRzlzYVdONVgyUmhkR0V1YjNkdVpYSXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXdZWGx2ZFhRc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d4TURBd0tTd0tJQ0FnSUM4dklDQWdJQ0J1YjNSbFBVSjVkR1Z6S0dJaVFXZHlhVWQxWVhKa0lFbHVjM1Z5WVc1alpTQlFZWGx2ZFhRaUtRb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0NtOXlZV05zWlY5elpYUjBiR1ZmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG95T0RJdE1qZ3pDaUFnSUNBdkx5QWpJRTFoY21zZ1lYTWdjMlYwZEd4bFpBb2dJQ0FnTHk4Z2NHOXNhV041WDJSaGRHRXVjMlYwZEd4bFpDQTlJRUZTUXpSVlNXNTBOalFvTVNrS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNUW9nSUNBZ2NtVndiR0ZqWlRJZ09UQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNamcwQ2lBZ0lDQXZMeUJ6Wld4bUxuQnZiR2xqYVdWelczQnBaRjBnUFNCd2IyeHBZM2xmWkdGMFlTNWpiM0I1S0NrS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNamcyTFRJNE53b2dJQ0FnTHk4Z0l5QlZjR1JoZEdVZ2MzUmhkR2x6ZEdsamN3b2dJQ0FnTHk4Z2MyVnNaaTVmZFhCa1lYUmxYM04wWVhSektGTjBjbWx1WnlnaWNHOXNhV041WDNObGRIUnNaV1FpS1N3Z1FWSkRORlZKYm5RMk5DaHdZWGx2ZFhRcExDQkJVa00wVlVsdWREWTBLREFwS1FvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURFeklDOHZJQ0p3YjJ4cFkzbGZjMlYwZEd4bFpDSUtJQ0FnSUdScFp5QXhDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTJGc2JITjFZaUJmZFhCa1lYUmxYM04wWVhSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qSTRPUzB5T1RBS0lDQWdJQzh2SUNNZ1RHOW5JSE5sZEhSc1pXMWxiblFnWlhabGJuUUtJQ0FnSUM4dklITmxiR1l1WDJ4dloxOWxkbVZ1ZENoQlVrTTBWVWx1ZERZMEtIQnBaQ2tzSUhCdmJHbGplVjlrWVhSaExtOTNibVZ5TENCelpYUjBiR1Z0Wlc1MFgyRmpkR2x2Yml3Z1FWSkRORlZKYm5RMk5DaHdZWGx2ZFhRcEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUlDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCa2FXY2dNd29nSUNBZ1kyRnNiSE4xWWlCZmJHOW5YMlYyWlc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qSTVNaTB5T1RNS0lDQWdJQzh2SUNNZ1JXMXBkQ0JzYjJjZ1ptOXlJR1Y0ZEdWeWJtRnNJRzF2Ym1sMGIzSnBibWNLSUNBZ0lDOHZJR3h2WnloQ2VYUmxjeWhpSWxCUFRFbERXVjlUUlZSVVRFVkVJaWtnS3lCVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRBMFpqUmpORGswTXpVNU5XWTFNelExTlRRMU5EUmpORFUwTkFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TWprMUNpQWdJQ0F2THlCeVpYUjFjbTRnUVZKRE5GVkpiblEyTkNod1lYbHZkWFFwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXBibk4xY21GdVkyVXVZMjl1ZEhKaFkzUXVRV2R5YVVkMVlYSmtTVzV6ZFhKaGJtTmxMbVJwYzNCMWRHVmZjMlYwZEd4bGJXVnVkQ2h3YjJ4cFkzbGZhV1E2SUdKNWRHVnpMQ0J5WldGemIyNDZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taR2x6Y0hWMFpWOXpaWFIwYkdWdFpXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG95T1RjdE1qazRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnWkdsemNIVjBaVjl6WlhSMGJHVnRaVzUwS0hObGJHWXNJSEJ2YkdsamVWOXBaRG9nUVZKRE5GVkpiblEyTkN3Z2NtVmhjMjl1T2lCQlVrTTBVM1J5YVc1bktTQXRQaUJCVWtNMFZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNekF6Q2lBZ0lDQXZMeUJ3YVdRZ1BTQndiMnhwWTNsZmFXUXVibUYwYVhabENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk16QTBDaUFnSUNBdkx5QmpZV3hzWlhJZ1BTQkJaR1J5WlhOekxtWnliMjFmWW5sMFpYTW9WSGh1TG5ObGJtUmxjaTVpZVhSbGN5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk16QTJMVE13TndvZ0lDQWdMeThnSXlCRmJtaGhibU5sWkNCMllXeHBaR0YwYVc5dUNpQWdJQ0F2THlCd2IyeHBZM2xmWkdGMFlTQTlJSE5sYkdZdWNHOXNhV05wWlhNdWJXRjVZbVVvY0dsa0tWc3dYUzVqYjNCNUtDa0tJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNHOXNhV05wWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TXpFd0NpQWdJQ0F2THlCcFppQnViM1FnWlhocGMzUnpPZ29nSUNBZ1ltNTZJR1JwYzNCMWRHVmZjMlYwZEd4bGJXVnVkRjloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNekV4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRVkpETkZWSmJuUTJOQ2d3S1NBZ0l5QlFiMnhwWTNrZ1pHOWxjMjRuZENCbGVHbHpkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BrYVhOd2RYUmxYM05sZEhSc1pXMWxiblJmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG96TVRNS0lDQWdJQzh2SUdsbUlHTmhiR3hsY2lBaFBTQndiMnhwWTNsZlpHRjBZUzV2ZDI1bGNqb0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JsZUhSeVlXTjBJREFnTXpJZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ0lUMEtJQ0FnSUdKNklHUnBjM0IxZEdWZmMyVjBkR3hsYldWdWRGOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk16RTBDaUFnSUNBdkx5QnlaWFIxY200Z1FWSkRORlZKYm5RMk5DZ3dLU0FnSXlCT2IzUWdkR2hsSUc5M2JtVnlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDbVJwYzNCMWRHVmZjMlYwZEd4bGJXVnVkRjloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPak14TmdvZ0lDQWdMeThnYVdZZ2NHOXNhV041WDJSaGRHRXVjMlYwZEd4bFpDNXVZWFJwZG1VZ1BUMGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdsdWRHTmZNeUF2THlBNU1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JpYm5vZ1pHbHpjSFYwWlY5elpYUjBiR1Z0Wlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvek1UY0tJQ0FnSUM4dklISmxkSFZ5YmlCQlVrTTBWVWx1ZERZMEtEQXBJQ0FqSUZCdmJHbGplU0J1YjNRZ2MyVjBkR3hsWkNCNVpYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0taR2x6Y0hWMFpWOXpaWFIwYkdWdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNekU1TFRNeU1Bb2dJQ0FnTHk4Z0l5QlVhVzFsTFdKaGMyVmtJSFpoYkdsa1lYUnBiMjRnTFNCa2FYTndkWFJsY3lCdGRYTjBJR0psSUdacGJHVmtJSGRwZEdocGJpQjBhVzFsSUhkcGJtUnZkd29nSUNBZ0x5OGdZM1Z5Y21WdWRGOXliM1Z1WkNBOUlFZHNiMkpoYkM1eWIzVnVaQW9nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPak15TWkwek1qTUtJQ0FnSUM4dklDTWdRV3hzYjNjZ1pHbHpjSFYwWlhNZ2QybDBhR2x1SURFd01EQWdjbTkxYm1SeklDaGhjSEJ5YjNocGJXRjBaV3g1SURNdE5DQmtZWGx6S1NCdlppQnpaWFIwYkdWdFpXNTBDaUFnSUNBdkx5QmhjM05sY25RZ1kzVnljbVZ1ZEY5eWIzVnVaQ0E4UFNCelpYUjBiR1Z0Wlc1MFgzSnZkVzVrSUNzZ1ZVbHVkRFkwS0RFd01EQXBMQ0FpUkdsemNIVjBaU0JtYVd4cGJtY2djR1Z5YVc5a0lHVjRjR2x5WldRaUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdhVzUwWXlBMElDOHZJREV3TURBS0lDQWdJQ3NLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1JHbHpjSFYwWlNCbWFXeHBibWNnY0dWeWFXOWtJR1Y0Y0dseVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNekkxTFRNeU5nb2dJQ0FnTHk4Z0l5QkRjbTl6Y3kxamIyNTBjbUZqZENCamIyMXRkVzVwWTJGMGFXOXVPaUJEWVd4c0lHUnBjM0IxZEdVZ1kyOXVkSEpoWTNRS0lDQWdJQzh2SUdsbUlITmxiR1l1WkdsemNIVjBaVjlqYjI1MGNtRmpkQ0FoUFNCQlpHUnlaWE56S0Vkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNcE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW1ScGMzQjFkR1ZmWTI5dWRISmhZM1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpHbHpjSFYwWlY5amIyNTBjbUZqZENCbGVHbHpkSE1LSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnSVQwS0lDQWdJR0o2SUdScGMzQjFkR1ZmYzJWMGRHeGxiV1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TXpJM0xUTXlPUW9nSUNBZ0x5OGdJeUJPYjNSbE9pQkRjbTl6Y3kxamIyNTBjbUZqZENCallXeHNJSEJoY21GdFpYUmxjbk1nYm1WbFpDQndjbTl3WlhJZ1lYQndJSEpsWm1WeVpXNWpaUW9nSUNBZ0x5OGdJeUJHYjNJZ2JtOTNMQ0IwYUdseklIUnlhV2RuWlhKeklHRnVJR1YyWlc1MElIUm9ZWFFnWTJGdUlHSmxJRzF2Ym1sMGIzSmxaQ0JsZUhSbGNtNWhiR3g1Q2lBZ0lDQXZMeUJzYjJjb1FubDBaWE1vWWlKRFVrOVRVMTlEVDA1VVVrRkRWRjlFU1ZOUVZWUkZJaWtnS3lCQ2VYUmxjeWhpSW1ScGMzQjFkR1ZmWTNKbFlYUmxaQ0lwS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkRNMU1qUm1OVE0xTXpWbU5ETTBaalJsTlRRMU1qUXhORE0xTkRWbU5EUTBPVFV6TlRBMU5UVTBORFUyTkRZNU56TTNNRGMxTnpRMk5UVm1Oak0zTWpZMU5qRTNORFkxTmpRS0lDQWdJR3h2WndvS1pHbHpjSFYwWlY5elpYUjBiR1Z0Wlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk16TXhMVE16TWdvZ0lDQWdMeThnSXlCTWIyY2daR2x6Y0hWMFpTQmxkbVZ1ZEFvZ0lDQWdMeThnYzJWc1ppNWZiRzluWDJWMlpXNTBLRUZTUXpSVlNXNTBOalFvY0dsa0tTd2dZMkZzYkdWeUxDQkJVa00wVTNSeWFXNW5LQ0prYVhOd2RYUmxaQ0lwTENCQlVrTTBWVWx1ZERZMEtEQXBLUW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNRGcyTkRZNU56TTNNRGMxTnpRMk5UWTBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTJGc2JITjFZaUJmYkc5blgyVjJaVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pNek5DMHpNelVLSUNBZ0lDOHZJQ01nUlcxcGRDQnNiMmNnWm05eUlHVjRkR1Z5Ym1Gc0lHMXZibWwwYjNKcGJtY0tJQ0FnSUM4dklHeHZaeWhDZVhSbGN5aGlJa1JKVTFCVlZFVmZRMUpGUVZSRlJDSXBJQ3NnWTJGc2JHVnlMbUo1ZEdWektRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5EUTBPVFV6TlRBMU5UVTBORFUxWmpRek5USTBOVFF4TlRRME5UUTBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG96TXpjS0lDQWdJQzh2SUhKbGRIVnliaUJCVWtNMFZVbHVkRFkwS0RFcENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVhVzV6ZFhKaGJtTmxMbU52Ym5SeVlXTjBMa0ZuY21sSGRXRnlaRWx1YzNWeVlXNWpaUzVuWlhSZmNHOXNhV041S0hCdmJHbGplVjlwWkRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwblpYUmZjRzlzYVdONU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3pNemt0TXpRd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQXZMeUJrWldZZ1oyVjBYM0J2YkdsamVTaHpaV3htTENCd2IyeHBZM2xmYVdRNklFRlNRelJWU1c1ME5qUXBJQzArSUZCdmJHbGplVVJoZEdFNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TXpReUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXdiMnhwWTJsbGN5NXRZWGxpWlNod2IyeHBZM2xmYVdRdWJtRjBhWFpsS1Zzd1hTNWpiM0I1S0NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZblJ2YVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk15QXZMeUFpY0c5c2FXTnBaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1sdWMzVnlZVzVqWlM1amIyNTBjbUZqZEM1QlozSnBSM1ZoY21SSmJuTjFjbUZ1WTJVdVoyVjBYM0J2YkdsamFXVnpYMko1WDI5M2JtVnlLRzkzYm1WeU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtZGxkRjl3YjJ4cFkybGxjMTlpZVY5dmQyNWxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TXpRMExUTTBOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5d2IyeHBZMmxsYzE5aWVWOXZkMjVsY2loelpXeG1MQ0J2ZDI1bGNqb2dRV1JrY21WemN5a2dMVDRnVkhWd2JHVmJRVkpETkZWSmJuUTJOQ3dnUVZKRE5GVkpiblEyTkYwNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3pOVEVLSUNBZ0lDOHZJR052ZFc1MElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3pOVElLSUNBZ0lDOHZJR1pwY25OMFgzQnZiR2xqZVY5cFpDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pNMU5DMHpOVFVLSUNBZ0lDOHZJQ01nUTJobFkyc2daV0ZqYUNCd2IyeHBZM2tnU1VRZ1puSnZiU0F4SUhSdklHNWxlSFJmY0c5c2FXTjVYMmxrSUMwZ01Rb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0RFc0lITmxiR1l1Ym1WNGRGOXdiMnhwWTNsZmFXUXBPZ29nSUNBZ1lubDBaV05mTWlBdkx5QWlibVY0ZEY5d2IyeHBZM2xmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVibVY0ZEY5d2IyeHBZM2xmYVdRZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9LWjJWMFgzQnZiR2xqYVdWelgySjVYMjkzYm1WeVgyWnZjbDlvWldGa1pYSkFNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TXpVMExUTTFOUW9nSUNBZ0x5OGdJeUJEYUdWamF5QmxZV05vSUhCdmJHbGplU0JKUkNCbWNtOXRJREVnZEc4Z2JtVjRkRjl3YjJ4cFkzbGZhV1FnTFNBeENpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvTVN3Z2MyVnNaaTV1WlhoMFgzQnZiR2xqZVY5cFpDazZDaUFnSUNCbWNtRnRaVjlrYVdjZ05nb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJRHdLSUNBZ0lHSjZJR2RsZEY5d2IyeHBZMmxsYzE5aWVWOXZkMjVsY2w5aFpuUmxjbDltYjNKQU1UQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNelUzQ2lBZ0lDQXZMeUJwWmlCelpXeG1MbkJ2YkdsamFXVnpMbTFoZVdKbEtIQnZiR2xqZVY5cFpDbGJNVjA2SUNBaklGQnZiR2xqZVNCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QTJDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndiMnhwWTJsbGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNZ29nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWW5vZ1oyVjBYM0J2YkdsamFXVnpYMko1WDI5M2JtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3pOVGdLSUNBZ0lDOHZJSEJ2YkdsamVWOWtZWFJoSUQwZ2MyVnNaaTV3YjJ4cFkybGxjeTV0WVhsaVpTaHdiMnhwWTNsZmFXUXBXekJkTG1OdmNIa29LUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG96TlRrS0lDQWdJQzh2SUdsbUlIQnZiR2xqZVY5a1lYUmhMbTkzYm1WeUxtNWhkR2wyWlNBOVBTQnZkMjVsY2k1dVlYUnBkbVU2Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUQwOUNpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCaWVpQm5aWFJmY0c5c2FXTnBaWE5mWW5sZmIzZHVaWEpmWVdaMFpYSmZhV1pmWld4elpVQTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPak0yTUFvZ0lDQWdMeThnWTI5MWJuUWdLejBnVlVsdWREWTBLREVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTXdvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPak0yTVFvZ0lDQWdMeThnYVdZZ1ptbHljM1JmY0c5c2FXTjVYMmxrSUQwOUlGVkpiblEyTkNnd0tUb0tJQ0FnSUdKdWVpQm5aWFJmY0c5c2FXTnBaWE5mWW5sZmIzZHVaWEpmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNCbWNtRnRaVjlrYVdjZ05nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNncG5aWFJmY0c5c2FXTnBaWE5mWW5sZmIzZHVaWEpmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb0taMlYwWDNCdmJHbGphV1Z6WDJKNVgyOTNibVZ5WDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lHSWdaMlYwWDNCdmJHbGphV1Z6WDJKNVgyOTNibVZ5WDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9LWjJWMFgzQnZiR2xqYVdWelgySjVYMjkzYm1WeVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNelUwTFRNMU5Rb2dJQ0FnTHk4Z0l5QkRhR1ZqYXlCbFlXTm9JSEJ2YkdsamVTQkpSQ0JtY205dElERWdkRzhnYm1WNGRGOXdiMnhwWTNsZmFXUWdMU0F4Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9NU3dnYzJWc1ppNXVaWGgwWDNCdmJHbGplVjlwWkNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ05nb2dJQ0FnWWlCblpYUmZjRzlzYVdOcFpYTmZZbmxmYjNkdVpYSmZabTl5WDJobFlXUmxja0F4Q2dwblpYUmZjRzlzYVdOcFpYTmZZbmxmYjNkdVpYSmZZV1owWlhKZlptOXlRREV3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvek5qUUtJQ0FnSUM4dklISmxkSFZ5YmlCVWRYQnNaU2dvUVZKRE5GVkpiblEyTkNoamIzVnVkQ2tzSUVGU1F6UlZTVzUwTmpRb1ptbHljM1JmY0c5c2FXTjVYMmxrS1NrcENpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVhVzV6ZFhKaGJtTmxMbU52Ym5SeVlXTjBMa0ZuY21sSGRXRnlaRWx1YzNWeVlXNWpaUzVuWlhSZmNHOXNhV041WDJOdmRXNTBLQ2tnTFQ0Z1lubDBaWE02Q21kbGRGOXdiMnhwWTNsZlkyOTFiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pNMk9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUVGU1F6UlZTVzUwTmpRb2MyVnNaaTV1WlhoMFgzQnZiR2xqZVY5cFpDQXRJRlZKYm5RMk5DZ3hLU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnVaWGgwWDNCdmJHbGplVjlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXVaWGgwWDNCdmJHbGplVjlwWkNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YVc1emRYSmhibU5sTG1OdmJuUnlZV04wTGtGbmNtbEhkV0Z5WkVsdWMzVnlZVzVqWlM1allXeGpkV3hoZEdWZlptVmxLR05oY0RvZ1lubDBaWE1zSUhKcGMydGZjMk52Y21VNklHSjVkR1Z6TENCMWJtTmxjblJoYVc1MGVUb2dZbmwwWlhNc0lHUjFjbUYwYVc5dVgyUmhlWE02SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWTJGc1kzVnNZWFJsWDJabFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZNemN4TFRNM09Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHTmhiR04xYkdGMFpWOW1aV1VvQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaXdLSUNBZ0lDOHZJQ0FnSUNCallYQTZJRUZTUXpSVlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ2NtbHphMTl6WTI5eVpUb2dRVkpETkZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCMWJtTmxjblJoYVc1MGVUb2dRVkpETkZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCa2RYSmhkR2x2Ymw5a1lYbHpPaUJCVWtNMFZVbHVkRFkwQ2lBZ0lDQXZMeUFwSUMwK0lFRlNRelJWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUEwSURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk16Z3pMVE00TkFvZ0lDQWdMeThnSXlCQ1lYTmxJR1psWlRvZ01TVWdiMllnWTI5MlpYSmhaMlVnWVcxdmRXNTBDaUFnSUNBdkx5QmlZWE5sWDJabFpTQTlJR05oY0M1dVlYUnBkbVVnTHk4Z1ZVbHVkRFkwS0RFd01Da0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHlJQzh2SURFd01Bb2dJQ0FnTHdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvek9EWXRNemczQ2lBZ0lDQXZMeUFqSUZKcGMyc2diWFZzZEdsd2JHbGxjam9nTVM0d0lIUnZJREl1TUNCaVlYTmxaQ0J2YmlCeWFYTnJJSE5qYjNKbElDZ3dMVEV3TUNrS0lDQWdJQzh2SUhKcGMydGZiWFZzZEdsd2JHbGxjaUE5SUZWSmJuUTJOQ2d4TURBcElDc2dLSEpwYzJ0ZmMyTnZjbVV1Ym1GMGFYWmxJQzh2SUZWSmJuUTJOQ2d5S1NrZ0lDTWdNVEF3TFRFMU1DQW9NUzR3TFRFdU5YZ3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdKMGIya0tJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBdkNpQWdJQ0JwYm5Salh6SWdMeThnTVRBd0NpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pNNE9TMHpPVEFLSUNBZ0lDOHZJQ01nVlc1alpYSjBZV2x1ZEhrZ2JYVnNkR2x3YkdsbGNqb2dNUzR3SUhSdklERXVOU0JpWVhObFpDQnZiaUIxYm1ObGNuUmhhVzUwZVNBb01DMDFNQ1VwQ2lBZ0lDQXZMeUIxYm1ObGNuUmhhVzUwZVY5dGRXeDBhWEJzYVdWeUlEMGdWVWx1ZERZMEtERXdNQ2tnS3lCMWJtTmxjblJoYVc1MGVTNXVZWFJwZG1VZ0lDTWdNVEF3TFRFMU1DQW9NUzR3TFRFdU5YZ3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNaUF2THlBeE1EQUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk16a3lMVE01TXdvZ0lDQWdMeThnSXlCRWRYSmhkR2x2YmlCdGRXeDBhWEJzYVdWeU9pQXhMakFnZEc4Z01pNHdJR0poYzJWa0lHOXVJR1IxY21GMGFXOXVJQ2d4TFRNMk5TQmtZWGx6S1FvZ0lDQWdMeThnWkhWeVlYUnBiMjVmYlhWc2RHbHdiR2xsY2lBOUlGVkpiblEyTkNneE1EQXBJQ3NnS0dSMWNtRjBhVzl1WDJSaGVYTXVibUYwYVhabElDOHZJRlZKYm5RMk5DZ3lLU2tnSUNNZ01UQXdMVEk0TWlBb01TNHdMVEl1T0RKNEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZEc5cENpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnTHdvZ0lDQWdhVzUwWTE4eUlDOHZJREV3TUFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG96T1RVdE16azJDaUFnSUNBdkx5QWpJRU5oYkdOMWJHRjBaU0JtYVc1aGJDQm1aV1VLSUNBZ0lDOHZJR1psWlNBOUlDaGlZWE5sWDJabFpTQXFJSEpwYzJ0ZmJYVnNkR2x3YkdsbGNpQXFJSFZ1WTJWeWRHRnBiblI1WDIxMWJIUnBjR3hwWlhJZ0tpQmtkWEpoZEdsdmJsOXRkV3gwYVhCc2FXVnlLU0F2THlBb1ZVbHVkRFkwS0RFd01Da2dLaUJWU1c1ME5qUW9NVEF3S1NBcUlGVkpiblEyTkNneE1EQXBLUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lDb0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdLZ29nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01EQXdJQzh2SURFd01EQXdNREFLSUNBZ0lDOEtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUb3pPVGd0TXprNUNpQWdJQ0F2THlBaklFMXBibWx0ZFcwZ1ptVmxJRzltSURFd01EQWdiV2xqY205QlRFZFBDaUFnSUNBdkx5QnRhVzVmWm1WbElEMGdWVWx1ZERZMEtERXdNREFwQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVEF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvME1EQUtJQ0FnSUM4dklHbG1JR1psWlNBOElHMXBibDltWldVNkNpQWdJQ0E4Q2lBZ0lDQmllaUJqWVd4amRXeGhkR1ZmWm1WbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvek9UZ3RNems1Q2lBZ0lDQXZMeUFqSUUxcGJtbHRkVzBnWm1WbElHOW1JREV3TURBZ2JXbGpjbTlCVEVkUENpQWdJQ0F2THlCdGFXNWZabVZsSUQwZ1ZVbHVkRFkwS0RFd01EQXBDaUFnSUNCcGJuUmpJRFFnTHk4Z01UQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG8wTURFS0lDQWdJQzh2SUdabFpTQTlJRzFwYmw5bVpXVUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb0tZMkZzWTNWc1lYUmxYMlpsWlY5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pRd013b2dJQ0FnTHk4Z2NtVjBkWEp1SUVGU1F6UlZTVzUwTmpRb1ptVmxLUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1cGJuTjFjbUZ1WTJVdVkyOXVkSEpoWTNRdVFXZHlhVWQxWVhKa1NXNXpkWEpoYm1ObExtUmxiR1YwWlY5d2IyeHBZM2tvY0c5c2FXTjVYMmxrT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21SbGJHVjBaVjl3YjJ4cFkzazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPalF3TlMwME1EWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJrWld4bGRHVmZjRzlzYVdONUtITmxiR1lzSUhCdmJHbGplVjlwWkRvZ1FWSkRORlZKYm5RMk5Da2dMVDRnUVZKRE5GVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG8wTVRFS0lDQWdJQzh2SUhCcFpDQTlJSEJ2YkdsamVWOXBaQzV1WVhScGRtVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUbzBNVE10TkRFMENpQWdJQ0F2THlBaklFTm9aV05ySUdsbUlIQnZiR2xqZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSEJ2YkdsamVWOWtZWFJoSUQwZ2MyVnNaaTV3YjJ4cFkybGxjeTV0WVhsaVpTaHdhV1FwV3pCZExtTnZjSGtvS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk15QXZMeUFpY0c5c2FXTnBaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUbzBNVGNLSUNBZ0lDOHZJR2xtSUc1dmRDQmxlR2x6ZEhNNkNpQWdJQ0JpYm5vZ1pHVnNaWFJsWDNCdmJHbGplVjloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZOREU0TFRReE9Rb2dJQ0FnTHk4Z0l5QlFiMnhwWTNrZ1pHOWxjMjRuZENCbGVHbHpkQW9nSUNBZ0x5OGdjbVYwZFhKdUlFRlNRelJWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWkdWc1pYUmxYM0J2YkdsamVWOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qUXlNUzAwTWpJS0lDQWdJQzh2SUNNZ1EyaGxZMnNnYVdZZ1kyRnNiR1Z5SUdseklIUm9aU0J2ZDI1bGNnb2dJQ0FnTHk4Z1kyRnNiR1Z5SUQwZ1FXUmtjbVZ6Y3k1bWNtOXRYMko1ZEdWektGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pReU13b2dJQ0FnTHk4Z2FXWWdZMkZzYkdWeUlDRTlJSEJ2YkdsamVWOWtZWFJoTG05M2JtVnlPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTUNBek1pQXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQ0U5Q2lBZ0lDQmllaUJrWld4bGRHVmZjRzlzYVdONVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvME1qUXROREkxQ2lBZ0lDQXZMeUFqSUVOaGJHeGxjaUJwY3lCdWIzUWdkR2hsSUc5M2JtVnlDaUFnSUNBdkx5QnlaWFIxY200Z1FWSkRORlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BrWld4bGRHVmZjRzlzYVdONVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk5ESTNMVFF5T0FvZ0lDQWdMeThnSXlCRGFHVmpheUJwWmlCd2IyeHBZM2tnYVhNZ1lXeHlaV0ZrZVNCelpYUjBiR1ZrQ2lBZ0lDQXZMeUJwWmlCd2IyeHBZM2xmWkdGMFlTNXpaWFIwYkdWa0xtNWhkR2wyWlNBOVBTQlZTVzUwTmpRb01TazZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnYVc1MFkxOHpJQzh2SURrd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmllaUJrWld4bGRHVmZjRzlzYVdONVgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvME1qa3RORE13Q2lBZ0lDQXZMeUFqSUZCdmJHbGplU0JwY3lCaGJISmxZV1I1SUhObGRIUnNaV1FzSUdOaGJtNXZkQ0JrWld4bGRHVUtJQ0FnSUM4dklISmxkSFZ5YmlCQlVrTTBWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDbVJsYkdWMFpWOXdiMnhwWTNsZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvME16SXRORE0wQ2lBZ0lDQXZMeUFqSUVSbGJHVjBaU0IwYUdVZ2NHOXNhV041SUdaeWIyMGdjM1J2Y21GblpRb2dJQ0FnTHk4Z0l5QkpiaUJRZVZSbFlXd2dRbTk0VFdGd0xDQjNaU0JrWld4bGRHVWdZbmtnZFhOcGJtY2daR1ZzSUd0bGVYZHZjbVFLSUNBZ0lDOHZJR1JsYkNCelpXeG1MbkJ2YkdsamFXVnpXM0JwWkYwS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk5ETTJDaUFnSUNBdkx5QnlaWFIxY200Z1FWSkRORlZKYm5RMk5DZ3hLUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01ERUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1sdWMzVnlZVzVqWlM1amIyNTBjbUZqZEM1QlozSnBSM1ZoY21SSmJuTjFjbUZ1WTJVdVoyVjBYMmRzYjJKaGJITW9LU0F0UGlCaWVYUmxjem9LWjJWMFgyZHNiMkpoYkhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qUTBNZ29nSUNBZ0x5OGdRV1JrY21WemN5NW1jbTl0WDJKNWRHVnpLSE5sYkdZdVlXUnRhVzR1WW5sMFpYTXBMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG8wTkRNS0lDQWdJQzh2SUVGa1pISmxjM011Wm5KdmJWOWllWFJsY3loelpXeG1MbTl5WVdOc1pTNWllWFJsY3lrc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpYjNKaFkyeGxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG05eVlXTnNaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZORFEwQ2lBZ0lDQXZMeUJCVWtNMFZVbHVkRFkwS0hObGJHWXVibVY0ZEY5d2IyeHBZM2xmYVdRcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYm1WNGRGOXdiMnhwWTNsZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Ym1WNGRGOXdiMnhwWTNsZmFXUWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qUTBNUzAwTkRVS0lDQWdJQzh2SUhKbGRIVnliaUJVZFhCc1pTZ29DaUFnSUNBdkx5QWdJQ0FnUVdSa2NtVnpjeTVtY205dFgySjVkR1Z6S0hObGJHWXVZV1J0YVc0dVlubDBaWE1wTEFvZ0lDQWdMeThnSUNBZ0lFRmtaSEpsYzNNdVpuSnZiVjlpZVhSbGN5aHpaV3htTG05eVlXTnNaUzVpZVhSbGN5a3NDaUFnSUNBdkx5QWdJQ0FnUVZKRE5GVkpiblEyTkNoelpXeG1MbTVsZUhSZmNHOXNhV041WDJsa0tRb2dJQ0FnTHk4Z0tTa0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YVc1emRYSmhibU5sTG1OdmJuUnlZV04wTGtGbmNtbEhkV0Z5WkVsdWMzVnlZVzVqWlM1blpYUmZjM1JoZEdsemRHbGpjeWdwSUMwK0lHSjVkR1Z6T2dwblpYUmZjM1JoZEdsemRHbGpjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TkRVd0NpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXpkR0YwYzE5aWIzZ3VkbUZzZFdVS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5OMFlYUnpYMkp2ZUNJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTjBZWFJ6WDJKdmVDQmxlR2x6ZEhNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVwYm5OMWNtRnVZMlV1WTI5dWRISmhZM1F1UVdkeWFVZDFZWEprU1c1emRYSmhibU5sTG1kbGRGOWxkbVZ1ZENobGRtVnVkRjlwWkRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwblpYUmZaWFpsYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qUTFNaTAwTlRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lDOHZJR1JsWmlCblpYUmZaWFpsYm5Rb2MyVnNaaXdnWlhabGJuUmZhV1E2SUVGU1F6UlZTVzUwTmpRcElDMCtJRkJ2YkdsamVVVjJaVzUwT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPalExTlFvZ0lDQWdMeThnWlhabGJuUWdQU0J6Wld4bUxtVjJaVzUwWDJ4dlp5NXRZWGxpWlNobGRtVnVkRjlwWkM1dVlYUnBkbVVwV3pCZExtTnZjSGtvS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpWlhabGJuUmZiRzluSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUbzBOVFl0TkRZeUNpQWdJQ0F2THlCcFppQmxkbVZ1ZENBOVBTQlFiMnhwWTNsRmRtVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCd2IyeHBZM2xmYVdROVFWSkRORlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCdmQyNWxjajFCWkdSeVpYTnpLRWRzYjJKaGJDNTZaWEp2WDJGa1pISmxjM01wTEFvZ0lDQWdMeThnSUNBZ0lHRmpkR2x2YmoxQlVrTTBVM1J5YVc1bktDSWlLU3dLSUNBZ0lDOHZJQ0FnSUNCMGFXMWxjM1JoYlhBOVFWSkRORlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5UVZKRE5GVkpiblEyTkNnd0tRb2dJQ0FnTHk4Z0tUb0tJQ0FnSUhCMWMyaGllWFJsY3lCaVlYTmxNeklvUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQk5VRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJLUW9nSUNBZ1BUMEtJQ0FnSUdKNklHZGxkRjlsZG1WdWRGOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk5EWXpMVFEyT1FvZ0lDQWdMeThnY21WMGRYSnVJRkJ2YkdsamVVVjJaVzUwS0FvZ0lDQWdMeThnSUNBZ0lIQnZiR2xqZVY5cFpEMUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHOTNibVZ5UFVGa1pISmxjM01vUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3lrc0NpQWdJQ0F2THlBZ0lDQWdZV04wYVc5dVBVRlNRelJUZEhKcGJtY29JbVYyWlc1MFgyNXZkRjltYjNWdVpDSXBMQW9nSUNBZ0x5OGdJQ0FnSUhScGJXVnpkR0Z0Y0QxQlVrTTBWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFCVWtNMFZVbHVkRFkwS0RBcENpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb1lubDBaWE1nWW1GelpUTXlLRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVRWQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlVFMVdNMGRMTTFSVlREVllSelkxUXpkTldsaFlTek5VUlNrS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0taMlYwWDJWMlpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZORGN3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdaWFpsYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVhVzV6ZFhKaGJtTmxMbU52Ym5SeVlXTjBMa0ZuY21sSGRXRnlaRWx1YzNWeVlXNWpaUzVuWlhSZmNtVmpaVzUwWDJWMlpXNTBjeWhzYVcxcGREb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncG5aWFJmY21WalpXNTBYMlYyWlc1MGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZORGN5TFRRM013b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjl5WldObGJuUmZaWFpsYm5SektITmxiR1lzSUd4cGJXbDBPaUJCVWtNMFZVbHVkRFkwS1NBdFBpQlVkWEJzWlZ0QlVrTTBWVWx1ZERZMExDQkJVa00wVlVsdWREWTBYVG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWMzVnlZVzVqWlM5amIyNTBjbUZqZEM1d2VUbzBOelVLSUNBZ0lDOHZJSFJ2ZEdGc1gyVjJaVzUwY3lBOUlITmxiR1l1Ym1WNGRGOWxkbVZ1ZEY5cFpDQXRJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltNWxlSFJmWlhabGJuUmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJtVjRkRjlsZG1WdWRGOXBaQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TkRjMkNpQWdJQ0F2THlCemRHRnlkRjlwWkNBOUlIUnZkR0ZzWDJWMlpXNTBjeUF0SUd4cGJXbDBMbTVoZEdsMlpTQXJJRlZKYm5RMk5DZ3hLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWRHOXBDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPalEzTndvZ0lDQWdMeThnYVdZZ2MzUmhjblJmYVdRZ1BDQlZTVzUwTmpRb01TazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUEFvZ0lDQWdZbm9nWjJWMFgzSmxZMlZ1ZEY5bGRtVnVkSE5mWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNXpkWEpoYm1ObEwyTnZiblJ5WVdOMExuQjVPalEzT0FvZ0lDQWdMeThnYzNSaGNuUmZhV1FnUFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLQ21kbGRGOXlaV05sYm5SZlpYWmxiblJ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TkRnd0NpQWdJQ0F2THlCeVpYUjFjbTRnVkhWd2JHVW9LRUZTUXpSVlNXNTBOalFvZEc5MFlXeGZaWFpsYm5SektTd2dRVkpETkZWSmJuUTJOQ2h6ZEdGeWRGOXBaQ2twS1FvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtbHVjM1Z5WVc1alpTNWpiMjUwY21GamRDNUJaM0pwUjNWaGNtUkpibk4xY21GdVkyVXVkbUZzYVdSaGRHVmZjRzlzYVdONVgzUnBiV2x1Wnlod2IyeHBZM2xmYVdRNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2RtRnNhV1JoZEdWZmNHOXNhV041WDNScGJXbHVaem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TkRneUxUUTRNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnTHk4Z1pHVm1JSFpoYkdsa1lYUmxYM0J2YkdsamVWOTBhVzFwYm1jb2MyVnNaaXdnY0c5c2FXTjVYMmxrT2lCQlVrTTBWVWx1ZERZMEtTQXRQaUJCVWtNMFZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuTjFjbUZ1WTJVdlkyOXVkSEpoWTNRdWNIazZORGcxQ2lBZ0lDQXZMeUJ3YjJ4cFkzbGZaR0YwWVNBOUlITmxiR1l1Y0c5c2FXTnBaWE11YldGNVltVW9jRzlzYVdONVgybGtMbTVoZEdsMlpTbGJNRjB1WTI5d2VTZ3BDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKMGIya0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luQnZiR2xqYVdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzV6ZFhKaGJtTmxMMk52Ym5SeVlXTjBMbkI1T2pRNE9Bb2dJQ0FnTHk4Z2FXWWdibTkwSUdWNGFYTjBjem9LSUNBZ0lHSnVlaUIyWVd4cFpHRjBaVjl3YjJ4cFkzbGZkR2x0YVc1blgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvME9Ea0tJQ0FnSUM4dklISmxkSFZ5YmlCQlVrTTBWVWx1ZERZMEtEQXBJQ0FqSUZCdmJHbGplU0JrYjJWemJpZDBJR1Y0YVhOMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NuWmhiR2xrWVhSbFgzQnZiR2xqZVY5MGFXMXBibWRmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVjM1Z5WVc1alpTOWpiMjUwY21GamRDNXdlVG8wT1RFS0lDQWdJQzh2SUdsbUlIQnZiR2xqZVY5a1lYUmhMbk5sZEhSc1pXUXVibUYwYVhabElEMDlJRlZKYm5RMk5DZ3hLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCcGJuUmpYek1nTHk4Z09UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUhaaGJHbGtZWFJsWDNCdmJHbGplVjkwYVcxcGJtZGZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1emRYSmhibU5sTDJOdmJuUnlZV04wTG5CNU9qUTVNZ29nSUNBZ0x5OGdjbVYwZFhKdUlFRlNRelJWU1c1ME5qUW9NaWtnSUNNZ1VHOXNhV041SUdGc2NtVmhaSGtnYzJWMGRHeGxaQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDblpoYkdsa1lYUmxYM0J2YkdsamVWOTBhVzFwYm1kZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvME9UUUtJQ0FnSUM4dklHTjFjbkpsYm5SZmNtOTFibVFnUFNCSGJHOWlZV3d1Y205MWJtUUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk5EazFDaUFnSUNBdkx5QnBaaUJqZFhKeVpXNTBYM0p2ZFc1a0lEd2djRzlzYVdONVgyUmhkR0V1ZERBdWJtRjBhWFpsT2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ016UWdMeThnTXpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0E4Q2lBZ0lDQmllaUIyWVd4cFpHRjBaVjl3YjJ4cFkzbGZkR2x0YVc1blgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1YzNWeVlXNWpaUzlqYjI1MGNtRmpkQzV3ZVRvME9UWUtJQ0FnSUM4dklISmxkSFZ5YmlCQlVrTTBWVWx1ZERZMEtETXBJQ0FqSUZCdmJHbGplU0JvWVhOdUozUWdjM1JoY25SbFpDQjVaWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01ETUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3AyWVd4cFpHRjBaVjl3YjJ4cFkzbGZkR2x0YVc1blgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk5EazRDaUFnSUNBdkx5QnBaaUJqZFhKeVpXNTBYM0p2ZFc1a0lENGdjRzlzYVdONVgyUmhkR0V1ZERFdWJtRjBhWFpsT2dvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ05ESWdMeThnTkRJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdQQW9nSUNBZ1lub2dkbUZzYVdSaGRHVmZjRzlzYVdONVgzUnBiV2x1WjE5aFpuUmxjbDlwWmw5bGJITmxRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBibk4xY21GdVkyVXZZMjl1ZEhKaFkzUXVjSGs2TkRrNUNpQWdJQ0F2THlCeVpYUjFjbTRnUVZKRE5GVkpiblEyTkNnMEtTQWdJeUJRYjJ4cFkza2dhR0Z6SUdWNGNHbHlaV1FLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3AyWVd4cFpHRjBaVjl3YjJ4cFkzbGZkR2x0YVc1blgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5OMWNtRnVZMlV2WTI5dWRISmhZM1F1Y0hrNk5UQXhDaUFnSUNBdkx5QnlaWFIxY200Z1FWSkRORlZKYm5RMk5DZ3hLU0FnSXlCUWIyeHBZM2tnYVhNZ1lXTjBhWFpsQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUZBUUJrV3VnSEpnOEVGUjk4ZFFnQUFBQUFBQUFBQUE1dVpYaDBYM0J2YkdsamVWOXBaQWh3YjJ4cFkybGxjd1ZoWkcxcGJnWnZjbUZqYkdVSUFBQUFBQUFBQUFFTmJtVjRkRjlsZG1WdWRGOXBaQWx6ZEdGMGMxOWliM2dRWkdsemNIVjBaVjlqYjI1MGNtRmpkQmRqYjI1MGNtRmpkRjlqY21WaGRHbHZibDl5YjNWdVpBbGxkbVZ1ZEY5c2IyY09jRzlzYVdONVgyTnlaV0YwWldRT2NHOXNhV041WDNObGRIUnNaV1FDQUdJeEdFQUFHaWNFTWdObkp3VXlBMmNuQ1RJRFp5b2laeWNLSTJjbkJ5Sm5NUnRCQUlXQ0VnU0pTbkZ1QkVmWDd6VUVNMmoxVmdTcExta2NCR2NYSWRZRVVQbVNyQVR2a0o4NEJGd1dpYUlFNnczZ0t3US9lUGJqQkt2MjFSb0UraUFDREFUYzR4dStCQm9PSUVnRUZBMGZSd1JGZjNKU0JHRmJzdzhFa25SRzREWWFBSTRTQVc0Qld3Rk1BVHdCRkFEc0FOWUF3QUN0QUpvQWlnQnVBRnNBU3dBN0FDZ0FGUUFDSTBNeEdSUkVNUmhFTmhvQmlBYTJLRXhRc0NKRE1Sa1VSREVZUkRZYUFZZ0dmeWhNVUxBaVF6RVpGRVF4R0VRMkdnR0lCY2tvVEZDd0lrTXhHUlJFTVJoRWlBVzBLRXhRc0NKRE1Sa1VSREVZUklnRmp5aE1VTEFpUXpFWkZFUXhHRVEyR2dHSUJVUW9URkN3SWtNeEdSUkVNUmhFTmhvQk5ob0NOaG9ETmhvRWlBVHRLRXhRc0NKRE1Sa1VSREVZUklnRTFTaE1VTEFpUXpFWkZFUXhHRVEyR2dHSUJFd29URkN3SWtNeEdSUkVNUmhFTmhvQmlBUXNLRXhRc0NKRE1Sa1VSREVZUkRZYUFUWWFBb2dEZFNoTVVMQWlRekVaRkVReEdFUTJHZ0UyR2dLSUFvTW9URkN3SWtNeEdSUkVNUmhFTmhvQk5ob0NOaG9ETmhvRU5ob0ZOaG9HTmhvSE5ob0lpQUlpS0V4UXNDSkRNUmtVUkRFWVJEWWFBVFlhQWpZYUF6WWFCRFlhQlRZYUJqWWFCellhQ0lnQlppaE1VTEFpUXpFWkZFUXhHRVNJQVZBb1RGQ3dJa014R1JSRU1SaEVOaG9CaUFFcklrTXhHUlJFTVJoRU5ob0JpQUJzS0V4UXNDSkRNUmtVUkRFWUZFUTJHZ0dJQUFJaVE0b0JBQ2NFaS85bkp3b3lCbWNuQ0lBb0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBTDhwaS8rQUVnQVFZMjl1ZEhKaFkzUmZZM0psWVhSbFpDbUlBQldKaWdFQk1RQWpKd1JsUkJKRUp3bUwvMmNuQm9tS0JBQXlCaGFML0l2OVVJQUNBRHBRVEZDTC8xQ0wvbEFqSndkbFJFa1dKd3RNVUVtOFNFOEN2eUlJSndkTVo0bUtBd0FqSndpK1JJdjlKd3dTUVFBeGl3RkpJMXNpQ0JaY0FFbUJDRnVML2hjSUZsd0lTWUVZV3lJSUZsd1lTWUVnVzR2L0Z3Z1dYQ0NNQVNjSWl3Ry9pWXY5SncwU2l3R01BRUVBR0lzQlNZRVFXNHYrRndnV1hCQkpnUmhiSWdrV1hCaU1BSXNBakFGQy84K0tBUUF4QUNNbkJHVkVFa1FuQll2L1o0a2pKd1ZsUkltS0NBRXlCSUVDRWtTTCtSZUwraGRLREVTTCt4ZEVpLzhYUkVzQk1nWU5SRXdrQ0ExRUl5cGxSRWtpQ0NwTVp6RUFTU2NPVUl2NVVJdjZVSXY3VUl2OFVJdjlVSXYrVUl2L1VDbFFpL2hRVHdJV0swc0JVRW04U0U4Q3Z5Y01pL3VMLzRqL0YwbExBb0FRQUE1d2IyeHBZM2xmWTNKbFlYUmxaSXY3aVA3TmdBNVFUMHhKUTFsZlExSkZRVlJGUkU4Q1VMQ0ppZ2dCSXlwbFJFa2lDQ3BNWnpFQUp3NVFpL2xRaS9wUWkvdFFpL3hRaS8xUWkvNVFpLzlRS1ZDTCtGQk1GaXRMQVZCSnZFaFBBcitKaWdJQk1RQWpKd1ZsUkJKRWkvNFhGa2tyVEZCSnZraEhBaVZiRkVReUJrc0JnU0piU3dFT1JFeUJLbHNPUkNPQUVnQVFjMlYwZEd4bFpGOXlaV3BsWTNSbFpJdi9GeUlTUVFCVGl3S0JNbHRKakFPQUVnQVFjMlYwZEd4bFpGOWhjSEJ5YjNabFpJd0VRUUF5c1lzQ1Z3QWdnQnBCWjNKcFIzVmhjbVFnU1c1emRYSmhibU5sSUZCaGVXOTFkTElGaXdPeUNMSUhJcklRSVFTeUFiT0xBaWNHWEZxTEFVbThTRXNCdjRzREZpY05Td0VwaVAzNFRGY0FJSXNBVElzRVN3T0kvYnFBRGxCUFRFbERXVjlUUlZSVVRFVkVNUUJRc0l3QWlZb0NBWUFBaS80WE1RQk1Ga2tyVEZDK1FBQUVLWXdBaVlzRFZ3QWdpd0VUUVFBRUtZd0FpWXNESlZ0SmpBQkFBQVFwakFDSk1nYUxBQ0VFQ0E1RUl5Y0paVVF5QXhOQkFDaUFKVU5TVDFOVFgwTlBUbFJTUVVOVVgwUkpVMUJWVkVWa2FYTndkWFJsWDJOeVpXRjBaV1N3aXdLTEFVbE9Bb0FLQUFoa2FYTndkWFJsWkNtSS9SdUFEMFJKVTFCVlZFVmZRMUpGUVZSRlJFeFFzQ2NHakFDSmlnRUJpLzhYRml0TVVMNUlpWW9CQVNPQUFFa2pSd0lxWlVRaWl3YUxCUXhCQUZhTEJoWXJURkJKakFDK1JRR0xCSXdDaXdPTUFVRUFMb3NBdmtoWEFDQ0wveEtMQkl3Q2l3T01BVUVBRm9zRElnaU1BNHNFU1l3Q1FBQUVpd2FNQW9zRGpBRkNBQUNMQW93RWl3R01BNHNHSWdpTUJrTC9vb3NERm9zRUZsQ01BSWtqS21WRUlna1dpWW9FQVl2OEZ5UUtpLzBYZ1FJS0pBaUwvaGNrQ0l2L0Y0RUNDaVFJVHdOUEF3dFBBZ3NMZ2NDRVBRcEpJUVFNUVFBRUlRU01BSXNBRmt5SmlnRUJpLzhYRml0TVVFbStRQUFFS1l3QWlURUFpd0ZYQUNBVFFRQUVLWXdBaVlzQkpWc2lFa0VBQkNtTUFJbUxBTHhJSndhTUFJa2pKd1JsUkNNbkJXVkVJeXBsUkJaT0FsQk1VSWtuQ0w1RWlZb0JBWXYvRnhZbkMweFF2a2hKZ0R3QUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRG9BQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFTUVFCUGdFc0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQURvQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUE5bGRtVnVkRjl1YjNSZlptOTFibVJNaVlzQVRJbUtBUUVqSndkbFJDSUpTWXYvRndraUNFa2lERUVBQXlLTUFZc0FGb3NCRmxDTUFJbUtBUUdBQUl2L0Z4WXJURkMrUUFBRUtZd0FpWXNCSlZzaUVrRUFEWUFJQUFBQUFBQUFBQUtNQUlreUJrbU1BSXNCZ1NKYkRFRUFEWUFJQUFBQUFBQUFBQU9NQUltTEFZRXFXNHNBREVFQURZQUlBQUFBQUFBQUFBU01BSWtuQm93QWlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxMCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
