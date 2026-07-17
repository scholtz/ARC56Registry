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

namespace Arc56.Generated.algorandfoundation.puya_ts.MyContract_99e9adaa
{


    public class MyContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MyContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ReadonlyObjectDc5110F2 : AVMObjectType
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

                public static ReadonlyObjectDc5110F2 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ReadonlyObjectDc5110F2();
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
                    return Equals(obj as ReadonlyObjectDc5110F2);
                }
                public bool Equals(ReadonlyObjectDc5110F2? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReadonlyObjectDc5110F2 left, ReadonlyObjectDc5110F2 right)
                {
                    return EqualityComparer<ReadonlyObjectDc5110F2>.Default.Equals(left, right);
                }
                public static bool operator !=(ReadonlyObjectDc5110F2 left, ReadonlyObjectDc5110F2 right)
                {
                    return !(left == right);
                }

            }

            public class Xy : AVMObjectType
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

                public static Xy Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Xy();
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
                    return Equals(obj as Xy);
                }
                public bool Equals(Xy? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Xy left, Xy right)
                {
                    return EqualityComparer<Xy>.Default.Equals(left, right);
                }
                public static bool operator !=(Xy left, Xy right)
                {
                    return !(left == right);
                }

            }

            public class Yx : AVMObjectType
            {
                public ulong Y { get; set; }

                public ulong X { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vY.From(Y);
                    ret.AddRange(vY.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Yx Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Yx();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vY.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueY = vY.ToValue();
                    if (valueY is ulong vYValue) { ret.Y = vYValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueX = vX.ToValue();
                    if (valueX is ulong vXValue) { ret.X = vXValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Yx);
                }
                public bool Equals(Yx? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Yx left, Yx right)
                {
                    return EqualityComparer<Yx>.Default.Equals(left, right);
                }
                public static bool operator !=(Yx left, Yx right)
                {
                    return !(left == right);
                }

            }

            public class TestingReturn : AVMObjectType
            {
                public Structs.ReadonlyObjectDc5110F2 Field0 { get; set; } = new Structs.ReadonlyObjectDc5110F2();

                public Structs.ReadonlyObjectDc5110F2 Field1 { get; set; } = new Structs.ReadonlyObjectDc5110F2();

                public Structs.ReadonlyObjectDc5110F2 Field2 { get; set; } = new Structs.ReadonlyObjectDc5110F2();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Field0.ToByteArray());
                    ret.AddRange(Field1.ToByteArray());
                    ret.AddRange(Field2.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TestingReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TestingReturn();
                    ret.Field0 = Structs.ReadonlyObjectDc5110F2.Parse(queue.ToArray());
                    { var consumedField0 = ret.Field0.ToByteArray().Length; for (int i = 0; i < consumedField0 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Field1 = Structs.ReadonlyObjectDc5110F2.Parse(queue.ToArray());
                    { var consumedField1 = ret.Field1.ToByteArray().Length; for (int i = 0; i < consumedField1 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Field2 = Structs.ReadonlyObjectDc5110F2.Parse(queue.ToArray());
                    { var consumedField2 = ret.Field2.ToByteArray().Length; for (int i = 0; i < consumedField2 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TestingReturn);
                }
                public bool Equals(TestingReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TestingReturn left, TestingReturn right)
                {
                    return EqualityComparer<TestingReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(TestingReturn left, TestingReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.Xy> GetXy(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 34, 40, 176 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Xy.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetXy_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 34, 40, 176 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.Yx> GetYx(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 8, 87, 91 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Yx.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetYx_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 8, 87, 91 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.ReadonlyObjectDc5110F2> GetAnon(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 123, 31, 252 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ReadonlyObjectDc5110F2.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAnon_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 123, 31, 252 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x"> XY</param>
        /// <param name="y"> YX</param>
        public async Task Test(Structs.Xy x, Structs.Yx y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 117, 248, 29 };

            var result = await base.CallApp(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test_Transactions(Structs.Xy x, Structs.Yx y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 117, 248, 29 };

            return await base.MakeTransactionList(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.TestingReturn> Testing(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 14, 46, 78 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TestingReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Testing_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 14, 46, 78 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXlDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJSZWFkb25seU9iamVjdERDNTExMEYyIjpbeyJuYW1lIjoieCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ5IiwidHlwZSI6InVpbnQ2NCJ9XSwiWFkiOlt7Im5hbWUiOiJ4IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InkiLCJ0eXBlIjoidWludDY0In1dLCJZWCI6W3sibmFtZSI6InkiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoieCIsInR5cGUiOiJ1aW50NjQifV0sIlRlc3RpbmdSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoiUmVhZG9ubHlPYmplY3REQzUxMTBGMiJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJSZWFkb25seU9iamVjdERDNTExMEYyIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6IlJlYWRvbmx5T2JqZWN0REM1MTEwRjIifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZ2V0WFkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiWFkiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRZWCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJZWCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEFub24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiUmVhZG9ubHlPYmplY3REQzUxMTBGMiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiWFkiLCJuYW1lIjoieCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiWVgiLCJuYW1lIjoieSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0aW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IigodWludDY0LHVpbnQ2NCksKHVpbnQ2NCx1aW50NjQpLCh1aW50NjQsdWludDY0KSkiLCJzdHJ1Y3QiOiJUZXN0aW5nUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszNzhdLCJlcnJvck1lc3NhZ2UiOiJhc3NlcnQgdGFyZ2V0IGlzIG1hdGNoIGZvciBjb25kaXRpb25zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RzL2FwcHJvdmFscy9uYW1lZC10eXBlcy5hbGdvLnRzOjpYWSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB0ZXN0cy9hcHByb3ZhbHMvbmFtZWQtdHlwZXMuYWxnby50czo6WVgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdnTVRZS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFEQUtDbTFoYVc1ZllteHZZMnRBTURvS0lDQWdJR0lnYldGcGJsOWliRzlqYTBBeENncHRZV2x1WDJKc2IyTnJRREU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZibUZ0WldRdGRIbHdaWE11WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFMTVRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhNZ29nSUNBZ1lpQnRZV2x1WDJGaWFWOXliM1YwYVc1blFESUtDbTFoYVc1ZllXSnBYM0p2ZFhScGJtZEFNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZVzFsWkMxMGVYQmxjeTVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RYbERiMjUwY21GamRDQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5Qk9iMDl3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV3Q2lBZ0lDQmlJRzFoYVc1ZlkyRnNiRjlPYjA5d1FETUtDbTFoYVc1ZlkyRnNiRjlPYjA5d1FETTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJtRnRaV1F0ZEhsd1pYTXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUUxNVEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobU1ESXlNamhpTUNBdkx5QnRaWFJvYjJRZ0ltZGxkRmhaS0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ2tpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhrT1RBNE5UYzFZaUF2THlCdFpYUm9iMlFnSW1kbGRGbFlLQ2tvZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzFOemRpTVdabVl5QXZMeUJ0WlhSb2IyUWdJbWRsZEVGdWIyNG9LU2gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHUmpOelZtT0RGa0lDOHZJRzFsZEdodlpDQWlkR1Z6ZENnb2RXbHVkRFkwTEhWcGJuUTJOQ2tzS0hWcGJuUTJOQ3gxYVc1ME5qUXBLWFp2YVdRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd05EQmxNbVUwWlNBdkx5QnRaWFJvYjJRZ0luUmxjM1JwYm1jb0tTZ29kV2x1ZERZMExIVnBiblEyTkNrc0tIVnBiblEyTkN4MWFXNTBOalFwTENoMWFXNTBOalFzZFdsdWREWTBLU2tpQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZloyVjBXRmxmY205MWRHVkFOQ0J0WVdsdVgyZGxkRmxZWDNKdmRYUmxRRFVnYldGcGJsOW5aWFJCYm05dVgzSnZkWFJsUURZZ2JXRnBibDkwWlhOMFgzSnZkWFJsUURjZ2JXRnBibDkwWlhOMGFXNW5YM0p2ZFhSbFFEZ0tJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRGtLQ20xaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTVPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEVLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Ub0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXpDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GdFpXUXRkSGx3WlhNdVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTE1UTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQmxjbklLQ20xaGFXNWZkR1Z6ZEdsdVoxOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGJXVmtMWFI1Y0dWekxtRnNaMjh1ZEhNNk5EQUtJQ0FnSUM4dklIQjFZbXhwWXlCMFpYTjBhVzVuS0NrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMGFXNW5DaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUE1Q2dwdFlXbHVYM1JsYzNSZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl1WVcxbFpDMTBlWEJsY3k1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCd2RXSnNhV01nZEdWemRDaDRPaUJZV1N3Z2VUb2dXVmdwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU9Rb0tiV0ZwYmw5blpYUkJibTl1WDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZibUZ0WldRdGRIbHdaWE11WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnY0hWaWJHbGpJR2RsZEVGdWIyNG9LU0I3Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRUZ1YjI0S0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEa0tDbTFoYVc1ZloyVjBXVmhmY205MWRHVkFOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZVzFsWkMxMGVYQmxjeTVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaMlYwV1Znb0tUb2dXVmdnZXdvZ0lDQWdZMkZzYkhOMVlpQm5aWFJaV0FvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU9Rb0tiV0ZwYmw5blpYUllXVjl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyNWhiV1ZrTFhSNWNHVnpMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJSEIxWW14cFl5Qm5aWFJZV1NncE9pQllXU0I3Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRmhaQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBNUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXdPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEVLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXlPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyNWhiV1ZrTFhSNWNHVnpMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCTmVVTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklFNXZUM0FLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCallXeHNjM1ZpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dVlXMWxaQzEwZVhCbGN5NWhiR2R2TG5Sek9qcE5lVU52Ym5SeVlXTjBMbWRsZEZoWlczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwV0ZrNkNpQWdJQ0JpSUdkbGRGaFpYMkpzYjJOclFEQUtDbWRsZEZoWlgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GdFpXUXRkSGx3WlhNdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRGaFpLQ2s2SUZoWklIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjVoYldWa0xYUjVjR1Z6TG1Gc1oyOHVkSE02T2sxNVEyOXVkSEpoWTNRdVoyVjBXRmtLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjVoYldWa0xYUjVjR1Z6TG1Gc1oyOHVkSE02T2sxNVEyOXVkSEpoWTNRdVoyVjBXVmhiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUlpXRG9LSUNBZ0lHSWdaMlYwV1ZoZllteHZZMnRBTUFvS1oyVjBXVmhmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZVzFsWkMxMGVYQmxjeTVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaMlYwV1Znb0tUb2dXVmdnZXdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJtRnRaV1F0ZEhsd1pYTXVZV3huYnk1MGN6bzZUWGxEYjI1MGNtRmpkQzVuWlhSWldBb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJtRnRaV1F0ZEhsd1pYTXVZV3huYnk1MGN6bzZUWGxEYjI1MGNtRmpkQzVuWlhSQmJtOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFFXNXZiam9LSUNBZ0lHSWdaMlYwUVc1dmJsOWliRzlqYTBBd0NncG5aWFJCYm05dVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GdFpXUXRkSGx3WlhNdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRFRnViMjRvS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZVzFsWkMxMGVYQmxjeTVoYkdkdkxuUnpPanBOZVVOdmJuUnlZV04wTG1kbGRFRnViMjRLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjVoYldWa0xYUjVjR1Z6TG1Gc1oyOHVkSE02T2sxNVEyOXVkSEpoWTNRdWRHVnpkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUTZDaUFnSUNCaUlIUmxjM1JmWW14dlkydEFNQW9LZEdWemRGOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGJXVmtMWFI1Y0dWekxtRnNaMjh1ZEhNNk16WUtJQ0FnSUM4dklIQjFZbXhwWXlCMFpYTjBLSGc2SUZoWkxDQjVPaUJaV0NrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF4TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyNWhiV1ZrTFhSNWNHVnpMbUZzWjI4dWRITTZPbGhaQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dVlXMWxaQzEwZVhCbGN5NWhiR2R2TG5Sek9qcFpXQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyNWhiV1ZrTFhSNWNHVnpMbUZzWjI4dWRITTZPazE1UTI5dWRISmhZM1F1ZEdWemRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl1WVcxbFpDMTBlWEJsY3k1aGJHZHZMblJ6T2pwTmVVTnZiblJ5WVdOMExuUmxjM1JwYm1kYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wYVc1bk9nb2dJQ0FnWWlCMFpYTjBhVzVuWDJKc2IyTnJRREFLQ25SbGMzUnBibWRmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZVzFsWkMxMGVYQmxjeTVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkR1Z6ZEdsdVp5Z3BJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGJXVmtMWFI1Y0dWekxtRnNaMjh1ZEhNNk9rMTVRMjl1ZEhKaFkzUXVkR1Z6ZEdsdVp3b2dJQ0FnWTI5MlpYSWdOUW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGJXVmtMWFI1Y0dWekxtRnNaMjh1ZEhNNk9rMTVRMjl1ZEhKaFkzUXVaMlYwV0Zrb0tTQXRQaUIxYVc1ME5qUXNJSFZwYm5RMk5Eb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyNWhiV1ZrTFhSNWNHVnpMbUZzWjI4dWRITTZPazE1UTI5dWRISmhZM1F1WjJWMFdGazZDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dVlXMWxaQzEwZVhCbGN5NWhiR2R2TG5Sek9qcE5lVU52Ym5SeVlXTjBMbWRsZEZoWlgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5dVlXMWxaQzEwZVhCbGN5NWhiR2R2TG5Sek9qcE5lVU52Ym5SeVlXTjBMbWRsZEZoWlgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GdFpXUXRkSGx3WlhNdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z2VEb2dNU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJtRnRaV1F0ZEhsd1pYTXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdlVG9nTWl3S0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyNWhiV1ZrTFhSNWNHVnpMbUZzWjI4dWRITTZNVFl0TVRrS0lDQWdJQzh2SUhKbGRIVnliaUI3Q2lBZ0lDQXZMeUFnSUhnNklERXNDaUFnSUNBdkx5QWdJSGs2SURJc0NpQWdJQ0F2THlCOUNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GdFpXUXRkSGx3WlhNdVlXeG5ieTUwY3pvNlRYbERiMjUwY21GamRDNW5aWFJaV0NncElDMCtJSFZwYm5RMk5Dd2dkV2x1ZERZME9ncDBaWE4wY3k5aGNIQnliM1poYkhNdmJtRnRaV1F0ZEhsd1pYTXVZV3huYnk1MGN6bzZUWGxEYjI1MGNtRmpkQzVuWlhSWldEb0tJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGJXVmtMWFI1Y0dWekxtRnNaMjh1ZEhNNk9rMTVRMjl1ZEhKaFkzUXVaMlYwV1ZoZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGJXVmtMWFI1Y0dWekxtRnNaMjh1ZEhNNk9rMTVRMjl1ZEhKaFkzUXVaMlYwV1ZoZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl1WVcxbFpDMTBlWEJsY3k1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCNU9pQXhNVEVzQ2lBZ0lDQndkWE5vYVc1MElERXhNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyNWhiV1ZrTFhSNWNHVnpMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJSGc2SURJeU1pd0tJQ0FnSUhCMWMyaHBiblFnTWpJeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GdFpXUXRkSGx3WlhNdVlXeG5ieTUwY3pveU15MHlOZ29nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdlRG9nTWpJeUxBb2dJQ0FnTHk4Z0lDQjVPaUF4TVRFc0NpQWdJQ0F2THlCOUNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GdFpXUXRkSGx3WlhNdVlXeG5ieTUwY3pvNlRYbERiMjUwY21GamRDNW5aWFJCYm05dUtDa2dMVDRnZFdsdWREWTBMQ0IxYVc1ME5qUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZVzFsWkMxMGVYQmxjeTVoYkdkdkxuUnpPanBOZVVOdmJuUnlZV04wTG1kbGRFRnViMjQ2Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZVzFsWkMxMGVYQmxjeTVoYkdkdkxuUnpPanBOZVVOdmJuUnlZV04wTG1kbGRFRnViMjVmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMjVoYldWa0xYUjVjR1Z6TG1Gc1oyOHVkSE02T2sxNVEyOXVkSEpoWTNRdVoyVjBRVzV2Ymw5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjVoYldWa0xYUjVjR1Z6TG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUhnNklGVnBiblEyTkNnektTd0tJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjVoYldWa0xYUjVjR1Z6TG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUhrNklGVnBiblEyTkNnMEtTd0tJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjVoYldWa0xYUjVjR1Z6TG1Gc1oyOHVkSE02TXpBdE16TUtJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lIZzZJRlZwYm5RMk5DZ3pLU3dLSUNBZ0lDOHZJQ0FnZVRvZ1ZXbHVkRFkwS0RRcExBb2dJQ0FnTHk4Z2ZTQmhjeUJqYjI1emRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGJXVmtMWFI1Y0dWekxtRnNaMjh1ZEhNNk9rMTVRMjl1ZEhKaFkzUXVkR1Z6ZENoNExuZzZJSFZwYm5RMk5Dd2dlQzU1T2lCMWFXNTBOalFzSUhrdWVUb2dkV2x1ZERZMExDQjVMbmc2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMjVoYldWa0xYUjVjR1Z6TG1Gc1oyOHVkSE02T2sxNVEyOXVkSEpoWTNRdWRHVnpkRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZVzFsWkMxMGVYQmxjeTVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkR1Z6ZENoNE9pQllXU3dnZVRvZ1dWZ3BJSHNLSUNBZ0lIQnliM1J2SURRZ01Bb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GdFpXUXRkSGx3WlhNdVlXeG5ieTUwY3pvNlRYbERiMjUwY21GamRDNTBaWE4wWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl1WVcxbFpDMTBlWEJsY3k1aGJHZHZMblJ6T2pwTmVVTnZiblJ5WVdOMExuUmxjM1JmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXVZVzFsWkMxMGVYQmxjeTVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNoNExDQjdJQzR1TG5rZ2ZTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0E5UFFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVnlkQ0IwWVhKblpYUWdhWE1nYldGMFkyZ2dabTl5SUdOdmJtUnBkR2x2Ym5NS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl1WVcxbFpDMTBlWEJsY3k1aGJHZHZMblJ6T2pwTmVVTnZiblJ5WVdOMExuUmxjM1JwYm1jb0tTQXRQaUIxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkN3Z2RXbHVkRFkwT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GdFpXUXRkSGx3WlhNdVlXeG5ieTUwY3pvNlRYbERiMjUwY21GamRDNTBaWE4wYVc1bk9nb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GdFpXUXRkSGx3WlhNdVlXeG5ieTUwY3pvNlRYbERiMjUwY21GamRDNTBaWE4wYVc1blgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5dVlXMWxaQzEwZVhCbGN5NWhiR2R2TG5Sek9qcE5lVU52Ym5SeVlXTjBMblJsYzNScGJtZGZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dVlXMWxaQzEwZVhCbGN5NWhiR2R2TG5Sek9qUXhDaUFnSUNBdkx5QmpiMjV6ZENCaElEMGdkR2hwY3k1blpYUllXU2dwQ2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dVlXMWxaQzEwZVhCbGN5NWhiR2R2TG5Sek9qcE5lVU52Ym5SeVlXTjBMbWRsZEZoWkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GdFpXUXRkSGx3WlhNdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z1kyOXVjM1FnWWlBOUlIUm9hWE11WjJWMFdWZ29LUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GdFpXUXRkSGx3WlhNdVlXeG5ieTUwY3pvNlRYbERiMjUwY21GamRDNW5aWFJaV0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjVoYldWa0xYUjVjR1Z6TG1Gc1oyOHVkSE02TkRNS0lDQWdJQzh2SUdOdmJuTjBJR01nUFNCMGFHbHpMbWRsZEVGdWIyNG9LUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GdFpXUXRkSGx3WlhNdVlXeG5ieTUwY3pvNlRYbERiMjUwY21GamRDNW5aWFJCYm05dUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ym1GdFpXUXRkSGx3WlhNdVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZ0aExDQmlMQ0JqWFNCaGN5QmpiMjV6ZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI1aGJXVmtMWFI1Y0dWekxtRnNaMjh1ZEhNNk9rMTVRMjl1ZEhKaFkzUXVYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbEtDa2dMVDRnZG05cFpEb0tYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbE9nb2dJQ0FnWWlCZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZmWW14dlkydEFNQW9LWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxYMkpzYjJOclFEQTZDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUVDWUNBQVFWSDN4MVFnQUFRZ0FBTVJzaUUwRUFiRUlBQURFWkloSkVNUmdpRTBFQVdrSUFBRFlhQUlBRThDSW9zSUFFMlFoWFc0QUVWM3NmL0lBRTNIWDRIWUFFQkE0dVRrOEZqZ1VBSWdBY0FCWUFFQUFLUWdBQVFnQUFRZ0FBQUlnQXEwTC84NGdBYjBMLzdZZ0FVVUwvNTRnQU0wTC80WWdBRlVMLzIwTC8yekVaSWhJeEdDSVNFRVNJQVFBalEwSUFBSWdBdEU0QkZpaFBBVkJQQVJaUUtVOEJVTEFqUTBJQUFJZ0FvMDRCRmloUEFWQlBBUlpRS1U4QlVMQWpRMElBQUlnQWxFNEJGaWhQQVZCUEFSWlFLVThCVUxBalEwSUFBRFlhQVVrVkpSSkVTU0lrV0JkT0FTUWtXQmMyR2dKSkZTVVNSRWtpSkZnWFRnRWtKRmdYVHdOUEEwOERUd09JQUZZalEwSUFBSWdBWVU0RlRnUk9BMDRDVGdFV0tFOEJVRThCRmxBb1R3RlFUd0VXS0U4QlVFOENGbEJRVHdFV0tFOEJVRThDRmxCUUtVOEJVTEFqUTBJQUFDT0JBb2xDQUFDQmI0SGVBWWxDQUFDQkE0RUVpWW9FQUVJQUFJdjlpLzRTaS95TC94SVFSSWxDQUFDSS84K0kvOU9JLzlsUEJVOEZUd1ZQQlU4RlR3V0pRZ0FBaVE9PSIsImNsZWFyIjoiQzBJQUFJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
