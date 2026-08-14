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

namespace Arc56.Generated.ranjith_ind.Evidence_Chain.EvidenceRegistry_06008427
{


    //
    // EvidenceRegistry Smart Contract
    //Blockchain-powered digital evidence protection and verification platform.
    //
    public class EvidenceRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EvidenceRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CustodyRecord : AVMObjectType
            {
                public string EvidenceId { get; set; }

                public Algorand.Address FromCustodian { get; set; }

                public Algorand.Address ToCustodian { get; set; }

                public ulong Timestamp { get; set; }

                public string ActionReason { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEvidenceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEvidenceId.From(EvidenceId);
                    stringRef[ret.Count] = vEvidenceId.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFromCustodian = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vFromCustodian.From(FromCustodian);
                    ret.AddRange(vFromCustodian.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vToCustodian = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vToCustodian.From(ToCustodian);
                    ret.AddRange(vToCustodian.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActionReason = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vActionReason.From(ActionReason);
                    stringRef[ret.Count] = vActionReason.Encode();
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

                public static CustodyRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new CustodyRecord();
                    uint count = 0;
                    var indexEvidenceId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEvidenceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEvidenceId.Decode(bytes.Skip(indexEvidenceId + prefixOffset).ToArray());
                    var valueEvidenceId = vEvidenceId.ToValue();
                    if (valueEvidenceId is string vEvidenceIdValue) { ret.EvidenceId = vEvidenceIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFromCustodian = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vFromCustodian.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFromCustodian = vFromCustodian.ToValue();
                    if (valueFromCustodian is Algorand.Address vFromCustodianValue) { ret.FromCustodian = vFromCustodianValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vToCustodian = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vToCustodian.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueToCustodian = vToCustodian.ToValue();
                    if (valueToCustodian is Algorand.Address vToCustodianValue) { ret.ToCustodian = vToCustodianValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    var indexActionReason = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActionReason = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vActionReason.Decode(bytes.Skip(indexActionReason + prefixOffset).ToArray());
                    var valueActionReason = vActionReason.ToValue();
                    if (valueActionReason is string vActionReasonValue) { ret.ActionReason = vActionReasonValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CustodyRecord);
                }
                public bool Equals(CustodyRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CustodyRecord left, CustodyRecord right)
                {
                    return EqualityComparer<CustodyRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(CustodyRecord left, CustodyRecord right)
                {
                    return !(left == right);
                }

            }

            public class EvidenceRecord : AVMObjectType
            {
                public string EvidenceId { get; set; }

                public string CaseId { get; set; }

                public string EvidenceHash { get; set; }

                public string IpfsCid { get; set; }

                public Algorand.Address Uploader { get; set; }

                public ulong CreatedAt { get; set; }

                public string Status { get; set; }

                public Algorand.Address CurrentCustodian { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEvidenceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEvidenceId.From(EvidenceId);
                    stringRef[ret.Count] = vEvidenceId.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaseId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCaseId.From(CaseId);
                    stringRef[ret.Count] = vCaseId.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEvidenceHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEvidenceHash.From(EvidenceHash);
                    stringRef[ret.Count] = vEvidenceHash.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpfsCid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vIpfsCid.From(IpfsCid);
                    stringRef[ret.Count] = vIpfsCid.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUploader = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vUploader.From(Uploader);
                    ret.AddRange(vUploader.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vStatus.From(Status);
                    stringRef[ret.Count] = vStatus.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrentCustodian = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCurrentCustodian.From(CurrentCustodian);
                    ret.AddRange(vCurrentCustodian.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EvidenceRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new EvidenceRecord();
                    uint count = 0;
                    var indexEvidenceId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEvidenceId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEvidenceId.Decode(bytes.Skip(indexEvidenceId + prefixOffset).ToArray());
                    var valueEvidenceId = vEvidenceId.ToValue();
                    if (valueEvidenceId is string vEvidenceIdValue) { ret.EvidenceId = vEvidenceIdValue; }
                    var indexCaseId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaseId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCaseId.Decode(bytes.Skip(indexCaseId + prefixOffset).ToArray());
                    var valueCaseId = vCaseId.ToValue();
                    if (valueCaseId is string vCaseIdValue) { ret.CaseId = vCaseIdValue; }
                    var indexEvidenceHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEvidenceHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEvidenceHash.Decode(bytes.Skip(indexEvidenceHash + prefixOffset).ToArray());
                    var valueEvidenceHash = vEvidenceHash.ToValue();
                    if (valueEvidenceHash is string vEvidenceHashValue) { ret.EvidenceHash = vEvidenceHashValue; }
                    var indexIpfsCid = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpfsCid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vIpfsCid.Decode(bytes.Skip(indexIpfsCid + prefixOffset).ToArray());
                    var valueIpfsCid = vIpfsCid.ToValue();
                    if (valueIpfsCid is string vIpfsCidValue) { ret.IpfsCid = vIpfsCidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUploader = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vUploader.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUploader = vUploader.ToValue();
                    if (valueUploader is Algorand.Address vUploaderValue) { ret.Uploader = vUploaderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    var indexStatus = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vStatus.Decode(bytes.Skip(indexStatus + prefixOffset).ToArray());
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is string vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrentCustodian = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCurrentCustodian.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCurrentCustodian = vCurrentCustodian.ToValue();
                    if (valueCurrentCustodian is Algorand.Address vCurrentCustodianValue) { ret.CurrentCustodian = vCurrentCustodianValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EvidenceRecord);
                }
                public bool Equals(EvidenceRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EvidenceRecord left, EvidenceRecord right)
                {
                    return EqualityComparer<EvidenceRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(EvidenceRecord left, EvidenceRecord right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class EvidenceRegisteredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 27, 37, 250, 220 };
                public const string Signature = "EvidenceRegistered(string,string,string,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string Field1 { get; set; }
                public string Field2 { get; set; }
                public string Field3 { get; set; }
                public Algorand.Address Field4 { get; set; }

                public static EvidenceRegisteredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new EvidenceRegisteredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(eventData.Skip(indexField1).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(eventData.Skip(indexField2).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
                    var indexField3 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.Decode(eventData.Skip(indexField3).ToArray());
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is string vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is Algorand.Address vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

            }

            public class CustodyTransferredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 111, 6, 117, 155 };
                public const string Signature = "CustodyTransferred(string,address,address,string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public string Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }
                public Algorand.Address Field3 { get; set; }
                public string Field4 { get; set; }

                public static CustodyTransferredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new CustodyTransferredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(eventData.Skip(indexField1).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is Algorand.Address vField3Value) { ret.Field3 = vField3Value; }
                    var indexField4 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField4.Decode(eventData.Skip(indexField4).ToArray());
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is string vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Register a new evidence record on-chain.
        ///</summary>
        /// <param name="evidenceId">Unique evidence string identifier </param>
        /// <param name="caseId">Legal / investigation case identifier </param>
        /// <param name="evidenceHash">SHA-256 hash of original evidence file </param>
        /// <param name="ipfsCid">IPFS content identifier for off-chain evidence storage </param>
        public async Task RegisterEvidence(string evidenceId, string caseId, string evidenceHash, string ipfsCid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 143, 54, 70 };
            var evidenceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidenceIdAbi.From(evidenceId);
            var caseIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); caseIdAbi.From(caseId);
            var evidenceHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidenceHashAbi.From(evidenceHash);
            var ipfsCidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfsCidAbi.From(ipfsCid);

            var result = await base.CallApp(new List<object> { abiHandle, evidenceIdAbi, caseIdAbi, evidenceHashAbi, ipfsCidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterEvidence_Transactions(string evidenceId, string caseId, string evidenceHash, string ipfsCid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 143, 54, 70 };
            var evidenceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidenceIdAbi.From(evidenceId);
            var caseIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); caseIdAbi.From(caseId);
            var evidenceHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidenceHashAbi.From(evidenceHash);
            var ipfsCidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfsCidAbi.From(ipfsCid);

            return await base.MakeTransactionList(new List<object> { abiHandle, evidenceIdAbi, caseIdAbi, evidenceHashAbi, ipfsCidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Retrieve a registered evidence record.
        ///</summary>
        /// <param name="evidenceId">Evidence identifier to lookup </param>
        public async Task<Structs.EvidenceRecord> GetEvidence(string evidenceId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 168, 63, 145 };
            var evidenceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidenceIdAbi.From(evidenceId);

            var result = await base.SimApp(new List<object> { abiHandle, evidenceIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EvidenceRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetEvidence_Transactions(string evidenceId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 168, 63, 145 };
            var evidenceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidenceIdAbi.From(evidenceId);

            return await base.MakeTransactionList(new List<object> { abiHandle, evidenceIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify whether a supplied hash matches the registered evidence hash.
        ///</summary>
        /// <param name="evidenceId">Evidence identifier </param>
        /// <param name="providedHash">Cryptographic hash to verify </param>
        public async Task<bool> VerifyEvidence(string evidenceId, string providedHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 163, 105, 174 };
            var evidenceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidenceIdAbi.From(evidenceId);
            var providedHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); providedHashAbi.From(providedHash);

            var result = await base.SimApp(new List<object> { abiHandle, evidenceIdAbi, providedHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyEvidence_Transactions(string evidenceId, string providedHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 163, 105, 174 };
            var evidenceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidenceIdAbi.From(evidenceId);
            var providedHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); providedHashAbi.From(providedHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, evidenceIdAbi, providedHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer evidence custody to a new custodian.
        ///Authorization Rule: Txn.sender MUST BE currentCustodian ONLY.
        ///</summary>
        /// <param name="evidenceId">Evidence identifier </param>
        /// <param name="newCustodian">Algorand address of new custodian </param>
        /// <param name="actionReason">Reason for custody transfer </param>
        public async Task TransferCustody(string evidenceId, Algorand.Address newCustodian, string actionReason, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 83, 150, 49 };
            var evidenceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidenceIdAbi.From(evidenceId);
            var newCustodianAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newCustodianAbi.From(newCustodian);
            var actionReasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); actionReasonAbi.From(actionReason);

            var result = await base.CallApp(new List<object> { abiHandle, evidenceIdAbi, newCustodianAbi, actionReasonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferCustody_Transactions(string evidenceId, Algorand.Address newCustodian, string actionReason, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 83, 150, 49 };
            var evidenceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidenceIdAbi.From(evidenceId);
            var newCustodianAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newCustodianAbi.From(newCustodian);
            var actionReasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); actionReasonAbi.From(actionReason);

            return await base.MakeTransactionList(new List<object> { abiHandle, evidenceIdAbi, newCustodianAbi, actionReasonAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total custody transitions count for an evidence item.
        ///</summary>
        /// <param name="evidenceId">Evidence identifier </param>
        public async Task<ulong> GetCustodyCount(string evidenceId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 15, 2, 1 };
            var evidenceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidenceIdAbi.From(evidenceId);

            var result = await base.SimApp(new List<object> { abiHandle, evidenceIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCustodyCount_Transactions(string evidenceId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 15, 2, 1 };
            var evidenceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidenceIdAbi.From(evidenceId);

            return await base.MakeTransactionList(new List<object> { abiHandle, evidenceIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get specific custody transition entry by index.
        ///</summary>
        /// <param name="evidenceId">Evidence identifier </param>
        /// <param name="index">Transition index (0-based) </param>
        public async Task<Structs.CustodyRecord> GetCustodyEntry(string evidenceId, ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 133, 48, 11 };
            var evidenceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidenceIdAbi.From(evidenceId);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            var result = await base.SimApp(new List<object> { abiHandle, evidenceIdAbi, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.CustodyRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetCustodyEntry_Transactions(string evidenceId, ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 133, 48, 11 };
            var evidenceIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); evidenceIdAbi.From(evidenceId);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            return await base.MakeTransactionList(new List<object> { abiHandle, evidenceIdAbi, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXZpZGVuY2VSZWdpc3RyeSIsImRlc2MiOiJFdmlkZW5jZVJlZ2lzdHJ5IFNtYXJ0IENvbnRyYWN0XHJcbkJsb2NrY2hhaW4tcG93ZXJlZCBkaWdpdGFsIGV2aWRlbmNlIHByb3RlY3Rpb24gYW5kIHZlcmlmaWNhdGlvbiBwbGF0Zm9ybS4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ3VzdG9keVJlY29yZCI6W3sibmFtZSI6ImV2aWRlbmNlSWQiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZnJvbUN1c3RvZGlhbiIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidG9DdXN0b2RpYW4iLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhY3Rpb25SZWFzb24iLCJ0eXBlIjoic3RyaW5nIn1dLCJFdmlkZW5jZVJlY29yZCI6W3sibmFtZSI6ImV2aWRlbmNlSWQiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiY2FzZUlkIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImV2aWRlbmNlSGFzaCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJpcGZzQ2lkIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InVwbG9hZGVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJjcmVhdGVkQXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3RhdHVzIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImN1cnJlbnRDdXN0b2RpYW4iLCJ0eXBlIjoiYWRkcmVzcyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJyZWdpc3RlckV2aWRlbmNlIiwiZGVzYyI6IlJlZ2lzdGVyIGEgbmV3IGV2aWRlbmNlIHJlY29yZCBvbi1jaGFpbi4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXZpZGVuY2VJZCIsImRlc2MiOiJVbmlxdWUgZXZpZGVuY2Ugc3RyaW5nIGlkZW50aWZpZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhc2VJZCIsImRlc2MiOiJMZWdhbCAvIGludmVzdGlnYXRpb24gY2FzZSBpZGVudGlmaWVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldmlkZW5jZUhhc2giLCJkZXNjIjoiU0hBLTI1NiBoYXNoIG9mIG9yaWdpbmFsIGV2aWRlbmNlIGZpbGUiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlwZnNDaWQiLCJkZXNjIjoiSVBGUyBjb250ZW50IGlkZW50aWZpZXIgZm9yIG9mZi1jaGFpbiBldmlkZW5jZSBzdG9yYWdlIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJFdmlkZW5jZVJlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEV2aWRlbmNlIiwiZGVzYyI6IlJldHJpZXZlIGEgcmVnaXN0ZXJlZCBldmlkZW5jZSByZWNvcmQuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2aWRlbmNlSWQiLCJkZXNjIjoiRXZpZGVuY2UgaWRlbnRpZmllciB0byBsb29rdXAiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcsc3RyaW5nLHN0cmluZyxhZGRyZXNzLHVpbnQ2NCxzdHJpbmcsYWRkcmVzcykiLCJzdHJ1Y3QiOiJFdmlkZW5jZVJlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5RXZpZGVuY2UiLCJkZXNjIjoiVmVyaWZ5IHdoZXRoZXIgYSBzdXBwbGllZCBoYXNoIG1hdGNoZXMgdGhlIHJlZ2lzdGVyZWQgZXZpZGVuY2UgaGFzaC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXZpZGVuY2VJZCIsImRlc2MiOiJFdmlkZW5jZSBpZGVudGlmaWVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm92aWRlZEhhc2giLCJkZXNjIjoiQ3J5cHRvZ3JhcGhpYyBoYXNoIHRvIHZlcmlmeSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zZmVyQ3VzdG9keSIsImRlc2MiOiJUcmFuc2ZlciBldmlkZW5jZSBjdXN0b2R5IHRvIGEgbmV3IGN1c3RvZGlhbi5cclxuQXV0aG9yaXphdGlvbiBSdWxlOiBUeG4uc2VuZGVyIE1VU1QgQkUgY3VycmVudEN1c3RvZGlhbiBPTkxZLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldmlkZW5jZUlkIiwiZGVzYyI6IkV2aWRlbmNlIGlkZW50aWZpZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdDdXN0b2RpYW4iLCJkZXNjIjoiQWxnb3JhbmQgYWRkcmVzcyBvZiBuZXcgY3VzdG9kaWFuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY3Rpb25SZWFzb24iLCJkZXNjIjoiUmVhc29uIGZvciBjdXN0b2R5IHRyYW5zZmVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJDdXN0b2R5VHJhbnNmZXJyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDdXN0b2R5Q291bnQiLCJkZXNjIjoiR2V0IHRvdGFsIGN1c3RvZHkgdHJhbnNpdGlvbnMgY291bnQgZm9yIGFuIGV2aWRlbmNlIGl0ZW0uIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2aWRlbmNlSWQiLCJkZXNjIjoiRXZpZGVuY2UgaWRlbnRpZmllciIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0Q3VzdG9keUVudHJ5IiwiZGVzYyI6IkdldCBzcGVjaWZpYyBjdXN0b2R5IHRyYW5zaXRpb24gZW50cnkgYnkgaW5kZXguIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2aWRlbmNlSWQiLCJkZXNjIjoiRXZpZGVuY2UgaWRlbnRpZmllciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjoiVHJhbnNpdGlvbiBpbmRleCAoMC1iYXNlZCkiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxhZGRyZXNzLGFkZHJlc3MsdWludDY0LHN0cmluZykiLCJzdHJ1Y3QiOiJDdXN0b2R5UmVjb3JkIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzg0MSw5NjFdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxM10sImVycm9yTWVzc2FnZSI6IkN1c3RvZHkgZW50cnkgZG9lcyBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDhdLCJlcnJvck1lc3NhZ2UiOiJFdmlkZW5jZSByZWNvcmQgYWxyZWFkeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODksNTM1LDYxNCw5NTZdLCJlcnJvck1lc3NhZ2UiOiJFdmlkZW5jZSByZWNvcmQgZG9lcyBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzBdLCJlcnJvck1lc3NhZ2UiOiJOZXcgY3VzdG9kaWFuIG11c3QgYmUgZGlmZmVyZW50IGZyb20gY3VycmVudCBjdXN0b2RpYW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjZdLCJlcnJvck1lc3NhZ2UiOiJVbmF1dGhvcml6ZWQ6IFR4bi5zZW5kZXIgaXMgbm90IGN1cnJlbnQgY3VzdG9kaWFuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI0XSwiZXJyb3JNZXNzYWdlIjoiY2FzZUlkIGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOV0sImVycm9yTWVzc2FnZSI6ImV2aWRlbmNlSGFzaCBjYW5ub3QgYmUgZW1wdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTldLCJlcnJvck1lc3NhZ2UiOiJldmlkZW5jZUlkIGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyMCw3MTgsNzI1XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NiwxNzIsMTg4LDIwNCw0NzEsNTAzLDUxNiw1NjgsNTkzLDkzOCw5NzVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjYsMTgyLDE5OCwyMTQsNDc4LDUxMCw1MjMsNTc4LDYwMCw5NDUsOTgyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzNdLCJlcnJvck1lc3NhZ2UiOiJpcGZzQ2lkIGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTWlBd0lERWdPRElLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbVYyT2lJZ01IZ3hOVEZtTjJNM05TQWlZMk02SWlBaVkyZzZJaUF3ZURNd016RXpNak16TXpRek5UTTJNemN6T0RNNUlEQjRNREExTWlBd2VEQXdOR01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUlhacFpHVnVZMlZTWldkcGMzUnllU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE13b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE56VTRaak0yTkRZZ01IaGhOV0U0TTJZNU1TQXdlRGc1WVRNMk9XRmxJREI0TmpjMU16azJNekVnTUhoaFpqQm1NREl3TVNBd2VEUmxPRFV6TURCaUlDOHZJRzFsZEdodlpDQWljbVZuYVhOMFpYSkZkbWxrWlc1alpTaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBSWFpwWkdWdVkyVW9jM1J5YVc1bktTaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NZV1JrY21WemN5eDFhVzUwTmpRc2MzUnlhVzVuTEdGa1pISmxjM01wSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmxGZG1sa1pXNWpaU2h6ZEhKcGJtY3NjM1J5YVc1bktXSnZiMndpTENCdFpYUm9iMlFnSW5SeVlXNXpabVZ5UTNWemRHOWtlU2h6ZEhKcGJtY3NZV1JrY21WemN5eHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFEzVnpkRzlrZVVOdmRXNTBLSE4wY21sdVp5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRU4xYzNSdlpIbEZiblJ5ZVNoemRISnBibWNzZFdsdWREWTBLU2h6ZEhKcGJtY3NZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblEyTkN4emRISnBibWNwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2NtVm5hWE4wWlhKRmRtbGtaVzVqWlNCblpYUkZkbWxrWlc1alpTQjJaWEpwWm5sRmRtbGtaVzVqWlNCMGNtRnVjMlpsY2tOMWMzUnZaSGtnWjJWMFEzVnpkRzlrZVVOdmRXNTBJR2RsZEVOMWMzUnZaSGxGYm5SeWVRb2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1JYWnBaR1Z1WTJWU1pXZHBjM1J5ZVNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnY0hWNVlTMTBjem82YVhSdllTaHBPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BwZEc5aE9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUR3S0lDQWdJR0o2SUdsMGIyRmZaV3h6WlY5aWIyUjVRRElLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd6TURNeE16SXpNek0wTXpVek5qTTNNemd6T1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEpsZEhOMVlnb0thWFJ2WVY5bGJITmxYMkp2WkhsQU1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdMd29nSUNBZ1kyRnNiSE4xWWlCcGRHOWhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJQ1VLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd6TURNeE16SXpNek0wTXpVek5qTTNNemd6T1FvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmRtbGtaVzVqWlZKbFoybHpkSEo1TG5KbFoybHpkR1Z5UlhacFpHVnVZMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXZHBjM1JsY2tWMmFXUmxibU5sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalVLSUNBZ0lDOHZJR0Z6YzJWeWRDaGxkbWxrWlc1alpVbGtMbUo1ZEdWekxteGxibWQwYUNBK0lESXNJQ2RsZG1sa1pXNWpaVWxrSUdOaGJtNXZkQ0JpWlNCbGJYQjBlU2NwQ2lBZ0lDQmthV2NnTmdvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lENEtJQ0FnSUdGemMyVnlkQ0F2THlCbGRtbGtaVzVqWlVsa0lHTmhibTV2ZENCaVpTQmxiWEIwZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJR0Z6YzJWeWRDaGpZWE5sU1dRdVlubDBaWE11YkdWdVozUm9JRDRnTWl3Z0oyTmhjMlZKWkNCallXNXViM1FnWW1VZ1pXMXdkSGtuS1FvZ0lDQWdaR2xuSURRS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnpaVWxrSUdOaGJtNXZkQ0JpWlNCbGJYQjBlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklHRnpjMlZ5ZENobGRtbGtaVzVqWlVoaGMyZ3VZbmwwWlhNdWJHVnVaM1JvSUQ0Z01pd2dKMlYyYVdSbGJtTmxTR0Z6YUNCallXNXViM1FnWW1VZ1pXMXdkSGtuS1FvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z1pYWnBaR1Z1WTJWSVlYTm9JR05oYm01dmRDQmlaU0JsYlhCMGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUdGemMyVnlkQ2hwY0daelEybGtMbUo1ZEdWekxteGxibWQwYUNBK0lESXNJQ2RwY0daelEybGtJR05oYm01dmRDQmlaU0JsYlhCMGVTY3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdhWEJtYzBOcFpDQmpZVzV1YjNRZ1ltVWdaVzF3ZEhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUJqYjI1emRDQnBaRk4wY2lBOUlHVjJhV1JsYm1ObFNXUXVibUYwYVhabENpQWdJQ0JrYVdjZ053b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJsZG1sa1pXNWpaVkpsWTI5eVpITWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQkZkbWxrWlc1alpWSmxZMjl5WkQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RsZGpvbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmxkam9pQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxtVjJhV1JsYm1ObFVtVmpiM0prY3locFpGTjBjaWt1WlhocGMzUnpMQ0FuUlhacFpHVnVZMlVnY21WamIzSmtJR0ZzY21WaFpIa2daWGhwYzNSekp5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1JYWnBaR1Z1WTJVZ2NtVmpiM0prSUdGc2NtVmhaSGtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM013b2dJQ0FnTHk4Z1kyOXVjM1FnYzJWdVpHVnlRV1JrY2lBOUlHNWxkeUJoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamMwQ2lBZ0lDQXZMeUJqYjI1emRDQjBhVzFsYzNSaGJYQWdQU0J1WlhjZ1lYSmpOQzVWYVc1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0NrS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM0TFRnM0NpQWdJQ0F2THlCamIyNXpkQ0J5WldOdmNtUWdQU0J1WlhjZ1JYWnBaR1Z1WTJWU1pXTnZjbVFvZXdvZ0lDQWdMeThnSUNCbGRtbGtaVzVqWlVsa09pQmxkbWxrWlc1alpVbGtMQW9nSUNBZ0x5OGdJQ0JqWVhObFNXUTZJR05oYzJWSlpDd0tJQ0FnSUM4dklDQWdaWFpwWkdWdVkyVklZWE5vT2lCbGRtbGtaVzVqWlVoaGMyZ3NDaUFnSUNBdkx5QWdJR2x3Wm5ORGFXUTZJR2x3Wm5ORGFXUXNDaUFnSUNBdkx5QWdJSFZ3Ykc5aFpHVnlPaUJ6Wlc1a1pYSkJaR1J5TEFvZ0lDQWdMeThnSUNCamNtVmhkR1ZrUVhRNklIUnBiV1Z6ZEdGdGNDd0tJQ0FnSUM4dklDQWdjM1JoZEhWek9pQnBibWwwYVdGc1UzUmhkSFZ6TEFvZ0lDQWdMeThnSUNCamRYSnlaVzUwUTNWemRHOWthV0Z1T2lCelpXNWtaWEpCWkdSeUxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdsdWRHTmZNeUF2THlBNE1nb2dJQ0FnWkdsbklERXhDaUFnSUNBckNpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TURBMU1nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNVEFLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EVUtJQ0FnSUM4dklITjBZWFIxY3pvZ2FXNXBkR2xoYkZOMFlYUjFjeXdLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TUdFMU1qUTFORGMwT1RVek5UUTBOVFV5TkRVME5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpndE9EY0tJQ0FnSUM4dklHTnZibk4wSUhKbFkyOXlaQ0E5SUc1bGR5QkZkbWxrWlc1alpWSmxZMjl5WkNoN0NpQWdJQ0F2THlBZ0lHVjJhV1JsYm1ObFNXUTZJR1YyYVdSbGJtTmxTV1FzQ2lBZ0lDQXZMeUFnSUdOaGMyVkpaRG9nWTJGelpVbGtMQW9nSUNBZ0x5OGdJQ0JsZG1sa1pXNWpaVWhoYzJnNklHVjJhV1JsYm1ObFNHRnphQ3dLSUNBZ0lDOHZJQ0FnYVhCbWMwTnBaRG9nYVhCbWMwTnBaQ3dLSUNBZ0lDOHZJQ0FnZFhCc2IyRmtaWEk2SUhObGJtUmxja0ZrWkhJc0NpQWdJQ0F2THlBZ0lHTnlaV0YwWldSQmREb2dkR2x0WlhOMFlXMXdMQW9nSUNBZ0x5OGdJQ0J6ZEdGMGRYTTZJR2x1YVhScFlXeFRkR0YwZFhNc0NpQWdJQ0F2THlBZ0lHTjFjbkpsYm5SRGRYTjBiMlJwWVc0NklITmxibVJsY2tGa1pISXNDaUFnSUNBdkx5QjlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNQW9nSUNBZ0x5OGdkR2hwY3k1bGRtbGtaVzVqWlZKbFkyOXlaSE1vYVdSVGRISXBMblpoYkhWbElEMGdZMnh2Ym1Vb2NtVmpiM0prS1FvZ0lDQWdaR2xuSURNS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TXkwNU9Rb2dJQ0FnTHk4Z1kyOXVjM1FnYVc1cGRHbGhiRU4xYzNSdlpIa2dQU0J1WlhjZ1EzVnpkRzlrZVZKbFkyOXlaQ2g3Q2lBZ0lDQXZMeUFnSUdWMmFXUmxibU5sU1dRNklHVjJhV1JsYm1ObFNXUXNDaUFnSUNBdkx5QWdJR1p5YjIxRGRYTjBiMlJwWVc0NklITmxibVJsY2tGa1pISXNDaUFnSUNBdkx5QWdJSFJ2UTNWemRHOWthV0Z1T2lCelpXNWtaWEpCWkdSeUxBb2dJQ0FnTHk4Z0lDQjBhVzFsYzNSaGJYQTZJSFJwYldWemRHRnRjQ3dLSUNBZ0lDOHZJQ0FnWVdOMGFXOXVVbVZoYzI5dU9pQnVaWGNnWVhKak5DNVRkSElvSjBsT1NWUkpRVXhmVWtWSFNWTlVVa0ZVU1U5T0p5a3NDaUFnSUNBdkx5QjlLUW9nSUNBZ2NIVnphR2x1ZENBM05nb2dJQ0FnWkdsbklEY0tJQ0FnSUNzS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01EUmpDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RnS0lDQWdJQzh2SUdGamRHbHZibEpsWVhOdmJqb2dibVYzSUdGeVl6UXVVM1J5S0NkSlRrbFVTVUZNWDFKRlIwbFRWRkpCVkVsUFRpY3BMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF4TkRRNU5HVTBPVFUwTkRrME1UUmpOV1kxTWpRMU5EYzBPVFV6TlRRMU1qUXhOVFEwT1RSbU5HVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prekxUazVDaUFnSUNBdkx5QmpiMjV6ZENCcGJtbDBhV0ZzUTNWemRHOWtlU0E5SUc1bGR5QkRkWE4wYjJSNVVtVmpiM0prS0hzS0lDQWdJQzh2SUNBZ1pYWnBaR1Z1WTJWSlpEb2daWFpwWkdWdVkyVkpaQ3dLSUNBZ0lDOHZJQ0FnWm5KdmJVTjFjM1J2WkdsaGJqb2djMlZ1WkdWeVFXUmtjaXdLSUNBZ0lDOHZJQ0FnZEc5RGRYTjBiMlJwWVc0NklITmxibVJsY2tGa1pISXNDaUFnSUNBdkx5QWdJSFJwYldWemRHRnRjRG9nZEdsdFpYTjBZVzF3TEFvZ0lDQWdMeThnSUNCaFkzUnBiMjVTWldGemIyNDZJRzVsZHlCaGNtTTBMbE4wY2lnblNVNUpWRWxCVEY5U1JVZEpVMVJTUVZSSlQwNG5LU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEyQ2lBZ0lDQXZMeUJqZFhOMGIyUjVRMjkxYm5SeklEMGdRbTk0VFdGd1BITjBjbWx1Wnl3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dKMk5qT2ljZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltTmpPaUlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TVFvZ0lDQWdMeThnZEdocGN5NWpkWE4wYjJSNVEyOTFiblJ6S0dsa1UzUnlLUzUyWVd4MVpTQTlJRlZwYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNZ29nSUNBZ0x5OGdZMjl1YzNRZ1kzVnpkRzlrZVV0bGVTQTlJR2xrVTNSeUlDc2dKem93SndvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqb3dJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdZM1Z6ZEc5a2VWSmxZMjl5WkhNZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCRGRYTjBiMlI1VW1WamIzSmtQaWg3SUd0bGVWQnlaV1pwZURvZ0oyTm9PaWNnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1Ob09pSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXpDaUFnSUNBdkx5QjBhR2x6TG1OMWMzUnZaSGxTWldOdmNtUnpLR04xYzNSdlpIbExaWGtwTG5aaGJIVmxJRDBnWTJ4dmJtVW9hVzVwZEdsaGJFTjFjM1J2WkhrcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTJDaUFnSUNBdkx5QmxiV2wwS0NkRmRtbGtaVzVqWlZKbFoybHpkR1Z5WldRbkxDQmxkbWxrWlc1alpVbGtMQ0JqWVhObFNXUXNJR1YyYVdSbGJtTmxTR0Z6YUN3Z2MyVnVaR1Z5UVdSa2Npa0tJQ0FnSUhCMWMyaHBiblFnTXpnS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeU5nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREZpTWpWbVlXUmpJQzh2SUcxbGRHaHZaQ0FpUlhacFpHVnVZMlZTWldkcGMzUmxjbVZrS0hOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxHRmtaSEpsYzNNcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZkbWxrWlc1alpWSmxaMmx6ZEhKNUxtZGxkRVYyYVdSbGJtTmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFJYWnBaR1Z1WTJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UWUtJQ0FnSUM4dklHTnZibk4wSUdsa1UzUnlJRDBnWlhacFpHVnVZMlZKWkM1dVlYUnBkbVVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z1pYWnBaR1Z1WTJWU1pXTnZjbVJ6SUQwZ1FtOTRUV0Z3UEhOMGNtbHVaeXdnUlhacFpHVnVZMlZTWldOdmNtUStLSHNnYTJWNVVISmxabWw0T2lBblpYWTZKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWlhZNklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UY0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbVYyYVdSbGJtTmxVbVZqYjNKa2N5aHBaRk4wY2lrdVpYaHBjM1J6TENBblJYWnBaR1Z1WTJVZ2NtVmpiM0prSUdSdlpYTWdibTkwSUdWNGFYTjBKeWtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnUlhacFpHVnVZMlVnY21WamIzSmtJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRnS0lDQWdJQzh2SUhKbGRIVnliaUJqYkc5dVpTaDBhR2x6TG1WMmFXUmxibU5sVW1WamIzSmtjeWhwWkZOMGNpa3VkbUZzZFdVcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSWFpwWkdWdVkyVlNaV2RwYzNSeWVTNTJaWEpwWm5sRmRtbGtaVzVqWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVVWMmFXUmxibU5sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEk1Q2lBZ0lDQXZMeUJqYjI1emRDQnBaRk4wY2lBOUlHVjJhV1JsYm1ObFNXUXVibUYwYVhabENpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJR1YyYVdSbGJtTmxVbVZqYjNKa2N5QTlJRUp2ZUUxaGNEeHpkSEpwYm1jc0lFVjJhV1JsYm1ObFVtVmpiM0prUGloN0lHdGxlVkJ5WldacGVEb2dKMlYyT2ljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltVjJPaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE13Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1bGRtbGtaVzVqWlZKbFkyOXlaSE1vYVdSVGRISXBMbVY0YVhOMGN5d2dKMFYyYVdSbGJtTmxJSEpsWTI5eVpDQmtiMlZ6SUc1dmRDQmxlR2x6ZENjcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFVjJhV1JsYm1ObElISmxZMjl5WkNCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTXhMVEV6TWdvZ0lDQWdMeThnWTI5dWMzUWdjbVZqYjNKa0lEMGdZMnh2Ym1Vb2RHaHBjeTVsZG1sa1pXNWpaVkpsWTI5eVpITW9hV1JUZEhJcExuWmhiSFZsS1FvZ0lDQWdMeThnY21WMGRYSnVJSEpsWTI5eVpDNWxkbWxrWlc1alpVaGhjMmd1WW5sMFpYTWdQVDA5SUhCeWIzWnBaR1ZrU0dGemFDNWllWFJsY3dvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNZ29nSUNBZ0x5OGdjbVYwZFhKdUlISmxZMjl5WkM1bGRtbGtaVzVqWlVoaGMyZ3VZbmwwWlhNZ1BUMDlJSEJ5YjNacFpHVmtTR0Z6YUM1aWVYUmxjd29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYWnBaR1Z1WTJWU1pXZHBjM1J5ZVM1MGNtRnVjMlpsY2tOMWMzUnZaSGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMGNtRnVjMlpsY2tOMWMzUnZaSGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFE1Q2lBZ0lDQXZMeUJqYjI1emRDQnBaRk4wY2lBOUlHVjJhV1JsYm1ObFNXUXVibUYwYVhabENpQWdJQ0JrYVdjZ013b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJsZG1sa1pXNWpaVkpsWTI5eVpITWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQkZkbWxrWlc1alpWSmxZMjl5WkQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RsZGpvbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmxkam9pQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRBS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtVjJhV1JsYm1ObFVtVmpiM0prY3locFpGTjBjaWt1WlhocGMzUnpMQ0FuUlhacFpHVnVZMlVnY21WamIzSmtJR1J2WlhNZ2JtOTBJR1Y0YVhOMEp5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdSWFpwWkdWdVkyVWdjbVZqYjNKa0lHUnZaWE1nYm05MElHVjRhWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVEl0TVRVekNpQWdJQ0F2THlCamIyNXpkQ0J5WldOdmNtUWdQU0JqYkc5dVpTaDBhR2x6TG1WMmFXUmxibU5sVW1WamIzSmtjeWhwWkZOMGNpa3VkbUZzZFdVcENpQWdJQ0F2THlCamIyNXpkQ0JqZFhKeVpXNTBRM1Z6ZEc5a2FXRnVRV1JrY2lBOUlISmxZMjl5WkM1amRYSnlaVzUwUTNWemRHOWthV0Z1Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5SeklEVXdJRE15Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVM0NpQWdJQ0F2THlCVWVHNHVjMlZ1WkdWeUlEMDlQU0JqZFhKeVpXNTBRM1Z6ZEc5a2FXRnVRV1JrY2k1dVlYUnBkbVVzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU5pMHhOVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDZ0tJQ0FnSUM4dklDQWdWSGh1TG5ObGJtUmxjaUE5UFQwZ1kzVnljbVZ1ZEVOMWMzUnZaR2xoYmtGa1pISXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQW5WVzVoZFhSb2IzSnBlbVZrT2lCVWVHNHVjMlZ1WkdWeUlHbHpJRzV2ZENCamRYSnlaVzUwSUdOMWMzUnZaR2xoYmljc0NpQWdJQ0F2THlBcENpQWdJQ0JoYzNObGNuUWdMeThnVlc1aGRYUm9iM0pwZW1Wa09pQlVlRzR1YzJWdVpHVnlJR2x6SUc1dmRDQmpkWEp5Wlc1MElHTjFjM1J2WkdsaGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZeENpQWdJQ0F2THlCdVpYZERkWE4wYjJScFlXNHVZbmwwWlhNZ0lUMDlJR04xY25KbGJuUkRkWE4wYjJScFlXNUJaR1J5TG1KNWRHVnpMQW9nSUNBZ1pHbG5JRFFLSUNBZ0lDRTlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qQXRNVFl6Q2lBZ0lDQXZMeUJoYzNObGNuUW9DaUFnSUNBdkx5QWdJRzVsZDBOMWMzUnZaR2xoYmk1aWVYUmxjeUFoUFQwZ1kzVnljbVZ1ZEVOMWMzUnZaR2xoYmtGa1pISXVZbmwwWlhNc0NpQWdJQ0F2THlBZ0lDZE9aWGNnWTNWemRHOWthV0Z1SUcxMWMzUWdZbVVnWkdsbVptVnlaVzUwSUdaeWIyMGdZM1Z5Y21WdWRDQmpkWE4wYjJScFlXNG5MQW9nSUNBZ0x5OGdLUW9nSUNBZ1lYTnpaWEowSUM4dklFNWxkeUJqZFhOMGIyUnBZVzRnYlhWemRDQmlaU0JrYVdabVpYSmxiblFnWm5KdmJTQmpkWEp5Wlc1MElHTjFjM1J2WkdsaGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZMUNpQWdJQ0F2THlCamIyNXpkQ0J6Wlc1a1pYSkJaR1J5SUQwZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkyQ2lBZ0lDQXZMeUJqYjI1emRDQjBhVzFsYzNSaGJYQWdQU0J1WlhjZ1lYSmpOQzVWYVc1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0NrS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTVFvZ0lDQWdMeThnWlhacFpHVnVZMlZKWkRvZ2NtVmpiM0prTG1WMmFXUmxibU5sU1dRc0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHpJQzh2SURneUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHpJQzh2SURneUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56SUtJQ0FnSUM4dklHTmhjMlZKWkRvZ2NtVmpiM0prTG1OaGMyVkpaQ3dLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWkdsbklEUUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dOUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNd29nSUNBZ0x5OGdaWFpwWkdWdVkyVklZWE5vT2lCeVpXTnZjbVF1WlhacFpHVnVZMlZJWVhOb0xBb2dJQ0FnWkdsbklEUUtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dOUW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUEyQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGMwQ2lBZ0lDQXZMeUJwY0daelEybGtPaUJ5WldOdmNtUXVhWEJtYzBOcFpDd0tJQ0FnSUdScFp5QTFDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1pHbG5JRFlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTndvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTlFvZ0lDQWdMeThnZFhCc2IyRmtaWEk2SUhKbFkyOXlaQzUxY0d4dllXUmxjaXdLSUNBZ0lHUnBaeUEyQ2lBZ0lDQndkWE5vYVc1MGN5QTRJRE15Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjMkNpQWdJQ0F2THlCamNtVmhkR1ZrUVhRNklISmxZMjl5WkM1amNtVmhkR1ZrUVhRc0NpQWdJQ0JrYVdjZ053b2dJQ0FnY0hWemFHbHVkSE1nTkRBZ09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNQzB4TnprS0lDQWdJQzh2SUdOdmJuTjBJSFZ3WkdGMFpXUlNaV052Y21RZ1BTQnVaWGNnUlhacFpHVnVZMlZTWldOdmNtUW9ld29nSUNBZ0x5OGdJQ0JsZG1sa1pXNWpaVWxrT2lCeVpXTnZjbVF1WlhacFpHVnVZMlZKWkN3S0lDQWdJQzh2SUNBZ1kyRnpaVWxrT2lCeVpXTnZjbVF1WTJGelpVbGtMQW9nSUNBZ0x5OGdJQ0JsZG1sa1pXNWpaVWhoYzJnNklISmxZMjl5WkM1bGRtbGtaVzVqWlVoaGMyZ3NDaUFnSUNBdkx5QWdJR2x3Wm5ORGFXUTZJSEpsWTI5eVpDNXBjR1p6UTJsa0xBb2dJQ0FnTHk4Z0lDQjFjR3h2WVdSbGNqb2djbVZqYjNKa0xuVndiRzloWkdWeUxBb2dJQ0FnTHk4Z0lDQmpjbVZoZEdWa1FYUTZJSEpsWTI5eVpDNWpjbVZoZEdWa1FYUXNDaUFnSUNBdkx5QWdJSE4wWVhSMWN6b2dibVYzVTNSaGRIVnpMQW9nSUNBZ0x5OGdJQ0JqZFhKeVpXNTBRM1Z6ZEc5a2FXRnVPaUJ1WlhkRGRYTjBiMlJwWVc0c0NpQWdJQ0F2THlCOUtRb2dJQ0FnWkdsbklEVUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURneUNpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNREExTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05nb2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOQW9nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjM0NpQWdJQ0F2THlCemRHRjBkWE02SUc1bGQxTjBZWFIxY3l3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01UTTBNelUxTlRNMU5EUm1ORFExT1RWbU5UUTFNalF4TkdVMU16UTJORFUxTWpVeU5EVTBOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY3dMVEUzT1FvZ0lDQWdMeThnWTI5dWMzUWdkWEJrWVhSbFpGSmxZMjl5WkNBOUlHNWxkeUJGZG1sa1pXNWpaVkpsWTI5eVpDaDdDaUFnSUNBdkx5QWdJR1YyYVdSbGJtTmxTV1E2SUhKbFkyOXlaQzVsZG1sa1pXNWpaVWxrTEFvZ0lDQWdMeThnSUNCallYTmxTV1E2SUhKbFkyOXlaQzVqWVhObFNXUXNDaUFnSUNBdkx5QWdJR1YyYVdSbGJtTmxTR0Z6YURvZ2NtVmpiM0prTG1WMmFXUmxibU5sU0dGemFDd0tJQ0FnSUM4dklDQWdhWEJtYzBOcFpEb2djbVZqYjNKa0xtbHdabk5EYVdRc0NpQWdJQ0F2THlBZ0lIVndiRzloWkdWeU9pQnlaV052Y21RdWRYQnNiMkZrWlhJc0NpQWdJQ0F2THlBZ0lHTnlaV0YwWldSQmREb2djbVZqYjNKa0xtTnlaV0YwWldSQmRDd0tJQ0FnSUM4dklDQWdjM1JoZEhWek9pQnVaWGRUZEdGMGRYTXNDaUFnSUNBdkx5QWdJR04xY25KbGJuUkRkWE4wYjJScFlXNDZJRzVsZDBOMWMzUnZaR2xoYml3S0lDQWdJQzh2SUgwcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE1Rb2dJQ0FnTHk4Z2RHaHBjeTVsZG1sa1pXNWpaVkpsWTI5eVpITW9hV1JUZEhJcExuWmhiSFZsSUQwZ1kyeHZibVVvZFhCa1lYUmxaRkpsWTI5eVpDa0tJQ0FnSUdScFp5QXpDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklHTjFjM1J2WkhsRGIzVnVkSE1nUFNCQ2IzaE5ZWEE4YzNSeWFXNW5MQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lBblkyTTZKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWTJNNklnb2dJQ0FnWkdsbklETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzBDaUFnSUNBdkx5QmpiMjV6ZENCamRYSnlaVzUwUTI5MWJuUWdQU0IwYUdsekxtTjFjM1J2WkhsRGIzVnVkSE1vYVdSVGRISXBMblpoYkhWbENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RVS0lDQWdJQzh2SUdOdmJuTjBJR04xYzNSdlpIbExaWGtnUFNCcFpGTjBjaUFySUNjNkp5QXJJR04xY25KbGJuUkRiM1Z1ZEM1MGIxTjBjbWx1WnlncENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlPaUlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR05oYkd4emRXSWdhWFJ2WVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RjdE1Ua3pDaUFnSUNBdkx5QmpiMjV6ZENCamRYTjBiMlI1Ulc1MGNua2dQU0J1WlhjZ1EzVnpkRzlrZVZKbFkyOXlaQ2g3Q2lBZ0lDQXZMeUFnSUdWMmFXUmxibU5sU1dRNklHVjJhV1JsYm1ObFNXUXNDaUFnSUNBdkx5QWdJR1p5YjIxRGRYTjBiMlJwWVc0NklITmxibVJsY2tGa1pISXNDaUFnSUNBdkx5QWdJSFJ2UTNWemRHOWthV0Z1T2lCdVpYZERkWE4wYjJScFlXNHNDaUFnSUNBdkx5QWdJSFJwYldWemRHRnRjRG9nZEdsdFpYTjBZVzF3TEFvZ0lDQWdMeThnSUNCaFkzUnBiMjVTWldGemIyNDZJR0ZqZEdsdmJsSmxZWE52Yml3S0lDQWdJQzh2SUgwcENpQWdJQ0J3ZFhOb2FXNTBJRGMyQ2lBZ0lDQmthV2NnT0FvZ0lDQWdLd29nSUNBZ1lubDBaV01nTmlBdkx5QXdlREF3TkdNS0lDQWdJR1JwWnlBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTndvZ0lDQWdMeThnWTNWemRHOWtlVkpsWTI5eVpITWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQkRkWE4wYjJSNVVtVmpiM0prUGloN0lHdGxlVkJ5WldacGVEb2dKMk5vT2ljZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltTm9PaUlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9UVUtJQ0FnSUM4dklIUm9hWE11WTNWemRHOWtlVkpsWTI5eVpITW9ZM1Z6ZEc5a2VVdGxlU2t1ZG1Gc2RXVWdQU0JqYkc5dVpTaGpkWE4wYjJSNVJXNTBjbmtwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrMkNpQWdJQ0F2THlCMGFHbHpMbU4xYzNSdlpIbERiM1Z1ZEhNb2FXUlRkSElwTG5aaGJIVmxJRDBnWTNWeWNtVnVkRU52ZFc1MElDc2dWV2x1ZERZMEtERXBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrNUNpQWdJQ0F2THlCbGJXbDBLQ2REZFhOMGIyUjVWSEpoYm5ObVpYSnlaV1FuTENCbGRtbGtaVzVqWlVsa0xDQnpaVzVrWlhKQlpHUnlMQ0J1WlhkRGRYTjBiMlJwWVc0c0lHRmpkR2x2YmxKbFlYTnZiaWtLSUNBZ0lIQjFjMmhwYm5RZ05qZ0tJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdLd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREEwTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJaakEyTnpVNVlpQXZMeUJ0WlhSb2IyUWdJa04xYzNSdlpIbFVjbUZ1YzJabGNuSmxaQ2h6ZEhKcGJtY3NZV1JrY21WemN5eGhaR1J5WlhOekxITjBjbWx1WnlraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZkbWxrWlc1alpWSmxaMmx6ZEhKNUxtZGxkRU4xYzNSdlpIbERiM1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRU4xYzNSdlpIbERiM1Z1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd09Rb2dJQ0FnTHk4Z1kyOXVjM1FnYVdSVGRISWdQU0JsZG1sa1pXNWpaVWxrTG01aGRHbDJaUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMUNpQWdJQ0F2THlCbGRtbGtaVzVqWlZKbFkyOXlaSE1nUFNCQ2IzaE5ZWEE4YzNSeWFXNW5MQ0JGZG1sa1pXNWpaVkpsWTI5eVpENG9leUJyWlhsUWNtVm1hWGc2SUNkbGRqb25JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0psZGpvaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UQUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbVYyYVdSbGJtTmxVbVZqYjNKa2N5aHBaRk4wY2lrdVpYaHBjM1J6TENBblJYWnBaR1Z1WTJVZ2NtVmpiM0prSUdSdlpYTWdibTkwSUdWNGFYTjBKeWtLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVWMmFXUmxibU5sSUhKbFkyOXlaQ0JrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRZS0lDQWdJQzh2SUdOMWMzUnZaSGxEYjNWdWRITWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuWTJNNkp5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZMk02SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRFS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxtTjFjM1J2WkhsRGIzVnVkSE1vYVdSVGRISXBMblpoYkhWbENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEZkbWxrWlc1alpWSmxaMmx6ZEhKNUxtZGxkRU4xYzNSdlpIbEZiblJ5ZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRU4xYzNSdlpIbEZiblJ5ZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qSUtJQ0FnSUM4dklHTnZibk4wSUdsa1UzUnlJRDBnWlhacFpHVnVZMlZKWkM1dVlYUnBkbVVLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qTUtJQ0FnSUM4dklHTnZibk4wSUdOMWMzUnZaSGxMWlhrZ1BTQnBaRk4wY2lBcklDYzZKeUFySUdsdVpHVjRMblJ2VTNSeWFXNW5LQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlPaUlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQnBkRzloQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUJqZFhOMGIyUjVVbVZqYjNKa2N5QTlJRUp2ZUUxaGNEeHpkSEpwYm1jc0lFTjFjM1J2WkhsU1pXTnZjbVErS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZMmc2SnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVkyZzZJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNalFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1OMWMzUnZaSGxTWldOdmNtUnpLR04xYzNSdlpIbExaWGtwTG1WNGFYTjBjeXdnSjBOMWMzUnZaSGtnWlc1MGNua2daRzlsY3lCdWIzUWdaWGhwYzNRbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRkWE4wYjJSNUlHVnVkSEo1SUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qVUtJQ0FnSUM4dklISmxkSFZ5YmlCamJHOXVaU2gwYUdsekxtTjFjM1J2WkhsU1pXTnZjbVJ6S0dOMWMzUnZaSGxMWlhrcExuWmhiSFZsS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBZ0FCVWlZSEEyVjJPZ1FWSDN4MUEyTmpPZ05qYURvS01ERXlNelExTmpjNE9RSUFVZ0lBVERFYlFRQTVNUmtVUkRFWVJJSUdCSFdQTmtZRXBhZy9rUVNKbzJtdUJHZFRsakVFcnc4Q0FRUk9oVEFMTmhvQWpnWUFMd0ZxQVlvQnl3TTlBMklBTVJrVU1SZ1VFRU9LQVFHTC80RUtERUVBQnljRWkvOGtXSW1MLzRFS0Nvai81b3YvZ1FvWUp3Uk1KRmhRaVRZYUFVa2pXU0lJU3dFVlNVOENFa1EyR2dKSkkxa2lDRXNCRlVsUEFoSkVOaG9EU1NOWklnaExBUlZKVHdJU1JEWWFCRWtqV1NJSVN3RVZTVThDRWtSTEJpSU5SRXNFSWcxRVN3SWlEVVJKSWcxRVN3ZFhBZ0FvU3dGUVNiMUZBUlJFTVFBeUJ4WWxTd3NJU1JaWEJnSW5CVXhRVEVzS0NFa1dWd1lDVHdKTVVFeFBDQWhKRmxjR0FrOENURkJNVHdZSVRFc0RVRXNDVUV3V1Z3WUNVRXNDVUVzS1VFc0lVRXNHVUU4RlVJQU1BQXBTUlVkSlUxUkZVa1ZFVUVzRHZFaFBBMHkvZ1V4TEJ3Z25Ca3NEVUVzRFVFOENVRXdXVndZQ1VFc0hVSUFXQUJSSlRrbFVTVUZNWDFKRlIwbFRWRkpCVkVsUFRsQXFTd05RSkJhL1R3S0FBam93VUN0TVVFbThTRXkvZ1NaUEJRaEpGbGNHQW9BQ0FDWk1VRXhQQkFnV1Z3WUNVRXhRVHdOUVR3SlFURkNBQkJzbCt0eE1VTEFrUXpZYUFVa2pXU0lJU3dFVkVrUlhBZ0FvVEZCSnZVVUJSTDVJS1V4UXNDUkROaG9CU1NOWklnaExBUlVTUkRZYUFra2pXU0lJU3dFVkVrUk1Wd0lBS0V4UVNiMUZBVVJKZ1FRaXVoZEtJcm9YSWdpNkVvQUJBQ05QQWxRcFRGQ3dKRU0yR2dGSkkxa2lDRXNCRlVsUEFoSkVOaG9DU1JXQklCSkVOaG9EU1NOWklnaExBUlVTUkVzRFZ3SUFLRXNCVUVtOVJRRkVTWU1DTWlDNk1RQkxBUkpFU3dRVFJERUFNZ2NXU3dJbElyb1hJZ2hMQXlWUEFycExBeUpKdWhkTEJFc0JJcm9YSWdoTEJVNEN1a3NFZ1FRaXVoZExCVXNCSXJvWElnaExCazRDdWtzRmdRWWl1aGRMQmtzQklyb1hJZ2hMQjA0Q3Vrc0dnd0lJSUxwTEI0TUNLQWk2U3dVVkpRaEpGbGNHQWljRlRGQkxCaFZQQWdoSkZsY0dBazhDVEZCTEJSVlBBZ2hKRmxjR0FrOENURkJMQkJWUEFnaE1Ud05RVHdKUVRCWlhCZ0pRU3dwUVR3UlFUd05RVHdKUVRGQ0FGUUFUUTFWVFZFOUVXVjlVVWtGT1UwWkZVbEpGUkZCTEE3eElUd05NdnlwTEExQkp2a1FYVHdTQUFUcFFTd0dJL1J0UWdVeExDQWduQmtzR1VFc0lVRThGVUV3V1Z3WUNVRXNJVUVzRlVDdFBBbEJKdkVoTXZ5UUlGcitCUkU4RUNJQUNBRVJQQWxCUEExQk1GbGNHQWxCUEFsQk1VSUFFYndaMW0weFFzQ1JETmhvQlNTTlpJZ2hMQVJVU1JGY0NBQ2hMQVZDOVJRRkVLa3hRdmtRWEZpbE1VTEFrUXpZYUFVa2pXU0lJU3dFVkVrUTJHZ0pKRllFSUVrUVhURmNDQUlBQk9sQk1pUHlFVUN0TVVFbTlSUUZFdmtncFRGQ3dKRU09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiRXZpZGVuY2VSZWdpc3RlcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDQiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkN1c3RvZHlUcmFuc2ZlcnJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
