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

namespace Arc56.Generated.LokoAnas.Algorand.AgentIDContract_2fbd1157
{


    //
    // 
    //    AgentID Proof-of-Excellence Protocol.
    //    Stores on-chain reputation for AI agents transacting via x402.
    //    
    //
    public class AgentIDContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgentIDContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AgentRecord : AVMObjectType
            {
                public string Did { get; set; }

                public ulong SettlementCount { get; set; }

                public ulong ConfirmedSettlements { get; set; }

                public ulong TotalVolume { get; set; }

                public ulong UniqueCounterpartyCount { get; set; }

                public ulong TimeWeightedVolume { get; set; }

                public ulong LastUpdateBlock { get; set; }

                public ulong StakeAlgo { get; set; }

                public ulong XalgoBalance { get; set; }

                public ulong EndorsementScore { get; set; }

                public ulong DisputeCount { get; set; }

                public ulong DisputeVolume { get; set; }

                public ulong PendingDisputeStake { get; set; }

                public ulong SandboxScenariosPassed { get; set; }

                public bool SandboxCertified { get; set; }

                public bool EuroAttested { get; set; }

                public ulong GenesisScore { get; set; }

                public ulong GenesisExpiryBlock { get; set; }

                public ulong CachedScore { get; set; }

                public ulong ScoreCachedAtBlock { get; set; }

                public bool IsRegistered { get; set; }

                public bool CautionFlag { get; set; }

                public ulong CreatedAtBlock { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDid.From(Did);
                    stringRef[ret.Count] = vDid.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSettlementCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSettlementCount.From(SettlementCount);
                    ret.AddRange(vSettlementCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vConfirmedSettlements = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vConfirmedSettlements.From(ConfirmedSettlements);
                    ret.AddRange(vConfirmedSettlements.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalVolume = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalVolume.From(TotalVolume);
                    ret.AddRange(vTotalVolume.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUniqueCounterpartyCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUniqueCounterpartyCount.From(UniqueCounterpartyCount);
                    ret.AddRange(vUniqueCounterpartyCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimeWeightedVolume = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimeWeightedVolume.From(TimeWeightedVolume);
                    ret.AddRange(vTimeWeightedVolume.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdateBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastUpdateBlock.From(LastUpdateBlock);
                    ret.AddRange(vLastUpdateBlock.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakeAlgo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStakeAlgo.From(StakeAlgo);
                    ret.AddRange(vStakeAlgo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXalgoBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vXalgoBalance.From(XalgoBalance);
                    ret.AddRange(vXalgoBalance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndorsementScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEndorsementScore.From(EndorsementScore);
                    ret.AddRange(vEndorsementScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputeCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDisputeCount.From(DisputeCount);
                    ret.AddRange(vDisputeCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputeVolume = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDisputeVolume.From(DisputeVolume);
                    ret.AddRange(vDisputeVolume.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPendingDisputeStake = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPendingDisputeStake.From(PendingDisputeStake);
                    ret.AddRange(vPendingDisputeStake.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSandboxScenariosPassed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSandboxScenariosPassed.From(SandboxScenariosPassed);
                    ret.AddRange(vSandboxScenariosPassed.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSandboxCertified = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vSandboxCertified.From(SandboxCertified);
                    ret.AddRange(vSandboxCertified.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEuroAttested = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vEuroAttested.From(EuroAttested);
                    ret.AddRange(vEuroAttested.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGenesisScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGenesisScore.From(GenesisScore);
                    ret.AddRange(vGenesisScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGenesisExpiryBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGenesisExpiryBlock.From(GenesisExpiryBlock);
                    ret.AddRange(vGenesisExpiryBlock.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCachedScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCachedScore.From(CachedScore);
                    ret.AddRange(vCachedScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScoreCachedAtBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vScoreCachedAtBlock.From(ScoreCachedAtBlock);
                    ret.AddRange(vScoreCachedAtBlock.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsRegistered = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsRegistered.From(IsRegistered);
                    ret.AddRange(vIsRegistered.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCautionFlag = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vCautionFlag.From(CautionFlag);
                    ret.AddRange(vCautionFlag.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAtBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAtBlock.From(CreatedAtBlock);
                    ret.AddRange(vCreatedAtBlock.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AgentRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AgentRecord();
                    uint count = 0;
                    var indexDid = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDid.Decode(bytes.Skip(indexDid + prefixOffset).ToArray());
                    var valueDid = vDid.ToValue();
                    if (valueDid is string vDidValue) { ret.Did = vDidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSettlementCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSettlementCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSettlementCount = vSettlementCount.ToValue();
                    if (valueSettlementCount is ulong vSettlementCountValue) { ret.SettlementCount = vSettlementCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vConfirmedSettlements = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vConfirmedSettlements.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueConfirmedSettlements = vConfirmedSettlements.ToValue();
                    if (valueConfirmedSettlements is ulong vConfirmedSettlementsValue) { ret.ConfirmedSettlements = vConfirmedSettlementsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalVolume = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalVolume.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalVolume = vTotalVolume.ToValue();
                    if (valueTotalVolume is ulong vTotalVolumeValue) { ret.TotalVolume = vTotalVolumeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUniqueCounterpartyCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUniqueCounterpartyCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUniqueCounterpartyCount = vUniqueCounterpartyCount.ToValue();
                    if (valueUniqueCounterpartyCount is ulong vUniqueCounterpartyCountValue) { ret.UniqueCounterpartyCount = vUniqueCounterpartyCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimeWeightedVolume = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimeWeightedVolume.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimeWeightedVolume = vTimeWeightedVolume.ToValue();
                    if (valueTimeWeightedVolume is ulong vTimeWeightedVolumeValue) { ret.TimeWeightedVolume = vTimeWeightedVolumeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdateBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastUpdateBlock.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastUpdateBlock = vLastUpdateBlock.ToValue();
                    if (valueLastUpdateBlock is ulong vLastUpdateBlockValue) { ret.LastUpdateBlock = vLastUpdateBlockValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakeAlgo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStakeAlgo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStakeAlgo = vStakeAlgo.ToValue();
                    if (valueStakeAlgo is ulong vStakeAlgoValue) { ret.StakeAlgo = vStakeAlgoValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXalgoBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vXalgoBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueXalgoBalance = vXalgoBalance.ToValue();
                    if (valueXalgoBalance is ulong vXalgoBalanceValue) { ret.XalgoBalance = vXalgoBalanceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndorsementScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEndorsementScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEndorsementScore = vEndorsementScore.ToValue();
                    if (valueEndorsementScore is ulong vEndorsementScoreValue) { ret.EndorsementScore = vEndorsementScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputeCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDisputeCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDisputeCount = vDisputeCount.ToValue();
                    if (valueDisputeCount is ulong vDisputeCountValue) { ret.DisputeCount = vDisputeCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputeVolume = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDisputeVolume.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDisputeVolume = vDisputeVolume.ToValue();
                    if (valueDisputeVolume is ulong vDisputeVolumeValue) { ret.DisputeVolume = vDisputeVolumeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPendingDisputeStake = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPendingDisputeStake.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePendingDisputeStake = vPendingDisputeStake.ToValue();
                    if (valuePendingDisputeStake is ulong vPendingDisputeStakeValue) { ret.PendingDisputeStake = vPendingDisputeStakeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSandboxScenariosPassed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSandboxScenariosPassed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSandboxScenariosPassed = vSandboxScenariosPassed.ToValue();
                    if (valueSandboxScenariosPassed is ulong vSandboxScenariosPassedValue) { ret.SandboxScenariosPassed = vSandboxScenariosPassedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSandboxCertified = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vSandboxCertified.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSandboxCertified = vSandboxCertified.ToValue();
                    if (valueSandboxCertified is bool vSandboxCertifiedValue) { ret.SandboxCertified = vSandboxCertifiedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEuroAttested = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vEuroAttested.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEuroAttested = vEuroAttested.ToValue();
                    if (valueEuroAttested is bool vEuroAttestedValue) { ret.EuroAttested = vEuroAttestedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGenesisScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGenesisScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGenesisScore = vGenesisScore.ToValue();
                    if (valueGenesisScore is ulong vGenesisScoreValue) { ret.GenesisScore = vGenesisScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGenesisExpiryBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGenesisExpiryBlock.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGenesisExpiryBlock = vGenesisExpiryBlock.ToValue();
                    if (valueGenesisExpiryBlock is ulong vGenesisExpiryBlockValue) { ret.GenesisExpiryBlock = vGenesisExpiryBlockValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCachedScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCachedScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCachedScore = vCachedScore.ToValue();
                    if (valueCachedScore is ulong vCachedScoreValue) { ret.CachedScore = vCachedScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScoreCachedAtBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vScoreCachedAtBlock.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueScoreCachedAtBlock = vScoreCachedAtBlock.ToValue();
                    if (valueScoreCachedAtBlock is ulong vScoreCachedAtBlockValue) { ret.ScoreCachedAtBlock = vScoreCachedAtBlockValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsRegistered = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsRegistered.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsRegistered = vIsRegistered.ToValue();
                    if (valueIsRegistered is bool vIsRegisteredValue) { ret.IsRegistered = vIsRegisteredValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCautionFlag = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vCautionFlag.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCautionFlag = vCautionFlag.ToValue();
                    if (valueCautionFlag is bool vCautionFlagValue) { ret.CautionFlag = vCautionFlagValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAtBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAtBlock.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAtBlock = vCreatedAtBlock.ToValue();
                    if (valueCreatedAtBlock is ulong vCreatedAtBlockValue) { ret.CreatedAtBlock = vCreatedAtBlockValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AgentRecord);
                }
                public bool Equals(AgentRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AgentRecord left, AgentRecord right)
                {
                    return EqualityComparer<AgentRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(AgentRecord left, AgentRecord right)
                {
                    return !(left == right);
                }

            }

            public class DisputeRecord : AVMObjectType
            {
                public Algorand.Address Disputer { get; set; }

                public Algorand.Address DisputedAgent { get; set; }

                public ulong TxAmount { get; set; }

                public ulong StakeLocked { get; set; }

                public ulong FiledAtBlock { get; set; }

                public bool Resolved { get; set; }

                public bool Upheld { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vDisputer.From(Disputer);
                    ret.AddRange(vDisputer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputedAgent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vDisputedAgent.From(DisputedAgent);
                    ret.AddRange(vDisputedAgent.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTxAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTxAmount.From(TxAmount);
                    ret.AddRange(vTxAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakeLocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStakeLocked.From(StakeLocked);
                    ret.AddRange(vStakeLocked.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFiledAtBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFiledAtBlock.From(FiledAtBlock);
                    ret.AddRange(vFiledAtBlock.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResolved = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vResolved.From(Resolved);
                    ret.AddRange(vResolved.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpheld = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vUpheld.From(Upheld);
                    ret.AddRange(vUpheld.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DisputeRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new DisputeRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDisputer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDisputer = vDisputer.ToValue();
                    if (valueDisputer is Algorand.Address vDisputerValue) { ret.Disputer = vDisputerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputedAgent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDisputedAgent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDisputedAgent = vDisputedAgent.ToValue();
                    if (valueDisputedAgent is Algorand.Address vDisputedAgentValue) { ret.DisputedAgent = vDisputedAgentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTxAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTxAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTxAmount = vTxAmount.ToValue();
                    if (valueTxAmount is ulong vTxAmountValue) { ret.TxAmount = vTxAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakeLocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStakeLocked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStakeLocked = vStakeLocked.ToValue();
                    if (valueStakeLocked is ulong vStakeLockedValue) { ret.StakeLocked = vStakeLockedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFiledAtBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFiledAtBlock.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFiledAtBlock = vFiledAtBlock.ToValue();
                    if (valueFiledAtBlock is ulong vFiledAtBlockValue) { ret.FiledAtBlock = vFiledAtBlockValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResolved = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vResolved.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueResolved = vResolved.ToValue();
                    if (valueResolved is bool vResolvedValue) { ret.Resolved = vResolvedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpheld = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vUpheld.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUpheld = vUpheld.ToValue();
                    if (valueUpheld is bool vUpheldValue) { ret.Upheld = vUpheldValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DisputeRecord);
                }
                public bool Equals(DisputeRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DisputeRecord left, DisputeRecord right)
                {
                    return EqualityComparer<DisputeRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(DisputeRecord left, DisputeRecord right)
                {
                    return !(left == right);
                }

            }

            public class EndorsementRecord : AVMObjectType
            {
                public Algorand.Address Endorser { get; set; }

                public Algorand.Address Endorsee { get; set; }

                public ulong StakeAmount { get; set; }

                public ulong EndorserScoreAtTime { get; set; }

                public ulong EndorsedAtBlock { get; set; }

                public bool Active { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndorser = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vEndorser.From(Endorser);
                    ret.AddRange(vEndorser.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndorsee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vEndorsee.From(Endorsee);
                    ret.AddRange(vEndorsee.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakeAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStakeAmount.From(StakeAmount);
                    ret.AddRange(vStakeAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndorserScoreAtTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEndorserScoreAtTime.From(EndorserScoreAtTime);
                    ret.AddRange(vEndorserScoreAtTime.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndorsedAtBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEndorsedAtBlock.From(EndorsedAtBlock);
                    ret.AddRange(vEndorsedAtBlock.Encode());
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

                public static EndorsementRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EndorsementRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndorser = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vEndorser.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEndorser = vEndorser.ToValue();
                    if (valueEndorser is Algorand.Address vEndorserValue) { ret.Endorser = vEndorserValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndorsee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vEndorsee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEndorsee = vEndorsee.ToValue();
                    if (valueEndorsee is Algorand.Address vEndorseeValue) { ret.Endorsee = vEndorseeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakeAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStakeAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStakeAmount = vStakeAmount.ToValue();
                    if (valueStakeAmount is ulong vStakeAmountValue) { ret.StakeAmount = vStakeAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndorserScoreAtTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEndorserScoreAtTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEndorserScoreAtTime = vEndorserScoreAtTime.ToValue();
                    if (valueEndorserScoreAtTime is ulong vEndorserScoreAtTimeValue) { ret.EndorserScoreAtTime = vEndorserScoreAtTimeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndorsedAtBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEndorsedAtBlock.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEndorsedAtBlock = vEndorsedAtBlock.ToValue();
                    if (valueEndorsedAtBlock is ulong vEndorsedAtBlockValue) { ret.EndorsedAtBlock = vEndorsedAtBlockValue; }
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
                    return Equals(obj as EndorsementRecord);
                }
                public bool Equals(EndorsementRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EndorsementRecord left, EndorsementRecord right)
                {
                    return EqualityComparer<EndorsementRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(EndorsementRecord left, EndorsementRecord right)
                {
                    return !(left == right);
                }

            }

            public class ScoreResult : AVMObjectType
            {
                public ulong Score { get; set; }

                public byte Tier { get; set; }

                public ulong SignalFinality { get; set; }

                public ulong SignalDiversity { get; set; }

                public ulong SignalDecay { get; set; }

                public ulong SignalEndorsement { get; set; }

                public ulong SignalDispute { get; set; }

                public ulong SettlementCount { get; set; }

                public ulong DisputeCount { get; set; }

                public ulong TotalVolume { get; set; }

                public ulong StakeAlgo { get; set; }

                public ulong XalgoBalance { get; set; }

                public bool SandboxCertified { get; set; }

                public ulong SandboxScenarios { get; set; }

                public bool EuroAttested { get; set; }

                public ulong GenesisScore { get; set; }

                public ulong GenesisExpiryBlock { get; set; }

                public bool CautionFlag { get; set; }

                public bool IsCached { get; set; }

                public ulong LastUpdateBlock { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vScore.From(Score);
                    ret.AddRange(vScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vTier.From(Tier);
                    ret.AddRange(vTier.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignalFinality = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSignalFinality.From(SignalFinality);
                    ret.AddRange(vSignalFinality.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignalDiversity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSignalDiversity.From(SignalDiversity);
                    ret.AddRange(vSignalDiversity.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignalDecay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSignalDecay.From(SignalDecay);
                    ret.AddRange(vSignalDecay.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignalEndorsement = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSignalEndorsement.From(SignalEndorsement);
                    ret.AddRange(vSignalEndorsement.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignalDispute = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSignalDispute.From(SignalDispute);
                    ret.AddRange(vSignalDispute.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSettlementCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSettlementCount.From(SettlementCount);
                    ret.AddRange(vSettlementCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputeCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDisputeCount.From(DisputeCount);
                    ret.AddRange(vDisputeCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalVolume = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalVolume.From(TotalVolume);
                    ret.AddRange(vTotalVolume.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakeAlgo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStakeAlgo.From(StakeAlgo);
                    ret.AddRange(vStakeAlgo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXalgoBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vXalgoBalance.From(XalgoBalance);
                    ret.AddRange(vXalgoBalance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSandboxCertified = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vSandboxCertified.From(SandboxCertified);
                    ret.AddRange(vSandboxCertified.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSandboxScenarios = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSandboxScenarios.From(SandboxScenarios);
                    ret.AddRange(vSandboxScenarios.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEuroAttested = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vEuroAttested.From(EuroAttested);
                    ret.AddRange(vEuroAttested.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGenesisScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGenesisScore.From(GenesisScore);
                    ret.AddRange(vGenesisScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGenesisExpiryBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGenesisExpiryBlock.From(GenesisExpiryBlock);
                    ret.AddRange(vGenesisExpiryBlock.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCautionFlag = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vCautionFlag.From(CautionFlag);
                    ret.AddRange(vCautionFlag.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsCached = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsCached.From(IsCached);
                    ret.AddRange(vIsCached.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdateBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastUpdateBlock.From(LastUpdateBlock);
                    ret.AddRange(vLastUpdateBlock.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ScoreResult Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ScoreResult();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueScore = vScore.ToValue();
                    if (valueScore is ulong vScoreValue) { ret.Score = vScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vTier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTier = vTier.ToValue();
                    if (valueTier is byte vTierValue) { ret.Tier = vTierValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignalFinality = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSignalFinality.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSignalFinality = vSignalFinality.ToValue();
                    if (valueSignalFinality is ulong vSignalFinalityValue) { ret.SignalFinality = vSignalFinalityValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignalDiversity = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSignalDiversity.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSignalDiversity = vSignalDiversity.ToValue();
                    if (valueSignalDiversity is ulong vSignalDiversityValue) { ret.SignalDiversity = vSignalDiversityValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignalDecay = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSignalDecay.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSignalDecay = vSignalDecay.ToValue();
                    if (valueSignalDecay is ulong vSignalDecayValue) { ret.SignalDecay = vSignalDecayValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignalEndorsement = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSignalEndorsement.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSignalEndorsement = vSignalEndorsement.ToValue();
                    if (valueSignalEndorsement is ulong vSignalEndorsementValue) { ret.SignalEndorsement = vSignalEndorsementValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignalDispute = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSignalDispute.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSignalDispute = vSignalDispute.ToValue();
                    if (valueSignalDispute is ulong vSignalDisputeValue) { ret.SignalDispute = vSignalDisputeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSettlementCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSettlementCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSettlementCount = vSettlementCount.ToValue();
                    if (valueSettlementCount is ulong vSettlementCountValue) { ret.SettlementCount = vSettlementCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDisputeCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDisputeCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDisputeCount = vDisputeCount.ToValue();
                    if (valueDisputeCount is ulong vDisputeCountValue) { ret.DisputeCount = vDisputeCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalVolume = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalVolume.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalVolume = vTotalVolume.ToValue();
                    if (valueTotalVolume is ulong vTotalVolumeValue) { ret.TotalVolume = vTotalVolumeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStakeAlgo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStakeAlgo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStakeAlgo = vStakeAlgo.ToValue();
                    if (valueStakeAlgo is ulong vStakeAlgoValue) { ret.StakeAlgo = vStakeAlgoValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXalgoBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vXalgoBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueXalgoBalance = vXalgoBalance.ToValue();
                    if (valueXalgoBalance is ulong vXalgoBalanceValue) { ret.XalgoBalance = vXalgoBalanceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSandboxCertified = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vSandboxCertified.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSandboxCertified = vSandboxCertified.ToValue();
                    if (valueSandboxCertified is bool vSandboxCertifiedValue) { ret.SandboxCertified = vSandboxCertifiedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSandboxScenarios = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSandboxScenarios.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSandboxScenarios = vSandboxScenarios.ToValue();
                    if (valueSandboxScenarios is ulong vSandboxScenariosValue) { ret.SandboxScenarios = vSandboxScenariosValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEuroAttested = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vEuroAttested.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEuroAttested = vEuroAttested.ToValue();
                    if (valueEuroAttested is bool vEuroAttestedValue) { ret.EuroAttested = vEuroAttestedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGenesisScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGenesisScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGenesisScore = vGenesisScore.ToValue();
                    if (valueGenesisScore is ulong vGenesisScoreValue) { ret.GenesisScore = vGenesisScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGenesisExpiryBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGenesisExpiryBlock.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGenesisExpiryBlock = vGenesisExpiryBlock.ToValue();
                    if (valueGenesisExpiryBlock is ulong vGenesisExpiryBlockValue) { ret.GenesisExpiryBlock = vGenesisExpiryBlockValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCautionFlag = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vCautionFlag.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCautionFlag = vCautionFlag.ToValue();
                    if (valueCautionFlag is bool vCautionFlagValue) { ret.CautionFlag = vCautionFlagValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsCached = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsCached.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsCached = vIsCached.ToValue();
                    if (valueIsCached is bool vIsCachedValue) { ret.IsCached = vIsCachedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdateBlock = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastUpdateBlock.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastUpdateBlock = vLastUpdateBlock.ToValue();
                    if (valueLastUpdateBlock is ulong vLastUpdateBlockValue) { ret.LastUpdateBlock = vLastUpdateBlockValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ScoreResult);
                }
                public bool Equals(ScoreResult? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ScoreResult left, ScoreResult right)
                {
                    return EqualityComparer<ScoreResult>.Default.Equals(left, right);
                }
                public static bool operator !=(ScoreResult left, ScoreResult right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Deploy and initialise the contract. Caller becomes admin.
        ///</summary>
        /// <param name="euro_oracle"> </param>
        /// <param name="sandbox_authority"> </param>
        public async Task Bootstrap(Algorand.Address euro_oracle, Algorand.Address sandbox_authority, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 90, 7, 168 };
            var euro_oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); euro_oracleAbi.From(euro_oracle);
            var sandbox_authorityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sandbox_authorityAbi.From(sandbox_authority);

            var result = await base.CallApp(new List<object> { abiHandle, euro_oracleAbi, sandbox_authorityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Algorand.Address euro_oracle, Algorand.Address sandbox_authority, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 90, 7, 168 };
            var euro_oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); euro_oracleAbi.From(euro_oracle);
            var sandbox_authorityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sandbox_authorityAbi.From(sandbox_authority);

            return await base.MakeTransactionList(new List<object> { abiHandle, euro_oracleAbi, sandbox_authorityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register the calling account as an AgentID participant.
        ///</summary>
        /// <param name="did"> </param>
        public async Task RegisterAgent(string did, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 156, 114, 52 };
            var didAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); didAbi.From(did);

            var result = await base.CallApp(new List<object> { abiHandle, didAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterAgent_Transactions(string did, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 156, 114, 52 };
            var didAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); didAbi.From(did);

            return await base.MakeTransactionList(new List<object> { abiHandle, didAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record the outcome of an x402 settlement for the calling agent.
        ///Must be submitted as part of an atomic group where tx[group_index-1] is the payment (ALGO Payment or ASA Transfer) to the receiver.
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="asset_id"> </param>
        /// <param name="counterparty"> </param>
        /// <param name="settled"> </param>
        public async Task RecordSettlement(ulong amount, ulong asset_id, Algorand.Address counterparty, bool settled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 185, 99, 164 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var counterpartyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); counterpartyAbi.From(counterparty);
            var settledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); settledAbi.From(settled);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, asset_idAbi, counterpartyAbi, settledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordSettlement_Transactions(ulong amount, ulong asset_id, Algorand.Address counterparty, bool settled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 185, 99, 164 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var counterpartyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); counterpartyAbi.From(counterparty);
            var settledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); settledAbi.From(settled);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, asset_idAbi, counterpartyAbi, settledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the agent's current score.
        ///Returns cached value if fresh (< STALENESS_WINDOW_BLOCKS old), otherwise recomputes all 5 signals and writes a new cache entry.
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<Structs.ScoreResult> ReadScore(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 236, 41, 255 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.SimApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ScoreResult.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ReadScore_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 236, 41, 255 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Force-recompute and cache the score for any agent.
        ///Non-readonly so the cache write persists on-chain. Called by the middleware when the cached score is stale.
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<Structs.ScoreResult> RefreshScore(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 195, 95, 173 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ScoreResult.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> RefreshScore_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 195, 95, 173 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Stake ALGO for the calling agent via Folks Finance xALGO pool.
        ///The preceding transaction in the group must be a Payment of ALGO to this contract address. Must be preceded (group_index - 1) by a Payment tx.
        ///</summary>
        public async Task StakeOnAgent(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 51, 252, 134 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StakeOnAgent_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 51, 252, 134 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Slash a portion of an agent's stake on upheld dispute.
        ///Only callable by admin.
        ///</summary>
        /// <param name="agent"> </param>
        /// <param name="slash_amount"> </param>
        public async Task SlashStake(Algorand.Address agent, ulong slash_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 19, 162, 206 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var slash_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); slash_amountAbi.From(slash_amount);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi, slash_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SlashStake_Transactions(Algorand.Address agent, ulong slash_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 19, 162, 206 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var slash_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); slash_amountAbi.From(slash_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi, slash_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw stake (minus any holds for pending disputes).
        ///</summary>
        /// <param name="amount"> </param>
        public async Task UnstakeFromAgent(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 69, 38, 132 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UnstakeFromAgent_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 69, 38, 132 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///File a dispute against a recent settlement.
        ///Rule A: disputer must provide stake = 2× tx_amount (via preceding Payment tx). Rule B: dispute impact = (tx_amount / total_volume) × base_penalty — negligible         against high-volume legitimate agents. Returns the dispute ID.
        ///</summary>
        /// <param name="disputed_agent"> </param>
        /// <param name="tx_amount"> </param>
        public async Task<ulong> FileDispute(Algorand.Address disputed_agent, ulong tx_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 201, 48, 84 };
            var disputed_agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); disputed_agentAbi.From(disputed_agent);
            var tx_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tx_amountAbi.From(tx_amount);

            var result = await base.CallApp(new List<object> { abiHandle, disputed_agentAbi, tx_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> FileDispute_Transactions(Algorand.Address disputed_agent, ulong tx_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 201, 48, 84 };
            var disputed_agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); disputed_agentAbi.From(disputed_agent);
            var tx_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tx_amountAbi.From(tx_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, disputed_agentAbi, tx_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Resolve a dispute (admin only in MVP; Rule C automation in Milestone 1).
        ///If upheld=True: slash agent stake, disputer keeps locked stake. If upheld=False: disputer loses 50% of locked stake to agent as compensation.
        ///</summary>
        /// <param name="dispute_id"> </param>
        /// <param name="upheld"> </param>
        public async Task ResolveDispute(ulong dispute_id, bool upheld, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 122, 232, 233 };
            var dispute_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dispute_idAbi.From(dispute_id);
            var upheldAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); upheldAbi.From(upheld);

            var result = await base.CallApp(new List<object> { abiHandle, dispute_idAbi, upheldAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ResolveDispute_Transactions(ulong dispute_id, bool upheld, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 122, 232, 233 };
            var dispute_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dispute_idAbi.From(dispute_id);
            var upheldAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); upheldAbi.From(upheld);

            return await base.MakeTransactionList(new List<object> { abiHandle, dispute_idAbi, upheldAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Endorse another agent by staking ALGO behind them.
        ///Endorser must be Verified tier (score ≥ 80). Preceding tx must be a Payment of stake_amount to this contract.
        ///</summary>
        /// <param name="endorsee"> </param>
        /// <param name="stake_amount"> </param>
        public async Task EndorseAgent(Algorand.Address endorsee, ulong stake_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 172, 221, 137 };
            var endorseeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); endorseeAbi.From(endorsee);
            var stake_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stake_amountAbi.From(stake_amount);

            var result = await base.CallApp(new List<object> { abiHandle, endorseeAbi, stake_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> EndorseAgent_Transactions(Algorand.Address endorsee, ulong stake_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 172, 221, 137 };
            var endorseeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); endorseeAbi.From(endorsee);
            var stake_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stake_amountAbi.From(stake_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, endorseeAbi, stake_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Issue or update Reputation Sandbox certificate for an agent.
        ///Only callable by the sandbox_authority.
        ///</summary>
        /// <param name="agent"> </param>
        /// <param name="scenarios_passed"> </param>
        public async Task SetSandboxCertified(Algorand.Address agent, ulong scenarios_passed, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 217, 31, 49 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var scenarios_passedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scenarios_passedAbi.From(scenarios_passed);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi, scenarios_passedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetSandboxCertified_Transactions(Algorand.Address agent, ulong scenarios_passed, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 217, 31, 49 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var scenarios_passedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scenarios_passedAbi.From(scenarios_passed);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi, scenarios_passedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set the EURO identity attestation flag for an agent.
        ///Only callable by the Quantos oracle address (euro_oracle).
        ///</summary>
        /// <param name="agent"> </param>
        public async Task SetEuroAttestation(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 38, 216, 108 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetEuroAttestation_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 38, 216, 108 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Assign Genesis Score 50 to the founding cohort (max 3 in MVP).
        ///Scores are transparently declared, time-limited, and decay automatically. Only callable by admin.
        ///</summary>
        /// <param name="member1"> </param>
        /// <param name="member2"> </param>
        /// <param name="member3"> </param>
        public async Task GenesisInitialize(Algorand.Address member1, Algorand.Address member2, Algorand.Address member3, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 118, 139, 65 };
            var member1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); member1Abi.From(member1);
            var member2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); member2Abi.From(member2);
            var member3Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); member3Abi.From(member3);

            var result = await base.CallApp(new List<object> { abiHandle, member1Abi, member2Abi, member3Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GenesisInitialize_Transactions(Algorand.Address member1, Algorand.Address member2, Algorand.Address member3, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 118, 139, 65 };
            var member1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); member1Abi.From(member1);
            var member2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); member2Abi.From(member2);
            var member3Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); member3Abi.From(member3);

            return await base.MakeTransactionList(new List<object> { abiHandle, member1Abi, member2Abi, member3Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer admin role. Only current admin.
        ///</summary>
        /// <param name="new_admin"> </param>
        public async Task UpdateAdmin(Algorand.Address new_admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 22, 94, 231 };
            var new_adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_adminAbi.From(new_admin);

            var result = await base.CallApp(new List<object> { abiHandle, new_adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAdmin_Transactions(Algorand.Address new_admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 22, 94, 231 };
            var new_adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_adminAbi.From(new_admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the Quantos euro oracle address.
        ///</summary>
        /// <param name="new_oracle"> </param>
        public async Task UpdateEuroOracle(Algorand.Address new_oracle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 153, 50, 14 };
            var new_oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_oracleAbi.From(new_oracle);

            var result = await base.CallApp(new List<object> { abiHandle, new_oracleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateEuroOracle_Transactions(Algorand.Address new_oracle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 153, 50, 14 };
            var new_oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_oracleAbi.From(new_oracle);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_oracleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRJRENvbnRyYWN0IiwiZGVzYyI6IlxuICAgIEFnZW50SUQgUHJvb2Ytb2YtRXhjZWxsZW5jZSBQcm90b2NvbC5cbiAgICBTdG9yZXMgb24tY2hhaW4gcmVwdXRhdGlvbiBmb3IgQUkgYWdlbnRzIHRyYW5zYWN0aW5nIHZpYSB4NDAyLlxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBZ2VudFJlY29yZCI6W3sibmFtZSI6ImRpZCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJzZXR0bGVtZW50X2NvdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNvbmZpcm1lZF9zZXR0bGVtZW50cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbF92b2x1bWUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidW5pcXVlX2NvdW50ZXJwYXJ0eV9jb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0aW1lX3dlaWdodGVkX3ZvbHVtZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXN0X3VwZGF0ZV9ibG9jayIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGFrZV9hbGdvIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InhhbGdvX2JhbGFuY2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZW5kb3JzZW1lbnRfc2NvcmUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZGlzcHV0ZV9jb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkaXNwdXRlX3ZvbHVtZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwZW5kaW5nX2Rpc3B1dGVfc3Rha2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic2FuZGJveF9zY2VuYXJpb3NfcGFzc2VkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNhbmRib3hfY2VydGlmaWVkIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJldXJvX2F0dGVzdGVkIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJnZW5lc2lzX3Njb3JlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImdlbmVzaXNfZXhwaXJ5X2Jsb2NrIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNhY2hlZF9zY29yZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzY29yZV9jYWNoZWRfYXRfYmxvY2siLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaXNfcmVnaXN0ZXJlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiY2F1dGlvbl9mbGFnIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJjcmVhdGVkX2F0X2Jsb2NrIiwidHlwZSI6InVpbnQ2NCJ9XSwiRGlzcHV0ZVJlY29yZCI6W3sibmFtZSI6ImRpc3B1dGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJkaXNwdXRlZF9hZ2VudCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidHhfYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YWtlX2xvY2tlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWxlZF9hdF9ibG9jayIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZXNvbHZlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoidXBoZWxkIiwidHlwZSI6ImJvb2wifV0sIkVuZG9yc2VtZW50UmVjb3JkIjpbeyJuYW1lIjoiZW5kb3JzZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImVuZG9yc2VlIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJzdGFrZV9hbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZW5kb3JzZXJfc2NvcmVfYXRfdGltZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlbmRvcnNlZF9hdF9ibG9jayIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhY3RpdmUiLCJ0eXBlIjoiYm9vbCJ9XSwiU2NvcmVSZXN1bHQiOlt7Im5hbWUiOiJzY29yZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0aWVyIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoic2lnbmFsX2ZpbmFsaXR5IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNpZ25hbF9kaXZlcnNpdHkiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic2lnbmFsX2RlY2F5IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNpZ25hbF9lbmRvcnNlbWVudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzaWduYWxfZGlzcHV0ZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzZXR0bGVtZW50X2NvdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRpc3B1dGVfY291bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfdm9sdW1lIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YWtlX2FsZ28iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoieGFsZ29fYmFsYW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzYW5kYm94X2NlcnRpZmllZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoic2FuZGJveF9zY2VuYXJpb3MiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZXVyb19hdHRlc3RlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZ2VuZXNpc19zY29yZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJnZW5lc2lzX2V4cGlyeV9ibG9jayIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjYXV0aW9uX2ZsYWciLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImlzX2NhY2hlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoibGFzdF91cGRhdGVfYmxvY2siLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOiJEZXBsb3kgYW5kIGluaXRpYWxpc2UgdGhlIGNvbnRyYWN0LiBDYWxsZXIgYmVjb21lcyBhZG1pbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV1cm9fb3JhY2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FuZGJveF9hdXRob3JpdHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXJfYWdlbnQiLCJkZXNjIjoiUmVnaXN0ZXIgdGhlIGNhbGxpbmcgYWNjb3VudCBhcyBhbiBBZ2VudElEIHBhcnRpY2lwYW50LiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjb3JkX3NldHRsZW1lbnQiLCJkZXNjIjoiUmVjb3JkIHRoZSBvdXRjb21lIG9mIGFuIHg0MDIgc2V0dGxlbWVudCBmb3IgdGhlIGNhbGxpbmcgYWdlbnQuXG5NdXN0IGJlIHN1Ym1pdHRlZCBhcyBwYXJ0IG9mIGFuIGF0b21pYyBncm91cCB3aGVyZSB0eFtncm91cF9pbmRleC0xXSBpcyB0aGUgcGF5bWVudCAoQUxHTyBQYXltZW50IG9yIEFTQSBUcmFuc2ZlcikgdG8gdGhlIHJlY2VpdmVyLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY291bnRlcnBhcnR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2V0dGxlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWFkX3Njb3JlIiwiZGVzYyI6IlJldHVybiB0aGUgYWdlbnQncyBjdXJyZW50IHNjb3JlLlxuUmV0dXJucyBjYWNoZWQgdmFsdWUgaWYgZnJlc2ggKDwgU1RBTEVORVNTX1dJTkRPV19CTE9DS1Mgb2xkKSwgb3RoZXJ3aXNlIHJlY29tcHV0ZXMgYWxsIDUgc2lnbmFscyBhbmQgd3JpdGVzIGEgbmV3IGNhY2hlIGVudHJ5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50OCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCx1aW50NjQsYm9vbCx1aW50NjQsdWludDY0LGJvb2wsYm9vbCx1aW50NjQpIiwic3RydWN0IjoiU2NvcmVSZXN1bHQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZnJlc2hfc2NvcmUiLCJkZXNjIjoiRm9yY2UtcmVjb21wdXRlIGFuZCBjYWNoZSB0aGUgc2NvcmUgZm9yIGFueSBhZ2VudC5cbk5vbi1yZWFkb25seSBzbyB0aGUgY2FjaGUgd3JpdGUgcGVyc2lzdHMgb24tY2hhaW4uIENhbGxlZCBieSB0aGUgbWlkZGxld2FyZSB3aGVuIHRoZSBjYWNoZWQgc2NvcmUgaXMgc3RhbGUuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ4LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sLHVpbnQ2NCxib29sLHVpbnQ2NCx1aW50NjQsYm9vbCxib29sLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJTY29yZVJlc3VsdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0YWtlX29uX2FnZW50IiwiZGVzYyI6IlN0YWtlIEFMR08gZm9yIHRoZSBjYWxsaW5nIGFnZW50IHZpYSBGb2xrcyBGaW5hbmNlIHhBTEdPIHBvb2wuXG5UaGUgcHJlY2VkaW5nIHRyYW5zYWN0aW9uIGluIHRoZSBncm91cCBtdXN0IGJlIGEgUGF5bWVudCBvZiBBTEdPIHRvIHRoaXMgY29udHJhY3QgYWRkcmVzcy4gTXVzdCBiZSBwcmVjZWRlZCAoZ3JvdXBfaW5kZXggLSAxKSBieSBhIFBheW1lbnQgdHguIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNsYXNoX3N0YWtlIiwiZGVzYyI6IlNsYXNoIGEgcG9ydGlvbiBvZiBhbiBhZ2VudCdzIHN0YWtlIG9uIHVwaGVsZCBkaXNwdXRlLlxuT25seSBjYWxsYWJsZSBieSBhZG1pbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzbGFzaF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5zdGFrZV9mcm9tX2FnZW50IiwiZGVzYyI6IldpdGhkcmF3IHN0YWtlIChtaW51cyBhbnkgaG9sZHMgZm9yIHBlbmRpbmcgZGlzcHV0ZXMpLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZmlsZV9kaXNwdXRlIiwiZGVzYyI6IkZpbGUgYSBkaXNwdXRlIGFnYWluc3QgYSByZWNlbnQgc2V0dGxlbWVudC5cblJ1bGUgQTogZGlzcHV0ZXIgbXVzdCBwcm92aWRlIHN0YWtlID0gMsOXIHR4X2Ftb3VudCAodmlhIHByZWNlZGluZyBQYXltZW50IHR4KS4gUnVsZSBCOiBkaXNwdXRlIGltcGFjdCA9ICh0eF9hbW91bnQgLyB0b3RhbF92b2x1bWUpIMOXIGJhc2VfcGVuYWx0eSDigJQgbmVnbGlnaWJsZSAgICAgICAgIGFnYWluc3QgaGlnaC12b2x1bWUgbGVnaXRpbWF0ZSBhZ2VudHMuIFJldHVybnMgdGhlIGRpc3B1dGUgSUQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkaXNwdXRlZF9hZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVzb2x2ZV9kaXNwdXRlIiwiZGVzYyI6IlJlc29sdmUgYSBkaXNwdXRlIChhZG1pbiBvbmx5IGluIE1WUDsgUnVsZSBDIGF1dG9tYXRpb24gaW4gTWlsZXN0b25lIDEpLlxuSWYgdXBoZWxkPVRydWU6IHNsYXNoIGFnZW50IHN0YWtlLCBkaXNwdXRlciBrZWVwcyBsb2NrZWQgc3Rha2UuIElmIHVwaGVsZD1GYWxzZTogZGlzcHV0ZXIgbG9zZXMgNTAlIG9mIGxvY2tlZCBzdGFrZSB0byBhZ2VudCBhcyBjb21wZW5zYXRpb24uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRpc3B1dGVfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1cGhlbGQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW5kb3JzZV9hZ2VudCIsImRlc2MiOiJFbmRvcnNlIGFub3RoZXIgYWdlbnQgYnkgc3Rha2luZyBBTEdPIGJlaGluZCB0aGVtLlxuRW5kb3JzZXIgbXVzdCBiZSBWZXJpZmllZCB0aWVyIChzY29yZSDiiaUgODApLiBQcmVjZWRpbmcgdHggbXVzdCBiZSBhIFBheW1lbnQgb2Ygc3Rha2VfYW1vdW50IHRvIHRoaXMgY29udHJhY3QuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmRvcnNlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Rha2VfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9zYW5kYm94X2NlcnRpZmllZCIsImRlc2MiOiJJc3N1ZSBvciB1cGRhdGUgUmVwdXRhdGlvbiBTYW5kYm94IGNlcnRpZmljYXRlIGZvciBhbiBhZ2VudC5cbk9ubHkgY2FsbGFibGUgYnkgdGhlIHNhbmRib3hfYXV0aG9yaXR5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjZW5hcmlvc19wYXNzZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2V1cm9fYXR0ZXN0YXRpb24iLCJkZXNjIjoiU2V0IHRoZSBFVVJPIGlkZW50aXR5IGF0dGVzdGF0aW9uIGZsYWcgZm9yIGFuIGFnZW50LlxuT25seSBjYWxsYWJsZSBieSB0aGUgUXVhbnRvcyBvcmFjbGUgYWRkcmVzcyAoZXVyb19vcmFjbGUpLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2VuZXNpc19pbml0aWFsaXplIiwiZGVzYyI6IkFzc2lnbiBHZW5lc2lzIFNjb3JlIDUwIHRvIHRoZSBmb3VuZGluZyBjb2hvcnQgKG1heCAzIGluIE1WUCkuXG5TY29yZXMgYXJlIHRyYW5zcGFyZW50bHkgZGVjbGFyZWQsIHRpbWUtbGltaXRlZCwgYW5kIGRlY2F5IGF1dG9tYXRpY2FsbHkuIE9ubHkgY2FsbGFibGUgYnkgYWRtaW4uIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZW1iZXIxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVtYmVyMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1lbWJlcjMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX2FkbWluIiwiZGVzYyI6IlRyYW5zZmVyIGFkbWluIHJvbGUuIE9ubHkgY3VycmVudCBhZG1pbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19hZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfZXVyb19vcmFjbGUiLCJkZXNjIjoiVXBkYXRlIHRoZSBRdWFudG9zIGV1cm8gb3JhY2xlIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3JhY2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6M30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjkxLDI5OSw2NDAsNzU1LDg3MiwxMDY4LDEzMjksMTc4NiwxOTI3LDE5OTEsMjA2NywyMTU1LDIxODBdLCJlcnJvck1lc3NhZ2UiOiJBZGRyZXNzIGxlbmd0aCBpcyAzMiBieXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNjMsMTQ4MSwyMDU0LDIxNTIsMjE3N10sImVycm9yTWVzc2FnZSI6ImFkbWluIG9ubHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTcsNzY0LDg4MCw5NTEsMTA4MCwxMTg5LDE5MzYsMTk5OV0sImVycm9yTWVzc2FnZSI6ImFnZW50IG5vdCByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM2XSwiZXJyb3JNZXNzYWdlIjoiYWxyZWFkeSByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUxMl0sImVycm9yTWVzc2FnZSI6ImFscmVhZHkgcmVzb2x2ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzkxXSwiZXJyb3JNZXNzYWdlIjoiY2Fubm90IHNlbGYtZW5kb3JzZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNjEsMTQ3OSwyMDUyLDIxNTAsMjE3NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGlzcHV0ZV9jb3VudGVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5ODZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmV1cm9fb3JhY2xlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnNhbmRib3hfYXV0aG9yaXR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfYWdlbnRzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0OTZdLCJlcnJvck1lc3NhZ2UiOiJkaXNwdXRlIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NDhdLCJlcnJvck1lc3NhZ2UiOiJkaXNwdXRlZCBhZ2VudCBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzM4XSwiZXJyb3JNZXNzYWdlIjoiZGlzcHV0ZWQgYWdlbnQgbm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODA5XSwiZXJyb3JNZXNzYWdlIjoiZW5kb3JzZWUgbm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODMxXSwiZXJyb3JNZXNzYWdlIjoiZW5kb3JzZXIgbXVzdCBiZSBWZXJpZmllZCB0aWVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgwMF0sImVycm9yTWVzc2FnZSI6ImVuZG9yc2VyIG5vdCByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk4OF0sImVycm9yTWVzc2FnZSI6ImV1cm8gb3JhY2xlIG9ubHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzYwXSwiZXJyb3JNZXNzYWdlIjoiaW5zdWZmaWNpZW50IGRpc3B1dGUgc3Rha2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjI2XSwiZXJyb3JNZXNzYWdlIjoiaW5zdWZmaWNpZW50IHdpdGhkcmF3YWJsZSBzdGFrZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0NSwxNDczXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzMsMjgyLDUzNyw3NTIsODY5LDEwNDYsMTMxMywxNzcwLDE5MDQsMTk3OSwyMDI2LDIwMzYsMjA0NiwyMTQ0LDIxNjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTIwLDUyOCwxMDU1LDExNzcsMTMyMiwxNDY1LDE3NzksMTkxM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2N10sImVycm9yTWVzc2FnZSI6Im1pbmltdW0gc3Rha2UgaXMgMSBBTEdPIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjczMV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkyMl0sImVycm9yTWVzc2FnZSI6InNhbmRib3ggYXV0aG9yaXR5IG9ubHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODQ0XSwiZXJyb3JNZXNzYWdlIjoic3Rha2UgcGF5bWVudCBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTXpJZ01UQXdJREV3TURBZ01URXhNeUE0TkRnZ01UQXdPREF3SURJd01EQXdNQ0F4TURBd01EQXdNREF3TURBS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnMk1UWTNOV1lnTUhnd01EQXdNREF3TURBd01EQXdNREF3SURCNE1EQWdJbUZrYldsdUlpQWlaR2x6Y0hWMFpWOWpiM1Z1ZEdWeUlpQWlkRzkwWVd4ZllXZGxiblJ6SWlBaVpYVnliMTl2Y21GamJHVWlJREI0TVRVeFpqZGpOelVnSW5OaGJtUmliM2hmWVhWMGFHOXlhWFI1SWlBd2VEWTBOekExWmdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2T0RNS0lDQWdJQzh2SUhObGJHWXVaR2x6Y0hWMFpWOWpiM1Z1ZEdWeU9pQkhiRzlpWVd4VGRHRjBaVnRWU1c1ME5qUmRJRDBnUjJ4dlltRnNVM1JoZEdVb1ZVbHVkRFkwS0RBcEtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVpHbHpjSFYwWlY5amIzVnVkR1Z5SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvNE5Bb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOWhaMlZ1ZEhNNklFZHNiMkpoYkZOMFlYUmxXMVZKYm5RMk5GMGdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIzUmhiRjloWjJWdWRITWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk56SUtJQ0FnSUM4dklHTnNZWE56SUVGblpXNTBTVVJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF5TVFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdVMU9XTTNNak0wSURCNE16VmlPVFl6WVRRZ01IaGlaR1ZqTWpsbVppQXdlR0k0WXpNMVptRmtJREI0WldZek0yWmpPRFlnTUhnMU5ERXpZVEpqWlNBd2VEVmpORFV5TmpnMElEQjRORE5qT1RNd05UUWdNSGczTmpkaFpUaGxPU0F3ZURjellXTmtaRGc1SURCNE5XWmtPVEZtTXpFZ01IZzNOekkyWkRnMll5QXdlR1kwTnpZNFlqUXhJREI0TkdFeE5qVmxaVGNnTUhnNVpEazVNekl3WlNBdkx5QnRaWFJvYjJRZ0luSmxaMmx6ZEdWeVgyRm5aVzUwS0hOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSnlaV052Y21SZmMyVjBkR3hsYldWdWRDaDFhVzUwTmpRc2RXbHVkRFkwTEdGa1pISmxjM01zWW05dmJDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXRmtYM05qYjNKbEtHRmtaSEpsYzNNcEtIVnBiblEyTkN4MWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkN4MWFXNTBOalFzWW05dmJDeDFhVzUwTmpRc2RXbHVkRFkwTEdKdmIyd3NZbTl2YkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKeVpXWnlaWE5vWDNOamIzSmxLR0ZrWkhKbGMzTXBLSFZwYm5RMk5DeDFhVzUwT0N4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzWW05dmJDeDFhVzUwTmpRc1ltOXZiQ3gxYVc1ME5qUXNkV2x1ZERZMExHSnZiMndzWW05dmJDeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSnpkR0ZyWlY5dmJsOWhaMlZ1ZENncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJ4aGMyaGZjM1JoYTJVb1lXUmtjbVZ6Y3l4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlkVzV6ZEdGclpWOW1jbTl0WDJGblpXNTBLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKbWFXeGxYMlJwYzNCMWRHVW9ZV1JrY21WemN5eDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKeVpYTnZiSFpsWDJScGMzQjFkR1VvZFdsdWREWTBMR0p2YjJ3cGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWlc1a2IzSnpaVjloWjJWdWRDaGhaR1J5WlhOekxIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSZmMyRnVaR0p2ZUY5alpYSjBhV1pwWldRb1lXUmtjbVZ6Y3l4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDJWMWNtOWZZWFIwWlhOMFlYUnBiMjRvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSm5aVzVsYzJselgybHVhWFJwWVd4cGVtVW9ZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxYMkZrYldsdUtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxYMlYxY205ZmIzSmhZMnhsS0dGa1pISmxjM01wZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JSEpsWjJsemRHVnlYMkZuWlc1MElISmxZMjl5WkY5elpYUjBiR1Z0Wlc1MElISmxZV1JmYzJOdmNtVWdjbVZtY21WemFGOXpZMjl5WlNCemRHRnJaVjl2Ymw5aFoyVnVkQ0J6YkdGemFGOXpkR0ZyWlNCMWJuTjBZV3RsWDJaeWIyMWZZV2RsYm5RZ1ptbHNaVjlrYVhOd2RYUmxJSEpsYzI5c2RtVmZaR2x6Y0hWMFpTQmxibVJ2Y25ObFgyRm5aVzUwSUhObGRGOXpZVzVrWW05NFgyTmxjblJwWm1sbFpDQnpaWFJmWlhWeWIxOWhkSFJsYzNSaGRHbHZiaUJuWlc1bGMybHpYMmx1YVhScFlXeHBlbVVnZFhCa1lYUmxYMkZrYldsdUlIVndaR0YwWlY5bGRYSnZYMjl5WVdOc1pRb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FESXhPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TnpJS0lDQWdJQzh2SUdOc1lYTnpJRUZuWlc1MFNVUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpZMVlUQTNZVGdnTHk4Z2JXVjBhRzlrSUNKaWIyOTBjM1J5WVhBb1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JpYjI5MGMzUnlZWEFLSUNBZ0lHVnljZ29LQ2k4dklHRm5aVzUwYVdRdVFXZGxiblJKUkVOdmJuUnlZV04wTG1KdmIzUnpkSEpoY0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtSnZiM1J6ZEhKaGNEb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPakV4TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwc0lHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pFeE9Rb2dJQ0FnTHk4Z2MyVnNaaTVoWkcxcGJpNTJZV3gxWlNBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltRmtiV2x1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pFeU1Bb2dJQ0FnTHk4Z2MyVnNaaTVsZFhKdlgyOXlZV05zWlM1MllXeDFaU0E5SUVGalkyOTFiblFvWlhWeWIxOXZjbUZqYkdVdVlubDBaWE1wQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWkdSeVpYTnpJR3hsYm1kMGFDQnBjeUF6TWlCaWVYUmxjd29nSUNBZ1lubDBaV01nTmlBdkx5QWlaWFZ5YjE5dmNtRmpiR1VpQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG94TWpFS0lDQWdJQzh2SUhObGJHWXVjMkZ1WkdKdmVGOWhkWFJvYjNKcGRIa3VkbUZzZFdVZ1BTQkJZMk52ZFc1MEtITmhibVJpYjNoZllYVjBhRzl5YVhSNUxtSjVkR1Z6S1FvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFRmtaSEpsYzNNZ2JHVnVaM1JvSUdseklETXlJR0o1ZEdWekNpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKellXNWtZbTk0WDJGMWRHaHZjbWwwZVNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3hNaklLSUNBZ0lDOHZJSE5sYkdZdVpHbHpjSFYwWlY5amIzVnVkR1Z5TG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0prYVhOd2RYUmxYMk52ZFc1MFpYSWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPakV5TXdvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5aFoyVnVkSE11ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2ZEdGc1gyRm5aVzUwY3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk1URXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU3dnWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmhaMlZ1ZEdsa0xrRm5aVzUwU1VSRGIyNTBjbUZqZEM1eVpXZHBjM1JsY2w5aFoyVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFoybHpkR1Z5WDJGblpXNTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TVRJNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3hNelVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnViM1FnYzJWc1ppNWhaMlZ1ZEhNdWJXRjVZbVVvVkhodUxuTmxibVJsY2lsYk1WMHNJQ0poYkhKbFlXUjVJSEpsWjJsemRHVnlaV1FpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpFMk56Vm1DaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHRnNjbVZoWkhrZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNVFEwQ2lBZ0lDQXZMeUJzWVhOMFgzVndaR0YwWlY5aWJHOWphejFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1Y205MWJtUXBMQW9nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG94TmpBS0lDQWdJQzh2SUdOeVpXRjBaV1JmWVhSZllteHZZMnM5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG5KdmRXNWtLU3dLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TVRNM0xURTJNUW9nSUNBZ0x5OGdjbVZqYjNKa0lEMGdRV2RsYm5SU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ1pHbGtQV1JwWkN3S0lDQWdJQzh2SUNBZ0lDQnpaWFIwYkdWdFpXNTBYMk52ZFc1MFBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHTnZibVpwY20xbFpGOXpaWFIwYkdWdFpXNTBjejFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOTJiMngxYldVOVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBjWFZsWDJOdmRXNTBaWEp3WVhKMGVWOWpiM1Z1ZEQxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCMGFXMWxYM2RsYVdkb2RHVmtYM1p2YkhWdFpUMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQnNZWE4wWDNWd1pHRjBaVjlpYkc5amF6MWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3VjbTkxYm1RcExBb2dJQ0FnTHk4Z0lDQWdJSE4wWVd0bFgyRnNaMjg5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZUdGc1oyOWZZbUZzWVc1alpUMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmxibVJ2Y25ObGJXVnVkRjl6WTI5eVpUMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmthWE53ZFhSbFgyTnZkVzUwUFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdScGMzQjFkR1ZmZG05c2RXMWxQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSEJsYm1ScGJtZGZaR2x6Y0hWMFpWOXpkR0ZyWlQxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCellXNWtZbTk0WDNOalpXNWhjbWx2YzE5d1lYTnpaV1E5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnYzJGdVpHSnZlRjlqWlhKMGFXWnBaV1E5WVhKak5DNUNiMjlzS0VaaGJITmxLU3dLSUNBZ0lDOHZJQ0FnSUNCbGRYSnZYMkYwZEdWemRHVmtQV0Z5WXpRdVFtOXZiQ2hHWVd4elpTa3NDaUFnSUNBdkx5QWdJQ0FnWjJWdVpYTnBjMTl6WTI5eVpUMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQm5aVzVsYzJselgyVjRjR2x5ZVY5aWJHOWphejFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JqWVdOb1pXUmZjMk52Y21VOVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2MyTnZjbVZmWTJGamFHVmtYMkYwWDJKc2IyTnJQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR2x6WDNKbFoybHpkR1Z5WldROVlYSmpOQzVDYjI5c0tGUnlkV1VwTEFvZ0lDQWdMeThnSUNBZ0lHTmhkWFJwYjI1ZlpteGhaejFoY21NMExrSnZiMndvUm1Gc2MyVXBMQW9nSUNBZ0x5OGdJQ0FnSUdOeVpXRjBaV1JmWVhSZllteHZZMnM5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG5KdmRXNWtLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3T1RRd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQTRNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNVFl5Q2lBZ0lDQXZMeUJ6Wld4bUxtRm5aVzUwYzF0VWVHNHVjMlZ1WkdWeVhTQTlJSEpsWTI5eVpDNWpiM0I1S0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk1UWTNOV1lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qRTJNd29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjloWjJWdWRITXVkbUZzZFdVZ1BTQnpaV3htTG5SdmRHRnNYMkZuWlc1MGN5NTJZV3gxWlNBcklGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5SdmRHRnNYMkZuWlc1MGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOWhaMlZ1ZEhNZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdOU0F2THlBaWRHOTBZV3hmWVdkbGJuUnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pFeU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZV2RsYm5ScFpDNUJaMlZ1ZEVsRVEyOXVkSEpoWTNRdWNtVmpiM0prWDNObGRIUnNaVzFsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV052Y21SZmMyVjBkR3hsYldWdWREb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qRTJPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1KdmIyd0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPakU0TWdvZ0lDQWdMeThnWVdkbGJuUWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG94T0RNS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtRm5aVzUwY3k1dFlYbGlaU2hoWjJWdWRDbGJNVjBzSUNKaFoyVnVkQ0J1YjNRZ2NtVm5hWE4wWlhKbFpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNVFkzTldZS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qRTRNZ29nSUNBZ0x5OGdZV2RsYm5RZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3hPRE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1GblpXNTBjeTV0WVhsaVpTaGhaMlZ1ZENsYk1WMHNJQ0poWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd2JpQXlDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk1UZzBDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1GblpXNTBjeTV0WVhsaVpTaGhaMlZ1ZENsYk1GMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNVGcyQ2lBZ0lDQXZMeUJpYkc5amEzTmZaV3hoY0hObFpDQTlJRWRzYjJKaGJDNXliM1Z1WkNBdElISmxZMjl5WkM1c1lYTjBYM1Z3WkdGMFpWOWliRzlqYXk1dVlYUnBkbVVLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ05ESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdENpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3hPVEFLSUNBZ0lDOHZJSE5sYkdZdVgyRndjR3g1WDJSbFkyRjVLSEpsWTI5eVpDNTBhVzFsWDNkbGFXZG9kR1ZrWDNadmJIVnRaUzV1WVhScGRtVXNJR0pzYjJOcmMxOWxiR0Z3YzJWa0tRb2dJQ0FnY0hWemFHbHVkQ0F6TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk9EQTRDaUFnSUNBdkx5QnBaaUIyYjJ4MWJXVWdQVDBnVlVsdWREWTBLREFwT2dvZ0lDQWdZbTU2SUhKbFkyOXlaRjl6WlhSMGJHVnRaVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pnd09Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ25KbFkyOXlaRjl6WlhSMGJHVnRaVzUwWDJGbWRHVnlYMmx1YkdsdVpXUmZZV2RsYm5ScFpDNUJaMlZ1ZEVsRVEyOXVkSEpoWTNRdVgyRndjR3g1WDJSbFkyRjVRREUxT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk1UZzRMVEU1TVFvZ0lDQWdMeThnSXlCRVpXTmhlU0JsZUdsemRHbHVaeUIwYVcxbExYZGxhV2RvZEdWa0lIWnZiSFZ0WlNCaGJtUWdZV1JrSUc1bGR5QnpaWFIwYkdWdFpXNTBDaUFnSUNBdkx5QnlaV052Y21RdWRHbHRaVjkzWldsbmFIUmxaRjkyYjJ4MWJXVWdQU0JoY21NMExsVkpiblEyTkNnS0lDQWdJQzh2SUNBZ0lDQnpaV3htTGw5aGNIQnNlVjlrWldOaGVTaHlaV052Y21RdWRHbHRaVjkzWldsbmFIUmxaRjkyYjJ4MWJXVXVibUYwYVhabExDQmliRzlqYTNOZlpXeGhjSE5sWkNrS0lDQWdJQzh2SUNrS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUF6TkFvZ0lDQWdZblZ5ZVNBekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3hPVE1LSUNBZ0lDOHZJR2xtSUhObGRIUnNaV1F1Ym1GMGFYWmxPZ29nSUNBZ1pHbG5JRFVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjZJSEpsWTI5eVpGOXpaWFIwYkdWdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNVGsxQ2lBZ0lDQXZMeUJ5WldOdmNtUXVZMjl1Wm1seWJXVmtYM05sZEhSc1pXMWxiblJ6TG01aGRHbDJaU0FySURFS0lDQWdJR1JwWnlBeUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNVGswTFRFNU5nb2dJQ0FnTHk4Z2NtVmpiM0prTG1OdmJtWnBjbTFsWkY5elpYUjBiR1Z0Wlc1MGN5QTlJR0Z5WXpRdVZVbHVkRFkwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMjl5WkM1amIyNW1hWEp0WldSZmMyVjBkR3hsYldWdWRITXVibUYwYVhabElDc2dNUW9nSUNBZ0x5OGdLUW9nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ01UQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPakU1T1FvZ0lDQWdMeThnY21WamIzSmtMblJwYldWZmQyVnBaMmgwWldSZmRtOXNkVzFsTG01aGRHbDJaU0FySUdGdGIzVnVkQzV1WVhScGRtVWdLaUF4TURBd0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNelFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTVRBS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBMElDOHZJREV3TURBS0lDQWdJQ29LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk1UazNMVEl3TUFvZ0lDQWdMeThnSXlCVFkyRnNaU0JoYlc5MWJuUWdZbmtnTVRBd01DQm1iM0lnZEdsdFpTMTNaV2xuYUhSbFpDQjJiMngxYldVZ2NISmxZMmx6YVc5dUNpQWdJQ0F2THlCeVpXTnZjbVF1ZEdsdFpWOTNaV2xuYUhSbFpGOTJiMngxYldVZ1BTQmhjbU0wTGxWSmJuUTJOQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTnZjbVF1ZEdsdFpWOTNaV2xuYUhSbFpGOTJiMngxYldVdWJtRjBhWFpsSUNzZ1lXMXZkVzUwTG01aGRHbDJaU0FxSURFd01EQUtJQ0FnSUM4dklDa0tJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdNelFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pJd01nb2dJQ0FnTHk4Z2NtVmpiM0prTG5SdmRHRnNYM1p2YkhWdFpTNXVZWFJwZG1VZ0t5QmhiVzkxYm5RdWJtRjBhWFpsQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pJd01TMHlNRE1LSUNBZ0lDOHZJSEpsWTI5eVpDNTBiM1JoYkY5MmIyeDFiV1VnUFNCaGNtTTBMbFZKYm5RMk5DZ0tJQ0FnSUM4dklDQWdJQ0J5WldOdmNtUXVkRzkwWVd4ZmRtOXNkVzFsTG01aGRHbDJaU0FySUdGdGIzVnVkQzV1WVhScGRtVUtJQ0FnSUM4dklDa0tJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURFNENpQWdJQ0JpZFhKNUlETUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPakl3TlMweU1EWUtJQ0FnSUM4dklDTWdWSEpoWTJzZ2RXNXBjWFZsSUdOdmRXNTBaWEp3WVhKMGFXVnpDaUFnSUNBdkx5QmpjRjlyWlhrZ1BTQnpaV3htTGw5amIzVnVkR1Z5Y0dGeWRIbGZhMlY1S0dGblpXNTBMQ0JCWTJOdmRXNTBLR052ZFc1MFpYSndZWEowZVM1aWVYUmxjeWtwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHUnBaeUEzQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFRmtaSEpsYzNNZ2JHVnVaM1JvSUdseklETXlJR0o1ZEdWekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzRORElLSUNBZ0lDOHZJSEpsZEhWeWJpQmhaMlZ1ZEM1aWVYUmxjeUFySUdOdmRXNTBaWEp3WVhKMGVTNWllWFJsY3dvZ0lDQWdaR2xuSURRS0lDQWdJR1JwWnlBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TWpBM0NpQWdJQ0F2THlCZlkzWmhiQ3dnYzJWbGJpQTlJSE5sYkdZdVkyOTFiblJsY25CaGNuUnBaWE11YldGNVltVW9ZM0JmYTJWNUtRb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRveU1EZ0tJQ0FnSUM4dklHbG1JRzV2ZENCelpXVnVPZ29nSUNBZ1ltNTZJSEpsWTI5eVpGOXpaWFIwYkdWdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNakE1Q2lBZ0lDQXZMeUJ6Wld4bUxtTnZkVzUwWlhKd1lYSjBhV1Z6VzJOd1gydGxlVjBnUFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTVRFS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPakl4TVFvZ0lDQWdMeThnY21WamIzSmtMblZ1YVhGMVpWOWpiM1Z1ZEdWeWNHRnlkSGxmWTI5MWJuUXVibUYwYVhabElDc2dNUW9nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeU5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRveU1UQXRNakV5Q2lBZ0lDQXZMeUJ5WldOdmNtUXVkVzVwY1hWbFgyTnZkVzUwWlhKd1lYSjBlVjlqYjNWdWRDQTlJR0Z5WXpRdVZVbHVkRFkwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMjl5WkM1MWJtbHhkV1ZmWTI5MWJuUmxjbkJoY25SNVgyTnZkVzUwTG01aGRHbDJaU0FySURFS0lDQWdJQzh2SUNrS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJREkyQ2lBZ0lDQmlkWEo1SURNS0NuSmxZMjl5WkY5elpYUjBiR1Z0Wlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qSXhOQW9nSUNBZ0x5OGdjbVZqYjNKa0xuTmxkSFJzWlcxbGJuUmZZMjkxYm5RZ1BTQmhjbU0wTGxWSmJuUTJOQ2h5WldOdmNtUXVjMlYwZEd4bGJXVnVkRjlqYjNWdWRDNXVZWFJwZG1VZ0t5QXhLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlESUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPakl4TlFvZ0lDQWdMeThnY21WamIzSmtMbXhoYzNSZmRYQmtZWFJsWDJKc2IyTnJJRDBnWVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG5KdmRXNWtLUW9nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBME1nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNakUzTFRJeE9Bb2dJQ0FnTHk4Z0l5QkpiblpoYkdsa1lYUmxJR05oWTJobFpDQnpZMjl5WlFvZ0lDQWdMeThnY21WamIzSmtMbk5qYjNKbFgyTmhZMmhsWkY5aGRGOWliRzlqYXlBOUlHRnlZelF1VlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2NtVndiR0ZqWlRJZ01UTXhDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG95TWpBS0lDQWdJQzh2SUhObGJHWXVZV2RsYm5SelcyRm5aVzUwWFNBOUlISmxZMjl5WkM1amIzQjVLQ2tLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNVFk1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbkpsWTI5eVpGOXpaWFIwYkdWdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU1UQTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG80TVRBS0lDQWdJQzh2SUdSaGVYTWdQU0JpYkc5amEzTmZaV3hoY0hObFpDQXZMeUJWU1c1ME5qUW9Ra3hQUTB0VFgxQkZVbDlUUTA5U1NVNUhYMFJCV1NrS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJREUwTkRBS0lDQWdJQzhLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk9ERXhDaUFnSUNBdkx5QnBaaUJrWVhseklEMDlJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHSnVlaUJ5WldOdmNtUmZjMlYwZEd4bGJXVnVkRjloWm5SbGNsOXBabDlsYkhObFFERXlDaUFnSUNCa2RYQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPakU1TUFvZ0lDQWdMeThnYzJWc1ppNWZZWEJ3YkhsZlpHVmpZWGtvY21WamIzSmtMblJwYldWZmQyVnBaMmgwWldSZmRtOXNkVzFsTG01aGRHbDJaU3dnWW14dlkydHpYMlZzWVhCelpXUXBDaUFnSUNCaUlISmxZMjl5WkY5elpYUjBiR1Z0Wlc1MFgyRm1kR1Z5WDJsdWJHbHVaV1JmWVdkbGJuUnBaQzVCWjJWdWRFbEVRMjl1ZEhKaFkzUXVYMkZ3Y0d4NVgyUmxZMkY1UURFMUNncHlaV052Y21SZmMyVjBkR3hsYldWdWRGOWhablJsY2w5cFpsOWxiSE5sUURFeU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZPREV6Q2lBZ0lDQXZMeUJwWmlCa1lYbHpJRDQ5SUZWSmJuUTJOQ2c1T1NrNkNpQWdJQ0JrYVdjZ09Rb2dJQ0FnY0hWemFHbHVkQ0E1T1FvZ0lDQWdQajBLSUNBZ0lHSjZJSEpsWTI5eVpGOXpaWFIwYkdWdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU1UUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPamd4TkMwNE1UVUtJQ0FnSUM4dklDTWdUbVZoY2kxNlpYSnZJR0ZtZEdWeUlEazVJSE5qYjNKcGJtY3RaR0Y1Y3dvZ0lDQWdMeThnY21WMGRYSnVJSFp2YkhWdFpTQXZMeUJWU1c1ME5qUW9NVEF3S1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEF3Q2lBZ0lDQXZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG94T1RBS0lDQWdJQzh2SUhObGJHWXVYMkZ3Y0d4NVgyUmxZMkY1S0hKbFkyOXlaQzUwYVcxbFgzZGxhV2RvZEdWa1gzWnZiSFZ0WlM1dVlYUnBkbVVzSUdKc2IyTnJjMTlsYkdGd2MyVmtLUW9nSUNBZ1lpQnlaV052Y21SZmMyVjBkR3hsYldWdWRGOWhablJsY2w5cGJteHBibVZrWDJGblpXNTBhV1F1UVdkbGJuUkpSRU52Ym5SeVlXTjBMbDloY0hCc2VWOWtaV05oZVVBeE5Rb0tjbVZqYjNKa1gzTmxkSFJzWlcxbGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBeE5Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPamd4TmdvZ0lDQWdMeThnY21WMFpXNTBhVzl1SUQwZ1ZVbHVkRFkwS0RFd01Da2dMU0JrWVhsekNpQWdJQ0JwYm5Salh6TWdMeThnTVRBd0NpQWdJQ0JrYVdjZ01UQUtJQ0FnSUMwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qZ3hOd29nSUNBZ0x5OGdjbVYwZFhKdUlDaDJiMngxYldVZ0tpQnlaWFJsYm5ScGIyNHBJQzh2SUZWSmJuUTJOQ2d4TURBcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eklDOHZJREV3TUFvZ0lDQWdMd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TVRrd0NpQWdJQ0F2THlCelpXeG1MbDloY0hCc2VWOWtaV05oZVNoeVpXTnZjbVF1ZEdsdFpWOTNaV2xuYUhSbFpGOTJiMngxYldVdWJtRjBhWFpsTENCaWJHOWphM05mWld4aGNITmxaQ2tLSUNBZ0lHSWdjbVZqYjNKa1gzTmxkSFJzWlcxbGJuUmZZV1owWlhKZmFXNXNhVzVsWkY5aFoyVnVkR2xrTGtGblpXNTBTVVJEYjI1MGNtRmpkQzVmWVhCd2JIbGZaR1ZqWVhsQU1UVUtDZ292THlCaFoyVnVkR2xrTGtGblpXNTBTVVJEYjI1MGNtRmpkQzV5WldGa1gzTmpiM0psVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVmhaRjl6WTI5eVpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPakl5TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk1qTXpDaUFnSUNBdkx5QmhaMlZ1ZEY5aFkyTnZkVzUwSUQwZ1FXTmpiM1Z1ZENoaFoyVnVkQzVpZVhSbGN5a0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWkdSeVpYTnpJR3hsYm1kMGFDQnBjeUF6TWlCaWVYUmxjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TWpNMENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWhaMlZ1ZEhNdWJXRjVZbVVvWVdkbGJuUmZZV05qYjNWdWRDbGJNVjBzSUNKaFoyVnVkQ0J1YjNRZ2NtVm5hWE4wWlhKbFpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNVFkzTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd2JpQXlDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk1qTTFDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1GblpXNTBjeTV0WVhsaVpTaGhaMlZ1ZEY5aFkyTnZkVzUwS1Zzd1hTNWpiM0I1S0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3lNellLSUNBZ0lDOHZJR04xY25KbGJuUmZZbXh2WTJzZ1BTQkhiRzlpWVd3dWNtOTFibVFLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qSXpOd29nSUNBZ0x5OGdZMkZqYUdWZllXZGxJRDBnWTNWeWNtVnVkRjlpYkc5amF5QXRJSEpsWTI5eVpDNXpZMjl5WlY5allXTm9aV1JmWVhSZllteHZZMnN1Ym1GMGFYWmxDaUFnSUNCd2RYTm9hVzUwSURFek1Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0xRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNak01Q2lBZ0lDQXZMeUJwWmlCallXTm9aVjloWjJVZ1BEMGdWVWx1ZERZMEtGTlVRVXhGVGtWVFUxOVhTVTVFVDFkZlFreFBRMHRUS1NCaGJtUWdjbVZqYjNKa0xuTmpiM0psWDJOaFkyaGxaRjloZEY5aWJHOWpheTV1WVhScGRtVWdQaUF3T2dvZ0lDQWdhVzUwWTE4eklDOHZJREV3TUFvZ0lDQWdQRDBLSUNBZ0lHSjZJSEpsWVdSZmMyTnZjbVZmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNCa2RYQUtJQ0FnSUdKNklISmxZV1JmYzJOdmNtVmZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3lOREFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTGw5aWRXbHNaRjl6WTI5eVpWOXlaWE4xYkhRb2NtVmpiM0prTENCcGMxOWpZV05vWldROVZISjFaU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1kyRnNiSE4xWWlCZlluVnBiR1JmYzJOdmNtVmZjbVZ6ZFd4MENpQWdJQ0J3YjNBS0NuSmxZV1JmYzJOdmNtVmZZV1owWlhKZmFXNXNhVzVsWkY5aFoyVnVkR2xrTGtGblpXNTBTVVJEYjI1MGNtRmpkQzV5WldGa1gzTmpiM0psUURVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3lNallLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2NtVmhaRjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3lORFlLSUNBZ0lDOHZJQ2tnUFNCelpXeG1MbDlqYjIxd2RYUmxYM05qYjNKbEtISmxZMjl5WkN3Z1kzVnljbVZ1ZEY5aWJHOWpheWtLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRjlqYjIxd2RYUmxYM05qYjNKbENpQWdJQ0JqYjNabGNpQTJDaUFnSUNCd2IzQnVJRFVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pJME9DMHlOVEFLSUNBZ0lDOHZJQ01nVjNKcGRHVWdabkpsYzJnZ1kyRmphR1VnS0c5dWJIa2djRzl6YzJsaWJHVWdhV1lnVGs5VUlISmxZV1J2Ym14NUlPS0FsQ0IwYUdseklHSnlZVzVqYUNCcGN5QjFibkpsWVdOb1lXSnNaUW9nSUNBZ0x5OGdJeUJwYmlCeVpXRmtiMjVzZVNCallXeHNjeXdnWW5WMElHTnZiWEJwYkdWeklHWnBibVU3SUdOaGJHeGxjbk1nZFhObElHNXZiaTF5WldGa2IyNXNlU0IwYnlCeVpXWnlaWE5vS1FvZ0lDQWdMeThnY21WamIzSmtMbU5oWTJobFpGOXpZMjl5WlNBOUlHRnlZelF1VlVsdWREWTBLR1pwYm1Gc1gzTmpiM0psS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV5SURFeU13b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNalV4Q2lBZ0lDQXZMeUJ5WldOdmNtUXVjMk52Y21WZlkyRmphR1ZrWDJGMFgySnNiMk5ySUQwZ1lYSmpOQzVWU1c1ME5qUW9ZM1Z5Y21WdWRGOWliRzlqYXlrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ01UTXhDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG95TlRJS0lDQWdJQzh2SUhKbFkyOXlaQzVqWVhWMGFXOXVYMlpzWVdjZ1BTQmhjbU0wTGtKdmIyd29abWx1WVd4ZmMyTnZjbVVnUENCVlNXNTBOalFvUTBGVlZFbFBUbDlUUTA5U1JWOVVTRkpGVTBoUFRFUXBLUW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBeU1Bb2dJQ0FnUEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHbHVkR01nTlNBdkx5QXhNVEV6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qSTFOQW9nSUNBZ0x5OGdjMlZzWmk1aFoyVnVkSE5iWVdkbGJuUmZZV05qYjNWdWRGMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRveU5UWUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbDlpZFdsc1pGOXpZMjl5WlY5eVpYTjFiSFFvY21WamIzSmtMQ0JwYzE5allXTm9aV1E5Um1Gc2MyVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWTJGc2JITjFZaUJmWW5WcGJHUmZjMk52Y21WZmNtVnpkV3gwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pJeU5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaUlISmxZV1JmYzJOdmNtVmZZV1owWlhKZmFXNXNhVzVsWkY5aFoyVnVkR2xrTGtGblpXNTBTVVJEYjI1MGNtRmpkQzV5WldGa1gzTmpiM0psUURVS0Nnb3ZMeUJoWjJWdWRHbGtMa0ZuWlc1MFNVUkRiMjUwY21GamRDNXlaV1p5WlhOb1gzTmpiM0psVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVm1jbVZ6YUY5elkyOXlaVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pJMU9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TWpZMUNpQWdJQ0F2THlCaFoyVnVkRjloWTJOdmRXNTBJRDBnUVdOamIzVnVkQ2hoWjJWdWRDNWllWFJsY3lrS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaR1J5WlhOeklHeGxibWQwYUNCcGN5QXpNaUJpZVhSbGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNalkyQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aFoyVnVkSE11YldGNVltVW9ZV2RsYm5SZllXTmpiM1Z1ZENsYk1WMHNJQ0poWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkNJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk1UWTNOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCaFoyVnVkQ0J1YjNRZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNalkzQ2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxtRm5aVzUwY3k1dFlYbGlaU2hoWjJWdWRGOWhZMk52ZFc1MEtWc3dYUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG95TmpnS0lDQWdJQzh2SUdOMWNuSmxiblJmWW14dlkyc2dQU0JIYkc5aVlXd3VjbTkxYm1RS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk1qY3pDaUFnSUNBdkx5QXBJRDBnYzJWc1ppNWZZMjl0Y0hWMFpWOXpZMjl5WlNoeVpXTnZjbVFzSUdOMWNuSmxiblJmWW14dlkyc3BDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyRnNiSE4xWWlCZlkyOXRjSFYwWlY5elkyOXlaUW9nSUNBZ1kyOTJaWElnTmdvZ0lDQWdjRzl3YmlBMUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3lOelVLSUNBZ0lDOHZJSEpsWTI5eVpDNWpZV05vWldSZmMyTnZjbVVnUFNCaGNtTTBMbFZKYm5RMk5DaG1hVzVoYkY5elkyOXlaU2tLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUF4TWpNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qSTNOZ29nSUNBZ0x5OGdjbVZqYjNKa0xuTmpiM0psWDJOaFkyaGxaRjloZEY5aWJHOWpheUE5SUdGeVl6UXVWVWx1ZERZMEtHTjFjbkpsYm5SZllteHZZMnNwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURFek1Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNamMzQ2lBZ0lDQXZMeUJ5WldOdmNtUXVZMkYxZEdsdmJsOW1iR0ZuSUQwZ1lYSmpOQzVDYjI5c0tHWnBibUZzWDNOamIzSmxJRHdnVlVsdWREWTBLRU5CVlZSSlQwNWZVME5QVWtWZlZFaFNSVk5JVDB4RUtTa0tJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTWpBS0lDQWdJRHdLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCcGJuUmpJRFVnTHk4Z01URXhNd29nSUNBZ2MzZGhjQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRveU56a0tJQ0FnSUM4dklITmxiR1l1WVdkbGJuUnpXMkZuWlc1MFgyRmpZMjkxYm5SZElEMGdjbVZqYjNKa0xtTnZjSGtvS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pJNE1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVYMkoxYVd4a1gzTmpiM0psWDNKbGMzVnNkQ2h5WldOdmNtUXNJR2x6WDJOaFkyaGxaRDFHWVd4elpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JqWVd4c2MzVmlJRjlpZFdsc1pGOXpZMjl5WlY5eVpYTjFiSFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TWpVNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmhaMlZ1ZEdsa0xrRm5aVzUwU1VSRGIyNTBjbUZqZEM1emRHRnJaVjl2Ymw5aFoyVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25OMFlXdGxYMjl1WDJGblpXNTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TWprMUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWhaMlZ1ZEhNdWJXRjVZbVVvWVdkbGJuUXBXekZkTENBaVlXZGxiblFnYm05MElISmxaMmx6ZEdWeVpXUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROakUyTnpWbUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3lPVFFLSUNBZ0lDOHZJR0ZuWlc1MElEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNamsxQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aFoyVnVkSE11YldGNVltVW9ZV2RsYm5RcFd6RmRMQ0FpWVdkbGJuUWdibTkwSUhKbFoybHpkR1Z5WldRaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV2RsYm5RZ2JtOTBJSEpsWjJsemRHVnlaV1FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pJNU5nb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTVoWjJWdWRITXViV0Y1WW1Vb1lXZGxiblFwV3pCZExtTnZjSGtvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qSTVPQzB5T1RrS0lDQWdJQzh2SUNNZ1JHVjBaWEp0YVc1bElITjBZV3RsWkNCaGJXOTFiblFnWm5KdmJTQjBhR1VnY0dGNWJXVnVkQ0JwYmlCMGFHVWdaM0p2ZFhBS0lDQWdJQzh2SUhCaGVXMWxiblJmWVcxdmRXNTBJRDBnYjNBdVIxUjRiaTVoYlc5MWJuUW9WSGh1TG1keWIzVndYMmx1WkdWNElDMGdNU2tLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3pNREFLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MFgyRnRiM1Z1ZENBK1BTQlZTVzUwTmpRb01WOHdNREJmTURBd0tTd2dJbTFwYm1sdGRXMGdjM1JoYTJVZ2FYTWdNU0JCVEVkUElnb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREV3TURBd01EQUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnYldsdWFXMTFiU0J6ZEdGclpTQnBjeUF4SUVGTVIwOEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPak13TlMwek1UQUtJQ0FnSUM4dklDTWdSR1Z3YjNOcGRDQnBiblJ2SUVadmJHdHpJRVpwYm1GdVkyVWdlRUZNUjA4Z2NHOXZiQ0IyYVdFZ2FXNXVaWElnZEhKaGJuTmhZM1JwYjI0S0lDQWdJQzh2SUhKbGMzVnNkQ0E5SUdsMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c0tBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5cFpEMUJjSEJzYVdOaGRHbHZiaWg0WVd4bmIxOWhjSEFwTEFvZ0lDQWdMeThnSUNBZ0lHRndjRjloY21kelBTaGlJbVJsY0c5emFYUkJiR2R2SWl3cExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTWpBd01Da3NDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3pNRGdLSUNBZ0lDOHZJR0Z3Y0Y5aGNtZHpQU2hpSW1SbGNHOXphWFJCYkdkdklpd3BMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROalEyTlRjd05tWTNNelk1TnpRME1UWmpOamMyWmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPak13TWdvZ0lDQWdMeThnZUdGc1oyOWZZWEJ3SUQwZ1ZVbHVkRFkwS0ZoQlRFZFBYMEZRVUY5SlJGOVVSVk5VVGtWVUtRb2dJQ0FnY0hWemFHbHVkQ0EzTXpBME16QTJOek1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk16QTFMVE13TmdvZ0lDQWdMeThnSXlCRVpYQnZjMmwwSUdsdWRHOGdSbTlzYTNNZ1JtbHVZVzVqWlNCNFFVeEhUeUJ3YjI5c0lIWnBZU0JwYm01bGNpQjBjbUZ1YzJGamRHbHZiZ29nSUNBZ0x5OGdjbVZ6ZFd4MElEMGdhWFI0Ymk1QmNIQnNhV05oZEdsdmJrTmhiR3dvQ2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk16QTVDaUFnSUNBdkx5Qm1aV1U5VlVsdWREWTBLREl3TURBcExBb2dJQ0FnY0hWemFHbHVkQ0F5TURBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNekExTFRNeE1Bb2dJQ0FnTHk4Z0l5QkVaWEJ2YzJsMElHbHVkRzhnUm05c2EzTWdSbWx1WVc1alpTQjRRVXhIVHlCd2IyOXNJSFpwWVNCcGJtNWxjaUIwY21GdWMyRmpkR2x2YmdvZ0lDQWdMeThnY21WemRXeDBJRDBnYVhSNGJpNUJjSEJzYVdOaGRHbHZia05oYkd3b0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJsa1BVRndjR3hwWTJGMGFXOXVLSGhoYkdkdlgyRndjQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMkZ5WjNNOUtHSWlaR1Z3YjNOcGRFRnNaMjhpTENrc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d5TURBd0tTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3pNVEV0TXpFekNpQWdJQ0F2THlBaklIaEJURWRQSUhKbFkyVnBkbVZrSUQwZ2NHRjViV1Z1ZEY5aGJXOTFiblFnS0RFNk1TQmhjSEJ5YjNocGJXRjBaU0JoZENCc1lYVnVZMmdwQ2lBZ0lDQXZMeUFqSUVsdUlIQnlZV04wYVdObExDQjBhR1VnWlhoamFHRnVaMlVnY21GMFpTQnBjeUErSURFZ1FVeEhUeUJ3WlhJZ2VFRk1SMDhLSUNBZ0lDOHZJSEpsWTI5eVpDNTRZV3huYjE5aVlXeGhibU5sSUQwZ1lYSmpOQzVWU1c1ME5qUW9jbVZqYjNKa0xuaGhiR2R2WDJKaGJHRnVZMlV1Ym1GMGFYWmxJQ3NnY0dGNWJXVnVkRjloYlc5MWJuUXBDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBMU9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEVTRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG96TVRnS0lDQWdJQzh2SUhKbFkyOXlaQzV6ZEdGclpWOWhiR2R2SUQwZ1lYSmpOQzVWU1c1ME5qUW9jbVZqYjNKa0xuTjBZV3RsWDJGc1oyOHVibUYwYVhabElDc2djR0Y1YldWdWRGOWhiVzkxYm5RcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOVEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJRFV3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvek1Ua0tJQ0FnSUM4dklISmxZMjl5WkM1elkyOXlaVjlqWVdOb1pXUmZZWFJmWW14dlkyc2dQU0JoY21NMExsVkpiblEyTkNnd0tTQWdJeUJwYm5aaGJHbGtZWFJsSUdOaFkyaGxDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnY21Wd2JHRmpaVElnTVRNeENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3pNakFLSUNBZ0lDOHZJSE5sYkdZdVlXZGxiblJ6VzJGblpXNTBYU0E5SUhKbFkyOXlaQzVqYjNCNUtDa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qSTROZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWVdkbGJuUnBaQzVCWjJWdWRFbEVRMjl1ZEhKaFkzUXVjMnhoYzJoZmMzUmhhMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwemJHRnphRjl6ZEdGclpUb0tJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNekl5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNek15Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbUZrYldsdUxuWmhiSFZsTENBaVlXUnRhVzRnYjI1c2VTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV1J0YVc0Z2IyNXNlUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TXpNMENpQWdJQ0F2THlCaFoyVnVkRjloWTJOdmRXNTBJRDBnUVdOamIzVnVkQ2hoWjJWdWRDNWllWFJsY3lrS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGa1pISmxjM01nYkdWdVozUm9JR2x6SURNeUlHSjVkR1Z6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvek16VUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUZuWlc1MGN5NXRZWGxpWlNoaFoyVnVkRjloWTJOdmRXNTBLVnN4WFN3Z0ltRm5aVzUwSUc1dmRDQnlaV2RwYzNSbGNtVmtJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFl4TmpjMVpnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TXpNMkNpQWdJQ0F2THlCeVpXTnZjbVFnUFNCelpXeG1MbUZuWlc1MGN5NXRZWGxpWlNoaFoyVnVkRjloWTJOdmRXNTBLVnN3WFM1amIzQjVLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPak16TndvZ0lDQWdMeThnWVdOMGRXRnNYM05zWVhOb0lEMGdjMnhoYzJoZllXMXZkVzUwTG01aGRHbDJaUW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qTXpPQW9nSUNBZ0x5OGdhV1lnWVdOMGRXRnNYM05zWVhOb0lENGdjbVZqYjNKa0xuTjBZV3RsWDJGc1oyOHVibUYwYVhabE9nb2dJQ0FnY0hWemFHbHVkQ0ExTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnUGdvZ0lDQWdZbm9nYzJ4aGMyaGZjM1JoYTJWZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWdvS2MyeGhjMmhmYzNSaGEyVmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNelF4Q2lBZ0lDQXZMeUJ5WldOdmNtUXVjM1JoYTJWZllXeG5ieUE5SUdGeVl6UXVWVWx1ZERZMEtISmxZMjl5WkM1emRHRnJaVjloYkdkdkxtNWhkR2wyWlNBdElHRmpkSFZoYkY5emJHRnphQ2tLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMUW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEVXdDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TXpReUNpQWdJQ0F2THlCcFppQnlaV052Y21RdWVHRnNaMjlmWW1Gc1lXNWpaUzV1WVhScGRtVWdQajBnWVdOMGRXRnNYM05zWVhOb09nb2dJQ0FnY0hWemFHbHVkQ0ExT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0E4UFFvZ0lDQWdZbm9nYzJ4aGMyaGZjM1JoYTJWZlpXeHpaVjlpYjJSNVFEVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPak0wTXdvZ0lDQWdMeThnY21WamIzSmtMbmhoYkdkdlgySmhiR0Z1WTJVZ1BTQmhjbU0wTGxWSmJuUTJOQ2h5WldOdmNtUXVlR0ZzWjI5ZlltRnNZVzVqWlM1dVlYUnBkbVVnTFNCaFkzUjFZV3hmYzJ4aGMyZ3BDaUFnSUNCa2FXY2dOQW9nSUNBZ1pHbG5JRElLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBMU9Bb2dJQ0FnWW5WeWVTQXpDZ3B6YkdGemFGOXpkR0ZyWlY5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvek5EY0tJQ0FnSUM4dklISmxZMjl5WkM1elkyOXlaVjlqWVdOb1pXUmZZWFJmWW14dlkyc2dQU0JoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnWkdsbklESUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J5WlhCc1lXTmxNaUF4TXpFS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qTTBPQW9nSUNBZ0x5OGdjMlZzWmk1aFoyVnVkSE5iWVdkbGJuUmZZV05qYjNWdWRGMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pNeU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwemJHRnphRjl6ZEdGclpWOWxiSE5sWDJKdlpIbEFOVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pNME5Rb2dJQ0FnTHk4Z2NtVmpiM0prTG5oaGJHZHZYMkpoYkdGdVkyVWdQU0JoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnWkdsbklESUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J5WlhCc1lXTmxNaUExT0FvZ0lDQWdZblZ5ZVNBekNpQWdJQ0JpSUhOc1lYTm9YM04wWVd0bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvS0NpOHZJR0ZuWlc1MGFXUXVRV2RsYm5SSlJFTnZiblJ5WVdOMExuVnVjM1JoYTJWZlpuSnZiVjloWjJWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ1YzNSaGEyVmZabkp2YlY5aFoyVnVkRG9LSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1pIVndDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG96TlRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pNMU13b2dJQ0FnTHk4Z1lXZGxiblFnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvek5UUUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUZuWlc1MGN5NXRZWGxpWlNoaFoyVnVkQ2xiTVYwc0lDSmhaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTVRZM05XWUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPak0xTXdvZ0lDQWdMeThnWVdkbGJuUWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG96TlRRS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtRm5aVzUwY3k1dFlYbGlaU2hoWjJWdWRDbGJNVjBzSUNKaFoyVnVkQ0J1YjNRZ2NtVm5hWE4wWlhKbFpDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCaFoyVnVkQ0J1YjNRZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNelUxQ2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxtRm5aVzUwY3k1dFlYbGlaU2hoWjJWdWRDbGJNRjB1WTI5d2VTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TXpVMkNpQWdJQ0F2THlCaGRtRnBiR0ZpYkdVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3pOVGNLSUNBZ0lDOHZJR2xtSUhKbFkyOXlaQzV6ZEdGclpWOWhiR2R2TG01aGRHbDJaU0ErSUhKbFkyOXlaQzV3Wlc1a2FXNW5YMlJwYzNCMWRHVmZjM1JoYTJVdWJtRjBhWFpsT2dvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEVXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEIxYzJocGJuUWdPVEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJRDRLSUNBZ0lHSjZJSFZ1YzNSaGEyVmZabkp2YlY5aFoyVnVkRjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPak0xT0FvZ0lDQWdMeThnWVhaaGFXeGhZbXhsSUQwZ2NtVmpiM0prTG5OMFlXdGxYMkZzWjI4dWJtRjBhWFpsSUMwZ2NtVmpiM0prTG5CbGJtUnBibWRmWkdsemNIVjBaVjl6ZEdGclpTNXVZWFJwZG1VS0lDQWdJR1IxY0RJS0lDQWdJQzBLSUNBZ0lHSjFjbmtnTXdvS2RXNXpkR0ZyWlY5bWNtOXRYMkZuWlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qTTJNQW9nSUNBZ0x5OGdZWE56WlhKMElHRnRiM1Z1ZEM1dVlYUnBkbVVnUEQwZ1lYWmhhV3hoWW14bExDQWlhVzV6ZFdabWFXTnBaVzUwSUhkcGRHaGtjbUYzWVdKc1pTQnpkR0ZyWlNJS0lDQWdJR1JwWnlBMkNpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ09Rb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5OMVptWnBZMmxsYm5RZ2QybDBhR1J5WVhkaFlteGxJSE4wWVd0bENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3pOaklLSUNBZ0lDOHZJSEpsWTI5eVpDNXpkR0ZyWlY5aGJHZHZJRDBnWVhKak5DNVZTVzUwTmpRb2NtVmpiM0prTG5OMFlXdGxYMkZzWjI4dWJtRjBhWFpsSUMwZ1lXMXZkVzUwTG01aGRHbDJaU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdMUW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRFVLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEVXdDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TXpZekNpQWdJQ0F2THlCcFppQnlaV052Y21RdWVHRnNaMjlmWW1Gc1lXNWpaUzV1WVhScGRtVWdQajBnWVcxdmRXNTBMbTVoZEdsMlpUb0tJQ0FnSUhCMWMyaHBiblFnTlRnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01URUtJQ0FnSUR3OUNpQWdJQ0JpZWlCMWJuTjBZV3RsWDJaeWIyMWZZV2RsYm5SZlpXeHpaVjlpYjJSNVFEVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPak0yTkFvZ0lDQWdMeThnY21WamIzSmtMbmhoYkdkdlgySmhiR0Z1WTJVZ1BTQmhjbU0wTGxWSmJuUTJOQ2h5WldOdmNtUXVlR0ZzWjI5ZlltRnNZVzVqWlM1dVlYUnBkbVVnTFNCaGJXOTFiblF1Ym1GMGFYWmxLUW9nSUNBZ1pHbG5JRGdLSUNBZ0lHUnBaeUE0Q2lBZ0lDQXRDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dOQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ05UZ0tJQ0FnSUdKMWNua2dOQW9LZFc1emRHRnJaVjltY205dFgyRm5aVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pNMk9DMHpOek1LSUNBZ0lDOHZJQ01nVW1WMGRYSnVJRUZNUjA4Z2RHOGdZV2RsYm5RZ2RtbGhJR2x1Ym1WeUlIQmhlVzFsYm5RS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFoWjJWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlZVzF2ZFc1MExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5VlVsdWREWTBLREV3TURBcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaR2xuSURjS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCa2FXY2dOUW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNelk0TFRNMk9Rb2dJQ0FnTHk4Z0l5QlNaWFIxY200Z1FVeEhUeUIwYnlCaFoyVnVkQ0IyYVdFZ2FXNXVaWElnY0dGNWJXVnVkQW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TXpjeUNpQWdJQ0F2THlCbVpXVTlWVWx1ZERZMEtERXdNREFwTEFvZ0lDQWdhVzUwWXlBMElDOHZJREV3TURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3pOamd0TXpjekNpQWdJQ0F2THlBaklGSmxkSFZ5YmlCQlRFZFBJSFJ2SUdGblpXNTBJSFpwWVNCcGJtNWxjaUJ3WVhsdFpXNTBDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOVlXZGxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGdGIzVnVkQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNneE1EQXdLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG96TnpVS0lDQWdJQzh2SUhKbFkyOXlaQzV6WTI5eVpWOWpZV05vWldSZllYUmZZbXh2WTJzZ1BTQmhjbU0wTGxWSmJuUTJOQ2d3S1FvZ0lDQWdaR2xuSURNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnlaWEJzWVdObE1pQXhNekVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pNM05nb2dJQ0FnTHk4Z2MyVnNaaTVoWjJWdWRITmJZV2RsYm5SZElEMGdjbVZqYjNKa0xtTnZjSGtvS1FvZ0lDQWdaR2xuSURVS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG96TlRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LZFc1emRHRnJaVjltY205dFgyRm5aVzUwWDJWc2MyVmZZbTlrZVVBMU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZNelkyQ2lBZ0lDQXZMeUJ5WldOdmNtUXVlR0ZzWjI5ZlltRnNZVzVqWlNBOUlHRnlZelF1VlVsdWREWTBLREFwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lISmxjR3hoWTJVeUlEVTRDaUFnSUNCaWRYSjVJRFFLSUNBZ0lHSWdkVzV6ZEdGclpWOW1jbTl0WDJGblpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU5nb0tDaTh2SUdGblpXNTBhV1F1UVdkbGJuUkpSRU52Ym5SeVlXTjBMbVpwYkdWZlpHbHpjSFYwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtWnBiR1ZmWkdsemNIVjBaVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pNNE1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pNNU5Rb2dJQ0FnTHk4Z1pHbHpjSFYwWlhJZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUb3pPVFlLSUNBZ0lDOHZJR1JwYzNCMWRHVmtJRDBnUVdOamIzVnVkQ2hrYVhOd2RYUmxaRjloWjJWdWRDNWllWFJsY3lrS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGa1pISmxjM01nYkdWdVozUm9JR2x6SURNeUlHSjVkR1Z6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvek9UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUZuWlc1MGN5NXRZWGxpWlNoa2FYTndkWFJsWkNsYk1WMHNJQ0prYVhOd2RYUmxaQ0JoWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkNJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk1UWTNOV1lLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1pHbHpjSFYwWldRZ1lXZGxiblFnYm05MElISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPak01T1FvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNWhaMlZ1ZEhNdWJXRjVZbVVvWkdsemNIVjBaV1FwV3pCZExtTnZjSGtvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPalF3TVMwME1ESUtJQ0FnSUM4dklDTWdWbVZ5YVdaNUlGSjFiR1VnUVNCemRHRnJaU0FvY0hKbFkyVmthVzVuSUZCaGVXMWxiblFnZEhnZ2FXNGdkR2hsSUdkeWIzVndLUW9nSUNBZ0x5OGdjM1JoYTJWZmNHRjViV1Z1ZENBOUlHOXdMa2RVZUc0dVlXMXZkVzUwS0ZSNGJpNW5jbTkxY0Y5cGJtUmxlQ0F0SURFcENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TkRBekNpQWdJQ0F2THlCeVpYRjFhWEpsWkY5emRHRnJaU0E5SUhSNFgyRnRiM1Z1ZEM1dVlYUnBkbVVnS2lCVlNXNTBOalFvUkVsVFVGVlVSVjlUVkVGTFJWOU5WVXhVU1ZCTVNVVlNLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FxQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvME1EUUtJQ0FnSUM4dklHRnpjMlZ5ZENCemRHRnJaVjl3WVhsdFpXNTBJRDQ5SUhKbGNYVnBjbVZrWDNOMFlXdGxMQ0FpYVc1emRXWm1hV05wWlc1MElHUnBjM0IxZEdVZ2MzUmhhMlVpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBibk4xWm1acFkybGxiblFnWkdsemNIVjBaU0J6ZEdGclpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOREEyQ2lBZ0lDQXZMeUJrYVhOd2RYUmxYMmxrSUQwZ2MyVnNaaTVrYVhOd2RYUmxYMk52ZFc1MFpYSXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0prYVhOd2RYUmxYMk52ZFc1MFpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WkdsemNIVjBaVjlqYjNWdWRHVnlJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOREEzQ2lBZ0lDQXZMeUJ6Wld4bUxtUnBjM0IxZEdWZlkyOTFiblJsY2k1MllXeDFaU0E5SUdScGMzQjFkR1ZmYVdRZ0t5QlZTVzUwTmpRb01Ta0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbVJwYzNCMWRHVmZZMjkxYm5SbGNpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8wTURrS0lDQWdJQzh2SUdScGMzQjFkR1ZmYTJWNUlEMGdiM0F1YVhSdllpaGthWE53ZFhSbFgybGtLUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TkRFMUNpQWdJQ0F2THlCemRHRnJaVjlzYjJOclpXUTlZWEpqTkM1VlNXNTBOalFvYzNSaGEyVmZjR0Y1YldWdWRDa3NDaUFnSUNCa2FXY2dNZ29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TkRFMkNpQWdJQ0F2THlCbWFXeGxaRjloZEY5aWJHOWphejFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1Y205MWJtUXBMQW9nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8wTVRFdE5ERTVDaUFnSUNBdkx5QmthWE53ZFhSbElEMGdSR2x6Y0hWMFpWSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQmthWE53ZFhSbGNqMWhjbU0wTGtGa1pISmxjM01vWkdsemNIVjBaWEl1WW5sMFpYTXBMQW9nSUNBZ0x5OGdJQ0FnSUdScGMzQjFkR1ZrWDJGblpXNTBQV0Z5WXpRdVFXUmtjbVZ6Y3loa2FYTndkWFJsWkM1aWVYUmxjeWtzQ2lBZ0lDQXZMeUFnSUNBZ2RIaGZZVzF2ZFc1MFBYUjRYMkZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGclpWOXNiMk5yWldROVlYSmpOQzVWU1c1ME5qUW9jM1JoYTJWZmNHRjViV1Z1ZENrc0NpQWdJQ0F2THlBZ0lDQWdabWxzWldSZllYUmZZbXh2WTJzOVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xuSnZkVzVrS1N3S0lDQWdJQzh2SUNBZ0lDQnlaWE52YkhabFpEMWhjbU0wTGtKdmIyd29SbUZzYzJVcExBb2dJQ0FnTHk4Z0lDQWdJSFZ3YUdWc1pEMWhjbU0wTGtKdmIyd29SbUZzYzJVcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvME1qQUtJQ0FnSUM4dklITmxiR1l1WkdsemNIVjBaWE5iWkdsemNIVjBaVjlyWlhsZElEMGdaR2x6Y0hWMFpTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnMk5EY3dOV1lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPalF5TkFvZ0lDQWdMeThnY21WamIzSmtMbkJsYm1ScGJtZGZaR2x6Y0hWMFpWOXpkR0ZyWlM1dVlYUnBkbVVnS3lCemRHRnJaVjl3WVhsdFpXNTBDaUFnSUNCa2FXY2dOQW9nSUNBZ2NIVnphR2x1ZENBNU1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdLd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TkRJeUxUUXlOUW9nSUNBZ0x5OGdJeUJNYjJOcklITjBZV3RsSUdsdUlIQmxibVJwYm1jZ2NHOXZiQ0FvY21WamIzSmtaV1FnYjI0Z2RHaGxJR1JwYzNCMWRHVmtJR0ZuWlc1MEozTWdjbVZqYjNKa0tRb2dJQ0FnTHk4Z2NtVmpiM0prTG5CbGJtUnBibWRmWkdsemNIVjBaVjl6ZEdGclpTQTlJR0Z5WXpRdVZVbHVkRFkwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMjl5WkM1d1pXNWthVzVuWDJScGMzQjFkR1ZmYzNSaGEyVXVibUYwYVhabElDc2djM1JoYTJWZmNHRjViV1Z1ZEFvZ0lDQWdMeThnS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBNU1Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOREkyQ2lBZ0lDQXZMeUJ5WldOdmNtUXVaR2x6Y0hWMFpWOWpiM1Z1ZENBOUlHRnlZelF1VlVsdWREWTBLSEpsWTI5eVpDNWthWE53ZFhSbFgyTnZkVzUwTG01aGRHbDJaU0FySURFcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOelFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTnpRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qUXlOd29nSUNBZ0x5OGdjbVZqYjNKa0xtUnBjM0IxZEdWZmRtOXNkVzFsSUQwZ1lYSmpOQzVWU1c1ME5qUW9jbVZqYjNKa0xtUnBjM0IxZEdWZmRtOXNkVzFsTG01aGRHbDJaU0FySUhSNFgyRnRiM1Z1ZEM1dVlYUnBkbVVwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ09ESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEZ3lDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8wTWpnS0lDQWdJQzh2SUhKbFkyOXlaQzV6WTI5eVpWOWpZV05vWldSZllYUmZZbXh2WTJzZ1BTQmhjbU0wTGxWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lISmxjR3hoWTJVeUlERXpNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TkRNd0NpQWdJQ0F2THlCelpXeG1MbUZuWlc1MGMxdGthWE53ZFhSbFpGMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JrYVdjZ01nb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPak00TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1lXZGxiblJwWkM1QloyVnVkRWxFUTI5dWRISmhZM1F1Y21WemIyeDJaVjlrYVhOd2RYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WemIyeDJaVjlrYVhOd2RYUmxPZ29nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCa2RYQnVJRFlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pRek13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qUTBOQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmk1MllXeDFaU3dnSW1Ga2JXbHVJRzl1YkhraUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHRmtiV2x1SUc5dWJIa0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPalEwTmdvZ0lDQWdMeThnWkdsemNIVjBaVjlyWlhrZ1BTQnZjQzVwZEc5aUtHUnBjM0IxZEdWZmFXUXVibUYwYVhabEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZORFEzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1a2FYTndkWFJsY3k1dFlYbGlaU2hrYVhOd2RYUmxYMnRsZVNsYk1WMHNJQ0prYVhOd2RYUmxJRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGcyTkRjd05XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUdScGMzQjFkR1VnYm05MElHWnZkVzVrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvME5EZ0tJQ0FnSUM4dklHUnBjM0IxZEdVZ1BTQnpaV3htTG1ScGMzQjFkR1Z6TG0xaGVXSmxLR1JwYzNCMWRHVmZhMlY1S1Zzd1hTNWpiM0I1S0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZORFE1Q2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUdScGMzQjFkR1V1Y21WemIyeDJaV1F1Ym1GMGFYWmxMQ0FpWVd4eVpXRmtlU0J5WlhOdmJIWmxaQ0lLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBM01EUUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYkhKbFlXUjVJSEpsYzI5c2RtVmtDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8wTlRFS0lDQWdJQzh2SUdScGMzQjFkR1V1Y21WemIyeDJaV1FnUFNCaGNtTTBMa0p2YjJ3b1ZISjFaU2tLSUNBZ0lIQjFjMmhwYm5RZ056QTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8wTlRJS0lDQWdJQzh2SUdScGMzQjFkR1V1ZFhCb1pXeGtJRDBnZFhCb1pXeGtDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjSFZ6YUdsdWRDQTNNRFVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCa2RYQnVJRElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pRMU5Bb2dJQ0FnTHk4Z1pHbHpjSFYwWldRZ1BTQkJZMk52ZFc1MEtHUnBjM0IxZEdVdVpHbHpjSFYwWldSZllXZGxiblF1WW5sMFpYTXBDaUFnSUNCbGVIUnlZV04wSURNeUlETXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pRMU5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZV2RsYm5SekxtMWhlV0psS0dScGMzQjFkR1ZrS1ZzeFhTd2dJbVJwYzNCMWRHVmtJR0ZuWlc1MElHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNVFkzTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJR1JwYzNCMWRHVmtJR0ZuWlc1MElHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZORFUyQ2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxtRm5aVzUwY3k1dFlYbGlaU2hrYVhOd2RYUmxaQ2xiTUYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZORFU0TFRRMU9Rb2dJQ0FnTHk4Z0l5QlNaV3hsWVhObElIQmxibVJwYm1jZ2MzUmhhMlVnYkc5amF3b2dJQ0FnTHk4Z2FXWWdjbVZqYjNKa0xuQmxibVJwYm1kZlpHbHpjSFYwWlY5emRHRnJaUzV1WVhScGRtVWdQajBnWkdsemNIVjBaUzV6ZEdGclpWOXNiMk5yWldRdWJtRjBhWFpsT2dvZ0lDQWdjSFZ6YUdsdWRDQTVNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3ZFhOb2FXNTBJRGN5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0ErUFFvZ0lDQWdZbm9nY21WemIyeDJaVjlrYVhOd2RYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZORFl4Q2lBZ0lDQXZMeUJ5WldOdmNtUXVjR1Z1WkdsdVoxOWthWE53ZFhSbFgzTjBZV3RsTG01aGRHbDJaU0F0SUdScGMzQjFkR1V1YzNSaGEyVmZiRzlqYTJWa0xtNWhkR2wyWlFvZ0lDQWdaSFZ3TWdvZ0lDQWdMUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TkRZd0xUUTJNZ29nSUNBZ0x5OGdjbVZqYjNKa0xuQmxibVJwYm1kZlpHbHpjSFYwWlY5emRHRnJaU0E5SUdGeVl6UXVWVWx1ZERZMEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTI5eVpDNXdaVzVrYVc1blgyUnBjM0IxZEdWZmMzUmhhMlV1Ym1GMGFYWmxJQzBnWkdsemNIVjBaUzV6ZEdGclpWOXNiMk5yWldRdWJtRjBhWFpsQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdPVEFLSUNBZ0lHSjFjbmtnTXdvS2NtVnpiMngyWlY5a2FYTndkWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pRMk5Bb2dJQ0FnTHk4Z2FXWWdkWEJvWld4a0xtNWhkR2wyWlRvS0lDQWdJR1JwWnlBMkNpQWdJQ0JpZWlCeVpYTnZiSFpsWDJScGMzQjFkR1ZmWld4elpWOWliMlI1UURFd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzBOalV0TkRZNENpQWdJQ0F2THlBaklGQmxibUZzZEhrNklHUmxaSFZqZENCd2NtOXdiM0owYVc5dVlXd2dhVzF3WVdOMElHWnliMjBnWVdkbGJuUW5jeUJrYVhOd2RYUmxJSEpoZEdsdkNpQWdJQ0F2THlBaklDaGhiSEpsWVdSNUlHTmhjSFIxY21Wa0lHbHVJR1JwYzNCMWRHVmZZMjkxYm5RZ1lXNWtJR1JwYzNCMWRHVmZkbTlzZFcxbEtRb2dJQ0FnTHk4Z0l5QlRiR0Z6YUNCaFoyVnVkQ2R6SUhOMFlXdGxJSEJ5YjNCdmNuUnBiMjVoYkd4NUNpQWdJQ0F2THlCemJHRnphQ0E5SUdScGMzQjFkR1V1ZEhoZllXMXZkVzUwTG01aGRHbDJaUW9nSUNBZ1pHbG5JRFVLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVFlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pRMk9Rb2dJQ0FnTHk4Z2FXWWdjMnhoYzJnZ1BpQnlaV052Y21RdWMzUmhhMlZmWVd4bmJ5NXVZWFJwZG1VNkNpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHbHVkQ0ExTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE5nb2dJQ0FnUGdvZ0lDQWdZbm9nY21WemIyeDJaVjlrYVhOd2RYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnWkdsbklERXpDaUFnSUNCaWRYSjVJREUxQ2dweVpYTnZiSFpsWDJScGMzQjFkR1ZmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TkRjeENpQWdJQ0F2THlCeVpXTnZjbVF1YzNSaGEyVmZZV3huYnlBOUlHRnlZelF1VlVsdWREWTBLSEpsWTI5eVpDNXpkR0ZyWlY5aGJHZHZMbTVoZEdsMlpTQXRJSE5zWVhOb0tRb2dJQ0FnWkdsbklERXpDaUFnSUNCa2FXY2dNVFVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMUW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEVXdDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TkRjeUNpQWdJQ0F2THlCcFppQnlaV052Y21RdWVHRnNaMjlmWW1Gc1lXNWpaUzV1WVhScGRtVWdQajBnYzJ4aGMyZzZDaUFnSUNCd2RYTm9hVzUwSURVNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTBDaUFnSUNBOFBRb2dJQ0FnWW5vZ2NtVnpiMngyWlY5a2FYTndkWFJsWDJWc2MyVmZZbTlrZVVBNENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzBOek1LSUNBZ0lDOHZJSEpsWTI5eVpDNTRZV3huYjE5aVlXeGhibU5sSUQwZ1lYSmpOQzVWU1c1ME5qUW9jbVZqYjNKa0xuaGhiR2R2WDJKaGJHRnVZMlV1Ym1GMGFYWmxJQzBnYzJ4aGMyZ3BDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdMUW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEVTRDaUFnSUNCaWRYSjVJRE1LQ25KbGMyOXNkbVZmWkdsemNIVjBaVjloWm5SbGNsOXBabDlsYkhObFFERTJPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TkRrekNpQWdJQ0F2THlCeVpXTnZjbVF1YzJOdmNtVmZZMkZqYUdWa1gyRjBYMkpzYjJOcklEMGdZWEpqTkM1VlNXNTBOalFvTUNrS0lDQWdJR1JwWnlBeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdjbVZ3YkdGalpUSWdNVE14Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvME9UUUtJQ0FnSUM4dklITmxiR1l1WVdkbGJuUnpXMlJwYzNCMWRHVmtYU0E5SUhKbFkyOXlaQzVqYjNCNUtDa0tJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5EazFDaUFnSUNBdkx5QnpaV3htTG1ScGMzQjFkR1Z6VzJScGMzQjFkR1ZmYTJWNVhTQTlJR1JwYzNCMWRHVXVZMjl3ZVNncENpQWdJQ0JrYVdjZ053b2dJQ0FnWkdsbklEWUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pRek13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dweVpYTnZiSFpsWDJScGMzQjFkR1ZmWld4elpWOWliMlI1UURnNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzBOelVLSUNBZ0lDOHZJSEpsWTI5eVpDNTRZV3huYjE5aVlXeGhibU5sSUQwZ1lYSmpOQzVWU1c1ME5qUW9NQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2NtVndiR0ZqWlRJZ05UZ0tJQ0FnSUdKMWNua2dNd29nSUNBZ1lpQnlaWE52YkhabFgyUnBjM0IxZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF4TmdvS2NtVnpiMngyWlY5a2FYTndkWFJsWDJWc2MyVmZZbTlrZVVBeE1Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPalEzTnkwME56Z0tJQ0FnSUM4dklDTWdTVzUyWVd4cFpDQmthWE53ZFhSbE9pQnpiR0Z6YUNBMU1DVWdiMllnYkc5amEyVmtJSE4wWVd0bExDQnpaVzVrSUhSdklHUnBjM0IxZEdWa0lHRm5aVzUwQ2lBZ0lDQXZMeUJ6YkdGemFGOWhiVzkxYm5RZ1BTQW9aR2x6Y0hWMFpTNXpkR0ZyWlY5c2IyTnJaV1F1Ym1GMGFYWmxJQ29nVlVsdWREWTBLRVJKVTFCVlZFVmZVMHhCVTBoZlVFVlNRMFZPVkNrcElDOHZJRlZKYm5RMk5DZ3hNREFwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05UQUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk15QXZMeUF4TURBS0lDQWdJQzhLSUNBZ0lHSjFjbmtnTVRNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qUTNPUzAwT0RBS0lDQWdJQzh2SUNNZ1VtVnRiM1psSUhCbGJtRnNkSGtnWm5KdmJTQmthWE53ZFhSbFgyTnZkVzUwSUhOcGJtTmxJR1JwYzNCMWRHVWdkMkZ6SUdsdWRtRnNhV1FLSUNBZ0lDOHZJR2xtSUhKbFkyOXlaQzVrYVhOd2RYUmxYMk52ZFc1MExtNWhkR2wyWlNBK0lGVkpiblEyTkNnd0tUb0tJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURjMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXlDaUFnSUNCaWVpQnlaWE52YkhabFgyUnBjM0IxZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5EZ3hDaUFnSUNBdkx5QnlaV052Y21RdVpHbHpjSFYwWlY5amIzVnVkQ0E5SUdGeVl6UXVWVWx1ZERZMEtISmxZMjl5WkM1a2FYTndkWFJsWDJOdmRXNTBMbTVoZEdsMlpTQXRJREVwQ2lBZ0lDQmthV2NnTVRBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ056UUtJQ0FnSUdKMWNua2dNd29LY21WemIyeDJaVjlrYVhOd2RYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8wT0RJS0lDQWdJQzh2SUdsbUlISmxZMjl5WkM1a2FYTndkWFJsWDNadmJIVnRaUzV1WVhScGRtVWdQajBnWkdsemNIVjBaUzUwZUY5aGJXOTFiblF1Ym1GMGFYWmxPZ29nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ09ESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVEVLSUNBZ0lHUnBaeUEyQ2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQStQUW9nSUNBZ1lub2djbVZ6YjJ4MlpWOWthWE53ZFhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qUTROQW9nSUNBZ0x5OGdjbVZqYjNKa0xtUnBjM0IxZEdWZmRtOXNkVzFsTG01aGRHbDJaU0F0SUdScGMzQjFkR1V1ZEhoZllXMXZkVzUwTG01aGRHbDJaUW9nSUNBZ1pHbG5JRGtLSUNBZ0lHUnBaeUE1Q2lBZ0lDQXRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8wT0RNdE5EZzFDaUFnSUNBdkx5QnlaV052Y21RdVpHbHpjSFYwWlY5MmIyeDFiV1VnUFNCaGNtTTBMbFZKYm5RMk5DZ0tJQ0FnSUM4dklDQWdJQ0J5WldOdmNtUXVaR2x6Y0hWMFpWOTJiMngxYldVdWJtRjBhWFpsSUMwZ1pHbHpjSFYwWlM1MGVGOWhiVzkxYm5RdWJtRjBhWFpsQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdPRElLSUNBZ0lHSjFjbmtnTXdvS2NtVnpiMngyWlY5a2FYTndkWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFNVFE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvME9EWXRORGt4Q2lBZ0lDQXZMeUFqSUZObGJtUWdjMnhoYzJobFpDQm1kVzVrY3lCMGJ5QjBhR1VnWkdsemNIVjBaV1FnWVdkbGJuUWdZWE1nWTI5dGNHVnVjMkYwYVc5dUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5WkdsemNIVjBaV1FzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhOc1lYTm9YMkZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOVZVbHVkRFkwS0RFd01EQXBMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWkdsbklERXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdaR2xuSURRS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pRNE5pMDBPRGNLSUNBZ0lDOHZJQ01nVTJWdVpDQnpiR0Z6YUdWa0lHWjFibVJ6SUhSdklIUm9aU0JrYVhOd2RYUmxaQ0JoWjJWdWRDQmhjeUJqYjIxd1pXNXpZWFJwYjI0S0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qUTVNQW9nSUNBZ0x5OGdabVZsUFZWSmJuUTJOQ2d4TURBd0tTd0tJQ0FnSUdsdWRHTWdOQ0F2THlBeE1EQXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TkRnMkxUUTVNUW9nSUNBZ0x5OGdJeUJUWlc1a0lITnNZWE5vWldRZ1puVnVaSE1nZEc4Z2RHaGxJR1JwYzNCMWRHVmtJR0ZuWlc1MElHRnpJR052YlhCbGJuTmhkR2x2YmdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQV1JwYzNCMWRHVmtMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF6YkdGemFGOWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d4TURBd0tTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JpSUhKbGMyOXNkbVZmWkdsemNIVjBaVjloWm5SbGNsOXBabDlsYkhObFFERTJDZ29LTHk4Z1lXZGxiblJwWkM1QloyVnVkRWxFUTI5dWRISmhZM1F1Wlc1a2IzSnpaVjloWjJWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVZ1Wkc5eWMyVmZZV2RsYm5RNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzFNREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzFNVElLSUNBZ0lDOHZJR1Z1Wkc5eWMyVnlJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TlRFekNpQWdJQ0F2THlCbGJtUnZjbk5sWlY5aFkyTnZkVzUwSUQwZ1FXTmpiM1Z1ZENobGJtUnZjbk5sWlM1aWVYUmxjeWtLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUZrWkhKbGMzTWdiR1Z1WjNSb0lHbHpJRE15SUdKNWRHVnpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8xTVRVS0lDQWdJQzh2SUdGemMyVnlkQ0JsYm1SdmNuTmxjaUFoUFNCbGJtUnZjbk5sWlY5aFkyTnZkVzUwTENBaVkyRnVibTkwSUhObGJHWXRaVzVrYjNKelpTSUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklETUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdWJtOTBJSE5sYkdZdFpXNWtiM0p6WlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5URTNDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVoWjJWdWRITXViV0Y1WW1Vb1pXNWtiM0p6WlhJcFd6RmRMQ0FpWlc1a2IzSnpaWElnYm05MElISmxaMmx6ZEdWeVpXUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROakUyTnpWbUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJR1Z1Wkc5eWMyVnlJRzV2ZENCeVpXZHBjM1JsY21Wa0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzFNVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1GblpXNTBjeTV0WVhsaVpTaGxibVJ2Y25ObFpWOWhZMk52ZFc1MEtWc3hYU3dnSW1WdVpHOXljMlZsSUc1dmRDQnlaV2RwYzNSbGNtVmtJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFl4TmpjMVpnb2dJQ0FnWkdsbklEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJsYm1SdmNuTmxaU0J1YjNRZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOVEU1Q2lBZ0lDQXZMeUJsY2w5eVpXTnZjbVFnUFNCelpXeG1MbUZuWlc1MGN5NXRZWGxpWlNobGJtUnZjbk5sY2lsYk1GMHVZMjl3ZVNncENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPalV5TUFvZ0lDQWdMeThnWldWZmNtVmpiM0prSUQwZ2MyVnNaaTVoWjJWdWRITXViV0Y1WW1Vb1pXNWtiM0p6WldWZllXTmpiM1Z1ZENsYk1GMHVZMjl3ZVNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvMU1qSXROVEl6Q2lBZ0lDQXZMeUFqSUVOb1pXTnJJR1Z1Wkc5eWMyVnlJR2x6SUZabGNtbG1hV1ZrSUhScFpYSUtJQ0FnSUM4dklHVnVaRzl5YzJWeVgzTmpiM0psSUQwZ1pYSmZjbVZqYjNKa0xtTmhZMmhsWkY5elkyOXlaUzV1WVhScGRtVUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F4TWpNZ09Bb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F4TWpNS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzFNalFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxibVJ2Y25ObGNsOXpZMjl5WlNBK1BTQlZTVzUwTmpRb1JVNUVUMUpUUlUxRlRsUmZUVWxPWDFORFQxSkZLU3dnSW1WdVpHOXljMlZ5SUcxMWMzUWdZbVVnVm1WeWFXWnBaV1FnZEdsbGNpSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0E0TUFvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxibVJ2Y25ObGNpQnRkWE4wSUdKbElGWmxjbWxtYVdWa0lIUnBaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pVeU5pMDFNamNLSUNBZ0lDOHZJQ01nVm1WeWFXWjVJSE4wWVd0bElIQmhlVzFsYm5RS0lDQWdJQzh2SUhCaGVXMWxiblFnUFNCdmNDNUhWSGh1TG1GdGIzVnVkQ2hVZUc0dVozSnZkWEJmYVc1a1pYZ2dMU0F4S1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPalV5T0FvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUWdQajBnYzNSaGEyVmZZVzF2ZFc1MExtNWhkR2wyWlN3Z0luTjBZV3RsSUhCaGVXMWxiblFnYldsemJXRjBZMmdpQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QXhDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUhOMFlXdGxJSEJoZVcxbGJuUWdiV2x6YldGMFkyZ0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPalV6TUMwMU16RUtJQ0FnSUM4dklDTWdSVzVrYjNKelpXMWxiblFnYTJWNUlEMGdaVzVrYjNKelpYSmZZbmwwWlhNZ0t5QmxibVJ2Y25ObFpWOWllWFJsY3dvZ0lDQWdMeThnWlc1a2IzSnpaVzFsYm5SZmEyVjVJRDBnWlc1a2IzSnpaWEl1WW5sMFpYTWdLeUJsYm1SdmNuTmxaVjloWTJOdmRXNTBMbUo1ZEdWekNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8xTXpZS0lDQWdJQzh2SUhOMFlXdGxYMkZ0YjNWdWREMWhjbU0wTGxWSmJuUTJOQ2h3WVhsdFpXNTBLU3dLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvMU16Z0tJQ0FnSUM4dklHVnVaRzl5YzJWa1gyRjBYMkpzYjJOclBXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXliM1Z1WkNrc0NpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qVXpNeTAxTkRBS0lDQWdJQzh2SUdWdVpHOXljMlZ0Wlc1MElEMGdSVzVrYjNKelpXMWxiblJTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnWlc1a2IzSnpaWEk5WVhKak5DNUJaR1J5WlhOektHVnVaRzl5YzJWeUxtSjVkR1Z6S1N3S0lDQWdJQzh2SUNBZ0lDQmxibVJ2Y25ObFpUMWhjbU0wTGtGa1pISmxjM01vWlc1a2IzSnpaV1ZmWVdOamIzVnVkQzVpZVhSbGN5a3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGEyVmZZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLSEJoZVcxbGJuUXBMQW9nSUNBZ0x5OGdJQ0FnSUdWdVpHOXljMlZ5WDNOamIzSmxYMkYwWDNScGJXVTlZWEpqTkM1VlNXNTBOalFvWlc1a2IzSnpaWEpmYzJOdmNtVXBMQW9nSUNBZ0x5OGdJQ0FnSUdWdVpHOXljMlZrWDJGMFgySnNiMk5yUFdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1eWIzVnVaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lXTjBhWFpsUFdGeVl6UXVRbTl2YkNoVWNuVmxLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TlRNNUNpQWdJQ0F2THlCaFkzUnBkbVU5WVhKak5DNUNiMjlzS0ZSeWRXVXBMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pVek15MDFOREFLSUNBZ0lDOHZJR1Z1Wkc5eWMyVnRaVzUwSUQwZ1JXNWtiM0p6WlcxbGJuUlNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdaVzVrYjNKelpYSTlZWEpqTkM1QlpHUnlaWE56S0dWdVpHOXljMlZ5TG1KNWRHVnpLU3dLSUNBZ0lDOHZJQ0FnSUNCbGJtUnZjbk5sWlQxaGNtTTBMa0ZrWkhKbGMzTW9aVzVrYjNKelpXVmZZV05qYjNWdWRDNWllWFJsY3lrc0NpQWdJQ0F2THlBZ0lDQWdjM1JoYTJWZllXMXZkVzUwUFdGeVl6UXVWVWx1ZERZMEtIQmhlVzFsYm5RcExBb2dJQ0FnTHk4Z0lDQWdJR1Z1Wkc5eWMyVnlYM05qYjNKbFgyRjBYM1JwYldVOVlYSmpOQzVWU1c1ME5qUW9aVzVrYjNKelpYSmZjMk52Y21VcExBb2dJQ0FnTHk4Z0lDQWdJR1Z1Wkc5eWMyVmtYMkYwWDJKc2IyTnJQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzV5YjNWdVpDa3NDaUFnSUNBdkx5QWdJQ0FnWVdOMGFYWmxQV0Z5WXpRdVFtOXZiQ2hVY25WbEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TlRReENpQWdJQ0F2THlCelpXeG1MbVZ1Wkc5eWMyVnRaVzUwYzF0bGJtUnZjbk5sYldWdWRGOXJaWGxkSUQwZ1pXNWtiM0p6WlcxbGJuUXVZMjl3ZVNncENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8xTkRNdE5UUTFDaUFnSUNBdkx5QWpJRlZ3WkdGMFpTQmxibVJ2Y25ObFpTZHpJR0ZuWjNKbFoyRjBaU0JsYm1SdmNuTmxiV1Z1ZENCelkyOXlaUW9nSUNBZ0x5OGdJeUJsYm1SdmNuTmxiV1Z1ZEY5elkyOXlaU0FyUFNBb2MzUmhhMlVnS2lCbGJtUnZjbk5sY2w5elkyOXlaU0F2SURFd01Da2dMeUF4WHpBd01GOHdNREFnS0c1dmNtMWhiR2w2WldRcENpQWdJQ0F2THlCamIyNTBjbWxpZFhScGIyNGdQU0FvY0dGNWJXVnVkQ0FxSUdWdVpHOXljMlZ5WDNOamIzSmxLU0F2THlCVlNXNTBOalFvTVRBd0tRb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eklDOHZJREV3TUFvZ0lDQWdMd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TlRRM0NpQWdJQ0F2THlCbFpWOXlaV052Y21RdVpXNWtiM0p6WlcxbGJuUmZjMk52Y21VdWJtRjBhWFpsSUNzZ1kyOXVkSEpwWW5WMGFXOXVDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBMk5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUNzS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qVTBOaTAxTkRnS0lDQWdJQzh2SUdWbFgzSmxZMjl5WkM1bGJtUnZjbk5sYldWdWRGOXpZMjl5WlNBOUlHRnlZelF1VlVsdWREWTBLQW9nSUNBZ0x5OGdJQ0FnSUdWbFgzSmxZMjl5WkM1bGJtUnZjbk5sYldWdWRGOXpZMjl5WlM1dVlYUnBkbVVnS3lCamIyNTBjbWxpZFhScGIyNEtJQ0FnSUM4dklDa0tJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdOallLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pVME9Rb2dJQ0FnTHk4Z1pXVmZjbVZqYjNKa0xuTmpiM0psWDJOaFkyaGxaRjloZEY5aWJHOWpheUE5SUdGeVl6UXVWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnY21Wd2JHRmpaVElnTVRNeENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzFOVEFLSUNBZ0lDOHZJSE5sYkdZdVlXZGxiblJ6VzJWdVpHOXljMlZsWDJGalkyOTFiblJkSUQwZ1pXVmZjbVZqYjNKa0xtTnZjSGtvS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TlRBeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmhaMlZ1ZEdsa0xrRm5aVzUwU1VSRGIyNTBjbUZqZEM1elpYUmZjMkZ1WkdKdmVGOWpaWEowYVdacFpXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZmMyRnVaR0p2ZUY5alpYSjBhV1pwWldRNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzFOVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzFOallLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXVjMkZ1WkdKdmVGOWhkWFJvYjNKcGRIa3VkbUZzZFdVc0lDSnpZVzVrWW05NElHRjFkR2h2Y21sMGVTQnZibXg1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luTmhibVJpYjNoZllYVjBhRzl5YVhSNUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk5oYm1SaWIzaGZZWFYwYUc5eWFYUjVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ6WVc1a1ltOTRJR0YxZEdodmNtbDBlU0J2Ym14NUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzFOamdLSUNBZ0lDOHZJR0ZuWlc1MFgyRmpZMjkxYm5RZ1BTQkJZMk52ZFc1MEtHRm5aVzUwTG1KNWRHVnpLUW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRV1JrY21WemN5QnNaVzVuZEdnZ2FYTWdNeklnWW5sMFpYTUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPalUyT1FvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVlXZGxiblJ6TG0xaGVXSmxLR0ZuWlc1MFgyRmpZMjkxYm5RcFd6RmRMQ0FpWVdkbGJuUWdibTkwSUhKbFoybHpkR1Z5WldRaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qRTJOelZtQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5UY3dDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1GblpXNTBjeTV0WVhsaVpTaGhaMlZ1ZEY5aFkyTnZkVzUwS1Zzd1hTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzFOekVLSUNBZ0lDOHZJSEpsWTI5eVpDNXpZVzVrWW05NFgzTmpaVzVoY21sdmMxOXdZWE56WldRZ1BTQnpZMlZ1WVhKcGIzTmZjR0Z6YzJWa0NpQWdJQ0JrYVdjZ01nb2dJQ0FnY21Wd2JHRmpaVElnT1RnS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qVTNNd29nSUNBZ0x5OGdjMk5sYm1GeWFXOXpYM0JoYzNObFpDNXVZWFJwZG1VZ1BqMGdWVWx1ZERZMEtGTkJUa1JDVDFoZlJsVk1URjlEUlZKVVgxTkRSVTVCVWtsUFV5a0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZblJ2YVFvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBK1BRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOVGN5TFRVM05Bb2dJQ0FnTHk4Z2NtVmpiM0prTG5OaGJtUmliM2hmWTJWeWRHbG1hV1ZrSUQwZ1lYSmpOQzVDYjI5c0tBb2dJQ0FnTHk4Z0lDQWdJSE5qWlc1aGNtbHZjMTl3WVhOelpXUXVibUYwYVhabElENDlJRlZKYm5RMk5DaFRRVTVFUWs5WVgwWlZURXhmUTBWU1ZGOVRRMFZPUVZKSlQxTXBDaUFnSUNBdkx5QXBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnYVc1MFl5QTJJQzh2SURnME9Bb2dJQ0FnYzNkaGNBb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8xTnpVS0lDQWdJQzh2SUhKbFkyOXlaQzV6WTI5eVpWOWpZV05vWldSZllYUmZZbXh2WTJzZ1BTQmhjbU0wTGxWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lISmxjR3hoWTJVeUlERXpNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TlRjMkNpQWdJQ0F2THlCelpXeG1MbUZuWlc1MGMxdGhaMlZ1ZEY5aFkyTnZkVzUwWFNBOUlISmxZMjl5WkM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPalUxTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1lXZGxiblJwWkM1QloyVnVkRWxFUTI5dWRISmhZM1F1YzJWMFgyVjFjbTlmWVhSMFpYTjBZWFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJmWlhWeWIxOWhkSFJsYzNSaGRHbHZiam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pVNE1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TlRnNENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1WMWNtOWZiM0poWTJ4bExuWmhiSFZsTENBaVpYVnlieUJ2Y21GamJHVWdiMjVzZVNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSmxkWEp2WDI5eVlXTnNaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bGRYSnZYMjl5WVdOc1pTQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWFZ5YnlCdmNtRmpiR1VnYjI1c2VRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOVGt3Q2lBZ0lDQXZMeUJoWjJWdWRGOWhZMk52ZFc1MElEMGdRV05qYjNWdWRDaGhaMlZ1ZEM1aWVYUmxjeWtLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlpHUnlaWE56SUd4bGJtZDBhQ0JwY3lBek1pQmllWFJsY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5Ua3hDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVoWjJWdWRITXViV0Y1WW1Vb1lXZGxiblJmWVdOamIzVnVkQ2xiTVYwc0lDSmhaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTVRZM05XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5Ua3lDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1GblpXNTBjeTV0WVhsaVpTaGhaMlZ1ZEY5aFkyTnZkVzUwS1Zzd1hTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzFPVE1LSUNBZ0lDOHZJSEpsWTI5eVpDNWxkWEp2WDJGMGRHVnpkR1ZrSUQwZ1lYSmpOQzVDYjI5c0tGUnlkV1VwQ2lBZ0lDQndkWE5vYVc1MElEZzBPUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TlRrMENpQWdJQ0F2THlCeVpXTnZjbVF1YzJOdmNtVmZZMkZqYUdWa1gyRjBYMkpzYjJOcklEMGdZWEpqTkM1VlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnlaWEJzWVdObE1pQXhNekVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pVNU5Rb2dJQ0FnTHk4Z2MyVnNaaTVoWjJWdWRITmJZV2RsYm5SZllXTmpiM1Z1ZEYwZ1BTQnlaV052Y21RdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8xT0RJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHRm5aVzUwYVdRdVFXZGxiblJKUkVOdmJuUnlZV04wTG1kbGJtVnphWE5mYVc1cGRHbGhiR2w2WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxibVZ6YVhOZmFXNXBkR2xoYkdsNlpUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzJNREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TmpFekNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1Ga2JXbHVMblpoYkhWbExDQWlZV1J0YVc0Z2IyNXNlU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFpHMXBiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWVdSdGFXNGdiMjVzZVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5qRTBDaUFnSUNBdkx5QmxlSEJwY25rZ1BTQkhiRzlpWVd3dWNtOTFibVFnS3lCVlNXNTBOalFvUjBWT1JWTkpVMTlFUlVOQldWOUNURTlEUzFNcENpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2x1ZEdNZ09DQXZMeUF5TURBd01EQUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2dwblpXNWxjMmx6WDJsdWFYUnBZV3hwZW1WZlptOXlYMkp2WkhsQU1qb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPall4TndvZ0lDQWdMeThnYldWdFltVnlJRDBnUVdOamIzVnVkQ2h0WlcxaVpYSmZZV1JrY2k1aWVYUmxjeWtLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUVdSa2NtVnpjeUJzWlc1bmRHZ2dhWE1nTXpJZ1lubDBaWE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pZeE9Bb2dJQ0FnTHk4Z2FXWWdjMlZzWmk1aFoyVnVkSE11YldGNVltVW9iV1Z0WW1WeUtWc3hYVG9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTVRZM05XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFlLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1oyVnVaWE5wYzE5cGJtbDBhV0ZzYVhwbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5qRTVDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1GblpXNTBjeTV0WVhsaVpTaHRaVzFpWlhJcFd6QmRMbU52Y0hrb0tRb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8yTWpBS0lDQWdJQzh2SUhKbFkyOXlaQzVuWlc1bGMybHpYM05qYjNKbElEMGdZWEpqTkM1VlNXNTBOalFvUjBWT1JWTkpVMTlUUTA5U1JTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TXpJS0lDQWdJSEpsY0d4aFkyVXlJREV3TndvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5qSXhDaUFnSUNBdkx5QnlaV052Y21RdVoyVnVaWE5wYzE5bGVIQnBjbmxmWW14dlkyc2dQU0JoY21NMExsVkpiblEyTkNobGVIQnBjbmtwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdNVEUxQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvMk1qSUtJQ0FnSUM4dklISmxZMjl5WkM1elkyOXlaVjlqWVdOb1pXUmZZWFJmWW14dlkyc2dQU0JoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSEpsY0d4aFkyVXlJREV6TVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5qSXpDaUFnSUNBdkx5QnpaV3htTG1GblpXNTBjMXR0WlcxaVpYSmRJRDBnY21WamIzSmtMbU52Y0hrb0tRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvS1oyVnVaWE5wYzE5cGJtbDBhV0ZzYVhwbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qWXhOZ29nSUNBZ0x5OGdabTl5SUcxbGJXSmxjbDloWkdSeUlHbHVJQ2h0WlcxaVpYSXhMQ0J0WlcxaVpYSXlMQ0J0WlcxaVpYSXpLVG9LSUNBZ0lHUjFjQW9nSUNBZ2MzZHBkR05vSUdkbGJtVnphWE5mYVc1cGRHbGhiR2w2WlY5bWIzSmZhR1ZoWkdWeVh6RkFOaUJuWlc1bGMybHpYMmx1YVhScFlXeHBlbVZmWm05eVgyaGxZV1JsY2w4eVFEY0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPall3TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BuWlc1bGMybHpYMmx1YVhScFlXeHBlbVZmWm05eVgyaGxZV1JsY2w4eVFEYzZDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWkdsbklESUtJQ0FnSUdJZ1oyVnVaWE5wYzE5cGJtbDBhV0ZzYVhwbFgyWnZjbDlpYjJSNVFESUtDbWRsYm1WemFYTmZhVzVwZEdsaGJHbDZaVjltYjNKZmFHVmhaR1Z5WHpGQU5qb0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdScFp5QXpDaUFnSUNCaUlHZGxibVZ6YVhOZmFXNXBkR2xoYkdsNlpWOW1iM0pmWW05a2VVQXlDZ29LTHk4Z1lXZGxiblJwWkM1QloyVnVkRWxFUTI5dWRISmhZM1F1ZFhCa1lYUmxYMkZrYldsdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkWEJrWVhSbFgyRmtiV2x1T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5qSTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvMk1qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0poWkcxcGJpQnZibXg1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCaFpHMXBiaUJ2Ym14NUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzJNamtLSUNBZ0lDOHZJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVWdQU0JCWTJOdmRXNTBLRzVsZDE5aFpHMXBiaTVpZVhSbGN5a0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWkdSeVpYTnpJR3hsYm1kMGFDQnBjeUF6TWlCaWVYUmxjd29nSUNBZ1lubDBaV05mTXlBdkx5QWlZV1J0YVc0aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOakkxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCaFoyVnVkR2xrTGtGblpXNTBTVVJEYjI1MGNtRmpkQzUxY0dSaGRHVmZaWFZ5YjE5dmNtRmpiR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1ZmWlhWeWIxOXZjbUZqYkdVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzJNekVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qWXpOQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmk1MllXeDFaU3dnSW1Ga2JXbHVJRzl1YkhraUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHRmtiV2x1SUc5dWJIa0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPall6TlFvZ0lDQWdMeThnYzJWc1ppNWxkWEp2WDI5eVlXTnNaUzUyWVd4MVpTQTlJRUZqWTI5MWJuUW9ibVYzWDI5eVlXTnNaUzVpZVhSbGN5a0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWkdSeVpYTnpJR3hsYm1kMGFDQnBjeUF6TWlCaWVYUmxjd29nSUNBZ1lubDBaV01nTmlBdkx5QWlaWFZ5YjE5dmNtRmpiR1VpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5qTXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJoWjJWdWRHbGtMa0ZuWlc1MFNVUkRiMjUwY21GamRDNWZZMjl0Y0hWMFpWOXpZMjl5WlNoeVpXTnZjbVE2SUdKNWRHVnpMQ0JqZFhKeVpXNTBYMkpzYjJOck9pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Dd2dkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalFzSUdKNWRHVnpPZ3BmWTI5dGNIVjBaVjl6WTI5eVpUb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPalkwTVMwMk5EWUtJQ0FnSUM4dklFQnpkV0p5YjNWMGFXNWxDaUFnSUNBdkx5QmtaV1lnWDJOdmJYQjFkR1ZmYzJOdmNtVW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd0tJQ0FnSUM4dklDQWdJQ0J5WldOdmNtUTZJRUZuWlc1MFVtVmpiM0prTEFvZ0lDQWdMeThnSUNBZ0lHTjFjbkpsYm5SZllteHZZMnM2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ2tnTFQ0Z2RIVndiR1ZiVlVsdWREWTBMQ0JWU1c1ME5qUXNJRlZKYm5RMk5Dd2dWVWx1ZERZMExDQlZTVzUwTmpRc0lGVkpiblEyTkYwNkNpQWdJQ0J3Y205MGJ5QXlJRGNLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1pIVndiaUF4TkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5qVXpDaUFnSUNBdkx5QmtaVzV2YlRFZ1BTQnlaV052Y21RdWMyVjBkR3hsYldWdWRGOWpiM1Z1ZEM1dVlYUnBkbVVnS3lCVlNXNTBOalFvTVNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvMk5UUUtJQ0FnSUM4dklITXhJRDBnS0hKbFkyOXlaQzVqYjI1bWFYSnRaV1JmYzJWMGRHeGxiV1Z1ZEhNdWJtRjBhWFpsSUNvZ1ZVbHVkRFkwS0RFd01Da3BJQzh2SUdSbGJtOXRNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURFd01Bb2dJQ0FnS2dvZ0lDQWdjM2RoY0FvZ0lDQWdMd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TmpVMkxUWTFPUW9nSUNBZ0x5OGdJeUF0TFMwZ1UybG5ibUZzSURJNklFTnZkVzUwWlhKd1lYSjBlU0JFYVhabGNuTnBkSGtnS0RJd0pTa2dMUzB0Q2lBZ0lDQXZMeUFqSUZOdlpuUXRZMkZ3SUdGMElFMUJXRjlFU1ZaRlVsTkpWRmxmUTA5VlRsUkZVbEJCVWxSSlJWTWdkMmwwYUNCemNYVmhjbVV0Y205dmRDQnpZMkZzYVc1bkNpQWdJQ0F2THlBaklITmpiM0psSUQwZ2JXbHVLREV3TUN3Z2MzRnlkQ2gxYm1seGRXVXBJQ29nTVRBcElDRGlocElnTVRBd0lIVnVhWEYxWlNEaWhwSWdjMk52Y21VZ01UQXdDaUFnSUNBdkx5QjFibWx4ZFdVZ1BTQnlaV052Y21RdWRXNXBjWFZsWDJOdmRXNTBaWEp3WVhKMGVWOWpiM1Z1ZEM1dVlYUnBkbVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR2x1ZENBeU5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOall3Q2lBZ0lDQXZMeUJwWmlCMWJtbHhkV1VnUGlCVlNXNTBOalFvVFVGWVgwUkpWa1ZTVTBsVVdWOURUMVZPVkVWU1VFRlNWRWxGVXlrNkNpQWdJQ0JwYm5Salh6TWdMeThnTVRBd0NpQWdJQ0ErQ2lBZ0lDQmllaUJmWTI5dGNIVjBaVjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qWTJNUW9nSUNBZ0x5OGdkVzVwY1hWbElEMGdWVWx1ZERZMEtFMUJXRjlFU1ZaRlVsTkpWRmxmUTA5VlRsUkZVbEJCVWxSSlJWTXBDaUFnSUNCcGJuUmpYek1nTHk4Z01UQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlERTRDZ3BmWTI5dGNIVjBaVjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzRNaklLSUNBZ0lDOHZJR2xtSUc0Z1BUMGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklERTRDaUFnSUNCaWJub2dYMk52YlhCMWRHVmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUF6T1FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk9ESXpDaUFnSUNBdkx5QnlaWFIxY200Z1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvS1gyTnZiWEIxZEdWZmMyTnZjbVZmWVdaMFpYSmZhVzVzYVc1bFpGOWhaMlZ1ZEdsa0xrRm5aVzUwU1VSRGIyNTBjbUZqZEM1ZmFYTnhjblJBTkRJNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzJOakl0TmpZekNpQWdJQ0F2THlBaklFbHVkR1ZuWlhJZ2MzRnlkQ0JoY0hCeWIzaHBiV0YwYVc5dU9pQnBjM0Z5ZENoNEtTQjJhV0VnVG1WM2RHOXVKM01nYldWMGFHOWtDaUFnSUNBdkx5QnpNaUE5SUhObGJHWXVYMmx6Y1hKMEtIVnVhWEYxWlNrZ0tpQlZTVzUwTmpRb01UQXBDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0FxQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TmpZMENpQWdJQ0F2THlCcFppQnpNaUErSUZWSmJuUTJOQ2d4TURBcE9nb2dJQ0FnYVc1MFkxOHpJQzh2SURFd01Bb2dJQ0FnUGdvZ0lDQWdZbm9nWDJOdmJYQjFkR1ZmYzJOdmNtVmZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzJOalVLSUNBZ0lDOHZJSE15SUQwZ1ZVbHVkRFkwS0RFd01Da0tJQ0FnSUdsdWRHTmZNeUF2THlBeE1EQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05nb0tYMk52YlhCMWRHVmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5qWTNMVFkzTUFvZ0lDQWdMeThnSXlBdExTMGdVMmxuYm1Gc0lETTZJRlJwYldVdFYyVnBaMmgwWldRZ1FXTjBhWFpwZEhrZ0tESXdKU2tnTFMwdENpQWdJQ0F2THlBaklGQmxibUZzYVhObElHeHZibWNnYVc1aFkzUnBkbWwwZVM0Z1JuVnNiQ0J6WTI5eVpTQnBaaUJoWTNScGRtVWdhVzRnYkdGemRDQXhORFF3SUdKc2IyTnJjeTRLSUNBZ0lDOHZJQ01nVTJOdmNtVWdaR1ZqWVhseklHeHBibVZoY214NUlIUnZJREFnWVhRZ1JFVkRRVmxmU0VGTVJsOU1TVVpGWDBSQldWTWdLaUJDVEU5RFMxTmZVRVZTWDFORFQxSkpUa2RmUkVGWkxnb2dJQ0FnTHk4Z1lteHZZMnR6WDNOcGJtTmxYMkZqZEdsMmFYUjVJRDBnWTNWeWNtVnVkRjlpYkc5amF5QXRJSEpsWTI5eVpDNXNZWE4wWDNWd1pHRjBaVjlpYkc5amF5NXVZWFJwZG1VS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdsdWRDQTBNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2MzZGhjQW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qWTNNUW9nSUNBZ0x5OGdiV0Y0WDJsa2JHVWdQU0JWU1c1ME5qUW9SRVZEUVZsZlNFRk1SbDlNU1VaRlgwUkJXVk1nS2lCQ1RFOURTMU5mVUVWU1gxTkRUMUpKVGtkZlJFRlpLUW9nSUNBZ2FXNTBZeUEzSUM4dklERXdNRGd3TUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5qY3lDaUFnSUNBdkx5QnBaaUJpYkc5amEzTmZjMmx1WTJWZllXTjBhWFpwZEhrZ1BqMGdiV0Y0WDJsa2JHVTZDaUFnSUNBK1BRb2dJQ0FnWW5vZ1gyTnZiWEIxZEdWZmMyTnZjbVZmWld4elpWOWliMlI1UURZS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qWTNNd29nSUNBZ0x5OGdjek1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRGNLQ2w5amIyMXdkWFJsWDNOamIzSmxYMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPalkzTnkwMk56Z0tJQ0FnSUM4dklDTWdRV1JrYVhScGIyNWhiR3g1SUdaaFkzUnZjaUJwYmlCMGFXMWxMWGRsYVdkb2RHVmtJSFp2YkhWdFpTQm1iM0lnWVdkbGJuUnpJSGRwZEdnZ2NtVmhiQ0JvYVhOMGIzSjVDaUFnSUNBdkx5QnBaaUJ5WldOdmNtUXVkR2x0WlY5M1pXbG5hSFJsWkY5MmIyeDFiV1V1Ym1GMGFYWmxJRDRnVlVsdWREWTBLREFwSUdGdVpDQnlaV052Y21RdWRHOTBZV3hmZG05c2RXMWxMbTVoZEdsMlpTQStJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR2x1ZENBek5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeE1Bb2dJQ0FnWW5vZ1gyTnZiWEIxZEdWZmMyTnZjbVZmWVdaMFpYSmZhV1pmWld4elpVQXhNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9hVzUwSURFNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFeENpQWdJQ0JpZWlCZlkyOXRjSFYwWlY5elkyOXlaVjloWm5SbGNsOXBabDlsYkhObFFERXlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8yTnprS0lDQWdJQzh2SUhSM1gzSmhkR2x2SUQwZ0tISmxZMjl5WkM1MGFXMWxYM2RsYVdkb2RHVmtYM1p2YkhWdFpTNXVZWFJwZG1VZ0tpQlZTVzUwTmpRb01UQXdLU2tnTHk4Z0tBb2dJQ0FnWm5KaGJXVmZaR2xuSURFd0NpQWdJQ0JwYm5Salh6TWdMeThnTVRBd0NpQWdJQ0FxQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvMk9EQUtJQ0FnSUM4dklISmxZMjl5WkM1MGIzUmhiRjkyYjJ4MWJXVXVibUYwYVhabElDb2dWVWx1ZERZMEtERXdNREFwSUNzZ1ZVbHVkRFkwS0RFcENpQWdJQ0JtY21GdFpWOWthV2NnTVRFS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TURBd0NpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOamM1TFRZNE1Rb2dJQ0FnTHk4Z2RIZGZjbUYwYVc4Z1BTQW9jbVZqYjNKa0xuUnBiV1ZmZDJWcFoyaDBaV1JmZG05c2RXMWxMbTVoZEdsMlpTQXFJRlZKYm5RMk5DZ3hNREFwS1NBdkx5QW9DaUFnSUNBdkx5QWdJQ0FnY21WamIzSmtMblJ2ZEdGc1gzWnZiSFZ0WlM1dVlYUnBkbVVnS2lCVlNXNTBOalFvTVRBd01Da2dLeUJWU1c1ME5qUW9NU2tLSUNBZ0lDOHZJQ2tLSUNBZ0lDOEtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeE5Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOamd5Q2lBZ0lDQXZMeUJwWmlCMGQxOXlZWFJwYnlBK0lGVkpiblEyTkNneE1EQXBPZ29nSUNBZ2FXNTBZMTh6SUM4dklERXdNQW9nSUNBZ1Bnb2dJQ0FnWW5vZ1gyTnZiWEIxZEdWZmMyTnZjbVZmWVdaMFpYSmZhV1pmWld4elpVQXhNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TmpnekNpQWdJQ0F2THlCMGQxOXlZWFJwYnlBOUlGVkpiblEyTkNneE1EQXBDaUFnSUNCcGJuUmpYek1nTHk4Z01UQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlERTBDZ3BmWTI5dGNIVjBaVjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURFeE9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOamcwTFRZNE5Rb2dJQ0FnTHk4Z0l5QkNiR1Z1WkRvZ056QWxJSEpsWTJWdVkza2djMk52Y21VZ0t5QXpNQ1VnZG05c2RXMWxJR052Ym5OcGMzUmxibU41Q2lBZ0lDQXZMeUJ6TXlBOUlDaHpNeUFxSUZWSmJuUTJOQ2czTUNrZ0t5QjBkMTl5WVhScGJ5QXFJRlZKYm5RMk5DZ3pNQ2twSUM4dklGVkpiblEyTkNneE1EQXBDaUFnSUNCbWNtRnRaVjlrYVdjZ053b2dJQ0FnY0hWemFHbHVkQ0EzTUFvZ0lDQWdLZ29nSUNBZ1puSmhiV1ZmWkdsbklERTBDaUFnSUNCd2RYTm9hVzUwSURNd0NpQWdJQ0FxQ2lBZ0lDQXJDaUFnSUNCcGJuUmpYek1nTHk4Z01UQXdDaUFnSUNBdkNpQWdJQ0JtY21GdFpWOWlkWEo1SURjS0NsOWpiMjF3ZFhSbFgzTmpiM0psWDJGbWRHVnlYMmxtWDJWc2MyVkFNVEk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvMk9URUtJQ0FnSUM4dklHVnpJRDBnY21WamIzSmtMbVZ1Wkc5eWMyVnRaVzUwWDNOamIzSmxMbTVoZEdsMlpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J3ZFhOb2FXNTBJRFkyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pZNE55MDJPVEFLSUNBZ0lDOHZJQ01nTFMwdElGTnBaMjVoYkNBME9pQlRkR0ZyWlMxWFpXbG5hSFJsWkNCRmJtUnZjbk5sYldWdWRDQW9NakFsS1NBdExTMEtJQ0FnSUM4dklDTWdaVzVrYjNKelpXMWxiblJmYzJOdmNtVWdjM1J2Y21Wa0lHRnpJSE4xYlNoemRHRnJaU0FxSUdWdVpHOXljMlZ5WDNOamIzSmxJQzhnTVRBd0tRb2dJQ0FnTHk4Z0l5Qk9iM0p0WVd4cGVtVWdkRzhnTU9LQWt6RXdNRG9nWTJGd0lHRjBJREV3TUY4d01EQmZNREF3SUNnOUlERXdNREFnUVV4SFR5RERseUJ6WTI5eVpTQXhNREFwQ2lBZ0lDQXZMeUJ0WVhoZlpXNWtiM0p6WlcxbGJuUWdQU0JWU1c1ME5qUW9NVEF3WHpBd01GOHdNREJmTURBd0tTQWdJeUF4TURBc01EQXdJRUZNUjA4Z1lYUWdiV0Y0SUhOamIzSmxDaUFnSUNCcGJuUmpJRGtnTHk4Z01UQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8yT1RJS0lDQWdJQzh2SUdsbUlHVnpJRDQ5SUcxaGVGOWxibVJ2Y25ObGJXVnVkRG9LSUNBZ0lENDlDaUFnSUNCaWVpQmZZMjl0Y0hWMFpWOXpZMjl5WlY5bGJITmxYMkp2WkhsQU1UUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPalk1TXdvZ0lDQWdMeThnY3pRZ1BTQlZTVzUwTmpRb01UQXdLUW9nSUNBZ2FXNTBZMTh6SUM4dklERXdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTRDZ3BmWTI5dGNIVjBaVjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURFMU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOamszTFRZNU9Rb2dJQ0FnTHk4Z0l5QXRMUzBnVTJsbmJtRnNJRFU2SUVScGMzQjFkR1VnVW1GMGFXOGdLREV3SlNrZ0xTMHRDaUFnSUNBdkx5QWpJRk5qYjNKbElHUmxZM0psWVhObGN5QndjbTl3YjNKMGFXOXVZV3hzZVNCM2FYUm9JR1JwYzNCMWRHVWdjbUYwWlFvZ0lDQWdMeThnY3pVZ1BTQlZTVzUwTmpRb01UQXdLUW9nSUNBZ2FXNTBZMTh6SUM4dklERXdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTVDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8zTURBS0lDQWdJQzh2SUdsbUlISmxZMjl5WkM1a2FYTndkWFJsWDJOdmRXNTBMbTVoZEdsMlpTQStJRlZKYm5RMk5DZ3dLU0JoYm1RZ2NtVmpiM0prTG5ObGRIUnNaVzFsYm5SZlkyOTFiblF1Ym1GMGFYWmxJRDRnVlVsdWREWTBLREFwT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQndkWE5vYVc1MElEYzBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlERXlDaUFnSUNCaWVpQmZZMjl0Y0hWMFpWOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRREl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVFVLSUNBZ0lHSjZJRjlqYjIxd2RYUmxYM05qYjNKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qY3dNUzAzTURJS0lDQWdJQzh2SUNNZ1VuVnNaU0JDT2lCa2FYTndkWFJsSUhkbGFXZG9kQ0E5SUdScGMzQjFkR1ZmWVcxdmRXNTBJQzhnZEc5MFlXeGZkbTlzZFcxbElDaGpZWEJ3WldRZ1lYUWdNU2tLSUNBZ0lDOHZJR1JwYzNCMWRHVmZjbUYwYVc4Z1BTQW9jbVZqYjNKa0xtUnBjM0IxZEdWZmRtOXNkVzFsTG01aGRHbDJaU0FxSUZWSmJuUTJOQ2d4TURBcEtTQXZMeUFvQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIQjFjMmhwYm5RZ09ESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYek1nTHk4Z01UQXdDaUFnSUNBcUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzNNRE1LSUNBZ0lDOHZJSEpsWTI5eVpDNTBiM1JoYkY5MmIyeDFiV1V1Ym1GMGFYWmxJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIQjFjMmhwYm5RZ01UZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk56QXhMVGN3TkFvZ0lDQWdMeThnSXlCU2RXeGxJRUk2SUdScGMzQjFkR1VnZDJWcFoyaDBJRDBnWkdsemNIVjBaVjloYlc5MWJuUWdMeUIwYjNSaGJGOTJiMngxYldVZ0tHTmhjSEJsWkNCaGRDQXhLUW9nSUNBZ0x5OGdaR2x6Y0hWMFpWOXlZWFJwYnlBOUlDaHlaV052Y21RdVpHbHpjSFYwWlY5MmIyeDFiV1V1Ym1GMGFYWmxJQ29nVlVsdWREWTBLREV3TUNrcElDOHZJQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTnZjbVF1ZEc5MFlXeGZkbTlzZFcxbExtNWhkR2wyWlNBcklGVkpiblEyTkNneEtRb2dJQ0FnTHk4Z0tRb2dJQ0FnTHdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pjd05Rb2dJQ0FnTHk4Z2FXWWdaR2x6Y0hWMFpWOXlZWFJwYnlBK0lGVkpiblEyTkNneE1EQXBPZ29nSUNBZ2FXNTBZMTh6SUM4dklERXdNQW9nSUNBZ1Bnb2dJQ0FnWW5vZ1gyTnZiWEIxZEdWZmMyTnZjbVZmWVdaMFpYSmZhV1pmWld4elpVQXhPUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TnpBMkNpQWdJQ0F2THlCa2FYTndkWFJsWDNKaGRHbHZJRDBnVlVsdWREWTBLREV3TUNrS0lDQWdJR2x1ZEdOZk15QXZMeUF4TURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvS1gyTnZiWEIxZEdWZmMyTnZjbVZmWVdaMFpYSmZhV1pmWld4elpVQXhPVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pjd053b2dJQ0FnTHk4Z2N6VWdQU0JWU1c1ME5qUW9NVEF3S1NBdElHUnBjM0IxZEdWZmNtRjBhVzhLSUNBZ0lHbHVkR05mTXlBdkx5QXhNREFLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNBdENpQWdJQ0JtY21GdFpWOWlkWEo1SURrS0NsOWpiMjF3ZFhSbFgzTmpiM0psWDJGbWRHVnlYMmxtWDJWc2MyVkFNakE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvM01Ea3ROekV3Q2lBZ0lDQXZMeUFqSUVkbGJtVnphWE1nYzJOdmNtVWdZMjl1ZEhKcFluVjBhVzl1SUNoa1pXTmhlWE1nYjNabGNpQkhSVTVGVTBsVFgwUkZRMEZaWDBKTVQwTkxVeWtLSUNBZ0lDOHZJR2RsYm1WemFYTmZZbTl1ZFhNZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qY3hNUW9nSUNBZ0x5OGdhV1lnY21WamIzSmtMbWRsYm1WemFYTmZjMk52Y21VdWJtRjBhWFpsSUQ0Z1ZVbHVkRFkwS0RBcElHRnVaQ0J5WldOdmNtUXVaMlZ1WlhOcGMxOWxlSEJwY25sZllteHZZMnN1Ym1GMGFYWmxJRDRnWTNWeWNtVnVkRjlpYkc5amF6b0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHbHVkQ0F4TURjS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTlFvZ0lDQWdZbm9nWDJOdmJYQjFkR1ZmYzJOdmNtVmZZV1owWlhKZmFXWmZaV3h6WlVBeU5Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J3ZFhOb2FXNTBJREV4TlFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F4TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQStDaUFnSUNCaWVpQmZZMjl0Y0hWMFpWOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRREkxQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvM01USUtJQ0FnSUM4dklHSnNiMk5yYzE5c1pXWjBJRDBnY21WamIzSmtMbWRsYm1WemFYTmZaWGh3YVhKNVgySnNiMk5yTG01aGRHbDJaU0F0SUdOMWNuSmxiblJmWW14dlkyc0tJQ0FnSUdaeVlXMWxYMlJwWnlBeE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvM01UTUtJQ0FnSUM4dklHZGxibVZ6YVhOZlltOXVkWE1nUFNBb2NtVmpiM0prTG1kbGJtVnphWE5mYzJOdmNtVXVibUYwYVhabElDb2dZbXh2WTJ0elgyeGxablFwSUM4dklGVkpiblEyTkNoSFJVNUZVMGxUWDBSRlEwRlpYMEpNVDBOTFV5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0tnb2dJQ0FnYVc1MFl5QTRJQzh2SURJd01EQXdNQW9nSUNBZ0x3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qY3hOQW9nSUNBZ0x5OGdhV1lnWjJWdVpYTnBjMTlpYjI1MWN5QStJSEpsWTI5eVpDNW5aVzVsYzJselgzTmpiM0psTG01aGRHbDJaVG9LSUNBZ0lEd0tJQ0FnSUdKNklGOWpiMjF3ZFhSbFgzTmpiM0psWDJGbWRHVnlYMmxtWDJWc2MyVkFNalVLSUNBZ0lHWnlZVzFsWDJScFp5QTFDaUFnSUNCbWNtRnRaVjlpZFhKNUlEUUtDbDlqYjIxd2RYUmxYM05qYjNKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpVNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzNNVGtLSUNBZ0lDOHZJSE14SUNvZ1ZVbHVkRFkwS0ZkRlNVZElWRjlHU1U1QlRFbFVXU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXhOd29nSUNBZ2NIVnphR2x1ZENBeU5Rb2dJQ0FnS2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk56SXdDaUFnSUNBdkx5QXJJSE15SUNvZ1ZVbHVkRFkwS0ZkRlNVZElWRjlFU1ZaRlVsTkpWRmtwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOZ29nSUNBZ2NIVnphR2x1ZENBeU1Bb2dJQ0FnS2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk56RTVMVGN5TUFvZ0lDQWdMeThnY3pFZ0tpQlZTVzUwTmpRb1YwVkpSMGhVWDBaSlRrRk1TVlJaS1FvZ0lDQWdMeThnS3lCek1pQXFJRlZKYm5RMk5DaFhSVWxIU0ZSZlJFbFdSVkpUU1ZSWktRb2dJQ0FnS3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk56SXhDaUFnSUNBdkx5QXJJSE16SUNvZ1ZVbHVkRFkwS0ZkRlNVZElWRjlFUlVOQldTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBM0NpQWdJQ0J3ZFhOb2FXNTBJREl3Q2lBZ0lDQXFDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8zTVRrdE56SXhDaUFnSUNBdkx5QnpNU0FxSUZWSmJuUTJOQ2hYUlVsSFNGUmZSa2xPUVV4SlZGa3BDaUFnSUNBdkx5QXJJSE15SUNvZ1ZVbHVkRFkwS0ZkRlNVZElWRjlFU1ZaRlVsTkpWRmtwQ2lBZ0lDQXZMeUFySUhNeklDb2dWVWx1ZERZMEtGZEZTVWRJVkY5RVJVTkJXU2tLSUNBZ0lDc0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPamN5TWdvZ0lDQWdMeThnS3lCek5DQXFJRlZKYm5RMk5DaFhSVWxIU0ZSZlJVNUVUMUpUUlUxRlRsUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ09Bb2dJQ0FnY0hWemFHbHVkQ0F5TUFvZ0lDQWdLZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TnpFNUxUY3lNZ29nSUNBZ0x5OGdjekVnS2lCVlNXNTBOalFvVjBWSlIwaFVYMFpKVGtGTVNWUlpLUW9nSUNBZ0x5OGdLeUJ6TWlBcUlGVkpiblEyTkNoWFJVbEhTRlJmUkVsV1JWSlRTVlJaS1FvZ0lDQWdMeThnS3lCek15QXFJRlZKYm5RMk5DaFhSVWxIU0ZSZlJFVkRRVmtwQ2lBZ0lDQXZMeUFySUhNMElDb2dWVWx1ZERZMEtGZEZTVWRJVkY5RlRrUlBVbE5GVFVWT1ZDa0tJQ0FnSUNzS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qY3lNd29nSUNBZ0x5OGdLeUJ6TlNBcUlGVkpiblEyTkNoWFJVbEhTRlJmUkVsVFVGVlVSU2tLSUNBZ0lHWnlZVzFsWDJScFp5QTVDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0FxQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvM01Ua3ROekl6Q2lBZ0lDQXZMeUJ6TVNBcUlGVkpiblEyTkNoWFJVbEhTRlJmUmtsT1FVeEpWRmtwQ2lBZ0lDQXZMeUFySUhNeUlDb2dWVWx1ZERZMEtGZEZTVWRJVkY5RVNWWkZVbE5KVkZrcENpQWdJQ0F2THlBcklITXpJQ29nVlVsdWREWTBLRmRGU1VkSVZGOUVSVU5CV1NrS0lDQWdJQzh2SUNzZ2N6UWdLaUJWU1c1ME5qUW9WMFZKUjBoVVgwVk9SRTlTVTBWTlJVNVVLUW9nSUNBZ0x5OGdLeUJ6TlNBcUlGVkpiblEyTkNoWFJVbEhTRlJmUkVsVFVGVlVSU2tLSUNBZ0lDc0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPamN5TkFvZ0lDQWdMeThnS1NBdkx5QlZTVzUwTmpRb01UQXdLUW9nSUNBZ2FXNTBZMTh6SUM4dklERXdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TnpFM0xUY3lOQW9nSUNBZ0x5OGdJeUF0TFMwZ1YyVnBaMmgwWldRZ2MzVnRJQzB0TFFvZ0lDQWdMeThnZDJWcFoyaDBaV1FnUFNBb0NpQWdJQ0F2THlBZ0lDQWdjekVnS2lCVlNXNTBOalFvVjBWSlIwaFVYMFpKVGtGTVNWUlpLUW9nSUNBZ0x5OGdJQ0FnSUNzZ2N6SWdLaUJWU1c1ME5qUW9WMFZKUjBoVVgwUkpWa1ZTVTBsVVdTa0tJQ0FnSUM4dklDQWdJQ0FySUhNeklDb2dWVWx1ZERZMEtGZEZTVWRJVkY5RVJVTkJXU2tLSUNBZ0lDOHZJQ0FnSUNBcklITTBJQ29nVlVsdWREWTBLRmRGU1VkSVZGOUZUa1JQVWxORlRVVk9WQ2tLSUNBZ0lDOHZJQ0FnSUNBcklITTFJQ29nVlVsdWREWTBLRmRGU1VkSVZGOUVTVk5RVlZSRktRb2dJQ0FnTHk4Z0tTQXZMeUJWU1c1ME5qUW9NVEF3S1FvZ0lDQWdMd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TnpJMkxUY3lOd29nSUNBZ0x5OGdJeUJCWkdRZ1oyVnVaWE5wY3lCaWIyNTFjeUFvWVdSa2FYUnBkbVVzSUhWd0lIUnZJR2wwY3lCa1pXTnNZWEpsWkNCMllXeDFaU2tLSUNBZ0lDOHZJR1pwYm1Gc1gzTmpiM0psSUQwZ2QyVnBaMmgwWldRZ0t5Qm5aVzVsYzJselgySnZiblZ6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzNNamt0TnpNd0NpQWdJQ0F2THlBaklGQmxibUZzZEhrNklPS0lrakUxSUhCbGNpQjFjR2hsYkdRZ1pHbHpjSFYwWlNCbWJHRm5DaUFnSUNBdkx5QnBaaUJ5WldOdmNtUXVaR2x6Y0hWMFpWOWpiM1Z1ZEM1dVlYUnBkbVVnUGlCVlNXNTBOalFvTUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTVRJS0lDQWdJR0o2SUY5amIyMXdkWFJsWDNOamIzSmxYMkZtZEdWeVgybG1YMlZzYzJWQU16SUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPamN6TVFvZ0lDQWdMeThnWkdsemNIVjBaVjl5WVhScGIxOWphR1ZqYXlBOUlDaHlaV052Y21RdVpHbHpjSFYwWlY5amIzVnVkQzV1WVhScGRtVWdLaUJWU1c1ME5qUW9NVEF3S1NrZ0x5OGdLQW9nSUNBZ1puSmhiV1ZmWkdsbklERXlDaUFnSUNCcGJuUmpYek1nTHk4Z01UQXdDaUFnSUNBcUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzNNekV0TnpNekNpQWdJQ0F2THlCa2FYTndkWFJsWDNKaGRHbHZYMk5vWldOcklEMGdLSEpsWTI5eVpDNWthWE53ZFhSbFgyTnZkVzUwTG01aGRHbDJaU0FxSUZWSmJuUTJOQ2d4TURBcEtTQXZMeUFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpiM0prTG5ObGRIUnNaVzFsYm5SZlkyOTFiblF1Ym1GMGFYWmxJQ3NnVlVsdWREWTBLREVwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVFlLSUNBZ0lDOEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPamN6TkFvZ0lDQWdMeThnYVdZZ1pHbHpjSFYwWlY5eVlYUnBiMTlqYUdWamF5QStJRlZKYm5RMk5DZ3hNQ2s2SUNBaklENGdNVEFsSUdScGMzQjFkR1VnY21GMFpRb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdQZ29nSUNBZ1lub2dYMk52YlhCMWRHVmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUF6TWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk56TTJDaUFnSUNBdkx5QnBaaUJtYVc1aGJGOXpZMjl5WlNBK0lIQmxibUZzZEhrNkNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk56TTFDaUFnSUNBdkx5QndaVzVoYkhSNUlEMGdWVWx1ZERZMEtFUkpVMUJWVkVWZlVFVk9RVXhVV1Y5UVQwbE9WRk1wQ2lBZ0lDQndkWE5vYVc1MElERTFDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8zTXpZS0lDQWdJQzh2SUdsbUlHWnBibUZzWDNOamIzSmxJRDRnY0dWdVlXeDBlVG9LSUNBZ0lENEtJQ0FnSUdKNklGOWpiMjF3ZFhSbFgzTmpiM0psWDJWc2MyVmZZbTlrZVVBeU9Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOek0zQ2lBZ0lDQXZMeUJtYVc1aGJGOXpZMjl5WlNBOUlHWnBibUZzWDNOamIzSmxJQzBnY0dWdVlXeDBlUW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPamN6TlFvZ0lDQWdMeThnY0dWdVlXeDBlU0E5SUZWSmJuUTJOQ2hFU1ZOUVZWUkZYMUJGVGtGTVZGbGZVRTlKVGxSVEtRb2dJQ0FnY0hWemFHbHVkQ0F4TlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk56TTNDaUFnSUNBdkx5Qm1hVzVoYkY5elkyOXlaU0E5SUdacGJtRnNYM05qYjNKbElDMGdjR1Z1WVd4MGVRb2dJQ0FnTFFvZ0lDQWdabkpoYldWZlluVnllU0F6Q2dwZlkyOXRjSFYwWlY5elkyOXlaVjloWm5SbGNsOXBabDlsYkhObFFETXlPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TnpReExUYzBNZ29nSUNBZ0x5OGdJeUJUWVc1a1ltOTRJR05sY25ScFptbGpZWFJwYjI0Z1ltOXVkWE02SUNzMUlIQnZhVzUwY3dvZ0lDQWdMeThnYVdZZ2NtVmpiM0prTG5OaGJtUmliM2hmWTJWeWRHbG1hV1ZrTG01aGRHbDJaVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZeUEySUM4dklEZzBPQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lub2dYMk52YlhCMWRHVmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUF6TkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk56UXpDaUFnSUNBdkx5Qm1hVzVoYkY5elkyOXlaU0E5SUdacGJtRnNYM05qYjNKbElDc2dWVWx1ZERZMEtEVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnY0hWemFHbHVkQ0ExQ2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtDbDlqYjIxd2RYUmxYM05qYjNKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpRNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzNORFV0TnpRMkNpQWdJQ0F2THlBaklFaGhjbVFnWTJGd0NpQWdJQ0F2THlCcFppQm1hVzVoYkY5elkyOXlaU0ErSUZWSmJuUTJOQ2hOUVZoZlUwTlBVa1VwT2dvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHbHVkR05mTXlBdkx5QXhNREFLSUNBZ0lENEtJQ0FnSUdKNklGOWpiMjF3ZFhSbFgzTmpiM0psWDJGbWRHVnlYMmxtWDJWc2MyVkFNellLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pjME53b2dJQ0FnTHk4Z1ptbHVZV3hmYzJOdmNtVWdQU0JWU1c1ME5qUW9UVUZZWDFORFQxSkZLUW9nSUNBZ2FXNTBZMTh6SUM4dklERXdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDZ3BmWTI5dGNIVjBaVjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURNMk9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOelE1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdabWx1WVd4ZmMyTnZjbVVzSUhNeExDQnpNaXdnY3pNc0lITTBMQ0J6TlFvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXhOd29nSUNBZ1puSmhiV1ZmWkdsbklEWUtJQ0FnSUdaeVlXMWxYMlJwWnlBM0NpQWdJQ0JtY21GdFpWOWthV2NnT0FvZ0lDQWdabkpoYldWZlpHbG5JRGtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQTJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEVUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBekNpQWdJQ0JtY21GdFpWOWlkWEo1SURJS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NsOWpiMjF3ZFhSbFgzTmpiM0psWDJWc2MyVmZZbTlrZVVBeU9Ub0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPamN6T1FvZ0lDQWdMeThnWm1sdVlXeGZjMk52Y21VZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJR0lnWDJOdmJYQjFkR1ZmYzJOdmNtVmZZV1owWlhKZmFXWmZaV3h6WlVBek1nb0tYMk52YlhCMWRHVmZjMk52Y21WZlpXeHpaVjlpYjJSNVFERTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TmprMUNpQWdJQ0F2THlCek5DQTlJQ2hsY3lBcUlGVkpiblEyTkNneE1EQXBLU0F2THlCdFlYaGZaVzVrYjNKelpXMWxiblFLSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCcGJuUmpYek1nTHk4Z01UQXdDaUFnSUNBcUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzJPRGN0Tmprd0NpQWdJQ0F2THlBaklDMHRMU0JUYVdkdVlXd2dORG9nVTNSaGEyVXRWMlZwWjJoMFpXUWdSVzVrYjNKelpXMWxiblFnS0RJd0pTa2dMUzB0Q2lBZ0lDQXZMeUFqSUdWdVpHOXljMlZ0Wlc1MFgzTmpiM0psSUhOMGIzSmxaQ0JoY3lCemRXMG9jM1JoYTJVZ0tpQmxibVJ2Y25ObGNsOXpZMjl5WlNBdklERXdNQ2tLSUNBZ0lDOHZJQ01nVG05eWJXRnNhWHBsSUhSdklERGlnSk14TURBNklHTmhjQ0JoZENBeE1EQmZNREF3WHpBd01DQW9QU0F4TURBd0lFRk1SMDhndzVjZ2MyTnZjbVVnTVRBd0tRb2dJQ0FnTHk4Z2JXRjRYMlZ1Wkc5eWMyVnRaVzUwSUQwZ1ZVbHVkRFkwS0RFd01GOHdNREJmTURBd1h6QXdNQ2tnSUNNZ01UQXdMREF3TUNCQlRFZFBJR0YwSUcxaGVDQnpZMjl5WlFvZ0lDQWdhVzUwWXlBNUlDOHZJREV3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5qazFDaUFnSUNBdkx5QnpOQ0E5SUNobGN5QXFJRlZKYm5RMk5DZ3hNREFwS1NBdkx5QnRZWGhmWlc1a2IzSnpaVzFsYm5RS0lDQWdJQzhLSUNBZ0lHWnlZVzFsWDJKMWNua2dPQW9nSUNBZ1lpQmZZMjl0Y0hWMFpWOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRREUxQ2dwZlkyOXRjSFYwWlY5elkyOXlaVjlsYkhObFgySnZaSGxBTmpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qWTNNUW9nSUNBZ0x5OGdiV0Y0WDJsa2JHVWdQU0JWU1c1ME5qUW9SRVZEUVZsZlNFRk1SbDlNU1VaRlgwUkJXVk1nS2lCQ1RFOURTMU5mVUVWU1gxTkRUMUpKVGtkZlJFRlpLUW9nSUNBZ2FXNTBZeUEzSUM4dklERXdNRGd3TUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5qYzFDaUFnSUNBdkx5QnpNeUE5SUNnb2JXRjRYMmxrYkdVZ0xTQmliRzlqYTNOZmMybHVZMlZmWVdOMGFYWnBkSGtwSUNvZ1ZVbHVkRFkwS0RFd01Da3BJQzh2SUcxaGVGOXBaR3hsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ0xRb2dJQ0FnYVc1MFkxOHpJQzh2SURFd01Bb2dJQ0FnS2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5qY3hDaUFnSUNBdkx5QnRZWGhmYVdSc1pTQTlJRlZKYm5RMk5DaEVSVU5CV1Y5SVFVeEdYMHhKUmtWZlJFRlpVeUFxSUVKTVQwTkxVMTlRUlZKZlUwTlBVa2xPUjE5RVFWa3BDaUFnSUNCcGJuUmpJRGNnTHk4Z01UQXdPREF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvMk56VUtJQ0FnSUM4dklITXpJRDBnS0NodFlYaGZhV1JzWlNBdElHSnNiMk5yYzE5emFXNWpaVjloWTNScGRtbDBlU2tnS2lCVlNXNTBOalFvTVRBd0tTa2dMeThnYldGNFgybGtiR1VLSUNBZ0lDOEtJQ0FnSUdaeVlXMWxYMkoxY25rZ053b2dJQ0FnWWlCZlkyOXRjSFYwWlY5elkyOXlaVjloWm5SbGNsOXBabDlsYkhObFFEY0tDbDlqYjIxd2RYUmxYM05qYjNKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXprNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzRNalFLSUNBZ0lDOHZJR2xtSUc0Z1BDQlZTVzUwTmpRb05DazZDaUFnSUNCbWNtRnRaVjlrYVdjZ01UZ0tJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdQQW9nSUNBZ1lub2dYMk52YlhCMWRHVmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUEwTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk9ESTFDaUFnSUNBdkx5QnlaWFIxY200Z1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk5qWXlMVFkyTXdvZ0lDQWdMeThnSXlCSmJuUmxaMlZ5SUhOeGNuUWdZWEJ3Y205NGFXMWhkR2x2YmpvZ2FYTnhjblFvZUNrZ2RtbGhJRTVsZDNSdmJpZHpJRzFsZEdodlpBb2dJQ0FnTHk4Z2N6SWdQU0J6Wld4bUxsOXBjM0Z5ZENoMWJtbHhkV1VwSUNvZ1ZVbHVkRFkwS0RFd0tRb2dJQ0FnWWlCZlkyOXRjSFYwWlY5elkyOXlaVjloWm5SbGNsOXBibXhwYm1Wa1gyRm5aVzUwYVdRdVFXZGxiblJKUkVOdmJuUnlZV04wTGw5cGMzRnlkRUEwTWdvS1gyTnZiWEIxZEdWZmMyTnZjbVZmWVdaMFpYSmZhV1pmWld4elpVQTBNVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pneU5pMDRNamNLSUNBZ0lDOHZJQ01nU1c1cGRHbGhiQ0JsYzNScGJXRjBaUW9nSUNBZ0x5OGdlQ0E5SUc0Z0x5OGdWVWx1ZERZMEtESXBDaUFnSUNCbWNtRnRaVjlrYVdjZ01UZ0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG80TWpndE9ESTVDaUFnSUNBdkx5QWpJRGdnYVhSbGNtRjBhVzl1Y3lCcGN5QnpkV1ptYVdOcFpXNTBJR1p2Y2lCMllXeDFaWE1nZFhBZ2RHOGdmakZsTVRnS0lDQWdJQzh2SUhnZ1BTQW9lQ0FySUc0Z0x5OGdlQ2tnTHk4Z1ZVbHVkRFkwS0RJcENpQWdJQ0JrZFhBeUNpQWdJQ0F2Q2lBZ0lDQXJDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQzhLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pnek1Bb2dJQ0FnTHk4Z2VDQTlJQ2g0SUNzZ2JpQXZMeUI0S1NBdkx5QlZTVzUwTmpRb01pa0tJQ0FnSUdSMWNESUtJQ0FnSUM4S0lDQWdJQ3NLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnTHdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk9ETXhDaUFnSUNBdkx5QjRJRDBnS0hnZ0t5QnVJQzh2SUhncElDOHZJRlZKYm5RMk5DZ3lLUW9nSUNBZ1pIVndNZ29nSUNBZ0x3b2dJQ0FnS3dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBdkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzRNeklLSUNBZ0lDOHZJSGdnUFNBb2VDQXJJRzRnTHk4Z2VDa2dMeThnVlVsdWREWTBLRElwQ2lBZ0lDQmtkWEF5Q2lBZ0lDQXZDaUFnSUNBckNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDOEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPamd6TXdvZ0lDQWdMeThnZUNBOUlDaDRJQ3NnYmlBdkx5QjRLU0F2THlCVlNXNTBOalFvTWlrS0lDQWdJR1IxY0RJS0lDQWdJQzhLSUNBZ0lDc0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdMd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2T0RNMENpQWdJQ0F2THlCNElEMGdLSGdnS3lCdUlDOHZJSGdwSUM4dklGVkpiblEyTkNneUtRb2dJQ0FnWkhWd01nb2dJQ0FnTHdvZ0lDQWdLd29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0F2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvNE16VUtJQ0FnSUM4dklIZ2dQU0FvZUNBcklHNGdMeThnZUNrZ0x5OGdWVWx1ZERZMEtESXBDaUFnSUNCa2RYQXlDaUFnSUNBdkNpQWdJQ0FyQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUM4S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qZ3pOZ29nSUNBZ0x5OGdlQ0E5SUNoNElDc2diaUF2THlCNEtTQXZMeUJWU1c1ME5qUW9NaWtLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXZDaUFnSUNBckNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDOEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPalkyTWkwMk5qTUtJQ0FnSUM4dklDTWdTVzUwWldkbGNpQnpjWEowSUdGd2NISnZlR2x0WVhScGIyNDZJR2x6Y1hKMEtIZ3BJSFpwWVNCT1pYZDBiMjRuY3lCdFpYUm9iMlFLSUNBZ0lDOHZJSE15SUQwZ2MyVnNaaTVmYVhOeGNuUW9kVzVwY1hWbEtTQXFJRlZKYm5RMk5DZ3hNQ2tLSUNBZ0lHSWdYMk52YlhCMWRHVmZjMk52Y21WZllXWjBaWEpmYVc1c2FXNWxaRjloWjJWdWRHbGtMa0ZuWlc1MFNVUkRiMjUwY21GamRDNWZhWE54Y25SQU5ESUtDZ292THlCaFoyVnVkR2xrTGtGblpXNTBTVVJEYjI1MGNtRmpkQzVmWW5WcGJHUmZjMk52Y21WZmNtVnpkV3gwS0hKbFkyOXlaRG9nWW5sMFpYTXNJR2x6WDJOaFkyaGxaRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjeXdnWW5sMFpYTTZDbDlpZFdsc1pGOXpZMjl5WlY5eVpYTjFiSFE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvM05URXROelUyQ2lBZ0lDQXZMeUJBYzNWaWNtOTFkR2x1WlFvZ0lDQWdMeThnWkdWbUlGOWlkV2xzWkY5elkyOXlaVjl5WlhOMWJIUW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd0tJQ0FnSUM4dklDQWdJQ0J5WldOdmNtUTZJRUZuWlc1MFVtVmpiM0prTEFvZ0lDQWdMeThnSUNBZ0lHbHpYMk5oWTJobFpEb2dZbTl2YkN3S0lDQWdJQzh2SUNrZ0xUNGdVMk52Y21WU1pYTjFiSFE2Q2lBZ0lDQndjbTkwYnlBeUlESUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPamMxT0FvZ0lDQWdMeThnYzJOdmNtVWdQU0J5WldOdmNtUXVZMkZqYUdWa1gzTmpiM0psTG01aGRHbDJaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbGVIUnlZV04wSURFeU15QTRDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhCMWMyaHBiblFnTVRJekNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzNPVEFLSUNBZ0lDOHZJR2xtSUhOamIzSmxJRDQ5SUZWSmJuUTJOQ2hVU1VWU1gwVk1TVlJGS1RvS0lDQWdJSEIxYzJocGJuUWdPVFVLSUNBZ0lENDlDaUFnSUNCaWVpQmZZblZwYkdSZmMyTnZjbVZmY21WemRXeDBYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOemt4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtEUXBDaUFnSUNCd2RYTm9hVzUwSURRS0NsOWlkV2xzWkY5elkyOXlaVjl5WlhOMWJIUmZZV1owWlhKZmFXNXNhVzVsWkY5aFoyVnVkR2xrTGtGblpXNTBTVVJEYjI1MGNtRmpkQzVmYzJOdmNtVmZkRzlmZEdsbGNrQXhNam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pjMk1TMDNOaklLSUNBZ0lDOHZJQ01nVW1WamIyMXdkWFJsSUhOcFoyNWhiSE1nWm05eUlHUnBjM0JzWVhrZ0tHTm9aV0Z3SUhOcGJtTmxJR05oWTJobElHbHpJR0ZzY21WaFpIa2djMlYwS1FvZ0lDQWdMeThnWDJacGJtRnNMQ0J6TVN3Z2N6SXNJSE16TENCek5Dd2djelVnUFNCelpXeG1MbDlqYjIxd2RYUmxYM05qYjNKbEtISmxZMjl5WkN3Z1IyeHZZbUZzTG5KdmRXNWtLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbmJHOWlZV3dnVW05MWJtUUtJQ0FnSUdOaGJHeHpkV0lnWDJOdmJYQjFkR1ZmYzJOdmNtVUtJQ0FnSUdaeVlXMWxYMkoxY25rZ0xUSUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk56WTJDaUFnSUNBdkx5QjBhV1Z5UFdGeVl6UXVWVWx1ZERnb2RHbGxjaWtzQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW1sMGJHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdWNGRISmhZM1FnTnlBeENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzNOamNLSUNBZ0lDOHZJSE5wWjI1aGJGOW1hVzVoYkdsMGVUMWhjbU0wTGxWSmJuUTJOQ2h6TVNrc0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzNOamdLSUNBZ0lDOHZJSE5wWjI1aGJGOWthWFpsY25OcGRIazlZWEpqTkM1VlNXNTBOalFvY3pJcExBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvM05qa0tJQ0FnSUM4dklITnBaMjVoYkY5a1pXTmhlVDFoY21NMExsVkpiblEyTkNoek15a3NDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qYzNNQW9nSUNBZ0x5OGdjMmxuYm1Gc1gyVnVaRzl5YzJWdFpXNTBQV0Z5WXpRdVZVbHVkRFkwS0hNMEtTd0tJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk56Y3hDaUFnSUNBdkx5QnphV2R1WVd4ZlpHbHpjSFYwWlQxaGNtTTBMbFZKYm5RMk5DaHpOU2tzQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPamMzTWdvZ0lDQWdMeThnYzJWMGRHeGxiV1Z1ZEY5amIzVnVkRDF5WldOdmNtUXVjMlYwZEd4bGJXVnVkRjlqYjNWdWRDd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWlhoMGNtRmpkQ0F5SURnS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qYzNNd29nSUNBZ0x5OGdaR2x6Y0hWMFpWOWpiM1Z1ZEQxeVpXTnZjbVF1WkdsemNIVjBaVjlqYjNWdWRDd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWlhoMGNtRmpkQ0EzTkNBNENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzNOelFLSUNBZ0lDOHZJSFJ2ZEdGc1gzWnZiSFZ0WlQxeVpXTnZjbVF1ZEc5MFlXeGZkbTlzZFcxbExBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JsZUhSeVlXTjBJREU0SURnS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qYzNOUW9nSUNBZ0x5OGdjM1JoYTJWZllXeG5iejF5WldOdmNtUXVjM1JoYTJWZllXeG5ieXdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1pYaDBjbUZqZENBMU1DQTRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8zTnpZS0lDQWdJQzh2SUhoaGJHZHZYMkpoYkdGdVkyVTljbVZqYjNKa0xuaGhiR2R2WDJKaGJHRnVZMlVzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHVjRkSEpoWTNRZ05UZ2dPQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TnpjM0NpQWdJQ0F2THlCellXNWtZbTk0WDJObGNuUnBabWxsWkQxeVpXTnZjbVF1YzJGdVpHSnZlRjlqWlhKMGFXWnBaV1FzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbHVkR01nTmlBdkx5QTRORGdLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pjM09Bb2dJQ0FnTHk4Z2MyRnVaR0p2ZUY5elkyVnVZWEpwYjNNOWNtVmpiM0prTG5OaGJtUmliM2hmYzJObGJtRnlhVzl6WDNCaGMzTmxaQ3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1pYaDBjbUZqZENBNU9DQTRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8zTnprS0lDQWdJQzh2SUdWMWNtOWZZWFIwWlhOMFpXUTljbVZqYjNKa0xtVjFjbTlmWVhSMFpYTjBaV1FzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIQjFjMmhwYm5RZ09EUTVDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8zT0RBS0lDQWdJQzh2SUdkbGJtVnphWE5mYzJOdmNtVTljbVZqYjNKa0xtZGxibVZ6YVhOZmMyTnZjbVVzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHVjRkSEpoWTNRZ01UQTNJRGdLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTloWjJWdWRHbGtMbkI1T2pjNE1Rb2dJQ0FnTHk4Z1oyVnVaWE5wYzE5bGVIQnBjbmxmWW14dlkyczljbVZqYjNKa0xtZGxibVZ6YVhOZlpYaHdhWEo1WDJKc2IyTnJMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbGVIUnlZV04wSURFeE5TQTRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8zT0RJS0lDQWdJQzh2SUdOaGRYUnBiMjVmWm14aFp6MXlaV052Y21RdVkyRjFkR2x2Ymw5bWJHRm5MQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpJRFVnTHk4Z01URXhNd29nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TnpnekNpQWdJQ0F2THlCcGMxOWpZV05vWldROVlYSmpOQzVDYjI5c0tHbHpYMk5oWTJobFpDa3NDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TnpnMENpQWdJQ0F2THlCc1lYTjBYM1Z3WkdGMFpWOWliRzlqYXoxeVpXTnZjbVF1YkdGemRGOTFjR1JoZEdWZllteHZZMnNzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHVjRkSEpoWTNRZ05ESWdPQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TnpZMExUYzROUW9nSUNBZ0x5OGdjbVYwZFhKdUlGTmpiM0psVW1WemRXeDBLQW9nSUNBZ0x5OGdJQ0FnSUhOamIzSmxQV0Z5WXpRdVZVbHVkRFkwS0hOamIzSmxLU3dLSUNBZ0lDOHZJQ0FnSUNCMGFXVnlQV0Z5WXpRdVZVbHVkRGdvZEdsbGNpa3NDaUFnSUNBdkx5QWdJQ0FnYzJsbmJtRnNYMlpwYm1Gc2FYUjVQV0Z5WXpRdVZVbHVkRFkwS0hNeEtTd0tJQ0FnSUM4dklDQWdJQ0J6YVdkdVlXeGZaR2wyWlhKemFYUjVQV0Z5WXpRdVZVbHVkRFkwS0hNeUtTd0tJQ0FnSUM4dklDQWdJQ0J6YVdkdVlXeGZaR1ZqWVhrOVlYSmpOQzVWU1c1ME5qUW9jek1wTEFvZ0lDQWdMeThnSUNBZ0lITnBaMjVoYkY5bGJtUnZjbk5sYldWdWREMWhjbU0wTGxWSmJuUTJOQ2h6TkNrc0NpQWdJQ0F2THlBZ0lDQWdjMmxuYm1Gc1gyUnBjM0IxZEdVOVlYSmpOQzVWU1c1ME5qUW9jelVwTEFvZ0lDQWdMeThnSUNBZ0lITmxkSFJzWlcxbGJuUmZZMjkxYm5ROWNtVmpiM0prTG5ObGRIUnNaVzFsYm5SZlkyOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1pHbHpjSFYwWlY5amIzVnVkRDF5WldOdmNtUXVaR2x6Y0hWMFpWOWpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5MmIyeDFiV1U5Y21WamIzSmtMblJ2ZEdGc1gzWnZiSFZ0WlN3S0lDQWdJQzh2SUNBZ0lDQnpkR0ZyWlY5aGJHZHZQWEpsWTI5eVpDNXpkR0ZyWlY5aGJHZHZMQW9nSUNBZ0x5OGdJQ0FnSUhoaGJHZHZYMkpoYkdGdVkyVTljbVZqYjNKa0xuaGhiR2R2WDJKaGJHRnVZMlVzQ2lBZ0lDQXZMeUFnSUNBZ2MyRnVaR0p2ZUY5alpYSjBhV1pwWldROWNtVmpiM0prTG5OaGJtUmliM2hmWTJWeWRHbG1hV1ZrTEFvZ0lDQWdMeThnSUNBZ0lITmhibVJpYjNoZmMyTmxibUZ5YVc5elBYSmxZMjl5WkM1ellXNWtZbTk0WDNOalpXNWhjbWx2YzE5d1lYTnpaV1FzQ2lBZ0lDQXZMeUFnSUNBZ1pYVnliMTloZEhSbGMzUmxaRDF5WldOdmNtUXVaWFZ5YjE5aGRIUmxjM1JsWkN3S0lDQWdJQzh2SUNBZ0lDQm5aVzVsYzJselgzTmpiM0psUFhKbFkyOXlaQzVuWlc1bGMybHpYM05qYjNKbExBb2dJQ0FnTHk4Z0lDQWdJR2RsYm1WemFYTmZaWGh3YVhKNVgySnNiMk5yUFhKbFkyOXlaQzVuWlc1bGMybHpYMlY0Y0dseWVWOWliRzlqYXl3S0lDQWdJQzh2SUNBZ0lDQmpZWFYwYVc5dVgyWnNZV2M5Y21WamIzSmtMbU5oZFhScGIyNWZabXhoWnl3S0lDQWdJQzh2SUNBZ0lDQnBjMTlqWVdOb1pXUTlZWEpqTkM1Q2IyOXNLR2x6WDJOaFkyaGxaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2JHRnpkRjkxY0dSaGRHVmZZbXh2WTJzOWNtVmpiM0prTG14aGMzUmZkWEJrWVhSbFgySnNiMk5yTEFvZ0lDQWdMeThnS1FvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lIVnVZMjkyWlhJZ01Ua0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeE9Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4TlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREUwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01UQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBNUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhKbGRITjFZZ29LWDJKMWFXeGtYM05qYjNKbFgzSmxjM1ZzZEY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvM09USUtJQ0FnSUM4dklHbG1JSE5qYjNKbElENDlJRlZKYm5RMk5DaFVTVVZTWDFaRlVrbEdTVVZFS1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEZ3dDaUFnSUNBK1BRb2dJQ0FnWW5vZ1gySjFhV3hrWDNOamIzSmxYM0psYzNWc2RGOWhablJsY2w5cFpsOWxiSE5sUURjS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5aFoyVnVkR2xrTG5CNU9qYzVNd29nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNnektRb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WVdkbGJuUnBaQzV3ZVRvM05Ua0tJQ0FnSUM4dklIUnBaWElnUFNCelpXeG1MbDl6WTI5eVpWOTBiMTkwYVdWeUtITmpiM0psS1FvZ0lDQWdZaUJmWW5WcGJHUmZjMk52Y21WZmNtVnpkV3gwWDJGbWRHVnlYMmx1YkdsdVpXUmZZV2RsYm5ScFpDNUJaMlZ1ZEVsRVEyOXVkSEpoWTNRdVgzTmpiM0psWDNSdlgzUnBaWEpBTVRJS0NsOWlkV2xzWkY5elkyOXlaVjl5WlhOMWJIUmZZV1owWlhKZmFXWmZaV3h6WlVBM09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyRm5aVzUwYVdRdWNIazZOemswQ2lBZ0lDQXZMeUJwWmlCelkyOXlaU0ErUFNCVlNXNTBOalFvVkVsRlVsOVVVbFZUVkVWRUtUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRFkxQ2lBZ0lDQStQUW9nSUNBZ1lub2dYMkoxYVd4a1gzTmpiM0psWDNKbGMzVnNkRjloWm5SbGNsOXBabDlsYkhObFFEa0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWhaMlZ1ZEdsa0xuQjVPamM1TlFvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3lLUW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdllXZGxiblJwWkM1d2VUbzNOVGtLSUNBZ0lDOHZJSFJwWlhJZ1BTQnpaV3htTGw5elkyOXlaVjkwYjE5MGFXVnlLSE5qYjNKbEtRb2dJQ0FnWWlCZlluVnBiR1JmYzJOdmNtVmZjbVZ6ZFd4MFgyRm1kR1Z5WDJsdWJHbHVaV1JmWVdkbGJuUnBaQzVCWjJWdWRFbEVRMjl1ZEhKaFkzUXVYM05qYjNKbFgzUnZYM1JwWlhKQU1USUtDbDlpZFdsc1pGOXpZMjl5WlY5eVpYTjFiSFJmWVdaMFpYSmZhV1pmWld4elpVQTVPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMkZuWlc1MGFXUXVjSGs2TnprMkNpQWdJQ0F2THlCcFppQnpZMjl5WlNBK1BTQlZTVzUwTmpRb1ZFbEZVbDlTUlV4SlFVSk1SU2s2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBME1Bb2dJQ0FnUGowS0lDQWdJR0o2SUY5aWRXbHNaRjl6WTI5eVpWOXlaWE4xYkhSZllXWjBaWEpmYVdaZlpXeHpaVUF4TVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk56azNDaUFnSUNBdkx5QnlaWFIxY200Z1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJGblpXNTBhV1F1Y0hrNk56VTVDaUFnSUNBdkx5QjBhV1Z5SUQwZ2MyVnNaaTVmYzJOdmNtVmZkRzlmZEdsbGNpaHpZMjl5WlNrS0lDQWdJR0lnWDJKMWFXeGtYM05qYjNKbFgzSmxjM1ZzZEY5aFpuUmxjbDlwYm14cGJtVmtYMkZuWlc1MGFXUXVRV2RsYm5SSlJFTnZiblJ5WVdOMExsOXpZMjl5WlY5MGIxOTBhV1Z5UURFeUNncGZZblZwYkdSZmMyTnZjbVZmY21WemRXeDBYMkZtZEdWeVgybG1YMlZzYzJWQU1URTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8zT1RnS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZZV2RsYm5ScFpDNXdlVG8zTlRrS0lDQWdJQzh2SUhScFpYSWdQU0J6Wld4bUxsOXpZMjl5WlY5MGIxOTBhV1Z5S0hOamIzSmxLUW9nSUNBZ1lpQmZZblZwYkdSZmMyTnZjbVZmY21WemRXeDBYMkZtZEdWeVgybHViR2x1WldSZllXZGxiblJwWkM1QloyVnVkRWxFUTI5dWRISmhZM1F1WDNOamIzSmxYM1J2WDNScFpYSkFNVElLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBS0FBRWdaT2dIMlFqUUJzQ1RCc0NhRElEUTI4UDBBaVlLQTJGblh3Z0FBQUFBQUFBQUFBRUFCV0ZrYldsdUQyUnBjM0IxZEdWZlkyOTFiblJsY2d4MGIzUmhiRjloWjJWdWRITUxaWFZ5YjE5dmNtRmpiR1VFRlI5OGRSRnpZVzVrWW05NFgyRjFkR2h2Y21sMGVRTmtjRjh4R0VBQUNDY0VJbWNuQlNKbk1Sa1VSREVZUVFCeGdnOEU1Wnh5TkFRMXVXT2tCTDNzS2Y4RXVNTmZyUVR2TS95R0JGUVRvczRFWEVVbWhBUkR5VEJVQkhaNjZPa0VjNnpkaVFSZjJSOHhCSGNtMkd3RTlIYUxRUVJLRmw3bkJKMlpNZzQyR2dDT0R3QkFBUU1CN2dKakFyVURFZ09VQkI4RXN3WG9CbTRHdVFib0IxNEhkd0NBQkdaYUI2ZzJHZ0NPQVFBQkFEWWFBVWtWU1NRU1JEWWFBa2tWU1NRU1JDc3hBR2NrVHdNU1JDY0dUd05uSkJKRUp3aE1aeWNFSW1jbkJTSm5JME0yR2dGSklsbUJBZ2hMQVJVU1JDZ3hBRkM5UlFFVVJESUdGaklHRm9BcUFKUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBVHdKUWdGb0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFJQlFURkJNVUNneEFGQkp2RWhNdnlJbkJXVkVJd2duQlV4bkkwTWlnQUEyR2dGSkZZRUlFa1EyR2dJVmdRZ1NSRFlhQTBrVlNTUVNSRFlhQkVrVkl4SkVNUUFvTVFCUVJ3SzlSUUZFdmtoSk1nWkxBWUVxV3dsTWdTSmJTVUFBZlNJV1N3Tk1YQ0pGQTBzRklsTkJBRkZMQWttQkNsc2pDQlpjQ2ttQklsdExDaGRKSVFRTFR3SUlGazhDVEZ3aVNZRVNXMDhDQ0JaY0VrVURKRXNIRWtSTEJFc0lVRWxGREwxRkFVQUFFeU1XU3d0TXYwc0NTWUVhV3lNSUZsd2FSUU5MQWttQkFsc2pDQlpjQWpJR0Zsd3FLVnlEU3dSSnZFaE12eU5EU3dHQm9Bc0tTVVVMUUFBRVNVTC9kRXNKZ1dNUFFRQUdTU1VLUXY5bUpVc0tDVXNCQ3lVS1F2OWFOaG9CU1JWSkpCSkVKQkpFS0V4UVJ3SzlSUUZFdmtoSk1nWkpUd0tCZ3dGYlNVNENDU1VPUVFBU1NVRUFEa3NDSTRnSFhrZ25CMHhRc0NORFN3SkxBa2xPQW9nRlhVNEdSZ1ZKRms4Q1RGeDdUd0lXWElOTWdSUU1LaUpQQWxRaVV5RUZURlJMQkVtOFNFc0J2eUtJQnlGSVF2L0FOaG9CU1JWSkpCSkVKQkpFS0V4UVNiMUZBVVJKdmtneUJreExBWWdGRDA0R1JnVkpGazhDVEZ4N1R3SVdYSU5NZ1JRTUtpSlBBbFFpVXlFRlRGUkxBYnhJVEVzQnZ5S0lCdE5JSndkTVVMQWpReWd4QUZCSnZVVUJSRW0rU0RFV0l3azRDRW1Cd0lROUQwU3hnQXRrWlhCdmMybDBRV3huYjdJYWdkSDVwZHdDc2hpQkJySVFnZEFQc2dHelN3R0JPbHRMQVFnV1R3Sk1YRHBKZ1RKYlR3SUlGbHd5S1Z5RFN3RzhTTDhqUTRBQU5ob0JTUlZKSkJKRU5ob0NTUldCQ0JKRU1RQWlLMlZFRWtRa1R3SVNSQ2hQQWxCSlRnSkp2VVVCUkw1SVNVOENGMGxQQW9FeVcwbE9BZzFCQUFOSlJRSkpTd0pKVGdJSkZrc0VURnd5U1VVRmdUcGJTVVVIRGtFQUcwc0VTd0lKRmtzRFRGdzZSUU5MQWlsY2cwc0VTYnhJVEw4alEwc0NLVnc2UlFOQy8raUFBRWsyR2dGSkZZRUlFa1F4QUNneEFGQkhBcjFGQVVTK1NFa2lURW1CTWx0SlR3S0JXbHRKVGdJTlFRQUVTZ2xGQTBzR0YwbEZDVWxMQkE1RVN3SkxBUWtXU3dWTVhESkpSUWFCT2x0SlJRc09RUUFzU3doTENBa1dTd1JNWERwRkJMRkxCN0lJU3dXeUJ5T3lFQ0VFc2dHelN3TXBYSU5MQlVtOFNFeS9JME5MQXlsY09rVUVRdi9YTmhvQlNSVkpKQkpFTmhvQ1NSV0JDQkpFTVFBa1R3TVNSQ2hMQTFCSnZVVUJSRW0rU0U0RE1SWWpDVGdJU3dNWFNZRUNDMHNDRGtRaUp3UmxSRWtqQ0NjRVRHY1dTd0lXTWdZV1R3WlBDVkJQQjFCUEFsQk1VQ3BRSndsTEFsQk12MHNFZ1ZwYlR3TUlGazhFVEZ4YVNZRktXeU1JRmx4S1NZRlNXMDhEQ0JaY1VpbGNnMHNDdkVoUEFreS9Kd2RNVUxBalE0QUFSd1kyR2dGSkZZRUlFa1EyR2dKSkZTTVNSREVBSWl0bFJCSkVUQmNXSndsTVVFbE9Ba205UlFGRXZraEpnY0FGVXlvaVR3SlVJbE1VUklIQUJTTlVUQ0pUU1U4Q2djRUZUd0pVUndKWElDQkpUZ0lvVEZCSlRnSkp2VVVCUkw1SVNVNENnVnBiU1U4Q2dVaGJTVTRDRDBFQUNrb0pGa3NEVEZ4YVJRTkxCa0VBWFVzRmdVQmJTVVVRU3dPQk1sdEpSUkFOUVFBRVN3MUZEMHNOU3c5SlRnSUpGa3NFVEZ3eVNVVUZnVHBiU1VVT0RrRUFJRXNMU3c4SkZrc0RURnc2UlFOTEFpbGNnMHNFU2J4SVRMOUxCMHNHdnlORFN3SXBYRHBGQTBMLzQwbUJNZ3NsQ2tVTlN3S0JTbHRKUlF4QkFBeExDaU1KRmtzRFRGeEtSUU5MQW9GU1cwbEZDMHNHZ1VCYlNVVUxEMEVBRFVzSlN3a0pGa3NEVEZ4U1JRT3hTd3l5Q0VzRXNnY2pzaEFoQkxJQnMwTC9qellhQVVrVlNTUVNSRFlhQWtrVmdRZ1NSREVBSkU4REVrUkpTd01UUkNoTEFWQkp2VVVCUkNoTEJGQkp2VVVCUkV5K1NFc0J2a2hPQTBsWGV3aE1nWHRiU1lGUUQwUXhGaU1KT0FoUEJoZExBUTVFVHdSUEJsQkxBUll5QmhaTEFrOENVRThGVUV4UWdBR0FVTDhMSlFwTEFvRkNXd2dXVHdKTVhFSXBYSU5MQWJ4SXZ5TkROaG9CU1JWSkpCSkVOaG9DU1JXQkNCSkVNUUFpSndobFJCSkVKRThDRWtRb1R3SlFTYjFGQVVSSnZraExBbHhpVHdJWGdRTVBLaUpQQWxRaVV5RUdURlFwWElOTEFieEl2eU5ETmhvQlNSVkpKQkpFTVFBaUp3WmxSQkpFSkJKRUtFeFFTYjFGQVVSSnZraUIwUVlqVkNsY2cwc0J2RWkvSTBNaU5ob0JTUlVrRWtRMkdnSkpUZ0lWSkJKRU5ob0RTVTRDRlNRU1JERUFJaXRsUkJKRU1nWWhDQWhNSWt4SkZTUVNSQ2hNVUVsRkJyMUZBVUVBSGtzRVNiNUlnQWdBQUFBQUFBQUFNbHhyU3dNV1hITXBYSU5MQWJ4SXYwbU5BZ0FMQUFJalE0RUNSUUZMQWtML3Z5TkZBVXNEUXYrM05ob0JTUlZKSkJKRU1RQWlLMlZFRWtRa0VrUXJUR2NqUXpZYUFVa1ZTU1FTUkRFQUlpdGxSQkpFSkJKRUp3Wk1aeU5EaWdJSGdBQkhEb3YrZ1FKYlNTTUlTWXYrZ1FwYkpRdE1Db3YrZ1JwYlNTVU5RUUFESll3U2l4SkFBWHdpZ1FvTFNZd0dKUTFCQUFNbGpBYUwvb0VxVzR2L1RBbEpqQUFoQnc5QkFVd2lqQWVML29FaVcwbU1Da0VBTVl2K2dSSmJTWXdMUVFBbWl3b2xDNHNMSVFRTEl3Z0tTWXdPSlExQkFBTWxqQTZMQjRGR0M0c09nUjRMQ0NVS2pBZUwvb0ZDVzBtTUFpRUpEMEVBOHlXTUNDV01DWXYrZ1VwYlNZd01RUUFsaXc5QkFDQ0wvb0ZTV3lVTGkvNkJFbHNqQ0FwSmpBRWxEVUVBQXlXTUFTV0xBUW1NQ1NLTUJJditnV3RiU1l3RlFRQW5pLzZCYzF0SmpBMkwvdzFCQUJtTERZdi9DWXNGU1U4Q0N5RUlDa21NQkF4QkFBU0xCWXdFaXhHQkdRdUxCb0VVQ3dpTEI0RVVDd2lMQ0lFVUN3aUxDWUVLQ3dnbENvc0VDSXdEaXd4QkFCeUxEQ1VMaXhBS2dRb05RUUFQaXdPQkR3MUJBRVNMQTRFUENZd0RpLzRoQmxNcUlrOENWQ0pUUVFBSGl3T0JCUWlNQTRzREpRMUJBQU1sakFPTEE0c1Jpd2FMQjRzSWl3bUwvb3dHakFXTUJJd0RqQUtNQVl3QWlTS01BMEwvdllzQ0pRc2hDUXFNQ0VML0JDRUhpd0FKSlFzaEJ3cU1CMEwrcUlzU2dRUU1RUUFFSTBMK2VZc1NTWUVDQ2tvS0NJRUNDa29LQ0lFQ0Nrb0tDSUVDQ2tvS0NJRUNDa29LQ0lFQ0Nrb0tDSUVDQ2tvS0NJRUNDa3hMQVFvSWdRSUtRdjQraWdJQ2kvNVhld2lML29GN1cwbUJYdzlCQU1hQkJJditNZ2FJL2ZTTS9rNEZUZ1JPQTA0Q1JRRlBCUlpKazRFSURrUlhCd0ZNRms4Q0ZrOERGazhFRms4RkZvditWd0lJaS81WFNnaUwvbGNTQ0l2K1Z6SUlpLzVYT2dpTC9pRUdVeW9pVHdKVWkvNVhZZ2lML29IUkJsTXFJazhDVkl2K1Yyc0lpLzVYY3dpTC9pRUZVeW9pVHdKVUtpS0wvMVNML2xjcUNJc0FUeE5RVHhKUVR4RlFUeEJRVHc5UVR3NVFUdzFRVHd4UVR3dFFUd3BRVHdsUVR3aFFUd2RRVHdaUVR3VlFUd1JRVHdJaVUwOERJMDhDVkZCTVVJditUd05QQTRtTEFZRlFEMEVBQllFRFF2OHZpd0dCUVE5QkFBV0JBa0wvSW9zQmdTZ1BRUUFFSTBML0ZpSkMveEk9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
