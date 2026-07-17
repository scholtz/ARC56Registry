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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.PoolManager__Helper49_742c3dbd
{


    //
    // Helper contract 49 for PoolManager
    //
    public class PoolManager__Helper49Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PoolManager__Helper49Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Tuple : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Previous { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Next { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrevious = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vPrevious.From(Previous);
                    ret.AddRange(vPrevious.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNext = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vNext.From(Next);
                    ret.AddRange(vNext.Encode());
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
                    var vPrevious = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vPrevious.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Previous = vPrevious;
                    var vNext = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vNext.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Next = vNext;
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

            public class SwapMathComputeSwapStepChunk0Return : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field2 { get; set; }

                public bool Field3 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field4 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field5 { get; set; }

                public bool Field6 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField5 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField5.From(Field5);
                    ret.AddRange(vField5.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField6.From(Field6);
                    ret.AddRange(vField6.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static SwapMathComputeSwapStepChunk0Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new SwapMathComputeSwapStepChunk0Return();
                    uint count = 0;
                    var vField0 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field0 = vField0;
                    var vField1 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field1 = vField1;
                    var vField2 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field2 = vField2;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is bool vField3Value) { ret.Field3 = vField3Value; }
                    var vField4 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field4 = vField4;
                    var vField5 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField5.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field5 = vField5;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField6 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField6.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField6 = vField6.ToValue();
                    if (valueField6 is bool vField6Value) { ret.Field6 = vField6Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as SwapMathComputeSwapStepChunk0Return);
                }
                public bool Equals(SwapMathComputeSwapStepChunk0Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(SwapMathComputeSwapStepChunk0Return left, SwapMathComputeSwapStepChunk0Return right)
                {
                    return EqualityComparer<SwapMathComputeSwapStepChunk0Return>.Default.Equals(left, right);
                }
                public static bool operator !=(SwapMathComputeSwapStepChunk0Return left, SwapMathComputeSwapStepChunk0Return right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///@notice bubble up the revert message returned by a call and revert with a wrapped ERC-7751 error
        /// @dev this method can be vulnerable to revert data bombs
        ///</summary>
        /// <param name="revertingContract"> </param>
        /// <param name="revertingFunctionSelector"> </param>
        /// <param name="additionalContext"> </param>
        public async Task CustomRevertBubbleUpAndRevertWith(Algorand.Address revertingContract, byte[] revertingFunctionSelector, byte[] additionalContext, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 165, 69, 249 };
            var revertingContractAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); revertingContractAbi.From(revertingContract);
            var revertingFunctionSelectorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); revertingFunctionSelectorAbi.From(revertingFunctionSelector);
            var additionalContextAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); additionalContextAbi.From(additionalContext);

            var result = await base.SimApp(new List<object> { abiHandle, revertingContractAbi, revertingFunctionSelectorAbi, additionalContextAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CustomRevertBubbleUpAndRevertWith_Transactions(Algorand.Address revertingContract, byte[] revertingFunctionSelector, byte[] additionalContext, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 132, 165, 69, 249 };
            var revertingContractAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); revertingContractAbi.From(revertingContract);
            var revertingFunctionSelectorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); revertingFunctionSelectorAbi.From(revertingFunctionSelector);
            var additionalContextAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte"); additionalContextAbi.From(additionalContext);

            return await base.MakeTransactionList(new List<object> { abiHandle, revertingContractAbi, revertingFunctionSelectorAbi, additionalContextAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///extracts int128 from the lower 128 bits of the BeforeSwapDelta
        /// returned by beforeSwap and afterSwap
        ///</summary>
        /// <param name="delta"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> BeforeSwapDeltaLibraryGetUnspecifiedDelta(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 delta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 183, 14, 246 };

            var result = await base.SimApp(new List<object> { abiHandle, delta }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> BeforeSwapDeltaLibraryGetUnspecifiedDelta_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 delta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 183, 14, 246 };

            return await base.MakeTransactionList(new List<object> { abiHandle, delta }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice applies a new currency delta for a given account and currency
        /// @return previous The prior value
        /// @return next The modified result
        ///</summary>
        /// <param name="currency"> </param>
        /// <param name="target"> </param>
        /// <param name="delta"> </param>
        public async Task<Structs.Tuple> CurrencyDeltaApplyDelta(Algorand.Address currency, Algorand.Address target, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 delta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 219, 223, 232 };
            var currencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); currencyAbi.From(currency);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            var result = await base.CallApp(new List<object> { abiHandle, currencyAbi, targetAbi, delta }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Tuple.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> CurrencyDeltaApplyDelta_Transactions(Algorand.Address currency, Algorand.Address target, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 delta, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 219, 223, 232 };
            var currencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); currencyAbi.From(currency);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            return await base.MakeTransactionList(new List<object> { abiHandle, currencyAbi, targetAbi, delta }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice Potential to underflow. Ensure checks are performed by integrating contracts to ensure this does not happen.
        /// Current usage ensures this will not happen because we call decrement with known boundaries (only up to the number of times we call increment).
        ///</summary>
        public async Task NonzeroDeltaCountDecrement(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 95, 220, 216 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> NonzeroDeltaCountDecrement_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 95, 220, 216 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="self"> </param>
        public async Task<bool> ProtocolFeeLibraryIsValidProtocolFee(ulong self, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 223, 72, 1 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); selfAbi.From(self);

            var result = await base.SimApp(new List<object> { abiHandle, selfAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ProtocolFeeLibraryIsValidProtocolFee_Transactions(ulong self, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 223, 72, 1 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); selfAbi.From(self);

            return await base.MakeTransactionList(new List<object> { abiHandle, selfAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="sqrtPriceCurrentX96"> </param>
        /// <param name="sqrtPriceTargetX96"> </param>
        /// <param name="liquidity"> </param>
        /// <param name="amountRemaining"> </param>
        /// <param name="feePips"> </param>
        public async Task<Structs.SwapMathComputeSwapStepChunk0Return> SwapMathComputeSwapStepChunk0(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 sqrtPriceCurrentX96, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 sqrtPriceTargetX96, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 liquidity, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amountRemaining, ulong feePips, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 66, 53, 213 };
            var feePipsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feePipsAbi.From(feePips);

            var result = await base.SimApp(new List<object> { abiHandle, sqrtPriceCurrentX96, sqrtPriceTargetX96, liquidity, amountRemaining, feePipsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.SwapMathComputeSwapStepChunk0Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> SwapMathComputeSwapStepChunk0_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 sqrtPriceCurrentX96, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 sqrtPriceTargetX96, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 liquidity, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 amountRemaining, ulong feePips, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 66, 53, 213 };
            var feePipsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feePipsAbi.From(feePips);

            return await base.MakeTransactionList(new List<object> { abiHandle, sqrtPriceCurrentX96, sqrtPriceTargetX96, liquidity, amountRemaining, feePipsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice Ensures that the hook address includes at least one hook flag or dynamic fees, or is the 0 address
        /// @param self The hook to verify
        /// @param fee The fee of the pool the hook is used with
        /// @return bool True if the hook address is valid
        ///</summary>
        /// <param name="self"> </param>
        /// <param name="fee"> </param>
        public async Task<bool> HooksIsValidHookAddress(Algorand.Address self, ulong fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 126, 14, 126 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeAbi.From(fee);

            var result = await base.SimApp(new List<object> { abiHandle, selfAbi, feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> HooksIsValidHookAddress_Transactions(Algorand.Address self, ulong fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 126, 14, 126 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); selfAbi.From(self);
            var feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeAbi.From(fee);

            return await base.MakeTransactionList(new List<object> { abiHandle, selfAbi, feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="currency"> </param>
        /// <param name="target"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> CurrencyDeltaGetDelta(Algorand.Address currency, Algorand.Address target, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 125, 69, 143 };
            var currencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); currencyAbi.From(currency);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            var result = await base.CallApp(new List<object> { abiHandle, currencyAbi, targetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> CurrencyDeltaGetDelta_Transactions(Algorand.Address currency, Algorand.Address target, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 125, 69, 143 };
            var currencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); currencyAbi.From(currency);
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);

            return await base.MakeTransactionList(new List<object> { abiHandle, currencyAbi, targetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice Returns ceil(x / y)
        /// @dev division by 0 will return 0, and should be checked externally
        /// @param x The dividend
        /// @param y The divisor
        /// @return z The quotient, ceil(x / y)
        ///</summary>
        /// <param name="x"> </param>
        /// <param name="y"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> UnsafeMathDivRoundingUp(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 154, 208, 21 };

            var result = await base.SimApp(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> UnsafeMathDivRoundingUp_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 154, 208, 21 };

            return await base.MakeTransactionList(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice A helper function to calculate the position key
        /// @param owner The address of the position owner
        /// @param tickLower the lower tick boundary of the position
        /// @param tickUpper the upper tick boundary of the position
        /// @param salt A unique value to differentiate between multiple positions in the same range, by the same owner. Passed in by the caller.
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="tickLower"> </param>
        /// <param name="tickUpper"> </param>
        /// <param name="salt"> </param>
        public async Task<byte[]> PositionCalculatePositionKey(Algorand.Address owner, ulong tickLower, ulong tickUpper, byte[] salt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 236, 178, 111 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var tickLowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickLowerAbi.From(tickLower);
            var tickUpperAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickUpperAbi.From(tickUpper);
            var saltAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); saltAbi.From(salt);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi, tickLowerAbi, tickUpperAbi, saltAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> PositionCalculatePositionKey_Transactions(Algorand.Address owner, ulong tickLower, ulong tickUpper, byte[] salt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 236, 178, 111 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var tickLowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickLowerAbi.From(tickLower);
            var tickUpperAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickUpperAbi.From(tickUpper);
            var saltAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); saltAbi.From(salt);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, tickLowerAbi, tickUpperAbi, saltAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="currency"> </param>
        /// <param name="value"> </param>
        public async Task CurrencyReservesSyncCurrencyAndReserves(Algorand.Address currency, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 83, 222, 114 };
            var currencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); currencyAbi.From(currency);

            var result = await base.CallApp(new List<object> { abiHandle, currencyAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CurrencyReservesSyncCurrencyAndReserves_Transactions(Algorand.Address currency, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 83, 222, 114 };
            var currencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); currencyAbi.From(currency);

            return await base.MakeTransactionList(new List<object> { abiHandle, currencyAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="_packed"> </param>
        public async Task<ulong> Slot0LibraryProtocolFee(byte[] _packed, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 204, 95, 93 };
            var _packedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _packedAbi.From(_packed);

            var result = await base.SimApp(new List<object> { abiHandle, _packedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Slot0LibraryProtocolFee_Transactions(byte[] _packed, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 204, 95, 93 };
            var _packedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); _packedAbi.From(_packed);

            return await base.MakeTransactionList(new List<object> { abiHandle, _packedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        public async Task<Algorand.Address> CurrencyLibraryFromId(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 123, 215, 6 };

            var result = await base.SimApp(new List<object> { abiHandle, id }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> CurrencyLibraryFromId_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 123, 215, 6 };

            return await base.MakeTransactionList(new List<object> { abiHandle, id }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9vbE1hbmFnZXJfX0hlbHBlcjQ5IiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCA0OSBmb3IgUG9vbE1hbmFnZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsidHVwbGUiOlt7Im5hbWUiOiJwcmV2aW91cyIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoibmV4dCIsInR5cGUiOiJ1aW50MjU2In1dLCJTd2FwTWF0aENvbXB1dGVTd2FwU3RlcENodW5rMFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiZmllbGQ0IiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDUiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkNiIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6IkN1c3RvbVJldmVydC5idWJibGVVcEFuZFJldmVydFdpdGgiLCJkZXNjIjoiQG5vdGljZSBidWJibGUgdXAgdGhlIHJldmVydCBtZXNzYWdlIHJldHVybmVkIGJ5IGEgY2FsbCBhbmQgcmV2ZXJ0IHdpdGggYSB3cmFwcGVkIEVSQy03NzUxIGVycm9yXG4gQGRldiB0aGlzIG1ldGhvZCBjYW4gYmUgdnVsbmVyYWJsZSB0byByZXZlcnQgZGF0YSBib21icyIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmV2ZXJ0aW5nQ29udHJhY3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXZlcnRpbmdGdW5jdGlvblNlbGVjdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkaXRpb25hbENvbnRleHQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJCZWZvcmVTd2FwRGVsdGFMaWJyYXJ5LmdldFVuc3BlY2lmaWVkRGVsdGEiLCJkZXNjIjoiZXh0cmFjdHMgaW50MTI4IGZyb20gdGhlIGxvd2VyIDEyOCBiaXRzIG9mIHRoZSBCZWZvcmVTd2FwRGVsdGFcbiByZXR1cm5lZCBieSBiZWZvcmVTd2FwIGFuZCBhZnRlclN3YXAiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbHRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiQ3VycmVuY3lEZWx0YS5hcHBseURlbHRhIiwiZGVzYyI6IkBub3RpY2UgYXBwbGllcyBhIG5ldyBjdXJyZW5jeSBkZWx0YSBmb3IgYSBnaXZlbiBhY2NvdW50IGFuZCBjdXJyZW5jeVxuIEByZXR1cm4gcHJldmlvdXMgVGhlIHByaW9yIHZhbHVlXG4gQHJldHVybiBuZXh0IFRoZSBtb2RpZmllZCByZXN1bHQiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImN1cnJlbmN5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsdGEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJ0dXBsZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Ik5vbnplcm9EZWx0YUNvdW50LmRlY3JlbWVudCIsImRlc2MiOiJAbm90aWNlIFBvdGVudGlhbCB0byB1bmRlcmZsb3cuIEVuc3VyZSBjaGVja3MgYXJlIHBlcmZvcm1lZCBieSBpbnRlZ3JhdGluZyBjb250cmFjdHMgdG8gZW5zdXJlIHRoaXMgZG9lcyBub3QgaGFwcGVuLlxuIEN1cnJlbnQgdXNhZ2UgZW5zdXJlcyB0aGlzIHdpbGwgbm90IGhhcHBlbiBiZWNhdXNlIHdlIGNhbGwgZGVjcmVtZW50IHdpdGgga25vd24gYm91bmRhcmllcyAob25seSB1cCB0byB0aGUgbnVtYmVyIG9mIHRpbWVzIHdlIGNhbGwgaW5jcmVtZW50KS4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiUHJvdG9jb2xGZWVMaWJyYXJ5LmlzVmFsaWRQcm90b2NvbEZlZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiU3dhcE1hdGguY29tcHV0ZVN3YXBTdGVwX19jaHVua18wIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcXJ0UHJpY2VDdXJyZW50WDk2IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3FydFByaWNlVGFyZ2V0WDk2IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGlxdWlkaXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50UmVtYWluaW5nIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVQaXBzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYsdWludDI1Nixib29sLHVpbnQyNTYsdWludDI1Nixib29sKSIsInN0cnVjdCI6IlN3YXBNYXRoQ29tcHV0ZVN3YXBTdGVwQ2h1bmswUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJIb29rcy5pc1ZhbGlkSG9va0FkZHJlc3MiLCJkZXNjIjoiQG5vdGljZSBFbnN1cmVzIHRoYXQgdGhlIGhvb2sgYWRkcmVzcyBpbmNsdWRlcyBhdCBsZWFzdCBvbmUgaG9vayBmbGFnIG9yIGR5bmFtaWMgZmVlcywgb3IgaXMgdGhlIDAgYWRkcmVzc1xuIEBwYXJhbSBzZWxmIFRoZSBob29rIHRvIHZlcmlmeVxuIEBwYXJhbSBmZWUgVGhlIGZlZSBvZiB0aGUgcG9vbCB0aGUgaG9vayBpcyB1c2VkIHdpdGhcbiBAcmV0dXJuIGJvb2wgVHJ1ZSBpZiB0aGUgaG9vayBhZGRyZXNzIGlzIHZhbGlkIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZWxmIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJDdXJyZW5jeURlbHRhLmdldERlbHRhIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdXJyZW5jeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRhcmdldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJVbnNhZmVNYXRoLmRpdlJvdW5kaW5nVXAiLCJkZXNjIjoiQG5vdGljZSBSZXR1cm5zIGNlaWwoeCAvIHkpXG4gQGRldiBkaXZpc2lvbiBieSAwIHdpbGwgcmV0dXJuIDAsIGFuZCBzaG91bGQgYmUgY2hlY2tlZCBleHRlcm5hbGx5XG4gQHBhcmFtIHggVGhlIGRpdmlkZW5kXG4gQHBhcmFtIHkgVGhlIGRpdmlzb3JcbiBAcmV0dXJuIHogVGhlIHF1b3RpZW50LCBjZWlsKHggLyB5KSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJQb3NpdGlvbi5jYWxjdWxhdGVQb3NpdGlvbktleSIsImRlc2MiOiJAbm90aWNlIEEgaGVscGVyIGZ1bmN0aW9uIHRvIGNhbGN1bGF0ZSB0aGUgcG9zaXRpb24ga2V5XG4gQHBhcmFtIG93bmVyIFRoZSBhZGRyZXNzIG9mIHRoZSBwb3NpdGlvbiBvd25lclxuIEBwYXJhbSB0aWNrTG93ZXIgdGhlIGxvd2VyIHRpY2sgYm91bmRhcnkgb2YgdGhlIHBvc2l0aW9uXG4gQHBhcmFtIHRpY2tVcHBlciB0aGUgdXBwZXIgdGljayBib3VuZGFyeSBvZiB0aGUgcG9zaXRpb25cbiBAcGFyYW0gc2FsdCBBIHVuaXF1ZSB2YWx1ZSB0byBkaWZmZXJlbnRpYXRlIGJldHdlZW4gbXVsdGlwbGUgcG9zaXRpb25zIGluIHRoZSBzYW1lIHJhbmdlLCBieSB0aGUgc2FtZSBvd25lci4gUGFzc2VkIGluIGJ5IHRoZSBjYWxsZXIuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGlja0xvd2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aWNrVXBwZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2FsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJDdXJyZW5jeVJlc2VydmVzLnN5bmNDdXJyZW5jeUFuZFJlc2VydmVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdXJyZW5jeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlNsb3QwTGlicmFyeS5wcm90b2NvbEZlZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9wYWNrZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IkN1cnJlbmN5TGlicmFyeS5mcm9tSWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX19pbml0X18iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIxMDhdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IGFscmVhZHkgaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDAwLDEwNjksMTE2MSwxMjQ5LDEzMTQsMTQyMSwxNTMyLDE2MTQsMTY5OCwxODAyLDE4ODUsMTk0OSwyMDE4XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiBtdXN0IGJlIGNhbGxlZCBpbiBncm91cCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMTQsMTA4MywxMTc1LDEyNjMsMTMyOCwxNDM1LDE1NDYsMTYyOCwxNzEyLDE4MTYsMTg5OSwxOTYzLDIwMzJdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHNlbmRlciBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMDcsMTA3NiwxMTY4LDEyNTYsMTMyMSwxNDI4LDE1MzksMTYyMSwxNzA1LDE4MDksMTg5MiwxOTU2LDIwMjVdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHVuYXV0aG9yaXplZCBjYWxsZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDI5LDEwOTgsMTE5MCwxMjc4LDEzNDMsMTQ1MCwxNTYxLDE2NDMsMTcyNywxODMxLDE5MTQsMTk3OCwyMDQ3XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB3cm9uZyBwcmV2IGNodW5rIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0MCwxMTA5LDEyMDEsMTI4OSwxMzU0LDE0NjEsMTU3MiwxNjU0LDE3MzgsMTg0MiwxOTI1LDE5ODksMjA1OF0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBtZXRob2QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDk0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEwMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NzIsMTEzNSwxMTQzLDE1MTIsMTU5NiwxNjA0LDE3NjQsMTc5MiwxODY3LDE5MzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTgxLDk5MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNTksMTE1MSwxMzc4LDEzODYsMTM5MywxNDAxLDE2ODAsMTY4OCwxODc1LDIwMDhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MjU2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMwMywxNDEwLDE1MjEsMTc3MywxNzgzLDIwNzcsMjA4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMTgsMTIxNiwxMjI5LDE2NjMsMTc0N10sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI0XSwiZXJyb3JNZXNzYWdlIjoicmV2ZXJ0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUTVMbDlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmS0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREVnTXpJZ01pQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklDSnZJaUFpY0NJZ0luTWlJREI0TVRVeFpqZGpOelVnTUhnd01TQXdlREF3SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdJREI0TldZMVpqYzBOV1l6TVRNd016QWdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUlEQjROVFppTUdOak16VTFaR1psTVRoaVpEVm1Zak16WmpKaU5qUTVNelEyT0dFME5tWTJNelpoWW1FMU0yUm1ZakprTVRWaE1ETmxaakprTlRRNU16QXpOU0F3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSUY5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZkNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xrSmxabTl5WlZOM1lYQkVaV3gwWVV4cFluSmhjbmt1WjJWMFZXNXpjR1ZqYVdacFpXUkVaV3gwWVNoa1pXeDBZVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BDWldadmNtVlRkMkZ3UkdWc2RHRk1hV0p5WVhKNUxtZGxkRlZ1YzNCbFkybG1hV1ZrUkdWc2RHRTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQTRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaThLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF5Q2lBZ0lDQmlKUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCaUlUMEtJQ0FnSUdKNklFSmxabTl5WlZOM1lYQkVaV3gwWVV4cFluSmhjbmt1WjJWMFZXNXpjR1ZqYVdacFpXUkVaV3gwWVY5MFpYSnVZWEo1WDJaaGJITmxRRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1Zd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lud0tJQ0FnSUhKbGRITjFZZ29LUW1WbWIzSmxVM2RoY0VSbGJIUmhUR2xpY21GeWVTNW5aWFJWYm5Od1pXTnBabWxsWkVSbGJIUmhYM1JsY201aGNubGZabUZzYzJWQU1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlLSUNBZ0lHSW1DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1UTNWeWNtVnVZM2xFWld4MFlTNWhjSEJzZVVSbGJIUmhLR04xY25KbGJtTjVPaUJpZVhSbGN5d2dkR0Z5WjJWME9pQmllWFJsY3l3Z1pHVnNkR0U2SUdKNWRHVnpLU0F0UGlCaWVYUmxjeXdnWW5sMFpYTTZDa04xY25KbGJtTjVSR1ZzZEdFdVlYQndiSGxFWld4MFlUb0tJQ0FnSUhCeWIzUnZJRE1nTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TldZMVpqYzBOV1l6TVRNek16SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnMVpqVm1OelExWmpNeE16QXpNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVEzVnljbVZ1WTNsRVpXeDBZUzVuWlhSRVpXeDBZU2hqZFhKeVpXNWplVG9nWW5sMFpYTXNJSFJoY21kbGREb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncERkWEp5Wlc1amVVUmxiSFJoTG1kbGRFUmxiSFJoT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjROV1kxWmpjME5XWXpNVE13TXpBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VRM1Z5Y21WdVkzbE1hV0p5WVhKNUxtWnliMjFKWkNocFpEb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncERkWEp5Wlc1amVVeHBZbkpoY25rdVpuSnZiVWxrT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQmlKZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGtOMWNuSmxibU41VW1WelpYSjJaWE11YzNsdVkwTjFjbkpsYm1ONVFXNWtVbVZ6WlhKMlpYTW9ZM1Z5Y21WdVkzazZJR0o1ZEdWekxDQjJZV3gxWlRvZ1lubDBaWE1wSUMwK0lIWnZhV1E2Q2tOMWNuSmxibU41VW1WelpYSjJaWE11YzNsdVkwTjFjbkpsYm1ONVFXNWtVbVZ6WlhKMlpYTTZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUdJbUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaFlUYzJNVGMwWmpObFlqYzVOalprTVRkaE16bGpaR1F4TnpNMU5EQmpNVGd6TUdSaU16WTRNRGhoWldGaVpEUmlObUZtWm1VeFpUYzBNbU5oWm1Vd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9XUmhNV0U0WkRBd056UmhOV1ZsTWpWa016TXhaV0kyWWpGalptUTBPV05oTXpVd05qQXhOV1prWmprNU9EVTJaR1EyWldFd1l6QTVOVEEzWlRsaFlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMa04xYzNSdmJWSmxkbVZ5ZEM1aWRXSmliR1ZWY0VGdVpGSmxkbVZ5ZEZkcGRHZ29jbVYyWlhKMGFXNW5RMjl1ZEhKaFkzUTZJR0o1ZEdWekxDQnlaWFpsY25ScGJtZEdkVzVqZEdsdmJsTmxiR1ZqZEc5eU9pQmllWFJsY3l3Z1lXUmthWFJwYjI1aGJFTnZiblJsZUhRNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwRGRYTjBiMjFTWlhabGNuUXVZblZpWW14bFZYQkJibVJTWlhabGNuUlhhWFJvT2dvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNCbGNuSWdMeThnY21WMlpYSjBDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMa2h2YjJ0ekxtaGhjMUJsY20xcGMzTnBiMjRvYzJWc1pqb2dZbmwwWlhNc0lHWnNZV2M2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q2todmIydHpMbWhoYzFCbGNtMXBjM05wYjI0NkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUpnb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJR0loUFFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xraHZiMnR6TG1selZtRnNhV1JJYjI5clFXUmtjbVZ6Y3loelpXeG1PaUJpZVhSbGN5d2dabVZsT2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS1NHOXZhM011YVhOV1lXeHBaRWh2YjJ0QlpHUnlaWE56T2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCd2RYTm9hVzUwSURFeU9Bb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRWh2YjJ0ekxtaGhjMUJsY20xcGMzTnBiMjRLSUNBZ0lHSnVlaUJJYjI5cmN5NXBjMVpoYkdsa1NHOXZhMEZrWkhKbGMzTmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lHbDBiMklLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCSWIyOXJjeTVvWVhOUVpYSnRhWE56YVc5dUNpQWdJQ0JpZWlCSWIyOXJjeTVwYzFaaGJHbGtTRzl2YTBGa1pISmxjM05mWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnY21WMGMzVmlDZ3BJYjI5cmN5NXBjMVpoYkdsa1NHOXZhMEZrWkhKbGMzTmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnY0hWemFHbHVkQ0EyTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlFaHZiMnR6TG1oaGMxQmxjbTFwYzNOcGIyNEtJQ0FnSUdKdWVpQkliMjlyY3k1cGMxWmhiR2xrU0c5dmEwRmtaSEpsYzNOZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJJYjI5cmN5NW9ZWE5RWlhKdGFYTnphVzl1Q2lBZ0lDQmllaUJJYjI5cmN5NXBjMVpoYkdsa1NHOXZhMEZrWkhKbGMzTmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdjbVYwYzNWaUNncEliMjlyY3k1cGMxWmhiR2xrU0c5dmEwRmtaSEpsYzNOZllXWjBaWEpmYVdaZlpXeHpaVUEyT2dvZ0lDQWdjSFZ6YUdsdWRDQXhNREkwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1NHOXZhM011YUdGelVHVnliV2x6YzJsdmJnb2dJQ0FnWW01NklFaHZiMnR6TG1selZtRnNhV1JJYjI5clFXUmtjbVZ6YzE5aFpuUmxjbDlwWmw5bGJITmxRRGtLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNCcGRHOWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnU0c5dmEzTXVhR0Z6VUdWeWJXbHpjMmx2YmdvZ0lDQWdZbm9nU0c5dmEzTXVhWE5XWVd4cFpFaHZiMnRCWkdSeVpYTnpYMkZtZEdWeVgybG1YMlZzYzJWQU9Rb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJSEpsZEhOMVlnb0tTRzl2YTNNdWFYTldZV3hwWkVodmIydEJaR1J5WlhOelgyRm1kR1Z5WDJsbVgyVnNjMlZBT1RvS0lDQWdJSEIxYzJocGJuUWdNalUyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1NHOXZhM011YUdGelVHVnliV2x6YzJsdmJnb2dJQ0FnWW01NklFaHZiMnR6TG1selZtRnNhV1JJYjI5clFXUmtjbVZ6YzE5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUVodmIydHpMbWhoYzFCbGNtMXBjM05wYjI0S0lDQWdJR0o2SUVodmIydHpMbWx6Vm1Gc2FXUkliMjlyUVdSa2NtVnpjMTloWm5SbGNsOXBabDlsYkhObFFERXlDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnY21WMGMzVmlDZ3BJYjI5cmN5NXBjMVpoYkdsa1NHOXZhMEZrWkhKbGMzTmZZV1owWlhKZmFXWmZaV3h6WlVBeE1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHSjVkR1Z6SUdKaGMyVXpNaWhCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJLU0F2THlCaFpHUnlJRUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRlpOVWhHUzFFS0lDQWdJRDA5Q2lBZ0lDQmllaUJJYjI5cmN5NXBjMVpoYkdsa1NHOXZhMEZrWkhKbGMzTmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRXhRUm1WbFRHbGljbUZ5ZVM1cGMwUjVibUZ0YVdOR1pXVUtJQ0FnSUNFS0NraHZiMnR6TG1selZtRnNhV1JJYjI5clFXUmtjbVZ6YzE5MFpYSnVZWEo1WDIxbGNtZGxRREU1T2dvZ0lDQWdjbVYwYzNWaUNncEliMjlyY3k1cGMxWmhiR2xrU0c5dmEwRmtaSEpsYzNOZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TkRvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TTJabVpnb2dJQ0FnWWlZS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmlQZ29nSUNBZ1ltNTZJRWh2YjJ0ekxtbHpWbUZzYVdSSWIyOXJRV1JrY21WemMxOWliMjlzWDNSeWRXVkFNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCTVVFWmxaVXhwWW5KaGNua3VhWE5FZVc1aGJXbGpSbVZsQ2lBZ0lDQmllaUJJYjI5cmN5NXBjMVpoYkdsa1NHOXZhMEZrWkhKbGMzTmZZbTl2YkY5bVlXeHpaVUF4TndvS1NHOXZhM011YVhOV1lXeHBaRWh2YjJ0QlpHUnlaWE56WDJKdmIyeGZkSEoxWlVBeE5qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSemRXSUtDa2h2YjJ0ekxtbHpWbUZzYVdSSWIyOXJRV1JrY21WemMxOWliMjlzWDJaaGJITmxRREUzT2dvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHSWdTRzl2YTNNdWFYTldZV3hwWkVodmIydEJaR1J5WlhOelgzUmxjbTVoY25sZmJXVnlaMlZBTVRrS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVRGQkdaV1ZNYVdKeVlYSjVMbWx6UkhsdVlXMXBZMFpsWlNoelpXeG1PaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJORG9LVEZCR1pXVk1hV0p5WVhKNUxtbHpSSGx1WVcxcFkwWmxaVG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J3ZFhOb2FXNTBJRGd6T0RnMk1EZ0tJQ0FnSUQwOUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VUbTl1ZW1WeWIwUmxiSFJoUTI5MWJuUXVaR1ZqY21WdFpXNTBLQ2tnTFQ0Z2RtOXBaRG9LVG05dWVtVnliMFJsYkhSaFEyOTFiblF1WkdWamNtVnRaVzUwT2dvZ0lDQWdZbmwwWldNZ09TQXZMeUF3ZURVMllqQmpZek0xTldSbVpURTRZbVExWm1Jek0yWXlZalkwT1RNME5qaGhORFptTmpNMllXSmhOVE5rWm1JeVpERTFZVEF6WldZeVpEVTBPVE13TXpVS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IZzFObUl3WTJNek5UVmtabVV4T0dKa05XWmlNek5tTW1JMk5Ea3pORFk0WVRRMlpqWXpObUZpWVRVelpHWmlNbVF4TldFd00yVm1NbVExTkRrek1ETTFDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmMybDBhVzl1TG1OaGJHTjFiR0YwWlZCdmMybDBhVzl1UzJWNUtHOTNibVZ5T2lCaWVYUmxjeXdnZEdsamEweHZkMlZ5T2lCMWFXNTBOalFzSUhScFkydFZjSEJsY2pvZ2RXbHVkRFkwTENCellXeDBPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbEJ2YzJsMGFXOXVMbU5oYkdOMWJHRjBaVkJ2YzJsMGFXOXVTMlY1T2dvZ0lDQWdjSEp2ZEc4Z05DQXhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lPVEJrWldOa09UVTBPR0kyTW1FNFpEWXdNelExWVRrNE9ETTRObVpqT0RSaVlUWmlZemsxTkRnME1EQTRaall6TmpKbU9UTXhOakJsWmpObE5UWXpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUhKdmRHOWpiMnhHWldWTWFXSnlZWEo1TG1selZtRnNhV1JRY205MGIyTnZiRVpsWlNoelpXeG1PaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJORG9LVUhKdmRHOWpiMnhHWldWTWFXSnlZWEo1TG1selZtRnNhV1JRY205MGIyTnZiRVpsWlRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQm1abVlLSUNBZ0lHSW1DaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNMlU1Q2lBZ0lDQmlQQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1abVl3TURBS0lDQWdJR0ltQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd6WlRrd01EQUtJQ0FnSUdJOENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0ltQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHSWhQUW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxOc2IzUXdUR2xpY21GeWVTNXdjbTkwYjJOdmJFWmxaU2hmY0dGamEyVmtPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3BUYkc5ME1FeHBZbkpoY25rdWNISnZkRzlqYjJ4R1pXVTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpOEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVZibk5oWm1WTllYUm9MbVJwZGxKdmRXNWthVzVuVlhBb2VEb2dZbmwwWlhNc0lIazZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tWVzV6WVdabFRXRjBhQzVrYVhaU2IzVnVaR2x1WjFWd09nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpSlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQmlQZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TkRrdVgxOXdkWGxoWDJGeVl6UmZjbTkxZEdWeVgxOG9LU0F0UGlCMWFXNTBOalE2Q2w5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5Zk9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklGOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZYMTlmWW1GeVpWOWpjbVZoZEdWZlgwQXlNQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRPRFJoTlRRMVpqa2dNSGcwTVdJM01HVm1OaUF3ZURjMVpHSmtabVU0SURCNFlUVTFabVJqWkRnZ01IaGhabVJtTkRnd01TQXdlREJpTkRJek5XUTFJREI0WTJNM1pUQmxOMlVnTUhobE56ZGtORFU0WmlBd2VEY3pPV0ZrTURFMUlEQjROelZsWTJJeU5tWWdNSGd6TWpVelpHVTNNaUF3ZUdRMFkyTTFaalZrSURCNFlqazNZbVEzTURZZ01IaGhPVFpsWmprNE9TQXZMeUJ0WlhSb2IyUWdJa04xYzNSdmJWSmxkbVZ5ZEM1aWRXSmliR1ZWY0VGdVpGSmxkbVZ5ZEZkcGRHZ29ZV1JrY21WemN5eGllWFJsV3pSZExHSjVkR1ZiTkYwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpUW1WbWIzSmxVM2RoY0VSbGJIUmhUR2xpY21GeWVTNW5aWFJWYm5Od1pXTnBabWxsWkVSbGJIUmhLSFZwYm5ReU5UWXBkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWlRM1Z5Y21WdVkzbEVaV3gwWVM1aGNIQnNlVVJsYkhSaEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1NoMWFXNTBNalUyTEhWcGJuUXlOVFlwSWl3Z2JXVjBhRzlrSUNKT2IyNTZaWEp2UkdWc2RHRkRiM1Z1ZEM1a1pXTnlaVzFsYm5Rb0tYWnZhV1FpTENCdFpYUm9iMlFnSWxCeWIzUnZZMjlzUm1WbFRHbGljbUZ5ZVM1cGMxWmhiR2xrVUhKdmRHOWpiMnhHWldVb2RXbHVkRFkwS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbE4zWVhCTllYUm9MbU52YlhCMWRHVlRkMkZ3VTNSbGNGOWZZMmgxYm10Zk1DaDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUTJOQ2tvZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXNZbTl2YkN4MWFXNTBNalUyTEhWcGJuUXlOVFlzWW05dmJDa2lMQ0J0WlhSb2IyUWdJa2h2YjJ0ekxtbHpWbUZzYVdSSWIyOXJRV1JrY21WemN5aGhaR1J5WlhOekxIVnBiblEyTkNsaWIyOXNJaXdnYldWMGFHOWtJQ0pEZFhKeVpXNWplVVJsYkhSaExtZGxkRVJsYkhSaEtHRmtaSEpsYzNNc1lXUmtjbVZ6Y3lsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKVmJuTmhabVZOWVhSb0xtUnBkbEp2ZFc1a2FXNW5WWEFvZFdsdWRESTFOaXgxYVc1ME1qVTJLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbEJ2YzJsMGFXOXVMbU5oYkdOMWJHRjBaVkJ2YzJsMGFXOXVTMlY1S0dGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DeGllWFJsV3pNeVhTbGllWFJsV3pNeVhTSXNJRzFsZEdodlpDQWlRM1Z5Y21WdVkzbFNaWE5sY25abGN5NXplVzVqUTNWeWNtVnVZM2xCYm1SU1pYTmxjblpsY3loaFpHUnlaWE56TEhWcGJuUXlOVFlwZG05cFpDSXNJRzFsZEdodlpDQWlVMnh2ZERCTWFXSnlZWEo1TG5CeWIzUnZZMjlzUm1WbEtHSjVkR1ZiTXpKZEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVEzVnljbVZ1WTNsTWFXSnlZWEo1TG1aeWIyMUpaQ2gxYVc1ME1qVTJLV0ZrWkhKbGMzTWlMQ0J0WlhSb2IyUWdJbDlmYVc1cGRGOWZLSFZwYm5RMk5DeDFhVzUwTmpRc1lubDBaVnRkS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0F2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUTVMa04xYzNSdmJWSmxkbVZ5ZEM1aWRXSmliR1ZWY0VGdVpGSmxkbVZ5ZEZkcGRHaGJjbTkxZEdsdVoxMGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME9TNUNaV1p2Y21WVGQyRndSR1ZzZEdGTWFXSnlZWEo1TG1kbGRGVnVjM0JsWTJsbWFXVmtSR1ZzZEdGYmNtOTFkR2x1WjEwZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwT1M1RGRYSnlaVzVqZVVSbGJIUmhMbUZ3Y0d4NVJHVnNkR0ZiY205MWRHbHVaMTBnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBPUzVPYjI1NlpYSnZSR1ZzZEdGRGIzVnVkQzVrWldOeVpXMWxiblJiY205MWRHbHVaMTBnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBPUzVRY205MGIyTnZiRVpsWlV4cFluSmhjbmt1YVhOV1lXeHBaRkJ5YjNSdlkyOXNSbVZsVzNKdmRYUnBibWRkSUZOM1lYQk5ZWFJvTG1OdmJYQjFkR1ZUZDJGd1UzUmxjRjlmWTJoMWJtdGZNQ0F2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUTVMa2h2YjJ0ekxtbHpWbUZzYVdSSWIyOXJRV1JrY21WemMxdHliM1YwYVc1blhTQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pRNUxrTjFjbkpsYm1ONVJHVnNkR0V1WjJWMFJHVnNkR0ZiY205MWRHbHVaMTBnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBPUzVWYm5OaFptVk5ZWFJvTG1ScGRsSnZkVzVrYVc1blZYQmJjbTkxZEdsdVoxMGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME9TNVFiM05wZEdsdmJpNWpZV3hqZFd4aGRHVlFiM05wZEdsdmJrdGxlVnR5YjNWMGFXNW5YU0F2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUTVMa04xY25KbGJtTjVVbVZ6WlhKMlpYTXVjM2x1WTBOMWNuSmxibU41UVc1a1VtVnpaWEoyWlhOYmNtOTFkR2x1WjEwZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwT1M1VGJHOTBNRXhwWW5KaGNua3VjSEp2ZEc5amIyeEdaV1ZiY205MWRHbHVaMTBnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBPUzVEZFhKeVpXNWplVXhwWW5KaGNua3Vabkp2YlVsa1czSnZkWFJwYm1kZElGOWZhVzVwZEY5ZkNpQWdJQ0JsY25JS0NsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZYMTlmWW1GeVpWOWpjbVZoZEdWZlgwQXlNRG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME9TNURkWE4wYjIxU1pYWmxjblF1WW5WaVlteGxWWEJCYm1SU1pYWmxjblJYYVhSb1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME9TNURkWE4wYjIxU1pYWmxjblF1WW5WaVlteGxWWEJCYm1SU1pYWmxjblJYYVhSb1czSnZkWFJwYm1kZE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQTBQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTkQ0S0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwT1M1RGRYTjBiMjFTWlhabGNuUXVZblZpWW14bFZYQkJibVJTWlhabGNuUlhhWFJvVzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCdGRYTjBJR0psSUdOaGJHeGxaQ0JwYmlCbmNtOTFjQW9nSUNBZ1ozUjRiaUF3SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhWdVlYVjBhRzl5YVhwbFpDQmpZV3hzWlhJS0lDQWdJR2QwZUc0Z01DQlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCelpXNWtaWElnYldsemJXRjBZMmdLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBPUzVEZFhOMGIyMVNaWFpsY25RdVluVmlZbXhsVlhCQmJtUlNaWFpsY25SWGFYUm9XM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCM2NtOXVaeUJ3Y21WMklHTm9kVzVyQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQnRaWFJvYjJRS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TkRrdVEzVnpkRzl0VW1WMlpYSjBMbUoxWW1Kc1pWVndRVzVrVW1WMlpYSjBWMmwwYUZ0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJRU4xYzNSdmJWSmxkbVZ5ZEM1aWRXSmliR1ZWY0VGdVpGSmxkbVZ5ZEZkcGRHZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjalE1TGtKbFptOXlaVk4zWVhCRVpXeDBZVXhwWW5KaGNua3VaMlYwVlc1emNHVmphV1pwWldSRVpXeDBZVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORGt1UW1WbWIzSmxVM2RoY0VSbGJIUmhUR2xpY21GeWVTNW5aWFJWYm5Od1pXTnBabWxsWkVSbGJIUmhXM0p2ZFhScGJtZGRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdKNklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TkRrdVFtVm1iM0psVTNkaGNFUmxiSFJoVEdsaWNtRnllUzVuWlhSVmJuTndaV05wWm1sbFpFUmxiSFJoVzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCdGRYTjBJR0psSUdOaGJHeGxaQ0JwYmlCbmNtOTFjQW9nSUNBZ1ozUjRiaUF3SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhWdVlYVjBhRzl5YVhwbFpDQmpZV3hzWlhJS0lDQWdJR2QwZUc0Z01DQlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCelpXNWtaWElnYldsemJXRjBZMmdLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBPUzVDWldadmNtVlRkMkZ3UkdWc2RHRk1hV0p5WVhKNUxtZGxkRlZ1YzNCbFkybG1hV1ZrUkdWc2RHRmJjbTkxZEdsdVoxMWZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ1kyaDFibXNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTmhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCM2NtOXVaeUJ3Y21WMklHMWxkR2h2WkFvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwT1M1Q1pXWnZjbVZUZDJGd1JHVnNkR0ZNYVdKeVlYSjVMbWRsZEZWdWMzQmxZMmxtYVdWa1JHVnNkR0ZiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ1pIVndDaUFnSUNCallXeHNjM1ZpSUVKbFptOXlaVk4zWVhCRVpXeDBZVXhwWW5KaGNua3VaMlYwVlc1emNHVmphV1pwWldSRVpXeDBZUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjalE1TGtOMWNuSmxibU41UkdWc2RHRXVZWEJ3YkhsRVpXeDBZVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORGt1UTNWeWNtVnVZM2xFWld4MFlTNWhjSEJzZVVSbGJIUmhXM0p2ZFhScGJtZGRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjalE1TGtOMWNuSmxibU41UkdWc2RHRXVZWEJ3YkhsRVpXeDBZVnR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUdkc2IySmhiQ0JIY205MWNGTnBlbVVLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nYlhWemRDQmlaU0JqWVd4c1pXUWdhVzRnWjNKdmRYQUtJQ0FnSUdkMGVHNGdNQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIxYm1GMWRHaHZjbWw2WldRZ1kyRnNiR1Z5Q2lBZ0lDQm5kSGh1SURBZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nYzJWdVpHVnlJRzFwYzIxaGRHTm9DaUFnSUNCaWVYUmxZMTh4SUM4dklDSndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5Ea3VRM1Z5Y21WdVkzbEVaV3gwWVM1aGNIQnNlVVJsYkhSaFczSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIzY205dVp5QndjbVYySUdOb2RXNXJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1ellTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCdFpYUm9iMlFLQ2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORGt1UTNWeWNtVnVZM2xFWld4MFlTNWhjSEJzZVVSbGJIUmhXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTmhiR3h6ZFdJZ1EzVnljbVZ1WTNsRVpXeDBZUzVoY0hCc2VVUmxiSFJoQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSjhDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUTVMazV2Ym5wbGNtOUVaV3gwWVVOdmRXNTBMbVJsWTNKbGJXVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORGt1VG05dWVtVnliMFJsYkhSaFEyOTFiblF1WkdWamNtVnRaVzUwVzNKdmRYUnBibWRkT2dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjalE1TGs1dmJucGxjbTlFWld4MFlVTnZkVzUwTG1SbFkzSmxiV1Z1ZEZ0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lHZHNiMkpoYkNCSGNtOTFjRk5wZW1VS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2JYVnpkQ0JpWlNCallXeHNaV1FnYVc0Z1ozSnZkWEFLSUNBZ0lHZDBlRzRnTUNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCMWJtRjFkR2h2Y21sNlpXUWdZMkZzYkdWeUNpQWdJQ0JuZEhodUlEQWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2MyVnVaR1Z5SUcxcGMyMWhkR05vQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORGt1VG05dWVtVnliMFJsYkhSaFEyOTFiblF1WkdWamNtVnRaVzUwVzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJR05vZFc1ckNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJ0WlhSb2IyUUtDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5Ea3VUbTl1ZW1WeWIwUmxiSFJoUTI5MWJuUXVaR1ZqY21WdFpXNTBXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdOaGJHeHpkV0lnVG05dWVtVnliMFJsYkhSaFEyOTFiblF1WkdWamNtVnRaVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME9TNVFjbTkwYjJOdmJFWmxaVXhwWW5KaGNua3VhWE5XWVd4cFpGQnliM1J2WTI5c1JtVmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBPUzVRY205MGIyTnZiRVpsWlV4cFluSmhjbmt1YVhOV1lXeHBaRkJ5YjNSdlkyOXNSbVZsVzNKdmRYUnBibWRkT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwT1M1UWNtOTBiMk52YkVabFpVeHBZbkpoY25rdWFYTldZV3hwWkZCeWIzUnZZMjlzUm1WbFczSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdaMnh2WW1Gc0lFZHliM1Z3VTJsNlpRb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQnRkWE4wSUdKbElHTmhiR3hsWkNCcGJpQm5jbTkxY0FvZ0lDQWdaM1I0YmlBd0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIVnVZWFYwYUc5eWFYcGxaQ0JqWVd4c1pYSUtJQ0FnSUdkMGVHNGdNQ0JUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQnpaVzVrWlhJZ2JXbHpiV0YwWTJnS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5BaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwT1M1UWNtOTBiMk52YkVabFpVeHBZbkpoY25rdWFYTldZV3hwWkZCeWIzUnZZMjlzUm1WbFczSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIzY205dVp5QndjbVYySUdOb2RXNXJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1ellTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCdFpYUm9iMlFLQ2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORGt1VUhKdmRHOWpiMnhHWldWTWFXSnlZWEo1TG1selZtRnNhV1JRY205MGIyTnZiRVpsWlZ0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQmtkWEFLSUNBZ0lHTmhiR3h6ZFdJZ1VISnZkRzlqYjJ4R1pXVk1hV0p5WVhKNUxtbHpWbUZzYVdSUWNtOTBiMk52YkVabFpRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUTVMbE4zWVhCTllYUm9MbU52YlhCMWRHVlRkMkZ3VTNSbGNGOWZZMmgxYm10Zk1GdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbE4zWVhCTllYUm9MbU52YlhCMWRHVlRkMkZ3VTNSbGNGOWZZMmgxYm10Zk1Eb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUZOM1lYQk5ZWFJvTG1OdmJYQjFkR1ZUZDJGd1UzUmxjRjlmWTJoMWJtdGZNRjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUdkc2IySmhiQ0JIY205MWNGTnBlbVVLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nYlhWemRDQmlaU0JqWVd4c1pXUWdhVzRnWjNKdmRYQUtJQ0FnSUdkMGVHNGdNQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIxYm1GMWRHaHZjbWw2WldRZ1kyRnNiR1Z5Q2lBZ0lDQm5kSGh1SURBZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nYzJWdVpHVnlJRzFwYzIxaGRHTm9DaUFnSUNCaWVYUmxZMTh4SUM4dklDSndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHSjZJRk4zWVhCTllYUm9MbU52YlhCMWRHVlRkMkZ3VTNSbGNGOWZZMmgxYm10Zk1GOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCamFIVnVhd29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWMyRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ2JXVjBhRzlrQ2dwVGQyRndUV0YwYUM1amIyMXdkWFJsVTNkaGNGTjBaWEJmWDJOb2RXNXJYekJmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dOQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHSStQUW9nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTBDaUFnSUNCaVBnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITmxkR0pwZEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzJWMFltbDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pRNUxraHZiMnR6TG1selZtRnNhV1JJYjI5clFXUmtjbVZ6YzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TkRrdVNHOXZhM011YVhOV1lXeHBaRWh2YjJ0QlpHUnlaWE56VzNKdmRYUnBibWRkT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjalE1TGtodmIydHpMbWx6Vm1Gc2FXUkliMjlyUVdSa2NtVnpjMXR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUdkc2IySmhiQ0JIY205MWNGTnBlbVVLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nYlhWemRDQmlaU0JqWVd4c1pXUWdhVzRnWjNKdmRYQUtJQ0FnSUdkMGVHNGdNQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIxYm1GMWRHaHZjbWw2WldRZ1kyRnNiR1Z5Q2lBZ0lDQm5kSGh1SURBZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nYzJWdVpHVnlJRzFwYzIxaGRHTm9DaUFnSUNCaWVYUmxZMTh4SUM4dklDSndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5Ea3VTRzl2YTNNdWFYTldZV3hwWkVodmIydEJaR1J5WlhOelczSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIzY205dVp5QndjbVYySUdOb2RXNXJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1ellTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCdFpYUm9iMlFLQ2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORGt1U0c5dmEzTXVhWE5XWVd4cFpFaHZiMnRCWkdSeVpYTnpXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdSMWNESUtJQ0FnSUdOaGJHeHpkV0lnU0c5dmEzTXVhWE5XWVd4cFpFaHZiMnRCWkdSeVpYTnpDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORGt1UTNWeWNtVnVZM2xFWld4MFlTNW5aWFJFWld4MFlWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5Ea3VRM1Z5Y21WdVkzbEVaV3gwWVM1blpYUkVaV3gwWVZ0eWIzVjBhVzVuWFRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORGt1UTNWeWNtVnVZM2xFWld4MFlTNW5aWFJFWld4MFlWdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJR2RzYjJKaGJDQkhjbTkxY0ZOcGVtVUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2diWFZ6ZENCaVpTQmpZV3hzWldRZ2FXNGdaM0p2ZFhBS0lDQWdJR2QwZUc0Z01DQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjFibUYxZEdodmNtbDZaV1FnWTJGc2JHVnlDaUFnSUNCbmRIaHVJREFnVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2djMlZ1WkdWeUlHMXBjMjFoZEdOb0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdKNklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TkRrdVEzVnljbVZ1WTNsRVpXeDBZUzVuWlhSRVpXeDBZVnR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQmphSFZ1YXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjMkVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdiV1YwYUc5a0Nnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pRNUxrTjFjbkpsYm1ONVJHVnNkR0V1WjJWMFJHVnNkR0ZiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ1pIVndNZ29nSUNBZ1kyRnNiSE4xWWlCRGRYSnlaVzVqZVVSbGJIUmhMbWRsZEVSbGJIUmhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORGt1Vlc1ellXWmxUV0YwYUM1a2FYWlNiM1Z1WkdsdVoxVndXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBPUzVWYm5OaFptVk5ZWFJvTG1ScGRsSnZkVzVrYVc1blZYQmJjbTkxZEdsdVoxMDZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUTVMbFZ1YzJGbVpVMWhkR2d1WkdsMlVtOTFibVJwYm1kVmNGdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJR2RzYjJKaGJDQkhjbTkxY0ZOcGVtVUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2diWFZ6ZENCaVpTQmpZV3hzWldRZ2FXNGdaM0p2ZFhBS0lDQWdJR2QwZUc0Z01DQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjFibUYxZEdodmNtbDZaV1FnWTJGc2JHVnlDaUFnSUNCbmRIaHVJREFnVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2djMlZ1WkdWeUlHMXBjMjFoZEdOb0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdKNklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TkRrdVZXNXpZV1psVFdGMGFDNWthWFpTYjNWdVpHbHVaMVZ3VzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJR05vZFc1ckNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJ0WlhSb2IyUUtDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5Ea3VWVzV6WVdabFRXRjBhQzVrYVhaU2IzVnVaR2x1WjFWd1czSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJR1IxY0RJS0lDQWdJR05oYkd4emRXSWdWVzV6WVdabFRXRjBhQzVrYVhaU2IzVnVaR2x1WjFWd0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5Ea3VVRzl6YVhScGIyNHVZMkZzWTNWc1lYUmxVRzl6YVhScGIyNUxaWGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjalE1TGxCdmMybDBhVzl1TG1OaGJHTjFiR0YwWlZCdmMybDBhVzl1UzJWNVczSnZkWFJwYm1kZE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pRNUxsQnZjMmwwYVc5dUxtTmhiR04xYkdGMFpWQnZjMmwwYVc5dVMyVjVXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnWjJ4dlltRnNJRWR5YjNWd1UybDZaUW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ0ZFhOMElHSmxJR05oYkd4bFpDQnBiaUJuY205MWNBb2dJQ0FnWjNSNGJpQXdJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSFZ1WVhWMGFHOXlhWHBsWkNCallXeHNaWElLSUNBZ0lHZDBlRzRnTUNCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ6Wlc1a1pYSWdiV2x6YldGMFkyZ0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME9TNVFiM05wZEdsdmJpNWpZV3hqZFd4aGRHVlFiM05wZEdsdmJrdGxlVnR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQmphSFZ1YXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjMkVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdiV1YwYUc5a0Nnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pRNUxsQnZjMmwwYVc5dUxtTmhiR04xYkdGMFpWQnZjMmwwYVc5dVMyVjVXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQmpZV3hzYzNWaUlGQnZjMmwwYVc5dUxtTmhiR04xYkdGMFpWQnZjMmwwYVc5dVMyVjVDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwT1M1RGRYSnlaVzVqZVZKbGMyVnlkbVZ6TG5ONWJtTkRkWEp5Wlc1amVVRnVaRkpsYzJWeWRtVnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBPUzVEZFhKeVpXNWplVkpsYzJWeWRtVnpMbk41Ym1ORGRYSnlaVzVqZVVGdVpGSmxjMlZ5ZG1WelczSnZkWFJwYm1kZE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBPUzVEZFhKeVpXNWplVkpsYzJWeWRtVnpMbk41Ym1ORGRYSnlaVzVqZVVGdVpGSmxjMlZ5ZG1WelczSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdaMnh2WW1Gc0lFZHliM1Z3VTJsNlpRb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQnRkWE4wSUdKbElHTmhiR3hsWkNCcGJpQm5jbTkxY0FvZ0lDQWdaM1I0YmlBd0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIVnVZWFYwYUc5eWFYcGxaQ0JqWVd4c1pYSUtJQ0FnSUdkMGVHNGdNQ0JUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQnpaVzVrWlhJZ2JXbHpiV0YwWTJnS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5BaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwT1M1RGRYSnlaVzVqZVZKbGMyVnlkbVZ6TG5ONWJtTkRkWEp5Wlc1amVVRnVaRkpsYzJWeWRtVnpXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCM2NtOXVaeUJ3Y21WMklHTm9kVzVyQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQnRaWFJvYjJRS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TkRrdVEzVnljbVZ1WTNsU1pYTmxjblpsY3k1emVXNWpRM1Z5Y21WdVkzbEJibVJTWlhObGNuWmxjMXR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVTZDaUFnSUNCa2RYQXlDaUFnSUNCallXeHNjM1ZpSUVOMWNuSmxibU41VW1WelpYSjJaWE11YzNsdVkwTjFjbkpsYm1ONVFXNWtVbVZ6WlhKMlpYTUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjalE1TGxOc2IzUXdUR2xpY21GeWVTNXdjbTkwYjJOdmJFWmxaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlORGt1VTJ4dmREQk1hV0p5WVhKNUxuQnliM1J2WTI5c1JtVmxXM0p2ZFhScGJtZGRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5Ea3VVMnh2ZERCTWFXSnlZWEo1TG5CeWIzUnZZMjlzUm1WbFczSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdaMnh2WW1Gc0lFZHliM1Z3VTJsNlpRb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQnRkWE4wSUdKbElHTmhiR3hsWkNCcGJpQm5jbTkxY0FvZ0lDQWdaM1I0YmlBd0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIVnVZWFYwYUc5eWFYcGxaQ0JqWVd4c1pYSUtJQ0FnSUdkMGVHNGdNQ0JUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQnpaVzVrWlhJZ2JXbHpiV0YwWTJnS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5BaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEkwT1M1VGJHOTBNRXhwWW5KaGNua3VjSEp2ZEc5amIyeEdaV1ZiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdZMmgxYm1zS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk5oSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJRzFsZEdodlpBb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME9TNVRiRzkwTUV4cFluSmhjbmt1Y0hKdmRHOWpiMnhHWldWYmNtOTFkR2x1WjExZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlGTnNiM1F3VEdsaWNtRnllUzV3Y205MGIyTnZiRVpsWlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU5Ea3VRM1Z5Y21WdVkzbE1hV0p5WVhKNUxtWnliMjFKWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TkRrdVEzVnljbVZ1WTNsTWFXSnlZWEo1TG1aeWIyMUpaRnR5YjNWMGFXNW5YVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pRNUxrTjFjbkpsYm1ONVRHbGljbUZ5ZVM1bWNtOXRTV1JiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCbmJHOWlZV3dnUjNKdmRYQlRhWHBsQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUcxMWMzUWdZbVVnWTJGc2JHVmtJR2x1SUdkeWIzVndDaUFnSUNCbmRIaHVJREFnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZFc1aGRYUm9iM0pwZW1Wa0lHTmhiR3hsY2dvZ0lDQWdaM1I0YmlBd0lGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhObGJtUmxjaUJ0YVhOdFlYUmphQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUTVMa04xY25KbGJtTjVUR2xpY21GeWVTNW1jbTl0U1dSYmNtOTFkR2x1WjExZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5BaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSGR5YjI1bklIQnlaWFlnWTJoMWJtc0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5OaElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIzY205dVp5QndjbVYySUcxbGRHaHZaQW9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMM1Z1YVhOM1lYQXRkalF2WTI5dWRISmhZM1J6TDJOdmNtVXZVRzl2YkUxaGJtRm5aWEl1YzI5c0xsQnZiMnhOWVc1aFoyVnlYMTlJWld4d1pYSTBPUzVEZFhKeVpXNWplVXhwWW5KaGNua3Vabkp2YlVsa1czSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQkRkWEp5Wlc1amVVeHBZbkpoY25rdVpuSnZiVWxrQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJME9TNWZYMmx1YVhSZlgxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbDlmYVc1cGRGOWZPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJoYkhKbFlXUjVJR2x1YVhScFlXeHBlbVZrQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljQ0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqUTVMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFTQUNBQ1lMQVc4QmNBRnpCQlVmZkhVQkFRRUFJUUVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBZGZYM1JmTVRBd0ZQLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy9JRmF3ekRWZC9oaTlYN00vSzJTVFJvcEc5amFycFQzN0xSV2dQdkxWU1RBMVFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQkNBb3VLQVFHTC80QWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFJQUFBQUFBQUFBQUFBQUFBQUFBQUFDaWdBRUNxb0FBcVVFQUpvdi9nQ0QvLy8vLy8vLy8vLy8vLy8vLy8vLy9BQUFBQUFBQUFBQUFBQUFBQUFBQUFLdUppLytBRVAvLy8vLy8vLy8vLy8vLy8vLy8vLytzaVlvREFvQUhYMTkwWHpFek1tUVdTWXYvb0NjSFN3Rm5pWW9DQVNjSFpCYUppZ0VCaS84bkNLeUppZ0lBaS80bkNLeUFJS3AyRjA4K3Q1WnRGNk9jM1JjMVFNR0REYk5vQ0s2cjFMYXYvaDUwTEsvZ1RHZUFJSjJocU5BSFNsN2lYVE1ldHJIUDFKeWpVR0FWL2ZtWVZ0MXVvTUNWQittcmkvOW5pWW9EQUFDS0FnR0wvb3YvckNVV3FZbUtBZ0dCZ0FFV2kvNU1pUC9uUUFBT2dRZ1dpLzVNaVAvYlFRQUNKWW1CUUJhTC9reUkvODFBQUE2QkJCYUwva3lJLzhGQkFBSWxpWUdBQ0JhTC9reUkvN0pBQUEwa0ZvditUSWovcDBFQUFpV0pnWUFDRm92K1RJai9tRUFBRFNJV2kvNU1pUCtOUVFBQ0pZbUwvb0FnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVNRUUFIaS8rSUFDOFVpWXYrZ0JRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBLy82d2xGcVZBQUFpTC80Z0FDVUVBQWlLSkpVTC8wb29CQVl2L2dZQ0FnQVFTaVNjSlpCWW5CcUFuQktFbkJxb25DVXhuaVlvRUFZQWdLUTNzMlZTTFlxaldBMFdwaURodnlFdW12SlZJUUFqMk5pK1RGZzd6NVdPSmlnRUJpLzhXU1lBQ0QvK3NnQUlENmFTQUFDY0VUd0pOVElBRC8vQUFySUFEUHBBQXBJQUFKd1JQQWsyc2dBQ3BpWW9CQVlFSXI0di9nQ0FBQUFBQUFBQUFBQUVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFLS0FBLy8vLzZ4UVNSV0JDQWxiaVlvQ0FZditpLytpaS82TC82cUFBS1dBQUNjRVR3Sk5vQ2NHcW9reEcwRUFjVEVaRkVReEdFU0NEZ1NFcFVYNUJFRzNEdllFZGR2ZjZBU2xYOXpZQksvZlNBRUVDMEkxMVFUTWZnNStCT2Q5Ulk4RWM1clFGUVIxN0xKdkJESlQzbklFMU14ZlhRUzVlOWNHQktsdStZazJHZ0NPRGdBSkFHQUFyQUVjQVZNQm53SWxBbmtDelFNaEE0Z0QwQVFWQkZrQU1Sa1VNUmdVRUVNMkdnRkpGU01TUkRZYUFra1ZnUVFTUkRZYUEwa1ZnUVFTUkNoa1FRQXRNZ1FrRDBRekFCZ29aQkpFTXdBQU1RQVNSQ2xrUVFBVk1SWWlDVGdZS1dRU1JERVdJZ2s1R2dBcVpCSkVTd0pMQWtzQ2lQMkxJa00yR2dGSkZTTVNSQ2hrUVFBdE1nUWtEMFF6QUJnb1pCSkVNd0FBTVFBU1JDbGtRUUFWTVJZaUNUZ1lLV1FTUkRFV0lnazVHZ0FxWkJKRVNZajhZa2tWSXc1RUk2K3JLMHhRc0NKRE5ob0JTUlVqRWtRMkdnSkpGU01TUkRZYUEwa1ZJeEpFS0dSQkFDMHlCQ1FQUkRNQUdDaGtFa1F6QUFBeEFCSkVLV1JCQUJVeEZpSUpPQmdwWkJKRU1SWWlDVGthQUNwa0VrUkxBa3NDU3dLSS9HOUxBUlVqRGtRanIwOENTd0dyU3dJVkl3NUVUZ0tyVUN0TVVMQWlReWhrUVFBdE1nUWtEMFF6QUJnb1pCSkVNd0FBTVFBU1JDbGtRUUFWTVJZaUNUZ1lLV1FTUkRFV0lnazVHZ0FxWkJKRWlQMThJa00yR2dGSkZZRUlFa1FYS0dSQkFDMHlCQ1FQUkRNQUdDaGtFa1F6QUFBeEFCSkVLV1JCQUJVeEZpSUpPQmdwWkJKRU1SWWlDVGthQUNwa0VrUkppUDF5SndVbFR3SlVLMHhRc0NKRE5ob0JTUlVqRWtRMkdnSkpGU01TUkRZYUF4VWpFa1EyR2dSSkZTTVNSRFlhQlVrVmdRZ1NSQmNvWkVFQUxUSUVKQTlFTXdBWUtHUVNSRE1BQURFQUVrUXBaRUVBRlRFV0lnazRHQ2xrRWtReEZpSUpPUm9BS21RU1JFa1dTd1JMQktjbEZrc0VwU092VHdPckp3cFFKd1VsVHdOVVVDY0tVQ2NGSlU4RFZGQXJURkN3SWtNMkdnRkpGU01TUkRZYUFra1ZnUWdTUkJjb1pFRUFMVElFSkE5RU13QVlLR1FTUkRNQUFERUFFa1FwWkVFQUZURVdJZ2s0R0Nsa0VrUXhGaUlKT1JvQUttUVNSRXFJKzR3bkJTVlBBbFFyVEZDd0lrTTJHZ0ZKRlNNU1JEWWFBa2tWSXhKRUtHUkJBQzB5QkNRUFJETUFHQ2hrRWtRekFBQXhBQkpFS1dSQkFCVXhGaUlKT0JncFpCSkVNUllpQ1RrYUFDcGtFa1JLaVBySFNSVWpEa1FqcjZzclRGQ3dJa00yR2dGSkZTTVNSRFlhQWtrVkl4SkVLR1JCQUMweUJDUVBSRE1BR0Noa0VrUXpBQUF4QUJKRUtXUkJBQlV4RmlJSk9CZ3BaQkpFTVJZaUNUa2FBQ3BrRWtSS2lQeGNTUlVqRGtRanI2c3JURkN3SWtNMkdnRkpGU01TUkRZYUFra1ZnUWdTUkJjMkdnTkpGWUVJRWtRWE5ob0VTUlVqRWtRb1pFRUFMVElFSkE5RU13QVlLR1FTUkRNQUFERUFFa1FwWkVFQUZURVdJZ2s0R0Nsa0VrUXhGaUlKT1JvQUttUVNSRXNEU3dOTEEwc0RpUHRkSzB4UXNDSkROaG9CU1JVakVrUTJHZ0pKRlNNU1JDaGtRUUF0TWdRa0QwUXpBQmdvWkJKRU13QUFNUUFTUkNsa1FRQVZNUllpQ1RnWUtXUVNSREVXSWdrNUdnQXFaQkpFU29qNXlTSkROaG9CU1JVakVrUW9aRUVBTFRJRUpBOUVNd0FZS0dRU1JETUFBREVBRWtRcFpFRUFGVEVXSWdrNEdDbGtFa1F4RmlJSk9Sb0FLbVFTUkVtSSt5Z1dLMHhRc0NKRE5ob0JTUlVqRWtRb1pFRUFMVElFSkE5RU13QVlLR1FTUkRNQUFERUFFa1FwWkVFQUZURVdJZ2s0R0Nsa0VrUXhGaUlKT1JvQUttUVNSRW1JK1RzclRGQ3dJa00yR2dGSkZZRUlFa1FYTmhvQ1NSV0JDQkpFRnpZYUEwa2xXU1FJU3dFVkVrUlhBZ0FvWkJSRUtFOERaeWxQQW1jcVRHY2lRdz09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
