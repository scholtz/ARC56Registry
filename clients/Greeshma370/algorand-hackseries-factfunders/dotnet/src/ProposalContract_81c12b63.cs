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

namespace Arc56.Generated.Greeshma370.algorand_hackseries_factfunders.ProposalContract_81c12b63
{


    public class ProposalContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ProposalContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DonationBoxKey : AVMObjectType
            {
                public ulong ProposalId { get; set; }

                public Algorand.Address Donor { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProposalId.From(ProposalId);
                    ret.AddRange(vProposalId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDonor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vDonor.From(Donor);
                    ret.AddRange(vDonor.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DonationBoxKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new DonationBoxKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalId = vProposalId.ToValue();
                    if (valueProposalId is ulong vProposalIdValue) { ret.ProposalId = vProposalIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDonor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDonor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDonor = vDonor.ToValue();
                    if (valueDonor is Algorand.Address vDonorValue) { ret.Donor = vDonorValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DonationBoxKey);
                }
                public bool Equals(DonationBoxKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DonationBoxKey left, DonationBoxKey right)
                {
                    return EqualityComparer<DonationBoxKey>.Default.Equals(left, right);
                }
                public static bool operator !=(DonationBoxKey left, DonationBoxKey right)
                {
                    return !(left == right);
                }

            }

            public class FutureFund : AVMObjectType
            {
                public Algorand.Address Primary { get; set; }

                public Algorand.Address Backup { get; set; }

                public ulong UnlockTime { get; set; }

                public ulong Amount { get; set; }

                public bool Claimed { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrimary = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPrimary.From(Primary);
                    ret.AddRange(vPrimary.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBackup = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vBackup.From(Backup);
                    ret.AddRange(vBackup.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnlockTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUnlockTime.From(UnlockTime);
                    ret.AddRange(vUnlockTime.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClaimed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vClaimed.From(Claimed);
                    ret.AddRange(vClaimed.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static FutureFund Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new FutureFund();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrimary = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPrimary.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrimary = vPrimary.ToValue();
                    if (valuePrimary is Algorand.Address vPrimaryValue) { ret.Primary = vPrimaryValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBackup = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBackup.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBackup = vBackup.ToValue();
                    if (valueBackup is Algorand.Address vBackupValue) { ret.Backup = vBackupValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnlockTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUnlockTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUnlockTime = vUnlockTime.ToValue();
                    if (valueUnlockTime is ulong vUnlockTimeValue) { ret.UnlockTime = vUnlockTimeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClaimed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vClaimed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueClaimed = vClaimed.ToValue();
                    if (valueClaimed is bool vClaimedValue) { ret.Claimed = vClaimedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as FutureFund);
                }
                public bool Equals(FutureFund? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(FutureFund left, FutureFund right)
                {
                    return EqualityComparer<FutureFund>.Default.Equals(left, right);
                }
                public static bool operator !=(FutureFund left, FutureFund right)
                {
                    return !(left == right);
                }

            }

            public class Proposal : AVMObjectType
            {
                public string Name { get; set; }

                public string Title { get; set; }

                public string Description { get; set; }

                public string Category { get; set; }

                public ulong AmountRequired { get; set; }

                public Algorand.Address CreatedBy { get; set; }

                public ulong AmountRaised { get; set; }

                public Structs.ProposalMilestones[] Milestones { get; set; }

                public ulong NoOfDonations { get; set; }

                public ulong NoOfUniqueDonors { get; set; }

                public ulong CurrentMilestone { get; set; }

                public ulong CreatedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTitle.From(Title);
                    stringRef[ret.Count] = vTitle.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDescription.From(Description);
                    stringRef[ret.Count] = vDescription.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCategory = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCategory.From(Category);
                    stringRef[ret.Count] = vCategory.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountRequired = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmountRequired.From(AmountRequired);
                    ret.AddRange(vAmountRequired.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedBy = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCreatedBy.From(CreatedBy);
                    ret.AddRange(vCreatedBy.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountRaised = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmountRaised.From(AmountRaised);
                    ret.AddRange(vAmountRaised.Encode());
                    var arrMilestones = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ProposalMilestones>(x => Structs.ProposalMilestones.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrMilestones.Value = (Milestones ?? Array.Empty<Structs.ProposalMilestones>()).ToList();
                    stringRef[ret.Count] = arrMilestones.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNoOfDonations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNoOfDonations.From(NoOfDonations);
                    ret.AddRange(vNoOfDonations.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNoOfUniqueDonors = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNoOfUniqueDonors.From(NoOfUniqueDonors);
                    ret.AddRange(vNoOfUniqueDonors.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrentMilestone = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCurrentMilestone.From(CurrentMilestone);
                    ret.AddRange(vCurrentMilestone.Encode());
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

                public static Proposal Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Proposal();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexTitle = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTitle.Decode(bytes.Skip(indexTitle + prefixOffset).ToArray());
                    var valueTitle = vTitle.ToValue();
                    if (valueTitle is string vTitleValue) { ret.Title = vTitleValue; }
                    var indexDescription = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDescription.Decode(bytes.Skip(indexDescription + prefixOffset).ToArray());
                    var valueDescription = vDescription.ToValue();
                    if (valueDescription is string vDescriptionValue) { ret.Description = vDescriptionValue; }
                    var indexCategory = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCategory = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCategory.Decode(bytes.Skip(indexCategory + prefixOffset).ToArray());
                    var valueCategory = vCategory.ToValue();
                    if (valueCategory is string vCategoryValue) { ret.Category = vCategoryValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountRequired = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountRequired.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountRequired = vAmountRequired.ToValue();
                    if (valueAmountRequired is ulong vAmountRequiredValue) { ret.AmountRequired = vAmountRequiredValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedBy = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCreatedBy.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedBy = vCreatedBy.ToValue();
                    if (valueCreatedBy is Algorand.Address vCreatedByValue) { ret.CreatedBy = vCreatedByValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountRaised = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmountRaised.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmountRaised = vAmountRaised.ToValue();
                    if (valueAmountRaised is ulong vAmountRaisedValue) { ret.AmountRaised = vAmountRaisedValue; }
                    var indexMilestones = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrMilestones = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ProposalMilestones>(x => Structs.ProposalMilestones.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrMilestones.Decode(bytes.Skip(indexMilestones + prefixOffset).ToArray());
                    ret.Milestones = arrMilestones.Value.ToArray();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNoOfDonations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNoOfDonations.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNoOfDonations = vNoOfDonations.ToValue();
                    if (valueNoOfDonations is ulong vNoOfDonationsValue) { ret.NoOfDonations = vNoOfDonationsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNoOfUniqueDonors = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNoOfUniqueDonors.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNoOfUniqueDonors = vNoOfUniqueDonors.ToValue();
                    if (valueNoOfUniqueDonors is ulong vNoOfUniqueDonorsValue) { ret.NoOfUniqueDonors = vNoOfUniqueDonorsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrentMilestone = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCurrentMilestone.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCurrentMilestone = vCurrentMilestone.ToValue();
                    if (valueCurrentMilestone is ulong vCurrentMilestoneValue) { ret.CurrentMilestone = vCurrentMilestoneValue; }
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
                    return Equals(obj as Proposal);
                }
                public bool Equals(Proposal? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Proposal left, Proposal right)
                {
                    return EqualityComparer<Proposal>.Default.Equals(left, right);
                }
                public static bool operator !=(Proposal left, Proposal right)
                {
                    return !(left == right);
                }

            }

            public class CreateProposalArgMilestones : AVMObjectType
            {
                public string Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
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

                public static CreateProposalArgMilestones Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new CreateProposalArgMilestones();
                    uint count = 0;
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as CreateProposalArgMilestones);
                }
                public bool Equals(CreateProposalArgMilestones? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CreateProposalArgMilestones left, CreateProposalArgMilestones right)
                {
                    return EqualityComparer<CreateProposalArgMilestones>.Default.Equals(left, right);
                }
                public static bool operator !=(CreateProposalArgMilestones left, CreateProposalArgMilestones right)
                {
                    return !(left == right);
                }

            }

            public class ProposalMilestones : AVMObjectType
            {
                public string Field0 { get; set; }

                public ulong Field1 { get; set; }

                public string Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public ulong Field5 { get; set; }

                public bool Field6 { get; set; }

                public ulong Field7 { get; set; }

                public ulong Field8 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static ProposalMilestones Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalMilestones();
                    uint count = 0;
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(bytes.Skip(indexField2 + prefixOffset).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is bool vField6Value) { ret.Field6 = vField6Value; }
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
                    return Equals(obj as ProposalMilestones);
                }
                public bool Equals(ProposalMilestones? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalMilestones left, ProposalMilestones right)
                {
                    return EqualityComparer<ProposalMilestones>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalMilestones left, ProposalMilestones right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="title"> </param>
        /// <param name="description"> </param>
        /// <param name="category"> </param>
        /// <param name="amount_required"> </param>
        /// <param name="milestones"> CreateProposalArgMilestones</param>
        /// <param name="payment"> </param>
        public async Task CreateProposal(PaymentTransaction payment, string name, string title, string description, string category, ulong amount_required, Structs.CreateProposalArgMilestones[] milestones, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 106, 80, 30, 88 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var titleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); titleAbi.From(title);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var categoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); categoryAbi.From(category);
            var amount_requiredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_requiredAbi.From(amount_required);
            var milestonesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.CreateProposalArgMilestones>(x => Structs.CreateProposalArgMilestones.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; milestonesAbi.From(milestones);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, titleAbi, descriptionAbi, categoryAbi, amount_requiredAbi, milestonesAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateProposal_Transactions(PaymentTransaction payment, string name, string title, string description, string category, ulong amount_required, Structs.CreateProposalArgMilestones[] milestones, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 106, 80, 30, 88 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var titleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); titleAbi.From(title);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var categoryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); categoryAbi.From(category);
            var amount_requiredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_requiredAbi.From(amount_required);
            var milestonesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.CreateProposalArgMilestones>(x => Structs.CreateProposalArgMilestones.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; milestonesAbi.From(milestones);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, titleAbi, descriptionAbi, categoryAbi, amount_requiredAbi, milestonesAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        /// <param name="payment"> </param>
        public async Task DonateProposal(PaymentTransaction payment, ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 135, 103, 85, 208 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DonateProposal_Transactions(PaymentTransaction payment, ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 135, 103, 85, 208 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        /// <param name="proof_link"> </param>
        public async Task SubmitProof(ulong proposal_id, string proof_link, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 111, 130, 195 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var proof_linkAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proof_linkAbi.From(proof_link);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi, proof_linkAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitProof_Transactions(ulong proposal_id, string proof_link, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 111, 130, 195 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var proof_linkAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proof_linkAbi.From(proof_link);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi, proof_linkAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        /// <param name="vote"> </param>
        public async Task VoteMilestone(ulong proposal_id, bool vote, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 80, 127, 24 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var voteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); voteAbi.From(vote);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi, voteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> VoteMilestone_Transactions(ulong proposal_id, bool vote, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 80, 127, 24 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var voteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); voteAbi.From(vote);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi, voteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        public async Task ClaimMilestone(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 148, 217, 99 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimMilestone_Transactions(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 148, 217, 99 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        public async Task RefundIfInactive(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 64, 89, 209 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RefundIfInactive_Transactions(ulong proposal_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 64, 89, 209 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="primary"> </param>
        /// <param name="backup"> </param>
        /// <param name="unlock_time"> </param>
        /// <param name="payment"> </param>
        public async Task FundFutureSelf(PaymentTransaction payment, Algorand.Address primary, Algorand.Address backup, ulong unlock_time, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 233, 18, 130, 38 };
            var primaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); primaryAbi.From(primary);
            var backupAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); backupAbi.From(backup);
            var unlock_timeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unlock_timeAbi.From(unlock_time);

            var result = await base.CallApp(new List<object> { abiHandle, primaryAbi, backupAbi, unlock_timeAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FundFutureSelf_Transactions(PaymentTransaction payment, Algorand.Address primary, Algorand.Address backup, ulong unlock_time, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 233, 18, 130, 38 };
            var primaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); primaryAbi.From(primary);
            var backupAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); backupAbi.From(backup);
            var unlock_timeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unlock_timeAbi.From(unlock_time);

            return await base.MakeTransactionList(new List<object> { abiHandle, primaryAbi, backupAbi, unlock_timeAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="fund_id"> </param>
        public async Task ClaimFutureSelf(ulong fund_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 105, 86, 119 };
            var fund_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fund_idAbi.From(fund_id);

            var result = await base.CallApp(new List<object> { abiHandle, fund_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimFutureSelf_Transactions(ulong fund_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 105, 86, 119 };
            var fund_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fund_idAbi.From(fund_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, fund_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHJvcG9zYWxDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJEb25hdGlvbkJveEtleSI6W3sibmFtZSI6InByb3Bvc2FsX2lkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRvbm9yIiwidHlwZSI6ImFkZHJlc3MifV0sIkZ1dHVyZUZ1bmQiOlt7Im5hbWUiOiJwcmltYXJ5IiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJiYWNrdXAiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InVubG9ja190aW1lIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjbGFpbWVkIiwidHlwZSI6ImJvb2wifV0sIlByb3Bvc2FsIjpbeyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ0aXRsZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJkZXNjcmlwdGlvbiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJjYXRlZ29yeSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJhbW91bnRfcmVxdWlyZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY3JlYXRlZF9ieSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYW1vdW50X3JhaXNlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtaWxlc3RvbmVzIiwidHlwZSI6IlByb3Bvc2FsTWlsZXN0b25lc1tdIn0seyJuYW1lIjoibm9fb2ZfZG9uYXRpb25zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im5vX29mX3VuaXF1ZV9kb25vcnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY3VycmVudF9taWxlc3RvbmUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY3JlYXRlZF9hdCIsInR5cGUiOiJ1aW50NjQifV0sIkNyZWF0ZVByb3Bvc2FsQXJnTWlsZXN0b25lcyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dLCJQcm9wb3NhbE1pbGVzdG9uZXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkNyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDgiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9wcm9wb3NhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aXRsZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVzY3JpcHRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhdGVnb3J5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRfcmVxdWlyZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6IihzdHJpbmcsdWludDY0KVtdIiwic3RydWN0IjoiQ3JlYXRlUHJvcG9zYWxBcmdNaWxlc3RvbmVzIiwibmFtZSI6Im1pbGVzdG9uZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZG9uYXRlX3Byb3Bvc2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1Ym1pdF9wcm9vZiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvb2ZfbGluayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2b3RlX21pbGVzdG9uZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xhaW1fbWlsZXN0b25lIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZnVuZF9pZl9pbmFjdGl2ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmdW5kX2Z1dHVyZV9zZWxmIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmltYXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmFja3VwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1bmxvY2tfdGltZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGFpbV9mdXR1cmVfc2VsZiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmdW5kX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6Mn0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTE3NF0sImVycm9yTWVzc2FnZSI6IkFsbCBtaWxlc3RvbmVzIGFscmVhZHkgY29tcGxldGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEzN10sImVycm9yTWVzc2FnZSI6IkFscmVhZHkgY2xhaW1lZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyM10sImVycm9yTWVzc2FnZSI6IkFtb3VudCByZXF1aXJlZCBtdXN0IGJlIGdyZWF0ZXIgdGhhbiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODMwXSwiZXJyb3JNZXNzYWdlIjoiQXQgbGVhc3Qgb25lIG1pbGVzdG9uZSBpcyByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0ODVdLCJlcnJvck1lc3NhZ2UiOiJDcmVhdG9yIGNhbm5vdCB2b3RlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjExOF0sImVycm9yTWVzc2FnZSI6IkZ1bmQgZG9lcyBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDY5XSwiZXJyb3JNZXNzYWdlIjoiRnVuZGluZyBtdXN0IGJlIGZyb20gY2FsbGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxNF0sImVycm9yTWVzc2FnZSI6IkdvYWwgYWxyZWFkeSByZWFjaGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0M10sImVycm9yTWVzc2FnZSI6IkdvYWwgbm90IHJlYWNoZWQgeWV0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzE0LDc0MywxMDA2LDEwMTAsMTEyNiwxMTM0LDExMzksMTIxNCwxNDExLDE0NjUsMTQ3OSwxNzE1LDE3OTMsMTkzNCwyMTQ3LDIxNThdLCJlcnJvck1lc3NhZ2UiOiJJbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzNF0sImVycm9yTWVzc2FnZSI6Ik1heGltdW0gb2YgNSBtaWxlc3RvbmVzIGFsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzkwXSwiZXJyb3JNZXNzYWdlIjoiTWlsZXN0b25lIGFscmVhZHkgY2xhaW1lZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NzhdLCJlcnJvck1lc3NhZ2UiOiJNaWxlc3RvbmUgbm90IGFwcHJvdmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA2MV0sImVycm9yTWVzc2FnZSI6Ik11c3QgZnVuZCB3aXRoIHBvc2l0aXZlIGFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1MF0sImVycm9yTWVzc2FnZSI6Ik11c3QgcGF5IGV4YWN0bHkgMiBBbGdvcyB0byBjcmVhdGUgYSBwcm9wb3NhbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNjhdLCJlcnJvck1lc3NhZ2UiOiJOb3QgYXV0aG9yaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MiwyMDcsMjM4LDI1MywyNjgsMjg2LDMwNCwzMjldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTMyXSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBzdWJtaXQgcHJvb2YiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjZdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgYmUgZnJvbSB0aGUgcHJvcG9zYWwgY3JlYXRvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1OCwxMDM0XSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBtdXN0IGJlIHNlbnQgdG8gdGhlIGNvbnRyYWN0IGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDU1XSwiZXJyb3JNZXNzYWdlIjoiUGF5bWVudCBtdXN0IGdvIHRvIGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUwMiwxNzU0XSwiZXJyb3JNZXNzYWdlIjoiUHJvb2YgaXMgbm90IHN1Ym1pdHRlZCB5ZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzYwXSwiZXJyb3JNZXNzYWdlIjoiUHJvb2Ygbm90IHN1Ym1pdHRlZCB5ZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NTVdLCJlcnJvck1lc3NhZ2UiOiJQcm9wb3NhbCBkZXNjcmlwdGlvbiBjYW5ub3QgYmUgZW1wdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OTgsMTExOCwxMzY3LDE2NzIsMTg4OF0sImVycm9yTWVzc2FnZSI6IlByb3Bvc2FsIGRvZXNuJ3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NDFdLCJlcnJvck1lc3NhZ2UiOiJQcm9wb3NhbCBuYW1lIGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0OF0sImVycm9yTWVzc2FnZSI6IlByb3Bvc2FsIHRpdGxlIGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MzldLCJlcnJvck1lc3NhZ2UiOiJTaG91bGQgaGF2ZSBkb25hdGVkIG1vcmUgdGhhbiAxIEFsZ28gdG8gdm90ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNDZdLCJlcnJvck1lc3NhZ2UiOiJUb28gZWFybHkgdG8gY2xhaW0iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MThdLCJlcnJvck1lc3NhZ2UiOiJUb3RhbCBtaWxlc3RvbmUgYW1vdW50IG11c3QgZXF1YWwgdGhlIHJlcXVpcmVkIGFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MTBdLCJlcnJvck1lc3NhZ2UiOiJWb3RpbmcgcGVyaW9kIGhhcyBlbmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3NjddLCJlcnJvck1lc3NhZ2UiOiJWb3RpbmcgcGVyaW9kIG5vdCBlbmRlZCB5ZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDY5XSwiZXJyb3JNZXNzYWdlIjoiWW91IGhhdmUgYWxyZWFkeSB2b3RlZCBmb3IgdGhpcyBtaWxlc3RvbmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTI0LDE5NzNdLCJlcnJvck1lc3NhZ2UiOiJZb3UgaGF2ZSBub3QgZG9uYXRlZCB0byB0aGlzIHByb3Bvc2FsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc0XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk1LDIxMCwyNDEsMjU2LDI3MSwyODksMzA3LDMzMl0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDk0LDE1MjYsMTk3OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZG9uYXRpb25zIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMjRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmZ1dHVyZUZ1bmRzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MzhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1pbGVzdG9uZVZvdGVzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNzRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm5vX29mX2Z1dHVyZV9mdW5kcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NzEsOTc2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ub19vZl9wcm9wb3NhbHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwNCwxMTI0LDEzNzMsMTYwOSwxNjc1LDE4MjMsMTg2NCwxODk0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wcm9wb3NhbHMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI5LDMyMCwzNjBdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Wm1ZdVkyOXVkSEpoWTNRdVVISnZjRzl6WVd4RGIyNTBjbUZqZEM1ZlgyRnNaMjl3ZVY5bGJuUnllWEJ2YVc1MFgzZHBkR2hmYVc1cGRDZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQWdNaUExTmlBeU9EZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3dNREF3TURBd01EQXdNREF3TURBd0lEQjRNREF3TUNBd2VEQXdJQ0p3Y205d2IzTmhiSE1pSUNKdWIwOW1VSEp2Y0c5ellXeHpJaUFpYm05UFprWjFkSFZ5WlVaMWJtUnpJaUF3ZURBd01ESWdJbTFwYkdWemRHOXVaVlp2ZEdWelh5SWdJbVJ2Ym1GMGFXOXVjeUlnSW1aMWRIVnlaVVoxYm1SZklnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qVTFMVFUyQ2lBZ0lDQXZMeUFqSUVOeWIzZGtablZ1WkdsdVp5QnpkR0YwWlFvZ0lDQWdMeThnYzJWc1ppNXViMTl2Wmw5d2NtOXdiM05oYkhNZ1BTQkhiRzlpWVd4VGRHRjBaU2hWU1c1ME5qUW9NQ2tzSUd0bGVUMGlibTlQWmxCeWIzQnZjMkZzY3lJcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKdWIwOW1VSEp2Y0c5ellXeHpJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TmpFdE5qSUtJQ0FnSUM4dklDTWdSblYwZFhKbElITmxiR1lnYzNSaGRHVUtJQ0FnSUM4dklITmxiR1l1Ym05ZmIyWmZablYwZFhKbFgyWjFibVJ6SUQwZ1IyeHZZbUZzVTNSaGRHVW9WVWx1ZERZMEtEQXBMQ0JyWlhrOUltNXZUMlpHZFhSMWNtVkdkVzVrY3lJcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKdWIwOW1SblYwZFhKbFJuVnVaSE1pQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPalV5TFRVekNpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTQkRiMjUwY21GamRDQXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklHTnNZWE56SUZCeWIzQnZjMkZzUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhNd29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFpoTlRBeFpUVTRJREI0T0RjMk56VTFaREFnTUhnMU5UWm1PREpqTXlBd2VEaGpOVEEzWmpFNElEQjRNamM1TkdRNU5qTWdNSGhsTmpRd05UbGtNU0F3ZUdVNU1USTRNakkySURCNE1qWTJPVFUyTnpjZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWZmNISnZjRzl6WVd3b2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkN3b2MzUnlhVzVuTEhWcGJuUTJOQ2xiWFN4d1lYa3BkbTlwWkNJc0lHMWxkR2h2WkNBaVpHOXVZWFJsWDNCeWIzQnZjMkZzS0hWcGJuUTJOQ3h3WVhrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzNWaWJXbDBYM0J5YjI5bUtIVnBiblEyTkN4emRISnBibWNwZG05cFpDSXNJRzFsZEdodlpDQWlkbTkwWlY5dGFXeGxjM1J2Ym1Vb2RXbHVkRFkwTEdKdmIyd3BkbTlwWkNJc0lHMWxkR2h2WkNBaVkyeGhhVzFmYldsc1pYTjBiMjVsS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaV1oxYm1SZmFXWmZhVzVoWTNScGRtVW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1aMWJtUmZablYwZFhKbFgzTmxiR1lvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5RMk5DeHdZWGtwZG05cFpDSXNJRzFsZEdodlpDQWlZMnhoYVcxZlpuVjBkWEpsWDNObGJHWW9kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMk55WldGMFpWOXdjbTl3YjNOaGJGOXliM1YwWlVBMUlHMWhhVzVmWkc5dVlYUmxYM0J5YjNCdmMyRnNYM0p2ZFhSbFFEWWdiV0ZwYmw5emRXSnRhWFJmY0hKdmIyWmZjbTkxZEdWQU55QnRZV2x1WDNadmRHVmZiV2xzWlhOMGIyNWxYM0p2ZFhSbFFEZ2diV0ZwYmw5amJHRnBiVjl0YVd4bGMzUnZibVZmY205MWRHVkFPU0J0WVdsdVgzSmxablZ1WkY5cFpsOXBibUZqZEdsMlpWOXliM1YwWlVBeE1DQnRZV2x1WDJaMWJtUmZablYwZFhKbFgzTmxiR1pmY205MWRHVkFNVEVnYldGcGJsOWpiR0ZwYlY5bWRYUjFjbVZmYzJWc1psOXliM1YwWlVBeE1nb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREUxT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qVXlMVFV6Q2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFNCRGIyNTBjbUZqZENBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUdOc1lYTnpJRkJ5YjNCdmMyRnNRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTJ4aGFXMWZablYwZFhKbFgzTmxiR1pmY205MWRHVkFNVEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1qZzJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pVeUxUVXpDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMU0JEYjI1MGNtRmpkQ0F0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJR05zWVhOeklGQnliM0J2YzJGc1EyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveU9EWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCamJHRnBiVjltZFhSMWNtVmZjMlZzWmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDltZFc1a1gyWjFkSFZ5WlY5elpXeG1YM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pJMk1pMHlOak1LSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0SUVaMWRIVnlaU0JUWld4bUlFMWxkR2h2WkhNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPalV5TFRVekNpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTQkRiMjUwY21GamRDQXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklHTnNZWE56SUZCeWIzQnZjMkZzUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qSTJNaTB5TmpNS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdElFWjFkSFZ5WlNCVFpXeG1JRTFsZEdodlpITWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1puVnVaRjltZFhSMWNtVmZjMlZzWmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl5WldaMWJtUmZhV1pmYVc1aFkzUnBkbVZmY205MWRHVkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1qTTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pVeUxUVXpDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMU0JEYjI1MGNtRmpkQ0F0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJR05zWVhOeklGQnliM0J2YzJGc1EyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveU16Z0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCeVpXWjFibVJmYVdaZmFXNWhZM1JwZG1VS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTJ4aGFXMWZiV2xzWlhOMGIyNWxYM0p2ZFhSbFFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TWpFekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPalV5TFRVekNpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTQkRiMjUwY21GamRDQXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklHTnNZWE56SUZCeWIzQnZjMkZzUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG95TVRNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJqYkdGcGJWOXRhV3hsYzNSdmJtVUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRtOTBaVjl0YVd4bGMzUnZibVZmY205MWRHVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveE9EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TlRJdE5UTUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRJRU52Ym5SeVlXTjBJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdZMnhoYzNNZ1VISnZjRzl6WVd4RGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pFNE1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUhadmRHVmZiV2xzWlhOMGIyNWxDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzTjFZbTFwZEY5d2NtOXZabDl5YjNWMFpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pFMU1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG8xTWkwMU13b2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMGdRMjl1ZEhKaFkzUWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QmpiR0Z6Y3lCUWNtOXdiM05oYkVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TVRVeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnYzNWaWJXbDBYM0J5YjI5bUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJSdmJtRjBaVjl3Y205d2IzTmhiRjl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pFeU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG8xTWkwMU13b2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMGdRMjl1ZEhKaFkzUWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QmpiR0Z6Y3lCUWNtOXdiM05oYkVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3hNamtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQmtiMjVoZEdWZmNISnZjRzl6WVd3S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTNKbFlYUmxYM0J5YjNCdmMyRnNYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TmpZdE5qY0tJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRJRU55YjNka1puVnVaR2x1WnlCTlpYUm9iMlJ6SUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUbzFNaTAxTXdvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwZ1EyOXVkSEpoWTNRZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCamJHRnpjeUJRY205d2IzTmhiRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRvMk5pMDJOd29nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBnUTNKdmQyUm1kVzVrYVc1bklFMWxkR2h2WkhNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnWTNKbFlYUmxYM0J5YjNCdmMyRnNDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUbzFNaTAxTXdvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwZ1EyOXVkSEpoWTNRZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlCamJHRnpjeUJRY205d2IzTmhiRU52Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREUxQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklGOXdkWGxoWDJ4cFlpNWhjbU0wTG1SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZENoaGNuSmhlVjlwZEdWdGMxOWpiM1Z1ZERvZ2RXbHVkRFkwTENCaGNuSmhlVjlvWldGa1gyRnVaRjkwWVdsc09pQmllWFJsY3l3Z2JtVjNYMmwwWlcxelgyTnZkVzUwT2lCMWFXNTBOalFzSUc1bGQxOW9aV0ZrWDJGdVpGOTBZV2xzT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZERvS0lDQWdJSEJ5YjNSdklEUWdNUW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ29LSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2dwa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5SZlptOXlYMmhsWVdSbGNrQXhPZ29nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0E4Q2lBZ0lDQmllaUJrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5a2VXNWhiV2xqWDJWc1pXMWxiblJmWVdaMFpYSmZabTl5UURRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDaUFnSUNCaUlHUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOW1iM0pmYUdWaFpHVnlRREVLQ21SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5aFpuUmxjbDltYjNKQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYkdWdUNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFFLQ21SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5bWIzSmZhR1ZoWkdWeVFEVTZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJRHdLSUNBZ0lHSjZJR1I1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJSNWJtRnRhV05mWld4bGJXVnVkRjloWm5SbGNsOW1iM0pBT0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEUUtJQ0FnSUdJZ1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyWnZjbDlvWldGa1pYSkFOUW9LWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlpIbHVZVzFwWTE5bGJHVnRaVzUwWDJGbWRHVnlYMlp2Y2tBNE9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdYM0IxZVdGZmJHbGlMbUZ5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVjl5WlhCc1lXTmxYMlI1Ym1GdGFXTmZaV3hsYldWdWRDaHpiM1Z5WTJVNklHSjVkR1Z6TENCdVpYZGZhWFJsYlRvZ1lubDBaWE1zSUdsdVpHVjRPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BrZVc1aGJXbGpYMkZ5Y21GNVgzSmxjR3hoWTJWZlpIbHVZVzFwWTE5bGJHVnRaVzUwT2dvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUhOMVluTjBjbWx1WnlBd0lESUtJQ0FnSUdSMWNBb2dJQ0FnWW5SdmFRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUEwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmthV2NnTVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ013b2dJQ0FnTFFvZ0lDQWdZMjkyWlhJZ05Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JzWlc0S0lDQWdJR052ZG1WeUlEVUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29LWkhsdVlXMXBZMTloY25KaGVWOXlaWEJzWVdObFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJRHdLSUNBZ0lHSjZJR1I1Ym1GdGFXTmZZWEp5WVhsZmNtVndiR0ZqWlY5a2VXNWhiV2xqWDJWc1pXMWxiblJmWVdaMFpYSmZabTl5UURVS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJR1p5WVcxbFgySjFjbmtnTkFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWWlCa2VXNWhiV2xqWDJGeWNtRjVYM0psY0d4aFkyVmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyWnZjbDlvWldGa1pYSkFNZ29LWkhsdVlXMXBZMTloY25KaGVWOXlaWEJzWVdObFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5aFpuUmxjbDltYjNKQU5Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVtWmk1amIyNTBjbUZqZEM1UWNtOXdiM05oYkVOdmJuUnlZV04wTG1OeVpXRjBaVjl3Y205d2IzTmhiQ2h1WVcxbE9pQmllWFJsY3l3Z2RHbDBiR1U2SUdKNWRHVnpMQ0JrWlhOamNtbHdkR2x2YmpvZ1lubDBaWE1zSUdOaGRHVm5iM0o1T2lCaWVYUmxjeXdnWVcxdmRXNTBYM0psY1hWcGNtVmtPaUJpZVhSbGN5d2diV2xzWlhOMGIyNWxjem9nWW5sMFpYTXNJSEJoZVcxbGJuUTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZM0psWVhSbFgzQnliM0J2YzJGc09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPalkyTFRjM0NpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTQkRjbTkzWkdaMWJtUnBibWNnVFdWMGFHOWtjeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzBLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHTnlaV0YwWlY5d2NtOXdiM05oYkNnS0lDQWdJQzh2SUNBZ0lDQnpaV3htTEFvZ0lDQWdMeThnSUNBZ0lHNWhiV1U2SUZOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMGFYUnNaVG9nVTNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUdSbGMyTnlhWEIwYVc5dU9pQlRkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdZMkYwWldkdmNuazZJRk4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUmZjbVZ4ZFdseVpXUTZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0J0YVd4bGMzUnZibVZ6T2lCRWVXNWhiV2xqUVhKeVlYbGJUV2xzWlhOMGIyNWxTVzV3ZFhSZExBb2dJQ0FnTHk4Z0lDQWdJSEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSeVlXNXpZV04wYVc5dUNpQWdJQ0F2THlBcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QTNJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRvM09Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1WVcxdmRXNTBJRDA5SURKZk1EQXdYekF3TUN3Z0lrMTFjM1FnY0dGNUlHVjRZV04wYkhrZ01pQkJiR2R2Y3lCMGJ5QmpjbVZoZEdVZ1lTQndjbTl3YjNOaGJDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0J3ZFhOb2FXNTBJREl3TURBd01EQWdMeThnTWpBd01EQXdNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCTmRYTjBJSEJoZVNCbGVHRmpkR3g1SURJZ1FXeG5iM01nZEc4Z1kzSmxZWFJsSUdFZ2NISnZjRzl6WVd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUbzNPUW9nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzFsYm5RdWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d2dJbEJoZVcxbGJuUWdiWFZ6ZENCaVpTQnpaVzUwSUhSdklIUm9aU0JqYjI1MGNtRmpkQ0JoWkdSeVpYTnpJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1VHRjViV1Z1ZENCdGRYTjBJR0psSUhObGJuUWdkRzhnZEdobElHTnZiblJ5WVdOMElHRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUbzRNQW9nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzFsYm5RdWMyVnVaR1Z5SUQwOUlGUjRiaTV6Wlc1a1pYSXNJQ0pRWVhsdFpXNTBJRzExYzNRZ1ltVWdabkp2YlNCMGFHVWdjSEp2Y0c5ellXd2dZM0psWVhSdmNpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCbWNtOXRJSFJvWlNCd2NtOXdiM05oYkNCamNtVmhkRzl5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk9ESUtJQ0FnSUM4dklHbGtlQ0E5SUhObGJHWXVibTlmYjJaZmNISnZjRzl6WVd4ekxuWmhiSFZsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlibTlQWmxCeWIzQnZjMkZzY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXViMTl2Wmw5d2NtOXdiM05oYkhNZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk9ETUtJQ0FnSUM4dklHWnBibUZzWDIxcGJHVnpkRzl1WlhNZ1BTQkVlVzVoYldsalFYSnlZWGxiVFdsc1pYTjBiMjVsWFNncENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pnMENpQWdJQ0F2THlCdGFXeGxjM1J2Ym1WelgzUnZkR0ZzSUQwZ1RtRjBhWFpsVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pnMkNpQWdJQ0F2THlCbWIzSWdhVzVrWlhnZ2FXNGdkWEpoYm1kbEtHMXBiR1Z6ZEc5dVpYTXViR1Z1WjNSb0tUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvS1kzSmxZWFJsWDNCeWIzQnZjMkZzWDJadmNsOW9aV0ZrWlhKQU1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG80TmdvZ0lDQWdMeThnWm05eUlHbHVaR1Y0SUdsdUlIVnlZVzVuWlNodGFXeGxjM1J2Ym1WekxteGxibWQwYUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lEd0tJQ0FnSUdKNklHTnlaV0YwWlY5d2NtOXdiM05oYkY5aFpuUmxjbDltYjNKQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPamczQ2lBZ0lDQXZMeUJ0YVd4bGMzUnZibVVnUFNCdGFXeGxjM1J2Ym1WelcybHVaR1Y0WFM1amIzQjVLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1pHbG5JREVLSUNBZ0lDMGdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk9Ea0tJQ0FnSUM4dklHNWhiV1U5Yldsc1pYTjBiMjVsTG01aGJXVXNDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG81TUFvZ0lDQWdMeThnWVcxdmRXNTBQVzFwYkdWemRHOXVaUzVoYlc5MWJuUXNDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBeUlEZ2dMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZPRGd0T1RnS0lDQWdJQzh2SUdacGJtRnNYMjFwYkdWemRHOXVaWE11WVhCd1pXNWtLRTFwYkdWemRHOXVaU2dLSUNBZ0lDOHZJQ0FnSUNCdVlXMWxQVzFwYkdWemRHOXVaUzV1WVcxbExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXRhV3hsYzNSdmJtVXVZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjI5bVgyeHBibXM5VTNSeWFXNW5LQ0lpS1N3S0lDQWdJQzh2SUNBZ0lDQjJiM1JsYzE5bWIzSTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUhadmRHVnpYMkZuWVdsdWMzUTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNYM1p2ZEdWeWN6MVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWTJ4aGFXMWxaRDFDYjI5c0tFWmhiSE5sS1N3S0lDQWdJQzh2SUNBZ0lDQndjbTl2Wmw5emRXSnRhWFIwWldSZmRHbHRaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RtOTBhVzVuWDJWdVpGOTBhVzFsUFZWSmJuUTJOQ2d3S1FvZ0lDQWdMeThnS1NrS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOVE1nTHk4Z05UTUtJQ0FnSUNzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd016VUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZPVElLSUNBZ0lDOHZJSFp2ZEdWelgyWnZjajFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pnNExUazRDaUFnSUNBdkx5Qm1hVzVoYkY5dGFXeGxjM1J2Ym1WekxtRndjR1Z1WkNoTmFXeGxjM1J2Ym1Vb0NpQWdJQ0F2THlBZ0lDQWdibUZ0WlQxdGFXeGxjM1J2Ym1VdWJtRnRaU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5Yldsc1pYTjBiMjVsTG1GdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCd2NtOXZabDlzYVc1clBWTjBjbWx1WnlnaUlpa3NDaUFnSUNBdkx5QWdJQ0FnZG05MFpYTmZabTl5UFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjJiM1JsYzE5aFoyRnBibk4wUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5MmIzUmxjbk05VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHTnNZV2x0WldROVFtOXZiQ2hHWVd4elpTa3NDaUFnSUNBdkx5QWdJQ0FnY0hKdmIyWmZjM1ZpYldsMGRHVmtYM1JwYldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSFp2ZEdsdVoxOWxibVJmZEdsdFpUMVZTVzUwTmpRb01Da0tJQ0FnSUM4dklDa3BDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRvNU13b2dJQ0FnTHk4Z2RtOTBaWE5mWVdkaGFXNXpkRDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pnNExUazRDaUFnSUNBdkx5Qm1hVzVoYkY5dGFXeGxjM1J2Ym1WekxtRndjR1Z1WkNoTmFXeGxjM1J2Ym1Vb0NpQWdJQ0F2THlBZ0lDQWdibUZ0WlQxdGFXeGxjM1J2Ym1VdWJtRnRaU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5Yldsc1pYTjBiMjVsTG1GdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCd2NtOXZabDlzYVc1clBWTjBjbWx1WnlnaUlpa3NDaUFnSUNBdkx5QWdJQ0FnZG05MFpYTmZabTl5UFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjJiM1JsYzE5aFoyRnBibk4wUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5MmIzUmxjbk05VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHTnNZV2x0WldROVFtOXZiQ2hHWVd4elpTa3NDaUFnSUNBdkx5QWdJQ0FnY0hKdmIyWmZjM1ZpYldsMGRHVmtYM1JwYldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSFp2ZEdsdVoxOWxibVJmZEdsdFpUMVZTVzUwTmpRb01Da0tJQ0FnSUM4dklDa3BDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRvNU5Bb2dJQ0FnTHk4Z2RHOTBZV3hmZG05MFpYSnpQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2T0RndE9UZ0tJQ0FnSUM4dklHWnBibUZzWDIxcGJHVnpkRzl1WlhNdVlYQndaVzVrS0UxcGJHVnpkRzl1WlNnS0lDQWdJQzh2SUNBZ0lDQnVZVzFsUFcxcGJHVnpkRzl1WlM1dVlXMWxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF0YVd4bGMzUnZibVV1WVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhCeWIyOW1YMnhwYm1zOVUzUnlhVzVuS0NJaUtTd0tJQ0FnSUM4dklDQWdJQ0IyYjNSbGMxOW1iM0k5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIWnZkR1Z6WDJGbllXbHVjM1E5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDNadmRHVnljejFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kyeGhhVzFsWkQxQ2IyOXNLRVpoYkhObEtTd0tJQ0FnSUM4dklDQWdJQ0J3Y205dlpsOXpkV0p0YVhSMFpXUmZkR2x0WlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdkbTkwYVc1blgyVnVaRjkwYVcxbFBWVkpiblEyTkNnd0tRb2dJQ0FnTHk4Z0tTa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2prMUNpQWdJQ0F2THlCamJHRnBiV1ZrUFVKdmIyd29SbUZzYzJVcExBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2T0RndE9UZ0tJQ0FnSUM4dklHWnBibUZzWDIxcGJHVnpkRzl1WlhNdVlYQndaVzVrS0UxcGJHVnpkRzl1WlNnS0lDQWdJQzh2SUNBZ0lDQnVZVzFsUFcxcGJHVnpkRzl1WlM1dVlXMWxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF0YVd4bGMzUnZibVV1WVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhCeWIyOW1YMnhwYm1zOVUzUnlhVzVuS0NJaUtTd0tJQ0FnSUM4dklDQWdJQ0IyYjNSbGMxOW1iM0k5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIWnZkR1Z6WDJGbllXbHVjM1E5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDNadmRHVnljejFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kyeGhhVzFsWkQxQ2IyOXNLRVpoYkhObEtTd0tJQ0FnSUM4dklDQWdJQ0J3Y205dlpsOXpkV0p0YVhSMFpXUmZkR2x0WlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdkbTkwYVc1blgyVnVaRjkwYVcxbFBWVkpiblEyTkNnd0tRb2dJQ0FnTHk4Z0tTa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2prMkNpQWdJQ0F2THlCd2NtOXZabDl6ZFdKdGFYUjBaV1JmZEdsdFpUMVZTVzUwTmpRb01Da3NDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPamc0TFRrNENpQWdJQ0F2THlCbWFXNWhiRjl0YVd4bGMzUnZibVZ6TG1Gd2NHVnVaQ2hOYVd4bGMzUnZibVVvQ2lBZ0lDQXZMeUFnSUNBZ2JtRnRaVDF0YVd4bGMzUnZibVV1Ym1GdFpTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTliV2xzWlhOMGIyNWxMbUZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J3Y205dlpsOXNhVzVyUFZOMGNtbHVaeWdpSWlrc0NpQWdJQ0F2THlBZ0lDQWdkbTkwWlhOZlptOXlQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCMmIzUmxjMTloWjJGcGJuTjBQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRjkyYjNSbGNuTTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lXbHRaV1E5UW05dmJDaEdZV3h6WlNrc0NpQWdJQ0F2THlBZ0lDQWdjSEp2YjJaZmMzVmliV2wwZEdWa1gzUnBiV1U5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIWnZkR2x1WjE5bGJtUmZkR2x0WlQxVlNXNTBOalFvTUNrS0lDQWdJQzh2SUNrcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG81TndvZ0lDQWdMeThnZG05MGFXNW5YMlZ1WkY5MGFXMWxQVlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG80T0MwNU9Bb2dJQ0FnTHk4Z1ptbHVZV3hmYldsc1pYTjBiMjVsY3k1aGNIQmxibVFvVFdsc1pYTjBiMjVsS0FvZ0lDQWdMeThnSUNBZ0lHNWhiV1U5Yldsc1pYTjBiMjVsTG01aGJXVXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQVzFwYkdWemRHOXVaUzVoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnY0hKdmIyWmZiR2x1YXoxVGRISnBibWNvSWlJcExBb2dJQ0FnTHk4Z0lDQWdJSFp2ZEdWelgyWnZjajFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RtOTBaWE5mWVdkaGFXNXpkRDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3hmZG05MFpYSnpQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCamJHRnBiV1ZrUFVKdmIyd29SbUZzYzJVcExBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjI5bVgzTjFZbTFwZEhSbFpGOTBhVzFsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQjJiM1JwYm1kZlpXNWtYM1JwYldVOVZVbHVkRFkwS0RBcENpQWdJQ0F2THlBcEtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRvNU1Rb2dJQ0FnTHk4Z2NISnZiMlpmYkdsdWF6MVRkSEpwYm1jb0lpSXBMQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUbzRPQzA1T0FvZ0lDQWdMeThnWm1sdVlXeGZiV2xzWlhOMGIyNWxjeTVoY0hCbGJtUW9UV2xzWlhOMGIyNWxLQW9nSUNBZ0x5OGdJQ0FnSUc1aGJXVTliV2xzWlhOMGIyNWxMbTVoYldVc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXMXBiR1Z6ZEc5dVpTNWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdjSEp2YjJaZmJHbHVhejFUZEhKcGJtY29JaUlwTEFvZ0lDQWdMeThnSUNBZ0lIWnZkR1Z6WDJadmNqMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZG05MFpYTmZZV2RoYVc1emREMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXeGZkbTkwWlhKelBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JqYkdGcGJXVmtQVUp2YjJ3b1JtRnNjMlVwTEFvZ0lDQWdMeThnSUNBZ0lIQnliMjltWDNOMVltMXBkSFJsWkY5MGFXMWxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCMmIzUnBibWRmWlc1a1gzUnBiV1U5VlVsdWREWTBLREFwQ2lBZ0lDQXZMeUFwS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1EQXdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEFvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk9Ua0tJQ0FnSUM4dklHMXBiR1Z6ZEc5dVpYTmZkRzkwWVd3Z1BTQnRhV3hsYzNSdmJtVnpYM1J2ZEdGc0lDc2diV2xzWlhOMGIyNWxMbUZ0YjNWdWRDNXVZWFJwZG1VS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnWWlCamNtVmhkR1ZmY0hKdmNHOXpZV3hmWm05eVgyaGxZV1JsY2tBeENncGpjbVZoZEdWZmNISnZjRzl6WVd4ZllXWjBaWEpmWm05eVFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TVRBeENpQWdJQ0F2THlCaGMzTmxjblFnWVcxdmRXNTBYM0psY1hWcGNtVmtJRDA5SUcxcGJHVnpkRzl1WlhOZmRHOTBZV3dzSUNKVWIzUmhiQ0J0YVd4bGMzUnZibVVnWVcxdmRXNTBJRzExYzNRZ1pYRjFZV3dnZEdobElISmxjWFZwY21Wa0lHRnRiM1Z1ZENJS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHSTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGUnZkR0ZzSUcxcGJHVnpkRzl1WlNCaGJXOTFiblFnYlhWemRDQmxjWFZoYkNCMGFHVWdjbVZ4ZFdseVpXUWdZVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNVEF5Q2lBZ0lDQXZMeUJoYzNObGNuUWdZVzF2ZFc1MFgzSmxjWFZwY21Wa0lENGdNQ3dnSWtGdGIzVnVkQ0J5WlhGMWFYSmxaQ0J0ZFhOMElHSmxJR2R5WldGMFpYSWdkR2hoYmlBd0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZajRLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiVzkxYm5RZ2NtVnhkV2x5WldRZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pFd013b2dJQ0FnTHk4Z1lYTnpaWEowSUdacGJtRnNYMjFwYkdWemRHOXVaWE11YkdWdVozUm9JRDRnTUN3Z0lrRjBJR3hsWVhOMElHOXVaU0J0YVd4bGMzUnZibVVnYVhNZ2NtVnhkV2x5WldRaUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklFRjBJR3hsWVhOMElHOXVaU0J0YVd4bGMzUnZibVVnYVhNZ2NtVnhkV2x5WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3hNRFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQm1hVzVoYkY5dGFXeGxjM1J2Ym1WekxteGxibWQwYUNBOFBTQTFMQ0FpVFdGNGFXMTFiU0J2WmlBMUlHMXBiR1Z6ZEc5dVpYTWdZV3hzYjNkbFpDSUtJQ0FnSUhCMWMyaHBiblFnTlNBdkx5QTFDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUUxaGVHbHRkVzBnYjJZZ05TQnRhV3hsYzNSdmJtVnpJR0ZzYkc5M1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG94TURVS0lDQWdJQzh2SUdGemMyVnlkQ0J1WVcxbExtNWhkR2wyWlM1aWVYUmxjeTVzWlc1bmRHZ2dQaUF3TENBaVVISnZjRzl6WVd3Z2JtRnRaU0JqWVc1dWIzUWdZbVVnWlcxd2RIa2lDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUY0tJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJRY205d2IzTmhiQ0J1WVcxbElHTmhibTV2ZENCaVpTQmxiWEIwZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qRXdOZ29nSUNBZ0x5OGdZWE56WlhKMElIUnBkR3hsTG01aGRHbDJaUzVpZVhSbGN5NXNaVzVuZEdnZ1BpQXdMQ0FpVUhKdmNHOXpZV3dnZEdsMGJHVWdZMkZ1Ym05MElHSmxJR1Z0Y0hSNUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMkNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdiR1Z1Q2lBZ0lDQmhjM05sY25RZ0x5OGdVSEp2Y0c5ellXd2dkR2wwYkdVZ1kyRnVibTkwSUdKbElHVnRjSFI1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1UQTNDaUFnSUNBdkx5QmhjM05sY25RZ1pHVnpZM0pwY0hScGIyNHVibUYwYVhabExtSjVkR1Z6TG14bGJtZDBhQ0ErSURBc0lDSlFjbTl3YjNOaGJDQmtaWE5qY21sd2RHbHZiaUJqWVc1dWIzUWdZbVVnWlcxd2RIa2lDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJRY205d2IzTmhiQ0JrWlhOamNtbHdkR2x2YmlCallXNXViM1FnWW1VZ1pXMXdkSGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveE1UVUtJQ0FnSUM4dklHTnlaV0YwWldSZlluazlRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG94TWpFS0lDQWdJQzh2SUdOeVpXRjBaV1JmWVhROVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLUW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pFd09TMHhNaklLSUNBZ0lDOHZJRzVsZDE5d2NtOXdiM05oYkNBOUlGQnliM0J2YzJGc0tBb2dJQ0FnTHk4Z0lDQWdJRzVoYldVOWJtRnRaU3dLSUNBZ0lDOHZJQ0FnSUNCMGFYUnNaVDEwYVhSc1pTd0tJQ0FnSUM4dklDQWdJQ0JrWlhOamNtbHdkR2x2Ymoxa1pYTmpjbWx3ZEdsdmJpd0tJQ0FnSUM4dklDQWdJQ0JqWVhSbFoyOXllVDFqWVhSbFoyOXllU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblJmY21WeGRXbHlaV1E5WVcxdmRXNTBYM0psY1hWcGNtVmtMQW9nSUNBZ0x5OGdJQ0FnSUdOeVpXRjBaV1JmWW5rOVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUmZjbUZwYzJWa1BWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J1YjE5dlpsOWtiMjVoZEdsdmJuTTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUc1dlgyOW1YM1Z1YVhGMVpWOWtiMjV2Y25NOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJRzFwYkdWemRHOXVaWE05Wm1sdVlXeGZiV2xzWlhOMGIyNWxjeTVqYjNCNUtDa3NDaUFnSUNBdkx5QWdJQ0FnWTNWeWNtVnVkRjl0YVd4bGMzUnZibVU5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTlWVWx1ZERZMEtFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3S1FvZ0lDQWdMeThnS1FvZ0lDQWdabkpoYldWZlpHbG5JQzAzQ2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09UQWdMeThnT1RBS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdOV0VLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzAyQ2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveE1UWUtJQ0FnSUM4dklHRnRiM1Z1ZEY5eVlXbHpaV1E5VlVsdWREWTBLREFwTEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveE1Ea3RNVEl5Q2lBZ0lDQXZMeUJ1WlhkZmNISnZjRzl6WVd3Z1BTQlFjbTl3YjNOaGJDZ0tJQ0FnSUM4dklDQWdJQ0J1WVcxbFBXNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2RHbDBiR1U5ZEdsMGJHVXNDaUFnSUNBdkx5QWdJQ0FnWkdWelkzSnBjSFJwYjI0OVpHVnpZM0pwY0hScGIyNHNDaUFnSUNBdkx5QWdJQ0FnWTJGMFpXZHZjbms5WTJGMFpXZHZjbmtzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwWDNKbGNYVnBjbVZrUFdGdGIzVnVkRjl5WlhGMWFYSmxaQ3dLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkR1ZrWDJKNVBVRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBYM0poYVhObFpEMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnYm05ZmIyWmZaRzl1WVhScGIyNXpQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCdWIxOXZabDkxYm1seGRXVmZaRzl1YjNKelBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J0YVd4bGMzUnZibVZ6UFdacGJtRnNYMjFwYkdWemRHOXVaWE11WTI5d2VTZ3BMQW9nSUNBZ0x5OGdJQ0FnSUdOMWNuSmxiblJmYldsc1pYTjBiMjVsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmpjbVZoZEdWa1gyRjBQVlZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NrS0lDQWdJQzh2SUNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPakV4TndvZ0lDQWdMeThnYm05ZmIyWmZaRzl1WVhScGIyNXpQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TVRBNUxURXlNZ29nSUNBZ0x5OGdibVYzWDNCeWIzQnZjMkZzSUQwZ1VISnZjRzl6WVd3b0NpQWdJQ0F2THlBZ0lDQWdibUZ0WlQxdVlXMWxMQW9nSUNBZ0x5OGdJQ0FnSUhScGRHeGxQWFJwZEd4bExBb2dJQ0FnTHk4Z0lDQWdJR1JsYzJOeWFYQjBhVzl1UFdSbGMyTnlhWEIwYVc5dUxBb2dJQ0FnTHk4Z0lDQWdJR05oZEdWbmIzSjVQV05oZEdWbmIzSjVMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRjl5WlhGMWFYSmxaRDFoYlc5MWJuUmZjbVZ4ZFdseVpXUXNDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUmxaRjlpZVQxQlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWRGOXlZV2x6WldROVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJRzV2WDI5bVgyUnZibUYwYVc5dWN6MVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnYm05ZmIyWmZkVzVwY1hWbFgyUnZibTl5Y3oxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdiV2xzWlhOMGIyNWxjejFtYVc1aGJGOXRhV3hsYzNSdmJtVnpMbU52Y0hrb0tTd0tJQ0FnSUM4dklDQWdJQ0JqZFhKeVpXNTBYMjFwYkdWemRHOXVaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJsWkY5aGREMVZTVzUwTmpRb1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3hNVGdLSUNBZ0lDOHZJRzV2WDI5bVgzVnVhWEYxWlY5a2IyNXZjbk05VlVsdWREWTBLREFwTEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveE1Ea3RNVEl5Q2lBZ0lDQXZMeUJ1WlhkZmNISnZjRzl6WVd3Z1BTQlFjbTl3YjNOaGJDZ0tJQ0FnSUM4dklDQWdJQ0J1WVcxbFBXNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2RHbDBiR1U5ZEdsMGJHVXNDaUFnSUNBdkx5QWdJQ0FnWkdWelkzSnBjSFJwYjI0OVpHVnpZM0pwY0hScGIyNHNDaUFnSUNBdkx5QWdJQ0FnWTJGMFpXZHZjbms5WTJGMFpXZHZjbmtzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwWDNKbGNYVnBjbVZrUFdGdGIzVnVkRjl5WlhGMWFYSmxaQ3dLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkR1ZrWDJKNVBVRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBYM0poYVhObFpEMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnYm05ZmIyWmZaRzl1WVhScGIyNXpQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCdWIxOXZabDkxYm1seGRXVmZaRzl1YjNKelBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J0YVd4bGMzUnZibVZ6UFdacGJtRnNYMjFwYkdWemRHOXVaWE11WTI5d2VTZ3BMQW9nSUNBZ0x5OGdJQ0FnSUdOMWNuSmxiblJmYldsc1pYTjBiMjVsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmpjbVZoZEdWa1gyRjBQVlZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NrS0lDQWdJQzh2SUNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPakV5TUFvZ0lDQWdMeThnWTNWeWNtVnVkRjl0YVd4bGMzUnZibVU5VlVsdWREWTBLREFwTEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveE1Ea3RNVEl5Q2lBZ0lDQXZMeUJ1WlhkZmNISnZjRzl6WVd3Z1BTQlFjbTl3YjNOaGJDZ0tJQ0FnSUM4dklDQWdJQ0J1WVcxbFBXNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2RHbDBiR1U5ZEdsMGJHVXNDaUFnSUNBdkx5QWdJQ0FnWkdWelkzSnBjSFJwYjI0OVpHVnpZM0pwY0hScGIyNHNDaUFnSUNBdkx5QWdJQ0FnWTJGMFpXZHZjbms5WTJGMFpXZHZjbmtzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwWDNKbGNYVnBjbVZrUFdGdGIzVnVkRjl5WlhGMWFYSmxaQ3dLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkR1ZrWDJKNVBVRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBYM0poYVhObFpEMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnYm05ZmIyWmZaRzl1WVhScGIyNXpQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCdWIxOXZabDkxYm1seGRXVmZaRzl1YjNKelBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0J0YVd4bGMzUnZibVZ6UFdacGJtRnNYMjFwYkdWemRHOXVaWE11WTI5d2VTZ3BMQW9nSUNBZ0x5OGdJQ0FnSUdOMWNuSmxiblJmYldsc1pYTjBiMjVsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmpjbVZoZEdWa1gyRjBQVlZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NrS0lDQWdJQzh2SUNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDJDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNVEkwQ2lBZ0lDQXZMeUJ6Wld4bUxuQnliM0J2YzJGc2MxdHBaSGhkSUQwZ2JtVjNYM0J5YjNCdmMyRnNMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNISnZjRzl6WVd4eklnb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qRXlOUW9nSUNBZ0x5OGdjMlZzWmk1dGFXeGxjM1J2Ym1WV2IzUmxjMXRwWkhoZElEMGdSSGx1WVcxcFkwRnljbUY1VzBGa1pISmxjM05kS0NrS0lDQWdJR0o1ZEdWaklEY2dMeThnSW0xcGJHVnpkRzl1WlZadmRHVnpYeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1USTJDaUFnSUNBdkx5QnpaV3htTG01dlgyOW1YM0J5YjNCdmMyRnNjeTUyWVd4MVpTQTlJRlZKYm5RMk5DaHpaV3htTG01dlgyOW1YM0J5YjNCdmMyRnNjeTUyWVd4MVpTNXVZWFJwZG1VZ0t5QXhLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltNXZUMlpRY205d2IzTmhiSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJtOWZiMlpmY0hKdmNHOXpZV3h6SUdWNGFYTjBjd29nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklEUWdMeThnSW01dlQyWlFjbTl3YjNOaGJITWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtWm1MbU52Ym5SeVlXTjBMbEJ5YjNCdmMyRnNRMjl1ZEhKaFkzUXVaRzl1WVhSbFgzQnliM0J2YzJGc0tIQnliM0J2YzJGc1gybGtPaUJpZVhSbGN5d2djR0Y1YldWdWREb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGtiMjVoZEdWZmNISnZjRzl6WVd3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNVEk1TFRFek1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnWkc5dVlYUmxYM0J5YjNCdmMyRnNLSE5sYkdZc0lIQnliM0J2YzJGc1gybGtPaUJWU1c1ME5qUXNJSEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSeVlXNXpZV04wYVc5dUtTQXRQaUJPYjI1bE9nb2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1UTXhDaUFnSUNBdkx5QmhjM05sY25RZ2NISnZjRzl6WVd4ZmFXUWdhVzRnYzJWc1ppNXdjbTl3YjNOaGJITXNJQ0pRY205d2IzTmhiQ0JrYjJWemJpZDBJR1Y0YVhOMElnb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNISnZjRzl6WVd4eklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVUhKdmNHOXpZV3dnWkc5bGMyNG5kQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPakV6TWdvZ0lDQWdMeThnY0hKdmNDQTlJSE5sYkdZdWNISnZjRzl6WVd4elczQnliM0J2YzJGc1gybGtYUzVqYjNCNUtDa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2NtOXdiM05oYkhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TVRNekNpQWdJQ0F2THlCaGMzTmxjblFnY0hKdmNDNWhiVzkxYm5SZmNtRnBjMlZrSUR3Z2NISnZjQzVoYlc5MWJuUmZjbVZ4ZFdseVpXUXNJQ0pIYjJGc0lHRnNjbVZoWkhrZ2NtVmhZMmhsWkNJS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBPQ0E0SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBNElEZ2dMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpUEFvZ0lDQWdZWE56WlhKMElDOHZJRWR2WVd3Z1lXeHlaV0ZrZVNCeVpXRmphR1ZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1UTTFDaUFnSUNBdkx5QmhiVzkxYm5RZ1BTQndZWGx0Wlc1MExtRnRiM1Z1ZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveE16WUtJQ0FnSUM4dklHUnZibTl5SUQwZ2NHRjViV1Z1ZEM1elpXNWtaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TVRNM0NpQWdJQ0F2THlCa2IyNWhkR2x2Ymw5aWIzaGZhMlY1SUQwZ1JHOXVZWFJwYjI1Q2IzaExaWGtvY0hKdmNHOXpZV3hmYVdROWNISnZjRzl6WVd4ZmFXUXNJR1J2Ym05eVBVRmtaSEpsYzNNb1pHOXViM0lwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3hNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNJQ0pRWVhsdFpXNTBJRzExYzNRZ1ltVWdjMlZ1ZENCMGJ5QjBhR1VnWTI5dWRISmhZM1FnWVdSa2NtVnpjeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCelpXNTBJSFJ2SUhSb1pTQmpiMjUwY21GamRDQmhaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNVFF3Q2lBZ0lDQXZMeUJwWmlCa2IyNWhkR2x2Ymw5aWIzaGZhMlY1SUc1dmRDQnBiaUJ6Wld4bUxtUnZibUYwYVc5dWN6b0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltUnZibUYwYVc5dWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCa2IyNWhkR1ZmY0hKdmNHOXpZV3hmWld4elpWOWliMlI1UURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3hOREVLSUNBZ0lDOHZJSEJ5YjNBdWJtOWZiMlpmZFc1cGNYVmxYMlJ2Ym05eWN5QTlJRlZKYm5RMk5DaHdjbTl3TG01dlgyOW1YM1Z1YVhGMVpWOWtiMjV2Y25NdWJtRjBhWFpsSUNzZ01Ta0tJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOallnTHk4Z05qWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdOallLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pFME1nb2dJQ0FnTHk4Z2MyVnNaaTVrYjI1aGRHbHZibk5iWkc5dVlYUnBiMjVmWW05NFgydGxlVjBnUFNCVlNXNTBOalFvWVcxdmRXNTBLUW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOXdkWFFLQ21SdmJtRjBaVjl3Y205d2IzTmhiRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TVRRMkNpQWdJQ0F2THlCd2NtOXdMbTV2WDI5bVgyUnZibUYwYVc5dWN5QTlJRlZKYm5RMk5DaHdjbTl3TG01dlgyOW1YMlJ2Ym1GMGFXOXVjeTV1WVhScGRtVWdLeUF4S1FvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBMU9DQXZMeUExT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBMU9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPakUwTndvZ0lDQWdMeThnY0hKdmNDNWhiVzkxYm5SZmNtRnBjMlZrSUQwZ1ZVbHVkRFkwS0hCeWIzQXVZVzF2ZFc1MFgzSmhhWE5sWkM1dVlYUnBkbVVnS3lCaGJXOTFiblFwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05EZ2dMeThnTkRnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ05EZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG94TkRnS0lDQWdJQzh2SUhObGJHWXVjSEp2Y0c5ellXeHpXM0J5YjNCdmMyRnNYMmxrWFNBOUlIQnliM0F1WTI5d2VTZ3BDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS1pHOXVZWFJsWDNCeWIzQnZjMkZzWDJWc2MyVmZZbTlrZVVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPakUwTkFvZ0lDQWdMeThnYzJWc1ppNWtiMjVoZEdsdmJuTmJaRzl1WVhScGIyNWZZbTk0WDJ0bGVWMGdQU0JWU1c1ME5qUW9jMlZzWmk1a2IyNWhkR2x2Ym5OYlpHOXVZWFJwYjI1ZlltOTRYMnRsZVYwdWJtRjBhWFpsSUNzZ1lXMXZkVzUwS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1a2IyNWhkR2x2Ym5NZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCaWRHOXBDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnWWlCa2IyNWhkR1ZmY0hKdmNHOXpZV3hmWVdaMFpYSmZhV1pmWld4elpVQXpDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1abUxtTnZiblJ5WVdOMExsQnliM0J2YzJGc1EyOXVkSEpoWTNRdWMzVmliV2wwWDNCeWIyOW1LSEJ5YjNCdmMyRnNYMmxrT2lCaWVYUmxjeXdnY0hKdmIyWmZiR2x1YXpvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q25OMVltMXBkRjl3Y205dlpqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG94TlRFdE1UVXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCemRXSnRhWFJmY0hKdmIyWW9jMlZzWml3Z2NISnZjRzl6WVd4ZmFXUTZJRlZKYm5RMk5Dd2djSEp2YjJaZmJHbHVhem9nVTNSeWFXNW5LU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3hOVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQndjbTl3YjNOaGJGOXBaQ0JwYmlCelpXeG1MbkJ5YjNCdmMyRnNjeXdnSWxCeWIzQnZjMkZzSUdSdlpYTnVKM1FnWlhocGMzUWlDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndjbTl3YjNOaGJITWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCUWNtOXdiM05oYkNCa2IyVnpiaWQwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TVRVMENpQWdJQ0F2THlCd2NtOXdJRDBnYzJWc1ppNXdjbTl3YjNOaGJITmJjSEp2Y0c5ellXeGZhV1JkTG1OdmNIa29LUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQnliM0J2YzJGc2N5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveE5UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCd2NtOXdMbU55WldGMFpXUmZZbmtnUFQwZ1FXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd2dJazl1YkhrZ1kzSmxZWFJ2Y2lCallXNGdjM1ZpYldsMElIQnliMjltSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElERTJJRE15SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHTnlaV0YwYjNJZ1kyRnVJSE4xWW0xcGRDQndjbTl2WmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qRTFOZ29nSUNBZ0x5OGdZWE56WlhKMElIQnliM0F1WVcxdmRXNTBYM0poYVhObFpDQStQU0J3Y205d0xtRnRiM1Z1ZEY5eVpYRjFhWEpsWkN3Z0lrZHZZV3dnYm05MElISmxZV05vWldRZ2VXVjBJZ29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURRNElEZ2dMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0E0SURnZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkhiMkZzSUc1dmRDQnlaV0ZqYUdWa0lIbGxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pFMU53b2dJQ0FnTHk4Z1lYTnpaWEowSUhCeWIzQXVZM1Z5Y21WdWRGOXRhV3hsYzNSdmJtVXVibUYwYVhabElEd2djSEp2Y0M1dGFXeGxjM1J2Ym1WekxteGxibWQwYUN3Z0lrRnNiQ0J0YVd4bGMzUnZibVZ6SUdGc2NtVmhaSGtnWTI5dGNHeGxkR1ZrSWdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEYzBJQzh2SURjMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklEVTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnUEFvZ0lDQWdZWE56WlhKMElDOHZJRUZzYkNCdGFXeGxjM1J2Ym1WeklHRnNjbVZoWkhrZ1kyOXRjR3hsZEdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNVFU1Q2lBZ0lDQXZMeUJqZFhKeVpXNTBYM1JwYldVZ1BTQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qRTJNQW9nSUNBZ0x5OGdibVYzWDIxcGJHVnpkRzl1WlhNZ1BTQkVlVzVoYldsalFYSnlZWGxiVFdsc1pYTjBiMjVsWFNncENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pFMk1Rb2dJQ0FnTHk4Z1ptOXlJR2xrZUNCcGJpQjFjbUZ1WjJVb2NISnZjQzV0YVd4bGMzUnZibVZ6TG14bGJtZDBhQ2s2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9LYzNWaWJXbDBYM0J5YjI5bVgyWnZjbDlvWldGa1pYSkFNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveE5qRUtJQ0FnSUM4dklHWnZjaUJwWkhnZ2FXNGdkWEpoYm1kbEtIQnliM0F1Yldsc1pYTjBiMjVsY3k1c1pXNW5kR2dwT2dvZ0lDQWdabkpoYldWZlpHbG5JRGtLSUNBZ0lHWnlZVzFsWDJScFp5QTJDaUFnSUNBOENpQWdJQ0JpZWlCemRXSnRhWFJmY0hKdmIyWmZZV1owWlhKZlptOXlRRGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveE5qSUtJQ0FnSUM4dklHMXBiR1Z6ZEc5dVpTQTlJSEJ5YjNBdWJXbHNaWE4wYjI1bGMxdHBaSGhkTG1OdmNIa29LUW9nSUNBZ1puSmhiV1ZmWkdsbklEVUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnT1FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JtY21GdFpWOWthV2NnTmdvZ0lDQWdaR2xuSURFS0lDQWdJQzBnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCa2FXY2dOQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNVFl6Q2lBZ0lDQXZMeUJwWmlCcFpIZ2dQVDBnY0hKdmNDNWpkWEp5Wlc1MFgyMXBiR1Z6ZEc5dVpTNXVZWFJwZG1VNkNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdQVDBLSUNBZ0lHSjZJSE4xWW0xcGRGOXdjbTl2Wmw5bGJITmxYMkp2WkhsQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPakUyTkFvZ0lDQWdMeThnYldsc1pYTjBiMjVsTG5CeWIyOW1YMnhwYm1zZ1BTQndjbTl2Wmw5c2FXNXJDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRBZ0x5OGdNVEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNVFkxQ2lBZ0lDQXZMeUJ0YVd4bGMzUnZibVV1Y0hKdmIyWmZjM1ZpYldsMGRHVmtYM1JwYldVZ1BTQlZTVzUwTmpRb1kzVnljbVZ1ZEY5MGFXMWxLUW9nSUNBZ1puSmhiV1ZmWkdsbklEY0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ016Y0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG94TmpZS0lDQWdJQzh2SUcxcGJHVnpkRzl1WlM1MmIzUnBibWRmWlc1a1gzUnBiV1VnUFNCVlNXNTBOalFvWTNWeWNtVnVkRjkwYVcxbElDc2dkbTkwYVc1blgzUnBiV1VwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElERTRNQ0F2THlBeE9EQUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJRFExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1UWTNDaUFnSUNBdkx5QnRhV3hsYzNSdmJtVXVZMnhoYVcxbFpDQTlJRUp2YjJ3b1JtRnNjMlVwQ2lBZ0lDQnBiblJqSURRZ0x5OGdNamc0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1UWTRDaUFnSUNBdkx5QnRhV3hsYzNSdmJtVXVkbTkwWlhOZlptOXlJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2NtVndiR0ZqWlRJZ01USUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG94TmprS0lDQWdJQzh2SUcxcGJHVnpkRzl1WlM1MmIzUmxjMTloWjJGcGJuTjBJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2NtVndiR0ZqWlRJZ01qQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG94TnpBS0lDQWdJQzh2SUcxcGJHVnpkRzl1WlM1MGIzUmhiRjkyYjNSbGNuTWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCeVpYQnNZV05sTWlBeU9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPakUzTVFvZ0lDQWdMeThnYm1WM1gyMXBiR1Z6ZEc5dVpYTXVZWEJ3Wlc1a0tHMXBiR1Z6ZEc5dVpTNWpiM0I1S0NrcENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1EQXdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dPQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEFvZ0lDQWdabkpoYldWZlluVnllU0E0Q2dwemRXSnRhWFJmY0hKdmIyWmZZV1owWlhKZmFXWmZaV3h6WlVBMU9nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1p5WVcxbFgySjFjbmtnT1FvZ0lDQWdZaUJ6ZFdKdGFYUmZjSEp2YjJaZlptOXlYMmhsWVdSbGNrQXhDZ3B6ZFdKdGFYUmZjSEp2YjJaZlpXeHpaVjlpYjJSNVFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TVRjekNpQWdJQ0F2THlCdVpYZGZiV2xzWlhOMGIyNWxjeTVoY0hCbGJtUW9iV2xzWlhOMGIyNWxMbU52Y0hrb0tTa0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3dNREF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUE0Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTmhiR3h6ZFdJZ1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MENpQWdJQ0JtY21GdFpWOWlkWEo1SURnS0lDQWdJR0lnYzNWaWJXbDBYM0J5YjI5bVgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvS2MzVmliV2wwWDNCeWIyOW1YMkZtZEdWeVgyWnZja0EzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qRTNOUW9nSUNBZ0x5OGdjSEp2Y0M1dGFXeGxjM1J2Ym1WeklEMGdibVYzWDIxcGJHVnpkRzl1WlhNdVkyOXdlU2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1puSmhiV1ZmWkdsbklEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pFM05nb2dJQ0FnTHk4Z2MyVnNaaTV3Y205d2IzTmhiSE5iY0hKdmNHOXpZV3hmYVdSZElEMGdjSEp2Y0M1amIzQjVLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qRTNOd29nSUNBZ0x5OGdjMlZzWmk1dGFXeGxjM1J2Ym1WV2IzUmxjMXR3Y205d2IzTmhiRjlwWkYwZ1BTQkVlVzVoYldsalFYSnlZWGxiUVdSa2NtVnpjMTBvS1FvZ0lDQWdZbmwwWldNZ055QXZMeUFpYldsc1pYTjBiMjVsVm05MFpYTmZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01Bb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtWm1MbU52Ym5SeVlXTjBMbEJ5YjNCdmMyRnNRMjl1ZEhKaFkzUXVkbTkwWlY5dGFXeGxjM1J2Ym1Vb2NISnZjRzl6WVd4ZmFXUTZJR0o1ZEdWekxDQjJiM1JsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZG05MFpWOXRhV3hsYzNSdmJtVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TVRnd0xURTRNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ2RtOTBaVjl0YVd4bGMzUnZibVVvYzJWc1ppd2djSEp2Y0c5ellXeGZhV1E2SUZWSmJuUTJOQ3dnZG05MFpUb2dRbTl2YkNrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pFNE1nb2dJQ0FnTHk4Z1lYTnpaWEowSUhCeWIzQnZjMkZzWDJsa0lHbHVJSE5sYkdZdWNISnZjRzl6WVd4ekxDQWlVSEp2Y0c5ellXd2daRzlsYzI0bmRDQmxlR2x6ZENJS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5CeWIzQnZjMkZzY3lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRkJ5YjNCdmMyRnNJR1J2WlhOdUozUWdaWGhwYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3hPRE1LSUNBZ0lDOHZJSEJ5YjNBZ1BTQnpaV3htTG5CeWIzQnZjMkZzYzF0d2NtOXdiM05oYkY5cFpGMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0hKdmNHOXpZV3h6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPakU0TkFvZ0lDQWdMeThnYldsc1pYTjBiMjVsSUQwZ2NISnZjQzV0YVd4bGMzUnZibVZ6VzNCeWIzQXVZM1Z5Y21WdWRGOXRhV3hsYzNSdmJtVXVibUYwYVhabFhTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTNOQ0F2THlBM05Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QTFOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUMwZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TVRnMkNpQWdJQ0F2THlCdGFXeGxjM1J2Ym1WZmRtOTBaWE1nUFNCelpXeG1MbTFwYkdWemRHOXVaVlp2ZEdWelczQnliM0J2YzJGc1gybGtYUzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z0ltMXBiR1Z6ZEc5dVpWWnZkR1Z6WHlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0YVd4bGMzUnZibVZXYjNSbGN5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveE9EY0tJQ0FnSUM4dklHWnZjaUJoWkdSeUlHbHVJRzFwYkdWemRHOXVaVjkyYjNSbGN6b0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0NuWnZkR1ZmYldsc1pYTjBiMjVsWDJadmNsOW9aV0ZrWlhKQU1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG94T0RjS0lDQWdJQzh2SUdadmNpQmhaR1J5SUdsdUlHMXBiR1Z6ZEc5dVpWOTJiM1JsY3pvS0lDQWdJR1p5WVcxbFgyUnBaeUEzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOZ29nSUNBZ1BBb2dJQ0FnWW5vZ2RtOTBaVjl0YVd4bGMzUnZibVZmWVdaMFpYSmZabTl5UURRS0lDQWdJR1p5WVcxbFgyUnBaeUExQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklEY0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNVGc0Q2lBZ0lDQXZMeUJoYzNObGNuUWdZV1JrY2k1dVlYUnBkbVVnSVQwZ1ZIaHVMbk5sYm1SbGNpd2dJbGx2ZFNCb1lYWmxJR0ZzY21WaFpIa2dkbTkwWldRZ1ptOXlJSFJvYVhNZ2JXbHNaWE4wYjI1bElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlpiM1VnYUdGMlpTQmhiSEpsWVdSNUlIWnZkR1ZrSUdadmNpQjBhR2x6SUcxcGJHVnpkRzl1WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ053b2dJQ0FnWWlCMmIzUmxYMjFwYkdWemRHOXVaVjltYjNKZmFHVmhaR1Z5UURFS0NuWnZkR1ZmYldsc1pYTjBiMjVsWDJGbWRHVnlYMlp2Y2tBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPakU1TUFvZ0lDQWdMeThnWVhOelpYSjBJSEJ5YjNBdVkzSmxZWFJsWkY5aWVTNXVZWFJwZG1VZ0lUMGdWSGh1TG5ObGJtUmxjaXdnSWtOeVpXRjBiM0lnWTJGdWJtOTBJSFp2ZEdVaUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXhOaUF6TWlBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnUTNKbFlYUnZjaUJqWVc1dWIzUWdkbTkwWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qRTVNUW9nSUNBZ0x5OGdZWE56WlhKMElHMXBiR1Z6ZEc5dVpTNXdjbTl2Wmw5c2FXNXJJQ0U5SUNJaUxDQWlVSEp2YjJZZ2FYTWdibTkwSUhOMVltMXBkSFJsWkNCNVpYUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREV3SUM4dklERXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd0NpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJRkJ5YjI5bUlHbHpJRzV2ZENCemRXSnRhWFIwWldRZ2VXVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TVRrekNpQWdJQ0F2THlCamRYSnlaVzUwWDNScGJXVWdQU0JIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPakU1TkFvZ0lDQWdMeThnWVhOelpYSjBJRzFwYkdWemRHOXVaUzUyYjNScGJtZGZaVzVrWDNScGJXVXVibUYwYVhabElENGdZM1Z5Y21WdWRGOTBhVzFsTENBaVZtOTBhVzVuSUhCbGNtbHZaQ0JvWVhNZ1pXNWtaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElEUTFJQzh2SURRMUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnUEFvZ0lDQWdZWE56WlhKMElDOHZJRlp2ZEdsdVp5QndaWEpwYjJRZ2FHRnpJR1Z1WkdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNVGsyQ2lBZ0lDQXZMeUJrYjI1aGRHOXlYMkp2ZUY5clpYa2dQU0JFYjI1aGRHbHZia0p2ZUV0bGVTaHdjbTl3YjNOaGJGOXBaRDF3Y205d2IzTmhiRjlwWkN3Z1pHOXViM0k5UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1UazNDaUFnSUNBdkx5QmhjM05sY25RZ1pHOXVZWFJ2Y2w5aWIzaGZhMlY1SUdsdUlITmxiR1l1Wkc5dVlYUnBiMjV6TENBaVdXOTFJR2hoZG1VZ2JtOTBJR1J2Ym1GMFpXUWdkRzhnZEdocGN5QndjbTl3YjNOaGJDSUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltUnZibUYwYVc5dWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJaYjNVZ2FHRjJaU0J1YjNRZ1pHOXVZWFJsWkNCMGJ5QjBhR2x6SUhCeWIzQnZjMkZzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1UazRDaUFnSUNBdkx5QmhiVzkxYm5SZlpHOXVZWFJsWkNBOUlITmxiR1l1Wkc5dVlYUnBiMjV6VzJSdmJtRjBiM0pmWW05NFgydGxlVjBLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1SdmJtRjBhVzl1Y3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG94T1RrS0lDQWdJQzh2SUdGemMyVnlkQ0JoYlc5MWJuUmZaRzl1WVhSbFpDQStQU0F4WHpBd01GOHdNREFzSUNKVGFHOTFiR1FnYUdGMlpTQmtiMjVoZEdWa0lHMXZjbVVnZEdoaGJpQXhJRUZzWjI4Z2RHOGdkbTkwWlNJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURCbU5ESTBNQW9nSUNBZ1lqNDlDaUFnSUNCaGMzTmxjblFnTHk4Z1UyaHZkV3hrSUdoaGRtVWdaRzl1WVhSbFpDQnRiM0psSUhSb1lXNGdNU0JCYkdkdklIUnZJSFp2ZEdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3lNREVLSUNBZ0lDOHZJSGRsYVdkb2RDQTlJRzl3TG5OeGNuUW9ZVzF2ZFc1MFgyUnZibUYwWldRdWJtRjBhWFpsSUM4dklFNWhkR2wyWlZWSmJuUTJOQ2d4WHpBd01GOHdNREFwS1FvZ0lDQWdZblJ2YVFvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3TURBd0lDOHZJREV3TURBd01EQUtJQ0FnSUM4S0lDQWdJSE54Y25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3lNRElLSUNBZ0lDOHZJR2xtSUhadmRHVTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNQW9nSUNBZ0lUMEtJQ0FnSUdKNklIWnZkR1ZmYldsc1pYTjBiMjVsWDJWc2MyVmZZbTlrZVVBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNakF6Q2lBZ0lDQXZMeUJ0YVd4bGMzUnZibVV1ZG05MFpYTmZabTl5SUQwZ1ZVbHVkRFkwS0cxcGJHVnpkRzl1WlM1MmIzUmxjMTltYjNJdWJtRjBhWFpsSUNzZ2QyVnBaMmgwS1FvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1pQXZMeUF4TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTVRJS0lDQWdJR1p5WVcxbFgySjFjbmtnTXdvS2RtOTBaVjl0YVd4bGMzUnZibVZmWVdaMFpYSmZhV1pmWld4elpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pJd053b2dJQ0FnTHk4Z2JXbHNaWE4wYjI1bExuUnZkR0ZzWDNadmRHVnljeUE5SUZWSmJuUTJOQ2h0YVd4bGMzUnZibVV1ZEc5MFlXeGZkbTkwWlhKekxtNWhkR2wyWlNBcklERXBDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREk0SUM4dklESTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJREk0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1qQTRDaUFnSUNBdkx5QnRhV3hsYzNSdmJtVmZkbTkwWlhNdVlYQndaVzVrS0VGa1pISmxjM01vVkhodUxuTmxibVJsY2lrcENpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lDOEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG95TURrS0lDQWdJQzh2SUhObGJHWXViV2xzWlhOMGIyNWxWbTkwWlhOYmNISnZjRzl6WVd4ZmFXUmRJRDBnYldsc1pYTjBiMjVsWDNadmRHVnpMbU52Y0hrb0tRb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TWpFd0NpQWdJQ0F2THlCelpXeG1MbkJ5YjNCdmMyRnNjMXR3Y205d2IzTmhiRjlwWkYwdWJXbHNaWE4wYjI1bGMxdHdjbTl3TG1OMWNuSmxiblJmYldsc1pYTjBiMjVsTG01aGRHbDJaVjBnUFNCdGFXeGxjM1J2Ym1VdVkyOXdlU2dwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3Y205d2IzTmhiSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUExTmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlHUjVibUZ0YVdOZllYSnlZWGxmY21Wd2JHRmpaVjlrZVc1aGJXbGpYMlZzWlcxbGJuUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dwMmIzUmxYMjFwYkdWemRHOXVaVjlsYkhObFgySnZaSGxBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3lNRFVLSUNBZ0lDOHZJRzFwYkdWemRHOXVaUzUyYjNSbGMxOWhaMkZwYm5OMElEMGdWVWx1ZERZMEtHMXBiR1Z6ZEc5dVpTNTJiM1JsYzE5aFoyRnBibk4wTG01aGRHbDJaU0FySUhkbGFXZG9kQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTWpBZ0x5OGdNakFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJREl3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHSWdkbTkwWlY5dGFXeGxjM1J2Ym1WZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtWm1MbU52Ym5SeVlXTjBMbEJ5YjNCdmMyRnNRMjl1ZEhKaFkzUXVZMnhoYVcxZmJXbHNaWE4wYjI1bEtIQnliM0J2YzJGc1gybGtPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tZMnhoYVcxZmJXbHNaWE4wYjI1bE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPakl4TXkweU1UUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUdOc1lXbHRYMjFwYkdWemRHOXVaU2h6Wld4bUxDQndjbTl3YjNOaGJGOXBaRG9nVlVsdWREWTBLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNakUxQ2lBZ0lDQXZMeUJoYzNObGNuUWdjSEp2Y0c5ellXeGZhV1FnYVc0Z2MyVnNaaTV3Y205d2IzTmhiSE1zSUNKUWNtOXdiM05oYkNCa2IyVnpiaWQwSUdWNGFYTjBJZ29nSUNBZ1lubDBaV05mTXlBdkx5QWljSEp2Y0c5ellXeHpJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVUhKdmNHOXpZV3dnWkc5bGMyNG5kQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPakl4TmdvZ0lDQWdMeThnY0hKdmNDQTlJSE5sYkdZdWNISnZjRzl6WVd4elczQnliM0J2YzJGc1gybGtYUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjSEp2Y0c5ellXeHpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qSXhOd29nSUNBZ0x5OGdiV2xzWlhOMGIyNWxJRDBnY0hKdmNDNXRhV3hsYzNSdmJtVnpXM0J5YjNBdVkzVnljbVZ1ZEY5dGFXeGxjM1J2Ym1VdWJtRjBhWFpsWFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBM05DQXZMeUEzTkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnTlRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXRJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklETUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTlFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNakU1Q2lBZ0lDQXZMeUJqZFhKeVpXNTBYM1JwYldVZ1BTQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qSXlNQW9nSUNBZ0x5OGdZWE56WlhKMElHMXBiR1Z6ZEc5dVpTNXdjbTl2Wmw5c2FXNXJJQ0U5SUNJaUxDQWlVSEp2YjJZZ2FYTWdibTkwSUhOMVltMXBkSFJsWkNCNVpYUWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBeE1DQXZMeUF4TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNQW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUWNtOXZaaUJwY3lCdWIzUWdjM1ZpYldsMGRHVmtJSGxsZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qSXlNUW9nSUNBZ0x5OGdZWE56WlhKMElHMXBiR1Z6ZEc5dVpTNXdjbTl2Wmw5emRXSnRhWFIwWldSZmRHbHRaUzV1WVhScGRtVWdJVDBnTUN3Z0lsQnliMjltSUc1dmRDQnpkV0p0YVhSMFpXUWdlV1YwSWdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdNemNnTHk4Z016Y0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaGMzTmxjblFnTHk4Z1VISnZiMllnYm05MElITjFZbTFwZEhSbFpDQjVaWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveU1qSUtJQ0FnSUM4dklHRnpjMlZ5ZENCamRYSnlaVzUwWDNScGJXVWdQaUJ0YVd4bGMzUnZibVV1ZG05MGFXNW5YMlZ1WkY5MGFXMWxMbTVoZEdsMlpTd2dJbFp2ZEdsdVp5QndaWEpwYjJRZ2JtOTBJR1Z1WkdWa0lIbGxkQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEUTFJQzh2SURRMUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnUGdvZ0lDQWdZWE56WlhKMElDOHZJRlp2ZEdsdVp5QndaWEpwYjJRZ2JtOTBJR1Z1WkdWa0lIbGxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pJeU13b2dJQ0FnTHk4Z1lYTnpaWEowSUcxcGJHVnpkRzl1WlM1MmIzUmxjMTltYjNJdWJtRjBhWFpsSUQ0Z2JXbHNaWE4wYjI1bExuWnZkR1Z6WDJGbllXbHVjM1F1Ym1GMGFYWmxMQ0FpVFdsc1pYTjBiMjVsSUc1dmRDQmhjSEJ5YjNabFpDSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TWlBdkx5QXhNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElESXdJQzh2SURJd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnUGdvZ0lDQWdZWE56WlhKMElDOHZJRTFwYkdWemRHOXVaU0J1YjNRZ1lYQndjbTkyWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3lNalFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnViM1FnYldsc1pYTjBiMjVsTG1Oc1lXbHRaV1FzSUNKTmFXeGxjM1J2Ym1VZ1lXeHlaV0ZrZVNCamJHRnBiV1ZrSWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqSURRZ0x5OGdNamc0Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUV2xzWlhOMGIyNWxJR0ZzY21WaFpIa2dZMnhoYVcxbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPakl5TmdvZ0lDQWdMeThnWTNKbFlYUnZjaUE5SUhCeWIzQXVZM0psWVhSbFpGOWllUzV1WVhScGRtVUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaWGgwY21GamRDQXhOaUF6TWlBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveU1qY3RNak14Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlZM0psWVhSdmNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTliV2xzWlhOMGIyNWxMbUZ0YjNWdWRDNXVZWFJwZG1VS0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveU1qZ0tJQ0FnSUM4dklITmxibVJsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3lNekFLSUNBZ0lDOHZJR0Z0YjNWdWREMXRhV3hsYzNSdmJtVXVZVzF2ZFc1MExtNWhkR2wyWlFvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1UyVnVaR1Z5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TWpJM0NpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3lNamN0TWpNeENpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5WTNKbFlYUnZjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5Yldsc1pYTjBiMjVsTG1GdGIzVnVkQzV1WVhScGRtVUtJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNak16Q2lBZ0lDQXZMeUJ0YVd4bGMzUnZibVV1WTJ4aGFXMWxaQ0E5SUVKdmIyd29WSEoxWlNrS0lDQWdJR2x1ZEdNZ05DQXZMeUF5T0RnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3lNelFLSUNBZ0lDOHZJSE5sYkdZdWNISnZjRzl6WVd4elczQnliM0J2YzJGc1gybGtYUzV0YVd4bGMzUnZibVZ6VzNCeWIzQXVZM1Z5Y21WdWRGOXRhV3hsYzNSdmJtVXVibUYwYVhabFhTQTlJRzFwYkdWemRHOXVaUzVqYjNCNUtDa0tJQ0FnSUdScFp5QXpDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3Y205d2IzTmhiSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUExTmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyRnNiSE4xWWlCa2VXNWhiV2xqWDJGeWNtRjVYM0psY0d4aFkyVmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TWpNMUNpQWdJQ0F2THlCelpXeG1MbkJ5YjNCdmMyRnNjMXR3Y205d2IzTmhiRjlwWkYwdVkzVnljbVZ1ZEY5dGFXeGxjM1J2Ym1VZ1BTQlZTVzUwTmpRb2NISnZjQzVqZFhKeVpXNTBYMjFwYkdWemRHOXVaUzV1WVhScGRtVWdLeUF4S1FvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQnliM0J2YzJGc2N5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEYzBDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Wm1ZdVkyOXVkSEpoWTNRdVVISnZjRzl6WVd4RGIyNTBjbUZqZEM1eVpXWjFibVJmYVdaZmFXNWhZM1JwZG1Vb2NISnZjRzl6WVd4ZmFXUTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncHlaV1oxYm1SZmFXWmZhVzVoWTNScGRtVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TWpNNExUSXpPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ2NtVm1kVzVrWDJsbVgybHVZV04wYVhabEtITmxiR1lzSUhCeWIzQnZjMkZzWDJsa09pQlZTVzUwTmpRcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TWpRd0NpQWdJQ0F2THlCaGMzTmxjblFnY0hKdmNHOXpZV3hmYVdRZ2FXNGdjMlZzWmk1d2NtOXdiM05oYkhNc0lDSlFjbTl3YjNOaGJDQmtiMlZ6YmlkMElHVjRhWE4wSWdvZ0lDQWdZbmwwWldOZk15QXZMeUFpY0hKdmNHOXpZV3h6SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1VISnZjRzl6WVd3Z1pHOWxjMjRuZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pJME1Rb2dJQ0FnTHk4Z2NISnZjQ0E5SUhObGJHWXVjSEp2Y0c5ellXeHpXM0J5YjNCdmMyRnNYMmxrWFM1amIzQjVLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdjbTl3YjNOaGJITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1qUXlDaUFnSUNBdkx5QmpkWEp5Wlc1MFgyMXBiR1Z6ZEc5dVpTQTlJSEJ5YjNBdWJXbHNaWE4wYjI1bGMxdHdjbTl3TG1OMWNuSmxiblJmYldsc1pYTjBiMjVsTG01aGRHbDJaVjB1WTI5d2VTZ3BDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTnpRZ0x5OGdOelFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eklDOHZJRFUyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNBdElDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURRS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pJME13b2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5MGFXMWxJRDBnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG95TkRRS0lDQWdJQzh2SUhScGJXVmZaR2xtWm1WeVpXNWpaU0E5SUdOMWNuSmxiblJmZEdsdFpTQXRJR04xY25KbGJuUmZiV2xzWlhOMGIyNWxMbkJ5YjI5bVgzTjFZbTFwZEhSbFpGOTBhVzFsTG01aGRHbDJaUW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBek55QXZMeUF6TndvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveU5EWUtJQ0FnSUM4dklHUnZibUYwYjNKZlltOTRYMnRsZVNBOUlFUnZibUYwYVc5dVFtOTRTMlY1S0hCeWIzQnZjMkZzWDJsa1BYQnliM0J2YzJGc1gybGtMQ0JrYjI1dmNqMUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG95TkRjS0lDQWdJQzh2SUdGemMyVnlkQ0JrYjI1aGRHOXlYMkp2ZUY5clpYa2dhVzRnYzJWc1ppNWtiMjVoZEdsdmJuTXNJQ0paYjNVZ2FHRjJaU0J1YjNRZ1pHOXVZWFJsWkNCMGJ5QjBhR2x6SUhCeWIzQnZjMkZzSWdvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWkc5dVlYUnBiMjV6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdXVzkxSUdoaGRtVWdibTkwSUdSdmJtRjBaV1FnZEc4Z2RHaHBjeUJ3Y205d2IzTmhiQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pJME9Bb2dJQ0FnTHk4Z1lXMXZkVzUwWDJSdmJtRjBaV1FnUFNCelpXeG1MbVJ2Ym1GMGFXOXVjMXRrYjI1aGRHOXlYMkp2ZUY5clpYbGRDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1a2IyNWhkR2x2Ym5NZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TWpVd0NpQWdJQ0F2THlCcFppQjBhVzFsWDJScFptWmxjbVZ1WTJVZ1BpQmxlSEJwY21GMGFXOXVYM1JwYldVNkNpQWdJQ0J3ZFhOb2FXNTBJREkwTUNBdkx5QXlOREFLSUNBZ0lENEtJQ0FnSUdKNklISmxablZ1WkY5cFpsOXBibUZqZEdsMlpWOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3lOVEVLSUNBZ0lDOHZJSEpsYldGcGJtbHVaMTloYlc5MWJuUWdQU0J3Y205d0xtRnRiM1Z1ZEY5eVpYRjFhWEpsWkM1dVlYUnBkbVVnTFNCd2NtOXdMbUZ0YjNWdWRGOXlZV2x6WldRdWJtRjBhWFpsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURnZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ05EZ2dMeThnTkRnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdMUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TWpVeUNpQWdJQ0F2THlCcFppQmhiVzkxYm5SZlpHOXVZWFJsWkNBK0lEQTZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0krQ2lBZ0lDQmllaUJ5WldaMWJtUmZhV1pmYVc1aFkzUnBkbVZmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TWpVekNpQWdJQ0F2THlCeVpXWjFibVJmWVcxdmRXNTBJRDBnVlVsdWREWTBLSEpsYldGcGJtbHVaMTloYlc5MWJuUWdLaUJoYlc5MWJuUmZaRzl1WVhSbFpDNXVZWFJwZG1VZ0x5OGdjSEp2Y0M1aGJXOTFiblJmY21GcGMyVmtMbTVoZEdsMlpTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0JpZEc5cENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdLZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUM4S0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3lOVFF0TWpVNENpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWNtVm1kVzVrWDJGdGIzVnVkQzV1WVhScGRtVUtJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3lOVFVLSUNBZ0lDOHZJSE5sYm1SbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG95TlRZS0lDQWdJQzh2SUhKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1qVTNDaUFnSUNBdkx5QmhiVzkxYm5ROWNtVm1kVzVrWDJGdGIzVnVkQzV1WVhScGRtVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZblJ2YVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TWpVMENpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3lOVFF0TWpVNENpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWNtVm1kVzVrWDJGdGIzVnVkQzV1WVhScGRtVUtJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNalU1Q2lBZ0lDQXZMeUJ6Wld4bUxtUnZibUYwYVc5dWMxdGtiMjVoZEc5eVgySnZlRjlyWlhsZElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0p2ZUY5d2RYUUtDbkpsWm5WdVpGOXBabDlwYm1GamRHbDJaVjloWm5SbGNsOXBabDlsYkhObFFEVTZDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVptWXVZMjl1ZEhKaFkzUXVVSEp2Y0c5ellXeERiMjUwY21GamRDNW1kVzVrWDJaMWRIVnlaVjl6Wld4bUtIQnlhVzFoY25rNklHSjVkR1Z6TENCaVlXTnJkWEE2SUdKNWRHVnpMQ0IxYm14dlkydGZkR2x0WlRvZ1lubDBaWE1zSUhCaGVXMWxiblE2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LWm5WdVpGOW1kWFIxY21WZmMyVnNaam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveU5qSXRNamN3Q2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFNCR2RYUjFjbVVnVTJWc1ppQk5aWFJvYjJSeklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnWm5WdVpGOW1kWFIxY21WZmMyVnNaaWdLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUhCeWFXMWhjbms2SUVGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1ltRmphM1Z3T2lCQlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lIVnViRzlqYTE5MGFXMWxPaUJWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnY0dGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZISmhibk5oWTNScGIyNEtJQ0FnSUM4dklDa2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJRFFnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qSTNNUW9nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzFsYm5RdWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d2dJbEJoZVcxbGJuUWdiWFZ6ZENCbmJ5QjBieUJqYjI1MGNtRmpkQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGQmhlVzFsYm5RZ2JYVnpkQ0JuYnlCMGJ5QmpiMjUwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJabUwyTnZiblJ5WVdOMExuQjVPakkzTWdvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUXVZVzF2ZFc1MElENGdNQ3dnSWsxMWMzUWdablZ1WkNCM2FYUm9JSEJ2YzJsMGFYWmxJR0Z0YjNWdWRDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJOZFhOMElHWjFibVFnZDJsMGFDQndiM05wZEdsMlpTQmhiVzkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3lOek1LSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExuTmxibVJsY2lBOVBTQlVlRzR1YzJWdVpHVnlMQ0FpUm5WdVpHbHVaeUJ0ZFhOMElHSmxJR1p5YjIwZ1kyRnNiR1Z5SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUm5WdVpHbHVaeUJ0ZFhOMElHSmxJR1p5YjIwZ1kyRnNiR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1qYzFDaUFnSUNBdkx5QnBaSGdnUFNCelpXeG1MbTV2WDI5bVgyWjFkSFZ5WlY5bWRXNWtjeTUyWVd4MVpRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW01dlQyWkdkWFIxY21WR2RXNWtjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dWIxOXZabDltZFhSMWNtVmZablZ1WkhNZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk1qZ3dDaUFnSUNBdkx5QmhiVzkxYm5ROVZVbHVkRFkwS0hCaGVXMWxiblF1WVcxdmRXNTBLU3dLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveU56WXRNamd5Q2lBZ0lDQXZMeUJ6Wld4bUxtWjFkSFZ5WlVaMWJtUnpXMmxrZUYwZ1BTQkdkWFIxY21WR2RXNWtLQW9nSUNBZ0x5OGdJQ0FnSUhCeWFXMWhjbms5Y0hKcGJXRnllU3dLSUNBZ0lDOHZJQ0FnSUNCaVlXTnJkWEE5WW1GamEzVndMQW9nSUNBZ0x5OGdJQ0FnSUhWdWJHOWphMTkwYVcxbFBYVnViRzlqYTE5MGFXMWxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFWU1c1ME5qUW9jR0Y1YldWdWRDNWhiVzkxYm5RcExBb2dJQ0FnTHk4Z0lDQWdJR05zWVdsdFpXUTlRbTl2YkNoR1lXeHpaU2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3lPREVLSUNBZ0lDOHZJR05zWVdsdFpXUTlRbTl2YkNoR1lXeHpaU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qSTNOaTB5T0RJS0lDQWdJQzh2SUhObGJHWXVablYwZFhKbFJuVnVaSE5iYVdSNFhTQTlJRVoxZEhWeVpVWjFibVFvQ2lBZ0lDQXZMeUFnSUNBZ2NISnBiV0Z5ZVQxd2NtbHRZWEo1TEFvZ0lDQWdMeThnSUNBZ0lHSmhZMnQxY0QxaVlXTnJkWEFzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXNiMk5yWDNScGJXVTlkVzVzYjJOclgzUnBiV1VzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFZWSmJuUTJOQ2h3WVhsdFpXNTBMbUZ0YjNWdWRDa3NDaUFnSUNBdkx5QWdJQ0FnWTJ4aGFXMWxaRDFDYjI5c0tFWmhiSE5sS1FvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNamMyQ2lBZ0lDQXZMeUJ6Wld4bUxtWjFkSFZ5WlVaMWJtUnpXMmxrZUYwZ1BTQkdkWFIxY21WR2RXNWtLQW9nSUNBZ1lubDBaV01nT1NBdkx5QWlablYwZFhKbFJuVnVaRjhpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNamMyTFRJNE1nb2dJQ0FnTHk4Z2MyVnNaaTVtZFhSMWNtVkdkVzVrYzF0cFpIaGRJRDBnUm5WMGRYSmxSblZ1WkNnS0lDQWdJQzh2SUNBZ0lDQndjbWx0WVhKNVBYQnlhVzFoY25rc0NpQWdJQ0F2THlBZ0lDQWdZbUZqYTNWd1BXSmhZMnQxY0N3S0lDQWdJQzh2SUNBZ0lDQjFibXh2WTJ0ZmRHbHRaVDExYm14dlkydGZkR2x0WlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVZVbHVkRFkwS0hCaGVXMWxiblF1WVcxdmRXNTBLU3dLSUNBZ0lDOHZJQ0FnSUNCamJHRnBiV1ZrUFVKdmIyd29SbUZzYzJVcENpQWdJQ0F2THlBcENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TWpnekNpQWdJQ0F2THlCelpXeG1MbTV2WDI5bVgyWjFkSFZ5WlY5bWRXNWtjeTUyWVd4MVpTQTlJRlZKYm5RMk5DaHBaSGd1Ym1GMGFYWmxJQ3NnTVNrS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUExSUM4dklDSnViMDltUm5WMGRYSmxSblZ1WkhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1abUxtTnZiblJ5WVdOMExsQnliM0J2YzJGc1EyOXVkSEpoWTNRdVkyeGhhVzFmWm5WMGRYSmxYM05sYkdZb1puVnVaRjlwWkRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q21Oc1lXbHRYMloxZEhWeVpWOXpaV3htT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qSTROaTB5T0RjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR05zWVdsdFgyWjFkSFZ5WlY5elpXeG1LSE5sYkdZc0lHWjFibVJmYVdRNklGVkpiblEyTkNrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pJNE9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdaMWJtUmZhV1FnYVc0Z2MyVnNaaTVtZFhSMWNtVkdkVzVrY3l3Z0lrWjFibVFnWkc5bGN5QnViM1FnWlhocGMzUWlDaUFnSUNCaWVYUmxZeUE1SUM4dklDSm1kWFIxY21WR2RXNWtYeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFWjFibVFnWkc5bGN5QnViM1FnWlhocGMzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG95T0RrS0lDQWdJQzh2SUdaMWJtUWdQU0J6Wld4bUxtWjFkSFZ5WlVaMWJtUnpXMloxYm1SZmFXUmRMbU52Y0hrb0tRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1aMWRIVnlaVVoxYm1SeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pJNU1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQm1kVzVrTG1Oc1lXbHRaV1FzSUNKQmJISmxZV1I1SUdOc1lXbHRaV1FpQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05qUXdJQzh2SURZME1Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGc2NtVmhaSGtnWTJ4aGFXMWxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pJNU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJRDQ5SUdaMWJtUXVkVzVzYjJOclgzUnBiV1V1Ym1GMGFYWmxMQ0FpVkc5dklHVmhjbXg1SUhSdklHTnNZV2x0SWdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdOalFnTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUZSdmJ5QmxZWEpzZVNCMGJ5QmpiR0ZwYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qSTVNd29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnWm5WdVpDNXdjbWx0WVhKNUlHOXlJRlI0Ymk1elpXNWtaWElnUFQwZ1puVnVaQzVpWVdOcmRYQXNJQ0pPYjNRZ1lYVjBhRzl5YVhwbFpDSUtJQ0FnSUdWNGRISmhZM1FnTUNBek1pQXZMeUJ2YmlCbGNuSnZjam9nU1c1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaWJub2dZMnhoYVcxZlpuVjBkWEpsWDNObGJHWmZZbTl2YkY5MGNuVmxRRElLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCbGVIUnlZV04wSURNeUlETXlJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHSjZJR05zWVdsdFgyWjFkSFZ5WlY5elpXeG1YMkp2YjJ4ZlptRnNjMlZBTXdvS1kyeGhhVzFmWm5WMGRYSmxYM05sYkdaZlltOXZiRjkwY25WbFFESTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb0tZMnhoYVcxZlpuVjBkWEpsWDNObGJHWmZZbTl2YkY5dFpYSm5aVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qSTVNd29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnWm5WdVpDNXdjbWx0WVhKNUlHOXlJRlI0Ymk1elpXNWtaWElnUFQwZ1puVnVaQzVpWVdOcmRYQXNJQ0pPYjNRZ1lYVjBhRzl5YVhwbFpDSUtJQ0FnSUdGemMyVnlkQ0F2THlCT2IzUWdZWFYwYUc5eWFYcGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWm1MMk52Ym5SeVlXTjBMbkI1T2pJNU5TMHlPVGtLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFtZFc1a0xtRnRiM1Z1ZEM1dVlYUnBkbVVLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bVppOWpiMjUwY21GamRDNXdlVG95T1RZS0lDQWdJQzh2SUhObGJtUmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1aaTlqYjI1MGNtRmpkQzV3ZVRveU9UY0tJQ0FnSUM4dklISmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm1ZdlkyOXVkSEpoWTNRdWNIazZNams0Q2lBZ0lDQXZMeUJoYlc5MWJuUTlablZ1WkM1aGJXOTFiblF1Ym1GMGFYWmxDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCd2RYTm9hVzUwSURjeUlDOHZJRGN5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptWXZZMjl1ZEhKaFkzUXVjSGs2TWprMUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltWmk5amIyNTBjbUZqZEM1d2VUb3lPVFV0TWprNUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVpuVnVaQzVoYlc5MWJuUXVibUYwYVhabENpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlptTDJOdmJuUnlZV04wTG5CNU9qTXdNUW9nSUNBZ0x5OGdablZ1WkM1amJHRnBiV1ZrSUQwZ1FtOXZiQ2hVY25WbEtRb2dJQ0FnY0hWemFHbHVkQ0EyTkRBZ0x5OGdOalF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabVl2WTI5dWRISmhZM1F1Y0hrNk16QXlDaUFnSUNBdkx5QnpaV3htTG1aMWRIVnlaVVoxYm1SelcyWjFibVJmYVdSZElEMGdablZ1WkM1amIzQjVLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0NtTnNZV2x0WDJaMWRIVnlaVjl6Wld4bVgySnZiMnhmWm1Gc2MyVkFNem9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHTnNZV2x0WDJaMWRIVnlaVjl6Wld4bVgySnZiMnhmYldWeVoyVkFOQW89IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUZBUUFDT0tBQ0pnb0lBQUFBQUFBQUFBQUNBQUFCQUFsd2NtOXdiM05oYkhNTmJtOVBabEJ5YjNCdmMyRnNjdzl1YjA5bVJuVjBkWEpsUm5WdVpITUNBQUlQYldsc1pYTjBiMjVsVm05MFpYTmZDV1J2Ym1GMGFXOXVjd3RtZFhSMWNtVkdkVzVrWHpFWVFBQUlKd1FvWnljRktHY3hHMEVBOG9JSUJHcFFIbGdFaDJkVjBBUlZiNExEQkl4UWZ4Z0VKNVRaWXdUbVFGblJCT2tTZ2lZRUptbFdkellhQUk0SUFJc0FjZ0JnQUU0QVB3QXdBQkVBQWlORE1Sa1VSREVZUkRZYUFZZ0hieUpETVJrVVJERVlSRFlhQVRZYUFqWWFBekVXSWdsSk9CQWlFa1NJQnhRaVF6RVpGRVF4R0VRMkdnR0lCbG9pUXpFWkZFUXhHRVEyR2dHSUJYWWlRekVaRkVReEdFUTJHZ0UyR2dLSUJESWlRekVaRkVReEdFUTJHZ0UyR2dLSUF5VWlRekVaRkVReEdFUTJHZ0V4RmlJSlNUZ1FJaEpFaUFLV0lrTXhHUlJFTVJoRU5ob0JOaG9DTmhvRE5ob0VOaG9GTmhvR01SWWlDVWs0RUNJU1JJZ0JFaUpETVJsQS8wZ3hHQlJFSWtPS0JBR0FBRW1ML2lRTGkvd2tDeU9MQklzRERFRUFISXY5aXdSSlRnSlppd0lJRmxjR0Fvc0JURkNNQVNRSWpBUkMvOXlML1JXTUFDT01CSXNFaXdJTVFRQWNpLytMQkVsT0FsbUxBQWdXVndZQ2l3Rk1VSXdCSkFpTUJFTC8zSXY4aS80SUZsY0dBb3NCVUl2OWl3T0xBRkpRaS84VmkvK0xBazhDVWxDTUFJbUtBd0dML1ZFQUFra1hpLzFYQWdDTC95UUxTd0ZNV1l2L0lnZ2tDMGxPQkVzQ1RGbExBaFZMQkl2L0NTSUpTd0ZQQTA4Q1RVbExBd2xPQll2K0ZVNEZTd01qVHdSU2kvNVFUd05QQWs4RFVsQk1KQXVMQVlzRkRFRUFJSXNFU1lzQlNVNERXWXNEQ0lzQ0NSWlhCZ0pMQWt4ZGpBUWtDSXdCUXYvWWl3Q0xCRkNNQUltS0J3Q0wvemdJZ1lDSmVoSkVpLzg0QnpJS0VrU0wvemdBTVFBU1JDTW5CR1ZFS1NPTC9pTlpJNHNFaXdNTVFRQjlpLzVYQWdDTEJFbE9BaVFMU3dGTVdVOENJZ2hKakFTTEEwc0JDVXNERlU4Q0pBdExCRXhaVHdKTlVra2pXVXNCRlVzQ1RnSlNTd0ZYQWdoTEFSV0JOUWlBQWdBMVR3SlFUQlpYQmdKUUtGQW9VQ2hRS2xBb1VDaFFURkFwVUNjR1RGQ0xBVWtqV1V4WEFnQWlUd09JL2xtTUFTUmJpd0lJakFKQy8zdUxBaGFML2FoRWkvMG9wVVNMQVVraldVbEVnUVVPUkl2NVZ3SUFGVVNMK2xjQ0FCVkVpL3RYQWdBVlJERUFNZ2NXaS9rVmdWb0lTUlpYQmdLQUFnQmFURkNMK2hWUEFnaEpGbGNHQWs4Q1RGQ0wreFZQQWdoSkZsY0dBazhDVEZDTC9CVlBBZ2hNaS8xUVR3TlFLRkJNRmxjR0FsQW9VQ2hRS0ZCTVVJdjVVSXY2VUl2N1VJdjhVRXhRSzRzQVNVNERVRW04U0V5L0p3ZE1VRW04U0NtL0l5Y0VaVVFYSWdnV0p3Uk1aNG1LQWdBcmkvNVFSd0s5UlFGRXZreEpUd0pFU1Zjd0NFeFhDQWlrUkl2L09BaUwvemdBaS81TVVJdi9PQWN5Q2hKRUp3aE1VRW05UlFGQUFDNkxBVW1CUWxzaUNCWmNRb3dCaXdJV3Y0c0JTWUU2V3lJSUZsdzZTWUV3VzRzQ0NCWmNNSXNBU2J4SVRMK0pTYjVFRjRzQ0NCYS9Rdi9YaWdJQWdBQXJpLzVRUndLOVJRRkV2a3hKVHdKRVNWY1FJREVBRWtSSlZ6QUlTd0ZYQ0FpblJFbUJTbHRKVHdKSkpWbEpUZ0pPQTBrVlRFNENVa2xPQWlOWlNVNENERVF5Qnlraml3bUxCZ3hCQUkyTEJWY0NBSXNKU1U0Q0pBdExBVXhaU3dJaUNFbU1BSXNHU3dFSlN3TVZUd0lrQzBzRVRGbFBBazFTVElzREVrRUFRMG1CQ2xralRGaUwvMUNMQjBsT0FoWmNKVXlCdEFFSUZsd3RJUVFqVkNoY0RDaGNGQ2hjSENjR1RGQ0xDRWtqV1V4WEFnQWlUd09JL0dxTUNJc0FqQWxDLzRNbkJreFFpd2hKSTFsTVZ3SUFJazhEaVB4T2pBaEMvK0dMQWlPTEJGaUxDRkNMQVVtOFNFeS9Kd2VML2xCSnZFZ3B2NG1LQWdBcmkvNVFSd0s5UlFGRXZreEpUd0pFU1lGS1cwbFBBa2tsV1VzQkZWSkpWd0lBU3dJa0Mwc0JURmxQQWlOWlR3TWlDRXhMQVFsTEF4VlBBaVFMU3dSTVdVOENUVkluQjR2K1VFbStURWxQQWtRaldTT0xCNHNHREVFQUc0c0ZWd0lBaXdkSlRnS0JJQXVCSUZneEFCTkVJZ2lNQjBMLzNZc0JWeEFnTVFBVFJJc0RTWUVLV1VzQkZVc0NUZ0pTS1JORU1nZE1nUzFiREVTTC9qRUFVQ2NJVEZCSnZVVUJSTDVFU1lBSUFBQUFBQUFQUWtDblJCZUJ3SVE5Q3BLTC95b1RRUUJhaXdOSmdReGJUd0lJRmx3TWpBT0xBMG1CSEZzaUNCWmNISXNGVndJQU1RQlFTUldCSUFvV1Z3WUNURkNMQkVtOFNFeS9pd0JKdmtSSkpWbExBUlZMQWtzQ1R3SlNUd1NMQW9qN25FOENJMDhEV0V4UVN3RzhTTCtKaXdOSmdSUmJUd0lJRmx3VWpBTkMvNk9LQVFBcmkvOVFTYjFGQVVSSnZrUkpnVXBiU3dFbFdVc0NGVXNEVGdKU1NWY0NBRXNDSkF0TEFVeFpUd0lqV1VzRElnaE1Td0VKU3dNVlN3SWtDMHNGVEZsUEFrMVBBMDhEVHdKU01nZExBWUVLV1VzQ0ZVc0RUZ0pTS1JORVN3R0JKVnRFU3dHQkxWc05SRW1CREZ0TEFZRVVXdzFFU1NFRVV5b2pUd0pVS2hKRVR3TlhFQ0N4TWdwTEFpUmJzZ2l5QUxJSElySVFJN0lCc3lFRUlsUkxBNzVFU1NWWlN3RVZTd0pMQWs4Q1VrOERUd1dJK3NaUEFpTlBBMWhNVUVzQ3ZFaExBa3kvRmtzQnZrUk1YRXBMQWJ4SXY0bUtBUUNBQUVrcmkvOVFTYjFGQVVTK1RFbFBBa1JKZ1VwYlN3RWxXVXNDRlU4RFRnSlNTVmNDQUVzQ0pBdExBVXhaVHdJaldVOERJZ2hNU3dFSlN3TVZUd0lrQzBzRVRGbFBBazFTTWdkTWdTVmJDWXYvTVFCUUp3aE1VRWxPQWttOVJRRkV2a3hPQWtTQjhBRU5RUUE2aXdKSmdRaGJUSUV3VzBtTUFRbU1BSXNFS0tWQkFDT0xCQmVMQUF1TEFRb1dzVElLTVFCUEFoZXlDTElIc2dBaXNoQWpzZ0d6aXdNb3Y0bUtCQUNML3pnSE1nb1NSSXYvT0FoSlJJdi9PQUF4QUJKRUl5Y0ZaVVJNRm92OGkvMVFpLzVRVEZBcVVDY0pTd0pRVEw4WElnZ1dKd1ZNWjRtS0FRQW5DWXYvVUVjQ3ZVVUJSTDVNU1U4Q1JFbUJnQVZUS2lOUEFsUXFFa1F5QjBzQmdVQmJEMFJYQUNBeEFCSkFBQXVMQVZjZ0lERUFFa0VBSmlKRXNUSUtNUUNMQVVsT0E0RklXN0lJc2dleUFDS3lFQ095QWJPQmdBVWlWSXNBVEwrSkkwTC8xdz09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
