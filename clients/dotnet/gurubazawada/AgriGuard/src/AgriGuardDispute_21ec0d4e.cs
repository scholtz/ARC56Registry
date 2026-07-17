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

namespace Arc56.Generated.gurubazawada.AgriGuard.AgriGuardDispute_21ec0d4e
{


    //
    // 
    //    Enhanced Dispute Resolution Contract for AgriGuard Insurance with Algorand Features
    //
    //    Features:
    //    - Community-based dispute resolution with enhanced juror management
    //    - Time-based voting deadlines and dispute lifecycle management
    //    - Event logging and statistics tracking
    //    - Cross-contract communication with insurance contract
    //    - Asset-based juror staking system
    //    - Advanced voting mechanisms with reputation-based selection
    //    
    //
    public class AgriGuardDisputeProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgriGuardDisputeProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DisputeData : AVMObjectType
            {
                public ulong PolicyId { get; set; }

                public Algorand.Address Claimant { get; set; }

                public string Reason { get; set; }

                public ulong CreatedAt { get; set; }

                public ulong Status { get; set; }

                public ulong YesVotes { get; set; }

                public ulong NoVotes { get; set; }

                public ulong TotalVotes { get; set; }

                public ulong VotingDeadline { get; set; }

                public ulong ResolutionRound { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPolicyId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPolicyId.From(PolicyId);
                    ret.AddRange(vPolicyId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClaimant = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vClaimant.From(Claimant);
                    ret.AddRange(vClaimant.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReason = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vReason.From(Reason);
                    stringRef[ret.Count] = vReason.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vYesVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vYesVotes.From(YesVotes);
                    ret.AddRange(vYesVotes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNoVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNoVotes.From(NoVotes);
                    ret.AddRange(vNoVotes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalVotes.From(TotalVotes);
                    ret.AddRange(vTotalVotes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotingDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVotingDeadline.From(VotingDeadline);
                    ret.AddRange(vVotingDeadline.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResolutionRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vResolutionRound.From(ResolutionRound);
                    ret.AddRange(vResolutionRound.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DisputeData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new DisputeData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPolicyId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPolicyId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePolicyId = vPolicyId.ToValue();
                    if (valuePolicyId is ulong vPolicyIdValue) { ret.PolicyId = vPolicyIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClaimant = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vClaimant.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueClaimant = vClaimant.ToValue();
                    if (valueClaimant is Algorand.Address vClaimantValue) { ret.Claimant = vClaimantValue; }
                    var indexReason = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReason = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vReason.Decode(bytes.Skip(indexReason + prefixOffset).ToArray());
                    var valueReason = vReason.ToValue();
                    if (valueReason is string vReasonValue) { ret.Reason = vReasonValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vYesVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vYesVotes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueYesVotes = vYesVotes.ToValue();
                    if (valueYesVotes is ulong vYesVotesValue) { ret.YesVotes = vYesVotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNoVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNoVotes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNoVotes = vNoVotes.ToValue();
                    if (valueNoVotes is ulong vNoVotesValue) { ret.NoVotes = vNoVotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalVotes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalVotes = vTotalVotes.ToValue();
                    if (valueTotalVotes is ulong vTotalVotesValue) { ret.TotalVotes = vTotalVotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotingDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVotingDeadline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVotingDeadline = vVotingDeadline.ToValue();
                    if (valueVotingDeadline is ulong vVotingDeadlineValue) { ret.VotingDeadline = vVotingDeadlineValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResolutionRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vResolutionRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueResolutionRound = vResolutionRound.ToValue();
                    if (valueResolutionRound is ulong vResolutionRoundValue) { ret.ResolutionRound = vResolutionRoundValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DisputeData);
                }
                public bool Equals(DisputeData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DisputeData left, DisputeData right)
                {
                    return EqualityComparer<DisputeData>.Default.Equals(left, right);
                }
                public static bool operator !=(DisputeData left, DisputeData right)
                {
                    return !(left == right);
                }

            }

            public class DisputeEvent : AVMObjectType
            {
                public ulong DisputeId { get; set; }

                public string Action { get; set; }

                public Algorand.Address Juror { get; set; }

                public ulong Timestamp { get; set; }

                public ulong VoteValue { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputeId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDisputeId.From(DisputeId);
                    ret.AddRange(vDisputeId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAction = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAction.From(Action);
                    stringRef[ret.Count] = vAction.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vJuror = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vJuror.From(Juror);
                    ret.AddRange(vJuror.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVoteValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVoteValue.From(VoteValue);
                    ret.AddRange(vVoteValue.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DisputeEvent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new DisputeEvent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputeId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDisputeId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDisputeId = vDisputeId.ToValue();
                    if (valueDisputeId is ulong vDisputeIdValue) { ret.DisputeId = vDisputeIdValue; }
                    var indexAction = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAction = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAction.Decode(bytes.Skip(indexAction + prefixOffset).ToArray());
                    var valueAction = vAction.ToValue();
                    if (valueAction is string vActionValue) { ret.Action = vActionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vJuror = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vJuror.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueJuror = vJuror.ToValue();
                    if (valueJuror is Algorand.Address vJurorValue) { ret.Juror = vJurorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVoteValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVoteValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVoteValue = vVoteValue.ToValue();
                    if (valueVoteValue is ulong vVoteValueValue) { ret.VoteValue = vVoteValueValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DisputeEvent);
                }
                public bool Equals(DisputeEvent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DisputeEvent left, DisputeEvent right)
                {
                    return EqualityComparer<DisputeEvent>.Default.Equals(left, right);
                }
                public static bool operator !=(DisputeEvent left, DisputeEvent right)
                {
                    return !(left == right);
                }

            }

            public class DisputeStats : AVMObjectType
            {
                public ulong TotalDisputes { get; set; }

                public ulong ResolvedDisputes { get; set; }

                public ulong RejectedDisputes { get; set; }

                public ulong TotalVotesCast { get; set; }

                public ulong ActiveJurors { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalDisputes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalDisputes.From(TotalDisputes);
                    ret.AddRange(vTotalDisputes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResolvedDisputes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vResolvedDisputes.From(ResolvedDisputes);
                    ret.AddRange(vResolvedDisputes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRejectedDisputes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRejectedDisputes.From(RejectedDisputes);
                    ret.AddRange(vRejectedDisputes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalVotesCast = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalVotesCast.From(TotalVotesCast);
                    ret.AddRange(vTotalVotesCast.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActiveJurors = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vActiveJurors.From(ActiveJurors);
                    ret.AddRange(vActiveJurors.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DisputeStats Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new DisputeStats();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalDisputes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalDisputes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalDisputes = vTotalDisputes.ToValue();
                    if (valueTotalDisputes is ulong vTotalDisputesValue) { ret.TotalDisputes = vTotalDisputesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResolvedDisputes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vResolvedDisputes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueResolvedDisputes = vResolvedDisputes.ToValue();
                    if (valueResolvedDisputes is ulong vResolvedDisputesValue) { ret.ResolvedDisputes = vResolvedDisputesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRejectedDisputes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRejectedDisputes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRejectedDisputes = vRejectedDisputes.ToValue();
                    if (valueRejectedDisputes is ulong vRejectedDisputesValue) { ret.RejectedDisputes = vRejectedDisputesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalVotesCast = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalVotesCast.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalVotesCast = vTotalVotesCast.ToValue();
                    if (valueTotalVotesCast is ulong vTotalVotesCastValue) { ret.TotalVotesCast = vTotalVotesCastValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActiveJurors = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vActiveJurors.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActiveJurors = vActiveJurors.ToValue();
                    if (valueActiveJurors is ulong vActiveJurorsValue) { ret.ActiveJurors = vActiveJurorsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DisputeStats);
                }
                public bool Equals(DisputeStats? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DisputeStats left, DisputeStats right)
                {
                    return EqualityComparer<DisputeStats>.Default.Equals(left, right);
                }
                public static bool operator !=(DisputeStats left, DisputeStats right)
                {
                    return !(left == right);
                }

            }

            public class JurorData : AVMObjectType
            {
                public Algorand.Address Address { get; set; }

                public ulong Reputation { get; set; }

                public ulong TotalVotes { get; set; }

                public ulong CorrectVotes { get; set; }

                public ulong RegistrationRound { get; set; }

                public ulong LastVoteRound { get; set; }

                public ulong StakedAmount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAddress.From(Address);
                    ret.AddRange(vAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReputation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vReputation.From(Reputation);
                    ret.AddRange(vReputation.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalVotes.From(TotalVotes);
                    ret.AddRange(vTotalVotes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCorrectVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCorrectVotes.From(CorrectVotes);
                    ret.AddRange(vCorrectVotes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegistrationRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRegistrationRound.From(RegistrationRound);
                    ret.AddRange(vRegistrationRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastVoteRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastVoteRound.From(LastVoteRound);
                    ret.AddRange(vLastVoteRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStakedAmount.From(StakedAmount);
                    ret.AddRange(vStakedAmount.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static JurorData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new JurorData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddress = vAddress.ToValue();
                    if (valueAddress is Algorand.Address vAddressValue) { ret.Address = vAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReputation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vReputation.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReputation = vReputation.ToValue();
                    if (valueReputation is ulong vReputationValue) { ret.Reputation = vReputationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalVotes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalVotes = vTotalVotes.ToValue();
                    if (valueTotalVotes is ulong vTotalVotesValue) { ret.TotalVotes = vTotalVotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCorrectVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCorrectVotes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCorrectVotes = vCorrectVotes.ToValue();
                    if (valueCorrectVotes is ulong vCorrectVotesValue) { ret.CorrectVotes = vCorrectVotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegistrationRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRegistrationRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegistrationRound = vRegistrationRound.ToValue();
                    if (valueRegistrationRound is ulong vRegistrationRoundValue) { ret.RegistrationRound = vRegistrationRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastVoteRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastVoteRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastVoteRound = vLastVoteRound.ToValue();
                    if (valueLastVoteRound is ulong vLastVoteRoundValue) { ret.LastVoteRound = vLastVoteRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStakedAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStakedAmount = vStakedAmount.ToValue();
                    if (valueStakedAmount is ulong vStakedAmountValue) { ret.StakedAmount = vStakedAmountValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as JurorData);
                }
                public bool Equals(JurorData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(JurorData left, JurorData right)
                {
                    return EqualityComparer<JurorData>.Default.Equals(left, right);
                }
                public static bool operator !=(JurorData left, JurorData right)
                {
                    return !(left == right);
                }

            }

            public class VoteData : AVMObjectType
            {
                public Algorand.Address Juror { get; set; }

                public ulong Vote { get; set; }

                public ulong Timestamp { get; set; }

                public ulong DisputeId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vJuror = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vJuror.From(Juror);
                    ret.AddRange(vJuror.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVote = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVote.From(Vote);
                    ret.AddRange(vVote.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputeId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDisputeId.From(DisputeId);
                    ret.AddRange(vDisputeId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VoteData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new VoteData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vJuror = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vJuror.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueJuror = vJuror.ToValue();
                    if (valueJuror is Algorand.Address vJurorValue) { ret.Juror = vJurorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVote = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVote.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVote = vVote.ToValue();
                    if (valueVote is ulong vVoteValue) { ret.Vote = vVoteValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputeId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDisputeId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDisputeId = vDisputeId.ToValue();
                    if (valueDisputeId is ulong vDisputeIdValue) { ret.DisputeId = vDisputeIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VoteData);
                }
                public bool Equals(VoteData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VoteData left, VoteData right)
                {
                    return EqualityComparer<VoteData>.Default.Equals(left, right);
                }
                public static bool operator !=(VoteData left, VoteData right)
                {
                    return !(left == right);
                }

            }

            public class GetRecentEventsReturn : AVMObjectType
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

                public static GetRecentEventsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetRecentEventsReturn();
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
                    return Equals(obj as GetRecentEventsReturn);
                }
                public bool Equals(GetRecentEventsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetRecentEventsReturn left, GetRecentEventsReturn right)
                {
                    return EqualityComparer<GetRecentEventsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetRecentEventsReturn left, GetRecentEventsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the dispute contract with enhanced features
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
        ///Set the main insurance contract address (admin only)
        ///</summary>
        /// <param name="contract_address"> </param>
        public async Task<ulong> SetInsuranceContract(Algorand.Address contract_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 245, 227, 252 };
            var contract_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); contract_addressAbi.From(contract_address);

            var result = await base.CallApp(new List<object> { abiHandle, contract_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SetInsuranceContract_Transactions(Algorand.Address contract_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 245, 227, 252 };
            var contract_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); contract_addressAbi.From(contract_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, contract_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Enhanced juror registration with staking requirement
        ///</summary>
        public async Task<ulong> RegisterJuror(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 186, 2, 58 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegisterJuror_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 186, 2, 58 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Enhanced dispute creation with advanced juror selection and timing
        ///</summary>
        /// <param name="policy_id"> </param>
        public async Task<ulong> CreateDispute(ulong policy_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 53, 205, 253 };
            var policy_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_idAbi.From(policy_id);

            var result = await base.CallApp(new List<object> { abiHandle, policy_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateDispute_Transactions(ulong policy_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 53, 205, 253 };
            var policy_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_idAbi.From(policy_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, policy_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Enhanced voting system with time validation and reputation tracking
        ///</summary>
        /// <param name="dispute_id"> </param>
        /// <param name="vote"> </param>
        public async Task<ulong> VoteOnDispute(ulong dispute_id, ulong vote, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 165, 45, 5 };
            var dispute_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dispute_idAbi.From(dispute_id);
            var voteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); voteAbi.From(vote);

            var result = await base.CallApp(new List<object> { abiHandle, dispute_idAbi, voteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VoteOnDispute_Transactions(ulong dispute_id, ulong vote, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 165, 45, 5 };
            var dispute_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dispute_idAbi.From(dispute_id);
            var voteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); voteAbi.From(vote);

            return await base.MakeTransactionList(new List<object> { abiHandle, dispute_idAbi, voteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get dispute information
        ///</summary>
        /// <param name="dispute_id"> </param>
        public async Task<Structs.DisputeData> GetDispute(ulong dispute_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 120, 181, 80 };
            var dispute_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dispute_idAbi.From(dispute_id);

            var result = await base.SimApp(new List<object> { abiHandle, dispute_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.DisputeData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetDispute_Transactions(ulong dispute_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 120, 181, 80 };
            var dispute_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dispute_idAbi.From(dispute_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, dispute_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get juror information
        ///</summary>
        /// <param name="juror_address"> </param>
        public async Task<Structs.JurorData> GetJurorInfo(Algorand.Address juror_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 120, 135, 227 };
            var juror_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); juror_addressAbi.From(juror_address);

            var result = await base.SimApp(new List<object> { abiHandle, juror_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.JurorData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetJurorInfo_Transactions(Algorand.Address juror_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 120, 135, 227 };
            var juror_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); juror_addressAbi.From(juror_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, juror_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total number of registered jurors
        ///</summary>
        public async Task<ulong> GetTotalJurors(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 39, 59, 56 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalJurors_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 39, 59, 56 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get comprehensive dispute resolution statistics
        ///</summary>
        public async Task<Structs.DisputeStats> GetStatistics(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
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
            return Structs.DisputeStats.Parse(lastLogBytes.Skip(4).ToArray());

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
        public async Task<Structs.DisputeEvent> GetEvent(ulong event_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 171, 152, 123 };
            var event_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); event_idAbi.From(event_id);

            var result = await base.SimApp(new List<object> { abiHandle, event_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.DisputeEvent.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetEvent_Transactions(ulong event_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 171, 152, 123 };
            var event_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); event_idAbi.From(event_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, event_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get recent events (returns count and starting event ID)
        ///</summary>
        /// <param name="limit"> </param>
        public async Task<Structs.GetRecentEventsReturn> GetRecentEvents(ulong limit, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
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
            return Structs.GetRecentEventsReturn.Parse(lastLogBytes.Skip(4).ToArray());

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
        ///Get enhanced dispute status with time-based information
        ///</summary>
        /// <param name="dispute_id"> </param>
        public async Task<ulong> GetDisputeStatus(ulong dispute_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 13, 217, 251 };
            var dispute_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dispute_idAbi.From(dispute_id);

            var result = await base.SimApp(new List<object> { abiHandle, dispute_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetDisputeStatus_Transactions(ulong dispute_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 13, 217, 251 };
            var dispute_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dispute_idAbi.From(dispute_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, dispute_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get count of active disputes and total disputes
        ///</summary>
        public async Task<Structs.GetRecentEventsReturn> GetActiveDisputes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 123, 158, 155 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetRecentEventsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetActiveDisputes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 123, 158, 155 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Validate juror eligibility and return status code
        ///</summary>
        /// <param name="juror_address"> </param>
        public async Task<ulong> ValidateJurorEligibility(Algorand.Address juror_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 41, 33, 184 };
            var juror_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); juror_addressAbi.From(juror_address);

            var result = await base.SimApp(new List<object> { abiHandle, juror_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ValidateJurorEligibility_Transactions(Algorand.Address juror_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 41, 33, 184 };
            var juror_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); juror_addressAbi.From(juror_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, juror_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get all disputes assigned to a specific juror
        ///</summary>
        /// <param name="juror_address"> </param>
        public async Task<byte[]> GetJurorAssignedDisputes(Algorand.Address juror_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 180, 38, 131 };
            var juror_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); juror_addressAbi.From(juror_address);

            var result = await base.SimApp(new List<object> { abiHandle, juror_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetJurorAssignedDisputes_Transactions(Algorand.Address juror_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 180, 38, 131 };
            var juror_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); juror_addressAbi.From(juror_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, juror_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if a juror is assigned to vote on a specific dispute
        ///</summary>
        /// <param name="juror_address"> </param>
        /// <param name="dispute_id"> </param>
        public async Task<ulong> IsJurorAssignedToDispute(Algorand.Address juror_address, ulong dispute_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 34, 58, 131 };
            var juror_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); juror_addressAbi.From(juror_address);
            var dispute_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dispute_idAbi.From(dispute_id);

            var result = await base.SimApp(new List<object> { abiHandle, juror_addressAbi, dispute_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsJurorAssignedToDispute_Transactions(Algorand.Address juror_address, ulong dispute_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 34, 58, 131 };
            var juror_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); juror_addressAbi.From(juror_address);
            var dispute_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dispute_idAbi.From(dispute_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, juror_addressAbi, dispute_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mark a dispute as processed/deleted (admin only)
        ///</summary>
        /// <param name="dispute_id"> </param>
        public async Task<ulong> MarkDisputeProcessed(ulong dispute_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 201, 103, 32 };
            var dispute_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dispute_idAbi.From(dispute_id);

            var result = await base.CallApp(new List<object> { abiHandle, dispute_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MarkDisputeProcessed_Transactions(ulong dispute_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 201, 103, 32 };
            var dispute_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dispute_idAbi.From(dispute_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, dispute_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Trigger policy processing in the insurance contract via inner transaction
        ///</summary>
        /// <param name="policy_id"> </param>
        public async Task<ulong> TriggerPolicyProcessing(ulong policy_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 189, 9, 150 };
            var policy_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policy_idAbi.From(policy_id);

            var result = await base.CallApp(new List<object> { abiHandle, policy_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TriggerPolicyProcessing_Transactions(ulong policy_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 189, 9, 150 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdyaUd1YXJkRGlzcHV0ZSIsImRlc2MiOiJcbiAgICBFbmhhbmNlZCBEaXNwdXRlIFJlc29sdXRpb24gQ29udHJhY3QgZm9yIEFncmlHdWFyZCBJbnN1cmFuY2Ugd2l0aCBBbGdvcmFuZCBGZWF0dXJlc1xuXG4gICAgRmVhdHVyZXM6XG4gICAgLSBDb21tdW5pdHktYmFzZWQgZGlzcHV0ZSByZXNvbHV0aW9uIHdpdGggZW5oYW5jZWQganVyb3IgbWFuYWdlbWVudFxuICAgIC0gVGltZS1iYXNlZCB2b3RpbmcgZGVhZGxpbmVzIGFuZCBkaXNwdXRlIGxpZmVjeWNsZSBtYW5hZ2VtZW50XG4gICAgLSBFdmVudCBsb2dnaW5nIGFuZCBzdGF0aXN0aWNzIHRyYWNraW5nXG4gICAgLSBDcm9zcy1jb250cmFjdCBjb21tdW5pY2F0aW9uIHdpdGggaW5zdXJhbmNlIGNvbnRyYWN0XG4gICAgLSBBc3NldC1iYXNlZCBqdXJvciBzdGFraW5nIHN5c3RlbVxuICAgIC0gQWR2YW5jZWQgdm90aW5nIG1lY2hhbmlzbXMgd2l0aCByZXB1dGF0aW9uLWJhc2VkIHNlbGVjdGlvblxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJEaXNwdXRlRGF0YSI6W3sibmFtZSI6InBvbGljeV9pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjbGFpbWFudCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicmVhc29uIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImNyZWF0ZWRfYXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3RhdHVzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Inllc192b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJub192b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbF92b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2b3RpbmdfZGVhZGxpbmUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmVzb2x1dGlvbl9yb3VuZCIsInR5cGUiOiJ1aW50NjQifV0sIkRpc3B1dGVFdmVudCI6W3sibmFtZSI6ImRpc3B1dGVfaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWN0aW9uIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6Imp1cm9yIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJ0aW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidm90ZV92YWx1ZSIsInR5cGUiOiJ1aW50NjQifV0sIkRpc3B1dGVTdGF0cyI6W3sibmFtZSI6InRvdGFsX2Rpc3B1dGVzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlc29sdmVkX2Rpc3B1dGVzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlamVjdGVkX2Rpc3B1dGVzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRvdGFsX3ZvdGVzX2Nhc3QiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWN0aXZlX2p1cm9ycyIsInR5cGUiOiJ1aW50NjQifV0sIkp1cm9yRGF0YSI6W3sibmFtZSI6ImFkZHJlc3MiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InJlcHV0YXRpb24iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfdm90ZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY29ycmVjdF92b3RlcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWdpc3RyYXRpb25fcm91bmQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGFzdF92b3RlX3JvdW5kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YWtlZF9hbW91bnQiLCJ0eXBlIjoidWludDY0In1dLCJWb3RlRGF0YSI6W3sibmFtZSI6Imp1cm9yIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJ2b3RlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkaXNwdXRlX2lkIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0UmVjZW50RXZlbnRzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX2FwcGxpY2F0aW9uIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIGRpc3B1dGUgY29udHJhY3Qgd2l0aCBlbmhhbmNlZCBmZWF0dXJlcyIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRtaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2luc3VyYW5jZV9jb250cmFjdCIsImRlc2MiOiJTZXQgdGhlIG1haW4gaW5zdXJhbmNlIGNvbnRyYWN0IGFkZHJlc3MgKGFkbWluIG9ubHkpIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb250cmFjdF9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXJfanVyb3IiLCJkZXNjIjoiRW5oYW5jZWQganVyb3IgcmVnaXN0cmF0aW9uIHdpdGggc3Rha2luZyByZXF1aXJlbWVudCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZV9kaXNwdXRlIiwiZGVzYyI6IkVuaGFuY2VkIGRpc3B1dGUgY3JlYXRpb24gd2l0aCBhZHZhbmNlZCBqdXJvciBzZWxlY3Rpb24gYW5kIHRpbWluZyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb2xpY3lfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2b3RlX29uX2Rpc3B1dGUiLCJkZXNjIjoiRW5oYW5jZWQgdm90aW5nIHN5c3RlbSB3aXRoIHRpbWUgdmFsaWRhdGlvbiBhbmQgcmVwdXRhdGlvbiB0cmFja2luZyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkaXNwdXRlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3RlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2Rpc3B1dGUiLCJkZXNjIjoiR2V0IGRpc3B1dGUgaW5mb3JtYXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGlzcHV0ZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3Msc3RyaW5nLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJEaXNwdXRlRGF0YSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2p1cm9yX2luZm8iLCJkZXNjIjoiR2V0IGp1cm9yIGluZm9ybWF0aW9uIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJqdXJvcl9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6Ikp1cm9yRGF0YSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3RvdGFsX2p1cm9ycyIsImRlc2MiOiJHZXQgdG90YWwgbnVtYmVyIG9mIHJlZ2lzdGVyZWQganVyb3JzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfc3RhdGlzdGljcyIsImRlc2MiOiJHZXQgY29tcHJlaGVuc2l2ZSBkaXNwdXRlIHJlc29sdXRpb24gc3RhdGlzdGljcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJEaXNwdXRlU3RhdHMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ldmVudCIsImRlc2MiOiJHZXQgYSBzcGVjaWZpYyBldmVudCBieSBJRCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldmVudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHN0cmluZyxhZGRyZXNzLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiRGlzcHV0ZUV2ZW50IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcmVjZW50X2V2ZW50cyIsImRlc2MiOiJHZXQgcmVjZW50IGV2ZW50cyAocmV0dXJucyBjb3VudCBhbmQgc3RhcnRpbmcgZXZlbnQgSUQpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxpbWl0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFJlY2VudEV2ZW50c1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2Rpc3B1dGVfc3RhdHVzIiwiZGVzYyI6IkdldCBlbmhhbmNlZCBkaXNwdXRlIHN0YXR1cyB3aXRoIHRpbWUtYmFzZWQgaW5mb3JtYXRpb24iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGlzcHV0ZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FjdGl2ZV9kaXNwdXRlcyIsImRlc2MiOiJHZXQgY291bnQgb2YgYWN0aXZlIGRpc3B1dGVzIGFuZCB0b3RhbCBkaXNwdXRlcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRSZWNlbnRFdmVudHNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlX2p1cm9yX2VsaWdpYmlsaXR5IiwiZGVzYyI6IlZhbGlkYXRlIGp1cm9yIGVsaWdpYmlsaXR5IGFuZCByZXR1cm4gc3RhdHVzIGNvZGUiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imp1cm9yX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9qdXJvcl9hc3NpZ25lZF9kaXNwdXRlcyIsImRlc2MiOiJHZXQgYWxsIGRpc3B1dGVzIGFzc2lnbmVkIHRvIGEgc3BlY2lmaWMganVyb3IiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imp1cm9yX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX2p1cm9yX2Fzc2lnbmVkX3RvX2Rpc3B1dGUiLCJkZXNjIjoiQ2hlY2sgaWYgYSBqdXJvciBpcyBhc3NpZ25lZCB0byB2b3RlIG9uIGEgc3BlY2lmaWMgZGlzcHV0ZSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoianVyb3JfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGlzcHV0ZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFya19kaXNwdXRlX3Byb2Nlc3NlZCIsImRlc2MiOiJNYXJrIGEgZGlzcHV0ZSBhcyBwcm9jZXNzZWQvZGVsZXRlZCAoYWRtaW4gb25seSkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGlzcHV0ZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyaWdnZXJfcG9saWN5X3Byb2Nlc3NpbmciLCJkZXNjIjoiVHJpZ2dlciBwb2xpY3kgcHJvY2Vzc2luZyBpbiB0aGUgaW5zdXJhbmNlIGNvbnRyYWN0IHZpYSBpbm5lciB0cmFuc2FjdGlvbiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb2xpY3lfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NiwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEyMDFdLCJlcnJvck1lc3NhZ2UiOiJDb250cmFjdCBpbml0aWFsaXphdGlvbiBwZXJpb2Qgbm90IGNvbXBsZXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM0MV0sImVycm9yTWVzc2FnZSI6IkNvbnRyYWN0IG5vdCBmdWxseSBvcGVyYXRpb25hbCB5ZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDczLDI0NzRdLCJlcnJvck1lc3NhZ2UiOiJJbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MjFdLCJlcnJvck1lc3NhZ2UiOiJJbnN1cmFuY2UgY29udHJhY3Qgbm90IHNldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2ODddLCJlcnJvck1lc3NhZ2UiOiJKdXJvciB2b3RlZCB0b28gcmVjZW50bHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzEsNTUwLDU2OSw1OTEsNjE4LDYzNyw2NTMsNjcyLDY5MSw3MTAsNzI2LDc0Miw3NjEsNzgwLDgwMiw4MjEsODM3LDg1Nl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNjBdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjcwOF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIG1hcmsgZGlzcHV0ZXMgYXMgcHJvY2Vzc2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODYwXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM0LDU1Myw1NzIsNTk0LDYyMSw2NDAsNjU2LDY3NSw2OTQsNzEzLDcyOSw3NDUsNzY0LDc4Myw4MDUsODI0LDg0MF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTU2LDI3MDQsMjc0OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE5NSwxMzM1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb250cmFjdF9jcmVhdGlvbl9yb3VuZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODkyLDI4MTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmluc3VyYW5jZV9jb250cmFjdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjA3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5taW5fc3Rha2VfYW1vdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNDYsMjQ5MywyNjExXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5uZXh0X2Rpc3B1dGVfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTgzLDI0MDNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm5leHRfZXZlbnRfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxMCwyMjMxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zdGF0c19ib3ggZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI0MywxNDM4LDE0NTAsMTU2OCwyMjI1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9qdXJvcnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudm90aW5nX2R1cmF0aW9uX3JvdW5kcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHbHpjSFYwWlM1amIyNTBjbUZqZEM1QlozSnBSM1ZoY21SRWFYTndkWFJsTGw5ZllXeG5iM0I1WDJWdWRISjVjRzlwYm5SZmQybDBhRjlwYm1sMEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURFZ01DQTFNQ0F4TUFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURBd01EQXdNREF3TURBd01EQXdNREFnTUhneE5URm1OMk0zTlNBd2VEQXdNREF3TURBd01EQXdNREF3TURFZ0luUnZkR0ZzWDJwMWNtOXljeUlnSW1ScGMzQjFkR1Z6SWlBaVlXUnRhVzRpSUNKdVpYaDBYMlJwYzNCMWRHVmZhV1FpSUNKcWRYSnZjbk1pSUNKcGJuTjFjbUZ1WTJWZlkyOXVkSEpoWTNRaUlDSmpiMjUwY21GamRGOWpjbVZoZEdsdmJsOXliM1Z1WkNJZ0ltNWxlSFJmWlhabGJuUmZhV1FpSUNKemRHRjBjMTlpYjNnaUlDSnFkWEp2Y2w5a2FYTndkWFJsY3lJZ01IZ3dNREF3TURBd01EQXdNREF3TURBeklDSjJiM1JwYm1kZlpIVnlZWFJwYjI1ZmNtOTFibVJ6SWlBaWJXbHVYM04wWVd0bFgyRnRiM1Z1ZENJZ0ltVjJaVzUwWDJ4dlp5SWdJbVJwYzNCMWRHVmZZM0psWVhSbFpDSWdJbVJwYzNCMWRHVmZjbVZ6YjJ4MlpXUWlJQ0prYVhOd2RYUmxYM0psYW1WamRHVmtJaUFpWkdsemNIVjBaVjl3Y205alpYTnpaV1FpSUNKMmIzUmxYMk5oYzNRaUlDSnFkWEp2Y2w5eVpXZHBjM1JsY21Wa0lpQXdlRFkwTmprM016Y3dOelUzTkRZMUlEQjRNREF3TURBd01EQXdNREF3TURBd01pQXdlRFl4TnpNM016WTVOamMyWlRZMU5qUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2prNUxURXdNQW9nSUNBZ0x5OGdJeUJIYkc5aVlXd2djM1JoZEdVS0lDQWdJQzh2SUhObGJHWXVZV1J0YVc0Z1BTQkJaR1J5WlhOektDa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNVEF4Q2lBZ0lDQXZMeUJ6Wld4bUxtbHVjM1Z5WVc1alpWOWpiMjUwY21GamRDQTlJRUZrWkhKbGMzTW9LUW9nSUNBZ1lubDBaV01nT0NBdkx5QWlhVzV6ZFhKaGJtTmxYMk52Ym5SeVlXTjBJZ29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk1UQXlDaUFnSUNBdkx5QnpaV3htTG01bGVIUmZaR2x6Y0hWMFpWOXBaQ0E5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpYm1WNGRGOWthWE53ZFhSbFgybGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3hNRE1LSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYW5WeWIzSnpJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYjNSaGJGOXFkWEp2Y25NaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pFd05Bb2dJQ0FnTHk4Z2MyVnNaaTVqYjI1MGNtRmpkRjlqY21WaGRHbHZibDl5YjNWdVpDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nT1NBdkx5QWlZMjl1ZEhKaFkzUmZZM0psWVhScGIyNWZjbTkxYm1RaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pFd05Rb2dJQ0FnTHk4Z2MyVnNaaTUyYjNScGJtZGZaSFZ5WVhScGIyNWZjbTkxYm1SeklEMGdWVWx1ZERZMEtERXdNREFwSUNBaklFUmxabUYxYkhRZ2RtOTBhVzVuSUhCbGNtbHZaRG9nZmpNdE5DQmtZWGx6Q2lBZ0lDQmllWFJsWXlBeE5DQXZMeUFpZG05MGFXNW5YMlIxY21GMGFXOXVYM0p2ZFc1a2N5SUtJQ0FnSUhCMWMyaHBiblFnTVRBd01DQXZMeUF4TURBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk1UQTJDaUFnSUNBdkx5QnpaV3htTG0xcGJsOXpkR0ZyWlY5aGJXOTFiblFnUFNCVlNXNTBOalFvTVRBd01EQXdNQ2tnSUNNZ01TQkJURWRQSUcxcGJtbHRkVzBnYzNSaGEyVUtJQ0FnSUdKNWRHVmpJREUxSUM4dklDSnRhVzVmYzNSaGEyVmZZVzF2ZFc1MElnb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01EQXdJQzh2SURFd01EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG94TVRnS0lDQWdJQzh2SUhObGJHWXVibVY0ZEY5bGRtVnVkRjlwWkNBOUlGVkpiblEyTkNneEtRb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0ltNWxlSFJmWlhabGJuUmZhV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklHTnNZWE56SUVGbmNtbEhkV0Z5WkVScGMzQjFkR1VvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNak1LSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGc0T1RSaE56RTJaU0F3ZURVMlpqVmxNMlpqSURCNFptTmlZVEF5TTJFZ01IZ3hNek0xWTJSbVpDQXdlR0kwWVRVeVpEQTFJREI0WkdRM09HSTFOVEFnTUhoall6YzRPRGRsTXlBd2VEZGxNamN6WWpNNElEQjRNVFF3WkRGbU5EY2dNSGhpWldGaU9UZzNZaUF3ZURZeE5XSmlNekJtSURCNE0yVXdaR1E1Wm1JZ01IaGpZemRpT1dVNVlpQXdlRFEwTWpreU1XSTRJREI0WVRsaU5ESTJPRE1nTUhneVlqSXlNMkU0TXlBd2VERXpZemsyTnpJd0lEQjRPV05pWkRBNU9UWWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVmZZWEJ3YkdsallYUnBiMjRvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJmYVc1emRYSmhibU5sWDJOdmJuUnlZV04wS0dGa1pISmxjM01wZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p5WldkcGMzUmxjbDlxZFhKdmNpZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSmpjbVZoZEdWZlpHbHpjSFYwWlNoMWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0oyYjNSbFgyOXVYMlJwYzNCMWRHVW9kV2x1ZERZMExIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOWthWE53ZFhSbEtIVnBiblEyTkNrb2RXbHVkRFkwTEdGa1pISmxjM01zYzNSeWFXNW5MSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltZGxkRjlxZFhKdmNsOXBibVp2S0dGa1pISmxjM01wS0dGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0puWlhSZmRHOTBZV3hmYW5WeWIzSnpLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5emRHRjBhWE4wYVdOektDa29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEY5bGRtVnVkQ2gxYVc1ME5qUXBLSFZwYm5RMk5DeHpkSEpwYm1jc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWjJWMFgzSmxZMlZ1ZEY5bGRtVnVkSE1vZFdsdWREWTBLU2gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwWDJScGMzQjFkR1ZmYzNSaGRIVnpLSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjloWTNScGRtVmZaR2x6Y0hWMFpYTW9LU2gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlkbUZzYVdSaGRHVmZhblZ5YjNKZlpXeHBaMmxpYVd4cGRIa29ZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjlxZFhKdmNsOWhjM05wWjI1bFpGOWthWE53ZFhSbGN5aGhaR1J5WlhOektXSjVkR1ZiWFNJc0lHMWxkR2h2WkNBaWFYTmZhblZ5YjNKZllYTnphV2R1WldSZmRHOWZaR2x6Y0hWMFpTaGhaR1J5WlhOekxIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW0xaGNtdGZaR2x6Y0hWMFpWOXdjbTlqWlhOelpXUW9kV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWRISnBaMmRsY2w5d2IyeHBZM2xmY0hKdlkyVnpjMmx1WnloMWFXNTBOalFwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWZllYQndiR2xqWVhScGIyNWZjbTkxZEdWQU5TQnRZV2x1WDNObGRGOXBibk4xY21GdVkyVmZZMjl1ZEhKaFkzUmZjbTkxZEdWQU5pQnRZV2x1WDNKbFoybHpkR1Z5WDJwMWNtOXlYM0p2ZFhSbFFEY2diV0ZwYmw5amNtVmhkR1ZmWkdsemNIVjBaVjl5YjNWMFpVQTRJRzFoYVc1ZmRtOTBaVjl2Ymw5a2FYTndkWFJsWDNKdmRYUmxRRGtnYldGcGJsOW5aWFJmWkdsemNIVjBaVjl5YjNWMFpVQXhNQ0J0WVdsdVgyZGxkRjlxZFhKdmNsOXBibVp2WDNKdmRYUmxRREV4SUcxaGFXNWZaMlYwWDNSdmRHRnNYMnAxY205eWMxOXliM1YwWlVBeE1pQnRZV2x1WDJkbGRGOXpkR0YwYVhOMGFXTnpYM0p2ZFhSbFFERXpJRzFoYVc1ZloyVjBYMlYyWlc1MFgzSnZkWFJsUURFMElHMWhhVzVmWjJWMFgzSmxZMlZ1ZEY5bGRtVnVkSE5mY205MWRHVkFNVFVnYldGcGJsOW5aWFJmWkdsemNIVjBaVjl6ZEdGMGRYTmZjbTkxZEdWQU1UWWdiV0ZwYmw5blpYUmZZV04wYVhabFgyUnBjM0IxZEdWelgzSnZkWFJsUURFM0lHMWhhVzVmZG1Gc2FXUmhkR1ZmYW5WeWIzSmZaV3hwWjJsaWFXeHBkSGxmY205MWRHVkFNVGdnYldGcGJsOW5aWFJmYW5WeWIzSmZZWE56YVdkdVpXUmZaR2x6Y0hWMFpYTmZjbTkxZEdWQU1Ua2diV0ZwYmw5cGMxOXFkWEp2Y2w5aGMzTnBaMjVsWkY5MGIxOWthWE53ZFhSbFgzSnZkWFJsUURJd0lHMWhhVzVmYldGeWExOWthWE53ZFhSbFgzQnliMk5sYzNObFpGOXliM1YwWlVBeU1TQnRZV2x1WDNSeWFXZG5aWEpmY0c5c2FXTjVYM0J5YjJObGMzTnBibWRmY205MWRHVkFNaklLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qZzFDaUFnSUNBdkx5QmpiR0Z6Y3lCQlozSnBSM1ZoY21SRWFYTndkWFJsS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUnlhV2RuWlhKZmNHOXNhV041WDNCeWIyTmxjM05wYm1kZmNtOTFkR1ZBTWpJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvMk1UY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklHTnNZWE56SUVGbmNtbEhkV0Z5WkVScGMzQjFkR1VvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qWXhOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCMGNtbG5aMlZ5WDNCdmJHbGplVjl3Y205alpYTnphVzVuQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMjFoY210ZlpHbHpjSFYwWlY5d2NtOWpaWE56WldSZmNtOTFkR1ZBTWpFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvMU9UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklHTnNZWE56SUVGbmNtbEhkV0Z5WkVScGMzQjFkR1VvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qVTVNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCdFlYSnJYMlJwYzNCMWRHVmZjSEp2WTJWemMyVmtDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgybHpYMnAxY205eVgyRnpjMmxuYm1Wa1gzUnZYMlJwYzNCMWRHVmZjbTkxZEdWQU1qQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzFPRElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklHTnNZWE56SUVGbmNtbEhkV0Z5WkVScGMzQjFkR1VvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qVTRNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWTJGc2JITjFZaUJwYzE5cWRYSnZjbDloYzNOcFoyNWxaRjkwYjE5a2FYTndkWFJsQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5cWRYSnZjbDloYzNOcFoyNWxaRjlrYVhOd2RYUmxjMTl5YjNWMFpVQXhPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalUyTlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzROUW9nSUNBZ0x5OGdZMnhoYzNNZ1FXZHlhVWQxWVhKa1JHbHpjSFYwWlNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZOVFkxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCallXeHNjM1ZpSUdkbGRGOXFkWEp2Y2w5aGMzTnBaMjVsWkY5a2FYTndkWFJsY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkbUZzYVdSaGRHVmZhblZ5YjNKZlpXeHBaMmxpYVd4cGRIbGZjbTkxZEdWQU1UZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzFORFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklHTnNZWE56SUVGbmNtbEhkV0Z5WkVScGMzQjFkR1VvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qVTBOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWTJGc2JITjFZaUIyWVd4cFpHRjBaVjlxZFhKdmNsOWxiR2xuYVdKcGJHbDBlUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmWVdOMGFYWmxYMlJwYzNCMWRHVnpYM0p2ZFhSbFFERTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZOVE14Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgyRmpkR2wyWlY5a2FYTndkWFJsY3dvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZlpHbHpjSFYwWlY5emRHRjBkWE5mY205MWRHVkFNVFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG8xTVRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZPRFVLSUNBZ0lDOHZJR05zWVhOeklFRm5jbWxIZFdGeVpFUnBjM0IxZEdVb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalV4TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZaR2x6Y0hWMFpWOXpkR0YwZFhNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgzSmxZMlZ1ZEY5bGRtVnVkSE5mY205MWRHVkFNVFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG8xTURNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZPRFVLSUNBZ0lDOHZJR05zWVhOeklFRm5jbWxIZFdGeVpFUnBjM0IxZEdVb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalV3TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZjbVZqWlc1MFgyVjJaVzUwY3dvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZlpYWmxiblJmY205MWRHVkFNVFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG8wT0RNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZPRFVLSUNBZ0lDOHZJR05zWVhOeklFRm5jbWxIZFdGeVpFUnBjM0IxZEdVb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalE0TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZaWFpsYm5RS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgzTjBZWFJwYzNScFkzTmZjbTkxZEdWQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzBOemdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSZmMzUmhkR2x6ZEdsamN3b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZkRzkwWVd4ZmFuVnliM0p6WDNKdmRYUmxRREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TkRjekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYM1J2ZEdGc1gycDFjbTl5Y3dvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZmFuVnliM0pmYVc1bWIxOXliM1YwWlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qUTFOQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z1kyeGhjM01nUVdkeWFVZDFZWEprUkdsemNIVjBaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk5EVTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5cWRYSnZjbDlwYm1adkNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOWthWE53ZFhSbFgzSnZkWFJsUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk5ETXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pnMUNpQWdJQ0F2THlCamJHRnpjeUJCWjNKcFIzVmhjbVJFYVhOd2RYUmxLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvME16SUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR05oYkd4emRXSWdaMlYwWDJScGMzQjFkR1VLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkbTkwWlY5dmJsOWthWE53ZFhSbFgzSnZkWFJsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvek1UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklHTnNZWE56SUVGbmNtbEhkV0Z5WkVScGMzQjFkR1VvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qTXhOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCMmIzUmxYMjl1WDJScGMzQjFkR1VLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFgyUnBjM0IxZEdWZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pJeU1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z1kyeGhjM01nUVdkeWFVZDFZWEprUkdsemNIVjBaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk1qSXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUdOeVpXRjBaVjlrYVhOd2RYUmxDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSmxaMmx6ZEdWeVgycDFjbTl5WDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG94T0RFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQnlaV2RwYzNSbGNsOXFkWEp2Y2dvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl6WlhSZmFXNXpkWEpoYm1ObFgyTnZiblJ5WVdOMFgzSnZkWFJsUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRveE56TUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklHTnNZWE56SUVGbmNtbEhkV0Z5WkVScGMzQjFkR1VvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qRTNNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCelpYUmZhVzV6ZFhKaGJtTmxYMk52Ym5SeVlXTjBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTnlaV0YwWlY5aGNIQnNhV05oZEdsdmJsOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk1USXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZPRFVLSUNBZ0lDOHZJR05zWVhOeklFRm5jbWxIZFdGeVpFUnBjM0IxZEdVb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPakV5TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdZMkZzYkhOMVlpQmpjbVZoZEdWZllYQndiR2xqWVhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WkdsemNIVjBaUzVqYjI1MGNtRmpkQzVCWjNKcFIzVmhjbVJFYVhOd2RYUmxMbU55WldGMFpWOWhjSEJzYVdOaGRHbHZiaWhoWkcxcGJqb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNtTnlaV0YwWlY5aGNIQnNhV05oZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qRXlNQzB4TWpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJQzh2SUdSbFppQmpjbVZoZEdWZllYQndiR2xqWVhScGIyNG9jMlZzWml3Z1lXUnRhVzQ2SUVGa1pISmxjM01wSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qRXlNd29nSUNBZ0x5OGdjMlZzWmk1aFpHMXBiaUE5SUdGa2JXbHVDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhaRzFwYmlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pFeU5Bb2dJQ0FnTHk4Z2MyVnNaaTVqYjI1MGNtRmpkRjlqY21WaGRHbHZibDl5YjNWdVpDQTlJRWRzYjJKaGJDNXliM1Z1WkFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpWTI5dWRISmhZM1JmWTNKbFlYUnBiMjVmY205MWJtUWlDaUFnSUNCbmJHOWlZV3dnVW05MWJtUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3hNelFLSUNBZ0lDOHZJSE5sYkdZdWMzUmhkSE5mWW05NExuWmhiSFZsSUQwZ2FXNXBkR2xoYkY5emRHRjBjeTVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpJREV4SUM4dklDSnpkR0YwYzE5aWIzZ2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3hNall0TVRNekNpQWdJQ0F2THlBaklFbHVhWFJwWVd4cGVtVWdjM1JoZEdsemRHbGpjd29nSUNBZ0x5OGdhVzVwZEdsaGJGOXpkR0YwY3lBOUlFUnBjM0IxZEdWVGRHRjBjeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRjlrYVhOd2RYUmxjejFCVWtNMFZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSEpsYzI5c2RtVmtYMlJwYzNCMWRHVnpQVUZTUXpSVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdjbVZxWldOMFpXUmZaR2x6Y0hWMFpYTTlRVkpETkZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5MmIzUmxjMTlqWVhOMFBVRlNRelJWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lXTjBhWFpsWDJwMWNtOXljejFCVWtNMFZVbHVkRFkwS0RBcENpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRNMENpQWdJQ0F2THlCelpXeG1Mbk4wWVhSelgySnZlQzUyWVd4MVpTQTlJR2x1YVhScFlXeGZjM1JoZEhNdVkyOXdlU2dwQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRveE16WXRNVE0zQ2lBZ0lDQXZMeUFqSUV4dlp5QmpiMjUwY21GamRDQmpjbVZoZEdsdmJpQmxkbVZ1ZEFvZ0lDQWdMeThnYzJWc1ppNWZiRzluWDJWMlpXNTBLRUZTUXpSVlNXNTBOalFvTUNrc0lHRmtiV2x1TENCQlVrTTBVM1J5YVc1bktDSmpiMjUwY21GamRGOWpjbVZoZEdWa0lpa3NJRUZTUXpSVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURFd05qTTJaalpsTnpRM01qWXhOak0zTkRWbU5qTTNNalkxTmpFM05EWTFOalFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCallXeHNjM1ZpSUY5c2IyZGZaWFpsYm5RS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVrYVhOd2RYUmxMbU52Ym5SeVlXTjBMa0ZuY21sSGRXRnlaRVJwYzNCMWRHVXVYMnh2WjE5bGRtVnVkQ2hrYVhOd2RYUmxYMmxrT2lCaWVYUmxjeXdnYW5WeWIzSTZJR0o1ZEdWekxDQmhZM1JwYjI0NklHSjVkR1Z6TENCMmIzUmxYM1poYkhWbE9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1gyeHZaMTlsZG1WdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qRXpPUzB4TkRBS0lDQWdJQzh2SUVCemRXSnliM1YwYVc1bENpQWdJQ0F2THlCa1pXWWdYMnh2WjE5bGRtVnVkQ2h6Wld4bUxDQmthWE53ZFhSbFgybGtPaUJCVWtNMFZVbHVkRFkwTENCcWRYSnZjam9nUVdSa2NtVnpjeXdnWVdOMGFXOXVPaUJCVWtNMFUzUnlhVzVuTENCMmIzUmxYM1poYkhWbE9pQkJVa00wVlVsdWREWTBLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTkNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRveE5EWUtJQ0FnSUM4dklIUnBiV1Z6ZEdGdGNEMUJVa00wVlVsdWREWTBLRWRzYjJKaGJDNXliM1Z1WkNrc0NpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pFME1pMHhORGdLSUNBZ0lDOHZJR1YyWlc1MElEMGdSR2x6Y0hWMFpVVjJaVzUwS0FvZ0lDQWdMeThnSUNBZ0lHUnBjM0IxZEdWZmFXUTlaR2x6Y0hWMFpWOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCaFkzUnBiMjQ5WVdOMGFXOXVMQW9nSUNBZ0x5OGdJQ0FnSUdwMWNtOXlQV3AxY205eUxBb2dJQ0FnTHk4Z0lDQWdJSFJwYldWemRHRnRjRDFCVWtNMFZVbHVkRFkwS0Vkc2IySmhiQzV5YjNWdVpDa3NDaUFnSUNBdkx5QWdJQ0FnZG05MFpWOTJZV3gxWlQxMmIzUmxYM1poYkhWbENpQWdJQ0F2THlBcENpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd00yRUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRveE5Ea0tJQ0FnSUM4dklITmxiR1l1WlhabGJuUmZiRzluVzNObGJHWXVibVY0ZEY5bGRtVnVkRjlwWkYwZ1BTQmxkbVZ1ZEM1amIzQjVLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlibVY0ZEY5bGRtVnVkRjlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXVaWGgwWDJWMlpXNTBYMmxrSUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWlaWFpsYm5SZmJHOW5JZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG94TlRBS0lDQWdJQzh2SUhObGJHWXVibVY0ZEY5bGRtVnVkRjlwWkNBclBTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpYm1WNGRGOWxkbVZ1ZEY5cFpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHbHpjSFYwWlM1amIyNTBjbUZqZEM1QlozSnBSM1ZoY21SRWFYTndkWFJsTGw5MWNHUmhkR1ZmYzNSaGRITW9ZV04wYVc5dU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1gzVndaR0YwWlY5emRHRjBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPakUxTWkweE5UTUtJQ0FnSUM4dklFQnpkV0p5YjNWMGFXNWxDaUFnSUNBdkx5QmtaV1lnWDNWd1pHRjBaVjl6ZEdGMGN5aHpaV3htTENCaFkzUnBiMjQ2SUZOMGNtbHVaeWtnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pFMU5Rb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5emRHRjBjeUE5SUhObGJHWXVjM1JoZEhOZlltOTRMblpoYkhWbExtTnZjSGtvS1FvZ0lDQWdZbmwwWldNZ01URWdMeThnSW5OMFlYUnpYMkp2ZUNJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTjBZWFJ6WDJKdmVDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pFMU53b2dJQ0FnTHk4Z2FXWWdZV04wYVc5dUlEMDlJRk4wY21sdVp5Z2laR2x6Y0hWMFpWOWpjbVZoZEdWa0lpazZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNWRHVmpJREUzSUM4dklDSmthWE53ZFhSbFgyTnlaV0YwWldRaUNpQWdJQ0E5UFFvZ0lDQWdZbm9nWDNWd1pHRjBaVjl6ZEdGMGMxOWxiSE5sWDJKdlpIbEFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNVFU0Q2lBZ0lDQXZMeUJqZFhKeVpXNTBYM04wWVhSekxuUnZkR0ZzWDJScGMzQjFkR1Z6SUQwZ1FWSkRORlZKYm5RMk5DaGpkWEp5Wlc1MFgzTjBZWFJ6TG5SdmRHRnNYMlJwYzNCMWRHVnpMbTVoZEdsMlpTQXJJREVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtDbDkxY0dSaGRHVmZjM1JoZEhOZllXWjBaWEpmYVdaZlpXeHpaVUF4TnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pFM01Rb2dJQ0FnTHk4Z2MyVnNaaTV6ZEdGMGMxOWliM2d1ZG1Gc2RXVWdQU0JqZFhKeVpXNTBYM04wWVhSekxtTnZjSGtvS1FvZ0lDQWdZbmwwWldNZ01URWdMeThnSW5OMFlYUnpYMkp2ZUNJS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0J5WlhSemRXSUtDbDkxY0dSaGRHVmZjM1JoZEhOZlpXeHpaVjlpYjJSNVFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3hOVGtLSUNBZ0lDOHZJR1ZzYVdZZ1lXTjBhVzl1SUQwOUlGTjBjbWx1WnlnaVpHbHpjSFYwWlY5eVpYTnZiSFpsWkNJcE9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFl5QXhPQ0F2THlBaVpHbHpjSFYwWlY5eVpYTnZiSFpsWkNJS0lDQWdJRDA5Q2lBZ0lDQmllaUJmZFhCa1lYUmxYM04wWVhSelgyVnNjMlZmWW05a2VVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3hOakFLSUNBZ0lDOHZJR04xY25KbGJuUmZjM1JoZEhNdWNtVnpiMngyWldSZlpHbHpjSFYwWlhNZ1BTQkJVa00wVlVsdWREWTBLR04xY25KbGJuUmZjM1JoZEhNdWNtVnpiMngyWldSZlpHbHpjSFYwWlhNdWJtRjBhWFpsSUNzZ01Ta0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdPQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEZ0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWWlCZmRYQmtZWFJsWDNOMFlYUnpYMkZtZEdWeVgybG1YMlZzYzJWQU1UY0tDbDkxY0dSaGRHVmZjM1JoZEhOZlpXeHpaVjlpYjJSNVFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3hOakVLSUNBZ0lDOHZJR1ZzYVdZZ1lXTjBhVzl1SUQwOUlGTjBjbWx1WnlnaVpHbHpjSFYwWlY5eVpXcGxZM1JsWkNJcE9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFl5QXhPU0F2THlBaVpHbHpjSFYwWlY5eVpXcGxZM1JsWkNJS0lDQWdJRDA5Q2lBZ0lDQmllaUJmZFhCa1lYUmxYM04wWVhSelgyVnNjMlZmWW05a2VVQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3hOaklLSUNBZ0lDOHZJR04xY25KbGJuUmZjM1JoZEhNdWNtVnFaV04wWldSZlpHbHpjSFYwWlhNZ1BTQkJVa00wVlVsdWREWTBLR04xY25KbGJuUmZjM1JoZEhNdWNtVnFaV04wWldSZlpHbHpjSFYwWlhNdWJtRjBhWFpsSUNzZ01Ta0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVFlnTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdNVFlLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1lpQmZkWEJrWVhSbFgzTjBZWFJ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNVGNLQ2w5MWNHUmhkR1ZmYzNSaGRITmZaV3h6WlY5aWIyUjVRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG94TmpNS0lDQWdJQzh2SUdWc2FXWWdZV04wYVc5dUlEMDlJRk4wY21sdVp5Z2laR2x6Y0hWMFpWOXdjbTlqWlhOelpXUWlLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lubDBaV01nTWpBZ0x5OGdJbVJwYzNCMWRHVmZjSEp2WTJWemMyVmtJZ29nSUNBZ1BUMEtJQ0FnSUdKdWVpQmZkWEJrWVhSbFgzTjBZWFJ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNVGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPakUyTmdvZ0lDQWdMeThnWld4cFppQmhZM1JwYjI0Z1BUMGdVM1J5YVc1bktDSjJiM1JsWDJOaGMzUWlLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lubDBaV01nTWpFZ0x5OGdJblp2ZEdWZlkyRnpkQ0lLSUNBZ0lEMDlDaUFnSUNCaWVpQmZkWEJrWVhSbFgzTjBZWFJ6WDJWc2MyVmZZbTlrZVVBeE1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk1UWTNDaUFnSUNBdkx5QmpkWEp5Wlc1MFgzTjBZWFJ6TG5SdmRHRnNYM1p2ZEdWelgyTmhjM1FnUFNCQlVrTTBWVWx1ZERZMEtHTjFjbkpsYm5SZmMzUmhkSE11ZEc5MFlXeGZkbTkwWlhOZlkyRnpkQzV1WVhScGRtVWdLeUF4S1FvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeU5DQXZMeUF5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBeU5Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JpSUY5MWNHUmhkR1ZmYzNSaGRITmZZV1owWlhKZmFXWmZaV3h6WlVBeE53b0tYM1Z3WkdGMFpWOXpkR0YwYzE5bGJITmxYMkp2WkhsQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3hOamdLSUNBZ0lDOHZJR1ZzYVdZZ1lXTjBhVzl1SUQwOUlGTjBjbWx1WnlnaWFuVnliM0pmY21WbmFYTjBaWEpsWkNJcE9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFl5QXlNaUF2THlBaWFuVnliM0pmY21WbmFYTjBaWEpsWkNJS0lDQWdJRDA5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCaWVpQmZkWEJrWVhSbFgzTjBZWFJ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPakUyT1FvZ0lDQWdMeThnWTNWeWNtVnVkRjl6ZEdGMGN5NWhZM1JwZG1WZmFuVnliM0p6SUQwZ1FWSkRORlZKYm5RMk5DaGpkWEp5Wlc1MFgzTjBZWFJ6TG1GamRHbDJaVjlxZFhKdmNuTXVibUYwYVhabElDc2dNU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTXpJS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvS1gzVndaR0YwWlY5emRHRjBjMTloWm5SbGNsOXBabDlsYkhObFFERXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWWlCZmRYQmtZWFJsWDNOMFlYUnpYMkZtZEdWeVgybG1YMlZzYzJWQU1UY0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WkdsemNIVjBaUzVqYjI1MGNtRmpkQzVCWjNKcFIzVmhjbVJFYVhOd2RYUmxMbk5sZEY5cGJuTjFjbUZ1WTJWZlkyOXVkSEpoWTNRb1kyOXVkSEpoWTNSZllXUmtjbVZ6Y3pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwelpYUmZhVzV6ZFhKaGJtTmxYMk52Ym5SeVlXTjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNVGN6TFRFM05Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JSE5sZEY5cGJuTjFjbUZ1WTJWZlkyOXVkSEpoWTNRb2MyVnNaaXdnWTI5dWRISmhZM1JmWVdSa2NtVnpjem9nUVdSa2NtVnpjeWtnTFQ0Z1FWSkRORlZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRjMkNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1Ga2JXbHVMQ0FpVDI1c2VTQmhaRzFwYmlJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JoWkcxcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk1UYzRDaUFnSUNBdkx5QnpaV3htTG1sdWMzVnlZVzVqWlY5amIyNTBjbUZqZENBOUlHTnZiblJ5WVdOMFgyRmtaSEpsYzNNS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW1sdWMzVnlZVzVqWlY5amIyNTBjbUZqZENJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pFM09Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUVGU1F6UlZTVzUwTmpRb01Ta0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBeENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WkdsemNIVjBaUzVqYjI1MGNtRmpkQzVCWjNKcFIzVmhjbVJFYVhOd2RYUmxMbkpsWjJsemRHVnlYMnAxY205eUtDa2dMVDRnWW5sMFpYTTZDbkpsWjJsemRHVnlYMnAxY205eU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk1UZ3hMVEU0TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlISmxaMmx6ZEdWeVgycDFjbTl5S0hObGJHWXBJQzArSUVGU1F6UlZTVzUwTmpRNkNpQWdJQ0J3Y205MGJ5QXdJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPakU0TkFvZ0lDQWdMeThnWTJGc2JHVnlJRDBnUVdSa2NtVnpjeTVtY205dFgySjVkR1Z6S0ZSNGJpNXpaVzVrWlhJdVlubDBaWE1wQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3hPRFl0TVRnM0NpQWdJQ0F2THlBaklFTm9aV05ySUdsbUlHRnNjbVZoWkhrZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z1pYaHBjM1JwYm1kZmFuVnliM0lnUFNCelpXeG1MbXAxY205eWN5NXRZWGxpWlNoallXeHNaWElwV3pGZENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKcWRYSnZjbk1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG94T0RRS0lDQWdJQzh2SUdOaGJHeGxjaUE5SUVGa1pISmxjM011Wm5KdmJWOWllWFJsY3loVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNVGcyTFRFNE53b2dJQ0FnTHk4Z0l5QkRhR1ZqYXlCcFppQmhiSEpsWVdSNUlISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklHVjRhWE4wYVc1blgycDFjbTl5SUQwZ2MyVnNaaTVxZFhKdmNuTXViV0Y1WW1Vb1kyRnNiR1Z5S1ZzeFhRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TVRnNENpQWdJQ0F2THlCcFppQmxlR2x6ZEdsdVoxOXFkWEp2Y2pvS0lDQWdJR0o2SUhKbFoybHpkR1Z5WDJwMWNtOXlYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk1UZzVDaUFnSUNBdkx5QnlaWFIxY200Z1FWSkRORlZKYm5RMk5DZ3dLU0FnSXlCQmJISmxZV1I1SUhKbFoybHpkR1Z5WldRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS2NtVm5hWE4wWlhKZmFuVnliM0pmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNVGt4TFRFNU1nb2dJQ0FnTHk4Z0l5QkZibWhoYm1ObFpDQjJZV3hwWkdGMGFXOXVDaUFnSUNBdkx5QmpkWEp5Wlc1MFgzSnZkVzVrSUQwZ1IyeHZZbUZzTG5KdmRXNWtDaUFnSUNCbmJHOWlZV3dnVW05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qRTVNd29nSUNBZ0x5OGdZWE56WlhKMElHTjFjbkpsYm5SZmNtOTFibVFnUGowZ2MyVnNaaTVqYjI1MGNtRmpkRjlqY21WaGRHbHZibDl5YjNWdVpDQXJJRlZKYm5RMk5DZ3hNQ2tzSUNKRGIyNTBjbUZqZENCcGJtbDBhV0ZzYVhwaGRHbHZiaUJ3WlhKcGIyUWdibTkwSUdOdmJYQnNaWFJsSWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbU52Ym5SeVlXTjBYMk55WldGMGFXOXVYM0p2ZFc1a0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU52Ym5SeVlXTjBYMk55WldGMGFXOXVYM0p2ZFc1a0lHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eklDOHZJREV3Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCRGIyNTBjbUZqZENCcGJtbDBhV0ZzYVhwaGRHbHZiaUJ3WlhKcGIyUWdibTkwSUdOdmJYQnNaWFJsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG95TURFS0lDQWdJQzh2SUhKbFoybHpkSEpoZEdsdmJsOXliM1Z1WkQxQlVrTTBWVWx1ZERZMEtHTjFjbkpsYm5SZmNtOTFibVFwTEFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TWpBekNpQWdJQ0F2THlCemRHRnJaV1JmWVcxdmRXNTBQVUZTUXpSVlNXNTBOalFvYzJWc1ppNXRhVzVmYzNSaGEyVmZZVzF2ZFc1MEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklERTFJQzh2SUNKdGFXNWZjM1JoYTJWZllXMXZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtMXBibDl6ZEdGclpWOWhiVzkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG94T1RVdE1qQTBDaUFnSUNBdkx5QWpJRkpsWjJsemRHVnlJRzVsZHlCcWRYSnZjaUIzYVhSb0lHVnVhR0Z1WTJWa0lHUmhkR0VLSUNBZ0lDOHZJR3AxY205eVgyUmhkR0VnUFNCS2RYSnZja1JoZEdFb0NpQWdJQ0F2THlBZ0lDQWdZV1JrY21WemN6MWpZV3hzWlhJc0NpQWdJQ0F2THlBZ0lDQWdjbVZ3ZFhSaGRHbHZiajFCVWtNMFZVbHVkRFkwS0RFd01Da3NJQ0FqSUZOMFlYSjBJSGRwZEdnZ01UQXdJSEpsY0hWMFlYUnBiMjRnY0c5cGJuUnpDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXeGZkbTkwWlhNOVFWSkRORlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCamIzSnlaV04wWDNadmRHVnpQVUZTUXpSVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdjbVZuYVhOMGNtRjBhVzl1WDNKdmRXNWtQVUZTUXpSVlNXNTBOalFvWTNWeWNtVnVkRjl5YjNWdVpDa3NDaUFnSUNBdkx5QWdJQ0FnYkdGemRGOTJiM1JsWDNKdmRXNWtQVUZTUXpSVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdjM1JoYTJWa1gyRnRiM1Z1ZEQxQlVrTTBWVWx1ZERZMEtITmxiR1l1YldsdVgzTjBZV3RsWDJGdGIzVnVkQ2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPakU1T0FvZ0lDQWdMeThnY21Wd2RYUmhkR2x2YmoxQlVrTTBWVWx1ZERZMEtERXdNQ2tzSUNBaklGTjBZWEowSUhkcGRHZ2dNVEF3SUhKbGNIVjBZWFJwYjI0Z2NHOXBiblJ6Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3hPVFV0TWpBMENpQWdJQ0F2THlBaklGSmxaMmx6ZEdWeUlHNWxkeUJxZFhKdmNpQjNhWFJvSUdWdWFHRnVZMlZrSUdSaGRHRUtJQ0FnSUM4dklHcDFjbTl5WDJSaGRHRWdQU0JLZFhKdmNrUmhkR0VvQ2lBZ0lDQXZMeUFnSUNBZ1lXUmtjbVZ6Y3oxallXeHNaWElzQ2lBZ0lDQXZMeUFnSUNBZ2NtVndkWFJoZEdsdmJqMUJVa00wVlVsdWREWTBLREV3TUNrc0lDQWpJRk4wWVhKMElIZHBkR2dnTVRBd0lISmxjSFYwWVhScGIyNGdjRzlwYm5SekNpQWdJQ0F2THlBZ0lDQWdkRzkwWVd4ZmRtOTBaWE05UVZKRE5GVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JqYjNKeVpXTjBYM1p2ZEdWelBVRlNRelJWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2NtVm5hWE4wY21GMGFXOXVYM0p2ZFc1a1BVRlNRelJWU1c1ME5qUW9ZM1Z5Y21WdWRGOXliM1Z1WkNrc0NpQWdJQ0F2THlBZ0lDQWdiR0Z6ZEY5MmIzUmxYM0p2ZFc1a1BVRlNRelJWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhhMlZrWDJGdGIzVnVkRDFCVWtNMFZVbHVkRFkwS0hObGJHWXViV2x1WDNOMFlXdGxYMkZ0YjNWdWRDa0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNVGs1Q2lBZ0lDQXZMeUIwYjNSaGJGOTJiM1JsY3oxQlVrTTBWVWx1ZERZMEtEQXBMQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qRTVOUzB5TURRS0lDQWdJQzh2SUNNZ1VtVm5hWE4wWlhJZ2JtVjNJR3AxY205eUlIZHBkR2dnWlc1b1lXNWpaV1FnWkdGMFlRb2dJQ0FnTHk4Z2FuVnliM0pmWkdGMFlTQTlJRXAxY205eVJHRjBZU2dLSUNBZ0lDOHZJQ0FnSUNCaFpHUnlaWE56UFdOaGJHeGxjaXdLSUNBZ0lDOHZJQ0FnSUNCeVpYQjFkR0YwYVc5dVBVRlNRelJWU1c1ME5qUW9NVEF3S1N3Z0lDTWdVM1JoY25RZ2QybDBhQ0F4TURBZ2NtVndkWFJoZEdsdmJpQndiMmx1ZEhNS0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5MmIzUmxjejFCVWtNMFZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR052Y25KbFkzUmZkbTkwWlhNOVFWSkRORlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCeVpXZHBjM1J5WVhScGIyNWZjbTkxYm1ROVFWSkRORlZKYm5RMk5DaGpkWEp5Wlc1MFgzSnZkVzVrS1N3S0lDQWdJQzh2SUNBZ0lDQnNZWE4wWDNadmRHVmZjbTkxYm1ROVFWSkRORlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCemRHRnJaV1JmWVcxdmRXNTBQVUZTUXpSVlNXNTBOalFvYzJWc1ppNXRhVzVmYzNSaGEyVmZZVzF2ZFc1MEtRb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3lNREFLSUNBZ0lDOHZJR052Y25KbFkzUmZkbTkwWlhNOVFWSkRORlZKYm5RMk5DZ3dLU3dLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3hPVFV0TWpBMENpQWdJQ0F2THlBaklGSmxaMmx6ZEdWeUlHNWxkeUJxZFhKdmNpQjNhWFJvSUdWdWFHRnVZMlZrSUdSaGRHRUtJQ0FnSUM4dklHcDFjbTl5WDJSaGRHRWdQU0JLZFhKdmNrUmhkR0VvQ2lBZ0lDQXZMeUFnSUNBZ1lXUmtjbVZ6Y3oxallXeHNaWElzQ2lBZ0lDQXZMeUFnSUNBZ2NtVndkWFJoZEdsdmJqMUJVa00wVlVsdWREWTBLREV3TUNrc0lDQWpJRk4wWVhKMElIZHBkR2dnTVRBd0lISmxjSFYwWVhScGIyNGdjRzlwYm5SekNpQWdJQ0F2THlBZ0lDQWdkRzkwWVd4ZmRtOTBaWE05UVZKRE5GVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JqYjNKeVpXTjBYM1p2ZEdWelBVRlNRelJWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2NtVm5hWE4wY21GMGFXOXVYM0p2ZFc1a1BVRlNRelJWU1c1ME5qUW9ZM1Z5Y21WdWRGOXliM1Z1WkNrc0NpQWdJQ0F2THlBZ0lDQWdiR0Z6ZEY5MmIzUmxYM0p2ZFc1a1BVRlNRelJWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhhMlZrWDJGdGIzVnVkRDFCVWtNMFZVbHVkRFkwS0hObGJHWXViV2x1WDNOMFlXdGxYMkZ0YjNWdWRDa0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qSXdNZ29nSUNBZ0x5OGdiR0Z6ZEY5MmIzUmxYM0p2ZFc1a1BVRlNRelJWU1c1ME5qUW9NQ2tzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNVGsxTFRJd05Bb2dJQ0FnTHk4Z0l5QlNaV2RwYzNSbGNpQnVaWGNnYW5WeWIzSWdkMmwwYUNCbGJtaGhibU5sWkNCa1lYUmhDaUFnSUNBdkx5QnFkWEp2Y2w5a1lYUmhJRDBnU25WeWIzSkVZWFJoS0FvZ0lDQWdMeThnSUNBZ0lHRmtaSEpsYzNNOVkyRnNiR1Z5TEFvZ0lDQWdMeThnSUNBZ0lISmxjSFYwWVhScGIyNDlRVkpETkZWSmJuUTJOQ2d4TURBcExDQWdJeUJUZEdGeWRDQjNhWFJvSURFd01DQnlaWEIxZEdGMGFXOXVJSEJ2YVc1MGN3b2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gzWnZkR1Z6UFVGU1F6UlZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWTI5eWNtVmpkRjkyYjNSbGN6MUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lISmxaMmx6ZEhKaGRHbHZibDl5YjNWdVpEMUJVa00wVlVsdWREWTBLR04xY25KbGJuUmZjbTkxYm1RcExBb2dJQ0FnTHk4Z0lDQWdJR3hoYzNSZmRtOTBaVjl5YjNWdVpEMUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lITjBZV3RsWkY5aGJXOTFiblE5UVZKRE5GVkpiblEyTkNoelpXeG1MbTFwYmw5emRHRnJaVjloYlc5MWJuUXBDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TWpBMkNpQWdJQ0F2THlCelpXeG1MbXAxY205eWMxdGpZV3hzWlhKZElEMGdhblZ5YjNKZlpHRjBZUzVqYjNCNUtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3lNRGNLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYW5WeWIzSnpJQ3M5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblJ2ZEdGc1gycDFjbTl5Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5cWRYSnZjbk1nWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZhblZ5YjNKeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qSXdPUzB5TVRBS0lDQWdJQzh2SUNNZ1ZYQmtZWFJsSUhOMFlYUnBjM1JwWTNNS0lDQWdJQzh2SUhObGJHWXVYM1Z3WkdGMFpWOXpkR0YwY3loVGRISnBibWNvSW1wMWNtOXlYM0psWjJsemRHVnlaV1FpS1NrS0lDQWdJR0o1ZEdWaklESXlJQzh2SUNKcWRYSnZjbDl5WldkcGMzUmxjbVZrSWdvZ0lDQWdZMkZzYkhOMVlpQmZkWEJrWVhSbFgzTjBZWFJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG95TVRJdE1qRXpDaUFnSUNBdkx5QWpJRXh2WnlCcWRYSnZjaUJ5WldkcGMzUnlZWFJwYjI0Z1pYWmxiblFLSUNBZ0lDOHZJSE5sYkdZdVgyeHZaMTlsZG1WdWRDaEJVa00wVlVsdWREWTBLREFwTENCallXeHNaWElzSUVGU1F6UlRkSEpwYm1jb0ltcDFjbTl5WDNKbFoybHpkR1Z5WldRaUtTd2dRVkpETkZWSmJuUTJOQ2d3S1NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeE1EWmhOelUzTWpabU56STFaamN5TmpVMk56WTVOek0zTkRZMU56STJOVFkwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyRnNiSE4xWWlCZmJHOW5YMlYyWlc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRveU1UVXRNakUyQ2lBZ0lDQXZMeUFqSUVWdGFYUWdiRzluSUdadmNpQmxlSFJsY201aGJDQnRiMjVwZEc5eWFXNW5DaUFnSUNBdkx5QnNiMmNvUW5sMFpYTW9ZaUpLVlZKUFVsOVNSVWRKVTFSRlVrVkVJaWtnS3lCallXeHNaWEl1WW5sMFpYTXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBZVFUxTlRJMFpqVXlOV1kxTWpRMU5EYzBPVFV6TlRRME5UVXlORFUwTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pJeE9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUVGU1F6UlZTVzUwTmpRb01Ta0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVrYVhOd2RYUmxMbU52Ym5SeVlXTjBMa0ZuY21sSGRXRnlaRVJwYzNCMWRHVXVZM0psWVhSbFgyUnBjM0IxZEdVb2NHOXNhV041WDJsa09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtTnlaV0YwWlY5a2FYTndkWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TWpJd0xUSXlNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUdOeVpXRjBaVjlrYVhOd2RYUmxLSE5sYkdZc0lIQnZiR2xqZVY5cFpEb2dRVkpETkZWSmJuUTJOQ2tnTFQ0Z1FWSkRORlZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNakl6Q2lBZ0lDQXZMeUJqWVd4c1pYSWdQU0JCWkdSeVpYTnpMbVp5YjIxZllubDBaWE1vVkhodUxuTmxibVJsY2k1aWVYUmxjeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qSXlOUzB5TWpZS0lDQWdJQzh2SUNNZ1JXNW9ZVzVqWldRZ2RtRnNhV1JoZEdsdmJnb2dJQ0FnTHk4Z2FuVnliM0pmWlhocGMzUnpJRDBnYzJWc1ppNXFkWEp2Y25NdWJXRjVZbVVvWTJGc2JHVnlLVnN4WFFvZ0lDQWdZbmwwWldNZ055QXZMeUFpYW5WeWIzSnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNakl6Q2lBZ0lDQXZMeUJqWVd4c1pYSWdQU0JCWkdSeVpYTnpMbVp5YjIxZllubDBaWE1vVkhodUxuTmxibVJsY2k1aWVYUmxjeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qSXlOUzB5TWpZS0lDQWdJQzh2SUNNZ1JXNW9ZVzVqWldRZ2RtRnNhV1JoZEdsdmJnb2dJQ0FnTHk4Z2FuVnliM0pmWlhocGMzUnpJRDBnYzJWc1ppNXFkWEp2Y25NdWJXRjVZbVVvWTJGc2JHVnlLVnN4WFFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPakl5TndvZ0lDQWdMeThnYVdZZ2JtOTBJR3AxY205eVgyVjRhWE4wY3pvS0lDQWdJR0p1ZWlCamNtVmhkR1ZmWkdsemNIVjBaVjloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qSXlPQW9nSUNBZ0x5OGdjbVYwZFhKdUlFRlNRelJWU1c1ME5qUW9NQ2tnSUNNZ1RtOTBJSEpsWjJsemRHVnlaV1FnWVhNZ2FuVnliM0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWTNKbFlYUmxYMlJwYzNCMWRHVmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk1qTXdMVEl6TVFvZ0lDQWdMeThnSXlCVWFXMWxMV0poYzJWa0lIWmhiR2xrWVhScGIyNEtJQ0FnSUM4dklHTjFjbkpsYm5SZmNtOTFibVFnUFNCSGJHOWlZV3d1Y205MWJtUUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk1qTXlDaUFnSUNBdkx5QmhjM05sY25RZ1kzVnljbVZ1ZEY5eWIzVnVaQ0ErUFNCelpXeG1MbU52Ym5SeVlXTjBYMk55WldGMGFXOXVYM0p2ZFc1a0lDc2dWVWx1ZERZMEtEVXdLU3dnSWtOdmJuUnlZV04wSUc1dmRDQm1kV3hzZVNCdmNHVnlZWFJwYjI1aGJDQjVaWFFpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWlZMjl1ZEhKaFkzUmZZM0psWVhScGIyNWZjbTkxYm1RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMjl1ZEhKaFkzUmZZM0psWVhScGIyNWZjbTkxYm1RZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOVEFLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVOdmJuUnlZV04wSUc1dmRDQm1kV3hzZVNCdmNHVnlZWFJwYjI1aGJDQjVaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPakl6TkMweU16VUtJQ0FnSUM4dklDTWdRM0psWVhSbElHUnBjM0IxZEdVZ2QybDBhQ0JsYm1oaGJtTmxaQ0JrWVhSaENpQWdJQ0F2THlCa2FYTndkWFJsWDJsa0lEMGdjMlZzWmk1dVpYaDBYMlJwYzNCMWRHVmZhV1FLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSnVaWGgwWDJScGMzQjFkR1ZmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVibVY0ZEY5a2FYTndkWFJsWDJsa0lHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TWpNMkNpQWdJQ0F2THlCelpXeG1MbTVsZUhSZlpHbHpjSFYwWlY5cFpDQXJQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWaklEWWdMeThnSW01bGVIUmZaR2x6Y0hWMFpWOXBaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG95TkRJS0lDQWdJQzh2SUdOeVpXRjBaV1JmWVhROVFWSkRORlZKYm5RMk5DaGpkWEp5Wlc1MFgzSnZkVzVrS1N3S0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRveU5EY0tJQ0FnSUM4dklIWnZkR2x1WjE5a1pXRmtiR2x1WlQxQlVrTTBWVWx1ZERZMEtHTjFjbkpsYm5SZmNtOTFibVFnS3lCelpXeG1Mblp2ZEdsdVoxOWtkWEpoZEdsdmJsOXliM1Z1WkhNcExBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKMmIzUnBibWRmWkhWeVlYUnBiMjVmY205MWJtUnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5admRHbHVaMTlrZFhKaGRHbHZibDl5YjNWdVpITWdaWGhwYzNSekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qSXpPQzB5TkRrS0lDQWdJQzh2SUdScGMzQjFkR1ZmWkdGMFlTQTlJRVJwYzNCMWRHVkVZWFJoS0FvZ0lDQWdMeThnSUNBZ0lIQnZiR2xqZVY5cFpEMXdiMnhwWTNsZmFXUXNDaUFnSUNBdkx5QWdJQ0FnWTJ4aGFXMWhiblE5WTJGc2JHVnlMQW9nSUNBZ0x5OGdJQ0FnSUhKbFlYTnZiajFCVWtNMFUzUnlhVzVuS0NKUWIyeHBZM2tnYzJWMGRHeGxiV1Z1ZENCa2FYTndkWFJsSWlrc0lDQWpJRVJsWm1GMWJIUWdjbVZoYzI5dUNpQWdJQ0F2THlBZ0lDQWdZM0psWVhSbFpGOWhkRDFCVWtNMFZVbHVkRFkwS0dOMWNuSmxiblJmY205MWJtUXBMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFCVWtNMFZVbHVkRFkwS0RBcExDQWdJeUJCWTNScGRtVUtJQ0FnSUM4dklDQWdJQ0I1WlhOZmRtOTBaWE05UVZKRE5GVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J1YjE5MmIzUmxjejFCVWtNMFZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gzWnZkR1Z6UFVGU1F6UlZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZG05MGFXNW5YMlJsWVdSc2FXNWxQVUZTUXpSVlNXNTBOalFvWTNWeWNtVnVkRjl5YjNWdVpDQXJJSE5sYkdZdWRtOTBhVzVuWDJSMWNtRjBhVzl1WDNKdmRXNWtjeWtzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpiMngxZEdsdmJsOXliM1Z1WkQxQlVrTTBWVWx1ZERZMEtEQXBDaUFnSUNBdkx5QXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdOaklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPakkwTXdvZ0lDQWdMeThnYzNSaGRIVnpQVUZTUXpSVlNXNTBOalFvTUNrc0lDQWpJRUZqZEdsMlpRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pJek9DMHlORGtLSUNBZ0lDOHZJR1JwYzNCMWRHVmZaR0YwWVNBOUlFUnBjM0IxZEdWRVlYUmhLQW9nSUNBZ0x5OGdJQ0FnSUhCdmJHbGplVjlwWkQxd2IyeHBZM2xmYVdRc0NpQWdJQ0F2THlBZ0lDQWdZMnhoYVcxaGJuUTlZMkZzYkdWeUxBb2dJQ0FnTHk4Z0lDQWdJSEpsWVhOdmJqMUJVa00wVTNSeWFXNW5LQ0pRYjJ4cFkza2djMlYwZEd4bGJXVnVkQ0JrYVhOd2RYUmxJaWtzSUNBaklFUmxabUYxYkhRZ2NtVmhjMjl1Q2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJsWkY5aGREMUJVa00wVlVsdWREWTBLR04xY25KbGJuUmZjbTkxYm1RcExBb2dJQ0FnTHk4Z0lDQWdJSE4wWVhSMWN6MUJVa00wVlVsdWREWTBLREFwTENBZ0l5QkJZM1JwZG1VS0lDQWdJQzh2SUNBZ0lDQjVaWE5mZG05MFpYTTlRVkpETkZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQnViMTkyYjNSbGN6MUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDNadmRHVnpQVUZTUXpSVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdkbTkwYVc1blgyUmxZV1JzYVc1bFBVRlNRelJWU1c1ME5qUW9ZM1Z5Y21WdWRGOXliM1Z1WkNBcklITmxiR1l1ZG05MGFXNW5YMlIxY21GMGFXOXVYM0p2ZFc1a2N5a3NDaUFnSUNBdkx5QWdJQ0FnY21WemIyeDFkR2x2Ymw5eWIzVnVaRDFCVWtNMFZVbHVkRFkwS0RBcENpQWdJQ0F2THlBcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qSTBOQW9nSUNBZ0x5OGdlV1Z6WDNadmRHVnpQVUZTUXpSVlNXNTBOalFvTUNrc0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TWpNNExUSTBPUW9nSUNBZ0x5OGdaR2x6Y0hWMFpWOWtZWFJoSUQwZ1JHbHpjSFYwWlVSaGRHRW9DaUFnSUNBdkx5QWdJQ0FnY0c5c2FXTjVYMmxrUFhCdmJHbGplVjlwWkN3S0lDQWdJQzh2SUNBZ0lDQmpiR0ZwYldGdWREMWpZV3hzWlhJc0NpQWdJQ0F2THlBZ0lDQWdjbVZoYzI5dVBVRlNRelJUZEhKcGJtY29JbEJ2YkdsamVTQnpaWFIwYkdWdFpXNTBJR1JwYzNCMWRHVWlLU3dnSUNNZ1JHVm1ZWFZzZENCeVpXRnpiMjRLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkR1ZrWDJGMFBVRlNRelJWU1c1ME5qUW9ZM1Z5Y21WdWRGOXliM1Z1WkNrc0NpQWdJQ0F2THlBZ0lDQWdjM1JoZEhWelBVRlNRelJWU1c1ME5qUW9NQ2tzSUNBaklFRmpkR2wyWlFvZ0lDQWdMeThnSUNBZ0lIbGxjMTkyYjNSbGN6MUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHNXZYM1p2ZEdWelBVRlNRelJWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3hmZG05MFpYTTlRVkpETkZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjJiM1JwYm1kZlpHVmhaR3hwYm1VOVFWSkRORlZKYm5RMk5DaGpkWEp5Wlc1MFgzSnZkVzVrSUNzZ2MyVnNaaTUyYjNScGJtZGZaSFZ5WVhScGIyNWZjbTkxYm1SektTd0tJQ0FnSUM4dklDQWdJQ0J5WlhOdmJIVjBhVzl1WDNKdmRXNWtQVUZTUXpSVlNXNTBOalFvTUNrS0lDQWdJQzh2SUNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk1qUTFDaUFnSUNBdkx5QnViMTkyYjNSbGN6MUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPakl6T0MweU5Ea0tJQ0FnSUM4dklHUnBjM0IxZEdWZlpHRjBZU0E5SUVScGMzQjFkR1ZFWVhSaEtBb2dJQ0FnTHk4Z0lDQWdJSEJ2YkdsamVWOXBaRDF3YjJ4cFkzbGZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ1kyeGhhVzFoYm5ROVkyRnNiR1Z5TEFvZ0lDQWdMeThnSUNBZ0lISmxZWE52YmoxQlVrTTBVM1J5YVc1bktDSlFiMnhwWTNrZ2MyVjBkR3hsYldWdWRDQmthWE53ZFhSbElpa3NJQ0FqSUVSbFptRjFiSFFnY21WaGMyOXVDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUmxaRjloZEQxQlVrTTBWVWx1ZERZMEtHTjFjbkpsYm5SZmNtOTFibVFwTEFvZ0lDQWdMeThnSUNBZ0lITjBZWFIxY3oxQlVrTTBWVWx1ZERZMEtEQXBMQ0FnSXlCQlkzUnBkbVVLSUNBZ0lDOHZJQ0FnSUNCNVpYTmZkbTkwWlhNOVFWSkRORlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCdWIxOTJiM1JsY3oxQlVrTTBWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNYM1p2ZEdWelBVRlNRelJWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RtOTBhVzVuWDJSbFlXUnNhVzVsUFVGU1F6UlZTVzUwTmpRb1kzVnljbVZ1ZEY5eWIzVnVaQ0FySUhObGJHWXVkbTkwYVc1blgyUjFjbUYwYVc5dVgzSnZkVzVrY3lrc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6YjJ4MWRHbHZibDl5YjNWdVpEMUJVa00wVlVsdWREWTBLREFwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pJME5nb2dJQ0FnTHk4Z2RHOTBZV3hmZG05MFpYTTlRVkpETkZWSmJuUTJOQ2d3S1N3S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG95TXpndE1qUTVDaUFnSUNBdkx5QmthWE53ZFhSbFgyUmhkR0VnUFNCRWFYTndkWFJsUkdGMFlTZ0tJQ0FnSUM4dklDQWdJQ0J3YjJ4cFkzbGZhV1E5Y0c5c2FXTjVYMmxrTEFvZ0lDQWdMeThnSUNBZ0lHTnNZV2x0WVc1MFBXTmhiR3hsY2l3S0lDQWdJQzh2SUNBZ0lDQnlaV0Z6YjI0OVFWSkRORk4wY21sdVp5Z2lVRzlzYVdONUlITmxkSFJzWlcxbGJuUWdaR2x6Y0hWMFpTSXBMQ0FnSXlCRVpXWmhkV3gwSUhKbFlYTnZiZ29nSUNBZ0x5OGdJQ0FnSUdOeVpXRjBaV1JmWVhROVFWSkRORlZKYm5RMk5DaGpkWEp5Wlc1MFgzSnZkVzVrS1N3S0lDQWdJQzh2SUNBZ0lDQnpkR0YwZFhNOVFWSkRORlZKYm5RMk5DZ3dLU3dnSUNNZ1FXTjBhWFpsQ2lBZ0lDQXZMeUFnSUNBZ2VXVnpYM1p2ZEdWelBVRlNRelJWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2JtOWZkbTkwWlhNOVFWSkRORlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRjkyYjNSbGN6MUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIWnZkR2x1WjE5a1pXRmtiR2x1WlQxQlVrTTBWVWx1ZERZMEtHTjFjbkpsYm5SZmNtOTFibVFnS3lCelpXeG1Mblp2ZEdsdVoxOWtkWEpoZEdsdmJsOXliM1Z1WkhNcExBb2dJQ0FnTHk4Z0lDQWdJSEpsYzI5c2RYUnBiMjVmY205MWJtUTlRVkpETkZWSmJuUTJOQ2d3S1FvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qSTBPQW9nSUNBZ0x5OGdjbVZ6YjJ4MWRHbHZibDl5YjNWdVpEMUJVa00wVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNak00TFRJME9Rb2dJQ0FnTHk4Z1pHbHpjSFYwWlY5a1lYUmhJRDBnUkdsemNIVjBaVVJoZEdFb0NpQWdJQ0F2THlBZ0lDQWdjRzlzYVdONVgybGtQWEJ2YkdsamVWOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCamJHRnBiV0Z1ZEQxallXeHNaWElzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmhjMjl1UFVGU1F6UlRkSEpwYm1jb0lsQnZiR2xqZVNCelpYUjBiR1Z0Wlc1MElHUnBjM0IxZEdVaUtTd2dJQ01nUkdWbVlYVnNkQ0J5WldGemIyNEtJQ0FnSUM4dklDQWdJQ0JqY21WaGRHVmtYMkYwUFVGU1F6UlZTVzUwTmpRb1kzVnljbVZ1ZEY5eWIzVnVaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhkSFZ6UFVGU1F6UlZTVzUwTmpRb01Da3NJQ0FqSUVGamRHbDJaUW9nSUNBZ0x5OGdJQ0FnSUhsbGMxOTJiM1JsY3oxQlVrTTBWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUc1dlgzWnZkR1Z6UFVGU1F6UlZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXeGZkbTkwWlhNOVFWSkRORlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCMmIzUnBibWRmWkdWaFpHeHBibVU5UVZKRE5GVkpiblEyTkNoamRYSnlaVzUwWDNKdmRXNWtJQ3NnYzJWc1ppNTJiM1JwYm1kZlpIVnlZWFJwYjI1ZmNtOTFibVJ6S1N3S0lDQWdJQzh2SUNBZ0lDQnlaWE52YkhWMGFXOXVYM0p2ZFc1a1BVRlNRelJWU1c1ME5qUW9NQ2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TWpReENpQWdJQ0F2THlCeVpXRnpiMjQ5UVZKRE5GTjBjbWx1WnlnaVVHOXNhV041SUhObGRIUnNaVzFsYm5RZ1pHbHpjSFYwWlNJcExDQWdJeUJFWldaaGRXeDBJSEpsWVhOdmJnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXhPVFV3Tm1ZMll6WTVOak0zT1RJd056TTJOVGMwTnpRMll6WTFObVEyTlRabE56UXlNRFkwTmprM016Y3dOelUzTkRZMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRveU16Z3RNalE1Q2lBZ0lDQXZMeUJrYVhOd2RYUmxYMlJoZEdFZ1BTQkVhWE53ZFhSbFJHRjBZU2dLSUNBZ0lDOHZJQ0FnSUNCd2IyeHBZM2xmYVdROWNHOXNhV041WDJsa0xBb2dJQ0FnTHk4Z0lDQWdJR05zWVdsdFlXNTBQV05oYkd4bGNpd0tJQ0FnSUM4dklDQWdJQ0J5WldGemIyNDlRVkpETkZOMGNtbHVaeWdpVUc5c2FXTjVJSE5sZEhSc1pXMWxiblFnWkdsemNIVjBaU0lwTENBZ0l5QkVaV1poZFd4MElISmxZWE52YmdvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTlRVkpETkZWSmJuUTJOQ2hqZFhKeVpXNTBYM0p2ZFc1a0tTd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlRVkpETkZWSmJuUTJOQ2d3S1N3Z0lDTWdRV04wYVhabENpQWdJQ0F2THlBZ0lDQWdlV1Z6WDNadmRHVnpQVUZTUXpSVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdibTlmZG05MFpYTTlRVkpETkZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5MmIzUmxjejFCVWtNMFZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSFp2ZEdsdVoxOWtaV0ZrYkdsdVpUMUJVa00wVlVsdWREWTBLR04xY25KbGJuUmZjbTkxYm1RZ0t5QnpaV3htTG5admRHbHVaMTlrZFhKaGRHbHZibDl5YjNWdVpITXBMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyOXNkWFJwYjI1ZmNtOTFibVE5UVZKRE5GVkpiblEyTkNnd0tRb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3lOVEVLSUNBZ0lDOHZJSE5sYkdZdVpHbHpjSFYwWlhOYlpHbHpjSFYwWlY5cFpGMGdQU0JrYVhOd2RYUmxYMlJoZEdFdVkyOXdlU2dwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlaR2x6Y0hWMFpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRveU56UXRNamMxQ2lBZ0lDQXZMeUFqSUVsbUlIZGxJR1J2YmlkMElHaGhkbVVnWlc1dmRXZG9JR3AxY205eWN5d2djMlZzWldOMElHRnNiQ0JoZG1GcGJHRmliR1VLSUNBZ0lDOHZJR2xtSUhObGJHWXVkRzkwWVd4ZmFuVnliM0p6SUR3OUlGVkpiblEyTkNneE1DazZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRHOTBZV3hmYW5WeWIzSnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMnAxY205eWN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk15QXZMeUF4TUFvZ0lDQWdQRDBLSUNBZ0lHSjZJR055WldGMFpWOWthWE53ZFhSbFgyVnNjMlZmWW05a2VVQXhNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNamMyTFRJM053b2dJQ0FnTHk4Z0l5QlRhVzF3YkdVZ2MyVnNaV04wYVc5dU9pQnBkR1Z5WVhSbElIUm9jbTkxWjJnZ1lXeHNJR3AxY205eWN3b2dJQ0FnTHk4Z2FuVnliM0pmYVc1a1pYZ2dQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtDbU55WldGMFpWOWthWE53ZFhSbFgzZG9hV3hsWDNSdmNFQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNamM0Q2lBZ0lDQXZMeUIzYUdsc1pTQnFkWEp2Y2w5cGJtUmxlQ0E4SUhObGJHWXVkRzkwWVd4ZmFuVnliM0p6SUdGdVpDQnpaV3hsWTNSbFpGOWpiM1Z1ZENBOElGVkpiblEyTkNneE1DazZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRHOTBZV3hmYW5WeWIzSnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMnAxY205eWN5QmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQStDaUFnSUNCaWVpQmpjbVZoZEdWZlpHbHpjSFYwWlY5aFpuUmxjbDlwWmw5bGJITmxRREU0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG95TnprS0lDQWdJQzh2SUdwMWNtOXlYMmx1WkdWNElDczlJRlZKYm5RMk5DZ3hLUW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHSWdZM0psWVhSbFgyUnBjM0IxZEdWZmQyaHBiR1ZmZEc5d1FEVUtDbU55WldGMFpWOWthWE53ZFhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvek1EVUtJQ0FnSUM4dklITmxiR1l1WkdsemNIVjBaVjlxZFhKdmNuTmJaR2x6Y0hWMFpWOXBaRjBnUFNCelpXeGxZM1JsWkY5cWRYSnZjbk1LSUNBZ0lIQjFjMmhpZVhSbGN5QWlaR2x6Y0hWMFpWOXFkWEp2Y25NaUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3lOekFLSUNBZ0lDOHZJSE5sYkdWamRHVmtYMnAxY205eWN5QTlJRUo1ZEdWektHSWlJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNekExQ2lBZ0lDQXZMeUJ6Wld4bUxtUnBjM0IxZEdWZmFuVnliM0p6VzJScGMzQjFkR1ZmYVdSZElEMGdjMlZzWldOMFpXUmZhblZ5YjNKekNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3lOVFl0TWpVM0NpQWdJQ0F2THlBaklGVndaR0YwWlNCemRHRjBhWE4wYVdOekNpQWdJQ0F2THlCelpXeG1MbDkxY0dSaGRHVmZjM1JoZEhNb1UzUnlhVzVuS0NKa2FYTndkWFJsWDJOeVpXRjBaV1FpS1NrS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKa2FYTndkWFJsWDJOeVpXRjBaV1FpQ2lBZ0lDQmpZV3hzYzNWaUlGOTFjR1JoZEdWZmMzUmhkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPakkxT1MweU5qQUtJQ0FnSUM4dklDTWdURzluSUdScGMzQjFkR1VnWTNKbFlYUnBiMjRnWlhabGJuUUtJQ0FnSUM4dklITmxiR1l1WDJ4dloxOWxkbVZ1ZENoQlVrTTBWVWx1ZERZMEtHUnBjM0IxZEdWZmFXUXBMQ0JqWVd4c1pYSXNJRUZTUXpSVGRISnBibWNvSW1ScGMzQjFkR1ZmWTNKbFlYUmxaQ0lwTENCQlVrTTBWVWx1ZERZMEtEQXBLUW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREJtTmpRMk9UY3pOekEzTlRjME5qVTFaall6TnpJMk5UWXhOelEyTlRZMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMkZzYkhOMVlpQmZiRzluWDJWMlpXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3lOakl0TWpZekNpQWdJQ0F2THlBaklFVnRhWFFnYkc5bklHWnZjaUJsZUhSbGNtNWhiQ0J0YjI1cGRHOXlhVzVuQ2lBZ0lDQXZMeUJzYjJjb1FubDBaWE1vWWlKRVNWTlFWVlJGWDBOU1JVRlVSVVFpS1NBcklFSjVkR1Z6S0dJaVpHbHpjSFYwWlY5cFpEb2lLU0FySUdOaGJHeGxjaTVpZVhSbGN5a0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUTBORGsxTXpVd05UVTFORFExTldZME16VXlORFUwTVRVME5EVTBORFkwTmprM016Y3dOelUzTkRZMU5XWTJPVFkwTTJFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRveU5qVUtJQ0FnSUM4dklISmxkSFZ5YmlCQlVrTTBWVWx1ZERZMEtHUnBjM0IxZEdWZmFXUXBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWTNKbFlYUmxYMlJwYzNCMWRHVmZaV3h6WlY5aWIyUjVRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TWpreExUSTVNd29nSUNBZ0x5OGdJeUJCWkhaaGJtTmxaQ0J6Wld4bFkzUnBiMjQ2SUhObGJHVmpkQ0JpWVhObFpDQnZiaUJ5WlhCMWRHRjBhVzl1SUdGdVpDQmhZM1JwZG1sMGVRb2dJQ0FnTHk4Z0l5QkdiM0lnYm05M0xDQnpaV3hsWTNRZ1ptbHljM1FnTVRBZ2FuVnliM0p6SUNoM2IzVnNaQ0JpWlNCcGJYQnliM1psWkNCM2FYUm9JSEJ5YjNCbGNpQnBkR1Z5WVhScGIyNHBDaUFnSUNBdkx5QnFkWEp2Y2w5cGJtUmxlQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9LWTNKbFlYUmxYMlJwYzNCMWRHVmZkMmhwYkdWZmRHOXdRREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TWprMENpQWdJQ0F2THlCM2FHbHNaU0J6Wld4bFkzUmxaRjlqYjNWdWRDQThJRlZKYm5RMk5DZ3hNQ2tnWVc1a0lHcDFjbTl5WDJsdVpHVjRJRHdnYzJWc1ppNTBiM1JoYkY5cWRYSnZjbk02Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzkwWVd4ZmFuVnliM0p6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJwMWNtOXljeUJsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0ErQ2lBZ0lDQmllaUJqY21WaGRHVmZaR2x6Y0hWMFpWOWhablJsY2w5cFpsOWxiSE5sUURFNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRveU9UVUtJQ0FnSUM4dklHcDFjbTl5WDJsdVpHVjRJQ3M5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR0lnWTNKbFlYUmxYMlJwYzNCMWRHVmZkMmhwYkdWZmRHOXdRREV5Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUnBjM0IxZEdVdVkyOXVkSEpoWTNRdVFXZHlhVWQxWVhKa1JHbHpjSFYwWlM1MmIzUmxYMjl1WDJScGMzQjFkR1VvWkdsemNIVjBaVjlwWkRvZ1lubDBaWE1zSUhadmRHVTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tkbTkwWlY5dmJsOWthWE53ZFhSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk16RTFMVE14TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlIWnZkR1ZmYjI1ZlpHbHpjSFYwWlNoelpXeG1MQ0JrYVhOd2RYUmxYMmxrT2lCQlVrTTBWVWx1ZERZMExDQjJiM1JsT2lCQlVrTTBWVWx1ZERZMEtTQXRQaUJCVWtNMFZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWkhWd2JpQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3pNVGdLSUNBZ0lDOHZJR05oYkd4bGNpQTlJRUZrWkhKbGMzTXVabkp2YlY5aWVYUmxjeWhVZUc0dWMyVnVaR1Z5TG1KNWRHVnpLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk16RTVDaUFnSUNBdkx5QmthWE53ZFhSbFgybGtYM1ZwYm5RZ1BTQmthWE53ZFhSbFgybGtMbTVoZEdsMlpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvek1qQUtJQ0FnSUM4dklHTjFjbkpsYm5SZmNtOTFibVFnUFNCSGJHOWlZV3d1Y205MWJtUUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk16SXlMVE15TXdvZ0lDQWdMeThnSXlCRmJtaGhibU5sWkNCa2FYTndkWFJsSUhaaGJHbGtZWFJwYjI0S0lDQWdJQzh2SUdScGMzQjFkR1ZmWkdGMFlTQTlJSE5sYkdZdVpHbHpjSFYwWlhNdWJXRjVZbVVvWkdsemNIVjBaVjlwWkY5MWFXNTBLVnN3WFM1amIzQjVLQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbVJwYzNCMWRHVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pNeU5nb2dJQ0FnTHk4Z2FXWWdibTkwSUdScGMzQjFkR1ZmWlhocGMzUnpPZ29nSUNBZ1ltNTZJSFp2ZEdWZmIyNWZaR2x6Y0hWMFpWOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pNeU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUVGU1F6UlZTVzUwTmpRb01Da2dJQ01nUkdsemNIVjBaU0J1YjNRZ1ptOTFibVFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LZG05MFpWOXZibDlrYVhOd2RYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qTXlPUzB6TXpBS0lDQWdJQzh2SUNNZ1ZHbHRaUzFpWVhObFpDQjJZV3hwWkdGMGFXOXVDaUFnSUNBdkx5QnBaaUJqZFhKeVpXNTBYM0p2ZFc1a0lENGdaR2x6Y0hWMFpWOWtZWFJoTG5admRHbHVaMTlrWldGa2JHbHVaUzV1WVhScGRtVTZDaUFnSUNCbWNtRnRaVjlrYVdjZ053b2dJQ0FnY0hWemFHbHVkQ0E0TWlBdkx5QTRNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHWnlZVzFsWDJScFp5QTFDaUFnSUNBOENpQWdJQ0JpZWlCMmIzUmxYMjl1WDJScGMzQjFkR1ZmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3pNekVLSUNBZ0lDOHZJSEpsZEhWeWJpQkJVa00wVlVsdWREWTBLREFwSUNBaklGWnZkR2x1WnlCd1pYSnBiMlFnWlhod2FYSmxaQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3AyYjNSbFgyOXVYMlJwYzNCMWRHVmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk16TXpDaUFnSUNBdkx5QnBaaUJrYVhOd2RYUmxYMlJoZEdFdWMzUmhkSFZ6TG01aGRHbDJaU0FoUFNCVlNXNTBOalFvTUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTndvZ0lDQWdhVzUwWTE4eUlDOHZJRFV3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZbm9nZG05MFpWOXZibDlrYVhOd2RYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk16TTBDaUFnSUNBdkx5QnlaWFIxY200Z1FWSkRORlZKYm5RMk5DZ3dLU0FnSXlCRWFYTndkWFJsSUdGc2NtVmhaSGtnY21WemIyeDJaV1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LZG05MFpWOXZibDlrYVhOd2RYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qTXpOaTB6TXpjS0lDQWdJQzh2SUNNZ1JXNW9ZVzVqWldRZ2FuVnliM0lnZG1Gc2FXUmhkR2x2YmdvZ0lDQWdMeThnYW5WeWIzSmZaR0YwWVNBOUlITmxiR1l1YW5WeWIzSnpMbTFoZVdKbEtHTmhiR3hsY2lsYk1GMHVZMjl3ZVNncENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKcWRYSnZjbk1pQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG96TkRBS0lDQWdJQzh2SUdsbUlHNXZkQ0JxZFhKdmNsOWxlR2x6ZEhNNkNpQWdJQ0JpYm5vZ2RtOTBaVjl2Ymw5a2FYTndkWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNelF4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRVkpETkZWSmJuUTJOQ2d3S1NBZ0l5Qk9iM1FnWVNCeVpXZHBjM1JsY21Wa0lHcDFjbTl5Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ25admRHVmZiMjVmWkdsemNIVjBaVjloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3pORE10TXpRMENpQWdJQ0F2THlBaklFTm9aV05ySUdsbUlHcDFjbTl5SUdseklHRnpjMmxuYm1Wa0lIUnZJSFJvYVhNZ1pHbHpjSFYwWlFvZ0lDQWdMeThnYW5WeWIzSmZaR2x6Y0hWMFpWOXJaWGtnUFNCallXeHNaWEl1WW5sMFpYTWdLeUJDZVhSbGN5aGlJbVJwYzNCMWRHVWlLUW9nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdKNWRHVmpJREl6SUM4dklEQjROalEyT1Rjek56QTNOVGMwTmpVS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk16UTFDaUFnSUNBdkx5QnBjMTloYzNOcFoyNWxaQ0E5SUhObGJHWXVhblZ5YjNKZlpHbHpjSFYwWlhNdWJXRjVZbVVvYW5WeWIzSmZaR2x6Y0hWMFpWOXJaWGtwV3pGZENpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaWFuVnliM0pmWkdsemNIVjBaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNelEzQ2lBZ0lDQXZMeUJwWmlCdWIzUWdhWE5mWVhOemFXZHVaV1E2Q2lBZ0lDQmlibm9nZG05MFpWOXZibDlrYVhOd2RYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU1UQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qTTBPQW9nSUNBZ0x5OGdjbVYwZFhKdUlFRlNRelJWU1c1ME5qUW9NQ2tnSUNNZ1NuVnliM0lnYm05MElHRnpjMmxuYm1Wa0lIUnZJSFJvYVhNZ1pHbHpjSFYwWlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwMmIzUmxYMjl1WDJScGMzQjFkR1ZmWVdaMFpYSmZhV1pmWld4elpVQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPak0xTUMwek5URUtJQ0FnSUM4dklDTWdRMmhsWTJzZ2RtOTBhVzVuSUdWc2FXZHBZbWxzYVhSNUlDaHlaV05sYm5RZ1lXTjBhWFpwZEhrZ2NtVnhkV2x5WlcxbGJuUXBDaUFnSUNBdkx5QnliM1Z1WkhOZmMybHVZMlZmYkdGemRGOTJiM1JsSUQwZ1kzVnljbVZ1ZEY5eWIzVnVaQ0F0SUdwMWNtOXlYMlJoZEdFdWJHRnpkRjkyYjNSbFgzSnZkVzVrTG01aGRHbDJaUW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTmpRZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOUW9nSUNBZ2MzZGhjQW9nSUNBZ0xRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk16VXlDaUFnSUNBdkx5QmhjM05sY25RZ2NtOTFibVJ6WDNOcGJtTmxYMnhoYzNSZmRtOTBaU0ErUFNCVlNXNTBOalFvTVRBcExDQWlTblZ5YjNJZ2RtOTBaV1FnZEc5dklISmxZMlZ1ZEd4NUlnb2dJQ0FnYVc1MFkxOHpJQzh2SURFd0NpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRXAxY205eUlIWnZkR1ZrSUhSdmJ5QnlaV05sYm5Sc2VRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk16VTBMVE0xTlFvZ0lDQWdMeThnSXlCRGFHVmpheUJwWmlCallXeHNaWElnWVd4eVpXRmtlU0IyYjNSbFpDQW9aVzVvWVc1alpXUWdhMlY1SUhOMGNuVmpkSFZ5WlNrS0lDQWdJQzh2SUhadmRHVmZhMlY1SUQwZ1FubDBaWE1vWWlKa2FYTndkWFJsSWlrZ0t5QmpZV3hzWlhJdVlubDBaWE1LSUNBZ0lHSjVkR1ZqSURJeklDOHZJREI0TmpRMk9UY3pOekEzTlRjME5qVUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qTTFOZ29nSUNBZ0x5OGdaWGhwYzNScGJtZGZkbTkwWlNBOUlITmxiR1l1YW5WeWIzSmZkbTkwWlhNdWJXRjVZbVVvZG05MFpWOXJaWGtwV3pGZENpQWdJQ0J3ZFhOb1lubDBaWE1nSW1wMWNtOXlYM1p2ZEdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG96TlRnS0lDQWdJQzh2SUdsbUlHVjRhWE4wYVc1blgzWnZkR1U2Q2lBZ0lDQmllaUIyYjNSbFgyOXVYMlJwYzNCMWRHVmZZV1owWlhKZmFXWmZaV3h6WlVBeE1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk16VTVDaUFnSUNBdkx5QnlaWFIxY200Z1FWSkRORlZKYm5RMk5DZ3dLU0FnSXlCQmJISmxZV1I1SUhadmRHVmtDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDblp2ZEdWZmIyNWZaR2x6Y0hWMFpWOWhablJsY2w5cFpsOWxiSE5sUURFeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk16WTFDaUFnSUNBdkx5QjBhVzFsYzNSaGJYQTlRVkpETkZWSmJuUTJOQ2hqZFhKeVpXNTBYM0p2ZFc1a0tTd0tJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TXpZeExUTTJOd29nSUNBZ0x5OGdJeUJTWldOdmNtUWdaVzVvWVc1alpXUWdkbTkwWlNCa1lYUmhDaUFnSUNBdkx5QjJiM1JsWDJSaGRHRWdQU0JXYjNSbFJHRjBZU2dLSUNBZ0lDOHZJQ0FnSUNCcWRYSnZjajFqWVd4c1pYSXNDaUFnSUNBdkx5QWdJQ0FnZG05MFpUMTJiM1JsTEFvZ0lDQWdMeThnSUNBZ0lIUnBiV1Z6ZEdGdGNEMUJVa00wVlVsdWREWTBLR04xY25KbGJuUmZjbTkxYm1RcExBb2dJQ0FnTHk4Z0lDQWdJR1JwYzNCMWRHVmZhV1E5WkdsemNIVjBaVjlwWkFvZ0lDQWdMeThnS1FvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvek5qa0tJQ0FnSUM4dklITmxiR1l1YW5WeWIzSmZkbTkwWlhOYmRtOTBaVjlyWlhsZElEMGdkbTkwWlY5a1lYUmhMbU52Y0hrb0tRb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qTTNNUzB6TnpJS0lDQWdJQzh2SUNNZ1ZYQmtZWFJsSUdScGMzQjFkR1VnZG05MFpTQmpiM1Z1ZEhNZ2QybDBhQ0JsYm1oaGJtTmxaQ0IwY21GamEybHVad29nSUNBZ0x5OGdhV1lnZG05MFpTNXVZWFJwZG1VZ1BUMGdWVWx1ZERZMEtERXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUhadmRHVmZiMjVmWkdsemNIVjBaVjlsYkhObFgySnZaSGxBTVRRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pNM013b2dJQ0FnTHk4Z1pHbHpjSFYwWlY5a1lYUmhMbmxsYzE5MmIzUmxjeUE5SUVGU1F6UlZTVzUwTmpRb1pHbHpjSFYwWlY5a1lYUmhMbmxsYzE5MmIzUmxjeTV1WVhScGRtVWdLeUF4S1FvZ0lDQWdabkpoYldWZlpHbG5JRGNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBMU9DQXZMeUExT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBMU9Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBM0NncDJiM1JsWDI5dVgyUnBjM0IxZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF4TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pNM053b2dJQ0FnTHk4Z1pHbHpjSFYwWlY5a1lYUmhMblJ2ZEdGc1gzWnZkR1Z6SUQwZ1FWSkRORlZKYm5RMk5DaGthWE53ZFhSbFgyUmhkR0V1ZEc5MFlXeGZkbTkwWlhNdWJtRjBhWFpsSUNzZ01Ta0tJQ0FnSUdaeVlXMWxYMlJwWnlBM0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOelFnTHk4Z056UUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdOelFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3pOemdLSUNBZ0lDOHZJSE5sYkdZdVpHbHpjSFYwWlhOYlpHbHpjSFYwWlY5cFpGOTFhVzUwWFNBOUlHUnBjM0IxZEdWZlpHRjBZUzVqYjNCNUtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBMkNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPak00TUMwek9ERUtJQ0FnSUM4dklDTWdWWEJrWVhSbElHcDFjbTl5SUdGamRHbDJhWFI1Q2lBZ0lDQXZMeUJxZFhKdmNsOWtZWFJoTG14aGMzUmZkbTkwWlY5eWIzVnVaQ0E5SUVGU1F6UlZTVzUwTmpRb1kzVnljbVZ1ZEY5eWIzVnVaQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnY21Wd2JHRmpaVElnTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pNNE1nb2dJQ0FnTHk4Z2FuVnliM0pmWkdGMFlTNTBiM1JoYkY5MmIzUmxjeUE5SUVGU1F6UlZTVzUwTmpRb2FuVnliM0pmWkdGMFlTNTBiM1JoYkY5MmIzUmxjeTV1WVhScGRtVWdLeUF4S1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEUXdJQzh2SURRd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEUXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3pPRE1LSUNBZ0lDOHZJSE5sYkdZdWFuVnliM0p6VzJOaGJHeGxjbDBnUFNCcWRYSnZjbDlrWVhSaExtTnZjSGtvS1FvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pNNE5TMHpPRFlLSUNBZ0lDOHZJQ01nUTJobFkyc2dhV1lnZDJVZ2FHRjJaU0JsYm05MVoyZ2dkbTkwWlhNZ2RHOGdjbVZ6YjJ4MlpTQW9aVzVvWVc1alpXUWdiRzluYVdNcENpQWdJQ0F2THlCMGIzUmhiRjkyYjNSbGN5QTlJR1JwYzNCMWRHVmZaR0YwWVM1MGIzUmhiRjkyYjNSbGN5NXVZWFJwZG1VS0lDQWdJSEIxYzJocGJuUWdOelFnTHk4Z056UUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3pPRGNLSUNBZ0lDOHZJR2xtSUhSdmRHRnNYM1p2ZEdWeklENDlJRGM2SUNBaklFNWxaV1FnWVhRZ2JHVmhjM1FnTnlCMmIzUmxjd29nSUNBZ2NIVnphR2x1ZENBM0lDOHZJRGNLSUNBZ0lENDlDaUFnSUNCaWVpQjJiM1JsWDI5dVgyUnBjM0IxZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF5TlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TXpnNENpQWdJQ0F2THlCcFppQmthWE53ZFhSbFgyUmhkR0V1ZVdWelgzWnZkR1Z6TG01aGRHbDJaU0ErUFNBME9pQWdJeUJUYVcxd2JHVWdiV0ZxYjNKcGRIa0tJQ0FnSUdaeVlXMWxYMlJwWnlBM0NpQWdJQ0J3ZFhOb2FXNTBJRFU0SUM4dklEVTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJRFFLSUNBZ0lENDlDaUFnSUNCaWVpQjJiM1JsWDI5dVgyUnBjM0IxZEdWZlpXeHpaVjlpYjJSNVFERTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUb3pPRGtLSUNBZ0lDOHZJR1JwYzNCMWRHVmZaR0YwWVM1emRHRjBkWE1nUFNCQlVrTTBWVWx1ZERZMEtERXBJQ0FqSUZKbGMyOXNkbVZrSUNoaGNIQnliM1psWkNrS0lDQWdJR1p5WVcxbFgyUnBaeUEzQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNUW9nSUNBZ2NtVndiR0ZqWlRJZ05UQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qTTVNQW9nSUNBZ0x5OGdaR2x6Y0hWMFpWOWtZWFJoTG5KbGMyOXNkWFJwYjI1ZmNtOTFibVFnUFNCQlVrTTBWVWx1ZERZMEtHTjFjbkpsYm5SZmNtOTFibVFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ2NtVndiR0ZqWlRJZ09UQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ053b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk16a3hDaUFnSUNBdkx5QnpaV3htTGw5MWNHUmhkR1ZmYzNSaGRITW9VM1J5YVc1bktDSmthWE53ZFhSbFgzSmxjMjlzZG1Wa0lpa3BDaUFnSUNCaWVYUmxZeUF4T0NBdkx5QWlaR2x6Y0hWMFpWOXlaWE52YkhabFpDSUtJQ0FnSUdOaGJHeHpkV0lnWDNWd1pHRjBaVjl6ZEdGMGN3b0tkbTkwWlY5dmJsOWthWE53ZFhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvek9UY0tJQ0FnSUM4dklITmxiR1l1WkdsemNIVjBaWE5iWkdsemNIVjBaVjlwWkY5MWFXNTBYU0E5SUdScGMzQjFkR1ZmWkdGMFlTNWpiM0I1S0NrS0lDQWdJR1p5WVcxbFgyUnBaeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlpHbG5JRGNLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk16azVMVFF3TUFvZ0lDQWdMeThnSXlCTWIyY2djbVZ6YjJ4MWRHbHZiaUJsZG1WdWRBb2dJQ0FnTHk4Z2NtVnpiMngxZEdsdmJsOWhZM1JwYjI0Z1BTQkJVa00wVTNSeWFXNW5LQ0prYVhOd2RYUmxYM0psYzI5c2RtVmtJaWtnYVdZZ1pHbHpjSFYwWlY5a1lYUmhMbk4wWVhSMWN5NXVZWFJwZG1VZ1BUMGdWVWx1ZERZMEtERXBJR1ZzYzJVZ1FWSkRORk4wY21sdVp5Z2laR2x6Y0hWMFpWOXlaV3BsWTNSbFpDSXBDaUFnSUNCcGJuUmpYeklnTHk4Z05UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUhadmRHVmZiMjVmWkdsemNIVjBaVjkwWlhKdVlYSjVYMlpoYkhObFFESXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREV3TmpRMk9UY3pOekEzTlRjME5qVTFaamN5TmpVM016Wm1ObU0zTmpZMU5qUUtDblp2ZEdWZmIyNWZaR2x6Y0hWMFpWOTBaWEp1WVhKNVgyMWxjbWRsUURJeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk5EQXhDaUFnSUNBdkx5QnpaV3htTGw5c2IyZGZaWFpsYm5Rb1pHbHpjSFYwWlY5cFpDd2dZMkZzYkdWeUxDQnlaWE52YkhWMGFXOXVYMkZqZEdsdmJpd2dkbTkwWlNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRjlzYjJkZlpYWmxiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalF3TXkwME1EUUtJQ0FnSUM4dklDTWdRM0p2YzNNdFkyOXVkSEpoWTNRZ1kyOXRiWFZ1YVdOaGRHbHZiam9nVkhKcFoyZGxjaUJ3WVhsdmRYUWdkbWxoSUdsdWMzVnlZVzVqWlNCamIyNTBjbUZqZEFvZ0lDQWdMeThnYVdZZ2MyVnNaaTVwYm5OMWNtRnVZMlZmWTI5dWRISmhZM1FnSVQwZ1FXUmtjbVZ6Y3loSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOektUb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKcGJuTjFjbUZ1WTJWZlkyOXVkSEpoWTNRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhVzV6ZFhKaGJtTmxYMk52Ym5SeVlXTjBJR1Y0YVhOMGN3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQWhQUW9nSUNBZ1lub2dkbTkwWlY5dmJsOWthWE53ZFhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pReU9TMDBNekFLSUNBZ0lDOHZJQ01nUTNKbFlYUmxJR3h2WnlCbGRtVnVkQ0JtYjNJZ1pYaDBaWEp1WVd3Z2JXOXVhWFJ2Y21sdVp5QnZaaUJqY205emN5MWpiMjUwY21GamRDQmpZV3hzQ2lBZ0lDQXZMeUJzYjJjb1FubDBaWE1vWWlKRFVrOVRVMTlEVDA1VVVrRkRWRjlUUlZSVVRFVk5SVTVVSWlrZ0t5QkNlWFJsY3loaUluTmxkSFJzWlcxbGJuUmZkSEpwWjJkbGNtVmtJaWtwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwTXpVeU5HWTFNelV6TldZME16Um1OR1UxTkRVeU5ERTBNelUwTldZMU16UTFOVFExTkRSak5EVTBaRFExTkdVMU5EY3pOalUzTkRjME5tTTJOVFprTmpVMlpUYzBOV1kzTkRjeU5qazJOelkzTmpVM01qWTFOalFLSUNBZ0lHeHZad29LZG05MFpWOXZibDlrYVhOd2RYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU1qUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzBNRGN0TkRBNENpQWdJQ0F2THlBaklFVnRhWFFnYkc5bklHWnZjaUJsZUhSbGNtNWhiQ0J0YjI1cGRHOXlhVzVuQ2lBZ0lDQXZMeUJzYjJjb1FubDBaWE1vWWlKRVNWTlFWVlJGWDFKRlUwOU1Wa1ZFSWlrZ0t5QmpZV3hzWlhJdVlubDBaWE1wQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwTkRRNU5UTTFNRFUxTlRRME5UVm1OVEkwTlRVek5HWTBZelUyTkRVME5Bb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNncDJiM1JsWDI5dVgyUnBjM0IxZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF5TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pReE1DMDBNVEVLSUNBZ0lDOHZJQ01nVlhCa1lYUmxJSE4wWVhScGMzUnBZM01nWVc1a0lHeHZaeUIyYjNSbElHVjJaVzUwQ2lBZ0lDQXZMeUJ6Wld4bUxsOTFjR1JoZEdWZmMzUmhkSE1vVTNSeWFXNW5LQ0oyYjNSbFgyTmhjM1FpS1NrS0lDQWdJR0o1ZEdWaklESXhJQzh2SUNKMmIzUmxYMk5oYzNRaUNpQWdJQ0JqWVd4c2MzVmlJRjkxY0dSaGRHVmZjM1JoZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pReE1nb2dJQ0FnTHk4Z2MyVnNaaTVmYkc5blgyVjJaVzUwS0dScGMzQjFkR1ZmYVdRc0lHTmhiR3hsY2l3Z1FWSkRORk4wY21sdVp5Z2lkbTkwWlY5allYTjBJaWtzSUhadmRHVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQTVOelkyWmpjME5qVTFaall6TmpFM016YzBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDJ4dloxOWxkbVZ1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TkRFMENpQWdJQ0F2THlCeVpYUjFjbTRnUVZKRE5GVkpiblEyTkNneEtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncDJiM1JsWDI5dVgyUnBjM0IxZEdWZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pNNU9TMDBNREFLSUNBZ0lDOHZJQ01nVEc5bklISmxjMjlzZFhScGIyNGdaWFpsYm5RS0lDQWdJQzh2SUhKbGMyOXNkWFJwYjI1ZllXTjBhVzl1SUQwZ1FWSkRORk4wY21sdVp5Z2laR2x6Y0hWMFpWOXlaWE52YkhabFpDSXBJR2xtSUdScGMzQjFkR1ZmWkdGMFlTNXpkR0YwZFhNdWJtRjBhWFpsSUQwOUlGVkpiblEyTkNneEtTQmxiSE5sSUVGU1F6UlRkSEpwYm1jb0ltUnBjM0IxZEdWZmNtVnFaV04wWldRaUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXhNRFkwTmprM016Y3dOelUzTkRZMU5XWTNNalkxTm1FMk5UWXpOelEyTlRZMENpQWdJQ0JpSUhadmRHVmZiMjVmWkdsemNIVjBaVjkwWlhKdVlYSjVYMjFsY21kbFFESXlDZ3AyYjNSbFgyOXVYMlJwYzNCMWRHVmZaV3h6WlY5aWIyUjVRREU0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TXprekNpQWdJQ0F2THlCa2FYTndkWFJsWDJSaGRHRXVjM1JoZEhWeklEMGdRVkpETkZWSmJuUTJOQ2d5S1NBZ0l5QlNaV3BsWTNSbFpBb2dJQ0FnWm5KaGJXVmZaR2xuSURjS0lDQWdJR0o1ZEdWaklESTBJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TWdvZ0lDQWdjbVZ3YkdGalpUSWdOVEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPak01TkFvZ0lDQWdMeThnWkdsemNIVjBaVjlrWVhSaExuSmxjMjlzZFhScGIyNWZjbTkxYm1RZ1BTQkJVa00wVlVsdWREWTBLR04xY25KbGJuUmZjbTkxYm1RcENpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdjbVZ3YkdGalpUSWdPVEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZNemsxQ2lBZ0lDQXZMeUJ6Wld4bUxsOTFjR1JoZEdWZmMzUmhkSE1vVTNSeWFXNW5LQ0prYVhOd2RYUmxYM0psYW1WamRHVmtJaWtwQ2lBZ0lDQmllWFJsWXlBeE9TQXZMeUFpWkdsemNIVjBaVjl5WldwbFkzUmxaQ0lLSUNBZ0lHTmhiR3h6ZFdJZ1gzVndaR0YwWlY5emRHRjBjd29nSUNBZ1lpQjJiM1JsWDI5dVgyUnBjM0IxZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF4T1FvS2RtOTBaVjl2Ymw5a2FYTndkWFJsWDJWc2MyVmZZbTlrZVVBeE5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qTTNOUW9nSUNBZ0x5OGdaR2x6Y0hWMFpWOWtZWFJoTG01dlgzWnZkR1Z6SUQwZ1FWSkRORlZKYm5RMk5DaGthWE53ZFhSbFgyUmhkR0V1Ym05ZmRtOTBaWE11Ym1GMGFYWmxJQ3NnTVNrS0lDQWdJR1p5WVcxbFgyUnBaeUEzQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05qWWdMeThnTmpZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ05qWUtJQ0FnSUdaeVlXMWxYMkoxY25rZ053b2dJQ0FnWWlCMmIzUmxYMjl1WDJScGMzQjFkR1ZmWVdaMFpYSmZhV1pmWld4elpVQXhOUW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1a2FYTndkWFJsTG1OdmJuUnlZV04wTGtGbmNtbEhkV0Z5WkVScGMzQjFkR1V1WjJWMFgyUnBjM0IxZEdVb1pHbHpjSFYwWlY5cFpEb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncG5aWFJmWkdsemNIVjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalF6TWkwME16TUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQm5aWFJmWkdsemNIVjBaU2h6Wld4bUxDQmthWE53ZFhSbFgybGtPaUJCVWtNMFZVbHVkRFkwS1NBdFBpQkVhWE53ZFhSbFJHRjBZVG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk5ETTFDaUFnSUNBdkx5QmthWE53ZFhSbFgyUmhkR0VnUFNCelpXeG1MbVJwYzNCMWRHVnpMbTFoZVdKbEtHUnBjM0IxZEdWZmFXUXVibUYwYVhabEtWc3dYUzVqYjNCNUtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5SdmFRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVpHbHpjSFYwWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzBNemN0TkRNNENpQWdJQ0F2THlBaklFTm9aV05ySUdsbUlHUnBjM0IxZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJwWmlCa2FYTndkWFJsWDJSaGRHRXVZMnhoYVcxaGJuUWdQVDBnUVdSa2NtVnpjeWhIYkc5aVlXd3VlbVZ5YjE5aFpHUnlaWE56S1RvS0lDQWdJR1Y0ZEhKaFkzUWdPQ0F6TWlBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0o2SUdkbGRGOWthWE53ZFhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TkRNNUxUUTFNQW9nSUNBZ0x5OGdjbVYwZFhKdUlFUnBjM0IxZEdWRVlYUmhLQW9nSUNBZ0x5OGdJQ0FnSUhCdmJHbGplVjlwWkQxQlVrTTBWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lXbHRZVzUwUFVGa1pISmxjM01vUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3lrc0NpQWdJQ0F2THlBZ0lDQWdjbVZoYzI5dVBVRlNRelJUZEhKcGJtY29JaUlwTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTlRVkpETkZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQnpkR0YwZFhNOVFWSkRORlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCNVpYTmZkbTkwWlhNOVFWSkRORlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCdWIxOTJiM1JsY3oxQlVrTTBWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNYM1p2ZEdWelBVRlNRelJWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RtOTBhVzVuWDJSbFlXUnNhVzVsUFVGU1F6UlZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnY21WemIyeDFkR2x2Ymw5eWIzVnVaRDFCVWtNMFZVbHVkRFkwS0RBcENpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb1lubDBaWE1nWW1GelpUTXlLRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUWxKQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRXBDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ21kbGRGOWthWE53ZFhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pRMU1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdScGMzQjFkR1ZmWkdGMFlRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVrYVhOd2RYUmxMbU52Ym5SeVlXTjBMa0ZuY21sSGRXRnlaRVJwYzNCMWRHVXVaMlYwWDJwMWNtOXlYMmx1Wm04b2FuVnliM0pmWVdSa2NtVnpjem9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BuWlhSZmFuVnliM0pmYVc1bWJ6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qUTFOQzAwTlRVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lDOHZJR1JsWmlCblpYUmZhblZ5YjNKZmFXNW1ieWh6Wld4bUxDQnFkWEp2Y2w5aFpHUnlaWE56T2lCQlpHUnlaWE56S1NBdFBpQktkWEp2Y2tSaGRHRTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pRMU53b2dJQ0FnTHk4Z2FuVnliM0pmWkdGMFlTQTlJSE5sYkdZdWFuVnliM0p6TG0xaGVXSmxLR3AxY205eVgyRmtaSEpsYzNNcFd6QmRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWFuVnliM0p6SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qUTJNQW9nSUNBZ0x5OGdhV1lnYm05MElHVjRhWE4wY3pvS0lDQWdJR0p1ZWlCblpYUmZhblZ5YjNKZmFXNW1iMTloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qUTJNUzAwTmprS0lDQWdJQzh2SUhKbGRIVnliaUJLZFhKdmNrUmhkR0VvQ2lBZ0lDQXZMeUFnSUNBZ1lXUmtjbVZ6Y3oxcWRYSnZjbDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhKbGNIVjBZWFJwYjI0OVFWSkRORlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRjkyYjNSbGN6MUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHTnZjbkpsWTNSZmRtOTBaWE05UVZKRE5GVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J5WldkcGMzUnlZWFJwYjI1ZmNtOTFibVE5UVZKRE5GVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JzWVhOMFgzWnZkR1ZmY205MWJtUTlRVkpETkZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQnpkR0ZyWldSZllXMXZkVzUwUFVGU1F6UlZTVzUwTmpRb01Da0tJQ0FnSUM4dklDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk5EWXpDaUFnSUNBdkx5QnlaWEIxZEdGMGFXOXVQVUZTUXpSVlNXNTBOalFvTUNrc0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TkRZeExUUTJPUW9nSUNBZ0x5OGdjbVYwZFhKdUlFcDFjbTl5UkdGMFlTZ0tJQ0FnSUM4dklDQWdJQ0JoWkdSeVpYTnpQV3AxY205eVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ3ZFhSaGRHbHZiajFCVWtNMFZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gzWnZkR1Z6UFVGU1F6UlZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWTI5eWNtVmpkRjkyYjNSbGN6MUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lISmxaMmx6ZEhKaGRHbHZibDl5YjNWdVpEMUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHeGhjM1JmZG05MFpWOXliM1Z1WkQxQlVrTTBWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlXdGxaRjloYlc5MWJuUTlRVkpETkZWSmJuUTJOQ2d3S1FvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvME5qUUtJQ0FnSUM4dklIUnZkR0ZzWDNadmRHVnpQVUZTUXpSVlNXNTBOalFvTUNrc0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TkRZeExUUTJPUW9nSUNBZ0x5OGdjbVYwZFhKdUlFcDFjbTl5UkdGMFlTZ0tJQ0FnSUM4dklDQWdJQ0JoWkdSeVpYTnpQV3AxY205eVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ3ZFhSaGRHbHZiajFCVWtNMFZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gzWnZkR1Z6UFVGU1F6UlZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWTI5eWNtVmpkRjkyYjNSbGN6MUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lISmxaMmx6ZEhKaGRHbHZibDl5YjNWdVpEMUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHeGhjM1JmZG05MFpWOXliM1Z1WkQxQlVrTTBWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlXdGxaRjloYlc5MWJuUTlRVkpETkZWSmJuUTJOQ2d3S1FvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvME5qVUtJQ0FnSUM4dklHTnZjbkpsWTNSZmRtOTBaWE05UVZKRE5GVkpiblEyTkNnd0tTd0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvME5qRXRORFk1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdTblZ5YjNKRVlYUmhLQW9nSUNBZ0x5OGdJQ0FnSUdGa1pISmxjM005YW5WeWIzSmZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J5WlhCMWRHRjBhVzl1UFVGU1F6UlZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXeGZkbTkwWlhNOVFWSkRORlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCamIzSnlaV04wWDNadmRHVnpQVUZTUXpSVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdjbVZuYVhOMGNtRjBhVzl1WDNKdmRXNWtQVUZTUXpSVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdiR0Z6ZEY5MmIzUmxYM0p2ZFc1a1BVRlNRelJWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhhMlZrWDJGdGIzVnVkRDFCVWtNMFZVbHVkRFkwS0RBcENpQWdJQ0F2THlBcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qUTJOZ29nSUNBZ0x5OGdjbVZuYVhOMGNtRjBhVzl1WDNKdmRXNWtQVUZTUXpSVlNXNTBOalFvTUNrc0NpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TkRZeExUUTJPUW9nSUNBZ0x5OGdjbVYwZFhKdUlFcDFjbTl5UkdGMFlTZ0tJQ0FnSUM4dklDQWdJQ0JoWkdSeVpYTnpQV3AxY205eVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ3ZFhSaGRHbHZiajFCVWtNMFZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gzWnZkR1Z6UFVGU1F6UlZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWTI5eWNtVmpkRjkyYjNSbGN6MUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lISmxaMmx6ZEhKaGRHbHZibDl5YjNWdVpEMUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHeGhjM1JmZG05MFpWOXliM1Z1WkQxQlVrTTBWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlXdGxaRjloYlc5MWJuUTlRVkpETkZWSmJuUTJOQ2d3S1FvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvME5qY0tJQ0FnSUM4dklHeGhjM1JmZG05MFpWOXliM1Z1WkQxQlVrTTBWVWx1ZERZMEtEQXBMQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qUTJNUzAwTmprS0lDQWdJQzh2SUhKbGRIVnliaUJLZFhKdmNrUmhkR0VvQ2lBZ0lDQXZMeUFnSUNBZ1lXUmtjbVZ6Y3oxcWRYSnZjbDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhKbGNIVjBZWFJwYjI0OVFWSkRORlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRjkyYjNSbGN6MUJVa00wVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHTnZjbkpsWTNSZmRtOTBaWE05UVZKRE5GVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J5WldkcGMzUnlZWFJwYjI1ZmNtOTFibVE5UVZKRE5GVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JzWVhOMFgzWnZkR1ZmY205MWJtUTlRVkpETkZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQnpkR0ZyWldSZllXMXZkVzUwUFVGU1F6UlZTVzUwTmpRb01Da0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZORFk0Q2lBZ0lDQXZMeUJ6ZEdGclpXUmZZVzF2ZFc1MFBVRlNRelJWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzBOakV0TkRZNUNpQWdJQ0F2THlCeVpYUjFjbTRnU25WeWIzSkVZWFJoS0FvZ0lDQWdMeThnSUNBZ0lHRmtaSEpsYzNNOWFuVnliM0pmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCeVpYQjFkR0YwYVc5dVBVRlNRelJWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3hmZG05MFpYTTlRVkpETkZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmpiM0p5WldOMFgzWnZkR1Z6UFVGU1F6UlZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnY21WbmFYTjBjbUYwYVc5dVgzSnZkVzVrUFVGU1F6UlZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnYkdGemRGOTJiM1JsWDNKdmRXNWtQVUZTUXpSVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdjM1JoYTJWa1gyRnRiM1Z1ZEQxQlVrTTBWVWx1ZERZMEtEQXBDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lISmxkSE4xWWdvS1oyVjBYMnAxY205eVgybHVabTlmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZORGN4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdhblZ5YjNKZlpHRjBZUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1a2FYTndkWFJsTG1OdmJuUnlZV04wTGtGbmNtbEhkV0Z5WkVScGMzQjFkR1V1WjJWMFgzUnZkR0ZzWDJwMWNtOXljeWdwSUMwK0lHSjVkR1Z6T2dwblpYUmZkRzkwWVd4ZmFuVnliM0p6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TkRjMkNpQWdJQ0F2THlCeVpYUjFjbTRnUVZKRE5GVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gycDFjbTl5Y3lrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYjNSaGJGOXFkWEp2Y25NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmFuVnliM0p6SUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUnBjM0IxZEdVdVkyOXVkSEpoWTNRdVFXZHlhVWQxWVhKa1JHbHpjSFYwWlM1blpYUmZjM1JoZEdsemRHbGpjeWdwSUMwK0lHSjVkR1Z6T2dwblpYUmZjM1JoZEdsemRHbGpjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalE0TVFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWMzUmhkSE5mWW05NExuWmhiSFZsQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpYzNSaGRITmZZbTk0SWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMzUmhkSE5mWW05NElHVjRhWE4wY3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVJwYzNCMWRHVXVZMjl1ZEhKaFkzUXVRV2R5YVVkMVlYSmtSR2x6Y0hWMFpTNW5aWFJmWlhabGJuUW9aWFpsYm5SZmFXUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taMlYwWDJWMlpXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZORGd6TFRRNE5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjlsZG1WdWRDaHpaV3htTENCbGRtVnVkRjlwWkRvZ1FWSkRORlZKYm5RMk5Da2dMVDRnUkdsemNIVjBaVVYyWlc1ME9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG8wT0RZS0lDQWdJQzh2SUdWMlpXNTBJRDBnYzJWc1ppNWxkbVZ1ZEY5c2IyY3ViV0Y1WW1Vb1pYWmxiblJmYVdRdWJtRjBhWFpsS1Zzd1hTNWpiM0I1S0NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZblJ2YVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ01UWWdMeThnSW1WMlpXNTBYMnh2WnlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qUTROeTAwT1RNS0lDQWdJQzh2SUdsbUlHVjJaVzUwSUQwOUlFUnBjM0IxZEdWRmRtVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCa2FYTndkWFJsWDJsa1BVRlNRelJWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lXTjBhVzl1UFVGU1F6UlRkSEpwYm1jb0lpSXBMQW9nSUNBZ0x5OGdJQ0FnSUdwMWNtOXlQVUZrWkhKbGMzTW9SMnh2WW1Gc0xucGxjbTlmWVdSa2NtVnpjeWtzQ2lBZ0lDQXZMeUFnSUNBZ2RHbHRaWE4wWVcxd1BVRlNRelJWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RtOTBaVjkyWVd4MVpUMUJVa00wVlVsdWREWTBLREFwQ2lBZ0lDQXZMeUFwT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJR0poYzJVek1paEJRVUZCUVVGQlFVRkJRVUZCUVVJeVFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVFcENpQWdJQ0E5UFFvZ0lDQWdZbm9nWjJWMFgyVjJaVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZORGswTFRVd01Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUVScGMzQjFkR1ZGZG1WdWRDZ0tJQ0FnSUM4dklDQWdJQ0JrYVhOd2RYUmxYMmxrUFVGU1F6UlZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWVdOMGFXOXVQVUZTUXpSVGRISnBibWNvSW1WMlpXNTBYMjV2ZEY5bWIzVnVaQ0lwTEFvZ0lDQWdMeThnSUNBZ0lHcDFjbTl5UFVGa1pISmxjM01vUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3lrc0NpQWdJQ0F2THlBZ0lDQWdkR2x0WlhOMFlXMXdQVUZTUXpSVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdkbTkwWlY5MllXeDFaVDFCVWtNMFZVbHVkRFkwS0RBcENpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb1lubDBaWE1nWW1GelpUTXlLRUZCUVVGQlFVRkJRVUZCUVVGQlFqSkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlVFMVdNMGRMTTFSVlREVllSelkxUXpkTldsaFlTek5VUlNrS0lDQWdJSE4zWVhBS0lDQWdJSEpsZEhOMVlnb0taMlYwWDJWMlpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qVXdNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHVjJaVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUnBjM0IxZEdVdVkyOXVkSEpoWTNRdVFXZHlhVWQxWVhKa1JHbHpjSFYwWlM1blpYUmZjbVZqWlc1MFgyVjJaVzUwY3loc2FXMXBkRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BuWlhSZmNtVmpaVzUwWDJWMlpXNTBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalV3TXkwMU1EUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQm5aWFJmY21WalpXNTBYMlYyWlc1MGN5aHpaV3htTENCc2FXMXBkRG9nUVZKRE5GVkpiblEyTkNrZ0xUNGdWSFZ3YkdWYlFWSkRORlZKYm5RMk5Dd2dRVkpETkZWSmJuUTJORjA2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qVXdOZ29nSUNBZ0x5OGdkRzkwWVd4ZlpYWmxiblJ6SUQwZ2MyVnNaaTV1WlhoMFgyVjJaVzUwWDJsa0lDMGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0ltNWxlSFJmWlhabGJuUmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJtVjRkRjlsZG1WdWRGOXBaQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalV3TndvZ0lDQWdMeThnYzNSaGNuUmZhV1FnUFNCMGIzUmhiRjlsZG1WdWRITWdMU0JzYVcxcGRDNXVZWFJwZG1VZ0t5QlZTVzUwTmpRb01Ta0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5SdmFRb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk5UQTRDaUFnSUNBdkx5QnBaaUJ6ZEdGeWRGOXBaQ0E4SUZWSmJuUTJOQ2d4S1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQThDaUFnSUNCaWVpQm5aWFJmY21WalpXNTBYMlYyWlc1MGMxOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pVd09Rb2dJQ0FnTHk4Z2MzUmhjblJmYVdRZ1BTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0NtZGxkRjl5WldObGJuUmZaWFpsYm5SelgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pVeE1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZSMWNHeGxLQ2hCVWtNMFZVbHVkRFkwS0hSdmRHRnNYMlYyWlc1MGN5a3NJRUZTUXpSVlNXNTBOalFvYzNSaGNuUmZhV1FwS1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWthWE53ZFhSbExtTnZiblJ5WVdOMExrRm5jbWxIZFdGeVpFUnBjM0IxZEdVdVoyVjBYMlJwYzNCMWRHVmZjM1JoZEhWektHUnBjM0IxZEdWZmFXUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taMlYwWDJScGMzQjFkR1ZmYzNSaGRIVnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZOVEV6TFRVeE5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjlrYVhOd2RYUmxYM04wWVhSMWN5aHpaV3htTENCa2FYTndkWFJsWDJsa09pQkJVa00wVlVsdWREWTBLU0F0UGlCQlVrTTBWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG8xTVRZS0lDQWdJQzh2SUdScGMzQjFkR1ZmWkdGMFlTQTlJSE5sYkdZdVpHbHpjSFYwWlhNdWJXRjVZbVVvWkdsemNIVjBaVjlwWkM1dVlYUnBkbVVwV3pCZExtTnZjSGtvS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0prYVhOd2RYUmxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk5URTVDaUFnSUNBdkx5QnBaaUJ1YjNRZ1pYaHBjM1J6T2dvZ0lDQWdZbTU2SUdkbGRGOWthWE53ZFhSbFgzTjBZWFIxYzE5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalV5TUFvZ0lDQWdMeThnY21WMGRYSnVJRUZTUXpSVlNXNTBOalFvTUNrZ0lDTWdSR2x6Y0hWMFpTQmtiMlZ6YmlkMElHVjRhWE4wQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dwblpYUmZaR2x6Y0hWMFpWOXpkR0YwZFhOZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TlRJeUNpQWdJQ0F2THlCamRYSnlaVzUwWDNKdmRXNWtJRDBnUjJ4dlltRnNMbkp2ZFc1a0NpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pVeU5DMDFNalVLSUNBZ0lDOHZJQ01nUTJobFkyc2dhV1lnZG05MGFXNW5JR1JsWVdSc2FXNWxJR2hoY3lCd1lYTnpaV1FLSUNBZ0lDOHZJR2xtSUdOMWNuSmxiblJmY205MWJtUWdQaUJrYVhOd2RYUmxYMlJoZEdFdWRtOTBhVzVuWDJSbFlXUnNhVzVsTG01aGRHbDJaU0JoYm1RZ1pHbHpjSFYwWlY5a1lYUmhMbk4wWVhSMWN5NXVZWFJwZG1VZ1BUMGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUhCMWMyaHBiblFnT0RJZ0x5OGdPRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQStDaUFnSUNCaWVpQm5aWFJmWkdsemNIVjBaVjl6ZEdGMGRYTmZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdhVzUwWTE4eUlDOHZJRFV3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZbTU2SUdkbGRGOWthWE53ZFhSbFgzTjBZWFIxYzE5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalV5TmdvZ0lDQWdMeThnY21WMGRYSnVJRUZTUXpSVlNXNTBOalFvTXlrZ0lDTWdWbTkwYVc1bklHVjRjR2x5WldRS0lDQWdJR0o1ZEdWaklERXpJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TXdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNncG5aWFJmWkdsemNIVjBaVjl6ZEdGMGRYTmZZV1owWlhKZmFXWmZaV3h6WlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJScGMzQjFkR1V2WTI5dWRISmhZM1F1Y0hrNk5USTRMVFV5T1FvZ0lDQWdMeThnSXlCU1pYUjFjbTRnWTNWeWNtVnVkQ0J6ZEdGMGRYTUtJQ0FnSUM4dklISmxkSFZ5YmlCa2FYTndkWFJsWDJSaGRHRXVjM1JoZEhWekNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaWGgwY21GamRDQTFNQ0E0SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUnBjM0IxZEdVdVkyOXVkSEpoWTNRdVFXZHlhVWQxWVhKa1JHbHpjSFYwWlM1blpYUmZZV04wYVhabFgyUnBjM0IxZEdWektDa2dMVDRnWW5sMFpYTTZDbWRsZEY5aFkzUnBkbVZmWkdsemNIVjBaWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG8xTXpFdE5UTXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0F2THlCa1pXWWdaMlYwWDJGamRHbDJaVjlrYVhOd2RYUmxjeWh6Wld4bUtTQXRQaUJVZFhCc1pWdEJVa00wVlVsdWREWTBMQ0JCVWtNMFZVbHVkRFkwWFRvS0lDQWdJSEJ5YjNSdklEQWdNUW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzFNelFLSUNBZ0lDOHZJR0ZqZEdsMlpWOWpiM1Z1ZENBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pVek5Rb2dJQ0FnTHk4Z2RHOTBZV3hmWTI5MWJuUWdQU0J6Wld4bUxtNWxlSFJmWkdsemNIVjBaVjlwWkNBdElGVkpiblEyTkNneEtRb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKdVpYaDBYMlJwYzNCMWRHVmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTVsZUhSZlpHbHpjSFYwWlY5cFpDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzFNemN0TlRNNENpQWdJQ0F2THlBaklFTnZkVzUwSUdGamRHbDJaU0JrYVhOd2RYUmxjeUFvYzNSaGRIVnpJRDBnTUNrS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2d4TENCelpXeG1MbTVsZUhSZlpHbHpjSFYwWlY5cFpDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb0taMlYwWDJGamRHbDJaVjlrYVhOd2RYUmxjMTltYjNKZmFHVmhaR1Z5UURFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvMU16Y3ROVE00Q2lBZ0lDQXZMeUFqSUVOdmRXNTBJR0ZqZEdsMlpTQmthWE53ZFhSbGN5QW9jM1JoZEhWeklEMGdNQ2tLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTZ3hMQ0J6Wld4bUxtNWxlSFJmWkdsemNIVjBaVjlwWkNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lEd0tJQ0FnSUdKNklHZGxkRjloWTNScGRtVmZaR2x6Y0hWMFpYTmZZV1owWlhKZlptOXlRRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalV6T1FvZ0lDQWdMeThnWkdsemNIVjBaVjlrWVhSaElEMGdjMlZzWmk1a2FYTndkWFJsY3k1dFlYbGlaU2hwS1Zzd1hTNWpiM0I1S0NrS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0prYVhOd2RYUmxjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvMU5EQUtJQ0FnSUM4dklHbG1JR1JwYzNCMWRHVmZaR0YwWVM1emRHRjBkWE11Ym1GMGFYWmxJRDA5SUZWSmJuUTJOQ2d3S1RvS0lDQWdJR2x1ZEdOZk1pQXZMeUExTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHSnVlaUJuWlhSZllXTjBhWFpsWDJScGMzQjFkR1Z6WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZOVFF4Q2lBZ0lDQXZMeUJoWTNScGRtVmZZMjkxYm5RZ0t6MGdWVWx1ZERZMEtERXBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9LWjJWMFgyRmpkR2wyWlY5a2FYTndkWFJsYzE5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzFNemN0TlRNNENpQWdJQ0F2THlBaklFTnZkVzUwSUdGamRHbDJaU0JrYVhOd2RYUmxjeUFvYzNSaGRIVnpJRDBnTUNrS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2d4TENCelpXeG1MbTVsZUhSZlpHbHpjSFYwWlY5cFpDazZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dOQW9nSUNBZ1lpQm5aWFJmWVdOMGFYWmxYMlJwYzNCMWRHVnpYMlp2Y2w5b1pXRmtaWEpBTVFvS1oyVjBYMkZqZEdsMlpWOWthWE53ZFhSbGMxOWhablJsY2w5bWIzSkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalUwTXdvZ0lDQWdMeThnY21WMGRYSnVJRlIxY0d4bEtDaEJVa00wVlVsdWREWTBLR0ZqZEdsMlpWOWpiM1Z1ZENrc0lFRlNRelJWU1c1ME5qUW9kRzkwWVd4ZlkyOTFiblFwS1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWthWE53ZFhSbExtTnZiblJ5WVdOMExrRm5jbWxIZFdGeVpFUnBjM0IxZEdVdWRtRnNhV1JoZEdWZmFuVnliM0pmWld4cFoybGlhV3hwZEhrb2FuVnliM0pmWVdSa2NtVnpjem9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3AyWVd4cFpHRjBaVjlxZFhKdmNsOWxiR2xuYVdKcGJHbDBlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalUwTlMwMU5EWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQjJZV3hwWkdGMFpWOXFkWEp2Y2w5bGJHbG5hV0pwYkdsMGVTaHpaV3htTENCcWRYSnZjbDloWkdSeVpYTnpPaUJCWkdSeVpYTnpLU0F0UGlCQlVrTTBWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG8xTkRnS0lDQWdJQzh2SUdwMWNtOXlYMlJoZEdFZ1BTQnpaV3htTG1wMWNtOXljeTV0WVhsaVpTaHFkWEp2Y2w5aFpHUnlaWE56S1Zzd1hTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWaklEY2dMeThnSW1wMWNtOXljeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvMU5URUtJQ0FnSUM4dklHbG1JRzV2ZENCbGVHbHpkSE02Q2lBZ0lDQmlibm9nZG1Gc2FXUmhkR1ZmYW5WeWIzSmZaV3hwWjJsaWFXeHBkSGxmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzFOVElLSUNBZ0lDOHZJSEpsZEhWeWJpQkJVa00wVlVsdWREWTBLREFwSUNBaklFNXZkQ0J5WldkcGMzUmxjbVZrQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dwMllXeHBaR0YwWlY5cWRYSnZjbDlsYkdsbmFXSnBiR2wwZVY5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG8xTlRRS0lDQWdJQzh2SUdOMWNuSmxiblJmY205MWJtUWdQU0JIYkc5aVlXd3VjbTkxYm1RS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TlRVMUNpQWdJQ0F2THlCeWIzVnVaSE5mYzJsdVkyVmZjbVZuYVhOMGNtRjBhVzl1SUQwZ1kzVnljbVZ1ZEY5eWIzVnVaQ0F0SUdwMWNtOXlYMlJoZEdFdWNtVm5hWE4wY21GMGFXOXVYM0p2ZFc1a0xtNWhkR2wyWlFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lIQjFjMmhwYm5RZ05UWWdMeThnTlRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG8xTlRjS0lDQWdJQzh2SUdsbUlISnZkVzVrYzE5emFXNWpaVjl5WldkcGMzUnlZWFJwYjI0Z1BDQlZTVzUwTmpRb05UQXBPZ29nSUNBZ2FXNTBZMTh5SUM4dklEVXdDaUFnSUNBOENpQWdJQ0JpZWlCMllXeHBaR0YwWlY5cWRYSnZjbDlsYkdsbmFXSnBiR2wwZVY5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalUxT0FvZ0lDQWdMeThnY21WMGRYSnVJRUZTUXpSVlNXNTBOalFvTVNrZ0lDTWdWRzl2SUc1bGR5d2dkMkZwZEdsdVp5QndaWEpwYjJRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0NuWmhiR2xrWVhSbFgycDFjbTl5WDJWc2FXZHBZbWxzYVhSNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pVMk1Bb2dJQ0FnTHk4Z2FXWWdhblZ5YjNKZlpHRjBZUzV5WlhCMWRHRjBhVzl1TG01aGRHbDJaU0E4SUZWSmJuUTJOQ2d4TUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjSFZ6YUdsdWRDQXpNaUF2THlBek1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBeE1Bb2dJQ0FnUEFvZ0lDQWdZbm9nZG1Gc2FXUmhkR1ZmYW5WeWIzSmZaV3hwWjJsaWFXeHBkSGxmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzFOakVLSUNBZ0lDOHZJSEpsZEhWeWJpQkJVa00wVlVsdWREWTBLRElwSUNBaklFeHZkeUJ5WlhCMWRHRjBhVzl1Q2lBZ0lDQmllWFJsWXlBeU5DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lISmxkSE4xWWdvS2RtRnNhV1JoZEdWZmFuVnliM0pmWld4cFoybGlhV3hwZEhsZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TlRZekNpQWdJQ0F2THlCeVpYUjFjbTRnUVZKRE5GVkpiblEyTkNnektTQWdJeUJGYkdsbmFXSnNaUW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXpDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHbHpjSFYwWlM1amIyNTBjbUZqZEM1QlozSnBSM1ZoY21SRWFYTndkWFJsTG1kbGRGOXFkWEp2Y2w5aGMzTnBaMjVsWkY5a2FYTndkWFJsY3locWRYSnZjbDloWkdSeVpYTnpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbWRsZEY5cWRYSnZjbDloYzNOcFoyNWxaRjlrYVhOd2RYUmxjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalUyTlMwMU5qWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJQzh2SUdSbFppQm5aWFJmYW5WeWIzSmZZWE56YVdkdVpXUmZaR2x6Y0hWMFpYTW9jMlZzWml3Z2FuVnliM0pmWVdSa2NtVnpjem9nUVdSa2NtVnpjeWtnTFQ0Z1FubDBaWE02Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvMU5qZ0tJQ0FnSUM4dklHRnpjMmxuYm1Wa1gyUnBjM0IxZEdWeklEMGdRbmwwWlhNb1lpSWlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzFOekV0TlRjekNpQWdJQ0F2THlBaklFbDBaWEpoZEdVZ2RHaHliM1ZuYUNCaGJHd2daR2x6Y0hWMFpYTWdkRzhnWm1sdVpDQmhjM05wWjI1bFpDQnZibVZ6Q2lBZ0lDQXZMeUFqSUZSb2FYTWdhWE1nWVNCemFXMXdiR2xtYVdWa0lHbHRjR3hsYldWdWRHRjBhVzl1SUMwZ2FXNGdjSEpoWTNScFkyVXNJSGRsSjJRZ2JtVmxaQ0JoSUcxdmNtVWdaV1ptYVdOcFpXNTBJR0Z3Y0hKdllXTm9DaUFnSUNBdkx5Qm1iM0lnWkdsemNIVjBaVjlwWkNCcGJpQjFjbUZ1WjJVb01Td2djMlZzWmk1dVpYaDBYMlJwYzNCMWRHVmZhV1FwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbTVsZUhSZlpHbHpjSFYwWlY5cFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV1WlhoMFgyUnBjM0IxZEdWZmFXUWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6QWdMeThnTVFvS1oyVjBYMnAxY205eVgyRnpjMmxuYm1Wa1gyUnBjM0IxZEdWelgyWnZjbDlvWldGa1pYSkFNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalUzTVMwMU56TUtJQ0FnSUM4dklDTWdTWFJsY21GMFpTQjBhSEp2ZFdkb0lHRnNiQ0JrYVhOd2RYUmxjeUIwYnlCbWFXNWtJR0Z6YzJsbmJtVmtJRzl1WlhNS0lDQWdJQzh2SUNNZ1ZHaHBjeUJwY3lCaElITnBiWEJzYVdacFpXUWdhVzF3YkdWdFpXNTBZWFJwYjI0Z0xTQnBiaUJ3Y21GamRHbGpaU3dnZDJVblpDQnVaV1ZrSUdFZ2JXOXlaU0JsWm1acFkybGxiblFnWVhCd2NtOWhZMmdLSUNBZ0lDOHZJR1p2Y2lCa2FYTndkWFJsWDJsa0lHbHVJSFZ5WVc1blpTZ3hMQ0J6Wld4bUxtNWxlSFJmWkdsemNIVjBaVjlwWkNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lEd0tJQ0FnSUdKNklHZGxkRjlxZFhKdmNsOWhjM05wWjI1bFpGOWthWE53ZFhSbGMxOWhablJsY2w5bWIzSkFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZOVGMwQ2lBZ0lDQXZMeUJxZFhKdmNsOWthWE53ZFhSbFgydGxlU0E5SUdwMWNtOXlYMko1ZEdWeklDc2dRbmwwWlhNb1lpSmhjM05wWjI1bFpDSXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNWRHVmpJREkxSUM4dklEQjROakUzTXpjek5qazJOelpsTmpVMk5Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzFOelVLSUNBZ0lDOHZJR2x6WDJGemMybG5ibVZrSUQwZ2MyVnNaaTVxZFhKdmNsOWthWE53ZFhSbGN5NXRZWGxpWlNocWRYSnZjbDlrYVhOd2RYUmxYMnRsZVNsYk1WMEtJQ0FnSUdKNWRHVmpJREV5SUM4dklDSnFkWEp2Y2w5a2FYTndkWFJsY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzFOemNLSUNBZ0lDOHZJR2xtSUdselgyRnpjMmxuYm1Wa09nb2dJQ0FnWW5vZ1oyVjBYMnAxY205eVgyRnpjMmxuYm1Wa1gyUnBjM0IxZEdWelgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TlRjNENpQWdJQ0F2THlCaGMzTnBaMjVsWkY5a2FYTndkWFJsY3lBOUlHRnpjMmxuYm1Wa1gyUnBjM0IxZEdWeklDc2dRbmwwWlhNb1lpSmhjM05wWjI1bFpDSXBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWW5sMFpXTWdNalVnTHk4Z01IZzJNVGN6TnpNMk9UWTNObVUyTlRZMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb0taMlYwWDJwMWNtOXlYMkZ6YzJsbmJtVmtYMlJwYzNCMWRHVnpYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pVM01TMDFOek1LSUNBZ0lDOHZJQ01nU1hSbGNtRjBaU0IwYUhKdmRXZG9JR0ZzYkNCa2FYTndkWFJsY3lCMGJ5Qm1hVzVrSUdGemMybG5ibVZrSUc5dVpYTUtJQ0FnSUM4dklDTWdWR2hwY3lCcGN5QmhJSE5wYlhCc2FXWnBaV1FnYVcxd2JHVnRaVzUwWVhScGIyNGdMU0JwYmlCd2NtRmpkR2xqWlN3Z2QyVW5aQ0J1WldWa0lHRWdiVzl5WlNCbFptWnBZMmxsYm5RZ1lYQndjbTloWTJnS0lDQWdJQzh2SUdadmNpQmthWE53ZFhSbFgybGtJR2x1SUhWeVlXNW5aU2d4TENCelpXeG1MbTVsZUhSZlpHbHpjSFYwWlY5cFpDazZDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ1lpQm5aWFJmYW5WeWIzSmZZWE56YVdkdVpXUmZaR2x6Y0hWMFpYTmZabTl5WDJobFlXUmxja0F4Q2dwblpYUmZhblZ5YjNKZllYTnphV2R1WldSZlpHbHpjSFYwWlhOZllXWjBaWEpmWm05eVFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzFPREFLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjM05wWjI1bFpGOWthWE53ZFhSbGN3b2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVJwYzNCMWRHVXVZMjl1ZEhKaFkzUXVRV2R5YVVkMVlYSmtSR2x6Y0hWMFpTNXBjMTlxZFhKdmNsOWhjM05wWjI1bFpGOTBiMTlrYVhOd2RYUmxLR3AxY205eVgyRmtaSEpsYzNNNklHSjVkR1Z6TENCa2FYTndkWFJsWDJsa09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtbHpYMnAxY205eVgyRnpjMmxuYm1Wa1gzUnZYMlJwYzNCMWRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzFPREl0TlRnekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQXZMeUJrWldZZ2FYTmZhblZ5YjNKZllYTnphV2R1WldSZmRHOWZaR2x6Y0hWMFpTaHpaV3htTENCcWRYSnZjbDloWkdSeVpYTnpPaUJCWkdSeVpYTnpMQ0JrYVhOd2RYUmxYMmxrT2lCQlVrTTBWVWx1ZERZMEtTQXRQaUJCVWtNMFZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzFPRFVLSUNBZ0lDOHZJR3AxY205eVgyUnBjM0IxZEdWZmEyVjVJRDBnYW5WeWIzSmZZV1JrY21WemN5NWllWFJsY3lBcklFSjVkR1Z6S0dJaVpHbHpjSFYwWlY5clpYa2lLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJORFk1TnpNM01EYzFOelEyTlRWbU5tSTJOVGM1Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYVhOd2RYUmxMMk52Ym5SeVlXTjBMbkI1T2pVNE5nb2dJQ0FnTHk4Z2FYTmZZWE56YVdkdVpXUWdQU0J6Wld4bUxtcDFjbTl5WDJScGMzQjFkR1Z6TG0xaGVXSmxLR3AxY205eVgyUnBjM0IxZEdWZmEyVjVLVnN4WFFvZ0lDQWdZbmwwWldNZ01USWdMeThnSW1wMWNtOXlYMlJwYzNCMWRHVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qVTRPQW9nSUNBZ0x5OGdjbVYwZFhKdUlFRlNRelJWU1c1ME5qUW9NU2tnYVdZZ2FYTmZZWE56YVdkdVpXUWdaV3h6WlNCQlVrTTBWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaR2x6Y0hWMFpTNWpiMjUwY21GamRDNUJaM0pwUjNWaGNtUkVhWE53ZFhSbExtMWhjbXRmWkdsemNIVjBaVjl3Y205alpYTnpaV1FvWkdsemNIVjBaVjlwWkRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwdFlYSnJYMlJwYzNCMWRHVmZjSEp2WTJWemMyVmtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZOVGt3TFRVNU1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JRzFoY210ZlpHbHpjSFYwWlY5d2NtOWpaWE56WldRb2MyVnNaaXdnWkdsemNIVjBaVjlwWkRvZ1FWSkRORlZKYm5RMk5Da2dMVDRnUVZKRE5GVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnBjM0IxZEdVdlkyOXVkSEpoWTNRdWNIazZOVGt6Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbUZrYldsdUxDQWlUMjVzZVNCaFpHMXBiaUJqWVc0Z2JXRnlheUJrYVhOd2RYUmxjeUJoY3lCd2NtOWpaWE56WldRaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWVdSdGFXNGdZMkZ1SUcxaGNtc2daR2x6Y0hWMFpYTWdZWE1nY0hKdlkyVnpjMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG8xT1RVS0lDQWdJQzh2SUdScGMzQjFkR1ZmYVdSZmRXbHVkQ0E5SUdScGMzQjFkR1ZmYVdRdWJtRjBhWFpsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPalU1TmdvZ0lDQWdMeThnWkdsemNIVjBaVjlrWVhSaElEMGdjMlZzWmk1a2FYTndkWFJsY3k1dFlYbGlaU2hrYVhOd2RYUmxYMmxrWDNWcGJuUXBXekJkTG1OdmNIa29LUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTkNBdkx5QWlaR2x6Y0hWMFpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJwYzNCMWRHVXZZMjl1ZEhKaFkzUXVjSGs2TlRrNUNpQWdJQ0F2THlCcFppQnViM1FnWkdsemNIVjBaVjlsZUdsemRITTZDaUFnSUNCaWJub2diV0Z5YTE5a2FYTndkWFJsWDNCeWIyTmxjM05sWkY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPall3TUFvZ0lDQWdMeThnY21WMGRYSnVJRUZTUXpSVlNXNTBOalFvTUNrZ0lDTWdSR2x6Y0hWMFpTQnViM1FnWm05MWJtUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tiV0Z5YTE5a2FYTndkWFJsWDNCeWIyTmxjM05sWkY5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG8yTURJdE5qQXpDaUFnSUNBdkx5QWpJRTFoY21zZ1pHbHpjSFYwWlNCaGN5QndjbTlqWlhOelpXUWdLSE4wWVhSMWN5QTlJRE1nYldWaGJuTWdjSEp2WTJWemMyVmtMMlJsYkdWMFpXUXBDaUFnSUNBdkx5QmthWE53ZFhSbFgyUmhkR0V1YzNSaGRIVnpJRDBnUVZKRE5GVkpiblEyTkNnektRb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR0o1ZEdWaklERXpJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TXdvZ0lDQWdjbVZ3YkdGalpUSWdOVEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPall3TkFvZ0lDQWdMeThnYzJWc1ppNWthWE53ZFhSbGMxdGthWE53ZFhSbFgybGtYM1ZwYm5SZElEMGdaR2x6Y0hWMFpWOWtZWFJoTG1OdmNIa29LUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG8yTURZdE5qQTNDaUFnSUNBdkx5QWpJRlZ3WkdGMFpTQnpkR0YwYVhOMGFXTnpDaUFnSUNBdkx5QnpaV3htTGw5MWNHUmhkR1ZmYzNSaGRITW9VM1J5YVc1bktDSmthWE53ZFhSbFgzQnliMk5sYzNObFpDSXBLUW9nSUNBZ1lubDBaV01nTWpBZ0x5OGdJbVJwYzNCMWRHVmZjSEp2WTJWemMyVmtJZ29nSUNBZ1kyRnNiSE4xWWlCZmRYQmtZWFJsWDNOMFlYUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzJNRGt0TmpFd0NpQWdJQ0F2THlBaklFeHZaeUJ3Y205alpYTnphVzVuSUdWMlpXNTBDaUFnSUNBdkx5QnpaV3htTGw5c2IyZGZaWFpsYm5Rb1pHbHpjSFYwWlY5cFpDd2djMlZzWmk1aFpHMXBiaXdnUVZKRE5GTjBjbWx1WnlnaVpHbHpjSFYwWlY5d2NtOWpaWE56WldRaUtTd2dRVkpETkZWSmJuUTJOQ2d3S1NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeE1UWTBOamszTXpjd056VTNORFkxTldZM01EY3lObVkyTXpZMU56TTNNelkxTmpRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpZV3hzYzNWaUlGOXNiMmRmWlhabGJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qWXhNaTAyTVRNS0lDQWdJQzh2SUNNZ1JXMXBkQ0JzYjJjZ1ptOXlJR1Y0ZEdWeWJtRnNJRzF2Ym1sMGIzSnBibWNLSUNBZ0lDOHZJR3h2WnloQ2VYUmxjeWhpSWtSSlUxQlZWRVZmVUZKUFEwVlRVMFZFSWlrZ0t5QkNlWFJsY3loaUluQnliMk5sYzNObFpDSXBLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRORFEwT1RVek5UQTFOVFUwTkRVMVpqVXdOVEkwWmpRek5EVTFNelV6TkRVME5EY3dOekkyWmpZek5qVTNNemN6TmpVMk5Bb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdsemNIVjBaUzlqYjI1MGNtRmpkQzV3ZVRvMk1UVUtJQ0FnSUM4dklISmxkSFZ5YmlCQlVrTTBWVWx1ZERZMEtERXBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WkdsemNIVjBaUzVqYjI1MGNtRmpkQzVCWjNKcFIzVmhjbVJFYVhOd2RYUmxMblJ5YVdkblpYSmZjRzlzYVdONVgzQnliMk5sYzNOcGJtY29jRzlzYVdONVgybGtPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDblJ5YVdkblpYSmZjRzlzYVdONVgzQnliMk5sYzNOcGJtYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHbHpjSFYwWlM5amIyNTBjbUZqZEM1d2VUbzJNVGN0TmpFNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0NpQWdJQ0F2THlCa1pXWWdkSEpwWjJkbGNsOXdiMnhwWTNsZmNISnZZMlZ6YzJsdVp5aHpaV3htTENCd2IyeHBZM2xmYVdRNklFRlNRelJWU1c1ME5qUXBJQzArSUVGU1F6UlZTVzUwTmpRNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWthWE53ZFhSbEwyTnZiblJ5WVdOMExuQjVPall5TUFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWFXNXpkWEpoYm1ObFgyTnZiblJ5WVdOMElDRTlJRUZrWkhKbGMzTW9SMnh2WW1Gc0xucGxjbTlmWVdSa2NtVnpjeWtzSUNKSmJuTjFjbUZ1WTJVZ1kyOXVkSEpoWTNRZ2JtOTBJSE5sZENJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNElDOHZJQ0pwYm5OMWNtRnVZMlZmWTI5dWRISmhZM1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFXNXpkWEpoYm1ObFgyTnZiblJ5WVdOMElHVjRhWE4wY3dvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWMzVnlZVzVqWlNCamIyNTBjbUZqZENCdWIzUWdjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR2x6Y0hWMFpTOWpiMjUwY21GamRDNXdlVG8yTWpZdE5qSTNDaUFnSUNBdkx5QWpJRU55WldGMFpTQnNiMmNnWlhabGJuUWdabTl5SUdWNGRHVnlibUZzSUcxdmJtbDBiM0pwYm1jZ2IyWWdjRzlzYVdONUlIQnliMk5sYzNOcGJtY2dkSEpwWjJkbGNnb2dJQ0FnTHk4Z2JHOW5LRUo1ZEdWektHSWlWRkpKUjBkRlVsOVFUMHhKUTFsZlVGSlBRMFZUVTBsT1J5SXBJQ3NnUW5sMFpYTW9ZaUp3YjJ4cFkzbGZjSEp2WTJWemMybHVaMTkwY21sbloyVnlaV1FpS1NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVME5USTBPVFEzTkRjME5UVXlOV1kxTURSbU5HTTBPVFF6TlRrMVpqVXdOVEkwWmpRek5EVTFNelV6TkRrMFpUUTNOekEyWmpaak5qazJNemM1TldZM01EY3lObVkyTXpZMU56TTNNelk1Tm1VMk56Vm1OelEzTWpZNU5qYzJOelkxTnpJMk5UWTBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2FYTndkWFJsTDJOdmJuUnlZV04wTG5CNU9qWXlPUW9nSUNBZ0x5OGdjbVYwZFhKdUlFRlNRelJWU1c1ME5qUW9NU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXhDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBUUF5Q2lZYUNBQUFBQUFBQUFBQUJCVWZmSFVJQUFBQUFBQUFBQUVNZEc5MFlXeGZhblZ5YjNKekNHUnBjM0IxZEdWekJXRmtiV2x1RDI1bGVIUmZaR2x6Y0hWMFpWOXBaQVpxZFhKdmNuTVNhVzV6ZFhKaGJtTmxYMk52Ym5SeVlXTjBGMk52Ym5SeVlXTjBYMk55WldGMGFXOXVYM0p2ZFc1a0RXNWxlSFJmWlhabGJuUmZhV1FKYzNSaGRITmZZbTk0RG1wMWNtOXlYMlJwYzNCMWRHVnpDQUFBQUFBQUFBQURGblp2ZEdsdVoxOWtkWEpoZEdsdmJsOXliM1Z1WkhNUWJXbHVYM04wWVd0bFgyRnRiM1Z1ZEFsbGRtVnVkRjlzYjJjUFpHbHpjSFYwWlY5amNtVmhkR1ZrRUdScGMzQjFkR1ZmY21WemIyeDJaV1FRWkdsemNIVjBaVjl5WldwbFkzUmxaQkZrYVhOd2RYUmxYM0J5YjJObGMzTmxaQWwyYjNSbFgyTmhjM1FRYW5WeWIzSmZjbVZuYVhOMFpYSmxaQWRrYVhOd2RYUmxDQUFBQUFBQUFBQUNDR0Z6YzJsbmJtVmtNUmhBQUNZbkJUSURaeWNJTWdObkp3WWlaeXNqWnljSkkyY25Eb0hvQjJjbkQ0SEFoRDFuSndvaVp6RWJRUUNGZ2hJRWlVcHhiZ1JXOWVQOEJQeTZBam9FRXpYTi9RUzBwUzBGQk4xNHRWQUV6SGlINHdSK0p6czRCQlFOSDBjRXZxdVlld1JoVzdNUEJENE4yZnNFekh1ZW13UkVLU0c0QkttMEpvTUVLeUk2Z3dRVHlXY2dCSnk5Q1pZMkdnQ09FZ0ZIQVRRQkpBRVJBUHNBNkFEVkFNVUF0UUNpQUk4QWZBQnNBRmtBUGdBb0FCVUFBaU5ETVJrVVJERVlSRFlhQVlnSTNTbE1VTEFpUXpFWkZFUXhHRVEyR2dHSUNGa3BURkN3SWtNeEdSUkVNUmhFTmhvQk5ob0NpQWdqS1V4UXNDSkRNUmtVUkRFWVJEWWFBWWdIMEVrVkZsY0dBa3hRS1V4UXNDSkRNUmtVUkRFWVJEWWFBWWdIaENsTVVMQWlRekVaRkVReEdFU0lCeXNwVEZDd0lrTXhHUlJFTVJoRU5ob0JpQWJwS1V4UXNDSkRNUmtVUkRFWVJEWWFBWWdHc2lsTVVMQWlRekVaRkVReEdFUTJHZ0dJQmZ3cFRGQ3dJa014R1JSRU1SaEVpQVhuS1V4UXNDSkRNUmtVUkRFWVJJZ0YwU2xNVUxBaVF6RVpGRVF4R0VRMkdnR0lCWjRwVEZDd0lrTXhHUlJFTVJoRU5ob0JpQVVJS1V4UXNDSkRNUmtVUkRFWVJEWWFBVFlhQW9nREZ5bE1VTEFpUXpFWkZFUXhHRVEyR2dHSUFlNHBURkN3SWtNeEdSUkVNUmhFaUFGVUtVeFFzQ0pETVJrVVJERVlSRFlhQVlnQkxpbE1VTEFpUXpFWkZFUXhHQlJFTmhvQmlBQUNJa09LQVFBbkJZdi9aeWNKTWdabkp3dUFLQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDL0tJdi9nQklBRUdOdmJuUnlZV04wWDJOeVpXRjBaV1FvaUFBQmlZb0VBRElHRm92OGdBSUFPbENML1ZCTVVJdi9VSXYrVUNNbkNtVkVTUlluRUV4UVNieElUd0svSWdnbkNreG5pWW9CQUNNbkM3NUVpLzhuRVJKQkFCS0xBVWtqV3lJSUZsd0FqQUVuQzRzQnY0bUwveWNTRWtFQUVJc0JTWUVJV3lJSUZsd0lqQUZDLytLTC95Y1RFa0VBRUlzQlNZRVFXeUlJRmx3UWpBRkMvOHFML3ljVUVrRC93b3YvSnhVU1FRQVFpd0ZKZ1JoYklnZ1dYQmlNQVVML3Fvdi9KeFlTaXdHTUFFRUFEWXNCU1lFZ1d5SUlGbHdnakFDTEFJd0JRditLaWdFQkl5Y0ZaVVF4QUJKRUp3aUwvMmNxaVlvQUFURUFKd2N4QUZCSnZrVUJRUUFFS0l3QWlUSUdJeWNKWlVRbENFc0JEa1FXSXljUFpVUVdpd0JKVGdPQUNBQUFBQUFBQUFCa1VDaFFLRkJQQWxBb1VFeFFpd0ZNdnlNclpVUWlDQ3RNWnljV2lQOEZLRXNCZ0JJQUVHcDFjbTl5WDNKbFoybHpkR1Z5WldRb2lQNjZnQkJLVlZKUFVsOVNSVWRKVTFSRlVrVkVURkN3S293QWlZb0JBU09BQURFQUp3Y3hBRkMrUlFGQUFBUW9qQUNKTWdZakp3bGxSQ1FJU3dFT1JDTW5CbVZFU1NJSUp3Wk1aMHNCRmlNbkRtVkVUd01JRm92L2l3SlFnQUlBWWxCUEFsQW9VQ2hRS0ZBb1VFeFFLRkNBR3dBWlVHOXNhV041SUhObGRIUnNaVzFsYm5RZ1pHbHpjSFYwWlZCTUZrbU1BQ2NFVEZCSnZFaE12eU1yWlVRbERrRUFkaU9NQVNNclpVU0xBUTFCQUFtTEFTSUlqQUZDLysyQURtUnBjM0IxZEdWZmFuVnliM0p6aXdCSlRnSlFTYnhJZ0FDL0p4R0kvaEJKaXdKSlRnS0FFUUFQWkdsemNIVjBaVjlqY21WaGRHVmtLSWo5dzRBYVJFbFRVRlZVUlY5RFVrVkJWRVZFWkdsemNIVjBaVjlwWkRwTVVMQ01BSWtqakFFaksyVkVpd0VOUWYrVGl3RWlDSXdCUXYvdGlnSUJJMGNETVFDTC9oY3lCa3dXSndSTVVFbStRQUFFS0l3QWlZc0hnVkpiaXdVTVFRQUVLSXdBaVlzSEpGdEJBQVFvakFDSkp3ZUxCRkJKakFDK1RJd0NRQUFFS0l3QWlZc0VKeGRRSnd4TVVMNUZBVUFBQkNpTUFJbUxBb0ZBVzRzRlRBa2xEMFFuRjRzRVVJQUxhblZ5YjNKZmRtOTBaWE5NVUVtTUFiNUZBVUVBQkNpTUFJbUxCUlpKakFPTEJJdi9VRXhRaS81UWl3Rk12NHYvRnlJU1FRRW1pd2RKZ1RwYklnZ1dYRHFNQjRzSFNZRktXeUlJRmx4S1NZd0hpd1pKdkVoTEFiK0xBb3NEWEVCSmdTaGJJZ2dXWENpTEFFeS9nVXBiZ1FjUFFRQ2Rpd2VCT2x1QkJBOUJBTWlMQnlwY01vc0RYRnFNQnljU2lQeThpd1pKdkVpTEIwbE9BcjhrV3lJU1FRQ1BnQklBRUdScGMzQjFkR1ZmY21WemIyeDJaV1NML29zRVR3S0wvNGo4V3lNbkNHVkVNZ01UUVFBd2dDMURVazlUVTE5RFQwNVVVa0ZEVkY5VFJWUlVURVZOUlU1VWMyVjBkR3hsYldWdWRGOTBjbWxuWjJWeVpXU3dnQkJFU1ZOUVZWUkZYMUpGVTA5TVZrVkVpd1JRc0NjVmlQdzFpLzZMQklBTEFBbDJiM1JsWDJOaGMzU0wvNGo3N3lxTUFJbUFFZ0FRWkdsemNIVjBaVjl5WldwbFkzUmxaRUwvYm9zSEp4aGNNb3NEWEZxTUJ5Y1RpUHZ6UXY4MGl3ZEpnVUpiSWdnV1hFS01CMEwrMTRvQkFZdi9GeFluQkV4UXZraEpWd2dnTWdNU1FRQm9nR1FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFHSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBVEltTEFFeUppZ0VCSndlTC8xQytRQUFRaS84b1VDaFFLRkFvVUNoUUtGQk1pWXNBVElraksyVkVGb2tuQzc1RWlZb0JBWXYvRnhZbkVFeFF2a2hKZ0R3QUFBQUFBQUFBQUFBNkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFTUVFCUGdFc0FBQUFBQUFBQUFBQTZBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUE5bGRtVnVkRjl1YjNSZlptOTFibVJNaVlzQVRJbUtBUUVqSndwbFJDSUpTWXYvRndraUNFa2lERUVBQXlLTUFZc0FGb3NCRmxDTUFJbUtBUUdML3hjV0p3Uk1VTDVBQUFNb1RJa3lCb3NBZ1ZKYkRVRUFDNHNBSkZ0QUFBUW5EVXlKaXdCWE1naE1pWW9BQVlBQUkwa25CbVZNU1U4Q1JDSUpJb3NFaXdJTVFRQWxpd1FXSndSTVVMNUlKRnVMQVl3QVFBQUdpd0VpQ0l3QWl3Q01BWXNFSWdpTUJFTC8wNHNCRm9zREZsQ01BSW1LQVFFbkI0di9VTDVBQUFNb1RJa3lCb3NBZ1RoYkNTUU1RUUFES2t5Sml3Q0JJRnNsREVFQUJDY1lUSWtuRFV5SmlnRUJJNEFBSXljR1pVUWlpd09MQWd4QkFDZUwveWNaVUNjTVRGQytSUUdMQVl3QVFRQUhpd0VuR1ZDTUFJc0FqQUdMQXlJSWpBTkMvOUdMQVl3QWlZb0NBWXYrZ0F0a2FYTndkWFJsWDJ0bGVWQW5ERXhRdmtVQktDcFBBazJKaWdFQkl5Y0ZaVVF4QUJKRWkvOFhGaWNFVEZCSnZrQUFCQ2lNQUltTEFTY05YREtMQUVtOFNFeS9KeFNJK1RNakp3VmxSSXYvVElBVEFCRmthWE53ZFhSbFgzQnliMk5sYzNObFpDaUkrT0tBR2tSSlUxQlZWRVZmVUZKUFEwVlRVMFZFY0hKdlkyVnpjMlZrc0NxTUFJbUtBUUVqSndobFJESURFMFNBTkZSU1NVZEhSVkpmVUU5TVNVTlpYMUJTVDBORlUxTkpUa2R3YjJ4cFkzbGZjSEp2WTJWemMybHVaMTkwY21sbloyVnlaV1N3S29rPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjEwLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
