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

namespace Arc56.Generated.algorandfoundation.puya_ts.ModuleConstantsAlgo_561bce34
{


    public class ModuleConstantsAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ModuleConstantsAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetBoolConstantsReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static GetBoolConstantsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetBoolConstantsReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetBoolConstantsReturn);
                }
                public bool Equals(GetBoolConstantsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetBoolConstantsReturn left, GetBoolConstantsReturn right)
                {
                    return EqualityComparer<GetBoolConstantsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetBoolConstantsReturn left, GetBoolConstantsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetUintConstantsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public ulong Field4 { get; set; }

                public ulong Field5 { get; set; }

                public ulong Field6 { get; set; }

                public ulong Field7 { get; set; }

                public ulong Field8 { get; set; }

                public ulong Field9 { get; set; }

                public ulong Field10 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField7.From(Field7);
                    ret.AddRange(vField7.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField8.From(Field8);
                    ret.AddRange(vField8.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField9 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField9.From(Field9);
                    ret.AddRange(vField9.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField10 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField10.From(Field10);
                    ret.AddRange(vField10.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetUintConstantsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetUintConstantsReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField8 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField8.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField8 = vField8.ToValue();
                    if (valueField8 is ulong vField8Value) { ret.Field8 = vField8Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField9 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField9.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField9 = vField9.ToValue();
                    if (valueField9 is ulong vField9Value) { ret.Field9 = vField9Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField10 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField10.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField10 = vField10.ToValue();
                    if (valueField10 is ulong vField10Value) { ret.Field10 = vField10Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetUintConstantsReturn);
                }
                public bool Equals(GetUintConstantsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetUintConstantsReturn left, GetUintConstantsReturn right)
                {
                    return EqualityComparer<GetUintConstantsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetUintConstantsReturn left, GetUintConstantsReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetBigUintConstantsReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field3 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field4 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field5 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field6 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field7 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField7 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
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

                public static GetBigUintConstantsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetBigUintConstantsReturn();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    var vField2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field2 = vField2;
                    var vField3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field3 = vField3;
                    var vField4 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field4 = vField4;
                    var vField5 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field5 = vField5;
                    var vField6 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field6 = vField6;
                    var vField7 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField7.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field7 = vField7;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetBigUintConstantsReturn);
                }
                public bool Equals(GetBigUintConstantsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetBigUintConstantsReturn left, GetBigUintConstantsReturn right)
                {
                    return EqualityComparer<GetBigUintConstantsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetBigUintConstantsReturn left, GetBigUintConstantsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetBoolConstantsReturn> GetBoolConstants(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 122, 7, 61 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetBoolConstantsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBoolConstants_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 122, 7, 61 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetUintConstantsReturn> GetUintConstants(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 12, 72, 14 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUintConstantsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUintConstants_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 12, 72, 14 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.GetBigUintConstantsReturn> GetBigUintConstants(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 16, 169, 52 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetBigUintConstantsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBigUintConstants_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 16, 169, 52 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string[]> GetStringConstants(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 49, 83, 167 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.String>("string");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToStringArray();

        }

        public async Task<List<Transaction>> GetStringConstants_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 49, 83, 167 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9kdWxlQ29uc3RhbnRzQWxnbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRCb29sQ29uc3RhbnRzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYm9vbCJ9XSwiR2V0VWludENvbnN0YW50c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ1IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkNiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDciLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQ4IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkOSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEwIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0QmlnVWludENvbnN0YW50c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJmaWVsZDUiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImZpZWxkNiIsInR5cGUiOiJ1aW50NTEyIn0seyJuYW1lIjoiZmllbGQ3IiwidHlwZSI6InVpbnQ1MTIifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZ2V0Qm9vbENvbnN0YW50cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCxib29sKSIsInN0cnVjdCI6IkdldEJvb2xDb25zdGFudHNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRVaW50Q29uc3RhbnRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFVpbnRDb25zdGFudHNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRCaWdVaW50Q29uc3RhbnRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIsdWludDUxMix1aW50NTEyLHVpbnQ1MTIpIiwic3RydWN0IjoiR2V0QmlnVWludENvbnN0YW50c1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFN0cmluZ0NvbnN0YW50cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmdbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNzQsMjg3LDI5OSwzMTEsMzIzLDMzNSwzNDcsMzU5XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ05qUWdNQ0F4SURJS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnZ01IZ3hOVEZtTjJNM05TQXdlREE0SUNKaFlpSUtJQ0FnSUdJZ2JXRnBibDlpYkc5amEwQXdDZ3B0WVdsdVgySnNiMk5yUURBNkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Rb0tiV0ZwYmw5aWJHOWphMEF4T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjF2WkhWc1pTMWpiMjV6ZEdGdWRITXVZV3huYnk1MGN6bzBNZ29nSUNBZ0x5OGdZMnhoYzNNZ1RXOWtkV3hsUTI5dWMzUmhiblJ6UVd4bmJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXhDaUFnSUNCaUlHMWhhVzVmWVdKcFgzSnZkWFJwYm1kQU1nb0tiV0ZwYmw5aFltbGZjbTkxZEdsdVowQXlPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMXZaSFZzWlMxamIyNXpkR0Z1ZEhNdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z1kyeGhjM01nVFc5a2RXeGxRMjl1YzNSaGJuUnpRV3huYnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlCT2IwOXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDRTlDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEa0tJQ0FnSUdJZ2JXRnBibDlqWVd4c1gwNXZUM0JBTXdvS2JXRnBibDlqWVd4c1gwNXZUM0JBTXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0YjJSMWJHVXRZMjl1YzNSaGJuUnpMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJR05zWVhOeklFMXZaSFZzWlVOdmJuTjBZVzUwYzBGc1oyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJPRGRoTURjelpDQXZMeUJ0WlhSb2IyUWdJbWRsZEVKdmIyeERiMjV6ZEdGdWRITW9LU2hpYjI5c0xHSnZiMndwSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TUdFd1l6UTRNR1VnTHk4Z2JXVjBhRzlrSUNKblpYUlZhVzUwUTI5dWMzUmhiblJ6S0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TlRFd1lUa3pOQ0F2THlCdFpYUm9iMlFnSW1kbGRFSnBaMVZwYm5SRGIyNXpkR0Z1ZEhNb0tTaDFhVzUwTlRFeUxIVnBiblExTVRJc2RXbHVkRFV4TWl4MWFXNTBOVEV5TEhWcGJuUTFNVElzZFdsdWREVXhNaXgxYVc1ME5URXlMSFZwYm5RMU1USXBJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjROemN6TVRVellUY2dMeThnYldWMGFHOWtJQ0puWlhSVGRISnBibWREYjI1emRHRnVkSE1vS1hOMGNtbHVaMXRkSWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCdFlYUmphQ0J0WVdsdVgyZGxkRUp2YjJ4RGIyNXpkR0Z1ZEhOZmNtOTFkR1ZBTkNCdFlXbHVYMmRsZEZWcGJuUkRiMjV6ZEdGdWRITmZjbTkxZEdWQU5TQnRZV2x1WDJkbGRFSnBaMVZwYm5SRGIyNXpkR0Z1ZEhOZmNtOTFkR1ZBTmlCdFlXbHVYMmRsZEZOMGNtbHVaME52Ym5OMFlXNTBjMTl5YjNWMFpVQTNDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUE0Q2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFPRG9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV3Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UQTZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxdlpIVnNaUzFqYjI1emRHRnVkSE11WVd4bmJ5NTBjem8wTWdvZ0lDQWdMeThnWTJ4aGMzTWdUVzlrZFd4bFEyOXVjM1JoYm5SelFXeG5ieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lHVnljZ29LYldGcGJsOW5aWFJUZEhKcGJtZERiMjV6ZEdGdWRITmZjbTkxZEdWQU56b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGIyUjFiR1V0WTI5dWMzUmhiblJ6TG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUdkbGRGTjBjbWx1WjBOdmJuTjBZVzUwY3lncElIc0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFUzUnlhVzVuUTI5dWMzUmhiblJ6Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBNENncHRZV2x1WDJkbGRFSnBaMVZwYm5SRGIyNXpkR0Z1ZEhOZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0YjJSMWJHVXRZMjl1YzNSaGJuUnpMbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJR2RsZEVKcFoxVnBiblJEYjI1emRHRnVkSE1vS1NCN0NpQWdJQ0JqWVd4c2MzVmlJR2RsZEVKcFoxVnBiblJEYjI1emRHRnVkSE1LSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURnS0NtMWhhVzVmWjJWMFZXbHVkRU52Ym5OMFlXNTBjMTl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMXZaSFZzWlMxamIyNXpkR0Z1ZEhNdVlXeG5ieTUwY3pvME5nb2dJQ0FnTHk4Z1oyVjBWV2x1ZEVOdmJuTjBZVzUwY3lncElIc0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFZXbHVkRU52Ym5OMFlXNTBjd29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBT0FvS2JXRnBibDluWlhSQ2IyOXNRMjl1YzNSaGJuUnpYM0p2ZFhSbFFEUTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJXOWtkV3hsTFdOdmJuTjBZVzUwY3k1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCblpYUkNiMjlzUTI5dWMzUmhiblJ6S0NrZ2V3b2dJQ0FnWTJGc2JITjFZaUJuWlhSQ2IyOXNRMjl1YzNSaGJuUnpDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUE0Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURrNkNpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Bb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ylc5a2RXeGxMV052Ym5OMFlXNTBjeTVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUJqYkdGemN5Qk5iMlIxYkdWRGIyNXpkR0Z1ZEhOQmJHZHZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4eElDOHZJRTV2VDNBS0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmpZV3hzYzNWaUlGOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRiMlIxYkdVdFkyOXVjM1JoYm5SekxtRnNaMjh1ZEhNNk9rMXZaSFZzWlVOdmJuTjBZVzUwYzBGc1oyOHVaMlYwUW05dmJFTnZibk4wWVc1MGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEVKdmIyeERiMjV6ZEdGdWRITTZDaUFnSUNCaUlHZGxkRUp2YjJ4RGIyNXpkR0Z1ZEhOZllteHZZMnRBTUFvS1oyVjBRbTl2YkVOdmJuTjBZVzUwYzE5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjF2WkhWc1pTMWpiMjV6ZEdGdWRITXVZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdaMlYwUW05dmJFTnZibk4wWVc1MGN5Z3BJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxdlpIVnNaUzFqYjI1emRHRnVkSE11WVd4bmJ5NTBjem82VFc5a2RXeGxRMjl1YzNSaGJuUnpRV3huYnk1blpYUkNiMjlzUTI5dWMzUmhiblJ6Q2lBZ0lDQmpiM1psY2lBeENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJXOWtkV3hsTFdOdmJuTjBZVzUwY3k1aGJHZHZMblJ6T2pwTmIyUjFiR1ZEYjI1emRHRnVkSE5CYkdkdkxtZGxkRlZwYm5SRGIyNXpkR0Z1ZEhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJWYVc1MFEyOXVjM1JoYm5Sek9nb2dJQ0FnWWlCblpYUlZhVzUwUTI5dWMzUmhiblJ6WDJKc2IyTnJRREFLQ21kbGRGVnBiblJEYjI1emRHRnVkSE5mWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRiMlIxYkdVdFkyOXVjM1JoYm5SekxtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklHZGxkRlZwYm5SRGIyNXpkR0Z1ZEhNb0tTQjdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0YjJSMWJHVXRZMjl1YzNSaGJuUnpMbUZzWjI4dWRITTZPazF2WkhWc1pVTnZibk4wWVc1MGMwRnNaMjh1WjJWMFZXbHVkRU52Ym5OMFlXNTBjd29nSUNBZ1kyOTJaWElnTVRBS0lDQWdJR052ZG1WeUlEa0tJQ0FnSUdOdmRtVnlJRGdLSUNBZ0lHTnZkbVZ5SURjS0lDQWdJR052ZG1WeUlEWUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjF2WkhWc1pTMWpiMjV6ZEdGdWRITXVZV3huYnk1MGN6bzZUVzlrZFd4bFEyOXVjM1JoYm5SelFXeG5ieTVuWlhSQ2FXZFZhVzUwUTI5dWMzUmhiblJ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBRbWxuVldsdWRFTnZibk4wWVc1MGN6b0tJQ0FnSUdJZ1oyVjBRbWxuVldsdWRFTnZibk4wWVc1MGMxOWliRzlqYTBBd0NncG5aWFJDYVdkVmFXNTBRMjl1YzNSaGJuUnpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJXOWtkV3hsTFdOdmJuTjBZVzUwY3k1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCblpYUkNhV2RWYVc1MFEyOXVjM1JoYm5SektDa2dld29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ylc5a2RXeGxMV052Ym5OMFlXNTBjeTVoYkdkdkxuUnpPanBOYjJSMWJHVkRiMjV6ZEdGdWRITkJiR2R2TG1kbGRFSnBaMVZwYm5SRGIyNXpkR0Z1ZEhNS0lDQWdJR052ZG1WeUlEY0tJQ0FnSUdOdmRtVnlJRFlLSUNBZ0lHTnZkbVZ5SURVS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBMk5Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTmpRS0lDQWdJR0o2WlhKdkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSjhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRFkwQ2lBZ0lDQmllbVZ5YndvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWZBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QTJOQW9nSUNBZ1lucGxjbThLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW53S0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekFnTHk4Z05qUUtJQ0FnSUdKNlpYSnZDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHdJQzh2SURZMENpQWdJQ0JpZW1WeWJ3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlmQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1DQXZMeUEyTkFvZ0lDQWdZbnBsY204S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEWTBDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOalFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKOENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRiMlIxYkdVdFkyOXVjM1JoYm5SekxtRnNaMjh1ZEhNNk9rMXZaSFZzWlVOdmJuTjBZVzUwYzBGc1oyOHVaMlYwVTNSeWFXNW5RMjl1YzNSaGJuUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFUzUnlhVzVuUTI5dWMzUmhiblJ6T2dvZ0lDQWdZaUJuWlhSVGRISnBibWREYjI1emRHRnVkSE5mWW14dlkydEFNQW9LWjJWMFUzUnlhVzVuUTI5dWMzUmhiblJ6WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiVzlrZFd4bExXTnZibk4wWVc1MGN5NWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5Qm5aWFJUZEhKcGJtZERiMjV6ZEdGdWRITW9LU0I3Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGIyUjFiR1V0WTI5dWMzUmhiblJ6TG1Gc1oyOHVkSE02T2sxdlpIVnNaVU52Ym5OMFlXNTBjMEZzWjI4dVoyVjBVM1J5YVc1blEyOXVjM1JoYm5SekNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJXOWtkV3hsTFdOdmJuTjBZVzUwY3k1aGJHZHZMblJ6T2pwTmIyUjFiR1ZEYjI1emRHRnVkSE5CYkdkdkxtZGxkRUp2YjJ4RGIyNXpkR0Z1ZEhNb0tTQXRQaUIxYVc1ME5qUXNJSFZwYm5RMk5Eb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMXZaSFZzWlMxamIyNXpkR0Z1ZEhNdVlXeG5ieTUwY3pvNlRXOWtkV3hsUTI5dWMzUmhiblJ6UVd4bmJ5NW5aWFJDYjI5c1EyOXVjM1JoYm5Sek9nb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ylc5a2RXeGxMV052Ym5OMFlXNTBjeTVoYkdkdkxuUnpPanBOYjJSMWJHVkRiMjV6ZEdGdWRITkJiR2R2TG1kbGRFSnZiMnhEYjI1emRHRnVkSE5mWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMjF2WkhWc1pTMWpiMjV6ZEdGdWRITXVZV3huYnk1MGN6bzZUVzlrZFd4bFEyOXVjM1JoYm5SelFXeG5ieTVuWlhSQ2IyOXNRMjl1YzNSaGJuUnpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJXOWtkV3hsTFdOdmJuTjBZVzUwY3k1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCeVpYUjFjbTRnVzJKZllXNWtMQ0JpWDI5eVhTQmhjeUJqYjI1emRBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiVzlrZFd4bExXTnZibk4wWVc1MGN5NWhiR2R2TG5Sek9qcE5iMlIxYkdWRGIyNXpkR0Z1ZEhOQmJHZHZMbWRsZEZWcGJuUkRiMjV6ZEdGdWRITW9LU0F0UGlCMWFXNTBOalFzSUhWcGJuUTJOQ3dnZFdsdWREWTBMQ0IxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalFzSUhWcGJuUTJORG9LZEdWemRITXZZWEJ3Y205MllXeHpMMjF2WkhWc1pTMWpiMjV6ZEdGdWRITXVZV3huYnk1MGN6bzZUVzlrZFd4bFEyOXVjM1JoYm5SelFXeG5ieTVuWlhSVmFXNTBRMjl1YzNSaGJuUnpPZ29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJXOWtkV3hsTFdOdmJuTjBZVzUwY3k1aGJHZHZMblJ6T2pwTmIyUjFiR1ZEYjI1emRHRnVkSE5CYkdkdkxtZGxkRlZwYm5SRGIyNXpkR0Z1ZEhOZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxdlpIVnNaUzFqYjI1emRHRnVkSE11WVd4bmJ5NTBjem82VFc5a2RXeGxRMjl1YzNSaGJuUnpRV3huYnk1blpYUlZhVzUwUTI5dWMzUmhiblJ6WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiVzlrZFd4bExXTnZibk4wWVc1MGN5NWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5QnlaWFIxY200Z1czVmZZV1JrTENCMVgzTjFZaXdnZFY5dGRXd3NJSFZmWkdsMkxDQjFYMjF2WkN3Z2RWOXdiM2NzSUhWZmJITm9hV1owTENCMVgzSnphR2xtZEN3Z2RWOWlhWFJQY2l3Z2RWOWlhWFJZYjNJc0lIVmZZbWwwUVc1a1hTQmhjeUJqYjI1emRBb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNCd2RYTm9hVzUwSURJd0NpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCd2RYTm9hVzUwSURFd01Bb2dJQ0FnY0hWemFHbHVkQ0EwTUFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRiMlIxYkdVdFkyOXVjM1JoYm5SekxtRnNaMjh1ZEhNNk9rMXZaSFZzWlVOdmJuTjBZVzUwYzBGc1oyOHVaMlYwUW1sblZXbHVkRU52Ym5OMFlXNTBjeWdwSUMwK0lHSjVkR1Z6TENCaWVYUmxjeXdnWW5sMFpYTXNJR0o1ZEdWekxDQmllWFJsY3l3Z1lubDBaWE1zSUdKNWRHVnpMQ0JpZVhSbGN6b0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMXZaSFZzWlMxamIyNXpkR0Z1ZEhNdVlXeG5ieTUwY3pvNlRXOWtkV3hsUTI5dWMzUmhiblJ6UVd4bmJ5NW5aWFJDYVdkVmFXNTBRMjl1YzNSaGJuUnpPZ29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJXOWtkV3hsTFdOdmJuTjBZVzUwY3k1aGJHZHZMblJ6T2pwTmIyUjFiR1ZEYjI1emRHRnVkSE5CYkdkdkxtZGxkRUpwWjFWcGJuUkRiMjV6ZEdGdWRITmZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMXZaSFZzWlMxamIyNXpkR0Z1ZEhNdVlXeG5ieTUwY3pvNlRXOWtkV3hsUTI5dWMzUmhiblJ6UVd4bmJ5NW5aWFJDYVdkVmFXNTBRMjl1YzNSaGJuUnpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJXOWtkV3hsTFdOdmJuTjBZVzUwY3k1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCeVpYUjFjbTRnVzJKMVgyRmtaQ3dnWW5WZmMzVmlMQ0JpZFY5dGRXd3NJR0oxWDJScGRpd2dZblZmYlc5a0xDQmlkVjlpYVhSUGNpd2dZblZmWW1sMFdHOXlMQ0JpZFY5aWFYUkJibVJkSUdGeklHTnZibk4wQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3WXdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBNENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQmhDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNRGdLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiVzlrZFd4bExXTnZibk4wWVc1MGN5NWhiR2R2TG5Sek9qcE5iMlIxYkdWRGIyNXpkR0Z1ZEhOQmJHZHZMbWRsZEZOMGNtbHVaME52Ym5OMFlXNTBjeWdwSUMwK0lHSjVkR1Z6T2dwMFpYTjBjeTloY0hCeWIzWmhiSE12Ylc5a2RXeGxMV052Ym5OMFlXNTBjeTVoYkdkdkxuUnpPanBOYjJSMWJHVkRiMjV6ZEdGdWRITkJiR2R2TG1kbGRGTjBjbWx1WjBOdmJuTjBZVzUwY3pvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjF2WkhWc1pTMWpiMjV6ZEdGdWRITXVZV3huYnk1MGN6bzZUVzlrZFd4bFEyOXVjM1JoYm5SelFXeG5ieTVuWlhSVGRISnBibWREYjI1emRHRnVkSE5mWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMjF2WkhWc1pTMWpiMjV6ZEdGdWRITXVZV3huYnk1MGN6bzZUVzlrZFd4bFEyOXVjM1JoYm5SelFXeG5ieTVuWlhSVGRISnBibWREYjI1emRHRnVkSE5mWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRiMlIxYkdVdFkyOXVjM1JoYm5SekxtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklISmxkSFZ5YmlCYmMxOWhaR1JkQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltRmlJZ29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVlXSWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGIyUjFiR1V0WTI5dWMzUmhiblJ6TG1Gc1oyOHVkSE02T2sxdlpIVnNaVU52Ym5OMFlXNTBjMEZzWjI4dVgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsS0NrZ0xUNGdkbTlwWkRvS1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsT2dvZ0lDQWdZaUJmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVmZZbXh2WTJ0QU1Bb0tYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFgySnNiMk5yUURBNkNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVRQUFCQWlZRUFBUVZIM3gxQVFnQ1lXSkNBQUJDQUFBeEd5TVRRUUJlUWdBQU1Sa2pFa1F4R0NNVFFRQk1RZ0FBTmhvQWdBUm9lZ2M5Z0FRS0RFZ09nQVFGRUtrMGdBUjNNVk9uVHdTT0JBQWNBQllBRUFBS1FnQUFRZ0FBUWdBQUFJZ0JEa0wvODRnQWpVTC83WWdBT1VMLzU0Z0FGVUwvNFVMLzRURVpJeEl4R0NNU0VFU0lBVWNrUTBJQUFJZ0E3azRCZ0FFQUkwOENWQ1JQQWxRb1R3RlFLVThCVUxBa1EwSUFBSWdBMWs0S1RnbE9DRTRIVGdaT0JVNEVUZ05PQWs0QkZpaFBBVkJQQVJaUVR3RVdVRThCRmxCUEFSWlFUd0VXVUU4QkZsQlBBUlpRVHdFV1VFOEJGbEJQQVJaUUtVOEJVTEFrUTBJQUFJZ0FuMDRIVGdaT0JVNEVUZ05PQWs0QlNSVWlEa1FpcjZzb1R3RlFTd0VWSWc1RUlxOVBBcXRRU3dFVklnNUVJcTlQQXF0UVN3RVZJZzVFSXE5UEFxdFFTd0VWSWc1RUlxOVBBcXRRU3dFVklnNUVJcTlQQXF0UVN3RVZJZzVFSXE5UEFxdFFTd0VWSWc1RUlxOVBBcXRRS1U4QlVMQWtRMElBQUlnQU9pbFBBVkN3SkVOQ0FBQWpKSWxDQUFDQkRJRUlnUlNCQlNPQlpJRW9KWUVLZ1FnbGlVSUFBSUFCRENxQUFSU0FBUVVvZ0FFS0tvQUJBb2xDQUFBa0ZsY0dBaXNWRmxjR0FpdFFKUlpYQmdKUEFrOEJVRThCVUlsQ0FBQ0oiLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
