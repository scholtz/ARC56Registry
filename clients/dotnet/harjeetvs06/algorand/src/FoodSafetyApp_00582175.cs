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

namespace Arc56.Generated.harjeetvs06.algorand.FoodSafetyApp_00582175
{


    //
    // Food Safety & Traceability application.
    //
    //    Uses one box per `batch_id` to store a BatchRecord struct.
    //    
    //
    public class FoodSafetyAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FoodSafetyAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class BatchRecord : AVMObjectType
            {
                public string Producer { get; set; }

                public string ProductName { get; set; }

                public string OriginLocation { get; set; }

                public ulong HarvestDate { get; set; }

                public ulong Status { get; set; }

                public string IpfsHash { get; set; }

                public string InspectionReportHash { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProducer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProducer.From(Producer);
                    stringRef[ret.Count] = vProducer.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProductName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProductName.From(ProductName);
                    stringRef[ret.Count] = vProductName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOriginLocation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOriginLocation.From(OriginLocation);
                    stringRef[ret.Count] = vOriginLocation.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHarvestDate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vHarvestDate.From(HarvestDate);
                    ret.AddRange(vHarvestDate.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpfsHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vIpfsHash.From(IpfsHash);
                    stringRef[ret.Count] = vIpfsHash.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInspectionReportHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vInspectionReportHash.From(InspectionReportHash);
                    stringRef[ret.Count] = vInspectionReportHash.Encode();
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

                public static BatchRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new BatchRecord();
                    uint count = 0;
                    var indexProducer = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProducer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProducer.Decode(bytes.Skip(indexProducer + prefixOffset).ToArray());
                    var valueProducer = vProducer.ToValue();
                    if (valueProducer is string vProducerValue) { ret.Producer = vProducerValue; }
                    var indexProductName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProductName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vProductName.Decode(bytes.Skip(indexProductName + prefixOffset).ToArray());
                    var valueProductName = vProductName.ToValue();
                    if (valueProductName is string vProductNameValue) { ret.ProductName = vProductNameValue; }
                    var indexOriginLocation = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOriginLocation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vOriginLocation.Decode(bytes.Skip(indexOriginLocation + prefixOffset).ToArray());
                    var valueOriginLocation = vOriginLocation.ToValue();
                    if (valueOriginLocation is string vOriginLocationValue) { ret.OriginLocation = vOriginLocationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHarvestDate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vHarvestDate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHarvestDate = vHarvestDate.ToValue();
                    if (valueHarvestDate is ulong vHarvestDateValue) { ret.HarvestDate = vHarvestDateValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    var indexIpfsHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIpfsHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vIpfsHash.Decode(bytes.Skip(indexIpfsHash + prefixOffset).ToArray());
                    var valueIpfsHash = vIpfsHash.ToValue();
                    if (valueIpfsHash is string vIpfsHashValue) { ret.IpfsHash = vIpfsHashValue; }
                    var indexInspectionReportHash = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInspectionReportHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vInspectionReportHash.Decode(bytes.Skip(indexInspectionReportHash + prefixOffset).ToArray());
                    var valueInspectionReportHash = vInspectionReportHash.ToValue();
                    if (valueInspectionReportHash is string vInspectionReportHashValue) { ret.InspectionReportHash = vInspectionReportHashValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BatchRecord);
                }
                public bool Equals(BatchRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BatchRecord left, BatchRecord right)
                {
                    return EqualityComparer<BatchRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(BatchRecord left, BatchRecord right)
                {
                    return !(left == right);
                }

            }

            public class GetBatchReturn : AVMObjectType
            {
                public string Field0 { get; set; }

                public string Field1 { get; set; }

                public string Field2 { get; set; }

                public string Field3 { get; set; }

                public ulong Field4 { get; set; }

                public ulong Field5 { get; set; }

                public string Field6 { get; set; }

                public string Field7 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.From(Field0);
                    stringRef[ret.Count] = vField0.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.From(Field3);
                    stringRef[ret.Count] = vField3.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField6.From(Field6);
                    stringRef[ret.Count] = vField6.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField7.From(Field7);
                    stringRef[ret.Count] = vField7.Encode();
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

                public static GetBatchReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetBatchReturn();
                    uint count = 0;
                    var indexField0 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField0.Decode(bytes.Skip(indexField0 + prefixOffset).ToArray());
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is string vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    var indexField2 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.Decode(bytes.Skip(indexField2 + prefixOffset).ToArray());
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is string vField2Value) { ret.Field2 = vField2Value; }
                    var indexField3 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField3.Decode(bytes.Skip(indexField3 + prefixOffset).ToArray());
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is string vField3Value) { ret.Field3 = vField3Value; }
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
                    var indexField6 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField6.Decode(bytes.Skip(indexField6 + prefixOffset).ToArray());
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is string vField6Value) { ret.Field6 = vField6Value; }
                    var indexField7 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField7.Decode(bytes.Skip(indexField7 + prefixOffset).ToArray());
                    var valueField7 = vField7.ToValue();
                    if (valueField7 is string vField7Value) { ret.Field7 = vField7Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetBatchReturn);
                }
                public bool Equals(GetBatchReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetBatchReturn left, GetBatchReturn right)
                {
                    return EqualityComparer<GetBatchReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetBatchReturn left, GetBatchReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Create a new batch. producer_address should be the account address string (58-char base32). Initial status = 0 (CREATED).
        ///</summary>
        /// <param name="batch_id"> </param>
        /// <param name="producer_address"> </param>
        /// <param name="product_name"> </param>
        /// <param name="origin_location"> </param>
        /// <param name="harvest_date"> </param>
        /// <param name="ipfs_hash"> </param>
        public async Task CreateBatch(string batch_id, string producer_address, string product_name, string origin_location, ulong harvest_date, string ipfs_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 126, 137, 102 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); batch_idAbi.From(batch_id);
            var producer_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); producer_addressAbi.From(producer_address);
            var product_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); product_nameAbi.From(product_name);
            var origin_locationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); origin_locationAbi.From(origin_location);
            var harvest_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); harvest_dateAbi.From(harvest_date);
            var ipfs_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_hashAbi.From(ipfs_hash);

            var result = await base.CallApp(new List<object> { abiHandle, batch_idAbi, producer_addressAbi, product_nameAbi, origin_locationAbi, harvest_dateAbi, ipfs_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateBatch_Transactions(string batch_id, string producer_address, string product_name, string origin_location, ulong harvest_date, string ipfs_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 126, 137, 102 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); batch_idAbi.From(batch_id);
            var producer_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); producer_addressAbi.From(producer_address);
            var product_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); product_nameAbi.From(product_name);
            var origin_locationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); origin_locationAbi.From(origin_location);
            var harvest_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); harvest_dateAbi.From(harvest_date);
            var ipfs_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_hashAbi.From(ipfs_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, batch_idAbi, producer_addressAbi, product_nameAbi, origin_locationAbi, harvest_dateAbi, ipfs_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Inspect a batch. Only allowed when status == CREATED (0). approved: non-zero -> APPROVED, zero -> REJECTED
        ///</summary>
        /// <param name="batch_id"> </param>
        /// <param name="inspection_report_hash"> </param>
        /// <param name="approved"> </param>
        public async Task InspectBatch(string batch_id, string inspection_report_hash, ulong approved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 185, 5, 254 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); batch_idAbi.From(batch_id);
            var inspection_report_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); inspection_report_hashAbi.From(inspection_report_hash);
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvedAbi.From(approved);

            var result = await base.CallApp(new List<object> { abiHandle, batch_idAbi, inspection_report_hashAbi, approvedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InspectBatch_Transactions(string batch_id, string inspection_report_hash, ulong approved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 185, 5, 254 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); batch_idAbi.From(batch_id);
            var inspection_report_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); inspection_report_hashAbi.From(inspection_report_hash);
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvedAbi.From(approved);

            return await base.MakeTransactionList(new List<object> { abiHandle, batch_idAbi, inspection_report_hashAbi, approvedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="batch_id"> </param>
        public async Task DistributeBatch(string batch_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 13, 104, 144 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); batch_idAbi.From(batch_id);

            var result = await base.CallApp(new List<object> { abiHandle, batch_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DistributeBatch_Transactions(string batch_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 13, 104, 144 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); batch_idAbi.From(batch_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, batch_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="batch_id"> </param>
        /// <param name="reason_hash"> </param>
        public async Task RecallBatch(string batch_id, string reason_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 170, 236, 179 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); batch_idAbi.From(batch_id);
            var reason_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reason_hashAbi.From(reason_hash);

            var result = await base.CallApp(new List<object> { abiHandle, batch_idAbi, reason_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecallBatch_Transactions(string batch_id, string reason_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 170, 236, 179 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); batch_idAbi.From(batch_id);
            var reason_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reason_hashAbi.From(reason_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, batch_idAbi, reason_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="batch_id"> </param>
        public async Task<Structs.GetBatchReturn> GetBatch(string batch_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 33, 86, 163 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); batch_idAbi.From(batch_id);

            var result = await base.SimApp(new List<object> { abiHandle, batch_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetBatchReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBatch_Transactions(string batch_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 33, 86, 163 };
            var batch_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); batch_idAbi.From(batch_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, batch_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRm9vZFNhZmV0eUFwcCIsImRlc2MiOiJGb29kIFNhZmV0eSAmIFRyYWNlYWJpbGl0eSBhcHBsaWNhdGlvbi5cblxuICAgIFVzZXMgb25lIGJveCBwZXIgYGJhdGNoX2lkYCB0byBzdG9yZSBhIEJhdGNoUmVjb3JkIHN0cnVjdC5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQmF0Y2hSZWNvcmQiOlt7Im5hbWUiOiJwcm9kdWNlciIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJwcm9kdWN0X25hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoib3JpZ2luX2xvY2F0aW9uIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImhhcnZlc3RfZGF0ZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaXBmc19oYXNoIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6Imluc3BlY3Rpb25fcmVwb3J0X2hhc2giLCJ0eXBlIjoic3RyaW5nIn1dLCJHZXRCYXRjaFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDciLCJ0eXBlIjoic3RyaW5nIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9iYXRjaCIsImRlc2MiOiJDcmVhdGUgYSBuZXcgYmF0Y2guIHByb2R1Y2VyX2FkZHJlc3Mgc2hvdWxkIGJlIHRoZSBhY2NvdW50IGFkZHJlc3Mgc3RyaW5nICg1OC1jaGFyIGJhc2UzMikuIEluaXRpYWwgc3RhdHVzID0gMCAoQ1JFQVRFRCkuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJhdGNoX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9kdWNlcl9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm9kdWN0X25hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yaWdpbl9sb2NhdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaGFydmVzdF9kYXRlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpcGZzX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5zcGVjdF9iYXRjaCIsImRlc2MiOiJJbnNwZWN0IGEgYmF0Y2guIE9ubHkgYWxsb3dlZCB3aGVuIHN0YXR1cyA9PSBDUkVBVEVEICgwKS4gYXBwcm92ZWQ6IG5vbi16ZXJvIC0+IEFQUFJPVkVELCB6ZXJvIC0+IFJFSkVDVEVEIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJhdGNoX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnNwZWN0aW9uX3JlcG9ydF9oYXNoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHByb3ZlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkaXN0cmlidXRlX2JhdGNoIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJhdGNoX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY2FsbF9iYXRjaCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYXRjaF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhc29uX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2JhdGNoIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJhdGNoX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsc3RyaW5nLHN0cmluZyxzdHJpbmcsdWludDY0LHVpbnQ2NCxzdHJpbmcsc3RyaW5nKSIsInN0cnVjdCI6IkdldEJhdGNoUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQxM10sImVycm9yTWVzc2FnZSI6IkJhdGNoIGFscmVhZHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTUzLDczNCw5MTAsMTA3Ml0sImVycm9yTWVzc2FnZSI6IkJhdGNoIGRvZXMgbm90IGV4aXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQ0XSwiZXJyb3JNZXNzYWdlIjoiQmF0Y2ggbm90IEFQUFJPVkVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTYxXSwiZXJyb3JNZXNzYWdlIjoiQmF0Y2ggbm90IGluIENSRUFURUQgc3RhdGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MTAsNzg0LDk1M10sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODksMjc3LDMwMSwzMTksMzQ3XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTAxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBjb250cmFjdCBjcmVhdG9yIGNhbiByZWNhbGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOThdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MiwyODAsMzA0LDMyMiwzNTBdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODk5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jcmVhdG9yIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Wm05dlpGOXpZV1psZEhrdVkyOXVkSEpoWTNRdVJtOXZaRk5oWm1WMGVVRndjQzVmWDJGc1oyOXdlVjlsYm5SeWVYQnZhVzUwWDNkcGRHaGZhVzVwZENncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ01pQTBDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmlZWFJqYUdWeklpQXdlREF3TVdFZ0ltTnlaV0YwYjNJaUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabTl2WkY5ellXWmxkSGt2WTI5dWRISmhZM1F1Y0hrNk1qUXRNalVLSUNBZ0lDOHZJQ01nY21WamIzSmtJR052Ym5SeVlXTjBJR055WldGMGIzSUtJQ0FnSUM4dklITmxiR1l1WTNKbFlYUnZjaUE5SUZSNGJpNXpaVzVrWlhJS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1OeVpXRjBiM0lpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm05dlpGOXpZV1psZEhrdlkyOXVkSEpoWTNRdWNIazZNVGNLSUNBZ0lDOHZJR05zWVhOeklFWnZiMlJUWVdabGRIbEJjSEFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhNQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRE0xTjJVNE9UWTJJREI0TVRCaU9UQTFabVVnTUhnek9EQmtOamc1TUNBd2VERXpZV0ZsWTJJeklEQjROakl5TVRVMllUTWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVmZZbUYwWTJnb2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkN4emRISnBibWNwZG05cFpDSXNJRzFsZEdodlpDQWlhVzV6Y0dWamRGOWlZWFJqYUNoemRISnBibWNzYzNSeWFXNW5MSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKa2FYTjBjbWxpZFhSbFgySmhkR05vS0hOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSnlaV05oYkd4ZlltRjBZMmdvYzNSeWFXNW5MSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZZbUYwWTJnb2MzUnlhVzVuS1NoemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2RXbHVkRFkwTEhWcGJuUTJOQ3h6ZEhKcGJtY3NjM1J5YVc1bktTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlkzSmxZWFJsWDJKaGRHTm9YM0p2ZFhSbFFEVWdiV0ZwYmw5cGJuTndaV04wWDJKaGRHTm9YM0p2ZFhSbFFEWWdiV0ZwYmw5a2FYTjBjbWxpZFhSbFgySmhkR05vWDNKdmRYUmxRRGNnYldGcGJsOXlaV05oYkd4ZlltRjBZMmhmY205MWRHVkFPQ0J0WVdsdVgyZGxkRjlpWVhSamFGOXliM1YwWlVBNUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabTl2WkY5ellXWmxkSGt2WTI5dWRISmhZM1F1Y0hrNk1UY0tJQ0FnSUM4dklHTnNZWE56SUVadmIyUlRZV1psZEhsQmNIQW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgySmhkR05vWDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabTl2WkY5ellXWmxkSGt2WTI5dWRISmhZM1F1Y0hrNk1UQXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYjI5a1gzTmhabVYwZVM5amIyNTBjbUZqZEM1d2VUb3hOd29nSUNBZ0x5OGdZMnhoYzNNZ1JtOXZaRk5oWm1WMGVVRndjQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYjI5a1gzTmhabVYwZVM5amIyNTBjbUZqZEM1d2VUb3hNREFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgySmhkR05vQ2lBZ0lDQmthV2NnTndvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTNDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURjS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOd29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ053b2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUEzQ2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEY0tJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F5T0NBdkx5QXlPQW9nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeFl3b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dPQW9nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ053b2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTmdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl5WldOaGJHeGZZbUYwWTJoZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYjI5a1gzTmhabVYwZVM5amIyNTBjbUZqZEM1d2VUbzRNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iMjlrWDNOaFptVjBlUzlqYjI1MGNtRmpkQzV3ZVRveE53b2dJQ0FnTHk4Z1kyeGhjM01nUm05dlpGTmhabVYwZVVGd2NDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptOXZaRjl6WVdabGRIa3ZZMjl1ZEhKaFkzUXVjSGs2T0RNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJ5WldOaGJHeGZZbUYwWTJnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWkdsemRISnBZblYwWlY5aVlYUmphRjl5YjNWMFpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnZiMlJmYzJGbVpYUjVMMk52Ym5SeVlXTjBMbkI1T2pZMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJadmIyUmZjMkZtWlhSNUwyTnZiblJ5WVdOMExuQjVPakUzQ2lBZ0lDQXZMeUJqYkdGemN5QkdiMjlrVTJGbVpYUjVRWEJ3S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJadmIyUmZjMkZtWlhSNUwyTnZiblJ5WVdOMExuQjVPalkyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdaR2x6ZEhKcFluVjBaVjlpWVhSamFBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5cGJuTndaV04wWDJKaGRHTm9YM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptOXZaRjl6WVdabGRIa3ZZMjl1ZEhKaFkzUXVjSGs2TkRVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm05dlpGOXpZV1psZEhrdlkyOXVkSEpoWTNRdWNIazZNVGNLSUNBZ0lDOHZJR05zWVhOeklFWnZiMlJUWVdabGRIbEJjSEFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp2YjJSZmMyRm1aWFI1TDJOdmJuUnlZV04wTG5CNU9qUTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2FXNXpjR1ZqZEY5aVlYUmphQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWZlltRjBZMmhmY205MWRHVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iMjlrWDNOaFptVjBlUzlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWIyOWtYM05oWm1WMGVTOWpiMjUwY21GamRDNXdlVG94TndvZ0lDQWdMeThnWTJ4aGMzTWdSbTl2WkZOaFptVjBlVUZ3Y0NoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptOXZaRjl6WVdabGRIa3ZZMjl1ZEhKaFkzUXVjSGs2TWprS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJqY21WaGRHVmZZbUYwWTJnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnZiMlJmYzJGbVpYUjVMMk52Ym5SeVlXTjBMbkI1T2pFM0NpQWdJQ0F2THlCamJHRnpjeUJHYjI5a1UyRm1aWFI1UVhCd0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVtYjI5a1gzTmhabVYwZVM1amIyNTBjbUZqZEM1R2IyOWtVMkZtWlhSNVFYQndMbU55WldGMFpWOWlZWFJqYUNoaVlYUmphRjlwWkRvZ1lubDBaWE1zSUhCeWIyUjFZMlZ5WDJGa1pISmxjM002SUdKNWRHVnpMQ0J3Y205a2RXTjBYMjVoYldVNklHSjVkR1Z6TENCdmNtbG5hVzVmYkc5allYUnBiMjQ2SUdKNWRHVnpMQ0JvWVhKMlpYTjBYMlJoZEdVNklIVnBiblEyTkN3Z2FYQm1jMTlvWVhOb09pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDJKaGRHTm9PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnZiMlJmYzJGbVpYUjVMMk52Ym5SeVlXTjBMbkI1T2pJNUxUTXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lDOHZJR1JsWmlCamNtVmhkR1ZmWW1GMFkyZ29jMlZzWml3Z1ltRjBZMmhmYVdRNklGTjBjbWx1Wnl3Z2NISnZaSFZqWlhKZllXUmtjbVZ6Y3pvZ1UzUnlhVzVuTENCd2NtOWtkV04wWDI1aGJXVTZJRk4wY21sdVp5d2diM0pwWjJsdVgyeHZZMkYwYVc5dU9pQlRkSEpwYm1jc0lHaGhjblpsYzNSZlpHRjBaVG9nVlVsdWREWTBMQ0JwY0daelgyaGhjMmc2SUZOMGNtbHVaeWtnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURZZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJadmIyUmZjMkZtWlhSNUwyTnZiblJ5WVdOMExuQjVPak15Q2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUhObGJHWXVZbUYwWTJobGN5NXRZWGxpWlNoaVlYUmphRjlwWkNsYk1WMHNJQ0pDWVhSamFDQmhiSEpsWVdSNUlHVjRhWE4wY3lJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KaGRHTm9aWE1pQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJDWVhSamFDQmhiSEpsWVdSNUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp2YjJSZmMyRm1aWFI1TDJOdmJuUnlZV04wTG5CNU9qTTFDaUFnSUNBdkx5QndjbTlrZFdObGNqMUJVa00wVTNSeWFXNW5LSEJ5YjJSMVkyVnlYMkZrWkhKbGMzTXBMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJadmIyUmZjMkZtWlhSNUwyTnZiblJ5WVdOMExuQjVPak0yQ2lBZ0lDQXZMeUJ3Y205a2RXTjBYMjVoYldVOVFWSkRORk4wY21sdVp5aHdjbTlrZFdOMFgyNWhiV1VwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnZiMlJmYzJGbVpYUjVMMk52Ym5SeVlXTjBMbkI1T2pNM0NpQWdJQ0F2THlCdmNtbG5hVzVmYkc5allYUnBiMjQ5UVZKRE5GTjBjbWx1WnlodmNtbG5hVzVmYkc5allYUnBiMjRwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnZiMlJmYzJGbVpYUjVMMk52Ym5SeVlXTjBMbkI1T2pNNENpQWdJQ0F2THlCb1lYSjJaWE4wWDJSaGRHVTlRVkpETkZWSmJuUTJOQ2hvWVhKMlpYTjBYMlJoZEdVcExBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm05dlpGOXpZV1psZEhrdlkyOXVkSEpoWTNRdWNIazZNemtLSUNBZ0lDOHZJSE4wWVhSMWN6MUJVa00wVlVsdWREWTBLRlZKYm5RMk5DZ3dLU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnZiMlJmYzJGbVpYUjVMMk52Ym5SeVlXTjBMbkI1T2pRd0NpQWdJQ0F2THlCcGNHWnpYMmhoYzJnOVFWSkRORk4wY21sdVp5aHBjR1p6WDJoaGMyZ3BMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJadmIyUmZjMkZtWlhSNUwyTnZiblJ5WVdOMExuQjVPak0wTFRReUNpQWdJQ0F2THlCeVpXTnZjbVFnUFNCQ1lYUmphRkpsWTI5eVpDZ0tJQ0FnSUM4dklDQWdJQ0J3Y205a2RXTmxjajFCVWtNMFUzUnlhVzVuS0hCeWIyUjFZMlZ5WDJGa1pISmxjM01wTEFvZ0lDQWdMeThnSUNBZ0lIQnliMlIxWTNSZmJtRnRaVDFCVWtNMFUzUnlhVzVuS0hCeWIyUjFZM1JmYm1GdFpTa3NDaUFnSUNBdkx5QWdJQ0FnYjNKcFoybHVYMnh2WTJGMGFXOXVQVUZTUXpSVGRISnBibWNvYjNKcFoybHVYMnh2WTJGMGFXOXVLU3dLSUNBZ0lDOHZJQ0FnSUNCb1lYSjJaWE4wWDJSaGRHVTlRVkpETkZWSmJuUTJOQ2hvWVhKMlpYTjBYMlJoZEdVcExBb2dJQ0FnTHk4Z0lDQWdJSE4wWVhSMWN6MUJVa00wVlVsdWREWTBLRlZKYm5RMk5DZ3dLU2tzQ2lBZ0lDQXZMeUFnSUNBZ2FYQm1jMTlvWVhOb1BVRlNRelJUZEhKcGJtY29hWEJtYzE5b1lYTm9LU3dLSUNBZ0lDOHZJQ0FnSUNCcGJuTndaV04wYVc5dVgzSmxjRzl5ZEY5b1lYTm9QVUZTUXpSVGRISnBibWNvVTNSeWFXNW5LQ0lpS1NrS0lDQWdJQzh2SUNrS0lDQWdJR1JwWnlBMUNpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNallnTHk4Z01qWUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURGaENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTJDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMUNpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iMjlrWDNOaFptVjBlUzlqYjI1MGNtRmpkQzV3ZVRvME1Rb2dJQ0FnTHk4Z2FXNXpjR1ZqZEdsdmJsOXlaWEJ2Y25SZmFHRnphRDFCVWtNMFUzUnlhVzVuS0ZOMGNtbHVaeWdpSWlrcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptOXZaRjl6WVdabGRIa3ZZMjl1ZEhKaFkzUXVjSGs2TXpRdE5ESUtJQ0FnSUM4dklISmxZMjl5WkNBOUlFSmhkR05vVW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUhCeWIyUjFZMlZ5UFVGU1F6UlRkSEpwYm1jb2NISnZaSFZqWlhKZllXUmtjbVZ6Y3lrc0NpQWdJQ0F2THlBZ0lDQWdjSEp2WkhWamRGOXVZVzFsUFVGU1F6UlRkSEpwYm1jb2NISnZaSFZqZEY5dVlXMWxLU3dLSUNBZ0lDOHZJQ0FnSUNCdmNtbG5hVzVmYkc5allYUnBiMjQ5UVZKRE5GTjBjbWx1WnlodmNtbG5hVzVmYkc5allYUnBiMjRwTEFvZ0lDQWdMeThnSUNBZ0lHaGhjblpsYzNSZlpHRjBaVDFCVWtNMFZVbHVkRFkwS0doaGNuWmxjM1JmWkdGMFpTa3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGRIVnpQVUZTUXpSVlNXNTBOalFvVlVsdWREWTBLREFwS1N3S0lDQWdJQzh2SUNBZ0lDQnBjR1p6WDJoaGMyZzlRVkpETkZOMGNtbHVaeWhwY0daelgyaGhjMmdwTEFvZ0lDQWdMeThnSUNBZ0lHbHVjM0JsWTNScGIyNWZjbVZ3YjNKMFgyaGhjMmc5UVZKRE5GTjBjbWx1WnloVGRISnBibWNvSWlJcEtRb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptOXZaRjl6WVdabGRIa3ZZMjl1ZEhKaFkzUXVjSGs2TkRNS0lDQWdJQzh2SUhObGJHWXVZbUYwWTJobGMxdGlZWFJqYUY5cFpGMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVabTl2WkY5ellXWmxkSGt1WTI5dWRISmhZM1F1Um05dlpGTmhabVYwZVVGd2NDNXBibk53WldOMFgySmhkR05vS0dKaGRHTm9YMmxrT2lCaWVYUmxjeXdnYVc1emNHVmpkR2x2Ymw5eVpYQnZjblJmYUdGemFEb2dZbmwwWlhNc0lHRndjSEp2ZG1Wa09pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNtbHVjM0JsWTNSZlltRjBZMmc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZabTl2WkY5ellXWmxkSGt2WTI5dWRISmhZM1F1Y0hrNk5EVXRORFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlHbHVjM0JsWTNSZlltRjBZMmdvYzJWc1ppd2dZbUYwWTJoZmFXUTZJRk4wY21sdVp5d2dhVzV6Y0dWamRHbHZibDl5WlhCdmNuUmZhR0Z6YURvZ1UzUnlhVzVuTENCaGNIQnliM1psWkRvZ1ZVbHVkRFkwS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptOXZaRjl6WVdabGRIa3ZZMjl1ZEhKaFkzUXVjSGs2TkRndE5Ea0tJQ0FnSUM4dklDTWdRV05qWlhOeklHMWhlV0psSUhKbGMzVnNkQ0JrYVhKbFkzUnNlU0IwYnlCaGRtOXBaQ0J0ZFhSaFlteGxJSEpsWm1WeVpXNWpaU0JoYzNOcFoyNXRaVzUwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aVlYUmphR1Z6TG0xaGVXSmxLR0poZEdOb1gybGtLVnN4WFN3Z0lrSmhkR05vSUdSdlpYTWdibTkwSUdWNGFYTjBJZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbUYwWTJobGN5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQnVJRElLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVKaGRHTm9JR1J2WlhNZ2JtOTBJR1Y0YVhOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm05dlpGOXpZV1psZEhrdlkyOXVkSEpoWTNRdWNIazZOVEFLSUNBZ0lDOHZJR04xY25KbGJuUWdQU0J6Wld4bUxtSmhkR05vWlhNdWJXRjVZbVVvWW1GMFkyaGZhV1FwV3pCZExtTnZjSGtvS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYjI5a1gzTmhabVYwZVM5amIyNTBjbUZqZEM1d2VUbzFNZ29nSUNBZ0x5OGdZWE56WlhKMElHTjFjbkpsYm5RdWMzUmhkSFZ6TG01aGRHbDJaU0E5UFNCVlNXNTBOalFvTUNrc0lDSkNZWFJqYUNCdWIzUWdhVzRnUTFKRlFWUkZSQ0J6ZEdGMFpTSUtJQ0FnSUhCMWMyaHBiblFnTVRRZ0x5OGdNVFFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FtRjBZMmdnYm05MElHbHVJRU5TUlVGVVJVUWdjM1JoZEdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYjI5a1gzTmhabVYwZVM5amIyNTBjbUZqZEM1d2VUbzFOQW9nSUNBZ0x5OGdibVYzWDNOMFlYUjFjeUE5SUVGU1F6UlZTVzUwTmpRb1ZVbHVkRFkwS0RJcEtTQnBaaUJoY0hCeWIzWmxaQ0FoUFNCVlNXNTBOalFvTUNrZ1pXeHpaU0JCVWtNMFZVbHVkRFkwS0ZWSmJuUTJOQ2d6S1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbm9nYVc1emNHVmpkRjlpWVhSamFGOTBaWEp1WVhKNVgyWmhiSE5sUURJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQnBkRzlpQ2dwcGJuTndaV04wWDJKaGRHTm9YM1JsY201aGNubGZiV1Z5WjJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWIyOWtYM05oWm1WMGVTOWpiMjUwY21GamRDNXdlVG8xTmdvZ0lDQWdMeThnY0hKdlpIVmpaWEk5WTNWeWNtVnVkQzV3Y205a2RXTmxjaXdLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iMjlrWDNOaFptVjBlUzlqYjI1MGNtRmpkQzV3ZVRvMU53b2dJQ0FnTHk4Z2NISnZaSFZqZEY5dVlXMWxQV04xY25KbGJuUXVjSEp2WkhWamRGOXVZVzFsTEFvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk15QXZMeUEwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1pHbG5JRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWIyOWtYM05oWm1WMGVTOWpiMjUwY21GamRDNXdlVG8xT0FvZ0lDQWdMeThnYjNKcFoybHVYMnh2WTJGMGFXOXVQV04xY25KbGJuUXViM0pwWjJsdVgyeHZZMkYwYVc5dUxBb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTWpJZ0x5OGdNaklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTkFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJadmIyUmZjMkZtWlhSNUwyTnZiblJ5WVdOMExuQjVPalU1Q2lBZ0lDQXZMeUJvWVhKMlpYTjBYMlJoZEdVOVkzVnljbVZ1ZEM1b1lYSjJaWE4wWDJSaGRHVXNDaUFnSUNCa2FXY2dOQW9nSUNBZ1pYaDBjbUZqZENBMklEZ2dMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm05dlpGOXpZV1psZEhrdlkyOXVkSEpoWTNRdWNIazZOakVLSUNBZ0lDOHZJR2x3Wm5OZmFHRnphRDFqZFhKeVpXNTBMbWx3Wm5OZmFHRnphQ3dLSUNBZ0lHUnBaeUExQ2lBZ0lDQndkWE5vYVc1MElESTBJQzh2SURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnZiMlJmYzJGbVpYUjVMMk52Ym5SeVlXTjBMbkI1T2pZeUNpQWdJQ0F2THlCcGJuTndaV04wYVc5dVgzSmxjRzl5ZEY5b1lYTm9QVUZTUXpSVGRISnBibWNvYVc1emNHVmpkR2x2Ymw5eVpYQnZjblJmYUdGemFDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYjI5a1gzTmhabVYwZVM5amIyNTBjbUZqZEM1d2VUbzFOUzAyTXdvZ0lDQWdMeThnZFhCa1lYUmxaQ0E5SUVKaGRHTm9VbVZqYjNKa0tBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjJSMVkyVnlQV04xY25KbGJuUXVjSEp2WkhWalpYSXNDaUFnSUNBdkx5QWdJQ0FnY0hKdlpIVmpkRjl1WVcxbFBXTjFjbkpsYm5RdWNISnZaSFZqZEY5dVlXMWxMQW9nSUNBZ0x5OGdJQ0FnSUc5eWFXZHBibDlzYjJOaGRHbHZiajFqZFhKeVpXNTBMbTl5YVdkcGJsOXNiMk5oZEdsdmJpd0tJQ0FnSUM4dklDQWdJQ0JvWVhKMlpYTjBYMlJoZEdVOVkzVnljbVZ1ZEM1b1lYSjJaWE4wWDJSaGRHVXNDaUFnSUNBdkx5QWdJQ0FnYzNSaGRIVnpQVzVsZDE5emRHRjBkWE1zQ2lBZ0lDQXZMeUFnSUNBZ2FYQm1jMTlvWVhOb1BXTjFjbkpsYm5RdWFYQm1jMTlvWVhOb0xBb2dJQ0FnTHk4Z0lDQWdJR2x1YzNCbFkzUnBiMjVmY21Wd2IzSjBYMmhoYzJnOVFWSkRORk4wY21sdVp5aHBibk53WldOMGFXOXVYM0psY0c5eWRGOW9ZWE5vS1FvZ0lDQWdMeThnS1FvZ0lDQWdaR2xuSURVS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXlOaUF2THlBeU5nb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TVdFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEWUtJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURVS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWIyOWtYM05oWm1WMGVTOWpiMjUwY21GamRDNXdlVG8yTkFvZ0lDQWdMeThnYzJWc1ppNWlZWFJqYUdWelcySmhkR05vWDJsa1hTQTlJSFZ3WkdGMFpXUXVZMjl3ZVNncENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LYVc1emNHVmpkRjlpWVhSamFGOTBaWEp1WVhKNVgyWmhiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm05dlpGOXpZV1psZEhrdlkyOXVkSEpoWTNRdWNIazZOVFFLSUNBZ0lDOHZJRzVsZDE5emRHRjBkWE1nUFNCQlVrTTBWVWx1ZERZMEtGVkpiblEyTkNneUtTa2dhV1lnWVhCd2NtOTJaV1FnSVQwZ1ZVbHVkRFkwS0RBcElHVnNjMlVnUVZKRE5GVkpiblEyTkNoVlNXNTBOalFvTXlrcENpQWdJQ0J3ZFhOb2FXNTBJRE1nTHk4Z013b2dJQ0FnYVhSdllnb2dJQ0FnWWlCcGJuTndaV04wWDJKaGRHTm9YM1JsY201aGNubGZiV1Z5WjJWQU13b0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVtYjI5a1gzTmhabVYwZVM1amIyNTBjbUZqZEM1R2IyOWtVMkZtWlhSNVFYQndMbVJwYzNSeWFXSjFkR1ZmWW1GMFkyZ29ZbUYwWTJoZmFXUTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGthWE4wY21saWRYUmxYMkpoZEdOb09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJadmIyUmZjMkZtWlhSNUwyTnZiblJ5WVdOMExuQjVPalkyTFRZM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUM4dklHUmxaaUJrYVhOMGNtbGlkWFJsWDJKaGRHTm9LSE5sYkdZc0lHSmhkR05vWDJsa09pQlRkSEpwYm1jcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iMjlrWDNOaFptVjBlUzlqYjI1MGNtRmpkQzV3ZVRvMk9DMDJPUW9nSUNBZ0x5OGdJeUJCWTJObGMzTWdiV0Y1WW1VZ2NtVnpkV3gwSUdScGNtVmpkR3g1SUhSdklHRjJiMmxrSUcxMWRHRmliR1VnY21WbVpYSmxibU5sSUdGemMybG5ibTFsYm5RS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtSmhkR05vWlhNdWJXRjVZbVVvWW1GMFkyaGZhV1FwV3pGZExDQWlRbUYwWTJnZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppWVhSamFHVnpJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnUW1GMFkyZ2daRzlsY3lCdWIzUWdaWGhwYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYjI5a1gzTmhabVYwZVM5amIyNTBjbUZqZEM1d2VUbzNNQW9nSUNBZ0x5OGdZM1Z5Y21WdWRDQTlJSE5sYkdZdVltRjBZMmhsY3k1dFlYbGlaU2hpWVhSamFGOXBaQ2xiTUYwdVkyOXdlU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp2YjJSZmMyRm1aWFI1TDJOdmJuUnlZV04wTG5CNU9qY3hDaUFnSUNBdkx5QmhjM05sY25RZ1kzVnljbVZ1ZEM1emRHRjBkWE11Ym1GMGFYWmxJRDA5SUZWSmJuUTJOQ2d5S1N3Z0lrSmhkR05vSUc1dmRDQkJVRkJTVDFaRlJDSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TkNBdkx5QXhOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVKaGRHTm9JRzV2ZENCQlVGQlNUMVpGUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp2YjJSZmMyRm1aWFI1TDJOdmJuUnlZV04wTG5CNU9qY3pDaUFnSUNBdkx5QndjbTlrZFdObGNqMWpkWEp5Wlc1MExuQnliMlIxWTJWeUxBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptOXZaRjl6WVdabGRIa3ZZMjl1ZEhKaFkzUXVjSGs2TnpRS0lDQWdJQzh2SUhCeWIyUjFZM1JmYm1GdFpUMWpkWEp5Wlc1MExuQnliMlIxWTNSZmJtRnRaU3dLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdScFp5QXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm05dlpGOXpZV1psZEhrdlkyOXVkSEpoWTNRdWNIazZOelVLSUNBZ0lDOHZJRzl5YVdkcGJsOXNiMk5oZEdsdmJqMWpkWEp5Wlc1MExtOXlhV2RwYmw5c2IyTmhkR2x2Yml3S0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJREl5SUM4dklESXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYjI5a1gzTmhabVYwZVM5amIyNTBjbUZqZEM1d2VUbzNOZ29nSUNBZ0x5OGdhR0Z5ZG1WemRGOWtZWFJsUFdOMWNuSmxiblF1YUdGeWRtVnpkRjlrWVhSbExBb2dJQ0FnWkdsbklEUUtJQ0FnSUdWNGRISmhZM1FnTmlBNElDOHZJRzl1SUdWeWNtOXlPaUJKYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp2YjJSZmMyRm1aWFI1TDJOdmJuUnlZV04wTG5CNU9qYzNDaUFnSUNBdkx5QnpkR0YwZFhNOVFWSkRORlZKYm5RMk5DaFZTVzUwTmpRb05Da3BMQW9nSUNBZ2FXNTBZMTh6SUM4dklEUUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWIyOWtYM05oWm1WMGVTOWpiMjUwY21GamRDNXdlVG8zT0FvZ0lDQWdMeThnYVhCbWMxOW9ZWE5vUFdOMWNuSmxiblF1YVhCbWMxOW9ZWE5vTEFvZ0lDQWdaR2xuSURZS0lDQWdJSEIxYzJocGJuUWdNalFnTHk4Z01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dOd29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp2YjJSZmMyRm1aWFI1TDJOdmJuUnlZV04wTG5CNU9qYzVDaUFnSUNBdkx5QnBibk53WldOMGFXOXVYM0psY0c5eWRGOW9ZWE5vUFdOMWNuSmxiblF1YVc1emNHVmpkR2x2Ymw5eVpYQnZjblJmYUdGemFBb2dJQ0FnWkdsbklEY0tJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnZiMlJmYzJGbVpYUjVMMk52Ym5SeVlXTjBMbkI1T2pjeUxUZ3dDaUFnSUNBdkx5QjFjR1JoZEdWa0lEMGdRbUYwWTJoU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ2NISnZaSFZqWlhJOVkzVnljbVZ1ZEM1d2NtOWtkV05sY2l3S0lDQWdJQzh2SUNBZ0lDQndjbTlrZFdOMFgyNWhiV1U5WTNWeWNtVnVkQzV3Y205a2RXTjBYMjVoYldVc0NpQWdJQ0F2THlBZ0lDQWdiM0pwWjJsdVgyeHZZMkYwYVc5dVBXTjFjbkpsYm5RdWIzSnBaMmx1WDJ4dlkyRjBhVzl1TEFvZ0lDQWdMeThnSUNBZ0lHaGhjblpsYzNSZlpHRjBaVDFqZFhKeVpXNTBMbWhoY25abGMzUmZaR0YwWlN3S0lDQWdJQzh2SUNBZ0lDQnpkR0YwZFhNOVFWSkRORlZKYm5RMk5DaFZTVzUwTmpRb05Da3BMQW9nSUNBZ0x5OGdJQ0FnSUdsd1puTmZhR0Z6YUQxamRYSnlaVzUwTG1sd1puTmZhR0Z6YUN3S0lDQWdJQzh2SUNBZ0lDQnBibk53WldOMGFXOXVYM0psY0c5eWRGOW9ZWE5vUFdOMWNuSmxiblF1YVc1emNHVmpkR2x2Ymw5eVpYQnZjblJmYUdGemFBb2dJQ0FnTHk4Z0tRb2dJQ0FnWkdsbklEWUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F5TmlBdkx5QXlOZ29nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01XRUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRGNLSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEWUtJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iMjlrWDNOaFptVjBlUzlqYjI1MGNtRmpkQzV3ZVRvNE1Rb2dJQ0FnTHk4Z2MyVnNaaTVpWVhSamFHVnpXMkpoZEdOb1gybGtYU0E5SUhWd1pHRjBaV1F1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Wm05dlpGOXpZV1psZEhrdVkyOXVkSEpoWTNRdVJtOXZaRk5oWm1WMGVVRndjQzV5WldOaGJHeGZZbUYwWTJnb1ltRjBZMmhmYVdRNklHSjVkR1Z6TENCeVpXRnpiMjVmYUdGemFEb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuSmxZMkZzYkY5aVlYUmphRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iMjlrWDNOaFptVjBlUzlqYjI1MGNtRmpkQzV3ZVRvNE15MDROQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ2NtVmpZV3hzWDJKaGRHTm9LSE5sYkdZc0lHSmhkR05vWDJsa09pQlRkSEpwYm1jc0lISmxZWE52Ymw5b1lYTm9PaUJUZEhKcGJtY3BJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYjI5a1gzTmhabVYwZVM5amIyNTBjbUZqZEM1d2VUbzROUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWpjbVZoZEc5eUxDQWlUMjVzZVNCamIyNTBjbUZqZENCamNtVmhkRzl5SUdOaGJpQnlaV05oYkd3aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZM0psWVhSdmNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqY21WaGRHOXlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHTnZiblJ5WVdOMElHTnlaV0YwYjNJZ1kyRnVJSEpsWTJGc2JBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJadmIyUmZjMkZtWlhSNUwyTnZiblJ5WVdOMExuQjVPamcyTFRnM0NpQWdJQ0F2THlBaklFRmpZMlZ6Y3lCdFlYbGlaU0J5WlhOMWJIUWdaR2x5WldOMGJIa2dkRzhnWVhadmFXUWdiWFYwWVdKc1pTQnlaV1psY21WdVkyVWdZWE56YVdkdWJXVnVkQW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WW1GMFkyaGxjeTV0WVhsaVpTaGlZWFJqYUY5cFpDbGJNVjBzSUNKQ1lYUmphQ0JrYjJWeklHNXZkQ0JsZUdsemRDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSmhkR05vWlhNaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNZWFJqYUNCa2IyVnpJRzV2ZENCbGVHbHpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnZiMlJmYzJGbVpYUjVMMk52Ym5SeVlXTjBMbkI1T2pnNENpQWdJQ0F2THlCamRYSnlaVzUwSUQwZ2MyVnNaaTVpWVhSamFHVnpMbTFoZVdKbEtHSmhkR05vWDJsa0tWc3dYUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptOXZaRjl6WVdabGRIa3ZZMjl1ZEhKaFkzUXVjSGs2T1RBS0lDQWdJQzh2SUhCeWIyUjFZMlZ5UFdOMWNuSmxiblF1Y0hKdlpIVmpaWElzQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTltYjI5a1gzTmhabVYwZVM5amIyNTBjbUZqZEM1d2VUbzVNUW9nSUNBZ0x5OGdjSEp2WkhWamRGOXVZVzFsUFdOMWNuSmxiblF1Y0hKdlpIVmpkRjl1WVcxbExBb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNeUF2THlBMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iMjlrWDNOaFptVjBlUzlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z2IzSnBaMmx1WDJ4dlkyRjBhVzl1UFdOMWNuSmxiblF1YjNKcFoybHVYMnh2WTJGMGFXOXVMQW9nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ01qSWdMeThnTWpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ05Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyWnZiMlJmYzJGbVpYUjVMMk52Ym5SeVlXTjBMbkI1T2prekNpQWdJQ0F2THlCb1lYSjJaWE4wWDJSaGRHVTlZM1Z5Y21WdWRDNW9ZWEoyWlhOMFgyUmhkR1VzQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaWGgwY21GamRDQTJJRGdnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlptOXZaRjl6WVdabGRIa3ZZMjl1ZEhKaFkzUXVjSGs2T1RRS0lDQWdJQzh2SUhOMFlYUjFjejFCVWtNMFZVbHVkRFkwS0ZWSmJuUTJOQ2cxS1Nrc0NpQWdJQ0J3ZFhOb2FXNTBJRFVnTHk4Z05Rb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJadmIyUmZjMkZtWlhSNUwyTnZiblJ5WVdOMExuQjVPamsxQ2lBZ0lDQXZMeUJwY0daelgyaGhjMmc5WTNWeWNtVnVkQzVwY0daelgyaGhjMmdzQ2lBZ0lDQmthV2NnTmdvZ0lDQWdjSFZ6YUdsdWRDQXlOQ0F2THlBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iMjlrWDNOaFptVjBlUzlqYjI1MGNtRmpkQzV3ZVRvNU5nb2dJQ0FnTHk4Z2FXNXpjR1ZqZEdsdmJsOXlaWEJ2Y25SZmFHRnphRDFCVWtNMFUzUnlhVzVuS0hKbFlYTnZibDlvWVhOb0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlp2YjJSZmMyRm1aWFI1TDJOdmJuUnlZV04wTG5CNU9qZzVMVGszQ2lBZ0lDQXZMeUIxY0dSaGRHVmtJRDBnUW1GMFkyaFNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdjSEp2WkhWalpYSTlZM1Z5Y21WdWRDNXdjbTlrZFdObGNpd0tJQ0FnSUM4dklDQWdJQ0J3Y205a2RXTjBYMjVoYldVOVkzVnljbVZ1ZEM1d2NtOWtkV04wWDI1aGJXVXNDaUFnSUNBdkx5QWdJQ0FnYjNKcFoybHVYMnh2WTJGMGFXOXVQV04xY25KbGJuUXViM0pwWjJsdVgyeHZZMkYwYVc5dUxBb2dJQ0FnTHk4Z0lDQWdJR2hoY25abGMzUmZaR0YwWlQxamRYSnlaVzUwTG1oaGNuWmxjM1JmWkdGMFpTd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlRVkpETkZWSmJuUTJOQ2hWU1c1ME5qUW9OU2twTEFvZ0lDQWdMeThnSUNBZ0lHbHdabk5mYUdGemFEMWpkWEp5Wlc1MExtbHdabk5mYUdGemFDd0tJQ0FnSUM4dklDQWdJQ0JwYm5Od1pXTjBhVzl1WDNKbGNHOXlkRjlvWVhOb1BVRlNRelJUZEhKcGJtY29jbVZoYzI5dVgyaGhjMmdwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmthV2NnTmdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElESTJJQzh2SURJMkNpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF4WVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ053b2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTmdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJadmIyUmZjMkZtWlhSNUwyTnZiblJ5WVdOMExuQjVPams0Q2lBZ0lDQXZMeUJ6Wld4bUxtSmhkR05vWlhOYlltRjBZMmhmYVdSZElEMGdkWEJrWVhSbFpDNWpiM0I1S0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NW1iMjlrWDNOaFptVjBlUzVqYjI1MGNtRmpkQzVHYjI5a1UyRm1aWFI1UVhCd0xtZGxkRjlpWVhSamFDaGlZWFJqYUY5cFpEb2dZbmwwWlhNcElDMCtJR0o1ZEdWekxDQmllWFJsY3l3Z1lubDBaWE1zSUdKNWRHVnpMQ0IxYVc1ME5qUXNJSFZwYm5RMk5Dd2dZbmwwWlhNc0lHSjVkR1Z6T2dwblpYUmZZbUYwWTJnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Wm05dlpGOXpZV1psZEhrdlkyOXVkSEpoWTNRdWNIazZNVEF3TFRFd01Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjlpWVhSamFDaHpaV3htTENCaVlYUmphRjlwWkRvZ1UzUnlhVzVuS1NBdFBpQlVkWEJzWlZ0VGRISnBibWNzSUZOMGNtbHVaeXdnVTNSeWFXNW5MQ0JUZEhKcGJtY3NJRlZKYm5RMk5Dd2dWVWx1ZERZMExDQlRkSEpwYm1jc0lGTjBjbWx1WjEwNkNpQWdJQ0J3Y205MGJ5QXhJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OW1iMjlrWDNOaFptVjBlUzlqYjI1MGNtRmpkQzV3ZVRveE1ESXRNVEF6Q2lBZ0lDQXZMeUFqSUVGalkyVnpjeUJ0WVhsaVpTQnlaWE4xYkhRZ1pHbHlaV04wYkhrZ2RHOGdZWFp2YVdRZ2JYVjBZV0pzWlNCeVpXWmxjbVZ1WTJVZ1lYTnphV2R1YldWdWRBb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZbUYwWTJobGN5NXRZWGxpWlNoaVlYUmphRjlwWkNsYk1WMHNJQ0pDWVhSamFDQmtiMlZ6SUc1dmRDQmxlR2x6ZENJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KaGRHTm9aWE1pQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCQ1lYUmphQ0JrYjJWeklHNXZkQ0JsZUdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJadmIyUmZjMkZtWlhSNUwyTnZiblJ5WVdOMExuQjVPakV3TkFvZ0lDQWdMeThnWTNWeWNtVnVkQ0E5SUhObGJHWXVZbUYwWTJobGN5NXRZWGxpWlNoaVlYUmphRjlwWkNsYk1GMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bWIyOWtYM05oWm1WMGVTOWpiMjUwY21GamRDNXdlVG94TURVdE1UQTJDaUFnSUNBdkx5QWpJSEpsZEhWeWJpQW9ZbUYwWTJoZmFXUXNJSEJ5YjJSMVkyVnlYMkZrWkhKbGMzTmZjM1J5YVc1bkxDQndjbTlrZFdOMFgyNWhiV1VzSUc5eWFXZHBibDlzYjJOaGRHbHZiaXdnYUdGeWRtVnpkRjlrWVhSbExDQnpkR0YwZFhNc0lHbHdabk5mYUdGemFDd2dhVzV6Y0dWamRHbHZibDl5WlhCdmNuUmZhR0Z6YUNrS0lDQWdJQzh2SUhKbGRIVnliaUFvWW1GMFkyaGZhV1FzSUdOMWNuSmxiblF1Y0hKdlpIVmpaWEl1Ym1GMGFYWmxMQ0JqZFhKeVpXNTBMbkJ5YjJSMVkzUmZibUZ0WlM1dVlYUnBkbVVzSUdOMWNuSmxiblF1YjNKcFoybHVYMnh2WTJGMGFXOXVMbTVoZEdsMlpTd2dZM1Z5Y21WdWRDNW9ZWEoyWlhOMFgyUmhkR1V1Ym1GMGFYWmxMQ0JqZFhKeVpXNTBMbk4wWVhSMWN5NXVZWFJwZG1Vc0lHTjFjbkpsYm5RdWFYQm1jMTlvWVhOb0xtNWhkR2wyWlN3Z1kzVnljbVZ1ZEM1cGJuTndaV04wYVc5dVgzSmxjRzl5ZEY5b1lYTm9MbTVoZEdsMlpTa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYek1nTHk4Z05Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ01qSWdMeThnTWpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ05Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QTBDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUExQ2lBZ0lDQndkWE5vYVc1MElERTBJQzh2SURFMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklEWUtJQ0FnSUhCMWMyaHBiblFnTWpRZ0x5OGdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTndvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1JwWnlBM0NpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052ZG1WeUlEY0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBQUVDQkNZREIySmhkR05vWlhNQ0FCb0hZM0psWVhSdmNqRVlRQUFFS2pFQVp6RWJRUUZjZ2dVRU5YNkpaZ1FRdVFYK0JEZ05hSkFFRTZyc3N3UmlJVmFqTmhvQWpnVUJCQURvQU5ZQXZnQUNJa014R1JSRU1SaEVOaG9CVndJQWlBTy9Td2NWRmxjR0FrOElVRXNIRlJaWEJnSlBDRkJMQnhVV1Z3WUNUd2hRU3djVkZsY0dBazhJVUU4SEZrOEhGa3NIRlJaWEJnSlBDRkJMQnhVV1Z3WUNUd2hRU3djVmdSd0lTUlpYQmdLQUFnQWNURkJMQ0JWUEFnaEpGbGNHQWs4Q1RGQkxCeFZQQWdoSkZsY0dBazhDVEZCTEJoVlBBZ2hNVHdWUVR3UlFTd0VXVndZQ1VFc0RGVThDQ0JaWEJnSlFUd1pRVHdWUVR3UlFUd05RVHdKUVRGQ0FCQlVmZkhWTVVMQWpRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSlhBZ0NJQWxNalF6RVpGRVF4R0VRMkdnRlhBZ0NJQVpralF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dKWEFnQTJHZ01YaUFESEkwTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ1Z3SUFOaG9EVndJQU5ob0VWd0lBTmhvRkZ6WWFCbGNDQUlnQURTTkRNUmxBL3NreEdCUkVJME9LQmdBb2kvcFFTYjVGQVJSRWkvc1ZGbGNHQW92N1VJdjhGUlpYQmdLTC9GQ0wvUlVXVndZQ2kvMVFpLzRXSWhhTC94VVdWd1lDaS85UVN3VVZnUm9JU1JaWEJnSXBURkJMQmhWUEFnaEpGbGNHQWs4Q1RGQkxCUlZQQWdoTVR3UlFUd05RU3dFV1Z3WUNVRXNDRlU4Q0NCWlhCZ0pRVHdSUVR3TlFUd0pRVEZDQUFnQUFVRXNCdkVpL2lZb0RBQ2lML1ZCSEFyNUZBVVMrU0VtQkRsc1VSSXYvUVFDV0pCYUxBVWtpV1VzQkpGbExBazhDU3dKU1N3SWxXVXNEVHdOTEFsSkxBNEVXV1VzRVR3TkxBbEpMQkZjR0NFc0ZnUmhaVHdaUEJFOENVb3YrRlJaWEJnS0wvbEJMQlJXQkdnaEpGbGNHQWlsTVVFc0dGVThDQ0VrV1Z3WUNUd0pNVUVzRkZVOENDRXhQQkZCUEIxQkxBUlpYQmdKUVN3TVZUd0lJRmxjR0FsQlBCVkJQQkZCUEExQlBBbEJNVUlzQVNieElUTCtKZ1FNV1F2OW1pZ0VBS0l2L1VFbStSUUZFU2I1SVNZRU9XeVFTUkVraVdVc0JKRmxMQWs4Q1N3SlNTd0lsV1VzRFR3TkxBbEpMQTRFV1dVc0VUd05MQWxKTEJGY0dDQ1VXU3dhQkdGbExCMDhGU3dKU1N3Y1ZUd2hQQTA4Q1Vrc0dGWUVhQ0VrV1Z3WUNLVXhRU3djVlR3SUlTUlpYQmdKUEFreFFTd1lWVHdJSVRFOEZVRThFVUVzQkZsY0dBbEJMQXhWUEFnZ1dWd1lDVUU4RlVFOEVVRThEVUU4Q1VFeFFTd0c4U0wrSmlnSUFNUUFpS21WRUVrUW9pLzVRU2I1RkFVUkp2a2hKSWxsTEFTUlpTd0pQQWtzQ1Vrc0NKVmxMQTA4RFN3SlNTd09CRmxsTEJFOERTd0pTU3dSWEJnaUJCUlpMQm9FWVdVOEhUd1ZQQWxLTC94VVdWd1lDaS85UVN3WVZnUm9JU1JaWEJnSXBURkJMQnhWUEFnaEpGbGNHQWs4Q1RGQkxCaFZQQWdoTVR3VlFUd1JRU3dFV1Z3WUNVRXNERlU4Q0NCWlhCZ0pRVHdWUVR3UlFUd05RVHdKUVRGQkxBYnhJdjRtS0FRZ29pLzlRU2I1RkFVUytTRWtpV1VzQkpGbExBazhDU3dKU1Z3SUFTd0lsV1VzRFR3TkxBbEpYQWdCTEE0RVdXVXNFVHdOTEFsSlhBZ0JMQklFR1cwc0ZnUTViU3dhQkdGbExCMDhGU3dKU1Z3SUFTd2NWVHdoUEEwOENVbGNDQUl2L1RnZUoiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
