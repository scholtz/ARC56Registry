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

namespace Arc56.Generated.LokoAnas.Algorand.AgentIDContract_44547838
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRJRENvbnRyYWN0IiwiZGVzYyI6IlxuICAgIEFnZW50SUQgUHJvb2Ytb2YtRXhjZWxsZW5jZSBQcm90b2NvbC5cbiAgICBTdG9yZXMgb24tY2hhaW4gcmVwdXRhdGlvbiBmb3IgQUkgYWdlbnRzIHRyYW5zYWN0aW5nIHZpYSB4NDAyLlxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBZ2VudFJlY29yZCI6W3sibmFtZSI6ImRpZCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJzZXR0bGVtZW50X2NvdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNvbmZpcm1lZF9zZXR0bGVtZW50cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbF92b2x1bWUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidW5pcXVlX2NvdW50ZXJwYXJ0eV9jb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0aW1lX3dlaWdodGVkX3ZvbHVtZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXN0X3VwZGF0ZV9ibG9jayIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGFrZV9hbGdvIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InhhbGdvX2JhbGFuY2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZW5kb3JzZW1lbnRfc2NvcmUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZGlzcHV0ZV9jb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkaXNwdXRlX3ZvbHVtZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwZW5kaW5nX2Rpc3B1dGVfc3Rha2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic2FuZGJveF9zY2VuYXJpb3NfcGFzc2VkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNhbmRib3hfY2VydGlmaWVkIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJldXJvX2F0dGVzdGVkIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJnZW5lc2lzX3Njb3JlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImdlbmVzaXNfZXhwaXJ5X2Jsb2NrIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNhY2hlZF9zY29yZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzY29yZV9jYWNoZWRfYXRfYmxvY2siLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaXNfcmVnaXN0ZXJlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiY2F1dGlvbl9mbGFnIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJjcmVhdGVkX2F0X2Jsb2NrIiwidHlwZSI6InVpbnQ2NCJ9XSwiRGlzcHV0ZVJlY29yZCI6W3sibmFtZSI6ImRpc3B1dGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJkaXNwdXRlZF9hZ2VudCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidHhfYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YWtlX2xvY2tlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWxlZF9hdF9ibG9jayIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZXNvbHZlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoidXBoZWxkIiwidHlwZSI6ImJvb2wifV0sIkVuZG9yc2VtZW50UmVjb3JkIjpbeyJuYW1lIjoiZW5kb3JzZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImVuZG9yc2VlIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJzdGFrZV9hbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZW5kb3JzZXJfc2NvcmVfYXRfdGltZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlbmRvcnNlZF9hdF9ibG9jayIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhY3RpdmUiLCJ0eXBlIjoiYm9vbCJ9XSwiU2NvcmVSZXN1bHQiOlt7Im5hbWUiOiJzY29yZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0aWVyIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoic2lnbmFsX2ZpbmFsaXR5IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNpZ25hbF9kaXZlcnNpdHkiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic2lnbmFsX2RlY2F5IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNpZ25hbF9lbmRvcnNlbWVudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzaWduYWxfZGlzcHV0ZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzZXR0bGVtZW50X2NvdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRpc3B1dGVfY291bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfdm9sdW1lIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YWtlX2FsZ28iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoieGFsZ29fYmFsYW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzYW5kYm94X2NlcnRpZmllZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoic2FuZGJveF9zY2VuYXJpb3MiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZXVyb19hdHRlc3RlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZ2VuZXNpc19zY29yZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJnZW5lc2lzX2V4cGlyeV9ibG9jayIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjYXV0aW9uX2ZsYWciLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImlzX2NhY2hlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoibGFzdF91cGRhdGVfYmxvY2siLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOiJEZXBsb3kgYW5kIGluaXRpYWxpc2UgdGhlIGNvbnRyYWN0LiBDYWxsZXIgYmVjb21lcyBhZG1pbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV1cm9fb3JhY2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FuZGJveF9hdXRob3JpdHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXJfYWdlbnQiLCJkZXNjIjoiUmVnaXN0ZXIgdGhlIGNhbGxpbmcgYWNjb3VudCBhcyBhbiBBZ2VudElEIHBhcnRpY2lwYW50LiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjb3JkX3NldHRsZW1lbnQiLCJkZXNjIjoiUmVjb3JkIHRoZSBvdXRjb21lIG9mIGFuIHg0MDIgc2V0dGxlbWVudCBmb3IgdGhlIGNhbGxpbmcgYWdlbnQuXG5NdXN0IGJlIHN1Ym1pdHRlZCBhcyBwYXJ0IG9mIGFuIGF0b21pYyBncm91cCB3aGVyZSB0eFtncm91cF9pbmRleC0xXSBpcyB0aGUgcGF5bWVudCAoQUxHTyBQYXltZW50IG9yIEFTQSBUcmFuc2ZlcikgdG8gdGhlIHJlY2VpdmVyLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY291bnRlcnBhcnR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2V0dGxlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWFkX3Njb3JlIiwiZGVzYyI6IlJldHVybiB0aGUgYWdlbnQncyBjdXJyZW50IHNjb3JlLlxuUmV0dXJucyBjYWNoZWQgdmFsdWUgaWYgZnJlc2ggKDwgU1RBTEVORVNTX1dJTkRPV19CTE9DS1Mgb2xkKSwgb3RoZXJ3aXNlIHJlY29tcHV0ZXMgYWxsIDUgc2lnbmFscyBhbmQgd3JpdGVzIGEgbmV3IGNhY2hlIGVudHJ5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50OCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbCx1aW50NjQsYm9vbCx1aW50NjQsdWludDY0LGJvb2wsYm9vbCx1aW50NjQpIiwic3RydWN0IjoiU2NvcmVSZXN1bHQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZnJlc2hfc2NvcmUiLCJkZXNjIjoiRm9yY2UtcmVjb21wdXRlIGFuZCBjYWNoZSB0aGUgc2NvcmUgZm9yIGFueSBhZ2VudC5cbk5vbi1yZWFkb25seSBzbyB0aGUgY2FjaGUgd3JpdGUgcGVyc2lzdHMgb24tY2hhaW4uIENhbGxlZCBieSB0aGUgbWlkZGxld2FyZSB3aGVuIHRoZSBjYWNoZWQgc2NvcmUgaXMgc3RhbGUuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ4LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sLHVpbnQ2NCxib29sLHVpbnQ2NCx1aW50NjQsYm9vbCxib29sLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJTY29yZVJlc3VsdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0YWtlX29uX2FnZW50IiwiZGVzYyI6IlN0YWtlIEFMR08gZm9yIHRoZSBjYWxsaW5nIGFnZW50IHZpYSBGb2xrcyBGaW5hbmNlIHhBTEdPIHBvb2wuXG5UaGUgcHJlY2VkaW5nIHRyYW5zYWN0aW9uIGluIHRoZSBncm91cCBtdXN0IGJlIGEgUGF5bWVudCBvZiBBTEdPIHRvIHRoaXMgY29udHJhY3QgYWRkcmVzcy4gTXVzdCBiZSBwcmVjZWRlZCAoZ3JvdXBfaW5kZXggLSAxKSBieSBhIFBheW1lbnQgdHguIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNsYXNoX3N0YWtlIiwiZGVzYyI6IlNsYXNoIGEgcG9ydGlvbiBvZiBhbiBhZ2VudCdzIHN0YWtlIG9uIHVwaGVsZCBkaXNwdXRlLlxuT25seSBjYWxsYWJsZSBieSBhZG1pbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzbGFzaF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5zdGFrZV9mcm9tX2FnZW50IiwiZGVzYyI6IldpdGhkcmF3IHN0YWtlIChtaW51cyBhbnkgaG9sZHMgZm9yIHBlbmRpbmcgZGlzcHV0ZXMpLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZmlsZV9kaXNwdXRlIiwiZGVzYyI6IkZpbGUgYSBkaXNwdXRlIGFnYWluc3QgYSByZWNlbnQgc2V0dGxlbWVudC5cblJ1bGUgQTogZGlzcHV0ZXIgbXVzdCBwcm92aWRlIHN0YWtlID0gMsOXIHR4X2Ftb3VudCAodmlhIHByZWNlZGluZyBQYXltZW50IHR4KS4gUnVsZSBCOiBkaXNwdXRlIGltcGFjdCA9ICh0eF9hbW91bnQgLyB0b3RhbF92b2x1bWUpIMOXIGJhc2VfcGVuYWx0eSDigJQgbmVnbGlnaWJsZSAgICAgICAgIGFnYWluc3QgaGlnaC12b2x1bWUgbGVnaXRpbWF0ZSBhZ2VudHMuIFJldHVybnMgdGhlIGRpc3B1dGUgSUQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkaXNwdXRlZF9hZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVzb2x2ZV9kaXNwdXRlIiwiZGVzYyI6IlJlc29sdmUgYSBkaXNwdXRlIChhZG1pbiBvbmx5IGluIE1WUDsgUnVsZSBDIGF1dG9tYXRpb24gaW4gTWlsZXN0b25lIDEpLlxuSWYgdXBoZWxkPVRydWU6IHNsYXNoIGFnZW50IHN0YWtlLCBkaXNwdXRlciBrZWVwcyBsb2NrZWQgc3Rha2UuIElmIHVwaGVsZD1GYWxzZTogZGlzcHV0ZXIgbG9zZXMgNTAlIG9mIGxvY2tlZCBzdGFrZSB0byBhZ2VudCBhcyBjb21wZW5zYXRpb24uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRpc3B1dGVfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1cGhlbGQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW5kb3JzZV9hZ2VudCIsImRlc2MiOiJFbmRvcnNlIGFub3RoZXIgYWdlbnQgYnkgc3Rha2luZyBBTEdPIGJlaGluZCB0aGVtLlxuRW5kb3JzZXIgbXVzdCBiZSBWZXJpZmllZCB0aWVyIChzY29yZSDiiaUgODApLiBQcmVjZWRpbmcgdHggbXVzdCBiZSBhIFBheW1lbnQgb2Ygc3Rha2VfYW1vdW50IHRvIHRoaXMgY29udHJhY3QuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmRvcnNlZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Rha2VfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9zYW5kYm94X2NlcnRpZmllZCIsImRlc2MiOiJJc3N1ZSBvciB1cGRhdGUgUmVwdXRhdGlvbiBTYW5kYm94IGNlcnRpZmljYXRlIGZvciBhbiBhZ2VudC5cbk9ubHkgY2FsbGFibGUgYnkgdGhlIHNhbmRib3hfYXV0aG9yaXR5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjZW5hcmlvc19wYXNzZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2V1cm9fYXR0ZXN0YXRpb24iLCJkZXNjIjoiU2V0IHRoZSBFVVJPIGlkZW50aXR5IGF0dGVzdGF0aW9uIGZsYWcgZm9yIGFuIGFnZW50LlxuT25seSBjYWxsYWJsZSBieSB0aGUgUXVhbnRvcyBvcmFjbGUgYWRkcmVzcyAoZXVyb19vcmFjbGUpLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2VuZXNpc19pbml0aWFsaXplIiwiZGVzYyI6IkFzc2lnbiBHZW5lc2lzIFNjb3JlIDUwIHRvIHRoZSBmb3VuZGluZyBjb2hvcnQgKG1heCAzIGluIE1WUCkuXG5TY29yZXMgYXJlIHRyYW5zcGFyZW50bHkgZGVjbGFyZWQsIHRpbWUtbGltaXRlZCwgYW5kIGRlY2F5IGF1dG9tYXRpY2FsbHkuIE9ubHkgY2FsbGFibGUgYnkgYWRtaW4uIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZW1iZXIxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVtYmVyMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1lbWJlcjMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX2FkbWluIiwiZGVzYyI6IlRyYW5zZmVyIGFkbWluIHJvbGUuIE9ubHkgY3VycmVudCBhZG1pbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19hZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfZXVyb19vcmFjbGUiLCJkZXNjIjoiVXBkYXRlIHRoZSBRdWFudG9zIGV1cm8gb3JhY2xlIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfb3JhY2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6M30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjkxLDI5OSw2NDAsNzU1LDg3MiwxMDY4LDEzMjksMTc4NiwxOTI3LDE5OTEsMjA2NywyMTU1LDIxODBdLCJlcnJvck1lc3NhZ2UiOiJBZGRyZXNzIGxlbmd0aCBpcyAzMiBieXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNjMsMTQ4MSwyMDU0LDIxNTIsMjE3N10sImVycm9yTWVzc2FnZSI6ImFkbWluIG9ubHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTcsNzY0LDg4MCw5NTEsMTA4MCwxMTg5LDE5MzYsMTk5OV0sImVycm9yTWVzc2FnZSI6ImFnZW50IG5vdCByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM2XSwiZXJyb3JNZXNzYWdlIjoiYWxyZWFkeSByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUxMl0sImVycm9yTWVzc2FnZSI6ImFscmVhZHkgcmVzb2x2ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzkxXSwiZXJyb3JNZXNzYWdlIjoiY2Fubm90IHNlbGYtZW5kb3JzZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNjEsMTQ3OSwyMDUyLDIxNTAsMjE3NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGlzcHV0ZV9jb3VudGVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5ODZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmV1cm9fb3JhY2xlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnNhbmRib3hfYXV0aG9yaXR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfYWdlbnRzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0OTZdLCJlcnJvck1lc3NhZ2UiOiJkaXNwdXRlIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NDhdLCJlcnJvck1lc3NhZ2UiOiJkaXNwdXRlZCBhZ2VudCBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzM4XSwiZXJyb3JNZXNzYWdlIjoiZGlzcHV0ZWQgYWdlbnQgbm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODA5XSwiZXJyb3JNZXNzYWdlIjoiZW5kb3JzZWUgbm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODMxXSwiZXJyb3JNZXNzYWdlIjoiZW5kb3JzZXIgbXVzdCBiZSBWZXJpZmllZCB0aWVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgwMF0sImVycm9yTWVzc2FnZSI6ImVuZG9yc2VyIG5vdCByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk4OF0sImVycm9yTWVzc2FnZSI6ImV1cm8gb3JhY2xlIG9ubHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzYwXSwiZXJyb3JNZXNzYWdlIjoiaW5zdWZmaWNpZW50IGRpc3B1dGUgc3Rha2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjI2XSwiZXJyb3JNZXNzYWdlIjoiaW5zdWZmaWNpZW50IHdpdGhkcmF3YWJsZSBzdGFrZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0NSwxNDczXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzMsMjgyLDUzNyw3NTIsODY5LDEwNDYsMTMxMywxNzcwLDE5MDQsMTk3OSwyMDI2LDIwMzYsMjA0NiwyMTQ0LDIxNjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTIwLDUyOCwxMDU1LDExNzcsMTMyMiwxNDY1LDE3NzksMTkxM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2N10sImVycm9yTWVzc2FnZSI6Im1pbmltdW0gc3Rha2UgaXMgMSBBTEdPIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjczMV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkyMl0sImVycm9yTWVzc2FnZSI6InNhbmRib3ggYXV0aG9yaXR5IG9ubHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODQ0XSwiZXJyb3JNZXNzYWdlIjoic3Rha2UgcGF5bWVudCBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTXpJZ01UQXdJREV3TURBZ01URXhNeUE0TkRnZ01UQXdPREF3SURJd01EQXdNQ0F4TURBd01EQXdNREF3TURBS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnMk1UWTNOV1lnTUhnd01EQXdNREF3TURBd01EQXdNREF3SURCNE1EQWdJbUZrYldsdUlpQWlaR2x6Y0hWMFpWOWpiM1Z1ZEdWeUlpQWlkRzkwWVd4ZllXZGxiblJ6SWlBaVpYVnliMTl2Y21GamJHVWlJREI0TVRVeFpqZGpOelVnSW5OaGJtUmliM2hmWVhWMGFHOXlhWFI1SWlBd2VEWTBOekExWmdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG80TXdvZ0lDQWdMeThnYzJWc1ppNWthWE53ZFhSbFgyTnZkVzUwWlhJNklFZHNiMkpoYkZOMFlYUmxXMVZKYm5RMk5GMGdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKa2FYTndkWFJsWDJOdmRXNTBaWElpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2T0RRS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZllXZGxiblJ6T2lCSGJHOWlZV3hUZEdGMFpWdFZTVzUwTmpSZElEMGdSMnh2WW1Gc1UzUmhkR1VvVlVsdWREWTBLREFwS1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEc5MFlXeGZZV2RsYm5Seklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TnpJS0lDQWdJQzh2SUdOc1lYTnpJRUZuWlc1MFNVUkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXlNUW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR1UxT1dNM01qTTBJREI0TXpWaU9UWXpZVFFnTUhoaVpHVmpNamxtWmlBd2VHSTRZek0xWm1Ga0lEQjRaV1l6TTJaak9EWWdNSGcxTkRFellUSmpaU0F3ZURWak5EVXlOamcwSURCNE5ETmpPVE13TlRRZ01IZzNOamRoWlRobE9TQXdlRGN6WVdOa1pEZzVJREI0Tldaa09URm1NekVnTUhnM056STJaRGcyWXlBd2VHWTBOelk0WWpReElEQjROR0V4TmpWbFpUY2dNSGc1WkRrNU16SXdaU0F2THlCdFpYUm9iMlFnSW5KbFoybHpkR1Z5WDJGblpXNTBLSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXTnZjbVJmYzJWMGRHeGxiV1Z1ZENoMWFXNTBOalFzZFdsdWREWTBMR0ZrWkhKbGMzTXNZbTl2YkNsMmIybGtJaXdnYldWMGFHOWtJQ0p5WldGa1gzTmpiM0psS0dGa1pISmxjM01wS0hWcGJuUTJOQ3gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiQ3gxYVc1ME5qUXNZbTl2YkN4MWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3c1ltOXZiQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0p5WldaeVpYTm9YM05qYjNKbEtHRmtaSEpsYzNNcEtIVnBiblEyTkN4MWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkN4MWFXNTBOalFzWW05dmJDeDFhVzUwTmpRc2RXbHVkRFkwTEdKdmIyd3NZbTl2YkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKemRHRnJaVjl2Ymw5aFoyVnVkQ2dwZG05cFpDSXNJRzFsZEdodlpDQWljMnhoYzJoZmMzUmhhMlVvWVdSa2NtVnpjeXgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWRXNXpkR0ZyWlY5bWNtOXRYMkZuWlc1MEtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0ptYVd4bFgyUnBjM0IxZEdVb1lXUmtjbVZ6Y3l4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p5WlhOdmJIWmxYMlJwYzNCMWRHVW9kV2x1ZERZMExHSnZiMndwZG05cFpDSXNJRzFsZEdodlpDQWlaVzVrYjNKelpWOWhaMlZ1ZENoaFpHUnlaWE56TEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJmYzJGdVpHSnZlRjlqWlhKMGFXWnBaV1FvWVdSa2NtVnpjeXgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBYMlYxY205ZllYUjBaWE4wWVhScGIyNG9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpXNWxjMmx6WDJsdWFYUnBZV3hwZW1Vb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlkWEJrWVhSbFgyRmtiV2x1S0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlkWEJrWVhSbFgyVjFjbTlmYjNKaFkyeGxLR0ZrWkhKbGMzTXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lISmxaMmx6ZEdWeVgyRm5aVzUwSUhKbFkyOXlaRjl6WlhSMGJHVnRaVzUwSUhKbFlXUmZjMk52Y21VZ2NtVm1jbVZ6YUY5elkyOXlaU0J6ZEdGclpWOXZibDloWjJWdWRDQnpiR0Z6YUY5emRHRnJaU0IxYm5OMFlXdGxYMlp5YjIxZllXZGxiblFnWm1sc1pWOWthWE53ZFhSbElISmxjMjlzZG1WZlpHbHpjSFYwWlNCbGJtUnZjbk5sWDJGblpXNTBJSE5sZEY5ellXNWtZbTk0WDJObGNuUnBabWxsWkNCelpYUmZaWFZ5YjE5aGRIUmxjM1JoZEdsdmJpQm5aVzVsYzJselgybHVhWFJwWVd4cGVtVWdkWEJrWVhSbFgyRmtiV2x1SUhWd1pHRjBaVjlsZFhKdlgyOXlZV05zWlFvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURJeE9nb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzNNZ29nSUNBZ0x5OGdZMnhoYzNNZ1FXZGxiblJKUkVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJOalZoTURkaE9DQXZMeUJ0WlhSb2IyUWdJbUp2YjNSemRISmhjQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHSnZiM1J6ZEhKaGNBb2dJQ0FnWlhKeUNnb0tMeThnWVdkbGJuUnBaQzVCWjJWdWRFbEVRMjl1ZEhKaFkzUXVZbTl2ZEhOMGNtRndXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW05dmRITjBjbUZ3T2dvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRveE1USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRMQ0JqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qRXhPUW9nSUNBZ0x5OGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTQTlJRlI0Ymk1elpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUZrYldsdUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk1USXdDaUFnSUNBdkx5QnpaV3htTG1WMWNtOWZiM0poWTJ4bExuWmhiSFZsSUQwZ1FXTmpiM1Z1ZENobGRYSnZYMjl5WVdOc1pTNWllWFJsY3lrS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGa1pISmxjM01nYkdWdVozUm9JR2x6SURNeUlHSjVkR1Z6Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0psZFhKdlgyOXlZV05zWlNJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TVRJeENpQWdJQ0F2THlCelpXeG1Mbk5oYm1SaWIzaGZZWFYwYUc5eWFYUjVMblpoYkhWbElEMGdRV05qYjNWdWRDaHpZVzVrWW05NFgyRjFkR2h2Y21sMGVTNWllWFJsY3lrS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaR1J5WlhOeklHeGxibWQwYUNCcGN5QXpNaUJpZVhSbGN3b2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWMyRnVaR0p2ZUY5aGRYUm9iM0pwZEhraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3hNaklLSUNBZ0lDOHZJSE5sYkdZdVpHbHpjSFYwWlY5amIzVnVkR1Z5TG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0prYVhOd2RYUmxYMk52ZFc1MFpYSWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZNVEl6Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDJGblpXNTBjeTUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlkRzkwWVd4ZllXZGxiblJ6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pFeE1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHNJR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1lXZGxiblJwWkM1QloyVnVkRWxFUTI5dWRISmhZM1F1Y21WbmFYTjBaWEpmWVdkbGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldkcGMzUmxjbDloWjJWdWREb0tJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZNVEk1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pFek5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQnpaV3htTG1GblpXNTBjeTV0WVhsaVpTaFVlRzR1YzJWdVpHVnlLVnN4WFN3Z0ltRnNjbVZoWkhrZ2NtVm5hWE4wWlhKbFpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNVFkzTldZS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWVd4eVpXRmtlU0J5WldkcGMzUmxjbVZrQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pFME5Bb2dJQ0FnTHk4Z2JHRnpkRjkxY0dSaGRHVmZZbXh2WTJzOVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xuSnZkVzVrS1N3S0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRveE5qQUtJQ0FnSUM4dklHTnlaV0YwWldSZllYUmZZbXh2WTJzOVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xuSnZkVzVrS1N3S0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRveE16Y3RNVFl4Q2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0JCWjJWdWRGSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQmthV1E5Wkdsa0xBb2dJQ0FnTHk4Z0lDQWdJSE5sZEhSc1pXMWxiblJmWTI5MWJuUTlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdZMjl1Wm1seWJXVmtYM05sZEhSc1pXMWxiblJ6UFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNYM1p2YkhWdFpUMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjFibWx4ZFdWZlkyOTFiblJsY25CaGNuUjVYMk52ZFc1MFBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIUnBiV1ZmZDJWcFoyaDBaV1JmZG05c2RXMWxQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR3hoYzNSZmRYQmtZWFJsWDJKc2IyTnJQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzV5YjNWdVpDa3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGEyVmZZV3huYnoxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCNFlXeG5iMTlpWVd4aGJtTmxQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR1Z1Wkc5eWMyVnRaVzUwWDNOamIzSmxQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR1JwYzNCMWRHVmZZMjkxYm5ROVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pHbHpjSFYwWlY5MmIyeDFiV1U5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnY0dWdVpHbHVaMTlrYVhOd2RYUmxYM04wWVd0bFBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lITmhibVJpYjNoZmMyTmxibUZ5YVc5elgzQmhjM05sWkQxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCellXNWtZbTk0WDJObGNuUnBabWxsWkQxaGNtTTBMa0p2YjJ3b1JtRnNjMlVwTEFvZ0lDQWdMeThnSUNBZ0lHVjFjbTlmWVhSMFpYTjBaV1E5WVhKak5DNUNiMjlzS0VaaGJITmxLU3dLSUNBZ0lDOHZJQ0FnSUNCblpXNWxjMmx6WDNOamIzSmxQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR2RsYm1WemFYTmZaWGh3YVhKNVgySnNiMk5yUFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdOaFkyaGxaRjl6WTI5eVpUMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQnpZMjl5WlY5allXTm9aV1JmWVhSZllteHZZMnM5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnYVhOZmNtVm5hWE4wWlhKbFpEMWhjbU0wTGtKdmIyd29WSEoxWlNrc0NpQWdJQ0F2THlBZ0lDQWdZMkYxZEdsdmJsOW1iR0ZuUFdGeVl6UXVRbTl2YkNoR1lXeHpaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJsWkY5aGRGOWliRzlqYXoxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWNtOTFibVFwTEFvZ0lDQWdMeThnS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBNU5EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRGd3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPakUyTWdvZ0lDQWdMeThnYzJWc1ppNWhaMlZ1ZEhOYlZIaHVMbk5sYm1SbGNsMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qRTJOelZtQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qRTJNd29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjloWjJWdWRITXVkbUZzZFdVZ1BTQnpaV3htTG5SdmRHRnNYMkZuWlc1MGN5NTJZV3gxWlNBcklGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5SdmRHRnNYMkZuWlc1MGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOWhaMlZ1ZEhNZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdOU0F2THlBaWRHOTBZV3hmWVdkbGJuUnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TVRJNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmhaMlZ1ZEdsa0xrRm5aVzUwU1VSRGIyNTBjbUZqZEM1eVpXTnZjbVJmYzJWMGRHeGxiV1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxZMjl5WkY5elpYUjBiR1Z0Wlc1ME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRveE5qa0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qRTRNZ29nSUNBZ0x5OGdZV2RsYm5RZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qRTRNd29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WVdkbGJuUnpMbTFoZVdKbEtHRm5aVzUwS1ZzeFhTd2dJbUZuWlc1MElHNXZkQ0J5WldkcGMzUmxjbVZrSWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZeE5qYzFaZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG94T0RJS0lDQWdJQzh2SUdGblpXNTBJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG94T0RNS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtRm5aVzUwY3k1dFlYbGlaU2hoWjJWdWRDbGJNVjBzSUNKaFoyVnVkQ0J1YjNRZ2NtVm5hWE4wWlhKbFpDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCaFoyVnVkQ0J1YjNRZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3hPRFFLSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVlXZGxiblJ6TG0xaGVXSmxLR0ZuWlc1MEtWc3dYUzVqYjNCNUtDa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ1pIVndDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPakU0TmdvZ0lDQWdMeThnWW14dlkydHpYMlZzWVhCelpXUWdQU0JIYkc5aVlXd3VjbTkxYm1RZ0xTQnlaV052Y21RdWJHRnpkRjkxY0dSaGRHVmZZbXh2WTJzdWJtRjBhWFpsQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEUXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0xRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3hPVEFLSUNBZ0lDOHZJSE5sYkdZdVgyRndjR3g1WDJSbFkyRjVLSEpsWTI5eVpDNTBhVzFsWDNkbGFXZG9kR1ZrWDNadmJIVnRaUzV1WVhScGRtVXNJR0pzYjJOcmMxOWxiR0Z3YzJWa0tRb2dJQ0FnY0hWemFHbHVkQ0F6TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvNE1EZ0tJQ0FnSUM4dklHbG1JSFp2YkhWdFpTQTlQU0JWU1c1ME5qUW9NQ2s2Q2lBZ0lDQmlibm9nY21WamIzSmtYM05sZEhSc1pXMWxiblJmWVdaMFpYSmZhV1pmWld4elpVQXhNQW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG80TURrS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3B5WldOdmNtUmZjMlYwZEd4bGJXVnVkRjloWm5SbGNsOXBibXhwYm1Wa1gyRm5aVzUwYVdRdVFXZGxiblJKUkVOdmJuUnlZV04wTGw5aGNIQnNlVjlrWldOaGVVQXhOVG9LSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TVRnNExURTVNUW9nSUNBZ0x5OGdJeUJFWldOaGVTQmxlR2x6ZEdsdVp5QjBhVzFsTFhkbGFXZG9kR1ZrSUhadmJIVnRaU0JoYm1RZ1lXUmtJRzVsZHlCelpYUjBiR1Z0Wlc1MENpQWdJQ0F2THlCeVpXTnZjbVF1ZEdsdFpWOTNaV2xuYUhSbFpGOTJiMngxYldVZ1BTQmhjbU0wTGxWSmJuUTJOQ2dLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MbDloY0hCc2VWOWtaV05oZVNoeVpXTnZjbVF1ZEdsdFpWOTNaV2xuYUhSbFpGOTJiMngxYldVdWJtRjBhWFpsTENCaWJHOWphM05mWld4aGNITmxaQ2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQXpOQW9nSUNBZ1luVnllU0F6Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pFNU13b2dJQ0FnTHk4Z2FXWWdjMlYwZEd4bFpDNXVZWFJwZG1VNkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5vZ2NtVmpiM0prWDNObGRIUnNaVzFsYm5SZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pFNU5Rb2dJQ0FnTHk4Z2NtVmpiM0prTG1OdmJtWnBjbTFsWkY5elpYUjBiR1Z0Wlc1MGN5NXVZWFJwZG1VZ0t5QXhDaUFnSUNCa2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURFd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TVRrMExURTVOZ29nSUNBZ0x5OGdjbVZqYjNKa0xtTnZibVpwY20xbFpGOXpaWFIwYkdWdFpXNTBjeUE5SUdGeVl6UXVWVWx1ZERZMEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTI5eVpDNWpiMjVtYVhKdFpXUmZjMlYwZEd4bGJXVnVkSE11Ym1GMGFYWmxJQ3NnTVFvZ0lDQWdMeThnS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdNVEFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TVRrNUNpQWdJQ0F2THlCeVpXTnZjbVF1ZEdsdFpWOTNaV2xuYUhSbFpGOTJiMngxYldVdWJtRjBhWFpsSUNzZ1lXMXZkVzUwTG01aGRHbDJaU0FxSURFd01EQUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F6TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01Bb2dJQ0FnS2dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBckNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qRTVOeTB5TURBS0lDQWdJQzh2SUNNZ1UyTmhiR1VnWVcxdmRXNTBJR0o1SURFd01EQWdabTl5SUhScGJXVXRkMlZwWjJoMFpXUWdkbTlzZFcxbElIQnlaV05wYzJsdmJnb2dJQ0FnTHk4Z2NtVmpiM0prTG5ScGJXVmZkMlZwWjJoMFpXUmZkbTlzZFcxbElEMGdZWEpqTkM1VlNXNTBOalFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpiM0prTG5ScGJXVmZkMlZwWjJoMFpXUmZkbTlzZFcxbExtNWhkR2wyWlNBcklHRnRiM1Z1ZEM1dVlYUnBkbVVnS2lBeE1EQXdDaUFnSUNBdkx5QXBDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJRE0wQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pJd01nb2dJQ0FnTHk4Z2NtVmpiM0prTG5SdmRHRnNYM1p2YkhWdFpTNXVZWFJwZG1VZ0t5QmhiVzkxYm5RdWJtRjBhWFpsQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TWpBeExUSXdNd29nSUNBZ0x5OGdjbVZqYjNKa0xuUnZkR0ZzWDNadmJIVnRaU0E5SUdGeVl6UXVWVWx1ZERZMEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTI5eVpDNTBiM1JoYkY5MmIyeDFiV1V1Ym1GMGFYWmxJQ3NnWVcxdmRXNTBMbTVoZEdsMlpRb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTVRnS0lDQWdJR0oxY25rZ013b2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3lNRFV0TWpBMkNpQWdJQ0F2THlBaklGUnlZV05ySUhWdWFYRjFaU0JqYjNWdWRHVnljR0Z5ZEdsbGN3b2dJQ0FnTHk4Z1kzQmZhMlY1SUQwZ2MyVnNaaTVmWTI5MWJuUmxjbkJoY25SNVgydGxlU2hoWjJWdWRDd2dRV05qYjNWdWRDaGpiM1Z1ZEdWeWNHRnlkSGt1WW5sMFpYTXBLUW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCa2FXY2dOd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlpHUnlaWE56SUd4bGJtZDBhQ0JwY3lBek1pQmllWFJsY3dvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvNE5ESUtJQ0FnSUM4dklISmxkSFZ5YmlCaFoyVnVkQzVpZVhSbGN5QXJJR052ZFc1MFpYSndZWEowZVM1aWVYUmxjd29nSUNBZ1pHbG5JRFFLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE1nb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3lNRGNLSUNBZ0lDOHZJRjlqZG1Gc0xDQnpaV1Z1SUQwZ2MyVnNaaTVqYjNWdWRHVnljR0Z5ZEdsbGN5NXRZWGxpWlNoamNGOXJaWGtwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZNakE0Q2lBZ0lDQXZMeUJwWmlCdWIzUWdjMlZsYmpvS0lDQWdJR0p1ZWlCeVpXTnZjbVJmYzJWMGRHeGxiV1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TWpBNUNpQWdJQ0F2THlCelpXeG1MbU52ZFc1MFpYSndZWEowYVdWelcyTndYMnRsZVYwZ1BTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01URUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TWpFeENpQWdJQ0F2THlCeVpXTnZjbVF1ZFc1cGNYVmxYMk52ZFc1MFpYSndZWEowZVY5amIzVnVkQzV1WVhScGRtVWdLeUF4Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElESTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk1qRXdMVEl4TWdvZ0lDQWdMeThnY21WamIzSmtMblZ1YVhGMVpWOWpiM1Z1ZEdWeWNHRnlkSGxmWTI5MWJuUWdQU0JoY21NMExsVkpiblEyTkNnS0lDQWdJQzh2SUNBZ0lDQnlaV052Y21RdWRXNXBjWFZsWDJOdmRXNTBaWEp3WVhKMGVWOWpiM1Z1ZEM1dVlYUnBkbVVnS3lBeENpQWdJQ0F2THlBcENpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUF5TmdvZ0lDQWdZblZ5ZVNBekNncHlaV052Y21SZmMyVjBkR3hsYldWdWRGOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qSXhOQW9nSUNBZ0x5OGdjbVZqYjNKa0xuTmxkSFJzWlcxbGJuUmZZMjkxYm5RZ1BTQmhjbU0wTGxWSmJuUTJOQ2h5WldOdmNtUXVjMlYwZEd4bGJXVnVkRjlqYjNWdWRDNXVZWFJwZG1VZ0t5QXhLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlESUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZNakUxQ2lBZ0lDQXZMeUJ5WldOdmNtUXViR0Z6ZEY5MWNHUmhkR1ZmWW14dlkyc2dQU0JoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1Y205MWJtUXBDaUFnSUNCbmJHOWlZV3dnVW05MWJtUUtJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURReUNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qSXhOeTB5TVRnS0lDQWdJQzh2SUNNZ1NXNTJZV3hwWkdGMFpTQmpZV05vWldRZ2MyTnZjbVVLSUNBZ0lDOHZJSEpsWTI5eVpDNXpZMjl5WlY5allXTm9aV1JmWVhSZllteHZZMnNnUFNCaGNtTTBMbFZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhKbGNHeGhZMlV5SURFek1Rb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3lNakFLSUNBZ0lDOHZJSE5sYkdZdVlXZGxiblJ6VzJGblpXNTBYU0E5SUhKbFkyOXlaQzVqYjNCNUtDa0tJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRveE5qa0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2NtVmpiM0prWDNObGRIUnNaVzFsYm5SZllXWjBaWEpmYVdaZlpXeHpaVUF4TURvS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk9ERXdDaUFnSUNBdkx5QmtZWGx6SUQwZ1lteHZZMnR6WDJWc1lYQnpaV1FnTHk4Z1ZVbHVkRFkwS0VKTVQwTkxVMTlRUlZKZlUwTlBVa2xPUjE5RVFWa3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBeE5EUXdDaUFnSUNBdkNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01URUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZPREV4Q2lBZ0lDQXZMeUJwWmlCa1lYbHpJRDA5SUZWSmJuUTJOQ2d3S1RvS0lDQWdJR0p1ZWlCeVpXTnZjbVJmYzJWMGRHeGxiV1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2lBZ0lDQmtkWEFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TVRrd0NpQWdJQ0F2THlCelpXeG1MbDloY0hCc2VWOWtaV05oZVNoeVpXTnZjbVF1ZEdsdFpWOTNaV2xuYUhSbFpGOTJiMngxYldVdWJtRjBhWFpsTENCaWJHOWphM05mWld4aGNITmxaQ2tLSUNBZ0lHSWdjbVZqYjNKa1gzTmxkSFJzWlcxbGJuUmZZV1owWlhKZmFXNXNhVzVsWkY5aFoyVnVkR2xrTGtGblpXNTBTVVJEYjI1MGNtRmpkQzVmWVhCd2JIbGZaR1ZqWVhsQU1UVUtDbkpsWTI5eVpGOXpaWFIwYkdWdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPamd4TXdvZ0lDQWdMeThnYVdZZ1pHRjVjeUErUFNCVlNXNTBOalFvT1RrcE9nb2dJQ0FnWkdsbklEa0tJQ0FnSUhCMWMyaHBiblFnT1RrS0lDQWdJRDQ5Q2lBZ0lDQmllaUJ5WldOdmNtUmZjMlYwZEd4bGJXVnVkRjloWm5SbGNsOXBabDlsYkhObFFERTBDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPamd4TkMwNE1UVUtJQ0FnSUM4dklDTWdUbVZoY2kxNlpYSnZJR0ZtZEdWeUlEazVJSE5qYjNKcGJtY3RaR0Y1Y3dvZ0lDQWdMeThnY21WMGRYSnVJSFp2YkhWdFpTQXZMeUJWU1c1ME5qUW9NVEF3S1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEF3Q2lBZ0lDQXZDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPakU1TUFvZ0lDQWdMeThnYzJWc1ppNWZZWEJ3YkhsZlpHVmpZWGtvY21WamIzSmtMblJwYldWZmQyVnBaMmgwWldSZmRtOXNkVzFsTG01aGRHbDJaU3dnWW14dlkydHpYMlZzWVhCelpXUXBDaUFnSUNCaUlISmxZMjl5WkY5elpYUjBiR1Z0Wlc1MFgyRm1kR1Z5WDJsdWJHbHVaV1JmWVdkbGJuUnBaQzVCWjJWdWRFbEVRMjl1ZEhKaFkzUXVYMkZ3Y0d4NVgyUmxZMkY1UURFMUNncHlaV052Y21SZmMyVjBkR3hsYldWdWRGOWhablJsY2w5cFpsOWxiSE5sUURFME9nb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzRNVFlLSUNBZ0lDOHZJSEpsZEdWdWRHbHZiaUE5SUZWSmJuUTJOQ2d4TURBcElDMGdaR0Y1Y3dvZ0lDQWdhVzUwWTE4eklDOHZJREV3TUFvZ0lDQWdaR2xuSURFd0NpQWdJQ0F0Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pneE53b2dJQ0FnTHk4Z2NtVjBkWEp1SUNoMmIyeDFiV1VnS2lCeVpYUmxiblJwYjI0cElDOHZJRlZKYm5RMk5DZ3hNREFwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh6SUM4dklERXdNQW9nSUNBZ0x3b2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3hPVEFLSUNBZ0lDOHZJSE5sYkdZdVgyRndjR3g1WDJSbFkyRjVLSEpsWTI5eVpDNTBhVzFsWDNkbGFXZG9kR1ZrWDNadmJIVnRaUzV1WVhScGRtVXNJR0pzYjJOcmMxOWxiR0Z3YzJWa0tRb2dJQ0FnWWlCeVpXTnZjbVJmYzJWMGRHeGxiV1Z1ZEY5aFpuUmxjbDlwYm14cGJtVmtYMkZuWlc1MGFXUXVRV2RsYm5SSlJFTnZiblJ5WVdOMExsOWhjSEJzZVY5a1pXTmhlVUF4TlFvS0NpOHZJR0ZuWlc1MGFXUXVRV2RsYm5SSlJFTnZiblJ5WVdOMExuSmxZV1JmYzJOdmNtVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldGa1gzTmpiM0psT2dvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRveU1qWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZNak16Q2lBZ0lDQXZMeUJoWjJWdWRGOWhZMk52ZFc1MElEMGdRV05qYjNWdWRDaGhaMlZ1ZEM1aWVYUmxjeWtLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlpHUnlaWE56SUd4bGJtZDBhQ0JwY3lBek1pQmllWFJsY3dvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRveU16UUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUZuWlc1MGN5NXRZWGxpWlNoaFoyVnVkRjloWTJOdmRXNTBLVnN4WFN3Z0ltRm5aVzUwSUc1dmRDQnlaV2RwYzNSbGNtVmtJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFl4TmpjMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQnVJRElLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUdGblpXNTBJRzV2ZENCeVpXZHBjM1JsY21Wa0NpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qSXpOUW9nSUNBZ0x5OGdjbVZqYjNKa0lEMGdjMlZzWmk1aFoyVnVkSE11YldGNVltVW9ZV2RsYm5SZllXTmpiM1Z1ZENsYk1GMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3lNellLSUNBZ0lDOHZJR04xY25KbGJuUmZZbXh2WTJzZ1BTQkhiRzlpWVd3dWNtOTFibVFLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk1qTTNDaUFnSUNBdkx5QmpZV05vWlY5aFoyVWdQU0JqZFhKeVpXNTBYMkpzYjJOcklDMGdjbVZqYjNKa0xuTmpiM0psWDJOaFkyaGxaRjloZEY5aWJHOWpheTV1WVhScGRtVUtJQ0FnSUhCMWMyaHBiblFnTVRNeENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdENpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qSXpPUW9nSUNBZ0x5OGdhV1lnWTJGamFHVmZZV2RsSUR3OUlGVkpiblEyTkNoVFZFRk1SVTVGVTFOZlYwbE9SRTlYWDBKTVQwTkxVeWtnWVc1a0lISmxZMjl5WkM1elkyOXlaVjlqWVdOb1pXUmZZWFJmWW14dlkyc3VibUYwYVhabElENGdNRG9LSUNBZ0lHbHVkR05mTXlBdkx5QXhNREFLSUNBZ0lEdzlDaUFnSUNCaWVpQnlaV0ZrWDNOamIzSmxYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnWkhWd0NpQWdJQ0JpZWlCeVpXRmtYM05qYjNKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRveU5EQUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbDlpZFdsc1pGOXpZMjl5WlY5eVpYTjFiSFFvY21WamIzSmtMQ0JwYzE5allXTm9aV1E5VkhKMVpTa0tJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWTJGc2JITjFZaUJmWW5WcGJHUmZjMk52Y21WZmNtVnpkV3gwQ2lBZ0lDQndiM0FLQ25KbFlXUmZjMk52Y21WZllXWjBaWEpmYVc1c2FXNWxaRjloWjJWdWRHbGtMa0ZuWlc1MFNVUkRiMjUwY21GamRDNXlaV0ZrWDNOamIzSmxRRFU2Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pJeU5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B5WldGa1gzTmpiM0psWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TWpRMkNpQWdJQ0F2THlBcElEMGdjMlZzWmk1ZlkyOXRjSFYwWlY5elkyOXlaU2h5WldOdmNtUXNJR04xY25KbGJuUmZZbXh2WTJzcENpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCZlkyOXRjSFYwWlY5elkyOXlaUW9nSUNBZ1kyOTJaWElnTmdvZ0lDQWdjRzl3YmlBMUNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qSTBPQzB5TlRBS0lDQWdJQzh2SUNNZ1YzSnBkR1VnWm5KbGMyZ2dZMkZqYUdVZ0tHOXViSGtnY0c5emMybGliR1VnYVdZZ1RrOVVJSEpsWVdSdmJteDVJT0tBbENCMGFHbHpJR0p5WVc1amFDQnBjeUIxYm5KbFlXTm9ZV0pzWlFvZ0lDQWdMeThnSXlCcGJpQnlaV0ZrYjI1c2VTQmpZV3hzY3l3Z1luVjBJR052YlhCcGJHVnpJR1pwYm1VN0lHTmhiR3hsY25NZ2RYTmxJRzV2YmkxeVpXRmtiMjVzZVNCMGJ5QnlaV1p5WlhOb0tRb2dJQ0FnTHk4Z2NtVmpiM0prTG1OaFkyaGxaRjl6WTI5eVpTQTlJR0Z5WXpRdVZVbHVkRFkwS0dacGJtRnNYM05qYjNKbEtRb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlERXlNd29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG95TlRFS0lDQWdJQzh2SUhKbFkyOXlaQzV6WTI5eVpWOWpZV05vWldSZllYUmZZbXh2WTJzZ1BTQmhjbU0wTGxWSmJuUTJOQ2hqZFhKeVpXNTBYMkpzYjJOcktRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQXhNekVLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TWpVeUNpQWdJQ0F2THlCeVpXTnZjbVF1WTJGMWRHbHZibDltYkdGbklEMGdZWEpqTkM1Q2IyOXNLR1pwYm1Gc1gzTmpiM0psSUR3Z1ZVbHVkRFkwS0VOQlZWUkpUMDVmVTBOUFVrVmZWRWhTUlZOSVQweEVLU2tLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ01qQUtJQ0FnSUR3S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQnBiblJqSURVZ0x5OGdNVEV4TXdvZ0lDQWdjM2RoY0FvZ0lDQWdjMlYwWW1sMENpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qSTFOQW9nSUNBZ0x5OGdjMlZzWmk1aFoyVnVkSE5iWVdkbGJuUmZZV05qYjNWdWRGMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pJMU5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVYMkoxYVd4a1gzTmpiM0psWDNKbGMzVnNkQ2h5WldOdmNtUXNJR2x6WDJOaFkyaGxaRDFHWVd4elpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JqWVd4c2MzVmlJRjlpZFdsc1pGOXpZMjl5WlY5eVpYTjFiSFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG95TWpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWWlCeVpXRmtYM05qYjNKbFgyRm1kR1Z5WDJsdWJHbHVaV1JmWVdkbGJuUnBaQzVCWjJWdWRFbEVRMjl1ZEhKaFkzUXVjbVZoWkY5elkyOXlaVUExQ2dvS0x5OGdZV2RsYm5ScFpDNUJaMlZ1ZEVsRVEyOXVkSEpoWTNRdWNtVm1jbVZ6YUY5elkyOXlaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFpuSmxjMmhmYzJOdmNtVTZDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPakkxT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3lOalVLSUNBZ0lDOHZJR0ZuWlc1MFgyRmpZMjkxYm5RZ1BTQkJZMk52ZFc1MEtHRm5aVzUwTG1KNWRHVnpLUW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGa1pISmxjM01nYkdWdVozUm9JR2x6SURNeUlHSjVkR1Z6Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pJMk5nb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZV2RsYm5SekxtMWhlV0psS0dGblpXNTBYMkZqWTI5MWJuUXBXekZkTENBaVlXZGxiblFnYm05MElISmxaMmx6ZEdWeVpXUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROakUyTnpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV2RsYm5RZ2JtOTBJSEpsWjJsemRHVnlaV1FLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TWpZM0NpQWdJQ0F2THlCeVpXTnZjbVFnUFNCelpXeG1MbUZuWlc1MGN5NXRZWGxpWlNoaFoyVnVkRjloWTJOdmRXNTBLVnN3WFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pJMk9Bb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5aWJHOWpheUE5SUVkc2IySmhiQzV5YjNWdVpBb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qSTNNd29nSUNBZ0x5OGdLU0E5SUhObGJHWXVYMk52YlhCMWRHVmZjMk52Y21Vb2NtVmpiM0prTENCamRYSnlaVzUwWDJKc2IyTnJLUW9nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTmhiR3h6ZFdJZ1gyTnZiWEIxZEdWZmMyTnZjbVVLSUNBZ0lHTnZkbVZ5SURZS0lDQWdJSEJ2Y0c0Z05Rb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3lOelVLSUNBZ0lDOHZJSEpsWTI5eVpDNWpZV05vWldSZmMyTnZjbVVnUFNCaGNtTTBMbFZKYm5RMk5DaG1hVzVoYkY5elkyOXlaU2tLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUF4TWpNS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk1qYzJDaUFnSUNBdkx5QnlaV052Y21RdWMyTnZjbVZmWTJGamFHVmtYMkYwWDJKc2IyTnJJRDBnWVhKak5DNVZTVzUwTmpRb1kzVnljbVZ1ZEY5aWJHOWpheWtLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTVRNeENpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qSTNOd29nSUNBZ0x5OGdjbVZqYjNKa0xtTmhkWFJwYjI1ZlpteGhaeUE5SUdGeVl6UXVRbTl2YkNobWFXNWhiRjl6WTI5eVpTQThJRlZKYm5RMk5DaERRVlZVU1U5T1gxTkRUMUpGWDFSSVVrVlRTRTlNUkNrcENpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJREl3Q2lBZ0lDQThDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnYVc1MFl5QTFJQzh2SURFeE1UTUtJQ0FnSUhOM1lYQUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG95TnprS0lDQWdJQzh2SUhObGJHWXVZV2RsYm5SelcyRm5aVzUwWDJGalkyOTFiblJkSUQwZ2NtVmpiM0prTG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZNamd3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1ZlluVnBiR1JmYzJOdmNtVmZjbVZ6ZFd4MEtISmxZMjl5WkN3Z2FYTmZZMkZqYUdWa1BVWmhiSE5sS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ1gySjFhV3hrWDNOamIzSmxYM0psYzNWc2RBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qSTFPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWVdkbGJuUnBaQzVCWjJWdWRFbEVRMjl1ZEhKaFkzUXVjM1JoYTJWZmIyNWZZV2RsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpkR0ZyWlY5dmJsOWhaMlZ1ZERvS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk1qazFDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVoWjJWdWRITXViV0Y1WW1Vb1lXZGxiblFwV3pGZExDQWlZV2RsYm5RZ2JtOTBJSEpsWjJsemRHVnlaV1FpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpFMk56Vm1DaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPakk1TkFvZ0lDQWdMeThnWVdkbGJuUWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPakk1TlFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVlXZGxiblJ6TG0xaGVXSmxLR0ZuWlc1MEtWc3hYU3dnSW1GblpXNTBJRzV2ZENCeVpXZHBjM1JsY21Wa0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJR0ZuWlc1MElHNXZkQ0J5WldkcGMzUmxjbVZrQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pJNU5nb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTVoWjJWdWRITXViV0Y1WW1Vb1lXZGxiblFwV3pCZExtTnZjSGtvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk1qazRMVEk1T1FvZ0lDQWdMeThnSXlCRVpYUmxjbTFwYm1VZ2MzUmhhMlZrSUdGdGIzVnVkQ0JtY205dElIUm9aU0J3WVhsdFpXNTBJR2x1SUhSb1pTQm5jbTkxY0FvZ0lDQWdMeThnY0dGNWJXVnVkRjloYlc5MWJuUWdQU0J2Y0M1SFZIaHVMbUZ0YjNWdWRDaFVlRzR1WjNKdmRYQmZhVzVrWlhnZ0xTQXhLUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk16QXdDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEY5aGJXOTFiblFnUGowZ1ZVbHVkRFkwS0RGZk1EQXdYekF3TUNrc0lDSnRhVzVwYlhWdElITjBZV3RsSUdseklERWdRVXhIVHlJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3TURBd0NpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRzFwYm1sdGRXMGdjM1JoYTJVZ2FYTWdNU0JCVEVkUENpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qTXdOUzB6TVRBS0lDQWdJQzh2SUNNZ1JHVndiM05wZENCcGJuUnZJRVp2Ykd0eklFWnBibUZ1WTJVZ2VFRk1SMDhnY0c5dmJDQjJhV0VnYVc1dVpYSWdkSEpoYm5OaFkzUnBiMjRLSUNBZ0lDOHZJSEpsYzNWc2RDQTlJR2wwZUc0dVFYQndiR2xqWVhScGIyNURZV3hzS0FvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxQmNIQnNhV05oZEdsdmJpaDRZV3huYjE5aGNIQXBMQW9nSUNBZ0x5OGdJQ0FnSUdGd2NGOWhjbWR6UFNoaUltUmxjRzl6YVhSQmJHZHZJaXdwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NakF3TUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pNd09Bb2dJQ0FnTHk4Z1lYQndYMkZ5WjNNOUtHSWlaR1Z3YjNOcGRFRnNaMjhpTENrc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMk5EWTFOekEyWmpjek5qazNORFF4Tm1NMk56Wm1DaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvek1ESUtJQ0FnSUM4dklIaGhiR2R2WDJGd2NDQTlJRlZKYm5RMk5DaFlRVXhIVDE5QlVGQmZTVVJmVkVWVFZFNUZWQ2tLSUNBZ0lIQjFjMmhwYm5RZ056TXdORE13TmpjekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZNekExTFRNd05nb2dJQ0FnTHk4Z0l5QkVaWEJ2YzJsMElHbHVkRzhnUm05c2EzTWdSbWx1WVc1alpTQjRRVXhIVHlCd2IyOXNJSFpwWVNCcGJtNWxjaUIwY21GdWMyRmpkR2x2YmdvZ0lDQWdMeThnY21WemRXeDBJRDBnYVhSNGJpNUJjSEJzYVdOaGRHbHZia05oYkd3b0NpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3pNRGtLSUNBZ0lDOHZJR1psWlQxVlNXNTBOalFvTWpBd01Da3NDaUFnSUNCd2RYTm9hVzUwSURJd01EQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPak13TlMwek1UQUtJQ0FnSUM4dklDTWdSR1Z3YjNOcGRDQnBiblJ2SUVadmJHdHpJRVpwYm1GdVkyVWdlRUZNUjA4Z2NHOXZiQ0IyYVdFZ2FXNXVaWElnZEhKaGJuTmhZM1JwYjI0S0lDQWdJQzh2SUhKbGMzVnNkQ0E5SUdsMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c0tBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5cFpEMUJjSEJzYVdOaGRHbHZiaWg0WVd4bmIxOWhjSEFwTEFvZ0lDQWdMeThnSUNBZ0lHRndjRjloY21kelBTaGlJbVJsY0c5emFYUkJiR2R2SWl3cExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTWpBd01Da3NDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3pNVEV0TXpFekNpQWdJQ0F2THlBaklIaEJURWRQSUhKbFkyVnBkbVZrSUQwZ2NHRjViV1Z1ZEY5aGJXOTFiblFnS0RFNk1TQmhjSEJ5YjNocGJXRjBaU0JoZENCc1lYVnVZMmdwQ2lBZ0lDQXZMeUFqSUVsdUlIQnlZV04wYVdObExDQjBhR1VnWlhoamFHRnVaMlVnY21GMFpTQnBjeUErSURFZ1FVeEhUeUJ3WlhJZ2VFRk1SMDhLSUNBZ0lDOHZJSEpsWTI5eVpDNTRZV3huYjE5aVlXeGhibU5sSUQwZ1lYSmpOQzVWU1c1ME5qUW9jbVZqYjNKa0xuaGhiR2R2WDJKaGJHRnVZMlV1Ym1GMGFYWmxJQ3NnY0dGNWJXVnVkRjloYlc5MWJuUXBDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBMU9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEVTRDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPak14T0FvZ0lDQWdMeThnY21WamIzSmtMbk4wWVd0bFgyRnNaMjhnUFNCaGNtTTBMbFZKYm5RMk5DaHlaV052Y21RdWMzUmhhMlZmWVd4bmJ5NXVZWFJwZG1VZ0t5QndZWGx0Wlc1MFgyRnRiM1Z1ZENrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTFNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdOVEFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TXpFNUNpQWdJQ0F2THlCeVpXTnZjbVF1YzJOdmNtVmZZMkZqYUdWa1gyRjBYMkpzYjJOcklEMGdZWEpqTkM1VlNXNTBOalFvTUNrZ0lDTWdhVzUyWVd4cFpHRjBaU0JqWVdOb1pRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSEpsY0d4aFkyVXlJREV6TVFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvek1qQUtJQ0FnSUM4dklITmxiR1l1WVdkbGJuUnpXMkZuWlc1MFhTQTlJSEpsWTI5eVpDNWpiM0I1S0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TWpnMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmhaMlZ1ZEdsa0xrRm5aVzUwU1VSRGIyNTBjbUZqZEM1emJHRnphRjl6ZEdGclpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5zWVhOb1gzTjBZV3RsT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pNeU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TXpNeUNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1Ga2JXbHVMblpoYkhWbExDQWlZV1J0YVc0Z2IyNXNlU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFpHMXBiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWVdSdGFXNGdiMjVzZVFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvek16UUtJQ0FnSUM4dklHRm5aVzUwWDJGalkyOTFiblFnUFNCQlkyTnZkVzUwS0dGblpXNTBMbUo1ZEdWektRb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FXUmtjbVZ6Y3lCc1pXNW5kR2dnYVhNZ016SWdZbmwwWlhNS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk16TTFDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVoWjJWdWRITXViV0Y1WW1Vb1lXZGxiblJmWVdOamIzVnVkQ2xiTVYwc0lDSmhaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTVRZM05XWUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV2RsYm5RZ2JtOTBJSEpsWjJsemRHVnlaV1FLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TXpNMkNpQWdJQ0F2THlCeVpXTnZjbVFnUFNCelpXeG1MbUZuWlc1MGN5NXRZWGxpWlNoaFoyVnVkRjloWTJOdmRXNTBLVnN3WFM1amIzQjVLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZNek0zQ2lBZ0lDQXZMeUJoWTNSMVlXeGZjMnhoYzJnZ1BTQnpiR0Z6YUY5aGJXOTFiblF1Ym1GMGFYWmxDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvek16Z0tJQ0FnSUM4dklHbG1JR0ZqZEhWaGJGOXpiR0Z6YUNBK0lISmxZMjl5WkM1emRHRnJaVjloYkdkdkxtNWhkR2wyWlRvS0lDQWdJSEIxYzJocGJuUWdOVEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJRDRLSUNBZ0lHSjZJSE5zWVhOb1gzTjBZV3RsWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRElLQ25Oc1lYTm9YM04wWVd0bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk16UXhDaUFnSUNBdkx5QnlaV052Y21RdWMzUmhhMlZmWVd4bmJ5QTlJR0Z5WXpRdVZVbHVkRFkwS0hKbFkyOXlaQzV6ZEdGclpWOWhiR2R2TG01aGRHbDJaU0F0SUdGamRIVmhiRjl6YkdGemFDa0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklEUUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV5SURVd0NpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05Rb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3pORElLSUNBZ0lDOHZJR2xtSUhKbFkyOXlaQzU0WVd4bmIxOWlZV3hoYm1ObExtNWhkR2wyWlNBK1BTQmhZM1IxWVd4ZmMyeGhjMmc2Q2lBZ0lDQndkWE5vYVc1MElEVTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRGNLSUNBZ0lEdzlDaUFnSUNCaWVpQnpiR0Z6YUY5emRHRnJaVjlsYkhObFgySnZaSGxBTlFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvek5ETUtJQ0FnSUM4dklISmxZMjl5WkM1NFlXeG5iMTlpWVd4aGJtTmxJRDBnWVhKak5DNVZTVzUwTmpRb2NtVmpiM0prTG5oaGJHZHZYMkpoYkdGdVkyVXVibUYwYVhabElDMGdZV04wZFdGc1gzTnNZWE5vS1FvZ0lDQWdaR2xuSURRS0lDQWdJR1JwWnlBeUNpQWdJQ0F0Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdOVGdLSUNBZ0lHSjFjbmtnTXdvS2MyeGhjMmhmYzNSaGEyVmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3pORGNLSUNBZ0lDOHZJSEpsWTI5eVpDNXpZMjl5WlY5allXTm9aV1JmWVhSZllteHZZMnNnUFNCaGNtTTBMbFZKYm5RMk5DZ3dLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCeVpYQnNZV05sTWlBeE16RUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZNelE0Q2lBZ0lDQXZMeUJ6Wld4bUxtRm5aVzUwYzF0aFoyVnVkRjloWTJOdmRXNTBYU0E5SUhKbFkyOXlaQzVqYjNCNUtDa0tJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvek1qSUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2MyeGhjMmhmYzNSaGEyVmZaV3h6WlY5aWIyUjVRRFU2Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pNME5Rb2dJQ0FnTHk4Z2NtVmpiM0prTG5oaGJHZHZYMkpoYkdGdVkyVWdQU0JoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnWkdsbklESUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J5WlhCc1lXTmxNaUExT0FvZ0lDQWdZblZ5ZVNBekNpQWdJQ0JpSUhOc1lYTm9YM04wWVd0bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvS0NpOHZJR0ZuWlc1MGFXUXVRV2RsYm5SSlJFTnZiblJ5WVdOMExuVnVjM1JoYTJWZlpuSnZiVjloWjJWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ1YzNSaGEyVmZabkp2YlY5aFoyVnVkRG9LSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1pIVndDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPak0xTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG96TlRNS0lDQWdJQzh2SUdGblpXNTBJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG96TlRRS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtRm5aVzUwY3k1dFlYbGlaU2hoWjJWdWRDbGJNVjBzSUNKaFoyVnVkQ0J1YjNRZ2NtVm5hWE4wWlhKbFpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNVFkzTldZS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk16VXpDaUFnSUNBdkx5QmhaMlZ1ZENBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk16VTBDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVoWjJWdWRITXViV0Y1WW1Vb1lXZGxiblFwV3pGZExDQWlZV2RsYm5RZ2JtOTBJSEpsWjJsemRHVnlaV1FpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdZV2RsYm5RZ2JtOTBJSEpsWjJsemRHVnlaV1FLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TXpVMUNpQWdJQ0F2THlCeVpXTnZjbVFnUFNCelpXeG1MbUZuWlc1MGN5NXRZWGxpWlNoaFoyVnVkQ2xiTUYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJR1IxY0FvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvek5UWUtJQ0FnSUM4dklHRjJZV2xzWVdKc1pTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZNelUzQ2lBZ0lDQXZMeUJwWmlCeVpXTnZjbVF1YzNSaGEyVmZZV3huYnk1dVlYUnBkbVVnUGlCeVpXTnZjbVF1Y0dWdVpHbHVaMTlrYVhOd2RYUmxYM04wWVd0bExtNWhkR2wyWlRvS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTFNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3ZFhOb2FXNTBJRGt3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0ErQ2lBZ0lDQmllaUIxYm5OMFlXdGxYMlp5YjIxZllXZGxiblJmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPak0xT0FvZ0lDQWdMeThnWVhaaGFXeGhZbXhsSUQwZ2NtVmpiM0prTG5OMFlXdGxYMkZzWjI4dWJtRjBhWFpsSUMwZ2NtVmpiM0prTG5CbGJtUnBibWRmWkdsemNIVjBaVjl6ZEdGclpTNXVZWFJwZG1VS0lDQWdJR1IxY0RJS0lDQWdJQzBLSUNBZ0lHSjFjbmtnTXdvS2RXNXpkR0ZyWlY5bWNtOXRYMkZuWlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk16WXdDaUFnSUNBdkx5QmhjM05sY25RZ1lXMXZkVzUwTG01aGRHbDJaU0E4UFNCaGRtRnBiR0ZpYkdVc0lDSnBibk4xWm1acFkybGxiblFnZDJsMGFHUnlZWGRoWW14bElITjBZV3RsSWdvZ0lDQWdaR2xuSURZS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1YzNWbVptbGphV1Z1ZENCM2FYUm9aSEpoZDJGaWJHVWdjM1JoYTJVS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk16WXlDaUFnSUNBdkx5QnlaV052Y21RdWMzUmhhMlZmWVd4bmJ5QTlJR0Z5WXpRdVZVbHVkRFkwS0hKbFkyOXlaQzV6ZEdGclpWOWhiR2R2TG01aGRHbDJaU0F0SUdGdGIzVnVkQzV1WVhScGRtVXBDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JREVLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTFDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBMU1Bb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEWUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZNell6Q2lBZ0lDQXZMeUJwWmlCeVpXTnZjbVF1ZUdGc1oyOWZZbUZzWVc1alpTNXVZWFJwZG1VZ1BqMGdZVzF2ZFc1MExtNWhkR2wyWlRvS0lDQWdJSEIxYzJocGJuUWdOVGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJRHc5Q2lBZ0lDQmllaUIxYm5OMFlXdGxYMlp5YjIxZllXZGxiblJmWld4elpWOWliMlI1UURVS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk16WTBDaUFnSUNBdkx5QnlaV052Y21RdWVHRnNaMjlmWW1Gc1lXNWpaU0E5SUdGeVl6UXVWVWx1ZERZMEtISmxZMjl5WkM1NFlXeG5iMTlpWVd4aGJtTmxMbTVoZEdsMlpTQXRJR0Z0YjNWdWRDNXVZWFJwZG1VcENpQWdJQ0JrYVdjZ09Bb2dJQ0FnWkdsbklEZ0tJQ0FnSUMwS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBMENpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUExT0FvZ0lDQWdZblZ5ZVNBMENncDFibk4wWVd0bFgyWnliMjFmWVdkbGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3pOamd0TXpjekNpQWdJQ0F2THlBaklGSmxkSFZ5YmlCQlRFZFBJSFJ2SUdGblpXNTBJSFpwWVNCcGJtNWxjaUJ3WVhsdFpXNTBDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOVlXZGxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGdGIzVnVkQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNneE1EQXdLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdScFp5QTNDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdaR2xuSURVS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TXpZNExUTTJPUW9nSUNBZ0x5OGdJeUJTWlhSMWNtNGdRVXhIVHlCMGJ5QmhaMlZ1ZENCMmFXRWdhVzV1WlhJZ2NHRjViV1Z1ZEFvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvek56SUtJQ0FnSUM4dklHWmxaVDFWU1c1ME5qUW9NVEF3TUNrc0NpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZNelk0TFRNM013b2dJQ0FnTHk4Z0l5QlNaWFIxY200Z1FVeEhUeUIwYnlCaFoyVnVkQ0IyYVdFZ2FXNXVaWElnY0dGNWJXVnVkQW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBXRm5aVzUwTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxaGJXOTFiblF1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMVZTVzUwTmpRb01UQXdNQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG96TnpVS0lDQWdJQzh2SUhKbFkyOXlaQzV6WTI5eVpWOWpZV05vWldSZllYUmZZbXh2WTJzZ1BTQmhjbU0wTGxWSmJuUTJOQ2d3S1FvZ0lDQWdaR2xuSURNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnlaWEJzWVdObE1pQXhNekVLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TXpjMkNpQWdJQ0F2THlCelpXeG1MbUZuWlc1MGMxdGhaMlZ1ZEYwZ1BTQnlaV052Y21RdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZNelV3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDblZ1YzNSaGEyVmZabkp2YlY5aFoyVnVkRjlsYkhObFgySnZaSGxBTlRvS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk16WTJDaUFnSUNBdkx5QnlaV052Y21RdWVHRnNaMjlmWW1Gc1lXNWpaU0E5SUdGeVl6UXVWVWx1ZERZMEtEQXBDaUFnSUNCa2FXY2dNd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhKbGNHeGhZMlV5SURVNENpQWdJQ0JpZFhKNUlEUUtJQ0FnSUdJZ2RXNXpkR0ZyWlY5bWNtOXRYMkZuWlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvS0NpOHZJR0ZuWlc1MGFXUXVRV2RsYm5SSlJFTnZiblJ5WVdOMExtWnBiR1ZmWkdsemNIVjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21acGJHVmZaR2x6Y0hWMFpUb0tJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZNemd5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUb3pPVFVLSUNBZ0lDOHZJR1JwYzNCMWRHVnlJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG96T1RZS0lDQWdJQzh2SUdScGMzQjFkR1ZrSUQwZ1FXTmpiM1Z1ZENoa2FYTndkWFJsWkY5aFoyVnVkQzVpZVhSbGN5a0tJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFRmtaSEpsYzNNZ2JHVnVaM1JvSUdseklETXlJR0o1ZEdWekNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qTTVPQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WVdkbGJuUnpMbTFoZVdKbEtHUnBjM0IxZEdWa0tWc3hYU3dnSW1ScGMzQjFkR1ZrSUdGblpXNTBJRzV2ZENCeVpXZHBjM1JsY21Wa0lnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWXhOamMxWmdvZ0lDQWdaR2xuSURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmthWE53ZFhSbFpDQmhaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG96T1RrS0lDQWdJQzh2SUhKbFkyOXlaQ0E5SUhObGJHWXVZV2RsYm5SekxtMWhlV0psS0dScGMzQjFkR1ZrS1Zzd1hTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPalF3TVMwME1ESUtJQ0FnSUM4dklDTWdWbVZ5YVdaNUlGSjFiR1VnUVNCemRHRnJaU0FvY0hKbFkyVmthVzVuSUZCaGVXMWxiblFnZEhnZ2FXNGdkR2hsSUdkeWIzVndLUW9nSUNBZ0x5OGdjM1JoYTJWZmNHRjViV1Z1ZENBOUlHOXdMa2RVZUc0dVlXMXZkVzUwS0ZSNGJpNW5jbTkxY0Y5cGJtUmxlQ0F0SURFcENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8wTURNS0lDQWdJQzh2SUhKbGNYVnBjbVZrWDNOMFlXdGxJRDBnZEhoZllXMXZkVzUwTG01aGRHbDJaU0FxSUZWSmJuUTJOQ2hFU1ZOUVZWUkZYMU5VUVV0RlgwMVZURlJKVUV4SlJWSXBDaUFnSUNCa2FXY2dNd29nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ29LSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TkRBMENpQWdJQ0F2THlCaGMzTmxjblFnYzNSaGEyVmZjR0Y1YldWdWRDQStQU0J5WlhGMWFYSmxaRjl6ZEdGclpTd2dJbWx1YzNWbVptbGphV1Z1ZENCa2FYTndkWFJsSUhOMFlXdGxJZ29nSUNBZ1pHbG5JRElLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNXpkV1ptYVdOcFpXNTBJR1JwYzNCMWRHVWdjM1JoYTJVS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5EQTJDaUFnSUNBdkx5QmthWE53ZFhSbFgybGtJRDBnYzJWc1ppNWthWE53ZFhSbFgyTnZkVzUwWlhJdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmthWE53ZFhSbFgyTnZkVzUwWlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaR2x6Y0hWMFpWOWpiM1Z1ZEdWeUlHVjRhWE4wY3dvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvME1EY0tJQ0FnSUM4dklITmxiR1l1WkdsemNIVjBaVjlqYjNWdWRHVnlMblpoYkhWbElEMGdaR2x6Y0hWMFpWOXBaQ0FySUZWSmJuUTJOQ2d4S1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVpHbHpjSFYwWlY5amIzVnVkR1Z5SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5EQTVDaUFnSUNBdkx5QmthWE53ZFhSbFgydGxlU0E5SUc5d0xtbDBiMklvWkdsemNIVjBaVjlwWkNrS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5ERTFDaUFnSUNBdkx5QnpkR0ZyWlY5c2IyTnJaV1E5WVhKak5DNVZTVzUwTmpRb2MzUmhhMlZmY0dGNWJXVnVkQ2tzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvME1UWUtJQ0FnSUM4dklHWnBiR1ZrWDJGMFgySnNiMk5yUFdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1eWIzVnVaQ2tzQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TkRFeExUUXhPUW9nSUNBZ0x5OGdaR2x6Y0hWMFpTQTlJRVJwYzNCMWRHVlNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdaR2x6Y0hWMFpYSTlZWEpqTkM1QlpHUnlaWE56S0dScGMzQjFkR1Z5TG1KNWRHVnpLU3dLSUNBZ0lDOHZJQ0FnSUNCa2FYTndkWFJsWkY5aFoyVnVkRDFoY21NMExrRmtaSEpsYzNNb1pHbHpjSFYwWldRdVlubDBaWE1wTEFvZ0lDQWdMeThnSUNBZ0lIUjRYMkZ0YjNWdWREMTBlRjloYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnYzNSaGEyVmZiRzlqYTJWa1BXRnlZelF1VlVsdWREWTBLSE4wWVd0bFgzQmhlVzFsYm5RcExBb2dJQ0FnTHk4Z0lDQWdJR1pwYkdWa1gyRjBYMkpzYjJOclBXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXliM1Z1WkNrc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6YjJ4MlpXUTlZWEpqTkM1Q2IyOXNLRVpoYkhObEtTd0tJQ0FnSUM4dklDQWdJQ0IxY0dobGJHUTlZWEpqTkM1Q2IyOXNLRVpoYkhObEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdkVzVqYjNabGNpQTVDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvME1qQUtJQ0FnSUM4dklITmxiR1l1WkdsemNIVjBaWE5iWkdsemNIVjBaVjlyWlhsZElEMGdaR2x6Y0hWMFpTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnMk5EY3dOV1lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOREkwQ2lBZ0lDQXZMeUJ5WldOdmNtUXVjR1Z1WkdsdVoxOWthWE53ZFhSbFgzTjBZV3RsTG01aGRHbDJaU0FySUhOMFlXdGxYM0JoZVcxbGJuUUtJQ0FnSUdScFp5QTBDaUFnSUNCd2RYTm9hVzUwSURrd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQXJDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPalF5TWkwME1qVUtJQ0FnSUM4dklDTWdURzlqYXlCemRHRnJaU0JwYmlCd1pXNWthVzVuSUhCdmIyd2dLSEpsWTI5eVpHVmtJRzl1SUhSb1pTQmthWE53ZFhSbFpDQmhaMlZ1ZENkeklISmxZMjl5WkNrS0lDQWdJQzh2SUhKbFkyOXlaQzV3Wlc1a2FXNW5YMlJwYzNCMWRHVmZjM1JoYTJVZ1BTQmhjbU0wTGxWSmJuUTJOQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTnZjbVF1Y0dWdVpHbHVaMTlrYVhOd2RYUmxYM04wWVd0bExtNWhkR2wyWlNBcklITjBZV3RsWDNCaGVXMWxiblFLSUNBZ0lDOHZJQ2tLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVElnT1RBS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5ESTJDaUFnSUNBdkx5QnlaV052Y21RdVpHbHpjSFYwWlY5amIzVnVkQ0E5SUdGeVl6UXVWVWx1ZERZMEtISmxZMjl5WkM1a2FYTndkWFJsWDJOdmRXNTBMbTVoZEdsMlpTQXJJREVwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ056UUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdOelFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TkRJM0NpQWdJQ0F2THlCeVpXTnZjbVF1WkdsemNIVjBaVjkyYjJ4MWJXVWdQU0JoY21NMExsVkpiblEyTkNoeVpXTnZjbVF1WkdsemNIVjBaVjkyYjJ4MWJXVXVibUYwYVhabElDc2dkSGhmWVcxdmRXNTBMbTVoZEdsMlpTa0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0E0TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnT0RJS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5ESTRDaUFnSUNBdkx5QnlaV052Y21RdWMyTnZjbVZmWTJGamFHVmtYMkYwWDJKc2IyTnJJRDBnWVhKak5DNVZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J5WlhCc1lXTmxNaUF4TXpFS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5ETXdDaUFnSUNBdkx5QnpaV3htTG1GblpXNTBjMXRrYVhOd2RYUmxaRjBnUFNCeVpXTnZjbVF1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TXpneUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmhaMlZ1ZEdsa0xrRm5aVzUwU1VSRGIyNTBjbUZqZEM1eVpYTnZiSFpsWDJScGMzQjFkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYTnZiSFpsWDJScGMzQjFkR1U2Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lHUjFjRzRnTmdvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvME16TUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qUTBOQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmk1MllXeDFaU3dnSW1Ga2JXbHVJRzl1YkhraUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHRmtiV2x1SUc5dWJIa0tJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZORFEyQ2lBZ0lDQXZMeUJrYVhOd2RYUmxYMnRsZVNBOUlHOXdMbWwwYjJJb1pHbHpjSFYwWlY5cFpDNXVZWFJwZG1VcENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qUTBOd29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WkdsemNIVjBaWE11YldGNVltVW9aR2x6Y0hWMFpWOXJaWGtwV3pGZExDQWlaR2x6Y0hWMFpTQnViM1FnWm05MWJtUWlDaUFnSUNCaWVYUmxZeUE1SUM4dklEQjROalEzTURWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJrYVhOd2RYUmxJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8wTkRnS0lDQWdJQzh2SUdScGMzQjFkR1VnUFNCelpXeG1MbVJwYzNCMWRHVnpMbTFoZVdKbEtHUnBjM0IxZEdWZmEyVjVLVnN3WFM1amIzQjVLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvME5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCdWIzUWdaR2x6Y0hWMFpTNXlaWE52YkhabFpDNXVZWFJwZG1Vc0lDSmhiSEpsWVdSNUlISmxjMjlzZG1Wa0lnb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRGN3TkFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHRnNjbVZoWkhrZ2NtVnpiMngyWldRS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5EVXhDaUFnSUNBdkx5QmthWE53ZFhSbExuSmxjMjlzZG1Wa0lEMGdZWEpqTkM1Q2IyOXNLRlJ5ZFdVcENpQWdJQ0J3ZFhOb2FXNTBJRGN3TkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lITmxkR0pwZEFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvME5USUtJQ0FnSUM4dklHUnBjM0IxZEdVdWRYQm9aV3hrSUQwZ2RYQm9aV3hrQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnY0hWemFHbHVkQ0EzTURVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5EVTBDaUFnSUNBdkx5QmthWE53ZFhSbFpDQTlJRUZqWTI5MWJuUW9aR2x6Y0hWMFpTNWthWE53ZFhSbFpGOWhaMlZ1ZEM1aWVYUmxjeWtLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvME5UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUZuWlc1MGN5NXRZWGxpWlNoa2FYTndkWFJsWkNsYk1WMHNJQ0prYVhOd2RYUmxaQ0JoWjJWdWRDQnViM1FnWm05MWJtUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROakUyTnpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJrYVhOd2RYUmxaQ0JoWjJWdWRDQnViM1FnWm05MWJtUUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZORFUyQ2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxtRm5aVzUwY3k1dFlYbGlaU2hrYVhOd2RYUmxaQ2xiTUYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzBOVGd0TkRVNUNpQWdJQ0F2THlBaklGSmxiR1ZoYzJVZ2NHVnVaR2x1WnlCemRHRnJaU0JzYjJOckNpQWdJQ0F2THlCcFppQnlaV052Y21RdWNHVnVaR2x1WjE5a2FYTndkWFJsWDNOMFlXdGxMbTVoZEdsMlpTQStQU0JrYVhOd2RYUmxMbk4wWVd0bFgyeHZZMnRsWkM1dVlYUnBkbVU2Q2lBZ0lDQndkWE5vYVc1MElEa3dDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEIxYzJocGJuUWdOeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJRDQ5Q2lBZ0lDQmllaUJ5WlhOdmJIWmxYMlJwYzNCMWRHVmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qUTJNUW9nSUNBZ0x5OGdjbVZqYjNKa0xuQmxibVJwYm1kZlpHbHpjSFYwWlY5emRHRnJaUzV1WVhScGRtVWdMU0JrYVhOd2RYUmxMbk4wWVd0bFgyeHZZMnRsWkM1dVlYUnBkbVVLSUNBZ0lHUjFjRElLSUNBZ0lDMEtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZORFl3TFRRMk1nb2dJQ0FnTHk4Z2NtVmpiM0prTG5CbGJtUnBibWRmWkdsemNIVjBaVjl6ZEdGclpTQTlJR0Z5WXpRdVZVbHVkRFkwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMjl5WkM1d1pXNWthVzVuWDJScGMzQjFkR1ZmYzNSaGEyVXVibUYwYVhabElDMGdaR2x6Y0hWMFpTNXpkR0ZyWlY5c2IyTnJaV1F1Ym1GMGFYWmxDaUFnSUNBdkx5QXBDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ09UQUtJQ0FnSUdKMWNua2dNd29LY21WemIyeDJaVjlrYVhOd2RYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZORFkwQ2lBZ0lDQXZMeUJwWmlCMWNHaGxiR1F1Ym1GMGFYWmxPZ29nSUNBZ1pHbG5JRFlLSUNBZ0lHSjZJSEpsYzI5c2RtVmZaR2x6Y0hWMFpWOWxiSE5sWDJKdlpIbEFNVEFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TkRZMUxUUTJPQW9nSUNBZ0x5OGdJeUJRWlc1aGJIUjVPaUJrWldSMVkzUWdjSEp2Y0c5eWRHbHZibUZzSUdsdGNHRmpkQ0JtY205dElHRm5aVzUwSjNNZ1pHbHpjSFYwWlNCeVlYUnBid29nSUNBZ0x5OGdJeUFvWVd4eVpXRmtlU0JqWVhCMGRYSmxaQ0JwYmlCa2FYTndkWFJsWDJOdmRXNTBJR0Z1WkNCa2FYTndkWFJsWDNadmJIVnRaU2tLSUNBZ0lDOHZJQ01nVTJ4aGMyZ2dZV2RsYm5RbmN5QnpkR0ZyWlNCd2NtOXdiM0owYVc5dVlXeHNlUW9nSUNBZ0x5OGdjMnhoYzJnZ1BTQmthWE53ZFhSbExuUjRYMkZ0YjNWdWRDNXVZWFJwZG1VS0lDQWdJR1JwWnlBMUNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFMkNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qUTJPUW9nSUNBZ0x5OGdhV1lnYzJ4aGMyZ2dQaUJ5WldOdmNtUXVjM1JoYTJWZllXeG5ieTV1WVhScGRtVTZDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR2x1ZENBMU1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhOZ29nSUNBZ1Bnb2dJQ0FnWW5vZ2NtVnpiMngyWlY5a2FYTndkWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29nSUNBZ1pHbG5JREV6Q2lBZ0lDQmlkWEo1SURFMUNncHlaWE52YkhabFgyUnBjM0IxZEdWZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvME56RUtJQ0FnSUM4dklISmxZMjl5WkM1emRHRnJaVjloYkdkdklEMGdZWEpqTkM1VlNXNTBOalFvY21WamIzSmtMbk4wWVd0bFgyRnNaMjh1Ym1GMGFYWmxJQzBnYzJ4aGMyZ3BDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHUnBaeUF4TlFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F0Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdOVEFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0ExQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pRM01nb2dJQ0FnTHk4Z2FXWWdjbVZqYjNKa0xuaGhiR2R2WDJKaGJHRnVZMlV1Ym1GMGFYWmxJRDQ5SUhOc1lYTm9PZ29nSUNBZ2NIVnphR2x1ZENBMU9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhOQW9nSUNBZ1BEMEtJQ0FnSUdKNklISmxjMjlzZG1WZlpHbHpjSFYwWlY5bGJITmxYMkp2WkhsQU9Bb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzBOek1LSUNBZ0lDOHZJSEpsWTI5eVpDNTRZV3huYjE5aVlXeGhibU5sSUQwZ1lYSmpOQzVWU1c1ME5qUW9jbVZqYjNKa0xuaGhiR2R2WDJKaGJHRnVZMlV1Ym1GMGFYWmxJQzBnYzJ4aGMyZ3BDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdMUW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEVTRDaUFnSUNCaWRYSjVJRE1LQ25KbGMyOXNkbVZmWkdsemNIVjBaVjloWm5SbGNsOXBabDlsYkhObFFERTJPZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8wT1RNS0lDQWdJQzh2SUhKbFkyOXlaQzV6WTI5eVpWOWpZV05vWldSZllYUmZZbXh2WTJzZ1BTQmhjbU0wTGxWSmJuUTJOQ2d3S1FvZ0lDQWdaR2xuSURJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnlaWEJzWVdObE1pQXhNekVLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TkRrMENpQWdJQ0F2THlCelpXeG1MbUZuWlc1MGMxdGthWE53ZFhSbFpGMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TkRrMUNpQWdJQ0F2THlCelpXeG1MbVJwYzNCMWRHVnpXMlJwYzNCMWRHVmZhMlY1WFNBOUlHUnBjM0IxZEdVdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTndvZ0lDQWdaR2xuSURZS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZORE16Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbkpsYzI5c2RtVmZaR2x6Y0hWMFpWOWxiSE5sWDJKdlpIbEFPRG9LSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TkRjMUNpQWdJQ0F2THlCeVpXTnZjbVF1ZUdGc1oyOWZZbUZzWVc1alpTQTlJR0Z5WXpRdVZVbHVkRFkwS0RBcENpQWdJQ0JrYVdjZ01nb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSEpsY0d4aFkyVXlJRFU0Q2lBZ0lDQmlkWEo1SURNS0lDQWdJR0lnY21WemIyeDJaVjlrYVhOd2RYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU1UWUtDbkpsYzI5c2RtVmZaR2x6Y0hWMFpWOWxiSE5sWDJKdlpIbEFNVEE2Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pRM055MDBOemdLSUNBZ0lDOHZJQ01nU1c1MllXeHBaQ0JrYVhOd2RYUmxPaUJ6YkdGemFDQTFNQ1VnYjJZZ2JHOWphMlZrSUhOMFlXdGxMQ0J6Wlc1a0lIUnZJR1JwYzNCMWRHVmtJR0ZuWlc1MENpQWdJQ0F2THlCemJHRnphRjloYlc5MWJuUWdQU0FvWkdsemNIVjBaUzV6ZEdGclpWOXNiMk5yWldRdWJtRjBhWFpsSUNvZ1ZVbHVkRFkwS0VSSlUxQlZWRVZmVTB4QlUwaGZVRVZTUTBWT1ZDa3BJQzh2SUZWSmJuUTJOQ2d4TURBcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOVEFLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNeUF2THlBeE1EQUtJQ0FnSUM4S0lDQWdJR0oxY25rZ01UTUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZORGM1TFRRNE1Bb2dJQ0FnTHk4Z0l5QlNaVzF2ZG1VZ2NHVnVZV3gwZVNCbWNtOXRJR1JwYzNCMWRHVmZZMjkxYm5RZ2MybHVZMlVnWkdsemNIVjBaU0IzWVhNZ2FXNTJZV3hwWkFvZ0lDQWdMeThnYVdZZ2NtVmpiM0prTG1ScGMzQjFkR1ZmWTI5MWJuUXVibUYwYVhabElENGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ056UUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVElLSUNBZ0lHSjZJSEpsYzI5c2RtVmZaR2x6Y0hWMFpWOWhablJsY2w5cFpsOWxiSE5sUURFeUNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qUTRNUW9nSUNBZ0x5OGdjbVZqYjNKa0xtUnBjM0IxZEdWZlkyOTFiblFnUFNCaGNtTTBMbFZKYm5RMk5DaHlaV052Y21RdVpHbHpjSFYwWlY5amIzVnVkQzV1WVhScGRtVWdMU0F4S1FvZ0lDQWdaR2xuSURFd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEYzBDaUFnSUNCaWRYSjVJRE1LQ25KbGMyOXNkbVZmWkdsemNIVjBaVjloWm5SbGNsOXBabDlsYkhObFFERXlPZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8wT0RJS0lDQWdJQzh2SUdsbUlISmxZMjl5WkM1a2FYTndkWFJsWDNadmJIVnRaUzV1WVhScGRtVWdQajBnWkdsemNIVjBaUzUwZUY5aGJXOTFiblF1Ym1GMGFYWmxPZ29nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ09ESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVEVLSUNBZ0lHUnBaeUEyQ2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQStQUW9nSUNBZ1lub2djbVZ6YjJ4MlpWOWthWE53ZFhSbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRRS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5EZzBDaUFnSUNBdkx5QnlaV052Y21RdVpHbHpjSFYwWlY5MmIyeDFiV1V1Ym1GMGFYWmxJQzBnWkdsemNIVjBaUzUwZUY5aGJXOTFiblF1Ym1GMGFYWmxDaUFnSUNCa2FXY2dPUW9nSUNBZ1pHbG5JRGtLSUNBZ0lDMEtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZORGd6TFRRNE5Rb2dJQ0FnTHk4Z2NtVmpiM0prTG1ScGMzQjFkR1ZmZG05c2RXMWxJRDBnWVhKak5DNVZTVzUwTmpRb0NpQWdJQ0F2THlBZ0lDQWdjbVZqYjNKa0xtUnBjM0IxZEdWZmRtOXNkVzFsTG01aGRHbDJaU0F0SUdScGMzQjFkR1V1ZEhoZllXMXZkVzUwTG01aGRHbDJaUW9nSUNBZ0x5OGdLUW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEZ3lDaUFnSUNCaWRYSjVJRE1LQ25KbGMyOXNkbVZmWkdsemNIVjBaVjloWm5SbGNsOXBabDlsYkhObFFERTBPZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8wT0RZdE5Ea3hDaUFnSUNBdkx5QWpJRk5sYm1RZ2MyeGhjMmhsWkNCbWRXNWtjeUIwYnlCMGFHVWdaR2x6Y0hWMFpXUWdZV2RsYm5RZ1lYTWdZMjl0Y0dWdWMyRjBhVzl1Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlaR2x6Y0hWMFpXUXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWE5zWVhOb1gyRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5VlVsdWREWTBLREV3TURBcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaR2xuSURFeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZORGcyTFRRNE53b2dJQ0FnTHk4Z0l5QlRaVzVrSUhOc1lYTm9aV1FnWm5WdVpITWdkRzhnZEdobElHUnBjM0IxZEdWa0lHRm5aVzUwSUdGeklHTnZiWEJsYm5OaGRHbHZiZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8wT1RBS0lDQWdJQzh2SUdabFpUMVZTVzUwTmpRb01UQXdNQ2tzQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVEF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5EZzJMVFE1TVFvZ0lDQWdMeThnSXlCVFpXNWtJSE5zWVhOb1pXUWdablZ1WkhNZ2RHOGdkR2hsSUdScGMzQjFkR1ZrSUdGblpXNTBJR0Z6SUdOdmJYQmxibk5oZEdsdmJnb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFdScGMzQjFkR1ZrTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxemJHRnphRjloYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNneE1EQXdLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCaUlISmxjMjlzZG1WZlpHbHpjSFYwWlY5aFpuUmxjbDlwWmw5bGJITmxRREUyQ2dvS0x5OGdZV2RsYm5ScFpDNUJaMlZ1ZEVsRVEyOXVkSEpoWTNRdVpXNWtiM0p6WlY5aFoyVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21WdVpHOXljMlZmWVdkbGJuUTZDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPalV3TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOVEV5Q2lBZ0lDQXZMeUJsYm1SdmNuTmxjaUE5SUZSNGJpNXpaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TlRFekNpQWdJQ0F2THlCbGJtUnZjbk5sWlY5aFkyTnZkVzUwSUQwZ1FXTmpiM1Z1ZENobGJtUnZjbk5sWlM1aWVYUmxjeWtLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUZrWkhKbGMzTWdiR1Z1WjNSb0lHbHpJRE15SUdKNWRHVnpDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPalV4TlFvZ0lDQWdMeThnWVhOelpYSjBJR1Z1Wkc5eWMyVnlJQ0U5SUdWdVpHOXljMlZsWDJGalkyOTFiblFzSUNKallXNXViM1FnYzJWc1ppMWxibVJ2Y25ObElnb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ013b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc1dWIzUWdjMlZzWmkxbGJtUnZjbk5sQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pVeE53b2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZV2RsYm5SekxtMWhlV0psS0dWdVpHOXljMlZ5S1ZzeFhTd2dJbVZ1Wkc5eWMyVnlJRzV2ZENCeVpXZHBjM1JsY21Wa0lnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWXhOamMxWmdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxibVJ2Y25ObGNpQnViM1FnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMU1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUZuWlc1MGN5NXRZWGxpWlNobGJtUnZjbk5sWlY5aFkyTnZkVzUwS1ZzeFhTd2dJbVZ1Wkc5eWMyVmxJRzV2ZENCeVpXZHBjM1JsY21Wa0lnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWXhOamMxWmdvZ0lDQWdaR2xuSURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxibVJ2Y25ObFpTQnViM1FnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMU1Ua0tJQ0FnSUM4dklHVnlYM0psWTI5eVpDQTlJSE5sYkdZdVlXZGxiblJ6TG0xaGVXSmxLR1Z1Wkc5eWMyVnlLVnN3WFM1amIzQjVLQ2tLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMU1qQUtJQ0FnSUM4dklHVmxYM0psWTI5eVpDQTlJSE5sYkdZdVlXZGxiblJ6TG0xaGVXSmxLR1Z1Wkc5eWMyVmxYMkZqWTI5MWJuUXBXekJkTG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzFNakl0TlRJekNpQWdJQ0F2THlBaklFTm9aV05ySUdWdVpHOXljMlZ5SUdseklGWmxjbWxtYVdWa0lIUnBaWElLSUNBZ0lDOHZJR1Z1Wkc5eWMyVnlYM05qYjNKbElEMGdaWEpmY21WamIzSmtMbU5oWTJobFpGOXpZMjl5WlM1dVlYUnBkbVVLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeE1qTWdPQW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBeE1qTUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPalV5TkFvZ0lDQWdMeThnWVhOelpYSjBJR1Z1Wkc5eWMyVnlYM05qYjNKbElENDlJRlZKYm5RMk5DaEZUa1JQVWxORlRVVk9WRjlOU1U1ZlUwTlBVa1VwTENBaVpXNWtiM0p6WlhJZ2JYVnpkQ0JpWlNCV1pYSnBabWxsWkNCMGFXVnlJZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURnd0NpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJR1Z1Wkc5eWMyVnlJRzExYzNRZ1ltVWdWbVZ5YVdacFpXUWdkR2xsY2dvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMU1qWXROVEkzQ2lBZ0lDQXZMeUFqSUZabGNtbG1lU0J6ZEdGclpTQndZWGx0Wlc1MENpQWdJQ0F2THlCd1lYbHRaVzUwSUQwZ2IzQXVSMVI0Ymk1aGJXOTFiblFvVkhodUxtZHliM1Z3WDJsdVpHVjRJQzBnTVNrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPalV5T0FvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUWdQajBnYzNSaGEyVmZZVzF2ZFc1MExtNWhkR2wyWlN3Z0luTjBZV3RsSUhCaGVXMWxiblFnYldsemJXRjBZMmdpQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QXhDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUhOMFlXdGxJSEJoZVcxbGJuUWdiV2x6YldGMFkyZ0tJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOVE13TFRVek1Rb2dJQ0FnTHk4Z0l5QkZibVJ2Y25ObGJXVnVkQ0JyWlhrZ1BTQmxibVJ2Y25ObGNsOWllWFJsY3lBcklHVnVaRzl5YzJWbFgySjVkR1Z6Q2lBZ0lDQXZMeUJsYm1SdmNuTmxiV1Z1ZEY5clpYa2dQU0JsYm1SdmNuTmxjaTVpZVhSbGN5QXJJR1Z1Wkc5eWMyVmxYMkZqWTI5MWJuUXVZbmwwWlhNS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOVE0yQ2lBZ0lDQXZMeUJ6ZEdGclpWOWhiVzkxYm5ROVlYSmpOQzVWU1c1ME5qUW9jR0Y1YldWdWRDa3NDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8xTXpnS0lDQWdJQzh2SUdWdVpHOXljMlZrWDJGMFgySnNiMk5yUFdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1eWIzVnVaQ2tzQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TlRNekxUVTBNQW9nSUNBZ0x5OGdaVzVrYjNKelpXMWxiblFnUFNCRmJtUnZjbk5sYldWdWRGSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQmxibVJ2Y25ObGNqMWhjbU0wTGtGa1pISmxjM01vWlc1a2IzSnpaWEl1WW5sMFpYTXBMQW9nSUNBZ0x5OGdJQ0FnSUdWdVpHOXljMlZsUFdGeVl6UXVRV1JrY21WemN5aGxibVJ2Y25ObFpWOWhZMk52ZFc1MExtSjVkR1Z6S1N3S0lDQWdJQzh2SUNBZ0lDQnpkR0ZyWlY5aGJXOTFiblE5WVhKak5DNVZTVzUwTmpRb2NHRjViV1Z1ZENrc0NpQWdJQ0F2THlBZ0lDQWdaVzVrYjNKelpYSmZjMk52Y21WZllYUmZkR2x0WlQxaGNtTTBMbFZKYm5RMk5DaGxibVJ2Y25ObGNsOXpZMjl5WlNrc0NpQWdJQ0F2THlBZ0lDQWdaVzVrYjNKelpXUmZZWFJmWW14dlkyczlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbkp2ZFc1a0tTd0tJQ0FnSUM4dklDQWdJQ0JoWTNScGRtVTlZWEpqTkM1Q2IyOXNLRlJ5ZFdVcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qVXpPUW9nSUNBZ0x5OGdZV04wYVhabFBXRnlZelF1UW05dmJDaFVjblZsS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnd0NpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qVXpNeTAxTkRBS0lDQWdJQzh2SUdWdVpHOXljMlZ0Wlc1MElEMGdSVzVrYjNKelpXMWxiblJTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnWlc1a2IzSnpaWEk5WVhKak5DNUJaR1J5WlhOektHVnVaRzl5YzJWeUxtSjVkR1Z6S1N3S0lDQWdJQzh2SUNBZ0lDQmxibVJ2Y25ObFpUMWhjbU0wTGtGa1pISmxjM01vWlc1a2IzSnpaV1ZmWVdOamIzVnVkQzVpZVhSbGN5a3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGEyVmZZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLSEJoZVcxbGJuUXBMQW9nSUNBZ0x5OGdJQ0FnSUdWdVpHOXljMlZ5WDNOamIzSmxYMkYwWDNScGJXVTlZWEpqTkM1VlNXNTBOalFvWlc1a2IzSnpaWEpmYzJOdmNtVXBMQW9nSUNBZ0x5OGdJQ0FnSUdWdVpHOXljMlZrWDJGMFgySnNiMk5yUFdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1eWIzVnVaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lXTjBhWFpsUFdGeVl6UXVRbTl2YkNoVWNuVmxLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMU5ERUtJQ0FnSUM4dklITmxiR1l1Wlc1a2IzSnpaVzFsYm5SelcyVnVaRzl5YzJWdFpXNTBYMnRsZVYwZ1BTQmxibVJ2Y25ObGJXVnVkQzVqYjNCNUtDa0tJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TlRRekxUVTBOUW9nSUNBZ0x5OGdJeUJWY0dSaGRHVWdaVzVrYjNKelpXVW5jeUJoWjJkeVpXZGhkR1VnWlc1a2IzSnpaVzFsYm5RZ2MyTnZjbVVLSUNBZ0lDOHZJQ01nWlc1a2IzSnpaVzFsYm5SZmMyTnZjbVVnS3owZ0tITjBZV3RsSUNvZ1pXNWtiM0p6WlhKZmMyTnZjbVVnTHlBeE1EQXBJQzhnTVY4d01EQmZNREF3SUNodWIzSnRZV3hwZW1Wa0tRb2dJQ0FnTHk4Z1kyOXVkSEpwWW5WMGFXOXVJRDBnS0hCaGVXMWxiblFnS2lCbGJtUnZjbk5sY2w5elkyOXlaU2tnTHk4Z1ZVbHVkRFkwS0RFd01Da0tJQ0FnSUNvS0lDQWdJR2x1ZEdOZk15QXZMeUF4TURBS0lDQWdJQzhLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TlRRM0NpQWdJQ0F2THlCbFpWOXlaV052Y21RdVpXNWtiM0p6WlcxbGJuUmZjMk52Y21VdWJtRjBhWFpsSUNzZ1kyOXVkSEpwWW5WMGFXOXVDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBMk5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUNzS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5UUTJMVFUwT0FvZ0lDQWdMeThnWldWZmNtVmpiM0prTG1WdVpHOXljMlZ0Wlc1MFgzTmpiM0psSUQwZ1lYSmpOQzVWU1c1ME5qUW9DaUFnSUNBdkx5QWdJQ0FnWldWZmNtVmpiM0prTG1WdVpHOXljMlZ0Wlc1MFgzTmpiM0psTG01aGRHbDJaU0FySUdOdmJuUnlhV0oxZEdsdmJnb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQTJOZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8xTkRrS0lDQWdJQzh2SUdWbFgzSmxZMjl5WkM1elkyOXlaVjlqWVdOb1pXUmZZWFJmWW14dlkyc2dQU0JoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSEpsY0d4aFkyVXlJREV6TVFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMU5UQUtJQ0FnSUM4dklITmxiR1l1WVdkbGJuUnpXMlZ1Wkc5eWMyVmxYMkZqWTI5MWJuUmRJRDBnWldWZmNtVmpiM0prTG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzFNREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdGblpXNTBhV1F1UVdkbGJuUkpSRU52Ym5SeVlXTjBMbk5sZEY5ellXNWtZbTk0WDJObGNuUnBabWxsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjl6WVc1a1ltOTRYMk5sY25ScFptbGxaRG9LSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TlRVMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8xTmpZS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1YzJGdVpHSnZlRjloZFhSb2IzSnBkSGt1ZG1Gc2RXVXNJQ0p6WVc1a1ltOTRJR0YxZEdodmNtbDBlU0J2Ym14NUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbk5oYm1SaWIzaGZZWFYwYUc5eWFYUjVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OaGJtUmliM2hmWVhWMGFHOXlhWFI1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCellXNWtZbTk0SUdGMWRHaHZjbWwwZVNCdmJteDVDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPalUyT0FvZ0lDQWdMeThnWVdkbGJuUmZZV05qYjNWdWRDQTlJRUZqWTI5MWJuUW9ZV2RsYm5RdVlubDBaWE1wQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWkdSeVpYTnpJR3hsYm1kMGFDQnBjeUF6TWlCaWVYUmxjd29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8xTmprS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtRm5aVzUwY3k1dFlYbGlaU2hoWjJWdWRGOWhZMk52ZFc1MEtWc3hYU3dnSW1GblpXNTBJRzV2ZENCeVpXZHBjM1JsY21Wa0lnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWXhOamMxWmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnWVdkbGJuUWdibTkwSUhKbFoybHpkR1Z5WldRS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5UY3dDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1GblpXNTBjeTV0WVhsaVpTaGhaMlZ1ZEY5aFkyTnZkVzUwS1Zzd1hTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qVTNNUW9nSUNBZ0x5OGdjbVZqYjNKa0xuTmhibVJpYjNoZmMyTmxibUZ5YVc5elgzQmhjM05sWkNBOUlITmpaVzVoY21sdmMxOXdZWE56WldRS0lDQWdJR1JwWnlBeUNpQWdJQ0J5WlhCc1lXTmxNaUE1T0FvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMU56TUtJQ0FnSUM4dklITmpaVzVoY21sdmMxOXdZWE56WldRdWJtRjBhWFpsSUQ0OUlGVkpiblEyTkNoVFFVNUVRazlZWDBaVlRFeGZRMFZTVkY5VFEwVk9RVkpKVDFNcENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSjBiMmtLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnUGowS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5UY3lMVFUzTkFvZ0lDQWdMeThnY21WamIzSmtMbk5oYm1SaWIzaGZZMlZ5ZEdsbWFXVmtJRDBnWVhKak5DNUNiMjlzS0FvZ0lDQWdMeThnSUNBZ0lITmpaVzVoY21sdmMxOXdZWE56WldRdWJtRjBhWFpsSUQ0OUlGVkpiblEyTkNoVFFVNUVRazlZWDBaVlRFeGZRMFZTVkY5VFEwVk9RVkpKVDFNcENpQWdJQ0F2THlBcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdhVzUwWXlBMklDOHZJRGcwT0FvZ0lDQWdjM2RoY0FvZ0lDQWdjMlYwWW1sMENpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qVTNOUW9nSUNBZ0x5OGdjbVZqYjNKa0xuTmpiM0psWDJOaFkyaGxaRjloZEY5aWJHOWpheUE5SUdGeVl6UXVWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnY21Wd2JHRmpaVElnTVRNeENpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qVTNOZ29nSUNBZ0x5OGdjMlZzWmk1aFoyVnVkSE5iWVdkbGJuUmZZV05qYjNWdWRGMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pVMU5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZV2RsYm5ScFpDNUJaMlZ1ZEVsRVEyOXVkSEpoWTNRdWMyVjBYMlYxY205ZllYUjBaWE4wWVhScGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZlpYVnliMTloZEhSbGMzUmhkR2x2YmpvS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5UZ3lDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pVNE9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1bGRYSnZYMjl5WVdOc1pTNTJZV3gxWlN3Z0ltVjFjbThnYjNKaFkyeGxJRzl1YkhraUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlaWFZ5YjE5dmNtRmpiR1VpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpYVnliMTl2Y21GamJHVWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1YxY204Z2IzSmhZMnhsSUc5dWJIa0tJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOVGt3Q2lBZ0lDQXZMeUJoWjJWdWRGOWhZMk52ZFc1MElEMGdRV05qYjNWdWRDaGhaMlZ1ZEM1aWVYUmxjeWtLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlpHUnlaWE56SUd4bGJtZDBhQ0JwY3lBek1pQmllWFJsY3dvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMU9URUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUZuWlc1MGN5NXRZWGxpWlNoaFoyVnVkRjloWTJOdmRXNTBLVnN4WFN3Z0ltRm5aVzUwSUc1dmRDQnlaV2RwYzNSbGNtVmtJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFl4TmpjMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJR0ZuWlc1MElHNXZkQ0J5WldkcGMzUmxjbVZrQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pVNU1nb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTVoWjJWdWRITXViV0Y1WW1Vb1lXZGxiblJmWVdOamIzVnVkQ2xiTUYwdVkyOXdlU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMU9UTUtJQ0FnSUM4dklISmxZMjl5WkM1bGRYSnZYMkYwZEdWemRHVmtJRDBnWVhKak5DNUNiMjlzS0ZSeWRXVXBDaUFnSUNCd2RYTm9hVzUwSURnME9Rb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSE5sZEdKcGRBb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzFPVFFLSUNBZ0lDOHZJSEpsWTI5eVpDNXpZMjl5WlY5allXTm9aV1JmWVhSZllteHZZMnNnUFNCaGNtTTBMbFZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhKbGNHeGhZMlV5SURFek1Rb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzFPVFVLSUNBZ0lDOHZJSE5sYkdZdVlXZGxiblJ6VzJGblpXNTBYMkZqWTI5MWJuUmRJRDBnY21WamIzSmtMbU52Y0hrb0tRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMU9ESUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR0ZuWlc1MGFXUXVRV2RsYm5SSlJFTnZiblJ5WVdOMExtZGxibVZ6YVhOZmFXNXBkR2xoYkdsNlpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsYm1WemFYTmZhVzVwZEdsaGJHbDZaVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPall3TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pZeE13b2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTd2dJbUZrYldsdUlHOXViSGtpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdGa2JXbHVJRzl1YkhrS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5qRTBDaUFnSUNBdkx5QmxlSEJwY25rZ1BTQkhiRzlpWVd3dWNtOTFibVFnS3lCVlNXNTBOalFvUjBWT1JWTkpVMTlFUlVOQldWOUNURTlEUzFNcENpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2x1ZEdNZ09DQXZMeUF5TURBd01EQUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2dwblpXNWxjMmx6WDJsdWFYUnBZV3hwZW1WZlptOXlYMkp2WkhsQU1qb0tJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOakUzQ2lBZ0lDQXZMeUJ0WlcxaVpYSWdQU0JCWTJOdmRXNTBLRzFsYldKbGNsOWhaR1J5TG1KNWRHVnpLUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWkdSeVpYTnpJR3hsYm1kMGFDQnBjeUF6TWlCaWVYUmxjd29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8yTVRnS0lDQWdJQzh2SUdsbUlITmxiR1l1WVdkbGJuUnpMbTFoZVdKbEtHMWxiV0psY2lsYk1WMDZDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROakUyTnpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTJDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdkbGJtVnphWE5mYVc1cGRHbGhiR2w2WlY5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TmpFNUNpQWdJQ0F2THlCeVpXTnZjbVFnUFNCelpXeG1MbUZuWlc1MGN5NXRZWGxpWlNodFpXMWlaWElwV3pCZExtTnZjSGtvS1FvZ0lDQWdaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qWXlNQW9nSUNBZ0x5OGdjbVZqYjNKa0xtZGxibVZ6YVhOZmMyTnZjbVVnUFNCaGNtTTBMbFZKYm5RMk5DaEhSVTVGVTBsVFgxTkRUMUpGS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXpNZ29nSUNBZ2NtVndiR0ZqWlRJZ01UQTNDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPall5TVFvZ0lDQWdMeThnY21WamIzSmtMbWRsYm1WemFYTmZaWGh3YVhKNVgySnNiMk5ySUQwZ1lYSmpOQzVWU1c1ME5qUW9aWGh3YVhKNUtRb2dJQ0FnWkdsbklETUtJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURFeE5Rb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzJNaklLSUNBZ0lDOHZJSEpsWTI5eVpDNXpZMjl5WlY5allXTm9aV1JmWVhSZllteHZZMnNnUFNCaGNtTTBMbFZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhKbGNHeGhZMlV5SURFek1Rb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzJNak1LSUNBZ0lDOHZJSE5sYkdZdVlXZGxiblJ6VzIxbGJXSmxjbDBnUFNCeVpXTnZjbVF1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENncG5aVzVsYzJselgybHVhWFJwWVd4cGVtVmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzJNVFlLSUNBZ0lDOHZJR1p2Y2lCdFpXMWlaWEpmWVdSa2NpQnBiaUFvYldWdFltVnlNU3dnYldWdFltVnlNaXdnYldWdFltVnlNeWs2Q2lBZ0lDQmtkWEFLSUNBZ0lITjNhWFJqYUNCblpXNWxjMmx6WDJsdWFYUnBZV3hwZW1WZlptOXlYMmhsWVdSbGNsOHhRRFlnWjJWdVpYTnBjMTlwYm1sMGFXRnNhWHBsWDJadmNsOW9aV0ZrWlhKZk1rQTNDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPall3TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BuWlc1bGMybHpYMmx1YVhScFlXeHBlbVZmWm05eVgyaGxZV1JsY2w4eVFEYzZDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWkdsbklESUtJQ0FnSUdJZ1oyVnVaWE5wYzE5cGJtbDBhV0ZzYVhwbFgyWnZjbDlpYjJSNVFESUtDbWRsYm1WemFYTmZhVzVwZEdsaGJHbDZaVjltYjNKZmFHVmhaR1Z5WHpGQU5qb0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdScFp5QXpDaUFnSUNCaUlHZGxibVZ6YVhOZmFXNXBkR2xoYkdsNlpWOW1iM0pmWW05a2VVQXlDZ29LTHk4Z1lXZGxiblJwWkM1QloyVnVkRWxFUTI5dWRISmhZM1F1ZFhCa1lYUmxYMkZrYldsdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkWEJrWVhSbFgyRmtiV2x1T2dvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMk1qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TmpJNENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1Ga2JXbHVMblpoYkhWbExDQWlZV1J0YVc0Z2IyNXNlU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFpHMXBiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWVdSdGFXNGdiMjVzZVFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMk1qa0tJQ0FnSUM4dklITmxiR1l1WVdSdGFXNHVkbUZzZFdVZ1BTQkJZMk52ZFc1MEtHNWxkMTloWkcxcGJpNWllWFJsY3lrS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaR1J5WlhOeklHeGxibWQwYUNCcGN5QXpNaUJpZVhSbGN3b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVlXUnRhVzRpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMk1qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR0ZuWlc1MGFXUXVRV2RsYm5SSlJFTnZiblJ5WVdOMExuVndaR0YwWlY5bGRYSnZYMjl5WVdOc1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ3WkdGMFpWOWxkWEp2WDI5eVlXTnNaVG9LSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TmpNeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPall6TkFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVoWkcxcGJpNTJZV3gxWlN3Z0ltRmtiV2x1SUc5dWJIa2lDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR0ZrYldsdUlHOXViSGtLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TmpNMUNpQWdJQ0F2THlCelpXeG1MbVYxY205ZmIzSmhZMnhsTG5aaGJIVmxJRDBnUVdOamIzVnVkQ2h1WlhkZmIzSmhZMnhsTG1KNWRHVnpLUW9nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGa1pISmxjM01nYkdWdVozUm9JR2x6SURNeUlHSjVkR1Z6Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0psZFhKdlgyOXlZV05zWlNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qWXpNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWVdkbGJuUnBaQzVCWjJWdWRFbEVRMjl1ZEhKaFkzUXVYMk52YlhCMWRHVmZjMk52Y21Vb2NtVmpiM0prT2lCaWVYUmxjeXdnWTNWeWNtVnVkRjlpYkc5amF6b2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCaWVYUmxjem9LWDJOdmJYQjFkR1ZmYzJOdmNtVTZDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPalkwTVMwMk5EWUtJQ0FnSUM4dklFQnpkV0p5YjNWMGFXNWxDaUFnSUNBdkx5QmtaV1lnWDJOdmJYQjFkR1ZmYzJOdmNtVW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd0tJQ0FnSUM4dklDQWdJQ0J5WldOdmNtUTZJRUZuWlc1MFVtVmpiM0prTEFvZ0lDQWdMeThnSUNBZ0lHTjFjbkpsYm5SZllteHZZMnM2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ2tnTFQ0Z2RIVndiR1ZiVlVsdWREWTBMQ0JWU1c1ME5qUXNJRlZKYm5RMk5Dd2dWVWx1ZERZMExDQlZTVzUwTmpRc0lGVkpiblEyTkYwNkNpQWdJQ0J3Y205MGJ5QXlJRGNLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1pIVndiaUF4TkFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMk5UTUtJQ0FnSUM4dklHUmxibTl0TVNBOUlISmxZMjl5WkM1elpYUjBiR1Z0Wlc1MFgyTnZkVzUwTG01aGRHbDJaU0FySUZWSmJuUTJOQ2d4S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TmpVMENpQWdJQ0F2THlCek1TQTlJQ2h5WldOdmNtUXVZMjl1Wm1seWJXVmtYM05sZEhSc1pXMWxiblJ6TG01aGRHbDJaU0FxSUZWSmJuUTJOQ2d4TURBcEtTQXZMeUJrWlc1dmJURUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUF4TURBS0lDQWdJQ29LSUNBZ0lITjNZWEFLSUNBZ0lDOEtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOalUyTFRZMU9Rb2dJQ0FnTHk4Z0l5QXRMUzBnVTJsbmJtRnNJREk2SUVOdmRXNTBaWEp3WVhKMGVTQkVhWFpsY25OcGRIa2dLREl3SlNrZ0xTMHRDaUFnSUNBdkx5QWpJRk52Wm5RdFkyRndJR0YwSUUxQldGOUVTVlpGVWxOSlZGbGZRMDlWVGxSRlVsQkJVbFJKUlZNZ2QybDBhQ0J6Y1hWaGNtVXRjbTl2ZENCelkyRnNhVzVuQ2lBZ0lDQXZMeUFqSUhOamIzSmxJRDBnYldsdUtERXdNQ3dnYzNGeWRDaDFibWx4ZFdVcElDb2dNVEFwSUNEaWhwSWdNVEF3SUhWdWFYRjFaU0RpaHBJZ2MyTnZjbVVnTVRBd0NpQWdJQ0F2THlCMWJtbHhkV1VnUFNCeVpXTnZjbVF1ZFc1cGNYVmxYMk52ZFc1MFpYSndZWEowZVY5amIzVnVkQzV1WVhScGRtVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHbHVkQ0F5TmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMk5qQUtJQ0FnSUM4dklHbG1JSFZ1YVhGMVpTQStJRlZKYm5RMk5DaE5RVmhmUkVsV1JWSlRTVlJaWDBOUFZVNVVSVkpRUVZKVVNVVlRLVG9LSUNBZ0lHbHVkR05mTXlBdkx5QXhNREFLSUNBZ0lENEtJQ0FnSUdKNklGOWpiMjF3ZFhSbFgzTmpiM0psWDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8yTmpFS0lDQWdJQzh2SUhWdWFYRjFaU0E5SUZWSmJuUTJOQ2hOUVZoZlJFbFdSVkpUU1ZSWlgwTlBWVTVVUlZKUVFWSlVTVVZUS1FvZ0lDQWdhVzUwWTE4eklDOHZJREV3TUFvZ0lDQWdabkpoYldWZlluVnllU0F4T0FvS1gyTnZiWEIxZEdWZmMyTnZjbVZmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG80TWpJS0lDQWdJQzh2SUdsbUlHNGdQVDBnVlVsdWREWTBLREFwT2dvZ0lDQWdabkpoYldWZlpHbG5JREU0Q2lBZ0lDQmlibm9nWDJOdmJYQjFkR1ZmYzJOdmNtVmZZV1owWlhKZmFXWmZaV3h6WlVBek9Rb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzRNak1LSUNBZ0lDOHZJSEpsZEhWeWJpQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NncGZZMjl0Y0hWMFpWOXpZMjl5WlY5aFpuUmxjbDlwYm14cGJtVmtYMkZuWlc1MGFXUXVRV2RsYm5SSlJFTnZiblJ5WVdOMExsOXBjM0Z5ZEVBME1qb0tJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOall5TFRZMk13b2dJQ0FnTHk4Z0l5QkpiblJsWjJWeUlITnhjblFnWVhCd2NtOTRhVzFoZEdsdmJqb2dhWE54Y25Rb2VDa2dkbWxoSUU1bGQzUnZiaWR6SUcxbGRHaHZaQW9nSUNBZ0x5OGdjeklnUFNCelpXeG1MbDlwYzNGeWRDaDFibWx4ZFdVcElDb2dWVWx1ZERZMEtERXdLUW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnS2dvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFlLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TmpZMENpQWdJQ0F2THlCcFppQnpNaUErSUZWSmJuUTJOQ2d4TURBcE9nb2dJQ0FnYVc1MFkxOHpJQzh2SURFd01Bb2dJQ0FnUGdvZ0lDQWdZbm9nWDJOdmJYQjFkR1ZmYzJOdmNtVmZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qWTJOUW9nSUNBZ0x5OGdjeklnUFNCVlNXNTBOalFvTVRBd0tRb2dJQ0FnYVc1MFkxOHpJQzh2SURFd01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMkNncGZZMjl0Y0hWMFpWOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pZMk55MDJOekFLSUNBZ0lDOHZJQ01nTFMwdElGTnBaMjVoYkNBek9pQlVhVzFsTFZkbGFXZG9kR1ZrSUVGamRHbDJhWFI1SUNneU1DVXBJQzB0TFFvZ0lDQWdMeThnSXlCUVpXNWhiR2x6WlNCc2IyNW5JR2x1WVdOMGFYWnBkSGt1SUVaMWJHd2djMk52Y21VZ2FXWWdZV04wYVhabElHbHVJR3hoYzNRZ01UUTBNQ0JpYkc5amEzTXVDaUFnSUNBdkx5QWpJRk5qYjNKbElHUmxZMkY1Y3lCc2FXNWxZWEpzZVNCMGJ5QXdJR0YwSUVSRlEwRlpYMGhCVEVaZlRFbEdSVjlFUVZsVElDb2dRa3hQUTB0VFgxQkZVbDlUUTA5U1NVNUhYMFJCV1M0S0lDQWdJQzh2SUdKc2IyTnJjMTl6YVc1alpWOWhZM1JwZG1sMGVTQTlJR04xY25KbGJuUmZZbXh2WTJzZ0xTQnlaV052Y21RdWJHRnpkRjkxY0dSaGRHVmZZbXh2WTJzdWJtRjBhWFpsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIQjFjMmhwYm5RZ05ESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOM1lYQUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pZM01Rb2dJQ0FnTHk4Z2JXRjRYMmxrYkdVZ1BTQlZTVzUwTmpRb1JFVkRRVmxmU0VGTVJsOU1TVVpGWDBSQldWTWdLaUJDVEU5RFMxTmZVRVZTWDFORFQxSkpUa2RmUkVGWktRb2dJQ0FnYVc1MFl5QTNJQzh2SURFd01EZ3dNQW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8yTnpJS0lDQWdJQzh2SUdsbUlHSnNiMk5yYzE5emFXNWpaVjloWTNScGRtbDBlU0ErUFNCdFlYaGZhV1JzWlRvS0lDQWdJRDQ5Q2lBZ0lDQmllaUJmWTI5dGNIVjBaVjl6WTI5eVpWOWxiSE5sWDJKdlpIbEFOZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8yTnpNS0lDQWdJQzh2SUhNeklEMGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBM0NncGZZMjl0Y0hWMFpWOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRRGM2Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pZM055MDJOemdLSUNBZ0lDOHZJQ01nUVdSa2FYUnBiMjVoYkd4NUlHWmhZM1J2Y2lCcGJpQjBhVzFsTFhkbGFXZG9kR1ZrSUhadmJIVnRaU0JtYjNJZ1lXZGxiblJ6SUhkcGRHZ2djbVZoYkNCb2FYTjBiM0o1Q2lBZ0lDQXZMeUJwWmlCeVpXTnZjbVF1ZEdsdFpWOTNaV2xuYUhSbFpGOTJiMngxYldVdWJtRjBhWFpsSUQ0Z1ZVbHVkRFkwS0RBcElHRnVaQ0J5WldOdmNtUXVkRzkwWVd4ZmRtOXNkVzFsTG01aGRHbDJaU0ErSUZWSmJuUTJOQ2d3S1RvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdsdWRDQXpOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhNQW9nSUNBZ1lub2dYMk52YlhCMWRHVmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQndkWE5vYVc1MElERTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlERXhDaUFnSUNCaWVpQmZZMjl0Y0hWMFpWOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pZM09Rb2dJQ0FnTHk4Z2RIZGZjbUYwYVc4Z1BTQW9jbVZqYjNKa0xuUnBiV1ZmZDJWcFoyaDBaV1JmZG05c2RXMWxMbTVoZEdsMlpTQXFJRlZKYm5RMk5DZ3hNREFwS1NBdkx5QW9DaUFnSUNCbWNtRnRaVjlrYVdjZ01UQUtJQ0FnSUdsdWRHTmZNeUF2THlBeE1EQUtJQ0FnSUNvS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5qZ3dDaUFnSUNBdkx5QnlaV052Y21RdWRHOTBZV3hmZG05c2RXMWxMbTVoZEdsMlpTQXFJRlZKYm5RMk5DZ3hNREF3S1NBcklGVkpiblEyTkNneEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURFeENpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOamM1TFRZNE1Rb2dJQ0FnTHk4Z2RIZGZjbUYwYVc4Z1BTQW9jbVZqYjNKa0xuUnBiV1ZmZDJWcFoyaDBaV1JmZG05c2RXMWxMbTVoZEdsMlpTQXFJRlZKYm5RMk5DZ3hNREFwS1NBdkx5QW9DaUFnSUNBdkx5QWdJQ0FnY21WamIzSmtMblJ2ZEdGc1gzWnZiSFZ0WlM1dVlYUnBkbVVnS2lCVlNXNTBOalFvTVRBd01Da2dLeUJWU1c1ME5qUW9NU2tLSUNBZ0lDOHZJQ2tLSUNBZ0lDOEtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeE5Bb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzJPRElLSUNBZ0lDOHZJR2xtSUhSM1gzSmhkR2x2SUQ0Z1ZVbHVkRFkwS0RFd01DazZDaUFnSUNCcGJuUmpYek1nTHk4Z01UQXdDaUFnSUNBK0NpQWdJQ0JpZWlCZlkyOXRjSFYwWlY5elkyOXlaVjloWm5SbGNsOXBabDlsYkhObFFERXhDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPalk0TXdvZ0lDQWdMeThnZEhkZmNtRjBhVzhnUFNCVlNXNTBOalFvTVRBd0tRb2dJQ0FnYVc1MFkxOHpJQzh2SURFd01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeE5Bb0tYMk52YlhCMWRHVmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUF4TVRvS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5qZzBMVFk0TlFvZ0lDQWdMeThnSXlCQ2JHVnVaRG9nTnpBbElISmxZMlZ1WTNrZ2MyTnZjbVVnS3lBek1DVWdkbTlzZFcxbElHTnZibk5wYzNSbGJtTjVDaUFnSUNBdkx5QnpNeUE5SUNoek15QXFJRlZKYm5RMk5DZzNNQ2tnS3lCMGQxOXlZWFJwYnlBcUlGVkpiblEyTkNnek1Da3BJQzh2SUZWSmJuUTJOQ2d4TURBcENpQWdJQ0JtY21GdFpWOWthV2NnTndvZ0lDQWdjSFZ6YUdsdWRDQTNNQW9nSUNBZ0tnb2dJQ0FnWm5KaGJXVmZaR2xuSURFMENpQWdJQ0J3ZFhOb2FXNTBJRE13Q2lBZ0lDQXFDaUFnSUNBckNpQWdJQ0JwYm5Salh6TWdMeThnTVRBd0NpQWdJQ0F2Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRGNLQ2w5amIyMXdkWFJsWDNOamIzSmxYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPalk1TVFvZ0lDQWdMeThnWlhNZ1BTQnlaV052Y21RdVpXNWtiM0p6WlcxbGJuUmZjMk52Y21VdWJtRjBhWFpsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIQjFjMmhwYm5RZ05qWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzJPRGN0Tmprd0NpQWdJQ0F2THlBaklDMHRMU0JUYVdkdVlXd2dORG9nVTNSaGEyVXRWMlZwWjJoMFpXUWdSVzVrYjNKelpXMWxiblFnS0RJd0pTa2dMUzB0Q2lBZ0lDQXZMeUFqSUdWdVpHOXljMlZ0Wlc1MFgzTmpiM0psSUhOMGIzSmxaQ0JoY3lCemRXMG9jM1JoYTJVZ0tpQmxibVJ2Y25ObGNsOXpZMjl5WlNBdklERXdNQ2tLSUNBZ0lDOHZJQ01nVG05eWJXRnNhWHBsSUhSdklERGlnSk14TURBNklHTmhjQ0JoZENBeE1EQmZNREF3WHpBd01DQW9QU0F4TURBd0lFRk1SMDhndzVjZ2MyTnZjbVVnTVRBd0tRb2dJQ0FnTHk4Z2JXRjRYMlZ1Wkc5eWMyVnRaVzUwSUQwZ1ZVbHVkRFkwS0RFd01GOHdNREJmTURBd1h6QXdNQ2tnSUNNZ01UQXdMREF3TUNCQlRFZFBJR0YwSUcxaGVDQnpZMjl5WlFvZ0lDQWdhVzUwWXlBNUlDOHZJREV3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMk9USUtJQ0FnSUM4dklHbG1JR1Z6SUQ0OUlHMWhlRjlsYm1SdmNuTmxiV1Z1ZERvS0lDQWdJRDQ5Q2lBZ0lDQmllaUJmWTI5dGNIVjBaVjl6WTI5eVpWOWxiSE5sWDJKdlpIbEFNVFFLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TmprekNpQWdJQ0F2THlCek5DQTlJRlZKYm5RMk5DZ3hNREFwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRGdLQ2w5amIyMXdkWFJsWDNOamIzSmxYMkZtZEdWeVgybG1YMlZzYzJWQU1UVTZDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPalk1TnkwMk9Ua0tJQ0FnSUM4dklDTWdMUzB0SUZOcFoyNWhiQ0ExT2lCRWFYTndkWFJsSUZKaGRHbHZJQ2d4TUNVcElDMHRMUW9nSUNBZ0x5OGdJeUJUWTI5eVpTQmtaV055WldGelpYTWdjSEp2Y0c5eWRHbHZibUZzYkhrZ2QybDBhQ0JrYVhOd2RYUmxJSEpoZEdVS0lDQWdJQzh2SUhNMUlEMGdWVWx1ZERZMEtERXdNQ2tLSUNBZ0lHbHVkR05mTXlBdkx5QXhNREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dPUW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8zTURBS0lDQWdJQzh2SUdsbUlISmxZMjl5WkM1a2FYTndkWFJsWDJOdmRXNTBMbTVoZEdsMlpTQStJRlZKYm5RMk5DZ3dLU0JoYm1RZ2NtVmpiM0prTG5ObGRIUnNaVzFsYm5SZlkyOTFiblF1Ym1GMGFYWmxJRDRnVlVsdWREWTBLREFwT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQndkWE5vYVc1MElEYzBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlERXlDaUFnSUNCaWVpQmZZMjl0Y0hWMFpWOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRREl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVFVLSUNBZ0lHSjZJRjlqYjIxd2RYUmxYM05qYjNKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpBS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk56QXhMVGN3TWdvZ0lDQWdMeThnSXlCU2RXeGxJRUk2SUdScGMzQjFkR1VnZDJWcFoyaDBJRDBnWkdsemNIVjBaVjloYlc5MWJuUWdMeUIwYjNSaGJGOTJiMngxYldVZ0tHTmhjSEJsWkNCaGRDQXhLUW9nSUNBZ0x5OGdaR2x6Y0hWMFpWOXlZWFJwYnlBOUlDaHlaV052Y21RdVpHbHpjSFYwWlY5MmIyeDFiV1V1Ym1GMGFYWmxJQ29nVlVsdWREWTBLREV3TUNrcElDOHZJQ2dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR2x1ZENBNE1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBeE1EQUtJQ0FnSUNvS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk56QXpDaUFnSUNBdkx5QnlaV052Y21RdWRHOTBZV3hmZG05c2RXMWxMbTVoZEdsMlpTQXJJRlZKYm5RMk5DZ3hLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCd2RYTm9hVzUwSURFNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TnpBeExUY3dOQW9nSUNBZ0x5OGdJeUJTZFd4bElFSTZJR1JwYzNCMWRHVWdkMlZwWjJoMElEMGdaR2x6Y0hWMFpWOWhiVzkxYm5RZ0x5QjBiM1JoYkY5MmIyeDFiV1VnS0dOaGNIQmxaQ0JoZENBeEtRb2dJQ0FnTHk4Z1pHbHpjSFYwWlY5eVlYUnBieUE5SUNoeVpXTnZjbVF1WkdsemNIVjBaVjkyYjJ4MWJXVXVibUYwYVhabElDb2dWVWx1ZERZMEtERXdNQ2twSUM4dklDZ0tJQ0FnSUM4dklDQWdJQ0J5WldOdmNtUXVkRzkwWVd4ZmRtOXNkVzFsTG01aGRHbDJaU0FySUZWSmJuUTJOQ2d4S1FvZ0lDQWdMeThnS1FvZ0lDQWdMd29nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOekExQ2lBZ0lDQXZMeUJwWmlCa2FYTndkWFJsWDNKaGRHbHZJRDRnVlVsdWREWTBLREV3TUNrNkNpQWdJQ0JwYm5Salh6TWdMeThnTVRBd0NpQWdJQ0ErQ2lBZ0lDQmllaUJmWTI5dGNIVjBaVjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURFNUNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qY3dOZ29nSUNBZ0x5OGdaR2x6Y0hWMFpWOXlZWFJwYnlBOUlGVkpiblEyTkNneE1EQXBDaUFnSUNCcGJuUmpYek1nTHk4Z01UQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtDbDlqYjIxd2RYUmxYM05qYjNKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRrNkNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qY3dOd29nSUNBZ0x5OGdjelVnUFNCVlNXNTBOalFvTVRBd0tTQXRJR1JwYzNCMWRHVmZjbUYwYVc4S0lDQWdJR2x1ZEdOZk15QXZMeUF4TURBS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQXRDaUFnSUNCbWNtRnRaVjlpZFhKNUlEa0tDbDlqYjIxd2RYUmxYM05qYjNKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpBNkNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qY3dPUzAzTVRBS0lDQWdJQzh2SUNNZ1IyVnVaWE5wY3lCelkyOXlaU0JqYjI1MGNtbGlkWFJwYjI0Z0tHUmxZMkY1Y3lCdmRtVnlJRWRGVGtWVFNWTmZSRVZEUVZsZlFreFBRMHRUS1FvZ0lDQWdMeThnWjJWdVpYTnBjMTlpYjI1MWN5QTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzNNVEVLSUNBZ0lDOHZJR2xtSUhKbFkyOXlaQzVuWlc1bGMybHpYM05qYjNKbExtNWhkR2wyWlNBK0lGVkpiblEyTkNnd0tTQmhibVFnY21WamIzSmtMbWRsYm1WemFYTmZaWGh3YVhKNVgySnNiMk5yTG01aGRHbDJaU0ErSUdOMWNuSmxiblJmWW14dlkyczZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhCMWMyaHBiblFnTVRBM0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURVS0lDQWdJR0o2SUY5amIyMXdkWFJsWDNOamIzSmxYMkZtZEdWeVgybG1YMlZzYzJWQU1qVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHbHVkQ0F4TVRVS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQZ29nSUNBZ1lub2dYMk52YlhCMWRHVmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUF5TlFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvM01USUtJQ0FnSUM4dklHSnNiMk5yYzE5c1pXWjBJRDBnY21WamIzSmtMbWRsYm1WemFYTmZaWGh3YVhKNVgySnNiMk5yTG01aGRHbDJaU0F0SUdOMWNuSmxiblJmWW14dlkyc0tJQ0FnSUdaeVlXMWxYMlJwWnlBeE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F0Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pjeE13b2dJQ0FnTHk4Z1oyVnVaWE5wYzE5aWIyNTFjeUE5SUNoeVpXTnZjbVF1WjJWdVpYTnBjMTl6WTI5eVpTNXVZWFJwZG1VZ0tpQmliRzlqYTNOZmJHVm1kQ2tnTHk4Z1ZVbHVkRFkwS0VkRlRrVlRTVk5mUkVWRFFWbGZRa3hQUTB0VEtRb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBcUNpQWdJQ0JwYm5SaklEZ2dMeThnTWpBd01EQXdDaUFnSUNBdkNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTkFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvM01UUUtJQ0FnSUM4dklHbG1JR2RsYm1WemFYTmZZbTl1ZFhNZ1BpQnlaV052Y21RdVoyVnVaWE5wYzE5elkyOXlaUzV1WVhScGRtVTZDaUFnSUNBOENpQWdJQ0JpZWlCZlkyOXRjSFYwWlY5elkyOXlaVjloWm5SbGNsOXBabDlsYkhObFFESTFDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMENncGZZMjl0Y0hWMFpWOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRREkxT2dvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvM01Ua0tJQ0FnSUM4dklITXhJQ29nVlVsdWREWTBLRmRGU1VkSVZGOUdTVTVCVEVsVVdTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBeE53b2dJQ0FnY0hWemFHbHVkQ0F5TlFvZ0lDQWdLZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8zTWpBS0lDQWdJQzh2SUNzZ2N6SWdLaUJWU1c1ME5qUW9WMFZKUjBoVVgwUkpWa1ZTVTBsVVdTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBMkNpQWdJQ0J3ZFhOb2FXNTBJREl3Q2lBZ0lDQXFDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPamN4T1MwM01qQUtJQ0FnSUM4dklITXhJQ29nVlVsdWREWTBLRmRGU1VkSVZGOUdTVTVCVEVsVVdTa0tJQ0FnSUM4dklDc2djeklnS2lCVlNXNTBOalFvVjBWSlIwaFVYMFJKVmtWU1UwbFVXU2tLSUNBZ0lDc0tJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOekl4Q2lBZ0lDQXZMeUFySUhNeklDb2dWVWx1ZERZMEtGZEZTVWRJVkY5RVJVTkJXU2tLSUNBZ0lHWnlZVzFsWDJScFp5QTNDaUFnSUNCd2RYTm9hVzUwSURJd0NpQWdJQ0FxQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pjeE9TMDNNakVLSUNBZ0lDOHZJSE14SUNvZ1ZVbHVkRFkwS0ZkRlNVZElWRjlHU1U1QlRFbFVXU2tLSUNBZ0lDOHZJQ3NnY3pJZ0tpQlZTVzUwTmpRb1YwVkpSMGhVWDBSSlZrVlNVMGxVV1NrS0lDQWdJQzh2SUNzZ2N6TWdLaUJWU1c1ME5qUW9WMFZKUjBoVVgwUkZRMEZaS1FvZ0lDQWdLd29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8zTWpJS0lDQWdJQzh2SUNzZ2N6UWdLaUJWU1c1ME5qUW9WMFZKUjBoVVgwVk9SRTlTVTBWTlJVNVVLUW9nSUNBZ1puSmhiV1ZmWkdsbklEZ0tJQ0FnSUhCMWMyaHBiblFnTWpBS0lDQWdJQ29LSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TnpFNUxUY3lNZ29nSUNBZ0x5OGdjekVnS2lCVlNXNTBOalFvVjBWSlIwaFVYMFpKVGtGTVNWUlpLUW9nSUNBZ0x5OGdLeUJ6TWlBcUlGVkpiblEyTkNoWFJVbEhTRlJmUkVsV1JWSlRTVlJaS1FvZ0lDQWdMeThnS3lCek15QXFJRlZKYm5RMk5DaFhSVWxIU0ZSZlJFVkRRVmtwQ2lBZ0lDQXZMeUFySUhNMElDb2dWVWx1ZERZMEtGZEZTVWRJVkY5RlRrUlBVbE5GVFVWT1ZDa0tJQ0FnSUNzS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk56SXpDaUFnSUNBdkx5QXJJSE0xSUNvZ1ZVbHVkRFkwS0ZkRlNVZElWRjlFU1ZOUVZWUkZLUW9nSUNBZ1puSmhiV1ZmWkdsbklEa0tJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJQ29LSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TnpFNUxUY3lNd29nSUNBZ0x5OGdjekVnS2lCVlNXNTBOalFvVjBWSlIwaFVYMFpKVGtGTVNWUlpLUW9nSUNBZ0x5OGdLeUJ6TWlBcUlGVkpiblEyTkNoWFJVbEhTRlJmUkVsV1JWSlRTVlJaS1FvZ0lDQWdMeThnS3lCek15QXFJRlZKYm5RMk5DaFhSVWxIU0ZSZlJFVkRRVmtwQ2lBZ0lDQXZMeUFySUhNMElDb2dWVWx1ZERZMEtGZEZTVWRJVkY5RlRrUlBVbE5GVFVWT1ZDa0tJQ0FnSUM4dklDc2djelVnS2lCVlNXNTBOalFvVjBWSlIwaFVYMFJKVTFCVlZFVXBDaUFnSUNBckNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qY3lOQW9nSUNBZ0x5OGdLU0F2THlCVlNXNTBOalFvTVRBd0tRb2dJQ0FnYVc1MFkxOHpJQzh2SURFd01Bb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzNNVGN0TnpJMENpQWdJQ0F2THlBaklDMHRMU0JYWldsbmFIUmxaQ0J6ZFcwZ0xTMHRDaUFnSUNBdkx5QjNaV2xuYUhSbFpDQTlJQ2dLSUNBZ0lDOHZJQ0FnSUNCek1TQXFJRlZKYm5RMk5DaFhSVWxIU0ZSZlJrbE9RVXhKVkZrcENpQWdJQ0F2THlBZ0lDQWdLeUJ6TWlBcUlGVkpiblEyTkNoWFJVbEhTRlJmUkVsV1JWSlRTVlJaS1FvZ0lDQWdMeThnSUNBZ0lDc2djek1nS2lCVlNXNTBOalFvVjBWSlIwaFVYMFJGUTBGWktRb2dJQ0FnTHk4Z0lDQWdJQ3NnY3pRZ0tpQlZTVzUwTmpRb1YwVkpSMGhVWDBWT1JFOVNVMFZOUlU1VUtRb2dJQ0FnTHk4Z0lDQWdJQ3NnY3pVZ0tpQlZTVzUwTmpRb1YwVkpSMGhVWDBSSlUxQlZWRVVwQ2lBZ0lDQXZMeUFwSUM4dklGVkpiblEyTkNneE1EQXBDaUFnSUNBdkNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qY3lOaTAzTWpjS0lDQWdJQzh2SUNNZ1FXUmtJR2RsYm1WemFYTWdZbTl1ZFhNZ0tHRmtaR2wwYVhabExDQjFjQ0IwYnlCcGRITWdaR1ZqYkdGeVpXUWdkbUZzZFdVcENpQWdJQ0F2THlCbWFXNWhiRjl6WTI5eVpTQTlJSGRsYVdkb2RHVmtJQ3NnWjJWdVpYTnBjMTlpYjI1MWN3b2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dNd29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8zTWprdE56TXdDaUFnSUNBdkx5QWpJRkJsYm1Gc2RIazZJT0tJa2pFMUlIQmxjaUIxY0dobGJHUWdaR2x6Y0hWMFpTQm1iR0ZuQ2lBZ0lDQXZMeUJwWmlCeVpXTnZjbVF1WkdsemNIVjBaVjlqYjNWdWRDNXVZWFJwZG1VZ1BpQlZTVzUwTmpRb01DazZDaUFnSUNCbWNtRnRaVjlrYVdjZ01USUtJQ0FnSUdKNklGOWpiMjF3ZFhSbFgzTmpiM0psWDJGbWRHVnlYMmxtWDJWc2MyVkFNeklLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TnpNeENpQWdJQ0F2THlCa2FYTndkWFJsWDNKaGRHbHZYMk5vWldOcklEMGdLSEpsWTI5eVpDNWthWE53ZFhSbFgyTnZkVzUwTG01aGRHbDJaU0FxSUZWSmJuUTJOQ2d4TURBcEtTQXZMeUFvQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNVElLSUNBZ0lHbHVkR05mTXlBdkx5QXhNREFLSUNBZ0lDb0tJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOek14TFRjek13b2dJQ0FnTHk4Z1pHbHpjSFYwWlY5eVlYUnBiMTlqYUdWamF5QTlJQ2h5WldOdmNtUXVaR2x6Y0hWMFpWOWpiM1Z1ZEM1dVlYUnBkbVVnS2lCVlNXNTBOalFvTVRBd0tTa2dMeThnS0FvZ0lDQWdMeThnSUNBZ0lISmxZMjl5WkM1elpYUjBiR1Z0Wlc1MFgyTnZkVzUwTG01aGRHbDJaU0FySUZWSmJuUTJOQ2d4S1FvZ0lDQWdMeThnS1FvZ0lDQWdabkpoYldWZlpHbG5JREUyQ2lBZ0lDQXZDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPamN6TkFvZ0lDQWdMeThnYVdZZ1pHbHpjSFYwWlY5eVlYUnBiMTlqYUdWamF5QStJRlZKYm5RMk5DZ3hNQ2s2SUNBaklENGdNVEFsSUdScGMzQjFkR1VnY21GMFpRb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdQZ29nSUNBZ1lub2dYMk52YlhCMWRHVmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUF6TWdvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvM016WUtJQ0FnSUM4dklHbG1JR1pwYm1Gc1gzTmpiM0psSUQ0Z2NHVnVZV3gwZVRvS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pjek5Rb2dJQ0FnTHk4Z2NHVnVZV3gwZVNBOUlGVkpiblEyTkNoRVNWTlFWVlJGWDFCRlRrRk1WRmxmVUU5SlRsUlRLUW9nSUNBZ2NIVnphR2x1ZENBeE5Rb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzNNellLSUNBZ0lDOHZJR2xtSUdacGJtRnNYM05qYjNKbElENGdjR1Z1WVd4MGVUb0tJQ0FnSUQ0S0lDQWdJR0o2SUY5amIyMXdkWFJsWDNOamIzSmxYMlZzYzJWZlltOWtlVUF5T1FvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvM016Y0tJQ0FnSUM4dklHWnBibUZzWDNOamIzSmxJRDBnWm1sdVlXeGZjMk52Y21VZ0xTQndaVzVoYkhSNUNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvM016VUtJQ0FnSUM4dklIQmxibUZzZEhrZ1BTQlZTVzUwTmpRb1JFbFRVRlZVUlY5UVJVNUJURlJaWDFCUFNVNVVVeWtLSUNBZ0lIQjFjMmhwYm5RZ01UVUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOek0zQ2lBZ0lDQXZMeUJtYVc1aGJGOXpZMjl5WlNBOUlHWnBibUZzWDNOamIzSmxJQzBnY0dWdVlXeDBlUW9nSUNBZ0xRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBekNncGZZMjl0Y0hWMFpWOXpZMjl5WlY5aFpuUmxjbDlwWmw5bGJITmxRRE15T2dvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvM05ERXROelF5Q2lBZ0lDQXZMeUFqSUZOaGJtUmliM2dnWTJWeWRHbG1hV05oZEdsdmJpQmliMjUxY3pvZ0t6VWdjRzlwYm5SekNpQWdJQ0F2THlCcFppQnlaV052Y21RdWMyRnVaR0p2ZUY5alpYSjBhV1pwWldRdWJtRjBhWFpsT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqSURZZ0x5OGdPRFE0Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllaUJmWTI5dGNIVjBaVjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURNMENpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qYzBNd29nSUNBZ0x5OGdabWx1WVd4ZmMyTnZjbVVnUFNCbWFXNWhiRjl6WTI5eVpTQXJJRlZKYm5RMk5DZzFLUW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTlFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDZ3BmWTI5dGNIVjBaVjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURNME9nb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzNORFV0TnpRMkNpQWdJQ0F2THlBaklFaGhjbVFnWTJGd0NpQWdJQ0F2THlCcFppQm1hVzVoYkY5elkyOXlaU0ErSUZWSmJuUTJOQ2hOUVZoZlUwTlBVa1VwT2dvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHbHVkR05mTXlBdkx5QXhNREFLSUNBZ0lENEtJQ0FnSUdKNklGOWpiMjF3ZFhSbFgzTmpiM0psWDJGbWRHVnlYMmxtWDJWc2MyVkFNellLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TnpRM0NpQWdJQ0F2THlCbWFXNWhiRjl6WTI5eVpTQTlJRlZKYm5RMk5DaE5RVmhmVTBOUFVrVXBDaUFnSUNCcGJuUmpYek1nTHk4Z01UQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtDbDlqYjIxd2RYUmxYM05qYjNKbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpZNkNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qYzBPUW9nSUNBZ0x5OGdjbVYwZFhKdUlHWnBibUZzWDNOamIzSmxMQ0J6TVN3Z2N6SXNJSE16TENCek5Dd2djelVLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01UY0tJQ0FnSUdaeVlXMWxYMlJwWnlBMkNpQWdJQ0JtY21GdFpWOWthV2NnTndvZ0lDQWdabkpoYldWZlpHbG5JRGdLSUNBZ0lHWnlZVzFsWDJScFp5QTVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05nb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMUNpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0lDQWdJR1p5WVcxbFgySjFjbmtnTXdvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwZlkyOXRjSFYwWlY5elkyOXlaVjlsYkhObFgySnZaSGxBTWprNkNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qY3pPUW9nSUNBZ0x5OGdabWx1WVd4ZmMyTnZjbVVnUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHSWdYMk52YlhCMWRHVmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUF6TWdvS1gyTnZiWEIxZEdWZmMyTnZjbVZmWld4elpWOWliMlI1UURFME9nb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzJPVFVLSUNBZ0lDOHZJSE0wSUQwZ0tHVnpJQ29nVlVsdWREWTBLREV3TUNrcElDOHZJRzFoZUY5bGJtUnZjbk5sYldWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR2x1ZEdOZk15QXZMeUF4TURBS0lDQWdJQ29LSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TmpnM0xUWTVNQW9nSUNBZ0x5OGdJeUF0TFMwZ1UybG5ibUZzSURRNklGTjBZV3RsTFZkbGFXZG9kR1ZrSUVWdVpHOXljMlZ0Wlc1MElDZ3lNQ1VwSUMwdExRb2dJQ0FnTHk4Z0l5QmxibVJ2Y25ObGJXVnVkRjl6WTI5eVpTQnpkRzl5WldRZ1lYTWdjM1Z0S0hOMFlXdGxJQ29nWlc1a2IzSnpaWEpmYzJOdmNtVWdMeUF4TURBcENpQWdJQ0F2THlBaklFNXZjbTFoYkdsNlpTQjBieUF3NG9DVE1UQXdPaUJqWVhBZ1lYUWdNVEF3WHpBd01GOHdNREFnS0QwZ01UQXdNQ0JCVEVkUElNT1hJSE5qYjNKbElERXdNQ2tLSUNBZ0lDOHZJRzFoZUY5bGJtUnZjbk5sYldWdWRDQTlJRlZKYm5RMk5DZ3hNREJmTURBd1h6QXdNRjh3TURBcElDQWpJREV3TUN3d01EQWdRVXhIVHlCaGRDQnRZWGdnYzJOdmNtVUtJQ0FnSUdsdWRHTWdPU0F2THlBeE1EQXdNREF3TURBd01EQUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOamsxQ2lBZ0lDQXZMeUJ6TkNBOUlDaGxjeUFxSUZWSmJuUTJOQ2d4TURBcEtTQXZMeUJ0WVhoZlpXNWtiM0p6WlcxbGJuUUtJQ0FnSUM4S0lDQWdJR1p5WVcxbFgySjFjbmtnT0FvZ0lDQWdZaUJmWTI5dGNIVjBaVjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURFMUNncGZZMjl0Y0hWMFpWOXpZMjl5WlY5bGJITmxYMkp2WkhsQU5qb0tJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOamN4Q2lBZ0lDQXZMeUJ0WVhoZmFXUnNaU0E5SUZWSmJuUTJOQ2hFUlVOQldWOUlRVXhHWDB4SlJrVmZSRUZaVXlBcUlFSk1UME5MVTE5UVJWSmZVME5QVWtsT1IxOUVRVmtwQ2lBZ0lDQnBiblJqSURjZ0x5OGdNVEF3T0RBd0NpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qWTNOUW9nSUNBZ0x5OGdjek1nUFNBb0tHMWhlRjlwWkd4bElDMGdZbXh2WTJ0elgzTnBibU5sWDJGamRHbDJhWFI1S1NBcUlGVkpiblEyTkNneE1EQXBLU0F2THlCdFlYaGZhV1JzWlFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNeUF2THlBeE1EQUtJQ0FnSUNvS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk5qY3hDaUFnSUNBdkx5QnRZWGhmYVdSc1pTQTlJRlZKYm5RMk5DaEVSVU5CV1Y5SVFVeEdYMHhKUmtWZlJFRlpVeUFxSUVKTVQwTkxVMTlRUlZKZlUwTlBVa2xPUjE5RVFWa3BDaUFnSUNCcGJuUmpJRGNnTHk4Z01UQXdPREF3Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pZM05Rb2dJQ0FnTHk4Z2N6TWdQU0FvS0cxaGVGOXBaR3hsSUMwZ1lteHZZMnR6WDNOcGJtTmxYMkZqZEdsMmFYUjVLU0FxSUZWSmJuUTJOQ2d4TURBcEtTQXZMeUJ0WVhoZmFXUnNaUW9nSUNBZ0x3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBM0NpQWdJQ0JpSUY5amIyMXdkWFJsWDNOamIzSmxYMkZtZEdWeVgybG1YMlZzYzJWQU53b0tYMk52YlhCMWRHVmZjMk52Y21WZllXWjBaWEpmYVdaZlpXeHpaVUF6T1RvS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk9ESTBDaUFnSUNBdkx5QnBaaUJ1SUR3Z1ZVbHVkRFkwS0RRcE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURFNENpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lEd0tJQ0FnSUdKNklGOWpiMjF3ZFhSbFgzTmpiM0psWDJGbWRHVnlYMmxtWDJWc2MyVkFOREVLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2T0RJMUNpQWdJQ0F2THlCeVpYUjFjbTRnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8yTmpJdE5qWXpDaUFnSUNBdkx5QWpJRWx1ZEdWblpYSWdjM0Z5ZENCaGNIQnliM2hwYldGMGFXOXVPaUJwYzNGeWRDaDRLU0IyYVdFZ1RtVjNkRzl1SjNNZ2JXVjBhRzlrQ2lBZ0lDQXZMeUJ6TWlBOUlITmxiR1l1WDJsemNYSjBLSFZ1YVhGMVpTa2dLaUJWU1c1ME5qUW9NVEFwQ2lBZ0lDQmlJRjlqYjIxd2RYUmxYM05qYjNKbFgyRm1kR1Z5WDJsdWJHbHVaV1JmWVdkbGJuUnBaQzVCWjJWdWRFbEVRMjl1ZEhKaFkzUXVYMmx6Y1hKMFFEUXlDZ3BmWTI5dGNIVjBaVjl6WTI5eVpWOWhablJsY2w5cFpsOWxiSE5sUURReE9nb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzRNall0T0RJM0NpQWdJQ0F2THlBaklFbHVhWFJwWVd3Z1pYTjBhVzFoZEdVS0lDQWdJQzh2SUhnZ1BTQnVJQzh2SUZWSmJuUTJOQ2d5S1FvZ0lDQWdabkpoYldWZlpHbG5JREU0Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnTHdvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvNE1qZ3RPREk1Q2lBZ0lDQXZMeUFqSURnZ2FYUmxjbUYwYVc5dWN5QnBjeUJ6ZFdabWFXTnBaVzUwSUdadmNpQjJZV3gxWlhNZ2RYQWdkRzhnZmpGbE1UZ0tJQ0FnSUM4dklIZ2dQU0FvZUNBcklHNGdMeThnZUNrZ0x5OGdWVWx1ZERZMEtESXBDaUFnSUNCa2RYQXlDaUFnSUNBdkNpQWdJQ0FyQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUM4S0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk9ETXdDaUFnSUNBdkx5QjRJRDBnS0hnZ0t5QnVJQzh2SUhncElDOHZJRlZKYm5RMk5DZ3lLUW9nSUNBZ1pIVndNZ29nSUNBZ0x3b2dJQ0FnS3dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBdkNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qZ3pNUW9nSUNBZ0x5OGdlQ0E5SUNoNElDc2diaUF2THlCNEtTQXZMeUJWU1c1ME5qUW9NaWtLSUNBZ0lHUjFjRElLSUNBZ0lDOEtJQ0FnSUNzS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0x3b2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzRNeklLSUNBZ0lDOHZJSGdnUFNBb2VDQXJJRzRnTHk4Z2VDa2dMeThnVlVsdWREWTBLRElwQ2lBZ0lDQmtkWEF5Q2lBZ0lDQXZDaUFnSUNBckNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDOEtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZPRE16Q2lBZ0lDQXZMeUI0SUQwZ0tIZ2dLeUJ1SUM4dklIZ3BJQzh2SUZWSmJuUTJOQ2d5S1FvZ0lDQWdaSFZ3TWdvZ0lDQWdMd29nSUNBZ0t3b2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXZDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPamd6TkFvZ0lDQWdMeThnZUNBOUlDaDRJQ3NnYmlBdkx5QjRLU0F2THlCVlNXNTBOalFvTWlrS0lDQWdJR1IxY0RJS0lDQWdJQzhLSUNBZ0lDc0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdMd29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG80TXpVS0lDQWdJQzh2SUhnZ1BTQW9lQ0FySUc0Z0x5OGdlQ2tnTHk4Z1ZVbHVkRFkwS0RJcENpQWdJQ0JrZFhBeUNpQWdJQ0F2Q2lBZ0lDQXJDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQzhLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2T0RNMkNpQWdJQ0F2THlCNElEMGdLSGdnS3lCdUlDOHZJSGdwSUM4dklGVkpiblEyTkNneUtRb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUM4S0lDQWdJQ3NLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnTHdvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvMk5qSXROall6Q2lBZ0lDQXZMeUFqSUVsdWRHVm5aWElnYzNGeWRDQmhjSEJ5YjNocGJXRjBhVzl1T2lCcGMzRnlkQ2g0S1NCMmFXRWdUbVYzZEc5dUozTWdiV1YwYUc5a0NpQWdJQ0F2THlCek1pQTlJSE5sYkdZdVgybHpjWEowS0hWdWFYRjFaU2tnS2lCVlNXNTBOalFvTVRBcENpQWdJQ0JpSUY5amIyMXdkWFJsWDNOamIzSmxYMkZtZEdWeVgybHViR2x1WldSZllXZGxiblJwWkM1QloyVnVkRWxFUTI5dWRISmhZM1F1WDJsemNYSjBRRFF5Q2dvS0x5OGdZV2RsYm5ScFpDNUJaMlZ1ZEVsRVEyOXVkSEpoWTNRdVgySjFhV3hrWDNOamIzSmxYM0psYzNWc2RDaHlaV052Y21RNklHSjVkR1Z6TENCcGMxOWpZV05vWldRNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNc0lHSjVkR1Z6T2dwZlluVnBiR1JmYzJOdmNtVmZjbVZ6ZFd4ME9nb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzNOVEV0TnpVMkNpQWdJQ0F2THlCQWMzVmljbTkxZEdsdVpRb2dJQ0FnTHk4Z1pHVm1JRjlpZFdsc1pGOXpZMjl5WlY5eVpYTjFiSFFvQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaXdLSUNBZ0lDOHZJQ0FnSUNCeVpXTnZjbVE2SUVGblpXNTBVbVZqYjNKa0xBb2dJQ0FnTHk4Z0lDQWdJR2x6WDJOaFkyaGxaRG9nWW05dmJDd0tJQ0FnSUM4dklDa2dMVDRnVTJOdmNtVlNaWE4xYkhRNkNpQWdJQ0J3Y205MGJ5QXlJRElLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TnpVNENpQWdJQ0F2THlCelkyOXlaU0E5SUhKbFkyOXlaQzVqWVdOb1pXUmZjMk52Y21VdWJtRjBhWFpsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHVjRkSEpoWTNRZ01USXpJRGdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR2x1ZENBeE1qTUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOemt3Q2lBZ0lDQXZMeUJwWmlCelkyOXlaU0ErUFNCVlNXNTBOalFvVkVsRlVsOUZURWxVUlNrNkNpQWdJQ0J3ZFhOb2FXNTBJRGsxQ2lBZ0lDQStQUW9nSUNBZ1lub2dYMkoxYVd4a1gzTmpiM0psWDNKbGMzVnNkRjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOemt4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtEUXBDaUFnSUNCd2RYTm9hVzUwSURRS0NsOWlkV2xzWkY5elkyOXlaVjl5WlhOMWJIUmZZV1owWlhKZmFXNXNhVzVsWkY5aFoyVnVkR2xrTGtGblpXNTBTVVJEYjI1MGNtRmpkQzVmYzJOdmNtVmZkRzlmZEdsbGNrQXhNam9LSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TnpZeExUYzJNZ29nSUNBZ0x5OGdJeUJTWldOdmJYQjFkR1VnYzJsbmJtRnNjeUJtYjNJZ1pHbHpjR3hoZVNBb1kyaGxZWEFnYzJsdVkyVWdZMkZqYUdVZ2FYTWdZV3h5WldGa2VTQnpaWFFwQ2lBZ0lDQXZMeUJmWm1sdVlXd3NJSE14TENCek1pd2djek1zSUhNMExDQnpOU0E5SUhObGJHWXVYMk52YlhCMWRHVmZjMk52Y21Vb2NtVmpiM0prTENCSGJHOWlZV3d1Y205MWJtUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnWTJGc2JITjFZaUJmWTI5dGNIVjBaVjl6WTI5eVpRb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBdE1nb2dJQ0FnWTI5MlpYSWdOUW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pjMk5nb2dJQ0FnTHk4Z2RHbGxjajFoY21NMExsVkpiblE0S0hScFpYSXBMQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR0pwZEd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JsZUhSeVlXTjBJRGNnTVFvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvM05qY0tJQ0FnSUM4dklITnBaMjVoYkY5bWFXNWhiR2wwZVQxaGNtTTBMbFZKYm5RMk5DaHpNU2tzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pjMk9Bb2dJQ0FnTHk4Z2MybG5ibUZzWDJScGRtVnljMmwwZVQxaGNtTTBMbFZKYm5RMk5DaHpNaWtzQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOelk1Q2lBZ0lDQXZMeUJ6YVdkdVlXeGZaR1ZqWVhrOVlYSmpOQzVWU1c1ME5qUW9jek1wTEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPamMzTUFvZ0lDQWdMeThnYzJsbmJtRnNYMlZ1Wkc5eWMyVnRaVzUwUFdGeVl6UXVWVWx1ZERZMEtITTBLU3dLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzNOekVLSUNBZ0lDOHZJSE5wWjI1aGJGOWthWE53ZFhSbFBXRnlZelF1VlVsdWREWTBLSE0xS1N3S0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8zTnpJS0lDQWdJQzh2SUhObGRIUnNaVzFsYm5SZlkyOTFiblE5Y21WamIzSmtMbk5sZEhSc1pXMWxiblJmWTI5MWJuUXNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdWNGRISmhZM1FnTWlBNENpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qYzNNd29nSUNBZ0x5OGdaR2x6Y0hWMFpWOWpiM1Z1ZEQxeVpXTnZjbVF1WkdsemNIVjBaVjlqYjNWdWRDd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWlhoMGNtRmpkQ0EzTkNBNENpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qYzNOQW9nSUNBZ0x5OGdkRzkwWVd4ZmRtOXNkVzFsUFhKbFkyOXlaQzUwYjNSaGJGOTJiMngxYldVc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1Y0ZEhKaFkzUWdNVGdnT0FvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvM056VUtJQ0FnSUM4dklITjBZV3RsWDJGc1oyODljbVZqYjNKa0xuTjBZV3RsWDJGc1oyOHNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdWNGRISmhZM1FnTlRBZ09Bb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzNOellLSUNBZ0lDOHZJSGhoYkdkdlgySmhiR0Z1WTJVOWNtVmpiM0prTG5oaGJHZHZYMkpoYkdGdVkyVXNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdWNGRISmhZM1FnTlRnZ09Bb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzNOemNLSUNBZ0lDOHZJSE5oYm1SaWIzaGZZMlZ5ZEdsbWFXVmtQWEpsWTI5eVpDNXpZVzVrWW05NFgyTmxjblJwWm1sbFpDd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFl5QTJJQzh2SURnME9Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzNOemdLSUNBZ0lDOHZJSE5oYm1SaWIzaGZjMk5sYm1GeWFXOXpQWEpsWTI5eVpDNXpZVzVrWW05NFgzTmpaVzVoY21sdmMxOXdZWE56WldRc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1Y0ZEhKaFkzUWdPVGdnT0FvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvM056a0tJQ0FnSUM4dklHVjFjbTlmWVhSMFpYTjBaV1E5Y21WamIzSmtMbVYxY205ZllYUjBaWE4wWldRc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSEIxYzJocGJuUWdPRFE1Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pjNE1Bb2dJQ0FnTHk4Z1oyVnVaWE5wYzE5elkyOXlaVDF5WldOdmNtUXVaMlZ1WlhOcGMxOXpZMjl5WlN3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdaWGgwY21GamRDQXhNRGNnT0FvZ0lDQWdMeThnWVdkbGJuUnBaQzV3ZVRvM09ERUtJQ0FnSUM4dklHZGxibVZ6YVhOZlpYaHdhWEo1WDJKc2IyTnJQWEpsWTI5eVpDNW5aVzVsYzJselgyVjRjR2x5ZVY5aWJHOWpheXdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1pYaDBjbUZqZENBeE1UVWdPQW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8zT0RJS0lDQWdJQzh2SUdOaGRYUnBiMjVmWm14aFp6MXlaV052Y21RdVkyRjFkR2x2Ymw5bWJHRm5MQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpJRFVnTHk4Z01URXhNd29nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8zT0RNS0lDQWdJQzh2SUdselgyTmhZMmhsWkQxaGNtTTBMa0p2YjJ3b2FYTmZZMkZqYUdWa0tTd0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPamM0TkFvZ0lDQWdMeThnYkdGemRGOTFjR1JoZEdWZllteHZZMnM5Y21WamIzSmtMbXhoYzNSZmRYQmtZWFJsWDJKc2IyTnJMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbGVIUnlZV04wSURReUlEZ0tJQ0FnSUM4dklHRm5aVzUwYVdRdWNIazZOelkwTFRjNE5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZOamIzSmxVbVZ6ZFd4MEtBb2dJQ0FnTHk4Z0lDQWdJSE5qYjNKbFBXRnlZelF1VlVsdWREWTBLSE5qYjNKbEtTd0tJQ0FnSUM4dklDQWdJQ0IwYVdWeVBXRnlZelF1VlVsdWREZ29kR2xsY2lrc0NpQWdJQ0F2THlBZ0lDQWdjMmxuYm1Gc1gyWnBibUZzYVhSNVBXRnlZelF1VlVsdWREWTBLSE14S1N3S0lDQWdJQzh2SUNBZ0lDQnphV2R1WVd4ZlpHbDJaWEp6YVhSNVBXRnlZelF1VlVsdWREWTBLSE15S1N3S0lDQWdJQzh2SUNBZ0lDQnphV2R1WVd4ZlpHVmpZWGs5WVhKak5DNVZTVzUwTmpRb2N6TXBMQW9nSUNBZ0x5OGdJQ0FnSUhOcFoyNWhiRjlsYm1SdmNuTmxiV1Z1ZEQxaGNtTTBMbFZKYm5RMk5DaHpOQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2MybG5ibUZzWDJScGMzQjFkR1U5WVhKak5DNVZTVzUwTmpRb2N6VXBMQW9nSUNBZ0x5OGdJQ0FnSUhObGRIUnNaVzFsYm5SZlkyOTFiblE5Y21WamIzSmtMbk5sZEhSc1pXMWxiblJmWTI5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWkdsemNIVjBaVjlqYjNWdWREMXlaV052Y21RdVpHbHpjSFYwWlY5amIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRjkyYjJ4MWJXVTljbVZqYjNKa0xuUnZkR0ZzWDNadmJIVnRaU3dLSUNBZ0lDOHZJQ0FnSUNCemRHRnJaVjloYkdkdlBYSmxZMjl5WkM1emRHRnJaVjloYkdkdkxBb2dJQ0FnTHk4Z0lDQWdJSGhoYkdkdlgySmhiR0Z1WTJVOWNtVmpiM0prTG5oaGJHZHZYMkpoYkdGdVkyVXNDaUFnSUNBdkx5QWdJQ0FnYzJGdVpHSnZlRjlqWlhKMGFXWnBaV1E5Y21WamIzSmtMbk5oYm1SaWIzaGZZMlZ5ZEdsbWFXVmtMQW9nSUNBZ0x5OGdJQ0FnSUhOaGJtUmliM2hmYzJObGJtRnlhVzl6UFhKbFkyOXlaQzV6WVc1a1ltOTRYM05qWlc1aGNtbHZjMTl3WVhOelpXUXNDaUFnSUNBdkx5QWdJQ0FnWlhWeWIxOWhkSFJsYzNSbFpEMXlaV052Y21RdVpYVnliMTloZEhSbGMzUmxaQ3dLSUNBZ0lDOHZJQ0FnSUNCblpXNWxjMmx6WDNOamIzSmxQWEpsWTI5eVpDNW5aVzVsYzJselgzTmpiM0psTEFvZ0lDQWdMeThnSUNBZ0lHZGxibVZ6YVhOZlpYaHdhWEo1WDJKc2IyTnJQWEpsWTI5eVpDNW5aVzVsYzJselgyVjRjR2x5ZVY5aWJHOWpheXdLSUNBZ0lDOHZJQ0FnSUNCallYVjBhVzl1WDJac1lXYzljbVZqYjNKa0xtTmhkWFJwYjI1ZlpteGhaeXdLSUNBZ0lDOHZJQ0FnSUNCcGMxOWpZV05vWldROVlYSmpOQzVDYjI5c0tHbHpYMk5oWTJobFpDa3NDaUFnSUNBdkx5QWdJQ0FnYkdGemRGOTFjR1JoZEdWZllteHZZMnM5Y21WamIzSmtMbXhoYzNSZmRYQmtZWFJsWDJKc2IyTnJMQW9nSUNBZ0x5OGdLUW9nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUhWdVkyOTJaWElnTVRrS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4T0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREUzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01UTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSEpsZEhOMVlnb0tYMkoxYVd4a1gzTmpiM0psWDNKbGMzVnNkRjloWm5SbGNsOXBabDlsYkhObFFEVTZDaUFnSUNBdkx5QmhaMlZ1ZEdsa0xuQjVPamM1TWdvZ0lDQWdMeThnYVdZZ2MyTnZjbVVnUGowZ1ZVbHVkRFkwS0ZSSlJWSmZWa1ZTU1VaSlJVUXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnT0RBS0lDQWdJRDQ5Q2lBZ0lDQmllaUJmWW5WcGJHUmZjMk52Y21WZmNtVnpkV3gwWDJGbWRHVnlYMmxtWDJWc2MyVkFOd29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8zT1RNS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NeWtLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzNOVGtLSUNBZ0lDOHZJSFJwWlhJZ1BTQnpaV3htTGw5elkyOXlaVjkwYjE5MGFXVnlLSE5qYjNKbEtRb2dJQ0FnWWlCZlluVnBiR1JmYzJOdmNtVmZjbVZ6ZFd4MFgyRm1kR1Z5WDJsdWJHbHVaV1JmWVdkbGJuUnBaQzVCWjJWdWRFbEVRMjl1ZEhKaFkzUXVYM05qYjNKbFgzUnZYM1JwWlhKQU1USUtDbDlpZFdsc1pGOXpZMjl5WlY5eVpYTjFiSFJmWVdaMFpYSmZhV1pmWld4elpVQTNPZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8zT1RRS0lDQWdJQzh2SUdsbUlITmpiM0psSUQ0OUlGVkpiblEyTkNoVVNVVlNYMVJTVlZOVVJVUXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTmpVS0lDQWdJRDQ5Q2lBZ0lDQmllaUJmWW5WcGJHUmZjMk52Y21WZmNtVnpkV3gwWDJGbWRHVnlYMmxtWDJWc2MyVkFPUW9nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8zT1RVS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NaWtLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnTHk4Z1lXZGxiblJwWkM1d2VUbzNOVGtLSUNBZ0lDOHZJSFJwWlhJZ1BTQnpaV3htTGw5elkyOXlaVjkwYjE5MGFXVnlLSE5qYjNKbEtRb2dJQ0FnWWlCZlluVnBiR1JmYzJOdmNtVmZjbVZ6ZFd4MFgyRm1kR1Z5WDJsdWJHbHVaV1JmWVdkbGJuUnBaQzVCWjJWdWRFbEVRMjl1ZEhKaFkzUXVYM05qYjNKbFgzUnZYM1JwWlhKQU1USUtDbDlpZFdsc1pGOXpZMjl5WlY5eVpYTjFiSFJmWVdaMFpYSmZhV1pmWld4elpVQTVPZ29nSUNBZ0x5OGdZV2RsYm5ScFpDNXdlVG8zT1RZS0lDQWdJQzh2SUdsbUlITmpiM0psSUQ0OUlGVkpiblEyTkNoVVNVVlNYMUpGVEVsQlFreEZLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURRd0NpQWdJQ0ErUFFvZ0lDQWdZbm9nWDJKMWFXeGtYM05qYjNKbFgzSmxjM1ZzZEY5aFpuUmxjbDlwWmw5bGJITmxRREV4Q2lBZ0lDQXZMeUJoWjJWdWRHbGtMbkI1T2pjNU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDOHZJR0ZuWlc1MGFXUXVjSGs2TnpVNUNpQWdJQ0F2THlCMGFXVnlJRDBnYzJWc1ppNWZjMk52Y21WZmRHOWZkR2xsY2loelkyOXlaU2tLSUNBZ0lHSWdYMkoxYVd4a1gzTmpiM0psWDNKbGMzVnNkRjloWm5SbGNsOXBibXhwYm1Wa1gyRm5aVzUwYVdRdVFXZGxiblJKUkVOdmJuUnlZV04wTGw5elkyOXlaVjkwYjE5MGFXVnlRREV5Q2dwZlluVnBiR1JmYzJOdmNtVmZjbVZ6ZFd4MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRFNkNpQWdJQ0F2THlCaFoyVnVkR2xrTG5CNU9qYzVPQW9nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUdGblpXNTBhV1F1Y0hrNk56VTVDaUFnSUNBdkx5QjBhV1Z5SUQwZ2MyVnNaaTVmYzJOdmNtVmZkRzlmZEdsbGNpaHpZMjl5WlNrS0lDQWdJR0lnWDJKMWFXeGtYM05qYjNKbFgzSmxjM1ZzZEY5aFpuUmxjbDlwYm14cGJtVmtYMkZuWlc1MGFXUXVRV2RsYm5SSlJFTnZiblJ5WVdOMExsOXpZMjl5WlY5MGIxOTBhV1Z5UURFeUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFLQUFFZ1pPZ0gyUWpRQnNDVEJzQ2FESURRMjhQMEFpWUtBMkZuWHdnQUFBQUFBQUFBQUFFQUJXRmtiV2x1RDJScGMzQjFkR1ZmWTI5MWJuUmxjZ3gwYjNSaGJGOWhaMlZ1ZEhNTFpYVnliMTl2Y21GamJHVUVGUjk4ZFJGellXNWtZbTk0WDJGMWRHaHZjbWwwZVFOa2NGOHhHRUFBQ0NjRUltY25CU0puTVJrVVJERVlRUUJ4Z2c4RTVaeHlOQVExdVdPa0JMM3NLZjhFdU1OZnJRVHZNL3lHQkZRVG9zNEVYRVVtaEFSRHlUQlVCSFo2Nk9rRWM2emRpUVJmMlI4eEJIY20yR3dFOUhhTFFRUktGbDduQkoyWk1nNDJHZ0NPRHdCQUFRTUI3Z0pqQXJVREVnT1VCQjhFc3dYb0JtNEd1UWJvQjE0SGR3Q0FCR1phQjZnMkdnQ09BUUFCQURZYUFVa1ZTU1FTUkRZYUFra1ZTU1FTUkNzeEFHY2tUd01TUkNjR1R3Tm5KQkpFSndoTVp5Y0VJbWNuQlNKbkkwTTJHZ0ZKSWxtQkFnaExBUlVTUkNneEFGQzlSUUVVUkRJR0ZqSUdGb0FxQUpRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFUd0pRZ0ZvQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUlCUVRGQk1VQ2d4QUZCSnZFaE12eUluQldWRUl3Z25CVXhuSTBNaWdBQTJHZ0ZKRllFSUVrUTJHZ0lWZ1FnU1JEWWFBMGtWU1NRU1JEWWFCRWtWSXhKRU1RQW9NUUJRUndLOVJRRkV2a2hKTWdaTEFZRXFXd2xNZ1NKYlNVQUFmU0lXU3dOTVhDSkZBMHNGSWxOQkFGRkxBa21CQ2xzakNCWmNDa21CSWx0TENoZEpJUVFMVHdJSUZrOENURndpU1lFU1cwOENDQlpjRWtVREpFc0hFa1JMQkVzSVVFbEZETDFGQVVBQUV5TVdTd3RNdjBzQ1NZRWFXeU1JRmx3YVJRTkxBa21CQWxzakNCWmNBaklHRmx3cUtWeURTd1JKdkVoTXZ5TkRTd0dCb0FzS1NVVUxRQUFFU1VML2RFc0pnV01QUVFBR1NTVUtRdjltSlVzS0NVc0JDeVVLUXY5YU5ob0JTUlZKSkJKRUpCSkVLRXhRUndLOVJRRkV2a2hKTWdaSlR3S0Jnd0ZiU1U0Q0NTVU9RUUFTU1VFQURrc0NJNGdIWGtnbkIweFFzQ05EU3dKTEFrbE9Bb2dGWFU0R1JnVkpGazhDVEZ4N1R3SVdYSU5NZ1JRTUtpSlBBbFFpVXlFRlRGUkxCRW04U0VzQnZ5S0lCeUZJUXYvQU5ob0JTUlZKSkJKRUpCSkVLRXhRU2IxRkFVUkp2a2d5Qmt4TEFZZ0ZEMDRHUmdWSkZrOENURng3VHdJV1hJTk1nUlFNS2lKUEFsUWlVeUVGVEZSTEFieElURXNCdnlLSUJ0TklKd2RNVUxBalF5Z3hBRkJKdlVVQlJFbStTREVXSXdrNENFbUJ3SVE5RDBTeGdBdGtaWEJ2YzJsMFFXeG5iN0lhZ2RINXBkd0NzaGlCQnJJUWdkQVBzZ0d6U3dHQk9sdExBUWdXVHdKTVhEcEpnVEpiVHdJSUZsd3lLVnlEU3dHOFNMOGpRNEFBTmhvQlNSVkpKQkpFTmhvQ1NSV0JDQkpFTVFBaUsyVkVFa1FrVHdJU1JDaFBBbEJKVGdKSnZVVUJSTDVJU1U4Q0YwbFBBb0V5VzBsT0FnMUJBQU5KUlFKSlN3SkpUZ0lKRmtzRVRGd3lTVVVGZ1RwYlNVVUhEa0VBRzBzRVN3SUpGa3NEVEZ3NlJRTkxBaWxjZzBzRVNieElUTDhqUTBzQ0tWdzZSUU5DLytpQUFFazJHZ0ZKRllFSUVrUXhBQ2d4QUZCSEFyMUZBVVMrU0VraVRFbUJNbHRKVHdLQldsdEpUZ0lOUVFBRVNnbEZBMHNHRjBsRkNVbExCQTVFU3dKTEFRa1dTd1ZNWERKSlJRYUJPbHRKUlFzT1FRQXNTd2hMQ0FrV1N3Uk1YRHBGQkxGTEI3SUlTd1d5QnlPeUVDRUVzZ0d6U3dNcFhJTkxCVW04U0V5L0kwTkxBeWxjT2tVRVF2L1hOaG9CU1JWSkpCSkVOaG9DU1JXQkNCSkVNUUFrVHdNU1JDaExBMUJKdlVVQlJFbStTRTRETVJZakNUZ0lTd01YU1lFQ0Mwc0NEa1FpSndSbFJFa2pDQ2NFVEdjV1N3SVdNZ1lXVHdaUENWQlBCMUJQQWxCTVVDcFFKd2xMQWxCTXYwc0VnVnBiVHdNSUZrOEVURnhhU1lGS1d5TUlGbHhLU1lGU1cwOERDQlpjVWlsY2cwc0N2RWhQQWt5L0p3ZE1VTEFqUTRBQVJ3WTJHZ0ZKRllFSUVrUTJHZ0pKRlNNU1JERUFJaXRsUkJKRVRCY1dKd2xNVUVsT0FrbTlSUUZFdmtoSmdjQUZVeW9pVHdKVUlsTVVSSUhBQlNOVVRDSlRTVThDZ2NFRlR3SlVSd0pYSUNCSlRnSW9URkJKVGdKSnZVVUJSTDVJU1U0Q2dWcGJTVThDZ1VoYlNVNENEMEVBQ2tvSkZrc0RURnhhUlFOTEJrRUFYVXNGZ1VCYlNVVVFTd09CTWx0SlJSQU5RUUFFU3cxRkQwc05TdzlKVGdJSkZrc0VURnd5U1VVRmdUcGJTVVVPRGtFQUlFc0xTdzhKRmtzRFRGdzZSUU5MQWlsY2cwc0VTYnhJVEw5TEIwc0d2eU5EU3dJcFhEcEZBMEwvNDBtQk1nc2xDa1VOU3dLQlNsdEpSUXhCQUF4TENpTUpGa3NEVEZ4S1JRTkxBb0ZTVzBsRkMwc0dnVUJiU1VVTEQwRUFEVXNKU3drSkZrc0RURnhTUlFPeFN3eXlDRXNFc2djanNoQWhCTElCczBML2p6WWFBVWtWU1NRU1JEWWFBa2tWZ1FnU1JERUFKRThERWtSSlN3TVRSQ2hMQVZCSnZVVUJSQ2hMQkZCSnZVVUJSRXkrU0VzQnZraE9BMGxYZXdoTWdYdGJTWUZRRDBReEZpTUpPQWhQQmhkTEFRNUVUd1JQQmxCTEFSWXlCaFpMQWs4Q1VFOEZVRXhRZ0FHQVVMOExKUXBMQW9GQ1d3Z1dUd0pNWEVJcFhJTkxBYnhJdnlORE5ob0JTUlZKSkJKRU5ob0NTUldCQ0JKRU1RQWlKd2hsUkJKRUpFOENFa1FvVHdKUVNiMUZBVVJKdmtoTEFseGlUd0lYZ1FNUEtpSlBBbFFpVXlFR1RGUXBYSU5MQWJ4SXZ5TkROaG9CU1JWSkpCSkVNUUFpSndabFJCSkVKQkpFS0V4UVNiMUZBVVJKdmtpQjBRWWpWQ2xjZzBzQnZFaS9JME1pTmhvQlNSVWtFa1EyR2dKSlRnSVZKQkpFTmhvRFNVNENGU1FTUkRFQUlpdGxSQkpFTWdZaENBaE1Ja3hKRlNRU1JDaE1VRWxGQnIxRkFVRUFIa3NFU2I1SWdBZ0FBQUFBQUFBQU1seHJTd01XWEhNcFhJTkxBYnhJdjBtTkFnQUxBQUlqUTRFQ1JRRkxBa0wvdnlORkFVc0RRdiszTmhvQlNSVkpKQkpFTVFBaUsyVkVFa1FrRWtRclRHY2pRellhQVVrVlNTUVNSREVBSWl0bFJCSkVKQkpFSndaTVp5TkRpZ0lIZ0FCSERvditnUUpiU1NNSVNZditnUXBiSlF0TUNvditnUnBiU1NVTlFRQURKWXdTaXhKQUFYd2lnUW9MU1l3R0pRMUJBQU1sakFhTC9vRXFXNHYvVEFsSmpBQWhCdzlCQVV3aWpBZUwvb0VpVzBtTUNrRUFNWXYrZ1JKYlNZd0xRUUFtaXdvbEM0c0xJUVFMSXdnS1NZd09KUTFCQUFNbGpBNkxCNEZHQzRzT2dSNExDQ1VLakFlTC9vRkNXMG1NQWlFSkQwRUE4eVdNQ0NXTUNZditnVXBiU1l3TVFRQWxpdzlCQUNDTC9vRlNXeVVMaS82QkVsc2pDQXBKakFFbERVRUFBeVdNQVNXTEFRbU1DU0tNQkl2K2dXdGJTWXdGUVFBbmkvNkJjMXRKakEyTC93MUJBQm1MRFl2L0NZc0ZTVThDQ3lFSUNrbU1CQXhCQUFTTEJZd0VpeEdCR1F1TEJvRVVDd2lMQjRFVUN3aUxDSUVVQ3dpTENZRUtDd2dsQ29zRUNJd0Rpd3hCQUJ5TERDVUxpeEFLZ1FvTlFRQVBpd09CRHcxQkFFU0xBNEVQQ1l3RGkvNGhCbE1xSWs4Q1ZDSlRRUUFIaXdPQkJRaU1BNHNESlExQkFBTWxqQU9MQTRzUml3YUxCNHNJaXdtTC9vd0dqQVdNQkl3RGpBS01BWXdBaVNLTUEwTC92WXNDSlFzaENRcU1DRUwvQkNFSGl3QUpKUXNoQndxTUIwTCtxSXNTZ1FRTVFRQUVJMEwrZVlzU1NZRUNDa29LQ0lFQ0Nrb0tDSUVDQ2tvS0NJRUNDa29LQ0lFQ0Nrb0tDSUVDQ2tvS0NJRUNDa29LQ0lFQ0NreExBUW9JZ1FJS1F2NCtpZ0lDaS81WGV3aUwvb0Y3VzBtQlh3OUJBTWFCQkl2K01nYUkvZlNNL2s0RlRnUk9BMDRDUlFGUEJSWkprNEVJRGtSWEJ3Rk1GazhDRms4REZrOEVGazhGRm92K1Z3SUlpLzVYU2dpTC9sY1NDSXYrVnpJSWkvNVhPZ2lML2lFR1V5b2lUd0pVaS81WFlnaUwvb0hSQmxNcUlrOENWSXYrVjJzSWkvNVhjd2lML2lFRlV5b2lUd0pVS2lLTC8xU0wvbGNxQ0lzQVR4TlFUeEpRVHhGUVR4QlFUdzlRVHc1UVR3MVFUd3hRVHd0UVR3cFFUd2xRVHdoUVR3ZFFUd1pRVHdWUVR3UlFUd0lpVTA4REkwOENWRkJNVUl2K1R3TlBBNG1MQVlGUUQwRUFCWUVEUXY4dml3R0JRUTlCQUFXQkFrTC9Jb3NCZ1NnUFFRQUVJMEwvRmlKQy94ST0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
