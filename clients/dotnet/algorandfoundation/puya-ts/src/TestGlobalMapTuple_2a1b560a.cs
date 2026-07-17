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

namespace Arc56.Generated.algorandfoundation.puya_ts.TestGlobalMapTuple_2a1b560a
{


    public class TestGlobalMapTupleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestGlobalMapTupleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdEdsb2JhbE1hcFR1cGxlIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDdDMkMwM0E5IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJiIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0TWFwT2ZUdXBsZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdE1hcE9mT2JqZWN0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RUdXBsZU1hcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0T2JqZWN0TWFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjUsImJ5dGVzIjo1fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0MDUsNDM0LDQ1MCw1MDcsNTM3LDYzNiw3MTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODksMjQwLDI3NSwzMjZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTgsMzA0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5OCwyNDksMjg0LDMzNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDksMjYwLDI5NSwzNDZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjNdLCJlcnJvck1lc3NhZ2UiOiJvYmplY3QgdmFsdWUgc2hvdWxkIG1hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTI4XSwiZXJyb3JNZXNzYWdlIjoib2JqZWN0LmEgc2hvdWxkIG1hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ1XSwiZXJyb3JNZXNzYWdlIjoib2JqZWN0LmIgc2hvdWxkIG1hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQwXSwiZXJyb3JNZXNzYWdlIjoidHVwbGUgdmFsdWUgc2hvdWxkIG1hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI2XSwiZXJyb3JNZXNzYWdlIjoidHVwbGVbMF0gc2hvdWxkIG1hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQyXSwiZXJyb3JNZXNzYWdlIjoidHVwbGVbMV0gc2hvdWxkIG1hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU3XSwiZXJyb3JNZXNzYWdlIjoidHVwbGVbMl0gc2hvdWxkIG1hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURJZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWF6RWlJREI0SUNKdFlYQlBabFIxY0d4bGN5SWdNSGd3TUNBaWJXRndUMlpQWW1wbFkzUnpJaUFpZEhWd2JHVk5ZWEFpSUNKdlltcGxZM1JOWVhBaUNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURFS0NtMWhhVzVmWW14dlkydEFNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZORGd0TkRrS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lITjBZWFJsVkc5MFlXeHpPaUI3SUdkc2IySmhiRUo1ZEdWek9pQTFMQ0JuYkc5aVlXeFZhVzUwY3pvZ05TQjlJSDBwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1ZHVnpkRWRzYjJKaGJFMWhjRlIxY0d4bElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0FoUFFvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1URUtJQ0FnSUdJZ2JXRnBibDloWW1sZmNtOTFkR2x1WjBBeUNncHRZV2x1WDJGaWFWOXliM1YwYVc1blFESTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qUTRMVFE1Q2lBZ0lDQXZMeUJBWTI5dWRISmhZM1FvZXlCemRHRjBaVlJ2ZEdGc2N6b2dleUJuYkc5aVlXeENlWFJsY3pvZ05Td2daMnh2WW1Gc1ZXbHVkSE02SURVZ2ZTQjlLUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZSbGMzUkhiRzlpWVd4TllYQlVkWEJzWlNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlCT2IwOXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDRTlDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEa0tJQ0FnSUdJZ2JXRnBibDlqWVd4c1gwNXZUM0JBTXdvS2JXRnBibDlqWVd4c1gwNXZUM0JBTXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02TkRndE5Ea0tJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJSE4wWVhSbFZHOTBZV3h6T2lCN0lHZHNiMkpoYkVKNWRHVnpPaUExTENCbmJHOWlZV3hWYVc1MGN6b2dOU0I5SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWR1Z6ZEVkc2IySmhiRTFoY0ZSMWNHeGxJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRaVGcxTVRsak1XRWdMeThnYldWMGFHOWtJQ0owWlhOMFRXRndUMlpVZFhCc1pYTW9jM1J5YVc1bkxIVnBiblEyTkN4aWIyOXNLWFp2YVdRaUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa05EVmhaVEEyWVNBdkx5QnRaWFJvYjJRZ0luUmxjM1JOWVhCUFprOWlhbVZqZEhNb2MzUnlhVzVuTEhWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5XSmxORGt6Wm1ZZ0x5OGdiV1YwYUc5a0lDSjBaWE4wVkhWd2JHVk5ZWEFvYzNSeWFXNW5MSFZwYm5RMk5DeGliMjlzS1hadmFXUWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzVaakF3WkRGaVpTQXZMeUJ0WlhSb2IyUWdJblJsYzNSUFltcGxZM1JOWVhBb2MzUnlhVzVuTEhWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnRZWFJqYUNCdFlXbHVYM1JsYzNSTllYQlBabFIxY0d4bGMxOXliM1YwWlVBMElHMWhhVzVmZEdWemRFMWhjRTltVDJKcVpXTjBjMTl5YjNWMFpVQTFJRzFoYVc1ZmRHVnpkRlIxY0d4bFRXRndYM0p2ZFhSbFFEWWdiV0ZwYmw5MFpYTjBUMkpxWldOMFRXRndYM0p2ZFhSbFFEY0tJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRGdLQ20xaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTRPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Eb0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXlDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pRNExUUTVDaUFnSUNBdkx5QkFZMjl1ZEhKaFkzUW9leUJ6ZEdGMFpWUnZkR0ZzY3pvZ2V5Qm5iRzlpWVd4Q2VYUmxjem9nTlN3Z1oyeHZZbUZzVldsdWRITTZJRFVnZlNCOUtRb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJsYzNSSGJHOWlZV3hOWVhCVWRYQnNaU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lHVnljZ29LYldGcGJsOTBaWE4wVDJKcVpXTjBUV0Z3WDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPamMwQ2lBZ0lDQXZMeUIwWlhOMFQySnFaV04wVFdGd0tHRTZJSE4wY21sdVp5d2dZam9nZFdsdWREWTBLU0I3Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1JQWW1wbFkzUk5ZWEFLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURnS0NtMWhhVzVmZEdWemRGUjFjR3hsVFdGd1gzSnZkWFJsUURZNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCMFpYTjBWSFZ3YkdWTllYQW9ZVG9nYzNSeWFXNW5MQ0JpT2lCMWFXNTBOalFzSUdNNklHSnZiMnhsWVc0cElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRGUjFjR3hsVFdGd0NpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTRDZ3B0WVdsdVgzUmxjM1JOWVhCUFprOWlhbVZqZEhOZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUhSbGMzUk5ZWEJQWms5aWFtVmpkSE1vWVRvZ2MzUnlhVzVuTENCaU9pQjFhVzUwTmpRcElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRFMWhjRTltVDJKcVpXTjBjd29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBT0FvS2JXRnBibDkwWlhOMFRXRndUMlpVZFhCc1pYTmZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklIUmxjM1JOWVhCUFpsUjFjR3hsY3loaE9pQnpkSEpwYm1jc0lHSTZJSFZwYm5RMk5Dd2dZem9nWW05dmJHVmhiaWtnZXdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wVFdGd1QyWlVkWEJzWlhNS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEZ0tDbTFoYVc1ZlkzSmxZWFJsWDA1dlQzQkFPVG9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV3Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZORGd0TkRrS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lITjBZWFJsVkc5MFlXeHpPaUI3SUdkc2IySmhiRUo1ZEdWek9pQTFMQ0JuYkc5aVlXeFZhVzUwY3pvZ05TQjlJSDBwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1ZHVnpkRWRzYjJKaGJFMWhjRlIxY0d4bElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklFNXZUM0FLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCallXeHNjM1ZpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JIYkc5aVlXeE5ZWEJVZFhCc1pTNTBaWE4wVFdGd1QyWlVkWEJzWlhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wVFdGd1QyWlVkWEJzWlhNNkNpQWdJQ0JpSUhSbGMzUk5ZWEJQWmxSMWNHeGxjMTlpYkc5amEwQXdDZ3AwWlhOMFRXRndUMlpVZFhCc1pYTmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklIUmxjM1JOWVhCUFpsUjFjR3hsY3loaE9pQnpkSEpwYm1jc0lHSTZJSFZwYm5RMk5Dd2dZem9nWW05dmJHVmhiaWtnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wUjJ4dlltRnNUV0Z3VkhWd2JHVXVkR1Z6ZEUxaGNFOW1WSFZ3YkdWekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFZHNiMkpoYkUxaGNGUjFjR3hsTG5SbGMzUk5ZWEJQWms5aWFtVmpkSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBUV0Z3VDJaUFltcGxZM1J6T2dvZ0lDQWdZaUIwWlhOMFRXRndUMlpQWW1wbFkzUnpYMkpzYjJOclFEQUtDblJsYzNSTllYQlBaazlpYW1WamRITmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk5qTUtJQ0FnSUM4dklIUmxjM1JOWVhCUFprOWlhbVZqZEhNb1lUb2djM1J5YVc1bkxDQmlPaUIxYVc1ME5qUXBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wUjJ4dlltRnNUV0Z3VkhWd2JHVXVkR1Z6ZEUxaGNFOW1UMkpxWldOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUkhiRzlpWVd4TllYQlVkWEJzWlM1MFpYTjBWSFZ3YkdWTllYQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFZIVndiR1ZOWVhBNkNpQWdJQ0JpSUhSbGMzUlVkWEJzWlUxaGNGOWliRzlqYTBBd0NncDBaWE4wVkhWd2JHVk5ZWEJmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJSFJsYzNSVWRYQnNaVTFoY0NoaE9pQnpkSEpwYm1jc0lHSTZJSFZwYm5RMk5Dd2dZem9nWW05dmJHVmhiaWtnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wUjJ4dlltRnNUV0Z3VkhWd2JHVXVkR1Z6ZEZSMWNHeGxUV0Z3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEVkc2IySmhiRTFoY0ZSMWNHeGxMblJsYzNSUFltcGxZM1JOWVhCYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wVDJKcVpXTjBUV0Z3T2dvZ0lDQWdZaUIwWlhOMFQySnFaV04wVFdGd1gySnNiMk5yUURBS0NuUmxjM1JQWW1wbFkzUk5ZWEJmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJSFJsYzNSUFltcGxZM1JOWVhBb1lUb2djM1J5YVc1bkxDQmlPaUIxYVc1ME5qUXBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wUjJ4dlltRnNUV0Z3VkhWd2JHVXVkR1Z6ZEU5aWFtVmpkRTFoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSSGJHOWlZV3hOWVhCVWRYQnNaUzUwWlhOMFRXRndUMlpVZFhCc1pYTW9ZVG9nWW5sMFpYTXNJR0k2SUhWcGJuUTJOQ3dnWXpvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pwVVpYTjBSMnh2WW1Gc1RXRndWSFZ3YkdVdWRHVnpkRTFoY0U5bVZIVndiR1Z6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnZEdWemRFMWhjRTltVkhWd2JHVnpLR0U2SUhOMGNtbHVaeXdnWWpvZ2RXbHVkRFkwTENCak9pQmliMjlzWldGdUtTQjdDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem82VkdWemRFZHNiMkpoYkUxaGNGUjFjR3hsTG5SbGMzUk5ZWEJQWmxSMWNHeGxjMTlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFIyeHZZbUZzVFdGd1ZIVndiR1V1ZEdWemRFMWhjRTltVkhWd2JHVnpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QjBhR2x6TG0xaGNFOW1WSFZ3YkdWektDZHJNU2NwTG5aaGJIVmxJRDBnVzJFc0lHSXNJR05kQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9hVzUwSURFeENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmRzYjJKaGJDMXRZWEF1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnYldGd1QyWlVkWEJzWlhNZ1BTQkhiRzlpWVd4TllYQThjM1J5YVc1bkxDQmJjM1J5YVc1bkxDQjFhVzUwTmpRc0lHSnZiMnhsWVc1ZFBpZ3BDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnRZWEJQWmxSMWNHeGxjeUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJSFJvYVhNdWJXRndUMlpVZFhCc1pYTW9KMnN4SnlrdWRtRnNkV1VnUFNCYllTd2dZaXdnWTEwS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1zeElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z2JXRndUMlpVZFhCc1pYTWdQU0JIYkc5aVlXeE5ZWEE4YzNSeWFXNW5MQ0JiYzNSeWFXNW5MQ0IxYVc1ME5qUXNJR0p2YjJ4bFlXNWRQaWdwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02TlRjS0lDQWdJQzh2SUhSb2FYTXViV0Z3VDJaVWRYQnNaWE1vSjJzeEp5a3VkbUZzZFdVZ1BTQmJZU3dnWWl3Z1kxMEtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUcxaGNFOW1WSFZ3YkdWeklEMGdSMnh2WW1Gc1RXRndQSE4wY21sdVp5d2dXM04wY21sdVp5d2dkV2x1ZERZMExDQmliMjlzWldGdVhUNG9LUW9nSUNBZ1lubDBaV05mTWlBdkx5QWliV0Z3VDJaVWRYQnNaWE1pQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1dFlYQlBabFIxY0d4bGN5Z25hekVuS1M1MllXeDFaVnN3WFNBOVBUMGdZU3dnSjNSMWNHeGxXekJkSUhOb2IzVnNaQ0J0WVhSamFDY3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnJNU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJRzFoY0U5bVZIVndiR1Z6SUQwZ1IyeHZZbUZzVFdGd1BITjBjbWx1Wnl3Z1czTjBjbWx1Wnl3Z2RXbHVkRFkwTENCaWIyOXNaV0Z1WFQ0b0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV0WVhCUFpsUjFjR3hsY3lnbmF6RW5LUzUyWVd4MVpWc3dYU0E5UFQwZ1lTd2dKM1IxY0d4bFd6QmRJSE5vYjNWc1pDQnRZWFJqYUNjcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBkWEJzWlZzd1hTQnphRzkxYkdRZ2JXRjBZMmdLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJRzFoY0U5bVZIVndiR1Z6SUQwZ1IyeHZZbUZzVFdGd1BITjBjbWx1Wnl3Z1czTjBjbWx1Wnl3Z2RXbHVkRFkwTENCaWIyOXNaV0Z1WFQ0b0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJXRndUMlpVZFhCc1pYTWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qVTVDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV0WVhCUFpsUjFjR3hsY3lnbmF6RW5LUzUyWVd4MVpWc3hYU0E5UFQwZ1lpd2dKM1IxY0d4bFd6RmRJSE5vYjNWc1pDQnRZWFJqYUNjcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKck1TSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklHMWhjRTltVkhWd2JHVnpJRDBnUjJ4dlltRnNUV0Z3UEhOMGNtbHVaeXdnVzNOMGNtbHVaeXdnZFdsdWREWTBMQ0JpYjI5c1pXRnVYVDRvS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pVNUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXRZWEJQWmxSMWNHeGxjeWduYXpFbktTNTJZV3gxWlZzeFhTQTlQVDBnWWl3Z0ozUjFjR3hsV3pGZElITm9iM1ZzWkNCdFlYUmphQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUjFjR3hsV3pGZElITm9iM1ZzWkNCdFlYUmphQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdiV0Z3VDJaVWRYQnNaWE1nUFNCSGJHOWlZV3hOWVhBOGMzUnlhVzVuTENCYmMzUnlhVzVuTENCMWFXNTBOalFzSUdKdmIyeGxZVzVkUGlncENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKdFlYQlBabFIxY0d4bGN5SUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk5qQUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbTFoY0U5bVZIVndiR1Z6S0Nkck1TY3BMblpoYkhWbFd6SmRJRDA5UFNCakxDQW5kSFZ3YkdWYk1sMGdjMmh2ZFd4a0lHMWhkR05vSnlrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1zeElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z2JXRndUMlpVZFhCc1pYTWdQU0JIYkc5aVlXeE5ZWEE4YzNSeWFXNW5MQ0JiYzNSeWFXNW5MQ0IxYVc1ME5qUXNJR0p2YjJ4bFlXNWRQaWdwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtMWhjRTltVkhWd2JHVnpLQ2RyTVNjcExuWmhiSFZsV3pKZElEMDlQU0JqTENBbmRIVndiR1ZiTWwwZ2MyaHZkV3hrSUcxaGRHTm9KeWtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElEZ3dDaUFnSUNCblpYUmlhWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGRYQnNaVnN5WFNCemFHOTFiR1FnYldGMFkyZ0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JIYkc5aVlXeE5ZWEJVZFhCc1pTNTBaWE4wVFdGd1QyWlBZbXBsWTNSektHRTZJR0o1ZEdWekxDQmlPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZPbFJsYzNSSGJHOWlZV3hOWVhCVWRYQnNaUzUwWlhOMFRXRndUMlpQWW1wbFkzUnpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdkR1Z6ZEUxaGNFOW1UMkpxWldOMGN5aGhPaUJ6ZEhKcGJtY3NJR0k2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdjSEp2ZEc4Z01pQXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JIYkc5aVlXeE5ZWEJVZFhCc1pTNTBaWE4wVFdGd1QyWlBZbXBsWTNSelgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JIYkc5aVlXeE5ZWEJVZFhCc1pTNTBaWE4wVFdGd1QyWlBZbXBsWTNSelgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCMGFHbHpMbTFoY0U5bVQySnFaV04wY3lnbmF6RW5LUzUyWVd4MVpTQTlJSHNnWVN3Z1lpQjlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2JXRndUMlpQWW1wbFkzUnpJRDBnUjJ4dlltRnNUV0Z3UEhOMGNtbHVaeXdnZXlCaE9pQnpkSEpwYm1jN0lHSTZJSFZwYm5RMk5DQjlQaWdwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p0WVhCUFprOWlhbVZqZEhNaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCMGFHbHpMbTFoY0U5bVQySnFaV04wY3lnbmF6RW5LUzUyWVd4MVpTQTlJSHNnWVN3Z1lpQjlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnJNU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJRzFoY0U5bVQySnFaV04wY3lBOUlFZHNiMkpoYkUxaGNEeHpkSEpwYm1jc0lIc2dZVG9nYzNSeWFXNW5PeUJpT2lCMWFXNTBOalFnZlQ0b0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QjBhR2x6TG0xaGNFOW1UMkpxWldOMGN5Z25hekVuS1M1MllXeDFaU0E5SUhzZ1lTd2dZaUI5Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QnRZWEJQWms5aWFtVmpkSE1nUFNCSGJHOWlZV3hOWVhBOGMzUnlhVzVuTENCN0lHRTZJSE4wY21sdVp6c2dZam9nZFdsdWREWTBJSDArS0NrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW0xaGNFOW1UMkpxWldOMGN5SUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk5qVUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbTFoY0U5bVQySnFaV04wY3lnbmF6RW5LUzUyWVd4MVpTNWhJRDA5UFNCaExDQW5iMkpxWldOMExtRWdjMmh2ZFd4a0lHMWhkR05vSnlrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1zeElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2JXRndUMlpQWW1wbFkzUnpJRDBnUjJ4dlltRnNUV0Z3UEhOMGNtbHVaeXdnZXlCaE9pQnpkSEpwYm1jN0lHSTZJSFZwYm5RMk5DQjlQaWdwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtMWhjRTltVDJKcVpXTjBjeWduYXpFbktTNTJZV3gxWlM1aElEMDlQU0JoTENBbmIySnFaV04wTG1FZ2MyaHZkV3hrSUcxaGRHTm9KeWtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5aWFtVmpkQzVoSUhOb2IzVnNaQ0J0WVhSamFBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2JXRndUMlpQWW1wbFkzUnpJRDBnUjJ4dlltRnNUV0Z3UEhOMGNtbHVaeXdnZXlCaE9pQnpkSEpwYm1jN0lHSTZJSFZwYm5RMk5DQjlQaWdwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p0WVhCUFprOWlhbVZqZEhNaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXRZWEJQWms5aWFtVmpkSE1vSjJzeEp5a3VkbUZzZFdVdVlpQTlQVDBnWWl3Z0oyOWlhbVZqZEM1aUlITm9iM1ZzWkNCdFlYUmphQ2NwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pyTVNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02TlRFS0lDQWdJQzh2SUcxaGNFOW1UMkpxWldOMGN5QTlJRWRzYjJKaGJFMWhjRHh6ZEhKcGJtY3NJSHNnWVRvZ2MzUnlhVzVuT3lCaU9pQjFhVzUwTmpRZ2ZUNG9LUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPalkyQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1dFlYQlBaazlpYW1WamRITW9KMnN4SnlrdWRtRnNkV1V1WWlBOVBUMGdZaXdnSjI5aWFtVmpkQzVpSUhOb2IzVnNaQ0J0WVhSamFDY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5aWFtVmpkQzVpSUhOb2IzVnNaQ0J0WVhSamFBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRWRzYjJKaGJFMWhjRlIxY0d4bExuUmxjM1JVZFhCc1pVMWhjQ2hoT2lCaWVYUmxjeXdnWWpvZ2RXbHVkRFkwTENCak9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk9sUmxjM1JIYkc5aVlXeE5ZWEJVZFhCc1pTNTBaWE4wVkhWd2JHVk5ZWEE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPalk1Q2lBZ0lDQXZMeUIwWlhOMFZIVndiR1ZOWVhBb1lUb2djM1J5YVc1bkxDQmlPaUIxYVc1ME5qUXNJR002SUdKdmIyeGxZVzRwSUhzS0lDQWdJSEJ5YjNSdklETWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdloyeHZZbUZzTFcxaGNDNWhiR2R2TG5Sek9qcFVaWE4wUjJ4dlltRnNUV0Z3VkhWd2JHVXVkR1Z6ZEZSMWNHeGxUV0Z3WDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTluYkc5aVlXd3RiV0Z3TG1Gc1oyOHVkSE02T2xSbGMzUkhiRzlpWVd4TllYQlVkWEJzWlM1MFpYTjBWSFZ3YkdWTllYQmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bmJHOWlZV3d0YldGd0xtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklIUm9hWE11ZEhWd2JHVk5ZWEFvVzJFc0lHSXNJR05kS1M1MllXeDFaU0E5SURrNUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vYVc1MElERXhDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z2RIVndiR1ZOWVhBZ1BTQkhiRzlpWVd4TllYQThXM04wY21sdVp5d2dkV2x1ZERZMExDQmliMjlzWldGdVhTd2dkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZeUExSUM4dklDSjBkWEJzWlUxaGNDSUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pjd0NpQWdJQ0F2THlCMGFHbHpMblIxY0d4bFRXRndLRnRoTENCaUxDQmpYU2t1ZG1Gc2RXVWdQU0E1T1FvZ0lDQWdjSFZ6YUdsdWRDQTVPUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZOekVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5SMWNHeGxUV0Z3S0Z0aExDQmlMQ0JqWFNrdWRtRnNkV1VnUFQwOUlEazVMQ0FuZEhWd2JHVWdkbUZzZFdVZ2MyaHZkV3hrSUcxaGRHTm9KeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaHBiblFnTVRFS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUIwZFhCc1pVMWhjQ0E5SUVkc2IySmhiRTFoY0R4YmMzUnlhVzVuTENCMWFXNTBOalFzSUdKdmIyeGxZVzVkTENCMWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5SMWNHeGxUV0Z3SWdvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZOekVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5SMWNHeGxUV0Z3S0Z0aExDQmlMQ0JqWFNrdWRtRnNkV1VnUFQwOUlEazVMQ0FuZEhWd2JHVWdkbUZzZFdVZ2MyaHZkV3hrSUcxaGRHTm9KeWtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElEazVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSMWNHeGxJSFpoYkhWbElITm9iM1ZzWkNCdFlYUmphQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEVkc2IySmhiRTFoY0ZSMWNHeGxMblJsYzNSUFltcGxZM1JOWVhBb1lUb2dZbmwwWlhNc0lHSTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEVkc2IySmhiRTFoY0ZSMWNHeGxMblJsYzNSUFltcGxZM1JOWVhBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WjJ4dlltRnNMVzFoY0M1aGJHZHZMblJ6T2pjMENpQWdJQ0F2THlCMFpYTjBUMkpxWldOMFRXRndLR0U2SUhOMGNtbHVaeXdnWWpvZ2RXbHVkRFkwS1NCN0NpQWdJQ0J3Y205MGJ5QXlJREFLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyZHNiMkpoYkMxdFlYQXVZV3huYnk1MGN6bzZWR1Z6ZEVkc2IySmhiRTFoY0ZSMWNHeGxMblJsYzNSUFltcGxZM1JOWVhCZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvNlZHVnpkRWRzYjJKaGJFMWhjRlIxY0d4bExuUmxjM1JQWW1wbFkzUk5ZWEJmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJSFJvYVhNdWIySnFaV04wVFdGd0tIc2dZU3dnWWlCOUtTNTJZV3gxWlNBOUlEazVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvMU5Bb2dJQ0FnTHk4Z2IySnFaV04wVFdGd0lEMGdSMnh2WW1Gc1RXRndQSHNnWVRvZ2MzUnlhVzVuT3lCaU9pQjFhVzUwTmpRZ2ZTd2dkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZeUEySUM4dklDSnZZbXBsWTNSTllYQWlDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJkc2IySmhiQzF0WVhBdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z2RHaHBjeTV2WW1wbFkzUk5ZWEFvZXlCaExDQmlJSDBwTG5aaGJIVmxJRDBnT1RrS0lDQWdJSEIxYzJocGJuUWdPVGtLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1dlltcGxZM1JOWVhBb2V5QmhMQ0JpSUgwcExuWmhiSFZsSUQwOVBTQTVPU3dnSjI5aWFtVmpkQ0IyWVd4MVpTQnphRzkxYkdRZ2JXRjBZMmduS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZOVFFLSUNBZ0lDOHZJRzlpYW1WamRFMWhjQ0E5SUVkc2IySmhiRTFoY0R4N0lHRTZJSE4wY21sdVp6c2dZam9nZFdsdWREWTBJSDBzSUhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpYjJKcVpXTjBUV0Z3SWdvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW5iRzlpWVd3dGJXRndMbUZzWjI4dWRITTZOellLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG05aWFtVmpkRTFoY0NoN0lHRXNJR0lnZlNrdWRtRnNkV1VnUFQwOUlEazVMQ0FuYjJKcVpXTjBJSFpoYkhWbElITm9iM1ZzWkNCdFlYUmphQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQTVPUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdlltcGxZM1FnZG1Gc2RXVWdjMmh2ZFd4a0lHMWhkR05vQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZaMnh2WW1Gc0xXMWhjQzVoYkdkdkxuUnpPanBVWlhOMFIyeHZZbUZzVFdGd1ZIVndiR1V1WDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxLQ2tnTFQ0Z2RtOXBaRG9LWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxPZ29nSUNBZ1lpQmZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWZllteHZZMnRBTUFvS1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsWDJKc2IyTnJRREE2Q2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNDQ1lIQW1zeEFBdHRZWEJQWmxSMWNHeGxjd0VBREcxaGNFOW1UMkpxWldOMGN3aDBkWEJzWlUxaGNBbHZZbXBsWTNSTllYQkNBQUJDQUFBeEd5SVRRUUJlUWdBQU1Sa2lFa1F4R0NJVFFRQk1RZ0FBTmhvQWdBVG9VWndhZ0FUVVd1QnFnQVJiNUpQL2dBU2ZBTkcrVHdTT0JBQWNBQllBRUFBS1FnQUFRZ0FBUWdBQUFJZ0FzRUwvODRnQWQwTC83WWdBVGtMLzU0Z0FGVUwvNFVMLzRURVpJaEl4R0NJU0VFU0lBaUlqUTBJQUFEWWFBVWtpV1NNTEpBaExBUlVTUkZjQ0FEWWFBa2tWSlJKRUZ6WWFBMGtWSXhKRUlsTlBBazhDVHdLSUFIc2pRMElBQURZYUFVa2lXU01MSkFoTEFSVVNSRmNDQURZYUFra1ZKUkpFRjRnQXdpTkRRZ0FBTmhvQlNTSlpJd3NrQ0VzQkZSSkVWd0lBTmhvQ1NSVWxFa1FYTmhvRFNSVWpFa1FpVTA4Q1R3SlBBb2dBNXlORFFnQUFOaG9CU1NKWkl3c2tDRXNCRlJKRVZ3SUFOaG9DU1JVbEVrUVhpQUVqSTBPS0F3QkNBQUNML1JVV1Z3WUNpLzFRZ1FzV1Z3WUNLVThCVUl2K0ZsQXJJb3YvVkZCUEFWQXFLRkJQQVdjcUtGQWlUd0ZsUkVraVdVNEJTUlZPQVU4Q1R3SlNWd0lBaS8wU1JDb29VQ0pQQVdWRUpDVllGNHYrRWtRcUtGQWlUd0ZsUklGUVU0di9Fa1NKaWdJQVFnQUFpLzRWRmxjR0FvditVSUVLRmxjR0FpbFBBVkNML3haUVR3RlFKd1FvVUU4Qlp5Y0VLRkFpVHdGbFJFa2lXVTRCU1JWT0FVOENUd0pTVndJQWkvNFNSQ2NFS0ZBaVR3RmxSQ1FsV0JlTC94SkVpWW9EQUVJQUFJdjlGUlpYQmdLTC9WQ0JDeFpYQmdJcFR3RlFpLzRXVUNzaWkvOVVVRThCVUNjRlR3RlFnV05uaS8wVkZsY0dBb3Y5VUlFTEZsY0dBaWxQQVZDTC9oWlFLeUtMLzFSUVR3RlFKd1ZQQVZBaVR3RmxSSUZqRWtTSmlnSUFRZ0FBaS80VkZsY0dBb3YrVUlFS0ZsY0dBaWxQQVZDTC94WlFUd0ZRSndaUEFWQ0JZMmVML2hVV1Z3WUNpLzVRZ1FvV1Z3WUNLVThCVUl2L0ZsQlBBVkFuQms4QlVDSlBBV1ZFZ1dNU1JJbENBQUNKIiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
