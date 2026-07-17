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

namespace Arc56.Generated.algorandfoundation.puya_ts.Arc4BoxContract_0eab2b63
{


    public class Arc4BoxContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc4BoxContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DynamicArrayInAStruct : AVMObjectType
            {
                public ulong A { get; set; }

                public ulong[] Arr { get; set; }

                public ulong B { get; set; }

                public ulong[] Arr2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vArr.From(Arr);
                    ret.AddRange(vArr.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vArr2.From(Arr2);
                    ret.AddRange(vArr2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DynamicArrayInAStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new DynamicArrayInAStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vArr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr = vArr.ToValue();
                    if (valueArr is ulong[] vArrValue) { ret.Arr = vArrValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is ulong vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vArr2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr2 = vArr2.ToValue();
                    if (valueArr2 is ulong[] vArr2Value) { ret.Arr2 = vArr2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DynamicArrayInAStruct);
                }
                public bool Equals(DynamicArrayInAStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DynamicArrayInAStruct left, DynamicArrayInAStruct right)
                {
                    return EqualityComparer<DynamicArrayInAStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(DynamicArrayInAStruct left, DynamicArrayInAStruct right)
                {
                    return !(left == right);
                }

            }

            public class LargeStruct : AVMObjectType
            {
                public byte[] A { get; set; }

                public byte[] B { get; set; }

                public byte[] C { get; set; }

                public byte[] D { get; set; }

                public ulong E { get; set; }

                public byte[] F { get; set; }

                public byte[] G { get; set; }

                public ulong H { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    vC.From(C);
                    ret.AddRange(vC.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    vD.From(D);
                    ret.AddRange(vD.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vE = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vE.From(E);
                    ret.AddRange(vE.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vF = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    vF.From(F);
                    ret.AddRange(vF.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vG = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    vG.From(G);
                    ret.AddRange(vG.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vH = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vH.From(H);
                    ret.AddRange(vH.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static LargeStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new LargeStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is byte[] vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is byte[] vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    count = vC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueC = vC.ToValue();
                    if (valueC is byte[] vCValue) { ret.C = vCValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    count = vD.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueD = vD.ToValue();
                    if (valueD is byte[] vDValue) { ret.D = vDValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vE = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vE.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueE = vE.ToValue();
                    if (valueE is ulong vEValue) { ret.E = vEValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vF = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    count = vF.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueF = vF.ToValue();
                    if (valueF is byte[] vFValue) { ret.F = vFValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vG = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1024]");
                    count = vG.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueG = vG.ToValue();
                    if (valueG is byte[] vGValue) { ret.G = vGValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vH = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vH.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueH = vH.ToValue();
                    if (valueH is ulong vHValue) { ret.H = vHValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LargeStruct);
                }
                public bool Equals(LargeStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LargeStruct left, LargeStruct right)
                {
                    return EqualityComparer<LargeStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(LargeStruct left, LargeStruct right)
                {
                    return !(left == right);
                }

            }

            public class ReadBoxesReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public byte[] Field1 { get; set; }

                public string Field2 { get; set; }

                public ulong Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField2.From(Field2);
                    stringRef[ret.Count] = vField2.Encode();
                    ret.AddRange(new byte[2]);
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

                public static ReadBoxesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ReadBoxesReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReadBoxesReturn);
                }
                public bool Equals(ReadBoxesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReadBoxesReturn left, ReadBoxesReturn right)
                {
                    return EqualityComparer<ReadBoxesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(ReadBoxesReturn left, ReadBoxesReturn right)
                {
                    return !(left == right);
                }

            }

            public class BoxesExistReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public bool Field1 { get; set; }

                public bool Field2 { get; set; }

                public bool Field3 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static BoxesExistReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BoxesExistReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is bool vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is bool vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BoxesExistReturn);
                }
                public bool Equals(BoxesExistReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BoxesExistReturn left, BoxesExistReturn right)
                {
                    return EqualityComparer<BoxesExistReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(BoxesExistReturn left, BoxesExistReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        public async Task SetBoxes(ulong a, byte[] b, string c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 247, 107, 105 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cAbi.From(c);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBoxes_Transactions(ulong a, byte[] b, string c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 247, 107, 105 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cAbi.From(c);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CheckKeys(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 35, 97, 122 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CheckKeys_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 35, 97, 122 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateManyInts(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 38, 57, 72 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateManyInts_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 38, 57, 72 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        /// <param name="value"> </param>
        public async Task SetManyInts(ulong index, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 188, 186, 94 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, indexAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetManyInts_Transactions(ulong index, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 188, 186, 94 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> SumManyInts(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 13, 61, 200 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SumManyInts_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 13, 61, 200 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeleteBoxes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 3, 155, 67 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteBoxes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 3, 155, 67 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task IndirectExtractAndReplace(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 195, 178, 249 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IndirectExtractAndReplace_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 195, 178, 249 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.ReadBoxesReturn> ReadBoxes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 222, 97, 77 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ReadBoxesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ReadBoxes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 222, 97, 77 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.BoxesExistReturn> BoxesExist(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 57, 23, 33 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BoxesExistReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> BoxesExist_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 57, 23, 33 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task SliceBox(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 59, 92, 100 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SliceBox_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 59, 92, 100 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Arc4Box(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 166, 38, 254 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc4Box_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 166, 38, 254 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestBoxRef(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 57, 237, 222 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestBoxRef_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 57, 237, 222 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateBools(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 178, 226, 65 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateBools_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 178, 226, 65 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        /// <param name="value"> </param>
        public async Task SetBool(ulong index, bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 206, 215, 155 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, indexAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBool_Transactions(ulong index, bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 206, 215, 155 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="stopAtTotal"> </param>
        public async Task<ulong> SumBools(ulong stopAtTotal, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 119, 244, 150 };
            var stopAtTotalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAtTotalAbi.From(stopAtTotal);

            var result = await base.CallApp(new List<object> { abiHandle, stopAtTotalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SumBools_Transactions(ulong stopAtTotal, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 119, 244, 150 };
            var stopAtTotalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stopAtTotalAbi.From(stopAtTotal);

            return await base.MakeTransactionList(new List<object> { abiHandle, stopAtTotalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNEJveENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkR5bmFtaWNBcnJheUluQVN0cnVjdCI6W3sibmFtZSI6ImEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXJyIiwidHlwZSI6InVpbnQ2NFtdIn0seyJuYW1lIjoiYiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhcnIyIiwidHlwZSI6InVpbnQ2NFtdIn1dLCJMYXJnZVN0cnVjdCI6W3sibmFtZSI6ImEiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImQiLCJ0eXBlIjoiYnl0ZVsxMDI0XSJ9LHsibmFtZSI6ImUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZiIsInR5cGUiOiJieXRlWzEwMjRdIn0seyJuYW1lIjoiZyIsInR5cGUiOiJieXRlWzEwMjRdIn0seyJuYW1lIjoiaCIsInR5cGUiOiJ1aW50NjQifV0sIlJlYWRCb3hlc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJ1aW50NjQifV0sIkJveGVzRXhpc3RSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXRCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrS2V5cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVNYW55SW50cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRNYW55SW50cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VtTWFueUludHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGVCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbmRpcmVjdEV4dHJhY3RBbmRSZXBsYWNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlYWRCb3hlcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGJ5dGVbXSxzdHJpbmcsdWludDY0KSIsInN0cnVjdCI6IlJlYWRCb3hlc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJveGVzRXhpc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYm9vbCxib29sLGJvb2wpIiwic3RydWN0IjoiQm94ZXNFeGlzdFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNsaWNlQm94IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFyYzRCb3giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEJveFJlZiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVCb29scyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRCb29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluZGV4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VtQm9vbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RvcEF0VG90YWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI1Nyw2NDAsNjQ5LDY1NSw4MDMsOTk1LDEwMjBdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU3XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODQsMzY2LDY2MCw3MTEsNzIxLDgyNSw4NzMsOTc4XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwMSw5MjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTExLDkzMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzgsMzI3LDg1NSw4NjQsODk0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzgzXSwiZXJyb3JNZXNzYWdlIjoibm8gZGF0YSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lEZ2dNaUEwTURrMkNpQWdJQ0JpZVhSbFkySnNiMk5ySUNKQ1QxaGZReUlnSW1Kc2IySWlJQ0ppYjNoTVlYSm5aU0lnSW1KdmVFRWlJQ0ppYjNoRUlpQWlZaUlnSW5SdmIwMWhibmxDYjI5c2N5SWdNSGd3TURBeE1ESXdNeUF3ZURFMU1XWTNZemMxSUNKdFlXNTVTVzUwY3lJZ0lqQWlJQ0pvWld4c2J5SWdJbUp2ZUZKbFppSWdNSGd3TURBeU16UXpNaUFpTkRJaUlEQjRNRFk0TVRBeENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR1IxY0c0Z01nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UXdDaUFnSUNBdkx5QmpiR0Z6Y3lCQmNtTTBRbTk0UTI5dWRISmhZM1FnWlhoMFpXNWtjeUJoY21NMExrTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF5TkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TWpkbU56WmlOamtnTUhnNU1USXpOakUzWVNBd2VHWTNNall6T1RRNElEQjRNRGxpWTJKaE5XVWdNSGczWVRCa00yUmpPQ0F3ZURka01ETTVZalF6SURCNE0ySmpNMkl5WmprZ01IaGtZMlJsTmpFMFpDQXdlR1V4TXpreE56SXhJREI0TmpnellqVmpOalFnTUhoaE5XRTJNalptWlNBd2VEa3dNemxsWkdSbElEQjRNamhpTW1VeU5ERWdNSGc0WkdObFpEYzVZaUF3ZURGak56ZG1ORGsySUM4dklHMWxkR2h2WkNBaWMyVjBRbTk0WlhNb2RXbHVkRFkwTEdKNWRHVmJYU3h6ZEhKcGJtY3BkbTlwWkNJc0lHMWxkR2h2WkNBaVkyaGxZMnRMWlhsektDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamNtVmhkR1ZOWVc1NVNXNTBjeWdwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwVFdGdWVVbHVkSE1vZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKemRXMU5ZVzU1U1c1MGN5Z3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSmtaV3hsZEdWQ2IzaGxjeWdwZG05cFpDSXNJRzFsZEdodlpDQWlhVzVrYVhKbFkzUkZlSFJ5WVdOMFFXNWtVbVZ3YkdGalpTZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVmhaRUp2ZUdWektDa29kV2x1ZERZMExHSjVkR1ZiWFN4emRISnBibWNzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWW05NFpYTkZlR2x6ZENncEtHSnZiMndzWW05dmJDeGliMjlzTEdKdmIyd3BJaXdnYldWMGFHOWtJQ0p6YkdsalpVSnZlQ2dwZG05cFpDSXNJRzFsZEdodlpDQWlZWEpqTkVKdmVDZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRUp2ZUZKbFppZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVkzSmxZWFJsUW05dmJITW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRUp2YjJ3b2RXbHVkRFkwTEdKdmIyd3BkbTlwWkNJc0lHMWxkR2h2WkNBaWMzVnRRbTl2YkhNb2RXbHVkRFkwS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZjMlYwUW05NFpYTmZjbTkxZEdWQU5pQnRZV2x1WDJOb1pXTnJTMlY1YzE5eWIzVjBaVUEzSUcxaGFXNWZZM0psWVhSbFRXRnVlVWx1ZEhOZmNtOTFkR1ZBT0NCdFlXbHVYM05sZEUxaGJubEpiblJ6WDNKdmRYUmxRRGtnYldGcGJsOXpkVzFOWVc1NVNXNTBjMTl5YjNWMFpVQXhNQ0J0WVdsdVgyUmxiR1YwWlVKdmVHVnpYM0p2ZFhSbFFERXhJRzFoYVc1ZmFXNWthWEpsWTNSRmVIUnlZV04wUVc1a1VtVndiR0ZqWlY5eWIzVjBaVUF4TWlCdFlXbHVYM0psWVdSQ2IzaGxjMTl5YjNWMFpVQXhNeUJ0WVdsdVgySnZlR1Z6UlhocGMzUmZjbTkxZEdWQU1UUWdiV0ZwYmw5emJHbGpaVUp2ZUY5eWIzVjBaVUF4TlNCdFlXbHVYMkZ5WXpSQ2IzaGZjbTkxZEdWQU1UWWdiV0ZwYmw5MFpYTjBRbTk0VW1WbVgzSnZkWFJsUURFM0lHMWhhVzVmWTNKbFlYUmxRbTl2YkhOZmNtOTFkR1ZBTVRnZ2JXRnBibDl6WlhSQ2IyOXNYM0p2ZFhSbFFERTVJRzFoYVc1ZmMzVnRRbTl2YkhOZmNtOTFkR1ZBTWpBS0lDQWdJR1Z5Y2dvS2JXRnBibDl6ZFcxQ2IyOXNjMTl5YjNWMFpVQXlNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalV4TUFvZ0lDQWdMeThnYzNWdFFtOXZiSE1vYzNSdmNFRjBWRzkwWVd3NklIVnBiblEyTkNrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCaWRYSjVJRElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalV4TVFvZ0lDQWdMeThnWlc1emRYSmxRblZrWjJWMEtERXpYekF3TUNrS0lDQWdJSEIxYzJocGJuUWdNVE13TURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmpZV3hzYzNWaUlHVnVjM1Z5WlY5aWRXUm5aWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalV4TWdvZ0lDQWdMeThnYkdWMElIUnZkR0ZzT2lCMWFXNTBOalFnUFNBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5USUtJQ0FnSUM4dklIUnZiMDFoYm5sQ2IyOXNjeUE5SUVKdmVEeEdhWGhsWkVGeWNtRjVQR0p2YjJ4bFlXNHNJRE16WHpBd01ENCtLSHNnYTJWNU9pQW5kRzl2VFdGdWVVSnZiMnh6SnlCOUtRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWRHOXZUV0Z1ZVVKdmIyeHpJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOVEV6Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUhaaGJIVmxJRzltSUhSb2FYTXVkRzl2VFdGdWVVSnZiMnh6TG5aaGJIVmxLU0I3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCQ2IzZ2diWFZ6ZENCb1lYWmxJSFpoYkhWbENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZblZ5ZVNBekNncHRZV2x1WDJadmNsOW9aV0ZrWlhKQU1qZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzFNVE1LSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnZG1Gc2RXVWdiMllnZEdocGN5NTBiMjlOWVc1NVFtOXZiSE11ZG1Gc2RXVXBJSHNLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElETXpNREF3Q2lBZ0lDQThDaUFnSUNCaWVpQnRZV2x1WDJKc2IyTnJRRE0xQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0x3b2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQ1VLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0xTWdvZ0lDQWdMeThnZEc5dlRXRnVlVUp2YjJ4eklEMGdRbTk0UEVacGVHVmtRWEp5WVhrOFltOXZiR1ZoYml3Z016TmZNREF3UGo0b2V5QnJaWGs2SUNkMGIyOU5ZVzU1UW05dmJITW5JSDBwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0owYjI5TllXNTVRbTl2YkhNaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvMU1UTUtJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdkbUZzZFdVZ2IyWWdkR2hwY3k1MGIyOU5ZVzU1UW05dmJITXVkbUZzZFdVcElIc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J6ZDJGd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qVXhOQW9nSUNBZ0x5OGdhV1lnS0haaGJIVmxLU0I3Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pVeE5Rb2dJQ0FnTHk4Z2RHOTBZV3dnS3owZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU16RTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzFNVGNLSUNBZ0lDOHZJR2xtSUNoMGIzUmhiQ0E5UFQwZ2MzUnZjRUYwVkc5MFlXd3BJSHNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEMDlDaUFnSUNCaWJub2diV0ZwYmw5aWJHOWphMEF6TlFvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJRE1LSUNBZ0lHSWdiV0ZwYmw5bWIzSmZhR1ZoWkdWeVFESTRDZ3B0WVdsdVgySnNiMk5yUURNMU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5URXdDaUFnSUNBdkx5QnpkVzFDYjI5c2N5aHpkRzl3UVhSVWIzUmhiRG9nZFdsdWREWTBLVG9nZFdsdWREWTBJSHNLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nT0NBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpaWFJDYjI5c1gzSnZkWFJsUURFNU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5UQTJDaUFnSUNBdkx5QnpaWFJDYjI5c0tHbHVaR1Y0T2lCMWFXNTBOalFzSUhaaGJIVmxPaUJpYjI5c1pXRnVLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5UQTNDaUFnSUNBdkx5QjBhR2x6TG5SdmIwMWhibmxDYjI5c2N5NTJZV3gxWlZ0cGJtUmxlRjBnUFNCMllXeDFaUW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBdkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBbENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5USUtJQ0FnSUM4dklIUnZiMDFoYm5sQ2IyOXNjeUE5SUVKdmVEeEdhWGhsWkVGeWNtRjVQR0p2YjJ4bFlXNHNJRE16WHpBd01ENCtLSHNnYTJWNU9pQW5kRzl2VFdGdWVVSnZiMnh6SnlCOUtRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWRHOXZUV0Z1ZVVKdmIyeHpJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOVEEzQ2lBZ0lDQXZMeUIwYUdsekxuUnZiMDFoYm5sQ2IyOXNjeTUyWVd4MVpWdHBibVJsZUYwZ1BTQjJZV3gxWlFvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOENpQWdJQ0JoYzNObGNuUWdMeThnYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TlRJS0lDQWdJQzh2SUhSdmIwMWhibmxDYjI5c2N5QTlJRUp2ZUR4R2FYaGxaRUZ5Y21GNVBHSnZiMnhsWVc0c0lETXpYekF3TUQ0K0tIc2dhMlY1T2lBbmRHOXZUV0Z1ZVVKdmIyeHpKeUI5S1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpZEc5dlRXRnVlVUp2YjJ4eklnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5UQTNDaUFnSUNBdkx5QjBhR2x6TG5SdmIwMWhibmxDYjI5c2N5NTJZV3gxWlZ0cGJtUmxlRjBnUFNCMllXeDFaUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qVXdOZ29nSUNBZ0x5OGdjMlYwUW05dmJDaHBibVJsZURvZ2RXbHVkRFkwTENCMllXeDFaVG9nWW05dmJHVmhiaWtnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVkNiMjlzYzE5eWIzVjBaVUF4T0RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNMU1nb2dJQ0FnTHk4Z2RHOXZUV0Z1ZVVKdmIyeHpJRDBnUW05NFBFWnBlR1ZrUVhKeVlYazhZbTl2YkdWaGJpd2dNek5mTURBd1BqNG9leUJyWlhrNklDZDBiMjlOWVc1NVFtOXZiSE1uSUgwcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMGIyOU5ZVzU1UW05dmJITWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzFNRE1LSUNBZ0lDOHZJSFJvYVhNdWRHOXZUV0Z1ZVVKdmIyeHpMbU55WldGMFpTZ3BDaUFnSUNCd2RYTm9hVzUwSURReE1qVUtJQ0FnSUdKdmVGOWpjbVZoZEdVS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TlRBeUNpQWdJQ0F2THlCamNtVmhkR1ZDYjI5c2N5Z3BJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z6ZEVKdmVGSmxabDl5YjNWMFpVQXhOem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalEyTmdvZ0lDQWdMeThnWVhOelpYSjBLQ0ZpYjNoU1pXWXhMbVY0YVhOMGN5d2dKMjV2SUdSaGRHRW5LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZbXh2WWlJS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dklHUmhkR0VLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalEzTVFvZ0lDQWdMeThnWVhOelpYSjBLR0p2ZUZKbFpqRXVZM0psWVhSbEtIc2djMmw2WlRvZ1ZXbHVkRFkwS0RNeUtTQjlLU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUpzYjJJaUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQmliM2hmWTNKbFlYUmxDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalEzTkFvZ0lDQWdMeThnWTI5dWMzUWdjMlZ1WkdWeVFubDBaWE1nUFNCVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBOelVLSUNBZ0lDOHZJR052Ym5OMElHRndjRUZrWkhKbGMzTWdQU0JIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5NWllWFJsY3dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRM053b2dJQ0FnTHk4Z1ltOTRVbVZtTVM1eVpYQnNZV05sS0RBc0lITmxibVJsY2tKNWRHVnpLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZbXh2WWlJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalEzT0FvZ0lDQWdMeThnWW05NFVtVm1NUzV5WlhOcGVtVW9PREF3TUNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Kc2IySWlDaUFnSUNCd2RYTm9hVzUwSURnd01EQUtJQ0FnSUdKdmVGOXlaWE5wZW1VS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRM09Rb2dJQ0FnTHk4Z1ltOTRVbVZtTVM1emNHeHBZMlVvTUN3Z01Dd2dZWEJ3UVdSa2NtVnpjeWtLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUpzYjJJaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZbTk0WDNOd2JHbGpaUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORGd3Q2lBZ0lDQXZMeUJpYjNoU1pXWXhMbkpsY0d4aFkyVW9OalFzSUhaaGJIVmxNeWtLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUpzYjJJaUNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpYUdWc2JHOGlDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5EZ3hDaUFnSUNBdkx5QmpiMjV6ZENCd2NtVm1hWGdnUFNCaWIzaFNaV1l4TG1WNGRISmhZM1FvTUN3Z016SWdLaUF5SUNzZ2RtRnNkV1V6TG14bGJtZDBhQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUpzYjJJaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjSFZ6YUdsdWRDQTJPUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTRNZ29nSUNBZ0x5OGdZWE56WlhKMEtIQnlaV1pwZUNBOVBUMGdZWEJ3UVdSa2NtVnpjeTVqYjI1allYUW9jMlZ1WkdWeVFubDBaWE1wTG1OdmJtTmhkQ2gyWVd4MVpUTXBLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKb1pXeHNieUlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRnMENpQWdJQ0F2THlCaWIzaFNaV1l4TG1SbGJHVjBaU2dwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppYkc5aUlnb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBPRGNLSUNBZ0lDOHZJR052Ym5OMElGdDJZV3gxWlN3Z1pYaHBjM1J6WFNBOUlHSnZlRkpsWmpFdWJXRjVZbVVvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWW14dllpSUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalE0T0FvZ0lDQWdMeThnWVhOelpYSjBLQ0ZsZUdsemRITXBDaUFnSUNCa2RYQUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5EZzVDaUFnSUNBdkx5QmhjM05sY25Rb2RtRnNkV1VnUFQwOUlFSjVkR1Z6S0NjbktTa0tJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTVNQW9nSUNBZ0x5OGdZWE56WlhKMEtHSnZlRkpsWmpFdVoyVjBLSHNnWkdWbVlYVnNkRG9nYzJWdVpHVnlRbmwwWlhNZ2ZTa2dQVDA5SUhObGJtUmxja0o1ZEdWektRb2dJQ0FnWkdsbklETUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRNU1nb2dJQ0FnTHk4Z1ltOTRVbVZtTVM1MllXeDFaU0E5SUhObGJtUmxja0o1ZEdWekxtTnZibU5oZENoaGNIQkJaR1J5WlhOektRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmliRzlpSWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWJHOWlJZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRrekNpQWdJQ0F2THlCaGMzTmxjblFvWW05NFVtVm1NUzVsZUdsemRITXNJQ2RDYkc5aUlHVjRhWE4wY3ljcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWJHOWlJZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wT1RRS0lDQWdJQzh2SUdGemMyVnlkQ2hpYjNoU1pXWXhMbXhsYm1kMGFDQTlQVDBnTmpRcENpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRZS0lDQWdJQzh2SUdKdmVGSmxaaUE5SUVKdmVEeGllWFJsY3o0b2V5QnJaWGs2SUNkaWIzaFNaV1luSUgwcENpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaVltOTRVbVZtSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRrM0NpQWdJQ0F2THlCMGFHbHpMbUp2ZUZKbFppNWpjbVZoZEdVb2V5QnphWHBsT2lCVmFXNTBOalFvTXpJcElIMHBDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0JpYjNoZlkzSmxZWFJsQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTmdvZ0lDQWdMeThnWW05NFVtVm1JRDBnUW05NFBHSjVkR1Z6UGloN0lHdGxlVG9nSjJKdmVGSmxaaWNnZlNrS0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKaWIzaFNaV1lpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wT1RrS0lDQWdJQzh2SUhSb2FYTXVZbTk0VW1WbUxtUmxiR1YwWlNncENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTJNd29nSUNBZ0x5OGdkR1Z6ZEVKdmVGSmxaaWdwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVhKak5FSnZlRjl5YjNWMFpVQXhOam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalExTmdvZ0lDQWdMeThnWW05NFJDNTJZV3gxWlNBOUlHNWxkeUJoY21NMExsTjBZWFJwWTBGeWNtRjVLRzVsZHlCaGNtTTBMbFZwYm5RNEtEQXBMQ0J1WlhjZ1lYSmpOQzVWYVc1ME9DZ3hLU3dnYm1WM0lHRnlZelF1VldsdWREZ29NaWtzSUc1bGR5QmhjbU0wTGxWcGJuUTRLRE1wS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0prSWdvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBd01ERXdNakF6Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1EQXdNVEF5TURNS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRMU53b2dJQ0FnTHk4Z1lYTnpaWEowS0dKdmVFUXVkbUZzZFdWYk1GMHVZWE5WYVc1ME5qUW9LU0E5UFQwZ01Da0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWVYUmxDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTFOZ29nSUNBZ0x5OGdZbTk0UkM1MllXeDFaU0E5SUc1bGR5QmhjbU0wTGxOMFlYUnBZMEZ5Y21GNUtHNWxkeUJoY21NMExsVnBiblE0S0RBcExDQnVaWGNnWVhKak5DNVZhVzUwT0NneEtTd2dibVYzSUdGeVl6UXVWV2x1ZERnb01pa3NJRzVsZHlCaGNtTTBMbFZwYm5RNEtETXBLUW9nSUNBZ1lubDBaV01nTnlBdkx5QXdlREF3TURFd01qQXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBOVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaGliM2hFTG5aaGJIVmxXekZkTG1GelZXbHVkRFkwS0NrZ1BUMDlJREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1oyVjBZbmwwWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalExTmdvZ0lDQWdMeThnWW05NFJDNTJZV3gxWlNBOUlHNWxkeUJoY21NMExsTjBZWFJwWTBGeWNtRjVLRzVsZHlCaGNtTTBMbFZwYm5RNEtEQXBMQ0J1WlhjZ1lYSmpOQzVWYVc1ME9DZ3hLU3dnYm1WM0lHRnlZelF1VldsdWREZ29NaWtzSUc1bGR5QmhjbU0wTGxWcGJuUTRLRE1wS1FvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURBd01ERXdNakF6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTlRrS0lDQWdJQzh2SUdGemMyVnlkQ2hpYjNoRUxuWmhiSFZsV3pKZExtRnpWV2x1ZERZMEtDa2dQVDA5SURJcENpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdaMlYwWW5sMFpRb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRMU5nb2dJQ0FnTHk4Z1ltOTRSQzUyWVd4MVpTQTlJRzVsZHlCaGNtTTBMbE4wWVhScFkwRnljbUY1S0c1bGR5QmhjbU0wTGxWcGJuUTRLREFwTENCdVpYY2dZWEpqTkM1VmFXNTBPQ2d4S1N3Z2JtVjNJR0Z5WXpRdVZXbHVkRGdvTWlrc0lHNWxkeUJoY21NMExsVnBiblE0S0RNcEtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEQXdNREV3TWpBekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME5qQUtJQ0FnSUM4dklHRnpjMlZ5ZENoaWIzaEVMblpoYkhWbFd6TmRMbUZ6VldsdWREWTBLQ2tnUFQwOUlETXBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJR2RsZEdKNWRHVUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRVMENpQWdJQ0F2THlCaGNtTTBRbTk0S0NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5emJHbGpaVUp2ZUY5eWIzVjBaVUF4TlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRME53b2dJQ0FnTHk4Z1ltOTRNQzUyWVd4MVpTQTlJRUo1ZEdWektDZFVaWE4wYVc1bklIUmxjM1JwYm1jZ01USXpKeWtLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0l3SWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaU1DSUtJQ0FnSUhCMWMyaGllWFJsY3lBaVZHVnpkR2x1WnlCMFpYTjBhVzVuSURFeU15SUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalEwT0FvZ0lDQWdMeThnWVhOelpYSjBLR0p2ZURBdWRtRnNkV1V1YzJ4cFkyVW9NQ3dnTnlrZ1BUMDlJRUo1ZEdWektDZFVaWE4wYVc1bkp5a3BDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlNQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCd2RYTm9hVzUwSURjS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbFJsYzNScGJtY2lDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORE1LSUNBZ0lDOHZJR0p2ZUVNZ1BTQkNiM2c4WVhKak5DNVRkSEkrS0hzZ2EyVjVPaUFuUWs5WVgwTW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pDVDFoZlF5SUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTFNQW9nSUNBZ0x5OGdkR2hwY3k1aWIzaERMblpoYkhWbElEMGdibVYzSUdGeVl6UXVVM1J5S0NkSVpXeHNieWNwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME13b2dJQ0FnTHk4Z1ltOTRReUE5SUVKdmVEeGhjbU0wTGxOMGNqNG9leUJyWlhrNklDZENUMWhmUXljZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0lrSlBXRjlESWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRVd0NpQWdJQ0F2THlCMGFHbHpMbUp2ZUVNdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1VGRISW9KMGhsYkd4dkp5a0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNRFUwT0RZMU5tTTJZelptQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5ETUtJQ0FnSUM4dklHSnZlRU1nUFNCQ2IzZzhZWEpqTkM1VGRISStLSHNnYTJWNU9pQW5RazlZWDBNbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSkNUMWhmUXlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRMU1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0UXk1MllXeDFaUzVpZVhSbGN5NXpiR2xqWlNneUxDQXhNQ2tnUFQwOUlFSjVkR1Z6S0NkSVpXeHNieWNwS1FvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lIQjFjMmhwYm5RZ05Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJSEIxYzJoaWVYUmxjeUFpU0dWc2JHOGlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBORFVLSUNBZ0lDOHZJSE5zYVdObFFtOTRLQ2tnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpYjNobGMwVjRhWE4wWDNKdmRYUmxRREUwT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpReENpQWdJQ0F2THlCaWIzaEJJRDBnUW05NFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkaWIzaEJKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWW05NFFTSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUTBNZ29nSUNBZ0x5OGdjbVYwZFhKdUlGdDBhR2x6TG1KdmVFRXVaWGhwYzNSekxDQjBhR2x6TG1KdmVFSXVaWGhwYzNSekxDQjBhR2x6TG1KdmVFTXVaWGhwYzNSekxDQjBhR2x6TG1KdmVFeGhjbWRsTG1WNGFYTjBjMTBnWVhNZ1kyOXVjM1FLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UXlDaUFnSUNBdkx5QmliM2hDSUQwZ1FtOTRQR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpQaWg3SUd0bGVUb2dKMkluSUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5EUXlDaUFnSUNBdkx5QnlaWFIxY200Z1czUm9hWE11WW05NFFTNWxlR2x6ZEhNc0lIUm9hWE11WW05NFFpNWxlR2x6ZEhNc0lIUm9hWE11WW05NFF5NWxlR2x6ZEhNc0lIUm9hWE11WW05NFRHRnlaMlV1WlhocGMzUnpYU0JoY3lCamIyNXpkQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5ETUtJQ0FnSUM4dklHSnZlRU1nUFNCQ2IzZzhZWEpqTkM1VGRISStLSHNnYTJWNU9pQW5RazlZWDBNbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSkNUMWhmUXlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pRME1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUZ0MGFHbHpMbUp2ZUVFdVpYaHBjM1J6TENCMGFHbHpMbUp2ZUVJdVpYaHBjM1J6TENCMGFHbHpMbUp2ZUVNdVpYaHBjM1J6TENCMGFHbHpMbUp2ZUV4aGNtZGxMbVY0YVhOMGMxMGdZWE1nWTI5dWMzUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpRM0NpQWdJQ0F2THlCaWIzaE1ZWEpuWlNBOUlFSnZlRHhNWVhKblpWTjBjblZqZEQ0b2V5QnJaWGs2SUNkaWIzaE1ZWEpuWlNjZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltSnZlRXhoY21kbElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5EUXlDaUFnSUNBdkx5QnlaWFIxY200Z1czUm9hWE11WW05NFFTNWxlR2x6ZEhNc0lIUm9hWE11WW05NFFpNWxlR2x6ZEhNc0lIUm9hWE11WW05NFF5NWxlR2x6ZEhNc0lIUm9hWE11WW05NFRHRnlaMlV1WlhocGMzUnpYU0JoY3lCamIyNXpkQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME5ERUtJQ0FnSUM4dklHSnZlR1Z6UlhocGMzUW9LVG9nY21WaFpHOXViSGtnVzJKdmIyeGxZVzRzSUdKdmIyeGxZVzRzSUdKdmIyeGxZVzRzSUdKdmIyeGxZVzVkSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNKbFlXUkNiM2hsYzE5eWIzVjBaVUF4TXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME1Rb2dJQ0FnTHk4Z1ltOTRRU0E5SUVKdmVEeDFhVzUwTmpRK0tIc2dhMlY1T2lBblltOTRRU2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1KdmVFRWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzFNallLSUNBZ0lDOHZJSEpsZEhWeWJpQlZhVzUwTmpRb1ltOTRMblpoYkhWbElDc2dNU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNnZ2JYVnpkQ0JvWVhabElIWmhiSFZsQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5ETTRDaUFnSUNBdkx5QnlaWFIxY200Z1cxVnBiblEyTkNoblpYUkNiM2hXWVd4MVpWQnNkWE14S0hSb2FYTXVZbTk0UVNrZ0xTQXhLU3dnZEdocGN5NWliM2hDTG5aaGJIVmxMbTVoZEdsMlpTd2dkR2hwY3k1aWIzaERMblpoYkhWbExDQjBhR2x6TG1KdmVFeGhjbWRsTG5aaGJIVmxMbVZkSUdGeklHTnZibk4wQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UXlDaUFnSUNBdkx5QmliM2hDSUQwZ1FtOTRQR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpQaWg3SUd0bGVUb2dKMkluSUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5ETTRDaUFnSUNBdkx5QnlaWFIxY200Z1cxVnBiblEyTkNoblpYUkNiM2hXWVd4MVpWQnNkWE14S0hSb2FYTXVZbTk0UVNrZ0xTQXhLU3dnZEdocGN5NWliM2hDTG5aaGJIVmxMbTVoZEdsMlpTd2dkR2hwY3k1aWIzaERMblpoYkhWbExDQjBhR2x6TG1KdmVFeGhjbWRsTG5aaGJIVmxMbVZkSUdGeklHTnZibk4wQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTXdvZ0lDQWdMeThnWW05NFF5QTlJRUp2ZUR4aGNtTTBMbE4wY2o0b2V5QnJaWGs2SUNkQ1QxaGZReWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSWtKUFdGOURJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORE00Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdXMVZwYm5RMk5DaG5aWFJDYjNoV1lXeDFaVkJzZFhNeEtIUm9hWE11WW05NFFTa2dMU0F4S1N3Z2RHaHBjeTVpYjNoQ0xuWmhiSFZsTG01aGRHbDJaU3dnZEdocGN5NWliM2hETG5aaGJIVmxMQ0IwYUdsekxtSnZlRXhoY21kbExuWmhiSFZsTG1WZElHRnpJR052Ym5OMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UTNDaUFnSUNBdkx5QmliM2hNWVhKblpTQTlJRUp2ZUR4TVlYSm5aVk4wY25WamRENG9leUJyWlhrNklDZGliM2hNWVhKblpTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUp2ZUV4aGNtZGxJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORE00Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdXMVZwYm5RMk5DaG5aWFJDYjNoV1lXeDFaVkJzZFhNeEtIUm9hWE11WW05NFFTa2dMU0F4S1N3Z2RHaHBjeTVpYjNoQ0xuWmhiSFZsTG01aGRHbDJaU3dnZEdocGN5NWliM2hETG5aaGJIVmxMQ0IwYUdsekxtSnZlRXhoY21kbExuWmhiSFZsTG1WZElHRnpJR052Ym5OMENpQWdJQ0JwYm5SaklEUWdMeThnTkRBNU5nb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNemNLSUNBZ0lDOHZJSEpsWVdSQ2IzaGxjeWdwT2lCeVpXRmtiMjVzZVNCYmRXbHVkRFkwTENCaWVYUmxjeXdnWVhKak5DNVRkSElzSUhWcGJuUTJORjBnZXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNd29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01UUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeU1Bb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJsdVpHbHlaV04wUlhoMGNtRmpkRUZ1WkZKbGNHeGhZMlZmY205MWRHVkFNVEk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRjS0lDQWdJQzh2SUdKdmVFeGhjbWRsSUQwZ1FtOTRQRXhoY21kbFUzUnlkV04wUGloN0lHdGxlVG9nSjJKdmVFeGhjbWRsSnlCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVltOTRUR0Z5WjJVaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME16SXRORE16Q2lBZ0lDQXZMeUJqYjI1emRDQnNZWEpuWlNBOUlHTnNiMjVsS0hSb2FYTXVZbTk0VEdGeVoyVXVkbUZzZFdVcENpQWdJQ0F2THlCc1lYSm5aUzVsSUNzOUlERUtJQ0FnSUdsdWRHTWdOQ0F2THlBME1EazJDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalF6TXdvZ0lDQWdMeThnYkdGeVoyVXVaU0FyUFNBeENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelEzQ2lBZ0lDQXZMeUJpYjNoTVlYSm5aU0E5SUVKdmVEeE1ZWEpuWlZOMGNuVmpkRDRvZXlCclpYazZJQ2RpYjNoTVlYSm5aU2NnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1KdmVFeGhjbWRsSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRNekxUUXpOQW9nSUNBZ0x5OGdiR0Z5WjJVdVpTQXJQU0F4Q2lBZ0lDQXZMeUIwYUdsekxtSnZlRXhoY21kbExuWmhiSFZsSUQwZ1kyeHZibVVvYkdGeVoyVXBDaUFnSUNCcGJuUmpJRFFnTHk4Z05EQTVOZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZmNtVndiR0ZqWlNBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZORE14Q2lBZ0lDQXZMeUJwYm1ScGNtVmpkRVY0ZEhKaFkzUkJibVJTWlhCc1lXTmxLQ2tnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlrWld4bGRHVkNiM2hsYzE5eWIzVjBaVUF4TVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME1Rb2dJQ0FnTHk4Z1ltOTRRU0E5SUVKdmVEeDFhVzUwTmpRK0tIc2dhMlY1T2lBblltOTRRU2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1KdmVFRWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNVGtLSUNBZ0lDOHZJSFJvYVhNdVltOTRRUzVrWld4bGRHVW9LUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRJS0lDQWdJQzh2SUdKdmVFSWdQU0JDYjNnOFlYSmpOQzVFZVc1aGJXbGpRbmwwWlhNK0tIc2dhMlY1T2lBbllpY2dmU2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUlpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTWpBS0lDQWdJQzh2SUhSb2FYTXVZbTk0UWk1a1pXeGxkR1VvS1FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5ETUtJQ0FnSUM4dklHSnZlRU1nUFNCQ2IzZzhZWEpqTkM1VGRISStLSHNnYTJWNU9pQW5RazlZWDBNbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSkNUMWhmUXlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pReU1Rb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoRExtUmxiR1YwWlNncENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBNUW9nSUNBZ0x5OGdZbTk0UVNBOUlFSnZlRHgxYVc1ME5qUStLSHNnYTJWNU9pQW5ZbTk0UVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltSnZlRUVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTWpJS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRUV1WjJWMEtIc2daR1ZtWVhWc2REb2dWV2x1ZERZMEtEUXlLU0I5S1NBOVBUMGdORElwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0J3ZFhOb2FXNTBJRFF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaR2xuSURNS0lDQWdJSE5sYkdWamRBb2dJQ0FnY0hWemFHbHVkQ0EwTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpReUNpQWdJQ0F2THlCaWIzaENJRDBnUW05NFBHRnlZelF1UkhsdVlXMXBZMEo1ZEdWelBpaDdJR3RsZVRvZ0oySW5JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ppSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRJekNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWliM2hDTG1kbGRDaDdJR1JsWm1GMWJIUTZJRzVsZHlCaGNtTTBMa1I1Ym1GdGFXTkNlWFJsY3loQ2VYUmxjeWduTkRJbktTa2dmU2t1Ym1GMGFYWmxJRDA5UFNCQ2VYUmxjeWduTkRJbktTa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURFeklDOHZJREI0TURBd01qTTBNeklLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNJME1pSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTBNd29nSUNBZ0x5OGdZbTk0UXlBOUlFSnZlRHhoY21NMExsTjBjajRvZXlCclpYazZJQ2RDVDFoZlF5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJa0pQV0Y5RElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5ESTBDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpYjNoRExtZGxkQ2g3SUdSbFptRjFiSFE2SUc1bGR5QmhjbU0wTGxOMGNpZ25OREluS1NCOUtTNXVZWFJwZG1VZ1BUMDlJQ2MwTWljcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QXdlREF3TURJek5ETXlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmllWFJsWXlBeE5DQXZMeUFpTkRJaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvME1qY0tJQ0FnSUM4dklHRnpjMlZ5ZENnaFlVVjRhWE4wY3lrS0lDQWdJSE4zWVhBS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRJNENpQWdJQ0F2THlCaGMzTmxjblFvWVNBOVBUMGdNQ2tLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelEzQ2lBZ0lDQXZMeUJpYjNoTVlYSm5aU0E5SUVKdmVEeE1ZWEpuWlZOMGNuVmpkRDRvZXlCclpYazZJQ2RpYjNoTVlYSm5aU2NnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1KdmVFeGhjbWRsSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRJNUNpQWdJQ0F2THlCMGFHbHpMbUp2ZUV4aGNtZGxMbVJsYkdWMFpTZ3BDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalF4T0FvZ0lDQWdMeThnWkdWc1pYUmxRbTk0WlhNb0tTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzTjFiVTFoYm5sSmJuUnpYM0p2ZFhSbFFERXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOREV3Q2lBZ0lDQXZMeUJsYm5OMWNtVkNkV1JuWlhRb01UQmZOVEF3S1FvZ0lDQWdjSFZ6YUdsdWRDQXhNRFV3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHTmhiR3h6ZFdJZ1pXNXpkWEpsWDJKMVpHZGxkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOREV4Q2lBZ0lDQXZMeUJzWlhRZ2RHOTBZV3dnUFNCVmFXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME9Bb2dJQ0FnTHk4Z2JXRnVlVWx1ZEhNZ1BTQkNiM2c4VFdGdWVVbHVkSE0rS0hzZ2EyVjVPaUFuYldGdWVVbHVkSE1uSUgwcENpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKdFlXNTVTVzUwY3lJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pReE1nb2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQjJZV3dnYjJZZ2RHaHBjeTV0WVc1NVNXNTBjeTUyWVd4MVpTa2dld29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjFjbmtnTXdvS2JXRnBibDltYjNKZmFHVmhaR1Z5UURVMk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5ERXlDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJSFpoYkNCdlppQjBhR2x6TG0xaGJubEpiblJ6TG5aaGJIVmxLU0I3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQTFNVE1LSUNBZ0lEd0tJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZabTl5UURVNENpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdLZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelE0Q2lBZ0lDQXZMeUJ0WVc1NVNXNTBjeUE5SUVKdmVEeE5ZVzU1U1c1MGN6NG9leUJyWlhrNklDZHRZVzU1U1c1MGN5Y2dmU2tLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbTFoYm5sSmJuUnpJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZOREV5Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUhaaGJDQnZaaUIwYUdsekxtMWhibmxKYm5SekxuWmhiSFZsS1NCN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qUXhNd29nSUNBZ0x5OGdkRzkwWVd3Z1BTQjBiM1JoYkNBcklIWmhiQW9nSUNBZ1pHbG5JRElLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ013b2dJQ0FnWWlCdFlXbHVYMlp2Y2w5b1pXRmtaWEpBTlRZS0NtMWhhVzVmWVdaMFpYSmZabTl5UURVNE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk5EQTVDaUFnSUNBdkx5QnpkVzFOWVc1NVNXNTBjeWdwSUhzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl6WlhSTllXNTVTVzUwYzE5eWIzVjBaVUE1T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRBMUNpQWdJQ0F2THlCelpYUk5ZVzU1U1c1MGN5aHBibVJsZURvZ2RXbHVkRFkwTENCMllXeDFaVG9nZFdsdWREWTBLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6bzBNRFlLSUNBZ0lDOHZJSFJvYVhNdWJXRnVlVWx1ZEhNdWRtRnNkV1ZiYVc1a1pYaGRJRDBnZG1Gc2RXVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0FxQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRnS0lDQWdJQzh2SUcxaGJubEpiblJ6SUQwZ1FtOTRQRTFoYm5sSmJuUnpQaWg3SUd0bGVUb2dKMjFoYm5sSmJuUnpKeUI5S1FvZ0lDQWdZbmwwWldNZ09TQXZMeUFpYldGdWVVbHVkSE1pQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem8wTURZS0lDQWdJQzh2SUhSb2FYTXViV0Z1ZVVsdWRITXVkbUZzZFdWYmFXNWtaWGhkSUQwZ2RtRnNkV1VLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzSmxjR3hoWTJVZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPalF3TlFvZ0lDQWdMeThnYzJWMFRXRnVlVWx1ZEhNb2FXNWtaWGc2SUhWcGJuUTJOQ3dnZG1Gc2RXVTZJSFZwYm5RMk5Da2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWTllXNTVTVzUwYzE5eWIzVjBaVUE0T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpRNENpQWdJQ0F2THlCdFlXNTVTVzUwY3lBOUlFSnZlRHhOWVc1NVNXNTBjejRvZXlCclpYazZJQ2R0WVc1NVNXNTBjeWNnZlNrS0lDQWdJR0o1ZEdWaklEa2dMeThnSW0xaGJubEpiblJ6SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRBeUNpQWdJQ0F2THlCMGFHbHpMbTFoYm5sSmJuUnpMbU55WldGMFpTZ3BDaUFnSUNCd2RYTm9hVzUwSURReE1EUUtJQ0FnSUdKdmVGOWpjbVZoZEdVS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TkRBeENpQWdJQ0F2THlCamNtVmhkR1ZOWVc1NVNXNTBjeWdwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTJobFkydExaWGx6WDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96T1RRS0lDQWdJQzh2SUdOb1pXTnJTMlY1Y3lncElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmMyVjBRbTk0WlhOZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNMU9Rb2dJQ0FnTHk4Z2MyVjBRbTk0WlhNb1lUb2dkV2x1ZERZMExDQmlPaUJpZVhSbGN5d2dZem9nWVhKak5DNVRkSElwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOakVLSUNBZ0lDOHZJSFJvYVhNdVltOTRRUzUyWVd4MVpTQTlJR0VLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UXhDaUFnSUNBdkx5QmliM2hCSUQwZ1FtOTRQSFZwYm5RMk5ENG9leUJyWlhrNklDZGliM2hCSnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVltOTRRU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0yTVFvZ0lDQWdMeThnZEdocGN5NWliM2hCTG5aaGJIVmxJRDBnWVFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UXlDaUFnSUNBdkx5QmliM2hDSUQwZ1FtOTRQR0Z5WXpRdVJIbHVZVzFwWTBKNWRHVnpQaWg3SUd0bGVUb2dKMkluSUgwcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16WXlDaUFnSUNBdkx5QjBhR2x6TG1KdmVFSXVkbUZzZFdVZ1BTQmtlVzVoYldsalFubDBaWE1LSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpReUNpQWdJQ0F2THlCaWIzaENJRDBnUW05NFBHRnlZelF1UkhsdVlXMXBZMEo1ZEdWelBpaDdJR3RsZVRvZ0oySW5JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ppSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpZeUNpQWdJQ0F2THlCMGFHbHpMbUp2ZUVJdWRtRnNkV1VnUFNCa2VXNWhiV2xqUW5sMFpYTUtJQ0FnSUdScFp5QTFDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRNS0lDQWdJQzh2SUdKdmVFTWdQU0JDYjNnOFlYSmpOQzVUZEhJK0tIc2dhMlY1T2lBblFrOVlYME1uSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKQ1QxaGZReUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0yTXdvZ0lDQWdMeThnZEdocGN5NWliM2hETG5aaGJIVmxJRDBnWXdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5ETUtJQ0FnSUM4dklHSnZlRU1nUFNCQ2IzZzhZWEpqTkM1VGRISStLSHNnYTJWNU9pQW5RazlZWDBNbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSkNUMWhmUXlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNMk13b2dJQ0FnTHk4Z2RHaHBjeTVpYjNoRExuWmhiSFZsSUQwZ1l3b2dJQ0FnWkdsbklESUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTkFvZ0lDQWdMeThnWW05NFJDQTlJRUp2ZUR4aWVYUmxjejRvZXlCclpYazZJQ2RpYjNoRUp5QjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZbTk0UkNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNMk5Bb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoRUxuWmhiSFZsSUQwZ1pIbHVZVzFwWTBKNWRHVnpMbTVoZEdsMlpRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORFFLSUNBZ0lDOHZJR0p2ZUVRZ1BTQkNiM2c4WW5sMFpYTStLSHNnYTJWNU9pQW5ZbTk0UkNjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltSnZlRVFpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TmpRS0lDQWdJQzh2SUhSb2FYTXVZbTk0UkM1MllXeDFaU0E5SUdSNWJtRnRhV05DZVhSbGN5NXVZWFJwZG1VS0lDQWdJR1JwWnlBekNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORGNLSUNBZ0lDOHZJR0p2ZUV4aGNtZGxJRDBnUW05NFBFeGhjbWRsVTNSeWRXTjBQaWg3SUd0bGVUb2dKMkp2ZUV4aGNtZGxKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWW05NFRHRnlaMlVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TmpVS0lDQWdJQzh2SUhSb2FYTXVZbTk0VEdGeVoyVXVZM0psWVhSbEtDa0tJQ0FnSUhCMWMyaHBiblFnTmpFMk1Bb2dJQ0FnWW05NFgyTnlaV0YwWlFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TmpZS0lDQWdJQzh2SUhSb2FYTXVZbTk0VEdGeVoyVXVkbUZzZFdVdVpTQTlJRFF5Q2lBZ0lDQndkWE5vYVc1MElEUXlDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORGNLSUNBZ0lDOHZJR0p2ZUV4aGNtZGxJRDBnUW05NFBFeGhjbWRsVTNSeWRXTjBQaWg3SUd0bGVUb2dKMkp2ZUV4aGNtZGxKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWW05NFRHRnlaMlVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TmpZS0lDQWdJQzh2SUhSb2FYTXVZbTk0VEdGeVoyVXVkbUZzZFdVdVpTQTlJRFF5Q2lBZ0lDQnBiblJqSURRZ0x5OGdOREE1TmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpTQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpRM0NpQWdJQ0F2THlCaWIzaE1ZWEpuWlNBOUlFSnZlRHhNWVhKblpWTjBjblZqZEQ0b2V5QnJaWGs2SUNkaWIzaE1ZWEpuWlNjZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltSnZlRXhoY21kbElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16WTNDaUFnSUNBdkx5QjBhR2x6TG1KdmVFeGhjbWRsTG5KbGNHeGhZMlVvWVhKak5DNXphWHBsVDJZOFFubDBaWE14TURJMFBpZ3BJQ29nTkN3Z2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0RReUtTNWllWFJsY3lrS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTURrMkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREpoQ2lBZ0lDQmliM2hmY21Wd2JHRmpaUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelF4Q2lBZ0lDQXZMeUJpYjNoQklEMGdRbTk0UEhWcGJuUTJORDRvZXlCclpYazZJQ2RpYjNoQkp5QjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZbTk0UVNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNM01Rb2dJQ0FnTHk4Z2RHaHBjeTVpYjNoQkxuWmhiSFZsSUNzOUlETUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCaWRHOXBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTVFvZ0lDQWdMeThnWW05NFFTQTlJRUp2ZUR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWW05NFFTY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUp2ZUVFaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek56RUtJQ0FnSUM4dklIUm9hWE11WW05NFFTNTJZV3gxWlNBclBTQXpDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TkRFS0lDQWdJQzh2SUdKdmVFRWdQU0JDYjNnOGRXbHVkRFkwUGloN0lHdGxlVG9nSjJKdmVFRW5JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0ppYjNoQklnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16YzBDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpYjNoQkxteGxibWQwYUNBOVBUMGdPQ2tLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJSEJ2Y0FvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTWdvZ0lDQWdMeThnWW05NFFpQTlJRUp2ZUR4aGNtTTBMa1I1Ym1GdGFXTkNlWFJsY3o0b2V5QnJaWGs2SUNkaUp5QjlLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0zTlFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRRaTVzWlc1bmRHZ2dQVDA5SUdSNWJtRnRhV05DZVhSbGN5NWllWFJsY3k1c1pXNW5kR2dwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelF6Q2lBZ0lDQXZMeUJpYjNoRElEMGdRbTk0UEdGeVl6UXVVM1J5UGloN0lHdGxlVG9nSjBKUFdGOURKeUI5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpUWs5WVgwTWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOellLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmVFTXViR1Z1WjNSb0lEMDlQU0JqTG1KNWRHVnpMbXhsYm1kMGFDa0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORFFLSUNBZ0lDOHZJR0p2ZUVRZ1BTQkNiM2c4WW5sMFpYTStLSHNnYTJWNU9pQW5ZbTk0UkNjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltSnZlRVFpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96TnpjS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRVF1YkdWdVozUm9JRDA5UFNCa2VXNWhiV2xqUW5sMFpYTXVibUYwYVhabExteGxibWQwYUNrS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUhCdmNBb2dJQ0FnWkdsbklEUUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UXpDaUFnSUNBdkx5QmliM2hESUQwZ1FtOTRQR0Z5WXpRdVUzUnlQaWg3SUd0bGVUb2dKMEpQV0Y5REp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlRazlZWDBNaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek9EQUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUp2ZUVNdWRtRnNkV1V1WW5sMFpYTXVZWFFvTUNrZ1BUMDlJR011WW5sMFpYTXVZWFFvTUNrcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCa2FXY2dOUW9nSUNBZ1pYaDBjbUZqZENBd0lERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTRNUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFF5NTJZV3gxWlM1aWVYUmxjeTVoZENndE1Ta2dQVDA5SUdNdVlubDBaWE11WVhRb0xURXBLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5ETUtJQ0FnSUM4dklHSnZlRU1nUFNCQ2IzZzhZWEpqTkM1VGRISStLSHNnYTJWNU9pQW5RazlZWDBNbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSkNUMWhmUXlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNNE1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0UXk1MllXeDFaUzVpZVhSbGN5NWhkQ2d0TVNrZ1BUMDlJR011WW5sMFpYTXVZWFFvTFRFcEtRb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdScFp5QTJDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak00TWdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRReTUyWVd4MVpTNWllWFJsY3k1emJHbGpaU2d3TENBdE1Ta2dQVDA5SUdNdVlubDBaWE11YzJ4cFkyVW9NQ3dnTFRFcEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1JwWnlBekNpQWdJQ0ErUFFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdScFp5QTBDaUFnSUNBK1BRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR1JwWnlBMUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURRS0lDQWdJSE4zWVhBS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lEd0tJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCelpXeGxZM1FLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXRDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORE1LSUNBZ0lDOHZJR0p2ZUVNZ1BTQkNiM2c4WVhKak5DNVRkSEkrS0hzZ2EyVjVPaUFuUWs5WVgwTW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pDVDFoZlF5SUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTRNZ29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFF5NTJZV3gxWlM1aWVYUmxjeTV6YkdsalpTZ3dMQ0F0TVNrZ1BUMDlJR011WW5sMFpYTXVjMnhwWTJVb01Dd2dMVEVwS1FvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrYVdjZ05nb2dJQ0FnUGowS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmthV2NnTndvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCa2FXY2dOd29nSUNBZ1BqMEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JrYVdjZ09Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1JwWnlBM0NpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ2MyVnNaV04wQ2lBZ0lDQmthV2NnT0FvZ0lDQWdaR2xuSURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96T0RNS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRU11ZG1Gc2RXVXVZbmwwWlhNdWMyeHBZMlVvTUN3Z01pa2dQVDA5SUdNdVlubDBaWE11YzJ4cFkyVW9NQ3dnTWlrcENpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdaR2xuSURVS0lDQWdJRDQ5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURJS0lDQWdJQzBLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTXdvZ0lDQWdMeThnWW05NFF5QTlJRUp2ZUR4aGNtTTBMbE4wY2o0b2V5QnJaWGs2SUNkQ1QxaGZReWNnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSWtKUFdGOURJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNemd6Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaERMblpoYkhWbExtSjVkR1Z6TG5Oc2FXTmxLREFzSURJcElEMDlQU0JqTG1KNWRHVnpMbk5zYVdObEtEQXNJRElwS1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ1pHbG5JRFVLSUNBZ0lENDlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkp2ZUMxd2NtOTRhV1Z6TG1Gc1oyOHVkSE02TXpRMENpQWdJQ0F2THlCaWIzaEVJRDBnUW05NFBHSjVkR1Z6UGloN0lHdGxlVG9nSjJKdmVFUW5JSDBwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0ppYjNoRUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16ZzJDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVpYjNoRUxuWmhiSFZsTG1GMEtEQXBJRDA5UFNCa2VXNWhiV2xqUW5sMFpYTXVibUYwYVhabExtRjBLREFwS1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmxlSFJ5WVdOMElESWdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNemczQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaEVMblpoYkhWbExtRjBLQzB4S1NBOVBUMGdaSGx1WVcxcFkwSjVkR1Z6TG01aGRHbDJaUzVoZENndE1Ta3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNME5Bb2dJQ0FnTHk4Z1ltOTRSQ0E5SUVKdmVEeGllWFJsY3o0b2V5QnJaWGs2SUNkaWIzaEVKeUI5S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWW05NFJDSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTROd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFJDNTJZV3gxWlM1aGRDZ3RNU2tnUFQwOUlHUjVibUZ0YVdOQ2VYUmxjeTV1WVhScGRtVXVZWFFvTFRFcEtRb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdScFp5QTBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak00T0FvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTRSQzUyWVd4MVpTNXpiR2xqWlNnd0xDQXRNU2tnUFQwOUlHUjVibUZ0YVdOQ2VYUmxjeTV1WVhScGRtVXVjMnhwWTJVb01Dd2dMVEVwS1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQStQUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdScFp5QXpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR1JwWnlBekNpQWdJQ0ErUFFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdScFp5QXhDaUFnSUNBdENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WW05NExYQnliM2hwWlhNdVlXeG5ieTUwY3pvek5EUUtJQ0FnSUM4dklHSnZlRVFnUFNCQ2IzZzhZbmwwWlhNK0tIc2dhMlY1T2lBblltOTRSQ2NnZlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1KdmVFUWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pPRGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmVFUXVkbUZzZFdVdWMyeHBZMlVvTUN3Z0xURXBJRDA5UFNCa2VXNWhiV2xqUW5sMFpYTXVibUYwYVhabExuTnNhV05sS0RBc0lDMHhLU2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaR2xuSURNS0lDQWdJRDQ5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pHbG5JRFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWkdsbklEUUtJQ0FnSUQ0OUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdaR2xuSURVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BBb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pHbG5JRFlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNemc1Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaEVMblpoYkhWbExuTnNhV05sS0RBc0lEVXBJRDA5UFNCa2VXNWhiV2xqUW5sMFpYTXVibUYwYVhabExuTnNhV05sS0RBc0lEVXBLUW9nSUNBZ2NIVnphR2x1ZENBMUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnUGowS0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ1pHbG5JRFVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCa2FXY2dNZ29nSUNBZ0xRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJKdmVDMXdjbTk0YVdWekxtRnNaMjh1ZEhNNk16UTBDaUFnSUNBdkx5QmliM2hFSUQwZ1FtOTRQR0o1ZEdWelBpaDdJR3RsZVRvZ0oySnZlRVFuSUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaWIzaEVJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNemc1Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aWIzaEVMblpoYkhWbExuTnNhV05sS0RBc0lEVXBJRDA5UFNCa2VXNWhiV2xqUW5sMFpYTXVibUYwYVhabExuTnNhV05sS0RBc0lEVXBLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ1pHbG5JRFFLSUNBZ0lENDlDaUFnSUNCd2RYTm9hVzUwSURVS0lDQWdJR1JwWnlBMUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURZS0lDQWdJR1JwWnlBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aWIzZ3RjSEp2ZUdsbGN5NWhiR2R2TG5Sek9qTTVNQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05NFJDNTJZV3gxWlM1emJHbGpaU2d3TENCVmFXNTBOalFvTWlrcElEMDlQU0JrZVc1aGJXbGpRbmwwWlhNdWJtRjBhWFpsTG5Oc2FXTmxLREFzSUZWcGJuUTJOQ2d5S1NrcENpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdaR2xuSURRS0lDQWdJRDQ5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaR2xuSURJS0lDQWdJQzBLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWliM2d0Y0hKdmVHbGxjeTVoYkdkdkxuUnpPak0wTkFvZ0lDQWdMeThnWW05NFJDQTlJRUp2ZUR4aWVYUmxjejRvZXlCclpYazZJQ2RpYjNoRUp5QjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZbTk0UkNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlpYjNndGNISnZlR2xsY3k1aGJHZHZMblJ6T2pNNU1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZbTk0UkM1MllXeDFaUzV6YkdsalpTZ3dMQ0JWYVc1ME5qUW9NaWtwSUQwOVBTQmtlVzVoYldsalFubDBaWE11Ym1GMGFYWmxMbk5zYVdObEtEQXNJRlZwYm5RMk5DZ3lLU2twQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCa2FXY2dNd29nSUNBZ1BqMEtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCemQyRndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pORGNLSUNBZ0lDOHZJR0p2ZUV4aGNtZGxJRDBnUW05NFBFeGhjbWRsVTNSeWRXTjBQaWg3SUd0bGVUb2dKMkp2ZUV4aGNtZGxKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWW05NFRHRnlaMlVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZbTk0TFhCeWIzaHBaWE11WVd4bmJ5NTBjem96T1RFS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtSnZlRXhoY21kbExteGxibWQwYUNBOVBUMGdZWEpqTkM1emFYcGxUMlk4VEdGeVoyVlRkSEoxWTNRK0tDa3BDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQndiM0FLSUNBZ0lIQjFjMmhwYm5RZ05qRTJNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwySnZlQzF3Y205NGFXVnpMbUZzWjI4dWRITTZNelU1Q2lBZ0lDQXZMeUJ6WlhSQ2IzaGxjeWhoT2lCMWFXNTBOalFzSUdJNklHSjVkR1Z6TENCak9pQmhjbU0wTGxOMGNpa2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1qUTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlltOTRMWEJ5YjNocFpYTXVZV3huYnk1MGN6b3pOREFLSUNBZ0lDOHZJR05zWVhOeklFRnlZelJDYjNoRGIyNTBjbUZqZENCbGVIUmxibVJ6SUdGeVl6UXVRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmZjSFY1WVY5c2FXSXVkWFJwYkM1bGJuTjFjbVZmWW5Wa1oyVjBLSEpsY1hWcGNtVmtYMkoxWkdkbGREb2dkV2x1ZERZMExDQm1aV1ZmYzI5MWNtTmxPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbVZ1YzNWeVpWOWlkV1JuWlhRNkNpQWdJQ0J3Y205MGJ5QXlJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnS3dvS1pXNXpkWEpsWDJKMVpHZGxkRjkzYUdsc1pWOTBiM0JBTVRvS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQm5iRzlpWVd3Z1QzQmpiMlJsUW5Wa1oyVjBDaUFnSUNBK0NpQWdJQ0JpZWlCbGJuTjFjbVZmWW5Wa1oyVjBYMkZtZEdWeVgzZG9hV3hsUURZS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIQjFjMmhwYm5RZ05pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQndkWE5vYVc1MElEVWdMeThnUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQmllWFJsWXlBeE5TQXZMeUF3ZURBMk9ERXdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJ5YjNaaGJGQnliMmR5WVcwS0lDQWdJR0o1ZEdWaklERTFJQzh2SURCNE1EWTRNVEF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOM2FYUmphQ0JsYm5OMWNtVmZZblZrWjJWMFgzTjNhWFJqYUY5allYTmxYekJBTXlCbGJuTjFjbVZmWW5Wa1oyVjBYM04zYVhSamFGOWpZWE5sWHpGQU5Bb0taVzV6ZFhKbFgySjFaR2RsZEY5emQybDBZMmhmWTJGelpWOXVaWGgwUURVNkNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdZaUJsYm5OMWNtVmZZblZrWjJWMFgzZG9hV3hsWDNSdmNFQXhDZ3BsYm5OMWNtVmZZblZrWjJWMFgzTjNhWFJqYUY5allYTmxYekZBTkRvS0lDQWdJR2RzYjJKaGJDQk5hVzVVZUc1R1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCaUlHVnVjM1Z5WlY5aWRXUm5aWFJmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUExQ2dwbGJuTjFjbVZmWW5Wa1oyVjBYM04zYVhSamFGOWpZWE5sWHpCQU16b0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnWWlCbGJuTjFjbVZmWW5Wa1oyVjBYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOUW9LWlc1emRYSmxYMkoxWkdkbGRGOWhablJsY2w5M2FHbHNaVUEyT2dvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQVFBSUFvQWdKaEFGUWs5WVgwTUVZbXh2WWdoaWIzaE1ZWEpuWlFSaWIzaEJCR0p2ZUVRQllneDBiMjlOWVc1NVFtOXZiSE1FQUFFQ0F3UVZIM3gxQ0cxaGJubEpiblJ6QVRBRmFHVnNiRzhHWW05NFVtVm1CQUFDTkRJQ05ESURCb0VCZ0FCSEFqRWJRUVVETVJrVVJERVlSSUlQQkNmM2Eya0VrU05oZWdUM0pqbElCQW04dWw0RWVnMDl5QVI5QTV0REJEdkRzdmtFM041aFRRVGhPUmNoQkdnN1hHUUVwYVltL2dTUU9lM2VCQ2l5NGtFRWpjN1htd1FjZC9TV05ob0FqZzhDa1FLUEFvWUNhZ0l1QWU0QjNRR1lBV2tCSGdENUFKUUFpd0JhQUFFQU5ob0JTUlVrRWtRWFJRS0J5R1VqaUFTQkkwVUJKd2E5UlFGRUkwVURTd0tCNklFQ0RFRUFLRXNDU1NRS1RDUVlKd1pQQWlLNlRGTkJBQVZKSWdoRkFVbExBaEpBQUFsTEFpSUlSUU5DLzg1SkZpY0lURkN3SWtNMkdnRkpGU1FTUkJjMkdnSkpGU0lTUkNOVFN3RWtDazhDSkJnbkJrc0NJcnBMQVNRTVJFeFBBMVFuQms0Q3V5SkRKd2FCblNDNVNDSkRLYjFGQVJSRUtZRWd1VVF4QURJS0tTTkxBN3NwZ2NBKzB5a2pTVXNEMGltQlFDY0x1eWtqZ1VXNlN3RkxBMUFuQzFBU1JDbThTQ20rU1JSRVN3R0FBQkpFU3dOT0FrMUxBaEpFVUNtOFNDbE12eW05U0lGQUVrUW5ESUVndVVnbkRMeElJa09BQVdRbkI3OG5CeU5WRkVRbkJ5SlZJaEpFSndjbFZTVVNSQ2NIZ1FOVmdRTVNSQ0pESndxOFNDY0tnQk5VWlhOMGFXNW5JSFJsYzNScGJtY2dNVEl6dnljS0k0RUh1b0FIVkdWemRHbHVaeEpFS0x4SUtJQUhBQVZJWld4c2I3OG9KWUVGdW9BRlNHVnNiRzhTUkNKREs3MUZBU2NGdlU0Q1NDaTlUZ05JS3IxT0JFaUFBUUFqVHdKVUlrOENWQ1ZQQWxTQkEwOENWQ2NJVEZDd0lrTXJ2a1FYSWdnaUNTY0Z2a1JYQWdBb3ZrUXFJUVFrdWhkUEF4WkxBeFVXVndZQ1R3UlFUSUFDQUJSUVN3RVZnUlFJRmxjR0FsQlBBaFpRVEZCTVVDY0lURkN3SWtNcUlRUWt1aGNpQ0JZcUlRUlBBcnNpUXl1OFNDY0Z2RWdvdkVncnZrd1hnU3BMQVVzRFRZRXFFa1FuQmI0bkRVNENUVmNDQUNjT0VrUW92aWNOVGdKTlZ3SUFKdzRTUkV3VVJCUkVLcnhJSWtPQmhGSWppQUpmSTBVQkp3bTlSUUZFSTBVRFN3S0JnUVFNUVFBWFN3SkpKQXNuQ1V3a3VoZExBZ2hGQWlJSVJRTkMvK0JKRmljSVRGQ3dJa00yR2dGSkZTUVNSQmMyR2dKSkZTUVNSRXdrQ3ljSlRFOEN1eUpESndtQmlDQzVTQ0pESWtNMkdnRkpGU1FTUkJjMkdnSkpJMWtsQ0VzQkZVbFBBaEpFU3dGWEFnQTJHZ05KSTFrbENFc0JGVWxQQWhKRVR3VVdLMHkvSndXOFNDY0ZTd1cvS0x4SUtFc0N2eWNFdkVnbkJFc0R2eXFCa0RDNVNJRXFGaW9oQkU4Q3V5b2hCSUFJQUFBQUFBQUFBQ3E3Szc1RUY0RURDQllyVEw4cnZVZ2tFa1FuQmIxSVR3UVNSQ2k5UkVsTEFoSkVKd1M5U0VzRUZVb1NSQ2dqSXJwTEJWY0FBUkpFU3dJaUNTaE1JcnBMQkNJSlN3Wk1JbGdTUkNOTEF3OGpTd1JQQWswaVN3UVBJa3NGVHdKTlN3Uk1DVWxMQWd4TEFreE5Td0VKS0VzQ1R3SzZJMHNHRHlOTEIwOENUU0pMQnc4aVN3aFBBazFMQjB3SlNVc0NERXNDVEUxTENFc0NUd0pTVHdJU1JDVkxCUThsVHdaUEFrMUxBZ2tvVHdOUEFyb2xTd1VQSlU4R1R3Sk5Ud1ZQQTA4Q1VoSkVKd1FqSXJwUEJGY0NBUkpFU3dFaUNTY0VUQ0s2U3dFaUNVc0VUQ0pZRWtRalN3SVBJMHNEVHdKTklrc0REeUpMQkU4Q1RVc0RUQWxKU3dJTVN3Sk1UVXNCQ1NjRVN3SlBBcm9qU3dNUEkwc0VUd0pOSWtzRUR5SkxCVThDVFVzRVRBbEpTd0lNU3dKTVRVc0dTd0pQQWxKUEFoSkVnUVZMQkErQkJVc0ZUd0pOU3dJSkp3UkxBMDhDdW9FRlN3UVBnUVZMQlU4Q1RVc0dTd05QQWxJU1JDVkxCQThsVHdWUEFrMUxBZ2tuQkU4RFR3SzZKVXNERHlWUEJFOENUVXhPQTFJU1JDcTlTSUdRTUJKRUlrTXhHUlF4R0JRUVE0b0NBSXYrZ1FvSWl3QXlEQTFCQUNxeGdRYXlFSUVGc2hrbkQ3SWVKdyt5SDR2L2pRSUFDd0FFczBMLzJ6SUFzZ0ZDLy9VanNnRkMvKytKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
