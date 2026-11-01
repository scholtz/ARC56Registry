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

namespace Arc56.Generated.BGope025.meditrace.BatchRegistry_ad24a932
{


    public class BatchRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BatchRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetBatchReturn : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
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
                    var ret = new GetBatchReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
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

            public class GetBatchDetailsReturn : AVMObjectType
            {
                public byte[] Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public Algorand.Address Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public ulong Field5 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static GetBatchDetailsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetBatchDetailsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as GetBatchDetailsReturn);
                }
                public bool Equals(GetBatchDetailsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetBatchDetailsReturn left, GetBatchDetailsReturn right)
                {
                    return EqualityComparer<GetBatchDetailsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetBatchDetailsReturn left, GetBatchDetailsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetCustodyRecordReturn : AVMObjectType
            {
                public Algorand.Address Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public Algorand.Address Field2 { get; set; }

                public ulong Field3 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetCustodyRecordReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetCustodyRecordReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetCustodyRecordReturn);
                }
                public bool Equals(GetCustodyRecordReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetCustodyRecordReturn left, GetCustodyRecordReturn right)
                {
                    return EqualityComparer<GetCustodyRecordReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetCustodyRecordReturn left, GetCustodyRecordReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetBreachRecordReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public Algorand.Address Field3 { get; set; }

                public byte[] Field4 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
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

                public static GetBreachRecordReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetBreachRecordReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is Algorand.Address vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is byte[] vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetBreachRecordReturn);
                }
                public bool Equals(GetBreachRecordReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetBreachRecordReturn left, GetBreachRecordReturn right)
                {
                    return EqualityComparer<GetBreachRecordReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetBreachRecordReturn left, GetBreachRecordReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Called once at app creation. Deployer becomes admin.
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Grant a role bitmask to an account. Admin-only.
        ///</summary>
        /// <param name="role"> </param>
        /// <param name="account"> </param>
        public async Task GrantRole(ulong role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 241, 164, 117 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantRole_Transactions(ulong role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 241, 164, 117 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Revoke a role bitmask from an account. Admin-only.
        ///</summary>
        /// <param name="role"> </param>
        /// <param name="account"> </param>
        public async Task RevokeRole(ulong role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 138, 131, 168 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeRole_Transactions(ulong role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 138, 131, 168 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task GrantManufacturerRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 232, 130, 85 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantManufacturerRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 232, 130, 85 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task GrantDistributorRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 255, 48, 94 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantDistributorRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 255, 48, 94 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task GrantPharmacyRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 126, 147, 202 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantPharmacyRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 126, 147, 202 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task GrantTelemetryOracleRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 24, 126, 101 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantTelemetryOracleRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 24, 126, 101 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task RevokeManufacturerRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 79, 10, 94 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeManufacturerRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 79, 10, 94 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task RevokeDistributorRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 223, 157, 67 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeDistributorRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 223, 157, 67 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task RevokePharmacyRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 104, 242, 186 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokePharmacyRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 104, 242, 186 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task RevokeTelemetryOracleRole(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 245, 181, 150 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeTelemetryOracleRole_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 245, 181, 150 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check whether an account holds a specific role.
        ///</summary>
        /// <param name="role"> </param>
        /// <param name="account"> </param>
        public async Task<bool> HasRole(ulong role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 53, 240, 92 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HasRole_Transactions(ulong role, Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 53, 240, 92 };
            var roleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); roleAbi.From(role);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, roleAbi, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a new medicine batch. Only manufacturers or admins.
        ///</summary>
        /// <param name="drugName">Name of the drug (max 256 bytes). </param>
        public async Task<ulong> CreateBatch(string drugName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 152, 49, 67 };
            var drugNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); drugNameAbi.From(drugName);

            var result = await base.CallApp(new List<object> { abiHandle, drugNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateBatch_Transactions(string drugName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 152, 49, 67 };
            var drugNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); drugNameAbi.From(drugName);

            return await base.MakeTransactionList(new List<object> { abiHandle, drugNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Legacy/manual breach method retained for backend compatibility.
        ///Only admin, manufacturer, or oracle can flag a breach.
        ///</summary>
        /// <param name="batchId"> </param>
        public async Task FlagBreach(ulong batchId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 219, 86, 8 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);

            var result = await base.CallApp(new List<object> { abiHandle, batchIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FlagBreach_Transactions(ulong batchId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 219, 86, 8 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);

            return await base.MakeTransactionList(new List<object> { abiHandle, batchIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Records a signed sensor reading digest on-chain and auto-breaches
        ///if the temperature is outside the safe range [2.00 °C, 8.00 °C].
        ///
        ///
        ///Temperature is in hundredths of a degree (e.g. 450 = 4.50 °C).
        ///For the AVM, we pass temperature as uint64; values above a threshold
        ///(e.g.  SAFE_MAX) are treated as out of range. Negative temperatures
        ///should be encoded as very large uint64 values and will always breach.
        ///</summary>
        /// <param name="batchId">The batch to record against. </param>
        /// <param name="temperatureCenti">Temp in 1/100 °C (uint64 encoding). </param>
        /// <param name="observedAt">Sensor observation timestamp (unix seconds). </param>
        /// <param name="sensor">Sensor account address. </param>
        /// <param name="evidenceHash">keccak256 of the signed telemetry payload. </param>
        public async Task<bool> RecordTemperature(ulong batchId, ulong temperatureCenti, ulong observedAt, Algorand.Address sensor, byte[] evidenceHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 16, 127, 62 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);
            var temperatureCentiAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); temperatureCentiAbi.From(temperatureCenti);
            var observedAtAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); observedAtAbi.From(observedAt);
            var sensorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sensorAbi.From(sensor);
            var evidenceHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); evidenceHashAbi.From(evidenceHash);

            var result = await base.CallApp(new List<object> { abiHandle, batchIdAbi, temperatureCentiAbi, observedAtAbi, sensorAbi, evidenceHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RecordTemperature_Transactions(ulong batchId, ulong temperatureCenti, ulong observedAt, Algorand.Address sensor, byte[] evidenceHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 16, 127, 62 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);
            var temperatureCentiAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); temperatureCentiAbi.From(temperatureCenti);
            var observedAtAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); observedAtAbi.From(observedAt);
            var sensorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sensorAbi.From(sensor);
            var evidenceHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); evidenceHashAbi.From(evidenceHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, batchIdAbi, temperatureCentiAbi, observedAtAbi, sensorAbi, evidenceHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer batch custody to a new custodian.
        ///Allowed for: current custodian, admin, manufacturer, distributor, pharmacy.
        ///</summary>
        /// <param name="batchId"> </param>
        /// <param name="newCustodian"> </param>
        public async Task TransferBatch(ulong batchId, Algorand.Address newCustodian, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 141, 166, 192 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);
            var newCustodianAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newCustodianAbi.From(newCustodian);

            var result = await base.CallApp(new List<object> { abiHandle, batchIdAbi, newCustodianAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferBatch_Transactions(ulong batchId, Algorand.Address newCustodian, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 141, 166, 192 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);
            var newCustodianAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newCustodianAbi.From(newCustodian);

            return await base.MakeTransactionList(new List<object> { abiHandle, batchIdAbi, newCustodianAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Pharmacy confirms final delivery of a batch.
        ///Only a pharmacy-role holder who is the current custodian (or admin).
        ///</summary>
        /// <param name="batchId"> </param>
        public async Task ConfirmDelivery(ulong batchId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 206, 76, 116 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);

            var result = await base.CallApp(new List<object> { abiHandle, batchIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ConfirmDelivery_Transactions(ulong batchId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 206, 76, 116 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);

            return await base.MakeTransactionList(new List<object> { abiHandle, batchIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get core batch info (drug name, manufacturer, state, created timestamp).
        ///</summary>
        /// <param name="batchId"> </param>
        public async Task<Structs.GetBatchReturn> GetBatch(ulong batchId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 162, 48, 5 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);

            var result = await base.CallApp(new List<object> { abiHandle, batchIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetBatchReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBatch_Transactions(ulong batchId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 162, 48, 5 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);

            return await base.MakeTransactionList(new List<object> { abiHandle, batchIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get full batch details.
        ///</summary>
        /// <param name="batchId"> </param>
        public async Task<Structs.GetBatchDetailsReturn> GetBatchDetails(ulong batchId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 204, 106, 241 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);

            var result = await base.CallApp(new List<object> { abiHandle, batchIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetBatchDetailsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBatchDetails_Transactions(ulong batchId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 204, 106, 241 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);

            return await base.MakeTransactionList(new List<object> { abiHandle, batchIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get a single custody record by batch ID and index.
        ///</summary>
        /// <param name="batchId"> </param>
        /// <param name="index"> </param>
        public async Task<Structs.GetCustodyRecordReturn> GetCustodyRecord(ulong batchId, ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 158, 187, 167 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            var result = await base.CallApp(new List<object> { abiHandle, batchIdAbi, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetCustodyRecordReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetCustodyRecord_Transactions(ulong batchId, ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 158, 187, 167 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            return await base.MakeTransactionList(new List<object> { abiHandle, batchIdAbi, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get a single breach record by batch ID and index.
        ///</summary>
        /// <param name="batchId"> </param>
        /// <param name="index"> </param>
        public async Task<Structs.GetBreachRecordReturn> GetBreachRecord(ulong batchId, ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 104, 118, 186 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            var result = await base.CallApp(new List<object> { abiHandle, batchIdAbi, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetBreachRecordReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBreachRecord_Transactions(ulong batchId, ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 104, 118, 186 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            return await base.MakeTransactionList(new List<object> { abiHandle, batchIdAbi, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the number of custody transfers for a batch.
        ///</summary>
        /// <param name="batchId"> </param>
        public async Task<ulong> GetCustodyCount(ulong batchId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 123, 148, 145 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);

            var result = await base.CallApp(new List<object> { abiHandle, batchIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCustodyCount_Transactions(ulong batchId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 123, 148, 145 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);

            return await base.MakeTransactionList(new List<object> { abiHandle, batchIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the number of breach records for a batch.
        ///</summary>
        /// <param name="batchId"> </param>
        public async Task<ulong> GetBreachCount(ulong batchId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 90, 134, 67 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);

            var result = await base.CallApp(new List<object> { abiHandle, batchIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBreachCount_Transactions(ulong batchId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 90, 134, 67 };
            var batchIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); batchIdAbi.From(batchId);

            return await base.MakeTransactionList(new List<object> { abiHandle, batchIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJCYXRjaFJlZ2lzdHJ5IiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRCYXRjaFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In1dLCJHZXRCYXRjaERldGFpbHNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0Q3VzdG9keVJlY29yZFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV0sIkdldEJyZWFjaFJlY29yZFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6ImJ5dGVbMzJdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6IkNhbGxlZCBvbmNlIGF0IGFwcCBjcmVhdGlvbi4gRGVwbG95ZXIgYmVjb21lcyBhZG1pbi4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImdyYW50Um9sZSIsImRlc2MiOiJHcmFudCBhIHJvbGUgYml0bWFzayB0byBhbiBhY2NvdW50LiBBZG1pbi1vbmx5LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoicmV2b2tlUm9sZSIsImRlc2MiOiJSZXZva2UgYSByb2xlIGJpdG1hc2sgZnJvbSBhbiBhY2NvdW50LiBBZG1pbi1vbmx5LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyb2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZ3JhbnRNYW51ZmFjdHVyZXJSb2xlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJncmFudERpc3RyaWJ1dG9yUm9sZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZ3JhbnRQaGFybWFjeVJvbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImdyYW50VGVsZW1ldHJ5T3JhY2xlUm9sZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoicmV2b2tlTWFudWZhY3R1cmVyUm9sZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoicmV2b2tlRGlzdHJpYnV0b3JSb2xlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJyZXZva2VQaGFybWFjeVJvbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InJldm9rZVRlbGVtZXRyeU9yYWNsZVJvbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6Imhhc1JvbGUiLCJkZXNjIjoiQ2hlY2sgd2hldGhlciBhbiBhY2NvdW50IGhvbGRzIGEgc3BlY2lmaWMgcm9sZS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm9sZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNyZWF0ZUJhdGNoIiwiZGVzYyI6IkNyZWF0ZSBhIG5ldyBtZWRpY2luZSBiYXRjaC4gT25seSBtYW51ZmFjdHVyZXJzIG9yIGFkbWlucy4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZHJ1Z05hbWUiLCJkZXNjIjoiTmFtZSBvZiB0aGUgZHJ1ZyAobWF4IDI1NiBieXRlcykuIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6ImJhdGNoSWQgLSBUaGUgYXNzaWduZWQgYmF0Y2ggSUQuIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImZsYWdCcmVhY2giLCJkZXNjIjoiTGVnYWN5L21hbnVhbCBicmVhY2ggbWV0aG9kIHJldGFpbmVkIGZvciBiYWNrZW5kIGNvbXBhdGliaWxpdHkuXG5Pbmx5IGFkbWluLCBtYW51ZmFjdHVyZXIsIG9yIG9yYWNsZSBjYW4gZmxhZyBhIGJyZWFjaC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmF0Y2hJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoicmVjb3JkVGVtcGVyYXR1cmUiLCJkZXNjIjoiUmVjb3JkcyBhIHNpZ25lZCBzZW5zb3IgcmVhZGluZyBkaWdlc3Qgb24tY2hhaW4gYW5kIGF1dG8tYnJlYWNoZXNcbmlmIHRoZSB0ZW1wZXJhdHVyZSBpcyBvdXRzaWRlIHRoZSBzYWZlIHJhbmdlIFsyLjAwIMKwQywgOC4wMCDCsENdLlxuXG5cblRlbXBlcmF0dXJlIGlzIGluIGh1bmRyZWR0aHMgb2YgYSBkZWdyZWUgKGUuZy4gNDUwID0gNC41MCDCsEMpLlxuRm9yIHRoZSBBVk0sIHdlIHBhc3MgdGVtcGVyYXR1cmUgYXMgdWludDY0OyB2YWx1ZXMgYWJvdmUgYSB0aHJlc2hvbGRcbihlLmcuICBTQUZFX01BWCkgYXJlIHRyZWF0ZWQgYXMgb3V0IG9mIHJhbmdlLiBOZWdhdGl2ZSB0ZW1wZXJhdHVyZXNcbnNob3VsZCBiZSBlbmNvZGVkIGFzIHZlcnkgbGFyZ2UgdWludDY0IHZhbHVlcyBhbmQgd2lsbCBhbHdheXMgYnJlYWNoLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYXRjaElkIiwiZGVzYyI6IlRoZSBiYXRjaCB0byByZWNvcmQgYWdhaW5zdC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRlbXBlcmF0dXJlQ2VudGkiLCJkZXNjIjoiVGVtcCBpbiAxLzEwMCDCsEMgKHVpbnQ2NCBlbmNvZGluZykuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvYnNlcnZlZEF0IiwiZGVzYyI6IlNlbnNvciBvYnNlcnZhdGlvbiB0aW1lc3RhbXAgKHVuaXggc2Vjb25kcykuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2Vuc29yIiwiZGVzYyI6IlNlbnNvciBhY2NvdW50IGFkZHJlc3MuIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2aWRlbmNlSGFzaCIsImRlc2MiOiJrZWNjYWsyNTYgb2YgdGhlIHNpZ25lZCB0ZWxlbWV0cnkgcGF5bG9hZC4iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6ImlzU2FmZSAtIFdoZXRoZXIgdGhlIHJlYWRpbmcgaXMgd2l0aGluIHRoZSBzYWZlIHJhbmdlLiJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJ0cmFuc2ZlckJhdGNoIiwiZGVzYyI6IlRyYW5zZmVyIGJhdGNoIGN1c3RvZHkgdG8gYSBuZXcgY3VzdG9kaWFuLlxuQWxsb3dlZCBmb3I6IGN1cnJlbnQgY3VzdG9kaWFuLCBhZG1pbiwgbWFudWZhY3R1cmVyLCBkaXN0cmlidXRvciwgcGhhcm1hY3kuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJhdGNoSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdDdXN0b2RpYW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNvbmZpcm1EZWxpdmVyeSIsImRlc2MiOiJQaGFybWFjeSBjb25maXJtcyBmaW5hbCBkZWxpdmVyeSBvZiBhIGJhdGNoLlxuT25seSBhIHBoYXJtYWN5LXJvbGUgaG9sZGVyIHdobyBpcyB0aGUgY3VycmVudCBjdXN0b2RpYW4gKG9yIGFkbWluKS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmF0Y2hJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZ2V0QmF0Y2giLCJkZXNjIjoiR2V0IGNvcmUgYmF0Y2ggaW5mbyAoZHJ1ZyBuYW1lLCBtYW51ZmFjdHVyZXIsIHN0YXRlLCBjcmVhdGVkIHRpbWVzdGFtcCkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJhdGNoSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbXSxhZGRyZXNzLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0QmF0Y2hSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZ2V0QmF0Y2hEZXRhaWxzIiwiZGVzYyI6IkdldCBmdWxsIGJhdGNoIGRldGFpbHMuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJhdGNoSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbXSxhZGRyZXNzLGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0QmF0Y2hEZXRhaWxzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImdldEN1c3RvZHlSZWNvcmQiLCJkZXNjIjoiR2V0IGEgc2luZ2xlIGN1c3RvZHkgcmVjb3JkIGJ5IGJhdGNoIElEIGFuZCBpbmRleC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmF0Y2hJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyxhZGRyZXNzLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRDdXN0b2R5UmVjb3JkUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImdldEJyZWFjaFJlY29yZCIsImRlc2MiOiJHZXQgYSBzaW5nbGUgYnJlYWNoIHJlY29yZCBieSBiYXRjaCBJRCBhbmQgaW5kZXguIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJhdGNoSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCxhZGRyZXNzLGJ5dGVbMzJdKSIsInN0cnVjdCI6IkdldEJyZWFjaFJlY29yZFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJnZXRDdXN0b2R5Q291bnQiLCJkZXNjIjoiR2V0IHRoZSBudW1iZXIgb2YgY3VzdG9keSB0cmFuc2ZlcnMgZm9yIGEgYmF0Y2guIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJhdGNoSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZ2V0QnJlYWNoQ291bnQiLCJkZXNjIjoiR2V0IHRoZSBudW1iZXIgb2YgYnJlYWNoIHJlY29yZHMgZm9yIGEgYmF0Y2guIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJhdGNoSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDbWx1ZEdOaWJHOWpheUF4SURNeUlEQWdNaUF4WHpBd01GOHdNREFnT0NBeE5pQTBDbUo1ZEdWallteHZZMnNnTUhnZ01IZzNNaUF3ZURFMU1XWTNZemMxSURCNE5qSTNNeUF3ZURZeU5qTWdNSGcyTXpZeklEQjROemcyTXlBd2VEWmxOalUzT0RjME5EazJOQ0F3ZURZeU56VWdNSGd3TURBd01EQXdNREF3TURBd01EQXdJREI0TmpFMk5EWmtOamsyWlNBd2VEWXlObVVnTUhnMk1qWmtJREI0TmpJM05DQXdlRGM0TnpRZ01IZzNPRFptSURCNE56ZzNNaUF3ZURjNE56TWdNSGczT0RZMUlEQjROak0yTmlBd2VEWXpOelFnTUhnMk16WXhJREI0TmpNM015QXdlREF3Q2dvdkx5QlVhR2x6SUZSRlFVd2dkMkZ6SUdkbGJtVnlZWFJsWkNCaWVTQlVSVUZNVTJOeWFYQjBJSFl3TGpFd05pNHpDaTh2SUdoMGRIQnpPaTh2WjJsMGFIVmlMbU52YlM5aGJHZHZjbUZ1WkdadmRXNWtZWFJwYjI0dlZFVkJURk5qY21sd2RBb0tMeThnVkdocGN5QmpiMjUwY21GamRDQnBjeUJqYjIxd2JHbGhiblFnZDJsMGFDQmhibVF2YjNJZ2FXMXdiR1Z0Wlc1MGN5QjBhR1VnWm05c2JHOTNhVzVuSUVGU1EzTTZJRnNnUVZKRE5DQmRDZ292THlCVWFHVWdabTlzYkc5M2FXNW5JSFJsYmlCc2FXNWxjeUJ2WmlCVVJVRk1JR2hoYm1Sc1pTQnBibWwwYVdGc0lIQnliMmR5WVcwZ1pteHZkd292THlCVWFHbHpJSEJoZEhSbGNtNGdhWE1nZFhObFpDQjBieUJ0WVd0bElHbDBJR1ZoYzNrZ1ptOXlJR0Z1ZVc5dVpTQjBieUJ3WVhKelpTQjBhR1VnYzNSaGNuUWdiMllnZEdobElIQnliMmR5WVcwZ1lXNWtJR1JsZEdWeWJXbHVaU0JwWmlCaElITndaV05wWm1saklHRmpkR2x2YmlCcGN5QmhiR3h2ZDJWa0NpOHZJRWhsY21Vc0lHRmpkR2x2YmlCeVpXWmxjbk1nZEc4Z2RHaGxJRTl1UTI5dGNHeGxkR1VnYVc0Z1kyOXRZbWx1WVhScGIyNGdkMmwwYUNCM2FHVjBhR1Z5SUhSb1pTQmhjSEFnYVhNZ1ltVnBibWNnWTNKbFlYUmxaQ0J2Y2lCallXeHNaV1FLTHk4Z1JYWmxjbmtnY0c5emMybGliR1VnWVdOMGFXOXVJR1p2Y2lCMGFHbHpJR052Ym5SeVlXTjBJR2x6SUhKbGNISmxjMlZ1ZEdWa0lHbHVJSFJvWlNCemQybDBZMmdnYzNSaGRHVnRaVzUwQ2k4dklFbG1JSFJvWlNCaFkzUnBiMjRnYVhNZ2JtOTBJR2x0Y0d4bGJXVnVkR1ZrSUdsdUlIUm9aU0JqYjI1MGNtRmpkQ3dnYVhSeklISmxjM0JsWTNScGRtVWdZbkpoYm1Ob0lIZHBiR3dnWW1VZ0lpcE9UMVJmU1UxUVRFVk5SVTVVUlVRaUlIZG9hV05vSUdwMWMzUWdZMjl1ZEdGcGJuTWdJbVZ5Y2lJS2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lRcHdkWE5vYVc1MElEWUtLZ3AwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaXNLYzNkcGRHTm9JQ3BqWVd4c1gwNXZUM0FnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcGpjbVZoZEdWZlRtOVBjQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRS0NpcE9UMVJmU1UxUVRFVk5SVTVVUlVRNkNna3ZMeUJVYUdVZ2NtVnhkV1Z6ZEdWa0lHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hwY3lCamIyNTBjbUZqZEM0Z1FYSmxJSGx2ZFNCMWMybHVaeUIwYUdVZ1kyOXljbVZqZENCUGJrTnZiWEJzWlhSbFB5QkVhV1FnZVc5MUlITmxkQ0I1YjNWeUlHRndjQ0JKUkQ4S0NXVnljZ29LTHk4Z1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b0tYWnZhV1FLS21GaWFWOXliM1YwWlY5amNtVmhkR1ZCY0hCc2FXTmhkR2x2YmpvS0NTOHZJR1Y0WldOMWRHVWdZM0psWVhSbFFYQndiR2xqWVhScGIyNG9LWFp2YVdRS0NXTmhiR3h6ZFdJZ1kzSmxZWFJsUVhCd2JHbGpZWFJwYjI0S0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaTh2SUdOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S0NrNklIWnZhV1FLTHk4S0x5OGdRMkZzYkdWa0lHOXVZMlVnWVhRZ1lYQndJR055WldGMGFXOXVMaUJFWlhCc2IzbGxjaUJpWldOdmJXVnpJR0ZrYldsdUxncGpjbVZoZEdWQmNIQnNhV05oZEdsdmJqb0tDWEJ5YjNSdklEQWdNQW9LQ1M4dklHTnZiblJ5WVdOMGMxeENZWFJqYUZKbFoybHpkSEo1TG5Sek9qRXhNQW9KTHk4Z2RHaHBjeTVoWkcxcGJpNTJZV3gxWlNBOUlIUm9hWE11ZEhodUxuTmxibVJsY2dvSllubDBaV01nTVRBZ0x5OGdJQ0poWkcxcGJpSUtDWFI0YmlCVFpXNWtaWElLQ1dGd2NGOW5iRzlpWVd4ZmNIVjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhFSmhkR05vVW1WbmFYTjBjbmt1ZEhNNk1URXhDZ2t2THlCMGFHbHpMbTVsZUhSQ1lYUmphRWxrTG5aaGJIVmxJRDBnTVFvSllubDBaV01nTnlBdkx5QWdJbTVsZUhSSlpDSUtDV2x1ZEdNZ01DQXZMeUF4Q2dsaGNIQmZaMnh2WW1Gc1gzQjFkQW9KY21WMGMzVmlDZ292THlCaGMzTmxjblJCWkcxcGJpZ3BPaUIyYjJsa0NtRnpjMlZ5ZEVGa2JXbHVPZ29KY0hKdmRHOGdNQ0F3Q2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUpoZEdOb1VtVm5hWE4wY25rdWRITTZNVEU1Q2drdkx5QmhjM05sY25Rb0Nna3ZMeUFnSUNBZ0lDQjBhR2x6TG5SNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVlXUnRhVzR1ZG1Gc2RXVWdmSHdLQ1M4dklDQWdJQ0FnSUNBZ0tIUm9hWE11Y205c1pYTW9kR2hwY3k1MGVHNHVjMlZ1WkdWeUtTNWxlR2x6ZEhNZ0ppWUtDUzh2SUNBZ0lDQWdJQ0FnSUNBb2RHaHBjeTV5YjJ4bGN5aDBhR2x6TG5SNGJpNXpaVzVrWlhJcExuWmhiSFZsSUNZZ1FVUk5TVTVmUWtsVUtTQWhQVDBnTUNrc0Nna3ZMeUFnSUNBZ0lDQW5RMkZzYkdWeUlHbHpJRzV2ZENCaGJpQmhaRzFwYmljS0NTOHZJQ0FnSUNBcENnbDBlRzRnVTJWdVpHVnlDZ2xpZVhSbFl5QXhNQ0F2THlBZ0ltRmtiV2x1SWdvSllYQndYMmRzYjJKaGJGOW5aWFFLQ1QwOUNnbGtkWEFLQ1dKdWVpQXFjMnRwY0Y5dmNqQUtDV0o1ZEdWaklERWdMeThnSUNKeUlnb0pkSGh1SUZObGJtUmxjZ29KWTI5dVkyRjBDZ2xpYjNoZmJHVnVDZ2x6ZDJGd0NnbHdiM0FLQ1dSMWNBb0pZbm9nS25OcmFYQmZZVzVrTUFvSllubDBaV01nTVNBdkx5QWdJbklpQ2dsMGVHNGdVMlZ1WkdWeUNnbGpiMjVqWVhRS0NXSnZlRjluWlhRS0Nna3ZMeUJpYjNnZ2RtRnNkV1VnWkc5bGN5QnViM1FnWlhocGMzUTZJSFJvYVhNdWNtOXNaWE1vZEdocGN5NTBlRzR1YzJWdVpHVnlLUzUyWVd4MVpRb0pZWE56WlhKMENnbGlkRzlwQ2dscGJuUmpJREFnTHk4Z01Rb0pKZ29KYVc1MFl5QXlJQzh2SURBS0NTRTlDZ2ttSmdvS0tuTnJhWEJmWVc1a01Eb0tDWHg4Q2dvcWMydHBjRjl2Y2pBNkNna3ZMeUJEWVd4c1pYSWdhWE1nYm05MElHRnVJR0ZrYldsdUNnbGhjM05sY25RS0NYSmxkSE4xWWdvS0x5OGdZMkZzYkdWeVNHRnpVbTlzWlNoeWIyeGxRbWwwT2lCMWFXNTBOalFwT2lCaWIyOXNaV0Z1Q21OaGJHeGxja2hoYzFKdmJHVTZDZ2x3Y205MGJ5QXhJREVLQ2drdkx5QXFhV1l3WDJOdmJtUnBkR2x2YmdvSkx5OGdZMjl1ZEhKaFkzUnpYRUpoZEdOb1VtVm5hWE4wY25rdWRITTZNVEk0Q2drdkx5QjBhR2x6TG5SNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVlXUnRhVzR1ZG1Gc2RXVUtDWFI0YmlCVFpXNWtaWElLQ1dKNWRHVmpJREV3SUM4dklDQWlZV1J0YVc0aUNnbGhjSEJmWjJ4dlltRnNYMmRsZEFvSlBUMEtDV0o2SUNwcFpqQmZaVzVrQ2dvSkx5OGdLbWxtTUY5amIyNXpaWEYxWlc1MENna3ZMeUJqYjI1MGNtRmpkSE5jUW1GMFkyaFNaV2RwYzNSeWVTNTBjem94TWpnS0NTOHZJSEpsZEhWeWJpQjBjblZsT3dvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhOMVlnb0tLbWxtTUY5bGJtUTZDZ2t2THlBcWFXWXhYMk52Ym1ScGRHbHZiZ29KTHk4Z1kyOXVkSEpoWTNSelhFSmhkR05vVW1WbmFYTjBjbmt1ZEhNNk1USTVDZ2t2THlBaGRHaHBjeTV5YjJ4bGN5aDBhR2x6TG5SNGJpNXpaVzVrWlhJcExtVjRhWE4wY3dvSllubDBaV01nTVNBdkx5QWdJbklpQ2dsMGVHNGdVMlZ1WkdWeUNnbGpiMjVqWVhRS0NXSnZlRjlzWlc0S0NYTjNZWEFLQ1hCdmNBb0pJUW9KWW5vZ0ttbG1NVjlsYm1RS0Nna3ZMeUFxYVdZeFgyTnZibk5sY1hWbGJuUUtDUzh2SUdOdmJuUnlZV04wYzF4Q1lYUmphRkpsWjJsemRISjVMblJ6T2pFeU9Rb0pMeThnY21WMGRYSnVJR1poYkhObE93b0phVzUwWXlBeUlDOHZJREFLQ1hKbGRITjFZZ29LS21sbU1WOWxibVE2Q2drdkx5QmpiMjUwY21GamRITmNRbUYwWTJoU1pXZHBjM1J5ZVM1MGN6b3hNekFLQ1M4dklISmxkSFZ5YmlBb2RHaHBjeTV5YjJ4bGN5aDBhR2x6TG5SNGJpNXpaVzVrWlhJcExuWmhiSFZsSUNZZ2NtOXNaVUpwZENrZ0lUMDlJREE3Q2dsaWVYUmxZeUF4SUM4dklDQWljaUlLQ1hSNGJpQlRaVzVrWlhJS0NXTnZibU5oZEFvSlltOTRYMmRsZEFvS0NTOHZJR0p2ZUNCMllXeDFaU0JrYjJWeklHNXZkQ0JsZUdsemREb2dkR2hwY3k1eWIyeGxjeWgwYUdsekxuUjRiaTV6Wlc1a1pYSXBMblpoYkhWbENnbGhjM05sY25RS0NXSjBiMmtLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJ5YjJ4bFFtbDBPaUIxYVc1ME5qUUtDU1lLQ1dsdWRHTWdNaUF2THlBd0Nna2hQUW9KY21WMGMzVmlDZ292THlCaFpHUnlaWE56U0dGelVtOXNaU2hoWTJOdmRXNTBPaUJCWkdSeVpYTnpMQ0J5YjJ4bFFtbDBPaUIxYVc1ME5qUXBPaUJpYjI5c1pXRnVDbUZrWkhKbGMzTklZWE5TYjJ4bE9nb0pjSEp2ZEc4Z01pQXhDZ29KTHk4Z0ttbG1NbDlqYjI1a2FYUnBiMjRLQ1M4dklHTnZiblJ5WVdOMGMxeENZWFJqYUZKbFoybHpkSEo1TG5Sek9qRXpOQW9KTHk4Z0lYUm9hWE11Y205c1pYTW9ZV05qYjNWdWRDa3VaWGhwYzNSekNnbGllWFJsWXlBeElDOHZJQ0FpY2lJS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaFkyTnZkVzUwT2lCQlpHUnlaWE56Q2dsamIyNWpZWFFLQ1dKdmVGOXNaVzRLQ1hOM1lYQUtDWEJ2Y0FvSklRb0pZbm9nS21sbU1sOWxibVFLQ2drdkx5QXFhV1l5WDJOdmJuTmxjWFZsYm5RS0NTOHZJR052Ym5SeVlXTjBjMXhDWVhSamFGSmxaMmx6ZEhKNUxuUnpPakV6TkFvSkx5OGdjbVYwZFhKdUlHWmhiSE5sT3dvSmFXNTBZeUF5SUM4dklEQUtDWEpsZEhOMVlnb0tLbWxtTWw5bGJtUTZDZ2t2THlCamIyNTBjbUZqZEhOY1FtRjBZMmhTWldkcGMzUnllUzUwY3pveE16VUtDUzh2SUhKbGRIVnliaUFvZEdocGN5NXliMnhsY3loaFkyTnZkVzUwS1M1MllXeDFaU0FtSUhKdmJHVkNhWFFwSUNFOVBTQXdPd29KWW5sMFpXTWdNU0F2THlBZ0luSWlDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZV05qYjNWdWREb2dRV1JrY21WemN3b0pZMjl1WTJGMENnbGliM2hmWjJWMENnb0pMeThnWW05NElIWmhiSFZsSUdSdlpYTWdibTkwSUdWNGFYTjBPaUIwYUdsekxuSnZiR1Z6S0dGalkyOTFiblFwTG5aaGJIVmxDZ2xoYzNObGNuUUtDV0owYjJrS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCeWIyeGxRbWwwT2lCMWFXNTBOalFLQ1NZS0NXbHVkR01nTWlBdkx5QXdDZ2toUFFvSmNtVjBjM1ZpQ2dvdkx5Qm5jbUZ1ZEZKdmJHVW9kV2x1ZERZMExHRmtaSEpsYzNNcGRtOXBaQW9xWVdKcFgzSnZkWFJsWDJkeVlXNTBVbTlzWlRvS0NTOHZJR0ZqWTI5MWJuUTZJR0ZrWkhKbGMzTUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0NXUjFjQW9KYkdWdUNnbHBiblJqSURFZ0x5OGdNeklLQ1QwOUNnb0pMeThnWVhKbmRXMWxiblFnTUNBb1lXTmpiM1Z1ZENrZ1ptOXlJR2R5WVc1MFVtOXNaU0J0ZFhOMElHSmxJR0VnWVdSa2NtVnpjd29KWVhOelpYSjBDZ29KTHk4Z2NtOXNaVG9nZFdsdWREWTBDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENnbGlkRzlwQ2dvSkx5OGdaWGhsWTNWMFpTQm5jbUZ1ZEZKdmJHVW9kV2x1ZERZMExHRmtaSEpsYzNNcGRtOXBaQW9KWTJGc2JITjFZaUJuY21GdWRGSnZiR1VLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJR2R5WVc1MFVtOXNaU2h5YjJ4bE9pQjFhVzUwTmpRc0lHRmpZMjkxYm5RNklFRmtaSEpsYzNNcE9pQjJiMmxrQ2k4dkNpOHZJRWR5WVc1MElHRWdjbTlzWlNCaWFYUnRZWE5ySUhSdklHRnVJR0ZqWTI5MWJuUXVJRUZrYldsdUxXOXViSGt1Q21keVlXNTBVbTlzWlRvS0NYQnliM1J2SURJZ01Bb0tDUzh2SUZCMWMyZ2daVzF3ZEhrZ1lubDBaWE1nWVdaMFpYSWdkR2hsSUdaeVlXMWxJSEJ2YVc1MFpYSWdkRzhnY21WelpYSjJaU0J6Y0dGalpTQm1iM0lnYkc5allXd2dkbUZ5YVdGaWJHVnpDZ2xpZVhSbFl5QXdJQzh2SURCNENnb0pMeThnWTI5dWRISmhZM1J6WEVKaGRHTm9VbVZuYVhOMGNua3VkSE02TVRReUNna3ZMeUIwYUdsekxtRnpjMlZ5ZEVGa2JXbHVLQ2tLQ1dOaGJHeHpkV0lnWVhOelpYSjBRV1J0YVc0S0Nna3ZMeUJqYjI1MGNtRmpkSE5jUW1GMFkyaFNaV2RwYzNSeWVTNTBjem94TkRNS0NTOHZJR0Z6YzJWeWRDaGhZMk52ZFc1MElDRTlQU0JuYkc5aVlXeHpMbnBsY205QlpHUnlaWE56TENBblEyRnVibTkwSUdkeVlXNTBJSEp2YkdVZ2RHOGdlbVZ5YnlCaFpHUnlaWE56SnlrS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCaFkyTnZkVzUwT2lCQlpHUnlaWE56Q2dsbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0NTRTlDZ29KTHk4Z1EyRnVibTkwSUdkeVlXNTBJSEp2YkdVZ2RHOGdlbVZ5YnlCaFpHUnlaWE56Q2dsaGMzTmxjblFLQ2drdkx5QmpiMjUwY21GamRITmNRbUYwWTJoU1pXZHBjM1J5ZVM1MGN6b3hORFFLQ1M4dklHTjFjbkpsYm5RNklIVnBiblEyTkNBOUlEQUtDV2x1ZEdNZ01pQXZMeUF3Q2dsbWNtRnRaVjlpZFhKNUlEQWdMeThnWTNWeWNtVnVkRG9nZFdsdWREWTBDZ29KTHk4Z0ttbG1NMTlqYjI1a2FYUnBiMjRLQ1M4dklHTnZiblJ5WVdOMGMxeENZWFJqYUZKbFoybHpkSEo1TG5Sek9qRTBOUW9KTHk4Z2RHaHBjeTV5YjJ4bGN5aGhZMk52ZFc1MEtTNWxlR2x6ZEhNS0NXSjVkR1ZqSURFZ0x5OGdJQ0p5SWdvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUdGalkyOTFiblE2SUVGa1pISmxjM01LQ1dOdmJtTmhkQW9KWW05NFgyeGxiZ29KYzNkaGNBb0pjRzl3Q2dsaWVpQXFhV1l6WDJWdVpBb0tDUzh2SUNwcFpqTmZZMjl1YzJWeGRXVnVkQW9KTHk4Z1kyOXVkSEpoWTNSelhFSmhkR05vVW1WbmFYTjBjbmt1ZEhNNk1UUTJDZ2t2THlCamRYSnlaVzUwSUQwZ2RHaHBjeTV5YjJ4bGN5aGhZMk52ZFc1MEtTNTJZV3gxWlFvSllubDBaV01nTVNBdkx5QWdJbklpQ2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnWVdOamIzVnVkRG9nUVdSa2NtVnpjd29KWTI5dVkyRjBDZ2xpYjNoZloyVjBDZ29KTHk4Z1ltOTRJSFpoYkhWbElHUnZaWE1nYm05MElHVjRhWE4wT2lCMGFHbHpMbkp2YkdWektHRmpZMjkxYm5RcExuWmhiSFZsQ2dsaGMzTmxjblFLQ1dKMGIya0tDV1p5WVcxbFgySjFjbmtnTUNBdkx5QmpkWEp5Wlc1ME9pQjFhVzUwTmpRS0NpcHBaak5mWlc1a09nb0pMeThnWTI5dWRISmhZM1J6WEVKaGRHTm9VbVZuYVhOMGNua3VkSE02TVRRNENna3ZMeUIwYUdsekxuSnZiR1Z6S0dGalkyOTFiblFwTG5aaGJIVmxJRDBnWTNWeWNtVnVkQ0I4SUhKdmJHVUtDV0o1ZEdWaklERWdMeThnSUNKeUlnb0pabkpoYldWZlpHbG5JQzB5SUM4dklHRmpZMjkxYm5RNklFRmtaSEpsYzNNS0NXTnZibU5oZEFvSlpuSmhiV1ZmWkdsbklEQWdMeThnWTNWeWNtVnVkRG9nZFdsdWREWTBDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdjbTlzWlRvZ2RXbHVkRFkwQ2dsOENnbHBkRzlpQ2dsaWIzaGZjSFYwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUpoZEdOb1VtVm5hWE4wY25rdWRITTZNVFE1Q2drdkx5QnNiMmNvSjFKdmJHVkhjbUZ1ZEdWa0p5a0tDWEIxYzJoaWVYUmxjeUF3ZURVeU5tWTJZelkxTkRjM01qWXhObVUzTkRZMU5qUWdMeThnSWxKdmJHVkhjbUZ1ZEdWa0lnb0piRzluQ2dseVpYUnpkV0lLQ2k4dklISmxkbTlyWlZKdmJHVW9kV2x1ZERZMExHRmtaSEpsYzNNcGRtOXBaQW9xWVdKcFgzSnZkWFJsWDNKbGRtOXJaVkp2YkdVNkNna3ZMeUJoWTJOdmRXNTBPaUJoWkdSeVpYTnpDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNnbGtkWEFLQ1d4bGJnb0phVzUwWXlBeElDOHZJRE15Q2drOVBRb0tDUzh2SUdGeVozVnRaVzUwSURBZ0tHRmpZMjkxYm5RcElHWnZjaUJ5WlhadmEyVlNiMnhsSUcxMWMzUWdZbVVnWVNCaFpHUnlaWE56Q2dsaGMzTmxjblFLQ2drdkx5QnliMnhsT2lCMWFXNTBOalFLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtDV0owYjJrS0Nna3ZMeUJsZUdWamRYUmxJSEpsZG05clpWSnZiR1VvZFdsdWREWTBMR0ZrWkhKbGMzTXBkbTlwWkFvSlkyRnNiSE4xWWlCeVpYWnZhMlZTYjJ4bENnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCeVpYWnZhMlZTYjJ4bEtISnZiR1U2SUhWcGJuUTJOQ3dnWVdOamIzVnVkRG9nUVdSa2NtVnpjeWs2SUhadmFXUUtMeThLTHk4Z1VtVjJiMnRsSUdFZ2NtOXNaU0JpYVhSdFlYTnJJR1p5YjIwZ1lXNGdZV05qYjNWdWRDNGdRV1J0YVc0dGIyNXNlUzRLY21WMmIydGxVbTlzWlRvS0NYQnliM1J2SURJZ01Bb0tDUzh2SUdOdmJuUnlZV04wYzF4Q1lYUmphRkpsWjJsemRISjVMblJ6T2pFMU5nb0pMeThnZEdocGN5NWhjM05sY25SQlpHMXBiaWdwQ2dsallXeHNjM1ZpSUdGemMyVnlkRUZrYldsdUNnb0pMeThnS21sbU5GOWpiMjVrYVhScGIyNEtDUzh2SUdOdmJuUnlZV04wYzF4Q1lYUmphRkpsWjJsemRISjVMblJ6T2pFMU53b0pMeThnZEdocGN5NXliMnhsY3loaFkyTnZkVzUwS1M1bGVHbHpkSE1LQ1dKNWRHVmpJREVnTHk4Z0lDSnlJZ29KWm5KaGJXVmZaR2xuSUMweUlDOHZJR0ZqWTI5MWJuUTZJRUZrWkhKbGMzTUtDV052Ym1OaGRBb0pZbTk0WDJ4bGJnb0pjM2RoY0FvSmNHOXdDZ2xpZWlBcWFXWTBYMlZ1WkFvS0NTOHZJQ3BwWmpSZlkyOXVjMlZ4ZFdWdWRBb0pMeThnWTI5dWRISmhZM1J6WEVKaGRHTm9VbVZuYVhOMGNua3VkSE02TVRVNENna3ZMeUIwYUdsekxuSnZiR1Z6S0dGalkyOTFiblFwTG5aaGJIVmxJRDBnZEdocGN5NXliMnhsY3loaFkyTnZkVzUwS1M1MllXeDFaU0FtSUg1eWIyeGxDZ2xpZVhSbFl5QXhJQzh2SUNBaWNpSUtDV1p5WVcxbFgyUnBaeUF0TWlBdkx5QmhZMk52ZFc1ME9pQkJaR1J5WlhOekNnbGpiMjVqWVhRS0NXSjVkR1ZqSURFZ0x5OGdJQ0p5SWdvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUdGalkyOTFiblE2SUVGa1pISmxjM01LQ1dOdmJtTmhkQW9KWW05NFgyZGxkQW9LQ1M4dklHSnZlQ0IyWVd4MVpTQmtiMlZ6SUc1dmRDQmxlR2x6ZERvZ2RHaHBjeTV5YjJ4bGN5aGhZMk52ZFc1MEtTNTJZV3gxWlFvSllYTnpaWEowQ2dsaWRHOXBDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdjbTlzWlRvZ2RXbHVkRFkwQ2dsK0Nna21DZ2xwZEc5aUNnbGliM2hmY0hWMENnb3FhV1kwWDJWdVpEb0tDUzh2SUdOdmJuUnlZV04wYzF4Q1lYUmphRkpsWjJsemRISjVMblJ6T2pFMk1Bb0pMeThnYkc5bktDZFNiMnhsVW1WMmIydGxaQ2NwQ2dsd2RYTm9ZbmwwWlhNZ01IZzFNalptTm1NMk5UVXlOalUzTmpabU5tSTJOVFkwSUM4dklDSlNiMnhsVW1WMmIydGxaQ0lLQ1d4dlp3b0pjbVYwYzNWaUNnb3ZMeUJuY21GdWRFMWhiblZtWVdOMGRYSmxjbEp2YkdVb1lXUmtjbVZ6Y3lsMmIybGtDaXBoWW1sZmNtOTFkR1ZmWjNKaGJuUk5ZVzUxWm1GamRIVnlaWEpTYjJ4bE9nb0pMeThnWVdOamIzVnVkRG9nWVdSa2NtVnpjd29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb0paSFZ3Q2dsc1pXNEtDV2x1ZEdNZ01TQXZMeUF6TWdvSlBUMEtDZ2t2THlCaGNtZDFiV1Z1ZENBd0lDaGhZMk52ZFc1MEtTQm1iM0lnWjNKaGJuUk5ZVzUxWm1GamRIVnlaWEpTYjJ4bElHMTFjM1FnWW1VZ1lTQmhaR1J5WlhOekNnbGhjM05sY25RS0Nna3ZMeUJsZUdWamRYUmxJR2R5WVc1MFRXRnVkV1poWTNSMWNtVnlVbTlzWlNoaFpHUnlaWE56S1hadmFXUUtDV05oYkd4emRXSWdaM0poYm5STllXNTFabUZqZEhWeVpYSlNiMnhsQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJuY21GdWRFMWhiblZtWVdOMGRYSmxjbEp2YkdVb1lXTmpiM1Z1ZERvZ1FXUmtjbVZ6Y3lrNklIWnZhV1FLWjNKaGJuUk5ZVzUxWm1GamRIVnlaWEpTYjJ4bE9nb0pjSEp2ZEc4Z01TQXdDZ29KTHk4Z1kyOXVkSEpoWTNSelhFSmhkR05vVW1WbmFYTjBjbmt1ZEhNNk1UWTFDZ2t2THlCMGFHbHpMbWR5WVc1MFVtOXNaU2hOUVU1VlJrRkRWRlZTUlZKZlFrbFVMQ0JoWTJOdmRXNTBLUW9KWm5KaGJXVmZaR2xuSUMweElDOHZJR0ZqWTI5MWJuUTZJRUZrWkhKbGMzTUtDV2x1ZEdNZ015QXZMeUF5Q2dsallXeHNjM1ZpSUdkeVlXNTBVbTlzWlFvSmNtVjBjM1ZpQ2dvdkx5Qm5jbUZ1ZEVScGMzUnlhV0oxZEc5eVVtOXNaU2hoWkdSeVpYTnpLWFp2YVdRS0ttRmlhVjl5YjNWMFpWOW5jbUZ1ZEVScGMzUnlhV0oxZEc5eVVtOXNaVG9LQ1M4dklHRmpZMjkxYm5RNklHRmtaSEpsYzNNS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLQ1dSMWNBb0piR1Z1Q2dscGJuUmpJREVnTHk4Z016SUtDVDA5Q2dvSkx5OGdZWEpuZFcxbGJuUWdNQ0FvWVdOamIzVnVkQ2tnWm05eUlHZHlZVzUwUkdsemRISnBZblYwYjNKU2IyeGxJRzExYzNRZ1ltVWdZU0JoWkdSeVpYTnpDZ2xoYzNObGNuUUtDZ2t2THlCbGVHVmpkWFJsSUdkeVlXNTBSR2x6ZEhKcFluVjBiM0pTYjJ4bEtHRmtaSEpsYzNNcGRtOXBaQW9KWTJGc2JITjFZaUJuY21GdWRFUnBjM1J5YVdKMWRHOXlVbTlzWlFvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnWjNKaGJuUkVhWE4wY21saWRYUnZjbEp2YkdVb1lXTmpiM1Z1ZERvZ1FXUmtjbVZ6Y3lrNklIWnZhV1FLWjNKaGJuUkVhWE4wY21saWRYUnZjbEp2YkdVNkNnbHdjbTkwYnlBeElEQUtDZ2t2THlCamIyNTBjbUZqZEhOY1FtRjBZMmhTWldkcGMzUnllUzUwY3pveE5qZ0tDUzh2SUhSb2FYTXVaM0poYm5SU2IyeGxLRVJKVTFSU1NVSlZWRTlTWDBKSlZDd2dZV05qYjNWdWRDa0tDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmhZMk52ZFc1ME9pQkJaR1J5WlhOekNnbHBiblJqSURjZ0x5OGdOQW9KWTJGc2JITjFZaUJuY21GdWRGSnZiR1VLQ1hKbGRITjFZZ29LTHk4Z1ozSmhiblJRYUdGeWJXRmplVkp2YkdVb1lXUmtjbVZ6Y3lsMmIybGtDaXBoWW1sZmNtOTFkR1ZmWjNKaGJuUlFhR0Z5YldGamVWSnZiR1U2Q2drdkx5QmhZMk52ZFc1ME9pQmhaR1J5WlhOekNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2dsa2RYQUtDV3hsYmdvSmFXNTBZeUF4SUM4dklETXlDZ2s5UFFvS0NTOHZJR0Z5WjNWdFpXNTBJREFnS0dGalkyOTFiblFwSUdadmNpQm5jbUZ1ZEZCb1lYSnRZV041VW05c1pTQnRkWE4wSUdKbElHRWdZV1JrY21WemN3b0pZWE56WlhKMENnb0pMeThnWlhobFkzVjBaU0JuY21GdWRGQm9ZWEp0WVdONVVtOXNaU2hoWkdSeVpYTnpLWFp2YVdRS0NXTmhiR3h6ZFdJZ1ozSmhiblJRYUdGeWJXRmplVkp2YkdVS0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaTh2SUdkeVlXNTBVR2hoY20xaFkzbFNiMnhsS0dGalkyOTFiblE2SUVGa1pISmxjM01wT2lCMmIybGtDbWR5WVc1MFVHaGhjbTFoWTNsU2IyeGxPZ29KY0hKdmRHOGdNU0F3Q2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUpoZEdOb1VtVm5hWE4wY25rdWRITTZNVGN4Q2drdkx5QjBhR2x6TG1keVlXNTBVbTlzWlNoUVNFRlNUVUZEV1Y5Q1NWUXNJR0ZqWTI5MWJuUXBDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZV05qYjNWdWREb2dRV1JrY21WemN3b0phVzUwWXlBMUlDOHZJRGdLQ1dOaGJHeHpkV0lnWjNKaGJuUlNiMnhsQ2dseVpYUnpkV0lLQ2k4dklHZHlZVzUwVkdWc1pXMWxkSEo1VDNKaFkyeGxVbTlzWlNoaFpHUnlaWE56S1hadmFXUUtLbUZpYVY5eWIzVjBaVjluY21GdWRGUmxiR1Z0WlhSeWVVOXlZV05zWlZKdmJHVTZDZ2t2THlCaFkyTnZkVzUwT2lCaFpHUnlaWE56Q2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDZ2xrZFhBS0NXeGxiZ29KYVc1MFl5QXhJQzh2SURNeUNnazlQUW9LQ1M4dklHRnlaM1Z0Wlc1MElEQWdLR0ZqWTI5MWJuUXBJR1p2Y2lCbmNtRnVkRlJsYkdWdFpYUnllVTl5WVdOc1pWSnZiR1VnYlhWemRDQmlaU0JoSUdGa1pISmxjM01LQ1dGemMyVnlkQW9LQ1M4dklHVjRaV04xZEdVZ1ozSmhiblJVWld4bGJXVjBjbmxQY21GamJHVlNiMnhsS0dGa1pISmxjM01wZG05cFpBb0pZMkZzYkhOMVlpQm5jbUZ1ZEZSbGJHVnRaWFJ5ZVU5eVlXTnNaVkp2YkdVS0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaTh2SUdkeVlXNTBWR1ZzWlcxbGRISjVUM0poWTJ4bFVtOXNaU2hoWTJOdmRXNTBPaUJCWkdSeVpYTnpLVG9nZG05cFpBcG5jbUZ1ZEZSbGJHVnRaWFJ5ZVU5eVlXTnNaVkp2YkdVNkNnbHdjbTkwYnlBeElEQUtDZ2t2THlCamIyNTBjbUZqZEhOY1FtRjBZMmhTWldkcGMzUnllUzUwY3pveE56UUtDUzh2SUhSb2FYTXVaM0poYm5SU2IyeGxLRTlTUVVOTVJWOUNTVlFzSUdGalkyOTFiblFwQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWVdOamIzVnVkRG9nUVdSa2NtVnpjd29KYVc1MFl5QTJJQzh2SURFMkNnbGpZV3hzYzNWaUlHZHlZVzUwVW05c1pRb0pjbVYwYzNWaUNnb3ZMeUJ5WlhadmEyVk5ZVzUxWm1GamRIVnlaWEpTYjJ4bEtHRmtaSEpsYzNNcGRtOXBaQW9xWVdKcFgzSnZkWFJsWDNKbGRtOXJaVTFoYm5WbVlXTjBkWEpsY2xKdmJHVTZDZ2t2THlCaFkyTnZkVzUwT2lCaFpHUnlaWE56Q2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDZ2xrZFhBS0NXeGxiZ29KYVc1MFl5QXhJQzh2SURNeUNnazlQUW9LQ1M4dklHRnlaM1Z0Wlc1MElEQWdLR0ZqWTI5MWJuUXBJR1p2Y2lCeVpYWnZhMlZOWVc1MVptRmpkSFZ5WlhKU2IyeGxJRzExYzNRZ1ltVWdZU0JoWkdSeVpYTnpDZ2xoYzNObGNuUUtDZ2t2THlCbGVHVmpkWFJsSUhKbGRtOXJaVTFoYm5WbVlXTjBkWEpsY2xKdmJHVW9ZV1JrY21WemN5bDJiMmxrQ2dsallXeHNjM1ZpSUhKbGRtOXJaVTFoYm5WbVlXTjBkWEpsY2xKdmJHVUtDV2x1ZEdNZ01DQXZMeUF4Q2dseVpYUjFjbTRLQ2k4dklISmxkbTlyWlUxaGJuVm1ZV04wZFhKbGNsSnZiR1VvWVdOamIzVnVkRG9nUVdSa2NtVnpjeWs2SUhadmFXUUtjbVYyYjJ0bFRXRnVkV1poWTNSMWNtVnlVbTlzWlRvS0NYQnliM1J2SURFZ01Bb0tDUzh2SUdOdmJuUnlZV04wYzF4Q1lYUmphRkpsWjJsemRISjVMblJ6T2pFM09Bb0pMeThnZEdocGN5NXlaWFp2YTJWU2IyeGxLRTFCVGxWR1FVTlVWVkpGVWw5Q1NWUXNJR0ZqWTI5MWJuUXBDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZV05qYjNWdWREb2dRV1JrY21WemN3b0phVzUwWXlBeklDOHZJRElLQ1dOaGJHeHpkV0lnY21WMmIydGxVbTlzWlFvSmNtVjBjM1ZpQ2dvdkx5QnlaWFp2YTJWRWFYTjBjbWxpZFhSdmNsSnZiR1VvWVdSa2NtVnpjeWwyYjJsa0NpcGhZbWxmY205MWRHVmZjbVYyYjJ0bFJHbHpkSEpwWW5WMGIzSlNiMnhsT2dvSkx5OGdZV05qYjNWdWREb2dZV1JrY21WemN3b0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvSlpIVndDZ2xzWlc0S0NXbHVkR01nTVNBdkx5QXpNZ29KUFQwS0Nna3ZMeUJoY21kMWJXVnVkQ0F3SUNoaFkyTnZkVzUwS1NCbWIzSWdjbVYyYjJ0bFJHbHpkSEpwWW5WMGIzSlNiMnhsSUcxMWMzUWdZbVVnWVNCaFpHUnlaWE56Q2dsaGMzTmxjblFLQ2drdkx5QmxlR1ZqZFhSbElISmxkbTlyWlVScGMzUnlhV0oxZEc5eVVtOXNaU2hoWkdSeVpYTnpLWFp2YVdRS0NXTmhiR3h6ZFdJZ2NtVjJiMnRsUkdsemRISnBZblYwYjNKU2IyeGxDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QnlaWFp2YTJWRWFYTjBjbWxpZFhSdmNsSnZiR1VvWVdOamIzVnVkRG9nUVdSa2NtVnpjeWs2SUhadmFXUUtjbVYyYjJ0bFJHbHpkSEpwWW5WMGIzSlNiMnhsT2dvSmNISnZkRzhnTVNBd0Nnb0pMeThnWTI5dWRISmhZM1J6WEVKaGRHTm9VbVZuYVhOMGNua3VkSE02TVRneENna3ZMeUIwYUdsekxuSmxkbTlyWlZKdmJHVW9SRWxUVkZKSlFsVlVUMUpmUWtsVUxDQmhZMk52ZFc1MEtRb0pabkpoYldWZlpHbG5JQzB4SUM4dklHRmpZMjkxYm5RNklFRmtaSEpsYzNNS0NXbHVkR01nTnlBdkx5QTBDZ2xqWVd4c2MzVmlJSEpsZG05clpWSnZiR1VLQ1hKbGRITjFZZ29LTHk4Z2NtVjJiMnRsVUdoaGNtMWhZM2xTYjJ4bEtHRmtaSEpsYzNNcGRtOXBaQW9xWVdKcFgzSnZkWFJsWDNKbGRtOXJaVkJvWVhKdFlXTjVVbTlzWlRvS0NTOHZJR0ZqWTI5MWJuUTZJR0ZrWkhKbGMzTUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXUjFjQW9KYkdWdUNnbHBiblJqSURFZ0x5OGdNeklLQ1QwOUNnb0pMeThnWVhKbmRXMWxiblFnTUNBb1lXTmpiM1Z1ZENrZ1ptOXlJSEpsZG05clpWQm9ZWEp0WVdONVVtOXNaU0J0ZFhOMElHSmxJR0VnWVdSa2NtVnpjd29KWVhOelpYSjBDZ29KTHk4Z1pYaGxZM1YwWlNCeVpYWnZhMlZRYUdGeWJXRmplVkp2YkdVb1lXUmtjbVZ6Y3lsMmIybGtDZ2xqWVd4c2MzVmlJSEpsZG05clpWQm9ZWEp0WVdONVVtOXNaUW9KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdjbVYyYjJ0bFVHaGhjbTFoWTNsU2IyeGxLR0ZqWTI5MWJuUTZJRUZrWkhKbGMzTXBPaUIyYjJsa0NuSmxkbTlyWlZCb1lYSnRZV041VW05c1pUb0tDWEJ5YjNSdklERWdNQW9LQ1M4dklHTnZiblJ5WVdOMGMxeENZWFJqYUZKbFoybHpkSEo1TG5Sek9qRTROQW9KTHk4Z2RHaHBjeTV5WlhadmEyVlNiMnhsS0ZCSVFWSk5RVU5aWDBKSlZDd2dZV05qYjNWdWRDa0tDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmhZMk52ZFc1ME9pQkJaR1J5WlhOekNnbHBiblJqSURVZ0x5OGdPQW9KWTJGc2JITjFZaUJ5WlhadmEyVlNiMnhsQ2dseVpYUnpkV0lLQ2k4dklISmxkbTlyWlZSbGJHVnRaWFJ5ZVU5eVlXTnNaVkp2YkdVb1lXUmtjbVZ6Y3lsMmIybGtDaXBoWW1sZmNtOTFkR1ZmY21WMmIydGxWR1ZzWlcxbGRISjVUM0poWTJ4bFVtOXNaVG9LQ1M4dklHRmpZMjkxYm5RNklHRmtaSEpsYzNNS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLQ1dSMWNBb0piR1Z1Q2dscGJuUmpJREVnTHk4Z016SUtDVDA5Q2dvSkx5OGdZWEpuZFcxbGJuUWdNQ0FvWVdOamIzVnVkQ2tnWm05eUlISmxkbTlyWlZSbGJHVnRaWFJ5ZVU5eVlXTnNaVkp2YkdVZ2JYVnpkQ0JpWlNCaElHRmtaSEpsYzNNS0NXRnpjMlZ5ZEFvS0NTOHZJR1Y0WldOMWRHVWdjbVYyYjJ0bFZHVnNaVzFsZEhKNVQzSmhZMnhsVW05c1pTaGhaR1J5WlhOektYWnZhV1FLQ1dOaGJHeHpkV0lnY21WMmIydGxWR1ZzWlcxbGRISjVUM0poWTJ4bFVtOXNaUW9KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdjbVYyYjJ0bFZHVnNaVzFsZEhKNVQzSmhZMnhsVW05c1pTaGhZMk52ZFc1ME9pQkJaR1J5WlhOektUb2dkbTlwWkFweVpYWnZhMlZVWld4bGJXVjBjbmxQY21GamJHVlNiMnhsT2dvSmNISnZkRzhnTVNBd0Nnb0pMeThnWTI5dWRISmhZM1J6WEVKaGRHTm9VbVZuYVhOMGNua3VkSE02TVRnM0Nna3ZMeUIwYUdsekxuSmxkbTlyWlZKdmJHVW9UMUpCUTB4RlgwSkpWQ3dnWVdOamIzVnVkQ2tLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJoWTJOdmRXNTBPaUJCWkdSeVpYTnpDZ2xwYm5SaklEWWdMeThnTVRZS0NXTmhiR3h6ZFdJZ2NtVjJiMnRsVW05c1pRb0pjbVYwYzNWaUNnb3ZMeUJvWVhOU2IyeGxLSFZwYm5RMk5DeGhaR1J5WlhOektXSnZiMndLS21GaWFWOXliM1YwWlY5b1lYTlNiMnhsT2dvSkx5OGdWR2hsSUVGQ1NTQnlaWFIxY200Z2NISmxabWw0Q2dsaWVYUmxZeUF5SUM4dklEQjRNVFV4Wmpkak56VUtDZ2t2THlCaFkyTnZkVzUwT2lCaFpHUnlaWE56Q2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDZ2xrZFhBS0NXeGxiZ29KYVc1MFl5QXhJQzh2SURNeUNnazlQUW9LQ1M4dklHRnlaM1Z0Wlc1MElEQWdLR0ZqWTI5MWJuUXBJR1p2Y2lCb1lYTlNiMnhsSUcxMWMzUWdZbVVnWVNCaFpHUnlaWE56Q2dsaGMzTmxjblFLQ2drdkx5QnliMnhsT2lCMWFXNTBOalFLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtDV0owYjJrS0Nna3ZMeUJsZUdWamRYUmxJR2hoYzFKdmJHVW9kV2x1ZERZMExHRmtaSEpsYzNNcFltOXZiQW9KWTJGc2JITjFZaUJvWVhOU2IyeGxDZ2xpZVhSbFl5QXlNeUF2THlBd2VEQXdDZ2xwYm5SaklESWdMeThnTUFvSmRXNWpiM1psY2lBeUNnbHpaWFJpYVhRS0NXTnZibU5oZEFvSmJHOW5DZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5Qm9ZWE5TYjJ4bEtISnZiR1U2SUhWcGJuUTJOQ3dnWVdOamIzVnVkRG9nUVdSa2NtVnpjeWs2SUdKdmIyeGxZVzRLTHk4S0x5OGdRMmhsWTJzZ2QyaGxkR2hsY2lCaGJpQmhZMk52ZFc1MElHaHZiR1J6SUdFZ2MzQmxZMmxtYVdNZ2NtOXNaUzRLYUdGelVtOXNaVG9LQ1hCeWIzUnZJRElnTVFvS0NTOHZJR052Ym5SeVlXTjBjMXhDWVhSamFGSmxaMmx6ZEhKNUxuUnpPakU1TkFvSkx5OGdjbVYwZFhKdUlIUm9hWE11WVdSa2NtVnpjMGhoYzFKdmJHVW9ZV05qYjNWdWRDd2djbTlzWlNrN0NnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z2NtOXNaVG9nZFdsdWREWTBDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdZV05qYjNWdWREb2dRV1JrY21WemN3b0pZMkZzYkhOMVlpQmhaR1J5WlhOelNHRnpVbTlzWlFvSmNtVjBjM1ZpQ2dvdkx5QmpjbVZoZEdWQ1lYUmphQ2h6ZEhKcGJtY3BkV2x1ZERZMENpcGhZbWxmY205MWRHVmZZM0psWVhSbFFtRjBZMmc2Q2drdkx5QlVhR1VnUVVKSklISmxkSFZ5YmlCd2NtVm1hWGdLQ1dKNWRHVmpJRElnTHk4Z01IZ3hOVEZtTjJNM05Rb0tDUzh2SUdSeWRXZE9ZVzFsT2lCemRISnBibWNLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtDV1Y0ZEhKaFkzUWdNaUF3Q2dvSkx5OGdaWGhsWTNWMFpTQmpjbVZoZEdWQ1lYUmphQ2h6ZEhKcGJtY3BkV2x1ZERZMENnbGpZV3hzYzNWaUlHTnlaV0YwWlVKaGRHTm9DZ2xwZEc5aUNnbGpiMjVqWVhRS0NXeHZad29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdZM0psWVhSbFFtRjBZMmdvWkhKMVowNWhiV1U2SUhOMGNtbHVaeWs2SUhWcGJuUTJOQW92THdvdkx5QkRjbVZoZEdVZ1lTQnVaWGNnYldWa2FXTnBibVVnWW1GMFkyZ3VJRTl1YkhrZ2JXRnVkV1poWTNSMWNtVnljeUJ2Y2lCaFpHMXBibk11Q2k4dkNpOHZJRUJ3WVhKaGJTQmtjblZuVG1GdFpTQXRJRTVoYldVZ2IyWWdkR2hsSUdSeWRXY2dLRzFoZUNBeU5UWWdZbmwwWlhNcExnb3ZMeUJBY21WMGRYSnVjeUJpWVhSamFFbGtJQzBnVkdobElHRnpjMmxuYm1Wa0lHSmhkR05vSUVsRUxncGpjbVZoZEdWQ1lYUmphRG9LQ1hCeWIzUnZJREVnTVFvS0NTOHZJRkIxYzJnZ1pXMXdkSGtnWW5sMFpYTWdZV1owWlhJZ2RHaGxJR1p5WVcxbElIQnZhVzUwWlhJZ2RHOGdjbVZ6WlhKMlpTQnpjR0ZqWlNCbWIzSWdiRzlqWVd3Z2RtRnlhV0ZpYkdWekNnbGllWFJsWXlBd0lDOHZJREI0Q2dsa2RYQUtDZ2t2THlCamIyNTBjbUZqZEhOY1FtRjBZMmhTWldkcGMzUnllUzUwY3pveU1Ea0tDUzh2SUdGemMyVnlkQ2dLQ1M4dklDQWdJQ0FnSUhSb2FYTXVZMkZzYkdWeVNHRnpVbTlzWlNoQlJFMUpUbDlDU1ZRcElIeDhJSFJvYVhNdVkyRnNiR1Z5U0dGelVtOXNaU2hOUVU1VlJrRkRWRlZTUlZKZlFrbFVLU3dLQ1M4dklDQWdJQ0FnSUNkRFlXeHNaWElnYVhNZ2JtOTBJR0VnYldGdWRXWmhZM1IxY21WeUp3b0pMeThnSUNBZ0lDa0tDV2x1ZEdNZ01DQXZMeUF4Q2dsallXeHNjM1ZpSUdOaGJHeGxja2hoYzFKdmJHVUtDV1IxY0FvSlltNTZJQ3B6YTJsd1gyOXlNUW9KYVc1MFl5QXpJQzh2SURJS0NXTmhiR3h6ZFdJZ1kyRnNiR1Z5U0dGelVtOXNaUW9KZkh3S0NpcHphMmx3WDI5eU1Ub0tDUzh2SUVOaGJHeGxjaUJwY3lCdWIzUWdZU0J0WVc1MVptRmpkSFZ5WlhJS0NXRnpjMlZ5ZEFvS0NTOHZJR052Ym5SeVlXTjBjMXhDWVhSamFGSmxaMmx6ZEhKNUxuUnpPakl4TXdvSkx5OGdibUZ0WlVKNWRHVnpJRDBnY21GM1FubDBaWE1vWkhKMVowNWhiV1VwQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWkhKMVowNWhiV1U2SUhOMGNtbHVad29KWkhWd0NnbHNaVzRLQ1dsMGIySUtDV1Y0ZEhKaFkzUWdOaUF5Q2dsemQyRndDZ2xqYjI1allYUUtDV1p5WVcxbFgySjFjbmtnTUNBdkx5QnVZVzFsUW5sMFpYTTZJR0o1ZEdWYlhRb0tDUzh2SUdOdmJuUnlZV04wYzF4Q1lYUmphRkpsWjJsemRISjVMblJ6T2pJeE5Bb0pMeThnWVhOelpYSjBLR3hsYmlodVlXMWxRbmwwWlhNcElENGdNQ0FtSmlCc1pXNG9ibUZ0WlVKNWRHVnpLU0E4UFNBeU5UWXNJQ2RKYm5aaGJHbGtJR1J5ZFdjZ2JtRnRaU2NwQ2dsbWNtRnRaVjlrYVdjZ01DQXZMeUJ1WVcxbFFubDBaWE02SUdKNWRHVmJYUW9KYkdWdUNnbHBiblJqSURJZ0x5OGdNQW9KUGdvSlpIVndDZ2xpZWlBcWMydHBjRjloYm1ReENnbG1jbUZ0WlY5a2FXY2dNQ0F2THlCdVlXMWxRbmwwWlhNNklHSjVkR1ZiWFFvSmJHVnVDZ2x3ZFhOb2FXNTBJREkxTmdvSlBEMEtDU1ltQ2dvcWMydHBjRjloYm1ReE9nb0pMeThnU1c1MllXeHBaQ0JrY25WbklHNWhiV1VLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeENZWFJqYUZKbFoybHpkSEo1TG5Sek9qSXhOZ29KTHk4Z1ltRjBZMmhKWkNBOUlIUm9hWE11Ym1WNGRFSmhkR05vU1dRdWRtRnNkV1VLQ1dKNWRHVmpJRGNnTHk4Z0lDSnVaWGgwU1dRaUNnbGhjSEJmWjJ4dlltRnNYMmRsZEFvSlpuSmhiV1ZmWW5WeWVTQXhJQzh2SUdKaGRHTm9TV1E2SUhWcGJuUTJOQW9LQ1M4dklHTnZiblJ5WVdOMGMxeENZWFJqYUZKbFoybHpkSEo1TG5Sek9qSXhOd29KTHk4Z2RHaHBjeTV1WlhoMFFtRjBZMmhKWkM1MllXeDFaU0E5SUdKaGRHTm9TV1FnS3lBeENnbGllWFJsWXlBM0lDOHZJQ0FpYm1WNGRFbGtJZ29KWm5KaGJXVmZaR2xuSURFZ0x5OGdZbUYwWTJoSlpEb2dkV2x1ZERZMENnbHBiblJqSURBZ0x5OGdNUW9KS3dvSllYQndYMmRzYjJKaGJGOXdkWFFLQ2drdkx5QmpiMjUwY21GamRITmNRbUYwWTJoU1pXZHBjM1J5ZVM1MGN6b3lNVGtLQ1M4dklIUm9hWE11WW1GMFkyaEVjblZuVG1GdFpTaGlZWFJqYUVsa0tTNTJZV3gxWlNBOUlHNWhiV1ZDZVhSbGN3b0pZbmwwWldNZ01URWdMeThnSUNKaWJpSUtDV1p5WVcxbFgyUnBaeUF4SUM4dklHSmhkR05vU1dRNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5dVkyRjBDZ2xrZFhBS0NXSnZlRjlrWld3S0NYQnZjQW9KWm5KaGJXVmZaR2xuSURBZ0x5OGdibUZ0WlVKNWRHVnpPaUJpZVhSbFcxMEtDV0p2ZUY5d2RYUUtDZ2t2THlCamIyNTBjbUZqZEhOY1FtRjBZMmhTWldkcGMzUnllUzUwY3pveU1qQUtDUzh2SUhSb2FYTXVZbUYwWTJoTllXNTFabUZqZEhWeVpYSW9ZbUYwWTJoSlpDa3VkbUZzZFdVZ1BTQjBhR2x6TG5SNGJpNXpaVzVrWlhJS0NXSjVkR1ZqSURFeUlDOHZJQ0FpWW0waUNnbG1jbUZ0WlY5a2FXY2dNU0F2THlCaVlYUmphRWxrT2lCMWFXNTBOalFLQ1dsMGIySUtDV052Ym1OaGRBb0pkSGh1SUZObGJtUmxjZ29KWW05NFgzQjFkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeENZWFJqYUZKbFoybHpkSEo1TG5Sek9qSXlNUW9KTHk4Z2RHaHBjeTVpWVhSamFFTjFjM1J2WkdsaGJpaGlZWFJqYUVsa0tTNTJZV3gxWlNBOUlIUm9hWE11ZEhodUxuTmxibVJsY2dvSllubDBaV01nTkNBdkx5QWdJbUpqSWdvSlpuSmhiV1ZmWkdsbklERWdMeThnWW1GMFkyaEpaRG9nZFdsdWREWTBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NYUjRiaUJUWlc1a1pYSUtDV0p2ZUY5d2RYUUtDZ2t2THlCamIyNTBjbUZqZEhOY1FtRjBZMmhTWldkcGMzUnllUzUwY3pveU1qSUtDUzh2SUhSb2FYTXVZbUYwWTJoVGRHRjBaU2hpWVhSamFFbGtLUzUyWVd4MVpTQTlJRk5VUVZSRlgwRkRWRWxXUlFvSllubDBaV01nTXlBdkx5QWdJbUp6SWdvSlpuSmhiV1ZmWkdsbklERWdMeThnWW1GMFkyaEpaRG9nZFdsdWREWTBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NXSjVkR1ZqSURrZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDZ2xpYjNoZmNIVjBDZ29KTHk4Z1kyOXVkSEpoWTNSelhFSmhkR05vVW1WbmFYTjBjbmt1ZEhNNk1qSXpDZ2t2THlCMGFHbHpMbUpoZEdOb1EzSmxZWFJsWkVGMEtHSmhkR05vU1dRcExuWmhiSFZsSUQwZ1oyeHZZbUZzY3k1c1lYUmxjM1JVYVcxbGMzUmhiWEFLQ1dKNWRHVmpJREV6SUM4dklDQWlZblFpQ2dsbWNtRnRaVjlrYVdjZ01TQXZMeUJpWVhSamFFbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXTnZibU5oZEFvSloyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9KYVhSdllnb0pZbTk0WDNCMWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4Q1lYUmphRkpsWjJsemRISjVMblJ6T2pJeU5Bb0pMeThnZEdocGN5NWlZWFJqYUZWd1pHRjBaV1JCZENoaVlYUmphRWxrS1M1MllXeDFaU0E5SUdkc2IySmhiSE11YkdGMFpYTjBWR2x0WlhOMFlXMXdDZ2xpZVhSbFl5QTRJQzh2SUNBaVluVWlDZ2xtY21GdFpWOWthV2NnTVNBdkx5QmlZWFJqYUVsa09pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb0phWFJ2WWdvSlltOTRYM0IxZEFvS0NTOHZJR052Ym5SeVlXTjBjMXhDWVhSamFGSmxaMmx6ZEhKNUxuUnpPakl5TlFvSkx5OGdkR2hwY3k1amRYTjBiMlI1UTI5MWJuUW9ZbUYwWTJoSlpDa3VkbUZzZFdVZ1BTQXdDZ2xpZVhSbFl5QTFJQzh2SUNBaVkyTWlDZ2xtY21GdFpWOWthV2NnTVNBdkx5QmlZWFJqYUVsa09pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KWW5sMFpXTWdPU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0NXSnZlRjl3ZFhRS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUW1GMFkyaFNaV2RwYzNSeWVTNTBjem95TWpZS0NTOHZJSFJvYVhNdVluSmxZV05vUTI5MWJuUW9ZbUYwWTJoSlpDa3VkbUZzZFdVZ1BTQXdDZ2xpZVhSbFl5QTJJQzh2SUNBaWVHTWlDZ2xtY21GdFpWOWthV2NnTVNBdkx5QmlZWFJqYUVsa09pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KWW5sMFpXTWdPU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0NXSnZlRjl3ZFhRS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUW1GMFkyaFNaV2RwYzNSeWVTNTBjem95TWpnS0NTOHZJR3h2WnlnblFtRjBZMmhEY21WaGRHVmtKeWtLQ1hCMWMyaGllWFJsY3lBd2VEUXlOakUzTkRZek5qZzBNemN5TmpVMk1UYzBOalUyTkNBdkx5QWlRbUYwWTJoRGNtVmhkR1ZrSWdvSmJHOW5DZ29KTHk4Z1kyOXVkSEpoWTNSelhFSmhkR05vVW1WbmFYTjBjbmt1ZEhNNk1qSTVDZ2t2THlCeVpYUjFjbTRnWW1GMFkyaEpaRHNLQ1daeVlXMWxYMlJwWnlBeElDOHZJR0poZEdOb1NXUTZJSFZwYm5RMk5Bb0tDUzh2SUhObGRDQjBhR1VnYzNWaWNtOTFkR2x1WlNCeVpYUjFjbTRnZG1Gc2RXVUtDV1p5WVcxbFgySjFjbmtnTUFvS0NTOHZJSEJ2Y0NCaGJHd2diRzlqWVd3Z2RtRnlhV0ZpYkdWeklHWnliMjBnZEdobElITjBZV05yQ2dsd2IzQnVJREVLQ1hKbGRITjFZZ29LTHk4Z1lYTnpaWEowUW1GMFkyaEZlR2x6ZEhNb1ltRjBZMmhKWkRvZ2RXbHVkRFkwS1RvZ2RtOXBaQXBoYzNObGNuUkNZWFJqYUVWNGFYTjBjem9LQ1hCeWIzUnZJREVnTUFvS0NTOHZJR052Ym5SeVlXTjBjMXhDWVhSamFGSmxaMmx6ZEhKNUxuUnpPakl6TndvSkx5OGdZWE56WlhKMEtHSmhkR05vU1dRZ1BpQXdJQ1ltSUdKaGRHTm9TV1FnUENCMGFHbHpMbTVsZUhSQ1lYUmphRWxrTG5aaGJIVmxMQ0FuUW1GMFkyZ2daRzlsY3lCdWIzUWdaWGhwYzNRbktRb0pabkpoYldWZlpHbG5JQzB4SUM4dklHSmhkR05vU1dRNklIVnBiblEyTkFvSmFXNTBZeUF5SUM4dklEQUtDVDRLQ1dSMWNBb0pZbm9nS25OcmFYQmZZVzVrTWdvSlpuSmhiV1ZmWkdsbklDMHhJQzh2SUdKaGRHTm9TV1E2SUhWcGJuUTJOQW9KWW5sMFpXTWdOeUF2THlBZ0ltNWxlSFJKWkNJS0NXRndjRjluYkc5aVlXeGZaMlYwQ2drOENna21KZ29LS25OcmFYQmZZVzVrTWpvS0NTOHZJRUpoZEdOb0lHUnZaWE1nYm05MElHVjRhWE4wQ2dsaGMzTmxjblFLQ1hKbGRITjFZZ29LTHk4Z1lYTnpaWEowVG05MFFuSmxZV05vWldRb1ltRjBZMmhKWkRvZ2RXbHVkRFkwS1RvZ2RtOXBaQXBoYzNObGNuUk9iM1JDY21WaFkyaGxaRG9LQ1hCeWIzUnZJREVnTUFvS0NTOHZJR052Ym5SeVlXTjBjMXhDWVhSamFGSmxaMmx6ZEhKNUxuUnpPakkwTVFvSkx5OGdZWE56WlhKMEtIUm9hWE11WW1GMFkyaFRkR0YwWlNoaVlYUmphRWxrS1M1MllXeDFaU0FoUFQwZ1UxUkJWRVZmUWxKRlFVTklSVVFzSUNkQ1lYUmphQ0JwY3lCaWNtVmhZMmhsWkNjcENnbGllWFJsWXlBeklDOHZJQ0FpWW5NaUNnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1ltRjBZMmhKWkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjI1allYUUtDV0p2ZUY5blpYUUtDZ2t2THlCaWIzZ2dkbUZzZFdVZ1pHOWxjeUJ1YjNRZ1pYaHBjM1E2SUhSb2FYTXVZbUYwWTJoVGRHRjBaU2hpWVhSamFFbGtLUzUyWVd4MVpRb0pZWE56WlhKMENnbGlkRzlwQ2dscGJuUmpJREFnTHk4Z01Rb0pJVDBLQ2drdkx5QkNZWFJqYUNCcGN5QmljbVZoWTJobFpBb0pZWE56WlhKMENnbHlaWFJ6ZFdJS0NpOHZJSE5sZEVKaGRHTm9VM1JoZEdVb1ltRjBZMmhKWkRvZ2RXbHVkRFkwTENCdVpYZFRkR0YwWlRvZ2RXbHVkRFkwS1RvZ2RtOXBaQXB6WlhSQ1lYUmphRk4wWVhSbE9nb0pjSEp2ZEc4Z01pQXdDZ29KTHk4Z1kyOXVkSEpoWTNSelhFSmhkR05vVW1WbmFYTjBjbmt1ZEhNNk1qUTFDZ2t2THlCMGFHbHpMbUpoZEdOb1UzUmhkR1VvWW1GMFkyaEpaQ2t1ZG1Gc2RXVWdQU0J1WlhkVGRHRjBaUW9KWW5sMFpXTWdNeUF2THlBZ0ltSnpJZ29KWm5KaGJXVmZaR2xuSUMweElDOHZJR0poZEdOb1NXUTZJSFZwYm5RMk5Bb0phWFJ2WWdvSlkyOXVZMkYwQ2dsbWNtRnRaVjlrYVdjZ0xUSWdMeThnYm1WM1UzUmhkR1U2SUhWcGJuUTJOQW9KYVhSdllnb0pZbTk0WDNCMWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4Q1lYUmphRkpsWjJsemRISjVMblJ6T2pJME5nb0pMeThnZEdocGN5NWlZWFJqYUZWd1pHRjBaV1JCZENoaVlYUmphRWxrS1M1MllXeDFaU0E5SUdkc2IySmhiSE11YkdGMFpYTjBWR2x0WlhOMFlXMXdDZ2xpZVhSbFl5QTRJQzh2SUNBaVluVWlDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZbUYwWTJoSlpEb2dkV2x1ZERZMENnbHBkRzlpQ2dsamIyNWpZWFFLQ1dkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtDV2wwYjJJS0NXSnZlRjl3ZFhRS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUW1GMFkyaFNaV2RwYzNSeWVTNTBjem95TkRjS0NTOHZJR3h2WnlnblUzUmhkR1ZEYUdGdVoyVmtKeWtLQ1hCMWMyaGllWFJsY3lBd2VEVXpOelEyTVRjME5qVTBNelk0TmpFMlpUWTNOalUyTkNBdkx5QWlVM1JoZEdWRGFHRnVaMlZrSWdvSmJHOW5DZ2x5WlhSemRXSUtDaTh2SUdac1lXZENjbVZoWTJnb2RXbHVkRFkwS1hadmFXUUtLbUZpYVY5eWIzVjBaVjltYkdGblFuSmxZV05vT2dvSkx5OGdZbUYwWTJoSlpEb2dkV2x1ZERZMENnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2dsaWRHOXBDZ29KTHk4Z1pYaGxZM1YwWlNCbWJHRm5RbkpsWVdOb0tIVnBiblEyTkNsMmIybGtDZ2xqWVd4c2MzVmlJR1pzWVdkQ2NtVmhZMmdLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJR1pzWVdkQ2NtVmhZMmdvWW1GMFkyaEpaRG9nZFdsdWREWTBLVG9nZG05cFpBb3ZMd292THlCTVpXZGhZM2t2YldGdWRXRnNJR0p5WldGamFDQnRaWFJvYjJRZ2NtVjBZV2x1WldRZ1ptOXlJR0poWTJ0bGJtUWdZMjl0Y0dGMGFXSnBiR2wwZVM0S0x5OGdUMjVzZVNCaFpHMXBiaXdnYldGdWRXWmhZM1IxY21WeUxDQnZjaUJ2Y21GamJHVWdZMkZ1SUdac1lXY2dZU0JpY21WaFkyZ3VDbVpzWVdkQ2NtVmhZMmc2Q2dsd2NtOTBieUF4SURBS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUW1GMFkyaFNaV2RwYzNSeWVTNTBjem95TlRrS0NTOHZJSFJvYVhNdVlYTnpaWEowUW1GMFkyaEZlR2x6ZEhNb1ltRjBZMmhKWkNrS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaVlYUmphRWxrT2lCMWFXNTBOalFLQ1dOaGJHeHpkV0lnWVhOelpYSjBRbUYwWTJoRmVHbHpkSE1LQ2drdkx5QmpiMjUwY21GamRITmNRbUYwWTJoU1pXZHBjM1J5ZVM1MGN6b3lOakFLQ1M4dklIUm9hWE11WVhOelpYSjBUbTkwUW5KbFlXTm9aV1FvWW1GMFkyaEpaQ2tLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJpWVhSamFFbGtPaUIxYVc1ME5qUUtDV05oYkd4emRXSWdZWE56WlhKMFRtOTBRbkpsWVdOb1pXUUtDZ2t2THlCamIyNTBjbUZqZEhOY1FtRjBZMmhTWldkcGMzUnllUzUwY3pveU5qRUtDUzh2SUdGemMyVnlkQ2dLQ1M4dklDQWdJQ0FnSUhSb2FYTXVZMkZzYkdWeVNHRnpVbTlzWlNoQlJFMUpUbDlDU1ZRcElIeDhDZ2t2THlBZ0lDQWdJQ0FnSUhSb2FYTXVZMkZzYkdWeVNHRnpVbTlzWlNoTlFVNVZSa0ZEVkZWU1JWSmZRa2xVS1NCOGZBb0pMeThnSUNBZ0lDQWdJQ0IwYUdsekxtTmhiR3hsY2toaGMxSnZiR1VvVDFKQlEweEZYMEpKVkNrc0Nna3ZMeUFnSUNBZ0lDQW5RMkZzYkdWeUlHTmhibTV2ZENCbWJHRm5JR0p5WldGamFDY0tDUzh2SUNBZ0lDQXBDZ2xwYm5SaklEQWdMeThnTVFvSlkyRnNiSE4xWWlCallXeHNaWEpJWVhOU2IyeGxDZ2xrZFhBS0NXSnVlaUFxYzJ0cGNGOXZjaklLQ1dsdWRHTWdNeUF2THlBeUNnbGpZV3hzYzNWaUlHTmhiR3hsY2toaGMxSnZiR1VLQ1h4OENnb3FjMnRwY0Y5dmNqSTZDZ2xrZFhBS0NXSnVlaUFxYzJ0cGNGOXZjak1LQ1dsdWRHTWdOaUF2THlBeE5nb0pZMkZzYkhOMVlpQmpZV3hzWlhKSVlYTlNiMnhsQ2dsOGZBb0tLbk5yYVhCZmIzSXpPZ29KTHk4Z1EyRnNiR1Z5SUdOaGJtNXZkQ0JtYkdGbklHSnlaV0ZqYUFvSllYTnpaWEowQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUpoZEdOb1VtVm5hWE4wY25rdWRITTZNalkzQ2drdkx5QjBhR2x6TG5ObGRFSmhkR05vVTNSaGRHVW9ZbUYwWTJoSlpDd2dVMVJCVkVWZlFsSkZRVU5JUlVRcENnbHBiblJqSURBZ0x5OGdNUW9KWm5KaGJXVmZaR2xuSUMweElDOHZJR0poZEdOb1NXUTZJSFZwYm5RMk5Bb0pZMkZzYkhOMVlpQnpaWFJDWVhSamFGTjBZWFJsQ2dseVpYUnpkV0lLQ2k4dklISmxZMjl5WkZSbGJYQmxjbUYwZFhKbEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0ZrWkhKbGMzTXNZbmwwWlZzek1sMHBZbTl2YkFvcVlXSnBYM0p2ZFhSbFgzSmxZMjl5WkZSbGJYQmxjbUYwZFhKbE9nb0pMeThnVkdobElFRkNTU0J5WlhSMWNtNGdjSEpsWm1sNENnbGllWFJsWXlBeUlDOHZJREI0TVRVeFpqZGpOelVLQ2drdkx5QmxkbWxrWlc1alpVaGhjMmc2SUdKNWRHVmJNekpkQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDZ2xrZFhBS0NXeGxiZ29KYVc1MFl5QXhJQzh2SURNeUNnazlQUW9LQ1M4dklHRnlaM1Z0Wlc1MElEQWdLR1YyYVdSbGJtTmxTR0Z6YUNrZ1ptOXlJSEpsWTI5eVpGUmxiWEJsY21GMGRYSmxJRzExYzNRZ1ltVWdZU0JpZVhSbFd6TXlYUW9KWVhOelpYSjBDZ29KTHk4Z2MyVnVjMjl5T2lCaFpHUnlaWE56Q2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDZ2xrZFhBS0NXeGxiZ29KYVc1MFl5QXhJQzh2SURNeUNnazlQUW9LQ1M4dklHRnlaM1Z0Wlc1MElERWdLSE5sYm5OdmNpa2dabTl5SUhKbFkyOXlaRlJsYlhCbGNtRjBkWEpsSUcxMWMzUWdZbVVnWVNCaFpHUnlaWE56Q2dsaGMzTmxjblFLQ2drdkx5QnZZbk5sY25abFpFRjBPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0NXSjBiMmtLQ2drdkx5QjBaVzF3WlhKaGRIVnlaVU5sYm5ScE9pQjFhVzUwTmpRS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLQ1dKMGIya0tDZ2t2THlCaVlYUmphRWxrT2lCMWFXNTBOalFLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtDV0owYjJrS0Nna3ZMeUJsZUdWamRYUmxJSEpsWTI5eVpGUmxiWEJsY21GMGRYSmxLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEdGa1pISmxjM01zWW5sMFpWc3pNbDBwWW05dmJBb0pZMkZzYkhOMVlpQnlaV052Y21SVVpXMXdaWEpoZEhWeVpRb0pZbmwwWldNZ01qTWdMeThnTUhnd01Bb0phVzUwWXlBeUlDOHZJREFLQ1hWdVkyOTJaWElnTWdvSmMyVjBZbWwwQ2dsamIyNWpZWFFLQ1d4dlp3b0phVzUwWXlBd0lDOHZJREVLQ1hKbGRIVnliZ29LTHk4Z2NtVmpiM0prVkdWdGNHVnlZWFIxY21Vb1ltRjBZMmhKWkRvZ2RXbHVkRFkwTENCMFpXMXdaWEpoZEhWeVpVTmxiblJwT2lCMWFXNTBOalFzSUc5aWMyVnlkbVZrUVhRNklIVnBiblEyTkN3Z2MyVnVjMjl5T2lCQlpHUnlaWE56TENCbGRtbGtaVzVqWlVoaGMyZzZJR0o1ZEdWek16SXBPaUJpYjI5c1pXRnVDaTh2Q2k4dklGSmxZMjl5WkhNZ1lTQnphV2R1WldRZ2MyVnVjMjl5SUhKbFlXUnBibWNnWkdsblpYTjBJRzl1TFdOb1lXbHVJR0Z1WkNCaGRYUnZMV0p5WldGamFHVnpDaTh2SUdsbUlIUm9aU0IwWlcxd1pYSmhkSFZ5WlNCcGN5QnZkWFJ6YVdSbElIUm9aU0J6WVdabElISmhibWRsSUZzeUxqQXdJTUt3UXl3Z09DNHdNQ0RDc0VOZExnb3ZMd292THlCVVpXMXdaWEpoZEhWeVpTQnBjeUJwYmlCb2RXNWtjbVZrZEdoeklHOW1JR0VnWkdWbmNtVmxJQ2hsTG1jdUlEUTFNQ0E5SURRdU5UQWd3ckJES1M0S0x5OGdSbTl5SUhSb1pTQkJWazBzSUhkbElIQmhjM01nZEdWdGNHVnlZWFIxY21VZ1lYTWdkV2x1ZERZME95QjJZV3gxWlhNZ1lXSnZkbVVnWVNCMGFISmxjMmh2YkdRS0x5OGdLR1V1Wnk0Z1BpQlRRVVpGWDAxQldDa2dZWEpsSUhSeVpXRjBaV1FnWVhNZ2IzVjBJRzltSUhKaGJtZGxMaUJPWldkaGRHbDJaU0IwWlcxd1pYSmhkSFZ5WlhNS0x5OGdjMmh2ZFd4a0lHSmxJR1Z1WTI5a1pXUWdZWE1nZG1WeWVTQnNZWEpuWlNCMWFXNTBOalFnZG1Gc2RXVnpJR0Z1WkNCM2FXeHNJR0ZzZDJGNWN5QmljbVZoWTJndUNpOHZDaTh2SUVCd1lYSmhiU0JpWVhSamFFbGtJQzBnVkdobElHSmhkR05vSUhSdklISmxZMjl5WkNCaFoyRnBibk4wTGdvdkx5QkFjR0Z5WVcwZ2RHVnRjR1Z5WVhSMWNtVkRaVzUwYVNBdElGUmxiWEFnYVc0Z01TOHhNREFnd3JCRElDaDFhVzUwTmpRZ1pXNWpiMlJwYm1jcExnb3ZMeUJBY0dGeVlXMGdiMkp6WlhKMlpXUkJkQ0F0SUZObGJuTnZjaUJ2WW5ObGNuWmhkR2x2YmlCMGFXMWxjM1JoYlhBZ0tIVnVhWGdnYzJWamIyNWtjeWt1Q2k4dklFQndZWEpoYlNCelpXNXpiM0lnTFNCVFpXNXpiM0lnWVdOamIzVnVkQ0JoWkdSeVpYTnpMZ292THlCQWNHRnlZVzBnWlhacFpHVnVZMlZJWVhOb0lDMGdhMlZqWTJGck1qVTJJRzltSUhSb1pTQnphV2R1WldRZ2RHVnNaVzFsZEhKNUlIQmhlV3h2WVdRdUNpOHZJRUJ5WlhSMWNtNXpJR2x6VTJGbVpTQXRJRmRvWlhSb1pYSWdkR2hsSUhKbFlXUnBibWNnYVhNZ2QybDBhR2x1SUhSb1pTQnpZV1psSUhKaGJtZGxMZ3B5WldOdmNtUlVaVzF3WlhKaGRIVnlaVG9LQ1hCeWIzUnZJRFVnTVFvS0NTOHZJRkIxYzJnZ1pXMXdkSGtnWW5sMFpYTWdZV1owWlhJZ2RHaGxJR1p5WVcxbElIQnZhVzUwWlhJZ2RHOGdjbVZ6WlhKMlpTQnpjR0ZqWlNCbWIzSWdiRzlqWVd3Z2RtRnlhV0ZpYkdWekNnbGllWFJsWXlBd0lDOHZJREI0Q2dsa2RYQnVJRElLQ2drdkx5QmpiMjUwY21GamRITmNRbUYwWTJoU1pXZHBjM1J5ZVM1MGN6b3lPVE1LQ1M4dklIUm9hWE11WVhOelpYSjBRbUYwWTJoRmVHbHpkSE1vWW1GMFkyaEpaQ2tLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJpWVhSamFFbGtPaUIxYVc1ME5qUUtDV05oYkd4emRXSWdZWE56WlhKMFFtRjBZMmhGZUdsemRITUtDZ2t2THlCamIyNTBjbUZqZEhOY1FtRjBZMmhTWldkcGMzUnllUzUwY3pveU9UWUtDUzh2SUdGemMyVnlkQ2dLQ1M4dklDQWdJQ0FnSUhSb2FYTXVZMkZzYkdWeVNHRnpVbTlzWlNoQlJFMUpUbDlDU1ZRcElIeDhJSFJvYVhNdVkyRnNiR1Z5U0dGelVtOXNaU2hQVWtGRFRFVmZRa2xVS1N3S0NTOHZJQ0FnSUNBZ0lDZERZV3hzWlhJZ2FYTWdibTkwSUdFZ2RHVnNaVzFsZEhKNUlHOXlZV05zWlNjS0NTOHZJQ0FnSUNBcENnbHBiblJqSURBZ0x5OGdNUW9KWTJGc2JITjFZaUJqWVd4c1pYSklZWE5TYjJ4bENnbGtkWEFLQ1dKdWVpQXFjMnRwY0Y5dmNqUUtDV2x1ZEdNZ05pQXZMeUF4TmdvSlkyRnNiSE4xWWlCallXeHNaWEpJWVhOU2IyeGxDZ2w4ZkFvS0tuTnJhWEJmYjNJME9nb0pMeThnUTJGc2JHVnlJR2x6SUc1dmRDQmhJSFJsYkdWdFpYUnllU0J2Y21GamJHVUtDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4Q1lYUmphRkpsWjJsemRISjVMblJ6T2pNd01Bb0pMeThnWVhOelpYSjBLSE5sYm5OdmNpQWhQVDBnWjJ4dlltRnNjeTU2WlhKdlFXUmtjbVZ6Y3l3Z0oxTmxibk52Y2lCallXNXViM1FnWW1VZ2VtVnlieUJoWkdSeVpYTnpKeWtLQ1daeVlXMWxYMlJwWnlBdE5DQXZMeUJ6Wlc1emIzSTZJRUZrWkhKbGMzTUtDV2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29KSVQwS0Nna3ZMeUJUWlc1emIzSWdZMkZ1Ym05MElHSmxJSHBsY204Z1lXUmtjbVZ6Y3dvSllYTnpaWEowQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUpoZEdOb1VtVm5hWE4wY25rdWRITTZNekF4Q2drdkx5QmhjM05sY25Rb1pYWnBaR1Z1WTJWSVlYTm9JQ0U5UFNCaWVtVnlieWd6TWlrZ1lYTWdZbmwwWlhNek1pd2dKMFYyYVdSbGJtTmxJR2hoYzJnZ2NtVnhkV2x5WldRbktRb0pabkpoYldWZlpHbG5JQzAxSUM4dklHVjJhV1JsYm1ObFNHRnphRG9nWW5sMFpYTXpNZ29KY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb0pJVDBLQ2drdkx5QkZkbWxrWlc1alpTQm9ZWE5vSUhKbGNYVnBjbVZrQ2dsaGMzTmxjblFLQ2drdkx5QmpiMjUwY21GamRITmNRbUYwWTJoU1pXZHBjM1J5ZVM1MGN6b3pNRElLQ1M4dklHRnpjMlZ5ZENnS0NTOHZJQ0FnSUNBZ0lHOWljMlZ5ZG1Wa1FYUWdQRDBnWjJ4dlltRnNjeTVzWVhSbGMzUlVhVzFsYzNSaGJYQWdLeUJOUVZoZlJsVlVWVkpGWDA5Q1UwVlNWa0ZVU1U5T1gxZEpUa1JQVnl3S0NTOHZJQ0FnSUNBZ0lDZFBZbk5sY25aaGRHbHZiaUJwY3lCMGIyOGdabUZ5SUdsdUlHWjFkSFZ5WlNjS0NTOHZJQ0FnSUNBcENnbG1jbUZ0WlY5a2FXY2dMVE1nTHk4Z2IySnpaWEoyWldSQmREb2dkV2x1ZERZMENnbG5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2dsd2RYTm9hVzUwSURNd01Bb0pLd29KUEQwS0Nna3ZMeUJQWW5ObGNuWmhkR2x2YmlCcGN5QjBiMjhnWm1GeUlHbHVJR1oxZEhWeVpRb0pZWE56WlhKMENnb0pMeThnWTI5dWRISmhZM1J6WEVKaGRHTm9VbVZuYVhOMGNua3VkSE02TXpBM0Nna3ZMeUJwYzFOaFptVWdQUW9KTHk4Z0lDQWdJQ0FnZEdWdGNHVnlZWFIxY21WRFpXNTBhU0ErUFNCVFFVWkZYMDFKVGw5VVJVMVFSVkpCVkZWU1JWOURSVTVVU1NBbUpnb0pMeThnSUNBZ0lDQWdkR1Z0Y0dWeVlYUjFjbVZEWlc1MGFTQThQU0JUUVVaRlgwMUJXRjlVUlUxUVJWSkJWRlZTUlY5RFJVNVVTUW9KWm5KaGJXVmZaR2xuSUMweUlDOHZJSFJsYlhCbGNtRjBkWEpsUTJWdWRHazZJSFZwYm5RMk5Bb0pjSFZ6YUdsdWRDQXlNREFLQ1Q0OUNnbGtkWEFLQ1dKNklDcHphMmx3WDJGdVpETUtDV1p5WVcxbFgyUnBaeUF0TWlBdkx5QjBaVzF3WlhKaGRIVnlaVU5sYm5ScE9pQjFhVzUwTmpRS0NYQjFjMmhwYm5RZ09EQXdDZ2s4UFFvSkppWUtDaXB6YTJsd1gyRnVaRE02Q2dsbWNtRnRaVjlpZFhKNUlEQWdMeThnYVhOVFlXWmxPaUJpYjI5c0Nnb0pMeThnWTI5dWRISmhZM1J6WEVKaGRHTm9VbVZuYVhOMGNua3VkSE02TXpFeENna3ZMeUJzYjJjb0oxUmxiWEJsY21GMGRYSmxVbVZqYjNKa1pXUW5LUW9KY0hWemFHSjVkR1Z6SURCNE5UUTJOVFprTnpBMk5UY3lOakUzTkRjMU56STJOVFV5TmpVMk16Wm1OekkyTkRZMU5qUWdMeThnSWxSbGJYQmxjbUYwZFhKbFVtVmpiM0prWldRaUNnbHNiMmNLQ2drdkx5QXFhV1kxWDJOdmJtUnBkR2x2YmdvSkx5OGdZMjl1ZEhKaFkzUnpYRUpoZEdOb1VtVm5hWE4wY25rdWRITTZNekV6Q2drdkx5QWhhWE5UWVdabENnbG1jbUZ0WlY5a2FXY2dNQ0F2THlCcGMxTmhabVU2SUdKdmIyd0tDU0VLQ1dKNklDcHBaalZmWlc1a0Nnb0pMeThnS21sbU5WOWpiMjV6WlhGMVpXNTBDZ2t2THlCamIyNTBjbUZqZEhOY1FtRjBZMmhTWldkcGMzUnllUzUwY3pvek1UVUtDUzh2SUdsa2VDQTlJSFJvYVhNdVluSmxZV05vUTI5MWJuUW9ZbUYwWTJoSlpDa3VkbUZzZFdVS0NXSjVkR1ZqSURZZ0x5OGdJQ0o0WXlJS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaVlYUmphRWxrT2lCMWFXNTBOalFLQ1dsMGIySUtDV052Ym1OaGRBb0pZbTk0WDJkbGRBb0tDUzh2SUdKdmVDQjJZV3gxWlNCa2IyVnpJRzV2ZENCbGVHbHpkRG9nZEdocGN5NWljbVZoWTJoRGIzVnVkQ2hpWVhSamFFbGtLUzUyWVd4MVpRb0pZWE56WlhKMENnbGlkRzlwQ2dsbWNtRnRaVjlpZFhKNUlERWdMeThnYVdSNE9pQjFhVzUwTmpRS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUW1GMFkyaFNaV2RwYzNSeWVTNTBjem96TVRZS0NTOHZJR3RsZVNBOUlHSmhkR05vU1dRZ0tpQXhYekF3TUY4d01EQWdLeUJwWkhnS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaVlYUmphRWxrT2lCMWFXNTBOalFLQ1dsdWRHTWdOQ0F2THlBeFh6QXdNRjh3TURBS0NTb0tDV1p5WVcxbFgyUnBaeUF4SUM4dklHbGtlRG9nZFdsdWREWTBDZ2tyQ2dsbWNtRnRaVjlpZFhKNUlESWdMeThnYTJWNU9pQjFhVzUwTmpRS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUW1GMFkyaFNaV2RwYzNSeWVTNTBjem96TVRnS0NTOHZJSFJvYVhNdVluSmxZV05vVkdWdGNDaHJaWGtwTG5aaGJIVmxJRDBnZEdWdGNHVnlZWFIxY21WRFpXNTBhUW9KWW5sMFpXTWdNVFFnTHk4Z0lDSjRkQ0lLQ1daeVlXMWxYMlJwWnlBeUlDOHZJR3RsZVRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjI1allYUUtDV1p5WVcxbFgyUnBaeUF0TWlBdkx5QjBaVzF3WlhKaGRIVnlaVU5sYm5ScE9pQjFhVzUwTmpRS0NXbDBiMklLQ1dKdmVGOXdkWFFLQ2drdkx5QmpiMjUwY21GamRITmNRbUYwWTJoU1pXZHBjM1J5ZVM1MGN6b3pNVGtLQ1M4dklIUm9hWE11WW5KbFlXTm9UMkp6WlhKMlpXUkJkQ2hyWlhrcExuWmhiSFZsSUQwZ2IySnpaWEoyWldSQmRBb0pZbmwwWldNZ01UVWdMeThnSUNKNGJ5SUtDV1p5WVcxbFgyUnBaeUF5SUM4dklHdGxlVG9nZFdsdWREWTBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NXWnlZVzFsWDJScFp5QXRNeUF2THlCdlluTmxjblpsWkVGME9pQjFhVzUwTmpRS0NXbDBiMklLQ1dKdmVGOXdkWFFLQ2drdkx5QmpiMjUwY21GamRITmNRbUYwWTJoU1pXZHBjM1J5ZVM1MGN6b3pNakFLQ1M4dklIUm9hWE11WW5KbFlXTm9VbVZqYjNKa1pXUkJkQ2hyWlhrcExuWmhiSFZsSUQwZ1oyeHZZbUZzY3k1c1lYUmxjM1JVYVcxbGMzUmhiWEFLQ1dKNWRHVmpJREUySUM4dklDQWllSElpQ2dsbWNtRnRaVjlrYVdjZ01pQXZMeUJyWlhrNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5dVkyRjBDZ2xuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NnbHBkRzlpQ2dsaWIzaGZjSFYwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUpoZEdOb1VtVm5hWE4wY25rdWRITTZNekl4Q2drdkx5QjBhR2x6TG1KeVpXRmphRk5sYm5OdmNpaHJaWGtwTG5aaGJIVmxJRDBnYzJWdWMyOXlDZ2xpZVhSbFl5QXhOeUF2THlBZ0luaHpJZ29KWm5KaGJXVmZaR2xuSURJZ0x5OGdhMlY1T2lCMWFXNTBOalFLQ1dsMGIySUtDV052Ym1OaGRBb0pabkpoYldWZlpHbG5JQzAwSUM4dklITmxibk52Y2pvZ1FXUmtjbVZ6Y3dvSlltOTRYM0IxZEFvS0NTOHZJR052Ym5SeVlXTjBjMXhDWVhSamFGSmxaMmx6ZEhKNUxuUnpPak15TWdvSkx5OGdkR2hwY3k1aWNtVmhZMmhGZG1sa1pXNWpaVWhoYzJnb2EyVjVLUzUyWVd4MVpTQTlJR1YyYVdSbGJtTmxTR0Z6YUFvSllubDBaV01nTVRnZ0x5OGdJQ0o0WlNJS0NXWnlZVzFsWDJScFp5QXlJQzh2SUd0bGVUb2dkV2x1ZERZMENnbHBkRzlpQ2dsamIyNWpZWFFLQ1daeVlXMWxYMlJwWnlBdE5TQXZMeUJsZG1sa1pXNWpaVWhoYzJnNklHSjVkR1Z6TXpJS0NXSnZlRjl3ZFhRS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUW1GMFkyaFNaV2RwYzNSeWVTNTBjem96TWpRS0NTOHZJSFJvYVhNdVluSmxZV05vUTI5MWJuUW9ZbUYwWTJoSlpDa3VkbUZzZFdVZ1BTQnBaSGdnS3lBeENnbGllWFJsWXlBMklDOHZJQ0FpZUdNaUNnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1ltRjBZMmhKWkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjI1allYUUtDV1p5WVcxbFgyUnBaeUF4SUM4dklHbGtlRG9nZFdsdWREWTBDZ2xwYm5SaklEQWdMeThnTVFvSkt3b0phWFJ2WWdvSlltOTRYM0IxZEFvS0NTOHZJR052Ym5SeVlXTjBjMXhDWVhSamFGSmxaMmx6ZEhKNUxuUnpPak15TmdvSkx5OGdiRzluS0NkVVpXMXdaWEpoZEhWeVpVSnlaV0ZqYUZKbFkyOXlaR1ZrSnlrS0NYQjFjMmhpZVhSbGN5QXdlRFUwTmpVMlpEY3dOalUzTWpZeE56UTNOVGN5TmpVME1qY3lOalUyTVRZek5qZzFNalkxTmpNMlpqY3lOalEyTlRZMElDOHZJQ0pVWlcxd1pYSmhkSFZ5WlVKeVpXRmphRkpsWTI5eVpHVmtJZ29KYkc5bkNnb0pMeThnS21sbU5sOWpiMjVrYVhScGIyNEtDUzh2SUdOdmJuUnlZV04wYzF4Q1lYUmphRkpsWjJsemRISjVMblJ6T2pNeU9Bb0pMeThnZEdocGN5NWlZWFJqYUZOMFlYUmxLR0poZEdOb1NXUXBMblpoYkhWbElDRTlQU0JUVkVGVVJWOUNVa1ZCUTBoRlJBb0pZbmwwWldNZ015QXZMeUFnSW1Keklnb0pabkpoYldWZlpHbG5JQzB4SUM4dklHSmhkR05vU1dRNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5dVkyRjBDZ2xpYjNoZloyVjBDZ29KTHk4Z1ltOTRJSFpoYkhWbElHUnZaWE1nYm05MElHVjRhWE4wT2lCMGFHbHpMbUpoZEdOb1UzUmhkR1VvWW1GMFkyaEpaQ2t1ZG1Gc2RXVUtDV0Z6YzJWeWRBb0pZblJ2YVFvSmFXNTBZeUF3SUM4dklERUtDU0U5Q2dsaWVpQXFhV1kyWDJWdVpBb0tDUzh2SUNwcFpqWmZZMjl1YzJWeGRXVnVkQW9KTHk4Z1kyOXVkSEpoWTNSelhFSmhkR05vVW1WbmFYTjBjbmt1ZEhNNk16STVDZ2t2THlCMGFHbHpMbk5sZEVKaGRHTm9VM1JoZEdVb1ltRjBZMmhKWkN3Z1UxUkJWRVZmUWxKRlFVTklSVVFwQ2dscGJuUmpJREFnTHk4Z01Rb0pabkpoYldWZlpHbG5JQzB4SUM4dklHSmhkR05vU1dRNklIVnBiblEyTkFvSlkyRnNiSE4xWWlCelpYUkNZWFJqYUZOMFlYUmxDZ29xYVdZMlgyVnVaRG9LQ2lwcFpqVmZaVzVrT2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUpoZEdOb1VtVm5hWE4wY25rdWRITTZNek16Q2drdkx5QnlaWFIxY200Z2FYTlRZV1psT3dvSlpuSmhiV1ZmWkdsbklEQWdMeThnYVhOVFlXWmxPaUJpYjI5c0Nnb0pMeThnYzJWMElIUm9aU0J6ZFdKeWIzVjBhVzVsSUhKbGRIVnliaUIyWVd4MVpRb0pabkpoYldWZlluVnllU0F3Q2dvSkx5OGdjRzl3SUdGc2JDQnNiMk5oYkNCMllYSnBZV0pzWlhNZ1puSnZiU0IwYUdVZ2MzUmhZMnNLQ1hCdmNHNGdNZ29KY21WMGMzVmlDZ292THlCMGNtRnVjMlpsY2tKaGRHTm9LSFZwYm5RMk5DeGhaR1J5WlhOektYWnZhV1FLS21GaWFWOXliM1YwWlY5MGNtRnVjMlpsY2tKaGRHTm9PZ29KTHk4Z2JtVjNRM1Z6ZEc5a2FXRnVPaUJoWkdSeVpYTnpDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNnbGtkWEFLQ1d4bGJnb0phVzUwWXlBeElDOHZJRE15Q2drOVBRb0tDUzh2SUdGeVozVnRaVzUwSURBZ0tHNWxkME4xYzNSdlpHbGhiaWtnWm05eUlIUnlZVzV6Wm1WeVFtRjBZMmdnYlhWemRDQmlaU0JoSUdGa1pISmxjM01LQ1dGemMyVnlkQW9LQ1M4dklHSmhkR05vU1dRNklIVnBiblEyTkFvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9KWW5SdmFRb0tDUzh2SUdWNFpXTjFkR1VnZEhKaGJuTm1aWEpDWVhSamFDaDFhVzUwTmpRc1lXUmtjbVZ6Y3lsMmIybGtDZ2xqWVd4c2MzVmlJSFJ5WVc1elptVnlRbUYwWTJnS0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaTh2SUhSeVlXNXpabVZ5UW1GMFkyZ29ZbUYwWTJoSlpEb2dkV2x1ZERZMExDQnVaWGREZFhOMGIyUnBZVzQ2SUVGa1pISmxjM01wT2lCMmIybGtDaTh2Q2k4dklGUnlZVzV6Wm1WeUlHSmhkR05vSUdOMWMzUnZaSGtnZEc4Z1lTQnVaWGNnWTNWemRHOWthV0Z1TGdvdkx5QkJiR3h2ZDJWa0lHWnZjam9nWTNWeWNtVnVkQ0JqZFhOMGIyUnBZVzRzSUdGa2JXbHVMQ0J0WVc1MVptRmpkSFZ5WlhJc0lHUnBjM1J5YVdKMWRHOXlMQ0J3YUdGeWJXRmplUzRLZEhKaGJuTm1aWEpDWVhSamFEb0tDWEJ5YjNSdklESWdNQW9LQ1M4dklGQjFjMmdnWlcxd2RIa2dZbmwwWlhNZ1lXWjBaWElnZEdobElHWnlZVzFsSUhCdmFXNTBaWElnZEc4Z2NtVnpaWEoyWlNCemNHRmpaU0JtYjNJZ2JHOWpZV3dnZG1GeWFXRmliR1Z6Q2dsaWVYUmxZeUF3SUM4dklEQjRDZ2xrZFhCdUlETUtDZ2t2THlCamIyNTBjbUZqZEhOY1FtRjBZMmhTWldkcGMzUnllUzUwY3pvek5EVUtDUzh2SUhSb2FYTXVZWE56WlhKMFFtRjBZMmhGZUdsemRITW9ZbUYwWTJoSlpDa0tDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmlZWFJqYUVsa09pQjFhVzUwTmpRS0NXTmhiR3h6ZFdJZ1lYTnpaWEowUW1GMFkyaEZlR2x6ZEhNS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUW1GMFkyaFNaV2RwYzNSeWVTNTBjem96TkRZS0NTOHZJSFJvYVhNdVlYTnpaWEowVG05MFFuSmxZV05vWldRb1ltRjBZMmhKWkNrS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaVlYUmphRWxrT2lCMWFXNTBOalFLQ1dOaGJHeHpkV0lnWVhOelpYSjBUbTkwUW5KbFlXTm9aV1FLQ2drdkx5QmpiMjUwY21GamRITmNRbUYwWTJoU1pXZHBjM1J5ZVM1MGN6b3pORGNLQ1M4dklHRnpjMlZ5ZENodVpYZERkWE4wYjJScFlXNGdJVDA5SUdkc2IySmhiSE11ZW1WeWIwRmtaSEpsYzNNc0lDZERkWE4wYjJScFlXNGdZMkZ1Ym05MElHSmxJSHBsY204Z1lXUmtjbVZ6Y3ljcENnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z2JtVjNRM1Z6ZEc5a2FXRnVPaUJCWkdSeVpYTnpDZ2xuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LQ1NFOUNnb0pMeThnUTNWemRHOWthV0Z1SUdOaGJtNXZkQ0JpWlNCNlpYSnZJR0ZrWkhKbGMzTUtDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4Q1lYUmphRkpsWjJsemRISjVMblJ6T2pNME9Rb0pMeThnYVhORGRYTjBiMlJwWVc0Z1BTQjBhR2x6TG5SNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVltRjBZMmhEZFhOMGIyUnBZVzRvWW1GMFkyaEpaQ2t1ZG1Gc2RXVUtDWFI0YmlCVFpXNWtaWElLQ1dKNWRHVmpJRFFnTHk4Z0lDSmlZeUlLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJpWVhSamFFbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXTnZibU5oZEFvSlltOTRYMmRsZEFvS0NTOHZJR0p2ZUNCMllXeDFaU0JrYjJWeklHNXZkQ0JsZUdsemREb2dkR2hwY3k1aVlYUmphRU4xYzNSdlpHbGhiaWhpWVhSamFFbGtLUzUyWVd4MVpRb0pZWE56WlhKMENnazlQUW9KWm5KaGJXVmZZblZ5ZVNBd0lDOHZJR2x6UTNWemRHOWthV0Z1T2lCaWIyOXNDZ29KTHk4Z1kyOXVkSEpoWTNSelhFSmhkR05vVW1WbmFYTjBjbmt1ZEhNNk16VXdDZ2t2THlCaGMzTmxjblFvQ2drdkx5QWdJQ0FnSUNCcGMwTjFjM1J2WkdsaGJpQjhmQW9KTHk4Z0lDQWdJQ0FnSUNCMGFHbHpMbU5oYkd4bGNraGhjMUp2YkdVb1FVUk5TVTVmUWtsVUtTQjhmQW9KTHk4Z0lDQWdJQ0FnSUNCMGFHbHpMbU5oYkd4bGNraGhjMUp2YkdVb1RVRk9WVVpCUTFSVlVrVlNYMEpKVkNrZ2ZId0tDUzh2SUNBZ0lDQWdJQ0FnZEdocGN5NWpZV3hzWlhKSVlYTlNiMnhsS0VSSlUxUlNTVUpWVkU5U1gwSkpWQ2tnZkh3S0NTOHZJQ0FnSUNBZ0lDQWdkR2hwY3k1allXeHNaWEpJWVhOU2IyeGxLRkJJUVZKTlFVTlpYMEpKVkNrc0Nna3ZMeUFnSUNBZ0lDQW5RMkZzYkdWeUlHNXZkQ0JoZFhSb2IzSnBlbVZrSUhSdklIUnlZVzV6Wm1WeUp3b0pMeThnSUNBZ0lDa0tDV1p5WVcxbFgyUnBaeUF3SUM4dklHbHpRM1Z6ZEc5a2FXRnVPaUJpYjI5c0NnbGtkWEFLQ1dKdWVpQXFjMnRwY0Y5dmNqVUtDV2x1ZEdNZ01DQXZMeUF4Q2dsallXeHNjM1ZpSUdOaGJHeGxja2hoYzFKdmJHVUtDWHg4Q2dvcWMydHBjRjl2Y2pVNkNnbGtkWEFLQ1dKdWVpQXFjMnRwY0Y5dmNqWUtDV2x1ZEdNZ015QXZMeUF5Q2dsallXeHNjM1ZpSUdOaGJHeGxja2hoYzFKdmJHVUtDWHg4Q2dvcWMydHBjRjl2Y2pZNkNnbGtkWEFLQ1dKdWVpQXFjMnRwY0Y5dmNqY0tDV2x1ZEdNZ055QXZMeUEwQ2dsallXeHNjM1ZpSUdOaGJHeGxja2hoYzFKdmJHVUtDWHg4Q2dvcWMydHBjRjl2Y2pjNkNnbGtkWEFLQ1dKdWVpQXFjMnRwY0Y5dmNqZ0tDV2x1ZEdNZ05TQXZMeUE0Q2dsallXeHNjM1ZpSUdOaGJHeGxja2hoYzFKdmJHVUtDWHg4Q2dvcWMydHBjRjl2Y2pnNkNna3ZMeUJEWVd4c1pYSWdibTkwSUdGMWRHaHZjbWw2WldRZ2RHOGdkSEpoYm5ObVpYSUtDV0Z6YzJWeWRBb0tDUzh2SUdOdmJuUnlZV04wYzF4Q1lYUmphRkpsWjJsemRISjVMblJ6T2pNMU9Rb0pMeThnY0hKbGRtbHZkWE5EZFhOMGIyUnBZVzRnUFNCMGFHbHpMbUpoZEdOb1EzVnpkRzlrYVdGdUtHSmhkR05vU1dRcExuWmhiSFZsQ2dsaWVYUmxZeUEwSUM4dklDQWlZbU1pQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWW1GMFkyaEpaRG9nZFdsdWREWTBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NXSnZlRjluWlhRS0Nna3ZMeUJpYjNnZ2RtRnNkV1VnWkc5bGN5QnViM1FnWlhocGMzUTZJSFJvYVhNdVltRjBZMmhEZFhOMGIyUnBZVzRvWW1GMFkyaEpaQ2t1ZG1Gc2RXVUtDV0Z6YzJWeWRBb0pabkpoYldWZlluVnllU0F4SUM4dklIQnlaWFpwYjNWelEzVnpkRzlrYVdGdU9pQmhaR1J5WlhOekNnb0pMeThnWTI5dWRISmhZM1J6WEVKaGRHTm9VbVZuYVhOMGNua3VkSE02TXpZd0Nna3ZMeUIwYUdsekxtSmhkR05vUTNWemRHOWthV0Z1S0dKaGRHTm9TV1FwTG5aaGJIVmxJRDBnYm1WM1EzVnpkRzlrYVdGdUNnbGllWFJsWXlBMElDOHZJQ0FpWW1NaUNnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1ltRjBZMmhKWkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjI1allYUUtDV1p5WVcxbFgyUnBaeUF0TWlBdkx5QnVaWGREZFhOMGIyUnBZVzQ2SUVGa1pISmxjM01LQ1dKdmVGOXdkWFFLQ2drdkx5QmpiMjUwY21GamRITmNRbUYwWTJoU1pXZHBjM1J5ZVM1MGN6b3pOakVLQ1M4dklIUm9hWE11WW1GMFkyaFZjR1JoZEdWa1FYUW9ZbUYwWTJoSlpDa3VkbUZzZFdVZ1BTQm5iRzlpWVd4ekxteGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvSllubDBaV01nT0NBdkx5QWdJbUoxSWdvSlpuSmhiV1ZmWkdsbklDMHhJQzh2SUdKaGRHTm9TV1E2SUhWcGJuUTJOQW9KYVhSdllnb0pZMjl1WTJGMENnbG5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2dscGRHOWlDZ2xpYjNoZmNIVjBDZ29KTHk4Z0ttbG1OMTlqYjI1a2FYUnBiMjRLQ1M4dklHTnZiblJ5WVdOMGMxeENZWFJqYUZKbFoybHpkSEo1TG5Sek9qTTJNd29KTHk4Z2RHaHBjeTVpWVhSamFGTjBZWFJsS0dKaGRHTm9TV1FwTG5aaGJIVmxJQ0U5UFNCVFZFRlVSVjlVVWtGT1UwWkZVbEpGUkFvSllubDBaV01nTXlBdkx5QWdJbUp6SWdvSlpuSmhiV1ZmWkdsbklDMHhJQzh2SUdKaGRHTm9TV1E2SUhWcGJuUTJOQW9KYVhSdllnb0pZMjl1WTJGMENnbGliM2hmWjJWMENnb0pMeThnWW05NElIWmhiSFZsSUdSdlpYTWdibTkwSUdWNGFYTjBPaUIwYUdsekxtSmhkR05vVTNSaGRHVW9ZbUYwWTJoSlpDa3VkbUZzZFdVS0NXRnpjMlZ5ZEFvSlluUnZhUW9KYVc1MFl5QXpJQzh2SURJS0NTRTlDZ2xpZWlBcWFXWTNYMlZ1WkFvS0NTOHZJQ3BwWmpkZlkyOXVjMlZ4ZFdWdWRBb0pMeThnWTI5dWRISmhZM1J6WEVKaGRHTm9VbVZuYVhOMGNua3VkSE02TXpZMENna3ZMeUIwYUdsekxuTmxkRUpoZEdOb1UzUmhkR1VvWW1GMFkyaEpaQ3dnVTFSQlZFVmZWRkpCVGxOR1JWSlNSVVFwQ2dscGJuUmpJRE1nTHk4Z01nb0pabkpoYldWZlpHbG5JQzB4SUM4dklHSmhkR05vU1dRNklIVnBiblEyTkFvSlkyRnNiSE4xWWlCelpYUkNZWFJqYUZOMFlYUmxDZ29xYVdZM1gyVnVaRG9LQ1M4dklHTnZiblJ5WVdOMGMxeENZWFJqYUZKbFoybHpkSEo1TG5Sek9qTTJPQW9KTHk4Z2FXUjRJRDBnZEdocGN5NWpkWE4wYjJSNVEyOTFiblFvWW1GMFkyaEpaQ2t1ZG1Gc2RXVUtDV0o1ZEdWaklEVWdMeThnSUNKall5SUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmlZWFJqYUVsa09pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KWW05NFgyZGxkQW9LQ1M4dklHSnZlQ0IyWVd4MVpTQmtiMlZ6SUc1dmRDQmxlR2x6ZERvZ2RHaHBjeTVqZFhOMGIyUjVRMjkxYm5Rb1ltRjBZMmhKWkNrdWRtRnNkV1VLQ1dGemMyVnlkQW9KWW5SdmFRb0pabkpoYldWZlluVnllU0F5SUM4dklHbGtlRG9nZFdsdWREWTBDZ29KTHk4Z1kyOXVkSEpoWTNSelhFSmhkR05vVW1WbmFYTjBjbmt1ZEhNNk16WTVDZ2t2THlCclpYa2dQU0JpWVhSamFFbGtJQ29nTVY4d01EQmZNREF3SUNzZ2FXUjRDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZbUYwWTJoSlpEb2dkV2x1ZERZMENnbHBiblJqSURRZ0x5OGdNVjh3TURCZk1EQXdDZ2txQ2dsbWNtRnRaVjlrYVdjZ01pQXZMeUJwWkhnNklIVnBiblEyTkFvSkt3b0pabkpoYldWZlluVnllU0F6SUM4dklHdGxlVG9nZFdsdWREWTBDZ29KTHk4Z1kyOXVkSEpoWTNSelhFSmhkR05vVW1WbmFYTjBjbmt1ZEhNNk16Y3hDZ2t2THlCMGFHbHpMbU4xYzNSdlpIbEdjbTl0S0d0bGVTa3VkbUZzZFdVZ1BTQndjbVYyYVc5MWMwTjFjM1J2WkdsaGJnb0pZbmwwWldNZ01Ua2dMeThnSUNKalppSUtDV1p5WVcxbFgyUnBaeUF6SUM4dklHdGxlVG9nZFdsdWREWTBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NXWnlZVzFsWDJScFp5QXhJQzh2SUhCeVpYWnBiM1Z6UTNWemRHOWthV0Z1T2lCaFpHUnlaWE56Q2dsaWIzaGZjSFYwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUpoZEdOb1VtVm5hWE4wY25rdWRITTZNemN5Q2drdkx5QjBhR2x6TG1OMWMzUnZaSGxVYnloclpYa3BMblpoYkhWbElEMGdibVYzUTNWemRHOWthV0Z1Q2dsaWVYUmxZeUF5TUNBdkx5QWdJbU4wSWdvSlpuSmhiV1ZmWkdsbklETWdMeThnYTJWNU9pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KWm5KaGJXVmZaR2xuSUMweUlDOHZJRzVsZDBOMWMzUnZaR2xoYmpvZ1FXUmtjbVZ6Y3dvSlltOTRYM0IxZEFvS0NTOHZJR052Ym5SeVlXTjBjMXhDWVhSamFGSmxaMmx6ZEhKNUxuUnpPak0zTXdvSkx5OGdkR2hwY3k1amRYTjBiMlI1UVdOMGIzSW9hMlY1S1M1MllXeDFaU0E5SUhSb2FYTXVkSGh1TG5ObGJtUmxjZ29KWW5sMFpXTWdNakVnTHk4Z0lDSmpZU0lLQ1daeVlXMWxYMlJwWnlBeklDOHZJR3RsZVRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjI1allYUUtDWFI0YmlCVFpXNWtaWElLQ1dKdmVGOXdkWFFLQ2drdkx5QmpiMjUwY21GamRITmNRbUYwWTJoU1pXZHBjM1J5ZVM1MGN6b3pOelFLQ1M4dklIUm9hWE11WTNWemRHOWtlVlJwYldWemRHRnRjQ2hyWlhrcExuWmhiSFZsSUQwZ1oyeHZZbUZzY3k1c1lYUmxjM1JVYVcxbGMzUmhiWEFLQ1dKNWRHVmpJREl5SUM4dklDQWlZM01pQ2dsbWNtRnRaVjlrYVdjZ015QXZMeUJyWlhrNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5dVkyRjBDZ2xuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NnbHBkRzlpQ2dsaWIzaGZjSFYwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUpoZEdOb1VtVm5hWE4wY25rdWRITTZNemMyQ2drdkx5QjBhR2x6TG1OMWMzUnZaSGxEYjNWdWRDaGlZWFJqYUVsa0tTNTJZV3gxWlNBOUlHbGtlQ0FySURFS0NXSjVkR1ZqSURVZ0x5OGdJQ0pqWXlJS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaVlYUmphRWxrT2lCMWFXNTBOalFLQ1dsMGIySUtDV052Ym1OaGRBb0pabkpoYldWZlpHbG5JRElnTHk4Z2FXUjRPaUIxYVc1ME5qUUtDV2x1ZEdNZ01DQXZMeUF4Q2drckNnbHBkRzlpQ2dsaWIzaGZjSFYwQ2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUpoZEdOb1VtVm5hWE4wY25rdWRITTZNemM0Q2drdkx5QnNiMmNvSjBOMWMzUnZaSGxVY21GdWMyWmxjbkpsWkNjcENnbHdkWE5vWW5sMFpYTWdNSGcwTXpjMU56TTNORFptTmpRM09UVTBOekkyTVRabE56TTJOalkxTnpJM01qWTFOalFnTHk4Z0lrTjFjM1J2WkhsVWNtRnVjMlpsY25KbFpDSUtDV3h2WndvSmNtVjBjM1ZpQ2dvdkx5QmpiMjVtYVhKdFJHVnNhWFpsY25rb2RXbHVkRFkwS1hadmFXUUtLbUZpYVY5eWIzVjBaVjlqYjI1bWFYSnRSR1ZzYVhabGNuazZDZ2t2THlCaVlYUmphRWxrT2lCMWFXNTBOalFLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtDV0owYjJrS0Nna3ZMeUJsZUdWamRYUmxJR052Ym1acGNtMUVaV3hwZG1WeWVTaDFhVzUwTmpRcGRtOXBaQW9KWTJGc2JITjFZaUJqYjI1bWFYSnRSR1ZzYVhabGNua0tDV2x1ZEdNZ01DQXZMeUF4Q2dseVpYUjFjbTRLQ2k4dklHTnZibVpwY20xRVpXeHBkbVZ5ZVNoaVlYUmphRWxrT2lCMWFXNTBOalFwT2lCMmIybGtDaTh2Q2k4dklGQm9ZWEp0WVdONUlHTnZibVpwY20xeklHWnBibUZzSUdSbGJHbDJaWEo1SUc5bUlHRWdZbUYwWTJndUNpOHZJRTl1YkhrZ1lTQndhR0Z5YldGamVTMXliMnhsSUdodmJHUmxjaUIzYUc4Z2FYTWdkR2hsSUdOMWNuSmxiblFnWTNWemRHOWthV0Z1SUNodmNpQmhaRzFwYmlrdUNtTnZibVpwY20xRVpXeHBkbVZ5ZVRvS0NYQnliM1J2SURFZ01Bb0tDUzh2SUdOdmJuUnlZV04wYzF4Q1lYUmphRkpsWjJsemRISjVMblJ6T2pNNU1Bb0pMeThnZEdocGN5NWhjM05sY25SQ1lYUmphRVY0YVhOMGN5aGlZWFJqYUVsa0tRb0pabkpoYldWZlpHbG5JQzB4SUM4dklHSmhkR05vU1dRNklIVnBiblEyTkFvSlkyRnNiSE4xWWlCaGMzTmxjblJDWVhSamFFVjRhWE4wY3dvS0NTOHZJR052Ym5SeVlXTjBjMXhDWVhSamFGSmxaMmx6ZEhKNUxuUnpPak01TVFvSkx5OGdkR2hwY3k1aGMzTmxjblJPYjNSQ2NtVmhZMmhsWkNoaVlYUmphRWxrS1FvSlpuSmhiV1ZmWkdsbklDMHhJQzh2SUdKaGRHTm9TV1E2SUhWcGJuUTJOQW9KWTJGc2JITjFZaUJoYzNObGNuUk9iM1JDY21WaFkyaGxaQW9LQ1M4dklHTnZiblJ5WVdOMGMxeENZWFJqYUZKbFoybHpkSEo1TG5Sek9qTTVNZ29KTHk4Z1lYTnpaWEowS0hSb2FYTXVZMkZzYkdWeVNHRnpVbTlzWlNoUVNFRlNUVUZEV1Y5Q1NWUXBMQ0FuVDI1c2VTQndhR0Z5YldGamVTQmpZVzRnWTI5dVptbHliU0JrWld4cGRtVnllU2NwQ2dscGJuUmpJRFVnTHk4Z09Bb0pZMkZzYkhOMVlpQmpZV3hzWlhKSVlYTlNiMnhsQ2dvSkx5OGdUMjVzZVNCd2FHRnliV0ZqZVNCallXNGdZMjl1Wm1seWJTQmtaV3hwZG1WeWVRb0pZWE56WlhKMENnb0pMeThnWTI5dWRISmhZM1J6WEVKaGRHTm9VbVZuYVhOMGNua3VkSE02TXprekNna3ZMeUJoYzNObGNuUW9DZ2t2THlBZ0lDQWdJQ0IwYUdsekxtSmhkR05vUTNWemRHOWthV0Z1S0dKaGRHTm9TV1FwTG5aaGJIVmxJRDA5UFNCMGFHbHpMblI0Ymk1elpXNWtaWElnZkh3S0NTOHZJQ0FnSUNBZ0lDQWdkR2hwY3k1allXeHNaWEpJWVhOU2IyeGxLRUZFVFVsT1gwSkpWQ2tzQ2drdkx5QWdJQ0FnSUNBblEyRnNiR1Z5SUdseklHNXZkQ0JqZFhKeVpXNTBJR04xYzNSdlpHbGhiaWNLQ1M4dklDQWdJQ0FwQ2dsaWVYUmxZeUEwSUM4dklDQWlZbU1pQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWW1GMFkyaEpaRG9nZFdsdWREWTBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NXSnZlRjluWlhRS0Nna3ZMeUJpYjNnZ2RtRnNkV1VnWkc5bGN5QnViM1FnWlhocGMzUTZJSFJvYVhNdVltRjBZMmhEZFhOMGIyUnBZVzRvWW1GMFkyaEpaQ2t1ZG1Gc2RXVUtDV0Z6YzJWeWRBb0pkSGh1SUZObGJtUmxjZ29KUFQwS0NXUjFjQW9KWW01NklDcHphMmx3WDI5eU9Rb0phVzUwWXlBd0lDOHZJREVLQ1dOaGJHeHpkV0lnWTJGc2JHVnlTR0Z6VW05c1pRb0pmSHdLQ2lwemEybHdYMjl5T1RvS0NTOHZJRU5oYkd4bGNpQnBjeUJ1YjNRZ1kzVnljbVZ1ZENCamRYTjBiMlJwWVc0S0NXRnpjMlZ5ZEFvS0NTOHZJR052Ym5SeVlXTjBjMXhDWVhSamFGSmxaMmx6ZEhKNUxuUnpPak01T0FvSkx5OGdkR2hwY3k1elpYUkNZWFJqYUZOMFlYUmxLR0poZEdOb1NXUXNJRk5VUVZSRlgwUkZURWxXUlZKRlJDa0tDWEIxYzJocGJuUWdNd29KWm5KaGJXVmZaR2xuSUMweElDOHZJR0poZEdOb1NXUTZJSFZwYm5RMk5Bb0pZMkZzYkhOMVlpQnpaWFJDWVhSamFGTjBZWFJsQ2dseVpYUnpkV0lLQ2k4dklHZGxkRUpoZEdOb0tIVnBiblEyTkNrb1lubDBaVnRkTEdGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5Da0tLbUZpYVY5eWIzVjBaVjluWlhSQ1lYUmphRG9LQ1M4dklGUm9aU0JCUWtrZ2NtVjBkWEp1SUhCeVpXWnBlQW9KWW5sMFpXTWdNaUF2THlBd2VERTFNV1kzWXpjMUNnb0pMeThnWW1GMFkyaEpaRG9nZFdsdWREWTBDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENnbGlkRzlwQ2dvSkx5OGdaWGhsWTNWMFpTQm5aWFJDWVhSamFDaDFhVzUwTmpRcEtHSjVkR1ZiWFN4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXBDZ2xqWVd4c2MzVmlJR2RsZEVKaGRHTm9DZ2xqYjI1allYUUtDV3h2WndvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnWjJWMFFtRjBZMmdvWW1GMFkyaEpaRG9nZFdsdWREWTBLVG9nVzJKNWRHVnpMQ0JCWkdSeVpYTnpMQ0IxYVc1ME5qUXNJSFZwYm5RMk5GMEtMeThLTHk4Z1IyVjBJR052Y21VZ1ltRjBZMmdnYVc1bWJ5QW9aSEoxWnlCdVlXMWxMQ0J0WVc1MVptRmpkSFZ5WlhJc0lITjBZWFJsTENCamNtVmhkR1ZrSUhScGJXVnpkR0Z0Y0NrdUNtZGxkRUpoZEdOb09nb0pjSEp2ZEc4Z01TQXhDZ29KTHk4Z1kyOXVkSEpoWTNSelhFSmhkR05vVW1WbmFYTjBjbmt1ZEhNNk5EQTVDZ2t2THlCMGFHbHpMbUZ6YzJWeWRFSmhkR05vUlhocGMzUnpLR0poZEdOb1NXUXBDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZbUYwWTJoSlpEb2dkV2x1ZERZMENnbGpZV3hzYzNWaUlHRnpjMlZ5ZEVKaGRHTm9SWGhwYzNSekNnb0pMeThnWTI5dWRISmhZM1J6WEVKaGRHTm9VbVZuYVhOMGNua3VkSE02TkRFd0Nna3ZMeUJ5WlhSMWNtNGdXd29KTHk4Z0lDQWdJQ0FnZEdocGN5NWlZWFJqYUVSeWRXZE9ZVzFsS0dKaGRHTm9TV1FwTG5aaGJIVmxMQW9KTHk4Z0lDQWdJQ0FnZEdocGN5NWlZWFJqYUUxaGJuVm1ZV04wZFhKbGNpaGlZWFJqYUVsa0tTNTJZV3gxWlN3S0NTOHZJQ0FnSUNBZ0lIUm9hWE11WW1GMFkyaFRkR0YwWlNoaVlYUmphRWxrS1M1MllXeDFaU3dLQ1M4dklDQWdJQ0FnSUhSb2FYTXVZbUYwWTJoRGNtVmhkR1ZrUVhRb1ltRjBZMmhKWkNrdWRtRnNkV1VzQ2drdkx5QWdJQ0FnWFRzS0NXSjVkR1ZqSURBZ0x5OGdJR2x1YVhScFlXd2dhR1ZoWkFvSllubDBaV01nTUNBdkx5QWdhVzVwZEdsaGJDQjBZV2xzQ2dsd2RYTm9ZbmwwWlhNZ01IZ3dNRE15SUM4dklHbHVhWFJwWVd3Z2FHVmhaQ0J2Wm1aelpYUUtDV0o1ZEdWaklERXhJQzh2SUNBaVltNGlDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZbUYwWTJoSlpEb2dkV2x1ZERZMENnbHBkRzlpQ2dsamIyNWpZWFFLQ1dKdmVGOW5aWFFLQ2drdkx5QmliM2dnZG1Gc2RXVWdaRzlsY3lCdWIzUWdaWGhwYzNRNklIUm9hWE11WW1GMFkyaEVjblZuVG1GdFpTaGlZWFJqYUVsa0tTNTJZV3gxWlFvSllYTnpaWEowQ2dsa2RYQUtDV3hsYmdvSmFYUnZZZ29KWlhoMGNtRmpkQ0EySURJS0NYTjNZWEFLQ1dOdmJtTmhkQW9KWTJGc2JITjFZaUFxY0hKdlkyVnpjMTlrZVc1aGJXbGpYM1IxY0d4bFgyVnNaVzFsYm5RS0NXSjVkR1ZqSURFeUlDOHZJQ0FpWW0waUNnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1ltRjBZMmhKWkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjI1allYUUtDV0p2ZUY5blpYUUtDZ2t2THlCaWIzZ2dkbUZzZFdVZ1pHOWxjeUJ1YjNRZ1pYaHBjM1E2SUhSb2FYTXVZbUYwWTJoTllXNTFabUZqZEhWeVpYSW9ZbUYwWTJoSlpDa3VkbUZzZFdVS0NXRnpjMlZ5ZEFvSlkyRnNiSE4xWWlBcWNISnZZMlZ6YzE5emRHRjBhV05mZEhWd2JHVmZaV3hsYldWdWRBb0pZbmwwWldNZ015QXZMeUFnSW1Keklnb0pabkpoYldWZlpHbG5JQzB4SUM4dklHSmhkR05vU1dRNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5dVkyRjBDZ2xpYjNoZloyVjBDZ29KTHk4Z1ltOTRJSFpoYkhWbElHUnZaWE1nYm05MElHVjRhWE4wT2lCMGFHbHpMbUpoZEdOb1UzUmhkR1VvWW1GMFkyaEpaQ2t1ZG1Gc2RXVUtDV0Z6YzJWeWRBb0pZblJ2YVFvSmFYUnZZZ29KWTJGc2JITjFZaUFxY0hKdlkyVnpjMTl6ZEdGMGFXTmZkSFZ3YkdWZlpXeGxiV1Z1ZEFvSllubDBaV01nTVRNZ0x5OGdJQ0ppZENJS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaVlYUmphRWxrT2lCMWFXNTBOalFLQ1dsMGIySUtDV052Ym1OaGRBb0pZbTk0WDJkbGRBb0tDUzh2SUdKdmVDQjJZV3gxWlNCa2IyVnpJRzV2ZENCbGVHbHpkRG9nZEdocGN5NWlZWFJqYUVOeVpXRjBaV1JCZENoaVlYUmphRWxrS1M1MllXeDFaUW9KWVhOelpYSjBDZ2xpZEc5cENnbHBkRzlpQ2dsallXeHNjM1ZpSUNwd2NtOWpaWE56WDNOMFlYUnBZMTkwZFhCc1pWOWxiR1Z0Wlc1MENnbHdiM0FnTHk4Z2NHOXdJR2hsWVdRZ2IyWm1jMlYwQ2dsamIyNWpZWFFnTHk4Z1kyOXVZMkYwSUdobFlXUWdZVzVrSUhSaGFXd0tDWEpsZEhOMVlnb0tMeThnWjJWMFFtRjBZMmhFWlhSaGFXeHpLSFZwYm5RMk5Da29ZbmwwWlZ0ZExHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da0tLbUZpYVY5eWIzVjBaVjluWlhSQ1lYUmphRVJsZEdGcGJITTZDZ2t2THlCVWFHVWdRVUpKSUhKbGRIVnliaUJ3Y21WbWFYZ0tDV0o1ZEdWaklESWdMeThnTUhneE5URm1OMk0zTlFvS0NTOHZJR0poZEdOb1NXUTZJSFZwYm5RMk5Bb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvSlluUnZhUW9LQ1M4dklHVjRaV04xZEdVZ1oyVjBRbUYwWTJoRVpYUmhhV3h6S0hWcGJuUTJOQ2tvWW5sMFpWdGRMR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tLQ1dOaGJHeHpkV0lnWjJWMFFtRjBZMmhFWlhSaGFXeHpDZ2xqYjI1allYUUtDV3h2WndvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnWjJWMFFtRjBZMmhFWlhSaGFXeHpLR0poZEdOb1NXUTZJSFZwYm5RMk5DazZJRnRpZVhSbGN5d2dRV1JrY21WemN5d2dRV1JrY21WemN5d2dkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkYwS0x5OEtMeThnUjJWMElHWjFiR3dnWW1GMFkyZ2daR1YwWVdsc2N5NEtaMlYwUW1GMFkyaEVaWFJoYVd4ek9nb0pjSEp2ZEc4Z01TQXhDZ29KTHk4Z1kyOXVkSEpoWTNSelhFSmhkR05vVW1WbmFYTjBjbmt1ZEhNNk5ESTBDZ2t2THlCMGFHbHpMbUZ6YzJWeWRFSmhkR05vUlhocGMzUnpLR0poZEdOb1NXUXBDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZbUYwWTJoSlpEb2dkV2x1ZERZMENnbGpZV3hzYzNWaUlHRnpjMlZ5ZEVKaGRHTm9SWGhwYzNSekNnb0pMeThnWTI5dWRISmhZM1J6WEVKaGRHTm9VbVZuYVhOMGNua3VkSE02TkRJMUNna3ZMeUJ5WlhSMWNtNGdXd29KTHk4Z0lDQWdJQ0FnZEdocGN5NWlZWFJqYUVSeWRXZE9ZVzFsS0dKaGRHTm9TV1FwTG5aaGJIVmxMQW9KTHk4Z0lDQWdJQ0FnZEdocGN5NWlZWFJqYUUxaGJuVm1ZV04wZFhKbGNpaGlZWFJqYUVsa0tTNTJZV3gxWlN3S0NTOHZJQ0FnSUNBZ0lIUm9hWE11WW1GMFkyaERkWE4wYjJScFlXNG9ZbUYwWTJoSlpDa3VkbUZzZFdVc0Nna3ZMeUFnSUNBZ0lDQjBhR2x6TG1KaGRHTm9VM1JoZEdVb1ltRjBZMmhKWkNrdWRtRnNkV1VzQ2drdkx5QWdJQ0FnSUNCMGFHbHpMbUpoZEdOb1EzSmxZWFJsWkVGMEtHSmhkR05vU1dRcExuWmhiSFZsTEFvSkx5OGdJQ0FnSUNBZ2RHaHBjeTVpWVhSamFGVndaR0YwWldSQmRDaGlZWFJqYUVsa0tTNTJZV3gxWlN3S0NTOHZJQ0FnSUNCZE93b0pZbmwwWldNZ01DQXZMeUFnYVc1cGRHbGhiQ0JvWldGa0NnbGllWFJsWXlBd0lDOHZJQ0JwYm1sMGFXRnNJSFJoYVd3S0NYQjFjMmhpZVhSbGN5QXdlREF3TldFZ0x5OGdhVzVwZEdsaGJDQm9aV0ZrSUc5bVpuTmxkQW9KWW5sMFpXTWdNVEVnTHk4Z0lDSmliaUlLQ1daeVlXMWxYMlJwWnlBdE1TQXZMeUJpWVhSamFFbGtPaUIxYVc1ME5qUUtDV2wwYjJJS0NXTnZibU5oZEFvSlltOTRYMmRsZEFvS0NTOHZJR0p2ZUNCMllXeDFaU0JrYjJWeklHNXZkQ0JsZUdsemREb2dkR2hwY3k1aVlYUmphRVJ5ZFdkT1lXMWxLR0poZEdOb1NXUXBMblpoYkhWbENnbGhjM05sY25RS0NXUjFjQW9KYkdWdUNnbHBkRzlpQ2dsbGVIUnlZV04wSURZZ01nb0pjM2RoY0FvSlkyOXVZMkYwQ2dsallXeHNjM1ZpSUNwd2NtOWpaWE56WDJSNWJtRnRhV05mZEhWd2JHVmZaV3hsYldWdWRBb0pZbmwwWldNZ01USWdMeThnSUNKaWJTSUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmlZWFJqYUVsa09pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KWW05NFgyZGxkQW9LQ1M4dklHSnZlQ0IyWVd4MVpTQmtiMlZ6SUc1dmRDQmxlR2x6ZERvZ2RHaHBjeTVpWVhSamFFMWhiblZtWVdOMGRYSmxjaWhpWVhSamFFbGtLUzUyWVd4MVpRb0pZWE56WlhKMENnbGpZV3hzYzNWaUlDcHdjbTlqWlhOelgzTjBZWFJwWTE5MGRYQnNaVjlsYkdWdFpXNTBDZ2xpZVhSbFl5QTBJQzh2SUNBaVltTWlDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZbUYwWTJoSlpEb2dkV2x1ZERZMENnbHBkRzlpQ2dsamIyNWpZWFFLQ1dKdmVGOW5aWFFLQ2drdkx5QmliM2dnZG1Gc2RXVWdaRzlsY3lCdWIzUWdaWGhwYzNRNklIUm9hWE11WW1GMFkyaERkWE4wYjJScFlXNG9ZbUYwWTJoSlpDa3VkbUZzZFdVS0NXRnpjMlZ5ZEFvSlkyRnNiSE4xWWlBcWNISnZZMlZ6YzE5emRHRjBhV05mZEhWd2JHVmZaV3hsYldWdWRBb0pZbmwwWldNZ015QXZMeUFnSW1Keklnb0pabkpoYldWZlpHbG5JQzB4SUM4dklHSmhkR05vU1dRNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5dVkyRjBDZ2xpYjNoZloyVjBDZ29KTHk4Z1ltOTRJSFpoYkhWbElHUnZaWE1nYm05MElHVjRhWE4wT2lCMGFHbHpMbUpoZEdOb1UzUmhkR1VvWW1GMFkyaEpaQ2t1ZG1Gc2RXVUtDV0Z6YzJWeWRBb0pZblJ2YVFvSmFYUnZZZ29KWTJGc2JITjFZaUFxY0hKdlkyVnpjMTl6ZEdGMGFXTmZkSFZ3YkdWZlpXeGxiV1Z1ZEFvSllubDBaV01nTVRNZ0x5OGdJQ0ppZENJS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaVlYUmphRWxrT2lCMWFXNTBOalFLQ1dsMGIySUtDV052Ym1OaGRBb0pZbTk0WDJkbGRBb0tDUzh2SUdKdmVDQjJZV3gxWlNCa2IyVnpJRzV2ZENCbGVHbHpkRG9nZEdocGN5NWlZWFJqYUVOeVpXRjBaV1JCZENoaVlYUmphRWxrS1M1MllXeDFaUW9KWVhOelpYSjBDZ2xpZEc5cENnbHBkRzlpQ2dsallXeHNjM1ZpSUNwd2NtOWpaWE56WDNOMFlYUnBZMTkwZFhCc1pWOWxiR1Z0Wlc1MENnbGllWFJsWXlBNElDOHZJQ0FpWW5VaUNnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1ltRjBZMmhKWkRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjI1allYUUtDV0p2ZUY5blpYUUtDZ2t2THlCaWIzZ2dkbUZzZFdVZ1pHOWxjeUJ1YjNRZ1pYaHBjM1E2SUhSb2FYTXVZbUYwWTJoVmNHUmhkR1ZrUVhRb1ltRjBZMmhKWkNrdWRtRnNkV1VLQ1dGemMyVnlkQW9KWW5SdmFRb0phWFJ2WWdvSlkyRnNiSE4xWWlBcWNISnZZMlZ6YzE5emRHRjBhV05mZEhWd2JHVmZaV3hsYldWdWRBb0pjRzl3SUM4dklIQnZjQ0JvWldGa0lHOW1abk5sZEFvSlkyOXVZMkYwSUM4dklHTnZibU5oZENCb1pXRmtJR0Z1WkNCMFlXbHNDZ2x5WlhSemRXSUtDaTh2SUdkbGRFTjFjM1J2WkhsU1pXTnZjbVFvZFdsdWREWTBMSFZwYm5RMk5Da29ZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkRFkwS1FvcVlXSnBYM0p2ZFhSbFgyZGxkRU4xYzNSdlpIbFNaV052Y21RNkNna3ZMeUJVYUdVZ1FVSkpJSEpsZEhWeWJpQndjbVZtYVhnS0NXSjVkR1ZqSURJZ0x5OGdNSGd4TlRGbU4yTTNOUW9LQ1M4dklHbHVaR1Y0T2lCMWFXNTBOalFLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtDV0owYjJrS0Nna3ZMeUJpWVhSamFFbGtPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXSjBiMmtLQ2drdkx5QmxlR1ZqZFhSbElHZGxkRU4xYzNSdlpIbFNaV052Y21Rb2RXbHVkRFkwTEhWcGJuUTJOQ2tvWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERZMEtRb0pZMkZzYkhOMVlpQm5aWFJEZFhOMGIyUjVVbVZqYjNKa0NnbGpiMjVqWVhRS0NXeHZad29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdaMlYwUTNWemRHOWtlVkpsWTI5eVpDaGlZWFJqYUVsa09pQjFhVzUwTmpRc0lHbHVaR1Y0T2lCMWFXNTBOalFwT2lCYlFXUmtjbVZ6Y3l3Z1FXUmtjbVZ6Y3l3Z1FXUmtjbVZ6Y3l3Z2RXbHVkRFkwWFFvdkx3b3ZMeUJIWlhRZ1lTQnphVzVuYkdVZ1kzVnpkRzlrZVNCeVpXTnZjbVFnWW5rZ1ltRjBZMmdnU1VRZ1lXNWtJR2x1WkdWNExncG5aWFJEZFhOMGIyUjVVbVZqYjNKa09nb0pjSEp2ZEc4Z01pQXhDZ29KTHk4Z1VIVnphQ0JsYlhCMGVTQmllWFJsY3lCaFpuUmxjaUIwYUdVZ1puSmhiV1VnY0c5cGJuUmxjaUIwYnlCeVpYTmxjblpsSUhOd1lXTmxJR1p2Y2lCc2IyTmhiQ0IyWVhKcFlXSnNaWE1LQ1dKNWRHVmpJREFnTHk4Z01IZ0tDZ2t2THlCamIyNTBjbUZqZEhOY1FtRjBZMmhTWldkcGMzUnllUzUwY3pvME5ESUtDUzh2SUhSb2FYTXVZWE56WlhKMFFtRjBZMmhGZUdsemRITW9ZbUYwWTJoSlpDa0tDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmlZWFJqYUVsa09pQjFhVzUwTmpRS0NXTmhiR3h6ZFdJZ1lYTnpaWEowUW1GMFkyaEZlR2x6ZEhNS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUW1GMFkyaFNaV2RwYzNSeWVTNTBjem8wTkRNS0NTOHZJR0Z6YzJWeWRDaHBibVJsZUNBOElIUm9hWE11WTNWemRHOWtlVU52ZFc1MEtHSmhkR05vU1dRcExuWmhiSFZsTENBblNXNWtaWGdnYjNWMElHOW1JSEpoYm1kbEp5a0tDV1p5WVcxbFgyUnBaeUF0TWlBdkx5QnBibVJsZURvZ2RXbHVkRFkwQ2dsaWVYUmxZeUExSUM4dklDQWlZMk1pQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWW1GMFkyaEpaRG9nZFdsdWREWTBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NXSnZlRjluWlhRS0Nna3ZMeUJpYjNnZ2RtRnNkV1VnWkc5bGN5QnViM1FnWlhocGMzUTZJSFJvYVhNdVkzVnpkRzlrZVVOdmRXNTBLR0poZEdOb1NXUXBMblpoYkhWbENnbGhjM05sY25RS0NXSjBiMmtLQ1R3S0Nna3ZMeUJKYm1SbGVDQnZkWFFnYjJZZ2NtRnVaMlVLQ1dGemMyVnlkQW9LQ1M4dklHTnZiblJ5WVdOMGMxeENZWFJqYUZKbFoybHpkSEo1TG5Sek9qUTBOQW9KTHk4Z2EyVjVJRDBnWW1GMFkyaEpaQ0FxSURGZk1EQXdYekF3TUNBcklHbHVaR1Y0Q2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWW1GMFkyaEpaRG9nZFdsdWREWTBDZ2xwYm5SaklEUWdMeThnTVY4d01EQmZNREF3Q2drcUNnbG1jbUZ0WlY5a2FXY2dMVElnTHk4Z2FXNWtaWGc2SUhWcGJuUTJOQW9KS3dvSlpuSmhiV1ZmWW5WeWVTQXdJQzh2SUd0bGVUb2dkV2x1ZERZMENnb0pMeThnWTI5dWRISmhZM1J6WEVKaGRHTm9VbVZuYVhOMGNua3VkSE02TkRRMUNna3ZMeUJ5WlhSMWNtNGdXd29KTHk4Z0lDQWdJQ0FnZEdocGN5NWpkWE4wYjJSNVJuSnZiU2hyWlhrcExuWmhiSFZsTEFvSkx5OGdJQ0FnSUNBZ2RHaHBjeTVqZFhOMGIyUjVWRzhvYTJWNUtTNTJZV3gxWlN3S0NTOHZJQ0FnSUNBZ0lIUm9hWE11WTNWemRHOWtlVUZqZEc5eUtHdGxlU2t1ZG1Gc2RXVXNDZ2t2THlBZ0lDQWdJQ0IwYUdsekxtTjFjM1J2WkhsVWFXMWxjM1JoYlhBb2EyVjVLUzUyWVd4MVpTd0tDUzh2SUNBZ0lDQmRPd29KWW5sMFpXTWdNVGtnTHk4Z0lDSmpaaUlLQ1daeVlXMWxYMlJwWnlBd0lDOHZJR3RsZVRvZ2RXbHVkRFkwQ2dscGRHOWlDZ2xqYjI1allYUUtDV0p2ZUY5blpYUUtDZ2t2THlCaWIzZ2dkbUZzZFdVZ1pHOWxjeUJ1YjNRZ1pYaHBjM1E2SUhSb2FYTXVZM1Z6ZEc5a2VVWnliMjBvYTJWNUtTNTJZV3gxWlFvSllYTnpaWEowQ2dsaWVYUmxZeUF5TUNBdkx5QWdJbU4wSWdvSlpuSmhiV1ZmWkdsbklEQWdMeThnYTJWNU9pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KWW05NFgyZGxkQW9LQ1M4dklHSnZlQ0IyWVd4MVpTQmtiMlZ6SUc1dmRDQmxlR2x6ZERvZ2RHaHBjeTVqZFhOMGIyUjVWRzhvYTJWNUtTNTJZV3gxWlFvSllYTnpaWEowQ2dsamIyNWpZWFFLQ1dKNWRHVmpJREl4SUM4dklDQWlZMkVpQ2dsbWNtRnRaVjlrYVdjZ01DQXZMeUJyWlhrNklIVnBiblEyTkFvSmFYUnZZZ29KWTI5dVkyRjBDZ2xpYjNoZloyVjBDZ29KTHk4Z1ltOTRJSFpoYkhWbElHUnZaWE1nYm05MElHVjRhWE4wT2lCMGFHbHpMbU4xYzNSdlpIbEJZM1J2Y2loclpYa3BMblpoYkhWbENnbGhjM05sY25RS0NXTnZibU5oZEFvSllubDBaV01nTWpJZ0x5OGdJQ0pqY3lJS0NXWnlZVzFsWDJScFp5QXdJQzh2SUd0bGVUb2dkV2x1ZERZMENnbHBkRzlpQ2dsamIyNWpZWFFLQ1dKdmVGOW5aWFFLQ2drdkx5QmliM2dnZG1Gc2RXVWdaRzlsY3lCdWIzUWdaWGhwYzNRNklIUm9hWE11WTNWemRHOWtlVlJwYldWemRHRnRjQ2hyWlhrcExuWmhiSFZsQ2dsaGMzTmxjblFLQ1dKMGIya0tDV2wwYjJJS0NXTnZibU5oZEFvS0NTOHZJSE5sZENCMGFHVWdjM1ZpY205MWRHbHVaU0J5WlhSMWNtNGdkbUZzZFdVS0NXWnlZVzFsWDJKMWNua2dNQW9KY21WMGMzVmlDZ292THlCblpYUkNjbVZoWTJoU1pXTnZjbVFvZFdsdWREWTBMSFZwYm5RMk5Da29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzWVdSa2NtVnpjeXhpZVhSbFd6TXlYU2tLS21GaWFWOXliM1YwWlY5blpYUkNjbVZoWTJoU1pXTnZjbVE2Q2drdkx5QlVhR1VnUVVKSklISmxkSFZ5YmlCd2NtVm1hWGdLQ1dKNWRHVmpJRElnTHk4Z01IZ3hOVEZtTjJNM05Rb0tDUzh2SUdsdVpHVjRPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0NXSjBiMmtLQ2drdkx5QmlZWFJqYUVsa09pQjFhVzUwTmpRS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLQ1dKMGIya0tDZ2t2THlCbGVHVmpkWFJsSUdkbGRFSnlaV0ZqYUZKbFkyOXlaQ2gxYVc1ME5qUXNkV2x1ZERZMEtTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3hoWkdSeVpYTnpMR0o1ZEdWYk16SmRLUW9KWTJGc2JITjFZaUJuWlhSQ2NtVmhZMmhTWldOdmNtUUtDV052Ym1OaGRBb0piRzluQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJuWlhSQ2NtVmhZMmhTWldOdmNtUW9ZbUYwWTJoSlpEb2dkV2x1ZERZMExDQnBibVJsZURvZ2RXbHVkRFkwS1RvZ1czVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalFzSUVGa1pISmxjM01zSUdKNWRHVnpNekpkQ2k4dkNpOHZJRWRsZENCaElITnBibWRzWlNCaWNtVmhZMmdnY21WamIzSmtJR0o1SUdKaGRHTm9JRWxFSUdGdVpDQnBibVJsZUM0S1oyVjBRbkpsWVdOb1VtVmpiM0prT2dvSmNISnZkRzhnTWlBeENnb0pMeThnVUhWemFDQmxiWEIwZVNCaWVYUmxjeUJoWm5SbGNpQjBhR1VnWm5KaGJXVWdjRzlwYm5SbGNpQjBieUJ5WlhObGNuWmxJSE53WVdObElHWnZjaUJzYjJOaGJDQjJZWEpwWVdKc1pYTUtDV0o1ZEdWaklEQWdMeThnTUhnS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUW1GMFkyaFNaV2RwYzNSeWVTNTBjem8wTmpBS0NTOHZJSFJvYVhNdVlYTnpaWEowUW1GMFkyaEZlR2x6ZEhNb1ltRjBZMmhKWkNrS0NXWnlZVzFsWDJScFp5QXRNU0F2THlCaVlYUmphRWxrT2lCMWFXNTBOalFLQ1dOaGJHeHpkV0lnWVhOelpYSjBRbUYwWTJoRmVHbHpkSE1LQ2drdkx5QmpiMjUwY21GamRITmNRbUYwWTJoU1pXZHBjM1J5ZVM1MGN6bzBOakVLQ1M4dklHRnpjMlZ5ZENocGJtUmxlQ0E4SUhSb2FYTXVZbkpsWVdOb1EyOTFiblFvWW1GMFkyaEpaQ2t1ZG1Gc2RXVXNJQ2RKYm1SbGVDQnZkWFFnYjJZZ2NtRnVaMlVuS1FvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUdsdVpHVjRPaUIxYVc1ME5qUUtDV0o1ZEdWaklEWWdMeThnSUNKNFl5SUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmlZWFJqYUVsa09pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KWW05NFgyZGxkQW9LQ1M4dklHSnZlQ0IyWVd4MVpTQmtiMlZ6SUc1dmRDQmxlR2x6ZERvZ2RHaHBjeTVpY21WaFkyaERiM1Z1ZENoaVlYUmphRWxrS1M1MllXeDFaUW9KWVhOelpYSjBDZ2xpZEc5cENnazhDZ29KTHk4Z1NXNWtaWGdnYjNWMElHOW1JSEpoYm1kbENnbGhjM05sY25RS0Nna3ZMeUJqYjI1MGNtRmpkSE5jUW1GMFkyaFNaV2RwYzNSeWVTNTBjem8wTmpJS0NTOHZJR3RsZVNBOUlHSmhkR05vU1dRZ0tpQXhYekF3TUY4d01EQWdLeUJwYm1SbGVBb0pabkpoYldWZlpHbG5JQzB4SUM4dklHSmhkR05vU1dRNklIVnBiblEyTkFvSmFXNTBZeUEwSUM4dklERmZNREF3WHpBd01Bb0pLZ29KWm5KaGJXVmZaR2xuSUMweUlDOHZJR2x1WkdWNE9pQjFhVzUwTmpRS0NTc0tDV1p5WVcxbFgySjFjbmtnTUNBdkx5QnJaWGs2SUhWcGJuUTJOQW9LQ1M4dklHTnZiblJ5WVdOMGMxeENZWFJqYUZKbFoybHpkSEo1TG5Sek9qUTJNd29KTHk4Z2NtVjBkWEp1SUZzS0NTOHZJQ0FnSUNBZ0lIUm9hWE11WW5KbFlXTm9WR1Z0Y0NoclpYa3BMblpoYkhWbExBb0pMeThnSUNBZ0lDQWdkR2hwY3k1aWNtVmhZMmhQWW5ObGNuWmxaRUYwS0d0bGVTa3VkbUZzZFdVc0Nna3ZMeUFnSUNBZ0lDQjBhR2x6TG1KeVpXRmphRkpsWTI5eVpHVmtRWFFvYTJWNUtTNTJZV3gxWlN3S0NTOHZJQ0FnSUNBZ0lIUm9hWE11WW5KbFlXTm9VMlZ1YzI5eUtHdGxlU2t1ZG1Gc2RXVXNDZ2t2THlBZ0lDQWdJQ0IwYUdsekxtSnlaV0ZqYUVWMmFXUmxibU5sU0dGemFDaHJaWGtwTG5aaGJIVmxMQW9KTHk4Z0lDQWdJRjA3Q2dsaWVYUmxZeUF4TkNBdkx5QWdJbmgwSWdvSlpuSmhiV1ZmWkdsbklEQWdMeThnYTJWNU9pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KWW05NFgyZGxkQW9LQ1M4dklHSnZlQ0IyWVd4MVpTQmtiMlZ6SUc1dmRDQmxlR2x6ZERvZ2RHaHBjeTVpY21WaFkyaFVaVzF3S0d0bGVTa3VkbUZzZFdVS0NXRnpjMlZ5ZEFvSlluUnZhUW9KYVhSdllnb0pZbmwwWldNZ01UVWdMeThnSUNKNGJ5SUtDV1p5WVcxbFgyUnBaeUF3SUM4dklHdGxlVG9nZFdsdWREWTBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NXSnZlRjluWlhRS0Nna3ZMeUJpYjNnZ2RtRnNkV1VnWkc5bGN5QnViM1FnWlhocGMzUTZJSFJvYVhNdVluSmxZV05vVDJKelpYSjJaV1JCZENoclpYa3BMblpoYkhWbENnbGhjM05sY25RS0NXSjBiMmtLQ1dsMGIySUtDV052Ym1OaGRBb0pZbmwwWldNZ01UWWdMeThnSUNKNGNpSUtDV1p5WVcxbFgyUnBaeUF3SUM4dklHdGxlVG9nZFdsdWREWTBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NXSnZlRjluWlhRS0Nna3ZMeUJpYjNnZ2RtRnNkV1VnWkc5bGN5QnViM1FnWlhocGMzUTZJSFJvYVhNdVluSmxZV05vVW1WamIzSmtaV1JCZENoclpYa3BMblpoYkhWbENnbGhjM05sY25RS0NXSjBiMmtLQ1dsMGIySUtDV052Ym1OaGRBb0pZbmwwWldNZ01UY2dMeThnSUNKNGN5SUtDV1p5WVcxbFgyUnBaeUF3SUM4dklHdGxlVG9nZFdsdWREWTBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NXSnZlRjluWlhRS0Nna3ZMeUJpYjNnZ2RtRnNkV1VnWkc5bGN5QnViM1FnWlhocGMzUTZJSFJvYVhNdVluSmxZV05vVTJWdWMyOXlLR3RsZVNrdWRtRnNkV1VLQ1dGemMyVnlkQW9KWTI5dVkyRjBDZ2xpZVhSbFl5QXhPQ0F2THlBZ0luaGxJZ29KWm5KaGJXVmZaR2xuSURBZ0x5OGdhMlY1T2lCMWFXNTBOalFLQ1dsMGIySUtDV052Ym1OaGRBb0pZbTk0WDJkbGRBb0tDUzh2SUdKdmVDQjJZV3gxWlNCa2IyVnpJRzV2ZENCbGVHbHpkRG9nZEdocGN5NWljbVZoWTJoRmRtbGtaVzVqWlVoaGMyZ29hMlY1S1M1MllXeDFaUW9KWVhOelpYSjBDZ2xqYjI1allYUUtDZ2t2THlCelpYUWdkR2hsSUhOMVluSnZkWFJwYm1VZ2NtVjBkWEp1SUhaaGJIVmxDZ2xtY21GdFpWOWlkWEo1SURBS0NYSmxkSE4xWWdvS0x5OGdaMlYwUTNWemRHOWtlVU52ZFc1MEtIVnBiblEyTkNsMWFXNTBOalFLS21GaWFWOXliM1YwWlY5blpYUkRkWE4wYjJSNVEyOTFiblE2Q2drdkx5QlVhR1VnUVVKSklISmxkSFZ5YmlCd2NtVm1hWGdLQ1dKNWRHVmpJRElnTHk4Z01IZ3hOVEZtTjJNM05Rb0tDUzh2SUdKaGRHTm9TV1E2SUhWcGJuUTJOQW9KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb0pZblJ2YVFvS0NTOHZJR1Y0WldOMWRHVWdaMlYwUTNWemRHOWtlVU52ZFc1MEtIVnBiblEyTkNsMWFXNTBOalFLQ1dOaGJHeHpkV0lnWjJWMFEzVnpkRzlrZVVOdmRXNTBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NXeHZad29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdaMlYwUTNWemRHOWtlVU52ZFc1MEtHSmhkR05vU1dRNklIVnBiblEyTkNrNklIVnBiblEyTkFvdkx3b3ZMeUJIWlhRZ2RHaGxJRzUxYldKbGNpQnZaaUJqZFhOMGIyUjVJSFJ5WVc1elptVnljeUJtYjNJZ1lTQmlZWFJqYUM0S1oyVjBRM1Z6ZEc5a2VVTnZkVzUwT2dvSmNISnZkRzhnTVNBeENnb0pMeThnWTI5dWRISmhZM1J6WEVKaGRHTm9VbVZuYVhOMGNua3VkSE02TkRjMkNna3ZMeUIwYUdsekxtRnpjMlZ5ZEVKaGRHTm9SWGhwYzNSektHSmhkR05vU1dRcENnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1ltRjBZMmhKWkRvZ2RXbHVkRFkwQ2dsallXeHNjM1ZpSUdGemMyVnlkRUpoZEdOb1JYaHBjM1J6Q2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUpoZEdOb1VtVm5hWE4wY25rdWRITTZORGMzQ2drdkx5QnlaWFIxY200Z2RHaHBjeTVqZFhOMGIyUjVRMjkxYm5Rb1ltRjBZMmhKWkNrdWRtRnNkV1U3Q2dsaWVYUmxZeUExSUM4dklDQWlZMk1pQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWW1GMFkyaEpaRG9nZFdsdWREWTBDZ2xwZEc5aUNnbGpiMjVqWVhRS0NXSnZlRjluWlhRS0Nna3ZMeUJpYjNnZ2RtRnNkV1VnWkc5bGN5QnViM1FnWlhocGMzUTZJSFJvYVhNdVkzVnpkRzlrZVVOdmRXNTBLR0poZEdOb1NXUXBMblpoYkhWbENnbGhjM05sY25RS0NXSjBiMmtLQ1hKbGRITjFZZ29LTHk4Z1oyVjBRbkpsWVdOb1EyOTFiblFvZFdsdWREWTBLWFZwYm5RMk5Bb3FZV0pwWDNKdmRYUmxYMmRsZEVKeVpXRmphRU52ZFc1ME9nb0pMeThnVkdobElFRkNTU0J5WlhSMWNtNGdjSEpsWm1sNENnbGllWFJsWXlBeUlDOHZJREI0TVRVeFpqZGpOelVLQ2drdkx5QmlZWFJqYUVsa09pQjFhVzUwTmpRS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLQ1dKMGIya0tDZ2t2THlCbGVHVmpkWFJsSUdkbGRFSnlaV0ZqYUVOdmRXNTBLSFZwYm5RMk5DbDFhVzUwTmpRS0NXTmhiR3h6ZFdJZ1oyVjBRbkpsWVdOb1EyOTFiblFLQ1dsMGIySUtDV052Ym1OaGRBb0piRzluQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJuWlhSQ2NtVmhZMmhEYjNWdWRDaGlZWFJqYUVsa09pQjFhVzUwTmpRcE9pQjFhVzUwTmpRS0x5OEtMeThnUjJWMElIUm9aU0J1ZFcxaVpYSWdiMllnWW5KbFlXTm9JSEpsWTI5eVpITWdabTl5SUdFZ1ltRjBZMmd1Q21kbGRFSnlaV0ZqYUVOdmRXNTBPZ29KY0hKdmRHOGdNU0F4Q2dvSkx5OGdZMjl1ZEhKaFkzUnpYRUpoZEdOb1VtVm5hWE4wY25rdWRITTZORGcwQ2drdkx5QjBhR2x6TG1GemMyVnlkRUpoZEdOb1JYaHBjM1J6S0dKaGRHTm9TV1FwQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWW1GMFkyaEpaRG9nZFdsdWREWTBDZ2xqWVd4c2MzVmlJR0Z6YzJWeWRFSmhkR05vUlhocGMzUnpDZ29KTHk4Z1kyOXVkSEpoWTNSelhFSmhkR05vVW1WbmFYTjBjbmt1ZEhNNk5EZzFDZ2t2THlCeVpYUjFjbTRnZEdocGN5NWljbVZoWTJoRGIzVnVkQ2hpWVhSamFFbGtLUzUyWVd4MVpUc0tDV0o1ZEdWaklEWWdMeThnSUNKNFl5SUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmlZWFJqYUVsa09pQjFhVzUwTmpRS0NXbDBiMklLQ1dOdmJtTmhkQW9KWW05NFgyZGxkQW9LQ1M4dklHSnZlQ0IyWVd4MVpTQmtiMlZ6SUc1dmRDQmxlR2x6ZERvZ2RHaHBjeTVpY21WaFkyaERiM1Z1ZENoaVlYUmphRWxrS1M1MllXeDFaUW9KWVhOelpYSjBDZ2xpZEc5cENnbHlaWFJ6ZFdJS0NpcGpjbVZoZEdWZlRtOVBjRG9LQ1hCMWMyaGllWFJsY3lBd2VHSTRORFEzWWpNMklDOHZJRzFsZEdodlpDQWlZM0psWVhSbFFYQndiR2xqWVhScGIyNG9LWFp2YVdRaUNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2dsdFlYUmphQ0FxWVdKcFgzSnZkWFJsWDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1Q2dvSkx5OGdkR2hwY3lCamIyNTBjbUZqZENCa2IyVnpJRzV2ZENCcGJYQnNaVzFsYm5RZ2RHaGxJR2RwZG1WdUlFRkNTU0J0WlhSb2IyUWdabTl5SUdOeVpXRjBaU0JPYjA5d0NnbGxjbklLQ2lwallXeHNYMDV2VDNBNkNnbHdkWE5vWW5sMFpYTWdNSGd6Tm1ZeFlUUTNOU0F2THlCdFpYUm9iMlFnSW1keVlXNTBVbTlzWlNoMWFXNTBOalFzWVdSa2NtVnpjeWwyYjJsa0lnb0pjSFZ6YUdKNWRHVnpJREI0WmpFNFlUZ3pZVGdnTHk4Z2JXVjBhRzlrSUNKeVpYWnZhMlZTYjJ4bEtIVnBiblEyTkN4aFpHUnlaWE56S1hadmFXUWlDZ2x3ZFhOb1lubDBaWE1nTUhnek1tVTRPREkxTlNBdkx5QnRaWFJvYjJRZ0ltZHlZVzUwVFdGdWRXWmhZM1IxY21WeVVtOXNaU2hoWkdSeVpYTnpLWFp2YVdRaUNnbHdkWE5vWW5sMFpYTWdNSGhoTm1abU16QTFaU0F2THlCdFpYUm9iMlFnSW1keVlXNTBSR2x6ZEhKcFluVjBiM0pTYjJ4bEtHRmtaSEpsYzNNcGRtOXBaQ0lLQ1hCMWMyaGllWFJsY3lBd2VHTmhOMlU1TTJOaElDOHZJRzFsZEdodlpDQWlaM0poYm5SUWFHRnliV0ZqZVZKdmJHVW9ZV1JrY21WemN5bDJiMmxrSWdvSmNIVnphR0o1ZEdWeklEQjRaakV4T0RkbE5qVWdMeThnYldWMGFHOWtJQ0puY21GdWRGUmxiR1Z0WlhSeWVVOXlZV05zWlZKdmJHVW9ZV1JrY21WemN5bDJiMmxrSWdvSmNIVnphR0o1ZEdWeklEQjRZekEwWmpCaE5XVWdMeThnYldWMGFHOWtJQ0p5WlhadmEyVk5ZVzUxWm1GamRIVnlaWEpTYjJ4bEtHRmtaSEpsYzNNcGRtOXBaQ0lLQ1hCMWMyaGllWFJsY3lBd2VETXlaR1k1WkRReklDOHZJRzFsZEdodlpDQWljbVYyYjJ0bFJHbHpkSEpwWW5WMGIzSlNiMnhsS0dGa1pISmxjM01wZG05cFpDSUtDWEIxYzJoaWVYUmxjeUF3ZURJME5qaG1NbUpoSUM4dklHMWxkR2h2WkNBaWNtVjJiMnRsVUdoaGNtMWhZM2xTYjJ4bEtHRmtaSEpsYzNNcGRtOXBaQ0lLQ1hCMWMyaGllWFJsY3lBd2VEbGpaalZpTlRrMklDOHZJRzFsZEdodlpDQWljbVYyYjJ0bFZHVnNaVzFsZEhKNVQzSmhZMnhsVW05c1pTaGhaR1J5WlhOektYWnZhV1FpQ2dsd2RYTm9ZbmwwWlhNZ01IaGhOak0xWmpBMVl5QXZMeUJ0WlhSb2IyUWdJbWhoYzFKdmJHVW9kV2x1ZERZMExHRmtaSEpsYzNNcFltOXZiQ0lLQ1hCMWMyaGllWFJsY3lBd2VHRmhPVGd6TVRReklDOHZJRzFsZEdodlpDQWlZM0psWVhSbFFtRjBZMmdvYzNSeWFXNW5LWFZwYm5RMk5DSUtDWEIxYzJoaWVYUmxjeUF3ZURVMlpHSTFOakE0SUM4dklHMWxkR2h2WkNBaVpteGhaMEp5WldGamFDaDFhVzUwTmpRcGRtOXBaQ0lLQ1hCMWMyaGllWFJsY3lBd2VEa3dNVEEzWmpObElDOHZJRzFsZEdodlpDQWljbVZqYjNKa1ZHVnRjR1Z5WVhSMWNtVW9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzWVdSa2NtVnpjeXhpZVhSbFd6TXlYU2xpYjI5c0lnb0pjSFZ6YUdKNWRHVnpJREI0WWprNFpHRTJZekFnTHk4Z2JXVjBhRzlrSUNKMGNtRnVjMlpsY2tKaGRHTm9LSFZwYm5RMk5DeGhaR1J5WlhOektYWnZhV1FpQ2dsd2RYTm9ZbmwwWlhNZ01IZzVNbU5sTkdNM05DQXZMeUJ0WlhSb2IyUWdJbU52Ym1acGNtMUVaV3hwZG1WeWVTaDFhVzUwTmpRcGRtOXBaQ0lLQ1hCMWMyaGllWFJsY3lBd2VEazBZVEl6TURBMUlDOHZJRzFsZEdodlpDQWlaMlYwUW1GMFkyZ29kV2x1ZERZMEtTaGllWFJsVzEwc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBLU0lLQ1hCMWMyaGllWFJsY3lBd2VHRXlZMk0yWVdZeElDOHZJRzFsZEdodlpDQWlaMlYwUW1GMFkyaEVaWFJoYVd4ektIVnBiblEyTkNrb1lubDBaVnRkTEdGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUNnbHdkWE5vWW5sMFpYTWdNSGhsTVRsbFltSmhOeUF2THlCdFpYUm9iMlFnSW1kbGRFTjFjM1J2WkhsU1pXTnZjbVFvZFdsdWREWTBMSFZwYm5RMk5Da29ZV1JrY21WemN5eGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkRFkwS1NJS0NYQjFjMmhpZVhSbGN5QXdlRGcxTmpnM05tSmhJQzh2SUcxbGRHaHZaQ0FpWjJWMFFuSmxZV05vVW1WamIzSmtLSFZwYm5RMk5DeDFhVzUwTmpRcEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0ZrWkhKbGMzTXNZbmwwWlZzek1sMHBJZ29KY0hWemFHSjVkR1Z6SURCNE5XSTNZamswT1RFZ0x5OGdiV1YwYUc5a0lDSm5aWFJEZFhOMGIyUjVRMjkxYm5Rb2RXbHVkRFkwS1hWcGJuUTJOQ0lLQ1hCMWMyaGllWFJsY3lBd2VETXdOV0U0TmpReklDOHZJRzFsZEdodlpDQWlaMlYwUW5KbFlXTm9RMjkxYm5Rb2RXbHVkRFkwS1hWcGJuUTJOQ0lLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtDVzFoZEdOb0lDcGhZbWxmY205MWRHVmZaM0poYm5SU2IyeGxJQ3BoWW1sZmNtOTFkR1ZmY21WMmIydGxVbTlzWlNBcVlXSnBYM0p2ZFhSbFgyZHlZVzUwVFdGdWRXWmhZM1IxY21WeVVtOXNaU0FxWVdKcFgzSnZkWFJsWDJkeVlXNTBSR2x6ZEhKcFluVjBiM0pTYjJ4bElDcGhZbWxmY205MWRHVmZaM0poYm5SUWFHRnliV0ZqZVZKdmJHVWdLbUZpYVY5eWIzVjBaVjluY21GdWRGUmxiR1Z0WlhSeWVVOXlZV05zWlZKdmJHVWdLbUZpYVY5eWIzVjBaVjl5WlhadmEyVk5ZVzUxWm1GamRIVnlaWEpTYjJ4bElDcGhZbWxmY205MWRHVmZjbVYyYjJ0bFJHbHpkSEpwWW5WMGIzSlNiMnhsSUNwaFltbGZjbTkxZEdWZmNtVjJiMnRsVUdoaGNtMWhZM2xTYjJ4bElDcGhZbWxmY205MWRHVmZjbVYyYjJ0bFZHVnNaVzFsZEhKNVQzSmhZMnhsVW05c1pTQXFZV0pwWDNKdmRYUmxYMmhoYzFKdmJHVWdLbUZpYVY5eWIzVjBaVjlqY21WaGRHVkNZWFJqYUNBcVlXSnBYM0p2ZFhSbFgyWnNZV2RDY21WaFkyZ2dLbUZpYVY5eWIzVjBaVjl5WldOdmNtUlVaVzF3WlhKaGRIVnlaU0FxWVdKcFgzSnZkWFJsWDNSeVlXNXpabVZ5UW1GMFkyZ2dLbUZpYVY5eWIzVjBaVjlqYjI1bWFYSnRSR1ZzYVhabGNua2dLbUZpYVY5eWIzVjBaVjluWlhSQ1lYUmphQ0FxWVdKcFgzSnZkWFJsWDJkbGRFSmhkR05vUkdWMFlXbHNjeUFxWVdKcFgzSnZkWFJsWDJkbGRFTjFjM1J2WkhsU1pXTnZjbVFnS21GaWFWOXliM1YwWlY5blpYUkNjbVZoWTJoU1pXTnZjbVFnS21GaWFWOXliM1YwWlY5blpYUkRkWE4wYjJSNVEyOTFiblFnS21GaWFWOXliM1YwWlY5blpYUkNjbVZoWTJoRGIzVnVkQW9LQ1M4dklIUm9hWE1nWTI5dWRISmhZM1FnWkc5bGN5QnViM1FnYVcxd2JHVnRaVzUwSUhSb1pTQm5hWFpsYmlCQlFra2diV1YwYUc5a0lHWnZjaUJqWVd4c0lFNXZUM0FLQ1dWeWNnb0tLbkJ5YjJObGMzTmZjM1JoZEdsalgzUjFjR3hsWDJWc1pXMWxiblE2Q2dsd2NtOTBieUEwSURNS0NXWnlZVzFsWDJScFp5QXROQ0F2THlCMGRYQnNaU0JvWldGa0NnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z1pXeGxiV1Z1ZEFvSlkyOXVZMkYwQ2dsbWNtRnRaVjlrYVdjZ0xUTWdMeThnZEhWd2JHVWdkR0ZwYkFvSlpuSmhiV1ZmWkdsbklDMHlJQzh2SUdobFlXUWdiMlptYzJWMENnbHlaWFJ6ZFdJS0NpcHdjbTlqWlhOelgyUjVibUZ0YVdOZmRIVndiR1ZmWld4bGJXVnVkRG9LQ1hCeWIzUnZJRFFnTXdvSlpuSmhiV1ZmWkdsbklDMDBJQzh2SUhSMWNHeGxJR2hsWVdRS0NXWnlZVzFsWDJScFp5QXRNaUF2THlCb1pXRmtJRzltWm5ObGRBb0pZMjl1WTJGMENnbG1jbUZ0WlY5aWRYSjVJQzAwSUM4dklIUjFjR3hsSUdobFlXUUtDV1p5WVcxbFgyUnBaeUF0TVNBdkx5QmxiR1Z0Wlc1MENnbGtkWEFLQ1d4bGJnb0pabkpoYldWZlpHbG5JQzB5SUM4dklHaGxZV1FnYjJabWMyVjBDZ2xpZEc5cENna3JDZ2xwZEc5aUNnbGxlSFJ5WVdOMElEWWdNZ29KWm5KaGJXVmZZblZ5ZVNBdE1pQXZMeUJvWldGa0lHOW1abk5sZEFvSlpuSmhiV1ZmWkdsbklDMHpJQzh2SUhSMWNHeGxJSFJoYVd3S0NYTjNZWEFLQ1dOdmJtTmhkQW9KWm5KaGJXVmZZblZ5ZVNBdE15QXZMeUIwZFhCc1pTQjBZV2xzQ2dsbWNtRnRaVjlrYVdjZ0xUUWdMeThnZEhWd2JHVWdhR1ZoWkFvSlpuSmhiV1ZmWkdsbklDMHpJQzh2SUhSMWNHeGxJSFJoYVd3S0NXWnlZVzFsWDJScFp5QXRNaUF2THlCb1pXRmtJRzltWm5ObGRBb0pjbVYwYzNWaSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjpudWxsLCJjb21waWxlckluZm8iOm51bGwsImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
