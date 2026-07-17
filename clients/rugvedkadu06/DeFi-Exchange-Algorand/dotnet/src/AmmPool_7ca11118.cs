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

namespace Arc56.Generated.rugvedkadu06.DeFi_Exchange_Algorand.AmmPool_7ca11118
{


    public class AmmPoolProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AmmPoolProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetReservesReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetReservesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetReservesReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetReservesReturn);
                }
                public bool Equals(GetReservesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetReservesReturn left, GetReservesReturn right)
                {
                    return EqualityComparer<GetReservesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetReservesReturn left, GetReservesReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the pool with two tokens and create LP token.
        ///</summary>
        /// <param name="token_a"> </param>
        /// <param name="token_b"> </param>
        public async Task<ulong> CreatePool(ulong token_a, ulong token_b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 67, 89, 204 };
            var token_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_aAbi.From(token_a);
            var token_bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_bAbi.From(token_b);

            var result = await base.CallApp(new List<object> { abiHandle, token_aAbi, token_bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreatePool_Transactions(ulong token_a, ulong token_b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 67, 89, 204 };
            var token_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_aAbi.From(token_a);
            var token_bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_bAbi.From(token_b);

            return await base.MakeTransactionList(new List<object> { abiHandle, token_aAbi, token_bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deposit tokens and mint LP tokens.
        ///</summary>
        /// <param name="axfer_a"> </param>
        /// <param name="axfer_b"> </param>
        public async Task<ulong> AddLiquidity(AssetTransferTransaction axfer_a, AssetTransferTransaction axfer_b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { axfer_a, axfer_b });
            byte[] abiHandle = { 1, 71, 44, 188 };

            var result = await base.CallApp(new List<object> { abiHandle, axfer_a, axfer_b }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddLiquidity_Transactions(AssetTransferTransaction axfer_a, AssetTransferTransaction axfer_b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { axfer_a, axfer_b });
            byte[] abiHandle = { 1, 71, 44, 188 };

            return await base.MakeTransactionList(new List<object> { abiHandle, axfer_a, axfer_b }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Burn LP tokens and withdraw reserves.
        ///</summary>
        /// <param name="lp_axfer"> </param>
        public async Task RemoveLiquidity(AssetTransferTransaction lp_axfer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { lp_axfer });
            byte[] abiHandle = { 46, 173, 200, 25 };

            var result = await base.CallApp(new List<object> { abiHandle, lp_axfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RemoveLiquidity_Transactions(AssetTransferTransaction lp_axfer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { lp_axfer });
            byte[] abiHandle = { 46, 173, 200, 25 };

            return await base.MakeTransactionList(new List<object> { abiHandle, lp_axfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return current pool reserves.
        ///</summary>
        public async Task<Structs.GetReservesReturn> GetReserves(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 164, 62, 235 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetReservesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetReserves_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 164, 62, 235 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQW1tUG9vbCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRSZXNlcnZlc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9wb29sIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIHBvb2wgd2l0aCB0d28gdG9rZW5zIGFuZCBjcmVhdGUgTFAgdG9rZW4uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuX2EiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuX2IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfbGlxdWlkaXR5IiwiZGVzYyI6IkRlcG9zaXQgdG9rZW5zIGFuZCBtaW50IExQIHRva2Vucy4iLCJhcmdzIjpbeyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJheGZlcl9hIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF4ZmVyX2IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW1vdmVfbGlxdWlkaXR5IiwiZGVzYyI6IkJ1cm4gTFAgdG9rZW5zIGFuZCB3aXRoZHJhdyByZXNlcnZlcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJscF9heGZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcmVzZXJ2ZXMiLCJkZXNjIjoiUmV0dXJuIGN1cnJlbnQgcG9vbCByZXNlcnZlcy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0UmVzZXJ2ZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUzOF0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBMUCB0b2tlbnMgZm9yIHdpdGhkcmF3YWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzBdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgbGlxdWlkaXR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI4XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCB0b2tlbiBBIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM4XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCB0b2tlbiBCIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg4XSwiZXJyb3JNZXNzYWdlIjoiUG9vbCBhbHJlYWR5IGluaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA2LDQ4NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubHBfdG9rZW5faWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYzLDM5NCw0MzcsNDk4LDU2OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubHBfdG9rZW5fc3VwcGx5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3NCw0NDYsNTEwLDU0Miw2MzFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlc2VydmVfYSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODQsNDU2LDUyNSw1NTUsNjM1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZXNlcnZlX2IgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg2LDMyNiw1NzldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRva2VuX2FfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM2LDYwNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG9rZW5fYl9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzIsMTgxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA4LDMxOCw0NzddLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lEUWdNU0E0Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0p5WlhObGNuWmxYMkVpSUNKeVpYTmxjblpsWDJJaUlDSnNjRjkwYjJ0bGJsOXpkWEJ3YkhraUlDSjBiMnRsYmw5aFgybGtJaUFpZEc5clpXNWZZbDlwWkNJZ0lteHdYM1J2YTJWdVgybGtJaUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXRYM0J2YjJ3dlkyOXVkSEpoWTNRdWNIazZOZ29nSUNBZ0x5OGdjMlZzWmk1MGIydGxibDloWDJsa0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiMnRsYmw5aFgybGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXRYM0J2YjJ3dlkyOXVkSEpoWTNRdWNIazZOd29nSUNBZ0x5OGdjMlZzWmk1MGIydGxibDlpWDJsa0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjBiMnRsYmw5aVgybGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXRYM0J2YjJ3dlkyOXVkSEpoWTNRdWNIazZPQW9nSUNBZ0x5OGdjMlZzWmk1eVpYTmxjblpsWDJFZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luSmxjMlZ5ZG1WZllTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJWOXdiMjlzTDJOdmJuUnlZV04wTG5CNU9qa0tJQ0FnSUM4dklITmxiR1l1Y21WelpYSjJaVjlpSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKeVpYTmxjblpsWDJJaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYlcxZmNHOXZiQzlqYjI1MGNtRmpkQzV3ZVRveE1Bb2dJQ0FnTHk4Z2MyVnNaaTVzY0Y5MGIydGxibDlwWkNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWJIQmZkRzlyWlc1ZmFXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJXMWZjRzl2YkM5amIyNTBjbUZqZEM1d2VUb3hNUW9nSUNBZ0x5OGdjMlZzWmk1c2NGOTBiMnRsYmw5emRYQndiSGtnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW14d1gzUnZhMlZ1WDNOMWNIQnNlU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVcxdFgzQnZiMnd2WTI5dWRISmhZM1F1Y0hrNk5Bb2dJQ0FnTHk4Z1kyeGhjM01nUVcxdFVHOXZiQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVE1LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFEwTkRNMU9XTmpJREI0TURFME56SmpZbU1nTUhneVpXRmtZemd4T1NBd2VHSTFZVFF6WldWaUlDOHZJRzFsZEdodlpDQWlZM0psWVhSbFgzQnZiMndvZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltRmtaRjlzYVhGMWFXUnBkSGtvWVhobVpYSXNZWGhtWlhJcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKeVpXMXZkbVZmYkdseGRXbGthWFI1S0dGNFptVnlLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRjl5WlhObGNuWmxjeWdwS0hWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxYM0J2YjJ3Z1lXUmtYMnhwY1hWcFpHbDBlU0J5WlcxdmRtVmZiR2x4ZFdsa2FYUjVJR2RsZEY5eVpYTmxjblpsY3dvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERXpPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXMXRYM0J2YjJ3dVkyOXVkSEpoWTNRdVFXMXRVRzl2YkM1amNtVmhkR1ZmY0c5dmJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpWOXdiMjlzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ0YlY5d2IyOXNMMk52Ym5SeVlXTjBMbkI1T2pFekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYlcxZmNHOXZiQzlqYjI1MGNtRmpkQzV3ZVRveE5nb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVkRzlyWlc1ZllWOXBaQ0E5UFNBd0xDQWlVRzl2YkNCaGJISmxZV1I1SUdsdWFYUnBZV3hwZW1Wa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmEyVnVYMkZmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzlyWlc1ZllWOXBaQ0JsZUdsemRITUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJRYjI5c0lHRnNjbVZoWkhrZ2FXNXBkR2xoYkdsNlpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJXMWZjRzl2YkM5amIyNTBjbUZqZEM1d2VUb3hPQW9nSUNBZ0x5OGdjMlZzWmk1MGIydGxibDloWDJsa0lEMGdkRzlyWlc1ZllTNXBaQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzlyWlc1ZllWOXBaQ0lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ0YlY5d2IyOXNMMk52Ym5SeVlXTjBMbkI1T2pFNUNpQWdJQ0F2THlCelpXeG1MblJ2YTJWdVgySmZhV1FnUFNCMGIydGxibDlpTG1sa0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGIydGxibDlpWDJsa0lnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXRYM0J2YjJ3dlkyOXVkSEpoWTNRdWNIazZNakV0TWpZS0lDQWdJQzh2SUNNZ1QzQjBMV2x1SUhSdklIUnZhMlZ1Y3dvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlkRzlyWlc1ZllTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ0YlY5d2IyOXNMMk52Ym5SeVlXTjBMbkI1T2pJMENpQWdJQ0F2THlCaGMzTmxkRjl5WldObGFYWmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiVzFmY0c5dmJDOWpiMjUwY21GamRDNXdlVG95TlFvZ0lDQWdMeThnWVhOelpYUmZZVzF2ZFc1MFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJWOXdiMjlzTDJOdmJuUnlZV04wTG5CNU9qSXhMVEl5Q2lBZ0lDQXZMeUFqSUU5d2RDMXBiaUIwYnlCMGIydGxibk1LSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lHbHVkR05mTVNBdkx5QmhlR1psY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXRYM0J2YjJ3dlkyOXVkSEpoWTNRdWNIazZNakV0TWpZS0lDQWdJQzh2SUNNZ1QzQjBMV2x1SUhSdklIUnZhMlZ1Y3dvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlkRzlyWlc1ZllTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYlcxZmNHOXZiQzlqYjI1MGNtRmpkQzV3ZVRveU55MHpNUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROWRHOXJaVzVmWWl3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnRiVjl3YjI5c0wyTnZiblJ5WVdOMExuQjVPakk1Q2lBZ0lDQXZMeUJoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJXMWZjRzl2YkM5amIyNTBjbUZqZEM1d2VUb3pNQW9nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFRBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ0YlY5d2IyOXNMMk52Ym5SeVlXTjBMbkI1T2pJM0NpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0JwYm5Salh6RWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ0YlY5d2IyOXNMMk52Ym5SeVlXTjBMbkI1T2pJM0xUTXhDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxMGIydGxibDlpTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnRiVjl3YjI5c0wyTnZiblJ5WVdOMExuQjVPak16TFRRd0NpQWdJQ0F2THlBaklFTnlaV0YwWlNCTVVDQjBiMnRsYmdvZ0lDQWdMeThnYkhCZllYTnpaWFFnUFNCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDI1aGJXVTlJa1JGV0MxTVVDMVVUMHRGVGlJc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEY5dVlXMWxQU0pNVUNJc0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3OU1UQmZNREF3WHpBd01GOHdNREJmTURBd0xDQWpJRXhoY21kbElITjFjSEJzZVFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4elBUWXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUzVqY21WaGRHVmtYMkZ6YzJWMENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzF0WDNCdmIyd3ZZMjl1ZEhKaFkzUXVjSGs2TXprS0lDQWdJQzh2SUcxaGJtRm5aWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVFdGdVlXZGxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnRiVjl3YjI5c0wyTnZiblJ5WVdOMExuQjVPak00Q2lBZ0lDQXZMeUJrWldOcGJXRnNjejAyTEFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBSR1ZqYVcxaGJITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJXMWZjRzl2YkM5amIyNTBjbUZqZEM1d2VUb3pOd29nSUNBZ0x5OGdkRzkwWVd3OU1UQmZNREF3WHpBd01GOHdNREJmTURBd0xDQWpJRXhoY21kbElITjFjSEJzZVFvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3TURBd01EQXdNREF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZSdmRHRnNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXRYM0J2YjJ3dlkyOXVkSEpoWTNRdWNIazZNellLSUNBZ0lDOHZJSFZ1YVhSZmJtRnRaVDBpVEZBaUxBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKTVVDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJWOXdiMjlzTDJOdmJuUnlZV04wTG5CNU9qTTFDaUFnSUNBdkx5QmhjM05sZEY5dVlXMWxQU0pFUlZndFRGQXRWRTlMUlU0aUxBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRVJWZ3RURkF0VkU5TFJVNGlDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUbUZ0WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ0YlY5d2IyOXNMMk52Ym5SeVlXTjBMbkI1T2pNekxUTTBDaUFnSUNBdkx5QWpJRU55WldGMFpTQk1VQ0IwYjJ0bGJnb2dJQ0FnTHk4Z2JIQmZZWE56WlhRZ1BTQnBkSGh1TGtGemMyVjBRMjl1Wm1sbktBb2dJQ0FnY0hWemFHbHVkQ0F6SUM4dklHRmpabWNLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJWOXdiMjlzTDJOdmJuUnlZV04wTG5CNU9qTXpMVFF3Q2lBZ0lDQXZMeUFqSUVOeVpXRjBaU0JNVUNCMGIydGxiZ29nSUNBZ0x5OGdiSEJmWVhOelpYUWdQU0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOUlrUkZXQzFNVUMxVVQwdEZUaUlzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBTSk1VQ0lzQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3c5TVRCZk1EQXdYekF3TUY4d01EQmZNREF3TENBaklFeGhjbWRsSUhOMWNIQnNlUW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFRZc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tTNWpjbVZoZEdWa1gyRnpjMlYwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJEY21WaGRHVmtRWE56WlhSSlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJWOXdiMjlzTDJOdmJuUnlZV04wTG5CNU9qUXlDaUFnSUNBdkx5QnpaV3htTG14d1gzUnZhMlZ1WDJsa0lEMGdiSEJmWVhOelpYUXVhV1FLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbXh3WDNSdmEyVnVYMmxrSWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVcxdFgzQnZiMnd2WTI5dWRISmhZM1F1Y0hrNk1UTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTmlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGJXMWZjRzl2YkM1amIyNTBjbUZqZEM1QmJXMVFiMjlzTG1Ga1pGOXNhWEYxYVdScGRIbGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWkdSZmJHbHhkV2xrYVhSNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJWOXdiMjlzTDJOdmJuUnlZV04wTG5CNU9qUTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUMwS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCaGVHWmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklHRjRabVZ5Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCaGVHWmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklHRjRabVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzF0WDNCdmIyd3ZZMjl1ZEhKaFkzUXVjSGs2TkRnS0lDQWdJQzh2SUdGemMyVnlkQ0JoZUdabGNsOWhMbmhtWlhKZllYTnpaWFF1YVdRZ1BUMGdjMlZzWmk1MGIydGxibDloWDJsa0xDQWlTVzUyWVd4cFpDQjBiMnRsYmlCQklnb2dJQ0FnWkdsbklERUtJQ0FnSUdkMGVHNXpJRmhtWlhKQmMzTmxkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZhMlZ1WDJGZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5clpXNWZZVjlwWkNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkNCMGIydGxiaUJCQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzF0WDNCdmIyd3ZZMjl1ZEhKaFkzUXVjSGs2TkRrS0lDQWdJQzh2SUdGemMyVnlkQ0JoZUdabGNsOWlMbmhtWlhKZllYTnpaWFF1YVdRZ1BUMGdjMlZzWmk1MGIydGxibDlpWDJsa0xDQWlTVzUyWVd4cFpDQjBiMnRsYmlCQ0lnb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QllabVZ5UVhOelpYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGIydGxibDlpWDJsa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2YTJWdVgySmZhV1FnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnZEc5clpXNGdRZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnRiVjl3YjI5c0wyTnZiblJ5WVdOMExuQjVPalV3Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWGhtWlhKZllTNWhjM05sZEY5eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYlcxZmNHOXZiQzlqYjI1MGNtRmpkQzV3ZVRvMU1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdGNFptVnlYMkl1WVhOelpYUmZjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJWOXdiMjlzTDJOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QmhiWFJmWVNBOUlHRjRabVZ5WDJFdVlYTnpaWFJmWVcxdmRXNTBDaUFnSUNCemQyRndDaUFnSUNCbmRIaHVjeUJCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ0YlY5d2IyOXNMMk52Ym5SeVlXTjBMbkI1T2pVMENpQWdJQ0F2THlCaGJYUmZZaUE5SUdGNFptVnlYMkl1WVhOelpYUmZZVzF2ZFc1MENpQWdJQ0JuZEhodWN5QkJjM05sZEVGdGIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnRiVjl3YjI5c0wyTnZiblJ5WVdOMExuQjVPalUzQ2lBZ0lDQXZMeUJwWmlCelpXeG1MbXh3WDNSdmEyVnVYM04xY0hCc2VTQTlQU0F3T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbXh3WDNSdmEyVnVYM04xY0hCc2VTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVzY0Y5MGIydGxibDl6ZFhCd2JIa2daWGhwYzNSekNpQWdJQ0JpYm5vZ1lXUmtYMnhwY1hWcFpHbDBlVjlsYkhObFgySnZaSGxBTXdvZ0lDQWdaR2xuSURFS0NtRmtaRjlzYVhGMWFXUnBkSGxmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnRiVjl3YjI5c0wyTnZiblJ5WVdOMExuQjVPalkyQ2lBZ0lDQXZMeUJoYzNObGNuUWdiV2x1ZEY5aGJXOTFiblFnUGlBd0xDQWlTVzV6ZFdabWFXTnBaVzUwSUd4cGNYVnBaR2wwZVNJS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCc2FYRjFhV1JwZEhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYlcxZmNHOXZiQzlqYjI1MGNtRmpkQzV3ZVRvMk9Bb2dJQ0FnTHk4Z2MyVnNaaTV5WlhObGNuWmxYMkVnS3owZ1lXMTBYMkVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnlaWE5sY25abFgyRWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y21WelpYSjJaVjloSUdWNGFYTjBjd29nSUNBZ1pHbG5JRE1LSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luSmxjMlZ5ZG1WZllTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXRYM0J2YjJ3dlkyOXVkSEpoWTNRdWNIazZOamtLSUNBZ0lDOHZJSE5sYkdZdWNtVnpaWEoyWlY5aUlDczlJR0Z0ZEY5aUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY21WelpYSjJaVjlpSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuSmxjMlZ5ZG1WZllpQmxlR2x6ZEhNS0lDQWdJR1JwWnlBeUNpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p5WlhObGNuWmxYMklpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ0YlY5d2IyOXNMMk52Ym5SeVlXTjBMbkI1T2pjd0NpQWdJQ0F2THlCelpXeG1MbXh3WDNSdmEyVnVYM04xY0hCc2VTQXJQU0J0YVc1MFgyRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbXh3WDNSdmEyVnVYM04xY0hCc2VTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVzY0Y5MGIydGxibDl6ZFhCd2JIa2daWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYkhCZmRHOXJaVzVmYzNWd2NHeDVJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiVzFmY0c5dmJDOWpiMjUwY21GamRDNXdlVG8zTWkwM053b2dJQ0FnTHk4Z0l5QlVjbUZ1YzJabGNpQk1VQ0IwYjJ0bGJuTWdkRzhnZFhObGNnb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5UVhOelpYUW9jMlZzWmk1c2NGOTBiMnRsYmw5cFpDa3NDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTlZWGhtWlhKZllTNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFcxcGJuUmZZVzF2ZFc1MExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ0YlY5d2IyOXNMMk52Ym5SeVlXTjBMbkI1T2pjMENpQWdJQ0F2THlCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXViSEJmZEc5clpXNWZhV1FwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbXh3WDNSdmEyVnVYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxteHdYM1J2YTJWdVgybGtJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJWOXdiMjlzTDJOdmJuUnlZV04wTG5CNU9qYzFDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxaGVHWmxjbDloTG5ObGJtUmxjaXdLSUNBZ0lHUnBaeUEwQ2lBZ0lDQm5kSGh1Y3lCVFpXNWtaWElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzF0WDNCdmIyd3ZZMjl1ZEhKaFkzUXVjSGs2TnpJdE56TUtJQ0FnSUM4dklDTWdWSEpoYm5ObVpYSWdURkFnZEc5clpXNXpJSFJ2SUhWelpYSUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUdsdWRHTmZNU0F2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVcxdFgzQnZiMnd2WTI5dWRISmhZM1F1Y0hrNk56SXROemNLSUNBZ0lDOHZJQ01nVkhKaGJuTm1aWElnVEZBZ2RHOXJaVzV6SUhSdklIVnpaWElLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXViSEJmZEc5clpXNWZhV1FwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFdGNFptVnlYMkV1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMXRhVzUwWDJGdGIzVnVkQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXRYM0J2YjJ3dlkyOXVkSEpoWTNRdWNIazZORFVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1lXUmtYMnhwY1hWcFpHbDBlVjlsYkhObFgySnZaSGxBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYlcxZmNHOXZiQzlqYjI1MGNtRmpkQzV3ZVRvMk1TMDJNZ29nSUNBZ0x5OGdJeUJRY205d2IzSjBhVzl1WVd3Z2JXbHVkR2x1WndvZ0lDQWdMeThnYldsdWRGOWhJRDBnS0dGdGRGOWhJQ29nYzJWc1ppNXNjRjkwYjJ0bGJsOXpkWEJ3YkhrcElDOHZJSE5sYkdZdWNtVnpaWEoyWlY5aENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYkhCZmRHOXJaVzVmYzNWd2NHeDVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14d1gzUnZhMlZ1WDNOMWNIQnNlU0JsZUdsemRITUtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNUW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5KbGMyVnlkbVZmWVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaWE5sY25abFgyRWdaWGhwYzNSekNpQWdJQ0F2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzF0WDNCdmIyd3ZZMjl1ZEhKaFkzUXVjSGs2TmpNS0lDQWdJQzh2SUcxcGJuUmZZaUE5SUNoaGJYUmZZaUFxSUhObGJHWXViSEJmZEc5clpXNWZjM1Z3Y0d4NUtTQXZMeUJ6Wld4bUxuSmxjMlZ5ZG1WZllnb2dJQ0FnWkdsbklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luSmxjMlZ5ZG1WZllpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV5WlhObGNuWmxYMklnWlhocGMzUnpDaUFnSUNBdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVcxdFgzQnZiMnd2WTI5dWRISmhZM1F1Y0hrNk5qUUtJQ0FnSUM4dklHMXBiblJmWVcxdmRXNTBJRDBnYldsdWRGOWhJR2xtSUcxcGJuUmZZU0E4SUcxcGJuUmZZaUJsYkhObElHMXBiblJmWWdvZ0lDQWdaSFZ3TWdvZ0lDQWdQQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JpSUdGa1pGOXNhWEYxYVdScGRIbGZZV1owWlhKZmFXWmZaV3h6WlVBMENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZ0YlY5d2IyOXNMbU52Ym5SeVlXTjBMa0Z0YlZCdmIyd3VjbVZ0YjNabFgyeHBjWFZwWkdsMGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsYlc5MlpWOXNhWEYxYVdScGRIazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXRYM0J2YjJ3dlkyOXVkSEpoWTNRdWNIazZPREVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQnVJRElLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdZWGhtWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJoZUdabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJWOXdiMjlzTDJOdmJuUnlZV04wTG5CNU9qZzBDaUFnSUNBdkx5QmhjM05sY25RZ2JIQmZZWGhtWlhJdWVHWmxjbDloYzNObGRDNXBaQ0E5UFNCelpXeG1MbXh3WDNSdmEyVnVYMmxrQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZobVpYSkJjM05sZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbXh3WDNSdmEyVnVYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxteHdYM1J2YTJWdVgybGtJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJWOXdiMjlzTDJOdmJuUnlZV04wTG5CNU9qZzFDaUFnSUNBdkx5QmhjM05sY25RZ2JIQmZZWGhtWlhJdVlYTnpaWFJmY21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCQmMzTmxkRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnRiVjl3YjI5c0wyTnZiblJ5WVdOMExuQjVPamcyQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1c2NGOTBiMnRsYmw5emRYQndiSGtnUGlBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYkhCZmRHOXJaVzVmYzNWd2NHeDVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14d1gzUnZhMlZ1WDNOMWNIQnNlU0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXRYM0J2YjJ3dlkyOXVkSEpoWTNRdWNIazZPRGdLSUNBZ0lDOHZJR3h3WDJGdGRDQTlJR3h3WDJGNFptVnlMbUZ6YzJWMFgyRnRiM1Z1ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdaM1I0Ym5NZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnRiVjl3YjI5c0wyTnZiblJ5WVdOMExuQjVPamc1Q2lBZ0lDQXZMeUJ2ZFhSZllTQTlJQ2hzY0Y5aGJYUWdLaUJ6Wld4bUxuSmxjMlZ5ZG1WZllTa2dMeThnYzJWc1ppNXNjRjkwYjJ0bGJsOXpkWEJ3YkhrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p5WlhObGNuWmxYMkVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVnpaWEoyWlY5aElHVjRhWE4wY3dvZ0lDQWdaR2xuSURFS0lDQWdJQ29LSUNBZ0lHUnBaeUF5Q2lBZ0lDQXZDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYlcxZmNHOXZiQzlqYjI1MGNtRmpkQzV3ZVRvNU1Bb2dJQ0FnTHk4Z2IzVjBYMklnUFNBb2JIQmZZVzEwSUNvZ2MyVnNaaTV5WlhObGNuWmxYMklwSUM4dklITmxiR1l1YkhCZmRHOXJaVzVmYzNWd2NHeDVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNtVnpaWEoyWlY5aUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsYzJWeWRtVmZZaUJsZUdsemRITUtJQ0FnSUNvS0lDQWdJSE4zWVhBS0lDQWdJQzhLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiVzFmY0c5dmJDOWpiMjUwY21GamRDNXdlVG81TWdvZ0lDQWdMeThnWVhOelpYSjBJRzkxZEY5aElENGdNQ0JoYm1RZ2IzVjBYMklnUGlBd0xDQWlTVzV6ZFdabWFXTnBaVzUwSUV4UUlIUnZhMlZ1Y3lCbWIzSWdkMmwwYUdSeVlYZGhiQ0lLSUNBZ0lHSjZJSEpsYlc5MlpWOXNhWEYxYVdScGRIbGZZbTl2YkY5bVlXeHpaVUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjZJSEpsYlc5MlpWOXNhWEYxYVdScGRIbGZZbTl2YkY5bVlXeHpaVUEwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9LY21WdGIzWmxYMnhwY1hWcFpHbDBlVjlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVcxdFgzQnZiMnd2WTI5dWRISmhZM1F1Y0hrNk9USUtJQ0FnSUM4dklHRnpjMlZ5ZENCdmRYUmZZU0ErSURBZ1lXNWtJRzkxZEY5aUlENGdNQ3dnSWtsdWMzVm1abWxqYVdWdWRDQk1VQ0IwYjJ0bGJuTWdabTl5SUhkcGRHaGtjbUYzWVd3aUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1emRXWm1hV05wWlc1MElFeFFJSFJ2YTJWdWN5Qm1iM0lnZDJsMGFHUnlZWGRoYkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ0YlY5d2IyOXNMMk52Ym5SeVlXTjBMbkI1T2prMENpQWdJQ0F2THlCelpXeG1MbkpsYzJWeWRtVmZZU0F0UFNCdmRYUmZZUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luSmxjMlZ5ZG1WZllTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV5WlhObGNuWmxYMkVnWlhocGMzUnpDaUFnSUNCa2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnlaWE5sY25abFgyRWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnRiVjl3YjI5c0wyTnZiblJ5WVdOMExuQjVPamsxQ2lBZ0lDQXZMeUJ6Wld4bUxuSmxjMlZ5ZG1WZllpQXRQU0J2ZFhSZllnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5KbGMyVnlkbVZmWWlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaWE5sY25abFgySWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNBdENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKeVpYTmxjblpsWDJJaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJWOXdiMjlzTDJOdmJuUnlZV04wTG5CNU9qazJDaUFnSUNBdkx5QnpaV3htTG14d1gzUnZhMlZ1WDNOMWNIQnNlU0F0UFNCc2NGOWhiWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnNjRjkwYjJ0bGJsOXpkWEJ3YkhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViSEJmZEc5clpXNWZjM1Z3Y0d4NUlHVjRhWE4wY3dvZ0lDQWdaR2xuSURVS0lDQWdJQzBLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbXh3WDNSdmEyVnVYM04xY0hCc2VTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXRYM0J2YjJ3dlkyOXVkSEpoWTNRdWNIazZPVGd0TVRBekNpQWdJQ0F2THlBaklGTmxibVFnZEc5clpXNXpJR0poWTJzZ2RHOGdkWE5sY2dvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlRWE56WlhRb2MyVnNaaTUwYjJ0bGJsOWhYMmxrS1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxc2NGOWhlR1psY2k1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVzkxZEY5aExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ0YlY5d2IyOXNMMk52Ym5SeVlXTjBMbkI1T2pFd01Bb2dJQ0FnTHk4Z2VHWmxjbDloYzNObGREMUJjM05sZENoelpXeG1MblJ2YTJWdVgyRmZhV1FwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblJ2YTJWdVgyRmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOXJaVzVmWVY5cFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYlcxZmNHOXZiQzlqYjI1MGNtRmpkQzV3ZVRveE1ERUtJQ0FnSUM4dklHRnpjMlYwWDNKbFkyVnBkbVZ5UFd4d1gyRjRabVZ5TG5ObGJtUmxjaXdLSUNBZ0lHUnBaeUEyQ2lBZ0lDQm5kSGh1Y3lCVFpXNWtaWElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVcxdFgzQnZiMnd2WTI5dWRISmhZM1F1Y0hrNk9UZ3RPVGtLSUNBZ0lDOHZJQ01nVTJWdVpDQjBiMnRsYm5NZ1ltRmpheUIwYnlCMWMyVnlDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNCcGJuUmpYekVnTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJWOXdiMjlzTDJOdmJuUnlZV04wTG5CNU9qazRMVEV3TXdvZ0lDQWdMeThnSXlCVFpXNWtJSFJ2YTJWdWN5QmlZV05ySUhSdklIVnpaWElLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXVkRzlyWlc1ZllWOXBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5YkhCZllYaG1aWEl1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMXZkWFJmWVN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzF0WDNCdmIyd3ZZMjl1ZEhKaFkzUXVjSGs2TVRBMUxURXdPUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROVFYTnpaWFFvYzJWc1ppNTBiMnRsYmw5aVgybGtLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFzY0Y5aGVHWmxjaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBXOTFkRjlpTEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnRiVjl3YjI5c0wyTnZiblJ5WVdOMExuQjVPakV3TmdvZ0lDQWdMeThnZUdabGNsOWhjM05sZEQxQmMzTmxkQ2h6Wld4bUxuUnZhMlZ1WDJKZmFXUXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnZhMlZ1WDJKZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5clpXNWZZbDlwWkNCbGVHbHpkSE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJWOXdiMjlzTDJOdmJuUnlZV04wTG5CNU9qRXdOUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2FXNTBZMTh4SUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJXMWZjRzl2YkM5amIyNTBjbUZqZEM1d2VUb3hNRFV0TVRBNUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFCYzNObGRDaHpaV3htTG5SdmEyVnVYMkpmYVdRcExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBXeHdYMkY0Wm1WeUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5YjNWMFgySXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGdGJWOXdiMjlzTDJOdmJuUnlZV04wTG5CNU9qZ3hDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25KbGJXOTJaVjlzYVhGMWFXUnBkSGxmWW05dmJGOW1ZV3h6WlVBME9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnY21WdGIzWmxYMnhwY1hWcFpHbDBlVjlpYjI5c1gyMWxjbWRsUURVS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZVzF0WDNCdmIyd3VZMjl1ZEhKaFkzUXVRVzF0VUc5dmJDNW5aWFJmY21WelpYSjJaWE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZjbVZ6WlhKMlpYTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXMXRYM0J2YjJ3dlkyOXVkSEpoWTNRdWNIazZNVEUwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdLSE5sYkdZdWNtVnpaWEoyWlY5aExDQnpaV3htTG5KbGMyVnlkbVZmWWlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p5WlhObGNuWmxYMkVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVnpaWEoyWlY5aElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkpsYzJWeWRtVmZZaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVpYTmxjblpsWDJJZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZVzF0WDNCdmIyd3ZZMjl1ZEhKaFkzUXVjSGs2TVRFeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBUUJDQ1lIQ1hKbGMyVnlkbVZmWVFseVpYTmxjblpsWDJJUGJIQmZkRzlyWlc1ZmMzVndjR3g1Q25SdmEyVnVYMkZmYVdRS2RHOXJaVzVmWWw5cFpBdHNjRjkwYjJ0bGJsOXBaQVFWSDN4MU1SaEFBQlFySW1jbkJDSm5LQ0puS1NKbkp3VWlaeW9pWnpFYlFRQXJNUmtVUkRFWVJJSUVCRVJEV2N3RUFVY3N2QVF1cmNnWkJMV2tQdXMyR2dDT0JBQUpBSTBCTndIWUFERVpGREVZRkJCRE5ob0JTUlVsRWtRWE5ob0NTUlVsRWtRWElpdGxSQlJFSzBzQ1p5Y0VTd0Zuc1RJS0lySVNzaFJNc2hFanNoQWlzZ0d6c1RJS0lySVNzaFN5RVNPeUVDS3lBYk94TWdxeUtZRUdzaU9CZ01ESzg0U2pBcklpZ0FKTVVMSWxnQXhFUlZndFRGQXRWRTlMUlU2eUpvRURzaEFpc2dHenREd25CVXNCWnhZbkJreFFzQ1JETVJhQkFnbEhBamdRSXhKRU1SWWtDVWs0RUNNU1JFc0JPQkVpSzJWRUVrUkpPQkVpSndSbFJCSkVTd0U0RkRJS0VrUkpPQlF5Q2hKRVREZ1NURGdTSWlwbFJFQUFRMHNCU1VRaUtHVkVTd01JS0V4bklpbGxSRXNDQ0NsTVp5SXFaVVJMQVFncVRHZXhJaWNGWlVSTEJEZ0FTd0t5RXJJVXNoRWpzaEFpc2dHekZpY0dURkN3SkVNaUttVkVTd0pMQVFzaUtHVkVDa3NDVHdJTElpbGxSQXBLREV4T0FrMUMvNTR4RmlRSlJ3STRFQ01TUkVrNEVTSW5CV1ZFRWtSSk9CUXlDaEpFSWlwbFJFbEVURGdTU1U0Q0lpaGxSRXNCQzBzQ0NrbE9BMDRESWlsbFJBdE1Da3hCQUZ0SlFRQlhKRVFpS0dWRVN3SkpUZ0lKS0V4bklpbGxSRXNDU1U0RENTbE1aeUlxWlVSTEJRa3FUR2V4SWl0bFJFc0dPQUJQQXJJU1NiSVVUTElSSTdJUUlySUJzN0VpSndSbFJFOENzaEt5RWJJVUk3SVFJcklCc3lSRElrTC9waUlvWlVRaUtXVkVUQlpNRmxBbkJreFFzQ1JEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
