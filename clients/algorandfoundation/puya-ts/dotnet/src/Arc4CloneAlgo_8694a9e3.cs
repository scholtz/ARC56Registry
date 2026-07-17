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

namespace Arc56.Generated.algorandfoundation.puya_ts.Arc4CloneAlgo_8694a9e3
{


    public class Arc4CloneAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Arc4CloneAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class SharedStruct : AVMObjectType
            {
                public byte[] Foo { get; set; }

                public byte Bar { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vFoo.From(Foo);
                    ret.AddRange(vFoo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vBar.From(Bar);
                    ret.AddRange(vBar.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SharedStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SharedStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vFoo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFoo = vFoo.ToValue();
                    if (valueFoo is byte[] vFooValue) { ret.Foo = vFooValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vBar.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBar = vBar.ToValue();
                    if (valueBar is byte vBarValue) { ret.Bar = vBarValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SharedStruct);
                }
                public bool Equals(SharedStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SharedStruct left, SharedStruct right)
                {
                    return EqualityComparer<SharedStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(SharedStruct left, SharedStruct right)
                {
                    return !(left == right);
                }

            }

            public class TopLevelStruct : AVMObjectType
            {
                public ulong A { get; set; }

                public string B { get; set; }

                public Structs.SharedStruct Shared { get; set; } = new Structs.SharedStruct();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vB.From(B);
                    stringRef[ret.Count] = vB.Encode();
                    ret.AddRange(new byte[2]);
                    stringRef[ret.Count] = Shared.ToByteArray();
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

                public static TopLevelStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new TopLevelStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    var indexB = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vB.Decode(bytes.Skip(indexB + prefixOffset).ToArray());
                    var valueB = vB.ToValue();
                    if (valueB is string vBValue) { ret.B = vBValue; }
                    var indexShared = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Shared = Structs.SharedStruct.Parse(bytes.Skip(indexShared + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TopLevelStruct);
                }
                public bool Equals(TopLevelStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TopLevelStruct left, TopLevelStruct right)
                {
                    return EqualityComparer<TopLevelStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(TopLevelStruct left, TopLevelStruct right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mutable"> </param>
        public async Task Aliasing(ulong[] mutable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 142, 39, 13 };
            var mutableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); mutableAbi.From(mutable);

            var result = await base.CallApp(new List<object> { abiHandle, mutableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Aliasing_Transactions(ulong[] mutable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 57, 142, 39, 13 };
            var mutableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); mutableAbi.From(mutable);

            return await base.MakeTransactionList(new List<object> { abiHandle, mutableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mutable"> </param>
        public async Task Receive(ulong[] mutable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 172, 190, 16 };
            var mutableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); mutableAbi.From(mutable);

            var result = await base.CallApp(new List<object> { abiHandle, mutableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Receive_Transactions(ulong[] mutable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 172, 190, 16 };
            var mutableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); mutableAbi.From(mutable);

            return await base.MakeTransactionList(new List<object> { abiHandle, mutableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        ///
        ///</summary>
        /// <param name="arg"> TopLevelStruct</param>
        public async Task<Structs.SharedStruct> StructReturn(Structs.TopLevelStruct arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 228, 14, 141 };

            var result = await base.CallApp(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SharedStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> StructReturn_Transactions(Structs.TopLevelStruct arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 228, 14, 141 };

            return await base.MakeTransactionList(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXJjNENsb25lQWxnbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJTaGFyZWRTdHJ1Y3QiOlt7Im5hbWUiOiJmb28iLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiYmFyIiwidHlwZSI6InVpbnQ4In1dLCJUb3BMZXZlbFN0cnVjdCI6W3sibmFtZSI6ImEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJzaGFyZWQiLCJ0eXBlIjoiU2hhcmVkU3RydWN0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImFsaWFzaW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibXV0YWJsZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNlaXZlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibXV0YWJsZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNlaXZlUmVhZG9ubHkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0cnVjdFJldHVybiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHN0cmluZywoYnl0ZVtdLHVpbnQ4KSkiLCJzdHJ1Y3QiOiJUb3BMZXZlbFN0cnVjdCIsIm5hbWUiOiJhcmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGJ5dGVbXSx1aW50OCkiLCJzdHJ1Y3QiOiJTaGFyZWRTdHJ1Y3QiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE0OCwxNzEsMTk0LDIzNSwyNzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgVG9wTGV2ZWxTdHJ1Y3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTcsMTgwLDIwM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8dWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDAgb2YgKChsZW4rdWludDhbXSksdWludDgpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMSBvZiAodWludDY0LChsZW4rdXRmOFtdKSwoKGxlbit1aW50OFtdKSx1aW50OCkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMiBvZiAodWludDY0LChsZW4rdXRmOFtdKSwoKGxlbit1aW50OFtdKSx1aW50OCkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIxLDI0NywyNjZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHR1cGxlIGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzgwXSwiZXJyb3JNZXNzYWdlIjoidGhpcyB3b24ndCBlcnJvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElESWdPQW9nSUNBZ1lpQnRZV2x1WDJKc2IyTnJRREFLQ20xaGFXNWZZbXh2WTJ0QU1Eb0tJQ0FnSUdJZ2JXRnBibDlpYkc5amEwQXhDZ3B0WVdsdVgySnNiMk5yUURFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWpiRzl1WlM1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWEpqTkVOc2IyNWxRV3huYnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdJVDBLSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFeENpQWdJQ0JpSUcxaGFXNWZZV0pwWDNKdmRYUnBibWRBTWdvS2JXRnBibDloWW1sZmNtOTFkR2x1WjBBeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRZMnh2Ym1VdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpSRGJHOXVaVUZzWjI4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z1RtOVBjQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQWhQUW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQTVDaUFnSUNCaUlHMWhhVzVmWTJGc2JGOU9iMDl3UURNS0NtMWhhVzVmWTJGc2JGOU9iMDl3UURNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWpiRzl1WlM1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRWEpqTkVOc2IyNWxRV3huYnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURNNU9HVXlOekJrSUM4dklHMWxkR2h2WkNBaVlXeHBZWE5wYm1jb2RXbHVkRFkwVzEwcGRtOXBaQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGd3WVdOaVpURXdJQzh2SUcxbGRHaHZaQ0FpY21WalpXbDJaU2gxYVc1ME5qUmJYU2wyYjJsa0lnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpUSXhNMlkxWWpZZ0x5OGdiV1YwYUc5a0lDSnlaV05sYVhabFVtVmhaRzl1Ykhrb2RXbHVkRFkwVzEwcGRtOXBaQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFl6WlRRd1pUaGtJQzh2SUcxbGRHaHZaQ0FpYzNSeWRXTjBVbVYwZFhKdUtDaDFhVzUwTmpRc2MzUnlhVzVuTENoaWVYUmxXMTBzZFdsdWREZ3BLU2tvWW5sMFpWdGRMSFZwYm5RNEtTSUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdiV0YwWTJnZ2JXRnBibDloYkdsaGMybHVaMTl5YjNWMFpVQTBJRzFoYVc1ZmNtVmpaV2wyWlY5eWIzVjBaVUExSUcxaGFXNWZjbVZqWldsMlpWSmxZV1J2Ym14NVgzSnZkWFJsUURZZ2JXRnBibDl6ZEhKMVkzUlNaWFIxY201ZmNtOTFkR1ZBTndvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU9Bb0tiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURnNkNpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Bb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV3T2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdOc2IyNWxMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmNtTTBRMnh2Ym1WQmJHZHZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ1pYSnlDZ3B0WVdsdVgzTjBjblZqZEZKbGRIVnlibDl5YjNWMFpVQTNPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0WTJ4dmJtVXVZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdjM1J5ZFdOMFVtVjBkWEp1S0dGeVp6b2dWRzl3VEdWMlpXeFRkSEoxWTNRcE9pQlRhR0Z5WldSVGRISjFZM1FnZXdvZ0lDQWdZMkZzYkhOMVlpQnpkSEoxWTNSU1pYUjFjbTRLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURnS0NtMWhhVzVmY21WalpXbDJaVkpsWVdSdmJteDVYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFqYkc5dVpTNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QnlaV05sYVhabFVtVmhaRzl1Ykhrb1lUb2djbVZoWkc5dWJIa2dkV2x1ZERZMFcxMHBJSHQ5Q2lBZ0lDQmpZV3hzYzNWaUlISmxZMlZwZG1WU1pXRmtiMjVzZVFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU9Bb0tiV0ZwYmw5eVpXTmxhWFpsWDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxamJHOXVaUzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJ5WldObGFYWmxLRzExZEdGaWJHVTZJSFZwYm5RMk5GdGRLU0I3ZlFvZ0lDQWdZMkZzYkhOMVlpQnlaV05sYVhabENpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTRDZ3B0WVdsdVgyRnNhV0Z6YVc1blgzSnZkWFJsUURRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWpiRzl1WlM1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCaGJHbGhjMmx1WnlodGRYUmhZbXhsT2lCMWFXNTBOalJiWFNrZ2V3b2dJQ0FnWTJGc2JITjFZaUJoYkdsaGMybHVad29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBT0FvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBNU9nb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UQUtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRZMnh2Ym1VdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ5WXpSRGJHOXVaVUZzWjI4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z1RtOVBjQW9nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdOaGJHeHpkV0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRZMnh2Ym1VdVlXeG5ieTUwY3pvNlpXTm9ieWh6T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE1zSUdKNWRHVnpPZ3BsWTJodk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRZMnh2Ym1VdVlXeG5ieTUwY3pvMk1Bb2dJQ0FnTHk4Z1puVnVZM1JwYjI0Z1pXTm9ieWh6T2lCVGFHRnlaV1JUZEhKMVkzUXBPaUJUYUdGeVpXUlRkSEoxWTNRZ2V3b2dJQ0FnY0hKdmRHOGdNU0F5Q2lBZ0lDQmlJR1ZqYUc5ZllteHZZMnRBTUFvS1pXTm9iMTlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0WTJ4dmJtVXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdjbVYwZFhKdUlITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWpiRzl1WlM1aGJHZHZMblJ6T2pwQmNtTTBRMnh2Ym1WQmJHZHZMbUZzYVdGemFXNW5XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVd4cFlYTnBibWM2Q2lBZ0lDQmlJR0ZzYVdGemFXNW5YMkpzYjJOclFEQUtDbUZzYVdGemFXNW5YMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFqYkc5dVpTNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QmhiR2xoYzJsdVp5aHRkWFJoWW14bE9pQjFhVzUwTmpSYlhTa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhkV2x1ZERZMFBnb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxamJHOXVaUzVoYkdkdkxuUnpPanBCY21NMFEyeHZibVZCYkdkdkxtRnNhV0Z6YVc1bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdFkyeHZibVV1WVd4bmJ5NTBjem82UVhKak5FTnNiMjVsUVd4bmJ5NXlaV05sYVhabFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZqWldsMlpUb0tJQ0FnSUdJZ2NtVmpaV2wyWlY5aWJHOWphMEF3Q2dweVpXTmxhWFpsWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxamJHOXVaUzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJ5WldObGFYWmxLRzExZEdGaWJHVTZJSFZwYm5RMk5GdGRLU0I3ZlFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4ZFdsdWREWTBQZ29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWpiRzl1WlM1aGJHZHZMblJ6T2pwQmNtTTBRMnh2Ym1WQmJHZHZMbkpsWTJWcGRtVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWpiRzl1WlM1aGJHZHZMblJ6T2pwQmNtTTBRMnh2Ym1WQmJHZHZMbkpsWTJWcGRtVlNaV0ZrYjI1c2VWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWTJWcGRtVlNaV0ZrYjI1c2VUb0tJQ0FnSUdJZ2NtVmpaV2wyWlZKbFlXUnZibXg1WDJKc2IyTnJRREFLQ25KbFkyVnBkbVZTWldGa2IyNXNlVjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0WTJ4dmJtVXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdjbVZqWldsMlpWSmxZV1J2Ym14NUtHRTZJSEpsWVdSdmJteDVJSFZwYm5RMk5GdGRLU0I3ZlFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4ZFdsdWREWTBQZ29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWpiRzl1WlM1aGJHZHZMblJ6T2pwQmNtTTBRMnh2Ym1WQmJHZHZMbkpsWTJWcGRtVlNaV0ZrYjI1c2VRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXTnNiMjVsTG1Gc1oyOHVkSE02T2tGeVl6UkRiRzl1WlVGc1oyOHVjM1J5ZFdOMFVtVjBkWEp1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MzUnlkV04wVW1WMGRYSnVPZ29nSUNBZ1lpQnpkSEoxWTNSU1pYUjFjbTVmWW14dlkydEFNQW9LYzNSeWRXTjBVbVYwZFhKdVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWpiRzl1WlM1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCemRISjFZM1JTWlhSMWNtNG9ZWEpuT2lCVWIzQk1aWFpsYkZOMGNuVmpkQ2s2SUZOb1lYSmxaRk4wY25WamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lIUmhhV3dnY0c5cGJuUmxjaUJoZENCcGJtUmxlQ0F4SUc5bUlDaDFhVzUwTmpRc0tHeGxiaXQxZEdZNFcxMHBMQ2dvYkdWdUszVnBiblE0VzEwcExIVnBiblE0S1NrS0lDQWdJR1JwWnlBeENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQndkWE5vYVc1MElERXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTWlCdlppQW9kV2x1ZERZMExDaHNaVzRyZFhSbU9GdGRLU3dvS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwT0NrcENpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmpiM1psY2lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQjBkWEJzWlNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01DQnZaaUFvS0d4bGJpdDFhVzUwT0Z0ZEtTeDFhVzUwT0NrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0FyQ2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCVWIzQk1aWFpsYkZOMGNuVmpkQW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWpiRzl1WlM1aGJHZHZMblJ6T2pwQmNtTTBRMnh2Ym1WQmJHZHZMbk4wY25WamRGSmxkSFZ5YmdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWpiRzl1WlM1aGJHZHZMblJ6T2pwQmNtTTBRMnh2Ym1WQmJHZHZMbUZzYVdGemFXNW5LRzExZEdGaWJHVTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFqYkc5dVpTNWhiR2R2TG5Sek9qcEJjbU0wUTJ4dmJtVkJiR2R2TG1Gc2FXRnphVzVuT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdFkyeHZibVV1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnWVd4cFlYTnBibWNvYlhWMFlXSnNaVG9nZFdsdWREWTBXMTBwSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFqYkc5dVpTNWhiR2R2TG5Sek9qcEJjbU0wUTJ4dmJtVkJiR2R2TG1Gc2FXRnphVzVuWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXTnNiMjVsTG1Gc1oyOHVkSE02T2tGeVl6UkRiRzl1WlVGc1oyOHVZV3hwWVhOcGJtZGZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV05zYjI1bExtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklIUm9hWE11Y21WalpXbDJaU2dvZWlBOUlHTnNiMjVsS0cxMWRHRmliR1VwS1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFqYkc5dVpTNWhiR2R2TG5Sek9qcEJjbU0wUTJ4dmJtVkJiR2R2TG5KbFkyVnBkbVVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdOc2IyNWxMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJSFJvYVhNdWNtVmpaV2wyWlZKbFlXUnZibXg1S0cxMWRHRmliR1VwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGeVl6UXRZMnh2Ym1VdVlXeG5ieTUwY3pvNlFYSmpORU5zYjI1bFFXeG5ieTV5WldObGFYWmxVbVZoWkc5dWJIa0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV05zYjI1bExtRnNaMjh1ZEhNNk9rRnlZelJEYkc5dVpVRnNaMjh1Y21WalpXbDJaU2h0ZFhSaFlteGxPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjbU0wTFdOc2IyNWxMbUZzWjI4dWRITTZPa0Z5WXpSRGJHOXVaVUZzWjI4dWNtVmpaV2wyWlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXTnNiMjVsTG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUhKbFkyVnBkbVVvYlhWMFlXSnNaVG9nZFdsdWREWTBXMTBwSUh0OUNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0WTJ4dmJtVXVZV3huYnk1MGN6bzZRWEpqTkVOc2IyNWxRV3huYnk1eVpXTmxhWFpsWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXTnNiMjVsTG1Gc1oyOHVkSE02T2tGeVl6UkRiRzl1WlVGc1oyOHVjbVZqWldsMlpWOWliRzlqYTBBd09nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWpiRzl1WlM1aGJHZHZMblJ6T2pwQmNtTTBRMnh2Ym1WQmJHZHZMbkpsWTJWcGRtVlNaV0ZrYjI1c2VTaGhPaUJpZVhSbGN5a2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0WTJ4dmJtVXVZV3huYnk1MGN6bzZRWEpqTkVOc2IyNWxRV3huYnk1eVpXTmxhWFpsVW1WaFpHOXViSGs2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWEpqTkMxamJHOXVaUzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJ5WldObGFYWmxVbVZoWkc5dWJIa29ZVG9nY21WaFpHOXViSGtnZFdsdWREWTBXMTBwSUh0OUNpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnlZelF0WTJ4dmJtVXVZV3huYnk1MGN6bzZRWEpqTkVOc2IyNWxRV3huYnk1eVpXTmxhWFpsVW1WaFpHOXViSGxmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdFkyeHZibVV1WVd4bmJ5NTBjem82UVhKak5FTnNiMjVsUVd4bmJ5NXlaV05sYVhabFVtVmhaRzl1YkhsZllteHZZMnRBTURvS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXTnNiMjVsTG1Gc1oyOHVkSE02T2tGeVl6UkRiRzl1WlVGc1oyOHVjM1J5ZFdOMFVtVjBkWEp1S0dGeVp6b2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncDBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFqYkc5dVpTNWhiR2R2TG5Sek9qcEJjbU0wUTJ4dmJtVkJiR2R2TG5OMGNuVmpkRkpsZEhWeWJqb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGNtTTBMV05zYjI1bExtRnNaMjh1ZEhNNk5UTUtJQ0FnSUM4dklITjBjblZqZEZKbGRIVnliaWhoY21jNklGUnZjRXhsZG1Wc1UzUnlkV04wS1RvZ1UyaGhjbVZrVTNSeWRXTjBJSHNLSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWpiRzl1WlM1aGJHZHZMblJ6T2pwQmNtTTBRMnh2Ym1WQmJHZHZMbk4wY25WamRGSmxkSFZ5Ymw5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WVhKak5DMWpiRzl1WlM1aGJHZHZMblJ6T2pwQmNtTTBRMnh2Ym1WQmJHZHZMbk4wY25WamRGSmxkSFZ5Ymw5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ5WXpRdFkyeHZibVV1WVd4bmJ5NTBjem8xTlFvZ0lDQWdMeThnWVhOelpYSjBLR0Z5Wnk1emFHRnlaV1FnUFQwOUlHVmphRzhvWVhKbkxuTm9ZWEpsWkNrc0lDSjBhR2x6SUhkdmJpZDBJR1Z5Y205eUlpa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1kyRnNiSE4xWWlCbFkyaHZDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUm9hWE1nZDI5dUozUWdaWEp5YjNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloY21NMExXTnNiMjVsTG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUhKbGRIVnliaUJoY21jdWMyaGhjbVZrQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUd4bGJnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYSmpOQzFqYkc5dVpTNWhiR2R2TG5Sek9qcEJjbU0wUTJ4dmJtVkJiR2R2TGw5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaU2dwSUMwK0lIWnZhV1E2Q2w5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVG9LSUNBZ0lHSWdYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFgySnNiMk5yUURBS0NsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlY5aWJHOWphMEF3T2dvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVDQ0VJQUFFSUFBREViSWhOQkFGNUNBQUF4R1NJU1JERVlJaE5CQUV4Q0FBQTJHZ0NBQkRtT0p3MkFCSUNzdmhDQUJPSVQ5YmFBQkdQa0RvMVBCSTRFQUJ3QUZnQVFBQXBDQUFCQ0FBQkNBQUFBaUFCM1F2L3ppQUJhUXYvdGlBQTlRdi9uaUFBZ1F2L2hRdi9oTVJraUVqRVlJaElRUklnQkVDTkRpZ0VDUWdBQWkvK0wvNGxDQUFBMkdnRkpJbGtsQ3lRSVN3RVZFa1NJQUpBalEwSUFBRFlhQVVraVdTVUxKQWhMQVJVU1JJZ0FpaU5EUWdBQU5ob0JTU0paSlFza0NFc0JGUkpFaUFCOEkwTkNBQUEyR2dGSkZVNEJTU1ZaU1lFTUVrUkxBVThCU3dOU0lsa2pDeVFJZ1F3SVN3R0JDbGxKU3dJU1JFc0NUd0ZQQkZKSkZVNEJTU0paU1lFREVrUlBBbElpV1NNTEpBaUJBd2dJU3dFVkVrU0lBQzJBQkJVZmZIVlBBVkN3STBPS0FRQkNBQUNMLzRnQUJvdi9pQUFLaVlvQkFVSUFBSXYvaVlvQkFFSUFBSW1LQVFGQ0FBQ0wvNEVLV1l2L0ZZdi9Ud0pQQWxLTC80RUtXWXYvRll2L1R3SlBBbEtJL3doT0FoSkVpLytCQ2xtTC94V0wvMDhDVHdKU1R3R0pRZ0FBaVE9PSIsImNsZWFyIjoiQzBJQUFJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
