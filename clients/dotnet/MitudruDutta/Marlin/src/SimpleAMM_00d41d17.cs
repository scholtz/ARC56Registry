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

namespace Arc56.Generated.MitudruDutta.Marlin.SimpleAMM_00d41d17
{


    //
    // Simple AMM for PT/YT token trading
    //
    public class SimpleAMMProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SimpleAMMProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class GetUserLiquidityReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetUserLiquidityReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetUserLiquidityReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetUserLiquidityReturn);
                }
                public bool Equals(GetUserLiquidityReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetUserLiquidityReturn left, GetUserLiquidityReturn right)
                {
                    return EqualityComparer<GetUserLiquidityReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetUserLiquidityReturn left, GetUserLiquidityReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetPoolInfoReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetPoolInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetPoolInfoReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetPoolInfoReturn);
                }
                public bool Equals(GetPoolInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetPoolInfoReturn left, GetPoolInfoReturn right)
                {
                    return EqualityComparer<GetPoolInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetPoolInfoReturn left, GetPoolInfoReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the AMM
        ///</summary>
        public async Task<string> Initialize(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 122, 209, 167 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Initialize_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 137, 122, 209, 167 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add liquidity to the pool
        ///</summary>
        /// <param name="amount_a"> </param>
        /// <param name="amount_b"> </param>
        public async Task<string> AddLiquidity(ulong amount_a, ulong amount_b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 213, 229, 79 };
            var amount_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_aAbi.From(amount_a);
            var amount_bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_bAbi.From(amount_b);

            var result = await base.CallApp(new List<object> { abiHandle, amount_aAbi, amount_bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> AddLiquidity_Transactions(ulong amount_a, ulong amount_b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 213, 229, 79 };
            var amount_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_aAbi.From(amount_a);
            var amount_bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_bAbi.From(amount_b);

            return await base.MakeTransactionList(new List<object> { abiHandle, amount_aAbi, amount_bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Swap token A for token B
        ///</summary>
        /// <param name="amount_in"> </param>
        public async Task<string> SwapAForB(ulong amount_in, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 94, 107, 203 };
            var amount_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inAbi.From(amount_in);

            var result = await base.CallApp(new List<object> { abiHandle, amount_inAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SwapAForB_Transactions(ulong amount_in, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 94, 107, 203 };
            var amount_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inAbi.From(amount_in);

            return await base.MakeTransactionList(new List<object> { abiHandle, amount_inAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Swap token B for token A
        ///</summary>
        /// <param name="amount_in"> </param>
        public async Task<string> SwapBForA(ulong amount_in, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 83, 12, 154 };
            var amount_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inAbi.From(amount_in);

            var result = await base.CallApp(new List<object> { abiHandle, amount_inAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SwapBForA_Transactions(ulong amount_in, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 83, 12, 154 };
            var amount_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inAbi.From(amount_in);

            return await base.MakeTransactionList(new List<object> { abiHandle, amount_inAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current reserves
        ///</summary>
        public async Task<Structs.GetReservesReturn> GetReserves(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 164, 62, 235 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
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
        ///Calculate output amount for a given input
        ///</summary>
        /// <param name="amount_in"> </param>
        /// <param name="reserve_in"> </param>
        /// <param name="reserve_out"> </param>
        public async Task<ulong> GetAmountOut(ulong amount_in, ulong reserve_in, ulong reserve_out, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 154, 192, 170 };
            var amount_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inAbi.From(amount_in);
            var reserve_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reserve_inAbi.From(reserve_in);
            var reserve_outAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reserve_outAbi.From(reserve_out);

            var result = await base.SimApp(new List<object> { abiHandle, amount_inAbi, reserve_inAbi, reserve_outAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAmountOut_Transactions(ulong amount_in, ulong reserve_in, ulong reserve_out, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 154, 192, 170 };
            var amount_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_inAbi.From(amount_in);
            var reserve_inAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reserve_inAbi.From(reserve_in);
            var reserve_outAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reserve_outAbi.From(reserve_out);

            return await base.MakeTransactionList(new List<object> { abiHandle, amount_inAbi, reserve_inAbi, reserve_outAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user's liquidity position
        ///</summary>
        public async Task<Structs.GetUserLiquidityReturn> GetUserLiquidity(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 229, 153, 119 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserLiquidityReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUserLiquidity_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 229, 153, 119 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get pool information
        ///</summary>
        public async Task<Structs.GetPoolInfoReturn> GetPoolInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 245, 93, 182 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetPoolInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPoolInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 245, 93, 182 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Remove liquidity from the pool
        ///</summary>
        /// <param name="liquidity_amount"> </param>
        public async Task<string> RemoveLiquidity(ulong liquidity_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 22, 8, 58 };
            var liquidity_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); liquidity_amountAbi.From(liquidity_amount);

            var result = await base.CallApp(new List<object> { abiHandle, liquidity_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RemoveLiquidity_Transactions(ulong liquidity_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 22, 8, 58 };
            var liquidity_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); liquidity_amountAbi.From(liquidity_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, liquidity_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set swap fee rate (admin only)
        ///</summary>
        /// <param name="new_fee"> </param>
        public async Task<string> SetFeeRate(ulong new_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 241, 37, 67 };
            var new_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_feeAbi.From(new_fee);

            var result = await base.CallApp(new List<object> { abiHandle, new_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SetFeeRate_Transactions(ulong new_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 241, 37, 67 };
            var new_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_feeAbi.From(new_fee);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Pause the AMM (admin only)
        ///</summary>
        public async Task<string> PauseAmm(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 167, 246, 128 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> PauseAmm_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 167, 246, 128 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Unpause the AMM (admin only)
        ///</summary>
        public async Task<string> UnpauseAmm(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 96, 156, 155 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UnpauseAmm_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 96, 156, 155 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2ltcGxlQU1NIiwiZGVzYyI6IlNpbXBsZSBBTU0gZm9yIFBUL1lUIHRva2VuIHRyYWRpbmciLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0UmVzZXJ2ZXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0VXNlckxpcXVpZGl0eVJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0UG9vbEluZm9SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRpYWxpemUiLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgQU1NIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX2xpcXVpZGl0eSIsImRlc2MiOiJBZGQgbGlxdWlkaXR5IHRvIHRoZSBwb29sIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudF9hIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRfYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN3YXBfYV9mb3JfYiIsImRlc2MiOiJTd2FwIHRva2VuIEEgZm9yIHRva2VuIEIiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50X2luIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3dhcF9iX2Zvcl9hIiwiZGVzYyI6IlN3YXAgdG9rZW4gQiBmb3IgdG9rZW4gQSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRfaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcmVzZXJ2ZXMiLCJkZXNjIjoiR2V0IGN1cnJlbnQgcmVzZXJ2ZXMiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0UmVzZXJ2ZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hbW91bnRfb3V0IiwiZGVzYyI6IkNhbGN1bGF0ZSBvdXRwdXQgYW1vdW50IGZvciBhIGdpdmVuIGlucHV0IiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudF9pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzZXJ2ZV9pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzZXJ2ZV9vdXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF91c2VyX2xpcXVpZGl0eSIsImRlc2MiOiJHZXQgdXNlcidzIGxpcXVpZGl0eSBwb3NpdGlvbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0VXNlckxpcXVpZGl0eVJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3Bvb2xfaW5mbyIsImRlc2MiOiJHZXQgcG9vbCBpbmZvcm1hdGlvbiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFBvb2xJbmZvUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW1vdmVfbGlxdWlkaXR5IiwiZGVzYyI6IlJlbW92ZSBsaXF1aWRpdHkgZnJvbSB0aGUgcG9vbCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsaXF1aWRpdHlfYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2ZlZV9yYXRlIiwiZGVzYyI6IlNldCBzd2FwIGZlZSByYXRlIChhZG1pbiBvbmx5KSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfZmVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2VfYW1tIiwiZGVzYyI6IlBhdXNlIHRoZSBBTU0gKGFkbWluIG9ubHkpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5wYXVzZV9hbW0iLCJkZXNjIjoiVW5wYXVzZSB0aGUgQU1NIChhZG1pbiBvbmx5KSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo2LCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjMsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNzE4LDEwNzksMTE5MywxMzk0XSwiZXJyb3JNZXNzYWdlIjoiQU1NIGlzIHBhdXNlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwODIsMTE5NiwxMzk3LDE3NTRdLCJlcnJvck1lc3NhZ2UiOiJBbW91bnQgbXVzdCBiZSBwb3NpdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczMF0sImVycm9yTWVzc2FnZSI6IkFtb3VudHMgbXVzdCBiZSBwb3NpdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MzBdLCJlcnJvck1lc3NhZ2UiOiJGZWUgdG9vIGhpZ2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTA3LDExMjksMTIyMSwxMjQzLDE3NjZdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgbGlxdWlkaXR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQwOV0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBsaXF1aWRpdHkgYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMjQsMTIzOF0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBvdXRwdXQgYW1vdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIwLDM0NCwzNjgsMzk2LDQyNCw0NDAsNDU2LDQ4NSw1MDEsNTI5LDU1Nyw1ODldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzE5XSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gcGF1c2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjIxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gc2V0IGZlZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MzhdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiB1bnBhdXNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI2XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBpbml0aWFsaXplIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjE4XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIzLDM0NywzNzEsMzk5LDQyNyw0NDMsNDU5LDQ4OCw1MDQsNTMyLDU2MCw1OTJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYxOSwxNzE3LDE3MzZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2MjYsMTc3MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZmVlX2Rlbm9taW5hdG9yIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNzIsMTYzNSwxNzc2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5mZWVfcmF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MTYsMTA3NywxMTkxLDEzOTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmlzX3BhdXNlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDE1LDEzMjksMTQwNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubGlxdWlkaXR5X2JhbGFuY2UgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQwLDEwOTAsMTIwNCwxMzAxLDEzNTYsMTQxM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucmVzZXJ2ZV9hIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0NywxMDk3LDEyMTEsMTMwNiwxMzYxLDE0MTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlc2VydmVfYiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OTIsMTMzNywxNDg1LDE0OTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRva2VuX2FfZGVwb3NpdGVkIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgwOSwxMzQ1LDE1MTMsMTUyNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG9rZW5fYl9kZXBvc2l0ZWQgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwMywxMDI5LDEwNTcsMTM2NiwxNDIxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9saXF1aWRpdHkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMmx0Y0d4bFgyRnRiUzVqYjI1MGNtRmpkQzVUYVcxd2JHVkJUVTB1WDE5aGJHZHZjSGxmWlc1MGNubHdiMmx1ZEY5M2FYUm9YMmx1YVhRb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElESUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0luSmxjMlZ5ZG1WZllTSWdJbkpsYzJWeWRtVmZZaUlnTUhneE5URm1OMk0zTlNBaWRHOTBZV3hmYkdseGRXbGthWFI1SWlBaWFYTmZjR0YxYzJWa0lpQWliR2x4ZFdsa2FYUjVYMkpoYkdGdVkyVWlJQ0owYjJ0bGJsOWhYMlJsY0c5emFYUmxaQ0lnSW5SdmEyVnVYMkpmWkdWd2IzTnBkR1ZrSWlBaVptVmxYM0poZEdVaUlDSmhaRzFwYmlJZ0ltWmxaVjlrWlc1dmJXbHVZWFJ2Y2lJZ01IZ3lNRFF5TTJFeU1DQXdlREl3TkdZM05UYzBNMkV5TUNBaVUzZGhjQ0JqYjIxd2JHVjBaV1FnYzNWalkyVnpjMloxYkd4NUlpQXdlRFF4TkdRMFpESXdOekEyTVRjMU56TTJOVFkwSURCNE5ERTBaRFJrTWpBM05UWmxOekEyTVRjMU56TTJOVFkwQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG8wTXkwME5Bb2dJQ0FnTHk4Z0l5QkRiMjV6ZEdGdWRITUtJQ0FnSUM4dklITmxiR1l1Wm1WbFgyUmxibTl0YVc1aGRHOXlJRDBnVlVsdWREWTBLREV3TURBcENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaVptVmxYMlJsYm05dGFXNWhkRzl5SWdvZ0lDQWdjSFZ6YUdsdWRDQXhNREF3SUM4dklERXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJqYkdGemN5QlRhVzF3YkdWQlRVMG9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE53b2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEZzVOMkZrTVdFM0lEQjROamhrTldVMU5HWWdNSGcyWXpWbE5tSmpZaUF3ZUdNMU5UTXdZemxoSURCNFlqVmhORE5sWldJZ01IaGlPVGxoWXpCaFlTQXdlR1ppWlRVNU9UYzNJREI0TkdKbU5UVmtZallnTUhoaU9URTJNRGd6WVNBd2VEa3haakV5TlRReklEQjRZamhoTjJZMk9EQWdNSGd6T0RZd09XTTVZaUF2THlCdFpYUm9iMlFnSW1sdWFYUnBZV3hwZW1Vb0tYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVlXUmtYMnhwY1hWcFpHbDBlU2gxYVc1ME5qUXNkV2x1ZERZMEtYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWMzZGhjRjloWDJadmNsOWlLSFZwYm5RMk5DbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luTjNZWEJmWWw5bWIzSmZZU2gxYVc1ME5qUXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSm5aWFJmY21WelpYSjJaWE1vS1NoMWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWjJWMFgyRnRiM1Z1ZEY5dmRYUW9kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSZmRYTmxjbDlzYVhGMWFXUnBkSGtvS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEY5d2IyOXNYMmx1Wm04b0tTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0p5WlcxdmRtVmZiR2x4ZFdsa2FYUjVLSFZwYm5RMk5DbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luTmxkRjltWldWZmNtRjBaU2gxYVc1ME5qUXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSndZWFZ6WlY5aGJXMG9LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlkVzV3WVhWelpWOWhiVzBvS1hOMGNtbHVaeUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZhVzVwZEdsaGJHbDZaVjl5YjNWMFpVQTFJRzFoYVc1ZllXUmtYMnhwY1hWcFpHbDBlVjl5YjNWMFpVQTJJRzFoYVc1ZmMzZGhjRjloWDJadmNsOWlYM0p2ZFhSbFFEY2diV0ZwYmw5emQyRndYMkpmWm05eVgyRmZjbTkxZEdWQU9DQnRZV2x1WDJkbGRGOXlaWE5sY25abGMxOXliM1YwWlVBNUlHMWhhVzVmWjJWMFgyRnRiM1Z1ZEY5dmRYUmZjbTkxZEdWQU1UQWdiV0ZwYmw5blpYUmZkWE5sY2w5c2FYRjFhV1JwZEhsZmNtOTFkR1ZBTVRFZ2JXRnBibDluWlhSZmNHOXZiRjlwYm1adlgzSnZkWFJsUURFeUlHMWhhVzVmY21WdGIzWmxYMnhwY1hWcFpHbDBlVjl5YjNWMFpVQXhNeUJ0WVdsdVgzTmxkRjltWldWZmNtRjBaVjl5YjNWMFpVQXhOQ0J0WVdsdVgzQmhkWE5sWDJGdGJWOXliM1YwWlVBeE5TQnRZV2x1WDNWdWNHRjFjMlZmWVcxdFgzSnZkWFJsUURFMkNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRvek1Rb2dJQ0FnTHk4Z1kyeGhjM01nVTJsdGNHeGxRVTFOS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzVnVjR0YxYzJWZllXMXRYM0p2ZFhSbFFERTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2TWpVMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCMWJuQmhkWE5sWDJGdGJRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmY0dGMWMyVmZZVzF0WDNKdmRYUmxRREUxT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk1qUTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQndZWFZ6WlY5aGJXMEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNObGRGOW1aV1ZmY21GMFpWOXliM1YwWlVBeE5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPakl6TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJqYkdGemN5QlRhVzF3YkdWQlRVMG9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qSXpOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJSE5sZEY5bVpXVmZjbUYwWlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjbVZ0YjNabFgyeHBjWFZwWkdsMGVWOXliM1YwWlVBeE16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPakl3TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJqYkdGemN5QlRhVzF3YkdWQlRVMG9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qSXdNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJSEpsYlc5MlpWOXNhWEYxYVdScGRIa0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOXdiMjlzWDJsdVptOWZjbTkxZEdWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG94T1RFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5d2IyOXNYMmx1Wm04S0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgzVnpaWEpmYkdseGRXbGthWFI1WDNKdmRYUmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk1UZ3lDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUmZkWE5sY2w5c2FYRjFhV1JwZEhrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgyRnRiM1Z1ZEY5dmRYUmZjbTkxZEdWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG94TnpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3pNUW9nSUNBZ0x5OGdZMnhoYzNNZ1UybHRjR3hsUVUxTktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRveE56SUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZZVzF2ZFc1MFgyOTFkQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmY21WelpYSjJaWE5mY205MWRHVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pFMk53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzSmxjMlZ5ZG1WekNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNOM1lYQmZZbDltYjNKZllWOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNVFEwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNekVLSUNBZ0lDOHZJR05zWVhOeklGTnBiWEJzWlVGTlRTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk1UUTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdjM2RoY0Y5aVgyWnZjbDloQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpkMkZ3WDJGZlptOXlYMkpmY205MWRHVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pFeU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pNeENpQWdJQ0F2THlCamJHRnpjeUJUYVcxd2JHVkJUVTBvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPakV5TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhOM1lYQmZZVjltYjNKZllnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVdSa1gyeHBjWFZwWkdsMGVWOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZOallLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3pNUW9nSUNBZ0x5OGdZMnhoYzNNZ1UybHRjR3hsUVUxTktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRvMk5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlHRmtaRjlzYVhGMWFXUnBkSGtLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgybHVhWFJwWVd4cGVtVmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPalV4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJwYm1sMGFXRnNhWHBsQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3pNUW9nSUNBZ0x5OGdZMnhoYzNNZ1UybHRjR3hsUVUxTktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTVDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6YVcxd2JHVmZZVzF0TG1OdmJuUnlZV04wTGxOcGJYQnNaVUZOVFM1cGJtbDBhV0ZzYVhwbEtDa2dMVDRnWW5sMFpYTTZDbWx1YVhScFlXeHBlbVU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0lrOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2FXNXBkR2xoYkdsNlpTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOeVpXRjBiM0lnWTJGdUlHbHVhWFJwWVd4cGVtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPalUyQ2lBZ0lDQXZMeUJ6Wld4bUxtRmtiV2x1TG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2k1aWVYUmxjd29nSUNBZ1lubDBaV01nT1NBdkx5QWlZV1J0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk5UY0tJQ0FnSUM4dklITmxiR1l1Y21WelpYSjJaVjloTG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p5WlhObGNuWmxYMkVpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pVNENpQWdJQ0F2THlCelpXeG1MbkpsYzJWeWRtVmZZaTUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWljbVZ6WlhKMlpWOWlJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG8xT1FvZ0lDQWdMeThnYzJWc1ppNW1aV1ZmY21GMFpTNTJZV3gxWlNBOUlGVkpiblEyTkNnektTQWdJeUF3TGpNbENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKbVpXVmZjbUYwWlNJS0lDQWdJSEIxYzJocGJuUWdNeUF2THlBekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZOakFLSUNBZ0lDOHZJSE5sYkdZdWFYTmZjR0YxYzJWa0xuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKcGMxOXdZWFZ6WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qWXhDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMnhwY1hWcFpHbDBlUzUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzkwWVd4ZmJHbHhkV2xrYVhSNUlnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUbzJNd29nSUNBZ0x5OGdiRzluS0dJaVUybHRjR3hsUVUxTklHbHVhWFJwWVd4cGVtVmtJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFV6TmprMlpEY3dObU0yTlRReE5HUTBaREl3TmprMlpUWTVOelEyT1RZeE5tTTJPVGRoTmpVMk5Bb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUbzJOQW9nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVFVMU5JR2x1YVhScFlXeHBlbVZrSUhOMVkyTmxjM05tZFd4c2VTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrRk5UU0JwYm1sMGFXRnNhWHBsWkNCemRXTmpaWE56Wm5Wc2JIa2lDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMybHRjR3hsWDJGdGJTNWpiMjUwY21GamRDNVRhVzF3YkdWQlRVMHVZV1JrWDJ4cGNYVnBaR2wwZVNoaGJXOTFiblJmWVRvZ2RXbHVkRFkwTENCaGJXOTFiblJmWWpvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1lXUmtYMnhwY1hWcFpHbDBlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pZMkxUY3hDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQmhaR1JmYkdseGRXbGthWFI1S0FvZ0lDQWdMeThnSUNBZ0lITmxiR1lzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwWDJFNklGVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5SZllqb2dWVWx1ZERZMExBb2dJQ0FnTHk4Z0tTQXRQaUJUZEhKcGJtYzZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaSFZ3YmlBM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUbzNNd29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1YVhOZmNHRjFjMlZrTG5aaGJIVmxJRDA5SUZWSmJuUTJOQ2d3S1N3Z0lrRk5UU0JwY3lCd1lYVnpaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlhWE5mY0dGMWMyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgzQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQlRVMGdhWE1nY0dGMWMyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG8zTkFvZ0lDQWdMeThnWVhOelpYSjBJR0Z0YjNWdWRGOWhJRDRnVlVsdWREWTBLREFwSUdGdVpDQmhiVzkxYm5SZllpQStJRlZKYm5RMk5DZ3dLU3dnSWtGdGIzVnVkSE1nYlhWemRDQmlaU0J3YjNOcGRHbDJaU0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lub2dZV1JrWDJ4cGNYVnBaR2wwZVY5aWIyOXNYMlpoYkhObFFETUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5vZ1lXUmtYMnhwY1hWcFpHbDBlVjlpYjI5c1gyWmhiSE5sUURNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwaFpHUmZiR2x4ZFdsa2FYUjVYMkp2YjJ4ZmJXVnlaMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QmhjM05sY25RZ1lXMXZkVzUwWDJFZ1BpQlZTVzUwTmpRb01Da2dZVzVrSUdGdGIzVnVkRjlpSUQ0Z1ZVbHVkRFkwS0RBcExDQWlRVzF2ZFc1MGN5QnRkWE4wSUdKbElIQnZjMmwwYVhabElnb2dJQ0FnWVhOelpYSjBJQzh2SUVGdGIzVnVkSE1nYlhWemRDQmlaU0J3YjNOcGRHbDJaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2TnpZS0lDQWdJQzh2SUdOMWNuSmxiblJmY21WelpYSjJaVjloSUQwZ2MyVnNaaTV5WlhObGNuWmxYMkV1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKeVpYTmxjblpsWDJFaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsYzJWeWRtVmZZU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPamMzQ2lBZ0lDQXZMeUJqZFhKeVpXNTBYM0psYzJWeWRtVmZZaUE5SUhObGJHWXVjbVZ6WlhKMlpWOWlMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY21WelpYSjJaVjlpSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVnpaWEoyWlY5aUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk56a3RPREFLSUNBZ0lDOHZJQ01nUm05eUlHWnBjbk4wSUd4cGNYVnBaR2wwZVNCd2NtOTJhWE5wYjI0c0lHRmpZMlZ3ZENCaGJua2djbUYwYVc4S0lDQWdJQzh2SUdsbUlHTjFjbkpsYm5SZmNtVnpaWEoyWlY5aElEMDlJRlZKYm5RMk5DZ3dLU0JoYm1RZ1kzVnljbVZ1ZEY5eVpYTmxjblpsWDJJZ1BUMGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1ltNTZJR0ZrWkY5c2FYRjFhV1JwZEhsZlpXeHpaVjlpYjJSNVFEY0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JpYm5vZ1lXUmtYMnhwY1hWcFpHbDBlVjlsYkhObFgySnZaSGxBTndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk9ERUtJQ0FnSUM4dklITmxiR1l1Y21WelpYSjJaVjloTG5aaGJIVmxJRDBnWVcxdmRXNTBYMkVLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkpsYzJWeWRtVmZZU0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pneUNpQWdJQ0F2THlCelpXeG1MbkpsYzJWeWRtVmZZaTUyWVd4MVpTQTlJR0Z0YjNWdWRGOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnlaWE5sY25abFgySWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG80TkMwNE5Rb2dJQ0FnTHk4Z0l5QkRZV3hqZFd4aGRHVWdhVzVwZEdsaGJDQnNhWEYxYVdScGRIa2dkRzlyWlc1eklDaG5aVzl0WlhSeWFXTWdiV1ZoYmlrS0lDQWdJQzh2SUd4cGNYVnBaR2wwZVY5MGIydGxibk1nUFNCelpXeG1MbDl6Y1hKMEtHRnRiM1Z1ZEY5aElDb2dZVzF2ZFc1MFgySXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnS2dvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pJNE9Bb2dJQ0FnTHk4Z2FXWWdlQ0E5UFNCVlNXNTBOalFvTUNrNkNpQWdJQ0JpYm5vZ1lXUmtYMnhwY1hWcFpHbDBlVjloWm5SbGNsOXBabDlsYkhObFFERTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG95T0RrS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3BoWkdSZmJHbHhkV2xrYVhSNVgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5wYlhCc1pWOWhiVzB1WTI5dWRISmhZM1F1VTJsdGNHeGxRVTFOTGw5emNYSjBRREU1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk9EY0tJQ0FnSUM4dklITmxiR1l1YkdseGRXbGthWFI1WDJKaGJHRnVZMlZiVkhodUxuTmxibVJsY2wwZ1BTQnNhWEYxYVdScGRIbGZkRzlyWlc1ekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pzYVhGMWFXUnBkSGxmWW1Gc1lXNWpaU0lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRvNE9Bb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXNhWEYxYVdScGRIa3VkbUZzZFdVZ1BTQnNhWEYxYVdScGRIbGZkRzlyWlc1ekNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGIzUmhiRjlzYVhGMWFXUnBkSGtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS1lXUmtYMnhwY1hWcFpHbDBlVjloWm5SbGNsOXBabDlsYkhObFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2TVRFMExURXhOUW9nSUNBZ0x5OGdJeUJVY21GamF5QjFjMlZ5SUdSbGNHOXphWFJ6Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZhMlZ1WDJGZlpHVndiM05wZEdWa1cxUjRiaTV6Wlc1a1pYSmRJRDBnYzJWc1ppNTBiMnRsYmw5aFgyUmxjRzl6YVhSbFpGdFVlRzR1YzJWdVpHVnlYU0FySUdGdGIzVnVkRjloQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWRHOXJaVzVmWVY5a1pYQnZjMmwwWldRaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiMnRsYmw5aFgyUmxjRzl6YVhSbFpDQmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnS3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTmlBdkx5QWlkRzlyWlc1ZllWOWtaWEJ2YzJsMFpXUWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qRXhOZ29nSUNBZ0x5OGdjMlZzWmk1MGIydGxibDlpWDJSbGNHOXphWFJsWkZ0VWVHNHVjMlZ1WkdWeVhTQTlJSE5sYkdZdWRHOXJaVzVmWWw5a1pYQnZjMmwwWldSYlZIaHVMbk5sYm1SbGNsMGdLeUJoYlc5MWJuUmZZZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5SdmEyVnVYMkpmWkdWd2IzTnBkR1ZrSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOXJaVzVmWWw5a1pYQnZjMmwwWldRZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQ3NLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luUnZhMlZ1WDJKZlpHVndiM05wZEdWa0lnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRveE1UZ0tJQ0FnSUM4dklHeHZaeWhpSWt4cGNYVnBaR2wwZVNCaFpHUmxaQ0F0SUVFNklDSWdLeUJ2Y0M1cGRHOWlLR0Z0YjNWdWRGOWhLU0FySUdJaUlFSTZJQ0lnS3lCdmNDNXBkRzlpS0dGdGIzVnVkRjlpS1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkdNMk9UY3hOelUyT1RZME5qazNORGM1TWpBMk1UWTBOalEyTlRZME1qQXlaREl3TkRFellUSXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TWpBME1qTmhNakFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk1URTVDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKTWFYRjFhV1JwZEhrZ1lXUmtaV1FnYzNWalkyVnpjMloxYkd4NUlpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVRHbHhkV2xrYVhSNUlHRmtaR1ZrSUhOMVkyTmxjM05tZFd4c2VTSUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BoWkdSZmJHbHhkV2xrYVhSNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3lPVE1LSUNBZ0lDOHZJSGtnUFNBb2VDQXJJRlZKYm5RMk5DZ3hLU2tnTHk4Z1ZVbHVkRFkwS0RJcENpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQzhLSUNBZ0lHWnlZVzFsWDJKMWNua2dOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2TWprMUxUSTVOZ29nSUNBZ0x5OGdJeUJPWlhkMGIyNG5jeUJ0WlhSb2IyUWdhWFJsY21GMGFXOXVjeUFvYkdsdGFYUmxaQ0JtYjNJZ1oyRnpJR1ZtWm1samFXVnVZM2twQ2lBZ0lDQXZMeUJqYjNWdWRHVnlJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEY0tDbUZrWkY5c2FYRjFhV1JwZEhsZmQyaHBiR1ZmZEc5d1FERTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2TWprM0NpQWdJQ0F2THlCM2FHbHNaU0I1SUR3Z2VpQmhibVFnWTI5MWJuUmxjaUE4SUZWSmJuUTJOQ2d4TUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTmdvZ0lDQWdabkpoYldWZlpHbG5JRGNLSUNBZ0lEd0tJQ0FnSUdKNklHRmtaRjlzYVhGMWFXUnBkSGxmWVdaMFpYSmZkMmhwYkdWQU1UZ0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J3ZFhOb2FXNTBJREV3SUM4dklERXdDaUFnSUNBOENpQWdJQ0JpZWlCaFpHUmZiR2x4ZFdsa2FYUjVYMkZtZEdWeVgzZG9hV3hsUURFNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3lPVGtLSUNBZ0lDOHZJSGtnUFNBb2VDQXZMeUI1SUNzZ2VTa2dMeThnVlVsdWREWTBLRElwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOUW9nSUNBZ1puSmhiV1ZmWkdsbklEWUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x3b2dJQ0FnWkdsbklERUtJQ0FnSUNzS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG96TURBS0lDQWdJQzh2SUdOdmRXNTBaWElnUFNCamIzVnVkR1Z5SUNzZ1ZVbHVkRFkwS0RFcENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMkNpQWdJQ0JtY21GdFpWOWlkWEo1SURjS0lDQWdJR0lnWVdSa1gyeHBjWFZwWkdsMGVWOTNhR2xzWlY5MGIzQkFNVFVLQ21Ga1pGOXNhWEYxYVdScGRIbGZZV1owWlhKZmQyaHBiR1ZBTVRnNkNpQWdJQ0JtY21GdFpWOWthV2NnTndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk9EUXRPRFVLSUNBZ0lDOHZJQ01nUTJGc1kzVnNZWFJsSUdsdWFYUnBZV3dnYkdseGRXbGthWFI1SUhSdmEyVnVjeUFvWjJWdmJXVjBjbWxqSUcxbFlXNHBDaUFnSUNBdkx5QnNhWEYxYVdScGRIbGZkRzlyWlc1eklEMGdjMlZzWmk1ZmMzRnlkQ2hoYlc5MWJuUmZZU0FxSUdGdGIzVnVkRjlpS1FvZ0lDQWdZaUJoWkdSZmJHbHhkV2xrYVhSNVgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5wYlhCc1pWOWhiVzB1WTI5dWRISmhZM1F1VTJsdGNHeGxRVTFOTGw5emNYSjBRREU1Q2dwaFpHUmZiR2x4ZFdsa2FYUjVYMlZzYzJWZlltOWtlVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk9UQXRPVElLSUNBZ0lDOHZJQ01nVFdGcGJuUmhhVzRnWTNWeWNtVnVkQ0J5WVhScGJ5Qm1iM0lnYzNWaWMyVnhkV1Z1ZENCaFpHUnBkR2x2Ym5NS0lDQWdJQzh2SUNNZ1EyRnNZM1ZzWVhSbElISmxjWFZwY21Wa0lHRnRiM1Z1ZEhNZ2RHOGdiV0ZwYm5SaGFXNGdjbUYwYVc4S0lDQWdJQzh2SUhKbGNYVnBjbVZrWDJJZ1BTQW9ZVzF2ZFc1MFgyRWdLaUJqZFhKeVpXNTBYM0psYzJWeWRtVmZZaWtnTHk4Z1kzVnljbVZ1ZEY5eVpYTmxjblpsWDJFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdLZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x3b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbWNtRnRaVjlpZFhKNUlEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPamt6Q2lBZ0lDQXZMeUJ5WlhGMWFYSmxaRjloSUQwZ0tHRnRiM1Z1ZEY5aUlDb2dZM1Z5Y21WdWRGOXlaWE5sY25abFgyRXBJQzh2SUdOMWNuSmxiblJmY21WelpYSjJaVjlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDb0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdMd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG81TlMwNU5nb2dJQ0FnTHk4Z0l5QlZjMlVnZEdobElITnRZV3hzWlhJZ2NtRjBhVzhnZEc4Z1lYWnZhV1FnYjNabGNpMWtaWEJ2YzJsMGFXNW5DaUFnSUNBdkx5QnBaaUJ5WlhGMWFYSmxaRjlpSUR3OUlHRnRiM1Z1ZEY5aU9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E4UFFvZ0lDQWdZbm9nWVdSa1gyeHBjWFZwWkdsMGVWOWxiSE5sWDJKdlpIbEFPUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2T1RjdE9UZ0tJQ0FnSUM4dklDTWdWWE5sSUdGdGIzVnVkRjloSUdGdVpDQmpZV3hqZFd4aGRHVmtJSEpsY1hWcGNtVmtYMklLSUNBZ0lDOHZJSE5sYkdZdWNtVnpaWEoyWlY5aExuWmhiSFZsSUQwZ1kzVnljbVZ1ZEY5eVpYTmxjblpsWDJFZ0t5QmhiVzkxYm5SZllRb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnlaWE5sY25abFgyRWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2T1RrS0lDQWdJQzh2SUhObGJHWXVjbVZ6WlhKMlpWOWlMblpoYkhWbElEMGdZM1Z5Y21WdWRGOXlaWE5sY25abFgySWdLeUJ5WlhGMWFYSmxaRjlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5KbGMyVnlkbVZmWWlJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3hNREV0TVRBeUNpQWdJQ0F2THlBaklFTmhiR04xYkdGMFpTQnNhWEYxYVdScGRIa2dkRzlyWlc1eklIQnliM0J2Y25ScGIyNWhiQ0IwYnlCamIyNTBjbWxpZFhScGIyNEtJQ0FnSUM4dklHeHBjWFZwWkdsMGVWOTBiMnRsYm5NZ1BTQW9ZVzF2ZFc1MFgyRWdLaUJ6Wld4bUxuUnZkR0ZzWDJ4cGNYVnBaR2wwZVM1MllXeDFaU2tnTHk4Z1kzVnljbVZ1ZEY5eVpYTmxjblpsWDJFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYjNSaGJGOXNhWEYxYVdScGRIa2lDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZiR2x4ZFdsa2FYUjVJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0FxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZDZ3BoWkdSZmJHbHhkV2xrYVhSNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3hNVEVLSUNBZ0lDOHZJSE5sYkdZdWJHbHhkV2xrYVhSNVgySmhiR0Z1WTJWYlZIaHVMbk5sYm1SbGNsMGdQU0J6Wld4bUxteHBjWFZwWkdsMGVWOWlZV3hoYm1ObFcxUjRiaTV6Wlc1a1pYSmRJQ3NnYkdseGRXbGthWFI1WDNSdmEyVnVjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW14cGNYVnBaR2wwZVY5aVlXeGhibU5sSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJHbHhkV2xrYVhSNVgySmhiR0Z1WTJVZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JrYVdjZ01Rb2dJQ0FnS3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTlNBdkx5QWliR2x4ZFdsa2FYUjVYMkpoYkdGdVkyVWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qRXhNZ29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjlzYVhGMWFXUnBkSGt1ZG1Gc2RXVWdQU0J6Wld4bUxuUnZkR0ZzWDJ4cGNYVnBaR2wwZVM1MllXeDFaU0FySUd4cGNYVnBaR2wwZVY5MGIydGxibk1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiM1JoYkY5c2FYRjFhV1JwZEhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmJHbHhkV2xrYVhSNUlHVjRhWE4wY3dvZ0lDQWdLd29nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzkwWVd4ZmJHbHhkV2xrYVhSNUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdJZ1lXUmtYMnhwY1hWcFpHbDBlVjloWm5SbGNsOXBabDlsYkhObFFERXhDZ3BoWkdSZmJHbHhkV2xrYVhSNVgyVnNjMlZmWW05a2VVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2TVRBMExURXdOUW9nSUNBZ0x5OGdJeUJWYzJVZ1lXMXZkVzUwWDJJZ1lXNWtJR05oYkdOMWJHRjBaV1FnY21WeGRXbHlaV1JmWVFvZ0lDQWdMeThnYzJWc1ppNXlaWE5sY25abFgyRXVkbUZzZFdVZ1BTQmpkWEp5Wlc1MFgzSmxjMlZ5ZG1WZllTQXJJSEpsY1hWcGNtVmtYMkVLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY21WelpYSjJaVjloSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qRXdOZ29nSUNBZ0x5OGdjMlZzWmk1eVpYTmxjblpsWDJJdWRtRnNkV1VnUFNCamRYSnlaVzUwWDNKbGMyVnlkbVZmWWlBcklHRnRiM1Z1ZEY5aUNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luSmxjMlZ5ZG1WZllpSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG94TURndE1UQTVDaUFnSUNBdkx5QWpJRU5oYkdOMWJHRjBaU0JzYVhGMWFXUnBkSGtnZEc5clpXNXpJSEJ5YjNCdmNuUnBiMjVoYkNCMGJ5QmpiMjUwY21saWRYUnBiMjRLSUNBZ0lDOHZJR3hwY1hWcFpHbDBlVjkwYjJ0bGJuTWdQU0FvWVcxdmRXNTBYMklnS2lCelpXeG1MblJ2ZEdGc1gyeHBjWFZwWkdsMGVTNTJZV3gxWlNrZ0x5OGdZM1Z5Y21WdWRGOXlaWE5sY25abFgySUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGIzUmhiRjlzYVhGMWFXUnBkSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYkdseGRXbGthWFI1SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBcUNpQWdJQ0J6ZDJGd0NpQWdJQ0F2Q2lBZ0lDQmlJR0ZrWkY5c2FYRjFhV1JwZEhsZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvS1lXUmtYMnhwY1hWcFpHbDBlVjlpYjI5c1gyWmhiSE5sUURNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJoWkdSZmJHbHhkV2xrYVhSNVgySnZiMnhmYldWeVoyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1emFXMXdiR1ZmWVcxdExtTnZiblJ5WVdOMExsTnBiWEJzWlVGTlRTNXpkMkZ3WDJGZlptOXlYMklvWVcxdmRXNTBYMmx1T2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwemQyRndYMkZmWm05eVgySTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG94TWpFdE1USXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQnpkMkZ3WDJGZlptOXlYMklvYzJWc1ppd2dZVzF2ZFc1MFgybHVPaUJWU1c1ME5qUXBJQzArSUZOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNVEkwQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1cGMxOXdZWFZ6WldRdWRtRnNkV1VnUFQwZ1ZVbHVkRFkwS0RBcExDQWlRVTFOSUdseklIQmhkWE5sWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pwYzE5d1lYVnpaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFYTmZjR0YxYzJWa0lHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRk5UU0JwY3lCd1lYVnpaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pFeU5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdGdGIzVnVkRjlwYmlBK0lGVkpiblEyTkNnd0tTd2dJa0Z0YjNWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoYzNObGNuUWdMeThnUVcxdmRXNTBJRzExYzNRZ1ltVWdjRzl6YVhScGRtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPakV5TndvZ0lDQWdMeThnWTNWeWNtVnVkRjl5WlhObGNuWmxYMkVnUFNCelpXeG1MbkpsYzJWeWRtVmZZUzUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5KbGMyVnlkbVZmWVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y21WelpYSjJaVjloSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2TVRJNENpQWdJQ0F2THlCamRYSnlaVzUwWDNKbGMyVnlkbVZmWWlBOUlITmxiR1l1Y21WelpYSjJaVjlpTG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNtVnpaWEoyWlY5aUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5KbGMyVnlkbVZmWWlCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pFek1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdOMWNuSmxiblJmY21WelpYSjJaVjloSUQ0Z1ZVbHVkRFkwS0RBcElHRnVaQ0JqZFhKeVpXNTBYM0psYzJWeWRtVmZZaUErSUZWSmJuUTJOQ2d3S1N3Z0lrbHVjM1ZtWm1samFXVnVkQ0JzYVhGMWFXUnBkSGtpQ2lBZ0lDQmllaUJ6ZDJGd1gyRmZabTl5WDJKZlltOXZiRjltWVd4elpVQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWW5vZ2MzZGhjRjloWDJadmNsOWlYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ25OM1lYQmZZVjltYjNKZllsOWliMjlzWDIxbGNtZGxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRveE16QUtJQ0FnSUM4dklHRnpjMlZ5ZENCamRYSnlaVzUwWDNKbGMyVnlkbVZmWVNBK0lGVkpiblEyTkNnd0tTQmhibVFnWTNWeWNtVnVkRjl5WlhObGNuWmxYMklnUGlCVlNXNTBOalFvTUNrc0lDSkpibk4xWm1acFkybGxiblFnYkdseGRXbGthWFI1SWdvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCc2FYRjFhV1JwZEhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qRXpNaTB4TXpNS0lDQWdJQzh2SUNNZ1EyRnNZM1ZzWVhSbElHOTFkSEIxZENCaGJXOTFiblFnZFhOcGJtY2dZMjl1YzNSaGJuUWdjSEp2WkhWamRDQm1iM0p0ZFd4aElIZHBkR2dnWm1WbGN3b2dJQ0FnTHk4Z1lXMXZkVzUwWDI5MWRDQTlJSE5sYkdZdVgyZGxkRjloYlc5MWJuUmZiM1YwS0dGdGIzVnVkRjlwYml3Z1kzVnljbVZ1ZEY5eVpYTmxjblpsWDJFc0lHTjFjbkpsYm5SZmNtVnpaWEoyWlY5aUtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JqWVd4c2MzVmlJRjluWlhSZllXMXZkVzUwWDI5MWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNVE0wQ2lBZ0lDQXZMeUJoYzNObGNuUWdZVzF2ZFc1MFgyOTFkQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lrbHVjM1ZtWm1samFXVnVkQ0J2ZFhSd2RYUWdZVzF2ZFc1MElnb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnU1c1emRXWm1hV05wWlc1MElHOTFkSEIxZENCaGJXOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pFek5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdGdGIzVnVkRjl2ZFhRZ1BEMGdZM1Z5Y21WdWRGOXlaWE5sY25abFgySXNJQ0pKYm5OMVptWnBZMmxsYm5RZ2JHbHhkV2xrYVhSNUlnb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ2JHbHhkV2xrYVhSNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3hNemN0TVRNNENpQWdJQ0F2THlBaklGVndaR0YwWlNCeVpYTmxjblpsY3dvZ0lDQWdMeThnYzJWc1ppNXlaWE5sY25abFgyRXVkbUZzZFdVZ1BTQmpkWEp5Wlc1MFgzSmxjMlZ5ZG1WZllTQXJJR0Z0YjNWdWRGOXBiZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkpsYzJWeWRtVmZZU0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRveE16a0tJQ0FnSUM4dklITmxiR1l1Y21WelpYSjJaVjlpTG5aaGJIVmxJRDBnWTNWeWNtVnVkRjl5WlhObGNuWmxYMklnTFNCaGJXOTFiblJmYjNWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnTFFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY21WelpYSjJaVjlpSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qRTBNUW9nSUNBZ0x5OGdiRzluS0dJaVUzZGhjQ0JCTFQ1Q0lDMGdTVzQ2SUNJZ0t5QnZjQzVwZEc5aUtHRnRiM1Z1ZEY5cGJpa2dLeUJpSWlCUGRYUTZJQ0lnS3lCdmNDNXBkRzlpS0dGdGIzVnVkRjl2ZFhRcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMU16YzNOakUzTURJd05ERXlaRE5sTkRJeU1ESmtNakEwT1RabE0yRXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUF3ZURJd05HWTNOVGMwTTJFeU1Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2TVRReUNpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pUZDJGd0lHTnZiWEJzWlhSbFpDQnpkV05qWlhOelpuVnNiSGtpS1FvZ0lDQWdZbmwwWldNZ01UTWdMeThnSWxOM1lYQWdZMjl0Y0d4bGRHVmtJSE4xWTJObGMzTm1kV3hzZVNJS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncHpkMkZ3WDJGZlptOXlYMkpmWW05dmJGOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYzNkaGNGOWhYMlp2Y2w5aVgySnZiMnhmYldWeVoyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1emFXMXdiR1ZmWVcxdExtTnZiblJ5WVdOMExsTnBiWEJzWlVGTlRTNXpkMkZ3WDJKZlptOXlYMkVvWVcxdmRXNTBYMmx1T2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwemQyRndYMkpmWm05eVgyRTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG94TkRRdE1UUTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQnpkMkZ3WDJKZlptOXlYMkVvYzJWc1ppd2dZVzF2ZFc1MFgybHVPaUJWU1c1ME5qUXBJQzArSUZOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNVFEzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1cGMxOXdZWFZ6WldRdWRtRnNkV1VnUFQwZ1ZVbHVkRFkwS0RBcExDQWlRVTFOSUdseklIQmhkWE5sWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pwYzE5d1lYVnpaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFYTmZjR0YxYzJWa0lHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRk5UU0JwY3lCd1lYVnpaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pFME9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdGdGIzVnVkRjlwYmlBK0lGVkpiblEyTkNnd0tTd2dJa0Z0YjNWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoYzNObGNuUWdMeThnUVcxdmRXNTBJRzExYzNRZ1ltVWdjRzl6YVhScGRtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPakUxTUFvZ0lDQWdMeThnWTNWeWNtVnVkRjl5WlhObGNuWmxYMkVnUFNCelpXeG1MbkpsYzJWeWRtVmZZUzUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5KbGMyVnlkbVZmWVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y21WelpYSjJaVjloSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2TVRVeENpQWdJQ0F2THlCamRYSnlaVzUwWDNKbGMyVnlkbVZmWWlBOUlITmxiR1l1Y21WelpYSjJaVjlpTG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNtVnpaWEoyWlY5aUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5KbGMyVnlkbVZmWWlCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pFMU13b2dJQ0FnTHk4Z1lYTnpaWEowSUdOMWNuSmxiblJmY21WelpYSjJaVjloSUQ0Z1ZVbHVkRFkwS0RBcElHRnVaQ0JqZFhKeVpXNTBYM0psYzJWeWRtVmZZaUErSUZWSmJuUTJOQ2d3S1N3Z0lrbHVjM1ZtWm1samFXVnVkQ0JzYVhGMWFXUnBkSGtpQ2lBZ0lDQmllaUJ6ZDJGd1gySmZabTl5WDJGZlltOXZiRjltWVd4elpVQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWW5vZ2MzZGhjRjlpWDJadmNsOWhYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ25OM1lYQmZZbDltYjNKZllWOWliMjlzWDIxbGNtZGxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRveE5UTUtJQ0FnSUM4dklHRnpjMlZ5ZENCamRYSnlaVzUwWDNKbGMyVnlkbVZmWVNBK0lGVkpiblEyTkNnd0tTQmhibVFnWTNWeWNtVnVkRjl5WlhObGNuWmxYMklnUGlCVlNXNTBOalFvTUNrc0lDSkpibk4xWm1acFkybGxiblFnYkdseGRXbGthWFI1SWdvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCc2FYRjFhV1JwZEhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qRTFOUzB4TlRZS0lDQWdJQzh2SUNNZ1EyRnNZM1ZzWVhSbElHOTFkSEIxZENCaGJXOTFiblFnZFhOcGJtY2dZMjl1YzNSaGJuUWdjSEp2WkhWamRDQm1iM0p0ZFd4aElIZHBkR2dnWm1WbGN3b2dJQ0FnTHk4Z1lXMXZkVzUwWDI5MWRDQTlJSE5sYkdZdVgyZGxkRjloYlc5MWJuUmZiM1YwS0dGdGIzVnVkRjlwYml3Z1kzVnljbVZ1ZEY5eVpYTmxjblpsWDJJc0lHTjFjbkpsYm5SZmNtVnpaWEoyWlY5aEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JqWVd4c2MzVmlJRjluWlhSZllXMXZkVzUwWDI5MWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNVFUzQ2lBZ0lDQXZMeUJoYzNObGNuUWdZVzF2ZFc1MFgyOTFkQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lrbHVjM1ZtWm1samFXVnVkQ0J2ZFhSd2RYUWdZVzF2ZFc1MElnb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnU1c1emRXWm1hV05wWlc1MElHOTFkSEIxZENCaGJXOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pFMU9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdGdGIzVnVkRjl2ZFhRZ1BEMGdZM1Z5Y21WdWRGOXlaWE5sY25abFgyRXNJQ0pKYm5OMVptWnBZMmxsYm5RZ2JHbHhkV2xrYVhSNUlnb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ2JHbHhkV2xrYVhSNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3hOakF0TVRZeENpQWdJQ0F2THlBaklGVndaR0YwWlNCeVpYTmxjblpsY3dvZ0lDQWdMeThnYzJWc1ppNXlaWE5sY25abFgySXVkbUZzZFdVZ1BTQmpkWEp5Wlc1MFgzSmxjMlZ5ZG1WZllpQXJJR0Z0YjNWdWRGOXBiZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkpsYzJWeWRtVmZZaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRveE5qSUtJQ0FnSUM4dklITmxiR1l1Y21WelpYSjJaVjloTG5aaGJIVmxJRDBnWTNWeWNtVnVkRjl5WlhObGNuWmxYMkVnTFNCaGJXOTFiblJmYjNWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnTFFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY21WelpYSjJaVjloSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qRTJOQW9nSUNBZ0x5OGdiRzluS0dJaVUzZGhjQ0JDTFQ1QklDMGdTVzQ2SUNJZ0t5QnZjQzVwZEc5aUtHRnRiM1Z1ZEY5cGJpa2dLeUJpSWlCUGRYUTZJQ0lnS3lCdmNDNXBkRzlpS0dGdGIzVnVkRjl2ZFhRcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMU16YzNOakUzTURJd05ESXlaRE5sTkRFeU1ESmtNakEwT1RabE0yRXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUF3ZURJd05HWTNOVGMwTTJFeU1Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2TVRZMUNpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pUZDJGd0lHTnZiWEJzWlhSbFpDQnpkV05qWlhOelpuVnNiSGtpS1FvZ0lDQWdZbmwwWldNZ01UTWdMeThnSWxOM1lYQWdZMjl0Y0d4bGRHVmtJSE4xWTJObGMzTm1kV3hzZVNJS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncHpkMkZ3WDJKZlptOXlYMkZmWW05dmJGOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYzNkaGNGOWlYMlp2Y2w5aFgySnZiMnhmYldWeVoyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1emFXMXdiR1ZmWVcxdExtTnZiblJ5WVdOMExsTnBiWEJzWlVGTlRTNW5aWFJmY21WelpYSjJaWE1vS1NBdFBpQmllWFJsY3pvS1oyVjBYM0psYzJWeWRtVnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2TVRjd0NpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnb1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1eVpYTmxjblpsWDJFdWRtRnNkV1VwTENCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5KbGMyVnlkbVZmWWk1MllXeDFaU2twS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkpsYzJWeWRtVmZZU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVpYTmxjblpsWDJFZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljbVZ6WlhKMlpWOWlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5KbGMyVnlkbVZmWWlCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5wYlhCc1pWOWhiVzB1WTI5dWRISmhZM1F1VTJsdGNHeGxRVTFOTG1kbGRGOWhiVzkxYm5SZmIzVjBLR0Z0YjNWdWRGOXBiam9nZFdsdWREWTBMQ0J5WlhObGNuWmxYMmx1T2lCMWFXNTBOalFzSUhKbGMyVnlkbVZmYjNWME9pQjFhVzUwTmpRcElDMCtJSFZwYm5RMk5Eb0taMlYwWDJGdGIzVnVkRjl2ZFhRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3hOekl0TVRjNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUM4dklHUmxaaUJuWlhSZllXMXZkVzUwWDI5MWRDZ0tJQ0FnSUM4dklDQWdJQ0J6Wld4bUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWRGOXBiam9nVlVsdWREWTBMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyVnlkbVZmYVc0NklGVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQnlaWE5sY25abFgyOTFkRG9nVlVsdWREWTBMQW9nSUNBZ0x5OGdLU0F0UGlCVlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPakU0TUFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVgyZGxkRjloYlc5MWJuUmZiM1YwS0dGdGIzVnVkRjlwYml3Z2NtVnpaWEoyWlY5cGJpd2djbVZ6WlhKMlpWOXZkWFFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCallXeHNjM1ZpSUY5blpYUmZZVzF2ZFc1MFgyOTFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTnBiWEJzWlY5aGJXMHVZMjl1ZEhKaFkzUXVVMmx0Y0d4bFFVMU5MbWRsZEY5MWMyVnlYMnhwY1hWcFpHbDBlU2dwSUMwK0lHSjVkR1Z6T2dwblpYUmZkWE5sY2w5c2FYRjFhV1JwZEhrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3hPRFlLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXViR2x4ZFdsa2FYUjVYMkpoYkdGdVkyVmJWSGh1TG5ObGJtUmxjbDBwTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0lteHBjWFZwWkdsMGVWOWlZV3hoYm1ObElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViR2x4ZFdsa2FYUjVYMkpoYkdGdVkyVWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG94T0RjS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEc5clpXNWZZVjlrWlhCdmMybDBaV1JiVkhodUxuTmxibVJsY2wwcExBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblJ2YTJWdVgyRmZaR1Z3YjNOcGRHVmtJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5clpXNWZZVjlrWlhCdmMybDBaV1FnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRveE9EZ0tJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE5sYkdZdWRHOXJaVzVmWWw5a1pYQnZjMmwwWldSYlZIaHVMbk5sYm1SbGNsMHBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ055QXZMeUFpZEc5clpXNWZZbDlrWlhCdmMybDBaV1FpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIydGxibDlpWDJSbGNHOXphWFJsWkNCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qRTROUzB4T0RrS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsUjFjR3hsS0NnS0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxteHBjWFZwWkdsMGVWOWlZV3hoYm1ObFcxUjRiaTV6Wlc1a1pYSmRLU3dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmEyVnVYMkZmWkdWd2IzTnBkR1ZrVzFSNGJpNXpaVzVrWlhKZEtTd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MblJ2YTJWdVgySmZaR1Z3YjNOcGRHVmtXMVI0Ymk1elpXNWtaWEpkS1FvZ0lDQWdMeThnS1NrS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMmx0Y0d4bFgyRnRiUzVqYjI1MGNtRmpkQzVUYVcxd2JHVkJUVTB1WjJWMFgzQnZiMnhmYVc1bWJ5Z3BJQzArSUdKNWRHVnpPZ3BuWlhSZmNHOXZiRjlwYm1adk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNVGsxQ2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MbkpsYzJWeWRtVmZZUzUyWVd4MVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWNtVnpaWEoyWlY5aElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsYzJWeWRtVmZZU0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPakU1TmdvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTV5WlhObGNuWmxYMkl1ZG1Gc2RXVXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luSmxjMlZ5ZG1WZllpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV5WlhObGNuWmxYMklnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG94T1RjS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEc5MFlXeGZiR2x4ZFdsa2FYUjVMblpoYkhWbEtTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGIzUmhiRjlzYVhGMWFXUnBkSGtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYkdseGRXbGthWFI1SUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2TVRrNENpQWdJQ0F2THlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG1abFpWOXlZWFJsTG5aaGJIVmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0ltWmxaVjl5WVhSbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbVpsWlY5eVlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNVGswTFRFNU9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWSFZ3YkdVb0tBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVjbVZ6WlhKMlpWOWhMblpoYkhWbEtTd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MbkpsYzJWeWRtVmZZaTUyWVd4MVpTa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjNSaGJGOXNhWEYxYVdScGRIa3VkbUZzZFdVcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVabVZsWDNKaGRHVXVkbUZzZFdVcENpQWdJQ0F2THlBcEtRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTnBiWEJzWlY5aGJXMHVZMjl1ZEhKaFkzUXVVMmx0Y0d4bFFVMU5MbkpsYlc5MlpWOXNhWEYxYVdScGRIa29iR2x4ZFdsa2FYUjVYMkZ0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tjbVZ0YjNabFgyeHBjWFZwWkdsMGVUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPakl3TVMweU1ESUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlISmxiVzkyWlY5c2FYRjFhV1JwZEhrb2MyVnNaaXdnYkdseGRXbGthWFI1WDJGdGIzVnVkRG9nVlVsdWREWTBLU0F0UGlCVGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPakl3TkFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWFYTmZjR0YxYzJWa0xuWmhiSFZsSUQwOUlGVkpiblEyTkNnd0tTd2dJa0ZOVFNCcGN5QndZWFZ6WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYVhOZmNHRjFjMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtbHpYM0JoZFhObFpDQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJUVTBnYVhNZ2NHRjFjMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRveU1EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCc2FYRjFhV1JwZEhsZllXMXZkVzUwSUQ0Z1ZVbHVkRFkwS0RBcExDQWlRVzF2ZFc1MElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYlc5MWJuUWdiWFZ6ZENCaVpTQndiM05wZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNakEzQ2lBZ0lDQXZMeUIxYzJWeVgyeHBjWFZwWkdsMGVTQTlJSE5sYkdZdWJHbHhkV2xrYVhSNVgySmhiR0Z1WTJWYlZIaHVMbk5sYm1SbGNsMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pzYVhGMWFXUnBkSGxmWW1Gc1lXNWpaU0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG14cGNYVnBaR2wwZVY5aVlXeGhibU5sSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk1qQTRDaUFnSUNBdkx5QmhjM05sY25RZ2RYTmxjbDlzYVhGMWFXUnBkSGtnUGowZ2JHbHhkV2xrYVhSNVgyRnRiM1Z1ZEN3Z0lrbHVjM1ZtWm1samFXVnVkQ0JzYVhGMWFXUnBkSGtnWW1Gc1lXNWpaU0lLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWMzVm1abWxqYVdWdWRDQnNhWEYxYVdScGRIa2dZbUZzWVc1alpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNakV3Q2lBZ0lDQXZMeUJqZFhKeVpXNTBYM0psYzJWeWRtVmZZU0E5SUhObGJHWXVjbVZ6WlhKMlpWOWhMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpY21WelpYSjJaVjloSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuSmxjMlZ5ZG1WZllTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qSXhNUW9nSUNBZ0x5OGdZM1Z5Y21WdWRGOXlaWE5sY25abFgySWdQU0J6Wld4bUxuSmxjMlZ5ZG1WZllpNTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkpsYzJWeWRtVmZZaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVpYTmxjblpsWDJJZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRveU1USUtJQ0FnSUM4dklIUnZkR0ZzWDJ4cGNYVnBaR2wwZVNBOUlITmxiR1l1ZEc5MFlXeGZiR2x4ZFdsa2FYUjVMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZiR2x4ZFdsa2FYUjVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMnhwY1hWcFpHbDBlU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPakl4TkMweU1UVUtJQ0FnSUM4dklDTWdRMkZzWTNWc1lYUmxJSEJ5YjNCdmNuUnBiMjVoYkNCaGJXOTFiblJ6SUhSdklIZHBkR2hrY21GM0NpQWdJQ0F2THlCaGJXOTFiblJmWVNBOUlDaHNhWEYxYVdScGRIbGZZVzF2ZFc1MElDb2dZM1Z5Y21WdWRGOXlaWE5sY25abFgyRXBJQzh2SUhSdmRHRnNYMnhwY1hWcFpHbDBlUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCa2FXY2dNd29nSUNBZ0tnb2dJQ0FnWkdsbklERUtJQ0FnSUM4S0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5MlpYSWdOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2TWpFMkNpQWdJQ0F2THlCaGJXOTFiblJmWWlBOUlDaHNhWEYxYVdScGRIbGZZVzF2ZFc1MElDb2dZM1Z5Y21WdWRGOXlaWE5sY25abFgySXBJQzh2SUhSdmRHRnNYMnhwY1hWcFpHbDBlUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCa2FXY2dNd29nSUNBZ0tnb2dJQ0FnWkdsbklERUtJQ0FnSUM4S0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNakU0TFRJeE9Rb2dJQ0FnTHk4Z0l5QlZjR1JoZEdVZ2NtVnpaWEoyWlhNZ1lXNWtJR3hwY1hWcFpHbDBlUW9nSUNBZ0x5OGdjMlZzWmk1eVpYTmxjblpsWDJFdWRtRnNkV1VnUFNCamRYSnlaVzUwWDNKbGMyVnlkbVZmWVNBdElHRnRiM1Z1ZEY5aENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnlaWE5sY25abFgyRWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnBiWEJzWlY5aGJXMHZZMjl1ZEhKaFkzUXVjSGs2TWpJd0NpQWdJQ0F2THlCelpXeG1MbkpsYzJWeWRtVmZZaTUyWVd4MVpTQTlJR04xY25KbGJuUmZjbVZ6WlhKMlpWOWlJQzBnWVcxdmRXNTBYMklLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzNkaGNBb2dJQ0FnTFFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY21WelpYSjJaVjlpSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qSXlNUW9nSUNBZ0x5OGdjMlZzWmk1c2FYRjFhV1JwZEhsZlltRnNZVzVqWlZ0VWVHNHVjMlZ1WkdWeVhTQTlJSFZ6WlhKZmJHbHhkV2xrYVhSNUlDMGdiR2x4ZFdsa2FYUjVYMkZ0YjNWdWRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklEVWdMeThnSW14cGNYVnBaR2wwZVY5aVlXeGhibU5sSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG95TWpJS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmJHbHhkV2xrYVhSNUxuWmhiSFZsSUQwZ2RHOTBZV3hmYkdseGRXbGthWFI1SUMwZ2JHbHhkV2xrYVhSNVgyRnRiM1Z1ZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiM1JoYkY5c2FYRjFhV1JwZEhraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNakkwTFRJeU5Rb2dJQ0FnTHk4Z0l5QlZjR1JoZEdVZ2RYTmxjaUJrWlhCdmMybDBjd29nSUNBZ0x5OGdhV1lnYzJWc1ppNTBiMnRsYmw5aFgyUmxjRzl6YVhSbFpGdFVlRzR1YzJWdVpHVnlYU0ErUFNCaGJXOTFiblJmWVRvS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBiMnRsYmw5aFgyUmxjRzl6YVhSbFpDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2YTJWdVgyRmZaR1Z3YjNOcGRHVmtJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ1BEMEtJQ0FnSUdKNklISmxiVzkyWlY5c2FYRjFhV1JwZEhsZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRveU1qWUtJQ0FnSUM4dklITmxiR1l1ZEc5clpXNWZZVjlrWlhCdmMybDBaV1JiVkhodUxuTmxibVJsY2wwZ1BTQnpaV3htTG5SdmEyVnVYMkZmWkdWd2IzTnBkR1ZrVzFSNGJpNXpaVzVrWlhKZElDMGdZVzF2ZFc1MFgyRUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0owYjJ0bGJsOWhYMlJsY0c5emFYUmxaQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmEyVnVYMkZmWkdWd2IzTnBkR1ZrSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lDMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5SdmEyVnVYMkZmWkdWd2IzTnBkR1ZrSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDZ3B5WlcxdmRtVmZiR2x4ZFdsa2FYUjVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPakl5T0FvZ0lDQWdMeThnYVdZZ2MyVnNaaTUwYjJ0bGJsOWlYMlJsY0c5emFYUmxaRnRVZUc0dWMyVnVaR1Z5WFNBK1BTQmhiVzkxYm5SZllqb0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0owYjJ0bGJsOWlYMlJsY0c5emFYUmxaQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmEyVnVYMkpmWkdWd2IzTnBkR1ZrSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lENDlDaUFnSUNCaWVpQnlaVzF2ZG1WZmJHbHhkV2xrYVhSNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk1qSTVDaUFnSUNBdkx5QnpaV3htTG5SdmEyVnVYMkpmWkdWd2IzTnBkR1ZrVzFSNGJpNXpaVzVrWlhKZElEMGdjMlZzWmk1MGIydGxibDlpWDJSbGNHOXphWFJsWkZ0VWVHNHVjMlZ1WkdWeVhTQXRJR0Z0YjNWdWRGOWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ055QXZMeUFpZEc5clpXNWZZbDlrWlhCdmMybDBaV1FpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIydGxibDlpWDJSbGNHOXphWFJsWkNCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQXRDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKMGIydGxibDlpWDJSbGNHOXphWFJsWkNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9LY21WdGIzWmxYMnhwY1hWcFpHbDBlVjloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG95TXpFS0lDQWdJQzh2SUd4dlp5aGlJa3hwY1hWcFpHbDBlU0J5WlcxdmRtVmtJQzBnUVRvZ0lpQXJJRzl3TG1sMGIySW9ZVzF2ZFc1MFgyRXBJQ3NnWWlJZ1Fqb2dJaUFySUc5d0xtbDBiMklvWVcxdmRXNTBYMklwS1FvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFJqTmprM01UYzFOamsyTkRZNU56UTNPVEl3TnpJMk5UWmtObVkzTmpZMU5qUXlNREprTWpBME1UTmhNakFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ01URWdMeThnTUhneU1EUXlNMkV5TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qSXpNZ29nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVRHbHhkV2xrYVhSNUlISmxiVzkyWldRZ2MzVmpZMlZ6YzJaMWJHeDVJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlUR2x4ZFdsa2FYUjVJSEpsYlc5MlpXUWdjM1ZqWTJWemMyWjFiR3g1SWdvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMmx0Y0d4bFgyRnRiUzVqYjI1MGNtRmpkQzVUYVcxd2JHVkJUVTB1YzJWMFgyWmxaVjl5WVhSbEtHNWxkMTltWldVNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNuTmxkRjltWldWZmNtRjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pJek5DMHlNelVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JSE5sZEY5bVpXVmZjbUYwWlNoelpXeG1MQ0J1WlhkZlptVmxPaUJWU1c1ME5qUXBJQzArSUZOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNak0zQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaTVpZVhSbGN5QTlQU0J6Wld4bUxtRmtiV2x1TG5aaGJIVmxMQ0FpVDI1c2VTQmhaRzFwYmlCallXNGdjMlYwSUdabFpTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCaFpHMXBiaUJqWVc0Z2MyVjBJR1psWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk1qTTRDaUFnSUNBdkx5QmhjM05sY25RZ2JtVjNYMlpsWlNBOElITmxiR1l1Wm1WbFgyUmxibTl0YVc1aGRHOXlMQ0FpUm1WbElIUnZieUJvYVdkb0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKbVpXVmZaR1Z1YjIxcGJtRjBiM0lpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVptVmxYMlJsYm05dGFXNWhkRzl5SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnUm1WbElIUnZieUJvYVdkb0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3lOREFLSUNBZ0lDOHZJRzlzWkY5bVpXVWdQU0J6Wld4bUxtWmxaVjl5WVhSbExuWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT0NBdkx5QWlabVZsWDNKaGRHVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Wm1WbFgzSmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG95TkRFS0lDQWdJQzh2SUhObGJHWXVabVZsWDNKaGRHVXVkbUZzZFdVZ1BTQnVaWGRmWm1WbENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKbVpXVmZjbUYwWlNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qSTBNd29nSUNBZ0x5OGdiRzluS0dJaVJtVmxJSFZ3WkdGMFpXUWdMU0JQYkdRNklDSWdLeUJ2Y0M1cGRHOWlLRzlzWkY5bVpXVXBJQ3NnWWlJZ1RtVjNPaUFpSUNzZ2IzQXVhWFJ2WWlodVpYZGZabVZsS1NrS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURRMk5qVTJOVEl3TnpVM01EWTBOakUzTkRZMU5qUXlNREprTWpBMFpqWmpOalF6WVRJd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VESXdOR1UyTlRjM00yRXlNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRveU5EUUtJQ0FnSUM4dklISmxkSFZ5YmlCVGRISnBibWNvSWtabFpTQnlZWFJsSUhWd1pHRjBaV1FnYzNWalkyVnpjMloxYkd4NUlpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVJtVmxJSEpoZEdVZ2RYQmtZWFJsWkNCemRXTmpaWE56Wm5Wc2JIa2lDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMybHRjR3hsWDJGdGJTNWpiMjUwY21GamRDNVRhVzF3YkdWQlRVMHVjR0YxYzJWZllXMXRLQ2tnTFQ0Z1lubDBaWE02Q25CaGRYTmxYMkZ0YlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qSTBPUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTd2dJazl1YkhrZ1lXUnRhVzRnWTJGdUlIQmhkWE5sSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR0ZrYldsdUlHTmhiaUJ3WVhWelpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNalV3Q2lBZ0lDQXZMeUJ6Wld4bUxtbHpYM0JoZFhObFpDNTJZV3gxWlNBOUlGVkpiblEyTkNneEtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWFYTmZjR0YxYzJWa0lnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3lOVElLSUNBZ0lDOHZJR3h2WnloaUlrRk5UU0J3WVhWelpXUWlLUW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdNSGcwTVRSa05HUXlNRGN3TmpFM05UY3pOalUyTkFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRveU5UTUtJQ0FnSUM4dklISmxkSFZ5YmlCVGRISnBibWNvSWtGTlRTQndZWFZ6WldRaUtRb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0lrRk5UU0J3WVhWelpXUWlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMybHRjR3hsWDJGdGJTNWpiMjUwY21GamRDNVRhVzF3YkdWQlRVMHVkVzV3WVhWelpWOWhiVzBvS1NBdFBpQmllWFJsY3pvS2RXNXdZWFZ6WlY5aGJXMDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG95TlRnS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5SUhObGJHWXVZV1J0YVc0dWRtRnNkV1VzSUNKUGJteDVJR0ZrYldsdUlHTmhiaUIxYm5CaGRYTmxJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEa2dMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1SUdOaGJpQjFibkJoZFhObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3lOVGtLSUNBZ0lDOHZJSE5sYkdZdWFYTmZjR0YxYzJWa0xuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKcGMxOXdZWFZ6WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qSTJNUW9nSUNBZ0x5OGdiRzluS0dJaVFVMU5JSFZ1Y0dGMWMyVmtJaWtLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJREI0TkRFMFpEUmtNakEzTlRabE56QTJNVGMxTnpNMk5UWTBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFXMXdiR1ZmWVcxdEwyTnZiblJ5WVdOMExuQjVPakkyTWdvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lRVTFOSUhWdWNHRjFjMlZrSWlrS0lDQWdJR0o1ZEdWaklERTFJQzh2SUNKQlRVMGdkVzV3WVhWelpXUWlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMybHRjR3hsWDJGdGJTNWpiMjUwY21GamRDNVRhVzF3YkdWQlRVMHVYMmRsZEY5aGJXOTFiblJmYjNWMEtHRnRiM1Z1ZEY5cGJqb2dkV2x1ZERZMExDQnlaWE5sY25abFgybHVPaUIxYVc1ME5qUXNJSEpsYzJWeWRtVmZiM1YwT2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS1gyZGxkRjloYlc5MWJuUmZiM1YwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk1qWTBMVEkzTUFvZ0lDQWdMeThnUUhOMVluSnZkWFJwYm1VS0lDQWdJQzh2SUdSbFppQmZaMlYwWDJGdGIzVnVkRjl2ZFhRb0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5SZmFXNDZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxYMmx1T2lCVlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpaWEoyWlY5dmRYUTZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDa2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJsdGNHeGxYMkZ0YlM5amIyNTBjbUZqZEM1d2VUb3lOeklLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhiVzkxYm5SZmFXNGdQaUJWU1c1ME5qUW9NQ2tzSUNKQmJXOTFiblFnYlhWemRDQmlaU0J3YjNOcGRHbDJaU0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lYTnpaWEowSUM4dklFRnRiM1Z1ZENCdGRYTjBJR0psSUhCdmMybDBhWFpsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmx0Y0d4bFgyRnRiUzlqYjI1MGNtRmpkQzV3ZVRveU56TUtJQ0FnSUM4dklHRnpjMlZ5ZENCeVpYTmxjblpsWDJsdUlENGdWVWx1ZERZMEtEQXBJR0Z1WkNCeVpYTmxjblpsWDI5MWRDQStJRlZKYm5RMk5DZ3dLU3dnSWtsdWMzVm1abWxqYVdWdWRDQnNhWEYxYVdScGRIa2lDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKNklGOW5aWFJmWVcxdmRXNTBYMjkxZEY5aWIyOXNYMlpoYkhObFFETUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5vZ1gyZGxkRjloYlc5MWJuUmZiM1YwWDJKdmIyeGZabUZzYzJWQU13b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NsOW5aWFJmWVcxdmRXNTBYMjkxZEY5aWIyOXNYMjFsY21kbFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMybHRjR3hsWDJGdGJTOWpiMjUwY21GamRDNXdlVG95TnpNS0lDQWdJQzh2SUdGemMyVnlkQ0J5WlhObGNuWmxYMmx1SUQ0Z1ZVbHVkRFkwS0RBcElHRnVaQ0J5WlhObGNuWmxYMjkxZENBK0lGVkpiblEyTkNnd0tTd2dJa2x1YzNWbVptbGphV1Z1ZENCc2FYRjFhV1JwZEhraUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1emRXWm1hV05wWlc1MElHeHBjWFZwWkdsMGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOcGJYQnNaVjloYlcwdlkyOXVkSEpoWTNRdWNIazZNamMxTFRJM05nb2dJQ0FnTHk4Z0l5QkJjSEJzZVNCbVpXVTZJR0Z0YjNWdWRGOXBibDkzYVhSb1gyWmxaU0E5SUdGdGIzVnVkRjlwYmlBcUlDZ3hNREF3SUMwZ1ptVmxYM0poZEdVcENpQWdJQ0F2THlCaGJXOTFiblJmYVc1ZmQybDBhRjltWldVZ1BTQmhiVzkxYm5SZmFXNGdLaUFvYzJWc1ppNW1aV1ZmWkdWdWIyMXBibUYwYjNJZ0xTQnpaV3htTG1abFpWOXlZWFJsTG5aaGJIVmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSm1aV1ZmWkdWdWIyMXBibUYwYjNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVabVZsWDJSbGJtOXRhVzVoZEc5eUlHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbVpsWlY5eVlYUmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1abFpWOXlZWFJsSUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnS2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05wYlhCc1pWOWhiVzB2WTI5dWRISmhZM1F1Y0hrNk1qYzRMVEk0TUFvZ0lDQWdMeThnSXlCRGIyNXpkR0Z1ZENCd2NtOWtkV04wSUdadmNtMTFiR0U2SUNoNElDc2daSGdwSUNvZ0tIa2dMU0JrZVNrZ1BTQjRJQ29nZVFvZ0lDQWdMeThnSXlCVGIyeDJhVzVuSUdadmNpQmtlVG9nWkhrZ1BTQW9lU0FxSUdSNEtTQXZJQ2g0SUNzZ1pIZ3BDaUFnSUNBdkx5QnVkVzFsY21GMGIzSWdQU0JoYlc5MWJuUmZhVzVmZDJsMGFGOW1aV1VnS2lCeVpYTmxjblpsWDI5MWRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQ29LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphVzF3YkdWZllXMXRMMk52Ym5SeVlXTjBMbkI1T2pJNE1Rb2dJQ0FnTHk4Z1pHVnViMjFwYm1GMGIzSWdQU0J5WlhObGNuWmxYMmx1SUNvZ2MyVnNaaTVtWldWZlpHVnViMjFwYm1GMGIzSWdLeUJoYlc5MWJuUmZhVzVmZDJsMGFGOW1aV1VLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0FxQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YVcxd2JHVmZZVzF0TDJOdmJuUnlZV04wTG5CNU9qSTRNd29nSUNBZ0x5OGdjbVYwZFhKdUlHNTFiV1Z5WVhSdmNpQXZMeUJrWlc1dmJXbHVZWFJ2Y2dvZ0lDQWdMd29nSUNBZ2NtVjBjM1ZpQ2dwZloyVjBYMkZ0YjNWdWRGOXZkWFJmWW05dmJGOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnWDJkbGRGOWhiVzkxYm5SZmIzVjBYMkp2YjJ4ZmJXVnlaMlZBTkFvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQUFFQ0poQUpjbVZ6WlhKMlpWOWhDWEpsYzJWeWRtVmZZZ1FWSDN4MUQzUnZkR0ZzWDJ4cGNYVnBaR2wwZVFscGMxOXdZWFZ6WldRUmJHbHhkV2xrYVhSNVgySmhiR0Z1WTJVUmRHOXJaVzVmWVY5a1pYQnZjMmwwWldRUmRHOXJaVzVmWWw5a1pYQnZjMmwwWldRSVptVmxYM0poZEdVRllXUnRhVzRQWm1WbFgyUmxibTl0YVc1aGRHOXlCQ0JDT2lBR0lFOTFkRG9nRzFOM1lYQWdZMjl0Y0d4bGRHVmtJSE4xWTJObGMzTm1kV3hzZVFwQlRVMGdjR0YxYzJWa0RFRk5UU0IxYm5CaGRYTmxaREVZUUFBR0p3cUI2QWRuTVJ0QkFZS0NEQVNKZXRHbkJHalY1VThFYkY1cnl3VEZVd3lhQkxXa1B1c0V1WnJBcWdUNzVabDNCRXYxWGJZRXVSWUlPZ1NSOFNWREJMaW45b0FFT0dDY216WWFBSTRNQVE4QTd3RFRBTGNBcHdDS0FIb0FhZ0JPQURJQUdnQUNJa014R1JSRU1SaEVpQVY3U1JVV1Z3WUNURkFxVEZDd0kwTXhHUlJFTVJoRWlBVlFTUlVXVndZQ1RGQXFURkN3STBNeEdSUkVNUmhFTmhvQkY0Z0V6MGtWRmxjR0FreFFLa3hRc0NORE1Sa1VSREVZUkRZYUFSZUlBOUpKRlJaWEJnSk1VQ3BNVUxBalF6RVpGRVF4R0VTSUE1b3FURkN3STBNeEdSUkVNUmhFaUFOc0treFFzQ05ETVJrVVJERVlSRFlhQVJjMkdnSVhOaG9ERjRnRFF4WXFURkN3STBNeEdSUkVNUmhFaUFNbUtreFFzQ05ETVJrVVJERVlSRFlhQVJlSUFxQkpGUlpYQmdKTVVDcE1VTEFqUXpFWkZFUXhHRVEyR2dFWGlBSVNTUlVXVndZQ1RGQXFURkN3STBNeEdSUkVNUmhFTmhvQkZ6WWFBaGVJQUlWSkZSWlhCZ0pNVUNwTVVMQWpRekVaRkVReEdFU0lBQmxKRlJaWEJnSk1VQ3BNVUxBalF6RVpRUDdVTVJnVVJDTkRNUUF5Q1JKRUp3a3hBR2NvSW1jcEltY25DSUVEWnljRUltY3JJbWVBRlZOcGJYQnNaVUZOVFNCcGJtbDBhV0ZzYVhwbFpMQ0FIRUZOVFNCcGJtbDBhV0ZzYVhwbFpDQnpkV05qWlhOelpuVnNiSG1KaWdJQmdBQkhCeUluQkdWRUZFU0wva0VCVm92L1FRRlJJMFFpS0dWTVNVNENqQUZFSWlsbFRJd0NSRUFBeDRzQ1FBRENLSXYrWnltTC8yZUwvb3YvQzBtTUJVQUFjaUl4QUNjRlN3Sm1LMHhuTVFBaUp3WmpSSXYrQ0RFQUp3WlBBbVl4QUNJbkIyTkVpLzhJTVFBbkIwOENab3YrRm9BVlRHbHhkV2xrYVhSNUlHRmtaR1ZrSUMwZ1FUb2dURkFuQzFDTC94WlFzSUFjVEdseGRXbGthWFI1SUdGa1pHVmtJSE4xWTJObGMzTm1kV3hzZVl3QWlZc0ZTU01JSkFxTUJpS01BSXdIaXdhTEJ3eEJBQ0tMQUlFS0RFRUFHb3NGaXdaSlRnSUtTd0VJSkFxTEFDTUlqQUNNQm93SFF2L1dpd2RDLzFLTC9vc0NTVTRDQzRzQlNVNENDa2xPQW93RWkvOExUd0lLakFPTC93NUJBRGFMQVVtTC9nZ29UR2VMQW9zRUNDbE1aeUlyWlVTTC9ndE1DakVBSWljRlkwUkxBUWd4QUNjRlR3Sm1JaXRsUkFnclRHZEMvd1dMQVlzRENDaE1aNHNDU1l2L0NDbE1aeUlyWlVTTC93dE1Da0wveHlKQy9xeUtBUUVpSndSbFJCUkVpLzlFSWlobFRFbFBBa1FpS1dWTVRnSkVRUUJQaXdGQkFFb2pSSXYvaXdCSlRnS0xBVWxPQTRnQ2NrbEVTVXNDRGtSUEFvdi9DQ2hNWjB4TEFRa3BUR2VML3hhQUVGTjNZWEFnUVMwK1FpQXRJRWx1T2lCTVVDY01VRXdXVUxBbkRZd0FpU0pDLzdPS0FRRWlKd1JsUkJSRWkvOUVJaWhsVEVsUEFrUWlLV1ZNVGdKRVFRQlBpd0ZCQUVvalJJdi9pd0ZKVGdLTEFFbE9BNGdDQUVsRVNVc0NEa1JQQW92L0NDbE1aMHhMQVFrb1RHZUwveGFBRUZOM1lYQWdRaTArUVNBdElFbHVPaUJNVUNjTVVFd1dVTEFuRFl3QWlTSkMvN01pS0dWRUZpSXBaVVFXVUltS0F3R0wvWXYraS8rSUFhdUpNUUFpSndWalJCWXhBQ0luQm1ORUZqRUFJaWNIWTBRV1RnSlFURkNKSWlobFJCWWlLV1ZFRmlJclpVUVdJaWNJWlVRV1R3TlBBMUJQQWxCTVVJbUtBUUVpSndSbFJCUkVpLzlFTVFBaUp3VmpSRW1ML3c5RUlpaGxSQ0lwWlVRaUsyVkVpLzlMQXd0TEFRcEpUZ0pPQll2L1N3TUxTd0VLU1U0R1R3UkxBd2tvVEdkUEEwd0pLVXhuVHdLTC93a3hBQ2NGVHdKbWkvOEpLMHhuTVFBaUp3WmpSQTVCQUJFeEFDSW5CbU5FaXdBSk1RQW5CazhDWmpFQUlpY0hZMFNMQVE5QkFCRXhBQ0luQjJORWl3RUpNUUFuQjA4Q1pvc0FGb0FYVEdseGRXbGthWFI1SUhKbGJXOTJaV1FnTFNCQk9pQk1VQ2NMVUlzQkZsQ3dnQjVNYVhGMWFXUnBkSGtnY21WdGIzWmxaQ0J6ZFdOalpYTnpablZzYkhtTUFJbUtBUUV4QUNJbkNXVkVFa1FpSndwbFJJdi9EVVFpSndobFJDY0lpLzluRm9BVFJtVmxJSFZ3WkdGMFpXUWdMU0JQYkdRNklFeFFnQVlnVG1WM09pQlFpLzhXVUxDQUhVWmxaU0J5WVhSbElIVndaR0YwWldRZ2MzVmpZMlZ6YzJaMWJHeDVpVEVBSWljSlpVUVNSQ2NFSTJjbkRyQW5Eb2t4QUNJbkNXVkVFa1FuQkNKbkp3K3dKdytKaWdNQmkvMUVpLzVCQUNhTC8wRUFJU05FSWljS1pVUWlKd2hsUkVzQlRBbUwvUXRKaS84TGkvNVBBd3RQQWdnS2lTSkMvOXc9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6MTAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
