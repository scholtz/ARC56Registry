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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.PoolManager__Helper33_ecdf9f4c
{


    //
    // Helper contract 33 for PoolManager
    //
    public class PoolManager__Helper33Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PoolManager__Helper33Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class TickBitmapNextInitializedTickWithinOneWordChunk1Chunk1Return : AVMObjectType
            {
                public bool Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static TickBitmapNextInitializedTickWithinOneWordChunk1Chunk1Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TickBitmapNextInitializedTickWithinOneWordChunk1Chunk1Return();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is bool vField0Value) { ret.Field0 = vField0Value; }
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
                    return Equals(obj as TickBitmapNextInitializedTickWithinOneWordChunk1Chunk1Return);
                }
                public bool Equals(TickBitmapNextInitializedTickWithinOneWordChunk1Chunk1Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TickBitmapNextInitializedTickWithinOneWordChunk1Chunk1Return left, TickBitmapNextInitializedTickWithinOneWordChunk1Chunk1Return right)
                {
                    return EqualityComparer<TickBitmapNextInitializedTickWithinOneWordChunk1Chunk1Return>.Default.Equals(left, right);
                }
                public static bool operator !=(TickBitmapNextInitializedTickWithinOneWordChunk1Chunk1Return left, TickBitmapNextInitializedTickWithinOneWordChunk1Chunk1Return right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///@notice Derives max liquidity per tick from given tick spacing
        /// @dev Executed when adding liquidity
        /// @param tickSpacing The amount of required tick separation, realized in multiples of `tickSpacing`
        ///     e.g., a tickSpacing of 3 requires ticks to be initialized every 3rd tick i.e., ..., -6, -3, 0, 3, 6, ...
        /// @return result The max liquidity per tick
        ///</summary>
        /// <param name="tickSpacing"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> PoolTickSpacingToMaxLiquidityPerTick(ulong tickSpacing, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 174, 87, 143 };
            var tickSpacingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickSpacingAbi.From(tickSpacing);

            var result = await base.SimApp(new List<object> { abiHandle, tickSpacingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> PoolTickSpacingToMaxLiquidityPerTick_Transactions(ulong tickSpacing, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 174, 87, 143 };
            var tickSpacingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickSpacingAbi.From(tickSpacing);

            return await base.MakeTransactionList(new List<object> { abiHandle, tickSpacingAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="self"> </param>
        /// <param name="tick"> </param>
        /// <param name="tickSpacing"> </param>
        /// <param name="lte"> </param>
        /// <param name="compressed"> </param>
        /// <param name="initialized"> </param>
        /// <param name="next"> </param>
        public async Task<Structs.TickBitmapNextInitializedTickWithinOneWordChunk1Chunk1Return> TickBitmapNextInitializedTickWithinOneWordChunk1Chunk1(byte[] self, ulong tick, ulong tickSpacing, bool lte, ulong compressed, bool initialized, ulong next, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 154, 238, 202 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); selfAbi.From(self);
            var tickAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickAbi.From(tick);
            var tickSpacingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickSpacingAbi.From(tickSpacing);
            var lteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); lteAbi.From(lte);
            var compressedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); compressedAbi.From(compressed);
            var initializedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); initializedAbi.From(initialized);
            var nextAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nextAbi.From(next);

            var result = await base.CallApp(new List<object> { abiHandle, selfAbi, tickAbi, tickSpacingAbi, lteAbi, compressedAbi, initializedAbi, nextAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TickBitmapNextInitializedTickWithinOneWordChunk1Chunk1Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TickBitmapNextInitializedTickWithinOneWordChunk1Chunk1_Transactions(byte[] self, ulong tick, ulong tickSpacing, bool lte, ulong compressed, bool initialized, ulong next, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 154, 238, 202 };
            var selfAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); selfAbi.From(self);
            var tickAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickAbi.From(tick);
            var tickSpacingAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickSpacingAbi.From(tickSpacing);
            var lteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); lteAbi.From(lte);
            var compressedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); compressedAbi.From(compressed);
            var initializedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); initializedAbi.From(initialized);
            var nextAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nextAbi.From(next);

            return await base.MakeTransactionList(new List<object> { abiHandle, selfAbi, tickAbi, tickSpacingAbi, lteAbi, compressedAbi, initializedAbi, nextAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9vbE1hbmFnZXJfX0hlbHBlcjMzIiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCAzMyBmb3IgUG9vbE1hbmFnZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVGlja0JpdG1hcE5leHRJbml0aWFsaXplZFRpY2tXaXRoaW5PbmVXb3JkQ2h1bmsxQ2h1bmsxUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6IlBvb2wudGlja1NwYWNpbmdUb01heExpcXVpZGl0eVBlclRpY2siLCJkZXNjIjoiQG5vdGljZSBEZXJpdmVzIG1heCBsaXF1aWRpdHkgcGVyIHRpY2sgZnJvbSBnaXZlbiB0aWNrIHNwYWNpbmdcbiBAZGV2IEV4ZWN1dGVkIHdoZW4gYWRkaW5nIGxpcXVpZGl0eVxuIEBwYXJhbSB0aWNrU3BhY2luZyBUaGUgYW1vdW50IG9mIHJlcXVpcmVkIHRpY2sgc2VwYXJhdGlvbiwgcmVhbGl6ZWQgaW4gbXVsdGlwbGVzIG9mIGB0aWNrU3BhY2luZ2BcbiAgICAgZS5nLiwgYSB0aWNrU3BhY2luZyBvZiAzIHJlcXVpcmVzIHRpY2tzIHRvIGJlIGluaXRpYWxpemVkIGV2ZXJ5IDNyZCB0aWNrIGkuZS4sIC4uLiwgLTYsIC0zLCAwLCAzLCA2LCAuLi5cbiBAcmV0dXJuIHJlc3VsdCBUaGUgbWF4IGxpcXVpZGl0eSBwZXIgdGljayIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aWNrU3BhY2luZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlRpY2tCaXRtYXAubmV4dEluaXRpYWxpemVkVGlja1dpdGhpbk9uZVdvcmRfX2NodW5rXzFfX2NodW5rXzEiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsZiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGljayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGlja1NwYWNpbmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbXByZXNzZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbml0aWFsaXplZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV4dCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYm9vbCx1aW50NjQpIiwic3RydWN0IjoiVGlja0JpdG1hcE5leHRJbml0aWFsaXplZFRpY2tXaXRoaW5PbmVXb3JkQ2h1bmsxQ2h1bmsxUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiX19pbml0X18iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzc1MV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogYWxyZWFkeSBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxOSw2NTJdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IG11c3QgYmUgY2FsbGVkIGluIGdyb3VwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTMzLDY2Nl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogc2VuZGVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTI2LDY1OV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogdW5hdXRob3JpemVkIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1MCw2ODNdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHdyb25nIHByZXYgY2h1bmsiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjIsNjk1XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiB3cm9uZyBwcmV2IG1ldGhvZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4OSw3MzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MTYsNjMxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5NSw3NDRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA4LDYwMiw2MDksNjIzLDY0MSw3MjEsNzMwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTcyXSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pNekxsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklERWdPQ0F3SURJS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnd01TQXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlnSW04aUlEQjRJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0lDSndJaUFpY3lJZ01IZzRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdJREI0TVRVeFpqZGpOelVLSUNBZ0lHSWdYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMThLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJDNTBhV05yVTNCaFkybHVaMVJ2VFdGNFRHbHhkV2xrYVhSNVVHVnlWR2xqYXloMGFXTnJVM0JoWTJsdVp6b2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tVRzl2YkM1MGFXTnJVM0JoWTJsdVoxUnZUV0Y0VEdseGRXbGthWFI1VUdWeVZHbGphem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1IxY0c0Z05Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaUlnb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EZ3dNREF3TUFvZ0lDQWdZaThLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF5Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCaWVpQlFiMjlzTG5ScFkydFRjR0ZqYVc1blZHOU5ZWGhNYVhGMWFXUnBkSGxRWlhKVWFXTnJYM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aakF3TURBd01Bb2dJQ0FnWW53S0lDQWdJR1p5WVcxbFgySjFjbmtnTXdvS1VHOXZiQzUwYVdOclUzQmhZMmx1WjFSdlRXRjRUR2x4ZFdsa2FYUjVVR1Z5VkdsamExOTBaWEp1WVhKNVgyMWxjbWRsUURNNkNpQWdJQ0J3ZFhOb2FXNTBJREU0TkRRMk56UTBNRGN6TnpBNE5qWTBNelEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRPREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lqNDlDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Rb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VBb2dJQ0FnWWlFOUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTmdvZ0lDQWdZbm9nVUc5dmJDNTBhV05yVTNCaFkybHVaMVJ2VFdGNFRHbHhkV2xrYVhSNVVHVnlWR2xqYTE5MFpYSnVZWEo1WDJaaGJITmxRREV4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOUW9nSUNBZ1lub2dVRzl2YkM1MGFXTnJVM0JoWTJsdVoxUnZUV0Y0VEdseGRXbGthWFI1VUdWeVZHbGphMTkwWlhKdVlYSjVYMlpoYkhObFFEa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Rb2dJQ0FnWWlzS0NsQnZiMnd1ZEdsamExTndZV05wYm1kVWIwMWhlRXhwY1hWcFpHbDBlVkJsY2xScFkydGZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpTHdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1ZS0lDQWdJSE4zWVhBS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFS0lDQWdJR0lyQ2dwUWIyOXNMblJwWTJ0VGNHRmphVzVuVkc5TllYaE1hWEYxYVdScGRIbFFaWEpVYVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTVRnNkNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMENpQWdJQ0JtY21GdFpWOWthV2NnTlFvZ0lDQWdZbm9nVUc5dmJDNTBhV05yVTNCaFkybHVaMVJ2VFdGNFRHbHhkV2xrYVhSNVVHVnlWR2xqYTE5MFpYSnVZWEo1WDJaaGJITmxRRE14Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREVLSUNBZ0lHSXJDZ3BRYjI5c0xuUnBZMnRUY0dGamFXNW5WRzlOWVhoTWFYRjFhV1JwZEhsUVpYSlVhV05yWDNSbGNtNWhjbmxmYldWeVoyVkFNekk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1lpVUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZzRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaVBqMEtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdaeVlXMWxYMlJwWnlBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpTFFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjSFZ6YUdsdWRDQTRPRGN5TnpJS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdabkpoYldWZlpHbG5JRFlLSUNBZ0lHSjZJRkJ2YjJ3dWRHbGphMU53WVdOcGJtZFViMDFoZUV4cGNYVnBaR2wwZVZCbGNsUnBZMnRmZEdWeWJtRnllVjltWVd4elpVQTBNUW9nSUNBZ1puSmhiV1ZmWkdsbklEVUtJQ0FnSUdKNklGQnZiMnd1ZEdsamExTndZV05wYm1kVWIwMWhlRXhwY1hWcFpHbDBlVkJsY2xScFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek9Rb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JpTFFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeENpQWdJQ0JpS3dvS1VHOXZiQzUwYVdOclUzQmhZMmx1WjFSdlRXRjRUR2x4ZFdsa2FYUjVVR1Z5VkdsamExOTBaWEp1WVhKNVgyMWxjbWRsUURRd09nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR0l2Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVFvZ0lDQWdZaXNLQ2xCdmIyd3VkR2xqYTFOd1lXTnBibWRVYjAxaGVFeHBjWFZwWkdsMGVWQmxjbFJwWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwT0RvS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJckNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUhOM1lYQUtJQ0FnSUdJdkNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tVRzl2YkM1MGFXTnJVM0JoWTJsdVoxUnZUV0Y0VEdseGRXbGthWFI1VUdWeVZHbGphMTkwWlhKdVlYSjVYMlpoYkhObFFETTVPZ29nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdJZ1VHOXZiQzUwYVdOclUzQmhZMmx1WjFSdlRXRjRUR2x4ZFdsa2FYUjVVR1Z5VkdsamExOTBaWEp1WVhKNVgyMWxjbWRsUURRd0NncFFiMjlzTG5ScFkydFRjR0ZqYVc1blZHOU5ZWGhNYVhGMWFXUnBkSGxRWlhKVWFXTnJYM1JsY201aGNubGZabUZzYzJWQU5ERTZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnWW5vZ1VHOXZiQzUwYVdOclUzQmhZMmx1WjFSdlRXRjRUR2x4ZFdsa2FYUjVVR1Z5VkdsamExOTBaWEp1WVhKNVgyWmhiSE5sUURRMkNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVpnb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFS0lDQWdJR0lyQ2dwUWIyOXNMblJwWTJ0VGNHRmphVzVuVkc5TllYaE1hWEYxYVdScGRIbFFaWEpVYVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTkRjNkNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZaThLSUNBZ0lHSWdVRzl2YkM1MGFXTnJVM0JoWTJsdVoxUnZUV0Y0VEdseGRXbGthWFI1VUdWeVZHbGphMTkwWlhKdVlYSjVYMjFsY21kbFFEUTRDZ3BRYjI5c0xuUnBZMnRUY0dGamFXNW5WRzlOWVhoTWFYRjFhV1JwZEhsUVpYSlVhV05yWDNSbGNtNWhjbmxmWm1Gc2MyVkFORFk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1lpQlFiMjlzTG5ScFkydFRjR0ZqYVc1blZHOU5ZWGhNYVhGMWFXUnBkSGxRWlhKVWFXTnJYM1JsY201aGNubGZiV1Z5WjJWQU5EY0tDbEJ2YjJ3dWRHbGphMU53WVdOcGJtZFViMDFoZUV4cGNYVnBaR2wwZVZCbGNsUnBZMnRmZEdWeWJtRnllVjltWVd4elpVQXpNVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCaUlGQnZiMnd1ZEdsamExTndZV05wYm1kVWIwMWhlRXhwY1hWcFpHbDBlVkJsY2xScFkydGZkR1Z5Ym1GeWVWOXRaWEpuWlVBek1nb0tVRzl2YkM1MGFXTnJVM0JoWTJsdVoxUnZUV0Y0VEdseGRXbGthWFI1VUdWeVZHbGphMTkwWlhKdVlYSjVYMlpoYkhObFFEazZDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWWlCUWIyOXNMblJwWTJ0VGNHRmphVzVuVkc5TllYaE1hWEYxYVdScGRIbFFaWEpVYVdOclgzUmxjbTVoY25sZmJXVnlaMlZBTVRBS0NsQnZiMnd1ZEdsamExTndZV05wYm1kVWIwMWhlRXhwY1hWcFpHbDBlVkJsY2xScFkydGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0JpZWlCUWIyOXNMblJwWTJ0VGNHRmphVzVuVkc5TllYaE1hWEYxYVdScGRIbFFaWEpVYVdOclgzUmxjbTVoY25sZlptRnNjMlZBTVRZS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdZaTBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVFvZ0lDQWdZaXNLQ2xCdmIyd3VkR2xqYTFOd1lXTnBibWRVYjAxaGVFeHBjWFZwWkdsMGVWQmxjbFJwWTJ0ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TnpvS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlMd29nSUNBZ1lpQlFiMjlzTG5ScFkydFRjR0ZqYVc1blZHOU5ZWGhNYVhGMWFXUnBkSGxRWlhKVWFXTnJYM1JsY201aGNubGZiV1Z5WjJWQU1UZ0tDbEJ2YjJ3dWRHbGphMU53WVdOcGJtZFViMDFoZUV4cGNYVnBaR2wwZVZCbGNsUnBZMnRmZEdWeWJtRnllVjltWVd4elpVQXhOam9LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCaUlGQnZiMnd1ZEdsamExTndZV05wYm1kVWIwMWhlRXhwY1hWcFpHbDBlVkJsY2xScFkydGZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE53b0tVRzl2YkM1MGFXTnJVM0JoWTJsdVoxUnZUV0Y0VEdseGRXbGthWFI1VUdWeVZHbGphMTkwWlhKdVlYSjVYMlpoYkhObFFESTZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1abVptWm1ZS0lDQWdJR0ltQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHSWdVRzl2YkM1MGFXTnJVM0JoWTJsdVoxUnZUV0Y0VEdseGRXbGthWFI1VUdWeVZHbGphMTkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjak16TGw5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZktDa2dMVDRnZFdsdWREWTBPZ3BmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHpvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlgxOWZYMkpoY21WZlkzSmxZWFJsWDE5QU9Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9EWmhaVFUzT0dZZ01IZzNOemxoWldWallTQXdlR0U1Tm1WbU9UZzVJQzh2SUcxbGRHaHZaQ0FpVUc5dmJDNTBhV05yVTNCaFkybHVaMVJ2VFdGNFRHbHhkV2xrYVhSNVVHVnlWR2xqYXloMWFXNTBOalFwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpVkdsamEwSnBkRzFoY0M1dVpYaDBTVzVwZEdsaGJHbDZaV1JVYVdOclYybDBhR2x1VDI1bFYyOXlaRjlmWTJoMWJtdGZNVjlmWTJoMWJtdGZNU2hpZVhSbFcxMHNkV2x1ZERZMExIVnBiblEyTkN4aWIyOXNMSFZwYm5RMk5DeGliMjlzTEhWcGJuUTJOQ2tvWW05dmJDeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSmZYMmx1YVhSZlh5aDFhVzUwTmpRc2RXbHVkRFkwTEdKNWRHVmJYU2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJek15NVFiMjlzTG5ScFkydFRjR0ZqYVc1blZHOU5ZWGhNYVhGMWFXUnBkSGxRWlhKVWFXTnJXM0p2ZFhScGJtZGRJRlJwWTJ0Q2FYUnRZWEF1Ym1WNGRFbHVhWFJwWVd4cGVtVmtWR2xqYTFkcGRHaHBiazl1WlZkdmNtUmZYMk5vZFc1clh6RmZYMk5vZFc1clh6RWdYMTlwYm1sMFgxOEtJQ0FnSUdWeWNnb0tYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMTlmWDE5aVlYSmxYMk55WldGMFpWOWZRRGs2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU16TXVVRzl2YkM1MGFXTnJVM0JoWTJsdVoxUnZUV0Y0VEdseGRXbGthWFI1VUdWeVZHbGphMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTkxYm1semQyRndMWFkwTDJOdmJuUnlZV04wY3k5amIzSmxMMUJ2YjJ4TllXNWhaMlZ5TG5OdmJDNVFiMjlzVFdGdVlXZGxjbDlmU0dWc2NHVnlNek11VUc5dmJDNTBhV05yVTNCaFkybHVaMVJ2VFdGNFRHbHhkV2xrYVhSNVVHVnlWR2xqYTF0eWIzVjBhVzVuWFRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJek15NVFiMjlzTG5ScFkydFRjR0ZqYVc1blZHOU5ZWGhNYVhGMWFXUnBkSGxRWlhKVWFXTnJXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnWjJ4dlltRnNJRWR5YjNWd1UybDZaUW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ0ZFhOMElHSmxJR05oYkd4bFpDQnBiaUJuY205MWNBb2dJQ0FnWjNSNGJpQXdJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6SWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSFZ1WVhWMGFHOXlhWHBsWkNCallXeHNaWElLSUNBZ0lHZDBlRzRnTUNCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ6Wlc1a1pYSWdiV2x6YldGMFkyZ0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwzVnVhWE4zWVhBdGRqUXZZMjl1ZEhKaFkzUnpMMk52Y21VdlVHOXZiRTFoYm1GblpYSXVjMjlzTGxCdmIyeE5ZVzVoWjJWeVgxOUlaV3h3WlhJek15NVFiMjlzTG5ScFkydFRjR0ZqYVc1blZHOU5ZWGhNYVhGMWFXUnBkSGxRWlhKVWFXTnJXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUExSUM4dklDSndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCM2NtOXVaeUJ3Y21WMklHTm9kVzVyQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQnRaWFJvYjJRS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5MWJtbHpkMkZ3TFhZMEwyTnZiblJ5WVdOMGN5OWpiM0psTDFCdmIyeE5ZVzVoWjJWeUxuTnZiQzVRYjI5c1RXRnVZV2RsY2w5ZlNHVnNjR1Z5TXpNdVVHOXZiQzUwYVdOclUzQmhZMmx1WjFSdlRXRjRUR2x4ZFdsa2FYUjVVR1Z5VkdsamExdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdVRzl2YkM1MGFXTnJVM0JoWTJsdVoxUnZUV0Y0VEdseGRXbGthWFI1VUdWeVZHbGphd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1UWIyOXNUV0Z1WVdkbGNsOWZTR1ZzY0dWeU16TXVWR2xqYTBKcGRHMWhjQzV1WlhoMFNXNXBkR2xoYkdsNlpXUlVhV05yVjJsMGFHbHVUMjVsVjI5eVpGOWZZMmgxYm10Zk1WOWZZMmgxYm10Zk1WdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbFJwWTJ0Q2FYUnRZWEF1Ym1WNGRFbHVhWFJwWVd4cGVtVmtWR2xqYTFkcGRHaHBiazl1WlZkdmNtUmZYMk5vZFc1clh6RmZYMk5vZFc1clh6RTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtSnZiMndLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5vZ1ZHbGphMEpwZEcxaGNDNXVaWGgwU1c1cGRHbGhiR2w2WldSVWFXTnJWMmwwYUdsdVQyNWxWMjl5WkY5ZlkyaDFibXRmTVY5ZlkyaDFibXRmTVY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lHZHNiMkpoYkNCSGNtOTFjRk5wZW1VS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2JYVnpkQ0JpWlNCallXeHNaV1FnYVc0Z1ozSnZkWEFLSUNBZ0lHZDBlRzRnTUNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCMWJtRjFkR2h2Y21sNlpXUWdZMkZzYkdWeUNpQWdJQ0JuZEhodUlEQWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2MyVnVaR1Z5SUcxcGMyMWhkR05vQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUZScFkydENhWFJ0WVhBdWJtVjRkRWx1YVhScFlXeHBlbVZrVkdsamExZHBkR2hwYms5dVpWZHZjbVJmWDJOb2RXNXJYekZmWDJOb2RXNXJYekZmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdZMmgxYm1zS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk5oSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0p6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJRzFsZEdodlpBb0tWR2xqYTBKcGRHMWhjQzV1WlhoMFNXNXBkR2xoYkdsNlpXUlVhV05yVjJsMGFHbHVUMjVsVjI5eVpGOWZZMmgxYm10Zk1WOWZZMmgxYm10Zk1WOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1JwWnlBekNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmRXNXBjM2RoY0MxMk5DOWpiMjUwY21GamRITXZZMjl5WlM5UWIyOXNUV0Z1WVdkbGNpNXpiMnd1VUc5dmJFMWhibUZuWlhKZlgwaGxiSEJsY2pNekxsOWZhVzVwZEY5ZlczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tYMTlwYm1sMFgxODZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCaGJISmxZV1I1SUdsdWFYUnBZV3hwZW1Wa0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKdklnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpY0NJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjak16TG1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVBUWdBQWlZSkFRRWcvLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy84QmJ3QWhBUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFYQUJjeUNBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBUVZIM3gxUWdGR2lnRUJKRWNFSzBtTC94WkpnQ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUlBQUFLS0FBUUtxSzZsQkFRT0FJUC8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vQUFBQXE0d0RnWmpzeWYvLy8vLy8vd0VXakFLTEF5Y0hwMG1NQlNzb1R3Sk5LNmxKakFaQkFLU0xCVUVBbWltTEE2RW9vSXNDVEtJcFRLRW9vQ2NFb0l3RWl3VkJBSHdwaXdPaEtLQ0xBa3lxSndlbkt5aFBBazJMQkV5aEp3U3FqQUNCNkpNMkZvd0Jpd1pCQUQ2TEJVRUFOQ21MQTZFb29Jc0JUS0lwVEtFb29DY0VvSXNBb1NjRXFpaWdKd1NxZ0JELy8vLy8vLy8vLy8vLy8vLy8vLy8vVEtLTUFJbUxBMEwvellzRlFRQU5LWXNEb1NpZ2l3Rk1va0wveElzRFF2LzBpd05DLzRXTEEwTC9aNHNGUVFBTktZc0RvU2lnaXdKTW9rTC9Yb3NEUXYvMGdBUC8vLytzakFOQy94Y3hHMEVBSkRFWkZFUXhHRVNDQXdTR3JsZVBCSGVhN3NvRXFXNzVpVFlhQUk0REFBa0FYQURlQURFWkZERVlGQkJETmhvQlNSVWpFa1FYS21SQkFEQXlCQ1VQUkRNQUdDcGtFa1F6QUFBeEFCSkVKd1ZrUVFBWE1SWWlDVGdZSndWa0VrUXhGaUlKT1JvQUp3WmtFa1JKaVA1SFNSV0JJQTVFZ1NDdnF5Y0lURkN3SWtNMkdnRkpKRmtsQ0V3VkVrUTJHZ0lWSXhKRU5ob0RGU01TUkRZYUJCVWlFa1EyR2dVVkl4SkVOaG9HU1JVaUVrUWtVellhQjBrVkl4SkVGeXBrUVFBd01nUWxEMFF6QUJncVpCSkVNd0FBTVFBU1JDY0ZaRUVBRnpFV0lnazRHQ2NGWkJKRU1SWWlDVGthQUNjR1pCSkVnQUVBSkVzRFZFc0JGbEFuQ0V4UXNDSkROaG9CU1JVakVrUVhOaG9DU1JVakVrUVhOaG9EU1NSWkpRaExBUlVTUkZjQ0FDcGtGRVFxVHdObkp3VlBBbWNuQmt4bklrTT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
