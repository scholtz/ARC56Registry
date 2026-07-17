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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.PoolManager__Helper31_feaeaf67
{


    //
    // Helper contract 31 for PoolManager
    //
    public class PoolManager__Helper31Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PoolManager__Helper31Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class TickMathGetSqrtPriceAtTickChunk0Return : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field0 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field1 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field2 { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Field3 { get; set; }

                public ulong Field4 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TickMathGetSqrtPriceAtTickChunk0Return Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TickMathGetSqrtPriceAtTickChunk0Return();
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
                    var vField3 = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Field3 = vField3;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TickMathGetSqrtPriceAtTickChunk0Return);
                }
                public bool Equals(TickMathGetSqrtPriceAtTickChunk0Return? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TickMathGetSqrtPriceAtTickChunk0Return left, TickMathGetSqrtPriceAtTickChunk0Return right)
                {
                    return EqualityComparer<TickMathGetSqrtPriceAtTickChunk0Return>.Default.Equals(left, right);
                }
                public static bool operator !=(TickMathGetSqrtPriceAtTickChunk0Return left, TickMathGetSqrtPriceAtTickChunk0Return right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="tick"> </param>
        public async Task<Structs.TickMathGetSqrtPriceAtTickChunk0Return> TickMathGetSqrtPriceAtTickChunk0(ulong tick, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 205, 253, 180 };
            var tickAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickAbi.From(tick);

            var result = await base.SimApp(new List<object> { abiHandle, tickAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TickMathGetSqrtPriceAtTickChunk0Return.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TickMathGetSqrtPriceAtTickChunk0_Transactions(ulong tick, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 205, 253, 180 };
            var tickAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tickAbi.From(tick);

            return await base.MakeTransactionList(new List<object> { abiHandle, tickAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUG9vbE1hbmFnZXJfX0hlbHBlcjMxIiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCAzMSBmb3IgUG9vbE1hbmFnZXIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVGlja01hdGhHZXRTcXJ0UHJpY2VBdFRpY2tDaHVuazBSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJmaWVsZDMiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImZpZWxkNCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiVGlja01hdGguZ2V0U3FydFByaWNlQXRUaWNrX19jaHVua18wIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDY0KSIsInN0cnVjdCI6IlRpY2tNYXRoR2V0U3FydFByaWNlQXRUaWNrQ2h1bmswUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJfX2luaXRfXyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTEzMl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogYWxyZWFkeSBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NF0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogbXVzdCBiZSBjYWxsZWQgaW4gZ3JvdXAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOThdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IHNlbmRlciBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogdW5hdXRob3JpemVkIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxM10sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBjaHVuayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNl0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBtZXRob2QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTE3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEyNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzIsMTEwMSwxMTEwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTc0LDEwMjBdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExOV0sImVycm9yTWVzc2FnZSI6InJldmVydCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjak14TGw5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZktDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURnZ01TQXpNaUF3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0lEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQ0FpYnlJZ0luQWlJREI0T0RBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaUJmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OTFibWx6ZDJGd0xYWTBMMk52Ym5SeVlXTjBjeTlqYjNKbEwxQnZiMnhOWVc1aFoyVnlMbk52YkM1RGRYTjBiMjFTWlhabGNuUXVjbVYyWlhKMFYybDBhQ2d5S1Y4eEtITmxiR1ZqZEc5eU9pQmllWFJsY3l3Z2RtRnNkV1U2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LUTNWemRHOXRVbVYyWlhKMExuSmxkbVZ5ZEZkcGRHZzZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJR1Z5Y2lBdkx5QnlaWFpsY25RS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqTXhMbDlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmS0NrZ0xUNGdkV2x1ZERZME9ncGZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYem9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWDE5ZlgySmhjbVZmWTNKbFlYUmxYMTlBT0FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WWpSalpHWmtZalFnTUhoaE9UWmxaams0T1NBdkx5QnRaWFJvYjJRZ0lsUnBZMnROWVhSb0xtZGxkRk54Y25SUWNtbGpaVUYwVkdsamExOWZZMmgxYm10Zk1DaDFhVzUwTmpRcEtIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWDE5cGJtbDBYMThvZFdsdWREWTBMSFZwYm5RMk5DeGllWFJsVzEwcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUZScFkydE5ZWFJvTG1kbGRGTnhjblJRY21salpVRjBWR2xqYTE5ZlkyaDFibXRmTUNCZlgybHVhWFJmWHdvZ0lDQWdaWEp5Q2dwZlgzQjFlV0ZmWVhKak5GOXliM1YwWlhKZlgxOWZYMkpoY21WZlkzSmxZWFJsWDE5QU9Eb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDNWdWFYTjNZWEF0ZGpRdlkyOXVkSEpoWTNSekwyTnZjbVV2VUc5dmJFMWhibUZuWlhJdWMyOXNMbEJ2YjJ4TllXNWhaMlZ5WDE5SVpXeHdaWEl6TVM1VWFXTnJUV0YwYUM1blpYUlRjWEowVUhKcFkyVkJkRlJwWTJ0ZlgyTm9kVzVyWHpCYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncFVhV05yVFdGMGFDNW5aWFJUY1hKMFVISnBZMlZCZEZScFkydGZYMk5vZFc1clh6QTZDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWkhWd2JpQXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUZScFkydE5ZWFJvTG1kbGRGTnhjblJRY21salpVRjBWR2xqYTE5ZlkyaDFibXRmTUY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lHZHNiMkpoYkNCSGNtOTFjRk5wZW1VS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUcxMWMzUWdZbVVnWTJGc2JHVmtJR2x1SUdkeWIzVndDaUFnSUNCbmRIaHVJREFnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZFc1aGRYUm9iM0pwZW1Wa0lHTmhiR3hsY2dvZ0lDQWdaM1I0YmlBd0lGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhObGJtUmxjaUJ0YVhOdFlYUmphQW9nSUNBZ1lubDBaV05mTXlBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUJVYVdOclRXRjBhQzVuWlhSVGNYSjBVSEpwWTJWQmRGUnBZMnRmWDJOb2RXNXJYekJmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdZMmgxYm1zS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk5oSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdiV1YwYUc5a0NncFVhV05yVFdGMGFDNW5aWFJUY1hKMFVISnBZMlZCZEZScFkydGZYMk5vZFc1clh6QmZZV1owWlhKZmFXWmZaV3h6WlVBMU9nb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQTRNREF3TURBS0lDQWdJR0l2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TWdvZ0lDQWdZaVVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCaWVpQlVhV05yVFdGMGFDNW5aWFJUY1hKMFVISnBZMlZCZEZScFkydGZYMk5vZFc1clh6QmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1NREF3TURBd0NpQWdJQ0JpZkFvZ0lDQWdZblZ5ZVNBeUNncFVhV05yVFdGMGFDNW5aWFJUY1hKMFVISnBZMlZCZEZScFkydGZYMk5vZFc1clh6QmZkR1Z5Ym1GeWVWOXRaWEpuWlVBNU9nb2dJQ0FnWkdsbklERUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZzRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaVBqMEtJQ0FnSUdKNklGUnBZMnROWVhSb0xtZGxkRk54Y25SUWNtbGpaVUYwVkdsamExOWZZMmgxYm10Zk1GOTBaWEp1WVhKNVgyWmhiSE5sUURFeENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJdkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abENpQWdJQ0JpZkFvS1ZHbGphMDFoZEdndVoyVjBVM0Z5ZEZCeWFXTmxRWFJVYVdOclgxOWphSFZ1YTE4d1gzUmxjbTVoY25sZmJXVnlaMlZBTVRJNkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBekNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWWw0S0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW5WeWVTQTNDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0J3ZFhOb2FXNTBJRGc0TnpJM01nb2dJQ0FnYVhSdllnb2dJQ0FnWWo0S0lDQWdJR0o2SUZScFkydE5ZWFJvTG1kbGRGTnhjblJRY21salpVRjBWR2xqYTE5ZlkyaDFibXRmTUY5aFpuUmxjbDlwWmw5bGJITmxRREUwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpZV3hzYzNWaUlFTjFjM1J2YlZKbGRtVnlkQzV5WlhabGNuUlhhWFJvQ2dwVWFXTnJUV0YwYUM1blpYUlRjWEowVUhKcFkyVkJkRlJwWTJ0ZlgyTm9kVzVyWHpCZllXWjBaWEpmYVdaZlpXeHpaVUF4TkRvS0lDQWdJR1JwWnlBMENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBeENpQWdJQ0JpSmdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURGbVptWmpZamt6TTJKa05tWmhaRE0zWVdFeVpERTJNbVF4WVRVNU5EQXdNUW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpWGdvZ0lDQWdZblZ5ZVNBMUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lHbDBiMklLSUNBZ0lHSW1DaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEVUtJQ0FnSUdJaFBRb2dJQ0FnWW5vZ1ZHbGphMDFoZEdndVoyVjBVM0Z5ZEZCeWFXTmxRWFJVYVdOclgxOWphSFZ1YTE4d1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRZS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobVptWTVOekkzTWpNM00yUTBNVE15TlRsaE5EWTVPVEExT0RCbE1qRXpZUW9nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpOEtJQ0FnSUdKMWNua2dOQW9LVkdsamEwMWhkR2d1WjJWMFUzRnlkRkJ5YVdObFFYUlVhV05yWDE5amFIVnVhMTh3WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFk2Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTFDaUFnSUNCaUpnb2dJQ0FnWkdsbklETUtJQ0FnSUdJaFBRb2dJQ0FnWW5vZ1ZHbGphMDFoZEdndVoyVjBVM0Z5ZEZCeWFXTmxRWFJVYVdOclgxOWphSFZ1YTE4d1gyRm1kR1Z5WDJsbVgyVnNjMlZBTVRnS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobVptWXlaVFV3WmpWbU5qVTJPVE15WldZeE1qTTFOMk5tTTJNM1ptUmpZd29nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpOEtJQ0FnSUdKMWNua2dOQW9LVkdsamEwMWhkR2d1WjJWMFUzRnlkRkJ5YVdObFFYUlVhV05yWDE5amFIVnVhMTh3WDJGbWRHVnlYMmxtWDJWc2MyVkFNVGc2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRFVLSUNBZ0lHSW1DaUFnSUNCa2FXY2dNd29nSUNBZ1lpRTlDaUFnSUNCaWVpQlVhV05yVFdGMGFDNW5aWFJUY1hKMFVISnBZMlZCZEZScFkydGZYMk5vZFc1clh6QmZZV1owWlhKZmFXWmZaV3h6WlVBeU1Bb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWm1aVFZqWVdOaE4yVXhNR1UwWlRZeFl6TTJNalJsWVdFd09UUXhZMlF3Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlMd29nSUNBZ1luVnllU0EwQ2dwVWFXTnJUV0YwYUM1blpYUlRjWEowVUhKcFkyVkJkRlJwWTJ0ZlgyTm9kVzVyWHpCZllXWjBaWEpmYVdaZlpXeHpaVUF5TURvS0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUExQ2lBZ0lDQmlKZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHSWhQUW9nSUNBZ1lub2dWR2xqYTAxaGRHZ3VaMlYwVTNGeWRGQnlhV05sUVhSVWFXTnJYMTlqYUhWdWExOHdYMkZtZEdWeVgybG1YMlZzYzJWQU1qSUtJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1abU5pT1RnME0yUTJNR1kyTVRVNVl6bGtZalU0T0RNMVl6a3lOalkwTkFvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaThLSUNBZ0lHSjFjbmtnTkFvS1ZHbGphMDFoZEdndVoyVjBVM0Z5ZEZCeWFXTmxRWFJVYVdOclgxOWphSFZ1YTE4d1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWpJNkNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBMUNpQWdJQ0JpSmdvZ0lDQWdaR2xuSURNS0lDQWdJR0loUFFvZ0lDQWdZbm9nVkdsamEwMWhkR2d1WjJWMFUzRnlkRkJ5YVdObFFYUlVhV05yWDE5amFIVnVhMTh3WDJGbWRHVnlYMmxtWDJWc2MyVkFNalFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhtWmprM00ySTBNV1poT1Roak1EZ3hORGN5WlRZNE9UWmtabUl5TlRSak1Bb2dJQ0FnWWlvS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWk4S0lDQWdJR0oxY25rZ05Bb0tWR2xqYTAxaGRHZ3VaMlYwVTNGeWRGQnlhV05sUVhSVWFXTnJYMTlqYUhWdWExOHdYMkZtZEdWeVgybG1YMlZzYzJWQU1qUTZDaUFnSUNCd2RYTm9hVzUwSURZMENpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWWlZS0lDQWdJR1JwWnlBekNpQWdJQ0JpSVQwS0lDQWdJR0o2SUZScFkydE5ZWFJvTG1kbGRGTnhjblJRY21salpVRjBWR2xqYTE5ZlkyaDFibXRmTUY5aFpuUmxjbDlwWmw5bGJITmxRREkyQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Wm1ZeVpXRXhOalEyTm1NNU5tRXpPRFF6WldNM09HSXpNalppTlRJNE5qRUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJdkNpQWdJQ0JpZFhKNUlEUUtDbFJwWTJ0TllYUm9MbWRsZEZOeGNuUlFjbWxqWlVGMFZHbGphMTlmWTJoMWJtdGZNRjloWm5SbGNsOXBabDlsYkhObFFESTJPZ29nSUNBZ2NIVnphR2x1ZENBeE1qZ0tJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTFDaUFnSUNCaUpnb2dJQ0FnWkdsbklETUtJQ0FnSUdJaFBRb2dJQ0FnWW5vZ1ZHbGphMDFoZEdndVoyVjBVM0Z5ZEZCeWFXTmxRWFJVYVdOclgxOWphSFZ1YTE4d1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWpnS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobVpUVmtaV1V3TkRaaE9UbGhNbUU0TVRGak5EWXhaakU1Tmpsak16QTFNd29nSUNBZ1lpb0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpOEtJQ0FnSUdKMWNua2dOQW9LVkdsamEwMWhkR2d1WjJWMFUzRnlkRkJ5YVdObFFYUlVhV05yWDE5amFIVnVhMTh3WDJGbWRHVnlYMmxtWDJWc2MyVkFNamc2Q2lBZ0lDQndkWE5vYVc1MElESTFOZ29nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRFVLSUNBZ0lHSW1DaUFnSUNCa2FXY2dNd29nSUNBZ1lpRTlDaUFnSUNCaWVpQlVhV05yVFdGMGFDNW5aWFJUY1hKMFVISnBZMlZCZEZScFkydGZYMk5vZFc1clh6QmZZV1owWlhKZmFXWmZaV3h6WlVBek1Bb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWmpZbVU0Tm1NM09UQXdZVGc0WVdWa1kyWm1Zemd6WWpRM09XRmhNMkUwQ2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlMd29nSUNBZ1luVnllU0EwQ2dwVWFXTnJUV0YwYUM1blpYUlRjWEowVUhKcFkyVkJkRlJwWTJ0ZlgyTm9kVzVyWHpCZllXWjBaWEpmYVdaZlpXeHpaVUF6TURvS0lDQWdJSEIxYzJocGJuUWdOVEV5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTlFvZ0lDQWdZaVlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmlJVDBLSUNBZ0lHSjZJRlJwWTJ0TllYUm9MbWRsZEZOeGNuUlFjbWxqWlVGMFZHbGphMTlmWTJoMWJtdGZNRjloWm5SbGNsOXBabDlsYkhObFFETXlDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRaams0TjJFM01qVXpZV00wTVRNeE56Wm1NbUl3TnpSalpqYzRNVFZsTlRRS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0l2Q2lBZ0lDQmlkWEo1SURRS0NsUnBZMnROWVhSb0xtZGxkRk54Y25SUWNtbGpaVUYwVkdsamExOWZZMmgxYm10Zk1GOWhablJsY2w5cFpsOWxiSE5sUURNeU9nb2dJQ0FnY0hWemFHbHVkQ0F4TURJMENpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWWlZS0lDQWdJR1JwWnlBekNpQWdJQ0JpSVQwS0lDQWdJR0o2SUZScFkydE5ZWFJvTG1kbGRGTnhjblJRY21salpVRjBWR2xqYTE5ZlkyaDFibXRmTUY5aFpuUmxjbDlwWmw5bGJITmxRRE0wQ2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WmpNek9USmlNRGd5TW1JM01EQXdOVGswTUdNM1lUTTVPR1UwWWpjd1pqTUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJdkNpQWdJQ0JpZFhKNUlEUUtDbFJwWTJ0TllYUm9MbWRsZEZOeGNuUlFjbWxqWlVGMFZHbGphMTlmWTJoMWJtdGZNRjloWm5SbGNsOXBabDlsYkhObFFETTBPZ29nSUNBZ2NIVnphR2x1ZENBeU1EUTRDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dOUW9nSUNBZ1lpWUtJQ0FnSUdScFp5QXpDaUFnSUNCaUlUMEtJQ0FnSUdKNklGUnBZMnROWVhSb0xtZGxkRk54Y25SUWNtbGpaVUYwVkdsamExOWZZMmgxYm10Zk1GOWhablJsY2w5cFpsOWxiSE5sUURNMkNpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpUY3hOVGswTnpWaE1tTXlPV0kzTkRRellqSTVZemRtWVRabE9EZzVaRGtLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXZDaUFnSUNCaWRYSjVJRFFLQ2xScFkydE5ZWFJvTG1kbGRGTnhjblJRY21salpVRjBWR2xqYTE5ZlkyaDFibXRmTUY5aFpuUmxjbDlwWmw5bGJITmxRRE0yT2dvZ0lDQWdjSFZ6YUdsdWRDQTBNRGsyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTlFvZ0lDQWdZaVlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmlJVDBLSUNBZ0lHSjZJRlJwWTJ0TllYUm9MbWRsZEZOeGNuUlFjbWxqWlVGMFZHbGphMTlmWTJoMWJtdGZNRjloWm5SbGNsOXBabDlsYkhObFFETTRDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRaREE1TjJZelltUm1aREl3TWpKaU9EZzBOV0ZrT0dZM09USmhZVFU0TWpVS0lDQWdJR0lxQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0l2Q2lBZ0lDQmlkWEo1SURRS0NsUnBZMnROWVhSb0xtZGxkRk54Y25SUWNtbGpaVUYwVkdsamExOWZZMmgxYm10Zk1GOWhablJsY2w5cFpsOWxiSE5sUURNNE9nb2dJQ0FnY0hWemFHbHVkQ0E0TVRreUNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWWlZS0lDQWdJR1JwWnlBekNpQWdJQ0JpSVQwS0lDQWdJR0o2SUZScFkydE5ZWFJvTG1kbGRGTnhjblJRY21salpVRjBWR2xqYTE5ZlkyaDFibXRmTUY5aFpuUmxjbDlwWmw5bGJITmxRRFF3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WVRsbU56UTJORFl5WkRnM01HWmtaamhoTmpWa1l6Rm1PVEJsTURZeFpUVUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJdkNpQWdJQ0JpZFhKNUlEUUtDbFJwWTJ0TllYUm9MbWRsZEZOeGNuUlFjbWxqWlVGMFZHbGphMTlmWTJoMWJtdGZNRjloWm5SbGNsOXBabDlsYkhObFFEUXdPZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1pHbG5JRFVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmlmQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQTRNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWZBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1ZHbGphMDFoZEdndVoyVjBVM0Z5ZEZCeWFXTmxRWFJVYVdOclgxOWphSFZ1YTE4d1gzUmxjbTVoY25sZlptRnNjMlZBTVRFNkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJdkNpQWdJQ0JpSUZScFkydE5ZWFJvTG1kbGRGTnhjblJRY21salpVRjBWR2xqYTE5ZlkyaDFibXRmTUY5MFpYSnVZWEo1WDIxbGNtZGxRREV5Q2dwVWFXTnJUV0YwYUM1blpYUlRjWEowVUhKcFkyVkJkRlJwWTJ0ZlgyTm9kVzVyWHpCZmRHVnlibUZ5ZVY5bVlXeHpaVUE0T2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Wm1abVptWm1DaUFnSUNCaUpnb2dJQ0FnWW5WeWVTQXlDaUFnSUNCaUlGUnBZMnROWVhSb0xtZGxkRk54Y25SUWNtbGpaVUYwVkdsamExOWZZMmgxYm10Zk1GOTBaWEp1WVhKNVgyMWxjbWRsUURrS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZkVzVwYzNkaGNDMTJOQzlqYjI1MGNtRmpkSE12WTI5eVpTOVFiMjlzVFdGdVlXZGxjaTV6YjJ3dVVHOXZiRTFoYm1GblpYSmZYMGhsYkhCbGNqTXhMbDlmYVc1cGRGOWZXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWDE5cGJtbDBYMTg2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ1lXeHlaV0ZrZVNCcGJtbDBhV0ZzYVhwbFpBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJ5SUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5BaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12ZFc1cGMzZGhjQzEyTkM5amIyNTBjbUZqZEhNdlkyOXlaUzlRYjI5c1RXRnVZV2RsY2k1emIyd3VVRzl2YkUxaGJtRm5aWEpmWDBobGJIQmxjak14TG1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVDQUVnQUNZRklRRUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUNBQUFBQUFBQUFBQUFBQUFBQUFBQUFCQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUZ2QVhBZ2dBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJDQUFTS0FnQUFNUnRCQUIweEdSUkVNUmhFZ2dJRXRNMzl0QVNwYnZtSk5ob0FqZ0lBQ1FPdEFERVpGREVZRkJCREpVY0ROaG9CU1JVaUVrUVhLbVJCQURBeUJJRUNEMFF6QUJncVpCSkVNd0FBTVFBU1JDdGtRUUFYTVJZakNUZ1lLMlFTUkRFV0l3azVHZ0NBQVhOa0VrUkpGa21BSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWdBQUFvb0FCQXFxQUFLbEJBeWlBSVAvLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vL0FBQUFxMFVDU3dFbkJLZEJBdk5MQVNjRW9vQWcvLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy82clNVc0RTVTREb0NpcXJVbE9Ba1VISXE5TVVFa1ZJZ2xiUlFLQjZKTTJGcVZCQUFlQUFFc0JpUDdpU3dSSmdBRUJySUFSQWYvOHVUTzliNjAzcWkwV0xScFpRQUdqS0txQUVRRUFBQUFBQUFBQUFBQUFBQUFBQUFBQXJVVUZnUUlXckNVV1NVVUZxVUVBRzBzRGdCRC8rWEp5TnoxQk1sbWthWkJZRGlFNm95aXFLYUpGQklFRUZrc0ZyRXNEcVVFQUcwc0RnQkQvOHVVUFgyVnBNdThTTlh6engvM01veWlxS2FKRkJDSVdTd1dzU3dPcFFRQWJTd09BRVAvbHlzcCtFT1RtSERZazZxQ1VITkNqS0tvcG9rVUVnUkFXU3dXc1N3T3BRUUFiU3dPQUVQL0xtRVBXRDJGWnlkdFlnMXlTWmtTaktLb3Bva1VFSkJaTEJheExBNmxCQUJ0TEE0QVEvNWM3UWZxWXdJRkhMbWlXMzdKVXdLTW9xaW1pUlFTQlFCWkxCYXhMQTZsQkFCdExBNEFRL3k2aFpHYkphamhEN0hpekpyVW9ZYU1vcWltaVJRU0JnQUVXU3dXc1N3T3BRUUFiU3dPQUVQNWQ3Z1JxbWFLb0VjUmg4WmFjTUZPaktLb3Bva1VFZ1lBQ0Zrc0ZyRXNEcVVFQUcwc0RnQkQ4dm9iSGtBcUlydHoveUR0SG1xT2tveWlxS2FKRkJJR0FCQlpMQmF4TEE2bEJBQnRMQTRBUStZZW5KVHJFRXhkdkt3ZE05NEZlVktNb3FpbWlSUVNCZ0FnV1N3V3NTd09wUVFBYlN3T0FFUE01S3dnaXR3QUZsQXg2T1k1TGNQT2pLS29wb2tVRWdZQVFGa3NGckVzRHFVRUFHMHNEZ0JEbkZaUjFvc0tiZEVPeW5IK202SW5ab3lpcUthSkZCSUdBSUJaTEJheExBNmxCQUJ0TEE0QVEwSmZ6dmYwZ0lyaUVXdGoza3FwWUphTW9xaW1pUlFTQmdFQVdTd1dzU3dPcFFRQWJTd09BRUtuM1JrWXRody9maW1YY0g1RGdZZVdqS0tvcG9rVUVKSzlMQlVrVkpBNUVTd0dyZ0NBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFnRXhRU3dWSkZTUU9SRThDcTFDQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBVUVzQkZsQ0FCQlVmZkhWTVVMQWpRMHNCSndTaVF2MHRnQVAvLy8rc1JRSkMvUEkyR2dGSkZTSVNSQmMyR2dKSkZTSVNSQmMyR2dOSkpWbUJBZ2hMQVJVU1JGY0NBQ3BrRkVRcVR3Tm5LMDhDWjRBQmMweG5JME09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
