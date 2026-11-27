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

namespace Arc56.Generated.akita_protocol.akita_sc.MockGuildConsensusHost_57b7818f
{


    //
    // Test-only Guild-shaped caller for independently exercising consensus policy bytecode.
    //
    public class MockGuildConsensusHostProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockGuildConsensusHostProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GuildConsensusRequirements : AVMObjectType
            {
                public ulong Participation { get; set; }

                public ulong Approval { get; set; }

                public ulong MinimumApprovals { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vParticipation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vParticipation.From(Participation);
                    ret.AddRange(vParticipation.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApproval = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vApproval.From(Approval);
                    ret.AddRange(vApproval.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinimumApprovals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinimumApprovals.From(MinimumApprovals);
                    ret.AddRange(vMinimumApprovals.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GuildConsensusRequirements Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GuildConsensusRequirements();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vParticipation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vParticipation.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueParticipation = vParticipation.ToValue();
                    if (valueParticipation is ulong vParticipationValue) { ret.Participation = vParticipationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApproval = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vApproval.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApproval = vApproval.ToValue();
                    if (valueApproval is ulong vApprovalValue) { ret.Approval = vApprovalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinimumApprovals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinimumApprovals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinimumApprovals = vMinimumApprovals.ToValue();
                    if (valueMinimumApprovals is ulong vMinimumApprovalsValue) { ret.MinimumApprovals = vMinimumApprovalsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GuildConsensusRequirements);
                }
                public bool Equals(GuildConsensusRequirements? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GuildConsensusRequirements left, GuildConsensusRequirements right)
                {
                    return EqualityComparer<GuildConsensusRequirements>.Default.Equals(left, right);
                }
                public static bool operator !=(GuildConsensusRequirements left, GuildConsensusRequirements right)
                {
                    return !(left == right);
                }

            }

            public class GuildConsensusResult : AVMObjectType
            {
                public bool Approved { get; set; }

                public ulong Approvals { get; set; }

                public ulong Rejections { get; set; }

                public ulong Abstains { get; set; }

                public ulong EligiblePower { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApproved = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vApproved.From(Approved);
                    ret.AddRange(vApproved.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApprovals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vApprovals.From(Approvals);
                    ret.AddRange(vApprovals.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRejections = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRejections.From(Rejections);
                    ret.AddRange(vRejections.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAbstains = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAbstains.From(Abstains);
                    ret.AddRange(vAbstains.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEligiblePower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEligiblePower.From(EligiblePower);
                    ret.AddRange(vEligiblePower.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GuildConsensusResult Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GuildConsensusResult();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApproved = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vApproved.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApproved = vApproved.ToValue();
                    if (valueApproved is bool vApprovedValue) { ret.Approved = vApprovedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApprovals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vApprovals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApprovals = vApprovals.ToValue();
                    if (valueApprovals is ulong vApprovalsValue) { ret.Approvals = vApprovalsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRejections = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRejections.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRejections = vRejections.ToValue();
                    if (valueRejections is ulong vRejectionsValue) { ret.Rejections = vRejectionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAbstains = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAbstains.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAbstains = vAbstains.ToValue();
                    if (valueAbstains is ulong vAbstainsValue) { ret.Abstains = vAbstainsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEligiblePower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEligiblePower.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEligiblePower = vEligiblePower.ToValue();
                    if (valueEligiblePower is ulong vEligiblePowerValue) { ret.EligiblePower = vEligiblePowerValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GuildConsensusResult);
                }
                public bool Equals(GuildConsensusResult? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GuildConsensusResult left, GuildConsensusResult right)
                {
                    return EqualityComparer<GuildConsensusResult>.Default.Equals(left, right);
                }
                public static bool operator !=(GuildConsensusResult left, GuildConsensusResult right)
                {
                    return !(left == right);
                }

            }

            public class GuildProposalSettings : AVMObjectType
            {
                public ulong Fee { get; set; }

                public ulong Power { get; set; }

                public ulong Duration { get; set; }

                public ulong Participation { get; set; }

                public ulong Approval { get; set; }

                public ulong MinimumApprovals { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFee.From(Fee);
                    ret.AddRange(vFee.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPower.From(Power);
                    ret.AddRange(vPower.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDuration.From(Duration);
                    ret.AddRange(vDuration.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vParticipation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vParticipation.From(Participation);
                    ret.AddRange(vParticipation.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApproval = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vApproval.From(Approval);
                    ret.AddRange(vApproval.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinimumApprovals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinimumApprovals.From(MinimumApprovals);
                    ret.AddRange(vMinimumApprovals.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GuildProposalSettings Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GuildProposalSettings();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFee = vFee.ToValue();
                    if (valueFee is ulong vFeeValue) { ret.Fee = vFeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPower = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPower.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePower = vPower.ToValue();
                    if (valuePower is ulong vPowerValue) { ret.Power = vPowerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDuration.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDuration = vDuration.ToValue();
                    if (valueDuration is ulong vDurationValue) { ret.Duration = vDurationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vParticipation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vParticipation.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueParticipation = vParticipation.ToValue();
                    if (valueParticipation is ulong vParticipationValue) { ret.Participation = vParticipationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApproval = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vApproval.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApproval = vApproval.ToValue();
                    if (valueApproval is ulong vApprovalValue) { ret.Approval = vApprovalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinimumApprovals = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinimumApprovals.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinimumApprovals = vMinimumApprovals.ToValue();
                    if (valueMinimumApprovals is ulong vMinimumApprovalsValue) { ret.MinimumApprovals = vMinimumApprovalsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GuildProposalSettings);
                }
                public bool Equals(GuildProposalSettings? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GuildProposalSettings left, GuildProposalSettings right)
                {
                    return EqualityComparer<GuildProposalSettings>.Default.Equals(left, right);
                }
                public static bool operator !=(GuildProposalSettings left, GuildProposalSettings right)
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
        public async Task InitProgram(ulong size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 10, 93, 197 };
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);

            var result = await base.CallApp(new List<object> { abiHandle, sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InitProgram_Transactions(ulong size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 10, 93, 197 };
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);

            return await base.MakeTransactionList(new List<object> { abiHandle, sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="offset"> </param>
        /// <param name="data"> </param>
        public async Task LoadProgram(ulong offset, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 9, 109, 37 };
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, offsetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LoadProgram_Transactions(ulong offset, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 9, 109, 37 };
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, offsetAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create the real policy as this host's child and bind it back to this host.
        ///</summary>
        /// <param name="governanceConfig"> </param>
        public async Task<ulong> CreateConsensus(byte[] governanceConfig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 56, 41, 205 };
            var governanceConfigAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); governanceConfigAbi.From(governanceConfig);

            var result = await base.CallApp(new List<object> { abiHandle, governanceConfigAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateConsensus_Transactions(byte[] governanceConfig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 56, 41, 205 };
            var governanceConfigAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); governanceConfigAbi.From(governanceConfig);

            return await base.MakeTransactionList(new List<object> { abiHandle, governanceConfigAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ValidateActivation(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 134, 90, 97 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ValidateActivation_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 134, 90, 97 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposalID"> </param>
        /// <param name="votingEnd"> </param>
        /// <param name="requirements"> GuildConsensusRequirements</param>
        public async Task OpenProposal(ulong proposalID, ulong votingEnd, Structs.GuildConsensusRequirements requirements, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 220, 182, 121 };
            var proposalIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposalIDAbi.From(proposalID);
            var votingEndAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); votingEndAbi.From(votingEnd);

            var result = await base.CallApp(new List<object> { abiHandle, proposalIDAbi, votingEndAbi, requirements }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpenProposal_Transactions(ulong proposalID, ulong votingEnd, Structs.GuildConsensusRequirements requirements, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 220, 182, 121 };
            var proposalIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposalIDAbi.From(proposalID);
            var votingEndAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); votingEndAbi.From(votingEnd);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposalIDAbi, votingEndAbi, requirements }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="voter"> </param>
        /// <param name="proposalID"> </param>
        /// <param name="vote"> </param>
        /// <param name="evidence"> </param>
        public async Task Vote(Algorand.Address voter, ulong proposalID, byte vote, byte[] evidence, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 6, 35, 205 };
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);
            var proposalIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposalIDAbi.From(proposalID);
            var voteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); voteAbi.From(vote);
            var evidenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); evidenceAbi.From(evidence);

            var result = await base.CallApp(new List<object> { abiHandle, voterAbi, proposalIDAbi, voteAbi, evidenceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Vote_Transactions(Algorand.Address voter, ulong proposalID, byte vote, byte[] evidence, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 6, 35, 205 };
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voterAbi.From(voter);
            var proposalIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposalIDAbi.From(proposalID);
            var voteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); voteAbi.From(vote);
            var evidenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); evidenceAbi.From(evidence);

            return await base.MakeTransactionList(new List<object> { abiHandle, voterAbi, proposalIDAbi, voteAbi, evidenceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposalID"> </param>
        public async Task<Structs.GuildConsensusResult> ResolveProposal(ulong proposalID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 58, 139, 0 };
            var proposalIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposalIDAbi.From(proposalID);

            var result = await base.CallApp(new List<object> { abiHandle, proposalIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GuildConsensusResult.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ResolveProposal_Transactions(ulong proposalID, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 58, 139, 0 };
            var proposalIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposalIDAbi.From(proposalID);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposalIDAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="proposalID"> </param>
        /// <param name="voters"> </param>
        public async Task<ulong> CleanupBallot(ulong proposalID, Algorand.Address[] voters, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 232, 35, 205 };
            var proposalIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposalIDAbi.From(proposalID);
            var votersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); votersAbi.From(voters);

            var result = await base.CallApp(new List<object> { abiHandle, proposalIDAbi, votersAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CleanupBallot_Transactions(ulong proposalID, Algorand.Address[] voters, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 232, 35, 205 };
            var proposalIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposalIDAbi.From(proposalID);
            var votersAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); votersAbi.From(voters);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposalIDAbi, votersAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        /// <param name="evidence"> </param>
        /// <param name="requiredThrough"> </param>
        public async Task<ulong> ProposalPower(Algorand.Address account, byte[] evidence, ulong requiredThrough, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 235, 124, 212 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var evidenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); evidenceAbi.From(evidence);
            var requiredThroughAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); requiredThroughAbi.From(requiredThrough);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi, evidenceAbi, requiredThroughAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ProposalPower_Transactions(Algorand.Address account, byte[] evidence, ulong requiredThrough, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 235, 124, 212 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var evidenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); evidenceAbi.From(evidence);
            var requiredThroughAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); requiredThroughAbi.From(requiredThrough);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi, evidenceAbi, requiredThroughAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Quote an opaque consensus action exactly as the Guild would.
        ///</summary>
        /// <param name="data"> </param>
        public async Task<ulong> ConsensusActionMbr(byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 126, 39, 23 };
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ConsensusActionMbr_Transactions(byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 126, 39, 23 };
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Forward an opaque consensus action with its quoted MBR exactly as the Guild would for `proposalID`.
        ///</summary>
        /// <param name="proposalID"> </param>
        /// <param name="data"> </param>
        public async Task ConsensusAction(ulong proposalID, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 70, 236, 30 };
            var proposalIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposalIDAbi.From(proposalID);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, proposalIDAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ConsensusAction_Transactions(ulong proposalID, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 70, 236, 30 };
            var proposalIDAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); proposalIDAbi.From(proposalID);
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposalIDAbi, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Forward opaque draft configuration with its quoted MBR exactly as the Guild would.
        ///</summary>
        /// <param name="config"> </param>
        public async Task ConfigureConsensus(byte[] config, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 93, 138, 153 };
            var configAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); configAbi.From(config);

            var result = await base.CallApp(new List<object> { abiHandle, configAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ConfigureConsensus_Transactions(byte[] config, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 93, 138, 153 };
            var configAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); configAbi.From(config);

            return await base.MakeTransactionList(new List<object> { abiHandle, configAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja0d1aWxkQ29uc2Vuc3VzSG9zdCIsImRlc2MiOiJUZXN0LW9ubHkgR3VpbGQtc2hhcGVkIGNhbGxlciBmb3IgaW5kZXBlbmRlbnRseSBleGVyY2lzaW5nIGNvbnNlbnN1cyBwb2xpY3kgYnl0ZWNvZGUuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ikd1aWxkQ29uc2Vuc3VzUmVxdWlyZW1lbnRzIjpbeyJuYW1lIjoicGFydGljaXBhdGlvbiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhcHByb3ZhbCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtaW5pbXVtQXBwcm92YWxzIiwidHlwZSI6InVpbnQ2NCJ9XSwiR3VpbGRDb25zZW5zdXNSZXN1bHQiOlt7Im5hbWUiOiJhcHByb3ZlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiYXBwcm92YWxzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlamVjdGlvbnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWJzdGFpbnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZWxpZ2libGVQb3dlciIsInR5cGUiOiJ1aW50NjQifV0sIkd1aWxkUHJvcG9zYWxTZXR0aW5ncyI6W3sibmFtZSI6ImZlZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwb3dlciIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkdXJhdGlvbiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwYXJ0aWNpcGF0aW9uIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFwcHJvdmFsIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1pbmltdW1BcHByb3ZhbHMiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbml0UHJvZ3JhbSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaXplIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvYWRQcm9ncmFtIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9mZnNldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVDb25zZW5zdXMiLCJkZXNjIjoiQ3JlYXRlIHRoZSByZWFsIHBvbGljeSBhcyB0aGlzIGhvc3QncyBjaGlsZCBhbmQgYmluZCBpdCBiYWNrIHRvIHRoaXMgaG9zdC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZ292ZXJuYW5jZUNvbmZpZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZhbGlkYXRlQWN0aXZhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcGVuUHJvcG9zYWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90aW5nRW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR3VpbGRDb25zZW5zdXNSZXF1aXJlbWVudHMiLCJuYW1lIjoicmVxdWlyZW1lbnRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZvdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbElEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2aWRlbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlc29sdmVQcm9wb3NhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9wb3NhbElEIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iihib29sLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHdWlsZENvbnNlbnN1c1Jlc3VsdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsZWFudXBCYWxsb3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzc1tdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZXJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJvcG9zYWxQb3dlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXZpZGVuY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVpcmVkVGhyb3VnaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbnNlbnN1c0FjdGlvbk1iciIsImRlc2MiOiJRdW90ZSBhbiBvcGFxdWUgY29uc2Vuc3VzIGFjdGlvbiBleGFjdGx5IGFzIHRoZSBHdWlsZCB3b3VsZC4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbnNlbnN1c0FjdGlvbiIsImRlc2MiOiJGb3J3YXJkIGFuIG9wYXF1ZSBjb25zZW5zdXMgYWN0aW9uIHdpdGggaXRzIHF1b3RlZCBNQlIgZXhhY3RseSBhcyB0aGUgR3VpbGQgd291bGQgZm9yIGBwcm9wb3NhbElEYC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxJRCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb25maWd1cmVDb25zZW5zdXMiLCJkZXNjIjoiRm9yd2FyZCBvcGFxdWUgZHJhZnQgY29uZmlndXJhdGlvbiB3aXRoIGl0cyBxdW90ZWQgTUJSIGV4YWN0bHkgYXMgdGhlIEd1aWxkIHdvdWxkLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb25maWciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjo5fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0NjEsNDgwXSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwMCw4MzQsOTM5LDEwMTIsMTA5NCwxMjYxLDEzNTFdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU3LDcxMiw4NDcsMTE3MCwxMjczXSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI0LDY2OSw3OTUsOTExLDk4MSwxMDU5LDExNjYsMTIyNiwxMzIzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDIyLDQ0Niw3ODIsOTY1LDEwMzgsMTExMSwxMTQ2LDEyMTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFjY291bnQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDMwLDQ1Myw3OTAsMTA0NiwxMTE5LDExNTQsMTIyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjAsMTAzMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDAsNDE1LDY0Nyw2NTUsNzY4LDkwNiw5NTksMTA1NCwxMTQwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzc2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvYXJjNTgvZ3VpbGRzL2NvcmUvdHlwZXMudHM6Okd1aWxkQ29uc2Vuc3VzUmVxdWlyZW1lbnRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTQ1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9hcmM1OC9ndWlsZHMvY29yZS90eXBlcy50czo6R3VpbGRDb25zZW5zdXNSZXN1bHQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MDUsMTAxNywxMDk5LDEyNjYsMTM1Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB1aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdnTmlBME1EazJDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VWdJbU52Ym5ObGJuTjFjeUlnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREVnSW5CeWIyZHlZVzBpSURCNFlqazROalZoTmpFZ01IZzFZak5oT0dJd01DQXdlR0U1WlRneU0yTmtJREI0WXpObFlqZGpaRFFnTUhnNE5UZGxNamN4TndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TkRJdE5ETUtJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJSE4wWVhSbFZHOTBZV3h6T2lCN0lHZHNiMkpoYkVKNWRHVnpPaUE1TENCbmJHOWlZV3hWYVc1MGN6b2dNU0I5SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUVzlqYTBkMWFXeGtRMjl1YzJWdWMzVnpTRzl6ZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjZJRzFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFNVFlLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGcwWVRCaE5XUmpOU0F3ZURjeE1EazJaREkxSURCNE5ERXpPREk1WTJRZ0x5OGdiV1YwYUc5a0lDSnBibWwwVUhKdlozSmhiU2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWJHOWhaRkJ5YjJkeVlXMG9kV2x1ZERZMExHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0pqY21WaGRHVkRiMjV6Wlc1emRYTW9ZbmwwWlZ0ZEtYVnBiblEyTkNJS0lDQWdJR0o1ZEdWaklEUWdMeThnYldWMGFHOWtJQ0oyWVd4cFpHRjBaVUZqZEdsMllYUnBiMjRvS1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRPRGxrWTJJMk56a2dNSGcxT1RBMk1qTmpaQ0F2THlCdFpYUm9iMlFnSW05d1pXNVFjbTl3YjNOaGJDaDFhVzUwTmpRc2RXbHVkRFkwTENoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRtOTBaU2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwT0N4aWVYUmxXMTBwZG05cFpDSUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z2JXVjBhRzlrSUNKeVpYTnZiSFpsVUhKdmNHOXpZV3dvZFdsdWREWTBLU2hpYjI5c0xIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCaWVYUmxZeUEySUM4dklHMWxkR2h2WkNBaVkyeGxZVzUxY0VKaGJHeHZkQ2gxYVc1ME5qUXNZV1JrY21WemMxdGRLWFZwYm5RMk5DSUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z2JXVjBhRzlrSUNKd2NtOXdiM05oYkZCdmQyVnlLR0ZrWkhKbGMzTXNZbmwwWlZ0ZExIVnBiblEyTkNsMWFXNTBOalFpQ2lBZ0lDQmllWFJsWXlBNElDOHZJRzFsZEdodlpDQWlZMjl1YzJWdWMzVnpRV04wYVc5dVRXSnlLR0o1ZEdWYlhTbDFhVzUwTmpRaUNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9ETTBObVZqTVdVZ01IaGhORFZrT0dFNU9TQXZMeUJ0WlhSb2IyUWdJbU52Ym5ObGJuTjFjMEZqZEdsdmJpaDFhVzUwTmpRc1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbU52Ym1acFozVnlaVU52Ym5ObGJuTjFjeWhpZVhSbFcxMHBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHbHVhWFJRY205bmNtRnRJR3h2WVdSUWNtOW5jbUZ0SUdOeVpXRjBaVU52Ym5ObGJuTjFjeUIyWVd4cFpHRjBaVUZqZEdsMllYUnBiMjRnYjNCbGJsQnliM0J2YzJGc0lIWnZkR1VnY21WemIyeDJaVkJ5YjNCdmMyRnNJR05zWldGdWRYQkNZV3hzYjNRZ2NISnZjRzl6WVd4UWIzZGxjaUJqYjI1elpXNXpkWE5CWTNScGIyNU5ZbklnWTI5dWMyVnVjM1Z6UVdOMGFXOXVJR052Ym1acFozVnlaVU52Ym5ObGJuTjFjd29nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREUyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TkRJdE5ETUtJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJSE4wWVhSbFZHOTBZV3h6T2lCN0lHZHNiMkpoYkVKNWRHVnpPaUE1TENCbmJHOWlZV3hWYVc1MGN6b2dNU0I5SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUVzlqYTBkMWFXeGtRMjl1YzJWdWMzVnpTRzl6ZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURSak5XTTJNV0poSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxDaUFnSUNCbGNuSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pvNlRXOWphMGQxYVd4a1EyOXVjMlZ1YzNWelNHOXpkQzVqY21WaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6bzBOUzAwTndvZ0lDQWdMeThnZFhCbmNtRmtaVUZ3Y0ZCeWIzQnZjMkZzVTJWMGRHbHVaM01nUFNCSGJHOWlZV3hUZEdGMFpUeEhkV2xzWkZCeWIzQnZjMkZzVTJWMGRHbHVaM00rS0hzS0lDQWdJQzh2SUNBZ2EyVjVPaUJIZFdsc1pFZHNiMkpoYkZOMFlYUmxTMlY1VlhCbmNtRmtaVUZ3Y0ZCeWIzQnZjMkZzVTJWMGRHbHVaM01zQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0oxY0dkeVlXUmxYMkZ3Y0Y5d2N5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qZzJMVGt6Q2lBZ0lDQXZMeUJqYjI1emRDQnpaWFIwYVc1bmN6b2dSM1ZwYkdSUWNtOXdiM05oYkZObGRIUnBibWR6SUQwZ2V3b2dJQ0FnTHk4Z0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIQnZkMlZ5T2lBd0xBb2dJQ0FnTHk4Z0lDQmtkWEpoZEdsdmJqb2dNU3dLSUNBZ0lDOHZJQ0FnY0dGeWRHbGphWEJoZEdsdmJqb2dNQ3dLSUNBZ0lDOHZJQ0FnWVhCd2NtOTJZV3c2SURBc0NpQWdJQ0F2THlBZ0lHMXBibWx0ZFcxQmNIQnliM1poYkhNNklERXNDaUFnSUNBdkx5QjlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pvNU5Bb2dJQ0FnTHk4Z2RHaHBjeTUxY0dkeVlXUmxRWEJ3VUhKdmNHOXpZV3hUWlhSMGFXNW5jeTUyWVd4MVpTQTlJR05zYjI1bEtITmxkSFJwYm1kektRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QmhaR1JRYkhWbmFXNVFjbTl3YjNOaGJGTmxkSFJwYm1keklEMGdSMnh2WW1Gc1UzUmhkR1U4UjNWcGJHUlFjbTl3YjNOaGJGTmxkSFJwYm1kelBpaDdJR3RsZVRvZ1IzVnBiR1JIYkc5aVlXeFRkR0YwWlV0bGVVRmtaRkJzZFdkcGJsQnliM0J2YzJGc1UyVjBkR2x1WjNNZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVlXUmtYM0JzZFdkcGJsOXdjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxamIyNXpaVzV6ZFhNdGFHOXpkQzVoYkdkdkxuUnpPamcyTFRrekNpQWdJQ0F2THlCamIyNXpkQ0J6WlhSMGFXNW5jem9nUjNWcGJHUlFjbTl3YjNOaGJGTmxkSFJwYm1keklEMGdld29nSUNBZ0x5OGdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSEJ2ZDJWeU9pQXdMQW9nSUNBZ0x5OGdJQ0JrZFhKaGRHbHZiam9nTVN3S0lDQWdJQzh2SUNBZ2NHRnlkR2xqYVhCaGRHbHZiam9nTUN3S0lDQWdJQzh2SUNBZ1lYQndjbTkyWVd3NklEQXNDaUFnSUNBdkx5QWdJRzFwYm1sdGRXMUJjSEJ5YjNaaGJITTZJREVzQ2lBZ0lDQXZMeUI5Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6bzVOUW9nSUNBZ0x5OGdkR2hwY3k1aFpHUlFiSFZuYVc1UWNtOXdiM05oYkZObGRIUnBibWR6TG5aaGJIVmxJRDBnWTJ4dmJtVW9jMlYwZEdsdVozTXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZORGt0TlRFS0lDQWdJQzh2SUhKbGJXOTJaVVY0WldOMWRHbHZibEJ5YjNCdmMyRnNVMlYwZEdsdVozTWdQU0JIYkc5aVlXeFRkR0YwWlR4SGRXbHNaRkJ5YjNCdmMyRnNVMlYwZEdsdVozTStLSHNLSUNBZ0lDOHZJQ0FnYTJWNU9pQkhkV2xzWkVkc2IySmhiRk4wWVhSbFMyVjVVbVZ0YjNabFJYaGxZM1YwYVc5dVVISnZjRzl6WVd4VFpYUjBhVzVuY3l3S0lDQWdJQzh2SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5KbGJXOTJaVjlsZUdWamRYUnBiMjVmY0hNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pvNE5pMDVNd29nSUNBZ0x5OGdZMjl1YzNRZ2MyVjBkR2x1WjNNNklFZDFhV3hrVUhKdmNHOXpZV3hUWlhSMGFXNW5jeUE5SUhzS0lDQWdJQzh2SUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCd2IzZGxjam9nTUN3S0lDQWdJQzh2SUNBZ1pIVnlZWFJwYjI0NklERXNDaUFnSUNBdkx5QWdJSEJoY25ScFkybHdZWFJwYjI0NklEQXNDaUFnSUNBdkx5QWdJR0Z3Y0hKdmRtRnNPaUF3TEFvZ0lDQWdMeThnSUNCdGFXNXBiWFZ0UVhCd2NtOTJZV3h6T2lBeExBb2dJQ0FnTHk4Z2ZRb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02T1RZS0lDQWdJQzh2SUhSb2FYTXVjbVZ0YjNabFJYaGxZM1YwYVc5dVVISnZjRzl6WVd4VFpYUjBhVzVuY3k1MllXeDFaU0E5SUdOc2IyNWxLSE5sZEhScGJtZHpLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxamIyNXpaVzV6ZFhNdGFHOXpkQzVoYkdkdkxuUnpPalV5TFRVMENpQWdJQ0F2THlCeVpXMXZkbVZRYkhWbmFXNVFjbTl3YjNOaGJGTmxkSFJwYm1keklEMGdSMnh2WW1Gc1UzUmhkR1U4UjNWcGJHUlFjbTl3YjNOaGJGTmxkSFJwYm1kelBpaDdDaUFnSUNBdkx5QWdJR3RsZVRvZ1IzVnBiR1JIYkc5aVlXeFRkR0YwWlV0bGVWSmxiVzkyWlZCc2RXZHBibEJ5YjNCdmMyRnNVMlYwZEdsdVozTXNDaUFnSUNBdkx5QjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnlaVzF2ZG1WZmNHeDFaMmx1WDNCeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk9EWXRPVE1LSUNBZ0lDOHZJR052Ym5OMElITmxkSFJwYm1kek9pQkhkV2xzWkZCeWIzQnZjMkZzVTJWMGRHbHVaM01nUFNCN0NpQWdJQ0F2THlBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUNBZ2NHOTNaWEk2SURBc0NpQWdJQ0F2THlBZ0lHUjFjbUYwYVc5dU9pQXhMQW9nSUNBZ0x5OGdJQ0J3WVhKMGFXTnBjR0YwYVc5dU9pQXdMQW9nSUNBZ0x5OGdJQ0JoY0hCeWIzWmhiRG9nTUN3S0lDQWdJQzh2SUNBZ2JXbHVhVzExYlVGd2NISnZkbUZzY3pvZ01Td0tJQ0FnSUM4dklIMEtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2prM0NpQWdJQ0F2THlCMGFHbHpMbkpsYlc5MlpWQnNkV2RwYmxCeWIzQnZjMkZzVTJWMGRHbHVaM011ZG1Gc2RXVWdQU0JqYkc5dVpTaHpaWFIwYVc1bmN5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6bzFOUzAxTndvZ0lDQWdMeThnWVdSa1FXeHNiM2RoYm1ObGMxQnliM0J2YzJGc1UyVjBkR2x1WjNNZ1BTQkhiRzlpWVd4VGRHRjBaVHhIZFdsc1pGQnliM0J2YzJGc1UyVjBkR2x1WjNNK0tIc0tJQ0FnSUM4dklDQWdhMlY1T2lCSGRXbHNaRWRzYjJKaGJGTjBZWFJsUzJWNVFXUmtRV3hzYjNkaGJtTmxjMUJ5YjNCdmMyRnNVMlYwZEdsdVozTXNDaUFnSUNBdkx5QjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSmhaR1JmWVd4c2IzZGhibU5sYzE5d2N5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qZzJMVGt6Q2lBZ0lDQXZMeUJqYjI1emRDQnpaWFIwYVc1bmN6b2dSM1ZwYkdSUWNtOXdiM05oYkZObGRIUnBibWR6SUQwZ2V3b2dJQ0FnTHk4Z0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lIQnZkMlZ5T2lBd0xBb2dJQ0FnTHk4Z0lDQmtkWEpoZEdsdmJqb2dNU3dLSUNBZ0lDOHZJQ0FnY0dGeWRHbGphWEJoZEdsdmJqb2dNQ3dLSUNBZ0lDOHZJQ0FnWVhCd2NtOTJZV3c2SURBc0NpQWdJQ0F2THlBZ0lHMXBibWx0ZFcxQmNIQnliM1poYkhNNklERXNDaUFnSUNBdkx5QjlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pvNU9Bb2dJQ0FnTHk4Z2RHaHBjeTVoWkdSQmJHeHZkMkZ1WTJWelVISnZjRzl6WVd4VFpYUjBhVzVuY3k1MllXeDFaU0E5SUdOc2IyNWxLSE5sZEhScGJtZHpLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxamIyNXpaVzV6ZFhNdGFHOXpkQzVoYkdkdkxuUnpPalU0TFRZd0NpQWdJQ0F2THlCeVpXMXZkbVZCYkd4dmQyRnVZMlZ6VUhKdmNHOXpZV3hUWlhSMGFXNW5jeUE5SUVkc2IySmhiRk4wWVhSbFBFZDFhV3hrVUhKdmNHOXpZV3hUWlhSMGFXNW5jejRvZXdvZ0lDQWdMeThnSUNCclpYazZJRWQxYVd4a1IyeHZZbUZzVTNSaGRHVkxaWGxTWlcxdmRtVkJiR3h2ZDJGdVkyVnpVSEp2Y0c5ellXeFRaWFIwYVc1bmN5d0tJQ0FnSUM4dklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luSmxiVzkyWlY5aGJHeHZkMkZ1WTJWelgzQnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZPRFl0T1RNS0lDQWdJQzh2SUdOdmJuTjBJSE5sZEhScGJtZHpPaUJIZFdsc1pGQnliM0J2YzJGc1UyVjBkR2x1WjNNZ1BTQjdDaUFnSUNBdkx5QWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdjRzkzWlhJNklEQXNDaUFnSUNBdkx5QWdJR1IxY21GMGFXOXVPaUF4TEFvZ0lDQWdMeThnSUNCd1lYSjBhV05wY0dGMGFXOXVPaUF3TEFvZ0lDQWdMeThnSUNCaGNIQnliM1poYkRvZ01Dd0tJQ0FnSUM4dklDQWdiV2x1YVcxMWJVRndjSEp2ZG1Gc2N6b2dNU3dLSUNBZ0lDOHZJSDBLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qazVDaUFnSUNBdkx5QjBhR2x6TG5KbGJXOTJaVUZzYkc5M1lXNWpaWE5RY205d2IzTmhiRk5sZEhScGJtZHpMblpoYkhWbElEMGdZMnh2Ym1Vb2MyVjBkR2x1WjNNcENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklHNWxkMFZ6WTNKdmQxQnliM0J2YzJGc1UyVjBkR2x1WjNNZ1BTQkhiRzlpWVd4VGRHRjBaVHhIZFdsc1pGQnliM0J2YzJGc1UyVjBkR2x1WjNNK0tIc2dhMlY1T2lCSGRXbHNaRWRzYjJKaGJGTjBZWFJsUzJWNVRtVjNSWE5qY205M1VISnZjRzl6WVd4VFpYUjBhVzVuY3lCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKdVpYZGZaWE5qY205M1gzQnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZPRFl0T1RNS0lDQWdJQzh2SUdOdmJuTjBJSE5sZEhScGJtZHpPaUJIZFdsc1pGQnliM0J2YzJGc1UyVjBkR2x1WjNNZ1BTQjdDaUFnSUNBdkx5QWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdjRzkzWlhJNklEQXNDaUFnSUNBdkx5QWdJR1IxY21GMGFXOXVPaUF4TEFvZ0lDQWdMeThnSUNCd1lYSjBhV05wY0dGMGFXOXVPaUF3TEFvZ0lDQWdMeThnSUNCaGNIQnliM1poYkRvZ01Dd0tJQ0FnSUM4dklDQWdiV2x1YVcxMWJVRndjSEp2ZG1Gc2N6b2dNU3dLSUNBZ0lDOHZJSDBLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qRXdNQW9nSUNBZ0x5OGdkR2hwY3k1dVpYZEZjMk55YjNkUWNtOXdiM05oYkZObGRIUnBibWR6TG5aaGJIVmxJRDBnWTJ4dmJtVW9jMlYwZEdsdVozTXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZOakl0TmpRS0lDQWdJQzh2SUhSdloyZHNaVVZ6WTNKdmQweHZZMnRRY205d2IzTmhiRk5sZEhScGJtZHpJRDBnUjJ4dlltRnNVM1JoZEdVOFIzVnBiR1JRY205d2IzTmhiRk5sZEhScGJtZHpQaWg3Q2lBZ0lDQXZMeUFnSUd0bGVUb2dSM1ZwYkdSSGJHOWlZV3hUZEdGMFpVdGxlVlJ2WjJkc1pVVnpZM0p2ZDB4dlkydFFjbTl3YjNOaGJGTmxkSFJwYm1kekxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWRHOW5aMnhsWDJWelkzSnZkMTl3Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pnMkxUa3pDaUFnSUNBdkx5QmpiMjV6ZENCelpYUjBhVzVuY3pvZ1IzVnBiR1JRY205d2IzTmhiRk5sZEhScGJtZHpJRDBnZXdvZ0lDQWdMeThnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUhCdmQyVnlPaUF3TEFvZ0lDQWdMeThnSUNCa2RYSmhkR2x2YmpvZ01Td0tJQ0FnSUM4dklDQWdjR0Z5ZEdsamFYQmhkR2x2YmpvZ01Dd0tJQ0FnSUM4dklDQWdZWEJ3Y205MllXdzZJREFzQ2lBZ0lDQXZMeUFnSUcxcGJtbHRkVzFCY0hCeWIzWmhiSE02SURFc0NpQWdJQ0F2THlCOUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem94TURFS0lDQWdJQzh2SUhSb2FYTXVkRzluWjJ4bFJYTmpjbTkzVEc5amExQnliM0J2YzJGc1UyVjBkR2x1WjNNdWRtRnNkV1VnUFNCamJHOXVaU2h6WlhSMGFXNW5jeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem8yTlMwMk53b2dJQ0FnTHk4Z2RYQmtZWFJsUjNWcGJHUlFjbTl3YjNOaGJGTmxkSFJwYm1keklEMGdSMnh2WW1Gc1UzUmhkR1U4UjNWcGJHUlFjbTl3YjNOaGJGTmxkSFJwYm1kelBpaDdDaUFnSUNBdkx5QWdJR3RsZVRvZ1IzVnBiR1JIYkc5aVlXeFRkR0YwWlV0bGVWVndaR0YwWlVkMWFXeGtVSEp2Y0c5ellXeFRaWFIwYVc1bmN5d0tJQ0FnSUM4dklIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luVndaR0YwWlY5bmRXbHNaRjl3Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pnMkxUa3pDaUFnSUNBdkx5QmpiMjV6ZENCelpYUjBhVzVuY3pvZ1IzVnBiR1JRY205d2IzTmhiRk5sZEhScGJtZHpJRDBnZXdvZ0lDQWdMeThnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUhCdmQyVnlPaUF3TEFvZ0lDQWdMeThnSUNCa2RYSmhkR2x2YmpvZ01Td0tJQ0FnSUM4dklDQWdjR0Z5ZEdsamFYQmhkR2x2YmpvZ01Dd0tJQ0FnSUM4dklDQWdZWEJ3Y205MllXdzZJREFzQ2lBZ0lDQXZMeUFnSUcxcGJtbHRkVzFCY0hCeWIzWmhiSE02SURFc0NpQWdJQ0F2THlCOUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem94TURJS0lDQWdJQzh2SUhSb2FYTXVkWEJrWVhSbFIzVnBiR1JRY205d2IzTmhiRk5sZEhScGJtZHpMblpoYkhWbElEMGdZMnh2Ym1Vb2MyVjBkR2x1WjNNcENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk9EUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ2YmtOeVpXRjBaVG9nSjNKbGNYVnBjbVVuSUgwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02T2sxdlkydEhkV2xzWkVOdmJuTmxibk4xYzBodmMzUXVhVzVwZEZCeWIyZHlZVzFiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGJtbDBVSEp2WjNKaGJUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qRXdOUW9nSUNBZ0x5OGdhVzVwZEZCeWIyZHlZVzBvYzJsNlpUb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdjSEp2WjNKaGJTQTlJRUp2ZUR4aWVYUmxjejRvZXlCclpYazZJQ2R3Y205bmNtRnRKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpY0hKdlozSmhiU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxamIyNXpaVzV6ZFhNdGFHOXpkQzVoYkdkdkxuUnpPakV3TmdvZ0lDQWdMeThnZEdocGN5NXdjbTluY21GdExtTnlaV0YwWlNoN0lITnBlbVVnZlNrS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5amNtVmhkR1VLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZNVEExQ2lBZ0lDQXZMeUJwYm1sMFVISnZaM0poYlNoemFYcGxPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pvNlRXOWphMGQxYVd4a1EyOXVjMlZ1YzNWelNHOXpkQzVzYjJGa1VISnZaM0poYlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNteHZZV1JRY205bmNtRnRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZNVEE1Q2lBZ0lDQXZMeUJzYjJGa1VISnZaM0poYlNodlptWnpaWFE2SUhWcGJuUTJOQ3dnWkdGMFlUb2dZbmwwWlhNcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZOamdLSUNBZ0lDOHZJSEJ5YjJkeVlXMGdQU0JDYjNnOFlubDBaWE0rS0hzZ2EyVjVPaUFuY0hKdlozSmhiU2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5CeWIyZHlZVzBpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUhSb2FYTXVjSEp2WjNKaGJTNXlaWEJzWVdObEtHOW1abk5sZEN3Z1pHRjBZU2tLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem94TURrS0lDQWdJQzh2SUd4dllXUlFjbTluY21GdEtHOW1abk5sZERvZ2RXbHVkRFkwTENCa1lYUmhPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pwTmIyTnJSM1ZwYkdSRGIyNXpaVzV6ZFhOSWIzTjBMbU55WldGMFpVTnZibk5sYm5OMWMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpVTnZibk5sYm5OMWN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qRXhOQW9nSUNBZ0x5OGdZM0psWVhSbFEyOXVjMlZ1YzNWektHZHZkbVZ5Ym1GdVkyVkRiMjVtYVdjNklHSjVkR1Z6S1RvZ2RXbHVkRFkwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxamIyNXpaVzV6ZFhNdGFHOXpkQzVoYkdkdkxuUnpPakV4TmkweE1qRUtJQ0FnSUM4dklHTnZibk4wSUdOdmJuTmxibk4xY3lBOUlHTnZibk5sYm5OMWMwTnZiblJ5WVdOMExtTmhiR3d1WTNKbFlYUmxLSHNLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMmR2ZG1WeWJtRnVZMlZEYjI1bWFXZGRMQW9nSUNBZ0x5OGdJQ0JoY0hCeWIzWmhiRkJ5YjJkeVlXMDZJRnQwYUdsekxuQnliMmR5WVcxR2FYSnpkRU5vZFc1cktDa3NJSFJvYVhNdWNISnZaM0poYlZObFkyOXVaRU5vZFc1cktDbGRMQW9nSUNBZ0x5OGdJQ0JqYkdWaGNsTjBZWFJsVUhKdlozSmhiVG9nWTI5dWMyVnVjM1Z6UTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBzQ2lBZ0lDQXZMeUFnSUdWNGRISmhVSEp2WjNKaGJWQmhaMlZ6T2lBekxBb2dJQ0FnTHk4Z2ZTa3VhWFI0Ymk1amNtVmhkR1ZrUVhCd0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnY0hKdlozSmhiU0E5SUVKdmVEeGllWFJsY3o0b2V5QnJaWGs2SUNkd2NtOW5jbUZ0SnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNISnZaM0poYlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pjeENpQWdJQ0F2THlCamIyNXpkQ0J6YVhwbElEMGdkR2hwY3k1d2NtOW5jbUZ0TG14bGJtZDBhQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pvM01nb2dJQ0FnTHk4Z2FXWWdLSE5wZW1VZ1BpQk5RVmhmUVZaTlgwSlpWRVZmUVZKU1FWbGZURVZPUjFSSUtTQnlaWFIxY200Z2RHaHBjeTV3Y205bmNtRnRMbVY0ZEhKaFkzUW9NQ3dnVFVGWVgwRldUVjlDV1ZSRlgwRlNVa0ZaWDB4RlRrZFVTQ2tLSUNBZ0lHbHVkR01nTkNBdkx5QTBNRGsyQ2lBZ0lDQStDaUFnSUNCaWVpQmpjbVZoZEdWRGIyNXpaVzV6ZFhOZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxamIyNXpaVzV6ZFhNdGFHOXpkQzVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUJ3Y205bmNtRnRJRDBnUW05NFBHSjVkR1Z6UGloN0lHdGxlVG9nSjNCeWIyZHlZVzBuSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKd2NtOW5jbUZ0SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TnpJS0lDQWdJQzh2SUdsbUlDaHphWHBsSUQ0Z1RVRllYMEZXVFY5Q1dWUkZYMEZTVWtGWlgweEZUa2RVU0NrZ2NtVjBkWEp1SUhSb2FYTXVjSEp2WjNKaGJTNWxlSFJ5WVdOMEtEQXNJRTFCV0Y5QlZrMWZRbGxVUlY5QlVsSkJXVjlNUlU1SFZFZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVc1MFl5QTBJQzh2SURRd09UWUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENncGpjbVZoZEdWRGIyNXpaVzV6ZFhOZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem82VFc5amEwZDFhV3hrUTI5dWMyVnVjM1Z6U0c5emRDNXdjbTluY21GdFJtbHljM1JEYUhWdWEwQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZOamdLSUNBZ0lDOHZJSEJ5YjJkeVlXMGdQU0JDYjNnOFlubDBaWE0rS0hzZ2EyVjVPaUFuY0hKdlozSmhiU2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5CeWIyZHlZVzBpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem8zTndvZ0lDQWdMeThnWTI5dWMzUWdjMmw2WlNBOUlIUm9hWE11Y0hKdlozSmhiUzVzWlc1bmRHZ0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUdsbUlDaHphWHBsSUQ0Z1RVRllYMEZXVFY5Q1dWUkZYMEZTVWtGWlgweEZUa2RVU0NrZ2V3b2dJQ0FnYVc1MFl5QTBJQzh2SURRd09UWUtJQ0FnSUQ0S0lDQWdJR0o2SUdOeVpXRjBaVU52Ym5ObGJuTjFjMTloWm5SbGNsOXBabDlsYkhObFFEY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qYzVDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV3Y205bmNtRnRMbVY0ZEhKaFkzUW9UVUZZWDBGV1RWOUNXVlJGWDBGU1VrRlpYMHhGVGtkVVNDd2djMmw2WlNBdElFMUJXRjlCVmsxZlFsbFVSVjlCVWxKQldWOU1SVTVIVkVncENpQWdJQ0JwYm5SaklEUWdMeThnTkRBNU5nb2dJQ0FnTFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUhCeWIyZHlZVzBnUFNCQ2IzZzhZbmwwWlhNK0tIc2dhMlY1T2lBbmNISnZaM0poYlNjZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luQnliMmR5WVcwaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pvM09Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVjSEp2WjNKaGJTNWxlSFJ5WVdOMEtFMUJXRjlCVmsxZlFsbFVSVjlCVWxKQldWOU1SVTVIVkVnc0lITnBlbVVnTFNCTlFWaGZRVlpOWDBKWlZFVmZRVkpTUVZsZlRFVk9SMVJJS1FvZ0lDQWdhVzUwWXlBMElDOHZJRFF3T1RZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtDbU55WldGMFpVTnZibk5sYm5OMWMxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pwTmIyTnJSM1ZwYkdSRGIyNXpaVzV6ZFhOSWIzTjBMbkJ5YjJkeVlXMVRaV052Ym1SRGFIVnVhMEE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TVRFMUNpQWdJQ0F2THlCamIyNXpkQ0JqYjI1elpXNXpkWE5EYjI1MGNtRmpkQ0E5SUdOdmJYQnBiR1ZCY21NMEtFZDFhV3hrUTI5dWMyVnVjM1Z6UTNKbFlYUmxVM1IxWWlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRXh2WTJGc1RuVnRWV2x1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdURzlqWVd4T2RXMUNlWFJsVTJ4cFkyVUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JwZEhodVgyWnBaV3hrSUVkc2IySmhiRTUxYlVKNWRHVlRiR2xqWlFvZ0lDQWdjSFZ6YUdsdWRDQXhNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkhiRzlpWVd4T2RXMVZhVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem94TVRZdE1USXhDaUFnSUNBdkx5QmpiMjV6ZENCamIyNXpaVzV6ZFhNZ1BTQmpiMjV6Wlc1emRYTkRiMjUwY21GamRDNWpZV3hzTG1OeVpXRjBaU2g3Q2lBZ0lDQXZMeUFnSUdGeVozTTZJRnRuYjNabGNtNWhibU5sUTI5dVptbG5YU3dLSUNBZ0lDOHZJQ0FnWVhCd2NtOTJZV3hRY205bmNtRnRPaUJiZEdocGN5NXdjbTluY21GdFJtbHljM1JEYUhWdWF5Z3BMQ0IwYUdsekxuQnliMmR5WVcxVFpXTnZibVJEYUhWdWF5Z3BYU3dLSUNBZ0lDOHZJQ0FnWTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzA2SUdOdmJuTmxibk4xYzBOdmJuUnlZV04wTG1Oc1pXRnlVM1JoZEdWUWNtOW5jbUZ0TEFvZ0lDQWdMeThnSUNCbGVIUnlZVkJ5YjJkeVlXMVFZV2RsY3pvZ015d0tJQ0FnSUM4dklIMHBMbWwwZUc0dVkzSmxZWFJsWkVGd2NBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pveE1qQUtJQ0FnSUM4dklHVjRkSEpoVUhKdlozSmhiVkJoWjJWek9pQXpMQW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVWNGRISmhVSEp2WjNKaGJWQmhaMlZ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem94TVRVS0lDQWdJQzh2SUdOdmJuTjBJR052Ym5ObGJuTjFjME52Ym5SeVlXTjBJRDBnWTI5dGNHbHNaVUZ5WXpRb1IzVnBiR1JEYjI1elpXNXpkWE5EY21WaGRHVlRkSFZpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJR0poYzJVMk5DaEVXVVZDVVhjOVBTa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyeGxZWEpUZEdGMFpWQnliMmR5WVcxUVlXZGxjd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJ5YjNaaGJGQnliMmR5WVcxUVlXZGxjd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJ5YjNaaGJGQnliMmR5WVcxUVlXZGxjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZNVEUyTFRFeU1Rb2dJQ0FnTHk4Z1kyOXVjM1FnWTI5dWMyVnVjM1Z6SUQwZ1kyOXVjMlZ1YzNWelEyOXVkSEpoWTNRdVkyRnNiQzVqY21WaGRHVW9ld29nSUNBZ0x5OGdJQ0JoY21kek9pQmJaMjkyWlhKdVlXNWpaVU52Ym1acFoxMHNDaUFnSUNBdkx5QWdJR0Z3Y0hKdmRtRnNVSEp2WjNKaGJUb2dXM1JvYVhNdWNISnZaM0poYlVacGNuTjBRMmgxYm1zb0tTd2dkR2hwY3k1d2NtOW5jbUZ0VTJWamIyNWtRMmgxYm1zb0tWMHNDaUFnSUNBdkx5QWdJR05zWldGeVUzUmhkR1ZRY205bmNtRnRPaUJqYjI1elpXNXpkWE5EYjI1MGNtRmpkQzVqYkdWaGNsTjBZWFJsVUhKdlozSmhiU3dLSUNBZ0lDOHZJQ0FnWlhoMGNtRlFjbTluY21GdFVHRm5aWE02SURNc0NpQWdJQ0F2THlCOUtTNXBkSGh1TG1OeVpXRjBaV1JCY0hBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURobE56a3pOVGhrSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0dKNWRHVmJYU2wyYjJsa0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwYm5Salh6TWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1oybDBlRzRnTUNCRGNtVmhkR1ZrUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk5EUUtJQ0FnSUM4dklHTnZibk5sYm5OMWN5QTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ1IzVnBiR1JIYkc5aVlXeFRkR0YwWlV0bGVVTnZibk5sYm5OMWN5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZMjl1YzJWdWMzVnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZNVEl5Q2lBZ0lDQXZMeUIwYUdsekxtTnZibk5sYm5OMWN5NTJZV3gxWlNBOUlHTnZibk5sYm5OMWN3b2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6b3hNak1LSUNBZ0lDOHZJR2wwZUc0dWNHRjViV1Z1ZENoN0lISmxZMlZwZG1WeU9pQmpiMjV6Wlc1emRYTXVZV1JrY21WemN5d2dZVzF2ZFc1ME9pQkhiRzlpWVd3dWJXbHVRbUZzWVc1alpTd2dabVZsT2lBd0lIMHBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JrZFhBS0lDQWdJR0Z3Y0Y5d1lYSmhiWE5mWjJWMElFRndjRUZrWkhKbGMzTUtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQmxlR2x6ZEhNS0lDQWdJR2RzYjJKaGJDQk5hVzVDWVd4aGJtTmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxamIyNXpaVzV6ZFhNdGFHOXpkQzVoYkdkdkxuUnpPakV5TkFvZ0lDQWdMeThnWTI5dWMyVnVjM1Z6UTI5dWRISmhZM1F1WTJGc2JDNWlhVzVrUjNWcGJHUW9leUJoY0hCSlpEb2dZMjl1YzJWdWMzVnpMQ0JoY21kek9pQmJSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbGtYU0I5S1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwZEc5aUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VETmxPRGN3TVROaUlDOHZJRzFsZEdodlpDQWlZbWx1WkVkMWFXeGtLSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk1URTBDaUFnSUNBdkx5QmpjbVZoZEdWRGIyNXpaVzV6ZFhNb1oyOTJaWEp1WVc1alpVTnZibVpwWnpvZ1lubDBaWE1wT2lCMWFXNTBOalFnZXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1kzSmxZWFJsUTI5dWMyVnVjM1Z6WDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJSEpsZEhWeWJpQkNlWFJsY3lnbkp5a0tJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk1URTRDaUFnSUNBdkx5QmhjSEJ5YjNaaGJGQnliMmR5WVcwNklGdDBhR2x6TG5CeWIyZHlZVzFHYVhKemRFTm9kVzVyS0Nrc0lIUm9hWE11Y0hKdlozSmhiVk5sWTI5dVpFTm9kVzVyS0NsZExBb2dJQ0FnWWlCamNtVmhkR1ZEYjI1elpXNXpkWE5mWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6bzZUVzlqYTBkMWFXeGtRMjl1YzJWdWMzVnpTRzl6ZEM1d2NtOW5jbUZ0VTJWamIyNWtRMmgxYm10QU9Bb0tZM0psWVhSbFEyOXVjMlZ1YzNWelgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCd2NtOW5jbUZ0SUQwZ1FtOTRQR0o1ZEdWelBpaDdJR3RsZVRvZ0ozQnliMmR5WVcwbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndjbTluY21GdElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbkJ5YjJkeVlXMHVaWGgwY21GamRDZ3dMQ0J6YVhwbEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qRXhPQW9nSUNBZ0x5OGdZWEJ3Y205MllXeFFjbTluY21GdE9pQmJkR2hwY3k1d2NtOW5jbUZ0Um1seWMzUkRhSFZ1YXlncExDQjBhR2x6TG5CeWIyZHlZVzFUWldOdmJtUkRhSFZ1YXlncFhTd0tJQ0FnSUdJZ1kzSmxZWFJsUTI5dWMyVnVjM1Z6WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZPazF2WTJ0SGRXbHNaRU52Ym5ObGJuTjFjMGh2YzNRdWNISnZaM0poYlVacGNuTjBRMmgxYm10QU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pwTmIyTnJSM1ZwYkdSRGIyNXpaVzV6ZFhOSWIzTjBMblpoYkdsa1lYUmxRV04wYVhaaGRHbHZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25aaGJHbGtZWFJsUVdOMGFYWmhkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pFeU9Rb2dJQ0FnTHk4Z1lXSnBRMkZzYkR4MGVYQmxiMllnUm1sNFpXUlRhV2R1WlhKSGRXbHNaRU52Ym5ObGJuTjFjeTV3Y205MGIzUjVjR1V1ZG1Gc2FXUmhkR1ZCWTNScGRtRjBhVzl1UGloN0lHRndjRWxrT2lCMGFHbHpMbU52Ym5ObGJuTjFjeTUyWVd4MVpTd2dZWEpuY3pvZ1cxMGdmU2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z1kyOXVjMlZ1YzNWeklEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGRXbHNaRWRzYjJKaGJGTjBZWFJsUzJWNVEyOXVjMlZ1YzNWeklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmpiMjV6Wlc1emRYTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6b3hNamtLSUNBZ0lDOHZJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlFWnBlR1ZrVTJsbmJtVnlSM1ZwYkdSRGIyNXpaVzV6ZFhNdWNISnZkRzkwZVhCbExuWmhiR2xrWVhSbFFXTjBhWFpoZEdsdmJqNG9leUJoY0hCSlpEb2dkR2hwY3k1amIyNXpaVzV6ZFhNdWRtRnNkV1VzSUdGeVozTTZJRnRkSUgwcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QTBJQzh2SUcxbGRHaHZaQ0FpZG1Gc2FXUmhkR1ZCWTNScGRtRjBhVzl1S0NsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2x1ZEdOZk15QXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6b3hNamdLSUNBZ0lDOHZJSFpoYkdsa1lYUmxRV04wYVhaaGRHbHZiaWdwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6bzZUVzlqYTBkMWFXeGtRMjl1YzJWdWMzVnpTRzl6ZEM1dmNHVnVVSEp2Y0c5ellXeGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B2Y0dWdVVISnZjRzl6WVd3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pveE16SUtJQ0FnSUM4dklHOXdaVzVRY205d2IzTmhiQ2h3Y205d2IzTmhiRWxFT2lCMWFXNTBOalFzSUhadmRHbHVaMFZ1WkRvZ2RXbHVkRFkwTENCeVpYRjFhWEpsYldWdWRITTZJRWQxYVd4a1EyOXVjMlZ1YzNWelVtVnhkV2x5WlcxbGJuUnpLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OWpiM0psTDNSNWNHVnpMblJ6T2pwSGRXbHNaRU52Ym5ObGJuTjFjMUpsY1hWcGNtVnRaVzUwY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TVRNekNpQWdJQ0F2THlCamIyNXpkQ0JoYlc5MWJuUWdQU0JoWW1sRFlXeHNQSFI1Y0dWdlppQkhkV2xzWkVOdmJuTmxibk4xYzBKaGMyVXVjSEp2ZEc5MGVYQmxMbUpoYkd4dmRFMWljajRvZXlCaGNIQkpaRG9nZEdocGN5NWpiMjV6Wlc1emRYTXVkbUZzZFdVc0lHRnlaM002SUZ0ZElIMHBMbkpsZEhWeWJsWmhiSFZsQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk5EUUtJQ0FnSUM4dklHTnZibk5sYm5OMWN5QTlJRWRzYjJKaGJGTjBZWFJsUEVGd2NHeHBZMkYwYVc5dVBpaDdJR3RsZVRvZ1IzVnBiR1JIYkc5aVlXeFRkR0YwWlV0bGVVTnZibk5sYm5OMWN5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZMjl1YzJWdWMzVnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZNVE16Q2lBZ0lDQXZMeUJqYjI1emRDQmhiVzkxYm5RZ1BTQmhZbWxEWVd4c1BIUjVjR1Z2WmlCSGRXbHNaRU52Ym5ObGJuTjFjMEpoYzJVdWNISnZkRzkwZVhCbExtSmhiR3h2ZEUxaWNqNG9leUJoY0hCSlpEb2dkR2hwY3k1amIyNXpaVzV6ZFhNdWRtRnNkV1VzSUdGeVozTTZJRnRkSUgwcExuSmxkSFZ5YmxaaGJIVmxDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHUXpaREk1TmpReklDOHZJRzFsZEdodlpDQWlZbUZzYkc5MFRXSnlLQ2wxYVc1ME5qUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhVzUwWTE4eklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQ2VYUmxjeUJvWVhNZ2RtRnNhV1FnY0hKbFptbDRDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSFZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk1UTTBMVEUwTmdvZ0lDQWdMeThnWVdKcFEyRnNiRHgwZVhCbGIyWWdSbWw0WldSVGFXZHVaWEpIZFdsc1pFTnZibk5sYm5OMWN5NXdjbTkwYjNSNWNHVXViM0JsYmxCeWIzQnZjMkZzUGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCMGFHbHpMbU52Ym5ObGJuTjFjeTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1d3b2dJQ0FnTHk4Z0lDQWdJR2wwZUc0dWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdJQ0J5WldObGFYWmxjam9nZEdocGN5NWpiMjV6Wlc1emRYTXVkbUZzZFdVdVlXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQWdJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnSUNCOUtTd0tJQ0FnSUM4dklDQWdJQ0J3Y205d2IzTmhiRWxFTEFvZ0lDQWdMeThnSUNBZ0lIWnZkR2x1WjBWdVpDd0tJQ0FnSUM4dklDQWdJQ0J5WlhGMWFYSmxiV1Z1ZEhNc0NpQWdJQ0F2THlBZ0lGMHNDaUFnSUNBdkx5QjlLUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk1UTTRDaUFnSUNBdkx5QnlaV05sYVhabGNqb2dkR2hwY3k1amIyNXpaVzV6ZFhNdWRtRnNkV1V1WVdSa2NtVnpjeXdLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJaR1J5WlhOekNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z1pYaHBjM1J6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TVRNM0xURTBNUW9nSUNBZ0x5OGdhWFI0Ymk1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ2NtVmpaV2wyWlhJNklIUm9hWE11WTI5dWMyVnVjM1Z6TG5aaGJIVmxMbUZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z2ZTa3NDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TVRRd0NpQWdJQ0F2THlCbVpXVTZJREFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxamIyNXpaVzV6ZFhNdGFHOXpkQzVoYkdkdkxuUnpPakV6TkMweE5EWUtJQ0FnSUM4dklHRmlhVU5oYkd3OGRIbHdaVzltSUVacGVHVmtVMmxuYm1WeVIzVnBiR1JEYjI1elpXNXpkWE11Y0hKdmRHOTBlWEJsTG05d1pXNVFjbTl3YjNOaGJENG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2dkR2hwY3k1amIyNXpaVzV6ZFhNdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnNLSUNBZ0lDOHZJQ0FnSUNCcGRIaHVMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0FnSUNBZ2NtVmpaV2wyWlhJNklIUm9hWE11WTI5dWMyVnVjM1Z6TG5aaGJIVmxMbUZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnSUNCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ0lDQm1aV1U2SURBc0NpQWdJQ0F2THlBZ0lDQWdmU2tzQ2lBZ0lDQXZMeUFnSUNBZ2NISnZjRzl6WVd4SlJDd0tJQ0FnSUM4dklDQWdJQ0IyYjNScGJtZEZibVFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnhkV2x5WlcxbGJuUnpMQW9nSUNBZ0x5OGdJQ0JkTEFvZ0lDQWdMeThnZlNrS0lDQWdJR2wwZUc1ZmJtVjRkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcyT0RRME9UQTRPQ0F2THlCdFpYUm9iMlFnSW05d1pXNVFjbTl3YjNOaGJDaHdZWGtzZFdsdWREWTBMSFZwYm5RMk5Dd29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk1UTXlDaUFnSUNBdkx5QnZjR1Z1VUhKdmNHOXpZV3dvY0hKdmNHOXpZV3hKUkRvZ2RXbHVkRFkwTENCMmIzUnBibWRGYm1RNklIVnBiblEyTkN3Z2NtVnhkV2x5WlcxbGJuUnpPaUJIZFdsc1pFTnZibk5sYm5OMWMxSmxjWFZwY21WdFpXNTBjeWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qcE5iMk5yUjNWcGJHUkRiMjV6Wlc1emRYTkliM04wTG5admRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyYjNSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk1UUTVDaUFnSUNBdkx5QjJiM1JsS0hadmRHVnlPaUJCWTJOdmRXNTBMQ0J3Y205d2IzTmhiRWxFT2lCMWFXNTBOalFzSUhadmRHVTZJRWQxYVd4a1ZtOTBaVlI1Y0dVc0lHVjJhV1JsYm1ObE9pQmllWFJsY3lrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RNENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZNVFV4TFRFMU5Bb2dJQ0FnTHk4Z1kyOXVjM1FnZG05MFpXUWdQU0JoWW1sRFlXeHNQSFI1Y0dWdlppQkdhWGhsWkZOcFoyNWxja2QxYVd4a1EyOXVjMlZ1YzNWekxuQnliM1J2ZEhsd1pTNW9ZWE5XYjNSbFpENG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2dkR2hwY3k1amIyNXpaVzV6ZFhNdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnR3Y205d2IzTmhiRWxFTENCMmIzUmxjbDBzQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TVRVeUNpQWdJQ0F2THlCaGNIQkpaRG9nZEdocGN5NWpiMjV6Wlc1emRYTXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TkRRS0lDQWdJQzh2SUdOdmJuTmxibk4xY3lBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjNWcGJHUkhiRzlpWVd4VGRHRjBaVXRsZVVOdmJuTmxibk4xY3lCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkyOXVjMlZ1YzNWeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk1UVXlDaUFnSUNBdkx5QmhjSEJKWkRvZ2RHaHBjeTVqYjI1elpXNXpkWE11ZG1Gc2RXVXNDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qRTFNUzB4TlRRS0lDQWdJQzh2SUdOdmJuTjBJSFp2ZEdWa0lEMGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1JtbDRaV1JUYVdkdVpYSkhkV2xzWkVOdmJuTmxibk4xY3k1d2NtOTBiM1I1Y0dVdWFHRnpWbTkwWldRK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIUm9hWE11WTI5dWMyVnVjM1Z6TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJjSEp2Y0c5ellXeEpSQ3dnZG05MFpYSmRMQW9nSUNBZ0x5OGdmU2t1Y21WMGRYSnVWbUZzZFdVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdZMU1EZ3dPR1ZtSUM4dklHMWxkR2h2WkNBaWFHRnpWbTkwWldRb2RXbHVkRFkwTEdGa1pISmxjM01wWW05dmJDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdScFp5QTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhVzUwWTE4eklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQ2VYUmxjeUJvWVhNZ2RtRnNhV1FnY0hKbFptbDRDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0p2YjJ3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pFMU5TMHhOalFLSUNBZ0lDOHZJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlFWnBlR1ZrVTJsbmJtVnlSM1ZwYkdSRGIyNXpaVzV6ZFhNdWNISnZkRzkwZVhCbExuWnZkR1UrS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUhSb2FYTXVZMjl1YzJWdWMzVnpMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYkNpQWdJQ0F2THlBZ0lDQWdhWFI0Ymk1d1lYbHRaVzUwS0hzZ2NtVmpaV2wyWlhJNklIUm9hWE11WTI5dWMyVnVjM1Z6TG5aaGJIVmxMbUZrWkhKbGMzTXNJR0Z0YjNWdWREb2dkbTkwWldRZ1B5QXdJRG9nUjNWcGJHUldiM1JsVFVKU0xDQm1aV1U2SURBZ2ZTa3NDaUFnSUNBdkx5QWdJQ0FnZG05MFpYSXNDaUFnSUNBdkx5QWdJQ0FnY0hKdmNHOXpZV3hKUkN3S0lDQWdJQzh2SUNBZ0lDQjJiM1JsTEFvZ0lDQWdMeThnSUNBZ0lHVjJhV1JsYm1ObExBb2dJQ0FnTHk4Z0lDQmRMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qRTFPQW9nSUNBZ0x5OGdhWFI0Ymk1d1lYbHRaVzUwS0hzZ2NtVmpaV2wyWlhJNklIUm9hWE11WTI5dWMyVnVjM1Z6TG5aaGJIVmxMbUZrWkhKbGMzTXNJR0Z0YjNWdWREb2dkbTkwWldRZ1B5QXdJRG9nUjNWcGJHUldiM1JsVFVKU0xDQm1aV1U2SURBZ2ZTa3NDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1FXUmtjbVZ6Y3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBeU1qVXdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjMlZzWldOMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZNVFUxTFRFMk5Bb2dJQ0FnTHk4Z1lXSnBRMkZzYkR4MGVYQmxiMllnUm1sNFpXUlRhV2R1WlhKSGRXbHNaRU52Ym5ObGJuTjFjeTV3Y205MGIzUjVjR1V1ZG05MFpUNG9ld29nSUNBZ0x5OGdJQ0JoY0hCSlpEb2dkR2hwY3k1amIyNXpaVzV6ZFhNdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnNLSUNBZ0lDOHZJQ0FnSUNCcGRIaHVMbkJoZVcxbGJuUW9leUJ5WldObGFYWmxjam9nZEdocGN5NWpiMjV6Wlc1emRYTXVkbUZzZFdVdVlXUmtjbVZ6Y3l3Z1lXMXZkVzUwT2lCMmIzUmxaQ0EvSURBZ09pQkhkV2xzWkZadmRHVk5RbElzSUdabFpUb2dNQ0I5S1N3S0lDQWdJQzh2SUNBZ0lDQjJiM1JsY2l3S0lDQWdJQzh2SUNBZ0lDQndjbTl3YjNOaGJFbEVMQW9nSUNBZ0x5OGdJQ0FnSUhadmRHVXNDaUFnSUNBdkx5QWdJQ0FnWlhacFpHVnVZMlVzQ2lBZ0lDQXZMeUFnSUYwc0NpQWdJQ0F2THlCOUtRb2dJQ0FnYVhSNGJsOXVaWGgwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUROa056VXlOV1U1SUM4dklHMWxkR2h2WkNBaWRtOTBaU2h3WVhrc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREZ3NZbmwwWlZ0ZEtYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwYm5Salh6TWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZNVFE1Q2lBZ0lDQXZMeUIyYjNSbEtIWnZkR1Z5T2lCQlkyTnZkVzUwTENCd2NtOXdiM05oYkVsRU9pQjFhVzUwTmpRc0lIWnZkR1U2SUVkMWFXeGtWbTkwWlZSNWNHVXNJR1YyYVdSbGJtTmxPaUJpZVhSbGN5azZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pwTmIyTnJSM1ZwYkdSRGIyNXpaVzV6ZFhOSWIzTjBMbkpsYzI5c2RtVlFjbTl3YjNOaGJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsYzI5c2RtVlFjbTl3YjNOaGJEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qRTJOd29nSUNBZ0x5OGdjbVZ6YjJ4MlpWQnliM0J2YzJGc0tIQnliM0J2YzJGc1NVUTZJSFZwYm5RMk5DazZJRWQxYVd4a1EyOXVjMlZ1YzNWelVtVnpkV3gwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qRTJPQzB4TnpFS0lDQWdJQzh2SUhKbGRIVnliaUJoWW1sRFlXeHNQSFI1Y0dWdlppQkdhWGhsWkZOcFoyNWxja2QxYVd4a1EyOXVjMlZ1YzNWekxuQnliM1J2ZEhsd1pTNXlaWE52YkhabFVISnZjRzl6WVd3K0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIUm9hWE11WTI5dWMyVnVjM1Z6TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJjSEp2Y0c5ellXeEpSRjBzQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TVRZNUNpQWdJQ0F2THlCaGNIQkpaRG9nZEdocGN5NWpiMjV6Wlc1emRYTXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TkRRS0lDQWdJQzh2SUdOdmJuTmxibk4xY3lBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjNWcGJHUkhiRzlpWVd4VGRHRjBaVXRsZVVOdmJuTmxibk4xY3lCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkyOXVjMlZ1YzNWeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk1UWTVDaUFnSUNBdkx5QmhjSEJKWkRvZ2RHaHBjeTVqYjI1elpXNXpkWE11ZG1Gc2RXVXNDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6b3hOamd0TVRjeENpQWdJQ0F2THlCeVpYUjFjbTRnWVdKcFEyRnNiRHgwZVhCbGIyWWdSbWw0WldSVGFXZHVaWEpIZFdsc1pFTnZibk5sYm5OMWN5NXdjbTkwYjNSNWNHVXVjbVZ6YjJ4MlpWQnliM0J2YzJGc1BpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQjBhR2x6TG1OdmJuTmxibk4xY3k1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXM0J5YjNCdmMyRnNTVVJkTEFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z2JXVjBhRzlrSUNKeVpYTnZiSFpsVUhKdmNHOXpZV3dvZFdsdWREWTBLU2hpYjI5c0xIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsdWRHTmZNeUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbmwwWlhNZ2FHRnpJSFpoYkdsa0lIQnlaV1pwZUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016TUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdlkyOXlaUzkwZVhCbGN5NTBjem82UjNWcGJHUkRiMjV6Wlc1emRYTlNaWE4xYkhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pFMk53b2dJQ0FnTHk4Z2NtVnpiMngyWlZCeWIzQnZjMkZzS0hCeWIzQnZjMkZzU1VRNklIVnBiblEyTkNrNklFZDFhV3hrUTI5dWMyVnVjM1Z6VW1WemRXeDBJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6bzZUVzlqYTBkMWFXeGtRMjl1YzJWdWMzVnpTRzl6ZEM1amJHVmhiblZ3UW1Gc2JHOTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJ4bFlXNTFjRUpoYkd4dmREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qRTNOQW9nSUNBZ0x5OGdZMnhsWVc1MWNFSmhiR3h2ZENod2NtOXdiM05oYkVsRU9pQjFhVzUwTmpRc0lIWnZkR1Z5Y3pvZ1FXTmpiM1Z1ZEZ0ZEtUb2dkV2x1ZERZMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRmpZMjkxYm5RK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pveE56VXRNVGM0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1IzVnBiR1JEYjI1elpXNXpkWE5DWVhObExuQnliM1J2ZEhsd1pTNWpiR1ZoYm5Wd1FtRnNiRzkwUGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCMGFHbHpMbU52Ym5ObGJuTjFjeTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1czQnliM0J2YzJGc1NVUXNJSFp2ZEdWeWMxMHNDaUFnSUNBdkx5QjlLUzV5WlhSMWNtNVdZV3gxWlFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZNVGMyQ2lBZ0lDQXZMeUJoY0hCSlpEb2dkR2hwY3k1amIyNXpaVzV6ZFhNdWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFdOdmJuTmxibk4xY3kxb2IzTjBMbUZzWjI4dWRITTZORFFLSUNBZ0lDOHZJR052Ym5ObGJuTjFjeUE5SUVkc2IySmhiRk4wWVhSbFBFRndjR3hwWTJGMGFXOXVQaWg3SUd0bGVUb2dSM1ZwYkdSSGJHOWlZV3hUZEdGMFpVdGxlVU52Ym5ObGJuTjFjeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWTI5dWMyVnVjM1Z6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TVRjMkNpQWdJQ0F2THlCaGNIQkpaRG9nZEdocGN5NWpiMjV6Wlc1emRYTXVkbUZzZFdVc0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pveE56VXRNVGM0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1IzVnBiR1JEYjI1elpXNXpkWE5DWVhObExuQnliM1J2ZEhsd1pTNWpiR1ZoYm5Wd1FtRnNiRzkwUGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCMGFHbHpMbU52Ym5ObGJuTjFjeTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1czQnliM0J2YzJGc1NVUXNJSFp2ZEdWeWMxMHNDaUFnSUNBdkx5QjlLUzV5WlhSMWNtNVdZV3gxWlFvZ0lDQWdZbmwwWldNZ05pQXZMeUJ0WlhSb2IyUWdJbU5zWldGdWRYQkNZV3hzYjNRb2RXbHVkRFkwTEdGa1pISmxjM05iWFNsMWFXNTBOalFpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwYm5Salh6TWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREFnTkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFSjVkR1Z6SUdoaGN5QjJZV3hwWkNCd2NtVm1hWGdLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6b3hOelFLSUNBZ0lDOHZJR05zWldGdWRYQkNZV3hzYjNRb2NISnZjRzl6WVd4SlJEb2dkV2x1ZERZMExDQjJiM1JsY25NNklFRmpZMjkxYm5SYlhTazZJSFZwYm5RMk5DQjdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk9rMXZZMnRIZFdsc1pFTnZibk5sYm5OMWMwaHZjM1F1Y0hKdmNHOXpZV3hRYjNkbGNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJ5YjNCdmMyRnNVRzkzWlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pveE9ERUtJQ0FnSUM4dklIQnliM0J2YzJGc1VHOTNaWElvWVdOamIzVnVkRG9nUVdOamIzVnVkQ3dnWlhacFpHVnVZMlU2SUdKNWRHVnpMQ0J5WlhGMWFYSmxaRlJvY205MVoyZzZJSFZwYm5RMk5DazZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TVRneUxURTROUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRmlhVU5oYkd3OGRIbHdaVzltSUVacGVHVmtVMmxuYm1WeVIzVnBiR1JEYjI1elpXNXpkWE11Y0hKdmRHOTBlWEJsTG5CeWIzQnZjMkZzVUc5M1pYSStLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSFJvYVhNdVkyOXVjMlZ1YzNWekxuWmhiSFZsTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiWVdOamIzVnVkQ3dnWlhacFpHVnVZMlVzSUhKbGNYVnBjbVZrVkdoeWIzVm5hRjBzQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TVRnekNpQWdJQ0F2THlCaGNIQkpaRG9nZEdocGN5NWpiMjV6Wlc1emRYTXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TkRRS0lDQWdJQzh2SUdOdmJuTmxibk4xY3lBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGloN0lHdGxlVG9nUjNWcGJHUkhiRzlpWVd4VGRHRjBaVXRsZVVOdmJuTmxibk4xY3lCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkyOXVjMlZ1YzNWeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMV052Ym5ObGJuTjFjeTFvYjNOMExtRnNaMjh1ZEhNNk1UZ3pDaUFnSUNBdkx5QmhjSEJKWkRvZ2RHaHBjeTVqYjI1elpXNXpkWE11ZG1Gc2RXVXNDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6b3hPREl0TVRnMUNpQWdJQ0F2THlCeVpYUjFjbTRnWVdKcFEyRnNiRHgwZVhCbGIyWWdSbWw0WldSVGFXZHVaWEpIZFdsc1pFTnZibk5sYm5OMWN5NXdjbTkwYjNSNWNHVXVjSEp2Y0c5ellXeFFiM2RsY2o0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2RHaHBjeTVqYjI1elpXNXpkWE11ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGdGhZMk52ZFc1MExDQmxkbWxrWlc1alpTd2djbVZ4ZFdseVpXUlVhSEp2ZFdkb1hTd0tJQ0FnSUM4dklIMHBMbkpsZEhWeWJsWmhiSFZsQ2lBZ0lDQmllWFJsWXlBM0lDOHZJRzFsZEdodlpDQWljSEp2Y0c5ellXeFFiM2RsY2loaFpHUnlaWE56TEdKNWRHVmJYU3gxYVc1ME5qUXBkV2x1ZERZMElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FXNTBZMTh6SUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBd0lEUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJDZVhSbGN5Qm9ZWE1nZG1Gc2FXUWdjSEpsWm1sNENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlIVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TVRneENpQWdJQ0F2THlCd2NtOXdiM05oYkZCdmQyVnlLR0ZqWTI5MWJuUTZJRUZqWTI5MWJuUXNJR1YyYVdSbGJtTmxPaUJpZVhSbGN5d2djbVZ4ZFdseVpXUlVhSEp2ZFdkb09pQjFhVzUwTmpRcE9pQjFhVzUwTmpRZ2V3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pwTmIyTnJSM1ZwYkdSRGIyNXpaVzV6ZFhOSWIzTjBMbU52Ym5ObGJuTjFjMEZqZEdsdmJrMWljbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OdmJuTmxibk4xYzBGamRHbHZiazFpY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pFNE9Rb2dJQ0FnTHk4Z1kyOXVjMlZ1YzNWelFXTjBhVzl1VFdKeUtHUmhkR0U2SUdKNWRHVnpLVG9nZFdsdWREWTBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZMkZzYkhOMVlpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6bzZUVzlqYTBkMWFXeGtRMjl1YzJWdWMzVnpTRzl6ZEM1amIyNXpaVzV6ZFhOQlkzUnBiMjVOWW5JS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem82VFc5amEwZDFhV3hrUTI5dWMyVnVjM1Z6U0c5emRDNWpiMjV6Wlc1emRYTkJZM1JwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiMjV6Wlc1emRYTkJZM1JwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pveE9UY0tJQ0FnSUM4dklHTnZibk5sYm5OMWMwRmpkR2x2Ymlod2NtOXdiM05oYkVsRU9pQjFhVzUwTmpRc0lHUmhkR0U2SUdKNWRHVnpLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TVRrNENpQWdJQ0F2THlCamIyNXpkQ0JoYlc5MWJuUWdQU0IwYUdsekxtTnZibk5sYm5OMWMwRmpkR2x2YmsxaWNpaGtZWFJoS1FvZ0lDQWdZMkZzYkhOMVlpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6bzZUVzlqYTBkMWFXeGtRMjl1YzJWdWMzVnpTRzl6ZEM1amIyNXpaVzV6ZFhOQlkzUnBiMjVOWW5JS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pFNU9TMHlNRElLSUNBZ0lDOHZJR0ZpYVVOaGJHdzhkSGx3Wlc5bUlFWnBlR1ZrVTJsbmJtVnlSM1ZwYkdSRGIyNXpaVzV6ZFhNdWNISnZkRzkwZVhCbExtRndjR3g1UTI5dWMyVnVjM1Z6UVdOMGFXOXVQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUIwYUdsekxtTnZibk5sYm5OMWN5NTJZV3gxWlN3S0lDQWdJQzh2SUNBZ1lYSm5jem9nVzJsMGVHNHVjR0Y1YldWdWRDaDdJSEpsWTJWcGRtVnlPaUIwYUdsekxtTnZibk5sYm5OMWN5NTJZV3gxWlM1aFpHUnlaWE56TENCaGJXOTFiblFzSUdabFpUb2dNQ0I5S1N3Z2NISnZjRzl6WVd4SlJDd2daR0YwWVYwc0NpQWdJQ0F2THlCOUtRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TWpBeENpQWdJQ0F2THlCaGNtZHpPaUJiYVhSNGJpNXdZWGx0Wlc1MEtIc2djbVZqWldsMlpYSTZJSFJvYVhNdVkyOXVjMlZ1YzNWekxuWmhiSFZsTG1Ga1pISmxjM01zSUdGdGIzVnVkQ3dnWm1WbE9pQXdJSDBwTENCd2NtOXdiM05oYkVsRUxDQmtZWFJoWFN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnWTI5dWMyVnVjM1Z6SUQwZ1IyeHZZbUZzVTNSaGRHVThRWEJ3YkdsallYUnBiMjQrS0hzZ2EyVjVPaUJIZFdsc1pFZHNiMkpoYkZOMFlYUmxTMlY1UTI5dWMyVnVjM1Z6SUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKamIyNXpaVzV6ZFhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pveU1ERUtJQ0FnSUM4dklHRnlaM002SUZ0cGRIaHVMbkJoZVcxbGJuUW9leUJ5WldObGFYWmxjam9nZEdocGN5NWpiMjV6Wlc1emRYTXVkbUZzZFdVdVlXUmtjbVZ6Y3l3Z1lXMXZkVzUwTENCbVpXVTZJREFnZlNrc0lIQnliM0J2YzJGc1NVUXNJR1JoZEdGZExBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndRV1JrY21WemN3b2dJQ0FnWVhOelpYSjBJQzh2SUdGd2NHeHBZMkYwYVc5dUlHVjRhWE4wY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TVRrNUxUSXdNZ29nSUNBZ0x5OGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1JtbDRaV1JUYVdkdVpYSkhkV2xzWkVOdmJuTmxibk4xY3k1d2NtOTBiM1I1Y0dVdVlYQndiSGxEYjI1elpXNXpkWE5CWTNScGIyNCtLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSFJvYVhNdVkyOXVjMlZ1YzNWekxuWmhiSFZsTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiYVhSNGJpNXdZWGx0Wlc1MEtIc2djbVZqWldsMlpYSTZJSFJvYVhNdVkyOXVjMlZ1YzNWekxuWmhiSFZsTG1Ga1pISmxjM01zSUdGdGIzVnVkQ3dnWm1WbE9pQXdJSDBwTENCd2NtOXdiM05oYkVsRUxDQmtZWFJoWFN3S0lDQWdJQzh2SUgwcENpQWdJQ0JwZEhodVgyNWxlSFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpkbFpEVm1aV1FnTHk4Z2JXVjBhRzlrSUNKaGNIQnNlVU52Ym5ObGJuTjFjMEZqZEdsdmJpaHdZWGtzZFdsdWREWTBMR0o1ZEdWYlhTbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVc1MFkxOHpJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxamIyNXpaVzV6ZFhNdGFHOXpkQzVoYkdkdkxuUnpPakU1TndvZ0lDQWdMeThnWTI5dWMyVnVjM1Z6UVdOMGFXOXVLSEJ5YjNCdmMyRnNTVVE2SUhWcGJuUTJOQ3dnWkdGMFlUb2dZbmwwWlhNcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem82VFc5amEwZDFhV3hrUTI5dWMyVnVjM1Z6U0c5emRDNWpiMjVtYVdkMWNtVkRiMjV6Wlc1emRYTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqYjI1bWFXZDFjbVZEYjI1elpXNXpkWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem95TURZS0lDQWdJQzh2SUdOdmJtWnBaM1Z5WlVOdmJuTmxibk4xY3loamIyNW1hV2M2SUdKNWRHVnpLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TWpBM0xUSXhNQW9nSUNBZ0x5OGdZMjl1YzNRZ1lXMXZkVzUwSUQwZ1lXSnBRMkZzYkR4MGVYQmxiMllnUm1sNFpXUlRhV2R1WlhKSGRXbHNaRU52Ym5ObGJuTjFjeTV3Y205MGIzUjVjR1V1WTI5dVptbG5kWEpoZEdsdmJrMWljajRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nZEdocGN5NWpiMjV6Wlc1emRYTXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lHRnlaM002SUZ0amIyNW1hV2RkTEFvZ0lDQWdMeThnZlNrdWNtVjBkWEp1Vm1Gc2RXVUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pJd09Bb2dJQ0FnTHk4Z1lYQndTV1E2SUhSb2FYTXVZMjl1YzJWdWMzVnpMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MWpiMjV6Wlc1emRYTXRhRzl6ZEM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCamIyNXpaVzV6ZFhNZ1BTQkhiRzlpWVd4VGRHRjBaVHhCY0hCc2FXTmhkR2x2Ymo0b2V5QnJaWGs2SUVkMWFXeGtSMnh2WW1Gc1UzUmhkR1ZMWlhsRGIyNXpaVzV6ZFhNZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltTnZibk5sYm5OMWN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qSXdPQW9nSUNBZ0x5OGdZWEJ3U1dRNklIUm9hWE11WTI5dWMyVnVjM1Z6TG5aaGJIVmxMQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6b3lNRGN0TWpFd0NpQWdJQ0F2THlCamIyNXpkQ0JoYlc5MWJuUWdQU0JoWW1sRFlXeHNQSFI1Y0dWdlppQkdhWGhsWkZOcFoyNWxja2QxYVd4a1EyOXVjMlZ1YzNWekxuQnliM1J2ZEhsd1pTNWpiMjVtYVdkMWNtRjBhVzl1VFdKeVBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQjBhR2x6TG1OdmJuTmxibk4xY3k1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMk52Ym1acFoxMHNDaUFnSUNBdkx5QjlLUzV5WlhSMWNtNVdZV3gxWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WVdFelpUUXdZVGdnTHk4Z2JXVjBhRzlrSUNKamIyNW1hV2QxY21GMGFXOXVUV0p5S0dKNWRHVmJYU2wxYVc1ME5qUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGJuUmpYek1nTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUo1ZEdWeklHaGhjeUIyWVd4cFpDQndjbVZtYVhnS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2RXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem95TVRFdE1qRTBDaUFnSUNBdkx5QmhZbWxEWVd4c1BIUjVjR1Z2WmlCR2FYaGxaRk5wWjI1bGNrZDFhV3hrUTI5dWMyVnVjM1Z6TG5CeWIzUnZkSGx3WlM1amIyNW1hV2QxY21VK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIUm9hWE11WTI5dWMyVnVjM1Z6TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJhWFI0Ymk1d1lYbHRaVzUwS0hzZ2NtVmpaV2wyWlhJNklIUm9hWE11WTI5dWMyVnVjM1Z6TG5aaGJIVmxMbUZrWkhKbGMzTXNJR0Z0YjNWdWRDd2dabVZsT2lBd0lIMHBMQ0JqYjI1bWFXZGRMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qSXhNd29nSUNBZ0x5OGdZWEpuY3pvZ1cybDBlRzR1Y0dGNWJXVnVkQ2g3SUhKbFkyVnBkbVZ5T2lCMGFHbHpMbU52Ym5ObGJuTjFjeTUyWVd4MVpTNWhaR1J5WlhOekxDQmhiVzkxYm5Rc0lHWmxaVG9nTUNCOUtTd2dZMjl1Wm1sblhTd0tJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCQlpHUnlaWE56Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWEJ3YkdsallYUnBiMjRnWlhocGMzUnpDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TWpFeExUSXhOQW9nSUNBZ0x5OGdZV0pwUTJGc2JEeDBlWEJsYjJZZ1JtbDRaV1JUYVdkdVpYSkhkV2xzWkVOdmJuTmxibk4xY3k1d2NtOTBiM1I1Y0dVdVkyOXVabWxuZFhKbFBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQjBhR2x6TG1OdmJuTmxibk4xY3k1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXMmwwZUc0dWNHRjViV1Z1ZENoN0lISmxZMlZwZG1WeU9pQjBhR2x6TG1OdmJuTmxibk4xY3k1MllXeDFaUzVoWkdSeVpYTnpMQ0JoYlc5MWJuUXNJR1psWlRvZ01DQjlLU3dnWTI5dVptbG5YU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQnBkSGh1WDI1bGVIUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRPR0ptWmpnek9EY2dMeThnYldWMGFHOWtJQ0pqYjI1bWFXZDFjbVVvY0dGNUxHSjVkR1ZiWFNsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGJuUmpYek1nTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TWpBMkNpQWdJQ0F2THlCamIyNW1hV2QxY21WRGIyNXpaVzV6ZFhNb1kyOXVabWxuT2lCaWVYUmxjeWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTFqYjI1elpXNXpkWE10YUc5emRDNWhiR2R2TG5Sek9qcE5iMk5yUjNWcGJHUkRiMjV6Wlc1emRYTkliM04wTG1OdmJuTmxibk4xYzBGamRHbHZiazFpY2loa1lYUmhPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3B6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdFkyOXVjMlZ1YzNWekxXaHZjM1F1WVd4bmJ5NTBjem82VFc5amEwZDFhV3hrUTI5dWMyVnVjM1Z6U0c5emRDNWpiMjV6Wlc1emRYTkJZM1JwYjI1TlluSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6b3hPRGtLSUNBZ0lDOHZJR052Ym5ObGJuTjFjMEZqZEdsdmJrMWljaWhrWVhSaE9pQmllWFJsY3lrNklIVnBiblEyTkNCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxamIyNXpaVzV6ZFhNdGFHOXpkQzVoYkdkdkxuUnpPakU1TUMweE9UTUtJQ0FnSUM4dklISmxkSFZ5YmlCaFltbERZV3hzUEhSNWNHVnZaaUJHYVhobFpGTnBaMjVsY2tkMWFXeGtRMjl1YzJWdWMzVnpMbkJ5YjNSdmRIbHdaUzVqYjI1elpXNXpkWE5CWTNScGIyNU5ZbkkrS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUhSb2FYTXVZMjl1YzJWdWMzVnpMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYlpHRjBZVjBzQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxXTnZibk5sYm5OMWN5MW9iM04wTG1Gc1oyOHVkSE02TVRreUNpQWdJQ0F2THlCaGNtZHpPaUJiWkdGMFlWMHNDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pveE9URUtJQ0FnSUM4dklHRndjRWxrT2lCMGFHbHpMbU52Ym5ObGJuTjFjeTUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RZMjl1YzJWdWMzVnpMV2h2YzNRdVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z1kyOXVjMlZ1YzNWeklEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tIc2dhMlY1T2lCSGRXbHNaRWRzYjJKaGJGTjBZWFJsUzJWNVEyOXVjMlZ1YzNWeklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmpiMjV6Wlc1emRYTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0WTI5dWMyVnVjM1Z6TFdodmMzUXVZV3huYnk1MGN6b3hPVEVLSUNBZ0lDOHZJR0Z3Y0Vsa09pQjBhR2x6TG1OdmJuTmxibk4xY3k1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxamIyNXpaVzV6ZFhNdGFHOXpkQzVoYkdkdkxuUnpPakU1TUMweE9UTUtJQ0FnSUM4dklISmxkSFZ5YmlCaFltbERZV3hzUEhSNWNHVnZaaUJHYVhobFpGTnBaMjVsY2tkMWFXeGtRMjl1YzJWdWMzVnpMbkJ5YjNSdmRIbHdaUzVqYjI1elpXNXpkWE5CWTNScGIyNU5ZbkkrS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1E2SUhSb2FYTXVZMjl1YzJWdWMzVnpMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQmhjbWR6T2lCYlpHRjBZVjBzQ2lBZ0lDQXZMeUI5S1M1eVpYUjFjbTVXWVd4MVpRb2dJQ0FnWW5sMFpXTWdPQ0F2THlCdFpYUm9iMlFnSW1OdmJuTmxibk4xYzBGamRHbHZiazFpY2loaWVYUmxXMTBwZFdsdWREWTBJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGJuUmpYek1nTHk4Z1lYQndiQW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUo1ZEdWeklHaGhjeUIyWVd4cFpDQndjbVZtYVhnS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2RXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZBQUVJQm9BZ0pna0VGUjk4ZFFsamIyNXpaVzV6ZFhNd0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJCM0J5YjJkeVlXMEV1WVphWVFSYk9vc0FCS25vSTgwRXcrdDgxQVNGZmljWE1Sa1VSREVZUVFCUmdnTUVTZ3BkeFFSeENXMGxCRUU0S2MwbkJJSUNCSW5jdG5rRVdRWWp6U2NGSndZbkJ5Y0lnZ0lFZzBic0hnU2tYWXFaTmhvQWpnd0F4QURUQVBNQnB3RzdBaXNDdmdMekF6c0RqUU9vQS9NQWdBUk1YR0c2TmhvQWpnRUFBUUNBRG5Wd1ozSmhaR1ZmWVhCd1gzQnpLbWVBRFdGa1pGOXdiSFZuYVc1ZmNITXFaNEFUY21WdGIzWmxYMlY0WldOMWRHbHZibDl3Y3lwbmdCQnlaVzF2ZG1WZmNHeDFaMmx1WDNCekttZUFFV0ZrWkY5aGJHeHZkMkZ1WTJWelgzQnpLbWVBRkhKbGJXOTJaVjloYkd4dmQyRnVZMlZ6WDNCekttZUFEVzVsZDE5bGMyTnliM2RmY0hNcVo0QVFkRzluWjJ4bFgyVnpZM0p2ZDE5d2N5cG5nQTkxY0dSaGRHVmZaM1ZwYkdSZmNITXFaeU5ETmhvQlNSVWtFa1FYSzB5NVNDTkROaG9CU1JVa0VrUVhOaG9DU1NKWmdRSUlTd0VWRWtSWEFnQXJUZ0s3STBNMkdnRkhBaUpaZ1FJSVRCVVNSTEVydlV4SlR3SkVJUVFOUVFDUVNDc2lJUVM2SzcxTVNVOENSQ0VFRFVFQWR5RUVDU3NoQkU4Q3VpS3lOaUt5TnlTeU5ZRU1zalFpc2htQkE3STRnQVFOZ1FGRHNrSk1za0N5UUlBRWpuazFqYklhc2hvbHNoQWlzZ0d6dHdBOUtVc0JaN0ZKY2doRU1nR3lDTElISTdJUUlySUJzN0V5Q0JZaXNobExBYklZZ0FRK2h3RTdzaHF5R2lXeUVDS3lBYk1XS0V4UXNDTkRTSUFBUXYrTUt5SlBBcnBDLzI2eElpbGxSTElZSndTeUdpV3lFQ0t5QWJNalF6WWFBVWtWSkJKRU5ob0NTUlVrRWtRMkdnTkpGWUVZRWtTeElpbGxSRW15R0lBRTA5S1dRN0lhSmJJUUlySUJzN1ErU1ZjRUFFeFhBQVFvRWtSSkZTUVNSQmV4U3dGeUNFU3lCN0lJSTdJUUlySUJ0cklZZ0FSb1JKQ0lzaHBQQXJJYVRMSWFzaG9sc2hBaXNnR3pJME0yR2dGSkZZRWdFa1EyR2dKSkZTUVNSRFlhQTBrVkl4SkVOaG9FU1NKWmdRSUlTd0VWRWtTeElpbGxSRW15R0lBRTlRZ0k3N0lhU3dPeUdrc0VzaG9sc2hBaXNnR3p0RDVKVndRQVRGY0FCQ2dTUkVrVkl4SkVJbE94U3dGeUNFU0I1SzhCSWs4RFRiSUlzZ2Nqc2hBaXNnRzJzaGlBQkQxMUplbXlHazhEc2hwUEFySWFUTElhc2hvbHNoQWlzZ0d6STBNMkdnRkpGU1FTUkxFaUtXVkVzaGduQmJJYXNob2xzaEFpc2dHenRENUpWd1FBVEZjQUJDZ1NSRWtWZ1NFU1JDaE1VTEFqUXpZYUFVa1ZKQkpFTmhvQ1NTSlpnU0FMZ1FJSVN3RVZFa1N4SWlsbFJMSVlKd2F5R2t5eUdySWFKYklRSXJJQnM3UStTVmNFQUV4WEFBUW9Fa1JKRlNRU1JDaE1VTEFqUXpZYUFVa1ZnU0FTUkRZYUFra2lXWUVDQ0VzQkZSSkVOaG9EU1JVa0VrU3hJaWxsUkxJWUp3ZXlHazhDc2hwTXNocXlHaVd5RUNLeUFiTzBQa2xYQkFCTVZ3QUVLQkpFU1JVa0VrUW9URkN3STBNMkdnRkpJbG1CQWdoTEFSVVNSRmNDQUlnQXRCWW9URkN3STBNMkdnRkpGU1FTUkRZYUFra2lXWUVDQ0VzQkZSSkVTVmNDQUlnQWtMRWlLV1ZFU1hJSVJFOENzZ2l5QnlPeUVDS3lBYmF5R0lBRVorMWY3YklhVExJYXNob2xzaEFpc2dHekkwTTJHZ0ZKSWxtQkFnaExBUlVTUkxFaUtXVkVTYklZZ0FTcVBrQ29zaHBMQWJJYUpiSVFJcklCczdRK1NWY0VBRXhYQUFRb0VrUkpGU1FTUkJleFN3RnlDRVN5QjdJSUk3SVFJcklCdHJJWWdBU0wvNE9Ic2hxeUdpV3lFQ0t5QWJNalE0b0JBYkdML3hVV1Z3WUNpLzlRSWlsbFJMSVlKd2l5R3JJYUpiSVFJcklCczdRK1NWY0VBRXhYQUFRb0VrUkpGU1FTUkJlSiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
