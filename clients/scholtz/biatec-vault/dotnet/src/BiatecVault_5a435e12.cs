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

namespace Arc56.Generated.scholtz.biatec_vault.BiatecVault_5a435e12
{


    public class BiatecVaultProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BiatecVaultProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Object31872968 : AVMObjectType
            {
                public string ProposalId { get; set; }

                public ulong SignaturesCount { get; set; }

                public string Vault { get; set; }

                public string SignatorGroupName { get; set; }

                public ulong ValidUntilTime { get; set; }

                public string ProposalType { get; set; }

                public Algorand.Address ChangedSignator { get; set; }

                public ulong ChangedThreshold { get; set; }

                public ulong ChangedSpendingLimitAssetId { get; set; }

                public ulong ChangedSpendingLimitAmount { get; set; }

                public ulong ChangedSpendingLimitDuration { get; set; }

                public Structs.PaymentGroup Transactions { get; set; } = new Structs.PaymentGroup();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalId.From(ProposalId);
                    stringRef[ret.Count] = vProposalId.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignaturesCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSignaturesCount.From(SignaturesCount);
                    ret.AddRange(vSignaturesCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVault = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVault.From(Vault);
                    stringRef[ret.Count] = vVault.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignatorGroupName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSignatorGroupName.From(SignatorGroupName);
                    stringRef[ret.Count] = vSignatorGroupName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValidUntilTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vValidUntilTime.From(ValidUntilTime);
                    ret.AddRange(vValidUntilTime.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalType.From(ProposalType);
                    stringRef[ret.Count] = vProposalType.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vChangedSignator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vChangedSignator.From(ChangedSignator);
                    ret.AddRange(vChangedSignator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vChangedThreshold = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vChangedThreshold.From(ChangedThreshold);
                    ret.AddRange(vChangedThreshold.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vChangedSpendingLimitAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vChangedSpendingLimitAssetId.From(ChangedSpendingLimitAssetId);
                    ret.AddRange(vChangedSpendingLimitAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vChangedSpendingLimitAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vChangedSpendingLimitAmount.From(ChangedSpendingLimitAmount);
                    ret.AddRange(vChangedSpendingLimitAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vChangedSpendingLimitDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vChangedSpendingLimitDuration.From(ChangedSpendingLimitDuration);
                    ret.AddRange(vChangedSpendingLimitDuration.Encode());
                    stringRef[ret.Count] = Transactions.ToByteArray();
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

                public static Object31872968 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Object31872968();
                    uint count = 0;
                    var indexProposalId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalId.Decode(bytes.Skip(indexProposalId + prefixOffset).ToArray());
                    var valueProposalId = vProposalId.ToValue();
                    if (valueProposalId is string vProposalIdValue) { ret.ProposalId = vProposalIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignaturesCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSignaturesCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSignaturesCount = vSignaturesCount.ToValue();
                    if (valueSignaturesCount is ulong vSignaturesCountValue) { ret.SignaturesCount = vSignaturesCountValue; }
                    var indexVault = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVault = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVault.Decode(bytes.Skip(indexVault + prefixOffset).ToArray());
                    var valueVault = vVault.ToValue();
                    if (valueVault is string vVaultValue) { ret.Vault = vVaultValue; }
                    var indexSignatorGroupName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignatorGroupName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSignatorGroupName.Decode(bytes.Skip(indexSignatorGroupName + prefixOffset).ToArray());
                    var valueSignatorGroupName = vSignatorGroupName.ToValue();
                    if (valueSignatorGroupName is string vSignatorGroupNameValue) { ret.SignatorGroupName = vSignatorGroupNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValidUntilTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vValidUntilTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValidUntilTime = vValidUntilTime.ToValue();
                    if (valueValidUntilTime is ulong vValidUntilTimeValue) { ret.ValidUntilTime = vValidUntilTimeValue; }
                    var indexProposalType = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalType.Decode(bytes.Skip(indexProposalType + prefixOffset).ToArray());
                    var valueProposalType = vProposalType.ToValue();
                    if (valueProposalType is string vProposalTypeValue) { ret.ProposalType = vProposalTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vChangedSignator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vChangedSignator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueChangedSignator = vChangedSignator.ToValue();
                    if (valueChangedSignator is Algorand.Address vChangedSignatorValue) { ret.ChangedSignator = vChangedSignatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vChangedThreshold = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vChangedThreshold.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueChangedThreshold = vChangedThreshold.ToValue();
                    if (valueChangedThreshold is ulong vChangedThresholdValue) { ret.ChangedThreshold = vChangedThresholdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vChangedSpendingLimitAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vChangedSpendingLimitAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueChangedSpendingLimitAssetId = vChangedSpendingLimitAssetId.ToValue();
                    if (valueChangedSpendingLimitAssetId is ulong vChangedSpendingLimitAssetIdValue) { ret.ChangedSpendingLimitAssetId = vChangedSpendingLimitAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vChangedSpendingLimitAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vChangedSpendingLimitAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueChangedSpendingLimitAmount = vChangedSpendingLimitAmount.ToValue();
                    if (valueChangedSpendingLimitAmount is ulong vChangedSpendingLimitAmountValue) { ret.ChangedSpendingLimitAmount = vChangedSpendingLimitAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vChangedSpendingLimitDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vChangedSpendingLimitDuration.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueChangedSpendingLimitDuration = vChangedSpendingLimitDuration.ToValue();
                    if (valueChangedSpendingLimitDuration is ulong vChangedSpendingLimitDurationValue) { ret.ChangedSpendingLimitDuration = vChangedSpendingLimitDurationValue; }
                    var indexTransactions = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Transactions = Structs.PaymentGroup.Parse(bytes.Skip(indexTransactions + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Object31872968);
                }
                public bool Equals(Object31872968? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Object31872968 left, Object31872968 right)
                {
                    return EqualityComparer<Object31872968>.Default.Equals(left, right);
                }
                public static bool operator !=(Object31872968 left, Object31872968 right)
                {
                    return !(left == right);
                }

            }

            public class ApproverWithPrposalId : AVMObjectType
            {
                public string ProposalId { get; set; }

                public Algorand.Address ApproverAddress { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalId.From(ProposalId);
                    stringRef[ret.Count] = vProposalId.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApproverAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vApproverAddress.From(ApproverAddress);
                    ret.AddRange(vApproverAddress.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ApproverWithPrposalId Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ApproverWithPrposalId();
                    uint count = 0;
                    var indexProposalId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProposalId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProposalId.Decode(bytes.Skip(indexProposalId + prefixOffset).ToArray());
                    var valueProposalId = vProposalId.ToValue();
                    if (valueProposalId is string vProposalIdValue) { ret.ProposalId = vProposalIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApproverAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vApproverAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApproverAddress = vApproverAddress.ToValue();
                    if (valueApproverAddress is Algorand.Address vApproverAddressValue) { ret.ApproverAddress = vApproverAddressValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ApproverWithPrposalId);
                }
                public bool Equals(ApproverWithPrposalId? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ApproverWithPrposalId left, ApproverWithPrposalId right)
                {
                    return EqualityComparer<ApproverWithPrposalId>.Default.Equals(left, right);
                }
                public static bool operator !=(ApproverWithPrposalId left, ApproverWithPrposalId right)
                {
                    return !(left == right);
                }

            }

            public class PaymentGroup : AVMObjectType
            {
                public ulong Count { get; set; }

                public string[] Type { get; set; }

                public Structs.PaymentGroupPayTxs[] PayTxs { get; set; }

                public Structs.PaymentGroupAssetTxs[] AssetTxs { get; set; }

                public Structs.PaymentGroupAppTxs[] AppTxs { get; set; }

                public Structs.PaymentGroupKeyRegTxs[] KeyRegTxs { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCount.From(Count);
                    ret.AddRange(vCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string[]");
                    vType.From(Type);
                    ret.AddRange(vType.Encode());
                    var arrPayTxs = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PaymentGroupPayTxs>(x => Structs.PaymentGroupPayTxs.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrPayTxs.Value = (PayTxs ?? Array.Empty<Structs.PaymentGroupPayTxs>()).ToList();
                    stringRef[ret.Count] = arrPayTxs.Encode();
                    ret.AddRange(new byte[2]);
                    var arrAssetTxs = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PaymentGroupAssetTxs>(x => Structs.PaymentGroupAssetTxs.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrAssetTxs.Value = (AssetTxs ?? Array.Empty<Structs.PaymentGroupAssetTxs>()).ToList();
                    stringRef[ret.Count] = arrAssetTxs.Encode();
                    ret.AddRange(new byte[2]);
                    var arrAppTxs = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PaymentGroupAppTxs>(x => Structs.PaymentGroupAppTxs.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrAppTxs.Value = (AppTxs ?? Array.Empty<Structs.PaymentGroupAppTxs>()).ToList();
                    stringRef[ret.Count] = arrAppTxs.Encode();
                    ret.AddRange(new byte[2]);
                    var arrKeyRegTxs = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PaymentGroupKeyRegTxs>(x => Structs.PaymentGroupKeyRegTxs.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrKeyRegTxs.Value = (KeyRegTxs ?? Array.Empty<Structs.PaymentGroupKeyRegTxs>()).ToList();
                    stringRef[ret.Count] = arrKeyRegTxs.Encode();
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

                public static PaymentGroup Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new PaymentGroup();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCount = vCount.ToValue();
                    if (valueCount is ulong vCountValue) { ret.Count = vCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string[]");
                    count = vType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueType = vType.ToValue();
                    if (valueType is string[] vTypeValue) { ret.Type = vTypeValue; }
                    var indexPayTxs = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrPayTxs = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PaymentGroupPayTxs>(x => Structs.PaymentGroupPayTxs.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrPayTxs.Decode(bytes.Skip(indexPayTxs + prefixOffset).ToArray());
                    ret.PayTxs = arrPayTxs.Value.ToArray();
                    var indexAssetTxs = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrAssetTxs = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PaymentGroupAssetTxs>(x => Structs.PaymentGroupAssetTxs.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrAssetTxs.Decode(bytes.Skip(indexAssetTxs + prefixOffset).ToArray());
                    ret.AssetTxs = arrAssetTxs.Value.ToArray();
                    var indexAppTxs = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrAppTxs = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PaymentGroupAppTxs>(x => Structs.PaymentGroupAppTxs.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrAppTxs.Decode(bytes.Skip(indexAppTxs + prefixOffset).ToArray());
                    ret.AppTxs = arrAppTxs.Value.ToArray();
                    var indexKeyRegTxs = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrKeyRegTxs = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PaymentGroupKeyRegTxs>(x => Structs.PaymentGroupKeyRegTxs.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrKeyRegTxs.Decode(bytes.Skip(indexKeyRegTxs + prefixOffset).ToArray());
                    ret.KeyRegTxs = arrKeyRegTxs.Value.ToArray();
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PaymentGroup);
                }
                public bool Equals(PaymentGroup? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PaymentGroup left, PaymentGroup right)
                {
                    return EqualityComparer<PaymentGroup>.Default.Equals(left, right);
                }
                public static bool operator !=(PaymentGroup left, PaymentGroup right)
                {
                    return !(left == right);
                }

            }

            public class SignatorGroupStruct : AVMObjectType
            {
                public ulong ThresholdCount { get; set; }

                public ulong AccountsCount { get; set; }

                public ulong SpendingLimitAmount { get; set; }

                public ulong SpendingLimitAsset { get; set; }

                public ulong SpendingLimitDuration { get; set; }

                public bool IsAdmin { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vThresholdCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vThresholdCount.From(ThresholdCount);
                    ret.AddRange(vThresholdCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccountsCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAccountsCount.From(AccountsCount);
                    ret.AddRange(vAccountsCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpendingLimitAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSpendingLimitAmount.From(SpendingLimitAmount);
                    ret.AddRange(vSpendingLimitAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpendingLimitAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSpendingLimitAsset.From(SpendingLimitAsset);
                    ret.AddRange(vSpendingLimitAsset.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpendingLimitDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSpendingLimitDuration.From(SpendingLimitDuration);
                    ret.AddRange(vSpendingLimitDuration.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsAdmin.From(IsAdmin);
                    ret.AddRange(vIsAdmin.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SignatorGroupStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SignatorGroupStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vThresholdCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vThresholdCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueThresholdCount = vThresholdCount.ToValue();
                    if (valueThresholdCount is ulong vThresholdCountValue) { ret.ThresholdCount = vThresholdCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccountsCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAccountsCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccountsCount = vAccountsCount.ToValue();
                    if (valueAccountsCount is ulong vAccountsCountValue) { ret.AccountsCount = vAccountsCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpendingLimitAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSpendingLimitAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpendingLimitAmount = vSpendingLimitAmount.ToValue();
                    if (valueSpendingLimitAmount is ulong vSpendingLimitAmountValue) { ret.SpendingLimitAmount = vSpendingLimitAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpendingLimitAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSpendingLimitAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpendingLimitAsset = vSpendingLimitAsset.ToValue();
                    if (valueSpendingLimitAsset is ulong vSpendingLimitAssetValue) { ret.SpendingLimitAsset = vSpendingLimitAssetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpendingLimitDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSpendingLimitDuration.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpendingLimitDuration = vSpendingLimitDuration.ToValue();
                    if (valueSpendingLimitDuration is ulong vSpendingLimitDurationValue) { ret.SpendingLimitDuration = vSpendingLimitDurationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsAdmin = vIsAdmin.ToValue();
                    if (valueIsAdmin is bool vIsAdminValue) { ret.IsAdmin = vIsAdminValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SignatorGroupStruct);
                }
                public bool Equals(SignatorGroupStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SignatorGroupStruct left, SignatorGroupStruct right)
                {
                    return EqualityComparer<SignatorGroupStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(SignatorGroupStruct left, SignatorGroupStruct right)
                {
                    return !(left == right);
                }

            }

            public class VaultAsset : AVMObjectType
            {
                public string Vault { get; set; }

                public ulong Asset { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVault = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVault.From(Vault);
                    stringRef[ret.Count] = vVault.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset.From(Asset);
                    ret.AddRange(vAsset.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VaultAsset Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new VaultAsset();
                    uint count = 0;
                    var indexVault = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVault = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVault.Decode(bytes.Skip(indexVault + prefixOffset).ToArray());
                    var valueVault = vVault.ToValue();
                    if (valueVault is string vVaultValue) { ret.Vault = vVaultValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VaultAsset);
                }
                public bool Equals(VaultAsset? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VaultAsset left, VaultAsset right)
                {
                    return EqualityComparer<VaultAsset>.Default.Equals(left, right);
                }
                public static bool operator !=(VaultAsset left, VaultAsset right)
                {
                    return !(left == right);
                }

            }

            public class VaultSignatorGroup : AVMObjectType
            {
                public string Vault { get; set; }

                public string SignatorGroupName { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVault = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVault.From(Vault);
                    stringRef[ret.Count] = vVault.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignatorGroupName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSignatorGroupName.From(SignatorGroupName);
                    stringRef[ret.Count] = vSignatorGroupName.Encode();
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

                public static VaultSignatorGroup Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new VaultSignatorGroup();
                    var indexVault = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVault = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVault.Decode(bytes.Skip(indexVault + prefixOffset).ToArray());
                    var valueVault = vVault.ToValue();
                    if (valueVault is string vVaultValue) { ret.Vault = vVaultValue; }
                    var indexSignatorGroupName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignatorGroupName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSignatorGroupName.Decode(bytes.Skip(indexSignatorGroupName + prefixOffset).ToArray());
                    var valueSignatorGroupName = vSignatorGroupName.ToValue();
                    if (valueSignatorGroupName is string vSignatorGroupNameValue) { ret.SignatorGroupName = vSignatorGroupNameValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VaultSignatorGroup);
                }
                public bool Equals(VaultSignatorGroup? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VaultSignatorGroup left, VaultSignatorGroup right)
                {
                    return EqualityComparer<VaultSignatorGroup>.Default.Equals(left, right);
                }
                public static bool operator !=(VaultSignatorGroup left, VaultSignatorGroup right)
                {
                    return !(left == right);
                }

            }

            public class VaultSignerAddress : AVMObjectType
            {
                public string Vault { get; set; }

                public string SignatorGroupName { get; set; }

                public Algorand.Address SignerAddress { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVault = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVault.From(Vault);
                    stringRef[ret.Count] = vVault.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignatorGroupName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSignatorGroupName.From(SignatorGroupName);
                    stringRef[ret.Count] = vSignatorGroupName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignerAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSignerAddress.From(SignerAddress);
                    ret.AddRange(vSignerAddress.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VaultSignerAddress Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new VaultSignerAddress();
                    uint count = 0;
                    var indexVault = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVault = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVault.Decode(bytes.Skip(indexVault + prefixOffset).ToArray());
                    var valueVault = vVault.ToValue();
                    if (valueVault is string vVaultValue) { ret.Vault = vVaultValue; }
                    var indexSignatorGroupName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignatorGroupName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSignatorGroupName.Decode(bytes.Skip(indexSignatorGroupName + prefixOffset).ToArray());
                    var valueSignatorGroupName = vSignatorGroupName.ToValue();
                    if (valueSignatorGroupName is string vSignatorGroupNameValue) { ret.SignatorGroupName = vSignatorGroupNameValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSignerAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSignerAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSignerAddress = vSignerAddress.ToValue();
                    if (valueSignerAddress is Algorand.Address vSignerAddressValue) { ret.SignerAddress = vSignerAddressValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VaultSignerAddress);
                }
                public bool Equals(VaultSignerAddress? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VaultSignerAddress left, VaultSignerAddress right)
                {
                    return EqualityComparer<VaultSignerAddress>.Default.Equals(left, right);
                }
                public static bool operator !=(VaultSignerAddress left, VaultSignerAddress right)
                {
                    return !(left == right);
                }

            }

            public class PaymentGroupPayTxs : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] Field2 { get; set; }

                public byte[] Field3 { get; set; }

                public ulong Field4 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PaymentGroupPayTxs Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PaymentGroupPayTxs();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[] vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is byte[] vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PaymentGroupPayTxs);
                }
                public bool Equals(PaymentGroupPayTxs? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PaymentGroupPayTxs left, PaymentGroupPayTxs right)
                {
                    return EqualityComparer<PaymentGroupPayTxs>.Default.Equals(left, right);
                }
                public static bool operator !=(PaymentGroupPayTxs left, PaymentGroupPayTxs right)
                {
                    return !(left == right);
                }

            }

            public class PaymentGroupAssetTxs : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] Field3 { get; set; }

                public byte[] Field4 { get; set; }

                public ulong Field5 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static PaymentGroupAssetTxs Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PaymentGroupAssetTxs();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is byte[] vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is byte[] vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PaymentGroupAssetTxs);
                }
                public bool Equals(PaymentGroupAssetTxs? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PaymentGroupAssetTxs left, PaymentGroupAssetTxs right)
                {
                    return EqualityComparer<PaymentGroupAssetTxs>.Default.Equals(left, right);
                }
                public static bool operator !=(PaymentGroupAssetTxs left, PaymentGroupAssetTxs right)
                {
                    return !(left == right);
                }

            }

            public class PaymentGroupAppTxs : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public Structs.PaymentGroupAppTxsField5 Field5 { get; set; } = new Structs.PaymentGroupAppTxsField5();

                public Structs.PaymentGroupAppTxsField5 Field6 { get; set; } = new Structs.PaymentGroupAppTxsField5();

                public Structs.PaymentGroupAppTxsField7 Field7 { get; set; } = new Structs.PaymentGroupAppTxsField7();

                public Structs.PaymentGroupAppTxsField7 Field8 { get; set; } = new Structs.PaymentGroupAppTxsField7();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    stringRef[ret.Count] = Field5.ToByteArray();
                    ret.AddRange(new byte[2]);
                    stringRef[ret.Count] = Field6.ToByteArray();
                    ret.AddRange(new byte[2]);
                    stringRef[ret.Count] = Field7.ToByteArray();
                    ret.AddRange(new byte[2]);
                    stringRef[ret.Count] = Field8.ToByteArray();
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

                public static PaymentGroupAppTxs Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new PaymentGroupAppTxs();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[] vField2Value) { ret.Field2 = vField2Value; }
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
                    var indexField5 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field5 = Structs.PaymentGroupAppTxsField5.Parse(bytes.Skip(indexField5 + prefixOffset).ToArray());
                    var indexField6 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field6 = Structs.PaymentGroupAppTxsField5.Parse(bytes.Skip(indexField6 + prefixOffset).ToArray());
                    var indexField7 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field7 = Structs.PaymentGroupAppTxsField7.Parse(bytes.Skip(indexField7 + prefixOffset).ToArray());
                    var indexField8 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field8 = Structs.PaymentGroupAppTxsField7.Parse(bytes.Skip(indexField8 + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PaymentGroupAppTxs);
                }
                public bool Equals(PaymentGroupAppTxs? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PaymentGroupAppTxs left, PaymentGroupAppTxs right)
                {
                    return EqualityComparer<PaymentGroupAppTxs>.Default.Equals(left, right);
                }
                public static bool operator !=(PaymentGroupAppTxs left, PaymentGroupAppTxs right)
                {
                    return !(left == right);
                }

            }

            public class PaymentGroupAppTxsField5 : AVMObjectType
            {
                public byte[][] Field0 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[][]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PaymentGroupAppTxsField5 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PaymentGroupAppTxsField5();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[][]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[][] vField0Value) { ret.Field0 = vField0Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PaymentGroupAppTxsField5);
                }
                public bool Equals(PaymentGroupAppTxsField5? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PaymentGroupAppTxsField5 left, PaymentGroupAppTxsField5 right)
                {
                    return EqualityComparer<PaymentGroupAppTxsField5>.Default.Equals(left, right);
                }
                public static bool operator !=(PaymentGroupAppTxsField5 left, PaymentGroupAppTxsField5 right)
                {
                    return !(left == right);
                }

            }

            public class PaymentGroupAppTxsField7 : AVMObjectType
            {
                public ulong[] Field0 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PaymentGroupAppTxsField7 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PaymentGroupAppTxsField7();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong[] vField0Value) { ret.Field0 = vField0Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PaymentGroupAppTxsField7);
                }
                public bool Equals(PaymentGroupAppTxsField7? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PaymentGroupAppTxsField7 left, PaymentGroupAppTxsField7 right)
                {
                    return EqualityComparer<PaymentGroupAppTxsField7>.Default.Equals(left, right);
                }
                public static bool operator !=(PaymentGroupAppTxsField7 left, PaymentGroupAppTxsField7 right)
                {
                    return !(left == right);
                }

            }

            public class PaymentGroupKeyRegTxs : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public byte[] Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public bool Field5 { get; set; }

                public byte[] Field6 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PaymentGroupKeyRegTxs Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PaymentGroupKeyRegTxs();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[64]");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is byte[] vField6Value) { ret.Field6 = vField6Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PaymentGroupKeyRegTxs);
                }
                public bool Equals(PaymentGroupKeyRegTxs? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PaymentGroupKeyRegTxs left, PaymentGroupKeyRegTxs right)
                {
                    return EqualityComparer<PaymentGroupKeyRegTxs>.Default.Equals(left, right);
                }
                public static bool operator !=(PaymentGroupKeyRegTxs left, PaymentGroupKeyRegTxs right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///This method creates a new vault with the given name and signer.
        ///</summary>
        /// <param name="vaultName">Name of the vault. Must be unique for everyone. </param>
        /// <param name="signatorGroupName"> </param>
        public async Task<bool> CreateVault(string vaultName, string signatorGroupName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 188, 188, 159 };
            var vaultNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); vaultNameAbi.From(vaultName);
            var signatorGroupNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); signatorGroupNameAbi.From(signatorGroupName);

            var result = await base.CallApp(new List<object> { abiHandle, vaultNameAbi, signatorGroupNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateVault_Transactions(string vaultName, string signatorGroupName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 188, 188, 159 };
            var vaultNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); vaultNameAbi.From(vaultName);
            var signatorGroupNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); signatorGroupNameAbi.From(signatorGroupName);

            return await base.MakeTransactionList(new List<object> { abiHandle, vaultNameAbi, signatorGroupNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Creates configuration change proposal. This proposal must be approved by signators based on the rules defined for the vault and the type of the proposal. For example, add signator proposal must be created by admin signator and it must be approved by all existing signators. On the other hand, change threshold proposal can be created by any signator and it must be approved only by threshold number of signators. Each type of proposal has its own rules for creation and approval/rejection which are defined in the implementation of this method and in the approval/rejection methods for each proposal type.
        ///</summary>
        /// <param name="proposal">Proposal structure Object31872968</param>
        /// <param name="propoerSignatorGroupName">Name of the signator group of the proposer. This is needed to validate that the proposer is valid signator and to check his permissions for creating the proposal based on the type of the proposal. </param>
        public async Task<bool> CreateProposal(Structs.Object31872968 proposal, string propoerSignatorGroupName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 46, 63, 85 };
            var propoerSignatorGroupNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); propoerSignatorGroupNameAbi.From(propoerSignatorGroupName);

            var result = await base.CallApp(new List<object> { abiHandle, proposal, propoerSignatorGroupNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateProposal_Transactions(Structs.Object31872968 proposal, string propoerSignatorGroupName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 46, 63, 85 };
            var propoerSignatorGroupNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); propoerSignatorGroupNameAbi.From(propoerSignatorGroupName);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposal, propoerSignatorGroupNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Signer can approve the proposal by calling this method. When the number of approvals reaches the threshold defined in the signator group for the vault, the proposal is executed and the proposed change is applied to the vault configuration. If the proposal is not approved until validUntil timestamp, it is rejected and cannot be approved anymore.
        ///</summary>
        /// <param name="proposalId">Guid of the proposal </param>
        public async Task<bool> ApproveProposal(string proposalId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 249, 239, 160 };
            var proposalIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposalIdAbi.From(proposalId);

            var result = await base.CallApp(new List<object> { abiHandle, proposalIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ApproveProposal_Transactions(string proposalId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 249, 239, 160 };
            var proposalIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposalIdAbi.From(proposalId);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposalIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmlhdGVjVmF1bHQiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiT2JqZWN0MzE4NzI5NjgiOlt7Im5hbWUiOiJwcm9wb3NhbElkIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InNpZ25hdHVyZXNDb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2YXVsdCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJzaWduYXRvckdyb3VwTmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ2YWxpZFVudGlsVGltZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcm9wb3NhbFR5cGUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiY2hhbmdlZFNpZ25hdG9yIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJjaGFuZ2VkVGhyZXNob2xkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNoYW5nZWRTcGVuZGluZ0xpbWl0QXNzZXRJZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjaGFuZ2VkU3BlbmRpbmdMaW1pdEFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjaGFuZ2VkU3BlbmRpbmdMaW1pdER1cmF0aW9uIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRyYW5zYWN0aW9ucyIsInR5cGUiOiJQYXltZW50R3JvdXAifV0sIkFwcHJvdmVyV2l0aFBycG9zYWxJZCI6W3sibmFtZSI6InByb3Bvc2FsSWQiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYXBwcm92ZXJBZGRyZXNzIiwidHlwZSI6ImFkZHJlc3MifV0sIlBheW1lbnRHcm91cCI6W3sibmFtZSI6ImNvdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InR5cGUiLCJ0eXBlIjoic3RyaW5nW10ifSx7Im5hbWUiOiJwYXlUeHMiLCJ0eXBlIjoiUGF5bWVudEdyb3VwUGF5VHhzW10ifSx7Im5hbWUiOiJhc3NldFR4cyIsInR5cGUiOiJQYXltZW50R3JvdXBBc3NldFR4c1tdIn0seyJuYW1lIjoiYXBwVHhzIiwidHlwZSI6IlBheW1lbnRHcm91cEFwcFR4c1tdIn0seyJuYW1lIjoia2V5UmVnVHhzIiwidHlwZSI6IlBheW1lbnRHcm91cEtleVJlZ1R4c1tdIn1dLCJTaWduYXRvckdyb3VwU3RydWN0IjpbeyJuYW1lIjoidGhyZXNob2xkQ291bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWNjb3VudHNDb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzcGVuZGluZ0xpbWl0QW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNwZW5kaW5nTGltaXRBc3NldCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzcGVuZGluZ0xpbWl0RHVyYXRpb24iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaXNBZG1pbiIsInR5cGUiOiJib29sIn1dLCJWYXVsdEFzc2V0IjpbeyJuYW1lIjoidmF1bHQiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYXNzZXQiLCJ0eXBlIjoidWludDY0In1dLCJWYXVsdFNpZ25hdG9yR3JvdXAiOlt7Im5hbWUiOiJ2YXVsdCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJzaWduYXRvckdyb3VwTmFtZSIsInR5cGUiOiJzdHJpbmcifV0sIlZhdWx0U2lnbmVyQWRkcmVzcyI6W3sibmFtZSI6InZhdWx0IiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InNpZ25hdG9yR3JvdXBOYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InNpZ25lckFkZHJlc3MiLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiUGF5bWVudEdyb3VwUGF5VHhzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50NjQifV0sIlBheW1lbnRHcm91cEFzc2V0VHhzIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJmaWVsZDUiLCJ0eXBlIjoidWludDY0In1dLCJQYXltZW50R3JvdXBBcHBUeHMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJQYXltZW50R3JvdXBBcHBUeHNGaWVsZDUifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoiUGF5bWVudEdyb3VwQXBwVHhzRmllbGQ1In0seyJuYW1lIjoiZmllbGQ3IiwidHlwZSI6IlBheW1lbnRHcm91cEFwcFR4c0ZpZWxkNyJ9LHsibmFtZSI6ImZpZWxkOCIsInR5cGUiOiJQYXltZW50R3JvdXBBcHBUeHNGaWVsZDcifV0sIlBheW1lbnRHcm91cEFwcFR4c0ZpZWxkNSI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJieXRlW11bXSJ9XSwiUGF5bWVudEdyb3VwQXBwVHhzRmllbGQ3IjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NFtdIn1dLCJQYXltZW50R3JvdXBLZXlSZWdUeHMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYnl0ZVszMl0ifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDUiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkNiIsInR5cGUiOiJieXRlWzY0XSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVWYXVsdCIsImRlc2MiOiJUaGlzIG1ldGhvZCBjcmVhdGVzIGEgbmV3IHZhdWx0IHdpdGggdGhlIGdpdmVuIG5hbWUgYW5kIHNpZ25lci4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmF1bHROYW1lIiwiZGVzYyI6Ik5hbWUgb2YgdGhlIHZhdWx0LiBNdXN0IGJlIHVuaXF1ZSBmb3IgZXZlcnlvbmUuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYXRvckdyb3VwTmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVHJ1ZSBpZiB0aGUgdmF1bHQgd2FzIGNyZWF0ZWQgc3VjY2Vzc2Z1bGx5LiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZVByb3Bvc2FsIiwiZGVzYyI6IkNyZWF0ZXMgY29uZmlndXJhdGlvbiBjaGFuZ2UgcHJvcG9zYWwuIFRoaXMgcHJvcG9zYWwgbXVzdCBiZSBhcHByb3ZlZCBieSBzaWduYXRvcnMgYmFzZWQgb24gdGhlIHJ1bGVzIGRlZmluZWQgZm9yIHRoZSB2YXVsdCBhbmQgdGhlIHR5cGUgb2YgdGhlIHByb3Bvc2FsLiBGb3IgZXhhbXBsZSwgYWRkIHNpZ25hdG9yIHByb3Bvc2FsIG11c3QgYmUgY3JlYXRlZCBieSBhZG1pbiBzaWduYXRvciBhbmQgaXQgbXVzdCBiZSBhcHByb3ZlZCBieSBhbGwgZXhpc3Rpbmcgc2lnbmF0b3JzLiBPbiB0aGUgb3RoZXIgaGFuZCwgY2hhbmdlIHRocmVzaG9sZCBwcm9wb3NhbCBjYW4gYmUgY3JlYXRlZCBieSBhbnkgc2lnbmF0b3IgYW5kIGl0IG11c3QgYmUgYXBwcm92ZWQgb25seSBieSB0aHJlc2hvbGQgbnVtYmVyIG9mIHNpZ25hdG9ycy4gRWFjaCB0eXBlIG9mIHByb3Bvc2FsIGhhcyBpdHMgb3duIHJ1bGVzIGZvciBjcmVhdGlvbiBhbmQgYXBwcm92YWwvcmVqZWN0aW9uIHdoaWNoIGFyZSBkZWZpbmVkIGluIHRoZSBpbXBsZW1lbnRhdGlvbiBvZiB0aGlzIG1ldGhvZCBhbmQgaW4gdGhlIGFwcHJvdmFsL3JlamVjdGlvbiBtZXRob2RzIGZvciBlYWNoIHByb3Bvc2FsIHR5cGUuIiwiYXJncyI6W3sidHlwZSI6IihzdHJpbmcsdWludDY0LHN0cmluZyxzdHJpbmcsdWludDY0LHN0cmluZyxhZGRyZXNzLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCwodWludDY0LHN0cmluZ1tdLChieXRlW10sdWludDY0LGJ5dGVbXSxieXRlW10sdWludDY0KVtdLChieXRlW10sdWludDY0LHVpbnQ2NCxieXRlW10sYnl0ZVtdLHVpbnQ2NClbXSwoYnl0ZVtdLHVpbnQ2NCxieXRlW10sdWludDY0LHVpbnQ2NCwoYnl0ZVtdW10pLChieXRlW11bXSksKHVpbnQ2NFtdKSwodWludDY0W10pKVtdLChieXRlWzMyXSxieXRlWzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sLGJ5dGVbNjRdKVtdKSkiLCJzdHJ1Y3QiOiJPYmplY3QzMTg3Mjk2OCIsIm5hbWUiOiJwcm9wb3NhbCIsImRlc2MiOiJQcm9wb3NhbCBzdHJ1Y3R1cmUiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3BvZXJTaWduYXRvckdyb3VwTmFtZSIsImRlc2MiOiJOYW1lIG9mIHRoZSBzaWduYXRvciBncm91cCBvZiB0aGUgcHJvcG9zZXIuIFRoaXMgaXMgbmVlZGVkIHRvIHZhbGlkYXRlIHRoYXQgdGhlIHByb3Bvc2VyIGlzIHZhbGlkIHNpZ25hdG9yIGFuZCB0byBjaGVjayBoaXMgcGVybWlzc2lvbnMgZm9yIGNyZWF0aW5nIHRoZSBwcm9wb3NhbCBiYXNlZCBvbiB0aGUgdHlwZSBvZiB0aGUgcHJvcG9zYWwuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUcnVlIGlmIHRoZSBwcm9wb3NhbCB3YXMgY3JlYXRlZCBzdWNjZXNzZnVsbHkuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXBwcm92ZVByb3Bvc2FsIiwiZGVzYyI6IlNpZ25lciBjYW4gYXBwcm92ZSB0aGUgcHJvcG9zYWwgYnkgY2FsbGluZyB0aGlzIG1ldGhvZC4gV2hlbiB0aGUgbnVtYmVyIG9mIGFwcHJvdmFscyByZWFjaGVzIHRoZSB0aHJlc2hvbGQgZGVmaW5lZCBpbiB0aGUgc2lnbmF0b3IgZ3JvdXAgZm9yIHRoZSB2YXVsdCwgdGhlIHByb3Bvc2FsIGlzIGV4ZWN1dGVkIGFuZCB0aGUgcHJvcG9zZWQgY2hhbmdlIGlzIGFwcGxpZWQgdG8gdGhlIHZhdWx0IGNvbmZpZ3VyYXRpb24uIElmIHRoZSBwcm9wb3NhbCBpcyBub3QgYXBwcm92ZWQgdW50aWwgdmFsaWRVbnRpbCB0aW1lc3RhbXAsIGl0IGlzIHJlamVjdGVkIGFuZCBjYW5ub3QgYmUgYXBwcm92ZWQgYW55bW9yZS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxJZCIsImRlc2MiOiJHdWlkIG9mIHRoZSBwcm9wb3NhbCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoiVHJ1ZSBpZiB0aGUgcHJvcG9zYWwgd2FzIGFwcHJvdmVkIGFuZCBleGVjdXRlZCBzdWNjZXNzZnVsbHkuIEZhbHNlIGlmIHRoZSBwcm9wb3NhbCB3YXMgYXBwcm92ZWQgYnV0IGl0IGlzIG5vdCBleGVjdXRlZCB5ZXQgYmVjYXVzZSB0aGUgbnVtYmVyIG9mIGFwcHJvdmFscyBkaWQgbm90IHJlYWNoIHRoZSB0aHJlc2hvbGQgZGVmaW5lZCBpbiB0aGUgc2lnbmF0b3IgZ3JvdXAgZm9yIHRoZSB2YXVsdC4ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE0NTVdLCJlcnJvck1lc3NhZ2UiOiJBZGQgc2lnbmF0b3IgcHJvcG9zYWwgbXVzdCBoYXZlIGNoYW5nZWRTaWduYXRvciBmaWVsZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MjRdLCJlcnJvck1lc3NhZ2UiOiJBcHByb3ZlciBjYW4gb25seSBvbmNlIGFwcHJvdmUgdGhlIHByb3Bvc2FsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU4MiwxODA0LDE4NjBdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUxNF0sImVycm9yTWVzc2FnZSI6IkNoYW5nZSBzcGVuZGluZyBsaW1pdCBwcm9wb3NhbCBtdXN0IGhhdmUgY2hhbmdlZFNwZW5kaW5nTGltaXREdXJhdGlvbiBmaWVsZCB3aGVuIGNoYW5nZWRTcGVuZGluZ0xpbWl0QW1vdW50IGlzIGdyZWF0ZXIgdGhhbiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ4OV0sImVycm9yTWVzc2FnZSI6IkNoYW5nZSB0aHJlc2hvbGQgcHJvcG9zYWwgbXVzdCBoYXZlIGNoYW5nZWRUaHJlc2hvbGQgZmllbGQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzgwXSwiZXJyb3JNZXNzYWdlIjoiTmV3IHByb3Bvc2FsIG11c3QgaGF2ZSAwIHNpZ25hdHVyZXMgY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA2XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzAzXSwiZXJyb3JNZXNzYWdlIjoiT25seSBhY3RpdmUgdmFsaWQgc2lnbmF0b3JzIGNhbiBhcHByb3ZlIHRoZSBjaGFuZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzk0XSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBzaWduZXJzIGNhbiBjcmVhdGUgYWRkIHNpZ25hdG9yIHByb3Bvc2FscyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NjRdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHNpZ25hdG9ycyBjYW4gYXBwcm92ZSBwcm9wb3NhbHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzc0XSwiZXJyb3JNZXNzYWdlIjoiT25seSBzaWduZXJzIGNhbiBjcmVhdGUgcHJvcG9zYWxzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY5OF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdmFsaWQgc2lnbmF0b3JzIGNhbiBhcHByb3ZlIHRoZSBjaGFuZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDMzXSwiZXJyb3JNZXNzYWdlIjoiT25seSB2YWxpZCBzaWduYXRvcnMgY2FuIHByb3Bvc2UgdGhlIGNoYW5nZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MDRdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHZhbGlkIHNpZ25hdG9ycyB3aXRoIHZhbGlkIHNpZ25hdG9yIGdyb3VwIGNhbiBwcm9wb3NlIHRoZSBjaGFuZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTkyXSwiZXJyb3JNZXNzYWdlIjoiUHJvcG9zYWwgaXMgZXhwaXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MzNdLCJlcnJvck1lc3NhZ2UiOiJQcm9wb3NhbCB3aXRoIHRoZSBzYW1lIGlkIGFscmVhZHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ3Ml0sImVycm9yTWVzc2FnZSI6IlJlbW92ZSBzaWduYXRvciBwcm9wb3NhbCBtdXN0IGhhdmUgY2hhbmdlZFNpZ25hdG9yIGZpZWxkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUwXSwiZXJyb3JNZXNzYWdlIjoiVmF1bHQgYWxyZWFkeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDI3LDIwOTUsMjUxNSwyOTI2XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTUzLDI1NzMsMjk4NCwzMzM1XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyOSw2MTYsNzY1LDkxNCwxMDM3LDExNDBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE1LDIzMSwzODksNDEyLDQzNiw0NjAsNTAyLDU0Myw1ODIsNjQ3LDY2Nyw2ODgsNzMxLDc5Niw4MTcsODM4LDg4MSw5NDksOTY5LDEwMDMsMTA1MSwxMTA2LDExNTQsMTIxMSwxMjQ3LDEyOTYsMTMxNSwxNTU3LDIwMjAsMjA3NywyNDk3LDI5MDhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzA5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIE9iamVjdDMxODcyOTY4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI1LDIzOCwxMzIyLDE1NjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM5NCwzNDA0LDM0MjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHNpemUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OTgsMTEwMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rKGxlbit1aW50OFtdKVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjA3LDEyNDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAwIG9mICgobGVuK3VpbnQ2NFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAwIG9mICgobGVuK3VpbnQ4W10pLHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksdWludDY0KSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk0MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rdWludDhbXSksdWludDY0LChsZW4rdWludDhbXSksdWludDY0LHVpbnQ2NCwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbit1aW50NjRbXSkpLCgobGVuK3VpbnQ2NFtdKSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzg4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMCBvZiAoKGxlbit1aW50OFtdKSx1aW50NjQsdWludDY0LChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSx1aW50NjQpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzgxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMCBvZiAoKGxlbit1dGY4W10pLHVpbnQ2NCwobGVuK3V0ZjhbXSksKGxlbit1dGY4W10pLHVpbnQ2NCwobGVuK3V0ZjhbXSksdWludDhbMzJdLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCwodWludDY0LChsZW4rKGxlbit1dGY4W10pW10pLChsZW4rKChsZW4rdWludDhbXSksdWludDY0LChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSx1aW50NjQpW10pLChsZW4rKChsZW4rdWludDhbXSksdWludDY0LHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksdWludDY0KVtdKSwobGVuKygobGVuK3VpbnQ4W10pLHVpbnQ2NCwobGVuK3VpbnQ4W10pLHVpbnQ2NCx1aW50NjQsKChsZW4rKGxlbit1aW50OFtdKVtdKSksKChsZW4rKGxlbit1aW50OFtdKVtdKSksKChsZW4rdWludDY0W10pKSwoKGxlbit1aW50NjRbXSkpKVtdKSwobGVuKyh1aW50OFszMl0sdWludDhbMzJdLHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wxLHVpbnQ4WzY0XSlbXSkpKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDEgb2YgKHVpbnQ2NCwobGVuKyhsZW4rdXRmOFtdKVtdKSwobGVuKygobGVuK3VpbnQ4W10pLHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksdWludDY0KVtdKSwobGVuKygobGVuK3VpbnQ4W10pLHVpbnQ2NCx1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pLHVpbnQ2NClbXSksKGxlbisoKGxlbit1aW50OFtdKSx1aW50NjQsKGxlbit1aW50OFtdKSx1aW50NjQsdWludDY0LCgobGVuKyhsZW4rdWludDhbXSlbXSkpLCgobGVuKyhsZW4rdWludDhbXSlbXSkpLCgobGVuK3VpbnQ2NFtdKSksKChsZW4rdWludDY0W10pKSlbXSksKGxlbisodWludDhbMzJdLHVpbnQ4WzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sMSx1aW50OFs2NF0pW10pKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDExIG9mICgobGVuK3V0ZjhbXSksdWludDY0LChsZW4rdXRmOFtdKSwobGVuK3V0ZjhbXSksdWludDY0LChsZW4rdXRmOFtdKSx1aW50OFszMl0sdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LCh1aW50NjQsKGxlbisobGVuK3V0ZjhbXSlbXSksKGxlbisoKGxlbit1aW50OFtdKSx1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pLHVpbnQ2NClbXSksKGxlbisoKGxlbit1aW50OFtdKSx1aW50NjQsdWludDY0LChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSx1aW50NjQpW10pLChsZW4rKChsZW4rdWludDhbXSksdWludDY0LChsZW4rdWludDhbXSksdWludDY0LHVpbnQ2NCwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbit1aW50NjRbXSkpLCgobGVuK3VpbnQ2NFtdKSkpW10pLChsZW4rKHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbDEsdWludDhbNjRdKVtdKSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjU5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMiBvZiAoKGxlbit1aW50OFtdKSx1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pLHVpbnQ2NCkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NjFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAyIG9mICgobGVuK3VpbnQ4W10pLHVpbnQ2NCwobGVuK3VpbnQ4W10pLHVpbnQ2NCx1aW50NjQsKChsZW4rKGxlbit1aW50OFtdKVtdKSksKChsZW4rKGxlbit1aW50OFtdKVtdKSksKChsZW4rdWludDY0W10pKSwoKGxlbit1aW50NjRbXSkpKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDIgb2YgKChsZW4rdXRmOFtdKSx1aW50NjQsKGxlbit1dGY4W10pLChsZW4rdXRmOFtdKSx1aW50NjQsKGxlbit1dGY4W10pLHVpbnQ4WzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsKHVpbnQ2NCwobGVuKyhsZW4rdXRmOFtdKVtdKSwobGVuKygobGVuK3VpbnQ4W10pLHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksdWludDY0KVtdKSwobGVuKygobGVuK3VpbnQ4W10pLHVpbnQ2NCx1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pLHVpbnQ2NClbXSksKGxlbisoKGxlbit1aW50OFtdKSx1aW50NjQsKGxlbit1aW50OFtdKSx1aW50NjQsdWludDY0LCgobGVuKyhsZW4rdWludDhbXSlbXSkpLCgobGVuKyhsZW4rdWludDhbXSlbXSkpLCgobGVuK3VpbnQ2NFtdKSksKChsZW4rdWludDY0W10pKSlbXSksKGxlbisodWludDhbMzJdLHVpbnQ4WzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sMSx1aW50OFs2NF0pW10pKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAyIG9mICh1aW50NjQsKGxlbisobGVuK3V0ZjhbXSlbXSksKGxlbisoKGxlbit1aW50OFtdKSx1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pLHVpbnQ2NClbXSksKGxlbisoKGxlbit1aW50OFtdKSx1aW50NjQsdWludDY0LChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSx1aW50NjQpW10pLChsZW4rKChsZW4rdWludDhbXSksdWludDY0LChsZW4rdWludDhbXSksdWludDY0LHVpbnQ2NCwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbit1aW50NjRbXSkpLCgobGVuK3VpbnQ2NFtdKSkpW10pLChsZW4rKHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbDEsdWludDhbNjRdKVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAzIG9mICgobGVuK3VpbnQ4W10pLHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksdWludDY0KSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDMgb2YgKChsZW4rdWludDhbXSksdWludDY0LHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksdWludDY0KSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDMgb2YgKChsZW4rdXRmOFtdKSx1aW50NjQsKGxlbit1dGY4W10pLChsZW4rdXRmOFtdKSx1aW50NjQsKGxlbit1dGY4W10pLHVpbnQ4WzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsKHVpbnQ2NCwobGVuKyhsZW4rdXRmOFtdKVtdKSwobGVuKygobGVuK3VpbnQ4W10pLHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksdWludDY0KVtdKSwobGVuKygobGVuK3VpbnQ4W10pLHVpbnQ2NCx1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pLHVpbnQ2NClbXSksKGxlbisoKGxlbit1aW50OFtdKSx1aW50NjQsKGxlbit1aW50OFtdKSx1aW50NjQsdWludDY0LCgobGVuKyhsZW4rdWludDhbXSlbXSkpLCgobGVuKyhsZW4rdWludDhbXSlbXSkpLCgobGVuK3VpbnQ2NFtdKSksKChsZW4rdWludDY0W10pKSlbXSksKGxlbisodWludDhbMzJdLHVpbnQ4WzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sMSx1aW50OFs2NF0pW10pKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAzIG9mICh1aW50NjQsKGxlbisobGVuK3V0ZjhbXSlbXSksKGxlbisoKGxlbit1aW50OFtdKSx1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pLHVpbnQ2NClbXSksKGxlbisoKGxlbit1aW50OFtdKSx1aW50NjQsdWludDY0LChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSx1aW50NjQpW10pLChsZW4rKChsZW4rdWludDhbXSksdWludDY0LChsZW4rdWludDhbXSksdWludDY0LHVpbnQ2NCwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbit1aW50NjRbXSkpLCgobGVuK3VpbnQ2NFtdKSkpW10pLChsZW4rKHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbDEsdWludDhbNjRdKVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA0IG9mICgobGVuK3VpbnQ4W10pLHVpbnQ2NCx1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pLHVpbnQ2NCkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NzVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA0IG9mICh1aW50NjQsKGxlbisobGVuK3V0ZjhbXSlbXSksKGxlbisoKGxlbit1aW50OFtdKSx1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pLHVpbnQ2NClbXSksKGxlbisoKGxlbit1aW50OFtdKSx1aW50NjQsdWludDY0LChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSx1aW50NjQpW10pLChsZW4rKChsZW4rdWludDhbXSksdWludDY0LChsZW4rdWludDhbXSksdWludDY0LHVpbnQ2NCwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbit1aW50NjRbXSkpLCgobGVuK3VpbnQ2NFtdKSkpW10pLChsZW4rKHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDY0LHVpbnQ2NCx1aW50NjQsYm9vbDEsdWludDhbNjRdKVtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5ODVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCA1IG9mICgobGVuK3VpbnQ4W10pLHVpbnQ2NCwobGVuK3VpbnQ4W10pLHVpbnQ2NCx1aW50NjQsKChsZW4rKGxlbit1aW50OFtdKVtdKSksKChsZW4rKGxlbit1aW50OFtdKVtdKSksKChsZW4rdWludDY0W10pKSwoKGxlbit1aW50NjRbXSkpKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDUgb2YgKChsZW4rdXRmOFtdKSx1aW50NjQsKGxlbit1dGY4W10pLChsZW4rdXRmOFtdKSx1aW50NjQsKGxlbit1dGY4W10pLHVpbnQ4WzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsKHVpbnQ2NCwobGVuKyhsZW4rdXRmOFtdKVtdKSwobGVuKygobGVuK3VpbnQ4W10pLHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksdWludDY0KVtdKSwobGVuKygobGVuK3VpbnQ4W10pLHVpbnQ2NCx1aW50NjQsKGxlbit1aW50OFtdKSwobGVuK3VpbnQ4W10pLHVpbnQ2NClbXSksKGxlbisoKGxlbit1aW50OFtdKSx1aW50NjQsKGxlbit1aW50OFtdKSx1aW50NjQsdWludDY0LCgobGVuKyhsZW4rdWludDhbXSlbXSkpLCgobGVuKyhsZW4rdWludDhbXSlbXSkpLCgobGVuK3VpbnQ2NFtdKSksKChsZW4rdWludDY0W10pKSlbXSksKGxlbisodWludDhbMzJdLHVpbnQ4WzMyXSx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sMSx1aW50OFs2NF0pW10pKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjg4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggNSBvZiAodWludDY0LChsZW4rKGxlbit1dGY4W10pW10pLChsZW4rKChsZW4rdWludDhbXSksdWludDY0LChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSx1aW50NjQpW10pLChsZW4rKChsZW4rdWludDhbXSksdWludDY0LHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksdWludDY0KVtdKSwobGVuKygobGVuK3VpbnQ4W10pLHVpbnQ2NCwobGVuK3VpbnQ4W10pLHVpbnQ2NCx1aW50NjQsKChsZW4rKGxlbit1aW50OFtdKVtdKSksKChsZW4rKGxlbit1aW50OFtdKVtdKSksKChsZW4rdWludDY0W10pKSwoKGxlbit1aW50NjRbXSkpKVtdKSwobGVuKyh1aW50OFszMl0sdWludDhbMzJdLHVpbnQ2NCx1aW50NjQsdWludDY0LGJvb2wxLHVpbnQ4WzY0XSlbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA4OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDYgb2YgKChsZW4rdWludDhbXSksdWludDY0LChsZW4rdWludDhbXSksdWludDY0LHVpbnQ2NCwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbit1aW50NjRbXSkpLCgobGVuK3VpbnQ2NFtdKSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDcgb2YgKChsZW4rdWludDhbXSksdWludDY0LChsZW4rdWludDhbXSksdWludDY0LHVpbnQ2NCwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbit1aW50NjRbXSkpLCgobGVuK3VpbnQ2NFtdKSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIyN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDggb2YgKChsZW4rdWludDhbXSksdWludDY0LChsZW4rdWludDhbXSksdWludDY0LHVpbnQ2NCwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbit1aW50NjRbXSkpLCgobGVuK3VpbnQ2NFtdKSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKChsZW4rdWludDhbXSksdWludDY0LChsZW4rdWludDhbXSksKGxlbit1aW50OFtdKSx1aW50NjQpW10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTE5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKChsZW4rdWludDhbXSksdWludDY0LChsZW4rdWludDhbXSksdWludDY0LHVpbnQ2NCwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbisobGVuK3VpbnQ4W10pW10pKSwoKGxlbit1aW50NjRbXSkpLCgobGVuK3VpbnQ2NFtdKSkpW10pIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzczXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKChsZW4rdWludDhbXSksdWludDY0LHVpbnQ2NCwobGVuK3VpbnQ4W10pLChsZW4rdWludDhbXSksdWludDY0KVtdKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNDUsMTE0OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGZvciAobGVuKyhsZW4rdWludDhbXSlbXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbisobGVuK3V0ZjhbXSlbXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzMsMzk2LDQyMCw0NDQsNDcxLDQ5MSw1NzEsNjM0LDY1NCw2NzUsNzIwLDc4Myw4MDQsODI1LDg3MCw5MzYsOTU2LDk4MCw5OTQsMTA4MywxMDk3LDExODMsMTIwMywxMjIyLDEyMzksMTI4M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01pQXdJRGdnTVRBZ01UVXpDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRPREFnSWxNaUlEQjRNREFnSW5NaUlEQjRNREF3TkNBd2VEQXdNalFnTUhnd01EQXdNREF3TURBd01EQXdNREF4SURCNE1UVXhaamRqTnpVNE1DQXdlREF3TUdNMk1UWTBOalF5WkRjek5qazJOelpsTmpFM05EWm1OeklnWW1GelpUTXlLRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRXBJREI0TURBd1pqY3lOalUyWkRabU56WTJOVEprTnpNMk9UWTNObVUyTVRjME5tWTNNaUF3ZURBd01UQTJNelk0TmpFMlpUWTNOalV5WkRjME5qZzNNalkxTnpNMk9EWm1ObU0yTkNBd2VEQXdNREF3TURBd01EQXdNREF3TURBZ01IZ3dNREUxTmpNMk9EWXhObVUyTnpZMU1tUTNNemN3TmpVMlpUWTBOamsyWlRZM01tUTJZelk1Tm1RMk9UYzBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalExQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FtbGhkR1ZqVm1GMWJIUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRBS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFpHTmlZMkpqT1dZZ01IaG1OakpsTTJZMU5TQXdlRGc1WmpsbFptRXdJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxWbUYxYkhRb2MzUnlhVzVuTEhOMGNtbHVaeWxpYjI5c0lpd2diV1YwYUc5a0lDSmpjbVZoZEdWUWNtOXdiM05oYkNnb2MzUnlhVzVuTEhWcGJuUTJOQ3h6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkN4emRISnBibWNzWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzS0hWcGJuUTJOQ3h6ZEhKcGJtZGJYU3dvWW5sMFpWdGRMSFZwYm5RMk5DeGllWFJsVzEwc1lubDBaVnRkTEhWcGJuUTJOQ2xiWFN3b1lubDBaVnRkTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZExHSjVkR1ZiWFN4MWFXNTBOalFwVzEwc0tHSjVkR1ZiWFN4MWFXNTBOalFzWW5sMFpWdGRMSFZwYm5RMk5DeDFhVzUwTmpRc0tHSjVkR1ZiWFZ0ZEtTd29ZbmwwWlZ0ZFcxMHBMQ2gxYVc1ME5qUmJYU2tzS0hWcGJuUTJORnRkS1NsYlhTd29ZbmwwWlZzek1sMHNZbmwwWlZzek1sMHNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzWW05dmJDeGllWFJsV3pZMFhTbGJYU2twTEhOMGNtbHVaeWxpYjI5c0lpd2diV1YwYUc5a0lDSmhjSEJ5YjNabFVISnZjRzl6WVd3b2MzUnlhVzVuS1dKdmIyd2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVldZWFZzZENCamNtVmhkR1ZRY205d2IzTmhiQ0JoY0hCeWIzWmxVSEp2Y0c5ellXd0tJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qUTFDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUW1saGRHVmpWbUYxYkhRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdJQ1ltSUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdjSFZ6YUdsdWRDQXhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFtbGhkR1ZqVm1GMWJIUXVZM0psWVhSbFZtRjFiSFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZXWVhWc2REb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVGtLSUNBZ0lDOHZJSEIxWW14cFl5QmpjbVZoZEdWV1lYVnNkQ2gyWVhWc2RFNWhiV1U2SUdGeVl6UXVVM1J5TENCemFXZHVZWFJ2Y2tkeWIzVndUbUZ0WlRvZ1lYSmpOQzVUZEhJcE9pQmhjbU0wTGtKdmIyd2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lORGNLSUNBZ0lDOHZJSEIxWW14cFl5QjJZWFZzZEhNZ1BTQkNiM2hOWVhBOFlYSmpOQzVUZEhJc0lHRnlZelF1VldsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0ozWW5JSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbllpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWXdDaUFnSUNBdkx5QmhjM05sY25Rb0lYUm9hWE11ZG1GMWJIUnpLSFpoZFd4MFRtRnRaU2t1WlhocGMzUnpMQ0FuVm1GMWJIUWdZV3h5WldGa2VTQmxlR2x6ZEhNbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCV1lYVnNkQ0JoYkhKbFlXUjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKcFlYUmxZMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTJNUW9nSUNBZ0x5OGdkR2hwY3k1MllYVnNkSE1vZG1GMWJIUk9ZVzFsS1M1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2d4S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qSXRNalkxQ2lBZ0lDQXZMeUJqYjI1emRDQjJZWFZzZEZOcFoyNWhkRzl5UjNKdmRYQTZJRlpoZFd4MFUybG5ibUYwYjNKSGNtOTFjQ0E5SUhzS0lDQWdJQzh2SUNBZ2RtRjFiSFE2SUhaaGRXeDBUbUZ0WlN3S0lDQWdJQzh2SUNBZ2MybG5ibUYwYjNKSGNtOTFjRTVoYldVNklITnBaMjVoZEc5eVIzSnZkWEJPWVcxbExBb2dJQ0FnTHk4Z2ZRb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklEUUtJQ0FnSUdScFp5QXlDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01EUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKcFlYUmxZMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNNQW9nSUNBZ0x5OGdjMmxuYm1WeVFXUmtjbVZ6Y3pvZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qY3RNamN4Q2lBZ0lDQXZMeUJqYjI1emRDQjJZWFZzZEZOcFoyNWxja0ZrWkhKbGMzTTZJRlpoZFd4MFUybG5ibVZ5UVdSa2NtVnpjeUE5SUhzS0lDQWdJQzh2SUNBZ2RtRjFiSFE2SUhaaGRXeDBUbUZ0WlN3S0lDQWdJQzh2SUNBZ2MybG5ibUYwYjNKSGNtOTFjRTVoYldVNklITnBaMjVoZEc5eVIzSnZkWEJPWVcxbExBb2dJQ0FnTHk4Z0lDQnphV2R1WlhKQlpHUnlaWE56T2lCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z2ZRb2dJQ0FnY0hWemFHbHVkQ0F6TmlBdkx5QXpOZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3TWpRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5EZ0tJQ0FnSUM4dklIQjFZbXhwWXlCemFXZHVZWFJ2Y2tkeWIzVndJRDBnUW05NFRXRndQRlpoZFd4MFUybG5ibUYwYjNKSGNtOTFjQ3dnVTJsbmJtRjBiM0pIY205MWNGTjBjblZqZEQ0b2V5QnJaWGxRY21WbWFYZzZJQ2R6SnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWN5SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qY3pMVEk0TUFvZ0lDQWdMeThnZEdocGN5NXphV2R1WVhSdmNrZHliM1Z3S0haaGRXeDBVMmxuYm1GMGIzSkhjbTkxY0NrdWRtRnNkV1VnUFNCN0NpQWdJQ0F2THlBZ0lIUm9jbVZ6YUc5c1pFTnZkVzUwT2lCdVpYY2dZWEpqTkM1VmFXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lHRmpZMjkxYm5SelEyOTFiblE2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ2MzQmxibVJwYm1kTWFXMXBkRUZ0YjNWdWREb2dibVYzSUdGeVl6UXVWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0J6Y0dWdVpHbHVaMHhwYldsMFFYTnpaWFE2SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ2MzQmxibVJwYm1kTWFXMXBkRVIxY21GMGFXOXVPaUJ1WlhjZ1lYSmpOQzVWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUdselFXUnRhVzQ2SUc1bGR5QmhjbU0wTGtKdmIyd29kSEoxWlNrc0NpQWdJQ0F2THlCOUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURnd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalE1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMmxuYm1WeWMwRmtaSEpsYzNNZ1BTQkNiM2hOWVhBOFZtRjFiSFJUYVdkdVpYSkJaR1J5WlhOekxDQmhjbU0wTGtKdmIydytLSHNnYTJWNVVISmxabWw0T2lBblV5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU56a0tJQ0FnSUM4dklHbHpRV1J0YVc0NklHNWxkeUJoY21NMExrSnZiMndvZEhKMVpTa3NDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRPREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0RFS0lDQWdJQzh2SUhSb2FYTXVjMmxuYm1WeWMwRmtaSEpsYzNNb2RtRjFiSFJUYVdkdVpYSkJaR1J5WlhOektTNTJZV3gxWlNBOUlHNWxkeUJoY21NMExrSnZiMndvZEhKMVpTa0tJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlRrS0lDQWdJQzh2SUhCMVlteHBZeUJqY21WaGRHVldZWFZzZENoMllYVnNkRTVoYldVNklHRnlZelF1VTNSeUxDQnphV2R1WVhSdmNrZHliM1Z3VG1GdFpUb2dZWEpqTkM1VGRISXBPaUJoY21NMExrSnZiMndnZXdvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURFMU1XWTNZemMxT0RBS0lDQWdJR3h2WndvZ0lDQWdjSFZ6YUdsdWRDQXhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFtbGhkR1ZqVm1GMWJIUXVZM0psWVhSbFVISnZjRzl6WVd4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdWUWNtOXdiM05oYkRvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmtkWEJ1SURZS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaSFZ3YmlBeU1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKcFlYUmxZMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTVNZ29nSUNBZ0x5OGdjSFZpYkdsaklHTnlaV0YwWlZCeWIzQnZjMkZzS0hCeWIzQnZjMkZzT2lCUWNtOXdiM05oYkZOMGNuVmpkQ3dnY0hKdmNHOWxjbE5wWjI1aGRHOXlSM0p2ZFhCT1lXMWxPaUJoY21NMExsTjBjaWs2SUdGeVl6UXVRbTl2YkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBNU1DQXZMeUE1TUFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0F3SUc5bUlDZ29iR1Z1SzNWMFpqaGJYU2tzZFdsdWREWTBMQ2hzWlc0cmRYUm1PRnRkS1N3b2JHVnVLM1YwWmpoYlhTa3NkV2x1ZERZMExDaHNaVzRyZFhSbU9GdGRLU3gxYVc1ME9Gc3pNbDBzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTENoMWFXNTBOalFzS0d4bGJpc29iR1Z1SzNWMFpqaGJYU2xiWFNrc0tHeGxiaXNvS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwTmpRc0tHeGxiaXQxYVc1ME9GdGRLU3dvYkdWdUszVnBiblE0VzEwcExIVnBiblEyTkNsYlhTa3NLR3hsYmlzb0tHeGxiaXQxYVc1ME9GdGRLU3gxYVc1ME5qUXNkV2x1ZERZMExDaHNaVzRyZFdsdWREaGJYU2tzS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwTmpRcFcxMHBMQ2hzWlc0cktDaHNaVzRyZFdsdWREaGJYU2tzZFdsdWREWTBMQ2hzWlc0cmRXbHVkRGhiWFNrc2RXbHVkRFkwTEhWcGJuUTJOQ3dvS0d4bGJpc29iR1Z1SzNWcGJuUTRXMTBwVzEwcEtTd29LR3hsYmlzb2JHVnVLM1ZwYm5RNFcxMHBXMTBwS1N3b0tHeGxiaXQxYVc1ME5qUmJYU2twTENnb2JHVnVLM1ZwYm5RMk5GdGRLU2twVzEwcExDaHNaVzRyS0hWcGJuUTRXek15WFN4MWFXNTBPRnN6TWwwc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNZbTl2YkRFc2RXbHVkRGhiTmpSZEtWdGRLU2twQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURNS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRGt5SUM4dklEa3lDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHpJQzh2SURFd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElESWdiMllnS0Noc1pXNHJkWFJtT0Z0ZEtTeDFhVzUwTmpRc0tHeGxiaXQxZEdZNFcxMHBMQ2hzWlc0cmRYUm1PRnRkS1N4MWFXNTBOalFzS0d4bGJpdDFkR1k0VzEwcExIVnBiblE0V3pNeVhTeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNLSFZwYm5RMk5Dd29iR1Z1S3loc1pXNHJkWFJtT0Z0ZEtWdGRLU3dvYkdWdUt5Z29iR1Z1SzNWcGJuUTRXMTBwTEhWcGJuUTJOQ3dvYkdWdUszVnBiblE0VzEwcExDaHNaVzRyZFdsdWREaGJYU2tzZFdsdWREWTBLVnRkS1N3b2JHVnVLeWdvYkdWdUszVnBiblE0VzEwcExIVnBiblEyTkN4MWFXNTBOalFzS0d4bGJpdDFhVzUwT0Z0ZEtTd29iR1Z1SzNWcGJuUTRXMTBwTEhWcGJuUTJOQ2xiWFNrc0tHeGxiaXNvS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwTmpRc0tHeGxiaXQxYVc1ME9GdGRLU3gxYVc1ME5qUXNkV2x1ZERZMExDZ29iR1Z1S3loc1pXNHJkV2x1ZERoYlhTbGJYU2twTENnb2JHVnVLeWhzWlc0cmRXbHVkRGhiWFNsYlhTa3BMQ2dvYkdWdUszVnBiblEyTkZ0ZEtTa3NLQ2hzWlc0cmRXbHVkRFkwVzEwcEtTbGJYU2tzS0d4bGJpc29kV2x1ZERoYk16SmRMSFZwYm5RNFd6TXlYU3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4aWIyOXNNU3gxYVc1ME9GczJORjBwVzEwcEtTa0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dOQW9nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXhNaUF2THlBeE1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXpJRzltSUNnb2JHVnVLM1YwWmpoYlhTa3NkV2x1ZERZMExDaHNaVzRyZFhSbU9GdGRLU3dvYkdWdUszVjBaamhiWFNrc2RXbHVkRFkwTENoc1pXNHJkWFJtT0Z0ZEtTeDFhVzUwT0Zzek1sMHNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMQ2gxYVc1ME5qUXNLR3hsYmlzb2JHVnVLM1YwWmpoYlhTbGJYU2tzS0d4bGJpc29LR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFzS0d4bGJpdDFhVzUwT0Z0ZEtTd29iR1Z1SzNWcGJuUTRXMTBwTEhWcGJuUTJOQ2xiWFNrc0tHeGxiaXNvS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwTmpRc2RXbHVkRFkwTENoc1pXNHJkV2x1ZERoYlhTa3NLR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFwVzEwcExDaHNaVzRyS0Noc1pXNHJkV2x1ZERoYlhTa3NkV2x1ZERZMExDaHNaVzRyZFdsdWREaGJYU2tzZFdsdWREWTBMSFZwYm5RMk5Dd29LR3hsYmlzb2JHVnVLM1ZwYm5RNFcxMHBXMTBwS1N3b0tHeGxiaXNvYkdWdUszVnBiblE0VzEwcFcxMHBLU3dvS0d4bGJpdDFhVzUwTmpSYlhTa3BMQ2dvYkdWdUszVnBiblEyTkZ0ZEtTa3BXMTBwTENoc1pXNHJLSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiREVzZFdsdWREaGJOalJkS1Z0ZEtTa3BDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JRFFLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdNaklnTHk4Z01qSUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dOU0J2WmlBb0tHeGxiaXQxZEdZNFcxMHBMSFZwYm5RMk5Dd29iR1Z1SzNWMFpqaGJYU2tzS0d4bGJpdDFkR1k0VzEwcExIVnBiblEyTkN3b2JHVnVLM1YwWmpoYlhTa3NkV2x1ZERoYk16SmRMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3dvZFdsdWREWTBMQ2hzWlc0cktHeGxiaXQxZEdZNFcxMHBXMTBwTENoc1pXNHJLQ2hzWlc0cmRXbHVkRGhiWFNrc2RXbHVkRFkwTENoc1pXNHJkV2x1ZERoYlhTa3NLR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFwVzEwcExDaHNaVzRyS0Noc1pXNHJkV2x1ZERoYlhTa3NkV2x1ZERZMExIVnBiblEyTkN3b2JHVnVLM1ZwYm5RNFcxMHBMQ2hzWlc0cmRXbHVkRGhiWFNrc2RXbHVkRFkwS1Z0ZEtTd29iR1Z1S3lnb2JHVnVLM1ZwYm5RNFcxMHBMSFZwYm5RMk5Dd29iR1Z1SzNWcGJuUTRXMTBwTEhWcGJuUTJOQ3gxYVc1ME5qUXNLQ2hzWlc0cktHeGxiaXQxYVc1ME9GdGRLVnRkS1Nrc0tDaHNaVzRyS0d4bGJpdDFhVzUwT0Z0ZEtWdGRLU2tzS0Noc1pXNHJkV2x1ZERZMFcxMHBLU3dvS0d4bGJpdDFhVzUwTmpSYlhTa3BLVnRkS1N3b2JHVnVLeWgxYVc1ME9Gc3pNbDBzZFdsdWREaGJNekpkTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExHSnZiMnd4TEhWcGJuUTRXelkwWFNsYlhTa3BLUW9nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnT0RnZ0x5OGdPRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElERXhJRzltSUNnb2JHVnVLM1YwWmpoYlhTa3NkV2x1ZERZMExDaHNaVzRyZFhSbU9GdGRLU3dvYkdWdUszVjBaamhiWFNrc2RXbHVkRFkwTENoc1pXNHJkWFJtT0Z0ZEtTeDFhVzUwT0Zzek1sMHNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMQ2gxYVc1ME5qUXNLR3hsYmlzb2JHVnVLM1YwWmpoYlhTbGJYU2tzS0d4bGJpc29LR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFzS0d4bGJpdDFhVzUwT0Z0ZEtTd29iR1Z1SzNWcGJuUTRXMTBwTEhWcGJuUTJOQ2xiWFNrc0tHeGxiaXNvS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwTmpRc2RXbHVkRFkwTENoc1pXNHJkV2x1ZERoYlhTa3NLR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFwVzEwcExDaHNaVzRyS0Noc1pXNHJkV2x1ZERoYlhTa3NkV2x1ZERZMExDaHNaVzRyZFdsdWREaGJYU2tzZFdsdWREWTBMSFZwYm5RMk5Dd29LR3hsYmlzb2JHVnVLM1ZwYm5RNFcxMHBXMTBwS1N3b0tHeGxiaXNvYkdWdUszVnBiblE0VzEwcFcxMHBLU3dvS0d4bGJpdDFhVzUwTmpSYlhTa3BMQ2dvYkdWdUszVnBiblEyTkZ0ZEtTa3BXMTBwTENoc1pXNHJLSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiREVzZFdsdWREaGJOalJkS1Z0ZEtTa3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUjFjRzRnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhPQ0F2THlBeE9Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeElHOW1JQ2gxYVc1ME5qUXNLR3hsYmlzb2JHVnVLM1YwWmpoYlhTbGJYU2tzS0d4bGJpc29LR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFzS0d4bGJpdDFhVzUwT0Z0ZEtTd29iR1Z1SzNWcGJuUTRXMTBwTEhWcGJuUTJOQ2xiWFNrc0tHeGxiaXNvS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwTmpRc2RXbHVkRFkwTENoc1pXNHJkV2x1ZERoYlhTa3NLR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFwVzEwcExDaHNaVzRyS0Noc1pXNHJkV2x1ZERoYlhTa3NkV2x1ZERZMExDaHNaVzRyZFdsdWREaGJYU2tzZFdsdWREWTBMSFZwYm5RMk5Dd29LR3hsYmlzb2JHVnVLM1ZwYm5RNFcxMHBXMTBwS1N3b0tHeGxiaXNvYkdWdUszVnBiblE0VzEwcFcxMHBLU3dvS0d4bGJpdDFhVzUwTmpSYlhTa3BMQ2dvYkdWdUszVnBiblEyTkZ0ZEtTa3BXMTBwTENoc1pXNHJLSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiREVzZFdsdWREaGJOalJkS1Z0ZEtTa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLZ29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NncGpjbVZoZEdWUWNtOXdiM05oYkY5bWIzSmZhR1ZoWkdWeVFERTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamt5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZM0psWVhSbFVISnZjRzl6WVd3b2NISnZjRzl6WVd3NklGQnliM0J2YzJGc1UzUnlkV04wTENCd2NtOXdiMlZ5VTJsbmJtRjBiM0pIY205MWNFNWhiV1U2SUdGeVl6UXVVM1J5S1RvZ1lYSmpOQzVDYjI5c0lIc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEUUtJQ0FnSUR3S0lDQWdJR0o2SUdOeVpXRjBaVkJ5YjNCdmMyRnNYMkZtZEdWeVgyWnZja0EwQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCa2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1ptOXlJQ2hzWlc0cktHeGxiaXQxZEdZNFcxMHBXMTBwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUNzS0lDQWdJR0oxY25rZ05Bb2dJQ0FnY0hWemFHbHVkQ0F4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCamNtVmhkR1ZRY205d2IzTmhiRjltYjNKZmFHVmhaR1Z5UURFS0NtTnlaV0YwWlZCeWIzQnZjMkZzWDJGbWRHVnlYMlp2Y2tBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKcFlYUmxZMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTVNZ29nSUNBZ0x5OGdjSFZpYkdsaklHTnlaV0YwWlZCeWIzQnZjMkZzS0hCeWIzQnZjMkZzT2lCUWNtOXdiM05oYkZOMGNuVmpkQ3dnY0hKdmNHOWxjbE5wWjI1aGRHOXlSM0p2ZFhCT1lXMWxPaUJoY21NMExsTjBjaWs2SUdGeVl6UXVRbTl2YkNCN0NpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0F5TUNBdkx5QXlNQW9nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlETXlDaUFnSUNCa2FXY2dOZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBeUlHOW1JQ2gxYVc1ME5qUXNLR3hsYmlzb2JHVnVLM1YwWmpoYlhTbGJYU2tzS0d4bGJpc29LR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFzS0d4bGJpdDFhVzUwT0Z0ZEtTd29iR1Z1SzNWcGJuUTRXMTBwTEhWcGJuUTJOQ2xiWFNrc0tHeGxiaXNvS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwTmpRc2RXbHVkRFkwTENoc1pXNHJkV2x1ZERoYlhTa3NLR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFwVzEwcExDaHNaVzRyS0Noc1pXNHJkV2x1ZERoYlhTa3NkV2x1ZERZMExDaHNaVzRyZFdsdWREaGJYU2tzZFdsdWREWTBMSFZwYm5RMk5Dd29LR3hsYmlzb2JHVnVLM1ZwYm5RNFcxMHBXMTBwS1N3b0tHeGxiaXNvYkdWdUszVnBiblE0VzEwcFcxMHBLU3dvS0d4bGJpdDFhVzUwTmpSYlhTa3BMQ2dvYkdWdUszVnBiblEyTkZ0ZEtTa3BXMTBwTENoc1pXNHJLSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiREVzZFdsdWREaGJOalJkS1Z0ZEtTa0tJQ0FnSUdScFp5QTJDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNamdLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBcUNpQWdJQ0JpZFhKNUlESXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5WeWVTQTBNUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKMWNua2dNalVLQ21OeVpXRjBaVkJ5YjNCdmMyRnNYMlp2Y2w5b1pXRmtaWEpBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9USUtJQ0FnSUM4dklIQjFZbXhwWXlCamNtVmhkR1ZRY205d2IzTmhiQ2h3Y205d2IzTmhiRG9nVUhKdmNHOXpZV3hUZEhKMVkzUXNJSEJ5YjNCdlpYSlRhV2R1WVhSdmNrZHliM1Z3VG1GdFpUb2dZWEpqTkM1VGRISXBPaUJoY21NMExrSnZiMndnZXdvZ0lDQWdaR2xuSURJMENpQWdJQ0JrYVdjZ01qWUtJQ0FnSUR3S0lDQWdJR0o2SUdOeVpXRjBaVkJ5YjNCdmMyRnNYMkZtZEdWeVgyWnZja0E0Q2lBZ0lDQmthV2NnTWpRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDb0tJQ0FnSUdScFp5QTBNZ29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeU13b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHWnZjaUFvYkdWdUt5Z29iR1Z1SzNWcGJuUTRXMTBwTEhWcGJuUTJOQ3dvYkdWdUszVnBiblE0VzEwcExDaHNaVzRyZFdsdWREaGJYU2tzZFdsdWREWTBLVnRkS1FvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5TWlBdkx5QXlNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXdJRzltSUNnb2JHVnVLM1ZwYm5RNFcxMHBMSFZwYm5RMk5Dd29iR1Z1SzNWcGJuUTRXMTBwTENoc1pXNHJkV2x1ZERoYlhTa3NkV2x1ZERZMEtRb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeU5DQXZMeUF5TkFvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTXlBdkx5QXhNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dNaUJ2WmlBb0tHeGxiaXQxYVc1ME9GdGRLU3gxYVc1ME5qUXNLR3hsYml0MWFXNTBPRnRkS1N3b2JHVnVLM1ZwYm5RNFcxMHBMSFZwYm5RMk5Da0tJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNd29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0FyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQXhNaUF2THlBeE1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ015QnZaaUFvS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwTmpRc0tHeGxiaXQxYVc1ME9GdGRLU3dvYkdWdUszVnBiblE0VzEwcExIVnBiblEyTkNrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lDc0tJQ0FnSUNzS0lDQWdJR0oxY25rZ01qRUtJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlESTFDaUFnSUNCaUlHTnlaV0YwWlZCeWIzQnZjMkZzWDJadmNsOW9aV0ZrWlhKQU5Rb0tZM0psWVhSbFVISnZjRzl6WVd4ZllXWjBaWEpmWm05eVFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamt5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZM0psWVhSbFVISnZjRzl6WVd3b2NISnZjRzl6WVd3NklGQnliM0J2YzJGc1UzUnlkV04wTENCd2NtOXdiMlZ5VTJsbmJtRjBiM0pIY205MWNFNWhiV1U2SUdGeVl6UXVVM1J5S1RvZ1lYSmpOQzVDYjI5c0lIc0tJQ0FnSUdScFp5QXhPUW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBek1Rb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURNMkNpQWdJQ0JrYVdjZ05nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCd2RYTm9hVzUwSURFeUlDOHZJREV5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ015QnZaaUFvZFdsdWREWTBMQ2hzWlc0cktHeGxiaXQxZEdZNFcxMHBXMTBwTENoc1pXNHJLQ2hzWlc0cmRXbHVkRGhiWFNrc2RXbHVkRFkwTENoc1pXNHJkV2x1ZERoYlhTa3NLR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFwVzEwcExDaHNaVzRyS0Noc1pXNHJkV2x1ZERoYlhTa3NkV2x1ZERZMExIVnBiblEyTkN3b2JHVnVLM1ZwYm5RNFcxMHBMQ2hzWlc0cmRXbHVkRGhiWFNrc2RXbHVkRFkwS1Z0ZEtTd29iR1Z1S3lnb2JHVnVLM1ZwYm5RNFcxMHBMSFZwYm5RMk5Dd29iR1Z1SzNWcGJuUTRXMTBwTEhWcGJuUTJOQ3gxYVc1ME5qUXNLQ2hzWlc0cktHeGxiaXQxYVc1ME9GdGRLVnRkS1Nrc0tDaHNaVzRyS0d4bGJpdDFhVzUwT0Z0ZEtWdGRLU2tzS0Noc1pXNHJkV2x1ZERZMFcxMHBLU3dvS0d4bGJpdDFhVzUwTmpSYlhTa3BLVnRkS1N3b2JHVnVLeWgxYVc1ME9Gc3pNbDBzZFdsdWREaGJNekpkTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExHSnZiMnd4TEhWcGJuUTRXelkwWFNsYlhTa3BDaUFnSUNCa2FXY2dOZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRE15Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWW5WeWVTQXlNQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKMWNua2dOREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWRYSjVJREkwQ2dwamNtVmhkR1ZRY205d2IzTmhiRjltYjNKZmFHVmhaR1Z5UURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa3lDaUFnSUNBdkx5QndkV0pzYVdNZ1kzSmxZWFJsVUhKdmNHOXpZV3dvY0hKdmNHOXpZV3c2SUZCeWIzQnZjMkZzVTNSeWRXTjBMQ0J3Y205d2IyVnlVMmxuYm1GMGIzSkhjbTkxY0U1aGJXVTZJR0Z5WXpRdVUzUnlLVG9nWVhKak5DNUNiMjlzSUhzS0lDQWdJR1JwWnlBeU13b2dJQ0FnWkdsbklETXdDaUFnSUNBOENpQWdJQ0JpZWlCamNtVmhkR1ZRY205d2IzTmhiRjloWm5SbGNsOW1iM0pBTVRJS0lDQWdJR1JwWnlBeU13b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JRFF4Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2daVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdabTl5SUNoc1pXNHJLQ2hzWlc0cmRXbHVkRGhiWFNrc2RXbHVkRFkwTEhWcGJuUTJOQ3dvYkdWdUszVnBiblE0VzEwcExDaHNaVzRyZFdsdWREaGJYU2tzZFdsdWREWTBLVnRkS1FvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F6TUNBdkx5QXpNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXdJRzltSUNnb2JHVnVLM1ZwYm5RNFcxMHBMSFZwYm5RMk5DeDFhVzUwTmpRc0tHeGxiaXQxYVc1ME9GdGRLU3dvYkdWdUszVnBiblE0VzEwcExIVnBiblEyTkNrS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lDc0tJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURFNElDOHZJREU0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0F6SUc5bUlDZ29iR1Z1SzNWcGJuUTRXMTBwTEhWcGJuUTJOQ3gxYVc1ME5qUXNLR3hsYml0MWFXNTBPRnRkS1N3b2JHVnVLM1ZwYm5RNFcxMHBMSFZwYm5RMk5Da0tJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNd29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0FyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQXlNQ0F2THlBeU1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ05DQnZaaUFvS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwTmpRc2RXbHVkRFkwTENoc1pXNHJkV2x1ZERoYlhTa3NLR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNBckNpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURJd0NpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeU5Bb2dJQ0FnWWlCamNtVmhkR1ZRY205d2IzTmhiRjltYjNKZmFHVmhaR1Z5UURrS0NtTnlaV0YwWlZCeWIzQnZjMkZzWDJGbWRHVnlYMlp2Y2tBeE1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPVElLSUNBZ0lDOHZJSEIxWW14cFl5QmpjbVZoZEdWUWNtOXdiM05oYkNod2NtOXdiM05oYkRvZ1VISnZjRzl6WVd4VGRISjFZM1FzSUhCeWIzQnZaWEpUYVdkdVlYUnZja2R5YjNWd1RtRnRaVG9nWVhKak5DNVRkSElwT2lCaGNtTTBMa0p2YjJ3Z2V3b2dJQ0FnWkdsbklERTRDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURNMUNpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTXpVS0lDQWdJR1JwWnlBMkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhCMWMyaHBiblFnTVRRZ0x5OGdNVFFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBMElHOW1JQ2gxYVc1ME5qUXNLR3hsYmlzb2JHVnVLM1YwWmpoYlhTbGJYU2tzS0d4bGJpc29LR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFzS0d4bGJpdDFhVzUwT0Z0ZEtTd29iR1Z1SzNWcGJuUTRXMTBwTEhWcGJuUTJOQ2xiWFNrc0tHeGxiaXNvS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwTmpRc2RXbHVkRFkwTENoc1pXNHJkV2x1ZERoYlhTa3NLR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFwVzEwcExDaHNaVzRyS0Noc1pXNHJkV2x1ZERoYlhTa3NkV2x1ZERZMExDaHNaVzRyZFdsdWREaGJYU2tzZFdsdWREWTBMSFZwYm5RMk5Dd29LR3hsYmlzb2JHVnVLM1ZwYm5RNFcxMHBXMTBwS1N3b0tHeGxiaXNvYkdWdUszVnBiblE0VzEwcFcxMHBLU3dvS0d4bGJpdDFhVzUwTmpSYlhTa3BMQ2dvYkdWdUszVnBiblEyTkZ0ZEtTa3BXMTBwTENoc1pXNHJLSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1ltOXZiREVzZFdsdWREaGJOalJkS1Z0ZEtTa0tJQ0FnSUdScFp5QTJDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNekVLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBcUNpQWdJQ0JpZFhKNUlERTVDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5WeWVTQXpPUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKMWNua2dNak1LQ21OeVpXRjBaVkJ5YjNCdmMyRnNYMlp2Y2w5b1pXRmtaWEpBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa3lDaUFnSUNBdkx5QndkV0pzYVdNZ1kzSmxZWFJsVUhKdmNHOXpZV3dvY0hKdmNHOXpZV3c2SUZCeWIzQnZjMkZzVTNSeWRXTjBMQ0J3Y205d2IyVnlVMmxuYm1GMGIzSkhjbTkxY0U1aGJXVTZJR0Z5WXpRdVUzUnlLVG9nWVhKak5DNUNiMjlzSUhzS0lDQWdJR1JwWnlBeU1nb2dJQ0FnWkdsbklESTVDaUFnSUNBOENpQWdJQ0JpZWlCamNtVmhkR1ZRY205d2IzTmhiRjloWm5SbGNsOW1iM0pBTWpRS0lDQWdJR1JwWnlBeU1nb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF6T1FvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQm1iM0lnS0d4bGJpc29LR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFzS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwTmpRc2RXbHVkRFkwTENnb2JHVnVLeWhzWlc0cmRXbHVkRGhiWFNsYlhTa3BMQ2dvYkdWdUt5aHNaVzRyZFdsdWREaGJYU2xiWFNrcExDZ29iR1Z1SzNWcGJuUTJORnRkS1Nrc0tDaHNaVzRyZFdsdWREWTBXMTBwS1NsYlhTa0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBek53b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW5WeWVTQXhOd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F6TmlBdkx5QXpOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXdJRzltSUNnb2JHVnVLM1ZwYm5RNFcxMHBMSFZwYm5RMk5Dd29iR1Z1SzNWcGJuUTRXMTBwTEhWcGJuUTJOQ3gxYVc1ME5qUXNLQ2hzWlc0cktHeGxiaXQxYVc1ME9GdGRLVnRkS1Nrc0tDaHNaVzRyS0d4bGJpdDFhVzUwT0Z0ZEtWdGRLU2tzS0Noc1pXNHJkV2x1ZERZMFcxMHBLU3dvS0d4bGJpdDFhVzUwTmpSYlhTa3BLUW9nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXpPQ0F2THlBek9Bb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk15QXZMeUF4TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTWlCdlppQW9LR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFzS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwTmpRc2RXbHVkRFkwTENnb2JHVnVLeWhzWlc0cmRXbHVkRGhiWFNsYlhTa3BMQ2dvYkdWdUt5aHNaVzRyZFdsdWREaGJYU2xiWFNrcExDZ29iR1Z1SzNWcGJuUTJORnRkS1Nrc0tDaHNaVzRyZFdsdWREWTBXMTBwS1NrS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNellLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElESTRJQzh2SURJNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdZWFFnYVc1a1pYZ2dOU0J2WmlBb0tHeGxiaXQxYVc1ME9GdGRLU3gxYVc1ME5qUXNLR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFzZFdsdWREWTBMQ2dvYkdWdUt5aHNaVzRyZFdsdWREaGJYU2xiWFNrcExDZ29iR1Z1S3loc1pXNHJkV2x1ZERoYlhTbGJYU2twTENnb2JHVnVLM1ZwYm5RMk5GdGRLU2tzS0Noc1pXNHJkV2x1ZERZMFcxMHBLU2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01DQnZaaUFvS0d4bGJpc29iR1Z1SzNWcGJuUTRXMTBwVzEwcEtRb2dJQ0FnYzNkaGNBb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlETXdDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdZblZ5ZVNBeE9Bb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0oxY25rZ016Z0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZFhKNUlESXlDZ3BqY21WaGRHVlFjbTl3YjNOaGJGOW1iM0pmYUdWaFpHVnlRREUxT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNU1nb2dJQ0FnTHk4Z2NIVmliR2xqSUdOeVpXRjBaVkJ5YjNCdmMyRnNLSEJ5YjNCdmMyRnNPaUJRY205d2IzTmhiRk4wY25WamRDd2djSEp2Y0c5bGNsTnBaMjVoZEc5eVIzSnZkWEJPWVcxbE9pQmhjbU0wTGxOMGNpazZJR0Z5WXpRdVFtOXZiQ0I3Q2lBZ0lDQmthV2NnTWpFS0lDQWdJR1JwWnlBeU9Bb2dJQ0FnUEFvZ0lDQWdZbm9nWTNKbFlYUmxVSEp2Y0c5ellXeGZZV1owWlhKZlptOXlRREU0Q2lBZ0lDQmthV2NnTWpFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDb0tJQ0FnSUdScFp5QXpPUW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHWnZjaUFvYkdWdUt5aHNaVzRyZFdsdWREaGJYU2xiWFNrS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhPQW9nSUNBZ2NIVnphR2x1ZENBeElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNaklLSUNBZ0lHSWdZM0psWVhSbFVISnZjRzl6WVd4ZlptOXlYMmhsWVdSbGNrQXhOUW9LWTNKbFlYUmxVSEp2Y0c5ellXeGZZV1owWlhKZlptOXlRREU0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNU1nb2dJQ0FnTHk4Z2NIVmliR2xqSUdOeVpXRjBaVkJ5YjNCdmMyRnNLSEJ5YjNCdmMyRnNPaUJRY205d2IzTmhiRk4wY25WamRDd2djSEp2Y0c5bGNsTnBaMjVoZEc5eVIzSnZkWEJPWVcxbE9pQmhjbU0wTGxOMGNpazZJR0Z5WXpRdVFtOXZiQ0I3Q2lBZ0lDQmthV2NnTVRZS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlBMENpQWdJQ0FyQ2lBZ0lDQmthV2NnTXpNS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F6TXdvZ0lDQWdaR2xuSURNMkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhCMWMyaHBiblFnTXpBZ0x5OGdNekFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSFJoYVd3Z2NHOXBiblJsY2lCaGRDQnBibVJsZUNBMklHOW1JQ2dvYkdWdUszVnBiblE0VzEwcExIVnBiblEyTkN3b2JHVnVLM1ZwYm5RNFcxMHBMSFZwYm5RMk5DeDFhVzUwTmpRc0tDaHNaVzRyS0d4bGJpdDFhVzUwT0Z0ZEtWdGRLU2tzS0Noc1pXNHJLR3hsYml0MWFXNTBPRnRkS1Z0ZEtTa3NLQ2hzWlc0cmRXbHVkRFkwVzEwcEtTd29LR3hsYml0MWFXNTBOalJiWFNrcEtRb2dJQ0FnWkdsbklERTJDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXdJRzltSUNnb2JHVnVLeWhzWlc0cmRXbHVkRGhiWFNsYlhTa3BDaUFnSUNCemQyRndDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNamtLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBcUNpQWdJQ0JpZFhKNUlERTNDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5WeWVTQXpOd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKMWNua2dNakVLQ21OeVpXRjBaVkJ5YjNCdmMyRnNYMlp2Y2w5b1pXRmtaWEpBTVRrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa3lDaUFnSUNBdkx5QndkV0pzYVdNZ1kzSmxZWFJsVUhKdmNHOXpZV3dvY0hKdmNHOXpZV3c2SUZCeWIzQnZjMkZzVTNSeWRXTjBMQ0J3Y205d2IyVnlVMmxuYm1GMGIzSkhjbTkxY0U1aGJXVTZJR0Z5WXpRdVUzUnlLVG9nWVhKak5DNUNiMjlzSUhzS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnWkdsbklESTNDaUFnSUNBOENpQWdJQ0JpZWlCamNtVmhkR1ZRY205d2IzTmhiRjloWm5SbGNsOW1iM0pBTWpJS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JRE00Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2daVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklERTVDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdabTl5SUNoc1pXNHJLR3hsYml0MWFXNTBPRnRkS1Z0ZEtRb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQXJDaUFnSUNCaWRYSjVJREUzQ2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F5TVFvZ0lDQWdZaUJqY21WaGRHVlFjbTl3YjNOaGJGOW1iM0pmYUdWaFpHVnlRREU1Q2dwamNtVmhkR1ZRY205d2IzTmhiRjloWm5SbGNsOW1iM0pBTWpJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa3lDaUFnSUNBdkx5QndkV0pzYVdNZ1kzSmxZWFJsVUhKdmNHOXpZV3dvY0hKdmNHOXpZV3c2SUZCeWIzQnZjMkZzVTNSeWRXTjBMQ0J3Y205d2IyVnlVMmxuYm1GMGIzSkhjbTkxY0U1aGJXVTZJR0Z5WXpRdVUzUnlLVG9nWVhKak5DNUNiMjlzSUhzS0lDQWdJR1JwWnlBeE5Rb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklEUUtJQ0FnSUNzS0lDQWdJR1JwWnlBek1nb2dJQ0FnS3dvZ0lDQWdaR2xuSURNMkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJRGNnYjJZZ0tDaHNaVzRyZFdsdWREaGJYU2tzZFdsdWREWTBMQ2hzWlc0cmRXbHVkRGhiWFNrc2RXbHVkRFkwTEhWcGJuUTJOQ3dvS0d4bGJpc29iR1Z1SzNWcGJuUTRXMTBwVzEwcEtTd29LR3hsYmlzb2JHVnVLM1ZwYm5RNFcxMHBXMTBwS1N3b0tHeGxiaXQxYVc1ME5qUmJYU2twTENnb2JHVnVLM1ZwYm5RMk5GdGRLU2twQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFNENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEVUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElEQWdiMllnS0Noc1pXNHJkV2x1ZERZMFcxMHBLUW9nSUNBZ2MzZGhjQW9nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBcUNpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z05Bb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ016UWdMeThnTXpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURnZ2IyWWdLQ2hzWlc0cmRXbHVkRGhiWFNrc2RXbHVkRFkwTENoc1pXNHJkV2x1ZERoYlhTa3NkV2x1ZERZMExIVnBiblEyTkN3b0tHeGxiaXNvYkdWdUszVnBiblE0VzEwcFcxMHBLU3dvS0d4bGJpc29iR1Z1SzNWcGJuUTRXMTBwVzEwcEtTd29LR3hsYml0MWFXNTBOalJiWFNrcExDZ29iR1Z1SzNWcGJuUTJORnRkS1NrcENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ2RIVndiR1VnWlc1amIyUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01DQnZaaUFvS0d4bGJpdDFhVzUwTmpSYlhTa3BDaUFnSUNCemQyRndDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlBMENpQWdJQ0FyQ2lBZ0lDQXJDaUFnSUNCa2FXY2dNVGdLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNVGdLSUNBZ0lHUnBaeUF5TWdvZ0lDQWdjSFZ6YUdsdWRDQXhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTWpNS0lDQWdJR0lnWTNKbFlYUmxVSEp2Y0c5ellXeGZabTl5WDJobFlXUmxja0F4TXdvS1kzSmxZWFJsVUhKdmNHOXpZV3hmWVdaMFpYSmZabTl5UURJME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKcFlYUmxZMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTVNZ29nSUNBZ0x5OGdjSFZpYkdsaklHTnlaV0YwWlZCeWIzQnZjMkZzS0hCeWIzQnZjMkZzT2lCUWNtOXdiM05oYkZOMGNuVmpkQ3dnY0hKdmNHOWxjbE5wWjI1aGRHOXlSM0p2ZFhCT1lXMWxPaUJoY21NMExsTjBjaWs2SUdGeVl6UXVRbTl2YkNCN0NpQWdJQ0JrYVdjZ01UY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTXpRS0lDQWdJQ3NLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSEIxYzJocGJuUWdNVFlnTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHRjBJR2x1WkdWNElEVWdiMllnS0hWcGJuUTJOQ3dvYkdWdUt5aHNaVzRyZFhSbU9GdGRLVnRkS1N3b2JHVnVLeWdvYkdWdUszVnBiblE0VzEwcExIVnBiblEyTkN3b2JHVnVLM1ZwYm5RNFcxMHBMQ2hzWlc0cmRXbHVkRGhiWFNrc2RXbHVkRFkwS1Z0ZEtTd29iR1Z1S3lnb2JHVnVLM1ZwYm5RNFcxMHBMSFZwYm5RMk5DeDFhVzUwTmpRc0tHeGxiaXQxYVc1ME9GdGRLU3dvYkdWdUszVnBiblE0VzEwcExIVnBiblEyTkNsYlhTa3NLR3hsYmlzb0tHeGxiaXQxYVc1ME9GdGRLU3gxYVc1ME5qUXNLR3hsYml0MWFXNTBPRnRkS1N4MWFXNTBOalFzZFdsdWREWTBMQ2dvYkdWdUt5aHNaVzRyZFdsdWREaGJYU2xiWFNrcExDZ29iR1Z1S3loc1pXNHJkV2x1ZERoYlhTbGJYU2twTENnb2JHVnVLM1ZwYm5RMk5GdGRLU2tzS0Noc1pXNHJkV2x1ZERZMFcxMHBLU2xiWFNrc0tHeGxiaXNvZFdsdWREaGJNekpkTEhWcGJuUTRXek15WFN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGliMjlzTVN4MWFXNTBPRnMyTkYwcFcxMHBLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ053b2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTWdOQ0F2THlBeE5UTUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNBckNpQWdJQ0JrYVdjZ09Bb2dJQ0FnS3dvZ0lDQWdaR2xuSURFekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJQWW1wbFkzUXpNVGczTWprMk9Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNU5Rb2dJQ0FnTHk4Z2RtRjFiSFE2SUhCeWIzQnZjMkZzTG5aaGRXeDBMQW9nSUNBZ1pHbG5JREUwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF4TXdvZ0lDQWdaR2xuSURFekNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9UWUtJQ0FnSUM4dklITnBaMjVoZEc5eVIzSnZkWEJPWVcxbE9pQndjbTl3YjNOaGJDNXphV2R1WVhSdmNrZHliM1Z3VG1GdFpTd0tJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1JwWnlBeE13b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTJDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qazBMVEk1TndvZ0lDQWdMeThnWTI5dWMzUWdkbUYxYkhSVGFXZHVZWFJ2Y2tkeWIzVndPaUJXWVhWc2RGTnBaMjVoZEc5eVIzSnZkWEFnUFNCN0NpQWdJQ0F2THlBZ0lIWmhkV3gwT2lCd2NtOXdiM05oYkM1MllYVnNkQ3dLSUNBZ0lDOHZJQ0FnYzJsbmJtRjBiM0pIY205MWNFNWhiV1U2SUhCeWIzQnZjMkZzTG5OcFoyNWhkRzl5UjNKdmRYQk9ZVzFsTEFvZ0lDQWdMeThnZlFvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SURRS0lDQWdJR1JwWnlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3TURRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKcFlYUmxZMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTBPQW9nSUNBZ0x5OGdjSFZpYkdsaklITnBaMjVoZEc5eVIzSnZkWEFnUFNCQ2IzaE5ZWEE4Vm1GMWJIUlRhV2R1WVhSdmNrZHliM1Z3TENCVGFXZHVZWFJ2Y2tkeWIzVndVM1J5ZFdOMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjNNbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprNENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXphV2R1WVhSdmNrZHliM1Z3S0haaGRXeDBVMmxuYm1GMGIzSkhjbTkxY0NrdVpYaHBjM1J6TENBblQyNXNlU0J6YVdkdVpYSnpJR05oYmlCamNtVmhkR1VnY0hKdmNHOXpZV3h6SnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J6YVdkdVpYSnpJR05oYmlCamNtVmhkR1VnY0hKdmNHOXpZV3h6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWprNUNpQWdJQ0F2THlCaGMzTmxjblFvY0hKdmNHOXpZV3d1YzJsbmJtRjBkWEpsYzBOdmRXNTBMbUZ6VldsdWREWTBLQ2tnUFQwOUlEQXNJQ2RPWlhjZ2NISnZjRzl6WVd3Z2JYVnpkQ0JvWVhabElEQWdjMmxuYm1GMGRYSmxjeUJqYjNWdWRDY3BDaUFnSUNCa2FXY2dOQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVG1WM0lIQnliM0J2YzJGc0lHMTFjM1FnYUdGMlpTQXdJSE5wWjI1aGRIVnlaWE1nWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNRE1LSUNBZ0lDOHZJSFJvYVhNdWMybG5ibUYwYjNKSGNtOTFjQ2gyWVhWc2RGTnBaMjVoZEc5eVIzSnZkWEFwTG5aaGJIVmxMbWx6UVdSdGFXNHVibUYwYVhabExBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCd2RYTm9hVzUwSURNeU1DQXZMeUF6TWpBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1ESXRNekExQ2lBZ0lDQXZMeUJoYzNObGNuUW9DaUFnSUNBdkx5QWdJSFJvYVhNdWMybG5ibUYwYjNKSGNtOTFjQ2gyWVhWc2RGTnBaMjVoZEc5eVIzSnZkWEFwTG5aaGJIVmxMbWx6UVdSdGFXNHVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQW5UMjVzZVNCaFpHMXBiaUJ6YVdkdVpYSnpJR05oYmlCamNtVmhkR1VnWVdSa0lITnBaMjVoZEc5eUlIQnliM0J2YzJGc2N5Y3NDaUFnSUNBdkx5QXBDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JoWkcxcGJpQnphV2R1WlhKeklHTmhiaUJqY21WaGRHVWdZV1JrSUhOcFoyNWhkRzl5SUhCeWIzQnZjMkZzY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd09DMHpNVEVLSUNBZ0lDOHZJR052Ym5OMElIQnliM0J2YzJWeVZtRjFiSFJUYVdkdVlYUnZja2R5YjNWd09pQldZWFZzZEZOcFoyNWhkRzl5UjNKdmRYQWdQU0I3Q2lBZ0lDQXZMeUFnSUhaaGRXeDBPaUJ3Y205d2IzTmhiQzUyWVhWc2RDd0tJQ0FnSUM4dklDQWdjMmxuYm1GMGIzSkhjbTkxY0U1aGJXVTZJSEJ5YjNCdlpYSlRhV2R1WVhSdmNrZHliM1Z3VG1GdFpTd0tJQ0FnSUM4dklIMEtJQ0FnSUdScFp5QTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkRnS0lDQWdJQzh2SUhCMVlteHBZeUJ6YVdkdVlYUnZja2R5YjNWd0lEMGdRbTk0VFdGd1BGWmhkV3gwVTJsbmJtRjBiM0pIY205MWNDd2dVMmxuYm1GMGIzSkhjbTkxY0ZOMGNuVmpkRDRvZXlCclpYbFFjbVZtYVhnNklDZHpKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKcFlYUmxZMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhNd29nSUNBZ0x5OGdkR2hwY3k1emFXZHVZWFJ2Y2tkeWIzVndLSEJ5YjNCdmMyVnlWbUYxYkhSVGFXZHVZWFJ2Y2tkeWIzVndLUzVsZUdsemRITXNDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1USXRNekUxQ2lBZ0lDQXZMeUJoYzNObGNuUW9DaUFnSUNBdkx5QWdJSFJvYVhNdWMybG5ibUYwYjNKSGNtOTFjQ2h3Y205d2IzTmxjbFpoZFd4MFUybG5ibUYwYjNKSGNtOTFjQ2t1WlhocGMzUnpMQW9nSUNBZ0x5OGdJQ0FuVDI1c2VTQjJZV3hwWkNCemFXZHVZWFJ2Y25NZ2QybDBhQ0IyWVd4cFpDQnphV2R1WVhSdmNpQm5jbTkxY0NCallXNGdjSEp2Y0c5elpTQjBhR1VnWTJoaGJtZGxKeXdLSUNBZ0lDOHZJQ2tLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUhaaGJHbGtJSE5wWjI1aGRHOXljeUIzYVhSb0lIWmhiR2xrSUhOcFoyNWhkRzl5SUdkeWIzVndJR05oYmlCd2NtOXdiM05sSUhSb1pTQmphR0Z1WjJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1qQUtJQ0FnSUM4dklITnBaMjVsY2tGa1pISmxjM002SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpFM0xUTXlNUW9nSUNBZ0x5OGdZMjl1YzNRZ2NISnZjRzl6WlhKV1lYVnNkRk5wWjI1bGNrRmtaSEpsYzNNNklGWmhkV3gwVTJsbmJtVnlRV1JrY21WemN5QTlJSHNLSUNBZ0lDOHZJQ0FnZG1GMWJIUTZJSEJ5YjNCdmMyRnNMblpoZFd4MExBb2dJQ0FnTHk4Z0lDQnphV2R1WVhSdmNrZHliM1Z3VG1GdFpUb2djSEp2Y0c5bGNsTnBaMjVoZEc5eVIzSnZkWEJPWVcxbExBb2dJQ0FnTHk4Z0lDQnphV2R1WlhKQlpHUnlaWE56T2lCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z2ZRb2dJQ0FnY0hWemFHbHVkQ0F6TmlBdkx5QXpOZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3TWpRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalE1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMmxuYm1WeWMwRmtaSEpsYzNNZ1BTQkNiM2hOWVhBOFZtRjFiSFJUYVdkdVpYSkJaR1J5WlhOekxDQmhjbU0wTGtKdmIydytLSHNnYTJWNVVISmxabWw0T2lBblV5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1qSUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbk5wWjI1bGNuTkJaR1J5WlhOektIQnliM0J2YzJWeVZtRjFiSFJUYVdkdVpYSkJaR1J5WlhOektTNWxlR2x6ZEhNc0lDZFBibXg1SUhaaGJHbGtJSE5wWjI1aGRHOXljeUJqWVc0Z2NISnZjRzl6WlNCMGFHVWdZMmhoYm1kbEp5a0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2RtRnNhV1FnYzJsbmJtRjBiM0p6SUdOaGJpQndjbTl3YjNObElIUm9aU0JqYUdGdVoyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNalVLSUNBZ0lDOHZJR2xtSUNod2NtOXdiM05oYkM1d2NtOXdiM05oYkZSNWNHVWdQVDA5SUVGa1pGTnBaMjVoZEc5eVVISnZjRzl6WVd4VWVYQmxLU0I3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnT0FvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFF6Q2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TURBd1l6WXhOalEyTkRKa056TTJPVFkzTm1VMk1UYzBObVkzTWdvZ0lDQWdQVDBLSUNBZ0lHSjZJR055WldGMFpWQnliM0J2YzJGc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWpjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1qWUtJQ0FnSUM4dklHRnpjMlZ5ZENod2NtOXdiM05oYkM1amFHRnVaMlZrVTJsbmJtRjBiM0lnSVQwOUlHNWxkeUJoY21NMExrRmtaSEpsYzNNb0tTd2dKMEZrWkNCemFXZHVZWFJ2Y2lCd2NtOXdiM05oYkNCdGRYTjBJR2hoZG1VZ1kyaGhibWRsWkZOcFoyNWhkRzl5SUdacFpXeGtKeWtLSUNBZ0lHUnBaeUF4TXdvZ0lDQWdaWGgwY21GamRDQXlOQ0F6TWdvZ0lDQWdZbmwwWldNZ09TQXZMeUJoWkdSeUlFRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGWk5VaEdTMUVLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1FXUmtJSE5wWjI1aGRHOXlJSEJ5YjNCdmMyRnNJRzExYzNRZ2FHRjJaU0JqYUdGdVoyVmtVMmxuYm1GMGIzSWdabWxsYkdRS0NtTnlaV0YwWlZCeWIzQnZjMkZzWDJGbWRHVnlYMmxtWDJWc2MyVkFNamM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJNENpQWdJQ0F2THlCcFppQW9jSEp2Y0c5ellXd3VjSEp2Y0c5ellXeFVlWEJsSUQwOVBTQlNaVzF2ZG1WVGFXZHVZWFJ2Y2xCeWIzQnZjMkZzVkhsd1pTa2dld29nSUNBZ1pHbG5JRFF4Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUF3ZURBd01HWTNNalkxTm1RMlpqYzJOalV5WkRjek5qazJOelpsTmpFM05EWm1OeklLSUNBZ0lEMDlDaUFnSUNCaWVpQmpjbVZoZEdWUWNtOXdiM05oYkY5aFpuUmxjbDlwWmw5bGJITmxRREk1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpNd0NpQWdJQ0F2THlCd2NtOXdiM05oYkM1amFHRnVaMlZrVTJsbmJtRjBiM0lnSVQwOUlHNWxkeUJoY21NMExrRmtaSEpsYzNNb0tTd0tJQ0FnSUdScFp5QXhNd29nSUNBZ1pYaDBjbUZqZENBeU5DQXpNZ29nSUNBZ1lubDBaV01nT1NBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUNFOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16STVMVE16TWdvZ0lDQWdMeThnWVhOelpYSjBLQW9nSUNBZ0x5OGdJQ0J3Y205d2IzTmhiQzVqYUdGdVoyVmtVMmxuYm1GMGIzSWdJVDA5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vS1N3S0lDQWdJQzh2SUNBZ0oxSmxiVzkyWlNCemFXZHVZWFJ2Y2lCd2NtOXdiM05oYkNCdGRYTjBJR2hoZG1VZ1kyaGhibWRsWkZOcFoyNWhkRzl5SUdacFpXeGtKeXdLSUNBZ0lDOHZJQ2tLSUNBZ0lHRnpjMlZ5ZENBdkx5QlNaVzF2ZG1VZ2MybG5ibUYwYjNJZ2NISnZjRzl6WVd3Z2JYVnpkQ0JvWVhabElHTm9ZVzVuWldSVGFXZHVZWFJ2Y2lCbWFXVnNaQW9LWTNKbFlYUmxVSEp2Y0c5ellXeGZZV1owWlhKZmFXWmZaV3h6WlVBeU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNelFLSUNBZ0lDOHZJR2xtSUNod2NtOXdiM05oYkM1d2NtOXdiM05oYkZSNWNHVWdQVDA5SUVOb1lXNW5aVlJvY21WemFHOXNaRkJ5YjNCdmMyRnNWSGx3WlNrZ2V3b2dJQ0FnWkdsbklEUXhDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QXdlREF3TVRBMk16WTROakUyWlRZM05qVXlaRGMwTmpnM01qWTFOek0yT0RabU5tTTJOQW9nSUNBZ1BUMEtJQ0FnSUdKNklHTnlaV0YwWlZCeWIzQnZjMkZzWDJGbWRHVnlYMmxtWDJWc2MyVkFNekVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TXpZS0lDQWdJQzh2SUhCeWIzQnZjMkZzTG1Ob1lXNW5aV1JVYUhKbGMyaHZiR1FnSVQwOUlHNWxkeUJoY21NMExsVnBiblEyTkNnd0tTd0tJQ0FnSUdScFp5QXhNd29nSUNBZ1pYaDBjbUZqZENBMU5pQTRDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUNFOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TTFMVE16T0FvZ0lDQWdMeThnWVhOelpYSjBLQW9nSUNBZ0x5OGdJQ0J3Y205d2IzTmhiQzVqYUdGdVoyVmtWR2h5WlhOb2IyeGtJQ0U5UFNCdVpYY2dZWEpqTkM1VmFXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDZERhR0Z1WjJVZ2RHaHlaWE5vYjJ4a0lIQnliM0J2YzJGc0lHMTFjM1FnYUdGMlpTQmphR0Z1WjJWa1ZHaHlaWE5vYjJ4a0lHWnBaV3hrSnl3S0lDQWdJQzh2SUNrS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYUdGdVoyVWdkR2h5WlhOb2IyeGtJSEJ5YjNCdmMyRnNJRzExYzNRZ2FHRjJaU0JqYUdGdVoyVmtWR2h5WlhOb2IyeGtJR1pwWld4a0NncGpjbVZoZEdWUWNtOXdiM05oYkY5aFpuUmxjbDlwWmw5bGJITmxRRE14T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNME1Bb2dJQ0FnTHk4Z2FXWWdLSEJ5YjNCdmMyRnNMbkJ5YjNCdmMyRnNWSGx3WlNBOVBUMGdRMmhoYm1kbFUzQmxibVJwYm1kTWFXMXBkRkJ5YjNCdmMyRnNWSGx3WlNrZ2V3b2dJQ0FnWkdsbklEUXhDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QXdlREF3TVRVMk16WTROakUyWlRZM05qVXlaRGN6TnpBMk5UWmxOalEyT1RabE5qY3laRFpqTmprMlpEWTVOelFLSUNBZ0lEMDlDaUFnSUNCaWVpQmpjbVZoZEdWUWNtOXdiM05oYkY5aFpuUmxjbDlwWmw5bGJITmxRRE0xQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpReUNpQWdJQ0F2THlCcFppQW9jSEp2Y0c5ellXd3VZMmhoYm1kbFpGTndaVzVrYVc1blRHbHRhWFJCYlc5MWJuUXVZWE5WYVc1ME5qUW9LU0ErSURBcElIc0tJQ0FnSUdScFp5QXhNd29nSUNBZ2NIVnphR2x1ZENBM01pQXZMeUEzTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0o2SUdOeVpXRjBaVkJ5YjNCdmMyRnNYMkZtZEdWeVgybG1YMlZzYzJWQU16VUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pORFFLSUNBZ0lDOHZJSEJ5YjNCdmMyRnNMbU5vWVc1blpXUlRjR1Z1WkdsdVoweHBiV2wwUkhWeVlYUnBiMjRnSVQwOUlHNWxkeUJoY21NMExsVnBiblEyTkNnd0tTd0tJQ0FnSUdScFp5QXhNd29nSUNBZ1pYaDBjbUZqZENBNE1DQTRDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUNFOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UXpMVE0wTmdvZ0lDQWdMeThnWVhOelpYSjBLQW9nSUNBZ0x5OGdJQ0J3Y205d2IzTmhiQzVqYUdGdVoyVmtVM0JsYm1ScGJtZE1hVzFwZEVSMWNtRjBhVzl1SUNFOVBTQnVaWGNnWVhKak5DNVZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ2REYUdGdVoyVWdjM0JsYm1ScGJtY2diR2x0YVhRZ2NISnZjRzl6WVd3Z2JYVnpkQ0JvWVhabElHTm9ZVzVuWldSVGNHVnVaR2x1WjB4cGJXbDBSSFZ5WVhScGIyNGdabWxsYkdRZ2QyaGxiaUJqYUdGdVoyVmtVM0JsYm1ScGJtZE1hVzFwZEVGdGIzVnVkQ0JwY3lCbmNtVmhkR1Z5SUhSb1lXNGdNQ2NzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRMmhoYm1kbElITndaVzVrYVc1bklHeHBiV2wwSUhCeWIzQnZjMkZzSUcxMWMzUWdhR0YyWlNCamFHRnVaMlZrVTNCbGJtUnBibWRNYVcxcGRFUjFjbUYwYVc5dUlHWnBaV3hrSUhkb1pXNGdZMmhoYm1kbFpGTndaVzVrYVc1blRHbHRhWFJCYlc5MWJuUWdhWE1nWjNKbFlYUmxjaUIwYUdGdUlEQUtDbU55WldGMFpWQnliM0J2YzJGc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXpVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VXdDaUFnSUNBdkx5QmhjM05sY25Rb0lYUm9hWE11Y0hKdmNHOXpZV3h6S0hCeWIzQnZjMkZzTG5CeWIzQnZjMkZzU1dRcExtVjRhWE4wY3l3Z0oxQnliM0J2YzJGc0lIZHBkR2dnZEdobElITmhiV1VnYVdRZ1lXeHlaV0ZrZVNCbGVHbHpkSE1uS1FvZ0lDQWdaR2xuSURFekNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBeE13b2dJQ0FnWkdsbklERXpDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qVXhDaUFnSUNBdkx5QndkV0pzYVdNZ2NISnZjRzl6WVd4eklEMGdRbTk0VFdGd1BHRnlZelF1VTNSeUxDQlFjbTl3YjNOaGJGTjBjblZqZEQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RqSnlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKaklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelV3Q2lBZ0lDQXZMeUJoYzNObGNuUW9JWFJvYVhNdWNISnZjRzl6WVd4ektIQnliM0J2YzJGc0xuQnliM0J2YzJGc1NXUXBMbVY0YVhOMGN5d2dKMUJ5YjNCdmMyRnNJSGRwZEdnZ2RHaGxJSE5oYldVZ2FXUWdZV3h5WldGa2VTQmxlR2x6ZEhNbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUWNtOXdiM05oYkNCM2FYUm9JSFJvWlNCellXMWxJR2xrSUdGc2NtVmhaSGtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelV4Q2lBZ0lDQXZMeUIwYUdsekxuQnliM0J2YzJGc2N5aHdjbTl3YjNOaGJDNXdjbTl3YjNOaGJFbGtLUzUyWVd4MVpTQTlJR05zYjI1bEtIQnliM0J2YzJGc0tRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T1RJS0lDQWdJQzh2SUhCMVlteHBZeUJqY21WaGRHVlFjbTl3YjNOaGJDaHdjbTl3YjNOaGJEb2dVSEp2Y0c5ellXeFRkSEoxWTNRc0lIQnliM0J2WlhKVGFXZHVZWFJ2Y2tkeWIzVndUbUZ0WlRvZ1lYSmpOQzVUZEhJcE9pQmhjbU0wTGtKdmIyd2dld29nSUNBZ1lubDBaV01nTnlBdkx5QXdlREUxTVdZM1l6YzFPREFLSUNBZ0lHeHZad29nSUNBZ2NIVnphR2x1ZENBeElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UW1saGRHVmpWbUYxYkhRdVlYQndjbTkyWlZCeWIzQnZjMkZzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYQndjbTkyWlZCeWIzQnZjMkZzT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEJ1SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5qSUtJQ0FnSUM4dklIQjFZbXhwWXlCaGNIQnliM1psVUhKdmNHOXpZV3dvY0hKdmNHOXpZV3hKWkRvZ1lYSmpOQzVUZEhJcE9pQmhjbU0wTGtKdmIyd2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKcFlYUmxZMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFNUW9nSUNBZ0x5OGdjSFZpYkdsaklIQnliM0J2YzJGc2N5QTlJRUp2ZUUxaGNEeGhjbU0wTGxOMGNpd2dVSEp2Y0c5ellXeFRkSEoxWTNRK0tIc2dhMlY1VUhKbFptbDRPaUFuWXljZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVl5SUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMk13b2dJQ0FnTHk4Z1kyOXVjM1FnY0hKdmNHOXpZV3dnUFNCamJHOXVaU2gwYUdsekxuQnliM0J2YzJGc2N5aHdjbTl3YjNOaGJFbGtLUzUyWVd4MVpTa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMk5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hCeWIzQnZjMkZzTG5aaGJHbGtWVzUwYVd4VWFXMWxMbUZ6VldsdWREWTBLQ2tnUENCSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdMQ0FuVUhKdmNHOXpZV3dnYVhNZ1pYaHdhWEpsWkNjcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVFFnTHk4Z01UUUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklGQnliM0J2YzJGc0lHbHpJR1Y0Y0dseVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOamtLSUNBZ0lDOHZJSFpoZFd4ME9pQndjbTl3YjNOaGJDNTJZWFZzZEN3S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnTVRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0F4TWlBdkx5QXhNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdScFp5QXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TnpBS0lDQWdJQzh2SUhOcFoyNWhkRzl5UjNKdmRYQk9ZVzFsT2lCd2NtOXdiM05oYkM1emFXZHVZWFJ2Y2tkeWIzVndUbUZ0WlN3S0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJREl5SUM4dklESXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEyQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOTJaWElnTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMk9DMHpOekVLSUNBZ0lDOHZJR052Ym5OMElIWmhkV3gwVTJsbmJtRjBiM0pIY205MWNEb2dWbUYxYkhSVGFXZHVZWFJ2Y2tkeWIzVndJRDBnZXdvZ0lDQWdMeThnSUNCMllYVnNkRG9nY0hKdmNHOXpZV3d1ZG1GMWJIUXNDaUFnSUNBdkx5QWdJSE5wWjI1aGRHOXlSM0p2ZFhCT1lXMWxPaUJ3Y205d2IzTmhiQzV6YVdkdVlYUnZja2R5YjNWd1RtRnRaU3dLSUNBZ0lDOHZJSDBLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUEwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkRnS0lDQWdJQzh2SUhCMVlteHBZeUJ6YVdkdVlYUnZja2R5YjNWd0lEMGdRbTk0VFdGd1BGWmhkV3gwVTJsbmJtRjBiM0pIY205MWNDd2dVMmxuYm1GMGIzSkhjbTkxY0ZOMGNuVmpkRDRvZXlCclpYbFFjbVZtYVhnNklDZHpKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemN5Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1emFXZHVZWFJ2Y2tkeWIzVndLSFpoZFd4MFUybG5ibUYwYjNKSGNtOTFjQ2t1WlhocGMzUnpMQ0FuVDI1c2VTQnphV2R1WVhSdmNuTWdZMkZ1SUdGd2NISnZkbVVnY0hKdmNHOXpZV3h6SnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J6YVdkdVlYUnZjbk1nWTJGdUlHRndjSEp2ZG1VZ2NISnZjRzl6WVd4ekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16YzRDaUFnSUNBdkx5QnphV2R1WlhKQlpHUnlaWE56T2lCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNM05TMHpOemtLSUNBZ0lDOHZJR052Ym5OMElHRndjSEp2ZG1WeVZtRjFiSFJUYVdkdVpYSkJaR1J5WlhOek9pQldZWFZzZEZOcFoyNWxja0ZrWkhKbGMzTWdQU0I3Q2lBZ0lDQXZMeUFnSUhaaGRXeDBPaUJ3Y205d2IzTmhiQzUyWVhWc2RDd0tJQ0FnSUM4dklDQWdjMmxuYm1GMGIzSkhjbTkxY0U1aGJXVTZJSEJ5YjNCdmMyRnNMbk5wWjI1aGRHOXlSM0p2ZFhCT1lXMWxMQW9nSUNBZ0x5OGdJQ0J6YVdkdVpYSkJaR1J5WlhOek9pQnVaWGNnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdmUW9nSUNBZ2NIVnphR2x1ZENBek5pQXZMeUF6TmdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBd01qUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnBZWFJsWTE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwT1FvZ0lDQWdMeThnY0hWaWJHbGpJSE5wWjI1bGNuTkJaR1J5WlhOeklEMGdRbTk0VFdGd1BGWmhkV3gwVTJsbmJtVnlRV1JrY21WemN5d2dZWEpqTkM1Q2IyOXNQaWg3SUd0bGVWQnlaV1pwZURvZ0oxTW5JSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pUSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16Z3dDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV6YVdkdVpYSnpRV1JrY21WemN5aGhjSEJ5YjNabGNsWmhkV3gwVTJsbmJtVnlRV1JrY21WemN5a3VaWGhwYzNSekxDQW5UMjVzZVNCMllXeHBaQ0J6YVdkdVlYUnZjbk1nWTJGdUlHRndjSEp2ZG1VZ2RHaGxJR05vWVc1blpTY3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2RtRnNhV1FnYzJsbmJtRjBiM0p6SUdOaGJpQmhjSEJ5YjNabElIUm9aU0JqYUdGdVoyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPRElLSUNBZ0lDOHZJSFJvYVhNdWMybG5ibVZ5YzBGa1pISmxjM01vWVhCd2NtOTJaWEpXWVhWc2RGTnBaMjVsY2tGa1pISmxjM01wTG5aaGJIVmxMbTVoZEdsMlpTd0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnBZWFJsWTE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00TVMwek9EUUtJQ0FnSUM4dklHRnpjMlZ5ZENnS0lDQWdJQzh2SUNBZ2RHaHBjeTV6YVdkdVpYSnpRV1JrY21WemN5aGhjSEJ5YjNabGNsWmhkV3gwVTJsbmJtVnlRV1JrY21WemN5a3VkbUZzZFdVdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBblQyNXNlU0JoWTNScGRtVWdkbUZzYVdRZ2MybG5ibUYwYjNKeklHTmhiaUJoY0hCeWIzWmxJSFJvWlNCamFHRnVaMlVuTEFvZ0lDQWdMeThnS1FvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1lXTjBhWFpsSUhaaGJHbGtJSE5wWjI1aGRHOXljeUJqWVc0Z1lYQndjbTkyWlNCMGFHVWdZMmhoYm1kbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16ZzJMVE00T1FvZ0lDQWdMeThnWTI5dWMzUWdZWEJ3Y205MlpYSlhhWFJvVUhKdmNHOXpZV3hKWkRvZ1FYQndjbTkyWlhKWGFYUm9VSEp3YjNOaGJFbGtJRDBnZXdvZ0lDQWdMeThnSUNCd2NtOXdiM05oYkVsa09pQndjbTl3YjNOaGJFbGtMQW9nSUNBZ0x5OGdJQ0JoY0hCeWIzWmxja0ZrWkhKbGMzTTZJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUI5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURJeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16ZzRDaUFnSUNBdkx5QmhjSEJ5YjNabGNrRmtaSEpsYzNNNklHNWxkeUJoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16ZzJMVE00T1FvZ0lDQWdMeThnWTI5dWMzUWdZWEJ3Y205MlpYSlhhWFJvVUhKdmNHOXpZV3hKWkRvZ1FYQndjbTkyWlhKWGFYUm9VSEp3YjNOaGJFbGtJRDBnZXdvZ0lDQWdMeThnSUNCd2NtOXdiM05oYkVsa09pQndjbTl3YjNOaGJFbGtMQW9nSUNBZ0x5OGdJQ0JoY0hCeWIzWmxja0ZrWkhKbGMzTTZJRzVsZHlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUI5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVeUNpQWdJQ0F2THlCd2RXSnNhV01nY0hKdmNHOXpZV3hCY0hCeWIzWmhiSE1nUFNCQ2IzaE5ZWEE4UVhCd2NtOTJaWEpYYVhSb1VISndiM05oYkVsa0xDQmhjbU0wTGxWcGJuUTJORDRvZXlCclpYbFFjbVZtYVhnNklDZHdKeUI5S1NBdkx5QndjbTl3YjNOaGJDQnBaQ0F0UGlCdWRXMWlaWElnYjJZZ1lYQndjbTkyWVd4ekNpQWdJQ0J3ZFhOb1lubDBaWE1nSW5BaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pPVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hkR2hwY3k1d2NtOXdiM05oYkVGd2NISnZkbUZzY3loaGNIQnliM1psY2xkcGRHaFFjbTl3YjNOaGJFbGtLUzVsZUdsemRITXNJQ2RCY0hCeWIzWmxjaUJqWVc0Z2IyNXNlU0J2Ym1ObElHRndjSEp2ZG1VZ2RHaGxJSEJ5YjNCdmMyRnNKeWtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRWEJ3Y205MlpYSWdZMkZ1SUc5dWJIa2diMjVqWlNCaGNIQnliM1psSUhSb1pTQndjbTl3YjNOaGJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKcFlYUmxZMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTVNZ29nSUNBZ0x5OGdkR2hwY3k1d2NtOXdiM05oYkVGd2NISnZkbUZzY3loaGNIQnliM1psY2xkcGRHaFFjbTl3YjNOaGJFbGtLUzUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ3hLUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01ERUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T1RNS0lDQWdJQzh2SUdOdmJuTjBJRzVsZDFOcFoyNWhkSFZ5WlhORGIzVnVkQ0E5SUc1bGR5QmhjbU0wTGxWcGJuUTJOQ2h3Y205d2IzTmhiQzV6YVdkdVlYUjFjbVZ6UTI5MWJuUXVZWE5WYVc1ME5qUW9LU0FySURFcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ2NIVnphR2x1ZENBeElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKcFlYUmxZMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTVOQW9nSUNBZ0x5OGdkR2hwY3k1d2NtOXdiM05oYkhNb2NISnZjRzl6WVd4SlpDa3VkbUZzZFdVdWMybG5ibUYwZFhKbGMwTnZkVzUwSUQwZ2JtVjNVMmxuYm1GMGRYSmxjME52ZFc1MENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXprMUNpQWdJQ0F2THlCcFppQW9ibVYzVTJsbmJtRjBkWEpsYzBOdmRXNTBMbUZ6VldsdWREWTBLQ2tnUGowZ2RHaHBjeTV6YVdkdVlYUnZja2R5YjNWd0tIWmhkV3gwVTJsbmJtRjBiM0pIY205MWNDa3VkbUZzZFdVdWRHaHlaWE5vYjJ4a1EyOTFiblF1WVhOVmFXNTBOalFvS1NrZ2V3b2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUQ0OUNpQWdJQ0JpZWlCaGNIQnliM1psVUhKdmNHOXpZV3hmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREEwQ2lBZ0lDQXZMeUJwWmlBb2NISnZjRzl6WVd3dWNISnZjRzl6WVd4VWVYQmxJRDA5UFNCQlpHUlRhV2R1WVhSdmNsQnliM0J2YzJGc1ZIbHdaU2tnZXdvZ0lDQWdaR2xuSURVS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTRPQ0F2THlBNE9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhOQW9nSUNBZ1pHbG5JRFVLSUNBZ0lITjNZWEFLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhOZ29nSUNBZ1lubDBaV01nT0NBdkx5QXdlREF3TUdNMk1UWTBOalF5WkRjek5qazJOelpsTmpFM05EWm1OeklLSUNBZ0lEMDlDaUFnSUNCaWVpQmhjSEJ5YjNabFVISnZjRzl6WVd4ZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRBNENpQWdJQ0F2THlCemFXZHVaWEpCWkdSeVpYTnpPaUJ3Y205d2IzTmhiQzVqYUdGdVoyVmtVMmxuYm1GMGIzSXNDaUFnSUNCa2FXY2dOZ29nSUNBZ2NIVnphR2x1ZEhNZ01qUWdNeklnTHk4Z01qUXNJRE15Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnBZWFJsWTE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF3TlMwME1Ea0tJQ0FnSUM4dklHTnZibk4wSUc1bGQxTnBaMjVsY2tGa1pISmxjM002SUZaaGRXeDBVMmxuYm1WeVFXUmtjbVZ6Y3lBOUlIc0tJQ0FnSUM4dklDQWdkbUYxYkhRNklIQnliM0J2YzJGc0xuWmhkV3gwTEFvZ0lDQWdMeThnSUNCemFXZHVZWFJ2Y2tkeWIzVndUbUZ0WlRvZ2NISnZjRzl6WVd3dWMybG5ibUYwYjNKSGNtOTFjRTVoYldVc0NpQWdJQ0F2THlBZ0lITnBaMjVsY2tGa1pISmxjM002SUhCeWIzQnZjMkZzTG1Ob1lXNW5aV1JUYVdkdVlYUnZjaXdLSUNBZ0lDOHZJSDBLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVRBS0lDQWdJQzh2SUhSb2FYTXVjMmxuYm1WeWMwRmtaSEpsYzNNb2JtVjNVMmxuYm1WeVFXUmtjbVZ6Y3lrdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1Q2IyOXNLSFJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE9EQUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lORGtLSUNBZ0lDOHZJSEIxWW14cFl5QnphV2R1WlhKelFXUmtjbVZ6Y3lBOUlFSnZlRTFoY0R4V1lYVnNkRk5wWjI1bGNrRmtaSEpsYzNNc0lHRnlZelF1UW05dmJENG9leUJyWlhsUWNtVm1hWGc2SUNkVEp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlVeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReE1Bb2dJQ0FnTHk4Z2RHaHBjeTV6YVdkdVpYSnpRV1JrY21WemN5aHVaWGRUYVdkdVpYSkJaR1J5WlhOektTNTJZV3gxWlNBOUlHNWxkeUJoY21NMExrSnZiMndvZEhKMVpTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzRNQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReE5nb2dJQ0FnTHk4Z2RHaHBjeTV6YVdkdVlYUnZja2R5YjNWd0tIWmhkV3gwVTJsbmJtRjBiM0pIY205MWNDa3VkbUZzZFdVdVlXTmpiM1Z1ZEhORGIzVnVkQzVoYzFWcGJuUTJOQ2dwSUNzZ01Td0tJQ0FnSUdScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ERTFMVFF4TndvZ0lDQWdMeThnZEdocGN5NXphV2R1WVhSdmNrZHliM1Z3S0haaGRXeDBVMmxuYm1GMGIzSkhjbTkxY0NrdWRtRnNkV1V1WVdOamIzVnVkSE5EYjNWdWRDQTlJRzVsZHlCaGNtTTBMbFZwYm5RMk5DZ0tJQ0FnSUM4dklDQWdkR2hwY3k1emFXZHVZWFJ2Y2tkeWIzVndLSFpoZFd4MFUybG5ibUYwYjNKSGNtOTFjQ2t1ZG1Gc2RXVXVZV05qYjNWdWRITkRiM1Z1ZEM1aGMxVnBiblEyTkNncElDc2dNU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHbDBiMklLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb0tZWEJ3Y205MlpWQnliM0J2YzJGc1gyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQ2FXRjBaV05XWVhWc2RDNWhjSEJ5YjNabFVISnZjRzl6WVd4QU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOaklLSUNBZ0lDOHZJSEIxWW14cFl5QmhjSEJ5YjNabFVISnZjRzl6WVd3b2NISnZjRzl6WVd4SlpEb2dZWEpqTkM1VGRISXBPaUJoY21NMExrSnZiMndnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGhjSEJ5YjNabFVISnZjRzl6WVd4ZllXWjBaWEpmYVdaZlpXeHpaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReU1Bb2dJQ0FnTHk4Z2FXWWdLSEJ5YjNCdmMyRnNMbkJ5YjNCdmMyRnNWSGx3WlNBOVBUMGdVbVZ0YjNabFUybG5ibUYwYjNKUWNtOXdiM05oYkZSNWNHVXBJSHNLSUNBZ0lHUnBaeUF4TkFvZ0lDQWdZbmwwWldNZ01UQWdMeThnTUhnd01EQm1OekkyTlRaa05tWTNOalkxTW1RM016WTVOamMyWlRZeE56UTJaamN5Q2lBZ0lDQTlQUW9nSUNBZ1lub2dZWEJ3Y205MlpWQnliM0J2YzJGc1gyRm1kR1Z5WDJsbVgyVnNjMlZBT1FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReU5Bb2dJQ0FnTHk4Z2MybG5ibVZ5UVdSa2NtVnpjem9nY0hKdmNHOXpZV3d1WTJoaGJtZGxaRk5wWjI1aGRHOXlMQW9nSUNBZ1pHbG5JRFlLSUNBZ0lIQjFjMmhwYm5SeklESTBJRE15SUM4dklESTBMQ0F6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTWpFdE5ESTFDaUFnSUNBdkx5QmpiMjV6ZENCemFXZHVaWEpCWkdSeVpYTnpWRzlTWlcxdmRtVTZJRlpoZFd4MFUybG5ibVZ5UVdSa2NtVnpjeUE5SUhzS0lDQWdJQzh2SUNBZ2RtRjFiSFE2SUhCeWIzQnZjMkZzTG5aaGRXeDBMQW9nSUNBZ0x5OGdJQ0J6YVdkdVlYUnZja2R5YjNWd1RtRnRaVG9nY0hKdmNHOXpZV3d1YzJsbmJtRjBiM0pIY205MWNFNWhiV1VzQ2lBZ0lDQXZMeUFnSUhOcFoyNWxja0ZrWkhKbGMzTTZJSEJ5YjNCdmMyRnNMbU5vWVc1blpXUlRhV2R1WVhSdmNpd0tJQ0FnSUM4dklIMEtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lORGtLSUNBZ0lDOHZJSEIxWW14cFl5QnphV2R1WlhKelFXUmtjbVZ6Y3lBOUlFSnZlRTFoY0R4V1lYVnNkRk5wWjI1bGNrRmtaSEpsYzNNc0lHRnlZelF1UW05dmJENG9leUJyWlhsUWNtVm1hWGc2SUNkVEp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlVeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReU5nb2dJQ0FnTHk4Z2RHaHBjeTV6YVdkdVpYSnpRV1JrY21WemN5aHphV2R1WlhKQlpHUnlaWE56Vkc5U1pXMXZkbVVwTG5aaGJIVmxJRDBnYm1WM0lHRnlZelF1UW05dmJDaG1ZV3h6WlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Bb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnBZWFJsWTE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF6TWdvZ0lDQWdMeThnZEdocGN5NXphV2R1WVhSdmNrZHliM1Z3S0haaGRXeDBVMmxuYm1GMGIzSkhjbTkxY0NrdWRtRnNkV1V1WVdOamIzVnVkSE5EYjNWdWRDNWhjMVZwYm5RMk5DZ3BJQzBnTVN3S0lDQWdJR1JwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRNeExUUXpNd29nSUNBZ0x5OGdkR2hwY3k1emFXZHVZWFJ2Y2tkeWIzVndLSFpoZFd4MFUybG5ibUYwYjNKSGNtOTFjQ2t1ZG1Gc2RXVXVZV05qYjNWdWRITkRiM1Z1ZENBOUlHNWxkeUJoY21NMExsVnBiblEyTkNnS0lDQWdJQzh2SUNBZ2RHaHBjeTV6YVdkdVlYUnZja2R5YjNWd0tIWmhkV3gwVTJsbmJtRjBiM0pIY205MWNDa3VkbUZzZFdVdVlXTmpiM1Z1ZEhORGIzVnVkQzVoYzFWcGJuUTJOQ2dwSUMwZ01Td0tJQ0FnSUM4dklDa0tJQ0FnSUdsMGIySUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRek5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUc1bGR5QmhjbU0wTGtKdmIyd29kSEoxWlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnNE1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKcFlYUmxZMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJNZ29nSUNBZ0x5OGdjSFZpYkdsaklHRndjSEp2ZG1WUWNtOXdiM05oYkNod2NtOXdiM05oYkVsa09pQmhjbU0wTGxOMGNpazZJR0Z5WXpRdVFtOXZiQ0I3Q2lBZ0lDQmlJR0Z3Y0hKdmRtVlFjbTl3YjNOaGJGOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFtbGhkR1ZqVm1GMWJIUXVZWEJ3Y205MlpWQnliM0J2YzJGc1FEUUtDbUZ3Y0hKdmRtVlFjbTl3YjNOaGJGOWhablJsY2w5cFpsOWxiSE5sUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ETTJDaUFnSUNBdkx5QnBaaUFvY0hKdmNHOXpZV3d1Y0hKdmNHOXpZV3hVZVhCbElEMDlQU0JEYUdGdVoyVlVhSEpsYzJodmJHUlFjbTl3YjNOaGJGUjVjR1VwSUhzS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z01IZ3dNREV3TmpNMk9EWXhObVUyTnpZMU1tUTNORFk0TnpJMk5UY3pOamcyWmpaak5qUUtJQ0FnSUQwOUNpQWdJQ0JpZWlCaGNIQnliM1psVUhKdmNHOXpZV3hmWVdaMFpYSmZhV1pmWld4elpVQXhNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnBZWFJsWTE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEwTVFvZ0lDQWdMeThnZEdocGN5NXphV2R1WVhSdmNrZHliM1Z3S0haaGRXeDBVMmxuYm1GMGIzSkhjbTkxY0NrdWRtRnNkV1V1ZEdoeVpYTm9iMnhrUTI5MWJuUWdQU0J3Y205d2IzTmhiQzVqYUdGdVoyVmtWR2h5WlhOb2IyeGtDaUFnSUNCa2FXY2dOZ29nSUNBZ2NIVnphR2x1ZENBMU5pQXZMeUExTmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTkRJS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1lYSmpOQzVDYjI5c0tIUnlkV1VwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0T0RBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5qSUtJQ0FnSUM4dklIQjFZbXhwWXlCaGNIQnliM1psVUhKdmNHOXpZV3dvY0hKdmNHOXpZV3hKWkRvZ1lYSmpOQzVUZEhJcE9pQmhjbU0wTGtKdmIyd2dld29nSUNBZ1lpQmhjSEJ5YjNabFVISnZjRzl6WVd4ZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tKcFlYUmxZMVpoZFd4MExtRndjSEp2ZG1WUWNtOXdiM05oYkVBMENncGhjSEJ5YjNabFVISnZjRzl6WVd4ZllXWjBaWEpmYVdaZlpXeHpaVUF4TVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5EUUtJQ0FnSUM4dklHbG1JQ2h3Y205d2IzTmhiQzV3Y205d2IzTmhiRlI1Y0dVZ1BUMDlJRU5vWVc1blpWTndaVzVrYVc1blRHbHRhWFJRY205d2IzTmhiRlI1Y0dVcElIc0tJQ0FnSUdScFp5QXhOQW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdNSGd3TURFMU5qTTJPRFl4Tm1VMk56WTFNbVEzTXpjd05qVTJaVFkwTmprMlpUWTNNbVEyWXpZNU5tUTJPVGMwQ2lBZ0lDQTlQUW9nSUNBZ1lub2dZWEJ3Y205MlpWQnliM0J2YzJGc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5Ea0tJQ0FnSUM4dklIUm9hWE11YzJsbmJtRjBiM0pIY205MWNDaDJZWFZzZEZOcFoyNWhkRzl5UjNKdmRYQXBMblpoYkhWbExuTndaVzVrYVc1blRHbHRhWFJCYlc5MWJuUWdQU0J3Y205d2IzTmhiQzVqYUdGdVoyVmtVM0JsYm1ScGJtZE1hVzFwZEVGdGIzVnVkQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBM01pQXZMeUEzTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCa2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQndkWE5vYVc1MElERTJJQzh2SURFMkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFV3Q2lBZ0lDQXZMeUIwYUdsekxuTnBaMjVoZEc5eVIzSnZkWEFvZG1GMWJIUlRhV2R1WVhSdmNrZHliM1Z3S1M1MllXeDFaUzV6Y0dWdVpHbHVaMHhwYldsMFFYTnpaWFFnUFNCd2NtOXdiM05oYkM1amFHRnVaMlZrVTNCbGJtUnBibWRNYVcxcGRFRnpjMlYwU1dRS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTJOQ0F2THlBMk5Bb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQXlOQ0F2THlBeU5Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY21Wd2JHRmpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnBZWFJsWTE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExTVFvZ0lDQWdMeThnZEdocGN5NXphV2R1WVhSdmNrZHliM1Z3S0haaGRXeDBVMmxuYm1GMGIzSkhjbTkxY0NrdWRtRnNkV1V1YzNCbGJtUnBibWRNYVcxcGRFUjFjbUYwYVc5dUlEMGdjSEp2Y0c5ellXd3VZMmhoYm1kbFpGTndaVzVrYVc1blRHbHRhWFJFZFhKaGRHbHZiZ29nSUNBZ2NIVnphR2x1ZENBNE1DQXZMeUE0TUFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY21Wd2JHRmpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnBZWFJsWTE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExTWdvZ0lDQWdMeThnY21WMGRYSnVJRzVsZHlCaGNtTTBMa0p2YjJ3b2RISjFaU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGc0TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMk1nb2dJQ0FnTHk4Z2NIVmliR2xqSUdGd2NISnZkbVZRY205d2IzTmhiQ2h3Y205d2IzTmhiRWxrT2lCaGNtTTBMbE4wY2lrNklHRnlZelF1UW05dmJDQjdDaUFnSUNCaUlHRndjSEp2ZG1WUWNtOXdiM05oYkY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UW1saGRHVmpWbUYxYkhRdVlYQndjbTkyWlZCeWIzQnZjMkZzUURRS0NtRndjSEp2ZG1WUWNtOXdiM05oYkY5aFpuUmxjbDlwWmw5bGJITmxRREV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMU5Rb2dJQ0FnTHk4Z2FXWWdLSEJ5YjNCdmMyRnNMbkJ5YjNCdmMyRnNWSGx3WlNBOVBUMGdWSEpoYm5OaFkzUnBiMjVRY205d2IzTmhiRlI1Y0dVcElIc0tJQ0FnSUdScFp5QXhOQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3WWpjME56STJNVFpsTnpNMk1UWXpOelEyT1RabU5tVUtJQ0FnSUQwOUNpQWdJQ0JpZWlCaGNIQnliM1psVUhKdmNHOXpZV3hmWVdaMFpYSmZhV1pmWld4elpVQXpOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnBZWFJsWTE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEyTXdvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCcElHOW1JSFZ5WVc1blpTaDBlSE11WTI5MWJuUXBLU0I3Q2lBZ0lDQmthV2NnTmdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEZzRJQzh2SURnNENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWW5WeWVTQTRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5WeWVTQTVDZ3BoY0hCeWIzWmxVSEp2Y0c5ellXeGZabTl5WDJobFlXUmxja0F4TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5qTUtJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdhU0J2WmlCMWNtRnVaMlVvZEhoekxtTnZkVzUwS1NrZ2V3b2dJQ0FnWkdsbklEZ0tJQ0FnSUdScFp5QTRDaUFnSUNBOENpQWdJQ0JpZWlCaGNIQnliM1psVUhKdmNHOXpZV3hmWVdaMFpYSmZabTl5UURNekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EWTBDaUFnSUNBdkx5QnpkMmwwWTJnZ0tIUjRjeTUwZVhCbFcybGRLU0I3Q2lBZ0lDQmthV2NnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUF4TXdvZ0lDQWdjM2RoY0FvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUxQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTXlBdkx5QXhNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TkFvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUR3S0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDb0tJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmtkWEF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRZMUNpQWdJQ0F2THlCallYTmxJQ2R3WVhsdFpXNTBKem9LSUNBZ0lIQjFjMmhpZVhSbGN5QWljR0Y1YldWdWRDSUtJQ0FnSUQwOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EWTFMVFEzTlFvZ0lDQWdMeThnWTJGelpTQW5jR0Y1YldWdWRDYzZDaUFnSUNBdkx5QWdJR052Ym5OMElIQmhlVzFsYm5SRGIyMXdiM05sUm1sbGJHUnpJRDBnZXdvZ0lDQWdMeThnSUNBZ0lDNHVMblI0Y3k1d1lYbFVlSE5iYVYwc0NpQWdJQ0F2THlBZ0lDQWdkSGx3WlRvZ1ZISmhibk5oWTNScGIyNVVlWEJsTGxCaGVXMWxiblFzQ2lBZ0lDQXZMeUFnSUgwZ2MyRjBhWE5tYVdWeklGQmhlVzFsYm5SRGIyMXdiM05sUm1sbGJHUnpDaUFnSUNBdkx5QWdJR2xtSUNocElEMDlQU0F3S1NCN0NpQWdJQ0F2THlBZ0lDQWdhWFI0YmtOdmJYQnZjMlV1WW1WbmFXNG9jR0Y1YldWdWRFTnZiWEJ2YzJWR2FXVnNaSE1wQ2lBZ0lDQXZMeUFnSUgwZ1pXeHpaU0I3Q2lBZ0lDQXZMeUFnSUNBZ2FYUjRia052YlhCdmMyVXVibVY0ZENod1lYbHRaVzUwUTI5dGNHOXpaVVpwWld4a2N5a0tJQ0FnSUM4dklDQWdmUW9nSUNBZ0x5OGdJQ0JpY21WaGF3b2dJQ0FnWW5vZ1lYQndjbTkyWlZCeWIzQnZjMkZzWDJGbWRHVnlYMmxtWDJWc2MyVkFNakFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTmpjS0lDQWdJQzh2SUM0dUxuUjRjeTV3WVhsVWVITmJhVjBzQ2lBZ0lDQmthV2NnTVRNS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNaUF2THlBeE1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2MzZGhjQW9nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdScFp5QXhDaUFnSUNCa2FXY2dNVElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVRFS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnY0hWemFHbHVkQ0F4SUM4dklERUtJQ0FnSUNzS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lDMGdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTXlBdkx5QXhNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdScFp5QXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFd0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdPRGdnTHk4Z09EZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEFLSUNBZ0lDc0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJQ3NLSUNBZ0lHUjFjRElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWkdsbklEWUtJQ0FnSUQ0S0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR1JwWnlBMkNpQWdJQ0FxQ2lBZ0lDQmthV2NnTVFvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURVS0lDQWdJSEIxYzJocGJuUWdNVElnTHk4Z01USUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dOZ29nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUEyQ2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhCMWMyaHBiblFnTVRRZ0x5OGdNVFFLSUNBZ0lDc0tJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFkyTFRRMk9Rb2dJQ0FnTHk4Z1kyOXVjM1FnY0dGNWJXVnVkRU52YlhCdmMyVkdhV1ZzWkhNZ1BTQjdDaUFnSUNBdkx5QWdJQzR1TG5SNGN5NXdZWGxVZUhOYmFWMHNDaUFnSUNBdkx5QWdJSFI1Y0dVNklGUnlZVzV6WVdOMGFXOXVWSGx3WlM1UVlYbHRaVzUwTEFvZ0lDQWdMeThnZlNCellYUnBjMlpwWlhNZ1VHRjViV1Z1ZEVOdmJYQnZjMlZHYVdWc1pITUtJQ0FnSUdScFp5QTBDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016QWdMeThnTXpBS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TVRBd01XVUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUNzS0lDQWdJR1JwWnlBMUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTnpBS0lDQWdJQzh2SUdsbUlDaHBJRDA5UFNBd0tTQjdDaUFnSUNCaWJub2dZWEJ3Y205MlpWQnliM0J2YzJGc1gyVnNjMlZmWW05a2VVQXhPUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnBZWFJsWTE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEzTVFvZ0lDQWdMeThnYVhSNGJrTnZiWEJ2YzJVdVltVm5hVzRvY0dGNWJXVnVkRU52YlhCdmMyVkdhV1ZzWkhNcENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXhNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vYVc1MElERTRJQzh2SURFNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklEUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dOQW9nSUNBZ2NIVnphR2x1ZENBeU1DQXZMeUF5TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBMUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklEVUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklEWUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCd2RYTm9hVzUwSURJeUlDOHZJREl5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVG05MFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVFpXNWtaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDZ3BoY0hCeWIzWmxVSEp2Y0c5ellXeGZZbXh2WTJ0QU16STZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFl6Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUdrZ2IyWWdkWEpoYm1kbEtIUjRjeTVqYjNWdWRDa3BJSHNLSUNBZ0lHUnBaeUE0Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0E1Q2lBZ0lDQmlJR0Z3Y0hKdmRtVlFjbTl3YjNOaGJGOW1iM0pmYUdWaFpHVnlRREUxQ2dwaGNIQnliM1psVUhKdmNHOXpZV3hmWld4elpWOWliMlI1UURFNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKcFlYUmxZMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNNd29nSUNBZ0x5OGdhWFI0YmtOdmJYQnZjMlV1Ym1WNGRDaHdZWGx0Wlc1MFEyOXRjRzl6WlVacFpXeGtjeWtLSUNBZ0lHbDBlRzVmYm1WNGRBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnTVRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHbHVkQ0F4T0NBdkx5QXhPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUEwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdScFp5QXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURRS0lDQWdJSEIxYzJocGJuUWdNakFnTHk4Z01qQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dOUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUExQ2lBZ0lDQnNaVzRLSUNBZ0lHUnBaeUEyQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdjSFZ6YUdsdWRDQXlNaUF2THlBeU1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lFNXZkR1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVMlZ1WkdWeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdZaUJoY0hCeWIzWmxVSEp2Y0c5ellXeGZZbXh2WTJ0QU16SUtDbUZ3Y0hKdmRtVlFjbTl3YjNOaGJGOWhablJsY2w5cFpsOWxiSE5sUURJd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKcFlYUmxZMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNOZ29nSUNBZ0x5OGdZMkZ6WlNBbllYTnpaWFFuT2dvZ0lDQWdaR2xuSURFeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW1GemMyVjBJZ29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOell0TkRnMkNpQWdJQ0F2THlCallYTmxJQ2RoYzNObGRDYzZDaUFnSUNBdkx5QWdJR052Ym5OMElHRnpjMlYwUTI5dGNHOXpaVVpwWld4a2N5QTlJSHNLSUNBZ0lDOHZJQ0FnSUNBdUxpNTBlSE11Y0dGNVZIaHpXMmxkTEFvZ0lDQWdMeThnSUNBZ0lIUjVjR1U2SUZSeVlXNXpZV04wYVc5dVZIbHdaUzVCYzNObGRGUnlZVzV6Wm1WeUxBb2dJQ0FnTHk4Z0lDQjlJSE5oZEdselptbGxjeUJCYzNObGRGUnlZVzV6Wm1WeVEyOXRjRzl6WlVacFpXeGtjd29nSUNBZ0x5OGdJQ0JwWmlBb2FTQTlQVDBnTUNrZ2V3b2dJQ0FnTHk4Z0lDQWdJR2wwZUc1RGIyMXdiM05sTG1KbFoybHVLR0Z6YzJWMFEyOXRjRzl6WlVacFpXeGtjeWtLSUNBZ0lDOHZJQ0FnZlNCbGJITmxJSHNLSUNBZ0lDOHZJQ0FnSUNCcGRIaHVRMjl0Y0c5elpTNXVaWGgwS0dGemMyVjBRMjl0Y0c5elpVWnBaV3hrY3lrS0lDQWdJQzh2SUNBZ2ZRb2dJQ0FnTHk4Z0lDQmljbVZoYXdvZ0lDQWdZbm9nWVhCd2NtOTJaVkJ5YjNCdmMyRnNYMkZtZEdWeVgybG1YMlZzYzJWQU1qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOemdLSUNBZ0lDOHZJQzR1TG5SNGN5NXdZWGxVZUhOYmFWMHNDaUFnSUNCa2FXY2dNVE1LSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE1pQXZMeUF4TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeE1nb2dJQ0FnYzNkaGNBb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JrYVdjZ01USUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdjSFZ6YUdsdWRDQXhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUMwZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNeUF2THlBeE1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JREV3Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ09EZ2dMeThnT0RnS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z01UQUtJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lDc0tJQ0FnSUdSMWNESUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURZS0lDQWdJRDRLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHUnBaeUEyQ2lBZ0lDQXFDaUFnSUNCa2FXY2dNUW9nSUNBZ0t3b2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1pHbG5JRFVLSUNBZ0lIQjFjMmhwYm5RZ01USWdMeThnTVRJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ05nb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QTJDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSEIxYzJocGJuUWdNVFFnTHk4Z01UUUtJQ0FnSUNzS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EYzNMVFE0TUFvZ0lDQWdMeThnWTI5dWMzUWdZWE56WlhSRGIyMXdiM05sUm1sbGJHUnpJRDBnZXdvZ0lDQWdMeThnSUNBdUxpNTBlSE11Y0dGNVZIaHpXMmxkTEFvZ0lDQWdMeThnSUNCMGVYQmxPaUJVY21GdWMyRmpkR2x2YmxSNWNHVXVRWE56WlhSVWNtRnVjMlpsY2l3S0lDQWdJQzh2SUgwZ2MyRjBhWE5tYVdWeklFRnpjMlYwVkhKaGJuTm1aWEpEYjIxd2IzTmxSbWxsYkdSekNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNd0lDOHZJRE13Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNRFF3TURGbENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTFDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0FyQ2lBZ0lDQmthV2NnTlFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGd4Q2lBZ0lDQXZMeUJwWmlBb2FTQTlQVDBnTUNrZ2V3b2dJQ0FnWW01NklHRndjSEp2ZG1WUWNtOXdiM05oYkY5bGJITmxYMkp2WkhsQU1qTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPRElLSUNBZ0lDOHZJR2wwZUc1RGIyMXdiM05sTG1KbFoybHVLR0Z6YzJWMFEyOXRjRzl6WlVacFpXeGtjeWtLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURFd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTVRnZ0x5OGdNVGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1JwWnlBMENpQWdJQ0J3ZFhOb2FXNTBJREl3SUM4dklESXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRFVLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTlFvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTmdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJSEIxYzJocGJuUWdNaklnTHk4Z01qSUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQk9iM1JsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRk5sYm1SbGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR0lnWVhCd2NtOTJaVkJ5YjNCdmMyRnNYMkpzYjJOclFETXlDZ3BoY0hCeWIzWmxVSEp2Y0c5ellXeGZaV3h6WlY5aWIyUjVRREl6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNE5Bb2dJQ0FnTHk4Z2FYUjRia052YlhCdmMyVXVibVY0ZENoaGMzTmxkRU52YlhCdmMyVkdhV1ZzWkhNcENpQWdJQ0JwZEhodVgyNWxlSFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklERXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ01UZ2dMeThnTVRnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QTBDaUFnSUNCd2RYTm9hVzUwSURJd0lDOHZJREl3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURVS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pHbG5JRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ05nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUhCMWMyaHBiblFnTWpJZ0x5OGdNaklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JPYjNSbENpQWdJQ0JwZEhodVgyWnBaV3hrSUZObGJtUmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdJZ1lYQndjbTkyWlZCeWIzQnZjMkZzWDJKc2IyTnJRRE15Q2dwaGNIQnliM1psVUhKdmNHOXpZV3hmWVdaMFpYSmZhV1pmWld4elpVQXlORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT0RjS0lDQWdJQzh2SUdOaGMyVWdKMkZ3Y0NjNkNpQWdJQ0JrYVdjZ01USUtJQ0FnSUhCMWMyaGllWFJsY3lBaVlYQndJZ29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPRGN0TkRrM0NpQWdJQ0F2THlCallYTmxJQ2RoY0hBbk9nb2dJQ0FnTHk4Z0lDQmpiMjV6ZENCaGNIQkRiMjF3YjNObFJtbGxiR1J6SUQwZ2V3b2dJQ0FnTHk4Z0lDQWdJQzR1TG5SNGN5NXdZWGxVZUhOYmFWMHNDaUFnSUNBdkx5QWdJQ0FnZEhsd1pUb2dWSEpoYm5OaFkzUnBiMjVVZVhCbExrRndjR3hwWTJGMGFXOXVRMkZzYkN3S0lDQWdJQzh2SUNBZ2ZTQnpZWFJwYzJacFpYTWdRWEJ3YkdsallYUnBiMjVEWVd4c1EyOXRjRzl6WlVacFpXeGtjd29nSUNBZ0x5OGdJQ0JwWmlBb2FTQTlQVDBnTUNrZ2V3b2dJQ0FnTHk4Z0lDQWdJR2wwZUc1RGIyMXdiM05sTG1KbFoybHVLR0Z3Y0VOdmJYQnZjMlZHYVdWc1pITXBDaUFnSUNBdkx5QWdJSDBnWld4elpTQjdDaUFnSUNBdkx5QWdJQ0FnYVhSNGJrTnZiWEJ2YzJVdWJtVjRkQ2hoY0hCRGIyMXdiM05sUm1sbGJHUnpLUW9nSUNBZ0x5OGdJQ0I5Q2lBZ0lDQXZMeUFnSUdKeVpXRnJDaUFnSUNCaWVpQmhjSEJ5YjNabFVISnZjRzl6WVd4ZllXWjBaWEpmYVdaZlpXeHpaVUF5T0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNE9Rb2dJQ0FnTHk4Z0xpNHVkSGh6TG5CaGVWUjRjMXRwWFN3S0lDQWdJR1JwWnlBeE13b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREV5SUM4dklERXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREV5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdMU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDb0tJQ0FnSUdScFp5QTBDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eklDOHZJREV3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0E0T0NBdkx5QTRPQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUF4TUFvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnS3dvZ0lDQWdaSFZ3TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dOZ29nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWkdsbklEWUtJQ0FnSUNvS0lDQWdJR1JwWnlBeENpQWdJQ0FyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNBckNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JrYVdjZ05Rb2dJQ0FnY0hWemFHbHVkQ0F4TWlBdkx5QXhNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUEyQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdScFp5QXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURZS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2NIVnphR2x1ZENBeE5DQXZMeUF4TkFvZ0lDQWdLd29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT0RndE5Ea3hDaUFnSUNBdkx5QmpiMjV6ZENCaGNIQkRiMjF3YjNObFJtbGxiR1J6SUQwZ2V3b2dJQ0FnTHk4Z0lDQXVMaTUwZUhNdWNHRjVWSGh6VzJsZExBb2dJQ0FnTHk4Z0lDQjBlWEJsT2lCVWNtRnVjMkZqZEdsdmJsUjVjR1V1UVhCd2JHbGpZWFJwYjI1RFlXeHNMQW9nSUNBZ0x5OGdmU0J6WVhScGMyWnBaWE1nUVhCd2JHbGpZWFJwYjI1RFlXeHNRMjl0Y0c5elpVWnBaV3hrY3dvZ0lDQWdaR2xuSURRS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TUNBdkx5QXpNQW9nSUNBZ0t3b2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQTJNREF4WlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdLd29nSUNBZ1pHbG5JRFVLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKcFlYUmxZMTkyWVhWc2RDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTVNZ29nSUNBZ0x5OGdhV1lnS0drZ1BUMDlJREFwSUhzS0lDQWdJR0p1ZWlCaGNIQnliM1psVUhKdmNHOXpZV3hmWld4elpWOWliMlI1UURJM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Ea3pDaUFnSUNBdkx5QnBkSGh1UTI5dGNHOXpaUzVpWldkcGJpaGhjSEJEYjIxd2IzTmxSbWxsYkdSektRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdsdWRDQXhPQ0F2THlBeE9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JRFFLSUNBZ0lIQjFjMmhwYm5RZ01qQWdMeThnTWpBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ05Rb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QTFDaUFnSUNCc1pXNEtJQ0FnSUdScFp5QTJDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2NIVnphR2x1ZENBeU1pQXZMeUF5TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUU1dmRHVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1UyVnVaR1Z5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ1lpQmhjSEJ5YjNabFVISnZjRzl6WVd4ZllteHZZMnRBTXpJS0NtRndjSEp2ZG1WUWNtOXdiM05oYkY5bGJITmxYMkp2WkhsQU1qYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGsxQ2lBZ0lDQXZMeUJwZEhodVEyOXRjRzl6WlM1dVpYaDBLR0Z3Y0VOdmJYQnZjMlZHYVdWc1pITXBDaUFnSUNCcGRIaHVYMjVsZUhRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJREV3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJocGJuUWdNVGdnTHk4Z01UZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQndkWE5vYVc1MElESXdJQzh2SURJd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklEVUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dOUW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dOZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lIQjFjMmhwYm5RZ01qSWdMeThnTWpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCT2IzUmxDaUFnSUNCcGRIaHVYMlpwWld4a0lGTmxibVJsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHSWdZWEJ3Y205MlpWQnliM0J2YzJGc1gySnNiMk5yUURNeUNncGhjSEJ5YjNabFVISnZjRzl6WVd4ZllXWjBaWEpmYVdaZlpXeHpaVUF5T0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9UZ0tJQ0FnSUM4dklHTmhjMlVnSjJ0bGVYSmxaeWM2Q2lBZ0lDQmthV2NnTVRJS0lDQWdJSEIxYzJoaWVYUmxjeUFpYTJWNWNtVm5JZ29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPVGd0TlRBNENpQWdJQ0F2THlCallYTmxJQ2RyWlhseVpXY25PZ29nSUNBZ0x5OGdJQ0JqYjI1emRDQnJaWGxEYjIxd2IzTmxSbWxsYkdSeklEMGdld29nSUNBZ0x5OGdJQ0FnSUM0dUxuUjRjeTVyWlhsU1pXZFVlSE5iYVYwc0NpQWdJQ0F2THlBZ0lDQWdkSGx3WlRvZ1ZISmhibk5oWTNScGIyNVVlWEJsTGt0bGVWSmxaMmx6ZEhKaGRHbHZiaXdLSUNBZ0lDOHZJQ0FnZlNCellYUnBjMlpwWlhNZ1MyVjVVbVZuYVhOMGNtRjBhVzl1UTI5dGNHOXpaVVpwWld4a2N3b2dJQ0FnTHk4Z0lDQnBaaUFvYVNBOVBUMGdNQ2tnZXdvZ0lDQWdMeThnSUNBZ0lHbDBlRzVEYjIxd2IzTmxMbUpsWjJsdUtHdGxlVU52YlhCdmMyVkdhV1ZzWkhNcENpQWdJQ0F2THlBZ0lIMGdaV3h6WlNCN0NpQWdJQ0F2THlBZ0lDQWdhWFI0YmtOdmJYQnZjMlV1Ym1WNGRDaHJaWGxEYjIxd2IzTmxSbWxsYkdSektRb2dJQ0FnTHk4Z0lDQjlDaUFnSUNBdkx5QWdJR0p5WldGckNpQWdJQ0JpZWlCaGNIQnliM1psVUhKdmNHOXpZV3hmWW14dlkydEFNeklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTURBS0lDQWdJQzh2SUM0dUxuUjRjeTVyWlhsU1pXZFVlSE5iYVYwc0NpQWdJQ0JrYVdjZ05nb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRGc0SUM4dklEZzRDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhOaUF2THlBeE5nb2dJQ0FnS3dvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ0t3b2dJQ0FnWkhWd01nb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmthV2NnTVRFS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOENpQWdJQ0JoYzNObGNuUWdMeThnYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpJRFFnTHk4Z01UVXpDaUFnSUNBcUNpQWdJQ0FyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTWdOQ0F2THlBeE5UTUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTXpJS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRFkwSURnS0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJRGN5SURnS0lDQWdJR1JwWnlBMENpQWdJQ0JsZUhSeVlXTjBJRGd3SURnS0lDQWdJR1JwWnlBMUNpQWdJQ0J3ZFhOb2FXNTBJRGN3TkNBdkx5QTNNRFFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCbGVIUnlZV04wSURnNUlEWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltbGhkR1ZqWDNaaGRXeDBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEF4Q2lBZ0lDQXZMeUIwZVhCbE9pQlVjbUZ1YzJGamRHbHZibFI1Y0dVdVMyVjVVbVZuYVhOMGNtRjBhVzl1TEFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT1RrdE5UQXlDaUFnSUNBdkx5QmpiMjV6ZENCclpYbERiMjF3YjNObFJtbGxiR1J6SUQwZ2V3b2dJQ0FnTHk4Z0lDQXVMaTUwZUhNdWEyVjVVbVZuVkhoelcybGRMQW9nSUNBZ0x5OGdJQ0IwZVhCbE9pQlVjbUZ1YzJGamRHbHZibFI1Y0dVdVMyVjVVbVZuYVhOMGNtRjBhVzl1TEFvZ0lDQWdMeThnZlNCellYUnBjMlpwWlhNZ1MyVjVVbVZuYVhOMGNtRjBhVzl1UTI5dGNHOXpaVVpwWld4a2N3b2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklEY0tJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhOcGVtVUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05nb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYzJsNlpRb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdjMlYwWW1sMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTmpRZ0x5OGdOalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCemFYcGxDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTURNS0lDQWdJQzh2SUdsbUlDaHBJRDA5UFNBd0tTQjdDaUFnSUNCaWJub2dZWEJ3Y205MlpWQnliM0J2YzJGc1gyVnNjMlZmWW05a2VVQXpNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnBZWFJsWTE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV3TkFvZ0lDQWdMeThnYVhSNGJrTnZiWEJ2YzJVdVltVm5hVzRvYTJWNVEyOXRjRzl6WlVacFpXeGtjeWtLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0E0SURNeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkQ0EwTUNBek1nb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTnpJZ0x5OGdOeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjSFZ6YUdsdWRDQTRNQ0F2THlBNE1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QTFDaUFnSUNCd2RYTm9hVzUwSURnNElDOHZJRGc0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURZS0lDQWdJSEIxYzJocGJuUWdOelk0SUM4dklEYzJPQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdWNGRISmhZM1FnT1RjZ05qUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1UzUmhkR1ZRY205dlpsQkxDaUFnSUNCcGRIaHVYMlpwWld4a0lFNXZibkJoY25ScFkybHdZWFJwYjI0S0lDQWdJR2wwZUc1ZlptbGxiR1FnVm05MFpVdGxlVVJwYkhWMGFXOXVDaUFnSUNCcGRIaHVYMlpwWld4a0lGWnZkR1ZNWVhOMENpQWdJQ0JwZEhodVgyWnBaV3hrSUZadmRHVkdhWEp6ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWld4bFkzUnBiMjVRU3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JXYjNSbFVFc0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdZaUJoY0hCeWIzWmxVSEp2Y0c5ellXeGZZbXh2WTJ0QU16SUtDbUZ3Y0hKdmRtVlFjbTl3YjNOaGJGOWxiSE5sWDJKdlpIbEFNekU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRBMkNpQWdJQ0F2THlCcGRIaHVRMjl0Y0c5elpTNXVaWGgwS0d0bGVVTnZiWEJ2YzJWR2FXVnNaSE1wQ2lBZ0lDQnBkSGh1WDI1bGVIUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0E0SURNeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkQ0EwTUNBek1nb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTnpJZ0x5OGdOeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjSFZ6YUdsdWRDQTRNQ0F2THlBNE1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QTFDaUFnSUNCd2RYTm9hVzUwSURnNElDOHZJRGc0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURZS0lDQWdJSEIxYzJocGJuUWdOelk0SUM4dklEYzJPQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdWNGRISmhZM1FnT1RjZ05qUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1UzUmhkR1ZRY205dlpsQkxDaUFnSUNCcGRIaHVYMlpwWld4a0lFNXZibkJoY25ScFkybHdZWFJwYjI0S0lDQWdJR2wwZUc1ZlptbGxiR1FnVm05MFpVdGxlVVJwYkhWMGFXOXVDaUFnSUNCcGRIaHVYMlpwWld4a0lGWnZkR1ZNWVhOMENpQWdJQ0JwZEhodVgyWnBaV3hrSUZadmRHVkdhWEp6ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWld4bFkzUnBiMjVRU3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JXYjNSbFVFc0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdZaUJoY0hCeWIzWmxVSEp2Y0c5ellXeGZZbXh2WTJ0QU16SUtDbUZ3Y0hKdmRtVlFjbTl3YjNOaGJGOWhablJsY2w5bWIzSkFNek02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRFeUNpQWdJQ0F2THlCcGRIaHVRMjl0Y0c5elpTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYVdGMFpXTmZkbUYxYkhRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1UTUtJQ0FnSUM4dklISmxkSFZ5YmlCdVpYY2dZWEpqTkM1Q2IyOXNLSFJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE9EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOaklLSUNBZ0lDOHZJSEIxWW14cFl5QmhjSEJ5YjNabFVISnZjRzl6WVd3b2NISnZjRzl6WVd4SlpEb2dZWEpqTkM1VGRISXBPaUJoY21NMExrSnZiMndnZXdvZ0lDQWdZaUJoY0hCeWIzWmxVSEp2Y0c5ellXeGZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rSnBZWFJsWTFaaGRXeDBMbUZ3Y0hKdmRtVlFjbTl3YjNOaGJFQTBDZ3BoY0hCeWIzWmxVSEp2Y0c5ellXeGZZV1owWlhKZmFXWmZaV3h6WlVBek5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWFXRjBaV05mZG1GMWJIUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOVGtLSUNBZ0lDOHZJSEpsZEhWeWJpQnVaWGNnWVhKak5DNUNiMjlzS0daaGJITmxLUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbWxoZEdWalgzWmhkV3gwTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZeUNpQWdJQ0F2THlCd2RXSnNhV01nWVhCd2NtOTJaVkJ5YjNCdmMyRnNLSEJ5YjNCdmMyRnNTV1E2SUdGeVl6UXVVM1J5S1RvZ1lYSmpOQzVDYjI5c0lIc0tJQ0FnSUdJZ1lYQndjbTkyWlZCeWIzQnZjMkZzWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwySnBZWFJsWTE5MllYVnNkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBDYVdGMFpXTldZWFZzZEM1aGNIQnliM1psVUhKdmNHOXpZV3hBTkFvS1lYQndjbTkyWlZCeWIzQnZjMkZzWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWlhV0YwWldOZmRtRjFiSFF2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTURBS0lDQWdJQzh2SUhKbGRIVnliaUJ1WlhjZ1lYSmpOQzVDYjI5c0tHWmhiSE5sS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW1saGRHVmpYM1poZFd4MEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16WXlDaUFnSUNBdkx5QndkV0pzYVdNZ1lYQndjbTkyWlZCeWIzQnZjMkZzS0hCeWIzQnZjMkZzU1dRNklHRnlZelF1VTNSeUtUb2dZWEpqTkM1Q2IyOXNJSHNLSUNBZ0lHSWdZWEJ3Y205MlpWQnliM0J2YzJGc1gyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpwWVhSbFkxOTJZWFZzZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQ2FXRjBaV05XWVhWc2RDNWhjSEJ5YjNabFVISnZjRzl6WVd4QU5Bbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZBZ0FJQ3BrQkpnNEJnQUZUQVFBQmN3SUFCQUlBSkFnQUFBQUFBQUFBQVFVVkgzeDFnQTRBREdGa1pDMXphV2R1WVhSdmNpQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJFQUQzSmxiVzkyWlMxemFXZHVZWFJ2Y2hJQUVHTm9ZVzVuWlMxMGFISmxjMmh2YkdRSUFBQUFBQUFBQUFBWEFCVmphR0Z1WjJVdGMzQmxibVJwYm1jdGJHbHRhWFF4RzBFQUpERVpGRVF4R0VTQ0F3VGN2THlmQlBZdVAxVUVpZm52b0RZYUFJNERBQXdBblFWREFERVpGREVZRkJCRWdRRkROaG9CU1NOWklnaExBUlZKVHdJU1JEWWFBa2tqV1NJSVN3RVZFa1NBQVhaTEExQkp2VVVCRkVRbkJyK0JCRXNDQ0JaWEJnSW5CRXhRU3dOUVN3RlFNUUNCSkU4RUNCWlhCZ0luQlV4UVRGQlBBMUJQQWxBclR3SlFnQ2tBQUFBQUFBQUFBUUFBQUFBQUFBQUJBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWdMOHBURkFvdnljSHNJRUJReU5IQm9BQVJ4UTJHZ0ZIQWhWSlR3SkpJMWxKVGdOSmdWb1NSRXNCVEVzRFVpTlpnVndJU3dFbFdVbE9CRWxMQWhKRVN3Sk1Td1JTSTFraUNBaExBWUVNV1VsT0JFbExBaEpFU3dKTVN3UlNJMWtpQ0FoTEFZRVdXVWxPQkVsTEFoSkVTd0pNU3dSU0kxa2lDQWhKVGdOTEFZRllXVWxPQkVsUEFoSkVUd0pTUndJVlNVOENTU1JaU1lFU0VrUlBBbEpKSTFsSlRnSWlDMHhYQWdBalNVc0VERUVBSlVjQ0lndExBMGxQQWxsSlN3WkpUZ1FTUkVzQkZWSWpXU0lJQ0VVRWdRRUlSUUZDLzlSTEFvRVVDRWxGSUVzR1NVNENKVmxKVHdJU1JFc0dVa2tqV1VsRkhDSUxSUlZYQWdCRktTTkZHVXNZU3hvTVFRQmhTeGhKSWd0TEtrbFBBbGxKU3hkSlRnUVNSRXNCRlZKSkZVc0JJMWxKZ1JZU1JFc0NURXNDVWlOWmdSZ0lTd0lsV1VsTEFoSkVTd05NU3dOU0kxa2lDQWhMQW9FTVdVbExBaEpFVHdOTVR3TlNJMWtpQ0FnSVJSV0JBUWhGR1VML2wwc1RJZ2hMSHdoSlJTUkxCa2xPQW9FTVdVbFBBaEpFU3daU1NTTlpTVVVnSWd0RkZGY0NBRVVvSTBVWVN4ZExIZ3hCQUdKTEYwa2lDMHNwU1U4Q1dVbExGa2xPQkJKRVN3RVZVa2tWU3dFaldVbUJIaEpFU3dKTVN3SlNJMW1CSUFoTEFvRVNXVWxMQWhKRVN3Tk1Td05TSTFraUNBaExBb0VVV1VsTEFoSkVUd05NVHdOU0kxa2lDQWdJUlJTQkFRaEZHRUwvbGtzU0lnaExJd2hKUlNOTEJrbE9Bb0VPV1VsUEFoSkVTd1pTU1NOWlNVVWZJZ3RGRTFjQ0FFVW5JMFVYU3haTEhReEJBV3hMRmlJTFN5ZEpUd0paU1VzVUVrUkxBUlZTU1VVbFNSVkpUZ0pGRVVraldVbUJKQkpFU3dGTVN3TlNJMW1CSmdoTEFTVlpTVXNDRWtSTEFreExCRklqV1NJSUNFbEZKRXNCZ1J4WlNVOENFa1JQQWxKSkZVc0JJMWxKSWhKRVRGSkpJMWxKUlI0aUMwVVNWd0lBUlNZalJSWkxGVXNjREVFQUprc1ZTU0lMU3lkSlR3SlpTVXNVU1U0RUVrUkxBUlZTSTFraUNBaEZFb0VCQ0VVV1F2L1NTeENCQkFoTElRaEpSU0ZMSkVsT0FvRWVXVWxQQWhKRVN4QlNTUlZMQVNOWlNTSVNSRXhTU1NOWlNVVWRJZ3RGRVZjQ0FFVWxJMFVWU3hSTEd3eEJBQ1pMRkVraUMwc21TVThDV1VsTEUwbE9CQkpFU3dFVlVpTlpJZ2dJUlJHQkFRaEZGVUwvMGtzUGdRUUlTeUFJU3lSSlRnS0JJRmxKU3dJU1JFc0NURXNTU1U0RlVra1ZTd0VqV1VraUVrUk1VaU5aSkF1QkJBZ0lTd0dCSWxsSlN3SVNSRThDVEU4RFVra1ZTd0VqV1VraUVrUk1VaU5aSkF1QkJBZ0lTeElJUlJKTEZvRUJDRVVYUXY2TVN4RWlDRXNpQ0VzR1NVNENnUkJaU1VzQ0VrUlBBa3hMQjFJaldTRUVDeUlJQ0VzSUNFc05Fa1EyR2dKSkkxa2lDRXNCRlJKRVN3NUpTdzFMRFVsT0ExSkxBazhDU3cxSlRnWlNTd0VWZ1FSTEFRZ1dWd1lDSndSTVVFc0RVRWxQQTFBclRGQkp2VVVCUkVzRUlsc1VSTDVJZ2NBQ1V5b2pUd0pVSTFORVN3UlFLMHhRdlVVQlJERUFnU1JQQWdnV1Z3WUNKd1ZNVUV4UVRGQlBBbEFwVEZDOVJRRkVURXNJVWtsRkt5Y0lFa0VBQ1VzTlZ4Z2dKd2tUUkVzcEp3b1NRUUFKU3cxWEdDQW5DUk5FU3lrbkN4SkJBQWxMRFZjNENDY01FMFJMS1NjTkVrRUFFVXNOZ1VoYlFRQUpTdzFYVUFnbkRCTkVTdzFKU3cxTERWS0FBV05NVUVtOVJRRVVSRW04U0V5L0p3ZXdnUUZESTBjQ2dBQkhCRFlhQVVraldTSUlTd0VWRWtTQUFXTkxBVkJKVGdKSnZreEpUZ05PQkVSSmdRNGt1aGN5Qnd4RVN3RWxXVXNDZ1F4WlN3TlBBa3NDVWtsT0EwNEZTd09CRmxsSlRnWlBCRTRDVWtsT0FrNEVTd0lWZ1FSTEFRZ1dWd1lDSndSTVVFc0VVRXNEVUN0TVVFbE9Ca205UlFGRU1RQ0JKRThEQ0JaWEJnSW5CVXhRU1U0SFRGQlBCRkJQQTFBcFRGQkp2VVVCUkw1SUkxTkVnQUlBSWpFQVVFOERVSUFCY0V4UVNiMUZBUlJFSndhL1N3RWlKTG9YZ1FFSVNSWlBBeUpQQXJ0TXZrZ2pXdzlCQnhkTEJVbUJXRmxKUlE1TEJVeFNTVVVRSndnU1FRQXlTd2FEQWhnZ3Vrc0JURkJMQlZCTEExQW9UQ2xNVUNpL1N3Skp2a1FrVzRFQkNCWWtUTHVBQkJVZmZIVk1VTENCQVVOTERpY0tFa0VBS0VzR2d3SVlJTHBMQVV4UVN3VlFTd05RS1V4UUtyOUxBVW0rUkNSYmdRRUpGaVJNdXloQy84UkxEaWNMRWtFQUVFc0dnVGdrdWtzQ0kwOEN1eWhDLzZ4TERpY05Fa0VBS1VzR1NZRklKTHBMQTBsT0E0RVFUd0s3U1lGQUpMcExBb0VZVHdLN2dWQWt1b0VnVExzb1F2OTdTdzZBRFFBTGRISmhibk5oWTNScGIyNFNRUVk5U3daSmdWZ2l1aGNrdWhkRkNDTkZDVXNJU3dnTVFRWWdTd1ZKRlVzTlRGSkpSUTlKSkZsTEFTVlpTVVVPVWtsWEFnQk1JMWxMQ2tsUEFneEVJZ3RKUlF4TEFVeFpTbGtpQ0ZoWEFnQkpSUTZBQjNCaGVXMWxiblFTUVFHWFN3MUpnUXhaU3d4TVVrbFhBZ0JNSTFsTEFVc01XVXNMU1U0RWdRRUlUd0pMQVFsTEF4VlBBaUlMU3dSTVdVOENUVkpKSTFsTEFTVlpTd0pQQWtzQ1VsY0NBRXNLU1lGWUlyb1hTU1VJU3dKTUlyb1hDRW9pdWhkTEJnMUVJZ2dpU3dZTFN3RUlTd0pNSXJvWENFa2lDRXNDVENTNkYwc0ZnUXhaU3daUEJrc0NVbGNDQUVzR0ZVOEhUd05QQWxKWEFnQlBBNEVPQ0U4RVRDUzZGMHNFRlJaWEJnSlBCVkJKRllFZUNFOEZGb0FLQUFBQUFBQUFBQUVBSGt4UVN3VVZGbGNHQWs4R1VFc0NGbGNHQWs4Q1RGQkxBUlZQQXdoTEJSVVdWd1lDVHdaUVRCWlhCZ0pQQWt4UVR3UVdVRThEVUU4Q1VFeFFURUFBVXJGSkpWdExBU05iU3dJa1dVc0RnUkpaU3dSUEFrc0NVbGNDQUVzRWdSUlpTd1ZQQTBzQ1VsY0NBRXNGRlVzR1R3TlBBbEpYQWdCUEJZRVdXN0lJc2dleUJiSUFzaEN5QVVzSWdRRUlSUWxDL21lMlNTVmJTd0VqVzBzQ0pGbExBNEVTV1VzRVR3SkxBbEpYQWdCTEJJRVVXVXNGVHdOTEFsSlhBZ0JMQlJWTEJrOERUd0pTVndJQVR3V0JGbHV5Q0xJSHNnV3lBTElRc2dGQy82dExESUFGWVhOelpYUVNRUUdRU3cxSmdReFpTd3hNVWtsWEFnQk1JMWxMQVVzTVdVc0xTVTRFZ1FFSVR3SkxBUWxMQXhWUEFpSUxTd1JNV1U4Q1RWSkpJMWxMQVNWWlN3SlBBa3NDVWxjQ0FFc0tTWUZZSXJvWFNTVUlTd0pNSXJvWENFb2l1aGRMQmcxRUlnZ2lTd1lMU3dFSVN3Sk1Jcm9YQ0VraUNFc0NUQ1M2RjBzRmdReFpTd1pQQmtzQ1VsY0NBRXNHRlU4SFR3TlBBbEpYQWdCUEE0RU9DRThFVENTNkYwc0VGUlpYQmdKUEJWQkpGWUVlQ0U4RkZvQUtBQUFBQUFBQUFBUUFIa3hRU3dVVkZsY0dBazhHVUVzQ0ZsY0dBazhDVEZCTEFSVlBBd2hMQlJVV1Z3WUNUd1pRVEJaWEJnSlBBa3hRVHdRV1VFOERVRThDVUV4UVRFQUFTN0ZKSlZ0TEFTTmJTd0lrV1VzRGdSSlpTd1JQQWtzQ1VsY0NBRXNFZ1JSWlN3VlBBMHNDVWxjQ0FFc0ZGVXNHVHdOUEFsSlhBZ0JQQllFV1c3SUlzZ2V5QmJJQXNoQ3lBVUwrV2JaSkpWdExBU05iU3dJa1dVc0RnUkpaU3dSUEFrc0NVbGNDQUVzRWdSUlpTd1ZQQTBzQ1VsY0NBRXNGRlVzR1R3TlBBbEpYQWdCUEJZRVdXN0lJc2dleUJiSUFzaEN5QVVMK0Rrc01nQU5oY0hBU1FRR1FTdzFKZ1F4WlN3eE1Va2xYQWdCTUkxbExBVXNNV1VzTFNVNEVnUUVJVHdKTEFRbExBeFZQQWlJTFN3Uk1XVThDVFZKSkkxbExBU1ZaU3dKUEFrc0NVbGNDQUVzS1NZRllJcm9YU1NVSVN3Sk1Jcm9YQ0VvaXVoZExCZzFFSWdnaVN3WUxTd0VJU3dKTUlyb1hDRWtpQ0VzQ1RDUzZGMHNGZ1F4WlN3WlBCa3NDVWxjQ0FFc0dGVThIVHdOUEFsSlhBZ0JQQTRFT0NFOEVUQ1M2RjBzRUZSWlhCZ0pQQlZCSkZZRWVDRThGRm9BS0FBQUFBQUFBQUFZQUhreFFTd1VWRmxjR0FrOEdVRXNDRmxjR0FrOENURkJMQVJWUEF3aExCUlVXVndZQ1R3WlFUQlpYQmdKUEFreFFUd1FXVUU4RFVFOENVRXhRVEVBQVM3RkpKVnRMQVNOYlN3SWtXVXNEZ1JKWlN3UlBBa3NDVWxjQ0FFc0VnUlJaU3dWUEEwc0NVbGNDQUVzRkZVc0dUd05QQWxKWEFnQlBCWUVXVzdJSXNnZXlCYklBc2hDeUFVTDh2clpKSlZ0TEFTTmJTd0lrV1VzRGdSSlpTd1JQQWtzQ1VsY0NBRXNFZ1JSWlN3VlBBMHNDVWxjQ0FFc0ZGVXNHVHdOUEFsSlhBZ0JQQllFV1c3SUlzZ2V5QmJJQXNoQ3lBVUw4YzBzTWdBWnJaWGx5WldjU1FmeGxTd1pKZ1ZnaXVoZEpnUkFJU3dKTUlyb1hDRW9pdWhkTEMwbFBBZ3hFVENJSVN3RWhCQXNJVHdKTUlRUzZTVmNBSUVzQlZ5QWdTd0pYUUFoTEExZElDRXNFVjFBSVN3V0J3QVZUVHdaWFdVQWlGa3NIRllFZ0VrUlBCMUJMQmhXQklCSkVUd1pRVHdWUVR3UlFUd05RS2lOUEJGUlFTd0VWZ1VBU1JFeFFURUFBUHJGSkkxdExBVmNJSUVzQ1Z5Z2dTd09CU0Z0TEJJRlFXMHNGZ1ZoYlN3YUJnQVpUVHdkWFlVQ3lQN0k1c2c2eURiSU1zZ3V5Q3JJUUk3SUJRdnVsdGtralcwc0JWd2dnU3dKWEtDQkxBNEZJVzBzRWdWQmJTd1dCV0Z0TEJvR0FCbE5QQjFkaFFMSS9zam15RHJJTnNneXlDN0lLc2hBanNnRkMrMmV6S0VMNUtTcEMrU1VxUXZraCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
