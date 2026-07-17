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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.PoolManager__Helper46_7dc2d596
{


    //
    // Helper contract 46 for PoolManager
    //
    public class PoolManager__Helper46Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PoolManager__Helper46Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class PoolKey : AVMObjectType
            {
                public byte[] Currency0 { get; set; }

                public byte[] Currency1 { get; set; }

                public ulong Fee { get; set; }

                public ulong TickSpacing { get; set; }

                public byte[] Hooks { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrency0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vCurrency0.From(Currency0);
                    ret.AddRange(vCurrency0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrency1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vCurrency1.From(Currency1);
                    ret.AddRange(vCurrency1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFee.From(Fee);
                    ret.AddRange(vFee.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickSpacing = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTickSpacing.From(TickSpacing);
                    ret.AddRange(vTickSpacing.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHooks = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vHooks.From(Hooks);
                    ret.AddRange(vHooks.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static PoolKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new PoolKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrency0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vCurrency0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCurrency0 = vCurrency0.ToValue();
                    if (valueCurrency0 is byte[] vCurrency0Value) { ret.Currency0 = vCurrency0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCurrency1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vCurrency1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCurrency1 = vCurrency1.ToValue();
                    if (valueCurrency1 is byte[] vCurrency1Value) { ret.Currency1 = vCurrency1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFee = vFee.ToValue();
                    if (valueFee is ulong vFeeValue) { ret.Fee = vFeeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTickSpacing = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTickSpacing.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTickSpacing = vTickSpacing.ToValue();
                    if (valueTickSpacing is ulong vTickSpacingValue) { ret.TickSpacing = vTickSpacingValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHooks = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vHooks.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHooks = vHooks.ToValue();
                    if (valueHooks is byte[] vHooksValue) { ret.Hooks = vHooksValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as PoolKey);
                }
                public bool Equals(PoolKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(PoolKey left, PoolKey right)
                {
                    return EqualityComparer<PoolKey>.Default.Equals(left, right);
                }
                public static bool operator !=(PoolKey left, PoolKey right)
                {
                    return !(left == right);
                }

            }

            public class Tuple : AVMObjectType
            {
                public ulong WordPos { get; set; }

                public ulong BitPos { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWordPos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWordPos.From(WordPos);
                    ret.AddRange(vWordPos.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBitPos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBitPos.From(BitPos);
                    ret.AddRange(vBitPos.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Tuple Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Tuple();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWordPos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWordPos.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWordPos = vWordPos.ToValue();
                    if (valueWordPos is ulong vWordPosValue) { ret.WordPos = vWordPosValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBitPos = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBitPos.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBitPos = vBitPos.ToValue();
                    if (valueBitPos is ulong vBitPosValue) { ret.BitPos = vBitPosValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Tuple);
                }
                public bool Equals(Tuple? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Tuple left, Tuple right)
                {
                    return EqualityComparer<Tuple>.Default.Equals(left, right);
                }
                public static bool operator !=(Tuple left, Tuple right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__free_memory_ptr"> </param>
        /// <param name="absTick"> </param>
        /// <param name="price"> </param>
        /// <param name="sqrtPriceX96"> </param>
        /// <param name="tick"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> TickMathGetSqrtPriceAtTickChunk1(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __free_memory_ptr, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 absTick, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 price, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 sqrtPriceX96, ulong tick, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 33, 64, 62 };
            var tickAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickAbi.From(tick);

            var result = await base.SimApp(new List<object> { abiHandle, __free_memory_ptr, absTick, price, sqrtPriceX96, tickAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> TickMathGetSqrtPriceAtTickChunk1_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __free_memory_ptr, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 absTick, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 price, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 sqrtPriceX96, ulong tick, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 202, 33, 64, 62 };
            var tickAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickAbi.From(tick);

            return await base.MakeTransactionList(new List<object> { abiHandle, __free_memory_ptr, absTick, price, sqrtPriceX96, tickAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice Computes the position in the mapping where the initialized bit for a tick lives
        /// @param tick The tick for which to compute the position
        /// @return wordPos The key in the mapping containing the word in which the bit is stored
        /// @return bitPos The bit position in the word where the flag is stored
        ///</summary>
        /// <param name="tick"> </param>
        public async Task<Structs.Tuple> TickBitmapPosition(ulong tick, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 96, 113, 207 };
            var tickAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickAbi.From(tick);

            var result = await base.SimApp(new List<object> { abiHandle, tickAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Tuple.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TickBitmapPosition_Transactions(ulong tick, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 96, 113, 207 };
            var tickAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickAbi.From(tick);

            return await base.MakeTransactionList(new List<object> { abiHandle, tickAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice Returns value equal to keccak256(abi.encode(poolKey))
        ///</summary>
        /// <param name="poolKey"> PoolKey</param>
        public async Task<byte[]> PoolIdLibraryToId(Structs.PoolKey poolKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 149, 126, 175 };

            var result = await base.SimApp(new List<object> { abiHandle, poolKey }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> PoolIdLibraryToId_Transactions(Structs.PoolKey poolKey, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 149, 126, 175 };

            return await base.MakeTransactionList(new List<object> { abiHandle, poolKey }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="o"> </param>
        /// <param name="p"> </param>
        /// <param name="s"> </param>
        public async Task Init(ulong o, ulong p, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 110, 249, 137 };
            var oAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oAbi.From(o);
            var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pAbi.From(p);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sAbi.From(s);

            var result = await base.CallApp(new List<object> { abiHandle, oAbi, pAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Init_Transactions(ulong o, ulong p, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 110, 249, 137 };
            var oAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oAbi.From(o);
            var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pAbi.From(p);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sAbi.From(s);

            return await base.MakeTransactionList(new List<object> { abiHandle, oAbi, pAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9vbE1hbmFnZXJfX0hlbHBlcjQ2IiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCA0NiBmb3IgUG9vbE1hbmFnZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUG9vbEtleSI6W3sibmFtZSI6ImN1cnJlbmN5MCIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJjdXJyZW5jeTEiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoiZmVlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRpY2tTcGFjaW5nIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Imhvb2tzIiwidHlwZSI6InVpbnQ4WzMyXSJ9XSwidHVwbGUiOlt7Im5hbWUiOiJ3b3JkUG9zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImJpdFBvcyIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiVGlja01hdGguZ2V0U3FydFByaWNlQXRUaWNrX19jaHVua18xIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2ZyZWVfbWVtb3J5X3B0ciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFic1RpY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNxcnRQcmljZVg5NiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGljayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlRpY2tCaXRtYXAucG9zaXRpb24iLCJkZXNjIjoiQG5vdGljZSBDb21wdXRlcyB0aGUgcG9zaXRpb24gaW4gdGhlIG1hcHBpbmcgd2hlcmUgdGhlIGluaXRpYWxpemVkIGJpdCBmb3IgYSB0aWNrIGxpdmVzXG4gQHBhcmFtIHRpY2sgVGhlIHRpY2sgZm9yIHdoaWNoIHRvIGNvbXB1dGUgdGhlIHBvc2l0aW9uXG4gQHJldHVybiB3b3JkUG9zIFRoZSBrZXkgaW4gdGhlIG1hcHBpbmcgY29udGFpbmluZyB0aGUgd29yZCBpbiB3aGljaCB0aGUgYml0IGlzIHN0b3JlZFxuIEByZXR1cm4gYml0UG9zIFRoZSBiaXQgcG9zaXRpb24gaW4gdGhlIHdvcmQgd2hlcmUgdGhlIGZsYWcgaXMgc3RvcmVkIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoidHVwbGUiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlBvb2xJZExpYnJhcnkudG9JZCIsImRlc2MiOiJAbm90aWNlIFJldHVybnMgdmFsdWUgZXF1YWwgdG8ga2VjY2FrMjU2KGFiaS5lbmNvZGUocG9vbEtleSkpIiwiYXJncyI6W3sidHlwZSI6Iih1aW50OFszMl0sdWludDhbMzJdLHVpbnQ2NCx1aW50NjQsdWludDhbMzJdKSIsInN0cnVjdCI6IlBvb2xLZXkiLCJuYW1lIjoicG9vbEtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfX2luaXRfXyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTE4OV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogYWxyZWFkeSBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3MSwxMDIwLDEwOTddLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IG11c3QgYmUgY2FsbGVkIGluIGdyb3VwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg1LDEwMzQsMTExMV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogc2VuZGVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc4LDEwMjcsMTEwNF0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogdW5hdXRob3JpemVkIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwMCwxMDQ5LDExMjZdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHdyb25nIHByZXYgY2h1bmsiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MTIsMTA2MSwxMTM4XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB3cm9uZyBwcmV2IG1ldGhvZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNzRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFBvb2xLZXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTgyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyOCw1MzYsNTQ0LDU1MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTksMTAwOCwxMTU4LDExNjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5ODZdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjalEyTGw5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZktDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURNeUlERWdPQ0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0p2SWlBaWNDSWdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdJQ0p6SWlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVl3TURBd01EQWdNSGhtWm1abVptWWdNSGd4TlRGbU4yTTNOU0F3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4TURBS0lDQWdJR0lnWDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRWxrVEdsaWNtRnllUzUwYjBsa0tIQnZiMnhMWlhrNklHSjVkR1Z6S1NBdFBpQmllWFJsY3l3Z1lubDBaWE02Q2xCdmIyeEpaRXhwWW5KaGNua3VkRzlKWkRvS0lDQWdJSEJ5YjNSdklERWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTmpRZ09Bb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTnpJZ09Bb2dJQ0FnWkdsbklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnT0RBZ016SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3RsWTJOaGF6STFOZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VkdsamEwSnBkRzFoY0M1d2IzTnBkR2x2YmloMGFXTnJPaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJOQ3dnZFdsdWREWTBPZ3BVYVdOclFtbDBiV0Z3TG5CdmMybDBhVzl1T2dvZ0lDQWdjSEp2ZEc4Z01TQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRGd3TURBd01Bb2dJQ0FnWWk4S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBeUNpQWdJQ0JpSlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lHUjFjQW9nSUNBZ1lub2dWR2xqYTBKcGRHMWhjQzV3YjNOcGRHbHZibDkwWlhKdVlYSjVYMlpoYkhObFFESUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aakF3TURBd01Bb2dJQ0FnWW53S0NsUnBZMnRDYVhSdFlYQXVjRzl6YVhScGIyNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBek9nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWo0OUNpQWdJQ0JpZWlCVWFXTnJRbWwwYldGd0xuQnZjMmwwYVc5dVgzUmxjbTVoY25sZlptRnNjMlZBT0FvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lHSjZJRlJwWTJ0Q2FYUnRZWEF1Y0c5emFYUnBiMjVmZEdWeWJtRnllVjltWVd4elpVQTJDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVl3TURBd01EQUtJQ0FnSUdKOENncFVhV05yUW1sMGJXRndMbkJ2YzJsMGFXOXVYM1JsY201aGNubGZiV1Z5WjJWQU56b0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdDaUFnSUNCaUx3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNFptWXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWW53S0NsUnBZMnRDYVhSdFlYQXVjRzl6YVhScGIyNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobVpnb2dJQ0FnWWlZS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J5WlhSemRXSUtDbFJwWTJ0Q2FYUnRZWEF1Y0c5emFYUnBiMjVmZEdWeWJtRnllVjltWVd4elpVQTJPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IaG1abVptWm1ZS0lDQWdJR0ltQ2lBZ0lDQmlJRlJwWTJ0Q2FYUnRZWEF1Y0c5emFYUnBiMjVmZEdWeWJtRnllVjl0WlhKblpVQTNDZ3BVYVdOclFtbDBiV0Z3TG5CdmMybDBhVzl1WDNSbGNtNWhjbmxmWm1Gc2MyVkFPRG9LSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaWVpQlVhV05yUW1sMGJXRndMbkJ2YzJsMGFXOXVYM1JsY201aGNubGZabUZzYzJWQU1UQUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aakF3TURBd01Bb2dJQ0FnWW53S0NsUnBZMnRDYVhSdFlYQXVjRzl6YVhScGIyNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1Ub0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdDaUFnSUNCaUx3b2dJQ0FnWWlCVWFXTnJRbWwwYldGd0xuQnZjMmwwYVc5dVgzUmxjbTVoY25sZmJXVnlaMlZBTVRJS0NsUnBZMnRDYVhSdFlYQXVjRzl6YVhScGIyNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNFptWm1abVptQ2lBZ0lDQmlKZ29nSUNBZ1lpQlVhV05yUW1sMGJXRndMbkJ2YzJsMGFXOXVYM1JsY201aGNubGZiV1Z5WjJWQU1URUtDbFJwWTJ0Q2FYUnRZWEF1Y0c5emFYUnBiMjVmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IaG1abVptWm1ZS0lDQWdJR0ltQ2lBZ0lDQmlJRlJwWTJ0Q2FYUnRZWEF1Y0c5emFYUnBiMjVmZEdWeWJtRnllVjl0WlhKblpVQXpDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwTmk1ZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlh5Z3BJQzArSUhWcGJuUTJORG9LWDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE4NkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ1gxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOWZYMTlpWVhKbFgyTnlaV0YwWlY5ZlFERXdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGpZVEl4TkRBelpTQXdlRGhsTmpBM01XTm1JREI0WkdJNU5UZGxZV1lnTUhoaE9UWmxaams0T1NBdkx5QnRaWFJvYjJRZ0lsUnBZMnROWVhSb0xtZGxkRk54Y25SUWNtbGpaVUYwVkdsamExOWZZMmgxYm10Zk1TaDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUTJOQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0pVYVdOclFtbDBiV0Z3TG5CdmMybDBhVzl1S0hWcGJuUTJOQ2tvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbEJ2YjJ4SlpFeHBZbkpoY25rdWRHOUpaQ2dvZFdsdWREaGJNekpkTEhWcGJuUTRXek15WFN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RNFd6TXlYU2twWW5sMFpWc3pNbDBpTENCdFpYUm9iMlFnSWw5ZmFXNXBkRjlmS0hWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCVWFXTnJUV0YwYUM1blpYUlRjWEowVUhKcFkyVkJkRlJwWTJ0ZlgyTm9kVzVyWHpFZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwTmk1VWFXTnJRbWwwYldGd0xuQnZjMmwwYVc5dVczSnZkWFJwYm1kZElDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TkRZdVVHOXZiRWxrVEdsaWNtRnllUzUwYjBsa1czSnZkWFJwYm1kZElGOWZhVzVwZEY5ZkNpQWdJQ0JsY25JS0NsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZYMTlmWW1GeVpWOWpjbVZoZEdWZlgwQXhNRG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME5pNVVhV05yVFdGMGFDNW5aWFJUY1hKMFVISnBZMlZCZEZScFkydGZYMk5vZFc1clh6RmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BVYVdOclRXRjBhQzVuWlhSVGNYSjBVSEpwWTJWQmRGUnBZMnRmWDJOb2RXNXJYekU2Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pIVndDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQlVhV05yVFdGMGFDNW5aWFJUY1hKMFVISnBZMlZCZEZScFkydGZYMk5vZFc1clh6RmZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0JuYkc5aVlXd2dSM0p2ZFhCVGFYcGxDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQnRkWE4wSUdKbElHTmhiR3hsWkNCcGJpQm5jbTkxY0FvZ0lDQWdaM1I0YmlBd0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIVnVZWFYwYUc5eWFYcGxaQ0JqWVd4c1pYSUtJQ0FnSUdkMGVHNGdNQ0JUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQnpaVzVrWlhJZ2JXbHpiV0YwWTJnS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5BaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5vZ1ZHbGphMDFoZEdndVoyVjBVM0Z5ZEZCeWFXTmxRWFJVYVdOclgxOWphSFZ1YTE4eFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIzY205dVp5QndjbVYySUdOb2RXNXJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1ellTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCdFpYUm9iMlFLQ2xScFkydE5ZWFJvTG1kbGRGTnhjblJRY21salpVRjBWR2xqYTE5ZlkyaDFibXRmTVY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQndkWE5vYVc1MElERTJNemcwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZaVlLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOd29nSUNBZ1lpRTlDaUFnSUNCaWVpQlVhV05yVFdGMGFDNW5aWFJUY1hKMFVISnBZMlZCZEZScFkydGZYMk5vZFc1clh6RmZZV1owWlhKZmFXWmZaV3h6WlVBNENpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE56QmtPRFk1WVRFMU5tUXlZVEZpT0Rrd1ltSXpaR1kyTW1KaFpqTXlaamNLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXZDaUFnSUNCaWRYSjVJRElLQ2xScFkydE5ZWFJvTG1kbGRGTnhjblJRY21salpVRjBWR2xqYTE5ZlkyaDFibXRmTVY5aFpuUmxjbDlwWmw5bGJITmxRRGc2Q2lBZ0lDQndkWE5vYVc1MElETXlOelk0Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZaVlLSUNBZ0lHUnBaeUExQ2lBZ0lDQmlJVDBLSUNBZ0lHSjZJRlJwWTJ0TllYUm9MbWRsZEZOeGNuUlFjbWxqWlVGMFZHbGphMTlmWTJoMWJtdGZNVjloWm5SbGNsOXBabDlsYkhObFFERXdDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNekZpWlRFek5XWTVOMlF3T0daa09UZ3hNak14TlRBMU5UUXlabU5tWVRZS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0l2Q2lBZ0lDQmlkWEo1SURJS0NsUnBZMnROWVhSb0xtZGxkRk54Y25SUWNtbGpaVUYwVkdsamExOWZZMmgxYm10Zk1WOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnY0hWemFHbHVkQ0EyTlRVek5nb2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklETUtJQ0FnSUdJbUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWWlFOUNpQWdJQ0JpZWlCVWFXTnJUV0YwYUM1blpYUlRjWEowVUhKcFkyVkJkRlJwWTJ0ZlgyTm9kVzVyWHpGZllXWjBaWEpmYVdaZlpXeHpaVUF4TWdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBNVlXRTFNRGhpTldJM1lUZzBaVEZqTmpjM1pHVTFOR1l6WlRrNVltTTVDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUx3b2dJQ0FnWW5WeWVTQXlDZ3BVYVdOclRXRjBhQzVuWlhSVGNYSjBVSEpwWTJWQmRGUnBZMnRmWDJOb2RXNXJYekZmWVdaMFpYSmZhV1pmWld4elpVQXhNam9LSUNBZ0lIQjFjMmhwYm5RZ01UTXhNRGN5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZaVlLSUNBZ0lHUnBaeUExQ2lBZ0lDQmlJVDBLSUNBZ0lHSjZJRlJwWTJ0TllYUm9MbWRsZEZOeGNuUlFjbWxqWlVGMFZHbGphMTlmWTJoMWJtdGZNVjloWm5SbGNsOXBabDlsYkhObFFERTBDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROV1EyWVdZNFpHVmtZamd4TVRrMk5qazVZek15T1RJeU5XVmxOakEwQ2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlMd29nSUNBZ1luVnllU0F5Q2dwVWFXTnJUV0YwYUM1blpYUlRjWEowVUhKcFkyVkJkRlJwWTJ0ZlgyTm9kVzVyWHpGZllXWjBaWEpmYVdaZlpXeHpaVUF4TkRvS0lDQWdJSEIxYzJocGJuUWdNall5TVRRMENpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ013b2dJQ0FnWWlZS0lDQWdJR1JwWnlBMUNpQWdJQ0JpSVQwS0lDQWdJR0o2SUZScFkydE5ZWFJvTG1kbGRGTnhjblJRY21salpVRjBWR2xqYTE5ZlkyaDFibXRmTVY5aFpuUmxjbDlwWmw5bGJITmxRREUyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpJeE5tVTFPRFJtTldaaE1XVmhPVEkyTURReFltVmtabVU1T0FvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaThLSUNBZ0lHSjFjbmtnTWdvS1ZHbGphMDFoZEdndVoyVjBVM0Z5ZEZCeWFXTmxRWFJVYVdOclgxOWphSFZ1YTE4eFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRZNkNpQWdJQ0J3ZFhOb2FXNTBJRFV5TkRJNE9Bb2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklETUtJQ0FnSUdJbUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWWlFOUNpQWdJQ0JpZWlCVWFXTnJUV0YwYUM1blpYUlRjWEowVUhKcFkyVkJkRlJwWTJ0ZlgyTm9kVzVyWHpGZllXWjBaWEpmYVdaZlpXeHpaVUF4T0FvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBME9HRXhOekF6T1RGbU4yUmpOREkwTkRSbE9HWmhNZ29nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpOEtJQ0FnSUdKMWNua2dNZ29LVkdsamEwMWhkR2d1WjJWMFUzRnlkRkJ5YVdObFFYUlVhV05yWDE5amFIVnVhMTh4WDJGbWRHVnlYMmxtWDJWc2MyVkFNVGc2Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0ExQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHSStDaUFnSUNCaWVpQlVhV05yVFdGMGFDNW5aWFJUY1hKMFVISnBZMlZCZEZScFkydGZYMk5vZFc1clh6RmZZbTl2YkY5bVlXeHpaVUF5TVFvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSThDaUFnSUNCaWVpQlVhV05yVFdGMGFDNW5aWFJUY1hKMFVISnBZMlZCZEZScFkydGZYMk5vZFc1clh6RmZZbTl2YkY5bVlXeHpaVUF5TVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ2xScFkydE5ZWFJvTG1kbGRGTnhjblJRY21salpVRjBWR2xqYTE5ZlkyaDFibXRmTVY5aWIyOXNYMjFsY21kbFFESXlPZ29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlQ0F3ZURBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lHSjZJRlJwWTJ0TllYUm9MbWRsZEZOeGNuUlFjbWxqWlVGMFZHbGphMTlmWTJoMWJtdGZNVjloWm5SbGNsOXBabDlsYkhObFFESTBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCa2FXY2dNZ29nSUNBZ1lpOEtJQ0FnSUdKMWNua2dNZ29LVkdsamEwMWhkR2d1WjJWMFUzRnlkRkJ5YVdObFFYUlVhV05yWDE5amFIVnVhMTh4WDJGbWRHVnlYMmxtWDJWc2MyVkFNalE2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Wm1abVptWm1abVlLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNQW9nSUNBZ1lpOEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncFVhV05yVFdGMGFDNW5aWFJUY1hKMFVISnBZMlZCZEZScFkydGZYMk5vZFc1clh6RmZZbTl2YkY5bVlXeHpaVUF5TVRvS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmlJRlJwWTJ0TllYUm9MbWRsZEZOeGNuUlFjbWxqWlVGMFZHbGphMTlmWTJoMWJtdGZNVjlpYjI5c1gyMWxjbWRsUURJeUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBOaTVVYVdOclFtbDBiV0Z3TG5CdmMybDBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwTmk1VWFXTnJRbWwwYldGd0xuQnZjMmwwYVc5dVczSnZkWFJwYm1kZE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUTJMbFJwWTJ0Q2FYUnRZWEF1Y0c5emFYUnBiMjViY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCbmJHOWlZV3dnUjNKdmRYQlRhWHBsQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ0ZFhOMElHSmxJR05oYkd4bFpDQnBiaUJuY205MWNBb2dJQ0FnWjNSNGJpQXdJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSFZ1WVhWMGFHOXlhWHBsWkNCallXeHNaWElLSUNBZ0lHZDBlRzRnTUNCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ6Wlc1a1pYSWdiV2x6YldGMFkyZ0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME5pNVVhV05yUW1sMGJXRndMbkJ2YzJsMGFXOXVXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCM2NtOXVaeUJ3Y21WMklHTm9kVzVyQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQnRaWFJvYjJRS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TkRZdVZHbGphMEpwZEcxaGNDNXdiM05wZEdsdmJsdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdWR2xqYTBKcGRHMWhjQzV3YjNOcGRHbHZiZ29nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME5pNVFiMjlzU1dSTWFXSnlZWEo1TG5SdlNXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUTJMbEJ2YjJ4SlpFeHBZbkpoY25rdWRHOUpaRnR5YjNWMGFXNW5YVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURFeE1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVUc5dmJFdGxlUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUTJMbEJ2YjJ4SlpFeHBZbkpoY25rdWRHOUpaRnR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUdkc2IySmhiQ0JIY205MWNGTnBlbVVLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJRzExYzNRZ1ltVWdZMkZzYkdWa0lHbHVJR2R5YjNWd0NpQWdJQ0JuZEhodUlEQWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkVzVoZFhSb2IzSnBlbVZrSUdOaGJHeGxjZ29nSUNBZ1ozUjRiaUF3SUZObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSE5sYm1SbGNpQnRhWE50WVhSamFBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pRMkxsQnZiMnhKWkV4cFluSmhjbmt1ZEc5SlpGdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCamFIVnVhd29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWMyRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ2JXVjBhRzlrQ2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjalEyTGxCdmIyeEpaRXhwWW5KaGNua3VkRzlKWkZ0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQmtkWEFLSUNBZ0lHTmhiR3h6ZFdJZ1VHOXZiRWxrVEdsaWNtRnllUzUwYjBsa0NpQWdJQ0J3YjNBS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUTJMbDlmYVc1cGRGOWZXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWDE5cGJtbDBYMTg2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ1lXeHlaV0ZrZVNCcGJtbDBhV0ZzYVhwbFpBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5BaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjalEyTG1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVJQUVJQUNZSkFXOEJjQ0VCQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQmN5RC8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vd0FBQUFQLy8vOEVGUjk4ZFNBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJBRUlCTUlvQkFpS3ZpLzlYQUNCTEFVeFFTUlVpQ1NKWWkvOVhJQ0JMQWt4UVNSVWlDU0pZVUl2L1YwQUlTd0pNVUVrVklna2lXRkNMLzFkSUNFc0NURkJKRlNJSklsaFFpLzlYVUNCUEFreFFTUlVpQ1NKWVVBS0wvNG1LQVFLTC94WkpnQ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUlBQUFLS0FBUUtxZ0FDcFNVRUFtNHNBSndXcmdDQ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUtkQkFGaUxBVUVBUzRzQUp3V3JKd2lpZ0NEL0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBS3VMQUlBQi82d2tyMGxQQWxCSkZTUUpXMHhQQWxCSkZTUUpXMHhQQTA4RGlZc0FKd2FzUXYreWl3RkJBQXVMQUNjRnF5Y0lva0wveUlzQUp3YXNRdi95aXdBbkJxeEMvMkl4RzBFQUt6RVpGRVF4R0VTQ0JBVEtJVUErQkk1Z2NjOEUyNVYrcndTcGJ2bUpOaG9BamdRQUNRSHFBamNDZ0FBeEdSUXhHQlFRUXlWSk5ob0JGU0lTUkRZYUFra1ZJaEpFTmhvRFNSVWlFa1EyR2dRVkloSkVOaG9GU1JVa0VrUVhLR1JCQUM4eUJJRUNEMFF6QUJnb1pCSkVNd0FBTVFBU1JDbGtRUUFXTVJZakNUZ1lLV1FTUkRFV0l3azVHZ0FuQkdRU1JJR0FnQUVXU3dPc0pSWkpSUWVwUVFBYlN3R0FFSERZYWFGVzBxRzRrTHM5OWl1dk12ZWpLcW9yb2tVQ2dZQ0FBaFpMQTZ4TEJhbEJBQnRMQVlBUU1iNFRYNWZRajltQkl4VUZWQy9QcHFNcXFpdWlSUUtCZ0lBRUZrc0RyRXNGcVVFQUcwc0JnQkFKcWxDTFczcUU0Y1ozM2xUejZadkpveXFxSzZKRkFvR0FnQWdXU3dPc1N3V3BRUUFhU3dHQUQxMXErTjdiZ1JsbW1jTXBJbDdtQktNcXFpdWlSUUtCZ0lBUUZrc0RyRXNGcVVFQUdVc0JnQTRpRnVXRTlmb2VxU1lFRyszK21LTXFxaXVpUlFLQmdJQWdGa3NEckVzRnFVRUFGMHNCZ0F3RWloY0RrZmZjUWtST2o2S2pLcW9yb2tVQ1NSWkpSUVdBQUtWQkFJTkxBNEFJZ0FBQUFBQUFBQUNrUVFCekk0SUNBQUVCVHdKTmdBQ3BRUUFuZ0NELy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vMHNDb2tVQ1N3R0FCUC8vLy8rZ0txcUFJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUVBQUFBQW9ra1ZJZzVFSXErckp3ZE1VTEFqUXlWQy80bzJHZ0ZKRlNRU1JCY29aRUVBTHpJRWdRSVBSRE1BR0Noa0VrUXpBQUF4QUJKRUtXUkJBQll4RmlNSk9CZ3BaQkpFTVJZakNUa2FBQ2NFWkJKRVNZajh6a3dXVEJaUUp3ZE1VTEFqUXpZYUFVa1ZnWEFTUkNoa1FRQXZNZ1NCQWc5RU13QVlLR1FTUkRNQUFERUFFa1FwWkVFQUZqRVdJd2s0R0Nsa0VrUXhGaU1KT1JvQUp3UmtFa1JKaVB3cFNDY0hURkN3STBNMkdnRkpGU1FTUkJjMkdnSkpGU1FTUkJjMkdnTkpKVm1CQWdoTEFSVVNSRmNDQUNoa0ZFUW9Ud05uS1U4Q1p5Y0VUR2NqUXc9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
