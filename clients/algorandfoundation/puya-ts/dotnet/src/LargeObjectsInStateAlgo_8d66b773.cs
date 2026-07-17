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

namespace Arc56.Generated.algorandfoundation.puya_ts.LargeObjectsInStateAlgo_8d66b773
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTGFyZ2VPYmplY3RzSW5TdGF0ZUFsZ28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ291bnRzIjpbeyJuYW1lIjoieCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ5IiwidHlwZSI6InVpbnQ4In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImdldE1iciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5jcmVhc2VYQ291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InhDb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDb3VudHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50OCkiLCJzdHJ1Y3QiOiJDb3VudHMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEwOV0sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDMsMTU0LDE3MV0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjUsMTM0LDE2NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQTVJRGdLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbmdpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiR0Z5WjJVdGIySnFaV04wY3kxcGJpMXpkR0YwWlM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCamJHRnpjeUJNWVhKblpVOWlhbVZqZEhOSmJsTjBZWFJsUVd4bmJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TVFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0T1dKbFptWXpObUVnTUhoaE5HVTRaREUyTkNBd2VERTVOakF4TnpkaklEQjRNalZtTXpJelpEQWdMeThnYldWMGFHOWtJQ0puWlhSTlluSW9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZbTl2ZEhOMGNtRndLSEJoZVNsMmIybGtJaXdnYldWMGFHOWtJQ0pwYm1OeVpXRnpaVmhEYjNWdWRDaDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEVOdmRXNTBjeWgxYVc1ME5qUXBLSFZwYm5RMk5DeDFhVzUwT0NraUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJkbGRFMWljbDl5YjNWMFpVQTBJR0p2YjNSemRISmhjQ0JwYm1OeVpXRnpaVmhEYjNWdWRDQm5aWFJEYjNWdWRITUtJQ0FnSUdWeWNnb0tiV0ZwYmw5blpYUk5ZbkpmY205MWRHVkFORG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUdkbGRFMWljaWdwT2lCMWFXNTBOalFnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TW1RNE0yWTBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4aGNtZGxMVzlpYW1WamRITXRhVzR0YzNSaGRHVXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdZMnhoYzNNZ1RHRnlaMlZQWW1wbFkzUnpTVzVUZEdGMFpVRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02T2t4aGNtZGxUMkpxWldOMGMwbHVVM1JoZEdWQmJHZHZMbUp2YjNSemRISmhjRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21KdmIzUnpkSEpoY0RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzWVhKblpTMXZZbXBsWTNSekxXbHVMWE4wWVhSbExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklHSnZiM1J6ZEhKaGNDaHdZWGs2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaWtnZXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z2NHRjVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeVlXNXpZV04wYVc5dUlIUjVjR1VnYVhNZ2NHRjVDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHRnlaMlV0YjJKcVpXTjBjeTFwYmkxemRHRjBaUzVoYkdkdkxuUnpPakl5TFRJMUNpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHdZWGtzSUhzS0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCQ1QxaGZUVUpTSUNzZ1FVTkRUMVZPVkY5Q1FWTkZYMDFDVWl3S0lDQWdJQzh2SUNBZ2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnZlNrS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiR0Z5WjJVdGIySnFaV04wY3kxcGJpMXpkR0YwWlM1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCaGJXOTFiblE2SUVKUFdGOU5RbElnS3lCQlEwTlBWVTVVWDBKQlUwVmZUVUpTTEFvZ0lDQWdjSFZ6YUdsdWRDQXlPVGd5T1RBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qSXlMVEkxQ2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNod1lYa3NJSHNLSUNBZ0lDOHZJQ0FnWVcxdmRXNTBPaUJDVDFoZlRVSlNJQ3NnUVVORFQxVk9WRjlDUVZORlgwMUNVaXdLSUNBZ0lDOHZJQ0FnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lEMDlDaUFnSUNCemQyRndDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeGhjbWRsTFc5aWFtVmpkSE10YVc0dGMzUmhkR1V1WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02TWpJdE1qVUtJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LSEJoZVN3Z2V3b2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklFSlBXRjlOUWxJZ0t5QkJRME5QVlU1VVgwSkJVMFZmVFVKU0xBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlCOUtRb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhKMElIUmhjbWRsZENCcGN5QnRZWFJqYUNCbWIzSWdZMjl1WkdsMGFXOXVjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeGhjbWRsTFc5aWFtVmpkSE10YVc0dGMzUmhkR1V1WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnYzNSdmNtRm5aU0E5SUVKdmVEeEdhWGhsWkVGeWNtRjVQRU52ZFc1MGN5d2dkSGx3Wlc5bUlFMUJXRjlKVkVWTlV6NCtLSHNnYTJWNU9pQW5lQ2NnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5naUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5QjBhR2x6TG5OMGIzSmhaMlV1WTNKbFlYUmxLQ2tLSUNBZ0lIQjFjMmhwYm5RZ056SXdNQW9nSUNBZ1ltOTRYMk55WldGMFpRb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5QmliMjkwYzNSeVlYQW9jR0Y1T2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiR0Z5WjJVdGIySnFaV04wY3kxcGJpMXpkR0YwWlM1aGJHZHZMblJ6T2pwTVlYSm5aVTlpYW1WamRITkpibE4wWVhSbFFXeG5ieTVwYm1OeVpXRnpaVmhEYjNWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx1WTNKbFlYTmxXRU52ZFc1ME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4aGNtZGxMVzlpYW1WamRITXRhVzR0YzNSaGRHVXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdhVzVqY21WaGMyVllRMjkxYm5Rb2FXNWtaWGc2SUhWcGJuUTJOQ3dnZUVOdmRXNTBPaUIxYVc1ME5qUXBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c1lYSm5aUzF2WW1wbFkzUnpMV2x1TFhOMFlYUmxMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJSFJvYVhNdWMzUnZjbUZuWlM1MllXeDFaVnRwYm1SbGVGMHVlQ0FyUFNCNFEyOTFiblFLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QTVDaUFnSUNBcUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QnpkRzl5WVdkbElEMGdRbTk0UEVacGVHVmtRWEp5WVhrOFEyOTFiblJ6TENCMGVYQmxiMllnVFVGWVgwbFVSVTFUUGo0b2V5QnJaWGs2SUNkNEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWllQ0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUhSb2FYTXVjM1J2Y21GblpTNTJZV3gxWlZ0cGJtUmxlRjB1ZUNBclBTQjRRMjkxYm5RS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnT1FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUhCMWMyaHBiblFnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4aGNtZGxMVzlpYW1WamRITXRhVzR0YzNSaGRHVXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdjM1J2Y21GblpTQTlJRUp2ZUR4R2FYaGxaRUZ5Y21GNVBFTnZkVzUwY3l3Z2RIbHdaVzltSUUxQldGOUpWRVZOVXo0K0tIc2dhMlY1T2lBbmVDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbmdpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiR0Z5WjJVdGIySnFaV04wY3kxcGJpMXpkR0YwWlM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCMGFHbHpMbk4wYjNKaFoyVXVkbUZzZFdWYmFXNWtaWGhkTG5nZ0t6MGdlRU52ZFc1MENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpTQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnhoY21kbExXOWlhbVZqZEhNdGFXNHRjM1JoZEdVdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2FXNWpjbVZoYzJWWVEyOTFiblFvYVc1a1pYZzZJSFZwYm5RMk5Dd2dlRU52ZFc1ME9pQjFhVzUwTmpRcElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qcE1ZWEpuWlU5aWFtVmpkSE5KYmxOMFlYUmxRV3huYnk1blpYUkRiM1Z1ZEhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJEYjNWdWRITTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHRnlaMlV0YjJKcVpXTjBjeTFwYmkxemRHRjBaUzVoYkdkdkxuUnpPak16Q2lBZ0lDQXZMeUJuWlhSRGIzVnVkSE1vYVc1a1pYZzZJSFZwYm5RMk5Da2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnhoY21kbExXOWlhbVZqZEhNdGFXNHRjM1JoZEdVdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVjM1J2Y21GblpTNTJZV3gxWlZ0cGJtUmxlRjBLSUNBZ0lHbHVkR05mTVNBdkx5QTVDaUFnSUNBcUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YkdGeVoyVXRiMkpxWldOMGN5MXBiaTF6ZEdGMFpTNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QnpkRzl5WVdkbElEMGdRbTk0UEVacGVHVmtRWEp5WVhrOFEyOTFiblJ6TENCMGVYQmxiMllnVFVGWVgwbFVSVTFUUGo0b2V5QnJaWGs2SUNkNEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWllQ0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuTjBiM0poWjJVdWRtRnNkV1ZiYVc1a1pYaGRDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekVnTHk4Z09Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNZWEpuWlMxdlltcGxZM1J6TFdsdUxYTjBZWFJsTG1Gc1oyOHVkSE02TXpNS0lDQWdJQzh2SUdkbGRFTnZkVzUwY3locGJtUmxlRG9nZFdsdWREWTBLU0I3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFRa0lKZ0VCZURFYlFRQThNUmtVUkRFWVJJSUVCSnZ2ODJvRXBPalJaQVFaWUJkOEJDWHpJOUEyR2dDT0JBQUJBQm9BUFFCa0FJQU1GUjk4ZFFBQUFBQUFMWVAwc0NKRE1Sa1VNUmdVRUVNeEZpSUpTVGdRSWhKRVNUZ0lnZlNIdGdFU1REZ0hNZ29TRUVRb2dhQTR1VWdpUXpZYUFVa1ZKQkpFRnpZYUFra1ZKQkpFRjB3akN5aExBU082Z1FCYlR3SUlGaWhPQXJzaVF6WWFBVWtWSkJKRUZ5TUxLRXdqdW9BRUZSOThkVXhRc0NKRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
