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

namespace Arc56.Generated.algorandfoundation.puya.NestedTuplesStorage_36351fc1
{


    public class NestedTuplesStorageProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NestedTuplesStorageProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class TupleWithMutable : AVMObjectType
            {
                public ulong[] Arr { get; set; }

                public ulong Bar { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vArr.From(Arr);
                    ret.AddRange(vArr.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static TupleWithMutable Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TupleWithMutable();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vArr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr = vArr.ToValue();
                    if (valueArr is ulong[] vArrValue) { ret.Arr = vArrValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBar.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBar = vBar.ToValue();
                    if (valueBar is ulong vBarValue) { ret.Bar = vBarValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TupleWithMutable);
                }
                public bool Equals(TupleWithMutable? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TupleWithMutable left, TupleWithMutable right)
                {
                    return EqualityComparer<TupleWithMutable>.Default.Equals(left, right);
                }
                public static bool operator !=(TupleWithMutable left, TupleWithMutable right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Bootstrap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 199, 109, 135 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 199, 109, 135 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="val"> </param>
        public async Task MutateTuple(ulong val, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 194, 83, 174 };
            var valAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valAbi.From(val);

            var result = await base.CallApp(new List<object> { abiHandle, valAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MutateTuple_Transactions(ulong val, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 194, 83, 174 };
            var valAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valAbi.From(val);

            return await base.MakeTransactionList(new List<object> { abiHandle, valAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="val"> </param>
        public async Task MutateBox(ulong val, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 68, 148, 12 };
            var valAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valAbi.From(val);

            var result = await base.CallApp(new List<object> { abiHandle, valAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MutateBox_Transactions(ulong val, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 68, 148, 12 };
            var valAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valAbi.From(val);

            return await base.MakeTransactionList(new List<object> { abiHandle, valAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="val"> </param>
        public async Task MutateGlobal(ulong val, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 34, 239, 26 };
            var valAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valAbi.From(val);

            var result = await base.CallApp(new List<object> { abiHandle, valAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MutateGlobal_Transactions(ulong val, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 98, 34, 239, 26 };
            var valAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valAbi.From(val);

            return await base.MakeTransactionList(new List<object> { abiHandle, valAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="val"> </param>
        public async Task MutateLocal(ulong val, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 38, 155, 80 };
            var valAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valAbi.From(val);

            var result = await base.CallApp(new List<object> { abiHandle, valAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MutateLocal_Transactions(ulong val, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 38, 155, 80 };
            var valAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valAbi.From(val);

            return await base.MakeTransactionList(new List<object> { abiHandle, valAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTmVzdGVkVHVwbGVzU3RvcmFnZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJUdXBsZVdpdGhNdXRhYmxlIjpbeyJuYW1lIjoiYXJyIiwidHlwZSI6InVpbnQ2NFtdIn0seyJuYW1lIjoiYmFyIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJib290c3RyYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJPcHRJbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im11dGF0ZV90dXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibXV0YXRlX2JveCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibXV0YXRlX2dsb2JhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibXV0YXRlX2xvY2FsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MX19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI2NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYm94IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZ2xvYiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxvYyBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NiwxNzIsMjA5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50dXAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA1LDI2MSwzMTksMzc1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQW9nSUNBZ1lubDBaV05pYkc5amF5QWlkSFZ3SWlBd2VEQXdNR0VnSW1KdmVDSWdJbWRzYjJJaUlDSnNiMk1pSURCNE1EQXdZVEF3TURBd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNQ0F3ZURBd01ERXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwzUjFjR3hsWDNOMGIzSmhaMlV1Y0hrNk1UWUtJQ0FnSUM4dklITmxiR1l1ZEhWd0lEMGdWSFZ3YkdWWGFYUm9UWFYwWVdKc1pTZ0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUjFjQ0lLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TURCaE1EQXdNREF3TURBd01EQXdNREF3TURBd01ERXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMM1IxY0d4bFgzTjBiM0poWjJVdWNIazZNVFl0TVRrS0lDQWdJQzh2SUhObGJHWXVkSFZ3SUQwZ1ZIVndiR1ZYYVhSb1RYVjBZV0pzWlNnS0lDQWdJQzh2SUNBZ0lDQmhjbkk5WVhKak5DNUVlVzVoYldsalFYSnlZWGtvWVhKak5DNVZTVzUwTmpRb01Da3BMQW9nSUNBZ0x5OGdJQ0FnSUdKaGNqMVZTVzUwTmpRb0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDNSMWNHeGxYM04wYjNKaFoyVXVjSGs2TWpBS0lDQWdJQzh2SUhObGJHWXVaMnh2WWk1MllXeDFaU0E5SUhObGJHWXVkSFZ3TGw5eVpYQnNZV05sS0dGeWNqMWhjbU0wTGtSNWJtRnRhV05CY25KaGVTaGhjbU0wTGxWSmJuUTJOQ2d3S1NrcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKbmJHOWlJZ29nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF3TUdFd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMM1IxY0d4bFgzTjBiM0poWjJVdWNIazZNakVLSUNBZ0lDOHZJSE5sYkdZdWRIVndJRDBnYzJWc1ppNTBkWEF1WDNKbGNHeGhZMlVvWVhKeVBXRnlZelF1UkhsdVlXMXBZMEZ5Y21GNUtHRnlZelF1VlVsdWREWTBLREFwS1NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owZFhBaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkSFZ3SUdWNGFYTjBjd29nSUNBZ1pYaDBjbUZqZENBeUlEZ0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREJoQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZkSFZ3YkdWZmMzUnZjbUZuWlM1d2VUb3hOd29nSUNBZ0x5OGdZWEp5UFdGeVl6UXVSSGx1WVcxcFkwRnljbUY1S0dGeVl6UXVWVWx1ZERZMEtEQXBLU3dLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdNSGd3TURBeE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOTBkWEJzWlY5emRHOXlZV2RsTG5CNU9qSXhDaUFnSUNBdkx5QnpaV3htTG5SMWNDQTlJSE5sYkdZdWRIVndMbDl5WlhCc1lXTmxLR0Z5Y2oxaGNtTTBMa1I1Ym1GdGFXTkJjbkpoZVNoaGNtTTBMbFZKYm5RMk5DZ3dLU2twQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SMWNDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZkSFZ3YkdWZmMzUnZjbUZuWlM1d2VUb3hNUW9nSUNBZ0x5OGdZMnhoYzNNZ1RtVnpkR1ZrVkhWd2JHVnpVM1J2Y21GblpTaGhjbU0wTGtGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WW1Wak56WmtPRGNnTHk4Z2JXVjBhRzlrSUNKaWIyOTBjM1J5WVhBb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMkp2YjNSemRISmhjRjl5YjNWMFpVQTFDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5qb0tJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2ZEhWd2JHVmZjM1J2Y21GblpTNXdlVG94TVFvZ0lDQWdMeThnWTJ4aGMzTWdUbVZ6ZEdWa1ZIVndiR1Z6VTNSdmNtRm5aU2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhoWTJNeU5UTmhaU0F3ZUdVNE5EUTVOREJqSURCNE5qSXlNbVZtTVdFZ01IZ3hZakkyT1dJMU1DQXZMeUJ0WlhSb2IyUWdJbTExZEdGMFpWOTBkWEJzWlNoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWliWFYwWVhSbFgySnZlQ2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWJYVjBZWFJsWDJkc2IySmhiQ2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWJYVjBZWFJsWDJ4dlkyRnNLSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JYVjBZWFJsWDNSMWNHeGxJRzExZEdGMFpWOWliM2dnYlhWMFlYUmxYMmRzYjJKaGJDQnRkWFJoZEdWZmJHOWpZV3dLSUNBZ0lHVnljZ29LYldGcGJsOWliMjkwYzNSeVlYQmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2ZEhWd2JHVmZjM1J2Y21GblpTNXdlVG95TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SlBjSFJKYmlKZEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklFOXdkRWx1Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR0lnWW05dmRITjBjbUZ3Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTFPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMblIxY0d4bFgzTjFjSEJ2Y25RdWRIVndiR1ZmYzNSdmNtRm5aUzVPWlhOMFpXUlVkWEJzWlhOVGRHOXlZV2RsTG1KdmIzUnpkSEpoY0Z0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtSnZiM1J6ZEhKaGNEb0tJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2ZEhWd2JHVmZjM1J2Y21GblpTNXdlVG95TlFvZ0lDQWdMeThnYzJWc1ppNWliM2d1ZG1Gc2RXVWdQU0J6Wld4bUxuUjFjQzVmY21Wd2JHRmpaU2hoY25JOVlYSmpOQzVFZVc1aGJXbGpRWEp5WVhrb1lYSmpOQzVWU1c1ME5qUW9NQ2twS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblIxY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBkWEFnWlhocGMzUnpDaUFnSUNCbGVIUnlZV04wSURJZ09Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNR0VLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURBd01ERXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltSnZlQ0lLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWW05NElnb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmRIVndiR1ZmYzNSdmNtRm5aUzV3ZVRveU5nb2dJQ0FnTHk4Z2MyVnNaaTVzYjJOYlZIaHVMbk5sYm1SbGNsMGdQU0J6Wld4bUxuUjFjQzVmY21Wd2JHRmpaU2hoY25JOVlYSmpOQzVFZVc1aGJXbGpRWEp5WVhrb1lYSmpOQzVWU1c1ME5qUW9NQ2twS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTkNBdkx5QWliRzlqSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDNSMWNHeGxYM04wYjNKaFoyVXVjSGs2TWpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUM0IwU1c0aVhTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxuUjFjR3hsWDNOMWNIQnZjblF1ZEhWd2JHVmZjM1J2Y21GblpTNU9aWE4wWldSVWRYQnNaWE5UZEc5eVlXZGxMbTExZEdGMFpWOTBkWEJzWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtMTFkR0YwWlY5MGRYQnNaVG9LSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmRIVndiR1ZmYzNSdmNtRm5aUzV3ZVRveU9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2ZEhWd2JHVmZjM1J2Y21GblpTNXdlVG96TUFvZ0lDQWdMeThnYzJWc1ppNTBkWEF1WVhKeUxtRndjR1Z1WkNoMllXd3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRIVndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SMWNDQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXlJRGdLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmRIVndiR1ZmYzNSdmNtRm5aUzV3ZVRvek1Bb2dJQ0FnTHk4Z2MyVnNaaTUwZFhBdVlYSnlMbUZ3Y0dWdVpDaDJZV3dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZkSFZ3YkdWZmMzUnZjbUZuWlM1d2VUb3pNQW9nSUNBZ0x5OGdjMlZzWmk1MGRYQXVZWEp5TG1Gd2NHVnVaQ2gyWVd3cENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdZUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkSFZ3SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZkSFZ3YkdWZmMzUnZjbUZuWlM1d2VUb3lPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxuUjFjR3hsWDNOMWNIQnZjblF1ZEhWd2JHVmZjM1J2Y21GblpTNU9aWE4wWldSVWRYQnNaWE5UZEc5eVlXZGxMbTExZEdGMFpWOWliM2hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdGRYUmhkR1ZmWW05NE9nb2dJQ0FnTHk4Z2RIVndiR1ZmYzNWd2NHOXlkQzkwZFhCc1pWOXpkRzl5WVdkbExuQjVPak15Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnZEhWd2JHVmZjM1Z3Y0c5eWRDOTBkWEJzWlY5emRHOXlZV2RsTG5CNU9qTTBDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlM1aGNuSXVZWEJ3Wlc1a0tIWmhiQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUp2ZUNJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtSnZlQ0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURnS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZkSFZ3YkdWZmMzUnZjbUZuWlM1d2VUb3pOQW9nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdVdVlYSnlMbUZ3Y0dWdVpDaDJZV3dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZkSFZ3YkdWZmMzUnZjbUZuWlM1d2VUb3pOQW9nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdVdVlYSnlMbUZ3Y0dWdVpDaDJZV3dwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd1lRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVltOTRJZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ppYjNnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDNSMWNHeGxYM04wYjNKaFoyVXVjSGs2TXpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTUwZFhCc1pWOXpkWEJ3YjNKMExuUjFjR3hsWDNOMGIzSmhaMlV1VG1WemRHVmtWSFZ3YkdWelUzUnZjbUZuWlM1dGRYUmhkR1ZmWjJ4dlltRnNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYlhWMFlYUmxYMmRzYjJKaGJEb0tJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2ZEhWd2JHVmZjM1J2Y21GblpTNXdlVG96TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZkSFZ3YkdWZmMzUnZjbUZuWlM1d2VUb3pPQW9nSUNBZ0x5OGdjMlZzWmk1bmJHOWlMblpoYkhWbExtRnljaTVoY0hCbGJtUW9kbUZzS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbWRzYjJJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaMnh2WWlCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBeUlEZ0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2ZEhWd2JHVmZjM1J2Y21GblpTNXdlVG96T0FvZ0lDQWdMeThnYzJWc1ppNW5iRzlpTG5aaGJIVmxMbUZ5Y2k1aGNIQmxibVFvZG1Gc0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBkWEJzWlY5emRYQndiM0owTDNSMWNHeGxYM04wYjNKaFoyVXVjSGs2TXpnS0lDQWdJQzh2SUhObGJHWXVaMnh2WWk1MllXeDFaUzVoY25JdVlYQndaVzVrS0haaGJDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREJoQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0puYkc5aUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIUjFjR3hsWDNOMWNIQnZjblF2ZEhWd2JHVmZjM1J2Y21GblpTNXdlVG96TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMblIxY0d4bFgzTjFjSEJ2Y25RdWRIVndiR1ZmYzNSdmNtRm5aUzVPWlhOMFpXUlVkWEJzWlhOVGRHOXlZV2RsTG0xMWRHRjBaVjlzYjJOaGJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTExZEdGMFpWOXNiMk5oYkRvS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZkSFZ3YkdWZmMzUnZjbUZuWlM1d2VUbzBNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSFIxY0d4bFgzTjFjSEJ2Y25RdmRIVndiR1ZmYzNSdmNtRm5aUzV3ZVRvME1nb2dJQ0FnTHk4Z2MyVnNaaTVzYjJOYlZIaHVMbk5sYm1SbGNsMHVZWEp5TG1Gd2NHVnVaQ2gyWVd3cENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnNiMk1pQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1c2IyTWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTWlBNENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0F2THlCMGRYQnNaVjl6ZFhCd2IzSjBMM1IxY0d4bFgzTjBiM0poWjJVdWNIazZORElLSUNBZ0lDOHZJSE5sYkdZdWJHOWpXMVI0Ymk1elpXNWtaWEpkTG1GeWNpNWhjSEJsYm1Rb2RtRnNLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUIwZFhCc1pWOXpkWEJ3YjNKMEwzUjFjR3hsWDNOMGIzSmhaMlV1Y0hrNk5ESUtJQ0FnSUM4dklITmxiR1l1Ykc5alcxUjRiaTV6Wlc1a1pYSmRMbUZ5Y2k1aGNIQmxibVFvZG1Gc0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNR0VLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbXh2WXlJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhSMWNHeGxYM04xY0hCdmNuUXZkSFZ3YkdWZmMzUnZjbUZuWlM1d2VUbzBNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFFSUpnY0RkSFZ3QWdBS0EySnZlQVJuYkc5aUEyeHZZeFFBQ2dBQUFBQUFBQUFBQUFFQUFBQUFBQUFBQUFvQUFRQUFBQUFBQUFBQU1SaEFBQmdvSndWbkt5Y0ZaeUlvWlVSWEFnZ3BURkFuQmxBb1RHY3hHMEVBUTRBRXZzZHRoellhQUk0QkFDc3hHUlJFTVJoRWdnUUVyTUpUcmdUb1JKUU1CR0lpN3hvRUd5YWJVRFlhQUk0RUFERUFhUUNqQU5zQU1Sa2pFakVZRUVSQ0FBZ3hHUlF4R0JRUVF5SW9aVVJYQWdncFRGQW5CbEFxdkVncVN3Ry9NUUFuQkU4Q1ppTkROaG9CU1JVa0VrUWlLR1ZFU1NKWlN3RVZTd0pPQWxKTVZ3SUlTd0VpV1NNSUZsY0dBRThDVEZ3QVR3SlFLVThDVUV4UUtFeG5JME0yR2dGSkZTUVNSQ3ErUkVraVdVc0JGVXNDVGdKU1RGY0NDRXNCSWxrakNCWlhCZ0JQQWt4Y0FFOENVQ2xQQWxCTVVDcThTQ3BNdnlORE5ob0JTUlVrRWtRaUsyVkVTU0paU3dFVlN3Sk9BbEpNVndJSVN3RWlXU01JRmxjR0FFOENURndBVHdKUUtVOENVRXhRSzB4bkkwTTJHZ0ZKRlNRU1JERUFTU0luQkdORVNTSlpTd0VWU3dKT0FsSk1Wd0lJU3dFaVdTTUlGbGNHQUU4Q1RGd0FUd05RS1U4Q1VFeFFKd1JNWmlORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
