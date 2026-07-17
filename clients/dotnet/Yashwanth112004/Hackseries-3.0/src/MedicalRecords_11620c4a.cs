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

namespace Arc56.Generated.Yashwanth112004.Hackseries_3_0.MedicalRecords_11620c4a
{


    public class MedicalRecordsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MedicalRecordsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class PrescriptionQueueItem : AVMObjectType
            {
                public ulong RecordId { get; set; }

                public Algorand.Address Patient { get; set; }

                public string PatientName { get; set; }

                public string Cid { get; set; }

                public bool IsDispensed { get; set; }

                public ulong BillAmount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecordId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRecordId.From(RecordId);
                    ret.AddRange(vRecordId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPatient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPatient.From(Patient);
                    ret.AddRange(vPatient.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPatientName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPatientName.From(PatientName);
                    stringRef[ret.Count] = vPatientName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCid.From(Cid);
                    stringRef[ret.Count] = vCid.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsDispensed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsDispensed.From(IsDispensed);
                    ret.AddRange(vIsDispensed.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBillAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBillAmount.From(BillAmount);
                    ret.AddRange(vBillAmount.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PrescriptionQueueItem Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new PrescriptionQueueItem();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecordId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRecordId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRecordId = vRecordId.ToValue();
                    if (valueRecordId is ulong vRecordIdValue) { ret.RecordId = vRecordIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPatient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPatient.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePatient = vPatient.ToValue();
                    if (valuePatient is Algorand.Address vPatientValue) { ret.Patient = vPatientValue; }
                    var indexPatientName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPatientName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPatientName.Decode(bytes.Skip(indexPatientName + prefixOffset).ToArray());
                    var valuePatientName = vPatientName.ToValue();
                    if (valuePatientName is string vPatientNameValue) { ret.PatientName = vPatientNameValue; }
                    var indexCid = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCid.Decode(bytes.Skip(indexCid + prefixOffset).ToArray());
                    var valueCid = vCid.ToValue();
                    if (valueCid is string vCidValue) { ret.Cid = vCidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsDispensed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsDispensed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsDispensed = vIsDispensed.ToValue();
                    if (valueIsDispensed is bool vIsDispensedValue) { ret.IsDispensed = vIsDispensedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBillAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBillAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBillAmount = vBillAmount.ToValue();
                    if (valueBillAmount is ulong vBillAmountValue) { ret.BillAmount = vBillAmountValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PrescriptionQueueItem);
                }
                public bool Equals(PrescriptionQueueItem? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PrescriptionQueueItem left, PrescriptionQueueItem right)
                {
                    return EqualityComparer<PrescriptionQueueItem>.Default.Equals(left, right);
                }
                public static bool operator !=(PrescriptionQueueItem left, PrescriptionQueueItem right)
                {
                    return !(left == right);
                }

            }

            public class GetPatientRecordsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public Algorand.Address Field2 { get; set; }

                public string Field3 { get; set; }

                public string Field4 { get; set; }

                public ulong Field5 { get; set; }

                public ulong Field6 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.From(Field3);
                    stringRef[ret.Count] = vField3.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField4.From(Field4);
                    stringRef[ret.Count] = vField4.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static GetPatientRecordsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetPatientRecordsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    var indexField3 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.Decode(bytes.Skip(indexField3 + prefixOffset).ToArray());
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is string vField3Value) { ret.Field3 = vField3Value; }
                    var indexField4 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField4.Decode(bytes.Skip(indexField4 + prefixOffset).ToArray());
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is string vField4Value) { ret.Field4 = vField4Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is ulong vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is ulong vField6Value) { ret.Field6 = vField6Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetPatientRecordsReturn);
                }
                public bool Equals(GetPatientRecordsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetPatientRecordsReturn left, GetPatientRecordsReturn right)
                {
                    return EqualityComparer<GetPatientRecordsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetPatientRecordsReturn left, GetPatientRecordsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class RecordAddedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 18, 224, 13, 29 };
                public const string Signature = "RecordAdded(uint64,address,address,string,string,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }
                public Algorand.Address Field3 { get; set; }
                public string Field4 { get; set; }
                public string Field5 { get; set; }
                public ulong Field6 { get; set; }

                public static RecordAddedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RecordAddedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
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
                    var indexField5 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField5.Decode(eventData.Skip(indexField5).ToArray());
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is string vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is ulong vField6Value) { ret.Field6 = vField6Value; }
                    return ret;

                }

            }

            public class PrescriptionAddedToQueueEvent
            {
                public static readonly byte[] Selector = new byte[4] { 98, 83, 164, 118 };
                public const string Signature = "PrescriptionAddedToQueue(uint64,address,string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }
                public string Field3 { get; set; }

                public static PrescriptionAddedToQueueEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PrescriptionAddedToQueueEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    var indexField3 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.Decode(eventData.Skip(indexField3).ToArray());
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is string vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

            }

            public class PrescriptionDispensedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 224, 15, 10, 251 };
                public const string Signature = "PrescriptionDispensed(uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public ulong Field2 { get; set; }

                public static PrescriptionDispensedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new PrescriptionDispensedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
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
                    return ret;

                }

            }

        }

        ///<summary>
        ///Set the AuditLog app ID (called once after deploy).
        ///</summary>
        /// <param name="audit_app_id"> </param>
        public async Task Bootstrap(ulong audit_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 202, 223, 138 };
            var audit_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); audit_app_idAbi.From(audit_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, audit_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(ulong audit_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 202, 223, 138 };
            var audit_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); audit_app_idAbi.From(audit_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, audit_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Approved fiduciaries (Labs, Doctors, etc.) map a CID to a patient.
        ///</summary>
        /// <param name="patient"> </param>
        /// <param name="cid"> </param>
        /// <param name="record_type"> </param>
        /// <param name="bill_amount"> </param>
        public async Task AddRecord(Algorand.Address patient, string cid, string record_type, ulong bill_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 250, 190, 158 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cidAbi.From(cid);
            var record_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); record_typeAbi.From(record_type);
            var bill_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_amountAbi.From(bill_amount);

            var result = await base.CallApp(new List<object> { abiHandle, patientAbi, cidAbi, record_typeAbi, bill_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddRecord_Transactions(Algorand.Address patient, string cid, string record_type, ulong bill_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 250, 190, 158 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cidAbi.From(cid);
            var record_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); record_typeAbi.From(record_type);
            var bill_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_amountAbi.From(bill_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, patientAbi, cidAbi, record_typeAbi, bill_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add a prescription to the global queue and to the patient's record history.
        ///</summary>
        /// <param name="patient"> </param>
        /// <param name="patient_name"> </param>
        /// <param name="cid"> </param>
        public async Task AddPrescription(Algorand.Address patient, string patient_name, string cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 12, 242, 139 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var patient_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); patient_nameAbi.From(patient_name);
            var cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cidAbi.From(cid);

            var result = await base.CallApp(new List<object> { abiHandle, patientAbi, patient_nameAbi, cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddPrescription_Transactions(Algorand.Address patient, string patient_name, string cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 12, 242, 139 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var patient_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); patient_nameAbi.From(patient_name);
            var cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cidAbi.From(cid);

            return await base.MakeTransactionList(new List<object> { abiHandle, patientAbi, patient_nameAbi, cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return all prescription queue items that have not been dispensed.
        ///</summary>
        public async Task<Structs.PrescriptionQueueItem[]> GetPendingPrescriptions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 150, 107, 235 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.PrescriptionQueueItem>(x => Structs.PrescriptionQueueItem.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> GetPendingPrescriptions_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 150, 107, 235 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Mark a prescription as dispensed and update the bill amount.
        ///</summary>
        /// <param name="record_id"> </param>
        /// <param name="bill_amount"> </param>
        public async Task MarkPrescriptionDispensed(ulong record_id, ulong bill_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 53, 241, 40 };
            var record_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); record_idAbi.From(record_id);
            var bill_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_amountAbi.From(bill_amount);

            var result = await base.CallApp(new List<object> { abiHandle, record_idAbi, bill_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MarkPrescriptionDispensed_Transactions(ulong record_id, ulong bill_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 53, 241, 40 };
            var record_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); record_idAbi.From(record_id);
            var bill_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_amountAbi.From(bill_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, record_idAbi, bill_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return all records mapped to a patient's address.
        ///</summary>
        /// <param name="patient"> </param>
        public async Task<Structs.GetPatientRecordsReturn[]> GetPatientRecords(Algorand.Address patient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 73, 188, 244 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);

            var result = await base.SimApp(new List<object> { abiHandle, patientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.GetPatientRecordsReturn>(x => Structs.GetPatientRecordsReturn.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> GetPatientRecords_Transactions(Algorand.Address patient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 73, 188, 244 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);

            return await base.MakeTransactionList(new List<object> { abiHandle, patientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWVkaWNhbFJlY29yZHMiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUHJlc2NyaXB0aW9uUXVldWVJdGVtIjpbeyJuYW1lIjoicmVjb3JkX2lkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InBhdGllbnQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBhdGllbnRfbmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJjaWQiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiaXNfZGlzcGVuc2VkIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJiaWxsX2Ftb3VudCIsInR5cGUiOiJ1aW50NjQifV0sIkdldFBhdGllbnRSZWNvcmRzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOiJTZXQgdGhlIEF1ZGl0TG9nIGFwcCBJRCAoY2FsbGVkIG9uY2UgYWZ0ZXIgZGVwbG95KS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXVkaXRfYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZF9yZWNvcmQiLCJkZXNjIjoiQXBwcm92ZWQgZmlkdWNpYXJpZXMgKExhYnMsIERvY3RvcnMsIGV0Yy4pIG1hcCBhIENJRCB0byBhIHBhdGllbnQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXRpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY29yZF90eXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiaWxsX2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUmVjb3JkQWRkZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDYiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfcHJlc2NyaXB0aW9uIiwiZGVzYyI6IkFkZCBhIHByZXNjcmlwdGlvbiB0byB0aGUgZ2xvYmFsIHF1ZXVlIGFuZCB0byB0aGUgcGF0aWVudCdzIHJlY29yZCBoaXN0b3J5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudF9uYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlByZXNjcmlwdGlvbkFkZGVkVG9RdWV1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BlbmRpbmdfcHJlc2NyaXB0aW9ucyIsImRlc2MiOiJSZXR1cm4gYWxsIHByZXNjcmlwdGlvbiBxdWV1ZSBpdGVtcyB0aGF0IGhhdmUgbm90IGJlZW4gZGlzcGVuc2VkLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3Msc3RyaW5nLHN0cmluZyxib29sLHVpbnQ2NClbXSIsInN0cnVjdCI6IlByZXNjcmlwdGlvblF1ZXVlSXRlbSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFya19wcmVzY3JpcHRpb25fZGlzcGVuc2VkIiwiZGVzYyI6Ik1hcmsgYSBwcmVzY3JpcHRpb24gYXMgZGlzcGVuc2VkIGFuZCB1cGRhdGUgdGhlIGJpbGwgYW1vdW50LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNvcmRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJpbGxfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJQcmVzY3JpcHRpb25EaXNwZW5zZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BhdGllbnRfcmVjb3JkcyIsImRlc2MiOiJSZXR1cm4gYWxsIHJlY29yZHMgbWFwcGVkIHRvIGEgcGF0aWVudCdzIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXRpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxhZGRyZXNzLHN0cmluZyxzdHJpbmcsdWludDY0LHVpbnQ2NClbXSIsInN0cnVjdCI6IkdldFBhdGllbnRSZWNvcmRzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ1MCw3OThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmF1ZGl0X2FwcCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTgsNzY2LDEwOTAsMTM5Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucGF0aWVudF9yZWNvcmRzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzMSwxMDM5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wcmVzY3JpcHRpb25fcXVldWUgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI5LDkxMSwxMDE2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5xdWV1ZV9sZW5ndGggZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzUyLDUwOSw2MTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlY29yZF9jb3VudGVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNTAsMTIxN10sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzExLDMzMyw1ODUsNjAxLDExMjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjQsMzQwLDU5NSw2MTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAyLDU3NiwxMzc5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4NiwzNDgsMTAwNCwxMDEyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNaUE0Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0p5WldOZlkyOTFiblJsY2lJZ0luRmZiR1Z1SWlBd2VEY3dOekkxWmlBaVlYVmthWFJmWVhCd0lpQXdlREF3TURJZ01IZzNNRGN4TldZZ01IZ3dNRFZqSURCNFl6ZGlaR0kwTnpBZ01IZ3dNREF4TURBd01pQXdlREF3TURBZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPalF4Q2lBZ0lDQXZMeUJ6Wld4bUxuSmxZMjl5WkY5amIzVnVkR1Z5TG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p5WldOZlkyOTFiblJsY2lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPalU0Q2lBZ0lDQXZMeUJ6Wld4bUxuRjFaWFZsWDJ4bGJtZDBhQzUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWljVjlzWlc0aUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qTTNDaUFnSUNBdkx5QmpiR0Z6Y3lCTlpXUnBZMkZzVW1WamIzSmtjeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVFVLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR0V3WTJGa1pqaGhJREI0WVRWbVlXSmxPV1VnTUhobU1EQmpaakk0WWlBd2VEQXpPVFkyWW1WaUlEQjRZemN6TldZeE1qZ2dNSGczWkRRNVltTm1OQ0F2THlCdFpYUm9iMlFnSW1KdmIzUnpkSEpoY0NoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZV1JrWDNKbFkyOXlaQ2hoWkdSeVpYTnpMSE4wY21sdVp5eHpkSEpwYm1jc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZrWkY5d2NtVnpZM0pwY0hScGIyNG9ZV1JrY21WemN5eHpkSEpwYm1jc2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEY5d1pXNWthVzVuWDNCeVpYTmpjbWx3ZEdsdmJuTW9LU2gxYVc1ME5qUXNZV1JrY21WemN5eHpkSEpwYm1jc2MzUnlhVzVuTEdKdmIyd3NkV2x1ZERZMEtWdGRJaXdnYldWMGFHOWtJQ0p0WVhKclgzQnlaWE5qY21sd2RHbHZibDlrYVhOd1pXNXpaV1FvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZjR0YwYVdWdWRGOXlaV052Y21SektHRmtaSEpsYzNNcEtIVnBiblEyTkN4aFpHUnlaWE56TEdGa1pISmxjM01zYzNSeWFXNW5MSE4wY21sdVp5eDFhVzUwTmpRc2RXbHVkRFkwS1Z0ZElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZbTl2ZEhOMGNtRndJR0ZrWkY5eVpXTnZjbVFnWVdSa1gzQnlaWE5qY21sd2RHbHZiaUJuWlhSZmNHVnVaR2x1WjE5d2NtVnpZM0pwY0hScGIyNXpJRzFoY210ZmNISmxjMk55YVhCMGFXOXVYMlJwYzNCbGJuTmxaQ0JuWlhSZmNHRjBhV1Z1ZEY5eVpXTnZjbVJ6Q2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UVTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklGOXdkWGxoWDJ4cFlpNWhjbU0wTG1SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZENoaGNuSmhlVjlwZEdWdGMxOWpiM1Z1ZERvZ2RXbHVkRFkwTENCaGNuSmhlVjlvWldGa1gyRnVaRjkwWVdsc09pQmllWFJsY3l3Z2JtVjNYMmwwWlcxelgyTnZkVzUwT2lCMWFXNTBOalFzSUc1bGQxOW9aV0ZrWDJGdVpGOTBZV2xzT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZERvS0lDQWdJSEJ5YjNSdklEUWdNUW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ29LSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5SZlptOXlYMmhsWVdSbGNrQXhPZ29nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0E4Q2lBZ0lDQmllaUJrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5a2VXNWhiV2xqWDJWc1pXMWxiblJmWVdaMFpYSmZabTl5UURRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDaUFnSUNCaUlHUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOW1iM0pmYUdWaFpHVnlRREVLQ21SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5aFpuUmxjbDltYjNKQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYkdWdUNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFFLQ21SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5bWIzSmZhR1ZoWkdWeVFEVTZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJRHdLSUNBZ0lHSjZJR1I1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJSNWJtRnRhV05mWld4bGJXVnVkRjloWm5SbGNsOW1iM0pBT0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEUUtJQ0FnSUdJZ1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyWnZjbDlvWldGa1pYSkFOUW9LWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlpIbHVZVzFwWTE5bGJHVnRaVzUwWDJGbWRHVnlYMlp2Y2tBNE9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxrMWxaR2xqWVd4U1pXTnZjbVJ6TG1OdmJuUnlZV04wTGsxbFpHbGpZV3hTWldOdmNtUnpMbUp2YjNSemRISmhjRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21KdmIzUnpkSEpoY0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG8yTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZUV1ZrYVdOaGJGSmxZMjl5WkhNdlkyOXVkSEpoWTNRdWNIazZOak1LSUNBZ0lDOHZJSE5sYkdZdVlYVmthWFJmWVhCd0xuWmhiSFZsSUQwZ1lYVmthWFJmWVhCd1gybGtMbTVoZEdsMlpRb2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVlYVmthWFJmWVhCd0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxrMWxaR2xqWVd4U1pXTnZjbVJ6TG1OdmJuUnlZV04wTGsxbFpHbGpZV3hTWldOdmNtUnpMbUZrWkY5eVpXTnZjbVJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaFpHUmZjbVZqYjNKa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pZMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk56UUtJQ0FnSUM4dklITmxiR1l1Y21WamIzSmtYMk52ZFc1MFpYSXVkbUZzZFdVZ0t6MGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNtVmpYMk52ZFc1MFpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y21WamIzSmtYMk52ZFc1MFpYSWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTUNBdkx5QWljbVZqWDJOdmRXNTBaWElpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG8zTlFvZ0lDQWdMeThnYm05M0lEMGdiM0F1UjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRvM09Bb2dJQ0FnTHk4Z2FXUTlZWEpqTkM1VlNXNTBOalFvYzJWc1ppNXlaV052Y21SZlkyOTFiblJsY2k1MllXeDFaU2tzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZUV1ZrYVdOaGJGSmxZMjl5WkhNdlkyOXVkSEpoWTNRdWNIazZPREFLSUNBZ0lDOHZJSEJ5YjNacFpHVnlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG80TXdvZ0lDQWdMeThnZEdsdFpYTjBZVzF3UFdGeVl6UXVWVWx1ZERZMEtHNXZkeWtzQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1kyOTJaWElnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPamMzTFRnMUNpQWdJQ0F2THlCdVpYZGZjbVZqYjNKa0lEMGdVbVZqYjNKa0tBb2dJQ0FnTHk4Z0lDQWdJR2xrUFdGeVl6UXVWVWx1ZERZMEtITmxiR1l1Y21WamIzSmtYMk52ZFc1MFpYSXVkbUZzZFdVcExBb2dJQ0FnTHk4Z0lDQWdJSEJoZEdsbGJuUTljR0YwYVdWdWRDd0tJQ0FnSUM4dklDQWdJQ0J3Y205MmFXUmxjajFoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnWTJsa1BXTnBaQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTnZjbVJmZEhsd1pUMXlaV052Y21SZmRIbHdaU3dLSUNBZ0lDOHZJQ0FnSUNCMGFXMWxjM1JoYlhBOVlYSmpOQzVWU1c1ME5qUW9ibTkzS1N3S0lDQWdJQzh2SUNBZ0lDQmlhV3hzWDJGdGIzVnVkRDFpYVd4c1gyRnRiM1Z1ZEN3S0lDQWdJQzh2SUNrS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREF3TldNS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHbHVkQ0E1TWdvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qZzNDaUFnSUNBdkx5QnBaaUJ3WVhScFpXNTBJR2x1SUhObGJHWXVjR0YwYVdWdWRGOXlaV052Y21Sek9nb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEY3dOekkxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWVdSa1gzSmxZMjl5WkY5bGJITmxYMkp2WkhsQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pnNENpQWdJQ0F2THlCaGNuSWdQU0J6Wld4bUxuQmhkR2xsYm5SZmNtVmpiM0prYzF0d1lYUnBaVzUwWFM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CaGRHbGxiblJmY21WamIzSmtjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG80T1FvZ0lDQWdMeThnWVhKeUxtRndjR1Z1WkNodVpYZGZjbVZqYjNKa0xtTnZjSGtvS1NrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3TURJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPamt3Q2lBZ0lDQXZMeUJ6Wld4bUxuQmhkR2xsYm5SZmNtVmpiM0prYzF0d1lYUnBaVzUwWFNBOUlHRnljaTVqYjNCNUtDa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0NtRmtaRjl5WldOdmNtUmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2prMUxURXdNd29nSUNBZ0x5OGdJeUJNYjJjZ2RHOGdRWFZrYVhSTWIyY2dZMjl1ZEhKaFkzUWdkbWxoSUdsdWJtVnlJSFJ5WVc1ellXTjBhVzl1Q2lBZ0lDQXZMeUJoY21NMExtRmlhVjlqWVd4c0tBb2dJQ0FnTHk4Z0lDQWdJQ0pzYjJkZlpHRjBZVjloWTJObGMzTmxaQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNjM1J5YVc1bkxIVnBiblEyTkNsMmIybGtJaXdLSUNBZ0lDOHZJQ0FnSUNCd1lYUnBaVzUwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxOMGNtbHVaeWdpVlhCc2IyRmtaV1FnYm1WM0lISmxZMjl5WkNJcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0c1dmR5a3NDaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQVUZ3Y0d4cFkyRjBhVzl1S0hObGJHWXVZWFZrYVhSZllYQndMblpoYkhWbEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG81T1FvZ0lDQWdMeThnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFd01nb2dJQ0FnTHk4Z1lYQndYMmxrUFVGd2NHeHBZMkYwYVc5dUtITmxiR1l1WVhWa2FYUmZZWEJ3TG5aaGJIVmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmhkV1JwZEY5aGNIQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVhWa2FYUmZZWEJ3SUdWNGFYTjBjd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZUV1ZrYVdOaGJGSmxZMjl5WkhNdlkyOXVkSEpoWTNRdWNIazZPVFV0TVRBekNpQWdJQ0F2THlBaklFeHZaeUIwYnlCQmRXUnBkRXh2WnlCamIyNTBjbUZqZENCMmFXRWdhVzV1WlhJZ2RISmhibk5oWTNScGIyNEtJQ0FnSUM4dklHRnlZelF1WVdKcFgyTmhiR3dvQ2lBZ0lDQXZMeUFnSUNBZ0lteHZaMTlrWVhSaFgyRmpZMlZ6YzJWa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4emRISnBibWNzZFdsdWREWTBLWFp2YVdRaUxBb2dJQ0FnTHk4Z0lDQWdJSEJoZEdsbGJuUXNDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVVM1J5YVc1bktDSlZjR3h2WVdSbFpDQnVaWGNnY21WamIzSmtJaWtzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9ibTkzS1N3S0lDQWdJQzh2SUNBZ0lDQmhjSEJmYVdROVFYQndiR2xqWVhScGIyNG9jMlZzWmk1aGRXUnBkRjloY0hBdWRtRnNkV1VwTEFvZ0lDQWdMeThnS1FvZ0lDQWdZbmwwWldNZ055QXZMeUJ0WlhSb2IyUWdJbXh2WjE5a1lYUmhYMkZqWTJWemMyVmtLR0ZrWkhKbGMzTXNZV1JrY21WemN5eHpkSEpwYm1jc2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURZS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRBd0NpQWdJQ0F2THlCaGNtTTBMbE4wY21sdVp5Z2lWWEJzYjJGa1pXUWdibVYzSUhKbFkyOXlaQ0lwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeE16VTFOekEyWXpabU5qRTJORFkxTmpReU1EWmxOalUzTnpJd056STJOVFl6Tm1ZM01qWTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUbzVOUzB4TURNS0lDQWdJQzh2SUNNZ1RHOW5JSFJ2SUVGMVpHbDBURzluSUdOdmJuUnlZV04wSUhacFlTQnBibTVsY2lCMGNtRnVjMkZqZEdsdmJnb2dJQ0FnTHk4Z1lYSmpOQzVoWW1sZlkyRnNiQ2dLSUNBZ0lDOHZJQ0FnSUNBaWJHOW5YMlJoZEdGZllXTmpaWE56WldRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhOMGNtbHVaeXgxYVc1ME5qUXBkbTlwWkNJc0NpQWdJQ0F2THlBZ0lDQWdjR0YwYVdWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVRkSEpwYm1jb0lsVndiRzloWkdWa0lHNWxkeUJ5WldOdmNtUWlLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaHViM2NwTEFvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxQmNIQnNhV05oZEdsdmJpaHpaV3htTG1GMVpHbDBYMkZ3Y0M1MllXeDFaU2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qRXdPQW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNXlaV052Y21SZlkyOTFiblJsY2k1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWljbVZqWDJOdmRXNTBaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVmpiM0prWDJOdmRXNTBaWElnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1URXdDaUFnSUNBdkx5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZUV1ZrYVdOaGJGSmxZMjl5WkhNdlkyOXVkSEpoWTNRdWNIazZNVEExTFRFeE5Bb2dJQ0FnTHk4Z0l5QkZiV2wwSUVGU1F5MHlPQ0JsZG1WdWRBb2dJQ0FnTHk4Z1lYSmpOQzVsYldsMEtBb2dJQ0FnTHk4Z0lDQWdJQ0pTWldOdmNtUkJaR1JsWkNoMWFXNTBOalFzWVdSa2NtVnpjeXhoWkdSeVpYTnpMSE4wY21sdVp5eHpkSEpwYm1jc2RXbHVkRFkwS1NJc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNXlaV052Y21SZlkyOTFiblJsY2k1MllXeDFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2NHRjBhV1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lDQWdZMmxrTEFvZ0lDQWdMeThnSUNBZ0lISmxZMjl5WkY5MGVYQmxMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtHNXZkeWtzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURVMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaHBiblFnT0RRS0lDQWdJR1JwWnlBMkNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREV5WlRBd1pERmtJQzh2SUcxbGRHaHZaQ0FpVW1WamIzSmtRV1JrWldRb2RXbHVkRFkwTEdGa1pISmxjM01zWVdSa2NtVnpjeXh6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pZMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21Ga1pGOXlaV052Y21SZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk9USUtJQ0FnSUM4dklHRnljaUE5SUdGeVl6UXVSSGx1WVcxcFkwRnljbUY1VzFKbFkyOXlaRjBvYm1WM1gzSmxZMjl5WkM1amIzQjVLQ2twQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TURBd01UQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPamt6Q2lBZ0lDQXZMeUJ6Wld4bUxuQmhkR2xsYm5SZmNtVmpiM0prYzF0d1lYUnBaVzUwWFNBOUlHRnljaTVqYjNCNUtDa0tJQ0FnSUdScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdZaUJoWkdSZmNtVmpiM0prWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1TlpXUnBZMkZzVW1WamIzSmtjeTVqYjI1MGNtRmpkQzVOWldScFkyRnNVbVZqYjNKa2N5NWhaR1JmY0hKbGMyTnlhWEIwYVc5dVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZV1JrWDNCeVpYTmpjbWx3ZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRveE1UWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRveE1qUUtJQ0FnSUM4dklITmxiR1l1Y21WamIzSmtYMk52ZFc1MFpYSXVkbUZzZFdVZ0t6MGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNtVmpYMk52ZFc1MFpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y21WamIzSmtYMk52ZFc1MFpYSWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTUNBdkx5QWljbVZqWDJOdmRXNTBaWElpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94TWpVS0lDQWdJQzh2SUc1dmR5QTlJRzl3TGtkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1USTJDaUFnSUNBdkx5QnlaV05mYVdRZ1BTQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuSmxZMjl5WkY5amIzVnVkR1Z5TG5aaGJIVmxLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qRXlPQzB4TWprS0lDQWdJQzh2SUNNZ1FXUmtJSFJ2SUhCeVpYTmpjbWx3ZEdsdmJpQnhkV1YxWlNBb2EyVjVaV1FnWW5rZ2NYVmxkV1VnYVc1a1pYZ3BDaUFnSUNBdkx5QnhkV1YxWlY5cFpIZ2dQU0JoY21NMExsVkpiblEyTkNoelpXeG1MbkYxWlhWbFgyeGxibWQwYUM1MllXeDFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnhYMnhsYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXhkV1YxWlY5c1pXNW5kR2dnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRveE16QXRNVE0zQ2lBZ0lDQXZMeUJ6Wld4bUxuQnlaWE5qY21sd2RHbHZibDl4ZFdWMVpWdHhkV1YxWlY5cFpIaGRJRDBnVUhKbGMyTnlhWEIwYVc5dVVYVmxkV1ZKZEdWdEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTI5eVpGOXBaRDF5WldOZmFXUXNDaUFnSUNBdkx5QWdJQ0FnY0dGMGFXVnVkRDF3WVhScFpXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhCaGRHbGxiblJmYm1GdFpUMXdZWFJwWlc1MFgyNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ1kybGtQV05wWkN3S0lDQWdJQzh2SUNBZ0lDQnBjMTlrYVhOd1pXNXpaV1E5WVhKak5DNUNiMjlzS0VaaGJITmxLU3dLSUNBZ0lDOHZJQ0FnSUNCaWFXeHNYMkZ0YjNWdWREMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrdVkyOXdlU2dwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdScFp5QTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnT1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURNMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaHBiblFnTlRNS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1UTXdDaUFnSUNBdkx5QnpaV3htTG5CeVpYTmpjbWx3ZEdsdmJsOXhkV1YxWlZ0eGRXVjFaVjlwWkhoZElEMGdVSEpsYzJOeWFYQjBhVzl1VVhWbGRXVkpkR1Z0S0FvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURjd056RTFaZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRveE16QXRNVE0zQ2lBZ0lDQXZMeUJ6Wld4bUxuQnlaWE5qY21sd2RHbHZibDl4ZFdWMVpWdHhkV1YxWlY5cFpIaGRJRDBnVUhKbGMyTnlhWEIwYVc5dVVYVmxkV1ZKZEdWdEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTI5eVpGOXBaRDF5WldOZmFXUXNDaUFnSUNBdkx5QWdJQ0FnY0dGMGFXVnVkRDF3WVhScFpXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhCaGRHbGxiblJmYm1GdFpUMXdZWFJwWlc1MFgyNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ1kybGtQV05wWkN3S0lDQWdJQzh2SUNBZ0lDQnBjMTlrYVhOd1pXNXpaV1E5WVhKak5DNUNiMjlzS0VaaGJITmxLU3dLSUNBZ0lDOHZJQ0FnSUNCaWFXeHNYMkZ0YjNWdWREMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrdVkyOXdlU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFek9Bb2dJQ0FnTHk4Z2MyVnNaaTV4ZFdWMVpWOXNaVzVuZEdndWRtRnNkV1VnS3owZ1ZVbHVkRFkwS0RFcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTVNBdkx5QWljVjlzWlc0aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFME5Bb2dJQ0FnTHk4Z2NISnZkbWxrWlhJOVlYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qRTBOd29nSUNBZ0x5OGdkR2x0WlhOMFlXMXdQV0Z5WXpRdVZVbHVkRFkwS0c1dmR5a3NDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5MlpYSWdOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qRTBNQzB4TkRrS0lDQWdJQzh2SUNNZ1FXeHpieUJoWkdRZ2RHOGdjR0YwYVdWdWRDZHpJSEpsWTI5eVpDQm9hWE4wYjNKNUNpQWdJQ0F2THlCdVpYZGZjbVZqYjNKa0lEMGdVbVZqYjNKa0tBb2dJQ0FnTHk4Z0lDQWdJR2xrUFhKbFkxOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCd1lYUnBaVzUwUFhCaGRHbGxiblFzQ2lBZ0lDQXZMeUFnSUNBZ2NISnZkbWxrWlhJOVlYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnSUNBZ0lHTnBaRDFqYVdRc0NpQWdJQ0F2THlBZ0lDQWdjbVZqYjNKa1gzUjVjR1U5WVhKak5DNVRkSEpwYm1jb0lsQnlaWE5qY21sd2RHbHZiaUlwTEFvZ0lDQWdMeThnSUNBZ0lIUnBiV1Z6ZEdGdGNEMWhjbU0wTGxWSmJuUTJOQ2h1YjNjcExBb2dJQ0FnTHk4Z0lDQWdJR0pwYkd4ZllXMXZkVzUwUFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3dNRFZqQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJocGJuUWdPVElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRRNENpQWdJQ0F2THlCaWFXeHNYMkZ0YjNWdWREMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3hOREF0TVRRNUNpQWdJQ0F2THlBaklFRnNjMjhnWVdSa0lIUnZJSEJoZEdsbGJuUW5jeUJ5WldOdmNtUWdhR2x6ZEc5eWVRb2dJQ0FnTHk4Z2JtVjNYM0psWTI5eVpDQTlJRkpsWTI5eVpDZ0tJQ0FnSUM4dklDQWdJQ0JwWkQxeVpXTmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ2NHRjBhV1Z1ZEQxd1lYUnBaVzUwTEFvZ0lDQWdMeThnSUNBZ0lIQnliM1pwWkdWeVBXRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQmphV1E5WTJsa0xBb2dJQ0FnTHk4Z0lDQWdJSEpsWTI5eVpGOTBlWEJsUFdGeVl6UXVVM1J5YVc1bktDSlFjbVZ6WTNKcGNIUnBiMjRpS1N3S0lDQWdJQzh2SUNBZ0lDQjBhVzFsYzNSaGJYQTlZWEpqTkM1VlNXNTBOalFvYm05M0tTd0tJQ0FnSUM4dklDQWdJQ0JpYVd4c1gyRnRiM1Z1ZEQxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRRMkNpQWdJQ0F2THlCeVpXTnZjbVJmZEhsd1pUMWhjbU0wTGxOMGNtbHVaeWdpVUhKbGMyTnlhWEIwYVc5dUlpa3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREJqTlRBM01qWTFOek0yTXpjeU5qazNNRGMwTmprMlpqWmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1UUXdMVEUwT1FvZ0lDQWdMeThnSXlCQmJITnZJR0ZrWkNCMGJ5QndZWFJwWlc1MEozTWdjbVZqYjNKa0lHaHBjM1J2Y25rS0lDQWdJQzh2SUc1bGQxOXlaV052Y21RZ1BTQlNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdhV1E5Y21WalgybGtMQW9nSUNBZ0x5OGdJQ0FnSUhCaGRHbGxiblE5Y0dGMGFXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCd2NtOTJhV1JsY2oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ1kybGtQV05wWkN3S0lDQWdJQzh2SUNBZ0lDQnlaV052Y21SZmRIbHdaVDFoY21NMExsTjBjbWx1WnlnaVVISmxjMk55YVhCMGFXOXVJaWtzQ2lBZ0lDQXZMeUFnSUNBZ2RHbHRaWE4wWVcxd1BXRnlZelF1VlVsdWREWTBLRzV2ZHlrc0NpQWdJQ0F2THlBZ0lDQWdZbWxzYkY5aGJXOTFiblE5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3hOVEVLSUNBZ0lDOHZJR2xtSUhCaGRHbGxiblFnYVc0Z2MyVnNaaTV3WVhScFpXNTBYM0psWTI5eVpITTZDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROekEzTWpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCaFpHUmZjSEpsYzJOeWFYQjBhVzl1WDJWc2MyVmZZbTlrZVVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRVeUNpQWdJQ0F2THlCaGNuSWdQU0J6Wld4bUxuQmhkR2xsYm5SZmNtVmpiM0prYzF0d1lYUnBaVzUwWFM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CaGRHbGxiblJmY21WamIzSmtjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94TlRNS0lDQWdJQzh2SUdGeWNpNWhjSEJsYm1Rb2JtVjNYM0psWTI5eVpDNWpiM0I1S0NrcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyRnNiSE4xWWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94TlRRS0lDQWdJQzh2SUhObGJHWXVjR0YwYVdWdWRGOXlaV052Y21SelczQmhkR2xsYm5SZElEMGdZWEp5TG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb0tZV1JrWDNCeVpYTmpjbWx3ZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRVNUxURTJOZ29nSUNBZ0x5OGdZWEpqTkM1aFltbGZZMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQWliRzluWDJSaGRHRmZZV05qWlhOelpXUW9ZV1JrY21WemN5eGhaR1J5WlhOekxITjBjbWx1Wnl4MWFXNTBOalFwZG05cFpDSXNDaUFnSUNBdkx5QWdJQ0FnY0dGMGFXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVUZEhKcGJtY29JbFZ3Ykc5aFpHVmtJRzVsZHlCUWNtVnpZM0pwY0hScGIyNGdkRzhnUjJ4dlltRnNJRkYxWlhWbElpa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2JtOTNLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNIQmZhV1E5UVhCd2JHbGpZWFJwYjI0b2MyVnNaaTVoZFdScGRGOWhjSEF1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFMk1nb2dJQ0FnTHk4Z1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qRTJOUW9nSUNBZ0x5OGdZWEJ3WDJsa1BVRndjR3hwWTJGMGFXOXVLSE5sYkdZdVlYVmthWFJmWVhCd0xuWmhiSFZsS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0poZFdScGRGOWhjSEFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlYVmthWFJmWVhCd0lHVjRhWE4wY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRVNUxURTJOZ29nSUNBZ0x5OGdZWEpqTkM1aFltbGZZMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQWliRzluWDJSaGRHRmZZV05qWlhOelpXUW9ZV1JrY21WemN5eGhaR1J5WlhOekxITjBjbWx1Wnl4MWFXNTBOalFwZG05cFpDSXNDaUFnSUNBdkx5QWdJQ0FnY0dGMGFXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVUZEhKcGJtY29JbFZ3Ykc5aFpHVmtJRzVsZHlCUWNtVnpZM0pwY0hScGIyNGdkRzhnUjJ4dlltRnNJRkYxWlhWbElpa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2JtOTNLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNIQmZhV1E5UVhCd2JHbGpZWFJwYjI0b2MyVnNaaTVoZFdScGRGOWhjSEF1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1lubDBaV01nTnlBdkx5QnRaWFJvYjJRZ0lteHZaMTlrWVhSaFgyRmpZMlZ6YzJWa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4emRISnBibWNzZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JRFVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qRTJNd29nSUNBZ0x5OGdZWEpqTkM1VGRISnBibWNvSWxWd2JHOWhaR1ZrSUc1bGR5QlFjbVZ6WTNKcGNIUnBiMjRnZEc4Z1IyeHZZbUZzSUZGMVpYVmxJaWtzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURJNU5UVTNNRFpqTm1ZMk1UWTBOalUyTkRJd05tVTJOVGMzTWpBMU1EY3lOalUzTXpZek56STJPVGN3TnpRMk9UWm1ObVV5TURjME5tWXlNRFEzTm1NMlpqWXlOakUyWXpJd05URTNOVFkxTnpVMk5Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFMU9TMHhOallLSUNBZ0lDOHZJR0Z5WXpRdVlXSnBYMk5oYkd3b0NpQWdJQ0F2THlBZ0lDQWdJbXh2WjE5a1lYUmhYMkZqWTJWemMyVmtLR0ZrWkhKbGMzTXNZV1JrY21WemN5eHpkSEpwYm1jc2RXbHVkRFkwS1hadmFXUWlMQW9nSUNBZ0x5OGdJQ0FnSUhCaGRHbGxiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VTNSeWFXNW5LQ0pWY0d4dllXUmxaQ0J1WlhjZ1VISmxjMk55YVhCMGFXOXVJSFJ2SUVkc2IySmhiQ0JSZFdWMVpTSXBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtHNXZkeWtzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFVGd2NHeHBZMkYwYVc5dUtITmxiR1l1WVhWa2FYUmZZWEJ3TG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1UWTRMVEUzTXdvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0FvZ0lDQWdMeThnSUNBZ0lDSlFjbVZ6WTNKcGNIUnBiMjVCWkdSbFpGUnZVWFZsZFdVb2RXbHVkRFkwTEdGa1pISmxjM01zYzNSeWFXNW5LU0lzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpYMmxrTEFvZ0lDQWdMeThnSUNBZ0lIQmhkR2xsYm5Rc0NpQWdJQ0F2THlBZ0lDQWdjR0YwYVdWdWRGOXVZVzFsTEFvZ0lDQWdMeThnS1FvZ0lDQWdaR2xuSURJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01tRUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpJMU0yRTBOellnTHk4Z2JXVjBhRzlrSUNKUWNtVnpZM0pwY0hScGIyNUJaR1JsWkZSdlVYVmxkV1VvZFdsdWREWTBMR0ZrWkhKbGMzTXNjM1J5YVc1bktTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1URTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtRmtaRjl3Y21WelkzSnBjSFJwYjI1ZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1UVTJDaUFnSUNBdkx5QmhjbklnUFNCaGNtTTBMa1I1Ym1GdGFXTkJjbkpoZVZ0U1pXTnZjbVJkS0c1bGQxOXlaV052Y21RdVkyOXdlU2dwS1FvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURBd01ERXdNREF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94TlRjS0lDQWdJQzh2SUhObGJHWXVjR0YwYVdWdWRGOXlaV052Y21SelczQmhkR2xsYm5SZElEMGdZWEp5TG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JpSUdGa1pGOXdjbVZ6WTNKcGNIUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TGsxbFpHbGpZV3hTWldOdmNtUnpMbU52Ym5SeVlXTjBMazFsWkdsallXeFNaV052Y21SekxtZGxkRjl3Wlc1a2FXNW5YM0J5WlhOamNtbHdkR2x2Ym5OYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmY0dWdVpHbHVaMTl3Y21WelkzSnBjSFJwYjI1ek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94T0RBS0lDQWdJQzh2SUhCbGJtUnBibWNnUFNCaGNtTTBMa1I1Ym1GdGFXTkJjbkpoZVZ0UWNtVnpZM0pwY0hScGIyNVJkV1YxWlVsMFpXMWRLQ2tLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGd3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRneENpQWdJQ0F2THlCMGIzUmhiQ0E5SUhObGJHWXVjWFZsZFdWZmJHVnVaM1JvTG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNWOXNaVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNYVmxkV1ZmYkdWdVozUm9JR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFNE1nb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hSdmRHRnNLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3BuWlhSZmNHVnVaR2x1WjE5d2NtVnpZM0pwY0hScGIyNXpYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94T0RJS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2gwYjNSaGJDazZDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JpZWlCblpYUmZjR1Z1WkdsdVoxOXdjbVZ6WTNKcGNIUnBiMjV6WDJGbWRHVnlYMlp2Y2tBM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRnekNpQWdJQ0F2THlCcGRHVnRJRDBnYzJWc1ppNXdjbVZ6WTNKcGNIUnBiMjVmY1hWbGRXVmJZWEpqTkM1VlNXNTBOalFvYVNsZExtTnZjSGtvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TnpBM01UVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2NtVnpZM0pwY0hScGIyNWZjWFZsZFdVZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1UZ3pMVEU0TkFvZ0lDQWdMeThnYVhSbGJTQTlJSE5sYkdZdWNISmxjMk55YVhCMGFXOXVYM0YxWlhWbFcyRnlZelF1VlVsdWREWTBLR2twWFM1amIzQjVLQ2tLSUNBZ0lDOHZJR2xtSUc1dmRDQnBkR1Z0TG1selgyUnBjM0JsYm5ObFpDNXVZWFJwZG1VNkNpQWdJQ0J3ZFhOb2FXNTBJRFEwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRveE9EUUtJQ0FnSUM4dklHbG1JRzV2ZENCcGRHVnRMbWx6WDJScGMzQmxibk5sWkM1dVlYUnBkbVU2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWJub2daMlYwWDNCbGJtUnBibWRmY0hKbGMyTnlhWEIwYVc5dWMxOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94T0RVS0lDQWdJQzh2SUhCbGJtUnBibWN1WVhCd1pXNWtLR2wwWlcwdVkyOXdlU2dwS1FvZ0lDQWdaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF3TURJS0lDQWdJR1JwWnlBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWkhsdVlXMXBZMTlsYkdWdFpXNTBDaUFnSUNCaWRYSjVJRE1LQ21kbGRGOXdaVzVrYVc1blgzQnlaWE5qY21sd2RHbHZibk5mWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qRTRNZ29nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtIUnZkR0ZzS1RvS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQm5aWFJmY0dWdVpHbHVaMTl3Y21WelkzSnBjSFJwYjI1elgyWnZjbDlvWldGa1pYSkFNZ29LWjJWMFgzQmxibVJwYm1kZmNISmxjMk55YVhCMGFXOXVjMTloWm5SbGNsOW1iM0pBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94TnpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnWkdsbklETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TGsxbFpHbGpZV3hTWldOdmNtUnpMbU52Ym5SeVlXTjBMazFsWkdsallXeFNaV052Y21SekxtMWhjbXRmY0hKbGMyTnlhWEIwYVc5dVgyUnBjM0JsYm5ObFpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTFoY210ZmNISmxjMk55YVhCMGFXOXVYMlJwYzNCbGJuTmxaRG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQnVJRGNLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1pIVndiaUF4TVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPakU0T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRrMUNpQWdJQ0F2THlCMGIzUmhiQ0E5SUhObGJHWXVjWFZsZFdWZmJHVnVaM1JvTG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNWOXNaVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNYVmxkV1ZmYkdWdVozUm9JR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFNU5nb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hSdmRHRnNLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3B0WVhKclgzQnlaWE5qY21sd2RHbHZibDlrYVhOd1pXNXpaV1JmWm05eVgyaGxZV1JsY2tBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFNU5nb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0hSdmRHRnNLVG9LSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEd0tJQ0FnSUdKNklHMWhjbXRmY0hKbGMyTnlhWEIwYVc5dVgyUnBjM0JsYm5ObFpGOWhablJsY2w5bWIzSkFNVFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3hPVGNLSUNBZ0lDOHZJR2xrZUNBOUlHRnlZelF1VlVsdWREWTBLR2twQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3hPVGdLSUNBZ0lDOHZJR2wwWlcwZ1BTQnpaV3htTG5CeVpYTmpjbWx3ZEdsdmJsOXhkV1YxWlZ0cFpIaGRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEY3dOekUxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01qTUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1luVnllU0F5TWdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0hKbGMyTnlhWEIwYVc5dVgzRjFaWFZsSUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFNU9DMHhPVGtLSUNBZ0lDOHZJR2wwWlcwZ1BTQnpaV3htTG5CeVpYTmpjbWx3ZEdsdmJsOXhkV1YxWlZ0cFpIaGRMbU52Y0hrb0tRb2dJQ0FnTHk4Z2FXWWdhWFJsYlM1eVpXTnZjbVJmYVdRZ1BUMGdjbVZqYjNKa1gybGtPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPakU1T1FvZ0lDQWdMeThnYVdZZ2FYUmxiUzV5WldOdmNtUmZhV1FnUFQwZ2NtVmpiM0prWDJsa09nb2dJQ0FnWkdsbklEUUtJQ0FnSUdJOVBRb2dJQ0FnWW5vZ2JXRnlhMTl3Y21WelkzSnBjSFJwYjI1ZlpHbHpjR1Z1YzJWa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG95TURBS0lDQWdJQzh2SUdsMFpXMHVhWE5mWkdsemNHVnVjMlZrSUQwZ1lYSmpOQzVDYjI5c0tGUnlkV1VwQ2lBZ0lDQmthV2NnTVRrS0lDQWdJSEIxYzJocGJuUWdNelV5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZUV1ZrYVdOaGJGSmxZMjl5WkhNdlkyOXVkSEpoWTNRdWNIazZNakF4Q2lBZ0lDQXZMeUJwZEdWdExtSnBiR3hmWVcxdmRXNTBJRDBnWW1sc2JGOWhiVzkxYm5RS0lDQWdJR1JwWnlBekNpQWdJQ0J5WlhCc1lXTmxNaUEwTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPakl3TWdvZ0lDQWdMeThnYzJWc1ppNXdjbVZ6WTNKcGNIUnBiMjVmY1hWbGRXVmJhV1I0WFNBOUlHbDBaVzB1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNaklLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pJd05DMHlNRFVLSUNBZ0lDOHZJQ01nVlhCa1lYUmxJSFJvWlNCd1lYUnBaVzUwSjNNZ2NtVmpiM0prSUdocGMzUnZjbmtnZDJsMGFDQjBhR1VnWW1sc2JDQmhiVzkxYm5RS0lDQWdJQzh2SUhCaGRHbGxiblFnUFNCcGRHVnRMbkJoZEdsbGJuUUtJQ0FnSUdWNGRISmhZM1FnT0NBek1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pJd05nb2dJQ0FnTHk4Z2FXWWdjR0YwYVdWdWRDQnBiaUJ6Wld4bUxuQmhkR2xsYm5SZmNtVmpiM0prY3pvS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnM01EY3lOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJeUNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJRzFoY210ZmNISmxjMk55YVhCMGFXOXVYMlJwYzNCbGJuTmxaRjloWm5SbGNsOXBabDlsYkhObFFERXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1qQTNDaUFnSUNBdkx5QmhjbklnUFNCelpXeG1MbkJoZEdsbGJuUmZjbVZqYjNKa2MxdHdZWFJwWlc1MFhTNWpiM0I1S0NrS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRYSjVJREkyQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3WVhScFpXNTBYM0psWTI5eVpITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZUV1ZrYVdOaGJGSmxZMjl5WkhNdlkyOXVkSEpoWTNRdWNIazZNakEzTFRJd09Bb2dJQ0FnTHk4Z1lYSnlJRDBnYzJWc1ppNXdZWFJwWlc1MFgzSmxZMjl5WkhOYmNHRjBhV1Z1ZEYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUJtYjNJZ2FpQnBiaUIxY21GdVoyVW9ZWEp5TG14bGJtZDBhQ2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JpZFhKNUlERXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1qQTRDaUFnSUNBdkx5Qm1iM0lnYWlCcGJpQjFjbUZ1WjJVb1lYSnlMbXhsYm1kMGFDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5WeWVTQXhNQW9LYldGeWExOXdjbVZ6WTNKcGNIUnBiMjVmWkdsemNHVnVjMlZrWDJadmNsOW9aV0ZrWlhKQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRveU1EZ0tJQ0FnSUM4dklHWnZjaUJxSUdsdUlIVnlZVzVuWlNoaGNuSXViR1Z1WjNSb0tUb0tJQ0FnSUdScFp5QTVDaUFnSUNCa2FXY2dNVE1LSUNBZ0lEd0tJQ0FnSUdKNklHMWhjbXRmY0hKbGMyTnlhWEIwYVc5dVgyUnBjM0JsYm5ObFpGOWhablJsY2w5bWIzSkFNVEVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3lNRGtLSUNBZ0lDOHZJSEpsWXlBOUlHRnljbHRxWFM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF5TXdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmlkWEo1SURJMUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmlkWEo1SURFNENpQWdJQ0JrYVdjZ01URUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0JpZFhKNUlERXdDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWpBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pHbG5JREVLSUNBZ0lDMGdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdKMWNua2dNVGdLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01qQUtJQ0FnSUdScFp5QTBDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdKMWNua2dNVGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3lNRGt0TWpFd0NpQWdJQ0F2THlCeVpXTWdQU0JoY25KYmFsMHVZMjl3ZVNncENpQWdJQ0F2THlCcFppQnlaV011YVdRZ1BUMGdjbVZqYjNKa1gybGtPZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNakVLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3lNVEFLSUNBZ0lDOHZJR2xtSUhKbFl5NXBaQ0E5UFNCeVpXTnZjbVJmYVdRNkNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWWowOUNpQWdJQ0JpZWlCdFlYSnJYM0J5WlhOamNtbHdkR2x2Ymw5a2FYTndaVzV6WldSZllXWjBaWEpmYVdaZlpXeHpaVUE1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZUV1ZrYVdOaGJGSmxZMjl5WkhNdlkyOXVkSEpoWTNRdWNIazZNakV4Q2lBZ0lDQXZMeUJ5WldNdVltbHNiRjloYlc5MWJuUWdQU0JpYVd4c1gyRnRiM1Z1ZEFvZ0lDQWdaR2xuSURFM0NpQWdJQ0JrYVdjZ013b2dJQ0FnY21Wd2JHRmpaVElnT0RRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG95TVRJS0lDQWdJQzh2SUdGeWNsdHFYU0E5SUhKbFl5NWpiM0I1S0NrS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUR3S0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaR2xuSURJMUNpQWdJQ0J6ZFdKemRISnBibWNnTUNBeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01qQUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaR2xuSURFMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklERXdDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDMEtJQ0FnSUdKMWNua2dNVElLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnNaVzRLSUNBZ0lHSjFjbmtnTVRRS0lDQWdJR1JwWnlBeU53b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0oxY25rZ01qQUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQmlkWEo1SURVS0lDQWdJR1JwWnlBeE13b2dJQ0FnWW5WeWVTQXhNUW9LYldGeWExOXdjbVZ6WTNKcGNIUnBiMjVmWkdsemNHVnVjMlZrWDJadmNsOW9aV0ZrWlhKQU1UYzZDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHUnBaeUExQ2lBZ0lDQThDaUFnSUNCaWVpQnRZWEpyWDNCeVpYTmpjbWx3ZEdsdmJsOWthWE53Wlc1elpXUmZZV1owWlhKZlptOXlRREU1Q2lBZ0lDQmthV2NnTVRnS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURFeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNVEVLSUNBZ0lDc0tJQ0FnSUdScFp5QTVDaUFnSUNBdENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXpDaUFnSUNCaWRYSjVJREl3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhNUW9nSUNBZ1lpQnRZWEpyWDNCeVpYTmpjbWx3ZEdsdmJsOWthWE53Wlc1elpXUmZabTl5WDJobFlXUmxja0F4TndvS2JXRnlhMTl3Y21WelkzSnBjSFJwYjI1ZlpHbHpjR1Z1YzJWa1gyRm1kR1Z5WDJadmNrQXhPVG9LSUNBZ0lHUnBaeUF4TmdvZ0lDQWdaR2xuSURFNUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKMWNua2dNalFLQ20xaGNtdGZjSEpsYzJOeWFYQjBhVzl1WDJScGMzQmxibk5sWkY5aFpuUmxjbDltYjNKQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1qRTBDaUFnSUNBdkx5QnpaV3htTG5CaGRHbGxiblJmY21WamIzSmtjMXR3WVhScFpXNTBYU0E5SUdGeWNpNWpiM0I1S0NrS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdScFp5QXlOQW9nSUNBZ1ltOTRYM0IxZEFvS2JXRnlhMTl3Y21WelkzSnBjSFJwYjI1ZlpHbHpjR1Z1YzJWa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TWpFMkxUSXlNQW9nSUNBZ0x5OGdZWEpqTkM1bGJXbDBLQW9nSUNBZ0x5OGdJQ0FnSUNKUWNtVnpZM0pwY0hScGIyNUVhWE53Wlc1elpXUW9kV2x1ZERZMExIVnBiblEyTkNraUxBb2dJQ0FnTHk4Z0lDQWdJSEpsWTI5eVpGOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCaWFXeHNYMkZ0YjNWdWRDd0tJQ0FnSUM4dklDa0tJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhsTURCbU1HRm1ZaUF2THlCdFpYUm9iMlFnSWxCeVpYTmpjbWx3ZEdsdmJrUnBjM0JsYm5ObFpDaDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNncHRZWEpyWDNCeVpYTmpjbWx3ZEdsdmJsOWthWE53Wlc1elpXUmZZV1owWlhKZlptOXlRREUxT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPakU0T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVhKclgzQnlaWE5qY21sd2RHbHZibDlrYVhOd1pXNXpaV1JmWVdaMFpYSmZhV1pmWld4elpVQTVPZ29nSUNBZ1pHbG5JREUwQ2lBZ0lDQmlkWEo1SURFd0NpQWdJQ0JpSUcxaGNtdGZjSEpsYzJOeWFYQjBhVzl1WDJScGMzQmxibk5sWkY5bWIzSmZhR1ZoWkdWeVFEWUtDbTFoY210ZmNISmxjMk55YVhCMGFXOXVYMlJwYzNCbGJuTmxaRjloWm5SbGNsOXBabDlsYkhObFFERXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qRTVOZ29nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtIUnZkR0ZzS1RvS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQnRZWEpyWDNCeVpYTmpjbWx3ZEdsdmJsOWthWE53Wlc1elpXUmZabTl5WDJobFlXUmxja0F5Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxrMWxaR2xqWVd4U1pXTnZjbVJ6TG1OdmJuUnlZV04wTGsxbFpHbGpZV3hTWldOdmNtUnpMbWRsZEY5d1lYUnBaVzUwWDNKbFkyOXlaSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZjR0YwYVdWdWRGOXlaV052Y21Sek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pJeU13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TWpJNENpQWdJQ0F2THlCcFppQndZWFJwWlc1MElHbHVJSE5sYkdZdWNHRjBhV1Z1ZEY5eVpXTnZjbVJ6T2dvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURjd056STFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ1oyVjBYM0JoZEdsbGJuUmZjbVZqYjNKa2MxOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG95TWprS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxuQmhkR2xsYm5SZmNtVmpiM0prYzF0d1lYUnBaVzUwWFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0dGMGFXVnVkRjl5WldOdmNtUnpJR1Z1ZEhKNUlHVjRhWE4wY3dvS1oyVjBYM0JoZEdsbGJuUmZjbVZqYjNKa2MxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVOWldScFkyRnNVbVZqYjNKa2N5NWpiMjUwY21GamRDNU5aV1JwWTJGc1VtVmpiM0prY3k1blpYUmZjR0YwYVdWdWRGOXlaV052Y21SelFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1qSXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwblpYUmZjR0YwYVdWdWRGOXlaV052Y21SelgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG95TXpBS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExrUjVibUZ0YVdOQmNuSmhlVnRTWldOdmNtUmRLQ2tLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGd3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TWpJekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdJZ1oyVjBYM0JoZEdsbGJuUmZjbVZqYjNKa2MxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVOWldScFkyRnNVbVZqYjNKa2N5NWpiMjUwY21GamRDNU5aV1JwWTJGc1VtVmpiM0prY3k1blpYUmZjR0YwYVdWdWRGOXlaV052Y21SelFEUUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFQ0NDWUxDM0psWTE5amIzVnVkR1Z5QlhGZmJHVnVBM0J5WHdsaGRXUnBkRjloY0hBQ0FBSURjSEZmQWdCY0JNZTl0SEFFQUFFQUFnSUFBQVFWSDN4MU1SaEFBQVlvSW1jcEltY3hHMEVBT1RFWkZFUXhHRVNDQmdTZ3l0K0tCS1g2dnA0RThBenlpd1FEbG12ckJNYzE4U2dFZlVtODlEWWFBSTRHQUlvQW1BR3FBdndEVVFUT0FERVpGREVZRkJCRGlnUUJnQUJKaS80a0M0djhKQXNpaXdTTEF3eEJBQnlML1lzRVNVNENXWXNDQ0JaWEJnS0xBVXhRakFFa0NJd0VRdi9jaS8wVmpBQWlqQVNMQklzQ0RFRUFISXYvaXdSSlRnSlppd0FJRmxjR0Fvc0JURkNNQVNRSWpBUkMvOXlML0l2K0NCWlhCZ0tMQVZDTC9Zc0Rpd0JTVUl2L0ZZdi9pd0pQQWxKUWpBQ0pOaG9CU1JVbEVrUVhLMHhuSTBNMkdnRkhBaFdCSUJKRU5ob0NTVTRDU1NKWkpBaExBUlZKVGdSSlR3SVNSRFlhQTBsT0JFa2lXU1FJU3dFVkVrUTJHZ1JKRlNVU1JDSW9aVVFqQ0NoTEFXY3lCMHdXTVFCUEFoWkpUZ05PQ0V4TEIxQk1VQ2NHVUlGY1R3VUlGbGNHQWxCTVVFeFFUd0pRVEZCTUtreFFTVTRDdlVVQlFRQ0xTd0ZKdmtSSklsbE1Wd0lBSndSUEJGQk9BaU5QQTRqKzMwc0J2RWkvc1RFQUlpdGxSTElZSndleUdrc0dTVTRDc2hxeUdvQVZBQk5WY0d4dllXUmxaQ0J1WlhjZ2NtVmpiM0prc2hwTEFrbE9BcklhZ1FheUVDS3lBYk1pS0dWRUZqRUFURThDVUV4UWdBSUFWRkNCVkVzR0NCWlhCZ0pRVEZCTEJWQkxBMUNBQkJMZ0RSMU1VTEFqUXljSVRGQkxBVW04U0V5L1F2K0ZOaG9CUndJVmdTQVNSRFlhQWtsT0Fra2lXU1FJU3dFVlNVOENFa1EyR2dOSklsa2tDRXNCRlVsUEFoSkVJaWhsUkNNSUtFc0JaeklIVEJZaUtXVkVTUlpQQWtzSVVFbE9DVW1BQWdBMVVJRTFUd2dJRmxjR0FsQ0FDUUFBQUFBQUFBQUFBRkJQQjFCTEJsQW5CVThEVUVtOFNFeS9UQ01JS1V4bk1RQlBBaFpKVGdKT0JrOENURkFuQmxDQlhFOERDQlpYQmdKUVRGQ0FDQUFBQUFBQUFBQUFVRXhRZ0E0QURGQnlaWE5qY21sd2RHbHZibEJNS2t4UVNVNEN2VVVCUVFDQlN3Rkp2a1JKSWxsTVZ3SUFKd1JQQkZCT0FpTlBBNGo5ZzBzQnZFaS9zVEVBSWl0bFJMSVlKd2V5R2tzRnNocXlHb0FyQUNsVmNHeHZZV1JsWkNCdVpYY2dVSEpsYzJOeWFYQjBhVzl1SUhSdklFZHNiMkpoYkNCUmRXVjFaYklhU3dHeUdvRUdzaEFpc2dHelN3S0FBZ0FxVUVzRVVJQUVZbE9rZGt4UXNDTkRKd2hNVUVzQlNieElUTDlDLzQ4aUp3a2lLV1ZFSWtsTEFneEJBRDVKRmljRlRGQkp2a3hGQmtTQkxDTzZJbE9BQVFBaVR3SlVJbE5BQUJoTEFra2lXVXhYQWdBbkJFc0dVRTRDSTA4RGlQektSUU5KSXdoRkFVTC91eWNLU3dOUXNDTkRJa2NIZ0FCSEN6WWFBVWtWSlJKRU5ob0NTUlVsRWtRaUtXVkVJa2xMQWd4QkFVbEpGaWNGVEZCSlJSZEp2a3hGRmtRaUpicExCS2hCQVRwTEU0SGdBaU5VU3dOY0xVc1dTYnhJU3dHL1Z3Z2dLa3hRU1VVV3ZVVUJRUUVCU3hSSnZreEZHa1FpSkxvWFJRMGlSUXBMQ1VzTkRFRUE0RXNYU1ZjQ0FFbE9Ba1VaSWxsSlRnSkZFa3NMU1NRTFN3Sk1XVWxPQkVVS1NTTUlTVVVVVHdOTEFRbExBeFZKVGdORkVrd2tDMGxGRkVzRVRGbEpSUTVNVFU4Q1R3TlBBbEpGRXlRTEpBaExGVWxQQWlTNkZ5UUlKYnBMQktoQkFKZExFVXNEWEZSTENrbExFZ3hFU3hsUkFBSkpSUlFYU1U4Q0NTTUpTdzVKVGdKTERFOENUVWxMQ2tsT0FnbEZERXNFRlVVT1N4dEpUZ01pVHdKU1R3VlFUZ0pQQTFKUVJSUWtDMFVGU3cxRkMwc0tTd1VNUVFBZ1N4SkpTd3hKVGdOWlN3c0lTd2tKRmxjR0Frc0NURjFGRkNRSVJRdEMvOWhMRUVzVFVFVVlTeFJKdkVoTEdMOUxBMHNEVUlBRTRBOEsrMHhRc0NORFN3NUZDa0wrK1VrakNFVUJRdjZmTmhvQlNSV0JJQkpFS2t4UVNiMUZBVUVBQ2ttK1JDY0tURkN3STBNbkNVTC85QT09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiUmVjb3JkQWRkZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDYiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlByZXNjcmlwdGlvbkFkZGVkVG9RdWV1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJQcmVzY3JpcHRpb25EaXNwZW5zZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
