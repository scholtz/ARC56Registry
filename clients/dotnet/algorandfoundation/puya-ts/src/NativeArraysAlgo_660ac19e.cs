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

namespace Arc56.Generated.algorandfoundation.puya_ts.NativeArraysAlgo_660ac19e
{


    public class NativeArraysAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NativeArraysAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Vector : AVMObjectType
            {
                public ulong X { get; set; }

                public ulong Y { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vY.From(Y);
                    ret.AddRange(vY.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Vector Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Vector();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueX = vX.ToValue();
                    if (valueX is ulong vXValue) { ret.X = vXValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vY.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueY = vY.ToValue();
                    if (valueY is ulong vYValue) { ret.Y = vYValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Vector);
                }
                public bool Equals(Vector? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Vector left, Vector right)
                {
                    return EqualityComparer<Vector>.Default.Equals(left, right);
                }
                public static bool operator !=(Vector left, Vector right)
                {
                    return !(left == right);
                }

            }

            public class BooleansStaticReturn : AVMObjectType
            {
                public bool Field0 { get; set; }

                public bool Field1 { get; set; }

                public bool Field2 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BooleansStaticReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BooleansStaticReturn();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BooleansStaticReturn);
                }
                public bool Equals(BooleansStaticReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BooleansStaticReturn left, BooleansStaticReturn right)
                {
                    return EqualityComparer<BooleansStaticReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(BooleansStaticReturn left, BooleansStaticReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ReadonlyArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 49, 133, 137 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReadonlyArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 49, 133, 137 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ArrayInObject(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 172, 144, 102 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ArrayInObject_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 176, 172, 144, 102 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong[]> BuildArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 76, 17, 202 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> BuildArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 76, 17, 202 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong[]> ArrayFromCtor(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 162, 159, 112 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> ArrayFromCtor_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 162, 159, 112 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong[]> BuildReadonly(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 213, 224, 53 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> BuildReadonly_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 213, 224, 53 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DoThings(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 165, 136, 200 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DoThings_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 19, 165, 136, 200 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="y"> </param>
        public async Task FixedArray(ulong[] y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 236, 193, 230 };
            var yAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(50, "uint64"); yAbi.From(y);

            var result = await base.CallApp(new List<object> { abiHandle, yAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FixedArray_Transactions(ulong[] y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 236, 193, 230 };
            var yAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(50, "uint64"); yAbi.From(y);

            return await base.MakeTransactionList(new List<object> { abiHandle, yAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Arc4Interop(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 123, 80, 178 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Arc4Interop_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 123, 80, 178 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="p"> Vector</param>
        public async Task<Structs.Vector[]> Structs(Structs.Vector p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 135, 160, 100 };

            var result = await base.CallApp(new List<object> { abiHandle, p }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Vector>(x => Structs.Vector.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> Structs_Transactions(Structs.Vector p, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 135, 160, 100 };

            return await base.MakeTransactionList(new List<object> { abiHandle, p }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool[]> Booleans(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 97, 214, 184 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Bool>("bool");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (bool)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> Booleans_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 97, 214, 184 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.BooleansStaticReturn> BooleansStatic(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 143, 84, 68, 115 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BooleansStaticReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> BooleansStatic_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 143, 84, 68, 115 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool[]> Arc4Booleans(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 231, 238, 69 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Bool>("bool");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (bool)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> Arc4Booleans_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 231, 238, 69 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.BooleansStaticReturn> Arc4BooleansStatic(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 227, 164, 248 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BooleansStaticReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Arc4BooleansStatic_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 227, 164, 248 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mutable"> </param>
        /// <param name="readOnly"> </param>
        public async Task Aliasing(ulong[] mutable, ulong[] readOnly, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 63, 34, 59 };
            var mutableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); mutableAbi.From(mutable);
            var readOnlyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); readOnlyAbi.From(readOnly);

            var result = await base.CallApp(new List<object> { abiHandle, mutableAbi, readOnlyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Aliasing_Transactions(ulong[] mutable, ulong[] readOnly, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 63, 34, 59 };
            var mutableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); mutableAbi.From(mutable);
            var readOnlyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); readOnlyAbi.From(readOnly);

            return await base.MakeTransactionList(new List<object> { abiHandle, mutableAbi, readOnlyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task ReceiveMutable(ulong[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 137, 84, 66 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReceiveMutable_Transactions(ulong[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 137, 84, 66 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task ReceiveReadonly(ulong[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 19, 245, 182 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReceiveReadonly_Transactions(ulong[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 226, 19, 245, 182 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTmF0aXZlQXJyYXlzQWxnbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJWZWN0b3IiOlt7Im5hbWUiOiJ4IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InkiLCJ0eXBlIjoidWludDY0In1dLCJCb29sZWFuc1N0YXRpY1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJyZWFkb25seUFycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFycmF5SW5PYmplY3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnVpbGRBcnJheSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXJyYXlGcm9tQ3RvciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYnVpbGRSZWFkb25seSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZG9UaGluZ3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZml4ZWRBcnJheSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbNTBdIiwic3RydWN0IjpudWxsLCJuYW1lIjoieSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM0SW50ZXJvcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdHJ1Y3RzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlZlY3RvciIsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KVtdIiwic3RydWN0IjoiVmVjdG9yIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYm9vbGVhbnMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJib29sZWFuc1N0YXRpYyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCxib29sLGJvb2wpIiwic3RydWN0IjoiQm9vbGVhbnNTdGF0aWNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM0Qm9vbGVhbnMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcmM0Qm9vbGVhbnNTdGF0aWMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKGJvb2wsYm9vbCxib29sKSIsInN0cnVjdCI6IkJvb2xlYW5zU3RhdGljUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWxpYXNpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtdXRhYmxlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlYWRPbmx5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY2VpdmVNdXRhYmxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNlaXZlUmVhZG9ubHkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTY1MF0sImVycm9yTWVzc2FnZSI6IlRoZXNlIHNob3VsZCBub3QgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzAsNTEwLDU2Nyw2MjMsNjYzLDgzNyw5OTgsMTE3NCwxMzc0LDE1MTYsMTU4OV0sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTNdLCJlcnJvck1lc3NhZ2UiOiJjYW5ub3QgcG9wIGZyb20gZW1wdHkgYXJyYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzAsNTc1LDE2NDVdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4NCw0NTYsNTMxLDU4MCw2MjcsNzMzLDg2MCwxMDUxLDEyMzQsMTM5MSwxNTY2LDE2MDYsMTYyMywxNjU4LDE2NzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjE3LDE2MzMsMTY2OCwxNjg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx1aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUyOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTx1aW50NjQsIDUwPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdGVzdHMvYXBwcm92YWxzL25hdGl2ZS1hcnJheXMuYWxnby50czo6VmVjdG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0EwSURFd0lEQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05XRXdJREI0TVRVeFpqZGpOelV3TURBellUQWdNSGd4TlRGbU4yTTNOVEF3TURRd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNakF3TURBd01EQXdNREF3TURBd01ETXdNREF3TURBd01EQXdNREF3TURBMElEQjRNRFk0TVRBeElEQjRNREF3TlRBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXlNREF3TURBd01EQXdNREF3TURBd016QXdNREF3TURBd01EQXdNREF3TURRd01EQXdNREF3TURBd01EQXdNREExQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZibUYwYVhabExXRnljbUY1Y3k1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk9ZWFJwZG1WQmNuSmhlWE5CYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREl6Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGczWkRNeE9EVTRPU0F3ZUdJd1lXTTVNRFkySURCNE1HWTBZekV4WTJFZ01IaGhZV0V5T1dZM01DQXdlR1V5WkRWbE1ETTFJREI0TVROaE5UZzRZemdnTUhoa05tVmpZekZsTmlBd2VEYzROMkkxTUdJeUlEQjRaV0k0TjJFd05qUWdNSGhpWXpZeFpEWmlPQ0F3ZURobU5UUTBORGN6SURCNE5ETmxOMlZsTkRVZ01IaGpZbVV6WVRSbU9DQXdlREUwTTJZeU1qTmlJREI0WkRrNE9UVTBORElnTUhobE1qRXpaalZpTmlBdkx5QnRaWFJvYjJRZ0luSmxZV1J2Ym14NVFYSnlZWGtvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZ5Y21GNVNXNVBZbXBsWTNRb0tYWnZhV1FpTENCdFpYUm9iMlFnSW1KMWFXeGtRWEp5WVhrb0tYVnBiblEyTkZ0ZElpd2diV1YwYUc5a0lDSmhjbkpoZVVaeWIyMURkRzl5S0NsMWFXNTBOalJiWFNJc0lHMWxkR2h2WkNBaVluVnBiR1JTWldGa2IyNXNlU2dwZFdsdWREWTBXMTBpTENCdFpYUm9iMlFnSW1SdlZHaHBibWR6S0NsMmIybGtJaXdnYldWMGFHOWtJQ0ptYVhobFpFRnljbUY1S0hWcGJuUTJORnMxTUYwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVhKak5FbHVkR1Z5YjNBb0tYWnZhV1FpTENCdFpYUm9iMlFnSW5OMGNuVmpkSE1vS0hWcGJuUTJOQ3gxYVc1ME5qUXBLU2gxYVc1ME5qUXNkV2x1ZERZMEtWdGRJaXdnYldWMGFHOWtJQ0ppYjI5c1pXRnVjeWdwWW05dmJGdGRJaXdnYldWMGFHOWtJQ0ppYjI5c1pXRnVjMU4wWVhScFl5Z3BLR0p2YjJ3c1ltOXZiQ3hpYjI5c0tTSXNJRzFsZEdodlpDQWlZWEpqTkVKdmIyeGxZVzV6S0NsaWIyOXNXMTBpTENCdFpYUm9iMlFnSW1GeVl6UkNiMjlzWldGdWMxTjBZWFJwWXlncEtHSnZiMndzWW05dmJDeGliMjlzS1NJc0lHMWxkR2h2WkNBaVlXeHBZWE5wYm1jb2RXbHVkRFkwVzEwc2RXbHVkRFkwVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WalpXbDJaVTExZEdGaWJHVW9kV2x1ZERZMFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVmpaV2wyWlZKbFlXUnZibXg1S0hWcGJuUTJORnRkS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgzSmxZV1J2Ym14NVFYSnlZWGxmY205MWRHVkFOQ0J0WVdsdVgyRnljbUY1U1c1UFltcGxZM1JmY205MWRHVkFOU0J0WVdsdVgySjFhV3hrUVhKeVlYbGZjbTkxZEdWQU5pQnRZV2x1WDJGeWNtRjVSbkp2YlVOMGIzSmZjbTkxZEdWQU55QnRZV2x1WDJKMWFXeGtVbVZoWkc5dWJIbGZjbTkxZEdWQU9DQmtiMVJvYVc1bmN5Qm1hWGhsWkVGeWNtRjVJRzFoYVc1ZllYSmpORWx1ZEdWeWIzQmZjbTkxZEdWQU1URWdjM1J5ZFdOMGN5QnRZV2x1WDJKdmIyeGxZVzV6WDNKdmRYUmxRREV6SUcxaGFXNWZZbTl2YkdWaGJuTlRkR0YwYVdOZmNtOTFkR1ZBTVRRZ2JXRnBibDloY21NMFFtOXZiR1ZoYm5OZmNtOTFkR1ZBTVRVZ2JXRnBibDloY21NMFFtOXZiR1ZoYm5OVGRHRjBhV05mY205MWRHVkFNVFlnWVd4cFlYTnBibWNnY21WalpXbDJaVTExZEdGaWJHVWdjbVZqWldsMlpWSmxZV1J2Ym14NUNpQWdJQ0JsY25JS0NtMWhhVzVmWVhKak5FSnZiMnhsWVc1elUzUmhkR2xqWDNKdmRYUmxRREUyT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjVoZEdsMlpTMWhjbkpoZVhNdVlXeG5ieTUwY3pveE9URUtJQ0FnSUM4dklHRnlZelJDYjI5c1pXRnVjMU4wWVhScFl5Z3BJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOV0V3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZWEpqTkVKdmIyeGxZVzV6WDNKdmRYUmxRREUxT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjVoZEdsMlpTMWhjbkpoZVhNdVlXeG5ieTUwY3pveE9EY0tJQ0FnSUM4dklHRnlZelJDYjI5c1pXRnVjeWdwSUhzS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlRBd01ETmhNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySnZiMnhsWVc1elUzUmhkR2xqWDNKdmRYUmxRREUwT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjVoZEdsMlpTMWhjbkpoZVhNdVlXeG5ieTUwY3pveE9ETUtJQ0FnSUM4dklHSnZiMnhsWVc1elUzUmhkR2xqS0NrZ2V3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMVlUQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aWIyOXNaV0Z1YzE5eWIzVjBaVUF4TXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl1WVhScGRtVXRZWEp5WVhsekxtRnNaMjh1ZEhNNk1UYzVDaUFnSUNBdkx5QmliMjlzWldGdWN5Z3BJSHNLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOVEF3TUROaE1Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGeVl6UkpiblJsY205d1gzSnZkWFJsUURFeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGRHbDJaUzFoY25KaGVYTXVZV3huYnk1MGN6b3hOVGNLSUNBZ0lDOHZJR0Z5WXpSSmJuUmxjbTl3S0NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aWRXbHNaRkpsWVdSdmJteDVYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJtRjBhWFpsTFdGeWNtRjVjeTVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJpZFdsc1pGSmxZV1J2Ym14NUtDazZJRkpsWVdSdmJteDVRWEp5WVhrOGRXbHVkRFkwUGlCN0NpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVd01EQTBNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURJd01EQXdNREF3TURBd01EQXdNREF6TURBd01EQXdNREF3TURBd01EQXdOQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRnljbUY1Um5KdmJVTjBiM0pmY205MWRHVkFOem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZWFJwZG1VdFlYSnlZWGx6TG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUdGeWNtRjVSbkp2YlVOMGIzSW9LVG9nUVhKeVlYazhkV2x1ZERZMFBpQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNRE13TURBd01EQXdNREF3TURBd01EQXhNREF3TURBd01EQXdNREF3TURBd01qQXdNREF3TURBd01EQXdNREF3TURNS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpZFdsc1pFRnljbUY1WDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZibUYwYVhabExXRnljbUY1Y3k1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCaWRXbHNaRUZ5Y21GNUtDazZJRUZ5Y21GNVBIVnBiblEyTkQ0Z2V3b2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMU1EQXdOREF3TURBd01EQXdNREF3TURBd01ERXdNREF3TURBd01EQXdNREF3TURBeU1EQXdNREF3TURBd01EQXdNREF3TXpBd01EQXdNREF3TURBd01EQXdNRFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhjbkpoZVVsdVQySnFaV04wWDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZibUYwYVhabExXRnljbUY1Y3k1aGJHZHZMblJ6T2pJd0NpQWdJQ0F2THlCaGNuSmhlVWx1VDJKcVpXTjBLQ2tnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl5WldGa2IyNXNlVUZ5Y21GNVgzSnZkWFJsUURRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GMGFYWmxMV0Z5Y21GNWN5NWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklISmxZV1J2Ym14NVFYSnlZWGtvS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF5TXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl1WVhScGRtVXRZWEp5WVhsekxtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTVoZEdsMlpVRnljbUY1YzBGc1oyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklGOXdkWGxoWDJ4cFlpNWhjbU0wTG1SNWJtRnRhV05mWVhKeVlYbGZjRzl3WDJacGVHVmtYM05wZW1Vb1lYSnlZWGs2SUdKNWRHVnpMQ0JtYVhobFpGOWllWFJsWDNOcGVtVTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbVI1Ym1GdGFXTmZZWEp5WVhsZmNHOXdYMlpwZUdWa1gzTnBlbVU2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYkdWdUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQzBLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNQW9nSUNBZ2NtVndiR0ZqWlRJZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGRHbDJaUzFoY25KaGVYTXVZV3huYnk1MGN6bzZUbUYwYVhabFFYSnlZWGx6UVd4bmJ5NWtiMVJvYVc1bmMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVJ2VkdocGJtZHpPZ29LWkc5VWFHbHVaM05mZDJocGJHVmZkRzl3UURJNkNpQWdJQ0J3ZFhOb2FXNTBJREUwTVRBS0lDQWdJR2RzYjJKaGJDQlBjR052WkdWQ2RXUm5aWFFLSUNBZ0lENEtJQ0FnSUdKNklHUnZWR2hwYm1kelgyRm1kR1Z5WDNkb2FXeGxRRGNLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdSR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNRFk0TVRBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NISnZkbUZzVUhKdlozSmhiUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREEyT0RFd01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGJHVmhjbE4wWVhSbFVISnZaM0poYlFvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1lpQmtiMVJvYVc1bmMxOTNhR2xzWlY5MGIzQkFNZ29LWkc5VWFHbHVaM05mWVdaMFpYSmZkMmhwYkdWQU56b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dVlYUnBkbVV0WVhKeVlYbHpMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJR0Z5Y2k1d2RYTm9LRFVwQ2lBZ0lDQndkWE5vYVc1MElEVUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREExTURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01ESXdNREF3TURBd01EQXdNREF3TURBek1EQXdNREF3TURBd01EQXdNREF3TkRBd01EQXdNREF3TURBd01EQXdNRFVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZWFJwZG1VdFlYSnlZWGx6TG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUdGemMyVnlkQ2hoY25JdWNHOXdLQ2toSUQwOVBTQTFLUW9nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0JqWVd4c2MzVmlJR1I1Ym1GdGFXTmZZWEp5WVhsZmNHOXdYMlpwZUdWa1gzTnBlbVVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZWFJwZG1VdFlYSnlZWGx6TG1Gc1oyOHVkSE02TkRnS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tHRnljaXdnV3pFc0lESXNJRE1zSURSZEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z05Bb2dJQ0FnUFQwS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdKaVlLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdaR2xuSURRS0lDQWdJSEIxYzJocGJuUWdNVGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdaR2xuSURRS0lDQWdJSEIxYzJocGJuUWdNallLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdOQW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYSjBJSFJoY21kbGRDQnBjeUJ0WVhSamFDQm1iM0lnWTI5dVpHbDBhVzl1Y3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjVoZEdsMlpTMWhjbkpoZVhNdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0dGeWNsc3dYU0E5UFQwZ01Ta0tJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyNWhkR2wyWlMxaGNuSmhlWE11WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnWVhOelpYSjBLR0Z5Y2k1aGRDZ3RNU2toSUQwOVBTQTBLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lDb0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekVnTHk4Z05Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGRHbDJaUzFoY25KaGVYTXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdZWEp5TG5CMWMyZ29WV2x1ZERZMEtEVXBLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF3Q2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZibUYwYVhabExXRnljbUY1Y3k1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaGhjbklzSUZzeExDQXlMQ0F6TENBMExDQTFYU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTFDaUFnSUNBOVBRb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ1ltQ2lBZ0lDQmthV2NnTXdvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJREU0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJREkyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eElDOHZJRFFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTXpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVnlkQ0IwWVhKblpYUWdhWE1nYldGMFkyZ2dabTl5SUdOdmJtUnBkR2x2Ym5NS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl1WVhScGRtVXRZWEp5WVhsekxtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklHTnZibk4wSUhSdmNDQTlJR0Z5Y2k1d2IzQW9LU0VLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdElDOHZJRzl1SUdWeWNtOXlPaUJqWVc1dWIzUWdjRzl3SUdaeWIyMGdaVzF3ZEhrZ1lYSnlZWGtLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnS2dvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1kyRnNiSE4xWWlCa2VXNWhiV2xqWDJGeWNtRjVYM0J2Y0Y5bWFYaGxaRjl6YVhwbENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GMGFYWmxMV0Z5Y21GNWN5NWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QmhjM05sY25Rb2RHOXdJRDA5UFNBMUtRb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0ExQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZibUYwYVhabExXRnljbUY1Y3k1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaGhjbklzSUZzeExDQXlMQ0F6TENBMFhTa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QTBDaUFnSUNBOVBRb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYeklnTHk4Z01UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01UZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01qWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekVnTHk4Z05Bb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhKMElIUmhjbWRsZENCcGN5QnRZWFJqYUNCbWIzSWdZMjl1WkdsMGFXOXVjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyNWhkR2wyWlMxaGNuSmhlWE11WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnWVhKeVd6RmRJRDBnTVRBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdNVEFnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJtRjBhWFpsTFdGeWNtRjVjeTVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUJqYjI1emRDQmhjbkl5SUQwZ1lYSnlMbmRwZEdnb01Td2dOU2tLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J5WlhCc1lXTmxNaUF4TUNBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZWFJwZG1VdFlYSnlZWGx6TG1Gc1oyOHVkSE02TnpBS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tHRnljaXdnV3pFc0lERXdMQ0F6TENBMFhTa0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdOQW9nSUNBZ1BUMEtJQ0FnSUdScFp5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkdsbklEUUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FtSmdvZ0lDQWdaR2xuSURRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TUFvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCa2FXY2dOQW9nSUNBZ2NIVnphR2x1ZENBeE9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCa2FXY2dOQW9nSUNBZ2NIVnphR2x1ZENBeU5nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNU0F2THlBMENpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25RZ2RHRnlaMlYwSUdseklHMWhkR05vSUdadmNpQmpiMjVrYVhScGIyNXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJtRjBhWFpsTFdGeWNtRjVjeTVoYkdkdkxuUnpPamN4Q2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNoaGNuSXlMQ0JiTVN3Z05Td2dNeXdnTkYwcENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QTBDaUFnSUNBOVBRb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdScFp5QXpDaUFnSUNCcGJuUmpYeklnTHk4Z01UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURVS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ01UZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J3ZFhOb2FXNTBJREkyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eElDOHZJRFFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVnlkQ0IwWVhKblpYUWdhWE1nYldGMFkyZ2dabTl5SUdOdmJtUnBkR2x2Ym5NS0lDQWdJR1JwWnlBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyNWhkR2wyWlMxaGNuSmhlWE11WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnWVhKeUlEMGdZWEp5TG1OdmJtTmhkQ2hoY25JcExtTnZibU5oZENneE1Ta3VZMjl1WTJGMEtIUXhLUW9nSUNBZ2NIVnphR2x1ZENBeE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGRHbDJaUzFoY25KaGVYTXVZV3huYnk1MGN6bzNOUW9nSUNBZ0x5OGdZWEp5SUQwZ1lYSnlMbU52Ym1OaGRDaGhjbklwTG1OdmJtTmhkQ2d4TVNrdVkyOXVZMkYwS0hReEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZWFJwZG1VdFlYSnlZWGx6TG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUdGeWNpQTlJR0Z5Y2k1amIyNWpZWFFvWVhKeUtTNWpiMjVqWVhRb01URXBMbU52Ym1OaGRDaDBNU2tLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJREFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dVlYUnBkbVV0WVhKeVlYbHpMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJR052Ym5OMElIUXhPaUJiZFdsdWREWTBMQ0IxYVc1ME5qUmRJRDBnV3pFeUxDQXhNMTBLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01HTXdNREF3TURBd01EQXdNREF3TURCa0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dVlYUnBkbVV0WVhKeVlYbHpMbUZzWjI4dWRITTZOellLSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0dGeWNpd2dXekVzSURFd0xDQXpMQ0EwTENBeExDQXhNQ3dnTXl3Z05Dd2dNVEVzSURFeUxDQXhNMTBwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVEVLSUNBZ0lEMDlDaUFnSUNCa2FXY2dNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnSmlZS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6SWdMeThnTVRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6SWdMeThnTVRBS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ01UZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ01qWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekVnTHk4Z05Bb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdsdWRDQXpOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJRFF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9hVzUwSURVd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9hVzUwSURVNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURRS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhwYm5RZ05qWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURFeENpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vYVc1MElEYzBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2NIVnphR2x1ZENBeE1nb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdsdWRDQTRNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ01UTUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWeWRDQjBZWEpuWlhRZ2FYTWdiV0YwWTJnZ1ptOXlJR052Ym1ScGRHbHZibk1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZWFJwZG1VdFlYSnlZWGx6TG1Gc1oyOHVkSE02T0RNS0lDQWdJQzh2SUdOdmJuTjBJR1pCY25JeElEMGdibVYzSUVacGVHVmtRWEp5WVhrOGRXbHVkRFkwTENBMFBpZ3BDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnY0hWemFHbHVkQ0ExQ2lBZ0lDQmthV2NnTXdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREExTURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01ESXdNREF3TURBd01EQXdNREF3TURBek1EQXdNREF3TURBd01EQXdNREF3TkRBd01EQXdNREF3TURBd01EQXdNRFVLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZWFJwZG1VdFlYSnlZWGx6TG1Gc1oyOHVkSE02T1RJS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tHRnljalFzSUZzeExDQXlMQ0F6TENBMExDQTFMQ0F4TENBeE1Dd2dNeXdnTkN3Z01Td2dNVEFzSURNc0lEUXNJREV4TENBeE1pd2dNVE5kS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdQVDBLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJREU0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJREkyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eElDOHZJRFFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTXpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTkRJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBMU1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNaUF2THlBeE1Bb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQTFPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQTJOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTVNBdkx5QTBDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRGMwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnT0RJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6SWdMeThnTVRBS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ09UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ09UZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekVnTHk4Z05Bb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXhNRFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElERXhDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJREV4TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSEIxYzJocGJuUWdNVElLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F4TWpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJREV6Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxjblFnZEdGeVoyVjBJR2x6SUcxaGRHTm9JR1p2Y2lCamIyNWthWFJwYjI1ekNpQWdJQ0JwYm5Salh6RWdMeThnTkFvZ0lDQWdaR2xuSURNS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJtRjBhWFpsTFdGeWNtRjVjeTVoYkdkdkxuUnpPamszQ2lBZ0lDQXZMeUJqYjI1emRDQmhjbkkySUQwZ1prRnljakV1WTI5dVkyRjBLR0Z5Y2lrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EUXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjVoZEdsMlpTMWhjbkpoZVhNdVlXeG5ieTUwY3pvNU9Bb2dJQ0FnTHk4Z1lYTnpaWEowVFdGMFkyZ29ZWEp5Tml3Z1d6QXNJREFzSURBc0lEQXNJREVzSURFd0xDQXpMQ0EwTENBeExDQXhNQ3dnTXl3Z05Dd2dNVEVzSURFeUxDQXhNMTBwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJREUxQ2lBZ0lDQTlQUW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURFNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElESTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRE0wQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTkRJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6SWdMeThnTVRBS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ05UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ05UZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekVnTHk4Z05Bb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQTJOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRGMwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURneUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURrd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURRS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ09UZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURFeENpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElERXdOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ01USUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNVFFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElERXpDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGNuUWdkR0Z5WjJWMElHbHpJRzFoZEdOb0lHWnZjaUJqYjI1a2FYUnBiMjV6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjVoZEdsMlpTMWhjbkpoZVhNdVlXeG5ieTUwY3pveE1EQUtJQ0FnSUM4dklHTnZibk4wSUdGeWNqY2dQU0JoY25JdVkyOXVZMkYwS0hKQmNuSXhLUW9nSUNBZ2NIVnphR2x1ZENBMUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNQW9nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dVlYUnBkbVV0WVhKeVlYbHpMbUZzWjI4dWRITTZPVFFLSUNBZ0lDOHZJR052Ym5OMElHRnljalVnUFNCbVFYSnlNUzVqYjI1allYUW9ja0Z5Y2pFcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNakF3TURBd01EQXdNREF3TURBd01ETXdNREF3TURBd01EQXdNREF3TURBME1EQXdNREF3TURBd01EQXdNREF3TlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GMGFYWmxMV0Z5Y21GNWN5NWhiR2R2TG5Sek9qRXdNUW9nSUNBZ0x5OGdZWE56WlhKMEtHRnljamN1YkdWdVozUm9JRDA5UFNBeE5pa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUQwOUNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGRHbDJaUzFoY25KaGVYTXVZV3huYnk1MGN6b3hNRElLSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0dGeWNqY3NJRnN4TENBeE1Dd2dNeXdnTkN3Z01Td2dNVEFzSURNc0lEUXNJREV4TENBeE1pd2dNVE1zSURFc0lESXNJRE1zSURRc0lEVmRLUW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTVRnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTWpZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6RWdMeThnTkFvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBek5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEUXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh5SUM4dklERXdDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRFV3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRFU0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eElDOHZJRFFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTmpZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJREV4Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURjMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBNE1nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTVRNS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ09UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQTVPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXhNRFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdNVEUwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eElDOHZJRFFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F4TWpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVnlkQ0IwWVhKblpYUWdhWE1nYldGMFkyZ2dabTl5SUdOdmJtUnBkR2x2Ym5NS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl1WVhScGRtVXRZWEp5WVhsekxtRnNaMjh1ZEhNNk1UQTBDaUFnSUNBdkx5QmpiMjV6ZENCaGNuSTRJRDBnWVhKeUxtTnZibU5oZENobVFYSnlNU2tLSUNBZ0lHbHVkR05mTVNBdkx5QTBDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dVlYUnBkbVV0WVhKeVlYbHpMbUZzWjI4dWRITTZNVEExQ2lBZ0lDQXZMeUJoYzNObGNuUW9ZWEp5T0M1c1pXNW5kR2dnUFQwOUlERTFLUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXhOUW9nSUNBZ1BUMEtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJtRjBhWFpsTFdGeWNtRjVjeTVoYkdkdkxuUnpPakV3TmdvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb1lYSnlPQ3dnV3pFc0lERXdMQ0F6TENBMExDQXhMQ0F4TUN3Z015d2dOQ3dnTVRFc0lERXlMQ0F4TXl3Z01Dd2dNQ3dnTUN3Z01GMHBDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QXhNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTWlBdkx5QXhNQW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F4T0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F5TmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1TQXZMeUEwQ2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURNMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ05ESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYeklnTHk4Z01UQUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdOVEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdOVGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdOQW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0EyTmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSEIxYzJocGJuUWdNVEVLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTnpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJREV5Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURneUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnY0hWemFHbHVkQ0F4TXdvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBNU1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQTVPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F4TURZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBeE1UUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWeWRDQjBZWEpuWlhRZ2FYTWdiV0YwWTJnZ1ptOXlJR052Ym1ScGRHbHZibk1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZWFJwZG1VdFlYSnlZWGx6TG1Gc1oyOHVkSE02TkRJS0lDQWdJQzh2SUdSdlZHaHBibWR6S0NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl1WVhScGRtVXRZWEp5WVhsekxtRnNaMjh1ZEhNNk9rNWhkR2wyWlVGeWNtRjVjMEZzWjI4dVptbDRaV1JCY25KaGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbVpwZUdWa1FYSnlZWGs2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZibUYwYVhabExXRnljbUY1Y3k1aGJHZHZMblJ6T2pFd09Rb2dJQ0FnTHk4Z1ptbDRaV1JCY25KaGVTaDVPaUJHYVhobFpFRnljbUY1UEhWcGJuUTJOQ3dnTlRBK0tTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EwTURBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQSFZwYm5RMk5Dd2dOVEErQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZibUYwYVhabExXRnljbUY1Y3k1aGJHZHZMblJ6T2pFeE9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hoYk1GMGdQVDA5SUhsYk1GMHBDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGRHbDJaUzFoY25KaGVYTXVZV3huYnk1MGN6b3hNRGtLSUNBZ0lDOHZJR1pwZUdWa1FYSnlZWGtvZVRvZ1JtbDRaV1JCY25KaGVUeDFhVzUwTmpRc0lEVXdQaWtnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZWFJwZG1VdFlYSnlZWGx6TG1Gc1oyOHVkSE02T2s1aGRHbDJaVUZ5Y21GNWMwRnNaMjh1YzNSeWRXTjBjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25OMGNuVmpkSE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZibUYwYVhabExXRnljbUY1Y3k1aGJHZHZMblJ6T2pFM01Bb2dJQ0FnTHk4Z2MzUnlkV04wY3loN0lIZ3NJSGtnZlRvZ1ZtVmpkRzl5S1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXhOZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGRHbDJaUzFoY25KaGVYTXVZV3huYnk1MGN6bzZWbVZqZEc5eUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyNWhkR2wyWlMxaGNuSmhlWE11WVd4bmJ5NTBjem94TnpNS0lDQWdJQzh2SUcxNVZtVmpkRzl5Y3lBOUlGdDdJSGdzSUhrZ2ZWMEtJQ0FnSUdScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dVlYUnBkbVV0WVhKeVlYbHpMbUZzWjI4dWRITTZNVGMxQ2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNodGVWWmxZM1J2Y25Nc0lGdDdJSGdzSUhrZ2ZWMHBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01UWUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lEMDlDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGNuUWdkR0Z5WjJWMElHbHpJRzFoZEdOb0lHWnZjaUJqYjI1a2FYUnBiMjV6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZibUYwYVhabExXRnljbUY1Y3k1aGJHZHZMblJ6T2pFM01Bb2dJQ0FnTHk4Z2MzUnlkV04wY3loN0lIZ3NJSGtnZlRvZ1ZtVmpkRzl5S1NCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZibUYwYVhabExXRnljbUY1Y3k1aGJHZHZMblJ6T2pwT1lYUnBkbVZCY25KaGVYTkJiR2R2TG1Gc2FXRnphVzVuVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lXeHBZWE5wYm1jNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GMGFYWmxMV0Z5Y21GNWN5NWhiR2R2TG5Sek9qRTVOUW9nSUNBZ0x5OGdZV3hwWVhOcGJtY29iWFYwWVdKc1pUb2dkV2x1ZERZMFcxMHNJSEpsWVdSUGJteDVPaUJ5WldGa2IyNXNlU0IxYVc1ME5qUmJYU2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeDFhVzUwTmpRK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhkV2x1ZERZMFBnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGRHbDJaUzFoY25KaGVYTXVZV3huYnk1MGN6b3lNRFlLSUNBZ0lDOHZJRzExZEdGaWJHVmJNVjBnS3owZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTVRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQXhNQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdsdWRHTmZNaUF2THlBeE1Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGRHbDJaUzFoY25KaGVYTXVZV3huYnk1MGN6b3lNRGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaHRkWFJoWW14bFd6RmRJQ0U5UFNCdVpXVmtRMnh2Ym1VeVd6RmRMQ0FuVkdobGMyVWdjMmh2ZFd4a0lHNXZkQ0J0WVhSamFDY3BDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCVWFHVnpaU0J6YUc5MWJHUWdibTkwSUcxaGRHTm9DaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJtRjBhWFpsTFdGeWNtRjVjeTVoYkdkdkxuUnpPakU1TlFvZ0lDQWdMeThnWVd4cFlYTnBibWNvYlhWMFlXSnNaVG9nZFdsdWREWTBXMTBzSUhKbFlXUlBibXg1T2lCeVpXRmtiMjVzZVNCMWFXNTBOalJiWFNrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl1WVhScGRtVXRZWEp5WVhsekxtRnNaMjh1ZEhNNk9rNWhkR2wyWlVGeWNtRjVjMEZzWjI4dWNtVmpaV2wyWlUxMWRHRmliR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXTmxhWFpsVFhWMFlXSnNaVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZWFJwZG1VdFlYSnlZWGx6TG1Gc1oyOHVkSE02TWpJeENpQWdJQ0F2THlCeVpXTmxhWFpsVFhWMFlXSnNaU2hoT2lCMWFXNTBOalJiWFNrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQSFZwYm5RMk5ENEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GMGFYWmxMV0Z5Y21GNWN5NWhiR2R2TG5Sek9qcE9ZWFJwZG1WQmNuSmhlWE5CYkdkdkxuSmxZMlZwZG1WU1pXRmtiMjVzZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxZMlZwZG1WU1pXRmtiMjVzZVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl1WVhScGRtVXRZWEp5WVhsekxtRnNaMjh1ZEhNNk1qSTFDaUFnSUNBdkx5QnlaV05sYVhabFVtVmhaRzl1Ykhrb1lUb2djbVZoWkc5dWJIa2dkV2x1ZERZMFcxMHBJSHQ5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOGRXbHVkRFkwUGdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUVFLQUNZRkJSVWZmSFdnQnhVZmZIVUFBNkFtRlI5OGRRQUVBQUFBQUFBQUFBRUFBQUFBQUFBQUFnQUFBQUFBQUFBREFBQUFBQUFBQUFRREJvRUJLZ0FGQUFBQUFBQUFBQUVBQUFBQUFBQUFBZ0FBQUFBQUFBQURBQUFBQUFBQUFBUUFBQUFBQUFBQUJURWJRUURBTVJrVVJERVlSSUlRQkgweGhZa0VzS3lRWmdRUFRCSEtCS3FpbjNBRTR0WGdOUVFUcFlqSUJOYnN3ZVlFZUh0UXNnVHJoNkJrQkx4aDFyZ0VqMVJFY3dSRDUrNUZCTXZqcFBnRUZEOGlPd1RaaVZSQ0JPSVQ5YlkyR2dDT0VBQkFBRDRBT2dBWEFCTUFaUVQvQUJFRkR3QU5BQWtBQlFBQkJWRUZoUVdYQUNpd0lrTXBzQ0pES0xBaVF5bXdJa01pUXlxd0lrT0FIaFVmZkhVQUF3QUFBQUFBQUFBQkFBQUFBQUFBQUFJQUFBQUFBQUFBQTdBaVF5cXdJa01pUXlKRE1Sa1VNUmdVRUVPS0FnR0wvaFdML3dtTC9pVlBBbEpKSlZraUNSWlhCZ0JjQUltQmdnc3lEQTFCQUJheGdRYXlFSUVGc2hrcnNoNHJzaDhsc2dHelF2L2hnUVVXSndTQkNJai92RWtsV1VrakVrc0NWd0lBU3dPQkFsc2lFazhDU3dFUVN3UWtXNEVDRWhCTEJJRVNXNEVERWhCTEJJRWFXeU1TRUVSRVN3RWlDWUVJQzFzakVrUWlDQlpYQmdCY0FFc0JVRWtsV1VtQkJSSkxBbGNDQUVzRGdRSmJJaEpQQWhCTEF5UmJnUUlTRUVzRGdSSmJnUU1TRUVzRGdScGJJeElRU3dPQklsdUJCUklRUkV3aUNZRUlDMXRNZ1FpSS95NU1nUVVTUkVrbFdTTVNTd0dCQWxzaUVoQkxBU1JiZ1FJU0VFc0JnUkpiZ1FNU0VFc0JnUnBiSXhJUVJDUVdYQXBKVHdKY0Nrc0JKVmxKSXhKTEExY0NBRXNFZ1FKYkloSlBBaEJMQkNSYkpCSVFTd1NCRWx1QkF4SVFTd1NCR2xzakVoQkVTd0lsV1NNU1N3T0JBbHNpRWhCTEF5UmJnUVVTRUVzRGdSSmJnUU1TRUU4RGdScGJJeElRUkVzQlR3SUlGbGNHQUU4Q1RGd0FURkNCQ3haTEFTVlpJZ2dXVndZQVR3Sk1YQUJNVUVrbFdZRUNDQlpYQmdCY0FJQVFBQUFBQUFBQUFBd0FBQUFBQUFBQURWQkpKVmxKZ1FzU1N3SlhBZ0JMQTRFQ1d5SVNUd0lRU3dNa1d5UVNFRXNEZ1JKYmdRTVNFRXNEZ1JwYkl4SVFTd09CSWxzaUVoQkxBNEVxV3lRU0VFc0RnVEpiZ1FNU0VFc0RnVHBiSXhJUVN3T0JRbHVCQ3hJUVN3T0JTbHVCREJJUVN3T0JVbHVCRFJJUVJJRWdyNEVGU3dNSUZsY0dBQ2NFVEZ3QVN3SlFTU1ZaZ1JBU1N3R0JBbHNpRWhCTEFTUmJnUUlTRUVzQmdSSmJnUU1TRUVzQmdScGJJeElRU3dHQklsdUJCUklRU3dHQktsc2lFaEJMQVlFeVd5UVNFRXNCZ1RwYmdRTVNFRXNCZ1VKYkl4SVFTd0dCU2xzaUVoQkxBWUZTV3lRU0VFc0JnVnBiZ1FNU0VFc0JnV0piSXhJUVN3R0JhbHVCQ3hJUVN3R0JjbHVCREJJUVRJRjZXNEVORWhCRUkwc0RDQlpYQmdDQUlnQUVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCTVhBQlBBbEJKSlZtQkR4SkxBWUVDV3hRUVN3RWtXeFFRU3dHQkVsc1VFRXNCZ1JwYkZCQkxBWUVpV3lJU0VFc0JnU3BiSkJJUVN3R0JNbHVCQXhJUVN3R0JPbHNqRWhCTEFZRkNXeUlTRUVzQmdVcGJKQklRU3dHQlVsdUJBeElRU3dHQldsc2pFaEJMQVlGaVc0RUxFaEJMQVlGcVc0RU1FaEJNZ1hKYmdRMFNFRVJMQVlFRkNCWlhCZ0JMQTB4Y0FJQW9BQUFBQUFBQUFBRUFBQUFBQUFBQUFnQUFBQUFBQUFBREFBQUFBQUFBQUFRQUFBQUFBQUFBQlZCSkpWbUJFQkpKUkVzQmdRSmJJaElRU3dFa1d5UVNFRXNCZ1JKYmdRTVNFRXNCZ1JwYkl4SVFTd0dCSWxzaUVoQkxBWUVxV3lRU0VFc0JnVEpiZ1FNU0VFc0JnVHBiSXhJUVN3R0JRbHVCQ3hJUVN3R0JTbHVCREJJUVN3R0JVbHVCRFJJUVN3R0JXbHNpRWhCTEFZRmlXNEVDRWhCTEFZRnFXNEVERWhCTEFZRnlXeU1TRUV5QmVsdUJCUklRUkV3akNCWlhCZ0JQQWt4Y0FFeFFTU1ZaZ1E4U1NVUkxBWUVDV3lJU0VFc0JKRnNrRWhCTEFZRVNXNEVERWhCTEFZRWFXeU1TRUVzQmdTSmJJaElRU3dHQktsc2tFaEJMQVlFeVc0RURFaEJMQVlFNld5TVNFRXNCZ1VKYmdRc1NFRXNCZ1VwYmdRd1NFRXNCZ1ZKYmdRMFNFRXNCZ1ZwYkZCQkxBWUZpV3hRUVN3R0JhbHNVRUV5QmNsc1VFRVFpUXpZYUFVa1ZnWkFERWtRbFd4UkVJa00yR2dGSkZZRVFFa1JKSlZ0TWdRaGJTd0VXU3dFV1VJQUNBQUZNVUVrbFdTSVNTd0ZYQWhCSkpWdFBCUkpNZ1FoYlR3UVNFQkJFZ0FRVkgzeDFURkN3SWtNMkdnRkpKVm1CQ0F1QkFnaExBUlVTUkRZYUFra2xXWUVJQzRFQ0NFd1ZFa1JKSkZ0SmdRSUlGazhDVEZ3S0pGc1RSQ0pETmhvQlNTVlpnUWdMZ1FJSVRCVVNSQ0pETmhvQlNTVlpnUWdMZ1FJSVRCVVNSQ0pEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
