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

namespace Arc56.Generated.algorandfoundation.xgov_beta_sc.XgovRegistryMock_1dadee51
{


    public class XgovRegistryMockProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public XgovRegistryMockProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class TypedGlobalState : AVMObjectType
            {
                public bool PausedRegistry { get; set; }

                public bool PausedProposals { get; set; }

                public Algorand.Address XgovManager { get; set; }

                public Algorand.Address XgovPayor { get; set; }

                public Algorand.Address XgovCouncil { get; set; }

                public Algorand.Address XgovSubscriber { get; set; }

                public Algorand.Address KycProvider { get; set; }

                public Algorand.Address CommitteeManager { get; set; }

                public Algorand.Address XgovDaemon { get; set; }

                public ulong XgovFee { get; set; }

                public ulong ProposerFee { get; set; }

                public ulong OpenProposalFee { get; set; }

                public ulong DaemonOpsFundingBps { get; set; }

                public ulong ProposalCommitmentBps { get; set; }

                public ulong MinRequestedAmount { get; set; }

                public ulong[] MaxRequestedAmount { get; set; }

                public ulong[] DiscussionDuration { get; set; }

                public ulong[] VotingDuration { get; set; }

                public ulong[] Quorum { get; set; }

                public ulong[] WeightedQuorum { get; set; }

                public ulong OutstandingFunds { get; set; }

                public ulong PendingProposals { get; set; }

                public byte[] CommitteeId { get; set; }

                public ulong CommitteeMembers { get; set; }

                public ulong CommitteeVotes { get; set; }

                public ulong AbsenceTolerance { get; set; }

                public ulong GovernancePeriod { get; set; }

                public ulong CommitteeGracePeriod { get; set; }

                public ulong CommitteeLastAnchor { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPausedRegistry = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vPausedRegistry.From(PausedRegistry);
                    ret.AddRange(vPausedRegistry.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPausedProposals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vPausedProposals.From(PausedProposals);
                    ret.AddRange(vPausedProposals.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXgovManager = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vXgovManager.From(XgovManager);
                    ret.AddRange(vXgovManager.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXgovPayor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vXgovPayor.From(XgovPayor);
                    ret.AddRange(vXgovPayor.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXgovCouncil = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vXgovCouncil.From(XgovCouncil);
                    ret.AddRange(vXgovCouncil.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXgovSubscriber = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vXgovSubscriber.From(XgovSubscriber);
                    ret.AddRange(vXgovSubscriber.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vKycProvider = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vKycProvider.From(KycProvider);
                    ret.AddRange(vKycProvider.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitteeManager = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCommitteeManager.From(CommitteeManager);
                    ret.AddRange(vCommitteeManager.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXgovDaemon = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vXgovDaemon.From(XgovDaemon);
                    ret.AddRange(vXgovDaemon.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXgovFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vXgovFee.From(XgovFee);
                    ret.AddRange(vXgovFee.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposerFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProposerFee.From(ProposerFee);
                    ret.AddRange(vProposerFee.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOpenProposalFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOpenProposalFee.From(OpenProposalFee);
                    ret.AddRange(vOpenProposalFee.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDaemonOpsFundingBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDaemonOpsFundingBps.From(DaemonOpsFundingBps);
                    ret.AddRange(vDaemonOpsFundingBps.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalCommitmentBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProposalCommitmentBps.From(ProposalCommitmentBps);
                    ret.AddRange(vProposalCommitmentBps.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinRequestedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinRequestedAmount.From(MinRequestedAmount);
                    ret.AddRange(vMinRequestedAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxRequestedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[3]");
                    vMaxRequestedAmount.From(MaxRequestedAmount);
                    ret.AddRange(vMaxRequestedAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDiscussionDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[4]");
                    vDiscussionDuration.From(DiscussionDuration);
                    ret.AddRange(vDiscussionDuration.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotingDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[4]");
                    vVotingDuration.From(VotingDuration);
                    ret.AddRange(vVotingDuration.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vQuorum = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[3]");
                    vQuorum.From(Quorum);
                    ret.AddRange(vQuorum.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeightedQuorum = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[3]");
                    vWeightedQuorum.From(WeightedQuorum);
                    ret.AddRange(vWeightedQuorum.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOutstandingFunds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOutstandingFunds.From(OutstandingFunds);
                    ret.AddRange(vOutstandingFunds.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPendingProposals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPendingProposals.From(PendingProposals);
                    ret.AddRange(vPendingProposals.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitteeId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vCommitteeId.From(CommitteeId);
                    ret.AddRange(vCommitteeId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitteeMembers = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCommitteeMembers.From(CommitteeMembers);
                    ret.AddRange(vCommitteeMembers.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitteeVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCommitteeVotes.From(CommitteeVotes);
                    ret.AddRange(vCommitteeVotes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAbsenceTolerance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAbsenceTolerance.From(AbsenceTolerance);
                    ret.AddRange(vAbsenceTolerance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGovernancePeriod = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGovernancePeriod.From(GovernancePeriod);
                    ret.AddRange(vGovernancePeriod.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitteeGracePeriod = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCommitteeGracePeriod.From(CommitteeGracePeriod);
                    ret.AddRange(vCommitteeGracePeriod.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitteeLastAnchor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCommitteeLastAnchor.From(CommitteeLastAnchor);
                    ret.AddRange(vCommitteeLastAnchor.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TypedGlobalState Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TypedGlobalState();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPausedRegistry = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vPausedRegistry.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePausedRegistry = vPausedRegistry.ToValue();
                    if (valuePausedRegistry is bool vPausedRegistryValue) { ret.PausedRegistry = vPausedRegistryValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPausedProposals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vPausedProposals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePausedProposals = vPausedProposals.ToValue();
                    if (valuePausedProposals is bool vPausedProposalsValue) { ret.PausedProposals = vPausedProposalsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXgovManager = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vXgovManager.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueXgovManager = vXgovManager.ToValue();
                    if (valueXgovManager is Algorand.Address vXgovManagerValue) { ret.XgovManager = vXgovManagerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXgovPayor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vXgovPayor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueXgovPayor = vXgovPayor.ToValue();
                    if (valueXgovPayor is Algorand.Address vXgovPayorValue) { ret.XgovPayor = vXgovPayorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXgovCouncil = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vXgovCouncil.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueXgovCouncil = vXgovCouncil.ToValue();
                    if (valueXgovCouncil is Algorand.Address vXgovCouncilValue) { ret.XgovCouncil = vXgovCouncilValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXgovSubscriber = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vXgovSubscriber.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueXgovSubscriber = vXgovSubscriber.ToValue();
                    if (valueXgovSubscriber is Algorand.Address vXgovSubscriberValue) { ret.XgovSubscriber = vXgovSubscriberValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vKycProvider = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vKycProvider.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueKycProvider = vKycProvider.ToValue();
                    if (valueKycProvider is Algorand.Address vKycProviderValue) { ret.KycProvider = vKycProviderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitteeManager = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCommitteeManager.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCommitteeManager = vCommitteeManager.ToValue();
                    if (valueCommitteeManager is Algorand.Address vCommitteeManagerValue) { ret.CommitteeManager = vCommitteeManagerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXgovDaemon = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vXgovDaemon.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueXgovDaemon = vXgovDaemon.ToValue();
                    if (valueXgovDaemon is Algorand.Address vXgovDaemonValue) { ret.XgovDaemon = vXgovDaemonValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXgovFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vXgovFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueXgovFee = vXgovFee.ToValue();
                    if (valueXgovFee is ulong vXgovFeeValue) { ret.XgovFee = vXgovFeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposerFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposerFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposerFee = vProposerFee.ToValue();
                    if (valueProposerFee is ulong vProposerFeeValue) { ret.ProposerFee = vProposerFeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOpenProposalFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOpenProposalFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOpenProposalFee = vOpenProposalFee.ToValue();
                    if (valueOpenProposalFee is ulong vOpenProposalFeeValue) { ret.OpenProposalFee = vOpenProposalFeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDaemonOpsFundingBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDaemonOpsFundingBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDaemonOpsFundingBps = vDaemonOpsFundingBps.ToValue();
                    if (valueDaemonOpsFundingBps is ulong vDaemonOpsFundingBpsValue) { ret.DaemonOpsFundingBps = vDaemonOpsFundingBpsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalCommitmentBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalCommitmentBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalCommitmentBps = vProposalCommitmentBps.ToValue();
                    if (valueProposalCommitmentBps is ulong vProposalCommitmentBpsValue) { ret.ProposalCommitmentBps = vProposalCommitmentBpsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinRequestedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinRequestedAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinRequestedAmount = vMinRequestedAmount.ToValue();
                    if (valueMinRequestedAmount is ulong vMinRequestedAmountValue) { ret.MinRequestedAmount = vMinRequestedAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxRequestedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[3]");
                    count = vMaxRequestedAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxRequestedAmount = vMaxRequestedAmount.ToValue();
                    if (valueMaxRequestedAmount is ulong[] vMaxRequestedAmountValue) { ret.MaxRequestedAmount = vMaxRequestedAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDiscussionDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[4]");
                    count = vDiscussionDuration.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDiscussionDuration = vDiscussionDuration.ToValue();
                    if (valueDiscussionDuration is ulong[] vDiscussionDurationValue) { ret.DiscussionDuration = vDiscussionDurationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotingDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[4]");
                    count = vVotingDuration.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVotingDuration = vVotingDuration.ToValue();
                    if (valueVotingDuration is ulong[] vVotingDurationValue) { ret.VotingDuration = vVotingDurationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vQuorum = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[3]");
                    count = vQuorum.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueQuorum = vQuorum.ToValue();
                    if (valueQuorum is ulong[] vQuorumValue) { ret.Quorum = vQuorumValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeightedQuorum = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[3]");
                    count = vWeightedQuorum.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeightedQuorum = vWeightedQuorum.ToValue();
                    if (valueWeightedQuorum is ulong[] vWeightedQuorumValue) { ret.WeightedQuorum = vWeightedQuorumValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOutstandingFunds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOutstandingFunds.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOutstandingFunds = vOutstandingFunds.ToValue();
                    if (valueOutstandingFunds is ulong vOutstandingFundsValue) { ret.OutstandingFunds = vOutstandingFundsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPendingProposals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPendingProposals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePendingProposals = vPendingProposals.ToValue();
                    if (valuePendingProposals is ulong vPendingProposalsValue) { ret.PendingProposals = vPendingProposalsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitteeId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vCommitteeId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCommitteeId = vCommitteeId.ToValue();
                    if (valueCommitteeId is byte[] vCommitteeIdValue) { ret.CommitteeId = vCommitteeIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitteeMembers = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCommitteeMembers.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCommitteeMembers = vCommitteeMembers.ToValue();
                    if (valueCommitteeMembers is ulong vCommitteeMembersValue) { ret.CommitteeMembers = vCommitteeMembersValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitteeVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCommitteeVotes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCommitteeVotes = vCommitteeVotes.ToValue();
                    if (valueCommitteeVotes is ulong vCommitteeVotesValue) { ret.CommitteeVotes = vCommitteeVotesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAbsenceTolerance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAbsenceTolerance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAbsenceTolerance = vAbsenceTolerance.ToValue();
                    if (valueAbsenceTolerance is ulong vAbsenceToleranceValue) { ret.AbsenceTolerance = vAbsenceToleranceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGovernancePeriod = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGovernancePeriod.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGovernancePeriod = vGovernancePeriod.ToValue();
                    if (valueGovernancePeriod is ulong vGovernancePeriodValue) { ret.GovernancePeriod = vGovernancePeriodValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitteeGracePeriod = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCommitteeGracePeriod.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCommitteeGracePeriod = vCommitteeGracePeriod.ToValue();
                    if (valueCommitteeGracePeriod is ulong vCommitteeGracePeriodValue) { ret.CommitteeGracePeriod = vCommitteeGracePeriodValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitteeLastAnchor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCommitteeLastAnchor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCommitteeLastAnchor = vCommitteeLastAnchor.ToValue();
                    if (valueCommitteeLastAnchor is ulong vCommitteeLastAnchorValue) { ret.CommitteeLastAnchor = vCommitteeLastAnchorValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TypedGlobalState);
                }
                public bool Equals(TypedGlobalState? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TypedGlobalState left, TypedGlobalState right)
                {
                    return EqualityComparer<TypedGlobalState>.Default.Equals(left, right);
                }
                public static bool operator !=(TypedGlobalState left, TypedGlobalState right)
                {
                    return !(left == right);
                }

            }

            public class XGovRegistryConfig : AVMObjectType
            {
                public ulong XgovFee { get; set; }

                public ulong ProposerFee { get; set; }

                public ulong OpenProposalFee { get; set; }

                public ulong DaemonOpsFundingBps { get; set; }

                public ulong ProposalCommitmentBps { get; set; }

                public ulong MinRequestedAmount { get; set; }

                public ulong[] MaxRequestedAmount { get; set; }

                public ulong[] DiscussionDuration { get; set; }

                public ulong[] VotingDuration { get; set; }

                public ulong[] Quorum { get; set; }

                public ulong[] WeightedQuorum { get; set; }

                public ulong AbsenceTolerance { get; set; }

                public ulong GovernancePeriod { get; set; }

                public ulong CommitteeGracePeriod { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXgovFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vXgovFee.From(XgovFee);
                    ret.AddRange(vXgovFee.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposerFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProposerFee.From(ProposerFee);
                    ret.AddRange(vProposerFee.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOpenProposalFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOpenProposalFee.From(OpenProposalFee);
                    ret.AddRange(vOpenProposalFee.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDaemonOpsFundingBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDaemonOpsFundingBps.From(DaemonOpsFundingBps);
                    ret.AddRange(vDaemonOpsFundingBps.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalCommitmentBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProposalCommitmentBps.From(ProposalCommitmentBps);
                    ret.AddRange(vProposalCommitmentBps.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinRequestedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinRequestedAmount.From(MinRequestedAmount);
                    ret.AddRange(vMinRequestedAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxRequestedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[3]");
                    vMaxRequestedAmount.From(MaxRequestedAmount);
                    ret.AddRange(vMaxRequestedAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDiscussionDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[4]");
                    vDiscussionDuration.From(DiscussionDuration);
                    ret.AddRange(vDiscussionDuration.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotingDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[4]");
                    vVotingDuration.From(VotingDuration);
                    ret.AddRange(vVotingDuration.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vQuorum = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[3]");
                    vQuorum.From(Quorum);
                    ret.AddRange(vQuorum.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeightedQuorum = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[3]");
                    vWeightedQuorum.From(WeightedQuorum);
                    ret.AddRange(vWeightedQuorum.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAbsenceTolerance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAbsenceTolerance.From(AbsenceTolerance);
                    ret.AddRange(vAbsenceTolerance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGovernancePeriod = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGovernancePeriod.From(GovernancePeriod);
                    ret.AddRange(vGovernancePeriod.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitteeGracePeriod = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCommitteeGracePeriod.From(CommitteeGracePeriod);
                    ret.AddRange(vCommitteeGracePeriod.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static XGovRegistryConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new XGovRegistryConfig();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vXgovFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vXgovFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueXgovFee = vXgovFee.ToValue();
                    if (valueXgovFee is ulong vXgovFeeValue) { ret.XgovFee = vXgovFeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposerFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposerFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposerFee = vProposerFee.ToValue();
                    if (valueProposerFee is ulong vProposerFeeValue) { ret.ProposerFee = vProposerFeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOpenProposalFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOpenProposalFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOpenProposalFee = vOpenProposalFee.ToValue();
                    if (valueOpenProposalFee is ulong vOpenProposalFeeValue) { ret.OpenProposalFee = vOpenProposalFeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDaemonOpsFundingBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDaemonOpsFundingBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDaemonOpsFundingBps = vDaemonOpsFundingBps.ToValue();
                    if (valueDaemonOpsFundingBps is ulong vDaemonOpsFundingBpsValue) { ret.DaemonOpsFundingBps = vDaemonOpsFundingBpsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalCommitmentBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalCommitmentBps.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalCommitmentBps = vProposalCommitmentBps.ToValue();
                    if (valueProposalCommitmentBps is ulong vProposalCommitmentBpsValue) { ret.ProposalCommitmentBps = vProposalCommitmentBpsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinRequestedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinRequestedAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinRequestedAmount = vMinRequestedAmount.ToValue();
                    if (valueMinRequestedAmount is ulong vMinRequestedAmountValue) { ret.MinRequestedAmount = vMinRequestedAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxRequestedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[3]");
                    count = vMaxRequestedAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxRequestedAmount = vMaxRequestedAmount.ToValue();
                    if (valueMaxRequestedAmount is ulong[] vMaxRequestedAmountValue) { ret.MaxRequestedAmount = vMaxRequestedAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDiscussionDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[4]");
                    count = vDiscussionDuration.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDiscussionDuration = vDiscussionDuration.ToValue();
                    if (valueDiscussionDuration is ulong[] vDiscussionDurationValue) { ret.DiscussionDuration = vDiscussionDurationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotingDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[4]");
                    count = vVotingDuration.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVotingDuration = vVotingDuration.ToValue();
                    if (valueVotingDuration is ulong[] vVotingDurationValue) { ret.VotingDuration = vVotingDurationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vQuorum = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[3]");
                    count = vQuorum.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueQuorum = vQuorum.ToValue();
                    if (valueQuorum is ulong[] vQuorumValue) { ret.Quorum = vQuorumValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeightedQuorum = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[3]");
                    count = vWeightedQuorum.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeightedQuorum = vWeightedQuorum.ToValue();
                    if (valueWeightedQuorum is ulong[] vWeightedQuorumValue) { ret.WeightedQuorum = vWeightedQuorumValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAbsenceTolerance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAbsenceTolerance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAbsenceTolerance = vAbsenceTolerance.ToValue();
                    if (valueAbsenceTolerance is ulong vAbsenceToleranceValue) { ret.AbsenceTolerance = vAbsenceToleranceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGovernancePeriod = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGovernancePeriod.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGovernancePeriod = vGovernancePeriod.ToValue();
                    if (valueGovernancePeriod is ulong vGovernancePeriodValue) { ret.GovernancePeriod = vGovernancePeriodValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCommitteeGracePeriod = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCommitteeGracePeriod.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCommitteeGracePeriod = vCommitteeGracePeriod.ToValue();
                    if (valueCommitteeGracePeriod is ulong vCommitteeGracePeriodValue) { ret.CommitteeGracePeriod = vCommitteeGracePeriodValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as XGovRegistryConfig);
                }
                public bool Equals(XGovRegistryConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(XGovRegistryConfig left, XGovRegistryConfig right)
                {
                    return EqualityComparer<XGovRegistryConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(XGovRegistryConfig left, XGovRegistryConfig right)
                {
                    return !(left == right);
                }

            }

            public class GetXgovBoxReturn : AVMObjectType
            {
                public Structs.GetXgovBoxReturnField0 Field0 { get; set; } = new Structs.GetXgovBoxReturnField0();

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Field0.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static GetXgovBoxReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetXgovBoxReturn();
                    uint count = 0;
                    ret.Field0 = Structs.GetXgovBoxReturnField0.Parse(queue.ToArray());
                    { var consumedField0 = ret.Field0.ToByteArray().Length; for (int i = 0; i < consumedField0 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetXgovBoxReturn);
                }
                public bool Equals(GetXgovBoxReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetXgovBoxReturn left, GetXgovBoxReturn right)
                {
                    return EqualityComparer<GetXgovBoxReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetXgovBoxReturn left, GetXgovBoxReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetXgovBoxReturnField0 : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetXgovBoxReturnField0 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetXgovBoxReturnField0();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetXgovBoxReturnField0);
                }
                public bool Equals(GetXgovBoxReturnField0? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetXgovBoxReturnField0 left, GetXgovBoxReturnField0 right)
                {
                    return EqualityComparer<GetXgovBoxReturnField0>.Default.Equals(left, right);
                }
                public static bool operator !=(GetXgovBoxReturnField0 left, GetXgovBoxReturnField0 right)
                {
                    return !(left == right);
                }

            }

            public class GetProposerBoxReturn : AVMObjectType
            {
                public Structs.GetProposerBoxReturnField0 Field0 { get; set; } = new Structs.GetProposerBoxReturnField0();

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Field0.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static GetProposerBoxReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetProposerBoxReturn();
                    uint count = 0;
                    ret.Field0 = Structs.GetProposerBoxReturnField0.Parse(queue.ToArray());
                    { var consumedField0 = ret.Field0.ToByteArray().Length; for (int i = 0; i < consumedField0 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetProposerBoxReturn);
                }
                public bool Equals(GetProposerBoxReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetProposerBoxReturn left, GetProposerBoxReturn right)
                {
                    return EqualityComparer<GetProposerBoxReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetProposerBoxReturn left, GetProposerBoxReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetProposerBoxReturnField0 : AVMObjectType
            {
                public bool Field0 { get; set; }

                public bool Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static GetProposerBoxReturnField0 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetProposerBoxReturnField0();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
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
                    return Equals(obj as GetProposerBoxReturnField0);
                }
                public bool Equals(GetProposerBoxReturnField0? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetProposerBoxReturnField0 left, GetProposerBoxReturnField0 right)
                {
                    return EqualityComparer<GetProposerBoxReturnField0>.Default.Equals(left, right);
                }
                public static bool operator !=(GetProposerBoxReturnField0 left, GetProposerBoxReturnField0 right)
                {
                    return !(left == right);
                }

            }

            public class GetRequestBoxReturn : AVMObjectType
            {
                public Structs.GetRequestBoxReturnField0 Field0 { get; set; } = new Structs.GetRequestBoxReturnField0();

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Field0.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static GetRequestBoxReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetRequestBoxReturn();
                    uint count = 0;
                    ret.Field0 = Structs.GetRequestBoxReturnField0.Parse(queue.ToArray());
                    { var consumedField0 = ret.Field0.ToByteArray().Length; for (int i = 0; i < consumedField0 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetRequestBoxReturn);
                }
                public bool Equals(GetRequestBoxReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetRequestBoxReturn left, GetRequestBoxReturn right)
                {
                    return EqualityComparer<GetRequestBoxReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetRequestBoxReturn left, GetRequestBoxReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetRequestBoxReturnField0 : AVMObjectType
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

                public static GetRequestBoxReturnField0 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetRequestBoxReturnField0();
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
                    return Equals(obj as GetRequestBoxReturnField0);
                }
                public bool Equals(GetRequestBoxReturnField0? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetRequestBoxReturnField0 left, GetRequestBoxReturnField0 right)
                {
                    return EqualityComparer<GetRequestBoxReturnField0>.Default.Equals(left, right);
                }
                public static bool operator !=(GetRequestBoxReturnField0 left, GetRequestBoxReturnField0 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="size"> </param>
        public async Task InitProposalContract(ulong size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 156, 71, 98 };
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);

            var result = await base.CallApp(new List<object> { abiHandle, sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InitProposalContract_Transactions(ulong size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 156, 71, 98 };
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);

            return await base.MakeTransactionList(new List<object> { abiHandle, sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="offset"> </param>
        /// <param name="data"> </param>
        public async Task LoadProposalContract(ulong offset, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 31, 86, 77 };
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, offsetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LoadProposalContract_Transactions(ulong offset, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 31, 86, 77 };
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, offsetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeleteProposalContractBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 10, 81, 46 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteProposalContractBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 10, 81, 46 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task PauseRegistry(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 247, 224, 230 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PauseRegistry_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 247, 224, 230 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task PauseProposals(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 226, 109, 138 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PauseProposals_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 226, 109, 138 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ResumeRegistry(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 53, 46, 134 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ResumeRegistry_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 53, 46, 134 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ResumeProposals(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 78, 214, 226 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ResumeProposals_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 78, 214, 226 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="manager"> </param>
        public async Task SetXgovManager(Algorand.Address manager, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 201, 204, 26 };
            var managerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); managerAbi.From(manager);

            var result = await base.CallApp(new List<object> { abiHandle, managerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetXgovManager_Transactions(Algorand.Address manager, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 201, 204, 26 };
            var managerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); managerAbi.From(manager);

            return await base.MakeTransactionList(new List<object> { abiHandle, managerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payor"> </param>
        public async Task SetPayor(Algorand.Address payor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 72, 64, 85 };
            var payorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payorAbi.From(payor);

            var result = await base.CallApp(new List<object> { abiHandle, payorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPayor_Transactions(Algorand.Address payor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 72, 64, 85 };
            var payorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payorAbi.From(payor);

            return await base.MakeTransactionList(new List<object> { abiHandle, payorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="council"> </param>
        public async Task SetXgovCouncil(Algorand.Address council, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 214, 173, 241 };
            var councilAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); councilAbi.From(council);

            var result = await base.CallApp(new List<object> { abiHandle, councilAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetXgovCouncil_Transactions(Algorand.Address council, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 214, 173, 241 };
            var councilAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); councilAbi.From(council);

            return await base.MakeTransactionList(new List<object> { abiHandle, councilAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="subscriber"> </param>
        public async Task SetXgovSubscriber(Algorand.Address subscriber, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 33, 107, 110 };
            var subscriberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); subscriberAbi.From(subscriber);

            var result = await base.CallApp(new List<object> { abiHandle, subscriberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetXgovSubscriber_Transactions(Algorand.Address subscriber, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 33, 107, 110 };
            var subscriberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); subscriberAbi.From(subscriber);

            return await base.MakeTransactionList(new List<object> { abiHandle, subscriberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="provider"> </param>
        public async Task SetKycProvider(Algorand.Address provider, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 133, 32, 242 };
            var providerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); providerAbi.From(provider);

            var result = await base.CallApp(new List<object> { abiHandle, providerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetKycProvider_Transactions(Algorand.Address provider, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 133, 32, 242 };
            var providerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); providerAbi.From(provider);

            return await base.MakeTransactionList(new List<object> { abiHandle, providerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="manager"> </param>
        public async Task SetCommitteeManager(Algorand.Address manager, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 119, 179, 14 };
            var managerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); managerAbi.From(manager);

            var result = await base.CallApp(new List<object> { abiHandle, managerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetCommitteeManager_Transactions(Algorand.Address manager, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 119, 179, 14 };
            var managerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); managerAbi.From(manager);

            return await base.MakeTransactionList(new List<object> { abiHandle, managerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="xgov_daemon"> </param>
        public async Task SetXgovDaemon(Algorand.Address xgov_daemon, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 183, 210, 104 };
            var xgov_daemonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_daemonAbi.From(xgov_daemon);

            var result = await base.CallApp(new List<object> { abiHandle, xgov_daemonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetXgovDaemon_Transactions(Algorand.Address xgov_daemon, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 183, 210, 104 };
            var xgov_daemonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_daemonAbi.From(xgov_daemon);

            return await base.MakeTransactionList(new List<object> { abiHandle, xgov_daemonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="config"> XGovRegistryConfig</param>
        public async Task ConfigXgovRegistry(Structs.XGovRegistryConfig config, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 127, 24, 96 };

            var result = await base.CallApp(new List<object> { abiHandle, config }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ConfigXgovRegistry_Transactions(Structs.XGovRegistryConfig config, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 127, 24, 96 };

            return await base.MakeTransactionList(new List<object> { abiHandle, config }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task UpdateXgovRegistry(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 86, 193, 171 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateXgovRegistry_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 86, 193, 171 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="voting_address"> </param>
        /// <param name="payment"> </param>
        public async Task SubscribeXgov(PaymentTransaction payment, Algorand.Address voting_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 160, 130, 206, 248 };
            var voting_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voting_addressAbi.From(voting_address);

            var result = await base.CallApp(new List<object> { abiHandle, voting_addressAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubscribeXgov_Transactions(PaymentTransaction payment, Algorand.Address voting_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 160, 130, 206, 248 };
            var voting_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voting_addressAbi.From(voting_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, voting_addressAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task UnsubscribeXgov(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 57, 253, 185 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UnsubscribeXgov_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 57, 253, 185 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="xgov_address"> </param>
        public async Task UnsubscribeAbsentee(Algorand.Address xgov_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 15, 106, 58 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);

            var result = await base.CallApp(new List<object> { abiHandle, xgov_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UnsubscribeAbsentee_Transactions(Algorand.Address xgov_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 15, 106, 58 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, xgov_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task ApproveSubscribeXgov(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 49, 188, 2 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveSubscribeXgov_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 60, 49, 188, 2 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task RejectSubscribeXgov(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 44, 120, 145 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RejectSubscribeXgov_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 44, 120, 145 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="xgov_address"> </param>
        /// <param name="owner_address"> </param>
        /// <param name="relation_type"> </param>
        /// <param name="payment"> </param>
        public async Task RequestSubscribeXgov(PaymentTransaction payment, Algorand.Address xgov_address, Algorand.Address owner_address, ulong relation_type, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 69, 7, 115, 144 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);
            var owner_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); owner_addressAbi.From(owner_address);
            var relation_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); relation_typeAbi.From(relation_type);

            var result = await base.CallApp(new List<object> { abiHandle, xgov_addressAbi, owner_addressAbi, relation_typeAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RequestSubscribeXgov_Transactions(PaymentTransaction payment, Algorand.Address xgov_address, Algorand.Address owner_address, ulong relation_type, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 69, 7, 115, 144 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);
            var owner_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); owner_addressAbi.From(owner_address);
            var relation_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); relation_typeAbi.From(relation_type);

            return await base.MakeTransactionList(new List<object> { abiHandle, xgov_addressAbi, owner_addressAbi, relation_typeAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="xgov_address"> </param>
        /// <param name="owner_address"> </param>
        /// <param name="relation_type"> </param>
        /// <param name="payment"> </param>
        public async Task RequestUnsubscribeXgov(PaymentTransaction payment, Algorand.Address xgov_address, Algorand.Address owner_address, ulong relation_type, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 147, 250, 205, 186 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);
            var owner_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); owner_addressAbi.From(owner_address);
            var relation_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); relation_typeAbi.From(relation_type);

            var result = await base.CallApp(new List<object> { abiHandle, xgov_addressAbi, owner_addressAbi, relation_typeAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RequestUnsubscribeXgov_Transactions(PaymentTransaction payment, Algorand.Address xgov_address, Algorand.Address owner_address, ulong relation_type, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 147, 250, 205, 186 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);
            var owner_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); owner_addressAbi.From(owner_address);
            var relation_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); relation_typeAbi.From(relation_type);

            return await base.MakeTransactionList(new List<object> { abiHandle, xgov_addressAbi, owner_addressAbi, relation_typeAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task ApproveUnsubscribeXgov(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 139, 58, 28 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveUnsubscribeXgov_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 139, 58, 28 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task RejectUnsubscribeXgov(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 234, 8, 31 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RejectUnsubscribeXgov_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 234, 8, 31 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="xgov_address"> </param>
        /// <param name="voting_address"> </param>
        public async Task SetVotingAccount(Algorand.Address xgov_address, Algorand.Address voting_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 162, 120, 133 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);
            var voting_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voting_addressAbi.From(voting_address);

            var result = await base.CallApp(new List<object> { abiHandle, xgov_addressAbi, voting_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetVotingAccount_Transactions(Algorand.Address xgov_address, Algorand.Address voting_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 162, 120, 133 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);
            var voting_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voting_addressAbi.From(voting_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, xgov_addressAbi, voting_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task SubscribeProposer(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 122, 79, 238, 67 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubscribeProposer_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 122, 79, 238, 67 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposer"> </param>
        /// <param name="kyc_status"> </param>
        /// <param name="kyc_expiring"> </param>
        public async Task SetProposerKyc(Algorand.Address proposer, bool kyc_status, ulong kyc_expiring, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 221, 16, 215 };
            var proposerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); proposerAbi.From(proposer);
            var kyc_statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); kyc_statusAbi.From(kyc_status);
            var kyc_expiringAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); kyc_expiringAbi.From(kyc_expiring);

            var result = await base.CallApp(new List<object> { abiHandle, proposerAbi, kyc_statusAbi, kyc_expiringAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetProposerKyc_Transactions(Algorand.Address proposer, bool kyc_status, ulong kyc_expiring, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 221, 16, 215 };
            var proposerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); proposerAbi.From(proposer);
            var kyc_statusAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); kyc_statusAbi.From(kyc_status);
            var kyc_expiringAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); kyc_expiringAbi.From(kyc_expiring);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposerAbi, kyc_statusAbi, kyc_expiringAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="committee_id"> </param>
        /// <param name="size"> </param>
        /// <param name="votes"> </param>
        public async Task DeclareCommittee(byte[] committee_id, ulong size, ulong votes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 211, 122, 100 };
            var committee_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); committee_idAbi.From(committee_id);
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);
            var votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); votesAbi.From(votes);

            var result = await base.CallApp(new List<object> { abiHandle, committee_idAbi, sizeAbi, votesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeclareCommittee_Transactions(byte[] committee_id, ulong size, ulong votes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 211, 122, 100 };
            var committee_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); committee_idAbi.From(committee_id);
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);
            var votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); votesAbi.From(votes);

            return await base.MakeTransactionList(new List<object> { abiHandle, committee_idAbi, sizeAbi, votesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task<ulong> OpenProposal(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 52, 52, 157, 204 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> OpenProposal_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 52, 52, 157, 204 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        /// <param name="xgov_address"> </param>
        /// <param name="approval_votes"> </param>
        /// <param name="rejection_votes"> </param>
        public async Task VoteProposal(ulong proposal_id, Algorand.Address xgov_address, ulong approval_votes, ulong rejection_votes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 143, 141, 214 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);
            var approval_votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approval_votesAbi.From(approval_votes);
            var rejection_votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rejection_votesAbi.From(rejection_votes);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi, xgov_addressAbi, approval_votesAbi, rejection_votesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VoteProposal_Transactions(ulong proposal_id, Algorand.Address xgov_address, ulong approval_votes, ulong rejection_votes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 143, 141, 214 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);
            var approval_votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approval_votesAbi.From(approval_votes);
            var rejection_votesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rejection_votesAbi.From(rejection_votes);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi, xgov_addressAbi, approval_votesAbi, rejection_votesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        /// <param name="absentees"> </param>
        public async Task UnassignAbsenteeFromProposal(ulong proposal_id, Algorand.Address[] absentees, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 226, 89, 53 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var absenteesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); absenteesAbi.From(absentees);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi, absenteesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UnassignAbsenteeFromProposal_Transactions(ulong proposal_id, Algorand.Address[] absentees, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 226, 89, 53 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var absenteesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); absenteesAbi.From(absentees);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi, absenteesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        public async Task PayGrantProposal(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 39, 185, 175 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PayGrantProposal_Transactions(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 39, 185, 175 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        public async Task FinalizeProposal(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 145, 7, 86 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FinalizeProposal_Transactions(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 145, 7, 86 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        public async Task DropProposal(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 97, 10, 159 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DropProposal_Transactions(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 97, 10, 159 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task DepositFunds(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 253, 198, 149, 194 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DepositFunds_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 253, 198, 149, 194 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task WithdrawFunds(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 144, 171, 84 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawFunds_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 144, 171, 84 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task WithdrawAvailableFunds(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 103, 75, 69 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawAvailableFunds_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 103, 75, 69 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetAvailableFunds(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 213, 174, 148 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAvailableFunds_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 213, 174, 148 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.TypedGlobalState> GetState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 229, 235, 70 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TypedGlobalState.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 229, 235, 70 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="xgov_address"> </param>
        public async Task<Structs.GetXgovBoxReturn> GetXgovBox(Algorand.Address xgov_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 99, 13, 101 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);

            var result = await base.SimApp(new List<object> { abiHandle, xgov_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetXgovBoxReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetXgovBox_Transactions(Algorand.Address xgov_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 99, 13, 101 };
            var xgov_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); xgov_addressAbi.From(xgov_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, xgov_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposer_address"> </param>
        public async Task<Structs.GetProposerBoxReturn> GetProposerBox(Algorand.Address proposer_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 79, 152, 188 };
            var proposer_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); proposer_addressAbi.From(proposer_address);

            var result = await base.SimApp(new List<object> { abiHandle, proposer_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetProposerBoxReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetProposerBox_Transactions(Algorand.Address proposer_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 79, 152, 188 };
            var proposer_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); proposer_addressAbi.From(proposer_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposer_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task<Structs.GetRequestBoxReturn> GetRequestBox(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 84, 139, 160 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.SimApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetRequestBoxReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRequestBox_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 84, 139, 160 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task<Structs.GetRequestBoxReturn> GetRequestUnsubscribeBox(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 103, 132, 246 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.SimApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetRequestBoxReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRequestUnsubscribeBox_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 103, 132, 246 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        public async Task IsProposal(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 152, 50, 0 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IsProposal_Transactions(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 152, 50, 0 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposer"> </param>
        public async Task<ulong> CreateEmptyProposal(Algorand.Address proposer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 134, 176, 63 };
            var proposerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); proposerAbi.From(proposer);

            var result = await base.CallApp(new List<object> { abiHandle, proposerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateEmptyProposal_Transactions(Algorand.Address proposer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 134, 176, 63 };
            var proposerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); proposerAbi.From(proposer);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OpUp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 216, 61, 217 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpUp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 216, 61, 217 };

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

        protected override ulong? ExtraProgramPages { get; set; } = 3;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWGdvdlJlZ2lzdHJ5TW9jayIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJUeXBlZEdsb2JhbFN0YXRlIjpbeyJuYW1lIjoicGF1c2VkX3JlZ2lzdHJ5IiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJwYXVzZWRfcHJvcG9zYWxzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJ4Z292X21hbmFnZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6Inhnb3ZfcGF5b3IiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6Inhnb3ZfY291bmNpbCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoieGdvdl9zdWJzY3JpYmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJreWNfcHJvdmlkZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImNvbW1pdHRlZV9tYW5hZ2VyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJ4Z292X2RhZW1vbiIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoieGdvdl9mZWUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicHJvcG9zZXJfZmVlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im9wZW5fcHJvcG9zYWxfZmVlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRhZW1vbl9vcHNfZnVuZGluZ19icHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicHJvcG9zYWxfY29tbWl0bWVudF9icHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWluX3JlcXVlc3RlZF9hbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWF4X3JlcXVlc3RlZF9hbW91bnQiLCJ0eXBlIjoidWludDY0WzNdIn0seyJuYW1lIjoiZGlzY3Vzc2lvbl9kdXJhdGlvbiIsInR5cGUiOiJ1aW50NjRbNF0ifSx7Im5hbWUiOiJ2b3RpbmdfZHVyYXRpb24iLCJ0eXBlIjoidWludDY0WzRdIn0seyJuYW1lIjoicXVvcnVtIiwidHlwZSI6InVpbnQ2NFszXSJ9LHsibmFtZSI6IndlaWdodGVkX3F1b3J1bSIsInR5cGUiOiJ1aW50NjRbM10ifSx7Im5hbWUiOiJvdXRzdGFuZGluZ19mdW5kcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwZW5kaW5nX3Byb3Bvc2FscyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjb21taXR0ZWVfaWQiLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJjb21taXR0ZWVfbWVtYmVycyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjb21taXR0ZWVfdm90ZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWJzZW5jZV90b2xlcmFuY2UiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZ292ZXJuYW5jZV9wZXJpb2QiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY29tbWl0dGVlX2dyYWNlX3BlcmlvZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjb21taXR0ZWVfbGFzdF9hbmNob3IiLCJ0eXBlIjoidWludDY0In1dLCJYR292UmVnaXN0cnlDb25maWciOlt7Im5hbWUiOiJ4Z292X2ZlZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcm9wb3Nlcl9mZWUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoib3Blbl9wcm9wb3NhbF9mZWUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZGFlbW9uX29wc19mdW5kaW5nX2JwcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcm9wb3NhbF9jb21taXRtZW50X2JwcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtaW5fcmVxdWVzdGVkX2Ftb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXhfcmVxdWVzdGVkX2Ftb3VudCIsInR5cGUiOiJ1aW50NjRbM10ifSx7Im5hbWUiOiJkaXNjdXNzaW9uX2R1cmF0aW9uIiwidHlwZSI6InVpbnQ2NFs0XSJ9LHsibmFtZSI6InZvdGluZ19kdXJhdGlvbiIsInR5cGUiOiJ1aW50NjRbNF0ifSx7Im5hbWUiOiJxdW9ydW0iLCJ0eXBlIjoidWludDY0WzNdIn0seyJuYW1lIjoid2VpZ2h0ZWRfcXVvcnVtIiwidHlwZSI6InVpbnQ2NFszXSJ9LHsibmFtZSI6ImFic2VuY2VfdG9sZXJhbmNlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImdvdmVybmFuY2VfcGVyaW9kIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNvbW1pdHRlZV9ncmFjZV9wZXJpb2QiLCJ0eXBlIjoidWludDY0In1dLCJHZXRYZ292Qm94UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6IkdldFhnb3ZCb3hSZXR1cm5GaWVsZDAifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYm9vbCJ9XSwiR2V0WGdvdkJveFJldHVybkZpZWxkMCI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In1dLCJHZXRQcm9wb3NlckJveFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJHZXRQcm9wb3NlckJveFJldHVybkZpZWxkMCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn1dLCJHZXRQcm9wb3NlckJveFJldHVybkZpZWxkMCI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dLCJHZXRSZXF1ZXN0Qm94UmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6IkdldFJlcXVlc3RCb3hSZXR1cm5GaWVsZDAifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYm9vbCJ9XSwiR2V0UmVxdWVzdEJveFJldHVybkZpZWxkMCI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbml0X3Byb3Bvc2FsX2NvbnRyYWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpemUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9hZF9wcm9wb3NhbF9jb250cmFjdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvZmZzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlX3Byb3Bvc2FsX2NvbnRyYWN0X2JveCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXVzZV9yZWdpc3RyeSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXVzZV9wcm9wb3NhbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVzdW1lX3JlZ2lzdHJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlc3VtZV9wcm9wb3NhbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X3hnb3ZfbWFuYWdlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWFuYWdlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfcGF5b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF94Z292X2NvdW5jaWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvdW5jaWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X3hnb3Zfc3Vic2NyaWJlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Vic2NyaWJlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfa3ljX3Byb3ZpZGVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm92aWRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfY29tbWl0dGVlX21hbmFnZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hbmFnZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X3hnb3ZfZGFlbW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4Z292X2RhZW1vbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb25maWdfeGdvdl9yZWdpc3RyeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0WzNdLHVpbnQ2NFs0XSx1aW50NjRbNF0sdWludDY0WzNdLHVpbnQ2NFszXSx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJYR292UmVnaXN0cnlDb25maWciLCJuYW1lIjoiY29uZmlnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV94Z292X3JlZ2lzdHJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiVXBkYXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdWJzY3JpYmVfeGdvdiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90aW5nX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5zdWJzY3JpYmVfeGdvdiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bnN1YnNjcmliZV9hYnNlbnRlZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoieGdvdl9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcHJvdmVfc3Vic2NyaWJlX3hnb3YiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWplY3Rfc3Vic2NyaWJlX3hnb3YiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXF1ZXN0X3N1YnNjcmliZV94Z292IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4Z292X2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lcl9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWxhdGlvbl90eXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlcXVlc3RfdW5zdWJzY3JpYmVfeGdvdiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoieGdvdl9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXJfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVsYXRpb25fdHlwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHByb3ZlX3Vuc3Vic2NyaWJlX3hnb3YiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWplY3RfdW5zdWJzY3JpYmVfeGdvdiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF92b3RpbmdfYWNjb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoieGdvdl9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90aW5nX2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3Vic2NyaWJlX3Byb3Bvc2VyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X3Byb3Bvc2VyX2t5YyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJreWNfc3RhdHVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJreWNfZXhwaXJpbmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVjbGFyZV9jb21taXR0ZWUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb21taXR0ZWVfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpemUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wZW5fcHJvcG9zYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZvdGVfcHJvcG9zYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4Z292X2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcHJvdmFsX3ZvdGVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWplY3Rpb25fdm90ZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5hc3NpZ25fYWJzZW50ZWVfZnJvbV9wcm9wb3NhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzc1tdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWJzZW50ZWVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBheV9ncmFudF9wcm9wb3NhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmaW5hbGl6ZV9wcm9wb3NhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkcm9wX3Byb3Bvc2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXRfZnVuZHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhd19mdW5kcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXdfYXZhaWxhYmxlX2Z1bmRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXZhaWxhYmxlX2Z1bmRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfc3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYm9vbCxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NFszXSx1aW50NjRbNF0sdWludDY0WzRdLHVpbnQ2NFszXSx1aW50NjRbM10sdWludDY0LHVpbnQ2NCxieXRlWzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJUeXBlZEdsb2JhbFN0YXRlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfeGdvdl9ib3giLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Inhnb3ZfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoKGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50NjQpLGJvb2wpIiwic3RydWN0IjoiR2V0WGdvdkJveFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3Byb3Bvc2VyX2JveCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zZXJfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoKGJvb2wsYm9vbCx1aW50NjQpLGJvb2wpIiwic3RydWN0IjoiR2V0UHJvcG9zZXJCb3hSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9yZXF1ZXN0X2JveCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IigoYWRkcmVzcyxhZGRyZXNzLHVpbnQ2NCksYm9vbCkiLCJzdHJ1Y3QiOiJHZXRSZXF1ZXN0Qm94UmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcmVxdWVzdF91bnN1YnNjcmliZV9ib3giLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoKGFkZHJlc3MsYWRkcmVzcyx1aW50NjQpLGJvb2wpIiwic3RydWN0IjoiR2V0UmVxdWVzdEJveFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfcHJvcG9zYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY3JlYXRlX2VtcHR5X3Byb3Bvc2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wX3VwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyOSwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIwNTIsMjQ3Ml0sImVycm9yTWVzc2FnZSI6Ik1pc3NpbmcgQ29uZmlnIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ3MV0sImVycm9yTWVzc2FnZSI6IlRoZXJlIGFyZSB2b3RlcnMgYXNzaWduZWQgdG8gdGhpcyBwcm9wb3NhbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNTYsMjMxMV0sImVycm9yTWVzc2FnZSI6IlVuYXV0aG9yaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNDksMjE4OCwyMTk2LDIzMDksMjQ3MCwyNTgxXSwiZXJyb3JNZXNzYWdlIjoiVW5rbm93biBlcnJvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNTRdLCJlcnJvck1lc3NhZ2UiOiJWb3RlciBhbHJlYWR5IHZvdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA1NSwyMTg5XSwiZXJyb3JNZXNzYWdlIjoiVm90ZXIgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA1M10sImVycm9yTWVzc2FnZSI6IlZvdGVzIGludmFsaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDUwXSwiZXJyb3JNZXNzYWdlIjoiVm90aW5nIFBlcmlvZCBFeHBpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA1MSwyMTkwLDIzMTAsMjQ3MywyNTgyXSwiZXJyb3JNZXNzYWdlIjoiV3JvbmcgUHJvcG9zYWwgU3RhdHVzIG9yIGZpbmFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxMDEsNzQzN10sImVycm9yTWVzc2FnZSI6ImFjY291bnQgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQ0M10sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MTMsMjEyNSwyMjQ2LDIzNjEsMjUyM10sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGxvZyB2YWx1ZSBpcyBub3QgdGhlIHJlc3VsdCBvZiBhbiBBQkkgcmV0dXJuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgzMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWJzZW5jZV90b2xlcmFuY2UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg0Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY29tbWl0dGVlX2dyYWNlX3BlcmlvZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODE3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb21taXR0ZWVfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg0N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY29tbWl0dGVlX2xhc3RfYW5jaG9yIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MjJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNvbW1pdHRlZV9tZW1iZXJzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MjddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNvbW1pdHRlZV92b3RlcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjU5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5kYWVtb25fb3BzX2Z1bmRpbmdfYnBzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MDldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmRpc2N1c3Npb25fZHVyYXRpb25fbGFyZ2UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjcwNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGlzY3Vzc2lvbl9kdXJhdGlvbl9tZWRpdW0gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY5OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGlzY3Vzc2lvbl9kdXJhdGlvbl9zbWFsbCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzE0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5kaXNjdXNzaW9uX2R1cmF0aW9uX3hsYXJnZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODM3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5nb3Zlcm5hbmNlX3BlcmlvZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjg0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tYXhfcmVxdWVzdGVkX2Ftb3VudF9sYXJnZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjc5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tYXhfcmVxdWVzdGVkX2Ftb3VudF9tZWRpdW0gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY3NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubWF4X3JlcXVlc3RlZF9hbW91bnRfc21hbGwgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY2OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubWluX3JlcXVlc3RlZF9hbW91bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY1NCw3NDQ4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vcGVuX3Byb3Bvc2FsX2ZlZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjMyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wYXVzZWRfcHJvcG9zYWxzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MjddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBhdXNlZF9yZWdpc3RyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjY0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wcm9wb3NhbF9jb21taXRtZW50X2JwcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzc3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5xdW9ydW1fbGFyZ2UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc3Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucXVvcnVtX21lZGl1bSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzY3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5xdW9ydW1fc21hbGwgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc0M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudm90aW5nX2R1cmF0aW9uX2xhcmdlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MzhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnZvdGluZ19kdXJhdGlvbl9tZWRpdW0gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjczM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudm90aW5nX2R1cmF0aW9uX3NtYWxsIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NDhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnZvdGluZ19kdXJhdGlvbl94bGFyZ2UgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgwMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYud2VpZ2h0ZWRfcXVvcnVtX2xhcmdlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3OTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLndlaWdodGVkX3F1b3J1bV9tZWRpdW0gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc5Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYud2VpZ2h0ZWRfcXVvcnVtX3NtYWxsIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2NDBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnhnb3ZfY291bmNpbCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjQ5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi54Z292X2RhZW1vbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTE0LDE5MjAsMjA4MywyMTMyLDIyNTMsMjM2OCwyNTMwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc3NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDkzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhY2NvdW50PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MjFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUzMCwxNTM5LDE1NDksMTU2MiwxNTcxLDE1ODAsMTU5MCwxNjE0LDE2MzIsMTY1OSwxNjY2LDE2OTEsMTY5OCwxNzQxLDE3NDgsMTc2OCwxNzkyLDE4NTcsMjk2MywzMDM2LDMwOTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ5OSwxNTA4LDE2NDEsMTY1MCwxNjczLDE3MDUsMTcyMywxNzMyLDE3ODIsMTgwMCwxODA5LDE4NDgsMTg2NSwxODczLDIwNzYsMjIxNiwyMzMxLDI0OTMsMjYxMiwyNjIxLDMwNjIsMzA3NCwzMDg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMuY29tbW9uLmFiaV90eXBlcy5YR292UmVnaXN0cnlDb25maWciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTI3LDIxMzksMjI2MCwyMzc1LDI1MzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc3RyaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYyMywxNjgyLDE3MTQsMTc1OSwxODM1LDI2MDNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnT0NBek1pQXhPREUwTkRBd0lESTBNVGt5TURBZ05qQTBPREF3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSWxkeWIyNW5JRkJ5YjNCdmMyRnNJRk4wWVhSMWN5QnZjaUJtYVc1aGJHbDZaV1FpSUNKRlVsSTZJaUF3ZURjd05qRTNOVGN6TmpVMk5EVm1OekkyTlRZM05qazNNemMwTnpJM09TQXdlRGN3TmpFM05UY3pOalUyTkRWbU56QTNNalptTnpBMlpqY3pOakUyWXpjeklEQjROemcyTnpabU56WTFaall6Tm1ZM05UWmxOak0yT1RaaklEQjROemcyTnpabU56WTFaalkwTmpFMk5UWmtObVkyWlNBd2VEWm1OekEyTlRabE5XWTNNRGN5Tm1ZM01EWm1Oek0yTVRaak5XWTJOalkxTmpVZ01IZzJNelptTm1RMlpEWTVOelEzTkRZMU5qVTFaalk1TmpRZ01IZzJNelptTm1RMlpEWTVOelEzTkRZMU5qVTFaalprTmpVMlpEWXlOalUzTWpjeklEQjROak0yWmpaa05tUTJPVGMwTnpRMk5UWTFOV1kzTmpabU56UTJOVGN6SURCNE5qUTJNVFkxTm1RMlpqWmxOV1kyWmpjd05qVTNNall4TnpRMk9UWm1ObVUxWmpZMk56VTJaVFkwTmprMlpUWTNOV1kyTWpjd056TWdNSGczTURjeU5tWTNNRFptTnpNMk1UWmpOV1kyTXpabU5tUTJaRFk1TnpRMlpEWTFObVUzTkRWbU5qSTNNRGN6SURCNE5tUTJPVFpsTldZM01qWTFOekUzTlRZMU56TTNORFkxTmpRMVpqWXhObVEyWmpjMU5tVTNOQ0F3ZURaa05qRTNPRFZtTnpJMk5UY3hOelUyTlRjek56UTJOVFkwTldZMk1UWmtObVkzTlRabE56UTFaamN6Tm1RMk1UWmpObU1nTUhnMlpEWXhOemcxWmpjeU5qVTNNVGMxTmpVM016YzBOalUyTkRWbU5qRTJaRFptTnpVMlpUYzBOV1kyWkRZMU5qUTJPVGMxTm1RZ01IZzJaRFl4TnpnMVpqY3lOalUzTVRjMU5qVTNNemMwTmpVMk5EVm1OakUyWkRabU56VTJaVGMwTldZMll6WXhOekkyTnpZMUlEQjROalEyT1Rjek5qTTNOVGN6TnpNMk9UWm1ObVUxWmpZME56VTNNall4TnpRMk9UWm1ObVUxWmpjek5tUTJNVFpqTm1NZ01IZzJORFk1TnpNMk16YzFOek0zTXpZNU5tWTJaVFZtTmpRM05UY3lOakUzTkRZNU5tWTJaVFZtTm1RMk5UWTBOamszTlRaa0lEQjROalEyT1Rjek5qTTNOVGN6TnpNMk9UWm1ObVUxWmpZME56VTNNall4TnpRMk9UWm1ObVUxWmpaak5qRTNNalkzTmpVZ01IZzJORFk1TnpNMk16YzFOek0zTXpZNU5tWTJaVFZtTmpRM05UY3lOakUzTkRZNU5tWTJaVFZtTnpnMll6WXhOekkyTnpZMUlEQjROelkyWmpjME5qazJaVFkzTldZMk5EYzFOekkyTVRjME5qazJaalpsTldZM016WmtOakUyWXpaaklEQjROelkyWmpjME5qazJaVFkzTldZMk5EYzFOekkyTVRjME5qazJaalpsTldZMlpEWTFOalEyT1RjMU5tUWdNSGczTmpabU56UTJPVFpsTmpjMVpqWTBOelUzTWpZeE56UTJPVFptTm1VMVpqWmpOakUzTWpZM05qVWdNSGczTmpabU56UTJPVFpsTmpjMVpqWTBOelUzTWpZeE56UTJPVFptTm1VMVpqYzRObU0yTVRjeU5qYzJOU0F3ZURjeE56VTJaamN5TnpVMlpEVm1Oek0yWkRZeE5tTTJZeUF3ZURjeE56VTJaamN5TnpVMlpEVm1ObVEyTlRZME5qazNOVFprSURCNE56RTNOVFptTnpJM05UWmtOV1kyWXpZeE56STJOelkxSURCNE56YzJOVFk1TmpjMk9EYzBOalUyTkRWbU56RTNOVFptTnpJM05UWmtOV1kzTXpaa05qRTJZelpqSURCNE56YzJOVFk1TmpjMk9EYzBOalUyTkRWbU56RTNOVFptTnpJM05UWmtOV1kyWkRZMU5qUTJPVGMxTm1RZ01IZzNOelkxTmprMk56WTROelEyTlRZME5XWTNNVGMxTm1ZM01qYzFObVExWmpaak5qRTNNalkzTmpVZ01IZzJNVFl5TnpNMk5UWmxOak0yTlRWbU56UTJaalpqTmpVM01qWXhObVUyTXpZMUlEQjROamMyWmpjMk5qVTNNalpsTmpFMlpUWXpOalUxWmpjd05qVTNNalk1Tm1ZMk5DQXdlRFl6Tm1ZMlpEWmtOamszTkRjME5qVTJOVFZtTmpjM01qWXhOak0yTlRWbU56QTJOVGN5TmprMlpqWTBJREI0TmpNMlpqWmtObVEyT1RjME56UTJOVFkxTldZMll6WXhOek0zTkRWbU5qRTJaVFl6TmpnMlpqY3lJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdJQ0pWYm1GMWRHaHZjbWw2WldRaUlDSldiM1JsY2lCdWIzUWdabTkxYm1RaUlDSk5hWE56YVc1bklFTnZibVpwWnlJZ1ltRnpaVE15S0VOVlVGaFpOVWxCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUVwQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPak13Q2lBZ0lDQXZMeUJyWlhrOWNtVm5YMk5tWnk1SFUxOUxSVmxmV0VkUFZsOURUMVZPUTBsTUxBb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEYzROamMyWmpjMk5XWTJNelptTnpVMlpUWXpOamsyWXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z1FXTmpiM1Z1ZENncExBb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pJM0xUTXhDaUFnSUNBdkx5QWpJRkp2YkdVdFFtRnpaV1FnUVdOalpYTnpJRU52Ym5SeWIyd2dLRkpDUVVNcENpQWdJQ0F2THlCelpXeG1MbmhuYjNaZlkyOTFibU5wYkNBOUlFZHNiMkpoYkZOMFlYUmxLQW9nSUNBZ0x5OGdJQ0FnSUVGalkyOTFiblFvS1N3S0lDQWdJQzh2SUNBZ0lDQnJaWGs5Y21WblgyTm1aeTVIVTE5TFJWbGZXRWRQVmw5RFQxVk9RMGxNTEFvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk16UUtJQ0FnSUM4dklHdGxlVDF5WldkZlkyWm5Ma2RUWDB0RldWOVlSMDlXWDBSQlJVMVBUaXdLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGczT0RZM05tWTNOalZtTmpRMk1UWTFObVEyWmpabENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qTXpDaUFnSUNBdkx5QkJZMk52ZFc1MEtDa3NDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk16SXRNelVLSUNBZ0lDOHZJSE5sYkdZdWVHZHZkbDlrWVdWdGIyNGdQU0JIYkc5aVlXeFRkR0YwWlNnS0lDQWdJQzh2SUNBZ0lDQkJZMk52ZFc1MEtDa3NDaUFnSUNBdkx5QWdJQ0FnYTJWNVBYSmxaMTlqWm1jdVIxTmZTMFZaWDFoSFQxWmZSRUZGVFU5T0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZOREFLSUNBZ0lDOHZJR3RsZVQxeVpXZGZZMlpuTGtkVFgwdEZXVjlRUVZWVFJVUmZVa1ZIU1ZOVVVsa3NDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjROekEyTVRjMU56TTJOVFkwTldZM01qWTFOamMyT1Rjek56UTNNamM1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pNNUNpQWdJQ0F2THlCR1lXeHpaU3dnSUNNZ2JtOXhZVG9nUmtKVU1EQXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3pOeTAwTVFvZ0lDQWdMeThnSXlCU1pXZHBjM1J5ZVNCRGIyNTBjbTlzSUZOMFlYUmxjd29nSUNBZ0x5OGdjMlZzWmk1d1lYVnpaV1JmY21WbmFYTjBjbmtnUFNCSGJHOWlZV3hUZEdGMFpTZ0tJQ0FnSUM4dklDQWdJQ0JHWVd4elpTd2dJQ01nYm05eFlUb2dSa0pVTURBekNpQWdJQ0F2THlBZ0lDQWdhMlY1UFhKbFoxOWpabWN1UjFOZlMwVlpYMUJCVlZORlJGOVNSVWRKVTFSU1dTd0tJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalEwQ2lBZ0lDQXZMeUJyWlhrOWNtVm5YMk5tWnk1SFUxOUxSVmxmVUVGVlUwVkVYMUJTVDFCUFUwRk1VeXdLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGczTURZeE56VTNNelkxTmpRMVpqY3dOekkyWmpjd05tWTNNell4Tm1NM013b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzBNd29nSUNBZ0x5OGdSbUZzYzJVc0lDQWpJRzV2Y1dFNklFWkNWREF3TXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TkRJdE5EVUtJQ0FnSUM4dklITmxiR1l1Y0dGMWMyVmtYM0J5YjNCdmMyRnNjeUE5SUVkc2IySmhiRk4wWVhSbEtBb2dJQ0FnTHk4Z0lDQWdJRVpoYkhObExDQWdJeUJ1YjNGaE9pQkdRbFF3TURNS0lDQWdJQzh2SUNBZ0lDQnJaWGs5Y21WblgyTm1aeTVIVTE5TFJWbGZVRUZWVTBWRVgxQlNUMUJQVTBGTVV5d0tJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalV3Q2lBZ0lDQXZMeUJyWlhrOWNtVm5YMk5tWnk1SFUxOUxSVmxmVDFCRlRsOVFVazlRVDFOQlRGOUdSVVVzQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0Tm1ZM01EWTFObVUxWmpjd056STJaamN3Tm1ZM016WXhObU0xWmpZMk5qVTJOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG8wT1FvZ0lDQWdMeThnVlVsdWREWTBLSEpsWjE5alptY3VUMUJGVGw5UVVrOVFUMU5CVEY5R1JVVXBMQW9nSUNBZ2NIVnphR2x1ZENBeE1EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk5EY3ROVEVLSUNBZ0lDOHZJQ01nUm1WbGN3b2dJQ0FnTHk4Z2MyVnNaaTV2Y0dWdVgzQnliM0J2YzJGc1gyWmxaU0E5SUVkc2IySmhiRk4wWVhSbEtBb2dJQ0FnTHk4Z0lDQWdJRlZKYm5RMk5DaHlaV2RmWTJabkxrOVFSVTVmVUZKUFVFOVRRVXhmUmtWRktTd0tJQ0FnSUM4dklDQWdJQ0JyWlhrOWNtVm5YMk5tWnk1SFUxOUxSVmxmVDFCRlRsOVFVazlRVDFOQlRGOUdSVVVzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z2EyVjVQWEpsWjE5alptY3VSMU5mUzBWWlgwUkJSVTFQVGw5UFVGTmZSbFZPUkVsT1IxOUNVRk1zQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUF3ZURZME5qRTJOVFprTm1ZMlpUVm1ObVkzTURZMU56STJNVGMwTmprMlpqWmxOV1kyTmpjMU5tVTJORFk1Tm1VMk56Vm1OakkzTURjekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QlZTVzUwTmpRb2NtVm5YMk5tWnk1RVFVVk5UMDVmVDFCVFgwWlZUa1JKVGtkZlFsQlRLU3dLSUNBZ0lIQjFjMmhwYm5RZ05UQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalV5TFRVMUNpQWdJQ0F2THlCelpXeG1MbVJoWlcxdmJsOXZjSE5mWm5WdVpHbHVaMTlpY0hNZ1BTQkhiRzlpWVd4VGRHRjBaU2dLSUNBZ0lDOHZJQ0FnSUNCVlNXNTBOalFvY21WblgyTm1aeTVFUVVWTlQwNWZUMUJUWDBaVlRrUkpUa2RmUWxCVEtTd0tJQ0FnSUM4dklDQWdJQ0JyWlhrOWNtVm5YMk5tWnk1SFUxOUxSVmxmUkVGRlRVOU9YMDlRVTE5R1ZVNUVTVTVIWDBKUVV5d0tJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalU0Q2lBZ0lDQXZMeUJyWlhrOWNtVm5YMk5tWnk1SFUxOUxSVmxmVUZKUFVFOVRRVXhmUTA5TlRVbFVUVVZPVkY5Q1VGTXNDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QXdlRGN3TnpJMlpqY3dObVkzTXpZeE5tTTFaall6Tm1ZMlpEWmtOamszTkRaa05qVTJaVGMwTldZMk1qY3dOek1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TlRjS0lDQWdJQzh2SUZWSmJuUTJOQ2h5WldkZlkyWm5MbEJTVDFCUFUwRk1YME5QVFUxSlZFMUZUbFJmUWxCVEtTd0tJQ0FnSUhCMWMyaHBiblFnTXpBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qVTJMVFU1Q2lBZ0lDQXZMeUJ6Wld4bUxuQnliM0J2YzJGc1gyTnZiVzFwZEcxbGJuUmZZbkJ6SUQwZ1IyeHZZbUZzVTNSaGRHVW9DaUFnSUNBdkx5QWdJQ0FnVlVsdWREWTBLSEpsWjE5alptY3VVRkpQVUU5VFFVeGZRMDlOVFVsVVRVVk9WRjlDVUZNcExBb2dJQ0FnTHk4Z0lDQWdJR3RsZVQxeVpXZGZZMlpuTGtkVFgwdEZXVjlRVWs5UVQxTkJURjlEVDAxTlNWUk5SVTVVWDBKUVV5d0tJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJyWlhrOWNtVm5YMk5tWnk1SFUxOUxSVmxmVFVsT1gxSkZVVlZGVTFSRlJGOUJUVTlWVGxRc0NpQWdJQ0JpZVhSbFl5QXhNeUF2THlBd2VEWmtOamsyWlRWbU56STJOVGN4TnpVMk5UY3pOelEyTlRZME5XWTJNVFprTm1ZM05UWmxOelFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TmpNS0lDQWdJQzh2SUZWSmJuUTJOQ2h5WldkZlkyWm5MazFKVGw5U1JWRlZSVk5VUlVSZlFVMVBWVTVVS1N3S0lDQWdJSEIxYzJocGJuUWdNalV3TURBd01EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG8yTVMwMk5Rb2dJQ0FnTHk4Z0l5QlNaWEYxWlhOMFpXUWdRVzF2ZFc1MElFeHBiV2wwY3dvZ0lDQWdMeThnYzJWc1ppNXRhVzVmY21WeGRXVnpkR1ZrWDJGdGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbEtBb2dJQ0FnTHk4Z0lDQWdJRlZKYm5RMk5DaHlaV2RmWTJabkxrMUpUbDlTUlZGVlJWTlVSVVJmUVUxUFZVNVVLU3dLSUNBZ0lDOHZJQ0FnSUNCclpYazljbVZuWDJObVp5NUhVMTlMUlZsZlRVbE9YMUpGVVZWRlUxUkZSRjlCVFU5VlRsUXNDaUFnSUNBdkx5QXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG8yT0FvZ0lDQWdMeThnYTJWNVBYSmxaMTlqWm1jdVIxTmZTMFZaWDAxQldGOVNSVkZWUlZOVVJVUmZRVTFQVlU1VVgxTk5RVXhNTEFvZ0lDQWdZbmwwWldNZ01UUWdMeThnTUhnMlpEWXhOemcxWmpjeU5qVTNNVGMxTmpVM016YzBOalUyTkRWbU5qRTJaRFptTnpVMlpUYzBOV1kzTXpaa05qRTJZelpqQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pZM0NpQWdJQ0F2THlCVlNXNTBOalFvY21WblgyTm1aeTVOUVZoZlVrVlJWVVZUVkVWRVgwRk5UMVZPVkY5VFRVRk1UQ2tzQ2lBZ0lDQndkWE5vYVc1MElESTFNREF3TURBd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalkyTFRZNUNpQWdJQ0F2THlCelpXeG1MbTFoZUY5eVpYRjFaWE4wWldSZllXMXZkVzUwWDNOdFlXeHNJRDBnUjJ4dlltRnNVM1JoZEdVb0NpQWdJQ0F2THlBZ0lDQWdWVWx1ZERZMEtISmxaMTlqWm1jdVRVRllYMUpGVVZWRlUxUkZSRjlCVFU5VlRsUmZVMDFCVEV3cExBb2dJQ0FnTHk4Z0lDQWdJR3RsZVQxeVpXZGZZMlpuTGtkVFgwdEZXVjlOUVZoZlVrVlJWVVZUVkVWRVgwRk5UMVZPVkY5VFRVRk1UQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pjeUNpQWdJQ0F2THlCclpYazljbVZuWDJObVp5NUhVMTlMUlZsZlRVRllYMUpGVVZWRlUxUkZSRjlCVFU5VlRsUmZUVVZFU1ZWTkxBb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z01IZzJaRFl4TnpnMVpqY3lOalUzTVRjMU5qVTNNemMwTmpVMk5EVm1OakUyWkRabU56VTJaVGMwTldZMlpEWTFOalEyT1RjMU5tUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZOekVLSUNBZ0lDOHZJRlZKYm5RMk5DaHlaV2RmWTJabkxrMUJXRjlTUlZGVlJWTlVSVVJmUVUxUFZVNVVYMDFGUkVsVlRTa3NDaUFnSUNCd2RYTm9hVzUwSURFd01EQXdNREF3TURBd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzNNQzAzTXdvZ0lDQWdMeThnYzJWc1ppNXRZWGhmY21WeGRXVnpkR1ZrWDJGdGIzVnVkRjl0WldScGRXMGdQU0JIYkc5aVlXeFRkR0YwWlNnS0lDQWdJQzh2SUNBZ0lDQlZTVzUwTmpRb2NtVm5YMk5tWnk1TlFWaGZVa1ZSVlVWVFZFVkVYMEZOVDFWT1ZGOU5SVVJKVlUwcExBb2dJQ0FnTHk4Z0lDQWdJR3RsZVQxeVpXZGZZMlpuTGtkVFgwdEZXVjlOUVZoZlVrVlJWVVZUVkVWRVgwRk5UMVZPVkY5TlJVUkpWVTBzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvM05nb2dJQ0FnTHk4Z2EyVjVQWEpsWjE5alptY3VSMU5mUzBWWlgwMUJXRjlTUlZGVlJWTlVSVVJmUVUxUFZVNVVYMHhCVWtkRkxBb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z01IZzJaRFl4TnpnMVpqY3lOalUzTVRjMU5qVTNNemMwTmpVMk5EVm1OakUyWkRabU56VTJaVGMwTldZMll6WXhOekkyTnpZMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qYzFDaUFnSUNBdkx5QlZTVzUwTmpRb2NtVm5YMk5tWnk1TlFWaGZVa1ZSVlVWVFZFVkVYMEZOVDFWT1ZGOU1RVkpIUlNrc0NpQWdJQ0J3ZFhOb2FXNTBJREl3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvM05DMDNOd29nSUNBZ0x5OGdjMlZzWmk1dFlYaGZjbVZ4ZFdWemRHVmtYMkZ0YjNWdWRGOXNZWEpuWlNBOUlFZHNiMkpoYkZOMFlYUmxLQW9nSUNBZ0x5OGdJQ0FnSUZWSmJuUTJOQ2h5WldkZlkyWm5MazFCV0Y5U1JWRlZSVk5VUlVSZlFVMVBWVTVVWDB4QlVrZEZLU3dLSUNBZ0lDOHZJQ0FnSUNCclpYazljbVZuWDJObVp5NUhVMTlMUlZsZlRVRllYMUpGVVZWRlUxUkZSRjlCVFU5VlRsUmZURUZTUjBVc0NpQWdJQ0F2THlBcENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzRNZ29nSUNBZ0x5OGdhMlY1UFhKbFoxOWpabWN1UjFOZlMwVlpYMFJKVTBOVlUxTkpUMDVmUkZWU1FWUkpUMDVmVTAxQlRFd3NDaUFnSUNCaWVYUmxZeUF4TnlBdkx5QXdlRFkwTmprM016WXpOelUzTXpjek5qazJaalpsTldZMk5EYzFOekkyTVRjME5qazJaalpsTldZM016WmtOakUyWXpaakNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qZ3hDaUFnSUNBdkx5QlZTVzUwTmpRb2NtVm5YMk5tWnk1RVNWTkRWVk5UU1U5T1gwUlZVa0ZVU1U5T1gxTk5RVXhNS1N3S0lDQWdJR2x1ZEdNZ05DQXZMeUF4T0RFME5EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPamM1TFRnekNpQWdJQ0F2THlBaklGUnBiV1VnVEdsdGFYUnpDaUFnSUNBdkx5QnpaV3htTG1ScGMyTjFjM05wYjI1ZlpIVnlZWFJwYjI1ZmMyMWhiR3dnUFNCSGJHOWlZV3hUZEdGMFpTZ0tJQ0FnSUM4dklDQWdJQ0JWU1c1ME5qUW9jbVZuWDJObVp5NUVTVk5EVlZOVFNVOU9YMFJWVWtGVVNVOU9YMU5OUVV4TUtTd0tJQ0FnSUM4dklDQWdJQ0JyWlhrOWNtVm5YMk5tWnk1SFUxOUxSVmxmUkVsVFExVlRVMGxQVGw5RVZWSkJWRWxQVGw5VFRVRk1UQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pnMkNpQWdJQ0F2THlCclpYazljbVZuWDJObVp5NUhVMTlMUlZsZlJFbFRRMVZUVTBsUFRsOUVWVkpCVkVsUFRsOU5SVVJKVlUwc0NpQWdJQ0JpZVhSbFl5QXhPQ0F2THlBd2VEWTBOamszTXpZek56VTNNemN6TmprMlpqWmxOV1kyTkRjMU56STJNVGMwTmprMlpqWmxOV1kyWkRZMU5qUTJPVGMxTm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklGVkpiblEyTkNoeVpXZGZZMlpuTGtSSlUwTlZVMU5KVDA1ZlJGVlNRVlJKVDA1ZlRVVkVTVlZOS1N3S0lDQWdJR2x1ZEdNZ05DQXZMeUF4T0RFME5EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPamcwTFRnM0NpQWdJQ0F2THlCelpXeG1MbVJwYzJOMWMzTnBiMjVmWkhWeVlYUnBiMjVmYldWa2FYVnRJRDBnUjJ4dlltRnNVM1JoZEdVb0NpQWdJQ0F2THlBZ0lDQWdWVWx1ZERZMEtISmxaMTlqWm1jdVJFbFRRMVZUVTBsUFRsOUVWVkpCVkVsUFRsOU5SVVJKVlUwcExBb2dJQ0FnTHk4Z0lDQWdJR3RsZVQxeVpXZGZZMlpuTGtkVFgwdEZXVjlFU1ZORFZWTlRTVTlPWDBSVlVrRlVTVTlPWDAxRlJFbFZUU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2prd0NpQWdJQ0F2THlCclpYazljbVZuWDJObVp5NUhVMTlMUlZsZlJFbFRRMVZUVTBsUFRsOUVWVkpCVkVsUFRsOU1RVkpIUlN3S0lDQWdJR0o1ZEdWaklERTVJQzh2SURCNE5qUTJPVGN6TmpNM05UY3pOek0yT1RabU5tVTFaalkwTnpVM01qWXhOelEyT1RabU5tVTFaalpqTmpFM01qWTNOalVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2T0RrS0lDQWdJQzh2SUZWSmJuUTJOQ2h5WldkZlkyWm5Ma1JKVTBOVlUxTkpUMDVmUkZWU1FWUkpUMDVmVEVGU1IwVXBMQW9nSUNBZ2FXNTBZeUEwSUM4dklERTRNVFEwTURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk9EZ3RPVEVLSUNBZ0lDOHZJSE5sYkdZdVpHbHpZM1Z6YzJsdmJsOWtkWEpoZEdsdmJsOXNZWEpuWlNBOUlFZHNiMkpoYkZOMFlYUmxLQW9nSUNBZ0x5OGdJQ0FnSUZWSmJuUTJOQ2h5WldkZlkyWm5Ma1JKVTBOVlUxTkpUMDVmUkZWU1FWUkpUMDVmVEVGU1IwVXBMQW9nSUNBZ0x5OGdJQ0FnSUd0bGVUMXlaV2RmWTJabkxrZFRYMHRGV1Y5RVNWTkRWVk5UU1U5T1gwUlZVa0ZVU1U5T1gweEJVa2RGTEFvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk9UUUtJQ0FnSUM4dklHdGxlVDF5WldkZlkyWm5Ma2RUWDB0RldWOUVTVk5EVlZOVFNVOU9YMFJWVWtGVVNVOU9YMWhNUVZKSFJTd0tJQ0FnSUdKNWRHVmpJREl3SUM4dklEQjROalEyT1Rjek5qTTNOVGN6TnpNMk9UWm1ObVUxWmpZME56VTNNall4TnpRMk9UWm1ObVUxWmpjNE5tTTJNVGN5TmpjMk5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzVNd29nSUNBZ0x5OGdWVWx1ZERZMEtISmxaMTlqWm1jdVJFbFRRMVZUVTBsUFRsOUVWVkpCVkVsUFRsOVlURUZTUjBVcExBb2dJQ0FnYVc1MFl5QTFJQzh2SURJME1Ua3lNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2T1RJdE9UVUtJQ0FnSUM4dklITmxiR1l1WkdselkzVnpjMmx2Ymw5a2RYSmhkR2x2Ymw5NGJHRnlaMlVnUFNCSGJHOWlZV3hUZEdGMFpTZ0tJQ0FnSUM4dklDQWdJQ0JWU1c1ME5qUW9jbVZuWDJObVp5NUVTVk5EVlZOVFNVOU9YMFJWVWtGVVNVOU9YMWhNUVZKSFJTa3NDaUFnSUNBdkx5QWdJQ0FnYTJWNVBYSmxaMTlqWm1jdVIxTmZTMFZaWDBSSlUwTlZVMU5KVDA1ZlJGVlNRVlJKVDA1ZldFeEJVa2RGTEFvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk9UZ0tJQ0FnSUM4dklHdGxlVDF5WldkZlkyWm5Ma2RUWDB0RldWOVdUMVJKVGtkZlJGVlNRVlJKVDA1ZlUwMUJURXdzQ2lBZ0lDQmllWFJsWXlBeU1TQXZMeUF3ZURjMk5tWTNORFk1Tm1VMk56Vm1OalEzTlRjeU5qRTNORFk1Tm1ZMlpUVm1Oek0yWkRZeE5tTTJZd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG81TndvZ0lDQWdMeThnVlVsdWREWTBLSEpsWjE5alptY3VWazlVU1U1SFgwUlZVa0ZVU1U5T1gxTk5RVXhNS1N3S0lDQWdJR2x1ZEdNZ05pQXZMeUEyTURRNE1EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZPVFl0T1RrS0lDQWdJQzh2SUhObGJHWXVkbTkwYVc1blgyUjFjbUYwYVc5dVgzTnRZV3hzSUQwZ1IyeHZZbUZzVTNSaGRHVW9DaUFnSUNBdkx5QWdJQ0FnVlVsdWREWTBLSEpsWjE5alptY3VWazlVU1U1SFgwUlZVa0ZVU1U5T1gxTk5RVXhNS1N3S0lDQWdJQzh2SUNBZ0lDQnJaWGs5Y21WblgyTm1aeTVIVTE5TFJWbGZWazlVU1U1SFgwUlZVa0ZVU1U5T1gxTk5RVXhNTEFvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1UQXlDaUFnSUNBdkx5QnJaWGs5Y21WblgyTm1aeTVIVTE5TFJWbGZWazlVU1U1SFgwUlZVa0ZVU1U5T1gwMUZSRWxWVFN3S0lDQWdJR0o1ZEdWaklESXlJQzh2SURCNE56WTJaamMwTmprMlpUWTNOV1kyTkRjMU56STJNVGMwTmprMlpqWmxOV1kyWkRZMU5qUTJPVGMxTm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1UQXhDaUFnSUNBdkx5QlZTVzUwTmpRb2NtVm5YMk5tWnk1V1QxUkpUa2RmUkZWU1FWUkpUMDVmVFVWRVNWVk5LU3dLSUNBZ0lHbHVkR01nTmlBdkx5QTJNRFE0TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1UQXdMVEV3TXdvZ0lDQWdMeThnYzJWc1ppNTJiM1JwYm1kZlpIVnlZWFJwYjI1ZmJXVmthWFZ0SUQwZ1IyeHZZbUZzVTNSaGRHVW9DaUFnSUNBdkx5QWdJQ0FnVlVsdWREWTBLSEpsWjE5alptY3VWazlVU1U1SFgwUlZVa0ZVU1U5T1gwMUZSRWxWVFNrc0NpQWdJQ0F2THlBZ0lDQWdhMlY1UFhKbFoxOWpabWN1UjFOZlMwVlpYMVpQVkVsT1IxOUVWVkpCVkVsUFRsOU5SVVJKVlUwc0NpQWdJQ0F2THlBcENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3hNRFlLSUNBZ0lDOHZJR3RsZVQxeVpXZGZZMlpuTGtkVFgwdEZXVjlXVDFSSlRrZGZSRlZTUVZSSlQwNWZURUZTUjBVc0NpQWdJQ0JpZVhSbFl5QXlNeUF2THlBd2VEYzJObVkzTkRZNU5tVTJOelZtTmpRM05UY3lOakUzTkRZNU5tWTJaVFZtTm1NMk1UY3lOamMyTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRveE1EVUtJQ0FnSUM4dklGVkpiblEyTkNoeVpXZGZZMlpuTGxaUFZFbE9SMTlFVlZKQlZFbFBUbDlNUVZKSFJTa3NDaUFnSUNCd2RYTm9hVzUwSURFeU1EazJNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TVRBMExURXdOd29nSUNBZ0x5OGdjMlZzWmk1MmIzUnBibWRmWkhWeVlYUnBiMjVmYkdGeVoyVWdQU0JIYkc5aVlXeFRkR0YwWlNnS0lDQWdJQzh2SUNBZ0lDQlZTVzUwTmpRb2NtVm5YMk5tWnk1V1QxUkpUa2RmUkZWU1FWUkpUMDVmVEVGU1IwVXBMQW9nSUNBZ0x5OGdJQ0FnSUd0bGVUMXlaV2RmWTJabkxrZFRYMHRGV1Y5V1QxUkpUa2RmUkZWU1FWUkpUMDVmVEVGU1IwVXNDaUFnSUNBdkx5QXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG94TVRBS0lDQWdJQzh2SUd0bGVUMXlaV2RmWTJabkxrZFRYMHRGV1Y5V1QxUkpUa2RmUkZWU1FWUkpUMDVmV0V4QlVrZEZMQW9nSUNBZ1lubDBaV01nTWpRZ0x5OGdNSGczTmpabU56UTJPVFpsTmpjMVpqWTBOelUzTWpZeE56UTJPVFptTm1VMVpqYzRObU0yTVRjeU5qYzJOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG94TURrS0lDQWdJQzh2SUZWSmJuUTJOQ2h5WldkZlkyWm5MbFpQVkVsT1IxOUVWVkpCVkVsUFRsOVlURUZTUjBVcExBb2dJQ0FnYVc1MFl5QTFJQzh2SURJME1Ua3lNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TVRBNExURXhNUW9nSUNBZ0x5OGdjMlZzWmk1MmIzUnBibWRmWkhWeVlYUnBiMjVmZUd4aGNtZGxJRDBnUjJ4dlltRnNVM1JoZEdVb0NpQWdJQ0F2THlBZ0lDQWdWVWx1ZERZMEtISmxaMTlqWm1jdVZrOVVTVTVIWDBSVlVrRlVTVTlPWDFoTVFWSkhSU2tzQ2lBZ0lDQXZMeUFnSUNBZ2EyVjVQWEpsWjE5alptY3VSMU5mUzBWWlgxWlBWRWxPUjE5RVZWSkJWRWxQVGw5WVRFRlNSMFVzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRveE1UWUtJQ0FnSUM4dklHdGxlVDF5WldkZlkyWm5Ma2RUWDB0RldWOURUMDFOU1ZSVVJVVmZTVVFzQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TmpNMlpqWmtObVEyT1RjME56UTJOVFkxTldZMk9UWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPakV4TlFvZ0lDQWdMeThnZEhsd0xrSjVkR1Z6TXpJdVpuSnZiVjlpZVhSbGN5aGlJakFpSUNvZ016SXBMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNekF6TURNd016QXpNRE13TXpBek1ETXdNekF6TURNd016QXpNRE13TXpBek1ETXdNekF6TURNd016QXpNRE13TXpBek1ETXdNekF6TURNd016QXpNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG94TVRNdE1URTNDaUFnSUNBdkx5QWpJSGhIYjNZZ1EyOXRiV2wwZEdWbENpQWdJQ0F2THlCelpXeG1MbU52YlcxcGRIUmxaVjlwWkNBOUlFZHNiMkpoYkZOMFlYUmxLQW9nSUNBZ0x5OGdJQ0FnSUhSNWNDNUNlWFJsY3pNeUxtWnliMjFmWW5sMFpYTW9ZaUl3SWlBcUlETXlLU3dLSUNBZ0lDOHZJQ0FnSUNCclpYazljbVZuWDJObVp5NUhVMTlMUlZsZlEwOU5UVWxVVkVWRlgwbEVMQW9nSUNBZ0x5OGdLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TVRJd0NpQWdJQ0F2THlCclpYazljbVZuWDJObVp5NUhVMTlMUlZsZlEwOU5UVWxVVkVWRlgwMUZUVUpGVWxNc0NpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE5qTTJaalprTm1RMk9UYzBOelEyTlRZMU5XWTJaRFkxTm1RMk1qWTFOekkzTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRveE1Ua0tJQ0FnSUM4dklGVkpiblEyTkNncExBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1URTRMVEV5TVFvZ0lDQWdMeThnYzJWc1ppNWpiMjF0YVhSMFpXVmZiV1Z0WW1WeWN5QTlJRWRzYjJKaGJGTjBZWFJsS0FvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNncExBb2dJQ0FnTHk4Z0lDQWdJR3RsZVQxeVpXZGZZMlpuTGtkVFgwdEZXVjlEVDAxTlNWUlVSVVZmVFVWTlFrVlNVeXdLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pFeU5Bb2dJQ0FnTHk4Z2EyVjVQWEpsWjE5alptY3VSMU5mUzBWWlgwTlBUVTFKVkZSRlJWOVdUMVJGVXl3S0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE5qTTJaalprTm1RMk9UYzBOelEyTlRZMU5XWTNOalptTnpRMk5UY3pDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPakV5TXdvZ0lDQWdMeThnVlVsdWREWTBLQ2tzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG94TWpJdE1USTFDaUFnSUNBdkx5QnpaV3htTG1OdmJXMXBkSFJsWlY5MmIzUmxjeUE5SUVkc2IySmhiRk4wWVhSbEtBb2dJQ0FnTHk4Z0lDQWdJRlZKYm5RMk5DZ3BMQW9nSUNBZ0x5OGdJQ0FnSUd0bGVUMXlaV2RmWTJabkxrZFRYMHRGV1Y5RFQwMU5TVlJVUlVWZlZrOVVSVk1zQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRveE16QUtJQ0FnSUM4dklHdGxlVDF5WldkZlkyWm5Ma2RUWDB0RldWOVJWVTlTVlUxZlUwMUJURXdzQ2lBZ0lDQmllWFJsWXlBeU5TQXZMeUF3ZURjeE56VTJaamN5TnpVMlpEVm1Oek0yWkRZeE5tTTJZd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG94TWprS0lDQWdJQzh2SUZWSmJuUTJOQ2h5WldkZlkyWm5MbEZWVDFKVlRWOVRUVUZNVENrc0NpQWdJQ0J3ZFhOb2FXNTBJRE13TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1USTNMVEV6TVFvZ0lDQWdMeThnSXlCUmRXOXlkVzF6Q2lBZ0lDQXZMeUJ6Wld4bUxuRjFiM0oxYlY5emJXRnNiQ0E5SUVkc2IySmhiRk4wWVhSbEtBb2dJQ0FnTHk4Z0lDQWdJRlZKYm5RMk5DaHlaV2RmWTJabkxsRlZUMUpWVFY5VFRVRk1UQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2EyVjVQWEpsWjE5alptY3VSMU5mUzBWWlgxRlZUMUpWVFY5VFRVRk1UQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pFek5Bb2dJQ0FnTHk4Z2EyVjVQWEpsWjE5alptY3VSMU5mUzBWWlgxRlZUMUpWVFY5TlJVUkpWVTBzQ2lBZ0lDQmllWFJsWXlBeU5pQXZMeUF3ZURjeE56VTJaamN5TnpVMlpEVm1ObVEyTlRZME5qazNOVFprQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pFek13b2dJQ0FnTHk4Z1ZVbHVkRFkwS0hKbFoxOWpabWN1VVZWUFVsVk5YMDFGUkVsVlRTa3NDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3hNekl0TVRNMUNpQWdJQ0F2THlCelpXeG1MbkYxYjNKMWJWOXRaV1JwZFcwZ1BTQkhiRzlpWVd4VGRHRjBaU2dLSUNBZ0lDOHZJQ0FnSUNCVlNXNTBOalFvY21WblgyTm1aeTVSVlU5U1ZVMWZUVVZFU1ZWTktTd0tJQ0FnSUM4dklDQWdJQ0JyWlhrOWNtVm5YMk5tWnk1SFUxOUxSVmxmVVZWUFVsVk5YMDFGUkVsVlRTd0tJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPakV6T0FvZ0lDQWdMeThnYTJWNVBYSmxaMTlqWm1jdVIxTmZTMFZaWDFGVlQxSlZUVjlNUVZKSFJTd0tJQ0FnSUdKNWRHVmpJREkzSUM4dklEQjROekUzTlRabU56STNOVFprTldZMll6WXhOekkyTnpZMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qRXpOd29nSUNBZ0x5OGdWVWx1ZERZMEtISmxaMTlqWm1jdVVWVlBVbFZOWDB4QlVrZEZLU3dLSUNBZ0lIQjFjMmhwYm5RZ056QXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG94TXpZdE1UTTVDaUFnSUNBdkx5QnpaV3htTG5GMWIzSjFiVjlzWVhKblpTQTlJRWRzYjJKaGJGTjBZWFJsS0FvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNoeVpXZGZZMlpuTGxGVlQxSlZUVjlNUVZKSFJTa3NDaUFnSUNBdkx5QWdJQ0FnYTJWNVBYSmxaMTlqWm1jdVIxTmZTMFZaWDFGVlQxSlZUVjlNUVZKSFJTd0tJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPakUwTkFvZ0lDQWdMeThnYTJWNVBYSmxaMTlqWm1jdVIxTmZTMFZaWDFkRlNVZElWRVZFWDFGVlQxSlZUVjlUVFVGTVRDd0tJQ0FnSUdKNWRHVmpJREk0SUM4dklEQjROemMyTlRZNU5qYzJPRGMwTmpVMk5EVm1OekUzTlRabU56STNOVFprTldZM016WmtOakUyWXpaakNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qRTBNd29nSUNBZ0x5OGdWVWx1ZERZMEtISmxaMTlqWm1jdVYwVkpSMGhVUlVSZlVWVlBVbFZOWDFOTlFVeE1LU3dLSUNBZ0lIQjFjMmhwYm5RZ05UQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG94TkRFdE1UUTFDaUFnSUNBdkx5QWpJRmRsYVdkb2RHVmtJRkYxYjNKMWJYTUtJQ0FnSUM4dklITmxiR1l1ZDJWcFoyaDBaV1JmY1hWdmNuVnRYM050WVd4c0lEMGdSMnh2WW1Gc1UzUmhkR1VvQ2lBZ0lDQXZMeUFnSUNBZ1ZVbHVkRFkwS0hKbFoxOWpabWN1VjBWSlIwaFVSVVJmVVZWUFVsVk5YMU5OUVV4TUtTd0tJQ0FnSUM4dklDQWdJQ0JyWlhrOWNtVm5YMk5tWnk1SFUxOUxSVmxmVjBWSlIwaFVSVVJmVVZWUFVsVk5YMU5OUVV4TUxBb2dJQ0FnTHk4Z0tRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNVFE0Q2lBZ0lDQXZMeUJyWlhrOWNtVm5YMk5tWnk1SFUxOUxSVmxmVjBWSlIwaFVSVVJmVVZWUFVsVk5YMDFGUkVsVlRTd0tJQ0FnSUdKNWRHVmpJREk1SUM4dklEQjROemMyTlRZNU5qYzJPRGMwTmpVMk5EVm1OekUzTlRabU56STNOVFprTldZMlpEWTFOalEyT1RjMU5tUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNVFEzQ2lBZ0lDQXZMeUJWU1c1ME5qUW9jbVZuWDJObVp5NVhSVWxIU0ZSRlJGOVJWVTlTVlUxZlRVVkVTVlZOS1N3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pFME5pMHhORGtLSUNBZ0lDOHZJSE5sYkdZdWQyVnBaMmgwWldSZmNYVnZjblZ0WDIxbFpHbDFiU0E5SUVkc2IySmhiRk4wWVhSbEtBb2dJQ0FnTHk4Z0lDQWdJRlZKYm5RMk5DaHlaV2RmWTJabkxsZEZTVWRJVkVWRVgxRlZUMUpWVFY5TlJVUkpWVTBwTEFvZ0lDQWdMeThnSUNBZ0lHdGxlVDF5WldkZlkyWm5Ma2RUWDB0RldWOVhSVWxIU0ZSRlJGOVJWVTlTVlUxZlRVVkVTVlZOTEFvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1UVXlDaUFnSUNBdkx5QnJaWGs5Y21WblgyTm1aeTVIVTE5TFJWbGZWMFZKUjBoVVJVUmZVVlZQVWxWTlgweEJVa2RGTEFvZ0lDQWdZbmwwWldNZ016QWdMeThnTUhnM056WTFOamsyTnpZNE56UTJOVFkwTldZM01UYzFObVkzTWpjMU5tUTFaalpqTmpFM01qWTNOalVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TVRVeENpQWdJQ0F2THlCVlNXNTBOalFvY21WblgyTm1aeTVYUlVsSFNGUkZSRjlSVlU5U1ZVMWZURUZTUjBVcExBb2dJQ0FnY0hWemFHbHVkQ0EzTURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qRTFNQzB4TlRNS0lDQWdJQzh2SUhObGJHWXVkMlZwWjJoMFpXUmZjWFZ2Y25WdFgyeGhjbWRsSUQwZ1IyeHZZbUZzVTNSaGRHVW9DaUFnSUNBdkx5QWdJQ0FnVlVsdWREWTBLSEpsWjE5alptY3VWMFZKUjBoVVJVUmZVVlZQVWxWTlgweEJVa2RGS1N3S0lDQWdJQzh2SUNBZ0lDQnJaWGs5Y21WblgyTm1aeTVIVTE5TFJWbGZWMFZKUjBoVVJVUmZVVlZQVWxWTlgweEJVa2RGTEFvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1UVTNDaUFnSUNBdkx5QlZTVzUwTmpRb2NtVm5YMk5tWnk1QlFsTkZUa05GWDFSUFRFVlNRVTVEUlNrc0lHdGxlVDF5WldkZlkyWm5Ma2RUWDB0RldWOUJRbE5GVGtORlgxUlBURVZTUVU1RFJRb2dJQ0FnWW5sMFpXTWdNekVnTHk4Z01IZzJNVFl5TnpNMk5UWmxOak0yTlRWbU56UTJaalpqTmpVM01qWXhObVUyTXpZMUNpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TVRVMUxURTFPQW9nSUNBZ0x5OGdJeUJPWlhjZ1ZtRnlhV0ZpYkdWeklDaHBiblJ5YjJSMVkyVmtJR0ZtZEdWeUlFMWhhVzVPWlhRZ1pHVndiRzk1YldWdWRDa0tJQ0FnSUM4dklITmxiR1l1WVdKelpXNWpaVjkwYjJ4bGNtRnVZMlVnUFNCSGJHOWlZV3hUZEdGMFpTZ0tJQ0FnSUM4dklDQWdJQ0JWU1c1ME5qUW9jbVZuWDJObVp5NUJRbE5GVGtORlgxUlBURVZTUVU1RFJTa3NJR3RsZVQxeVpXZGZZMlpuTGtkVFgwdEZXVjlCUWxORlRrTkZYMVJQVEVWU1FVNURSUW9nSUNBZ0x5OGdLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TVRZd0NpQWdJQ0F2THlCVlNXNTBOalFvY21WblgyTm1aeTVIVDFaRlVrNUJUa05GWDFCRlVrbFBSQ2tzSUd0bGVUMXlaV2RmWTJabkxrZFRYMHRGV1Y5SFQxWkZVazVCVGtORlgxQkZVa2xQUkFvZ0lDQWdZbmwwWldNZ016SWdMeThnTUhnMk56Wm1OelkyTlRjeU5tVTJNVFpsTmpNMk5UVm1OekEyTlRjeU5qazJaalkwQ2lBZ0lDQndkWE5vYVc1MElERXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1UVTVMVEUyTVFvZ0lDQWdMeThnYzJWc1ppNW5iM1psY201aGJtTmxYM0JsY21sdlpDQTlJRWRzYjJKaGJGTjBZWFJsS0FvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNoeVpXZGZZMlpuTGtkUFZrVlNUa0ZPUTBWZlVFVlNTVTlFS1N3Z2EyVjVQWEpsWjE5alptY3VSMU5mUzBWWlgwZFBWa1ZTVGtGT1EwVmZVRVZTU1U5RUNpQWdJQ0F2THlBcENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3hOalFLSUNBZ0lDOHZJR3RsZVQxeVpXZGZZMlpuTGtkVFgwdEZXVjlEVDAxTlNWUlVSVVZmUjFKQlEwVmZVRVZTU1U5RUxBb2dJQ0FnWW5sMFpXTWdNek1nTHk4Z01IZzJNelptTm1RMlpEWTVOelEzTkRZMU5qVTFaalkzTnpJMk1UWXpOalUxWmpjd05qVTNNalk1Tm1ZMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3hOak1LSUNBZ0lDOHZJRlZKYm5RMk5DaHlaV2RmWTJabkxrTlBUVTFKVkZSRlJWOUhVa0ZEUlY5UVJWSkpUMFFwTEFvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRveE5qSXRNVFkxQ2lBZ0lDQXZMeUJ6Wld4bUxtTnZiVzFwZEhSbFpWOW5jbUZqWlY5d1pYSnBiMlFnUFNCSGJHOWlZV3hUZEdGMFpTZ0tJQ0FnSUM4dklDQWdJQ0JWU1c1ME5qUW9jbVZuWDJObVp5NURUMDFOU1ZSVVJVVmZSMUpCUTBWZlVFVlNTVTlFS1N3S0lDQWdJQzh2SUNBZ0lDQnJaWGs5Y21WblgyTm1aeTVIVTE5TFJWbGZRMDlOVFVsVVZFVkZYMGRTUVVORlgxQkZVa2xQUkN3S0lDQWdJQzh2SUNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qRTJOd29nSUNBZ0x5OGdWVWx1ZERZMEtDa3NJR3RsZVQxeVpXZGZZMlpuTGtkVFgwdEZXVjlEVDAxTlNWUlVSVVZmVEVGVFZGOUJUa05JVDFJS0lDQWdJR0o1ZEdWaklETTBJQzh2SURCNE5qTTJaalprTm1RMk9UYzBOelEyTlRZMU5XWTJZell4TnpNM05EVm1OakUyWlRZek5qZzJaamN5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG94TmpZdE1UWTRDaUFnSUNBdkx5QnpaV3htTG1OdmJXMXBkSFJsWlY5c1lYTjBYMkZ1WTJodmNpQTlJRWRzYjJKaGJGTjBZWFJsS0FvZ0lDQWdMeThnSUNBZ0lGVkpiblEyTkNncExDQnJaWGs5Y21WblgyTm1aeTVIVTE5TFJWbGZRMDlOVFVsVVZFVkZYMHhCVTFSZlFVNURTRTlTQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPakkwQ2lBZ0lDQXZMeUJqYkdGemN5QllaMjkyVW1WbmFYTjBjbmxOYjJOcktGaEhiM1pTWldkcGMzUnllVWx1ZEdWeVptRmpaU2s2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwT1RVMll6RmhZaUF2THlCdFpYUm9iMlFnSW5Wd1pHRjBaVjk0WjI5MlgzSmxaMmx6ZEhKNUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDkxY0dSaGRHVmZlR2R2ZGw5eVpXZHBjM1J5ZVY5eWIzVjBaVUEwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEVTBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRPVFU1WXpRM05qSWdNSGcyWXpGbU5UWTBaQ0F3ZUdVeE1HRTFNVEpsSURCNE9EWm1OMlV3WlRZZ01IZ3pPV1V5Tm1RNFlTQXdlRGs0TXpVeVpUZzJJREI0Wm1FMFpXUTJaVElnTUhoa05tTTVZMk14WVNBd2VEVmpORGcwTURVMUlEQjRNemRrTm1Ga1pqRWdNSGhrTkRJeE5tSTJaU0F3ZUdKaE9EVXlNR1l5SURCNE1UWTNOMkl6TUdVZ01IZzROR0kzWkRJMk9DQXdlR0ZtTjJZeE9EWXdJREI0WVRBNE1tTmxaamdnTUhoa1pqTTVabVJpT1NBd2VHTmhNR1kyWVROaElEQjRNMk16TVdKak1ESWdNSGd3WkRKak56ZzVNU0F3ZURRMU1EYzNNemt3SURCNE9UTm1ZV05rWW1FZ01IaGpaVGhpTTJFeFl5QXdlR1poWldFd09ERm1JREI0TUdSaE1qYzRPRFVnTUhnM1lUUm1aV1UwTXlBd2VEVXlaR1F4TUdRM0lEQjRaRFJrTXpkaE5qUWdNSGd6TkRNME9XUmpZeUF3ZURFMU9HWTRaR1EySURCNE5XWmxNalU1TXpVZ01IaGtZakkzWWpsaFppQXdlR1kxT1RFd056VTJJREI0TmpVMk1UQmhPV1lnTUhobVpHTTJPVFZqTWlBd2VHSmhPVEJoWWpVMElEQjRNV0UyTnpSaU5EVWdNSGhoT0dRMVlXVTVOQ0F3ZURaaFpUVmxZalEySURCNE1qYzJNekJrTmpVZ01IZzRNalJtT1RoaVl5QXdlRFE1TlRRNFltRXdJREI0T0RJMk56ZzBaallnTUhneU5qazRNekl3TUNBd2VHTXpPRFppTURObUlEQjRaR0prT0ROa1pEa2dMeThnYldWMGFHOWtJQ0pwYm1sMFgzQnliM0J2YzJGc1gyTnZiblJ5WVdOMEtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0pzYjJGa1gzQnliM0J2YzJGc1gyTnZiblJ5WVdOMEtIVnBiblEyTkN4aWVYUmxXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlaR1ZzWlhSbFgzQnliM0J2YzJGc1gyTnZiblJ5WVdOMFgySnZlQ2dwZG05cFpDSXNJRzFsZEdodlpDQWljR0YxYzJWZmNtVm5hWE4wY25rb0tYWnZhV1FpTENCdFpYUm9iMlFnSW5CaGRYTmxYM0J5YjNCdmMyRnNjeWdwZG05cFpDSXNJRzFsZEdodlpDQWljbVZ6ZFcxbFgzSmxaMmx6ZEhKNUtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpYTjFiV1ZmY0hKdmNHOXpZV3h6S0NsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSZmVHZHZkbDl0WVc1aFoyVnlLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBYM0JoZVc5eUtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFgzaG5iM1pmWTI5MWJtTnBiQ2hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRjk0WjI5MlgzTjFZbk5qY21saVpYSW9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUmZhM2xqWDNCeWIzWnBaR1Z5S0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDJOdmJXMXBkSFJsWlY5dFlXNWhaMlZ5S0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDNobmIzWmZaR0ZsYlc5dUtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTI5dVptbG5YM2huYjNaZmNtVm5hWE4wY25rb0tIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJORnN6WFN4MWFXNTBOalJiTkYwc2RXbHVkRFkwV3pSZExIVnBiblEyTkZzelhTeDFhVzUwTmpSYk0xMHNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk4xWW5OamNtbGlaVjk0WjI5MktHRmtaSEpsYzNNc2NHRjVLWFp2YVdRaUxDQnRaWFJvYjJRZ0luVnVjM1ZpYzJOeWFXSmxYM2huYjNZb0tYWnZhV1FpTENCdFpYUm9iMlFnSW5WdWMzVmljMk55YVdKbFgyRmljMlZ1ZEdWbEtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVhCd2NtOTJaVjl6ZFdKelkzSnBZbVZmZUdkdmRpaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WcVpXTjBYM04xWW5OamNtbGlaVjk0WjI5MktIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p5WlhGMVpYTjBYM04xWW5OamNtbGlaVjk0WjI5MktHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBOalFzY0dGNUtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbGNYVmxjM1JmZFc1emRXSnpZM0pwWW1WZmVHZHZkaWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERZMExIQmhlU2wyYjJsa0lpd2diV1YwYUc5a0lDSmhjSEJ5YjNabFgzVnVjM1ZpYzJOeWFXSmxYM2huYjNZb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsYW1WamRGOTFibk4xWW5OamNtbGlaVjk0WjI5MktIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSZmRtOTBhVzVuWDJGalkyOTFiblFvWVdSa2NtVnpjeXhoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTjFZbk5qY21saVpWOXdjbTl3YjNObGNpaHdZWGtwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDNCeWIzQnZjMlZ5WDJ0NVl5aGhaR1J5WlhOekxHSnZiMndzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltUmxZMnhoY21WZlkyOXRiV2wwZEdWbEtHSjVkR1ZiTXpKZExIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWliM0JsYmw5d2NtOXdiM05oYkNod1lYa3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSjJiM1JsWDNCeWIzQnZjMkZzS0hWcGJuUTJOQ3hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZFc1aGMzTnBaMjVmWVdKelpXNTBaV1ZmWm5KdmJWOXdjbTl3YjNOaGJDaDFhVzUwTmpRc1lXUmtjbVZ6YzF0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5CaGVWOW5jbUZ1ZEY5d2NtOXdiM05oYkNoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlabWx1WVd4cGVtVmZjSEp2Y0c5ellXd29kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1SeWIzQmZjSEp2Y0c5ellXd29kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1SbGNHOXphWFJmWm5WdVpITW9jR0Y1S1hadmFXUWlMQ0J0WlhSb2IyUWdJbmRwZEdoa2NtRjNYMloxYm1SektIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0ozYVhSb1pISmhkMTloZG1GcGJHRmliR1ZmWm5WdVpITW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGOWhkbUZwYkdGaWJHVmZablZ1WkhNb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBYM04wWVhSbEtDa29ZbTl2YkN4aWIyOXNMR0ZrWkhKbGMzTXNZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMFd6TmRMSFZwYm5RMk5GczBYU3gxYVc1ME5qUmJORjBzZFdsdWREWTBXek5kTEhWcGJuUTJORnN6WFN4MWFXNTBOalFzZFdsdWREWTBMR0o1ZEdWYk16SmRMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwWDNobmIzWmZZbTk0S0dGa1pISmxjM01wS0NoaFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTeGliMjlzS1NJc0lHMWxkR2h2WkNBaVoyVjBYM0J5YjNCdmMyVnlYMkp2ZUNoaFpHUnlaWE56S1Nnb1ltOXZiQ3hpYjI5c0xIVnBiblEyTkNrc1ltOXZiQ2tpTENCdFpYUm9iMlFnSW1kbGRGOXlaWEYxWlhOMFgySnZlQ2gxYVc1ME5qUXBLQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERZMEtTeGliMjlzS1NJc0lHMWxkR2h2WkNBaVoyVjBYM0psY1hWbGMzUmZkVzV6ZFdKelkzSnBZbVZmWW05NEtIVnBiblEyTkNrb0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBOalFwTEdKdmIyd3BJaXdnYldWMGFHOWtJQ0pwYzE5d2NtOXdiM05oYkNoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZM0psWVhSbFgyVnRjSFI1WDNCeWIzQnZjMkZzS0dGa1pISmxjM01wZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p2Y0Y5MWNDZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHbHVhWFJmY0hKdmNHOXpZV3hmWTI5dWRISmhZM1FnYkc5aFpGOXdjbTl3YjNOaGJGOWpiMjUwY21GamRDQnRZV2x1WDJSbGJHVjBaVjl3Y205d2IzTmhiRjlqYjI1MGNtRmpkRjlpYjNoZmNtOTFkR1ZBT1NCdFlXbHVYM0JoZFhObFgzSmxaMmx6ZEhKNVgzSnZkWFJsUURFd0lHMWhhVzVmY0dGMWMyVmZjSEp2Y0c5ellXeHpYM0p2ZFhSbFFERXhJRzFoYVc1ZmNtVnpkVzFsWDNKbFoybHpkSEo1WDNKdmRYUmxRREV5SUcxaGFXNWZjbVZ6ZFcxbFgzQnliM0J2YzJGc2MxOXliM1YwWlVBeE15QnpaWFJmZUdkdmRsOXRZVzVoWjJWeUlITmxkRjl3WVhsdmNpQnpaWFJmZUdkdmRsOWpiM1Z1WTJsc0lITmxkRjk0WjI5MlgzTjFZbk5qY21saVpYSWdjMlYwWDJ0NVkxOXdjbTkyYVdSbGNpQnpaWFJmWTI5dGJXbDBkR1ZsWDIxaGJtRm5aWElnYzJWMFgzaG5iM1pmWkdGbGJXOXVJR052Ym1acFoxOTRaMjkyWDNKbFoybHpkSEo1SUhOMVluTmpjbWxpWlY5NFoyOTJJRzFoYVc1ZmRXNXpkV0p6WTNKcFltVmZlR2R2ZGw5eWIzVjBaVUF5TXlCMWJuTjFZbk5qY21saVpWOWhZbk5sYm5SbFpTQmhjSEJ5YjNabFgzTjFZbk5qY21saVpWOTRaMjkySUhKbGFtVmpkRjl6ZFdKelkzSnBZbVZmZUdkdmRpQnlaWEYxWlhOMFgzTjFZbk5qY21saVpWOTRaMjkySUhKbGNYVmxjM1JmZFc1emRXSnpZM0pwWW1WZmVHZHZkaUJoY0hCeWIzWmxYM1Z1YzNWaWMyTnlhV0psWDNobmIzWWdjbVZxWldOMFgzVnVjM1ZpYzJOeWFXSmxYM2huYjNZZ2MyVjBYM1p2ZEdsdVoxOWhZMk52ZFc1MElITjFZbk5qY21saVpWOXdjbTl3YjNObGNpQnpaWFJmY0hKdmNHOXpaWEpmYTNsaklHUmxZMnhoY21WZlkyOXRiV2wwZEdWbElHOXdaVzVmY0hKdmNHOXpZV3dnZG05MFpWOXdjbTl3YjNOaGJDQjFibUZ6YzJsbmJsOWhZbk5sYm5SbFpWOW1jbTl0WDNCeWIzQnZjMkZzSUhCaGVWOW5jbUZ1ZEY5d2NtOXdiM05oYkNCbWFXNWhiR2w2WlY5d2NtOXdiM05oYkNCa2NtOXdYM0J5YjNCdmMyRnNJR1JsY0c5emFYUmZablZ1WkhNZ2QybDBhR1J5WVhkZlpuVnVaSE1nZDJsMGFHUnlZWGRmWVhaaGFXeGhZbXhsWDJaMWJtUnpJRzFoYVc1ZloyVjBYMkYyWVdsc1lXSnNaVjltZFc1a2MxOXliM1YwWlVBME5DQm5aWFJmYzNSaGRHVWdaMlYwWDNobmIzWmZZbTk0SUdkbGRGOXdjbTl3YjNObGNsOWliM2dnWjJWMFgzSmxjWFZsYzNSZlltOTRJR2RsZEY5eVpYRjFaWE4wWDNWdWMzVmljMk55YVdKbFgySnZlQ0JwYzE5d2NtOXdiM05oYkNCamNtVmhkR1ZmWlcxd2RIbGZjSEp2Y0c5ellXd2diV0ZwYmw5dmNGOTFjRjl5YjNWMFpVQTFNZ29nSUNBZ1pYSnlDZ3B0WVdsdVgyOXdYM1Z3WDNKdmRYUmxRRFV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvMU9EVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOWhkbUZwYkdGaWJHVmZablZ1WkhOZmNtOTFkR1ZBTkRRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUXpOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWXlBek5TQXZMeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzVnVjM1ZpYzJOeWFXSmxYM2huYjNaZmNtOTFkR1ZBTWpNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qSTBOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmNtVnpkVzFsWDNCeWIzQnZjMkZzYzE5eWIzVjBaVUF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1qQXdDaUFnSUNBdkx5QnpaV3htTG5CaGRYTmxaRjl3Y205d2IzTmhiSE11ZG1Gc2RXVWdQU0JHWVd4elpRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEY3dOakUzTlRjek5qVTJORFZtTnpBM01qWm1OekEyWmpjek5qRTJZemN6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TVRrNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl5WlhOMWJXVmZjbVZuYVhOMGNubGZjbTkxZEdWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPakU1TmdvZ0lDQWdMeThnYzJWc1ppNXdZWFZ6WldSZmNtVm5hWE4wY25rdWRtRnNkV1VnUFNCR1lXeHpaUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlRGN3TmpFM05UY3pOalUyTkRWbU56STJOVFkzTmprM016YzBOekkzT1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pFNU5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmY0dGMWMyVmZjSEp2Y0c5ellXeHpYM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG94T1RJS0lDQWdJQzh2SUhObGJHWXVjR0YxYzJWa1gzQnliM0J2YzJGc2N5NTJZV3gxWlNBOUlGUnlkV1VLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGczTURZeE56VTNNelkxTmpRMVpqY3dOekkyWmpjd05tWTNNell4Tm1NM013b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qRTVNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmNHRjFjMlZmY21WbmFYTjBjbmxmY205MWRHVkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pFNE9Bb2dJQ0FnTHk4Z2MyVnNaaTV3WVhWelpXUmZjbVZuYVhOMGNua3VkbUZzZFdVZ1BTQlVjblZsQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TnpBMk1UYzFOek0yTlRZME5XWTNNalkxTmpjMk9UY3pOelEzTWpjNUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1UZzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5a1pXeGxkR1ZmY0hKdmNHOXpZV3hmWTI5dWRISmhZM1JmWW05NFgzSnZkWFJsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qRTRNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFOVFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pJMENpQWdJQ0F2THlCamJHRnpjeUJZWjI5MlVtVm5hWE4wY25sTmIyTnJLRmhIYjNaU1pXZHBjM1J5ZVVsdWRHVnlabUZqWlNrNkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMFl6VmpOakZpWVNBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlNncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFgzSnZkWFJsUURVMUNpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYM0p2ZFhSbFFEVTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG94TnpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTFjR1JoZEdWZmVHZHZkbDl5WldkcGMzUnllVjl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG95TXpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lWWEJrWVhSbFFYQndiR2xqWVhScGIyNGlYU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmdvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbmhuYjNaZmNtVm5hWE4wY25sZmJXOWpheTVqYjI1MGNtRmpkQzVZWjI5MlVtVm5hWE4wY25sTmIyTnJMbWx1YVhSZmNISnZjRzl6WVd4ZlkyOXVkSEpoWTNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBibWwwWDNCeWIzQnZjMkZzWDJOdmJuUnlZV04wT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRveE56UUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdVkyOXVkSEpoWTNRdVdHZHZkbEpsWjJsemRISjVUVzlqYXk1c2IyRmtYM0J5YjNCdmMyRnNYMk52Ym5SeVlXTjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYkc5aFpGOXdjbTl3YjNOaGJGOWpiMjUwY21GamREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNVGM0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTG1OdmJuUnlZV04wTGxobmIzWlNaV2RwYzNSeWVVMXZZMnN1YzJWMFgzaG5iM1pmYldGdVlXZGxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGOTRaMjkyWDIxaGJtRm5aWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pJd01nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMbU52Ym5SeVlXTjBMbGhuYjNaU1pXZHBjM1J5ZVUxdlkyc3VjMlYwWDNCaGVXOXlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFgzQmhlVzl5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRveU1EWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbmhuYjNaZmNtVm5hWE4wY25sZmJXOWpheTVqYjI1MGNtRmpkQzVZWjI5MlVtVm5hWE4wY25sTmIyTnJMbk5sZEY5NFoyOTJYMk52ZFc1amFXeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZmVHZHZkbDlqYjNWdVkybHNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG95TVRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TWpFeUNpQWdJQ0F2THlCelpXeG1MbmhuYjNaZlkyOTFibU5wYkM1MllXeDFaU0E5SUdOdmRXNWphV3dLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGczT0RZM05tWTNOalZtTmpNMlpqYzFObVUyTXpZNU5tTUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPakl4TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVHZHZkbDl5WldkcGMzUnllVjl0YjJOckxtTnZiblJ5WVdOMExsaG5iM1pTWldkcGMzUnllVTF2WTJzdWMyVjBYM2huYjNaZmMzVmljMk55YVdKbGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5NFoyOTJYM04xWW5OamNtbGlaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pJeE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMbU52Ym5SeVlXTjBMbGhuYjNaU1pXZHBjM1J5ZVUxdlkyc3VjMlYwWDJ0NVkxOXdjbTkyYVdSbGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5cmVXTmZjSEp2ZG1sa1pYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPakl4T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVHZHZkbDl5WldkcGMzUnllVjl0YjJOckxtTnZiblJ5WVdOMExsaG5iM1pTWldkcGMzUnllVTF2WTJzdWMyVjBYMk52YlcxcGRIUmxaVjl0WVc1aFoyVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFgyTnZiVzFwZEhSbFpWOXRZVzVoWjJWeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3lNaklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5obmIzWmZjbVZuYVhOMGNubGZiVzlqYXk1amIyNTBjbUZqZEM1WVoyOTJVbVZuYVhOMGNubE5iMk5yTG5ObGRGOTRaMjkyWDJSaFpXMXZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGOTRaMjkyWDJSaFpXMXZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TWpJMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pJeU9Bb2dJQ0FnTHk4Z2MyVnNaaTU0WjI5MlgyUmhaVzF2Ymk1MllXeDFaU0E5SUhobmIzWmZaR0ZsYlc5dUNpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE56ZzJOelptTnpZMVpqWTBOakUyTlRaa05tWTJaUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TWpJMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3VZMjl1ZEhKaFkzUXVXR2R2ZGxKbFoybHpkSEo1VFc5amF5NWpiMjVtYVdkZmVHZHZkbDl5WldkcGMzUnllVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OdmJtWnBaMTk0WjI5MlgzSmxaMmx6ZEhKNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3lNekFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTWpBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJ6YldGeWRGOWpiMjUwY21GamRITXVZMjl0Ylc5dUxtRmlhVjkwZVhCbGN5NVlSMjkyVW1WbmFYTjBjbmxEYjI1bWFXY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTG1OdmJuUnlZV04wTGxobmIzWlNaV2RwYzNSeWVVMXZZMnN1YzNWaWMyTnlhV0psWDNobmIzWmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6ZFdKelkzSnBZbVZmZUdkdmRqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNak00Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTU0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN1WTI5dWRISmhZM1F1V0dkdmRsSmxaMmx6ZEhKNVRXOWpheTUxYm5OMVluTmpjbWxpWlY5aFluTmxiblJsWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVnVjM1ZpYzJOeWFXSmxYMkZpYzJWdWRHVmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG95TkRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5NWpiMjUwY21GamRDNVlaMjkyVW1WbmFYTjBjbmxOYjJOckxtRndjSEp2ZG1WZmMzVmljMk55YVdKbFgzaG5iM1piY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaGNIQnliM1psWDNOMVluTmpjbWxpWlY5NFoyOTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG95TlRJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTU0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN1WTI5dWRISmhZM1F1V0dkdmRsSmxaMmx6ZEhKNVRXOWpheTV5WldwbFkzUmZjM1ZpYzJOeWFXSmxYM2huYjNaYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV3BsWTNSZmMzVmljMk55YVdKbFgzaG5iM1k2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pJMU5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5obmIzWmZjbVZuYVhOMGNubGZiVzlqYXk1amIyNTBjbUZqZEM1WVoyOTJVbVZuYVhOMGNubE5iMk5yTG5KbGNYVmxjM1JmYzNWaWMyTnlhV0psWDNobmIzWmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlhGMVpYTjBYM04xWW5OamNtbGlaVjk0WjI5Mk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3lOakFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdVkyOXVkSEpoWTNRdVdHZHZkbEpsWjJsemRISjVUVzlqYXk1eVpYRjFaWE4wWDNWdWMzVmljMk55YVdKbFgzaG5iM1piY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYRjFaWE4wWDNWdWMzVmljMk55YVdKbFgzaG5iM1k2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pJM01Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbmhuYjNaZmNtVm5hWE4wY25sZmJXOWpheTVqYjI1MGNtRmpkQzVZWjI5MlVtVm5hWE4wY25sTmIyTnJMbUZ3Y0hKdmRtVmZkVzV6ZFdKelkzSnBZbVZmZUdkdmRsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ3Y0hKdmRtVmZkVzV6ZFdKelkzSnBZbVZmZUdkdmRqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNamd5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMbU52Ym5SeVlXTjBMbGhuYjNaU1pXZHBjM1J5ZVUxdlkyc3VjbVZxWldOMFgzVnVjM1ZpYzJOeWFXSmxYM2huYjNaYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV3BsWTNSZmRXNXpkV0p6WTNKcFltVmZlR2R2ZGpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1qZzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVHZHZkbDl5WldkcGMzUnllVjl0YjJOckxtTnZiblJ5WVdOMExsaG5iM1pTWldkcGMzUnllVTF2WTJzdWMyVjBYM1p2ZEdsdVoxOWhZMk52ZFc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwWDNadmRHbHVaMTloWTJOdmRXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG95T1RBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5NWpiMjUwY21GamRDNVlaMjkyVW1WbmFYTjBjbmxOYjJOckxuTjFZbk5qY21saVpWOXdjbTl3YjNObGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk4xWW5OamNtbGlaVjl3Y205d2IzTmxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TWprMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdVkyOXVkSEpoWTNRdVdHZHZkbEpsWjJsemRISjVUVzlqYXk1elpYUmZjSEp2Y0c5elpYSmZhM2xqVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBYM0J5YjNCdmMyVnlYMnQ1WXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk16QXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3VZMjl1ZEhKaFkzUXVXR2R2ZGxKbFoybHpkSEo1VFc5amF5NWtaV05zWVhKbFgyTnZiVzFwZEhSbFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJsWTJ4aGNtVmZZMjl0YldsMGRHVmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG96TVRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNekUwQ2lBZ0lDQXZMeUJ6Wld4bUxtTnZiVzFwZEhSbFpWOXBaQzUyWVd4MVpTQTlJR052YlcxcGRIUmxaVjlwWkM1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGcyTXpabU5tUTJaRFk1TnpRM05EWTFOalUxWmpZNU5qUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk16RTFDaUFnSUNBdkx5QnpaV3htTG1OdmJXMXBkSFJsWlY5dFpXMWlaWEp6TG5aaGJIVmxJRDBnYzJsNlpRb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VEWXpObVkyWkRaa05qazNORGMwTmpVMk5UVm1ObVEyTlRaa05qSTJOVGN5TnpNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TXpFMkNpQWdJQ0F2THlCelpXeG1MbU52YlcxcGRIUmxaVjkyYjNSbGN5NTJZV3gxWlNBOUlIWnZkR1Z6Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUF3ZURZek5tWTJaRFprTmprM05EYzBOalUyTlRWbU56WTJaamMwTmpVM013b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNekV3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdVkyOXVkSEpoWTNRdVdHZHZkbEpsWjJsemRISjVUVzlqYXk1dmNHVnVYM0J5YjNCdmMyRnNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYjNCbGJsOXdjbTl3YjNOaGJEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNekU0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnWW5sMFpXTWdNelVnTHk4Z01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3VZMjl1ZEhKaFkzUXVXR2R2ZGxKbFoybHpkSEo1VFc5amF5NTJiM1JsWDNCeWIzQnZjMkZzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RtOTBaVjl3Y205d2IzTmhiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TXpJeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pNek1TMHpNemNLSUNBZ0lDOHZJR1Z5Y205eUxDQmZkSGdnUFNCaGNtTTBMbUZpYVY5allXeHNLQW9nSUNBZ0x5OGdJQ0FnSUZCeWIzQnZjMkZzTG5admRHVXNDaUFnSUNBdkx5QWdJQ0FnZUdkdmRsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0hKdmRtRnNYM1p2ZEdWekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYW1WamRHbHZibDkyYjNSbGN5d0tJQ0FnSUM4dklDQWdJQ0JoY0hCZmFXUTljSEp2Y0c5ellXeGZhV1FzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3pNeklLSUNBZ0lDOHZJRkJ5YjNCdmMyRnNMblp2ZEdVc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE9EUXhZVEJrTWlBdkx5QnRaWFJvYjJRZ0luWnZkR1VvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMEtYTjBjbWx1WnlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNek14TFRNek53b2dJQ0FnTHk4Z1pYSnliM0lzSUY5MGVDQTlJR0Z5WXpRdVlXSnBYMk5oYkd3b0NpQWdJQ0F2THlBZ0lDQWdVSEp2Y0c5ellXd3VkbTkwWlN3S0lDQWdJQzh2SUNBZ0lDQjRaMjkyWDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYQndjbTkyWVd4ZmRtOTBaWE1zQ2lBZ0lDQXZMeUFnSUNBZ2NtVnFaV04wYVc5dVgzWnZkR1Z6TEFvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxd2NtOXdiM05oYkY5cFpDd0tJQ0FnSUM4dklDa0tJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJzYjJjZ2RtRnNkV1VnYVhNZ2JtOTBJSFJvWlNCeVpYTjFiSFFnYjJZZ1lXNGdRVUpKSUhKbGRIVnliZ29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlITjBjbWx1WndvZ0lDQWdaWGgwY21GamRDQTJJREFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG96TXprS0lDQWdJQzh2SUdsbUlHVnljbTl5TG5OMFlYSjBjM2RwZEdnb1pYSnlMa0ZTUTE4Mk5WOVFVa1ZHU1ZncE9nb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ1BBb2dJQ0FnWW5vZ2RtOTBaVjl3Y205d2IzTmhiRjkwWlhKdVlYSjVYMlpoYkhObFFEUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NncDJiM1JsWDNCeWIzQnZjMkZzWDNSbGNtNWhjbmxmYldWeVoyVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TXpNNUNpQWdJQ0F2THlCcFppQmxjbkp2Y2k1emRHRnlkSE4zYVhSb0tHVnljaTVCVWtOZk5qVmZVRkpGUmtsWUtUb0tJQ0FnSUdKNklIWnZkR1ZmY0hKdmNHOXpZV3hmWVdaMFpYSmZhV1pmWld4elpVQXhOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG96TkRBS0lDQWdJQzh2SUdWeWNtOXlYM2RwZEdodmRYUmZjSEpsWm1sNElEMGdVM1J5YVc1bkxtWnliMjFmWW5sMFpYTW9aWEp5YjNJdVlubDBaWE5iTkRwZEtRb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0ErUFFvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNCa2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TXpReUNpQWdJQ0F2THlCallYTmxJR1Z5Y2k1VlRrRlZWRWhQVWtsYVJVUTZDaUFnSUNCaWVYUmxZeUF6TmlBdkx5QWlWVzVoZFhSb2IzSnBlbVZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvek5EUUtJQ0FnSUM4dklHTmhjMlVnWlhKeUxsWlBWRVZTWDA1UFZGOUdUMVZPUkRvS0lDQWdJR0o1ZEdWaklETTNJQzh2SUNKV2IzUmxjaUJ1YjNRZ1ptOTFibVFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pNME5nb2dJQ0FnTHk4Z1kyRnpaU0JsY25JdVZrOVVSVkpmUVV4U1JVRkVXVjlXVDFSRlJEb0tJQ0FnSUhCMWMyaGllWFJsYzNNZ0lsWnZkR1Z5SUdGc2NtVmhaSGtnZG05MFpXUWlJQ0pXYjNSbGN5QnBiblpoYkdsa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3pOVEFLSUNBZ0lDOHZJR05oYzJVZ1pYSnlMazFKVTFOSlRrZGZRMDlPUmtsSE9nb2dJQ0FnWW5sMFpXTWdNemdnTHk4Z0lrMXBjM05wYm1jZ1EyOXVabWxuSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvek5USUtJQ0FnSUM4dklHTmhjMlVnWlhKeUxsZFNUMDVIWDFCU1QxQlBVMEZNWDFOVVFWUlZVem9LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbGR5YjI1bklGQnliM0J2YzJGc0lGTjBZWFIxY3lCdmNpQm1hVzVoYkdsNlpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPak0xTkFvZ0lDQWdMeThnWTJGelpTQmxjbkl1Vms5VVNVNUhYMUJGVWtsUFJGOUZXRkJKVWtWRU9nb2dJQ0FnY0hWemFHSjVkR1Z6SUNKV2IzUnBibWNnVUdWeWFXOWtJRVY0Y0dseVpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPak0wTVMwek5UY0tJQ0FnSUM4dklHMWhkR05vSUdWeWNtOXlYM2RwZEdodmRYUmZjSEpsWm1sNE9nb2dJQ0FnTHk4Z0lDQWdJR05oYzJVZ1pYSnlMbFZPUVZWVVNFOVNTVnBGUkRvS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVhOelpYSjBJRVpoYkhObExDQmxjbkl1VlU1QlZWUklUMUpKV2tWRUlDQWpJRzV2Y1dFS0lDQWdJQzh2SUNBZ0lDQmpZWE5sSUdWeWNpNVdUMVJGVWw5T1QxUmZSazlWVGtRNkNpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGemMyVnlkQ0JHWVd4elpTd2daWEp5TGxaUFZFVlNYMDVQVkY5R1QxVk9SQ0FnSXlCdWIzRmhDaUFnSUNBdkx5QWdJQ0FnWTJGelpTQmxjbkl1Vms5VVJWSmZRVXhTUlVGRVdWOVdUMVJGUkRvS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVhOelpYSjBJRVpoYkhObExDQmxjbkl1Vms5VVJWSmZRVXhTUlVGRVdWOVdUMVJGUkNBZ0l5QnViM0ZoQ2lBZ0lDQXZMeUFnSUNBZ1kyRnpaU0JsY25JdVZrOVVSVk5mU1U1V1FVeEpSRG9LSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZWE56WlhKMElFWmhiSE5sTENCbGNuSXVWazlVUlZOZlNVNVdRVXhKUkNBZ0l5QnViM0ZoQ2lBZ0lDQXZMeUFnSUNBZ1kyRnpaU0JsY25JdVRVbFRVMGxPUjE5RFQwNUdTVWM2Q2lBZ0lDQXZMeUFnSUNBZ0lDQWdJR0Z6YzJWeWRDQkdZV3h6WlN3Z1pYSnlMazFKVTFOSlRrZGZRMDlPUmtsSElDQWpJRzV2Y1dFS0lDQWdJQzh2SUNBZ0lDQmpZWE5sSUdWeWNpNVhVazlPUjE5UVVrOVFUMU5CVEY5VFZFRlVWVk02Q2lBZ0lDQXZMeUFnSUNBZ0lDQWdJR0Z6YzJWeWRDQkdZV3h6WlN3Z1pYSnlMbGRTVDA1SFgxQlNUMUJQVTBGTVgxTlVRVlJWVXlBZ0l5QnViM0ZoQ2lBZ0lDQXZMeUFnSUNBZ1kyRnpaU0JsY25JdVZrOVVTVTVIWDFCRlVrbFBSRjlGV0ZCSlVrVkVPZ29nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjM05sY25RZ1JtRnNjMlVzSUdWeWNpNVdUMVJKVGtkZlVFVlNTVTlFWDBWWVVFbFNSVVFnSUNNZ2JtOXhZUW9nSUNBZ0x5OGdJQ0FnSUdOaGMyVWdYem9LSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZWE56WlhKMElFWmhiSE5sTENBaVZXNXJibTkzYmlCbGNuSnZjaUlnSUNNZ2JtOXhZUW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0J0WVhSamFDQjJiM1JsWDNCeWIzQnZjMkZzWDNOM2FYUmphRjlqWVhObFh6QkFOeUIyYjNSbFgzQnliM0J2YzJGc1gzTjNhWFJqYUY5allYTmxYekZBT0NCMmIzUmxYM0J5YjNCdmMyRnNYM04zYVhSamFGOWpZWE5sWHpKQU9TQjJiM1JsWDNCeWIzQnZjMkZzWDNOM2FYUmphRjlqWVhObFh6TkFNVEFnZG05MFpWOXdjbTl3YjNOaGJGOXpkMmwwWTJoZlkyRnpaVjgwUURFeElIWnZkR1ZmY0hKdmNHOXpZV3hmYzNkcGRHTm9YMk5oYzJWZk5VQXhNaUIyYjNSbFgzQnliM0J2YzJGc1gzTjNhWFJqYUY5allYTmxYelpBTVRNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk16VTNDaUFnSUNBdkx5QmhjM05sY25RZ1JtRnNjMlVzSUNKVmJtdHViM2R1SUdWeWNtOXlJaUFnSXlCdWIzRmhDaUFnSUNCbGNuSWdMeThnVlc1cmJtOTNiaUJsY25KdmNnb0tkbTkwWlY5d2NtOXdiM05oYkY5emQybDBZMmhmWTJGelpWODJRREV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvek5UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCR1lXeHpaU3dnWlhKeUxsWlBWRWxPUjE5UVJWSkpUMFJmUlZoUVNWSkZSQ0FnSXlCdWIzRmhDaUFnSUNCbGNuSWdMeThnVm05MGFXNW5JRkJsY21sdlpDQkZlSEJwY21Wa0NncDJiM1JsWDNCeWIzQnZjMkZzWDNOM2FYUmphRjlqWVhObFh6VkFNVEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pNMU13b2dJQ0FnTHk4Z1lYTnpaWEowSUVaaGJITmxMQ0JsY25JdVYxSlBUa2RmVUZKUFVFOVRRVXhmVTFSQlZGVlRJQ0FqSUc1dmNXRUtJQ0FnSUdWeWNpQXZMeUJYY205dVp5QlFjbTl3YjNOaGJDQlRkR0YwZFhNZ2IzSWdabWx1WVd4cGVtVmtDZ3AyYjNSbFgzQnliM0J2YzJGc1gzTjNhWFJqYUY5allYTmxYelJBTVRFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qTTFNUW9nSUNBZ0x5OGdZWE56WlhKMElFWmhiSE5sTENCbGNuSXVUVWxUVTBsT1IxOURUMDVHU1VjZ0lDTWdibTl4WVFvZ0lDQWdaWEp5SUM4dklFMXBjM05wYm1jZ1EyOXVabWxuQ2dwMmIzUmxYM0J5YjNCdmMyRnNYM04zYVhSamFGOWpZWE5sWHpOQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPak0wT1FvZ0lDQWdMeThnWVhOelpYSjBJRVpoYkhObExDQmxjbkl1Vms5VVJWTmZTVTVXUVV4SlJDQWdJeUJ1YjNGaENpQWdJQ0JsY25JZ0x5OGdWbTkwWlhNZ2FXNTJZV3hwWkFvS2RtOTBaVjl3Y205d2IzTmhiRjl6ZDJsMFkyaGZZMkZ6WlY4eVFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPak0wTndvZ0lDQWdMeThnWVhOelpYSjBJRVpoYkhObExDQmxjbkl1Vms5VVJWSmZRVXhTUlVGRVdWOVdUMVJGUkNBZ0l5QnViM0ZoQ2lBZ0lDQmxjbklnTHk4Z1ZtOTBaWElnWVd4eVpXRmtlU0IyYjNSbFpBb0tkbTkwWlY5d2NtOXdiM05oYkY5emQybDBZMmhmWTJGelpWOHhRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pNME5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUVaaGJITmxMQ0JsY25JdVZrOVVSVkpmVGs5VVgwWlBWVTVFSUNBaklHNXZjV0VLSUNBZ0lHVnljaUF2THlCV2IzUmxjaUJ1YjNRZ1ptOTFibVFLQ25admRHVmZjSEp2Y0c5ellXeGZjM2RwZEdOb1gyTmhjMlZmTUVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3pORE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQkdZV3h6WlN3Z1pYSnlMbFZPUVZWVVNFOVNTVnBGUkNBZ0l5QnViM0ZoQ2lBZ0lDQmxjbklnTHk4Z1ZXNWhkWFJvYjNKcGVtVmtDZ3AyYjNSbFgzQnliM0J2YzJGc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qTXlNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDblp2ZEdWZmNISnZjRzl6WVd4ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvek16a0tJQ0FnSUM4dklHbG1JR1Z5Y205eUxuTjBZWEowYzNkcGRHZ29aWEp5TGtGU1ExODJOVjlRVWtWR1NWZ3BPZ29nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ05pQTBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSkZVbEk2SWdvZ0lDQWdQVDBLSUNBZ0lHSWdkbTkwWlY5d2NtOXdiM05oYkY5MFpYSnVZWEo1WDIxbGNtZGxRRFVLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVHZHZkbDl5WldkcGMzUnllVjl0YjJOckxtTnZiblJ5WVdOMExsaG5iM1pTWldkcGMzUnllVTF2WTJzdWRXNWhjM05wWjI1ZllXSnpaVzUwWldWZlpuSnZiVjl3Y205d2IzTmhiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25WdVlYTnphV2R1WDJGaWMyVnVkR1ZsWDJaeWIyMWZjSEp2Y0c5ellXdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPak0xT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVdOamIzVnVkRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TXpZekxUTTJOd29nSUNBZ0x5OGdaWEp5YjNJc0lGOTBlQ0E5SUdGeVl6UXVZV0pwWDJOaGJHd29DaUFnSUNBdkx5QWdJQ0FnVUhKdmNHOXpZV3d1ZFc1aGMzTnBaMjVmWVdKelpXNTBaV1Z6TEFvZ0lDQWdMeThnSUNBZ0lHRmljMlZ1ZEdWbGN5d0tJQ0FnSUM4dklDQWdJQ0JoY0hCZmFXUTljSEp2Y0c5ellXeGZhV1FzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TXpZMENpQWdJQ0F2THlCUWNtOXdiM05oYkM1MWJtRnpjMmxuYmw5aFluTmxiblJsWlhNc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnM05tWm1OR00zTUNBdkx5QnRaWFJvYjJRZ0luVnVZWE56YVdkdVgyRmljMlZ1ZEdWbGN5aGhaR1J5WlhOelcxMHBjM1J5YVc1bklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qTTJNeTB6TmpjS0lDQWdJQzh2SUdWeWNtOXlMQ0JmZEhnZ1BTQmhjbU0wTG1GaWFWOWpZV3hzS0FvZ0lDQWdMeThnSUNBZ0lGQnliM0J2YzJGc0xuVnVZWE56YVdkdVgyRmljMlZ1ZEdWbGN5d0tJQ0FnSUM4dklDQWdJQ0JoWW5ObGJuUmxaWE1zQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFhCeWIzQnZjMkZzWDJsa0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JsZUhSeVlXTjBJREFnTkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR3h2WnlCMllXeDFaU0JwY3lCdWIzUWdkR2hsSUhKbGMzVnNkQ0J2WmlCaGJpQkJRa2tnY21WMGRYSnVDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2MzUnlhVzVuQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNQW9nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPak0yT1FvZ0lDQWdMeThnYVdZZ1pYSnliM0l1YzNSaGNuUnpkMmwwYUNobGNuSXVRVkpEWHpZMVgxQlNSVVpKV0NrNkNpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNBOENpQWdJQ0JpZWlCMWJtRnpjMmxuYmw5aFluTmxiblJsWlY5bWNtOXRYM0J5YjNCdmMyRnNYM1JsY201aGNubGZabUZzYzJWQU5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0NuVnVZWE56YVdkdVgyRmljMlZ1ZEdWbFgyWnliMjFmY0hKdmNHOXpZV3hmZEdWeWJtRnllVjl0WlhKblpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG96TmprS0lDQWdJQzh2SUdsbUlHVnljbTl5TG5OMFlYSjBjM2RwZEdnb1pYSnlMa0ZTUTE4Mk5WOVFVa1ZHU1ZncE9nb2dJQ0FnWW5vZ2RXNWhjM05wWjI1ZllXSnpaVzUwWldWZlpuSnZiVjl3Y205d2IzTmhiRjlsYkhObFgySnZaSGxBTVRBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk16Y3dDaUFnSUNBdkx5Qmxjbkp2Y2w5M2FYUm9iM1YwWDNCeVpXWnBlQ0E5SUZOMGNtbHVaeTVtY205dFgySjVkR1Z6S0dWeWNtOXlMbUo1ZEdWeld6UTZYU2tLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1BqMEtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qTTNNZ29nSUNBZ0x5OGdZMkZ6WlNCbGNuSXVWMUpQVGtkZlVGSlBVRTlUUVV4ZlUxUkJWRlZUT2dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpVjNKdmJtY2dVSEp2Y0c5ellXd2dVM1JoZEhWeklHOXlJR1pwYm1Gc2FYcGxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TXpjMENpQWdJQ0F2THlCallYTmxJR1Z5Y2k1V1QxUkZVbDlPVDFSZlJrOVZUa1E2Q2lBZ0lDQmllWFJsWXlBek55QXZMeUFpVm05MFpYSWdibTkwSUdadmRXNWtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG96TnpFdE16YzNDaUFnSUNBdkx5QnRZWFJqYUNCbGNuSnZjbDkzYVhSb2IzVjBYM0J5WldacGVEb0tJQ0FnSUM4dklDQWdJQ0JqWVhObElHVnljaTVYVWs5T1IxOVFVazlRVDFOQlRGOVRWRUZVVlZNNkNpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGemMyVnlkQ0JHWVd4elpTd2daWEp5TGxkU1QwNUhYMUJTVDFCUFUwRk1YMU5VUVZSVlV5QWdJeUJ1YjNGaENpQWdJQ0F2THlBZ0lDQWdZMkZ6WlNCbGNuSXVWazlVUlZKZlRrOVVYMFpQVlU1RU9nb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaGMzTmxjblFnUm1Gc2MyVXNJR1Z5Y2k1V1QxUkZVbDlPVDFSZlJrOVZUa1FnSUNNZ2JtOXhZUW9nSUNBZ0x5OGdJQ0FnSUdOaGMyVWdYem9LSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZWE56WlhKMElFWmhiSE5sTENBaVZXNXJibTkzYmlCbGNuSnZjaUlnSUNNZ2JtOXhZUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J0WVhSamFDQjFibUZ6YzJsbmJsOWhZbk5sYm5SbFpWOW1jbTl0WDNCeWIzQnZjMkZzWDNOM2FYUmphRjlqWVhObFh6QkFOeUIxYm1GemMybG5ibDloWW5ObGJuUmxaVjltY205dFgzQnliM0J2YzJGc1gzTjNhWFJqYUY5allYTmxYekZBT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvek56Y0tJQ0FnSUM4dklHRnpjMlZ5ZENCR1lXeHpaU3dnSWxWdWEyNXZkMjRnWlhKeWIzSWlJQ0FqSUc1dmNXRUtJQ0FnSUdWeWNpQXZMeUJWYm10dWIzZHVJR1Z5Y205eUNncDFibUZ6YzJsbmJsOWhZbk5sYm5SbFpWOW1jbTl0WDNCeWIzQnZjMkZzWDNOM2FYUmphRjlqWVhObFh6RkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TXpjMUNpQWdJQ0F2THlCaGMzTmxjblFnUm1Gc2MyVXNJR1Z5Y2k1V1QxUkZVbDlPVDFSZlJrOVZUa1FnSUNNZ2JtOXhZUW9nSUNBZ1pYSnlJQzh2SUZadmRHVnlJRzV2ZENCbWIzVnVaQW9LZFc1aGMzTnBaMjVmWVdKelpXNTBaV1ZmWm5KdmJWOXdjbTl3YjNOaGJGOXpkMmwwWTJoZlkyRnpaVjh3UURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qTTNNd29nSUNBZ0x5OGdZWE56WlhKMElFWmhiSE5sTENCbGNuSXVWMUpQVGtkZlVGSlBVRTlUUVV4ZlUxUkJWRlZUSUNBaklHNXZjV0VLSUNBZ0lHVnljaUF2THlCWGNtOXVaeUJRY205d2IzTmhiQ0JUZEdGMGRYTWdiM0lnWm1sdVlXeHBlbVZrQ2dwMWJtRnpjMmxuYmw5aFluTmxiblJsWlY5bWNtOXRYM0J5YjNCdmMyRnNYMlZzYzJWZlltOWtlVUF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk16YzVDaUFnSUNBdkx5QmhjM05sY25RZ1pYSnliM0lnUFQwZ0lpSXNJQ0pWYm10dWIzZHVJR1Z5Y205eUlnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJWYm10dWIzZHVJR1Z5Y205eUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qTTFPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDblZ1WVhOemFXZHVYMkZpYzJWdWRHVmxYMlp5YjIxZmNISnZjRzl6WVd4ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvek5qa0tJQ0FnSUM4dklHbG1JR1Z5Y205eUxuTjBZWEowYzNkcGRHZ29aWEp5TGtGU1ExODJOVjlRVWtWR1NWZ3BPZ29nSUNBZ1pHbG5JRElLSUNBZ0lHVjRkSEpoWTNRZ05pQTBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSkZVbEk2SWdvZ0lDQWdQVDBLSUNBZ0lHSWdkVzVoYzNOcFoyNWZZV0p6Wlc1MFpXVmZabkp2YlY5d2NtOXdiM05oYkY5MFpYSnVZWEo1WDIxbGNtZGxRRFVLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVHZHZkbDl5WldkcGMzUnllVjl0YjJOckxtTnZiblJ5WVdOMExsaG5iM1pTWldkcGMzUnllVTF2WTJzdWNHRjVYMmR5WVc1MFgzQnliM0J2YzJGc1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjR0Y1WDJkeVlXNTBYM0J5YjNCdmMyRnNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG96T0RFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qTTRNd29nSUNBZ0x5OGdaWEp5YjNJc0lGOTBlQ0E5SUdGeVl6UXVZV0pwWDJOaGJHd29VSEp2Y0c5ellXd3VablZ1WkN3Z1lYQndYMmxrUFhCeWIzQnZjMkZzWDJsa0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNFlUVmxOR000TUNBdkx5QnRaWFJvYjJRZ0ltWjFibVFvS1hOMGNtbHVaeUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1lYQndiR2xqWVhScGIyNGdiRzluSUhaaGJIVmxJR2x6SUc1dmRDQjBhR1VnY21WemRXeDBJRzltSUdGdUlFRkNTU0J5WlhSMWNtNEtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCemRISnBibWNLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNemcxQ2lBZ0lDQXZMeUJwWmlCbGNuSnZjaTV6ZEdGeWRITjNhWFJvS0dWeWNpNUJVa05mTmpWZlVGSkZSa2xZS1RvS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUR3S0lDQWdJR0o2SUhCaGVWOW5jbUZ1ZEY5d2NtOXdiM05oYkY5MFpYSnVZWEo1WDJaaGJITmxRRFFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDZ3B3WVhsZlozSmhiblJmY0hKdmNHOXpZV3hmZEdWeWJtRnllVjl0WlhKblpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG96T0RVS0lDQWdJQzh2SUdsbUlHVnljbTl5TG5OMFlYSjBjM2RwZEdnb1pYSnlMa0ZTUTE4Mk5WOVFVa1ZHU1ZncE9nb2dJQ0FnWW5vZ2NHRjVYMmR5WVc1MFgzQnliM0J2YzJGc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk16ZzJDaUFnSUNBdkx5Qmxjbkp2Y2w5M2FYUm9iM1YwWDNCeVpXWnBlQ0E5SUZOMGNtbHVaeTVtY205dFgySjVkR1Z6S0dWeWNtOXlMbUo1ZEdWeld6UTZYU2tLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1BqMEtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qTTRPQW9nSUNBZ0x5OGdZMkZ6WlNCbGNuSXVWVTVCVlZSSVQxSkpXa1ZFT2dvZ0lDQWdZbmwwWldNZ016WWdMeThnSWxWdVlYVjBhRzl5YVhwbFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNemt3Q2lBZ0lDQXZMeUJqWVhObElHVnljaTVYVWs5T1IxOVFVazlRVDFOQlRGOVRWRUZVVlZNNkNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKWGNtOXVaeUJRY205d2IzTmhiQ0JUZEdGMGRYTWdiM0lnWm1sdVlXeHBlbVZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvek9EY3RNemt6Q2lBZ0lDQXZMeUJ0WVhSamFDQmxjbkp2Y2w5M2FYUm9iM1YwWDNCeVpXWnBlRG9LSUNBZ0lDOHZJQ0FnSUNCallYTmxJR1Z5Y2k1VlRrRlZWRWhQVWtsYVJVUTZDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHRnpjMlZ5ZENCR1lXeHpaU3dnWlhKeUxsVk9RVlZVU0U5U1NWcEZSQ0FnSXlCdWIzRmhDaUFnSUNBdkx5QWdJQ0FnWTJGelpTQmxjbkl1VjFKUFRrZGZVRkpQVUU5VFFVeGZVMVJCVkZWVE9nb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaGMzTmxjblFnUm1Gc2MyVXNJR1Z5Y2k1WFVrOU9SMTlRVWs5UVQxTkJURjlUVkVGVVZWTWdJQ01nYm05eFlRb2dJQ0FnTHk4Z0lDQWdJR05oYzJVZ1h6b0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ1lYTnpaWEowSUVaaGJITmxMQ0FpVlc1cmJtOTNiaUJsY25KdmNpSWdJQ01nYm05eFlRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnRZWFJqYUNCd1lYbGZaM0poYm5SZmNISnZjRzl6WVd4ZmMzZHBkR05vWDJOaGMyVmZNRUEzSUhCaGVWOW5jbUZ1ZEY5d2NtOXdiM05oYkY5emQybDBZMmhmWTJGelpWOHhRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TXprekNpQWdJQ0F2THlCaGMzTmxjblFnUm1Gc2MyVXNJQ0pWYm10dWIzZHVJR1Z5Y205eUlpQWdJeUJ1YjNGaENpQWdJQ0JsY25JZ0x5OGdWVzVyYm05M2JpQmxjbkp2Y2dvS2NHRjVYMmR5WVc1MFgzQnliM0J2YzJGc1gzTjNhWFJqYUY5allYTmxYekZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk16a3hDaUFnSUNBdkx5QmhjM05sY25RZ1JtRnNjMlVzSUdWeWNpNVhVazlPUjE5UVVrOVFUMU5CVEY5VFZFRlVWVk1nSUNNZ2JtOXhZUW9nSUNBZ1pYSnlJQzh2SUZkeWIyNW5JRkJ5YjNCdmMyRnNJRk4wWVhSMWN5QnZjaUJtYVc1aGJHbDZaV1FLQ25CaGVWOW5jbUZ1ZEY5d2NtOXdiM05oYkY5emQybDBZMmhmWTJGelpWOHdRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pNNE9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUVaaGJITmxMQ0JsY25JdVZVNUJWVlJJVDFKSldrVkVJQ0FqSUc1dmNXRUtJQ0FnSUdWeWNpQXZMeUJWYm1GMWRHaHZjbWw2WldRS0NuQmhlVjluY21GdWRGOXdjbTl3YjNOaGJGOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3pPREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B3WVhsZlozSmhiblJmY0hKdmNHOXpZV3hmZEdWeWJtRnllVjltWVd4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG96T0RVS0lDQWdJQzh2SUdsbUlHVnljbTl5TG5OMFlYSjBjM2RwZEdnb1pYSnlMa0ZTUTE4Mk5WOVFVa1ZHU1ZncE9nb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTmlBMENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKRlVsSTZJZ29nSUNBZ1BUMEtJQ0FnSUdJZ2NHRjVYMmR5WVc1MFgzQnliM0J2YzJGc1gzUmxjbTVoY25sZmJXVnlaMlZBTlFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3VZMjl1ZEhKaFkzUXVXR2R2ZGxKbFoybHpkSEo1VFc5amF5NW1hVzVoYkdsNlpWOXdjbTl3YjNOaGJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVpwYm1Gc2FYcGxYM0J5YjNCdmMyRnNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG96T1RVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qTTVOd29nSUNBZ0x5OGdaWEp5YjNJc0lGOTBlQ0E5SUdGeVl6UXVZV0pwWDJOaGJHd29VSEp2Y0c5ellXd3VabWx1WVd4cGVtVXNJR0Z3Y0Y5cFpEMXdjbTl3YjNOaGJGOXBaQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPREF5TURZNVlqUWdMeThnYldWMGFHOWtJQ0ptYVc1aGJHbDZaU2dwYzNSeWFXNW5JZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSEIxYzJocGJuUWdOaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQnNiMmNnZG1Gc2RXVWdhWE1nYm05MElIUm9aU0J5WlhOMWJIUWdiMllnWVc0Z1FVSkpJSEpsZEhWeWJnb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhOMGNtbHVad29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3pPVGtLSUNBZ0lDOHZJR2xtSUdWeWNtOXlMbk4wWVhKMGMzZHBkR2dvWlhKeUxrRlNRMTgyTlY5UVVrVkdTVmdwT2dvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnUEFvZ0lDQWdZbm9nWm1sdVlXeHBlbVZmY0hKdmNHOXpZV3hmZEdWeWJtRnllVjltWVd4elpVQTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb0tabWx1WVd4cGVtVmZjSEp2Y0c5ellXeGZkR1Z5Ym1GeWVWOXRaWEpuWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3pPVGtLSUNBZ0lDOHZJR2xtSUdWeWNtOXlMbk4wWVhKMGMzZHBkR2dvWlhKeUxrRlNRMTgyTlY5UVVrVkdTVmdwT2dvZ0lDQWdZbm9nWm1sdVlXeHBlbVZmY0hKdmNHOXpZV3hmWVdaMFpYSmZhV1pmWld4elpVQXhNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG8wTURBS0lDQWdJQzh2SUdWeWNtOXlYM2RwZEdodmRYUmZjSEpsWm1sNElEMGdVM1J5YVc1bkxtWnliMjFmWW5sMFpYTW9aWEp5YjNJdVlubDBaWE5iTkRwZEtRb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0ErUFFvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNCa2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TkRBeUNpQWdJQ0F2THlCallYTmxJR1Z5Y2k1WFVrOU9SMTlRVWs5UVQxTkJURjlUVkVGVVZWTTZDaUFnSUNCaWVYUmxZMTh4SUM4dklDSlhjbTl1WnlCUWNtOXdiM05oYkNCVGRHRjBkWE1nYjNJZ1ptbHVZV3hwZW1Wa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzBNRFFLSUNBZ0lDOHZJR05oYzJVZ1pYSnlMazFKVTFOSlRrZGZRMDlPUmtsSE9nb2dJQ0FnWW5sMFpXTWdNemdnTHk4Z0lrMXBjM05wYm1jZ1EyOXVabWxuSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvME1EWUtJQ0FnSUM4dklHTmhjMlVnWlhKeUxsWlBWRVZTVTE5QlUxTkpSMDVGUkRvS0lDQWdJSEIxYzJoaWVYUmxjeUFpVkdobGNtVWdZWEpsSUhadmRHVnljeUJoYzNOcFoyNWxaQ0IwYnlCMGFHbHpJSEJ5YjNCdmMyRnNJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG8wTURFdE5EQTVDaUFnSUNBdkx5QnRZWFJqYUNCbGNuSnZjbDkzYVhSb2IzVjBYM0J5WldacGVEb0tJQ0FnSUM4dklDQWdJQ0JqWVhObElHVnljaTVYVWs5T1IxOVFVazlRVDFOQlRGOVRWRUZVVlZNNkNpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGemMyVnlkQ0JHWVd4elpTd2daWEp5TGxkU1QwNUhYMUJTVDFCUFUwRk1YMU5VUVZSVlV5QWdJeUJ1YjNGaENpQWdJQ0F2THlBZ0lDQWdZMkZ6WlNCbGNuSXVUVWxUVTBsT1IxOURUMDVHU1VjNkNpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGemMyVnlkQ0JHWVd4elpTd2daWEp5TGsxSlUxTkpUa2RmUTA5T1JrbEhJQ0FqSUc1dmNXRUtJQ0FnSUM4dklDQWdJQ0JqWVhObElHVnljaTVXVDFSRlVsTmZRVk5UU1VkT1JVUTZDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHRnpjMlZ5ZENCR1lXeHpaU3dnWlhKeUxsWlBWRVZTVTE5QlUxTkpSMDVGUkNBZ0l5QnViM0ZoQ2lBZ0lDQXZMeUFnSUNBZ1kyRnpaU0JmT2dvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JoYzNObGNuUWdSbUZzYzJVc0lDSlZibXR1YjNkdUlHVnljbTl5SWlBZ0l5QnViM0ZoQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUcxaGRHTm9JR1pwYm1Gc2FYcGxYM0J5YjNCdmMyRnNYM04zYVhSamFGOWpZWE5sWHpCQU55Qm1hVzVoYkdsNlpWOXdjbTl3YjNOaGJGOXpkMmwwWTJoZlkyRnpaVjh4UURnZ1ptbHVZV3hwZW1WZmNISnZjRzl6WVd4ZmMzZHBkR05vWDJOaGMyVmZNa0E1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pRd09Rb2dJQ0FnTHk4Z1lYTnpaWEowSUVaaGJITmxMQ0FpVlc1cmJtOTNiaUJsY25KdmNpSWdJQ01nYm05eFlRb2dJQ0FnWlhKeUlDOHZJRlZ1YTI1dmQyNGdaWEp5YjNJS0NtWnBibUZzYVhwbFgzQnliM0J2YzJGc1gzTjNhWFJqYUY5allYTmxYekpBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk5EQTNDaUFnSUNBdkx5QmhjM05sY25RZ1JtRnNjMlVzSUdWeWNpNVdUMVJGVWxOZlFWTlRTVWRPUlVRZ0lDTWdibTl4WVFvZ0lDQWdaWEp5SUM4dklGUm9aWEpsSUdGeVpTQjJiM1JsY25NZ1lYTnphV2R1WldRZ2RHOGdkR2hwY3lCd2NtOXdiM05oYkFvS1ptbHVZV3hwZW1WZmNISnZjRzl6WVd4ZmMzZHBkR05vWDJOaGMyVmZNVUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvME1EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCR1lXeHpaU3dnWlhKeUxrMUpVMU5KVGtkZlEwOU9Sa2xISUNBaklHNXZjV0VLSUNBZ0lHVnljaUF2THlCTmFYTnphVzVuSUVOdmJtWnBad29LWm1sdVlXeHBlbVZmY0hKdmNHOXpZV3hmYzNkcGRHTm9YMk5oYzJWZk1FQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG8wTURNS0lDQWdJQzh2SUdGemMyVnlkQ0JHWVd4elpTd2daWEp5TGxkU1QwNUhYMUJTVDFCUFUwRk1YMU5VUVZSVlV5QWdJeUJ1YjNGaENpQWdJQ0JsY25JZ0x5OGdWM0p2Ym1jZ1VISnZjRzl6WVd3Z1UzUmhkSFZ6SUc5eUlHWnBibUZzYVhwbFpBb0tabWx1WVd4cGVtVmZjSEp2Y0c5ellXeGZZV1owWlhKZmFXWmZaV3h6WlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNemsxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWm1sdVlXeHBlbVZmY0hKdmNHOXpZV3hmZEdWeWJtRnllVjltWVd4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG96T1RrS0lDQWdJQzh2SUdsbUlHVnljbTl5TG5OMFlYSjBjM2RwZEdnb1pYSnlMa0ZTUTE4Mk5WOVFVa1ZHU1ZncE9nb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTmlBMENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKRlVsSTZJZ29nSUNBZ1BUMEtJQ0FnSUdJZ1ptbHVZV3hwZW1WZmNISnZjRzl6WVd4ZmRHVnlibUZ5ZVY5dFpYSm5aVUExQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5NWpiMjUwY21GamRDNVlaMjkyVW1WbmFYTjBjbmxOYjJOckxtUnliM0JmY0hKdmNHOXpZV3hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa2NtOXdYM0J5YjNCdmMyRnNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG8wTVRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUXhNd29nSUNBZ0x5OGdaWEp5YjNJc0lGOTBlQ0E5SUdGeVl6UXVZV0pwWDJOaGJHd29VSEp2Y0c5ellXd3VaSEp2Y0N3Z1lYQndYMmxrUFhCeWIzQnZjMkZzWDJsa0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnM016Y3hNekl4WVNBdkx5QnRaWFJvYjJRZ0ltUnliM0FvS1hOMGNtbHVaeUlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J3ZFhOb2FXNTBJRFlnTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1lYQndiR2xqWVhScGIyNGdiRzluSUhaaGJIVmxJR2x6SUc1dmRDQjBhR1VnY21WemRXeDBJRzltSUdGdUlFRkNTU0J5WlhSMWNtNEtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCemRISnBibWNLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZOREUxQ2lBZ0lDQXZMeUJwWmlCbGNuSnZjaTV6ZEdGeWRITjNhWFJvS0dWeWNpNUJVa05mTmpWZlVGSkZSa2xZS1RvS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUR3S0lDQWdJR0o2SUdSeWIzQmZjSEp2Y0c5ellXeGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvS1pISnZjRjl3Y205d2IzTmhiRjkwWlhKdVlYSjVYMjFsY21kbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalF4TlFvZ0lDQWdMeThnYVdZZ1pYSnliM0l1YzNSaGNuUnpkMmwwYUNobGNuSXVRVkpEWHpZMVgxQlNSVVpKV0NrNkNpQWdJQ0JpZWlCa2NtOXdYM0J5YjNCdmMyRnNYMkZtZEdWeVgybG1YMlZzYzJWQU9Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzBNVFlLSUNBZ0lDOHZJR1Z5Y205eVgzZHBkR2h2ZFhSZmNISmxabWw0SUQwZ1UzUnlhVzVuTG1aeWIyMWZZbmwwWlhNb1pYSnliM0l1WW5sMFpYTmJORHBkS1FvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQStQUW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZOREU0Q2lBZ0lDQXZMeUJqWVhObElHVnljaTVYVWs5T1IxOVFVazlRVDFOQlRGOVRWRUZVVlZNNkNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKWGNtOXVaeUJRY205d2IzTmhiQ0JUZEdGMGRYTWdiM0lnWm1sdVlXeHBlbVZrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvME1UY3ROREl4Q2lBZ0lDQXZMeUJ0WVhSamFDQmxjbkp2Y2w5M2FYUm9iM1YwWDNCeVpXWnBlRG9LSUNBZ0lDOHZJQ0FnSUNCallYTmxJR1Z5Y2k1WFVrOU9SMTlRVWs5UVQxTkJURjlUVkVGVVZWTTZDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHRnpjMlZ5ZENCR1lXeHpaU3dnWlhKeUxsZFNUMDVIWDFCU1QxQlBVMEZNWDFOVVFWUlZVeUFnSXlCdWIzRmhDaUFnSUNBdkx5QWdJQ0FnWTJGelpTQmZPZ29nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjM05sY25RZ1JtRnNjMlVzSUNKVmJtdHViM2R1SUdWeWNtOXlJaUFnSXlCdWIzRmhDaUFnSUNCemQyRndDaUFnSUNCdFlYUmphQ0JrY205d1gzQnliM0J2YzJGc1gzTjNhWFJqYUY5allYTmxYekJBTndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvME1qRUtJQ0FnSUM4dklHRnpjMlZ5ZENCR1lXeHpaU3dnSWxWdWEyNXZkMjRnWlhKeWIzSWlJQ0FqSUc1dmNXRUtJQ0FnSUdWeWNpQXZMeUJWYm10dWIzZHVJR1Z5Y205eUNncGtjbTl3WDNCeWIzQnZjMkZzWDNOM2FYUmphRjlqWVhObFh6QkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TkRFNUNpQWdJQ0F2THlCaGMzTmxjblFnUm1Gc2MyVXNJR1Z5Y2k1WFVrOU9SMTlRVWs5UVQxTkJURjlUVkVGVVZWTWdJQ01nYm05eFlRb2dJQ0FnWlhKeUlDOHZJRmR5YjI1bklGQnliM0J2YzJGc0lGTjBZWFIxY3lCdmNpQm1hVzVoYkdsNlpXUUtDbVJ5YjNCZmNISnZjRzl6WVd4ZllXWjBaWEpmYVdaZlpXeHpaVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvME1URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGtjbTl3WDNCeWIzQnZjMkZzWDNSbGNtNWhjbmxmWm1Gc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TkRFMUNpQWdJQ0F2THlCcFppQmxjbkp2Y2k1emRHRnlkSE4zYVhSb0tHVnljaTVCVWtOZk5qVmZVRkpGUmtsWUtUb0tJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURZZ05Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVJWSlNPaUlLSUNBZ0lEMDlDaUFnSUNCaUlHUnliM0JmY0hKdmNHOXpZV3hmZEdWeWJtRnllVjl0WlhKblpVQTFDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5obmIzWmZjbVZuYVhOMGNubGZiVzlqYXk1amIyNTBjbUZqZEM1WVoyOTJVbVZuYVhOMGNubE5iMk5yTG1SbGNHOXphWFJmWm5WdVpITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWlhCdmMybDBYMloxYm1Sek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzBNak1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbmhuYjNaZmNtVm5hWE4wY25sZmJXOWpheTVqYjI1MGNtRmpkQzVZWjI5MlVtVm5hWE4wY25sTmIyTnJMbmRwZEdoa2NtRjNYMloxYm1SelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkMmwwYUdSeVlYZGZablZ1WkhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUXlOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5NWpiMjUwY21GamRDNVlaMjkyVW1WbmFYTjBjbmxOYjJOckxuZHBkR2hrY21GM1gyRjJZV2xzWVdKc1pWOW1kVzVrYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuZHBkR2hrY21GM1gyRjJZV2xzWVdKc1pWOW1kVzVrY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk5ETXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVHZHZkbDl5WldkcGMzUnllVjl0YjJOckxtTnZiblJ5WVdOMExsaG5iM1pTWldkcGMzUnllVTF2WTJzdVoyVjBYM04wWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNOMFlYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG8wTkRJS0lDQWdJQzh2SUhCaGRYTmxaRjl5WldkcGMzUnllVDF6Wld4bUxuQmhkWE5sWkY5eVpXZHBjM1J5ZVM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjROekEyTVRjMU56TTJOVFkwTldZM01qWTFOamMyT1Rjek56UTNNamM1Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHRjFjMlZrWDNKbFoybHpkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG8wTkRNS0lDQWdJQzh2SUhCaGRYTmxaRjl3Y205d2IzTmhiSE05YzJWc1ppNXdZWFZ6WldSZmNISnZjRzl6WVd4ekxuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGczTURZeE56VTNNelkxTmpRMVpqY3dOekkyWmpjd05tWTNNell4Tm1NM013b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkJoZFhObFpGOXdjbTl3YjNOaGJITWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUTBOQW9nSUNBZ0x5OGdlR2R2ZGw5dFlXNWhaMlZ5UFVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TkRRMUNpQWdJQ0F2THlCNFoyOTJYM0JoZVc5eVBVZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTXNDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZORFEyQ2lBZ0lDQXZMeUI0WjI5MlgyTnZkVzVqYVd3OWMyVnNaaTU0WjI5MlgyTnZkVzVqYVd3dWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlRGM0TmpjMlpqYzJOV1kyTXpabU56VTJaVFl6TmprMll3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbmhuYjNaZlkyOTFibU5wYkNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TkRRM0NpQWdJQ0F2THlCNFoyOTJYM04xWW5OamNtbGlaWEk5UjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG8wTkRndE5EUTVDaUFnSUNBdkx5QnJlV05mY0hKdmRtbGtaWEk5UjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUdOdmJXMXBkSFJsWlY5dFlXNWhaMlZ5UFVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNc0NpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZORFV3Q2lBZ0lDQXZMeUI0WjI5MlgyUmhaVzF2YmoxelpXeG1MbmhuYjNaZlpHRmxiVzl1TG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZzNPRFkzTm1ZM05qVm1OalEyTVRZMU5tUTJaalpsQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWVHZHZkbDlrWVdWdGIyNGdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUTFNd29nSUNBZ0x5OGdiM0JsYmw5d2NtOXdiM05oYkY5bVpXVTljMlZzWmk1dmNHVnVYM0J5YjNCdmMyRnNYMlpsWlM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRObVkzTURZMU5tVTFaamN3TnpJMlpqY3dObVkzTXpZeE5tTTFaalkyTmpVMk5Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTl3Wlc1ZmNISnZjRzl6WVd4ZlptVmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzBOVFFLSUNBZ0lDOHZJR1JoWlcxdmJsOXZjSE5mWm5WdVpHbHVaMTlpY0hNOWMyVnNaaTVrWVdWdGIyNWZiM0J6WDJaMWJtUnBibWRmWW5CekxuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TmpRMk1UWTFObVEyWmpabE5XWTJaamN3TmpVM01qWXhOelEyT1RabU5tVTFaalkyTnpVMlpUWTBOamsyWlRZM05XWTJNamN3TnpNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWtZV1Z0YjI1ZmIzQnpYMloxYm1ScGJtZGZZbkJ6SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmY21WbmFYTjBjbmxmYlc5amF5OWpiMjUwY21GamRDNXdlVG8wTlRVS0lDQWdJQzh2SUhCeWIzQnZjMkZzWDJOdmJXMXBkRzFsYm5SZlluQnpQWE5sYkdZdWNISnZjRzl6WVd4ZlkyOXRiV2wwYldWdWRGOWljSE11ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z01IZzNNRGN5Tm1ZM01EWm1Oek0yTVRaak5XWTJNelptTm1RMlpEWTVOelEyWkRZMU5tVTNORFZtTmpJM01EY3pDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0hKdmNHOXpZV3hmWTI5dGJXbDBiV1Z1ZEY5aWNITWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUTFOZ29nSUNBZ0x5OGdiV2x1WDNKbGNYVmxjM1JsWkY5aGJXOTFiblE5YzJWc1ppNXRhVzVmY21WeGRXVnpkR1ZrWDJGdGIzVnVkQzUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNeUF2THlBd2VEWmtOamsyWlRWbU56STJOVGN4TnpVMk5UY3pOelEyTlRZME5XWTJNVFprTm1ZM05UWmxOelFLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dGFXNWZjbVZ4ZFdWemRHVmtYMkZ0YjNWdWRDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk5EVTVDaUFnSUNBdkx5QnpaV3htTG0xaGVGOXlaWEYxWlhOMFpXUmZZVzF2ZFc1MFgzTnRZV3hzTG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUwSUM4dklEQjRObVEyTVRjNE5XWTNNalkxTnpFM05UWTFOek0zTkRZMU5qUTFaall4Tm1RMlpqYzFObVUzTkRWbU56TTJaRFl4Tm1NMll3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTFoZUY5eVpYRjFaWE4wWldSZllXMXZkVzUwWDNOdFlXeHNJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzBOakFLSUNBZ0lDOHZJSE5sYkdZdWJXRjRYM0psY1hWbGMzUmxaRjloYlc5MWJuUmZiV1ZrYVhWdExuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJREI0Tm1RMk1UYzROV1kzTWpZMU56RTNOVFkxTnpNM05EWTFOalExWmpZeE5tUTJaamMxTm1VM05EVm1ObVEyTlRZME5qazNOVFprQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXRjRYM0psY1hWbGMzUmxaRjloYlc5MWJuUmZiV1ZrYVhWdElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvME5qRUtJQ0FnSUM4dklITmxiR1l1YldGNFgzSmxjWFZsYzNSbFpGOWhiVzkxYm5SZmJHRnlaMlV1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z01IZzJaRFl4TnpnMVpqY3lOalUzTVRjMU5qVTNNemMwTmpVMk5EVm1OakUyWkRabU56VTJaVGMwTldZMll6WXhOekkyTnpZMUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV0Y0WDNKbGNYVmxjM1JsWkY5aGJXOTFiblJmYkdGeVoyVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUTFOeTAwTmpNS0lDQWdJQzh2SUcxaGVGOXlaWEYxWlhOMFpXUmZZVzF2ZFc1MFBVWnBlR1ZrUVhKeVlYa29DaUFnSUNBdkx5QWdJQ0FnS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J6Wld4bUxtMWhlRjl5WlhGMVpYTjBaV1JmWVcxdmRXNTBYM050WVd4c0xuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J6Wld4bUxtMWhlRjl5WlhGMVpYTjBaV1JmWVcxdmRXNTBYMjFsWkdsMWJTNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnYzJWc1ppNXRZWGhmY21WeGRXVnpkR1ZrWDJGdGIzVnVkRjlzWVhKblpTNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQXBDaUFnSUNBdkx5QXBMQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUTJOZ29nSUNBZ0x5OGdjMlZzWmk1a2FYTmpkWE56YVc5dVgyUjFjbUYwYVc5dVgzTnRZV3hzTG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUzSUM4dklEQjROalEyT1Rjek5qTTNOVGN6TnpNMk9UWm1ObVUxWmpZME56VTNNall4TnpRMk9UWm1ObVUxWmpjek5tUTJNVFpqTm1NS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWthWE5qZFhOemFXOXVYMlIxY21GMGFXOXVYM050WVd4c0lHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvME5qY0tJQ0FnSUM4dklITmxiR1l1WkdselkzVnpjMmx2Ymw5a2RYSmhkR2x2Ymw5dFpXUnBkVzB1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVGdnTHk4Z01IZzJORFk1TnpNMk16YzFOek0zTXpZNU5tWTJaVFZtTmpRM05UY3lOakUzTkRZNU5tWTJaVFZtTm1RMk5UWTBOamszTlRaa0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaR2x6WTNWemMybHZibDlrZFhKaGRHbHZibDl0WldScGRXMGdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUTJPQW9nSUNBZ0x5OGdjMlZzWmk1a2FYTmpkWE56YVc5dVgyUjFjbUYwYVc5dVgyeGhjbWRsTG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJREU1SUM4dklEQjROalEyT1Rjek5qTTNOVGN6TnpNMk9UWm1ObVUxWmpZME56VTNNall4TnpRMk9UWm1ObVUxWmpaak5qRTNNalkzTmpVS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWthWE5qZFhOemFXOXVYMlIxY21GMGFXOXVYMnhoY21kbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvME5qa0tJQ0FnSUM4dklITmxiR1l1WkdselkzVnpjMmx2Ymw5a2RYSmhkR2x2Ymw5NGJHRnlaMlV1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNakFnTHk4Z01IZzJORFk1TnpNMk16YzFOek0zTXpZNU5tWTJaVFZtTmpRM05UY3lOakUzTkRZNU5tWTJaVFZtTnpnMll6WXhOekkyTnpZMUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaR2x6WTNWemMybHZibDlrZFhKaGRHbHZibDk0YkdGeVoyVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUTJOQzAwTnpFS0lDQWdJQzh2SUdScGMyTjFjM05wYjI1ZlpIVnlZWFJwYjI0OVJtbDRaV1JCY25KaGVTZ0tJQ0FnSUM4dklDQWdJQ0FvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJSE5sYkdZdVpHbHpZM1Z6YzJsdmJsOWtkWEpoZEdsdmJsOXpiV0ZzYkM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdjMlZzWmk1a2FYTmpkWE56YVc5dVgyUjFjbUYwYVc5dVgyMWxaR2wxYlM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdjMlZzWmk1a2FYTmpkWE56YVc5dVgyUjFjbUYwYVc5dVgyeGhjbWRsTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnpaV3htTG1ScGMyTjFjM05wYjI1ZlpIVnlZWFJwYjI1ZmVHeGhjbWRsTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUNrS0lDQWdJQzh2SUNrc0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalEzTkFvZ0lDQWdMeThnYzJWc1ppNTJiM1JwYm1kZlpIVnlZWFJwYjI1ZmMyMWhiR3d1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNakVnTHk4Z01IZzNOalptTnpRMk9UWmxOamMxWmpZME56VTNNall4TnpRMk9UWm1ObVUxWmpjek5tUTJNVFpqTm1NS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTJiM1JwYm1kZlpIVnlZWFJwYjI1ZmMyMWhiR3dnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalEzTlFvZ0lDQWdMeThnYzJWc1ppNTJiM1JwYm1kZlpIVnlZWFJwYjI1ZmJXVmthWFZ0TG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJREl5SUM4dklEQjROelkyWmpjME5qazJaVFkzTldZMk5EYzFOekkyTVRjME5qazJaalpsTldZMlpEWTFOalEyT1RjMU5tUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUyYjNScGJtZGZaSFZ5WVhScGIyNWZiV1ZrYVhWdElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvME56WUtJQ0FnSUM4dklITmxiR1l1ZG05MGFXNW5YMlIxY21GMGFXOXVYMnhoY21kbExuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURJeklDOHZJREI0TnpZMlpqYzBOamsyWlRZM05XWTJORGMxTnpJMk1UYzBOamsyWmpabE5XWTJZell4TnpJMk56WTFDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZG05MGFXNW5YMlIxY21GMGFXOXVYMnhoY21kbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvME56Y0tJQ0FnSUM4dklITmxiR1l1ZG05MGFXNW5YMlIxY21GMGFXOXVYM2hzWVhKblpTNTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeU5DQXZMeUF3ZURjMk5tWTNORFk1Tm1VMk56Vm1OalEzTlRjeU5qRTNORFk1Tm1ZMlpUVm1OemcyWXpZeE56STJOelkxQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRtOTBhVzVuWDJSMWNtRjBhVzl1WDNoc1lYSm5aU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZORGN5TFRRM09Rb2dJQ0FnTHk4Z2RtOTBhVzVuWDJSMWNtRjBhVzl1UFVacGVHVmtRWEp5WVhrb0NpQWdJQ0F2THlBZ0lDQWdLQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnpaV3htTG5admRHbHVaMTlrZFhKaGRHbHZibDl6YldGc2JDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnYzJWc1ppNTJiM1JwYm1kZlpIVnlZWFJwYjI1ZmJXVmthWFZ0TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnpaV3htTG5admRHbHVaMTlrZFhKaGRHbHZibDlzWVhKblpTNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnYzJWc1ppNTJiM1JwYm1kZlpIVnlZWFJwYjI1ZmVHeGhjbWRsTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUNrS0lDQWdJQzh2SUNrc0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalE0TWdvZ0lDQWdMeThnYzJWc1ppNXhkVzl5ZFcxZmMyMWhiR3d1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNalVnTHk4Z01IZzNNVGMxTm1ZM01qYzFObVExWmpjek5tUTJNVFpqTm1NS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXhkVzl5ZFcxZmMyMWhiR3dnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalE0TXdvZ0lDQWdMeThnYzJWc1ppNXhkVzl5ZFcxZmJXVmthWFZ0TG5aaGJIVmxMQ0FnSXlCT2J5QnNiMjVuWlhJZ2RYTmxaQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJREkySUM4dklEQjROekUzTlRabU56STNOVFprTldZMlpEWTFOalEyT1RjMU5tUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV4ZFc5eWRXMWZiV1ZrYVhWdElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvME9EUUtJQ0FnSUM4dklITmxiR1l1Y1hWdmNuVnRYMnhoY21kbExuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURJM0lDOHZJREI0TnpFM05UWm1OekkzTlRaa05XWTJZell4TnpJMk56WTFDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y1hWdmNuVnRYMnhoY21kbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvME9EQXRORGcyQ2lBZ0lDQXZMeUJ4ZFc5eWRXMDlSbWw0WldSQmNuSmhlU2dLSUNBZ0lDOHZJQ0FnSUNBb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUhObGJHWXVjWFZ2Y25WdFgzTnRZV3hzTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnpaV3htTG5GMWIzSjFiVjl0WldScGRXMHVkbUZzZFdVc0lDQWpJRTV2SUd4dmJtZGxjaUIxYzJWa0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUhObGJHWXVjWFZ2Y25WdFgyeGhjbWRsTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUNrS0lDQWdJQzh2SUNrc0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TkRnNUNpQWdJQ0F2THlCelpXeG1MbmRsYVdkb2RHVmtYM0YxYjNKMWJWOXpiV0ZzYkM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUF5T0NBdkx5QXdlRGMzTmpVMk9UWTNOamczTkRZMU5qUTFaamN4TnpVMlpqY3lOelUyWkRWbU56TTJaRFl4Tm1NMll3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbmRsYVdkb2RHVmtYM0YxYjNKMWJWOXpiV0ZzYkNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TkRrd0NpQWdJQ0F2THlCelpXeG1MbmRsYVdkb2RHVmtYM0YxYjNKMWJWOXRaV1JwZFcwdWRtRnNkV1VzSUNBaklFNXZJR3h2Ym1kbGNpQjFjMlZrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV01nTWprZ0x5OGdNSGczTnpZMU5qazJOelk0TnpRMk5UWTBOV1kzTVRjMU5tWTNNamMxTm1RMVpqWmtOalUyTkRZNU56VTJaQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5kbGFXZG9kR1ZrWDNGMWIzSjFiVjl0WldScGRXMGdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUTVNUW9nSUNBZ0x5OGdjMlZzWmk1M1pXbG5hSFJsWkY5eGRXOXlkVzFmYkdGeVoyVXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ016QWdMeThnTUhnM056WTFOamsyTnpZNE56UTJOVFkwTldZM01UYzFObVkzTWpjMU5tUTFaalpqTmpFM01qWTNOalVLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1M1pXbG5hSFJsWkY5eGRXOXlkVzFmYkdGeVoyVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUTROeTAwT1RNS0lDQWdJQzh2SUhkbGFXZG9kR1ZrWDNGMWIzSjFiVDFHYVhobFpFRnljbUY1S0FvZ0lDQWdMeThnSUNBZ0lDZ0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ2MyVnNaaTUzWldsbmFIUmxaRjl4ZFc5eWRXMWZjMjFoYkd3dWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJSE5sYkdZdWQyVnBaMmgwWldSZmNYVnZjblZ0WDIxbFpHbDFiUzUyWVd4MVpTd2dJQ01nVG04Z2JHOXVaMlZ5SUhWelpXUUtJQ0FnSUM4dklDQWdJQ0FnSUNBZ2MyVnNaaTUzWldsbmFIUmxaRjl4ZFc5eWRXMWZiR0Z5WjJVdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ0tRb2dJQ0FnTHk4Z0tTd0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvME9UWUtJQ0FnSUM4dklHTnZiVzFwZEhSbFpWOXBaRDF6Wld4bUxtTnZiVzFwZEhSbFpWOXBaQzUyWVd4MVpTNWpiM0I1S0Nrc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURZek5tWTJaRFprTmprM05EYzBOalUyTlRWbU5qazJOQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OdmJXMXBkSFJsWlY5cFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk5EazNDaUFnSUNBdkx5QmpiMjF0YVhSMFpXVmZiV1Z0WW1WeWN6MXpaV3htTG1OdmJXMXBkSFJsWlY5dFpXMWlaWEp6TG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IZzJNelptTm1RMlpEWTVOelEzTkRZMU5qVTFaalprTmpVMlpEWXlOalUzTWpjekNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMjl0YldsMGRHVmxYMjFsYldKbGNuTWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUTVPQW9nSUNBZ0x5OGdZMjl0YldsMGRHVmxYM1p2ZEdWelBYTmxiR1l1WTI5dGJXbDBkR1ZsWDNadmRHVnpMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklERXdJQzh2SURCNE5qTTJaalprTm1RMk9UYzBOelEyTlRZMU5XWTNOalptTnpRMk5UY3pDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTI5dGJXbDBkR1ZsWDNadmRHVnpJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzBPVGtLSUNBZ0lDOHZJR0ZpYzJWdVkyVmZkRzlzWlhKaGJtTmxQWE5sYkdZdVlXSnpaVzVqWlY5MGIyeGxjbUZ1WTJVdWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV01nTXpFZ0x5OGdNSGcyTVRZeU56TTJOVFpsTmpNMk5UVm1OelEyWmpaak5qVTNNall4Tm1VMk16WTFDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdKelpXNWpaVjkwYjJ4bGNtRnVZMlVnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalV3TUFvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlY5d1pYSnBiMlE5YzJWc1ppNW5iM1psY201aGJtTmxYM0JsY21sdlpDNTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBek1pQXZMeUF3ZURZM05tWTNOalkxTnpJMlpUWXhObVUyTXpZMU5XWTNNRFkxTnpJMk9UWm1OalFLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bmIzWmxjbTVoYm1ObFgzQmxjbWx2WkNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TlRBeENpQWdJQ0F2THlCamIyMXRhWFIwWldWZlozSmhZMlZmY0dWeWFXOWtQWE5sYkdZdVkyOXRiV2wwZEdWbFgyZHlZV05sWDNCbGNtbHZaQzUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QXpNeUF2THlBd2VEWXpObVkyWkRaa05qazNORGMwTmpVMk5UVm1OamMzTWpZeE5qTTJOVFZtTnpBMk5UY3lOamsyWmpZMENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMjl0YldsMGRHVmxYMmR5WVdObFgzQmxjbWx2WkNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TlRBeUNpQWdJQ0F2THlCamIyMXRhWFIwWldWZmJHRnpkRjloYm1Ob2IzSTljMlZzWmk1amIyMXRhWFIwWldWZmJHRnpkRjloYm1Ob2IzSXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ016UWdMeThnTUhnMk16Wm1ObVEyWkRZNU56UTNORFkxTmpVMVpqWmpOakUzTXpjME5XWTJNVFpsTmpNMk9EWm1OeklLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amIyMXRhWFIwWldWZmJHRnpkRjloYm1Ob2IzSWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qUTBNUzAxTURNS0lDQWdJQzh2SUhKbGRIVnliaUIwZVhBdVZIbHdaV1JIYkc5aVlXeFRkR0YwWlNnS0lDQWdJQzh2SUNBZ0lDQndZWFZ6WldSZmNtVm5hWE4wY25rOWMyVnNaaTV3WVhWelpXUmZjbVZuYVhOMGNua3VkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdjR0YxYzJWa1gzQnliM0J2YzJGc2N6MXpaV3htTG5CaGRYTmxaRjl3Y205d2IzTmhiSE11ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnZUdkdmRsOXRZVzVoWjJWeVBVZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnZUdkdmRsOXdZWGx2Y2oxSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSGhuYjNaZlkyOTFibU5wYkQxelpXeG1MbmhuYjNaZlkyOTFibU5wYkM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCNFoyOTJYM04xWW5OamNtbGlaWEk5UjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQnJlV05mY0hKdmRtbGtaWEk5UjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmpiMjF0YVhSMFpXVmZiV0Z1WVdkbGNqMUhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhobmIzWmZaR0ZsYlc5dVBYTmxiR1l1ZUdkdmRsOWtZV1Z0YjI0dWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ2VHZHZkbDltWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjNCdmMyVnlYMlpsWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdiM0JsYmw5d2NtOXdiM05oYkY5bVpXVTljMlZzWmk1dmNHVnVYM0J5YjNCdmMyRnNYMlpsWlM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCa1lXVnRiMjVmYjNCelgyWjFibVJwYm1kZlluQnpQWE5sYkdZdVpHRmxiVzl1WDI5d2MxOW1kVzVrYVc1blgySndjeTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0J3Y205d2IzTmhiRjlqYjIxdGFYUnRaVzUwWDJKd2N6MXpaV3htTG5CeWIzQnZjMkZzWDJOdmJXMXBkRzFsYm5SZlluQnpMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJRzFwYmw5eVpYRjFaWE4wWldSZllXMXZkVzUwUFhObGJHWXViV2x1WDNKbGNYVmxjM1JsWkY5aGJXOTFiblF1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnYldGNFgzSmxjWFZsYzNSbFpGOWhiVzkxYm5ROVJtbDRaV1JCY25KaGVTZ0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0tBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQWdjMlZzWmk1dFlYaGZjbVZ4ZFdWemRHVmtYMkZ0YjNWdWRGOXpiV0ZzYkM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJQ0FnSUhObGJHWXViV0Y0WDNKbGNYVmxjM1JsWkY5aGJXOTFiblJmYldWa2FYVnRMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQWdjMlZzWmk1dFlYaGZjbVZ4ZFdWemRHVmtYMkZ0YjNWdWRGOXNZWEpuWlM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdLUW9nSUNBZ0x5OGdJQ0FnSUNrc0NpQWdJQ0F2THlBZ0lDQWdaR2x6WTNWemMybHZibDlrZFhKaGRHbHZiajFHYVhobFpFRnljbUY1S0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNCelpXeG1MbVJwYzJOMWMzTnBiMjVmWkhWeVlYUnBiMjVmYzIxaGJHd3VkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNBZ0lDQnpaV3htTG1ScGMyTjFjM05wYjI1ZlpIVnlZWFJwYjI1ZmJXVmthWFZ0TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWdJQ0FnYzJWc1ppNWthWE5qZFhOemFXOXVYMlIxY21GMGFXOXVYMnhoY21kbExuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FnSUNBZ2MyVnNaaTVrYVhOamRYTnphVzl1WDJSMWNtRjBhVzl1WDNoc1lYSm5aUzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0tRb2dJQ0FnTHk4Z0lDQWdJQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RtOTBhVzVuWDJSMWNtRjBhVzl1UFVacGVHVmtRWEp5WVhrb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSUNBZ0lITmxiR1l1ZG05MGFXNW5YMlIxY21GMGFXOXVYM050WVd4c0xuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FnSUNBZ2MyVnNaaTUyYjNScGJtZGZaSFZ5WVhScGIyNWZiV1ZrYVhWdExuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FnSUNBZ2MyVnNaaTUyYjNScGJtZGZaSFZ5WVhScGIyNWZiR0Z5WjJVdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNCelpXeG1Mblp2ZEdsdVoxOWtkWEpoZEdsdmJsOTRiR0Z5WjJVdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ2tLSUNBZ0lDOHZJQ0FnSUNBcExBb2dJQ0FnTHk4Z0lDQWdJSEYxYjNKMWJUMUdhWGhsWkVGeWNtRjVLQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQW9DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDQWdJQ0J6Wld4bUxuRjFiM0oxYlY5emJXRnNiQzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0lDQWdJSE5sYkdZdWNYVnZjblZ0WDIxbFpHbDFiUzUyWVd4MVpTd2dJQ01nVG04Z2JHOXVaMlZ5SUhWelpXUUtJQ0FnSUM4dklDQWdJQ0FnSUNBZ0lDQWdJSE5sYkdZdWNYVnZjblZ0WDJ4aGNtZGxMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBcENpQWdJQ0F2THlBZ0lDQWdLU3dLSUNBZ0lDOHZJQ0FnSUNCM1pXbG5hSFJsWkY5eGRXOXlkVzA5Um1sNFpXUkJjbkpoZVNnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FnSUNBZ2MyVnNaaTUzWldsbmFIUmxaRjl4ZFc5eWRXMWZjMjFoYkd3dWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNCelpXeG1MbmRsYVdkb2RHVmtYM0YxYjNKMWJWOXRaV1JwZFcwdWRtRnNkV1VzSUNBaklFNXZJR3h2Ym1kbGNpQjFjMlZrQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNCelpXeG1MbmRsYVdkb2RHVmtYM0YxYjNKMWJWOXNZWEpuWlM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdLUW9nSUNBZ0x5OGdJQ0FnSUNrc0NpQWdJQ0F2THlBZ0lDQWdiM1YwYzNSaGJtUnBibWRmWm5WdVpITTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUhCbGJtUnBibWRmY0hKdmNHOXpZV3h6UFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmpiMjF0YVhSMFpXVmZhV1E5YzJWc1ppNWpiMjF0YVhSMFpXVmZhV1F1ZG1Gc2RXVXVZMjl3ZVNncExBb2dJQ0FnTHk4Z0lDQWdJR052YlcxcGRIUmxaVjl0WlcxaVpYSnpQWE5sYkdZdVkyOXRiV2wwZEdWbFgyMWxiV0psY25NdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1kyOXRiV2wwZEdWbFgzWnZkR1Z6UFhObGJHWXVZMjl0YldsMGRHVmxYM1p2ZEdWekxuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lHRmljMlZ1WTJWZmRHOXNaWEpoYm1ObFBYTmxiR1l1WVdKelpXNWpaVjkwYjJ4bGNtRnVZMlV1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnWjI5MlpYSnVZVzVqWlY5d1pYSnBiMlE5YzJWc1ppNW5iM1psY201aGJtTmxYM0JsY21sdlpDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQmpiMjF0YVhSMFpXVmZaM0poWTJWZmNHVnlhVzlrUFhObGJHWXVZMjl0YldsMGRHVmxYMmR5WVdObFgzQmxjbWx2WkM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCamIyMXRhWFIwWldWZmJHRnpkRjloYm1Ob2IzSTljMlZzWmk1amIyMXRhWFIwWldWZmJHRnpkRjloYm1Ob2IzSXVkbUZzZFdVc0NpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNallLSUNBZ0lITmxkR0pwZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lIVnVZMjkyWlhJZ01qVUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2RXNWpiM1psY2lBeU13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWpFS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREU1Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pRMU1Rb2dJQ0FnTHk4Z2VHZHZkbDltWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk5EUXhMVFV3TXdvZ0lDQWdMeThnY21WMGRYSnVJSFI1Y0M1VWVYQmxaRWRzYjJKaGJGTjBZWFJsS0FvZ0lDQWdMeThnSUNBZ0lIQmhkWE5sWkY5eVpXZHBjM1J5ZVQxelpXeG1MbkJoZFhObFpGOXlaV2RwYzNSeWVTNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQndZWFZ6WldSZmNISnZjRzl6WVd4elBYTmxiR1l1Y0dGMWMyVmtYM0J5YjNCdmMyRnNjeTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0I0WjI5MlgyMWhibUZuWlhJOVIyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0I0WjI5MlgzQmhlVzl5UFVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdlR2R2ZGw5amIzVnVZMmxzUFhObGJHWXVlR2R2ZGw5amIzVnVZMmxzTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUhobmIzWmZjM1ZpYzJOeWFXSmxjajFIYkc5aVlXd3VlbVZ5YjE5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHdDVZMTl3Y205MmFXUmxjajFIYkc5aVlXd3VlbVZ5YjE5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHTnZiVzFwZEhSbFpWOXRZVzVoWjJWeVBVZHNiMkpoYkM1NlpYSnZYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnZUdkdmRsOWtZV1Z0YjI0OWMyVnNaaTU0WjI5MlgyUmhaVzF2Ymk1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCNFoyOTJYMlpsWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdjSEp2Y0c5elpYSmZabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQnZjR1Z1WDNCeWIzQnZjMkZzWDJabFpUMXpaV3htTG05d1pXNWZjSEp2Y0c5ellXeGZabVZsTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUdSaFpXMXZibDl2Y0hOZlpuVnVaR2x1WjE5aWNITTljMlZzWmk1a1lXVnRiMjVmYjNCelgyWjFibVJwYm1kZlluQnpMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjNCdmMyRnNYMk52YlcxcGRHMWxiblJmWW5CelBYTmxiR1l1Y0hKdmNHOXpZV3hmWTI5dGJXbDBiV1Z1ZEY5aWNITXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdiV2x1WDNKbGNYVmxjM1JsWkY5aGJXOTFiblE5YzJWc1ppNXRhVzVmY21WeGRXVnpkR1ZrWDJGdGIzVnVkQzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0J0WVhoZmNtVnhkV1Z6ZEdWa1gyRnRiM1Z1ZEQxR2FYaGxaRUZ5Y21GNUtBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNBZ0lDQnpaV3htTG0xaGVGOXlaWEYxWlhOMFpXUmZZVzF2ZFc1MFgzTnRZV3hzTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWdJQ0FnYzJWc1ppNXRZWGhmY21WeGRXVnpkR1ZrWDJGdGIzVnVkRjl0WldScGRXMHVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNBZ0lDQnpaV3htTG0xaGVGOXlaWEYxWlhOMFpXUmZZVzF2ZFc1MFgyeGhjbWRsTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQXBDaUFnSUNBdkx5QWdJQ0FnS1N3S0lDQWdJQzh2SUNBZ0lDQmthWE5qZFhOemFXOXVYMlIxY21GMGFXOXVQVVpwZUdWa1FYSnlZWGtvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ2dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJQ0FnSUhObGJHWXVaR2x6WTNWemMybHZibDlrZFhKaGRHbHZibDl6YldGc2JDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSUNBZ0lITmxiR1l1WkdselkzVnpjMmx2Ymw5a2RYSmhkR2x2Ymw5dFpXUnBkVzB1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDQWdJQ0J6Wld4bUxtUnBjMk4xYzNOcGIyNWZaSFZ5WVhScGIyNWZiR0Z5WjJVdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNCelpXeG1MbVJwYzJOMWMzTnBiMjVmWkhWeVlYUnBiMjVmZUd4aGNtZGxMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBcENpQWdJQ0F2THlBZ0lDQWdLU3dLSUNBZ0lDOHZJQ0FnSUNCMmIzUnBibWRmWkhWeVlYUnBiMjQ5Um1sNFpXUkJjbkpoZVNnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FnSUNBZ2MyVnNaaTUyYjNScGJtZGZaSFZ5WVhScGIyNWZjMjFoYkd3dWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNCelpXeG1Mblp2ZEdsdVoxOWtkWEpoZEdsdmJsOXRaV1JwZFcwdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNCelpXeG1Mblp2ZEdsdVoxOWtkWEpoZEdsdmJsOXNZWEpuWlM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJQ0FnSUhObGJHWXVkbTkwYVc1blgyUjFjbUYwYVc5dVgzaHNZWEpuWlM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdLUW9nSUNBZ0x5OGdJQ0FnSUNrc0NpQWdJQ0F2THlBZ0lDQWdjWFZ2Y25WdFBVWnBlR1ZrUVhKeVlYa29DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDZ0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0lDQWdJSE5sYkdZdWNYVnZjblZ0WDNOdFlXeHNMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQWdjMlZzWmk1eGRXOXlkVzFmYldWa2FYVnRMblpoYkhWbExDQWdJeUJPYnlCc2IyNW5aWElnZFhObFpBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQWdjMlZzWmk1eGRXOXlkVzFmYkdGeVoyVXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNrS0lDQWdJQzh2SUNBZ0lDQXBMQW9nSUNBZ0x5OGdJQ0FnSUhkbGFXZG9kR1ZrWDNGMWIzSjFiVDFHYVhobFpFRnljbUY1S0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNCelpXeG1MbmRsYVdkb2RHVmtYM0YxYjNKMWJWOXpiV0ZzYkM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJQ0FnSUhObGJHWXVkMlZwWjJoMFpXUmZjWFZ2Y25WdFgyMWxaR2wxYlM1MllXeDFaU3dnSUNNZ1RtOGdiRzl1WjJWeUlIVnpaV1FLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJQ0FnSUhObGJHWXVkMlZwWjJoMFpXUmZjWFZ2Y25WdFgyeGhjbWRsTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQXBDaUFnSUNBdkx5QWdJQ0FnS1N3S0lDQWdJQzh2SUNBZ0lDQnZkWFJ6ZEdGdVpHbHVaMTltZFc1a2N6MVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnY0dWdVpHbHVaMTl3Y205d2IzTmhiSE05VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHTnZiVzFwZEhSbFpWOXBaRDF6Wld4bUxtTnZiVzFwZEhSbFpWOXBaQzUyWVd4MVpTNWpiM0I1S0Nrc0NpQWdJQ0F2THlBZ0lDQWdZMjl0YldsMGRHVmxYMjFsYldKbGNuTTljMlZzWmk1amIyMXRhWFIwWldWZmJXVnRZbVZ5Y3k1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCamIyMXRhWFIwWldWZmRtOTBaWE05YzJWc1ppNWpiMjF0YVhSMFpXVmZkbTkwWlhNdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1lXSnpaVzVqWlY5MGIyeGxjbUZ1WTJVOWMyVnNaaTVoWW5ObGJtTmxYM1J2YkdWeVlXNWpaUzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0JuYjNabGNtNWhibU5sWDNCbGNtbHZaRDF6Wld4bUxtZHZkbVZ5Ym1GdVkyVmZjR1Z5YVc5a0xuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lHTnZiVzFwZEhSbFpWOW5jbUZqWlY5d1pYSnBiMlE5YzJWc1ppNWpiMjF0YVhSMFpXVmZaM0poWTJWZmNHVnlhVzlrTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUdOdmJXMXBkSFJsWlY5c1lYTjBYMkZ1WTJodmNqMXpaV3htTG1OdmJXMXBkSFJsWlY5c1lYTjBYMkZ1WTJodmNpNTJZV3gxWlN3S0lDQWdJQzh2SUNrS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01UY0tJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeE5nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFMUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRRS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREV5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk5ETTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVHZHZkbDl5WldkcGMzUnllVjl0YjJOckxtTnZiblJ5WVdOMExsaG5iM1pTWldkcGMzUnllVTF2WTJzdVoyVjBYM2huYjNaZlltOTRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzaG5iM1pmWW05NE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzFNRFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdjSFZ6YUdKNWRHVnpJR0poYzJVek1paERWVkJZV1RWSlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFTa0tJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTU0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN1WTI5dWRISmhZM1F1V0dkdmRsSmxaMmx6ZEhKNVRXOWpheTVuWlhSZmNISnZjRzl6WlhKZlltOTRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzQnliM0J2YzJWeVgySnZlRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNKbFoybHpkSEo1WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TlRFM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTU0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN1WTI5dWRISmhZM1F1V0dkdmRsSmxaMmx6ZEhKNVRXOWpheTVuWlhSZmNtVnhkV1Z6ZEY5aWIzaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmNtVnhkV1Z6ZEY5aWIzZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalV6TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1lubDBaV01nTXprZ0x5OGdZbUZ6WlRNeUtFTlZVRmhaTlVsQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVFcENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMbU52Ym5SeVlXTjBMbGhuYjNaU1pXZHBjM1J5ZVUxdlkyc3VaMlYwWDNKbGNYVmxjM1JmZFc1emRXSnpZM0pwWW1WZlltOTRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzSmxjWFZsYzNSZmRXNXpkV0p6WTNKcFltVmZZbTk0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvMU5EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0o1ZEdWaklETTVJQzh2SUdKaGMyVXpNaWhEVlZCWVdUVkpRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJLUW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5obmIzWmZjbVZuYVhOMGNubGZiVzlqYXk1amIyNTBjbUZqZEM1WVoyOTJVbVZuYVhOMGNubE5iMk5yTG1selgzQnliM0J2YzJGc1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thWE5mY0hKdmNHOXpZV3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pVMk1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5obmIzWmZjbVZuYVhOMGNubGZiVzlqYXk1amIyNTBjbUZqZEM1WVoyOTJVbVZuYVhOMGNubE5iMk5yTG1OeVpXRjBaVjlsYlhCMGVWOXdjbTl3YjNOaGJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpWOWxiWEIwZVY5d2NtOXdiM05oYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk5UWTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qVTNNQW9nSUNBZ0x5OGdiV0p5WDJKbFptOXlaU0E5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM011YldsdVgySmhiR0Z1WTJVS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEUxcGJrSmhiR0Z1WTJVS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJR1oxYm1SbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzFOekV0TlRjMENpQWdJQ0F2THlCeVpYTWdQU0JoY21NMExtRnlZelJmWTNKbFlYUmxLQW9nSUNBZ0x5OGdJQ0FnSUZCeWIzQnZjMkZzTEFvZ0lDQWdMeThnSUNBZ0lIQnliM0J2YzJWeUxBb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdjSFZ6YUdsdWRDQXlOd29nSUNBZ2FYUjRibDltYVdWc1pDQkhiRzlpWVd4T2RXMVZhVzUwQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1IyeHZZbUZzVG5WdFFubDBaVk5zYVdObENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSWGgwY21GUWNtOW5jbUZ0VUdGblpYTUtJQ0FnSUhCMWMyaGllWFJsY3lCaVlYTmxOalFvUTI5RlFsRjNQVDBwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRVR0ZuWlhNS0lDQWdJSEIxYzJoaWVYUmxjeUJpWVhObE5qUW9RMmxCUmtGQlJXZERjRUpQU21sclIyTXpVbWhrU0ZaNlFVRnNiV0ZYTldoaVIydzJXbGRSU1dOSVNuWmpSemw2V2xoSlVHTnRWbTVoV0U0d1kyNXNabGxZUW5kWU1teHJSVWRHZW1NeWJHNWliVlpyV0RJeGJHSlhTbXhqYmsxT1pHMDVNRnBYVW1aaVYxWjBXVzFXZVdOM2JHaGpTRUo1WWpOYWFHSklUVXRqYlZaeFdsZE9NR0ZYT1hWamQwWk9Ra0pWWm1aSVZWSlpNamwwWWxkc01HUkhWbXhZTWpGc1lsZEtiR051VFZGamJWWjRaRmRXZW1SSFZtdFlNa1owWWpOV2RXUkNSbWxpTTJ4cVlqTlNNRnBYVW1aaVYxWjBXVzFXZVdOM1ZuVmtWM2h6WTNjNWFtSXlNWFJoV0ZJd1dsZFdabVJ0T1RCYVdFMVJXbTVXZFZwSGJIVmFNVGxxV1ZoU2JGb3lPWGxsVVRWb1l6Tk9jRm95Tld4YVJqa3lZak5TYkdOM1JsZEJVVUZPWWtjNWFtRXlWbXRZTWtaMFlqTldkV1JDUW5oa1Z6bDVaRmN4Wm1SSGFIbGFXRTV2WWpKNGEwZFlaR3hoVjJSdlpFZFdhMWd6UmpGaU0wb3hZbFk1TUdGSVNteGpNbWgyWWtkUmJWSldTbE5QYkdSNVlqSTFia2xHUW5saU0wSjJZekpHYzBsR1RqQlpXRkl4WTNsQ2RtTnBRbTFoVnpWb1lrZHNObHBYVVUxWk1qbDBZbGRzTUdSSFZteFlNbXhyUlZjNWQxcFhOV1pqU0VwMlkwYzVlbGxYZUdaYWJWWnNTRWRTYUZwWE1YWmliRGwyWTBkV2VWbFlVbkJpTWpWbVdtNVdkVnBIYkhWYU1UbHBZMGhOVDJJelFteGliRGt3WVZjeGJHTXpVbWhpV0VGWFpHMDVNRnBXT1haalIxWjFZVmMxYmxnelVuQmlWMVo2WkVkR2RHTkJlRzFrVnpWcllWYzFibGd6VWpWalIxVlFaRzA1TUdGWE5XNVlNbEl4WTIxR01HRlhPWFZFTTBKb1pGaE9iRnBHT1hsYVYyUndZek5TZVdWU1VucGtWMHAwWVZoT2VtRlhPWFZZTTFKd1lsZFdlbVJIUm5SalFrWjBXbGhTYUZwSFJqQlpWamt4WTBkNGRsbFhVbXhhUVZZd1lWaFNjMXBSVm0xaU1rNHhZM2hPYTJGWVRtcGtXRTU2WVZjNWRWZ3lVakZqYlVZd1lWYzVkVVpITVhCaWJEbDVXbGhHTVZwWVRqQmFWMUptV1ZjeGRtUlhOVEJIYlRGb1pVWTVlVnBZUmpGYVdFNHdXbGRTWmxsWE1YWmtWelV3V0RKNGFHTnRaR3hETTJodVlqTmFabHBIUm14aVZ6bDFSVEJXVTFWcWNGZGlNMUpzWTJsQ2RXSXpVV2RhYlRreFltMVJlRWRGUVVGcGFrVXhaMUZOVTFKRVJUQm5Vbk5UVWtSRk0wWkZVWGhPYUZKRlMzcEpSRnA1WTBWSmJXTnVSME5zYmtwM2MybGFlV05RU1cxamJrZFRTbTVLZUc5cFdubGpZa2x0WTI1SlEwcHVTbmgzYVZwNVoybGFlVzlwV25samFFbHRZMjVKYVd4dVNuaEJhVnA1WTJwSmJXTnVTRk5LYmtwM2QybGFlV05WU1cxamJrcERTbTVLZURScFdubGpWa2x0WTI1R2FVcHVTbmRWYVZwNVkxSkpiV051UW1sS2JrcDNNR2xhZVdOSVNXMWpia05EU201S2R6UnBXalJCUlVwRVpVNVFSRmxoUVVrMFFrRktSWGhIVWxKRlRWSm9Ra0ZJY1VORlFWUjBjbkp1UzBKSVJrUnRWVGhGWXpORmVVZG5VVEExYUZCTFFrRXlZWE5PWTBWSFJVZG5NR2RTZWxSaU4wMUNTR0l2VkVoQlJVbFRNbVpDZDFOTFdHdDVRVUpEY2tKdGQxVkZaME5DY0hSQlV6SlRaV2d3UWtOU2FGZzFRVVZPY0hoRGRXZFVZakpFTTFwT2FHOUJhbWhCUVZoM1QwOUJLMUZGUzNkU2QwSllRVWhWZDJaRVEwWTBTWGxCYWk5RFdXTkxZVUYwUWtNeU5FRkJVVUZxVVRSQlJYcEhiRTl4YWxsaFFVazBRa0ZCTUVGTlVtMUNRbEpKZUVkQ1FrVlJaMjl6VG1odlFsTlNWV3RGYTFGNVJGVlJjbFJIWTI1Q1JFbE9XbmxqV1dsQmRtdEtlR2hOV25salRHbEJkazlLZDNSTldubGpVR2xCZGtaS2R6bE5XbmxqV21sQmRUaEtlR3hOV25sallXbEJkWHBLZUhCTldubE9SRXRWWTBOTlVsbHFRMVZyTkVWRFRWTlNSRmxoUVZWcmFWZFpSVU5EUlhOQ1JsSktSVlozU1VGT2FHOURVMUpYUWtOQ1NrVkdlbGxoUVRCclZtZFJaMU5TUW1NeVIyZFNTa1pUVFZOU1EyTm1hVUYwZFVaRlUwbERPVUpGU1dsb2JGSkZRVU16ZVVseFdsVlNRVUYwWjJwU1JYTkVVMUpYUW1WM05VVkxVazVGVTNkSmJFVnJRVUZEUlhORFoxSlJVMUZSU3pSSk1GRnVTbGxuVEU1NVkyMXBRWE41VTNkT1NsUm5TbEJCZHpsRlUzZEZVRkpKUVZoalNFcDJZMGM1ZWxsWGVHWlpNamwwWWxkc01HSlhWblZrUmpscFkwaFBTVU4zYkV4QlVYTm9Ra0Z3VEVKcmF6UkJRMGx5V2xWUlUxSkZhelJDZWtsTFJXdFJORU5GYkVaRFVrcEZTbmxLVEVKWFpVRkhiVEZvWlVZNWVWcFlSakZhV0U0d1dsZFNabGxYTVhaa1Z6VXdXRE5PZEZsWGVITnBRWEpIWjBKMGRGbFlhR1pqYlZaNFpGZFdlbVJIVm10WU1rWjBZak5XZFdSR09YUmFWMUp3WkZjeVNVTnhXa1pEVVRWQ1FXZG5iRXA0UWsxYWVXTmtVM2RPYmtwM2VFeEJiV1JLUm5samFsUkhZMjVHUlhOSFdubEpia1ZIVmsxVFZUUkRVbEZ3UlZOVlVXbEtkM2hzVWtWUmJFVnJSVUpwTkVGYVdrZHNlbGt6Vm5wak1teDJZbXc1YTJSWVNtaGtSMngyWW13NWVtSlhSbk5pU1dkTFZVTmphMVJIWTJsS2VFSnNWRVZzVDBGclZVdFNRMVZUVVZGRlUyZENWakppTTFKd1ltMWtabHBJVm5sWldGSndZakkxWm1NeU1XaGlSM2xKUTJsS1JrSnBZMlZUZDFwdVowRjRlR1JYT1hsa1Z6Rm1Zekl4YUdKSGVVbERaM0ZCUkVoR01XSXpTakZpVmpseldWaEtibHBaWjBvclZYTkNRMU5qYkdsQmJuaEtlV0ZKUTJWNFRFRlJhMmxLZDNoc1VrVTRRME5WT0VORE1IZExRME5KYmtNeVZrVkRlVVZGUTJsalZsUkhaVUZHV0dSc1lWZGtiMlJIVm10WU0wWXhZak5LTVdKV09YcGlWMFp6WWtsblNuUkpRVlprTWxad1dqSm9NRnBYVW1aaldGWjJZMjVXZEZneWVHaGpiV1JzYVVGdFlWTjNSVXBLZVZkSlExcEpia3B2WjBwcVZYTkNRMU5KYmtSSFZrVlVkMGxLVkhkSlRGUkJiMGxKYVdOUVdsVlJURWxSVVV0S2VGcE5XbmxuYkZwNVkySk5aMlJ1U1dsalpGcFZVVmRUV2s5Q1EwRTFSVlozWTBKSmFXTk5XbFZSYVVwNFFteFNRbHBLYXpSRlNVUnJVbGhDZDBWNVFtczRRMFpyT0VSVVJrSlFRV3hDVFVac1EwRkNSWE5XYWxwb1RWVk1RV3BSTUhOSVoxSlJVMUZSUVdkblFsb3lZak5TY0dKdFpHWmFTRlo1V1ZoU2NHSXlOV1ppVjFacllWaFdkR2xCYTBoU1VWcERMM1ZMUVVaWVduWmtSMngxV2pFNWEyUllTbWhrUjJ4MlltdzVjMWxZU201YVdXZEpOa1ZWUjFGMk4wUlRkMlZDUmtKS1FrRkRTMEZIYlZKd1l6Sk9NV016VG5CaU1qVm1Xa2hXZVZsWVVuQmlNalZtWWxkV2EyRllWblJwUVdrNFVYWTFjR2RDYkd0aFdFNXFaRmhPZW1GWE9YVllNbEl4WTIxR01HRlhPWFZZTW5ob1kyMWtiR2xCYVdKUmRqVkpVM2RHVEVKM05VSkJRVmRDUmtWTU9UZEpSV1ZSZGpOdVNXdE1PVkpUU2tNdlUxVXlSMmRHU2tsc2JVSkJaMmhNUVZKVlUxSkdZME5CUldzeVIyZEtTa1pUVFZOU1EwcFVTbmdyU1VOR01GVlNTV2RKY0VWM1ZsTlZORVJTUTJOb1NUSmtRa0ZCTkc1RFluaEpTbmR0T0ZORFkwcFVURGhxVVhsalNuWlZVa3BUZDAxSlNuZHNUVEI1WTBwVVJUaERkVEJNTHpaVFMwbERTMFpGU1dsb2JGSkRWVlJSUVVGSVNXbHdiRkpGUlVGTVEyTllVbEZHU2t0U1RrSkJRa0pLVTFKVlYxWjNXVU5VUmtGdVEydDRVWE5EVGtSSmFYUnNVa2xuU1dwRFkwcDJSV2R4U1RKamNGRjJMMlpMVlZWQ1VYWXZVMHA0SzBsQ09YZFZVa2xuU1VsNlNVaEphV05pV2xWUlNrbHBZMnRhVlZGUVVrTkpia2xYVmtWU1EyTnVhVUZtUzFOU1ZXdEZhMUZwU25oc2JGSkRTVzVIYlZaRlEzbEZSVU52WjBsTVUybENSa2RqYmtsRVNVaGFlVTVFUzFWck1rZG5Sa2hCYVVwYVUxVTBRMmRUWjB4blVVbEpWRUpWVTFKSlowZzRhMUZwUzBkV1JXZFNVVk5TUkVWWFVVRkVVMDFuVWtaQmVVNUdRa1Z6UkZOM1RVMVJVVUZPVTNkT1NtbEJaMDVKZDJoR1FrVk1Melo1U2taQ1JYTkVVM2RGVFZGUlFrWlRkMFpZUVdkQ1RFSkZiRTlCYjBWdlF6UkZiMWRGYkZoQlEwSk5Ta1p6YmtWck9FTlZSVzA1VWxGRlZWSkZjMEpTUlhOQ1JuSTRhVXAzVm14U1EwMUpTbmRXVFZwNVNXNUZWMVpGUTBOalVsUkhZMnBEUlZWRlVYWXJla2xwWTBaYVZWRnBTbmQwYkZKQ1NrSkJSbGxwU25oR2JGSkRTVzVFTWxaRlJXdFJiMmRTYkc1TloyTnVTRVZ6UWxwNVNXNUliVlpGVTNkRlNVbHBZMVphVlZGWFUxcE5hMFJyVWxoQ1FWRnBTbmhhYkZKQ1drcHJlVkZQVWtaalJVSkVTVWRVZDFGWFZIZFJWMVZGT0VSVlJUaERWVVYzVjFWSlFVVXpUM1pvZUZWNFVYTkRUa1JKYjJkSVZFVk1MMUY1U2twTFZGbGhRVlZyVmtwQ1NrVk9hRzlEVTFKWFFrTkNTa1ZHZWxsaFFUQnJWbWRSWjFOU1FtVkpRblprUlVscGFHeFNTVVZhUlRCRlFtbHBZMWhTVVZwTVFsTnJWRkZSUVZKVGQxWktSbEphV0VKblNrMVZRMk5MVkVaRGQwa3dUVzVGYTNORVZVVnNSa0p5TVVaQlZVRkNTbE5qYjFKUldreENVMnRUVVZGRlZsTjNVeXRTUW1SS1VsRlZhVXAzV214U1EwMUpTbmRhVFZvd2MwTlRkMHRKUW10c1FrRk5UV2xLZHpGc1VrTk5TVXAzTVUxYWVVbHFVM2RTVEVKdlowaERSWE5IVTFKVmFsTjNSVkJKTUhORFZIZEtUbFJHU2twR1UxRlRVa1Z6UlVacmJWUktRVFZGVm5kUlJWTjNVVmRUV2sxclJHdFNXRUpCVWxCQ1FscEthM2xSVDFKR1kwVkNRMGx1UW0xV1JVWnJiVlJLUVRWRlZuZFJSVWxwWTA1YVZWRlhVMXBOYTBSclVsaENRVkZwU25ka2JGSkNXa3ByZVZGUFVrWmpSVUpEU1c1RFIxWkZSbXR0VkVwQk5VVldkMUZGU1dsalQxcFZVVmRUV2sxclJHdFNXRUpCVVhsQ2F6aEtWSGRzVVZSM2FGRlVkMlJSU25oTmFWUjNiRlZWUlRoSFZVVTRSbFZGT0VWVlJUaEVWVVU0UTFWRmQxZFZTVUZGY1ZKRFMwZHJlRkZ6UTJ4REwzWm5hVk4zVWt4Qk1HeFBRV2RzVEVFd2JFOUJkMnhLVkdkT1QwSkRTVzVDTWxaRlEwTmpTRlJIWTJsS2QyaHNVa0ZuYmtORmVHNUphV05QV2xWUlNVcDNOVTFhTUV3dlJsVnpSbEYyTml0VGQxTXJVa0prU2xKUlZreEJhM05EUTBGNFFrRkRVa3hCTUhORFUzZExTVUpUT1VGQlFtbEJSVlZXVTFWcWNGZGlNMUpzWTNsQ2NHSnVXbWhpUjJ4clVsRmFReTl4YjNCU1VWcERMM0ZUU1VKUWVFRkJRME5CUjFWV1UxVnFjRmRpTTFKd1ltMWpaMVZIVm5saFZ6bHJTVVZXTkdOSGJIbGFWMUpHUW10TUsxWkRiRVpDYTB3clZHbHJia2cwWjBWemVGSkZTV2xvYkZKSlJWcEZhMU5KUWsxQ1FrRkJZVWxDVDBKQ1FVWkJhbEpKWjBaWE1FVkJVVzluUm1GclJVRlFTV2RHWmpCRlFVNXBUa1pCVld4Q1FVTkZiMmRTTlc1cFFWTTNUV2RaYmtWNVNreENSbEZxVkhkT1ZWUkNXbEZuUVZOTVpVcFZWVlJHUTNkSk1FMXZaMU5vYmtscGRHeFNTV2RGT0VWTUx6RlRTa1pCVlV3dmVIbEtReTgyTUdsU2QwbHdUbWh2UWxKM1NXbFhWV3hQUVdsUlRHZFJTVWxVUWxWVFVrbG5SWEpGVVdsTFIxWkZaMUkwVTFGQlFVdEphV2hzVWtsRmIwVnJSVUZDZVVseFdsVlNRa0ZHT0c1R01GVkdVM2RSY0VVd1JVRkZWWE5GVTFKVlYxWjNXVU5VUmtGdVEydDRVWE5EVGtSSmExVkVVM2RLVEVGUmVFSkJSRkpNUVZaalEwRkZjMFJLUVhOclYwVnNSa0o1WTFOVVJrSktVbEZYT1ZKUlJrRkJRVlZ1UzBWTUwzaHJjMFIyYTFGWVUzZGFUV2xCVkVGVGQwbHFRMFZWUkZGMkwwVkxWVXd2Y21sc1JrSlZUQzl1ZWxsaFFWVnJWa2w0U2tWSmJFNUtUVkZEUVVSSWFHNWlNMXBtV1RJNU1XSnRUbkJpU1dkRWJsVnJWa3BDU2tWRmExRnBTMGRXUldkU05GTlNRMGx1UWxkV1JVWkZVa0pCUTFWdloxUjRia2xwWTBWYVZWSjVRMFZUU1VKQlNYbENhV05VU1d0elJGWkZkMWRWU1VGRmNuVm5XRWRWZUZGelEwNUVTMGxGZEZwNVNYSmFWVk5KUVN0R1F5ODVkMmxwUVU4NVVrTkpiMXBWVTBKTVVrNUNRVU5KYmtZd1ZVSlRVMnRVVVZGQlVWTlZhMVpHYkdOSFFXdDRVVXAzY0UxVlRFRnFVWGxwUWsxdFkzQlJkaTl3UzFWVlFsRjJMMk5KYTJ0d1VuZEpNa2RuUmtoQmFVcGFVMVUwUTBwQmRVSkJaMmhOUmxKS1JXbEJUbWhTUTBsdldsVlRRa1pDU2tWTlVscEJRVVpuZVVKRlZVUkpNRlZHVTNkU1RFRjNlRUpCUVRGTVFrVnRTVUV6ZDJwRFJWVkdVWFl2Y2tsclZVVlRkMDVNUVZGNFFrRkRPVXhCVm1ORFFVVnpSVXBCYzJ0WFJXeEdRbmxqVTFSR1FrcFNVV2s1VWxGR1FrRkJkRXhDY2pWRlJqQnpSMVJKWjBSc2EzTkVTWGRvUmtKRlRDOTVVMDVFU1c5blJFNVZUQzkyVTB0SlFYWTFSVWxwY0d4U1JVRkJUR2xKYjFwVlVrSkJTMnRwUzBkV1JVcFNUa0pCUzBGcFMwZFdSV2RVU1ZSUlVVTlhTV2xvYkZKSlJUaEZNRVZCYWtOSmIxcFZVMEpMUWs1Q1FVbEpia1l3VlVKVFUydFVVVkZCVVZOVmExWkdiR05IUVd0NFVVcDNjRTFWVEVGcVVYbEpia0pYVmtWUlVVRjZaME0xUmxWc1NUWldSMmhzWTIxVloxbFlTbXhKU0ZwMlpFZFdlV041UW1oak0wNXdXakkxYkZwRFFqQmllVUl3WVVkc2VrbElRbmxpTTBKMll6SkdjMUYyS3pKSmFXaHNVa05WVTFGUlFVaEphWFJzVWtsblEyZERTVzVDUjFaRlkyZG9SVTFuY0hwQlJWRjVRMjVOUWxKQmJVbEJiRmx4U1RKamNGRjJLMHBMVlZWQ1VYWTVPR2xCU1haU1EwbHhXbFZTUlVwM2JUaFRRMGx1UWtkV1JXTm5hRVZOWjNCNlFVVlRTVUZwZDJwUmVVbHlXbFZSYVVwM1VteFNRMGx1U1cxV1JVbHBZMkphVlZGcFNubENiRkpEU1c1SVIxWkZTV2xvYkZKRFNYRmFWVkZwU25oQ2JGSkRTVzVKTWxaRlJtdHRWR2RSWjA5U1JtTklRVk5KYmtoWFZrVkphV05OV2xWUmFVcDRVbXhTUTBsdVIwZFdSVWxwWTB4YVZWRnBTbmM1YkZKRFNXNUNiVlpGU1dsalRscFZVV2xLZDJSc1VrTkpia05IVmtWSmFXTlBXbFZTVUVWNFdsQkdSWGhSVTNoTlZrWnNZMGRCYXpoVlZVVjVRVUZuUkVWVlJUaFVSbXhDVUVWb1dsRlVlRVZYVlVVNFVVWnNRVzVGZVVwUVJWWlNVVlIzTkZkVlJUaE9WVVU0VFVac1FsQkRlRnBSVkhkdlYxVkZPRXBWUlRoSlJteENVRUo0V2xGVWQxbFhWVVU0Umtac1FsQkNRbHBSVkhkTlYxVkZPRU5HYkVKTlZVTmpTMVJHUTNkSk1FMHlSMmRHU2taVFVWTlNRMk5UVkVaQ1NuWlZiRkJCYTJoQ1FVSlNURUZpTlVWR2VGbHVSWGxLVEVFeFVsRktkM0JOVlV4QmFsRjVTa012S3pCcFNuaFdiRkpDV2twcmVWRlBVa1pqUlVKRFNXNUdiVlpGUm10dFZFcEJOVVZXZDFGRlNXbGpSMXBWVVZkVFdrMXJSR3RTV0VKQlVXbEtkekZzVWtKYVNtdDVVVTlTUm1ORlFrTkpia0l5VmtWR2EyMVVTa0UxUlZaM1VVVkphV05KV2xWUlYxTmFUV3RFYTFKWVFrRlJhVXAzTld4U1FscEthM2xSVDFKR1kwVkNTV2RCTDBsblFrUnZaMEpLYjJkQlkwVTRTMVIzY0ZGVWQyeFJWSGRvVVZSM1pGRlVkMXBSVkhkV1VVcDRUV2xVZDFwVlNUQTRSbFpKUlVOVWQxSlZaMUZPVUVFeFVsRktkM0JOVlV4QmFsRTBiMEpCVTBsdVFrZFdSV2t2T1d4U1NXMUxRVkZGYVVwM1VteFNTWFl2V2xWVFNrMW5ZMmxLZUhoc1VrRnJhVXA0Tld4U1FUWkthV2ROUW1rdk5rd3ZVa3BDUVVGeFRDODBkamxGYTBWQlFXbFBTa2x2YTJsS2QxcHNVa05KYmtNeVZrVkZiMjFKUVVKb1JVbHBhR3hTUTFWVFVWRkJTMGxwY0d4U1JVRkJRWGxPUldsVFNrTXZMMjk0UVVOSmNscFZVVk5wVkVWQlNuYzlQU2tLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3Y205MllXeFFjbTluY21GdFVHRm5aWE1LSUNBZ0lIQjFjMmhpZVhSbGN5QmlZWE5sTmpRb1NqUnFMMnd3YTFaS1FrcEZSVzlyZVVSVFNXNUNSMVpGUlc5dFMwRm5RM2hwTHl0NVEwbDJLM05uWTJwemFFRnBjMmRIZW1sWmIwSkJRMGx1UmtkV1JXa3ZPVTFwVUM5bFNuaFJhVm8wYlV0QlVVTk1MM3BuV1UxbloxTlNTWFl2VDFKdlFVNW9iMEZGYTFOS1NXbGpWbHBWVVdsS2QxcHNVa05KYmtSWFZrVkRWWE5DUkhoRFNrbHBZMWRhVlZGcFNuZGtiRkpEU1c1RFIxWkZRME5KYmtSdFZrVkRSWE5DUkhoRFNrbHBZMGhhVlZGcFNuZG9iRkpCTWtwcFowbEJTbmhMVEM5c1FrcDJWVlZDVWtsMkwxSkRTVzVDVjFaRlNYZHJia0pWZUc1SmFXTlNXbFZUVEM5M2EyNUZWWGh1ZGtWcFNpa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndjbTkyWVd4UWNtOW5jbUZ0VUdGblpYTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZOVGN5Q2lBZ0lDQXZMeUJRY205d2IzTmhiQ3dLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR05qTmprMFpXRmhJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLR0ZrWkhKbGMzTXBkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmNtVm5hWE4wY25sZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvMU56RXROVGMwQ2lBZ0lDQXZMeUJ5WlhNZ1BTQmhjbU0wTG1GeVl6UmZZM0psWVhSbEtBb2dJQ0FnTHk4Z0lDQWdJRkJ5YjNCdmMyRnNMQW9nSUNBZ0x5OGdJQ0FnSUhCeWIzQnZjMlZ5TEFvZ0lDQWdMeThnS1FvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnUTNKbFlYUmxaRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk5UYzFDaUFnSUNBdkx5QnRZbkpmWVdaMFpYSWdQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMbTFwYmw5aVlXeGhibU5sQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JOYVc1Q1lXeGhibU5sQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQm1kVzVrWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzSmxaMmx6ZEhKNVgyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk5UYzNMVFU0TVFvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQWEpsY3k1amNtVmhkR1ZrWDJGd2NDNWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXpaV3htTG05d1pXNWZjSEp2Y0c5ellXeGZabVZsTG5aaGJIVmxJQzBnS0cxaWNsOWhablJsY2lBdElHMWljbDlpWldadmNtVXBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzFOemdLSUNBZ0lDOHZJSEpsWTJWcGRtVnlQWEpsY3k1amNtVmhkR1ZrWDJGd2NDNWhaR1J5WlhOekxBb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VGa1pISmxjM01LSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJzYVdOaGRHbHZiaUJsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM0psWjJsemRISjVYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZOVGM1Q2lBZ0lDQXZMeUJoYlc5MWJuUTljMlZzWmk1dmNHVnVYM0J5YjNCdmMyRnNYMlpsWlM1MllXeDFaU0F0SUNodFluSmZZV1owWlhJZ0xTQnRZbkpmWW1WbWIzSmxLU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRObVkzTURZMU5tVTFaamN3TnpJMlpqY3dObVkzTXpZeE5tTTFaalkyTmpVMk5Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTl3Wlc1ZmNISnZjRzl6WVd4ZlptVmxJR1Y0YVhOMGN3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUMwS0lDQWdJQzBLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5eVpXZHBjM1J5ZVY5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pVM053b2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjbVZuYVhOMGNubGZiVzlqYXk5amIyNTBjbUZqZEM1d2VUbzFPREFLSUNBZ0lDOHZJR1psWlQwd0xBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXlaV2RwYzNSeWVWOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qVTNOeTAxT0RFS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF5WlhNdVkzSmxZWFJsWkY5aGNIQXVZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljMlZzWmk1dmNHVnVYM0J5YjNCdmMyRnNYMlpsWlM1MllXeDFaU0F0SUNodFluSmZZV1owWlhJZ0xTQnRZbkpmWW1WbWIzSmxLU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl5WldkcGMzUnllVjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalUyTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBSEFRQUlJSURmYm9EVWt3R0E5U1FtS0FRVkgzeDFJbGR5YjI1bklGQnliM0J2YzJGc0lGTjBZWFIxY3lCdmNpQm1hVzVoYkdsNlpXUUVSVkpTT2c5d1lYVnpaV1JmY21WbmFYTjBjbmtRY0dGMWMyVmtYM0J5YjNCdmMyRnNjd3g0WjI5MlgyTnZkVzVqYVd3TGVHZHZkbDlrWVdWdGIyNFJiM0JsYmw5d2NtOXdiM05oYkY5bVpXVU1ZMjl0YldsMGRHVmxYMmxrRVdOdmJXMXBkSFJsWlY5dFpXMWlaWEp6RDJOdmJXMXBkSFJsWlY5MmIzUmxjeHhrWVdWdGIyNWZiM0JsY21GMGFXOXVYMloxYm1ScGJtZGZZbkJ6RjNCeWIzQnZjMkZzWDJOdmJXMXBkRzFsYm5SZlluQnpGRzFwYmw5eVpYRjFaWE4wWldSZllXMXZkVzUwR20xaGVGOXlaWEYxWlhOMFpXUmZZVzF2ZFc1MFgzTnRZV3hzRzIxaGVGOXlaWEYxWlhOMFpXUmZZVzF2ZFc1MFgyMWxaR2wxYlJwdFlYaGZjbVZ4ZFdWemRHVmtYMkZ0YjNWdWRGOXNZWEpuWlJsa2FYTmpkWE56YVc5dVgyUjFjbUYwYVc5dVgzTnRZV3hzR21ScGMyTjFjM05wYjI1ZlpIVnlZWFJwYjI1ZmJXVmthWFZ0R1dScGMyTjFjM05wYjI1ZlpIVnlZWFJwYjI1ZmJHRnlaMlVhWkdselkzVnpjMmx2Ymw5a2RYSmhkR2x2Ymw5NGJHRnlaMlVWZG05MGFXNW5YMlIxY21GMGFXOXVYM050WVd4c0ZuWnZkR2x1WjE5a2RYSmhkR2x2Ymw5dFpXUnBkVzBWZG05MGFXNW5YMlIxY21GMGFXOXVYMnhoY21kbEZuWnZkR2x1WjE5a2RYSmhkR2x2Ymw5NGJHRnlaMlVNY1hWdmNuVnRYM050WVd4c0RYRjFiM0oxYlY5dFpXUnBkVzBNY1hWdmNuVnRYMnhoY21kbEZYZGxhV2RvZEdWa1gzRjFiM0oxYlY5emJXRnNiQlozWldsbmFIUmxaRjl4ZFc5eWRXMWZiV1ZrYVhWdEZYZGxhV2RvZEdWa1gzRjFiM0oxYlY5c1lYSm5aUkZoWW5ObGJtTmxYM1J2YkdWeVlXNWpaUkZuYjNabGNtNWhibU5sWDNCbGNtbHZaQlpqYjIxdGFYUjBaV1ZmWjNKaFkyVmZjR1Z5YVc5a0ZXTnZiVzFwZEhSbFpWOXNZWE4wWDJGdVkyaHZjZ3dWSDN4MUFBQUFBQUFBQUFBTVZXNWhkWFJvYjNKcGVtVmtEMVp2ZEdWeUlHNXZkQ0JtYjNWdVpBNU5hWE56YVc1bklFTnZibVpwWjAwVkgzeDFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBREVZUUFEWUp3VXlBMmNuQmpJRFp5c2paeWNFSTJjbkI0R0F3dGN2WnljTGdmUURaeWNNZ2F3Q1p5Y05nWUR5aTZnSlp5Y09nWUQwOXBCZFp5Y1BnWURRMjhQMEFtY25FSUdBb0xlSDZRVm5KeEVoQkdjbkVpRUVaeWNUSVFSbkp4UWhCV2NuRlNFR1p5Y1dJUVpuSnhlQmdPcEpaeWNZSVFWbkp3aUFJREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd1p5Y0pJMmNuQ2lObkp4bUJ1QmRuSnhvalp5Y2JnZGcyWnljY2dZZ25aeWNkSTJjbkhvSFlObWNuSDRFRlp5Y2dnY0NFUFdjbklZR1FUbWNuSWlObmdBUkpWc0dyTmhvQWpnRUJoREVaRkVReEdFRUJhNEl1QkpXY1IySUViQjlXVFFUaENsRXVCSWIzNE9ZRU9lSnRpZ1NZTlM2R0JQcE8xdUlFMXNuTUdnUmNTRUJWQkRmV3JmRUUxQ0ZyYmdTNmhTRHlCQlozc3c0RWhMZlNhQVN2ZnhoZ0JLQ0N6dmdFM3puOXVRVEtEMm82QkR3eHZBSUVEU3g0a1FSRkIzT1FCSlA2emJvRXpvczZIQVQ2NmdnZkJBMmllSVVFZWsvdVF3UlMzUkRYQk5UVGVtUUVORFNkekFRVmo0M1dCRi9pV1RVRTJ5ZTVyd1Qxa1FkV0JHVmhDcDhFL2NhVndnUzZrS3RVQkJwblMwVUVxTld1bEFScTVldEdCQ2RqRFdVRWdrK1l2QVJKVkl1Z0JJSm5oUFlFSnBneUFBVERockEvQk52WVBkazJHZ0NPTGdBN0FFUUFJQUFiQUJVQUVBQUtBRm9BWXdCc0FIb0Fnd0NNQUpVQW93Q3VBQWdBd0FESkFOSUEyd0Q3QVJzQkpBRXRBVDBCU0FGZkFZa0Jsd0o3QXdjRGVnUWNCSWtFbEFTZEFBTUVwZ1h6Qmp3R1ZnWmlCbTRHZHdBQkFDSkRKeU93SWtNaVF5Y0VJMmNpUXlzalp5SkRKd1FpWnlKREt5Sm5Ja01pUTRBRVRGeGh1allhQUk0QkFBRUFJa014R1lFRUVqRVlFRU0yR2dFVkpCSkVJa00yR2dFVkpCSkVOaG9DU1NOWmdRSUlUQlVTUkNKRE5ob0JGU1VTUkNKRE5ob0JGU1VTUkNKRE5ob0JTUlVsRWtRbkJVeG5Ja00yR2dFVkpSSkVJa00yR2dFVkpSSkVJa00yR2dFVkpSSkVJa00yR2dGSkZTVVNSQ2NHVEdjaVF6WWFBUldCMEFFU1JDSkROaG9CRlNVU1JERVdJZ2s0RUNJU1JDSkROaG9CRlNVU1JDSkROaG9CRlNRU1JDSkROaG9CRlNRU1JDSkROaG9CRlNVU1JEWWFBaFVsRWtRMkdnTVZKQkpFTVJZaUNUZ1FJaEpFSWtNMkdnRVZKUkpFTmhvQ0ZTVVNSRFlhQXhVa0VrUXhGaUlKT0JBaUVrUWlRellhQVJVa0VrUWlRellhQVJVa0VrUWlRellhQVJVbEVrUTJHZ0lWSlJKRUlrTXhGaUlKT0JBaUVrUWlRellhQVJVbEVrUTJHZ0lWSWhKRU5ob0RGU1FTUkNKRE5ob0JTUlVsRWtRMkdnSkpGU1FTUkJjMkdnTkpGU1FTUkJjbkNFOERaeWNKVHdKbkp3cE1aeUpETVJZaUNUZ1FJaEpFSnlPd0lrTTJHZ0ZKRlNRU1JCYzJHZ0pKRlNVU1JEWWFBMGtWSkJKRU5ob0VTUlVrRWtTeFR3T3lHSUFFR0VHZzBySWFUd0t5R2t5eUdySWFnUWF5RUNPeUFiTzBQa2NDVndBRUtCSkVTVmNFQUVraldZRUNDRXdWRWtSWEJnQkpGVW1CQkF4QkFIY2pRUUJ4Z1FSTEFVbE9BZytCQkVzQ1R3Sk5Td05NVHdKU0p5UW5KWUlDRTFadmRHVnlJR0ZzY21WaFpIa2dkbTkwWldRTlZtOTBaWE1nYVc1MllXeHBaQ2NtS1lBVlZtOTBhVzVuSUZCbGNtbHZaQ0JGZUhCcGNtVmtUd2VPQndBSEFBWUFCUUFFQUFNQUFnQUJBQUFBQUFBQUFBQWlRMHNDVndZRUtoSkMvNEEyR2dGSkZTUVNSQmMyR2dKSkkxa2xDNEVDQ0VzQkZSSkVzVXl5R0lBRWR2OU1jTElhc2hxQkJySVFJN0lCczdRK1J3SlhBQVFvRWtSSlZ3UUFTU05aZ1FJSVRCVVNSRmNHQUVrVlNZRUVERUVBTHlOQkFDT0JCRXNCU1U0Q0Q0RUVTd0pQQWsxTEEweFBBbElwSnlWUEFvNENBQUlBQVFBQUFFc0JnQUFTUkNKRFN3SlhCZ1FxRWtML3lEWWFBVWtWSkJKRUY3R3lHSUFFaWw1TWdMSWFnUWF5RUNPeUFiTzBQa2NDVndBRUtCSkVTVmNFQUVraldZRUNDRXdWRWtSWEJnQkpGVW1CQkF4QkFDa2pRUUFqZ1FSTEFVbE9BZytCQkVzQ1R3Sk5Td05NVHdKU0p5UXBUd0tPQWdBQ0FBRUFBQUFpUTBzQ1Z3WUVLaEpDLzg0MkdnRkpGU1FTUkJleHNoaUFCSUFnYWJTeUdvRUdzaEFqc2dHenRENUhBbGNBQkNnU1JFbFhCQUJKSTFtQkFnaE1GUkpFVndZQVNSVkpnUVFNUVFCWUkwRUFVb0VFU3dGSlRnSVBnUVJMQWs4Q1RVc0RURThDVWlrbkpvQXFWR2hsY21VZ1lYSmxJSFp2ZEdWeWN5QmhjM05wWjI1bFpDQjBieUIwYUdseklIQnliM0J2YzJGc1R3T09Bd0FEQUFJQUFRQUFBQUFpUTBzQ1Z3WUVLaEpDLzU4MkdnRkpGU1FTUkJleHNoaUFCSE54TWhxeUdvRUdzaEFqc2dHenRENUhBbGNBQkNnU1JFbFhCQUJKSTFtQkFnaE1GUkpFVndZQVNSVkpnUVFNUVFBakkwRUFIWUVFU3dGSlRnSVBnUVJMQWs4Q1RVc0RURThDVWlsTWpnRUFBUUFBSWtOTEFsY0dCQ29TUXYvVU1SWWlDVGdRSWhKRUlrTTJHZ0VWSkJKRUlrTTJHZ0VWSkJKRUlrTWpLMlZFSXljRVpVUXlBMGtqSndWbFJESURSd0lqSndabFJDTW5CMlZFSXljTFpVUWpKd3hsUkNNbkRXVkVJeWNPWlVRakp3OWxSQ01uRUdWRVR3SVdUd0lXVUV3V1VDTW5FV1ZFSXljU1pVUWpKeE5sUkNNbkZHVkVUd01XVHdNV1VFOENGbEJNRmxBakp4VmxSQ01uRm1WRUl5Y1haVVFqSnhobFJFOERGazhERmxCUEFoWlFUQlpRSXljWlpVUWpKeHBsUkNNbkcyVkVUd0lXVHdJV1VFd1dVQ01uSEdWRUl5Y2RaVVFqSng1bFJFOENGazhDRmxCTUZsQWpKd2hsUkNNbkNXVkVJeWNLWlVRakp4OWxSQ01uSUdWRUl5Y2haVVFqSnlKbFJJQUJBQ05QR2xRaVR4bFVUeGRRVHhaUVR4VlFUeFJRVHhOUVR4SlFUeEZRSXhaTVN3RlFTd0ZRVHhFV1VFOFFGbEJQRHhaUVR3NFdVRThOVUU4TVVFOExVRThLVUU4SlVFc0JVRXhRVHdkUVR3WVdVRThGRmxCUEJCWlFUd01XVUU4Q0ZsQk1GbEFvVEZDd0lrTTJHZ0VWSlJKRWdEMFZIM3gxQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQXNDSkROaG9CRlNVU1JJQU9GUjk4ZFFBQUFBQUFBQUFBQUFDd0lrTTJHZ0VWSkJKRUp5ZXdJa00yR2dFVkpCSkVKeWV3SWtNMkdnRVZKQkpFSWtNMkdnRkpGU1VTUkRJS2N3RkVzWUVic2pTQkE3STFnUUt5T0lBRUNvRUJRN0pDZ0lBZ0NpQUZBQUVnQ3BCT0ppa0djM1JoZEhWekFBbG1hVzVoYkdsNlpXUUljSEp2Y0c5elpYSVBjbVZuYVhOMGNubGZZWEJ3WDJsa0VHRnpjMmxuYm1Wa1gyMWxiV0psY25NTmRtOTBaV1JmYldWdFltVnljd2xoY0hCeWIzWmhiSE1LY21WcVpXTjBhVzl1Y3dGTkJCVWZmSFVSWTI5dGJXbDBkR1ZsWDIxbGJXSmxjbk1RY21WeGRXVnpkR1ZrWDJGdGIzVnVkQkZpYjNsamIzUjBaV1JmYldWdFltVnljd1Z1ZFd4c2N3OWpiMjF0YVhSMFpXVmZkbTkwWlhNUVpuVnVaR2x1WjE5allYUmxaMjl5ZVE1aGMzTnBaMjVsWkY5MmIzUmxjd0ZXQVFBTmJHOWphMlZrWDJGdGIzVnVkQkJ4ZFc5eWRXMWZkR2h5WlhOb2IyeGtHWGRsYVdkb2RHVmtYM0YxYjNKMWJWOTBhSEpsYzJodmJHUW1SVkpTT2xkeWIyNW5JRkJ5YjNCdmMyRnNJRk4wWVhSMWN5QnZjaUJtYVc1aGJHbDZaV1FNWTI5dGJXbDBkR1ZsWDJsa0VXOXdaVzVmY0hKdmNHOXpZV3hmWm1WbEhHUmhaVzF2Ymw5dmNHVnlZWFJwYjI1ZlpuVnVaR2x1WjE5aWNITU9iM0JsYmw5MGFXMWxjM1JoYlhBV2RtOTBaVjl2Y0dWdWFXNW5YM1JwYldWemRHRnRjQXhtZFc1a2FXNW5YM1I1Y0dVUGRtOTBhVzVuWDJSMWNtRjBhVzl1RDNCaGRYTmxaRjl5WldkcGMzUnllUlJ6ZFdKdGFYTnphVzl1WDNScGJXVnpkR0Z0Y0JGdFpYUmhaR0YwWVY5MWNHeHZZV1JsWkFWMGFYUnNaUVZtYjJOMWN4TmthWE5qZFhOemFXOXVYMlIxY21GMGFXOXVGRzFwYmw5eVpYRjFaWE4wWldSZllXMXZkVzUwR20xaGVGOXlaWEYxWlhOMFpXUmZZVzF2ZFc1MFgyeGhjbWRsQzNobmIzWmZaR0ZsYlc5dUUwVlNVanBXYjNSbGNpQnViM1FnWm05MWJtUXhHRUFBaWpFMWdRTVNSREUwZ1JzU1JERTNGRVF4TmhSRUt6SURaeWNFSW1jbkdDbG5Kd3NpWnljUEltY25HU0puSnhvaVp5Y2JJbWNuSUNKbkp4d2laeWdpWnlvaVp5Y2hJbWNuSWlsbkp4QWlaeWNqSW1jbkhTSm5Kd3dpWnljVUltY25KQ0puSng0aVp5Y1ZJbWNuRmlKbkp3VWlaeWNSSW1jbkJpSm5KdzBpWnljSEltY25DQ0puSnc0aVo0QUVKRGVOUERZYUFJNEJBSkV4R1JSRU1SaEJBSHFDRUFUdHJybktCSEZEbVU4RWMzRXlHZ1EwNWhQS0JBMmFzTmNFR0VHZzBnUnpUYjdNQkhiL1RIQUVJUzJmQndTS1hreUFCQ3JCbXdVRWdDQnB0QVMyU2VoMEJDUmhYNUFFTnB4Q3VnVGIyRDNaTmhvQWpoQUFYd09PQStRRUt3UndCWEFIVXdmRENGNEl5QWovQ1ljS2FBdEJDMjRBQVFBalE0QUV6R2xPcWpZYUFJNEJBQTBBTVJtQkJSSXhHQkJFUWdvc05ob0JTUlVrRWtReURVUXJUR2NuQkRJTlp5Y1lpQXZrSnhoTVp5Y0xpQXZPSnd0TVp5Y1BpQXZGSnc5TVp5Y1ppQXU4SnhsTVp5Y2FpQXV6SnhwTVp5TkRLVWNDTVJZakNVazRFQ01TUkRZYUFVa2lXWUVDQ0VzQkZSSkVWd0lBTmhvQ1NSV0JDQkpFRnpZYUEwa1ZnUWdTUkJjMkdnUkpGU01TUkNjZmlBdHVGRVNJQzlCRUlpaGxSRUFDM3lJcVpVUkFBdGdqUkVzRFNSV0JldzVFS1JORVN3SWxFa0FBQ0VzQ2dSUVNRUUs0STBRbkpZZ0xOeWNtaUFzeVN3TkpUZ0pQQXc5RVN3RVBSSUFYY0hKdmNHOXpZV3hmWTI5dGJXbDBiV1Z1ZEY5aWNIT0lDd2xMQVFzaEJBcExCa2s0QUNJclpVUVNSRWs0QnpJS0VrUTRDRWxGQ1JKRUp5SkxCV2VBR20xaGVGOXlaWEYxWlhOMFpXUmZZVzF2ZFc1MFgzTnRZV3hzaUFyR2dCdHRZWGhmY21WeGRXVnpkR1ZrWDJGdGIzVnVkRjl0WldScGRXMklDcVpGQ1E1QkFnZ2xKeEJNWnljZFN3Tm5Kd3hMQW1kSkZ5Y2pUR2NuRkVzR1p5SW5FR1ZNU1U0Q1JRcEVTVVFpSnd4bFJFUWxFa0VCaTRBWlpHbHpZM1Z6YzJsdmJsOWtkWEpoZEdsdmJsOXpiV0ZzYklnS1VDY2tUR2NpSnhCbFRFbE9Ba1VLUkNVU1FRRVNnQlYyYjNScGJtZGZaSFZ5WVhScGIyNWZjMjFoYkd5SUNpSkZCaWNlU3dabmdBeHhkVzl5ZFcxZmMyMWhiR3lJQ2dxQURIRjFiM0oxYlY5c1lYSm5aWWdKK1VzQkNTY2xpQW54SnlhSUNleExBUWtpSnd4bFJFOENDVThDQzB3S0NDSW5DMlZFQ3lFRUNpY1ZUR2VBRlhkbGFXZG9kR1ZrWDNGMWIzSjFiVjl6YldGc2JJZ0p0SUFWZDJWcFoyaDBaV1JmY1hWdmNuVnRYMnhoY21kbGlBbWFTd0VKSnlXSUNaSW5Kb2dKalVzQkNTSW5ER1ZFVHdJSlR3SUxUQW9JSWljUFpVUUxJUVFLSnhaTVp5Z2xaeWNiTWdkbklpY2RaVVFXU1pPQkNBNUVWd2NCSWljTVpVUWlKeEJsUkJaSms0RUlEa1JYQndFeUJrOENGazhEVEZCUEFsQk1GbENBQkVzVmpaaE1VTEFqUTBzSGdSUVNRUUFnZ0JaMmIzUnBibWRmWkhWeVlYUnBiMjVmYldWa2FYVnRpQWtIUlFaQy91S0FGWFp2ZEdsdVoxOWtkWEpoZEdsdmJsOXNZWEpuWllnSTZFVUdRdjdEU3dlQkZCSkJBQ0tBR21ScGMyTjFjM05wYjI1ZlpIVnlZWFJwYjI1ZmJXVmthWFZ0aUFpOFF2NXBnQmxrYVhOamRYTnphVzl1WDJSMWNtRjBhVzl1WDJ4aGNtZGxpQWliUXY1SVN3RkxCdzVCQUFXQkZFTDk3SUVlUXYzbklrTDlSU0pDL1NVMkdnRkpJbG1CQWdoTEFSVVNSRmNDQUVrMkdnSkpGU01TUkNKVEp4K0lDRjBVUklnSXBFd1ZTVTREUkNjaEkyZEJBQTRuQ2J4SUp3bThTQ2NKVEw4alF5Y0p2VVJKU3dNSUp3bE0weWNKVEU4Q3UwTC82U0tJQ0tGRUlpaGxSQ1VUUUFBSElpcGxSRUVBTENjWFJRRkpLUk5CQUJCSlNSVVdWd1lDVEZBbkNreFFzQ05ESWl0bFJJZ0lqQ2NKdkVncUkyY3BRdi9mS1VVQlF2L1NKeCtJQjl3VVJJZ0lJeklISWljYlpVUUpJaWNrWlVRUFJDSW5JV1ZFUkNjbmlBZktTUlVrRWtRaUp4bGxSQ0luR21WRUN5RUVDb2dJTFNpQkZHY25JRElIWnlOREtVazJHZ0ZIQWlKWlNVNENnU2dMZ1FJSVRCVVNSSWdIOGtRaUtHVkVnUlFTUkRFV1FBRFNNZ1JGQXlORkJFc0RTd01NUVFBTlN3TkppQWdOSXdoRkJFTC82eUpGQkVzRFN3RU1RUUJGU3dGWEFnQkxCRWxPQW9Fb0M0RW9XRWxYQUNCTUpGc25FazhDVUVtOVJRRVVSRXNCUkVzQkZyOGlKd1ZsUkNNSUp3Vk1aeUluRVdWRUNDY1JUR2NqQ0VVRVF2K3pJaWNGWlVRaUp3dGxSQkpCQUZZaUp4RmxSQ0luRDJWRUVrUW9nUmxuTWdjbkhFc0JaeUluSG1WRVN3RUlJaWNWWlVRV1NaTWtEa1JYQkFRaUp4WmxSQlpKa3lRT1JGY0VCRElHVHdRV1R3UVdVRThEVUU4Q1VFd1dVSUFFM092aHhVeFFzQ05ESW9nSFRFTC9ReUpKS1RZYUFVa1ZKQkpFTmhvQ1NSV0JDQkpFRnpZYUEwa1ZnUWdTUkJlSUJ2ZEVJaWhsUklFWkUwRUJpaWNYUlFaTEJTa1RRUUFSU3dWSkZSWlhCZ0pNVUNjS1RGQ3dJME1uRWtzRFVFbEZCcjFGQVVBQkpTY29SUVpMQlNrU1FRRVZTd1MrUkJkSlJRVWlKd1psUkNNSUp3Wk1aMHNDU3dLSUJrbEJBTU1pSncxbFJDTUlKdzFNWnlJalN3UkxCb2dIQ0VzR1NSVWpTd0VQSTBzQ1R3Sk5URkpKRlNRU1JFc0VGa21USkE1RVZ3UUVTd1FXU1pNa0RrUlhCQVJQQkJaSmt5UU9SRmNFQkNJbkJtVkVGa21USkE1RVZ3UUVJaWNOWlVRV1NaTWtEa1JYQkFRaUp3ZGxSQlpKa3lRT1JGY0VCQ0luQ0dWRUZrbVRKQTVFVndRRUlpY09aVVFXU1pNa0RrUlhCQVF5Qms4SlR3bFFUd2hRVHdkUUp4TWlUd2xVVUU4R1VFOEZVRThFVUU4RFVFOENVRXdXVUlBRXFSQ0tHa3hRc0NsQy92Z2lTd1JMQTBsT0FnbExBMGxPQXdsSlRnTk9CQ0luQjJWRUNDY0hUR2NpSndobFJBZ25DRXhuSWljT1pVUUlKdzVNWjBML0ZVc0ZRdjYrU3dTK1JCZEpSUVZMQWtzQ0NBeEJBQ1JMQTBzQ1N3S0lCUzlBQUJpQUVVVlNVanBXYjNSbGN5QnBiblpoYkdsa1JRWkMvcW9wUlFaQy9xU0lCUHhBQUNDQUdVVlNVanBXYjNScGJtY2dVR1Z5YVc5a0lFVjRjR2x5WldSRkJrTCtWQ2xGQmtMK1Rpa25INGdFc3hSRUlpaGxSSUVaRWtTSUJNQkJBQWFJQk9CQkFGQWpSSWdGVzBFQVFvZ0Zha0VBUElnRmYwRUFOaU5GQVVsQkFDRW9nUjVuaUFTN01nWW5FeUpMQkZRalR3TlVUQlpRZ0FTTGVKVVVURkN3STBNb2dTaG5JaXRsUklnRThFTC8xU0pGQVVML3h5SkMvNjBpUndJcE5ob0JSd0lpV1VsT0FpUUxnUUlJVEJVU1JJZ0VyRVFpS0dWRWdSNFNRQUFLSWlobFJJRW9Fa0VBQnlJcVpVUkJBRjhuRjBVRlN3UXBFMEVBRVVzRVNSVVdWd1lDVEZBbkNreFFzQ05ESWtVRFN3SkxBUXhCQURSTEFWY0NBRXNESkFza1dFbEZCeWNTVEZCSlJRVzlSUUZBQUFVbktFTC94a3NEdmtRWFN3Wk1pQVRBU3dJakNFVURRdi9FS1VML3JpbEZCVUwvbnpZYUFVa1ZJeEpFSWxOSk1RQ0FESGhuYjNaZlkyOTFibU5wYklnRG5Va1ZKQkpFRWtRaUtHVkVnUjRTUkNJbkJXVkVGRVJCQUNVb2dUeG5JaWNFWlVSeUNFU0lCQUl5QmljVElrc0RWRXdXVUlBRXJ1Z1hHVXhRc0NOREtJRXRaeUlyWlVTSUErRkMvOXdpaUFPOVJDSW9aVVNCTFJOQkFDSW5GMFVCU1NrVFFRQVFTVWtWRmxjR0FreFFKd3BNVUxBalF5aUJNbWNwUXYvcEtVVUJRdi9jSWtrcFJ3STJHZ0ZIQWlKWlNVNENKQXVCQWdoTUZSSkVpQU5oUkNJb1pVU0JGQkpFTVJaQUFGZ3lCRVVESTBVRlN3UkxBd3hCQUExTEJFbUlBM3dqQ0VVRlF2L3JJa1VFU3dOTEFReEJBQzlMQVZjQ0FFc0VKQXNrV0VsRkJ5Y1NURkJKUlFpOVJRRkJBQXRMQnI1RUYwc0dUSWdEbGtzREl3aEZCRUwveVNORElvZ0ROVUwvdlNLSUF2NUVJaXBsUkVBQUxpSW9aVVJCQUtraUtHVkVKUk5CQUtBaUtHVkVnVElUUVFDV0lpaGxSSUU4RTBFQWpDSW9aVVNCS0JOQkFJSW5GMFVCU1NrVFFRQVFTVWtWRmxjR0FreFFKd3BNVUxBalF5SW5CV1ZFUVFBemdDNUZVbEk2VkdobGNtVWdZWEpsSUhadmRHVnljeUJoYzNOcFoyNWxaQ0IwYnlCMGFHbHpJSEJ5YjNCdmMyRnNRdisySWlobFJDVVNRUUFISWl0bFJJZ0NnQ0luQkdWRWNnaEVNZ3B6QUVReUNuTUJSQW1JQWxZcUkyY3BRditKS1VVQlF2OThpQUl2UkNJcVpVUkVKd204U0NJbkJHVkVjZ2hFTWdwekFFU0lBaXdqUXlJclpVUWlKd1JsUkNJbkltVkVJaWNiWlVRaUp5QmxSQ0luSEdWRUlpaGxSQ0lxWlVRaUp4QmxSQ0luSTJWRUZrbVRnUWdPUkZjSEFTSW5IV1ZFSWljTVpVUWlKeFJsUkNJbkdHVkVJaWNMWlVRaUp3OWxSQ0luQm1WRUlpY05aVVFpSndkbFJDSW5DR1ZFSWljT1pVUlBFeFpQRkV4UVN4TVZGbGNHQWs4VVVFeUFBZ0RFVUU4VEZsQlBFaFpRVHhFV1VFOFFGbEFuRXlKUEVWUlFUdzRXVUU4TlVFOE1GbEJQQ3haUVR3b1dVRThKVUU4SUZsQlBCeFpRVHdZV1VFOEZGbEJQQkJaUVR3TVdVRThDRmxCTVVDY0tURkN3STBNMkdnRkpGU1FTUkNjU1RGQkp2VWxQQWtoQkFCUkxBYjVFRnhZbkV5SkxBMVJRSndwTVVMQWpReUpDLyswaUp4VmxSQlpKa3lRT1JGY0VCQ0luRm1WRUZrbVRKQTVFVndRRUlpY0daVVFXU1pNa0RrUlhCQVFpSncxbFJCWkpreVFPUkZjRUJDSW5CMlZFRmttVEpBNUVWd1FFSWljSVpVUVdTWk1rRGtSWEJBUWlKdzVsUkJaSmt5UU9SRmNFQklnQS9JZ0JEb2dCSm9nQWNFOEtUd3BRVHdsUVR3aFFUd2RRVHdaUVR3VlFKeE1pVHdaVUkwOEZWSUVDVHdSVWdRTlBBMVJRSndwTVVMQWpRNG9CQVNJbkJHVkVpLzlsUkltS0FRRWlKd1JsUkl2L1pVU0pNZ2NpSnh4bFJBa2lKeDVsUkE2SmlnTUJpLzZML1JKQkFBcUwvNHY5RWtFQUFpT0pJb2tpSndabFJDSW5DMlZFRW9tSUFCaEVJaWhsUkNVU1FRQUtJaXBsUkVBQUF5TkVpU0pDLy9veEFDSXJaVVFTaVRFQUo3SkFnTGNCSjRqL2wwa1ZKQkpFRW9reURTSW5CR1ZFRW9tS0FnQ3hpLyt5Q0l2K3NnY2pzaEFpc2dHemlZb0JBQ0luRkdWRWkvOU1pUC9lSnhRaVo0bUtBUUNML3pnWU1nZ1NSSXYvT1JvQU5ob0FFa1NKSWljVlpVUWlKd1psUkNJbkRXVkVDVXNCRHhDSklpY1daVVFpSndkbFJDSW5DR1ZFQ0NJbkRtVkVDRXNCRHhDSklpY0haVVFpSndobFJBMkppZ0lBSnhLTC9sQkp2VVVCUkl2L1JDSW5CV1ZFSXdrbkJVeG5JaWNSWlVTTC93a25FVXhudkVpSnNrQ0FCTXhwVHFxeUdreXlHb0VHc2hBanNnR3p0RDB5Q25NQlJMRkxBWElJUkNNbkIyVkVUd0pQQkFrSnNnaXlCeUt5RUNPeUFiTVdLRXhRc0NKRCIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
