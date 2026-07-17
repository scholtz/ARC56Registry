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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.PoolManager__Helper11_01339bfe
{


    //
    // Helper contract 11 for PoolManager
    //
    public class PoolManager__Helper11Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PoolManager__Helper11Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

            public class SwapParams : AVMObjectType
            {
                public byte ZeroForOne { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 AmountSpecified { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 SqrtPriceLimitX96 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vZeroForOne = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vZeroForOne.From(ZeroForOne);
                    ret.AddRange(vZeroForOne.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmountSpecified = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAmountSpecified.From(AmountSpecified);
                    ret.AddRange(vAmountSpecified.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSqrtPriceLimitX96 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vSqrtPriceLimitX96.From(SqrtPriceLimitX96);
                    ret.AddRange(vSqrtPriceLimitX96.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SwapParams Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SwapParams();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vZeroForOne = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vZeroForOne.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueZeroForOne = vZeroForOne.ToValue();
                    if (valueZeroForOne is byte vZeroForOneValue) { ret.ZeroForOne = vZeroForOneValue; }
                    var vAmountSpecified = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAmountSpecified.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.AmountSpecified = vAmountSpecified;
                    var vSqrtPriceLimitX96 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vSqrtPriceLimitX96.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.SqrtPriceLimitX96 = vSqrtPriceLimitX96;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SwapParams);
                }
                public bool Equals(SwapParams? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SwapParams left, SwapParams right)
                {
                    return EqualityComparer<SwapParams>.Default.Equals(left, right);
                }
                public static bool operator !=(SwapParams left, SwapParams right)
                {
                    return !(left == right);
                }

            }

            public class HooksAfterSwapReturn : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
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

                public static HooksAfterSwapReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new HooksAfterSwapReturn();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as HooksAfterSwapReturn);
                }
                public bool Equals(HooksAfterSwapReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(HooksAfterSwapReturn left, HooksAfterSwapReturn right)
                {
                    return EqualityComparer<HooksAfterSwapReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(HooksAfterSwapReturn left, HooksAfterSwapReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///@notice calls afterSwap hook if permissioned and validates return value
        ///</summary>
        /// <param name="self"> </param>
        /// <param name="key"> PoolKey</param>
        /// <param name="params"> SwapParams</param>
        /// <param name="swapDelta"> </param>
        /// <param name="hookData"> </param>
        /// <param name="beforeSwapHookReturn"> </param>
        public async Task<Structs.HooksAfterSwapReturn> HooksAfterSwap(Algorand.Address self, Structs.PoolKey key, Structs.SwapParams @params, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 swapDelta, byte[] hookData, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 beforeSwapHookReturn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 217, 225, 93 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var hookDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hookDataAbi.From(hookData);

            var result = await base.CallApp(new List<object> { abiHandle, selfAbi, key, @params, swapDelta, hookDataAbi, beforeSwapHookReturn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.HooksAfterSwapReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> HooksAfterSwap_Transactions(Algorand.Address self, Structs.PoolKey key, Structs.SwapParams @params, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 swapDelta, byte[] hookData, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 beforeSwapHookReturn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 217, 225, 93 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var hookDataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); hookDataAbi.From(hookData);

            return await base.MakeTransactionList(new List<object> { abiHandle, selfAbi, key, @params, swapDelta, hookDataAbi, beforeSwapHookReturn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9vbE1hbmFnZXJfX0hlbHBlcjExIiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCAxMSBmb3IgUG9vbE1hbmFnZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUG9vbEtleSI6W3sibmFtZSI6ImN1cnJlbmN5MCIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJjdXJyZW5jeTEiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoiZmVlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRpY2tTcGFjaW5nIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Imhvb2tzIiwidHlwZSI6InVpbnQ4WzMyXSJ9XSwiU3dhcFBhcmFtcyI6W3sibmFtZSI6Inplcm9Gb3JPbmUiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJhbW91bnRTcGVjaWZpZWQiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InNxcnRQcmljZUxpbWl0WDk2IiwidHlwZSI6InVpbnQyNTYifV0sIkhvb2tzQWZ0ZXJTd2FwUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDI1NiJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJIb29rcy5hZnRlclN3YXAiLCJkZXNjIjoiQG5vdGljZSBjYWxscyBhZnRlclN3YXAgaG9vayBpZiBwZXJtaXNzaW9uZWQgYW5kIHZhbGlkYXRlcyByZXR1cm4gdmFsdWUiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbGYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50OFszMl0sdWludDhbMzJdLHVpbnQ2NCx1aW50NjQsdWludDhbMzJdKSIsInN0cnVjdCI6IlBvb2xLZXkiLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDgsdWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IlN3YXBQYXJhbXMiLCJuYW1lIjoicGFyYW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3dhcERlbHRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJob29rRGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJlZm9yZVN3YXBIb29rUmV0dXJuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiSG9va3NBZnRlclN3YXBSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfX2luaXRfXyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbOTYyXSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiBhbHJlYWR5IGluaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODI2XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiBtdXN0IGJlIGNhbGxlZCBpbiBncm91cCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg0MV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogc2VuZGVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODM0XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB1bmF1dGhvcml6ZWQgY2FsbGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODU4XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB3cm9uZyBwcmV2IGNodW5rIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODcxXSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB3cm9uZyBwcmV2IG1ldGhvZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5Nyw5NDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NzRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgUG9vbEtleSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc4M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBTd2FwUGFyYW1zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODA0LDk1NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzkxLDgxNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MzAsOTQwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODk0LDkwNl0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU0LDY5M10sImVycm9yTWVzc2FnZSI6InJldmVydCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjakV4TGw5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZktDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURNeUlEQWdNU0F5Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01DQXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFnTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aaUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01DQWlieUlnTUhnNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0lEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQ0F3ZURBeUlDSndJZ29nSUNBZ1lpQmZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYd29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVDWldadmNtVlRkMkZ3UkdWc2RHRk1hV0p5WVhKNUxtZGxkRk53WldOcFptbGxaRVJsYkhSaEtHUmxiSFJoT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2tKbFptOXlaVk4zWVhCRVpXeDBZVXhwWW5KaGNua3VaMlYwVTNCbFkybG1hV1ZrUkdWc2RHRTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0krUFFvZ0lDQWdZbm9nUW1WbWIzSmxVM2RoY0VSbGJIUmhUR2xpY21GeWVTNW5aWFJUY0dWamFXWnBaV1JFWld4MFlWOTBaWEp1WVhKNVgyWmhiSE5sUURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0l2Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZbndLSUNBZ0lISmxkSE4xWWdvS1FtVm1iM0psVTNkaGNFUmxiSFJoVEdsaWNtRnllUzVuWlhSVGNHVmphV1pwWldSRVpXeDBZVjkwWlhKdVlYSjVYMlpoYkhObFFESTZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUx3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMa0psWm05eVpWTjNZWEJFWld4MFlVeHBZbkpoY25rdVoyVjBWVzV6Y0dWamFXWnBaV1JFWld4MFlTaGtaV3gwWVRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwQ1pXWnZjbVZUZDJGd1JHVnNkR0ZNYVdKeVlYSjVMbWRsZEZWdWMzQmxZMmxtYVdWa1JHVnNkR0U2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3T0RBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJdkNpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE1ESUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJR0o2SUVKbFptOXlaVk4zWVhCRVpXeDBZVXhwWW5KaGNua3VaMlYwVlc1emNHVmphV1pwWldSRVpXeDBZVjkwWlhKdVlYSjVYMlpoYkhObFFESUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdKOENpQWdJQ0J5WlhSemRXSUtDa0psWm05eVpWTjNZWEJFWld4MFlVeHBZbkpoY25rdVoyVjBWVzV6Y0dWamFXWnBaV1JFWld4MFlWOTBaWEp1WVhKNVgyWmhiSE5sUURJNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1lpWUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVEZFhOMGIyMVNaWFpsY25RdVluVmlZbXhsVlhCQmJtUlNaWFpsY25SWGFYUm9LSEpsZG1WeWRHbHVaME52Ym5SeVlXTjBPaUJpZVhSbGN5d2djbVYyWlhKMGFXNW5SblZ1WTNScGIyNVRaV3hsWTNSdmNqb2dZbmwwWlhNc0lHRmtaR2wwYVc5dVlXeERiMjUwWlhoME9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS1EzVnpkRzl0VW1WMlpYSjBMbUoxWW1Kc1pWVndRVzVrVW1WMlpYSjBWMmwwYURvS0lDQWdJSEJ5YjNSdklETWdNQW9nSUNBZ1pYSnlJQzh2SUhKbGRtVnlkQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVJYjI5cmN5NWhablJsY2xOM1lYQW9jMlZzWmpvZ1lubDBaWE1zSUd0bGVUb2dZbmwwWlhNc0lIQmhjbUZ0Y3pvZ1lubDBaWE1zSUhOM1lYQkVaV3gwWVRvZ1lubDBaWE1zSUdodmIydEVZWFJoT2lCaWVYUmxjeXdnWW1WbWIzSmxVM2RoY0VodmIydFNaWFIxY200NklHSjVkR1Z6S1NBdFBpQmllWFJsY3l3Z1lubDBaWE1zSUdKNWRHVnpMQ0JpZVhSbGN6b0tTRzl2YTNNdVlXWjBaWEpUZDJGd09nb2dJQ0FnY0hKdmRHOGdOaUEwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pIVndiaUF6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUWUtJQ0FnSUQwOUNpQWdJQ0JpZWlCSWIyOXJjeTVoWm5SbGNsTjNZWEJmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0J5WlhSemRXSUtDa2h2YjJ0ekxtRm1kR1Z5VTNkaGNGOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdRbVZtYjNKbFUzZGhjRVJsYkhSaFRHbGljbUZ5ZVM1blpYUlRjR1ZqYVdacFpXUkVaV3gwWVFvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1FtVm1iM0psVTNkaGNFUmxiSFJoVEdsaWNtRnllUzVuWlhSVmJuTndaV05wWm1sbFpFUmxiSFJoQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5nb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJJYjI5cmN5NW9ZWE5RWlhKdGFYTnphVzl1Q2lBZ0lDQmllaUJJYjI5cmN5NWhablJsY2xOM1lYQmZZV1owWlhKZmFXWmZaV3h6WlVBMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaU5HUTFPVFF3TVNBdkx5QnRaWFJvYjJRZ0ltRm1kR1Z5VTNkaGNDaGhaR1J5WlhOekxITjBjblZqZENCUWIyOXNTMlY1TEhOMGNuVmpkQ0JUZDJGd1VHRnlZVzF6TEhWcGJuUXlOVFlzWW5sMFpWdGRLU2hpZVhSbFd6UmRMSFZwYm5ReU5UWXBJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5nb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJJYjI5cmN5NW9ZWE5RWlhKdGFYTnphVzl1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFlLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdTRzl2YTNNdVkyRnNiRWh2YjJ0WGFYUm9VbVYwZFhKdVJHVnNkR0VLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVU5oYzNRdWRHOUpiblF4TWpnS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmlLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDZ3BJYjI5cmN5NWhablJsY2xOM1lYQmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCaUlUMEtJQ0FnSUdKdWVpQkliMjlyY3k1aFpuUmxjbE4zWVhCZmFXWmZZbTlrZVVBMkNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHSWhQUW9nSUNBZ1lub2dTRzl2YTNNdVlXWjBaWEpUZDJGd1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRBS0NraHZiMnR6TG1GbWRHVnlVM2RoY0Y5cFpsOWliMlI1UURZNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR1Y0ZEhKaFkzUWdNU0F6TWdvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHSThDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdWNGRISmhZM1FnTUNBeENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJRDA5Q2lBZ0lDQmllaUJJYjI5cmN5NWhablJsY2xOM1lYQmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNENpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHTmhiR3h6ZFdJZ2RHOUNZV3hoYm1ObFJHVnNkR0VLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9LU0c5dmEzTXVZV1owWlhKVGQyRndYM1JsY201aGNubGZiV1Z5WjJWQU9Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR05oYkd4emRXSWdjM1ZpQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJQzB6Q2dwSWIyOXJjeTVoWm5SbGNsTjNZWEJmWVdaMFpYSmZhV1pmWld4elpVQXhNRG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUhKbGRITjFZZ29LU0c5dmEzTXVZV1owWlhKVGQyRndYM1JsY201aGNubGZabUZzYzJWQU9Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZMkZzYkhOMVlpQjBiMEpoYkdGdVkyVkVaV3gwWVFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQmlJRWh2YjJ0ekxtRm1kR1Z5VTNkaGNGOTBaWEp1WVhKNVgyMWxjbWRsUURrS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVNHOXZhM011WTJGc2JFaHZiMnNvYzJWc1pqb2dZbmwwWlhNc0lHUmhkR0U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LU0c5dmEzTXVZMkZzYkVodmIyczZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmpZV3hzYzNWaUlFTjFjM1J2YlZKbGRtVnlkQzVpZFdKaWJHVlZjRUZ1WkZKbGRtVnlkRmRwZEdnS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdRM1Z6ZEc5dFVtVjJaWEowTG5KbGRtVnlkRmRwZEdnS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnd0NpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VTRzl2YTNNdVkyRnNiRWh2YjJ0WGFYUm9VbVYwZFhKdVJHVnNkR0VvYzJWc1pqb2dZbmwwWlhNc0lHUmhkR0U2SUdKNWRHVnpMQ0J3WVhKelpWSmxkSFZ5YmpvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS1NHOXZhM011WTJGc2JFaHZiMnRYYVhSb1VtVjBkWEp1UkdWc2RHRTZDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlFaHZiMnR6TG1OaGJHeEliMjlyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSnVlaUJJYjI5cmN5NWpZV3hzU0c5dmExZHBkR2hTWlhSMWNtNUVaV3gwWVY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCeVpYUnpkV0lLQ2todmIydHpMbU5oYkd4SWIyOXJWMmwwYUZKbGRIVnlia1JsYkhSaFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUNFOUNpQWdJQ0JpZWlCSWIyOXJjeTVqWVd4c1NHOXZhMWRwZEdoU1pYUjFjbTVFWld4MFlWOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR05oYkd4emRXSWdRM1Z6ZEc5dFVtVjJaWEowTG5KbGRtVnlkRmRwZEdnS0NraHZiMnR6TG1OaGJHeEliMjlyVjJsMGFGSmxkSFZ5YmtSbGJIUmhYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JqWVd4c2MzVmlJRkJoY25ObFFubDBaWE11Y0dGeWMyVlNaWFIxY201RVpXeDBZUW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGtodmIydHpMbWhoYzFCbGNtMXBjM05wYjI0b2MyVnNaam9nWW5sMFpYTXNJR1pzWVdjNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNraHZiMnR6TG1oaGMxQmxjbTFwYzNOcGIyNDZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlKZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUdJaFBRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJoY25ObFFubDBaWE11Y0dGeWMyVlNaWFIxY201RVpXeDBZU2h5WlhOMWJIUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tVR0Z5YzJWQ2VYUmxjeTV3WVhKelpWSmxkSFZ5YmtSbGJIUmhPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VjM1ZpS0dFNklHSjVkR1Z6TENCaU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNuTjFZam9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE9EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWo0OUNpQWdJQ0JpZWlCemRXSmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpTHdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1NREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0o4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLQ25OMVlsOTBaWEp1WVhKNVgyMWxjbWRsUURNNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpTHdvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURBeUNpQWdJQ0JpSlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQmllaUJ6ZFdKZmRHVnlibUZ5ZVY5bVlXeHpaVUExQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVpqQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlmQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDZ3B6ZFdKZmRHVnlibUZ5ZVY5dFpYSm5aVUEyT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWXlBMklDOHZJREI0T0RBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZajQ5Q2lBZ0lDQmllaUJ6ZFdKZmRHVnlibUZ5ZVY5bVlXeHpaVUE0Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlMd29nSUNBZ1lubDBaV05mTWlBdkx5QXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSjhDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtDbk4xWWw5MFpYSnVZWEo1WDIxbGNtZGxRRGs2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlMd29nSUNBZ1lubDBaV01nT0NBdkx5QXdlREF5Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCaWVpQnpkV0pmZEdWeWJtRnllVjltWVd4elpVQXhNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1Zd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lud0tDbk4xWWw5MFpYSnVZWEo1WDIxbGNtZGxRREV5T2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZEWVhOMExuUnZTVzUwTVRJNENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WRFlYTjBMblJ2U1c1ME1USTRDaUFnSUNCallXeHNjM1ZpSUhSdlFtRnNZVzVqWlVSbGJIUmhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LYzNWaVgzUmxjbTVoY25sZlptRnNjMlZBTVRFNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aZ29nSUNBZ1lpWUtJQ0FnSUdJZ2MzVmlYM1JsY201aGNubGZiV1Z5WjJWQU1USUtDbk4xWWw5MFpYSnVZWEo1WDJaaGJITmxRRGc2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlMd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNCaUlITjFZbDkwWlhKdVlYSjVYMjFsY21kbFFEa0tDbk4xWWw5MFpYSnVZWEo1WDJaaGJITmxRRFU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVpnb2dJQ0FnWWlZS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdZaUJ6ZFdKZmRHVnlibUZ5ZVY5dFpYSm5aVUEyQ2dwemRXSmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWk4S0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdZaUJ6ZFdKZmRHVnlibUZ5ZVY5dFpYSm5aVUF6Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTG5SdlFtRnNZVzVqWlVSbGJIUmhLRjloYlc5MWJuUXdPaUJpZVhSbGN5d2dYMkZ0YjNWdWRERTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tkRzlDWVd4aGJtTmxSR1ZzZEdFNkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0ltQ2lBZ0lDQmlmQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGtOMWMzUnZiVkpsZG1WeWRDNXlaWFpsY25SWGFYUm9LREVwS0hObGJHVmpkRzl5T2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LUTNWemRHOXRVbVYyWlhKMExuSmxkbVZ5ZEZkcGRHZzZDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJR1Z5Y2lBdkx5QnlaWFpsY25RS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVUyRm1aVU5oYzNRdWRHOUpiblF4TWpnb01TbGZNQ2g0T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2xOaFptVkRZWE4wTG5SdlNXNTBNVEk0T2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUlUMEtJQ0FnSUdKNklGTmhabVZEWVhOMExuUnZTVzUwTVRJNFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZMkZzYkhOMVlpQkRkWE4wYjIxU1pYWmxjblF1Y21WMlpYSjBWMmwwYUFvS1UyRm1aVU5oYzNRdWRHOUpiblF4TWpoZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lITjNZWEFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU1URXVYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMThvS1NBdFBpQjFhVzUwTmpRNkNsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRjlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmWDE5ZlltRnlaVjlqY21WaGRHVmZYMEE0Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGczTjJRNVpURTFaQ0F3ZUdFNU5tVm1PVGc1SUM4dklHMWxkR2h2WkNBaVNHOXZhM011WVdaMFpYSlRkMkZ3S0dGa1pISmxjM01zS0hWcGJuUTRXek15WFN4MWFXNTBPRnN6TWwwc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME9Gc3pNbDBwTENoMWFXNTBPQ3gxYVc1ME1qVTJMSFZwYm5ReU5UWXBMSFZwYm5ReU5UWXNZbmwwWlZ0ZExIVnBiblF5TlRZcEtIVnBiblF5TlRZc2RXbHVkREkxTmlraUxDQnRaWFJvYjJRZ0lsOWZhVzVwZEY5ZktIVnBiblEyTkN4MWFXNTBOalFzWW5sMFpWdGRLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pFeExraHZiMnR6TG1GbWRHVnlVM2RoY0Z0eWIzVjBhVzVuWFNCZlgybHVhWFJmWHdvZ0lDQWdaWEp5Q2dwZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlgxOWZYMkpoY21WZlkzSmxZWFJsWDE5QU9Eb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEl4TVM1SWIyOXJjeTVoWm5SbGNsTjNZWEJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjakV4TGtodmIydHpMbUZtZEdWeVUzZGhjRnR5YjNWMGFXNW5YVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRFeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJRYjI5c1MyVjVDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EyTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdVM2RoY0ZCaGNtRnRjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKdklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdKNklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TVRFdVNHOXZhM011WVdaMFpYSlRkMkZ3VzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCdGRYTjBJR0psSUdOaGJHeGxaQ0JwYmlCbmNtOTFjQW9nSUNBZ1ozUjRiaUF3SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhWdVlYVjBhRzl5YVhwbFpDQmpZV3hzWlhJS0lDQWdJR2QwZUc0Z01DQlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCelpXNWtaWElnYldsemJXRjBZMmdLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSXhNUzVJYjI5cmN5NWhablJsY2xOM1lYQmJjbTkxZEdsdVoxMWZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ1kyaDFibXNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTmhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ2JXVjBhRzlrQ2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjakV4TGtodmIydHpMbUZtZEdWeVUzZGhjRnR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVTZDaUFnSUNCa2FXY2dOUW9nSUNBZ1pHbG5JRFVLSUNBZ0lHUnBaeUExQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaR2xuSURVS0lDQWdJR1JwWnlBMUNpQWdJQ0JqWVd4c2MzVmlJRWh2YjJ0ekxtRm1kR1Z5VTNkaGNBb2dJQ0FnY0c5d2JpQXlDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUdScFp5QXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbndLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJeE1TNWZYMmx1YVhSZlgxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbDlmYVc1cGRGOWZPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJoYkhKbFlXUjVJR2x1YVhScFlXeHBlbVZrQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p2SWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nT1NBdkx5QWljQ0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqRXhMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUlBQUJBaVlLQUNBQUFBQUFBQUFBQUFBQUFBQUFBQUFCQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0QvLy8vLy8vLy8vLy8vLy8vLy8vLy9BQUFBQUFBQUFBQUFBQUFBQUFBQUFCRC8vLy8vLy8vLy8vLy8vLy8vLy8vL0lRRUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFGdklJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUNBQUFBQUFBQUFBQUFBQUFBQUFBQUFBUUlCY0VJQ0Fvb0JBWXYvSndhblFRQUhpLzhwb2lxcmlZdi9LYUtKaWdFQmkvOG5CNkluQ0tvb3FVRUFCWXYvS3F1SmkvOHJySW1LQXdBQWlnWUVJMGNETVFDTCtoSkJBQklqRm92OVRJdjdpL3hQQjA4SFR3ZFBCNG1MLzRqL3Bvd0JpLytJLzdhTUFvRkFGb3Y2VElnQXkwRUFOb0FFdE5XVUFURUFVSXY3VUl2OFVDS3ZpLzFRU1JVaUNTSllVSXYrVUlFRUZvdjZUSWdBb1l2NlRnS0lBSE9JQVV5TEFxQ01BaWlNQUNNV1NZd0Rpd0twUUFBSWl3R0xBNmxCQUNXTC9GY0JJSXNEcEl2OFZ3QUJLS2tTUVFBaml3R0xBb2dCQTR3QWkvMkxBSWdBYW96OWkvMkxBSXY3aS94UEIwOEhUd2RQQjRtTEFvc0JpQURnakFCQy85cUtBZ0dML292L0tJai9LU2lJQU55QUFZQ0ppZ01CaS8yTC9vai80NHYvUUFBRUl4Wk1pWXNBRllGQUUwRUFCQ2lJQUxpTEFJZ0FEa3lKaWdJQmkvNkwvNndqRnFtSmlnRUJLSW1LQWdFalJ3S0wvaWNHcDBFQWVZditLYUlxcTR3QWkvNG5CNkluQ0tvb3FVRUFXNHYrS3F1TUFZdi9Kd2FuUVFCRWkvOHBvaXFyakFLTC95Y0hvaWNJcWlpcFFRQW9pLzhxcTRzQUp3U2dpd0toSndTcWl3RW5CS0JQQXFFbkJLcE1pQUJBVElnQVBJZ0FKWXdBaVl2L0s2eEMvOVdML3ltaWpBSkMvN3VML2l1c2pBRkMvNktML2ltaWpBQkMvNGFLQWdHTC9pbWpKd1NxSzR2L3JLdUppZ0VBQUlvQkFZdi9LNnhKaS8rcFFRQUVLSWovNm9zQVRJa3hHMEVBSFRFWkZFUXhHRVNDQWdSMzJlRmRCS2x1K1lrMkdnQ09BZ0FKQUswQU1Sa1VNUmdVRUVNMkdnRkpGU0lTUkRZYUFra1ZnWEFTUkRZYUEwa1ZnVUVTUkRZYUJFa1ZJaEpFTmhvRlNTTlpKUWhMQVJVU1JGY0NBRFlhQmtrVkloSkVKd1ZrUVFBeU1nUWxEMFF6QUJnbkJXUVNSRE1BQURFQUVrUW5DV1JCQUJneEZpUUpPQmduQ1dRU1JERVdKQWs1R2dDQUFYTmtFa1JMQlVzRlN3VkxCVXNGU3dXSS9ZaEdBa3hKRlNJT1JDS3ZURXNCcTBzQ0ZTSU9SRTRDcTFDQUJCVWZmSFZNVUxBa1F6WWFBVWtWZ1FnU1JCYzJHZ0pKRllFSUVrUVhOaG9EU1NOWkpRaExBUlVTUkZjQ0FDY0ZaQlJFSndWUEEyY25DVThDWjRBQmMweG5KRU09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
