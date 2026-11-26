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

namespace Arc56.Generated.akita_protocol.akita_sc.AkitaDAOTypes_3f1c4600
{


    public class AkitaDAOTypesProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AkitaDAOTypesProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ProposalAddAllowances : AVMObjectType
            {
                public string Escrow { get; set; }

                public Structs.ProposalAddAllowancesAllowances[] Allowances { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.From(Escrow);
                    stringRef[ret.Count] = vEscrow.Encode();
                    ret.AddRange(new byte[2]);
                    var arrAllowances = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ProposalAddAllowancesAllowances>(x => Structs.ProposalAddAllowancesAllowances.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrAllowances.Value = (Allowances ?? Array.Empty<Structs.ProposalAddAllowancesAllowances>()).ToList();
                    stringRef[ret.Count] = arrAllowances.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalAddAllowances Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalAddAllowances();
                    var indexEscrow = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.Decode(bytes.Skip(indexEscrow + prefixOffset).ToArray());
                    var valueEscrow = vEscrow.ToValue();
                    if (valueEscrow is string vEscrowValue) { ret.Escrow = vEscrowValue; }
                    var indexAllowances = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrAllowances = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ProposalAddAllowancesAllowances>(x => Structs.ProposalAddAllowancesAllowances.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrAllowances.Decode(bytes.Skip(indexAllowances + prefixOffset).ToArray());
                    ret.Allowances = arrAllowances.Value.ToArray();
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalAddAllowances);
                }
                public bool Equals(ProposalAddAllowances? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalAddAllowances left, ProposalAddAllowances right)
                {
                    return EqualityComparer<ProposalAddAllowances>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalAddAllowances left, ProposalAddAllowances right)
                {
                    return !(left == right);
                }

            }

            public class ProposalAddNamedPlugin : AVMObjectType
            {
                public string Name { get; set; }

                public ulong Plugin { get; set; }

                public Algorand.Address Caller { get; set; }

                public string Escrow { get; set; }

                public byte DelegationType { get; set; }

                public ulong LastValid { get; set; }

                public ulong Cooldown { get; set; }

                public Structs.ProposalAddNamedPluginMethods[] Methods { get; set; }

                public bool UseRounds { get; set; }

                public bool UseExecutionKey { get; set; }

                public bool CoverFees { get; set; }

                public bool DefaultToEscrow { get; set; }

                public ulong Fee { get; set; }

                public ulong Power { get; set; }

                public ulong Duration { get; set; }

                public ulong Participation { get; set; }

                public ulong Approval { get; set; }

                public string SourceLink { get; set; }

                public Structs.ProposalAddAllowancesAllowances[] Allowances { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPlugin.From(Plugin);
                    ret.AddRange(vPlugin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCaller.From(Caller);
                    ret.AddRange(vCaller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.From(Escrow);
                    stringRef[ret.Count] = vEscrow.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDelegationType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vDelegationType.From(DelegationType);
                    ret.AddRange(vDelegationType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastValid.From(LastValid);
                    ret.AddRange(vLastValid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCooldown = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCooldown.From(Cooldown);
                    ret.AddRange(vCooldown.Encode());
                    var arrMethods = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ProposalAddNamedPluginMethods>(x => Structs.ProposalAddNamedPluginMethods.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrMethods.Value = (Methods ?? Array.Empty<Structs.ProposalAddNamedPluginMethods>()).ToList();
                    stringRef[ret.Count] = arrMethods.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUseRounds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vUseRounds.From(UseRounds);
                    ret.AddRange(vUseRounds.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUseExecutionKey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vUseExecutionKey.From(UseExecutionKey);
                    ret.AddRange(vUseExecutionKey.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCoverFees = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vCoverFees.From(CoverFees);
                    ret.AddRange(vCoverFees.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDefaultToEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vDefaultToEscrow.From(DefaultToEscrow);
                    ret.AddRange(vDefaultToEscrow.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSourceLink = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSourceLink.From(SourceLink);
                    stringRef[ret.Count] = vSourceLink.Encode();
                    ret.AddRange(new byte[2]);
                    var arrAllowances = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ProposalAddAllowancesAllowances>(x => Structs.ProposalAddAllowancesAllowances.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrAllowances.Value = (Allowances ?? Array.Empty<Structs.ProposalAddAllowancesAllowances>()).ToList();
                    stringRef[ret.Count] = arrAllowances.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalAddNamedPlugin Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalAddNamedPlugin();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPlugin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePlugin = vPlugin.ToValue();
                    if (valuePlugin is ulong vPluginValue) { ret.Plugin = vPluginValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCaller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCaller = vCaller.ToValue();
                    if (valueCaller is Algorand.Address vCallerValue) { ret.Caller = vCallerValue; }
                    var indexEscrow = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.Decode(bytes.Skip(indexEscrow + prefixOffset).ToArray());
                    var valueEscrow = vEscrow.ToValue();
                    if (valueEscrow is string vEscrowValue) { ret.Escrow = vEscrowValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDelegationType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vDelegationType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDelegationType = vDelegationType.ToValue();
                    if (valueDelegationType is byte vDelegationTypeValue) { ret.DelegationType = vDelegationTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastValid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastValid = vLastValid.ToValue();
                    if (valueLastValid is ulong vLastValidValue) { ret.LastValid = vLastValidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCooldown = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCooldown.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCooldown = vCooldown.ToValue();
                    if (valueCooldown is ulong vCooldownValue) { ret.Cooldown = vCooldownValue; }
                    var indexMethods = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrMethods = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ProposalAddNamedPluginMethods>(x => Structs.ProposalAddNamedPluginMethods.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrMethods.Decode(bytes.Skip(indexMethods + prefixOffset).ToArray());
                    ret.Methods = arrMethods.Value.ToArray();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUseRounds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vUseRounds.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUseRounds = vUseRounds.ToValue();
                    if (valueUseRounds is bool vUseRoundsValue) { ret.UseRounds = vUseRoundsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUseExecutionKey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vUseExecutionKey.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUseExecutionKey = vUseExecutionKey.ToValue();
                    if (valueUseExecutionKey is bool vUseExecutionKeyValue) { ret.UseExecutionKey = vUseExecutionKeyValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCoverFees = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vCoverFees.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCoverFees = vCoverFees.ToValue();
                    if (valueCoverFees is bool vCoverFeesValue) { ret.CoverFees = vCoverFeesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDefaultToEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vDefaultToEscrow.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDefaultToEscrow = vDefaultToEscrow.ToValue();
                    if (valueDefaultToEscrow is bool vDefaultToEscrowValue) { ret.DefaultToEscrow = vDefaultToEscrowValue; }
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
                    var indexSourceLink = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSourceLink = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSourceLink.Decode(bytes.Skip(indexSourceLink + prefixOffset).ToArray());
                    var valueSourceLink = vSourceLink.ToValue();
                    if (valueSourceLink is string vSourceLinkValue) { ret.SourceLink = vSourceLinkValue; }
                    var indexAllowances = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrAllowances = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ProposalAddAllowancesAllowances>(x => Structs.ProposalAddAllowancesAllowances.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrAllowances.Decode(bytes.Skip(indexAllowances + prefixOffset).ToArray());
                    ret.Allowances = arrAllowances.Value.ToArray();
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalAddNamedPlugin);
                }
                public bool Equals(ProposalAddNamedPlugin? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalAddNamedPlugin left, ProposalAddNamedPlugin right)
                {
                    return EqualityComparer<ProposalAddNamedPlugin>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalAddNamedPlugin left, ProposalAddNamedPlugin right)
                {
                    return !(left == right);
                }

            }

            public class ProposalAddPlugin : AVMObjectType
            {
                public ulong Plugin { get; set; }

                public Algorand.Address Caller { get; set; }

                public string Escrow { get; set; }

                public byte DelegationType { get; set; }

                public ulong LastValid { get; set; }

                public ulong Cooldown { get; set; }

                public Structs.ProposalAddNamedPluginMethods[] Methods { get; set; }

                public bool UseRounds { get; set; }

                public bool UseExecutionKey { get; set; }

                public bool CoverFees { get; set; }

                public bool DefaultToEscrow { get; set; }

                public ulong Fee { get; set; }

                public ulong Power { get; set; }

                public ulong Duration { get; set; }

                public ulong Participation { get; set; }

                public ulong Approval { get; set; }

                public string SourceLink { get; set; }

                public Structs.ProposalAddAllowancesAllowances[] Allowances { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPlugin.From(Plugin);
                    ret.AddRange(vPlugin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCaller.From(Caller);
                    ret.AddRange(vCaller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.From(Escrow);
                    stringRef[ret.Count] = vEscrow.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDelegationType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vDelegationType.From(DelegationType);
                    ret.AddRange(vDelegationType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastValid.From(LastValid);
                    ret.AddRange(vLastValid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCooldown = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCooldown.From(Cooldown);
                    ret.AddRange(vCooldown.Encode());
                    var arrMethods = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ProposalAddNamedPluginMethods>(x => Structs.ProposalAddNamedPluginMethods.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrMethods.Value = (Methods ?? Array.Empty<Structs.ProposalAddNamedPluginMethods>()).ToList();
                    stringRef[ret.Count] = arrMethods.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUseRounds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vUseRounds.From(UseRounds);
                    ret.AddRange(vUseRounds.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUseExecutionKey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vUseExecutionKey.From(UseExecutionKey);
                    ret.AddRange(vUseExecutionKey.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCoverFees = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vCoverFees.From(CoverFees);
                    ret.AddRange(vCoverFees.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDefaultToEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vDefaultToEscrow.From(DefaultToEscrow);
                    ret.AddRange(vDefaultToEscrow.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSourceLink = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSourceLink.From(SourceLink);
                    stringRef[ret.Count] = vSourceLink.Encode();
                    ret.AddRange(new byte[2]);
                    var arrAllowances = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ProposalAddAllowancesAllowances>(x => Structs.ProposalAddAllowancesAllowances.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrAllowances.Value = (Allowances ?? Array.Empty<Structs.ProposalAddAllowancesAllowances>()).ToList();
                    stringRef[ret.Count] = arrAllowances.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalAddPlugin Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalAddPlugin();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPlugin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePlugin = vPlugin.ToValue();
                    if (valuePlugin is ulong vPluginValue) { ret.Plugin = vPluginValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCaller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCaller = vCaller.ToValue();
                    if (valueCaller is Algorand.Address vCallerValue) { ret.Caller = vCallerValue; }
                    var indexEscrow = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.Decode(bytes.Skip(indexEscrow + prefixOffset).ToArray());
                    var valueEscrow = vEscrow.ToValue();
                    if (valueEscrow is string vEscrowValue) { ret.Escrow = vEscrowValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDelegationType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vDelegationType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDelegationType = vDelegationType.ToValue();
                    if (valueDelegationType is byte vDelegationTypeValue) { ret.DelegationType = vDelegationTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastValid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastValid = vLastValid.ToValue();
                    if (valueLastValid is ulong vLastValidValue) { ret.LastValid = vLastValidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCooldown = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCooldown.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCooldown = vCooldown.ToValue();
                    if (valueCooldown is ulong vCooldownValue) { ret.Cooldown = vCooldownValue; }
                    var indexMethods = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrMethods = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ProposalAddNamedPluginMethods>(x => Structs.ProposalAddNamedPluginMethods.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrMethods.Decode(bytes.Skip(indexMethods + prefixOffset).ToArray());
                    ret.Methods = arrMethods.Value.ToArray();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUseRounds = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vUseRounds.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUseRounds = vUseRounds.ToValue();
                    if (valueUseRounds is bool vUseRoundsValue) { ret.UseRounds = vUseRoundsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUseExecutionKey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vUseExecutionKey.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUseExecutionKey = vUseExecutionKey.ToValue();
                    if (valueUseExecutionKey is bool vUseExecutionKeyValue) { ret.UseExecutionKey = vUseExecutionKeyValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCoverFees = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vCoverFees.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCoverFees = vCoverFees.ToValue();
                    if (valueCoverFees is bool vCoverFeesValue) { ret.CoverFees = vCoverFeesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDefaultToEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vDefaultToEscrow.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDefaultToEscrow = vDefaultToEscrow.ToValue();
                    if (valueDefaultToEscrow is bool vDefaultToEscrowValue) { ret.DefaultToEscrow = vDefaultToEscrowValue; }
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
                    var indexSourceLink = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSourceLink = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSourceLink.Decode(bytes.Skip(indexSourceLink + prefixOffset).ToArray());
                    var valueSourceLink = vSourceLink.ToValue();
                    if (valueSourceLink is string vSourceLinkValue) { ret.SourceLink = vSourceLinkValue; }
                    var indexAllowances = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrAllowances = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ProposalAddAllowancesAllowances>(x => Structs.ProposalAddAllowancesAllowances.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrAllowances.Decode(bytes.Skip(indexAllowances + prefixOffset).ToArray());
                    ret.Allowances = arrAllowances.Value.ToArray();
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalAddPlugin);
                }
                public bool Equals(ProposalAddPlugin? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalAddPlugin left, ProposalAddPlugin right)
                {
                    return EqualityComparer<ProposalAddPlugin>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalAddPlugin left, ProposalAddPlugin right)
                {
                    return !(left == right);
                }

            }

            public class ProposalChangeAdmin : AVMObjectType
            {
                public Algorand.Address Admin { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAdmin.From(Admin);
                    ret.AddRange(vAdmin.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalChangeAdmin Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ProposalChangeAdmin();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdmin = vAdmin.ToValue();
                    if (valueAdmin is Algorand.Address vAdminValue) { ret.Admin = vAdminValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalChangeAdmin);
                }
                public bool Equals(ProposalChangeAdmin? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalChangeAdmin left, ProposalChangeAdmin right)
                {
                    return EqualityComparer<ProposalChangeAdmin>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalChangeAdmin left, ProposalChangeAdmin right)
                {
                    return !(left == right);
                }

            }

            public class ProposalDeleteEscrow : AVMObjectType
            {
                public string Escrow { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.From(Escrow);
                    stringRef[ret.Count] = vEscrow.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalDeleteEscrow Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalDeleteEscrow();
                    var indexEscrow = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.Decode(bytes.Skip(indexEscrow + prefixOffset).ToArray());
                    var valueEscrow = vEscrow.ToValue();
                    if (valueEscrow is string vEscrowValue) { ret.Escrow = vEscrowValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalDeleteEscrow);
                }
                public bool Equals(ProposalDeleteEscrow? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalDeleteEscrow left, ProposalDeleteEscrow right)
                {
                    return EqualityComparer<ProposalDeleteEscrow>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalDeleteEscrow left, ProposalDeleteEscrow right)
                {
                    return !(left == right);
                }

            }

            public class ProposalExecuteNamedPlugin : AVMObjectType
            {
                public string Name { get; set; }

                public byte[] ExecutionKey { get; set; }

                public byte[][] Groups { get; set; }

                public ulong FirstValid { get; set; }

                public ulong LastValid { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutionKey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vExecutionKey.From(ExecutionKey);
                    ret.AddRange(vExecutionKey.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGroups = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32][]");
                    vGroups.From(Groups);
                    ret.AddRange(vGroups.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirstValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFirstValid.From(FirstValid);
                    ret.AddRange(vFirstValid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastValid.From(LastValid);
                    ret.AddRange(vLastValid.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalExecuteNamedPlugin Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalExecuteNamedPlugin();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutionKey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vExecutionKey.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExecutionKey = vExecutionKey.ToValue();
                    if (valueExecutionKey is byte[] vExecutionKeyValue) { ret.ExecutionKey = vExecutionKeyValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGroups = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32][]");
                    count = vGroups.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGroups = vGroups.ToValue();
                    if (valueGroups is byte[][] vGroupsValue) { ret.Groups = vGroupsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirstValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFirstValid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFirstValid = vFirstValid.ToValue();
                    if (valueFirstValid is ulong vFirstValidValue) { ret.FirstValid = vFirstValidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastValid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastValid = vLastValid.ToValue();
                    if (valueLastValid is ulong vLastValidValue) { ret.LastValid = vLastValidValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalExecuteNamedPlugin);
                }
                public bool Equals(ProposalExecuteNamedPlugin? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalExecuteNamedPlugin left, ProposalExecuteNamedPlugin right)
                {
                    return EqualityComparer<ProposalExecuteNamedPlugin>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalExecuteNamedPlugin left, ProposalExecuteNamedPlugin right)
                {
                    return !(left == right);
                }

            }

            public class ProposalExecutePlugin : AVMObjectType
            {
                public ulong Plugin { get; set; }

                public string Escrow { get; set; }

                public byte[] ExecutionKey { get; set; }

                public byte[][] Groups { get; set; }

                public ulong FirstValid { get; set; }

                public ulong LastValid { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPlugin.From(Plugin);
                    ret.AddRange(vPlugin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.From(Escrow);
                    stringRef[ret.Count] = vEscrow.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutionKey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vExecutionKey.From(ExecutionKey);
                    ret.AddRange(vExecutionKey.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGroups = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32][]");
                    vGroups.From(Groups);
                    ret.AddRange(vGroups.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirstValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFirstValid.From(FirstValid);
                    ret.AddRange(vFirstValid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastValid.From(LastValid);
                    ret.AddRange(vLastValid.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalExecutePlugin Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalExecutePlugin();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPlugin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePlugin = vPlugin.ToValue();
                    if (valuePlugin is ulong vPluginValue) { ret.Plugin = vPluginValue; }
                    var indexEscrow = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.Decode(bytes.Skip(indexEscrow + prefixOffset).ToArray());
                    var valueEscrow = vEscrow.ToValue();
                    if (valueEscrow is string vEscrowValue) { ret.Escrow = vEscrowValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutionKey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vExecutionKey.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExecutionKey = vExecutionKey.ToValue();
                    if (valueExecutionKey is byte[] vExecutionKeyValue) { ret.ExecutionKey = vExecutionKeyValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGroups = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32][]");
                    count = vGroups.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGroups = vGroups.ToValue();
                    if (valueGroups is byte[][] vGroupsValue) { ret.Groups = vGroupsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirstValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFirstValid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFirstValid = vFirstValid.ToValue();
                    if (valueFirstValid is ulong vFirstValidValue) { ret.FirstValid = vFirstValidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastValid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastValid = vLastValid.ToValue();
                    if (valueLastValid is ulong vLastValidValue) { ret.LastValid = vLastValidValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalExecutePlugin);
                }
                public bool Equals(ProposalExecutePlugin? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalExecutePlugin left, ProposalExecutePlugin right)
                {
                    return EqualityComparer<ProposalExecutePlugin>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalExecutePlugin left, ProposalExecutePlugin right)
                {
                    return !(left == right);
                }

            }

            public class ProposalNewEscrow : AVMObjectType
            {
                public string Escrow { get; set; }

                public Algorand.Address Address { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.From(Escrow);
                    stringRef[ret.Count] = vEscrow.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAddress.From(Address);
                    ret.AddRange(vAddress.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalNewEscrow Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalNewEscrow();
                    uint count = 0;
                    var indexEscrow = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.Decode(bytes.Skip(indexEscrow + prefixOffset).ToArray());
                    var valueEscrow = vEscrow.ToValue();
                    if (valueEscrow is string vEscrowValue) { ret.Escrow = vEscrowValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAddress = vAddress.ToValue();
                    if (valueAddress is Algorand.Address vAddressValue) { ret.Address = vAddressValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalNewEscrow);
                }
                public bool Equals(ProposalNewEscrow? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalNewEscrow left, ProposalNewEscrow right)
                {
                    return EqualityComparer<ProposalNewEscrow>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalNewEscrow left, ProposalNewEscrow right)
                {
                    return !(left == right);
                }

            }

            public class ProposalReclaim : AVMObjectType
            {
                public string Escrow { get; set; }

                public Structs.ProposalReclaimReclaims[] Reclaims { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.From(Escrow);
                    stringRef[ret.Count] = vEscrow.Encode();
                    ret.AddRange(new byte[2]);
                    var arrReclaims = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ProposalReclaimReclaims>(x => Structs.ProposalReclaimReclaims.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrReclaims.Value = (Reclaims ?? Array.Empty<Structs.ProposalReclaimReclaims>()).ToList();
                    stringRef[ret.Count] = arrReclaims.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalReclaim Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalReclaim();
                    var indexEscrow = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.Decode(bytes.Skip(indexEscrow + prefixOffset).ToArray());
                    var valueEscrow = vEscrow.ToValue();
                    if (valueEscrow is string vEscrowValue) { ret.Escrow = vEscrowValue; }
                    var indexReclaims = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrReclaims = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ProposalReclaimReclaims>(x => Structs.ProposalReclaimReclaims.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrReclaims.Decode(bytes.Skip(indexReclaims + prefixOffset).ToArray());
                    ret.Reclaims = arrReclaims.Value.ToArray();
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalReclaim);
                }
                public bool Equals(ProposalReclaim? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalReclaim left, ProposalReclaim right)
                {
                    return EqualityComparer<ProposalReclaim>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalReclaim left, ProposalReclaim right)
                {
                    return !(left == right);
                }

            }

            public class ProposalRemoveAllowances : AVMObjectType
            {
                public string Escrow { get; set; }

                public ulong[] Assets { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.From(Escrow);
                    stringRef[ret.Count] = vEscrow.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vAssets.From(Assets);
                    ret.AddRange(vAssets.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalRemoveAllowances Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalRemoveAllowances();
                    uint count = 0;
                    var indexEscrow = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.Decode(bytes.Skip(indexEscrow + prefixOffset).ToArray());
                    var valueEscrow = vEscrow.ToValue();
                    if (valueEscrow is string vEscrowValue) { ret.Escrow = vEscrowValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vAssets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssets = vAssets.ToValue();
                    if (valueAssets is ulong[] vAssetsValue) { ret.Assets = vAssetsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalRemoveAllowances);
                }
                public bool Equals(ProposalRemoveAllowances? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalRemoveAllowances left, ProposalRemoveAllowances right)
                {
                    return EqualityComparer<ProposalRemoveAllowances>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalRemoveAllowances left, ProposalRemoveAllowances right)
                {
                    return !(left == right);
                }

            }

            public class ProposalRemoveExecutePlugin : AVMObjectType
            {
                public byte[] ExecutionKey { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutionKey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vExecutionKey.From(ExecutionKey);
                    ret.AddRange(vExecutionKey.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalRemoveExecutePlugin Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ProposalRemoveExecutePlugin();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutionKey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vExecutionKey.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExecutionKey = vExecutionKey.ToValue();
                    if (valueExecutionKey is byte[] vExecutionKeyValue) { ret.ExecutionKey = vExecutionKeyValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalRemoveExecutePlugin);
                }
                public bool Equals(ProposalRemoveExecutePlugin? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalRemoveExecutePlugin left, ProposalRemoveExecutePlugin right)
                {
                    return EqualityComparer<ProposalRemoveExecutePlugin>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalRemoveExecutePlugin left, ProposalRemoveExecutePlugin right)
                {
                    return !(left == right);
                }

            }

            public class ProposalRemoveNamedPlugin : AVMObjectType
            {
                public string Name { get; set; }

                public ulong Plugin { get; set; }

                public Algorand.Address Caller { get; set; }

                public string Escrow { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPlugin.From(Plugin);
                    ret.AddRange(vPlugin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCaller.From(Caller);
                    ret.AddRange(vCaller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.From(Escrow);
                    stringRef[ret.Count] = vEscrow.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalRemoveNamedPlugin Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalRemoveNamedPlugin();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPlugin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePlugin = vPlugin.ToValue();
                    if (valuePlugin is ulong vPluginValue) { ret.Plugin = vPluginValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCaller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCaller = vCaller.ToValue();
                    if (valueCaller is Algorand.Address vCallerValue) { ret.Caller = vCallerValue; }
                    var indexEscrow = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.Decode(bytes.Skip(indexEscrow + prefixOffset).ToArray());
                    var valueEscrow = vEscrow.ToValue();
                    if (valueEscrow is string vEscrowValue) { ret.Escrow = vEscrowValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalRemoveNamedPlugin);
                }
                public bool Equals(ProposalRemoveNamedPlugin? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalRemoveNamedPlugin left, ProposalRemoveNamedPlugin right)
                {
                    return EqualityComparer<ProposalRemoveNamedPlugin>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalRemoveNamedPlugin left, ProposalRemoveNamedPlugin right)
                {
                    return !(left == right);
                }

            }

            public class ProposalRemovePlugin : AVMObjectType
            {
                public ulong Plugin { get; set; }

                public Algorand.Address Caller { get; set; }

                public string Escrow { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPlugin.From(Plugin);
                    ret.AddRange(vPlugin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCaller.From(Caller);
                    ret.AddRange(vCaller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.From(Escrow);
                    stringRef[ret.Count] = vEscrow.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalRemovePlugin Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalRemovePlugin();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPlugin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPlugin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePlugin = vPlugin.ToValue();
                    if (valuePlugin is ulong vPluginValue) { ret.Plugin = vPluginValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCaller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCaller = vCaller.ToValue();
                    if (valueCaller is Algorand.Address vCallerValue) { ret.Caller = vCallerValue; }
                    var indexEscrow = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.Decode(bytes.Skip(indexEscrow + prefixOffset).ToArray());
                    var valueEscrow = vEscrow.ToValue();
                    if (valueEscrow is string vEscrowValue) { ret.Escrow = vEscrowValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalRemovePlugin);
                }
                public bool Equals(ProposalRemovePlugin? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalRemovePlugin left, ProposalRemovePlugin right)
                {
                    return EqualityComparer<ProposalRemovePlugin>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalRemovePlugin left, ProposalRemovePlugin right)
                {
                    return !(left == right);
                }

            }

            public class ProposalToggleEscrowLock : AVMObjectType
            {
                public string Escrow { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.From(Escrow);
                    stringRef[ret.Count] = vEscrow.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalToggleEscrowLock Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalToggleEscrowLock();
                    var indexEscrow = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrow = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEscrow.Decode(bytes.Skip(indexEscrow + prefixOffset).ToArray());
                    var valueEscrow = vEscrow.ToValue();
                    if (valueEscrow is string vEscrowValue) { ret.Escrow = vEscrowValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalToggleEscrowLock);
                }
                public bool Equals(ProposalToggleEscrowLock? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalToggleEscrowLock left, ProposalToggleEscrowLock right)
                {
                    return EqualityComparer<ProposalToggleEscrowLock>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalToggleEscrowLock left, ProposalToggleEscrowLock right)
                {
                    return !(left == right);
                }

            }

            public class ProposalUpdateField : AVMObjectType
            {
                public string Field { get; set; }

                public byte[] Value { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField.From(Field);
                    stringRef[ret.Count] = vField.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vValue.From(Value);
                    ret.AddRange(vValue.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalUpdateField Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ProposalUpdateField();
                    uint count = 0;
                    var indexField = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField.Decode(bytes.Skip(indexField + prefixOffset).ToArray());
                    var valueField = vField.ToValue();
                    if (valueField is string vFieldValue) { ret.Field = vFieldValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is byte[] vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalUpdateField);
                }
                public bool Equals(ProposalUpdateField? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalUpdateField left, ProposalUpdateField right)
                {
                    return EqualityComparer<ProposalUpdateField>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalUpdateField left, ProposalUpdateField right)
                {
                    return !(left == right);
                }

            }

            public class ProposalUpgradeApp : AVMObjectType
            {
                public ulong App { get; set; }

                public byte[] ExecutionKey { get; set; }

                public byte[][] Groups { get; set; }

                public ulong FirstValid { get; set; }

                public ulong LastValid { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vApp.From(App);
                    ret.AddRange(vApp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutionKey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vExecutionKey.From(ExecutionKey);
                    ret.AddRange(vExecutionKey.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGroups = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32][]");
                    vGroups.From(Groups);
                    ret.AddRange(vGroups.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirstValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFirstValid.From(FirstValid);
                    ret.AddRange(vFirstValid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastValid.From(LastValid);
                    ret.AddRange(vLastValid.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalUpgradeApp Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ProposalUpgradeApp();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vApp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApp = vApp.ToValue();
                    if (valueApp is ulong vAppValue) { ret.App = vAppValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutionKey = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vExecutionKey.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExecutionKey = vExecutionKey.ToValue();
                    if (valueExecutionKey is byte[] vExecutionKeyValue) { ret.ExecutionKey = vExecutionKeyValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGroups = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32][]");
                    count = vGroups.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGroups = vGroups.ToValue();
                    if (valueGroups is byte[][] vGroupsValue) { ret.Groups = vGroupsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFirstValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFirstValid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFirstValid = vFirstValid.ToValue();
                    if (valueFirstValid is ulong vFirstValidValue) { ret.FirstValid = vFirstValidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastValid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastValid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastValid = vLastValid.ToValue();
                    if (valueLastValid is ulong vLastValidValue) { ret.LastValid = vLastValidValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalUpgradeApp);
                }
                public bool Equals(ProposalUpgradeApp? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalUpgradeApp left, ProposalUpgradeApp right)
                {
                    return EqualityComparer<ProposalUpgradeApp>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalUpgradeApp left, ProposalUpgradeApp right)
                {
                    return !(left == right);
                }

            }

            public class ProposalAddAllowancesAllowances : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public byte Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public bool Field5 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ProposalAddAllowancesAllowances Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ProposalAddAllowancesAllowances();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte vField1Value) { ret.Field1 = vField1Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is bool vField5Value) { ret.Field5 = vField5Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalAddAllowancesAllowances);
                }
                public bool Equals(ProposalAddAllowancesAllowances? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalAddAllowancesAllowances left, ProposalAddAllowancesAllowances right)
                {
                    return EqualityComparer<ProposalAddAllowancesAllowances>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalAddAllowancesAllowances left, ProposalAddAllowancesAllowances right)
                {
                    return !(left == right);
                }

            }

            public class ProposalAddNamedPluginMethods : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4]");
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

                public static ProposalAddNamedPluginMethods Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ProposalAddNamedPluginMethods();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as ProposalAddNamedPluginMethods);
                }
                public bool Equals(ProposalAddNamedPluginMethods? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalAddNamedPluginMethods left, ProposalAddNamedPluginMethods right)
                {
                    return EqualityComparer<ProposalAddNamedPluginMethods>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalAddNamedPluginMethods left, ProposalAddNamedPluginMethods right)
                {
                    return !(left == right);
                }

            }

            public class ProposalReclaimReclaims : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public bool Field2 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static ProposalReclaimReclaims Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ProposalReclaimReclaims();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is bool vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ProposalReclaimReclaims);
                }
                public bool Equals(ProposalReclaimReclaims? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ProposalReclaimReclaims left, ProposalReclaimReclaims right)
                {
                    return EqualityComparer<ProposalReclaimReclaims>.Default.Equals(left, right);
                }
                public static bool operator !=(ProposalReclaimReclaims left, ProposalReclaimReclaims right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalUpgradeApp</param>
        public async Task<Structs.ProposalUpgradeApp> ProposalUpgradeAppShape(Structs.ProposalUpgradeApp shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 179, 88, 150 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalUpgradeApp.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalUpgradeAppShape_Transactions(Structs.ProposalUpgradeApp shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 179, 88, 150 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalAddPlugin</param>
        public async Task<Structs.ProposalAddPlugin> ProposalAddPluginShape(Structs.ProposalAddPlugin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 228, 186, 183 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalAddPlugin.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalAddPluginShape_Transactions(Structs.ProposalAddPlugin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 228, 186, 183 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalAddNamedPlugin</param>
        public async Task<Structs.ProposalAddNamedPlugin> ProposalAddNamedPluginShape(Structs.ProposalAddNamedPlugin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 213, 243, 255 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalAddNamedPlugin.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalAddNamedPluginShape_Transactions(Structs.ProposalAddNamedPlugin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 213, 243, 255 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalRemovePlugin</param>
        public async Task<Structs.ProposalRemovePlugin> ProposalRemovePluginShape(Structs.ProposalRemovePlugin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 148, 26, 44 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalRemovePlugin.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalRemovePluginShape_Transactions(Structs.ProposalRemovePlugin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 148, 26, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalRemoveNamedPlugin</param>
        public async Task<Structs.ProposalRemoveNamedPlugin> ProposalRemoveNamedPluginShape(Structs.ProposalRemoveNamedPlugin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 207, 34, 204 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalRemoveNamedPlugin.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalRemoveNamedPluginShape_Transactions(Structs.ProposalRemoveNamedPlugin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 207, 34, 204 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalExecutePlugin</param>
        public async Task<Structs.ProposalExecutePlugin> ProposalExecutePluginShape(Structs.ProposalExecutePlugin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 78, 247, 48 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalExecutePlugin.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalExecutePluginShape_Transactions(Structs.ProposalExecutePlugin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 78, 247, 48 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalExecuteNamedPlugin</param>
        public async Task<Structs.ProposalExecuteNamedPlugin> ProposalExecuteNamedPluginShape(Structs.ProposalExecuteNamedPlugin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 171, 94, 20 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalExecuteNamedPlugin.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalExecuteNamedPluginShape_Transactions(Structs.ProposalExecuteNamedPlugin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 171, 94, 20 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalRemoveExecutePlugin</param>
        public async Task<Structs.ProposalRemoveExecutePlugin> ProposalRemoveExecutePluginShape(Structs.ProposalRemoveExecutePlugin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 138, 189, 47 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalRemoveExecutePlugin.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalRemoveExecutePluginShape_Transactions(Structs.ProposalRemoveExecutePlugin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 138, 189, 47 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalAddAllowances</param>
        public async Task<Structs.ProposalAddAllowances> ProposalAddAllowancesShape(Structs.ProposalAddAllowances shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 175, 132, 32 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalAddAllowances.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalAddAllowancesShape_Transactions(Structs.ProposalAddAllowances shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 175, 132, 32 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalRemoveAllowances</param>
        public async Task<Structs.ProposalRemoveAllowances> ProposalRemoveAllowancesShape(Structs.ProposalRemoveAllowances shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 206, 92, 169 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalRemoveAllowances.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalRemoveAllowancesShape_Transactions(Structs.ProposalRemoveAllowances shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 206, 92, 169 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalNewEscrow</param>
        public async Task<Structs.ProposalNewEscrow> ProposalNewEscrowShape(Structs.ProposalNewEscrow shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 88, 213, 68 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalNewEscrow.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalNewEscrowShape_Transactions(Structs.ProposalNewEscrow shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 88, 213, 68 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalToggleEscrowLock</param>
        public async Task<Structs.ProposalToggleEscrowLock> ProposalToggleEscrowLockShape(Structs.ProposalToggleEscrowLock shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 170, 184, 29 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalToggleEscrowLock.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalToggleEscrowLockShape_Transactions(Structs.ProposalToggleEscrowLock shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 170, 184, 29 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalUpdateField</param>
        public async Task<Structs.ProposalUpdateField> ProposalUpdateFieldShape(Structs.ProposalUpdateField shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 157, 60, 203 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalUpdateField.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalUpdateFieldShape_Transactions(Structs.ProposalUpdateField shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 157, 60, 203 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalReclaim</param>
        public async Task<Structs.ProposalReclaim> ProposalReclaimShape(Structs.ProposalReclaim shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 64, 45, 27 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalReclaim.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalReclaimShape_Transactions(Structs.ProposalReclaim shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 64, 45, 27 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalChangeAdmin</param>
        public async Task<Structs.ProposalChangeAdmin> ProposalChangeAdminShape(Structs.ProposalChangeAdmin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 150, 234, 90 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalChangeAdmin.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalChangeAdminShape_Transactions(Structs.ProposalChangeAdmin shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 150, 234, 90 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="shape"> ProposalDeleteEscrow</param>
        public async Task<Structs.ProposalDeleteEscrow> ProposalDeleteEscrowShape(Structs.ProposalDeleteEscrow shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 48, 106, 75 };

            var result = await base.SimApp(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ProposalDeleteEscrow.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ProposalDeleteEscrowShape_Transactions(Structs.ProposalDeleteEscrow shape, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 48, 106, 75 };

            return await base.MakeTransactionList(new List<object> { abiHandle, shape }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWtpdGFEQU9UeXBlcyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJQcm9wb3NhbEFkZEFsbG93YW5jZXMiOlt7Im5hbWUiOiJlc2Nyb3ciLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYWxsb3dhbmNlcyIsInR5cGUiOiJQcm9wb3NhbEFkZEFsbG93YW5jZXNBbGxvd2FuY2VzW10ifV0sIlByb3Bvc2FsQWRkTmFtZWRQbHVnaW4iOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InBsdWdpbiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjYWxsZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImVzY3JvdyIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJkZWxlZ2F0aW9uVHlwZSIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6Imxhc3RWYWxpZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjb29sZG93biIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtZXRob2RzIiwidHlwZSI6IlByb3Bvc2FsQWRkTmFtZWRQbHVnaW5NZXRob2RzW10ifSx7Im5hbWUiOiJ1c2VSb3VuZHMiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6InVzZUV4ZWN1dGlvbktleSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiY292ZXJGZWVzIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJkZWZhdWx0VG9Fc2Nyb3ciLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZlZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwb3dlciIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkdXJhdGlvbiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwYXJ0aWNpcGF0aW9uIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFwcHJvdmFsIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNvdXJjZUxpbmsiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYWxsb3dhbmNlcyIsInR5cGUiOiJQcm9wb3NhbEFkZEFsbG93YW5jZXNBbGxvd2FuY2VzW10ifV0sIlByb3Bvc2FsQWRkUGx1Z2luIjpbeyJuYW1lIjoicGx1Z2luIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNhbGxlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZXNjcm93IiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImRlbGVnYXRpb25UeXBlIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoibGFzdFZhbGlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNvb2xkb3duIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im1ldGhvZHMiLCJ0eXBlIjoiUHJvcG9zYWxBZGROYW1lZFBsdWdpbk1ldGhvZHNbXSJ9LHsibmFtZSI6InVzZVJvdW5kcyIsInR5cGUiOiJib29sIn0seyJuYW1lIjoidXNlRXhlY3V0aW9uS2V5IiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJjb3ZlckZlZXMiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImRlZmF1bHRUb0VzY3JvdyIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmVlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InBvd2VyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImR1cmF0aW9uIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InBhcnRpY2lwYXRpb24iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXBwcm92YWwiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic291cmNlTGluayIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJhbGxvd2FuY2VzIiwidHlwZSI6IlByb3Bvc2FsQWRkQWxsb3dhbmNlc0FsbG93YW5jZXNbXSJ9XSwiUHJvcG9zYWxDaGFuZ2VBZG1pbiI6W3sibmFtZSI6ImFkbWluIiwidHlwZSI6ImFkZHJlc3MifV0sIlByb3Bvc2FsRGVsZXRlRXNjcm93IjpbeyJuYW1lIjoiZXNjcm93IiwidHlwZSI6InN0cmluZyJ9XSwiUHJvcG9zYWxFeGVjdXRlTmFtZWRQbHVnaW4iOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImV4ZWN1dGlvbktleSIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6Imdyb3VwcyIsInR5cGUiOiJieXRlWzMyXVtdIn0seyJuYW1lIjoiZmlyc3RWYWxpZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXN0VmFsaWQiLCJ0eXBlIjoidWludDY0In1dLCJQcm9wb3NhbEV4ZWN1dGVQbHVnaW4iOlt7Im5hbWUiOiJwbHVnaW4iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZXNjcm93IiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImV4ZWN1dGlvbktleSIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6Imdyb3VwcyIsInR5cGUiOiJieXRlWzMyXVtdIn0seyJuYW1lIjoiZmlyc3RWYWxpZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXN0VmFsaWQiLCJ0eXBlIjoidWludDY0In1dLCJQcm9wb3NhbE5ld0VzY3JvdyI6W3sibmFtZSI6ImVzY3JvdyIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJhZGRyZXNzIiwidHlwZSI6ImFkZHJlc3MifV0sIlByb3Bvc2FsUmVjbGFpbSI6W3sibmFtZSI6ImVzY3JvdyIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJyZWNsYWltcyIsInR5cGUiOiJQcm9wb3NhbFJlY2xhaW1SZWNsYWltc1tdIn1dLCJQcm9wb3NhbFJlbW92ZUFsbG93YW5jZXMiOlt7Im5hbWUiOiJlc2Nyb3ciLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYXNzZXRzIiwidHlwZSI6InVpbnQ2NFtdIn1dLCJQcm9wb3NhbFJlbW92ZUV4ZWN1dGVQbHVnaW4iOlt7Im5hbWUiOiJleGVjdXRpb25LZXkiLCJ0eXBlIjoiYnl0ZVszMl0ifV0sIlByb3Bvc2FsUmVtb3ZlTmFtZWRQbHVnaW4iOlt7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InBsdWdpbiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjYWxsZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImVzY3JvdyIsInR5cGUiOiJzdHJpbmcifV0sIlByb3Bvc2FsUmVtb3ZlUGx1Z2luIjpbeyJuYW1lIjoicGx1Z2luIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNhbGxlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZXNjcm93IiwidHlwZSI6InN0cmluZyJ9XSwiUHJvcG9zYWxUb2dnbGVFc2Nyb3dMb2NrIjpbeyJuYW1lIjoiZXNjcm93IiwidHlwZSI6InN0cmluZyJ9XSwiUHJvcG9zYWxVcGRhdGVGaWVsZCI6W3sibmFtZSI6ImZpZWxkIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InZhbHVlIiwidHlwZSI6ImJ5dGVbXSJ9XSwiUHJvcG9zYWxVcGdyYWRlQXBwIjpbeyJuYW1lIjoiYXBwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImV4ZWN1dGlvbktleSIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6Imdyb3VwcyIsInR5cGUiOiJieXRlWzMyXVtdIn0seyJuYW1lIjoiZmlyc3RWYWxpZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXN0VmFsaWQiLCJ0eXBlIjoidWludDY0In1dLCJQcm9wb3NhbEFkZEFsbG93YW5jZXNBbGxvd2FuY2VzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJib29sIn1dLCJQcm9wb3NhbEFkZE5hbWVkUGx1Z2luTWV0aG9kcyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJieXRlWzRdIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XSwiUHJvcG9zYWxSZWNsYWltUmVjbGFpbXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InByb3Bvc2FsVXBncmFkZUFwcFNoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsYnl0ZVszMl0sYnl0ZVszMl1bXSx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlByb3Bvc2FsVXBncmFkZUFwcCIsIm5hbWUiOiJzaGFwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGJ5dGVbMzJdLGJ5dGVbMzJdW10sdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQcm9wb3NhbFVwZ3JhZGVBcHAiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb3Bvc2FsQWRkUGx1Z2luU2hhcGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLHN0cmluZyx1aW50OCx1aW50NjQsdWludDY0LChieXRlWzRdLHVpbnQ2NClbXSxib29sLGJvb2wsYm9vbCxib29sLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsc3RyaW5nLCh1aW50NjQsdWludDgsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbClbXSkiLCJzdHJ1Y3QiOiJQcm9wb3NhbEFkZFBsdWdpbiIsIm5hbWUiOiJzaGFwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3Msc3RyaW5nLHVpbnQ4LHVpbnQ2NCx1aW50NjQsKGJ5dGVbNF0sdWludDY0KVtdLGJvb2wsYm9vbCxib29sLGJvb2wsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCxzdHJpbmcsKHVpbnQ2NCx1aW50OCx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sKVtdKSIsInN0cnVjdCI6IlByb3Bvc2FsQWRkUGx1Z2luIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm9wb3NhbEFkZE5hbWVkUGx1Z2luU2hhcGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHN0cmluZyx1aW50NjQsYWRkcmVzcyxzdHJpbmcsdWludDgsdWludDY0LHVpbnQ2NCwoYnl0ZVs0XSx1aW50NjQpW10sYm9vbCxib29sLGJvb2wsYm9vbCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHN0cmluZywodWludDY0LHVpbnQ4LHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wpW10pIiwic3RydWN0IjoiUHJvcG9zYWxBZGROYW1lZFBsdWdpbiIsIm5hbWUiOiJzaGFwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLHVpbnQ2NCxhZGRyZXNzLHN0cmluZyx1aW50OCx1aW50NjQsdWludDY0LChieXRlWzRdLHVpbnQ2NClbXSxib29sLGJvb2wsYm9vbCxib29sLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsc3RyaW5nLCh1aW50NjQsdWludDgsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbClbXSkiLCJzdHJ1Y3QiOiJQcm9wb3NhbEFkZE5hbWVkUGx1Z2luIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm9wb3NhbFJlbW92ZVBsdWdpblNoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxzdHJpbmcpIiwic3RydWN0IjoiUHJvcG9zYWxSZW1vdmVQbHVnaW4iLCJuYW1lIjoic2hhcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLHN0cmluZykiLCJzdHJ1Y3QiOiJQcm9wb3NhbFJlbW92ZVBsdWdpbiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJvcG9zYWxSZW1vdmVOYW1lZFBsdWdpblNoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihzdHJpbmcsdWludDY0LGFkZHJlc3Msc3RyaW5nKSIsInN0cnVjdCI6IlByb3Bvc2FsUmVtb3ZlTmFtZWRQbHVnaW4iLCJuYW1lIjoic2hhcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyx1aW50NjQsYWRkcmVzcyxzdHJpbmcpIiwic3RydWN0IjoiUHJvcG9zYWxSZW1vdmVOYW1lZFBsdWdpbiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJvcG9zYWxFeGVjdXRlUGx1Z2luU2hhcGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCxzdHJpbmcsYnl0ZVszMl0sYnl0ZVszMl1bXSx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlByb3Bvc2FsRXhlY3V0ZVBsdWdpbiIsIm5hbWUiOiJzaGFwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHN0cmluZyxieXRlWzMyXSxieXRlWzMyXVtdLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiUHJvcG9zYWxFeGVjdXRlUGx1Z2luIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm9wb3NhbEV4ZWN1dGVOYW1lZFBsdWdpblNoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihzdHJpbmcsYnl0ZVszMl0sYnl0ZVszMl1bXSx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlByb3Bvc2FsRXhlY3V0ZU5hbWVkUGx1Z2luIiwibmFtZSI6InNoYXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsYnl0ZVszMl0sYnl0ZVszMl1bXSx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlByb3Bvc2FsRXhlY3V0ZU5hbWVkUGx1Z2luIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm9wb3NhbFJlbW92ZUV4ZWN1dGVQbHVnaW5TaGFwZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYnl0ZVszMl0pIiwic3RydWN0IjoiUHJvcG9zYWxSZW1vdmVFeGVjdXRlUGx1Z2luIiwibmFtZSI6InNoYXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihieXRlWzMyXSkiLCJzdHJ1Y3QiOiJQcm9wb3NhbFJlbW92ZUV4ZWN1dGVQbHVnaW4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb3Bvc2FsQWRkQWxsb3dhbmNlc1NoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihzdHJpbmcsKHVpbnQ2NCx1aW50OCx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sKVtdKSIsInN0cnVjdCI6IlByb3Bvc2FsQWRkQWxsb3dhbmNlcyIsIm5hbWUiOiJzaGFwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLCh1aW50NjQsdWludDgsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbClbXSkiLCJzdHJ1Y3QiOiJQcm9wb3NhbEFkZEFsbG93YW5jZXMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb3Bvc2FsUmVtb3ZlQWxsb3dhbmNlc1NoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihzdHJpbmcsdWludDY0W10pIiwic3RydWN0IjoiUHJvcG9zYWxSZW1vdmVBbGxvd2FuY2VzIiwibmFtZSI6InNoYXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsdWludDY0W10pIiwic3RydWN0IjoiUHJvcG9zYWxSZW1vdmVBbGxvd2FuY2VzIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm9wb3NhbE5ld0VzY3Jvd1NoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihzdHJpbmcsYWRkcmVzcykiLCJzdHJ1Y3QiOiJQcm9wb3NhbE5ld0VzY3JvdyIsIm5hbWUiOiJzaGFwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLGFkZHJlc3MpIiwic3RydWN0IjoiUHJvcG9zYWxOZXdFc2Nyb3ciLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb3Bvc2FsVG9nZ2xlRXNjcm93TG9ja1NoYXBlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IihzdHJpbmcpIiwic3RydWN0IjoiUHJvcG9zYWxUb2dnbGVFc2Nyb3dMb2NrIiwibmFtZSI6InNoYXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcpIiwic3RydWN0IjoiUHJvcG9zYWxUb2dnbGVFc2Nyb3dMb2NrIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm9wb3NhbFVwZGF0ZUZpZWxkU2hhcGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHN0cmluZyxieXRlW10pIiwic3RydWN0IjoiUHJvcG9zYWxVcGRhdGVGaWVsZCIsIm5hbWUiOiJzaGFwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLGJ5dGVbXSkiLCJzdHJ1Y3QiOiJQcm9wb3NhbFVwZGF0ZUZpZWxkIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm9wb3NhbFJlY2xhaW1TaGFwZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoc3RyaW5nLCh1aW50NjQsdWludDY0LGJvb2wpW10pIiwic3RydWN0IjoiUHJvcG9zYWxSZWNsYWltIiwibmFtZSI6InNoYXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsKHVpbnQ2NCx1aW50NjQsYm9vbClbXSkiLCJzdHJ1Y3QiOiJQcm9wb3NhbFJlY2xhaW0iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb3Bvc2FsQ2hhbmdlQWRtaW5TaGFwZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoYWRkcmVzcykiLCJzdHJ1Y3QiOiJQcm9wb3NhbENoYW5nZUFkbWluIiwibmFtZSI6InNoYXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzKSIsInN0cnVjdCI6IlByb3Bvc2FsQ2hhbmdlQWRtaW4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb3Bvc2FsRGVsZXRlRXNjcm93U2hhcGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHN0cmluZykiLCJzdHJ1Y3QiOiJQcm9wb3NhbERlbGV0ZUVzY3JvdyIsIm5hbWUiOiJzaGFwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nKSIsInN0cnVjdCI6IlByb3Bvc2FsRGVsZXRlRXNjcm93IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE3NiwyMTMsMjM0LDI1OCwyNzksMzE1LDMzNiwzNTcsMzgxLDQwMiw0MzksNDcyLDQ5Myw1MjcsNTQ4LDU4NCw2MDUsNjU1LDY3NSw3MTAsNzMwLDc2Niw3OTgsODI5LDg0OSw4ODEsOTAxLDk1MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvYXJjNTgvZGFvL3R5cGVzLnRzOjpQcm9wb3NhbEFkZEFsbG93YW5jZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL2FyYzU4L2Rhby90eXBlcy50czo6UHJvcG9zYWxBZGROYW1lZFBsdWdpbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvYXJjNTgvZGFvL3R5cGVzLnRzOjpQcm9wb3NhbEFkZFBsdWdpbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvYXJjNTgvZGFvL3R5cGVzLnRzOjpQcm9wb3NhbENoYW5nZUFkbWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTU1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9hcmM1OC9kYW8vdHlwZXMudHM6OlByb3Bvc2FsRGVsZXRlRXNjcm93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjEzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9hcmM1OC9kYW8vdHlwZXMudHM6OlByb3Bvc2FsRXhlY3V0ZU5hbWVkUGx1Z2luIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9hcmM1OC9kYW8vdHlwZXMudHM6OlByb3Bvc2FsRXhlY3V0ZVBsdWdpbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc3MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvYXJjNTgvZGFvL3R5cGVzLnRzOjpQcm9wb3NhbE5ld0VzY3JvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvYXJjNTgvZGFvL3R5cGVzLnRzOjpQcm9wb3NhbFJlY2xhaW0iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3Igc21hcnRfY29udHJhY3RzL2FyYzU4L2Rhby90eXBlcy50czo6UHJvcG9zYWxSZW1vdmVBbGxvd2FuY2VzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9hcmM1OC9kYW8vdHlwZXMudHM6OlByb3Bvc2FsUmVtb3ZlRXhlY3V0ZVBsdWdpbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvYXJjNTgvZGFvL3R5cGVzLnRzOjpQcm9wb3NhbFJlbW92ZU5hbWVkUGx1Z2luIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQ0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9hcmM1OC9kYW8vdHlwZXMudHM6OlByb3Bvc2FsUmVtb3ZlUGx1Z2luIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODAyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9hcmM1OC9kYW8vdHlwZXMudHM6OlByb3Bvc2FsVG9nZ2xlRXNjcm93TG9jayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBzbWFydF9jb250cmFjdHMvYXJjNTgvZGFvL3R5cGVzLnRzOjpQcm9wb3NhbFVwZGF0ZUZpZWxkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9hcmM1OC9kYW8vdHlwZXMudHM6OlByb3Bvc2FsVXBncmFkZUFwcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5MCw5NDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAwIG9mICgobGVuK3V0ZjhbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODczXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMCBvZiAoKGxlbit1dGY4W10pLChsZW4rKHVpbnQ2NCx1aW50NjQsYm9vbDEpW10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rdXRmOFtdKSwobGVuKyh1aW50NjQsdWludDgsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbDEpW10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcwMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rdXRmOFtdKSwobGVuK3VpbnQ2NFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MjFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAwIG9mICgobGVuK3V0ZjhbXSksKGxlbit1aW50OFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAwIG9mICgobGVuK3V0ZjhbXSksdWludDY0LHVpbnQ4WzMyXSwobGVuK3V0ZjhbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMCBvZiAoKGxlbit1dGY4W10pLHVpbnQ2NCx1aW50OFszMl0sKGxlbit1dGY4W10pLHVpbnQ4LHVpbnQ2NCx1aW50NjQsKGxlbisodWludDhbNF0sdWludDY0KVtdKSxib29sMSxib29sMSxib29sMSxib29sMSx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LChsZW4rdXRmOFtdKSwobGVuKyh1aW50NjQsdWludDgsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbDEpW10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rdXRmOFtdKSx1aW50OFszMl0pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMCBvZiAoKGxlbit1dGY4W10pLHVpbnQ4WzMyXSwobGVuK3VpbnQ4WzMyXVtdKSx1aW50NjQsdWludDY0KSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg5M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDEgb2YgKChsZW4rdXRmOFtdKSwobGVuKyh1aW50NjQsdWludDY0LGJvb2wxKVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICgobGVuK3V0ZjhbXSksKGxlbisodWludDY0LHVpbnQ4LHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wxKVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICgobGVuK3V0ZjhbXSksKGxlbit1aW50NjRbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODQxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMSBvZiAoKGxlbit1dGY4W10pLChsZW4rdWludDhbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTE5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMSBvZiAodWludDY0LChsZW4rdXRmOFtdKSx1aW50OFszMl0sKGxlbit1aW50OFszMl1bXSksdWludDY0LHVpbnQ2NCkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxNiBvZiAodWludDY0LHVpbnQ4WzMyXSwobGVuK3V0ZjhbXSksdWludDgsdWludDY0LHVpbnQ2NCwobGVuKyh1aW50OFs0XSx1aW50NjQpW10pLGJvb2wxLGJvb2wxLGJvb2wxLGJvb2wxLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsKGxlbit1dGY4W10pLChsZW4rKHVpbnQ2NCx1aW50OCx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sMSlbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzczXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMTcgb2YgKChsZW4rdXRmOFtdKSx1aW50NjQsdWludDhbMzJdLChsZW4rdXRmOFtdKSx1aW50OCx1aW50NjQsdWludDY0LChsZW4rKHVpbnQ4WzRdLHVpbnQ2NClbXSksYm9vbDEsYm9vbDEsYm9vbDEsYm9vbDEsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCwobGVuK3V0ZjhbXSksKGxlbisodWludDY0LHVpbnQ4LHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wxKVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxNyBvZiAodWludDY0LHVpbnQ4WzMyXSwobGVuK3V0ZjhbXSksdWludDgsdWludDY0LHVpbnQ2NCwobGVuKyh1aW50OFs0XSx1aW50NjQpW10pLGJvb2wxLGJvb2wxLGJvb2wxLGJvb2wxLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsKGxlbit1dGY4W10pLChsZW4rKHVpbnQ2NCx1aW50OCx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sMSlbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMTggb2YgKChsZW4rdXRmOFtdKSx1aW50NjQsdWludDhbMzJdLChsZW4rdXRmOFtdKSx1aW50OCx1aW50NjQsdWludDY0LChsZW4rKHVpbnQ4WzRdLHVpbnQ2NClbXSksYm9vbDEsYm9vbDEsYm9vbDEsYm9vbDEsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCwobGVuK3V0ZjhbXSksKGxlbisodWludDY0LHVpbnQ4LHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wxKVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAyIG9mICgobGVuK3V0ZjhbXSksdWludDhbMzJdLChsZW4rdWludDhbMzJdW10pLHVpbnQ2NCx1aW50NjQpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMiBvZiAodWludDY0LHVpbnQ4WzMyXSwobGVuK3VpbnQ4WzMyXVtdKSx1aW50NjQsdWludDY0KSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDIgb2YgKHVpbnQ2NCx1aW50OFszMl0sKGxlbit1dGY4W10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDIgb2YgKHVpbnQ2NCx1aW50OFszMl0sKGxlbit1dGY4W10pLHVpbnQ4LHVpbnQ2NCx1aW50NjQsKGxlbisodWludDhbNF0sdWludDY0KVtdKSxib29sMSxib29sMSxib29sMSxib29sMSx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LChsZW4rdXRmOFtdKSwobGVuKyh1aW50NjQsdWludDgsdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbDEpW10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDMgb2YgKChsZW4rdXRmOFtdKSx1aW50NjQsdWludDhbMzJdLChsZW4rdXRmOFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAzIG9mICgobGVuK3V0ZjhbXSksdWludDY0LHVpbnQ4WzMyXSwobGVuK3V0ZjhbXSksdWludDgsdWludDY0LHVpbnQ2NCwobGVuKyh1aW50OFs0XSx1aW50NjQpW10pLGJvb2wxLGJvb2wxLGJvb2wxLGJvb2wxLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsKGxlbit1dGY4W10pLChsZW4rKHVpbnQ2NCx1aW50OCx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sMSlbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMyBvZiAodWludDY0LChsZW4rdXRmOFtdKSx1aW50OFszMl0sKGxlbit1aW50OFszMl1bXSksdWludDY0LHVpbnQ2NCkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA2IG9mICh1aW50NjQsdWludDhbMzJdLChsZW4rdXRmOFtdKSx1aW50OCx1aW50NjQsdWludDY0LChsZW4rKHVpbnQ4WzRdLHVpbnQ2NClbXSksYm9vbDEsYm9vbDEsYm9vbDEsYm9vbDEsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCwobGVuK3V0ZjhbXSksKGxlbisodWludDY0LHVpbnQ4LHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wxKVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA3IG9mICgobGVuK3V0ZjhbXSksdWludDY0LHVpbnQ4WzMyXSwobGVuK3V0ZjhbXSksdWludDgsdWludDY0LHVpbnQ2NCwobGVuKyh1aW50OFs0XSx1aW50NjQpW10pLGJvb2wxLGJvb2wxLGJvb2wxLGJvb2wxLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsKGxlbit1dGY4W10pLChsZW4rKHVpbnQ2NCx1aW50OCx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sMSlbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYzLDIwMCwyMjEsMjQ1LDI2NiwzMDIsMzIzLDM0NCwzNjgsMzg5LDQyNiw0NTksNDgwLDUxNCw1MzUsNTcxLDU5Miw2NDMsNjYyLDY5OCw3MTcsNzUzLDc4Niw4MTcsODM2LDg2OSw4ODgsOTM5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeUlERWdOQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlREUxTVdZM1l6YzFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WkdGdkwzUjVjR1Z6TG1Gc1oyOHVkSE02TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnJhWFJoUkVGUFZIbHdaWE1nWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1qTUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEa3lZak0xT0RrMklEQjROMlZsTkdKaFlqY2dNSGc0TW1RMVpqTm1aaUF3ZUdZek9UUXhZVEpqSURCNFpqRmpaakl5WTJNZ01IaGlaRFJsWmpjek1DQXdlR1ZpWVdJMVpURTBJREI0Tm1JNFlXSmtNbVlnTUhobVkyRm1PRFF5TUNBd2VEVTFZMlUxWTJFNUlEQjRaVFExT0dRMU5EUWdNSGcxTUdGaFlqZ3haQ0F3ZURFME9XUXpZMk5pSURCNE1XRTBNREprTVdJZ01IZzNPRGsyWldFMVlTQXdlR1V3TXpBMllUUmlJQzh2SUcxbGRHaHZaQ0FpY0hKdmNHOXpZV3hWY0dkeVlXUmxRWEJ3VTJoaGNHVW9LSFZwYm5RMk5DeGllWFJsV3pNeVhTeGllWFJsV3pNeVhWdGRMSFZwYm5RMk5DeDFhVzUwTmpRcEtTaDFhVzUwTmpRc1lubDBaVnN6TWwwc1lubDBaVnN6TWwxYlhTeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaWNISnZjRzl6WVd4QlpHUlFiSFZuYVc1VGFHRndaU2dvZFdsdWREWTBMR0ZrWkhKbGMzTXNjM1J5YVc1bkxIVnBiblE0TEhWcGJuUTJOQ3gxYVc1ME5qUXNLR0o1ZEdWYk5GMHNkV2x1ZERZMEtWdGRMR0p2YjJ3c1ltOXZiQ3hpYjI5c0xHSnZiMndzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3h6ZEhKcGJtY3NLSFZwYm5RMk5DeDFhVzUwT0N4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzS1Z0ZEtTa29kV2x1ZERZMExHRmtaSEpsYzNNc2MzUnlhVzVuTEhWcGJuUTRMSFZwYm5RMk5DeDFhVzUwTmpRc0tHSjVkR1ZiTkYwc2RXbHVkRFkwS1Z0ZExHSnZiMndzWW05dmJDeGliMjlzTEdKdmIyd3NkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeHpkSEpwYm1jc0tIVnBiblEyTkN4MWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4aWIyOXNLVnRkS1NJc0lHMWxkR2h2WkNBaWNISnZjRzl6WVd4QlpHUk9ZVzFsWkZCc2RXZHBibE5vWVhCbEtDaHpkSEpwYm1jc2RXbHVkRFkwTEdGa1pISmxjM01zYzNSeWFXNW5MSFZwYm5RNExIVnBiblEyTkN4MWFXNTBOalFzS0dKNWRHVmJORjBzZFdsdWREWTBLVnRkTEdKdmIyd3NZbTl2YkN4aWIyOXNMR0p2YjJ3c2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4emRISnBibWNzS0hWcGJuUTJOQ3gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3hpYjI5c0tWdGRLU2tvYzNSeWFXNW5MSFZwYm5RMk5DeGhaR1J5WlhOekxITjBjbWx1Wnl4MWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERZMExDaGllWFJsV3pSZExIVnBiblEyTkNsYlhTeGliMjlzTEdKdmIyd3NZbTl2YkN4aWIyOXNMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNjM1J5YVc1bkxDaDFhVzUwTmpRc2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiQ2xiWFNraUxDQnRaWFJvYjJRZ0luQnliM0J2YzJGc1VtVnRiM1psVUd4MVoybHVVMmhoY0dVb0tIVnBiblEyTkN4aFpHUnlaWE56TEhOMGNtbHVaeWtwS0hWcGJuUTJOQ3hoWkdSeVpYTnpMSE4wY21sdVp5a2lMQ0J0WlhSb2IyUWdJbkJ5YjNCdmMyRnNVbVZ0YjNabFRtRnRaV1JRYkhWbmFXNVRhR0Z3WlNnb2MzUnlhVzVuTEhWcGJuUTJOQ3hoWkdSeVpYTnpMSE4wY21sdVp5a3BLSE4wY21sdVp5eDFhVzUwTmpRc1lXUmtjbVZ6Y3l4emRISnBibWNwSWl3Z2JXVjBhRzlrSUNKd2NtOXdiM05oYkVWNFpXTjFkR1ZRYkhWbmFXNVRhR0Z3WlNnb2RXbHVkRFkwTEhOMGNtbHVaeXhpZVhSbFd6TXlYU3hpZVhSbFd6TXlYVnRkTEhWcGJuUTJOQ3gxYVc1ME5qUXBLU2gxYVc1ME5qUXNjM1J5YVc1bkxHSjVkR1ZiTXpKZExHSjVkR1ZiTXpKZFcxMHNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0luQnliM0J2YzJGc1JYaGxZM1YwWlU1aGJXVmtVR3gxWjJsdVUyaGhjR1VvS0hOMGNtbHVaeXhpZVhSbFd6TXlYU3hpZVhSbFd6TXlYVnRkTEhWcGJuUTJOQ3gxYVc1ME5qUXBLU2h6ZEhKcGJtY3NZbmwwWlZzek1sMHNZbmwwWlZzek1sMWJYU3gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWljSEp2Y0c5ellXeFNaVzF2ZG1WRmVHVmpkWFJsVUd4MVoybHVVMmhoY0dVb0tHSjVkR1ZiTXpKZEtTa29ZbmwwWlZzek1sMHBJaXdnYldWMGFHOWtJQ0p3Y205d2IzTmhiRUZrWkVGc2JHOTNZVzVqWlhOVGFHRndaU2dvYzNSeWFXNW5MQ2gxYVc1ME5qUXNkV2x1ZERnc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkNsYlhTa3BLSE4wY21sdVp5d29kV2x1ZERZMExIVnBiblE0TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExHSnZiMndwVzEwcElpd2diV1YwYUc5a0lDSndjbTl3YjNOaGJGSmxiVzkyWlVGc2JHOTNZVzVqWlhOVGFHRndaU2dvYzNSeWFXNW5MSFZwYm5RMk5GdGRLU2tvYzNSeWFXNW5MSFZwYm5RMk5GdGRLU0lzSUcxbGRHaHZaQ0FpY0hKdmNHOXpZV3hPWlhkRmMyTnliM2RUYUdGd1pTZ29jM1J5YVc1bkxHRmtaSEpsYzNNcEtTaHpkSEpwYm1jc1lXUmtjbVZ6Y3lraUxDQnRaWFJvYjJRZ0luQnliM0J2YzJGc1ZHOW5aMnhsUlhOamNtOTNURzlqYTFOb1lYQmxLQ2h6ZEhKcGJtY3BLU2h6ZEhKcGJtY3BJaXdnYldWMGFHOWtJQ0p3Y205d2IzTmhiRlZ3WkdGMFpVWnBaV3hrVTJoaGNHVW9LSE4wY21sdVp5eGllWFJsVzEwcEtTaHpkSEpwYm1jc1lubDBaVnRkS1NJc0lHMWxkR2h2WkNBaWNISnZjRzl6WVd4U1pXTnNZV2x0VTJoaGNHVW9LSE4wY21sdVp5d29kV2x1ZERZMExIVnBiblEyTkN4aWIyOXNLVnRkS1Nrb2MzUnlhVzVuTENoMWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3cFcxMHBJaXdnYldWMGFHOWtJQ0p3Y205d2IzTmhiRU5vWVc1blpVRmtiV2x1VTJoaGNHVW9LR0ZrWkhKbGMzTXBLU2hoWkdSeVpYTnpLU0lzSUcxbGRHaHZaQ0FpY0hKdmNHOXpZV3hFWld4bGRHVkZjMk55YjNkVGFHRndaU2dvYzNSeWFXNW5LU2tvYzNSeWFXNW5LU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhCeWIzQnZjMkZzVlhCbmNtRmtaVUZ3Y0ZOb1lYQmxJSEJ5YjNCdmMyRnNRV1JrVUd4MVoybHVVMmhoY0dVZ2NISnZjRzl6WVd4QlpHUk9ZVzFsWkZCc2RXZHBibE5vWVhCbElIQnliM0J2YzJGc1VtVnRiM1psVUd4MVoybHVVMmhoY0dVZ2NISnZjRzl6WVd4U1pXMXZkbVZPWVcxbFpGQnNkV2RwYmxOb1lYQmxJSEJ5YjNCdmMyRnNSWGhsWTNWMFpWQnNkV2RwYmxOb1lYQmxJSEJ5YjNCdmMyRnNSWGhsWTNWMFpVNWhiV1ZrVUd4MVoybHVVMmhoY0dVZ2NISnZjRzl6WVd4U1pXMXZkbVZGZUdWamRYUmxVR3gxWjJsdVUyaGhjR1VnY0hKdmNHOXpZV3hCWkdSQmJHeHZkMkZ1WTJWelUyaGhjR1VnY0hKdmNHOXpZV3hTWlcxdmRtVkJiR3h2ZDJGdVkyVnpVMmhoY0dVZ2NISnZjRzl6WVd4T1pYZEZjMk55YjNkVGFHRndaU0J3Y205d2IzTmhiRlJ2WjJkc1pVVnpZM0p2ZDB4dlkydFRhR0Z3WlNCd2NtOXdiM05oYkZWd1pHRjBaVVpwWld4a1UyaGhjR1VnY0hKdmNHOXpZV3hTWldOc1lXbHRVMmhoY0dVZ2NISnZjRzl6WVd4RGFHRnVaMlZCWkcxcGJsTm9ZWEJsSUhCeWIzQnZjMkZzUkdWc1pYUmxSWE5qY205M1UyaGhjR1VLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1qTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WkdGdkwzUjVjR1Z6TG1Gc1oyOHVkSE02TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnJhWFJoUkVGUFZIbHdaWE1nWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5a1lXOHZkSGx3WlhNdVlXeG5ieTUwY3pvNlFXdHBkR0ZFUVU5VWVYQmxjeTV3Y205d2IzTmhiRlZ3WjNKaFpHVkJjSEJUYUdGd1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJ5YjNCdmMyRnNWWEJuY21Ga1pVRndjRk5vWVhCbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMlJoYnk5MGVYQmxjeTVoYkdkdkxuUnpPalVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEUXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURVNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURJZ2IyWWdLSFZwYm5RMk5DeDFhVzUwT0Zzek1sMHNLR3hsYml0MWFXNTBPRnN6TWwxYlhTa3NkV2x1ZERZMExIVnBiblEyTkNrS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ05qQUtJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5a1lXOHZkSGx3WlhNdWRITTZPbEJ5YjNCdmMyRnNWWEJuY21Ga1pVRndjQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzlrWVc4dmRIbHdaWE11WVd4bmJ5NTBjem82UVd0cGRHRkVRVTlVZVhCbGN5NXdjbTl3YjNOaGJFRmtaRkJzZFdkcGJsTm9ZWEJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NISnZjRzl6WVd4QlpHUlFiSFZuYVc1VGFHRndaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5a1lXOHZkSGx3WlhNdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTkRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVEEyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJRElnYjJZZ0tIVnBiblEyTkN4MWFXNTBPRnN6TWwwc0tHeGxiaXQxZEdZNFcxMHBMSFZwYm5RNExIVnBiblEyTkN4MWFXNTBOalFzS0d4bGJpc29kV2x1ZERoYk5GMHNkV2x1ZERZMEtWdGRLU3hpYjI5c01TeGliMjlzTVN4aWIyOXNNU3hpYjI5c01TeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExDaHNaVzRyZFhSbU9GdGRLU3dvYkdWdUt5aDFhVzUwTmpRc2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiREVwVzEwcEtRb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeE1EZ0tJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRFU1Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0EySUc5bUlDaDFhVzUwTmpRc2RXbHVkRGhiTXpKZExDaHNaVzRyZFhSbU9GdGRLU3gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwTENoc1pXNHJLSFZwYm5RNFd6UmRMSFZwYm5RMk5DbGJYU2tzWW05dmJERXNZbTl2YkRFc1ltOXZiREVzWW05dmJERXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Dd29iR1Z1SzNWMFpqaGJYU2tzS0d4bGJpc29kV2x1ZERZMExIVnBiblE0TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExHSnZiMnd4S1Z0ZEtTa0tJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNd29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01USUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNBckNpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0F4TURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURFMklHOW1JQ2gxYVc1ME5qUXNkV2x1ZERoYk16SmRMQ2hzWlc0cmRYUm1PRnRkS1N4MWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERZMExDaHNaVzRyS0hWcGJuUTRXelJkTEhWcGJuUTJOQ2xiWFNrc1ltOXZiREVzWW05dmJERXNZbTl2YkRFc1ltOXZiREVzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3dvYkdWdUszVjBaamhiWFNrc0tHeGxiaXNvZFdsdWREWTBMSFZwYm5RNExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3eEtWdGRLU2tLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNBckNpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0F4TURRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURFM0lHOW1JQ2gxYVc1ME5qUXNkV2x1ZERoYk16SmRMQ2hzWlc0cmRYUm1PRnRkS1N4MWFXNTBPQ3gxYVc1ME5qUXNkV2x1ZERZMExDaHNaVzRyS0hWcGJuUTRXelJkTEhWcGJuUTJOQ2xiWFNrc1ltOXZiREVzWW05dmJERXNZbTl2YkRFc1ltOXZiREVzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3dvYkdWdUszVjBaamhiWFNrc0tHeGxiaXNvZFdsdWREWTBMSFZwYm5RNExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0p2YjJ3eEtWdGRLU2tLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNelFLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQXJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaR0Z2TDNSNWNHVnpMblJ6T2pwUWNtOXdiM05oYkVGa1pGQnNkV2RwYmdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5a1lXOHZkSGx3WlhNdVlXeG5ieTUwY3pvNlFXdHBkR0ZFUVU5VWVYQmxjeTV3Y205d2IzTmhiRUZrWkU1aGJXVmtVR3gxWjJsdVUyaGhjR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwd2NtOXdiM05oYkVGa1pFNWhiV1ZrVUd4MVoybHVVMmhoY0dVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaR0Z2TDNSNWNHVnpMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1EZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01DQnZaaUFvS0d4bGJpdDFkR1k0VzEwcExIVnBiblEyTkN4MWFXNTBPRnN6TWwwc0tHeGxiaXQxZEdZNFcxMHBMSFZwYm5RNExIVnBiblEyTkN4MWFXNTBOalFzS0d4bGJpc29kV2x1ZERoYk5GMHNkV2x1ZERZMEtWdGRLU3hpYjI5c01TeGliMjlzTVN4aWIyOXNNU3hpYjI5c01TeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExDaHNaVzRyZFhSbU9GdGRLU3dvYkdWdUt5aDFhVzUwTmpRc2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiREVwVzEwcEtRb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeE1UQUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRFF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0F6SUc5bUlDZ29iR1Z1SzNWMFpqaGJYU2tzZFdsdWREWTBMSFZwYm5RNFd6TXlYU3dvYkdWdUszVjBaamhiWFNrc2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RMk5Dd29iR1Z1S3loMWFXNTBPRnMwWFN4MWFXNTBOalFwVzEwcExHSnZiMnd4TEdKdmIyd3hMR0p2YjJ3eExHSnZiMnd4TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzS0d4bGJpdDFkR1k0VzEwcExDaHNaVzRyS0hWcGJuUTJOQ3gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3hpYjI5c01TbGJYU2twQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURNS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTmpFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURjZ2IyWWdLQ2hzWlc0cmRYUm1PRnRkS1N4MWFXNTBOalFzZFdsdWREaGJNekpkTENoc1pXNHJkWFJtT0Z0ZEtTeDFhVzUwT0N4MWFXNTBOalFzZFdsdWREWTBMQ2hzWlc0cktIVnBiblE0V3pSZExIVnBiblEyTkNsYlhTa3NZbTl2YkRFc1ltOXZiREVzWW05dmJERXNZbTl2YkRFc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN3b2JHVnVLM1YwWmpoYlhTa3NLR3hsYmlzb2RXbHVkRFkwTEhWcGJuUTRMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEdKdmIyd3hLVnRkS1NrS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ013b2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJQ29LSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0FyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQXhNRFFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJREUzSUc5bUlDZ29iR1Z1SzNWMFpqaGJYU2tzZFdsdWREWTBMSFZwYm5RNFd6TXlYU3dvYkdWdUszVjBaamhiWFNrc2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RMk5Dd29iR1Z1S3loMWFXNTBPRnMwWFN4MWFXNTBOalFwVzEwcExHSnZiMnd4TEdKdmIyd3hMR0p2YjJ3eExHSnZiMnd4TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzS0d4bGJpdDFkR1k0VzEwcExDaHNaVzRyS0hWcGJuUTJOQ3gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3hpYjI5c01TbGJYU2twQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURNS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTVRBMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeE9DQnZaaUFvS0d4bGJpdDFkR1k0VzEwcExIVnBiblEyTkN4MWFXNTBPRnN6TWwwc0tHeGxiaXQxZEdZNFcxMHBMSFZwYm5RNExIVnBiblEyTkN4MWFXNTBOalFzS0d4bGJpc29kV2x1ZERoYk5GMHNkV2x1ZERZMEtWdGRLU3hpYjI5c01TeGliMjlzTVN4aWIyOXNNU3hpYjI5c01TeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExDaHNaVzRyZFhSbU9GdGRLU3dvYkdWdUt5aDFhVzUwTmpRc2RXbHVkRGdzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiREVwVzEwcEtRb2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXpDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBek5Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5a1lXOHZkSGx3WlhNdWRITTZPbEJ5YjNCdmMyRnNRV1JrVG1GdFpXUlFiSFZuYVc0S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlpHRnZMM1I1Y0dWekxtRnNaMjh1ZEhNNk9rRnJhWFJoUkVGUFZIbHdaWE11Y0hKdmNHOXpZV3hTWlcxdmRtVlFiSFZuYVc1VGFHRndaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25CeWIzQnZjMkZzVW1WdGIzWmxVR3gxWjJsdVUyaGhjR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlpHRnZMM1I1Y0dWekxtRnNaMjh1ZEhNNk1qQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURRd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJRElnYjJZZ0tIVnBiblEyTkN4MWFXNTBPRnN6TWwwc0tHeGxiaXQxZEdZNFcxMHBLUW9nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQTBOQW9nSUNBZ0t3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyUmhieTkwZVhCbGN5NTBjem82VUhKdmNHOXpZV3hTWlcxdmRtVlFiSFZuYVc0S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlpHRnZMM1I1Y0dWekxtRnNaMjh1ZEhNNk9rRnJhWFJoUkVGUFZIbHdaWE11Y0hKdmNHOXpZV3hTWlcxdmRtVk9ZVzFsWkZCc2RXZHBibE5vWVhCbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjSEp2Y0c5ellXeFNaVzF2ZG1WT1lXMWxaRkJzZFdkcGJsTm9ZWEJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyUmhieTkwZVhCbGN5NWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTkRRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTUNCdlppQW9LR3hsYml0MWRHWTRXMTBwTEhWcGJuUTJOQ3gxYVc1ME9Gc3pNbDBzS0d4bGJpdDFkR1k0VzEwcEtRb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBME5nb2dJQ0FnS3dvZ0lDQWdaR2xuSURJS0lDQWdJSEIxYzJocGJuUWdORElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJRE1nYjJZZ0tDaHNaVzRyZFhSbU9GdGRLU3gxYVc1ME5qUXNkV2x1ZERoYk16SmRMQ2hzWlc0cmRYUm1PRnRkS1NrS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ013b2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQXJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaR0Z2TDNSNWNHVnpMblJ6T2pwUWNtOXdiM05oYkZKbGJXOTJaVTVoYldWa1VHeDFaMmx1Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJSaGJ5OTBlWEJsY3k1aGJHZHZMblJ6T2pwQmEybDBZVVJCVDFSNWNHVnpMbkJ5YjNCdmMyRnNSWGhsWTNWMFpWQnNkV2RwYmxOb1lYQmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY0hKdmNHOXpZV3hGZUdWamRYUmxVR3gxWjJsdVUyaGhjR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlpHRnZMM1I1Y0dWekxtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOakFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dNU0J2WmlBb2RXbHVkRFkwTENoc1pXNHJkWFJtT0Z0ZEtTeDFhVzUwT0Zzek1sMHNLR3hsYml0MWFXNTBPRnN6TWwxYlhTa3NkV2x1ZERZMExIVnBiblEyTkNrS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTmpJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElEUXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCMGRYQnNaU0JsYm1OdlpHbHVad29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXpJRzltSUNoMWFXNTBOalFzS0d4bGJpdDFkR1k0VzEwcExIVnBiblE0V3pNeVhTd29iR1Z1SzNWcGJuUTRXek15WFZ0ZEtTeDFhVzUwTmpRc2RXbHVkRFkwS1FvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJQ3NLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzlrWVc4dmRIbHdaWE11ZEhNNk9sQnliM0J2YzJGc1JYaGxZM1YwWlZCc2RXZHBiZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzlrWVc4dmRIbHdaWE11WVd4bmJ5NTBjem82UVd0cGRHRkVRVTlVZVhCbGN5NXdjbTl3YjNOaGJFVjRaV04xZEdWT1lXMWxaRkJzZFdkcGJsTm9ZWEJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NISnZjRzl6WVd4RmVHVmpkWFJsVG1GdFpXUlFiSFZuYVc1VGFHRndaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5a1lXOHZkSGx3WlhNdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFV5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJREFnYjJZZ0tDaHNaVzRyZFhSbU9GdGRLU3gxYVc1ME9Gc3pNbDBzS0d4bGJpdDFhVzUwT0Zzek1sMWJYU2tzZFdsdWREWTBMSFZwYm5RMk5Da0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ05UUUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRE0wQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0F5SUc5bUlDZ29iR1Z1SzNWMFpqaGJYU2tzZFdsdWREaGJNekpkTENoc1pXNHJkV2x1ZERoYk16SmRXMTBwTEhWcGJuUTJOQ3gxYVc1ME5qUXBDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBcUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyUmhieTkwZVhCbGN5NTBjem82VUhKdmNHOXpZV3hGZUdWamRYUmxUbUZ0WldSUWJIVm5hVzRLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WkdGdkwzUjVjR1Z6TG1Gc1oyOHVkSE02T2tGcmFYUmhSRUZQVkhsd1pYTXVjSEp2Y0c5ellXeFNaVzF2ZG1WRmVHVmpkWFJsVUd4MVoybHVVMmhoY0dWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdjbTl3YjNOaGJGSmxiVzkyWlVWNFpXTjFkR1ZRYkhWbmFXNVRhR0Z3WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWtZVzh2ZEhsd1pYTXVZV3huYnk1MGN6bzBNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyUmhieTkwZVhCbGN5NTBjem82VUhKdmNHOXpZV3hTWlcxdmRtVkZlR1ZqZFhSbFVHeDFaMmx1Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJSaGJ5OTBlWEJsY3k1aGJHZHZMblJ6T2pwQmEybDBZVVJCVDFSNWNHVnpMbkJ5YjNCdmMyRnNRV1JrUVd4c2IzZGhibU5sYzFOb1lYQmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY0hKdmNHOXpZV3hCWkdSQmJHeHZkMkZ1WTJWelUyaGhjR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlpHRnZMM1I1Y0dWekxtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTUNCdlppQW9LR3hsYml0MWRHWTRXMTBwTENoc1pXNHJLSFZwYm5RMk5DeDFhVzUwT0N4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzTVNsYlhTa3BDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTVNCdlppQW9LR3hsYml0MWRHWTRXMTBwTENoc1pXNHJLSFZwYm5RMk5DeDFhVzUwT0N4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzTVNsYlhTa3BDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElETTBDaUFnSUNBcUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyUmhieTkwZVhCbGN5NTBjem82VUhKdmNHOXpZV3hCWkdSQmJHeHZkMkZ1WTJWekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyUmhieTkwZVhCbGN5NWhiR2R2TG5Sek9qcEJhMmwwWVVSQlQxUjVjR1Z6TG5CeWIzQnZjMkZzVW1WdGIzWmxRV3hzYjNkaGJtTmxjMU5vWVhCbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjSEp2Y0c5ellXeFNaVzF2ZG1WQmJHeHZkMkZ1WTJWelUyaGhjR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlpHRnZMM1I1Y0dWekxtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTUNCdlppQW9LR3hsYml0MWRHWTRXMTBwTENoc1pXNHJkV2x1ZERZMFcxMHBLUW9nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNBckNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURFZ2IyWWdLQ2hzWlc0cmRYUm1PRnRkS1N3b2JHVnVLM1ZwYm5RMk5GdGRLU2tLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lDc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWtZVzh2ZEhsd1pYTXVkSE02T2xCeWIzQnZjMkZzVW1WdGIzWmxRV3hzYjNkaGJtTmxjd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzlrWVc4dmRIbHdaWE11WVd4bmJ5NTBjem82UVd0cGRHRkVRVTlVZVhCbGN5NXdjbTl3YjNOaGJFNWxkMFZ6WTNKdmQxTm9ZWEJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NISnZjRzl6WVd4T1pYZEZjMk55YjNkVGFHRndaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5a1lXOHZkSGx3WlhNdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRE0wQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJREFnYjJZZ0tDaHNaVzRyZFhSbU9GdGRLU3gxYVc1ME9Gc3pNbDBwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRE0yQ2lBZ0lDQXJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaR0Z2TDNSNWNHVnpMblJ6T2pwUWNtOXdiM05oYkU1bGQwVnpZM0p2ZHdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5a1lXOHZkSGx3WlhNdVlXeG5ieTUwY3pvNlFXdHBkR0ZFUVU5VWVYQmxjeTV3Y205d2IzTmhiRlJ2WjJkc1pVVnpZM0p2ZDB4dlkydFRhR0Z3WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQnliM0J2YzJGc1ZHOW5aMnhsUlhOamNtOTNURzlqYTFOb1lYQmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJSaGJ5OTBlWEJsY3k1aGJHZHZMblJ6T2pZd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJREFnYjJZZ0tDaHNaVzRyZFhSbU9GdGRLU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUEwQ2lBZ0lDQXJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaR0Z2TDNSNWNHVnpMblJ6T2pwUWNtOXdiM05oYkZSdloyZHNaVVZ6WTNKdmQweHZZMnNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WkdGdkwzUjVjR1Z6TG1Gc1oyOHVkSE02T2tGcmFYUmhSRUZQVkhsd1pYTXVjSEp2Y0c5ellXeFZjR1JoZEdWR2FXVnNaRk5vWVhCbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjSEp2Y0c5ellXeFZjR1JoZEdWR2FXVnNaRk5vWVhCbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMlJoYnk5MGVYQmxjeTVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElEQWdiMllnS0Noc1pXNHJkWFJtT0Z0ZEtTd29iR1Z1SzNWcGJuUTRXMTBwS1FvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElERWdiMllnS0Noc1pXNHJkWFJtT0Z0ZEtTd29iR1Z1SzNWcGJuUTRXMTBwS1FvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lDc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOWtZVzh2ZEhsd1pYTXVkSE02T2xCeWIzQnZjMkZzVlhCa1lYUmxSbWxsYkdRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlpHRnZMM1I1Y0dWekxtRnNaMjh1ZEhNNk9rRnJhWFJoUkVGUFZIbHdaWE11Y0hKdmNHOXpZV3hTWldOc1lXbHRVMmhoY0dWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdjbTl3YjNOaGJGSmxZMnhoYVcxVGFHRndaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5a1lXOHZkSGx3WlhNdVlXeG5ieTUwY3pvM01Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0F3SUc5bUlDZ29iR1Z1SzNWMFpqaGJYU2tzS0d4bGJpc29kV2x1ZERZMExIVnBiblEyTkN4aWIyOXNNU2xiWFNrcENpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dNU0J2WmlBb0tHeGxiaXQxZEdZNFcxMHBMQ2hzWlc0cktIVnBiblEyTkN4MWFXNTBOalFzWW05dmJERXBXMTBwS1FvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F4TndvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJQ3NLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzlrWVc4dmRIbHdaWE11ZEhNNk9sQnliM0J2YzJGc1VtVmpiR0ZwYlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5a1lXOHZkSGx3WlhNdVlXeG5ieTUwY3pvNlFXdHBkR0ZFUVU5VWVYQmxjeTV3Y205d2IzTmhiRU5vWVc1blpVRmtiV2x1VTJoaGNHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B3Y205d2IzTmhiRU5vWVc1blpVRmtiV2x1VTJoaGNHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WkdGdkwzUjVjR1Z6TG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzlrWVc4dmRIbHdaWE11ZEhNNk9sQnliM0J2YzJGc1EyaGhibWRsUVdSdGFXNEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaR0Z2TDNSNWNHVnpMbUZzWjI4dWRITTZPa0ZyYVhSaFJFRlBWSGx3WlhNdWNISnZjRzl6WVd4RVpXeGxkR1ZGYzJOeWIzZFRhR0Z3WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQnliM0J2YzJGc1JHVnNaWFJsUlhOamNtOTNVMmhoY0dVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaR0Z2TDNSNWNHVnpMbUZzWjI4dWRITTZPREFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01DQnZaaUFvS0d4bGJpdDFkR1k0VzEwcEtRb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklEUUtJQ0FnSUNzS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5a1lXOHZkSGx3WlhNdWRITTZPbEJ5YjNCdmMyRnNSR1ZzWlhSbFJYTmpjbTkzQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUlCQkNZQkJCVWZmSFV4RzBFQWZ6RVpGRVF4R0VTQ0VBU1NzMWlXQkg3a3VyY0VndFh6L3dUemxCb3NCUEhQSXN3RXZVNzNNQVRycTE0VUJHdUt2UzhFL0srRUlBUlZ6bHlwQk9SWTFVUUVVS3E0SFFRVW5UekxCQnBBTFJzRWVKYnFXZ1RnTUdwTE5ob0FqaEFBQ1FBdUFKVUJFQUV5QVdnQm9nSGJBZW9DSVFKWUFua0NtQUxNQXdNREVnQXhHUlF4R0JRUVF6WWFBVWtWU3dHQktGbEpnVG9TUkVzQ1RFc0NVaUpaZ1NBTGdUd0lFa1FvVEZDd0pFTTJHZ0ZKRlVzQmdTaFpTWUZxRWtSTEFreExBbElpV1lGc0NFc0NnVHRaU1VzQ0VrUkxBMHhMQTFJaVdZRU1DeU1JQ0VzQ2dXWlpTVXNDRWtSTEEweExBMUlpV1NNSUNFc0NnV2haU1VzQ0VrUkxBMHhMQTFJaVdZRWlDeU1JQ0JKRUtFeFFzQ1JETmhvQlNSVkxBU0paU1lGc0VrUkxBa3hMQWxJaVdZRnVDRXNDZ1NwWlNVc0NFa1JMQTB4TEExSWlXU01JQ0VzQ2dUMVpTVXNDRWtSTEEweExBMUlpV1lFTUN5TUlDRXNDZ1doWlNVc0NFa1JMQTB4TEExSWlXU01JQ0VzQ2dXcFpTVXNDRWtSTEEweExBMUlpV1lFaUN5TUlDQkpFS0V4UXNDUkROaG9CU1JWTEFZRW9XVW1CS2hKRVN3Sk1Td0pTSWxtQkxBZ1NSQ2hNVUxBa1F6WWFBVWtWU3dFaVdVbUJMQkpFU3dKTVN3SlNJbG1CTGdoTEFvRXFXVWxMQWhKRVN3Tk1Td05TSWxrakNBZ1NSQ2hNVUxBa1F6WWFBVWtWU3dHQkNGbEpnVHdTUkVzQ1RFc0NVaUpaZ1Q0SVN3S0JLbGxKU3dJU1JFc0RURXNEVWlKWmdTQUxJd2dJRWtRb1RGQ3dKRU0yR2dGSkZVc0JJbGxKZ1RRU1JFc0NURXNDVWlKWmdUWUlTd0tCSWxsSlN3SVNSRXNEVEVzRFVpSlpnU0FMSXdnSUVrUW9URkN3SkVNMkdnRkpGWUVnRWtRb1RGQ3dKRU0yR2dGSkZVc0JJbGxKSlJKRVN3Sk1Td0pTSWxtQkJnaExBaU5aU1VzQ0VrUkxBMHhMQTFJaVdZRWlDeU1JQ0JKRUtFeFFzQ1JETmhvQlNSVkxBU0paU1NVU1JFc0NURXNDVWlKWmdRWUlTd0lqV1VsTEFoSkVTd05NU3dOU0lsbUJDQXNqQ0FnU1JDaE1VTEFrUXpZYUFVa1ZTd0VpV1VtQkloSkVTd0pNU3dKU0lsbUJKQWdTUkNoTVVMQWtRellhQVVrVlN3RWlXVWtqRWtSTEFreExBbElpV1NVSUVrUW9URkN3SkVNMkdnRkpGVXNCSWxsSkpSSkVTd0pNU3dKU0lsbUJCZ2hMQWlOWlNVc0NFa1JMQTB4TEExSWlXU01JQ0JKRUtFeFFzQ1JETmhvQlNSVkxBU0paU1NVU1JFc0NURXNDVWlKWmdRWUlTd0lqV1VsTEFoSkVTd05NU3dOU0lsbUJFUXNqQ0FnU1JDaE1VTEFrUXpZYUFVa1ZnU0FTUkNoTVVMQWtRellhQVVrVlN3RWlXVWtqRWtSTEFreExBbElpV1NVSUVrUW9URkN3SkVNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
