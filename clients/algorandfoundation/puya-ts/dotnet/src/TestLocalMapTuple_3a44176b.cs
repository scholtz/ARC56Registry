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

namespace Arc56.Generated.algorandfoundation.puya_ts.TestLocalMapTuple_3a44176b
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdExvY2FsTWFwVHVwbGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiT2JqZWN0N0MyQzAzQTkiOlt7Im5hbWUiOiJhIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Im9wdEluIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiT3B0SW4iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0TWFwT2ZUdXBsZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdE1hcE9mT2JqZWN0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RUdXBsZU1hcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0T2JqZWN0TWFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6NSwiYnl0ZXMiOjV9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxOTMsMjEzLDIyNSwyODgsMzA4LDM5OSw0NzVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBMb2NhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOCwyMzgsMzIwLDQxMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NSwzNDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM1LDI0NSwzMjcsNDE4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NiwyNTYsMzM4LDQyOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3OV0sImVycm9yTWVzc2FnZSI6Im9iamVjdCB2YWx1ZSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDJdLCJlcnJvck1lc3NhZ2UiOiJvYmplY3QuYSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTJdLCJlcnJvck1lc3NhZ2UiOiJvYmplY3QuYiBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDNdLCJlcnJvck1lc3NhZ2UiOiJ0dXBsZSB2YWx1ZSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDddLCJlcnJvck1lc3NhZ2UiOiJ0dXBsZVswXSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTldLCJlcnJvck1lc3NhZ2UiOiJ0dXBsZVsxXSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzBdLCJlcnJvck1lc3NhZ2UiOiJ0dXBsZVsyXSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRElnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUFpYldGd1QyWlVkWEJzWlhOck1TSWdJbTFoY0U5bVQySnFaV04wYzJzeElpQXdlREF3TUdJZ01IZ3dNQ0F3ZURBd01HRUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvMU5pMDFOd29nSUNBZ0x5OGdRR052Ym5SeVlXTjBLSHNnYzNSaGRHVlViM1JoYkhNNklIc2diRzlqWVd4Q2VYUmxjem9nTlN3Z2JHOWpZV3hWYVc1MGN6b2dOU0I5SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWR1Z6ZEV4dlkyRnNUV0Z3VkhWd2JHVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURJNU16RTBaRGsxSUM4dklHMWxkR2h2WkNBaWIzQjBTVzRvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyOXdkRWx1WDNKdmRYUmxRRE1LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR1U0TlRFNVl6RmhJREI0WkRRMVlXVXdObUVnTUhnMVltVTBPVE5tWmlBd2VEbG1NREJrTVdKbElDOHZJRzFsZEdodlpDQWlkR1Z6ZEUxaGNFOW1WSFZ3YkdWektITjBjbWx1Wnl4MWFXNTBOalFzWW05dmJDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMFpYTjBUV0Z3VDJaUFltcGxZM1J6S0hOMGNtbHVaeXgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRlIxY0d4bFRXRndLSE4wY21sdVp5eDFhVzUwTmpRc1ltOXZiQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wVDJKcVpXTjBUV0Z3S0hOMGNtbHVaeXgxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lIUmxjM1JOWVhCUFpsUjFjR3hsY3lCMFpYTjBUV0Z3VDJaUFltcGxZM1J6SUhSbGMzUlVkWEJzWlUxaGNDQjBaWE4wVDJKcVpXTjBUV0Z3Q2lBZ0lDQmxjbklLQ20xaGFXNWZiM0IwU1c1ZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSjA5d2RFbHVKeUI5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SUU5d2RFbHVDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qVTJMVFUzQ2lBZ0lDQXZMeUJBWTI5dWRISmhZM1FvZXlCemRHRjBaVlJ2ZEdGc2N6b2dleUJzYjJOaGJFSjVkR1Z6T2lBMUxDQnNiMk5oYkZWcGJuUnpPaUExSUgwZ2ZTa0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJVWlhOMFRHOWpZV3hOWVhCVWRYQnNaU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wVEc5allXeE5ZWEJVZFhCc1pTNTBaWE4wVFdGd1QyWlVkWEJzWlhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wVFdGd1QyWlVkWEJzWlhNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUhSbGMzUk5ZWEJQWmxSMWNHeGxjeWhoT2lCemRISnBibWNzSUdJNklIVnBiblEyTkN3Z1l6b2dZbTl2YkdWaGJpa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklIUm9hWE11YldGd1QyWlVkWEJzWlhNb0oyc3hKeXdnVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCYllTd2dZaXdnWTEwS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNR0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaR2xuSURRS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z2JXRndUMlpVZFhCc1pYTWdQU0JNYjJOaGJFMWhjRHh6ZEhKcGJtY3NJRnR6ZEhKcGJtY3NJSFZwYm5RMk5Dd2dZbTl2YkdWaGJsMCtLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTFoY0U5bVZIVndiR1Z6YXpFaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUhSb2FYTXViV0Z3VDJaVWRYQnNaWE1vSjJzeEp5d2dWSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0JiWVN3Z1lpd2dZMTBLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXRZWEJQWmxSMWNHeGxjeWduYXpFbkxDQlVlRzR1YzJWdVpHVnlLUzUyWVd4MVpWc3dYU0E5UFQwZ1lTd2dKM1IxY0d4bFd6QmRJSE5vYjNWc1pDQnRZWFJqYUNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5QnRZWEJQWmxSMWNHeGxjeUE5SUV4dlkyRnNUV0Z3UEhOMGNtbHVaeXdnVzNOMGNtbHVaeXdnZFdsdWREWTBMQ0JpYjI5c1pXRnVYVDRvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYldGd1QyWlVkWEJzWlhOck1TSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvMk9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXViV0Z3VDJaVWRYQnNaWE1vSjJzeEp5d2dWSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVmJNRjBnUFQwOUlHRXNJQ2QwZFhCc1pWc3dYU0J6YUc5MWJHUWdiV0YwWTJnbktRb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUV4dlkyRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGRYQnNaVnN3WFNCemFHOTFiR1FnYldGMFkyZ0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvM01Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXViV0Z3VDJaVWRYQnNaWE1vSjJzeEp5d2dWSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVmJNVjBnUFQwOUlHSXNJQ2QwZFhCc1pWc3hYU0J6YUc5MWJHUWdiV0YwWTJnbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzFPQW9nSUNBZ0x5OGdiV0Z3VDJaVWRYQnNaWE1nUFNCTWIyTmhiRTFoY0R4emRISnBibWNzSUZ0emRISnBibWNzSUhWcGJuUTJOQ3dnWW05dmJHVmhibDArS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW0xaGNFOW1WSFZ3YkdWemF6RWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbTFoY0U5bVZIVndiR1Z6S0Nkck1TY3NJRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxXekZkSUQwOVBTQmlMQ0FuZEhWd2JHVmJNVjBnYzJodmRXeGtJRzFoZEdOb0p5a0tJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCTWIyTmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhWd2JHVmJNVjBnYzJodmRXeGtJRzFoZEdOb0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TnpFS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtMWhjRTltVkhWd2JHVnpLQ2RyTVNjcEtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbFd6SmRJRDA5UFNCakxDQW5kSFZ3YkdWYk1sMGdjMmh2ZFd4a0lHMWhkR05vSnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklHMWhjRTltVkhWd2JHVnpJRDBnVEc5allXeE5ZWEE4YzNSeWFXNW5MQ0JiYzNSeWFXNW5MQ0IxYVc1ME5qUXNJR0p2YjJ4bFlXNWRQaWdwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p0WVhCUFpsUjFjR3hsYzJzeElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pjeENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXRZWEJQWmxSMWNHeGxjeWduYXpFbktTaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpWc3lYU0E5UFQwZ1l5d2dKM1IxY0d4bFd6SmRJSE5vYjNWc1pDQnRZWFJqYUNjcENpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnVEc5allXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ09EQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGRYQnNaVnN5WFNCemFHOTFiR1FnYldGMFkyZ0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvMk53b2dJQ0FnTHk4Z2RHVnpkRTFoY0U5bVZIVndiR1Z6S0dFNklITjBjbWx1Wnl3Z1lqb2dkV2x1ZERZMExDQmpPaUJpYjI5c1pXRnVLU0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wVEc5allXeE5ZWEJVZFhCc1pTNTBaWE4wVFdGd1QyWlBZbXBsWTNSelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEUxaGNFOW1UMkpxWldOMGN6b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvM05Bb2dJQ0FnTHk4Z2RHVnpkRTFoY0U5bVQySnFaV04wY3loaE9pQnpkSEpwYm1jc0lHSTZJSFZwYm5RMk5Da2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z2RHaHBjeTV0WVhCUFprOWlhbVZqZEhNb0oyc3hKeXdnVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCN0lHRXNJR0lnZlFvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1EQXdZUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzFPUW9nSUNBZ0x5OGdiV0Z3VDJaUFltcGxZM1J6SUQwZ1RHOWpZV3hOWVhBOGMzUnlhVzVuTENCN0lHRTZJSE4wY21sdVp6c2dZam9nZFdsdWREWTBJSDArS0NrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW0xaGNFOW1UMkpxWldOMGMyc3hJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QjBhR2x6TG0xaGNFOW1UMkpxWldOMGN5Z25hekVuTENCVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlIc2dZU3dnWWlCOUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YldGd1QyWlBZbXBsWTNSektDZHJNU2NwS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsTG1FZ1BUMDlJR0VzSUNkdlltcGxZM1F1WVNCemFHOTFiR1FnYldGMFkyZ25LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8xT1FvZ0lDQWdMeThnYldGd1QyWlBZbXBsWTNSeklEMGdURzlqWVd4TllYQThjM1J5YVc1bkxDQjdJR0U2SUhOMGNtbHVaenNnWWpvZ2RXbHVkRFkwSUgwK0tDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltMWhjRTltVDJKcVpXTjBjMnN4SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1dFlYQlBaazlpYW1WamRITW9KMnN4Snlrb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVdVlTQTlQVDBnWVN3Z0oyOWlhbVZqZEM1aElITm9iM1ZzWkNCdFlYUmphQ2NwQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dURzlqWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzlpYW1WamRDNWhJSE5vYjNWc1pDQnRZWFJqYUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPamMzQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1dFlYQlBaazlpYW1WamRITW9KMnN4Snl3Z1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVdVlpQTlQVDBnWWl3Z0oyOWlhbVZqZEM1aUlITm9iM1ZzWkNCdFlYUmphQ2NwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pVNUNpQWdJQ0F2THlCdFlYQlBaazlpYW1WamRITWdQU0JNYjJOaGJFMWhjRHh6ZEhKcGJtY3NJSHNnWVRvZ2MzUnlhVzVuT3lCaU9pQjFhVzUwTmpRZ2ZUNG9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWliV0Z3VDJaUFltcGxZM1J6YXpFaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TnpjS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtMWhjRTltVDJKcVpXTjBjeWduYXpFbkxDQlVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTNWlJRDA5UFNCaUxDQW5iMkpxWldOMExtSWdjMmh2ZFd4a0lHMWhkR05vSnlrS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJNYjJOaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5aWFtVmpkQzVpSUhOb2IzVnNaQ0J0WVhSamFBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pjMENpQWdJQ0F2THlCMFpYTjBUV0Z3VDJaUFltcGxZM1J6S0dFNklITjBjbWx1Wnl3Z1lqb2dkV2x1ZERZMEtTQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBURzlqWVd4TllYQlVkWEJzWlM1MFpYTjBWSFZ3YkdWTllYQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFZIVndiR1ZOWVhBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUhSbGMzUlVkWEJzWlUxaGNDaGhPaUJ6ZEhKcGJtY3NJR0k2SUhWcGJuUTJOQ3dnWXpvZ1ltOXZiR1ZoYmlrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T0RFS0lDQWdJQzh2SUhSb2FYTXVkSFZ3YkdWTllYQW9XMkVzSUdJc0lHTmRLU2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SURrNUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNR0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCelpYUmlhWFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TmpFS0lDQWdJQzh2SUhSMWNHeGxUV0Z3SUQwZ1RHOWpZV3hOWVhBOFczTjBjbWx1Wnl3Z2RXbHVkRFkwTENCaWIyOXNaV0Z1WFN3Z2RXbHVkRFkwUGlncENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5SMWNHeGxUV0Z3SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T0RFS0lDQWdJQzh2SUhSb2FYTXVkSFZ3YkdWTllYQW9XMkVzSUdJc0lHTmRLU2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SURrNUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQTVPUW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qZ3lDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTUwZFhCc1pVMWhjQ2hiWVN3Z1lpd2dZMTBzSUZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwOVBTQTVPU3dnSjNSMWNHeGxJSFpoYkhWbElITm9iM1ZzWkNCdFlYUmphQ2NwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dURzlqWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnT1RrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSFZ3YkdVZ2RtRnNkV1VnYzJodmRXeGtJRzFoZEdOb0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUhSbGMzUlVkWEJzWlUxaGNDaGhPaUJ6ZEhKcGJtY3NJR0k2SUhWcGJuUTJOQ3dnWXpvZ1ltOXZiR1ZoYmlrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFeHZZMkZzVFdGd1ZIVndiR1V1ZEdWemRFOWlhbVZqZEUxaGNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSUFltcGxZM1JOWVhBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T0RVS0lDQWdJQzh2SUhSbGMzUlBZbXBsWTNSTllYQW9ZVG9nYzNSeWFXNW5MQ0JpT2lCMWFXNTBOalFwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJSFJvYVhNdWIySnFaV04wVFdGd0tIc2dZU3dnWWlCOUxDQlVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJRGs1Q2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREJoQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pZeUNpQWdJQ0F2THlCdlltcGxZM1JOWVhBZ1BTQk1iMk5oYkUxaGNEeDdJR0U2SUhOMGNtbHVaenNnWWpvZ2RXbHVkRFkwSUgwc0lIVnBiblEyTkQ0b0tRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKdlltcGxZM1JOWVhBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvNE5nb2dJQ0FnTHk4Z2RHaHBjeTV2WW1wbFkzUk5ZWEFvZXlCaExDQmlJSDBzSUZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwZ09Ua0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRGs1Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZPRGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG05aWFtVmpkRTFoY0NoN0lHRXNJR0lnZlN3Z1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BUMDlJRGs1TENBbmIySnFaV04wSUhaaGJIVmxJSE5vYjNWc1pDQnRZWFJqYUNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnVEc5allXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ09Ua0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYjJKcVpXTjBJSFpoYkhWbElITm9iM1ZzWkNCdFlYUmphQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QjBaWE4wVDJKcVpXTjBUV0Z3S0dFNklITjBjbWx1Wnl3Z1lqb2dkV2x1ZERZMEtTQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNDQ1lGRFcxaGNFOW1WSFZ3YkdWemF6RU9iV0Z3VDJaUFltcGxZM1J6YXpFQ0FBc0JBQUlBQ2pFYlFRQkFnQVFwTVUyVk5ob0FqZ0VBS3pFWkZFUXhHRVNDQkFUb1Vad2FCTlJhNEdvRVcrU1Qvd1NmQU5HK05ob0FqZ1FBRVFCL0FORUJMQUF4R1NNU01SZ1FRekVaRkRFWUZCQkROaG9CU1NKWkpBaExBUlVTUkZjQ0FEWWFBa2tWSlJKRUZ6WWFBMGtWSXhKRUlsTkxBaFVXVndZQ1N3TlFTd0lXS2t4UUt5SkxCRlJRVEZBeEFDaFBBbVl4QUNJb1kwUkpJbGxMQVJWU1Z3SUFUd01TUkRFQUlpaGpSQ1JiVHdJU1JERUFJaWhqUklGUVV4SkVJME0yR2dGSklsa2tDRXNCRlJKRVZ3SUFOaG9DU1JVbEVrUVhTd0VWRmxjR0Frc0NVRXNCRmljRVRGQk1VREVBS1U4Q1pqRUFJaWxqUkVraVdVc0JGVkpYQWdCUEFoSkVNUUFpS1dORUpGc1NSQ05ETmhvQlNTSlpKQWhMQVJVU1JGY0NBRFlhQWtrVkpSSkVGellhQTBrVkl4SkVJbE5MQWhVV1Z3WUNUd05RVHdJV0treFFLeUpQQkZSUVRGQ0FDSFIxY0d4bFRXRndURkF4QUVzQmdXTm1NUUFpVHdKalJJRmpFa1FqUXpZYUFVa2lXU1FJU3dFVkVrUlhBZ0EyR2dKSkZTVVNSQmRMQVJVV1Z3WUNUd0pRVEJZbkJFeFFURkNBQ1c5aWFtVmpkRTFoY0V4UU1RQkxBWUZqWmpFQUlrOENZMFNCWXhKRUkwTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
