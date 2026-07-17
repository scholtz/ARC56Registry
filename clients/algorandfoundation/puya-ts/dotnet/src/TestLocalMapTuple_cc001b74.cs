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

namespace Arc56.Generated.algorandfoundation.puya_ts.TestLocalMapTuple_cc001b74
{


    public class TestLocalMapTupleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestLocalMapTupleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Object7C2C03A9 : AVMObjectType
            {
                public string A { get; set; }

                public ulong B { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vA.From(A);
                    stringRef[ret.Count] = vA.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Object7C2C03A9 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Object7C2C03A9();
                    uint count = 0;
                    var indexA = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vA.Decode(bytes.Skip(indexA + prefixOffset).ToArray());
                    var valueA = vA.ToValue();
                    if (valueA is string vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is ulong vBValue) { ret.B = vBValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Object7C2C03A9);
                }
                public bool Equals(Object7C2C03A9? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Object7C2C03A9 left, Object7C2C03A9 right)
                {
                    return EqualityComparer<Object7C2C03A9>.Default.Equals(left, right);
                }
                public static bool operator !=(Object7C2C03A9 left, Object7C2C03A9 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 49, 77, 149 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 49, 77, 149 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        public async Task TestMapOfTuples(string a, ulong b, bool c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 81, 156, 26 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); cAbi.From(c);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestMapOfTuples_Transactions(string a, ulong b, bool c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 81, 156, 26 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); cAbi.From(c);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task TestMapOfObjects(string a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 90, 224, 106 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestMapOfObjects_Transactions(string a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 90, 224, 106 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        public async Task TestTupleMap(string a, ulong b, bool c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 228, 147, 255 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); cAbi.From(c);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestTupleMap_Transactions(string a, ulong b, bool c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 228, 147, 255 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); cAbi.From(c);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task TestObjectMap(string a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 0, 209, 190 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestObjectMap_Transactions(string a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 159, 0, 209, 190 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdExvY2FsTWFwVHVwbGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiT2JqZWN0N0MyQzAzQTkiOlt7Im5hbWUiOiJhIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Im9wdEluIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiT3B0SW4iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0TWFwT2ZUdXBsZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdE1hcE9mT2JqZWN0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RUdXBsZU1hcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0T2JqZWN0TWFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6NSwiYnl0ZXMiOjV9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNzMsMjY2LDMyNywzNDcsNDI2LDQ0Niw0NThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBMb2NhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMCwxODUsMjc4LDM1OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMiwzODZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE3LDE5MiwyODUsMzY2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOCwyMDMsMjk2LDM3N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3N10sImVycm9yTWVzc2FnZSI6Im9iamVjdCB2YWx1ZSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDFdLCJlcnJvck1lc3NhZ2UiOiJvYmplY3QuYSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTFdLCJlcnJvck1lc3NhZ2UiOiJvYmplY3QuYiBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzBdLCJlcnJvck1lc3NhZ2UiOiJ0dXBsZSB2YWx1ZSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NDBdLCJlcnJvck1lc3NhZ2UiOiJ0dXBsZVswXSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTJdLCJlcnJvck1lc3NhZ2UiOiJ0dXBsZVsxXSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjNdLCJlcnJvck1lc3NhZ2UiOiJ0dXBsZVsyXSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRElnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUFpYldGd1QyWlVkWEJzWlhOck1TSWdJbTFoY0U5bVQySnFaV04wYzJzeElpQXdlREF3TUdFZ01IZ3dNREJpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOVFl0TlRjS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lITjBZWFJsVkc5MFlXeHpPaUI3SUd4dlkyRnNRbmwwWlhNNklEVXNJR3h2WTJGc1ZXbHVkSE02SURVZ2ZTQjlLUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZSbGMzUk1iMk5oYkUxaGNGUjFjR3hsSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lPVE14TkdRNU5TQXZMeUJ0WlhSb2IyUWdJbTl3ZEVsdUtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDl2Y0hSSmJsOXliM1YwWlVBekNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhobE9EVXhPV014WVNBd2VHUTBOV0ZsTURaaElEQjROV0psTkRrelptWWdNSGc1WmpBd1pERmlaU0F2THlCdFpYUm9iMlFnSW5SbGMzUk5ZWEJQWmxSMWNHeGxjeWh6ZEhKcGJtY3NkV2x1ZERZMExHSnZiMndwZG05cFpDSXNJRzFsZEdodlpDQWlkR1Z6ZEUxaGNFOW1UMkpxWldOMGN5aHpkSEpwYm1jc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJblJsYzNSVWRYQnNaVTFoY0NoemRISnBibWNzZFdsdWREWTBMR0p2YjJ3cGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEdWemRFOWlhbVZqZEUxaGNDaHpkSEpwYm1jc2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgzUmxjM1JOWVhCUFpsUjFjR3hsYzE5eWIzVjBaVUEySUcxaGFXNWZkR1Z6ZEUxaGNFOW1UMkpxWldOMGMxOXliM1YwWlVBM0lHMWhhVzVmZEdWemRGUjFjR3hsVFdGd1gzSnZkWFJsUURnZ2JXRnBibDkwWlhOMFQySnFaV04wVFdGd1gzSnZkWFJsUURrS0lDQWdJR1Z5Y2dvS2JXRnBibDkwWlhOMFQySnFaV04wVFdGd1gzSnZkWFJsUURrNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T0RVS0lDQWdJQzh2SUhSbGMzUlBZbXBsWTNSTllYQW9ZVG9nYzNSeWFXNW5MQ0JpT2lCMWFXNTBOalFwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJSFJvYVhNdWIySnFaV04wVFdGd0tIc2dZU3dnWWlCOUxDQlVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJRGs1Q2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREJoQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pZeUNpQWdJQ0F2THlCdlltcGxZM1JOWVhBZ1BTQk1iMk5oYkUxaGNEeDdJR0U2SUhOMGNtbHVaenNnWWpvZ2RXbHVkRFkwSUgwc0lIVnBiblEyTkQ0b0tRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKdlltcGxZM1JOWVhBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvNE5nb2dJQ0FnTHk4Z2RHaHBjeTV2WW1wbFkzUk5ZWEFvZXlCaExDQmlJSDBzSUZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwZ09Ua0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRGs1Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZPRGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG05aWFtVmpkRTFoY0NoN0lHRXNJR0lnZlN3Z1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BUMDlJRGs1TENBbmIySnFaV04wSUhaaGJIVmxJSE5vYjNWc1pDQnRZWFJqYUNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnVEc5allXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ09Ua0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYjJKcVpXTjBJSFpoYkhWbElITm9iM1ZzWkNCdFlYUmphQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QjBaWE4wVDJKcVpXTjBUV0Z3S0dFNklITjBjbWx1Wnl3Z1lqb2dkV2x1ZERZMEtTQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjM1JVZFhCc1pVMWhjRjl5YjNWMFpVQTRPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qZ3dDaUFnSUNBdkx5QjBaWE4wVkhWd2JHVk5ZWEFvWVRvZ2MzUnlhVzVuTENCaU9pQjFhVzUwTmpRc0lHTTZJR0p2YjJ4bFlXNHBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVltOXZiQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qZ3hDaUFnSUNBdkx5QjBhR2x6TG5SMWNHeGxUV0Z3S0Z0aExDQmlMQ0JqWFNrb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQTVPUW9nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TURCaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnpaWFJpYVhRS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklIUjFjR3hsVFdGd0lEMGdURzlqWVd4TllYQThXM04wY21sdVp5d2dkV2x1ZERZMExDQmliMjlzWldGdVhTd2dkV2x1ZERZMFBpZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luUjFjR3hsVFdGd0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk9ERUtJQ0FnSUM4dklIUm9hWE11ZEhWd2JHVk5ZWEFvVzJFc0lHSXNJR05kS1NoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlEazVDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0E1T1FvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1MGRYQnNaVTFoY0NoYllTd2dZaXdnWTEwc0lGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMDlQU0E1T1N3Z0ozUjFjR3hsSUhaaGJIVmxJSE5vYjNWc1pDQnRZWFJqYUNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnVEc5allXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ09Ua0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhWd2JHVWdkbUZzZFdVZ2MyaHZkV3hrSUcxaGRHTm9DaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk9EQUtJQ0FnSUM4dklIUmxjM1JVZFhCc1pVMWhjQ2hoT2lCemRISnBibWNzSUdJNklIVnBiblEyTkN3Z1l6b2dZbTl2YkdWaGJpa2dld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWE4wVFdGd1QyWlBZbXBsWTNSelgzSnZkWFJsUURjNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUhSbGMzUk5ZWEJQWms5aWFtVmpkSE1vWVRvZ2MzUnlhVzVuTENCaU9pQjFhVzUwTmpRcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUhSb2FYTXViV0Z3VDJaUFltcGxZM1J6S0Nkck1TY3NJRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnZXlCaExDQmlJSDBLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd01HRUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklHMWhjRTltVDJKcVpXTjBjeUE5SUV4dlkyRnNUV0Z3UEhOMGNtbHVaeXdnZXlCaE9pQnpkSEpwYm1jN0lHSTZJSFZwYm5RMk5DQjlQaWdwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p0WVhCUFprOWlhbVZqZEhOck1TSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z2RHaHBjeTV0WVhCUFprOWlhbVZqZEhNb0oyc3hKeXdnVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCN0lHRXNJR0lnZlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk56WUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbTFoY0U5bVQySnFaV04wY3lnbmF6RW5LU2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaUzVoSUQwOVBTQmhMQ0FuYjJKcVpXTjBMbUVnYzJodmRXeGtJRzFoZEdOb0p5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOVGtLSUNBZ0lDOHZJRzFoY0U5bVQySnFaV04wY3lBOUlFeHZZMkZzVFdGd1BITjBjbWx1Wnl3Z2V5QmhPaUJ6ZEhKcGJtYzdJR0k2SUhWcGJuUTJOQ0I5UGlncENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdFlYQlBaazlpYW1WamRITnJNU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YldGd1QyWlBZbXBsWTNSektDZHJNU2NwS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsTG1FZ1BUMDlJR0VzSUNkdlltcGxZM1F1WVNCemFHOTFiR1FnYldGMFkyZ25LUW9nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFeHZZMkZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZZbXBsWTNRdVlTQnphRzkxYkdRZ2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzNOd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YldGd1QyWlBZbXBsWTNSektDZHJNU2NzSUZSNGJpNXpaVzVrWlhJcExuWmhiSFZsTG1JZ1BUMDlJR0lzSUNkdlltcGxZM1F1WWlCemFHOTFiR1FnYldGMFkyZ25LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8xT1FvZ0lDQWdMeThnYldGd1QyWlBZbXBsWTNSeklEMGdURzlqWVd4TllYQThjM1J5YVc1bkxDQjdJR0U2SUhOMGNtbHVaenNnWWpvZ2RXbHVkRFkwSUgwK0tDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltMWhjRTltVDJKcVpXTjBjMnN4SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPamMzQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1dFlYQlBaazlpYW1WamRITW9KMnN4Snl3Z1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVdVlpQTlQVDBnWWl3Z0oyOWlhbVZqZEM1aUlITm9iM1ZzWkNCdFlYUmphQ2NwQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dURzlqWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2WW1wbFkzUXVZaUJ6YUc5MWJHUWdiV0YwWTJnS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8zTkFvZ0lDQWdMeThnZEdWemRFMWhjRTltVDJKcVpXTjBjeWhoT2lCemRISnBibWNzSUdJNklIVnBiblEyTkNrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYTjBUV0Z3VDJaVWRYQnNaWE5mY205MWRHVkFOam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzJOd29nSUNBZ0x5OGdkR1Z6ZEUxaGNFOW1WSFZ3YkdWektHRTZJSE4wY21sdVp5d2dZam9nZFdsdWREWTBMQ0JqT2lCaWIyOXNaV0Z1S1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnZEdocGN5NXRZWEJQWmxSMWNHeGxjeWduYXpFbkxDQlVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJRnRoTENCaUxDQmpYUW9nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBd1lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdScFp5QTBDaUFnSUNCelpYUmlhWFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOVGdLSUNBZ0lDOHZJRzFoY0U5bVZIVndiR1Z6SUQwZ1RHOWpZV3hOWVhBOGMzUnlhVzVuTENCYmMzUnlhVzVuTENCMWFXNTBOalFzSUdKdmIyeGxZVzVkUGlncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdFlYQlBabFIxY0d4bGMyc3hJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QjBhR2x6TG0xaGNFOW1WSFZ3YkdWektDZHJNU2NzSUZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwZ1cyRXNJR0lzSUdOZENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzJPUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YldGd1QyWlVkWEJzWlhNb0oyc3hKeXdnVkhodUxuTmxibVJsY2lrdWRtRnNkV1ZiTUYwZ1BUMDlJR0VzSUNkMGRYQnNaVnN3WFNCemFHOTFiR1FnYldGMFkyZ25LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8xT0FvZ0lDQWdMeThnYldGd1QyWlVkWEJzWlhNZ1BTQk1iMk5oYkUxaGNEeHpkSEpwYm1jc0lGdHpkSEpwYm1jc0lIVnBiblEyTkN3Z1ltOXZiR1ZoYmwwK0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltMWhjRTltVkhWd2JHVnphekVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG0xaGNFOW1WSFZ3YkdWektDZHJNU2NzSUZSNGJpNXpaVzVrWlhJcExuWmhiSFZsV3pCZElEMDlQU0JoTENBbmRIVndiR1ZiTUYwZ2MyaHZkV3hrSUcxaGRHTm9KeWtLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5Qk1iMk5oYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSFZ3YkdWYk1GMGdjMmh2ZFd4a0lHMWhkR05vQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOekFLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG0xaGNFOW1WSFZ3YkdWektDZHJNU2NzSUZSNGJpNXpaVzVrWlhJcExuWmhiSFZsV3pGZElEMDlQU0JpTENBbmRIVndiR1ZiTVYwZ2MyaHZkV3hrSUcxaGRHTm9KeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUcxaGNFOW1WSFZ3YkdWeklEMGdURzlqWVd4TllYQThjM1J5YVc1bkxDQmJjM1J5YVc1bkxDQjFhVzUwTmpRc0lHSnZiMnhsWVc1ZFBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnRZWEJQWmxSMWNHeGxjMnN4SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1dFlYQlBabFIxY0d4bGN5Z25hekVuTENCVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlZzeFhTQTlQVDBnWWl3Z0ozUjFjR3hsV3pGZElITm9iM1ZzWkNCdFlYUmphQ2NwQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dURzlqWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUjFjR3hsV3pGZElITm9iM1ZzWkNCdFlYUmphQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qY3hDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV0WVhCUFpsUjFjR3hsY3lnbmF6RW5LU2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaVnN5WFNBOVBUMGdZeXdnSjNSMWNHeGxXekpkSUhOb2IzVnNaQ0J0WVhSamFDY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUJ0WVhCUFpsUjFjR3hsY3lBOUlFeHZZMkZzVFdGd1BITjBjbWx1Wnl3Z1czTjBjbWx1Wnl3Z2RXbHVkRFkwTENCaWIyOXNaV0Z1WFQ0b0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJXRndUMlpVZFhCc1pYTnJNU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YldGd1QyWlVkWEJzWlhNb0oyc3hKeWtvVkhodUxuTmxibVJsY2lrdWRtRnNkV1ZiTWwwZ1BUMDlJR01zSUNkMGRYQnNaVnN5WFNCemFHOTFiR1FnYldGMFkyZ25LUW9nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFeHZZMkZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJRGd3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSFZ3YkdWYk1sMGdjMmh2ZFd4a0lHMWhkR05vQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOamNLSUNBZ0lDOHZJSFJsYzNSTllYQlBabFIxY0d4bGN5aGhPaUJ6ZEhKcGJtY3NJR0k2SUhWcGJuUTJOQ3dnWXpvZ1ltOXZiR1ZoYmlrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5dmNIUkpibDl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQW5UM0IwU1c0bklIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdUM0IwU1c0S0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TlRZdE5UY0tJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJSE4wWVhSbFZHOTBZV3h6T2lCN0lHeHZZMkZzUW5sMFpYTTZJRFVzSUd4dlkyRnNWV2x1ZEhNNklEVWdmU0I5S1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGUmxjM1JNYjJOaGJFMWhjRlIxY0d4bElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFQ0NDWUVEVzFoY0U5bVZIVndiR1Z6YXpFT2JXRndUMlpQWW1wbFkzUnphekVDQUFvQ0FBc3hHMEVCcVlBRUtURk5sVFlhQUk0QkFaUXhHUlJFTVJoRWdnUUU2RkdjR2dUVVd1QnFCRnZray84RW53RFJ2allhQUk0RUFQb0FxUUJNQUFFQU5ob0JTU0paSkFoTEFSVVNSRmNDQURZYUFra1ZKUkpFRjBzQkZSWlhCZ0pQQWxCTUZpcE1VRXhRZ0FsdlltcGxZM1JOWVhCTVVERUFTd0dCWTJZeEFDSlBBbU5FZ1dNU1JDTkROaG9CU1NKWkpBaExBUlVTUkZjQ0FEWWFBa2tWSlJKRUZ6WWFBMGtWSXhKRUlsTkxBaFVXVndZQ1R3TlFUd0lXSzB4UWdBRUFJazhFVkZCTVVJQUlkSFZ3YkdWTllYQk1VREVBU3dHQlkyWXhBQ0pQQW1ORWdXTVNSQ05ETmhvQlNTSlpKQWhMQVJVU1JGY0NBRFlhQWtrVkpSSkVGMHNCRlJaWEJnSkxBbEJMQVJZcVRGQk1VREVBS1U4Q1pqRUFJaWxqUkVraVdVc0JGVkpYQWdCUEFoSkVNUUFpS1dORUpGc1NSQ05ETmhvQlNTSlpKQWhMQVJVU1JGY0NBRFlhQWtrVkpSSkVGellhQTBrVkl4SkVJbE5MQWhVV1Z3WUNTd05RU3dJV0sweFFnQUVBSWtzRVZGQk1VREVBS0U4Q1pqRUFJaWhqUkVraVdVc0JGVkpYQWdCUEF4SkVNUUFpS0dORUpGdFBBaEpFTVFBaUtHTkVnVkJURWtRalF6RVpJeEl4R0JCRE1Sa1VNUmdVRUVNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
