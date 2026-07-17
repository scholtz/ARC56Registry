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

namespace Arc56.Generated.aorumbayev.puya.NamedTuplesContract_3227712a
{


    public class NamedTuplesContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NamedTuplesContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class TestTuple : AVMObjectType
            {
                public ulong A { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 B { get; set; }

                public string C { get; set; }

                public byte[] D { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vC.From(C);
                    stringRef[ret.Count] = vC.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vD.From(D);
                    ret.AddRange(vD.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TestTuple Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new TestTuple();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    var vB = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.B = vB;
                    var indexC = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vC.Decode(bytes.Skip(indexC + prefixOffset).ToArray());
                    var valueC = vC.ToValue();
                    if (valueC is string vCValue) { ret.C = vCValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vD.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueD = vD.ToValue();
                    if (valueD is byte[] vDValue) { ret.D = vDValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TestTuple);
                }
                public bool Equals(TestTuple? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TestTuple left, TestTuple right)
                {
                    return EqualityComparer<TestTuple>.Default.Equals(left, right);
                }
                public static bool operator !=(TestTuple left, TestTuple right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        /// <param name="c"> </param>
        /// <param name="d"> </param>
        public async Task<Structs.TestTuple> BuildTuple(ulong a, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 b, string c, byte[] d, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 110, 234, 206 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cAbi.From(c);
            var dAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dAbi.From(d);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, b, cAbi, dAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TestTuple.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> BuildTuple_Transactions(ulong a, AVM.ClientGenerator.ABI.ARC4.Types.UInt512 b, string c, byte[] d, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 110, 234, 206 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); cAbi.From(c);
            var dAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dAbi.From(d);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, b, cAbi, dAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> TestTuple</param>
        public async Task TestTuple(Structs.TestTuple value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 159, 91, 240 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestTuple_Transactions(Structs.TestTuple value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 111, 159, 91, 240 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTmFtZWRUdXBsZXNDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJUZXN0VHVwbGUiOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoidWludDUxMiJ9LHsibmFtZSI6ImMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZCIsInR5cGUiOiJieXRlW10ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYnVpbGRfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NTEyLHN0cmluZyxieXRlW10pIiwic3RydWN0IjoiVGVzdFR1cGxlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF90dXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ1MTIsc3RyaW5nLGJ5dGVbXSkiLCJzdHJ1Y3QiOiJUZXN0VHVwbGUiLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0OV0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcsOTNdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTVdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MCw5Nl0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjRdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTmpRS0lDQWdJQzh2SUc1aGJXVmtYM1IxY0d4bGN5OWpiMjUwY21GamRDNXdlVG94TlFvZ0lDQWdMeThnWTJ4aGMzTWdUbUZ0WldSVWRYQnNaWE5EYjI1MGNtRmpkQ2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTndvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURRMU5tVmxZV05sSURCNE5tWTVaalZpWmpBZ0x5OGdiV1YwYUc5a0lDSmlkV2xzWkY5MGRYQnNaU2gxYVc1ME5qUXNkV2x1ZERVeE1peHpkSEpwYm1jc1lubDBaVnRkS1NoMWFXNTBOalFzZFdsdWREVXhNaXh6ZEhKcGJtY3NZbmwwWlZ0ZEtTSXNJRzFsZEdodlpDQWlkR1Z6ZEY5MGRYQnNaU2dvZFdsdWREWTBMSFZwYm5RMU1USXNjM1J5YVc1bkxHSjVkR1ZiWFNrcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZblZwYkdSZmRIVndiR1ZmY205MWRHVkFNeUJ0WVdsdVgzUmxjM1JmZEhWd2JHVmZjbTkxZEdWQU5Bb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV4T2dvZ0lDQWdMeThnYm1GdFpXUmZkSFZ3YkdWekwyTnZiblJ5WVdOMExuQjVPakUxQ2lBZ0lDQXZMeUJqYkdGemN5Qk9ZVzFsWkZSMWNHeGxjME52Ym5SeVlXTjBLR0Z5WXpRdVFWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z6ZEY5MGRYQnNaVjl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdibUZ0WldSZmRIVndiR1Z6TDJOdmJuUnlZV04wTG5CNU9qTXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCdVlXMWxaRjkwZFhCc1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRVS0lDQWdJQzh2SUdOc1lYTnpJRTVoYldWa1ZIVndiR1Z6UTI5dWRISmhZM1FvWVhKak5DNUJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElEZ2dOalFnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBM01pQXZMeUEzTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb2FXNTBJRGMwSUM4dklEYzBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYm1GdFpXUmZkSFZ3YkdWekwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBYM1IxY0d4bENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKMWFXeGtYM1IxY0d4bFgzSnZkWFJsUURNNkNpQWdJQ0F2THlCdVlXMWxaRjkwZFhCc1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJRzVoYldWa1gzUjFjR3hsY3k5amIyNTBjbUZqZEM1d2VUb3hOUW9nSUNBZ0x5OGdZMnhoYzNNZ1RtRnRaV1JVZFhCc1pYTkRiMjUwY21GamRDaGhjbU0wTGtGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUc1aGJXVmtYM1IxY0d4bGN5OWpiMjUwY21GamRDNXdlVG94TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklETUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURZMENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCcGJuUmpYeklnTHk4Z05qUUtJQ0FnSUdKNlpYSnZDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR0o4Q2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQTBZd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEYzJJQzh2SURjMkNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURjNkNpQWdJQ0F2THlCdVlXMWxaRjkwZFhCc1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRVS0lDQWdJQzh2SUdOc1lYTnpJRTVoYldWa1ZIVndiR1Z6UTI5dWRISmhZM1FvWVhKak5DNUJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtNWhiV1ZrWDNSMWNHeGxjeTVqYjI1MGNtRmpkQzVPWVcxbFpGUjFjR3hsYzBOdmJuUnlZV04wTG5SbGMzUmZkSFZ3YkdVb2RtRnNkV1V1WVRvZ2RXbHVkRFkwTENCMllXeDFaUzVpT2lCaWVYUmxjeXdnZG1Gc2RXVXVZem9nWW5sMFpYTXNJSFpoYkhWbExtUTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncDBaWE4wWDNSMWNHeGxPZ29nSUNBZ0x5OGdibUZ0WldSZmRIVndiR1Z6TDJOdmJuUnlZV04wTG5CNU9qTXhMVE15Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUhSbGMzUmZkSFZ3YkdVb2MyVnNaaXdnZG1Gc2RXVTZJRlJsYzNSVWRYQnNaU2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURRZ01Bb2dJQ0FnTHk4Z2JtRnRaV1JmZEhWd2JHVnpMMk52Ym5SeVlXTjBMbkI1T2pNekNpQWdJQ0F2THlCaGMzTmxjblFnZG1Gc2RXVXVZU0E4SURFd01EQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnY0hWemFHbHVkQ0F4TURBd0lDOHZJREV3TURBS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYm1GdFpXUmZkSFZ3YkdWekwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJoYzNObGNuUWdkbUZzZFdVdVlpQThJRElxS2pZMUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBeU1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZandLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYm1GdFpXUmZkSFZ3YkdWekwyTnZiblJ5WVdOMExuQjVPak0xQ2lBZ0lDQXZMeUJoYzNObGNuUWdkbUZzZFdVdVl5NWllWFJsY3k1c1pXNW5kR2dnUGlBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lENEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdibUZ0WldSZmRIVndiR1Z6TDJOdmJuUnlZV04wTG5CNU9qTTJDaUFnSUNBdkx5QmhjM05sY25RZ2RtRnNkV1V1WkNBOVBTQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQVFCQU1SdEJBTENDQWdSRmJ1ck9CRytmVy9BMkdnQ09BZ0E2QUFJalF6RVpGRVF4R0VRMkdnRkpJMXRMQVZjSVFFc0NnVWhaU3dPQlNsbExCRThDU3dKU1Z3SUFTd1FWVHdWUEEwOENVbGNDQUlnQWJpSkRNUmtVUkRFWVJEWWFBUmMyR2dJMkdnTlhBZ0EyR2dSWEFnQlBBeFpMQXhVa0RrUWtyMDhFcTBzREZSWlhCZ0pQQkZCTEF4VVdWd1lDVHdSUVR3TlBBMUNBQWdCTVVFc0NGWUZNQ0JaWEJnSlFUd0pRVEZDQUJCVWZmSFZNVUxBaVF6RVpRUDlnTVJnVVJDSkRpZ1FBaS95QjZBY01SSXY5Z0FrQ0FBQUFBQUFBQUFDa1JJditGU0lOUkl2L01RQVNSSWs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
