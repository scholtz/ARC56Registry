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

namespace Arc56.Generated.algorandfoundation.puya_ts.LargeObjectsInStateAlgo_072fb3b6
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTGFyZ2VPYmplY3RzSW5TdGF0ZUFsZ28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ291bnRzIjpbeyJuYW1lIjoieCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ5IiwidHlwZSI6InVpbnQ4In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldE1iciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5jcmVhc2VYQ291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InhDb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDb3VudHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50OCkiLCJzdHJ1Y3QiOiJDb3VudHMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI0OV0sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzMsMjk1LDMxM10sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxODQsMTkzLDIxMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2OF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURrZ09DQXlPVGd5T1RBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySUNKNElpQXdlREUxTVdZM1l6YzFDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFERUtDbTFoYVc1ZllteHZZMnRBTVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzWVhKblpTMXZZbXBsWTNSekxXbHVMWE4wWVhSbExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklHTnNZWE56SUV4aGNtZGxUMkpxWldOMGMwbHVVM1JoZEdWQmJHZHZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVEVLSUNBZ0lHSWdiV0ZwYmw5aFltbGZjbTkxZEdsdVowQXlDZ3B0WVdsdVgyRmlhVjl5YjNWMGFXNW5RREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiR0Z5WjJVdGIySnFaV04wY3kxcGJpMXpkR0YwWlM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCamJHRnpjeUJNWVhKblpVOWlhbVZqZEhOSmJsTjBZWFJsUVd4bmJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5Qk9iMDl3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRRGtLSUNBZ0lHSWdiV0ZwYmw5allXeHNYMDV2VDNCQU13b0tiV0ZwYmw5allXeHNYMDV2VDNCQU16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c1lYSm5aUzF2WW1wbFkzUnpMV2x1TFhOMFlYUmxMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJR05zWVhOeklFeGhjbWRsVDJKcVpXTjBjMGx1VTNSaGRHVkJiR2R2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T1dKbFptWXpObUVnTHk4Z2JXVjBhRzlrSUNKblpYUk5ZbklvS1hWcGJuUTJOQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0UwWlRoa01UWTBJQzh2SUcxbGRHaHZaQ0FpWW05dmRITjBjbUZ3S0hCaGVTbDJiMmxrSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRrMk1ERTNOMk1nTHk4Z2JXVjBhRzlrSUNKcGJtTnlaV0Z6WlZoRGIzVnVkQ2gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5TldZek1qTmtNQ0F2THlCdFpYUm9iMlFnSW1kbGRFTnZkVzUwY3loMWFXNTBOalFwS0hWcGJuUTJOQ3gxYVc1ME9Da2lDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJRzFoZEdOb0lHMWhhVzVmWjJWMFRXSnlYM0p2ZFhSbFFEUWdiV0ZwYmw5aWIyOTBjM1J5WVhCZmNtOTFkR1ZBTlNCdFlXbHVYMmx1WTNKbFlYTmxXRU52ZFc1MFgzSnZkWFJsUURZZ2JXRnBibDluWlhSRGIzVnVkSE5mY205MWRHVkFOd29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBT0FvS2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRGc2Q2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXdPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c1lYSm5aUzF2WW1wbFkzUnpMV2x1TFhOMFlYUmxMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJR05zWVhOeklFeGhjbWRsVDJKcVpXTjBjMGx1VTNSaGRHVkJiR2R2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdaWEp5Q2dwdFlXbHVYMmRsZEVOdmRXNTBjMTl5YjNWMFpVQTNPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeGhjbWRsTFc5aWFtVmpkSE10YVc0dGMzUmhkR1V1WVd4bmJ5NTBjem96TXdvZ0lDQWdMeThnWjJWMFEyOTFiblJ6S0dsdVpHVjRPaUIxYVc1ME5qUXBJSHNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBRMjkxYm5SekNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTRDZ3B0WVdsdVgybHVZM0psWVhObFdFTnZkVzUwWDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiR0Z5WjJVdGIySnFaV04wY3kxcGJpMXpkR0YwWlM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCcGJtTnlaV0Z6WlZoRGIzVnVkQ2hwYm1SbGVEb2dkV2x1ZERZMExDQjRRMjkxYm5RNklIVnBiblEyTkNrZ2V3b2dJQ0FnWTJGc2JITjFZaUJwYm1OeVpXRnpaVmhEYjNWdWRBb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFPQW9LYldGcGJsOWliMjkwYzNSeVlYQmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c1lYSm5aUzF2WW1wbFkzUnpMV2x1TFhOMFlYUmxMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJR0p2YjNSemRISmhjQ2h3WVhrNklHZDBlRzR1VUdGNWJXVnVkRlI0YmlrZ2V3b2dJQ0FnWTJGc2JITjFZaUJpYjI5MGMzUnlZWEFLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURnS0NtMWhhVzVmWjJWMFRXSnlYM0p2ZFhSbFFEUTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHRnlaMlV0YjJKcVpXTjBjeTFwYmkxemRHRjBaUzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJuWlhSTlluSW9LVG9nZFdsdWREWTBJSHNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBUV0p5Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBNENncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEazZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNQW9LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1URTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHRnlaMlV0YjJKcVpXTjBjeTFwYmkxemRHRjBaUzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJqYkdGemN5Qk1ZWEpuWlU5aWFtVmpkSE5KYmxOMFlYUmxRV3huYnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlCT2IwOXdDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBOVBRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWTJGc2JITjFZaUJmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qcE1ZWEpuWlU5aWFtVmpkSE5KYmxOMFlYUmxRV3huYnk1blpYUk5ZbkpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUk5Zbkk2Q2lBZ0lDQmlJR2RsZEUxaWNsOWliRzlqYTBBd0NncG5aWFJOWW5KZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzWVhKblpTMXZZbXBsWTNSekxXbHVMWE4wWVhSbExtRnNaMjh1ZEhNNk1UY0tJQ0FnSUM4dklHZGxkRTFpY2lncE9pQjFhVzUwTmpRZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiR0Z5WjJVdGIySnFaV04wY3kxcGJpMXpkR0YwWlM1aGJHZHZMblJ6T2pwTVlYSm5aVTlpYW1WamRITkpibE4wWVhSbFFXeG5ieTVuWlhSTlluSUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02T2t4aGNtZGxUMkpxWldOMGMwbHVVM1JoZEdWQmJHZHZMbUp2YjNSemRISmhjRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21KdmIzUnpkSEpoY0RvS0lDQWdJR0lnWW05dmRITjBjbUZ3WDJKc2IyTnJRREFLQ21KdmIzUnpkSEpoY0Y5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnhoY21kbExXOWlhbVZqZEhNdGFXNHRjM1JoZEdVdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z1ltOXZkSE4wY21Gd0tIQmhlVG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLU0I3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMnhoY21kbExXOWlhbVZqZEhNdGFXNHRjM1JoZEdVdVlXeG5ieTUwY3pvNlRHRnlaMlZQWW1wbFkzUnpTVzVUZEdGMFpVRnNaMjh1WW05dmRITjBjbUZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeGhjbWRsTFc5aWFtVmpkSE10YVc0dGMzUmhkR1V1WVd4bmJ5NTBjem82VEdGeVoyVlBZbXBsWTNSelNXNVRkR0YwWlVGc1oyOHVhVzVqY21WaGMyVllRMjkxYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBibU55WldGelpWaERiM1Z1ZERvS0lDQWdJR0lnYVc1amNtVmhjMlZZUTI5MWJuUmZZbXh2WTJ0QU1Bb0thVzVqY21WaGMyVllRMjkxYm5SZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzWVhKblpTMXZZbXBsWTNSekxXbHVMWE4wWVhSbExtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklHbHVZM0psWVhObFdFTnZkVzUwS0dsdVpHVjRPaUIxYVc1ME5qUXNJSGhEYjNWdWREb2dkV2x1ZERZMEtTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02T2t4aGNtZGxUMkpxWldOMGMwbHVVM1JoZEdWQmJHZHZMbWx1WTNKbFlYTmxXRU52ZFc1MENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnhoY21kbExXOWlhbVZqZEhNdGFXNHRjM1JoZEdVdVlXeG5ieTUwY3pvNlRHRnlaMlZQWW1wbFkzUnpTVzVUZEdGMFpVRnNaMjh1WjJWMFEyOTFiblJ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBRMjkxYm5Sek9nb2dJQ0FnWWlCblpYUkRiM1Z1ZEhOZllteHZZMnRBTUFvS1oyVjBRMjkxYm5SelgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5Qm5aWFJEYjNWdWRITW9hVzVrWlhnNklIVnBiblEyTkNrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qcE1ZWEpuWlU5aWFtVmpkSE5KYmxOMFlYUmxRV3huYnk1blpYUkRiM1Z1ZEhNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c1lYSm5aUzF2WW1wbFkzUnpMV2x1TFhOMFlYUmxMbUZzWjI4dWRITTZPa3hoY21kbFQySnFaV04wYzBsdVUzUmhkR1ZCYkdkdkxtZGxkRTFpY2lncElDMCtJSFZwYm5RMk5Eb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeGhjbWRsTFc5aWFtVmpkSE10YVc0dGMzUmhkR1V1WVd4bmJ5NTBjem82VEdGeVoyVlBZbXBsWTNSelNXNVRkR0YwWlVGc1oyOHVaMlYwVFdKeU9nb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qcE1ZWEpuWlU5aWFtVmpkSE5KYmxOMFlYUmxRV3huYnk1blpYUk5ZbkpmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMnhoY21kbExXOWlhbVZqZEhNdGFXNHRjM1JoZEdVdVlXeG5ieTUwY3pvNlRHRnlaMlZQWW1wbFkzUnpTVzVUZEdGMFpVRnNaMjh1WjJWMFRXSnlYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHRnlaMlV0YjJKcVpXTjBjeTFwYmkxemRHRjBaUzVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdRazlZWDAxQ1VpQXJJRUZEUTA5VlRsUmZRa0ZUUlY5TlFsSUtJQ0FnSUdsdWRHTWdOQ0F2THlBeU9UZ3lPVEF3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiR0Z5WjJVdGIySnFaV04wY3kxcGJpMXpkR0YwWlM1aGJHZHZMblJ6T2pwTVlYSm5aVTlpYW1WamRITkpibE4wWVhSbFFXeG5ieTVpYjI5MGMzUnlZWEFvY0dGNU9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5c1lYSm5aUzF2WW1wbFkzUnpMV2x1TFhOMFlYUmxMbUZzWjI4dWRITTZPa3hoY21kbFQySnFaV04wYzBsdVUzUmhkR1ZCYkdkdkxtSnZiM1J6ZEhKaGNEb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c1lYSm5aUzF2WW1wbFkzUnpMV2x1TFhOMFlYUmxMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJR0p2YjNSemRISmhjQ2h3WVhrNklHZDBlRzR1VUdGNWJXVnVkRlI0YmlrZ2V3b2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02T2t4aGNtZGxUMkpxWldOMGMwbHVVM1JoZEdWQmJHZHZMbUp2YjNSemRISmhjRjlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiR0Z5WjJVdGIySnFaV04wY3kxcGJpMXpkR0YwWlM1aGJHZHZMblJ6T2pwTVlYSm5aVTlpYW1WamRITkpibE4wWVhSbFFXeG5ieTVpYjI5MGMzUnlZWEJmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02TWpJdE1qVUtJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LSEJoZVN3Z2V3b2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklFSlBXRjlOUWxJZ0t5QkJRME5QVlU1VVgwSkJVMFZmVFVKU0xBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzWVhKblpTMXZZbXBsWTNSekxXbHVMWE4wWVhSbExtRnNaMjh1ZEhNNk1qTUtJQ0FnSUM4dklHRnRiM1Z1ZERvZ1FrOVlYMDFDVWlBcklFRkRRMDlWVGxSZlFrRlRSVjlOUWxJc0NpQWdJQ0JwYm5SaklEUWdMeThnTWprNE1qa3dNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeGhjbWRsTFc5aWFtVmpkSE10YVc0dGMzUmhkR1V1WVd4bmJ5NTBjem95TWkweU5Rb2dJQ0FnTHk4Z1lYTnpaWEowVFdGMFkyZ29jR0Y1TENCN0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ1FrOVlYMDFDVWlBcklFRkRRMDlWVGxSZlFrRlRSVjlOUWxJc0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUgwcENpQWdJQ0E5UFFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnhoY21kbExXOWlhbVZqZEhNdGFXNHRjM1JoZEdVdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzWVhKblpTMXZZbXBsWTNSekxXbHVMWE4wWVhSbExtRnNaMjh1ZEhNNk1qSXRNalVLSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0hCaGVTd2dld29nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJRUpQV0Y5TlFsSWdLeUJCUTBOUFZVNVVYMEpCVTBWZlRVSlNMQW9nSUNBZ0x5OGdJQ0J5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QjlLUW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYSjBJSFJoY21kbGRDQnBjeUJ0WVhSamFDQm1iM0lnWTI5dVpHbDBhVzl1Y3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnhoY21kbExXOWlhbVZqZEhNdGFXNHRjM1JoZEdVdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z2MzUnZjbUZuWlNBOUlFSnZlRHhHYVhobFpFRnljbUY1UEVOdmRXNTBjeXdnZEhsd1pXOW1JRTFCV0Y5SlZFVk5VejQrS0hzZ2EyVjVPaUFuZUNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luZ2lDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHRnlaMlV0YjJKcVpXTjBjeTFwYmkxemRHRjBaUzVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUIwYUdsekxuTjBiM0poWjJVdVkzSmxZWFJsS0NrS0lDQWdJSEIxYzJocGJuUWdOekl3TUFvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ2NHOXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHRnlaMlV0YjJKcVpXTjBjeTFwYmkxemRHRjBaUzVoYkdkdkxuUnpPanBNWVhKblpVOWlhbVZqZEhOSmJsTjBZWFJsUVd4bmJ5NXBibU55WldGelpWaERiM1Z1ZENocGJtUmxlRG9nZFdsdWREWTBMQ0I0UTI5MWJuUTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeGhjbWRsTFc5aWFtVmpkSE10YVc0dGMzUmhkR1V1WVd4bmJ5NTBjem82VEdGeVoyVlBZbXBsWTNSelNXNVRkR0YwWlVGc1oyOHVhVzVqY21WaGMyVllRMjkxYm5RNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QnBibU55WldGelpWaERiM1Z1ZENocGJtUmxlRG9nZFdsdWREWTBMQ0I0UTI5MWJuUTZJSFZwYm5RMk5Da2dld29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzWVhKblpTMXZZbXBsWTNSekxXbHVMWE4wWVhSbExtRnNaMjh1ZEhNNk9reGhjbWRsVDJKcVpXTjBjMGx1VTNSaGRHVkJiR2R2TG1sdVkzSmxZWE5sV0VOdmRXNTBYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02T2t4aGNtZGxUMkpxWldOMGMwbHVVM1JoZEdWQmJHZHZMbWx1WTNKbFlYTmxXRU52ZFc1MFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QjBhR2x6TG5OMGIzSmhaMlV1ZG1Gc2RXVmJhVzVrWlhoZExuZ2dLejBnZUVOdmRXNTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNaUF2THlBNUNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0t3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4aGNtZGxMVzlpYW1WamRITXRhVzR0YzNSaGRHVXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdjM1J2Y21GblpTQTlJRUp2ZUR4R2FYaGxaRUZ5Y21GNVBFTnZkVzUwY3l3Z2RIbHdaVzltSUUxQldGOUpWRVZOVXo0K0tIc2dhMlY1T2lBbmVDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbmdpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiR0Z5WjJVdGIySnFaV04wY3kxcGJpMXpkR0YwWlM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCMGFHbHpMbk4wYjNKaFoyVXVkbUZzZFdWYmFXNWtaWGhkTG5nZ0t6MGdlRU52ZFc1MENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHbHVkR05mTWlBdkx5QTVDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsdWRHTmZNaUF2THlBNUNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0t3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ3NLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUhOMGIzSmhaMlVnUFNCQ2IzZzhSbWw0WldSQmNuSmhlVHhEYjNWdWRITXNJSFI1Y0dWdlppQk5RVmhmU1ZSRlRWTStQaWg3SUd0bGVUb2dKM2duSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKNElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4aGNtZGxMVzlpYW1WamRITXRhVzR0YzNSaGRHVXVZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdkR2hwY3k1emRHOXlZV2RsTG5aaGJIVmxXMmx1WkdWNFhTNTRJQ3M5SUhoRGIzVnVkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjl5WlhCc1lXTmxJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qcE1ZWEpuWlU5aWFtVmpkSE5KYmxOMFlYUmxRV3huYnk1blpYUkRiM1Z1ZEhNb2FXNWtaWGc2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzWVhKblpTMXZZbXBsWTNSekxXbHVMWE4wWVhSbExtRnNaMjh1ZEhNNk9reGhjbWRsVDJKcVpXTjBjMGx1VTNSaGRHVkJiR2R2TG1kbGRFTnZkVzUwY3pvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzWVhKblpTMXZZbXBsWTNSekxXbHVMWE4wWVhSbExtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklHZGxkRU52ZFc1MGN5aHBibVJsZURvZ2RXbHVkRFkwS1NCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeGhjbWRsTFc5aWFtVmpkSE10YVc0dGMzUmhkR1V1WVd4bmJ5NTBjem82VEdGeVoyVlBZbXBsWTNSelNXNVRkR0YwWlVGc1oyOHVaMlYwUTI5MWJuUnpYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02T2t4aGNtZGxUMkpxWldOMGMwbHVVM1JoZEdWQmJHZHZMbWRsZEVOdmRXNTBjMTlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeGhjbWRsTFc5aWFtVmpkSE10YVc0dGMzUmhkR1V1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdWMzUnZjbUZuWlM1MllXeDFaVnRwYm1SbGVGMEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHlJQzh2SURrS0lDQWdJQ29LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBckNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QnpkRzl5WVdkbElEMGdRbTk0UEVacGVHVmtRWEp5WVhrOFEyOTFiblJ6TENCMGVYQmxiMllnVFVGWVgwbFVSVTFUUGo0b2V5QnJaWGs2SUNkNEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWllQ0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuTjBiM0poWjJVdWRtRnNkV1ZiYVc1a1pYaGRDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR2x1ZEdOZk1pQXZMeUE1Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4aGNtZGxMVzlpYW1WamRITXRhVzR0YzNSaGRHVXVZV3huYnk1MGN6bzZUR0Z5WjJWUFltcGxZM1J6U1c1VGRHRjBaVUZzWjI4dVgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsS0NrZ0xUNGdkbTlwWkRvS1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsT2dvZ0lDQWdZaUJmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVmZZbXh2WTJ0QU1Bb0tYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFgySnNiMk5yUURBNkNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZBQUVKQ1BTSHRnRW1BZ0Y0QkJVZmZIVkNBQUJDQUFBeEd5SVRRUUJlUWdBQU1Sa2lFa1F4R0NJVFFRQk1RZ0FBTmhvQWdBU2I3L05xZ0FTazZORmtnQVFaWUJkOGdBUWw4eVBRVHdTT0JBQWNBQllBRUFBS1FnQUFRZ0FBUWdBQUFJZ0FZVUwvODRnQVFVTC83WWdBS1VMLzU0Z0FGVUwvNFVMLzRURVpJaEl4R0NJU0VFU0lBSzhqUTBJQUFJZ0FTaFlwVHdGUXNDTkRRZ0FBTVJZakNVazRFQ01TUklnQU9DTkRRZ0FBTmhvQlNSVWxFa1FYTmhvQ1NSVWxFa1FYaUFBN0kwTkNBQUEyR2dGSkZTVVNSQmVJQUZJcFR3RlFzQ05EUWdBQUlRU0ppZ0VBUWdBQWkvODRDQ0VFRW92L09BY3lDaElRUkNpQm9EaTVTSW1LQWdCQ0FBQ0wvaVFMSWdnb1R3RWt1aUlsV0JlTC93Z1dpLzRrQ3lJSUlnZ29Ud0ZQQXJ1SmlnRUJRZ0FBaS84a0N5SUlLRThCSkxxSlFnQUFpUT09IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
