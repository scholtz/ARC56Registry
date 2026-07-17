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

namespace Arc56.Generated.Yashwanth112004.Hackseries_3_0.MedicalRecords_eb74383e
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

                public string Field5 { get; set; }

                public ulong Field6 { get; set; }

                public ulong Field7 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField5.From(Field5);
                    stringRef[ret.Count] = vField5.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
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
                    var indexField5 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField5.Decode(bytes.Skip(indexField5 + prefixOffset).ToArray());
                    var valueField5 = vField5.ToValue();
                    if (valueField5 is string vField5Value) { ret.Field5 = vField5Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is ulong vField6Value) { ret.Field6 = vField6Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField7 = vField7.ToValue();
                    if (valueField7 is ulong vField7Value) { ret.Field7 = vField7Value; }
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
        /// <param name="previous_cid"> </param>
        /// <param name="record_type"> </param>
        /// <param name="bill_amount"> </param>
        public async Task AddRecord(Algorand.Address patient, string cid, string previous_cid, string record_type, ulong bill_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 39, 69, 77 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cidAbi.From(cid);
            var previous_cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); previous_cidAbi.From(previous_cid);
            var record_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); record_typeAbi.From(record_type);
            var bill_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_amountAbi.From(bill_amount);

            var result = await base.CallApp(new List<object> { abiHandle, patientAbi, cidAbi, previous_cidAbi, record_typeAbi, bill_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddRecord_Transactions(Algorand.Address patient, string cid, string previous_cid, string record_type, ulong bill_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 39, 69, 77 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cidAbi.From(cid);
            var previous_cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); previous_cidAbi.From(previous_cid);
            var record_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); record_typeAbi.From(record_type);
            var bill_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bill_amountAbi.From(bill_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, patientAbi, cidAbi, previous_cidAbi, record_typeAbi, bill_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
            byte[] abiHandle = { 18, 203, 22, 224 };
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
            byte[] abiHandle = { 18, 203, 22, 224 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWVkaWNhbFJlY29yZHMiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUHJlc2NyaXB0aW9uUXVldWVJdGVtIjpbeyJuYW1lIjoicmVjb3JkX2lkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InBhdGllbnQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBhdGllbnRfbmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJjaWQiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiaXNfZGlzcGVuc2VkIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJiaWxsX2Ftb3VudCIsInR5cGUiOiJ1aW50NjQifV0sIkdldFBhdGllbnRSZWNvcmRzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ3IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJib290c3RyYXAiLCJkZXNjIjoiU2V0IHRoZSBBdWRpdExvZyBhcHAgSUQgKGNhbGxlZCBvbmNlIGFmdGVyIGRlcGxveSkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF1ZGl0X2FwcF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfcmVjb3JkIiwiZGVzYyI6IkFwcHJvdmVkIGZpZHVjaWFyaWVzIChMYWJzLCBEb2N0b3JzLCBldGMuKSBtYXAgYSBDSUQgdG8gYSBwYXRpZW50LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmV2aW91c19jaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY29yZF90eXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiaWxsX2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiUmVjb3JkQWRkZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDYiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfcHJlc2NyaXB0aW9uIiwiZGVzYyI6IkFkZCBhIHByZXNjcmlwdGlvbiB0byB0aGUgZ2xvYmFsIHF1ZXVlIGFuZCB0byB0aGUgcGF0aWVudCdzIHJlY29yZCBoaXN0b3J5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudF9uYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlByZXNjcmlwdGlvbkFkZGVkVG9RdWV1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BlbmRpbmdfcHJlc2NyaXB0aW9ucyIsImRlc2MiOiJSZXR1cm4gYWxsIHByZXNjcmlwdGlvbiBxdWV1ZSBpdGVtcyB0aGF0IGhhdmUgbm90IGJlZW4gZGlzcGVuc2VkLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3Msc3RyaW5nLHN0cmluZyxib29sLHVpbnQ2NClbXSIsInN0cnVjdCI6IlByZXNjcmlwdGlvblF1ZXVlSXRlbSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFya19wcmVzY3JpcHRpb25fZGlzcGVuc2VkIiwiZGVzYyI6Ik1hcmsgYSBwcmVzY3JpcHRpb24gYXMgZGlzcGVuc2VkIGFuZCB1cGRhdGUgdGhlIGJpbGwgYW1vdW50LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNvcmRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJpbGxfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJQcmVzY3JpcHRpb25EaXNwZW5zZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BhdGllbnRfcmVjb3JkcyIsImRlc2MiOiJSZXR1cm4gYWxsIHJlY29yZHMgbWFwcGVkIHRvIGEgcGF0aWVudCdzIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXRpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyxhZGRyZXNzLHN0cmluZyxzdHJpbmcsc3RyaW5nLHVpbnQ2NCx1aW50NjQpW10iLCJzdHJ1Y3QiOiJHZXRQYXRpZW50UmVjb3Jkc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0ODQsNDk0LDg1Miw4NjJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmF1ZGl0X2FwcCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTUsODIzLDExNTcsMTQ1OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucGF0aWVudF9yZWNvcmRzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk5OSwxMTA2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wcmVzY3JpcHRpb25fcXVldWUgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjcyLDk3OSwxMDgzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5xdWV1ZV9sZW5ndGggZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzczLDU1MSw2NThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlY29yZF9jb3VudGVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMTcsMTI4NF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE2LDMzNSwzNTQsNjI4LDY0NCwxMTg3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI5LDM0NSwzNjEsNjM4LDY1NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDcsNjE5LDE0NDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkxLDM2OSwxMDcxLDEwNzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURJZ01TQTRDaUFnSUNCaWVYUmxZMkpzYjJOcklDSnlaV05mWTI5MWJuUmxjaUlnSW1GMVpHbDBYMkZ3Y0NJZ0luRmZiR1Z1SWlBd2VEY3dOekkxWmlBd2VEQXdNRElnTUhnd01DQXdlRGN3TnpFMVppQXdlREF3TldVZ01IaGlaR1V4T1Rrd01pQXdlREF3TURFd01EQXlJREI0TURBd01DQXdlREUxTVdZM1l6YzFDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TkRJS0lDQWdJQzh2SUhObGJHWXVjbVZqYjNKa1gyTnZkVzUwWlhJdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5KbFkxOWpiM1Z1ZEdWeUlnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TkRVS0lDQWdJQzh2SUhObGJHWXVZWFZrYVhSZllYQndMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhkV1JwZEY5aGNIQWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z2MyVnNaaTV4ZFdWMVpWOXNaVzVuZEdndWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5GZmJHVnVJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG96T0FvZ0lDQWdMeThnWTJ4aGMzTWdUV1ZrYVdOaGJGSmxZMjl5WkhNb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaE1HTmhaR1k0WVNBd2VEQmhNamMwTlRSa0lEQjRaakF3WTJZeU9HSWdNSGd3TXprMk5tSmxZaUF3ZUdNM016Vm1NVEk0SURCNE1USmpZakUyWlRBZ0x5OGdiV1YwYUc5a0lDSmliMjkwYzNSeVlYQW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1Ga1pGOXlaV052Y21Rb1lXUmtjbVZ6Y3l4emRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVdSa1gzQnlaWE5qY21sd2RHbHZiaWhoWkdSeVpYTnpMSE4wY21sdVp5eHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzQmxibVJwYm1kZmNISmxjMk55YVhCMGFXOXVjeWdwS0hWcGJuUTJOQ3hoWkdSeVpYTnpMSE4wY21sdVp5eHpkSEpwYm1jc1ltOXZiQ3gxYVc1ME5qUXBXMTBpTENCdFpYUm9iMlFnSW0xaGNtdGZjSEpsYzJOeWFYQjBhVzl1WDJScGMzQmxibk5sWkNoMWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRjl3WVhScFpXNTBYM0psWTI5eVpITW9ZV1JrY21WemN5a29kV2x1ZERZMExHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4emRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eDFhVzUwTmpRc2RXbHVkRFkwS1Z0ZElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZbTl2ZEhOMGNtRndJR0ZrWkY5eVpXTnZjbVFnWVdSa1gzQnlaWE5qY21sd2RHbHZiaUJuWlhSZmNHVnVaR2x1WjE5d2NtVnpZM0pwY0hScGIyNXpJRzFoY210ZmNISmxjMk55YVhCMGFXOXVYMlJwYzNCbGJuTmxaQ0JuWlhSZmNHRjBhV1Z1ZEY5eVpXTnZjbVJ6Q2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UVTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklGOXdkWGxoWDJ4cFlpNWhjbU0wTG1SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZENoaGNuSmhlVjlwZEdWdGMxOWpiM1Z1ZERvZ2RXbHVkRFkwTENCaGNuSmhlVjlvWldGa1gyRnVaRjkwWVdsc09pQmllWFJsY3l3Z2JtVjNYMmwwWlcxelgyTnZkVzUwT2lCMWFXNTBOalFzSUc1bGQxOW9aV0ZrWDJGdVpGOTBZV2xzT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZERvS0lDQWdJSEJ5YjNSdklEUWdNUW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ29LSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5SZlptOXlYMmhsWVdSbGNrQXhPZ29nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0E4Q2lBZ0lDQmllaUJrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5a2VXNWhiV2xqWDJWc1pXMWxiblJmWVdaMFpYSmZabTl5UURRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDaUFnSUNCaUlHUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOW1iM0pmYUdWaFpHVnlRREVLQ21SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5aFpuUmxjbDltYjNKQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYkdWdUNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFFLQ21SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5bWIzSmZhR1ZoWkdWeVFEVTZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJRHdLSUNBZ0lHSjZJR1I1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJSNWJtRnRhV05mWld4bGJXVnVkRjloWm5SbGNsOW1iM0pBT0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEUUtJQ0FnSUdJZ1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyWnZjbDlvWldGa1pYSkFOUW9LWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlpIbHVZVzFwWTE5bGJHVnRaVzUwWDJGbWRHVnlYMlp2Y2tBNE9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxrMWxaR2xqWVd4U1pXTnZjbVJ6TG1OdmJuUnlZV04wTGsxbFpHbGpZV3hTWldOdmNtUnpMbUp2YjNSemRISmhjRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21KdmIzUnpkSEpoY0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG8yTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZUV1ZrYVdOaGJGSmxZMjl5WkhNdlkyOXVkSEpoWTNRdWNIazZOalVLSUNBZ0lDOHZJSE5sYkdZdVlYVmthWFJmWVhCd0xuWmhiSFZsSUQwZ1lYVmthWFJmWVhCd1gybGtMbTVoZEdsMlpRb2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlYVmthWFJmWVhCd0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRvMk1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxrMWxaR2xqWVd4U1pXTnZjbVJ6TG1OdmJuUnlZV04wTGsxbFpHbGpZV3hTWldOdmNtUnpMbUZrWkY5eVpXTnZjbVJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaFpHUmZjbVZqYjNKa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pZM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qYzNDaUFnSUNBdkx5QnpaV3htTG5KbFkyOXlaRjlqYjNWdWRHVnlMblpoYkhWbElDczlJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luSmxZMTlqYjNWdWRHVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5KbFkyOXlaRjlqYjNWdWRHVnlJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkpsWTE5amIzVnVkR1Z5SWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TnpnS0lDQWdJQzh2SUc1dmR5QTlJRzl3TGtkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk9ERUtJQ0FnSUM4dklHbGtQV0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVjbVZqYjNKa1gyTnZkVzUwWlhJdWRtRnNkV1VwTEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPamd6Q2lBZ0lDQXZMeUJ3Y205MmFXUmxjajFoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2T0RjS0lDQWdJQzh2SUhScGJXVnpkR0Z0Y0QxaGNtTTBMbFZKYm5RMk5DaHViM2NwTEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHTnZkbVZ5SURFd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2T0RBdE9Ea0tJQ0FnSUM4dklHNWxkMTl5WldOdmNtUWdQU0JTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnYVdROVlYSmpOQzVWU1c1ME5qUW9jMlZzWmk1eVpXTnZjbVJmWTI5MWJuUmxjaTUyWVd4MVpTa3NDaUFnSUNBdkx5QWdJQ0FnY0dGMGFXVnVkRDF3WVhScFpXNTBMQW9nSUNBZ0x5OGdJQ0FnSUhCeWIzWnBaR1Z5UFdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnSUNCamFXUTlZMmxrTEFvZ0lDQWdMeThnSUNBZ0lIQnlaWFpwYjNWelgyTnBaRDF3Y21WMmFXOTFjMTlqYVdRc0NpQWdJQ0F2THlBZ0lDQWdjbVZqYjNKa1gzUjVjR1U5Y21WamIzSmtYM1I1Y0dVc0NpQWdJQ0F2THlBZ0lDQWdkR2x0WlhOMFlXMXdQV0Z5WXpRdVZVbHVkRFkwS0c1dmR5a3NDaUFnSUNBdkx5QWdJQ0FnWW1sc2JGOWhiVzkxYm5ROVltbHNiRjloYlc5MWJuUXNDaUFnSUNBdkx5QXBDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dPUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnd01EVmxDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhwYm5RZ09UUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk9URUtJQ0FnSUM4dklHbG1JSEJoZEdsbGJuUWdhVzRnYzJWc1ppNXdZWFJwWlc1MFgzSmxZMjl5WkhNNkNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE56QTNNalZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJoWkdSZmNtVmpiM0prWDJWc2MyVmZZbTlrZVVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2T1RJS0lDQWdJQzh2SUdGeWNpQTlJSE5sYkdZdWNHRjBhV1Z1ZEY5eVpXTnZjbVJ6VzNCaGRHbGxiblJkTG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0dGMGFXVnVkRjl5WldOdmNtUnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPamt6Q2lBZ0lDQXZMeUJoY25JdVlYQndaVzVrS0c1bGQxOXlaV052Y21RdVkyOXdlU2dwS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF3TWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOaGJHeHpkV0lnWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlpIbHVZVzFwWTE5bGJHVnRaVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZUV1ZrYVdOaGJGSmxZMjl5WkhNdlkyOXVkSEpoWTNRdWNIazZPVFFLSUNBZ0lDOHZJSE5sYkdZdWNHRjBhV1Z1ZEY5eVpXTnZjbVJ6VzNCaGRHbGxiblJkSUQwZ1lYSnlMbU52Y0hrb0tRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvS1lXUmtYM0psWTI5eVpGOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2T1RrdE1UQXdDaUFnSUNBdkx5QWpJRXh2WnlCMGJ5QkJkV1JwZEV4dlp5QmpiMjUwY21GamRDQjJhV0VnYVc1dVpYSWdkSEpoYm5OaFkzUnBiMjRnVDA1TVdTQnBaaUJwYm1sMGFXRnNhWHBsWkFvZ0lDQWdMeThnYVdZZ2MyVnNaaTVoZFdScGRGOWhjSEF1ZG1Gc2RXVWdJVDBnVlVsdWREWTBLREFwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUYxWkdsMFgyRndjQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGRXUnBkRjloY0hBZ1pYaHBjM1J6Q2lBZ0lDQmllaUJoWkdSZmNtVmpiM0prWDJGbWRHVnlYMmxtWDJWc2MyVkFOd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qRXdNUzB4TURrS0lDQWdJQzh2SUdGeVl6UXVZV0pwWDJOaGJHd29DaUFnSUNBdkx5QWdJQ0FnSW14dloxOWtZWFJoWDJGalkyVnpjMlZrS0dGa1pISmxjM01zWVdSa2NtVnpjeXh6ZEhKcGJtY3NkV2x1ZERZMExHSnZiMndwZG05cFpDSXNDaUFnSUNBdkx5QWdJQ0FnY0dGMGFXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVUZEhKcGJtY29JbFZ3Ykc5aFpHVmtJRzVsZHlCeVpXTnZjbVFpS1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h1YjNjcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVFtOXZiQ2hHWVd4elpTa3NDaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQVUZ3Y0d4cFkyRjBhVzl1S0hObGJHWXVZWFZrYVhSZllYQndMblpoYkhWbEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94TURRS0lDQWdJQzh2SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRveE1EZ0tJQ0FnSUM4dklHRndjRjlwWkQxQmNIQnNhV05oZEdsdmJpaHpaV3htTG1GMVpHbDBYMkZ3Y0M1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZWFZrYVhSZllYQndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GMVpHbDBYMkZ3Y0NCbGVHbHpkSE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPakV3TVMweE1Ea0tJQ0FnSUM4dklHRnlZelF1WVdKcFgyTmhiR3dvQ2lBZ0lDQXZMeUFnSUNBZ0lteHZaMTlrWVhSaFgyRmpZMlZ6YzJWa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4emRISnBibWNzZFdsdWREWTBMR0p2YjJ3cGRtOXBaQ0lzQ2lBZ0lDQXZMeUFnSUNBZ2NHRjBhV1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VGRISnBibWNvSWxWd2JHOWhaR1ZrSUc1bGR5QnlaV052Y21RaUtTd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNodWIzY3BMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVRbTl2YkNoR1lXeHpaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFVGd2NHeHBZMkYwYVc5dUtITmxiR1l1WVhWa2FYUmZZWEJ3TG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdiV1YwYUc5a0lDSnNiMmRmWkdGMFlWOWhZMk5sYzNObFpDaGhaR1J5WlhOekxHRmtaSEpsYzNNc2MzUnlhVzVuTEhWcGJuUTJOQ3hpYjI5c0tYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFd05Rb2dJQ0FnTHk4Z1lYSmpOQzVUZEhKcGJtY29JbFZ3Ykc5aFpHVmtJRzVsZHlCeVpXTnZjbVFpS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01UTTFOVGN3Tm1NMlpqWXhOalEyTlRZME1qQTJaVFkxTnpjeU1EY3lOalUyTXpabU56STJOQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qRXdOd29nSUNBZ0x5OGdZWEpqTkM1Q2IyOXNLRVpoYkhObEtTd0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94TURFdE1UQTVDaUFnSUNBdkx5QmhjbU0wTG1GaWFWOWpZV3hzS0FvZ0lDQWdMeThnSUNBZ0lDSnNiMmRmWkdGMFlWOWhZMk5sYzNObFpDaGhaR1J5WlhOekxHRmtaSEpsYzNNc2MzUnlhVzVuTEhWcGJuUTJOQ3hpYjI5c0tYWnZhV1FpTEFvZ0lDQWdMeThnSUNBZ0lIQmhkR2xsYm5Rc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVUzUnlhVzVuS0NKVmNHeHZZV1JsWkNCdVpYY2djbVZqYjNKa0lpa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2JtOTNLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwTEFvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxQmNIQnNhV05oZEdsdmJpaHpaV3htTG1GMVpHbDBYMkZ3Y0M1MllXeDFaU2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9LWVdSa1gzSmxZMjl5WkY5aFpuUmxjbDlwWmw5bGJITmxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZUV1ZrYVdOaGJGSmxZMjl5WkhNdlkyOXVkSEpoWTNRdWNIazZNVEUwQ2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MbkpsWTI5eVpGOWpiM1Z1ZEdWeUxuWmhiSFZsS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p5WldOZlkyOTFiblJsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaV052Y21SZlkyOTFiblJsY2lCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3hNVFlLSUNBZ0lDOHZJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94TVRFdE1USXdDaUFnSUNBdkx5QWpJRVZ0YVhRZ1FWSkRMVEk0SUdWMlpXNTBDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9DaUFnSUNBdkx5QWdJQ0FnSWxKbFkyOXlaRUZrWkdWa0tIVnBiblEyTkN4aFpHUnlaWE56TEdGa1pISmxjM01zYzNSeWFXNW5MSE4wY21sdVp5eDFhVzUwTmpRcElpd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MbkpsWTI5eVpGOWpiM1Z1ZEdWeUxuWmhiSFZsS1N3S0lDQWdJQzh2SUNBZ0lDQndZWFJwWlc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdJQ0JqYVdRc0NpQWdJQ0F2THlBZ0lDQWdjbVZqYjNKa1gzUjVjR1VzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVWU1c1ME5qUW9ibTkzS1N3S0lDQWdJQzh2SUNrS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREExTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb2FXNTBJRGcwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVEpsTURCa01XUWdMeThnYldWMGFHOWtJQ0pTWldOdmNtUkJaR1JsWkNoMWFXNTBOalFzWVdSa2NtVnpjeXhoWkdSeVpYTnpMSE4wY21sdVp5eHpkSEpwYm1jc2RXbHVkRFkwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TmpjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWVdSa1gzSmxZMjl5WkY5bGJITmxYMkp2WkhsQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRvNU5nb2dJQ0FnTHk4Z1lYSnlJRDBnWVhKak5DNUVlVzVoYldsalFYSnlZWGxiVW1WamIzSmtYU2h1WlhkZmNtVmpiM0prTG1OdmNIa29LU2tLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGd3TURBeE1EQXdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZUV1ZrYVdOaGJGSmxZMjl5WkhNdlkyOXVkSEpoWTNRdWNIazZPVGNLSUNBZ0lDOHZJSE5sYkdZdWNHRjBhV1Z1ZEY5eVpXTnZjbVJ6VzNCaGRHbGxiblJkSUQwZ1lYSnlMbU52Y0hrb0tRb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmlJR0ZrWkY5eVpXTnZjbVJmWVdaMFpYSmZhV1pmWld4elpVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TGsxbFpHbGpZV3hTWldOdmNtUnpMbU52Ym5SeVlXTjBMazFsWkdsallXeFNaV052Y21SekxtRmtaRjl3Y21WelkzSnBjSFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGhaR1JmY0hKbGMyTnlhWEIwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFeU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFek1Bb2dJQ0FnTHk4Z2MyVnNaaTV5WldOdmNtUmZZMjkxYm5SbGNpNTJZV3gxWlNBclBTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKeVpXTmZZMjkxYm5SbGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV5WldOdmNtUmZZMjkxYm5SbGNpQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnlaV05mWTI5MWJuUmxjaUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPakV6TVFvZ0lDQWdMeThnYm05M0lEMGdiM0F1UjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRveE16SUtJQ0FnSUM4dklISmxZMTlwWkNBOUlHRnlZelF1VlVsdWREWTBLSE5sYkdZdWNtVmpiM0prWDJOdmRXNTBaWEl1ZG1Gc2RXVXBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1UTTBMVEV6TlFvZ0lDQWdMeThnSXlCQlpHUWdkRzhnY0hKbGMyTnlhWEIwYVc5dUlIRjFaWFZsSUNoclpYbGxaQ0JpZVNCeGRXVjFaU0JwYm1SbGVDa0tJQ0FnSUM4dklIRjFaWFZsWDJsa2VDQTlJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVjWFZsZFdWZmJHVnVaM1JvTG5aaGJIVmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luRmZiR1Z1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuRjFaWFZsWDJ4bGJtZDBhQ0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFek5pMHhORE1LSUNBZ0lDOHZJSE5sYkdZdWNISmxjMk55YVhCMGFXOXVYM0YxWlhWbFczRjFaWFZsWDJsa2VGMGdQU0JRY21WelkzSnBjSFJwYjI1UmRXVjFaVWwwWlcwb0NpQWdJQ0F2THlBZ0lDQWdjbVZqYjNKa1gybGtQWEpsWTE5cFpDd0tJQ0FnSUM4dklDQWdJQ0J3WVhScFpXNTBQWEJoZEdsbGJuUXNDaUFnSUNBdkx5QWdJQ0FnY0dGMGFXVnVkRjl1WVcxbFBYQmhkR2xsYm5SZmJtRnRaU3dLSUNBZ0lDOHZJQ0FnSUNCamFXUTlZMmxrTEFvZ0lDQWdMeThnSUNBZ0lHbHpYMlJwYzNCbGJuTmxaRDFoY21NMExrSnZiMndvUm1Gc2MyVXBMQW9nSUNBZ0x5OGdJQ0FnSUdKcGJHeGZZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnS1M1amIzQjVLQ2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUE1Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TXpVS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHbHVkQ0ExTXdvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRveE16WUtJQ0FnSUM4dklITmxiR1l1Y0hKbGMyTnlhWEIwYVc5dVgzRjFaWFZsVzNGMVpYVmxYMmxrZUYwZ1BTQlFjbVZ6WTNKcGNIUnBiMjVSZFdWMVpVbDBaVzBvQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TnpBM01UVm1DaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFek5pMHhORE1LSUNBZ0lDOHZJSE5sYkdZdWNISmxjMk55YVhCMGFXOXVYM0YxWlhWbFczRjFaWFZsWDJsa2VGMGdQU0JRY21WelkzSnBjSFJwYjI1UmRXVjFaVWwwWlcwb0NpQWdJQ0F2THlBZ0lDQWdjbVZqYjNKa1gybGtQWEpsWTE5cFpDd0tJQ0FnSUM4dklDQWdJQ0J3WVhScFpXNTBQWEJoZEdsbGJuUXNDaUFnSUNBdkx5QWdJQ0FnY0dGMGFXVnVkRjl1WVcxbFBYQmhkR2xsYm5SZmJtRnRaU3dLSUNBZ0lDOHZJQ0FnSUNCamFXUTlZMmxrTEFvZ0lDQWdMeThnSUNBZ0lHbHpYMlJwYzNCbGJuTmxaRDFoY21NMExrSnZiMndvUm1Gc2MyVXBMQW9nSUNBZ0x5OGdJQ0FnSUdKcGJHeGZZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnS1M1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRRMENpQWdJQ0F2THlCelpXeG1MbkYxWlhWbFgyeGxibWQwYUM1MllXeDFaU0FyUFNCVlNXNTBOalFvTVNrS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnhYMnhsYmlJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRVd0NpQWdJQ0F2THlCd2NtOTJhV1JsY2oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1UVTBDaUFnSUNBdkx5QjBhVzFsYzNSaGJYQTlZWEpqTkM1VlNXNTBOalFvYm05M0tTd0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjNabGNpQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1UUTJMVEUxTmdvZ0lDQWdMeThnSXlCQmJITnZJR0ZrWkNCMGJ5QndZWFJwWlc1MEozTWdjbVZqYjNKa0lHaHBjM1J2Y25rS0lDQWdJQzh2SUc1bGQxOXlaV052Y21RZ1BTQlNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdhV1E5Y21WalgybGtMQW9nSUNBZ0x5OGdJQ0FnSUhCaGRHbGxiblE5Y0dGMGFXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCd2NtOTJhV1JsY2oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ1kybGtQV05wWkN3S0lDQWdJQzh2SUNBZ0lDQndjbVYyYVc5MWMxOWphV1E5WVhKak5DNVRkSEpwYm1jb0lpSXBMQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyOXlaRjkwZVhCbFBXRnlZelF1VTNSeWFXNW5LQ0pRY21WelkzSnBjSFJwYjI0aUtTd0tJQ0FnSUM4dklDQWdJQ0IwYVcxbGMzUmhiWEE5WVhKak5DNVZTVzUwTmpRb2JtOTNLU3dLSUNBZ0lDOHZJQ0FnSUNCaWFXeHNYMkZ0YjNWdWREMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURBMVpRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9hVzUwSURrMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1UVTFDaUFnSUNBdkx5QmlhV3hzWDJGdGIzVnVkRDFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94TkRZdE1UVTJDaUFnSUNBdkx5QWpJRUZzYzI4Z1lXUmtJSFJ2SUhCaGRHbGxiblFuY3lCeVpXTnZjbVFnYUdsemRHOXllUW9nSUNBZ0x5OGdibVYzWDNKbFkyOXlaQ0E5SUZKbFkyOXlaQ2dLSUNBZ0lDOHZJQ0FnSUNCcFpEMXlaV05mYVdRc0NpQWdJQ0F2THlBZ0lDQWdjR0YwYVdWdWREMXdZWFJwWlc1MExBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjNacFpHVnlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdJQ0JqYVdROVkybGtMQW9nSUNBZ0x5OGdJQ0FnSUhCeVpYWnBiM1Z6WDJOcFpEMWhjbU0wTGxOMGNtbHVaeWdpSWlrc0NpQWdJQ0F2THlBZ0lDQWdjbVZqYjNKa1gzUjVjR1U5WVhKak5DNVRkSEpwYm1jb0lsQnlaWE5qY21sd2RHbHZiaUlwTEFvZ0lDQWdMeThnSUNBZ0lIUnBiV1Z6ZEdGdGNEMWhjbU0wTGxWSmJuUTJOQ2h1YjNjcExBb2dJQ0FnTHk4Z0lDQWdJR0pwYkd4ZllXMXZkVzUwUFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREJqTlRBM01qWTFOek0yTXpjeU5qazNNRGMwTmprMlpqWmxDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3hOVGdLSUNBZ0lDOHZJR2xtSUhCaGRHbGxiblFnYVc0Z2MyVnNaaTV3WVhScFpXNTBYM0psWTI5eVpITTZDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjROekEzTWpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCaFpHUmZjSEpsYzJOeWFYQjBhVzl1WDJWc2MyVmZZbTlrZVVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRVNUNpQWdJQ0F2THlCaGNuSWdQU0J6Wld4bUxuQmhkR2xsYm5SZmNtVmpiM0prYzF0d1lYUnBaVzUwWFM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CaGRHbGxiblJmY21WamIzSmtjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94TmpBS0lDQWdJQzh2SUdGeWNpNWhjSEJsYm1Rb2JtVjNYM0psWTI5eVpDNWpiM0I1S0NrcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyRnNiSE4xWWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94TmpFS0lDQWdJQzh2SUhObGJHWXVjR0YwYVdWdWRGOXlaV052Y21SelczQmhkR2xsYm5SZElEMGdZWEp5TG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb0tZV1JrWDNCeVpYTmpjbWx3ZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRZMkNpQWdJQ0F2THlCcFppQnpaV3htTG1GMVpHbDBYMkZ3Y0M1MllXeDFaU0FoUFNCVlNXNTBOalFvTUNrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVhWa2FYUmZZWEJ3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRjFaR2wwWDJGd2NDQmxlR2x6ZEhNS0lDQWdJR0o2SUdGa1pGOXdjbVZ6WTNKcGNIUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1UWTNMVEUzTlFvZ0lDQWdMeThnWVhKak5DNWhZbWxmWTJGc2JDZ0tJQ0FnSUM4dklDQWdJQ0FpYkc5blgyUmhkR0ZmWVdOalpYTnpaV1FvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSE4wY21sdVp5eDFhVzUwTmpRc1ltOXZiQ2wyYjJsa0lpd0tJQ0FnSUM4dklDQWdJQ0J3WVhScFpXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbE4wY21sdVp5Z2lWWEJzYjJGa1pXUWdibVYzSUZCeVpYTmpjbWx3ZEdsdmJpQjBieUJIYkc5aVlXd2dVWFZsZFdVaUtTd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNodWIzY3BMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVRbTl2YkNoR1lXeHpaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFVGd2NHeHBZMkYwYVc5dUtITmxiR1l1WVhWa2FYUmZZWEJ3TG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRveE56QUtJQ0FnSUM4dklHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3hOelFLSUNBZ0lDOHZJR0Z3Y0Y5cFpEMUJjSEJzYVdOaGRHbHZiaWh6Wld4bUxtRjFaR2wwWDJGd2NDNTJZV3gxWlNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVhWa2FYUmZZWEJ3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRjFaR2wwWDJGd2NDQmxlR2x6ZEhNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFMk55MHhOelVLSUNBZ0lDOHZJR0Z5WXpRdVlXSnBYMk5oYkd3b0NpQWdJQ0F2THlBZ0lDQWdJbXh2WjE5a1lYUmhYMkZqWTJWemMyVmtLR0ZrWkhKbGMzTXNZV1JrY21WemN5eHpkSEpwYm1jc2RXbHVkRFkwTEdKdmIyd3BkbTlwWkNJc0NpQWdJQ0F2THlBZ0lDQWdjR0YwYVdWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVRkSEpwYm1jb0lsVndiRzloWkdWa0lHNWxkeUJRY21WelkzSnBjSFJwYjI0Z2RHOGdSMnh2WW1Gc0lGRjFaWFZsSWlrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYm05M0tTd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExrSnZiMndvUm1Gc2MyVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGd2NGOXBaRDFCY0hCc2FXTmhkR2x2YmloelpXeG1MbUYxWkdsMFgyRndjQzUyWVd4MVpTa3NDaUFnSUNBdkx5QXBDaUFnSUNCaWVYUmxZeUE0SUM4dklHMWxkR2h2WkNBaWJHOW5YMlJoZEdGZllXTmpaWE56WldRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhOMGNtbHVaeXgxYVc1ME5qUXNZbTl2YkNsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1JwWnlBMUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94TnpFS0lDQWdJQzh2SUdGeVl6UXVVM1J5YVc1bktDSlZjR3h2WVdSbFpDQnVaWGNnVUhKbGMyTnlhWEIwYVc5dUlIUnZJRWRzYjJKaGJDQlJkV1YxWlNJcExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXlPVFUxTnpBMll6Wm1OakUyTkRZMU5qUXlNRFpsTmpVM056SXdOVEEzTWpZMU56TTJNemN5TmprM01EYzBOamsyWmpabE1qQTNORFptTWpBME56WmpObVkyTWpZeE5tTXlNRFV4TnpVMk5UYzFOalVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3hOREVLSUNBZ0lDOHZJR2x6WDJScGMzQmxibk5sWkQxaGNtTTBMa0p2YjJ3b1JtRnNjMlVwTEFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qRTJOeTB4TnpVS0lDQWdJQzh2SUdGeVl6UXVZV0pwWDJOaGJHd29DaUFnSUNBdkx5QWdJQ0FnSW14dloxOWtZWFJoWDJGalkyVnpjMlZrS0dGa1pISmxjM01zWVdSa2NtVnpjeXh6ZEhKcGJtY3NkV2x1ZERZMExHSnZiMndwZG05cFpDSXNDaUFnSUNBdkx5QWdJQ0FnY0dGMGFXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ1lYSmpOQzVUZEhKcGJtY29JbFZ3Ykc5aFpHVmtJRzVsZHlCUWNtVnpZM0pwY0hScGIyNGdkRzhnUjJ4dlltRnNJRkYxWlhWbElpa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2JtOTNLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwTEFvZ0lDQWdMeThnSUNBZ0lHRndjRjlwWkQxQmNIQnNhV05oZEdsdmJpaHpaV3htTG1GMVpHbDBYMkZ3Y0M1MllXeDFaU2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9LWVdSa1gzQnlaWE5qY21sd2RHbHZibDloWm5SbGNsOXBabDlsYkhObFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1UYzNMVEU0TWdvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0FvZ0lDQWdMeThnSUNBZ0lDSlFjbVZ6WTNKcGNIUnBiMjVCWkdSbFpGUnZVWFZsZFdVb2RXbHVkRFkwTEdGa1pISmxjM01zYzNSeWFXNW5LU0lzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpYMmxrTEFvZ0lDQWdMeThnSUNBZ0lIQmhkR2xsYm5Rc0NpQWdJQ0F2THlBZ0lDQWdjR0YwYVdWdWRGOXVZVzFsTEFvZ0lDQWdMeThnS1FvZ0lDQWdaR2xuSURJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01tRUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpJMU0yRTBOellnTHk4Z2JXVjBhRzlrSUNKUWNtVnpZM0pwY0hScGIyNUJaR1JsWkZSdlVYVmxkV1VvZFdsdWREWTBMR0ZrWkhKbGMzTXNjM1J5YVc1bktTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1USXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtRmtaRjl3Y21WelkzSnBjSFJwYjI1ZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1UWXpDaUFnSUNBdkx5QmhjbklnUFNCaGNtTTBMa1I1Ym1GdGFXTkJjbkpoZVZ0U1pXTnZjbVJkS0c1bGQxOXlaV052Y21RdVkyOXdlU2dwS1FvZ0lDQWdZbmwwWldNZ09TQXZMeUF3ZURBd01ERXdNREF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94TmpRS0lDQWdJQzh2SUhObGJHWXVjR0YwYVdWdWRGOXlaV052Y21SelczQmhkR2xsYm5SZElEMGdZWEp5TG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JpSUdGa1pGOXdjbVZ6WTNKcGNIUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TGsxbFpHbGpZV3hTWldOdmNtUnpMbU52Ym5SeVlXTjBMazFsWkdsallXeFNaV052Y21SekxtZGxkRjl3Wlc1a2FXNW5YM0J5WlhOamNtbHdkR2x2Ym5OYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmY0dWdVpHbHVaMTl3Y21WelkzSnBjSFJwYjI1ek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG94T0RrS0lDQWdJQzh2SUhCbGJtUnBibWNnUFNCaGNtTTBMa1I1Ym1GdGFXTkJjbkpoZVZ0UWNtVnpZM0pwY0hScGIyNVJkV1YxWlVsMFpXMWRLQ2tLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJREI0TURBd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFNU1Bb2dJQ0FnTHk4Z2RHOTBZV3dnUFNCelpXeG1MbkYxWlhWbFgyeGxibWQwYUM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luRmZiR1Z1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuRjFaWFZsWDJ4bGJtZDBhQ0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRveE9URUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoMGIzUmhiQ2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWjJWMFgzQmxibVJwYm1kZmNISmxjMk55YVhCMGFXOXVjMTltYjNKZmFHVmhaR1Z5UURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRreENpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvZEc5MFlXd3BPZ29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BBb2dJQ0FnWW5vZ1oyVjBYM0JsYm1ScGJtZGZjSEpsYzJOeWFYQjBhVzl1YzE5aFpuUmxjbDltYjNKQU53b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFNU1nb2dJQ0FnTHk4Z2FYUmxiU0E5SUhObGJHWXVjSEpsYzJOeWFYQjBhVzl1WDNGMVpYVmxXMkZ5WXpRdVZVbHVkRFkwS0drcFhTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURjd056RTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0oxY25rZ05nb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNISmxjMk55YVhCMGFXOXVYM0YxWlhWbElHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qRTVNaTB4T1RNS0lDQWdJQzh2SUdsMFpXMGdQU0J6Wld4bUxuQnlaWE5qY21sd2RHbHZibDl4ZFdWMVpWdGhjbU0wTGxWSmJuUTJOQ2hwS1YwdVkyOXdlU2dwQ2lBZ0lDQXZMeUJwWmlCdWIzUWdhWFJsYlM1cGMxOWthWE53Wlc1elpXUXVibUYwYVhabE9nb2dJQ0FnY0hWemFHbHVkQ0EwTkFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1Ua3pDaUFnSUNBdkx5QnBaaUJ1YjNRZ2FYUmxiUzVwYzE5a2FYTndaVzV6WldRdWJtRjBhWFpsT2dvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSnVlaUJuWlhSZmNHVnVaR2x1WjE5d2NtVnpZM0pwY0hScGIyNXpYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFNU5Bb2dJQ0FnTHk4Z2NHVnVaR2x1Wnk1aGNIQmxibVFvYVhSbGJTNWpiM0I1S0NrcENpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURBd01nb2dJQ0FnWkdsbklEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTJGc2JITjFZaUJrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5a2VXNWhiV2xqWDJWc1pXMWxiblFLSUNBZ0lHSjFjbmtnTXdvS1oyVjBYM0JsYm1ScGJtZGZjSEpsYzJOeWFYQjBhVzl1YzE5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZUV1ZrYVdOaGJGSmxZMjl5WkhNdlkyOXVkSEpoWTNRdWNIazZNVGt4Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9kRzkwWVd3cE9nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJR2RsZEY5d1pXNWthVzVuWDNCeVpYTmpjbWx3ZEdsdmJuTmZabTl5WDJobFlXUmxja0F5Q2dwblpYUmZjR1Z1WkdsdVoxOXdjbVZ6WTNKcGNIUnBiMjV6WDJGbWRHVnlYMlp2Y2tBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pFNE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVRXVmthV05oYkZKbFkyOXlaSE11WTI5dWRISmhZM1F1VFdWa2FXTmhiRkpsWTI5eVpITXViV0Z5YTE5d2NtVnpZM0pwY0hScGIyNWZaR2x6Y0dWdWMyVmtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYldGeWExOXdjbVZ6WTNKcGNIUnBiMjVmWkdsemNHVnVjMlZrT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjRzRnTndvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEJ1SURFeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRrM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRveU1EUUtJQ0FnSUM4dklIUnZkR0ZzSUQwZ2MyVnNaaTV4ZFdWMVpWOXNaVzVuZEdndWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnhYMnhsYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXhkV1YxWlY5c1pXNW5kR2dnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1qQTFDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2RHOTBZV3dwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ20xaGNtdGZjSEpsYzJOeWFYQjBhVzl1WDJScGMzQmxibk5sWkY5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1qQTFDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb2RHOTBZV3dwT2dvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2diV0Z5YTE5d2NtVnpZM0pwY0hScGIyNWZaR2x6Y0dWdWMyVmtYMkZtZEdWeVgyWnZja0F4TlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPakl3TmdvZ0lDQWdMeThnYVdSNElEMGdZWEpqTkM1VlNXNTBOalFvYVNrS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPakl3TndvZ0lDQWdMeThnYVhSbGJTQTlJSE5sYkdZdWNISmxjMk55YVhCMGFXOXVYM0YxWlhWbFcybGtlRjB1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZeUEySUM4dklEQjROekEzTVRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNd29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkWEo1SURJeUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d2NtVnpZM0pwY0hScGIyNWZjWFZsZFdVZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1qQTNMVEl3T0FvZ0lDQWdMeThnYVhSbGJTQTlJSE5sYkdZdWNISmxjMk55YVhCMGFXOXVYM0YxWlhWbFcybGtlRjB1WTI5d2VTZ3BDaUFnSUNBdkx5QnBaaUJwZEdWdExuSmxZMjl5WkY5cFpDQTlQU0J5WldOdmNtUmZhV1E2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TWpBNENpQWdJQ0F2THlCcFppQnBkR1Z0TG5KbFkyOXlaRjlwWkNBOVBTQnlaV052Y21SZmFXUTZDaUFnSUNCa2FXY2dOQW9nSUNBZ1lqMDlDaUFnSUNCaWVpQnRZWEpyWDNCeVpYTmpjbWx3ZEdsdmJsOWthWE53Wlc1elpXUmZZV1owWlhKZmFXWmZaV3h6WlVBeE13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pJd09Rb2dJQ0FnTHk4Z2FYUmxiUzVwYzE5a2FYTndaVzV6WldRZ1BTQmhjbU0wTGtKdmIyd29WSEoxWlNrS0lDQWdJR1JwWnlBeE9Rb2dJQ0FnY0hWemFHbHVkQ0F6TlRJS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG95TVRBS0lDQWdJQzh2SUdsMFpXMHVZbWxzYkY5aGJXOTFiblFnUFNCaWFXeHNYMkZ0YjNWdWRBb2dJQ0FnWkdsbklETUtJQ0FnSUhKbGNHeGhZMlV5SURRMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TWpFeENpQWdJQ0F2THlCelpXeG1MbkJ5WlhOamNtbHdkR2x2Ymw5eGRXVjFaVnRwWkhoZElEMGdhWFJsYlM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF5TWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1qRXpMVEl4TkFvZ0lDQWdMeThnSXlCVmNHUmhkR1VnZEdobElIQmhkR2xsYm5RbmN5QnlaV052Y21RZ2FHbHpkRzl5ZVNCM2FYUm9JSFJvWlNCaWFXeHNJR0Z0YjNWdWRBb2dJQ0FnTHk4Z2NHRjBhV1Z1ZENBOUlHbDBaVzB1Y0dGMGFXVnVkQW9nSUNBZ1pYaDBjbUZqZENBNElETXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1qRTFDaUFnSUNBdkx5QnBaaUJ3WVhScFpXNTBJR2x1SUhObGJHWXVjR0YwYVdWdWRGOXlaV052Y21Sek9nb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEY3dOekkxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01qSUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nYldGeWExOXdjbVZ6WTNKcGNIUnBiMjVmWkdsemNHVnVjMlZrWDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3lNVFlLSUNBZ0lDOHZJR0Z5Y2lBOUlITmxiR1l1Y0dGMGFXVnVkRjl5WldOdmNtUnpXM0JoZEdsbGJuUmRMbU52Y0hrb0tRb2dJQ0FnWkdsbklESXdDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjFjbmtnTWpZS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CaGRHbGxiblJmY21WamIzSmtjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG95TVRZdE1qRTNDaUFnSUNBdkx5QmhjbklnUFNCelpXeG1MbkJoZEdsbGJuUmZjbVZqYjNKa2MxdHdZWFJwWlc1MFhTNWpiM0I1S0NrS0lDQWdJQzh2SUdadmNpQnFJR2x1SUhWeVlXNW5aU2hoY25JdWJHVnVaM1JvS1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdKMWNua2dNVE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3lNVGNLSUNBZ0lDOHZJR1p2Y2lCcUlHbHVJSFZ5WVc1blpTaGhjbkl1YkdWdVozUm9LVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJREV3Q2dwdFlYSnJYM0J5WlhOamNtbHdkR2x2Ymw5a2FYTndaVzV6WldSZlptOXlYMmhsWVdSbGNrQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwMWxaR2xqWVd4U1pXTnZjbVJ6TDJOdmJuUnlZV04wTG5CNU9qSXhOd29nSUNBZ0x5OGdabTl5SUdvZ2FXNGdkWEpoYm1kbEtHRnljaTVzWlc1bmRHZ3BPZ29nSUNBZ1pHbG5JRGtLSUNBZ0lHUnBaeUF4TXdvZ0lDQWdQQW9nSUNBZ1lub2diV0Z5YTE5d2NtVnpZM0pwY0hScGIyNWZaR2x6Y0dWdWMyVmtYMkZtZEdWeVgyWnZja0F4TVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPakl4T0FvZ0lDQWdMeThnY21WaklEMGdZWEp5VzJwZExtTnZjSGtvS1FvZ0lDQWdaR2xuSURJekNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0oxY25rZ01qVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0oxY25rZ01UZ0tJQ0FnSUdScFp5QXhNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdKMWNua2dNVEFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeU1Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdMU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1luVnllU0F4T0FvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDb0tJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNQW9nSUNBZ1pHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRRS0lDQWdJSE4zWVhBS0lDQWdJSE5sYkdWamRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1luVnllU0F4T1FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPakl4T0MweU1Ua0tJQ0FnSUM4dklISmxZeUE5SUdGeWNsdHFYUzVqYjNCNUtDa0tJQ0FnSUM4dklHbG1JSEpsWXk1cFpDQTlQU0J5WldOdmNtUmZhV1E2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5TVFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMDFsWkdsallXeFNaV052Y21SekwyTnZiblJ5WVdOMExuQjVPakl4T1FvZ0lDQWdMeThnYVdZZ2NtVmpMbWxrSUQwOUlISmxZMjl5WkY5cFpEb0tJQ0FnSUdScFp5QTBDaUFnSUNCaVBUMEtJQ0FnSUdKNklHMWhjbXRmY0hKbGMyTnlhWEIwYVc5dVgyUnBjM0JsYm5ObFpGOWhablJsY2w5cFpsOWxiSE5sUURrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlOWldScFkyRnNVbVZqYjNKa2N5OWpiMjUwY21GamRDNXdlVG95TWpBS0lDQWdJQzh2SUhKbFl5NWlhV3hzWDJGdGIzVnVkQ0E5SUdKcGJHeGZZVzF2ZFc1MENpQWdJQ0JrYVdjZ01UY0tJQ0FnSUdScFp5QXpDaUFnSUNCeVpYQnNZV05sTWlBNE5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pJeU1Rb2dJQ0FnTHk4Z1lYSnlXMnBkSUQwZ2NtVmpMbU52Y0hrb0tRb2dJQ0FnWkdsbklERXdDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXhPQW9nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ01qVUtJQ0FnSUhOMVluTjBjbWx1WnlBd0lESUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdENpQWdJQ0JrYVdjZ01UUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pHbG5JREV5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMUW9nSUNBZ1luVnllU0F4TWdvZ0lDQWdaR2xuSURRS0lDQWdJR3hsYmdvZ0lDQWdZblZ5ZVNBeE5Bb2dJQ0FnWkdsbklESTNDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5WeWVTQXlNQW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNvS0lDQWdJR0oxY25rZ05Rb2dJQ0FnWkdsbklERXpDaUFnSUNCaWRYSjVJREV4Q2dwdFlYSnJYM0J5WlhOamNtbHdkR2x2Ymw5a2FYTndaVzV6WldSZlptOXlYMmhsWVdSbGNrQXhOem9LSUNBZ0lHUnBaeUF4TUFvZ0lDQWdaR2xuSURVS0lDQWdJRHdLSUNBZ0lHSjZJRzFoY210ZmNISmxjMk55YVhCMGFXOXVYMlJwYzNCbGJuTmxaRjloWm5SbGNsOW1iM0pBTVRrS0lDQWdJR1JwWnlBeE9Bb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01USUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF4TVFvZ0lDQWdLd29nSUNBZ1pHbG5JRGtLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVE1LSUNBZ0lHSjFjbmtnTWpBS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQmlJRzFoY210ZmNISmxjMk55YVhCMGFXOXVYMlJwYzNCbGJuTmxaRjltYjNKZmFHVmhaR1Z5UURFM0NncHRZWEpyWDNCeVpYTmpjbWx3ZEdsdmJsOWthWE53Wlc1elpXUmZZV1owWlhKZlptOXlRREU1T2dvZ0lDQWdaR2xuSURFMkNpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1luVnllU0F5TkFvS2JXRnlhMTl3Y21WelkzSnBjSFJwYjI1ZlpHbHpjR1Z1YzJWa1gyRm1kR1Z5WDJadmNrQXhNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3lNak1LSUNBZ0lDOHZJSE5sYkdZdWNHRjBhV1Z1ZEY5eVpXTnZjbVJ6VzNCaGRHbGxiblJkSUQwZ1lYSnlMbU52Y0hrb0tRb2dJQ0FnWkdsbklESXdDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1pHbG5JREkwQ2lBZ0lDQmliM2hmY0hWMENncHRZWEpyWDNCeVpYTmpjbWx3ZEdsdmJsOWthWE53Wlc1elpXUmZZV1owWlhKZmFXWmZaV3h6WlVBeE1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRveU1qVXRNakk1Q2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvQ2lBZ0lDQXZMeUFnSUNBZ0lsQnlaWE5qY21sd2RHbHZia1JwYzNCbGJuTmxaQ2gxYVc1ME5qUXNkV2x1ZERZMEtTSXNDaUFnSUNBdkx5QWdJQ0FnY21WamIzSmtYMmxrTEFvZ0lDQWdMeThnSUNBZ0lHSnBiR3hmWVcxdmRXNTBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdVd01HWXdZV1ppSUM4dklHMWxkR2h2WkNBaVVISmxjMk55YVhCMGFXOXVSR2x6Y0dWdWMyVmtLSFZwYm5RMk5DeDFhVzUwTmpRcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tDbTFoY210ZmNISmxjMk55YVhCMGFXOXVYMlJwYzNCbGJuTmxaRjloWm5SbGNsOW1iM0pBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VFdWa2FXTmhiRkpsWTI5eVpITXZZMjl1ZEhKaFkzUXVjSGs2TVRrM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGNtdGZjSEpsYzJOeWFYQjBhVzl1WDJScGMzQmxibk5sWkY5aFpuUmxjbDlwWmw5bGJITmxRRGs2Q2lBZ0lDQmthV2NnTVRRS0lDQWdJR0oxY25rZ01UQUtJQ0FnSUdJZ2JXRnlhMTl3Y21WelkzSnBjSFJwYjI1ZlpHbHpjR1Z1YzJWa1gyWnZjbDlvWldGa1pYSkFOZ29LYldGeWExOXdjbVZ6WTNKcGNIUnBiMjVmWkdsemNHVnVjMlZrWDJGbWRHVnlYMmxtWDJWc2MyVkFNVE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZUV1ZrYVdOaGJGSmxZMjl5WkhNdlkyOXVkSEpoWTNRdWNIazZNakExQ2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9kRzkwWVd3cE9nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJRzFoY210ZmNISmxjMk55YVhCMGFXOXVYMlJwYzNCbGJuTmxaRjltYjNKZmFHVmhaR1Z5UURJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVUV1ZrYVdOaGJGSmxZMjl5WkhNdVkyOXVkSEpoWTNRdVRXVmthV05oYkZKbFkyOXlaSE11WjJWMFgzQmhkR2xsYm5SZmNtVmpiM0prYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjl3WVhScFpXNTBYM0psWTI5eVpITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1qTXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5TlpXUnBZMkZzVW1WamIzSmtjeTlqYjI1MGNtRmpkQzV3ZVRveU16Y0tJQ0FnSUM4dklHbG1JSEJoZEdsbGJuUWdhVzRnYzJWc1ppNXdZWFJwWlc1MFgzSmxZMjl5WkhNNkNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE56QTNNalZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQm5aWFJmY0dGMGFXVnVkRjl5WldOdmNtUnpYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pJek9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVjR0YwYVdWdWRGOXlaV052Y21SelczQmhkR2xsYm5SZExtTnZjSGtvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d1lYUnBaVzUwWDNKbFkyOXlaSE1nWlc1MGNua2daWGhwYzNSekNncG5aWFJmY0dGMGFXVnVkRjl5WldOdmNtUnpYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TGsxbFpHbGpZV3hTWldOdmNtUnpMbU52Ym5SeVlXTjBMazFsWkdsallXeFNaV052Y21SekxtZGxkRjl3WVhScFpXNTBYM0psWTI5eVpITkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OU5aV1JwWTJGc1VtVmpiM0prY3k5amIyNTBjbUZqZEM1d2VUb3lNeklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldNZ01URWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGxkRjl3WVhScFpXNTBYM0psWTI5eVpITmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDAxbFpHbGpZV3hTWldOdmNtUnpMMk52Ym5SeVlXTjBMbkI1T2pJek9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVSSGx1WVcxcFkwRnljbUY1VzFKbFkyOXlaRjBvS1FvZ0lDQWdZbmwwWldNZ01UQWdMeThnTUhnd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlRXVmthV05oYkZKbFkyOXlaSE12WTI5dWRISmhZM1F1Y0hrNk1qTXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdaMlYwWDNCaGRHbGxiblJmY21WamIzSmtjMTloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1TlpXUnBZMkZzVW1WamIzSmtjeTVqYjI1MGNtRmpkQzVOWldScFkyRnNVbVZqYjNKa2N5NW5aWFJmY0dGMGFXVnVkRjl5WldOdmNtUnpRRFFLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBSUJDQ1lNQzNKbFkxOWpiM1Z1ZEdWeUNXRjFaR2wwWDJGd2NBVnhYMnhsYmdOd2NsOENBQUlCQUFOd2NWOENBRjRFdmVHWkFnUUFBUUFDQWdBQUJCVWZmSFV4R0VBQUNTZ2laeWtpWnlvaVp6RWJRUUE1TVJrVVJERVlSSUlHQktESzM0b0VDaWRGVFFUd0RQS0xCQU9XYStzRXh6WHhLQVFTeXhiZ05ob0FqZ1lBaWdDWUFkQURPd09QQlF3QU1Sa1VNUmdVRUVPS0JBR0FBRW1ML2lNTGkvd2pDeUtMQklzRERFRUFISXY5aXdSSlRnSlppd0lJRmxjR0Fvc0JURkNNQVNNSWpBUkMvOXlML1JXTUFDS01CSXNFaXdJTVFRQWNpLytMQkVsT0FsbUxBQWdXVndZQ2l3Rk1VSXdCSXdpTUJFTC8zSXY4aS80SUZsY0dBb3NCVUl2OWl3T0xBRkpRaS84VmkvK0xBazhDVWxDTUFJazJHZ0ZKRlNVU1JCY3BUR2NrUXpZYUFVY0NGWUVnRWtRMkdnSkpUZ0pKSWxrakNFc0JGVWxPQkVsUEFoSkVOaG9EU1NKWkl3aExBUlZKVHdJU1JEWWFCRWxPQmtraVdTTUlTd0VWRWtRMkdnVkpGU1VTUkNJb1pVUWtDQ2hMQVdjeUIwd1dNUUJQQWhaSlRnTk9Da3hMQ1ZCTVVDY0hVSUZlVHdjSVNSWlhCZ0pQQWt4UVRFOEZDQlpYQmdKUVRGQk1VRThEVUU4Q1VFeFFUQ3RNVUVsT0FyMUZBVUVBa1VzQlNiNUVTU0paVEZjQ0FDY0VUd1JRVGdJa1R3T0kvcjlMQWJ4SXZ5SXBaVVJCQUR5eE1RQWlLV1ZFc2hnbkNMSWFTd2F5R3JJYWdCVUFFMVZ3Ykc5aFpHVmtJRzVsZHlCeVpXTnZjbVN5R2tzQnNob25CYklhZ1FheUVDS3lBYk1pS0dWRUZqRUFURXNIVUV4UWdBSUFWRkNCVkVzRkNCWlhCZ0pRU3dKUVN3VlFTd05RZ0FRUzRBMGRURkN3SkVNbkNVeFFTd0ZKdkVoTXYwTC9mellhQVVjQ0ZZRWdFa1EyR2dKSlRnSkpJbGtqQ0VzQkZVbFBBaEpFTmhvRFNTSlpJd2hMQVJWSlR3SVNSQ0lvWlVRa0NDaExBV2N5QjB3V0lpcGxSRWtXVHdKTENGQkpUZ2xKZ0FJQU5WQ0JOVThJQ0JaWEJnSlFnQWtBQUFBQUFBQUFBQUJRVHdkUVN3WlFKd1pQQTFCSnZFaE12MHdrQ0NwTVp6RUFUd0lXU1U0Q1RnWlBBa3hRSndkUWdWNVBBd2hKRmxjR0FrOENURkJNSXdnV1Z3WUNVRXhRZ0FnQUFBQUFBQUFBQUZCTVVJQVFBQUFBREZCeVpYTmpjbWx3ZEdsdmJsQk1LMHhRU1U0Q3ZVVUJRUUNNU3dGSnZrUkpJbGxNVndJQUp3UlBCRkJPQWlSUEE0ajlUMHNCdkVpL0lpbGxSRUVBVXJFeEFDSXBaVVN5R0NjSXNocExCYklhc2hxQUt3QXBWWEJzYjJGa1pXUWdibVYzSUZCeVpYTmpjbWx3ZEdsdmJpQjBieUJIYkc5aVlXd2dVWFZsZFdXeUdrc0JzaG9uQmJJYWdRYXlFQ0t5QWJOTEFvQUNBQ3BRU3dSUWdBUmlVNlIyVEZDd0pFTW5DVXhRU3dGSnZFaE12MEwvaENJbkNpSXFaVVFpU1VzQ0RFRUFQVWtXSndaTVVFbStURVVHUklFc0pMb2lVeWNGSWs4Q1ZDSlRRQUFZU3dKSklsbE1Wd0lBSndSTEJsQk9BaVJQQTRqOGpFVURTU1FJUlFGQy83d25DMHNEVUxBa1F5SkhCNEFBUndzMkdnRkpGU1VTUkRZYUFra1ZKUkpFSWlwbFJDSkpTd0lNUVFGSlNSWW5Ca3hRU1VVWFNiNU1SUlpFSWlXNlN3U29RUUU2U3hPQjRBSWtWRXNEWEMxTEZrbThTRXNCdjFjSUlDdE1VRWxGRnIxRkFVRUJBVXNVU2I1TVJScEVJaU82RjBVTklrVUtTd2xMRFF4QkFPQkxGMGxYQWdCSlRnSkZHU0paU1U0Q1JSSkxDMGtqQzBzQ1RGbEpUZ1JGQ2tra0NFbEZGRThEU3dFSlN3TVZTVTREUlJKTUl3dEpSUlJMQkV4WlNVVU9URTFQQWs4RFR3SlNSUk1qQ3lNSVN4VkpUd0lqdWhjakNDVzZTd1NvUVFDWFN4RkxBMXhXU3dwSlN4SU1SRXNaVVFBQ1NVVVVGMGxQQWdra0NVc09TVTRDU3d4UEFrMUpTd3BKVGdJSlJReExCQlZGRGtzYlNVNERJazhDVWs4RlVFNENUd05TVUVVVUl3dEZCVXNOUlF0TENrc0ZERUVBSUVzU1NVc01TVTREV1VzTENFc0pDUlpYQmdKTEFreGRSUlFqQ0VVTFF2L1lTeEJMRTFCRkdFc1VTYnhJU3hpL1N3TkxBMUNBQk9BUEN2dE1VTEFrUTBzT1JRcEMvdmxKSkFoRkFVTCtuellhQVVrVmdTQVNSQ3RNVUVtOVJRRkJBQXBKdmtRbkMweFFzQ1JESndwQy8vUT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJSZWNvcmRBZGRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUHJlc2NyaXB0aW9uQWRkZWRUb1F1ZXVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlByZXNjcmlwdGlvbkRpc3BlbnNlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
