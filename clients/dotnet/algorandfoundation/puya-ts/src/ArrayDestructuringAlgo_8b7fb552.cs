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

namespace Arc56.Generated.algorandfoundation.puya_ts.ArrayDestructuringAlgo_8b7fb552
{


    public class ArrayDestructuringAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ArrayDestructuringAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class TestNestedArgArg : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public Structs.TestNestedArgArgField1 Field1 { get; set; } = new Structs.TestNestedArgArgField1();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    ret.AddRange(Field1.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TestNestedArgArg Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TestNestedArgArg();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    ret.Field1 = Structs.TestNestedArgArgField1.Parse(queue.ToArray());
                    { var consumedField1 = ret.Field1.ToByteArray().Length; for (int i = 0; i < consumedField1 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TestNestedArgArg);
                }
                public bool Equals(TestNestedArgArg? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TestNestedArgArg left, TestNestedArgArg right)
                {
                    return EqualityComparer<TestNestedArgArg>.Default.Equals(left, right);
                }
                public static bool operator !=(TestNestedArgArg left, TestNestedArgArg right)
                {
                    return !(left == right);
                }

            }

            public class TestNestedArgArgField1 : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field1 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TestNestedArgArgField1 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TestNestedArgArgField1();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TestNestedArgArgField1);
                }
                public bool Equals(TestNestedArgArgField1? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TestNestedArgArgField1 left, TestNestedArgArgField1 right)
                {
                    return EqualityComparer<TestNestedArgArgField1>.Default.Equals(left, right);
                }
                public static bool operator !=(TestNestedArgArgField1 left, TestNestedArgArgField1 right)
                {
                    return !(left == right);
                }

            }

            public class TestNestedReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public Structs.TestNestedArgArgField1 Field1 { get; set; } = new Structs.TestNestedArgArgField1();

                public ulong Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    ret.AddRange(Field1.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
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

                public static TestNestedReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TestNestedReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    ret.Field1 = Structs.TestNestedArgArgField1.Parse(queue.ToArray());
                    { var consumedField1 = ret.Field1.ToByteArray().Length; for (int i = 0; i < consumedField1 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    var vField3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field3 = vField3;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TestNestedReturn);
                }
                public bool Equals(TestNestedReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TestNestedReturn left, TestNestedReturn right)
                {
                    return EqualityComparer<TestNestedReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(TestNestedReturn left, TestNestedReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> TestNestedArgArg</param>
        public async Task<Structs.TestNestedReturn> TestNested(Structs.TestNestedArgArg arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 183, 232, 223 };

            var result = await base.CallApp(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TestNestedReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TestNested_Transactions(Structs.TestNestedArgArg arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 183, 232, 223 };

            return await base.MakeTransactionList(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Test(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 128, 0, 222 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 128, 0, 222 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestLiteralDestructuring(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 175, 198, 198 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestLiteralDestructuring_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 175, 198, 198 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong[]> ProduceFixed(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 139, 105, 131 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(3, "uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> ProduceFixed_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 139, 105, 131 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJyYXlEZXN0cnVjdHVyaW5nQWxnbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJUZXN0TmVzdGVkQXJnQXJnIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJUZXN0TmVzdGVkQXJnQXJnRmllbGQxIn1dLCJUZXN0TmVzdGVkQXJnQXJnRmllbGQxIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDUxMiJ9XSwiVGVzdE5lc3RlZFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiVGVzdE5lc3RlZEFyZ0FyZ0ZpZWxkMSJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDUxMiJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0TmVzdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsKHVpbnQ1MTIsdWludDUxMikpIiwic3RydWN0IjoiVGVzdE5lc3RlZEFyZ0FyZyIsIm5hbWUiOiJhcmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCwodWludDUxMix1aW50NTEyKSx1aW50NjQsdWludDUxMikiLCJzdHJ1Y3QiOiJUZXN0TmVzdGVkUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0TGl0ZXJhbERlc3RydWN0dXJpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJvZHVjZUZpeGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFszXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0MjRdLCJlcnJvck1lc3NhZ2UiOiJhc3NlcnQgdGFyZ2V0IGlzIG1hdGNoIGZvciBjb25kaXRpb25zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudHVwbGU8YXJjNC51aW50NjQsYXJjNC50dXBsZTxhcmM0LnVpbnQ1MTIsYXJjNC51aW50NTEyPj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDksMjIyLDIzOV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0EyTkNBeElEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ2dNSGd3TmlBd2VERTFNV1kzWXpjMUNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURFS0NtMWhhVzVmWW14dlkydEFNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbkpoZVMxa1pYTjBjblZqZEhWeWFXNW5MbUZzWjI4dWRITTZOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeWNtRjVSR1Z6ZEhKMVkzUjFjbWx1WjBGc1oyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhNUW9nSUNBZ1lpQnRZV2x1WDJGaWFWOXliM1YwYVc1blFESUtDbTFoYVc1ZllXSnBYM0p2ZFhScGJtZEFNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbkpoZVMxa1pYTjBjblZqZEhWeWFXNW5MbUZzWjI4dWRITTZOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGeWNtRjVSR1Z6ZEhKMVkzUjFjbWx1WjBGc1oyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdUbTlQY0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0FoUFFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUE1Q2lBZ0lDQmlJRzFoYVc1ZlkyRnNiRjlPYjA5d1FETUtDbTFoYVc1ZlkyRnNiRjlPYjA5d1FETTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSnlZWGt0WkdWemRISjFZM1IxY21sdVp5NWhiR2R2TG5Sek9qUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY25KaGVVUmxjM1J5ZFdOMGRYSnBibWRCYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE56UmlOMlU0WkdZZ0x5OGdiV1YwYUc5a0lDSjBaWE4wVG1WemRHVmtLQ2gxYVc1ME5qUXNLSFZwYm5RMU1USXNkV2x1ZERVeE1pa3BLU2gxYVc1ME5qUXNLSFZwYm5RMU1USXNkV2x1ZERVeE1pa3NkV2x1ZERZMExIVnBiblExTVRJcElnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlUYzRNREF3WkdVZ0x5OGdiV1YwYUc5a0lDSjBaWE4wS0NsMmIybGtJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNbVJoWm1NMll6WWdMeThnYldWMGFHOWtJQ0owWlhOMFRHbDBaWEpoYkVSbGMzUnlkV04wZFhKcGJtY29LWFp2YVdRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa05EaGlOams0TXlBdkx5QnRaWFJvYjJRZ0luQnliMlIxWTJWR2FYaGxaQ2dwZFdsdWREWTBXek5kSWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCdFlYUmphQ0J0WVdsdVgzUmxjM1JPWlhOMFpXUmZjbTkxZEdWQU5DQnRZV2x1WDNSbGMzUmZjbTkxZEdWQU5TQnRZV2x1WDNSbGMzUk1hWFJsY21Gc1JHVnpkSEoxWTNSMWNtbHVaMTl5YjNWMFpVQTJJRzFoYVc1ZmNISnZaSFZqWlVacGVHVmtYM0p2ZFhSbFFEY0tJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRGdLQ20xaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTRPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Eb0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXlDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKeVlYa3RaR1Z6ZEhKMVkzUjFjbWx1Wnk1aGJHZHZMblJ6T2pRS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJjbkpoZVVSbGMzUnlkV04wZFhKcGJtZEJiR2R2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdaWEp5Q2dwdFlXbHVYM0J5YjJSMVkyVkdhWGhsWkY5eWIzVjBaVUEzT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5Y21GNUxXUmxjM1J5ZFdOMGRYSnBibWN1WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnY0hKdlpIVmpaVVpwZUdWa0tDazZJRVpwZUdWa1FYSnlZWGs4ZFdsdWREWTBMQ0F6UGlCN0NpQWdJQ0JqWVd4c2MzVmlJSEJ5YjJSMVkyVkdhWGhsWkFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU9Bb0tiV0ZwYmw5MFpYTjBUR2wwWlhKaGJFUmxjM1J5ZFdOMGRYSnBibWRmY205MWRHVkFOam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbkpoZVMxa1pYTjBjblZqZEhWeWFXNW5MbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJSFJsYzNSTWFYUmxjbUZzUkdWemRISjFZM1IxY21sdVp5Z3BJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkRXhwZEdWeVlXeEVaWE4wY25WamRIVnlhVzVuQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBNENncHRZV2x1WDNSbGMzUmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNuSmhlUzFrWlhOMGNuVmpkSFZ5YVc1bkxtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklIUmxjM1FvS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNRS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEZ0tDbTFoYVc1ZmRHVnpkRTVsYzNSbFpGOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeWNtRjVMV1JsYzNSeWRXTjBkWEpwYm1jdVlXeG5ieTUwY3pvMUNpQWdJQ0F2THlCMFpYTjBUbVZ6ZEdWa0tHRnlaem9nY21WaFpHOXViSGtnVzNWcGJuUTJOQ3dnY21WaFpHOXViSGtnVzJKcFozVnBiblFzSUdKcFozVnBiblJkWFNrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMFRtVnpkR1ZrQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBNENncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEazZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNQW9LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1URTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSnlZWGt0WkdWemRISjFZM1IxY21sdVp5NWhiR2R2TG5Sek9qUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCY25KaGVVUmxjM1J5ZFdOMGRYSnBibWRCYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklFNXZUM0FLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCallXeHNjM1ZpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNuSmhlUzFrWlhOMGNuVmpkSFZ5YVc1bkxtRnNaMjh1ZEhNNk9rRnljbUY1UkdWemRISjFZM1IxY21sdVowRnNaMjh1ZEdWemRFNWxjM1JsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JPWlhOMFpXUTZDaUFnSUNCaUlIUmxjM1JPWlhOMFpXUmZZbXh2WTJ0QU1Bb0tkR1Z6ZEU1bGMzUmxaRjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnljbUY1TFdSbGMzUnlkV04wZFhKcGJtY3VZV3huYnk1MGN6bzFDaUFnSUNBdkx5QjBaWE4wVG1WemRHVmtLR0Z5WnpvZ2NtVmhaRzl1YkhrZ1czVnBiblEyTkN3Z2NtVmhaRzl1YkhrZ1cySnBaM1ZwYm5Rc0lHSnBaM1ZwYm5SZFhTa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRNMkNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuUjFjR3hsUEdGeVl6UXVkV2x1ZERZMExHRnlZelF1ZEhWd2JHVThZWEpqTkM1MWFXNTBOVEV5TEdGeVl6UXVkV2x1ZERVeE1qNCtDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUdOdmRtVnlJREVLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCd2RYTm9hVzUwSURFeU9Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsdWRHTmZNU0F2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR2x1ZEdOZk1TQXZMeUEyTkFvZ0lDQWdhVzUwWTE4eElDOHZJRFkwQ2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiM1psY2lBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdllYSnlZWGt0WkdWemRISjFZM1IxY21sdVp5NWhiR2R2TG5Sek9qcEJjbkpoZVVSbGMzUnlkV04wZFhKcGJtZEJiR2R2TG5SbGMzUk9aWE4wWldRS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURZMENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z05qUUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUEyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHhJQzh2SURZMENpQWdJQ0JpZW1WeWJ3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlmQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdOalFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUEyTkFvZ0lDQWdZbnBsY204S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lud0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5Y21GNUxXUmxjM1J5ZFdOMGRYSnBibWN1WVd4bmJ5NTBjem82UVhKeVlYbEVaWE4wY25WamRIVnlhVzVuUVd4bmJ5NTBaWE4wVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRG9LSUNBZ0lHSWdkR1Z6ZEY5aWJHOWphMEF3Q2dwMFpYTjBYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSnlZWGt0WkdWemRISjFZM1IxY21sdVp5NWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5QjBaWE4wS0NrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEp5WVhrdFpHVnpkSEoxWTNSMWNtbHVaeTVoYkdkdkxuUnpPanBCY25KaGVVUmxjM1J5ZFdOMGRYSnBibWRCYkdkdkxuUmxjM1FLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSnlZWGt0WkdWemRISjFZM1IxY21sdVp5NWhiR2R2TG5Sek9qcEJjbkpoZVVSbGMzUnlkV04wZFhKcGJtZEJiR2R2TG5SbGMzUk1hWFJsY21Gc1JHVnpkSEoxWTNSMWNtbHVaMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUk1hWFJsY21Gc1JHVnpkSEoxWTNSMWNtbHVaem9LSUNBZ0lHSWdkR1Z6ZEV4cGRHVnlZV3hFWlhOMGNuVmpkSFZ5YVc1blgySnNiMk5yUURBS0NuUmxjM1JNYVhSbGNtRnNSR1Z6ZEhKMVkzUjFjbWx1WjE5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5Y21GNUxXUmxjM1J5ZFdOMGRYSnBibWN1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnZEdWemRFeHBkR1Z5WVd4RVpYTjBjblZqZEhWeWFXNW5LQ2tnZXdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdllYSnlZWGt0WkdWemRISjFZM1IxY21sdVp5NWhiR2R2TG5Sek9qcEJjbkpoZVVSbGMzUnlkV04wZFhKcGJtZEJiR2R2TG5SbGMzUk1hWFJsY21Gc1JHVnpkSEoxWTNSMWNtbHVad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNuSmhlUzFrWlhOMGNuVmpkSFZ5YVc1bkxtRnNaMjh1ZEhNNk9rRnljbUY1UkdWemRISjFZM1IxY21sdVowRnNaMjh1Y0hKdlpIVmpaVVpwZUdWa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjSEp2WkhWalpVWnBlR1ZrT2dvZ0lDQWdZaUJ3Y205a2RXTmxSbWw0WldSZllteHZZMnRBTUFvS2NISnZaSFZqWlVacGVHVmtYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSnlZWGt0WkdWemRISjFZM1IxY21sdVp5NWhiR2R2TG5Sek9qUTBDaUFnSUNBdkx5QndjbTlrZFdObFJtbDRaV1FvS1RvZ1JtbDRaV1JCY25KaGVUeDFhVzUwTmpRc0lETStJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeWNtRjVMV1JsYzNSeWRXTjBkWEpwYm1jdVlXeG5ieTUwY3pvNlFYSnlZWGxFWlhOMGNuVmpkSFZ5YVc1blFXeG5ieTV3Y205a2RXTmxSbWw0WldRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNuSmhlUzFrWlhOMGNuVmpkSFZ5YVc1bkxtRnNaMjh1ZEhNNk9rRnljbUY1UkdWemRISjFZM1IxY21sdVowRnNaMjh1ZEdWemRFNWxjM1JsWkNoaGNtY3VNRG9nZFdsdWREWTBMQ0JoY21jdU1TNHdPaUJpZVhSbGN5d2dZWEpuTGpFdU1Ub2dZbmwwWlhNcElDMCtJSFZwYm5RMk5Dd2dZbmwwWlhNc0lHSjVkR1Z6TENCMWFXNTBOalFzSUdKNWRHVnpPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEp5WVhrdFpHVnpkSEoxWTNSMWNtbHVaeTVoYkdkdkxuUnpPanBCY25KaGVVUmxjM1J5ZFdOMGRYSnBibWRCYkdkdkxuUmxjM1JPWlhOMFpXUTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSnlZWGt0WkdWemRISjFZM1IxY21sdVp5NWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklIUmxjM1JPWlhOMFpXUW9ZWEpuT2lCeVpXRmtiMjVzZVNCYmRXbHVkRFkwTENCeVpXRmtiMjVzZVNCYlltbG5kV2x1ZEN3Z1ltbG5kV2x1ZEYxZEtTQjdDaUFnSUNCd2NtOTBieUF6SURVS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5Y21GNUxXUmxjM1J5ZFdOMGRYSnBibWN1WVd4bmJ5NTBjem82UVhKeVlYbEVaWE4wY25WamRIVnlhVzVuUVd4bmJ5NTBaWE4wVG1WemRHVmtYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbkpoZVMxa1pYTjBjblZqZEhWeWFXNW5MbUZzWjI4dWRITTZPa0Z5Y21GNVJHVnpkSEoxWTNSMWNtbHVaMEZzWjI4dWRHVnpkRTVsYzNSbFpGOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeWNtRjVMV1JsYzNSeWRXTjBkWEpwYm1jdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCamIyNXpkQ0JiWVN3Z1lsMGdQU0JoY21jS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbkpoZVMxa1pYTjBjblZqZEhWeWFXNW5MbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdZMjl1YzNRZ1cyTXNJRnRrWFYwZ1BTQmhjbWNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSnlZWGt0WkdWemRISjFZM1IxY21sdVp5NWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklISmxkSFZ5YmlCYllTd2dZaXdnWXl3Z1pGMGdZWE1nWTI5dWMzUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKeVlYa3RaR1Z6ZEhKMVkzUjFjbWx1Wnk1aGJHZHZMblJ6T2pwQmNuSmhlVVJsYzNSeWRXTjBkWEpwYm1kQmJHZHZMblJsYzNRb0tTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdllYSnlZWGt0WkdWemRISjFZM1IxY21sdVp5NWhiR2R2TG5Sek9qcEJjbkpoZVVSbGMzUnlkV04wZFhKcGJtZEJiR2R2TG5SbGMzUTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSnlZWGt0WkdWemRISjFZM1IxY21sdVp5NWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5QjBaWE4wS0NrZ2V3b2dJQ0FnY0hKdmRHOGdNQ0F3Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbkpoZVMxa1pYTjBjblZqZEhWeWFXNW5MbUZzWjI4dWRITTZPa0Z5Y21GNVJHVnpkSEoxWTNSMWNtbHVaMEZzWjI4dWRHVnpkRjlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEp5WVhrdFpHVnpkSEoxWTNSMWNtbHVaeTVoYkdkdkxuUnpPanBCY25KaGVVUmxjM1J5ZFdOMGRYSnBibWRCYkdkdkxuUmxjM1JmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbkpoZVMxa1pYTjBjblZqZEhWeWFXNW5MbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJR052Ym5OMElGdGhMQ0JpTENCakxDQmtYU0E5SUhSb2FYTXVjSEp2WkhWalpVbDBaVzF6S0NrS0lDQWdJR05oYkd4emRXSWdjSEp2WkhWalpVbDBaVzF6Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JqYjNabGNpQXpDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKeVlYa3RaR1Z6ZEhKMVkzUjFjbWx1Wnk1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCamIyNXpkQ0JiTENBc0lHVmRJRDBnZEdocGN5NXdjbTlrZFdObFNYUmxiWE1vS1FvZ0lDQWdZMkZzYkhOMVlpQndjbTlrZFdObFNYUmxiWE1LSUNBZ0lHTnZkbVZ5SURjS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmRtVnlJRFlLSUNBZ0lHTnZkbVZ5SURVS0lDQWdJR052ZG1WeUlETUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNuSmhlUzFrWlhOMGNuVmpkSFZ5YVc1bkxtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHTnZibk4wSUdZZ1BTQW9XMmNzSUN3Z0xDQnBYU0E5SUhSb2FYTXVjSEp2WkhWalpVbDBaVzF6S0NrcENpQWdJQ0JqWVd4c2MzVmlJSEJ5YjJSMVkyVkpkR1Z0Y3dvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBM0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5MlpYSWdNVEFLSUNBZ0lHTnZkbVZ5SURFd0NpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZkbVZ5SURFd0NpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZkbVZ5SURFd0NpQWdJQ0JqYjNabGNpQXhNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnljbUY1TFdSbGMzUnlkV04wZFhKcGJtY3VZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdZWE56WlhKMEtHRWdQVDA5SURVcENpQWdJQ0J3ZFhOb2FXNTBJRFVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbkpoZVMxa1pYTjBjblZqZEhWeWFXNW5MbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaGlJRDA5UFNCQ2VYUmxjeWdwS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5Y21GNUxXUmxjM1J5ZFdOMGRYSnBibWN1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnWVhOelpYSjBLQ0ZqS1FvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEp5WVhrdFpHVnpkSEoxWTNSMWNtbHVaeTVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJoYzNObGNuUW9aQ0E5UFQwZ05tNHBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd05nb2dJQ0FnWWowOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNuSmhlUzFrWlhOMGNuVmpkSFZ5YVc1bkxtRnNaMjh1ZEhNNk1qSUtJQ0FnSUM4dklHRnpjMlZ5ZENnaFpTa0tJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEp5WVhrdFpHVnpkSEoxWTNSMWNtbHVaeTVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUJoYzNObGNuUW9aeUE5UFQwZ05Ta0tJQ0FnSUhCMWMyaHBiblFnTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5Y21GNUxXUmxjM1J5ZFdOMGRYSnBibWN1WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnWVhOelpYSjBLR2tnUFQwOUlEWnVLUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREEyQ2lBZ0lDQmlQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5Y21GNUxXUmxjM1J5ZFdOMGRYSnBibWN1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb1ppd2dXelVzSUVKNWRHVnpLQ2tzSUdaaGJITmxMQ0EyYmwwcENpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnUFQwS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2NIVnphR2x1ZENBMUNpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQTJDaUFnSUNCaVBUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYSjBJSFJoY21kbGRDQnBjeUJ0WVhSamFDQm1iM0lnWTI5dVpHbDBhVzl1Y3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5Y21GNUxXUmxjM1J5ZFdOMGRYSnBibWN1WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnWTI5dWMzUWdXM2dzSUhrc0lIcGRJRDBnZEdocGN5NXdjbTlrZFdObFJtbDRaV1FvS1FvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdllYSnlZWGt0WkdWemRISjFZM1IxY21sdVp5NWhiR2R2TG5Sek9qcEJjbkpoZVVSbGMzUnlkV04wZFhKcGJtZEJiR2R2TG5CeWIyUjFZMlZHYVhobFpBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeWNtRjVMV1JsYzNSeWRXTjBkWEpwYm1jdVlXeG5ieTUwY3pvNlFYSnlZWGxFWlhOMGNuVmpkSFZ5YVc1blFXeG5ieTV3Y205a2RXTmxTWFJsYlhNb0tTQXRQaUIxYVc1ME5qUXNJR0o1ZEdWekxDQjFhVzUwTmpRc0lHSjVkR1Z6T2dwd2NtOWtkV05sU1hSbGJYTTZDaUFnSUNCaUlIQnliMlIxWTJWSmRHVnRjMTlpYkc5amEwQXdDZ3B3Y205a2RXTmxTWFJsYlhOZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY25KaGVTMWtaWE4wY25WamRIVnlhVzVuTG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUhKbGRIVnliaUJiTlN3Z1FubDBaWE1vS1N3Z1ptRnNjMlVzSURadVhRb2dJQ0FnY0hWemFHbHVkQ0ExQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREEyQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEp5WVhrdFpHVnpkSEoxWTNSMWNtbHVaeTVoYkdkdkxuUnpPanBCY25KaGVVUmxjM1J5ZFdOMGRYSnBibWRCYkdkdkxuUmxjM1JNYVhSbGNtRnNSR1Z6ZEhKMVkzUjFjbWx1WnlncElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNuSmhlUzFrWlhOMGNuVmpkSFZ5YVc1bkxtRnNaMjh1ZEhNNk9rRnljbUY1UkdWemRISjFZM1IxY21sdVowRnNaMjh1ZEdWemRFeHBkR1Z5WVd4RVpYTjBjblZqZEhWeWFXNW5PZ29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllYSnlZWGt0WkdWemRISjFZM1IxY21sdVp5NWhiR2R2TG5Sek9qcEJjbkpoZVVSbGMzUnlkV04wZFhKcGJtZEJiR2R2TG5SbGMzUk1hWFJsY21Gc1JHVnpkSEoxWTNSMWNtbHVaMTlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEp5WVhrdFpHVnpkSEoxWTNSMWNtbHVaeTVoYkdkdkxuUnpPanBCY25KaGVVUmxjM1J5ZFdOMGRYSnBibWRCYkdkdkxuUmxjM1JNYVhSbGNtRnNSR1Z6ZEhKMVkzUjFjbWx1WjE5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5Y21GNUxXUmxjM1J5ZFdOMGRYSnBibWN1WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnYkdWMElHRWdQU0JWYVc1ME5qUW9NU2tLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSnlZWGt0WkdWemRISjFZM1IxY21sdVp5NWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QmpiMjV6ZENCYmVDd2dlVjBnUFNBb1cySXNJR0ZkSUQwZ1cyRXNJR0pkS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbkpoZVMxa1pYTjBjblZqZEhWeWFXNW5MbUZzWjI4dWRITTZNellLSUNBZ0lDOHZJR3hsZENCaUlEMGdWV2x1ZERZMEtESXBDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY25KaGVTMWtaWE4wY25WamRIVnlhVzVuTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUdOdmJuTjBJRnQ0TENCNVhTQTlJQ2hiWWl3Z1lWMGdQU0JiWVN3Z1lsMHBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1kyOTJaWElnTVFvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdZMjkyWlhJZ01Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeWNtRjVMV1JsYzNSeWRXTjBkWEpwYm1jdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2JHVjBJR0VnUFNCVmFXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEp5WVhrdFpHVnpkSEoxWTNSMWNtbHVaeTVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUJoYzNObGNuUW9lQ0E5UFQwZ1lpa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNuSmhlUzFrWlhOMGNuVmpkSFZ5YVc1bkxtRnNaMjh1ZEhNNk16WUtJQ0FnSUM4dklHeGxkQ0JpSUQwZ1ZXbHVkRFkwS0RJcENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbkpoZVMxa1pYTjBjblZqZEhWeWFXNW5MbUZzWjI4dWRITTZOREVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDVJRDA5UFNCaEtRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeWNtRjVMV1JsYzNSeWRXTjBkWEpwYm1jdVlXeG5ieTUwY3pvNlFYSnlZWGxFWlhOMGNuVmpkSFZ5YVc1blFXeG5ieTV3Y205a2RXTmxSbWw0WldRb0tTQXRQaUJpZVhSbGN6b0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnljbUY1TFdSbGMzUnlkV04wZFhKcGJtY3VZV3huYnk1MGN6bzZRWEp5WVhsRVpYTjBjblZqZEhWeWFXNW5RV3huYnk1d2NtOWtkV05sUm1sNFpXUTZDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNuSmhlUzFrWlhOMGNuVmpkSFZ5YVc1bkxtRnNaMjh1ZEhNNk9rRnljbUY1UkdWemRISjFZM1IxY21sdVowRnNaMjh1Y0hKdlpIVmpaVVpwZUdWa1gySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNuSmhlUzFrWlhOMGNuVmpkSFZ5YVc1bkxtRnNaMjh1ZEhNNk9rRnljbUY1UkdWemRISjFZM1IxY21sdVowRnNaMjh1Y0hKdlpIVmpaVVpwZUdWa1gySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKeVlYa3RaR1Z6ZEhKMVkzUjFjbWx1Wnk1aGJHZHZMblJ6T2pRMUNpQWdJQ0F2THlCeVpYUjFjbTRnYm1WM0lFWnBlR1ZrUVhKeVlYazhkV2x1ZERZMExDQXpQaWd4TENBeUxDQXpLUW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbkpoZVMxa1pYTjBjblZqZEhWeWFXNW5MbUZzWjI4dWRITTZPa0Z5Y21GNVJHVnpkSEoxWTNSMWNtbHVaMEZzWjI4dVgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsS0NrZ0xUNGdkbTlwWkRvS1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsT2dvZ0lDQWdZaUJmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVmZZbXh2WTJ0QU1Bb0tYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFgySnNiMk5yUURBNkNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBRUFCQ0NZREFBRUdCQlVmZkhWQ0FBQkNBQUF4R3lJVFFRQmVRZ0FBTVJraUVrUXhHQ0lUUVFCTVFnQUFOaG9BZ0FSMHQramZnQVNuZ0FEZWdBUXRyOGJHZ0FUVWkybURUd1NPQkFBY0FCWUFFQUFLUWdBQVFnQUFRZ0FBQUlnQXFVTC84NGdBbTBMLzdZZ0FqVUwvNTRnQUZVTC80VUwvNFRFWkloSXhHQ0lTRUVTSUFXRWtRMElBQURZYUFVa1ZnWWdCRWtSSklpVllGMDRCSllHQUFWaEpJaU5ZVGdFakkxaFBBazRCVHdKUEFVOENUd0pQQW9nQVhFNEVUZ05PQWs0QkZpaFBBVkJPQWtrVkl3NUVJNityS0U4QlVFc0JGU01PUkNPdlR3S3JVRkJQQVJaUVN3RVZJdzVFSTY5UEFxdFFLazhCVUxBa1EwSUFBSWdBTWlSRFFnQUFpQUNySkVOQ0FBQ0lBTVVxVHdGUXNDUkRpZ01GUWdBQWkvMkwvb3YvaS8yTC9rOEVUd1JQQkU4RVR3U0ppZ0FBUWdBQWlBQnZUZ05PQWs0QlRnTk9BMDREVGdPSUFGNU9CMDRDVGdaT0JVNERpQUJSVGdOT0EwNENTVTRIU3dGT0NrNEtUd0ZPQ2s4QlRncE9Db0VGRWtRb0VrUVVSRThDS2FoRVR3RVVSSUVGRWtRcHFFU0JCSUVFRWs4QmdRVVNFRThCS0JJUVR3RWlFaEJQQVNtb0VFU0lBQ3lKUWdBQWdRVW9JaW1KUWdBQUpCWW9Ud0ZRZ1FJV1VFa2lKVmdYVGdFbEpWZ1hUZ0VrRWtTQkFoSkVpVUlBQUNRV0tFOEJVSUVDRmxDQkF4WlFpVUlBQUlrPSIsImNsZWFyIjoiQzBJQUFJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
