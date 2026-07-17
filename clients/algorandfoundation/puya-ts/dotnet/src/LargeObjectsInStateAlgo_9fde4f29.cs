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

namespace Arc56.Generated.algorandfoundation.puya_ts.LargeObjectsInStateAlgo_9fde4f29
{


    public class LargeObjectsInStateAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LargeObjectsInStateAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Counts : AVMObjectType
            {
                public ulong X { get; set; }

                public byte Y { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vX.From(X);
                    ret.AddRange(vX.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
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

                public static Counts Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Counts();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vX.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueX = vX.ToValue();
                    if (valueX is ulong vXValue) { ret.X = vXValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vY = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vY.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueY = vY.ToValue();
                    if (valueY is byte vYValue) { ret.Y = vYValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Counts);
                }
                public bool Equals(Counts? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Counts left, Counts right)
                {
                    return EqualityComparer<Counts>.Default.Equals(left, right);
                }
                public static bool operator !=(Counts left, Counts right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetMbr(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 239, 243, 106 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMbr_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 239, 243, 106 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay"> </param>
        public async Task Bootstrap(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 164, 232, 209, 100 };

            var result = await base.CallApp(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 164, 232, 209, 100 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        /// <param name="xCount"> </param>
        public async Task IncreaseXCount(ulong index, ulong xCount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 96, 23, 124 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var xCountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xCountAbi.From(xCount);

            var result = await base.CallApp(new List<object> { abiHandle, indexAbi, xCountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IncreaseXCount_Transactions(ulong index, ulong xCount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 96, 23, 124 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var xCountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xCountAbi.From(xCount);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi, xCountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        public async Task<Structs.Counts> GetCounts(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 243, 35, 208 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            var result = await base.CallApp(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Counts.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetCounts_Transactions(ulong index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 243, 35, 208 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTGFyZ2VPYmplY3RzSW5TdGF0ZUFsZ28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ291bnRzIjpbeyJuYW1lIjoieCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ5IiwidHlwZSI6InVpbnQ4In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldE1iciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5jcmVhc2VYQ291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InhDb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDb3VudHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50OCkiLCJzdHJ1Y3QiOiJDb3VudHMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE0OV0sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MiwxMDksMTIwXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1LDkxLDEwMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMl0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0E1SURnS0lDQWdJR0o1ZEdWallteHZZMnNnSW5naUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5QmpiR0Z6Y3lCTVlYSm5aVTlpYW1WamRITkpibE4wWVhSbFFXeG5ieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE1Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9XSmxabVl6Tm1FZ01IaGhOR1U0WkRFMk5DQXdlREU1TmpBeE56ZGpJREI0TWpWbU16SXpaREFnTHk4Z2JXVjBhRzlrSUNKblpYUk5ZbklvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWW05dmRITjBjbUZ3S0hCaGVTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKcGJtTnlaV0Z6WlZoRGIzVnVkQ2gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRFTnZkVzUwY3loMWFXNTBOalFwS0hWcGJuUTJOQ3gxYVc1ME9Da2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyZGxkRTFpY2w5eWIzVjBaVUEwSUcxaGFXNWZZbTl2ZEhOMGNtRndYM0p2ZFhSbFFEVWdiV0ZwYmw5cGJtTnlaV0Z6WlZoRGIzVnVkRjl5YjNWMFpVQTJJRzFoYVc1ZloyVjBRMjkxYm5SelgzSnZkWFJsUURjS0lDQWdJR1Z5Y2dvS2JXRnBibDluWlhSRGIzVnVkSE5mY205MWRHVkFOem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUdkbGRFTnZkVzUwY3locGJtUmxlRG9nZFdsdWREWTBLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QnlaWFIxY200Z2RHaHBjeTV6ZEc5eVlXZGxMblpoYkhWbFcybHVaR1Y0WFFvZ0lDQWdhVzUwWTE4eElDOHZJRGtLSUNBZ0lDb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c1lYSm5aUzF2WW1wbFkzUnpMV2x1TFhOMFlYUmxMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJSE4wYjNKaFoyVWdQU0JDYjNnOFJtbDRaV1JCY25KaGVUeERiM1Z1ZEhNc0lIUjVjR1Z2WmlCTlFWaGZTVlJGVFZNK1BpaDdJR3RsZVRvZ0ozZ25JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0o0SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnhoY21kbExXOWlhbVZqZEhNdGFXNHRjM1JoZEdVdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVjM1J2Y21GblpTNTJZV3gxWlZ0cGJtUmxlRjBLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QTVDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnhoY21kbExXOWlhbVZqZEhNdGFXNHRjM1JoZEdVdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z1oyVjBRMjkxYm5SektHbHVaR1Y0T2lCMWFXNTBOalFwSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlwYm1OeVpXRnpaVmhEYjNWdWRGOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4aGNtZGxMVzlpYW1WamRITXRhVzR0YzNSaGRHVXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdhVzVqY21WaGMyVllRMjkxYm5Rb2FXNWtaWGc2SUhWcGJuUTJOQ3dnZUVOdmRXNTBPaUIxYVc1ME5qUXBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c1lYSm5aUzF2WW1wbFkzUnpMV2x1TFhOMFlYUmxMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJSFJvYVhNdWMzUnZjbUZuWlM1MllXeDFaVnRwYm1SbGVGMHVlQ0FyUFNCNFEyOTFiblFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QTVDaUFnSUNBcUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QnpkRzl5WVdkbElEMGdRbTk0UEVacGVHVmtRWEp5WVhrOFEyOTFiblJ6TENCMGVYQmxiMllnVFVGWVgwbFVSVTFUUGo0b2V5QnJaWGs2SUNkNEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWllQ0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUhSb2FYTXVjM1J2Y21GblpTNTJZV3gxWlZ0cGJtUmxlRjB1ZUNBclBTQjRRMjkxYm5RS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnT1FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUhCMWMyaHBiblFnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4aGNtZGxMVzlpYW1WamRITXRhVzR0YzNSaGRHVXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdjM1J2Y21GblpTQTlJRUp2ZUR4R2FYaGxaRUZ5Y21GNVBFTnZkVzUwY3l3Z2RIbHdaVzltSUUxQldGOUpWRVZOVXo0K0tIc2dhMlY1T2lBbmVDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbmdpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiR0Z5WjJVdGIySnFaV04wY3kxcGJpMXpkR0YwWlM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCMGFHbHpMbk4wYjNKaFoyVXVkbUZzZFdWYmFXNWtaWGhkTG5nZ0t6MGdlRU52ZFc1MENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpTQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnhoY21kbExXOWlhbVZqZEhNdGFXNHRjM1JoZEdVdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2FXNWpjbVZoYzJWWVEyOTFiblFvYVc1a1pYZzZJSFZwYm5RMk5Dd2dlRU52ZFc1ME9pQjFhVzUwTmpRcElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltOXZkSE4wY21Gd1gzSnZkWFJsUURVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5QmliMjkwYzNSeVlYQW9jR0Y1T2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRwSUhzS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeGhjbWRsTFc5aWFtVmpkSE10YVc0dGMzUmhkR1V1WVd4bmJ5NTBjem95TWkweU5Rb2dJQ0FnTHk4Z1lYTnpaWEowVFdGMFkyZ29jR0Y1TENCN0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ1FrOVlYMDFDVWlBcklFRkRRMDlWVGxSZlFrRlRSVjlOUWxJc0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUgwcENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnhoY21kbExXOWlhbVZqZEhNdGFXNHRjM1JoZEdVdVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z1lXMXZkVzUwT2lCQ1QxaGZUVUpTSUNzZ1FVTkRUMVZPVkY5Q1FWTkZYMDFDVWl3S0lDQWdJSEIxYzJocGJuUWdNams0TWprd01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4aGNtZGxMVzlpYW1WamRITXRhVzR0YzNSaGRHVXVZV3huYnk1MGN6b3lNaTB5TlFvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb2NHRjVMQ0I3Q2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nUWs5WVgwMUNVaUFySUVGRFEwOVZUbFJmUWtGVFJWOU5RbElzQ2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJSDBwQ2lBZ0lDQTlQUW9nSUNBZ2MzZGhjQW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiR0Z5WjJVdGIySnFaV04wY3kxcGJpMXpkR0YwWlM1aGJHZHZMblJ6T2pJeUxUSTFDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2h3WVhrc0lIc0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQkNUMWhmVFVKU0lDc2dRVU5EVDFWT1ZGOUNRVk5GWDAxQ1Vpd0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWeWRDQjBZWEpuWlhRZ2FYTWdiV0YwWTJnZ1ptOXlJR052Ym1ScGRHbHZibk1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUhOMGIzSmhaMlVnUFNCQ2IzZzhSbWw0WldSQmNuSmhlVHhEYjNWdWRITXNJSFI1Y0dWdlppQk5RVmhmU1ZSRlRWTStQaWg3SUd0bGVUb2dKM2duSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKNElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4aGNtZGxMVzlpYW1WamRITXRhVzR0YzNSaGRHVXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdkR2hwY3k1emRHOXlZV2RsTG1OeVpXRjBaU2dwQ2lBZ0lDQndkWE5vYVc1MElEY3lNREFLSUNBZ0lHSnZlRjlqY21WaGRHVUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4aGNtZGxMVzlpYW1WamRITXRhVzR0YzNSaGRHVXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdZbTl2ZEhOMGNtRndLSEJoZVRvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1S1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRFMWljbDl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeGhjbWRsTFc5aWFtVmpkSE10YVc0dGMzUmhkR1V1WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnWjJWMFRXSnlLQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF5WkRnelpqUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5QmpiR0Z6Y3lCTVlYSm5aVTlpYW1WamRITkpibE4wWVhSbFFXeG5ieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBUWtJSmdFQmVERWJRUUNnTVJrVVJERVlSSUlFQkp2djgyb0VwT2pSWkFRWllCZDhCQ1h6STlBMkdnQ09CQUJsQUVJQUd3QUJBRFlhQVVrVkpCSkVGeU1MS0V3anVvQUVGUjk4ZFV4UXNDSkROaG9CU1JVa0VrUVhOaG9DU1JVa0VrUVhUQ01MS0VzQkk3cUJBRnRQQWdnV0tFNEN1eUpETVJZaUNVazRFQ0lTUkVrNENJSDBoN1lCRWt3NEJ6SUtFaEJFS0lHZ09MbElJa09BREJVZmZIVUFBQUFBQUMyRDlMQWlRekVaRkRFWUZCQkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
