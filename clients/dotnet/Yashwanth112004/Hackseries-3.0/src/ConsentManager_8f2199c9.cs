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

namespace Arc56.Generated.Yashwanth112004.Hackseries_3_0.ConsentManager_8f2199c9
{


    public class ConsentManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ConsentManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetPatientConsentsReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public string Field2 { get; set; }

                public string Field3 { get; set; }

                public string Field4 { get; set; }

                public ulong Field5 { get; set; }

                public ulong Field6 { get; set; }

                public bool Field7 { get; set; }

                public bool Field8 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
                    ret.AddRange(new byte[2]);
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static GetPatientConsentsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetPatientConsentsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField7 = vField7.ToValue();
                    if (valueField7 is bool vField7Value) { ret.Field7 = vField7Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField8.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField8 = vField8.ToValue();
                    if (valueField8 is bool vField8Value) { ret.Field8 = vField8Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetPatientConsentsReturn);
                }
                public bool Equals(GetPatientConsentsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetPatientConsentsReturn left, GetPatientConsentsReturn right)
                {
                    return EqualityComparer<GetPatientConsentsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetPatientConsentsReturn left, GetPatientConsentsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetPendingRequestsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public string Field2 { get; set; }

                public ulong Field3 { get; set; }

                public bool Field4 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static GetPendingRequestsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GetPendingRequestsReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is bool vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetPendingRequestsReturn);
                }
                public bool Equals(GetPendingRequestsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetPendingRequestsReturn left, GetPendingRequestsReturn right)
                {
                    return EqualityComparer<GetPendingRequestsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetPendingRequestsReturn left, GetPendingRequestsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="fiduciary"> </param>
        /// <param name="purpose"> </param>
        /// <param name="data_hash"> </param>
        /// <param name="data_scope"> </param>
        /// <param name="duration_in_seconds"> </param>
        public async Task GrantConsent(Algorand.Address fiduciary, string purpose, string data_hash, string data_scope, ulong duration_in_seconds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 215, 96, 84 };
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);
            var data_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); data_hashAbi.From(data_hash);
            var data_scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); data_scopeAbi.From(data_scope);
            var duration_in_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_in_secondsAbi.From(duration_in_seconds);

            var result = await base.CallApp(new List<object> { abiHandle, fiduciaryAbi, purposeAbi, data_hashAbi, data_scopeAbi, duration_in_secondsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantConsent_Transactions(Algorand.Address fiduciary, string purpose, string data_hash, string data_scope, ulong duration_in_seconds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 215, 96, 84 };
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);
            var data_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); data_hashAbi.From(data_hash);
            var data_scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); data_scopeAbi.From(data_scope);
            var duration_in_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_in_secondsAbi.From(duration_in_seconds);

            return await base.MakeTransactionList(new List<object> { abiHandle, fiduciaryAbi, purposeAbi, data_hashAbi, data_scopeAbi, duration_in_secondsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        public async Task RevokeConsent(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 253, 99, 111 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            var result = await base.CallApp(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeConsent_Transactions(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 253, 99, 111 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        public async Task RequestErasure(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 79, 170, 210 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            var result = await base.CallApp(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RequestErasure_Transactions(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 79, 170, 210 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="patient"> </param>
        public async Task<Structs.GetPatientConsentsReturn[]> GetPatientConsents(Algorand.Address patient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 125, 188, 15 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);

            var result = await base.SimApp(new List<object> { abiHandle, patientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.GetPatientConsentsReturn>(x => Structs.GetPatientConsentsReturn.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> GetPatientConsents_Transactions(Algorand.Address patient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 164, 125, 188, 15 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);

            return await base.MakeTransactionList(new List<object> { abiHandle, patientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="principal"> </param>
        /// <param name="index"> </param>
        /// <param name="required_scope"> </param>
        public async Task<bool> ValidateConsent(Algorand.Address principal, ulong index, string required_scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 40, 165, 172 };
            var principalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); principalAbi.From(principal);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var required_scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); required_scopeAbi.From(required_scope);

            var result = await base.SimApp(new List<object> { abiHandle, principalAbi, indexAbi, required_scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ValidateConsent_Transactions(Algorand.Address principal, ulong index, string required_scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 40, 165, 172 };
            var principalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); principalAbi.From(principal);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var required_scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); required_scopeAbi.From(required_scope);

            return await base.MakeTransactionList(new List<object> { abiHandle, principalAbi, indexAbi, required_scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        /// <param name="new_duration_in_seconds"> </param>
        public async Task UpdateConsentDuration(ulong index, ulong new_duration_in_seconds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 70, 39, 233 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var new_duration_in_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_duration_in_secondsAbi.From(new_duration_in_seconds);

            var result = await base.CallApp(new List<object> { abiHandle, indexAbi, new_duration_in_secondsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateConsentDuration_Transactions(ulong index, ulong new_duration_in_seconds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 70, 39, 233 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var new_duration_in_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_duration_in_secondsAbi.From(new_duration_in_seconds);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi, new_duration_in_secondsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="patient"> </param>
        /// <param name="purpose"> </param>
        public async Task RequestAccess(Algorand.Address patient, string purpose, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 77, 235, 208 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);

            var result = await base.CallApp(new List<object> { abiHandle, patientAbi, purposeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RequestAccess_Transactions(Algorand.Address patient, string purpose, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 77, 235, 208 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);

            return await base.MakeTransactionList(new List<object> { abiHandle, patientAbi, purposeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="patient"> </param>
        public async Task<Structs.GetPendingRequestsReturn[]> GetPendingRequests(Algorand.Address patient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 41, 170, 218 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);

            var result = await base.SimApp(new List<object> { abiHandle, patientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.GetPendingRequestsReturn>(x => Structs.GetPendingRequestsReturn.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> GetPendingRequests_Transactions(Algorand.Address patient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 41, 170, 218 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);

            return await base.MakeTransactionList(new List<object> { abiHandle, patientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        /// <param name="data_hash"> </param>
        /// <param name="data_scope"> </param>
        /// <param name="duration_in_seconds"> </param>
        public async Task ApproveRequest(ulong request_id, string data_hash, string data_scope, ulong duration_in_seconds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 164, 189, 155 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);
            var data_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); data_hashAbi.From(data_hash);
            var data_scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); data_scopeAbi.From(data_scope);
            var duration_in_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_in_secondsAbi.From(duration_in_seconds);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi, data_hashAbi, data_scopeAbi, duration_in_secondsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveRequest_Transactions(ulong request_id, string data_hash, string data_scope, ulong duration_in_seconds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 164, 189, 155 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);
            var data_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); data_hashAbi.From(data_hash);
            var data_scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); data_scopeAbi.From(data_scope);
            var duration_in_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_in_secondsAbi.From(duration_in_seconds);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi, data_hashAbi, data_scopeAbi, duration_in_secondsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task RejectRequest(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 137, 6, 41 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RejectRequest_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 137, 6, 41 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29uc2VudE1hbmFnZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0UGF0aWVudENvbnNlbnRzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkNSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDYiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ3IiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDgiLCJ0eXBlIjoiYm9vbCJ9XSwiR2V0UGVuZGluZ1JlcXVlc3RzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJncmFudF9jb25zZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWR1Y2lhcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1cnBvc2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGFfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YV9zY29wZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZHVyYXRpb25faW5fc2Vjb25kcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VfY29uc2VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXF1ZXN0X2VyYXN1cmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BhdGllbnRfY29uc2VudHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhdGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyxzdHJpbmcsc3RyaW5nLHN0cmluZyx1aW50NjQsdWludDY0LGJvb2wsYm9vbClbXSIsInN0cnVjdCI6IkdldFBhdGllbnRDb25zZW50c1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfY29uc2VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpbmNpcGFsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWlyZWRfc2NvcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfY29uc2VudF9kdXJhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2R1cmF0aW9uX2luX3NlY29uZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVxdWVzdF9hY2Nlc3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhdGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1cnBvc2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BlbmRpbmdfcmVxdWVzdHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhdGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLHN0cmluZyx1aW50NjQsYm9vbClbXSIsInN0cnVjdCI6IkdldFBlbmRpbmdSZXF1ZXN0c1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXBwcm92ZV9yZXF1ZXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGFfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YV9zY29wZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZHVyYXRpb25faW5fc2Vjb25kcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWplY3RfcmVxdWVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNzAwXSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSByZXZva2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI3OV0sImVycm9yTWVzc2FnZSI6IkNvbnNlbnQgbm90IGFjdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MzJdLCJlcnJvck1lc3NhZ2UiOiJQZW5kaW5nIHJlcXVlc3Qgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM3OCwxNDU2LDE2NTMsMTk3OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWNjZXNzX3JlcXVlc3RzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2Niw2MjIsNzM3LDk1NCwxMDA3LDEyMDEsMTkwNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY29uc2VudHMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMzMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucmVxdWVzdF9jb3VudGVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1MSw3MTEsNzY2LDkyOSwxMTE3LDEyMzAsMTI5NCwxNTAzLDE3NjAsMTc5MCwyMDI2LDIxMTNdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0MCw0NTYsNDcyLDYzNCw3NDksOTg4LDExMDAsMTIxMywxMzIwLDE0ODIsMTYwOSwxNjI1LDE3NDIsMjAwMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1MCw0NjYsNDc5LDk5NCwxMzI3LDE2MTgsMTYzMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzQsOTQ5LDk3MSwxMzE0LDE0MzNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDg3LDYxNSw3MzAsOTc5LDExODYsMTE5NCwxNjAyLDE2MzksMTk2N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJRElnTVNBNENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1EQWdNSGcyTXpWbUlEQjRPREFnSWlJZ01IZ3dNREF5SURCNE5qRTNNalZtSUNKeVpYRmZZMjkxYm5SbGNpSWdNSGd3TURBeE1EQXdNaUF3ZURBd01EWTBOVFV5TkRFMU16UTFORFFnTUhneE5URm1OMk0zTlNBd2VEQXdOVGNLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5UQUtJQ0FnSUM4dklITmxiR1l1Y21WeGRXVnpkRjlqYjNWdWRHVnlMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEySUM4dklDSnlaWEZmWTI5MWJuUmxjaUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pReUNpQWdJQ0F2THlCamJHRnpjeUJEYjI1elpXNTBUV0Z1WVdkbGNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1Ua0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHWmlaRGMyTURVMElEQjRZbVZtWkRZek5tWWdNSGcyWmpSbVlXRmtNaUF3ZUdFME4yUmlZekJtSURCNE5HTXlPR0UxWVdNZ01IZzBNelEyTWpkbE9TQXdlR1E0TkdSbFltUXdJREI0TmpBeU9XRmhaR0VnTUhobE5HRTBZbVE1WWlBd2VHWmlPRGt3TmpJNUlDOHZJRzFsZEdodlpDQWlaM0poYm5SZlkyOXVjMlZ1ZENoaFpHUnlaWE56TEhOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p5WlhadmEyVmZZMjl1YzJWdWRDaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WeGRXVnpkRjlsY21GemRYSmxLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZjR0YwYVdWdWRGOWpiMjV6Wlc1MGN5aGhaR1J5WlhOektTaGhaR1J5WlhOekxHRmtaSEpsYzNNc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3NkV2x1ZERZMExIVnBiblEyTkN4aWIyOXNMR0p2YjJ3cFcxMGlMQ0J0WlhSb2IyUWdJblpoYkdsa1lYUmxYMk52Ym5ObGJuUW9ZV1JrY21WemN5eDFhVzUwTmpRc2MzUnlhVzVuS1dKdmIyd2lMQ0J0WlhSb2IyUWdJblZ3WkdGMFpWOWpiMjV6Wlc1MFgyUjFjbUYwYVc5dUtIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljbVZ4ZFdWemRGOWhZMk5sYzNNb1lXUmtjbVZ6Y3l4emRISnBibWNwZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwWDNCbGJtUnBibWRmY21WeGRXVnpkSE1vWVdSa2NtVnpjeWtvZFdsdWREWTBMR0ZrWkhKbGMzTXNjM1J5YVc1bkxIVnBiblEyTkN4aWIyOXNLVnRkSWl3Z2JXVjBhRzlrSUNKaGNIQnliM1psWDNKbGNYVmxjM1FvZFdsdWREWTBMSE4wY21sdVp5eHpkSEpwYm1jc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsYW1WamRGOXlaWEYxWlhOMEtIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWjNKaGJuUmZZMjl1YzJWdWRDQnlaWFp2YTJWZlkyOXVjMlZ1ZENCeVpYRjFaWE4wWDJWeVlYTjFjbVVnWjJWMFgzQmhkR2xsYm5SZlkyOXVjMlZ1ZEhNZ2RtRnNhV1JoZEdWZlkyOXVjMlZ1ZENCMWNHUmhkR1ZmWTI5dWMyVnVkRjlrZFhKaGRHbHZiaUJ5WlhGMVpYTjBYMkZqWTJWemN5Qm5aWFJmY0dWdVpHbHVaMTl5WlhGMVpYTjBjeUJoY0hCeWIzWmxYM0psY1hWbGMzUWdjbVZxWldOMFgzSmxjWFZsYzNRS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhPVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdYM0IxZVdGZmJHbGlMbUZ5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MEtHRnljbUY1WDJsMFpXMXpYMk52ZFc1ME9pQjFhVzUwTmpRc0lHRnljbUY1WDJobFlXUmZZVzVrWDNSaGFXdzZJR0o1ZEdWekxDQnVaWGRmYVhSbGJYTmZZMjkxYm5RNklIVnBiblEyTkN3Z2JtVjNYMmhsWVdSZllXNWtYM1JoYVd3NklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1ME9nb2dJQ0FnY0hKdmRHOGdOQ0F4Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0lpQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NncGtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlrZVc1aGJXbGpYMlZzWlcxbGJuUmZabTl5WDJobFlXUmxja0F4T2dvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNBOENpQWdJQ0JpZWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5SZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQmlJR1I1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJSNWJtRnRhV05mWld4bGJXVnVkRjltYjNKZmFHVmhaR1Z5UURFS0NtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOWhablJsY2w5bWIzSkFORG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2JHVnVDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0NtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOW1iM0pmYUdWaFpHVnlRRFU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUdSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5aFpuUmxjbDltYjNKQU9Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFFLSUNBZ0lHSWdaSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWkhsdVlXMXBZMTlsYkdWdFpXNTBYMlp2Y2w5b1pXRmtaWEpBTlFvS1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyRm1kR1Z5WDJadmNrQTRPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWDNCMWVXRmZiR2xpTG1GeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVY5eVpYQnNZV05sWDJSNWJtRnRhV05mWld4bGJXVnVkQ2h6YjNWeVkyVTZJR0o1ZEdWekxDQnVaWGRmYVhSbGJUb2dZbmwwWlhNc0lHbHVaR1Y0T2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwa2VXNWhiV2xqWDJGeWNtRjVYM0psY0d4aFkyVmZaSGx1WVcxcFkxOWxiR1Z0Wlc1ME9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lITjFZbk4wY21sdVp5QXdJRElLSUNBZ0lHUjFjQW9nSUNBZ1luUnZhUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBckNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR1JwWnlBeENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTBDaUFnSUNBdENpQWdJQ0JqYjNabGNpQTJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4bGJnb2dJQ0FnWTI5MlpYSWdOZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBcUNpQWdJQ0J6ZDJGd0NncGtlVzVoYldsalgyRnljbUY1WDNKbGNHeGhZMlZmWkhsdVlXMXBZMTlsYkdWdFpXNTBYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJR1p5WVcxbFgyUnBaeUExQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1BBb2dJQ0FnWW5vZ1pIbHVZVzFwWTE5aGNuSmhlVjl5WlhCc1lXTmxYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOWhablJsY2w5bWIzSkFOUW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0ExQ2lBZ0lDQmlJR1I1Ym1GdGFXTmZZWEp5WVhsZmNtVndiR0ZqWlY5a2VXNWhiV2xqWDJWc1pXMWxiblJmWm05eVgyaGxZV1JsY2tBeUNncGtlVzVoYldsalgyRnljbUY1WDNKbGNHeGhZMlZmWkhsdVlXMXBZMTlsYkdWdFpXNTBYMkZtZEdWeVgyWnZja0ExT2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnZibk5sYm5SZmJXRnVZV2RsY2k1amIyNTBjbUZqZEM1RGIyNXpaVzUwVFdGdVlXZGxjaTVuY21GdWRGOWpiMjV6Wlc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taM0poYm5SZlkyOXVjMlZ1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TlRJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QnpaVzVrWlhKZllXUmtjaUE5SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk5Bb2dJQ0FnTHk4Z2JtOTNJRDBnYjNBdVIyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOalVLSUNBZ0lDOHZJR1Y0Y0dseWVTQTlJRzV2ZHlBcklHUjFjbUYwYVc5dVgybHVYM05sWTI5dVpITXVibUYwYVhabENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSjBiMmtLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qY3pDaUFnSUNBdkx5Qm5jbUZ1ZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0c1dmR5a3NDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QmxlSEJwY25rOVlYSmpOQzVWU1c1ME5qUW9aWGh3YVhKNUtTd0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5qY3ROemNLSUNBZ0lDOHZJRzVsZDE5amIyNXpaVzUwSUQwZ1EyOXVjMlZ1ZENnS0lDQWdJQzh2SUNBZ0lDQmtZWFJoWDNCeWFXNWphWEJoYkQxelpXNWtaWEpmWVdSa2Npd0tJQ0FnSUM4dklDQWdJQ0JrWVhSaFgyWnBaSFZqYVdGeWVUMW1hV1IxWTJsaGNua3NDaUFnSUNBdkx5QWdJQ0FnY0hWeWNHOXpaVDF3ZFhKd2IzTmxMQW9nSUNBZ0x5OGdJQ0FnSUdSaGRHRmZhR0Z6YUQxa1lYUmhYMmhoYzJnc0NpQWdJQ0F2THlBZ0lDQWdaR0YwWVY5elkyOXdaVDFrWVhSaFgzTmpiM0JsTEFvZ0lDQWdMeThnSUNBZ0lHZHlZVzUwWldSZllYUTlZWEpqTkM1VlNXNTBOalFvYm05M0tTd0tJQ0FnSUM4dklDQWdJQ0JsZUhCcGNuazlZWEpqTkM1VlNXNTBOalFvWlhod2FYSjVLU3dLSUNBZ0lDOHZJQ0FnSUNCcGMxOWhZM1JwZG1VOVlYSmpOQzVDYjI5c0tGUnlkV1VwTEFvZ0lDQWdMeThnSUNBZ0lHVnlZWE5sWkQxaGNtTTBMa0p2YjJ3b1JtRnNjMlVwTEFvZ0lDQWdMeThnS1FvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUF3ZURBd05UY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR2x1ZENBNE53b2dJQ0FnZFc1amIzWmxjaUE0Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE9EQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8zT1FvZ0lDQWdMeThnYVdZZ2MyVnVaR1Z5WDJGa1pISWdhVzRnYzJWc1ppNWpiMjV6Wlc1MGN6b0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJNelZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJuY21GdWRGOWpiMjV6Wlc1MFgyVnNjMlZmWW05a2VVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qZ3dDaUFnSUNBdkx5QmhjbklnUFNCelpXeG1MbU52Ym5ObGJuUnpXM05sYm1SbGNsOWhaR1J5WFM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OdmJuTmxiblJ6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvNE1Rb2dJQ0FnTHk4Z1lYSnlMbUZ3Y0dWdVpDaHVaWGRmWTI5dWMyVnVkQzVqYjNCNUtDa3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EQXlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMkZzYkhOMVlpQmtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlrZVc1aGJXbGpYMlZzWlcxbGJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk9ESUtJQ0FnSUM4dklITmxiR1l1WTI5dWMyVnVkSE5iYzJWdVpHVnlYMkZrWkhKZElEMGdZWEp5TG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb0taM0poYm5SZlkyOXVjMlZ1ZEY5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPalV5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWR5WVc1MFgyTnZibk5sYm5SZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qZzBDaUFnSUNBdkx5QmhjbklnUFNCaGNtTTBMa1I1Ym1GdGFXTkJjbkpoZVZ0RGIyNXpaVzUwWFNodVpYZGZZMjl1YzJWdWRDNWpiM0I1S0NrcENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1EQXdNVEF3TURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z2MyVnNaaTVqYjI1elpXNTBjMXR6Wlc1a1pYSmZZV1JrY2wwZ1BTQmhjbkl1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJR0lnWjNKaGJuUmZZMjl1YzJWdWRGOWhablJsY2w5cFpsOWxiSE5sUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMjl1YzJWdWRGOXRZVzVoWjJWeUxtTnZiblJ5WVdOMExrTnZibk5sYm5STllXNWhaMlZ5TG5KbGRtOXJaVjlqYjI1elpXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WMmIydGxYMk52Ym5ObGJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qZzNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk9UQUtJQ0FnSUM4dklHRnljaUE5SUhObGJHWXVZMjl1YzJWdWRITmJjMlZ1WkdWeVgyRmtaSEpkTG1OdmNIa29LUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFl6TldZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2T0RrS0lDQWdJQzh2SUhObGJtUmxjbDloWkdSeUlEMGdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPamt3Q2lBZ0lDQXZMeUJoY25JZ1BTQnpaV3htTG1OdmJuTmxiblJ6VzNObGJtUmxjbDloWkdSeVhTNWpiM0I1S0NrS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpiMjV6Wlc1MGN5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZPVEVLSUNBZ0lDOHZJR052Ym5ObGJuUWdQU0JoY25KYmFXNWtaWGd1Ym1GMGFYWmxYUzVqYjNCNUtDa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdMU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdScFp5QTBDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDb0tJQ0FnSUdScFp5QTFDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG81TUMwNU1nb2dJQ0FnTHk4Z1lYSnlJRDBnYzJWc1ppNWpiMjV6Wlc1MGMxdHpaVzVrWlhKZllXUmtjbDB1WTI5d2VTZ3BDaUFnSUNBdkx5QmpiMjV6Wlc1MElEMGdZWEp5VzJsdVpHVjRMbTVoZEdsMlpWMHVZMjl3ZVNncENpQWdJQ0F2THlCaGMzTmxjblFnWTI5dWMyVnVkQzVwYzE5aFkzUnBkbVV1Ym1GMGFYWmxMQ0FpUVd4eVpXRmtlU0J5WlhadmEyVmtJZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUdScFp5QXpDaUFnSUNBcUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JRFVLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnY0hWemFHbHVkQ0E0T0FvZ0lDQWdLd29nSUNBZ1pHbG5JRFVLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUdOdmJuTmxiblF1YVhOZllXTjBhWFpsTG01aGRHbDJaU3dnSWtGc2NtVmhaSGtnY21WMmIydGxaQ0lLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaGMzTmxjblFnTHk4Z1FXeHlaV0ZrZVNCeVpYWnZhMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPamt6Q2lBZ0lDQXZMeUJqYjI1elpXNTBMbWx6WDJGamRHbDJaU0E5SUdGeVl6UXVRbTl2YkNoR1lXeHpaU2tLSUNBZ0lIQjFjMmhwYm5RZ05qZzRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qazBDaUFnSUNBdkx5QmhjbkpiYVc1a1pYZ3VibUYwYVhabFhTQTlJR052Ym5ObGJuUXVZMjl3ZVNncENpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQThDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnWkhsdVlXMXBZMTloY25KaGVWOXlaWEJzWVdObFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG81TlFvZ0lDQWdMeThnYzJWc1ppNWpiMjV6Wlc1MGMxdHpaVzVrWlhKZllXUmtjbDBnUFNCaGNuSXVZMjl3ZVNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPamczQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WTI5dWMyVnVkRjl0WVc1aFoyVnlMbU52Ym5SeVlXTjBMa052Ym5ObGJuUk5ZVzVoWjJWeUxuSmxjWFZsYzNSZlpYSmhjM1Z5WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxjWFZsYzNSZlpYSmhjM1Z5WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2T1RjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TURBS0lDQWdJQzh2SUdGeWNpQTlJSE5sYkdZdVkyOXVjMlZ1ZEhOYmMyVnVaR1Z5WDJGa1pISmRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEWXpOV1lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZPVGtLSUNBZ0lDOHZJSE5sYm1SbGNsOWhaR1J5SUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXdNQW9nSUNBZ0x5OGdZWEp5SUQwZ2MyVnNaaTVqYjI1elpXNTBjMXR6Wlc1a1pYSmZZV1JrY2wwdVkyOXdlU2dwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyOXVjMlZ1ZEhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXdNUW9nSUNBZ0x5OGdZMjl1YzJWdWRDQTlJR0Z5Y2x0cGJtUmxlQzV1WVhScGRtVmRMbU52Y0hrb0tRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXRJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklEUUtJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklEVUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakV3TWdvZ0lDQWdMeThnWTI5dWMyVnVkQzVsY21GelpXUWdQU0JoY21NMExrSnZiMndvVkhKMVpTa0tJQ0FnSUhCMWMyaHBiblFnTmpnNUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFd013b2dJQ0FnTHk4Z1kyOXVjMlZ1ZEM1cGMxOWhZM1JwZG1VZ1BTQmhjbU0wTGtKdmIyd29SbUZzYzJVcENpQWdJQ0J3ZFhOb2FXNTBJRFk0T0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITmxkR0pwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TURRS0lDQWdJQzh2SUdOdmJuTmxiblF1Y0hWeWNHOXpaU0E5SUdGeVl6UXVVM1J5YVc1bktDSkZVa0ZUUlVRaUtRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3dNREEyTkRVMU1qUXhOVE0wTlRRMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURZMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklETUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklEUUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0F0Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdMUW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdOallLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnY0hWemFHbHVkQ0EyT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCeVpYQnNZV05sTWlBMk9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1EVUtJQ0FnSUM4dklHTnZibk5sYm5RdVpHRjBZVjlvWVhOb0lEMGdZWEpqTkM1VGRISnBibWNvSWtWU1FWTkZSQ0lwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05qWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TURRS0lDQWdJQzh2SUdOdmJuTmxiblF1Y0hWeWNHOXpaU0E5SUdGeVl6UXVVM1J5YVc1bktDSkZVa0ZUUlVRaUtRb2dJQ0FnWW5sMFpXTWdPQ0F2THlBd2VEQXdNRFkwTlRVeU5ERTFNelExTkRRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRBMUNpQWdJQ0F2THlCamIyNXpaVzUwTG1SaGRHRmZhR0Z6YUNBOUlHRnlZelF1VTNSeWFXNW5LQ0pGVWtGVFJVUWlLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQTJPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJQzBLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J5WlhCc1lXTmxNaUEyT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TURZS0lDQWdJQzh2SUdOdmJuTmxiblF1WkdGMFlWOXpZMjl3WlNBOUlHRnlZelF1VTNSeWFXNW5LQ0pGVWtGVFJVUWlLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURZNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXdOQW9nSUNBZ0x5OGdZMjl1YzJWdWRDNXdkWEp3YjNObElEMGdZWEpqTkM1VGRISnBibWNvSWtWU1FWTkZSQ0lwQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TURBd05qUTFOVEkwTVRVek5EVTBOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNRFlLSUNBZ0lDOHZJR052Ym5ObGJuUXVaR0YwWVY5elkyOXdaU0E5SUdGeVl6UXVVM1J5YVc1bktDSkZVa0ZUUlVRaUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXdOd29nSUNBZ0x5OGdZWEp5VzJsdVpHVjRMbTVoZEdsMlpWMGdQU0JqYjI1elpXNTBMbU52Y0hrb0tRb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZjbVZ3YkdGalpWOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRBNENpQWdJQ0F2THlCelpXeG1MbU52Ym5ObGJuUnpXM05sYm1SbGNsOWhaR1J5WFNBOUlHRnljaTVqYjNCNUtDa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2T1RjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1amIyNXpaVzUwWDIxaGJtRm5aWEl1WTI5dWRISmhZM1F1UTI5dWMyVnVkRTFoYm1GblpYSXVaMlYwWDNCaGRHbGxiblJmWTI5dWMyVnVkSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZjR0YwYVdWdWRGOWpiMjV6Wlc1MGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1URXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1URTBDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVqYjI1elpXNTBjMXR3WVhScFpXNTBYUzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJNelZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnZibk5sYm5SeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNVEFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldNZ09TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWpiMjV6Wlc1MFgyMWhibUZuWlhJdVkyOXVkSEpoWTNRdVEyOXVjMlZ1ZEUxaGJtRm5aWEl1ZG1Gc2FXUmhkR1ZmWTI5dWMyVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25aaGJHbGtZWFJsWDJOdmJuTmxiblE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEkxQ2lBZ0lDQXZMeUJoY25JZ1BTQnpaV3htTG1OdmJuTmxiblJ6VzNCeWFXNWphWEJoYkYwdVkyOXdlU2dwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TmpNMVpnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqYjI1elpXNTBjeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJMkNpQWdJQ0F2THlCamIyNXpaVzUwSUQwZ1lYSnlXMmx1WkdWNExtNWhkR2wyWlYwdVkyOXdlU2dwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJM0NpQWdJQ0F2THlCdWIzY2dQU0J2Y0M1SGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TXpBS0lDQWdJQzh2SUdOdmJuTmxiblF1YVhOZllXTjBhWFpsTG01aGRHbDJaUW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUhCMWMyaHBiblFnT0RnS0lDQWdJQ3NLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRNd0xURXpNZ29nSUNBZ0x5OGdZMjl1YzJWdWRDNXBjMTloWTNScGRtVXVibUYwYVhabENpQWdJQ0F2THlCaGJtUWdibTkwSUdOdmJuTmxiblF1WlhKaGMyVmtMbTVoZEdsMlpRb2dJQ0FnTHk4Z1lXNWtJRzV2ZHlBOFBTQmpiMjV6Wlc1MExtVjRjR2x5ZVM1dVlYUnBkbVVLSUNBZ0lHSjZJSFpoYkdsa1lYUmxYMk52Ym5ObGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFek1Rb2dJQ0FnTHk4Z1lXNWtJRzV2ZENCamIyNXpaVzUwTG1WeVlYTmxaQzV1WVhScGRtVUtJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJSEIxYzJocGJuUWdPRGdLSUNBZ0lDc0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSnVlaUIyWVd4cFpHRjBaVjlqYjI1elpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU9Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE16SUtJQ0FnSUM4dklHRnVaQ0J1YjNjZ1BEMGdZMjl1YzJWdWRDNWxlSEJwY25rdWJtRjBhWFpsQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCd2RYTm9hVzUwSURnd0NpQWdJQ0FyQ2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QXlDaUFnSUNBK1BRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE16QXRNVE15Q2lBZ0lDQXZMeUJqYjI1elpXNTBMbWx6WDJGamRHbDJaUzV1WVhScGRtVUtJQ0FnSUM4dklHRnVaQ0J1YjNRZ1kyOXVjMlZ1ZEM1bGNtRnpaV1F1Ym1GMGFYWmxDaUFnSUNBdkx5QmhibVFnYm05M0lEdzlJR052Ym5ObGJuUXVaWGh3YVhKNUxtNWhkR2wyWlFvZ0lDQWdZbm9nZG1Gc2FXUmhkR1ZmWTI5dWMyVnVkRjloWm5SbGNsOXBabDlsYkhObFFEa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UTTBDaUFnSUNBdkx5QnBaaUJqYjI1elpXNTBMbVJoZEdGZmMyTnZjR1VnUFQwZ1lYSmpOQzVUZEhKcGJtY29Ja0ZzYkNJcE9nb2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURNS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnTFNBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EyT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0E0Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBek5ERTJZelpqQ2lBZ0lDQTlQUW9nSUNBZ1lub2dkbUZzYVdSaGRHVmZZMjl1YzJWdWRGOWhablJsY2w5cFpsOWxiSE5sUURZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRNMUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0ZSeWRXVXBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRPREFLQ25aaGJHbGtZWFJsWDJOdmJuTmxiblJmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TG1OdmJuUnlZV04wTGtOdmJuTmxiblJOWVc1aFoyVnlMblpoYkdsa1lYUmxYMk52Ym5ObGJuUkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakV4TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFl5QTVJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncDJZV3hwWkdGMFpWOWpiMjV6Wlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRNMkNpQWdJQ0F2THlCcFppQmpiMjV6Wlc1MExtUmhkR0ZmYzJOdmNHVWdQVDBnY21WeGRXbHlaV1JmYzJOdmNHVTZDaUFnSUNCa2FXY2dOZ29nSUNBZ1pHbG5JRFlLSUNBZ0lEMDlDaUFnSUNCaWVpQjJZV3hwWkdGMFpWOWpiMjV6Wlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBT1FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TXpjS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExrSnZiMndvVkhKMVpTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzRNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUIyWVd4cFpHRjBaVjlqYjI1elpXNTBYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1OdmJuTmxiblJmYldGdVlXZGxjaTVqYjI1MGNtRmpkQzVEYjI1elpXNTBUV0Z1WVdkbGNpNTJZV3hwWkdGMFpWOWpiMjV6Wlc1MFFERXdDZ3AyWVd4cFpHRjBaVjlqYjI1elpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UTTVDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVDYjI5c0tFWmhiSE5sS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFeE5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaUlIWmhiR2xrWVhSbFgyTnZibk5sYm5SZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVZMjl1YzJWdWRGOXRZVzVoWjJWeUxtTnZiblJ5WVdOMExrTnZibk5sYm5STllXNWhaMlZ5TG5aaGJHbGtZWFJsWDJOdmJuTmxiblJBTVRBS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMjl1YzJWdWRGOXRZVzVoWjJWeUxtTnZiblJ5WVdOMExrTnZibk5sYm5STllXNWhaMlZ5TG5Wd1pHRjBaVjlqYjI1elpXNTBYMlIxY21GMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxYMk52Ym5ObGJuUmZaSFZ5WVhScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTBNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakUwT0FvZ0lDQWdMeThnWVhKeUlEMGdjMlZzWmk1amIyNXpaVzUwYzF0elpXNWtaWEpmWVdSa2NsMHVZMjl3ZVNncENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5qTTFaZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hORGNLSUNBZ0lDOHZJSE5sYm1SbGNsOWhaR1J5SUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTBPQW9nSUNBZ0x5OGdZWEp5SUQwZ2MyVnNaaTVqYjI1elpXNTBjMXR6Wlc1a1pYSmZZV1JrY2wwdVkyOXdlU2dwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyOXVjMlZ1ZEhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTBPUW9nSUNBZ0x5OGdZMjl1YzJWdWRDQTlJR0Z5Y2x0cGJtUmxlQzV1WVhScGRtVmRMbU52Y0hrb0tRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXRJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklEUUtJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklEVUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakUwT0MweE5UQUtJQ0FnSUM4dklHRnljaUE5SUhObGJHWXVZMjl1YzJWdWRITmJjMlZ1WkdWeVgyRmtaSEpkTG1OdmNIa29LUW9nSUNBZ0x5OGdZMjl1YzJWdWRDQTlJR0Z5Y2x0cGJtUmxlQzV1WVhScGRtVmRMbU52Y0hrb0tRb2dJQ0FnTHk4Z1lYTnpaWEowSUdOdmJuTmxiblF1YVhOZllXTjBhWFpsTG01aGRHbDJaU3dnSWtOdmJuTmxiblFnYm05MElHRmpkR2wyWlNJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQmthV2NnTXdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lIQjFjMmhwYm5RZ09EZ0tJQ0FnSUNzS0lDQWdJR1JwWnlBMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVFV3Q2lBZ0lDQXZMeUJoYzNObGNuUWdZMjl1YzJWdWRDNXBjMTloWTNScGRtVXVibUYwYVhabExDQWlRMjl1YzJWdWRDQnViM1FnWVdOMGFYWmxJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdGemMyVnlkQ0F2THlCRGIyNXpaVzUwSUc1dmRDQmhZM1JwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRVeENpQWdJQ0F2THlCdWIzY2dQU0J2Y0M1SGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hOVElLSUNBZ0lDOHZJR052Ym5ObGJuUXVaWGh3YVhKNUlEMGdZWEpqTkM1VlNXNTBOalFvYm05M0lDc2dibVYzWDJSMWNtRjBhVzl1WDJsdVgzTmxZMjl1WkhNdWJtRjBhWFpsS1FvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCaWRHOXBDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUEzT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TlRNS0lDQWdJQzh2SUdGeWNsdHBibVJsZUM1dVlYUnBkbVZkSUQwZ1kyOXVjMlZ1ZEM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUR3S0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQmtlVzVoYldsalgyRnljbUY1WDNKbGNHeGhZMlZmWkhsdVlXMXBZMTlsYkdWdFpXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTFOQW9nSUNBZ0x5OGdjMlZzWmk1amIyNXpaVzUwYzF0elpXNWtaWEpmWVdSa2NsMGdQU0JoY25JdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTBNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU52Ym5ObGJuUmZiV0Z1WVdkbGNpNWpiMjUwY21GamRDNURiMjV6Wlc1MFRXRnVZV2RsY2k1eVpYRjFaWE4wWDJGalkyVnpjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGNYVmxjM1JmWVdOalpYTnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hOVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hOaklLSUNBZ0lDOHZJSE5sYkdZdWNtVnhkV1Z6ZEY5amIzVnVkR1Z5TG5aaGJIVmxJQ3M5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbkpsY1Y5amIzVnVkR1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuSmxjWFZsYzNSZlkyOTFiblJsY2lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKeVpYRmZZMjkxYm5SbGNpSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hOalFLSUNBZ0lDOHZJR2xrUFdGeVl6UXVWVWx1ZERZMEtITmxiR1l1Y21WeGRXVnpkRjlqYjNWdWRHVnlMblpoYkhWbEtTd0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UWTFDaUFnSUNBdkx5QndjbTkyYVdSbGNqMWhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakUyTndvZ0lDQWdMeThnZEdsdFpYTjBZVzF3UFdGeVl6UXVWVWx1ZERZMEtHOXdMa2RzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UWXpMVEUyT1FvZ0lDQWdMeThnYm1WM1gzSmxjWFZsYzNRZ1BTQkJZMk5sYzNOU1pYRjFaWE4wS0FvZ0lDQWdMeThnSUNBZ0lHbGtQV0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVjbVZ4ZFdWemRGOWpiM1Z1ZEdWeUxuWmhiSFZsS1N3S0lDQWdJQzh2SUNBZ0lDQndjbTkyYVdSbGNqMWhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lDQWdjSFZ5Y0c5elpUMXdkWEp3YjNObExBb2dJQ0FnTHk4Z0lDQWdJSFJwYldWemRHRnRjRDFoY21NMExsVkpiblEyTkNodmNDNUhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0F2THlBZ0lDQWdhWE5mY0dWdVpHbHVaejFoY21NMExrSnZiMndvVkhKMVpTa3NDaUFnSUNBdkx5QXBDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd016TUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakUyT0FvZ0lDQWdMeThnYVhOZmNHVnVaR2x1WnoxaGNtTTBMa0p2YjJ3b1ZISjFaU2tzQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0T0RBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRZekxURTJPUW9nSUNBZ0x5OGdibVYzWDNKbGNYVmxjM1FnUFNCQlkyTmxjM05TWlhGMVpYTjBLQW9nSUNBZ0x5OGdJQ0FnSUdsa1BXRnlZelF1VlVsdWREWTBLSE5sYkdZdWNtVnhkV1Z6ZEY5amIzVnVkR1Z5TG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ0FnSUNCd2NtOTJhV1JsY2oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ2NIVnljRzl6WlQxd2RYSndiM05sTEFvZ0lDQWdMeThnSUNBZ0lIUnBiV1Z6ZEdGdGNEMWhjbU0wTGxWSmJuUTJOQ2h2Y0M1SGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZjR1Z1WkdsdVp6MWhjbU0wTGtKdmIyd29WSEoxWlNrc0NpQWdJQ0F2THlBcENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hOekVLSUNBZ0lDOHZJR2xtSUhCaGRHbGxiblFnYVc0Z2MyVnNaaTVoWTJObGMzTmZjbVZ4ZFdWemRITTZDaUFnSUNCaWVYUmxZeUExSUM4dklEQjROakUzTWpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCeVpYRjFaWE4wWDJGalkyVnpjMTlsYkhObFgySnZaSGxBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TnpJS0lDQWdJQzh2SUdGeWNpQTlJSE5sYkdZdVlXTmpaWE56WDNKbGNYVmxjM1J6VzNCaGRHbGxiblJkTG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdOalpYTnpYM0psY1hWbGMzUnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TnpNS0lDQWdJQzh2SUdGeWNpNWhjSEJsYm1Rb2JtVjNYM0psY1hWbGMzUXVZMjl3ZVNncEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURBd01nb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTmhiR3h6ZFdJZ1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFM05Bb2dJQ0FnTHk4Z2MyVnNaaTVoWTJObGMzTmZjbVZ4ZFdWemRITmJjR0YwYVdWdWRGMGdQU0JoY25JdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDZ3B5WlhGMVpYTjBYMkZqWTJWemMxOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFMU5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dweVpYRjFaWE4wWDJGalkyVnpjMTlsYkhObFgySnZaSGxBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRjMkNpQWdJQ0F2THlCaGNuSWdQU0JoY21NMExrUjVibUZ0YVdOQmNuSmhlVnRCWTJObGMzTlNaWEYxWlhOMFhTaHVaWGRmY21WeGRXVnpkQzVqYjNCNUtDa3BDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNREF3TVRBd01ESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hOemNLSUNBZ0lDOHZJSE5sYkdZdVlXTmpaWE56WDNKbGNYVmxjM1J6VzNCaGRHbGxiblJkSUQwZ1lYSnlMbU52Y0hrb0tRb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmlJSEpsY1hWbGMzUmZZV05qWlhOelgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWpiMjV6Wlc1MFgyMWhibUZuWlhJdVkyOXVkSEpoWTNRdVEyOXVjMlZ1ZEUxaGJtRm5aWEl1WjJWMFgzQmxibVJwYm1kZmNtVnhkV1Z6ZEhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmY0dWdVpHbHVaMTl5WlhGMVpYTjBjem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0lpSUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hOemtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hPRE1LSUNBZ0lDOHZJSEJsYm1ScGJtY2dQU0JoY21NMExrUjVibUZ0YVdOQmNuSmhlVnRCWTJObGMzTlNaWEYxWlhOMFhTZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakU0TkFvZ0lDQWdMeThnYVdZZ2NHRjBhV1Z1ZENCcGJpQnpaV3htTG1GalkyVnpjMTl5WlhGMVpYTjBjem9LSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGcyTVRjeU5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdkbGRGOXdaVzVrYVc1blgzSmxjWFZsYzNSelgyRm1kR1Z5WDJsbVgyVnNjMlZBT1FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94T0RVS0lDQWdJQzh2SUdGeWNpQTlJSE5sYkdZdVlXTmpaWE56WDNKbGNYVmxjM1J6VzNCaGRHbGxiblJkTG1OdmNIa29LUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZFhKNUlEa0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmpZMlZ6YzE5eVpYRjFaWE4wY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UZzFMVEU0TmdvZ0lDQWdMeThnWVhKeUlEMGdjMlZzWmk1aFkyTmxjM05mY21WeGRXVnpkSE5iY0dGMGFXVnVkRjB1WTI5d2VTZ3BDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb1lYSnlMbXhsYm1kMGFDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmlkWEo1SURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRnMkNpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvWVhKeUxteGxibWQwYUNrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZblZ5ZVNBekNncG5aWFJmY0dWdVpHbHVaMTl5WlhGMVpYTjBjMTltYjNKZmFHVmhaR1Z5UURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFNE5nb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0dGeWNpNXNaVzVuZEdncE9nb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QTBDaUFnSUNBOENpQWdJQ0JpZWlCblpYUmZjR1Z1WkdsdVoxOXlaWEYxWlhOMGMxOWhablJsY2w5cFpsOWxiSE5sUURrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRnM0NpQWdJQ0F2THlCeVpYRWdQU0JoY25KYmFWMHVZMjl3ZVNncENpQWdJQ0JrYVdjZ05nb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdScFp5QTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdScFp5QXhDaUFnSUNBdElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaR2xuSURRS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURVS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCaWRYSjVJRGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVGczTFRFNE9Bb2dJQ0FnTHk4Z2NtVnhJRDBnWVhKeVcybGRMbU52Y0hrb0tRb2dJQ0FnTHk4Z2FXWWdjbVZ4TG1selgzQmxibVJwYm1jdWJtRjBhWFpsT2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdjSFZ6YUdsdWRDQTFNZ29nSUNBZ0t3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakU0T0FvZ0lDQWdMeThnYVdZZ2NtVnhMbWx6WDNCbGJtUnBibWN1Ym1GMGFYWmxPZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNklHZGxkRjl3Wlc1a2FXNW5YM0psY1hWbGMzUnpYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE9Ea0tJQ0FnSUM4dklIQmxibVJwYm1jdVlYQndaVzVrS0hKbGNTNWpiM0I1S0NrcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURBd01nb2dJQ0FnWkdsbklEZ0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTJGc2JITjFZaUJrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5a2VXNWhiV2xqWDJWc1pXMWxiblFLSUNBZ0lHSjFjbmtnTWdvS1oyVjBYM0JsYm1ScGJtZGZjbVZ4ZFdWemRITmZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnWkdsbklEUUtJQ0FnSUdKMWNua2dNd29nSUNBZ1lpQm5aWFJmY0dWdVpHbHVaMTl5WlhGMVpYTjBjMTltYjNKZmFHVmhaR1Z5UURNS0NtZGxkRjl3Wlc1a2FXNW5YM0psY1hWbGMzUnpYMkZtZEdWeVgybG1YMlZzYzJWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UYzVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnZibk5sYm5SZmJXRnVZV2RsY2k1amIyNTBjbUZqZEM1RGIyNXpaVzUwVFdGdVlXZGxjaTVoY0hCeWIzWmxYM0psY1hWbGMzUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoY0hCeWIzWmxYM0psY1hWbGMzUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE9USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndiaUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakl3TWdvZ0lDQWdMeThnYzJWdVpHVnlYMkZrWkhJZ1BTQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNakF6Q2lBZ0lDQXZMeUJoY25JZ1BTQnpaV3htTG1GalkyVnpjMTl5WlhGMVpYTjBjMXR6Wlc1a1pYSmZZV1JrY2wwdVkyOXdlU2dwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TmpFM01qVm1DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qSXdNZ29nSUNBZ0x5OGdjMlZ1WkdWeVgyRmtaSElnUFNCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1qQXpDaUFnSUNBdkx5QmhjbklnUFNCelpXeG1MbUZqWTJWemMxOXlaWEYxWlhOMGMxdHpaVzVrWlhKZllXUmtjbDB1WTI5d2VTZ3BDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV05qWlhOelgzSmxjWFZsYzNSeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3lNRFFLSUNBZ0lDOHZJR1p2ZFc1a0lEMGdZWEpqTkM1Q2IyOXNLRVpoYkhObEtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qSXdOUW9nSUNBZ0x5OGdabTkxYm1SZmFXUjRJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3lNRGNLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaGhjbkl1YkdWdVozUm9LVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwaGNIQnliM1psWDNKbGNYVmxjM1JmWm05eVgyaGxZV1JsY2tBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU1EY0tJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoaGNuSXViR1Z1WjNSb0tUb0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUdGd2NISnZkbVZmY21WeGRXVnpkRjloWm5SbGNsOW1iM0pBT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG95TURndE1qQTVDaUFnSUNBdkx5QnlaWEVnUFNCaGNuSmJhVjB1WTI5d2VTZ3BDaUFnSUNBdkx5QnBaaUJ5WlhFdWFXUWdQVDBnY21WeGRXVnpkRjlwWkNCaGJtUWdjbVZ4TG1selgzQmxibVJwYm1jdWJtRjBhWFpsT2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFMENpQWdJQ0JrYVdjZ05nb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU1Ea0tJQ0FnSUM4dklHbG1JSEpsY1M1cFpDQTlQU0J5WlhGMVpYTjBYMmxrSUdGdVpDQnlaWEV1YVhOZmNHVnVaR2x1Wnk1dVlYUnBkbVU2Q2lBZ0lDQmthV2NnTVRJS0lDQWdJR0k5UFFvZ0lDQWdZbm9nWVhCd2NtOTJaVjl5WlhGMVpYTjBYMkZtZEdWeVgybG1YMlZzYzJWQU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU1EZ3RNakE1Q2lBZ0lDQXZMeUJ5WlhFZ1BTQmhjbkpiYVYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUJwWmlCeVpYRXVhV1FnUFQwZ2NtVnhkV1Z6ZEY5cFpDQmhibVFnY21WeExtbHpYM0JsYm1ScGJtY3VibUYwYVhabE9nb2dJQ0FnWkdsbklEVUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklERTBDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJSEIxYzJocGJuUWdOVElLSUNBZ0lDc0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG95TURrS0lDQWdJQzh2SUdsbUlISmxjUzVwWkNBOVBTQnlaWEYxWlhOMFgybGtJR0Z1WkNCeVpYRXVhWE5mY0dWdVpHbHVaeTV1WVhScGRtVTZDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5vZ1lYQndjbTkyWlY5eVpYRjFaWE4wWDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3lNVEFLSUNBZ0lDOHZJR1p2ZFc1a0lEMGdZWEpqTkM1Q2IyOXNLRlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE9EQUtJQ0FnSUdKMWNua2dOQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRE1LQ21Gd2NISnZkbVZmY21WeGRXVnpkRjloWm5SbGNsOW1iM0pBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpFMENpQWdJQ0F2THlCaGMzTmxjblFnWm05MWJtUXVibUYwYVhabExDQWlVR1Z1WkdsdVp5QnlaWEYxWlhOMElHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaGMzTmxjblFnTHk4Z1VHVnVaR2x1WnlCeVpYRjFaWE4wSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG95TVRZS0lDQWdJQzh2SUhKbGNTQTlJR0Z5Y2x0bWIzVnVaRjlwWkhoZExtTnZjSGtvS1FvZ0lDQWdaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkdsbklEVUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JREVLSUNBZ0lDMGdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBcUNpQWdJQ0JrYVdjZ05nb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNakUzQ2lBZ0lDQXZMeUJ5WlhFdWFYTmZjR1Z1WkdsdVp5QTlJR0Z5WXpRdVFtOXZiQ2hHWVd4elpTa0tJQ0FnSUhCMWMyaHBiblFnTkRBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pJeE9Bb2dJQ0FnTHk4Z1lYSnlXMlp2ZFc1a1gybGtlRjBnUFNCeVpYRXVZMjl3ZVNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQThDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURFS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyRnNiSE4xWWlCa2VXNWhiV2xqWDJGeWNtRjVYM0psY0d4aFkyVmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjl0WVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pJeE9Rb2dJQ0FnTHk4Z2MyVnNaaTVoWTJObGMzTmZjbVZ4ZFdWemRITmJjMlZ1WkdWeVgyRmtaSEpkSUQwZ1lYSnlMbU52Y0hrb0tRb2dJQ0FnWkdsbklEY0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakl5TVFvZ0lDQWdMeThnYm05M0lEMGdiM0F1UjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1qSXlDaUFnSUNBdkx5QmxlSEJwY25rZ1BTQnViM2NnS3lCa2RYSmhkR2x2Ymw5cGJsOXpaV052Ym1SekxtNWhkR2wyWlFvZ0lDQWdaR2xuSURrS0lDQWdJR0owYjJrS0lDQWdJR1JwWnlBeENpQWdJQ0FyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakl5TmdvZ0lDQWdMeThnWkdGMFlWOW1hV1IxWTJsaGNuazljbVZ4TG5CeWIzWnBaR1Z5TEFvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdPQ0F6TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG95TWpjS0lDQWdJQzh2SUhCMWNuQnZjMlU5Y21WeExuQjFjbkJ2YzJVc0NpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHbHVkQ0EwTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBMENpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3lNekFLSUNBZ0lDOHZJR2R5WVc1MFpXUmZZWFE5WVhKak5DNVZTVzUwTmpRb2JtOTNLU3dLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU16RUtJQ0FnSUM4dklHVjRjR2x5ZVQxaGNtTTBMbFZKYm5RMk5DaGxlSEJwY25rcExBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakl5TkMweU16UUtJQ0FnSUM4dklHNWxkMTlqYjI1elpXNTBJRDBnUTI5dWMyVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCa1lYUmhYM0J5YVc1amFYQmhiRDF6Wlc1a1pYSmZZV1JrY2l3S0lDQWdJQzh2SUNBZ0lDQmtZWFJoWDJacFpIVmphV0Z5ZVQxeVpYRXVjSEp2ZG1sa1pYSXNDaUFnSUNBdkx5QWdJQ0FnY0hWeWNHOXpaVDF5WlhFdWNIVnljRzl6WlN3S0lDQWdJQzh2SUNBZ0lDQmtZWFJoWDJoaGMyZzlaR0YwWVY5b1lYTm9MQW9nSUNBZ0x5OGdJQ0FnSUdSaGRHRmZjMk52Y0dVOVpHRjBZVjl6WTI5d1pTd0tJQ0FnSUM4dklDQWdJQ0JuY21GdWRHVmtYMkYwUFdGeVl6UXVWVWx1ZERZMEtHNXZkeWtzQ2lBZ0lDQXZMeUFnSUNBZ1pYaHdhWEo1UFdGeVl6UXVWVWx1ZERZMEtHVjRjR2x5ZVNrc0NpQWdJQ0F2THlBZ0lDQWdhWE5mWVdOMGFYWmxQV0Z5WXpRdVFtOXZiQ2hVY25WbEtTd0tJQ0FnSUM4dklDQWdJQ0JsY21GelpXUTlZWEpqTkM1Q2IyOXNLRVpoYkhObEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUdScFp5QXhNQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUExQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd3TURVM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0RjS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01UVUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnNE1Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3lNellLSUNBZ0lDOHZJR2xtSUhObGJtUmxjbDloWkdSeUlHbHVJSE5sYkdZdVkyOXVjMlZ1ZEhNNkNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5qTTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRZS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2dZWEJ3Y205MlpWOXlaWEYxWlhOMFgyVnNjMlZmWW05a2VVQXhNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3lNemNLSUNBZ0lDOHZJR05mWVhKeUlEMGdjMlZzWmk1amIyNXpaVzUwYzF0elpXNWtaWEpmWVdSa2NsMHVZMjl3ZVNncENpQWdJQ0JrYVdjZ01UUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMjl1YzJWdWRITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakl6T0FvZ0lDQWdMeThnWTE5aGNuSXVZWEJ3Wlc1a0tHNWxkMTlqYjI1elpXNTBMbU52Y0hrb0tTa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01ESUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpZV3hzYzNWaUlHUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU16a0tJQ0FnSUM4dklITmxiR1l1WTI5dWMyVnVkSE5iYzJWdVpHVnlYMkZrWkhKZElEMGdZMTloY25JdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDZ3BoY0hCeWIzWmxYM0psY1hWbGMzUmZZV1owWlhKZmFXWmZaV3h6WlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1Ua3lDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtRndjSEp2ZG1WZmNtVnhkV1Z6ZEY5bGJITmxYMkp2WkhsQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qSTBNUW9nSUNBZ0x5OGdZMTloY25JZ1BTQmhjbU0wTGtSNWJtRnRhV05CY25KaGVWdERiMjV6Wlc1MFhTaHVaWGRmWTI5dWMyVnVkQzVqYjNCNUtDa3BDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNREF3TVRBd01ESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3lORElLSUNBZ0lDOHZJSE5sYkdZdVkyOXVjMlZ1ZEhOYmMyVnVaR1Z5WDJGa1pISmRJRDBnWTE5aGNuSXVZMjl3ZVNncENpQWdJQ0JrYVdjZ01UUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmlJR0Z3Y0hKdmRtVmZjbVZ4ZFdWemRGOWhablJsY2w5cFpsOWxiSE5sUURFeENncGhjSEJ5YjNabFgzSmxjWFZsYzNSZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG95TURjS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2hoY25JdWJHVnVaM1JvS1RvS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQmhjSEJ5YjNabFgzSmxjWFZsYzNSZlptOXlYMmhsWVdSbGNrQXlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1OdmJuTmxiblJmYldGdVlXZGxjaTVqYjI1MGNtRmpkQzVEYjI1elpXNTBUV0Z1WVdkbGNpNXlaV3BsWTNSZmNtVnhkV1Z6ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxhbVZqZEY5eVpYRjFaWE4wT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJaUlLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG95TkRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG95TkRjS0lDQWdJQzh2SUdGeWNpQTlJSE5sYkdZdVlXTmpaWE56WDNKbGNYVmxjM1J6VzNObGJtUmxjbDloWkdSeVhTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnMk1UY3lOV1lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNalEyQ2lBZ0lDQXZMeUJ6Wlc1a1pYSmZZV1JrY2lBOUlHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3lORGNLSUNBZ0lDOHZJR0Z5Y2lBOUlITmxiR1l1WVdOalpYTnpYM0psY1hWbGMzUnpXM05sYm1SbGNsOWhaR1J5WFM1amIzQjVLQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWTJObGMzTmZjbVZ4ZFdWemRITWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakkwTnkweU5EZ0tJQ0FnSUM4dklHRnljaUE5SUhObGJHWXVZV05qWlhOelgzSmxjWFZsYzNSelczTmxibVJsY2w5aFpHUnlYUzVqYjNCNUtDa0tJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoaGNuSXViR1Z1WjNSb0tUb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNalE0Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9ZWEp5TG14bGJtZDBhQ2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LY21WcVpXTjBYM0psY1hWbGMzUmZabTl5WDJobFlXUmxja0F5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG95TkRnS0lDQWdJQzh2SUdadmNpQnBJR2x1SUhWeVlXNW5aU2hoY25JdWJHVnVaM1JvS1RvS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRHdLSUNBZ0lHSjZJSEpsYW1WamRGOXlaWEYxWlhOMFgyRm1kR1Z5WDJadmNrQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5dFlXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qSTBPUW9nSUNBZ0x5OGdjbVZ4SUQwZ1lYSnlXMmxkTG1OdmNIa29LUW9nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0oxY25rZ01UQUtJQ0FnSUdScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV5Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdScFp5QXhDaUFnSUNBdElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaR2xuSURRS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURVS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCaWRYSjVJREV3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakkwT1MweU5UQUtJQ0FnSUM4dklISmxjU0E5SUdGeWNsdHBYUzVqYjNCNUtDa0tJQ0FnSUM4dklHbG1JSEpsY1M1cFpDQTlQU0J5WlhGMVpYTjBYMmxrSUdGdVpDQnlaWEV1YVhOZmNHVnVaR2x1Wnk1dVlYUnBkbVU2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EzQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG95TlRBS0lDQWdJQzh2SUdsbUlISmxjUzVwWkNBOVBTQnlaWEYxWlhOMFgybGtJR0Z1WkNCeVpYRXVhWE5mY0dWdVpHbHVaeTV1WVhScGRtVTZDaUFnSUNCa2FXY2dOUW9nSUNBZ1lqMDlDaUFnSUNCaWVpQnlaV3BsWTNSZmNtVnhkV1Z6ZEY5aFpuUmxjbDlwWmw5bGJITmxRRFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNalE1TFRJMU1Bb2dJQ0FnTHk4Z2NtVnhJRDBnWVhKeVcybGRMbU52Y0hrb0tRb2dJQ0FnTHk4Z2FXWWdjbVZ4TG1sa0lEMDlJSEpsY1hWbGMzUmZhV1FnWVc1a0lISmxjUzVwYzE5d1pXNWthVzVuTG01aGRHbDJaVG9LSUNBZ0lHUnBaeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUhCMWMyaHBiblFnTlRJS0lDQWdJQ3NLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU5UQUtJQ0FnSUM4dklHbG1JSEpsY1M1cFpDQTlQU0J5WlhGMVpYTjBYMmxrSUdGdVpDQnlaWEV1YVhOZmNHVnVaR2x1Wnk1dVlYUnBkbVU2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lub2djbVZxWldOMFgzSmxjWFZsYzNSZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXRZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakkxTVFvZ0lDQWdMeThnY21WeExtbHpYM0JsYm1ScGJtY2dQU0JoY21NMExrSnZiMndvUm1Gc2MyVXBDaUFnSUNCa2FXY2dPQW9nSUNBZ2NIVnphR2x1ZENBME1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J6WlhSaWFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDIxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1qVXlDaUFnSUNBdkx5QmhjbkpiYVYwZ1BTQnlaWEV1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmthV2NnTVRBS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pHbG5JRFFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJrZVc1aGJXbGpYMkZ5Y21GNVgzSmxjR3hoWTJWZlpIbHVZVzFwWTE5bGJHVnRaVzUwQ2lBZ0lDQmlkWEo1SURNS0NuSmxhbVZqZEY5eVpYRjFaWE4wWDJGbWRHVnlYMlp2Y2tBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYldGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU5UUUtJQ0FnSUM4dklITmxiR1l1WVdOalpYTnpYM0psY1hWbGMzUnpXM05sYm1SbGNsOWhaR1J5WFNBOUlHRnljaTVqYjNCNUtDa0tJQ0FnSUdScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMjFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TWpRMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25KbGFtVmpkRjl5WlhGMVpYTjBYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUdScFp5QTJDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSWdjbVZxWldOMFgzSmxjWFZsYzNSZlptOXlYMmhsWVdSbGNrQXlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBSUJDQ1lMQVFBQ1kxOEJnQUFDQUFJRFlYSmZDM0psY1Y5amIzVnVkR1Z5QkFBQkFBSUlBQVpGVWtGVFJVUUVGUjk4ZFFJQVZ6RVlRQUFFSndZaVp6RWJRUUJWTVJrVVJERVlSSUlLQlB2WFlGUUV2djFqYndSdlQ2clNCS1I5dkE4RVRDaWxyQVJEUmlmcEJOaE42OUFFWUNtcTJnVGtwTDJiQlB1SkJpazJHZ0NPQ2dFT0FjUUNOd01SQXlZRC93UitCUEFGblFjSUFERVpGREVZRkJCRGlnUUJLMG1ML2lNTGkvd2pDeUtMQklzRERFRUFISXY5aXdSSlRnSlppd0lJRmxjR0Fvc0JURkNNQVNNSWpBUkMvOXlML1JXTUFDS01CSXNFaXdJTVFRQWNpLytMQkVsT0FsbUxBQWdXVndZQ2l3Rk1VSXdCSXdpTUJFTC8zSXY4aS80SUZsY0dBb3NCVUl2OWl3T0xBRkpRaS84VmkvK0xBazhDVWxDTUFJbUtBd0dML1ZFQUFra1hpLzFYQWdDTC95TUxTd0ZNV1l2L0pBZ2pDMHNDU3dGWlN3TVZTd1dML3dra0NVc0JUd05QQWsxSlN3UUpUZ2FML2hWT0Jrc0VJazhGVW92K1VFOEVUd0pQQTFKUVRnSk1Jd3RNaXdXTEJBeEJBQ0NMQTBtTEJVbE9BMW1MQWdpTEFRa1dWd1lDU3dKTVhZd0RJd2lNQlVMLzJJc0Fpd05RakFDSk5ob0JTUldCSUJKRU5ob0NTU0paSXdoTEFSVkpUd0lTUkRZYUEwa2lXU01JU3dFVlNVOENFa1EyR2dSSklsa2pDRXNCRlJKRU5ob0ZTUlVsRWtReEFESUhUd0lYU3dFSVRCWk1Ga3NDVHdsUUp3cFFnVmRQQ0FoSkZsY0dBazhDVEZCTVR3WUlGbGNHQWxCUEFsQk1VQ3BRVHdSUVR3TlFUd0pRVENsTVVFbE9BcjFGQVVFQUlFc0JTYjVFU1NKWlRGY0NBQ2NFVHdSUVRnSWtUd09JL2xwTEFieEl2eVJESndkTVVFc0JTYnhJVEw5Qy8vQTJHZ0ZKRlNVU1JDa3hBRkJKdmtSUEFoZExBVmNDQUVzQ0lsbExBaU1MU3dKTVdVc0RKQWhMQWtzQkNVc0VGVThDSXd0TEJVeFpUd0pOVHdOT0FsSWpTd01MSXdoTEJVd2p1aGVCV0FoTEJVd2t1aUpUS0NKUEFsUWlVMFNCc0FVaVZFc0NUd0lNUkV5SS9sbExBYnhJdnlSRE5ob0JTUlVsRWtRcE1RQlFTYjVFVHdJWFN3RlhBZ0JMQWlKWlN3SWpDMHNDVEZsTEF5UUlTd0pMQVFsTEJCVlBBaU1MU3dWTVdVOENUVThEVGdKU2diRUZKRlNCc0FVaVZFbUJRRmxMQVNKTEFsZ25DRkJMQW9GQ1dVc0RGVXNFU3dKUEFsSlBBa3hRU3dGUEF3bFBBaVVJU3dFSkZsY0dBazhDVEZ4Q1R3S0JSRmtsQ0U4Q0NSWlhCZ0pjUkVtQlFsbExBU0pMQWxnbkNGQkxBb0ZFV1VzREZVOEVTd0pQQWxKUEFreFFTd0ZQQXdsUEFpVUlUQWtXVndZQ1hFUkpnVVJaSWt4WUp3aFFTd0pQQWd4RVRJajlmMHNCdkVpL0pFTTJHZ0ZKRllFZ0VrUXBURkMrUkNjSlRGQ3dKRU1pTmhvQlNSV0JJQkpFTmhvQ1NSVWxFa1EyR2dOSlRnTkpJbGtqQ0V3VkVrUXBUd0pRU1U0Q1NiNU1UZ05FVEJkSlRnSXlCMDRDSXdzakNFbE9Ba3NCVENPNkY0RllDQ1M2SWxNb0lrOENWQ0pUUVFDQVN3UkpTd0lqdWhlQldBZ2t1aVJUS0NKUEFsUWlVMEFBWjBzRVNVc0NJN29YZ1ZBSUpib1hTd0lQUVFCVFN3TkpWd0lBVENKWlN3UkpJd3RMQTB4WlRDUUlUd0pMQVFsTEF4VlBBaU1MU3dSTVdVOENUVkpKZ1VSWlN3RVZVa2xGQ0lBRkFBTkJiR3dTUVFBSUtpY0pURkN3SkVOTEJrc0dFa0VBQkNwQy8rMG9Rdi9wTmhvQlNSVWxFa1EyR2dKSkZTVVNSQ2t4QUZCSnZrUlBBeGRMQVZjQ0FFc0NJbGxMQWlNTFN3Sk1XVXNESkFoTEFrc0JDVXNFRlU4Q0l3dExCVXhaVHdKTlR3Tk9BbElqU3dNTEl3aExCVXdqdWhlQldBaExCVXdrdWlKVEtDSlBBbFFpVTBReUIwOEdGd2dXWEU1TEFrOENERVJNaVB3U1N3RzhTTDhrUXpZYUFVa1ZnU0FTUkRZYUFra2lXU01JU3dFVkVrUWlKd1psUkNRSUp3WkxBV2NXTVFBeUJ4Wk9BbENBQWdBelVFeFFLbEJNVUV3bkJVeFFTVTRDdlVVQlFRQWdTd0ZKdmtSSklsbE1Wd0lBSndSUEJGQk9BaVJQQTRqN0xrc0J2RWkvSkVNbkIweFFTd0ZKdkVoTXYwTC84Q0pKSzBjQ05ob0JTUldCSUJKRWdBSUFBRXduQlV4UVNiMUZBVUVBaDBjQ3ZreEZDVVFpSTdvWFJRUWlSUU5MQWtzRURFRUFiMHNHU1ZjQ0FFd2lXVXNFU1NNTFN3Tk1XVXNCSkFoSlJRcFBBMHNCQ1VzRUZVOENJd3RMQlV4WlR3Sk5Ud05PQWxKRkJ5TUxJd2hMQVVsUEFpTzZGNEUwQ0NTNklsTW9JazhDVkNKVFFRQVlTd0ZKSWxsTVZ3SUFKd1JMQ0ZCT0FpUlBBNGo2ZlVVQ1N3UkZBMEwvaVNjSlN3SlFzQ1JESWlzMkdnRkpGU1VTUkRZYUFrY0NJbGtqQ0V3VlNVOENFa1EyR2dOSEFpSlpJd2hNRlJKRU5ob0VTUlVsRWtReEFDY0ZNUUJRUndLK1RFNENSQ2hNSWt3aUk3b1hJa2xMQWd4QkFEb2pTd0VMSXdoSlJRNUxCa2xQQWlPNkZ5TUlKYnBMREtoQkFQdExCVWxMRGlPNkY0RTBDQ1M2SWxNb0lrOENWQ0pUUVFEaUtrVUVTVVVEU3dNaVUwUkxCRWxYQWdCTEFTSlpTd1ZKSXd0TEEweFpTd0VrQ0VzRFN3RUpTd1VWVHdJakMwc0dURmxQQWsxUEJFNENVb0dRQXlKVVN3RlBBd3hFVHdKTEFVOERpUG9kU3dkSnZFaE12eklIU3drWFN3RUlTd0pYQ0NCTEE0RW9XVXNFRlU4RlRnSlNUd01XVHdNV1N3cEpUZ1ZQQkZBbkNsQkxBeFdCVndoSkZsY0dBazhDVEZCTVN3OElGbGNHQWxCUEFsQk1VQ3BRVEZCTERGQkxDbEJNS1V4UVNVVVF2VVVCUVFBZ1N3NUp2a1JKSWxsTVZ3SUFKd1JQQkZCT0FpUlBBNGo1SGtzQnZFaS9KRU1uQjB4UVN3NUp2RWhNdjBMLzhFa2tDRVVCUXY3YklpdEhBallhQVVrVkpSSkVKd1V4QUZCSEFyNU1UZ0pFSWlPNkZ5SkpTd0lNUVFDRVN3SkpWd0lBVENKWlNVNENSUXBMQWtrakMwc0NURmxMQVNRSVNVVU1Ud1JMQVFsTEJCVlBBaU1MU3dWTVdVOENUVThEVGdKU1JRb2pDeU1JU1VVSFN3UkpUd0lqdWhjakNDVzZTd1dvUVFBOVN3TkpTd2NqdWhlQk5BZ2t1aUpUS0NKUEFsUWlVMEVBSkVzSWdaQURJbFJMQVVsT0Frc0tERVJMQkV4UEFvajQyMFVEU3dOSnZFaExBNzhrUTBzR1JRRkMvMlE9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
