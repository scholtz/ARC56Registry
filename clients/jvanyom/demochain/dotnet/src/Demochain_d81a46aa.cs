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

namespace Arc56.Generated.jvanyom.demochain.Demochain_d81a46aa
{


    public class DemochainProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DemochainProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ApprovalTally : AVMObjectType
            {
                public uint VotesFor { get; set; }

                public uint TotalVotes { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotesFor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vVotesFor.From(VotesFor);
                    ret.AddRange(vVotesFor.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vTotalVotes.From(TotalVotes);
                    ret.AddRange(vTotalVotes.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ApprovalTally Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ApprovalTally();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotesFor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vVotesFor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVotesFor = vVotesFor.ToValue();
                    if (valueVotesFor is uint vVotesForValue) { ret.VotesFor = vVotesForValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalVotes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vTotalVotes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalVotes = vTotalVotes.ToValue();
                    if (valueTotalVotes is uint vTotalVotesValue) { ret.TotalVotes = vTotalVotesValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ApprovalTally);
                }
                public bool Equals(ApprovalTally? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ApprovalTally left, ApprovalTally right)
                {
                    return EqualityComparer<ApprovalTally>.Default.Equals(left, right);
                }
                public static bool operator !=(ApprovalTally left, ApprovalTally right)
                {
                    return !(left == right);
                }

            }

            public class BallotId : AVMObjectType
            {
                public Algorand.Address Sender { get; set; }

                public ulong ProposalId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSender.From(Sender);
                    ret.AddRange(vSender.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProposalId.From(ProposalId);
                    ret.AddRange(vProposalId.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BallotId Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BallotId();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSender = vSender.ToValue();
                    if (valueSender is Algorand.Address vSenderValue) { ret.Sender = vSenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProposalId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProposalId = vProposalId.ToValue();
                    if (valueProposalId is ulong vProposalIdValue) { ret.ProposalId = vProposalIdValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BallotId);
                }
                public bool Equals(BallotId? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BallotId left, BallotId right)
                {
                    return EqualityComparer<BallotId>.Default.Equals(left, right);
                }
                public static bool operator !=(BallotId left, BallotId right)
                {
                    return !(left == right);
                }

            }

            public class CensusId : AVMObjectType
            {
                public ulong OrgId { get; set; }

                public Algorand.Address Member { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrgId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOrgId.From(OrgId);
                    ret.AddRange(vOrgId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMember = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vMember.From(Member);
                    ret.AddRange(vMember.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static CensusId Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CensusId();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrgId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOrgId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOrgId = vOrgId.ToValue();
                    if (valueOrgId is ulong vOrgIdValue) { ret.OrgId = vOrgIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMember = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vMember.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMember = vMember.ToValue();
                    if (valueMember is Algorand.Address vMemberValue) { ret.Member = vMemberValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CensusId);
                }
                public bool Equals(CensusId? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CensusId left, CensusId right)
                {
                    return EqualityComparer<CensusId>.Default.Equals(left, right);
                }
                public static bool operator !=(CensusId left, CensusId right)
                {
                    return !(left == right);
                }

            }

            public class Organization : AVMObjectType
            {
                public ulong OrgId { get; set; }

                public string Name { get; set; }

                public string Description { get; set; }

                public Algorand.Address Organizer { get; set; }

                public uint MemberCount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrgId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOrgId.From(OrgId);
                    ret.AddRange(vOrgId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDescription.From(Description);
                    stringRef[ret.Count] = vDescription.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrganizer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOrganizer.From(Organizer);
                    ret.AddRange(vOrganizer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMemberCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vMemberCount.From(MemberCount);
                    ret.AddRange(vMemberCount.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Organization Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Organization();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrgId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOrgId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOrgId = vOrgId.ToValue();
                    if (valueOrgId is ulong vOrgIdValue) { ret.OrgId = vOrgIdValue; }
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexDescription = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDescription.Decode(bytes.Skip(indexDescription + prefixOffset).ToArray());
                    var valueDescription = vDescription.ToValue();
                    if (valueDescription is string vDescriptionValue) { ret.Description = vDescriptionValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrganizer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOrganizer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOrganizer = vOrganizer.ToValue();
                    if (valueOrganizer is Algorand.Address vOrganizerValue) { ret.Organizer = vOrganizerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMemberCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vMemberCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMemberCount = vMemberCount.ToValue();
                    if (valueMemberCount is uint vMemberCountValue) { ret.MemberCount = vMemberCountValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Organization);
                }
                public bool Equals(Organization? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Organization left, Organization right)
                {
                    return EqualityComparer<Organization>.Default.Equals(left, right);
                }
                public static bool operator !=(Organization left, Organization right)
                {
                    return !(left == right);
                }

            }

            public class Proposal : AVMObjectType
            {
                public ulong OrgId { get; set; }

                public string Title { get; set; }

                public string Description { get; set; }

                public string[] Options { get; set; }

                public ulong StartingDate { get; set; }

                public ulong EndingDate { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrgId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOrgId.From(OrgId);
                    ret.AddRange(vOrgId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTitle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vTitle.From(Title);
                    stringRef[ret.Count] = vTitle.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDescription = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDescription.From(Description);
                    stringRef[ret.Count] = vDescription.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOptions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string[]");
                    vOptions.From(Options);
                    ret.AddRange(vOptions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartingDate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStartingDate.From(StartingDate);
                    ret.AddRange(vStartingDate.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndingDate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEndingDate.From(EndingDate);
                    ret.AddRange(vEndingDate.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrgId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOrgId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOrgId = vOrgId.ToValue();
                    if (valueOrgId is ulong vOrgIdValue) { ret.OrgId = vOrgIdValue; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOptions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string[]");
                    count = vOptions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOptions = vOptions.ToValue();
                    if (valueOptions is string[] vOptionsValue) { ret.Options = vOptionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartingDate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStartingDate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStartingDate = vStartingDate.ToValue();
                    if (valueStartingDate is ulong vStartingDateValue) { ret.StartingDate = vStartingDateValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndingDate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEndingDate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEndingDate = vEndingDate.ToValue();
                    if (valueEndingDate is ulong vEndingDateValue) { ret.EndingDate = vEndingDateValue; }
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

        }

        ///<summary>
        ///Method for creating an organization
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="description"> </param>
        public async Task<ulong> CreateOrganization(string name, string description, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 113, 175, 103 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, descriptionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateOrganization_Transactions(string name, string description, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 113, 175, 103 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, descriptionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="org_id"> </param>
        /// <param name="addresses"> </param>
        public async Task AddToCensus(ulong org_id, Algorand.Address[] addresses, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 29, 224, 108, 90 };
            var org_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); org_idAbi.From(org_id);
            var addressesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); addressesAbi.From(addresses);

            var result = await base.CallApp(new List<object> { abiHandle, org_idAbi, addressesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddToCensus_Transactions(ulong org_id, Algorand.Address[] addresses, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 29, 224, 108, 90 };
            var org_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); org_idAbi.From(org_id);
            var addressesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); addressesAbi.From(addresses);

            return await base.MakeTransactionList(new List<object> { abiHandle, org_idAbi, addressesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="org_id"> </param>
        /// <param name="addresses"> </param>
        public async Task RemoveFromCensus(ulong org_id, Algorand.Address[] addresses, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 136, 25, 153 };
            var org_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); org_idAbi.From(org_id);
            var addressesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); addressesAbi.From(addresses);

            var result = await base.CallApp(new List<object> { abiHandle, org_idAbi, addressesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveFromCensus_Transactions(ulong org_id, Algorand.Address[] addresses, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 136, 25, 153 };
            var org_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); org_idAbi.From(org_id);
            var addressesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); addressesAbi.From(addresses);

            return await base.MakeTransactionList(new List<object> { abiHandle, org_idAbi, addressesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="org_id"> </param>
        /// <param name="address"> </param>
        public async Task<bool> IsInCensus(ulong org_id, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 240, 208, 253 };
            var org_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); org_idAbi.From(org_id);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, org_idAbi, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsInCensus_Transactions(ulong org_id, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 240, 208, 253 };
            var org_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); org_idAbi.From(org_id);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, org_idAbi, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="org_id"> </param>
        /// <param name="title"> </param>
        /// <param name="description"> </param>
        /// <param name="options"> </param>
        /// <param name="start_date"> </param>
        /// <param name="ending_date"> </param>
        public async Task<ulong> CreateProposal(ulong org_id, string title, string description, string[] options, ulong start_date, ulong ending_date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 31, 201, 0, 238 };
            var org_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); org_idAbi.From(org_id);
            var titleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); titleAbi.From(title);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var optionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.String>("string"); optionsAbi.From(options);
            var start_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); start_dateAbi.From(start_date);
            var ending_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ending_dateAbi.From(ending_date);

            var result = await base.CallApp(new List<object> { abiHandle, org_idAbi, titleAbi, descriptionAbi, optionsAbi, start_dateAbi, ending_dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateProposal_Transactions(ulong org_id, string title, string description, string[] options, ulong start_date, ulong ending_date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 31, 201, 0, 238 };
            var org_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); org_idAbi.From(org_id);
            var titleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); titleAbi.From(title);
            var descriptionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); descriptionAbi.From(description);
            var optionsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.String>("string"); optionsAbi.From(options);
            var start_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); start_dateAbi.From(start_date);
            var ending_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ending_dateAbi.From(ending_date);

            return await base.MakeTransactionList(new List<object> { abiHandle, org_idAbi, titleAbi, descriptionAbi, optionsAbi, start_dateAbi, ending_dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        /// <param name="approve"> </param>
        public async Task CastApprovalVote(ulong proposal_id, bool approve, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 4, 8, 99 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var approveAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); approveAbi.From(approve);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi, approveAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CastApprovalVote_Transactions(ulong proposal_id, bool approve, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 4, 8, 99 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var approveAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); approveAbi.From(approve);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi, approveAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposal_id"> </param>
        /// <param name="preference_order"> </param>
        public async Task CastElectionVote(ulong proposal_id, byte[] preference_order, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 216, 88, 47 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var preference_orderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); preference_orderAbi.From(preference_order);

            var result = await base.CallApp(new List<object> { abiHandle, proposal_idAbi, preference_orderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CastElectionVote_Transactions(ulong proposal_id, byte[] preference_order, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 216, 88, 47 };
            var proposal_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposal_idAbi.From(proposal_id);
            var preference_orderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); preference_orderAbi.From(preference_order);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal_idAbi, preference_orderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGVtb2NoYWluIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFwcHJvdmFsVGFsbHkiOlt7Im5hbWUiOiJ2b3Rlc19mb3IiLCJ0eXBlIjoidWludDMyIn0seyJuYW1lIjoidG90YWxfdm90ZXMiLCJ0eXBlIjoidWludDMyIn1dLCJCYWxsb3RJZCI6W3sibmFtZSI6InNlbmRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicHJvcG9zYWxfaWQiLCJ0eXBlIjoidWludDY0In1dLCJDZW5zdXNJZCI6W3sibmFtZSI6Im9yZ19pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtZW1iZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiT3JnYW5pemF0aW9uIjpbeyJuYW1lIjoib3JnX2lkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZGVzY3JpcHRpb24iLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoib3JnYW5pemVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJtZW1iZXJfY291bnQiLCJ0eXBlIjoidWludDMyIn1dLCJQcm9wb3NhbCI6W3sibmFtZSI6Im9yZ19pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0aXRsZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJkZXNjcmlwdGlvbiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJvcHRpb25zIiwidHlwZSI6InN0cmluZ1tdIn0seyJuYW1lIjoic3RhcnRpbmdfZGF0ZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlbmRpbmdfZGF0ZSIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX29yZ2FuaXphdGlvbiIsImRlc2MiOiJNZXRob2QgZm9yIGNyZWF0aW5nIGFuIG9yZ2FuaXphdGlvbiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXNjcmlwdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZF90b19jZW5zdXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JnX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVtb3ZlX2Zyb21fY2Vuc3VzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yZ19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzc1tdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzc2VzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX2luX2NlbnN1cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmdfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZV9wcm9wb3NhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmdfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpdGxlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZXNjcmlwdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcHRpb25zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFydF9kYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmRpbmdfZGF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhc3RfYXBwcm92YWxfdm90ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcHJvdmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FzdF9lbGVjdGlvbl92b3RlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3Bvc2FsX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJlZmVyZW5jZV9vcmRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzkyNSwxMDYyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hcHByb3ZhbF90YWxsaWVzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYub3JnX2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucHJvcG9zYWxfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEzMF0sImVycm9yTWVzc2FnZSI6ImVsZWN0aW9uLmFscmVhZHktdm90ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDU1XSwiZXJyb3JNZXNzYWdlIjoiZWxlY3Rpb24uZW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTQ4LDExODQsMTIxMl0sImVycm9yTWVzc2FnZSI6ImVsZWN0aW9uLm1pc3Npbmctb3B0aW9ucyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNDNdLCJlcnJvck1lc3NhZ2UiOiJlbGVjdGlvbi5ub3Qtc3RhcnRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNCw0NjAsMTE3NSwxMjA4XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjgsMzg0LDQ3NCw0OTQsNTEwLDczNyw4ODksOTUwLDk3MiwxMDI3LDEwNDAsMTA1MiwxMDc5LDEyOTFdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NiwxNjIsMjkyLDQxMiw1NzgsNTk0LDYxMCw2NTQsMTAwMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg3Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NzRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4Pj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDUsNDI1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU2LDE2OSw1ODcsNjAzLDEwMDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4Myw0MDMsNTI4LDU3MSw2ODUsNjk2LDg2NCw5OTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbisobGVuK3V0ZjhbXSlbXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTZdLCJlcnJvck1lc3NhZ2UiOiJvcmcuYWxyZWFkeS1leGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzhdLCJlcnJvck1lc3NhZ2UiOiJvcmcuY2Vuc3VzLmNhbm5vdC1yZW1vdmUtb3JnYW5pemVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU0XSwiZXJyb3JNZXNzYWdlIjoib3JnLmNlbnN1cy5kdXBsaWNhdGVkLWFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzldLCJlcnJvck1lc3NhZ2UiOiJvcmcuY2Vuc3VzLmludmFsaWQtYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4Nl0sImVycm9yTWVzc2FnZSI6Im9yZy5jZW5zdXMubm9uLXJlZ2lzdGVyZWQtYWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwOSw0MjldLCJlcnJvck1lc3NhZ2UiOiJvcmcuY2Vuc3VzLnRvby1tYW55LWFkZHJlc3NlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMTRdLCJlcnJvck1lc3NhZ2UiOiJvcmcuY2Vuc3VzLnVuYXV0aG9yaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4Ml0sImVycm9yTWVzc2FnZSI6Im9yZy5lbXB0eS1kZXNjcmlwdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3Nl0sImVycm9yTWVzc2FnZSI6Im9yZy5lbXB0eS1uYW1lIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI2OV0sImVycm9yTWVzc2FnZSI6Im9yZy5ub3QtZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjkzXSwiZXJyb3JNZXNzYWdlIjoib3JnLnVuYXV0aG9yaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3Nyw1MDMsOTQxLDk2Ml0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTEwXSwiZXJyb3JNZXNzYWdlIjoicHJvcG9zYWwuYWxyZWFkeS12b3RlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxNV0sImVycm9yTWVzc2FnZSI6InByb3Bvc2FsLmVtcHR5LWRlc2NyaXB0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzU4XSwiZXJyb3JNZXNzYWdlIjoicHJvcG9zYWwuZW1wdHktb3B0aW9ucyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwOF0sImVycm9yTWVzc2FnZSI6InByb3Bvc2FsLmVtcHR5LXRpdGxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExMF0sImVycm9yTWVzc2FnZSI6InByb3Bvc2FsLm5vdC1hY2NlcHRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNTRdLCJlcnJvck1lc3NhZ2UiOiJwcm9wb3NhbC5ub3QtZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjBdLCJlcnJvck1lc3NhZ2UiOiJwcm9wb3NhbC50b28tZmV3LW9wdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ01pQXpNZ29nSUNBZ1lubDBaV05pYkc5amF5QWliM0puWHlJZ0ltTnpYeUlnSW5CeVh5SWdJbkJ5YjNCdmMyRnNYMmxrSWlBaWIzSm5YMmxrSWlBd2VEZ3dJREI0TVRVeFpqZGpOelVnSW1GMFh5SUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk5URUtJQ0FnSUM4dklITmxiR1l1Y0hKdmNHOXpZV3hmYVdRZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luQnliM0J2YzJGc1gybGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPalV5Q2lBZ0lDQXZMeUJ6Wld4bUxtOXlaMTlwWkNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWIzSm5YMmxrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZZMmhoYVc0dlkyOXVkSEpoWTNRdWNIazZORGNLSUNBZ0lDOHZJR05zWVhOeklFUmxiVzlqYUdGcGJpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UWUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEbGxOekZoWmpZM0lEQjRNV1JsTURaak5XRWdNSGhsTmpnNE1UazVPU0F3ZUdZeFpqQmtNR1prSURCNE1XWmpPVEF3WldVZ01IZzRNREEwTURnMk15QXdlR0V3WkRnMU9ESm1JQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxYMjl5WjJGdWFYcGhkR2x2YmloemRISnBibWNzYzNSeWFXNW5LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZV1JrWDNSdlgyTmxibk4xY3loMWFXNTBOalFzWVdSa2NtVnpjMXRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsYlc5MlpWOW1jbTl0WDJObGJuTjFjeWgxYVc1ME5qUXNZV1JrY21WemMxdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltbHpYMmx1WDJObGJuTjFjeWgxYVc1ME5qUXNZV1JrY21WemN5bGliMjlzSWl3Z2JXVjBhRzlrSUNKamNtVmhkR1ZmY0hKdmNHOXpZV3dvZFdsdWREWTBMSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuVzEwc2RXbHVkRFkwTEhWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbU5oYzNSZllYQndjbTkyWVd4ZmRtOTBaU2gxYVc1ME5qUXNZbTl2YkNsMmIybGtJaXdnYldWMGFHOWtJQ0pqWVhOMFgyVnNaV04wYVc5dVgzWnZkR1VvZFdsdWREWTBMSFZwYm5RNFcxMHBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHTnlaV0YwWlY5dmNtZGhibWw2WVhScGIyNGdZV1JrWDNSdlgyTmxibk4xY3lCeVpXMXZkbVZmWm5KdmJWOWpaVzV6ZFhNZ2FYTmZhVzVmWTJWdWMzVnpJR055WldGMFpWOXdjbTl3YjNOaGJDQmpZWE4wWDJGd2NISnZkbUZzWDNadmRHVWdZMkZ6ZEY5bGJHVmpkR2x2Ymw5MmIzUmxDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRZNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wTGtSbGJXOWphR0ZwYmk1amNtVmhkR1ZmYjNKbllXNXBlbUYwYVc5dVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbFgyOXlaMkZ1YVhwaGRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WTJoaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk5qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCdWIzUWdjMlZzWmk1ZmFYTmZZbXhoYm1zb2JtRnRaU2tzSUNKdmNtY3VaVzF3ZEhrdGJtRnRaU0lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlGOXBjMTlpYkdGdWF3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzl5Wnk1bGJYQjBlUzF1WVcxbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qWTVDaUFnSUNBdkx5QmhjM05sY25RZ2JtOTBJSE5sYkdZdVgybHpYMkpzWVc1cktHUmxjMk55YVhCMGFXOXVLU3dnSW05eVp5NWxiWEIwZVMxa1pYTmpjbWx3ZEdsdmJpSUtJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJmYVhOZllteGhibXNLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdmNtY3VaVzF3ZEhrdFpHVnpZM0pwY0hScGIyNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZZMmhoYVc0dlkyOXVkSEpoWTNRdWNIazZOekFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnVZVzFsSUc1dmRDQnBiaUJ6Wld4bUxtOXlaMkZ1YVhwaGRHbHZibDl1WVcxbGN5d2dJbTl5Wnk1aGJISmxZV1I1TFdWNGFYTjBjeUlLSUNBZ0lIQjFjMmhpZVhSbGN5QWliMjVmSWdvZ0lDQWdaR2xuSURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdmNtY3VZV3h5WldGa2VTMWxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk56SUtJQ0FnSUM4dklITmxiR1l1YjNKblgybGtJQ3M5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p2Y21kZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNKblgybGtJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbTl5WjE5cFpDSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG8zTlFvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTV2Y21kZmFXUXBMQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG8zT0FvZ0lDQWdMeThnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUbzNOQzA0TUFvZ0lDQWdMeThnYzJWc1ppNXZjbWRoYm1sNllYUnBiMjV6VzNObGJHWXViM0puWDJsa1hTQTlJRTl5WjJGdWFYcGhkR2x2YmlnS0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtOXlaMTlwWkNrc0NpQWdJQ0F2THlBZ0lDQWdibUZ0WlN3S0lDQWdJQzh2SUNBZ0lDQmtaWE5qY21sd2RHbHZiaXdLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME16SW9NU2tLSUNBZ0lDOHZJQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURNd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaHBiblFnTkRnS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPamM1Q2lBZ0lDQXZMeUJoY21NMExsVkpiblF6TWlneEtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk56UXRPREFLSUNBZ0lDOHZJSE5sYkdZdWIzSm5ZVzVwZW1GMGFXOXVjMXR6Wld4bUxtOXlaMTlwWkYwZ1BTQlBjbWRoYm1sNllYUnBiMjRvQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1dmNtZGZhV1FwTEFvZ0lDQWdMeThnSUNBZ0lHNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ1pHVnpZM0pwY0hScGIyNHNDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERNeUtERXBDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUbzNOQW9nSUNBZ0x5OGdjMlZzWmk1dmNtZGhibWw2WVhScGIyNXpXM05sYkdZdWIzSm5YMmxrWFNBOUlFOXlaMkZ1YVhwaGRHbHZiaWdLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTl5WjE4aUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPamMwTFRnd0NpQWdJQ0F2THlCelpXeG1MbTl5WjJGdWFYcGhkR2x2Ym5OYmMyVnNaaTV2Y21kZmFXUmRJRDBnVDNKbllXNXBlbUYwYVc5dUtBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXViM0puWDJsa0tTd0tJQ0FnSUM4dklDQWdJQ0J1WVcxbExBb2dJQ0FnTHk4Z0lDQWdJR1JsYzJOeWFYQjBhVzl1TEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUXpNaWd4S1FvZ0lDQWdMeThnS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZZMmhoYVc0dlkyOXVkSEpoWTNRdWNIazZPRElLSUNBZ0lDOHZJSE5sYkdZdWIzSm5ZVzVwZW1GMGFXOXVYMjVoYldWelcyNWhiV1ZkSUQwZ1lYSmpOQzVDYjI5c0tGUnlkV1VwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0T0RBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZZMmhoYVc0dlkyOXVkSEpoWTNRdWNIazZPRE1LSUNBZ0lDOHZJSE5sYkdZdVkyVnVjM1Z6VzBObGJuTjFjMGxrS0dGeVl6UXVWVWx1ZERZMEtITmxiR1l1YjNKblgybGtLU3dnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBLVjBnUFNCaGNtTTBMa0p2YjJ3b1ZISjFaU2tLSUNBZ0lHUjFjQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmpjMThpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk9ESUtJQ0FnSUM4dklITmxiR1l1YjNKbllXNXBlbUYwYVc5dVgyNWhiV1Z6VzI1aGJXVmRJRDBnWVhKak5DNUNiMjlzS0ZSeWRXVXBDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRPREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WTJoaGFXNHZZMjl1ZEhKaFkzUXVjSGs2T0RNS0lDQWdJQzh2SUhObGJHWXVZMlZ1YzNWelcwTmxibk4xYzBsa0tHRnlZelF1VlVsdWREWTBLSE5sYkdZdWIzSm5YMmxrS1N3Z1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwS1YwZ1BTQmhjbU0wTGtKdmIyd29WSEoxWlNrS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZZMmhoYVc0dlkyOXVkSEpoWTNRdWNIazZOalVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBMa1JsYlc5amFHRnBiaTVoWkdSZmRHOWZZMlZ1YzNWelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZV1JrWDNSdlgyTmxibk4xY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk9EY0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG80T1FvZ0lDQWdMeThnWVhOelpYSjBJR0ZrWkhKbGMzTmxjeTVzWlc1bmRHZ2dQRDBnVFVGWVgwTkZUbE5WVTE5Q1FWUkRTQ3dnSW05eVp5NWpaVzV6ZFhNdWRHOXZMVzFoYm5rdFlXUmtjbVZ6YzJWeklnb2dJQ0FnY0hWemFHbHVkQ0EzQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOXlaeTVqWlc1emRYTXVkRzl2TFcxaGJua3RZV1JrY21WemMyVnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPamt3Q2lBZ0lDQXZMeUJ6Wld4bUxsOWhjM05sY25SZmFYTmZiM0puWVc1cGVtVnlLRzl5WjE5cFpDa0tJQ0FnSUdOaGJHeHpkV0lnWDJGemMyVnlkRjlwYzE5dmNtZGhibWw2WlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk9USUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoaFpHUnlaWE56WlhNdWJHVnVaM1JvS1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwaFpHUmZkRzlmWTJWdWMzVnpYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk9USUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoaFpHUnlaWE56WlhNdWJHVnVaM1JvS1RvS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRHdLSUNBZ0lHSjZJR0ZrWkY5MGIxOWpaVzV6ZFhOZllXWjBaWEpmWm05eVFEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZZMmhoYVc0dlkyOXVkSEpoWTNRdWNIazZPVE1LSUNBZ0lDOHZJR0ZrWkhKbGMzTWdQU0JoWkdSeVpYTnpaWE5iYVYwdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WTJoaGFXNHZZMjl1ZEhKaFkzUXVjSGs2T1RRS0lDQWdJQzh2SUdGemMyVnlkQ0JoWkdSeVpYTnpJQ0U5SUdGeVl6UXVRV1JrY21WemN5aEhiRzlpWVd3dWVtVnliMTloWkdSeVpYTnpLU3dnSW05eVp5NWpaVzV6ZFhNdWFXNTJZV3hwWkMxaFpHUnlaWE56SWdvZ0lDQWdaSFZ3Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnYjNKbkxtTmxibk4xY3k1cGJuWmhiR2xrTFdGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WTJoaGFXNHZZMjl1ZEhKaFkzUXVjSGs2T1RZS0lDQWdJQzh2SUd0bGVTQTlJRU5sYm5OMWMwbGtLRzl5WjE5cFpDd2dZV1JrY21WemN5a0tJQ0FnSUdScFp5QTFDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qazNDaUFnSUNBdkx5QmhjM05sY25RZ2EyVjVJRzV2ZENCcGJpQnpaV3htTG1ObGJuTjFjeXdnSW05eVp5NWpaVzV6ZFhNdVpIVndiR2xqWVhSbFpDMWhaR1J5WlhOeklnb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkzTmZJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzl5Wnk1alpXNXpkWE11WkhWd2JHbGpZWFJsWkMxaFpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjJOb1lXbHVMMk52Ym5SeVlXTjBMbkI1T2prNENpQWdJQ0F2THlCelpXeG1MbU5sYm5OMWMxdHJaWGxkSUQwZ1lYSmpOQzVDYjI5c0tGUnlkV1VwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0T0RBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZZMmhoYVc0dlkyOXVkSEpoWTNRdWNIazZNVEF4Q2lBZ0lDQXZMeUJ6Wld4bUxtOXlaMkZ1YVhwaGRHbHZibk5iYjNKblgybGtMbUZ6WDNWcGJuUTJOQ2dwWFM1dFpXMWlaWEpmWTI5MWJuUXVZWE5mZFdsdWREWTBLQ2tnS3lBeENpQWdJQ0JpZEc5cENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdmNtZGZJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5SeklEUTBJRFFLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG94TURBdE1UQXlDaUFnSUNBdkx5QnpaV3htTG05eVoyRnVhWHBoZEdsdmJuTmJiM0puWDJsa0xtRnpYM1ZwYm5RMk5DZ3BYUzV0WlcxaVpYSmZZMjkxYm5RZ1BTQmhjbU0wTGxWSmJuUXpNaWdLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MbTl5WjJGdWFYcGhkR2x2Ym5OYmIzSm5YMmxrTG1GelgzVnBiblEyTkNncFhTNXRaVzFpWlhKZlkyOTFiblF1WVhOZmRXbHVkRFkwS0NrZ0t5QXhDaUFnSUNBdkx5QXBDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdKcGRHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmxlSFJ5WVdOMElEUWdOQW9nSUNBZ2NIVnphR2x1ZENBME5Bb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzSmxjR3hoWTJVZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WTJoaGFXNHZZMjl1ZEhKaFkzUXVjSGs2T1RJS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2hoWkdSeVpYTnpaWE11YkdWdVozUm9LVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ1lXUmtYM1J2WDJObGJuTjFjMTltYjNKZmFHVmhaR1Z5UURJS0NtRmtaRjkwYjE5alpXNXpkWE5mWVdaMFpYSmZabTl5UURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qZzNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRDNUVaVzF2WTJoaGFXNHVjbVZ0YjNabFgyWnliMjFmWTJWdWMzVnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WdGIzWmxYMlp5YjIxZlkyVnVjM1Z6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE1EUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG94TURZS0lDQWdJQzh2SUdGemMyVnlkQ0JoWkdSeVpYTnpaWE11YkdWdVozUm9JRHc5SUUxQldGOURSVTVUVlZOZlFrRlVRMGdzSUNKdmNtY3VZMlZ1YzNWekxuUnZieTF0WVc1NUxXRmtaSEpsYzNObGN5SUtJQ0FnSUhCMWMyaHBiblFnTndvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZjbWN1WTJWdWMzVnpMblJ2YnkxdFlXNTVMV0ZrWkhKbGMzTmxjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG94TURjS0lDQWdJQzh2SUhObGJHWXVYMkZ6YzJWeWRGOXBjMTl2Y21kaGJtbDZaWElvYjNKblgybGtLUW9nSUNBZ1pIVndDaUFnSUNCallXeHNjM1ZpSUY5aGMzTmxjblJmYVhOZmIzSm5ZVzVwZW1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qRXdPUW9nSUNBZ0x5OGdiM0puSUQwZ2MyVnNaaTV2Y21kaGJtbDZZWFJwYjI1elcyOXlaMTlwWkM1aGMxOTFhVzUwTmpRb0tWMHVZMjl3ZVNncENpQWdJQ0JpZEc5cENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdmNtZGZJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjJOb1lXbHVMMk52Ym5SeVlXTjBMbkI1T2pFeE1Rb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0dGa1pISmxjM05sY3k1c1pXNW5kR2dwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ25KbGJXOTJaVjltY205dFgyTmxibk4xYzE5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPakV4TVFvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLR0ZrWkhKbGMzTmxjeTVzWlc1bmRHZ3BPZ29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNd29nSUNBZ1BBb2dJQ0FnWW5vZ2NtVnRiM1psWDJaeWIyMWZZMlZ1YzNWelgyRm1kR1Z5WDJadmNrQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPakV4TWdvZ0lDQWdMeThnWVdSa2NtVnpjeUE5SUdGa1pISmxjM05sYzF0cFhTNWpiM0I1S0NrS0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE1UTUtJQ0FnSUM4dklHdGxlU0E5SUVObGJuTjFjMGxrS0c5eVoxOXBaQ3dnWVdSa2NtVnpjeWtLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qRXhOUW9nSUNBZ0x5OGdZWE56WlhKMElHRmtaSEpsYzNNZ0lUMGdiM0puTG05eVoyRnVhWHBsY2l3Z0ltOXlaeTVqWlc1emRYTXVZMkZ1Ym05MExYSmxiVzkyWlMxdmNtZGhibWw2WlhJaUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCd2RYTm9hVzUwSURFeUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM0puTG1ObGJuTjFjeTVqWVc1dWIzUXRjbVZ0YjNabExXOXlaMkZ1YVhwbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUb3hNVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnJaWGtnYVc0Z2MyVnNaaTVqWlc1emRYTXNJQ0p2Y21jdVkyVnVjM1Z6TG01dmJpMXlaV2RwYzNSbGNtVmtMV0ZrWkhKbGMzTWlDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmpjMThpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z2IzSm5MbU5sYm5OMWN5NXViMjR0Y21WbmFYTjBaWEpsWkMxaFpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjJOb1lXbHVMMk52Ym5SeVlXTjBMbkI1T2pFeE9Bb2dJQ0FnTHk4Z1pHVnNJSE5sYkdZdVkyVnVjM1Z6VzJ0bGVWMEtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG94TWpFS0lDQWdJQzh2SUhObGJHWXViM0puWVc1cGVtRjBhVzl1YzF0dmNtZGZhV1F1WVhOZmRXbHVkRFkwS0NsZExtMWxiV0psY2w5amIzVnVkQzVoYzE5MWFXNTBOalFvS1NBdElERUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkSE1nTkRRZ05Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qRXlNQzB4TWpJS0lDQWdJQzh2SUhObGJHWXViM0puWVc1cGVtRjBhVzl1YzF0dmNtZGZhV1F1WVhOZmRXbHVkRFkwS0NsZExtMWxiV0psY2w5amIzVnVkQ0E5SUdGeVl6UXVWVWx1ZERNeUtBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZdWIzSm5ZVzVwZW1GMGFXOXVjMXR2Y21kZmFXUXVZWE5mZFdsdWREWTBLQ2xkTG0xbGJXSmxjbDlqYjNWdWRDNWhjMTkxYVc1ME5qUW9LU0F0SURFS0lDQWdJQzh2SUNrS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZbWwwYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdWNGRISmhZM1FnTkNBMENpQWdJQ0J3ZFhOb2FXNTBJRFEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY21Wd2JHRmpaU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUb3hNVEVLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaGhaR1J5WlhOelpYTXViR1Z1WjNSb0tUb0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURFS0lDQWdJR0lnY21WdGIzWmxYMlp5YjIxZlkyVnVjM1Z6WDJadmNsOW9aV0ZrWlhKQU1nb0tjbVZ0YjNabFgyWnliMjFmWTJWdWMzVnpYMkZtZEdWeVgyWnZja0ExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE1EUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMExrUmxiVzlqYUdGcGJpNXBjMTlwYmw5alpXNXpkWE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGMxOXBibDlqWlc1emRYTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPakV5TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qRXlOZ29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UW05dmJDaERaVzV6ZFhOSlpDaHZjbWRmYVdRc0lHRmtaSEpsYzNNcElHbHVJSE5sYkdZdVkyVnVjM1Z6S1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKamMxOGlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE1qUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHTnZiblJ5WVdOMExrUmxiVzlqYUdGcGJpNWpjbVZoZEdWZmNISnZjRzl6WVd4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdWZmNISnZjRzl6WVd3NkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG94TWpnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDb0tJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ21OeVpXRjBaVjl3Y205d2IzTmhiRjltYjNKZmFHVmhaR1Z5UURFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qRXlPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUExQ2lBZ0lDQThDaUFnSUNCaWVpQmpjbVZoZEdWZmNISnZjRzl6WVd4ZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJR1JwWnlBekNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRGNLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJtYjNJZ0tHeGxiaXNvYkdWdUszVjBaamhiWFNsYlhTa0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1luVnllU0ExQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlHTnlaV0YwWlY5d2NtOXdiM05oYkY5bWIzSmZhR1ZoWkdWeVFERUtDbU55WldGMFpWOXdjbTl3YjNOaGJGOWhablJsY2w5bWIzSkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WTJoaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TVRJNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0K0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UVUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUyQ2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk1UTTRDaUFnSUNBdkx5QnpaV3htTGw5aGMzTmxjblJmYVc1ZlkyVnVjM1Z6S0c5eVoxOXBaQ2tLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdZMkZzYkhOMVlpQmZZWE56WlhKMFgybHVYMk5sYm5OMWN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUb3hOREFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnViM1FnYzJWc1ppNWZhWE5mWW14aGJtc29kR2wwYkdVcExDQWljSEp2Y0c5ellXd3VaVzF3ZEhrdGRHbDBiR1VpQ2lBZ0lDQmthV2NnT1FvZ0lDQWdZMkZzYkhOMVlpQmZhWE5mWW14aGJtc0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ3Y205d2IzTmhiQzVsYlhCMGVTMTBhWFJzWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE5ERUtJQ0FnSUM4dklHRnpjMlZ5ZENCdWIzUWdjMlZzWmk1ZmFYTmZZbXhoYm1zb1pHVnpZM0pwY0hScGIyNHBMQ0FpY0hKdmNHOXpZV3d1Wlcxd2RIa3RaR1Z6WTNKcGNIUnBiMjRpQ2lBZ0lDQmthV2NnTndvZ0lDQWdZMkZzYkhOMVlpQmZhWE5mWW14aGJtc0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ3Y205d2IzTmhiQzVsYlhCMGVTMWtaWE5qY21sd2RHbHZiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG94TkRJS0lDQWdJQzh2SUdGemMyVnlkQ0J2Y0hScGIyNXpMbXhsYm1kMGFDQStQU0F5TENBaWNISnZjRzl6WVd3dWRHOXZMV1psZHkxdmNIUnBiMjV6SWdvZ0lDQWdaR2xuSURRS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklIQnliM0J2YzJGc0xuUnZieTFtWlhjdGIzQjBhVzl1Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE5EY0tJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNodmNIUnBiMjV6TG14bGJtZDBhQ2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0F4TWdvS1kzSmxZWFJsWDNCeWIzQnZjMkZzWDJadmNsOW9aV0ZrWlhKQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZZMmhoYVc0dlkyOXVkSEpoWTNRdWNIazZNVFEzQ2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9iM0IwYVc5dWN5NXNaVzVuZEdncE9nb2dJQ0FnWkdsbklERXhDaUFnSUNCa2FXY2dOUW9nSUNBZ1BBb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTBDaUFnSUNCaWVpQmpjbVZoZEdWZmNISnZjRzl6WVd4ZllXWjBaWEpmWm05eVFEa0tJQ0FnSUdScFp5QXhNZ29nSUNBZ1lYTnpaWEowSUM4dklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdScFp5QXhNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pIVndNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG94TkRnS0lDQWdJQzh2SUdGemMyVnlkQ0J1YjNRZ2MyVnNaaTVmYVhOZllteGhibXNvYjNCMGFXOXVjMXRwWFNrc0lDSndjbTl3YjNOaGJDNWxiWEIwZVMxdmNIUnBiMjV6SWdvZ0lDQWdZMkZzYkhOMVlpQmZhWE5mWW14aGJtc0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ3Y205d2IzTmhiQzVsYlhCMGVTMXZjSFJwYjI1ekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qRTBOd29nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtHOXdkR2x2Ym5NdWJHVnVaM1JvS1RvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREV5Q2lBZ0lDQmlJR055WldGMFpWOXdjbTl3YjNOaGJGOW1iM0pmYUdWaFpHVnlRRFlLQ21OeVpXRjBaVjl3Y205d2IzTmhiRjloWm5SbGNsOW1iM0pBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk1UVXdDaUFnSUNBdkx5QnpaV3htTG5CeWIzQnZjMkZzWDJsa0lDczlJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndjbTl3YjNOaGJGOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2NtOXdiM05oYkY5cFpDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndjbTl3YjNOaGJGOXBaQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE5USXRNVFU1Q2lBZ0lDQXZMeUJ6Wld4bUxuQnliM0J2YzJGc2MxdHpaV3htTG5CeWIzQnZjMkZzWDJsa1hTQTlJRkJ5YjNCdmMyRnNLQW9nSUNBZ0x5OGdJQ0FnSUc5eVoxOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCMGFYUnNaU3dLSUNBZ0lDOHZJQ0FnSUNCa1pYTmpjbWx3ZEdsdmJpd0tJQ0FnSUM4dklDQWdJQ0J2Y0hScGIyNXpMbU52Y0hrb0tTd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGeWRGOWtZWFJsTEFvZ0lDQWdMeThnSUNBZ0lHVnVaR2x1WjE5a1lYUmxMQW9nSUNBZ0x5OGdLUW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURGbENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaHBiblFnTXpBS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QTVDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01UVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREUyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dPUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qRTFNZ29nSUNBZ0x5OGdjMlZzWmk1d2NtOXdiM05oYkhOYmMyVnNaaTV3Y205d2IzTmhiRjlwWkYwZ1BTQlFjbTl3YjNOaGJDZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luQnlYeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk1UVXlMVEUxT1FvZ0lDQWdMeThnYzJWc1ppNXdjbTl3YjNOaGJITmJjMlZzWmk1d2NtOXdiM05oYkY5cFpGMGdQU0JRY205d2IzTmhiQ2dLSUNBZ0lDOHZJQ0FnSUNCdmNtZGZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ2RHbDBiR1VzQ2lBZ0lDQXZMeUFnSUNBZ1pHVnpZM0pwY0hScGIyNHNDaUFnSUNBdkx5QWdJQ0FnYjNCMGFXOXVjeTVqYjNCNUtDa3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGNuUmZaR0YwWlN3S0lDQWdJQzh2SUNBZ0lDQmxibVJwYm1kZlpHRjBaU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WTJoaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TVRZeENpQWdJQ0F2THlCelpXeG1MbUZ3Y0hKdmRtRnNYM1JoYkd4cFpYTmJjMlZzWmk1d2NtOXdiM05oYkY5cFpGMGdQU0JCY0hCeWIzWmhiRlJoYkd4NUtHRnlZelF1VlVsdWRETXlLREFwTENCaGNtTTBMbFZKYm5Rek1pZ3dLU2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbUYwWHlJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZZMmhoYVc0dlkyOXVkSEpoWTNRdWNIazZNVEk0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkQzVFWlcxdlkyaGhhVzR1WTJGemRGOWhjSEJ5YjNaaGJGOTJiM1JsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyRnpkRjloY0hCeWIzWmhiRjkyYjNSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUb3hOalVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qRTJOd29nSUNBZ0x5OGdjMlZzWmk1ZllYTnpaWEowWDNCeWIzQnZjMkZzWDJWNGFYTjBjeWh3Y205d2IzTmhiRjlwWkNrS0lDQWdJR1JwWnlBeENpQWdJQ0JqWVd4c2MzVmlJRjloYzNObGNuUmZjSEp2Y0c5ellXeGZaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qRTJPUW9nSUNBZ0x5OGdjSEp2Y0c5ellXd2dQU0J6Wld4bUxuQnliM0J2YzJGc2MxdHdjbTl3YjNOaGJGOXBaQzVoYzE5MWFXNTBOalFvS1YwdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZblJ2YVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY0hKZklnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG94TmprdE1UY3dDaUFnSUNBdkx5QndjbTl3YjNOaGJDQTlJSE5sYkdZdWNISnZjRzl6WVd4elczQnliM0J2YzJGc1gybGtMbUZ6WDNWcGJuUTJOQ2dwWFM1amIzQjVLQ2tLSUNBZ0lDOHZJSE5sYkdZdVgyRnpjMlZ5ZEY5cGJsOWpaVzV6ZFhNb2NISnZjRzl6WVd3dWIzSm5YMmxrS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WTJoaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TVRjd0NpQWdJQ0F2THlCelpXeG1MbDloYzNObGNuUmZhVzVmWTJWdWMzVnpLSEJ5YjNCdmMyRnNMbTl5WjE5cFpDa0tJQ0FnSUdOaGJHeHpkV0lnWDJGemMyVnlkRjlwYmw5alpXNXpkWE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WTJoaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TVRjMUNpQWdJQ0F2THlCaVlXeHNiM1JmYVdRZ1BTQkNZV3hzYjNSSlpDaGhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0lIQnliM0J2YzJGc1gybGtLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk1UYzJDaUFnSUNBdkx5QmhjM05sY25RZ1ltRnNiRzkwWDJsa0lHNXZkQ0JwYmlCelpXeG1MbUZ3Y0hKdmRtRnNYMkpoYkd4dmRITXNJQ0p3Y205d2IzTmhiQzVoYkhKbFlXUjVMWFp2ZEdWa0lnb2dJQ0FnY0hWemFHSjVkR1Z6SUNKaFlsOGlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdjSEp2Y0c5ellXd3VZV3h5WldGa2VTMTJiM1JsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRveE56Z0tJQ0FnSUM4dklITmxiR1l1WVhCd2NtOTJZV3hmWW1Gc2JHOTBjMXRpWVd4c2IzUmZhV1JkSUQwZ1lYQndjbTkyWlFvZ0lDQWdaR2xuSURJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZZMmhoYVc0dlkyOXVkSEpoWTNRdWNIazZNVGd3Q2lBZ0lDQXZMeUIwWVd4c2VTQTlJSE5sYkdZdVlYQndjbTkyWVd4ZmRHRnNiR2xsYzF0d2NtOXdiM05oYkY5cFpDNWhjMTkxYVc1ME5qUW9LVjB1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZeUEzSUM4dklDSmhkRjhpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVhCd2NtOTJZV3hmZEdGc2JHbGxjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk1UZ3lDaUFnSUNBdkx5QnBaaUJoY0hCeWIzWmxMbTVoZEdsMlpUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNklHTmhjM1JmWVhCd2NtOTJZV3hmZG05MFpWOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk1UZ3pDaUFnSUNBdkx5QnpaV3htTG1Gd2NISnZkbUZzWDNSaGJHeHBaWE5iY0hKdmNHOXpZV3hmYVdRdVlYTmZkV2x1ZERZMEtDbGRMblp2ZEdWelgyWnZjaUE5SUdGeVl6UXVWVWx1ZERNeUtIUmhiR3g1TG5admRHVnpYMlp2Y2k1aGMxOTFhVzUwTmpRb0tTQXJJREVwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXpNZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZbWwwYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdWNGRISmhZM1FnTkNBMENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0NtTmhjM1JmWVhCd2NtOTJZV3hmZG05MFpWOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qRTROUW9nSUNBZ0x5OGdjMlZzWmk1aGNIQnliM1poYkY5MFlXeHNhV1Z6VzNCeWIzQnZjMkZzWDJsa0xtRnpYM1ZwYm5RMk5DZ3BYUzUwYjNSaGJGOTJiM1JsY3lBOUlHRnlZelF1VlVsdWRETXlLSFJoYkd4NUxuUnZkR0ZzWDNadmRHVnpMbUZ6WDNWcGJuUTJOQ2dwSUNzZ01Ta0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF6TWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW1sMGJHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHVjRkSEpoWTNRZ05DQTBDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qRTJOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUXVSR1Z0YjJOb1lXbHVMbU5oYzNSZlpXeGxZM1JwYjI1ZmRtOTBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OaGMzUmZaV3hsWTNScGIyNWZkbTkwWlRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaSFZ3YmlBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qRTROd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUb3hPVE1LSUNBZ0lDOHZJSE5sYkdZdVgyRnpjMlZ5ZEY5d2NtOXdiM05oYkY5bGVHbHpkSE1vY0hKdmNHOXpZV3hmYVdRcENpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdYMkZ6YzJWeWRGOXdjbTl3YjNOaGJGOWxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk1UazFDaUFnSUNBdkx5QndjbTl3YjNOaGJDQTlJSE5sYkdZdWNISnZjRzl6WVd4elczQnliM0J2YzJGc1gybGtMbUZ6WDNWcGJuUTJOQ2dwWFM1amIzQjVLQ2tLSUNBZ0lHSjBiMmtLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkJ5WHlJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG94T1RVdE1UazJDaUFnSUNBdkx5QndjbTl3YjNOaGJDQTlJSE5sYkdZdWNISnZjRzl6WVd4elczQnliM0J2YzJGc1gybGtMbUZ6WDNWcGJuUTJOQ2dwWFM1amIzQjVLQ2tLSUNBZ0lDOHZJSE5sYkdZdVgyRnpjMlZ5ZEY5cGJsOWpaVzV6ZFhNb2NISnZjRzl6WVd3dWIzSm5YMmxrS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG94T1RZS0lDQWdJQzh2SUhObGJHWXVYMkZ6YzJWeWRGOXBibDlqWlc1emRYTW9jSEp2Y0c5ellXd3ViM0puWDJsa0tRb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJRjloYzNObGNuUmZhVzVmWTJWdWMzVnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPakU1T0FvZ0lDQWdMeThnWVhOelpYSjBJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lENDlJSEJ5YjNCdmMyRnNMbk4wWVhKMGFXNW5YMlJoZEdVdVlYTmZkV2x1ZERZMEtDa3NJQ0psYkdWamRHbHZiaTV1YjNRdGMzUmhjblJsWkNJS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBjeUF4TkNBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1luUnZhUW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGJHVmpkR2x2Ymk1dWIzUXRjM1JoY25SbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUb3hPVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBOElIQnliM0J2YzJGc0xtVnVaR2x1WjE5a1lYUmxMbUZ6WDNWcGJuUTJOQ2dwTENBaVpXeGxZM1JwYjI0dVpXNWtaV1FpQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhCMWMyaHBiblJ6SURJeUlEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQThDaUFnSUNCaGMzTmxjblFnTHk4Z1pXeGxZM1JwYjI0dVpXNWtaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WTJoaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TWpFNENpQWdJQ0F2THlCMFlXeHNlU0E5SUhObGJHWXVZWEJ3Y205MllXeGZkR0ZzYkdsbGMxdHdjbTl3YjNOaGJGOXBaQzVoYzE5MWFXNTBOalFvS1YwdVkyOXdlU2dwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0poZEY4aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlYQndjbTkyWVd4ZmRHRnNiR2xsY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZZMmhoYVc0dlkyOXVkSEpoWTNRdWNIazZNakU1Q2lBZ0lDQXZMeUJ2Y21jZ1BTQnpaV3htTG05eVoyRnVhWHBoZEdsdmJuTmJiM0puWDJsa0xtRnpYM1ZwYm5RMk5DZ3BYUzVqYjNCNUtDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdKMGIya0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOXlaMThpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk1qSXhDaUFnSUNBdkx5QjBiM1JoYkY5MmIzUmxjeUE5SUhSaGJHeDVMblJ2ZEdGc1gzWnZkR1Z6TG1GelgzVnBiblEyTkNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF6TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRveU1qSUtJQ0FnSUM4dklHMWxiV0psY2w5amIzVnVkQ0E5SUc5eVp5NXRaVzFpWlhKZlkyOTFiblF1WVhOZmRXbHVkRFkwS0NrS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUnpJRFEwSURRS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPakl5TkFvZ0lDQWdMeThnZEc5MFlXd2dQU0IwYjNSaGJGOTJiM1JsY3lCcFppQjBiM1JoYkY5MmIzUmxjeUErSUcxbGJXSmxjbDlqYjNWdWRDQmxiSE5sSUcxbGJXSmxjbDlqYjNWdWRBb2dJQ0FnWkhWd01nb2dJQ0FnUGdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRveU1qWUtJQ0FnSUM4dklHRndjSEp2ZG1Gc1gzWnZkR1Z6SUQwZ2RHRnNiSGt1ZG05MFpYTmZabTl5TG1GelgzVnBiblEyTkNncENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTXpJS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk1qSTRDaUFnSUNBdkx5QnlaV0ZqYUdWa1gzRjFiM0oxYlNBOUlIUnZkR0ZzSUQ0Z01DQmhibVFnUVZCUVVrOVdRVXhmVVZWUFVsVk5YMFJGVGlBcUlHRndjSEp2ZG1Gc1gzWnZkR1Z6SUQ0OUlFRlFVRkpQVmtGTVgxRlZUMUpWVFY5T1ZVMGdLaUIwYjNSaGJBb2dJQ0FnWW5vZ1kyRnpkRjlsYkdWamRHbHZibDkyYjNSbFgySnZiMnhmWm1Gc2MyVkFNVE1LSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnWkdsbklERUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQmthV2NnTXdvZ0lDQWdLZ29nSUNBZ1BqMEtJQ0FnSUdKNklHTmhjM1JmWld4bFkzUnBiMjVmZG05MFpWOWliMjlzWDJaaGJITmxRREV6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LWTJGemRGOWxiR1ZqZEdsdmJsOTJiM1JsWDJKdmIyeGZiV1Z5WjJWQU1UUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPakl6TUFvZ0lDQWdMeThnWVhOelpYSjBJSEpsWVdOb1pXUmZjWFZ2Y25WdExDQWljSEp2Y0c5ellXd3VibTkwTFdGalkyVndkR1ZrSWdvZ0lDQWdZWE56WlhKMElDOHZJSEJ5YjNCdmMyRnNMbTV2ZEMxaFkyTmxjSFJsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRveU1ETUtJQ0FnSUM4dklIQnliM0J2YzJGc1gzWnZkR1VnUFNCQ1lXeHNiM1JKWkNoaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzSUhCeWIzQnZjMkZzWDJsa0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUb3lNRFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQndjbTl3YjNOaGJGOTJiM1JsSUc1dmRDQnBiaUJ6Wld4bUxtVnNaV04wYVc5dVgySmhiR3h2ZEhNc0lDSmxiR1ZqZEdsdmJpNWhiSEpsWVdSNUxYWnZkR1ZrSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0psWWw4aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdaV3hsWTNScGIyNHVZV3h5WldGa2VTMTJiM1JsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRveU1EWUtJQ0FnSUM4dklHNGdQU0J3Y205d2IzTmhiQzV2Y0hScGIyNXpMbXhsYm1kMGFBb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qSXdOd29nSUNBZ0x5OGdZWE56WlhKMElIQnlaV1psY21WdVkyVmZiM0prWlhJdWJHVnVaM1JvSUQwOUlHNHNJQ0psYkdWamRHbHZiaTV0YVhOemFXNW5MVzl3ZEdsdmJuTWlDaUFnSUNCa2FXY2dOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGJHVmpkR2x2Ymk1dGFYTnphVzVuTFc5d2RHbHZibk1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaVzF2WTJoaGFXNHZZMjl1ZEhKaFkzUXVjSGs2TWpBNUNpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvYmlrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZblZ5ZVNBeE1Bb0tZMkZ6ZEY5bGJHVmpkR2x2Ymw5MmIzUmxYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk1qQTVDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2JpazZDaUFnSUNCa2FXY2dPUW9nSUNBZ1pHbG5JRGdLSUNBZ0lEd0tJQ0FnSUdKNklHTmhjM1JmWld4bFkzUnBiMjVmZG05MFpWOWhablJsY2w5bWIzSkFPUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG95TVRBS0lDQWdJQzh2SUdGemMyVnlkQ0J3Y21WbVpYSmxibU5sWDI5eVpHVnlXMmxkTG1GelgzVnBiblEyTkNncElEd2diaXdnSW1Wc1pXTjBhVzl1TG0xcGMzTnBibWN0YjNCMGFXOXVjeUlLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF4TVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZFhKNUlERTBDaUFnSUNCa2FXY2dNUW9nSUNBZ1oyVjBZbmwwWlFvZ0lDQWdaR2xuSURrS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxiR1ZqZEdsdmJpNXRhWE56YVc1bkxXOXdkR2x2Ym5NS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk1qRXlDaUFnSUNBdkx5Qm1iM0lnYWlCcGJpQjFjbUZ1WjJVb2FTQXJJREVzSUc0cE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0E0Q2lBZ0lDQmlkWEo1SURrS0NtTmhjM1JmWld4bFkzUnBiMjVmZG05MFpWOW1iM0pmYUdWaFpHVnlRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjJOb1lXbHVMMk52Ym5SeVlXTjBMbkI1T2pJeE1nb2dJQ0FnTHk4Z1ptOXlJR29nYVc0Z2RYSmhibWRsS0drZ0t5QXhMQ0J1S1RvS0lDQWdJR1JwWnlBNENpQWdJQ0JrYVdjZ09Bb2dJQ0FnUEFvZ0lDQWdZbm9nWTJGemRGOWxiR1ZqZEdsdmJsOTJiM1JsWDJGbWRHVnlYMlp2Y2tBM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qSXhNd29nSUNBZ0x5OGdZWE56WlhKMElIQnlaV1psY21WdVkyVmZiM0prWlhKYmFWMGdJVDBnY0hKbFptVnlaVzVqWlY5dmNtUmxjbHRxWFN3Z0ltVnNaV04wYVc5dUxtMXBjM05wYm1jdGIzQjBhVzl1Y3lJS0lDQWdJR1JwWnlBeE1nb2dJQ0FnWkdsbklEa0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JREV6Q2lBZ0lDQmlJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxiR1ZqZEdsdmJpNXRhWE56YVc1bkxXOXdkR2x2Ym5NS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWlcxdlkyaGhhVzR2WTI5dWRISmhZM1F1Y0hrNk1qRXlDaUFnSUNBdkx5Qm1iM0lnYWlCcGJpQjFjbUZ1WjJVb2FTQXJJREVzSUc0cE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnT1FvZ0lDQWdZaUJqWVhOMFgyVnNaV04wYVc5dVgzWnZkR1ZmWm05eVgyaGxZV1JsY2tBMENncGpZWE4wWDJWc1pXTjBhVzl1WDNadmRHVmZZV1owWlhKZlptOXlRRGM2Q2lBZ0lDQmthV2NnTmdvZ0lDQWdZblZ5ZVNBeE1Bb2dJQ0FnWWlCallYTjBYMlZzWldOMGFXOXVYM1p2ZEdWZlptOXlYMmhsWVdSbGNrQXlDZ3BqWVhOMFgyVnNaV04wYVc5dVgzWnZkR1ZmWVdaMFpYSmZabTl5UURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qSXhOUW9nSUNBZ0x5OGdjMlZzWmk1bGJHVmpkR2x2Ymw5aVlXeHNiM1J6VzNCeWIzQnZjMkZzWDNadmRHVmRJRDBnY0hKbFptVnlaVzVqWlY5dmNtUmxjaTVqYjNCNUtDa0tJQ0FnSUdScFp5QXhNQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHUnBaeUExQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qRTROd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwallYTjBYMlZzWldOMGFXOXVYM1p2ZEdWZlltOXZiRjltWVd4elpVQXhNem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHTmhjM1JmWld4bFkzUnBiMjVmZG05MFpWOWliMjlzWDIxbGNtZGxRREUwQ2dvS0x5OGdZMjl1ZEhKaFkzUXVSR1Z0YjJOb1lXbHVMbDloYzNObGNuUmZjSEp2Y0c5ellXeGZaWGhwYzNSektIQnliM0J2YzJGc1gybGtPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tYMkZ6YzJWeWRGOXdjbTl3YjNOaGJGOWxlR2x6ZEhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qSXpNZ29nSUNBZ0x5OGdaR1ZtSUY5aGMzTmxjblJmY0hKdmNHOXpZV3hmWlhocGMzUnpLSE5sYkdZc0lIQnliM0J2YzJGc1gybGtPaUJoY21NMExsVkpiblEyTkNrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG95TXpNS0lDQWdJQzh2SUdGemMyVnlkQ0J3Y205d2IzTmhiRjlwWkM1aGMxOTFhVzUwTmpRb0tTQnBiaUJ6Wld4bUxuQnliM0J2YzJGc2N5d2dJbkJ5YjNCdmMyRnNMbTV2ZEMxbWIzVnVaQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1luUnZhUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTWlBdkx5QWljSEpmSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QndjbTl3YjNOaGJDNXViM1F0Wm05MWJtUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklHTnZiblJ5WVdOMExrUmxiVzlqYUdGcGJpNWZZWE56WlhKMFgyOXlaMTlsZUdsemRITW9iM0puWDJsa09pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1gyRnpjMlZ5ZEY5dmNtZGZaWGhwYzNSek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUb3lNelVLSUNBZ0lDOHZJR1JsWmlCZllYTnpaWEowWDI5eVoxOWxlR2x6ZEhNb2MyVnNaaXdnYjNKblgybGtPaUJoY21NMExsVkpiblEyTkNrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG95TXpZS0lDQWdJQzh2SUdGemMyVnlkQ0J2Y21kZmFXUXVZWE5mZFdsdWREWTBLQ2tnYVc0Z2MyVnNaaTV2Y21kaGJtbDZZWFJwYjI1ekxDQWliM0puTG01dmRDMW1iM1Z1WkNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZblJ2YVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYjNKblh5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnYjNKbkxtNXZkQzFtYjNWdVpBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1kyOXVkSEpoWTNRdVJHVnRiMk5vWVdsdUxsOWhjM05sY25SZmFYTmZiM0puWVc1cGVtVnlLRzl5WjE5cFpEb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNsOWhjM05sY25SZmFYTmZiM0puWVc1cGVtVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG95TXpnS0lDQWdJQzh2SUdSbFppQmZZWE56WlhKMFgybHpYMjl5WjJGdWFYcGxjaWh6Wld4bUxDQnZjbWRmYVdRNklHRnlZelF1VlVsdWREWTBLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qSXpPUW9nSUNBZ0x5OGdjMlZzWmk1ZllYTnpaWEowWDI5eVoxOWxlR2x6ZEhNb2IzSm5YMmxrS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOWhjM05sY25SZmIzSm5YMlY0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUb3lOREVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrZ1BUMGdjMlZzWmk1dmNtZGhibWw2WVhScGIyNXpXMjl5WjE5cFpDNWhjMTkxYVc1ME5qUW9LVjB1YjNKbllXNXBlbVZ5TENBaWIzSm5MblZ1WVhWMGFHOXlhWHBsWkNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1luUnZhUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QWliM0puWHlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2Y21jdWRXNWhkWFJvYjNKcGVtVmtDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmpiMjUwY21GamRDNUVaVzF2WTJoaGFXNHVYMkZ6YzJWeWRGOXBibDlqWlc1emRYTW9iM0puWDJsa09pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1gyRnpjMlZ5ZEY5cGJsOWpaVzV6ZFhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qSTBNd29nSUNBZ0x5OGdaR1ZtSUY5aGMzTmxjblJmYVc1ZlkyVnVjM1Z6S0hObGJHWXNJRzl5WjE5cFpEb2dZWEpqTkM1VlNXNTBOalFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXMXZZMmhoYVc0dlkyOXVkSEpoWTNRdWNIazZNalEwQ2lBZ0lDQXZMeUJ6Wld4bUxsOWhjM05sY25SZmIzSm5YMlY0YVhOMGN5aHZjbWRmYVdRcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdYMkZ6YzJWeWRGOXZjbWRmWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPakkwTmdvZ0lDQWdMeThnWVhOelpYSjBJRU5sYm5OMWMwbGtLRzl5WjE5cFpDd2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcEtTQnBiaUJ6Wld4bUxtTmxibk4xY3l3Z0ltOXlaeTVqWlc1emRYTXVkVzVoZFhSb2IzSnBlbVZrSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU56WHlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM0puTG1ObGJuTjFjeTUxYm1GMWRHaHZjbWw2WldRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdOdmJuUnlZV04wTGtSbGJXOWphR0ZwYmk1ZmFYTmZZbXhoYm1zb2N6b2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Eb0tYMmx6WDJKc1lXNXJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiVzlqYUdGcGJpOWpiMjUwY21GamRDNXdlVG95TkRnS0lDQWdJQzh2SUdSbFppQmZhWE5mWW14aGJtc29jMlZzWml3Z2N6b2dZWEpqTkM1VGRISnBibWNwSUMwK0lHSnZiMnc2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUb3lORGtLSUNBZ0lDOHZJR0lnUFNCekxtNWhkR2wyWlM1aWVYUmxjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qSTFNUW9nSUNBZ0x5OGdhV1lnWWk1c1pXNW5kR2dnUFQwZ01Eb0tJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0JpYm5vZ1gybHpYMkpzWVc1clgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRveU5USUtJQ0FnSUM4dklISmxkSFZ5YmlCVWNuVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDbDlwYzE5aWJHRnVhMTloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnRiMk5vWVdsdUwyTnZiblJ5WVdOMExuQjVPakkxTkFvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLR0l1YkdWdVozUm9LVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtDbDlwYzE5aWJHRnVhMTltYjNKZmFHVmhaR1Z5UURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qSTFOQW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtHSXViR1Z1WjNSb0tUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2dYMmx6WDJKc1lXNXJYMkZtZEdWeVgyWnZja0E0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1Z0YjJOb1lXbHVMMk52Ym5SeVlXTjBMbkI1T2pJMU5Rb2dJQ0FnTHk4Z2FXWWdiM0F1WjJWMFlubDBaU2hpTENCcEtTQWhQU0F6TWpvS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1oyVjBZbmwwWlFvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQWhQUW9nSUNBZ1lub2dYMmx6WDJKc1lXNXJYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJXOWphR0ZwYmk5amIyNTBjbUZqZEM1d2VUb3lOVFlLSUNBZ0lDOHZJSEpsZEhWeWJpQkdZV3h6WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwZmFYTmZZbXhoYm10ZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYlc5amFHRnBiaTlqYjI1MGNtRmpkQzV3ZVRveU5UUUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoaUxteGxibWQwYUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWWlCZmFYTmZZbXhoYm10ZlptOXlYMmhsWVdSbGNrQXpDZ3BmYVhOZllteGhibXRmWVdaMFpYSmZabTl5UURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWdGIyTm9ZV2x1TDJOdmJuUnlZV04wTG5CNU9qSTFPQW9nSUNBZ0x5OGdjbVYwZFhKdUlGUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNJQ1lJQkc5eVoxOERZM05mQTNCeVh3dHdjbTl3YjNOaGJGOXBaQVp2Y21kZmFXUUJnQVFWSDN4MUEyRjBYekVZUUFBSEt5Sm5Kd1FpWnpFYlFRQkFNUmtVUkRFWVJJSUhCSjV4cjJjRUhlQnNXZ1RtaUJtWkJQSHcwUDBFSDhrQTdnU0FCQWhqQktEWVdDODJHZ0NPQndBSkFJNEJCZ0dFQWFvQzFBTkxBREVaRkRFWUZCQkROaG9CU1NKWkpBaExBUlZKVHdJU1JEWWFBa2tpV1NRSVN3RVZFa1JMQW9nRWRSUkVTWWdFYnhSRWdBTnZibDlMQTFCSnZVVUJGRVFpSndSbFJDTUlKd1JMQVdjV01RQkxBWUFDQURCUWdUQlBCZ2dXVndZQ1VFeFFnQVFBQUFBQlVFOEVVRThEVUNoTEFsQkp2RWhNdjB3bkJiOUpNUUJRS1V4UUp3Vy9Kd1pNVUxBalF6WWFBVWNDRllFSUVrUTJHZ0pKVGdKSklsbEpUZ05KSlFza0NFOENGUkpFZ1FjT1JJZ0R2aUpKU3dJTVFRQkhTd0pYQWdCTEFVbE9BaVVMSlZoSk1nTVRSRXNGU1U4Q1VDbE1VRW05UlFFVVJDY0Z2eGNXS0V4UVNZTUNMQVM2RnlNSUZrbVRKUTVFVndRRWdTeE11eU1JUlFGQy83SWpRellhQVVjQ0ZZRUlFa1EyR2dKSlRnSkpJbGxKVGdOSkpRc2tDRThDRlJKRWdRY09SRW1JQTBVWEZpaE1VQ0pKU3dNTVFRQkhTd05YQWdCTEFVbE9BaVVMSlZoTEJrc0JVRXNFU1U0RGdRd2x1azhDRTBRcFRGQkp2VVVCUkx4SVNZTUNMQVM2RnlNSkZrbVRKUTVFVndRRWdTeE11eU1JUlFGQy83SWpRellhQVVrVmdRZ1NSRFlhQWtrVkpSSkVVQ2xNVUwxRkFZQUJBQ0pQQWxRbkJreFFzQ05ESWttQUFFazJHZ0ZKRllFSUVrUTJHZ0pIQWlKWkpBaE1GVWxQQWhKRU5ob0RSd0lpV1NRSVRCVkpUd0lTUkRZYUJFY0NJbGxKVGdJa0MweEpGVXhYQWdBaVNVc0ZERUVBSkVjQ0pBdExBMGxQQWxsSlN3ZEpUZ1FTUkVzQkZWSWlXU1FJQ0VVRkl3aEZBVUwvMVVzREpBaExBeEpFTmhvRlNVVVBGWUVJRWtRMkdnWkpSUkFWZ1FnU1JFc0tpQUpSU3dtSUFtRVVSRXNIaUFKYUZFUkxCQ1FQUkNKRkRFc0xTd1VNU1VVT1FRQWZTd3hFU3d0SkpBdExBMGxQQWxsS1dTUUlXSWdDTHhSRUl3aEZERUwvMWlJclpVUWpDQ3RMQVdkTEM0QUNBQjVRZ1I1TEN3aEpGbGNHQWs4Q1RGQk1Td2tJRmxjR0FsQkxEMUJMRUZCTEMxQkxDVkJMQjFCTUZpcExBVkJKdkVoUEFyOG5CMHNCVUlBSUFBQUFBQUFBQUFDL0p3Wk1VTEFqUXpZYUFVa1ZnUWdTUkRZYUFra1ZJeEpFU3dHSUFXdExBUmNXS2tzQlVDS0JDTHFJQVpJeEFFOERVSUFEWVdKZlRGQkp2VVVCRkVSTEFyOG5CMHhRU1U0Q3ZreE9Ba1FpVTBFQUZFa2lXaU1JRmttVEpRNUVWd1FFU3dJaVR3SzdTWUVFV2lNSUZrbVRKUTVFVndRRVN3S0JCRThDdXlORElrY0NnQUJIQXpZYUFVY0NGWUVJRWtRMkdnSkpUZ0pKSWxsSlRnTWtDRXdWRWtSSmlBRGpGeFlxU3dGUVNVNENTU0tCQ0xwSmlBRUhNZ2RMQW9NQ0RnaTZGdzlFTWdkUEFvTUNGZ2k2Rnd4RUp3ZFBBbEMrUkV3WEZpaE1VRXNCZ1FSYVRJTUNMQVM2RjBvTlRFNENUVWxQQWlKYVRFRUFqWUVEU3dFTEpFc0RDdzlCQUlBalJERUFTd1pRZ0FObFlsOU1VRWxGREwxRkFSUkVTd0pKZ1F3a3VoY2t1aGRKUlFsTEJCSkVJa1VLU3dsTENBeEJBRU5MQkZjQ0FFbEZEa2xMQzBsT0F5TllSUTVMQVZWTENReEVJd2hKUlFoRkNVc0lTd2dNUVFBVVN3eExDVWxPQWlOWVN3MnBSQ01JUlFsQy8rUkxCa1VLUXYrMVN3cEp2RWhMQmI4alF5SkMvMzJLQVFDTC94Y1dLa3hRdlVVQlJJbUtBUUNML3hjV0tFeFF2VVVCUkltS0FRQ0wvNGovNlRFQWkvOFhGaWhNVUlFTUpib1NSSW1LQVFDTC80ai8wWXYvTVFCUUtVeFF2VVVCUkltS0FRR0FBSXYvVndJQVNSVkpRQUFFSTR3QWlTS01BSXNBaXdJTVFRQVhpd0dMQUZVbEUwRUFCQ0tNQUltTEFDTUlqQUJDLytFampBQ0oiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
