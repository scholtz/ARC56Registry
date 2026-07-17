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

namespace Arc56.Generated.algorandfoundation.puya_ts.TestLocalMapTuple_f0a8dbff
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdExvY2FsTWFwVHVwbGUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiT2JqZWN0N0MyQzAzQTkiOlt7Im5hbWUiOiJhIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6Im9wdEluIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiT3B0SW4iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0TWFwT2ZUdXBsZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdE1hcE9mT2JqZWN0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RUdXBsZU1hcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0T2JqZWN0TWFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6NSwiYnl0ZXMiOjV9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0NTcsNDg4LDUwNiw1NjksNjAxLDcwNiw3OTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBMb2NhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMSwyODIsMzE3LDM2OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MCwzNDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQwLDI5MSwzMjYsMzc3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MSwzMDIsMzM3LDM4OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5OV0sImVycm9yTWVzc2FnZSI6Im9iamVjdCB2YWx1ZSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTBdLCJlcnJvck1lc3NhZ2UiOiJvYmplY3QuYSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDldLCJlcnJvck1lc3NhZ2UiOiJvYmplY3QuYiBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MTBdLCJlcnJvck1lc3NhZ2UiOiJ0dXBsZSB2YWx1ZSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzhdLCJlcnJvck1lc3NhZ2UiOiJ0dXBsZVswXSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTZdLCJlcnJvck1lc3NhZ2UiOiJ0dXBsZVsxXSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTNdLCJlcnJvck1lc3NhZ2UiOiJ0dXBsZVsyXSBzaG91bGQgbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRElnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUFpYXpFaUlEQjRJQ0p0WVhCUFpsUjFjR3hsY3lJZ01IZ3dNQ0FpYldGd1QyWlBZbXBsWTNSeklpQWlkSFZ3YkdWTllYQWlJQ0p2WW1wbFkzUk5ZWEFpQ2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ1lpQnRZV2x1WDJKc2IyTnJRREVLQ20xaGFXNWZZbXh2WTJ0QU1Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvMU5pMDFOd29nSUNBZ0x5OGdRR052Ym5SeVlXTjBLSHNnYzNSaGRHVlViM1JoYkhNNklIc2diRzlqWVd4Q2VYUmxjem9nTlN3Z2JHOWpZV3hWYVc1MGN6b2dOU0I5SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWR1Z6ZEV4dlkyRnNUV0Z3VkhWd2JHVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhNd29nSUNBZ1lpQnRZV2x1WDJGaWFWOXliM1YwYVc1blFESUtDbTFoYVc1ZllXSnBYM0p2ZFhScGJtZEFNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzFOaTAxTndvZ0lDQWdMeThnUUdOdmJuUnlZV04wS0hzZ2MzUmhkR1ZVYjNSaGJITTZJSHNnYkc5allXeENlWFJsY3pvZ05Td2diRzlqWVd4VmFXNTBjem9nTlNCOUlIMHBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVkdWemRFeHZZMkZzVFdGd1ZIVndiR1VnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5T1RNeE5HUTVOU0F2THlCdFpYUm9iMlFnSW05d2RFbHVLQ2wyYjJsa0lnb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMjl3ZEVsdVgzSnZkWFJsUURNS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEUUtDbTFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pVMkxUVTNDaUFnSUNBdkx5QkFZMjl1ZEhKaFkzUW9leUJ6ZEdGMFpWUnZkR0ZzY3pvZ2V5QnNiMk5oYkVKNWRHVnpPaUExTENCc2IyTmhiRlZwYm5Sek9pQTFJSDBnZlNrS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlVaWE4wVEc5allXeE5ZWEJVZFhCc1pTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5Qk9iMDl3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV4Q2lBZ0lDQmlJRzFoYVc1ZlkyRnNiRjlPYjA5d1FEVUtDbTFoYVc1ZlkyRnNiRjlPYjA5d1FEVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5UWXROVGNLSUNBZ0lDOHZJRUJqYjI1MGNtRmpkQ2g3SUhOMFlYUmxWRzkwWVd4ek9pQjdJR3h2WTJGc1FubDBaWE02SURVc0lHeHZZMkZzVldsdWRITTZJRFVnZlNCOUtRb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJsYzNSTWIyTmhiRTFoY0ZSMWNHeGxJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRaVGcxTVRsak1XRWdMeThnYldWMGFHOWtJQ0owWlhOMFRXRndUMlpVZFhCc1pYTW9jM1J5YVc1bkxIVnBiblEyTkN4aWIyOXNLWFp2YVdRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa05EVmhaVEEyWVNBdkx5QnRaWFJvYjJRZ0luUmxjM1JOWVhCUFprOWlhbVZqZEhNb2MzUnlhVzVuTEhWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5XSmxORGt6Wm1ZZ0x5OGdiV1YwYUc5a0lDSjBaWE4wVkhWd2JHVk5ZWEFvYzNSeWFXNW5MSFZwYm5RMk5DeGliMjlzS1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzVaakF3WkRGaVpTQXZMeUJ0WlhSb2IyUWdJblJsYzNSUFltcGxZM1JOWVhBb2MzUnlhVzVuTEhWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnRZWFJqYUNCdFlXbHVYM1JsYzNSTllYQlBabFIxY0d4bGMxOXliM1YwWlVBMklHMWhhVzVmZEdWemRFMWhjRTltVDJKcVpXTjBjMTl5YjNWMFpVQTNJRzFoYVc1ZmRHVnpkRlIxY0d4bFRXRndYM0p2ZFhSbFFEZ2diV0ZwYmw5MFpYTjBUMkpxWldOMFRXRndYM0p2ZFhSbFFEa0tJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREV3Q2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVEE2Q2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXlPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvMU5pMDFOd29nSUNBZ0x5OGdRR052Ym5SeVlXTjBLSHNnYzNSaGRHVlViM1JoYkhNNklIc2diRzlqWVd4Q2VYUmxjem9nTlN3Z2JHOWpZV3hWYVc1MGN6b2dOU0I5SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWR1Z6ZEV4dlkyRnNUV0Z3VkhWd2JHVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCbGNuSUtDbTFoYVc1ZmRHVnpkRTlpYW1WamRFMWhjRjl5YjNWMFpVQTVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QjBaWE4wVDJKcVpXTjBUV0Z3S0dFNklITjBjbWx1Wnl3Z1lqb2dkV2x1ZERZMEtTQjdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUlBZbXBsWTNSTllYQUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREV3Q2dwdFlXbHVYM1JsYzNSVWRYQnNaVTFoY0Y5eWIzVjBaVUE0T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPamd3Q2lBZ0lDQXZMeUIwWlhOMFZIVndiR1ZOWVhBb1lUb2djM1J5YVc1bkxDQmlPaUIxYVc1ME5qUXNJR002SUdKdmIyeGxZVzRwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEZSMWNHeGxUV0Z3Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBeE1Bb0tiV0ZwYmw5MFpYTjBUV0Z3VDJaUFltcGxZM1J6WDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJSFJsYzNSTllYQlBaazlpYW1WamRITW9ZVG9nYzNSeWFXNW5MQ0JpT2lCMWFXNTBOalFwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEUxaGNFOW1UMkpxWldOMGN3b2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVEFLQ20xaGFXNWZkR1Z6ZEUxaGNFOW1WSFZ3YkdWelgzSnZkWFJsUURZNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUhSbGMzUk5ZWEJQWmxSMWNHeGxjeWhoT2lCemRISnBibWNzSUdJNklIVnBiblEyTkN3Z1l6b2dZbTl2YkdWaGJpa2dld29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBUV0Z3VDJaVWRYQnNaWE1LSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFd0NncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXhPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLQ20xaGFXNWZiM0IwU1c1ZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSjA5d2RFbHVKeUI5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SUU5d2RFbHVDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWTJGc2JITjFZaUJ2Y0hSSmJnb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOQW9LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UTTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5UWXROVGNLSUNBZ0lDOHZJRUJqYjI1MGNtRmpkQ2g3SUhOMFlYUmxWRzkwWVd4ek9pQjdJR3h2WTJGc1FubDBaWE02SURVc0lHeHZZMkZzVldsdWRITTZJRFVnZlNCOUtRb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJsYzNSTWIyTmhiRTFoY0ZSMWNHeGxJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJRTV2VDNBS0lDQWdJRDA5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmpZV3hzYzNWaUlGOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEV4dlkyRnNUV0Z3VkhWd2JHVXViM0IwU1c1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHZjSFJKYmpvS0lDQWdJR0lnYjNCMFNXNWZZbXh2WTJ0QU1Bb0tiM0IwU1c1ZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSjA5d2RFbHVKeUI5S1FvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JNYjJOaGJFMWhjRlIxY0d4bExtOXdkRWx1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wVEc5allXeE5ZWEJVZFhCc1pTNTBaWE4wVFdGd1QyWlVkWEJzWlhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wVFdGd1QyWlVkWEJzWlhNNkNpQWdJQ0JpSUhSbGMzUk5ZWEJQWmxSMWNHeGxjMTlpYkc5amEwQXdDZ3AwWlhOMFRXRndUMlpVZFhCc1pYTmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvMk53b2dJQ0FnTHk4Z2RHVnpkRTFoY0U5bVZIVndiR1Z6S0dFNklITjBjbWx1Wnl3Z1lqb2dkV2x1ZERZMExDQmpPaUJpYjI5c1pXRnVLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRXh2WTJGc1RXRndWSFZ3YkdVdWRHVnpkRTFoY0U5bVZIVndiR1Z6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wVEc5allXeE5ZWEJVZFhCc1pTNTBaWE4wVFdGd1QyWlBZbXBsWTNSelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEUxaGNFOW1UMkpxWldOMGN6b0tJQ0FnSUdJZ2RHVnpkRTFoY0U5bVQySnFaV04wYzE5aWJHOWphMEF3Q2dwMFpYTjBUV0Z3VDJaUFltcGxZM1J6WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJSFJsYzNSTllYQlBaazlpYW1WamRITW9ZVG9nYzNSeWFXNW5MQ0JpT2lCMWFXNTBOalFwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSTWIyTmhiRTFoY0ZSMWNHeGxMblJsYzNSTllYQlBaazlpYW1WamRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUk1iMk5oYkUxaGNGUjFjR3hsTG5SbGMzUlVkWEJzWlUxaGNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSVWRYQnNaVTFoY0RvS0lDQWdJR0lnZEdWemRGUjFjR3hsVFdGd1gySnNiMk5yUURBS0NuUmxjM1JVZFhCc1pVMWhjRjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qZ3dDaUFnSUNBdkx5QjBaWE4wVkhWd2JHVk5ZWEFvWVRvZ2MzUnlhVzVuTENCaU9pQjFhVzUwTmpRc0lHTTZJR0p2YjJ4bFlXNHBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBURzlqWVd4TllYQlVkWEJzWlM1MFpYTjBWSFZ3YkdWTllYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUk1iMk5oYkUxaGNGUjFjR3hsTG5SbGMzUlBZbXBsWTNSTllYQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFQySnFaV04wVFdGd09nb2dJQ0FnWWlCMFpYTjBUMkpxWldOMFRXRndYMkpzYjJOclFEQUtDblJsYzNSUFltcGxZM1JOWVhCZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem80TlFvZ0lDQWdMeThnZEdWemRFOWlhbVZqZEUxaGNDaGhPaUJ6ZEhKcGJtY3NJR0k2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEV4dlkyRnNUV0Z3VkhWd2JHVXVkR1Z6ZEU5aWFtVmpkRTFoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEV4dlkyRnNUV0Z3VkhWd2JHVXViM0IwU1c0b0tTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JNYjJOaGJFMWhjRlIxY0d4bExtOXdkRWx1T2dvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSTWIyTmhiRTFoY0ZSMWNHeGxMbTl3ZEVsdVgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRXh2WTJGc1RXRndWSFZ3YkdVdWIzQjBTVzVmWW14dlkydEFNRG9LSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEV4dlkyRnNUV0Z3VkhWd2JHVXVkR1Z6ZEUxaGNFOW1WSFZ3YkdWektHRTZJR0o1ZEdWekxDQmlPaUIxYVc1ME5qUXNJR002SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFRHOWpZV3hOWVhCVWRYQnNaUzUwWlhOMFRXRndUMlpVZFhCc1pYTTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklIUmxjM1JOWVhCUFpsUjFjR3hsY3loaE9pQnpkSEpwYm1jc0lHSTZJSFZwYm5RMk5Dd2dZem9nWW05dmJHVmhiaWtnZXdvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRXh2WTJGc1RXRndWSFZ3YkdVdWRHVnpkRTFoY0U5bVZIVndiR1Z6WDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFeHZZMkZzVFdGd1ZIVndiR1V1ZEdWemRFMWhjRTltVkhWd2JHVnpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklIUm9hWE11YldGd1QyWlVkWEJzWlhNb0oyc3hKeXdnVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCYllTd2dZaXdnWTEwS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhwYm5RZ01URUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjMlYwWW1sMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUcxaGNFOW1WSFZ3YkdWeklEMGdURzlqWVd4TllYQThjM1J5YVc1bkxDQmJjM1J5YVc1bkxDQjFhVzUwTmpRc0lHSnZiMnhsWVc1ZFBpZ3BDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnRZWEJQWmxSMWNHeGxjeUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdkR2hwY3k1dFlYQlBabFIxY0d4bGN5Z25hekVuTENCVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlGdGhMQ0JpTENCalhRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWF6RWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklHMWhjRTltVkhWd2JHVnpJRDBnVEc5allXeE5ZWEE4YzNSeWFXNW5MQ0JiYzNSeWFXNW5MQ0IxYVc1ME5qUXNJR0p2YjJ4bFlXNWRQaWdwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnZEdocGN5NXRZWEJQWmxSMWNHeGxjeWduYXpFbkxDQlVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJRnRoTENCaUxDQmpYUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z2JXRndUMlpVZFhCc1pYTWdQU0JNYjJOaGJFMWhjRHh6ZEhKcGJtY3NJRnR6ZEhKcGJtY3NJSFZwYm5RMk5Dd2dZbTl2YkdWaGJsMCtLQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTFoY0U5bVZIVndiR1Z6SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPalk1Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1dFlYQlBabFIxY0d4bGN5Z25hekVuTENCVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlZzd1hTQTlQVDBnWVN3Z0ozUjFjR3hsV3pCZElITm9iM1ZzWkNCdFlYUmphQ2NwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pyTVNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8xT0FvZ0lDQWdMeThnYldGd1QyWlVkWEJzWlhNZ1BTQk1iMk5oYkUxaGNEeHpkSEpwYm1jc0lGdHpkSEpwYm1jc0lIVnBiblEyTkN3Z1ltOXZiR1ZoYmwwK0tDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qWTVDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV0WVhCUFpsUjFjR3hsY3lnbmF6RW5MQ0JVZUc0dWMyVnVaR1Z5S1M1MllXeDFaVnN3WFNBOVBUMGdZU3dnSjNSMWNHeGxXekJkSUhOb2IzVnNaQ0J0WVhSamFDY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1RHOWpZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmpiM1psY2lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdZMjkyWlhJZ01Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RIVndiR1ZiTUYwZ2MyaHZkV3hrSUcxaGRHTm9DaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklHMWhjRTltVkhWd2JHVnpJRDBnVEc5allXeE5ZWEE4YzNSeWFXNW5MQ0JiYzNSeWFXNW5MQ0IxYVc1ME5qUXNJR0p2YjJ4bFlXNWRQaWdwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p0WVhCUFpsUjFjR3hsY3lJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8zTUFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWJXRndUMlpVZFhCc1pYTW9KMnN4Snl3Z1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdWYk1WMGdQVDA5SUdJc0lDZDBkWEJzWlZzeFhTQnphRzkxYkdRZ2JXRjBZMmduS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYXpFaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUcxaGNFOW1WSFZ3YkdWeklEMGdURzlqWVd4TllYQThjM1J5YVc1bkxDQmJjM1J5YVc1bkxDQjFhVzUwTmpRc0lHSnZiMnhsWVc1ZFBpZ3BDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzNNQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11YldGd1QyWlVkWEJzWlhNb0oyc3hKeXdnVkhodUxuTmxibVJsY2lrdWRtRnNkV1ZiTVYwZ1BUMDlJR0lzSUNkMGRYQnNaVnN4WFNCemFHOTFiR1FnYldGMFkyZ25LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFeHZZMkZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSFZ3YkdWYk1WMGdjMmh2ZFd4a0lHMWhkR05vQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOVGdLSUNBZ0lDOHZJRzFoY0U5bVZIVndiR1Z6SUQwZ1RHOWpZV3hOWVhBOGMzUnlhVzVuTENCYmMzUnlhVzVuTENCMWFXNTBOalFzSUdKdmIyeGxZVzVkUGlncENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKdFlYQlBabFIxY0d4bGN5SUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvM01Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXViV0Z3VDJaVWRYQnNaWE1vSjJzeEp5a29WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVmJNbDBnUFQwOUlHTXNJQ2QwZFhCc1pWc3lYU0J6YUc5MWJHUWdiV0YwWTJnbktRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWF6RWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklHMWhjRTltVkhWd2JHVnpJRDBnVEc5allXeE5ZWEE4YzNSeWFXNW5MQ0JiYzNSeWFXNW5MQ0IxYVc1ME5qUXNJR0p2YjJ4bFlXNWRQaWdwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWJXRndUMlpVZFhCc1pYTW9KMnN4Snlrb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdWYk1sMGdQVDA5SUdNc0lDZDBkWEJzWlZzeVhTQnphRzkxYkdRZ2JXRjBZMmduS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRXh2WTJGc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURnd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwZFhCc1pWc3lYU0J6YUc5MWJHUWdiV0YwWTJnS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFeHZZMkZzVFdGd1ZIVndiR1V1ZEdWemRFMWhjRTltVDJKcVpXTjBjeWhoT2lCaWVYUmxjeXdnWWpvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUk1iMk5oYkUxaGNGUjFjR3hsTG5SbGMzUk5ZWEJQWms5aWFtVmpkSE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJSFJsYzNSTllYQlBaazlpYW1WamRITW9ZVG9nYzNSeWFXNW5MQ0JpT2lCMWFXNTBOalFwSUhzS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JNYjJOaGJFMWhjRlIxY0d4bExuUmxjM1JOWVhCUFprOWlhbVZqZEhOZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBURzlqWVd4TllYQlVkWEJzWlM1MFpYTjBUV0Z3VDJaUFltcGxZM1J6WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJSFJvYVhNdWJXRndUMlpQWW1wbFkzUnpLQ2RyTVNjc0lGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdleUJoTENCaUlIMEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUcxaGNFOW1UMkpxWldOMGN5QTlJRXh2WTJGc1RXRndQSE4wY21sdVp5d2dleUJoT2lCemRISnBibWM3SUdJNklIVnBiblEyTkNCOVBpZ3BDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnRZWEJQWms5aWFtVmpkSE1pQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJSFJvYVhNdWJXRndUMlpQWW1wbFkzUnpLQ2RyTVNjc0lGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdleUJoTENCaUlIMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltc3hJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QnRZWEJQWms5aWFtVmpkSE1nUFNCTWIyTmhiRTFoY0R4emRISnBibWNzSUhzZ1lUb2djM1J5YVc1bk95QmlPaUIxYVc1ME5qUWdmVDRvS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUhSb2FYTXViV0Z3VDJaUFltcGxZM1J6S0Nkck1TY3NJRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnZXlCaExDQmlJSDBLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklHMWhjRTltVDJKcVpXTjBjeUE5SUV4dlkyRnNUV0Z3UEhOMGNtbHVaeXdnZXlCaE9pQnpkSEpwYm1jN0lHSTZJSFZwYm5RMk5DQjlQaWdwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p0WVhCUFprOWlhbVZqZEhNaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TnpZS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtMWhjRTltVDJKcVpXTjBjeWduYXpFbktTaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTNWhJRDA5UFNCaExDQW5iMkpxWldOMExtRWdjMmh2ZFd4a0lHMWhkR05vSnlrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1zeElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pVNUNpQWdJQ0F2THlCdFlYQlBaazlpYW1WamRITWdQU0JNYjJOaGJFMWhjRHh6ZEhKcGJtY3NJSHNnWVRvZ2MzUnlhVzVuT3lCaU9pQjFhVzUwTmpRZ2ZUNG9LUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZOellLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG0xaGNFOW1UMkpxWldOMGN5Z25hekVuS1NoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlM1aElEMDlQU0JoTENBbmIySnFaV04wTG1FZ2MyaHZkV3hrSUcxaGRHTm9KeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5Qk1iMk5oYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZZbXBsWTNRdVlTQnphRzkxYkdRZ2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzFPUW9nSUNBZ0x5OGdiV0Z3VDJaUFltcGxZM1J6SUQwZ1RHOWpZV3hOWVhBOGMzUnlhVzVuTENCN0lHRTZJSE4wY21sdVp6c2dZam9nZFdsdWREWTBJSDArS0NrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW0xaGNFOW1UMkpxWldOMGN5SUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvM053b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXViV0Z3VDJaUFltcGxZM1J6S0Nkck1TY3NJRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxMbUlnUFQwOUlHSXNJQ2R2WW1wbFkzUXVZaUJ6YUc5MWJHUWdiV0YwWTJnbktRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWF6RWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk5Ua0tJQ0FnSUM4dklHMWhjRTltVDJKcVpXTjBjeUE5SUV4dlkyRnNUV0Z3UEhOMGNtbHVaeXdnZXlCaE9pQnpkSEpwYm1jN0lHSTZJSFZwYm5RMk5DQjlQaWdwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem8zTndvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWJXRndUMlpQWW1wbFkzUnpLQ2RyTVNjc0lGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbExtSWdQVDA5SUdJc0lDZHZZbXBsWTNRdVlpQnphRzkxYkdRZ2JXRjBZMmduS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRXh2WTJGc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYjJKcVpXTjBMbUlnYzJodmRXeGtJRzFoZEdOb0NpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUk1iMk5oYkUxaGNGUjFjR3hsTG5SbGMzUlVkWEJzWlUxaGNDaGhPaUJpZVhSbGN5d2dZam9nZFdsdWREWTBMQ0JqT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFeHZZMkZzVFdGd1ZIVndiR1V1ZEdWemRGUjFjR3hsVFdGd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pnd0NpQWdJQ0F2THlCMFpYTjBWSFZ3YkdWTllYQW9ZVG9nYzNSeWFXNW5MQ0JpT2lCMWFXNTBOalFzSUdNNklHSnZiMnhsWVc0cElIc0tJQ0FnSUhCeWIzUnZJRE1nTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSTWIyTmhiRTFoY0ZSMWNHeGxMblJsYzNSVWRYQnNaVTFoY0Y5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUk1iMk5oYkUxaGNGUjFjR3hsTG5SbGMzUlVkWEJzWlUxaGNGOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pneENpQWdJQ0F2THlCMGFHbHpMblIxY0d4bFRXRndLRnRoTENCaUxDQmpYU2tvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNBNU9Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdsdWRDQXhNUW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z2RIVndiR1ZOWVhBZ1BTQk1iMk5oYkUxaGNEeGJjM1J5YVc1bkxDQjFhVzUwTmpRc0lHSnZiMnhsWVc1ZExDQjFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUjFjR3hsVFdGd0lnb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem80TVFvZ0lDQWdMeThnZEdocGN5NTBkWEJzWlUxaGNDaGJZU3dnWWl3Z1kxMHBLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnT1RrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnY0hWemFHbHVkQ0E1T1FvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1MGRYQnNaVTFoY0NoYllTd2dZaXdnWTEwc0lGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMDlQU0E1T1N3Z0ozUjFjR3hsSUhaaGJIVmxJSE5vYjNWc1pDQnRZWFJqYUNjcENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vYVc1MElERXhDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCMGRYQnNaVTFoY0NBOUlFeHZZMkZzVFdGd1BGdHpkSEpwYm1jc0lIVnBiblEyTkN3Z1ltOXZiR1ZoYmwwc0lIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWRIVndiR1ZOWVhBaUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1MGRYQnNaVTFoY0NoYllTd2dZaXdnWTEwc0lGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMDlQU0E1T1N3Z0ozUjFjR3hsSUhaaGJIVmxJSE5vYjNWc1pDQnRZWFJqYUNjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnVEc5allXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ09Ua0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhWd2JHVWdkbUZzZFdVZ2MyaHZkV3hrSUcxaGRHTm9DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JNYjJOaGJFMWhjRlIxY0d4bExuUmxjM1JQWW1wbFkzUk5ZWEFvWVRvZ1lubDBaWE1zSUdJNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBURzlqWVd4TllYQlVkWEJzWlM1MFpYTjBUMkpxWldOMFRXRndPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QjBaWE4wVDJKcVpXTjBUV0Z3S0dFNklITjBjbWx1Wnl3Z1lqb2dkV2x1ZERZMEtTQjdDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFRHOWpZV3hOWVhCVWRYQnNaUzUwWlhOMFQySnFaV04wVFdGd1gySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRXh2WTJGc1RXRndWSFZ3YkdVdWRHVnpkRTlpYW1WamRFMWhjRjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFcxaGNDNWhiR2R2TG5Sek9qZzJDaUFnSUNBdkx5QjBhR2x6TG05aWFtVmpkRTFoY0NoN0lHRXNJR0lnZlN3Z1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQTVPUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF0WVhBdVlXeG5ieTUwY3pvMk1nb2dJQ0FnTHk4Z2IySnFaV04wVFdGd0lEMGdURzlqWVd4TllYQThleUJoT2lCemRISnBibWM3SUdJNklIVnBiblEyTkNCOUxDQjFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltOWlhbVZqZEUxaGNDSUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUhSb2FYTXViMkpxWldOMFRXRndLSHNnWVN3Z1lpQjlMQ0JVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SURrNUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUhCMWMyaHBiblFnT1RrS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXRZWEF1WVd4bmJ5NTBjem80TndvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWIySnFaV04wVFdGd0tIc2dZU3dnWWlCOUxDQlVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlQVDBnT1Rrc0lDZHZZbXBsWTNRZ2RtRnNkV1VnYzJodmRXeGtJRzFoZEdOb0p5a0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RiV0Z3TG1Gc1oyOHVkSE02TmpJS0lDQWdJQzh2SUc5aWFtVmpkRTFoY0NBOUlFeHZZMkZzVFdGd1BIc2dZVG9nYzNSeWFXNW5PeUJpT2lCMWFXNTBOalFnZlN3Z2RXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKdlltcGxZM1JOWVhBaUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xXMWhjQzVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1dlltcGxZM1JOWVhBb2V5QmhMQ0JpSUgwc0lGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMDlQU0E1T1N3Z0oyOWlhbVZqZENCMllXeDFaU0J6YUc5MWJHUWdiV0YwWTJnbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUV4dlkyRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElEazVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5aWFtVmpkQ0IyWVd4MVpTQnphRzkxYkdRZ2JXRjBZMmdLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEV4dlkyRnNUV0Z3VkhWd2JHVXVYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbEtDa2dMVDRnZG05cFpEb0tYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbE9nb2dJQ0FnWWlCZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZmWW14dlkydEFNQW9LWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxYMkpzYjJOclFEQTZDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFQ0NDWUhBbXN4QUF0dFlYQlBabFIxY0d4bGN3RUFERzFoY0U5bVQySnFaV04wY3doMGRYQnNaVTFoY0FsdlltcGxZM1JOWVhCQ0FBQkNBQUF4R3lJVFFRQ0FRZ0FBTmhvQWdBUXBNVTJWVHdHT0FRQmVRZ0FBTVJraUVrUXhHQ0lUUVFCTVFnQUFOaG9BZ0FUb1Vad2FnQVRVV3VCcWdBUmI1SlAvZ0FTZkFORytUd1NPQkFBY0FCWUFFQUFLUWdBQVFnQUFRZ0FBQUlnQXlFTC84NGdBajBMLzdZZ0Faa0wvNTRnQUxVTC80VUwvNFRFWkl4SXhHQ0lURUVTSUFCSkMvNVV4R1NJU01SZ2lFaEJFaUFKTUkwTkNBQUNJQUs0alEwSUFBRFlhQVVraVdTTUxKQWhMQVJVU1JGY0NBRFlhQWtrVkpSSkVGellhQTBrVkl4SkVJbE5QQWs4Q1R3S0lBSDhqUTBJQUFEWWFBVWtpV1NNTEpBaExBUlVTUkZjQ0FEWWFBa2tWSlJKRUY0Z0EwQ05EUWdBQU5ob0JTU0paSXdza0NFc0JGUkpFVndJQU5ob0NTUlVsRWtRWE5ob0RTUlVqRWtRaVUwOENUd0pQQW9nQS9TTkRRZ0FBTmhvQlNTSlpJd3NrQ0VzQkZSSkVWd0lBTmhvQ1NSVWxFa1FYaUFFL0kwTkNBQUNKaWdNQVFnQUFpLzBWRmxjR0FvdjlVSUVMRmxjR0FpbFBBVkNML2haUUt5S0wvMVJRVHdGUUtpaFFNUUJQQVU4Q1ppb29VREVBSWs4Q1kwUkpJbGxPQVVrVlRnRlBBazhDVWxjQ0FJdjlFa1FxS0ZBeEFDSlBBbU5FSkNWWUY0ditFa1FxS0ZBeEFDSlBBbU5FZ1ZCVGkvOFNSSW1LQWdCQ0FBQ0wvaFVXVndZQ2kvNVFnUW9XVndZQ0tVOEJVSXYvRmxCUEFWQW5CQ2hRTVFCUEFVOENaaWNFS0ZBeEFDSlBBbU5FU1NKWlRnRkpGVTRCVHdKUEFsSlhBZ0NML2hKRUp3UW9VREVBSWs4Q1kwUWtKVmdYaS84U1JJbUtBd0JDQUFDTC9SVVdWd1lDaS8xUWdRc1dWd1lDS1U4QlVJditGbEFySW92L1ZGQlBBVkFuQlU4QlVERUFUd0dCWTJhTC9SVVdWd1lDaS8xUWdRc1dWd1lDS1U4QlVJditGbEFySW92L1ZGQlBBVkFuQlU4QlVERUFJazhDWTBTQll4SkVpWW9DQUVJQUFJditGUlpYQmdLTC9sQ0JDaFpYQmdJcFR3RlFpLzhXVUU4QlVDY0dUd0ZRTVFCUEFZRmpab3YrRlJaWEJnS0wvbENCQ2haWEJnSXBUd0ZRaS84V1VFOEJVQ2NHVHdGUU1RQWlUd0pqUklGakVrU0pRZ0FBaVE9PSIsImNsZWFyIjoiQzBJQUFJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
