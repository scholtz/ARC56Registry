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

namespace Arc56.Generated.shaikhafijulrehaman_ops.Evidencechain_by_blockchain.EvidenceRegistry_deab03aa
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXZpZGVuY2VSZWdpc3RyeSIsImRlc2MiOiJFdmlkZW5jZVJlZ2lzdHJ5IFNtYXJ0IENvbnRyYWN0XG5CbG9ja2NoYWluLXBvd2VyZWQgZGlnaXRhbCBldmlkZW5jZSBwcm90ZWN0aW9uIGFuZCB2ZXJpZmljYXRpb24gcGxhdGZvcm0uIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkN1c3RvZHlSZWNvcmQiOlt7Im5hbWUiOiJldmlkZW5jZUlkIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZyb21DdXN0b2RpYW4iLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InRvQ3VzdG9kaWFuIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJ0aW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYWN0aW9uUmVhc29uIiwidHlwZSI6InN0cmluZyJ9XSwiRXZpZGVuY2VSZWNvcmQiOlt7Im5hbWUiOiJldmlkZW5jZUlkIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImNhc2VJZCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJldmlkZW5jZUhhc2giLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiaXBmc0NpZCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ1cGxvYWRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiY3JlYXRlZEF0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXR1cyIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJjdXJyZW50Q3VzdG9kaWFuIiwidHlwZSI6ImFkZHJlc3MifV19LCJNZXRob2RzIjpbeyJuYW1lIjoicmVnaXN0ZXJFdmlkZW5jZSIsImRlc2MiOiJSZWdpc3RlciBhIG5ldyBldmlkZW5jZSByZWNvcmQgb24tY2hhaW4uIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2aWRlbmNlSWQiLCJkZXNjIjoiVW5pcXVlIGV2aWRlbmNlIHN0cmluZyBpZGVudGlmaWVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYXNlSWQiLCJkZXNjIjoiTGVnYWwgLyBpbnZlc3RpZ2F0aW9uIGNhc2UgaWRlbnRpZmllciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXZpZGVuY2VIYXNoIiwiZGVzYyI6IlNIQS0yNTYgaGFzaCBvZiBvcmlnaW5hbCBldmlkZW5jZSBmaWxlIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpcGZzQ2lkIiwiZGVzYyI6IklQRlMgY29udGVudCBpZGVudGlmaWVyIGZvciBvZmYtY2hhaW4gZXZpZGVuY2Ugc3RvcmFnZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRXZpZGVuY2VSZWdpc3RlcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRFdmlkZW5jZSIsImRlc2MiOiJSZXRyaWV2ZSBhIHJlZ2lzdGVyZWQgZXZpZGVuY2UgcmVjb3JkLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJldmlkZW5jZUlkIiwiZGVzYyI6IkV2aWRlbmNlIGlkZW50aWZpZXIgdG8gbG9va3VwIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsc3RyaW5nLHN0cmluZyxzdHJpbmcsYWRkcmVzcyx1aW50NjQsc3RyaW5nLGFkZHJlc3MpIiwic3RydWN0IjoiRXZpZGVuY2VSZWNvcmQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeUV2aWRlbmNlIiwiZGVzYyI6IlZlcmlmeSB3aGV0aGVyIGEgc3VwcGxpZWQgaGFzaCBtYXRjaGVzIHRoZSByZWdpc3RlcmVkIGV2aWRlbmNlIGhhc2guIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2aWRlbmNlSWQiLCJkZXNjIjoiRXZpZGVuY2UgaWRlbnRpZmllciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvdmlkZWRIYXNoIiwiZGVzYyI6IkNyeXB0b2dyYXBoaWMgaGFzaCB0byB2ZXJpZnkiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2ZlckN1c3RvZHkiLCJkZXNjIjoiVHJhbnNmZXIgZXZpZGVuY2UgY3VzdG9keSB0byBhIG5ldyBjdXN0b2RpYW4uXG5BdXRob3JpemF0aW9uIFJ1bGU6IFR4bi5zZW5kZXIgTVVTVCBCRSBjdXJyZW50Q3VzdG9kaWFuIE9OTFkuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2aWRlbmNlSWQiLCJkZXNjIjoiRXZpZGVuY2UgaWRlbnRpZmllciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0N1c3RvZGlhbiIsImRlc2MiOiJBbGdvcmFuZCBhZGRyZXNzIG9mIG5ldyBjdXN0b2RpYW4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjdGlvblJlYXNvbiIsImRlc2MiOiJSZWFzb24gZm9yIGN1c3RvZHkgdHJhbnNmZXIiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkN1c3RvZHlUcmFuc2ZlcnJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEN1c3RvZHlDb3VudCIsImRlc2MiOiJHZXQgdG90YWwgY3VzdG9keSB0cmFuc2l0aW9ucyBjb3VudCBmb3IgYW4gZXZpZGVuY2UgaXRlbS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXZpZGVuY2VJZCIsImRlc2MiOiJFdmlkZW5jZSBpZGVudGlmaWVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDdXN0b2R5RW50cnkiLCJkZXNjIjoiR2V0IHNwZWNpZmljIGN1c3RvZHkgdHJhbnNpdGlvbiBlbnRyeSBieSBpbmRleC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXZpZGVuY2VJZCIsImRlc2MiOiJFdmlkZW5jZSBpZGVudGlmaWVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmRleCIsImRlc2MiOiJUcmFuc2l0aW9uIGluZGV4ICgwLWJhc2VkKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoc3RyaW5nLGFkZHJlc3MsYWRkcmVzcyx1aW50NjQsc3RyaW5nKSIsInN0cnVjdCI6IkN1c3RvZHlSZWNvcmQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODQxLDk2MV0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDEzXSwiZXJyb3JNZXNzYWdlIjoiQ3VzdG9keSBlbnRyeSBkb2VzIG5vdCBleGlzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0OF0sImVycm9yTWVzc2FnZSI6IkV2aWRlbmNlIHJlY29yZCBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4OSw1MzUsNjE0LDk1Nl0sImVycm9yTWVzc2FnZSI6IkV2aWRlbmNlIHJlY29yZCBkb2VzIG5vdCBleGlzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzMF0sImVycm9yTWVzc2FnZSI6Ik5ldyBjdXN0b2RpYW4gbXVzdCBiZSBkaWZmZXJlbnQgZnJvbSBjdXJyZW50IGN1c3RvZGlhbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyNl0sImVycm9yTWVzc2FnZSI6IlVuYXV0aG9yaXplZDogVHhuLnNlbmRlciBpcyBub3QgY3VycmVudCBjdXN0b2RpYW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjRdLCJlcnJvck1lc3NhZ2UiOiJjYXNlSWQgY2Fubm90IGJlIGVtcHR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI5XSwiZXJyb3JNZXNzYWdlIjoiZXZpZGVuY2VIYXNoIGNhbm5vdCBiZSBlbXB0eSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxOV0sImVycm9yTWVzc2FnZSI6ImV2aWRlbmNlSWQgY2Fubm90IGJlIGVtcHR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjIwLDcxOCw3MjVdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU2LDE3MiwxODgsMjA0LDQ3MSw1MDMsNTE2LDU2OCw1OTMsOTM4LDk3NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NiwxODIsMTk4LDIxNCw0NzgsNTEwLDUyMyw1NzgsNjAwLDk0NSw5ODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk5MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzM10sImVycm9yTWVzc2FnZSI6ImlwZnNDaWQgY2Fubm90IGJlIGVtcHR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNaUF3SURFZ09ESUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltVjJPaUlnTUhneE5URm1OMk0zTlNBaVkyTTZJaUFpWTJnNklpQXdlRE13TXpFek1qTXpNelF6TlRNMk16Y3pPRE01SURCNE1EQTFNaUF3ZURBd05HTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdSWFpwWkdWdVkyVlNaV2RwYzNSeWVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TnpVNFpqTTJORFlnTUhoaE5XRTRNMlk1TVNBd2VEZzVZVE0yT1dGbElEQjROamMxTXprMk16RWdNSGhoWmpCbU1ESXdNU0F3ZURSbE9EVXpNREJpSUM4dklHMWxkR2h2WkNBaWNtVm5hWE4wWlhKRmRtbGtaVzVqWlNoemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFJYWnBaR1Z1WTJVb2MzUnlhVzVuS1NoemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc1lXUmtjbVZ6Y3l4MWFXNTBOalFzYzNSeWFXNW5MR0ZrWkhKbGMzTXBJaXdnYldWMGFHOWtJQ0oyWlhKcFpubEZkbWxrWlc1alpTaHpkSEpwYm1jc2MzUnlhVzVuS1dKdmIyd2lMQ0J0WlhSb2IyUWdJblJ5WVc1elptVnlRM1Z6ZEc5a2VTaHpkSEpwYm1jc1lXUmtjbVZ6Y3l4emRISnBibWNwZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwUTNWemRHOWtlVU52ZFc1MEtITjBjbWx1WnlsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRFTjFjM1J2WkhsRmJuUnllU2h6ZEhKcGJtY3NkV2x1ZERZMEtTaHpkSEpwYm1jc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUTJOQ3h6ZEhKcGJtY3BJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnY21WbmFYTjBaWEpGZG1sa1pXNWpaU0JuWlhSRmRtbGtaVzVqWlNCMlpYSnBabmxGZG1sa1pXNWpaU0IwY21GdWMyWmxja04xYzNSdlpIa2daMlYwUTNWemRHOWtlVU52ZFc1MElHZGxkRU4xYzNSdlpIbEZiblJ5ZVFvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUlhacFpHVnVZMlZTWldkcGMzUnllU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjSFY1WVMxMGN6bzZhWFJ2WVNocE9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncHBkRzloT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJRHdLSUNBZ0lHSjZJR2wwYjJGZlpXeHpaVjlpYjJSNVFESUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3pNRE14TXpJek16TTBNelV6TmpNM016Z3pPUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lISmxkSE4xWWdvS2FYUnZZVjlsYkhObFgySnZaSGxBTWpvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ0x3b2dJQ0FnWTJGc2JITjFZaUJwZEc5aENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lDVUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3pNRE14TXpJek16TTBNelV6TmpNM016Z3pPUW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBGZG1sa1pXNWpaVkpsWjJsemRISjVMbkpsWjJsemRHVnlSWFpwWkdWdVkyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldkcGMzUmxja1YyYVdSbGJtTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qVUtJQ0FnSUM4dklHRnpjMlZ5ZENobGRtbGtaVzVqWlVsa0xtSjVkR1Z6TG14bGJtZDBhQ0ErSURJc0lDZGxkbWxrWlc1alpVbGtJR05oYm01dmRDQmlaU0JsYlhCMGVTY3BDaUFnSUNCa2FXY2dOZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUQ0S0lDQWdJR0Z6YzJWeWRDQXZMeUJsZG1sa1pXNWpaVWxrSUdOaGJtNXZkQ0JpWlNCbGJYQjBlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklHRnpjMlZ5ZENoallYTmxTV1F1WW5sMFpYTXViR1Z1WjNSb0lENGdNaXdnSjJOaGMyVkpaQ0JqWVc1dWIzUWdZbVVnWlcxd2RIa25LUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnWTJGelpVbGtJR05oYm01dmRDQmlaU0JsYlhCMGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUdGemMyVnlkQ2hsZG1sa1pXNWpaVWhoYzJndVlubDBaWE11YkdWdVozUm9JRDRnTWl3Z0oyVjJhV1JsYm1ObFNHRnphQ0JqWVc1dWIzUWdZbVVnWlcxd2RIa25LUW9nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnWlhacFpHVnVZMlZJWVhOb0lHTmhibTV2ZENCaVpTQmxiWEIwZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamdLSUNBZ0lDOHZJR0Z6YzJWeWRDaHBjR1p6UTJsa0xtSjVkR1Z6TG14bGJtZDBhQ0ErSURJc0lDZHBjR1p6UTJsa0lHTmhibTV2ZENCaVpTQmxiWEIwZVNjcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z2FYQm1jME5wWkNCallXNXViM1FnWW1VZ1pXMXdkSGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QmpiMjV6ZENCcFpGTjBjaUE5SUdWMmFXUmxibU5sU1dRdWJtRjBhWFpsQ2lBZ0lDQmthV2NnTndvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTFDaUFnSUNBdkx5QmxkbWxrWlc1alpWSmxZMjl5WkhNZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCRmRtbGtaVzVqWlZKbFkyOXlaRDRvZXlCclpYbFFjbVZtYVhnNklDZGxkam9uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbGRqb2lDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdZWE56WlhKMEtDRjBhR2x6TG1WMmFXUmxibU5sVW1WamIzSmtjeWhwWkZOMGNpa3VaWGhwYzNSekxDQW5SWFpwWkdWdVkyVWdjbVZqYjNKa0lHRnNjbVZoWkhrZ1pYaHBjM1J6SnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUlhacFpHVnVZMlVnY21WamIzSmtJR0ZzY21WaFpIa2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTXdvZ0lDQWdMeThnWTI5dWMzUWdjMlZ1WkdWeVFXUmtjaUE5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QmpiMjV6ZENCMGFXMWxjM1JoYlhBZ1BTQnVaWGNnWVhKak5DNVZhVzUwTmpRb1IyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ2tLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzRMVGczQ2lBZ0lDQXZMeUJqYjI1emRDQnlaV052Y21RZ1BTQnVaWGNnUlhacFpHVnVZMlZTWldOdmNtUW9ld29nSUNBZ0x5OGdJQ0JsZG1sa1pXNWpaVWxrT2lCbGRtbGtaVzVqWlVsa0xBb2dJQ0FnTHk4Z0lDQmpZWE5sU1dRNklHTmhjMlZKWkN3S0lDQWdJQzh2SUNBZ1pYWnBaR1Z1WTJWSVlYTm9PaUJsZG1sa1pXNWpaVWhoYzJnc0NpQWdJQ0F2THlBZ0lHbHdabk5EYVdRNklHbHdabk5EYVdRc0NpQWdJQ0F2THlBZ0lIVndiRzloWkdWeU9pQnpaVzVrWlhKQlpHUnlMQW9nSUNBZ0x5OGdJQ0JqY21WaGRHVmtRWFE2SUhScGJXVnpkR0Z0Y0N3S0lDQWdJQzh2SUNBZ2MzUmhkSFZ6T2lCcGJtbDBhV0ZzVTNSaGRIVnpMQW9nSUNBZ0x5OGdJQ0JqZFhKeVpXNTBRM1Z6ZEc5a2FXRnVPaUJ6Wlc1a1pYSkJaR1J5TEFvZ0lDQWdMeThnZlNrS0lDQWdJR2x1ZEdOZk15QXZMeUE0TWdvZ0lDQWdaR2xuSURFeENpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNREExTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01UQUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RVS0lDQWdJQzh2SUhOMFlYUjFjem9nYVc1cGRHbGhiRk4wWVhSMWN5d0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNR0UxTWpRMU5EYzBPVFV6TlRRME5UVXlORFUwTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemd0T0RjS0lDQWdJQzh2SUdOdmJuTjBJSEpsWTI5eVpDQTlJRzVsZHlCRmRtbGtaVzVqWlZKbFkyOXlaQ2g3Q2lBZ0lDQXZMeUFnSUdWMmFXUmxibU5sU1dRNklHVjJhV1JsYm1ObFNXUXNDaUFnSUNBdkx5QWdJR05oYzJWSlpEb2dZMkZ6WlVsa0xBb2dJQ0FnTHk4Z0lDQmxkbWxrWlc1alpVaGhjMmc2SUdWMmFXUmxibU5sU0dGemFDd0tJQ0FnSUM4dklDQWdhWEJtYzBOcFpEb2dhWEJtYzBOcFpDd0tJQ0FnSUM4dklDQWdkWEJzYjJGa1pYSTZJSE5sYm1SbGNrRmtaSElzQ2lBZ0lDQXZMeUFnSUdOeVpXRjBaV1JCZERvZ2RHbHRaWE4wWVcxd0xBb2dJQ0FnTHk4Z0lDQnpkR0YwZFhNNklHbHVhWFJwWVd4VGRHRjBkWE1zQ2lBZ0lDQXZMeUFnSUdOMWNuSmxiblJEZFhOMGIyUnBZVzQ2SUhObGJtUmxja0ZrWkhJc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1Bb2dJQ0FnTHk4Z2RHaHBjeTVsZG1sa1pXNWpaVkpsWTI5eVpITW9hV1JUZEhJcExuWmhiSFZsSUQwZ1kyeHZibVVvY21WamIzSmtLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNeTA1T1FvZ0lDQWdMeThnWTI5dWMzUWdhVzVwZEdsaGJFTjFjM1J2WkhrZ1BTQnVaWGNnUTNWemRHOWtlVkpsWTI5eVpDaDdDaUFnSUNBdkx5QWdJR1YyYVdSbGJtTmxTV1E2SUdWMmFXUmxibU5sU1dRc0NpQWdJQ0F2THlBZ0lHWnliMjFEZFhOMGIyUnBZVzQ2SUhObGJtUmxja0ZrWkhJc0NpQWdJQ0F2THlBZ0lIUnZRM1Z6ZEc5a2FXRnVPaUJ6Wlc1a1pYSkJaR1J5TEFvZ0lDQWdMeThnSUNCMGFXMWxjM1JoYlhBNklIUnBiV1Z6ZEdGdGNDd0tJQ0FnSUM4dklDQWdZV04wYVc5dVVtVmhjMjl1T2lCdVpYY2dZWEpqTkM1VGRISW9KMGxPU1ZSSlFVeGZVa1ZIU1ZOVVVrRlVTVTlPSnlrc0NpQWdJQ0F2THlCOUtRb2dJQ0FnY0hWemFHbHVkQ0EzTmdvZ0lDQWdaR2xuSURjS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TURSakNpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVGdLSUNBZ0lDOHZJR0ZqZEdsdmJsSmxZWE52YmpvZ2JtVjNJR0Z5WXpRdVUzUnlLQ2RKVGtsVVNVRk1YMUpGUjBsVFZGSkJWRWxQVGljcExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXhORFE1TkdVME9UVTBORGswTVRSak5XWTFNalExTkRjME9UVXpOVFExTWpReE5UUTBPVFJtTkdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt6TFRrNUNpQWdJQ0F2THlCamIyNXpkQ0JwYm1sMGFXRnNRM1Z6ZEc5a2VTQTlJRzVsZHlCRGRYTjBiMlI1VW1WamIzSmtLSHNLSUNBZ0lDOHZJQ0FnWlhacFpHVnVZMlZKWkRvZ1pYWnBaR1Z1WTJWSlpDd0tJQ0FnSUM4dklDQWdabkp2YlVOMWMzUnZaR2xoYmpvZ2MyVnVaR1Z5UVdSa2Npd0tJQ0FnSUM4dklDQWdkRzlEZFhOMGIyUnBZVzQ2SUhObGJtUmxja0ZrWkhJc0NpQWdJQ0F2THlBZ0lIUnBiV1Z6ZEdGdGNEb2dkR2x0WlhOMFlXMXdMQW9nSUNBZ0x5OGdJQ0JoWTNScGIyNVNaV0Z6YjI0NklHNWxkeUJoY21NMExsTjBjaWduU1U1SlZFbEJURjlTUlVkSlUxUlNRVlJKVDA0bktTd0tJQ0FnSUM4dklIMHBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTJDaUFnSUNBdkx5QmpkWE4wYjJSNVEyOTFiblJ6SUQwZ1FtOTRUV0Z3UEhOMGNtbHVaeXdnZFdsdWREWTBQaWg3SUd0bGVWQnlaV1pwZURvZ0oyTmpPaWNnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1Oak9pSUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNUW9nSUNBZ0x5OGdkR2hwY3k1amRYTjBiMlI1UTI5MWJuUnpLR2xrVTNSeUtTNTJZV3gxWlNBOUlGVnBiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd01nb2dJQ0FnTHk4Z1kyOXVjM1FnWTNWemRHOWtlVXRsZVNBOUlHbGtVM1J5SUNzZ0p6b3dKd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWpvd0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME53b2dJQ0FnTHk4Z1kzVnpkRzlrZVZKbFkyOXlaSE1nUFNCQ2IzaE5ZWEE4YzNSeWFXNW5MQ0JEZFhOMGIyUjVVbVZqYjNKa1BpaDdJR3RsZVZCeVpXWnBlRG9nSjJOb09pY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbU5vT2lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBekNpQWdJQ0F2THlCMGFHbHpMbU4xYzNSdlpIbFNaV052Y21SektHTjFjM1J2WkhsTFpYa3BMblpoYkhWbElEMGdZMnh2Ym1Vb2FXNXBkR2xoYkVOMWMzUnZaSGtwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMkNpQWdJQ0F2THlCbGJXbDBLQ2RGZG1sa1pXNWpaVkpsWjJsemRHVnlaV1FuTENCbGRtbGtaVzVqWlVsa0xDQmpZWE5sU1dRc0lHVjJhV1JsYm1ObFNHRnphQ3dnYzJWdVpHVnlRV1JrY2lrS0lDQWdJSEIxYzJocGJuUWdNemdLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF5TmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERmlNalZtWVdSaklDOHZJRzFsZEdodlpDQWlSWFpwWkdWdVkyVlNaV2RwYzNSbGNtVmtLSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEdGa1pISmxjM01wSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmRtbGtaVzVqWlZKbFoybHpkSEo1TG1kbGRFVjJhV1JsYm1ObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwUlhacFpHVnVZMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRZS0lDQWdJQzh2SUdOdmJuTjBJR2xrVTNSeUlEMGdaWFpwWkdWdVkyVkpaQzV1WVhScGRtVUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnWlhacFpHVnVZMlZTWldOdmNtUnpJRDBnUW05NFRXRndQSE4wY21sdVp5d2dSWFpwWkdWdVkyVlNaV052Y21RK0tIc2dhMlY1VUhKbFptbDRPaUFuWlhZNkp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaWFk2SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRjS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtVjJhV1JsYm1ObFVtVmpiM0prY3locFpGTjBjaWt1WlhocGMzUnpMQ0FuUlhacFpHVnVZMlVnY21WamIzSmtJR1J2WlhNZ2JtOTBJR1Y0YVhOMEp5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdSWFpwWkdWdVkyVWdjbVZqYjNKa0lHUnZaWE1nYm05MElHVjRhWE4wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVGdLSUNBZ0lDOHZJSEpsZEhWeWJpQmpiRzl1WlNoMGFHbHpMbVYyYVdSbGJtTmxVbVZqYjNKa2N5aHBaRk4wY2lrdWRtRnNkV1VwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlJYWnBaR1Z1WTJWU1pXZHBjM1J5ZVM1MlpYSnBabmxGZG1sa1pXNWpaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25abGNtbG1lVVYyYVdSbGJtTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTVDaUFnSUNBdkx5QmpiMjV6ZENCcFpGTjBjaUE5SUdWMmFXUmxibU5sU1dRdWJtRjBhWFpsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklHVjJhV1JsYm1ObFVtVmpiM0prY3lBOUlFSnZlRTFoY0R4emRISnBibWNzSUVWMmFXUmxibU5sVW1WamIzSmtQaWg3SUd0bGVWQnlaV1pwZURvZ0oyVjJPaWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WMk9pSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTXdDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVsZG1sa1pXNWpaVkpsWTI5eVpITW9hV1JUZEhJcExtVjRhWE4wY3l3Z0owVjJhV1JsYm1ObElISmxZMjl5WkNCa2IyVnpJRzV2ZENCbGVHbHpkQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVWMmFXUmxibU5sSUhKbFkyOXlaQ0JrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNeExURXpNZ29nSUNBZ0x5OGdZMjl1YzNRZ2NtVmpiM0prSUQwZ1kyeHZibVVvZEdocGN5NWxkbWxrWlc1alpWSmxZMjl5WkhNb2FXUlRkSElwTG5aaGJIVmxLUW9nSUNBZ0x5OGdjbVYwZFhKdUlISmxZMjl5WkM1bGRtbGtaVzVqWlVoaGMyZ3VZbmwwWlhNZ1BUMDlJSEJ5YjNacFpHVmtTR0Z6YUM1aWVYUmxjd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndNZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhKbFkyOXlaQzVsZG1sa1pXNWpaVWhoYzJndVlubDBaWE1nUFQwOUlIQnliM1pwWkdWa1NHRnphQzVpZVhSbGN3b2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UlhacFpHVnVZMlZTWldkcGMzUnllUzUwY21GdWMyWmxja04xYzNSdlpIbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwY21GdWMyWmxja04xYzNSdlpIazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ETUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTVDaUFnSUNBdkx5QmpiMjV6ZENCcFpGTjBjaUE5SUdWMmFXUmxibU5sU1dRdWJtRjBhWFpsQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTFDaUFnSUNBdkx5QmxkbWxrWlc1alpWSmxZMjl5WkhNZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCRmRtbGtaVzVqWlZKbFkyOXlaRDRvZXlCclpYbFFjbVZtYVhnNklDZGxkam9uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbGRqb2lDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1WMmFXUmxibU5sVW1WamIzSmtjeWhwWkZOMGNpa3VaWGhwYzNSekxDQW5SWFpwWkdWdVkyVWdjbVZqYjNKa0lHUnZaWE1nYm05MElHVjRhWE4wSnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1JYWnBaR1Z1WTJVZ2NtVmpiM0prSUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5USXRNVFV6Q2lBZ0lDQXZMeUJqYjI1emRDQnlaV052Y21RZ1BTQmpiRzl1WlNoMGFHbHpMbVYyYVdSbGJtTmxVbVZqYjNKa2N5aHBaRk4wY2lrdWRtRnNkV1VwQ2lBZ0lDQXZMeUJqYjI1emRDQmpkWEp5Wlc1MFEzVnpkRzlrYVdGdVFXUmtjaUE5SUhKbFkyOXlaQzVqZFhKeVpXNTBRM1Z6ZEc5a2FXRnVDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblJ6SURVd0lETXlDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFUzQ2lBZ0lDQXZMeUJVZUc0dWMyVnVaR1Z5SUQwOVBTQmpkWEp5Wlc1MFEzVnpkRzlrYVdGdVFXUmtjaTV1WVhScGRtVXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTmkweE5Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENnS0lDQWdJQzh2SUNBZ1ZIaHVMbk5sYm1SbGNpQTlQVDBnWTNWeWNtVnVkRU4xYzNSdlpHbGhia0ZrWkhJdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBblZXNWhkWFJvYjNKcGVtVmtPaUJVZUc0dWMyVnVaR1Z5SUdseklHNXZkQ0JqZFhKeVpXNTBJR04xYzNSdlpHbGhiaWNzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjM05sY25RZ0x5OGdWVzVoZFhSb2IzSnBlbVZrT2lCVWVHNHVjMlZ1WkdWeUlHbHpJRzV2ZENCamRYSnlaVzUwSUdOMWMzUnZaR2xoYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFl4Q2lBZ0lDQXZMeUJ1WlhkRGRYTjBiMlJwWVc0dVlubDBaWE1nSVQwOUlHTjFjbkpsYm5SRGRYTjBiMlJwWVc1QlpHUnlMbUo1ZEdWekxBb2dJQ0FnWkdsbklEUUtJQ0FnSUNFOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpBdE1UWXpDaUFnSUNBdkx5QmhjM05sY25Rb0NpQWdJQ0F2THlBZ0lHNWxkME4xYzNSdlpHbGhiaTVpZVhSbGN5QWhQVDBnWTNWeWNtVnVkRU4xYzNSdlpHbGhia0ZrWkhJdVlubDBaWE1zQ2lBZ0lDQXZMeUFnSUNkT1pYY2dZM1Z6ZEc5a2FXRnVJRzExYzNRZ1ltVWdaR2xtWm1WeVpXNTBJR1p5YjIwZ1kzVnljbVZ1ZENCamRYTjBiMlJwWVc0bkxBb2dJQ0FnTHk4Z0tRb2dJQ0FnWVhOelpYSjBJQzh2SUU1bGR5QmpkWE4wYjJScFlXNGdiWFZ6ZENCaVpTQmthV1ptWlhKbGJuUWdabkp2YlNCamRYSnlaVzUwSUdOMWMzUnZaR2xoYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkxQ2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhKQlpHUnlJRDBnYm1WM0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWTJDaUFnSUNBdkx5QmpiMjV6ZENCMGFXMWxjM1JoYlhBZ1BTQnVaWGNnWVhKak5DNVZhVzUwTmpRb1IyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ2tLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNNUW9nSUNBZ0x5OGdaWFpwWkdWdVkyVkpaRG9nY21WamIzSmtMbVYyYVdSbGJtTmxTV1FzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eklDOHZJRGd5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTXdvZ0lDQWdhVzUwWTE4eklDOHZJRGd5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpJS0lDQWdJQzh2SUdOaGMyVkpaRG9nY21WamIzSmtMbU5oYzJWSlpDd0tJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURRS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM013b2dJQ0FnTHk4Z1pYWnBaR1Z1WTJWSVlYTm9PaUJ5WldOdmNtUXVaWFpwWkdWdVkyVklZWE5vTEFvZ0lDQWdaR2xuSURRS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QTJDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJhV1JsYm1ObFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UYzBDaUFnSUNBdkx5QnBjR1p6UTJsa09pQnlaV052Y21RdWFYQm1jME5wWkN3S0lDQWdJR1JwWnlBMUNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWkdsbklEWUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dOd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNOUW9nSUNBZ0x5OGdkWEJzYjJGa1pYSTZJSEpsWTI5eVpDNTFjR3h2WVdSbGNpd0tJQ0FnSUdScFp5QTJDaUFnSUNCd2RYTm9hVzUwY3lBNElETXlDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGMyQ2lBZ0lDQXZMeUJqY21WaGRHVmtRWFE2SUhKbFkyOXlaQzVqY21WaGRHVmtRWFFzQ2lBZ0lDQmthV2NnTndvZ0lDQWdjSFZ6YUdsdWRITWdOREFnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM01DMHhOemtLSUNBZ0lDOHZJR052Ym5OMElIVndaR0YwWldSU1pXTnZjbVFnUFNCdVpYY2dSWFpwWkdWdVkyVlNaV052Y21Rb2V3b2dJQ0FnTHk4Z0lDQmxkbWxrWlc1alpVbGtPaUJ5WldOdmNtUXVaWFpwWkdWdVkyVkpaQ3dLSUNBZ0lDOHZJQ0FnWTJGelpVbGtPaUJ5WldOdmNtUXVZMkZ6WlVsa0xBb2dJQ0FnTHk4Z0lDQmxkbWxrWlc1alpVaGhjMmc2SUhKbFkyOXlaQzVsZG1sa1pXNWpaVWhoYzJnc0NpQWdJQ0F2THlBZ0lHbHdabk5EYVdRNklISmxZMjl5WkM1cGNHWnpRMmxrTEFvZ0lDQWdMeThnSUNCMWNHeHZZV1JsY2pvZ2NtVmpiM0prTG5Wd2JHOWhaR1Z5TEFvZ0lDQWdMeThnSUNCamNtVmhkR1ZrUVhRNklISmxZMjl5WkM1amNtVmhkR1ZrUVhRc0NpQWdJQ0F2THlBZ0lITjBZWFIxY3pvZ2JtVjNVM1JoZEhWekxBb2dJQ0FnTHk4Z0lDQmpkWEp5Wlc1MFEzVnpkRzlrYVdGdU9pQnVaWGREZFhOMGIyUnBZVzRzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdaR2xuSURVS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGd5Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1EQTFNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTmdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOUW9nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGMzQ2lBZ0lDQXZMeUJ6ZEdGMGRYTTZJRzVsZDFOMFlYUjFjeXdLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TVRNME16VTFOVE0xTkRSbU5EUTFPVFZtTlRRMU1qUXhOR1UxTXpRMk5EVTFNalV5TkRVME5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjd0xURTNPUW9nSUNBZ0x5OGdZMjl1YzNRZ2RYQmtZWFJsWkZKbFkyOXlaQ0E5SUc1bGR5QkZkbWxrWlc1alpWSmxZMjl5WkNoN0NpQWdJQ0F2THlBZ0lHVjJhV1JsYm1ObFNXUTZJSEpsWTI5eVpDNWxkbWxrWlc1alpVbGtMQW9nSUNBZ0x5OGdJQ0JqWVhObFNXUTZJSEpsWTI5eVpDNWpZWE5sU1dRc0NpQWdJQ0F2THlBZ0lHVjJhV1JsYm1ObFNHRnphRG9nY21WamIzSmtMbVYyYVdSbGJtTmxTR0Z6YUN3S0lDQWdJQzh2SUNBZ2FYQm1jME5wWkRvZ2NtVmpiM0prTG1sd1puTkRhV1FzQ2lBZ0lDQXZMeUFnSUhWd2JHOWhaR1Z5T2lCeVpXTnZjbVF1ZFhCc2IyRmtaWElzQ2lBZ0lDQXZMeUFnSUdOeVpXRjBaV1JCZERvZ2NtVmpiM0prTG1OeVpXRjBaV1JCZEN3S0lDQWdJQzh2SUNBZ2MzUmhkSFZ6T2lCdVpYZFRkR0YwZFhNc0NpQWdJQ0F2THlBZ0lHTjFjbkpsYm5SRGRYTjBiMlJwWVc0NklHNWxkME4xYzNSdlpHbGhiaXdLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TVFvZ0lDQWdMeThnZEdocGN5NWxkbWxrWlc1alpWSmxZMjl5WkhNb2FXUlRkSElwTG5aaGJIVmxJRDBnWTJ4dmJtVW9kWEJrWVhSbFpGSmxZMjl5WkNrS0lDQWdJR1JwWnlBekNpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRZS0lDQWdJQzh2SUdOMWMzUnZaSGxEYjNWdWRITWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQjFhVzUwTmpRK0tIc2dhMlY1VUhKbFptbDRPaUFuWTJNNkp5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZMk02SWdvZ0lDQWdaR2xuSURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMmFXUmxibU5sWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRnMENpQWdJQ0F2THlCamIyNXpkQ0JqZFhKeVpXNTBRMjkxYm5RZ1BTQjBhR2x6TG1OMWMzUnZaSGxEYjNWdWRITW9hV1JUZEhJcExuWmhiSFZsQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRFVLSUNBZ0lDOHZJR052Ym5OMElHTjFjM1J2WkhsTFpYa2dQU0JwWkZOMGNpQXJJQ2M2SnlBcklHTjFjbkpsYm5SRGIzVnVkQzUwYjFOMGNtbHVaeWdwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhCMWMyaGllWFJsY3lBaU9pSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTmhiR3h6ZFdJZ2FYUnZZUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRGN0TVRrekNpQWdJQ0F2THlCamIyNXpkQ0JqZFhOMGIyUjVSVzUwY25rZ1BTQnVaWGNnUTNWemRHOWtlVkpsWTI5eVpDaDdDaUFnSUNBdkx5QWdJR1YyYVdSbGJtTmxTV1E2SUdWMmFXUmxibU5sU1dRc0NpQWdJQ0F2THlBZ0lHWnliMjFEZFhOMGIyUnBZVzQ2SUhObGJtUmxja0ZrWkhJc0NpQWdJQ0F2THlBZ0lIUnZRM1Z6ZEc5a2FXRnVPaUJ1WlhkRGRYTjBiMlJwWVc0c0NpQWdJQ0F2THlBZ0lIUnBiV1Z6ZEdGdGNEb2dkR2x0WlhOMFlXMXdMQW9nSUNBZ0x5OGdJQ0JoWTNScGIyNVNaV0Z6YjI0NklHRmpkR2x2YmxKbFlYTnZiaXdLSUNBZ0lDOHZJSDBwQ2lBZ0lDQndkWE5vYVc1MElEYzJDaUFnSUNCa2FXY2dPQW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEQXdOR01LSUNBZ0lHUnBaeUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdZM1Z6ZEc5a2VWSmxZMjl5WkhNZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCRGRYTjBiMlI1VW1WamIzSmtQaWg3SUd0bGVWQnlaV1pwZURvZ0oyTm9PaWNnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1Ob09pSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RVS0lDQWdJQzh2SUhSb2FYTXVZM1Z6ZEc5a2VWSmxZMjl5WkhNb1kzVnpkRzlrZVV0bGVTa3VkbUZzZFdVZ1BTQmpiRzl1WlNoamRYTjBiMlI1Ulc1MGNua3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGsyQ2lBZ0lDQXZMeUIwYUdsekxtTjFjM1J2WkhsRGIzVnVkSE1vYVdSVGRISXBMblpoYkhWbElEMGdZM1Z5Y21WdWRFTnZkVzUwSUNzZ1ZXbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGs1Q2lBZ0lDQXZMeUJsYldsMEtDZERkWE4wYjJSNVZISmhibk5tWlhKeVpXUW5MQ0JsZG1sa1pXNWpaVWxrTENCelpXNWtaWEpCWkdSeUxDQnVaWGREZFhOMGIyUnBZVzRzSUdGamRHbHZibEpsWVhOdmJpa0tJQ0FnSUhCMWMyaHBiblFnTmpnS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ0t3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQTBOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMlpqQTJOelU1WWlBdkx5QnRaWFJvYjJRZ0lrTjFjM1J2WkhsVWNtRnVjMlpsY25KbFpDaHpkSEpwYm1jc1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhOMGNtbHVaeWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFF6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmRtbGtaVzVqWlZKbFoybHpkSEo1TG1kbGRFTjFjM1J2WkhsRGIzVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRFTjFjM1J2WkhsRGIzVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3T1FvZ0lDQWdMeThnWTI5dWMzUWdhV1JUZEhJZ1BTQmxkbWxrWlc1alpVbGtMbTVoZEdsMlpRb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1sa1pXNWpaVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUJsZG1sa1pXNWpaVkpsWTI5eVpITWdQU0JDYjNoTllYQThjM1J5YVc1bkxDQkZkbWxrWlc1alpWSmxZMjl5WkQ0b2V5QnJaWGxRY21WbWFYZzZJQ2RsZGpvbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmxkam9pQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRBS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtVjJhV1JsYm1ObFVtVmpiM0prY3locFpGTjBjaWt1WlhocGMzUnpMQ0FuUlhacFpHVnVZMlVnY21WamIzSmtJR1J2WlhNZ2JtOTBJR1Y0YVhOMEp5a0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRVYyYVdSbGJtTmxJSEpsWTI5eVpDQmtiMlZ6SUc1dmRDQmxlR2x6ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJR04xYzNSdlpIbERiM1Z1ZEhNZ1BTQkNiM2hOWVhBOGMzUnlhVzVuTENCMWFXNTBOalErS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZMk02SnlCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVkyTTZJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNVEVLSUNBZ0lDOHZJSEpsZEhWeWJpQjBhR2x6TG1OMWMzUnZaSGxEYjNWdWRITW9hV1JUZEhJcExuWmhiSFZsQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyYVdSbGJtTmxYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakEzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtbGtaVzVqWlY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRmRtbGtaVzVqWlZKbFoybHpkSEo1TG1kbGRFTjFjM1J2WkhsRmJuUnllVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRFTjFjM1J2WkhsRmJuUnllVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpJS0lDQWdJQzh2SUdOdmJuTjBJR2xrVTNSeUlEMGdaWFpwWkdWdVkyVkpaQzV1WVhScGRtVUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpNS0lDQWdJQzh2SUdOdmJuTjBJR04xYzNSdlpIbExaWGtnUFNCcFpGTjBjaUFySUNjNkp5QXJJR2x1WkdWNExuUnZVM1J5YVc1bktDa0tJQ0FnSUhCMWMyaGllWFJsY3lBaU9pSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCcGRHOWhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbWxrWlc1alpWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5QmpkWE4wYjJSNVVtVmpiM0prY3lBOUlFSnZlRTFoY0R4emRISnBibWNzSUVOMWMzUnZaSGxTWldOdmNtUStLSHNnYTJWNVVISmxabWw0T2lBblkyZzZKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWTJnNklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWnBaR1Z1WTJWZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qUUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbU4xYzNSdlpIbFNaV052Y21SektHTjFjM1J2WkhsTFpYa3BMbVY0YVhOMGN5d2dKME4xYzNSdlpIa2daVzUwY25rZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRGRYTjBiMlI1SUdWdWRISjVJR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhacFpHVnVZMlZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpVS0lDQWdJQzh2SUhKbGRIVnliaUJqYkc5dVpTaDBhR2x6TG1OMWMzUnZaSGxTWldOdmNtUnpLR04xYzNSdlpIbExaWGtwTG5aaGJIVmxLUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpwWkdWdVkyVmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNakFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFnQUJVaVlIQTJWMk9nUVZIM3gxQTJOak9nTmphRG9LTURFeU16UTFOamM0T1FJQVVnSUFUREViUVFBNU1Sa1VSREVZUklJR0JIV1BOa1lFcGFnL2tRU0pvMm11QkdkVGxqRUVydzhDQVFST2hUQUxOaG9BamdZQUx3RnFBWW9CeXdNOUEySUFNUmtVTVJnVUVFT0tBUUdMLzRFS0RFRUFCeWNFaS84a1dJbUwvNEVLQ29qLzVvdi9nUW9ZSndSTUpGaFFpVFlhQVVraldTSUlTd0VWU1U4Q0VrUTJHZ0pKSTFraUNFc0JGVWxQQWhKRU5ob0RTU05aSWdoTEFSVkpUd0lTUkRZYUJFa2pXU0lJU3dFVlNVOENFa1JMQmlJTlJFc0VJZzFFU3dJaURVUkpJZzFFU3dkWEFnQW9Td0ZRU2IxRkFSUkVNUUF5QnhZbFN3c0lTUlpYQmdJbkJVeFFURXNLQ0VrV1Z3WUNUd0pNVUV4UENBaEpGbGNHQWs4Q1RGQk1Ud1lJVEVzRFVFc0NVRXdXVndZQ1VFc0NVRXNLVUVzSVVFc0dVRThGVUlBTUFBcFNSVWRKVTFSRlVrVkVVRXNEdkVoUEEweS9nVXhMQndnbkJrc0RVRXNEVUU4Q1VFd1dWd1lDVUVzSFVJQVdBQlJKVGtsVVNVRk1YMUpGUjBsVFZGSkJWRWxQVGxBcVN3TlFKQmEvVHdLQUFqb3dVQ3RNVUVtOFNFeS9nU1pQQlFoSkZsY0dBb0FDQUNaTVVFeFBCQWdXVndZQ1VFeFFUd05RVHdKUVRGQ0FCQnNsK3R4TVVMQWtRellhQVVraldTSUlTd0VWRWtSWEFnQW9URkJKdlVVQlJMNUlLVXhRc0NSRE5ob0JTU05aSWdoTEFSVVNSRFlhQWtraldTSUlTd0VWRWtSTVZ3SUFLRXhRU2IxRkFVUkpnUVFpdWhkS0lyb1hJZ2k2RW9BQkFDTlBBbFFwVEZDd0pFTTJHZ0ZKSTFraUNFc0JGVWxQQWhKRU5ob0NTUldCSUJKRU5ob0RTU05aSWdoTEFSVVNSRXNEVndJQUtFc0JVRW05UlFGRVNZTUNNaUM2TVFCTEFSSkVTd1FUUkRFQU1nY1dTd0lsSXJvWElnaExBeVZQQXJwTEF5Skp1aGRMQkVzQklyb1hJZ2hMQlU0Q3Vrc0VnUVFpdWhkTEJVc0JJcm9YSWdoTEJrNEN1a3NGZ1FZaXVoZExCa3NCSXJvWElnaExCMDRDdWtzR2d3SUlJTHBMQjRNQ0tBaTZTd1VWSlFoSkZsY0dBaWNGVEZCTEJoVlBBZ2hKRmxjR0FrOENURkJMQlJWUEFnaEpGbGNHQWs4Q1RGQkxCQlZQQWdoTVR3TlFUd0pRVEJaWEJnSlFTd3BRVHdSUVR3TlFUd0pRVEZDQUZRQVRRMVZUVkU5RVdWOVVVa0ZPVTBaRlVsSkZSRkJMQTd4SVR3Tk12eXBMQTFCSnZrUVhUd1NBQVRwUVN3R0kvUnRRZ1V4TENBZ25Ca3NHVUVzSVVFOEZVRXdXVndZQ1VFc0lVRXNGVUN0UEFsQkp2RWhNdnlRSUZyK0JSRThFQ0lBQ0FFUlBBbEJQQTFCTUZsY0dBbEJQQWxCTVVJQUVid1oxbTB4UXNDUkROaG9CU1NOWklnaExBUlVTUkZjQ0FDaExBVkM5UlFGRUtreFF2a1FYRmlsTVVMQWtRellhQVVraldTSUlTd0VWRWtRMkdnSkpGWUVJRWtRWFRGY0NBSUFCT2xCTWlQeUVVQ3RNVUVtOVJRRkV2a2dwVEZDd0pFTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJFdmlkZW5jZVJlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQ3VzdG9keVRyYW5zZmVycmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ0IiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
